using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/**
 * Names: Nathan Siu and mike Meissner
 * File Name Order.cs
 * File Description: Order Model
 * 
 * */

namespace FinalProject.Models
{   
    [Bind(Exclude ="OrderId")]
    public class Order
    {
        [ScaffoldColumn(false)]
        
        public virtual int OrderId { get; set; }
        public virtual string Username { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string Province { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Country { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        [ScaffoldColumn(false)]
        public virtual decimal Total { get; set; }
        [ScaffoldColumn(false)]
        public virtual System.DateTime OrderDate { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}