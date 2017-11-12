using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPieRepository _pieRepository;
        private readonly IPieReviewRepository _pieReviewRepository;
        private readonly HtmlEncoder _htmlEncoder;


        public PieController( IPieRepository pieRepository, ICategoryRepository categoryRepository, IPieReviewRepository pieReviewRepository, HtmlEncoder htmlEncoder)
        {
            _categoryRepository = categoryRepository;
            _pieReviewRepository = pieReviewRepository;
            _htmlEncoder = htmlEncoder;
            _pieRepository = pieRepository;
        }

        
        public IActionResult Index()
        {
            return RedirectToAction("List",new {category = ""});
//            return List("");
        }

        public IActionResult List(string category)
        {
            return View(new PiesListViewModel
            {
                CurrentCategory = category??"All pies"
            });
        }




        // [Route("[controller]/Details/{id}")]
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(new PieDetailViewModel() { Pie = pie });
        }



        // [Route("[controller]/Details/{id}")]
        [HttpPost]
        public IActionResult Details(int id, string review)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            // Protect against XSS attacks by encoding all input
            string encodedReview = _htmlEncoder.Encode(review);

            _pieReviewRepository.AddPieReview(new PieReview() { Pie = pie, Review = encodedReview });

            return View(new PieDetailViewModel() { Pie = pie, Review="" });
        }

    }
}
