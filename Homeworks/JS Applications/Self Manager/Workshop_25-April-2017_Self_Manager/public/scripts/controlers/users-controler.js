import { templateLoader as tl } from "../common/template-loader.js";
import { requester } from "../common/requester.js";
import { constants } from "../common/constants.js";
import { validator } from "../common/validator.js";

const usersController = function() {

    function init() {
        if (validator.isUserLoggedIn()) {
            $("#functions-panel").show();
            $("#user-info").html(localStorage.username);
            $("#login-link").hide();
            $("#logout-link").show();
            $("#register-link").hide();

        } else {
            $("#functions-panel").hide();
            $("#user-info").html("");
            $("#login-link").show();
            $("#logout-link").hide();
            $("#register-link").show();
        }
    }

    function register(context) {
        tl.get("register")
            .then(template => context.$element().html(template))
            .then(() => {

                $("#btnRegister").on("click", function() {
                    const username = $("#signupName").val();
                    const pass = $("#signupPassword").val();
                    const passHash = CryptoJS.SHA1(pass).toString();
                    const user = {
                        username,
                        passHash
                    };

                    requester.register(user)
                        .then((x) => {
                            toastr.success(constants.SUCCESS_REGISTRATION);
                            document.location = "#/login";
                        })
                        .catch(x => toastr.error(x.responseText));
                });

            });
    }

    function login(context) {
        tl.get("login")
            .then(template => context.$element().html(template))
            .then(() => {
                $("#btnLogin").on("click", function() {
                    const username = $("#signupUser").val();
                    const pass = $("#signupPassword").val();
                    const passHash = CryptoJS.SHA1(pass).toString();
                    const user = {
                        username,
                        passHash
                    };

                    requester.login(user)
                        .then(x => {
                            toastr.success(constants.SUCCESS_LOGIN);
                            document.location = "#/home";
                        })
                        .then(() => {
                            requester.getUser(username)
                                .then(x => {
                                    localStorage.setItem("id", x[0].id);
                                    localStorage.setItem("username", x[0].username);
                                    localStorage.setItem("authKey", x[0].authKey);
                                    init();
                                });
                        })
                        .catch(x => toastr.error(x.responseText));
                });
            });
    }

    function logout() {
        localStorage.clear();
        init();
        document.location = "#/home";
    }

    return {
        init,
        register,
        login,
        logout
    };
}();

export { usersController };