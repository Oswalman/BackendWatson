﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba_Watson.Models;

namespace Prueba_Watson.Migrations
{
    [DbContext(typeof(Prueba_WatsonContext))]
    partial class Prueba_WatsonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Prueba_Watson.Models.Persona", b =>
                {
                    b.Property<int>("Identificador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdPersona")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SumaDocumento")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SumaNombres")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Identificador");

                    b.HasIndex("IdPersona")
                        .IsUnique()
                        .HasFilter("[IdPersona] IS NOT NULL");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("Prueba_Watson.Models.Usuario", b =>
                {
                    b.Property<int>("Identificador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Identificador");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Prueba_Watson.Models.Persona", b =>
                {
                    b.HasOne("Prueba_Watson.Models.Usuario", "Usuario")
                        .WithOne("Persona")
                        .HasForeignKey("Prueba_Watson.Models.Persona", "IdPersona");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Prueba_Watson.Models.Usuario", b =>
                {
                    b.Navigation("Persona");
                });
#pragma warning restore 612, 618
        }
    }
}
