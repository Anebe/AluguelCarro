using AluguelCarro.Interface;
using AluguelCarro.src.DTO;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AluguelCarro.src.DAO
{
    internal class MySqlContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Filial> Filial { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string connectionString = "server=localhost;uid=root;pwd=;database=aluguel_carro";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
