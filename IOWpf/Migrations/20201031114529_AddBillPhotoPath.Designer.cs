﻿// <auto-generated />
using System;
using IOWpf.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IOWpf.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20201031114529_AddBillPhotoPath")]
    partial class AddBillPhotoPath
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("IOWpf.Models.Balance", b =>
                {
                    b.Property<int>("BalanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("curr_balance")
                        .HasColumnType("REAL");

                    b.HasKey("BalanceId");

                    b.ToTable("Balances");
                });

            modelBuilder.Entity("IOWpf.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category_name")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("IOWpf.Models.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("amount")
                        .HasColumnType("REAL");

                    b.Property<string>("bill_photo_path")
                        .HasColumnType("TEXT");

                    b.Property<string>("creator_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("if_childs")
                        .HasColumnType("INTEGER");

                    b.HasKey("ExpenseId");

                    b.HasIndex("UserId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("IOWpf.Models.Expense_Category", b =>
                {
                    b.Property<int>("ExpenseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ExpenseId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Expense_Categories");
                });

            modelBuilder.Entity("IOWpf.Models.Income", b =>
                {
                    b.Property<int>("IncomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("amount")
                        .HasColumnType("REAL");

                    b.Property<string>("creator_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("if_childs")
                        .HasColumnType("INTEGER");

                    b.HasKey("IncomeId");

                    b.HasIndex("UserId");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("IOWpf.Models.Piggy_bank", b =>
                {
                    b.Property<int>("Piggy_bankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("creator_name")
                        .HasColumnType("TEXT");

                    b.Property<float>("goal")
                        .HasColumnType("REAL");

                    b.Property<string>("goal_date")
                        .HasColumnType("TEXT");

                    b.Property<string>("goal_namel")
                        .HasColumnType("TEXT");

                    b.Property<bool>("if_childs")
                        .HasColumnType("INTEGER");

                    b.Property<float>("monthly_income")
                        .HasColumnType("REAL");

                    b.Property<int>("start_day")
                        .HasColumnType("INTEGER");

                    b.Property<float>("treasured_amount")
                        .HasColumnType("REAL");

                    b.HasKey("Piggy_bankId");

                    b.ToTable("Piggy_Banks");
                });

            modelBuilder.Entity("IOWpf.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BalanceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("BalanceId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("IOWpf.Models.User_Piggy_bank", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Piggy_bankId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "Piggy_bankId");

                    b.HasIndex("Piggy_bankId");

                    b.ToTable("User_Piggy_banks");
                });

            modelBuilder.Entity("IOWpf.Models.Child", b =>
                {
                    b.HasBaseType("IOWpf.Models.User");

                    b.HasDiscriminator().HasValue("Child");
                });

            modelBuilder.Entity("IOWpf.Models.Grown_up", b =>
                {
                    b.HasBaseType("IOWpf.Models.User");

                    b.HasDiscriminator().HasValue("Grown_up");
                });

            modelBuilder.Entity("IOWpf.Models.Admin", b =>
                {
                    b.HasBaseType("IOWpf.Models.Grown_up");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("IOWpf.Models.Expense", b =>
                {
                    b.HasOne("IOWpf.Models.User", "User")
                        .WithMany("Expenses")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("IOWpf.Models.Expense_Category", b =>
                {
                    b.HasOne("IOWpf.Models.Category", "Category")
                        .WithMany("Expense_Categories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IOWpf.Models.Expense", "Expense")
                        .WithMany("Expense_Categories")
                        .HasForeignKey("ExpenseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IOWpf.Models.Income", b =>
                {
                    b.HasOne("IOWpf.Models.User", "User")
                        .WithMany("Incomes")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("IOWpf.Models.User", b =>
                {
                    b.HasOne("IOWpf.Models.Balance", "Balance")
                        .WithMany("User")
                        .HasForeignKey("BalanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IOWpf.Models.User_Piggy_bank", b =>
                {
                    b.HasOne("IOWpf.Models.Piggy_bank", "Piggy_bank")
                        .WithMany("User_Piggy_banks")
                        .HasForeignKey("Piggy_bankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IOWpf.Models.User", "User")
                        .WithMany("User_Piggy_banks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}