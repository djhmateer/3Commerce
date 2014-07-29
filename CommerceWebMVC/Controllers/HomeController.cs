using Ploeh.Samples.Commerce.Domain;
using Ploeh.Samples.Commerce.Web.Models;
using System;
using System.Web.Mvc;

namespace CommerceWebMVC.Controllers {
    public class HomeController : Controller {
        private readonly ProductRepository repository;

        public HomeController(ProductRepository repository) {
            if (repository == null) {
                throw new ArgumentNullException("repository");
            }

            this.repository = repository;
        }

        // Need a parameterless constructor if have another ctor with a parameter
        public HomeController() {
        }

        public ViewResult Index() {
            var productService = new ProductService(this.repository);

            var vm = new FeaturedProductsViewModel();

            var products = productService.GetFeaturedProducts(this.User);
            foreach (var product in products) {
                var productVM = new ProductViewModel(product);
                vm.Products.Add(productVM);
            }

            return View(vm);
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}