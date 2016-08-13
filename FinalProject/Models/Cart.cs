using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
/**
 * Names: Nathan Siu and mike Meissner
 * File Name cart.cs
 * File Description: This is the model for the cart
 * 
 * */

namespace FinalProject.Models
{
    public class Cart
    {
        [Key]
        public virtual int RecordId { get; set; }
        public virtual string CartId { get; set; }
        public virtual int Count { get; set; }
        public virtual System.DateTime DateCreated { get; set; }
        public virtual int FoodId { get; set; }
        public virtual Menu MenuItem { get; set; }

    }
}