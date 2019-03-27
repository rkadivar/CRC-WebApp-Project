
/* AUTHOR : Rashid Kadivar
   CREATE DATE : March 26, 2019
   PURPOSE : Bind the data with view and interact in full CRUD 
   */

var app = angular.module("Homeapp", ['angularUtils.directives.dirPagination']);
app.controller("HomeController", function ($scope, $http, $filter) {
    var date = new Date();
    $scope.btntext = "Save";
    $scope.type = ["Primary", "Secondary"];
    $scope.renewal = ["Yes", "No"];
    $scope.bandwidth = [6.250, 12.500, 25, 50, 100];
    $scope.qos = [1, 2, 3, 4, 5];
    $scope.trafficModel = ["voice&data", "voice", "iot", "data"];
    $scope.status = "Submitted";
    $scope.currentDate = $filter('date')(new Date(), 'MM/dd/yyyy');
    $scope.min = 138;
    $scope.max = 970;
    $scope.pageSize = 10;

    $scope.savedata = function ($route) {
        $scope.btntext = "please wait..";
        $http({
            method: 'POST',
            url: '/Home/Add_record',
            data: $scope.request
        }).success(function (d) {
            $scope.btntext = "save";
            $scope.request = null;
            alert(d);
            $route.reload();
        }).error(function () {
            alert('Failed');
        })
    }

    $scope.updatedata = function ($route) {
        $scope.btntext = "please wait..";
        $http({
            method: 'POST',
            url: '/Home/update_record',
            data: $scope.request
        }).success(function (d) {
            $scope.btntext = "save";
            $scope.request = null;
            alert(d);
            $route.reload();
        }).error(function () {
            alert('Failed');
        })
    }

    $http.get("/Home/Get_data").then(function (d) {
        $scope.record = d.data;
    }, function (error) {
        alert('Failed');
    });

    $scope.toggleModal = function (id) {
        $http.get("/Home/Get_databyid?id=" + id).then(function (d) {
            $scope.request = d.data[0];
        }, function (error) {
            alert('Failed');
        });
    }

    $scope.loadrecord = function (id) {
        $http.get("/Home/Get_databyid?id=" + id).then(function (d) {
            $scope.request = d.data[0];
        }, function (error) {
            alert('Failed');
        });
    }
    $scope.deleterecord = function (id) {
        $http.get("/Home/delete_record?id=" + id).then(function (d) {
            alert(d.data);
        }, function (error) {
            alert('Failed');
        });
    }

    $scope.sort = function (keyname) {
        $scope.sortKey = keyname;
        $scope.reverse = !$scope.reverse;
    }

});

app.directive('ngConfirmClick', [
    function () {
        return {
            priority: 1,
            terminal: true,
            link: function (scope, element, attr) {
                var msg = attr.ngConfirmClick || "Are you sure?";
                var clickAction = attr.ngClick;
                element.bind('click', function (event) {
                    if (window.confirm(msg)) {
                        scope.$eval(clickAction)
                    }
                });
            }
        };
    }]);

app.controller('OtherController', OtherController);

function OtherController($scope) {
    $scope.pageChangeHandler = function (num) {
        console.log('going to page ' + num);
    };
}