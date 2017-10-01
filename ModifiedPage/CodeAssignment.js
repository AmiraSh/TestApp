var CodeAssignment = CodeAssignment || {};

(function () {
    var self = this;
	
    self.salesUrl = 'http://localhost:54263/api/sales';
    self.baseSaleUrl = '';
    
    self.initialize = function () {
        getSales();
    }
	
    self.viewModel = {};
    
    self.viewModel.getFullUrl = function (url) {
        return self.viewModel.baseUrl() + url;
    }
    
    function getSales() {
        $.getJSON(self.salesUrl, function(data) {
			ko.mapping.fromJS(data, {}, self.viewModel);
			ko.applyBindings(self.viewModel);
        });

    }
}).apply(CodeAssignment);