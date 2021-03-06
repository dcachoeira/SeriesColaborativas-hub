﻿/* START OF FILE - ..\Sources\Preview.src.js - */
// Initialization for Query object preview tab
function IsQueryObjectPreview() {
	return window.external != undefined && window.external.SendText != undefined;
}

function IsDashboardEdit() {
	return typeof UCDashboardForEditor !== 'undefined';
}

function UpdateQueryObjectPreview(postDataJSON) {

	function SetPreviewData(qViewer, postDataJSON) {
		var postData = JSON.parse(postDataJSON);
		var keys = Object.keys(postData);
		for (var i = 0; i < keys.length; i++) {
			var key = keys[i];
			qViewer[key] = postData[key];
		}
	}

	var userControlId = Object.keys(qv.collection)[0];
	var qViewer = qv.collection[userControlId];
	SetPreviewData(qViewer, postDataJSON);
	qViewer.realShow();

}
/* END OF FILE - ..\Sources\Preview.src.js - */
/* START OF FILE - ..\Sources\Util.src.js - */
ACTIVITY_INDICATOR_CLASS = 'gx-qv-loading'

var qv = { collection: {} }

qv.util = {

	color: {

		getHtmlColor: function (color) {
			var htmlColor;
			if ((typeof (color) == "string") || (typeof (color) == "number")) {
				if (gx.color.toHex) {
					if (color == -1) // -1 = null color
						htmlColor = "";
					else htmlColor = "#" + gx.color.toHex(color); // GeneXus X Ev. 1
				} else htmlColor = "#" + gxToHex(color) // GeneXus X
			} else htmlColor = (color == undefined ? "#000000" : color.Html);
			return htmlColor;
		},

		parseCSSColor: function (color) {
			if (color.substring(0, 3) == "rgb") {
				var values = color.replace("rgb", "").replace("(", "").replace(")", "").split(",");
				var numColor = gx.color.rgb(parseInt(values[0]), parseInt(values[1]), parseInt(values[2]));
				return this.getHtmlColor(numColor);
			} else return color;
		},

		convertValueToColor: function (value) {
			var valueColor;
			if (value.indexOf("#") == -1)
				valueColor = "#" + value;
			else
				valueColor = value;
			var vColor = valueColor.substring(1, valueColor.length);
			while (vColor.length < 6)
				vColor = "0" + vColor;
			return "#" + vColor;
		}

	},

	css: (function () {

		var CSSStyles = {}

		function getCSSStyle(className) {
			if (CSSStyles[className] != undefined)
				return CSSStyles[className];
			else {
				styleObj = loadCSSStyle(className);
				if (styleObj != undefined) {
					styleTransformed = transformCSSStyle(styleObj)
					CSSStyles[className] = styleTransformed;
					return styleTransformed;
				} else return "";
			}
		}

		function loadCSSStyle(className) {
			var css;
			var cssName = gx.theme + ".css";
			var cssFound = false;
			var styleObj;
			for (var i = 0; i < document.styleSheets.length; i++)
				if (document.styleSheets[i].href != null && document.styleSheets[i].href.indexOf(cssName) >= 0) {
					cssFound = true;
					css = document.styleSheets[i];
					break;
				}
			if (cssFound) if (css.cssRules) crossRules = css.cssRules;
			else if (css.rules) crossRules = css.rules;
			var lengthRuleSelected = Number.MAX_SAFE_INTEGER;
			for (var i = 0; i < crossRules.length; i++) {
				var rule = crossRules[i];
				if (rule.selectorText != undefined)
					if (rule.selectorText.toLowerCase().indexOf("." + className.toLowerCase()) == 0 && rule.selectorText.length < lengthRuleSelected) {
						styleObj = rule.style;
						lengthRuleSelected = rule.selectorText.length;
					}
			}
			return styleObj;
		}

		function transformCSSStyle(styleObj) {
			var strAux = "";
			if (styleObj.color != "") strAux += (strAux == "" ? "" : ";") + "color:" + qv.util.color.parseCSSColor(styleObj.color);
			if (styleObj.backgroundColor != "") strAux += (strAux == "" ? "" : ";") + "backgroundColor:" + qv.util.color.parseCSSColor(styleObj.backgroundColor);
			if (styleObj.borderStyle != "") strAux += (strAux == "" ? "" : ";") + "borderStyle:" + styleObj.borderStyle;
			if (styleObj.borderWidth != "") strAux += (strAux == "" ? "" : ";") + "borderThickness:" + styleObj.borderWidth.replace("pt", "").replace("px", "");
			if (styleObj.borderColor != "") strAux += (strAux == "" ? "" : ";") + "borderColor:" + qv.util.color.parseCSSColor(styleObj.borderColor);
			//if (styleObj.paddingLeft != "")        strAux += (strAux == "" ? "" : ";") + "paddingLeft:"      + styleObj.paddingLeft.replace("pt", "").replace("px", "");
			//if (styleObj.paddingRight != "")       strAux += (strAux == "" ? "" : ";") + "paddingRight:"     + styleObj.paddingRight.replace("pt", "").replace("px", "");
			//if (styleObj.paddingTop != "")         strAux += (strAux == "" ? "" : ";") + "paddingTop:"       + styleObj.paddingTop.replace("pt", "").replace("px", "");
			//if (styleObj.paddingBottom != "")      strAux += (strAux == "" ? "" : ";") + "paddingBottom:"    + styleObj.paddingBottom.replace("pt", "").replace("px", "");
			if (styleObj.fontFamily != "") strAux += (strAux == "" ? "" : ";") + "fontFamily:" + styleObj.fontFamily.replace(/"/g, "").replace(/'/g, "");
			if (styleObj.fontSize != "") strAux += (strAux == "" ? "" : ";") + "fontSize:" + styleObj.fontSize.replace("pt", "").replace("px", "");
			if (styleObj.fontWeight != "") strAux += (strAux == "" ? "" : ";") + "fontWeight:" + styleObj.fontWeight;
			if (styleObj.fontStyle != "") strAux += (strAux == "" ? "" : ";") + "fontStyle:" + styleObj.fontStyle;
			if (styleObj.textDecoration != "") strAux += (strAux == "" ? "" : ";") + "textDecoration:" + styleObj.textDecoration;
			//if (styleObj.textAlign != "")          strAux += (strAux == "" ? "" : ";") + "textAlign:"        + styleObj.textAlign;

			// Faltan
			//    backgroundAlpha   = "1"     // 0 .. 1
			//    cornerRadius    = "0"       // 0 .. n
			//    dropShadowEnabled = "true"    // true | false
			//    shadowDirection   = "right"   // left | right | center
			return strAux;
		}
	
		return {

			replaceCssClasses: function (xml) {
				var replaceMarker = "gxpl_cssReplace(";
				while ((posIni = xml.indexOf(replaceMarker)) >= 0) {
					posFin = xml.indexOf(")", posIni);
					className = xml.substring(posIni + replaceMarker.length, posFin);
					style = getCSSStyle(className);
					toReplace = xml.substring(posIni, posFin + 1);
					xml = xml.replace(toReplace, style);
				}
				return xml;
			},

			parseStyle: function (style) {
				var cssStyle = "";
				if (style != "" && style != undefined) {
					if (style.indexOf(":") < 0)
						return style;	// No se parsea pues el el nombre de una clase
					else {
						var arr = style.split(";");
						for (var i = 0; i < arr.length; i++) {
							var arr2 = arr[i].split(":");
							var key = arr2[0];
							var value = arr2[1];
							var key2;
							var units = "";
							switch (key) {
								case "color":
									key2 = "color";
									break;
								case "backgroundColor":
									key2 = "background-color";
									break;
								case "borderStyle":
									key2 = "border-style";
									break;
								case "borderThickness":
									key2 = "border-width";
									units = "px";
									break;
								case "borderColor":
									key2 = "border-color";
									break;
								case "fontFamily":
									key2 = "font-family";
									break;
								case "fontSize":
									key2 = "font-size";
									units = "px";
									break;
								case "fontWeight":
									key2 = "font-weight";
									break;
								case "fontStyle":
									key2 = "font-style";
									break;
								case "textDecoration":
									key2 = "text-decoration";
									break;
							}
							cssStyle += key2 + ":" + value + units + ";";
						}
					}
					return cssStyle;
				}
				return cssStyle;
			}

		}

	})(),

	autorefresh: (function () {

		return {

			UpdateLayoutSameGroup: function (qViewer, xml) {

				function ParseParametersXML(qViewer, xml) {
					var xmlDoc = qv.util.dom.xmlDocument(xml);
					var rootElement = qv.util.dom.getSingleElementByTagName(xmlDoc, "gxpl_ParameterCollection");
					if (qViewer.Metadata == undefined)
						qViewer.Metadata = {};
					qViewer.Metadata.Parameters = [];
					var parameters = qv.util.dom.getMultipleElementsByTagName(rootElement, "gxpl_Parameter");
					for (var i = 0; i < parameters.length; i++) {
						var parameter = {};
						parameter.Name = qv.util.dom.getValueNode(qv.util.dom.getSingleElementByTagName(parameters[i], "Name"));
						parameter.Type = qv.util.dom.getValueNode(qv.util.dom.getSingleElementByTagName(parameters[i], "Type"));
						parameter.IsCollection = gx.lang.gxBoolean(qv.util.dom.getValueNode(qv.util.dom.getSingleElementByTagName(parameters[i], "IsCollection")));
						qViewer.Metadata.Parameters.push(parameter);
					}
				}

				function UpdateTargetAxesAndParametersFromSourceAxes(qViewer, sourceAxes, sourceTableType) {
					
					function GetFieldInQuery(qViewer, fieldName) {

						function GetFieldInCollection(col, property, fieldName) {
							for (var i = 0 ; i < col.length; i++) {
								var field = col[i];
								if (field[property] == fieldName)
									return field;
							}
							return null;
						}

						function GetAxisInQuery(qViewer, fieldName) {
							return GetFieldInCollection(qViewer.Metadata.Axes, "Name", fieldName);
						}

						function GetDatumInQuery(qViewer, fieldName) {
							return GetFieldInCollection(qViewer.Metadata.Data, "Name", fieldName);
						}

						var field = GetAxisInQuery(qViewer, fieldName);
						if (field == null)
							field = GetDatumInQuery(qViewer, fieldName);
						return field;

					}

					function GetRuntimeAxis(qViewer, axisName) {
						var runtimeAxis = null;
						for (var i = 0; i < qViewer.Axes.length; i++) {
							if (qViewer.Axes[i].Name == axisName) {
								runtimeAxis = qViewer.Axes[i];
								break;
							}
						}
						return runtimeAxis;
					}

					function CopyAxisInfo(sourceAxis, targetAxis) {
						if (targetAxis.Title == undefined)
							targetAxis.Title = "";		// porque sino pone "undefined"
						if (targetAxis.Aggregation == undefined)
							targetAxis.Aggregation = "";		// porque sino pone "undefined"
						if (targetAxis.AxisOrder == undefined)
							targetAxis.AxisOrder = { Type: "None" };
						if (targetAxis.Format == undefined)
							targetAxis.Format = { Subtotals: "Yes" };
						qv.util.MergeFields(targetAxis, sourceAxis);
					}

					function GetParameterInQuery(qViewer, axisName) {
						for (var i = 0 ; i < qViewer.Metadata.Parameters.length; i++) {
							var parameter = qViewer.Metadata.Parameters[i];
							if (parameter.IsCollection && parameter.Name == axisName)
								return [i, parameter];
						}
						return [null, null];
					}

					function GetRuntimeParameter(qViewer, axisName) {
						var runtimeParameter = null;
						for (var i = 0; i < qViewer.Parameters.length; i++) {
							if (qViewer.Parameters[i].Name == axisName) {
								runtimeParameter = qViewer.Parameters[i];
								break;
							}
						}
						return runtimeParameter;
					}

					function GetRuntimeParameterValue(sourceAxis, parameter) {
						var valueList = "";
						var delimiter = (parameter.Type == "I" || parameter.Type == "R" || parameter.Type == "B" ? "" : "\"");
						for (var i = 0; i < sourceAxis.Filter.Values.length; i++) {
							valueList += (valueList == "" ? "" : ",") + delimiter + sourceAxis.Filter.Values[i] + delimiter;
						}
						valueList = "[" + valueList + "]";
						return valueList;
					}

					var fields = [];
					if (!qViewer._parametersCloned) {
						// Clono la collection de parámetros pues aunque se carguen en los eventos con la misma variable el autorefresh agrega diferente a la collection dependiendo de si es chart o no chart
						qViewer._parametersCloned = true;
						qViewer.Parameters = qv.util.cloneObject(qViewer.Parameters);
					}
					var keys = qv.util.GetOrderedAxesKeys(axes);
					for (var i = 0; i < keys.length; i++) {
						var index = parseInt(keys[i].substr(5, 4));
						sourceAxis = sourceAxes[index];
						var parameterArray = GetParameterInQuery(qViewer, sourceAxis.Name);
						var parameterPosition = parameterArray[0];
						var parameter = parameterArray[1];
						var field = GetFieldInQuery(qViewer, sourceAxis.Name);
						var applyToAxis = (field != null);
						var applyToParameter = !applyToAxis;
						if (applyToAxis) {
							var runtimeAxis = GetRuntimeAxis(qViewer, sourceAxis.Name);
							if (runtimeAxis == null) {
								runtimeAxis = {};
								runtimeAxis.Name = sourceAxis.Name;
							}
							if (sourceTableType == "Table" && qViewer.RealType != "Table")
								sourceAxis.AxisType = qv.util.ToQueryViewerAxisType(field.AxisType);	// Porque la tabla no tiene la distinción de filas, columnas o páginas
							CopyAxisInfo(sourceAxis, runtimeAxis);
							fields.push(runtimeAxis);
						}
						if (applyToParameter) {
							// no existe un eje para aplicar los cambios, busco si puedo aplicarlos en un parametro
							if (parameter != null) {
								// existe un parámetro en la query destino, aplico los cambios ahí
								var runtimeParameterValue = GetRuntimeParameterValue(sourceAxis, parameter);
								if (qViewer.Object) {
									var array = eval(qViewer.Object);
									array[parameterPosition + 2] = runtimeParameterValue;
									qViewer.Object = JSON.stringify(array);
								}
								else {
									var runtimeParameter = GetRuntimeParameter(qViewer, sourceAxis.Name);
									if (runtimeParameter == null) {
										runtimeParameter = {};
										runtimeParameter.Name = sourceAxis.Name;
										qViewer.Parameters.push(runtimeParameter);
									}
									runtimeParameter.Value = runtimeParameterValue;
								}
							}
						}
					}
					qViewer.Axes = fields;
				}

				function UpdateQueryViewer(qViewer, axes, sourceTableType) {
					UpdateTargetAxesAndParametersFromSourceAxes(qViewer, axes, sourceTableType);
					qViewer.RememberLayout = false;
					qViewer.AllowChangeAxesOrder = true;
					qv.util.autorefresh.SaveAxesAndParametersState(qViewer);
					qViewer.realShow();
				}

				if ((qViewer.AutoRefreshGroup != undefined) && (qViewer.AutoRefreshGroup != null) && (qViewer.AutoRefreshGroup != "") && (qv.util.trim(qViewer.AutoRefreshGroup) != "")) {

					qv.util.autorefresh.DeleteAxesAndParametersState(qViewer);
					var axes = qv.pivot.GetRuntimeMetadata(xml, qViewer.RealType);
					var sourceTableType = qViewer.RealType;

					for (index in qv.collection) {
						qViewerOther = qv.collection[index];
						if (qv.services.IsObjectSet(qViewerOther))
							if (qViewerOther.userControlId() != qViewer.userControlId()) {
								if (qViewer.AutoRefreshGroup == qViewerOther.AutoRefreshGroup) {
									// In same Refresh Group
									qViewerOther._isAutorefresh = true;
									if (qViewerOther.Metadata != undefined && qViewerOther.Metadata.Parameters != undefined)
										UpdateQueryViewer(qViewerOther, axes, sourceTableType);
									else
										qViewerOther.getQueryParameters(function (parametersXML, qViewer) {
											ParseParametersXML(qViewer, parametersXML);
											UpdateQueryViewer(qViewer, axes, sourceTableType);
										});
								}
							}
					}
				}

			},

			LoadAxesAndParametersState: function (qViewer) {
				var path = window.location.pathname + "_" + qViewer.userControlId() + "_" + qViewer.ObjectId + "_" + qViewer.ObjectName + "_";
				var cookieparameterID = path + "Parameters";
				var cookieAxesID = path + "Axes";
				var parametersString = qv.util.storage.getItem(cookieparameterID);
				var AxesString = qv.util.storage.getItem(cookieAxesID);
				if (parametersString != null && parametersString != "") {
					qViewer.Parameters = JSON.parse(parametersString);
					qViewer.RememberLayout = false;
				}
				if (AxesString != null && AxesString != "") {
					qViewer.Axes = JSON.parse(AxesString);
					qViewer.RememberLayout = false;
				}
			},

			SaveAxesAndParametersState: function (qViewer) {
				var path = window.location.pathname + "_" + qViewer.userControlId() + "_" + qViewer.ObjectId + "_" + qViewer.ObjectName + "_";
				var cookieparameterID = path + "Parameters";
				var cookieAxesID = path + "Axes";
				qv.util.storage.setItem(cookieparameterID, JSON.stringify(qViewer.Parameters));
				qv.util.storage.setItem(cookieAxesID, JSON.stringify(qViewer.Axes));
			},

			DeleteAxesAndParametersState: function (qViewer) {
				var path = window.location.pathname + "_" + qViewer.userControlId() + "_" + qViewer.ObjectId + "_" + qViewer.ObjectName + "_";
				var cookieparameterID = path + "Parameters";
				var cookieAxesID = path + "Axes";
				qv.util.storage.removeItem(cookieparameterID);
				qv.util.storage.removeItem(cookieAxesID);
			}

		}

	})(),        
	
	dom: {

		getSingleElementByTagName: function (parent, name) {
			var nodes;
			var node;
			nodes = this.getMultipleElementsByTagName(parent, name);
			node = (nodes.length > 0 ? nodes[0] : null);
			return node;
		},

		getMultipleElementsByTagName: function (parent, name) {
			var nodes;
			var node;
			if (!gx.util.browser.isIE() || gx.util.browser.ieVersion() >= 12)
				nodes = parent.getElementsByTagName(name);
			else // Internet Explorer
				nodes = parent.selectNodes(name);
			return nodes;
		},

		getValueNode: function (node) {
			if ((node == null) || (node == undefined))
				return null;
			if ((node.firstChild != null) && (node.firstChild != undefined))
				return node.firstChild.nodeValue;
			else
				return null;
		},

		selectXPathNode: function (xmlDoc, xpath) {
			var nodes;
			var node;
			if (xmlDoc.evaluate) { // Firefox, Chrome, Opera and Safari
				nodes = xmlDoc.evaluate(xpath, xmlDoc, null, XPathResult.ANY_TYPE, null);
				node = nodes.iterateNext();
			} else {			// Internet Explorer
				nodes = xmlDoc.selectNodes(xpath);
				node = (nodes.length > 0 ? nodes[0] : null);
			}
			return node;
		},

		xmlDocument: function (text) {
			var xmlDoc;
			if (!gx.util.browser.isIE() || gx.util.browser.ieVersion() >= 12) {
				parser = new DOMParser();
				xmlDoc = parser.parseFromString(text, "text/xml");
			} else // Internet Explorer
			{
				xmlDoc = new ActiveXObject("Microsoft.XMLDOM");
				xmlDoc.async = "false";
				xmlDoc.loadXML(text);
			}
			return xmlDoc;
		}

	},

	storage: (function() {

		function createCookie(name, value, days) {
			if (days) {
				var date = new Date();
				date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
				var expires = "; expires=" + date.toGMTString();
			} else
				var expires = "";
			document.cookie = name + "=" + value + expires + "; path=/";
		}

		function readCookie(name) {
			var nameEQ = name + "=";
			var ca = document.cookie.split(';');
			for (var i = 0; i < ca.length; i++) {
				var c = ca[i];
				while (c.charAt(0) == ' ') c = c.substring(1, c.length);
				if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
			}
			return null;
		}

		function eraseCookie(name) {
			createCookie(name, "", -1);
		}

		return {

			setItem: function (key, data) {
				if (!!localStorage)
					localStorage.setItem(key, data);
				else
					createCookie(key, data, 365);
			},

			getItem: function (key) {
				if (!!localStorage)
					return localStorage.getItem(key);
				else
					return readCookie(key);
			},

			removeItem: function (key) {
				if (!!localStorage)
					localStorage.removeItem(key);
				else
					eraseCookie(key);
			}
		}

	})(),

	ExecuteTracker: function (trackerId, trackerData) {
		var trackers = Array();
		for (var i = 0; i < gx.fx.ctx.trackers.length; i++)
			if (gx.fx.ctx.trackers[i].types[0] == trackerId) trackers[trackers.length] = gx.fx.ctx.trackers[i];
		for (var i = 0; i < trackers.length; i++) {
			var tgxO = gx.O;
			gx.O = trackers[i].obj;
			var tCmp = gx.csv.cmpCtx;
			gx.csv.cmpCtx = trackers[i].obj.CmpContext;
			gx.evt.setProcessing(false);
			trackers[i].hdl.call(trackers[i].obj, null, null, trackerData);
			gx.O = tgxO;
			gx.csv.cmpCtx = tCmp;
		}
	},

	satisfyStyle: function (value, conditionalStyle) {
		switch (conditionalStyle.Operator) {
			case "EQ":
				return value == conditionalStyle.Value1;
			case "GT":
				return value > conditionalStyle.Value1;
			case "LT":
				return value < conditionalStyle.Value1;
			case "GE":
				return value >= conditionalStyle.Value1;
			case "LE":
				return value <= conditionalStyle.Value1;
			case "NE":
				return value != conditionalStyle.Value1;
			case "IN":
				return value >= conditionalStyle.Value1 && value <= conditionalStyle.Value2;
		}
	},

	isGeneXusPreview: function () {
		return IsQueryObjectPreview();
	},

	getGenerator: function () {
		var gen;
		if (gx.gen.isDotNet())
			gen = "C#";
		else if (gx.gen.isJava())
			gen = "Java";
		else
			gen = "";
		return gen;
	},

	fixSize: function (size) {
		return size.replace("px", "");
	},

	getErrorFromText: function (resultText) {
		if (resultText == "<Result OK=\"True\"></Result>")
			return ""; // No hubo error
		else
			return resultText.replace("<Result OK=\"False\"><Dsc>", "").replace("</Dsc></Result>", "");
	},

	trim: function (str) {
		if (typeof str != 'string')
			return null;
		return str.replace(/^[\s]+/, '').replace(/[\s]+$/, '').replace(/[\s]{2,}/, ' ');
	},

	capitalize: function (str) {
		return str.charAt(0).toUpperCase() + str.slice(1);
	},

	decapitalize: function (str) {
		return str.charAt(0).toLowerCase() + str.slice(1);
	},

	dateToString: function (date, includeTime) {
		var dateStr = date.getStringWithFmt("Y4MD").replace(/\//g, "-");
		if (includeTime) {
			date.TimeFmt = 24;
			dateStr += " " + date.getTimeString(true, true);
		}
		return dateStr;
	},

	cloneObject: function (obj) {
		return JSON.parse(JSON.stringify(obj));
	},

	endsWith: function (string, subString) {
		return string.substr(string.length - subString.length, subString.length) == subString;
	},

	startsWith: function (string, subString) {
		return string.substr(0, subString.length) == subString;
	},

	formatNumber: function (number, decimalPrecision, picture, removeTrailingZeroes) {

		var formattedNumber = gx.num.formatNumber(number, decimalPrecision, picture, 0, true, false);
		if (removeTrailingZeroes) {
			if (formattedNumber.indexOf(".") >= 0 || formattedNumber.indexOf(",") >= 0) {
				while (qv.util.endsWith(formattedNumber, "0"))
					formattedNumber = formattedNumber.slice(0, -1);
				if (qv.util.endsWith(formattedNumber, ".") || qv.util.endsWith(formattedNumber, ","))
					formattedNumber = formattedNumber.slice(0, -1);
			}
		}
		return formattedNumber;
	},

	formatDateTime: function (date, dataType, dateFormat, includeHours, includeMinutes, includeSeconds) {
		var gxDate = new gx.date.gxdate(date, "Y4MD");
		var formattedDate = gxDate.getStringWithFmt(dateFormat);
		if (dataType == "datetime") {
			gxDate.TimeFmt = 24;
			formattedDate += " " + gxDate.getTimeString(includeMinutes, includeSeconds, includeHours);
		}
		return formattedDate;
	},

	seconsdToText: function (seconds) {
		var text;
		var picture = "ZZZZZZZZZZZZZZ9";
		var decimalPrecision = 0;
		if (seconds < 60)							// less than 1 minute
			text = qv.util.formatNumber(Math.round(seconds), decimalPrecision, picture, false) + " " + qv.util.decapitalize(gx.getMessage("GXPL_QViewerSeconds"));
		else if (seconds < 60 * 60)					// less than 1 hour
			text = qv.util.formatNumber(Math.round(seconds / 60), decimalPrecision, picture, false) + " " + qv.util.decapitalize(gx.getMessage("GXPL_QViewerMinutes"));
		else if (seconds < 60 * 60 * 24)			// less than 1 day
			text = qv.util.formatNumber(Math.round(seconds / 60 / 60), decimalPrecision, picture, false) + " " + qv.util.decapitalize(gx.getMessage("GXPL_QViewerHours"));
		else if (seconds < 60 * 60 * 24 * 30.44)	// less than 1 month
			text = qv.util.formatNumber(Math.round(seconds / 60 / 60 / 24), decimalPrecision, picture, false) + " " + qv.util.decapitalize(gx.getMessage("GXPL_QViewerDays"));
		else if (seconds < 60 * 60 * 24 * 365.25)	// less than 1 year
			text = qv.util.formatNumber(Math.round(seconds / 60 / 60 / 24 / 30.44), decimalPrecision, picture, false) + " " + qv.util.decapitalize(gx.getMessage("GXPL_QViewerMonths"));
		else										// more than 1 year
			text = qv.util.formatNumber(Math.round(seconds / 60 / 60 / 24 / 365.25), decimalPrecision, picture, false) + " " + qv.util.decapitalize(gx.getMessage("GXPL_QViewerYears"));
		return text;
	},

	ParseNumericPicture: function (dataType, picture) {
		var decimalPrecision;
		var useThousandsSeparator;
		var prefix = "";
		var suffix = "";
		if (picture == "") {
			decimalPrecision = (dataType == "integer" ? 0 : 2);
			useThousandsSeparator = false;
		}
		else {			// Saco los datos de la picture
			if (picture.indexOf(".") < 0 && picture.indexOf(",") < 0) {		// No tiene ni punto ni coma
				decimalPrecision = 0;
				useThousandsSeparator = false;
			} else if (picture.indexOf(".") >= 0 && picture.indexOf(",") < 0) {	// Tiene solo punto
				decimalPrecision = (dataType == "integer" ? 0 : picture.length - picture.indexOf(".") - 1);
				useThousandsSeparator = false;
			} else if (picture.indexOf(".") < 0 && picture.indexOf(",") >= 0) {	// Tiene solo coma
				decimalPrecision = 0;
				useThousandsSeparator = true;
			} else {															// Tiene punto y coma
				decimalPrecision = (dataType == "integer" ? 0 : picture.length - picture.indexOf(".") - 1);
				useThousandsSeparator = true;
			}
			// Obtengo prefijo y sufijo.
			// pictureArea = 1 (prefijo), 2 (número) o 3 (sufijo)
			var pictureArea = 1;
			for (var i = 0; i < picture.length; i++) {
				var chr = picture.substr(i, 1);
				if ((chr == "." || chr == "," || chr == "9" || chr == "Z") && pictureArea == 1)
					pictureArea = 2;
				if ((chr != "." && chr != "," && chr != "9" && chr != "Z") && pictureArea == 2)
					pictureArea = 3;
				switch (pictureArea) {
					case 1:
						prefix += chr;
						break;
					case 3:
						suffix += chr;
						break;
				}
			}
		}
		return { DecimalPrecision: decimalPrecision, UseThousandsSeparator: useThousandsSeparator, Prefix: prefix, Suffix: suffix };
	},

	ParseDateTimePicture: function (dataType, picture) {
		var dateFormat = gx.dateFormat;
		var includeHours = dataType == "datetime";
		var includeMinutes = dataType == "datetime";
		var includeSeconds = dataType == "datetime";
		if (picture != "") {
			if (picture.indexOf("9999") >= 0 && dateFormat.indexOf("Y4") < 0)
				dateFormat = dateFormat.replace("Y", "Y4");
			else if (picture.indexOf("9999") < 0 && dateFormat.indexOf("Y4") >= 0)
				dateFormat = dateFormat.replace("Y4", "Y");
			if (dataType == "datetime") {
				var posSeparator = picture.indexOf(" ");
				if (posSeparator >= 0) {
					var timePart = picture.substr(posSeparator + 1, picture.length - posSeparator);
					includeHours = timePart.length >= 2;
					includeMinutes = timePart.length >= 5;
					includeSeconds = timePart.length == 8;
				}
				else {
					includeHours = false;
					includeMinutes = false;
					includeSeconds = false;
				}
			}
		}
		return { DateFormat: dateFormat, IncludeHours: includeHours, IncludeMinutes: includeMinutes, IncludeSeconds: includeSeconds };
	},

	aggregate: function (aggregation, values, quantities) {
		aggregation = aggregation || "Sum";
		var sumValues = null;
		var sumQuantities = null;
		var minValue = null;
		var maxValue = null;
		switch (aggregation) {
			case "Sum":
				for (var i = 0; i < values.length; i++) {
					if (values[i] != null)
						sumValues += values[i];
				}
				return sumValues;
			case "Average":
				for (var i = 0; i < values.length; i++) {
					if (values[i] != null) {
						sumValues += values[i];
						sumQuantities += quantities[i];
					}
				}
				return sumValues != null ? sumValues / sumQuantities : null;
			case "Count":
				for (var i = 0; i < quantities.length; i++) { sumQuantities += quantities[i]; }
				return sumQuantities;
			case "Max":
				for (var i = 0; i < values.length; i++) { maxValue = (maxValue == null ? values[i] : (values[i] > maxValue ? values[i] : maxValue)); }
				return maxValue;
			case "Min":
				for (var i = 0; i < values.length; i++) { minValue = (minValue == null ? values[i] : (values[i] < minValue ? values[i] : minValue)); }
				return minValue;
		}
	},

	FromRuntimeMetadata: function (hidden, isDimension, type) {
		if (hidden == "true")
			return "Hidden";
		if (!isDimension)
			return "Data";
		if (type == "rows")
			return "Row";
		if (type == "columns")
			return "Column";
		return "Page";
	},

	ToQueryViewerAxisType: function (axisType) {	// Convierte hacia el dominio QueryViewerAxisType
		switch (axisType) {
			case "Rows":
				return "Row";
			case "Columns":
				return "Column";
			case "Pages":
				return "Page";
			case "Data":
				return "Data";
			case "Hidden":
				return "NotShow";
		}
	},

	anyError: function (resultText) {
		return (resultText.indexOf("<Result OK=\"False\"><Dsc>") == 0);
	},

	showActivityIndicator: function (qViewer) {
		gx.dom.addClass(qViewer.getContainerControl(), ACTIVITY_INDICATOR_CLASS);
	},

	hideActivityIndicator: function (qViewer) {
		gx.dom.removeClass(qViewer.getContainerControl(), ACTIVITY_INDICATOR_CLASS);
	},

	renderError: function (qViewer, errMsg) {
		if (IsQueryObjectPreview() && !IsDashboardEdit()) // Preview en GeneXus (se muestra en el output)
			window.external.SendText(qViewer.ControlName, errMsg);
		else // Aplicación generada
		{
			qViewer.AdjustSize();
			var buffer = "<table height=" + this.fixSize(qViewer.Height) + " width =" + this.fixSize(qViewer.Width) + " style=\"border-right: silver thin solid; border-top: silver thin solid; border-left: silver thin solid; border-bottom: silver thin solid"  + "\"><tbody><tr><td align=center>" + gx.getMessage("GXPL_QViewerError") + ": " + errMsg + "</td></tr></tbody></table>";
			qViewer.setHtml(buffer);
		}
	},

	GetDesigntimeMetadata: function (qViewer) {

		var queryViewerAxes = [];
		// Agrego los ejes
		for (var i = 0; i < qViewer.Metadata.Axes.length; i++) {
			var axis = qViewer.Metadata.Axes[i];
			var queryViewerAxis = {};
			queryViewerAxis.Name = axis.Name;
			queryViewerAxis.Title = axis.Title;
			queryViewerAxis.DataField = axis.DataField;
			queryViewerAxis.Type = qv.util.ToQueryViewerAxisType(axis.AxisType);
			queryViewerAxis.Filter = axis.Filter;
			queryViewerAxis.ExpandCollapse = axis.ExpandCollapse;
			queryViewerAxis.AxisOrder = axis.Order;
			queryViewerAxis.Format = {};
			queryViewerAxis.Format.Subtotals = axis.Subtotals;
			queryViewerAxis.Format.Picture = axis.Picture;
			queryViewerAxis.Format.CanDragToPages = axis.CanDragToPages;
			queryViewerAxis.Format.Style = axis.Style;
			if (axis.ValuesStyles.length > 0)
				queryViewerAxis.Format.ValuesStyles = axis.ValuesStyles;
			queryViewerAxes.push(queryViewerAxis);
		}
		// Agrego los datos
		for (var i = 0; i < qViewer.Metadata.Data.length; i++) {
			var datum = qViewer.Metadata.Data[i];
			var queryViewerAxis = {};
			queryViewerAxis.Name = datum.Name;
			queryViewerAxis.Title = datum.Title;
			queryViewerAxis.DataField = datum.DataField;
			queryViewerAxis.Type = qv.util.ToQueryViewerAxisType(datum.AxisType);
			queryViewerAxis.Aggregation = datum.Aggregation;
			queryViewerAxis.Format = {};
			queryViewerAxis.Format.Picture = datum.Picture;
			queryViewerAxis.Format.Style = datum.Style;
			queryViewerAxis.Format.TargetValue = datum.TargetValue;
			queryViewerAxis.Format.MaximumValue = queryViewerAxis.Format.TargetValue;
			if (datum.ConditionalStyles.length > 0)
				queryViewerAxis.Format.ConditionalStyles = datum.ConditionalStyles;
			queryViewerAxes.push(queryViewerAxis);
		}
		return queryViewerAxes;
	},
	
	MergeFields: function (designtimeField, runtimeField) {
		designtimeField.Type = runtimeField.AxisType;
		if (designtimeField.Type != "Data" && designtimeField.Type != "Hidden") {
			switch (designtimeField.AxisOrder.Type) {

				case "None":
				case "Ascending":
				case "Descending":
					designtimeField.AxisOrder.Type = runtimeField.Order;
					break;
				case "Custom":
					if (runtimeField.Order == "Descending")
						designtimeField.AxisOrder.Values.reverse();
					break;
			}
			if (designtimeField.Format.Subtotals != "No")
				if (runtimeField.Subtotals != undefined)
					designtimeField.Format.Subtotals = (runtimeField.Subtotals == "Yes" ? "Yes" : "Hidden");
			designtimeField.Filter = runtimeField.Filter;
			designtimeField.ExpandCollapse = runtimeField.ExpandCollapse;
		}
	},

	GetOrderedAxesKeys: function (axes) {

		function padLeft(nr, n, str) {
			return Array(n - String(nr).length + 1).join(str || '0') + nr;
		}

		var keys = [];
		for (var i = 0; i < axes.length; i++) {
			var axis = axes[i];
			var key;
			switch (axis.AxisType) {
				case "Row":
					key = "A" + padLeft(axis.AxisPosition, 4, "0") + padLeft(i, 4, "0");
					break;
				case "Column":
					key = "B" + padLeft(axis.AxisPosition, 4, "0") + padLeft(i, 4, "0");
					break;
				case "Page":
					key = "C" + padLeft(axis.AxisPosition, 4, "0") + padLeft(i, 4, "0");
					break;
				case "Hidden":
					key = "D" + padLeft(axis.AxisPosition, 4, "0") + padLeft(i, 4, "0");
					break;
				case "Data":
					key = "E" + padLeft(axis.AxisPosition, 4, "0") + padLeft(i, 4, "0");
					break;
			}
			keys.push(key);
		}
		keys.sort();
		return keys;

	},

	GetContainerControlClass: function (qViewer) {
		if (qViewer.Class != "") {
			var ucClass = qViewer.Class + "-" + qViewer.RealType.toLowerCase();
			return ucClass;
		}
		else
			return "";
	},

	SetUserControlClass: function (uc, className) {
		uc.getContainerControl().className = "gx_usercontrol " + className;
	}

}
/* END OF FILE - ..\Sources\Util.src.js - */
/* START OF FILE - ..\Sources\Services.src.js - */
var STATE_DONE = 4
var STATUS_OK = 200

qv.services = (function () {

	function MetadataChanged(qViewer, key) {

		function MetadataType(outputType) {
			if (outputType == "Table")
				return "OnlyRows";
			else
				return "AllAxisTypes";
		}

		var runtimeFieldsJSON = qv.services.RuntimeFieldsJSON(qViewer);
		var queryInfoTextForNullValues = "";
		var queryInfoFieldsJSON = "";
		var metadataType = MetadataType(qViewer.RealType);
		if (qViewer.QueryInfo != "") {
			var queryInfo = eval('(' + qViewer.QueryInfo + ')');
			queryInfoTextForNullValues = queryInfo.TextForNullValues;
			queryInfoFieldsJSON = gx.json.serializeJson(queryInfo.Fields);
		}
		if (qViewer.ObjectName != key.ObjectName || qViewer.ObjectType != key.ObjectType || qViewer.ObjectId != key.ObjectId || qViewer.Object != key.Object || runtimeFieldsJSON != key.RuntimeFieldsJSON || queryInfoTextForNullValues != key.QueryInfoTextForNullValues || queryInfoFieldsJSON != key.QueryInfoFieldsJSON || metadataType != key.MetadataType) {
			key.ObjectName = qViewer.ObjectName;
			key.ObjectType = qViewer.ObjectType;
			key.ObjectId = qViewer.ObjectId;
			key.Object = qViewer.Object;
			key.RuntimeFieldsJSON = runtimeFieldsJSON;
			key.QueryInfoTextForNullValues = queryInfoTextForNullValues;
			key.QueryInfoFieldsJSON = queryInfoFieldsJSON;
			key.MetadataType = metadataType;
			return true;
		}
		else
			return false;
	}

	function DataChanged(qViewer, key) {

		function DataType(outputType) {
			if (outputType == "Table")
				return "PagedRecordSet";
			else if (outputType == "PivotTable")
				return "PagedLineSet";
			else
				return "NotPaged";
		}

		function GetFieldOrdersJSON(qViewer, fields, keyOrderType) {
			var orderStr = SortAscendingForced(qViewer);
			for (var i = 0; i < fields.length; i++) {
				var field = fields[i];
				var orderType = "";
				if (field[keyOrderType] != undefined)
					orderType = field[keyOrderType].Type;
				if (orderType != "") {
					var sdtOrderType = qv.services.postInfo._priv.SdtWithValuesJSON("Order", orderType, "Custom", field[keyOrderType].Values, false);
					orderStr += "," + sdtOrderType;
				}
			}
			return orderStr;
		}

		var runtimeParametersJSON = qv.services.RuntimeParametersJSON(qViewer);
		var orderJSON = GetFieldOrdersJSON(qViewer, qViewer.Axes, "AxisOrder");
		var queryInfoSQLSentence = "";
		var queryInfoParametersJSON = "";
		var queryInfoOrderJSON = "";
		var dataType = DataType(qViewer.RealType);
		if (qViewer.QueryInfo != "") {
			var queryInfo = eval('(' + qViewer.QueryInfo + ')');
			queryInfoSQLSentence = queryInfo.SQLSentence;
			queryInfoParametersJSON = gx.json.serializeJson(queryInfo.Parameters);
			queryInfoOrderJSON = GetFieldOrdersJSON(qViewer, queryInfo.Fields, "Order");
		}
		if (qViewer.ObjectName != key.ObjectName || qViewer.ObjectType != key.ObjectType || qViewer.ObjectId != key.ObjectId || qViewer.Object != key.Object || runtimeParametersJSON != key.RuntimeParametersJSON || orderJSON != key.OrderJSON || queryInfoSQLSentence != key.QueryInfoSQLSentence || queryInfoParametersJSON != key.QueryInfoParametersJSON || queryInfoOrderJSON != key.QueryInfoOrderJSON || dataType != key.DataType) {
			key.ObjectName = qViewer.ObjectName;
			key.ObjectType = qViewer.ObjectType;
			key.ObjectId = qViewer.ObjectId;
			key.Object = qViewer.Object;
			key.RuntimeParametersJSON = runtimeParametersJSON;
			key.OrderJSON = orderJSON;
			key.QueryInfoSQLSentence = queryInfoSQLSentence;
			key.QueryInfoParametersJSON = queryInfoParametersJSON;
			key.QueryInfoOrderJSON = queryInfoOrderJSON;
			key.DataType = dataType;
			return true;
		}
		else
			return false;
	}

	function SortAscendingForced(qViewer) {
		return (qViewer.RealType == "Chart" && qv.chart.IsDatetimeXAxis(qViewer)) || (qViewer.RealType == "Card" && (qViewer.IncludeSparkline || qViewer.IncludeTrend))
	}

	return {

		url: (function () {

			function getServiceURL(serviceName) {
				var GenType = qv.util.getGenerator();
				var fc = foolCache(); // Para que el explorador no cachee los resultados de los servicios
				switch (GenType) {
					case "C#":
						return baseUrl() + "agxpl_" + serviceName + ".aspx?" + fc;
					case "Java":
						return GetJavaBaseUrl(false) + "qviewer.services.agxpl_" + serviceName + "?" + fc;
					default:
						return "";
				}
			}

			function foolCache() {
				var currentTime = new Date();
				var miliSecs = currentTime.getTime();
				return miliSecs;
			}

			function staticDirectory() {
				if (gx.staticDirectory != "")
					return gx.staticDirectory;
				else
					return this.getCookie('StaticContent');
			}

			function GetJavaBaseUrl(staticContent) {
				var baseUrl = gx.util.resourceUrl(gx.basePath, true);
				if (staticContent) {
					baseUrl += staticDirectory();
				} else
					baseUrl += "servlet/";
				return baseUrl;
			}

			function baseUrl() {
				var url = new gx.util.Url(location.href);
				var path = url.path;
				var pathResult = path.substr(0, path.lastIndexOf('/') + 1);
				if (url.port == "")
					urlresult = url.protocol + "://" + url.host + pathResult;
				else
					urlresult = url.protocol + "://" + url.host + ":" + url.port + pathResult;
				return urlresult;
			}

			return {

				getDefaultOutputURL: function () {
					return getServiceURL("getdefaultoutput");
				},

				getRecordsetCacheKeyURL: function () {
					return getServiceURL("getrecordsetcachekey");
				},

				getMetadataURL: function () {
					return getServiceURL("getmetadata");
				},

				getDataURL: function () {
					return getServiceURL("getdata");
				},

				getAttributeValuesURL: function () {
					return getServiceURL("getattributevalues");
				},

				getPageDataForTableURL: function () {
					return getServiceURL("getpagedatafortable");
				},

				getPageDataForPivotTableURL: function () {
					return getServiceURL("getpagedataforpivottable");
				},

				getQueryParametersURL: function () {
					return getServiceURL("getqueryparameters");
				}
			
			}

		})(),

		postInfo: (function () {

			function RuntimeFieldsJSON(qViewer, encodevaluescollection) {
				var strFields = '';
				var strValues = '';
				var existFields;
				var existValues;
				var picture;
				var targetValue;
				var maximumValue;
				var style;
				var subtotals;
				var CanDragToPages;
				var orderType;
				var expandCollapseType;
				var filterType;
				existFields = false;
				for (i = 0; qViewer.Axes[i] != undefined; i++) {
					existFields = true;
					strFields += (strFields != '' ? ',' : '');
					strFields += '{';
					picture = '';
					targetValue = 0;
					maximumValue = 0;
					style = '';
					subtotals = '';
					CanDragToPages = '';
					orderType = '';
					expandCollapseType = '';
					filterType = '';
					var valuesStyles = ValuesStylesJSON(qViewer.Axes[i]);
					var conditionalStyles = ConditionalStylesJSON(qViewer.Axes[i]);
					var grouping = GroupingJSON(qViewer.Axes[i]);
					if (qViewer.Axes[i].Format != undefined) {
						picture = (qViewer.Axes[i].Format.Picture ? qViewer.Axes[i].Format.Picture : "");
						targetValue = (qViewer.Axes[i].Format.TargetValue ? qViewer.Axes[i].Format.TargetValue : 0);
						maximumValue = (qViewer.Axes[i].Format.MaximumValue ? qViewer.Axes[i].Format.MaximumValue : 0);
						style = (qViewer.Axes[i].Format.Style ? qViewer.Axes[i].Format.Style : "");
						subtotals = (qViewer.Axes[i].Format.Subtotals ? qViewer.Axes[i].Format.Subtotals : "");
						CanDragToPages = (qViewer.Axes[i].Format.CanDragToPages ? qViewer.Axes[i].Format.CanDragToPages : "");
					}
					if (qViewer.Axes[i].AxisOrder != undefined) {
						orderType = qViewer.Axes[i].AxisOrder.Type;
					}
					if (qViewer.Axes[i].ExpandCollapse != undefined) {
						expandCollapseType = qViewer.Axes[i].ExpandCollapse.Type;
					}
					if (qViewer.Axes[i].Filter != undefined) {
						filterType = qViewer.Axes[i].Filter.Type;
					}
					if (filterType == undefined) filterType = "ShowSomeValues";

					strFields += '"Name":"' + encodeURIComponent(qViewer.Axes[i].Name) + '"';
					strFields += ',';
					strFields += '"Caption":"' + encodeURIComponent(qViewer.Axes[i].Title) + '"';
					strFields += ',';
					strFields += '"Aggregation":"' + qViewer.Axes[i].Aggregation + '"';
					strFields += ',';
					var t = qViewer.Axes[i].Type;
					strFields += '"Axis":{"Type":"' + (t == "Row" ? "Rows" : (t == "Column" ? "Columns" : (t == "Page" ? "Pages" : (t == "NotShow" ? "Hidden" : t)))) + '"}';
					strFields += ',';
					strFields += '"Picture":"' + encodeURIComponent(picture) + '"';
					strFields += ',';
					strFields += '"TargetValue":' + targetValue;
					strFields += ',';
					strFields += '"MaximumValue":' + maximumValue;
					strFields += ',';
					strFields += '"Style":"' + style + '"';
					strFields += ',';
					strFields += '"Subtotals":"' + subtotals + '"';
					strFields += ',';
					strFields += '"CanDragToPages":"' + CanDragToPages + '"';
					if (orderType != '') {
						var sdtOrderType = SdtWithValuesJSON("Order", orderType, "Custom", qViewer.Axes[i].AxisOrder.Values, encodevaluescollection);
						strFields += (sdtOrderType != '' ? ',' + sdtOrderType : '');
					}
					if (expandCollapseType != '') {
						var sdtExpandCollapse = SdtWithValuesJSON("ExpandCollapse", expandCollapseType, "ExpandSomeValues", qViewer.Axes[i].ExpandCollapse.Values, encodevaluescollection);
						strFields += (sdtExpandCollapse != '' ? ',' + sdtExpandCollapse : '');
					}
					if (filterType != '' && qViewer.Axes[i].Filter.Values) {
						var sdtFilter = SdtWithValuesJSON("Filter", filterType, "ShowSomeValues", qViewer.Axes[i].Filter.Values, encodevaluescollection);
						strFields += (sdtFilter != '' ? ',' + sdtFilter : '');
					}
					strFields += (valuesStyles != '' ? ',' + valuesStyles : '');
					strFields += (conditionalStyles != '' ? ',' + conditionalStyles : '');
					strFields += (grouping != '' ? ',' + grouping : '');
					strFields += '}';
				}
				if (existFields) strFields = '"RuntimeFields":[' + strFields + "]";
				return strFields;
			}

			function ValuesStylesJSON(axis) {
				var strStyles = '';
				var existStyles = false;
				if (axis.Format != undefined) {
					if (axis.Format.ValuesStyles != undefined) {
						for (var i = 0; axis.Format.ValuesStyles[i] != undefined; i++) {
							existStyles = true;
							strStyles += (strStyles != '' ? ',' : '');
							strStyles += '{';
							strStyles += '"Value":"' + encodeURIComponent(axis.Format.ValuesStyles[i].Value) + '"';
							strStyles += ',';
							strStyles += '"Style":"' + encodeURIComponent(axis.Format.ValuesStyles[i].StyleOrClass) + '"';
							strStyles += ',';
							strStyles += '"Propagate":' + (axis.Format.ValuesStyles[i].ApplyToRowOrColumn ? "true" : "false");
							strStyles += '}';
						}
					}
				}
				if (existStyles) strStyles = '"ValuesStyles":[' + strStyles + ']';
				return strStyles;
			}

			function ConditionalStylesJSON(axis) {
				var strStyles = '';
				var existStyles = false;
				if (axis.Format != undefined) {
					if (axis.Format.ConditionalStyles != undefined) {
						for (var i = 0; axis.Format.ConditionalStyles[i] != undefined; i++) {
							existStyles = true;
							strStyles += (strStyles != '' ? ',' : '');
							strStyles += '{';
							strStyles += '"Operator":"' + axis.Format.ConditionalStyles[i].Operator + '"';
							strStyles += ',';
							strStyles += '"Value1":"' + encodeURIComponent(axis.Format.ConditionalStyles[i].Value1) + '"';
							if (axis.Format.ConditionalStyles[i].Operator == "IN") {
								strStyles += ',';
								strStyles += '"Value2":"' + encodeURIComponent(axis.Format.ConditionalStyles[i].Value2) + '"';
							}
							strStyles += ',';
							strStyles += '"Style":"' + encodeURIComponent(axis.Format.ConditionalStyles[i].StyleOrClass) + '"';
							strStyles += '}';
						}
					}
				}
				if (existStyles) strStyles = '"ConditionalStyles":[' + strStyles + ']';
				return strStyles;
			}

			function GroupingJSON(axis) {
				var strGrouping = '';
				if (axis.Grouping != undefined) {
					strGrouping += '{';
					strGrouping += '"GroupByYear":' + (axis.Grouping.GroupByYear ? "true" : "false");
					strGrouping += ',';
					strGrouping += '"YearTitle":"' + axis.Grouping.YearTitle + '"';
					strGrouping += ',';
					strGrouping += '"GroupBySemester":' + (axis.Grouping.GroupBySemester ? "true" : "false");
					strGrouping += ',';
					strGrouping += '"SemesterTitle":"' + axis.Grouping.SemesterTitle + '"';
					strGrouping += ',';
					strGrouping += '"GroupByQuarter":' + (axis.Grouping.GroupByQuarter ? "true" : "false");
					strGrouping += ',';
					strGrouping += '"QuarterTitle":"' + axis.Grouping.QuarterTitle + '"';
					strGrouping += ',';
					strGrouping += '"GroupByMonth":' + (axis.Grouping.GroupByMonth ? "true" : "false");
					strGrouping += ',';
					strGrouping += '"MonthTitle":"' + axis.Grouping.MonthTitle + '"';
					strGrouping += ',';
					strGrouping += '"GroupByDayOfWeek":' + (axis.Grouping.GroupByDayOfWeek ? "true" : "false");
					strGrouping += ',';
					strGrouping += '"DayOfWeekTitle":"' + axis.Grouping.DayOfWeekTitle + '"';
					strGrouping += ',';
					strGrouping += '"HideValue":' + (axis.Grouping.HideValue ? "true" : "false");
					strGrouping += '}';
					strGrouping = '"Grouping":' + strGrouping;
				}
				return strGrouping;
			}

			function SdtWithValuesJSON(sdtName, actualType, typeWithValues, values, encodevalues) {
				var strAux = '';
				if (actualType != '') {
					strAux += '"' + sdtName + '":';
					strAux += '{';
					strAux += '"Type":"' + actualType + '"';
					strValues = "";
					if (actualType == typeWithValues) {
						existValues = false;
						for (j = 0; values[j] != undefined; j++) {
							existValues = true;
							strValues += (strValues != '' ? ',' : '');
							if (encodevalues) strValues += '"' + encodeURIComponent(values[j]) + '"';
							else strValues += '"' + values[j] + '"';
						}
						if (existValues) strValues = ',' + '"Values":[' + strValues + ']';
					}
					strAux += strValues;
					strAux += '}';
				}
				return strAux;
			}

			function RuntimeParametersJSON(qViewer) {
				var strParameters = '';
				var existParameters = false;

				if (qViewer.Object) {
					var array = eval(qViewer.Object);
					for (i = 2; i < array.length; i++) {
						existParameters = true;
						strParameters += (strParameters != '' ? ',' : '');
						strParameters += '{';
						strParameters += '"Value":"' + encodeURIComponent(array[i]) + '"';
						strParameters += '}';
					}
				}
				else {
					for (i = 0; qViewer.Parameters[i] != undefined; i++) {
						existParameters = true;
						strParameters += (strParameters != '' ? ',' : '');
						strParameters += '{';
						strParameters += '"Name":"' + qViewer.Parameters[i].Name + '"';
						strParameters += ',';
						strParameters += '"Value":"' + encodeURIComponent(qViewer.Parameters[i].Value) + '"';
						strParameters += '}';
					}
				}
				if (existParameters) strParameters = '"RuntimeParameters":[' + strParameters + ']';
				return strParameters;
			}

			function ExpandCollapseJSON(ExpandCollapse) {
				var strExpandCollapse = '';
				var existExpandCollapse = false;
				for (var i = 0; ExpandCollapse[i] != undefined; i++) {
					existExpandCollapse = true;
					strExpandCollapse += (strExpandCollapse != '' ? ',' : '');
					strExpandCollapse += '{';
					strExpandCollapse += '"DataField":"' + ExpandCollapse[i].DataField + '"';
					strExpandCollapse += ',';
					strExpandCollapse += '"NullExpanded":' + ExpandCollapse[i].NullExpanded;
					strExpandedValues = "";
					existValues = false;
					for (var j = 0; ExpandCollapse[i].NotNullValues.Expanded[j] != undefined; j++) {
						existValues = true;
						strExpandedValues += (strExpandedValues != '' ? ',' : '');
						strExpandedValues += '"' + encodeURIComponent(ExpandCollapse[i].NotNullValues.Expanded[j]) + '"';
					}
					if (existValues) strExpandedValues = ',' + '"Expanded":[' + strExpandedValues + ']';
					strCollapsedValues = "";
					existValues = false;
					for (var j = 0; ExpandCollapse[i].NotNullValues.Collapsed[j] != undefined; j++) {
						existValues = true;
						strCollapsedValues += (strCollapsedValues != '' ? ',' : '');
						strCollapsedValues += '"' + encodeURIComponent(ExpandCollapse[i].NotNullValues.Collapsed[j]) + '"';
					}
					if (existValues) strCollapsedValues = ',' + '"Collapsed":[' + strCollapsedValues + ']';
					strExpandCollapse += ',';
					strExpandCollapse += '"NotNullValues":{"DefaultAction":"' + ExpandCollapse[i].NotNullValues.DefaultAction + '"' + strExpandedValues + strCollapsedValues + '}';
					strExpandCollapse += '}';
				}
				if (existExpandCollapse) strExpandCollapse = '"ExpandCollapse":[' + strExpandCollapse + ']';
				return strExpandCollapse;
			}

			function FiltersJSON(Filters) {
				var strFilters = '';
				var existFilters = false;
				for (i = 0; Filters[i] != undefined; i++) {
					existFilters = true;
					strFilters += (strFilters != '' ? ',' : '');
					strFilters += '{';
					strFilters += '"DataField":"' + Filters[i].DataField + '"';
					strFilters += ',';
					strFilters += '"NullIncluded":' + Filters[i].NullIncluded;
					strIncludedValues = "";
					existValues = false;
					for (j = 0; Filters[i].NotNullValues.Included[j] != undefined; j++) {
						existValues = true;
						strIncludedValues += (strIncludedValues != '' ? ',' : '');
						strIncludedValues += '"' + encodeURIComponent(Filters[i].NotNullValues.Included[j]) + '"';
					}
					if (existValues) strIncludedValues = ',' + '"Included":[' + strIncludedValues + ']';
					strExcludedValues = "";
					existValues = false;
					for (j = 0; Filters[i].NotNullValues.Excluded[j] != undefined; j++) {
						existValues = true;
						strExcludedValues += (strExcludedValues != '' ? ',' : '');
						strExcludedValues += '"' + encodeURIComponent(Filters[i].NotNullValues.Excluded[j]) + '"';
					}
					if (existValues) strExcludedValues = ',' + '"Excluded":[' + strExcludedValues + ']';
					strFilters += ',';
					strFilters += '"NotNullValues":{"DefaultAction":"' + Filters[i].NotNullValues.DefaultAction + '"' + strIncludedValues + strExcludedValues + '}';
					strFilters += '}';
				}
				if (existFilters) strFilters = '"Filters":[' + strFilters + ']';
				return strFilters;
			}

			function AxesInfoJSON(AxesInfo) {
				var strAxesInfo = '';
				var existAxesInfo = false;
				for (var i = 0; AxesInfo[i] != undefined; i++) {
					existAxesInfo = true;
					strAxesInfo += (strAxesInfo != '' ? ',' : '');
					strAxesInfo += '{';
					strAxesInfo += '"DataField":"' + AxesInfo[i].DataField + '"';
					strAxesInfo += ',';
					strAxesInfo += '"Axis":{"Type":"' + AxesInfo[i].Axis.Type + '","Position":' + AxesInfo[i].Axis.Position + '}';
					strAxesInfo += ',';
					strAxesInfo += '"Order":"' + AxesInfo[i].Order + '"';
					strAxesInfo += ',';
					strAxesInfo += '"Subtotals":' + AxesInfo[i].Subtotals;
					strAxesInfo += '}';
				}
				if (existAxesInfo) strAxesInfo = '"AxesInfo":[' + strAxesInfo + ']';
				return strAxesInfo;
			}

			function DataInfoJSON(DataInfo) {
				var strDataInfo = '';
				var existDataInfo = false;
				for (var i = 0; DataInfo[i] != undefined; i++) {
					existDataInfo = true;
					strDataInfo += (strDataInfo != '' ? ',' : '');
					strDataInfo += '{';
					strDataInfo += '"DataField":"' + DataInfo[i].DataField + '"';
					strDataInfo += ',';
					strDataInfo += '"Axis":{"Type":"' + DataInfo[i].Axis.Type + '","Position":' + DataInfo[i].Axis.Position + '}';
					strDataInfo += '}';
				}
				if (existDataInfo) strDataInfo = '"DataInfo":[' + strDataInfo + ']';
				return strDataInfo;
			}

			function OrderJSON(DataField, Type) {
				return '{"DataField":"' + DataField + '","Type":"' + Type + '"}';
			}

			function RecordsetCacheInfoJSON(qViewer) {
				if (qViewer.UseRecordsetCache)
					return '{"ActualKey":"' + qViewer.RecordsetCache.ActualKey + '","OldKey":"' + qViewer.RecordsetCache.OldKey + '","MinutesToKeep":' + qViewer.MinutesToKeepInRecordsetCache + ',"MaximumSize":' + qViewer.MaximumCacheSize + '}';
				else
					return '{"ActualKey":"","OldKey":"","MinutesToKeep":0,"MaximumSize":0}';
			}

			function getObjectBasicInfo(qViewer) {
				var str = "";
				str += (qViewer.ParentObject.PackageName != '' ? '"ApplicationNamespace":"' + qViewer.ParentObject.PackageName + '"' + ',' : '');
				if (qViewer.Object) {
					var array = eval(qViewer.Object);
					str += '"ObjectName":"' + array[1].replace(/\\/g, ".") + '"';
				}
				else {
					str += '"ObjectName":"' + qViewer.ObjectName + '"';
					str += ',';
					str += '"Alt_ObjectType":"' + qViewer.ObjectType + '"';
					str += ',';
					str += '"Alt_ObjectId":' + qViewer.ObjectId;
				}
				return str;
			}

			return {

				DefaultOutput: function (qViewer) {
					var str = "";
					str += '{';
					str += getObjectBasicInfo(qViewer);
					str += (qViewer.ObjectInfo != '' ? ',' + '"ObjectInfo":' + qViewer.ObjectInfo : '');
					str += '}';
					return "Data=" + encodeURIComponent(str);
				},

				RecordsetCacheKey: function () {
					return "";
				},

				Metadata: function (qViewer) {
					var str = "";
					var runtimeParametersJSON = RuntimeParametersJSON(qViewer);
					var runtimeFieldsJSON = RuntimeFieldsJSON(qViewer, true);
					str += '{';
					str += getObjectBasicInfo(qViewer);
					str += (qViewer.QueryInfo != '' ? ',' + '"QueryInfo":' + qViewer.QueryInfo : '');
					str += (qViewer.AppSettings != '' ? ',' + '"AppSettings":' + qViewer.AppSettings : '');
					str += (runtimeParametersJSON != '' ? ',' + runtimeParametersJSON : '');
					str += (runtimeFieldsJSON != '' ? ',' + runtimeFieldsJSON : '');
					str += ',';
					str += '"TableType":"' + qViewer.RealType + '"';
					str += ',';
					str += '"AllowAxesOrderChange":' + qViewer.AllowChangeAxesOrder;
					str += ',';
					str += '"RememberLayout":' + qViewer.RememberLayout;
					str += ',';
					str += '"ShowDataLabelsIn":"' + qViewer.ShowDataLabelsIn + '"';
					str += ',';
					str += '"ShowAxesSelectors":"' + qViewer.ShowAxesSelectors + '"';
					str += ',';
					str += '"RecordsetCacheInfo":' + RecordsetCacheInfoJSON(qViewer);
					str += ',';
					str += '"ReturnSampleData":' + qViewer.ReturnSampleData;
					str += '}';
					return "Data=" + encodeURIComponent(str);
				},

				Data: function (qViewer) {
					var str = "";
					var runtimeParametersJSON = RuntimeParametersJSON(qViewer);
					var runtimeFieldsJSON = RuntimeFieldsJSON(qViewer, true);
					str += '{';
					str += getObjectBasicInfo(qViewer);
					str += (qViewer.QueryInfo != '' ? ',' + '"QueryInfo":' + qViewer.QueryInfo : '');
					str += (qViewer.AppSettings != '' ? ',' + '"AppSettings":' + qViewer.AppSettings : '');
					str += (runtimeParametersJSON != '' ? ',' + runtimeParametersJSON : '');
					str += (runtimeFieldsJSON != '' ? ',' + runtimeFieldsJSON : '');
					str += ',';
					str += '"TableType":"' + qViewer.RealType + '"';
					str += ',';
					str += '"SortAscendingForced":' + SortAscendingForced(qViewer);
					str += ',';
					str += '"AllowAxesOrderChange":' + qViewer.AllowChangeAxesOrder;
					str += ',';
					str += '"RecordsetCacheInfo":' + RecordsetCacheInfoJSON(qViewer);
					str += ',';
					str += '"ReturnSampleData":' + qViewer.ReturnSampleData;
					str += '}';
					return "Data=" + encodeURIComponent(str);
				},

				AttributeValues: function (qViewer, DataField, PageNumber, PageSize, Filter) {
					var str = "";
					var runtimeParametersJSON = RuntimeParametersJSON(qViewer);
					var runtimeFieldsJSON = RuntimeFieldsJSON(qViewer, true);
					str += '{';
					str += getObjectBasicInfo(qViewer);
					str += ',';
					str += '"DataField":"' + DataField + '"';
					str += ',';
					str += '"PageNumber":' + PageNumber;
					str += ',';
					str += '"PageSize":' + PageSize;
					str += ',';
					str += '"Filter":"' + Filter + '"';
					str += (qViewer.QueryInfo != '' ? ',' + '"QueryInfo":' + qViewer.QueryInfo : '');
					str += (qViewer.AppSettings != '' ? ',' + '"AppSettings":' + qViewer.AppSettings : '');
					str += (runtimeParametersJSON != '' ? ',' + runtimeParametersJSON : '');
					str += (runtimeFieldsJSON != '' ? ',' + runtimeFieldsJSON : '');
					str += ',';
					str += '"TableType":"' + qViewer.RealType + '"';
					str += ',';
					str += '"AllowAxesOrderChange":' + qViewer.AllowChangeAxesOrder;
					str += ',';
					str += '"RecordsetCacheInfo":' + RecordsetCacheInfoJSON(qViewer);
					str += ',';
					str += '"ReturnSampleData":' + qViewer.ReturnSampleData;
					str += '}';
					return "Data=" + encodeURIComponent(str);
				},

				TablePageData: function (qViewer, PageNumber, PageSize, ReturnTotPages, DataFieldOrder, OrderType, Filters) {
					var str = "";
					var runtimeParametersJSON = RuntimeParametersJSON(qViewer);
					var runtimeFieldsJSON = RuntimeFieldsJSON(qViewer, true);
					var filtersJSON = FiltersJSON(Filters);
					str += '{';
					str += getObjectBasicInfo(qViewer);
					str += ',';
					str += '"PageNumber":' + PageNumber;
					str += ',';
					str += '"PageSize":' + (gx.lang.gxBoolean(qViewer.Paging) ? PageSize : 0);
					str += ',';
					str += '"ReturnTotPages":' + ReturnTotPages;
					str += ',';
					str += '"Order":' + OrderJSON(DataFieldOrder, OrderType);
					str += (filtersJSON != '' ? ',' + filtersJSON : '');
					str += (qViewer.QueryInfo != '' ? ',' + '"QueryInfo":' + qViewer.QueryInfo : '');
					str += (qViewer.AppSettings != '' ? ',' + '"AppSettings":' + qViewer.AppSettings : '');
					str += (runtimeParametersJSON != '' ? ',' + runtimeParametersJSON : '');
					str += (runtimeFieldsJSON != '' ? ',' + runtimeFieldsJSON : '');
					str += ',';
					str += '"AllowAxesOrderChange":' + qViewer.AllowChangeAxesOrder;
					str += ',';
					str += '"RecordsetCacheInfo":' + RecordsetCacheInfoJSON(qViewer);
					str += ',';
					str += '"ReturnSampleData":' + qViewer.ReturnSampleData;
					str += '}';
					return "Data=" + encodeURIComponent(str);
				},

				PivotTablePageData: function (qViewer, PageNumber, PageSize, ReturnTotPages, AxesInfo, DataInfo, Filters, ExpandCollapse, LayoutChanged) {
					var str = "";
					var runtimeParametersJSON = RuntimeParametersJSON(qViewer);
					var runtimeFieldsJSON = RuntimeFieldsJSON(qViewer, true);
					var axesInfoJSON = AxesInfoJSON(AxesInfo);
					var dataInfoJSON = DataInfoJSON(DataInfo);
					var filtersJSON = FiltersJSON(Filters);
					var expandCollapseJSON = ExpandCollapseJSON(ExpandCollapse);
					str += '{';
					str += getObjectBasicInfo(qViewer);
					str += ',';
					str += '"PageNumber":' + PageNumber;
					str += ',';
					str += '"PageSize":' + (gx.lang.gxBoolean(qViewer.Paging) ? PageSize : 0);
					str += ',';
					str += '"ReturnTotPages":' + ReturnTotPages;
					str += ',';
					str += '"ShowDataLabelsIn":"' + qViewer.ShowDataLabelsIn + '"';
					str += (axesInfoJSON != '' ? ',' + axesInfoJSON : '');
					str += (dataInfoJSON != '' ? ',' + dataInfoJSON : '');
					str += (filtersJSON != '' ? ',' + filtersJSON : '');
					str += (expandCollapseJSON != '' ? ',' + expandCollapseJSON : '');
					str += (qViewer.QueryInfo != '' ? ',' + '"QueryInfo":' + qViewer.QueryInfo : '');
					str += (qViewer.AppSettings != '' ? ',' + '"AppSettings":' + qViewer.AppSettings : '');
					str += (runtimeParametersJSON != '' ? ',' + runtimeParametersJSON : '');
					str += (runtimeFieldsJSON != '' ? ',' + runtimeFieldsJSON : '');
					str += ',';
					str += '"AllowAxesOrderChange":' + qViewer.AllowChangeAxesOrder;
					str += ',';
					str += '"RecordsetCacheInfo":' + RecordsetCacheInfoJSON(qViewer);
					str += ',';
					str += '"LayoutChanged":' + LayoutChanged;
					str += ',';
					str += '"ReturnSampleData":' + qViewer.ReturnSampleData;
					str += '}';
					return "Data=" + encodeURIComponent(str);
				},

				getQueryParameters: function (qViewer) {
					var str = "";
					str += '{';
					str += getObjectBasicInfo(qViewer);
					str += (qViewer.ObjectInfo != '' ? ',' + '"ObjectInfo":' + qViewer.ObjectInfo : '');
					str += '}';
					return "Data=" + encodeURIComponent(str);
				},

				_priv: {

					RuntimeParametersJSON: function (qViewer) {
						return RuntimeParametersJSON(qViewer)
					},

					RuntimeFieldsJSON: function (qViewer) {
						return RuntimeFieldsJSON(qViewer)
					},

					SdtWithValuesJSON: function (sdtName, actualType, typeWithValues, values, encodevalues) {
						return SdtWithValuesJSON(sdtName, actualType, typeWithValues, values, encodevalues);
					}

				}

			}

		})(),

		RuntimeParametersJSON: function (qViewer) {
			return this.postInfo._priv.RuntimeParametersJSON(qViewer);
		},

		RuntimeFieldsJSON: function (qViewer, encodevaluescollection) {
			return this.postInfo._priv.RuntimeFieldsJSON(qViewer, encodevaluescollection);
		},

		getXMLHttpRequest: function () {
			if (window.XMLHttpRequest) {
				return new window.XMLHttpRequest;
			} else {
				try {
					return new ActiveXObject("MSXML2.XMLHTTP.3.0");
				} catch (ex) {
					return null;
				}
			}
		},

		CallServerSync: function (qViewer, serviceUrlFn, postInfoFn, postInfoParms) {
			postInfoParms = postInfoParms || [];
			postInfoParms.unshift(qViewer);
			var src = serviceUrlFn.call(qv.services.url);
			var postInfo = postInfoFn.apply(qv.services.postInfo, postInfoParms);
			var xmlHttp = qv.services.getXMLHttpRequest();
			xmlHttp.open("POST", src, false); // sync
			xmlHttp.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
			xmlHttp.send(postInfo);
			return xmlHttp.responseText;
		},

		createAsyncServerCallFn: function (qViewer, serviceUrlFn, postInfoFn, externalQueryMember, responsePreProcessFn) {
			return function (callback, postInfoParms) {
				postInfoParms = postInfoParms || [];
				postInfoParms.unshift(qViewer);
				var responseFn = function (response) {
					if (responsePreProcessFn && qViewer.RealType != "Card") {
						response = responsePreProcessFn.call(qv.util.css, response);
					}
					callback(response, qViewer);
				};
				if (!gx.lang.gxBoolean(qViewer.IsExternalQuery)) {
					var src = serviceUrlFn.call(qv.services.url)
					var	postInfo = postInfoFn.apply(qv.services.postInfo, postInfoParms)
					var	xmlHttp = qv.services.getXMLHttpRequest()
					var	responseHandler = function () {
							if (xmlHttp.readyState == STATE_DONE && xmlHttp.status == STATUS_OK) {
								responseFn(xmlHttp.responseText);
							}
						};
					if (gx.util.browser.isIE())
						xmlHttp.onreadystatechange = responseHandler;
					else
						xmlHttp.onload = responseHandler;
					xmlHttp.open("POST", src); // async
					xmlHttp.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
					xmlHttp.send(postInfo);
				}
				else
					responseFn(qViewer.ExternalQueryResultObj()[externalQueryMember]);
			}
		},

		parseRecordsetCacheKeyXML: function (qViewer) {
			if (qViewer.xml.recordsetCacheKey != "") {
				qViewer.RecordsetCache = qViewer.RecordsetCache || {};
				qViewer.RecordsetCache.OldKey = (qViewer.RecordsetCache.ActualKey ? qViewer.RecordsetCache.ActualKey : "");
				qViewer.RecordsetCache.ActualKey = qViewer.xml.recordsetCacheKey;	// Es un texto plano, no un XML que haya que parsear
			}
		},

		parseDataXML: function (qViewer) {
			if (qViewer.xml.data != "") {
				var xmlDoc = qv.util.dom.xmlDocument(qViewer.xml.data);
				var rootElement = qv.util.dom.getSingleElementByTagName(xmlDoc, "Recordset");
				qViewer.Data = qViewer.Data || {};
				var rows;
				if (!gx.util.browser.isIE()) {
					rows = qv.util.dom.getMultipleElementsByTagName(rootElement, "Record");
				} else {
					rows = qv.util.dom.getMultipleElementsByTagName(qv.util.dom.getSingleElementByTagName(rootElement, "Page"), "Record");
				}
				qViewer.Data.Rows = [];
				for (var i = 0; i < rows.length; i++) {
					var row = {};
					for (var j = 0; j < rows[i].childNodes.length; j++) {
						var node = rows[i].childNodes[j];
						if (node.nodeType == 1) {
							var name = node.nodeName;
							var value = (node.childNodes.length == 1 ? node.childNodes[0].nodeValue : "");
							row[name] = value;
						}
					}
					qViewer.Data.Rows.push(row);
				}
			}
		},

		parseMetadataXML: function (qViewer) {

			function translateStyleOperator(op1, op2) {
				if (op1 == "greaterequal" && op2 == "lessequal")
					return "IN";
				else
					switch (op1) {
						case "equal":
							return "EQ";
						case "less":
							return "LT";
						case "greater":
							return "GT";
						case "lessequal":
							return "LE";
						case "greaterequal":
							return "GE";
						case "notequal":
							return "NE";
					}
			}

			function ToAxisType(axisType) {
				switch (axisType) {
					case "rows":
						return "Rows";
					case "columns":
						return "Columns";
					case "filters":
						return "Pages";
					case "data":
						return "Data";
					case "hidden":
						return "Hidden";
				}
			}

			function getValuesGroup(parentElement, groupTag, valueTag, searchTotalValue) {
				var obj = {};
				var groupElement = qv.util.dom.getSingleElementByTagName(parentElement, groupTag);
				if (groupElement != null) {
					obj.GroupFound = true;
					obj.TotalValueFound = false;
					var values = qv.util.dom.getMultipleElementsByTagName(groupElement, valueTag);
					obj.Values = [];
					for (var i = 0; i < values.length; i++) {
						var value = (values[i].firstChild != null ? values[i].firstChild.nodeValue : "");
						if (value == "TOTAL" && searchTotalValue)
							obj.TotalValueFound = true;
						else
							obj.Values.push(value);
					}
				}
				else
					obj.GroupFound = false;
				return obj;
			}

			function removeCSSReplaceMarker(style) {
				var replaceMarker = "gxpl_cssReplace(";
				if (style.indexOf(replaceMarker) == 0) {	// El style es en realidad el nombre de una clase
					var posIni = style.indexOf(replaceMarker);
					var posFin = style.indexOf(")", posIni);
					style = style.substring(posIni + replaceMarker.length, posFin);
				}
				return style;
			}

			function getValuesStyles(parentElement) {
				var valuesStylesElements;
				var parentElement2 = qv.util.dom.getSingleElementByTagName(parentElement, "formatValues");
				if (parentElement2 != null)
					valuesStylesElements = qv.util.dom.getMultipleElementsByTagName(parentElement2, "value");
				else
					valuesStylesElements = [];
				var ValuesStyles = []
				for (var i = 0; i < valuesStylesElements.length; i++) {
					var valueStyle = {};
					valueStyle.Value = qv.util.trim(valuesStylesElements[i].firstChild != null ? valuesStylesElements[i].firstChild.nodeValue : "");
					valueStyle.StyleOrClass = removeCSSReplaceMarker(valuesStylesElements[i].getAttribute("format"));
					valueStyle.ApplyToRowOrColumn = valuesStylesElements[i].getAttribute("recursive") == "yes";
					ValuesStyles.push(valueStyle);
				}
				return ValuesStyles;
			}

			function getConditionalStyles(parentElement) {
				var conditionalStylesElements;
				var parentElement2 = qv.util.dom.getSingleElementByTagName(parentElement, "conditionalFormats");
				if (parentElement2 != null)
					conditionalStylesElements = qv.util.dom.getMultipleElementsByTagName(parentElement2, "rule");
				else
					conditionalStylesElements = [];
				var ConditionalStyles = []
				for (var i = 0; i < conditionalStylesElements.length; i++) {
					var conditionalStyle = {};
					conditionalStyle.Operator = translateStyleOperator(conditionalStylesElements[i].getAttribute("op1"), conditionalStylesElements[i].getAttribute("op2"));
					conditionalStyle.Value1 = parseFloat(conditionalStylesElements[i].getAttribute("value1"));
					if (conditionalStyle.Operator == "IN")
						conditionalStyle.Value2 = parseFloat(conditionalStylesElements[i].getAttribute("value2"));
					conditionalStyle.StyleOrClass = removeCSSReplaceMarker(conditionalStylesElements[i].getAttribute("format"));
					ConditionalStyles.push(conditionalStyle);
				}
				return ConditionalStyles;
			}

			if (qViewer.xml.metadata != "") {
				var xmlDoc = qv.util.dom.xmlDocument(qViewer.xml.metadata);
				var rootElement = qv.util.dom.getSingleElementByTagName(xmlDoc, "OLAPCube");
				qViewer.Metadata = qViewer.Metadata || {};
				// Obtengo propiedades generales
				qViewer.Metadata.TextForNullValues = rootElement.getAttribute("textForNullValues");
				// Obtengo los ejes
				var axes = qv.util.dom.getMultipleElementsByTagName(rootElement, "OLAPDimension");
				qViewer.Metadata.Axes = [];
				for (var i = 0; i < axes.length; i++) {
					var axis = {};
					axis.Name = axes[i].getAttribute("name");
					axis.Title = axes[i].getAttribute("displayName");
					axis.DataField = axes[i].getAttribute("dataField");
					axis.DataType = axes[i].getAttribute("dataType");
					axis.AxisType = ToAxisType(axes[i].getAttribute("defaultPosition"));
					axis.Picture = axes[i].getAttribute("picture");
					if (axis.Picture == "")
						switch (axis.DataType) {
							case "integer":
								axis.Picture = "ZZZZZZZZZZZZZZ9";
								break;
							case "real":
								axis.Picture = "ZZZZZZZZZZZZZZ9.99";
								break;
							case "date":
								axis.Picture = "99/99/9999";
								break;
							case "datetime":
								axis.Picture = "99/99/9999 99:99:99";
								break;
						}
					var validPositions = axes[i].getAttribute("validPositions");
					axis.CanDragToPages = validPositions.indexOf("filters") >= 0;
					axis.Style = axes[i].getAttribute("format");
					var includeGroup = getValuesGroup(axes[i], "include", "value", true);
					var excludeGroup = getValuesGroup(axes[i], "exclude", "value", true);
					var expandGroup = getValuesGroup(axes[i], "expand", "value", false);
					var customOrderGroup = getValuesGroup(axes[i], "customOrder", "Value", false);
					if (axes[i].getAttribute("summarize") == "no")
						axis.Subtotals = "No";
					else {
						if (excludeGroup.GroupFound && excludeGroup.TotalValueFound)
							axis.Subtotals = "Hidden";
						else
							axis.Subtotals = "Yes";
					}
					axis.Filter = {};
					if (!includeGroup.GroupFound && !excludeGroup.GroupFound)
						axis.Filter.Type = "ShowAllValues";
					else if (!includeGroup.GroupFound && excludeGroup.GroupFound && excludeGroup.Values.length == 0 & excludeGroup.TotalValueFound)
						axis.Filter.Type = "ShowAllValues";
					else if (includeGroup.GroupFound && !excludeGroup.GroupFound && includeGroup.Values.length == 0)
						axis.Filter.Type = "HideAllValues";
					else {
						axis.Filter.Type = "ShowSomeValues";
						axis.Filter.Values = includeGroup.Values;
					}
					axis.ExpandCollapse = {};
					if (!expandGroup.GroupFound)
						axis.ExpandCollapse.Type = "ExpandAllValues";
					else if (expandGroup.GroupFound && expandGroup.Values.length == 0)
						axis.ExpandCollapse.Type = "CollapseAllValues";
					else {
						axis.ExpandCollapse.Type = "ExpandSomeValues";
						axis.ExpandCollapse.Values = expandGroup.Values;
					}
					axis.Order = {};
					var order = axes[i].getAttribute("order");
					if (order == null)
						axis.Order.Type = "None";
					else {
						axis.Order.Type = qv.util.capitalize(order);
						if (axis.Order.Type == "Custom")
							axis.Order.Values = customOrderGroup.Values;
					}
					axis.ValuesStyles = getValuesStyles(axes[i]);
					qViewer.Metadata.Axes.push(axis);
				}
				// Obtengo los datos
				var data = qv.util.dom.getMultipleElementsByTagName(rootElement, "OLAPMeasure");
				qViewer.Metadata.Data = [];
				for (var i = 0; i < data.length; i++) {
					var datum = {};
					datum.Name = data[i].getAttribute("name");
					datum.Title = data[i].getAttribute("displayName");
					datum.DataField = data[i].getAttribute("dataField");
					datum.Aggregation = data[i].getAttribute("aggregation");
					datum.DataType = data[i].getAttribute("dataType");
					datum.AxisType = ToAxisType(data[i].getAttribute("defaultPosition"));
					datum.Picture = data[i].getAttribute("picture");
					if (datum.Picture == "")
						datum.Picture = datum.DataType == "integer" ? "ZZZZZZZZZZZZZZ9" : "ZZZZZZZZZZZZZZ9.99";
					datum.Aggregation = qv.util.capitalize(datum.Aggregation);
					datum.TargetValue = parseFloat(data[i].getAttribute("targetValue"));
					datum.MaximumValue = parseFloat(data[i].getAttribute("maximumValue"));
					datum.Style = data[i].getAttribute("format");
					if (datum.TargetValue <= 0)
						datum.TargetValue = 100;
					if (datum.MaximumValue <= 0)
						datum.MaximumValue = 100;
					datum.ConditionalStyles = getConditionalStyles(data[i]);
					qViewer.Metadata.Data.push(datum);
				}
			}
		},

		GetDataIfNeeded: function (qViewer, callbackFn) {
			qViewer.Data = qViewer.Data || {};
			qViewer.Data.LastServiceCallKey = qViewer.Data.LastServiceCallKey || {};
			if (DataChanged(qViewer, qViewer.Data.LastServiceCallKey) || gx.lang.gxBoolean(qViewer.IsExternalQuery))
				qViewer.calculatePivottableData(callbackFn);
			else
				callbackFn(qViewer.xml.data, qViewer);
		},

		GetMetadataIfNeeded: function (qViewer, callbackFn) {
			qViewer.Metadata = qViewer.Metadata || {};
			qViewer.Metadata.LastServiceCallKey = qViewer.Metadata.LastServiceCallKey || {};
			if (MetadataChanged(qViewer, qViewer.Metadata.LastServiceCallKey) || gx.lang.gxBoolean(qViewer.IsExternalQuery))
				qViewer.calculatePivottableMetadata(callbackFn);
			else
				callbackFn(qViewer.xml.metadata, qViewer);
		},
		
		GetRecordsetCacheKeyIfNeeded: function (qViewer, callbackFn) {
			if (qViewer.UseRecordsetCache) {
				qViewer.RecordsetCache = qViewer.RecordsetCache || {};
				qViewer.RecordsetCache.LastServiceCallKey = qViewer.RecordsetCache.LastServiceCallKey || {};
				if (DataChanged(qViewer, qViewer.RecordsetCache.LastServiceCallKey))
					qViewer.getRecordsetCacheKey(callbackFn);
				else
					callbackFn(qViewer.xml.recordsetCacheKey, qViewer);
			}
			else
				callbackFn("", qViewer);
		},

		IsObjectSet: function (qViewer) {
			return qViewer.Object || qViewer.ObjectName != "" || (qViewer.ObjectType != "" && qViewer.ObjectId != 0);
		}

	}

})()

/* END OF FILE - ..\Sources\Services.src.js - */
/* START OF FILE - ..\Sources\PivotTable.src.js - */
qv.pivot = (function () {

	function renderPivotServices(qViewer, xml1, xml2, time1, time2) {
		var xml1Encoded = gx.html.encode(xml1, true, true);
		var xml2Encoded = gx.html.encode(xml2, true, true);
		qViewer.AdjustSize();
		var buffer1 = "<div style=\"overflow:auto; border-right: silver thin solid; border-top: silver thin solid; border-left: silver thin solid; border-bottom: silver thin solid; width: " + qViewer.Width + "px; height: " + parseInt(qViewer.Height) / 2 + "px" + "\">" + xml1Encoded + "</div>";
		buffer1 += "Time: " + time1 / 1000 + " seconds";
		var buffer2 = "<div style=\"overflow:auto; border-right: silver thin solid; border-top: silver thin solid; border-left: silver thin solid; border-bottom: silver thin solid; width: " + qViewer.Width + "px; height: " + parseInt(qViewer.Height) / 2 + "px" + "\">" + xml2Encoded + "</div>";
		buffer2 += "Time: " + time2 / 1000 + " seconds";
		qViewer.setHtml(buffer1 + buffer2);
	}

	function renderPivotTable(qViewer) {
		var qvClass = qv.util.GetContainerControlClass(qViewer);
		if (qvClass != "")
			qv.util.SetUserControlClass(qViewer, qvClass);
		if (!qViewer.AutoResize) {
			qViewer.getContainerControl().style.height = gx.dom.addUnits(qViewer.Height);
			qViewer.getContainerControl().style.width = gx.dom.addUnits(qViewer.Width);
		}
		else {
			switch (qViewer.AutoResizeType) {
				case "Both":
					// do nothing
					break;
				case "Vertical":
					if (!gx.util.browser.isIE()) {
						qViewer.getContainerControl().style.width = gx.dom.addUnits(qViewer.Width);
					}
					break;
				case "Horizontal":
					qViewer.getContainerControl().style.height = gx.dom.addUnits(qViewer.Height);
					break;
			}
		}
		if ((!qViewer.AutoResize) || ((qViewer.AutoResize) && (qViewer.AutoResizeType == "Vertical") && (!gx.util.browser.isIE()))) {
			qViewer.getContainerControl().style.overflow = 'auto';
		}
		var page = qViewer.userControlId() + "_" + qViewer.ObjectName.replace(/,/g, "").replace(/\./g,"") + "_pivot_page"; //qViewer.ControlName +
		qViewer.pivotParams = {};
		qViewer.pivotParams.page = page;
		var content = qViewer.userControlId() + "_" + qViewer.ObjectName.replace(/,/g, "").replace(/\./g,"") + "_pivot_content"; //qViewer.ControlName
		qViewer.pivotParams.content = content;
		var chart = qViewer.userControlId() + "_" + qViewer.ObjectName.replace(/,/g, "").replace(/\./g,"") + "_pivot_chart"; //qViewer.ControlName
		qViewer.pivotParams.chart = chart;
		if (qViewer.RealType == "PivotTable") {
			var buff = '<div id="' + page + '"></div><div id="' + content + '"></div><div id="' + chart + '"></div>';
			document.getElementById(qViewer.ContainerName).innerHTML = buff.toString();
		} else {
			if (qViewer.RealType == "Table") {
				document.getElementById(qViewer.ContainerName).innerHTML = "";
			}
		}
		qViewer.pivotParams.container = qViewer.getContainerControl();
		qViewer.pivotParams.RealType = qViewer.RealType;
		qViewer.pivotParams.ObjectName = qViewer.ObjectName;
		qViewer.pivotParams.ControlName = qViewer.ControlName;
		qViewer.pivotParams.PageSize = ((qViewer.Paging) && (qViewer.Paging != "false")) ? qViewer.PageSize : undefined;
		qViewer.pivotParams.metadata = qViewer.xml.metadata;
		var data;
		if (qViewer.RealType == "Table")
			data = qViewer.ServerPagingForTable ? qViewer.xml.pageData : qViewer.xml.data;
		else
			data = qViewer.ServerPagingForPivotTable ? qViewer.xml.pageData : qViewer.xml.data;
		qViewer.pivotParams.data = data;
		qViewer.pivotParams.UcId = qViewer.userControlId();
		qViewer.pivotParams.ShrinkToFit = qViewer.ShrinkToFit;
		qViewer.pivotParams.DisableColumnSort = qViewer.DisableColumnSort;
		qViewer.pivotParams.RememberLayout = qViewer.RememberLayout;
		qViewer.pivotParams.ShowDataLabelsIn = qViewer.ShowDataLabelsIn;
		qViewer.pivotParams.ServerPaging = qViewer.ServerPagingForTable && (!gx.lang.gxBoolean(qViewer.IsExternalQuery));
		qViewer.pivotParams.ServerPagingPivot = qViewer.ServerPagingForPivotTable && (!gx.lang.gxBoolean(qViewer.IsExternalQuery));;
		qViewer.pivotParams.ServerPagingCacheSize = 0
		qViewer.pivotParams.UseRecordsetCache = qViewer.UseRecordsetCache;
		if (OAT.Loader != undefined) {
			renderJSPivot(qViewer.pivotParams, qv.collection, qViewer);
		} else {
			OAT.Loader.addListener(function () {
				renderJSPivot(qViewer.pivotParams, qv.collection, qViewer);
			});
		}
	}

	function callServiceGetPageDataForTable(qViewer, t1, t2) {
		qViewer.getPageDataForTable(function (resXML, qViewer) {
			qv.util.hideActivityIndicator(qViewer);
			var d3 = new Date();
			var t3 = d3.getTime();
			if (!qv.util.anyError(resXML) || qViewer.debugServices) {
				if (resXML != "")
					qViewer.xml.pageData = resXML;
				if (qViewer.debugServices)
					renderPivotServices(qViewer, qViewer.xml.metadata, qViewer.xml.pageData, t2 - t1, t3 - t2);
				else {
					renderPivotTable(qViewer);
				}
			} else {
				errMsg = qv.util.getErrorFromText(resXML);
				qv.util.renderError(qViewer, errMsg);
			}
		}, [1, qViewer.PageSize, true, "", "", []]);
	}

	function loadContextItems(Node) {
		var Items = [];
		if (Node != null) {
			var itemIndex = -1;
			for (var i = 0; i < Node.childNodes.length; i++) {
				if (Node.childNodes[i].nodeName == "ITEM") {
					itemIndex++;
					Items[itemIndex] = {};
					Items[itemIndex].Name = Node.childNodes[i].getAttribute("name");
					Items[itemIndex].Values = [];
					var valueIndex = -1;
					// Seek VALUES node
					var valuesNode = Node.childNodes[i]; // ITEM
					for (var j = 0; j < Node.childNodes[i].childNodes.length; j++)
						if (Node.childNodes[i].childNodes[j].nodeName == "VALUES") {
							valuesNode = Node.childNodes[i].childNodes[j];
							break;
						}
					// Seek VALUE nodes
					for (var j = 0; j < valuesNode.childNodes.length; j++)
						if (valuesNode.childNodes[j].nodeName == "VALUE") {
							valueIndex++;
							Items[itemIndex].Values[valueIndex] = (valuesNode.childNodes[j].firstChild != null ? valuesNode.childNodes[j].firstChild.nodeValue : "");
						}
				}
			}
		}
		return Items;
	}

	return {

		tryToRenderPivotTable: function (qViewer) {
			var errMsg = "";

			// Ejecuto el primer servicio y verifico que no haya habido error
			var d1 = new Date();
			var t1 = d1.getTime();

			qViewer.xml = qViewer.xml || {};

			if (qViewer.IntervalCheckChartSize != undefined)
				qViewer.IntervalCheckChartSize = clearInterval(qViewer.IntervalCheckChartSize);			// Elimino el intervalo seteado cuando estuvo configurado como Chart con Autoresize

			qv.services.GetRecordsetCacheKeyIfNeeded(qViewer, function (resText, qViewer) {				// Servicio GetRecordsetCacheKey
				var newRecordsetCacheKey = false;
				if (resText != qViewer.xml.recordsetCacheKey) {
					qViewer.xml.recordsetCacheKey = resText;
					newRecordsetCacheKey = true;
				}
				qv.util.hideActivityIndicator(qViewer);
				if (!qv.util.anyError(resText) || qViewer.debugServices) {
					if (newRecordsetCacheKey)
						qv.services.parseRecordsetCacheKeyXML(qViewer);

					qv.services.GetMetadataIfNeeded(qViewer, function (resText, qViewer) {				// Servicio GetMetadata
						var newMetadata = false;
						if (resText != qViewer.xml.metadata) {
							qViewer.xml.metadata = resText;
							newMetadata = true;
						}
						qv.util.hideActivityIndicator(qViewer);
						var d2 = new Date();
						var t2 = d2.getTime();
						if (!qv.util.anyError(resText) || qViewer.debugServices) {
							if (newMetadata)
								qv.services.parseMetadataXML(qViewer);
							if ((qViewer.ServerPagingForTable) && (qViewer.RealType == "Table") && (!gx.lang.gxBoolean(qViewer.IsExternalQuery))) {
								// Tabla con paginado en el server
								var previusStateSave = false;
								if (OAT.getStateWhenServingPaging) {
									previusStateSave = OAT.getStateWhenServingPaging(qViewer.userControlId() + '_' + qViewer.ObjectName, qViewer.ObjectName)
								}
								if ((!previusStateSave) || (!qViewer.RememberLayout)) {
										callServiceGetPageDataForTable(qViewer, t1, t2);
								} else {
									qv.util.hideActivityIndicator(qViewer);
									renderPivotTable(qViewer);
								}
							}
							else if ((qViewer.ServerPagingForPivotTable) && (qViewer.RealType == "PivotTable") && (!gx.lang.gxBoolean(qViewer.IsExternalQuery))) {
								// PivotTable con paginado en el server
								if (qViewer.debugServices) {
									qViewer.getPageDataForPivotTable(function (resXML, qViewer) {
										var d3 = new Date();
										var t3 = d3.getTime();
										qv.util.hideActivityIndicator(qViewer);
										if (!qv.util.anyError(resXML)) {
											if (resXML != "")
												qViewer.xml.pageData = resXML;
											renderPivotServices(qViewer, qViewer.xml.metadata, qViewer.xml.pageData, t2 - t1, t3 - t2);
										} else {
											errMsg = qv.util.getErrorFromText(resXML);
											qv.util.renderError(qViewer, errMsg);
										}
									}, [1, qViewer.PageSize, true, [], [], [], true]);
								} else {
									var previusStateSave = false;
									if (OAT.getStateWhenServingPaging) {
										previusStateSave = OAT.getStateWhenServingPaging(qViewer.userControlId() + '_' + qViewer.ObjectName, qViewer.ObjectName)
									}
									qv.util.hideActivityIndicator(qViewer);
									renderPivotTable(qViewer);
								}
							}
							else {
								// Paginado en el cliente
								qv.services.GetDataIfNeeded(qViewer, function (resText, qViewer) {				// Servicio GetData
									if (resText != qViewer.xml.data)
										qViewer.xml.data = resText;
									qv.util.hideActivityIndicator(qViewer);
									var d3 = new Date();
									var t3 = d3.getTime();
									if (!qv.util.anyError(resText) || qViewer.debugServices) {
										if (qViewer.debugServices)
											renderPivotServices(qViewer, qViewer.xml.metadata, qViewer.xml.data, t2 - t1, t3 - t2);
										else
											renderPivotTable(qViewer);
									} else {
										// Error en el servicio GetData
										errMsg = qv.util.getErrorFromText(resText);
										qv.util.renderError(qViewer, errMsg);
									}
								});
							}
						}
						else {
							// Error en el servicio GetMetadata
							errMsg = qv.util.getErrorFromText(resText);
							qv.util.renderError(qViewer, errMsg);
						}
					});

				}
				else {
					// Error en el servicio GetRecordsetCachekey
					errMsg = qv.util.getErrorFromText(resText);
					qv.util.renderError(qViewer, errMsg);
				}
			});

		},

		GetMetadataPivot: function (qViewer) {

			function MergeMetadatas(designtimeMetadata, runtimeMetadata) {

				var fields = [];
				var keys = qv.util.GetOrderedAxesKeys(runtimeMetadata);
				for (var i = 0; i < keys.length; i++) {
					var index = parseInt(keys[i].substr(5, 4));
					var runtimeField = runtimeMetadata[index];
					var designtimeField;
					var designtimeFieldCloned;
					for (var j = 0; j < designtimeMetadata.length; j++) {
						designtimeField = designtimeMetadata[j];
						if (designtimeField.Name == runtimeField.Name) {
							designtimeFieldCloned = qv.util.cloneObject(designtimeField);		// Clono para no perder los valores originales
							break;
						}
					}
					qv.util.MergeFields(designtimeFieldCloned, runtimeField);
					fields.push(designtimeFieldCloned);
				}
				return fields;

			}

			var designtimeMetadata = qv.util.GetDesigntimeMetadata(qViewer);
			if (designtimeMetadata.length > 0) {
				var xml = qViewer.oat_element.getMetadataXML();
				var runtimeMetadata = qv.pivot.GetRuntimeMetadata(xml, qViewer.RealType);
				return MergeMetadatas(designtimeMetadata, runtimeMetadata);
			}
			else
				return [];
		},

		GetRuntimeMetadata: function (xml, type) {

			function GetTypeValuesObject(parentNode, typeNodeName, includeNodeName, excludeTotalValue) {
				var nodeType = qv.util.dom.getValueNode(qv.util.dom.getSingleElementByTagName(parentNode, typeNodeName));
				var values = [];
				var parentNodeAux = qv.util.dom.getSingleElementByTagName(parentNode, includeNodeName);
				if (parentNodeAux != null) {
					var valueNodes = qv.util.dom.getMultipleElementsByTagName(parentNodeAux, "value");
					for (var j = 0; j < valueNodes.length; j++) {
						var value = qv.util.trim(qv.util.dom.getValueNode(valueNodes[j]));
						if (value != null && (value.toUpperCase() != "TOTAL" || !excludeTotalValue))
							values.push(value);
					}
				}
				return { Type: nodeType, Values: values };
			}

			var xmlDoc = qv.util.dom.xmlDocument(xml);
			var rootElement = qv.util.dom.getSingleElementByTagName(xmlDoc, "OLAPCube");
			var queryViewerAxes = [];
			// Obtengo los ejes
			var axes = qv.util.dom.getMultipleElementsByTagName(rootElement, "OLAPDimension");
			for (var i = 0; i < axes.length; i++) {
				var axis = {};
				var name = qv.util.dom.getValueNode(qv.util.dom.getSingleElementByTagName(axes[i], "name"));
				var hidden = qv.util.dom.getValueNode(qv.util.dom.getSingleElementByTagName(axes[i], "hidden"));
				var axisType = qv.util.dom.getValueNode(qv.util.dom.getSingleElementByTagName(axes[i], "defaultPosition"));
				var axisPosition = qv.util.dom.getValueNode(qv.util.dom.getSingleElementByTagName(axes[i], "axisOrder"));
				var summarize = qv.util.dom.getValueNode(qv.util.dom.getSingleElementByTagName(axes[i], "summarize"));
				var order = qv.util.dom.getValueNode(qv.util.dom.getSingleElementByTagName(axes[i], "order"));
				axis.Name = name;
				axis.AxisType = qv.util.FromRuntimeMetadata(hidden, true, axisType);
				axis.AxisPosition = axisPosition;
				axis.Order = qv.util.capitalize(order);
				if (type == "Table") {
					axis.Filter = GetTypeValuesObject(axes[i], "", "include", true);
					axis.Filter.Type = "ShowSomeValues";
				}
				else {
					axis.Subtotals = summarize == "no" ? "No" : "Yes";
					axis.Filter = GetTypeValuesObject(axes[i], "filterType", "include", true);
					axis.ExpandCollapse = GetTypeValuesObject(axes[i], "collapseType", "includeExpand", false);
				}
				queryViewerAxes.push(axis);
			}
			if (type != "Table") {
				// Obtengo los datos
				var data = qv.util.dom.getMultipleElementsByTagName(rootElement, "OLAPMeasure");
				for (var i = 0; i < data.length; i++) {
					var datum = {};
					var name = qv.util.dom.getValueNode(qv.util.dom.getSingleElementByTagName(data[i], "name"));
					var hidden = qv.util.dom.getValueNode(qv.util.dom.getSingleElementByTagName(data[i], "hidden"));
					var axisPosition = (i + 1).toString();
					datum.Name = name;
					datum.AxisType = qv.util.FromRuntimeMetadata(hidden, false, null);
					datum.AxisPosition = axisPosition;
					queryViewerAxes.push(datum);
				}
			}
			return queryViewerAxes;
		},

		GetDataPivot: function (qViewer) {
			var result = qViewer.oat_element.getDataXML()
			return result;
		},

		GetFilteredDataPivot: function (qViewer) {
			var result = qViewer.oat_element.getFilteredDataXML()
			return result;
		},

		onOAT_PIVOTDragAndDropEvent: function (qViewer, data) {
			var position;
			if (qViewer.RealType == "PivotTable") {
				if (IsQueryObjectPreview())
					window.external.SendText(qViewer.ControlName, data);
				if (qViewer.DragAndDrop) {
					var xml_doc = qv.util.dom.xmlDocument(data);
					var Node = qv.util.dom.selectXPathNode(xml_doc, "/DATA");
					qViewer.DragAndDropData.Name = Node.getAttribute("name");
					position = Node.getAttribute("position");
					qViewer.DragAndDropData.Axis = (position == "rows" ? "Row" : (position == "columns" ? "Column" : "Page"));
					qViewer.DragAndDrop();
				}
			}
		},

		onItemClickEvent: function (qViewer, data, isDoubleClick) {
			var location;
			var eventData;
			if ((qViewer.ItemClick && !isDoubleClick) || (qViewer.ItemDoubleClick && isDoubleClick)) {
				eventData = (isDoubleClick ? eventData = qViewer.ItemDoubleClickData : qViewer.ItemClickData);
				var xml_doc = qv.util.dom.xmlDocument(data);
				var Node1 = qv.util.dom.selectXPathNode(xml_doc, "/DATA/ITEM");
				var Node2 = qv.util.dom.selectXPathNode(xml_doc, "/DATA/CONTEXT/RELATED");
				var Node3 = qv.util.dom.selectXPathNode(xml_doc, "/DATA/CONTEXT/FILTERS");
				eventData.Name = Node1.getAttribute("name");
				location = Node1.getAttribute("location");
				eventData.Axis = (location == "rows" ? "Row" : (location == "columns" ? "Column" : (location == "pages" ? "Page" : "Data")));
				eventData.Value = (Node1.firstChild != null ? Node1.firstChild.nodeValue : "");
				eventData.Context = loadContextItems(Node2);
				eventData.Filters = loadContextItems(Node3);
				if (isDoubleClick)
					qViewer.ItemDoubleClick();
				else
					qViewer.ItemClick();
			}
		},

		onItemExpandCollapseEvent: function (qViewer, data, isCollapse) {
			var location;
			var eventData;
			if (IsQueryObjectPreview())
				window.external.SendText(qViewer.ControlName, data);
			if ((qViewer.ItemExpand && !isCollapse) || (qViewer.ItemCollapse && isCollapse)) {
				eventData = (isCollapse ? eventData = qViewer.ItemCollapseData : qViewer.ItemExpandData);
				var xml_doc = qv.util.dom.xmlDocument(data);
				var Node1 = qv.util.dom.selectXPathNode(xml_doc, "/DATA/ITEM");
				var Node2 = qv.util.dom.selectXPathNode(xml_doc, "/DATA/CONTEXT/EXPANDEDVALUES");
				eventData.Name = Node1.getAttribute("name");
				eventData.Value = Node1.firstChild.nodeValue;
				eventData.ExpandedValues = [];
				var valueIndex = -1;
				for (var i = 0; i < Node2.childNodes.length; i++)
					if (Node2.childNodes[i].nodeName == "VALUE") {
						valueIndex++;
						eventData.ExpandedValues[valueIndex] = Node2.childNodes[i].firstChild.nodeValue;
					}
				if (isCollapse)
					qViewer.ItemCollapse();
				else
					qViewer.ItemExpand();
			}
		}

	}

})()
/* END OF FILE - ..\Sources\PivotTable.src.js - */
/* START OF FILE - ..\Sources\Chart.src.js - */
var HCChart;
var _highChartsDrawPointsWrapped;
var HIGHCHARTS_COLOR_PREFIX = "highcharts-color-";
var HIGHCHARTS_MAX_COLORS = 36;
var HIGHCHARTS_CUSTOM_COLOR = [];

qv.chart = (function () {

	function IsTimelineChart(qViewer) {
		return qViewer.RealChartType == "Timeline" || qViewer.RealChartType == "SmoothTimeline" || qViewer.RealChartType == "StepTimeline";
	}

	function IsDatetimeXAxis(qViewer) {
		return IsTimelineChart(qViewer) || (qViewer.RealChartType == "Sparkline" );
	}

	function IsStackedChart(qViewer) {
		return qViewer.RealChartType == "StackedColumn" || qViewer.RealChartType == "StackedColumn3D" || qViewer.RealChartType == "StackedColumn100" ||  qViewer.RealChartType == "StackedBar" ||  qViewer.RealChartType == "StackedBar100" ||  qViewer.RealChartType == "StackedArea" ||  qViewer.RealChartType == "StackedArea100" ||  qViewer.RealChartType == "StackedLine" ||  qViewer.RealChartType == "StackedLine100";
	}

	function IsCircularChart(qViewer) {
		return qViewer.RealChartType == "Pie" || qViewer.RealChartType == "Pie3D" || qViewer.RealChartType == "Doughnut" || qViewer.RealChartType == "Doughnut3D";
	}

	function IsFunnelChart(qViewer) {
		return qViewer.RealChartType == "Funnel" || qViewer.RealChartType == "Pyramid";
	}

	function IsPolarChart(qViewer) {
		return qViewer.RealChartType == "Radar" || qViewer.RealChartType == "FilledRadar" || qViewer.RealChartType == "PolarArea";
	}

	function IsSingleSerieChart(qViewer) {
		return IsCircularChart(qViewer) || IsFunnelChart(qViewer);
	}

	function IsCombinationChart(qViewer) {
		return (qViewer.RealChartType == "ColumnLine" || qViewer.RealChartType == "Column3DLine") && qViewer.Chart.Series.DataFields.length > 1 ;
	}

	function IsGaugeChart(qViewer) {
		return qViewer.RealChartType == "CircularGauge" || qViewer.RealChartType == "LinearGauge";
	}

	function IsAreaChart(qViewer) {
		return qViewer.RealChartType == "Area" || qViewer.RealChartType == "StackedArea" || qViewer.RealChartType == "StackedArea100" || qViewer.RealChartType == "SmoothArea"  || qViewer.RealChartType == "StepArea";
	}

	function IsLineChart(qViewer) {
		return qViewer.RealChartType == "Line" || qViewer.RealChartType == "StackedLine" || qViewer.RealChartType == "StackedLine100" || qViewer.RealChartType == "SmoothLine"  || qViewer.RealChartType == "StepLine" || qViewer.RealChartType == "Sparkline" || IsTimelineChart(qViewer);
	}

	function IsBarChart(qViewer) {
		return qViewer.RealChartType == "Bar" || qViewer.RealChartType == "StackedBar" || qViewer.RealChartType == "StackedBar100";
	}

	function HasYAxis(qViewer) {
		return !IsCircularChart(qViewer) && !IsFunnelChart(qViewer) && !IsGaugeChart(qViewer);
	}

	function IsSplittedChart(qViewer) {
		if (IsStackedChart(qViewer))
			return false;						// Para las gráficas Stacked no tiene sentido separar en varias gráficas pues dejan de apilarse las series
		else
			return (qViewer.PlotSeries == "InSeparateCharts" || IsSingleSerieChart(qViewer)) && qViewer.Chart.Series.DataFields.length > 1;	// Fuerzo gráficas separadas para este tipo de gráficas porque sino no se pueden dibujar
	}

	function NumberOfCharts(qViewer) {
		return IsSplittedChart(qViewer) ? qViewer.Chart.Series.DataFields.length : 1;
	}

	function splitChartContainer(qViewer) {
		var viewerId = qViewer.userControlId();
		if (IsTimelineChart(qViewer)) {
			var html = '';
			html += '<div id="' + optionsId(viewerId) + '" class="QVTimelineHeaderContainer" style="width:100%; height:' + TimelineHeaderHeight + 'px"></div>';
			html += '<div id="' + centerId(viewerId) + '" style="width:100%; height:calc(100% - ' + TimelineHeaderHeight + 'px - ' + TimelineFooterHeight + 'px)"></div>';
			html += '<div id="' + footerId(viewerId) + '" class="gx-qv-footer" style="width:100%; height:' + TimelineFooterHeight + 'px"></div>';
			qViewer.getContainerControl().innerHTML = html;
		}
		if (IsSplittedChart(qViewer)) {
			var html = '';
			var totDIVs = qViewer.Chart.Series.DataFields.length;
			var divHeight = parseInt(100 / totDIVs);
			var percentLeft = 100 % totDIVs;
			var container;
			var baseId;
			if (IsTimelineChart(qViewer)) {
				container = document.getElementById(centerId(viewerId));
				baseId = centerId(viewerId);
			}
			else {
				container = qViewer.getContainerControl();
				baseId = viewerId;
			}
			for (var i = 0; i < totDIVs; i++) {
				html += '<div id="' + baseId + "_chart" + i.toString() + '" style="width:100%;height:' + (divHeight + (i < percentLeft ? 1 : 0)).toString() + '%"></div>';
			}
			container.innerHTML = html;
		}
	}

	function getHoverPoints(qViewer, index) {
		var points = [];
		for (var i = 0; i < qViewer.Charts.length; i++) {
			for (var j = 0; j < qViewer.Charts[i].series.length; j++) {
				var point = qViewer.Charts[i].series[j].data[index];
				points.push(point);
			}
		}
		return points;
	}

	function syncPoints(qViewer, container, index, visible, highlightIfVisible) {
		for (var i = 0; i < qViewer.Charts.length; i++) {
			if (container.id != qViewer.Charts[i].container.id) {
				for (var j = 0; j < qViewer.Charts[i].series.length; j++) {
					var point = qViewer.Charts[i].series[j].data[index];
					if (visible) {
						if (highlightIfVisible) point.setState('hover');
						qViewer.Charts[i].tooltip.hide(0);
					}
					else {
						point.setState();
					}
				}
			}
		}
	}

	function getChartType_forHightCharts(chartType) {
		switch (chartType) {
			case "Column":
			case "Column3D":
			case "StackedColumn":
			case "StackedColumn3D":
			case "StackedColumn100":
			case "PolarArea":
				return "column";
			case "Bar":
			case "StackedBar":
			case "StackedBar100":
			case "LinearGauge":
				return "bar";
			case "Area":
			case "StackedArea":
			case "StackedArea100":
			case "FilledRadar":
			case "StepArea":
				return "area";
			case "SmoothArea":
				return "areaspline";
			case "Line":
			case "StackedLine":
			case "StackedLine100":
			case "Radar":
			case "Timeline":
			case "StepTimeline":
			case "Sparkline":
			case "StepLine":
				return "line";
			case "SmoothLine":
			case "SmoothTimeline":
				return "spline";
			case "ColumnLine":
			case "Column3DLine":
				return "column";
			case "Pie":
			case "Pie3D":
			case "Doughnut":
			case "Doughnut3D":
				return "pie";
			case "Funnel":
				return "funnel";
			case "Pyramid":
				return "pyramid";
			case "CircularGauge":
				return "solidgauge";
			default:
				return "line";
		}
	}

	function setLanguageOptions() {
		Highcharts.setOptions({
			lang: {
				//loading: 'Cargando...',  
				months: [gx.getMessage("GXPL_QViewerJanuary"), gx.getMessage("GXPL_QViewerFebruary"), gx.getMessage("GXPL_QViewerMarch"), gx.getMessage("GXPL_QViewerApril"), gx.getMessage("GXPL_QViewerMay"), gx.getMessage("GXPL_QViewerJune"), gx.getMessage("GXPL_QViewerJuly"), gx.getMessage("GXPL_QViewerAugust"), gx.getMessage("GXPL_QViewerSeptember"), gx.getMessage("GXPL_QViewerOctober"), gx.getMessage("GXPL_QViewerNovember"), gx.getMessage("GXPL_QViewerDecember")],
				weekdays: [gx.getMessage("GXPL_QViewerSunday"), gx.getMessage("GXPL_QViewerMonday"), gx.getMessage("GXPL_QViewerTuesday"), gx.getMessage("GXPL_QViewerWednesday"), gx.getMessage("GXPL_QViewerThursday"), gx.getMessage("GXPL_QViewerFriday"), gx.getMessage("GXPL_QViewerSaturday")],
				shortMonths: [gx.getMessage("GXPL_QViewerJanuary").substring(0, 3), gx.getMessage("GXPL_QViewerFebruary").substring(0, 3), gx.getMessage("GXPL_QViewerMarch").substring(0, 3), gx.getMessage("GXPL_QViewerApril").substring(0, 3), gx.getMessage("GXPL_QViewerMay").substring(0, 3), gx.getMessage("GXPL_QViewerJune").substring(0, 3), gx.getMessage("GXPL_QViewerJuly").substring(0, 3), gx.getMessage("GXPL_QViewerAugust").substring(0, 3), gx.getMessage("GXPL_QViewerSeptember").substring(0, 3), gx.getMessage("GXPL_QViewerOctober").substring(0, 3), gx.getMessage("GXPL_QViewerNovember").substring(0, 3), gx.getMessage("GXPL_QViewerDecember").substring(0, 3)]
				/*,  
				exportButtonTitle: "Exportar",  
				printButtonTitle: "Importar",  
				rangeSelectorFrom: "De",  
				rangeSelectorTo: "A",  
				rangeSelectorZoom: "Periodo",  
				downloadPNG: 'Descargar gráfica PNG',  
				downloadJPEG: 'Descargar gráfica JPEG',  
				downloadPDF: 'Descargar gráfica PDF',  
				downloadSVG: 'Descargar gráfica SVG',  
				printChart: 'Imprimir Gráfica',  
				thousandsSep: ",",  
				decimalPoint: '.'  
				*/
			}
		});
	}

	function SetItemClickData(eventData, qViewer, name, axis, value, selected, row) {

		function GetContextElement(axisOrDatum, value) {
			var contextElement = {};
			contextElement.Name = axisOrDatum.Name;
			var pictureProperties = GetPictureProperties(axisOrDatum.DataType, axisOrDatum.Picture);
			var formattedValue = ApplyPicture(value, axisOrDatum.Picture, axisOrDatum.DataType, pictureProperties);
			contextElement.Values = [formattedValue];
			return contextElement;
		}

		eventData.Name = name;
		eventData.Axis = axis;
		eventData.Value = value;
		eventData.Selected = selected;
		eventData.Context = [];
		for (var i = 0; i < qViewer.Chart.Categories.DataFields.length; i++) {
			var dataField = qViewer.Chart.Categories.DataFields[i];
			var axis = GetAxisByDataField(qViewer, dataField);
			var contextElement = GetContextElement(axis, row[dataField]);
			eventData.Context.push(contextElement);
		}
		for (var i = 0; i < qViewer.Chart.Series.DataFields.length; i++) {
			var dataField = qViewer.Chart.Series.DataFields[i];
			var datum = GetDatumByDataField(qViewer, dataField);
			var contextElement = GetContextElement(datum, row[dataField]);
			eventData.Context.push(contextElement);
		}
		eventData.Filters = [];
	}

	function ToggleChartsSelection(charts, index) {
		var selectedResult = false;
		for (var i = 0; i < charts.length; i++) {
			var chart = charts[i];
			for (var j = 0; j < chart.series.length; j++) {
				var point = chart.series[j].points[index];
				if (point.selected) {
					point.select();
					break;
				}
				else {
					point.select(true, j > 0);
					selectedResult = true;
				}
			}
		}
		return selectedResult;
	}

	function GetRowsToSelect(qViewer, selection) {
		var rowsToSelect = [];
		for (var i = 0; i < qViewer.Data.Rows.length; i++) {
			var row = qViewer.Data.Rows[i];
			var selected = true;
			for (j = 0; j < selection.length; j++) {
				var selectionItem = selection[j];
				if (row[selectionItem.DataField])
					if (qv.util.trim(row[selectionItem.DataField]) != qv.util.trim(selectionItem.Value)) {
						selected = false;
						break;
					}
			}
			if (selected)
				rowsToSelect.push(i);
		}
		return rowsToSelect;
	}

	function SelectChartsPoints(charts, indexes) {
		for (var i = 0; i < charts.length; i++) {
			var chart = charts[i];
			var accumulate = false;
			for (var j = 0; j < indexes.length; j++) {
				var index = indexes[j];
				for (var k = 0; k < chart.series.length; k++) {
					var point = chart.series[k].points[index];
					point.select(true, accumulate);
					if (!accumulate)
						accumulate = true;
				}
			}
		}
	}

	function DeselectChartsPoints(charts) {
		for (var i = 0; i < charts.length; i++) {
			var chart = charts[i];
			var points = chart.getSelectedPoints();
			if (points.length > 0)
				points[0].select(false, false);
		}
	}

	function onHighchartsItemClickEventHandler(event) {

		var qViewer = qv.collection[this.chart.options.qv.viewerId];
		var selected = false;
		if (qViewer.SelectionAllowed()) {
			if (qViewer.SelectionType == "Line")
				selected = ToggleChartsSelection(qViewer.Charts, event.point.index);
			else {
				event.point.select();
				selected = event.point.selected;
				if (qViewer.PlotSeries == "InSeparateCharts" && selected) {
					for (var i = 0; i < qViewer.Charts.length; i++) {
						var chart = qViewer.Charts[i];
						var point = chart.series[0].points[event.point.index];
						if (point != event.point)
							point.select(false);
					}
				}
			}
		}
		if (qViewer.ItemClick) {
			var serie = qViewer.Chart.Series.ByName[this.name];
			var formattedValue = qv.util.formatNumber(event.point.y, serie.NumberFormat.DecimalPrecision, serie.Picture, false);
			var row = qViewer.Data.Rows[event.point.index];
			SetItemClickData(qViewer.ItemClickData, qViewer, serie.FieldName, "Data", formattedValue, selected, row);
			qViewer.ItemClick();
		}
	}

	function onHighchartsXAxisClickEventHandler(event, tickInd, tick, chart) {
		var qViewer = qv.collection[chart.options.qv.viewerId];
		var selected = false;
		if (qViewer.SelectionAllowed() && !IsTimelineChart(qViewer))
			selected = ToggleChartsSelection(qViewer.Charts, tick.pos);
		if (qViewer.ItemClick) {
			var name;
			if (qViewer.Chart.Categories.DataFields.length == 1) {
				var dataField = qViewer.Chart.Categories.DataFields[0];
				var axis = GetAxisByDataField(qViewer, dataField);
				name = axis.Name;
			}
			else
				name = "";
			var row = qViewer.Data.Rows[tickInd];
			SetItemClickData(qViewer.ItemClickData, qViewer, name, "Row", tick.label.textStr, selected, row);
			qViewer.ItemClick();
		}
	}

	function GetBoldText(text, color) {
		if (color == "")
			return '<span style="font-weight:bold">' + text + '</span>';
		else
			return '<span style="font-weight:bold;color:' + color + ';">' + text + '</span>';
	}

	function CircularGaugeTooltipAndDataLabelFormatter(evArg, qViewer) {
		var serie = qViewer.Chart.Series.ByName[evArg.series.name];
		var chartSize = Math.min(qViewer.Height, qViewer.Width) / NumberOfCharts(qViewer);
		var fontSize = chartSize / 13;
		return '<span style="color:' + GetColorStringFromHighchartsObject(qViewer, evArg) + ';font-size:' + fontSize + 'px">' + qv.util.formatNumber(evArg.point.y, 2, "ZZZZZZZZZZZZZZ9.99", true) + '%</span>'
	}

	function DataLabelFormatter(evArg, qViewer, showvalues) {
		var chartSerie = qViewer.Chart.Series.ByName[evArg.series.name];
		var multiplier = qViewer.RealChartType == "LinearGauge" ? chartSerie.TargetValue / 100 : 1;
		var value = qv.util.formatNumber(evArg.point.y * multiplier, chartSerie.NumberFormat.DecimalPrecision, chartSerie.Picture, false);
		var chartType = evArg.series.chart.options.chart.type;
		var label = value;
		return label;
	}

	function TooltipFormatter(evArg, chartSeries, sharedTooltip)
	{
		var qViewer;
		if (!sharedTooltip) {
			qViewer = qv.collection[evArg.series.chart.options.qv.viewerId];
			var serie = chartSeries[evArg.series.name];
			var picture = IsGaugeChart(qViewer) ? "ZZZZZZZZZZZZZZ9.99" : serie.Picture;
			var decimalPrecision = IsGaugeChart(qViewer) ? 2 : serie.NumberFormat.DecimalPrecision;
			var removeTrailingZeroes = IsGaugeChart(qViewer);
			return '<b>' + (evArg.point.id != "" ? evArg.point.id : evArg.series.name) + '</b>: ' + qv.util.formatNumber(evArg.point.y, decimalPrecision, picture, removeTrailingZeroes) + (IsGaugeChart(qViewer) ? "%" : "");
		}
		else {
			var firstPoint;
			var index;
			if (!evArg.points) {
				firstPoint = evArg.point;
				index = firstPoint.index;
			}
			else {
				firstPoint = evArg.points[0];
				index = firstPoint.point.index;
			}
			qViewer = qv.collection[firstPoint.series.chart.options.qv.viewerId];
			var isSingleSerieChart = IsSingleSerieChart(qViewer);
			var hoverPoints = getHoverPoints(qViewer, index);
			var x = (!evArg.key ? (!evArg.x ? "" : evArg.x) : evArg.key);
			var hasTitle = x != "" && qViewer.RealChartType != "Sparkline";	// en Sparkline la x no viene formateada
			var res = "";
			if (hasTitle)
				res += GetBoldText(x, isSingleSerieChart ? GetColorStringFromHighchartsObject(qViewer, evArg) : "");
			for (var i = 0; i < hoverPoints.length; i++) {
				var point = hoverPoints[i];
				var serie = chartSeries[point.series.name];
				res += (hasTitle || i > 0 ? '<br/>' : '') + GetBoldText(point.series.name + ': ', isSingleSerieChart ? "" : GetColorStringFromHighchartsObject(qViewer, point));
				res += qv.util.formatNumber(point.y, serie.NumberFormat.DecimalPrecision, serie.Picture, false);
			}
			return res;
		}
	}

	function PieTooltipFormatter(evArg, chartSeries, sharedTooltip) {
		if (!sharedTooltip) {
			var percentage = Math.round(evArg.point.percentage * 100) / 100;
			return '<b>' + (evArg.point.name != "" ? evArg.point.name : evArg.point.series.name) + '</b>: ' + percentage + '%';
		}
		else {
			var qViewer = qv.collection[evArg.point.series.chart.options.qv.viewerId];
			var isSingleSerieChart = IsSingleSerieChart(qViewer);
			var hoverPoints = getHoverPoints(qViewer, evArg.point.index);
			var x = hoverPoints.length > 0 ? hoverPoints[0].id : "";
			var hasTitle = x != "";
			var res = "";
			if (hasTitle)
				res += GetBoldText(x, isSingleSerieChart ? GetColorStringFromHighchartsObject(qViewer, evArg) : "");
			for (var i = 0; i < hoverPoints.length; i++) {
				var point = hoverPoints[i];
				var serie = chartSeries[point.series.name];
				res += (hasTitle || i > 0 ? '<br/>' : '') + GetBoldText(point.series.name + ': ', isSingleSerieChart ? "" : GetColorStringFromHighchartsObject(qViewer, point.series));
				var percentage = Math.round(point.percentage * 100) / 100;
				res += percentage + '%';;
			}
			return res;
		}
	}

	function Stacked100TooltipFormatter(evArg) {
		var percentage = Math.round(evArg.point.percentage * 100) / 100;
		return '<b>' + (evArg.point.id != "" ? evArg.point.id : evArg.series.name) + '</b>: ' + percentage + '%';
	}

	function DateTimeTooltipFormatter(evArg, addChangeInformation, chartSeries) {

		function GetDuration(point) {

			var value = point.y;
			var points = point.series.data;
			var index = point.index;
			var duration = "";
			var max = index;
			for (var i = index + 1; i < points.length; i++) {
				if (points[i].y != value)
					break;
				max = i;
			}
			if (max < points.length - 1)
				max++;
			var min = index;
			for (var i = index - 1; i >= 0; i--) {
				if (points[i].y != value)
					break;
				min = i;
			}
			var seconds = (points[max].x - points[min].x) / 1000;
			duration = " (" + gx.getMessage("GXPL_QViewerDuration") + ": " + qv.util.seconsdToText(seconds) + ")";
			return duration;
		}

		var hoverPoints;
		var qViewer = qv.collection[evArg.points[0].series.chart.options.qv.viewerId];
		if (IsSplittedChart(qViewer))
			hoverPoints = getHoverPoints(qViewer, evArg.points[0].point.index);
		else {
			hoverPoints = [];
			$.each(evArg.points, function (index, point) {
				hoverPoints.push(point.point);
			});
		}
		// Agrupa la lista de puntos por name
		var points_by_name = {};
		var compare = false;
		for (var i = 0; i < hoverPoints.length; i++) {
			var name = hoverPoints[i].series.name;
			if (points_by_name[name] == undefined) {
				points_by_name[name] = [];
			}
			points_by_name[name].push(hoverPoints[i]);
			if (points_by_name[name].length > 1) compare = true;
		}
		var res = '';
		var currentTotal = 0;
		var previousTotal = 0;
		var oldUtc;
		for (var key_name in points_by_name) {
			var serie = chartSeries[key_name];
			var points = points_by_name[key_name];
			var color = GetColorStringFromHighchartsObject(qViewer, points[0]);
			var colorSpan = '<span style="color:' + color + ';">';
			var colorSpanBold = '<span style="font-weight:bold;color:' + color + ';">';
			var boldSpan = '<span style="font-weight:bold;">';
			if (compare)
				res += colorSpanBold + key_name + '</span><br/>';
			for (var ind = 0; points[ind] != undefined; ind++) {
				var p = points[ind];
				var utc = parseInt(p.real_x ? p.real_x : p.x);
				if (p.real_x) {
					previousTotal += p.y;
				} else {
					currentTotal += p.y;
				}
				if (hoverPoints.length > 0 && hoverPoints[0].series.chart.options.qv.comparing) { //Si esta habilitada la comparación (la fecha es diferente con el período anterior)
					//Se muestra toda la información de cada serie con el color correspondiente
					res += p.name + ': </span>' + qv.util.formatNumber(p.y, serie.NumberFormat.DecimalPrecision, serie.Picture, false) + '</span><br/>';
				}
				else {
					//Se muestra el nombre de cada con el color correspondiente. La fecha que es común va arriba en negro. El valor de cada serie en bold (sin color)							
					if (oldUtc != utc) {
						res += p.name + '<br/>';
						oldUtc = utc;
					}
					var duration = qViewer.RealChartType == "StepTimeline" ? GetDuration(p) : "";
					res += colorSpan + key_name + ': </span>' + boldSpan + qv.util.formatNumber(p.y, serie.NumberFormat.DecimalPrecision, serie.Picture, false) + '</span>' + duration + '<br/>';
				}
			}
		}
		// Agrega la informacion de cambio entre una seria y la otra. Esto solo para el caso de tener una serie en la query.
		if (addChangeInformation && hoverPoints.length > 0 && hoverPoints[0].series.chart.options.qv.comparing) {
			//Si las dos series tienen valores en el punto actual
			if (previousTotal > 0 && currentTotal > 0) {
				var change = ((currentTotal - previousTotal) / previousTotal) * 100;
				change = qv.util.formatNumber(change, 2, "ZZZZZZZZZZZZZZ9.99", false);
				res += '<span>' + gx.getMessage("GXPL_QViewerJSChartChange") + '</span><span style="font-weight:bold;"> ' + change + '%</span>';
			}
		}
		return res;
	}

	function selectionEventHandler(event) {
		if (typeof _avoidSelectionEventHandler === "undefined")
			_avoidSelectionEventHandler = false;
		if (!_avoidSelectionEventHandler) {
			// Desmarca el botón de zoom seleccionado cuando se hace un zoom seleccionando puntos en la gráfica
			deselectZoom(prevClickedZoomId);
			prevClickedZoomId = null;
			if (event.xAxis) {
				var qvOptions = event.target.options.qv;
				var xAxis = event.xAxis[0];
				var minPercent = (xAxis.min - qvOptions.dataMin) / (qvOptions.dataMax - qvOptions.dataMin) * 100;
				var maxPercent = (xAxis.max - qvOptions.dataMin) / (qvOptions.dataMax - qvOptions.dataMin) * 100;
				InitializeSlider(event.target.options.qv.viewerId, minPercent, maxPercent);
			}
			else
				InitializeSlider(event.target.options.qv.viewerId, 0, 100);
			var qViewer = qv.collection[event.target.options.qv.viewerId];
			if (IsSplittedChart(qViewer)) {
				var containers;
				var containerId = qViewer.getContainerControl().id;
				containers = $("[id^=" + containerId + "_chart]");
				var charts = [];
				$.each(containers, function (index, div) {
					if (div.id != event.target.renderTo.id) {
						var chart = $("#" + div.id).highcharts();
						charts.push(chart);
					}
				});
				$.each(charts, function (index, chart) {
					if (event.xAxis) {
						chart.get('xaxis').setExtremes(xAxis.min, xAxis.max);
					}
					else {
						_avoidSelectionEventHandler = true;
						chart.zoomOut();
						_avoidSelectionEventHandler = false;
					}
				});
			}
		}
	}

	function groupPoints(chartCategories, chartSeriePoints, xAxisDataType, aggregation, groupOption)
	{

		function getGroupStartPoint(dateStr, name, xAxisDataType, dateFormat, groupOption) {

			function yearWith4Digits(xAxisDataType, name) {
				return xAxisDataType == "date" ? name.length == 10 : name.charAt(10) == " ";
			}

			function formatDate(dateStr, dateFormat, yearWith4Digits, includeMonth, includeDay) {
				var year = dateStr.substr(0, 4);
				var month = dateStr.substr(5, 2);
				var day = dateStr.substr(8, 2);
				var date = dateFormat;
				if (!includeMonth) date = date.replace("M", "");
				if (!includeDay) date = date.replace("D", "");
				var newDate = "";
				for (var i = 0; i < date.length; i++) {
					newDate += i == 0 ? "" : "/";
					newDate += date.charAt(i);
				}
				date = newDate.replace("Y", yearWith4Digits ? year : year.substr(2, 2));
				if (includeMonth)
					date = date.replace("M", month);
				if (includeDay)
					date = date.replace("D", day);
				return date;
			}

			var dateStrStartPoint;
			var nameStartPoint;
			if (dateStr != "") {
				groupOption = groupOption || (xAxisDataType == "date" ? "Days" : "Seconds");
				switch (groupOption) {
					case "Years":
						dateStrStartPoint = dateStr.substr(0, 4) + "-01-01";
						nameStartPoint = formatDate(dateStrStartPoint, dateFormat, yearWith4Digits(xAxisDataType, name), false, false);
						break;
					case "Months":
						dateStrStartPoint = dateStr.substr(0, 7) + "-01";
						nameStartPoint = formatDate(dateStrStartPoint, dateFormat, yearWith4Digits(xAxisDataType, name), true, false);
						break;
					case "Semesters":
						var startingMonth = dateStr.substr(5, 2) <= "06" ? "01" : "07";
						dateStrStartPoint = dateStr.substr(0, 5) + startingMonth + "-01";
						var semester = dateStr.substr(5, 2) <= "06" ? "01" : "02";
						dateStrSemester = dateStr.substr(0, 5) + semester + "-01";
						nameStartPoint = formatDate(dateStrSemester, dateFormat, yearWith4Digits(xAxisDataType, name), true, false);
						break;
					case "Quarters":
						var startingMonth = dateStr.substr(5, 2) <= "03" ? "01" : (dateStr.substr(5, 2) <= "06" ? "04" : (dateStr.substr(5, 2) <= "09" ? "07" : "10"));
						dateStrStartPoint = dateStr.substr(0, 5) + startingMonth + "-01";
						var quarter = dateStr.substr(5, 2) <= "03" ? "01" : (dateStr.substr(5, 2) <= "06" ? "02" : (dateStr.substr(5, 2) <= "09" ? "03" : "04"));
						dateStrQuarter = dateStr.substr(0, 5) + quarter + "-01";
						nameStartPoint = formatDate(dateStrQuarter, dateFormat, yearWith4Digits(xAxisDataType, name), true, false);
						break;
					case "Weeks":
						var date = new gx.date.gxdate(dateStr, "Y4MD");
						var dow = gx.date.dow(date);
						date = gx.date.dtadd(date, -86400 * (dow - 1));
						dateStrStartPoint = qv.util.dateToString(date, false);
						nameStartPoint = formatDate(dateStrStartPoint, dateFormat, yearWith4Digits(xAxisDataType, name), true, true);
						break;
					case "Days":
						dateStrStartPoint = xAxisDataType == "date" ? dateStr : dateStr.substr(0, 10);
						nameStartPoint = xAxisDataType == "date" ? name : name.substr(0, 10);
						break;
					case "Hours":
						dateStrStartPoint = dateStr.substr(0, 13) + ":00:00";
						nameStartPoint = name.substr(0, 13) + ":00";
						break;
					case "Minutes":
						dateStrStartPoint = dateStr.substr(0, 16) + ":00";
						nameStartPoint = name.substr(0, 16);
						break;
					case "Seconds":
						dateStrStartPoint = dateStr;
						nameStartPoint = name;
						break;
				}
			}
			else {
				dateStrStartPoint = "";
				nameStartPoint = "";
			}
			return { dateStr: dateStrStartPoint, name: nameStartPoint };
		}

		var point;
		var lastStartPoint = { dateStr: null, name: null };
		var currentYValues = [];
		var currentYQuantities = [];
		var points = [];
		for (i = 0; i < chartSeriePoints.length; i++) {
			var name = chartCategories.Values[i].ValueWithPicture;
			var xValue = chartCategories.Values[i].Value;
			var yValue;
			var yQuantity;
			if (chartSeriePoints[i].Value != null) {
				if (aggregation == "Count") {
					yValue = 0;		// No se utiliza
					yQuantity = parseFloat(qv.util.trim(chartSeriePoints[i].Value));
				}
				else {
					if (aggregation == "Average") {
						yValue = parseFloat(qv.util.trim(chartSeriePoints[i].Value_N));
						yQuantity = parseFloat(qv.util.trim(chartSeriePoints[i].Value_D));
					}
					else {
						yValue = parseFloat(qv.util.trim(chartSeriePoints[i].Value));
						yQuantity = 1;
					}
				}
			}
			else {
				yValue = null;
				yQuantity = 0;
			}
			var currentStartPoint = getGroupStartPoint(xValue, name, xAxisDataType, gx.dateFormat, groupOption);
			if (currentStartPoint.dateStr == lastStartPoint.dateStr || i == 0) {
				if (yValue != null) {
					currentYValues.push(yValue);
					currentYQuantities.push(yQuantity);
				}
				if (i == 0)
					lastStartPoint = currentStartPoint;
			}
			else {
				point = { x: lastStartPoint.dateStr, y: qv.util.aggregate(aggregation, currentYValues, currentYQuantities), name: lastStartPoint.name };
				points.push(point);
				lastStartPoint = currentStartPoint;
				currentYValues = [yValue];
				currentYQuantities = [yQuantity];
			}
		}
		if (currentYValues.length > 0 && currentYQuantities.length > 0) {
			point = { x: lastStartPoint.dateStr, y: qv.util.aggregate(aggregation, currentYValues, currentYQuantities), name: lastStartPoint.name };
			points.push(point);
		}
		return points;
	}

	function aggregatePoints(chartSerie) {
		var currentYValues = [];
		var currentYQuantities = [];
		var firstColor = "";
		for (i = 0; i < chartSerie.Points.length; i++) {
			var yValue;
			var yQuantity;
			if (chartSerie.Aggregation == "Count") {
				yValue = 0;		// No se utiliza
				yQuantity = parseFloat(qv.util.trim(chartSerie.Points[i].Value));
			}
			else {
				if (chartSerie.Aggregation == "Average") {
					yValue = parseFloat(qv.util.trim(chartSerie.Points[i].Value_N));
					yQuantity = parseFloat(qv.util.trim(chartSerie.Points[i].Value_D));
				}
				else {
					yValue = parseFloat(qv.util.trim(chartSerie.Points[i].Value));
					yQuantity = 1;
				}
			}
			currentYValues.push(yValue);
			currentYQuantities.push(yQuantity);
			if (firstColor == "") firstColor = chartSerie.Points[i].Color;
		}
		var value = qv.util.aggregate(chartSerie.Aggregation, currentYValues, currentYQuantities).toString();
		chartSerie.Points = [{ Value: value, Value_N: value, Value_D: "1", Color: firstColor }];
		chartSerie.NegativeValues = value < 0;
		chartSerie.PositiveValues = value > 0;
	}

	function getSpacing(qViewer)
	{
		// Números determinados experimentalmente
		var spacingTop;
		var spacingRight;
		var spacingBottom;
		var spacingLeft = 0;
		switch (qViewer.RealChartType) {
			case "Column3D":
			case "StackedColumn3D":
			case "Column3DLine":
				spacingRight = 15;
				break;
			case "StackedBar100":
				spacingRight = 1;
				break;
			case "Funnel":
			case "Pyramid":
				spacingRight = 40;
				break;
			default:
				spacingRight = 0;
				break;
		}
		if (IsTimelineChart(qViewer))
			if (qViewer.Chart.Series.DataFields.length > 1)
				spacingBottom = 0;
			else
				spacingBottom = 5;
		else if (IsGaugeChart(qViewer))
			spacingBottom = 0;
		else
			spacingBottom = 15;		// default de HighCharts
		if (IsGaugeChart(qViewer))
			spacingTop = 0;
		else
			spacingTop = 10			// default de HighCharts
		return [spacingTop, spacingRight, spacingBottom, spacingLeft];
	}

	function circularGaugeWidths(chartSeriesCount, serieNumber) {
		var width;
		var center;
		var lowerExtreme;
		var upperExtreme;
		if (chartSeriesCount <= 3)
			width = 24;
		else
			width = 50 / (chartSeriesCount - 1) - 1;		// Para que no pase más del 50% del Gauge hacia adentro;
		center = 100 - (width + 1) * (serieNumber - 1);
		lowerExtreme = center - width / 2;
		upperExtreme = center + width / 2;
		return { Width: width, Center: center, LowerExtreme: lowerExtreme, UpperExtreme: upperExtreme};
	}

	function linearGaugeWidths(chartSeriesCount, serieNumber) {
		var width = 1 / chartSeriesCount / 2;
		var center = -0.5 + (serieNumber - 0.5) / chartSeriesCount;
		var lowerExtreme = center - width / 2;
		var upperExtreme = center + width / 2;
		return { Width: width, Center: center, LowerExtreme: lowerExtreme, UpperExtreme: upperExtreme };
	}

	function ApplyPicture(value, picture, dataType, pictureProperties) {
		switch (dataType) {
			case "integer":
			case "real":
				return qv.util.formatNumber(value, pictureProperties.DecimalPrecision, picture, false);
			case "boolean":
			case "character":
				return qv.util.trim(value);
			case "date":
			case "datetime":
				return qv.util.formatDateTime(value, dataType, pictureProperties.DateFormat, pictureProperties.IncludeHours, pictureProperties.IncludeMinutes, pictureProperties.IncludeSeconds);
		}
	}

	function GetPictureProperties(dataType, picture) {
		var pictureProperties;
		if (dataType == "integer" || dataType == "real")
			pictureProperties = qv.util.ParseNumericPicture(dataType, picture);
		else if (dataType == "date" || dataType == "datetime")
			pictureProperties = qv.util.ParseDateTimePicture(dataType, picture);
		else
			pictureProperties = null;
		return pictureProperties;
	}
	
	function ProcessDataAndMetadata(qViewer) {

		function GetCategoriesAndSeriesDataFields(qViewer) {
			qViewer.Chart.Categories = {};
			qViewer.Chart.Categories.DataFields = [];
			for (var i = 0; i < qViewer.Metadata.Axes.length; i++) {
				var axis = qViewer.Metadata.Axes[i];
				if (axis.AxisType == "Rows" || axis.AxisType == "Columns")
					qViewer.Chart.Categories.DataFields.push(axis.DataField);
			}
			qViewer.Chart.Series = {};
			qViewer.Chart.Series.DataFields = [];
			for (var i = 0; i < qViewer.Metadata.Data.length; i++) {
				var datum = qViewer.Metadata.Data[i];
				qViewer.Chart.Series.DataFields.push(datum.DataField);
			}
		}

		function GetAxesByDataFieldObj(qViewer) {
			var axesByDataField = {};
			for (var i = 0; i < qViewer.Metadata.Axes.length; i++) {
				var axis = qViewer.Metadata.Axes[i];
				var pictureProperties = GetPictureProperties(axis.DataType, axis.Picture);
				axesByDataField[axis.DataField] = { Picture: axis.Picture, DataType: axis.DataType, PictureProperties: pictureProperties, Filter: axis.Filter };
			}
			return axesByDataField;
		}

		function GetDataByDataFieldObj(qViewer, uniqueAxis) {

			function IsMulticoloredSerie(qViewer, datum, uniqueAxis) {

				function ExistColors(styles) {
					// Verifica si hay colores a partir de Styles condicionales
					var existColors = false;
					for (var i = 0; i < styles.length; i++) {
						var style = styles[i];
						var arr = GetColorFromStyle(style.StyleOrClass, false);
						var colorFound = arr[0];
						if (colorFound) {
							existColors = true;
							break;
						}
					}
					return existColors;
				}

				var multicoloredSerie;
				if (IsSingleSerieChart(qViewer) || (qViewer.RealChartType == "PolarArea" && qViewer.Chart.Series.DataFields.length == 1))
					multicoloredSerie = true;					// Estos tipos de gráfica tienen que dibujar sí o sí cada valor con un color diferente
				else if (IsAreaChart(qViewer) || IsLineChart(qViewer) || qViewer.RealChartType == "Radar" || qViewer.RealChartType == "FilledRadar")
					multicoloredSerie = false;					// Estos tipos de gráfica no pueden ser multicolores porque son líneas o áreas y no estamos dejando pintar partes de una linea o area de colores diferentes
				else if (qViewer.Chart.Series.DataFields.length > 1 && !IsSplittedChart(qViewer))
					multicoloredSerie = false;					// Multi series: al haber más de una serie hay una leyenda indicando el color de cada serie, por lo tanto todos los valores tienen que tener el mismo color
				else {
					// Single series
					var existConditionalColors = ExistColors(datum.ConditionalStyles);
					var existValuesColors = false;
					if (uniqueAxis != null)
						existValuesColors = ExistColors(uniqueAxis.ValuesStyles);	// Si tengo una sola categoria tambien se puede hacer por valor si corresponde
					multicoloredSerie = (existConditionalColors || existValuesColors);	// Es multicolor si existen colores condicionales o colores por valor
				}
				return multicoloredSerie;
			}

			var dataByDataField = {};
			for (var i = 0; i < qViewer.Metadata.Data.length; i++) {
				var datum = qViewer.Metadata.Data[i];
				var multicolored = IsMulticoloredSerie(qViewer, datum, uniqueAxis)
				dataByDataField[datum.DataField] = { Datum: datum, Multicolored: multicolored };
			}
			return dataByDataField;

		}

		function GetColorFromStyle(style, isBackgroundColor) {
			var color = "";
			var colorFound = false;
			var colorKey = isBackgroundColor ? "backgroundcolor" : "color";
			if (style != "") {
				var keyValuePairs = style.split(";");
				for (var i = 0; i < keyValuePairs.length; i++) {
					var keyValuePairStr = keyValuePairs[i];
					var keyValuePair = keyValuePairStr.split(":");
					if (keyValuePair.length == 2) {
						var key = keyValuePair[0];
						var value = keyValuePair[1];
						if (key.toLowerCase() == colorKey) {
							color = value;
							colorFound = (value != "");
							break;
						}
					}
				}
				if (colorFound && color.substr(0, 1) == "#")
					color = color.replace("#", "");
			}
			return [colorFound, color];
		}

		function GetColor(multicoloredSerie, datum, uniqueAxis, seriesIndex, colorIndex, categoryLabel, value) {

			function GetValueStyleColor(axis, value) {
				// Obtiene el color que corresponde al valor según el ValueStyle
				var arr = [false, ""];
				for (var i = 0; i < axis.ValuesStyles.length; i++) {
					var valueStyle = axis.ValuesStyles[i];
					if (valueStyle.Value == value) {
						arr = GetColorFromStyle(valueStyle.StyleOrClass, false);
						break;
					}
				}
				return arr;
			}

			function GetConditionalColor(datum, value) {
				// Obtiene el color que corresponde al valor según el Style condicional
				var arr = [false, ""];
				var conditionSatisfied = false;
				for (var i = 0; i < datum.ConditionalStyles.length; i++) {
					var conditionalStyle = datum.ConditionalStyles[i];
					conditionSatisfied = qv.util.satisfyStyle(value, conditionalStyle);
					if (conditionSatisfied) {
						arr = GetColorFromStyle(conditionalStyle.StyleOrClass, false);
						break;
					}
				}
				return arr;
			}

			var color;
			var colorIndexAux = -1;
			var isDefaultColor = false;
			var arr;
			if (multicoloredSerie) {		// Cada valor de la serie tiene un color diferente
				var colorFound = false;
				if (uniqueAxis != null) {
					arr = GetValueStyleColor(uniqueAxis, categoryLabel);	// Busco primero en los style por valor
					colorFound = arr[0];
					color = arr[1];
				}
				if (!colorFound) {
					arr = GetConditionalColor(datum, value)	// Busco luego en los styles condicionales
					colorFound = arr[0];
					color = arr[1];
					if (!colorFound) {
						colorIndexAux = colorIndex % HIGHCHARTS_MAX_COLORS;
						isDefaultColor = true;
					}
				}
			}
			else {		// Todos los valores de la serie con el mismo valor
				arr = GetColorFromStyle(datum.Style, false);
				colorFound = arr[0];
				color = arr[1];
				if (!colorFound) {
					colorIndexAux = seriesIndex % HIGHCHARTS_MAX_COLORS;
					isDefaultColor = true;
				}
			}
			return { IsDefault: isDefaultColor, Color: color, ColorIndex: colorIndexAux };
		}

		function AddCategoryValue(qViewer, row, valueIndex, axesByDataField) {

			function GetCategoryLabel(qViewer, row, axesByDataField) {

				var label = "";
				var labelWithPicture = "";
				for (var i = 0; i < qViewer.Chart.Categories.DataFields.length; i++) {
					var dataField = qViewer.Chart.Categories.DataFields[i];
					var value;
					var valueWithPicture;
					if (row[dataField] != undefined) {
						value = qv.util.trim(row[dataField]);
						valueWithPicture = ApplyPicture(value, axesByDataField[dataField].Picture, axesByDataField[dataField].DataType, axesByDataField[dataField].PictureProperties);
					}
					else {
						value = qViewer.Metadata.TextForNullValues;
						valueWithPicture = qViewer.Metadata.TextForNullValues;
					}
					label += (label == "" ? "" : ", ") + value;
					labelWithPicture += (labelWithPicture == "" ? "" : ", ") + valueWithPicture;
				}
				return [label, labelWithPicture];
			}

			var arr = GetCategoryLabel(qViewer, row, axesByDataField);
			var categoryValue = {};
			categoryValue.Value = arr[0];
			categoryValue.ValueWithPicture = arr[1];
			qViewer.Chart.Categories.Values.push(categoryValue);
			if (valueIndex == 0) {
				qViewer.Chart.Categories.MinValue = categoryValue.Value;
				qViewer.Chart.Categories.MaxValue = categoryValue.Value;
			}
			else {
				if (categoryValue.Value > qViewer.Chart.Categories.MaxValue)
					qViewer.Chart.Categories.MaxValue = categoryValue.Value;
				if (categoryValue.Value < qViewer.Chart.Categories.MinValue)
					qViewer.Chart.Categories.MinValue = categoryValue.Value;
			}

		}

		function AddSeriesValues(qViewer, row, valueIndex, dataByDataField, uniqueAxis) {
			for (var i = 0; i < qViewer.Chart.Series.DataFields.length; i++) {
				var serie = qViewer.Chart.Series.ByIndex[i]
				var dataField = qViewer.Chart.Series.DataFields[i];
				var value = row[dataField] != undefined ? row[dataField]: null;
				var point = {};
				point.Value = value;
				var datum = dataByDataField[dataField].Datum;
				var multicoloredSerie = dataByDataField[dataField].Multicolored;
				if (datum.Aggregation == "Average") {
					var value_N = row[dataField + "_N"];
					var value_D = row[dataField + "_D"];
					if (value_N == undefined && value_D == undefined) {
						// Caso de un dataprovider donde se le asigna agregación = Average por código
						value_N = value;
						value_D = "1";
					}
					point.Value_N = value_N;
					point.Value_D = value_D;
				}
				if (multicoloredSerie)
					point.Color = GetColor(multicoloredSerie, datum, uniqueAxis, 0, valueIndex, qViewer.Chart.Categories.Values[valueIndex].Value, value);
				else
					point.Color = GetNullColor();
				serie.Points.push(point);
				if (point.Value > 0) serie.PositiveValues = true;
				if (point.Value < 0) serie.NegativeValues = true;
			}
		}

		function CalculatePlotBands(qViewer, datum) {
			for (var j = 0; j < datum.ConditionalStyles.length; j++) {
				var conditionalStyle = datum.ConditionalStyles[j];
				var arr = GetColorFromStyle(conditionalStyle.StyleOrClass, true);
				var colorFound = arr[0];
				var backgroundColor = arr[1];
				if (colorFound) {
					plotBand = {};
					plotBand.Color = GetColorObject(backgroundColor);
					if (conditionalStyle.Operator == "IN") {
						plotBand.From = parseFloat(conditionalStyle.Value1);
						plotBand.To = parseFloat(conditionalStyle.Value2);
					} else if (conditionalStyle.Operator == "EQ") {
						plotBand.From = parseFloat(conditionalStyle.Value1);
						plotBand.To = parseFloat(conditionalStyle.Value1);
					}
					else if (conditionalStyle.Operator == "GE" || conditionalStyle.Operator == "GT")
						plotBand.From = parseFloat(conditionalStyle.Value1);
					else if (conditionalStyle.Operator == "LE" || conditionalStyle.Operator == "LT")
						plotBand.To = parseFloat(conditionalStyle.Value1);
					plotBand.SeriesName = datum.Title;
					qViewer.Chart.PlotBands.push(plotBand);
				}
			}
		}

		function IsFilteredRow(qViewer, row) {
			var filtered = false;
			for (var i = 0; i < qViewer.Metadata.Axes.length; i++) {
				var axis = qViewer.Metadata.Axes[i];
				if (axis.AxisType == "Rows" || axis.AxisType == "Columns" || axis.AxisType == "Pages") {
					if (axis.Filter.Type == "HideAllValues") {
						filtered = true;
						break;
					}
					else if (axis.Filter.Type == "ShowSomeValues") {
						var value = qv.util.trim(row[axis.DataField]);
						if (axis.Filter.Values.indexOf(value) < 0) {
							filtered = true;
							break;
						}
					}
				}
			}
			return filtered;
		}

		qViewer.Chart = {};

		// Obtengo DataFields de categorias y series
		GetCategoriesAndSeriesDataFields(qViewer);

		// Inicializo categorias
		qViewer.Chart.Categories.MinValue = null;
		qViewer.Chart.Categories.MaxValue = null;
		qViewer.Chart.Categories.Values = [];
		var axesByDataField = GetAxesByDataFieldObj(qViewer);

		// Inicializo series
		qViewer.Chart.Series.ByName = {};
		qViewer.Chart.Series.ByIndex = [];
		var uniqueAxis = qViewer.Chart.Categories.DataFields.length == 1 ? GetAxisByDataField(qViewer, qViewer.Chart.Categories.DataFields[0]) : null;
		var dataByDataField = GetDataByDataFieldObj(qViewer, uniqueAxis);
		qViewer.Chart.PlotBands = [];
		for (var i = 0; i < qViewer.Chart.Series.DataFields.length; i++) {
			var dataField = qViewer.Chart.Series.DataFields[i];
			var datum = dataByDataField[dataField].Datum;
			var serie = {};
			var multicoloredSerie = dataByDataField[dataField].Multicolored;
			serie.FieldName = datum.Name;					// Nombre del field correspondiente a serie
			serie.Name = datum.Title;						// Título (traducible) del field correspondiente a la serie
			serie.DataType = datum.DataType;
			serie.Aggregation = datum.Aggregation;
			var picture = datum.Picture;
			serie.Picture = (picture == "" ? (serie.DataType == "integer" ? "ZZZZZZZZZZZZZZ9" : "ZZZZZZZZZZZZZZ9.99") : picture);
			serie.NumberFormat = qv.util.ParseNumericPicture(serie.DataType, serie.Picture);
			if (!multicoloredSerie)
				serie.Color = GetColor(multicoloredSerie, datum, uniqueAxis, i, 0, "", 0);
			else
				serie.Color = GetNullColor();
			serie.TargetValue = datum.TargetValue;
			serie.MaximumValue = datum.MaximumValue;
			NormalizeTargetAndMaximumValues(serie);
			serie.PositiveValues = false;
			serie.NegativeValues = false;
			serie.Points = [];
			qViewer.Chart.Series.ByName[serie.Name] = serie;
			qViewer.Chart.Series.ByIndex.push(serie);
			// Si el dato tiene estilos condicionales, agrego las PlotBands correspondientes
			CalculatePlotBands(qViewer, datum);
		}

		// Recorro valores y lleno categorías y series
		var valueIndex = 0;
		for (var i = 0; i < qViewer.Data.Rows.length; i++) {
			var row = qViewer.Data.Rows[i];
			if (!IsFilteredRow(qViewer, row)) {
				AddCategoryValue(qViewer, row, valueIndex, axesByDataField);
				AddSeriesValues(qViewer, row, valueIndex, dataByDataField, uniqueAxis);
				valueIndex++;
			}
		}

		if (IsGaugeChart(qViewer))
			for (var i = 0; i < qViewer.Chart.Series.DataFields.length; i++) {
				var serie = qViewer.Chart.Series.ByIndex[i];
				aggregatePoints(serie);		// Sólo puede haber un punto por serie para el Gauge
			}

	}

	function NormalizeTargetAndMaximumValues(serie) {
		if (serie.TargetValue <= 0)
			serie.TargetValue = 100;
		if (serie.MaximumValue <= 0)
			serie.MaximumValue = 100;
		if (serie.MaximumValue < serie.TargetValue)
			serie.MaximumValue = serie.TargetValue;
	}

	function GetThemeStyleSheet(qViewer) {
		if (!qViewer._themeStyleSheet) {
			var cssName = gx.theme + ".css";
			qViewer._themeStyleSheet = GetStyleSheet(cssName);
		}
		return qViewer._themeStyleSheet;
	}

	function GetQueryViewerStyleSheet(qViewer) {
		if (!qViewer._queryViewerStyleSheet) {
			var cssName = "QueryViewer.css";
			qViewer._queryViewerStyleSheet = GetStyleSheet(cssName);
		}
		return qViewer._queryViewerStyleSheet;
	}

	function GetStyleSheet(cssName) {
		var styleSheet;
		for (var i = 0; i < document.styleSheets.length; i++)
			if (document.styleSheets[i].href != null && document.styleSheets[i].href.indexOf(cssName) >= 0) {
				styleSheet = document.styleSheets[i];
				break;
			}
		return styleSheet;
	}

	function LoadColorsObj(colorsObj, styleSheet, rulePrefix) {
		var colorsCount = 0;
		for (var i = 0; i < styleSheet.cssRules.length; i++) {
			var rule = styleSheet.cssRules[i];
			if (rule.selectorText && rule.selectorText.indexOf(rulePrefix) == 0) {
				var key = rule.selectorText.replace(rulePrefix, "");
				colorsObj[key] = rule.style.fill;
				colorsCount++;
			}
			if (colorsCount == HIGHCHARTS_MAX_COLORS)
				break;
		}
	}

	function GetHighchartsDefaultColors(qViewer) {
		if (!qViewer._HighchartsDefaultColors) {
			qViewer._HighchartsDefaultColors = [];
			var colorsObj = {};
			var styleSheet;
			var rulePrefix;
			styleSheet = GetQueryViewerStyleSheet(qViewer);		// Inicializo con los colores default del QueryViewer
			rulePrefix = ".highcharts-color-";
			LoadColorsObj(colorsObj, styleSheet, rulePrefix);
			if (qViewer.Class != "") {
				styleSheet = GetThemeStyleSheet(qViewer);			// Sustituyo con los colores definidos en el tema
				rulePrefix = "." + qv.util.GetContainerControlClass(qViewer) + " " + ".highcharts-color-";
				LoadColorsObj(colorsObj, styleSheet, rulePrefix);
			}
			for (var i = 0; i < HIGHCHARTS_MAX_COLORS; i++)
				qViewer._HighchartsDefaultColors.push(colorsObj[i.toString()]);
		}
		return qViewer._HighchartsDefaultColors;
	}

	function GetColorStringFromHighchartsObject(qViewer, highchartsObject) {
		var classPrefix = "highcharts-color-";
		var colorIndex;
		var color;
		if (highchartsObject.className && highchartsObject.className.indexOf(classPrefix) == 0)
			colorIndex = parseInt(highchartsObject.className.replace(classPrefix, ""));
		else 
			colorIndex = highchartsObject.colorIndex;
		if (colorIndex < HIGHCHARTS_MAX_COLORS) {
			var defaultColors = GetHighchartsDefaultColors(qViewer);
			color = defaultColors[colorIndex];
		}
		else {
			color = HIGHCHARTS_CUSTOM_COLOR[colorIndex - HIGHCHARTS_MAX_COLORS];
			if (IsHexaColor(color))
				color = "#" + color;
		}
		return color;
	}

	function GetColorObject(colorStr) {
		return { IsDefault: false, Color: colorStr, ColorIndex: '-1' };
	}

	function GetNullColor() {
		return GetColorObject("");
	}

	function IsNullColor(color) {
		return color.IsDefault ? color.ColorIndex < 0 : color.Color == "";
	}

	function IsDefaultColor(color) {
		return color.IsDefault;
	}

	function IsHexaColor(colorStr) {
		return (colorStr.length === 6 && !isNaN(parseInt(colorStr, 16)));
	}

	function AddHighchartsCustomColor(qViewer, color) {

		var localColorIndex = HIGHCHARTS_CUSTOM_COLOR.indexOf(color);
		var globalColorIndex;
		if (localColorIndex < 0) {
			HIGHCHARTS_CUSTOM_COLOR.push(color);
			localColorIndex = HIGHCHARTS_CUSTOM_COLOR.length - 1;
			globalColorIndex = HIGHCHARTS_MAX_COLORS + localColorIndex;
			var prefix = IsHexaColor(color) ? "#" : "";
			var rule = "." + HIGHCHARTS_COLOR_PREFIX + globalColorIndex + " {fill: " + prefix + color + "; stroke: " + prefix + color + ";}";
			var themeStyleSheet = GetThemeStyleSheet(qViewer);
			themeStyleSheet.insertRule(rule, themeStyleSheet.cssRules.length);
		}
		else
			globalColorIndex = HIGHCHARTS_MAX_COLORS + localColorIndex;
		return globalColorIndex;
	}

	function SetHighchartsColor(qViewer, highchartsObject, color, colorIndexForDefaultColors) {
		if (!IsNullColor(color)) {
			var colorIndex;
			if (color.IsDefault)
				colorIndex = color.ColorIndex;
			else
				colorIndex = AddHighchartsCustomColor(qViewer, color.Color);
			if (colorIndexForDefaultColors)
				highchartsObject.colorIndex = colorIndex;
			else
				highchartsObject.className = HIGHCHARTS_COLOR_PREFIX + colorIndex;	// Para PlotBands, por ejemplo, no anda setear el colorIndex
		}
	}

	function AddHighchartsCSSRules(qViewer) {
		// Workaround por no poder hacer estos seteos mediante la propiedad className en el tooltip
		if (qViewer.RealChartType == "CircularGauge") {
			var themeStyleSheet = GetThemeStyleSheet(qViewer);
			var rule = "#" + qViewer.ContainerName + " .highcharts-tooltip-box {fill: none !important; stroke-width: 0 !important; }";
			themeStyleSheet.insertRule(rule, themeStyleSheet.cssRules.length);
		}
	}

	function getHighchartOptions(qViewer, chartSerie, serieIndex) {

		function getChartObject(qViewer, serieIndex) {
			var chart = {};
			chart.spacing = getSpacing(qViewer);
			if (!IsSplittedChart(qViewer)) {
				if (!IsTimelineChart(qViewer))
					chart.renderTo = qViewer.getContainerControl();
				else
					chart.renderTo = document.getElementById(centerId(qViewer.userControlId()));
			}
			else {
				var viewerId = qViewer.userControlId();
				var baseId;
				if (IsTimelineChart(qViewer))
					baseId = centerId(viewerId);
				else
					baseId = viewerId;
				chart.renderTo = document.getElementById(baseId + "_chart" + serieIndex.toString());
			}
			if (!IsCombinationChart(qViewer)) {
				chart.type = getChartType_forHightCharts(qViewer.RealChartType);
			}
			if (qViewer.RealChartType == "Radar" || qViewer.RealChartType == "FilledRadar" || qViewer.RealChartType == "PolarArea")
				chart.polar = true;
			else if (qViewer.RealChartType == "Column3D" || qViewer.RealChartType == "StackedColumn3D" || qViewer.RealChartType == "Column3DLine")
				chart.options3d = { enabled: true, alpha: 15, beta: 15, depth: 50, viewDistance: 25 };
			else if (qViewer.RealChartType == "Pie3D" || qViewer.RealChartType == "Doughnut3D")
				chart.options3d = { enabled: true, alpha: 45, beta: 0 };
			else if (IsTimelineChart(qViewer)) {
				chart.zoomType = 'x';
				chart.resetZoomButton = { theme: { display: 'none' } };
				chart.events = {};
				chart.events.selection = function (event) {
					selectionEventHandler(event);
				};
			}
			return chart;
		}

		function getNoCreditsObject() {
			var credits = { enabled: false };
			return credits;
		}

		function getLegendObject(qViewer) {
			var legend = { enabled: (qViewer.Chart.Series.DataFields.length > 1 && !IsSplittedChart(qViewer)) || IsSingleSerieChart(qViewer), margin: 0 };
			if (qViewer.RealChartType == "CircularGauge") {
				legend.labelFormatter = function () {
					var viewerId = this.chart.options.qv.viewerId;
					var qViewer = qv.collection[viewerId];
					return '<span style="text-weight:bold;color:' + GetColorStringFromHighchartsObject(qViewer, this.userOptions) + '">' + '█' + '</span> ' + this.name;
				};
				legend.symbolWidth = 0;
			}
			return legend;
		}

		function getTitleObject(qViewer, serieIndex) {
			var title;
			if (qViewer.Title == "")
				title = { text: null };
			else {
				var titleStr = (serieIndex == null || serieIndex == 0) ? qViewer.Title : null;
				title = { text: titleStr };
			}
			return title;
		}

		function getSubtitleObject(qViewer, chartSerie) {
			var subtitle = {};
			if (IsSplittedChart(qViewer) && (IsSingleSerieChart(qViewer) || qViewer.RealChartType == "CircularGauge")) {
				subtitle.text = chartSerie.Name;
				subtitle.floating = true;
				subtitle.align = "left";
				subtitle.verticalAlign = "middle";
			}
			return subtitle;
		}

		function getXAxisObject(qViewer, serieIndex) {
			xAxis = {};
			if (qViewer.RealChartType != "CircularGauge") {
				var isDatetimeXAxis = IsDatetimeXAxis(qViewer);
				if (qViewer.RealChartType != "Radar" && qViewer.RealChartType != "FilledRadar" && qViewer.RealChartType != "PolarArea" && qViewer.RealChartType != "LinearGauge" && qViewer.RealChartType != "Sparkline")
					xAxis.title = { text: XAxisTitle(qViewer) };
				else {
					if (qViewer.RealChartType == "Sparkline" && IsSplittedChart(qViewer))
						xAxis.title = { text: qViewer.Chart.Series.ByIndex[serieIndex].Name };
					xAxis.lineWidth = 0;
					if (qViewer.RealChartType == "LinearGauge" || qViewer.RealChartType == "Sparkline")
						xAxis.tickPositions = [];
					if (qViewer.RealChartType == "Radar" || qViewer.RealChartType == "FilledRadar")
						xAxis.tickmarkPlacement = "on";
					else
						xAxis.tickmarkPlacement = "between";
				}
				if (qViewer.RealChartType == "LinearGauge") {
					var i = 0;
					var widths;
					if (IsSplittedChart(qViewer))
						widths = linearGaugeWidths(1, 1);
					xAxis.plotBands = [];
					for (var serieName in qViewer.Chart.Series.ByName) {
						if (!IsSplittedChart(qViewer) || i == serieIndex) {
							var chartSerie = qViewer.Chart.Series.ByName[serieName];
							if (!IsSplittedChart(qViewer))
								widths = linearGaugeWidths(qViewer.Chart.Series.DataFields.length, i + 1);
							plotBand = {};
							var color;
							if (!IsNullColor(chartSerie.Color))
								color = chartSerie.Color;
							else
								color = chartSerie.Points[0].Color;
							SetHighchartsColor(qViewer, plotBand, color, false)
							plotBand.from = widths.LowerExtreme;
							plotBand.to = widths.UpperExtreme;
							xAxis.plotBands.push(plotBand);
						}
						i++;
					}
				}
				if (!isDatetimeXAxis)
					xAxis.categories = [];
				var anyCategoryLabel = false;
				for (i = 0; i < qViewer.Chart.Categories.Values.length; i++) {
					if (qViewer.Chart.Categories.Values[i].ValueWithPicture != "")
						anyCategoryLabel = true;
					if (!isDatetimeXAxis) {
						xAxis.categories[i] = qViewer.Chart.Categories.Values[i].ValueWithPicture;
					}
				}
				if (!isDatetimeXAxis) {
					xAxis.labels = {};
					xAxis.labels.enabled = anyCategoryLabel;
					if (qViewer.XAxisLabels == "Vertically" && !IsBarChart(qViewer) && !IsPolarChart(qViewer)) {
						xAxis.labels.rotation = 270;
						xAxis.labels.y = 5;
						xAxis.labels.align = "right";
					}
				}
				else {
					xAxis.type = 'datetime';
					xAxis.id = 'xaxis';
					if (XAxisDataType(qViewer) == "date") {
						xAxis.maxZoom = 10 * 24 * 3600 * 1000;
						if (qViewer.Chart.Categories.MaxValue != null && qViewer.Chart.Categories.MinValue != null) {
							var minDate = new gx.date.gxdate(qViewer.Chart.Categories.MinValue, "Y4MD");
							var maxDate = new gx.date.gxdate(qViewer.Chart.Categories.MaxValue, "Y4MD");
							if (maxDate.Value.getTime() - minDate.Value.getTime() < 10 * 24 * 3600 * 1000)
								xAxis.tickInterval = 24 * 3600 * 1000;
						}
					}
				}
				if (IsPolarChart(qViewer))
					xAxis.className = "highcharts-no-axis-line highcharts-yes-grid-line";		// Clases no estándar de Highcharts
				else if (qViewer.RealChartType == "Sparkline")
					xAxis.className = "highcharts-no-axis-line highcharts-no-grid-line";		// Clases no estándar de Highcharts
		}
			return xAxis;
		}

		function getYAxisObject(qViewer, chartSerie) {
			if (qViewer.RealChartType == "Sparkline")
				yAxis = { visible: false };
			else {
				var yAxisName;
				if (qViewer.RealChartType == "CircularGauge")
					yAxisName = null;
				else
					yAxisName = IsSplittedChart(qViewer) ? chartSerie.Name : YAxisTitle(qViewer);
				if (IsCombinationChart(qViewer) && !IsSplittedChart(qViewer)) {
					yAxis = [];
					yAxis[0] = { title: { text: yAxisName } };
					yAxis[1] = { title: { text: "" }, opposite: true };		// El eje secundario por ahora no es posible setearle titulo
				} else {
					yAxis = { title: { text: yAxisName } };
				}
				yAxis.plotLines = [];
				yAxis.plotBands = [];
				if (HasYAxis(qViewer)) {
					for (var i = 0; i < qViewer.Chart.PlotBands.length; i++) {
						var chartPlotBand = qViewer.Chart.PlotBands[i];
						if (chartSerie == null || chartSerie.Name == chartPlotBand.SeriesName) {
							if (chartPlotBand.From == chartPlotBand.To && chartPlotBand.From != null) {
								var plotLine = { value: chartPlotBand.From, width: 1, zIndex: 3 };
								SetHighchartsColor(qViewer, plotLine, chartPlotBand.Color, false);
								yAxis.plotLines.push(plotLine);
							}
							else {
								var plotBand = {};
								SetHighchartsColor(qViewer, plotBand, chartPlotBand.Color, false);
								plotBand.from = !chartPlotBand.From ? Number.MIN_VALUE : chartPlotBand.From;
								plotBand.to = !chartPlotBand.To ? Number.MAX_VALUE : chartPlotBand.To;
								yAxis.plotBands.push(plotBand);
							}
						}
					}
				}
				if (qViewer.RealChartType == "Radar" || qViewer.RealChartType == "FilledRadar" || qViewer.RealChartType == "PolarArea") {
					yAxis.min = 0;
					if (qViewer.RealChartType == "Radar" || qViewer.RealChartType == "FilledRadar")
						yAxis.gridLineInterpolation = "polygon";
					else
						yAxis.gridLineInterpolation = "circle";
				}
				if (IsGaugeChart(qViewer)) {
					yAxis.min = 0;
					yAxis.max = 0;
					for (var serieName in qViewer.Chart.Series.ByName) {
						if (!IsSplittedChart(qViewer) || serieName == chartSerie.Name) {
							var chartSerieAux = qViewer.Chart.Series.ByName[serieName];
							yAxis.max = Math.max(yAxis.max, 100 * chartSerieAux.MaximumValue / chartSerieAux.TargetValue);
						}
					}
					if (qViewer.RealChartType == "LinearGauge" || yAxis.max != 100) {
						var plotLine = {};
						plotLine.className = "highcharts-dashed-plot-line";		// Clase no estándar de Highcharts
						plotLine.value = 100;
						if (IsSplittedChart(qViewer) || qViewer.Chart.Series.DataFields.length == 1) {
							var cs = IsSplittedChart(qViewer) ? chartSerie : qViewer.Chart.Series.ByIndex[0];
							var y;
							var x;
							var align;
							if (qViewer.RealChartType == "LinearGauge") {
								y = -10;
								x = -5;
								align = "right";
							}
							else {
								y = 15;
								x = 0;
								align = "center";
							}
							plotLine.label = { text: cs.TargetValue, verticalAlign: 'bottom', rotation: 0, y: y, x: x, align: align };
						}
						yAxis.plotLines.push(plotLine);
					}
				}
				if (qViewer.RealChartType == "LinearGauge") {
					yAxis.className = "highcharts-no-axis-line highcharts-no-grid-line";		// Clases no estándar de Highcharts
					yAxis.labels = { enabled: false };
				} else if (qViewer.RealChartType == "CircularGauge") {
					yAxis.lineWidth = 0;
					yAxis.tickPositions = [];
				}
				if (gx.lang.gxBoolean(qViewer.XAxisIntersectionAtZero)) {
					var anyPositiveValue = false;
					var anyNegativeValue = false;
					for (var serieName in qViewer.Chart.Series.ByName) {
						var chartSerieAux = qViewer.Chart.Series.ByName[serieName];
						if (chartSerieAux.PositiveValues)
							anyPositiveValue = true;
						if (chartSerieAux.NegativeValues)
							anyNegativeValue = true;
					}
					if (!anyNegativeValue) {
						if (IsCombinationChart(qViewer) && !IsSplittedChart(qViewer)) {
							yAxis[0].min = 0;
							yAxis[1].min = 0;
						}
						else
							yAxis.min = 0;
					}
					if (!anyPositiveValue) {
						if (IsCombinationChart(qViewer) && !IsSplittedChart(qViewer)) {
							yAxis[0].max = 0;
							yAxis[1].max = 0;
						}
						else
							yAxis.max = 0;
					}
				}
			}
			return yAxis;
		}

		function getPlotOptionsObject(chartType, qViewer) {

			function LinearGaugePlotHeight(qViewer) {
				var marginBottom;
				if (IsSplittedChart(qViewer) || qViewer.Chart.Series.DataFields.length == 1)
					marginBottom = 23 * NumberOfCharts(qViewer);	// por el título del eje Y
				else
					marginBottom = 29;	// por la leyenda
				return qViewer.Height - marginBottom;
			}

			function getMarker(qViewer) {
				var marker = { radius: 1, symbol: "circle", states: { hover: { radius: 4 } } };
				if (qViewer.SelectionAllowed()) {
					marker.states.select = { radius: 5, lineWidth: 1 };
					if (qViewer.SelectionColor)
						marker.states.select.fillColor = qViewer.SelectionColor;
				}
				return marker;
			}

			var showvalues = gx.lang.gxBoolean(qViewer.ShowValues);
			var plotOptions = {};
			plotOptions.series = {};
			var selectionColor = IsCircularChart(qViewer) && !qViewer.SelectionColor ? "#CCCCCC" : qViewer.SelectionColor;
			if (qViewer.SelectionAllowed() && selectionColor)
				plotOptions.series.states = { select: { color: selectionColor } };
			plotOptions.series.events = {};
			if (qViewer.RealChartType == "CircularGauge") {
				plotOptions.series.dataLabels = {};
				plotOptions.series.dataLabels.enabled = (qViewer.Chart.Series.DataFields.length == 1 && gx.lang.gxBoolean(qViewer.ShowValues)) || IsSplittedChart(qViewer);
				plotOptions.series.dataLabels.y = 0;
				plotOptions.series.dataLabels.borderWidth = 0;
				plotOptions.series.dataLabels.formatter = function () {
					return CircularGaugeTooltipAndDataLabelFormatter(this, qViewer);
				}
				plotOptions.series.marker = { enabled: false };
			}
			else {
				if (showvalues) {
					plotOptions.series.dataLabels = {};
					plotOptions.series.dataLabels.enabled = true;
					plotOptions.series.dataLabels.connectorColor = '#000000'
					plotOptions.series.dataLabels.formatter = function () {
						return DataLabelFormatter(this, qViewer, showvalues);
					}
					if (qViewer.RealChartType == "LinearGauge")
						plotOptions.series.dataLabels.inside = true;
				}
			}
			if (IsSplittedChart(qViewer) && qViewer.RealChartType != "CircularGauge") {
				plotOptions.series.point = {};
				plotOptions.series.point.events = {};
				var highlightIfVisible = qViewer.RealChartType != "LinearGauge";
				plotOptions.series.point.events.mouseOver = function () { syncPoints(qViewer, this.series.chart.container, this.index, true, highlightIfVisible); };
				plotOptions.series.point.events.mouseOut = function () { syncPoints(qViewer, this.series.chart.container, this.index, false, highlightIfVisible); };
			}
			if (qViewer.ItemClick || qViewer.SelectionAllowed())
				plotOptions.series.events.click = onHighchartsItemClickEventHandler;	// Asocia el manejador para el evento click de la chart
			switch (chartType) {
				case "bar":
					plotOptions.bar = {};
					if (qViewer.RealChartType == "StackedBar") {
						plotOptions.series.stacking = 'normal';
						plotOptions.bar.stacking = 'normal';
					} else if (qViewer.RealChartType == "StackedBar100") {
						plotOptions.series.stacking = 'percent';
						plotOptions.bar.stacking = 'percent';
					}
					if (qViewer.RealChartType == "LinearGauge") {
						var widths = linearGaugeWidths(qViewer.Chart.Series.DataFields.length, 1);
						var width = widths.Width * LinearGaugePlotHeight(qViewer);
						plotOptions.bar.pointWidth = width;
						plotOptions.bar.pointPadding = 0;
						plotOptions.bar.groupPadding = 0;
						var minValue = Number.MAX_VALUE;
						for (var i = 0; i < qViewer.Chart.Series.DataFields.length; i++) {
							var chartSerie = qViewer.Chart.Series.ByIndex[i];
							var value = chartSerie.Points[0].Value / chartSerie.TargetValue;
							if (value < minValue)
								minValue = value;
						}
						var minLength = minValue * qViewer.Width;
						plotOptions.bar.borderRadius = Math.min(width / 2, minLength / 2);
					}
					break;
				case "column":
					plotOptions.column = {};
					if (qViewer.RealChartType == "StackedColumn" || qViewer.RealChartType == "StackedColumn3D" || qViewer.RealChartType == "PolarArea") {
						plotOptions.series.stacking = 'normal';
						plotOptions.column.stacking = 'normal';
					} else if (qViewer.RealChartType == "StackedColumn100") {
						plotOptions.series.stacking = 'percent';
						plotOptions.column.stacking = 'percent';
					}
					if (qViewer.RealChartType == "PolarArea") {
						plotOptions.column.pointPadding = 0;
						plotOptions.column.groupPadding = 0;
					}
					break;
				case "area":
					plotOptions.area = {};
					if (qViewer.RealChartType == "StepArea")
						plotOptions.area.step = "center";
					plotOptions.area.marker = getMarker(qViewer);
					if (qViewer.RealChartType == "StackedArea")
						plotOptions.area.stacking = 'normal';
					else if (qViewer.RealChartType == "StackedArea100")
						plotOptions.area.stacking = 'percent';
					break;
				case "areaspline":
					plotOptions.areaspline = {};
					plotOptions.areaspline.marker = getMarker(qViewer);
					break;
				case "line":
					plotOptions.line = {};
					plotOptions.line.marker = getMarker(qViewer);
					if (qViewer.RealChartType == "StepLine")
						plotOptions.line.step = "center";
					else if (qViewer.RealChartType == "StepTimeline")
						plotOptions.line.step = "left";
					if (IsTimelineChart(qViewer))
						plotOptions.series.connectNulls = true;		// Para el caso de la time se setea esta configuracion para que la Highcharts interpole los datos, evitando que se generen saltos (gaps) en la la linea graficada. Cuando se tienen datos faltantes para el eje x (fechas para las cuales no se obtuvieron datos)
					else if (qViewer.RealChartType == "StackedLine")
						plotOptions.line.stacking = 'normal';
					else if (qViewer.RealChartType == "StackedLine100")
						plotOptions.line.stacking = 'percent';
					break;
				case "spline":
					plotOptions.spline = {};
					plotOptions.spline.marker = getMarker(qViewer);
					break;
				case "pie":
					plotOptions.pie = {};
					if (qViewer.RealChartType == "Doughnut" || qViewer.RealChartType == "Doughnut3D")
						plotOptions.pie.innerSize = '35%';
					if (qViewer.RealChartType == "Pie3D" || qViewer.RealChartType == "Doughnut3D")
						plotOptions.pie.depth = 35;
					plotOptions.pie.dataLabels = { enabled: showvalues };
					plotOptions.pie.showInLegend = true;
					break;
				case "solidgauge":
					plotOptions.solidgauge = {};
					plotOptions.solidgauge.showInLegend = true;
					plotOptions.solidgauge.rounded = true;
					break;
				case "funnel":
					plotOptions.funnel = {};
					plotOptions.funnel.showInLegend = true;
					plotOptions.funnel.dataLabels = { enabled: showvalues };
					break;
				case "pyramid":
					plotOptions.pyramid = {};
					plotOptions.pyramid.showInLegend = true;
					plotOptions.pyramid.dataLabels = { enabled: showvalues };
					break;
			}
			return plotOptions;
		}

		function getTooltipObject(qViewer) {
			var tooltip = {};
			if (IsTimelineChart(qViewer)) {
				tooltip.borderRadius = 1;
				tooltip.shadow= true;
				tooltip.shared = true;
				tooltip.useHTML = false; //Hay un bug que hace que si esta en true se muestra el html por fuera del aréa del tooltip
				tooltip.formatter = function () {
					return DateTimeTooltipFormatter(this, false, qViewer.Chart.Series.ByName)
				}
			}
			else {
				if (qViewer.RealChartType == "StackedColumn100" || qViewer.RealChartType == "StackedBar100" || qViewer.RealChartType == "StackedArea100" || qViewer.RealChartType == "StackedLine100")
					tooltip.formatter = function () {
						return Stacked100TooltipFormatter(this);
					}
				else if (IsCircularChart(qViewer))
					tooltip.formatter = function () {
						return PieTooltipFormatter(this, qViewer.Chart.Series.ByName, IsSplittedChart(qViewer));
					}
				else if (qViewer.RealChartType == "CircularGauge") {
					tooltip.enabled = (qViewer.Chart.Series.DataFields.length > 1 || !gx.lang.gxBoolean(qViewer.ShowValues)) && !IsSplittedChart(qViewer);
					tooltip.formatter = function () {
						return CircularGaugeTooltipAndDataLabelFormatter(this, qViewer);
					};
					tooltip.positioner = function (labelWidth, labelHeight) {
						return { x: (this.chart.plotWidth - labelWidth) / 2, y: (this.chart.plotHeight) / 2 };
					}
				}
				else
					tooltip.formatter = function () {
						return TooltipFormatter(this, qViewer.Chart.Series.ByName, IsSplittedChart(qViewer) && !IsGaugeChart(qViewer));
					}
			}
			return tooltip;
		}

		function getSeriesObject(qViewer, serieIndex, groupOption) {

			function getSerieObject(qViewer, chartSerie, serieIndex, series, groupOption) {
				var serie = {};
				if (qViewer.ItemClick || qViewer.SelectionAllowed())
					serie.className = "highcharts-drilldown-point";
				if (IsTimelineChart(qViewer)) {
					serie.name = chartSerie.Name;
					serie.data = [];
					serie.turboThreshold = 0;
					if (!IsNullColor(chartSerie.Color))
						SetHighchartsColor(qViewer, serie, chartSerie.Color, true);
					var points = groupPoints(qViewer.Chart.Categories, chartSerie.Points, XAxisDataType(qViewer), chartSerie.Aggregation, groupOption);
					for (j = 0; j < points.length; j++) {
						var name = points[j].name;
						var xValue = points[j].x;
						var value = points[j].y;
						var date = new gx.date.gxdate(xValue, "Y4MD");
						serie.data[j] = { x: date.Value.getTime() - date.Value.getTimezoneOffset() * 60000, y: value, name: name };
						if (IsNullColor(chartSerie.Color))
							SetHighchartsColor(qViewer, serie.data[j], chartSerie.Points[j].Color, true);
					}
				}
				else {
					var widths;
					if (qViewer.RealChartType == "CircularGauge") {
						if (IsSplittedChart(qViewer))
							widths = circularGaugeWidths(1, 1);
						else
							widths = circularGaugeWidths(qViewer.Chart.Series.DataFields.length, serieIndex + 1);
					}
					serie.name = chartSerie.Name;
					serie.data = [];
					serie.turboThreshold = 0;
					if (!IsNullColor(chartSerie.Color)) {
						SetHighchartsColor(qViewer, serie, chartSerie.Color, true);
					}
					if ((qViewer.RealChartType == "Radar" || qViewer.RealChartType == "FilledRadar" || qViewer.RealChartType == "PolarArea"))
						serie.pointPlacement = (qViewer.RealChartType == "Radar" || qViewer.RealChartType == "FilledRadar" ? "on" : null);
					for (j = 0; j < chartSerie.Points.length; j++) {
						var value = chartSerie.Points[j].Value != null ? parseFloat(qv.util.trim(chartSerie.Points[j].Value).replace(",", ".")) : null;
						if (IsGaugeChart(qViewer))
							value = value / chartSerie.TargetValue * 100;
						var name = qViewer.Chart.Categories.Values[j].ValueWithPicture;
						serie.data[j] = {};
						serie.data[j].y = value;
						serie.data[j].name = IsGaugeChart(qViewer) ? "" : name;
						serie.data[j].id = serie.data[j].name;
						if (IsDatetimeXAxis(qViewer)) {
							var xValue = qViewer.Chart.Categories.Values[j].Value;
							var date = new gx.date.gxdate(xValue, "Y4MD");
							serie.data[j].x = date.Value.getTime() - date.Value.getTimezoneOffset() * 60000;
							serie.data[j].id = date;
						}
						if (qViewer.RealChartType == "CircularGauge") {
							serie.data[j].radius = (widths.UpperExtreme).toString() + '%';
							serie.data[j].innerRadius = (widths.LowerExtreme).toString() + '%';
						}
						if (qViewer.RealChartType == "CircularGauge") {
							var color;
							if (!IsNullColor(chartSerie.Color))
								color = chartSerie.Color;
							else
								color = chartSerie.Points[0].Color;
							SetHighchartsColor(qViewer, serie.data[j], color, true);
						}
						else if (IsNullColor(chartSerie.Color))
							SetHighchartsColor(qViewer, serie.data[j], chartSerie.Points[j].Color, true);
					}
				}
				return serie;
			}

			var series = [];
			var i = 0
			for (var serieName in qViewer.Chart.Series.ByName) {
				if (!IsSplittedChart(qViewer) || i == serieIndex) {
					var chartSerie = qViewer.Chart.Series.ByName[serieName];
					var serie = getSerieObject(qViewer, chartSerie, i, series, groupOption)
					var k = serieIndex != null ? serieIndex : i;
					if (IsCombinationChart(qViewer)) {
						if (k % 2 == 0) {
							serie.type = 'column';
							serie.yAxis = 0;
						}
						else {
							serie.type = 'line';
							serie.yAxis = IsSplittedChart(qViewer) ? 0 : 1;
						}
					}
					series.push(serie);
				}
				i++;
			}

			return series;

		}

		function getPaneObject(qViewer, serieIndex) {
			var pane = {};
			if (qViewer.RealChartType == "CircularGauge") {
				pane.background = [];
				var widths;
				if (IsSplittedChart(qViewer))
					widths = circularGaugeWidths(1, 1);
				var i = 0;
				for (var serieName in qViewer.Chart.Series.ByName) {
					if (!IsSplittedChart(qViewer) || i == serieIndex) {
						var chartSerie = qViewer.Chart.Series.ByName[serieName];
						var oneBackground = {};
						if (!IsSplittedChart(qViewer))
							widths = circularGaugeWidths(qViewer.Chart.Series.DataFields.length, i + 1);
						oneBackground.outerRadius = (widths.UpperExtreme).toString() + '%';
						oneBackground.innerRadius = (widths.LowerExtreme).toString() + '%';
						var color;
						if (!IsNullColor(chartSerie.Color))
							color = chartSerie.Color;
						else
							color = chartSerie.Points[0].Color;
						SetHighchartsColor(qViewer, oneBackground, color, false);
						oneBackground.borderWidth = 0;
						pane.background.push(oneBackground);
					}
					i++;
				}
			}
			return pane;
		}

		var groupOption = XAxisDataType(qViewer) == "date" ? "Days" : "Seconds";

		var options = {};
		options.qv = {};
		options.qv.viewerId = qViewer.userControlId(); // Almacena el identificador del control en las opciones de la grafica

		options.chart = getChartObject(qViewer, serieIndex);
		options.credits = getNoCreditsObject();
		options.legend = getLegendObject(qViewer);
		options.title = getTitleObject(qViewer, serieIndex);
		options.subtitle = getSubtitleObject(qViewer, chartSerie);
		options.pane = getPaneObject(qViewer, serieIndex);
		options.xAxis = getXAxisObject(qViewer, serieIndex);
		options.yAxis = getYAxisObject(qViewer, chartSerie);
		options.plotOptions = getPlotOptionsObject(options.chart.type, qViewer);
		options.tooltip = getTooltipObject(qViewer);
		options.series = getSeriesObject(qViewer, serieIndex, groupOption);

		return options;
	}

	function getAllHighchartAOptions(qViewer) {
		var arrOptions = [];
		if (!IsSplittedChart(qViewer)) {
			var options = getHighchartOptions(qViewer, null, null);
			arrOptions.push(options);
		}
		else {
			var serieIndex = 0
			for (var serieName in qViewer.Chart.Series.ByName) {
				var chartSerie = qViewer.Chart.Series.ByName[serieName];
				var options = getHighchartOptions(qViewer, chartSerie, serieIndex);
				arrOptions.push(options);
				serieIndex++;
			}
		}
		return arrOptions;
	}

	function renderChartServices(qViewer, xml1, xml2, time1, time2) {
		var xml1Encoded = gx.html.encode(xml1, true, true);
		var xml2Encoded = gx.html.encode(xml2, true, true);
		qViewer.AdjustSize();
		var buffer1 = "<div style=\"overflow:auto; border-right: silver thin solid; border-top: silver thin solid; border-left: silver thin solid; border-bottom: silver thin solid; width: " + qViewer.Width + "px; height: " + parseInt(qViewer.Height) / 2 + "px" + "\">" + xml1Encoded + "</div>";
		buffer1 += "Time: " + time1 / 1000 + " seconds";
		var buffer2 = "<div style=\"overflow:auto; border-right: silver thin solid; border-top: silver thin solid; border-left: silver thin solid; border-bottom: silver thin solid; width: " + qViewer.Width + "px; height: " + parseInt(qViewer.Height) / 2 + "px" + "\">" + xml2Encoded + "</div>";
		buffer2 += "Time: " + time2 / 1000 + " seconds";
		qViewer.setHtml(buffer1 + buffer2);
	}

	function GetDatumByDataField(qViewer, dataField) {
		for (var i = 0; i < qViewer.Metadata.Data.length; i++)
			if (qViewer.Metadata.Data[i].DataField == dataField)
				return qViewer.Metadata.Data[i];
	}

	function GetAxisByDataField(qViewer, dataField) {
		for (var i = 0; i < qViewer.Metadata.Axes.length; i++)
			if (qViewer.Metadata.Axes[i].DataField == dataField)
				return qViewer.Metadata.Axes[i];
	}

	function XAxisDataType(qViewer) {
		var cantRowsOrColumns = 0;
		var dataType = "";
		for (var i = 0; i < qViewer.Metadata.Axes.length; i++) {
			var axis = qViewer.Metadata.Axes[i];
			if (axis.AxisType == "Rows" || axis.AxisType == "Columns") {
				cantRowsOrColumns++;
				dataType = axis.DataType;
			}
		}
		if (cantRowsOrColumns == 1)
			return dataType;
		else
			return "character";		// Pues se concatenan los valores
	}

	function XAxisTitle(qViewer) {
		var xAxisTitle = "";
		if (qViewer.XAxisTitle == "")
			for (var i = 0; i < qViewer.Metadata.Axes.length; i++) {
				var axis = qViewer.Metadata.Axes[i];
				if (axis.AxisType == "Rows" || axis.AxisType == "Columns")
					xAxisTitle += (xAxisTitle == "" ? "" : ", ") + gx.getMessage(axis.Title);		// Se concatenan los títulos
			}
		else
			xAxisTitle = gx.getMessage(qViewer.XAxisTitle);
		return xAxisTitle;
	}

	function YAxisTitle(qViewer) {
		var yAxisTitle = "";
		if (qViewer.YAxisTitle == "") {
			if (qViewer.Chart.Series.DataFields.length == 1) {
				var fieldTitle = GetDatumByDataField(qViewer, qViewer.Chart.Series.DataFields[0]).Title;
				yAxisTitle = gx.getMessage(fieldTitle);
			}
		}
		else
			yAxisTitle = gx.getMessage(qViewer.YAxisTitle);
		return yAxisTitle;
	}

	function renderChart(qViewer) {
		var i = 0;
		var qvClass = qv.util.GetContainerControlClass(qViewer);
		if (qvClass != "")
			qv.util.SetUserControlClass(qViewer, qvClass);
		ProcessDataAndMetadata(qViewer);
		splitChartContainer(qViewer);
		var arrOptions = getAllHighchartAOptions(qViewer);
		AddHighchartsCSSRules(qViewer);
		setLanguageOptions();
		var HCCharts = [];
		for (var serie = 0; serie < arrOptions.length; serie++) {
			HCChart = new Highcharts.Chart(arrOptions[serie], HCFinishedLoadingCallback);
			HCCharts.push(HCChart);
		}
		qViewer.Charts = HCCharts;
		if (IsTimelineChart(qViewer))
			FillHeaderAndFooter(HCCharts, arrOptions);
	}

	function RenderChartAndSetAutoresize(qViewer) {
		qViewer.ForceChartRendering = true; // Esta variable es para forzar el dibujado de las gráficas con autoresize cuando se cambia alguna de sus propiedades (ver issue 26466)
		var container = qViewer.getContainerControl();
		if (!gx.lang.gxBoolean(qViewer.AutoResize) && qViewer.IntervalCheckChartSize == undefined) { // No tiene autoresize y no se lo acaban de sacar. Por lo tanto la dibujo
			container.style.height = qViewer.Height + "px";
			container.style.width = qViewer.Width + "px";
			renderChart(qViewer);
		}
		else {
			if (gx.lang.gxBoolean(qViewer.AutoResize) && qViewer.IntervalCheckChartSize == undefined) { // Tiene autoresize y se lo acaban de poner. Seteo el intervalo para que se chequee el tamaño cada 1 minuto
				var code;
				switch (qViewer.AutoResizeType) {
					case "Both":
						container.style.width = "100%";
						container.style.height = "100%";
						code = "try { qv.chart.checkChartSize(" + qViewer.me() + ") } catch (e) {}";
						qViewer.IntervalCheckChartSize = setInterval(code, 1000);
						break;
					case "Vertical":
						qViewer.getContainerControl().style.width = gx.dom.addUnits(qViewer.Width);
						break;
					case "Horizontal":
						qViewer.getContainerControl().style.height = gx.dom.addUnits(qViewer.Height);
						break;
				}
				code = "try { qv.chart.checkChartSize(" + qViewer.me() + ") } catch (e) { }";
				setTimeout(code, 0);
			} else if (!gx.lang.gxBoolean(qViewer.AutoResize) && qViewer.IntervalCheckChartSize != undefined) { // No tiene autoresize, pero tenía. Borro el intervalo para que no se actualice más el tamaño
				qViewer.IntervalCheckChartSize = clearInterval(qViewer.IntervalCheckChartSize);
			} else {
				code = "try { qv.chart.checkChartSize(" + qViewer.me() + ") } catch (e) { }";	// Tiene autoresize y no se lo sacaron. Dibujo la chart para que no demore a que se venza el intervalo
				setTimeout(code, 0);
			}
		}
	}

	// ------------------------------------------------------ Timeline ------------------------------------------------------

	var prevClickedZoomId = null
	var viewerId = null
	var TimelineHeaderHeight = 35;
	var TimelineFooterHeight = 50;

	function isNumeric(n) {
		return !isNaN(parseFloat(n)) && isFinite(n);
	}

	// Determina si el navegador es Microsoft Internet Explorer en una version anterior a la 9	
	function isOldIEf() {
		return gx.util.browser.isIE() && gx.util.browser.ieVersion() <= 8.0;
	}

	function getZoomId(z) {
		return (viewerId + "_Zoom_" + z + "m");
	}

	function getZoomControl(z) {
		if (isNumeric(z))
			return gx.dom.el(getZoomId(z));
		else //control id
			return gx.dom.el(z);
	}

	function changeZoomControlUnderline(z, decoration) {
		zoom = getZoomControl(z);
		if (zoom)
			zoom.style.textDecoration = decoration;
	}
	
	function selectZoom(z) {
		changeZoomControlUnderline(z, "underline");
	}

	function deselectZoom(z) {
		changeZoomControlUnderline(z, "none");
	}

	function triggerZoom(z) {
		zoom = getZoomControl(z);
		if (zoom)
			zoom.onclick();
		else
			if (z != 0) {		// Intento con un zoom más alejado
				var newZoom;
				switch (z) {
					case 12:
						newZoom = 6;
						break;
					case 6:
						newZoom = 3;
						break;
					case 3:
						newZoom = 2;
						break;
					case 2:
						newZoom = 1;
						break;
					case 1:
						newZoom = 0;
						break;
				}
				triggerZoom(newZoom);
			}
	}

	function hideZoom(z) {
		zoom = getZoomControl(z);
		if (zoom)
			zoom.style.display = "none";
	}

	function showZoom(z) {
		zoom = getZoomControl(z);
		if (zoom)
			zoom.style.display = "";
	}

	function getSelectedZoomFactor() {
		return parseInt(prevClickedZoomId.substring(0, prevClickedZoomId.length - 1).substring(prevClickedZoomId.indexOf("_Zoom_") + 6));
	}

	//Esta funcion se invoca mas arriba en el handler del evento de seleccion de la timeline
	function deselectActiveZoom() {
		deselectZoom(prevClickedZoomId);
	}

	function EnableDisableCompareControls(qViewerId, enabled) {
		gx.dom.el(qViewerId + "_options_compare_enable").disabled = !enabled;
		gx.dom.el(qViewerId + "_options_compare_text").disabled = !enabled;
		gx.dom.el(qViewerId + "_options_compare_text").style.opacity = (!enabled ? 0.5 : 1);
		gx.dom.el(qViewerId + "_options_compare_options").disabled = !enabled;
		gx.dom.el(qViewerId + "_options_compare_options").style.opacity = (!enabled ? 0.5 : 1);
	}

	function EnableCompareControls(qViewerId, enabled) {
		EnableDisableCompareControls(qViewerId, true);
	}

	function DisableCompareControls(qViewerId, enabled) {
		EnableDisableCompareControls(qViewerId, false);
	}

	var sliderCursorWidth = 10;
	var sliderClickedOffsetX = 0;
	var sliderClickedqViewerId = "";
	var sliderClickedPaddingLeft = 0;
	var sliderClickedPaddingRight = 0;
	var sliderClickedRangeWidth = 0;
	var sliderClickedContainerWidth = 0;
	var sliderResizingLeft = false;
	var sliderResizingRight = false;
	var sliderMovingBar = false;

	function optionsId(qViewerId) {
		return qViewerId + "_options";
	}

	function centerId(qViewerId) {
		return qViewerId + "_center";
	}

	function footerId(qViewerId) {
		return qViewerId + "_footer";
	}

	function footerSliderId(qViewerId) {
		return qViewerId + "_footer_slider";
	}

	function footerChartId(qViewerId) {
		return qViewerId + "_footer_chart";
	}

	function footerRangeId(qViewerId) {
		return qViewerId + "_footer_range";
	}

	function footerLeftCursorId(qViewerId) {
		return qViewerId + "_footer_left_cursor";
	}

	function footerRightCursorId(qViewerId) {
		return qViewerId + "_footer_right_cursor";
	}

	function footerCenterId(qViewerId) {
		return qViewerId + "_footer_center";
	}

	function InitializeSlider(qViewerId, minValue, maxValue) {
		minValue = setMinAndMax(minValue, 0, 100);
		maxValue = setMinAndMax(maxValue, 0, 100);
		var controlWidth = parseInt(qv.collection[qViewerId].Width);
		$("#" + footerId(qViewerId))
			.css("width", controlWidth.toString() + "px")
			.css("height", TimelineFooterHeight.toString() + "px");
		$("#" + footerChartId(qViewerId))
			.css("width", controlWidth.toString() + "px")
			.css("height", (TimelineFooterHeight-2).toString() + "px");

		var paddingLeft = Math.round(minValue * controlWidth / 100);
		var paddingRight = Math.round((100 - maxValue) * controlWidth / 100);
		// Fix: PaddingLeft y PaddingRight deben dejar lugar para los cursores. Esto hace que no se pueda llegar a un rango de tamaño cero nunca, pero queda feo si se solapan los cursores
		if (controlWidth - paddingLeft - paddingRight < 2 * sliderCursorWidth) {
			var pixelsToRemove = 2 * sliderCursorWidth - (controlWidth - paddingLeft - paddingRight);
			var pixelsToRemoveLeft;
			var pixelsToRemoveRight;
			if (pixelsToRemove % 2 == 0)
				pixelsToRemoveLeft = pixelsToRemove / 2;
			else
				pixelsToRemoveLeft = (pixelsToRemove + 1) / 2;
			pixelsToRemoveRight = pixelsToRemove - pixelsToRemoveLeft;
			paddingLeft -= pixelsToRemoveLeft;
			paddingRight -= pixelsToRemoveRight;
			if (paddingLeft < 0)
			{
				paddingRight += paddingLeft;
				paddingLeft = 0;
			}
			if (paddingRight < 0)
			{
				paddingLeft += paddingRight;
				paddingRight = 0;
			}
		}
		var width = controlWidth - paddingLeft - paddingRight;

		$("#" + footerSliderId(qViewerId))
			.css("width", width.toString() + "px")
			.css("height", TimelineFooterHeight.toString() + "px")
			.css("padding-left", paddingLeft.toString() + "px")
			.css("padding-right", paddingRight.toString() + "px");
		$("#" + footerRangeId(qViewerId))
			.css("width", width.toString() + "px")
			.css("height", TimelineFooterHeight.toString() + "px");
		$("#" + footerLeftCursorId(qViewerId))
			.css("width", sliderCursorWidth.toString() + "px")
			.css("height", TimelineFooterHeight.toString() + "px");
		$("#" + footerRightCursorId(qViewerId))
			.css("width", sliderCursorWidth.toString() + "px")
			.css("height", TimelineFooterHeight.toString() + "px");
		$("#" + footerCenterId(qViewerId))
			.css("width", (width - 2 * sliderCursorWidth).toString() + "px")
			.css("height", TimelineFooterHeight.toString() + "px")
			.css("left", sliderCursorWidth.toString() + "px");
	}

	function setMin(value, minValue)
	{
		return Math.max(value, minValue);
	}

	function setMax(value, maxValue) {
		return Math.min(value, maxValue);
	}

	function setMinAndMax(value, minValue, maxValue) {
		return setMax(setMin(value, minValue), maxValue);
	}

	function normalizedSliderOffset(qViewerId, event) {
		var paddingLeft = parseInt($("#" + footerSliderId(qViewerId)).css("padding-left"));
		var barWidth = parseInt($("#" + footerRangeId(qViewerId)).css("width"));
		var offsetX;
		if (event.originalEvent.touches)
			offsetX = event.originalEvent.touches[0].pageX - event.originalEvent.touches[0].target.offsetLeft;
		else
			offsetX = event.offsetX;
		switch (event.target.id) {
			case footerSliderId(qViewerId):
				return offsetX;
			case footerLeftCursorId(qViewerId):
				return offsetX + paddingLeft;
			case footerCenterId(qViewerId):
				return offsetX + paddingLeft;
			case footerRightCursorId(qViewerId):
				return offsetX + paddingLeft + barWidth - sliderCursorWidth;
		}
	}

	function attachSliderEvents(qViewerId) {

		function leftCursorMousedown(event) {
			event.preventDefault();
			sliderResizingLeft = true;
		}

		function rightCursorMousedown(event) {
			event.preventDefault();
			sliderResizingRight = true;
		}

		function centerMousedown(event) {
			event.preventDefault();
			if (!sliderResizingLeft && !sliderResizingRight)
				sliderMovingBar = true;
		}

		function sliderMousedown(event) {
			event.preventDefault();
			sliderClickedqViewerId = qViewerId;
			var slider = $("#" + footerSliderId(sliderClickedqViewerId));
			var range = $("#" + footerRangeId(sliderClickedqViewerId));
			var paddingLeft = parseInt(slider.css("padding-left"));
			sliderClickedOffsetX = normalizedSliderOffset(sliderClickedqViewerId, event);
			sliderClickedPaddingLeft = parseInt(slider.css("padding-left"));
			sliderClickedPaddingRight = parseInt(slider.css("padding-right"));
			sliderClickedContainerWidth = parseInt(slider.css("width"));
			sliderClickedRangeWidth = parseInt(range.css("width"));
		}

		function documentMouseup(event) {
			if (sliderMovingBar || sliderResizingRight || sliderResizingLeft) {
				var slider = $("#" + footerSliderId(sliderClickedqViewerId));
				var qViewer = qv.collection[sliderClickedqViewerId];
				var compare = gx.dom.el(sliderClickedqViewerId + '_options_compare_enable').checked;
				var controlWidth = parseInt(qViewer.Width);
				var containerId;
				var containers;
				if (IsTimelineChart(qViewer))
					containerId = centerId(qViewer.userControlId());
				else
					containerId = qViewer.getContainerControl().id;
				if (IsSplittedChart(qViewer))
					containers = $("[id^=" + containerId + "_chart]");
				else
					containers = $("#" + containerId);
				var charts = [];
				$.each(containers, function (index, div) {
					var chart = $("#" + div.id).highcharts();
					charts.push(chart);
				});
				var firstChart = charts[0];
				var paddingLeft = parseInt(slider.css("padding-left"));
				var paddingRight = parseInt(slider.css("padding-right"));
				var minPercent = 100 * paddingLeft / controlWidth;
				var maxPercent = 100 * (1 - paddingRight / controlWidth);
				if (minPercent == 0 && maxPercent == 100)
					$.each(charts, function (index, chart) {
						chart.zoomOut();
					});
				else {
					var extremes = firstChart.get('xaxis').getExtremes();
					var qvOptions = firstChart.options.qv;
					var minDate = qvOptions.dataMin + minPercent / 100 * (qvOptions.dataMax - qvOptions.dataMin);
					var maxDate = qvOptions.dataMin + maxPercent / 100 * (qvOptions.dataMax - qvOptions.dataMin);
					var redraw = (compare) ? false : true;
					$.each(charts, function (index, chart) {
						chart.get('xaxis').setExtremes(minDate, maxDate, redraw);
					});
				}
				if (compare)
					GroupAndCompareFunction(charts);
				if (sliderResizingRight || sliderResizingLeft) {
					deselectZoom(prevClickedZoomId);
					prevClickedZoomId = null;
				}
			}
			sliderMovingBar = false;
			sliderResizingLeft = false;
			sliderResizingRight = false;
		}

		function sliderMousemove(event) {
			if (sliderMovingBar || sliderResizingRight || sliderResizingLeft) {
				var increment = normalizedSliderOffset(sliderClickedqViewerId, event) - sliderClickedOffsetX;
				if (sliderResizingLeft)
					increment = setMax(increment, sliderClickedRangeWidth - 2 * sliderCursorWidth);
				else
					increment = setMax(increment, sliderClickedPaddingRight);
				if (sliderResizingRight)
					increment = setMin(increment, -sliderClickedRangeWidth + 2 * sliderCursorWidth);
				else
					increment = setMin(increment, -sliderClickedPaddingLeft)
				if (increment != 0) {
					var center = $("#" + footerCenterId(sliderClickedqViewerId));
					var slider = $("#" + footerSliderId(sliderClickedqViewerId));
					var range = $("#" + footerRangeId(sliderClickedqViewerId));
					if (sliderResizingLeft) {
						slider.css("padding-left", (sliderClickedPaddingLeft + increment).toString() + "px");
						range.css("width", (sliderClickedRangeWidth - increment).toString() + "px");
						center.css("width", (sliderClickedRangeWidth - 2 * sliderCursorWidth - increment).toString() + "px");
						slider.css("width", (sliderClickedContainerWidth - increment).toString() + "px");
					} else if (sliderResizingRight) {
						slider.css("padding-right", (sliderClickedPaddingRight - increment).toString() + "px");
						range.css("width", (sliderClickedRangeWidth + increment).toString() + "px");
						center.css("width", (sliderClickedRangeWidth - 2 * sliderCursorWidth + increment).toString() + "px");
						slider.css("width", (sliderClickedContainerWidth + increment).toString() + "px");
					} else {
						slider.css("padding-left", (sliderClickedPaddingLeft + increment).toString() + "px");
						slider.css("padding-right", (sliderClickedPaddingRight - increment).toString() + "px");
					}
				}

			}
		}

		var leftCursor = $("#" + footerLeftCursorId(qViewerId));
		var rightCursor = $("#" + footerRightCursorId(qViewerId));
		var center = $("#" + footerCenterId(qViewerId));
		var slider = $("#" + footerSliderId(qViewerId));
		var range = $("#" + footerRangeId(qViewerId));

		// Attachments for mouse events
		leftCursor.mousedown(function (event) {
			leftCursorMousedown(event);
		});
		rightCursor.mousedown(function (event) {
			rightCursorMousedown(event);
		});
		center.mousedown(function (event) {
			centerMousedown(event);
		});
		slider.mousedown(function (event) {
			sliderMousedown(event);
		});
		$(document).mouseup(function (event) {
			documentMouseup(event);
		});
		slider.mousemove(function (event) {
			sliderMousemove(event);
		});


		// Attachments for finger events
		leftCursor.on("touchstart", function (event) {
			leftCursorMousedown(event);
		});
		rightCursor.on("touchstart", function (event) {
			rightCursorMousedown(event);
		});
		center.on("touchstart", function (event) {
			centerMousedown(event);
		});
		slider.on("touchstart", function (event) {
			sliderMousedown(event);
		});
		$(document).on("touchend", function (event) {
			documentMouseup(event);
		});
		$(document).on("touchcancel", function (event) {
			documentMouseup(event);
		});
		slider.on("touchmove", function (event) {
			sliderMousemove(event);
		});

	}

	function footerHTML(qViewerId) {
		var html = '';
		html += '<div id="' + footerSliderId(qViewerId) + '" class="gx-qv-footer-slider">';
		html +=		'<div id="' + footerRangeId(qViewerId) + '" class="gx-qv-footer-range">';
		html +=			'<div id="' + footerLeftCursorId(qViewerId) + '" class="gx-qv-footer-left-cursor"></div>';
		html +=			'<div id="' + footerRightCursorId(qViewerId) + '" class="gx-qv-footer-right-cursor"></div>';
		html +=			'<div id="' + footerCenterId(qViewerId) + '" class="gx-qv-footer-center"></div>';
		html +=		'</div>';
		html +=	'</div>';
		html += '<div id="' + footerChartId(qViewerId) + '" class="gx-qv-footer-chart"></div>';
		return html;
	}

	function getTimelineFooterChartOptions(qViewer, arrOptions)
	{
		var containerId = footerChartId(qViewer.userControlId());
		var chartType = (qViewer.RealChartType == "SmoothTimeline" ? "spline" : "line");
		var step = qViewer.RealChartType == "StepTimeline" ? "left" : "";
		var series = [];
		if (!IsSplittedChart(qViewer))
			for (var i = 0; i < arrOptions[0].series.length; i++)
				series.push(arrOptions[0].series[i]);
		else {
			for (var i = 0; i < arrOptions.length; i++)
				series.push(arrOptions[i].series[0]);
		}
		return qv.chart.getSparklineChartOptions(qViewer, containerId, chartType, false, step, series);
	}

	function GroupAndCompareFunction(charts) {
		var firstChart = charts[0];
		var viewerId = firstChart.options.qv.viewerId;
		var qViewer = qv.collection[viewerId];

		// Chequea si esta marcado el chkbox que indica que se quiere comparar
		var compare = gx.dom.el(viewerId + "_options_compare_enable").checked;
		$.each(charts, function (index, chart) {
			chart.options.qv.comparing = compare;
		});

		// Obtiene el tipo de periodo contra el que se quiere comparar
		var extremes = firstChart.get('xaxis').getExtremes();
		if (extremes.userMin != undefined)
			extremes.min = extremes.userMin;	//Sin esto, la llamada a setextremes (con redraw en false) realizado en el zoom no actualiza el min hasta el próximo dibujado.
		if (extremes.userMax != undefined)
			extremes.max = extremes.userMax;	//Sin esto, la llamada a setextremes (con redraw en false) realizado en el zoom no actualiza el min hasta el próximo dibujado.

		if (compare) {

			var options = gx.dom.el(viewerId + "_options_compare_options").children;
			var selectedOptionValue;
			for (ind = 0; options[ind] != undefined && selectedOptionValue == undefined; ind++) {
				if (options[ind].selected) {
					selectedOptionValue = options[ind].value;
				}
			}
			var minDateCompare;
			var maxDateCompare;
			if (selectedOptionValue == 'PrevPeriod') {
				maxDateCompare = new Date(extremes.min);
				minDateCompare = new Date(extremes.min - (extremes.max - extremes.min));
			} else if (selectedOptionValue == 'PrevYear') {
				minDateCompare = new Date(extremes.min);
				minDateCompare = new Date(minDateCompare.setFullYear(minDateCompare.getFullYear() - 1));
				maxDateCompare = new Date(extremes.max);
				maxDateCompare = new Date(maxDateCompare.setFullYear(maxDateCompare.getFullYear() - 1));
			}
			minDateCompare = minDateCompare.getTime();
			maxDateCompare = maxDateCompare.getTime();

			hideZoom(viewerId + "_Zoom_0m");//Si esta habilitada la comparación oculto el zoom all
		}
		else
			showZoom(viewerId + "_Zoom_0m");

		// Elimina todas las series existentes de la grafica
		$.each(charts, function (index, chart) {
			var series_colorIndexes = []
			while (chart.series.length > 0) {
				if (!chart.options.qv.colorIndexesUsed) {
					series_colorIndexes.push(chart.series[0].colorIndex);
				}
				chart.series[0].remove(true)
			}
			if (!chart.options.qv.colorIndexesUsed) {
				chart.options.qv.colorIndexesUsed = series_colorIndexes;
			}
		});

		// Carga las series con los datos que correspondan
		var ns = 0
		for (var serieName in qViewer.Chart.Series.ByName) {
			var chartSerie = qViewer.Chart.Series.ByName[serieName];
			var chart;
			var serieColorIndex;
			if (IsSplittedChart(qViewer)) {
				chart = charts[ns];
				serieColorIndex = chart.options.qv.colorIndexesUsed[0];
			}
			else {
				chart = firstChart;
				serieColorIndex = chart.options.qv.colorIndexesUsed[ns];
			}

			// Serie con el periodo seleccionado por el usuario
			var serie1 = {};
			serie1.turboThreshold = 0;
			serie1.colorIndex = serieColorIndex;
			serie1.id = serieName + "1";
			serie1.name = serieName;
			serie1.data = [];

			if (compare) {
				// Serie con el periodo contra el que se va a comparar
				var serie2 = {};
				serie2.className = "highcharts-dashed-series-line";
				serie2.turboThreshold = 0;
				serie2.colorIndex = serieColorIndex;
				serie2.id = serieName + "2";
				serie2.name = serieName;
				serie2.data = [];
			}

			var points;
			var groupOption = document.getElementById(viewerId + "_options_group_options").value;
			points = groupPoints(qViewer.Chart.Categories, chartSerie.Points, XAxisDataType(qViewer), chartSerie.Aggregation, groupOption);

			for (i = 0; i < points.length; i++) {
				var value = points[i].y;
				var date = new gx.date.gxdate(points[i].x, "Y4MD");
				var name = points[i].name;
				var timeValue1 = date.Value.getTime() - date.Value.getTimezoneOffset() * 60000;
				var original_time_value = date.Value.getTime() - date.Value.getTimezoneOffset() * 60000;
				if (compare) {
					var addToSerie1 = false;
					var addToSerie2 = false;
					if (timeValue1 <= extremes.max && timeValue1 >= extremes.min) {
						addToSerie1 = true;
					}
					if (timeValue1 <= maxDateCompare && timeValue1 >= minDateCompare) {
						addToSerie2 = true;
						var tmpDate = new Date(timeValue1);
						var timeValue2;
						if (selectedOptionValue == "PrevPeriod") {
							if (chart.options.qv.predef_zoom == "1m") {
								timeValue2 = tmpDate.setMonth(tmpDate.getMonth() + 1);
							} else if (chart.options.qv.predef_zoom == "2m") {
								timeValue2 = tmpDate.setMonth(tmpDate.getMonth() + 2);
							} else if (chart.options.qv.predef_zoom == "3m") {
								timeValue2 = tmpDate.setMonth(tmpDate.getMonth() + 3);
							} else if (chart.options.qv.predef_zoom == "6m") {
								timeValue2 = tmpDate.setMonth(tmpDate.getMonth() + 6);
							} else if (chart.options.qv.predef_zoom == "12m") {
								timeValue2 = tmpDate.setFullYear(tmpDate.getFullYear() + 1);
							} else {
								timeValue2 += extremes.max - extremes.min;
							}
						} else if (selectedOptionValue == "PrevYear") {
							timeValue2 = tmpDate.setFullYear(tmpDate.getFullYear() + 1);
						}
					}
					if (addToSerie1) {
						var point = {};
						point.x = timeValue1;
						point.y = value;
						point.name = name;
						serie1.data.push(point);
					}
					if (addToSerie2) {
						var point = {};
						point.x = timeValue2;
						point.y = value;
						point.name = name;
						point.real_x = original_time_value;
						serie2.data.push(point);
					}
				} else {
					serie1.data.push({ x: timeValue1, y: value, name: name });
				}
			}

			chart.addSeries(serie1);
			if (compare) {
				chart.addSeries(serie2);
			}
			ns++;
		}

	}

	function getSuitableZoomFactor(points, maxPoints) {
		if (points.length < maxPoints)
			return 0;
		else {
			var maxValue = points[points.length - 1].x;
			var minValue = points[points.length - maxPoints].x;
			var cantMeses = (maxValue - minValue) / 1000 / 3600 / 24 / (365 / 12);
			if (cantMeses <= 1)
				return 1;
			else if (cantMeses <= 2)
				return 2;
			else if (cantMeses <= 3)
				return 3;
			else if (cantMeses <= 6)
				return 6;
			else
				return 12;
		}
	}

	function FillHeaderAndFooter(charts, arrOptions)
	{

		function GetZoomItemHtml(text, id) {
			return GetHeaderItem('<a id="' + id + '" style="cursor:pointer">' + text + '</a>', true, true);
		}

		function GetHeaderItem(html, paddingLeft, paddingRight) {
			return '<div style="display:table-cell;' + (paddingLeft ? 'padding-left:3px;' : '') + (paddingRight ? 'padding-right:3px;' : '') + '">' + html + '</div>';
		}

		function GetHeaderHtml(qViewer, include1m, include2m, include3m, include6m, include1y, showYears, showSemesters, showQuarters, showMonths, showWeeks, showHours, showMinutes) {
			var qViewerId = qViewer.userControlId();
			var header_html = '<div class="QVTimelineHeader" style="display:table"><div style="display:table-row">' + GetHeaderItem(gx.getMessage("GXPL_QViewerJSChartZoom"), true, true);

			// Zoom
			if (include1m) {
				header_html += GetZoomItemHtml(gx.getMessage("GXPL_QViewerJSChartZoomLevelToOneMonth"), qViewerId + "_Zoom_1m");
				if (include2m) {
					header_html += GetZoomItemHtml(gx.getMessage("GXPL_QViewerJSChartZoomLevelToTwoMonth"), qViewerId + "_Zoom_2m");
					if (include3m) {
						header_html += GetZoomItemHtml(gx.getMessage("GXPL_QViewerJSChartZoomLevelToThreeMonth"), qViewerId + "_Zoom_3m");
						if (include6m) {
							header_html += GetZoomItemHtml(gx.getMessage("GXPL_QViewerJSChartZoomLevelToSixMonth"), qViewerId + "_Zoom_6m");
							if (include1y) {
								header_html += GetZoomItemHtml(gx.getMessage("GXPL_QViewerJSChartZoomLevelToOneYear"), qViewerId + "_Zoom_12m");
							}
						}
					}
				}
			}
			header_html += GetZoomItemHtml(gx.getMessage("GXPL_QViewerJSChartZoomLevelToAll"), qViewerId + "_Zoom_0m");

			// Filler
			header_html += '<div style="display:table-cell;width:100%"></div>';

			// Group by
			header_html += GetHeaderItem('<span id="' + optionsId(qViewerId) + '_groupby_text" style="white-space:nowrap">' + gx.getMessage("GXPL_QViewerGroupBy") + '</span>', false, true);
			header_html += GetHeaderItem(GetGroupHtml(qViewer, showYears, showSemesters, showQuarters, showMonths, showWeeks, showHours, showMinutes), false, true);

			// Compare to
			header_html += GetHeaderItem('<input id="' + optionsId(qViewerId) + '_compare_enable" type="checkbox" style="vertical-align:sub">', true, true);
			header_html += GetHeaderItem('<span id="' + optionsId(qViewerId) + '_compare_text" style="white-space:nowrap">' + gx.getMessage("GXPL_QViewerCompareWith") + '</span>', false, true);
			header_html += GetHeaderItem('<select id="' + optionsId(qViewerId) + '_compare_options">' + '<option value="PrevPeriod">' + gx.getMessage("GXPL_QViewerPreviousPeriod") + '</span></option>' + '<option value="PrevYear">' + gx.getMessage("GXPL_QViewerPreviousYear") + '</option>' + '</select>', false, true);
			header_html += '</div></div>';

			return header_html;
		}

		function GetGroupOptionHtml(value, selected, text) {
			return '<option value="' + value + '"' + (selected ? " selected" : "") + '>' + text + '</option>';
		}

		function GetGroupHtml(qViewer, showYears, showSemesters, showQuarters, showMonths, showWeeks, showHours, showMinutes) {
			var group_html = "";
			if (XAxisDataType(qViewer) == "datetime") {
				group_html += GetGroupOptionHtml("Seconds", qViewer._groupOption == "Seconds", gx.getMessage("GXPL_QViewerSeconds"));
				if (showMinutes) {
					group_html += GetGroupOptionHtml("Minutes", qViewer._groupOption == "Minutes", gx.getMessage("GXPL_QViewerMinutes"));
					if (showHours) {
						group_html += GetGroupOptionHtml("Hours", qViewer._groupOption == "Hours", gx.getMessage("GXPL_QViewerHours"));
					}
				}
			}
			if (showDays || XAxisDataType(qViewer) == "date") {
				group_html += GetGroupOptionHtml("Days", qViewer._groupOption == "Days", gx.getMessage("GXPL_QViewerDays"));
				if (showWeeks) {
					group_html += GetGroupOptionHtml("Weeks", qViewer._groupOption == "Weeks", gx.getMessage("GXPL_QViewerWeeks"));
					if (showMonths) {
						group_html += GetGroupOptionHtml("Months", qViewer._groupOption == "Months", gx.getMessage("GXPL_QViewerMonths"));
						if (showQuarters) {
							group_html += GetGroupOptionHtml("Quarters", qViewer._groupOption == "Quarters", gx.getMessage("GXPL_QViewerQuarters"));
							if (showSemesters) {
								group_html += GetGroupOptionHtml("Semesters", qViewer._groupOption == "Semesters", gx.getMessage("GXPL_QViewerSemesters"));
								if (showYears) {
									group_html += GetGroupOptionHtml("Years", qViewer._groupOption == "Years", gx.getMessage("GXPL_QViewerYears"));
								}
							}
						}
					}
				}
			}
			var qViewerId = qViewer.userControlId();
			group_html = '<select id="' + optionsId(qViewerId) + '_group_options">' + group_html + '</select>';
			return group_html;
		}

		// Crea un nuevo div conteniendo los links para hacer zoom predefenidos programaticamente.
		var firstChart = charts[0];
		viewerId = firstChart.options.qv.viewerId;
		var qViewer = qv.collection[viewerId];
		var divOptions = document.getElementById(optionsId(viewerId));
		var divFooter = document.getElementById(footerId(viewerId));

		var extremes = firstChart.get('xaxis').getExtremes();
		var winTime = extremes.dataMax - extremes.dataMin;
		$.each(charts, function (index, chart) {
			chart.options.qv.dataMax = extremes.dataMax;
			chart.options.qv.dataMin = extremes.dataMin;
		});
		var moreThanOneMonth = winTime > 30.42 * 24 * 3600 * 1000;
		var moreThanTwoMonths = winTime > 60.83 * 24 * 3600 * 1000;
		var moreThanThreeMonths = winTime > 91.25 * 24 * 3600 * 1000;
		var moreThanSixMonths = winTime > 182.5 * 24 * 3600 * 1000;
		var moreThanOneYear = winTime > 365 * 24 * 3600 * 1000;


		qViewer._groupOption = qViewer._groupOption || (XAxisDataType(qViewer) == "date" ? "Days" : "Seconds")

		var minDate = new gx.date.gxdate('');
		var maxDate = new gx.date.gxdate('');
		minDate.Value.setTime(extremes.dataMin + minDate.Value.getTimezoneOffset() * 60000);
		maxDate.Value.setTime(extremes.dataMax + maxDate.Value.getTimezoneOffset() * 60000);

		var showYears = true;
		var showSemesters = true;
		var showQuarters = true;
		var showMonths = true;
		var showWeeks = true;
		var showDays = true;
		var showHours = true;
		var showMinutes = true;

		if (gx.date.year(minDate) == gx.date.year(maxDate)) {
			showYears = false;
			if (!(gx.date.month(minDate) <= 6 && gx.date.month(maxDate) >= 7)) {
				showSemesters = false;
				if (!((gx.date.month(minDate) <= 3 && gx.date.month(maxDate) >= 4) || (gx.date.month(minDate) <= 6 && gx.date.month(maxDate) >= 7) || (gx.date.month(minDate) <= 9 && gx.date.month(maxDate) >= 10))) {
					showQuarters = false;
					if (gx.date.month(minDate) == gx.date.month(maxDate)) {
						showMonths = false;
						if ((gx.date.day(minDate) - gx.date.dow(minDate)) == (gx.date.day(maxDate) - gx.date.dow(maxDate))) {
							showWeeks = false;
							if (gx.date.day(minDate) == gx.date.day(maxDate)) {
								showDays = false;
								if (gx.date.hour(minDate) == gx.date.hour(maxDate)) {
									showHours = false;
									if (gx.date.minute(minDate) == gx.date.minute(maxDate)) {
										showMinutes = false;
									}
								}
							}
						}
					}
				}
			}
		}


		divOptions.innerHTML = GetHeaderHtml(qViewer, moreThanOneMonth, moreThanTwoMonths, moreThanThreeMonths, moreThanSixMonths, moreThanOneYear, showYears, showSemesters, showQuarters, showMonths, showWeeks, showHours, showMinutes);
		divFooter.innerHTML = footerHTML(viewerId);
		attachSliderEvents(viewerId);

		////////////////////////////////////////////////////////////////////////////////////////////
		// Event handlers para las opciones de "compare to past"
		////////////////////////////////////////////////////////////////////////////////////////////

		gx.dom.el(divOptions.id + '_compare_enable').onclick = function () {
			GroupAndCompareFunction(charts);
		};
		gx.dom.el(divOptions.id + '_compare_options').onchange = function () {
			if (gx.dom.el(divOptions.id + '_compare_enable').checked) {
				GroupAndCompareFunction(charts);
			}
		};
		gx.dom.el(divOptions.id + '_group_options').onchange = function () {
			GroupAndCompareFunction(charts);
		};
		var doZoom = function (zoomFactor) {

			var compare = gx.dom.el(divOptions.id + '_compare_enable').checked;

			if (zoomFactor > 0) {

				var minDate, maxDate;
				var extremes = firstChart.get('xaxis').getExtremes();
				maxDate = extremes.dataMax;
				minDate = maxDate - 30.417 * zoomFactor * 24 * 3600 * 1000; //30.4166 = 365dias/12meses
				var redraw = (compare) ? false : true;
				$.each(charts, function (index, chart) {
					chart.get('xaxis').setExtremes(minDate, maxDate, redraw);
				});
				var qvOptions = firstChart.options.qv;
				var minPercent = (minDate - qvOptions.dataMin) / (qvOptions.dataMax - qvOptions.dataMin) * 100;
				var maxPercent = (maxDate - qvOptions.dataMin) / (qvOptions.dataMax - qvOptions.dataMin) * 100;
				InitializeSlider(firstChart.options.qv.viewerId, minPercent, maxPercent);

				EnableCompareControls(firstChart.options.qv.viewerId, true);
			}
			else //Zoom All
			{
				$.each(charts, function (index, chart) {
					chart.zoomOut();
				});
				DisableCompareControls(firstChart.options.qv.viewerId, false);
			}

			//Resalto el selector de zoom seleccionado
			deselectZoom(prevClickedZoomId);
			selectZoom(this.id);

			$.each(charts, function (index, chart) {
				chart.options.qv.predef_zoom = zoomFactor + "m";
			});
			prevClickedZoomId = this.id;

			//Si esta habilitada la comparación recalculo las fechas
			if (compare)
				GroupAndCompareFunction(charts);

		};

		////////////////////////////////////////////////////////////////////////////////////////////		
		// Carga los links de zooms con los event handlers necesarios
		// Zoom automatico a x meses		
		var array_zooms = [0, 1, 2, 3, 6, 12];
		for (var index in array_zooms) {
			var x = array_zooms[index];
			var zoomXm = gx.dom.el(viewerId + "_Zoom_" + x + "m");
			if (zoomXm) {
				zoomXm.onclick = doZoom.closure(zoomXm, [x]);
			}
		}
		////////////////////////////////////////////////////////////////////////////////////////////

		// Al final, se muestra un rango de fechas que despliegue un máximo de 20 puntos
		var zoomFactor = getSuitableZoomFactor(firstChart.series[0].points, 20);
		triggerZoom(zoomFactor);

		var footerChartOptions = getTimelineFooterChartOptions(qViewer, arrOptions);
		var FooterHCChart = new Highcharts.Chart(footerChartOptions);	// Agrego la gráfica del footer


	}

	//This function execute when the Highcharts object is finished loading and rendering.
	function HCFinishedLoadingCallback(chart) {

		var qViewer = qv.collection[chart.options.qv.viewerId];
		if (qViewer.ItemClick || qViewer.SelectionAllowed()) {
			if (!IsTimelineChart(qViewer))
				// Cambia el cursor
				$("g.highcharts-xaxis-labels > text").css({ cursor: "pointer" });
			// Asocia el manejador para el evento click sobre el eje x
			jQuery.each(chart.xAxis[0].ticks, function (tick_index, tick) {
				if (tick && tick.label) {
					tick.label.on("click", function (event) {
						onHighchartsXAxisClickEventHandler(event, tick_index, tick, chart);
					});
				}
			});
		}

	}

	// ---------------------------------------------------- end Timeline ----------------------------------------------------

	return {

		tryToRenderChart: function (qViewer) {
			var errMsg = "";

			// Ejecuto el primer servicio y verifico que no haya habido error
			var d1 = new Date();
			var t1 = d1.getTime();

			qViewer.xml = qViewer.xml || {};

			qv.services.GetRecordsetCacheKeyIfNeeded(qViewer, function (resText, qViewer) {			// Servicio GetRecordsetCacheKey
				var newRecordsetCacheKey = false;
				if (resText != qViewer.xml.recordsetCacheKey) {
					qViewer.xml.recordsetCacheKey = resText;
					newRecordsetCacheKey = true;
				}
				qv.util.hideActivityIndicator(qViewer);
				if (!qv.util.anyError(resText) || qViewer.debugServices) {
					if (newRecordsetCacheKey)
						qv.services.parseRecordsetCacheKeyXML(qViewer);

					qv.services.GetMetadataIfNeeded(qViewer, function (resText, qViewer) {			// Servicio GetMetadata
						var newMetadata = false;
						if (resText != qViewer.xml.metadata) {
							qViewer.xml.metadata = resText;
							newMetadata = true;
						}
						qv.util.hideActivityIndicator(qViewer);
						var d2 = new Date();
						var t2 = d2.getTime();
						if (!qv.util.anyError(resText) || qViewer.debugServices) {
							if (newMetadata)
								qv.services.parseMetadataXML(qViewer);

							qv.services.GetDataIfNeeded(qViewer, function (resText, qViewer) {		// Servicio GetData
								var newData = false;
								if (resText != qViewer.xml.data) {
									qViewer.xml.data = resText;
									newData = true;
								}
								qv.util.hideActivityIndicator(qViewer);
								var d3 = new Date();
								var t3 = d3.getTime();
								if (!qv.util.anyError(resText) || qViewer.debugServices) {
									if (newData)
										qv.services.parseDataXML(qViewer);
									if (qViewer.debugServices)
										renderChartServices(qViewer, qViewer.xml.metadata, qViewer.xml.data, t2 - t1, t3 - t2);
									else
										RenderChartAndSetAutoresize(qViewer);
								} else {
									// Error en el servicio GetData
									errMsg = qv.util.getErrorFromText(resText);
									qv.util.renderError(qViewer, errMsg);
								}
							});

						}
						else {
							// Error en el servicio GetMetadata
							errMsg = qv.util.getErrorFromText(resText);
							qv.util.renderError(qViewer, errMsg);
						}
					});

				}
				else {
					// Error en el servicio GetRecordsetCachekey
					errMsg = qv.util.getErrorFromText(resText);
					qv.util.renderError(qViewer, errMsg);
				}
			});

		},

		GetMetadataChart: function (qViewer) {
			return qv.util.GetDesigntimeMetadata(qViewer);
		},

		GetDataChart: function (qViewer) {
			return qViewer.xml.data;
		},

		checkChartSize: function (qViewer) {
			if (qViewer.LastHeight == undefined) qViewer.LastHeight = parseInt(qv.util.fixSize(qViewer.Height));
			if (qViewer.LastWidth == undefined) qViewer.LastWidth = parseInt(qv.util.fixSize(qViewer.Width));
			var container = qViewer.getContainerControl();
			var height = (container.offsetHeight != 0 ? container.offsetHeight : container.parentNode.offsetHeight);
			var width = (container.offsetWidth != 0 ? container.offsetWidth : container.parentNode.offsetWidth);
			if (qViewer.ForceChartRendering || (height != qViewer.LastHeight && width != qViewer.LastWidth)) {
				qViewer.Height = height.toString();
				qViewer.Width = width.toString();
				qViewer.LastHeight = height;
				qViewer.LastWidth = width;
				renderChart(qViewer);
				qViewer.ForceChartRendering = false;
			}
		},

		getSparklineChartOptions: function (qViewer, containerId, chartType, noBackground, step, series) {
			var options = {};
			options.chart = {};
			options.chart.renderTo = containerId;
			options.chart.margin = 0;
			options.chart.type = chartType;
			if (noBackground)
				options.chart.className = "highcharts-no-background";		// Clase no estándar de Highcharts
			options.title = {};
			options.title.text = "";
			options.credits = {};
			options.credits.enabled = false;
			options.xAxis = {};
			options.xAxis.visible = false;
			options.yAxis = {};
			options.yAxis.visible = false;
			options.legend = {};
			options.legend.enabled = false;
			options.tooltip = {};
			options.tooltip.enabled = false;
			options.plotOptions = {};
			options.plotOptions.series = {};
			options.plotOptions.series.animation = false;
			options.plotOptions.series.enableMouseTracking = false;
			options.plotOptions.series.lineWidth = 1;
			options.plotOptions.series.shadow = false;
			options.plotOptions.series.states = {};
			options.plotOptions.series.states.hover = {};
			options.plotOptions.series.states.hover.lineWidth = 1;
			options.plotOptions.series.marker = {};
			options.plotOptions.series.marker.radius = 0;
			options.plotOptions.series.marker.states = {};
			options.plotOptions.series.marker.states.hover = {};
			options.plotOptions.series.marker.states.hover.radius = 2;
			if (step != "")
				options.plotOptions.series.step = step;
			options.series = []
			for (var i = 0; i < series.length; i++)
				options.series.push(series[i]);
			return options;
		},

		IsDatetimeXAxis: function (qViewer) {
			return IsDatetimeXAxis(qViewer);
		},

		Select: function (qViewer, selection) {
			var rowsToSelect = GetRowsToSelect(qViewer, selection);
			if (rowsToSelect.length > 0)
				SelectChartsPoints(qViewer.Charts, rowsToSelect);
			else
				DeselectChartsPoints(qViewer.Charts);
		},

		Deselect: function (qViewer, selection) {
			DeselectChartsPoints(qViewer.Charts);
		}

	}

})()
/* END OF FILE - ..\Sources\Chart.src.js - */
/* START OF FILE - ..\Sources\Card.src.js - */
qv.card = (function () {

	function renderCardServices(qViewer, xml1, xml2, time1, time2) {
		var xml1Encoded = gx.html.encode(xml1, true, true);
		var xml2Encoded = gx.html.encode(xml2, true, true);
		qViewer.AdjustSize();
		var buffer1 = "<div style=\"overflow:auto; border-right: silver thin solid; border-top: silver thin solid; border-left: silver thin solid; border-bottom: silver thin solid; width: " + qViewer.Width + "px; height: " + parseInt(qViewer.Height) / 2 + "px" + "\">" + xml1Encoded + "</div>";
		buffer1 += "Time: " + time1 / 1000 + " seconds";
		var buffer2 = "<div style=\"overflow:auto; border-right: silver thin solid; border-top: silver thin solid; border-left: silver thin solid; border-bottom: silver thin solid; width: " + qViewer.Width + "px; height: " + parseInt(qViewer.Height) / 2 + "px" + "\">" + xml2Encoded + "</div>";
		buffer2 += "Time: " + time2 / 1000 + " seconds";
		qViewer.setHtml(buffer1 + buffer2);
	}

	function aggregateData(data, rows) {

		function aggregateDatum(datum, rows) {
			var currentYValues = [];
			var currentYQuantities = [];
			var firstColor = "";
			for (var i = 0; i < rows.length; i++) {
				var row = rows[i];
				var yValue;
				var yQuantity;
				if (datum.Aggregation == "Count") {
					yValue = 0;		// No se utiliza
					yQuantity = parseFloat(row[datum.DataField]);
				}
				else {
					if (datum.Aggregation == "Average") {
						yValue = parseFloat(row[datum.DataField + "_N"]);
						yQuantity = parseFloat(row[datum.DataField + "_D"]);
					}
					else {
						yValue = parseFloat(row[datum.DataField]);
						yQuantity = 1;
					}
				}
				currentYValues.push(yValue);
				currentYQuantities.push(yQuantity);
			}
			return qv.util.aggregate(datum.Aggregation, currentYValues, currentYQuantities).toString();
		}

		var newRow = {};
		for (var i = 0; i < data.length; i++) {
			var datum = data[i];
			var aggValue = aggregateDatum(datum, rows);
			newRow[datum.DataField] = aggValue;
		}
		return newRow;
	}

	function selectStyle(datum, value) {

		if (datum.ConditionalStyles.length == 0)
			return qv.util.css.parseStyle(datum.Style);
		else {
			for (var i = 0; i < datum.ConditionalStyles.length; i++) {
				var conditionalStyle = datum.ConditionalStyles[i];
				if (qv.util.satisfyStyle(value, conditionalStyle))
					return (qv.util.css.parseStyle(conditionalStyle.StyleOrClass));
			}
			return qv.util.css.parseStyle(datum.Style);
		}
	}

	function analizeSeries(qViewer, datum, xDataField, xDataType) {

		function analizeMain(start, regressionStart, xDataField, yDataField, rows, xDataType) {
			var minValue = null;
			var maxValue = null;
			var minWhen = null;
			var maxWhen = null;
			var chartSeriesData = [];
			var lr = {AnyTrend: false};
			if (xDataField != "") {
				var end = rows.length - 1;
				var n = 0;
				var sum_x = 0;
				var sum_y = 0;
				var sum_xy = 0;
				var sum_xx = 0;
				var sum_yy = 0;
				var regressionStartDate = null;
				var regressionStartY = null;
				for (var i = start; i <= end; i++) {
					if (rows[i][xDataField] != undefined && rows[i][yDataField] != undefined) {
						n += 1;
						var date = new gx.date.gxdate(rows[i][xDataField], "Y4MD");
						var yValue = parseFloat(rows[i][yDataField]);
						chartSeriesData.push({ x: date.Value.getTime() - date.Value.getTimezoneOffset() * 60000, y: yValue });
						if (minValue == null && maxValue == null) {
							minValue = yValue;
							maxValue = yValue;
							minWhen = rows[i][xDataField];
							maxWhen = rows[i][xDataField];
						}
						else {
							if (yValue > maxValue) {
								maxWhen = rows[i][xDataField];
								maxValue = yValue;
							}
							if (yValue < minValue) {
								minWhen = rows[i][xDataField];
								minValue = yValue;
							}
						}
						if (i >= regressionStart) {
							if (regressionStartDate == null && regressionStartY == null) {
								regressionStartDate = date;
								regressionStartY = yValue;
							}
							// Cambio de variable para no manejar números tan grandes
							var x = xDataType == "date" ? gx.date.daysDiff(date, regressionStartDate) : gx.date.secDiff(date, regressionStartDate);
							var y = yValue - regressionStartY;
							sum_x += x;
							sum_y += y;
							sum_xy += x * y;
							sum_xx += x * x;
							sum_yy += y * y;
						}
					}
				}
				lr.AnyTrend = n > 1;
				lr.Slope = (n * sum_xy - sum_x * sum_y) / (n * sum_xx - sum_x * sum_x);
				lr.Intercept = (sum_y - lr.Slope * sum_x) / n;
				lr.R2 = Math.pow((n * sum_xy - sum_x * sum_y) / Math.sqrt((n * sum_xx - sum_x * sum_x) * (n * sum_yy - sum_y * sum_y)), 2);
			}
			var data = {};
			data.LinearRegression = lr;
			data.MinValue = minValue;
			data.MinWhen = minWhen;
			data.MaxValue = maxValue;
			data.MaxWhen = maxWhen;
			data.ChartSeriesData = chartSeriesData;
			return data;
		}

		function getRegressionStartDateStr(trendPeriod, xDataType) {
			var endDate = gx.date.now();
			var startDate;
			switch (trendPeriod) {
				case "LastYear":
					startDate = gx.date.addyr(endDate, -1);
					break;
				case "LastSemester":
					startDate = gx.date.addmth(endDate, -6);
					break;
				case "LastQuarter":
					startDate = gx.date.addmth(endDate, -3);
					break;
				case "LastMonth":
					startDate = gx.date.addmth(endDate, -1);
					break;
				case "LastWeek":
					startDate = gx.date.dtadd(endDate, -86400 * 7);
					break;
				case "LastDay":
					startDate = gx.date.dtadd(endDate, -86400);
					break;
				case "LastHour":
					startDate = gx.date.dtadd(endDate, -3600);
					break;
				case "LastMinute":
					startDate = gx.date.dtadd(endDate, -60);
					break;
				case "LastSecond":
					startDate = gx.date.dtadd(endDate, -1);
					break;
			}
			var startDateStr = qv.util.dateToString(startDate, xDataType == "datetime");
			return startDateStr;
		}

		// Busco un eje de tipo date o datetime
		var data = {};
		var noTrend = { AnyTrend: false };
		var regressionStart;
		if (qViewer.IncludeTrend) {
			if (qViewer.TrendPeriod == "SinceTheBeginning" || qViewer.TrendPeriod == "")
				regressionStart = 0;
			else {
				var trendStartDate = getRegressionStartDateStr(qViewer.TrendPeriod, xDataType);
				regressionStart = qViewer.Data.Rows.length - 1;
				for (var i = qViewer.Data.Rows.length - 2; i >= 0; i--) {
					var currentDate = qViewer.Data.Rows[i][xDataField];
					if (currentDate < trendStartDate)
						break;
					regressionStart = i;
				}
			}
		}
		else
			regressionStart = qViewer.Data.Rows.length - 1;	// Start = End para que no calcule regresión lineal
		var start = qViewer.IncludeSparkline || qViewer.IncludeMaxAndMin ? 0 : regressionStart;
		data = analizeMain(start, regressionStart, xDataField, datum.DataField, qViewer.Data.Rows, xDataType);
		return data;
	}

	function setEventData(eventData, qViewer, name, allRows) {

		function getContext(qViewer, allRows) {

			function getElementValues(dataField, rows, allRows) {
				var values = [];
				if (allRows)
					for (var i = 0; i < rows.length; i++)
						values.push(rows[i][dataField]);
				else
					values.push(rows[rows.length - 1][dataField]);
				return values;
			}

			var context = [];
			for (var i = 0; i < qViewer.Metadata.Axes.length; i++) {
				var element = {};
				element.Name = qViewer.Metadata.Axes[i].Name;
				element.Values = getElementValues(qViewer.Metadata.Axes[i].DataField, qViewer.Data.Rows, allRows);
				context.push(element);
			}
			for (var i = 0; i < qViewer.Metadata.Data.length; i++) {
				var element = {};
				element.Name = qViewer.Metadata.Data[i].Name;
				element.Values = getElementValues(qViewer.Metadata.Data[i].DataField, qViewer.Data.Rows, allRows);
				context.push(element);
			}
			return context;
		}

		var datum = null;
		for (var i = 0; i < qViewer.Metadata.Data.length; i++) {
			if (qViewer.Metadata.Data[i].Name == name) {
				datum = qViewer.Metadata.Data[i];
				break;
			}
		}
		if (datum != null) {
			eventData.Name = datum.Name;
			eventData.Axis = 'Data';
			var lastRow;
			if (allRows)
				lastRow = aggregateData(qViewer.Metadata.Data, qViewer.Data.Rows);
			else
				lastRow = qViewer.Data.Rows[qViewer.Data.Rows.length - 1];
			eventData.Value = lastRow[datum.DataField];
			eventData.Context = getContext(qViewer, allRows);
		}
	}

	function sparklineChartId(qViewerId, i) {
		return qViewerId + "_card_sparkline_" + i;
	}

	function GetSparklineOptions(qViewer, seriesData, i) {
		var containerId = sparklineChartId(qViewer.userControlId(), i);
		var series = [{ data: seriesData }];
		return qv.chart.getSparklineChartOptions(qViewer, containerId, "line", true, "", series);
	}

	function getMinMaxTable(text1, text2, text3) {
		var cellStyle = "text-align:center; padding: 0px 5px 0px 5px";
		var html = '<table><tbody>';
		html += '<tr><td style="' + cellStyle + '"><span class="qv-card-max-and-min-value">' + text1 + '</span></td></tr>';
		html += '<tr><td style="' + cellStyle + '"><span class="qv-card-max-and-min-time">' + text2 + '</span></td></tr>';
		html += '<tr><td style="' + cellStyle + '"><span class="qv-card-max-and-min-title">' + text3 + '</span></td></tr>';
		html += '</tbody></table>';
		return html;
	}

	function age(dateStr) {
		var date = new gx.date.gxdate(dateStr, "Y4MD");
		var now = gx.date.now();
		var seconds = gx.date.secDiff(now, date);
		return qv.util.seconsdToText(seconds);
	}

	function valueOrPercentage(qViewer, valueStr, datum, decimals) {
		var value;
		var percentage;
		if (valueStr != "") {
			value = qv.util.formatNumber(parseFloat(valueStr), decimals, datum.Picture, false);
			percentage = qv.util.formatNumber(parseFloat(valueStr * 100 / datum.TargetValue), 2, "ZZZZZZZZZZZZZZ9.99", false) + '%';
		}
		else {
			value = "";
			percentage = "";
		}
		switch (qViewer.ShowDataAs) {
			case "Values":
				return value;
			case "Percentages":
				return percentage;
			case "ValuesAndPercentages":
				return value + ' (' + percentage + ')';
			default:
				return value;
		}
	}

	function renderCard(qViewer) {
		qViewer.AdjustSize();
		var anyRows = qViewer.Data.Rows.length > 0;
		var aggregateRows = true;
		var xDataField = "";
		var xDataType;
		for (var i = 0; i < qViewer.Metadata.Axes.length; i++) {
			var axis = qViewer.Metadata.Axes[i];
			if (axis.DataType == "date" || axis.DataType == "datetime") {	// Si hay alguna fecha no agrego los datos porque voy a querer ver la evolución a lo largo del tiempo
				aggregateRows = false;
				xDataField = axis.DataField;
				xDataType = axis.DataType;
				break;
			}
		}
		var lastRow;
		if (anyRows) {
			if (aggregateRows)
				lastRow = aggregateData(qViewer.Metadata.Data, qViewer.Data.Rows);
			else
				lastRow = qViewer.Data.Rows[qViewer.Data.Rows.length - 1];
		}
		var styleSize = gx.lang.gxBoolean(qViewer.AutoResize) ? '' : ' style="height:' + qViewer.Height + 'px; width:' + qViewer.Width + 'px"';
		var qvClass = qv.util.GetContainerControlClass(qViewer);
		var classStr = qvClass != "" ? ' class="' + qvClass + '"' : "";
		var buffer = '<table' + classStr + styleSize + '><tbody><tr><td align="center">';		// Contenedor del UC
		buffer += '<table style="white-space: nowrap; ' + (qViewer.Orientation == "Horizontal" ? "width" : "height") + ': 100%' + '"><tbody>';		// Para todos los indicadores en la card
		buffer += qViewer.Orientation == "Horizontal" ? "<tr>" : "";
		var dataAllSeries = [];
		for (var i = 0; i < qViewer.Metadata.Data.length; i++) {
			var datum = qViewer.Metadata.Data[i];
			var numberFormat = qv.util.ParseNumericPicture(datum.DataType, datum.Picture);
			var decimals = numberFormat.DecimalPrecision;
			var value;
			var valueStr;
			var ageStr;
			if (anyRows) {
				value = lastRow[datum.DataField];
				valueStr = valueOrPercentage(qViewer, lastRow[datum.DataField], datum, decimals);
				ageStr = age(lastRow[xDataField]);
			}
			else {
				value = "";
				valueStr = "";
				ageStr = "";
			}
			var trendDivTag;
			var sparklineRowTag;
			var maxAndMinRowTag;
			if ((gx.lang.gxBoolean(qViewer.IncludeTrend) || gx.lang.gxBoolean(qViewer.IncludeSparkline) || gx.lang.gxBoolean(qViewer.IncludeMaxAndMin)) && anyRows) {
				var data = analizeSeries(qViewer, datum, xDataField, xDataType);
				dataAllSeries.push(data);
				if (data.LinearRegression.AnyTrend) {
					var trendClass;
					if (data.LinearRegression.Slope > 0)
						trendClass = "qv-card-upward-trend";
					else if (data.LinearRegression.Slope < 0)
						trendClass = "qv-card-downward-trend";
					else
						trendClass = "qv-card-sideward-trend";
					var trendTooltip;
					if (qViewer.TrendPeriod == "")
						trendTooltip = gx.getMessage("GXPL_QViewerSinceTheBeginningTrend");
					else
						trendTooltip = gx.getMessage("GXPL_QViewer" + qViewer.TrendPeriod + "Trend");
					trendDivTag = '<div class="' + trendClass + '" style="margin-' + (qViewer.IncludeSparkline ? "left" : "right") + ':5px; width:16px; height: 16px" title="' + trendTooltip + '" />';
				}
				else
					trendDivTag = '';
				sparklineRowTag = '';
				if (qViewer.IncludeSparkline && xDataField != "") {
					sparklineRowTag += '<tr><td>';
					sparklineRowTag += '<table style="width:100%"><tbody><tr>';
					sparklineRowTag += '<td style="width:1000%"><div id="' + sparklineChartId(qViewer.userControlId(), i) + '" style="height:50px;width:100%;min-width:100px"></div></td>';
					sparklineRowTag += '<td style="width:0%">' + trendDivTag + '</td>';
					sparklineRowTag += '</tr></tbody></table>';
					sparklineRowTag += '</td></tr>';
				}
				maxAndMinRowTag = '';
				if (qViewer.IncludeMaxAndMin && xDataField != "") {
					maxAndMinRowTag += '<tr><td align="center"><table><tbody><tr>';
					maxAndMinRowTag += '<td>' + getMinMaxTable(valueOrPercentage(qViewer, data.MinValue, datum, decimals), age(data.MinWhen), gx.getMessage("GXPL_QViewerAggregatorsMinimum")) + '</td>';
					maxAndMinRowTag += '<td>' + getMinMaxTable(valueOrPercentage(qViewer, data.MaxValue, datum, decimals), age(data.MaxWhen), gx.getMessage("GXPL_QViewerAggregatorsMaximum")) + '</td>';
					maxAndMinRowTag += '</tr></tbody></table></td></tr>';
				}
			}
			else {
				trendDivTag = '';
				sparklineRowTag = '';
				maxAndMinRowTag = '';
			}
			var style = selectStyle(datum, value);
			var elementValueClass = "qv-card-element-value";
			if (style.indexOf(":") < 0) {	// El style es en realidad el nombre de una clase
				elementValueClass = style;
				style = "";
			}
			var onClick = "";
			var onDblClick = "";
			if (qViewer.ItemClick) {
				style += (style == '' ? '' : '; ') + 'cursor:pointer';
				if (qViewer.ItemClick)
					onClick = 'onclick="qv.card.fireItemClickEvent(' + qViewer.me() + ', \'' + datum.Name + '\', ' + aggregateRows + ');"';
			}
			buffer += qViewer.Orientation == "Vertical" ? '<tr>' : "";
			var cellStyle = i < qViewer.Metadata.Data.length - 1 ? ' style="padding-' + (qViewer.Orientation == "Horizontal" ? "right" : "bottom") + ': 20px"' : '';
			buffer += '<td align="center"' + cellStyle + '>';
			buffer += '<table><tbody>';
			buffer += '<tr><td align="center"><table><tbody><tr><td>' + (qViewer.IncludeSparkline ? "" : trendDivTag) + '</td><td align="center"><span class="' + elementValueClass + '" style="' + style + '"' + onClick + onDblClick + '>' + valueStr + '</span></td></tr>' + (xDataField != "" ? '<tr><td colspan=2 style="text-align:center"><span class="qv-card-element-time">' + ageStr + '</span></td></tr>' : "") + '</tbody></table></td></tr>';
			buffer += '<tr><td align="center"><span class="qv-card-element-title">' + datum.Title + '</span></td></tr>';
			buffer += sparklineRowTag;
			buffer += maxAndMinRowTag;
			buffer += '</tbody></table>';
			buffer += '</td>';
			buffer += qViewer.Orientation == "Vertical" ? '</tr>' : "";
		}
		buffer += qViewer.Orientation == "Horizontal" ? "</tr>" : "";
		buffer += '</tbody></table>';		// Para todos los indicadores en la card
		buffer += '</td></tr></tbody></table>';		// Contenedor del UC
		qViewer.setHtml(buffer);
		if (qViewer.IncludeSparkline && xDataField != "" && anyRows) {
			for (var i = 0; i < qViewer.Metadata.Data.length; i++) {
				var sparklineOptions = GetSparklineOptions(qViewer, dataAllSeries[i].ChartSeriesData, i);
				var SparklineHCChart = new Highcharts.Chart(sparklineOptions);
			}
		}
	}

	return {

		tryToRenderCard: function (qViewer) {
			var errMsg = "";

			// Ejecuto el primer servicio y verifico que no haya habido error
			var d1 = new Date();
			var t1 = d1.getTime();

			qViewer.xml = qViewer.xml || {};

			if (qViewer.IntervalCheckChartSize != undefined)
				qViewer.IntervalCheckChartSize = clearInterval(qViewer.IntervalCheckChartSize);			// Elimino el intervalo seteado cuando estuvo configurado como Chart con Autoresize

			qv.services.GetRecordsetCacheKeyIfNeeded(qViewer, function (resText, qViewer) {				// Servicio GetRecordsetCacheKey
				var newRecordsetCacheKey = false;
				if (resText != qViewer.xml.recordsetCacheKey) {
					qViewer.xml.recordsetCacheKey = resText;
					newRecordsetCacheKey = true;
				}
				qv.util.hideActivityIndicator(qViewer);
				if (!qv.util.anyError(resText) || qViewer.debugServices) {
					if (newRecordsetCacheKey)
						qv.services.parseRecordsetCacheKeyXML(qViewer);

					qv.services.GetMetadataIfNeeded(qViewer, function (resText, qViewer) {				// Servicio GetMetadata
						var newMetadata = false;
						if (resText != qViewer.xml.metadata) {
							qViewer.xml.metadata = resText;
							newMetadata = true;
						}
						qv.util.hideActivityIndicator(qViewer);
						var d2 = new Date();
						var t2 = d2.getTime();
						if (!qv.util.anyError(resText) || qViewer.debugServices) {
							if (newMetadata)
								qv.services.parseMetadataXML(qViewer);

							qv.services.GetDataIfNeeded(qViewer, function (resText, qViewer) {			// Servicio GetData
								var newData = false;
								if (resText != qViewer.xml.data) {
									qViewer.xml.data = resText;
									newData = true;
								}
								qv.util.hideActivityIndicator(qViewer);
								var d3 = new Date();
								var t3 = d3.getTime();
								if (!qv.util.anyError(resText) || qViewer.debugServices) {
									if (newData)
										qv.services.parseDataXML(qViewer);
									if (qViewer.debugServices)
										renderCardServices(qViewer, qViewer.xml.metadata, qViewer.xml.data, t2 - t1, t3 - t2);
									else
										renderCard(qViewer);
								} else {
									// Error en el servicio GetData
									errMsg = qv.util.getErrorFromText(resText);
									qv.util.renderError(qViewer, errMsg);
								}
							});

						}
						else {
							// Error en el servicio GetMetadata
							errMsg = qv.util.getErrorFromText(resText);
							qv.util.renderError(qViewer, errMsg);
						}
					});

				}
				else {
					// Error en el servicio GetRecordsetCachekey
					errMsg = qv.util.getErrorFromText(resText);
					qv.util.renderError(qViewer, errMsg);
				}
			});

		},

		GetMetadataCard: function (qViewer) {
			return qv.util.GetDesigntimeMetadata(qViewer);
		},

		GetDataCard: function (qViewer) {
			return qViewer.xml.data;
		},

		fireItemClickEvent: function (qViewer, name, allRows) {
			setEventData(qViewer.ItemClickData, qViewer, name, allRows);
			qViewer.ItemClick();
		}

	}

})()
/* END OF FILE - ..\Sources\Card.src.js - */
