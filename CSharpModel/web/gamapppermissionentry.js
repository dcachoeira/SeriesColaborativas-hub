/*!   GeneXus C# 15_0_9-121631 on 9/20/2018 19:45:1.83
*/
gx.evt.autoSkip=!1;gx.define("gamapppermissionentry",!1,function(){var n,t;this.ServerClass="gamapppermissionentry";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8ApplicationId=gx.fn.getIntegerValue("vAPPLICATIONID",".");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV6isOK=gx.fn.getControlValue("vISOK")};this.Validv_Accesstype=function(){try{var n=gx.util.balloon.getNew("vACCESSTYPE");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e121h2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e141h1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57];this.GXLastCtrlId=57;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","Permission","str");t.setProp("Collapsible","Collapsible",!1,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TABLECONTENT",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,lvl:0,type:"char",len:254,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"GAMAPPLICATION_NAME",gxz:"ZV32GXV1",gxold:"OV32GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV1=n)},v2z:function(n){n!==undefined&&(gx.O.ZV32GXV1=n)},v2c:function(){gx.fn.setControlValue("GAMAPPLICATION_NAME",gx.O.GXV1,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV1=this.val())},val:function(){return gx.fn.getControlValue("GAMAPPLICATION_NAME")},nac:gx.falseFn};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,lvl:0,type:"char",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vGUID",gxz:"ZV14GUID",gxold:"OV14GUID",gxvar:"AV14GUID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV14GUID=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14GUID=n)},v2c:function(){gx.fn.setControlValue("vGUID",gx.O.AV14GUID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV14GUID=this.val())},val:function(){return gx.fn.getControlValue("vGUID")},nac:gx.falseFn};this.declareDomainHdlr(30,function(){});n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,lvl:0,type:"char",len:254,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vNAME",gxz:"ZV16Name",gxold:"OV16Name",gxvar:"AV16Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV16Name=n)},v2z:function(n){n!==undefined&&(gx.O.ZV16Name=n)},v2c:function(){gx.fn.setControlValue("vNAME",gx.O.AV16Name,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV16Name=this.val())},val:function(){return gx.fn.getControlValue("vNAME")},nac:gx.falseFn};this.declareDomainHdlr(35,function(){});n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,lvl:0,type:"char",len:254,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDSC",gxz:"ZV10Dsc",gxold:"OV10Dsc",gxvar:"AV10Dsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10Dsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10Dsc=n)},v2c:function(){gx.fn.setControlValue("vDSC",gx.O.AV10Dsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV10Dsc=this.val())},val:function(){return gx.fn.getControlValue("vDSC")},nac:gx.falseFn};this.declareDomainHdlr(40,function(){});n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Accesstype,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vACCESSTYPE",gxz:"ZV20AccessType",gxold:"OV20AccessType",gxvar:"AV20AccessType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV20AccessType=n)},v2z:function(n){n!==undefined&&(gx.O.ZV20AccessType=n)},v2c:function(){gx.fn.setComboBoxValue("vACCESSTYPE",gx.O.AV20AccessType);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV20AccessType=this.val())},val:function(){return gx.fn.getControlValue("vACCESSTYPE")},nac:gx.falseFn};this.declareDomainHdlr(45,function(){});n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vISPARENT",gxz:"ZV15IsParent",gxold:"OV15IsParent",gxvar:"AV15IsParent",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.AV15IsParent=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV15IsParent=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("vISPARENT",gx.O.AV15IsParent,!0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15IsParent=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("vISPARENT")},nac:gx.falseFn,values:["true","false"]};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"BTNENTER",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"BTNCANCEL",grid:0};this.GXV1="";this.ZV32GXV1="";this.OV32GXV1="";this.AV14GUID="";this.ZV14GUID="";this.OV14GUID="";this.AV16Name="";this.ZV16Name="";this.OV16Name="";this.AV10Dsc="";this.ZV10Dsc="";this.OV10Dsc="";this.AV20AccessType="";this.ZV20AccessType="";this.OV20AccessType="";this.AV15IsParent=!1;this.ZV15IsParent=!1;this.OV15IsParent=!1;this.GXV1="";this.AV14GUID="";this.AV16Name="";this.AV10Dsc="";this.AV20AccessType="";this.AV15IsParent=!1;this.AV8ApplicationId=0;this.Gx_mode="";this.AV6isOK=!1;this.Events={e121h2_client:["ENTER",!0],e141h1_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV8ApplicationId",fld:"vAPPLICATIONID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV14GUID",fld:"vGUID",pic:"",hsh:!0,nv:""}],[]];this.EvtParms.START=[[{av:"AV8ApplicationId",fld:"vAPPLICATIONID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"AV14GUID",fld:"vGUID",pic:"",hsh:!0,nv:""},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""}],[{av:'gx.fn.getCtrlProperty("vISPARENT","Enabled")',ctrl:"vISPARENT",prop:"Enabled"},{av:"AV16Name",fld:"vNAME",pic:"",nv:""},{av:"AV10Dsc",fld:"vDSC",pic:"",nv:""},{ctrl:"vACCESSTYPE"},{av:"AV20AccessType",fld:"vACCESSTYPE",pic:"",nv:""},{av:"AV15IsParent",fld:"vISPARENT",pic:"",nv:!1},{ctrl:"BTNENTER",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vNAME","Enabled")',ctrl:"vNAME",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vDSC","Enabled")',ctrl:"vDSC",prop:"Enabled"},{ctrl:"BTNENTER",prop:"Caption"}]];this.EvtParms.ENTER=[[{av:"AV8ApplicationId",fld:"vAPPLICATIONID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"AV14GUID",fld:"vGUID",pic:"",hsh:!0,nv:""},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV16Name",fld:"vNAME",pic:"",nv:""},{av:"AV10Dsc",fld:"vDSC",pic:"",nv:""},{ctrl:"vACCESSTYPE"},{av:"AV20AccessType",fld:"vACCESSTYPE",pic:"",nv:""},{av:"AV6isOK",fld:"vISOK",pic:"",nv:!1}],[{av:"AV6isOK",fld:"vISOK",pic:"",nv:!1}]];this.EnterCtrl=["BTNENTER"];this.setVCMap("AV8ApplicationId","vAPPLICATIONID",0,"int");this.setVCMap("Gx_mode","vMODE",0,"char");this.setVCMap("AV6isOK","vISOK",0,"boolean");this.addBCProperty("Gamapplication",["Name"],this.GXValidFnc[25],"AV5GAMApplication");this.Initialize()});gx.createParentObj(gamapppermissionentry)