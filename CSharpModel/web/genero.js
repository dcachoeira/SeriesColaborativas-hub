/*!   GeneXus C# 15_0_9-121631 on 9/25/2018 19:6:39.99
*/
gx.evt.autoSkip=!1;gx.define("genero",!1,function(){var n,t;this.ServerClass="genero";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7GeneroId=gx.fn.getIntegerValue("vGENEROID",".");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Generoid=function(){try{var n=gx.util.balloon.getNew("GENEROID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Generonome=function(){try{var n=gx.util.balloon.getNew("GENERONOME");if(this.AnyError=0,""==this.A49GeneroNome)try{n.setError("Nome é obrigatório.");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e120b2_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e130b11_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e140b11_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43];this.GXLastCtrlId=43;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","Informações Gerais","str");t.setProp("Collapsible","Collapsible",!1,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"TABLECONTENT",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Generonome,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"GENERONOME",gxz:"Z49GeneroNome",gxold:"O49GeneroNome",gxvar:"A49GeneroNome",ucs:[],op:[25],ip:[25],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A49GeneroNome=n)},v2z:function(n){n!==undefined&&(gx.O.Z49GeneroNome=n)},v2c:function(){gx.fn.setControlValue("GENERONOME",gx.O.A49GeneroNome,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A49GeneroNome=this.val())},val:function(){return gx.fn.getControlValue("GENERONOME")},nac:gx.falseFn};this.declareDomainHdlr(25,function(){});n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"GENEROINATIVO",gxz:"Z50GeneroInativo",gxold:"O50GeneroInativo",gxvar:"A50GeneroInativo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.A50GeneroInativo=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z50GeneroInativo=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("GENEROINATIVO",gx.O.A50GeneroInativo,!0)},c2v:function(){this.val()!==undefined&&(gx.O.A50GeneroInativo=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("GENEROINATIVO")},nac:gx.falseFn,values:["true","false"]};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"BTNTRN_CANCEL",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"BTNTRN_ENTER",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"BTNTRN_DELETE",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};n[43]={id:43,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Generoid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"GENEROID",gxz:"Z48GeneroId",gxold:"O48GeneroId",gxvar:"A48GeneroId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A48GeneroId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z48GeneroId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("GENEROID",gx.O.A48GeneroId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A48GeneroId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("GENEROID",".")},nac:gx.falseFn};this.declareDomainHdlr(43,function(){});this.A49GeneroNome="";this.Z49GeneroNome="";this.O49GeneroNome="";this.A50GeneroInativo=!1;this.Z50GeneroInativo=!1;this.O50GeneroInativo=!1;this.A48GeneroId=0;this.Z48GeneroId=0;this.O48GeneroId=0;this.AV8WWPContext={UsuarioId:0,UsuarioNome:"",UsuarioLogin:""};this.AV11TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV7GeneroId=0;this.AV12WebSession={};this.A48GeneroId=0;this.A49GeneroNome="";this.A50GeneroInativo=!1;this.Gx_mode="";this.Events={e120b2_client:["AFTER TRN",!0],e130b11_client:["ENTER",!0],e140b11_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV7GeneroId",fld:"vGENEROID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV7GeneroId",fld:"vGENEROID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"A48GeneroId",fld:"GENEROID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms.START=[[],[{av:"AV8WWPContext",fld:"vWWPCONTEXT",pic:"",nv:null},{av:"AV11TrnContext",fld:"vTRNCONTEXT",pic:"",nv:null},{av:'gx.fn.getCtrlProperty("GENEROID","Visible")',ctrl:"GENEROID",prop:"Visible"}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV11TrnContext",fld:"vTRNCONTEXT",pic:"",nv:null}],[]];this.EnterCtrl=["BTNTRN_ENTER"];this.setVCMap("AV7GeneroId","vGENEROID",0,"int");this.setVCMap("Gx_mode","vMODE",0,"char");this.setVCMap("AV11TrnContext","vTRNCONTEXT",0,"WWPBaseObjectsWWPTransactionContext");this.Initialize()});gx.createParentObj(genero)