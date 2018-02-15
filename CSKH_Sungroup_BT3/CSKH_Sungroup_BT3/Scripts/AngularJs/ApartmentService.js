app.service("myService", function ($http) {

    //get All Eployee
    this.getApartments = function () {
        debugger;
        return $http.get("/Apartments/GetAll");
    };
    //get all CustomerId
    this.getCustomerId = function () {
        debugger;
        return $http.get("/Apartments/GetCustomerId");

    }

    // get Employee By Id
    this.getApartment = function (apartmentID) {
        var response = $http({
            method: "post",
            url: "/Apartments/getApartmentByNo",
            params: {
                id: JSON.stringify(apartmentID)
            }
        });
        return response;
    }
    // Update Employee
    this.updateApart = function (apartment) {
        var response = $http({
            method: "post",
            url: "/Apartments/UpdateApartment",
            data: JSON.stringify(apartment),
            dataType: "json"
        });
        return response;
    }

    // Add Employee
    this.AddApart = function (apartment) {
        var response = $http({
            method: "post",
            url: "/Apartments/AddApartment",
            data: JSON.stringify(apartment),
            dataType: "json"
        });
        return response;
    }

    //Delete Employee
    this.DeleteApart = function (apartment) {
        var response = $http({
            method: "post",
            url: "/Apartments/DeleteApartment",
            data: JSON.stringify(apartment),
            dataType: "json"
        });
        return response;
    }
}
)