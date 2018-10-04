/*
               File: Conquista
        Description: Conquista
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:22.10
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class conquista : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
         gxfirstwebparm_bkp = gxfirstwebparm;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7ConquistaId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConquistaId), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCONQUISTAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ConquistaId), "ZZZZZZZZZZZZZZZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         cmbConquistaTipo.Name = "CONQUISTATIPO";
         cmbConquistaTipo.WebTags = "";
         cmbConquistaTipo.addItem("1", "Quantidade de séries", 0);
         cmbConquistaTipo.addItem("2", "Quantidade de minutos", 0);
         cmbConquistaTipo.addItem("3", "Quantidade de episódios", 0);
         if ( cmbConquistaTipo.ItemCount > 0 )
         {
            A44ConquistaTipo = (short)(NumberUtil.Val( cmbConquistaTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44ConquistaTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0)));
         }
         chkConquistaInativo.Name = "CONQUISTAINATIVO";
         chkConquistaInativo.WebTags = "";
         chkConquistaInativo.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkConquistaInativo_Internalname, "TitleCaption", chkConquistaInativo.Caption, true);
         chkConquistaInativo.CheckedValue = "false";
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Conquista", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtConquistaNome_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public conquista( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public conquista( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           long aP1_ConquistaId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7ConquistaId = aP1_ConquistaId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbConquistaTipo = new GXCombobox();
         chkConquistaInativo = new GXCheckbox();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("wwpbaseobjects.workwithplusmasterpage", "GeneXus.Programs.wwpbaseobjects.workwithplusmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void fix_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
         }
         if ( cmbConquistaTipo.ItemCount > 0 )
         {
            A44ConquistaTipo = (short)(NumberUtil.Val( cmbConquistaTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44ConquistaTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbConquistaTipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbConquistaTipo_Internalname, "Values", cmbConquistaTipo.ToJavascriptSource(), true);
         }
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainTransaction", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtConquistaNome_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtConquistaNome_Internalname, "Nome", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtConquistaNome_Internalname, A29ConquistaNome, StringUtil.RTrim( context.localUtil.Format( A29ConquistaNome, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtConquistaNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtConquistaNome_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Nome", "left", true, "HLP_Conquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtConquistaPontos_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtConquistaPontos_Internalname, "Pontos", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtConquistaPontos_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A28ConquistaPontos), 4, 0, ",", "")), ((edtConquistaPontos_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A28ConquistaPontos), "ZZZ9")) : context.localUtil.Format( (decimal)(A28ConquistaPontos), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtConquistaPontos_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtConquistaPontos_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Pontos", "right", false, "HLP_Conquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbConquistaTipo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbConquistaTipo_Internalname, "Tipo de conquista", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbConquistaTipo, cmbConquistaTipo_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0)), 1, cmbConquistaTipo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbConquistaTipo.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,35);\"", "", true, "HLP_Conquista.htm");
            cmbConquistaTipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbConquistaTipo_Internalname, "Values", (String)(cmbConquistaTipo.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtConquistaQuantidadeNecessaria_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtConquistaQuantidadeNecessaria_Internalname, "Quantidade necessária", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtConquistaQuantidadeNecessaria_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A45ConquistaQuantidadeNecessaria), 4, 0, ",", "")), ((edtConquistaQuantidadeNecessaria_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A45ConquistaQuantidadeNecessaria), "ZZZ9")) : context.localUtil.Format( (decimal)(A45ConquistaQuantidadeNecessaria), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtConquistaQuantidadeNecessaria_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtConquistaQuantidadeNecessaria_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Quantidade", "right", false, "HLP_Conquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkConquistaInativo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkConquistaInativo_Internalname, "Inativo", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkConquistaInativo_Internalname, StringUtil.BoolToStr( A46ConquistaInativo), "", "Inativo", 1, chkConquistaInativo.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(45, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,45);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "Fechar", bttBtntrn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Conquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "Confirmar", bttBtntrn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Conquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "Eliminar", bttBtntrn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Conquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtConquistaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ConquistaId), 18, 0, ",", "")), ((edtConquistaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtConquistaId_Jsonclick, 0, "Attribute", "", "", "", "", edtConquistaId_Visible, edtConquistaId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Conquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11072 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A29ConquistaNome = cgiGet( edtConquistaNome_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29ConquistaNome", A29ConquistaNome);
               if ( ( ( context.localUtil.CToN( cgiGet( edtConquistaPontos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtConquistaPontos_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CONQUISTAPONTOS");
                  AnyError = 1;
                  GX_FocusControl = edtConquistaPontos_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A28ConquistaPontos = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ConquistaPontos), 4, 0)));
               }
               else
               {
                  A28ConquistaPontos = (short)(context.localUtil.CToN( cgiGet( edtConquistaPontos_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ConquistaPontos), 4, 0)));
               }
               cmbConquistaTipo.CurrentValue = cgiGet( cmbConquistaTipo_Internalname);
               A44ConquistaTipo = (short)(NumberUtil.Val( cgiGet( cmbConquistaTipo_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44ConquistaTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtConquistaQuantidadeNecessaria_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtConquistaQuantidadeNecessaria_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CONQUISTAQUANTIDADENECESSARIA");
                  AnyError = 1;
                  GX_FocusControl = edtConquistaQuantidadeNecessaria_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A45ConquistaQuantidadeNecessaria = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45ConquistaQuantidadeNecessaria", StringUtil.LTrim( StringUtil.Str( (decimal)(A45ConquistaQuantidadeNecessaria), 4, 0)));
               }
               else
               {
                  A45ConquistaQuantidadeNecessaria = (short)(context.localUtil.CToN( cgiGet( edtConquistaQuantidadeNecessaria_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45ConquistaQuantidadeNecessaria", StringUtil.LTrim( StringUtil.Str( (decimal)(A45ConquistaQuantidadeNecessaria), 4, 0)));
               }
               A46ConquistaInativo = StringUtil.StrToBool( cgiGet( chkConquistaInativo_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46ConquistaInativo", A46ConquistaInativo);
               A27ConquistaId = (long)(context.localUtil.CToN( cgiGet( edtConquistaId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
               /* Read saved values. */
               Z27ConquistaId = (long)(context.localUtil.CToN( cgiGet( "Z27ConquistaId"), ",", "."));
               Z28ConquistaPontos = (short)(context.localUtil.CToN( cgiGet( "Z28ConquistaPontos"), ",", "."));
               Z29ConquistaNome = cgiGet( "Z29ConquistaNome");
               Z44ConquistaTipo = (short)(context.localUtil.CToN( cgiGet( "Z44ConquistaTipo"), ",", "."));
               Z45ConquistaQuantidadeNecessaria = (short)(context.localUtil.CToN( cgiGet( "Z45ConquistaQuantidadeNecessaria"), ",", "."));
               Z46ConquistaInativo = StringUtil.StrToBool( cgiGet( "Z46ConquistaInativo"));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7ConquistaId = (long)(context.localUtil.CToN( cgiGet( "vCONQUISTAID"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               Dvpanel_tableattributes_Objectcall = cgiGet( "DVPANEL_TABLEATTRIBUTES_Objectcall");
               Dvpanel_tableattributes_Class = cgiGet( "DVPANEL_TABLEATTRIBUTES_Class");
               Dvpanel_tableattributes_Enabled = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Enabled"));
               Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
               Dvpanel_tableattributes_Height = cgiGet( "DVPANEL_TABLEATTRIBUTES_Height");
               Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
               Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
               Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
               Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
               Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
               Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
               Dvpanel_tableattributes_Showheader = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showheader"));
               Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
               Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
               Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
               Dvpanel_tableattributes_Visible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Visible"));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Conquista";
               A27ConquistaId = (long)(context.localUtil.CToN( cgiGet( edtConquistaId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A27ConquistaId != Z27ConquistaId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("conquista:[SecurityCheckFailed value for]"+"ConquistaId:"+context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9"));
                  GXUtil.WriteLog("conquista:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A27ConquistaId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode7 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode7;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound7 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_070( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "CONQUISTAID");
                        AnyError = 1;
                        GX_FocusControl = edtConquistaId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName");
            EvtGridId = cgiGet( "_EventGridId");
            EvtRowId = cgiGet( "_EventRowId");
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1);
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11072 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12072 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12072 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll077( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtntrn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtntrn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes077( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_070( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls077( ) ;
            }
            else
            {
               CheckExtendedTable077( ) ;
               CloseExtendedTableCursors077( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption070( )
      {
      }

      protected void E11072( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "SeriesColaborativas");
         edtConquistaId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaId_Visible), 5, 0)), true);
      }

      protected void E12072( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("conquistaww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM077( short GX_JID )
      {
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z28ConquistaPontos = T00073_A28ConquistaPontos[0];
               Z29ConquistaNome = T00073_A29ConquistaNome[0];
               Z44ConquistaTipo = T00073_A44ConquistaTipo[0];
               Z45ConquistaQuantidadeNecessaria = T00073_A45ConquistaQuantidadeNecessaria[0];
               Z46ConquistaInativo = T00073_A46ConquistaInativo[0];
            }
            else
            {
               Z28ConquistaPontos = A28ConquistaPontos;
               Z29ConquistaNome = A29ConquistaNome;
               Z44ConquistaTipo = A44ConquistaTipo;
               Z45ConquistaQuantidadeNecessaria = A45ConquistaQuantidadeNecessaria;
               Z46ConquistaInativo = A46ConquistaInativo;
            }
         }
         if ( GX_JID == -8 )
         {
            Z27ConquistaId = A27ConquistaId;
            Z28ConquistaPontos = A28ConquistaPontos;
            Z29ConquistaNome = A29ConquistaNome;
            Z44ConquistaTipo = A44ConquistaTipo;
            Z45ConquistaQuantidadeNecessaria = A45ConquistaQuantidadeNecessaria;
            Z46ConquistaInativo = A46ConquistaInativo;
         }
      }

      protected void standaloneNotModal( )
      {
         edtConquistaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaId_Enabled), 5, 0)), true);
         edtConquistaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaId_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7ConquistaId) )
         {
            A27ConquistaId = AV7ConquistaId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtntrn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtntrn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
      }

      protected void Load077( )
      {
         /* Using cursor T00074 */
         pr_default.execute(2, new Object[] {A27ConquistaId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound7 = 1;
            A28ConquistaPontos = T00074_A28ConquistaPontos[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ConquistaPontos), 4, 0)));
            A29ConquistaNome = T00074_A29ConquistaNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29ConquistaNome", A29ConquistaNome);
            A44ConquistaTipo = T00074_A44ConquistaTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44ConquistaTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0)));
            A45ConquistaQuantidadeNecessaria = T00074_A45ConquistaQuantidadeNecessaria[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45ConquistaQuantidadeNecessaria", StringUtil.LTrim( StringUtil.Str( (decimal)(A45ConquistaQuantidadeNecessaria), 4, 0)));
            A46ConquistaInativo = T00074_A46ConquistaInativo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46ConquistaInativo", A46ConquistaInativo);
            ZM077( -8) ;
         }
         pr_default.close(2);
         OnLoadActions077( ) ;
      }

      protected void OnLoadActions077( )
      {
      }

      protected void CheckExtendedTable077( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( (0==A28ConquistaPontos) )
         {
            GX_msglist.addItem("Pontos é obrigatório.", 1, "CONQUISTAPONTOS");
            AnyError = 1;
            GX_FocusControl = edtConquistaPontos_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A29ConquistaNome)) )
         {
            GX_msglist.addItem("Nome é obrigatório.", 1, "CONQUISTANOME");
            AnyError = 1;
            GX_FocusControl = edtConquistaNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( A44ConquistaTipo == 1 ) || ( A44ConquistaTipo == 2 ) || ( A44ConquistaTipo == 3 ) ) )
         {
            GX_msglist.addItem("Campo Tipo de conquista fora do intervalo", "OutOfRange", 1, "CONQUISTATIPO");
            AnyError = 1;
            GX_FocusControl = cmbConquistaTipo_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (0==A44ConquistaTipo) )
         {
            GX_msglist.addItem("Tipo de conquista é obrigatório.", 1, "CONQUISTATIPO");
            AnyError = 1;
            GX_FocusControl = cmbConquistaTipo_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (0==A45ConquistaQuantidadeNecessaria) )
         {
            GX_msglist.addItem("Quantidade necessária é obrigatório.", 1, "CONQUISTAQUANTIDADENECESSARIA");
            AnyError = 1;
            GX_FocusControl = edtConquistaQuantidadeNecessaria_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors077( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey077( )
      {
         /* Using cursor T00075 */
         pr_default.execute(3, new Object[] {A27ConquistaId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00073 */
         pr_default.execute(1, new Object[] {A27ConquistaId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM077( 8) ;
            RcdFound7 = 1;
            A27ConquistaId = T00073_A27ConquistaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
            A28ConquistaPontos = T00073_A28ConquistaPontos[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ConquistaPontos), 4, 0)));
            A29ConquistaNome = T00073_A29ConquistaNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29ConquistaNome", A29ConquistaNome);
            A44ConquistaTipo = T00073_A44ConquistaTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44ConquistaTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0)));
            A45ConquistaQuantidadeNecessaria = T00073_A45ConquistaQuantidadeNecessaria[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45ConquistaQuantidadeNecessaria", StringUtil.LTrim( StringUtil.Str( (decimal)(A45ConquistaQuantidadeNecessaria), 4, 0)));
            A46ConquistaInativo = T00073_A46ConquistaInativo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46ConquistaInativo", A46ConquistaInativo);
            Z27ConquistaId = A27ConquistaId;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load077( ) ;
            if ( AnyError == 1 )
            {
               RcdFound7 = 0;
               InitializeNonKey077( ) ;
            }
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey077( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey077( ) ;
         if ( RcdFound7 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound7 = 0;
         /* Using cursor T00076 */
         pr_default.execute(4, new Object[] {A27ConquistaId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00076_A27ConquistaId[0] < A27ConquistaId ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00076_A27ConquistaId[0] > A27ConquistaId ) ) )
            {
               A27ConquistaId = T00076_A27ConquistaId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
               RcdFound7 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound7 = 0;
         /* Using cursor T00077 */
         pr_default.execute(5, new Object[] {A27ConquistaId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00077_A27ConquistaId[0] > A27ConquistaId ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00077_A27ConquistaId[0] < A27ConquistaId ) ) )
            {
               A27ConquistaId = T00077_A27ConquistaId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
               RcdFound7 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey077( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtConquistaNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert077( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound7 == 1 )
            {
               if ( A27ConquistaId != Z27ConquistaId )
               {
                  A27ConquistaId = Z27ConquistaId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "CONQUISTAID");
                  AnyError = 1;
                  GX_FocusControl = edtConquistaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtConquistaNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update077( ) ;
                  GX_FocusControl = edtConquistaNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A27ConquistaId != Z27ConquistaId )
               {
                  /* Insert record */
                  GX_FocusControl = edtConquistaNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert077( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "CONQUISTAID");
                     AnyError = 1;
                     GX_FocusControl = edtConquistaId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtConquistaNome_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert077( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A27ConquistaId != Z27ConquistaId )
         {
            A27ConquistaId = Z27ConquistaId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "CONQUISTAID");
            AnyError = 1;
            GX_FocusControl = edtConquistaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtConquistaNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency077( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00072 */
            pr_default.execute(0, new Object[] {A27ConquistaId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Conquista"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z28ConquistaPontos != T00072_A28ConquistaPontos[0] ) || ( StringUtil.StrCmp(Z29ConquistaNome, T00072_A29ConquistaNome[0]) != 0 ) || ( Z44ConquistaTipo != T00072_A44ConquistaTipo[0] ) || ( Z45ConquistaQuantidadeNecessaria != T00072_A45ConquistaQuantidadeNecessaria[0] ) || ( Z46ConquistaInativo != T00072_A46ConquistaInativo[0] ) )
            {
               if ( Z28ConquistaPontos != T00072_A28ConquistaPontos[0] )
               {
                  GXUtil.WriteLog("conquista:[seudo value changed for attri]"+"ConquistaPontos");
                  GXUtil.WriteLogRaw("Old: ",Z28ConquistaPontos);
                  GXUtil.WriteLogRaw("Current: ",T00072_A28ConquistaPontos[0]);
               }
               if ( StringUtil.StrCmp(Z29ConquistaNome, T00072_A29ConquistaNome[0]) != 0 )
               {
                  GXUtil.WriteLog("conquista:[seudo value changed for attri]"+"ConquistaNome");
                  GXUtil.WriteLogRaw("Old: ",Z29ConquistaNome);
                  GXUtil.WriteLogRaw("Current: ",T00072_A29ConquistaNome[0]);
               }
               if ( Z44ConquistaTipo != T00072_A44ConquistaTipo[0] )
               {
                  GXUtil.WriteLog("conquista:[seudo value changed for attri]"+"ConquistaTipo");
                  GXUtil.WriteLogRaw("Old: ",Z44ConquistaTipo);
                  GXUtil.WriteLogRaw("Current: ",T00072_A44ConquistaTipo[0]);
               }
               if ( Z45ConquistaQuantidadeNecessaria != T00072_A45ConquistaQuantidadeNecessaria[0] )
               {
                  GXUtil.WriteLog("conquista:[seudo value changed for attri]"+"ConquistaQuantidadeNecessaria");
                  GXUtil.WriteLogRaw("Old: ",Z45ConquistaQuantidadeNecessaria);
                  GXUtil.WriteLogRaw("Current: ",T00072_A45ConquistaQuantidadeNecessaria[0]);
               }
               if ( Z46ConquistaInativo != T00072_A46ConquistaInativo[0] )
               {
                  GXUtil.WriteLog("conquista:[seudo value changed for attri]"+"ConquistaInativo");
                  GXUtil.WriteLogRaw("Old: ",Z46ConquistaInativo);
                  GXUtil.WriteLogRaw("Current: ",T00072_A46ConquistaInativo[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Conquista"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert077( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable077( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM077( 0) ;
            CheckOptimisticConcurrency077( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm077( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert077( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00078 */
                     pr_default.execute(6, new Object[] {A28ConquistaPontos, A29ConquistaNome, A44ConquistaTipo, A45ConquistaQuantidadeNecessaria, A46ConquistaInativo});
                     A27ConquistaId = T00078_A27ConquistaId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Conquista") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption070( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load077( ) ;
            }
            EndLevel077( ) ;
         }
         CloseExtendedTableCursors077( ) ;
      }

      protected void Update077( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable077( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency077( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm077( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate077( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00079 */
                     pr_default.execute(7, new Object[] {A28ConquistaPontos, A29ConquistaNome, A44ConquistaTipo, A45ConquistaQuantidadeNecessaria, A46ConquistaInativo, A27ConquistaId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Conquista") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Conquista"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate077( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel077( ) ;
         }
         CloseExtendedTableCursors077( ) ;
      }

      protected void DeferredUpdate077( )
      {
      }

      protected void delete( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency077( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls077( ) ;
            AfterConfirm077( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete077( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000710 */
                  pr_default.execute(8, new Object[] {A27ConquistaId});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Conquista") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel077( ) ;
         Gx_mode = sMode7;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls077( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000711 */
            pr_default.execute(9, new Object[] {A27ConquistaId});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário conquista"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel077( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete077( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_gam.commit( "Conquista");
            pr_default.commit( "Conquista");
            if ( AnyError == 0 )
            {
               ConfirmValues070( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_gam.rollback( "Conquista");
            pr_default.rollback( "Conquista");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart077( )
      {
         /* Scan By routine */
         /* Using cursor T000712 */
         pr_default.execute(10);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound7 = 1;
            A27ConquistaId = T000712_A27ConquistaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext077( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound7 = 1;
            A27ConquistaId = T000712_A27ConquistaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
         }
      }

      protected void ScanEnd077( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm077( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert077( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate077( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete077( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete077( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate077( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes077( )
      {
         edtConquistaNome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaNome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaNome_Enabled), 5, 0)), true);
         edtConquistaPontos_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaPontos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaPontos_Enabled), 5, 0)), true);
         cmbConquistaTipo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbConquistaTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbConquistaTipo.Enabled), 5, 0)), true);
         edtConquistaQuantidadeNecessaria_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaQuantidadeNecessaria_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaQuantidadeNecessaria_Enabled), 5, 0)), true);
         chkConquistaInativo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkConquistaInativo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkConquistaInativo.Enabled), 5, 0)), true);
         edtConquistaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaId_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes077( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues070( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 121631), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxcfg.js", "?20189251962370", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("conquista.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7ConquistaId)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "Conquista";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("conquista:[SendSecurityCheck value for]"+"ConquistaId:"+context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9"));
         GXUtil.WriteLog("conquista:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z27ConquistaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27ConquistaId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z28ConquistaPontos", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28ConquistaPontos), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z29ConquistaNome", Z29ConquistaNome);
         GxWebStd.gx_hidden_field( context, "Z44ConquistaTipo", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z44ConquistaTipo), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z45ConquistaQuantidadeNecessaria", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z45ConquistaQuantidadeNecessaria), 4, 0, ",", "")));
         GxWebStd.gx_boolean_hidden_field( context, "Z46ConquistaInativo", Z46ConquistaInativo);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "vCONQUISTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ConquistaId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCONQUISTAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ConquistaId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Objectcall", StringUtil.RTrim( Dvpanel_tableattributes_Objectcall));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Enabled", StringUtil.BoolToStr( Dvpanel_tableattributes_Enabled));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Width", StringUtil.RTrim( Dvpanel_tableattributes_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Cls", StringUtil.RTrim( Dvpanel_tableattributes_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Title", StringUtil.RTrim( Dvpanel_tableattributes_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsible", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsed", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autowidth", StringUtil.BoolToStr( Dvpanel_tableattributes_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoheight", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableattributes_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Iconposition", StringUtil.RTrim( Dvpanel_tableattributes_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoscroll));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("conquista.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7ConquistaId) ;
      }

      public override String GetPgmname( )
      {
         return "Conquista" ;
      }

      public override String GetPgmdesc( )
      {
         return "Conquista" ;
      }

      protected void InitializeNonKey077( )
      {
         A28ConquistaPontos = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ConquistaPontos), 4, 0)));
         A29ConquistaNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29ConquistaNome", A29ConquistaNome);
         A44ConquistaTipo = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44ConquistaTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0)));
         A45ConquistaQuantidadeNecessaria = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45ConquistaQuantidadeNecessaria", StringUtil.LTrim( StringUtil.Str( (decimal)(A45ConquistaQuantidadeNecessaria), 4, 0)));
         A46ConquistaInativo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46ConquistaInativo", A46ConquistaInativo);
         Z28ConquistaPontos = 0;
         Z29ConquistaNome = "";
         Z44ConquistaTipo = 0;
         Z45ConquistaQuantidadeNecessaria = 0;
         Z46ConquistaInativo = false;
      }

      protected void InitAll077( )
      {
         A27ConquistaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
         InitializeNonKey077( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20189251962399", true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.por.js", "?"+GetCacheInvalidationToken( ), false);
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("conquista.js", "?20189251962399", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtConquistaNome_Internalname = "CONQUISTANOME";
         edtConquistaPontos_Internalname = "CONQUISTAPONTOS";
         cmbConquistaTipo_Internalname = "CONQUISTATIPO";
         edtConquistaQuantidadeNecessaria_Internalname = "CONQUISTAQUANTIDADENECESSARIA";
         chkConquistaInativo_Internalname = "CONQUISTAINATIVO";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtConquistaId_Internalname = "CONQUISTAID";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "Informações Gerais";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Conquista";
         edtConquistaId_Jsonclick = "";
         edtConquistaId_Enabled = 0;
         edtConquistaId_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         chkConquistaInativo.Enabled = 1;
         edtConquistaQuantidadeNecessaria_Jsonclick = "";
         edtConquistaQuantidadeNecessaria_Enabled = 1;
         cmbConquistaTipo_Jsonclick = "";
         cmbConquistaTipo.Enabled = 1;
         edtConquistaPontos_Jsonclick = "";
         edtConquistaPontos_Enabled = 1;
         edtConquistaNome_Jsonclick = "";
         edtConquistaNome_Enabled = 1;
         chkConquistaInativo.Caption = "Inativo";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7ConquistaId',fld:'vCONQUISTAID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7ConquistaId',fld:'vCONQUISTAID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0},{av:'A27ConquistaId',fld:'CONQUISTAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12072',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:'',nv:null}],oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z29ConquistaNome = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         A29ConquistaNome = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode7 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         T00074_A27ConquistaId = new long[1] ;
         T00074_A28ConquistaPontos = new short[1] ;
         T00074_A29ConquistaNome = new String[] {""} ;
         T00074_A44ConquistaTipo = new short[1] ;
         T00074_A45ConquistaQuantidadeNecessaria = new short[1] ;
         T00074_A46ConquistaInativo = new bool[] {false} ;
         T00075_A27ConquistaId = new long[1] ;
         T00073_A27ConquistaId = new long[1] ;
         T00073_A28ConquistaPontos = new short[1] ;
         T00073_A29ConquistaNome = new String[] {""} ;
         T00073_A44ConquistaTipo = new short[1] ;
         T00073_A45ConquistaQuantidadeNecessaria = new short[1] ;
         T00073_A46ConquistaInativo = new bool[] {false} ;
         T00076_A27ConquistaId = new long[1] ;
         T00077_A27ConquistaId = new long[1] ;
         T00072_A27ConquistaId = new long[1] ;
         T00072_A28ConquistaPontos = new short[1] ;
         T00072_A29ConquistaNome = new String[] {""} ;
         T00072_A44ConquistaTipo = new short[1] ;
         T00072_A45ConquistaQuantidadeNecessaria = new short[1] ;
         T00072_A46ConquistaInativo = new bool[] {false} ;
         T00078_A27ConquistaId = new long[1] ;
         T000711_A30UsuarioConquistaId = new long[1] ;
         T000712_A27ConquistaId = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.conquista__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.conquista__default(),
            new Object[][] {
                new Object[] {
               T00072_A27ConquistaId, T00072_A28ConquistaPontos, T00072_A29ConquistaNome, T00072_A44ConquistaTipo, T00072_A45ConquistaQuantidadeNecessaria, T00072_A46ConquistaInativo
               }
               , new Object[] {
               T00073_A27ConquistaId, T00073_A28ConquistaPontos, T00073_A29ConquistaNome, T00073_A44ConquistaTipo, T00073_A45ConquistaQuantidadeNecessaria, T00073_A46ConquistaInativo
               }
               , new Object[] {
               T00074_A27ConquistaId, T00074_A28ConquistaPontos, T00074_A29ConquistaNome, T00074_A44ConquistaTipo, T00074_A45ConquistaQuantidadeNecessaria, T00074_A46ConquistaInativo
               }
               , new Object[] {
               T00075_A27ConquistaId
               }
               , new Object[] {
               T00076_A27ConquistaId
               }
               , new Object[] {
               T00077_A27ConquistaId
               }
               , new Object[] {
               T00078_A27ConquistaId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000711_A30UsuarioConquistaId
               }
               , new Object[] {
               T000712_A27ConquistaId
               }
            }
         );
      }

      private short Z28ConquistaPontos ;
      private short Z44ConquistaTipo ;
      private short Z45ConquistaQuantidadeNecessaria ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short A44ConquistaTipo ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A28ConquistaPontos ;
      private short A45ConquistaQuantidadeNecessaria ;
      private short RcdFound7 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int edtConquistaNome_Enabled ;
      private int edtConquistaPontos_Enabled ;
      private int edtConquistaQuantidadeNecessaria_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtConquistaId_Enabled ;
      private int edtConquistaId_Visible ;
      private int idxLst ;
      private long wcpOAV7ConquistaId ;
      private long Z27ConquistaId ;
      private long AV7ConquistaId ;
      private long A27ConquistaId ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String chkConquistaInativo_Internalname ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtConquistaNome_Internalname ;
      private String cmbConquistaTipo_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String TempTags ;
      private String edtConquistaNome_Jsonclick ;
      private String edtConquistaPontos_Internalname ;
      private String edtConquistaPontos_Jsonclick ;
      private String cmbConquistaTipo_Jsonclick ;
      private String edtConquistaQuantidadeNecessaria_Internalname ;
      private String edtConquistaQuantidadeNecessaria_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtConquistaId_Internalname ;
      private String edtConquistaId_Jsonclick ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Height ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode7 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_tableattributes_Internalname ;
      private bool Z46ConquistaInativo ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A46ConquistaInativo ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool returnInSub ;
      private String Z29ConquistaNome ;
      private String A29ConquistaNome ;
      private IGxSession AV12WebSession ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbConquistaTipo ;
      private GXCheckbox chkConquistaInativo ;
      private IDataStoreProvider pr_default ;
      private long[] T00074_A27ConquistaId ;
      private short[] T00074_A28ConquistaPontos ;
      private String[] T00074_A29ConquistaNome ;
      private short[] T00074_A44ConquistaTipo ;
      private short[] T00074_A45ConquistaQuantidadeNecessaria ;
      private bool[] T00074_A46ConquistaInativo ;
      private long[] T00075_A27ConquistaId ;
      private long[] T00073_A27ConquistaId ;
      private short[] T00073_A28ConquistaPontos ;
      private String[] T00073_A29ConquistaNome ;
      private short[] T00073_A44ConquistaTipo ;
      private short[] T00073_A45ConquistaQuantidadeNecessaria ;
      private bool[] T00073_A46ConquistaInativo ;
      private long[] T00076_A27ConquistaId ;
      private long[] T00077_A27ConquistaId ;
      private long[] T00072_A27ConquistaId ;
      private short[] T00072_A28ConquistaPontos ;
      private String[] T00072_A29ConquistaNome ;
      private short[] T00072_A44ConquistaTipo ;
      private short[] T00072_A45ConquistaQuantidadeNecessaria ;
      private bool[] T00072_A46ConquistaInativo ;
      private long[] T00078_A27ConquistaId ;
      private long[] T000711_A30UsuarioConquistaId ;
      private IDataStoreProvider pr_gam ;
      private long[] T000712_A27ConquistaId ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
   }

   public class conquista__gam : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "GAM";
    }

 }

 public class conquista__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
       ,new ForEachCursor(def[3])
       ,new ForEachCursor(def[4])
       ,new ForEachCursor(def[5])
       ,new ForEachCursor(def[6])
       ,new UpdateCursor(def[7])
       ,new UpdateCursor(def[8])
       ,new ForEachCursor(def[9])
       ,new ForEachCursor(def[10])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00074 ;
        prmT00074 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00075 ;
        prmT00075 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00073 ;
        prmT00073 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00076 ;
        prmT00076 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00077 ;
        prmT00077 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00072 ;
        prmT00072 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00078 ;
        prmT00078 = new Object[] {
        new Object[] {"@ConquistaPontos",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@ConquistaNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@ConquistaTipo",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@ConquistaQuantidadeNecessaria",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@ConquistaInativo",SqlDbType.Bit,4,0}
        } ;
        Object[] prmT00079 ;
        prmT00079 = new Object[] {
        new Object[] {"@ConquistaPontos",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@ConquistaNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@ConquistaTipo",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@ConquistaQuantidadeNecessaria",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@ConquistaInativo",SqlDbType.Bit,4,0} ,
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000710 ;
        prmT000710 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000711 ;
        prmT000711 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000712 ;
        prmT000712 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("T00072", "SELECT [ConquistaId], [ConquistaPontos], [ConquistaNome], [ConquistaTipo], [ConquistaQuantidadeNecessaria], [ConquistaInativo] FROM [Conquista] WITH (UPDLOCK) WHERE [ConquistaId] = @ConquistaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00072,1,0,true,false )
           ,new CursorDef("T00073", "SELECT [ConquistaId], [ConquistaPontos], [ConquistaNome], [ConquistaTipo], [ConquistaQuantidadeNecessaria], [ConquistaInativo] FROM [Conquista] WITH (NOLOCK) WHERE [ConquistaId] = @ConquistaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00073,1,0,true,false )
           ,new CursorDef("T00074", "SELECT TM1.[ConquistaId], TM1.[ConquistaPontos], TM1.[ConquistaNome], TM1.[ConquistaTipo], TM1.[ConquistaQuantidadeNecessaria], TM1.[ConquistaInativo] FROM [Conquista] TM1 WITH (NOLOCK) WHERE TM1.[ConquistaId] = @ConquistaId ORDER BY TM1.[ConquistaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00074,100,0,true,false )
           ,new CursorDef("T00075", "SELECT [ConquistaId] FROM [Conquista] WITH (NOLOCK) WHERE [ConquistaId] = @ConquistaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00075,1,0,true,false )
           ,new CursorDef("T00076", "SELECT TOP 1 [ConquistaId] FROM [Conquista] WITH (NOLOCK) WHERE ( [ConquistaId] > @ConquistaId) ORDER BY [ConquistaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00076,1,0,true,true )
           ,new CursorDef("T00077", "SELECT TOP 1 [ConquistaId] FROM [Conquista] WITH (NOLOCK) WHERE ( [ConquistaId] < @ConquistaId) ORDER BY [ConquistaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00077,1,0,true,true )
           ,new CursorDef("T00078", "INSERT INTO [Conquista]([ConquistaPontos], [ConquistaNome], [ConquistaTipo], [ConquistaQuantidadeNecessaria], [ConquistaInativo]) VALUES(@ConquistaPontos, @ConquistaNome, @ConquistaTipo, @ConquistaQuantidadeNecessaria, @ConquistaInativo); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT00078)
           ,new CursorDef("T00079", "UPDATE [Conquista] SET [ConquistaPontos]=@ConquistaPontos, [ConquistaNome]=@ConquistaNome, [ConquistaTipo]=@ConquistaTipo, [ConquistaQuantidadeNecessaria]=@ConquistaQuantidadeNecessaria, [ConquistaInativo]=@ConquistaInativo  WHERE [ConquistaId] = @ConquistaId", GxErrorMask.GX_NOMASK,prmT00079)
           ,new CursorDef("T000710", "DELETE FROM [Conquista]  WHERE [ConquistaId] = @ConquistaId", GxErrorMask.GX_NOMASK,prmT000710)
           ,new CursorDef("T000711", "SELECT TOP 1 [UsuarioConquistaId] FROM [UsuarioConquista] WITH (NOLOCK) WHERE [ConquistaId] = @ConquistaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000711,1,0,true,true )
           ,new CursorDef("T000712", "SELECT [ConquistaId] FROM [Conquista] WITH (NOLOCK) ORDER BY [ConquistaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000712,100,0,true,false )
        };
     }
  }

  public void getResults( int cursor ,
                          IFieldGetter rslt ,
                          Object[] buf )
  {
     switch ( cursor )
     {
           case 0 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              ((bool[]) buf[5])[0] = rslt.getBool(6) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              ((bool[]) buf[5])[0] = rslt.getBool(6) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              ((bool[]) buf[5])[0] = rslt.getBool(6) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 10 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
           case 0 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 2 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (short)parms[3]);
              stmt.SetParameter(5, (bool)parms[4]);
              return;
           case 7 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (short)parms[3]);
              stmt.SetParameter(5, (bool)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
