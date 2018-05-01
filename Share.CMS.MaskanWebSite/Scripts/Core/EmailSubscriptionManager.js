var EmailSubscriptionManager = function EmailSubscriptionManager(callback) {
    _SubscriptionManager = this;

    EmailSubscriptionManager.prototype.SubscripeWithEmail = function () {
        var EmailAddress = $("#txtSubscripeMail").val();
        // Required Validation.
        if (EmailAddress == "") {
            $.notify(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 63, "Please enter you email address"), "info");
            return;
        }

        // Validation Email Address.
        if (!_CommonManager.isEmail(EmailAddress)) {
            $.notify(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 64, "Please enter a valid email address"), "warn");
            return;
        }

        // Create Object for Post Request.
        var emailSubscription_VM = {
            Email: EmailAddress
        }

        // Calling API.
        _CommonManager.SendRequest("/api/EmailSubscription/AddEmailSubscription", emailSubscription_VM, function () {
            $.notify(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 65, "Thanks for subscriping our mail news"), "success");
            _SubscriptionManager.ClearControls();
        }, function () {
            $.notify(_TranslationManager.GetTranslatedText(TranslationModule.MaskanWeb, 66, "Sorry, Your email added before"), "warn");
        });
    }


    EmailSubscriptionManager.prototype.ClearControls = function (email) {
        $("#txtSubscripeMail").val("");
    }

}