app.controller('LoginController', ['$rootScope', '$scope', '$translate', '$http', '$location', '$state', '$stateParams', '$timeout', '$interval', 'ControllerConfig',
function ($rootScope, $scope, $translate, $http, $location, $state, $stateParams, $timeout, $interval, Controller) {
    $scope.LoginSuccess = true;
    $scope.ConnectionFailed = true;
    $scope.EnginePasswordValid = true;//引擎密码错误
    //进入页面触发
    $rootScope.$on('$viewContentLoaded', function () {

    });

    // 获取语言
    $rootScope.$on('$translateChangeEnd', function () {
       
    });
    $scope.getLanguage = function () {
       
    }
   


    //钉钉单点登录开始
    // 处理单点登录
    $scope.getUrlParam = function (name) {
        
    };

    $scope.loginIn = function () {
        
    }
}]);