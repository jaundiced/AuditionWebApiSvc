using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using NordstromAuditionWebApiSvc.Models;

namespace NordstromAuditionWebApiSvc.Controllers
{
    public class ProductsController : ApiController
    {
// ReSharper disable once InconsistentNaming
        private static readonly Product[] products =
        {
            new Product
            {
                brand = "Zella",
                formatted_regular_price = "$68.00",
                image_url = "17/_8884657",
                name = "Zella 'Run' Stripe Half Zip Pullover",
                style_id = 3552410
            },
            new Product
            {
                brand = "Hinge",
                formatted_regular_price = "$26.00",
                image_url = @"7/_8904187",
                name = "Hinge® Jersey Tank",
                style_id = 3223974
            },
            new Product
            {
                brand = "Trouve",
                formatted_regular_price = "$68.00",
                image_url = @"7/_8547507",
                name = "Trouvé Side Slit Tunic Sweater",
                style_id = 3530925
            },
            new Product
            {
                brand = "Halogen®",
                formatted_regular_price = "$46.00",
                image_url = @"18/_8592178",
                name = "Halogen® Three Quarter Sleeve Cardigan (Regular & Petite)",
                style_id = 3320328
            },
            new Product
            {
                brand = "Zella",
                formatted_regular_price = "$58.00",
                image_url = @"4/_8889484",
                name = "Zella 'All Shirred Up' Pullover",
                style_id = 3460660
            },
            new Product
            {
                brand = "Zella",
                formatted_regular_price = "$58.00",
                image_url = @"14/_8680834",
                name = "Zella 'Easy' Sweatshirt",
                style_id = 3493124
            },
            new Product
            {
                brand = "Hinge",
                formatted_regular_price = "$26.00",
                image_url = @"7/_8904187",
                name = "Hinge® Jersey Tank",
                style_id = 3223974
            },
            new Product
            {
                brand = "Trouve",
                formatted_regular_price = "$38.00",
                image_url = @"7/_8803147",
                name = "Trouvé 'Luxe' Tee",
                style_id = 3530951
            },
            new Product
            {
                brand = "Stem",
                formatted_regular_price = "$38.00",
                image_url = @"2/_8736822",
                name = "Stem Seamed Dolman Sleeve Tee",
                style_id = 3530224
            },
            new Product
            {
                brand = "Zella",
                formatted_regular_price = "$52.00",
                image_url = @"13/_5917973",
                name = "Zella 'Live In' Leggings",
                style_id = 3035710
            },
            new Product
            {
                brand = "Pleione",
                formatted_regular_price = "$58.00",
                image_url = @"15/_8164075",
                name = "Pleione Mixed Media Roll Sleeve Top (Regular & Petite)",
                style_id = 3438286
            },
            new Product
            {
                brand = "Paige Denim",
                formatted_regular_price = "$158.00",
                image_url = @"10/_7163970",
                name = "Paige Denim 'Skyline 12' Skinny Stretch Jeans (Twilight)",
                style_id = 3128824
            }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.style_id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}