using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCompanyName.AbpZeroTemplate.Dto;
using MyCompanyName.AbpZeroTemplate.Products.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        Task<GetProductForEditOutput> GetProductForEditAsync(ProductEditDto input);

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
