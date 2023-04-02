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
    public class WriterConfiguration : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.HasKey(x => x.WriterId);
            builder.Property(x=> x.WriterName).HasMaxLength(50);
            builder.Property(x=> x.WriterSurName).HasMaxLength(50);
            builder.Property(x=> x.WriterImage).HasMaxLength(100);
            builder.Property(x=> x.WriterMail).HasMaxLength(50);
            builder.Property(x=> x.WriterPassword).HasMaxLength(20);
        }
    }
}
