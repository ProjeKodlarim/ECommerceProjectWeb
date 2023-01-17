using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", @"dbo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName)
                .HasColumnName("UserName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.UserName)
                .HasColumnName("UserName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Password)
                .HasColumnName("Password")
                .HasMaxLength(20)
                .IsRequired();
            builder.Property(x => x.Gender)
                .HasColumnName("Gender")
                .IsRequired();
            builder.Property(x => x.DateOfBirtday)
                .HasColumnName("DateOfBirtday")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);

            //proje çalıştığında veri olması için

            builder.HasData(new User
            {
                Id=1,
                FirstName = "Omer",
                LastName = "BB",
                Password = "123",
                Gender = true,
                DateOfBirtday = Convert.ToDateTime("01-01-2000"),
                CreatedDate = DateTime.Now,
                Adress = "Istanbul",
                CreatedUserId=1,
                Email = "omer@omer.com",
                UserName = "OmerBB"
            }); 

        }
    }
}
