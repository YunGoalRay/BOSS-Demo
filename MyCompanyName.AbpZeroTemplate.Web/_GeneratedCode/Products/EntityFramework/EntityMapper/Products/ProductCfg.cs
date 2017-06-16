 // 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2017-06-16T18:33:01. All Rights Reserved.
//<生成时间>2017-06-16T18:33:01</生成时间>
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
		            ToTable("Product", AbpZeroTemplateConsts.SchemaName.Basic);
 
      //todo: 需要将以下文件注入到AbpZeroTemplateDbContext中

  //		public IDbSet<Product> Products { get; set; }
   //		 modelBuilder.Configurations.Add(new ProductCfg());




		    // 产品名称
			Property(a => a.ProductName).HasMaxLength(128);
		    // 产品分类
			Property(a => a.Classify).HasMaxLength(256);
		    // 备注
			Property(a => a.Comment).HasMaxLength(256);
		    // 业务大类
			Property(a => a.BusinessCategory).HasMaxLength(64);
		    // 业务类型
			Property(a => a.BusinessType).HasMaxLength(64);
		}
    }
}