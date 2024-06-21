using Microsoft.AspNetCore.Mvc;

namespace EnterpriseToDo.Controllers
{
  public class HomeController : BaseController
  {
    public IActionResult Index()
    {
      return View();
    }

    [Route("careers")]
    public IActionResult Careers()
    {
      return View();
    }
  }
}