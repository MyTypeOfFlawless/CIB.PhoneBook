(function (app) {
    var editController = function ($scope, contactService) {

        $scope.isEditable = function () {
            return $scope.edit && $scope.edit.contact;
        };

        $scope.cancel = function () {
            $scope.edit.contact = null;
        };

        $scope.Contacts = [];

        var createContact = function () {
            contactService.create($scope.edit.contact)
                .then(function () {
                    $scope.contacts.push($scope.edit.contact);
                    $scope.edit.contact = null;
                });
        };
        
        var updateContact = function () {
            contactService.update($scope.edit.contact)
                .then(function () {
                    angular.extend($scope.contact, $scope.edit.contact);
                    $scope.edit.contact = null;
                });
        };

        $scope.save = function () {
            if ($scope.edit.contact.Id) {
                updateContact();
            } else {
                createContact();
            }
        };
    };
    app.controller("editController", editController);
}(angular.module("phoneBook")));