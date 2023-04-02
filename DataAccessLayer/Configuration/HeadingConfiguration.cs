using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    public class HeadingConfiguration : IEntityTypeConfiguration<Heading>
    {
        public void Configure(EntityTypeBuilder<Heading> builder)
        {
            builder.HasKey(x => x.HeadingId);
            builder.Property(x => x.HeadingName).HasMaxLength(50);
            builder.HasOne(x => x.Category).WithMany(x => x.Headings).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Writer).WithMany(x => x.Headings).HasForeignKey(x => x.WriterID);
        }
    }
}
