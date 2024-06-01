﻿// <auto-generated />
using DDDSample1.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DDDNetCore.Migrations
{
    [DbContext(typeof(DDDSample1DbContext))]
    [Migration("20230104153112_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DDDSample1.Domain.Armazens.Armazem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Armazens");
                });

            modelBuilder.Entity("DDDSample1.Domain.Categories.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DDDSample1.Domain.Entregas.Entrega", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("_ArmazemId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("_ArmazemId");

                    b.ToTable("Entregas");
                });

            modelBuilder.Entity("DDDSample1.Domain.Families.Family", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("DDDSample1.Domain.Products.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DDDSample1.Domain.Users.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DDDSample1.Domain.Armazens.Armazem", b =>
                {
                    b.OwnsOne("DDDSample1.Domain.Armazens.Altitude", "_Altitude", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("varchar(255)");

                            b1.Property<double>("altitude")
                                .HasColumnType("double");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Armazens.CidadeNo", "_CidadeNo", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("varchar(255)");

                            b1.Property<int>("no")
                                .HasColumnType("int");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Armazens.Designacao", "_Designacao", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("designacao")
                                .HasColumnType("longtext");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Armazens.Endereco", "_Endereco", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("endereco")
                                .HasColumnType("longtext");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Armazens.Latitude", "_Latitude", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("varchar(255)");

                            b1.Property<double>("latitude")
                                .HasColumnType("double");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Armazens.LojaId", "_LojaId", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("lojaId")
                                .HasColumnType("longtext");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Armazens.Longitude", "_Longitude", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("varchar(255)");

                            b1.Property<double>("longitude")
                                .HasColumnType("double");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Armazens.Municipio", "_Municipio", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("municipe")
                                .HasColumnType("longtext");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.Navigation("_Altitude");

                    b.Navigation("_CidadeNo");

                    b.Navigation("_Designacao");

                    b.Navigation("_Endereco");

                    b.Navigation("_Latitude");

                    b.Navigation("_LojaId");

                    b.Navigation("_Longitude");

                    b.Navigation("_Municipio");
                });

            modelBuilder.Entity("DDDSample1.Domain.Entregas.Entrega", b =>
                {
                    b.HasOne("DDDSample1.Domain.Armazens.Armazem", null)
                        .WithMany("Entregas")
                        .HasForeignKey("_ArmazemId");

                    b.OwnsOne("DDDSample1.Domain.Entregas.DataEntrega", "_DataEntrega", b1 =>
                        {
                            b1.Property<string>("EntregaId")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("data")
                                .HasColumnType("longtext");

                            b1.HasKey("EntregaId");

                            b1.ToTable("Entregas");

                            b1.WithOwner()
                                .HasForeignKey("EntregaId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Entregas.MassaEntrega", "_MassaEntrega", b1 =>
                        {
                            b1.Property<string>("EntregaId")
                                .HasColumnType("varchar(255)");

                            b1.Property<double>("massa")
                                .HasColumnType("double");

                            b1.HasKey("EntregaId");

                            b1.ToTable("Entregas");

                            b1.WithOwner()
                                .HasForeignKey("EntregaId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Entregas.TempoColocar", "_TempoColocar", b1 =>
                        {
                            b1.Property<string>("EntregaId")
                                .HasColumnType("varchar(255)");

                            b1.Property<int>("_tempoColocar")
                                .HasColumnType("int");

                            b1.HasKey("EntregaId");

                            b1.ToTable("Entregas");

                            b1.WithOwner()
                                .HasForeignKey("EntregaId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Entregas.TempoRetirar", "_TempoRetirar", b1 =>
                        {
                            b1.Property<string>("EntregaId")
                                .HasColumnType("varchar(255)");

                            b1.Property<int>("_tempoRetirar")
                                .HasColumnType("int");

                            b1.HasKey("EntregaId");

                            b1.ToTable("Entregas");

                            b1.WithOwner()
                                .HasForeignKey("EntregaId");
                        });

                    b.Navigation("_DataEntrega");

                    b.Navigation("_MassaEntrega");

                    b.Navigation("_TempoColocar");

                    b.Navigation("_TempoRetirar");
                });

            modelBuilder.Entity("DDDSample1.Domain.Users.User", b =>
                {
                    b.OwnsOne("DDDSample1.Domain.Users.Email", "_Email", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("email")
                                .HasColumnType("longtext");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Users.Nome", "_Nome", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("nome")
                                .HasColumnType("longtext");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Users.Password", "_Password", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("password")
                                .HasColumnType("longtext");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Users.Role", "_Role", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("role")
                                .HasColumnType("longtext");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Users.Telefone", "_Telefone", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("varchar(255)");

                            b1.Property<int>("telefone")
                                .HasColumnType("int");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("_Email")
                        .IsRequired();

                    b.Navigation("_Nome")
                        .IsRequired();

                    b.Navigation("_Password")
                        .IsRequired();

                    b.Navigation("_Role");

                    b.Navigation("_Telefone")
                        .IsRequired();
                });

            modelBuilder.Entity("DDDSample1.Domain.Armazens.Armazem", b =>
                {
                    b.Navigation("Entregas");
                });
#pragma warning restore 612, 618
        }
    }
}