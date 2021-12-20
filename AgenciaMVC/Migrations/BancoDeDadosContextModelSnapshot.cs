﻿// <auto-generated />
using System;
using AgenciaMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgenciaMVC.Migrations
{
    [DbContext(typeof(BancoDeDadosContext))]
    partial class BancoDeDadosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgenciaMVC.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cidadeCliente")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("estadoCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeCliente")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AgenciaMVC.Models.Destino", b =>
                {
                    b.Property<int>("IdDestino")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dataFinal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dataInicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoDestino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeDestino")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("paisDestino")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("valorDiaria")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdDestino");

                    b.ToTable("Destinos");
                });

            modelBuilder.Entity("AgenciaMVC.Models.Pacote", b =>
                {
                    b.Property<int>("IdPacotes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FK_IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("FK_IdDestino")
                        .HasColumnType("int");

                    b.Property<int?>("clienteIdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("destinoIdDestino")
                        .HasColumnType("int");

                    b.Property<int>("qtdeDias")
                        .HasColumnType("int");

                    b.Property<int>("qtdePessoas")
                        .HasColumnType("int");

                    b.HasKey("IdPacotes");

                    b.HasIndex("clienteIdCliente");

                    b.HasIndex("destinoIdDestino");

                    b.ToTable("Pacotes");
                });

            modelBuilder.Entity("AgenciaMVC.Models.Pacote", b =>
                {
                    b.HasOne("AgenciaMVC.Models.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteIdCliente");

                    b.HasOne("AgenciaMVC.Models.Destino", "destino")
                        .WithMany()
                        .HasForeignKey("destinoIdDestino");

                    b.Navigation("cliente");

                    b.Navigation("destino");
                });
#pragma warning restore 612, 618
        }
    }
}
