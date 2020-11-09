using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebServerAppFinalProject.Models
{
    internal class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasData(
                new Category { CategoryId = 1, Name = "Cakes"},
                new Category { CategoryId = 2, Name = "Cookies" },
                new Category { CategoryId = 3, Name = "Bread" },
                new Category { CategoryId = 4, Name = "Pies & Tarts" },
                new Category { CategoryId = 5, Name = "Crips, Crumbles & Cobblers" },
                new Category { CategoryId = 6, Name = "Brownies & Bars" },
                new Category { CategoryId = 7, Name = "Frostings, Fillings & Jams" },
                new Category { CategoryId = 8, Name = "Sweet Dough" },
                new Category { CategoryId = 9, Name = "Pastry" },
                new Category { CategoryId = 10, Name = "Desserts" }
                );
        }

    }
}
