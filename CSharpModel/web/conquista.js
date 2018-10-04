/*!   GeneXus C# 15_0_9-121631 on 9/25/2018 19:6:24.37
*/
gx.evt.autoSkip=!1;gx.define("conquista",!1,function(){var n,t;this.ServerClass="conquista";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7ConquistaId=gx.fn.getIntegerValue("vCONQUISTAID",".");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Conquistaid=function(){try{var n=gx.util.balloon.getNew("CONQUISTAID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Conquistanome=function(){try{var n=gx.util.balloon.getNew("CONQUISTANOME");if(this.AnyError=0,""==this.A29ConquistaNome)try{n.setError("Nome é obrigatório.");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Conquistapontos=function(){try{var n=gx.util.balloon.getNew("CONQUISTAPONTOS");if(this.AnyError=0,0==this.A28ConquistaPontos)try{n.setError("Pontos é obrigatório.");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Conquistatipo=function(){try{var n=gx.util.balloon.getNew("CONQUISTATIPO");if(this.AnyError=0,!(this.A44ConquistaTipo==1||this.A44ConquistaTipo==2||this.A44ConquistaTipo==3))try{n.setError("Campo Tipo de conquista fora do intervalo");this.AnyError=gx.num.trunc(1,0)}catch(t){}if(0==this.A44ConquistaTipo)try{n.setError("Tipo de conquista é obrigatório.");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Conquistaquantidadenecessaria=function(){try{var n=gx.util.balloon.getNew("CONQUISTAQUANTIDADENECESSARIA");if(this.AnyError=0,0==this.A45ConquistaQuantidadeNecessaria)try{n.setError("Quantidade necessária é obrigatório.");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e12072_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e13077_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14077_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58];this.GXLastCtrlId=58;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","Informações Gerais","str");t.setProp("Collapsible","Collapsible",!1,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"TABLECONTENT",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Conquistanome,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CONQUISTANOME",gxz:"Z29ConquistaNome",gxold:"O29ConquistaNome",gxvar:"A29ConquistaNome",ucs:[],op:[25],ip:[25],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A29ConquistaNome=n)},v2z:function(n){n!==undefined&&(gx.O.Z29ConquistaNome=n)},v2c:function(){gx.fn.setControlValue("CONQUISTANOME",gx.O.A29ConquistaNome,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A29ConquistaNome=this.val())},val:function(){return gx.fn.getControlValue("CONQUISTANOME")},nac:gx.falseFn};this.declareDomainHdlr(25,function(){});n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Conquistapontos,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CONQUISTAPONTOS",gxz:"Z28ConquistaPontos",gxold:"O28ConquistaPontos",gxvar:"A28ConquistaPontos",ucs:[],op:[30],ip:[30],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A28ConquistaPontos=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z28ConquistaPontos=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CONQUISTAPONTOS",gx.O.A28ConquistaPontos,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A28ConquistaPontos=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CONQUISTAPONTOS",".")},nac:gx.falseFn};this.declareDomainHdlr(30,function(){});n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Conquistatipo,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CONQUISTATIPO",gxz:"Z44ConquistaTipo",gxold:"O44ConquistaTipo",gxvar:"A44ConquistaTipo",ucs:[],op:[35],ip:[35],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.A44ConquistaTipo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z44ConquistaTipo=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("CONQUISTATIPO",gx.O.A44ConquistaTipo);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A44ConquistaTipo=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CONQUISTATIPO",".")},nac:gx.falseFn};this.declareDomainHdlr(35,function(){});n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Conquistaquantidadenecessaria,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CONQUISTAQUANTIDADENECESSARIA",gxz:"Z45ConquistaQuantidadeNecessaria",gxold:"O45ConquistaQuantidadeNecessaria",gxvar:"A45ConquistaQuantidadeNecessaria",ucs:[],op:[40],ip:[40],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A45ConquistaQuantidadeNecessaria=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z45ConquistaQuantidadeNecessaria=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CONQUISTAQUANTIDADENECESSARIA",gx.O.A45ConquistaQuantidadeNecessaria,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A45ConquistaQuantidadeNecessaria=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CONQUISTAQUANTIDADENECESSARIA",".")},nac:gx.falseFn};this.declareDomainHdlr(40,function(){});n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CONQUISTAINATIVO",gxz:"Z46ConquistaInativo",gxold:"O46ConquistaInativo",gxvar:"A46ConquistaInativo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.A46ConquistaInativo=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z46ConquistaInativo=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("CONQUISTAINATIVO",gx.O.A46ConquistaInativo,!0)},c2v:function(){this.val()!==undefined&&(gx.O.A46ConquistaInativo=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("CONQUISTAINATIVO")},nac:gx.falseFn,values:["true","false"]};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"BTNTRN_CANCEL",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"BTNTRN_ENTER",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"BTNTRN_DELETE",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};n[58]={id:58,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Conquistaid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CONQUISTAID",gxz:"Z27ConquistaId",gxold:"O27ConquistaId",gxvar:"A27ConquistaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A27ConquistaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z27ConquistaId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CONQUISTAID",gx.O.A27ConquistaId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A27ConquistaId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CONQUISTAID",".")},nac:gx.falseFn};this.declareDomainHdlr(58,function(){});this.A29ConquistaNome="";this.Z29ConquistaNome="";this.O29ConquistaNome="";this.A28ConquistaPontos=0;this.Z28ConquistaPontos=0;this.O28ConquistaPontos=0;this.A44ConquistaTipo=0;this.Z44ConquistaTipo=0;this.O44ConquistaTipo=0;this.A45ConquistaQuantidadeNecessaria=0;this.Z45ConquistaQuantidadeNecessaria=0;this.O45ConquistaQuantidadeNecessaria=0;this.A46ConquistaInativo=!1;this.Z46ConquistaInativo=!1;this.O46ConquistaInativo=!1;this.A27ConquistaId=0;this.Z27ConquistaId=0;this.O27ConquistaId=0;this.AV8WWPContext={UsuarioId:0,UsuarioNome:"",UsuarioLogin:""};this.AV11TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV7ConquistaId=0;this.AV12WebSession={};this.A27ConquistaId=0;this.A28ConquistaPontos=0;this.A29ConquistaNome="";this.A44ConquistaTipo=0;this.A45ConquistaQuantidadeNecessaria=0;this.A46ConquistaInativo=!1;this.Gx_mode="";this.Events={e12072_client:["AFTER TRN",!0],e13077_client:["ENTER",!0],e14077_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV7ConquistaId",fld:"vCONQUISTAID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV7ConquistaId",fld:"vCONQUISTAID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0},{av:"A27ConquistaId",fld:"CONQUISTAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms.START=[[],[{av:"AV8WWPContext",fld:"vWWPCONTEXT",pic:"",nv:null},{av:"AV11TrnContext",fld:"vTRNCONTEXT",pic:"",nv:null},{av:'gx.fn.getCtrlProperty("CONQUISTAID","Visible")',ctrl:"CONQUISTAID",prop:"Visible"}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV11TrnContext",fld:"vTRNCONTEXT",pic:"",nv:null}],[]];this.EnterCtrl=["BTNTRN_ENTER"];this.setVCMap("AV7ConquistaId","vCONQUISTAID",0,"int");this.setVCMap("Gx_mode","vMODE",0,"char");this.setVCMap("AV11TrnContext","vTRNCONTEXT",0,"WWPBaseObjectsWWPTransactionContext");this.Initialize()});gx.createParentObj(conquista)