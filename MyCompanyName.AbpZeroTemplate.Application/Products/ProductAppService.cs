﻿using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using MyCompanyName.AbpZeroTemplate.Products.Authorization;
using MyCompanyName.AbpZeroTemplate.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Products
{
    /// <summary>
    /// 基础数据产品信息服务实现
    /// </summary>
    [AbpAuthorize(ProductAppPermissions.Product)]
    public class ProductAppService : AbpZeroTemplateAppServiceBase,IProductAppService
    {
        private readonly IRepository<Product, int> _productRepository;


        private readonly ProductManage _productManage;
        /// <summary>
        /// 构造方法
        /// </summary>
        public ProductAppService(IRepository<Product, int> productRepository,
ProductManage productManage

  )
        {
            _productRepository = productRepository;
            _productManage = productManage;

        }

        #region 基础数据产品信息管理

        /// <summary>
        /// 根据查询条件获取基础数据产品信息分页列表
        /// </summary>
        public async Task<PagedResultDto<ProductListDto>> GetPagedProductsAsync(GetProductInput input)
        {

            var query = _productRepository.GetAll();
            //TODO:根据传入的参数添加过滤条件

            var productCount = await query.CountAsync();

            var products = await query
            .OrderBy(input.Sorting)
            .PageBy(input)
            .ToListAsync();

            var productListDtos = products.MapTo<List<ProductListDto>>();
            return new PagedResultDto<ProductListDto>(
            productCount,
            productListDtos
            );
        }

        /// <summary>
        /// 通过Id获取基础数据产品信息信息进行编辑或修改 
        /// </summary>
        public async Task<GetProductForEditOutput> GetProductForEditAsync(NullableIdDto<int> input)
        {
            var output = new GetProductForEditOutput();

            ProductEditDto productEditDto;

            if (input.Id.HasValue)
            {
                var entity = await _productRepository.GetAsync(input.Id.Value);
                productEditDto = entity.MapTo<ProductEditDto>();
            }
            else
            {
                productEditDto = new ProductEditDto();
            }

            output.Product = productEditDto;
            return output;
        }


        /// <summary>
        /// 通过指定id获取基础数据产品信息ListDto信息
        /// </summary>
        public async Task<ProductListDto> GetProductByIdAsync(EntityDto<int> input)
        {
            var entity = await _productRepository.GetAsync(input.Id);

            return entity.MapTo<ProductListDto>();
        }







        /// <summary>
        /// 新增或更改基础数据产品信息
        /// </summary>
        public async Task CreateOrUpdateProductAsync(CreateOrUpdateProductInput input)
        {
            if (input.ProductEditDto.Id.HasValue)
            {
                await UpdateProductAsync(input.ProductEditDto);
            }
            else
            {
                await CreateProductAsync(input.ProductEditDto);
            }
        }

        /// <summary>
        /// 新增基础数据产品信息
        /// </summary>
        [AbpAuthorize(ProductAppPermissions.Product_CreateProduct)]
        public virtual async Task<ProductEditDto> CreateProductAsync(ProductEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = input.MapTo<Product>();

            entity = await _productRepository.InsertAsync(entity);
            return entity.MapTo<ProductEditDto>();
        }

        /// <summary>
        /// 编辑基础数据产品信息
        /// </summary>
        [AbpAuthorize(ProductAppPermissions.Product_EditProduct)]
        public virtual async Task UpdateProductAsync(ProductEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _productRepository.GetAsync(input.Id.Value);
            input.MapTo(entity);

            await _productRepository.UpdateAsync(entity);
        }

        /// <summary>
        /// 删除基础数据产品信息
        /// </summary>
        [AbpAuthorize(ProductAppPermissions.Product_DeleteProduct)]
        public async Task DeleteProductAsync(EntityDto<int> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _productRepository.DeleteAsync(input.Id);
        }

        /// <summary>
        /// 批量删除基础数据产品信息
        /// </summary>
        [AbpAuthorize(ProductAppPermissions.Product_DeleteProduct)]
        public async Task BatchDeleteProductAsync(List<int> input)
        {
            //TODO:批量删除前的逻辑判断，是否允许删除
            await _productRepository.DeleteAsync(s => input.Contains(s.Id));
        }

        #endregion












    }
}
