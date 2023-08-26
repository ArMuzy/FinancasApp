using FinancasApp.Data.Entities;
using FinancasApp.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Data.Contexts
{
    //classe para configuração do acesso ao banco de dados
    //realizado pelo EntityFramework
    //Viemos do UsuarioMaps
    //Segundo fazer a configuração das classes

    //REGRA 1: Herdar DbContex!
    public class DataContext : DbContext
    {
        //REGRA 2 : IMPLEMENTAR MÉTODO 'OnConfiguring' para 
        //mapearmos a string de conexão do banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDFinnancasApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        //REGRA 3: Implementar o método OnModelCreating para
        // adicionar cada classe de mapeamento do projeto
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
        //Regra 4: Para cada entidade do projeto declare
        //uma propriedade do tipo DbSet
        
        public DbSet<Usuario> Usuario { get; set; }
    }
}
