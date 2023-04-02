using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.ContactId);
            builder.Property(x => x.UserName).HasMaxLength(50);
            builder.Property(x => x.UserMail).HasMaxLength(50);
            builder.Property(x => x.Subject).HasMaxLength(50);
            builder.Property(x => x.Message).HasMaxLength(200);
        }
    }
}
