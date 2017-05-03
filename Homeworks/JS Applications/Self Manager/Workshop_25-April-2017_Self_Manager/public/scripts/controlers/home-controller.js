import { templateLoader as tl } from "../common/template-loader.js";
import { requester } from "../common/requester.js";

const homeController = function() {

    function viewHome(context) {
        tl.get("home")
            .then(template => context.$element().html(template));
    }

    return {
        viewHome
    };
}();

export { homeController };