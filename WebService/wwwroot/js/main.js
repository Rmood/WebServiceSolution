require.config({
    baseUrl: "js",
    paths: {
        knockout: "lib/knockout/dist/knockout",
        jquery: "lib/jQuery/dist/jquery.min",
        text: "lib/text/text",
        dataservice: "services/dataService"
    }
});


require(['knockout'], function (ko) {
    ko.components.register("products", {
        viewModel: { require: "app/components/products" },
        template: { require: "text!app/components/products.html" }
    });

    ko.components.register("categories", {
        viewModel: { require: "app/components/categories" },
        template: { require: "text!app/components/categories.html" }
    });

    ko.components.register("orders", {
        viewModel: { require: "app/components/orders" },
        template: { require: "text!app/components/orders.html" }
    });

    ko.components.register("clients", {
        viewModel: { require: "app/components/clients" },
        template: { require: "text!app/components/clients.html" }
    });


    ko.applyBindings({});
});

