import { constants } from "./constants.js";

const requester = function() {

    function getUser(username) {
        return $.ajax({
            type: "GET",
            url: "api/users",
            contentType: "application/json",
            dataFilter: function(data) {
                data = JSON.parse(data);
                data = Array.from(data.result).filter(x => x.username === username);
                return JSON.stringify(data);
            }
        });
    }

    function getTodos(user) {
        return $.ajax({
            type: "GET",
            url: "api/todos",
            contentType: "application/json",
            headers: {
                "x-auth-key": user.authKey
            }
        });
    }

    function getEvents(user) {
        return $.ajax({
            type: "GET",
            url: "api/events",
            contentType: "application/json",
            headers: {
                "x-auth-key": user.authKey
            }
        });
    }

    function register(user) {
        return $.ajax({
            type: "POST",
            url: "api/users",
            contentType: "application/json",
            data: JSON.stringify(user)
        });
    }

    function login(user) {
        return $.ajax({
            type: "PUT",
            url: "api/users/auth",
            contentType: "application/json",
            data: JSON.stringify(user)
        });
    }

    function addTodo(todo) {
        return $.ajax({
            type: "POST",
            url: "api/todos",
            contentType: "application/json",
            headers: {
                "x-auth-key": localStorage.getItem("authKey")
            },
            data: JSON.stringify(todo)
        });
    }

    function addEvent(event) {
        return $.ajax({
            type: "POST",
            url: "api/events",
            contentType: "application/json",
            headers: {
                "x-auth-key": localStorage.getItem("authKey")
            },
            data: JSON.stringify(event)
        });
    }

    function updateTodo(todo) {
        return $.ajax({
            type: "PUT",
            url: "api/todos/" + todo.id,
            contentType: "application/json",
            headers: {
                "x-auth-key": localStorage.getItem("authKey")
            },
            data: JSON.stringify(todo)
        });
    }

    return {
        getUser,
        getTodos,
        getEvents,
        register,
        login,
        addTodo,
        addEvent,
        updateTodo
    };
}();

export { requester };