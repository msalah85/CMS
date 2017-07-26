
var propertyDetailsController = function () {
    var
        init = function () {
            getProperty();
        },
        getProperty = function () {
            var
                _id = commonManger.getUrlSegment(),
                data = {
                    actionName: 'Properties_One',
                    names: ['ID'],
                    values: [_id]
                },
                showingData = function (d) {
                    console.log(d);

                    var list = d.list;

                    if (list) {
                        $.each(list, function (k, v) {
                            $('#' + k).html(v);
                        });

                        // seo
                        document.title = list.PropertyTitle + ' - مسكن.كوم';
                        $('meta[name=description],meta[name=keywords]').remove();
                        // set anew one
                        var metaDesc = $('<meta name="description" />').attr('content', $(list.Description).text()),
                            metaKeys = $('<meta name="keywords" />').attr('content', list.PropertyTitle.split(' ').join(','));

                        $('head').append(metaDesc);
                        $('head').append(metaKeys);
                    }
                };
            
            if (_id)
                serviceManager.getData(data, showingData);
        };

    return {
        Init: init
    };

}();
