﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TodoAppData.models.ModelConfigurations
{
    class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.CreatedOn)
                   .HasColumnType("TIMESTAMP(0)")
                   .IsRequired();

            builder.Property(prop => prop.Body)
                   .HasMaxLength(1000);

            builder.Property(prop => prop.Title)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(prop => prop.isCompleted)
                   .IsRequired();
        }
    }
}
