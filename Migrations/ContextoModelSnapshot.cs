﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P2_AP1_CarlosLopez_20190720.DAL;

namespace P2_AP1_CarlosLopez_20190720.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("P2_AP1_CarlosLopez_20190720.Entidades.ProyectoDetalle", b =>
                {
                    b.Property<int>("ProyectoDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProyectoDetalleId");

                    b.HasIndex("ProyectoId");

                    b.HasIndex("TipoId");

                    b.ToTable("ProyectoDetalle");
                });

            modelBuilder.Entity("P2_AP1_CarlosLopez_20190720.Entidades.Proyectos", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.HasKey("ProyectoId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("P2_AP1_CarlosLopez_20190720.Entidades.TiposTareas", b =>
                {
                    b.Property<int>("TipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Requerimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tiempo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipoTarea")
                        .HasColumnType("TEXT");

                    b.HasKey("TipoId");

                    b.ToTable("TiposTareas");

                    b.HasData(
                        new
                        {
                            TipoId = 1,
                            Requerimiento = "Analizar la opcion de clientes",
                            Tiempo = 120,
                            TipoTarea = "Analisis"
                        },
                        new
                        {
                            TipoId = 2,
                            Requerimiento = "Hacer un diseño excelente",
                            Tiempo = 60,
                            TipoTarea = "Diseño"
                        },
                        new
                        {
                            TipoId = 3,
                            Requerimiento = "Programar todo el registro",
                            Tiempo = 240,
                            TipoTarea = "Programacion"
                        },
                        new
                        {
                            TipoId = 4,
                            Requerimiento = "Probar con mucho cuidado",
                            Tiempo = 30,
                            TipoTarea = "Prueba"
                        });
                });

            modelBuilder.Entity("P2_AP1_CarlosLopez_20190720.Entidades.ProyectoDetalle", b =>
                {
                    b.HasOne("P2_AP1_CarlosLopez_20190720.Entidades.Proyectos", "Proyectos")
                        .WithMany("Detalle")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P2_AP1_CarlosLopez_20190720.Entidades.TiposTareas", "TiposTareas")
                        .WithMany()
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyectos");

                    b.Navigation("TiposTareas");
                });

            modelBuilder.Entity("P2_AP1_CarlosLopez_20190720.Entidades.Proyectos", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
