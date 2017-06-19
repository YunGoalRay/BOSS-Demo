// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2017-06-16T18:32:58. All Rights Reserved.
//<生成时间>2017-06-16T18:32:58</生成时间>
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;

namespace MyCompanyName.AbpZeroTemplate.Products
{
    /// <summary>
    /// 基础数据产品信息业务管理
    /// </summary>
    public class ProductManage : IDomainService
    {
        private readonly IRepository<Product, string> _productRepository;

        /// <summary>
        /// 构造方法
        /// </summary>
        public ProductManage(IRepository<Product, string> productRepository)
        {
            _productRepository = productRepository;
        }

        //TODO:编写领域业务代码
        /// <summary>
        ///     初始化
        /// </summary>
        private void Init()
        {
        }
    }
}
