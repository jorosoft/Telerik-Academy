/* globals require console */
"use strict";

const constants = require("./config/constants");
const app = require("./config/application");
const data = require("./data")(constants);
require("./routers")(app, data);

app.listen(constants.port, () => console.log(`Server running at :${constants.port}`));