'use strict';

angular.module('myApp.factories', []).factory('Student', ['$resource',
    function ($resource) {
        var resource = $resource('http://localhost:2464/Api/Student', {}, { get: { method: 'GET', isArray: true } });
        return resource;
    }
]);



/* Controllers */

angular.module('myApp.controllers', [])
  .controller('MyCtrl1', ['$scope', 'Student', function ($scope, Student) {
      $scope.name = 'Tiger';
      $scope.students = [];

      Student.get(function(response) {
          $scope.students = response;
      });

  }])
  .controller('MyCtrl2', ['$scope', 'Student', function ($scope, Student) {

      $scope.name = '';
      $scope.phone = '';
      $scope.address = '';

      $scope.save = function() {
          Student.save({Name : $scope.name,Phone: $scope.phone,Address:$scope.address}, function(response) {
              if (response) {
                  $scope.notification = 'Student is saved';
                  $scope.name = '';
                  $scope.phone = '';
                  $scope.address = '';
              } else {
                  $scope.notification = 'Student is not saved';
              }
          });
      };

     
  }]);


