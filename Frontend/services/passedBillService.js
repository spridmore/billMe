angular
  .module('billProject')
  .service('passedBillService', function ($http) {

    this.getPassedBill = function() {
      return $http.get('http://localhost:5000/api/PassedBill');
    }

    this.sendSubject = function(subject) {
      return $http.get('http://localhost:5000/api/PassedBill/' + subject);
    }
    
    this.submitComment = function(comment, author, commentBillId) {
      return $http({
        url: 'http://localhost:5000/api/comments/',
        method: "POST",
        data: { "Body" : comment, "Author" : author, "commentBillId" : commentBillId}
      });
    }

    this.returnComment = function() {
      return $http.get('http://localhost:5000/api/comments/')
    }
    
  });