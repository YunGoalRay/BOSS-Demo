(function () {
    appModule.controller('common.views.products.createOrEditModal', [
        '$scope', '$uibModalInstance', 'abp.services.app.product', 'productId',
        function ($scope, $uibModalInstance, productService, productId) {
            var vm = this;
            vm.saving = false;
            //首先将product数据设置为null
            vm.product = null;



            //触发保存方法
            vm.save = function () {
                vm.saving = true;
                productService.createOrUpdateProductAsync({ productEditDto: vm.product }).then(function () {
                    abp.notify.info(app.localize('SavedSuccessfully'));
                    $uibModalInstance.close();
                }).finally(function () {
                    vm.saving = false;
                });


            };
            //取消关闭页面
            vm.cancel = function () {
                $uibModalInstance.dismiss();
            };

            //初始化页面
            function init() {
                //   console.log(productId);
                productService.getProductForEditAsync({
                    id: productId
                }).then(function (result) {
                    //      console.log(result);
                    //console.log(result.data);
                    vm.product = result.data.product;
                });
            }
            //执行初始化方法
            init();
        }
    ]);
})();