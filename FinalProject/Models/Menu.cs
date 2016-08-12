﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Menu
    {
        public Menu()
        {

        }
        public Menu(int foodID, string Name, double price, string shortDescription, string longDescription)
        {
           
            this.FoodId = FoodId;
            this.Name = Name;
            this.Price = Price;
            this.shortDescription = shortDescription;
            this.longDescription = longDescription;

        }
        [Key]
        public virtual int FoodId { get; set; }
        public virtual string foodImageUrl { get; set; }
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }
        public virtual string shortDescription { get; set; }
        public virtual string longDescription { get; set; }
    }
}