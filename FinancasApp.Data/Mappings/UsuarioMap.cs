using FinancasApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Data.Mappings
{
    //classe de mapeamento ORM para entidade usuario 
    //Pra virar uma tabela no banco de dados
    //primeiro mapea 
    //Depois vamos para DataContext
    public class UsuarioMap :IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //nome da tabela
            builder.ToTable("USUARIO");

            //CHAVE PRIMÁRIA DA TABELA é o Id
            builder.HasKey(u => u.Id);

            //mapeamento dos campos
            builder.Property(u => u.Id)
                .HasColumnName("ID")
                .IsRequired();// campo obrigatório

            builder.Property(u => u.Nome)
                  .HasColumnName("NOME")
                  .HasMaxLength(100)
                  .IsRequired();// campo obrigatório

            builder.Property(u => u.Email)
                  .HasColumnName("EMAIL")
                  .HasMaxLength(50)
                  .IsRequired(); // campo obrigatório

            builder.HasIndex(u => u.Email)
                .IsUnique();//não pode ter e-mail repetidos

            builder.Property(u => u.Senha)
                 .HasColumnName("SENHA")
                 .HasMaxLength(40)
                 .IsRequired();

            builder.Property(u => u.DataHoraCriacao)
                .HasColumnName("DATAHORACRIACAO")
                .HasColumnType("datetime")
                .IsRequired();


        }
    }
}
