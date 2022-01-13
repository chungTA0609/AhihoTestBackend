using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.username).IsRequired().HasMaxLength(50);
            builder.Property(p => p.birthday).IsRequired();
            builder.Property(p => p.gender).IsRequired();
            builder.HasOne(b => b.geo_location).WithMany().HasForeignKey(p =>p.geo_location_id);
        }
    }
}
