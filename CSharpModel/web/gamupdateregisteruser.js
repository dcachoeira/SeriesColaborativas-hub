/*!   GeneXus C# 15_0_9-121631 on 9/20/2018 19:43:43.92
*/
gx.evt.autoSkip=!1;gx.define("gamupdateregisteruser",!1,function(){this.ServerClass="gamupdateregisteruser";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV18CheckRequiredFieldsResult=gx.fn.getControlValue("vCHECKREQUIREDFIELDSRESULT");this.AV5ApplicationClientId=gx.fn.getControlValue("vAPPLICATIONCLIENTID")};this.Validv_Birthday=function(){try{var n=gx.util.balloon.getNew("vBIRTHDAY");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Validv_Gender=function(){try{var n=gx.util.balloon.getNew("vGENDER");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e12152_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14151_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87];this.GXLastCtrlId=87;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TABLECONTENT",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"HEADERORIGINAL",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"TABLELOGIN",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"SIGNIN",format:0,grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"UNNAMEDTABLE1",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"UNNAMEDTABLENAME",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"TEXTBLOCKNAME",format:0,grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,lvl:0,type:"svchar",len:100,dec:60,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vNAME",gxz:"ZV14Name",gxold:"OV14Name",gxvar:"AV14Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV14Name=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14Name=n)},v2c:function(){gx.fn.setControlValue("vNAME",gx.O.AV14Name,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV14Name=this.val())},val:function(){return gx.fn.getControlValue("vNAME")},nac:gx.falseFn};this.declareDomainHdlr(30,function(){});n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"EMAIL_CELL",grid:0};n[33]={id:33,fld:"UNNAMEDTABLEEMAIL",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"TEXTBLOCKEMAIL",format:0,grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vEMAIL",gxz:"ZV7EMail",gxold:"OV7EMail",gxvar:"AV7EMail",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7EMail=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7EMail=n)},v2c:function(){gx.fn.setControlValue("vEMAIL",gx.O.AV7EMail,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV7EMail=this.val())},val:function(){return gx.fn.getControlValue("vEMAIL")},nac:gx.falseFn};this.declareDomainHdlr(39,function(){});n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"FIRSTNAME_CELL",grid:0};n[42]={id:42,fld:"UNNAMEDTABLEFIRSTNAME",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"TEXTBLOCKFIRSTNAME",format:0,grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,lvl:0,type:"char",len:60,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vFIRSTNAME",gxz:"ZV10FirstName",gxold:"OV10FirstName",gxvar:"AV10FirstName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10FirstName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10FirstName=n)},v2c:function(){gx.fn.setControlValue("vFIRSTNAME",gx.O.AV10FirstName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV10FirstName=this.val())},val:function(){return gx.fn.getControlValue("vFIRSTNAME")},nac:gx.falseFn};this.declareDomainHdlr(48,function(){});n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"LASTNAME_CELL",grid:0};n[51]={id:51,fld:"UNNAMEDTABLELASTNAME",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"TEXTBLOCKLASTNAME",format:0,grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,lvl:0,type:"char",len:60,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLASTNAME",gxz:"ZV13LastName",gxold:"OV13LastName",gxvar:"AV13LastName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV13LastName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13LastName=n)},v2c:function(){gx.fn.setControlValue("vLASTNAME",gx.O.AV13LastName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV13LastName=this.val())},val:function(){return gx.fn.getControlValue("vLASTNAME")},nac:gx.falseFn};this.declareDomainHdlr(57,function(){});n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"BIRTHDAY_CELL",grid:0};n[60]={id:60,fld:"UNNAMEDTABLEBIRTHDAY",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"TEXTBLOCKBIRTHDAY",format:0,grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Birthday,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vBIRTHDAY",gxz:"ZV6Birthday",gxold:"OV6Birthday",gxvar:"AV6Birthday",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6Birthday=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6Birthday=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vBIRTHDAY",gx.O.AV6Birthday,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV6Birthday=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("vBIRTHDAY")},nac:gx.falseFn};this.declareDomainHdlr(66,function(){});n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"GENDER_CELL",grid:0};n[69]={id:69,fld:"UNNAMEDTABLEGENDER",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"TEXTBLOCKGENDER",format:0,grid:0};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Gender,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vGENDER",gxz:"ZV11Gender",gxold:"OV11Gender",gxvar:"AV11Gender",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV11Gender=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11Gender=n)},v2c:function(){gx.fn.setComboBoxValue("vGENDER",gx.O.AV11Gender);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV11Gender=this.val())},val:function(){return gx.fn.getControlValue("vGENDER")},nac:gx.falseFn};this.declareDomainHdlr(75,function(){});n[76]={id:76,fld:"",grid:0};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"",grid:0};n[79]={id:79,fld:"",grid:0};n[80]={id:80,fld:"BTNENTER",grid:0};n[81]={id:81,fld:"",grid:0};n[82]={id:82,fld:"BTNCANCEL",grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,fld:"",grid:0};n[85]={id:85,fld:"TABLEERROR",grid:0};n[86]={id:86,fld:"",grid:0};n[87]={id:87,fld:"",grid:0};this.AV14Name="";this.ZV14Name="";this.OV14Name="";this.AV7EMail="";this.ZV7EMail="";this.OV7EMail="";this.AV10FirstName="";this.ZV10FirstName="";this.OV10FirstName="";this.AV13LastName="";this.ZV13LastName="";this.OV13LastName="";this.AV6Birthday=gx.date.nullDate();this.ZV6Birthday=gx.date.nullDate();this.OV6Birthday=gx.date.nullDate();this.AV11Gender="";this.ZV11Gender="";this.OV11Gender="";this.AV14Name="";this.AV7EMail="";this.AV10FirstName="";this.AV13LastName="";this.AV6Birthday=gx.date.nullDate();this.AV11Gender="";this.AV5ApplicationClientId="";this.AV18CheckRequiredFieldsResult=!1;this.Events={e12152_client:["ENTER",!0],e14151_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV5ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:"",hsh:!0,nv:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Backcolor"},{av:'gx.fn.getCtrlProperty("LAYOUTMAINTABLE","Class")',ctrl:"LAYOUTMAINTABLE",prop:"Class"},{av:'gx.fn.getCtrlProperty("TABLEERROR","Visible")',ctrl:"TABLEERROR",prop:"Visible"},{av:"AV14Name",fld:"vNAME",pic:"",nv:""},{av:"AV7EMail",fld:"vEMAIL",pic:"",nv:""},{av:"AV10FirstName",fld:"vFIRSTNAME",pic:"",nv:""},{av:"AV13LastName",fld:"vLASTNAME",pic:"",nv:""},{av:"AV6Birthday",fld:"vBIRTHDAY",pic:"",nv:""},{ctrl:"vGENDER"},{av:"AV11Gender",fld:"vGENDER",pic:"",nv:""},{av:'gx.fn.getCtrlProperty("EMAIL_CELL","Class")',ctrl:"EMAIL_CELL",prop:"Class"},{av:'gx.fn.getCtrlProperty("FIRSTNAME_CELL","Class")',ctrl:"FIRSTNAME_CELL",prop:"Class"},{av:'gx.fn.getCtrlProperty("LASTNAME_CELL","Class")',ctrl:"LASTNAME_CELL",prop:"Class"},{av:'gx.fn.getCtrlProperty("BIRTHDAY_CELL","Class")',ctrl:"BIRTHDAY_CELL",prop:"Class"},{av:'gx.fn.getCtrlProperty("GENDER_CELL","Class")',ctrl:"GENDER_CELL",prop:"Class"}]];this.EvtParms.ENTER=[[{av:"AV18CheckRequiredFieldsResult",fld:"vCHECKREQUIREDFIELDSRESULT",pic:"",nv:!1},{av:"AV14Name",fld:"vNAME",pic:"",nv:""},{av:"AV7EMail",fld:"vEMAIL",pic:"",nv:""},{av:"AV10FirstName",fld:"vFIRSTNAME",pic:"",nv:""},{av:"AV13LastName",fld:"vLASTNAME",pic:"",nv:""},{av:"AV6Birthday",fld:"vBIRTHDAY",pic:"",nv:""},{ctrl:"vGENDER"},{av:"AV11Gender",fld:"vGENDER",pic:"",nv:""},{av:"AV5ApplicationClientId",fld:"vAPPLICATIONCLIENTID",pic:"",hsh:!0,nv:""}],[{av:"AV18CheckRequiredFieldsResult",fld:"vCHECKREQUIREDFIELDSRESULT",pic:"",nv:!1},{av:'gx.fn.getCtrlProperty("TABLEERROR","Visible")',ctrl:"TABLEERROR",prop:"Visible"}]];this.EnterCtrl=["BTNENTER"];this.setVCMap("AV18CheckRequiredFieldsResult","vCHECKREQUIREDFIELDSRESULT",0,"boolean");this.setVCMap("AV5ApplicationClientId","vAPPLICATIONCLIENTID",0,"char");this.Initialize()});gx.createParentObj(gamupdateregisteruser)