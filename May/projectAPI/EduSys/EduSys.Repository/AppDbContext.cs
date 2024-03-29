﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EduSys.Core.Models;
using EduSys.Repository.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EduSys.Repository
{
    public class AppDbContext : DbContext  
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base (options)
        {
                    
        }

        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; } 
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().HasKey  (c => c.Id).HasName("CategoryId");    
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // bu hisse   bir bir  tanitmaqla   aparilir
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductFeatureConfiguration());

            //Nümunə olsun deyə bura yazılıb amma düzgün deyil 

            modelBuilder.Entity<ProductFeature>().HasData
                (
                new ProductFeature 
                {
                    Id=1,
                    Color="Red",
                    Heigth=30,
                    Width=70,
                    ProductId=1
                },

                new ProductFeature
                {
                    Id = 2,
                    Color = "Red",
                    Heigth = 20,
                    Width = 25,
                    ProductId = 3
                }
                );

          
    }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity entityReferance) 
                {
                    switch (item.State)
                    {
                      
                        case EntityState.Modified:
                            {
                                entityReferance.CreateDate = DateTime.Now;
                                break;
                            }
                        case EntityState.Added:
                            {
                                Entry(entityReferance).Property(x => x.UpdateDate).IsModified = false;
                                entityReferance.UpdateDate = DateTime.Now;  
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity entityReferance)
                {
                    switch (item.State)
                    {

                        case EntityState.Modified:
                            {
                                Entry(entityReferance).Property(x => x.UpdateDate).IsModified = false;
                                entityReferance.CreateDate = DateTime.Now;
                                break;
                            }
                        case EntityState.Added:
                            {
                                Entry(entityReferance).Property(x => x.CreateDate).IsModified = false;
                                entityReferance.UpdateDate = DateTime.Now;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
          
            return base.SaveChanges();
        }
    }
}
