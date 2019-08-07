using System.Web.Mvc;
using Impacta.MOD;
using Impacta.Tarefas.Business;

namespace Impacta.Tarefas.Controllers
{
	public class RealBooksController : Controller
	{
		// GET: RealBooks
		public ActionResult Index()
		{

            
            return View();
            //// criar um objeto do tipo Business
			//EditoraBUS editoraBUS = new EditoraBUS();

			//var listaEditora = editoraBUS.ListarEditoras();

			//// Retornamos a lista para a VIEW que estara tipada para 
			//// receber uma lista de Editoras
			//return View(listaEditora);
		}

		// GET: RealBooks/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: RealBooks/Create
		public ActionResult CriarEditora()
		{

			return View();
		}

		// POST: RealBooks/Create
		[HttpPost]
		public ActionResult Create(Editora collection)
		{
			try
			{
				if (ModelState.IsValid)
				{
					
				}
				EditoraBUS editoraBUS = new EditoraBUS();

				editoraBUS.Salvar(collection);

				return RedirectToAction("Index");
			}
			catch
			{
				
				return View();
			}
		}

		// GET: RealBooks/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: RealBooks/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add update logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: RealBooks/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: RealBooks/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}
}
