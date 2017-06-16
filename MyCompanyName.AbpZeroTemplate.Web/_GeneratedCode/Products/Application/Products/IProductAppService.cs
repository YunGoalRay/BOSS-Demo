

// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2017-06-16T18:32:54. All Rights Reserved.
//<生成时间>2017-06-16T18:32:54</生成时间>
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCompanyName.AbpZeroTemplate.Products.Dtos;

namespace MyCompanyName.AbpZeroTemplate.Products
{
	/// <summary>
    /// 基础数据产品信息服务接口
    /// </summary>
    public interface IProductAppService : IApplicationService
    {
        #region 基础数据产品信息管理

        /// <summary>
        /// 根据查询条件获取基础数据产品信息分页列表
        /// </summary>
        Task<PagedResultDto<ProductListDto>> GetPagedProductsAsync(GetProductInput input);

        /// <summary>
        /// 通过Id获取基础数据产品信息信息进行编辑或修改 
        /// </summary>
        Task<GetProductForEditOutput> GetProductForEditAsync(NullableIdDto<string> input);

		  /// <summary>
        /// 通过指定id获取基础数据产品信息ListDto信息
        /// </summary>
		Task<ProductListDto> GetProductByIdAsync(EntityDto<string> input);



        /// <summary>
        /// 新增或更改基础数据产品信息
        /// </summary>
        Task CreateOrUpdateProductAsync(CreateOrUpdateProductInput input);





        /// <summary>
        /// 新增基础数据产品信息
        /// </summary>
        Task<ProductEditDto> CreateProductAsync(ProductEditDto input);

        /// <summary>
        /// 更新基础数据产品信息
        /// </summary>
        Task UpdateProductAsync(ProductEditDto input);

        /// <summary>
        /// 删除基础数据产品信息
        /// </summary>
        Task DeleteProductAsync(EntityDto<string> input);

        /// <summary>
        /// 批量删除基础数据产品信息
        /// </summary>
        Task BatchDeleteProductAsync(List<string> input);

        #endregion

#region Excel导出功能



         /// <summary>
        /// 获取基础数据产品信息信息转换为Excel
        /// </summary>
        /// <returns></returns>
        Task<FileDto> GetProductToExcel();

#endregion





    }
}
