using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicDataViewer.Model
{
    public class Category
    {

        [RestSharp.RequestProperty(Name ="id")]
        public int Id { get; set; }

        [RestSharp.RequestProperty(Name = "name")]
        public string Name { get; set; }

        [RestSharp.RequestProperty(Name = "parent_id")]
        public int ParentID { get; set; }

    }
}
