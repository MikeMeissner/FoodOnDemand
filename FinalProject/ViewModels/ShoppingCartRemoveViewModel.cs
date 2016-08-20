using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/**
 * Names: Nathan Siu and mike Meissner
 * File Name ShoppingCartRemoveViewModel.cs
 * File Description: This will remove an item from the cart
 * 
 * */

namespace FinalProject.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        public virtual string Message { get; set; }
        public virtual decimal CartTotal { get; set; }
        public virtual int CartCount { get; set; }
        public virtual int ItemCount { get; set; }
        public virtual int DeleteId { get; set; }
    }
}