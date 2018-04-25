using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ajax_notes.Models;

namespace ajax_notes.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            if(TempData["Error"] != null){
                ViewBag.Error = TempData["Error"];
            }
            List<Dictionary<string, object>> AllNotes = DbConnector.Query("SELECT * FROM notes");
            ViewBag.notes = AllNotes;
            return View();
        }
        [HttpPost]
        [Route("/create")]
        public IActionResult Note(string title)
        {
            if(string.IsNullOrEmpty(title)){
                TempData["Error"] = "Title cannot be empty!";
                return RedirectToAction("Index");
            }
            string query = $"INSERT INTO notes (title, created_at, updated_at) VALUES('{title}', NOW(), NOW());";
            DbConnector.Execute(query);
            return RedirectToAction("Index");
        }
        [Route("/update/{noteId}")]
        public IActionResult Update(string description, int noteId)
        {
            string query = $"UPDATE notes SET description = '{description}', updated_at = NOW() WHERE id = '{noteId}';";
            DbConnector.Execute(query);
            return RedirectToAction("Index");
        }
        [Route("/delete/{noteId}")]
        public IActionResult Delete(int noteId)
        {
            string query = $"DELETE FROM notes WHERE id = '{noteId}';";
            DbConnector.Execute(query);
            return RedirectToAction("Index");
        }
    }
}
