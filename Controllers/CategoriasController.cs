using Microsoft.AspNetCore.Mvc;
using TechStoreMVC.Models;
namespace TechStoreMVC.Controllers

{
    public class CategoriasController : Controller
    {
        private readonly CategoriaDB _categoriaDB;
        public CategoriasController()
        {
            _categoriaDB = new CategoriaDB();
        }   
        [HttpGet]
        public ActionResult Index()
        {
            List<Categoria> categorias = _categoriaDB.Listar();
            return View(categorias);

        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Categoria? categoria = _categoriaDB.buscarPorId(id);
            if (categoria is null)
                return NotFound();

            return View(categoria);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Categoria categoria)
        {
            if (!ModelState.IsValid)
                return View(categoria);
            _categoriaDB.Adicionar(categoria);
            TempData["Sucesso"] =
            "Categoria cadastrada com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Categoria? categoria = _categoriaDB.buscarPorId(id);
            if (categoria is null)
                return NotFound();

            return View(categoria);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Categoria categoria, int id)
        {
            if (id != categoria.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return View(categoria);

            bool atualizou = _categoriaDB.Atualizar(categoria);
            if (!atualizou)
                return NotFound();

            TempData["Sucesso"] =
            "Categoria editada com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Categoria? categoria = _categoriaDB.buscarPorId(id);
            if (categoria is null)
                return NotFound();

            return View(categoria);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            bool excluiu = _categoriaDB.Excluir(id);
            if (!excluiu)
                return NotFound();

            TempData["Sucesso"] =
            "Categoria deletada com sucesso!";
            return RedirectToAction(nameof(Index));
        }


    }
}

