app.service("CustomerService", function ($http) {
    //Get all customer
    this.getAllCustomers = function () {
        return $http.get("Customers/GetAllCustomers");
    };
    //Adding customer
    this.addNewCustomer = function (customer) {
        return $http({
            method: "post",
            url: "Customers/AddNewCustomer",
            data: JSON.stringify(customer),
            dataType: "json"
        });
    };
    //Editing customer
    this.editCustomer = function (id) {
        return $http.post("Customers/Edit/" + id)
    }
    //Deleting customer
    this.deleteCustomer = function (id) {
        return $http.post("Customers/DeleteCustomer/" + id)
    };
    //Updating customer
    this.updateCustomer = function (customer) {
        return $http({
            method: "post",
            url: "Customers/UpdateCustomer",
            data: JSON.stringify(customer),
            dataType: "json"
        });
    }
});