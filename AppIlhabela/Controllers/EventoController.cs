using AppIlhabela.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppIlhabela.Controllers
{
    public class EventoController : Controller
    {
        
            // Método que exibe a página inicial com todos os eventos
            public ActionResult Index()
            {
                var events = GetEvents();
                ViewBag.Beaches = GetBeaches();
                return View(events);
            }

            // Método para exibir os eventos de uma praia específica
            public ActionResult BeachEvents(string beachName)
            {
                var events = GetEvents().Where(e => e.nome == beachName).ToList();
                return View("BeachEvents", events);
                ViewBag.SelectedBeach = "Praia1";
        }


            // Simulação de dados
            private List<Praias> GetEvents()
            {
                return new List<Praias>
        {
            new Praias { nome = "Praia 1", descriçao = "url-to-image-1.jpg", preços = 20 },
            new Praias { nome = "Praia 2", descriçao = "url-to-image-2.jpg", preços = 20 },
            new Praias { nome = "Praia 3", descriçao = "url-to-image-3.jpg", preços = 20 },
            new Praias { nome = "Praia 4", descriçao = "url-to-image-4.jpg", preços = 20 }
        };
            }

            private List<string> GetBeaches()
            {
                return new List<string> { "Praia 1", "Praia 2", "Praia 3", "Praia 4" };
            }
        }

    }
