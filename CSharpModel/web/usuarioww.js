/*!   GeneXus C# 15_0_9-121631 on 9/20/2018 19:46:22.86
*/
gx.evt.autoSkip=!1;gx.define("usuarioww",!1,function(){var i,f,u,r,n,e,t;this.ServerClass="usuarioww";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV28ColumnsSelector=gx.fn.getControlValue("vCOLUMNSSELECTOR");this.AV58Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV28ColumnsSelector=gx.fn.getControlValue("vCOLUMNSSELECTOR");this.AV58Pgmname=gx.fn.getControlValue("vPGMNAME")};this.s152_client=function(){this.DDO_USUARIONOMEContainer.SortedStatus=this.AV14OrderedDsc?"DSC":"ASC"};this.e11292_client=function(){return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE",!1,null,!0,!0)};this.e12292_client=function(){return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",!1,null,!0,!0)};this.e13292_client=function(){return this.executeServerEvent("DDO_USUARIONOME.ONOPTIONCLICKED",!1,null,!0,!0)};this.e14292_client=function(){return this.executeServerEvent("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED",!1,null,!0,!0)};this.e15292_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e19292_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e20292_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];i=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,28,29,30,31,32,34,35,36,37,38,39,41,42,43,45,48,49,50];this.GXLastCtrlId=50;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",33,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"usuarioww",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px",0,"px","Novo registro",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);f=this.GridContainer;f.addBitmap("&Update","vUPDATE",34,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");f.addSingleLineEdit(11,35,"USUARIOID","Id","","UsuarioId","int",0,"px",18,18,"right",null,[],11,"UsuarioId",!1,0,!1,!1,"Attribute",1,"WWColumn hidden-xs");f.addSingleLineEdit(12,36,"USUARIONOME","","","UsuarioNome","svchar",0,"px",40,40,"left",null,[],12,"UsuarioNome",!0,0,!1,!1,"Attribute",1,"WWColumn");this.GridContainer.emptyText="";this.setGrid(f);this.DVPANEL_TABLEHEADERContainer=gx.uc.getNew(this,10,0,"BootstrapPanel","DVPANEL_TABLEHEADERContainer","Dvpanel_tableheader","DVPANEL_TABLEHEADER");u=this.DVPANEL_TABLEHEADERContainer;u.setProp("Class","Class","","char");u.setProp("Enabled","Enabled",!0,"boolean");u.setProp("Width","Width","100%","str");u.setProp("Height","Height","100","str");u.setProp("AutoWidth","Autowidth",!1,"bool");u.setProp("AutoHeight","Autoheight",!0,"bool");u.setProp("Cls","Cls","PanelNoHeader","str");u.setProp("ShowHeader","Showheader",!0,"bool");u.setProp("Title","Title","Opções","str");u.setProp("Collapsible","Collapsible",!0,"bool");u.setProp("Collapsed","Collapsed",!1,"bool");u.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");u.setProp("IconPosition","Iconposition","left","str");u.setProp("AutoScroll","Autoscroll",!1,"bool");u.setProp("Visible","Visible",!0,"bool");u.setC2ShowFunction(function(n){n.show()});this.setUserControl(u);this.GRIDPAGINATIONBARContainer=gx.uc.getNew(this,40,34,"DVelop_DVPaginationBar","GRIDPAGINATIONBARContainer","Gridpaginationbar","GRIDPAGINATIONBAR");r=this.GRIDPAGINATIONBARContainer;r.setProp("Enabled","Enabled",!0,"boolean");r.setProp("Class","Class","PaginationBar","str");r.setProp("ShowFirst","Showfirst",!1,"bool");r.setProp("ShowPrevious","Showprevious",!0,"bool");r.setProp("ShowNext","Shownext",!0,"bool");r.setProp("ShowLast","Showlast",!1,"bool");r.setProp("PagesToShow","Pagestoshow",5,"num");r.setProp("PagingButtonsPosition","Pagingbuttonsposition","Right","str");r.setProp("PagingCaptionPosition","Pagingcaptionposition","Left","str");r.setProp("EmptyGridClass","Emptygridclass","PaginationBarEmptyGrid","str");r.setProp("SelectedPage","Selectedpage","","char");r.setProp("RowsPerPageSelector","Rowsperpageselector",!0,"bool");r.setDynProp("RowsPerPageSelectedValue","Rowsperpageselectedvalue",10,"num");r.setProp("RowsPerPageOptions","Rowsperpageoptions","5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50","str");r.setProp("First","First","First","str");r.setProp("Previous","Previous","WWP_PagingPreviousCaption","str");r.setProp("Next","Next","WWP_PagingNextCaption","str");r.setProp("Last","Last","Last","str");r.setProp("Caption","Caption","Página <CURRENT_PAGE> de <TOTAL_PAGES>","str");r.setProp("EmptyGridCaption","Emptygridcaption","WWP_PagingEmptyGridCaption","str");r.setProp("RowsPerPageCaption","Rowsperpagecaption","WWP_PagingRowsPerPage","str");r.addV2CFunction("AV47GridCurrentPage","vGRIDCURRENTPAGE","SetCurrentPage");r.addC2VFunction(function(n){n.ParentObject.AV47GridCurrentPage=n.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",n.ParentObject.AV47GridCurrentPage)});r.addV2CFunction("AV48GridPageCount","vGRIDPAGECOUNT","SetPageCount");r.addC2VFunction(function(n){n.ParentObject.AV48GridPageCount=n.GetPageCount();gx.fn.setControlValue("vGRIDPAGECOUNT",n.ParentObject.AV48GridPageCount)});r.setProp("RecordCount","Recordcount","","str");r.setProp("Page","Page","","str");r.setProp("Visible","Visible",!0,"bool");r.setC2ShowFunction(function(n){n.show()});r.addEventHandler("ChangePage",this.e11292_client);r.addEventHandler("ChangeRowsPerPage",this.e12292_client);this.setUserControl(r);this.DDO_USUARIONOMEContainer=gx.uc.getNew(this,44,34,"BootstrapDropDownOptions","DDO_USUARIONOMEContainer","Ddo_usuarionome","DDO_USUARIONOME");n=this.DDO_USUARIONOMEContainer;n.setProp("Class","Class","","char");n.setProp("Enabled","Enabled",!0,"boolean");n.setProp("Icon","Icon","","char");n.setProp("Caption","Caption","","str");n.setProp("Tooltip","Tooltip","WWP_TSColumnOptions","str");n.setProp("Cls","Cls","ColumnSettings","str");n.setProp("ActiveEventKey","Activeeventkey","","char");n.setDynProp("FilteredText_set","Filteredtext_set","","char");n.setProp("FilteredText_get","Filteredtext_get","","char");n.setProp("FilteredTextTo_set","Filteredtextto_set","","char");n.setProp("FilteredTextTo_get","Filteredtextto_get","","char");n.setDynProp("SelectedValue_set","Selectedvalue_set","","char");n.setProp("SelectedValue_get","Selectedvalue_get","","char");n.setProp("SelectedText_set","Selectedtext_set","","char");n.setProp("SelectedText_get","Selectedtext_get","","char");n.setProp("GAMOAuthToken","Gamoauthtoken","","char");n.setProp("TitleControlAlign","Titlecontrolalign","Automatic","str");n.setProp("DropDownOptionsType","Dropdownoptionstype","GridTitleSettings","str");n.setDynProp("TitleControlIdToReplace","Titlecontrolidtoreplace","","str");n.setProp("IncludeSortASC","Includesortasc",!0,"bool");n.setProp("IncludeSortDSC","Includesortdsc",!0,"bool");n.setDynProp("SortedStatus","Sortedstatus","","char");n.setProp("IncludeFilter","Includefilter",!0,"bool");n.setProp("FilterType","Filtertype","Character","str");n.setProp("FilterIsRange","Filterisrange",!1,"bool");n.setProp("IncludeDataList","Includedatalist",!0,"bool");n.setProp("DataListType","Datalisttype","Dynamic","str");n.setProp("AllowMultipleSelection","Allowmultipleselection",!1,"bool");n.setProp("DataListFixedValues","Datalistfixedvalues","","char");n.setProp("DataListProc","Datalistproc","UsuarioWWGetFilterData","str");n.setProp("DataListUpdateMinimumCharacters","Datalistupdateminimumcharacters",0,"num");n.setProp("FixedFilters","Fixedfilters","","str");n.setProp("SelectedFixedFilter","Selectedfixedfilter","","char");n.setProp("ColumnsSelectorValues","Columnsselectorvalues","","char");n.setProp("SortASC","Sortasc","WWP_TSSortASC","str");n.setProp("SortDSC","Sortdsc","WWP_TSSortDSC","str");n.setProp("LoadingData","Loadingdata","WWP_TSLoading","str");n.setProp("CleanFilter","Cleanfilter","WWP_TSCleanFilter","str");n.setProp("RangeFilterFrom","Rangefilterfrom","","char");n.setProp("RangeFilterTo","Rangefilterto","","char");n.setProp("NoResultsFound","Noresultsfound","WWP_TSNoResults","str");n.setProp("SearchButtonText","Searchbuttontext","WWP_TSSearchButtonCaption","str");n.setProp("UpdateButtonText","Updatebuttontext","Update","str");n.addV2CFunction("AV45DDO_TitleSettingsIcons","vDDO_TITLESETTINGSICONS","SetDropDownOptionsTitleSettingsIcons");n.addC2VFunction(function(n){n.ParentObject.AV45DDO_TitleSettingsIcons=n.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",n.ParentObject.AV45DDO_TitleSettingsIcons)});n.addV2CFunction("AV41UsuarioNomeTitleFilterData","vUSUARIONOMETITLEFILTERDATA","SetDropDownOptionsData");n.addC2VFunction(function(n){n.ParentObject.AV41UsuarioNomeTitleFilterData=n.GetDropDownOptionsData();gx.fn.setControlValue("vUSUARIONOMETITLEFILTERDATA",n.ParentObject.AV41UsuarioNomeTitleFilterData)});n.setProp("Visible","Visible",!0,"bool");n.setC2ShowFunction(function(n){n.show()});n.addEventHandler("OnOptionClicked",this.e13292_client);this.setUserControl(n);this.WORKWITHPLUSUTILITIES1Container=gx.uc.getNew(this,46,45,"DVelop_WorkWithPlusUtilities","WORKWITHPLUSUTILITIES1Container","Workwithplusutilities1","WORKWITHPLUSUTILITIES1");e=this.WORKWITHPLUSUTILITIES1Container;e.setProp("Class","Class","","char");e.setProp("Enabled","Enabled",!0,"boolean");e.setProp("Width","Width","100","str");e.setProp("Height","Height","100","str");e.setProp("Visible","Visible",!0,"bool");e.setC2ShowFunction(function(n){n.show()});this.setUserControl(e);this.DDO_GRIDCOLUMNSSELECTORContainer=gx.uc.getNew(this,47,45,"BootstrapDropDownOptions","DDO_GRIDCOLUMNSSELECTORContainer","Ddo_gridcolumnsselector","DDO_GRIDCOLUMNSSELECTOR");t=this.DDO_GRIDCOLUMNSSELECTORContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Icon","Icon","","char");t.setProp("Caption","Caption","Seleciona colunas","str");t.setProp("Tooltip","Tooltip","WWP_EditColumnsTooltip","str");t.setProp("Cls","Cls","ColumnsSelector hidden-xs","str");t.setProp("ActiveEventKey","Activeeventkey","","char");t.setProp("FilteredText_set","Filteredtext_set","","char");t.setProp("FilteredText_get","Filteredtext_get","","char");t.setProp("FilteredTextTo_set","Filteredtextto_set","","char");t.setProp("FilteredTextTo_get","Filteredtextto_get","","char");t.setProp("SelectedValue_set","Selectedvalue_set","","char");t.setProp("SelectedValue_get","Selectedvalue_get","","char");t.setProp("SelectedText_set","Selectedtext_set","","char");t.setProp("SelectedText_get","Selectedtext_get","","char");t.setProp("GAMOAuthToken","Gamoauthtoken","","char");t.setProp("TitleControlAlign","Titlecontrolalign","Automatic","str");t.setProp("DropDownOptionsType","Dropdownoptionstype","GridColumnsSelector","str");t.setDynProp("TitleControlIdToReplace","Titlecontrolidtoreplace","","str");t.setProp("IncludeSortASC","Includesortasc",!1,"boolean");t.setProp("IncludeSortDSC","Includesortdsc",!1,"boolean");t.setProp("SortedStatus","Sortedstatus","","char");t.setProp("IncludeFilter","Includefilter",!1,"boolean");t.setProp("FilterType","Filtertype","","char");t.setProp("FilterIsRange","Filterisrange",!1,"boolean");t.setProp("IncludeDataList","Includedatalist",!1,"boolean");t.setProp("DataListType","Datalisttype","","char");t.setProp("AllowMultipleSelection","Allowmultipleselection",!1,"boolean");t.setProp("DataListFixedValues","Datalistfixedvalues","","char");t.setProp("DataListProc","Datalistproc","","char");t.setProp("DataListUpdateMinimumCharacters","Datalistupdateminimumcharacters","","int");t.setProp("FixedFilters","Fixedfilters","","char");t.setProp("SelectedFixedFilter","Selectedfixedfilter","","char");t.setProp("ColumnsSelectorValues","Columnsselectorvalues","","char");t.setProp("SortASC","Sortasc","","char");t.setProp("SortDSC","Sortdsc","","char");t.setProp("LoadingData","Loadingdata","","char");t.setProp("CleanFilter","Cleanfilter","","char");t.setProp("RangeFilterFrom","Rangefilterfrom","","char");t.setProp("RangeFilterTo","Rangefilterto","","char");t.setProp("NoResultsFound","Noresultsfound","","char");t.setProp("SearchButtonText","Searchbuttontext","","char");t.setProp("UpdateButtonText","Updatebuttontext","WWP_ColumnsSelectorButton","str");t.addV2CFunction("AV45DDO_TitleSettingsIcons","vDDO_TITLESETTINGSICONS","SetDropDownOptionsTitleSettingsIcons");t.addC2VFunction(function(n){n.ParentObject.AV45DDO_TitleSettingsIcons=n.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",n.ParentObject.AV45DDO_TitleSettingsIcons)});t.addV2CFunction("AV28ColumnsSelector","vCOLUMNSSELECTOR","SetDropDownOptionsData");t.addC2VFunction(function(n){n.ParentObject.AV28ColumnsSelector=n.GetDropDownOptionsData();gx.fn.setControlValue("vCOLUMNSSELECTOR",n.ParentObject.AV28ColumnsSelector)});t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});t.addEventHandler("OnColumnsChanged",this.e14292_client);this.setUserControl(t);i[2]={id:2,fld:"",grid:0};i[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};i[4]={id:4,fld:"",grid:0};i[5]={id:5,fld:"",grid:0};i[6]={id:6,fld:"TABLEMAIN",grid:0};i[7]={id:7,fld:"",grid:0};i[8]={id:8,fld:"",grid:0};i[9]={id:9,fld:"HTML_DVPANEL_TABLEHEADER",grid:0};i[12]={id:12,fld:"LAYOUT_TABLEHEADER",grid:0};i[13]={id:13,fld:"",grid:0};i[14]={id:14,fld:"TABLEHEADER",grid:0};i[15]={id:15,fld:"",grid:0};i[16]={id:16,fld:"",grid:0};i[17]={id:17,fld:"TABLEACTIONS",grid:0};i[18]={id:18,fld:"",grid:0};i[19]={id:19,fld:"",grid:0};i[20]={id:20,fld:"",grid:0};i[21]={id:21,fld:"",grid:0};i[22]={id:22,fld:"BTNINSERT",grid:0};i[23]={id:23,fld:"",grid:0};i[24]={id:24,fld:"BTNEDITCOLUMNS",grid:0};i[25]={id:25,fld:"",grid:0};i[26]={id:26,fld:"",grid:0};i[28]={id:28,fld:"",grid:0};i[29]={id:29,fld:"",grid:0};i[30]={id:30,fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};i[31]={id:31,fld:"",grid:0};i[32]={id:32,fld:"",grid:0};i[34]={id:34,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV50Update",gxold:"OV50Update",gxvar:"AV50Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV50Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV50Update=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATE",n||gx.fn.currentGridRowImpl(33),gx.O.AV50Update,gx.O.AV57Update_GXI)},c2v:function(){gx.O.AV57Update_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV50Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(33))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATE_GXI",n||gx.fn.currentGridRowImpl(33))},gxvar_GXI:"AV57Update_GXI",nac:gx.falseFn};i[35]={id:35,lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUARIOID",gxz:"Z11UsuarioId",gxold:"O11UsuarioId",gxvar:"A11UsuarioId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A11UsuarioId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11UsuarioId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("USUARIOID",n||gx.fn.currentGridRowImpl(33),gx.O.A11UsuarioId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A11UsuarioId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("USUARIOID",n||gx.fn.currentGridRowImpl(33),".")},nac:gx.falseFn};i[36]={id:36,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUARIONOME",gxz:"Z12UsuarioNome",gxold:"O12UsuarioNome",gxvar:"A12UsuarioNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A12UsuarioNome=n)},v2z:function(n){n!==undefined&&(gx.O.Z12UsuarioNome=n)},v2c:function(n){gx.fn.setGridControlValue("USUARIONOME",n||gx.fn.currentGridRowImpl(33),gx.O.A12UsuarioNome,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A12UsuarioNome=this.val())},val:function(n){return gx.fn.getGridControlValue("USUARIONOME",n||gx.fn.currentGridRowImpl(33))},nac:gx.falseFn};i[37]={id:37,fld:"",grid:0};i[38]={id:38,fld:"",grid:0};i[39]={id:39,fld:"HTML_GRIDPAGINATIONBAR",grid:0};i[41]={id:41,fld:"",grid:0};i[42]={id:42,fld:"",grid:0};i[43]={id:43,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};i[45]={id:45,lvl:0,type:"svchar",len:300,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_USUARIONOMETITLECONTROLIDTOREPLACE",gxz:"ZV44ddo_UsuarioNomeTitleControlIdToReplace",gxold:"OV44ddo_UsuarioNomeTitleControlIdToReplace",gxvar:"AV44ddo_UsuarioNomeTitleControlIdToReplace",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV44ddo_UsuarioNomeTitleControlIdToReplace=n)},v2z:function(n){n!==undefined&&(gx.O.ZV44ddo_UsuarioNomeTitleControlIdToReplace=n)},v2c:function(){gx.fn.setControlValue("vDDO_USUARIONOMETITLECONTROLIDTOREPLACE",gx.O.AV44ddo_UsuarioNomeTitleControlIdToReplace,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV44ddo_UsuarioNomeTitleControlIdToReplace=this.val())},val:function(){return gx.fn.getControlValue("vDDO_USUARIONOMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};i[48]={id:48,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV14OrderedDsc=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV14OrderedDsc=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};i[49]={id:49,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFUSUARIONOME",gxz:"ZV42TFUsuarioNome",gxold:"OV42TFUsuarioNome",gxvar:"AV42TFUsuarioNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV42TFUsuarioNome=n)},v2z:function(n){n!==undefined&&(gx.O.ZV42TFUsuarioNome=n)},v2c:function(){gx.fn.setControlValue("vTFUSUARIONOME",gx.O.AV42TFUsuarioNome,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV42TFUsuarioNome=this.val())},val:function(){return gx.fn.getControlValue("vTFUSUARIONOME")},nac:gx.falseFn};i[50]={id:50,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFUSUARIONOME_SEL",gxz:"ZV43TFUsuarioNome_Sel",gxold:"OV43TFUsuarioNome_Sel",gxvar:"AV43TFUsuarioNome_Sel",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV43TFUsuarioNome_Sel=n)},v2z:function(n){n!==undefined&&(gx.O.ZV43TFUsuarioNome_Sel=n)},v2c:function(){gx.fn.setControlValue("vTFUSUARIONOME_SEL",gx.O.AV43TFUsuarioNome_Sel,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV43TFUsuarioNome_Sel=this.val())},val:function(){return gx.fn.getControlValue("vTFUSUARIONOME_SEL")},nac:gx.falseFn};this.ZV50Update="";this.OV50Update="";this.Z11UsuarioId=0;this.O11UsuarioId=0;this.Z12UsuarioNome="";this.O12UsuarioNome="";this.AV44ddo_UsuarioNomeTitleControlIdToReplace="";this.ZV44ddo_UsuarioNomeTitleControlIdToReplace="";this.OV44ddo_UsuarioNomeTitleControlIdToReplace="";this.AV14OrderedDsc=!1;this.ZV14OrderedDsc=!1;this.OV14OrderedDsc=!1;this.AV42TFUsuarioNome="";this.ZV42TFUsuarioNome="";this.OV42TFUsuarioNome="";this.AV43TFUsuarioNome_Sel="";this.ZV43TFUsuarioNome_Sel="";this.OV43TFUsuarioNome_Sel="";this.AV47GridCurrentPage=0;this.AV45DDO_TitleSettingsIcons={Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""};this.AV44ddo_UsuarioNomeTitleControlIdToReplace="";this.AV14OrderedDsc=!1;this.AV42TFUsuarioNome="";this.AV43TFUsuarioNome_Sel="";this.A52UsuarioTipo=0;this.AV50Update="";this.A11UsuarioId=0;this.A12UsuarioNome="";this.AV28ColumnsSelector={VisibleColumns:[],InvisibleColumns:[]};this.AV58Pgmname="";this.Events={e11292_client:["GRIDPAGINATIONBAR.CHANGEPAGE",!0],e12292_client:["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",!0],e13292_client:["DDO_USUARIONOME.ONOPTIONCLICKED",!0],e14292_client:["DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED",!0],e15292_client:["'DOINSERT'",!0],e19292_client:["ENTER",!0],e20292_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage",nv:0},{av:"GRID_nEOF",nv:0},{av:"subGrid_Rows",nv:0},{av:"AV28ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:"AV44ddo_UsuarioNomeTitleControlIdToReplace",fld:"vDDO_USUARIONOMETITLECONTROLIDTOREPLACE",pic:"",nv:""},{av:"AV42TFUsuarioNome",fld:"vTFUSUARIONOME",pic:"",nv:""},{av:"AV43TFUsuarioNome_Sel",fld:"vTFUSUARIONOME_SEL",pic:"",nv:""},{av:"AV58Pgmname",fld:"vPGMNAME",pic:"",nv:""},{av:"AV14OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{ctrl:"GRID",prop:"Rows"}],[{av:"AV41UsuarioNomeTitleFilterData",fld:"vUSUARIONOMETITLEFILTERDATA",pic:"",nv:null},{av:"AV28ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:'gx.fn.getCtrlProperty("USUARIONOME","Visible")',ctrl:"USUARIONOME",prop:"Visible"},{ctrl:"USUARIONOME",prop:"Titleformat"},{av:'gx.fn.getCtrlProperty("USUARIONOME","Title")',ctrl:"USUARIONOME",prop:"Title"},{av:"AV47GridCurrentPage",fld:"vGRIDCURRENTPAGE",pic:"ZZZZZZZZZ9",nv:0},{av:"AV48GridPageCount",fld:"vGRIDPAGECOUNT",pic:"ZZZZZZZZZ9",nv:0}]];this.EvtParms.START=[[{av:"AV58Pgmname",fld:"vPGMNAME",pic:"",nv:""},{av:"AV14OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1}],[{ctrl:"GRID",prop:"Rows"},{av:'gx.fn.getCtrlProperty("vTFUSUARIONOME","Visible")',ctrl:"vTFUSUARIONOME",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vTFUSUARIONOME_SEL","Visible")',ctrl:"vTFUSUARIONOME_SEL",prop:"Visible"},{av:"this.DDO_USUARIONOMEContainer.TitleControlIdToReplace",ctrl:"DDO_USUARIONOME",prop:"TitleControlIdToReplace"},{av:"AV44ddo_UsuarioNomeTitleControlIdToReplace",fld:"vDDO_USUARIONOMETITLECONTROLIDTOREPLACE",pic:"",nv:""},{av:'gx.fn.getCtrlProperty("vDDO_USUARIONOMETITLECONTROLIDTOREPLACE","Visible")',ctrl:"vDDO_USUARIONOMETITLECONTROLIDTOREPLACE",prop:"Visible"},{ctrl:"FORM",prop:"Caption"},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:"vORDEREDDSC",prop:"Visible"},{av:"AV45DDO_TitleSettingsIcons",fld:"vDDO_TITLESETTINGSICONS",pic:"",nv:null},{av:"this.DDO_GRIDCOLUMNSSELECTORContainer.TitleControlIdToReplace",ctrl:"DDO_GRIDCOLUMNSSELECTOR",prop:"TitleControlIdToReplace"},{av:"this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue",ctrl:"GRIDPAGINATIONBAR",prop:"RowsPerPageSelectedValue"},{av:"AV14OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{av:"AV42TFUsuarioNome",fld:"vTFUSUARIONOME",pic:"",nv:""},{av:"this.DDO_USUARIONOMEContainer.FilteredText_set",ctrl:"DDO_USUARIONOME",prop:"FilteredText_set"},{av:"AV43TFUsuarioNome_Sel",fld:"vTFUSUARIONOME_SEL",pic:"",nv:""},{av:"this.DDO_USUARIONOMEContainer.SelectedValue_set",ctrl:"DDO_USUARIONOME",prop:"SelectedValue_set"},{av:"this.DDO_USUARIONOMEContainer.SortedStatus",ctrl:"DDO_USUARIONOME",prop:"SortedStatus"}]];this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"]=[[{av:"GRID_nFirstRecordOnPage",nv:0},{av:"GRID_nEOF",nv:0},{av:"subGrid_Rows",nv:0},{av:"AV14OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{av:"AV42TFUsuarioNome",fld:"vTFUSUARIONOME",pic:"",nv:""},{av:"AV43TFUsuarioNome_Sel",fld:"vTFUSUARIONOME_SEL",pic:"",nv:""},{av:"AV28ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:"AV44ddo_UsuarioNomeTitleControlIdToReplace",fld:"vDDO_USUARIONOMETITLECONTROLIDTOREPLACE",pic:"",nv:""},{av:"AV58Pgmname",fld:"vPGMNAME",pic:"",nv:""},{av:"this.GRIDPAGINATIONBARContainer.SelectedPage",ctrl:"GRIDPAGINATIONBAR",prop:"SelectedPage"}],[]];this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"]=[[{av:"GRID_nFirstRecordOnPage",nv:0},{av:"GRID_nEOF",nv:0},{av:"subGrid_Rows",nv:0},{av:"AV14OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{av:"AV42TFUsuarioNome",fld:"vTFUSUARIONOME",pic:"",nv:""},{av:"AV43TFUsuarioNome_Sel",fld:"vTFUSUARIONOME_SEL",pic:"",nv:""},{av:"AV28ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:"AV44ddo_UsuarioNomeTitleControlIdToReplace",fld:"vDDO_USUARIONOMETITLECONTROLIDTOREPLACE",pic:"",nv:""},{av:"AV58Pgmname",fld:"vPGMNAME",pic:"",nv:""},{av:"this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue",ctrl:"GRIDPAGINATIONBAR",prop:"RowsPerPageSelectedValue"}],[{ctrl:"GRID",prop:"Rows"}]];this.EvtParms["DDO_USUARIONOME.ONOPTIONCLICKED"]=[[{av:"GRID_nFirstRecordOnPage",nv:0},{av:"GRID_nEOF",nv:0},{av:"subGrid_Rows",nv:0},{av:"AV14OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{av:"AV42TFUsuarioNome",fld:"vTFUSUARIONOME",pic:"",nv:""},{av:"AV43TFUsuarioNome_Sel",fld:"vTFUSUARIONOME_SEL",pic:"",nv:""},{av:"AV28ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:"AV44ddo_UsuarioNomeTitleControlIdToReplace",fld:"vDDO_USUARIONOMETITLECONTROLIDTOREPLACE",pic:"",nv:""},{av:"AV58Pgmname",fld:"vPGMNAME",pic:"",nv:""},{av:"this.DDO_USUARIONOMEContainer.ActiveEventKey",ctrl:"DDO_USUARIONOME",prop:"ActiveEventKey"},{av:"this.DDO_USUARIONOMEContainer.FilteredText_get",ctrl:"DDO_USUARIONOME",prop:"FilteredText_get"},{av:"this.DDO_USUARIONOMEContainer.SelectedValue_get",ctrl:"DDO_USUARIONOME",prop:"SelectedValue_get"},{ctrl:"GRID",prop:"Rows"}],[{av:"AV14OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{av:"this.DDO_USUARIONOMEContainer.SortedStatus",ctrl:"DDO_USUARIONOME",prop:"SortedStatus"},{av:"AV42TFUsuarioNome",fld:"vTFUSUARIONOME",pic:"",nv:""},{av:"AV43TFUsuarioNome_Sel",fld:"vTFUSUARIONOME_SEL",pic:"",nv:""},{av:"AV41UsuarioNomeTitleFilterData",fld:"vUSUARIONOMETITLEFILTERDATA",pic:"",nv:null},{av:"AV28ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:'gx.fn.getCtrlProperty("USUARIONOME","Visible")',ctrl:"USUARIONOME",prop:"Visible"},{ctrl:"USUARIONOME",prop:"Titleformat"},{av:'gx.fn.getCtrlProperty("USUARIONOME","Title")',ctrl:"USUARIONOME",prop:"Title"},{av:"AV47GridCurrentPage",fld:"vGRIDCURRENTPAGE",pic:"ZZZZZZZZZ9",nv:0},{av:"AV48GridPageCount",fld:"vGRIDPAGECOUNT",pic:"ZZZZZZZZZ9",nv:0}]];this.EvtParms["GRID.LOAD"]=[[{av:"A11UsuarioId",fld:"USUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV50Update",fld:"vUPDATE",pic:"",nv:""},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:"vUPDATE",prop:"Tooltiptext"},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("USUARIONOME","Link")',ctrl:"USUARIONOME",prop:"Link"}]];this.EvtParms["DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED"]=[[{av:"GRID_nFirstRecordOnPage",nv:0},{av:"GRID_nEOF",nv:0},{av:"subGrid_Rows",nv:0},{av:"AV14OrderedDsc",fld:"vORDEREDDSC",pic:"",nv:!1},{av:"AV42TFUsuarioNome",fld:"vTFUSUARIONOME",pic:"",nv:""},{av:"AV43TFUsuarioNome_Sel",fld:"vTFUSUARIONOME_SEL",pic:"",nv:""},{av:"AV28ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:"AV44ddo_UsuarioNomeTitleControlIdToReplace",fld:"vDDO_USUARIONOMETITLECONTROLIDTOREPLACE",pic:"",nv:""},{av:"AV58Pgmname",fld:"vPGMNAME",pic:"",nv:""},{av:"this.DDO_GRIDCOLUMNSSELECTORContainer.ColumnsSelectorValues",ctrl:"DDO_GRIDCOLUMNSSELECTOR",prop:"ColumnsSelectorValues"},{ctrl:"GRID",prop:"Rows"}],[{av:"AV28ColumnsSelector",fld:"vCOLUMNSSELECTOR",pic:"",nv:null},{av:"AV41UsuarioNomeTitleFilterData",fld:"vUSUARIONOMETITLEFILTERDATA",pic:"",nv:null},{av:'gx.fn.getCtrlProperty("USUARIONOME","Visible")',ctrl:"USUARIONOME",prop:"Visible"},{ctrl:"USUARIONOME",prop:"Titleformat"},{av:'gx.fn.getCtrlProperty("USUARIONOME","Title")',ctrl:"USUARIONOME",prop:"Title"},{av:"AV47GridCurrentPage",fld:"vGRIDCURRENTPAGE",pic:"ZZZZZZZZZ9",nv:0},{av:"AV48GridPageCount",fld:"vGRIDPAGECOUNT",pic:"ZZZZZZZZZ9",nv:0}]];this.EvtParms["'DOINSERT'"]=[[{av:"A11UsuarioId",fld:"USUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[]];this.setVCMap("AV28ColumnsSelector","vCOLUMNSSELECTOR",0,"WWPBaseObjectsWWPColumnsSelector");this.setVCMap("AV58Pgmname","vPGMNAME",0,"char");this.setVCMap("AV28ColumnsSelector","vCOLUMNSSELECTOR",0,"WWPBaseObjectsWWPColumnsSelector");this.setVCMap("AV58Pgmname","vPGMNAME",0,"char");this.setVCMap("AV28ColumnsSelector","vCOLUMNSSELECTOR",0,"WWPBaseObjectsWWPColumnsSelector");this.setVCMap("AV58Pgmname","vPGMNAME",0,"char");f.addRefreshingVar(this.GXValidFnc[48]);f.addRefreshingVar(this.GXValidFnc[49]);f.addRefreshingVar(this.GXValidFnc[50]);f.addRefreshingVar({rfrVar:"AV28ColumnsSelector"});f.addRefreshingVar(this.GXValidFnc[45]);f.addRefreshingVar({rfrVar:"AV58Pgmname"});this.Initialize()});gx.createParentObj(usuarioww)