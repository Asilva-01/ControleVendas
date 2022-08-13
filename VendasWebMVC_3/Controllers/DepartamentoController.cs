using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC_3.Models;

namespace VendasWebMVC_3.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {

            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Name = "Eletronicos" });
            list.Add(new Departamento { Id = 2, Name = "Moda" });


            return View(list);
        }
    }
}
