/*
               File: GAMApplicationEntry
        Description: Application
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:44:19.81
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
   public class gamapplicationentry : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamapplicationentry( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamapplicationentry( IGxContext context )
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
                           long aP1_Id )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV34Id = aP1_Id;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavMainmenu = new GXCombobox();
         chkavAccessrequirespermission = new GXCheckbox();
         chkavClientaccessuniquebyuser = new GXCheckbox();
         chkavClientallowremoteauth = new GXCheckbox();
         chkavClientallowgetuserroles = new GXCheckbox();
         chkavClientallowgetuseradddata = new GXCheckbox();
         chkavEnvironmentsecureprotocol = new GXCheckbox();
         chkavAutoregisteranomymoususer = new GXCheckbox();
      }

      protected void INITWEB( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
                  AV34Id = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34Id), 12, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV34Id), "ZZZZZZZZZZZ9"), context));
               }
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
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

      public override short ExecuteStartEvent( )
      {
         PA1C2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1C2( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 121631), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxcfg.js", "?201892019442022", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("calendar-pt.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamapplicationentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV34Id)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV34Id), "ZZZZZZZZZZZ9"), context));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "GXUITABSPANEL_TABS_Class", StringUtil.RTrim( Gxuitabspanel_tabs_Class));
         GxWebStd.gx_hidden_field( context, "GXUITABSPANEL_TABS_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gxuitabspanel_tabs_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXUITABSPANEL_TABS_Historymanagement", StringUtil.BoolToStr( Gxuitabspanel_tabs_Historymanagement));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE1C2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1C2( ) ;
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
         return formatLink("gamapplicationentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV34Id) ;
      }

      public override String GetPgmname( )
      {
         return "GAMApplicationEntry" ;
      }

      public override String GetPgmdesc( )
      {
         return "Application" ;
      }

      protected void WB1C0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, divTablemain_Width, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableMainWithShadow", "left", "top", "", "", "div");
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
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"GXUITABSPANEL_TABSContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "General", "", "", lblGeneral_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMApplicationEntry.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "General") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable4_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavId_Internalname, "Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34Id), 12, 0, ",", "")), ((edtavId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV34Id), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV34Id), "ZZZZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavId_Enabled, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "GAMKeyNumLong", "right", false, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGuid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGuid_Internalname, "GUID", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGuid_Internalname, StringUtil.RTrim( AV32GUID), StringUtil.RTrim( context.localUtil.Format( AV32GUID, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGuid_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavGuid_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GAMGUID", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavName_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavName_Internalname, StringUtil.RTrim( AV39Name), StringUtil.RTrim( context.localUtil.Format( AV39Name, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavName_Enabled, 1, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavDsc_Internalname, "Description", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDsc_Internalname, StringUtil.RTrim( AV22Dsc), StringUtil.RTrim( context.localUtil.Format( AV22Dsc, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavDsc_Enabled, 1, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVersion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVersion_Internalname, "Version", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVersion_Internalname, StringUtil.RTrim( AV41Version), StringUtil.RTrim( context.localUtil.Format( AV41Version, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVersion_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavVersion_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionShort", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCompany_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCompany_Internalname, "Company", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCompany_Internalname, StringUtil.RTrim( AV20Company), StringUtil.RTrim( context.localUtil.Format( AV20Company, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCompany_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCompany_Enabled, 1, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCopyright_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCopyright_Internalname, "Copyright", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCopyright_Internalname, StringUtil.RTrim( AV21Copyright), StringUtil.RTrim( context.localUtil.Format( AV21Copyright, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCopyright_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCopyright_Enabled, 1, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavMainmenu_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavMainmenu_Internalname, "Main Menu", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavMainmenu, cmbavMainmenu_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV36MainMenu), 12, 0)), 1, cmbavMainmenu_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavMainmenu.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,60);\"", "", true, "HLP_GAMApplicationEntry.htm");
            cmbavMainmenu.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV36MainMenu), 12, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavMainmenu_Internalname, "Values", (String)(cmbavMainmenu.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavHomeobject_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavHomeobject_Internalname, "Home Object", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavHomeobject_Internalname, AV33HomeObject, StringUtil.RTrim( context.localUtil.Format( AV33HomeObject, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavHomeobject_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavHomeobject_Enabled, 1, "text", "", 0, "px", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientlocallogoutobject_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientlocallogoutobject_Internalname, "Local Logout Object", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientlocallogoutobject_Internalname, AV44ClientLocalLogoutObject, StringUtil.RTrim( context.localUtil.Format( AV44ClientLocalLogoutObject, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientlocallogoutobject_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavClientlocallogoutobject_Enabled, 1, "text", "", 0, "px", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavAccessrequirespermission_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavAccessrequirespermission_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavAccessrequirespermission_Internalname, StringUtil.BoolToStr( AV5AccessRequiresPermission), "", " ", 1, chkavAccessrequirespermission.Enabled, "true", "Requires permissions?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(75, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,75);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblClientapplicationdata_title_Internalname, "Client Application Data", "", "", lblClientapplicationdata_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMApplicationEntry.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "ClientApplicationData") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable3_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientid_Internalname, "Client Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientid_Internalname, StringUtil.RTrim( AV14ClientId), StringUtil.RTrim( context.localUtil.Format( AV14ClientId, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,85);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavClientid_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GAMClientApplicationId", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientsecret_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientsecret_Internalname, "Client Secret", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientsecret_Internalname, StringUtil.RTrim( AV19ClientSecret), StringUtil.RTrim( context.localUtil.Format( AV19ClientSecret, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,90);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientsecret_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavClientsecret_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, 0, true, "GAMClientApplicationSecret", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientaccessuniquebyuser_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientaccessuniquebyuser_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientaccessuniquebyuser_Internalname, StringUtil.BoolToStr( AV8ClientAccessUniqueByUser), "", " ", 1, chkavClientaccessuniquebyuser.Enabled, "true", "Single user access?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(95, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,95);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedclientrevoked_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockclientrevoked_Internalname, "Revoked", "", "", lblTextblockclientrevoked_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_103_1C2( true) ;
         }
         else
         {
            wb_table1_103_1C2( false) ;
         }
         return  ;
      }

      protected void wb_table1_103_1C2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"title3"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblRemoteauthentication_title_Internalname, "Remote Authentication", "", "", lblRemoteauthentication_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMApplicationEntry.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "RemoteAuthentication") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"panel3"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable2_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientallowremoteauth_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientallowremoteauth_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientallowremoteauth_Internalname, StringUtil.BoolToStr( AV11ClientAllowRemoteAuth), "", " ", 1, chkavClientallowremoteauth.Enabled, "true", "Allow remote authentication?", StyleString, ClassString, "", "", TempTags+" onblur=\""+""+";gx.evt.onblur(this,119);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divClientallowgetuserroles_cell_Internalname, 1, 0, "px", 0, "px", divClientallowgetuserroles_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", chkavClientallowgetuserroles.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientallowgetuserroles_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientallowgetuserroles_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 124,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientallowgetuserroles_Internalname, StringUtil.BoolToStr( AV10ClientAllowGetUserRoles), "", " ", chkavClientallowgetuserroles.Visible, chkavClientallowgetuserroles.Enabled, "true", "Can get user roles?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(124, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,124);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divClientallowgetuseradddata_cell_Internalname, 1, 0, "px", 0, "px", divClientallowgetuseradddata_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", chkavClientallowgetuseradddata.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavClientallowgetuseradddata_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavClientallowgetuseradddata_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 129,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavClientallowgetuseradddata_Internalname, StringUtil.BoolToStr( AV9ClientAllowGetUserAddData), "", " ", chkavClientallowgetuseradddata.Visible, chkavClientallowgetuseradddata.Enabled, "true", "Can get user additional data?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(129, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,129);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divClientlocalloginurl_cell_Internalname, 1, 0, "px", 0, "px", divClientlocalloginurl_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavClientlocalloginurl_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientlocalloginurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientlocalloginurl_Internalname, "Local Login URL", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 134,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientlocalloginurl_Internalname, AV16ClientLocalLoginURL, StringUtil.RTrim( context.localUtil.Format( AV16ClientLocalLoginURL, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,134);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientlocalloginurl_Jsonclick, 0, "Attribute", "", "", "", "", edtavClientlocalloginurl_Visible, edtavClientlocalloginurl_Enabled, 1, "text", "", 0, "px", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divClientcallbackurl_cell_Internalname, 1, 0, "px", 0, "px", divClientcallbackurl_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavClientcallbackurl_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientcallbackurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientcallbackurl_Internalname, " Callback URL", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 139,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientcallbackurl_Internalname, AV12ClientCallbackURL, StringUtil.RTrim( context.localUtil.Format( AV12ClientCallbackURL, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,139);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientcallbackurl_Jsonclick, 0, "Attribute", "", "", "", "", edtavClientcallbackurl_Visible, edtavClientcallbackurl_Enabled, 1, "text", "", 0, "px", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divClientimageurl_cell_Internalname, 1, 0, "px", 0, "px", divClientimageurl_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavClientimageurl_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientimageurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientimageurl_Internalname, " Image URL", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 144,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientimageurl_Internalname, AV15ClientImageURL, StringUtil.RTrim( context.localUtil.Format( AV15ClientImageURL, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,144);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientimageurl_Jsonclick, 0, "Attribute", "", "", "", "", edtavClientimageurl_Visible, edtavClientimageurl_Enabled, 1, "text", "", 0, "px", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedclientencryptionkey_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTextblockclientencryptionkey_cell_Internalname, 1, 0, "px", 0, "px", divTextblockclientencryptionkey_cell_Class, "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockclientencryptionkey_Internalname, "Private encryption key", "", "", lblTextblockclientencryptionkey_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table2_152_1C2( true) ;
         }
         else
         {
            wb_table2_152_1C2( false) ;
         }
         return  ;
      }

      protected void wb_table2_152_1C2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divClientrepositoryguid_cell_Internalname, 1, 0, "px", 0, "px", divClientrepositoryguid_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavClientrepositoryguid_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientrepositoryguid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientrepositoryguid_Internalname, "Repository GUID", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 163,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientrepositoryguid_Internalname, StringUtil.RTrim( AV42ClientRepositoryGUID), StringUtil.RTrim( context.localUtil.Format( AV42ClientRepositoryGUID, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,163);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientrepositoryguid_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", edtavClientrepositoryguid_Visible, edtavClientrepositoryguid_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GAMGUID", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"title4"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblEnvironmentsettings_title_Internalname, "Environment Settings", "", "", lblEnvironmentsettings_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMApplicationEntry.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "EnvironmentSettings") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"panel4"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEnvironmentname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEnvironmentname_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 173,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEnvironmentname_Internalname, StringUtil.RTrim( AV24EnvironmentName), StringUtil.RTrim( context.localUtil.Format( AV24EnvironmentName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,173);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEnvironmentname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavEnvironmentname_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionMedium", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavEnvironmentsecureprotocol_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavEnvironmentsecureprotocol_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 178,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavEnvironmentsecureprotocol_Internalname, StringUtil.BoolToStr( AV28EnvironmentSecureProtocol), "", " ", 1, chkavEnvironmentsecureprotocol.Enabled, "true", "Is HTTPS?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(178, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,178);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEnvironmenthost_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEnvironmenthost_Internalname, "Host", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 183,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEnvironmenthost_Internalname, StringUtil.RTrim( AV23EnvironmentHost), StringUtil.RTrim( context.localUtil.Format( AV23EnvironmentHost, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,183);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEnvironmenthost_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavEnvironmenthost_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionMedium", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEnvironmentport_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEnvironmentport_Internalname, "Port", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 188,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEnvironmentport_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25EnvironmentPort), 5, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV25EnvironmentPort), "ZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,188);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEnvironmentport_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavEnvironmentport_Enabled, 1, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEnvironmentvirtualdirectory_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEnvironmentvirtualdirectory_Internalname, "Virtual Directory", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 193,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEnvironmentvirtualdirectory_Internalname, StringUtil.RTrim( AV29EnvironmentVirtualDirectory), StringUtil.RTrim( context.localUtil.Format( AV29EnvironmentVirtualDirectory, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,193);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEnvironmentvirtualdirectory_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavEnvironmentvirtualdirectory_Enabled, 1, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionMedium", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEnvironmentprogrampackage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEnvironmentprogrampackage_Internalname, "Package", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 198,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEnvironmentprogrampackage_Internalname, StringUtil.RTrim( AV27EnvironmentProgramPackage), StringUtil.RTrim( context.localUtil.Format( AV27EnvironmentProgramPackage, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,198);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEnvironmentprogrampackage_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavEnvironmentprogrampackage_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEnvironmentprogramextension_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEnvironmentprogramextension_Internalname, "Extension", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 203,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEnvironmentprogramextension_Internalname, StringUtil.RTrim( AV26EnvironmentProgramExtension), StringUtil.RTrim( context.localUtil.Format( AV26EnvironmentProgramExtension, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,203);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEnvironmentprogramextension_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavEnvironmentprogramextension_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionShort", "left", true, "HLP_GAMApplicationEntry.htm");
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 208,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", bttBtnenter_Caption, bttBtnenter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtnenter_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 210,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Fechar", bttBtncancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMApplicationEntry.htm");
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
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 214,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavAutoregisteranomymoususer_Internalname, StringUtil.BoolToStr( AV7AutoRegisterAnomymousUser), "", "", chkavAutoregisteranomymoususer.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(214, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,214);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1C2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Application", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1C0( ) ;
      }

      protected void WS1C2( )
      {
         START1C2( ) ;
         EVT1C2( ) ;
      }

      protected void EVT1C2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E111C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOGENERATEKEYGAMREMOTE'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoGenerateKeyGAMRemote' */
                              E121C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOREVOKEALLOW'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoRevokeAllow' */
                              E131C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: Enter */
                                    E141C2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E151C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CLOSE'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Close' */
                              E161C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E171C2 ();
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
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
      }

      protected void WE1C2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA1C2( )
      {
         if ( nDonePA == 0 )
         {
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
            cmbavMainmenu.Name = "vMAINMENU";
            cmbavMainmenu.WebTags = "";
            if ( cmbavMainmenu.ItemCount > 0 )
            {
               AV36MainMenu = (long)(NumberUtil.Val( cmbavMainmenu.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV36MainMenu), 12, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36MainMenu", StringUtil.LTrim( StringUtil.Str( (decimal)(AV36MainMenu), 12, 0)));
            }
            chkavAccessrequirespermission.Name = "vACCESSREQUIRESPERMISSION";
            chkavAccessrequirespermission.WebTags = "";
            chkavAccessrequirespermission.Caption = "Requires permissions?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAccessrequirespermission_Internalname, "TitleCaption", chkavAccessrequirespermission.Caption, true);
            chkavAccessrequirespermission.CheckedValue = "false";
            chkavClientaccessuniquebyuser.Name = "vCLIENTACCESSUNIQUEBYUSER";
            chkavClientaccessuniquebyuser.WebTags = "";
            chkavClientaccessuniquebyuser.Caption = "Single user access?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavClientaccessuniquebyuser_Internalname, "TitleCaption", chkavClientaccessuniquebyuser.Caption, true);
            chkavClientaccessuniquebyuser.CheckedValue = "false";
            chkavClientallowremoteauth.Name = "vCLIENTALLOWREMOTEAUTH";
            chkavClientallowremoteauth.WebTags = "";
            chkavClientallowremoteauth.Caption = "Allow remote authentication?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavClientallowremoteauth_Internalname, "TitleCaption", chkavClientallowremoteauth.Caption, true);
            chkavClientallowremoteauth.CheckedValue = "false";
            chkavClientallowgetuserroles.Name = "vCLIENTALLOWGETUSERROLES";
            chkavClientallowgetuserroles.WebTags = "";
            chkavClientallowgetuserroles.Caption = "Can get user roles?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavClientallowgetuserroles_Internalname, "TitleCaption", chkavClientallowgetuserroles.Caption, true);
            chkavClientallowgetuserroles.CheckedValue = "false";
            chkavClientallowgetuseradddata.Name = "vCLIENTALLOWGETUSERADDDATA";
            chkavClientallowgetuseradddata.WebTags = "";
            chkavClientallowgetuseradddata.Caption = "Can get user additional data?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavClientallowgetuseradddata_Internalname, "TitleCaption", chkavClientallowgetuseradddata.Caption, true);
            chkavClientallowgetuseradddata.CheckedValue = "false";
            chkavEnvironmentsecureprotocol.Name = "vENVIRONMENTSECUREPROTOCOL";
            chkavEnvironmentsecureprotocol.WebTags = "";
            chkavEnvironmentsecureprotocol.Caption = "Is HTTPS?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavEnvironmentsecureprotocol_Internalname, "TitleCaption", chkavEnvironmentsecureprotocol.Caption, true);
            chkavEnvironmentsecureprotocol.CheckedValue = "false";
            chkavAutoregisteranomymoususer.Name = "vAUTOREGISTERANOMYMOUSUSER";
            chkavAutoregisteranomymoususer.WebTags = "";
            chkavAutoregisteranomymoususer.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAutoregisteranomymoususer_Internalname, "TitleCaption", chkavAutoregisteranomymoususer.Caption, true);
            chkavAutoregisteranomymoususer.CheckedValue = "false";
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavGuid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void fix_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
         }
         if ( cmbavMainmenu.ItemCount > 0 )
         {
            AV36MainMenu = (long)(NumberUtil.Val( cmbavMainmenu.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV36MainMenu), 12, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36MainMenu", StringUtil.LTrim( StringUtil.Str( (decimal)(AV36MainMenu), 12, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavMainmenu.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV36MainMenu), 12, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavMainmenu_Internalname, "Values", cmbavMainmenu.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1C2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), true);
         edtavGuid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), true);
         edtavClientrevoked_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientrevoked_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientrevoked_Enabled), 5, 0)), true);
         edtavClientencryptionkey_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientencryptionkey_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientencryptionkey_Enabled), 5, 0)), true);
         edtavClientrepositoryguid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientrepositoryguid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientrepositoryguid_Enabled), 5, 0)), true);
      }

      protected void RF1C2( )
      {
         initialize_formulas( ) ;
         /* Execute user event: Refresh */
         E151C2 ();
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E171C2 ();
            WB1C0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1C2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV34Id), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void STRUP1C0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), true);
         edtavGuid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), true);
         edtavClientrevoked_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientrevoked_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientrevoked_Enabled), 5, 0)), true);
         edtavClientencryptionkey_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientencryptionkey_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientencryptionkey_Enabled), 5, 0)), true);
         edtavClientrepositoryguid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientrepositoryguid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientrepositoryguid_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E111C2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV32GUID = cgiGet( edtavGuid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32GUID", AV32GUID);
            AV39Name = cgiGet( edtavName_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39Name", AV39Name);
            AV22Dsc = cgiGet( edtavDsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Dsc", AV22Dsc);
            AV41Version = cgiGet( edtavVersion_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41Version", AV41Version);
            AV20Company = cgiGet( edtavCompany_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Company", AV20Company);
            AV21Copyright = cgiGet( edtavCopyright_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Copyright", AV21Copyright);
            cmbavMainmenu.CurrentValue = cgiGet( cmbavMainmenu_Internalname);
            AV36MainMenu = (long)(NumberUtil.Val( cgiGet( cmbavMainmenu_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36MainMenu", StringUtil.LTrim( StringUtil.Str( (decimal)(AV36MainMenu), 12, 0)));
            AV33HomeObject = cgiGet( edtavHomeobject_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33HomeObject", AV33HomeObject);
            AV44ClientLocalLogoutObject = cgiGet( edtavClientlocallogoutobject_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44ClientLocalLogoutObject", AV44ClientLocalLogoutObject);
            AV5AccessRequiresPermission = StringUtil.StrToBool( cgiGet( chkavAccessrequirespermission_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5AccessRequiresPermission", AV5AccessRequiresPermission);
            AV14ClientId = cgiGet( edtavClientid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ClientId", AV14ClientId);
            AV19ClientSecret = cgiGet( edtavClientsecret_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ClientSecret", AV19ClientSecret);
            AV8ClientAccessUniqueByUser = StringUtil.StrToBool( cgiGet( chkavClientaccessuniquebyuser_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClientAccessUniqueByUser", AV8ClientAccessUniqueByUser);
            if ( context.localUtil.VCDateTime( cgiGet( edtavClientrevoked_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Client Revoked"}), 1, "vCLIENTREVOKED");
               GX_FocusControl = edtavClientrevoked_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18ClientRevoked = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ClientRevoked", context.localUtil.TToC( AV18ClientRevoked, 10, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV18ClientRevoked = context.localUtil.CToT( cgiGet( edtavClientrevoked_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ClientRevoked", context.localUtil.TToC( AV18ClientRevoked, 10, 5, 0, 3, "/", ":", " "));
            }
            AV11ClientAllowRemoteAuth = StringUtil.StrToBool( cgiGet( chkavClientallowremoteauth_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ClientAllowRemoteAuth", AV11ClientAllowRemoteAuth);
            AV10ClientAllowGetUserRoles = StringUtil.StrToBool( cgiGet( chkavClientallowgetuserroles_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ClientAllowGetUserRoles", AV10ClientAllowGetUserRoles);
            AV9ClientAllowGetUserAddData = StringUtil.StrToBool( cgiGet( chkavClientallowgetuseradddata_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ClientAllowGetUserAddData", AV9ClientAllowGetUserAddData);
            AV16ClientLocalLoginURL = cgiGet( edtavClientlocalloginurl_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ClientLocalLoginURL", AV16ClientLocalLoginURL);
            AV12ClientCallbackURL = cgiGet( edtavClientcallbackurl_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12ClientCallbackURL", AV12ClientCallbackURL);
            AV15ClientImageURL = cgiGet( edtavClientimageurl_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ClientImageURL", AV15ClientImageURL);
            AV13ClientEncryptionKey = cgiGet( edtavClientencryptionkey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ClientEncryptionKey", AV13ClientEncryptionKey);
            AV42ClientRepositoryGUID = cgiGet( edtavClientrepositoryguid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42ClientRepositoryGUID", AV42ClientRepositoryGUID);
            AV24EnvironmentName = cgiGet( edtavEnvironmentname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24EnvironmentName", AV24EnvironmentName);
            AV28EnvironmentSecureProtocol = StringUtil.StrToBool( cgiGet( chkavEnvironmentsecureprotocol_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28EnvironmentSecureProtocol", AV28EnvironmentSecureProtocol);
            AV23EnvironmentHost = cgiGet( edtavEnvironmenthost_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23EnvironmentHost", AV23EnvironmentHost);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavEnvironmentport_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavEnvironmentport_Internalname), ",", ".") > Convert.ToDecimal( 99999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vENVIRONMENTPORT");
               GX_FocusControl = edtavEnvironmentport_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV25EnvironmentPort = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25EnvironmentPort", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25EnvironmentPort), 5, 0)));
            }
            else
            {
               AV25EnvironmentPort = (int)(context.localUtil.CToN( cgiGet( edtavEnvironmentport_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25EnvironmentPort", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25EnvironmentPort), 5, 0)));
            }
            AV29EnvironmentVirtualDirectory = cgiGet( edtavEnvironmentvirtualdirectory_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29EnvironmentVirtualDirectory", AV29EnvironmentVirtualDirectory);
            AV27EnvironmentProgramPackage = cgiGet( edtavEnvironmentprogrampackage_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27EnvironmentProgramPackage", AV27EnvironmentProgramPackage);
            AV26EnvironmentProgramExtension = cgiGet( edtavEnvironmentprogramextension_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26EnvironmentProgramExtension", AV26EnvironmentProgramExtension);
            AV7AutoRegisterAnomymousUser = StringUtil.StrToBool( cgiGet( chkavAutoregisteranomymoususer_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7AutoRegisterAnomymousUser", AV7AutoRegisterAnomymousUser);
            /* Read saved values. */
            Gxuitabspanel_tabs_Class = cgiGet( "GXUITABSPANEL_TABS_Class");
            Gxuitabspanel_tabs_Pagecount = (int)(context.localUtil.CToN( cgiGet( "GXUITABSPANEL_TABS_Pagecount"), ",", "."));
            Gxuitabspanel_tabs_Historymanagement = StringUtil.StrToBool( cgiGet( "GXUITABSPANEL_TABS_Historymanagement"));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E111C2 ();
         if (returnInSub) return;
      }

      protected void E111C2( )
      {
         /* Start Routine */
         chkavAutoregisteranomymoususer.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAutoregisteranomymoususer_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavAutoregisteranomymoususer.Visible), 5, 0)), true);
         AV40User = new SdtGAMUser(context).get();
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            AV6Application.load( AV34Id);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34Id), 12, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV34Id), "ZZZZZZZZZZZ9"), context));
            AV32GUID = AV6Application.gxTpr_Guid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32GUID", AV32GUID);
            AV39Name = AV6Application.gxTpr_Name;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39Name", AV39Name);
            AV22Dsc = AV6Application.gxTpr_Description;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Dsc", AV22Dsc);
            AV41Version = AV6Application.gxTpr_Version;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41Version", AV41Version);
            AV21Copyright = AV6Application.gxTpr_Copyright;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Copyright", AV21Copyright);
            AV20Company = AV6Application.gxTpr_Companyname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Company", AV20Company);
            AV54GXV2 = 1;
            AV53GXV1 = AV6Application.getmenus(AV38MenuFilter, out  AV31Errors);
            while ( AV54GXV2 <= AV53GXV1.Count )
            {
               AV37Menu = ((SdtGAMApplicationMenu)AV53GXV1.Item(AV54GXV2));
               cmbavMainmenu.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV37Menu.gxTpr_Id), 12, 0)), AV37Menu.gxTpr_Name, 0);
               AV54GXV2 = (int)(AV54GXV2+1);
            }
            AV36MainMenu = AV6Application.gxTpr_Mainmenuid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36MainMenu", StringUtil.LTrim( StringUtil.Str( (decimal)(AV36MainMenu), 12, 0)));
            AV5AccessRequiresPermission = AV6Application.gxTpr_Accessrequirespermission;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5AccessRequiresPermission", AV5AccessRequiresPermission);
            AV7AutoRegisterAnomymousUser = AV6Application.gxTpr_Clientautoregisteranomymoususer;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7AutoRegisterAnomymousUser", AV7AutoRegisterAnomymousUser);
            AV14ClientId = AV6Application.gxTpr_Clientid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ClientId", AV14ClientId);
            AV19ClientSecret = AV6Application.gxTpr_Clientsecret;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ClientSecret", AV19ClientSecret);
            AV8ClientAccessUniqueByUser = AV6Application.gxTpr_Clientaccessuniquebyuser;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClientAccessUniqueByUser", AV8ClientAccessUniqueByUser);
            AV18ClientRevoked = AV6Application.gxTpr_Clientrevoked;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ClientRevoked", context.localUtil.TToC( AV18ClientRevoked, 10, 5, 0, 3, "/", ":", " "));
            AV11ClientAllowRemoteAuth = AV6Application.gxTpr_Clientallowremoteauthentication;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ClientAllowRemoteAuth", AV11ClientAllowRemoteAuth);
            AV10ClientAllowGetUserRoles = AV6Application.gxTpr_Clientallowgetuserroles;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ClientAllowGetUserRoles", AV10ClientAllowGetUserRoles);
            AV9ClientAllowGetUserAddData = AV6Application.gxTpr_Clientallowgetuseradditionaldata;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ClientAllowGetUserAddData", AV9ClientAllowGetUserAddData);
            AV16ClientLocalLoginURL = AV6Application.gxTpr_Clientlocalloginurl;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ClientLocalLoginURL", AV16ClientLocalLoginURL);
            AV44ClientLocalLogoutObject = AV6Application.gxTpr_Logoutobject;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44ClientLocalLogoutObject", AV44ClientLocalLogoutObject);
            AV33HomeObject = AV6Application.gxTpr_Homeobject;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33HomeObject", AV33HomeObject);
            AV12ClientCallbackURL = AV6Application.gxTpr_Clientcallbackurl;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12ClientCallbackURL", AV12ClientCallbackURL);
            AV15ClientImageURL = AV6Application.gxTpr_Clientimageurl;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ClientImageURL", AV15ClientImageURL);
            AV13ClientEncryptionKey = AV6Application.gxTpr_Clientencryptionkey;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ClientEncryptionKey", AV13ClientEncryptionKey);
            AV42ClientRepositoryGUID = AV6Application.gxTpr_Clientrepositoryguid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42ClientRepositoryGUID", AV42ClientRepositoryGUID);
            AV24EnvironmentName = AV6Application.gxTpr_Environment.gxTpr_Name;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24EnvironmentName", AV24EnvironmentName);
            AV28EnvironmentSecureProtocol = AV6Application.gxTpr_Environment.gxTpr_Secureprotocol;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28EnvironmentSecureProtocol", AV28EnvironmentSecureProtocol);
            AV23EnvironmentHost = AV6Application.gxTpr_Environment.gxTpr_Host;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23EnvironmentHost", AV23EnvironmentHost);
            AV25EnvironmentPort = AV6Application.gxTpr_Environment.gxTpr_Port;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25EnvironmentPort", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25EnvironmentPort), 5, 0)));
            AV29EnvironmentVirtualDirectory = AV6Application.gxTpr_Environment.gxTpr_Virtualdirectory;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29EnvironmentVirtualDirectory", AV29EnvironmentVirtualDirectory);
            AV27EnvironmentProgramPackage = AV6Application.gxTpr_Environment.gxTpr_Programpackage;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27EnvironmentProgramPackage", AV27EnvironmentProgramPackage);
            AV26EnvironmentProgramExtension = AV6Application.gxTpr_Environment.gxTpr_Programextension;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26EnvironmentProgramExtension", AV26EnvironmentProgramExtension);
            if ( (DateTime.MinValue==AV6Application.gxTpr_Clientrevoked) )
            {
               bttBtnrevokeallow_Caption = "Revoke";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnrevokeallow_Internalname, "Caption", bttBtnrevokeallow_Caption, true);
            }
            else
            {
               bttBtnrevokeallow_Caption = "Authorize";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnrevokeallow_Internalname, "Caption", bttBtnrevokeallow_Caption, true);
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            edtavGuid_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), true);
            edtavName_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), true);
            edtavDsc_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDsc_Enabled), 5, 0)), true);
            edtavVersion_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVersion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVersion_Enabled), 5, 0)), true);
            edtavCopyright_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavCopyright_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavCopyright_Enabled), 5, 0)), true);
            edtavCompany_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavCompany_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavCompany_Enabled), 5, 0)), true);
            cmbavMainmenu.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavMainmenu_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavMainmenu.Enabled), 5, 0)), true);
            chkavAccessrequirespermission.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAccessrequirespermission_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavAccessrequirespermission.Enabled), 5, 0)), true);
            edtavClientid_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientid_Enabled), 5, 0)), true);
            edtavClientsecret_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientsecret_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientsecret_Enabled), 5, 0)), true);
            chkavClientaccessuniquebyuser.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavClientaccessuniquebyuser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavClientaccessuniquebyuser.Enabled), 5, 0)), true);
            edtavClientrevoked_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientrevoked_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientrevoked_Enabled), 5, 0)), true);
            chkavClientallowremoteauth.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavClientallowremoteauth_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavClientallowremoteauth.Enabled), 5, 0)), true);
            chkavClientallowgetuserroles.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavClientallowgetuserroles_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavClientallowgetuserroles.Enabled), 5, 0)), true);
            chkavClientallowgetuseradddata.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavClientallowgetuseradddata_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavClientallowgetuseradddata.Enabled), 5, 0)), true);
            edtavClientlocalloginurl_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientlocalloginurl_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientlocalloginurl_Enabled), 5, 0)), true);
            edtavClientcallbackurl_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientcallbackurl_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientcallbackurl_Enabled), 5, 0)), true);
            edtavClientimageurl_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientimageurl_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientimageurl_Enabled), 5, 0)), true);
            edtavClientencryptionkey_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientencryptionkey_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientencryptionkey_Enabled), 5, 0)), true);
            edtavClientrepositoryguid_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientrepositoryguid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientrepositoryguid_Enabled), 5, 0)), true);
            edtavEnvironmentname_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEnvironmentname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEnvironmentname_Enabled), 5, 0)), true);
            chkavEnvironmentsecureprotocol.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavEnvironmentsecureprotocol_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavEnvironmentsecureprotocol.Enabled), 5, 0)), true);
            edtavEnvironmenthost_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEnvironmenthost_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEnvironmenthost_Enabled), 5, 0)), true);
            edtavEnvironmentport_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEnvironmentport_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEnvironmentport_Enabled), 5, 0)), true);
            edtavEnvironmentvirtualdirectory_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEnvironmentvirtualdirectory_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEnvironmentvirtualdirectory_Enabled), 5, 0)), true);
            edtavEnvironmentprogrampackage_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEnvironmentprogrampackage_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEnvironmentprogrampackage_Enabled), 5, 0)), true);
            edtavEnvironmentprogramextension_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEnvironmentprogramextension_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEnvironmentprogramextension_Enabled), 5, 0)), true);
            edtavHomeobject_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHomeobject_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHomeobject_Enabled), 5, 0)), true);
            edtavClientlocallogoutobject_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientlocallogoutobject_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientlocallogoutobject_Enabled), 5, 0)), true);
            bttBtngeneratekeygamremote_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtngeneratekeygamremote_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtngeneratekeygamremote_Visible), 5, 0)), true);
            bttBtnenter_Caption = "Delete";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenter_Internalname, "Caption", bttBtnenter_Caption, true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtnenter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnenter_Visible), 5, 0)), true);
         }
         divTablemain_Width = 875;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Width", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Width), 9, 0)), true);
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
         chkavAutoregisteranomymoususer.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAutoregisteranomymoususer_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavAutoregisteranomymoususer.Visible), 5, 0)), true);
      }

      protected void E121C2( )
      {
         /* 'DoGenerateKeyGAMRemote' Routine */
         AV13ClientEncryptionKey = Crypto.GetEncryptionKey( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ClientEncryptionKey", AV13ClientEncryptionKey);
         /*  Sending Event outputs  */
      }

      protected void E131C2( )
      {
         /* 'DoRevokeAllow' Routine */
         AV6Application.load( AV34Id);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34Id), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV34Id), "ZZZZZZZZZZZ9"), context));
         if ( (DateTime.MinValue==AV6Application.gxTpr_Clientrevoked) )
         {
            AV35isOk = AV6Application.revokeclient(out  AV31Errors);
         }
         else
         {
            AV35isOk = AV6Application.authorizeclient(out  AV31Errors);
         }
         if ( AV35isOk )
         {
            if ( (DateTime.MinValue==AV6Application.gxTpr_Clientrevoked) )
            {
               bttBtnrevokeallow_Caption = "Revoke";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnrevokeallow_Internalname, "Caption", bttBtnrevokeallow_Caption, true);
            }
            else
            {
               bttBtnrevokeallow_Caption = "Authorize";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnrevokeallow_Internalname, "Caption", bttBtnrevokeallow_Caption, true);
            }
            pr_gam.commit( "GAMApplicationEntry");
            pr_default.commit( "GAMApplicationEntry");
            context.DoAjaxRefresh();
         }
         else
         {
            /* Execute user subroutine: 'ERRORS' */
            S122 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         if ( ! ( AV11ClientAllowRemoteAuth ) )
         {
            chkavClientallowgetuserroles.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavClientallowgetuserroles_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavClientallowgetuserroles.Visible), 5, 0)), true);
            divClientallowgetuserroles_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divClientallowgetuserroles_cell_Internalname, "Class", divClientallowgetuserroles_cell_Class, true);
         }
         else
         {
            chkavClientallowgetuserroles.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavClientallowgetuserroles_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavClientallowgetuserroles.Visible), 5, 0)), true);
            divClientallowgetuserroles_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divClientallowgetuserroles_cell_Internalname, "Class", divClientallowgetuserroles_cell_Class, true);
         }
         if ( ! ( AV11ClientAllowRemoteAuth ) )
         {
            chkavClientallowgetuseradddata.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavClientallowgetuseradddata_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavClientallowgetuseradddata.Visible), 5, 0)), true);
            divClientallowgetuseradddata_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divClientallowgetuseradddata_cell_Internalname, "Class", divClientallowgetuseradddata_cell_Class, true);
         }
         else
         {
            chkavClientallowgetuseradddata.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavClientallowgetuseradddata_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavClientallowgetuseradddata.Visible), 5, 0)), true);
            divClientallowgetuseradddata_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divClientallowgetuseradddata_cell_Internalname, "Class", divClientallowgetuseradddata_cell_Class, true);
         }
         if ( ! ( AV11ClientAllowRemoteAuth ) )
         {
            edtavClientlocalloginurl_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientlocalloginurl_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientlocalloginurl_Visible), 5, 0)), true);
            divClientlocalloginurl_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divClientlocalloginurl_cell_Internalname, "Class", divClientlocalloginurl_cell_Class, true);
         }
         else
         {
            edtavClientlocalloginurl_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientlocalloginurl_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientlocalloginurl_Visible), 5, 0)), true);
            divClientlocalloginurl_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divClientlocalloginurl_cell_Internalname, "Class", divClientlocalloginurl_cell_Class, true);
         }
         if ( ! ( AV11ClientAllowRemoteAuth ) )
         {
            edtavClientcallbackurl_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientcallbackurl_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientcallbackurl_Visible), 5, 0)), true);
            divClientcallbackurl_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divClientcallbackurl_cell_Internalname, "Class", divClientcallbackurl_cell_Class, true);
         }
         else
         {
            edtavClientcallbackurl_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientcallbackurl_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientcallbackurl_Visible), 5, 0)), true);
            divClientcallbackurl_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divClientcallbackurl_cell_Internalname, "Class", divClientcallbackurl_cell_Class, true);
         }
         if ( ! ( AV11ClientAllowRemoteAuth ) )
         {
            edtavClientimageurl_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientimageurl_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientimageurl_Visible), 5, 0)), true);
            divClientimageurl_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divClientimageurl_cell_Internalname, "Class", divClientimageurl_cell_Class, true);
         }
         else
         {
            edtavClientimageurl_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientimageurl_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientimageurl_Visible), 5, 0)), true);
            divClientimageurl_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divClientimageurl_cell_Internalname, "Class", divClientimageurl_cell_Class, true);
         }
         if ( ! ( AV11ClientAllowRemoteAuth ) )
         {
            edtavClientencryptionkey_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientencryptionkey_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientencryptionkey_Visible), 5, 0)), true);
            cellClientencryptionkey_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellClientencryptionkey_cell_Internalname, "Class", cellClientencryptionkey_cell_Class, true);
            divTextblockclientencryptionkey_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTextblockclientencryptionkey_cell_Internalname, "Class", divTextblockclientencryptionkey_cell_Class, true);
         }
         else
         {
            edtavClientencryptionkey_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientencryptionkey_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientencryptionkey_Visible), 5, 0)), true);
            cellClientencryptionkey_cell_Class = "MergeDataCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellClientencryptionkey_cell_Internalname, "Class", cellClientencryptionkey_cell_Class, true);
            divTextblockclientencryptionkey_cell_Class = "col-sm-3 MergeLabelCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTextblockclientencryptionkey_cell_Internalname, "Class", divTextblockclientencryptionkey_cell_Class, true);
         }
         if ( ! ( AV11ClientAllowRemoteAuth ) )
         {
            edtavClientrepositoryguid_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientrepositoryguid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientrepositoryguid_Visible), 5, 0)), true);
            divClientrepositoryguid_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divClientrepositoryguid_cell_Internalname, "Class", divClientrepositoryguid_cell_Class, true);
         }
         else
         {
            edtavClientrepositoryguid_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientrepositoryguid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientrepositoryguid_Visible), 5, 0)), true);
            divClientrepositoryguid_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divClientrepositoryguid_cell_Internalname, "Class", divClientrepositoryguid_cell_Class, true);
         }
         if ( ! ( AV11ClientAllowRemoteAuth ) )
         {
            bttBtngeneratekeygamremote_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtngeneratekeygamremote_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtngeneratekeygamremote_Visible), 5, 0)), true);
         }
         else
         {
            edtavClientrepositoryguid_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClientrepositoryguid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClientrepositoryguid_Visible), 5, 0)), true);
            bttBtngeneratekeygamremote_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtngeneratekeygamremote_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtngeneratekeygamremote_Visible), 5, 0)), true);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E141C2 ();
         if (returnInSub) return;
      }

      protected void E141C2( )
      {
         /* Enter Routine */
         AV6Application.load( AV34Id);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34Id), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV34Id), "ZZZZZZZZZZZ9"), context));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) )
         {
            AV6Application.gxTpr_Name = AV39Name;
            AV6Application.gxTpr_Description = AV22Dsc;
            AV6Application.gxTpr_Version = AV41Version;
            AV6Application.gxTpr_Copyright = AV21Copyright;
            AV6Application.gxTpr_Companyname = AV20Company;
            AV6Application.gxTpr_Mainmenuid = AV36MainMenu;
            AV6Application.gxTpr_Accessrequirespermission = AV5AccessRequiresPermission;
            AV6Application.gxTpr_Clientautoregisteranomymoususer = AV7AutoRegisterAnomymousUser;
            AV6Application.gxTpr_Clientid = AV14ClientId;
            AV6Application.gxTpr_Clientsecret = AV19ClientSecret;
            AV6Application.gxTpr_Clientaccessuniquebyuser = AV8ClientAccessUniqueByUser;
            AV6Application.gxTpr_Clientallowremoteauthentication = AV11ClientAllowRemoteAuth;
            AV6Application.gxTpr_Clientallowgetuserroles = AV10ClientAllowGetUserRoles;
            AV6Application.gxTpr_Clientallowgetuseradditionaldata = AV9ClientAllowGetUserAddData;
            AV6Application.gxTpr_Clientlocalloginurl = AV16ClientLocalLoginURL;
            AV6Application.gxTpr_Logoutobject = AV44ClientLocalLogoutObject;
            AV6Application.gxTpr_Homeobject = AV33HomeObject;
            AV6Application.gxTpr_Clientcallbackurl = AV12ClientCallbackURL;
            AV6Application.gxTpr_Clientimageurl = AV15ClientImageURL;
            AV6Application.gxTpr_Clientencryptionkey = AV13ClientEncryptionKey;
            AV6Application.gxTpr_Clientrepositoryguid = AV42ClientRepositoryGUID;
            AV6Application.gxTpr_Environment.gxTpr_Name = AV24EnvironmentName;
            AV6Application.gxTpr_Environment.gxTpr_Secureprotocol = AV28EnvironmentSecureProtocol;
            AV6Application.gxTpr_Environment.gxTpr_Host = AV23EnvironmentHost;
            AV6Application.gxTpr_Environment.gxTpr_Port = AV25EnvironmentPort;
            AV6Application.gxTpr_Environment.gxTpr_Virtualdirectory = AV29EnvironmentVirtualDirectory;
            AV6Application.gxTpr_Environment.gxTpr_Programpackage = AV27EnvironmentProgramPackage;
            AV6Application.gxTpr_Environment.gxTpr_Programextension = AV26EnvironmentProgramExtension;
            AV6Application.save();
         }
         else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            AV6Application.delete();
         }
         if ( AV6Application.success() )
         {
            pr_gam.commit( "GAMApplicationEntry");
            pr_default.commit( "GAMApplicationEntry");
            CallWebObject(formatLink("gamwwapplications.aspx") );
            context.wjLocDisableFrm = 1;
         }
         else
         {
            AV31Errors = AV6Application.geterrors();
            /* Execute user subroutine: 'ERRORS' */
            S122 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
      }

      protected void E151C2( )
      {
         /* Refresh Routine */
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            bttBtnrevokeallow_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnrevokeallow_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnrevokeallow_Visible), 5, 0)), true);
         }
         else
         {
            bttBtnrevokeallow_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnrevokeallow_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnrevokeallow_Visible), 5, 0)), true);
         }
         /*  Sending Event outputs  */
      }

      protected void E161C2( )
      {
         /* 'Close' Routine */
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void S122( )
      {
         /* 'ERRORS' Routine */
         if ( AV31Errors.Count > 0 )
         {
            AV55GXV3 = 1;
            while ( AV55GXV3 <= AV31Errors.Count )
            {
               AV30Error = ((SdtGAMError)AV31Errors.Item(AV55GXV3));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV30Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV30Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
               AV55GXV3 = (int)(AV55GXV3+1);
            }
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E171C2( )
      {
         /* Load Routine */
      }

      protected void wb_table2_152_1C2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedclientencryptionkey_Internalname, tblTablemergedclientencryptionkey_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellClientencryptionkey_cell_Internalname+"\"  class='"+cellClientencryptionkey_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientencryptionkey_Internalname, "Client Encryption Key", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 156,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientencryptionkey_Internalname, StringUtil.RTrim( AV13ClientEncryptionKey), StringUtil.RTrim( context.localUtil.Format( AV13ClientEncryptionKey, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,156);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientencryptionkey_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", edtavClientencryptionkey_Visible, edtavClientencryptionkey_Enabled, 1, "text", "", 32, "chr", 1, "row", 32, 0, 0, 0, 1, -1, 0, true, "GAMEncryptionKey", "left", true, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 158,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtngeneratekeygamremote_Internalname, "", "Generate Key GAMRemote", bttBtngeneratekeygamremote_Jsonclick, 5, "Generate Key GAMRemote", "", StyleString, ClassString, bttBtngeneratekeygamremote_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOGENERATEKEYGAMREMOTE\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMApplicationEntry.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_152_1C2e( true) ;
         }
         else
         {
            wb_table2_152_1C2e( false) ;
         }
      }

      protected void wb_table1_103_1C2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedclientrevoked_Internalname, tblTablemergedclientrevoked_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientrevoked_Internalname, "Client Revoked", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 107,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavClientrevoked_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavClientrevoked_Internalname, context.localUtil.TToC( AV18ClientRevoked, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV18ClientRevoked, "99/99/9999 99:99"), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',5,24,'por',false,0);"+";gx.evt.onblur(this,107);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientrevoked_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavClientrevoked_Enabled, 1, "text", "", 16, "chr", 1, "row", 16, 0, 0, 0, 1, -1, 0, true, "GAMDateTime", "right", false, "HLP_GAMApplicationEntry.htm");
            GxWebStd.gx_bitmap( context, edtavClientrevoked_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavClientrevoked_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_GAMApplicationEntry.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnrevokeallow_Internalname, "", bttBtnrevokeallow_Caption, bttBtnrevokeallow_Jsonclick, 5, "Revoke", "", StyleString, ClassString, bttBtnrevokeallow_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOREVOKEALLOW\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMApplicationEntry.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_103_1C2e( true) ;
         }
         else
         {
            wb_table1_103_1C2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         Gx_mode = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         AV34Id = Convert.ToInt64(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34Id), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV34Id), "ZZZZZZZZZZZ9"), context));
      }

      public override String getresponse( String sGXDynURL )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA1C2( ) ;
         WS1C2( ) ;
         WE1C2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019443716", true);
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
         context.AddJavascriptSource("gamapplicationentry.js", "?201892019443718", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblGeneral_title_Internalname = "GENERAL_TITLE";
         edtavId_Internalname = "vID";
         edtavGuid_Internalname = "vGUID";
         edtavName_Internalname = "vNAME";
         edtavDsc_Internalname = "vDSC";
         edtavVersion_Internalname = "vVERSION";
         edtavCompany_Internalname = "vCOMPANY";
         edtavCopyright_Internalname = "vCOPYRIGHT";
         cmbavMainmenu_Internalname = "vMAINMENU";
         edtavHomeobject_Internalname = "vHOMEOBJECT";
         edtavClientlocallogoutobject_Internalname = "vCLIENTLOCALLOGOUTOBJECT";
         chkavAccessrequirespermission_Internalname = "vACCESSREQUIRESPERMISSION";
         divUnnamedtable4_Internalname = "UNNAMEDTABLE4";
         lblClientapplicationdata_title_Internalname = "CLIENTAPPLICATIONDATA_TITLE";
         edtavClientid_Internalname = "vCLIENTID";
         edtavClientsecret_Internalname = "vCLIENTSECRET";
         chkavClientaccessuniquebyuser_Internalname = "vCLIENTACCESSUNIQUEBYUSER";
         lblTextblockclientrevoked_Internalname = "TEXTBLOCKCLIENTREVOKED";
         edtavClientrevoked_Internalname = "vCLIENTREVOKED";
         bttBtnrevokeallow_Internalname = "BTNREVOKEALLOW";
         tblTablemergedclientrevoked_Internalname = "TABLEMERGEDCLIENTREVOKED";
         divTablesplittedclientrevoked_Internalname = "TABLESPLITTEDCLIENTREVOKED";
         divUnnamedtable3_Internalname = "UNNAMEDTABLE3";
         lblRemoteauthentication_title_Internalname = "REMOTEAUTHENTICATION_TITLE";
         chkavClientallowremoteauth_Internalname = "vCLIENTALLOWREMOTEAUTH";
         chkavClientallowgetuserroles_Internalname = "vCLIENTALLOWGETUSERROLES";
         divClientallowgetuserroles_cell_Internalname = "CLIENTALLOWGETUSERROLES_CELL";
         chkavClientallowgetuseradddata_Internalname = "vCLIENTALLOWGETUSERADDDATA";
         divClientallowgetuseradddata_cell_Internalname = "CLIENTALLOWGETUSERADDDATA_CELL";
         edtavClientlocalloginurl_Internalname = "vCLIENTLOCALLOGINURL";
         divClientlocalloginurl_cell_Internalname = "CLIENTLOCALLOGINURL_CELL";
         edtavClientcallbackurl_Internalname = "vCLIENTCALLBACKURL";
         divClientcallbackurl_cell_Internalname = "CLIENTCALLBACKURL_CELL";
         edtavClientimageurl_Internalname = "vCLIENTIMAGEURL";
         divClientimageurl_cell_Internalname = "CLIENTIMAGEURL_CELL";
         lblTextblockclientencryptionkey_Internalname = "TEXTBLOCKCLIENTENCRYPTIONKEY";
         divTextblockclientencryptionkey_cell_Internalname = "TEXTBLOCKCLIENTENCRYPTIONKEY_CELL";
         edtavClientencryptionkey_Internalname = "vCLIENTENCRYPTIONKEY";
         cellClientencryptionkey_cell_Internalname = "CLIENTENCRYPTIONKEY_CELL";
         bttBtngeneratekeygamremote_Internalname = "BTNGENERATEKEYGAMREMOTE";
         tblTablemergedclientencryptionkey_Internalname = "TABLEMERGEDCLIENTENCRYPTIONKEY";
         divTablesplittedclientencryptionkey_Internalname = "TABLESPLITTEDCLIENTENCRYPTIONKEY";
         edtavClientrepositoryguid_Internalname = "vCLIENTREPOSITORYGUID";
         divClientrepositoryguid_cell_Internalname = "CLIENTREPOSITORYGUID_CELL";
         divUnnamedtable2_Internalname = "UNNAMEDTABLE2";
         lblEnvironmentsettings_title_Internalname = "ENVIRONMENTSETTINGS_TITLE";
         edtavEnvironmentname_Internalname = "vENVIRONMENTNAME";
         chkavEnvironmentsecureprotocol_Internalname = "vENVIRONMENTSECUREPROTOCOL";
         edtavEnvironmenthost_Internalname = "vENVIRONMENTHOST";
         edtavEnvironmentport_Internalname = "vENVIRONMENTPORT";
         edtavEnvironmentvirtualdirectory_Internalname = "vENVIRONMENTVIRTUALDIRECTORY";
         edtavEnvironmentprogrampackage_Internalname = "vENVIRONMENTPROGRAMPACKAGE";
         edtavEnvironmentprogramextension_Internalname = "vENVIRONMENTPROGRAMEXTENSION";
         divUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         Gxuitabspanel_tabs_Internalname = "GXUITABSPANEL_TABS";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         chkavAutoregisteranomymoususer_Internalname = "vAUTOREGISTERANOMYMOUSUSER";
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
         bttBtnrevokeallow_Visible = 1;
         edtavClientrevoked_Jsonclick = "";
         bttBtngeneratekeygamremote_Visible = 1;
         edtavClientencryptionkey_Jsonclick = "";
         cellClientencryptionkey_cell_Class = "";
         edtavClientencryptionkey_Visible = 1;
         edtavClientencryptionkey_Enabled = 1;
         edtavClientrevoked_Enabled = 1;
         bttBtnrevokeallow_Caption = "Revoke";
         chkavAutoregisteranomymoususer.Caption = "";
         chkavEnvironmentsecureprotocol.Caption = " ";
         chkavClientallowgetuseradddata.Caption = " ";
         chkavClientallowgetuserroles.Caption = " ";
         chkavClientallowremoteauth.Caption = " ";
         chkavClientaccessuniquebyuser.Caption = " ";
         chkavAccessrequirespermission.Caption = " ";
         chkavAutoregisteranomymoususer.Visible = 1;
         bttBtnenter_Caption = "Confirmar";
         bttBtnenter_Visible = 1;
         edtavEnvironmentprogramextension_Jsonclick = "";
         edtavEnvironmentprogramextension_Enabled = 1;
         edtavEnvironmentprogrampackage_Jsonclick = "";
         edtavEnvironmentprogrampackage_Enabled = 1;
         edtavEnvironmentvirtualdirectory_Jsonclick = "";
         edtavEnvironmentvirtualdirectory_Enabled = 1;
         edtavEnvironmentport_Jsonclick = "";
         edtavEnvironmentport_Enabled = 1;
         edtavEnvironmenthost_Jsonclick = "";
         edtavEnvironmenthost_Enabled = 1;
         chkavEnvironmentsecureprotocol.Enabled = 1;
         edtavEnvironmentname_Jsonclick = "";
         edtavEnvironmentname_Enabled = 1;
         edtavClientrepositoryguid_Jsonclick = "";
         edtavClientrepositoryguid_Enabled = 1;
         edtavClientrepositoryguid_Visible = 1;
         divClientrepositoryguid_cell_Class = "col-xs-12";
         divTextblockclientencryptionkey_cell_Class = "col-xs-12 col-sm-3";
         edtavClientimageurl_Jsonclick = "";
         edtavClientimageurl_Enabled = 1;
         edtavClientimageurl_Visible = 1;
         divClientimageurl_cell_Class = "col-xs-12";
         edtavClientcallbackurl_Jsonclick = "";
         edtavClientcallbackurl_Enabled = 1;
         edtavClientcallbackurl_Visible = 1;
         divClientcallbackurl_cell_Class = "col-xs-12";
         edtavClientlocalloginurl_Jsonclick = "";
         edtavClientlocalloginurl_Enabled = 1;
         edtavClientlocalloginurl_Visible = 1;
         divClientlocalloginurl_cell_Class = "col-xs-12";
         chkavClientallowgetuseradddata.Enabled = 1;
         chkavClientallowgetuseradddata.Visible = 1;
         divClientallowgetuseradddata_cell_Class = "col-xs-12";
         chkavClientallowgetuserroles.Enabled = 1;
         chkavClientallowgetuserroles.Visible = 1;
         divClientallowgetuserroles_cell_Class = "col-xs-12";
         chkavClientallowremoteauth.Enabled = 1;
         chkavClientaccessuniquebyuser.Enabled = 1;
         edtavClientsecret_Jsonclick = "";
         edtavClientsecret_Enabled = 1;
         edtavClientid_Jsonclick = "";
         edtavClientid_Enabled = 1;
         chkavAccessrequirespermission.Enabled = 1;
         edtavClientlocallogoutobject_Jsonclick = "";
         edtavClientlocallogoutobject_Enabled = 1;
         edtavHomeobject_Jsonclick = "";
         edtavHomeobject_Enabled = 1;
         cmbavMainmenu_Jsonclick = "";
         cmbavMainmenu.Enabled = 1;
         edtavCopyright_Jsonclick = "";
         edtavCopyright_Enabled = 1;
         edtavCompany_Jsonclick = "";
         edtavCompany_Enabled = 1;
         edtavVersion_Jsonclick = "";
         edtavVersion_Enabled = 1;
         edtavDsc_Jsonclick = "";
         edtavDsc_Enabled = 1;
         edtavName_Jsonclick = "";
         edtavName_Enabled = 1;
         edtavGuid_Jsonclick = "";
         edtavGuid_Enabled = 1;
         edtavId_Jsonclick = "";
         edtavId_Enabled = 0;
         divTablemain_Width = 0;
         Gxuitabspanel_tabs_Historymanagement = Convert.ToBoolean( 0);
         Gxuitabspanel_tabs_Pagecount = 4;
         Gxuitabspanel_tabs_Class = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Application";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV34Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{ctrl:'BTNREVOKEALLOW',prop:'Visible'}]}");
         setEventMetadata("'DOGENERATEKEYGAMREMOTE'","{handler:'E121C2',iparms:[],oparms:[{av:'AV13ClientEncryptionKey',fld:'vCLIENTENCRYPTIONKEY',pic:'',nv:''}]}");
         setEventMetadata("'DOREVOKEALLOW'","{handler:'E131C2',iparms:[{av:'AV34Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{ctrl:'BTNREVOKEALLOW',prop:'Caption'}]}");
         setEventMetadata("ENTER","{handler:'E141C2',iparms:[{av:'AV34Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV39Name',fld:'vNAME',pic:'',nv:''},{av:'AV22Dsc',fld:'vDSC',pic:'',nv:''},{av:'AV41Version',fld:'vVERSION',pic:'',nv:''},{av:'AV21Copyright',fld:'vCOPYRIGHT',pic:'',nv:''},{av:'AV20Company',fld:'vCOMPANY',pic:'',nv:''},{av:'cmbavMainmenu'},{av:'AV36MainMenu',fld:'vMAINMENU',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV5AccessRequiresPermission',fld:'vACCESSREQUIRESPERMISSION',pic:'',nv:false},{av:'AV7AutoRegisterAnomymousUser',fld:'vAUTOREGISTERANOMYMOUSUSER',pic:'',nv:false},{av:'AV14ClientId',fld:'vCLIENTID',pic:'',nv:''},{av:'AV19ClientSecret',fld:'vCLIENTSECRET',pic:'',nv:''},{av:'AV8ClientAccessUniqueByUser',fld:'vCLIENTACCESSUNIQUEBYUSER',pic:'',nv:false},{av:'AV11ClientAllowRemoteAuth',fld:'vCLIENTALLOWREMOTEAUTH',pic:'',nv:false},{av:'AV10ClientAllowGetUserRoles',fld:'vCLIENTALLOWGETUSERROLES',pic:'',nv:false},{av:'AV9ClientAllowGetUserAddData',fld:'vCLIENTALLOWGETUSERADDDATA',pic:'',nv:false},{av:'AV16ClientLocalLoginURL',fld:'vCLIENTLOCALLOGINURL',pic:'',nv:''},{av:'AV44ClientLocalLogoutObject',fld:'vCLIENTLOCALLOGOUTOBJECT',pic:'',nv:''},{av:'AV33HomeObject',fld:'vHOMEOBJECT',pic:'',nv:''},{av:'AV12ClientCallbackURL',fld:'vCLIENTCALLBACKURL',pic:'',nv:''},{av:'AV15ClientImageURL',fld:'vCLIENTIMAGEURL',pic:'',nv:''},{av:'AV13ClientEncryptionKey',fld:'vCLIENTENCRYPTIONKEY',pic:'',nv:''},{av:'AV42ClientRepositoryGUID',fld:'vCLIENTREPOSITORYGUID',pic:'',nv:''},{av:'AV24EnvironmentName',fld:'vENVIRONMENTNAME',pic:'',nv:''},{av:'AV28EnvironmentSecureProtocol',fld:'vENVIRONMENTSECUREPROTOCOL',pic:'',nv:false},{av:'AV23EnvironmentHost',fld:'vENVIRONMENTHOST',pic:'',nv:''},{av:'AV25EnvironmentPort',fld:'vENVIRONMENTPORT',pic:'ZZZZ9',nv:0},{av:'AV29EnvironmentVirtualDirectory',fld:'vENVIRONMENTVIRTUALDIRECTORY',pic:'',nv:''},{av:'AV27EnvironmentProgramPackage',fld:'vENVIRONMENTPROGRAMPACKAGE',pic:'',nv:''},{av:'AV26EnvironmentProgramExtension',fld:'vENVIRONMENTPROGRAMEXTENSION',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("'CLOSE'","{handler:'E161C2',iparms:[],oparms:[]}");
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
      }

      public override void initialize( )
      {
         wcpOGx_mode = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         lblGeneral_title_Jsonclick = "";
         TempTags = "";
         AV32GUID = "";
         AV39Name = "";
         AV22Dsc = "";
         AV41Version = "";
         AV20Company = "";
         AV21Copyright = "";
         AV33HomeObject = "";
         AV44ClientLocalLogoutObject = "";
         lblClientapplicationdata_title_Jsonclick = "";
         AV14ClientId = "";
         AV19ClientSecret = "";
         lblTextblockclientrevoked_Jsonclick = "";
         lblRemoteauthentication_title_Jsonclick = "";
         AV16ClientLocalLoginURL = "";
         AV12ClientCallbackURL = "";
         AV15ClientImageURL = "";
         lblTextblockclientencryptionkey_Jsonclick = "";
         AV42ClientRepositoryGUID = "";
         lblEnvironmentsettings_title_Jsonclick = "";
         AV24EnvironmentName = "";
         AV23EnvironmentHost = "";
         AV29EnvironmentVirtualDirectory = "";
         AV27EnvironmentProgramPackage = "";
         AV26EnvironmentProgramExtension = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV18ClientRevoked = (DateTime)(DateTime.MinValue);
         AV13ClientEncryptionKey = "";
         AV40User = new SdtGAMUser(context);
         AV6Application = new SdtGAMApplication(context);
         AV53GXV1 = new GXExternalCollection<SdtGAMApplicationMenu>( context, "SdtGAMApplicationMenu", "GeneXus.Programs");
         AV38MenuFilter = new SdtGAMApplicationMenuFilter(context);
         AV31Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV37Menu = new SdtGAMApplicationMenu(context);
         AV30Error = new SdtGAMError(context);
         sStyleString = "";
         bttBtngeneratekeygamremote_Jsonclick = "";
         bttBtnrevokeallow_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamapplicationentry__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamapplicationentry__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         edtavGuid_Enabled = 0;
         edtavClientrevoked_Enabled = 0;
         edtavClientencryptionkey_Enabled = 0;
         edtavClientrepositoryguid_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int Gxuitabspanel_tabs_Pagecount ;
      private int divTablemain_Width ;
      private int edtavId_Enabled ;
      private int edtavGuid_Enabled ;
      private int edtavName_Enabled ;
      private int edtavDsc_Enabled ;
      private int edtavVersion_Enabled ;
      private int edtavCompany_Enabled ;
      private int edtavCopyright_Enabled ;
      private int edtavHomeobject_Enabled ;
      private int edtavClientlocallogoutobject_Enabled ;
      private int edtavClientid_Enabled ;
      private int edtavClientsecret_Enabled ;
      private int edtavClientlocalloginurl_Visible ;
      private int edtavClientlocalloginurl_Enabled ;
      private int edtavClientcallbackurl_Visible ;
      private int edtavClientcallbackurl_Enabled ;
      private int edtavClientimageurl_Visible ;
      private int edtavClientimageurl_Enabled ;
      private int edtavClientrepositoryguid_Visible ;
      private int edtavClientrepositoryguid_Enabled ;
      private int edtavEnvironmentname_Enabled ;
      private int edtavEnvironmenthost_Enabled ;
      private int AV25EnvironmentPort ;
      private int edtavEnvironmentport_Enabled ;
      private int edtavEnvironmentvirtualdirectory_Enabled ;
      private int edtavEnvironmentprogrampackage_Enabled ;
      private int edtavEnvironmentprogramextension_Enabled ;
      private int bttBtnenter_Visible ;
      private int edtavClientrevoked_Enabled ;
      private int edtavClientencryptionkey_Enabled ;
      private int AV54GXV2 ;
      private int bttBtngeneratekeygamremote_Visible ;
      private int edtavClientencryptionkey_Visible ;
      private int bttBtnrevokeallow_Visible ;
      private int AV55GXV3 ;
      private int idxLst ;
      private long AV34Id ;
      private long wcpOAV34Id ;
      private long AV36MainMenu ;
      private String Gx_mode ;
      private String wcpOGx_mode ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String Gxuitabspanel_tabs_Class ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divTablecontent_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblGeneral_title_Internalname ;
      private String lblGeneral_title_Jsonclick ;
      private String divUnnamedtable4_Internalname ;
      private String edtavId_Internalname ;
      private String edtavId_Jsonclick ;
      private String edtavGuid_Internalname ;
      private String TempTags ;
      private String AV32GUID ;
      private String edtavGuid_Jsonclick ;
      private String edtavName_Internalname ;
      private String AV39Name ;
      private String edtavName_Jsonclick ;
      private String edtavDsc_Internalname ;
      private String AV22Dsc ;
      private String edtavDsc_Jsonclick ;
      private String edtavVersion_Internalname ;
      private String AV41Version ;
      private String edtavVersion_Jsonclick ;
      private String edtavCompany_Internalname ;
      private String AV20Company ;
      private String edtavCompany_Jsonclick ;
      private String edtavCopyright_Internalname ;
      private String AV21Copyright ;
      private String edtavCopyright_Jsonclick ;
      private String cmbavMainmenu_Internalname ;
      private String cmbavMainmenu_Jsonclick ;
      private String edtavHomeobject_Internalname ;
      private String edtavHomeobject_Jsonclick ;
      private String edtavClientlocallogoutobject_Internalname ;
      private String edtavClientlocallogoutobject_Jsonclick ;
      private String chkavAccessrequirespermission_Internalname ;
      private String lblClientapplicationdata_title_Internalname ;
      private String lblClientapplicationdata_title_Jsonclick ;
      private String divUnnamedtable3_Internalname ;
      private String edtavClientid_Internalname ;
      private String AV14ClientId ;
      private String edtavClientid_Jsonclick ;
      private String edtavClientsecret_Internalname ;
      private String AV19ClientSecret ;
      private String edtavClientsecret_Jsonclick ;
      private String chkavClientaccessuniquebyuser_Internalname ;
      private String divTablesplittedclientrevoked_Internalname ;
      private String lblTextblockclientrevoked_Internalname ;
      private String lblTextblockclientrevoked_Jsonclick ;
      private String lblRemoteauthentication_title_Internalname ;
      private String lblRemoteauthentication_title_Jsonclick ;
      private String divUnnamedtable2_Internalname ;
      private String chkavClientallowremoteauth_Internalname ;
      private String divClientallowgetuserroles_cell_Internalname ;
      private String divClientallowgetuserroles_cell_Class ;
      private String chkavClientallowgetuserroles_Internalname ;
      private String divClientallowgetuseradddata_cell_Internalname ;
      private String divClientallowgetuseradddata_cell_Class ;
      private String chkavClientallowgetuseradddata_Internalname ;
      private String divClientlocalloginurl_cell_Internalname ;
      private String divClientlocalloginurl_cell_Class ;
      private String edtavClientlocalloginurl_Internalname ;
      private String edtavClientlocalloginurl_Jsonclick ;
      private String divClientcallbackurl_cell_Internalname ;
      private String divClientcallbackurl_cell_Class ;
      private String edtavClientcallbackurl_Internalname ;
      private String edtavClientcallbackurl_Jsonclick ;
      private String divClientimageurl_cell_Internalname ;
      private String divClientimageurl_cell_Class ;
      private String edtavClientimageurl_Internalname ;
      private String edtavClientimageurl_Jsonclick ;
      private String divTablesplittedclientencryptionkey_Internalname ;
      private String divTextblockclientencryptionkey_cell_Internalname ;
      private String divTextblockclientencryptionkey_cell_Class ;
      private String lblTextblockclientencryptionkey_Internalname ;
      private String lblTextblockclientencryptionkey_Jsonclick ;
      private String divClientrepositoryguid_cell_Internalname ;
      private String divClientrepositoryguid_cell_Class ;
      private String edtavClientrepositoryguid_Internalname ;
      private String AV42ClientRepositoryGUID ;
      private String edtavClientrepositoryguid_Jsonclick ;
      private String lblEnvironmentsettings_title_Internalname ;
      private String lblEnvironmentsettings_title_Jsonclick ;
      private String divUnnamedtable1_Internalname ;
      private String edtavEnvironmentname_Internalname ;
      private String AV24EnvironmentName ;
      private String edtavEnvironmentname_Jsonclick ;
      private String chkavEnvironmentsecureprotocol_Internalname ;
      private String edtavEnvironmenthost_Internalname ;
      private String AV23EnvironmentHost ;
      private String edtavEnvironmenthost_Jsonclick ;
      private String edtavEnvironmentport_Internalname ;
      private String edtavEnvironmentport_Jsonclick ;
      private String edtavEnvironmentvirtualdirectory_Internalname ;
      private String AV29EnvironmentVirtualDirectory ;
      private String edtavEnvironmentvirtualdirectory_Jsonclick ;
      private String edtavEnvironmentprogrampackage_Internalname ;
      private String AV27EnvironmentProgramPackage ;
      private String edtavEnvironmentprogrampackage_Jsonclick ;
      private String edtavEnvironmentprogramextension_Internalname ;
      private String AV26EnvironmentProgramExtension ;
      private String edtavEnvironmentprogramextension_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Caption ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String chkavAutoregisteranomymoususer_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavClientrevoked_Internalname ;
      private String edtavClientencryptionkey_Internalname ;
      private String AV13ClientEncryptionKey ;
      private String bttBtnrevokeallow_Caption ;
      private String bttBtnrevokeallow_Internalname ;
      private String bttBtngeneratekeygamremote_Internalname ;
      private String cellClientencryptionkey_cell_Class ;
      private String cellClientencryptionkey_cell_Internalname ;
      private String sStyleString ;
      private String tblTablemergedclientencryptionkey_Internalname ;
      private String edtavClientencryptionkey_Jsonclick ;
      private String bttBtngeneratekeygamremote_Jsonclick ;
      private String tblTablemergedclientrevoked_Internalname ;
      private String edtavClientrevoked_Jsonclick ;
      private String bttBtnrevokeallow_Jsonclick ;
      private String Gxuitabspanel_tabs_Internalname ;
      private DateTime AV18ClientRevoked ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Gxuitabspanel_tabs_Historymanagement ;
      private bool wbLoad ;
      private bool AV5AccessRequiresPermission ;
      private bool AV8ClientAccessUniqueByUser ;
      private bool AV11ClientAllowRemoteAuth ;
      private bool AV10ClientAllowGetUserRoles ;
      private bool AV9ClientAllowGetUserAddData ;
      private bool AV28EnvironmentSecureProtocol ;
      private bool AV7AutoRegisterAnomymousUser ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV35isOk ;
      private String AV33HomeObject ;
      private String AV44ClientLocalLogoutObject ;
      private String AV16ClientLocalLoginURL ;
      private String AV12ClientCallbackURL ;
      private String AV15ClientImageURL ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavMainmenu ;
      private GXCheckbox chkavAccessrequirespermission ;
      private GXCheckbox chkavClientaccessuniquebyuser ;
      private GXCheckbox chkavClientallowremoteauth ;
      private GXCheckbox chkavClientallowgetuserroles ;
      private GXCheckbox chkavClientallowgetuseradddata ;
      private GXCheckbox chkavEnvironmentsecureprotocol ;
      private GXCheckbox chkavAutoregisteranomymoususer ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMError> AV31Errors ;
      private GXExternalCollection<SdtGAMApplicationMenu> AV53GXV1 ;
      private GXWebForm Form ;
      private SdtGAMApplication AV6Application ;
      private SdtGAMError AV30Error ;
      private SdtGAMApplicationMenu AV37Menu ;
      private SdtGAMApplicationMenuFilter AV38MenuFilter ;
      private SdtGAMUser AV40User ;
   }

   public class gamapplicationentry__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamapplicationentry__default : DataStoreHelperBase, IDataStoreHelper
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

}

}
