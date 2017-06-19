﻿using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace MyCompanyName.AbpZeroTemplate.Products
{
    /// <summary>
    /// 基础数据产品信息业务管理
    /// </summary>
    public class ProductManage : IDomainService
    {
        private readonly IRepository<Product, int> _productRepository;

        /// <summary>
        /// 构造方法
        /// </summary>
        public ProductManage(IRepository<Product, int> productRepository)
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
