using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.DBModels;

namespace WebApplication1.Abstract
{
    public class IProductRepository
    {
        IEnumerable<Product> Product { get; }
    }
}