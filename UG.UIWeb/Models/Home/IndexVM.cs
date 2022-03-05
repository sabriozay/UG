using System.Collections.Generic;
using UG.DAL.Entities;

namespace UG.UIWeb.Models.Home
{
    public class IndexVM
    {
        public List<Customer> Customers { get; set; }
        public BestQuantity bestQuantity { get; set; }
        public IndexVM()
        {
            
        }
    }
}
