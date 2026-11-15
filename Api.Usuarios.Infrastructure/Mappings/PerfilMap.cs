using Api.Usuarios.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Usuarios.Infrastructure.Mappings
{
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            //Nome da Tabela
            builder.ToTable("PERFIS");

            //Chave Primária
            builder.HasKey(p => p.Id);

            //Mapear os campos da tabela
            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.Nome).HasColumnName("NOME")
                .HasColumnName("NOME")
                .HasMaxLength(25)
                .IsRequired();


            //Definir o campo nome como único
            builder.HasIndex(p => p.Nome)
                .IsUnique();

        }
    }
}
