function BootstrapDropDownOptions() {

	this.DropDownOptionsData;
	this.Icon;
	this.Caption;
	this.Cls;
	this.ActiveEventKey;
	this.Tooltip;
	this.DropDownOptionsType;

	//Title Settings
	this.TitleControlAlign;
	this.TitleControlIdToReplace;
	this.DropDownOptionsTitleSettingsIcons;
	this.FilteredText_get;
	this.FilteredText_set;
	this.FilteredTextTo_get;
	this.FilteredTextTo_set;
	this.SelectedValue_get;
	this.SelectedValue_set;
	this.SelectedText_get;
	this.SelectedText_set;
	this.IncludeSortASC;
	this.IncludeSortDSC;
	this.SortedStatus;
	this.IncludeFilter;
	this.FilterType;
	this.FilterIsRange;
	this.IncludeDataList;
	this.DataListType;
	this.DataListFixedValues;
	this.DataListProc;
	this.DataListUpdateMinimumCharacters;
	this.LastFilteredText;
	this.LastFilteredTextTo;

	//Title Settings labels
	this.SortASC;
	this.SortDSC;
	this.LoadingData;
	this.CleanFilter;
	this.RangeFilterFrom;
	this.RangeFilterTo;
	this.NoResultsFound;
	this.SearchButtonText;

	//ColumnsSelector
	this.ColumnsSelectorValues;

	//ColumnsSelector labels
	this.UpdateButtonText;

	this.GAMOAuthToken;

	this.UseAsGridTitleSetting;

	this.SetDropDownOptionsData = function (data) {
		if (this.DropDownOptionsType == "GridTitleSettings") {
			this.FilteredText_get = this.FilteredText_set;
			this.FilteredText = this.FilteredText_get;
			this.FilteredTextTo_get = this.FilteredTextTo_set;
			this.FilteredTextTo = this.FilteredTextTo_get;
			this.SelectedValue_get = this.SelectedValue_set;
			this.SelectedValue = this.SelectedValue_get;
			this.SelectedText_get = this.SelectedText_set;
			this.SelectedText = this.SelectedText_get;
			this.UseAsGridTitleSetting = true;
			if (data != undefined) {
				var dataEmpty = (data.length == 0);
				if (this.IncludeSortASC && (dataEmpty || !this.DataHasEventKey(data, "<#OrderASC#>"))) {
					var dataObj = {};
					dataObj.EventKey = "<#OrderASC#>";
					dataObj.Icon = this.DropDownOptionsTitleSettingsIcons["OptionSortASC_GXI"];
					dataObj.Icon_GXI = '';
					dataObj.IsDivider = false;
					dataObj.JSonclickEvent = '';
					dataObj.Link = '';
					dataObj.Title = gx.getMessage(this.SortASC);
					dataObj.Tooltip = '';
					data.push(dataObj);
				}
				if (this.IncludeSortDSC && (dataEmpty || !this.DataHasEventKey(data, "<#OrderDSC#>"))) {
					var dataObj = {};
					dataObj.EventKey = "<#OrderDSC#>";
					dataObj.Icon = this.DropDownOptionsTitleSettingsIcons["OptionSortDSC_GXI"];
					dataObj.Icon_GXI = '';
					dataObj.IsDivider = false;
					dataObj.JSonclickEvent = '';
					dataObj.Link = '';
					dataObj.Title = gx.getMessage(this.SortDSC);
					dataObj.Tooltip = '';
					data.push(dataObj);
				}
				if ((this.IncludeFilter || this.IncludeDataList) && (dataEmpty || !this.DataHasEventKey(data, "<#FilterOptions#>"))) {
					if (this.IncludeSortASC || this.IncludeSortDSC) {
						var dataObj = {};
						dataObj.EventKey = "";
						dataObj.Icon = "";
						dataObj.Icon_GXI = '';
						dataObj.IsDivider = true;
						dataObj.JSonclickEvent = '';
						dataObj.Link = '';
						dataObj.Title = '';
						dataObj.Tooltip = '';
						data.push(dataObj);
					}
					var dataObj = {};
					dataObj.EventKey = "<#FilterOptions#>";
					dataObj.Icon = "";
					dataObj.Icon_GXI = '';
					dataObj.IsDivider = false;
					dataObj.JSonclickEvent = '';
					dataObj.Link = '';
					dataObj.Title = gx.getMessage(this.LoadingData);
					dataObj.Tooltip = '';
					data.push(dataObj);
				}
			}
		} else {
			this.UseAsGridTitleSetting = false;
		}
		var dataUndefined = true;
		if (data != undefined) {
			if (data.length > 0) {
				this.DropDownOptionsData = data;
				dataUndefined = false;
			} else if (this.DropDownOptionsType == "GridColumnsSelector"
						&& (data.VisibleColumns != undefined ? data.VisibleColumns.length : 0) + (data.InvisibleColumns != undefined ? data.InvisibleColumns.length : 0) > 0) {
				this.DropDownOptionsData = data;
				if (this.DropDownOptionsData.VisibleColumns == undefined) {
					this.DropDownOptionsData.VisibleColumns = [];
				}
				if (this.DropDownOptionsData.InvisibleColumns == undefined) {
					this.DropDownOptionsData.InvisibleColumns = [];
				}
				dataUndefined = false;
			}
		}
		if (this.my_dropDownOptions != undefined && !dataUndefined) {
			this.my_dropDownOptions.render();
		}
	}

	this.DataHasEventKey = function (data, eventKey) {
		for (var index = 0; index < data.length; index += 1) {
			if (data[index]["EventKey"] == eventKey) {
				return true;
			}
		}
		return false;
	}

	this.GetDropDownOptionsData = function () {
	}

	this.SetDropDownOptionsTitleSettingsIcons = function (icons) {
		if (icons != undefined && icons.Default != '') {
			this.DropDownOptionsTitleSettingsIcons = icons;
		}
	}

	this.GetDropDownOptionsTitleSettingsIcons = function () {
	}

	this.onaftereventx = function (control) {
		var controlRender = false;
		if ($("#" + control.containerToDrawName).attr("class") == null || $("#" + control.containerToDrawName).attr("class").length == 0) {
			controlRender = true;
		} else {
			controlRender = true;
			try {
				if ($("#" + control.containerToDrawName).children().length == 2) {
					var ul = $("#" + control.containerToDrawName).children()[1];
					for (var i = 0; i < ul.children.length; i++) {
						if (ul.children[i].children.length == 1) {
							var elem = ul.children[i].children[0];
							var ev = $._data(elem, 'events');
							if (ev != null) {
								controlRender = false;
								break;
							}
						}
					}
				}
			} catch (err) {
				console.log("onaftereventx - error verifying if controlRender is necessary: " + err.message);
			}
		}
		if (controlRender) {
			control.render();
		}
	}

	this.show = function () {
		///UserCodeRegionStart:[show] (do not remove this comment.)



		if (this.my_dropDownOptions == undefined) {
			this.my_dropDownOptions = new DVelopBootstrapDropDownOptions(this);
			this.my_dropDownOptions.render();

			gx.fx.obs.addObserver("gx.onafterevent", window, function (thisC) {
				return function (e) {
					thisC.onaftereventx(thisC.my_dropDownOptions);
				}
			}(this));

			gx.fx.obs.addObserver("gx.onload", window, function (thisC) {
				return function (e) {
					thisC.onaftereventx(thisC.my_dropDownOptions);
				}
			}(this));

			if (this.my_dropDownOptions.IsDate()) {
				$("#" + this.my_dropDownOptions.containerToDrawName).off('hide.bs.dropdown').on('hide.bs.dropdown', function (ddo) {
					return function (e) {
						return ddo.OnDDOClosing();
					}
				}(this.my_dropDownOptions));
			}
		}









































		///UserCodeRegionEnd: (do not remove this comment.)
	}
	///UserCodeRegionStart:[User Functions] (do not remove this comment.)













































	///UserCodeRegionEnd: (do not remove this comment.):
}
