using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;
using Rize.Admin.Services.Enum;
using Rize.Admin.Services.Interface;
using Rize.Model.Entities;
using RIZE.AdminWeb.Attributes;

namespace RIZE.AdminWeb.Controllers
{
    [Authorize]
    [AuthorizeForScopes(Scopes = new[] { "User.Read" })]
    [RizeAuth]
    public class StoresController : Controller
    {
        private readonly IStoreService _storeService;

        public StoresController(IStoreService storeService)
        {
            _storeService = storeService;             
        }

        // GET: Stores
        [HttpGet("/administration/stores")]
        public async Task<IActionResult> Index()
        {          
            return View();
        }
        
        
        [HttpGet("/administration/StoreList")]
        public async Task<IActionResult> StoreList([DataSourceRequest] DataSourceRequest request)
        {
            var stores = await _storeService.GetStores(request);
          
            return Json(stores.Data.ToDataSourceResult(request));
        }


        // GET: Stores/Create
        [HttpGet("/administration/stores/Create")]
        public IActionResult Create()
        {
            return View(new Store());
        }

        // POST: Stores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("/administration/stores/Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Store storeRequest)
        {
            if (ModelState.IsValid)
            {
                var store = _storeService.CreateStore(storeRequest);               
                return RedirectToAction(nameof(Index));
            }
            return View(storeRequest);
        }

        // GET: Stores/detail/5
        [HttpGet("/administration/stores/detail/{id}")]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var store = await _storeService.GetStore((int)id);
            if (store == null)
            {
                return NotFound();
            }
            return View(store);
        }

        // POST: Stores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("/administration/stores/edit/{id}"), ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Store store)
        {
            if (id != store.StoreID)
            {
                TempData["ToastType"] = ToasTypes.Warning;
                TempData["ToastMessage"] = "Store not found!";
                return NotFound();
            }

            if (ModelState.IsValid)
            {               
                var storeUpdated = await _storeService.UpdateStore(id, store);

                TempData["ToastType"] = ToasTypes.Success;
                TempData["ToastMessage"] = $"The store {store.StoDescription} was updated successfully.";
                return RedirectToAction(nameof(Index));
            }

            TempData["ToastType"] = ToasTypes.Warning;
            TempData["ToastMessage"] = "There was an error with your submission.";
            return View("~/Views/stores/detail.cshtml", store);
        }

        // GET: Stores/Delete/5
        [HttpGet("/administration/stores/delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var store = await _storeService.GetStore((int)id);
            if (store == null)
            {
                return NotFound();
            }

            return View(store);
        }

        // POST: Stores/Delete/5
        [HttpPost("/administration/stores/delete/{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {          
          
            return RedirectToAction(nameof(Index));
        }
    }
}
