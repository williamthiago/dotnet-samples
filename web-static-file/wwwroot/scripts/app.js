(function() {
    function showSystem(data) {
        document.getElementById('description').textContent = data.Description;
        document.getElementById('system').src = '/assets/images/' + data.SystemBase.toLowerCase() + '.svg';
        var overlay = document.getElementById('overlay');
        overlay.parentNode.removeChild(overlay);
    }

    function getSystem() {
        var request = new XMLHttpRequest();
        request.open('GET', '/api/system/version', true);
        request.onload = function() {
            if (request.status >= 200 && request.status < 400) {
                var data = JSON.parse(request.responseText);
                showSystem(data);
            }
        };
        request.send();
    }

    function runOnLoad(func) {
        if (document.readyState != 'loading') {
            func();
        } else {
            document.addEventListener('DOMContentLoaded', func);
        }
    }

    runOnLoad(getSystem);

})();