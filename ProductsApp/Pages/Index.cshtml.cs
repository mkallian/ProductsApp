using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsApp.Module;
using ProductsApp.Services;

namespace ProductsApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;

        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products = productService.GetProducts();    

        }
    }
}
