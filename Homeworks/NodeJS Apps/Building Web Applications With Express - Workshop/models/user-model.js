/* globals require module */

const mongoose = require("mongoose");

let schema = new mongoose.Schema({
    username: {
        type: String,
        required: true
    },
    name: {
        type: String,
        required: true
    },
    imageLink: {
        type: String,
        required: true
    }
});
mongoose.model("User", schema);

module.exports = mongoose.model("User");