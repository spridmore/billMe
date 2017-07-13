angular
  .module('billProject')
  .controller("passedBillController", function ($scope, $state, $stateParams, passedBillService) {

    $scope.passed = [];
    $scope.subjectReturned = [];
    $scope.subject = "";
    $scope.billComment = "";
    $scope.commentHolder = [];
    $scope.returnedComments = [];
    $scope.comments = "";
    $scope.userName = "";
    $scope.billComment = "";
    $scope.billError = false;
    $scope.billId = "";
    $scope.value = "";

    passedBillService.getPassedBill().then(function (response) {
      $scope.passed = response.data.results;
    })


    $scope.showComments = function (billId) {
      passedBillService.returnComment().then(function (response) {
        
        
        $scope.returnedComments = [];
        for (var i = 0; i < response.data.length; i++) {
          if (billId == response.data[i].commentBillId) {
            $scope.returnedComments.push(response.data[i])
          }
        }
      })
    }   

    $scope.sendSubjectPassed = function () {
      passedBillService.sendSubject($scope.subject).then(function (response) {
        $scope.subjectReturned = response.data.results;
      });
      $scope.passed = [];
      if($scope.subject == ""){
        $scope.billError = true
      }
      else{
        $scope.billError = false;
      }
    }

    $scope.submitComment = function (comment, userName, billId) {
      passedBillService.submitComment(comment, userName, billId).then(function (response) {
      $scope.showComments(billId)
      $scope.billComment = "";
      $scope.userName = "";
     
      
    })
  }
 
  })
