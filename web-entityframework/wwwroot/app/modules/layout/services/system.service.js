(function() {
    'use strict';

    angular
        .module('app.layout')
        .service('systemService', service);

    service.$inject = ['$http'];

    function service($http) {
        return {
            getVersion: getVersion
        };

        function getVersion() {
            return $http.get('/api/system/version');
        }
    }
}());