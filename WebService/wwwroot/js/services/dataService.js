define(['jquery'], function ($) {

    var productsUrl = "api/products";
    var categoriesUrl = "api/categories";
    var clientsUrl = "api/clients";
    var ordersUrl = "api/orders";


    var getProducts = function (callback) {
        $.getJSON(productsUrl, function (data) {
            callback(data);
        });
    };

    var getCategories = function (callback) {
        $.getJSON(categoriesUrl, function (data) {
            callback(data);
        });
    };

    var getClients = function (callback) {
        $.getJSON(clientsUrl, function (data) {
            callback(data);
        });
    };

    var getOrders = function (callback) {
        $.getJSON(ordersUrl, function (data) {
            callback(data);
        });
    };

    return {
        getProducts,
        getCategories,
        getClients,
        getOrders
    };
});