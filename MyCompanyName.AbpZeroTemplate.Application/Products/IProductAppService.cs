using Abp.Application.Services;
using MyCompanyName.AbpZeroTemplate.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Products
{
    public interface IProductAppService : IApplicationService
    {
        /// <summary>
        /// 根据查询条件获取产品分页列表
        /// </summary>
        Task<PagedResultOutput<ProductListDto>> GetProductList(GetProductQueryInput input);

        /// <summary>
        /// 获取指定id的产品信息
        /// </summary>
        Task<ProductDto> GetProduct(IdInput input);

        /// <summary>
        /// 新增或更改产品
        /// </summary>
        Task CreateOrUpdateProduct(ProductDto input);

        /// <summary>
        /// 新增产品
        /// </summary>
        Task<ProductDto> CreateProduct(ProductDto input);

        /// <summary>
        /// 更新产品
        /// </summary>
        Task UpdateProduct(ProductDto input);

        /// <summary>
        /// 删除产品
        /// </summary>
        Task DeleteProduct(IdInput input);

        /// <summary>
        /// 导出到表格
        /// </summary>
        /// <returns></returns>
        Task<FileDto> GetProductsToExcel();
    }
}
