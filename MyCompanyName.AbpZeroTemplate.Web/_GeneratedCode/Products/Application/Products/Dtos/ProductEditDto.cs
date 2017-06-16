
// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2017-06-16T18:32:49. All Rights Reserved.
//<生成时间>2017-06-16T18:32:49</生成时间>
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Abp.Extensions;
using MyCompanyName.AbpZeroTemplate.Products;

namespace MyCompanyName.AbpZeroTemplate.Products.Dtos
{
    /// <summary>
    /// 基础数据产品信息编辑用Dto
    /// </summary>
    [AutoMap(typeof(Product))]
    public class ProductEditDto 
    {

	/// <summary>
    ///   主键Id
    /// </summary>
    [DisplayName("主键Id")]
	public string? Id{get;set;}

        /// <summary>
        /// 产品名称
        /// </summary>
        [DisplayName("产品名称")]
        [Required]
        [MaxLength(128)]
        public   string  ProductName { get; set; }

        /// <summary>
        /// 产品分类
        /// </summary>
        [DisplayName("产品分类")]
        [Required]
        [MaxLength(256)]
        public   string  Classify { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        [MaxLength(256)]
        public   string  Comment { get; set; }

        /// <summary>
        /// 业务大类
        /// </summary>
        [DisplayName("业务大类")]
        [Required]
        [MaxLength(64)]
        public   string  BusinessCategory { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [DisplayName("业务类型")]
        [Required]
        [MaxLength(64)]
        public   string  BusinessType { get; set; }

    }
}
