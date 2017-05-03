import { homeController } from "./controlers/home-controller.js";
import { todosController } from "./controlers/todos-controller.js";
import { eventsController } from "./controlers/events-controller.js";
import { usersController } from "./controlers/users-controler.js";
import { constants } from "./common/constants.js";
import { validator } from "./common/validator.js";


(function() {
    const selfManager = Sammy("#content", function() {

        this.get("#/", homeController.viewHome);

        this.get("#/home", homeController.viewHome);

        this.get("#/todos", todosController.viewTodos);

        this.get("#/todos/add", function(context) {
            todosController.addTodo(context)
        });

        this.get("#/events", eventsController.viewEvents);

        this.get("#/events/add", function(context) {
            eventsController.addEvent(context)
        });

        this.get("#/register", function(context) {
            if (validator.isUserLoggedIn()) {
                toastr.error(constants.ERROR_HAVE_ACCOUNT);
            } else {
                usersController.register(context);
            }
        });

        this.get("#/login", function(context) {
            if (validator.isUserLoggedIn()) {
                toastr.error(constants.ERROR_ALREADY_LOGGED);
            } else {
                usersController.login(context);
            }
        });

        this.get("#/logout", usersController.logout);

        // Get Home view for empty hash URLs
        this.get("", function() {
            this.app.runRoute("get", "#/home");
        });


    });

    $(function() {
        selfManager.run("#/")
    });

    $(document).ready(function() {
        usersController.init();
    });

    return {
        selfManager,
    }

})();