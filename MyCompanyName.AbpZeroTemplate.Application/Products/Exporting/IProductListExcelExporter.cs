using MyCompanyName.AbpZeroTemplate.Dto;
using MyCompanyName.AbpZeroTemplate.Products.Dtos;
using System.Collections.Generic;

namespace MyCompanyName.AbpZeroTemplate.Products
{
    /// <summary>
    /// 基础数据产品信息的数据导出功能 
    /// </summary>
    public interface IProductListExcelExporter
    {
        /// <summary>
        /// 导出基础数据产品信息到EXCEL文件
        /// <param name="productListDtos">导出信息的DTO</param>
        /// </summary>
        FileDto ExportProductToFile(List<ProductListDto> productListDtos);
    }
}
