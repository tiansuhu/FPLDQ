app.controller('LoginController', ['$rootScope', '$scope', '$translate', '$http', '$location', '$state', '$stateParams', '$timeout', '$interval', 'ControllerConfig',
function ($rootScope, $scope, $translate, $http, $location, $state, $stateParams, $timeout, $interval, Controller) {
    
    //进入页面触发
    $rootScope.$on('$viewContentLoaded', function () {
        $scope.Title = "登录";
    });
    $scope.loginIn = function () {
        $scope.userCode = $("#txtUser").val();
        $scope.userPassword = $("#txtPassword").val();
        if ($scope.userCode == "" || $scope.userCode == undefined) {
            focus("userCode");
            return;
        }
        if ($scope.userPassword == "" || $scope.userPassword == undefined) {
            focus("userPassword");
            return;
        }
        $http({
            url: Controller.Organization.LoginIn,
            method:"post",
            data: {
                userCode: this.userCode,
                password: this.userPassword,
                rendom: new Date().getTime()
            }
        })
        .success(function (result, header, config, status) {
           // $scope.$emit("LoginIn", result);//调用main.js 中的LoginIn事件
            // 设置主界面
            $state.go("app.homepage");

            if (result.Success) {
                "登录成功"
               
            }
            else {
               "登录失败"
            }
        })
        .error(function (data, header, config, status) {

        });
    }
}]);