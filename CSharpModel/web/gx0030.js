/*!   GeneXus C# 15_0_9-121631 on 9/20/2018 19:46:30.16
*/
gx.evt.autoSkip=!1;gx.define("gx0030",!1,function(){var n,t;this.ServerClass="gx0030";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8pUsuarioId=gx.fn.getIntegerValue("vPUSUARIOID",".")};this.Validv_Cusuariotipo=function(){try{var n=gx.util.balloon.getNew("vCUSUARIOTIPO");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e181x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),$.Deferred().resolve()};this.e111x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUARIOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUARIOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUARIOID","Visible",!0)):(gx.fn.setCtrlProperty("USUARIOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUARIOID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUARIOIDFILTERCONTAINER","Class")',ctrl:"USUARIOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOID","Visible")',ctrl:"vCUSUARIOID",prop:"Visible"}]),$.Deferred().resolve()};this.e121x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUARIONOMEFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUARIONOMEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUARIONOME","Visible",!0)):(gx.fn.setCtrlProperty("USUARIONOMEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUARIONOME","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUARIONOMEFILTERCONTAINER","Class")',ctrl:"USUARIONOMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIONOME","Visible")',ctrl:"vCUSUARIONOME",prop:"Visible"}]),$.Deferred().resolve()};this.e131x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUARIOTIPOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUARIOTIPOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUARIOTIPO","Visible",!0)):(gx.fn.setCtrlProperty("USUARIOTIPOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUARIOTIPO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUARIOTIPOFILTERCONTAINER","Class")',ctrl:"USUARIOTIPOFILTERCONTAINER",prop:"Class"},{ctrl:"vCUSUARIOTIPO"}]),$.Deferred().resolve()};this.e141x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUARIOINATIVOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUARIOINATIVOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUARIOINATIVO","Visible",!0)):(gx.fn.setCtrlProperty("USUARIOINATIVOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUARIOINATIVO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUARIOINATIVOFILTERCONTAINER","Class")',ctrl:"USUARIOINATIVOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOINATIVO","Visible")',ctrl:"vCUSUARIOINATIVO",prop:"Visible"}]),$.Deferred().resolve()};this.e151x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUARIOLOGINFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUARIOLOGINFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUARIOLOGIN","Visible",!0)):(gx.fn.setCtrlProperty("USUARIOLOGINFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUARIOLOGIN","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUARIOLOGINFILTERCONTAINER","Class")',ctrl:"USUARIOLOGINFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOLOGIN","Visible")',ctrl:"vCUSUARIOLOGIN",prop:"Visible"}]),$.Deferred().resolve()};this.e161x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUARIOSENHAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUARIOSENHAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUARIOSENHA","Visible",!0)):(gx.fn.setCtrlProperty("USUARIOSENHAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUARIOSENHA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUARIOSENHAFILTERCONTAINER","Class")',ctrl:"USUARIOSENHAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOSENHA","Visible")',ctrl:"vCUSUARIOSENHA",prop:"Visible"}]),$.Deferred().resolve()};this.e171x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUARIOGAMGUIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUARIOGAMGUIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUARIOGAMGUID","Visible",!0)):(gx.fn.setCtrlProperty("USUARIOGAMGUIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUARIOGAMGUID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUARIOGAMGUIDFILTERCONTAINER","Class")',ctrl:"USUARIOGAMGUIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOGAMGUID","Visible")',ctrl:"vCUSUARIOGAMGUID",prop:"Visible"}]),$.Deferred().resolve()};this.e211x2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e221x1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,85,86,87,88,89,90,91,92,93];this.GXLastCtrlId=93;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",84,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0030",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Novo registro",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",85,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(11,86,"USUARIOID","Id","","UsuarioId","int",0,"px",18,18,"right",null,[],11,"UsuarioId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(12,87,"USUARIONOME","Nome","","UsuarioNome","svchar",0,"px",40,40,"left",null,[],12,"UsuarioNome",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addComboBox(52,88,"USUARIOTIPO","Tipo","UsuarioTipo","int",null,0,!0,!1,0,"px","WWColumn OptionalColumn");t.addCheckBox(53,89,"USUARIOINATIVO","Inativo","","UsuarioInativo","boolean","true","false",null,!0,!1,0,"px","WWColumn OptionalColumn");t.addSingleLineEdit(54,90,"USUARIOLOGIN","Login","","UsuarioLogin","svchar",0,"px",40,40,"left",null,[],54,"UsuarioLogin",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"USUARIOIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLUSUARIOIDFILTER",format:1,grid:0,evt:"e111x1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUARIOID",gxz:"ZV6cUsuarioId",gxold:"OV6cUsuarioId",gxvar:"AV6cUsuarioId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cUsuarioId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cUsuarioId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCUSUARIOID",gx.O.AV6cUsuarioId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cUsuarioId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCUSUARIOID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"USUARIONOMEFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLUSUARIONOMEFILTER",format:1,grid:0,evt:"e121x1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUARIONOME",gxz:"ZV7cUsuarioNome",gxold:"OV7cUsuarioNome",gxvar:"AV7cUsuarioNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cUsuarioNome=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cUsuarioNome=n)},v2c:function(){gx.fn.setControlValue("vCUSUARIONOME",gx.O.AV7cUsuarioNome,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cUsuarioNome=this.val())},val:function(){return gx.fn.getControlValue("vCUSUARIONOME")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"USUARIOTIPOFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLUSUARIOTIPOFILTER",format:1,grid:0,evt:"e131x1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Cusuariotipo,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUARIOTIPO",gxz:"ZV10cUsuarioTipo",gxold:"OV10cUsuarioTipo",gxvar:"AV10cUsuarioTipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV10cUsuarioTipo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10cUsuarioTipo=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("vCUSUARIOTIPO",gx.O.AV10cUsuarioTipo)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cUsuarioTipo=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCUSUARIOTIPO",".")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"USUARIOINATIVOFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLUSUARIOINATIVOFILTER",format:1,grid:0,evt:"e141x1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUARIOINATIVO",gxz:"ZV11cUsuarioInativo",gxold:"OV11cUsuarioInativo",gxvar:"AV11cUsuarioInativo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.AV11cUsuarioInativo=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11cUsuarioInativo=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("vCUSUARIOINATIVO",gx.O.AV11cUsuarioInativo,!0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cUsuarioInativo=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("vCUSUARIOINATIVO")},nac:gx.falseFn,values:["true","false"]};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"USUARIOLOGINFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLUSUARIOLOGINFILTER",format:1,grid:0,evt:"e151x1_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUARIOLOGIN",gxz:"ZV12cUsuarioLogin",gxold:"OV12cUsuarioLogin",gxvar:"AV12cUsuarioLogin",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cUsuarioLogin=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12cUsuarioLogin=n)},v2c:function(){gx.fn.setControlValue("vCUSUARIOLOGIN",gx.O.AV12cUsuarioLogin,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cUsuarioLogin=this.val())},val:function(){return gx.fn.getControlValue("vCUSUARIOLOGIN")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"USUARIOSENHAFILTERCONTAINER",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"LBLUSUARIOSENHAFILTER",format:1,grid:0,evt:"e161x1_client"};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"svchar",len:32,dec:0,sign:!1,isPwd:!0,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUARIOSENHA",gxz:"ZV13cUsuarioSenha",gxold:"OV13cUsuarioSenha",gxvar:"AV13cUsuarioSenha",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV13cUsuarioSenha=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13cUsuarioSenha=n)},v2c:function(){gx.fn.setControlValue("vCUSUARIOSENHA",gx.O.AV13cUsuarioSenha,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV13cUsuarioSenha=this.val())},val:function(){return gx.fn.getControlValue("vCUSUARIOSENHA")},nac:gx.falseFn};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"USUARIOGAMGUIDFILTERCONTAINER",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"LBLUSUARIOGAMGUIDFILTER",format:1,grid:0,evt:"e171x1_client"};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,fld:"",grid:0};n[76]={id:76,lvl:0,type:"char",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUARIOGAMGUID",gxz:"ZV14cUsuarioGamGuid",gxold:"OV14cUsuarioGamGuid",gxvar:"AV14cUsuarioGamGuid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV14cUsuarioGamGuid=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14cUsuarioGamGuid=n)},v2c:function(){gx.fn.setControlValue("vCUSUARIOGAMGUID",gx.O.AV14cUsuarioGamGuid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV14cUsuarioGamGuid=this.val())},val:function(){return gx.fn.getControlValue("vCUSUARIOGAMGUID")},nac:gx.falseFn};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"GRIDTABLE",grid:0};n[79]={id:79,fld:"",grid:0};n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"BTNTOGGLE",grid:0};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[85]={id:85,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(84))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(84))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[86]={id:86,lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUARIOID",gxz:"Z11UsuarioId",gxold:"O11UsuarioId",gxvar:"A11UsuarioId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A11UsuarioId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11UsuarioId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("USUARIOID",n||gx.fn.currentGridRowImpl(84),gx.O.A11UsuarioId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A11UsuarioId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("USUARIOID",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[87]={id:87,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUARIONOME",gxz:"Z12UsuarioNome",gxold:"O12UsuarioNome",gxvar:"A12UsuarioNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A12UsuarioNome=n)},v2z:function(n){n!==undefined&&(gx.O.Z12UsuarioNome=n)},v2c:function(n){gx.fn.setGridControlValue("USUARIONOME",n||gx.fn.currentGridRowImpl(84),gx.O.A12UsuarioNome,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A12UsuarioNome=this.val())},val:function(n){return gx.fn.getGridControlValue("USUARIONOME",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[88]={id:88,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUARIOTIPO",gxz:"Z52UsuarioTipo",gxold:"O52UsuarioTipo",gxvar:"A52UsuarioTipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A52UsuarioTipo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z52UsuarioTipo=gx.num.intval(n))},v2c:function(n){gx.fn.setGridComboBoxValue("USUARIOTIPO",n||gx.fn.currentGridRowImpl(84),gx.O.A52UsuarioTipo);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A52UsuarioTipo=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("USUARIOTIPO",n||gx.fn.currentGridRowImpl(84),".")},nac:gx.falseFn};n[89]={id:89,lvl:2,type:"boolean",len:4,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUARIOINATIVO",gxz:"Z53UsuarioInativo",gxold:"O53UsuarioInativo",gxvar:"A53UsuarioInativo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A53UsuarioInativo=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z53UsuarioInativo=gx.lang.booleanValue(n))},v2c:function(n){gx.fn.setGridCheckBoxValue("USUARIOINATIVO",n||gx.fn.currentGridRowImpl(84),gx.O.A53UsuarioInativo,!0)},c2v:function(){this.val()!==undefined&&(gx.O.A53UsuarioInativo=gx.lang.booleanValue(this.val()))},val:function(n){return gx.fn.getGridControlValue("USUARIOINATIVO",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn,values:["true","false"]};n[90]={id:90,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:84,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUARIOLOGIN",gxz:"Z54UsuarioLogin",gxold:"O54UsuarioLogin",gxvar:"A54UsuarioLogin",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A54UsuarioLogin=n)},v2z:function(n){n!==undefined&&(gx.O.Z54UsuarioLogin=n)},v2c:function(n){gx.fn.setGridControlValue("USUARIOLOGIN",n||gx.fn.currentGridRowImpl(84),gx.O.A54UsuarioLogin,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A54UsuarioLogin=this.val())},val:function(n){return gx.fn.getGridControlValue("USUARIOLOGIN",n||gx.fn.currentGridRowImpl(84))},nac:gx.falseFn};n[91]={id:91,fld:"",grid:0};n[92]={id:92,fld:"",grid:0};n[93]={id:93,fld:"BTN_CANCEL",grid:0};this.AV6cUsuarioId=0;this.ZV6cUsuarioId=0;this.OV6cUsuarioId=0;this.AV7cUsuarioNome="";this.ZV7cUsuarioNome="";this.OV7cUsuarioNome="";this.AV10cUsuarioTipo=0;this.ZV10cUsuarioTipo=0;this.OV10cUsuarioTipo=0;this.AV11cUsuarioInativo=!1;this.ZV11cUsuarioInativo=!1;this.OV11cUsuarioInativo=!1;this.AV12cUsuarioLogin="";this.ZV12cUsuarioLogin="";this.OV12cUsuarioLogin="";this.AV13cUsuarioSenha="";this.ZV13cUsuarioSenha="";this.OV13cUsuarioSenha="";this.AV14cUsuarioGamGuid="";this.ZV14cUsuarioGamGuid="";this.OV14cUsuarioGamGuid="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z11UsuarioId=0;this.O11UsuarioId=0;this.Z12UsuarioNome="";this.O12UsuarioNome="";this.Z52UsuarioTipo=0;this.O52UsuarioTipo=0;this.Z53UsuarioInativo=!1;this.O53UsuarioInativo=!1;this.Z54UsuarioLogin="";this.O54UsuarioLogin="";this.AV6cUsuarioId=0;this.AV7cUsuarioNome="";this.AV10cUsuarioTipo=0;this.AV11cUsuarioInativo=!1;this.AV12cUsuarioLogin="";this.AV13cUsuarioSenha="";this.AV14cUsuarioGamGuid="";this.AV8pUsuarioId=0;this.A56UsuarioGamGuid="";this.A55UsuarioSenha="";this.AV5LinkSelection="";this.A11UsuarioId=0;this.A12UsuarioNome="";this.A52UsuarioTipo=0;this.A53UsuarioInativo=!1;this.A54UsuarioLogin="";this.Events={e211x2_client:["ENTER",!0],e221x1_client:["CANCEL",!0],e181x1_client:["'TOGGLE'",!1],e111x1_client:["LBLUSUARIOIDFILTER.CLICK",!1],e121x1_client:["LBLUSUARIONOMEFILTER.CLICK",!1],e131x1_client:["LBLUSUARIOTIPOFILTER.CLICK",!1],e141x1_client:["LBLUSUARIOINATIVOFILTER.CLICK",!1],e151x1_client:["LBLUSUARIOLOGINFILTER.CLICK",!1],e161x1_client:["LBLUSUARIOSENHAFILTER.CLICK",!1],e171x1_client:["LBLUSUARIOGAMGUIDFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cUsuarioId",fld:"vCUSUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cUsuarioNome",fld:"vCUSUARIONOME",pic:"",nv:""},{ctrl:"vCUSUARIOTIPO"},{av:"AV10cUsuarioTipo",fld:"vCUSUARIOTIPO",pic:"ZZZ9",nv:0},{av:"AV11cUsuarioInativo",fld:"vCUSUARIOINATIVO",pic:"",nv:!1},{av:"AV12cUsuarioLogin",fld:"vCUSUARIOLOGIN",pic:"",nv:""},{av:"AV13cUsuarioSenha",fld:"vCUSUARIOSENHA",pic:"",nv:""},{av:"AV14cUsuarioGamGuid",fld:"vCUSUARIOGAMGUID",pic:"",nv:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLUSUARIOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUARIOIDFILTERCONTAINER","Class")',ctrl:"USUARIOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUARIOIDFILTERCONTAINER","Class")',ctrl:"USUARIOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOID","Visible")',ctrl:"vCUSUARIOID",prop:"Visible"}]];this.EvtParms["LBLUSUARIONOMEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUARIONOMEFILTERCONTAINER","Class")',ctrl:"USUARIONOMEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUARIONOMEFILTERCONTAINER","Class")',ctrl:"USUARIONOMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIONOME","Visible")',ctrl:"vCUSUARIONOME",prop:"Visible"}]];this.EvtParms["LBLUSUARIOTIPOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUARIOTIPOFILTERCONTAINER","Class")',ctrl:"USUARIOTIPOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUARIOTIPOFILTERCONTAINER","Class")',ctrl:"USUARIOTIPOFILTERCONTAINER",prop:"Class"},{ctrl:"vCUSUARIOTIPO"}]];this.EvtParms["LBLUSUARIOINATIVOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUARIOINATIVOFILTERCONTAINER","Class")',ctrl:"USUARIOINATIVOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUARIOINATIVOFILTERCONTAINER","Class")',ctrl:"USUARIOINATIVOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOINATIVO","Visible")',ctrl:"vCUSUARIOINATIVO",prop:"Visible"}]];this.EvtParms["LBLUSUARIOLOGINFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUARIOLOGINFILTERCONTAINER","Class")',ctrl:"USUARIOLOGINFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUARIOLOGINFILTERCONTAINER","Class")',ctrl:"USUARIOLOGINFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOLOGIN","Visible")',ctrl:"vCUSUARIOLOGIN",prop:"Visible"}]];this.EvtParms["LBLUSUARIOSENHAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUARIOSENHAFILTERCONTAINER","Class")',ctrl:"USUARIOSENHAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUARIOSENHAFILTERCONTAINER","Class")',ctrl:"USUARIOSENHAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOSENHA","Visible")',ctrl:"vCUSUARIOSENHA",prop:"Visible"}]];this.EvtParms["LBLUSUARIOGAMGUIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUARIOGAMGUIDFILTERCONTAINER","Class")',ctrl:"USUARIOGAMGUIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUARIOGAMGUIDFILTERCONTAINER","Class")',ctrl:"USUARIOGAMGUIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOGAMGUID","Visible")',ctrl:"vCUSUARIOGAMGUID",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A11UsuarioId",fld:"USUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV8pUsuarioId",fld:"vPUSUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cUsuarioId",fld:"vCUSUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cUsuarioNome",fld:"vCUSUARIONOME",pic:"",nv:""},{ctrl:"vCUSUARIOTIPO"},{av:"AV10cUsuarioTipo",fld:"vCUSUARIOTIPO",pic:"ZZZ9",nv:0},{av:"AV11cUsuarioInativo",fld:"vCUSUARIOINATIVO",pic:"",nv:!1},{av:"AV12cUsuarioLogin",fld:"vCUSUARIOLOGIN",pic:"",nv:""},{av:"AV13cUsuarioSenha",fld:"vCUSUARIOSENHA",pic:"",nv:""},{av:"AV14cUsuarioGamGuid",fld:"vCUSUARIOGAMGUID",pic:"",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cUsuarioId",fld:"vCUSUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cUsuarioNome",fld:"vCUSUARIONOME",pic:"",nv:""},{ctrl:"vCUSUARIOTIPO"},{av:"AV10cUsuarioTipo",fld:"vCUSUARIOTIPO",pic:"ZZZ9",nv:0},{av:"AV11cUsuarioInativo",fld:"vCUSUARIOINATIVO",pic:"",nv:!1},{av:"AV12cUsuarioLogin",fld:"vCUSUARIOLOGIN",pic:"",nv:""},{av:"AV13cUsuarioSenha",fld:"vCUSUARIOSENHA",pic:"",nv:""},{av:"AV14cUsuarioGamGuid",fld:"vCUSUARIOGAMGUID",pic:"",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cUsuarioId",fld:"vCUSUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cUsuarioNome",fld:"vCUSUARIONOME",pic:"",nv:""},{ctrl:"vCUSUARIOTIPO"},{av:"AV10cUsuarioTipo",fld:"vCUSUARIOTIPO",pic:"ZZZ9",nv:0},{av:"AV11cUsuarioInativo",fld:"vCUSUARIOINATIVO",pic:"",nv:!1},{av:"AV12cUsuarioLogin",fld:"vCUSUARIOLOGIN",pic:"",nv:""},{av:"AV13cUsuarioSenha",fld:"vCUSUARIOSENHA",pic:"",nv:""},{av:"AV14cUsuarioGamGuid",fld:"vCUSUARIOGAMGUID",pic:"",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cUsuarioId",fld:"vCUSUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cUsuarioNome",fld:"vCUSUARIONOME",pic:"",nv:""},{ctrl:"vCUSUARIOTIPO"},{av:"AV10cUsuarioTipo",fld:"vCUSUARIOTIPO",pic:"ZZZ9",nv:0},{av:"AV11cUsuarioInativo",fld:"vCUSUARIOINATIVO",pic:"",nv:!1},{av:"AV12cUsuarioLogin",fld:"vCUSUARIOLOGIN",pic:"",nv:""},{av:"AV13cUsuarioSenha",fld:"vCUSUARIOSENHA",pic:"",nv:""},{av:"AV14cUsuarioGamGuid",fld:"vCUSUARIOGAMGUID",pic:"",nv:""}],[]];this.setVCMap("AV8pUsuarioId","vPUSUARIOID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar(this.GXValidFnc[76]);this.Initialize()});gx.createParentObj(gx0030)