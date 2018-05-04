var CommonManager = function CommonManager(callback) {

    CommonManager.prototype.SendRequest = function (url, data, _callback, _ExistingCallback) {
        $.ajax({
            url: ".." + url,
            type: 'POST',
            data: JSON.stringify(data),
            contentType: 'application/json; charset=utf-8',
            success: function (result) {
                if (result >= 1) {
                    _callback(result);
                } else if (result == -1) {
                    _ExistingCallback();
                }
            },
            error: function (error) {
                console.log(error);
            }
        });
    }


    CommonManager.prototype.GetAPI = function (url , _callback) {
        $.ajax({
            url: url,
            type: 'GET',
            contentType: 'application/json; charset=utf-8',
            success: function (result) {
                _callback(result);
            },
            error: function (error) {
                console.log(error);
            }
        });
    }


    CommonManager.prototype.isEmail = function (sEmail) {
        debugger;
        var filter = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
        if (filter.test(sEmail)) {
            return true;
        }
        else {
            return false;
        }
    }



}

