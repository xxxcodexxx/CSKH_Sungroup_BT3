
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
            $("#alert-info").removeClass("alert alert-danger");
            $("#alert-info").removeClass("alert alert-success");
            $("#alert-info").addClass("alert alert-success");
            $("#alert-info").html("Thêm mới thành công");
            setTimeout(function () {
                $("#alert-info").removeClass("alert alert-danger");
                $("#alert-info").removeClass("alert alert-success");
                $("#alert-info").html("");
            }, 2000)
            GetCustomerList();
        }, function () {
            $("#alert-info").removeClass("alert alert-danger");
            $("#alert-info").removeClass("alert alert-success");
            $("#alert-info").addClass("alert alert-danger");
            $("#alert-info").html("Thêm mới thất bại");
            setTimeout(function () {
                $("#alert-info").removeClass("alert alert-danger");
                $("#alert-info").removeClass("alert alert-success");
                $("#alert-info").html("");
            }, 2000)
        });
    }
    //Delete customer
    $scope.deleteCustomer = function (customer, index) {
        if (confirm("Bạn muốn xóa khách hàng " + customer.FirstName + customer.LastName)) {
            CustomerService.deleteCustomer(customer.Id).then(function () {
                $scope.customers.splice(index, 1);
            }, function () {
                alert("something went wrong.");
            });
        }
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
            $("#alert-info").removeClass("alert alert-danger");
            $("#alert-info").removeClass("alert alert-success");
            $("#alert-info").addClass("alert alert-success");
            $("#alert-info").html("Sửa đổi thông tin thành công");
            setTimeout(function () {
                $("#alert-info").removeClass("alert alert-danger");
                $("#alert-info").removeClass("alert alert-success");
                $("#alert-info").html("");
            }, 2000)
            GetCustomerList();
        }, function () {
            $("#alert-info").removeClass("alert alert-danger");
            $("#alert-info").removeClass("alert alert-success");
            $("#alert-info").addClass("alert alert-danger");
            $("#alert-info").html("Thay đổi thông tin thất bại");
            setTimeout(function () {
                $("#alert-info").removeClass("alert alert-danger");
                $("#alert-info").removeClass("alert alert-success");
                $("#alert-info").html("");
            }, 2000)
        });
    }
});
