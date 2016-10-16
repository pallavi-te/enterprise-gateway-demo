var myapp = angular.module("myapp", []);
myapp.controller("HomeController", function($scope) {
    console.log("Welcome to demo");

    $scope.Demo = {
        IsStarted: false,
        IsResetRequired: false,
    };
});