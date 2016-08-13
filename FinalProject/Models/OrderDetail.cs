using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class OrderDetail
    {
        public virtual int OrderDetailId { get; set; }


        public virtual int Quantity { get; set; }
        public virtual decimal UnitPrice { get; set; }

        public virtual int FoodId { get; set; }
        public virtual Menu MenuItem { get; set; }

        public virtual int OrderId { get; set; }
        public virtual Order Order { get; set; }


    }
}