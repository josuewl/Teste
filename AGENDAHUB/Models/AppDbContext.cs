﻿using Microsoft.EntityFrameworkCore;

namespace AGENDAHUB.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Servicos> Servicos { get; set; }

        //Adicionem aqui quando criarem controllers para o banco de dados
    }
}
