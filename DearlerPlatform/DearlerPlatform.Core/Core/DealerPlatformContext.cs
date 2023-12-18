using System;
using System.Collections.Generic;
using DearlerPlatform.Domain;
using Microsoft.EntityFrameworkCore;

namespace DearlerPlatform.Core;

public partial class DealerPlatformContext : DbContext
{
    public DealerPlatformContext()
    {
    }

    public DealerPlatformContext(DbContextOptions<DealerPlatformContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerInvoice> CustomerInvoices { get; set; }

    public virtual DbSet<CustomerPwd> CustomerPwds { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductPhoto> ProductPhotos { get; set; }

    public virtual DbSet<ProductSale> ProductSales { get; set; }

    public virtual DbSet<ProductSaleAreaDiff> ProductSaleAreaDiffs { get; set; }

    public virtual DbSet<SaleOrderDetail> SaleOrderDetails { get; set; }

    public virtual DbSet<SaleOrderMaster> SaleOrderMasters { get; set; }

    public virtual DbSet<SaleOrderProgress> SaleOrderProgresses { get; set; }

    public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=localhost;database=DealerPlatform;uid=LvMaxZz1;pwd=19981214zc;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerNo).HasName("PK_T200_customer_code");

            entity.Property(e => e.CustomerNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AreaName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AreaNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.BankAccount)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNote)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Ein)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.FirstAreaName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstAreaNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.HeadImgUrl)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.OpenId)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.OwnerWorkerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OwnerWorkerNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.OwnerWorkerTel)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Province)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Tel)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerInvoice>(entity =>
        {
            entity.HasKey(e => new { e.CustomerNo, e.InvoiceNo }).HasName("PK_T200_customer_invoice");

            entity.Property(e => e.CustomerNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceAccount)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceBank)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceEin)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InvoicePhone)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerPwd>(entity =>
        {
            entity.HasKey(e => e.CustomerNo).HasName("PK_T101_customer_psw");

            entity.Property(e => e.CustomerNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CustomerPwd1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CustomerPwd");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => new { e.SysNo, e.ProductNo }).HasName("PK_T200_product_code");

            entity.Property(e => e.SysNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProductNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BelongTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BelongTypeNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductBzgg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductBZGG");
            entity.Property(e => e.ProductCd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductCD");
            entity.Property(e => e.ProductCz)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductCZ");
            entity.Property(e => e.ProductDj)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductDJ");
            entity.Property(e => e.ProductGg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductGG");
            entity.Property(e => e.ProductGy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductGY");
            entity.Property(e => e.ProductHb)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductHB");
            entity.Property(e => e.ProductHd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductHD");
            entity.Property(e => e.ProductHs)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductHS");
            entity.Property(e => e.ProductMc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductMC");
            entity.Property(e => e.ProductName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProductNote)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ProductPp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductPP");
            entity.Property(e => e.ProductXh)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductXH");
            entity.Property(e => e.ProductYs)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductYS");
            entity.Property(e => e.TypeName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TypeNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UnitName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UnitNo)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductPhoto>(entity =>
        {
            entity.HasKey(e => e.ProductNo).HasName("PK_T200_product_photo");

            entity.Property(e => e.ProductNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductPhotoUrl)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SysNo)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductSale>(entity =>
        {
            entity.HasKey(e => new { e.SysNo, e.ProductNo }).HasName("PK_T201_product_sale_list");

            entity.Property(e => e.SysNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProductNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.StockNo)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductSaleAreaDiff>(entity =>
        {
            entity.HasKey(e => new { e.SysNo, e.ProductNo, e.StockNo, e.AreaNo }).HasName("PK_T201_product_sale_area_diff");

            entity.Property(e => e.SysNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProductNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StockNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.AreaNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.FirstAreaNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SaleOrderDetail>(entity =>
        {
            entity.HasKey(e => e.SaleOrderGuid);

            entity.Property(e => e.SaleOrderGuid)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InputDate).HasColumnType("datetime");
            entity.Property(e => e.ProductName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ProductNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ProductPhotoUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SaleOrderNo)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SaleOrderMaster>(entity =>
        {
            entity.HasKey(e => e.SaleOrderNo);

            entity.Property(e => e.SaleOrderNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.EditUserNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InputDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StockNo)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SaleOrderProgress>(entity =>
        {
            entity.HasKey(e => new { e.SaleOrderNo, e.ProgressGuid });

            entity.Property(e => e.SaleOrderNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ProgressGuid)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.StepName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StepTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ShoppingCart>(entity =>
        {
            entity.HasKey(e => e.CartGuid).HasName("PK_T200_shopping_cart");

            entity.Property(e => e.CartGuid)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductNo)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.StockNo).HasName("PK_T200_stock_code");

            entity.Property(e => e.StockNo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.StockLinkman)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.StockName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StockPhone)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.StockTel)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
