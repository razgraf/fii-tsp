using System;
using Microsoft.EntityFrameworkCore;

using MyPhotos.Model;

namespace MyPhotos.Storage
{
    public class Context : DbContext
    {

        public DbSet<File> Files { get; set; }
        public DbSet<Data> Datas { get; set; }
        public DbSet<FileData> FileDatas { get; set; }

        public Context()
        {
            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=RAZVAN-PC\\MSSQLSERVER01;Initial Catalog=tspp2;Integrated Security=True;Pooling=False");
        }

        // source: https://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileData>()
                .HasKey(fd => new { fd.FileId, fd.DataId, fd.FileDataId });
            modelBuilder.Entity<FileData>()
                .HasOne(fd => fd.File)
                .WithMany(f => f.FileDatas)
                .HasForeignKey(fd => fd.FileId);
            modelBuilder.Entity<FileData>()
                .HasOne(fd => fd.Data)
                .WithMany(d => d.FileDatas)
                .HasForeignKey(fd => fd.DataId);
        }
    }
}
