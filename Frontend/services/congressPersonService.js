angular
  .module('billProject')
  .service('congressPersonService', function ($http) {

    this.geoLocate = function () {
      return $http.get("http://localhost:5000/api/geolocator")
    };

     this.findReps = function (zip) {
      return $http.get("http://localhost:5000/api/geolocator/" + zip)
    };

    this.findRepData = function(id) {
      return $http.get("http://localhost:5000/api/RepContactData/" + id)
    };

  })