﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea9Docker.Data;

#nullable disable

namespace Tarea9Docker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tarea9Docker.Data.Empleado", b =>
                {
                    b.Property<int>("idEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idEmpleado"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PuestoidPuesto")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idPuesto")
                        .HasColumnType("int");

                    b.HasKey("idEmpleado");

                    b.HasIndex("PuestoidPuesto");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Tarea9Docker.Data.Puesto", b =>
                {
                    b.Property<int>("idPuesto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPuesto"));

                    b.Property<string>("nombrePuesto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPuesto");

                    b.ToTable("Puestos");
                });

            modelBuilder.Entity("Tarea9Docker.Data.Empleado", b =>
                {
                    b.HasOne("Tarea9Docker.Data.Puesto", "Puesto")
                        .WithMany()
                        .HasForeignKey("PuestoidPuesto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Puesto");
                });
#pragma warning restore 612, 618
        }
    }
}
