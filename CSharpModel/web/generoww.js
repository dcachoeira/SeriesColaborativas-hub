/*!   GeneXus C# 15_0_9-121631 on 9/20/2018 19:46:13.76
*/
gx.evt.autoSkip=!1;gx.define("generoww",!1,function(){var i,f,u,r,n,e,t;this.ServerClass="generoww";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV27ColumnsSelector=gx.fn.getControlValue("vCOLUMNSSELECTOR");this.AV56Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV27ColumnsSelector=gx.fn.getControlValue("vCOLUMNSSELECTOR");this.AV56Pgmname=gx.fn.getControlValue("vPGMNAME")};this.s152_client=function(){this.DDO_GENERONOMEContainer.SortedStatus=this.AV13OrderedDsc?"DSC":"ASC"};this.e11282_client=function(){return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE",!1,null,!0,!0)};this.e12282_client=function(){return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",!1,null,!0,!0)};this.e13282_client=function(){return this.executeServerEvent("DDO_GENERONOME.ONOPTIONCLICKED",!1,null,!0,!0)};this.e14282_client=function(){return this.executeServerEvent("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED",!1,null,!0,!0)};this.e15282_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e19282_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e20282_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];i=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,28,29,30,31,32,34,35,36,37,38,39,40,42,43,44,46,49,50,51];this.GXLastCtrlId=51;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",33,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"generoww",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px",0,"px","Novo registro",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);f=this.GridContainer;f.addBitmap("&Update","vUPDATE",34,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");f.addSingleLineEdit(48,35,"GENEROID","Id","","GeneroId","int",0,"px",18,18,"right",null,[],48,"GeneroId",!1,0,!1,!1,"Attribute",1,"WWColumn hidden-xs");f.addSingleLineEdit(49,36,"GENERONOME","","","GeneroNome","svchar",0,"px",40,40,"left",null,[],49,"GeneroNome",!0,0,!1,!1,"Attribute",1,"WWColumn");f.addCheckBox(50,37,"GENEROINATIVO","Inativo","","GeneroInativo","boolean","true","false",null,!1,!1,0,"px","WWColumn hidden-xs");this.GridContainer.emptyText="";this.setGrid(f);this.DVPANEL_TABLEHEADERContainer=gx.uc.getNew(this,10,0,"BootstrapPanel","DVPANEL_TABLEHEADERContainer","Dvpanel_tableheader","DVPANEL_TABLEHEADER");u=this.DVPANEL_TABLEHEADERContainer;u.setProp("Class","Class","","char");u.setProp("Enabled","Enabled",!0,"boolean");u.setProp("Width","Width","100%","str");u.setProp("Height","Height","100","str");u.setProp("AutoWidth","Autowidth",!1,"bool");u.setProp("AutoHeight","Autoheight",!0,"bool");u.setProp("Cls","Cls","PanelNoHeader","str");u.setProp("ShowHeader","Showheader",!0,"bool");u.setProp("Title","Title","Opções","str");u.setProp("Collapsible","Collapsible",!0,"bool");u.setProp("Collapsed","Collapsed",!1,"bool");u.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");u.setProp("IconPosition","Iconposition","left","str");u.setProp("AutoScroll","Autoscroll",!1,"bool");u.setProp("Visible","Visible",!0,"bool");u.setC2ShowFunction(function(n){n.show()});this.setUserControl(u);this.GRIDPAGINATIONBARContainer=gx.uc.getNew(this,41,34,"DVelop_DVPaginationBar","GRIDPAGINATIONBARContainer","Gridpaginationbar","GRIDPAGINATIONBAR");r=this.GRIDPAGINATIONBARContainer;r.setProp("Enabled","Enabled",!0,"boolean");r.setProp("Class","Class","PaginationBar","str");r.setProp("ShowFirst","Showfirst",!1,"bool");r.setProp("ShowPrevious","Showprevious",!0,"bool");r.setProp("ShowNext","Shownext",!0,"bool");r.setProp("ShowLast","Showlast",!1,"bool");r.setProp("PagesToShow","Pagestoshow",5,"num");r.setProp("PagingButtonsPosition","Pagingbuttonsposition","Right","str");r.setProp("PagingCaptionPosition","Pagingcaptionposition","Left","str");r.setProp("EmptyGridClass","Emptygridclass","PaginationBarEmptyGrid","str");r.setProp("SelectedPage","Selectedpage","","char");r.setProp("RowsPerPageSelector","Rowsperpageselector",!0,"bool");r.setDynProp("RowsPerPageSelectedValue","Rowsperpageselectedvalue",10,"num");r.setProp("RowsPerPageOptions","Rowsperpageoptions","5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50","str");r.setProp("First","First","First","str");r.setProp("Previous","Previous","WWP_PagingPreviousCaption","str");r.setProp("Next","Next","WWP_PagingNextCaption","str");r.setProp("Last","Last","Last","str");r.setProp("Caption","Caption","Página <CURRENT_PAGE> de <TOTAL_PAGES>","str");r.setProp("EmptyGridCaption","Emptygridcaption","WWP_PagingEmptyGridCaption","str");r.setProp("RowsPerPageCaption","Rowsperpagecaption","WWP_PagingRowsPerPage","str");r.addV2CFunction("AV44GridCurrentPage","vGRIDCURRENTPAGE","SetCurrentPage");r.addC2VFunction(function(n){n.ParentObject.AV44GridCurrentPage=n.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",n.ParentObject.AV44GridCurrentPage)});r.addV2CFunction("AV45GridPageCount","vGRIDPAGECOUNT","SetPageCount");r.addC2VFunction(function(n){n.ParentObject.AV45GridPageCount=n.GetPageCount();gx.fn.setControlValue("vGRIDPAGECOUNT",n.ParentObject.AV45GridPageCount)});r.setProp("RecordCount","Recordcount","","str");r.setProp("Page","Page","","str");r.setProp("Visible","Visible",!0,"bool");r.setC2ShowFunction(function(n){n.show()});r.addEventHandler("ChangePage",this.e11282_client);r.addEventHandler("ChangeRowsPerPage",this.e12282_client);this.setUserControl(r);this.DDO_GENERONOMEContainer=gx.uc.getNew(this,45,34,"BootstrapDropDownOptions","DDO_GENERONOMEContainer","Ddo_generonome","DDO_GENERONOME");n=this.DDO_GENERONOMEContainer;n.setProp("Class","Class","","char");n.setProp("Enabled","Enabled",!0,"boolean");n.setProp("Icon","Icon","","char");n.setProp("Caption","Caption","","str");n.setProp("Tooltip","Tooltip","WWP_TSColumnOptions","str");n.setProp("Cls","Cls","ColumnSettings","str");n.setProp("ActiveEventKey","Activeeventkey","","char");n.setDynProp("FilteredText_set","Filteredtext_set","","char");n.setProp("FilteredText_get","Filteredtext_get","","char");n.setProp("FilteredTextTo_set","Filteredtextto_set","","char");n.setProp("FilteredTextTo_get","Filteredtextto_get","","char");n.setDynProp("SelectedValue_set","Selectedvalue_set","","char");n.setProp("SelectedValue_get","Selectedvalue_get","","char");n.setProp("SelectedText_set","Selectedtext_set","","char");n.setProp("SelectedText_get","Selectedtext_get","","char");n.setProp("GAMOAuthToken","Gamoauthtoken","","char");n.setProp("TitleControlAlign","Titlecontrolalign","Automatic","str");n.setProp("DropDownOptionsType","Dropdownoptionstype","GridTitleSettings","str");n.setDynProp("TitleControlIdToReplace","Titlecontrolidtoreplace","","str");n.setProp("IncludeSortASC","Includesortasc",!0,"bool");n.setProp("IncludeSortDSC","Includesortdsc",!0,"bool");n.setDynProp("SortedStatus","Sortedstatus","","char");n.setProp("IncludeFilter","Includefilter",!0,"bool");n.setProp("FilterType","Filtertype","Character","str");n.setProp("FilterIsRange","Filterisrange",!1,"bool");n.setProp("IncludeDataList","Includedatalist",!0,"bool");n.setProp("DataListType","Datalisttype","Dynamic","str");n.setProp("AllowMultipleSelection","Allowmultipleselection",!1,"bool");n.setProp("DataListFixedValues","Datalistfixedvalues","","char");n.setProp("DataListProc","Datalistproc","GeneroWWGetFilterData","str");n.setProp("DataListUpdateMinimumCharacters","Datalistupdateminimumcharacters",0,"num");n.setProp("FixedFilters","Fixedfilters","","str");n.setProp("SelectedFixedFilter","Selectedfixedfilter","","char");n.setProp("ColumnsSelectorValues","Columnsselectorvalues","","char");n.setProp("SortASC","Sortasc","WWP_TSSortASC","str");n.setProp("SortDSC","Sortdsc","WWP_TSSortDSC","str");n.setProp("LoadingData","Loadingdata","WWP_TSLoading","str");n.setProp("CleanFilter","Cleanfilter","WWP_TSCleanFilter","str");n.setProp("RangeFilterFrom","Rangefilterfrom","","char");n.setProp("RangeFilterTo","Rangefilterto","","char");n.setProp("NoResultsFound","Noresultsfound","WWP_TSNoResults","str");n.setProp("SearchButtonText","Searchbuttontext","WWP_TSSearchButtonCaption","str");n.setProp("UpdateButtonText","Updatebuttontext","Update","str");n.addV2CFunction("AV40DDO_TitleSettingsIcons","vDDO_TITLESETTINGSICONS","SetDropDownOptionsTitleSettingsIcons");n.addC2VFunction(function(n){n.ParentObject.AV40DDO_TitleSettingsIcons=n.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",n.ParentObject.AV40DDO_TitleSettingsIcons)});n.addV2CFunction("AV36GeneroNomeTitleFilterData","vGENERONOMETITLEFILTERDATA","SetDropDownOptionsData");n.addC2VFunction(function(n){n.ParentObject.AV36GeneroNomeTitleFilterData=n.GetDropDownOptionsData();gx.fn.setControlValue("vGENERONOMETITLEFILTERDATA",n.ParentObject.AV36GeneroNomeTitleFilterData)});n.setProp("Visible","Visible",!0,"bool");n.setC2ShowFunction(function(n){n.show()});n.addEventHandler("OnOptionClicked",this.e13282_client);this.setUserControl(n);this.WORKWITHPLUSUTILITIES1Container=gx.uc.getNew(this,47,46,"DVelop_WorkWithPlusUtilities","WORKWITHPLUSUTILITIES1Container","Workwithplusutilities1","WORKWITHPLUSUTILITIES1");e=this.WORKWITHPLUSUTILITIES1Container;e.setProp("Class","Class","","char");e.setProp("Enabled","Enabled",!0,"boolean");e.setProp("Width","Width","100","str");e.setProp("Height","Height","100","str");e.setProp("Visible","Visible",!0,"bool");e.setC2ShowFunction(function(n){n.show()});this.setUserControl(e);this.DDO_GRIDCOLUMNSSELECTORContainer=gx.uc.getNew(this,48,46,"BootstrapDropDownOptions","DDO_GRIDCOLUMNSSELECTORContainer","Ddo_gridcolumnsselector","DDO_GRIDCOLUMNSSELECTOR");t=this.DDO_GRIDCOLUMNSSELECTORContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Icon","Icon","","char");t.setProp("Caption","Caption","Seleciona colunas","str");t.setProp("Tooltip","Tooltip","WWP_EditColumnsTooltip","str");t.setProp("Cls","Cls","ColumnsSelector hidden-xs","str");t.setProp("ActiveEventKey","Activeeventkey","","char");t.setProp("FilteredText_set","Filteredtext_set","","char");t.setProp("FilteredText_get","Filteredtext_get","","char");t.setProp("FilteredTextTo_set","Filteredtextto_set","","char");t.setProp("FilteredTextTo_get","Filteredtextto_get","","char");t.setProp("SelectedValue_set","Selectedvalue_set","","char");t.setProp("SelectedValue_get","Selectedvalue_get","","char");t.setProp("SelectedText_set","Selectedtext_set","","char");t.setProp("SelectedText_get","Selectedtext_get","","char");t.setProp("GAMOAuthToken","Gamoauthtoken","","char");t.setProp("TitleControlAlign","Titlecontrolalign","Automatic","str");t.setProp("DropDownOptionsType","Dropdownoptionstype","GridColumnsSelector","str");t.setDynProp("TitleControlIdToReplace","Titlecontrolidtoreplace","","str");t.setProp("IncludeSortASC","Includesortasc",!1,"boolean");t.setProp("IncludeSortDSC","Includesortdsc",!1,"boolean");t.setProp("SortedStatus","Sortedstatus","","char");t.setProp("IncludeFilter","Includefilter",!1,"boolean");t.setProp("FilterType","Filtertype","","char");t.setProp("FilterIsRange","Filterisrange",!1,"boolean");t.setProp("IncludeDataList","Includedatalist",!1,"boolean");t.setProp("DataListType","Datalisttype","","char");t.setProp("AllowMultipleSelection","Allowmultipleselection",!1,"boolean");t.setProp("DataListFixedValues","Datalistfixedvalues","","char");t.setProp("DataListProc","Datalistproc","","char");t.setProp("DataListUpdateMinimumCharacters","Datalistupdateminimumcharacters","","int");t.setProp("FixedFilters","Fixedfilters","","char");t.setProp("SelectedFixedFilter","Selectedfixedfilter","","char");t.setProp("ColumnsSelectorValues","Columnsselectorvalues","","char");t.setProp("SortASC","Sortasc","","char");t.setProp("SortDSC","Sortdsc","","char");t.setProp("LoadingData","Loadingdata","","char");t.setProp("CleanFilter","Cleanfilter","","char");t.setProp("RangeFilterFrom","Rangefilterfrom","","char");t.setProp("RangeFilterTo","Rangefilterto","","char");t.setProp("NoResultsFound","Noresultsfound","","char");t.setProp("SearchButtonText","Searchbuttontext","","char");t.setProp("UpdateButtonText","Updatebuttontext","WWP_ColumnsSelectorButton","str");t.addV2CFunction("AV40DDO_TitleSettingsIcons","vDDO_TITLESETTINGSICONS","SetDropDownOptionsTitleSettingsIcons");t.addC2VFunction(function(n){n.ParentObject.AV40DDO_TitleSettingsIcons=n.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",n.ParentObject.AV40DDO_TitleSettingsIcons)});t.addV2CFunction("AV27ColumnsSelector","vCOLUMNSSELECTOR","SetDropDownOptionsData");t.addC2VFunction(function(n){n.ParentObject.AV27ColumnsSelector=n.GetDropDownOptionsData();gx.fn.setControlValue("vCOLUMNSSELECTOR",n.ParentObject.AV27ColumnsSelector)});t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});t.addEventHandler("OnColumnsChanged",this.e14282_client);this.setUserControl(t);i[2]={id:2,fld:"",grid:0};i[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};i[4]={id:4,fld:"",grid:0};i[5]={id:5,fld:"",grid:0};i[6]={id:6,fld:"TABLEMAIN",grid:0};i[7]={id:7,fld:"",grid:0};i[8]={id:8,fld:"",grid:0};i[9]={id:9,fld:"HTML_DVPANEL_TABLEHEADER",grid:0};i[12]={id:12,fld:"LAYOUT_TABLEHEADER",grid:0};i[13]={id:13,fld:"",grid:0};i[14]={id:14,fld:"TABLEHEADER",grid:0};i[15]={id:15,fld:"",grid:0};i[16]={id:16,fld:"",grid:0};i[17]={id:17,fld:"TABLEACTIONS",grid:0};i[18]={id:18,fld:"",grid:0};i[19]={id:19,fld:"",grid:0};i[20]={id:20,fld:"",grid:0};i[21]={id:21,fld:"",grid:0};i[22]={id:22,fld:"BTNINSERT",grid:0};i[23]={id:23,fld:"",grid:0};i[24]={id:24,fld:"BTNEDITCOLUMNS",grid:0};i[25]={id:25,fld:"",grid:0};i[26]={id:26,fld:"",grid:0};i[28]={id:28,fld:"",grid:0};i[29]={id:29,fld:"",grid:0};i[30]={id:30,fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};i[31]={id:31,fld:"",grid:0};i[32]={id:32,fld:"",grid:0};i[34]={id:34,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV46Update",gxold:"OV46Update",gxvar:"AV46Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV46Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV46Update=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATE",n||gx.fn.currentGridRowImpl(33),gx.O.AV46Update,gx.O.AV55Update_GXI)},c2v:function(){gx.O.AV55Update_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV46Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(33))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATE_GXI",n||gx.fn.currentGridRowImpl(33))},gxvar_GXI:"AV55Update_GXI",nac:gx.falseFn};i[35]={id:35,lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"GENEROID",gxz:"Z48GeneroId",gxold:"O48GeneroId",gxvar:"A48GeneroId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A48GeneroId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z48GeneroId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("GENEROID",n||gx.fn.currentGridRowImpl(33),gx.O.A48GeneroId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A48GeneroId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("GENEROID",n||gx.fn.currentGridRowImpl(33),".")},nac:gx.falseFn};i[36]={id:36,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"GENERONOME",gxz:"Z49GeneroNome",gxold:"O49GeneroNome",gxvar:"A49GeneroNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A49GeneroNome=n)},v2z:function(n){n!==undefined&&(gx.O.Z49GeneroNome=n)},v2c:function(n){gx.fn.setGridControlValue("GENERONOME",n||gx.fn.currentGridRowImpl(33),gx.O.A49GeneroNome,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A49GeneroNome=this.val())},val:function(n){return gx.fn.getGridControlValue("GENERONOME",n||gx.fn.currentGridRowImpl(33))},nac:gx.falseFn};i[37]={id:37,lvl:2,type:"boolean",len:4,dec:0,sign:!1,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"GENEROINATIVO",gxz:"Z50GeneroInativo",gxold:"O50GeneroInativo",gxvar:"A50GeneroInativo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A50GeneroInativo=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z50GeneroInativo=gx.lang.booleanValue(n))},v2c:function(n){gx.fn.setGridCheckBoxValue("GENEROINATIVO",n||gx.fn.currentGridRowImpl(33),gx.O.A50GeneroInativo,!0)},c2v:function(){this.val()!==undefined&&(gx.O.A50GeneroInativo=gx.lang.booleanValue(this.val()))},val:function(n){return gx.fn.getGridControlValue("GENEROINATIVO",n||gx.fn.currentGridRowImpl(33))},nac:gx.falseFn,values:["true","false"]};i[38]={id:38,fld:"",grid:0};i[39]={id:39,fld:"",grid:0};i[40]={id:40,fld:"HTML_GRIDPAGINATIONBAR",grid:0};i[42]={id:42,fld:"",grid:0};i[43]={id:43,fld:"",grid:0};i[44]={id:44,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};i[46]={id:46,lvl:0,type:"svchar",len:300,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_GENERONOMETITLECONTROLIDTOREPLACE",gxz:"ZV39ddo_GeneroNomeTitleControlIdToReplace",gxold:"OV39ddo_GeneroNomeTitleControlIdToReplace",gxvar:"AV39ddo_GeneroNomeTitleControlIdToReplace",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV39ddo_GeneroNomeTitleControlIdToReplace=n)},v2z:function(n){n!==undefined&&(gx.O.ZV39ddo_GeneroNomeTitleControlIdToReplace=n)},v2c:function(){gx.fn.setControlValue("vDDO_GENERONOMETITLECONTROLIDTOREPLACE",gx.O.AV39ddo_GeneroNomeTitleControlIdToReplace,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV39ddo_GeneroNomeTitleControlIdToReplace=this.val())},val:function(){return gx.fn.getControlValue("vDDO_GENERONOMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};i[49]={id:49,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV13OrderedDsc",gxold:"OV13OrderedDsc",gxvar:"AV13OrderedDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV13OrderedDsc=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV13OrderedDsc=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV13OrderedDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV13OrderedDsc=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};i[50]={id:50,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFGENERONOME",gxz:"ZV37TFGeneroNome",gxold:"OV37TFGeneroNome",gxvar:"AV37TFGeneroNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV37TFGeneroNome=n)},v2z:function(n){n!==undefined&&(gx.O.ZV37TFGeneroNome=n)},v2c:function(){gx.fn.setControlValue("vTFGENERONOME",gx.O.AV37TFGeneroNome,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV37TFGeneroNome=this.val())},val:function(){return gx.fn.getControlValue("vTFGENERONOME")},nac:gx.falseFn};i[51]={id:51,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFGENERONOME_SEL",gxz:"ZV38TFGeneroNome_Sel",gxold:"OV38TFGeneroNome_Sel",gxvar:"AV38TFGeneroNome_Sel",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV38TFGeneroNome_Sel=n)},v2z:function(n){n!==undefined&&(gx.O.ZV38TFGeneroNome_Sel=n)},v2c:function(){gx.fn.setControlValue("vTFGENERONOME_SEL",gx.O.AV38TFGeneroNome_Sel,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV38TFGeneroNome_Sel=this.val())},val:function(){return gx.fn.getControlValue("vTFGENERONOME_SEL")},nac:gx.falseFn};this.ZV46Update="";this.OV46Update="";this.Z48GeneroId=0;this.O48GeneroId=0;this.Z49GeneroNome="";this.O49GeneroNome="";this.Z50GeneroInativo=!1;this.O50GeneroInativo=!1;this.AV39ddo_GeneroNomeTitleControlIdToReplace="";this.ZV39ddo_GeneroNomeTitleControlIdToReplace="";this.OV39ddo_GeneroNomeTitleControlIdToReplace="";this.AV13OrderedDsc=!1;this.ZV13OrderedDsc=!1;this.OV13OrderedDsc=!1;this.AV37TFGeneroNome="";this.ZV37TFGeneroNome="";this.OV37TFGeneroNome="";this.AV38TFGeneroNome_Sel="";this.ZV38TFGeneroNome_Sel="";this.OV38TFGeneroNome_Sel="";this.AV44GridCurrentPage=0;this.AV40DDO_TitleSettingsIcons={Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""};this.AV39ddo_GeneroNomeTitleControlIdToReplace="";this.AV13OrderedDsc=!1;this.AV37TFGeneroNome="";this.AV38TFGeneroNome_Sel="";this.AV46Update="";this.A48GeneroId=0;this.A49GeneroNome="";this.A50GeneroInativo=!1;this.AV27ColumnsSelector={VisibleColumns:[],InvisibleColumns:[]};this.AV56Pgmname="";this.Events={e11282_client:["GRIDPAGINATIONBAR.CHANGEPAGE",!0],e12282_client:["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",!0],e13282_client:["DDO_GENERONOME.ONOPTIONCLICKED",!0],e14282_client:["DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED",!0],e15282_client:["'DOINSERT'",!0],e19282_client:["ENTER",!0],e20282_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage",nv:0},{av:"GRID_nEOF",nv:0},{av:"subGrid_Rows",nv:0},{av:"AV27ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:"AV39ddo_GeneroNomeTitleControlIdToReplace",fld:"vDDO_GENERONOMETITLECONTROLIDTOREPLACE",pic:"",nv:""},{av:"AV37TFGeneroNome",fld:"vTFGENERONOME",pic:"",nv:""},{av:"AV38TFGeneroNome_Sel",fld:"vTFGENERONOME_SEL",pic:"",nv:""},{av:"AV56Pgmname",fld:"vPGMNAME",pic:"",nv:""},{av:"AV13OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{ctrl:"GRID",prop:"Rows"}],[{av:"AV36GeneroNomeTitleFilterData",fld:"vGENERONOMETITLEFILTERDATA",pic:"",nv:null},{av:"AV27ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:'gx.fn.getCtrlProperty("GENERONOME","Visible")',ctrl:"GENERONOME",prop:"Visible"},{ctrl:"GENERONOME",prop:"Titleformat"},{av:'gx.fn.getCtrlProperty("GENERONOME","Title")',ctrl:"GENERONOME",prop:"Title"},{av:"AV44GridCurrentPage",fld:"vGRIDCURRENTPAGE",pic:"ZZZZZZZZZ9",nv:0},{av:"AV45GridPageCount",fld:"vGRIDPAGECOUNT",pic:"ZZZZZZZZZ9",nv:0}]];this.EvtParms.START=[[{av:"AV56Pgmname",fld:"vPGMNAME",pic:"",nv:""},{av:"AV13OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1}],[{ctrl:"GRID",prop:"Rows"},{av:'gx.fn.getCtrlProperty("vTFGENERONOME","Visible")',ctrl:"vTFGENERONOME",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vTFGENERONOME_SEL","Visible")',ctrl:"vTFGENERONOME_SEL",prop:"Visible"},{av:"this.DDO_GENERONOMEContainer.TitleControlIdToReplace",ctrl:"DDO_GENERONOME",prop:"TitleControlIdToReplace"},{av:"AV39ddo_GeneroNomeTitleControlIdToReplace",fld:"vDDO_GENERONOMETITLECONTROLIDTOREPLACE",pic:"",nv:""},{av:'gx.fn.getCtrlProperty("vDDO_GENERONOMETITLECONTROLIDTOREPLACE","Visible")',ctrl:"vDDO_GENERONOMETITLECONTROLIDTOREPLACE",prop:"Visible"},{ctrl:"FORM",prop:"Caption"},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:"vORDEREDDSC",prop:"Visible"},{av:"AV40DDO_TitleSettingsIcons",fld:"vDDO_TITLESETTINGSICONS",pic:"",nv:null},{av:"this.DDO_GRIDCOLUMNSSELECTORContainer.TitleControlIdToReplace",ctrl:"DDO_GRIDCOLUMNSSELECTOR",prop:"TitleControlIdToReplace"},{av:"this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue",ctrl:"GRIDPAGINATIONBAR",prop:"RowsPerPageSelectedValue"},{av:"AV13OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{av:"AV37TFGeneroNome",fld:"vTFGENERONOME",pic:"",nv:""},{av:"this.DDO_GENERONOMEContainer.FilteredText_set",ctrl:"DDO_GENERONOME",prop:"FilteredText_set"},{av:"AV38TFGeneroNome_Sel",fld:"vTFGENERONOME_SEL",pic:"",nv:""},{av:"this.DDO_GENERONOMEContainer.SelectedValue_set",ctrl:"DDO_GENERONOME",prop:"SelectedValue_set"},{av:"this.DDO_GENERONOMEContainer.SortedStatus",ctrl:"DDO_GENERONOME",prop:"SortedStatus"}]];this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"]=[[{av:"GRID_nFirstRecordOnPage",nv:0},{av:"GRID_nEOF",nv:0},{av:"subGrid_Rows",nv:0},{av:"AV13OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{av:"AV37TFGeneroNome",fld:"vTFGENERONOME",pic:"",nv:""},{av:"AV38TFGeneroNome_Sel",fld:"vTFGENERONOME_SEL",pic:"",nv:""},{av:"AV27ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:"AV39ddo_GeneroNomeTitleControlIdToReplace",fld:"vDDO_GENERONOMETITLECONTROLIDTOREPLACE",pic:"",nv:""},{av:"AV56Pgmname",fld:"vPGMNAME",pic:"",nv:""},{av:"this.GRIDPAGINATIONBARContainer.SelectedPage",ctrl:"GRIDPAGINATIONBAR",prop:"SelectedPage"}],[]];this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"]=[[{av:"GRID_nFirstRecordOnPage",nv:0},{av:"GRID_nEOF",nv:0},{av:"subGrid_Rows",nv:0},{av:"AV13OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{av:"AV37TFGeneroNome",fld:"vTFGENERONOME",pic:"",nv:""},{av:"AV38TFGeneroNome_Sel",fld:"vTFGENERONOME_SEL",pic:"",nv:""},{av:"AV27ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:"AV39ddo_GeneroNomeTitleControlIdToReplace",fld:"vDDO_GENERONOMETITLECONTROLIDTOREPLACE",pic:"",nv:""},{av:"AV56Pgmname",fld:"vPGMNAME",pic:"",nv:""},{av:"this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue",ctrl:"GRIDPAGINATIONBAR",prop:"RowsPerPageSelectedValue"}],[{ctrl:"GRID",prop:"Rows"}]];this.EvtParms["DDO_GENERONOME.ONOPTIONCLICKED"]=[[{av:"GRID_nFirstRecordOnPage",nv:0},{av:"GRID_nEOF",nv:0},{av:"subGrid_Rows",nv:0},{av:"AV13OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{av:"AV37TFGeneroNome",fld:"vTFGENERONOME",pic:"",nv:""},{av:"AV38TFGeneroNome_Sel",fld:"vTFGENERONOME_SEL",pic:"",nv:""},{av:"AV27ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:"AV39ddo_GeneroNomeTitleControlIdToReplace",fld:"vDDO_GENERONOMETITLECONTROLIDTOREPLACE",pic:"",nv:""},{av:"AV56Pgmname",fld:"vPGMNAME",pic:"",nv:""},{av:"this.DDO_GENERONOMEContainer.ActiveEventKey",ctrl:"DDO_GENERONOME",prop:"ActiveEventKey"},{av:"this.DDO_GENERONOMEContainer.FilteredText_get",ctrl:"DDO_GENERONOME",prop:"FilteredText_get"},{av:"this.DDO_GENERONOMEContainer.SelectedValue_get",ctrl:"DDO_GENERONOME",prop:"SelectedValue_get"},{ctrl:"GRID",prop:"Rows"}],[{av:"AV13OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{av:"this.DDO_GENERONOMEContainer.SortedStatus",ctrl:"DDO_GENERONOME",prop:"SortedStatus"},{av:"AV37TFGeneroNome",fld:"vTFGENERONOME",pic:"",nv:""},{av:"AV38TFGeneroNome_Sel",fld:"vTFGENERONOME_SEL",pic:"",nv:""},{av:"AV36GeneroNomeTitleFilterData",fld:"vGENERONOMETITLEFILTERDATA",pic:"",nv:null},{av:"AV27ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:'gx.fn.getCtrlProperty("GENERONOME","Visible")',ctrl:"GENERONOME",prop:"Visible"},{ctrl:"GENERONOME",prop:"Titleformat"},{av:'gx.fn.getCtrlProperty("GENERONOME","Title")',ctrl:"GENERONOME",prop:"Title"},{av:"AV44GridCurrentPage",fld:"vGRIDCURRENTPAGE",pic:"ZZZZZZZZZ9",nv:0},{av:"AV45GridPageCount",fld:"vGRIDPAGECOUNT",pic:"ZZZZZZZZZ9",nv:0}]];this.EvtParms["GRID.LOAD"]=[[{av:"A48GeneroId",fld:"GENEROID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV46Update",fld:"vUPDATE",pic:"",nv:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("GENERONOME","Link")',ctrl:"GENERONOME",prop:"Link"}]];this.EvtParms["DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED"]=[[{av:"GRID_nFirstRecordOnPage",nv:0},{av:"GRID_nEOF",nv:0},{av:"subGrid_Rows",nv:0},{av:"AV13OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{av:"AV37TFGeneroNome",fld:"vTFGENERONOME",pic:"",nv:""},{av:"AV38TFGeneroNome_Sel",fld:"vTFGENERONOME_SEL",pic:"",nv:""},{av:"AV27ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:"AV39ddo_GeneroNomeTitleControlIdToReplace",fld:"vDDO_GENERONOMETITLECONTROLIDTOREPLACE",pic:"",nv:""},{av:"AV56Pgmname",fld:"vPGMNAME",pic:"",nv:""},{av:"this.DDO_GRIDCOLUMNSSELECTORContainer.ColumnsSelectorValues",ctrl:"DDO_GRIDCOLUMNSSELECTOR",prop:"ColumnsSelectorValues"},{ctrl:"GRID",prop:"Rows"}],[{av:"AV27ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:"AV36GeneroNomeTitleFilterData",fld:"vGENERONOMETITLEFILTERDATA",pic:"",nv:null},{av:'gx.fn.getCtrlProperty("GENERONOME","Visible")',ctrl:"GENERONOME",prop:"Visible"},{ctrl:"GENERONOME",prop:"Titleformat"},{av:'gx.fn.getCtrlProperty("GENERONOME","Title")',ctrl:"GENERONOME",prop:"Title"},{av:"AV44GridCurrentPage",fld:"vGRIDCURRENTPAGE",pic:"ZZZZZZZZZ9",nv:0},{av:"AV45GridPageCount",fld:"vGRIDPAGECOUNT",pic:"ZZZZZZZZZ9",nv:0}]];this.EvtParms["'DOINSERT'"]=[[{av:"A48GeneroId",fld:"GENEROID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[]];this.setVCMap("AV27ColumnsSelector","vCOLUMNSSELECTOR",0,"WWPBaseObjectsWWPColumnsSelector");this.setVCMap("AV56Pgmname","vPGMNAME",0,"char");this.setVCMap("AV27ColumnsSelector","vCOLUMNSSELECTOR",0,"WWPBaseObjectsWWPColumnsSelector");this.setVCMap("AV56Pgmname","vPGMNAME",0,"char");this.setVCMap("AV27ColumnsSelector","vCOLUMNSSELECTOR",0,"WWPBaseObjectsWWPColumnsSelector");this.setVCMap("AV56Pgmname","vPGMNAME",0,"char");f.addRefreshingVar(this.GXValidFnc[49]);f.addRefreshingVar(this.GXValidFnc[50]);f.addRefreshingVar(this.GXValidFnc[51]);f.addRefreshingVar({rfrVar:"AV27ColumnsSelector"});f.addRefreshingVar(this.GXValidFnc[46]);f.addRefreshingVar({rfrVar:"AV56Pgmname"});this.Initialize()});gx.createParentObj(generoww)