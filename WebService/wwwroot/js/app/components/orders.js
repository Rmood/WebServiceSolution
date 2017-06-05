define(['knockout', 'dataservice'], function (ko, dataService) {
    return function () {
        var orders = ko.observableArray([]);

        dataService.getOrders(function (data) {
            console.log(data);
            orders(data);
        });

        return {
            orders
        };
    };
});