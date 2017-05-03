/* globals module require */

const express = require("express");

module.exports = function(app, data) {
    let controller = require("../controllers/superheroes-controller")(data);

    let router = new express.Router();

    router
        .get("/", controller.getAll)
        .get("/:id", controller.getById)
        .post("/", controller.create);

    app.use("/superheroes", router);
};