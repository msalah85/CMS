
var newsDetailsController = function () {
    var
        init = function () {
            getNewsDetails();
        },
        getNewsDetails = function () {
            var
                _id = commonManger.getUrlSegment(),
                data = {
                    actionName: 'News_One',
                    names: ['ID'],
                    values: [_id]
                },
                showingData = function (d) {
                    var list = d.list;

                    if (list) {
                        $.each(list, function (k, v) {
                            $('#' + k).html(v);
                        });
                    }
                };

            serviceManager.getData(data, showingData);
        };

    return {
        Init: init
    };
}();
