﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication7.models
{
   
        public class Product
        {
        [Key]
            public int pId { get; set; }
        [Required]
            public string pName { get; set; }
            public int price { get; set; }
            public int quantity { get; set; }
            public string category { get; set; }

        }
    public class SalesDbContext : DbContext
    {
        
        public DbSet<Product> Products { get; set; }

        public SalesDbContext(DbContextOptions<SalesDbContext> options)
         : base(options)
        {

        }


    }
}