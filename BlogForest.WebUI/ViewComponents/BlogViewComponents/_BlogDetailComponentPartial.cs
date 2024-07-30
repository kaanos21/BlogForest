using BlogForest.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailComponentPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public _BlogDetailComponentPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var xx = ViewBag.i;
            var value=_blogService.tGetById(id);
            return View(value);
        }
    }
}
