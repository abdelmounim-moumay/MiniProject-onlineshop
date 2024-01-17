﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineStore.Data;

namespace OnlineStore.Migrations
{
    [DbContext(typeof(OnlineStoreDbContext))]
    partial class OnlineStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineStore.Models.Database.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128)
                        .IsUnicode(true);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Smartphone"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Notebook"
                        },
                        new
                        {
                            Id = 3,
                            Name = "TV"
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Comment", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("ntext");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Path = "iphonexr.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Path = "samsung10e.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Path = "macbookpro16.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Path = "macbookpro13.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Path = "lgtv.jpg"
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool?>("CommentsEnabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("ntext")
                        .IsUnicode(true);

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(7,2)");

                    b.Property<string>("Producer")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("ImageId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2024, 1, 17, 12, 39, 54, 884, DateTimeKind.Local).AddTicks(3904),
                            CreatorUserId = 3,
                            Description = "Example of description about a smartphone.",
                            ImageId = 1,
                            Model = "iPhone XR 64GB",
                            Price = 760.0m,
                            Producer = "Apple"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2024, 1, 17, 12, 39, 54, 884, DateTimeKind.Local).AddTicks(4711),
                            CreatorUserId = 3,
                            Description = "New smartphone Samsung S10e is already in sale.",
                            ImageId = 2,
                            Model = "S10e SM-G970",
                            Price = 650.00m,
                            Producer = "Samsung"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2024, 1, 17, 12, 39, 54, 884, DateTimeKind.Local).AddTicks(4742),
                            CreatorUserId = 3,
                            Description = "New notebook from Apple is already in our store.",
                            ImageId = 3,
                            Model = "Macbook Pro 16\"",
                            Price = 2200.00m,
                            Producer = "Apple"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2024, 1, 17, 12, 39, 54, 884, DateTimeKind.Local).AddTicks(4748),
                            CreatorUserId = 3,
                            Description = "New notebook from Apple is already in our store.",
                            ImageId = 4,
                            Model = "MacBook Pro 13\" Space Gray",
                            Price = 1400.00m,
                            Producer = "Apple"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2024, 1, 17, 12, 39, 54, 884, DateTimeKind.Local).AddTicks(4753),
                            CreatorUserId = 3,
                            Description = "New TV with high resolution screen.",
                            ImageId = 5,
                            Model = "43UM7459",
                            Price = 450.00m,
                            Producer = "LG"
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FullPrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.PurchaseProduct", b =>
                {
                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.HasKey("PurchaseId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("PurchaseProducts");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Rate", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.ShoppingCart", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256)
                        .IsUnicode(true);

                    b.Property<string>("AuthValue")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128)
                        .IsUnicode(true);

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "",
                            CreationTime = new DateTime(2024, 1, 17, 12, 39, 54, 877, DateTimeKind.Local).AddTicks(880),
                            Email = "vasylvlasiuk@gmail.com",
                            LastLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Vasyl",
                            PasswordHash = @"%�Z҃�@
�d�mq<�",
                            RoleId = 1,
                            Surname = "Vlasiuk"
                        },
                        new
                        {
                            Id = 2,
                            Adress = "",
                            CreationTime = new DateTime(2024, 1, 17, 12, 39, 54, 884, DateTimeKind.Local).AddTicks(671),
                            Email = "johndoe@gmail.com",
                            LastLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John",
                            PasswordHash = "1[��N�W��?�}",
                            RoleId = 2,
                            Surname = "Doe"
                        },
                        new
                        {
                            Id = 3,
                            Adress = "",
                            CreationTime = new DateTime(2024, 1, 17, 12, 39, 54, 884, DateTimeKind.Local).AddTicks(1082),
                            Email = "ostepbondar@gmail.com",
                            LastLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ostap",
                            PasswordHash = "^�g�9ƏQE�/���\"	",
                            RoleId = 3,
                            Surname = "Bondar"
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Database.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Moderator"
                        },
                        new
                        {
                            Id = 1,
                            Name = "SimpleUser"
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Comment", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Database.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Product", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Database.User", "CreatorUser")
                        .WithMany("Products")
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Database.Image", "Image")
                        .WithMany("Products")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Purchase", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.User", "User")
                        .WithMany("Purchases")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineStore.Models.Database.PurchaseProduct", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.Product", "Product")
                        .WithMany("PurchaseProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Database.Purchase", "Purchase")
                        .WithMany("PurchaseProducts")
                        .HasForeignKey("PurchaseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Rate", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.Product", "Product")
                        .WithMany("Rates")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Database.User", "User")
                        .WithMany("Rates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineStore.Models.Database.ShoppingCart", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.Product", "Product")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Database.User", "User")
                        .WithMany("ShoppingCart")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineStore.Models.Database.User", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.UserRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
