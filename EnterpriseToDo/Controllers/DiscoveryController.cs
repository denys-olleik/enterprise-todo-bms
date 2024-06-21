using Microsoft.AspNetCore.Mvc;

namespace EnterpriseToDo.Controllers
{
  public class DiscoveryController : BaseController
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}