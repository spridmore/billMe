angular
  .module('billProject')
  .service('userService', function ($http) {

  this.addUser = function(userName, firstName, lastName, password, userId){
    return $http({
      url: 'http://localhost:5000/api/user/',
      method: 'POST',
      data: {"UserName" : userName, "FirstName" : firstName, "LastName" : lastName, "Password" : password, "UserId" : userId}
    })
  }
    
  })