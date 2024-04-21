using BusinessLogic.Implementations;
using Microsoft.AspNetCore.Mvc;
using HtmlAgilityPack;
using System.Text;

namespace SpanishWebProj.Controllers
{
    public class ExamDeleController : Controller
    {
        private List<string> Levels = new List<string> { "A1", "A2", "B1", "B2", "C1", "C2" };

        public async Task<IActionResult> GetExams()
        {
            var content = await GetPageContent("https://examenes.cervantes.es/es/dele/examenes/a1");
            return View("GetExams", content);
        }


        private async Task<string> GetPageContent(string url)
        {
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            // Parsează conținutul HTML folosind HtmlAgilityPack
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            // Extrage elementul cu id-ul "maincontent"
            var mainContentNode = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='maincontent']/article/div[2]/div[2]");

            // Verifică dacă s-a găsit elementul
            if (mainContentNode != null)
            {
                // Elimină toate elementele <img> cu clasa "file-icon" din conținut
                var fileIconImages = mainContentNode.SelectNodes("//img[@class='file-icon']");
                if (fileIconImages != null)
                {
                    foreach (var imgNode in fileIconImages)
                    {
                        imgNode.Remove();
                    }
                }

                // Returnează conținutul HTML al elementului găsit (fără imaginile cu clasa "file-icon")
                return mainContentNode.OuterHtml;
            }
            else
            {
                // În caz contrar, returnează un mesaj de eroare sau altă logică de gestionare a lipsei elementului
                return "<p>Error: Main content not found.</p>";
            }
        }
    }
}