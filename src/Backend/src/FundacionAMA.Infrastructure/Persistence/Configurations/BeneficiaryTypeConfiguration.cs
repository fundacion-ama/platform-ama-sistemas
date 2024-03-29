﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using FundacionAMA.Domain.Entities;
using FundacionAMA.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace FundacionAMA.Infrastructure.Persistence.Configurations
{
    public partial class BeneficiaryTypeConfiguration : IEntityTypeConfiguration<BeneficiaryType>
    {
        public void Configure(EntityTypeBuilder<BeneficiaryType> entity)
        {
            entity.ToTable("BeneficiaryType");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
            .HasMaxLength(10)
            .IsFixedLength();
            entity.Property(e => e.Status)
            .IsRequired()
            .HasDefaultValueSql("(N'')");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<BeneficiaryType> entity);
    }
}
