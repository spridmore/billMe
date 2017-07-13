angular
  .module('billProject')
  .controller("congressPersonController", function ($scope, $state, $stateParams, $log, congressPersonService) {
    $scope.locate = [];
    $scope.locateByZip = [];
    $scope.zip = "";
    $scope.repDataArray = [];
    $scope.congressError = false;

    congressPersonService.geoLocate().then(function (response) {
      $scope.locate = response;
    });

    $scope.sendLocation = function () {
      congressPersonService.findReps($scope.locate.data.zip_code).then(function (response) {
        $scope.locateByZip = response.data.results;
      });
    }

    $scope.sendZip = function () {
      congressPersonService.findReps($scope.zip).then(function (response) {
        if($scope.zip == ""){
          $scope.congressError = true;
        }
        else {
          $scope.congressError = false;
        }
        $scope.locateByZip = response.data.results;   
      });
    }

    $scope.repData = function () { 
      $scope.repDataArray = []   
      for(var i = 0; i < $scope.locateByZip.length; i++){
       congressPersonService.findRepData($scope.locateByZip[i].bioguide_id).then(function (response) {
          $scope.repDataArray.push(response.data.results[0]);        
       });
      }; 
      };           
    
  });