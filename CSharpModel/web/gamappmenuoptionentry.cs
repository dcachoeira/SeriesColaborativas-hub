/*
               File: GAMAppMenuOptionEntry
        Description: GAM App Menu Option Entry
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:45:49.54
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
   public class gamappmenuoptionentry : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamappmenuoptionentry( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamappmenuoptionentry( IGxContext context )
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
                           long aP1_ApplicationId ,
                           long aP2_MenuId ,
                           long aP3_Id )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV10ApplicationId = aP1_ApplicationId;
         this.AV22MenuId = aP2_MenuId;
         this.AV18Id = aP3_Id;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavType = new GXCombobox();
         cmbavMenusid = new GXCombobox();
         cmbavRelresid = new GXCombobox();
         cmbavLink = new GXCombobox();
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
                  AV10ApplicationId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ApplicationId), 12, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ApplicationId), "ZZZZZZZZZZZ9"), context));
                  AV22MenuId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22MenuId), 12, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMENUID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22MenuId), "ZZZZZZZZZZZ9"), context));
                  AV18Id = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Id), 12, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18Id), "ZZZZZZZZZZZ9"), context));
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
         PA1S2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1S2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019454978", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamappmenuoptionentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV10ApplicationId) + "," + UrlEncode("" +AV22MenuId) + "," + UrlEncode("" +AV18Id)+"\">") ;
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
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "vAPPLICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10ApplicationId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ApplicationId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMENUID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22MenuId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vMENUID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22MenuId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18Id), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18Id), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_boolean_hidden_field( context, "vISOK", AV6isOK);
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
            WE1S2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1S2( ) ;
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
         return formatLink("gamappmenuoptionentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV10ApplicationId) + "," + UrlEncode("" +AV22MenuId) + "," + UrlEncode("" +AV18Id) ;
      }

      public override String GetPgmname( )
      {
         return "GAMAppMenuOptionEntry" ;
      }

      public override String GetPgmdesc( )
      {
         return "GAM App Menu Option Entry" ;
      }

      protected void WB1S0( )
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-lg-6", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGamapplication_name_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGamapplication_name_Internalname, "Application", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavGamapplication_name_Internalname, StringUtil.RTrim( AV5GAMApplication.gxTpr_Name), "", "", 0, 1, edtavGamapplication_name_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "254", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_GAMAppMenuOptionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavApplicationmenu_name_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavApplicationmenu_name_Internalname, "Menu", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavApplicationmenu_name_Internalname, StringUtil.RTrim( AV11ApplicationMenu.gxTpr_Name), "", "", 0, 1, edtavApplicationmenu_name_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "254", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_GAMAppMenuOptionEntry.htm");
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
            GxWebStd.gx_label_element( context, edtavGuid_Internalname, "GUID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGuid_Internalname, StringUtil.RTrim( AV17GUID), StringUtil.RTrim( context.localUtil.Format( AV17GUID, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGuid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGuid_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GAMAppMenuOptionEntry.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavName_Internalname, StringUtil.RTrim( AV25Name), StringUtil.RTrim( context.localUtil.Format( AV25Name, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavName_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMAppMenuOptionEntry.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDsc_Internalname, StringUtil.RTrim( AV13Dsc), StringUtil.RTrim( context.localUtil.Format( AV13Dsc, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavDsc_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMAppMenuOptionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavType_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavType_Internalname, "Type", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavType, cmbavType_Internalname, StringUtil.RTrim( AV37Type), 1, cmbavType_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVTYPE.CLICK."+"'", "char", "", 1, cmbavType.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,50);\"", "", true, "HLP_GAMAppMenuOptionEntry.htm");
            cmbavType.CurrentValue = StringUtil.RTrim( AV37Type);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavType_Internalname, "Values", (String)(cmbavType.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMenusid_cell_Internalname, 1, 0, "px", 0, "px", divMenusid_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", cmbavMenusid.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavMenusid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavMenusid_Internalname, "SubMenu", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavMenusid, cmbavMenusid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV24MenusId), 12, 0)), 1, cmbavMenusid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavMenusid.Visible, cmbavMenusid.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,55);\"", "", true, "HLP_GAMAppMenuOptionEntry.htm");
            cmbavMenusid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24MenusId), 12, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavMenusid_Internalname, "Values", (String)(cmbavMenusid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRelresid_cell_Internalname, 1, 0, "px", 0, "px", divRelresid_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", cmbavRelresid.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavRelresid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavRelresid_Internalname, "Permission", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavRelresid, cmbavRelresid_Internalname, StringUtil.RTrim( AV32RelResId), 1, cmbavRelresid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", cmbavRelresid.Visible, cmbavRelresid.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,60);\"", "", true, "HLP_GAMAppMenuOptionEntry.htm");
            cmbavRelresid.CurrentValue = StringUtil.RTrim( AV32RelResId);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRelresid_Internalname, "Values", (String)(cmbavRelresid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavResource_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavResource_Internalname, "Resource", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavResource_Internalname, AV34Resource, StringUtil.RTrim( context.localUtil.Format( AV34Resource, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavResource_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavResource_Enabled, 1, "text", "", 0, "px", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMAppMenuOptionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavResourceparameters_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavResourceparameters_Internalname, "Resource Parameters", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavResourceparameters_Internalname, AV35ResourceParameters, StringUtil.RTrim( context.localUtil.Format( AV35ResourceParameters, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavResourceparameters_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavResourceparameters_Enabled, 1, "text", "", 0, "px", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMAppMenuOptionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavIconclass_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavIconclass_Internalname, "Icon Class", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavIconclass_Internalname, AV43IconClass, StringUtil.RTrim( context.localUtil.Format( AV43IconClass, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,75);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavIconclass_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavIconclass_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GAMAppMenuOptionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavLink_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavLink_Internalname, "Link Target", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavLink, cmbavLink_Internalname, StringUtil.RTrim( AV44Link), 1, cmbavLink_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavLink.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,80);\"", "", true, "HLP_GAMAppMenuOptionEntry.htm");
            cmbavLink.CurrentValue = StringUtil.RTrim( AV44Link);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavLink_Internalname, "Values", (String)(cmbavLink.ToJavascriptSource()), true);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", bttBtnenter_Caption, bttBtnenter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtnenter_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMAppMenuOptionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Fechar", bttBtncancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMAppMenuOptionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1S2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "GAM App Menu Option Entry", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1S0( ) ;
      }

      protected void WS1S2( )
      {
         START1S2( ) ;
         EVT1S2( ) ;
      }

      protected void EVT1S2( )
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
                              E111S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VTYPE.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E121S2 ();
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
                                    E131S2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VRELRESID.ISVALID") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E141S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E151S2 ();
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

      protected void WE1S2( )
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

      protected void PA1S2( )
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
            cmbavType.Name = "vTYPE";
            cmbavType.WebTags = "";
            cmbavType.addItem("S", "Simple", 0);
            cmbavType.addItem("M", "Menu", 0);
            if ( cmbavType.ItemCount > 0 )
            {
               AV37Type = cmbavType.getValidValue(AV37Type);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37Type", AV37Type);
            }
            cmbavMenusid.Name = "vMENUSID";
            cmbavMenusid.WebTags = "";
            if ( cmbavMenusid.ItemCount > 0 )
            {
               AV24MenusId = (long)(NumberUtil.Val( cmbavMenusid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV24MenusId), 12, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24MenusId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24MenusId), 12, 0)));
            }
            cmbavRelresid.Name = "vRELRESID";
            cmbavRelresid.WebTags = "";
            if ( cmbavRelresid.ItemCount > 0 )
            {
               AV32RelResId = cmbavRelresid.getValidValue(AV32RelResId);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32RelResId", AV32RelResId);
            }
            cmbavLink.Name = "vLINK";
            cmbavLink.WebTags = "";
            cmbavLink.addItem("", "", 0);
            cmbavLink.addItem("_blank", "Blank", 0);
            if ( cmbavLink.ItemCount > 0 )
            {
               AV44Link = cmbavLink.getValidValue(AV44Link);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44Link", AV44Link);
            }
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavGamapplication_name_Internalname;
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
         if ( cmbavType.ItemCount > 0 )
         {
            AV37Type = cmbavType.getValidValue(AV37Type);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37Type", AV37Type);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavType.CurrentValue = StringUtil.RTrim( AV37Type);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavType_Internalname, "Values", cmbavType.ToJavascriptSource(), true);
         }
         if ( cmbavMenusid.ItemCount > 0 )
         {
            AV24MenusId = (long)(NumberUtil.Val( cmbavMenusid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV24MenusId), 12, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24MenusId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24MenusId), 12, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavMenusid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24MenusId), 12, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavMenusid_Internalname, "Values", cmbavMenusid.ToJavascriptSource(), true);
         }
         if ( cmbavRelresid.ItemCount > 0 )
         {
            AV32RelResId = cmbavRelresid.getValidValue(AV32RelResId);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32RelResId", AV32RelResId);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavRelresid.CurrentValue = StringUtil.RTrim( AV32RelResId);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRelresid_Internalname, "Values", cmbavRelresid.ToJavascriptSource(), true);
         }
         if ( cmbavLink.ItemCount > 0 )
         {
            AV44Link = cmbavLink.getValidValue(AV44Link);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44Link", AV44Link);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavLink.CurrentValue = StringUtil.RTrim( AV44Link);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavLink_Internalname, "Values", cmbavLink.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1S2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavGamapplication_name_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGamapplication_name_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGamapplication_name_Enabled), 5, 0)), true);
         edtavApplicationmenu_name_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavApplicationmenu_name_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavApplicationmenu_name_Enabled), 5, 0)), true);
      }

      protected void RF1S2( )
      {
         initialize_formulas( ) ;
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E151S2 ();
            WB1S0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1S2( )
      {
         GxWebStd.gx_hidden_field( context, "vAPPLICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10ApplicationId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ApplicationId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMENUID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22MenuId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vMENUID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22MenuId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18Id), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18Id), "ZZZZZZZZZZZ9"), context));
      }

      protected void STRUP1S0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavGamapplication_name_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGamapplication_name_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGamapplication_name_Enabled), 5, 0)), true);
         edtavApplicationmenu_name_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavApplicationmenu_name_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavApplicationmenu_name_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E111S2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV5GAMApplication.gxTpr_Name = cgiGet( edtavGamapplication_name_Internalname);
            AV11ApplicationMenu.gxTpr_Name = cgiGet( edtavApplicationmenu_name_Internalname);
            AV17GUID = cgiGet( edtavGuid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GUID", AV17GUID);
            AV25Name = cgiGet( edtavName_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25Name", AV25Name);
            AV13Dsc = cgiGet( edtavDsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Dsc", AV13Dsc);
            cmbavType.CurrentValue = cgiGet( cmbavType_Internalname);
            AV37Type = cgiGet( cmbavType_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37Type", AV37Type);
            cmbavMenusid.CurrentValue = cgiGet( cmbavMenusid_Internalname);
            AV24MenusId = (long)(NumberUtil.Val( cgiGet( cmbavMenusid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24MenusId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24MenusId), 12, 0)));
            cmbavRelresid.CurrentValue = cgiGet( cmbavRelresid_Internalname);
            AV32RelResId = cgiGet( cmbavRelresid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32RelResId", AV32RelResId);
            AV34Resource = cgiGet( edtavResource_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Resource", AV34Resource);
            AV35ResourceParameters = cgiGet( edtavResourceparameters_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ResourceParameters", AV35ResourceParameters);
            AV43IconClass = cgiGet( edtavIconclass_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43IconClass", AV43IconClass);
            cmbavLink.CurrentValue = cgiGet( cmbavLink_Internalname);
            AV44Link = cgiGet( cmbavLink_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44Link", AV44Link);
            /* Read saved values. */
            Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
            Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
            Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
            Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
            Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
            Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
            Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
            Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
            Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
            Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
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
         E111S2 ();
         if (returnInSub) return;
      }

      protected void E111S2( )
      {
         /* Start Routine */
         AV5GAMApplication.load( AV10ApplicationId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ApplicationId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ApplicationId), "ZZZZZZZZZZZ9"), context));
         AV11ApplicationMenu = AV5GAMApplication.getmenu(AV22MenuId, out  AV15Errors);
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            AV12ApplicationMenuOption = AV11ApplicationMenu.getmenuoptionbyid(AV10ApplicationId, AV18Id, out  AV15Errors);
            AV25Name = AV12ApplicationMenuOption.gxTpr_Name;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25Name", AV25Name);
            AV13Dsc = AV12ApplicationMenuOption.gxTpr_Description;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Dsc", AV13Dsc);
            AV17GUID = AV12ApplicationMenuOption.gxTpr_Guid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GUID", AV17GUID);
            AV37Type = AV12ApplicationMenuOption.gxTpr_Type;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37Type", AV37Type);
            AV24MenusId = AV12ApplicationMenuOption.gxTpr_Submenuid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24MenusId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24MenusId), 12, 0)));
            AV32RelResId = AV12ApplicationMenuOption.gxTpr_Permissionresourceguid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32RelResId", AV32RelResId);
            AV34Resource = AV12ApplicationMenuOption.gxTpr_Resource;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Resource", AV34Resource);
            AV35ResourceParameters = AV12ApplicationMenuOption.gxTpr_Resourceparameters;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ResourceParameters", AV35ResourceParameters);
            if ( AV12ApplicationMenuOption.gxTpr_Properties.Count > 0 )
            {
               AV43IconClass = ((SdtGAMProperty)AV12ApplicationMenuOption.gxTpr_Properties.Item(1)).gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43IconClass", AV43IconClass);
               AV44Link = ((SdtGAMProperty)AV12ApplicationMenuOption.gxTpr_Properties.Item(2)).gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44Link", AV44Link);
            }
            edtavGuid_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), true);
            if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
            {
               if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
               {
                  bttBtnenter_Visible = 0;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnenter_Visible), 5, 0)), true);
               }
               edtavName_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), true);
               edtavDsc_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDsc_Enabled), 5, 0)), true);
               cmbavType.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavType.Enabled), 5, 0)), true);
               cmbavMenusid.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavMenusid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavMenusid.Enabled), 5, 0)), true);
               cmbavRelresid.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRelresid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavRelresid.Enabled), 5, 0)), true);
               edtavResource_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavResource_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavResource_Enabled), 5, 0)), true);
               edtavResourceparameters_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavResourceparameters_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavResourceparameters_Enabled), 5, 0)), true);
               bttBtnenter_Caption = "Delete";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenter_Internalname, "Caption", bttBtnenter_Caption, true);
               cmbavLink.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavLink_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavLink.Enabled), 5, 0)), true);
               edtavIconclass_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavIconclass_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavIconclass_Enabled), 5, 0)), true);
            }
         }
         if ( StringUtil.StrCmp(AV37Type, "S") == 0 )
         {
            AV52GXV4 = 1;
            AV51GXV3 = AV5GAMApplication.getpermissions(AV28PermissionFilter, out  AV15Errors);
            while ( AV52GXV4 <= AV51GXV3.Count )
            {
               AV27Permission = ((SdtGAMApplicationPermission)AV51GXV3.Item(AV52GXV4));
               cmbavRelresid.addItem(AV27Permission.gxTpr_Guid, AV27Permission.gxTpr_Name, 0);
               AV52GXV4 = (int)(AV52GXV4+1);
            }
         }
         else
         {
            AV54GXV6 = 1;
            AV53GXV5 = AV5GAMApplication.getsubmenus(AV22MenuId, out  AV15Errors);
            while ( AV54GXV6 <= AV53GXV5.Count )
            {
               AV20Menu = ((SdtGAMApplicationMenu)AV53GXV5.Item(AV54GXV6));
               cmbavMenusid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV20Menu.gxTpr_Id), 12, 0)), AV20Menu.gxTpr_Name, 0);
               AV54GXV6 = (int)(AV54GXV6+1);
            }
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         if ( ! ( ( StringUtil.StrCmp(AV37Type, "M") == 0 ) ) )
         {
            cmbavMenusid.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavMenusid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavMenusid.Visible), 5, 0)), true);
            divMenusid_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divMenusid_cell_Internalname, "Class", divMenusid_cell_Class, true);
         }
         else
         {
            cmbavMenusid.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavMenusid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavMenusid.Visible), 5, 0)), true);
            divMenusid_cell_Class = "col-xs-12 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divMenusid_cell_Internalname, "Class", divMenusid_cell_Class, true);
         }
         if ( ! ( ( StringUtil.StrCmp(AV37Type, "S") == 0 ) ) )
         {
            cmbavRelresid.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRelresid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavRelresid.Visible), 5, 0)), true);
            divRelresid_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divRelresid_cell_Internalname, "Class", divRelresid_cell_Class, true);
         }
         else
         {
            cmbavRelresid.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRelresid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavRelresid.Visible), 5, 0)), true);
            divRelresid_cell_Class = "col-xs-12 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divRelresid_cell_Internalname, "Class", divRelresid_cell_Class, true);
         }
      }

      protected void E121S2( )
      {
         /* Type_Click Routine */
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
         if ( StringUtil.StrCmp(AV37Type, "S") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV32RelResId)) )
            {
               AV5GAMApplication.load( AV10ApplicationId);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ApplicationId), 12, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ApplicationId), "ZZZZZZZZZZZ9"), context));
               AV56GXV8 = 1;
               AV55GXV7 = AV5GAMApplication.getpermissions(AV28PermissionFilter, out  AV15Errors);
               while ( AV56GXV8 <= AV55GXV7.Count )
               {
                  AV27Permission = ((SdtGAMApplicationPermission)AV55GXV7.Item(AV56GXV8));
                  cmbavRelresid.addItem(AV27Permission.gxTpr_Guid, AV27Permission.gxTpr_Name, 0);
                  AV56GXV8 = (int)(AV56GXV8+1);
               }
            }
         }
         else
         {
            if ( (0==AV24MenusId) )
            {
               AV5GAMApplication.load( AV10ApplicationId);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ApplicationId), 12, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ApplicationId), "ZZZZZZZZZZZ9"), context));
               AV58GXV10 = 1;
               AV57GXV9 = AV5GAMApplication.getsubmenus(AV22MenuId, out  AV15Errors);
               while ( AV58GXV10 <= AV57GXV9.Count )
               {
                  AV20Menu = ((SdtGAMApplicationMenu)AV57GXV9.Item(AV58GXV10));
                  cmbavMenusid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV20Menu.gxTpr_Id), 12, 0)), AV20Menu.gxTpr_Name, 0);
                  AV58GXV10 = (int)(AV58GXV10+1);
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5GAMApplication", AV5GAMApplication);
         cmbavRelresid.CurrentValue = StringUtil.RTrim( AV32RelResId);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRelresid_Internalname, "Values", cmbavRelresid.ToJavascriptSource(), true);
         cmbavMenusid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24MenusId), 12, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavMenusid_Internalname, "Values", cmbavMenusid.ToJavascriptSource(), true);
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E131S2 ();
         if (returnInSub) return;
      }

      protected void E131S2( )
      {
         /* Enter Routine */
         AV5GAMApplication.load( AV10ApplicationId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ApplicationId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ApplicationId), "ZZZZZZZZZZZ9"), context));
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25Name)) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               /* Execute user subroutine: 'LOAD_APPLICATIONMENUOPTION' */
               S122 ();
               if (returnInSub) return;
               AV6isOK = AV5GAMApplication.addmenuoption(AV22MenuId, AV12ApplicationMenuOption, out  AV15Errors);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6isOK", AV6isOK);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
            {
               AV12ApplicationMenuOption = AV5GAMApplication.getmenuoption(AV22MenuId, AV18Id, out  AV15Errors);
               /* Execute user subroutine: 'LOAD_APPLICATIONMENUOPTION' */
               S122 ();
               if (returnInSub) return;
               AV6isOK = AV5GAMApplication.updatemenuoption(AV22MenuId, AV12ApplicationMenuOption, out  AV15Errors);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6isOK", AV6isOK);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               AV12ApplicationMenuOption = AV5GAMApplication.getmenuoption(AV22MenuId, AV18Id, out  AV15Errors);
               AV6isOK = AV5GAMApplication.deletemenuoption(AV22MenuId, AV12ApplicationMenuOption, out  AV15Errors);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6isOK", AV6isOK);
            }
         }
         else
         {
            AV6isOK = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6isOK", AV6isOK);
            AV14Error = new SdtGAMError(context);
            AV14Error.gxTpr_Code = 239;
            AV14Error.gxTpr_Message = gxdomaingamerrormessages.getDescription(context,AV14Error.gxTpr_Code);
            AV15Errors.Add(AV14Error, 0);
         }
         if ( AV6isOK )
         {
            pr_gam.commit( "GAMAppMenuOptionEntry");
            pr_default.commit( "GAMAppMenuOptionEntry");
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         else
         {
            AV59GXV11 = 1;
            while ( AV59GXV11 <= AV15Errors.Count )
            {
               AV14Error = ((SdtGAMError)AV15Errors.Item(AV59GXV11));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV14Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV14Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
               AV59GXV11 = (int)(AV59GXV11+1);
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5GAMApplication", AV5GAMApplication);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12ApplicationMenuOption", AV12ApplicationMenuOption);
      }

      protected void E141S2( )
      {
         /* Relresid_Isvalid Routine */
         AV5GAMApplication.load( AV10ApplicationId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ApplicationId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ApplicationId), "ZZZZZZZZZZZ9"), context));
         AV27Permission = AV5GAMApplication.getpermissionbyguid(AV32RelResId, out  AV15Errors);
         AV34Resource = AV27Permission.gxTpr_Resource;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34Resource", AV34Resource);
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5GAMApplication", AV5GAMApplication);
      }

      protected void S122( )
      {
         /* 'LOAD_APPLICATIONMENUOPTION' Routine */
         AV12ApplicationMenuOption.gxTpr_Guid = AV17GUID;
         AV12ApplicationMenuOption.gxTpr_Name = AV25Name;
         AV12ApplicationMenuOption.gxTpr_Description = AV13Dsc;
         AV12ApplicationMenuOption.gxTpr_Type = AV37Type;
         AV12ApplicationMenuOption.gxTpr_Submenuid = AV24MenusId;
         AV12ApplicationMenuOption.gxTpr_Permissionresourceguid = AV32RelResId;
         AV12ApplicationMenuOption.gxTpr_Resource = AV34Resource;
         AV12ApplicationMenuOption.gxTpr_Resourceparameters = AV35ResourceParameters;
         if ( AV12ApplicationMenuOption.gxTpr_Properties.Count == 2 )
         {
            AV12ApplicationMenuOption.gxTpr_Properties.Clear();
         }
         AV45GAMProperty = new SdtGAMProperty(context);
         AV45GAMProperty.gxTpr_Id = "IconClass";
         AV45GAMProperty.gxTpr_Value = AV43IconClass;
         AV12ApplicationMenuOption.gxTpr_Properties.Add(AV45GAMProperty, 0);
         AV45GAMProperty = new SdtGAMProperty(context);
         AV45GAMProperty.gxTpr_Id = "Link";
         AV45GAMProperty.gxTpr_Value = AV44Link;
         AV12ApplicationMenuOption.gxTpr_Properties.Add(AV45GAMProperty, 0);
      }

      protected void nextLoad( )
      {
      }

      protected void E151S2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         Gx_mode = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         AV10ApplicationId = Convert.ToInt64(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10ApplicationId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10ApplicationId), "ZZZZZZZZZZZ9"), context));
         AV22MenuId = Convert.ToInt64(getParm(obj,2));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22MenuId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMENUID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22MenuId), "ZZZZZZZZZZZ9"), context));
         AV18Id = Convert.ToInt64(getParm(obj,3));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Id), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18Id), "ZZZZZZZZZZZ9"), context));
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
         PA1S2( ) ;
         WS1S2( ) ;
         WE1S2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019455991", true);
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
         context.AddJavascriptSource("gamappmenuoptionentry.js", "?201892019455992", false);
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtavGamapplication_name_Internalname = "GAMAPPLICATION_NAME";
         edtavApplicationmenu_name_Internalname = "APPLICATIONMENU_NAME";
         edtavGuid_Internalname = "vGUID";
         edtavName_Internalname = "vNAME";
         edtavDsc_Internalname = "vDSC";
         cmbavType_Internalname = "vTYPE";
         cmbavMenusid_Internalname = "vMENUSID";
         divMenusid_cell_Internalname = "MENUSID_CELL";
         cmbavRelresid_Internalname = "vRELRESID";
         divRelresid_cell_Internalname = "RELRESID_CELL";
         edtavResource_Internalname = "vRESOURCE";
         edtavResourceparameters_Internalname = "vRESOURCEPARAMETERS";
         edtavIconclass_Internalname = "vICONCLASS";
         cmbavLink_Internalname = "vLINK";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
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
         edtavApplicationmenu_name_Enabled = -1;
         edtavGamapplication_name_Enabled = -1;
         bttBtnenter_Caption = "Confirmar";
         bttBtnenter_Visible = 1;
         cmbavLink_Jsonclick = "";
         cmbavLink.Enabled = 1;
         edtavIconclass_Jsonclick = "";
         edtavIconclass_Enabled = 1;
         edtavResourceparameters_Jsonclick = "";
         edtavResourceparameters_Enabled = 1;
         edtavResource_Jsonclick = "";
         edtavResource_Enabled = 1;
         cmbavRelresid_Jsonclick = "";
         cmbavRelresid.Enabled = 1;
         cmbavRelresid.Visible = 1;
         divRelresid_cell_Class = "col-xs-12";
         cmbavMenusid_Jsonclick = "";
         cmbavMenusid.Enabled = 1;
         cmbavMenusid.Visible = 1;
         divMenusid_cell_Class = "col-xs-12";
         cmbavType_Jsonclick = "";
         cmbavType.Enabled = 1;
         edtavDsc_Jsonclick = "";
         edtavDsc_Enabled = 1;
         edtavName_Jsonclick = "";
         edtavName_Enabled = 1;
         edtavGuid_Jsonclick = "";
         edtavGuid_Enabled = 1;
         edtavApplicationmenu_name_Enabled = 0;
         edtavGamapplication_name_Enabled = 0;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "Menu Option";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "GAM App Menu Option Entry";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV10ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV22MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV18Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("VTYPE.CLICK","{handler:'E121S2',iparms:[{av:'cmbavType'},{av:'AV37Type',fld:'vTYPE',pic:'',nv:''},{av:'cmbavRelresid'},{av:'AV32RelResId',fld:'vRELRESID',pic:'',nv:''},{av:'AV10ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'cmbavMenusid'},{av:'AV24MenusId',fld:'vMENUSID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV22MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'cmbavRelresid'},{av:'AV32RelResId',fld:'vRELRESID',pic:'',nv:''},{av:'cmbavMenusid'},{av:'AV24MenusId',fld:'vMENUSID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'divMenusid_cell_Class',ctrl:'MENUSID_CELL',prop:'Class'},{av:'divRelresid_cell_Class',ctrl:'RELRESID_CELL',prop:'Class'}]}");
         setEventMetadata("ENTER","{handler:'E131S2',iparms:[{av:'AV10ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV25Name',fld:'vNAME',pic:'',nv:''},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV22MenuId',fld:'vMENUID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV18Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV6isOK',fld:'vISOK',pic:'',nv:false},{av:'AV17GUID',fld:'vGUID',pic:'',nv:''},{av:'AV13Dsc',fld:'vDSC',pic:'',nv:''},{av:'cmbavType'},{av:'AV37Type',fld:'vTYPE',pic:'',nv:''},{av:'cmbavMenusid'},{av:'AV24MenusId',fld:'vMENUSID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'cmbavRelresid'},{av:'AV32RelResId',fld:'vRELRESID',pic:'',nv:''},{av:'AV34Resource',fld:'vRESOURCE',pic:'',nv:''},{av:'AV35ResourceParameters',fld:'vRESOURCEPARAMETERS',pic:'',nv:''},{av:'AV43IconClass',fld:'vICONCLASS',pic:'',nv:''},{av:'cmbavLink'},{av:'AV44Link',fld:'vLINK',pic:'',nv:''}],oparms:[{av:'AV6isOK',fld:'vISOK',pic:'',nv:false}]}");
         setEventMetadata("VRELRESID.ISVALID","{handler:'E141S2',iparms:[{av:'AV10ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'cmbavRelresid'},{av:'AV32RelResId',fld:'vRELRESID',pic:'',nv:''}],oparms:[{av:'AV34Resource',fld:'vRESOURCE',pic:'',nv:''}]}");
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
         AV5GAMApplication = new SdtGAMApplication(context);
         AV11ApplicationMenu = new SdtGAMApplicationMenu(context);
         TempTags = "";
         AV17GUID = "";
         AV25Name = "";
         AV13Dsc = "";
         AV37Type = "";
         AV32RelResId = "";
         AV34Resource = "";
         AV35ResourceParameters = "";
         AV43IconClass = "";
         AV44Link = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV15Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV12ApplicationMenuOption = new SdtGAMApplicationMenuOption(context);
         AV51GXV3 = new GXExternalCollection<SdtGAMApplicationPermission>( context, "SdtGAMApplicationPermission", "GeneXus.Programs");
         AV28PermissionFilter = new SdtGAMApplicationPermissionFilter(context);
         AV27Permission = new SdtGAMApplicationPermission(context);
         AV53GXV5 = new GXExternalCollection<SdtGAMApplicationMenu>( context, "SdtGAMApplicationMenu", "GeneXus.Programs");
         AV20Menu = new SdtGAMApplicationMenu(context);
         AV55GXV7 = new GXExternalCollection<SdtGAMApplicationPermission>( context, "SdtGAMApplicationPermission", "GeneXus.Programs");
         AV57GXV9 = new GXExternalCollection<SdtGAMApplicationMenu>( context, "SdtGAMApplicationMenu", "GeneXus.Programs");
         AV14Error = new SdtGAMError(context);
         AV45GAMProperty = new SdtGAMProperty(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamappmenuoptionentry__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamappmenuoptionentry__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavGamapplication_name_Enabled = 0;
         edtavApplicationmenu_name_Enabled = 0;
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
      private int edtavGamapplication_name_Enabled ;
      private int edtavApplicationmenu_name_Enabled ;
      private int edtavGuid_Enabled ;
      private int edtavName_Enabled ;
      private int edtavDsc_Enabled ;
      private int edtavResource_Enabled ;
      private int edtavResourceparameters_Enabled ;
      private int edtavIconclass_Enabled ;
      private int bttBtnenter_Visible ;
      private int AV52GXV4 ;
      private int AV54GXV6 ;
      private int AV56GXV8 ;
      private int AV58GXV10 ;
      private int AV59GXV11 ;
      private int idxLst ;
      private long AV10ApplicationId ;
      private long AV22MenuId ;
      private long AV18Id ;
      private long wcpOAV10ApplicationId ;
      private long wcpOAV22MenuId ;
      private long wcpOAV18Id ;
      private long AV24MenusId ;
      private String Gx_mode ;
      private String wcpOGx_mode ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String edtavGamapplication_name_Internalname ;
      private String edtavApplicationmenu_name_Internalname ;
      private String edtavGuid_Internalname ;
      private String TempTags ;
      private String AV17GUID ;
      private String edtavGuid_Jsonclick ;
      private String edtavName_Internalname ;
      private String AV25Name ;
      private String edtavName_Jsonclick ;
      private String edtavDsc_Internalname ;
      private String AV13Dsc ;
      private String edtavDsc_Jsonclick ;
      private String cmbavType_Internalname ;
      private String AV37Type ;
      private String cmbavType_Jsonclick ;
      private String divMenusid_cell_Internalname ;
      private String divMenusid_cell_Class ;
      private String cmbavMenusid_Internalname ;
      private String cmbavMenusid_Jsonclick ;
      private String divRelresid_cell_Internalname ;
      private String divRelresid_cell_Class ;
      private String cmbavRelresid_Internalname ;
      private String AV32RelResId ;
      private String cmbavRelresid_Jsonclick ;
      private String edtavResource_Internalname ;
      private String edtavResource_Jsonclick ;
      private String edtavResourceparameters_Internalname ;
      private String edtavResourceparameters_Jsonclick ;
      private String edtavIconclass_Internalname ;
      private String edtavIconclass_Jsonclick ;
      private String cmbavLink_Internalname ;
      private String cmbavLink_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Caption ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Dvpanel_tableattributes_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV6isOK ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV34Resource ;
      private String AV35ResourceParameters ;
      private String AV43IconClass ;
      private String AV44Link ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavType ;
      private GXCombobox cmbavMenusid ;
      private GXCombobox cmbavRelresid ;
      private GXCombobox cmbavLink ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMError> AV15Errors ;
      private GXExternalCollection<SdtGAMApplicationPermission> AV51GXV3 ;
      private GXExternalCollection<SdtGAMApplicationPermission> AV55GXV7 ;
      private GXExternalCollection<SdtGAMApplicationMenu> AV53GXV5 ;
      private GXExternalCollection<SdtGAMApplicationMenu> AV57GXV9 ;
      private GXWebForm Form ;
      private SdtGAMApplication AV5GAMApplication ;
      private SdtGAMProperty AV45GAMProperty ;
      private SdtGAMError AV14Error ;
      private SdtGAMApplicationPermission AV27Permission ;
      private SdtGAMApplicationPermissionFilter AV28PermissionFilter ;
      private SdtGAMApplicationMenu AV11ApplicationMenu ;
      private SdtGAMApplicationMenu AV20Menu ;
      private SdtGAMApplicationMenuOption AV12ApplicationMenuOption ;
   }

   public class gamappmenuoptionentry__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamappmenuoptionentry__default : DataStoreHelperBase, IDataStoreHelper
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
