
// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2017-06-16T18:32:57. All Rights Reserved.
//<生成时间>2017-06-16T18:32:57</生成时间>
namespace MyCompanyName.AbpZeroTemplate.Products
{
	
			//TODO:Angular后端的导航栏目设计

	/*
	//无次级导航属性
	   var product=new MenuItemDefinition(
                ProductAppPermissions.Product,
                L("Product"),
				url:"products",
				icon:"icon-grid",
				 requiredPermissionName: ProductAppPermissions.Product
				);

*/
				//有下级菜单
            /*

			   var product=new MenuItemDefinition(
                ProductAppPermissions.Product,
                L("Product"),			
				icon:"icon-grid"				
				);

				product.AddItem(
			new MenuItemDefinition(
			ProductAppPermissions.Product,
			L("Product"),
			"icon-star",
			url:"products",
			requiredPermissionName: ProductAppPermissions.Product));
	

			
			*/
	
			
	
	
	
	//配置权限模块初始化
 //TODO:★需要到请将以下内容剪切到AbpZeroTemplateApplicationModule
 //   Configuration.Authorization.Providers.Add<ProductAppAuthorizationProvider>();


 

//TODO:★请将以下内容剪切到CORE类库的Localization/Source/AbpZeroTemplatezh-cn.xml
//第一次加载建议复制他
// <text name="MustBe_Required" value="不能为空" />


/*
    <!-- 基础数据产品信息管理 -->
	    <text name="Product" value="基础数据产品信息" />
	    <text name="ProductHeaderInfo" value="基础数据产品信息管理列表" />
		    <text name="CreateProduct" value="新增基础数据产品信息" />
    <text name="EditProduct" value="编辑基础数据产品信息" />
    <text name="DeleteProduct" value="删除基础数据产品信息" />

	  
		

		    <text name="ProductDeleteWarningMessage" value="基础数据产品信息名称: {0} 将被删除,是否确定删除它。" />
<!--//用于表格展示的数据信息的标题-->
					<text name="ProductName" value="产品名称" />
				 	<text name="Classify" value="产品分类" />
				 	<text name="Comment" value="备注" />
				 	<text name="BusinessCategory" value="业务大类" />
				 	<text name="BusinessType" value="业务类型" />
				 
*/


//TODO:★请将以下内容剪切到CORE类库的Localization/Source/AbpZeroTemplate.xml
/*
    <!-- 基础数据产品信息english管理 -->
		    <text name="	ProductHeaderInfo" value="基础数据产品信息List" />
			<!--//用于表格展示的数据信息的标题-->
					<text name="ProductName" value="产品名称" />
				 	<text name="Classify" value="产品分类" />
				 	<text name="Comment" value="备注" />
				 	<text name="BusinessCategory" value="业务大类" />
				 	<text name="BusinessType" value="业务类型" />
				 
    <text name="Product" value="ManagementProduct" />
    <text name="CreateProduct" value="CreateProduct" />
    <text name="EditProduct" value="EditProduct" />
    <text name="DeleteProduct" value="DeleteProduct" />
*/




}