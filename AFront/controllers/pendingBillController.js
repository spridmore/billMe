angular
  .module('billProject')
  .controller("pendingBillController", function ($scope, $state, $stateParams, $log, pendingBillService) {
   
    $scope.pending = [];
    $scope.subjectReturned = [];
    $scope.subject = "";
    
    pendingBillService.getPendingBill().then(function (response) {
      $scope.pending = response.data.results;
    });
  
    $scope.sendSubject = function() {
      pendingBillService.sendSubject($scope.subject).then(function (response) {
      $scope.subjectReturned = response.data.results;
      })
      $scope.pending = []
      if($scope.subject == ""){
        $scope.billError = true
      }
      else{
        $scope.billError = false;
      }
    }
  });