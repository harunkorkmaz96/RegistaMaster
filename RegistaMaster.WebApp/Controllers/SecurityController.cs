using Microsoft.AspNetCore.Mvc;
using RegistaMaster.Application.Repositories;
using RegistaMaster.Application.Services.SecurityService;
using RegistaMaster.Domain.DTOModels.LoginModels;

namespace RegistaMaster.WebApp.Controllers;

public class SecurityController(IUnitOfWork unitOfWork) : Controller
{
  private readonly IUnitOfWork _unitOfWork = unitOfWork;
  public IActionResult Index()
  {
    return View();
  }
  [HttpGet]
  public IActionResult Login(PathString url)
  {
    return View(_unitOfWork.SecurityRepository.Login(url));
  }
  [HttpPost]
  public async Task<IActionResult> Login(LoginDTO model)
  {
    var result =await _unitOfWork.SecurityRepository.Login(model.UserName,model.Password,model.Url);
    if (result == "Kullanıcı Adı veya Şifre Hatalı")
    {
      ModelState.AddModelError("All", result);
      return View(model);
    }
    return Redirect(result);
  }
  public IActionResult Logout() {
    _unitOfWork.SecurityRepository.Logout();
    return RedirectToAction("Login");
  }
}
