﻿using GreenHouse.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.Data
{
    public class GreenHouseDbContext : DbContext
    {
        public GreenHouseDbContext() : base("GreenhouseConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> footers { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<PostCategory> postCategories { get; set; }
        public DbSet<Menu> menus { get; set; }
        public DbSet<MenuGruop> menuGruops { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
        public DbSet<PostTag> postTags { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<Shop> shops { get; set; }
        public DbSet<Tag> tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}