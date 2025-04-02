﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgramacaoIV.Venda.Api.Context;

#nullable disable

namespace ProgramacaoIV.Venda.Api.Migrations
{
    [DbContext(typeof(VendaContext))]
    [Migration("20250402003138_migration_1_0_0")]
    partial class migration_1_0_0
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProgramacaoIV.Venda.Api.Entidades.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("ID");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("NR_CPF");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DT_ATUALIZACAO");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DT_CRIACAO");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("DS_ENDERECO");

                    b.Property<bool>("IsAtivo")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IN_ATIVO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("NM_CLIENTE");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("NR_TELEFONE");

                    b.HasKey("Id");

                    b.ToTable("CLIENTE", (string)null);
                });

            modelBuilder.Entity("ProgramacaoIV.Venda.Api.Entidades.ItemTransacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DT_ATUALIZACAO");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DT_CRIACAO");

                    b.Property<Guid?>("ID_ITEM_TRANSACAO")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ID_PRODUTO")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsAtivo")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IN_ATIVO");

                    b.Property<decimal>("Quantidade")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("QT_ITEM");

                    b.Property<decimal>("Valor")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("VL_ITEM");

                    b.HasKey("Id");

                    b.HasIndex("ID_ITEM_TRANSACAO");

                    b.HasIndex("ID_PRODUTO");

                    b.ToTable("TRANSACAO_ITEM", (string)null);
                });

            modelBuilder.Entity("ProgramacaoIV.Venda.Api.Entidades.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DT_ATUALIZACAO");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DT_CRIACAO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("DS_PRODUTO");

                    b.Property<string>("EAN")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("NR_EAN");

                    b.Property<decimal>("Estoque")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("QT_ESTOQUE");

                    b.Property<bool>("IsAtivo")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IN_ATIVO");

                    b.Property<decimal>("PrecoCompra")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("VL_PRECO_COMPRA");

                    b.Property<decimal>("PrecoVenda")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("VL_PRECO_VENDA");

                    b.HasKey("Id");

                    b.ToTable("PRODUTO", (string)null);
                });

            modelBuilder.Entity("ProgramacaoIV.Venda.Api.Entidades.Transacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DT_ATUALIZACAO");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DT_CRIACAO");

                    b.Property<Guid>("ID_CLIENTE")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsAtivo")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IN_ATIVO");

                    b.HasKey("Id");

                    b.HasIndex("ID_CLIENTE");

                    b.ToTable("TRANSACAO", (string)null);
                });

            modelBuilder.Entity("ProgramacaoIV.Venda.Api.Entidades.ItemTransacao", b =>
                {
                    b.HasOne("ProgramacaoIV.Venda.Api.Entidades.Transacao", null)
                        .WithMany("Itens")
                        .HasForeignKey("ID_ITEM_TRANSACAO")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProgramacaoIV.Venda.Api.Entidades.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ID_PRODUTO")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("ProgramacaoIV.Venda.Api.Entidades.Transacao", b =>
                {
                    b.HasOne("ProgramacaoIV.Venda.Api.Entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ID_CLIENTE")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ProgramacaoIV.Venda.Api.Entidades.Transacao", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
