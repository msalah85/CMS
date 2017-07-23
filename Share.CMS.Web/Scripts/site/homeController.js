var homeController = function () {
    var
        init = function () {
            showHomeNews();
        },
        showHomeNews = function () {
            var langID = commonManger.getCurrentLanguage(),
                proName = 'Site_HomeNews',
                data = [['LnagID'], [langID]],
                showingNews = function (d) {
                    var list = d.list;

                    console.log(list);
                };

            serviceManager.getData(proName, data, showingNews);

        };

    return {
        Init: init
    };
}();

homeController.Init();