
app.controller("CustomerCtrl", function ($scope, CustomerService) {

    
    $scope.customers = [];
    $scope.Status = true;
    GetCustomerList();
    
   
    // Clear data
    $scope.clearData = function () {
        $scope.FirstName = null;
        $scope.LastName = null;
        $scope.Passport = null;
        $scope.Email = null;
        $scope.PhoneNumber = null;
        $scope.Address = null;
    }
    //Get all records
    function GetCustomerList() {
        CustomerService.getAllCustomers().then(function (cus) {
            $scope.customers = cus.data;
        },function () {
            alert('Error in getting records');
        });
    }
    // Editing Customer
    $scope.editCustomer = function (customer) {
        CustomerService.editCustomer(customer.Id).then(function () {
            $scope.FirstName = customer.FirstName;
            $scope.LastName = customer.LastName;
            $scope.Passport = customer.Passport;
            $scope.Email = customer.Email;
            $scope.PhoneNumber = customer.PhoneNumber;
            $scope.Address = customer.Address;
            $scope.Id = customer.Id
            $scope.Status = false;
        })
    }

    //Adding new customer
    $scope.addCustomer = function () {
        var customer = {
            FirstName: $scope.FirstName,
            LastName: $scope.LastName,
            Passport: $scope.Passport,
            PhoneNumber: $scope.PhoneNumber,
            Address: $scope.Address,
            Email: $scope.Email
        }
        CustomerService.addNewCustomer(customer).then(function (cus) {
            $scope.customers.push(cus);
            GetCustomerList();
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
    $scope.updateCustomer = function () {
        var customer = {
            Id: $scope.Id,
            FirstName: $scope.FirstName,
            LastName: $scope.LastName,
            Passport: $scope.Passport,
            PhoneNumber: $scope.PhoneNumber,
            Address: $scope.Address,
            Email: $scope.Email
        }
        CustomerService.updateCustomer(customer).then(function () {
            GetCustomerList();
        }, function () {
            alert("Error Update");
        });
    }
});
