using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Todo.Domain;
using Todo.Services.UnitOfWork;

namespace Todo.Client.Areas.Home.Controllers
{
    public class TodoController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TodoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            // Get all Todo Items
            IEnumerable<TodoItem> todoItems = _unitOfWork.TodoService.GetAll();

            return View(todoItems);
        }


        // GET: 
        public IActionResult Add()
        {
            return View();
        }

        // POST:
        [HttpPost, ActionName("Add")]
        public IActionResult AddPost(TodoItem model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _unitOfWork.TodoService.Add(model);
            _unitOfWork.Save();

            return RedirectToAction("Index");
        }


        public IActionResult Edit(Guid id)
        {
            var model = _unitOfWork.TodoService.GetTodoById(id);
            if (model == null)
                return RedirectToAction("Index");

            return View(model);
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditPOST(TodoItem model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _unitOfWork.TodoService.Update(model);
            _unitOfWork.Save();

            return RedirectToAction("Index");
        }


        
        public IActionResult Delete(Guid id)
        {
            var obj = _unitOfWork.TodoService.GetTodoById(id);
            _unitOfWork.TodoService.Remove(obj);
            _unitOfWork.Save();

            return RedirectToAction("Index");
        }

    }
}
