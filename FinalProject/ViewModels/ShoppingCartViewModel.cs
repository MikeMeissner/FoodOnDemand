using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject.Models;
/**
 * Names: Nathan Siu and mike Meissner
 * File Name ShoppingCartViewModel.cs
 * File Description: This is the shopping cart view model
 * 
 * */
namespace FinalProject.ViewModels
{
    public class ShoppingCartViewModel
    {
        public virtual List<Cart> CartItems { get; set; }
        public virtual decimal CartTotal { get; set; }
    }
}