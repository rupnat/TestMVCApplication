(function() {

    var app = angular.module('AngularApp', []);    

    var CustomerController = function ($scope, $http) {

        var getCustomers = function (response) {
            $scope.Customers = response.data;
        };

        var onError = function (reason) {
            $scope.error = "Could not fetch data.";
        };


        $http.get("/api/Customer/Get").then(getCustomers, onError);

    };

    app.controller('CustomerController', CustomerController);

}());