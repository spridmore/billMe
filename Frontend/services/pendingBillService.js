angular
  .module('billProject')
  .service('pendingBillService', function ($http) {

    this.getPendingBill = function() {
      return $http.get('http://localhost:5000/api/PendingBill')
    }
    
    this.sendSubject = function(subject) {
      // console.log(subject)
      return $http.get('http://localhost:5000/api/PendingBill/' + subject)
    }
 
  })