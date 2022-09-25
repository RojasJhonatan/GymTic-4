﻿// <auto-generated />
using System;
using GymTic.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GymTic.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220925031839_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GymTic.App.Dominio.Alimentacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("almuerzo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("desayuno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diasSemana")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Alimentacion");
                });

            modelBuilder.Entity("GymTic.App.Dominio.CategoriaEjercicios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombreCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("puntosSaludables")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("categoriaEjercicios");
                });

            modelBuilder.Entity("GymTic.App.Dominio.CategoriaNutricion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombreCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("puntosSaludables")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("categoriaNutricion");
                });

            modelBuilder.Entity("GymTic.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("altura")
                        .HasColumnType("real");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("peso")
                        .HasColumnType("int");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("GymTic.App.Dominio.Dieta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("alimentacionid")
                        .HasColumnType("int");

                    b.Property<int?>("categoriaid")
                        .HasColumnType("int");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("verificacion")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("alimentacionid");

                    b.HasIndex("categoriaid");

                    b.ToTable("Dieta");
                });

            modelBuilder.Entity("GymTic.App.Dominio.Ejercicio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("caloriasConsumidas")
                        .HasColumnType("int");

                    b.Property<int?>("categoriaid")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("puntosSaludables")
                        .HasColumnType("int");

                    b.Property<int>("repeticiones")
                        .HasColumnType("int");

                    b.Property<int>("series")
                        .HasColumnType("int");

                    b.Property<string>("zonaCuerpo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("categoriaid");

                    b.ToTable("Ejercicio");
                });

            modelBuilder.Entity("GymTic.App.Dominio.Nutricion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("dietaid")
                        .HasColumnType("int");

                    b.Property<int>("puntosVerificacion")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("dietaid");

                    b.ToTable("Nutricion");
                });

            modelBuilder.Entity("GymTic.App.Dominio.PlanSaludable", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("clienteid")
                        .HasColumnType("int");

                    b.Property<int?>("nutricionid")
                        .HasColumnType("int");

                    b.Property<int?>("rutinaid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("clienteid");

                    b.HasIndex("nutricionid");

                    b.HasIndex("rutinaid");

                    b.ToTable("PlanSaludable");
                });

            modelBuilder.Entity("GymTic.App.Dominio.Rutina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ejerciciosid")
                        .HasColumnType("int");

                    b.Property<string>("horario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("ejerciciosid");

                    b.ToTable("Rutina");
                });

            modelBuilder.Entity("GymTic.App.Dominio.Dieta", b =>
                {
                    b.HasOne("GymTic.App.Dominio.Alimentacion", "alimentacion")
                        .WithMany()
                        .HasForeignKey("alimentacionid");

                    b.HasOne("GymTic.App.Dominio.CategoriaNutricion", "categoria")
                        .WithMany()
                        .HasForeignKey("categoriaid");

                    b.Navigation("alimentacion");

                    b.Navigation("categoria");
                });

            modelBuilder.Entity("GymTic.App.Dominio.Ejercicio", b =>
                {
                    b.HasOne("GymTic.App.Dominio.CategoriaEjercicios", "categoria")
                        .WithMany()
                        .HasForeignKey("categoriaid");

                    b.Navigation("categoria");
                });

            modelBuilder.Entity("GymTic.App.Dominio.Nutricion", b =>
                {
                    b.HasOne("GymTic.App.Dominio.Dieta", "dieta")
                        .WithMany()
                        .HasForeignKey("dietaid");

                    b.Navigation("dieta");
                });

            modelBuilder.Entity("GymTic.App.Dominio.PlanSaludable", b =>
                {
                    b.HasOne("GymTic.App.Dominio.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteid");

                    b.HasOne("GymTic.App.Dominio.Nutricion", "nutricion")
                        .WithMany()
                        .HasForeignKey("nutricionid");

                    b.HasOne("GymTic.App.Dominio.Rutina", "rutina")
                        .WithMany()
                        .HasForeignKey("rutinaid");

                    b.Navigation("cliente");

                    b.Navigation("nutricion");

                    b.Navigation("rutina");
                });

            modelBuilder.Entity("GymTic.App.Dominio.Rutina", b =>
                {
                    b.HasOne("GymTic.App.Dominio.Ejercicio", "ejercicios")
                        .WithMany()
                        .HasForeignKey("ejerciciosid");

                    b.Navigation("ejercicios");
                });
#pragma warning restore 612, 618
        }
    }
}
