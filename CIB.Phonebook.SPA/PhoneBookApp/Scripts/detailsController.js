(function (app) {
    var detailsController = function ($scope, $routeParams, contactService) {
        var id = $routeParams.id;
        contactService.getById(id).then(function (data) {
            $scope.contact = data;
        });

        $scope.edit = function () {
            $scope.edit.contact = angular.copy($scope.contact);
        };
    };
    app.controller("detailsController", detailsController);
}(angular.module("phoneBook")));