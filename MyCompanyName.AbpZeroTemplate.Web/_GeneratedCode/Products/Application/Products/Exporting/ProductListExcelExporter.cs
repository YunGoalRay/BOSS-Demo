                                                                            

        
// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2017-06-16T18:33:03. All Rights Reserved.
//<生成时间>2017-06-16T18:33:03</生成时间>
	using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Dynamic;
    using System.Text;
    using System.Threading.Tasks;
    using Abp;
    using Abp.Application.Services.Dto;
    using Abp.Authorization;
    using Abp.AutoMapper;
    using Abp.Configuration;
    using Abp.Domain.Repositories;
    using Abp.Extensions;
    using Abp.Linq.Extensions;
    using MyCompanyName.AbpZeroTemplate.Products.Authorization;
    using MyCompanyName.AbpZeroTemplate.Products.Dtos;
 
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
        public ProductListExcelExporter(ITimeZoneConverter timeZoneConverter,     IAbpSession abpSession)
        {
                       _timeZoneConverter = timeZoneConverter;    
                     _abpSession = abpSession;
        }

    

         /// <summary>
        /// 导出基础数据产品信息到EXCEL文件
        /// <param name="productListDtos">导出信息的DTO</param>
        /// </summary>
    public    FileDto ExportProductToFile(List<ProductListDto> productListDtos){


var file=CreateExcelPackage("productList.xlsx",excelPackage=>{

var sheet=excelPackage.Workbook.Worksheets.Add(L("Product"));
                    sheet.OutLineApplyStyle = true;

                    AddHeader(
                        sheet,
                          L("ProductName"),  
     L("Classify"),  
     L("Comment"),  
     L("BusinessCategory"),  
     L("BusinessType"),  
                        );
         AddObjects(sheet,2,productListDtos,
            
      _ => _.ProductName,   
       
      _ => _.Classify,   
       
      _ => _.Comment,   
       
      _ => _.BusinessCategory,   
       
      _ => _.BusinessType,   

);
                    //写个时间转换的吧
          //var creationTimeColumn = sheet.Column(10);
                    //creationTimeColumn.Style.Numberformat.Format = "yyyy-mm-dd";

        for (var i = 1; i <= 5; i++)
                    {
                        sheet.Column(i).AutoFit();
                    }       

});
   return file;

}


 

 
  

    }
    }
