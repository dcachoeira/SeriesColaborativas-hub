/*!   GeneXus C# 15_0_9-121631 on 9/20/2018 19:40:59.40
*/
gx.evt.autoSkip=!1;gx.define("gamsecuritypolicyentry",!1,function(){var n,t,i,r,u;this.ServerClass="gamsecuritypolicyentry";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV9Id=gx.fn.getIntegerValue("vID",".");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Validv_Securitypolicyallowmultipleconcurrentwebsessions=function(){try{var n=gx.util.balloon.getNew("vSECURITYPOLICYALLOWMULTIPLECONCURRENTWEBSESSIONS");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e120r2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e140r1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115];this.GXLastCtrlId=115;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","Security Policy","str");t.setProp("Collapsible","Collapsible",!1,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);this.DVPANEL_UNNAMEDTABLE1Container=gx.uc.getNew(this,37,25,"BootstrapPanel","DVPANEL_UNNAMEDTABLE1Container","Dvpanel_unnamedtable1","DVPANEL_UNNAMEDTABLE1");i=this.DVPANEL_UNNAMEDTABLE1Container;i.setProp("Class","Class","","char");i.setProp("Enabled","Enabled",!0,"boolean");i.setProp("Width","Width","100%","str");i.setProp("Height","Height","100","str");i.setProp("AutoWidth","Autowidth",!1,"bool");i.setProp("AutoHeight","Autoheight",!0,"bool");i.setProp("Cls","Cls","PanelCard_BaseColor","str");i.setProp("ShowHeader","Showheader",!0,"bool");i.setProp("Title","Title","Password Configurations","str");i.setProp("Collapsible","Collapsible",!0,"bool");i.setProp("Collapsed","Collapsed",!1,"bool");i.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");i.setProp("IconPosition","Iconposition","left","str");i.setProp("AutoScroll","Autoscroll",!1,"bool");i.setProp("Visible","Visible",!0,"bool");i.setC2ShowFunction(function(n){n.show()});this.setUserControl(i);this.DVPANEL_ONLYWEBContainer=gx.uc.getNew(this,77,25,"BootstrapPanel","DVPANEL_ONLYWEBContainer","Dvpanel_onlyweb","DVPANEL_ONLYWEB");r=this.DVPANEL_ONLYWEBContainer;r.setProp("Class","Class","","char");r.setProp("Enabled","Enabled",!0,"boolean");r.setProp("Width","Width","100%","str");r.setProp("Height","Height","100","str");r.setProp("AutoWidth","Autowidth",!1,"bool");r.setProp("AutoHeight","Autoheight",!0,"bool");r.setProp("Cls","Cls","PanelCard_BaseColor","str");r.setProp("ShowHeader","Showheader",!0,"bool");r.setProp("Title","Title","Only Web","str");r.setProp("Collapsible","Collapsible",!1,"bool");r.setProp("Collapsed","Collapsed",!1,"bool");r.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");r.setProp("IconPosition","Iconposition","left","str");r.setProp("AutoScroll","Autoscroll",!1,"bool");r.setProp("Visible","Visible",!0,"bool");r.setC2ShowFunction(function(n){n.show()});this.setUserControl(r);this.DVPANEL_ONLYSDContainer=gx.uc.getNew(this,94,25,"BootstrapPanel","DVPANEL_ONLYSDContainer","Dvpanel_onlysd","DVPANEL_ONLYSD");u=this.DVPANEL_ONLYSDContainer;u.setProp("Class","Class","","char");u.setProp("Enabled","Enabled",!0,"boolean");u.setProp("Width","Width","100%","str");u.setProp("Height","Height","100","str");u.setProp("AutoWidth","Autowidth",!1,"bool");u.setProp("AutoHeight","Autoheight",!0,"bool");u.setProp("Cls","Cls","PanelCard_BaseColor","str");u.setProp("ShowHeader","Showheader",!0,"bool");u.setProp("Title","Title","Only Smart Devices","str");u.setProp("Collapsible","Collapsible",!1,"bool");u.setProp("Collapsed","Collapsed",!1,"bool");u.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");u.setProp("IconPosition","Iconposition","left","str");u.setProp("AutoScroll","Autoscroll",!1,"bool");u.setProp("Visible","Visible",!0,"bool");u.setC2ShowFunction(function(n){n.show()});this.setUserControl(u);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TABLECONTENT",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYID",gxz:"ZV32SecurityPolicyId",gxold:"OV32SecurityPolicyId",gxvar:"AV32SecurityPolicyId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV32SecurityPolicyId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV32SecurityPolicyId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYID",gx.O.AV32SecurityPolicyId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV32SecurityPolicyId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECURITYPOLICYID",".")},nac:gx.falseFn};this.declareDomainHdlr(25,function(){});n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,lvl:0,type:"char",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYGUID",gxz:"ZV33SecurityPolicyGUID",gxold:"OV33SecurityPolicyGUID",gxvar:"AV33SecurityPolicyGUID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV33SecurityPolicyGUID=n)},v2z:function(n){n!==undefined&&(gx.O.ZV33SecurityPolicyGUID=n)},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYGUID",gx.O.AV33SecurityPolicyGUID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV33SecurityPolicyGUID=this.val())},val:function(){return gx.fn.getControlValue("vSECURITYPOLICYGUID")},nac:gx.falseFn};this.declareDomainHdlr(29,function(){});n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"char",len:254,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYNAME",gxz:"ZV34SecurityPolicyName",gxold:"OV34SecurityPolicyName",gxvar:"AV34SecurityPolicyName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV34SecurityPolicyName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV34SecurityPolicyName=n)},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYNAME",gx.O.AV34SecurityPolicyName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV34SecurityPolicyName=this.val())},val:function(){return gx.fn.getControlValue("vSECURITYPOLICYNAME")},nac:gx.falseFn};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"HTML_DVPANEL_UNNAMEDTABLE1",grid:0};n[39]={id:39,fld:"LAYOUT_UNNAMEDTABLE1",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"UNNAMEDTABLE1",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYPERIODCHANGEPASSWORD",gxz:"ZV25SecurityPolicyPeriodChangePassword",gxold:"OV25SecurityPolicyPeriodChangePassword",gxvar:"AV25SecurityPolicyPeriodChangePassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV25SecurityPolicyPeriodChangePassword=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV25SecurityPolicyPeriodChangePassword=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYPERIODCHANGEPASSWORD",gx.O.AV25SecurityPolicyPeriodChangePassword,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV25SecurityPolicyPeriodChangePassword=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECURITYPOLICYPERIODCHANGEPASSWORD",".")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYMINIMUMTIMETOCHANGEPASSWORDS",gxz:"ZV26SecurityPolicyMinimumTimeToChangePasswords",gxold:"OV26SecurityPolicyMinimumTimeToChangePasswords",gxvar:"AV26SecurityPolicyMinimumTimeToChangePasswords",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV26SecurityPolicyMinimumTimeToChangePasswords=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV26SecurityPolicyMinimumTimeToChangePasswords=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYMINIMUMTIMETOCHANGEPASSWORDS",gx.O.AV26SecurityPolicyMinimumTimeToChangePasswords,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV26SecurityPolicyMinimumTimeToChangePasswords=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECURITYPOLICYMINIMUMTIMETOCHANGEPASSWORDS",".")},nac:gx.falseFn};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,lvl:0,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYMINIMUMLENGTHPASSWORD",gxz:"ZV27SecurityPolicyMinimumLengthPassword",gxold:"OV27SecurityPolicyMinimumLengthPassword",gxvar:"AV27SecurityPolicyMinimumLengthPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV27SecurityPolicyMinimumLengthPassword=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV27SecurityPolicyMinimumLengthPassword=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYMINIMUMLENGTHPASSWORD",gx.O.AV27SecurityPolicyMinimumLengthPassword,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV27SecurityPolicyMinimumLengthPassword=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECURITYPOLICYMINIMUMLENGTHPASSWORD",".")},nac:gx.falseFn};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,lvl:0,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYMINIMUMNUMERICCHARACTERSPASSWORD",gxz:"ZV28SecurityPolicyMinimumNumericCharactersPassword",gxold:"OV28SecurityPolicyMinimumNumericCharactersPassword",gxvar:"AV28SecurityPolicyMinimumNumericCharactersPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV28SecurityPolicyMinimumNumericCharactersPassword=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV28SecurityPolicyMinimumNumericCharactersPassword=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYMINIMUMNUMERICCHARACTERSPASSWORD",gx.O.AV28SecurityPolicyMinimumNumericCharactersPassword,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV28SecurityPolicyMinimumNumericCharactersPassword=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECURITYPOLICYMINIMUMNUMERICCHARACTERSPASSWORD",".")},nac:gx.falseFn};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,lvl:0,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYMINIMUMUPPERCASECHARACTERSPASSWORD",gxz:"ZV29SecurityPolicyMinimumUpperCaseCharactersPassword",gxold:"OV29SecurityPolicyMinimumUpperCaseCharactersPassword",gxvar:"AV29SecurityPolicyMinimumUpperCaseCharactersPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV29SecurityPolicyMinimumUpperCaseCharactersPassword=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV29SecurityPolicyMinimumUpperCaseCharactersPassword=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYMINIMUMUPPERCASECHARACTERSPASSWORD",gx.O.AV29SecurityPolicyMinimumUpperCaseCharactersPassword,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV29SecurityPolicyMinimumUpperCaseCharactersPassword=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECURITYPOLICYMINIMUMUPPERCASECHARACTERSPASSWORD",".")},nac:gx.falseFn};n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"",grid:0};n[67]={id:67,fld:"",grid:0};n[68]={id:68,lvl:0,type:"int",len:2,dec:0,sign:!1,pic:"Z9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYMINIMUMSPECIALCHARACTERSPASSWORD",gxz:"ZV30SecurityPolicyMinimumSpecialCharactersPassword",gxold:"OV30SecurityPolicyMinimumSpecialCharactersPassword",gxvar:"AV30SecurityPolicyMinimumSpecialCharactersPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV30SecurityPolicyMinimumSpecialCharactersPassword=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV30SecurityPolicyMinimumSpecialCharactersPassword=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYMINIMUMSPECIALCHARACTERSPASSWORD",gx.O.AV30SecurityPolicyMinimumSpecialCharactersPassword,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV30SecurityPolicyMinimumSpecialCharactersPassword=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECURITYPOLICYMINIMUMSPECIALCHARACTERSPASSWORD",".")},nac:gx.falseFn};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYMAXIMUMPASSWORDHISTORYENTRIES",gxz:"ZV31SecurityPolicyMaximumPasswordHistoryEntries",gxold:"OV31SecurityPolicyMaximumPasswordHistoryEntries",gxvar:"AV31SecurityPolicyMaximumPasswordHistoryEntries",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV31SecurityPolicyMaximumPasswordHistoryEntries=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV31SecurityPolicyMaximumPasswordHistoryEntries=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYMAXIMUMPASSWORDHISTORYENTRIES",gx.O.AV31SecurityPolicyMaximumPasswordHistoryEntries,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV31SecurityPolicyMaximumPasswordHistoryEntries=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECURITYPOLICYMAXIMUMPASSWORDHISTORYENTRIES",".")},nac:gx.falseFn};n[74]={id:74,fld:"",grid:0};n[75]={id:75,fld:"",grid:0};n[76]={id:76,fld:"HTML_DVPANEL_ONLYWEB",grid:0};n[79]={id:79,fld:"LAYOUT_ONLYWEB",grid:0};n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"ONLYWEB",grid:0};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,fld:"",grid:0};n[85]={id:85,fld:"",grid:0};n[86]={id:86,lvl:0,type:"int",len:1,dec:0,sign:!1,pic:"9",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Securitypolicyallowmultipleconcurrentwebsessions,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYALLOWMULTIPLECONCURRENTWEBSESSIONS",gxz:"ZV23SecurityPolicyAllowMultipleConcurrentWebSessions",gxold:"OV23SecurityPolicyAllowMultipleConcurrentWebSessions",gxvar:"AV23SecurityPolicyAllowMultipleConcurrentWebSessions",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV23SecurityPolicyAllowMultipleConcurrentWebSessions=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV23SecurityPolicyAllowMultipleConcurrentWebSessions=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("vSECURITYPOLICYALLOWMULTIPLECONCURRENTWEBSESSIONS",gx.O.AV23SecurityPolicyAllowMultipleConcurrentWebSessions);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV23SecurityPolicyAllowMultipleConcurrentWebSessions=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECURITYPOLICYALLOWMULTIPLECONCURRENTWEBSESSIONS",".")},nac:gx.falseFn};this.declareDomainHdlr(86,function(){});n[87]={id:87,fld:"",grid:0};n[88]={id:88,fld:"",grid:0};n[89]={id:89,fld:"",grid:0};n[90]={id:90,fld:"",grid:0};n[91]={id:91,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYWEBSESSIONTIMEOUT",gxz:"ZV24SecurityPolicyWebSessionTimeout",gxold:"OV24SecurityPolicyWebSessionTimeout",gxvar:"AV24SecurityPolicyWebSessionTimeout",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV24SecurityPolicyWebSessionTimeout=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV24SecurityPolicyWebSessionTimeout=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYWEBSESSIONTIMEOUT",gx.O.AV24SecurityPolicyWebSessionTimeout,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV24SecurityPolicyWebSessionTimeout=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECURITYPOLICYWEBSESSIONTIMEOUT",".")},nac:gx.falseFn};n[92]={id:92,fld:"",grid:0};n[93]={id:93,fld:"HTML_DVPANEL_ONLYSD",grid:0};n[96]={id:96,fld:"LAYOUT_ONLYSD",grid:0};n[97]={id:97,fld:"",grid:0};n[98]={id:98,fld:"ONLYSD",grid:0};n[99]={id:99,fld:"",grid:0};n[100]={id:100,fld:"",grid:0};n[101]={id:101,fld:"",grid:0};n[102]={id:102,fld:"",grid:0};n[103]={id:103,lvl:0,type:"int",len:6,dec:0,sign:!1,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYOAUTHTOKENEXPIRE",gxz:"ZV22SecurityPolicyOauthTokenExpire",gxold:"OV22SecurityPolicyOauthTokenExpire",gxvar:"AV22SecurityPolicyOauthTokenExpire",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV22SecurityPolicyOauthTokenExpire=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV22SecurityPolicyOauthTokenExpire=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYOAUTHTOKENEXPIRE",gx.O.AV22SecurityPolicyOauthTokenExpire,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV22SecurityPolicyOauthTokenExpire=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECURITYPOLICYOAUTHTOKENEXPIRE",".")},nac:gx.falseFn};n[104]={id:104,fld:"",grid:0};n[105]={id:105,fld:"",grid:0};n[106]={id:106,fld:"",grid:0};n[107]={id:107,fld:"",grid:0};n[108]={id:108,lvl:0,type:"int",len:6,dec:0,sign:!1,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECURITYPOLICYOAUTHTOKENMAXIMUMRENOVATIONS",gxz:"ZV35SecurityPolicyOauthTokenMaximumRenovations",gxold:"OV35SecurityPolicyOauthTokenMaximumRenovations",gxvar:"AV35SecurityPolicyOauthTokenMaximumRenovations",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV35SecurityPolicyOauthTokenMaximumRenovations=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV35SecurityPolicyOauthTokenMaximumRenovations=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vSECURITYPOLICYOAUTHTOKENMAXIMUMRENOVATIONS",gx.O.AV35SecurityPolicyOauthTokenMaximumRenovations,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV35SecurityPolicyOauthTokenMaximumRenovations=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vSECURITYPOLICYOAUTHTOKENMAXIMUMRENOVATIONS",".")},nac:gx.falseFn};n[109]={id:109,fld:"",grid:0};n[110]={id:110,fld:"",grid:0};n[111]={id:111,fld:"",grid:0};n[112]={id:112,fld:"",grid:0};n[113]={id:113,fld:"BTNENTER",grid:0};n[114]={id:114,fld:"",grid:0};n[115]={id:115,fld:"BTNCANCEL",grid:0};this.AV32SecurityPolicyId=0;this.ZV32SecurityPolicyId=0;this.OV32SecurityPolicyId=0;this.AV33SecurityPolicyGUID="";this.ZV33SecurityPolicyGUID="";this.OV33SecurityPolicyGUID="";this.AV34SecurityPolicyName="";this.ZV34SecurityPolicyName="";this.OV34SecurityPolicyName="";this.AV25SecurityPolicyPeriodChangePassword=0;this.ZV25SecurityPolicyPeriodChangePassword=0;this.OV25SecurityPolicyPeriodChangePassword=0;this.AV26SecurityPolicyMinimumTimeToChangePasswords=0;this.ZV26SecurityPolicyMinimumTimeToChangePasswords=0;this.OV26SecurityPolicyMinimumTimeToChangePasswords=0;this.AV27SecurityPolicyMinimumLengthPassword=0;this.ZV27SecurityPolicyMinimumLengthPassword=0;this.OV27SecurityPolicyMinimumLengthPassword=0;this.AV28SecurityPolicyMinimumNumericCharactersPassword=0;this.ZV28SecurityPolicyMinimumNumericCharactersPassword=0;this.OV28SecurityPolicyMinimumNumericCharactersPassword=0;this.AV29SecurityPolicyMinimumUpperCaseCharactersPassword=0;this.ZV29SecurityPolicyMinimumUpperCaseCharactersPassword=0;this.OV29SecurityPolicyMinimumUpperCaseCharactersPassword=0;this.AV30SecurityPolicyMinimumSpecialCharactersPassword=0;this.ZV30SecurityPolicyMinimumSpecialCharactersPassword=0;this.OV30SecurityPolicyMinimumSpecialCharactersPassword=0;this.AV31SecurityPolicyMaximumPasswordHistoryEntries=0;this.ZV31SecurityPolicyMaximumPasswordHistoryEntries=0;this.OV31SecurityPolicyMaximumPasswordHistoryEntries=0;this.AV23SecurityPolicyAllowMultipleConcurrentWebSessions=0;this.ZV23SecurityPolicyAllowMultipleConcurrentWebSessions=0;this.OV23SecurityPolicyAllowMultipleConcurrentWebSessions=0;this.AV24SecurityPolicyWebSessionTimeout=0;this.ZV24SecurityPolicyWebSessionTimeout=0;this.OV24SecurityPolicyWebSessionTimeout=0;this.AV22SecurityPolicyOauthTokenExpire=0;this.ZV22SecurityPolicyOauthTokenExpire=0;this.OV22SecurityPolicyOauthTokenExpire=0;this.AV35SecurityPolicyOauthTokenMaximumRenovations=0;this.ZV35SecurityPolicyOauthTokenMaximumRenovations=0;this.OV35SecurityPolicyOauthTokenMaximumRenovations=0;this.AV32SecurityPolicyId=0;this.AV33SecurityPolicyGUID="";this.AV34SecurityPolicyName="";this.AV25SecurityPolicyPeriodChangePassword=0;this.AV26SecurityPolicyMinimumTimeToChangePasswords=0;this.AV27SecurityPolicyMinimumLengthPassword=0;this.AV28SecurityPolicyMinimumNumericCharactersPassword=0;this.AV29SecurityPolicyMinimumUpperCaseCharactersPassword=0;this.AV30SecurityPolicyMinimumSpecialCharactersPassword=0;this.AV31SecurityPolicyMaximumPasswordHistoryEntries=0;this.AV23SecurityPolicyAllowMultipleConcurrentWebSessions=0;this.AV24SecurityPolicyWebSessionTimeout=0;this.AV22SecurityPolicyOauthTokenExpire=0;this.AV35SecurityPolicyOauthTokenMaximumRenovations=0;this.AV9Id=0;this.Gx_mode="";this.Events={e120r2_client:["ENTER",!0],e140r1_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV9Id",fld:"vID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV33SecurityPolicyGUID",fld:"vSECURITYPOLICYGUID",pic:"",hsh:!0,nv:""}],[]];this.EvtParms.START=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV9Id",fld:"vID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV32SecurityPolicyId",fld:"vSECURITYPOLICYID",pic:"ZZZZZZZZ9",nv:0},{av:"AV33SecurityPolicyGUID",fld:"vSECURITYPOLICYGUID",pic:"",hsh:!0,nv:""},{av:"AV34SecurityPolicyName",fld:"vSECURITYPOLICYNAME",pic:"",nv:""},{av:"AV25SecurityPolicyPeriodChangePassword",fld:"vSECURITYPOLICYPERIODCHANGEPASSWORD",pic:"ZZZ9",nv:0},{av:"AV26SecurityPolicyMinimumTimeToChangePasswords",fld:"vSECURITYPOLICYMINIMUMTIMETOCHANGEPASSWORDS",pic:"ZZZ9",nv:0},{av:"AV27SecurityPolicyMinimumLengthPassword",fld:"vSECURITYPOLICYMINIMUMLENGTHPASSWORD",pic:"Z9",nv:0},{av:"AV28SecurityPolicyMinimumNumericCharactersPassword",fld:"vSECURITYPOLICYMINIMUMNUMERICCHARACTERSPASSWORD",pic:"Z9",nv:0},{av:"AV29SecurityPolicyMinimumUpperCaseCharactersPassword",fld:"vSECURITYPOLICYMINIMUMUPPERCASECHARACTERSPASSWORD",pic:"Z9",nv:0},{av:"AV30SecurityPolicyMinimumSpecialCharactersPassword",fld:"vSECURITYPOLICYMINIMUMSPECIALCHARACTERSPASSWORD",pic:"Z9",nv:0},{av:"AV31SecurityPolicyMaximumPasswordHistoryEntries",fld:"vSECURITYPOLICYMAXIMUMPASSWORDHISTORYENTRIES",pic:"ZZZ9",nv:0},{ctrl:"vSECURITYPOLICYALLOWMULTIPLECONCURRENTWEBSESSIONS"},{av:"AV23SecurityPolicyAllowMultipleConcurrentWebSessions",fld:"vSECURITYPOLICYALLOWMULTIPLECONCURRENTWEBSESSIONS",pic:"9",nv:0},{av:"AV24SecurityPolicyWebSessionTimeout",fld:"vSECURITYPOLICYWEBSESSIONTIMEOUT",pic:"ZZZ9",nv:0},{av:"AV22SecurityPolicyOauthTokenExpire",fld:"vSECURITYPOLICYOAUTHTOKENEXPIRE",pic:"ZZZZZ9",nv:0},{av:"AV35SecurityPolicyOauthTokenMaximumRenovations",fld:"vSECURITYPOLICYOAUTHTOKENMAXIMUMRENOVATIONS",pic:"ZZZZZ9",nv:0},{ctrl:"BTNENTER",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vSECURITYPOLICYNAME","Enabled")',ctrl:"vSECURITYPOLICYNAME",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vSECURITYPOLICYWEBSESSIONTIMEOUT","Enabled")',ctrl:"vSECURITYPOLICYWEBSESSIONTIMEOUT",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vSECURITYPOLICYOAUTHTOKENEXPIRE","Enabled")',ctrl:"vSECURITYPOLICYOAUTHTOKENEXPIRE",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vSECURITYPOLICYOAUTHTOKENMAXIMUMRENOVATIONS","Enabled")',ctrl:"vSECURITYPOLICYOAUTHTOKENMAXIMUMRENOVATIONS",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vSECURITYPOLICYPERIODCHANGEPASSWORD","Enabled")',ctrl:"vSECURITYPOLICYPERIODCHANGEPASSWORD",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vSECURITYPOLICYMINIMUMTIMETOCHANGEPASSWORDS","Enabled")',ctrl:"vSECURITYPOLICYMINIMUMTIMETOCHANGEPASSWORDS",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vSECURITYPOLICYMINIMUMLENGTHPASSWORD","Enabled")',ctrl:"vSECURITYPOLICYMINIMUMLENGTHPASSWORD",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vSECURITYPOLICYMINIMUMNUMERICCHARACTERSPASSWORD","Enabled")',ctrl:"vSECURITYPOLICYMINIMUMNUMERICCHARACTERSPASSWORD",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vSECURITYPOLICYMINIMUMUPPERCASECHARACTERSPASSWORD","Enabled")',ctrl:"vSECURITYPOLICYMINIMUMUPPERCASECHARACTERSPASSWORD",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vSECURITYPOLICYMINIMUMSPECIALCHARACTERSPASSWORD","Enabled")',ctrl:"vSECURITYPOLICYMINIMUMSPECIALCHARACTERSPASSWORD",prop:"Enabled"},{av:'gx.fn.getCtrlProperty("vSECURITYPOLICYMAXIMUMPASSWORDHISTORYENTRIES","Enabled")',ctrl:"vSECURITYPOLICYMAXIMUMPASSWORDHISTORYENTRIES",prop:"Enabled"},{ctrl:"BTNENTER",prop:"Caption"}]];this.EvtParms.ENTER=[[{av:"AV9Id",fld:"vID",pic:"ZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV33SecurityPolicyGUID",fld:"vSECURITYPOLICYGUID",pic:"",hsh:!0,nv:""},{av:"AV34SecurityPolicyName",fld:"vSECURITYPOLICYNAME",pic:"",nv:""},{av:"AV25SecurityPolicyPeriodChangePassword",fld:"vSECURITYPOLICYPERIODCHANGEPASSWORD",pic:"ZZZ9",nv:0},{av:"AV26SecurityPolicyMinimumTimeToChangePasswords",fld:"vSECURITYPOLICYMINIMUMTIMETOCHANGEPASSWORDS",pic:"ZZZ9",nv:0},{av:"AV27SecurityPolicyMinimumLengthPassword",fld:"vSECURITYPOLICYMINIMUMLENGTHPASSWORD",pic:"Z9",nv:0},{av:"AV28SecurityPolicyMinimumNumericCharactersPassword",fld:"vSECURITYPOLICYMINIMUMNUMERICCHARACTERSPASSWORD",pic:"Z9",nv:0},{av:"AV29SecurityPolicyMinimumUpperCaseCharactersPassword",fld:"vSECURITYPOLICYMINIMUMUPPERCASECHARACTERSPASSWORD",pic:"Z9",nv:0},{av:"AV30SecurityPolicyMinimumSpecialCharactersPassword",fld:"vSECURITYPOLICYMINIMUMSPECIALCHARACTERSPASSWORD",pic:"Z9",nv:0},{av:"AV31SecurityPolicyMaximumPasswordHistoryEntries",fld:"vSECURITYPOLICYMAXIMUMPASSWORDHISTORYENTRIES",pic:"ZZZ9",nv:0},{ctrl:"vSECURITYPOLICYALLOWMULTIPLECONCURRENTWEBSESSIONS"},{av:"AV23SecurityPolicyAllowMultipleConcurrentWebSessions",fld:"vSECURITYPOLICYALLOWMULTIPLECONCURRENTWEBSESSIONS",pic:"9",nv:0},{av:"AV24SecurityPolicyWebSessionTimeout",fld:"vSECURITYPOLICYWEBSESSIONTIMEOUT",pic:"ZZZ9",nv:0},{av:"AV22SecurityPolicyOauthTokenExpire",fld:"vSECURITYPOLICYOAUTHTOKENEXPIRE",pic:"ZZZZZ9",nv:0},{av:"AV35SecurityPolicyOauthTokenMaximumRenovations",fld:"vSECURITYPOLICYOAUTHTOKENMAXIMUMRENOVATIONS",pic:"ZZZZZ9",nv:0}],[{av:"AV32SecurityPolicyId",fld:"vSECURITYPOLICYID",pic:"ZZZZZZZZ9",nv:0}]];this.EnterCtrl=["BTNENTER"];this.setVCMap("AV9Id","vID",0,"int");this.setVCMap("Gx_mode","vMODE",0,"char");this.Initialize()});gx.createParentObj(gamsecuritypolicyentry)