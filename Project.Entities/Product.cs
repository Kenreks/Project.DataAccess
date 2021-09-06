using System;

namespace Project.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string QauntityPerUnit { get; set; }
        public short UnitsInStock { get; set; }
        public int UnitPrice { get; set; }

    }
}
