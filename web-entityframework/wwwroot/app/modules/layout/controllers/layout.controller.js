(function() {
    'use strict';

    angular
        .module('app.layout')
        .controller('LayoutController', controller);

    controller.$inject = ['systemService'];


    function controller(systemService) {
        var self = this;
        self.systemBase = undefined;

        init();

        function init() {
            systemService.getVersion().then(function(result) {
                self.systemBase = result.data.SystemBase.toLowerCase();
            });
        }
    }
})();