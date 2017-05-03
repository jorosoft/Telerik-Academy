import { templateLoader as tl } from "../common/template-loader.js";
import { requester } from "../common/requester.js";
import { constants } from "../common/constants.js";

const todosController = function() {

    function viewTodos(context) {
        const user = localStorage;

        Promise.all([tl.get("todos"), requester.getTodos(user)])
            .then(([template, data]) => {
                context.$element().html(template(data));
            })
            .then(() => {
                $("body").on("change", function(ev) {
                    let selected = $(ev.target).find('option:selected');
                    let notSelected = $(ev.target).find('option:not(:selected)');

                    selected.attr("selected", "false");
                    notSelected.attr("selected", "true");

                    const selectedValue = $(ev.target).find('option:selected').val();
                    const currentTodoId = $(ev.target).parents(".panel-default").attr("id");

                    requester.getTodos(user)
                        .then((todos) => {
                            console.log(todos);
                        });

                });
            })
            .catch(x => toastr.error(x.responseText));
    }

    function addTodo(context) {
        tl.get("todos-add")
            .then((template) => {
                context.$element().html(template);
            })
            .then(() => {
                $("#btnAddTodo").on("click", function() {
                    const text = $("#todoText").val();
                    const category = $("#todoCategory").val();
                    const todo = {
                        text,
                        category
                    };

                    requester.addTodo(todo)
                        .then(() => {
                            toastr.success(constants.SUCCESS_ADD_TODO);
                            document.location = "#/todos";
                        })
                        .catch((err) => {
                            toastr.error(err.responseText);
                        });

                });
            });
    }

    function updateTodo(todo) {
        requester.updateTodo(todo)
            .then(() => {
                toastr.success(constants.SUCCESS_CHANGE_TODO_STATE);
            })
            .catch((err) => {
                toastr.error(err.responseText);
            });
    }

    return {
        viewTodos,
        addTodo
    };
}();

export { todosController };