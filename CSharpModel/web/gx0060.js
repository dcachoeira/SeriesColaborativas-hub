/*!   GeneXus C# 15_0_9-121631 on 9/25/2018 19:6:57.76
*/
gx.evt.autoSkip=!1;gx.define("gx0060",!1,function(){var n,t;this.ServerClass="gx0060";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV10pNotificacaoId=gx.fn.getIntegerValue("vPNOTIFICACAOID",".")};this.Validv_Cnotificacaotipo=function(){try{var n=gx.util.balloon.getNew("vCNOTIFICACAOTIPO");if(this.AnyError=0,!(this.AV8cNotificacaoTipo==1||0==this.AV8cNotificacaoTipo))try{n.setError("Campo Tipo de notificação fora do intervalo");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Validv_Cnotificacaodatahoraenvio=function(){try{var n=gx.util.balloon.getNew("vCNOTIFICACAODATAHORAENVIO");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.AV9cNotificacaoDataHoraEnvio)==0||new gx.date.gxdate(this.AV9cNotificacaoDataHoraEnvio).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("Campo Data e hora de envio fora do intervalo");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e16201_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),$.Deferred().resolve()};this.e11201_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("NOTIFICACAOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("NOTIFICACAOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCNOTIFICACAOID","Visible",!0)):(gx.fn.setCtrlProperty("NOTIFICACAOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCNOTIFICACAOID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("NOTIFICACAOIDFILTERCONTAINER","Class")',ctrl:"NOTIFICACAOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCNOTIFICACAOID","Visible")',ctrl:"vCNOTIFICACAOID",prop:"Visible"}]),$.Deferred().resolve()};this.e12201_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUARIOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUARIOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUARIOID","Visible",!0)):(gx.fn.setCtrlProperty("USUARIOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUARIOID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUARIOIDFILTERCONTAINER","Class")',ctrl:"USUARIOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOID","Visible")',ctrl:"vCUSUARIOID",prop:"Visible"}]),$.Deferred().resolve()};this.e13201_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("NOTIFICACAOTIPOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("NOTIFICACAOTIPOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCNOTIFICACAOTIPO","Visible",!0)):(gx.fn.setCtrlProperty("NOTIFICACAOTIPOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCNOTIFICACAOTIPO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("NOTIFICACAOTIPOFILTERCONTAINER","Class")',ctrl:"NOTIFICACAOTIPOFILTERCONTAINER",prop:"Class"},{ctrl:"vCNOTIFICACAOTIPO"}]),$.Deferred().resolve()};this.e14201_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("NOTIFICACAODATAHORAENVIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("NOTIFICACAODATAHORAENVIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("NOTIFICACAODATAHORAENVIOFILTERCONTAINER","Class","AdvancedContainerItem"),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("NOTIFICACAODATAHORAENVIOFILTERCONTAINER","Class")',ctrl:"NOTIFICACAODATAHORAENVIOFILTERCONTAINER",prop:"Class"}]),$.Deferred().resolve()};this.e15201_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("NOTIFICACAOLIGACAOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("NOTIFICACAOLIGACAOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCNOTIFICACAOLIGACAOID","Visible",!0)):(gx.fn.setCtrlProperty("NOTIFICACAOLIGACAOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCNOTIFICACAOLIGACAOID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("NOTIFICACAOLIGACAOIDFILTERCONTAINER","Class")',ctrl:"NOTIFICACAOLIGACAOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCNOTIFICACAOLIGACAOID","Visible")',ctrl:"vCNOTIFICACAOLIGACAOID",prop:"Visible"}]),$.Deferred().resolve()};this.e19202_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e20201_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,65,66,67,68,69,70,71,72,73];this.GXLastCtrlId=73;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",64,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0060",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Novo registro",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",65,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(23,66,"NOTIFICACAOID","Id","","NotificacaoId","int",0,"px",18,18,"right",null,[],23,"NotificacaoId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(11,67,"USUARIOID","Id","","UsuarioId","int",0,"px",18,18,"right",null,[],11,"UsuarioId",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addComboBox(24,68,"NOTIFICACAOTIPO","de notificação","NotificacaoTipo","int",null,0,!0,!1,0,"px","WWColumn");t.addSingleLineEdit(26,69,"NOTIFICACAODATAHORAENVIO","de envio","","NotificacaoDataHoraEnvio","dtime",0,"px",14,14,"right",null,[],26,"NotificacaoDataHoraEnvio",!0,5,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(61,70,"NOTIFICACAOLIGACAOID","de ligação","","NotificacaoLigacaoId","int",0,"px",18,18,"right",null,[],61,"NotificacaoLigacaoId",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"NOTIFICACAOIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLNOTIFICACAOIDFILTER",format:1,grid:0,evt:"e11201_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCNOTIFICACAOID",gxz:"ZV6cNotificacaoId",gxold:"OV6cNotificacaoId",gxvar:"AV6cNotificacaoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cNotificacaoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cNotificacaoId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCNOTIFICACAOID",gx.O.AV6cNotificacaoId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cNotificacaoId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCNOTIFICACAOID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"USUARIOIDFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLUSUARIOIDFILTER",format:1,grid:0,evt:"e12201_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUARIOID",gxz:"ZV7cUsuarioId",gxold:"OV7cUsuarioId",gxvar:"AV7cUsuarioId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cUsuarioId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cUsuarioId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCUSUARIOID",gx.O.AV7cUsuarioId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cUsuarioId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCUSUARIOID",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"NOTIFICACAOTIPOFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLNOTIFICACAOTIPOFILTER",format:1,grid:0,evt:"e13201_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Cnotificacaotipo,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCNOTIFICACAOTIPO",gxz:"ZV8cNotificacaoTipo",gxold:"OV8cNotificacaoTipo",gxvar:"AV8cNotificacaoTipo",ucs:[],op:[36],ip:[36],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV8cNotificacaoTipo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV8cNotificacaoTipo=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("vCNOTIFICACAOTIPO",gx.O.AV8cNotificacaoTipo)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cNotificacaoTipo=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCNOTIFICACAOTIPO",".")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"NOTIFICACAODATAHORAENVIOFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLNOTIFICACAODATAHORAENVIOFILTER",format:1,grid:0,evt:"e14201_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"dtime",len:8,dec:5,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Cnotificacaodatahoraenvio,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCNOTIFICACAODATAHORAENVIO",gxz:"ZV9cNotificacaoDataHoraEnvio",gxold:"OV9cNotificacaoDataHoraEnvio",gxvar:"AV9cNotificacaoDataHoraEnvio",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/99 99:99",dec:5},ucs:[],op:[46],ip:[46],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cNotificacaoDataHoraEnvio=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9cNotificacaoDataHoraEnvio=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCNOTIFICACAODATAHORAENVIO",gx.O.AV9cNotificacaoDataHoraEnvio,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cNotificacaoDataHoraEnvio=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCNOTIFICACAODATAHORAENVIO")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"NOTIFICACAOLIGACAOIDFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLNOTIFICACAOLIGACAOIDFILTER",format:1,grid:0,evt:"e15201_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCNOTIFICACAOLIGACAOID",gxz:"ZV12cNotificacaoLigacaoId",gxold:"OV12cNotificacaoLigacaoId",gxvar:"AV12cNotificacaoLigacaoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cNotificacaoLigacaoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV12cNotificacaoLigacaoId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCNOTIFICACAOLIGACAOID",gx.O.AV12cNotificacaoLigacaoId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cNotificacaoLigacaoId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCNOTIFICACAOLIGACAOID",".")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"GRIDTABLE",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"BTNTOGGLE",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[65]={id:65,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64),gx.O.AV5LinkSelection,gx.O.AV15Linkselection_GXI)},c2v:function(){gx.O.AV15Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(64))},gxvar_GXI:"AV15Linkselection_GXI",nac:gx.falseFn};n[66]={id:66,lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NOTIFICACAOID",gxz:"Z23NotificacaoId",gxold:"O23NotificacaoId",gxvar:"A23NotificacaoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A23NotificacaoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z23NotificacaoId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("NOTIFICACAOID",n||gx.fn.currentGridRowImpl(64),gx.O.A23NotificacaoId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A23NotificacaoId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("NOTIFICACAOID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[67]={id:67,lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUARIOID",gxz:"Z11UsuarioId",gxold:"O11UsuarioId",gxvar:"A11UsuarioId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A11UsuarioId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11UsuarioId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("USUARIOID",n||gx.fn.currentGridRowImpl(64),gx.O.A11UsuarioId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A11UsuarioId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("USUARIOID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[68]={id:68,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NOTIFICACAOTIPO",gxz:"Z24NotificacaoTipo",gxold:"O24NotificacaoTipo",gxvar:"A24NotificacaoTipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A24NotificacaoTipo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z24NotificacaoTipo=gx.num.intval(n))},v2c:function(n){gx.fn.setGridComboBoxValue("NOTIFICACAOTIPO",n||gx.fn.currentGridRowImpl(64),gx.O.A24NotificacaoTipo);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A24NotificacaoTipo=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("NOTIFICACAOTIPO",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[69]={id:69,lvl:2,type:"dtime",len:8,dec:5,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NOTIFICACAODATAHORAENVIO",gxz:"Z26NotificacaoDataHoraEnvio",gxold:"O26NotificacaoDataHoraEnvio",gxvar:"A26NotificacaoDataHoraEnvio",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A26NotificacaoDataHoraEnvio=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z26NotificacaoDataHoraEnvio=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("NOTIFICACAODATAHORAENVIO",n||gx.fn.currentGridRowImpl(64),gx.O.A26NotificacaoDataHoraEnvio,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A26NotificacaoDataHoraEnvio=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("NOTIFICACAODATAHORAENVIO",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[70]={id:70,lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NOTIFICACAOLIGACAOID",gxz:"Z61NotificacaoLigacaoId",gxold:"O61NotificacaoLigacaoId",gxvar:"A61NotificacaoLigacaoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A61NotificacaoLigacaoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z61NotificacaoLigacaoId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("NOTIFICACAOLIGACAOID",n||gx.fn.currentGridRowImpl(64),gx.O.A61NotificacaoLigacaoId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A61NotificacaoLigacaoId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("NOTIFICACAOLIGACAOID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"BTN_CANCEL",grid:0};this.AV6cNotificacaoId=0;this.ZV6cNotificacaoId=0;this.OV6cNotificacaoId=0;this.AV7cUsuarioId=0;this.ZV7cUsuarioId=0;this.OV7cUsuarioId=0;this.AV8cNotificacaoTipo=0;this.ZV8cNotificacaoTipo=0;this.OV8cNotificacaoTipo=0;this.AV9cNotificacaoDataHoraEnvio=gx.date.nullDate();this.ZV9cNotificacaoDataHoraEnvio=gx.date.nullDate();this.OV9cNotificacaoDataHoraEnvio=gx.date.nullDate();this.AV12cNotificacaoLigacaoId=0;this.ZV12cNotificacaoLigacaoId=0;this.OV12cNotificacaoLigacaoId=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z23NotificacaoId=0;this.O23NotificacaoId=0;this.Z11UsuarioId=0;this.O11UsuarioId=0;this.Z24NotificacaoTipo=0;this.O24NotificacaoTipo=0;this.Z26NotificacaoDataHoraEnvio=gx.date.nullDate();this.O26NotificacaoDataHoraEnvio=gx.date.nullDate();this.Z61NotificacaoLigacaoId=0;this.O61NotificacaoLigacaoId=0;this.AV6cNotificacaoId=0;this.AV7cUsuarioId=0;this.AV8cNotificacaoTipo=0;this.AV9cNotificacaoDataHoraEnvio=gx.date.nullDate();this.AV12cNotificacaoLigacaoId=0;this.AV10pNotificacaoId=0;this.AV5LinkSelection="";this.A23NotificacaoId=0;this.A11UsuarioId=0;this.A24NotificacaoTipo=0;this.A26NotificacaoDataHoraEnvio=gx.date.nullDate();this.A61NotificacaoLigacaoId=0;this.Events={e19202_client:["ENTER",!0],e20201_client:["CANCEL",!0],e16201_client:["'TOGGLE'",!1],e11201_client:["LBLNOTIFICACAOIDFILTER.CLICK",!1],e12201_client:["LBLUSUARIOIDFILTER.CLICK",!1],e13201_client:["LBLNOTIFICACAOTIPOFILTER.CLICK",!1],e14201_client:["LBLNOTIFICACAODATAHORAENVIOFILTER.CLICK",!1],e15201_client:["LBLNOTIFICACAOLIGACAOIDFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cNotificacaoId",fld:"vCNOTIFICACAOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cUsuarioId",fld:"vCUSUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{ctrl:"vCNOTIFICACAOTIPO"},{av:"AV8cNotificacaoTipo",fld:"vCNOTIFICACAOTIPO",pic:"ZZZ9",nv:0},{av:"AV9cNotificacaoDataHoraEnvio",fld:"vCNOTIFICACAODATAHORAENVIO",pic:"99/99/99 99:99",nv:""},{av:"AV12cNotificacaoLigacaoId",fld:"vCNOTIFICACAOLIGACAOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLNOTIFICACAOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("NOTIFICACAOIDFILTERCONTAINER","Class")',ctrl:"NOTIFICACAOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("NOTIFICACAOIDFILTERCONTAINER","Class")',ctrl:"NOTIFICACAOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCNOTIFICACAOID","Visible")',ctrl:"vCNOTIFICACAOID",prop:"Visible"}]];this.EvtParms["LBLUSUARIOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUARIOIDFILTERCONTAINER","Class")',ctrl:"USUARIOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUARIOIDFILTERCONTAINER","Class")',ctrl:"USUARIOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOID","Visible")',ctrl:"vCUSUARIOID",prop:"Visible"}]];this.EvtParms["LBLNOTIFICACAOTIPOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("NOTIFICACAOTIPOFILTERCONTAINER","Class")',ctrl:"NOTIFICACAOTIPOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("NOTIFICACAOTIPOFILTERCONTAINER","Class")',ctrl:"NOTIFICACAOTIPOFILTERCONTAINER",prop:"Class"},{ctrl:"vCNOTIFICACAOTIPO"}]];this.EvtParms["LBLNOTIFICACAODATAHORAENVIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("NOTIFICACAODATAHORAENVIOFILTERCONTAINER","Class")',ctrl:"NOTIFICACAODATAHORAENVIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("NOTIFICACAODATAHORAENVIOFILTERCONTAINER","Class")',ctrl:"NOTIFICACAODATAHORAENVIOFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLNOTIFICACAOLIGACAOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("NOTIFICACAOLIGACAOIDFILTERCONTAINER","Class")',ctrl:"NOTIFICACAOLIGACAOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("NOTIFICACAOLIGACAOIDFILTERCONTAINER","Class")',ctrl:"NOTIFICACAOLIGACAOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCNOTIFICACAOLIGACAOID","Visible")',ctrl:"vCNOTIFICACAOLIGACAOID",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A23NotificacaoId",fld:"NOTIFICACAOID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV10pNotificacaoId",fld:"vPNOTIFICACAOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cNotificacaoId",fld:"vCNOTIFICACAOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cUsuarioId",fld:"vCUSUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{ctrl:"vCNOTIFICACAOTIPO"},{av:"AV8cNotificacaoTipo",fld:"vCNOTIFICACAOTIPO",pic:"ZZZ9",nv:0},{av:"AV9cNotificacaoDataHoraEnvio",fld:"vCNOTIFICACAODATAHORAENVIO",pic:"99/99/99 99:99",nv:""},{av:"AV12cNotificacaoLigacaoId",fld:"vCNOTIFICACAOLIGACAOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cNotificacaoId",fld:"vCNOTIFICACAOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cUsuarioId",fld:"vCUSUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{ctrl:"vCNOTIFICACAOTIPO"},{av:"AV8cNotificacaoTipo",fld:"vCNOTIFICACAOTIPO",pic:"ZZZ9",nv:0},{av:"AV9cNotificacaoDataHoraEnvio",fld:"vCNOTIFICACAODATAHORAENVIO",pic:"99/99/99 99:99",nv:""},{av:"AV12cNotificacaoLigacaoId",fld:"vCNOTIFICACAOLIGACAOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cNotificacaoId",fld:"vCNOTIFICACAOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cUsuarioId",fld:"vCUSUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{ctrl:"vCNOTIFICACAOTIPO"},{av:"AV8cNotificacaoTipo",fld:"vCNOTIFICACAOTIPO",pic:"ZZZ9",nv:0},{av:"AV9cNotificacaoDataHoraEnvio",fld:"vCNOTIFICACAODATAHORAENVIO",pic:"99/99/99 99:99",nv:""},{av:"AV12cNotificacaoLigacaoId",fld:"vCNOTIFICACAOLIGACAOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cNotificacaoId",fld:"vCNOTIFICACAOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cUsuarioId",fld:"vCUSUARIOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{ctrl:"vCNOTIFICACAOTIPO"},{av:"AV8cNotificacaoTipo",fld:"vCNOTIFICACAOTIPO",pic:"ZZZ9",nv:0},{av:"AV9cNotificacaoDataHoraEnvio",fld:"vCNOTIFICACAODATAHORAENVIO",pic:"99/99/99 99:99",nv:""},{av:"AV12cNotificacaoLigacaoId",fld:"vCNOTIFICACAOLIGACAOID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}],[]];this.setVCMap("AV10pNotificacaoId","vPNOTIFICACAOID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);this.Initialize()});gx.createParentObj(gx0060)