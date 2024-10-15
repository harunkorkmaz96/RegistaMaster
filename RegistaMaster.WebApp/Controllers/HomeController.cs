using Microsoft.AspNetCore.Mvc;
using RegistaMaster.Application.Repositories;
using RegistaMaster.Domain.DTOModels.SecurityModels;
using RegistaMaster.Domain.Enums;
using RegistaMaster.WebApp.Models;
using System.Diagnostics;

namespace RegistaMaster.WebApp.Controllers
{
  public class HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork) : Controller
  {
    private readonly ILogger<HomeController> _logger = logger;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly SessionDTO _session = unitOfWork.GetSession();

    public async Task<IActionResult> Index()
    {
      switch (_session.AuthorizationStatus)
      {
        case AuthorizationStatus.Admin:
          ViewBag.Chart = await _unitOfWork.HomeRepository.AdminChart();
          break;
        case AuthorizationStatus.TeamLeader:
          ViewBag.Chart = await _unitOfWork.HomeRepository.TeamLeaderChart(_session.Id);
          break;
        case AuthorizationStatus.Developer:
          ViewBag.Chart = await _unitOfWork.HomeRepository.DeveloperChart(_session.Id);
          break;
      }
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
