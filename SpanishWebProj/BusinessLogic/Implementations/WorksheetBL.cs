using BusinessLogic.Interfaces;
using DAL.Interfaces;
using DAL.Repositories;
using Domain.Entity.Quiz;
using Domain.Entity.Vocabulary;
using Domain.Entity.Worksheet;
using Domain.Enum;
using Domain.Models.Quiz;
using Domain.Models.Vocabulary;
using Domain.Models.Worksheet;
using Domain.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Implementations
{
    public class WorksheetBL : IWorksheetBL
    {
        private readonly IBaseRepository<Worksheet> _worksheetRepository;
        private readonly IBaseRepository<WorksheetCategory> _worksheetCategoryRepository;

        public WorksheetBL(IBaseRepository<Worksheet> worksheetRepository, IBaseRepository<WorksheetCategory> worksheetCategoryRepository)
        {
            _worksheetRepository = worksheetRepository;
            _worksheetCategoryRepository = worksheetCategoryRepository;
        }

        public IBaseResponse<List<Worksheet>> GetWorksheets()
        {
            try
            {
                var worksheet = _worksheetRepository.GetAll().Include(x => x.WorksheetCategory).ToList();
                if (!worksheet.Any())
                {
                    return new BaseResponse<List<Worksheet>>()
                    {
                        Description = "Nu sunt găsite referințe",
                        StatusCode = StatusCode.OK
                    };
                }

                return new BaseResponse<List<Worksheet>>()
                {
                    Data = worksheet,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<Worksheet>>()
                {
                    Description = $"[GetWorksheets] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
        //      _worksheetRepository.Create(w);
        //    return RedirectToAction("Create");
        public async Task<IBaseResponse<Worksheet>> Create(Worksheet model)
        {
            try
            {
                var worksheet = new Worksheet()
                {
                    Name = model.Name,
                    Path = model.Path,
                    Level = (TypeCourse)Convert.ToInt32(model.Level),
                    WorksheetCategoryId = model.WorksheetCategoryId,
                };
                await _worksheetRepository.Create(worksheet);

                return new BaseResponse<Worksheet>()
                {
                    StatusCode = StatusCode.OK,
                    Data = worksheet
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Worksheet>()
                {
                    Description = $"[Create] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }


        public async Task<bool> UploadFile(IFormFile file)
        {
            string path = "";
            try
            {
                if (file.Length > 0)
                {
                    path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "UploadedFiles"));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (var fileStream = new FileStream(Path.Combine(path, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
            }
        }

        public async Task<IBaseResponse<bool>> Delete(int id)
        {
            try
            {
                var worksheet = await _worksheetRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                if (worksheet == null)
                {
                    return new BaseResponse<bool>()
                    {
                        Description = "Nu este găsit",
                        Data = false
                    };
                }

                await _worksheetRepository.Delete(worksheet);

                return new BaseResponse<bool>()
                {
                    Data = true,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[DeleteWorksheet] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }


    }
}
