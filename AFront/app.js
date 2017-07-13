var app = angular.module("billProject", ["ui.router"]);

app.config(function ($stateProvider, $urlRouterProvider, $httpProvider) {

  $urlRouterProvider.otherwise("/");

  $stateProvider
    .state("home", {
      url: "/",
      templateUrl: "./views/home.html",
      controller: "userController"
    })
    .state("passedBill", {
      url: "/passedBill",
      templateUrl: "./views/passedBill.html",
      controller: "passedBillController"
    })
    .state("pendingBill", {
      url: "/pendingBill",
      templateUrl: "./views/pendingBill.html",
      controller: "pendingBillController"
    })
    .state("congressPerson", {
      url: "/congressPerson",
      templateUrl: "./views/congressPerson.html",
      controller: "congressPersonController"
    })

})