function DVelop_WorkWithPlusUtilities() {
	this.Width;
	this.Height;

	this.show = function () {
		SetMinWidthTotalizers();
	}

	gx.fx.obs.addObserver("gx.onafterevent", window, function (thisC) {
		return function (e) {
			SetMinWidthTotalizers();
		}
	}(this));

	gx.fx.obs.addObserver("gx.onload", window, function (thisC) {
		return function (e) {
			SetMinWidthTotalizers();
		}
	}(this));
}

function WWPSelectAll(allBox, upperSelectFilterName) {
	for (var i = 0; i < document.MAINFORM.elements.length; i++) {
		var e = document.MAINFORM.elements[i];

		if (e.type == 'checkbox' && e.name != allBox.name && e.name.toUpperCase().indexOf(upperSelectFilterName) >= 0) {
			e.checked = allBox.checked;
			if (e.checked) {
				e.value = "true";
			} else {
				e.value = "false";
			}
		}
	}
}

function WWPSelectAllGXUI(allSelectedVariable) {
	if (document.getElementById(allSelectedVariable).value == 'true') {
		document.getElementById(allSelectedVariable).value = 'false';
	} else {
		document.getElementById(allSelectedVariable).value = 'true';
	}
	WWPDoGXRefresh();
}

function WWPSelectAllRemoveParentOnClick(allBox) {
	allBox.parentNode.onclick = '';
}

function WWPSortColumn(orderAscId, orderById, orderIndex) {
	var selOrderIndex;
	if (orderById != '') {
		selOrderIndex = document.getElementById(orderById).value;
	} else {
		selOrderIndex = orderIndex;
	}
	if (selOrderIndex == orderIndex) {
		if (document.getElementById(orderAscId).value == 'true') {
			document.getElementById(orderAscId).value = 'false';
		} else {
			document.getElementById(orderAscId).value = 'true';
		}
	} else {
		document.getElementById(orderById).value = orderIndex;
	}
	var wcName = '';
	if (orderAscId != null && orderAscId.indexOf("vORDEREDDSC") > 0) {
		wcName = orderAscId.substring(0, orderAscId.indexOf("vORDEREDDSC"));
	}
	WWPDoGXRefresh(wcName);
}

function WWPDoGXRefresh() {
	WWPDoGXRefresh('');
}

function WWPDoGXRefresh(wcName) {
	if (wcName == null) {
		wcName = '';
	}
	gx.evt.execEvt(wcName, false, wcName + 'EREFRESH.', this);
}

function WWPDynFilterHideLast(lastIndex) {
	while (lastIndex > 1) {
		if (document.getElementById('Dynamicfiltersrow' + lastIndex).className != 'Invisible') {
			document.getElementById('Dynamicfiltersrow' + lastIndex).className = 'Invisible';
			return true;
		}
		lastIndex--;
	}
	return true;
}

function WWPDynFilterHideLast_AL(dynTableId, lastIndex, fixedFilters) {
	while (lastIndex > 1) {
		var row = document.getElementById(dynTableId).rows[lastIndex + fixedFilters - 1];
		if (row.cells[0].className.indexOf('Invisible') == -1) {
			for (var i = 0, cell; cell = row.cells[i]; i++) {
				cell.className = 'Invisible';
			}
			return true;
		}
		lastIndex--;
	}
	return true;
}


function WWPDynFilterShow(index) {
	document.getElementById('Dynamicfiltersrow' + index).className = '';
	return true;
}

function WWPDynFilterShow_AL(dynTableId, index, fixedFilters) {
	var row = document.getElementById(dynTableId).rows[index + fixedFilters - 1];
	var firstRow = document.getElementById(dynTableId).rows[fixedFilters];
	for (var i = 0, cell; cell = row.cells[i]; i++) {
		cell.className = firstRow.cells[i].className;
	}
	return true;
}

function WWPDynFilterHideAll(totalRows) {
	while (totalRows > 1) {
		if (document.getElementById('Dynamicfiltersrow' + totalRows).className != 'Invisible') {
			document.getElementById('Dynamicfiltersrow' + totalRows).className = 'Invisible';
		}
		totalRows--;
	}
	return true;
}

function WWPDynFilterHideAll_AL(dynTableId, totalRows, fixedFilters) {
	while (totalRows > 1) {
		var row = document.getElementById(dynTableId).rows[totalRows + fixedFilters - 1];
		if (row.cells[0].className.indexOf('Invisible') == -1) {
			for (var i = 0, cell; cell = row.cells[i]; i++) {
				cell.className = 'Invisible';
			}
		}
		totalRows--;
	}
	return true;
}

function SetMinWidthTotalizers() {
	$("table.GridWithTotalizer").each(function () {;
		var idGrid = $(this).attr('id');
		var tableTotalizerId = idGrid.substring(0, idGrid.indexOf("ContainerTbl")).toUpperCase() + "TABLETOTALIZER";
		if ($(this).css('display') == 'none') {
			$("#" + tableTotalizerId).css({ display: 'none' });
		} else {
			$("#" + tableTotalizerId).css({ display: '' });
		}
		var width = $(this).outerWidth();
		if ($("#" + tableTotalizerId).hasClass("TableTotalizerAl"))
			$("#" + tableTotalizerId).css({ minWidth: width });

		var i = 0;
		$('#' + idGrid).find('th.GridWithTotalizer').each(function () {
			var widthTH = $(this).outerWidth();
			var item = $("#" + tableTotalizerId + " td")[i];
			$(item).css({ width: widthTH });
			if ($(this).css('display') == 'none')
				$(item).css({ display: 'none' });
			else
				$(item).css({ display: 'table-cell' });
			var textAl = $(this).css('text-align');
			if (textAl != null && textAl != '')
				$(item).css({ 'text-align': textAl });
			i++;
		});
	});
}

function ClearMinWidthTotalizers() {
	$("table.GridWithTotalizer").each(function () {;
		var idGrid = $(this).attr('id');
		var tableTotalizerId = idGrid.substring(0, idGrid.indexOf("ContainerTbl")).toUpperCase() + "TABLETOTALIZER";
		if ($("#" + tableTotalizerId).hasClass("TableTotalizerAl"))
			$("#" + tableTotalizerId).css({ minWidth: 0 });

		var i = 0;
		$('#' + idGrid).find('th.GridWithTotalizer').each(function () {
			var item = $("#" + tableTotalizerId + " td")[i];
			$(item).css({ width: 0 });
			if ($(this).css('display') == 'none')
				$(item).css({ display: 'none' });
			else
				$(item).css({ display: 'table-cell' });
			i++;
		});
	});
}

$(window).resize(function () {
	SetMinWidthTotalizers();
});

$(window).load(function () {
	SetMinWidthTotalizers();
});