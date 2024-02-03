﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using FundacionAMA.Domain.Entities;
using FundacionAMA.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace FundacionAMA.Infrastructure.Persistence.Configurations
{
    public partial class DonationTypeConfiguration : IEntityTypeConfiguration<DonationType>
    {
        public void Configure(EntityTypeBuilder<DonationType> entity)
        {
            entity.ToTable("DonationType");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(30)
            .IsFixedLength();
            entity.Property(e => e.Status)
            .IsRequired()
            .HasDefaultValueSql("(N'')");
            entity.HasData(new DonationType
            {
                Id = 1,
                Name = "viveres",
                Status = "A",
                CreatedAt = DateTime.Now,
                Active = true,
            },
            new DonationType
            {
                Id = 2,
                Name = "medicina",
                Status = "A",
                CreatedAt = DateTime.Now,
                Active = true,
            },
            new DonationType
            {
                Id = 3,
                Name = "vestimenta",
                Status = "A",
                CreatedAt = DateTime.Now,
                Active = true,
            },
            new DonationType
            {
                Id = 4,
                Name = "monetario",
                Status = "A",
                CreatedAt = DateTime.Now,
                Active = true,
            },
            new DonationType
            {
                Id = 5,
                Name = "tecnologia",
                Status = "A",
                CreatedAt = DateTime.Now,
                Active = true,
            },
            new DonationType
            {
                Id = 6,
                Name = "suministros",
                Status = "A",
                CreatedAt = DateTime.Now,
                Active = true,
            },
            new DonationType
            {
                Id = 7,
                Name = "varios",
                Status = "A",
                CreatedAt = DateTime.Now,
                Active = true,
            }
            );

           OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DonationType> entity);
    }
}