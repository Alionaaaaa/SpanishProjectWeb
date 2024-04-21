using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using Domain.Entity.Quiz;
using Domain.Entity.Worksheet;
using Domain.Models.Quiz;
using Domain.Models.Worksheet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SpanishWebProj.Controllers
{
    public class WorksheetsController : Controller
    {
        private readonly IWorksheetBL _worksheetBL;
        private readonly IBaseRepository<WorksheetCategory> _worksheetCategoryRepository;
        private readonly IBaseRepository<Worksheet> _worksheetRepository;
        public WorksheetsController(IWorksheetBL worksheetBL, IBaseRepository<WorksheetCategory> worksheetCategoryRepository, IBaseRepository<Worksheet> worksheetRepository)
        {
            _worksheetBL = worksheetBL;
            _worksheetCategoryRepository = worksheetCategoryRepository;
            _worksheetRepository = worksheetRepository;
        }

        [HttpGet]
        public IActionResult GetWorksheets()
        {
            var response = _worksheetBL.GetWorksheets();
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return View("Error", $"{response.Description}");
        }




        private readonly string wwwrootDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        public IActionResult Create()
        {
            ViewBag.getCategory = _worksheetCategoryRepository.GetAll();
            List<string> pdf = Directory.GetFiles(wwwrootDirectory, "*.pdf").Select(Path.GetFileName).ToList();
            ViewBag.PdfFiles = pdf; // Pass the list of file names using ViewBag

            return View(new Worksheet()); // Pass an empty Worksheet instance as the model
        }
        [HttpPost]
        public async Task<IActionResult> Create(Worksheet worksheet, IFormFile myFile)
        {
            if (myFile != null && myFile.Length > 0)
            {
                var uploadsDirectory = Path.Combine(wwwrootDirectory, "UploadsPDF");
                Directory.CreateDirectory(uploadsDirectory); // Create directory if it doesn't exist
                var fileName = Path.GetFileName(myFile.FileName);
                var filePath = Path.Combine(uploadsDirectory, fileName);

                // Save the file to disk
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await myFile.CopyToAsync(stream);
                }

                // Set the path property of the worksheet object to the relative path
                worksheet.Path = "/UploadsPDF/" + fileName;
            }

            // Save the worksheet object to the database
            await _worksheetRepository.Create(worksheet);

            return RedirectToAction("GetWorksheets");
        }





        //public IActionResult Create()
        //{
        //    ViewBag.getCategory = _worksheetCategoryRepository.GetAll();
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create(Worksheet w)
        //{
        //    _worksheetRepository.Create(w);
        //    return RedirectToAction("Create");


        //}





        //[HttpGet]
        //public IActionResult UploadFile()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<ActionResult> UploadFile(IFormFile file)
        //{
        //    try
        //    {
        //        // Salvează fișierul în locația specificată în proiect
        //        var filePath = "/UploadsPDF/" + file.FileName; // Ajustează calea după necesitate
        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await file.CopyToAsync(stream);
        //        }

        //        // Actualizează proprietatea Path din ViewModel cu calea către fișierul încărcat
        //        var model = new WorksheetViewModel
        //        {
        //            Name = file.FileName,
        //            Path = filePath // Salvează doar calea către fișier în baza de date
        //                            // Completează și celelalte proprietăți ale modelului, dacă este necesar
        //        };

        //        // Poți trimite modelul către metoda Create din business logic layer pentru a-l salva în baza de date
        //        var response = await _worksheetBL.Create(model);

        //        ViewBag.Message = "Fișierul a fost încărcat cu succes!";
        //    }
        //    catch (Exception)
        //    {
        //        //Log ex
        //        ViewBag.Message = "File Upload Failed";
        //    }
        //    return View();
        //}



        // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _worksheetBL.Delete(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("GetWorksheets");
            }
            return View("Error", $"{response.Description}");
        }
    }
}
