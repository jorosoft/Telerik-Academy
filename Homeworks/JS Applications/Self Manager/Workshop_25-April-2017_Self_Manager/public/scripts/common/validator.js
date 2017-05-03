const validator = function() {

    function isUserLoggedIn() {
        return localStorage.username && localStorage.authKey;
    }

    return {
        isUserLoggedIn
    };
}();

export { validator };