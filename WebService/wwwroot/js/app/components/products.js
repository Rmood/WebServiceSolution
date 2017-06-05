define(['knockout', 'dataservice'], function (ko, dataService) {
    return function () {
        var products = ko.observableArray([]);

        dataService.getProducts(function (data) {
            console.log(data);
            products(data);
        });

        return {
            products
        };
    };
});

