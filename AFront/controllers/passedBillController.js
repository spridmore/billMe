angular
  .module('billProject')
  .controller("passedBillController", function ($scope, $state, $stateParams, passedBillService) {

    $scope.passed = [];
    $scope.subjectReturned = [];
    $scope.subject = "";
    $scope.returnedComments = [];
    // $scope.bob = "";

    passedBillService.getPassedBill().then(function (response) {
      $scope.passed = response.data.results;
    })

    passedBillService.returnComment().then(function (response) {
      $scope.comments = response.data;
    })

    $scope.sendSubjectPassed = function () {
      passedBillService.sendSubject($scope.subject).then(function (response) {
        $scope.subjectReturned = response.data.results;
      });
      $scope.passed = [];
    }

    $scope.submitComment = function (bill) {
      for (var i = 0; i < $scope.passed.length; i++) {
      var commentBillId = $scope.passed[i].bill_id;
      if ($scope.bob = commentBillId) {
      passedBillService.submitComment(bill.comment, bill.author, commentBillId).then(function (response) {
      })
     }
   }
 }
})
    