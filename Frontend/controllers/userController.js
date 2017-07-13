angular
.module('billProject')
.controller("userController", function ($scope, $state, $stateParams, userService){

userId = 0;

  $scope.addUser = function() {
    userService.addUser($scope.userName, $scope.firstName, $scope.lastName, $scope.password, userId++)
  }

})