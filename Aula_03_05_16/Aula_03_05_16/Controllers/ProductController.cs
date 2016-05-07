using Aula_03_05_16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula_03_05_16.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> lista = new List<Product> {
        new Product { Id = 3, Nome = "coca-cola", Categoria = "bebida", Price = 6 },
        new Product { Id = 4, Nome = "pipoca", Categoria = "comida", Price = 6 },
        new Product { Id = 5, Nome = "chocolate", Categoria = "doce", Price = 6 }
        };



// GET: Product
public ActionResult Index()
        {          

            return View(lista);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product produto)
        {
            try
            {
                lista.Add(produto);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
