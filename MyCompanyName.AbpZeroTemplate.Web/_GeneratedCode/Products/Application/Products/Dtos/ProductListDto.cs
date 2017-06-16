
// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
//<Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2017-06-16T18:32:50. All Rights Reserved.
//<生成时间>2017-06-16T18:32:50</生成时间>
using System;
using System.ComponentModel;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyCompanyName.AbpZeroTemplate.Products;

namespace MyCompanyName.AbpZeroTemplate.Products.Dtos
{
	/// <summary>
    /// 基础数据产品信息列表Dto
    /// </summary>
    [AutoMapFrom(typeof(Product))]
    public class ProductListDto : EntityDto<string>
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        [DisplayName("产品名称")]
        public      string ProductName { get; set; }
        /// <summary>
        /// 产品分类
        /// </summary>
        [DisplayName("产品分类")]
        public      string Classify { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        public      string Comment { get; set; }
        /// <summary>
        /// 业务大类
        /// </summary>
        [DisplayName("业务大类")]
        public      string BusinessCategory { get; set; }
        /// <summary>
        /// 业务类型
        /// </summary>
        [DisplayName("业务类型")]
        public      string BusinessType { get; set; }
    }
}
