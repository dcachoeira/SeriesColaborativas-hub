/*!   GeneXus C# 15_0_9-121631 on 9/20/2018 19:46:39.43
*/
gx.evt.autoSkip=!1;gx.define("gx0070",!1,function(){var n,t;this.ServerClass="gx0070";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV9pConquistaId=gx.fn.getIntegerValue("vPCONQUISTAID",".")};this.Validv_Cconquistatipo=function(){try{var n=gx.util.balloon.getNew("vCCONQUISTATIPO");if(this.AnyError=0,!(this.AV11cConquistaTipo==1||this.AV11cConquistaTipo==2||this.AV11cConquistaTipo==3||0==this.AV11cConquistaTipo))try{n.setError("Campo Tipo de conquista fora do intervalo");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e17211_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),$.Deferred().resolve()};this.e11211_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CONQUISTAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CONQUISTAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCONQUISTAID","Visible",!0)):(gx.fn.setCtrlProperty("CONQUISTAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCONQUISTAID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CONQUISTAIDFILTERCONTAINER","Class")',ctrl:"CONQUISTAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCONQUISTAID","Visible")',ctrl:"vCCONQUISTAID",prop:"Visible"}]),$.Deferred().resolve()};this.e12211_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CONQUISTAPONTOSFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CONQUISTAPONTOSFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCONQUISTAPONTOS","Visible",!0)):(gx.fn.setCtrlProperty("CONQUISTAPONTOSFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCONQUISTAPONTOS","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CONQUISTAPONTOSFILTERCONTAINER","Class")',ctrl:"CONQUISTAPONTOSFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCONQUISTAPONTOS","Visible")',ctrl:"vCCONQUISTAPONTOS",prop:"Visible"}]),$.Deferred().resolve()};this.e13211_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CONQUISTANOMEFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CONQUISTANOMEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCONQUISTANOME","Visible",!0)):(gx.fn.setCtrlProperty("CONQUISTANOMEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCONQUISTANOME","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CONQUISTANOMEFILTERCONTAINER","Class")',ctrl:"CONQUISTANOMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCONQUISTANOME","Visible")',ctrl:"vCCONQUISTANOME",prop:"Visible"}]),$.Deferred().resolve()};this.e14211_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CONQUISTATIPOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CONQUISTATIPOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCONQUISTATIPO","Visible",!0)):(gx.fn.setCtrlProperty("CONQUISTATIPOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCONQUISTATIPO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CONQUISTATIPOFILTERCONTAINER","Class")',ctrl:"CONQUISTATIPOFILTERCONTAINER",prop:"Class"},{ctrl:"vCCONQUISTATIPO"}]),$.Deferred().resolve()};this.e15211_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCONQUISTAQUANTIDADENECESSARIA","Visible",!0)):(gx.fn.setCtrlProperty("CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCONQUISTAQUANTIDADENECESSARIA","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER","Class")',ctrl:"CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCONQUISTAQUANTIDADENECESSARIA","Visible")',ctrl:"vCCONQUISTAQUANTIDADENECESSARIA",prop:"Visible"}]),$.Deferred().resolve()};this.e16211_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CONQUISTAINATIVOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CONQUISTAINATIVOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCONQUISTAINATIVO","Visible",!0)):(gx.fn.setCtrlProperty("CONQUISTAINATIVOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCONQUISTAINATIVO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CONQUISTAINATIVOFILTERCONTAINER","Class")',ctrl:"CONQUISTAINATIVOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCONQUISTAINATIVO","Visible")',ctrl:"vCCONQUISTAINATIVO",prop:"Visible"}]),$.Deferred().resolve()};this.e20212_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e21211_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,75,76,77,78,79,80,81,82,83,84];this.GXLastCtrlId=84;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",74,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0070",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Novo registro",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",75,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(27,76,"CONQUISTAID","Id","","ConquistaId","int",0,"px",18,18,"right",null,[],27,"ConquistaId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(28,77,"CONQUISTAPONTOS","Pontos","","ConquistaPontos","int",0,"px",4,4,"right",null,[],28,"ConquistaPontos",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(29,78,"CONQUISTANOME","Nome","","ConquistaNome","svchar",0,"px",40,40,"left",null,[],29,"ConquistaNome",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addComboBox(44,79,"CONQUISTATIPO","Tipo de conquista","ConquistaTipo","int",null,0,!0,!1,0,"px","WWColumn OptionalColumn");t.addSingleLineEdit(45,80,"CONQUISTAQUANTIDADENECESSARIA","Quantidade necessária","","ConquistaQuantidadeNecessaria","int",0,"px",4,4,"right",null,[],45,"ConquistaQuantidadeNecessaria",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addCheckBox(46,81,"CONQUISTAINATIVO","Inativo","","ConquistaInativo","boolean","true","false",null,!0,!1,0,"px","WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"CONQUISTAIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLCONQUISTAIDFILTER",format:1,grid:0,evt:"e11211_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCONQUISTAID",gxz:"ZV6cConquistaId",gxold:"OV6cConquistaId",gxvar:"AV6cConquistaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cConquistaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cConquistaId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCONQUISTAID",gx.O.AV6cConquistaId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cConquistaId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCONQUISTAID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"CONQUISTAPONTOSFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLCONQUISTAPONTOSFILTER",format:1,grid:0,evt:"e12211_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCONQUISTAPONTOS",gxz:"ZV7cConquistaPontos",gxold:"OV7cConquistaPontos",gxvar:"AV7cConquistaPontos",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cConquistaPontos=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cConquistaPontos=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCONQUISTAPONTOS",gx.O.AV7cConquistaPontos,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cConquistaPontos=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCONQUISTAPONTOS",".")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"CONQUISTANOMEFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLCONQUISTANOMEFILTER",format:1,grid:0,evt:"e13211_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCONQUISTANOME",gxz:"ZV8cConquistaNome",gxold:"OV8cConquistaNome",gxvar:"AV8cConquistaNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cConquistaNome=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cConquistaNome=n)},v2c:function(){gx.fn.setControlValue("vCCONQUISTANOME",gx.O.AV8cConquistaNome,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cConquistaNome=this.val())},val:function(){return gx.fn.getControlValue("vCCONQUISTANOME")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"CONQUISTATIPOFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLCONQUISTATIPOFILTER",format:1,grid:0,evt:"e14211_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Cconquistatipo,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCONQUISTATIPO",gxz:"ZV11cConquistaTipo",gxold:"OV11cConquistaTipo",gxvar:"AV11cConquistaTipo",ucs:[],op:[46],ip:[46],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV11cConquistaTipo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11cConquistaTipo=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("vCCONQUISTATIPO",gx.O.AV11cConquistaTipo)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cConquistaTipo=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCONQUISTATIPO",".")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLCONQUISTAQUANTIDADENECESSARIAFILTER",format:1,grid:0,evt:"e15211_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCONQUISTAQUANTIDADENECESSARIA",gxz:"ZV12cConquistaQuantidadeNecessaria",gxold:"OV12cConquistaQuantidadeNecessaria",gxvar:"AV12cConquistaQuantidadeNecessaria",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cConquistaQuantidadeNecessaria=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV12cConquistaQuantidadeNecessaria=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCONQUISTAQUANTIDADENECESSARIA",gx.O.AV12cConquistaQuantidadeNecessaria,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12cConquistaQuantidadeNecessaria=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCONQUISTAQUANTIDADENECESSARIA",".")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"CONQUISTAINATIVOFILTERCONTAINER",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"LBLCONQUISTAINATIVOFILTER",format:1,grid:0,evt:"e16211_client"};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCONQUISTAINATIVO",gxz:"ZV13cConquistaInativo",gxold:"OV13cConquistaInativo",gxvar:"AV13cConquistaInativo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.AV13cConquistaInativo=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV13cConquistaInativo=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("vCCONQUISTAINATIVO",gx.O.AV13cConquistaInativo,!0)},c2v:function(){this.val()!==undefined&&(gx.O.AV13cConquistaInativo=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("vCCONQUISTAINATIVO")},nac:gx.falseFn,values:["true","false"]};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"GRIDTABLE",grid:0};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"BTNTOGGLE",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[75]={id:75,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(74),gx.O.AV5LinkSelection,gx.O.AV16Linkselection_GXI)},c2v:function(){gx.O.AV16Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(74))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(74))},gxvar_GXI:"AV16Linkselection_GXI",nac:gx.falseFn};n[76]={id:76,lvl:2,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CONQUISTAID",gxz:"Z27ConquistaId",gxold:"O27ConquistaId",gxvar:"A27ConquistaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A27ConquistaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z27ConquistaId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CONQUISTAID",n||gx.fn.currentGridRowImpl(74),gx.O.A27ConquistaId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A27ConquistaId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CONQUISTAID",n||gx.fn.currentGridRowImpl(74),".")},nac:gx.falseFn};n[77]={id:77,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CONQUISTAPONTOS",gxz:"Z28ConquistaPontos",gxold:"O28ConquistaPontos",gxvar:"A28ConquistaPontos",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A28ConquistaPontos=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z28ConquistaPontos=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CONQUISTAPONTOS",n||gx.fn.currentGridRowImpl(74),gx.O.A28ConquistaPontos,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A28ConquistaPontos=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CONQUISTAPONTOS",n||gx.fn.currentGridRowImpl(74),".")},nac:gx.falseFn};n[78]={id:78,lvl:2,type:"svchar",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CONQUISTANOME",gxz:"Z29ConquistaNome",gxold:"O29ConquistaNome",gxvar:"A29ConquistaNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A29ConquistaNome=n)},v2z:function(n){n!==undefined&&(gx.O.Z29ConquistaNome=n)},v2c:function(n){gx.fn.setGridControlValue("CONQUISTANOME",n||gx.fn.currentGridRowImpl(74),gx.O.A29ConquistaNome,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A29ConquistaNome=this.val())},val:function(n){return gx.fn.getGridControlValue("CONQUISTANOME",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[79]={id:79,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CONQUISTATIPO",gxz:"Z44ConquistaTipo",gxold:"O44ConquistaTipo",gxvar:"A44ConquistaTipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A44ConquistaTipo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z44ConquistaTipo=gx.num.intval(n))},v2c:function(n){gx.fn.setGridComboBoxValue("CONQUISTATIPO",n||gx.fn.currentGridRowImpl(74),gx.O.A44ConquistaTipo);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A44ConquistaTipo=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CONQUISTATIPO",n||gx.fn.currentGridRowImpl(74),".")},nac:gx.falseFn};n[80]={id:80,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CONQUISTAQUANTIDADENECESSARIA",gxz:"Z45ConquistaQuantidadeNecessaria",gxold:"O45ConquistaQuantidadeNecessaria",gxvar:"A45ConquistaQuantidadeNecessaria",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A45ConquistaQuantidadeNecessaria=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z45ConquistaQuantidadeNecessaria=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CONQUISTAQUANTIDADENECESSARIA",n||gx.fn.currentGridRowImpl(74),gx.O.A45ConquistaQuantidadeNecessaria,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A45ConquistaQuantidadeNecessaria=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CONQUISTAQUANTIDADENECESSARIA",n||gx.fn.currentGridRowImpl(74),".")},nac:gx.falseFn};n[81]={id:81,lvl:2,type:"boolean",len:4,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CONQUISTAINATIVO",gxz:"Z46ConquistaInativo",gxold:"O46ConquistaInativo",gxvar:"A46ConquistaInativo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A46ConquistaInativo=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z46ConquistaInativo=gx.lang.booleanValue(n))},v2c:function(n){gx.fn.setGridCheckBoxValue("CONQUISTAINATIVO",n||gx.fn.currentGridRowImpl(74),gx.O.A46ConquistaInativo,!0)},c2v:function(){this.val()!==undefined&&(gx.O.A46ConquistaInativo=gx.lang.booleanValue(this.val()))},val:function(n){return gx.fn.getGridControlValue("CONQUISTAINATIVO",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn,values:["true","false"]};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,fld:"BTN_CANCEL",grid:0};this.AV6cConquistaId=0;this.ZV6cConquistaId=0;this.OV6cConquistaId=0;this.AV7cConquistaPontos=0;this.ZV7cConquistaPontos=0;this.OV7cConquistaPontos=0;this.AV8cConquistaNome="";this.ZV8cConquistaNome="";this.OV8cConquistaNome="";this.AV11cConquistaTipo=0;this.ZV11cConquistaTipo=0;this.OV11cConquistaTipo=0;this.AV12cConquistaQuantidadeNecessaria=0;this.ZV12cConquistaQuantidadeNecessaria=0;this.OV12cConquistaQuantidadeNecessaria=0;this.AV13cConquistaInativo=!1;this.ZV13cConquistaInativo=!1;this.OV13cConquistaInativo=!1;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z27ConquistaId=0;this.O27ConquistaId=0;this.Z28ConquistaPontos=0;this.O28ConquistaPontos=0;this.Z29ConquistaNome="";this.O29ConquistaNome="";this.Z44ConquistaTipo=0;this.O44ConquistaTipo=0;this.Z45ConquistaQuantidadeNecessaria=0;this.O45ConquistaQuantidadeNecessaria=0;this.Z46ConquistaInativo=!1;this.O46ConquistaInativo=!1;this.AV6cConquistaId=0;this.AV7cConquistaPontos=0;this.AV8cConquistaNome="";this.AV11cConquistaTipo=0;this.AV12cConquistaQuantidadeNecessaria=0;this.AV13cConquistaInativo=!1;this.AV9pConquistaId=0;this.AV5LinkSelection="";this.A27ConquistaId=0;this.A28ConquistaPontos=0;this.A29ConquistaNome="";this.A44ConquistaTipo=0;this.A45ConquistaQuantidadeNecessaria=0;this.A46ConquistaInativo=!1;this.Events={e20212_client:["ENTER",!0],e21211_client:["CANCEL",!0],e17211_client:["'TOGGLE'",!1],e11211_client:["LBLCONQUISTAIDFILTER.CLICK",!1],e12211_client:["LBLCONQUISTAPONTOSFILTER.CLICK",!1],e13211_client:["LBLCONQUISTANOMEFILTER.CLICK",!1],e14211_client:["LBLCONQUISTATIPOFILTER.CLICK",!1],e15211_client:["LBLCONQUISTAQUANTIDADENECESSARIAFILTER.CLICK",!1],e16211_client:["LBLCONQUISTAINATIVOFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cConquistaId",fld:"vCCONQUISTAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cConquistaPontos",fld:"vCCONQUISTAPONTOS",pic:"ZZZ9",nv:0},{av:"AV8cConquistaNome",fld:"vCCONQUISTANOME",pic:"",nv:""},{ctrl:"vCCONQUISTATIPO"},{av:"AV11cConquistaTipo",fld:"vCCONQUISTATIPO",pic:"ZZZ9",nv:0},{av:"AV12cConquistaQuantidadeNecessaria",fld:"vCCONQUISTAQUANTIDADENECESSARIA",pic:"ZZZ9",nv:0},{av:"AV13cConquistaInativo",fld:"vCCONQUISTAINATIVO",pic:"",nv:!1}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLCONQUISTAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CONQUISTAIDFILTERCONTAINER","Class")',ctrl:"CONQUISTAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CONQUISTAIDFILTERCONTAINER","Class")',ctrl:"CONQUISTAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCONQUISTAID","Visible")',ctrl:"vCCONQUISTAID",prop:"Visible"}]];this.EvtParms["LBLCONQUISTAPONTOSFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CONQUISTAPONTOSFILTERCONTAINER","Class")',ctrl:"CONQUISTAPONTOSFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CONQUISTAPONTOSFILTERCONTAINER","Class")',ctrl:"CONQUISTAPONTOSFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCONQUISTAPONTOS","Visible")',ctrl:"vCCONQUISTAPONTOS",prop:"Visible"}]];this.EvtParms["LBLCONQUISTANOMEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CONQUISTANOMEFILTERCONTAINER","Class")',ctrl:"CONQUISTANOMEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CONQUISTANOMEFILTERCONTAINER","Class")',ctrl:"CONQUISTANOMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCONQUISTANOME","Visible")',ctrl:"vCCONQUISTANOME",prop:"Visible"}]];this.EvtParms["LBLCONQUISTATIPOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CONQUISTATIPOFILTERCONTAINER","Class")',ctrl:"CONQUISTATIPOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CONQUISTATIPOFILTERCONTAINER","Class")',ctrl:"CONQUISTATIPOFILTERCONTAINER",prop:"Class"},{ctrl:"vCCONQUISTATIPO"}]];this.EvtParms["LBLCONQUISTAQUANTIDADENECESSARIAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER","Class")',ctrl:"CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER","Class")',ctrl:"CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCONQUISTAQUANTIDADENECESSARIA","Visible")',ctrl:"vCCONQUISTAQUANTIDADENECESSARIA",prop:"Visible"}]];this.EvtParms["LBLCONQUISTAINATIVOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CONQUISTAINATIVOFILTERCONTAINER","Class")',ctrl:"CONQUISTAINATIVOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CONQUISTAINATIVOFILTERCONTAINER","Class")',ctrl:"CONQUISTAINATIVOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCONQUISTAINATIVO","Visible")',ctrl:"vCCONQUISTAINATIVO",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A27ConquistaId",fld:"CONQUISTAID",pic:"ZZZZZZZZZZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV9pConquistaId",fld:"vPCONQUISTAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cConquistaId",fld:"vCCONQUISTAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cConquistaPontos",fld:"vCCONQUISTAPONTOS",pic:"ZZZ9",nv:0},{av:"AV8cConquistaNome",fld:"vCCONQUISTANOME",pic:"",nv:""},{ctrl:"vCCONQUISTATIPO"},{av:"AV11cConquistaTipo",fld:"vCCONQUISTATIPO",pic:"ZZZ9",nv:0},{av:"AV12cConquistaQuantidadeNecessaria",fld:"vCCONQUISTAQUANTIDADENECESSARIA",pic:"ZZZ9",nv:0},{av:"AV13cConquistaInativo",fld:"vCCONQUISTAINATIVO",pic:"",nv:!1}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cConquistaId",fld:"vCCONQUISTAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cConquistaPontos",fld:"vCCONQUISTAPONTOS",pic:"ZZZ9",nv:0},{av:"AV8cConquistaNome",fld:"vCCONQUISTANOME",pic:"",nv:""},{ctrl:"vCCONQUISTATIPO"},{av:"AV11cConquistaTipo",fld:"vCCONQUISTATIPO",pic:"ZZZ9",nv:0},{av:"AV12cConquistaQuantidadeNecessaria",fld:"vCCONQUISTAQUANTIDADENECESSARIA",pic:"ZZZ9",nv:0},{av:"AV13cConquistaInativo",fld:"vCCONQUISTAINATIVO",pic:"",nv:!1}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cConquistaId",fld:"vCCONQUISTAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cConquistaPontos",fld:"vCCONQUISTAPONTOS",pic:"ZZZ9",nv:0},{av:"AV8cConquistaNome",fld:"vCCONQUISTANOME",pic:"",nv:""},{ctrl:"vCCONQUISTATIPO"},{av:"AV11cConquistaTipo",fld:"vCCONQUISTATIPO",pic:"ZZZ9",nv:0},{av:"AV12cConquistaQuantidadeNecessaria",fld:"vCCONQUISTAQUANTIDADENECESSARIA",pic:"ZZZ9",nv:0},{av:"AV13cConquistaInativo",fld:"vCCONQUISTAINATIVO",pic:"",nv:!1}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cConquistaId",fld:"vCCONQUISTAID",pic:"ZZZZZZZZZZZZZZZZZ9",nv:0},{av:"AV7cConquistaPontos",fld:"vCCONQUISTAPONTOS",pic:"ZZZ9",nv:0},{av:"AV8cConquistaNome",fld:"vCCONQUISTANOME",pic:"",nv:""},{ctrl:"vCCONQUISTATIPO"},{av:"AV11cConquistaTipo",fld:"vCCONQUISTATIPO",pic:"ZZZ9",nv:0},{av:"AV12cConquistaQuantidadeNecessaria",fld:"vCCONQUISTAQUANTIDADENECESSARIA",pic:"ZZZ9",nv:0},{av:"AV13cConquistaInativo",fld:"vCCONQUISTAINATIVO",pic:"",nv:!1}],[]];this.setVCMap("AV9pConquistaId","vPCONQUISTAID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);this.Initialize()});gx.createParentObj(gx0070)