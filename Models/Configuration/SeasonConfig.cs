﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebServerAppFinalProject.Models
{
    internal class SeasonConfig : IEntityTypeConfiguration<Season>
    {
        public void Configure(EntityTypeBuilder<Season> entity)
        {
            entity.HasData(
                new Season { SeasonId = 1, Name = "General" },
                new Season { SeasonId = 2, Name = "Year End Holidays" },
                new Season { SeasonId = 3, Name = "Spring" },
                new Season { SeasonId = 4, Name = "Fall & Thanksgiving" },
                new Season { SeasonId = 5, Name = "Halloween" },
                new Season { SeasonId = 6, Name = "Summer" },
                new Season { SeasonId = 7, Name = "Valentine's Day" }
            );
        }
    }
}
