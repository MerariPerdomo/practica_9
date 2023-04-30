using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using practica_9.Models;

namespace practica_9.Controllers
{
    public class EquiposController : Controller
    {
        private readonly equiposDbcontext _equiposDbContext;
        public EquiposController(equiposDbcontext equiposDbContext)
        {
            _equiposDbContext = equiposDbContext;
        }
        public IActionResult Index()
        {
            var listaMarcas = (from m in _equiposDbContext.marcas
                               select m).ToList();
            ViewData["listaMarcas"] = new SelectList(listaMarcas, "id_marcas", "nombre_marca");
            
            var listatipo = (from eq in _equiposDbContext.equipos
                               select eq).ToList();
            ViewData["listatipo"] = new SelectList(listatipo, "id_equipos", "nombre");

            var listaestado = (from es in _equiposDbContext.estados_equipos
                             select es).ToList();
            ViewData["listaestado"] = new SelectList(listaestado, "id_estados_equipos", "estado");

            var listadoDeEquipos = (from e in _equiposDbContext.equipos
                                    join m in _equiposDbContext.marcas on e.marca_id equals m.id_marcas
                               select new
                               {
                                   nombre= e.nombre,
                                   descripcion = e.descripcion,
                                   marca_id = e.marca_id, 
                                   marca_nombre = m.nombre_marca
                               }).ToList();
            ViewData["listadoDeEquipos"] = listadoDeEquipos;
            return View();
            
        }
        public IActionResult CrearEquipos(equipos NuevoEquipo)
        {
            _equiposDbContext.Add(NuevoEquipo);
            _equiposDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }

}
