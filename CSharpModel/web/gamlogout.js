/*!   GeneXus C# 15_0_9-121631 on 9/20/2018 19:38:44.10
*/
gx.evt.autoSkip=!1;gx.define("gamlogout",!0,function(n){this.ServerClass="gamlogout";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e110h1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PROFILE","Class")=="Table193x216"?gx.fn.setCtrlProperty("PROFILE","Class","Table193x216Collapsed"):gx.fn.setCtrlProperty("PROFILE","Class","Table193x216"),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROFILE","Class")',ctrl:"PROFILE",prop:"Class"}]),$.Deferred().resolve()};this.e120h1_client=function(){return this.clearMessages(),this.call("gamuserentry.aspx",["UPD",this.AV7GUID]),this.refreshOutputs([]),$.Deferred().resolve()};this.e130h1_client=function(){return this.clearMessages(),this.call("gamchangeyourpassword.aspx",[]),this.refreshOutputs([]),$.Deferred().resolve()};this.e150h2_client=function(){return this.executeServerEvent("'LOGOUT'",!0,null,!1,!1)};this.e170h2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e180h2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54];this.GXLastCtrlId=54;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLE1",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"TABLE3",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"PHOTOCELLTOP",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vPHOTO",gxz:"ZV10Photo",gxold:"OV10Photo",gxvar:"AV10Photo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10Photo=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10Photo=n)},v2c:function(){gx.fn.setMultimediaValue("vPHOTO",gx.O.AV10Photo,gx.O.AV16Photo_GXI)},c2v:function(){gx.O.AV16Photo_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV10Photo=this.val())},val:function(){return gx.fn.getBlobValue("vPHOTO")},val_GXI:function(){return gx.fn.getControlValue("vPHOTO_GXI")},gxvar_GXI:"AV16Photo_GXI",nac:gx.falseFn,evt:"e110h1_client"};t[14]={id:14,fld:"LETTERCELLTOP",grid:0};t[15]={id:15,fld:"LETTERTITTLE",format:0,grid:0,evt:"e110h1_client"};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"TABLEWELCOME",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"TBWELCOME",format:0,grid:0,evt:"e110h1_client"};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,fld:"CURRENTREPOSITORY",format:0,grid:0};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"PROFILE",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,fld:"",grid:0};t[29]={id:29,fld:"TABLE2",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"PHOTOCELL",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vPHOTO",gxz:"ZV10Photo",gxold:"OV10Photo",gxvar:"AV10Photo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10Photo=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10Photo=n)},v2c:function(){gx.fn.setMultimediaValue("vPHOTO",gx.O.AV10Photo,gx.O.AV16Photo_GXI)},c2v:function(){gx.O.AV16Photo_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV10Photo=this.val())},val:function(){return gx.fn.getBlobValue("vPHOTO")},val_GXI:function(){return gx.fn.getControlValue("vPHOTO_GXI")},gxvar_GXI:"AV16Photo_GXI",nac:gx.falseFn};t[34]={id:34,fld:"LETTERCELL",grid:0};t[35]={id:35,fld:"LETTER",format:0,grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"NAME",format:0,grid:0};t[38]={id:38,fld:"",grid:0};t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"EMAIL",format:0,grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,fld:"SETTINGS",format:0,grid:0,evt:"e120h1_client"};t[44]={id:44,fld:"",grid:0};t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"CHANGEPASSWORD",format:0,grid:0,evt:"e130h1_client"};t[47]={id:47,fld:"",grid:0};t[48]={id:48,fld:"",grid:0};t[49]={id:49,fld:"LOGOUT",format:0,grid:0,evt:"e150h2_client"};t[50]={id:50,fld:"",grid:0};t[51]={id:51,fld:"",grid:0};t[52]={id:52,fld:"",grid:0};t[53]={id:53,fld:"",grid:0};t[54]={id:54,lvl:0,type:"char",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vGUID",gxz:"ZV7GUID",gxold:"OV7GUID",gxvar:"AV7GUID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7GUID=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7GUID=n)},v2c:function(){gx.fn.setControlValue("vGUID",gx.O.AV7GUID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV7GUID=this.val())},val:function(){return gx.fn.getControlValue("vGUID")},nac:gx.falseFn};this.declareDomainHdlr(54,function(){});this.AV16Photo_GXI="";this.AV10Photo="";this.ZV10Photo="";this.OV10Photo="";this.AV7GUID="";this.ZV7GUID="";this.OV7GUID="";this.AV10Photo="";this.AV7GUID="";this.Events={e150h2_client:["'LOGOUT'",!0],e170h2_client:["ENTER",!0],e180h2_client:["CANCEL",!0],e110h1_client:["'USEROPTIONS'",!1],e120h1_client:["'PROFILE'",!1],e130h1_client:["'CHANGEPASSWORD'",!1]};this.EvtParms.REFRESH=[[{av:"AV7GUID",fld:"vGUID",pic:"",hsh:!0,nv:""}],[]];this.EvtParms.START=[[],[{av:'gx.fn.getCtrlProperty("CURRENTREPOSITORY","Visible")',ctrl:"CURRENTREPOSITORY",prop:"Visible"},{av:'gx.fn.getCtrlProperty("TBWELCOME","Caption")',ctrl:"TBWELCOME",prop:"Caption"},{av:'gx.fn.getCtrlProperty("vGUID","Visible")',ctrl:"vGUID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("PROFILE","Class")',ctrl:"PROFILE",prop:"Class"},{av:'gx.fn.getCtrlProperty("NAME","Caption")',ctrl:"NAME",prop:"Caption"},{av:'gx.fn.getCtrlProperty("EMAIL","Caption")',ctrl:"EMAIL",prop:"Caption"},{av:"AV7GUID",fld:"vGUID",pic:"",hsh:!0,nv:""},{av:"AV10Photo",fld:"vPHOTO",pic:"",nv:""},{av:'gx.fn.getCtrlProperty("LETTER","Caption")',ctrl:"LETTER",prop:"Caption"},{av:'gx.fn.getCtrlProperty("LETTERTITTLE","Caption")',ctrl:"LETTERTITTLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("PHOTOCELL","Visible")',ctrl:"PHOTOCELL",prop:"Visible"},{av:'gx.fn.getCtrlProperty("LETTERCELL","Visible")',ctrl:"LETTERCELL",prop:"Visible"},{av:'gx.fn.getCtrlProperty("PHOTOCELLTOP","Visible")',ctrl:"PHOTOCELLTOP",prop:"Visible"},{av:'gx.fn.getCtrlProperty("LETTERCELLTOP","Visible")',ctrl:"LETTERCELLTOP",prop:"Visible"},{av:'gx.fn.getCtrlProperty("CURRENTREPOSITORY","Caption")',ctrl:"CURRENTREPOSITORY",prop:"Caption"},{av:'gx.fn.getCtrlProperty("TABLEWELCOME","Class")',ctrl:"TABLEWELCOME",prop:"Class"}]];this.EvtParms["'LOGOUT'"]=[[],[]];this.EvtParms["'USEROPTIONS'"]=[[{av:'gx.fn.getCtrlProperty("PROFILE","Class")',ctrl:"PROFILE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROFILE","Class")',ctrl:"PROFILE",prop:"Class"}]];this.EvtParms["'PROFILE'"]=[[{av:"AV7GUID",fld:"vGUID",pic:"",hsh:!0,nv:""}],[]];this.EvtParms["'CHANGEPASSWORD'"]=[[],[]];this.Initialize()})