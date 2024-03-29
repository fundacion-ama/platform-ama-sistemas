﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using FundacionAMA.Domain.Entities;
using FundacionAMA.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace FundacionAMA.Infrastructure.Persistence.Configurations
{
    public partial class DonorConfiguration : IEntityTypeConfiguration<Donor>
    {
        public void Configure(EntityTypeBuilder<Donor> entity)
        {
            entity.HasKey(e => e.PersonId).HasName("PK_Donors");
            entity.Property(e => e.PersonId).ValueGeneratedOnAdd();
            entity.Property(e => e.Status)
            .IsRequired()
            .HasDefaultValueSql("(N'')");
            entity.HasOne(d => d.Person).WithOne(p => p.IdNavigation)
         .HasForeignKey<Donor>(d => d.PersonId)
         .OnDelete(DeleteBehavior.ClientSetNull)
         .HasConstraintName("FK_Persons_Donors");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Donor> entity);
    }
}
