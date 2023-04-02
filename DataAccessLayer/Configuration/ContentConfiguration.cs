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
    public class ContentConfiguration : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.HasKey(x => x.ContentId);
            builder.Property(x => x.ContentValue).HasMaxLength(1000);
            builder.HasOne(x=>x.Heading).WithMany(x=>x.Contents).HasForeignKey(x=>x.HeadingId);
            builder.HasOne(x=>x.Writer).WithMany(x=>x.Contents).HasForeignKey(x=>x.WriterId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
