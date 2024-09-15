using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configurations
{


    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Configure the Name property as required
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100); // Max length of 100

            // Configure the Email property with a unique index
            builder.HasIndex(c => c.Email)
                .IsUnique();

            // Set default value for Age
            builder.Property(c => c.Age)
                .HasDefaultValue(18);
        }
    }

}

