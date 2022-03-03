/// <reference path="dirpagination.js" />
/// <reference path="angular.min.js" />
var MyApp = angular.module('MyApp', ['angularUtils.directives.dirPagination']);

MyApp.controller('EmpCtrl', function ($scope, $http, EmployeeService) {
    $scope.currentPage = 1;
    $scope.pageSize = 5;

    $scope.reload = ()=> window.location.reload(); 

    $scope.ButtonClick = function () {
          var post =$http({
            method: "POST",
            url: "/Employees/UpdateEmpl",
            dataType: 'json',
            params: { id: $scope.EditEmp.Id, salary: $scope.EditEmp.Salary },
        }).then()
        {
            window.location.reload();
        }
    };


    $scope.getTotal = function gettotal() {
        var total = 0;
        for (var i = 0; i < $scope.Employees.length; i++) {
            total += $scope.Employees[i].Salary;
        }
        return total;
    };
    $scope.getemp = function (emp) {
        $scope.EditEmp = emp;


    };




    getEmployee();

    function getEmployee() {


        EmployeeService.getEmployee()

            .then(function (response) {

                $scope.Employees = response.data;


            })

            , (function (error) {

                $scope.status = 'Unable to load customer data: ' + error.message;

                console.log($scope.status);

            });


    }

});



MyApp.factory('EmployeeService', ['$http', function ($http) {



    var EmployeeService = {};

    EmployeeService.getEmployee = function () {

        return $http.get('/Employees/GetEmpl');

    };

    return EmployeeService;



}]);