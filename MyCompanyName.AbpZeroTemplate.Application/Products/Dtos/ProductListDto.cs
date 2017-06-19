using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel;

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
