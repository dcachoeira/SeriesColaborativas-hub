/*!   GeneXus C# 15_0_9-121631 on 9/20/2018 19:46:1.27
*/
gx.evt.autoSkip=!1;gx.define("gamappmenuoptionentry",!1,function(){var n,t;this.ServerClass="gamappmenuoptionentry";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV10ApplicationId=gx.fn.getIntegerValue("vAPPLICATIONID",".");this.AV22MenuId=gx.fn.getIntegerValue("vMENUID",".");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV18Id=gx.fn.getIntegerValue("vID",".");this.AV6isOK=gx.fn.getControlValue("vISOK")};this.Validv_Type=function(){try{var n=gx.util.balloon.getNew("vTYPE");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.s112_client=function(){this.AV37Type=="M"?(gx.fn.setCtrlProperty("vMENUSID","Visible",!0),gx.fn.setCtrlProperty("MENUSID_CELL","Class","col-xs-12 DataContentCell")):(gx.fn.setCtrlProperty("vMENUSID","Visible",!1),gx.fn.setCtrlProperty("MENUSID_CELL","Class","Invisible"));this.AV37Type=="S"?(gx.fn.setCtrlProperty("vRELRESID","Visible",!0),gx.fn.setCtrlProperty("RELRESID_CELL","Class","col-xs-12 DataContentCell")):(gx.fn.setCtrlProperty("vRELRESID","Visible",!1),gx.fn.setCtrlProperty("RELRESID_CELL","Class","Invisible"))};this.e121s2_client=function(){return this.executeServerEvent("VTYPE.CLICK",!0,null,!1,!0)};this.e131s2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e141s2_client=function(){return this.executeServerEvent("VRELRESID.ISVALID",!0,null,!1,!0)};this.e161s1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87];this.GXLastCtrlId=87;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","Menu Option","str");t.setProp("Collapsible","Collapsible",!1,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"TABLECONTENT",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,lvl:0,type:"char",len:254,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"GAMAPPLICATION_NAME",gxz:"ZV49GXV1",gxold:"OV49GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV1=n)},v2z:function(n){n!==undefined&&(gx.O.ZV49GXV1=n)},v2c:function(){gx.fn.setControlValue("GAMAPPLICATION_NAME",gx.O.GXV1,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV1=this.val())},val:function(){return gx.fn.getControlValue("GAMAPPLICATION_NAME")},nac:gx.falseFn};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,lvl:0,type:"char",len:254,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"APPLICATIONMENU_NAME",gxz:"ZV50GXV2",gxold:"OV50GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV2=n)},v2z:function(n){n!==undefined&&(gx.O.ZV50GXV2=n)},v2c:function(){gx.fn.setControlValue("APPLICATIONMENU_NAME",gx.O.GXV2,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV2=this.val())},val:function(){return gx.fn.getControlValue("APPLICATIONMENU_NAME")},nac:gx.falseFn};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,lvl:0,type:"char",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vGUID",gxz:"ZV17GUID",gxold:"OV17GUID",gxvar:"AV17GUID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV17GUID=n)},v2z:function(n){n!==undefined&&(gx.O.ZV17GUID=n)},v2c:function(){gx.fn.setControlValue("vGUID",gx.O.AV17GUID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV17GUID=this.val())},val:function(){return gx.fn.getControlValue("vGUID")},nac:gx.falseFn};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,lvl:0,type:"char",len:254,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vNAME",gxz:"ZV25Name",gxold:"OV25Name",gxvar:"AV25Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV25Name=n)},v2z:function(n){n!==undefined&&(gx.O.ZV25Name=n)},v2c:function(){gx.fn.setControlValue("vNAME",gx.O.AV25Name,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV25Name=this.val())},val:function(){return gx.fn.getControlValue("vNAME")},nac:gx.falseFn};this.declareDomainHdlr(40,function(){});n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,lvl:0,type:"char",len:254,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDSC",gxz:"ZV13Dsc",gxold:"OV13Dsc",gxvar:"AV13Dsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV13Dsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13Dsc=n)},v2c:function(){gx.fn.setControlValue("vDSC",gx.O.AV13Dsc,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV13Dsc=this.val())},val:function(){return gx.fn.getControlValue("vDSC")},nac:gx.falseFn};this.declareDomainHdlr(45,function(){});n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,lvl:0,type:"char",len:1,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Type,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vTYPE",gxz:"ZV37Type",gxold:"OV37Type",gxvar:"AV37Type",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV37Type=n)},v2z:function(n){n!==undefined&&(gx.O.ZV37Type=n)},v2c:function(){gx.fn.setComboBoxValue("vTYPE",gx.O.AV37Type);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV37Type=this.val())},val:function(){return gx.fn.getControlValue("vTYPE")},nac:gx.falseFn,evt:"e121s2_client"};this.declareDomainHdlr(50,function(){});n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"MENUSID_CELL",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,lvl:0,type:"int",len:12,dec:0,sign:!1,pic:"ZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vMENUSID",gxz:"ZV24MenusId",gxold:"OV24MenusId",gxvar:"AV24MenusId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV24MenusId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV24MenusId=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("vMENUSID",gx.O.AV24MenusId);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV24MenusId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vMENUSID",".")},nac:gx.falseFn};this.declareDomainHdlr(55,function(){});n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"RELRESID_CELL",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,lvl:0,type:"char",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:"e141s2_client",evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vRELRESID",gxz:"ZV32RelResId",gxold:"OV32RelResId",gxvar:"AV32RelResId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV32RelResId=n)},v2z:function(n){n!==undefined&&(gx.O.ZV32RelResId=n)},v2c:function(){gx.fn.setComboBoxValue("vRELRESID",gx.O.AV32RelResId);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV32RelResId=this.val())},val:function(){return gx.fn.getControlValue("vRELRESID")},nac:gx.falseFn};this.declareDomainHdlr(60,function(){});n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,lvl:0,type:"svchar",len:2048,dec:250,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vRESOURCE",gxz:"ZV34Resource",gxold:"OV34Resource",gxvar:"AV34Resource",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV34Resource=n)},v2z:function(n){n!==undefined&&(gx.O.ZV34Resource=n)},v2c:function(){gx.fn.setControlValue("vRESOURCE",gx.O.AV34Resource,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV34Resource=this.val())},val:function(){return gx.fn.getControlValue("vRESOURCE")},nac:gx.falseFn};this.declareDomainHdlr(65,function(){});n[66]={id:66,fld:"",grid:0};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"",grid:0};n[70]={id:70,lvl:0,type:"svchar",len:2048,dec:250,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vRESOURCEPARAMETERS",gxz:"ZV35ResourceParameters",gxold:"OV35ResourceParameters",gxvar:"AV35ResourceParameters",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV35ResourceParameters=n)},v2z:function(n){n!==undefined&&(gx.O.ZV35ResourceParameters=n)},v2c:function(){gx.fn.setControlValue("vRESOURCEPARAMETERS",gx.O.AV35ResourceParameters,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV35ResourceParameters=this.val())},val:function(){return gx.fn.getControlValue("vRESOURCEPARAMETERS")},nac:gx.falseFn};this.declareDomainHdlr(70,function(){});n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vICONCLASS",gxz:"ZV43IconClass",gxold:"OV43IconClass",gxvar:"AV43IconClass",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV43IconClass=n)},v2z:function(n){n!==undefined&&(gx.O.ZV43IconClass=n)},v2c:function(){gx.fn.setControlValue("vICONCLASS",gx.O.AV43IconClass,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV43IconClass=this.val())},val:function(){return gx.fn.getControlValue("vICONCLASS")},nac:gx.falseFn};n[76]={id:76,fld:"",grid:0};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"",grid:0};n[79]={id:79,fld:"",grid:0};n[80]={id:80,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINK",gxz:"ZV44Link",gxold:"OV44Link",gxvar:"AV44Link",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV44Link=n)},v2z:function(n){n!==undefined&&(gx.O.ZV44Link=n)},v2c:function(){gx.fn.setComboBoxValue("vLINK",gx.O.AV44Link)},c2v:function(){this.val()!==undefined&&(gx.O.AV44Link=this.val())},val:function(){return gx.fn.getControlValue("vLINK")},nac:gx.falseFn};n[81]={id:81,fld:"",grid:0};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,fld:"",grid:0};n[85]={id:85,fld:"BTNENTER",grid:0};n[86]={id:86,fld:"",grid:0};n[87]={id:87,fld:"BTNCANCEL",grid:0};this.GXV1="";this.ZV49GXV1="";this.OV49GXV1="";this.GXV2="";this.ZV50GXV2="";this.OV50GXV2="";this.AV17GUID="";this.ZV17GUID="";this.OV17GUID="";this.AV25Name="";this.ZV25Name="";this.OV25Name="";this.AV13Dsc="";this.ZV13Dsc="";this.OV13Dsc="";this.AV37Type="";this.ZV37Type="";this.OV37Type="";this.AV24MenusId=0;this.ZV24MenusId=0;this.OV24MenusId=0;this.AV32RelResId="";this.ZV32RelResId="";this.OV32RelResId="";this.AV34Resource="";this.ZV34Resource="";this.OV34Resource="";this.AV35ResourceParameters="";this.ZV35ResourceParameters="";this.OV35ResourceParameters="";this.AV43IconClass="";this.ZV43IconClass="";this.OV43IconClass="";this.AV44Link="";this.ZV44Link="";this.OV44Link="";this.GXV1="";this.GXV2="";this.AV17GUID="";this.AV25Name="";this.AV13Dsc="";this.AV37Type="";this.AV24MenusId=0;this.AV32RelResId="";this.AV34Resource="";this.AV35ResourceParameters="";this.AV43IconClass="";this.AV44Link="";this.AV10ApplicationId=0;this.AV22MenuId=0;this.AV18Id=0;this.Gx_mode="";this.AV6isOK=!1;this.Events={e121s2_client:["VTYPE.CLICK",!0],e131s2_client:["ENTER",!0],e141s2_client:["VRELRESID.ISVALID",!0],e161s1_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV10ApplicationId",fld:"vAPPLICATIONID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"AV22MenuId",fld:"vMENUID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV18Id",fld:"vID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.START=[[{av:"AV10ApplicationId",fld:"vAPPLICATIONID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"AV22MenuId",fld:"vMENUID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV18Id",fld:"vID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{ctrl:"vTYPE"},{av:"AV37Type",fld:"vTYPE",pic:"",nv:""},{ctrl:"vRELRESID"},{av:"AV32RelResId",fld:"vRELRESID",pic:"",nv:""},{ctrl:"vMENUSID"},{av:"AV24MenusId",fld:"vMENUSID",pic:"ZZZZZZZZZZZ9",nv:0}],[{av:"AV25Name",fld:"vNAME",pic:"",nv:""},{av:"AV13Dsc",fld:"vDSC",pic:"",nv:""},{av:"AV17GUID",fld:"vGUID",pic:"",nv:""},{ctrl:"vTYPE"},{av:"AV37Type",fld:"vTYPE",pic:"",nv:""},{ctrl:"vMENUSID"},{av:"AV24MenusId",fld:"vMENUSID",pic:"ZZZZZZZZZZZ9",nv:0},{ctrl:"vRELRESID"},{av:"AV32RelResId",fld:"vRELRESID",pic:"",nv:""},{av:"AV34Resource",fld:"vRESOURCE",pic:"",nv:""},{av:"AV35ResourceParameters",fld:"vRESOURCEPARAMETERS",pic:"",nv:""},{av:"AV43IconClass",fld:"vICONCLASS",pic:"",nv:""},{ctrl:"vLINK"},{av:"AV44Link",fld:"vLINK",pic:"",nv:""},{av:'gx.fn.getCtrlProperty("vGUID","Enabled")',ctrl:"vGUID",prop:"Enabled"},{ctrl:"BTNENTER",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vNAME","Enabled")',ctrl:"vNAME",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vDSC","Enabled")',ctrl:"vDSC",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vRESOURCE","Enabled")',ctrl:"vRESOURCE",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vRESOURCEPARAMETERS","Enabled")',ctrl:"vRESOURCEPARAMETERS",prop:"Enabled"},{ctrl:"BTNENTER",prop:"Caption"},{av:'gx.fn.getCtrlProperty("vICONCLASS","Enabled")',ctrl:"vICONCLASS",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("MENUSID_CELL","Class")',ctrl:"MENUSID_CELL",prop:"Class"},{av:'gx.fn.getCtrlProperty("RELRESID_CELL","Class")',ctrl:"RELRESID_CELL",prop:"Class"}]];this.EvtParms["VTYPE.CLICK"]=[[{ctrl:"vTYPE"},{av:"AV37Type",fld:"vTYPE",pic:"",nv:""},{ctrl:"vRELRESID"},{av:"AV32RelResId",fld:"vRELRESID",pic:"",nv:""},{av:"AV10ApplicationId",fld:"vAPPLICATIONID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{ctrl:"vMENUSID"},{av:"AV24MenusId",fld:"vMENUSID",pic:"ZZZZZZZZZZZ9",nv:0},{av:"AV22MenuId",fld:"vMENUID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0}],[{ctrl:"vRELRESID"},{av:"AV32RelResId",fld:"vRELRESID",pic:"",nv:""},{ctrl:"vMENUSID"},{av:"AV24MenusId",fld:"vMENUSID",pic:"ZZZZZZZZZZZ9",nv:0},{av:'gx.fn.getCtrlProperty("MENUSID_CELL","Class")',ctrl:"MENUSID_CELL",prop:"Class"},{av:'gx.fn.getCtrlProperty("RELRESID_CELL","Class")',ctrl:"RELRESID_CELL",prop:"Class"}]];this.EvtParms.ENTER=[[{av:"AV10ApplicationId",fld:"vAPPLICATIONID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"AV25Name",fld:"vNAME",pic:"",nv:""},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV22MenuId",fld:"vMENUID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"AV18Id",fld:"vID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"AV6isOK",fld:"vISOK",pic:"",nv:!1},{av:"AV17GUID",fld:"vGUID",pic:"",nv:""},{av:"AV13Dsc",fld:"vDSC",pic:"",nv:""},{ctrl:"vTYPE"},{av:"AV37Type",fld:"vTYPE",pic:"",nv:""},{ctrl:"vMENUSID"},{av:"AV24MenusId",fld:"vMENUSID",pic:"ZZZZZZZZZZZ9",nv:0},{ctrl:"vRELRESID"},{av:"AV32RelResId",fld:"vRELRESID",pic:"",nv:""},{av:"AV34Resource",fld:"vRESOURCE",pic:"",nv:""},{av:"AV35ResourceParameters",fld:"vRESOURCEPARAMETERS",pic:"",nv:""},{av:"AV43IconClass",fld:"vICONCLASS",pic:"",nv:""},{ctrl:"vLINK"},{av:"AV44Link",fld:"vLINK",pic:"",nv:""}],[{av:"AV6isOK",fld:"vISOK",pic:"",nv:!1}]];this.EvtParms["VRELRESID.ISVALID"]=[[{av:"AV10ApplicationId",fld:"vAPPLICATIONID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{ctrl:"vRELRESID"},{av:"AV32RelResId",fld:"vRELRESID",pic:"",nv:""}],[{av:"AV34Resource",fld:"vRESOURCE",pic:"",nv:""}]];this.EnterCtrl=["BTNENTER"];this.setVCMap("AV10ApplicationId","vAPPLICATIONID",0,"int");this.setVCMap("AV22MenuId","vMENUID",0,"int");this.setVCMap("Gx_mode","vMODE",0,"char");this.setVCMap("AV18Id","vID",0,"int");this.setVCMap("AV6isOK","vISOK",0,"boolean");this.addBCProperty("Gamapplication",["Name"],this.GXValidFnc[25],"AV5GAMApplication");this.addBCProperty("Applicationmenu",["Name"],this.GXValidFnc[30],"AV11ApplicationMenu");this.Initialize()});gx.createParentObj(gamappmenuoptionentry)