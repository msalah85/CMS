var AccountManager = function AccountManager(callBack) {
    _selfAccountManager = this;

    // Methods.
    AccountManager.prototype.CreateNewAccount = function (area) {
        // validate all Required Fields.
        var Username = $("#txtNewAccName").val();
        var Password = $("#txtNewAccPassword").val();
        var Email = $("#txtNewAccEMail").val();

        if (Username == "" || Password == "" || Email == "") {
            $("#lblCreateNewAccMsg").html(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 75, "Please fill all fields"));
            return;
        }

        // Validation Email Address.
        if (!_CommonManager.isEmail(Email)) {
            $("#lblCreateNewAccMsg").html(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 64, "Please enter a valid email address"));
            return;
        }

        var UserViewModel = {
            "Username": $("#txtNewAccName").val(),
            "Password": $("#txtNewAccPassword").val(),
            "Email": $("#txtNewAccEMail").val()
        }

        var URI = "/user/Register";
        if (area == "Core")
            URI = "/user/Register";
        _CommonManager.SendRequest(URI, UserViewModel, function (result) {
            // sucess callback.

            $("#modal3").hide();
            $("#modal1").hide();
            $("#lblCreateNewAccMsg").html("");
            _selfAccountManager.ClearControls();
            window.parent.SuccessLogIn();
        }, function () {
            // user Already exist.
            $("#lblCreateNewAccMsg").html(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 67, "UserName or Email Already Exist"));
        });
    }


    AccountManager.prototype.LogInWithMail = function (area) {
        // Validate Model.
        var Username = $("#txtLogInEmail").val();
        var Password = $("#txtLogInPassword").val();

        if (Username == "" || Password == "") {
            $("#lblLogInMsg").html(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 75, "Please fill all fields"));
            return;
        }

        var _LogInViewModel = {
            "Username": $("#txtLogInEmail").val(),
            "Password": $("#txtLogInPassword").val()
        }
        /// api / UsersService / LogIn
        var URI = "/user/LogIn";
        if (area == "Core")
            URI = "/user/LogIn";

        _CommonManager.SendRequest(URI, _LogInViewModel, function (result) {
            // sucess callback.
            $("#modal2").hide();
            $("#modal1").hide();
            $("#lblLogInMsg").html("");
            _selfAccountManager.ClearControls();
            window.parent.SuccessLogIn();
        }, function () {
            // Invalid username or password. 
            $("#lblLogInMsg").html(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 68, "Invalid username or password"));
        });
    }

    AccountManager.prototype.LogOut = function (area) {
        var URI = "user/LogOut";
        if (area == "Core")
            URI = "../user/LogOut";
        _CommonManager.GetAPI(URI, function () {
            window.parent.SuccessLogIn();
            // console.log("user signed out successfully");
        });
    }

    AccountManager.prototype.RecoverPassword = function (area) {
        debugger;
        var Email = $("#txtRecoverEmail").val();

        if (Email == "") {
            $("#lblRecoverMessage").html(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 63, "Please enter your email address"));
            return;
        }

        // Validation Email Address.
        if (!_CommonManager.isEmail(Email)) {
            $("#lblRecoverMessage").html(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 64, "Please enter a valid email address"));
            return;
        }

        var URI = "user/RecoverPassoerd/?Email=" + Email;
        if (area == "Core")
            URI = "../user/RecoverPassoerd/?Email=" + Email;
        _CommonManager.GetAPI(URI, function (result) {
            debugger;
            if (result == "This email does not exsit in our database") {
                $("#lblRecoverMessage").html(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 79, "This email does not exsit in our database"));
                return;
            }
            $("#lblRecoverMessage").html(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 77, "Please check your mail to reset your password"));
        });
    }


    AccountManager.prototype.ClearControls = function () {
        $("#txtNewAccName").val("");
        $("#txtNewAccPassword").val("");
        $("#txtNewAccEMail").val("");
        $("#txtLogInEmail").val("");
        $("#txtLogInPassword").val("");
    }

}
