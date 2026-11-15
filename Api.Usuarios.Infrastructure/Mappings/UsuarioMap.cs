using Api.Usuarios.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Usuarios.Infrastructure.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Nome da Tabela
            builder.ToTable("USUARIOS");

            //Chave Primária
            builder.HasKey(u => u.Id);

            //Mapeamento dos Campos da tabela

            builder.Property (u => u.Id)
                .HasColumnName("ID");
            builder.Property(u => u.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(50)
                .IsRequired();
                


            builder.Property(u => u.Senha)
                .HasColumnName("SENHA")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property (u => u.DataCadastro)
                .HasColumnName("DATA_CADASTRO")
                .IsRequired();
            builder.Property (u => u.PerfilId)
                .HasColumnName("ID_PERFIL")
                .IsRequired();


            //Definir o campo email como único
            builder.HasIndex(u => u.Email)
                .IsUnique();

            //Mapeamento do relacionamento + chave estrangeira

            builder.HasOne(u => u.Perfil) //Usuario tem um Perfil
                .WithMany(p => p.Usuarios) //Perfil tem muitos Usuarios
                .HasForeignKey(u => u.PerfilId); //Chave estrangeira






        }
    }
}
