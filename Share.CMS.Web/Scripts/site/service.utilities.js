// ref commonManger.js
// ref dataServices.js
// ref defaults.js


var serviceManager = function () {
    var
        getData = function (funName, param, successCallback) {
            var dto = {
                actionName: funName,
                names: param[0],
                values: param[1]
            };

            dataService.callAjax('GET', dto,
                sUrl + 'GetData',
                function (data) {
                    // convert commpressed data to json
                    var json = commonManger.decoData(data);

                    successCallback(json);
                },
                commonManger.errorException);
        },
        saveData = function (funName, param, successCallback) {
            var dto = {
                actionName: funName,
                names: param[0],
                values: param[1]
            };

            dataService.callAjax('POST', JSON.stringify(dto), sUrl + 'SaveData',
                successCallback, commonManger.errorException);
        };

    return {
        getData: getData,
        saveData: saveData,
    };
}();


