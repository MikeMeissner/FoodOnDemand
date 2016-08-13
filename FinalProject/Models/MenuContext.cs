namespace FinalProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    /**
 * Names: Nathan Siu and mike Meissner
 * File Name MenuContext.cs
 * File Description: This is menu connection
 * 
 * */

    public partial class MenuContext : DbContext
    {
        public MenuContext()
            : base("name=MenuConnection")
        {
        }


        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

    }
}
