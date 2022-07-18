﻿// <auto-generated />
using System;
using ListME.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ListME.Migrations
{
    [DbContext(typeof(ListMEContext))]
    [Migration("20220718205837_1.0")]
    partial class _10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ListME.Models.Acesso", b =>
                {
                    b.Property<int>("Id_Acesso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Acesso"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuarioId_Usuario")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id_Acesso");

                    b.HasIndex("usuarioId_Usuario");

                    b.ToTable("Acessos", (string)null);
                });

            modelBuilder.Entity("ListME.Models.Estoque", b =>
                {
                    b.Property<int>("Id_Estoque")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Estoque"), 1L, 1);

                    b.Property<string>("Data_Validade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantidade_Estoque")
                        .HasColumnType("int");

                    b.HasKey("Id_Estoque");

                    b.ToTable("Estoque", (string)null);
                });

            modelBuilder.Entity("ListME.Models.Produtos_ListaDeCompras", b =>
                {
                    b.Property<int>("Id_Produtos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Produtos"), 1L, 1);

                    b.Property<string>("Descricao_Produtos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstoqueId_Estoque")
                        .HasColumnType("int");

                    b.Property<string>("Nome_Produtos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Preco")
                        .HasColumnType("real");

                    b.Property<int>("Quantidade_Produtos")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId_Usuario")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id_Produtos");

                    b.HasIndex("EstoqueId_Estoque");

                    b.HasIndex("UsuarioId_Usuario");

                    b.ToTable("Produtos da lista de compras", (string)null);
                });

            modelBuilder.Entity("ListME.Models.Residencias", b =>
                {
                    b.Property<int>("Id_Residencias")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Residencias"), 1L, 1);

                    b.Property<string>("Descricao_Residencias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto_Residencias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_Residencias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioId_Usuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("estoqueId_Estoque")
                        .HasColumnType("int");

                    b.HasKey("Id_Residencias");

                    b.HasIndex("UsuarioId_Usuario");

                    b.HasIndex("estoqueId_Estoque");

                    b.ToTable("Residências", (string)null);
                });

            modelBuilder.Entity("ListME.Models.Usuario", b =>
                {
                    b.Property<string>("Id_Usuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Data_Nascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto_Perfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Usuario");

                    b.ToTable("Usuários", (string)null);
                });

            modelBuilder.Entity("ListME.Models.Acesso", b =>
                {
                    b.HasOne("ListME.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioId_Usuario");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("ListME.Models.Produtos_ListaDeCompras", b =>
                {
                    b.HasOne("ListME.Models.Estoque", null)
                        .WithMany("produtos")
                        .HasForeignKey("EstoqueId_Estoque");

                    b.HasOne("ListME.Models.Usuario", null)
                        .WithMany("produtos")
                        .HasForeignKey("UsuarioId_Usuario");
                });

            modelBuilder.Entity("ListME.Models.Residencias", b =>
                {
                    b.HasOne("ListME.Models.Usuario", null)
                        .WithMany("residencias")
                        .HasForeignKey("UsuarioId_Usuario");

                    b.HasOne("ListME.Models.Estoque", "estoque")
                        .WithMany()
                        .HasForeignKey("estoqueId_Estoque")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("estoque");
                });

            modelBuilder.Entity("ListME.Models.Estoque", b =>
                {
                    b.Navigation("produtos");
                });

            modelBuilder.Entity("ListME.Models.Usuario", b =>
                {
                    b.Navigation("produtos");

                    b.Navigation("residencias");
                });
#pragma warning restore 612, 618
        }
    }
}
