import { templateLoader as tl } from "../common/template-loader.js";
import { requester } from "../common/requester.js";
import { constants } from "../common/constants.js";

const eventsController = function() {

    function viewEvents(context) {
        const user = localStorage;

        Promise.all([tl.get("events"), requester.getEvents(user)])
            .then(([template, data]) => {
                context.$element().html(template(data));
            })
            .catch(x => toastr.error(x.responseText));
    }

    function addEvent(context) {
        tl.get("events-add")
            .then((template) => {
                context.$element().html(template);
            })
            .then(() => {
                $('.datepicker').datepicker();
                $("#btnAddEvent").on("click", function() {
                    const title = $("#eventTitle").val();
                    const category = $("#eventCategory").val();
                    const description = $("#eventDescription").val();
                    const date = $("#eventDate").val();

                    if (date) {
                        const event = {
                            title,
                            category,
                            description,
                            date: new Date(date).toISOString()
                        };

                        requester.addEvent(event)
                            .then(() => {
                                toastr.success(constants.SUCCESS_ADD_EVENT);
                                document.location = "#/events";
                            })
                            .catch((err) => {
                                toastr.error(err.responseText);
                            });

                    } else {
                        toastr.error(constants.ERROR_INVALID_DATE);
                    }

                });
            });
    }

    return {
        viewEvents,
        addEvent
    };
}();

export { eventsController };