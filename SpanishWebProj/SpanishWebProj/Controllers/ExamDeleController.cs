using Microsoft.AspNetCore.Mvc;
using HtmlAgilityPack;
using System.Net.Http;
using System.Threading.Tasks;

namespace SpanishWebProj.Controllers
{
    public class ExamDeleController : Controller
    {
        public async Task<IActionResult> GetExams(string url)
        {
            var content = await GetPageContent("https://examenes.cervantes.es" + url);
            return View("GetExams", content);
        }


        public async Task<IActionResult> GetExamContent(string level)
        {
            var url = "https://examenes.cervantes.es/es/dele/examenes/" + level.ToLower();
            var content = await GetPageContent(url);

            var model = new Dictionary<string, string>();
            model.Add("ExamContent", content);
            model.Add("Level", level);

            return PartialView("ExamContentPartial", model);
        }




        private async Task<string> GetPageContent(string url)
        {
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var mainContentNode = htmlDocument.DocumentNode.SelectSingleNode("//*[@id='maincontent']/article/div[2]/div[2]");

            if (mainContentNode != null)
            {
                var fileIconImages = mainContentNode.SelectNodes("//img[@class='file-icon']");
                if (fileIconImages != null)
                {
                    foreach (var imgNode in fileIconImages)
                    {
                        imgNode.Remove();
                    }
                }
                return mainContentNode.OuterHtml;
            }
            else
            {
                return "<p>Error: Main content not found.</p>";
            }
        }
    }
}
