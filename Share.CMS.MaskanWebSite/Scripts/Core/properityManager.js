var properityManager = function properityManager(callback) {
    Self_properity = this;
    properityManager.prototype.InsertProperty = function () {

        var propertyViewModel = {
            "AdditionalRooms": $("#AdditionalRooms").val(),
            "Area": $("#Area").val(),
            "AreaTypeID": $("#AreaTypeID").val(),
            "Balconies": $("#Balconies").val(),
            "Bathrooms": $("#Bathrooms").val(),
            "BedRooms": $("#BedRooms").val(),
            "CityID": $("#CityID").val(),
            "ContactPersonID": $("#ContactPersonID").val(),
            "CountryID": $("#CountryID").val(),
            "CreationDate": $("#CreationDate").val(),
            "Description": $("#Description").val(),
            "Floor": $("#Floor").val(),
            "FurnitureTypeID": $("#FurnitureTypeID").val(),
            "LocationLang": $("#LocationLang").val(),
            "LocationLat": $("#LocationLat").val(),
            "OwnershipTypeID": $("#OwnershipTypeID").val(),
            "Price": $("#Price").val(),
            "PriceTypeID": $("#PriceTypeID").val(),
            "ProjectTypeID": $("#ProjectTypeID").val(),
            "PropertyID": $("#PropertyID").val(),
            "PropertyTitle": $("#PropertyTitle").val(),
            "PropertyTypeID": $("#PropertyTypeID").val(),
            "ResidanceID": $("#ResidanceID").val(),
            "StreetID": $("#StreetID").val()
        };
        debugger;
        _CommonManager.SendRequest("/Property/InsertProperty", propertyViewModel , function (result) {
            if (result < 0)
            {
                $("#divMessage").text(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 112, "An error occured while adding your property"));
                $("#divMessage").show();
                $.notify(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 112, "An error occured while adding your property"), "error");
            }
            else
            {
                Self_properity.ClearControls();
                $("#divMessage").text(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 111, "Your property added successfully"));
                $("#divMessage").show();
                $.notify(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 111, "Your property added successfully"), "success");
            }
        }, function () {
            $("#divMessage").text(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 111, "An error occured while adding your property"));
            $("#divMessage").show();
            $.notify(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 111, "An error occured while adding your property"), "error");
        });
    }


    properityManager.prototype.ClearControls = function () {
        $("#AdditionalRooms").val(''); $("#PropertyTitle").val('');
        $("#LocationLang").val('');
        $("#LocationLat").val('');
        $("#Floor").val('');
        $("#Description").val('');
        $("#Balconies").val('');
        $("#Bathrooms").val('');
        $("#BedRooms").val('');
        $("#Area").val('');
    }

}