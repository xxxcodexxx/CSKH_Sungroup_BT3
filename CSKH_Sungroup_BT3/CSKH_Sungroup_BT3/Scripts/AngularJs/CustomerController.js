
app.controller("CustomerCtrl", function ($scope, CustomerService) {

    
    $scope.customers = [];
    GetCustomerList();
    
   

    //Get all records
    function GetCustomerList() {
        CustomerService.getAllCustomers().then(function (cus) {
            $scope.customers = cus.data;
        },function () {
            alert('Error in getting records');
        });
    }
    //Adding new customer
    $scope.addCustomer = function (customer) {
        CustomerService.addNewCustomer(customer).then(function (cus) {
            $scope.customers.push(cus);
        }, function () {
            alert('Error in adding customer');
        });
    }
    //Delete customer
    $scope.deleteCustomer = function (customer, index) {
        CustomerService.deleteCustomer(customer.Id).then(function () {
            $scope.customers.splice(index, 1);
        }, function () {
            alert("something went wrong.");
        });
    };
    //Updating customer
    $scope.updateCustomer = function (customer) {
        CustomerService.updateCustomer(customer).then(function (customer) {
            Id: $scope.Id;
            Passport: $scope.Passport;
            Address: $scope.Address;
            Email: $scope.Email;
            PhoneNumber: $scope.PhoneNumber
        }, function () {
            alert("Error Update");
        });
    }
});
