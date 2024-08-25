using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicDataViewer.Model
{
    public class CategoriesToken
    {
        [RestSharp.RequestProperty(Name = "categories")]
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
