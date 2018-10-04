/*!   GeneXus C# 15_0_9-121631 on 9/20/2018 19:38:24.73
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.wizardstepsbulletwc', true, function (CmpContext) {
   this.ServerClass =  "wwpbaseobjects.wizardstepsbulletwc" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV9StepNumber=gx.fn.getIntegerValue("vSTEPNUMBER",'.') ;
      this.AV12SelectedStepNumber=gx.fn.getIntegerValue("vSELECTEDSTEPNUMBER",'.') ;
      this.AV11WizardSteps=gx.fn.getControlValue("vWIZARDSTEPS") ;
      this.AV8CurrentStep=gx.fn.getControlValue("vCURRENTSTEP") ;
      this.AV9StepNumber=gx.fn.getIntegerValue("vSTEPNUMBER",'.') ;
      this.AV12SelectedStepNumber=gx.fn.getIntegerValue("vSELECTEDSTEPNUMBER",'.') ;
   };
   this.e130e2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e140e2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,8,11,14,17,19,20,21,22,23,24,26,29,32];
   this.GXLastCtrlId =32;
   this.GridwizardstepsContainer = new gx.grid.grid(this, 2,"WbpLvl2",5,"Gridwizardsteps","Gridwizardsteps","GridwizardstepsContainer",this.CmpContext,this.IsMasterPage,"wwpbaseobjects.wizardstepsbulletwc",[],true,0,true,true,0,false,false,false,"CollWWPBaseObjects\WizardSteps.WizardStepsItem",0,"px",0,"px","Novo registro",false,false,false,null,null,false,"AV11WizardSteps",false,[1,1,1,1],false,0,false,false);
   var GridwizardstepsContainer = this.GridwizardstepsContainer;
   GridwizardstepsContainer.startRow("","","","","","");
   GridwizardstepsContainer.startCell("","","top","","","","","","","");
   GridwizardstepsContainer.startTable("Tblcontainerstep",8,"0px");
   GridwizardstepsContainer.addHtmlCode("<tbody>");
   GridwizardstepsContainer.startRow("","","","","","");
   GridwizardstepsContainer.startCell("","","","","","","","","","");
   GridwizardstepsContainer.startTable("Tablestepbulletline",11,"0px");
   GridwizardstepsContainer.addHtmlCode("<tbody>");
   GridwizardstepsContainer.startRow("","","","","","");
   GridwizardstepsContainer.startCell("","","","","","","","","","TableStepBulletLineCell");
   GridwizardstepsContainer.startTable("Tablestepbulletlineleft",14,"0px");
   GridwizardstepsContainer.addHtmlCode("<tbody>");
   GridwizardstepsContainer.startRow("","","","","","");
   GridwizardstepsContainer.startCell("","","","","","","","","","");
   GridwizardstepsContainer.addTextBlock('DUMMYBULLETLINELEFT',null,17);
   GridwizardstepsContainer.endCell();
   GridwizardstepsContainer.endRow();
   GridwizardstepsContainer.addHtmlCode("</tbody>");
   GridwizardstepsContainer.endTable();
   GridwizardstepsContainer.endCell();
   GridwizardstepsContainer.startCell("","","","","","","","","","");
   GridwizardstepsContainer.startDiv(19,"Layout_tablestepitem","0px","0px");
   GridwizardstepsContainer.startDiv(20,"","0px","0px");
   GridwizardstepsContainer.startDiv(21,"Tablestepitem","0px","0px");
   GridwizardstepsContainer.startDiv(22,"","0px","0px");
   GridwizardstepsContainer.startDiv(23,"","0px","0px");
   GridwizardstepsContainer.addTextBlock('STEPNUMBER',null,24);
   GridwizardstepsContainer.endDiv();
   GridwizardstepsContainer.endDiv();
   GridwizardstepsContainer.endDiv();
   GridwizardstepsContainer.endDiv();
   GridwizardstepsContainer.endDiv();
   GridwizardstepsContainer.endCell();
   GridwizardstepsContainer.startCell("","","","","","","","","","TableStepBulletLineCell");
   GridwizardstepsContainer.startTable("Tablestepbulletlineright",26,"0px");
   GridwizardstepsContainer.addHtmlCode("<tbody>");
   GridwizardstepsContainer.startRow("","","","","","");
   GridwizardstepsContainer.startCell("","","","","","","","","","");
   GridwizardstepsContainer.addTextBlock('DUMMYBULLETLINERIGHT',null,29);
   GridwizardstepsContainer.endCell();
   GridwizardstepsContainer.endRow();
   GridwizardstepsContainer.addHtmlCode("</tbody>");
   GridwizardstepsContainer.endTable();
   GridwizardstepsContainer.endCell();
   GridwizardstepsContainer.endRow();
   GridwizardstepsContainer.addHtmlCode("</tbody>");
   GridwizardstepsContainer.endTable();
   GridwizardstepsContainer.endCell();
   GridwizardstepsContainer.endRow();
   GridwizardstepsContainer.startRow("","","","","","");
   GridwizardstepsContainer.startCell("","","","","","","","","","AttributeStepBulletCell");
   GridwizardstepsContainer.addSingleLineEdit("GXV2",32,"WIZARDSTEPS__TITLE","","","Title","svchar",40,"chr",40,40,"left",null,[],"GXV2","GXV2",true,0,false,false,"",1,"");
   GridwizardstepsContainer.endCell();
   GridwizardstepsContainer.endRow();
   GridwizardstepsContainer.addHtmlCode("</tbody>");
   GridwizardstepsContainer.endTable();
   GridwizardstepsContainer.endCell();
   GridwizardstepsContainer.endRow();
   this.GridwizardstepsContainer.emptyText = "";
   this.setGrid(GridwizardstepsContainer);
   GXValidFnc[2]={ id: 2, fld:"TABLEMAIN",grid:0};
   GXValidFnc[8]={ id: 8, fld:"TBLCONTAINERSTEP",grid:5};
   GXValidFnc[11]={ id: 11, fld:"TABLESTEPBULLETLINE",grid:5};
   GXValidFnc[14]={ id: 14, fld:"TABLESTEPBULLETLINELEFT",grid:5};
   GXValidFnc[17]={ id: 17, fld:"DUMMYBULLETLINELEFT", format:0,grid:5};
   GXValidFnc[19]={ id: 19, fld:"LAYOUT_TABLESTEPITEM",grid:5};
   GXValidFnc[20]={ id: 20, fld:"",grid:5};
   GXValidFnc[21]={ id: 21, fld:"TABLESTEPITEM",grid:5};
   GXValidFnc[22]={ id: 22, fld:"",grid:5};
   GXValidFnc[23]={ id: 23, fld:"",grid:5};
   GXValidFnc[24]={ id: 24, fld:"STEPNUMBER", format:0,grid:5};
   GXValidFnc[26]={ id: 26, fld:"TABLESTEPBULLETLINERIGHT",grid:5};
   GXValidFnc[29]={ id: 29, fld:"DUMMYBULLETLINERIGHT", format:0,grid:5};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:5,gxgrid:this.GridwizardstepsContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"WIZARDSTEPS__TITLE",gxz:"ZV18GXV2",gxold:"OV18GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.GXV2=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV18GXV2=Value},v2c:function(row){gx.fn.setGridControlValue("WIZARDSTEPS__TITLE",row || gx.fn.currentGridRowImpl(5),gx.O.GXV2,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV2=this.val()},val:function(row){return gx.fn.getGridControlValue("WIZARDSTEPS__TITLE",row || gx.fn.currentGridRowImpl(5))},nac:gx.falseFn};
   this.AV11WizardSteps = [ ] ;
   this.AV8CurrentStep = "" ;
   this.GXV2 = "" ;
   this.AV9StepNumber = 0 ;
   this.AV12SelectedStepNumber = 0 ;
   this.Events = {"e130e2_client": ["ENTER", true] ,"e140e2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRIDWIZARDSTEPS_nFirstRecordOnPage',nv:0},{av:'GRIDWIZARDSTEPS_nEOF',nv:0},{av:'AV11WizardSteps',fld:'vWIZARDSTEPS',grid:5,pic:'',nv:null},{av:'sPrefix',nv:''},{av:'AV9StepNumber',fld:'vSTEPNUMBER',pic:'ZZZ9',hsh:true,nv:0},{av:'AV12SelectedStepNumber',fld:'vSELECTEDSTEPNUMBER',pic:'ZZZ9',hsh:true,nv:0}],[]];
   this.EvtParms["START"] = [[{av:'AV11WizardSteps',fld:'vWIZARDSTEPS',grid:5,pic:'',nv:null},{av:'GRIDWIZARDSTEPS_nFirstRecordOnPage',nv:0},{av:'AV8CurrentStep',fld:'vCURRENTSTEP',pic:'',nv:''}],[{av:'AV12SelectedStepNumber',fld:'vSELECTEDSTEPNUMBER',pic:'ZZZ9',hsh:true,nv:0},{av:'AV9StepNumber',fld:'vSTEPNUMBER',pic:'ZZZ9',hsh:true,nv:0}]];
   this.EvtParms["GRIDWIZARDSTEPS.LOAD"] = [[{av:'AV9StepNumber',fld:'vSTEPNUMBER',pic:'ZZZ9',hsh:true,nv:0},{av:'AV12SelectedStepNumber',fld:'vSELECTEDSTEPNUMBER',pic:'ZZZ9',hsh:true,nv:0}],[{av:'gx.fn.getCtrlProperty("STEPNUMBER","Visible")',ctrl:'STEPNUMBER',prop:'Visible'},{av:'gx.fn.getCtrlProperty("STEPNUMBER","Caption")',ctrl:'STEPNUMBER',prop:'Caption'},{av:'gx.fn.getCtrlProperty("TABLESTEPBULLETLINELEFT","Class")',ctrl:'TABLESTEPBULLETLINELEFT',prop:'Class'},{av:'gx.fn.getCtrlProperty("TABLESTEPBULLETLINERIGHT","Class")',ctrl:'TABLESTEPBULLETLINERIGHT',prop:'Class'},{av:'gx.fn.getCtrlProperty("TABLESTEPITEM","Class")',ctrl:'TABLESTEPITEM',prop:'Class'},{ctrl:'WIZARDSTEPS__TITLE',prop:'Class'},{av:'gx.fn.getCtrlProperty("STEPNUMBER","Class")',ctrl:'STEPNUMBER',prop:'Class'},{av:'AV9StepNumber',fld:'vSTEPNUMBER',pic:'ZZZ9',hsh:true,nv:0}]];
   this.setVCMap("AV9StepNumber", "STEPNUMBER", 0, "int");
   this.setVCMap("AV12SelectedStepNumber", "vSELECTEDSTEPNUMBER", 0, "int");
   this.setVCMap("AV11WizardSteps", "vWIZARDSTEPS", 0, "CollWWPBaseObjects\WizardSteps.WizardStepsItem");
   this.setVCMap("AV8CurrentStep", "vCURRENTSTEP", 0, "svchar");
   this.setVCMap("AV9StepNumber", "STEPNUMBER", 0, "int");
   this.setVCMap("AV12SelectedStepNumber", "vSELECTEDSTEPNUMBER", 0, "int");
   this.setVCMap("AV9StepNumber", "STEPNUMBER", 0, "int");
   this.setVCMap("AV12SelectedStepNumber", "vSELECTEDSTEPNUMBER", 0, "int");
   GridwizardstepsContainer.addRefreshingVar({rfrVar:"AV9StepNumber"});
   GridwizardstepsContainer.addRefreshingVar({rfrVar:"AV12SelectedStepNumber"});
   this.addGridBCProperty("Wizardsteps", ["Title"], this.GXValidFnc[32], "AV11WizardSteps");
   this.Initialize( );
});
