using Domain.Entity.Worksheet;
using Domain.Models.Worksheet;
using Domain.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IWorksheetBL
    {
        IBaseResponse<List<Worksheet>> GetWorksheets();
        Task<IBaseResponse<Worksheet>> Create(Worksheet model);
        Task<bool> UploadFile(IFormFile file);
        Task<IBaseResponse<bool>> Delete(int id);

    }
}
