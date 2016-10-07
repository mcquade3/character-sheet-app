using Microsoft.AspNet.Mvc;
using CharacterSheetApp.Models;
using System;

namespace CharacterSheetApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View("Index", Equipment.GetAll());
    }

    public IActionResult Create(string EquipmentName)
    {
      Equipment.Create(EquipmentName);
      return RedirectToAction("Index");
    }
  }
}