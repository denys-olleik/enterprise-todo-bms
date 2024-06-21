using CsvHelper;
using EnterpriseToDo.Common;
using EnterpriseToDo.CustomAttributes;
using EnterpriseToDo.Service;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace EnterpriseToDo.Controllers
{
    [AuthorizeWithOrganizationId]
    [Route("file")]
    public class FileController : BaseController
    {
        
    }
}