using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using KatmanlıModel.Model;


namespace KatmanlıData.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<Kullanici> Kullanıcı { get; set; }

        public DbSet<Diziler> Diziler { get; set; }

        public DbSet<Filmler> Filmler { get; set; }

        public DbSet<FilmIzlemeListesi> FilmIzlemeListesi { get; set; }

        public DbSet<DiziIzlemeListesi> DiziIzlemeListesi { get; set; }

        public DbSet<DiziYorumlar> DiziYorumlar { get; set; }

        public DbSet<FilmYorumlar> FilmYorumlar { get; set; }

       
    }
}
