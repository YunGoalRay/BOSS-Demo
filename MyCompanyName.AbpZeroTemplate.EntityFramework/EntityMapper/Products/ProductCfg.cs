using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using MyCompanyName.AbpZeroTemplate.Products;

namespace MyCompanyName.AbpZeroTemplate.Products.EntityMapper.Products
{

	/// <summary>
    /// 基础数据产品信息的数据配置文件
    /// </summary>
    public class ProductCfg : EntityTypeConfiguration<Product>
    {
		/// <summary>
        ///  构造方法[默认链接字符串< see cref = "AbpZeroTemplateDbContext" /> ]
        /// </summary>
		public ProductCfg ()
		{
		    ToTable("Product");

            // 产品ID
            Property(a => a.ProductId).HasMaxLength(32);
            // 产品名称
            Property(a => a.ProductName).HasMaxLength(32);
            // 产品分类
            Property(a => a.Classify).HasMaxLength(64);
            // 备注
            Property(a => a.Comment).HasMaxLength(255);
            // 业务大类
            Property(a => a.BusinessCategory).HasMaxLength(64);
            // 业务类型
            Property(a => a.BusinessType).HasMaxLength(64);
        }
    }
}