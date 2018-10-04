/*
               File: GAMSecurityPolicyEntry
        Description: Security Policy
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:40:52.30
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
   public class gamsecuritypolicyentry : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamsecuritypolicyentry( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamsecuritypolicyentry( IGxContext context )
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
         this.AV9Id = aP1_Id;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavSecuritypolicyallowmultipleconcurrentwebsessions = new GXCombobox();
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
                  AV9Id = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9Id), 12, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9Id), "ZZZZZZZZZZZ9"), context));
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
         PA0R2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0R2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019405239", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamsecuritypolicyentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV9Id)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vSECURITYPOLICYGUID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV33SecurityPolicyGUID, "")), context));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "GAMSecurityPolicyEntry";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV33SecurityPolicyGUID, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("gamsecuritypolicyentry:[SendSecurityCheck value for]"+"SecurityPolicyGUID:"+StringUtil.RTrim( context.localUtil.Format( AV33SecurityPolicyGUID, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9Id), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9Id), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Width", StringUtil.RTrim( Dvpanel_unnamedtable1_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Cls", StringUtil.RTrim( Dvpanel_unnamedtable1_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Title", StringUtil.RTrim( Dvpanel_unnamedtable1_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable1_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autoscroll));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYWEB_Width", StringUtil.RTrim( Dvpanel_onlyweb_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYWEB_Cls", StringUtil.RTrim( Dvpanel_onlyweb_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYWEB_Title", StringUtil.RTrim( Dvpanel_onlyweb_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYWEB_Collapsible", StringUtil.BoolToStr( Dvpanel_onlyweb_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYWEB_Collapsed", StringUtil.BoolToStr( Dvpanel_onlyweb_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYWEB_Autowidth", StringUtil.BoolToStr( Dvpanel_onlyweb_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYWEB_Autoheight", StringUtil.BoolToStr( Dvpanel_onlyweb_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYWEB_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_onlyweb_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYWEB_Iconposition", StringUtil.RTrim( Dvpanel_onlyweb_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYWEB_Autoscroll", StringUtil.BoolToStr( Dvpanel_onlyweb_Autoscroll));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYSD_Width", StringUtil.RTrim( Dvpanel_onlysd_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYSD_Cls", StringUtil.RTrim( Dvpanel_onlysd_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYSD_Title", StringUtil.RTrim( Dvpanel_onlysd_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYSD_Collapsible", StringUtil.BoolToStr( Dvpanel_onlysd_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYSD_Collapsed", StringUtil.BoolToStr( Dvpanel_onlysd_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYSD_Autowidth", StringUtil.BoolToStr( Dvpanel_onlysd_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYSD_Autoheight", StringUtil.BoolToStr( Dvpanel_onlysd_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYSD_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_onlysd_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYSD_Iconposition", StringUtil.RTrim( Dvpanel_onlysd_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ONLYSD_Autoscroll", StringUtil.BoolToStr( Dvpanel_onlysd_Autoscroll));
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
            WE0R2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0R2( ) ;
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
         return formatLink("gamsecuritypolicyentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV9Id) ;
      }

      public override String GetPgmname( )
      {
         return "GAMSecurityPolicyEntry" ;
      }

      public override String GetPgmdesc( )
      {
         return "Security Policy " ;
      }

      protected void WB0R0( )
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
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableLabel50Percent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicyid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicyid_Internalname, "Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicyid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV32SecurityPolicyId), 9, 0, ",", "")), ((edtavSecuritypolicyid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV32SecurityPolicyId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV32SecurityPolicyId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicyid_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavSecuritypolicyid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "GAMKeyNumShort", "right", false, "HLP_GAMSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicyguid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicyguid_Internalname, "GUID", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicyguid_Internalname, StringUtil.RTrim( AV33SecurityPolicyGUID), StringUtil.RTrim( context.localUtil.Format( AV33SecurityPolicyGUID, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicyguid_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavSecuritypolicyguid_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GAMGUID", "left", true, "HLP_GAMSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicyname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicyname_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicyname_Internalname, StringUtil.RTrim( AV34SecurityPolicyName), StringUtil.RTrim( context.localUtil.Format( AV34SecurityPolicyName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicyname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecuritypolicyname_Enabled, 1, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMSecurityPolicyEntry.htm");
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_UNNAMEDTABLE1Container"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_UNNAMEDTABLE1Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, 1, 0, "px", 0, "px", "TableLabel50Percent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicyperiodchangepassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicyperiodchangepassword_Internalname, "Period to change it (days)", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicyperiodchangepassword_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25SecurityPolicyPeriodChangePassword), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV25SecurityPolicyPeriodChangePassword), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicyperiodchangepassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecuritypolicyperiodchangepassword_Enabled, 1, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicyminimumtimetochangepasswords_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicyminimumtimetochangepasswords_Internalname, "Min. time to change password (minutes)", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicyminimumtimetochangepasswords_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26SecurityPolicyMinimumTimeToChangePasswords), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV26SecurityPolicyMinimumTimeToChangePasswords), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicyminimumtimetochangepasswords_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecuritypolicyminimumtimetochangepasswords_Enabled, 1, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicyminimumlengthpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicyminimumlengthpassword_Internalname, "Min. password length", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicyminimumlengthpassword_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27SecurityPolicyMinimumLengthPassword), 2, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV27SecurityPolicyMinimumLengthPassword), "Z9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicyminimumlengthpassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecuritypolicyminimumlengthpassword_Enabled, 1, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicyminimumnumericcharacterspassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicyminimumnumericcharacterspassword_Internalname, "Min. numeric characters", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicyminimumnumericcharacterspassword_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28SecurityPolicyMinimumNumericCharactersPassword), 2, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV28SecurityPolicyMinimumNumericCharactersPassword), "Z9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicyminimumnumericcharacterspassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecuritypolicyminimumnumericcharacterspassword_Enabled, 1, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicyminimumuppercasecharacterspassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicyminimumuppercasecharacterspassword_Internalname, "Min. uppercase characters", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicyminimumuppercasecharacterspassword_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29SecurityPolicyMinimumUpperCaseCharactersPassword), 2, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV29SecurityPolicyMinimumUpperCaseCharactersPassword), "Z9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicyminimumuppercasecharacterspassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecuritypolicyminimumuppercasecharacterspassword_Enabled, 1, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicyminimumspecialcharacterspassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicyminimumspecialcharacterspassword_Internalname, "Min. special characters", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicyminimumspecialcharacterspassword_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30SecurityPolicyMinimumSpecialCharactersPassword), 2, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV30SecurityPolicyMinimumSpecialCharactersPassword), "Z9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicyminimumspecialcharacterspassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecuritypolicyminimumspecialcharacterspassword_Enabled, 1, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicymaximumpasswordhistoryentries_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicymaximumpasswordhistoryentries_Internalname, "Max. password history entries", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicymaximumpasswordhistoryentries_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31SecurityPolicyMaximumPasswordHistoryEntries), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV31SecurityPolicyMaximumPasswordHistoryEntries), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicymaximumpasswordhistoryentries_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecuritypolicymaximumpasswordhistoryentries_Enabled, 1, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMSecurityPolicyEntry.htm");
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_onlyweb_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_ONLYWEBContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_ONLYWEBContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_onlyweb_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divOnlyweb_Internalname, 1, 0, "px", 0, "px", "TableLabel50Percent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Internalname, "Allow multiple concurrent web sessions", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavSecuritypolicyallowmultipleconcurrentwebsessions, cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV23SecurityPolicyAllowMultipleConcurrentWebSessions), 1, 0)), 1, cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavSecuritypolicyallowmultipleconcurrentwebsessions.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,86);\"", "", true, "HLP_GAMSecurityPolicyEntry.htm");
            cmbavSecuritypolicyallowmultipleconcurrentwebsessions.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV23SecurityPolicyAllowMultipleConcurrentWebSessions), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Internalname, "Values", (String)(cmbavSecuritypolicyallowmultipleconcurrentwebsessions.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicywebsessiontimeout_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicywebsessiontimeout_Internalname, "Session timeout (minutes)", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicywebsessiontimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24SecurityPolicyWebSessionTimeout), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV24SecurityPolicyWebSessionTimeout), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,91);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicywebsessiontimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecuritypolicywebsessiontimeout_Enabled, 1, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMSecurityPolicyEntry.htm");
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_onlysd_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_ONLYSDContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_ONLYSDContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_onlysd_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divOnlysd_Internalname, 1, 0, "px", 0, "px", "TableLabel50Percent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicyoauthtokenexpire_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicyoauthtokenexpire_Internalname, "Oauth token expire (minutes)", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicyoauthtokenexpire_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22SecurityPolicyOauthTokenExpire), 6, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22SecurityPolicyOauthTokenExpire), "ZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,103);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicyoauthtokenexpire_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecuritypolicyoauthtokenexpire_Enabled, 1, "text", "", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecuritypolicyoauthtokenmaximumrenovations_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuritypolicyoauthtokenmaximumrenovations_Internalname, "Max. token renovations", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuritypolicyoauthtokenmaximumrenovations_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV35SecurityPolicyOauthTokenMaximumRenovations), 6, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV35SecurityPolicyOauthTokenMaximumRenovations), "ZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,108);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuritypolicyoauthtokenmaximumrenovations_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecuritypolicyoauthtokenmaximumrenovations_Enabled, 1, "text", "", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMSecurityPolicyEntry.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", bttBtnenter_Caption, bttBtnenter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtnenter_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMSecurityPolicyEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Fechar", bttBtncancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMSecurityPolicyEntry.htm");
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

      protected void START0R2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Security Policy ", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0R0( ) ;
      }

      protected void WS0R2( )
      {
         START0R2( ) ;
         EVT0R2( ) ;
      }

      protected void EVT0R2( )
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
                              E110R2 ();
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
                                    E120R2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E130R2 ();
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

      protected void WE0R2( )
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

      protected void PA0R2( )
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
            cmbavSecuritypolicyallowmultipleconcurrentwebsessions.Name = "vSECURITYPOLICYALLOWMULTIPLECONCURRENTWEBSESSIONS";
            cmbavSecuritypolicyallowmultipleconcurrentwebsessions.WebTags = "";
            cmbavSecuritypolicyallowmultipleconcurrentwebsessions.addItem("1", "Yes, from different IP address", 0);
            cmbavSecuritypolicyallowmultipleconcurrentwebsessions.addItem("2", "Yes, from same IP address", 0);
            cmbavSecuritypolicyallowmultipleconcurrentwebsessions.addItem("3", "No", 0);
            if ( cmbavSecuritypolicyallowmultipleconcurrentwebsessions.ItemCount > 0 )
            {
               AV23SecurityPolicyAllowMultipleConcurrentWebSessions = (short)(NumberUtil.Val( cmbavSecuritypolicyallowmultipleconcurrentwebsessions.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV23SecurityPolicyAllowMultipleConcurrentWebSessions), 1, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23SecurityPolicyAllowMultipleConcurrentWebSessions", StringUtil.Str( (decimal)(AV23SecurityPolicyAllowMultipleConcurrentWebSessions), 1, 0));
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
               GX_FocusControl = edtavSecuritypolicyid_Internalname;
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
         if ( cmbavSecuritypolicyallowmultipleconcurrentwebsessions.ItemCount > 0 )
         {
            AV23SecurityPolicyAllowMultipleConcurrentWebSessions = (short)(NumberUtil.Val( cmbavSecuritypolicyallowmultipleconcurrentwebsessions.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV23SecurityPolicyAllowMultipleConcurrentWebSessions), 1, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23SecurityPolicyAllowMultipleConcurrentWebSessions", StringUtil.Str( (decimal)(AV23SecurityPolicyAllowMultipleConcurrentWebSessions), 1, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavSecuritypolicyallowmultipleconcurrentwebsessions.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV23SecurityPolicyAllowMultipleConcurrentWebSessions), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Internalname, "Values", cmbavSecuritypolicyallowmultipleconcurrentwebsessions.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0R2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavSecuritypolicyid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyid_Enabled), 5, 0)), true);
         edtavSecuritypolicyguid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyguid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyguid_Enabled), 5, 0)), true);
      }

      protected void RF0R2( )
      {
         initialize_formulas( ) ;
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E130R2 ();
            WB0R0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0R2( )
      {
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9Id), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9Id), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vSECURITYPOLICYGUID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV33SecurityPolicyGUID, "")), context));
      }

      protected void STRUP0R0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavSecuritypolicyid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyid_Enabled), 5, 0)), true);
         edtavSecuritypolicyguid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyguid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyguid_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110R2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSECURITYPOLICYID");
               GX_FocusControl = edtavSecuritypolicyid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV32SecurityPolicyId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32SecurityPolicyId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV32SecurityPolicyId), 9, 0)));
            }
            else
            {
               AV32SecurityPolicyId = (int)(context.localUtil.CToN( cgiGet( edtavSecuritypolicyid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32SecurityPolicyId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV32SecurityPolicyId), 9, 0)));
            }
            AV33SecurityPolicyGUID = cgiGet( edtavSecuritypolicyguid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33SecurityPolicyGUID", AV33SecurityPolicyGUID);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSECURITYPOLICYGUID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV33SecurityPolicyGUID, "")), context));
            AV34SecurityPolicyName = cgiGet( edtavSecuritypolicyname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34SecurityPolicyName", AV34SecurityPolicyName);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyperiodchangepassword_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyperiodchangepassword_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSECURITYPOLICYPERIODCHANGEPASSWORD");
               GX_FocusControl = edtavSecuritypolicyperiodchangepassword_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV25SecurityPolicyPeriodChangePassword = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25SecurityPolicyPeriodChangePassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25SecurityPolicyPeriodChangePassword), 4, 0)));
            }
            else
            {
               AV25SecurityPolicyPeriodChangePassword = (short)(context.localUtil.CToN( cgiGet( edtavSecuritypolicyperiodchangepassword_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25SecurityPolicyPeriodChangePassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25SecurityPolicyPeriodChangePassword), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumtimetochangepasswords_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumtimetochangepasswords_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSECURITYPOLICYMINIMUMTIMETOCHANGEPASSWORDS");
               GX_FocusControl = edtavSecuritypolicyminimumtimetochangepasswords_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV26SecurityPolicyMinimumTimeToChangePasswords = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26SecurityPolicyMinimumTimeToChangePasswords", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26SecurityPolicyMinimumTimeToChangePasswords), 4, 0)));
            }
            else
            {
               AV26SecurityPolicyMinimumTimeToChangePasswords = (short)(context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumtimetochangepasswords_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26SecurityPolicyMinimumTimeToChangePasswords", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26SecurityPolicyMinimumTimeToChangePasswords), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumlengthpassword_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumlengthpassword_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSECURITYPOLICYMINIMUMLENGTHPASSWORD");
               GX_FocusControl = edtavSecuritypolicyminimumlengthpassword_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV27SecurityPolicyMinimumLengthPassword = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27SecurityPolicyMinimumLengthPassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27SecurityPolicyMinimumLengthPassword), 2, 0)));
            }
            else
            {
               AV27SecurityPolicyMinimumLengthPassword = (short)(context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumlengthpassword_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27SecurityPolicyMinimumLengthPassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27SecurityPolicyMinimumLengthPassword), 2, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumnumericcharacterspassword_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumnumericcharacterspassword_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSECURITYPOLICYMINIMUMNUMERICCHARACTERSPASSWORD");
               GX_FocusControl = edtavSecuritypolicyminimumnumericcharacterspassword_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV28SecurityPolicyMinimumNumericCharactersPassword = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28SecurityPolicyMinimumNumericCharactersPassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28SecurityPolicyMinimumNumericCharactersPassword), 2, 0)));
            }
            else
            {
               AV28SecurityPolicyMinimumNumericCharactersPassword = (short)(context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumnumericcharacterspassword_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28SecurityPolicyMinimumNumericCharactersPassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28SecurityPolicyMinimumNumericCharactersPassword), 2, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumuppercasecharacterspassword_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumuppercasecharacterspassword_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSECURITYPOLICYMINIMUMUPPERCASECHARACTERSPASSWORD");
               GX_FocusControl = edtavSecuritypolicyminimumuppercasecharacterspassword_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV29SecurityPolicyMinimumUpperCaseCharactersPassword = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29SecurityPolicyMinimumUpperCaseCharactersPassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29SecurityPolicyMinimumUpperCaseCharactersPassword), 2, 0)));
            }
            else
            {
               AV29SecurityPolicyMinimumUpperCaseCharactersPassword = (short)(context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumuppercasecharacterspassword_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29SecurityPolicyMinimumUpperCaseCharactersPassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29SecurityPolicyMinimumUpperCaseCharactersPassword), 2, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumspecialcharacterspassword_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumspecialcharacterspassword_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSECURITYPOLICYMINIMUMSPECIALCHARACTERSPASSWORD");
               GX_FocusControl = edtavSecuritypolicyminimumspecialcharacterspassword_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV30SecurityPolicyMinimumSpecialCharactersPassword = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30SecurityPolicyMinimumSpecialCharactersPassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30SecurityPolicyMinimumSpecialCharactersPassword), 2, 0)));
            }
            else
            {
               AV30SecurityPolicyMinimumSpecialCharactersPassword = (short)(context.localUtil.CToN( cgiGet( edtavSecuritypolicyminimumspecialcharacterspassword_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30SecurityPolicyMinimumSpecialCharactersPassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30SecurityPolicyMinimumSpecialCharactersPassword), 2, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicymaximumpasswordhistoryentries_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicymaximumpasswordhistoryentries_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSECURITYPOLICYMAXIMUMPASSWORDHISTORYENTRIES");
               GX_FocusControl = edtavSecuritypolicymaximumpasswordhistoryentries_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV31SecurityPolicyMaximumPasswordHistoryEntries = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31SecurityPolicyMaximumPasswordHistoryEntries", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31SecurityPolicyMaximumPasswordHistoryEntries), 4, 0)));
            }
            else
            {
               AV31SecurityPolicyMaximumPasswordHistoryEntries = (short)(context.localUtil.CToN( cgiGet( edtavSecuritypolicymaximumpasswordhistoryentries_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31SecurityPolicyMaximumPasswordHistoryEntries", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31SecurityPolicyMaximumPasswordHistoryEntries), 4, 0)));
            }
            cmbavSecuritypolicyallowmultipleconcurrentwebsessions.CurrentValue = cgiGet( cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Internalname);
            AV23SecurityPolicyAllowMultipleConcurrentWebSessions = (short)(NumberUtil.Val( cgiGet( cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23SecurityPolicyAllowMultipleConcurrentWebSessions", StringUtil.Str( (decimal)(AV23SecurityPolicyAllowMultipleConcurrentWebSessions), 1, 0));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicywebsessiontimeout_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicywebsessiontimeout_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSECURITYPOLICYWEBSESSIONTIMEOUT");
               GX_FocusControl = edtavSecuritypolicywebsessiontimeout_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV24SecurityPolicyWebSessionTimeout = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24SecurityPolicyWebSessionTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24SecurityPolicyWebSessionTimeout), 4, 0)));
            }
            else
            {
               AV24SecurityPolicyWebSessionTimeout = (short)(context.localUtil.CToN( cgiGet( edtavSecuritypolicywebsessiontimeout_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24SecurityPolicyWebSessionTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24SecurityPolicyWebSessionTimeout), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyoauthtokenexpire_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyoauthtokenexpire_Internalname), ",", ".") > Convert.ToDecimal( 999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSECURITYPOLICYOAUTHTOKENEXPIRE");
               GX_FocusControl = edtavSecuritypolicyoauthtokenexpire_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22SecurityPolicyOauthTokenExpire = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22SecurityPolicyOauthTokenExpire", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22SecurityPolicyOauthTokenExpire), 6, 0)));
            }
            else
            {
               AV22SecurityPolicyOauthTokenExpire = (int)(context.localUtil.CToN( cgiGet( edtavSecuritypolicyoauthtokenexpire_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22SecurityPolicyOauthTokenExpire", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22SecurityPolicyOauthTokenExpire), 6, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyoauthtokenmaximumrenovations_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavSecuritypolicyoauthtokenmaximumrenovations_Internalname), ",", ".") > Convert.ToDecimal( 999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSECURITYPOLICYOAUTHTOKENMAXIMUMRENOVATIONS");
               GX_FocusControl = edtavSecuritypolicyoauthtokenmaximumrenovations_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV35SecurityPolicyOauthTokenMaximumRenovations = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35SecurityPolicyOauthTokenMaximumRenovations", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35SecurityPolicyOauthTokenMaximumRenovations), 6, 0)));
            }
            else
            {
               AV35SecurityPolicyOauthTokenMaximumRenovations = (int)(context.localUtil.CToN( cgiGet( edtavSecuritypolicyoauthtokenmaximumrenovations_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35SecurityPolicyOauthTokenMaximumRenovations", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35SecurityPolicyOauthTokenMaximumRenovations), 6, 0)));
            }
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
            Dvpanel_unnamedtable1_Width = cgiGet( "DVPANEL_UNNAMEDTABLE1_Width");
            Dvpanel_unnamedtable1_Cls = cgiGet( "DVPANEL_UNNAMEDTABLE1_Cls");
            Dvpanel_unnamedtable1_Title = cgiGet( "DVPANEL_UNNAMEDTABLE1_Title");
            Dvpanel_unnamedtable1_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Collapsible"));
            Dvpanel_unnamedtable1_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Collapsed"));
            Dvpanel_unnamedtable1_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autowidth"));
            Dvpanel_unnamedtable1_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autoheight"));
            Dvpanel_unnamedtable1_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Showcollapseicon"));
            Dvpanel_unnamedtable1_Iconposition = cgiGet( "DVPANEL_UNNAMEDTABLE1_Iconposition");
            Dvpanel_unnamedtable1_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autoscroll"));
            Dvpanel_onlyweb_Width = cgiGet( "DVPANEL_ONLYWEB_Width");
            Dvpanel_onlyweb_Cls = cgiGet( "DVPANEL_ONLYWEB_Cls");
            Dvpanel_onlyweb_Title = cgiGet( "DVPANEL_ONLYWEB_Title");
            Dvpanel_onlyweb_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_ONLYWEB_Collapsible"));
            Dvpanel_onlyweb_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_ONLYWEB_Collapsed"));
            Dvpanel_onlyweb_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_ONLYWEB_Autowidth"));
            Dvpanel_onlyweb_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_ONLYWEB_Autoheight"));
            Dvpanel_onlyweb_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_ONLYWEB_Showcollapseicon"));
            Dvpanel_onlyweb_Iconposition = cgiGet( "DVPANEL_ONLYWEB_Iconposition");
            Dvpanel_onlyweb_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_ONLYWEB_Autoscroll"));
            Dvpanel_onlysd_Width = cgiGet( "DVPANEL_ONLYSD_Width");
            Dvpanel_onlysd_Cls = cgiGet( "DVPANEL_ONLYSD_Cls");
            Dvpanel_onlysd_Title = cgiGet( "DVPANEL_ONLYSD_Title");
            Dvpanel_onlysd_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_ONLYSD_Collapsible"));
            Dvpanel_onlysd_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_ONLYSD_Collapsed"));
            Dvpanel_onlysd_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_ONLYSD_Autowidth"));
            Dvpanel_onlysd_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_ONLYSD_Autoheight"));
            Dvpanel_onlysd_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_ONLYSD_Showcollapseicon"));
            Dvpanel_onlysd_Iconposition = cgiGet( "DVPANEL_ONLYSD_Iconposition");
            Dvpanel_onlysd_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_ONLYSD_Autoscroll"));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = "hsh" + "GAMSecurityPolicyEntry";
            AV33SecurityPolicyGUID = cgiGet( edtavSecuritypolicyguid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33SecurityPolicyGUID", AV33SecurityPolicyGUID);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSECURITYPOLICYGUID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV33SecurityPolicyGUID, "")), context));
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV33SecurityPolicyGUID, ""));
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("gamsecuritypolicyentry:[SecurityCheckFailed value for]"+"SecurityPolicyGUID:"+StringUtil.RTrim( context.localUtil.Format( AV33SecurityPolicyGUID, "")));
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E110R2 ();
         if (returnInSub) return;
      }

      protected void E110R2( )
      {
         /* Start Routine */
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            AV20SecurityPolicy.load( (int)(AV9Id));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9Id), 12, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9Id), "ZZZZZZZZZZZ9"), context));
            AV32SecurityPolicyId = AV20SecurityPolicy.gxTpr_Id;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32SecurityPolicyId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV32SecurityPolicyId), 9, 0)));
            AV33SecurityPolicyGUID = AV20SecurityPolicy.gxTpr_Guid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33SecurityPolicyGUID", AV33SecurityPolicyGUID);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSECURITYPOLICYGUID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV33SecurityPolicyGUID, "")), context));
            AV34SecurityPolicyName = AV20SecurityPolicy.gxTpr_Name;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34SecurityPolicyName", AV34SecurityPolicyName);
            AV25SecurityPolicyPeriodChangePassword = AV20SecurityPolicy.gxTpr_Periodchangepassword;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25SecurityPolicyPeriodChangePassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25SecurityPolicyPeriodChangePassword), 4, 0)));
            AV26SecurityPolicyMinimumTimeToChangePasswords = AV20SecurityPolicy.gxTpr_Minimumtimetochangepasswords;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26SecurityPolicyMinimumTimeToChangePasswords", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26SecurityPolicyMinimumTimeToChangePasswords), 4, 0)));
            AV27SecurityPolicyMinimumLengthPassword = AV20SecurityPolicy.gxTpr_Minimumlengthpassword;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27SecurityPolicyMinimumLengthPassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27SecurityPolicyMinimumLengthPassword), 2, 0)));
            AV28SecurityPolicyMinimumNumericCharactersPassword = AV20SecurityPolicy.gxTpr_Minimumnumericcharacterspassword;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28SecurityPolicyMinimumNumericCharactersPassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28SecurityPolicyMinimumNumericCharactersPassword), 2, 0)));
            AV29SecurityPolicyMinimumUpperCaseCharactersPassword = AV20SecurityPolicy.gxTpr_Minimumuppercasecharacterspassword;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29SecurityPolicyMinimumUpperCaseCharactersPassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29SecurityPolicyMinimumUpperCaseCharactersPassword), 2, 0)));
            AV30SecurityPolicyMinimumSpecialCharactersPassword = AV20SecurityPolicy.gxTpr_Minimumspecialcharacterspassword;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30SecurityPolicyMinimumSpecialCharactersPassword", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30SecurityPolicyMinimumSpecialCharactersPassword), 2, 0)));
            AV31SecurityPolicyMaximumPasswordHistoryEntries = AV20SecurityPolicy.gxTpr_Maximumpasswordhistoryentries;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31SecurityPolicyMaximumPasswordHistoryEntries", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31SecurityPolicyMaximumPasswordHistoryEntries), 4, 0)));
            AV23SecurityPolicyAllowMultipleConcurrentWebSessions = AV20SecurityPolicy.gxTpr_Allowmultipleconcurrentwebsessions;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23SecurityPolicyAllowMultipleConcurrentWebSessions", StringUtil.Str( (decimal)(AV23SecurityPolicyAllowMultipleConcurrentWebSessions), 1, 0));
            AV24SecurityPolicyWebSessionTimeout = AV20SecurityPolicy.gxTpr_Websessiontimeout;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24SecurityPolicyWebSessionTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24SecurityPolicyWebSessionTimeout), 4, 0)));
            AV22SecurityPolicyOauthTokenExpire = AV20SecurityPolicy.gxTpr_Oauthtokenexpire;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22SecurityPolicyOauthTokenExpire", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22SecurityPolicyOauthTokenExpire), 6, 0)));
            AV35SecurityPolicyOauthTokenMaximumRenovations = AV20SecurityPolicy.gxTpr_Oauthtokenmaximumrenovations;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35SecurityPolicyOauthTokenMaximumRenovations", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35SecurityPolicyOauthTokenMaximumRenovations), 6, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtnenter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnenter_Visible), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            edtavSecuritypolicyname_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyname_Enabled), 5, 0)), true);
            cmbavSecuritypolicyallowmultipleconcurrentwebsessions.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavSecuritypolicyallowmultipleconcurrentwebsessions.Enabled), 5, 0)), true);
            edtavSecuritypolicywebsessiontimeout_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicywebsessiontimeout_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicywebsessiontimeout_Enabled), 5, 0)), true);
            edtavSecuritypolicyoauthtokenexpire_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyoauthtokenexpire_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyoauthtokenexpire_Enabled), 5, 0)), true);
            edtavSecuritypolicyoauthtokenmaximumrenovations_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyoauthtokenmaximumrenovations_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyoauthtokenmaximumrenovations_Enabled), 5, 0)), true);
            edtavSecuritypolicyperiodchangepassword_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyperiodchangepassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyperiodchangepassword_Enabled), 5, 0)), true);
            edtavSecuritypolicyminimumtimetochangepasswords_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyminimumtimetochangepasswords_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyminimumtimetochangepasswords_Enabled), 5, 0)), true);
            edtavSecuritypolicyminimumlengthpassword_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyminimumlengthpassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyminimumlengthpassword_Enabled), 5, 0)), true);
            edtavSecuritypolicyminimumnumericcharacterspassword_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyminimumnumericcharacterspassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyminimumnumericcharacterspassword_Enabled), 5, 0)), true);
            edtavSecuritypolicyminimumuppercasecharacterspassword_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyminimumuppercasecharacterspassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyminimumuppercasecharacterspassword_Enabled), 5, 0)), true);
            edtavSecuritypolicyminimumspecialcharacterspassword_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicyminimumspecialcharacterspassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicyminimumspecialcharacterspassword_Enabled), 5, 0)), true);
            edtavSecuritypolicymaximumpasswordhistoryentries_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuritypolicymaximumpasswordhistoryentries_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuritypolicymaximumpasswordhistoryentries_Enabled), 5, 0)), true);
            bttBtnenter_Caption = "Delete";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenter_Internalname, "Caption", bttBtnenter_Caption, true);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E120R2 ();
         if (returnInSub) return;
      }

      protected void E120R2( )
      {
         /* Enter Routine */
         AV20SecurityPolicy.load( (int)(AV9Id));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9Id), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9Id), "ZZZZZZZZZZZ9"), context));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) )
         {
            AV32SecurityPolicyId = AV20SecurityPolicy.gxTpr_Id;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32SecurityPolicyId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV32SecurityPolicyId), 9, 0)));
            AV20SecurityPolicy.gxTpr_Guid = AV33SecurityPolicyGUID;
            AV20SecurityPolicy.gxTpr_Name = AV34SecurityPolicyName;
            AV20SecurityPolicy.gxTpr_Periodchangepassword = AV25SecurityPolicyPeriodChangePassword;
            AV20SecurityPolicy.gxTpr_Minimumtimetochangepasswords = AV26SecurityPolicyMinimumTimeToChangePasswords;
            AV20SecurityPolicy.gxTpr_Minimumlengthpassword = AV27SecurityPolicyMinimumLengthPassword;
            AV20SecurityPolicy.gxTpr_Minimumnumericcharacterspassword = AV28SecurityPolicyMinimumNumericCharactersPassword;
            AV20SecurityPolicy.gxTpr_Minimumuppercasecharacterspassword = AV29SecurityPolicyMinimumUpperCaseCharactersPassword;
            AV20SecurityPolicy.gxTpr_Minimumspecialcharacterspassword = AV30SecurityPolicyMinimumSpecialCharactersPassword;
            AV20SecurityPolicy.gxTpr_Maximumpasswordhistoryentries = AV31SecurityPolicyMaximumPasswordHistoryEntries;
            AV20SecurityPolicy.gxTpr_Allowmultipleconcurrentwebsessions = AV23SecurityPolicyAllowMultipleConcurrentWebSessions;
            AV20SecurityPolicy.gxTpr_Websessiontimeout = AV24SecurityPolicyWebSessionTimeout;
            AV20SecurityPolicy.gxTpr_Oauthtokenexpire = AV22SecurityPolicyOauthTokenExpire;
            AV20SecurityPolicy.gxTpr_Oauthtokenmaximumrenovations = (short)(AV35SecurityPolicyOauthTokenMaximumRenovations);
            AV20SecurityPolicy.save();
         }
         else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            AV20SecurityPolicy.delete();
         }
         if ( AV20SecurityPolicy.success() )
         {
            pr_gam.commit( "GAMSecurityPolicyEntry");
            pr_default.commit( "GAMSecurityPolicyEntry");
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         else
         {
            AV7Errors = AV20SecurityPolicy.geterrors();
            AV44GXV1 = 1;
            while ( AV44GXV1 <= AV7Errors.Count )
            {
               AV6Error = ((SdtGAMError)AV7Errors.Item(AV44GXV1));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV6Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV6Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
               AV44GXV1 = (int)(AV44GXV1+1);
            }
         }
         /*  Sending Event outputs  */
      }

      protected void nextLoad( )
      {
      }

      protected void E130R2( )
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
         AV9Id = Convert.ToInt64(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9Id), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9Id), "ZZZZZZZZZZZ9"), context));
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
         PA0R2( ) ;
         WS0R2( ) ;
         WE0R2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019405891", true);
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
         context.AddJavascriptSource("gamsecuritypolicyentry.js", "?201892019405891", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtavSecuritypolicyid_Internalname = "vSECURITYPOLICYID";
         edtavSecuritypolicyguid_Internalname = "vSECURITYPOLICYGUID";
         edtavSecuritypolicyname_Internalname = "vSECURITYPOLICYNAME";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         edtavSecuritypolicyperiodchangepassword_Internalname = "vSECURITYPOLICYPERIODCHANGEPASSWORD";
         edtavSecuritypolicyminimumtimetochangepasswords_Internalname = "vSECURITYPOLICYMINIMUMTIMETOCHANGEPASSWORDS";
         edtavSecuritypolicyminimumlengthpassword_Internalname = "vSECURITYPOLICYMINIMUMLENGTHPASSWORD";
         edtavSecuritypolicyminimumnumericcharacterspassword_Internalname = "vSECURITYPOLICYMINIMUMNUMERICCHARACTERSPASSWORD";
         edtavSecuritypolicyminimumuppercasecharacterspassword_Internalname = "vSECURITYPOLICYMINIMUMUPPERCASECHARACTERSPASSWORD";
         edtavSecuritypolicyminimumspecialcharacterspassword_Internalname = "vSECURITYPOLICYMINIMUMSPECIALCHARACTERSPASSWORD";
         edtavSecuritypolicymaximumpasswordhistoryentries_Internalname = "vSECURITYPOLICYMAXIMUMPASSWORDHISTORYENTRIES";
         divUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         divLayout_unnamedtable1_Internalname = "LAYOUT_UNNAMEDTABLE1";
         Dvpanel_unnamedtable1_Internalname = "DVPANEL_UNNAMEDTABLE1";
         divHtml_dvpanel_unnamedtable1_Internalname = "HTML_DVPANEL_UNNAMEDTABLE1";
         cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Internalname = "vSECURITYPOLICYALLOWMULTIPLECONCURRENTWEBSESSIONS";
         edtavSecuritypolicywebsessiontimeout_Internalname = "vSECURITYPOLICYWEBSESSIONTIMEOUT";
         divOnlyweb_Internalname = "ONLYWEB";
         divLayout_onlyweb_Internalname = "LAYOUT_ONLYWEB";
         Dvpanel_onlyweb_Internalname = "DVPANEL_ONLYWEB";
         divHtml_dvpanel_onlyweb_Internalname = "HTML_DVPANEL_ONLYWEB";
         edtavSecuritypolicyoauthtokenexpire_Internalname = "vSECURITYPOLICYOAUTHTOKENEXPIRE";
         edtavSecuritypolicyoauthtokenmaximumrenovations_Internalname = "vSECURITYPOLICYOAUTHTOKENMAXIMUMRENOVATIONS";
         divOnlysd_Internalname = "ONLYSD";
         divLayout_onlysd_Internalname = "LAYOUT_ONLYSD";
         Dvpanel_onlysd_Internalname = "DVPANEL_ONLYSD";
         divHtml_dvpanel_onlysd_Internalname = "HTML_DVPANEL_ONLYSD";
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
         bttBtnenter_Caption = "Confirmar";
         bttBtnenter_Visible = 1;
         edtavSecuritypolicyoauthtokenmaximumrenovations_Jsonclick = "";
         edtavSecuritypolicyoauthtokenmaximumrenovations_Enabled = 1;
         edtavSecuritypolicyoauthtokenexpire_Jsonclick = "";
         edtavSecuritypolicyoauthtokenexpire_Enabled = 1;
         edtavSecuritypolicywebsessiontimeout_Jsonclick = "";
         edtavSecuritypolicywebsessiontimeout_Enabled = 1;
         cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Jsonclick = "";
         cmbavSecuritypolicyallowmultipleconcurrentwebsessions.Enabled = 1;
         edtavSecuritypolicymaximumpasswordhistoryentries_Jsonclick = "";
         edtavSecuritypolicymaximumpasswordhistoryentries_Enabled = 1;
         edtavSecuritypolicyminimumspecialcharacterspassword_Jsonclick = "";
         edtavSecuritypolicyminimumspecialcharacterspassword_Enabled = 1;
         edtavSecuritypolicyminimumuppercasecharacterspassword_Jsonclick = "";
         edtavSecuritypolicyminimumuppercasecharacterspassword_Enabled = 1;
         edtavSecuritypolicyminimumnumericcharacterspassword_Jsonclick = "";
         edtavSecuritypolicyminimumnumericcharacterspassword_Enabled = 1;
         edtavSecuritypolicyminimumlengthpassword_Jsonclick = "";
         edtavSecuritypolicyminimumlengthpassword_Enabled = 1;
         edtavSecuritypolicyminimumtimetochangepasswords_Jsonclick = "";
         edtavSecuritypolicyminimumtimetochangepasswords_Enabled = 1;
         edtavSecuritypolicyperiodchangepassword_Jsonclick = "";
         edtavSecuritypolicyperiodchangepassword_Enabled = 1;
         edtavSecuritypolicyname_Jsonclick = "";
         edtavSecuritypolicyname_Enabled = 1;
         edtavSecuritypolicyguid_Jsonclick = "";
         edtavSecuritypolicyguid_Enabled = 1;
         edtavSecuritypolicyid_Jsonclick = "";
         edtavSecuritypolicyid_Enabled = 1;
         Dvpanel_onlysd_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_onlysd_Iconposition = "left";
         Dvpanel_onlysd_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_onlysd_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_onlysd_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_onlysd_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_onlysd_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_onlysd_Title = "Only Smart Devices";
         Dvpanel_onlysd_Cls = "PanelCard_BaseColor";
         Dvpanel_onlysd_Width = "100%";
         Dvpanel_onlyweb_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_onlyweb_Iconposition = "left";
         Dvpanel_onlyweb_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_onlyweb_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_onlyweb_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_onlyweb_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_onlyweb_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_onlyweb_Title = "Only Web";
         Dvpanel_onlyweb_Cls = "PanelCard_BaseColor";
         Dvpanel_onlyweb_Width = "100%";
         Dvpanel_unnamedtable1_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Iconposition = "left";
         Dvpanel_unnamedtable1_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable1_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable1_Title = "Password Configurations";
         Dvpanel_unnamedtable1_Cls = "PanelCard_BaseColor";
         Dvpanel_unnamedtable1_Width = "100%";
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "Security Policy";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Security Policy ";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV9Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV33SecurityPolicyGUID',fld:'vSECURITYPOLICYGUID',pic:'',hsh:true,nv:''}],oparms:[]}");
         setEventMetadata("ENTER","{handler:'E120R2',iparms:[{av:'AV9Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV33SecurityPolicyGUID',fld:'vSECURITYPOLICYGUID',pic:'',hsh:true,nv:''},{av:'AV34SecurityPolicyName',fld:'vSECURITYPOLICYNAME',pic:'',nv:''},{av:'AV25SecurityPolicyPeriodChangePassword',fld:'vSECURITYPOLICYPERIODCHANGEPASSWORD',pic:'ZZZ9',nv:0},{av:'AV26SecurityPolicyMinimumTimeToChangePasswords',fld:'vSECURITYPOLICYMINIMUMTIMETOCHANGEPASSWORDS',pic:'ZZZ9',nv:0},{av:'AV27SecurityPolicyMinimumLengthPassword',fld:'vSECURITYPOLICYMINIMUMLENGTHPASSWORD',pic:'Z9',nv:0},{av:'AV28SecurityPolicyMinimumNumericCharactersPassword',fld:'vSECURITYPOLICYMINIMUMNUMERICCHARACTERSPASSWORD',pic:'Z9',nv:0},{av:'AV29SecurityPolicyMinimumUpperCaseCharactersPassword',fld:'vSECURITYPOLICYMINIMUMUPPERCASECHARACTERSPASSWORD',pic:'Z9',nv:0},{av:'AV30SecurityPolicyMinimumSpecialCharactersPassword',fld:'vSECURITYPOLICYMINIMUMSPECIALCHARACTERSPASSWORD',pic:'Z9',nv:0},{av:'AV31SecurityPolicyMaximumPasswordHistoryEntries',fld:'vSECURITYPOLICYMAXIMUMPASSWORDHISTORYENTRIES',pic:'ZZZ9',nv:0},{av:'cmbavSecuritypolicyallowmultipleconcurrentwebsessions'},{av:'AV23SecurityPolicyAllowMultipleConcurrentWebSessions',fld:'vSECURITYPOLICYALLOWMULTIPLECONCURRENTWEBSESSIONS',pic:'9',nv:0},{av:'AV24SecurityPolicyWebSessionTimeout',fld:'vSECURITYPOLICYWEBSESSIONTIMEOUT',pic:'ZZZ9',nv:0},{av:'AV22SecurityPolicyOauthTokenExpire',fld:'vSECURITYPOLICYOAUTHTOKENEXPIRE',pic:'ZZZZZ9',nv:0},{av:'AV35SecurityPolicyOauthTokenMaximumRenovations',fld:'vSECURITYPOLICYOAUTHTOKENMAXIMUMRENOVATIONS',pic:'ZZZZZ9',nv:0}],oparms:[{av:'AV32SecurityPolicyId',fld:'vSECURITYPOLICYID',pic:'ZZZZZZZZ9',nv:0}]}");
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
         AV33SecurityPolicyGUID = "";
         GXKey = "";
         forbiddenHiddens = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         AV34SecurityPolicyName = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         hsh = "";
         AV20SecurityPolicy = new SdtGAMSecurityPolicy(context);
         AV7Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV6Error = new SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamsecuritypolicyentry__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamsecuritypolicyentry__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavSecuritypolicyid_Enabled = 0;
         edtavSecuritypolicyguid_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short AV25SecurityPolicyPeriodChangePassword ;
      private short AV26SecurityPolicyMinimumTimeToChangePasswords ;
      private short AV27SecurityPolicyMinimumLengthPassword ;
      private short AV28SecurityPolicyMinimumNumericCharactersPassword ;
      private short AV29SecurityPolicyMinimumUpperCaseCharactersPassword ;
      private short AV30SecurityPolicyMinimumSpecialCharactersPassword ;
      private short AV31SecurityPolicyMaximumPasswordHistoryEntries ;
      private short AV23SecurityPolicyAllowMultipleConcurrentWebSessions ;
      private short AV24SecurityPolicyWebSessionTimeout ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int AV32SecurityPolicyId ;
      private int edtavSecuritypolicyid_Enabled ;
      private int edtavSecuritypolicyguid_Enabled ;
      private int edtavSecuritypolicyname_Enabled ;
      private int edtavSecuritypolicyperiodchangepassword_Enabled ;
      private int edtavSecuritypolicyminimumtimetochangepasswords_Enabled ;
      private int edtavSecuritypolicyminimumlengthpassword_Enabled ;
      private int edtavSecuritypolicyminimumnumericcharacterspassword_Enabled ;
      private int edtavSecuritypolicyminimumuppercasecharacterspassword_Enabled ;
      private int edtavSecuritypolicyminimumspecialcharacterspassword_Enabled ;
      private int edtavSecuritypolicymaximumpasswordhistoryentries_Enabled ;
      private int edtavSecuritypolicywebsessiontimeout_Enabled ;
      private int AV22SecurityPolicyOauthTokenExpire ;
      private int edtavSecuritypolicyoauthtokenexpire_Enabled ;
      private int AV35SecurityPolicyOauthTokenMaximumRenovations ;
      private int edtavSecuritypolicyoauthtokenmaximumrenovations_Enabled ;
      private int bttBtnenter_Visible ;
      private int AV44GXV1 ;
      private int idxLst ;
      private long AV9Id ;
      private long wcpOAV9Id ;
      private String Gx_mode ;
      private String wcpOGx_mode ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String AV33SecurityPolicyGUID ;
      private String GXKey ;
      private String forbiddenHiddens ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String Dvpanel_unnamedtable1_Width ;
      private String Dvpanel_unnamedtable1_Cls ;
      private String Dvpanel_unnamedtable1_Title ;
      private String Dvpanel_unnamedtable1_Iconposition ;
      private String Dvpanel_onlyweb_Width ;
      private String Dvpanel_onlyweb_Cls ;
      private String Dvpanel_onlyweb_Title ;
      private String Dvpanel_onlyweb_Iconposition ;
      private String Dvpanel_onlysd_Width ;
      private String Dvpanel_onlysd_Cls ;
      private String Dvpanel_onlysd_Title ;
      private String Dvpanel_onlysd_Iconposition ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divTablecontent_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String edtavSecuritypolicyid_Internalname ;
      private String TempTags ;
      private String edtavSecuritypolicyid_Jsonclick ;
      private String edtavSecuritypolicyguid_Internalname ;
      private String edtavSecuritypolicyguid_Jsonclick ;
      private String edtavSecuritypolicyname_Internalname ;
      private String AV34SecurityPolicyName ;
      private String edtavSecuritypolicyname_Jsonclick ;
      private String divHtml_dvpanel_unnamedtable1_Internalname ;
      private String divLayout_unnamedtable1_Internalname ;
      private String divUnnamedtable1_Internalname ;
      private String edtavSecuritypolicyperiodchangepassword_Internalname ;
      private String edtavSecuritypolicyperiodchangepassword_Jsonclick ;
      private String edtavSecuritypolicyminimumtimetochangepasswords_Internalname ;
      private String edtavSecuritypolicyminimumtimetochangepasswords_Jsonclick ;
      private String edtavSecuritypolicyminimumlengthpassword_Internalname ;
      private String edtavSecuritypolicyminimumlengthpassword_Jsonclick ;
      private String edtavSecuritypolicyminimumnumericcharacterspassword_Internalname ;
      private String edtavSecuritypolicyminimumnumericcharacterspassword_Jsonclick ;
      private String edtavSecuritypolicyminimumuppercasecharacterspassword_Internalname ;
      private String edtavSecuritypolicyminimumuppercasecharacterspassword_Jsonclick ;
      private String edtavSecuritypolicyminimumspecialcharacterspassword_Internalname ;
      private String edtavSecuritypolicyminimumspecialcharacterspassword_Jsonclick ;
      private String edtavSecuritypolicymaximumpasswordhistoryentries_Internalname ;
      private String edtavSecuritypolicymaximumpasswordhistoryentries_Jsonclick ;
      private String divHtml_dvpanel_onlyweb_Internalname ;
      private String divLayout_onlyweb_Internalname ;
      private String divOnlyweb_Internalname ;
      private String cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Internalname ;
      private String cmbavSecuritypolicyallowmultipleconcurrentwebsessions_Jsonclick ;
      private String edtavSecuritypolicywebsessiontimeout_Internalname ;
      private String edtavSecuritypolicywebsessiontimeout_Jsonclick ;
      private String divHtml_dvpanel_onlysd_Internalname ;
      private String divLayout_onlysd_Internalname ;
      private String divOnlysd_Internalname ;
      private String edtavSecuritypolicyoauthtokenexpire_Internalname ;
      private String edtavSecuritypolicyoauthtokenexpire_Jsonclick ;
      private String edtavSecuritypolicyoauthtokenmaximumrenovations_Internalname ;
      private String edtavSecuritypolicyoauthtokenmaximumrenovations_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Caption ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String hsh ;
      private String Dvpanel_tableattributes_Internalname ;
      private String Dvpanel_unnamedtable1_Internalname ;
      private String Dvpanel_onlyweb_Internalname ;
      private String Dvpanel_onlysd_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool Dvpanel_unnamedtable1_Collapsible ;
      private bool Dvpanel_unnamedtable1_Collapsed ;
      private bool Dvpanel_unnamedtable1_Autowidth ;
      private bool Dvpanel_unnamedtable1_Autoheight ;
      private bool Dvpanel_unnamedtable1_Showcollapseicon ;
      private bool Dvpanel_unnamedtable1_Autoscroll ;
      private bool Dvpanel_onlyweb_Collapsible ;
      private bool Dvpanel_onlyweb_Collapsed ;
      private bool Dvpanel_onlyweb_Autowidth ;
      private bool Dvpanel_onlyweb_Autoheight ;
      private bool Dvpanel_onlyweb_Showcollapseicon ;
      private bool Dvpanel_onlyweb_Autoscroll ;
      private bool Dvpanel_onlysd_Collapsible ;
      private bool Dvpanel_onlysd_Collapsed ;
      private bool Dvpanel_onlysd_Autowidth ;
      private bool Dvpanel_onlysd_Autoheight ;
      private bool Dvpanel_onlysd_Showcollapseicon ;
      private bool Dvpanel_onlysd_Autoscroll ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavSecuritypolicyallowmultipleconcurrentwebsessions ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMError> AV7Errors ;
      private GXWebForm Form ;
      private SdtGAMError AV6Error ;
      private SdtGAMSecurityPolicy AV20SecurityPolicy ;
   }

   public class gamsecuritypolicyentry__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamsecuritypolicyentry__default : DataStoreHelperBase, IDataStoreHelper
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
