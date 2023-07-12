var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('ALL');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);