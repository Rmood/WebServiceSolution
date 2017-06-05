define(['knockout', 'dataservice'], function (ko, dataService) {
    return function () {
        var clients = ko.observableArray([]);

        dataService.getClients(function (data) {
            console.log(data);
            clients(data);
        });

        return {
            clients
        };
    };
});