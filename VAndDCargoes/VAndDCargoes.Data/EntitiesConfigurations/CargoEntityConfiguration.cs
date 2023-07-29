﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VAndDCargoes.Data.Models;

namespace VAndDCargoes.Data.EntitiesConfigurations
{
    public class CargoEntityConfiguration : IEntityTypeConfiguration<Cargo>
	{
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder
                .HasOne(x => x.Creator)
                .WithMany(x => x.Cargoes)
                .HasForeignKey(x => x.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.CreatorId)
                .HasDefaultValue(Guid.Parse("3d7a05d7-8255-4936-9f32-36a07dc4af55"));
        }
    }
}

