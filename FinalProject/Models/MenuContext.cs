namespace FinalProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class MenuContext : DBContext
    {
        public MenuContext()
            : base("name=MenuConnection")
        {
        }
        public virtual DbSet<Menu> Menu { get; set; }
    }
}