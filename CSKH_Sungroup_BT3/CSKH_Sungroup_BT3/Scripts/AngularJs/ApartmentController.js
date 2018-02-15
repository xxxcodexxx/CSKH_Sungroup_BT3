app.controller("myCntrl", function ($scope, myService) {
   
    GetAllApartment();
    //To Get All Records 
    function GetAllApartment() {
        debugger;
        var getData = myService.getApartments();
        debugger;
        getData.then(function (apart) {
            $scope.apartments = apart.data;
        }, function () {
            alert('Error in getting records');
        });
    }
    GetCustomerId();
    function GetCustomerId() {
        debugger;
        var getData = myService.getCustomerId();
        debugger;
        getData.then(function (cus) {
            $scope.customers = cus.data;
        }, function () {
            alert('Error in getting records');
        })
    }

    $scope.editApartment = function (apartment) {
        debugger;
        var getData = myService.getApartment(apartment.Id);
        getData.then(function (apart) {
            $scope.apartment = apart.data;
            $scope.apartmentIdEdit = apartment.Id;
            $scope.apartmentApartmentNameEdit = apartment.ApartmentName;
            $scope.apartmentAddressEdit = apartment.Address;
            $scope.apartmentPriceEdit = apartment.Price;
            $scope.apartmentStatusEdit = apartment.Status;
            $scope.apartmentCustomerIdEdit = apartment.CustomerId;
        },
        function () {
            alert('Error in getting records');
        });
        
    }

  
    
    
        
        
        $scope.UpdateApartment= function () {
            
            var Apartment = {
                ApartmentName: $scope.apartmentApartmentNameEdit,
                Address: $scope.apartmentAddressEdit,
                Status: $scope.apartmentStatusEdit,
                Price: $scope.apartmentPriceEdit,
                CustomerId: $scope.apartmentCustomerIdEdit,
            }
            Apartment.Id = $scope.apartmentId;
            var getData = myService.updateApart(Apartment);
            getData.then(function (msg) {
                GetAllApartment();
                alert(msg.data);

            }, function () {
                alert('Error in updating record');
            });
            

        }  
      
        $scope.AddApartment = function () {
           
                debugger;
              
                
                var Apartment = {
                    ApartmentName: $scope.apartmentApartmentName,
                    Address: $scope.apartmentAddress,
                    Status: $scope.apartmentStatus,
                    Price: $scope.apartmentPrice,
                    CustomerId: $scope.apartmentCustomerId,
                };
                
                var getData = myService.AddApart(Apartment);
                getData.then(function (msg) {
                    GetAllApartment();
                    alert(msg.data);

                }, function () {
                    alert('Error in adding record');
                });
            }
        
    

 

    $scope.deleteApartment = function (apartment) {
        var getData = myService.DeleteApart(apartment);
        getData.then(function (msg) {
            GetAllApartment();
            alert('Apartment Deleted');
        }, function () {
            alert('Error in Deleting Record');
        });
    }
   

 
});