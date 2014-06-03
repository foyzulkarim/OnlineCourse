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
  .controller('MyCtrl2', ['$scope', function($scope) {

  }]);


