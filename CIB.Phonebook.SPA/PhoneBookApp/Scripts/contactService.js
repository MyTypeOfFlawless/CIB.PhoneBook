import 'rxjs/add/operator/toPromise';

(function (app) {
    var contactService = function ($http, contactApiUrl) {
        //var getAll = function () {
        //    return $http.get(contactApiUrl);
        //};

        var getAll = getAll(){
            let promise = new Promise((resolve, reject) => {
                this.http.get(contactApiUrl)
                    .toPromise()
                    .then(
                        res => { // Success
                            console.log(res.json());
                            resolve();
                        }
                    );
            });
            return promise;
        }

        var getById = function (id) {
            return $http.get(contactApiUrl + id);
        };

        var update = function (contact) {
            return $http.put(contactApiUrl + contact.Id, contact);
        };

        var create = function (contact) {
            console.log(JSON.stringify(contact));
            return $http.post(contactApiUrl, contact);
        };

        var deleteById = function (id) {
            return $http.delete(contactApiUrl + id);
        };

        return {
            getAll: getAll,
            getById: getById,
            update: update,
            create: create,
            delete: deleteById
        };
    };
    app.factory("contactService", contactService);
}(angular.module("phoneBook")));