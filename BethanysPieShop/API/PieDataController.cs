using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    [Route("api/piedata")]
    public class PieDataController : Controller
    {
        private const int PAGE_SIZE = 6;

        private readonly IPieRepository _pieRepository;

        public PieDataController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }


        [HttpGet("{category}/{pagecounter}")]
        public IEnumerable<PieViewModel> LoadMorePies(string category, int pagecounter)
        {
            IEnumerable<Pie> dbPies = null;

            if (string.IsNullOrEmpty(category) || category.ToUpper() == "ALL PIES")
            {
                dbPies = _pieRepository.Pies;
                
            }
            else
            {
                dbPies = _pieRepository.Pies.Where(p => p.Category.CategoryName == category);
            }

            dbPies = dbPies.OrderBy(p => p.Name).Skip(PAGE_SIZE* pagecounter).Take(PAGE_SIZE);

            List<PieViewModel> pies = new List<PieViewModel>();

            foreach (var dbPie in dbPies)
            {
                pies.Add(MapDbPieToPieViewModel(dbPie));
            }
            return pies;
        }


        private PieViewModel MapDbPieToPieViewModel(Pie dbPie)
        {
            return new PieViewModel()
            {
                PieId = dbPie.PieId,
                Name = dbPie.Name,
                Price = dbPie.Price,
                ShortDescription = dbPie.ShortDescription,
                ImageThumbnailUrl = dbPie.ImageThumbnailUrl
            };
        }
    }
}
