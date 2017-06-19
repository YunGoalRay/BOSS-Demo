using Abp.Runtime.Session;
using Abp.Timing.Timezone;
using MyCompanyName.AbpZeroTemplate.DataExporting.Excel.EpPlus;
using MyCompanyName.AbpZeroTemplate.Dto;
using MyCompanyName.AbpZeroTemplate.Products.Dtos;
using System.Collections.Generic;

namespace MyCompanyName.AbpZeroTemplate.Products
{
    /// <summary>
    /// 基础数据产品信息的导出EXCEL功能的实现
    /// </summary>
    public class ProductListExcelExporter : EpPlusExcelExporterBase, IProductListExcelExporter
    {

        private readonly ITimeZoneConverter _timeZoneConverter;
        private readonly IAbpSession _abpSession;


        /// <summary>
        /// 构造方法
        /// </summary>
        public ProductListExcelExporter(ITimeZoneConverter timeZoneConverter, IAbpSession abpSession)
        {
            _timeZoneConverter = timeZoneConverter;
            _abpSession = abpSession;
        }

        /// <summary>
        /// 导出基础数据产品信息到EXCEL文件
        /// <param name="productListDtos">导出信息的DTO</param>
        /// </summary>
        public FileDto ExportProductToFile(List<ProductListDto> productListDtos)
        {
            var file = CreateExcelPackage("productList.xlsx", excelPackage => {
                var sheet = excelPackage.Workbook.Worksheets.Add(L("Product"));
                sheet.OutLineApplyStyle = true;

                AddHeader(
                    sheet,
                      L("ProductName"),
                      L("Classify"),
                      L("Comment"),
                      L("BusinessCategory"),
                      L("BusinessType"));
                AddObjects(sheet, 2, productListDtos,
                    _ => _.ProductName,
                    _ => _.Classify,
                    _ => _.Comment,
                    _ => _.BusinessCategory,
                    _ => _.BusinessType);
                
                //时间转换
                var creationTimeColumn = sheet.Column(10);
                creationTimeColumn.Style.Numberformat.Format = "yyyy-mm-dd";

                for (var i = 1; i <= 5; i++)
                {
                    sheet.Column(i).AutoFit();
                }
            });
            return file;
        }
    }
}
