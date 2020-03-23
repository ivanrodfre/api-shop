using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Models;

namespace Shop.Controllers
{
    [Route("v1")]
    public class HomeController : Controller
    {
        public async Task<ActionResult<dynamic>> Get(
            [FromServices]DataContext context
        )
        {
            var emplyee = new User { Id = 1, UserName = "ivanrodfre", Password = "123" };
            var manager = new User { Id = 2, UserName = "joao", Password = "123" };
            var category = new Category { Id = 1, Title = "Informática" };
            var product = new Product { Id = 1, CategoryId = 1, Title = "Produto 1", Description = "Descrição aqui", Price = 299 };

            context.Users.Add(emplyee);
            context.Users.Add(manager);
            context.Categories.Add(category);
            context.Products.Add(product);

            await context.SaveChangesAsync();

            return Ok(new
            {
                message = "Dados configurados"
            });

        }
    }
}