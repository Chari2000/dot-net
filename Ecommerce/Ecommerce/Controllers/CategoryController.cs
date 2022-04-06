using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ecommerceContext _ecommerceDbContext;
        public CategoryController(ecommerceContext ecommerceDbContext)
        {
            _ecommerceDbContext = ecommerceDbContext;
        }
        [HttpGet]
        public IEnumerable<TblCategory> GetCategories()
        {
            return _ecommerceDbContext.TblCategories.ToList();
        }
    }
}
