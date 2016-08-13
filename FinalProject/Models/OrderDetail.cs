using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/**
 * Names: Nathan Siu and mike Meissner
 * File Name OrderDetail.cs
 * File Description: This is thhe order detail model
 * 
 * */

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