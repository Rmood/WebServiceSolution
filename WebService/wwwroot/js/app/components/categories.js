define(['knockout', 'dataservice'], function (ko, dataService) {
    return function () {
        var categories = ko.observableArray([]);

        dataService.getCategories(function (data) {
            console.log(data);
            categories(data);
        });

        return {
            categories
        };
    };
});