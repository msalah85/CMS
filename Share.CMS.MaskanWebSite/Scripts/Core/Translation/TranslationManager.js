
var TranslationModule = {
    MaskanWeb: "MaskanWeb"
};



var TranslationManager = function TranslationManager() {

    TranslationManager.prototype.GetTranslatedText = function (Module, langid, originalTxt) {
        try {
            if (isRight == "False")
            {
                return originalTxt;
            }
            var _TranslatedModules = JSON.parse($(document.getElementById("TranslatedModules")).val());
            if (_TranslatedModules.hasOwnProperty(Module)) {
                var currentModule = _TranslatedModules[Module];

                for (var index = 0; index < currentModule.length; index++) {

                    if (currentModule[index].id == langid) {
                        return currentModule[index].c;
                    }
                }
            } else {
                return originalTxt;
            }

        } catch (e) {
            return originalTxt;
        }
        return originalTxt;

    }

}