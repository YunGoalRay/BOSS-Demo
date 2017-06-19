using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Products
{
    /// <summary>
    /// 基础数据产品信息
    /// </summary>
    public class Product: Entity<string>
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        public override string Id { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public virtual string ProductName { get; set; }
        /// <summary>
        /// 产品分类
        /// </summary>
        public virtual string Classify { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Comment { get; set; }
        /// <summary>
        /// 业务大类
        /// </summary>
        public virtual string BusinessCategory { get; set; }
        /// <summary>
        /// 业务类型
        /// </summary>
        public virtual string BusinessType { get; set; }
    }
}
