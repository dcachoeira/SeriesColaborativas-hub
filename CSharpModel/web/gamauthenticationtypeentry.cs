/*
               File: GAMAuthenticationTypeEntry
        Description: Authentication type
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:42:29.70
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
   public class gamauthenticationtypeentry : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamauthenticationtypeentry( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamauthenticationtypeentry( IGxContext context )
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
                           String aP1_Name ,
                           String aP2_TypeIdDsp )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV32Name = aP1_Name;
         this.AV35TypeIdDsp = aP2_TypeIdDsp;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavTypeid = new GXCombobox();
         cmbavFunctionid = new GXCombobox();
         chkavIsenable = new GXCheckbox();
         cmbavWsversion = new GXCombobox();
         cmbavWsserversecureprotocol = new GXCombobox();
         cmbavCusversion = new GXCombobox();
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
                  AV32Name = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
                  AV35TypeIdDsp = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35TypeIdDsp", AV35TypeIdDsp);
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
         PA102( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START102( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019423060", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamauthenticationtypeentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV32Name)) + "," + UrlEncode(StringUtil.RTrim(AV35TypeIdDsp))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "vTYPEIDDSP", StringUtil.RTrim( AV35TypeIdDsp));
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
         GxWebStd.gx_hidden_field( context, "DVPANEL_FB_Width", StringUtil.RTrim( Dvpanel_fb_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_FB_Cls", StringUtil.RTrim( Dvpanel_fb_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_FB_Title", StringUtil.RTrim( Dvpanel_fb_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_FB_Collapsible", StringUtil.BoolToStr( Dvpanel_fb_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_FB_Collapsed", StringUtil.BoolToStr( Dvpanel_fb_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_FB_Autowidth", StringUtil.BoolToStr( Dvpanel_fb_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_FB_Autoheight", StringUtil.BoolToStr( Dvpanel_fb_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_FB_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_fb_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_FB_Iconposition", StringUtil.RTrim( Dvpanel_fb_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_FB_Autoscroll", StringUtil.BoolToStr( Dvpanel_fb_Autoscroll));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TW_Width", StringUtil.RTrim( Dvpanel_tw_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TW_Cls", StringUtil.RTrim( Dvpanel_tw_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TW_Title", StringUtil.RTrim( Dvpanel_tw_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TW_Collapsible", StringUtil.BoolToStr( Dvpanel_tw_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TW_Collapsed", StringUtil.BoolToStr( Dvpanel_tw_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TW_Autowidth", StringUtil.BoolToStr( Dvpanel_tw_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TW_Autoheight", StringUtil.BoolToStr( Dvpanel_tw_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TW_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tw_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TW_Iconposition", StringUtil.RTrim( Dvpanel_tw_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TW_Autoscroll", StringUtil.BoolToStr( Dvpanel_tw_Autoscroll));
         GxWebStd.gx_hidden_field( context, "DVPANEL_WS_Width", StringUtil.RTrim( Dvpanel_ws_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_WS_Cls", StringUtil.RTrim( Dvpanel_ws_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_WS_Title", StringUtil.RTrim( Dvpanel_ws_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_WS_Collapsible", StringUtil.BoolToStr( Dvpanel_ws_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_WS_Collapsed", StringUtil.BoolToStr( Dvpanel_ws_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_WS_Autowidth", StringUtil.BoolToStr( Dvpanel_ws_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_WS_Autoheight", StringUtil.BoolToStr( Dvpanel_ws_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_WS_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_ws_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_WS_Iconposition", StringUtil.RTrim( Dvpanel_ws_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_WS_Autoscroll", StringUtil.BoolToStr( Dvpanel_ws_Autoscroll));
         GxWebStd.gx_hidden_field( context, "DVPANEL_EXT_Width", StringUtil.RTrim( Dvpanel_ext_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_EXT_Cls", StringUtil.RTrim( Dvpanel_ext_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_EXT_Title", StringUtil.RTrim( Dvpanel_ext_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_EXT_Collapsible", StringUtil.BoolToStr( Dvpanel_ext_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_EXT_Collapsed", StringUtil.BoolToStr( Dvpanel_ext_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_EXT_Autowidth", StringUtil.BoolToStr( Dvpanel_ext_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_EXT_Autoheight", StringUtil.BoolToStr( Dvpanel_ext_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_EXT_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_ext_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_EXT_Iconposition", StringUtil.RTrim( Dvpanel_ext_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_EXT_Autoscroll", StringUtil.BoolToStr( Dvpanel_ext_Autoscroll));
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
            WE102( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT102( ) ;
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
         return formatLink("gamauthenticationtypeentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV32Name)) + "," + UrlEncode(StringUtil.RTrim(AV35TypeIdDsp)) ;
      }

      public override String GetPgmname( )
      {
         return "GAMAuthenticationTypeEntry" ;
      }

      public override String GetPgmdesc( )
      {
         return "Authentication type" ;
      }

      protected void WB100( )
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
            GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavTypeid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavTypeid_Internalname, "Type", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavTypeid, cmbavTypeid_Internalname, StringUtil.RTrim( AV34TypeId), 1, cmbavTypeid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavTypeid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,25);\"", "", true, "HLP_GAMAuthenticationTypeEntry.htm");
            cmbavTypeid.CurrentValue = StringUtil.RTrim( AV34TypeId);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTypeid_Internalname, "Values", (String)(cmbavTypeid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavName_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavName_Internalname, StringUtil.RTrim( AV32Name), StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavName_Enabled, 0, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavFunctionid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavFunctionid_Internalname, "Function", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavFunctionid, cmbavFunctionid_Internalname, StringUtil.RTrim( AV26FunctionId), 1, cmbavFunctionid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavFunctionid.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "", true, "HLP_GAMAuthenticationTypeEntry.htm");
            cmbavFunctionid.CurrentValue = StringUtil.RTrim( AV26FunctionId);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavFunctionid_Internalname, "Values", (String)(cmbavFunctionid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavDsc_Internalname, "Description", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDsc_Internalname, StringUtil.RTrim( AV23Dsc), StringUtil.RTrim( context.localUtil.Format( AV23Dsc, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavDsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionMedium", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavIsenable_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavIsenable_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavIsenable_Internalname, StringUtil.BoolToStr( AV31IsEnable), "", " ", 1, chkavIsenable.Enabled, "true", "Enabled?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(43, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,43);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavAdditionalscope_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAdditionalscope_Internalname, "Additional Scope", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavAdditionalscope_Internalname, AV5AdditionalScope, StringUtil.RTrim( context.localUtil.Format( AV5AdditionalScope, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,47);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavAdditionalscope_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavAdditionalscope_Enabled, 0, "text", "", 80, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTblfacebook_Internalname, 1, 0, "px", 0, "px", "Table100x100", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_fb_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_FBContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_FBContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_fb_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFb_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientid_Internalname, "Client Id.", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientid_Internalname, AV14ClientId, StringUtil.RTrim( context.localUtil.Format( AV14ClientId, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavClientid_Enabled, 0, "text", "", 80, "chr", 1, "row", 400, 0, 0, 0, 1, -1, 0, true, "GAMPropertyValue", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavClientsecret_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClientsecret_Internalname, "Client secret", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClientsecret_Internalname, AV15ClientSecret, StringUtil.RTrim( context.localUtil.Format( AV15ClientSecret, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClientsecret_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavClientsecret_Enabled, 0, "text", "", 80, "chr", 1, "row", 400, 0, 0, 0, 1, -1, 0, true, "GAMPropertyValue", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSiteurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSiteurl_Internalname, "Site URL", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSiteurl_Internalname, AV33SiteURL, StringUtil.RTrim( context.localUtil.Format( AV33SiteURL, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSiteurl_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSiteurl_Enabled, 0, "text", "", 80, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavImpersonate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavImpersonate_Internalname, "Impersonate", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavImpersonate_Internalname, StringUtil.RTrim( AV30Impersonate), StringUtil.RTrim( context.localUtil.Format( AV30Impersonate, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavImpersonate_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavImpersonate_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GAMAuthenticationTypeName", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGamrserverurl_cell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGamrserverurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGamrserverurl_Internalname, "Remote Server URL", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGamrserverurl_Internalname, AV29GAMRServerURL, StringUtil.RTrim( context.localUtil.Format( AV29GAMRServerURL, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,81);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGamrserverurl_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGamrserverurl_Enabled, 0, "text", "", 0, "px", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGamrprivateencryptkey_cell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGamrprivateencryptkey_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGamrprivateencryptkey_Internalname, "Private Encryption Key", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGamrprivateencryptkey_Internalname, StringUtil.RTrim( AV27GAMRPrivateEncryptKey), StringUtil.RTrim( context.localUtil.Format( AV27GAMRPrivateEncryptKey, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,85);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGamrprivateencryptkey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGamrprivateencryptkey_Enabled, 0, "text", "", 32, "chr", 1, "row", 32, 0, 0, 0, 1, -1, 0, true, "GAMEncryptionKey", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGamrrepositoryguid_cell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGamrrepositoryguid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGamrrepositoryguid_Internalname, "GUID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGamrrepositoryguid_Internalname, StringUtil.RTrim( AV28GAMRRepositoryGUID), StringUtil.RTrim( context.localUtil.Format( AV28GAMRRepositoryGUID, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,90);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGamrrepositoryguid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGamrrepositoryguid_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GAMGUID", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
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
            GxWebStd.gx_div_start( context, divTbltwitter_Internalname, 1, 0, "px", 0, "px", "Table100x100", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tw_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_TWContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TWContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tw_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTw_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConsumerkey_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConsumerkey_Internalname, "Consumer key", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConsumerkey_Internalname, StringUtil.RTrim( AV16ConsumerKey), StringUtil.RTrim( context.localUtil.Format( AV16ConsumerKey, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,106);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConsumerkey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavConsumerkey_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConsumersecret_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConsumersecret_Internalname, "Consumer secret", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 110,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConsumersecret_Internalname, StringUtil.RTrim( AV17ConsumerSecret), StringUtil.RTrim( context.localUtil.Format( AV17ConsumerSecret, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,110);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConsumersecret_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavConsumersecret_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCallbackurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCallbackurl_Internalname, "Callback URL", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCallbackurl_Internalname, AV13CallbackURL, StringUtil.RTrim( context.localUtil.Format( AV13CallbackURL, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,115);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCallbackurl_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCallbackurl_Enabled, 0, "text", "", 80, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
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
            GxWebStd.gx_div_start( context, divTblwebservice_Internalname, 1, 0, "px", 0, "px", "Table100x100", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_ws_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_WSContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_WSContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_ws_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divWs_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavWsversion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavWsversion_Internalname, "Web service version", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 131,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavWsversion, cmbavWsversion_Internalname, StringUtil.RTrim( AV45WSVersion), 1, cmbavWsversion_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavWsversion.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,131);\"", "", true, "HLP_GAMAuthenticationTypeEntry.htm");
            cmbavWsversion.CurrentValue = StringUtil.RTrim( AV45WSVersion);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavWsversion_Internalname, "Values", (String)(cmbavWsversion.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWsimpersonate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsimpersonate_Internalname, "Impersonate", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 135,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsimpersonate_Internalname, StringUtil.RTrim( AV47WSImpersonate), StringUtil.RTrim( context.localUtil.Format( AV47WSImpersonate, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,135);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsimpersonate_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWsimpersonate_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GAMAuthenticationTypeName", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedwsprivateencryptkey_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockwsprivateencryptkey_Internalname, "Private encription key", "", "", lblTextblockwsprivateencryptkey_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_143_102( true) ;
         }
         else
         {
            wb_table1_143_102( false) ;
         }
         return  ;
      }

      protected void wb_table1_143_102e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWsservername_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsservername_Internalname, "Server name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 153,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsservername_Internalname, StringUtil.RTrim( AV41WSServerName), StringUtil.RTrim( context.localUtil.Format( AV41WSServerName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,153);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsservername_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWsservername_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionMedium", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWsserverport_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsserverport_Internalname, "Server port", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 158,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsserverport_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42WSServerPort), 5, 0, ",", "")), ((edtavWsserverport_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV42WSServerPort), "ZZZZ9")) : context.localUtil.Format( (decimal)(AV42WSServerPort), "ZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,158);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsserverport_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWsserverport_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWsserverbaseurl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsserverbaseurl_Internalname, "Base URL", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 162,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsserverbaseurl_Internalname, AV40WSServerBaseURL, StringUtil.RTrim( context.localUtil.Format( AV40WSServerBaseURL, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,162);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsserverbaseurl_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWsserverbaseurl_Enabled, 0, "text", "", 80, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavWsserversecureprotocol_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavWsserversecureprotocol_Internalname, "Secure protocol", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 167,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavWsserversecureprotocol, cmbavWsserversecureprotocol_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV43WSServerSecureProtocol), 1, 0)), 1, cmbavWsserversecureprotocol_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavWsserversecureprotocol.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,167);\"", "", true, "HLP_GAMAuthenticationTypeEntry.htm");
            cmbavWsserversecureprotocol.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV43WSServerSecureProtocol), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavWsserversecureprotocol_Internalname, "Values", (String)(cmbavWsserversecureprotocol.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWstimeout_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWstimeout_Internalname, "Timeout", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 171,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWstimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV44WSTimeout), 5, 0, ",", "")), ((edtavWstimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV44WSTimeout), "ZZZZ9")) : context.localUtil.Format( (decimal)(AV44WSTimeout), "ZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,171);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWstimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWstimeout_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWspackage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWspackage_Internalname, "Web service package", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 176,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWspackage_Internalname, StringUtil.RTrim( AV38WSPackage), StringUtil.RTrim( context.localUtil.Format( AV38WSPackage, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,176);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWspackage_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWspackage_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionMedium", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWsname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsname_Internalname, "Web service name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 180,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsname_Internalname, StringUtil.RTrim( AV37WSName), StringUtil.RTrim( context.localUtil.Format( AV37WSName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,180);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWsname_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionMedium", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavWsextension_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsextension_Internalname, "Web service extension", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 185,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsextension_Internalname, StringUtil.RTrim( AV36WSExtension), StringUtil.RTrim( context.localUtil.Format( AV36WSExtension, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,185);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsextension_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWsextension_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionMedium", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
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
            GxWebStd.gx_div_start( context, divTblexternal_Internalname, 1, 0, "px", 0, "px", "Table100x100", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_ext_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_EXTContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_EXTContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_ext_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divExt_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavCusversion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCusversion_Internalname, "JSON version", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 201,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCusversion, cmbavCusversion_Internalname, StringUtil.RTrim( AV22CusVersion), 1, cmbavCusversion_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavCusversion.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,201);\"", "", true, "HLP_GAMAuthenticationTypeEntry.htm");
            cmbavCusversion.CurrentValue = StringUtil.RTrim( AV22CusVersion);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCusversion_Internalname, "Values", (String)(cmbavCusversion.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCusimpersonate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusimpersonate_Internalname, "Impersonate", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 205,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusimpersonate_Internalname, StringUtil.RTrim( AV46CusImpersonate), StringUtil.RTrim( context.localUtil.Format( AV46CusImpersonate, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,205);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusimpersonate_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCusimpersonate_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GAMAuthenticationTypeName", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedcusprivateencryptkey_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockcusprivateencryptkey_Internalname, "Private encription key", "", "", lblTextblockcusprivateencryptkey_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table2_213_102( true) ;
         }
         else
         {
            wb_table2_213_102( false) ;
         }
         return  ;
      }

      protected void wb_table2_213_102e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCusfilename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusfilename_Internalname, "File name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 223,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusfilename_Internalname, StringUtil.RTrim( AV19CusFileName), StringUtil.RTrim( context.localUtil.Format( AV19CusFileName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,223);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusfilename_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCusfilename_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionMedium", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCuspackage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCuspackage_Internalname, "Package", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 228,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCuspackage_Internalname, StringUtil.RTrim( AV20CusPackage), StringUtil.RTrim( context.localUtil.Format( AV20CusPackage, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,228);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCuspackage_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCuspackage_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionMedium", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavCusclassname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusclassname_Internalname, "Class name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 232,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusclassname_Internalname, StringUtil.RTrim( AV18CusClassName), StringUtil.RTrim( context.localUtil.Format( AV18CusClassName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,232);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusclassname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCusclassname_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionMedium", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 237,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "Confirmar", bttBtnenter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 239,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Fechar", bttBtncancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMAuthenticationTypeEntry.htm");
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

      protected void START102( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Authentication type", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP100( ) ;
      }

      protected void WS102( )
      {
         START102( ) ;
         EVT102( ) ;
      }

      protected void EVT102( )
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
                              E11102 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOGENKEYCUSTOM'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoGenKeyCustom' */
                              E12102 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOGENKEY'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoGenKey' */
                              E13102 ();
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
                                    E14102 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E15102 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E16102 ();
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

      protected void WE102( )
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

      protected void PA102( )
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
            cmbavTypeid.Name = "vTYPEID";
            cmbavTypeid.WebTags = "";
            cmbavTypeid.addItem("Custom", "Custom", 0);
            cmbavTypeid.addItem("ExternalWebService", "External Web Service", 0);
            cmbavTypeid.addItem("Facebook", "Facebook", 0);
            cmbavTypeid.addItem("GAMLocal", "GAM Local", 0);
            cmbavTypeid.addItem("GAMRemote", "GAM Remote", 0);
            cmbavTypeid.addItem("Google", "Google", 0);
            cmbavTypeid.addItem("Twitter", "Twitter", 0);
            if ( cmbavTypeid.ItemCount > 0 )
            {
               AV34TypeId = cmbavTypeid.getValidValue(AV34TypeId);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TypeId", AV34TypeId);
            }
            cmbavFunctionid.Name = "vFUNCTIONID";
            cmbavFunctionid.WebTags = "";
            cmbavFunctionid.addItem("AuthenticationAndRoles", "Authentication and Roles", 0);
            cmbavFunctionid.addItem("OnlyAuthentication", "Only Authentication", 0);
            if ( cmbavFunctionid.ItemCount > 0 )
            {
               AV26FunctionId = cmbavFunctionid.getValidValue(AV26FunctionId);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26FunctionId", AV26FunctionId);
            }
            chkavIsenable.Name = "vISENABLE";
            chkavIsenable.WebTags = "";
            chkavIsenable.Caption = "Enabled?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsenable_Internalname, "TitleCaption", chkavIsenable.Caption, true);
            chkavIsenable.CheckedValue = "false";
            cmbavWsversion.Name = "vWSVERSION";
            cmbavWsversion.WebTags = "";
            cmbavWsversion.addItem("GAM10", "Version 1.0", 0);
            cmbavWsversion.addItem("GAM20", "Version 2.0", 0);
            if ( cmbavWsversion.ItemCount > 0 )
            {
               AV45WSVersion = cmbavWsversion.getValidValue(AV45WSVersion);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45WSVersion", AV45WSVersion);
            }
            cmbavWsserversecureprotocol.Name = "vWSSERVERSECUREPROTOCOL";
            cmbavWsserversecureprotocol.WebTags = "";
            cmbavWsserversecureprotocol.addItem("0", "No", 0);
            cmbavWsserversecureprotocol.addItem("1", "Yes", 0);
            if ( cmbavWsserversecureprotocol.ItemCount > 0 )
            {
               AV43WSServerSecureProtocol = (short)(NumberUtil.Val( cmbavWsserversecureprotocol.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV43WSServerSecureProtocol), 1, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43WSServerSecureProtocol", StringUtil.Str( (decimal)(AV43WSServerSecureProtocol), 1, 0));
            }
            cmbavCusversion.Name = "vCUSVERSION";
            cmbavCusversion.WebTags = "";
            cmbavCusversion.addItem("GAM10", "Version 1.0", 0);
            cmbavCusversion.addItem("GAM20", "Version 2.0", 0);
            if ( cmbavCusversion.ItemCount > 0 )
            {
               AV22CusVersion = cmbavCusversion.getValidValue(AV22CusVersion);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22CusVersion", AV22CusVersion);
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
               GX_FocusControl = cmbavTypeid_Internalname;
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
         if ( cmbavTypeid.ItemCount > 0 )
         {
            AV34TypeId = cmbavTypeid.getValidValue(AV34TypeId);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TypeId", AV34TypeId);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavTypeid.CurrentValue = StringUtil.RTrim( AV34TypeId);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTypeid_Internalname, "Values", cmbavTypeid.ToJavascriptSource(), true);
         }
         if ( cmbavFunctionid.ItemCount > 0 )
         {
            AV26FunctionId = cmbavFunctionid.getValidValue(AV26FunctionId);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26FunctionId", AV26FunctionId);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavFunctionid.CurrentValue = StringUtil.RTrim( AV26FunctionId);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavFunctionid_Internalname, "Values", cmbavFunctionid.ToJavascriptSource(), true);
         }
         if ( cmbavWsversion.ItemCount > 0 )
         {
            AV45WSVersion = cmbavWsversion.getValidValue(AV45WSVersion);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45WSVersion", AV45WSVersion);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavWsversion.CurrentValue = StringUtil.RTrim( AV45WSVersion);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavWsversion_Internalname, "Values", cmbavWsversion.ToJavascriptSource(), true);
         }
         if ( cmbavWsserversecureprotocol.ItemCount > 0 )
         {
            AV43WSServerSecureProtocol = (short)(NumberUtil.Val( cmbavWsserversecureprotocol.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV43WSServerSecureProtocol), 1, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43WSServerSecureProtocol", StringUtil.Str( (decimal)(AV43WSServerSecureProtocol), 1, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavWsserversecureprotocol.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV43WSServerSecureProtocol), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavWsserversecureprotocol_Internalname, "Values", cmbavWsserversecureprotocol.ToJavascriptSource(), true);
         }
         if ( cmbavCusversion.ItemCount > 0 )
         {
            AV22CusVersion = cmbavCusversion.getValidValue(AV22CusVersion);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22CusVersion", AV22CusVersion);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCusversion.CurrentValue = StringUtil.RTrim( AV22CusVersion);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCusversion_Internalname, "Values", cmbavCusversion.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF102( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF102( )
      {
         initialize_formulas( ) ;
         /* Execute user event: Refresh */
         E15102 ();
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E16102 ();
            WB100( ) ;
         }
      }

      protected void send_integrity_lvl_hashes102( )
      {
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void STRUP100( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11102 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbavTypeid.CurrentValue = cgiGet( cmbavTypeid_Internalname);
            AV34TypeId = cgiGet( cmbavTypeid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TypeId", AV34TypeId);
            cmbavFunctionid.CurrentValue = cgiGet( cmbavFunctionid_Internalname);
            AV26FunctionId = cgiGet( cmbavFunctionid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26FunctionId", AV26FunctionId);
            AV23Dsc = cgiGet( edtavDsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23Dsc", AV23Dsc);
            AV31IsEnable = StringUtil.StrToBool( cgiGet( chkavIsenable_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31IsEnable", AV31IsEnable);
            AV5AdditionalScope = cgiGet( edtavAdditionalscope_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5AdditionalScope", AV5AdditionalScope);
            AV14ClientId = cgiGet( edtavClientid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ClientId", AV14ClientId);
            AV15ClientSecret = cgiGet( edtavClientsecret_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ClientSecret", AV15ClientSecret);
            AV33SiteURL = cgiGet( edtavSiteurl_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33SiteURL", AV33SiteURL);
            AV30Impersonate = cgiGet( edtavImpersonate_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30Impersonate", AV30Impersonate);
            AV29GAMRServerURL = cgiGet( edtavGamrserverurl_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GAMRServerURL", AV29GAMRServerURL);
            AV27GAMRPrivateEncryptKey = cgiGet( edtavGamrprivateencryptkey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GAMRPrivateEncryptKey", AV27GAMRPrivateEncryptKey);
            AV28GAMRRepositoryGUID = cgiGet( edtavGamrrepositoryguid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GAMRRepositoryGUID", AV28GAMRRepositoryGUID);
            AV16ConsumerKey = cgiGet( edtavConsumerkey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ConsumerKey", AV16ConsumerKey);
            AV17ConsumerSecret = cgiGet( edtavConsumersecret_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ConsumerSecret", AV17ConsumerSecret);
            AV13CallbackURL = cgiGet( edtavCallbackurl_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13CallbackURL", AV13CallbackURL);
            cmbavWsversion.CurrentValue = cgiGet( cmbavWsversion_Internalname);
            AV45WSVersion = cgiGet( cmbavWsversion_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45WSVersion", AV45WSVersion);
            AV47WSImpersonate = cgiGet( edtavWsimpersonate_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47WSImpersonate", AV47WSImpersonate);
            AV39WSPrivateEncryptKey = cgiGet( edtavWsprivateencryptkey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39WSPrivateEncryptKey", AV39WSPrivateEncryptKey);
            AV41WSServerName = cgiGet( edtavWsservername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41WSServerName", AV41WSServerName);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavWsserverport_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavWsserverport_Internalname), ",", ".") > Convert.ToDecimal( 99999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vWSSERVERPORT");
               GX_FocusControl = edtavWsserverport_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV42WSServerPort = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42WSServerPort", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42WSServerPort), 5, 0)));
            }
            else
            {
               AV42WSServerPort = (int)(context.localUtil.CToN( cgiGet( edtavWsserverport_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42WSServerPort", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42WSServerPort), 5, 0)));
            }
            AV40WSServerBaseURL = cgiGet( edtavWsserverbaseurl_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40WSServerBaseURL", AV40WSServerBaseURL);
            cmbavWsserversecureprotocol.CurrentValue = cgiGet( cmbavWsserversecureprotocol_Internalname);
            AV43WSServerSecureProtocol = (short)(NumberUtil.Val( cgiGet( cmbavWsserversecureprotocol_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43WSServerSecureProtocol", StringUtil.Str( (decimal)(AV43WSServerSecureProtocol), 1, 0));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavWstimeout_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavWstimeout_Internalname), ",", ".") > Convert.ToDecimal( 99999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vWSTIMEOUT");
               GX_FocusControl = edtavWstimeout_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV44WSTimeout = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44WSTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44WSTimeout), 5, 0)));
            }
            else
            {
               AV44WSTimeout = (int)(context.localUtil.CToN( cgiGet( edtavWstimeout_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44WSTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44WSTimeout), 5, 0)));
            }
            AV38WSPackage = cgiGet( edtavWspackage_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38WSPackage", AV38WSPackage);
            AV37WSName = cgiGet( edtavWsname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37WSName", AV37WSName);
            AV36WSExtension = cgiGet( edtavWsextension_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36WSExtension", AV36WSExtension);
            cmbavCusversion.CurrentValue = cgiGet( cmbavCusversion_Internalname);
            AV22CusVersion = cgiGet( cmbavCusversion_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22CusVersion", AV22CusVersion);
            AV46CusImpersonate = cgiGet( edtavCusimpersonate_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46CusImpersonate", AV46CusImpersonate);
            AV21CusPrivateEncryptKey = cgiGet( edtavCusprivateencryptkey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21CusPrivateEncryptKey", AV21CusPrivateEncryptKey);
            AV19CusFileName = cgiGet( edtavCusfilename_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19CusFileName", AV19CusFileName);
            AV20CusPackage = cgiGet( edtavCuspackage_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20CusPackage", AV20CusPackage);
            AV18CusClassName = cgiGet( edtavCusclassname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18CusClassName", AV18CusClassName);
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
            Dvpanel_fb_Width = cgiGet( "DVPANEL_FB_Width");
            Dvpanel_fb_Cls = cgiGet( "DVPANEL_FB_Cls");
            Dvpanel_fb_Title = cgiGet( "DVPANEL_FB_Title");
            Dvpanel_fb_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_FB_Collapsible"));
            Dvpanel_fb_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_FB_Collapsed"));
            Dvpanel_fb_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_FB_Autowidth"));
            Dvpanel_fb_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_FB_Autoheight"));
            Dvpanel_fb_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_FB_Showcollapseicon"));
            Dvpanel_fb_Iconposition = cgiGet( "DVPANEL_FB_Iconposition");
            Dvpanel_fb_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_FB_Autoscroll"));
            Dvpanel_tw_Width = cgiGet( "DVPANEL_TW_Width");
            Dvpanel_tw_Cls = cgiGet( "DVPANEL_TW_Cls");
            Dvpanel_tw_Title = cgiGet( "DVPANEL_TW_Title");
            Dvpanel_tw_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TW_Collapsible"));
            Dvpanel_tw_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TW_Collapsed"));
            Dvpanel_tw_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TW_Autowidth"));
            Dvpanel_tw_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TW_Autoheight"));
            Dvpanel_tw_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TW_Showcollapseicon"));
            Dvpanel_tw_Iconposition = cgiGet( "DVPANEL_TW_Iconposition");
            Dvpanel_tw_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TW_Autoscroll"));
            Dvpanel_ws_Width = cgiGet( "DVPANEL_WS_Width");
            Dvpanel_ws_Cls = cgiGet( "DVPANEL_WS_Cls");
            Dvpanel_ws_Title = cgiGet( "DVPANEL_WS_Title");
            Dvpanel_ws_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_WS_Collapsible"));
            Dvpanel_ws_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_WS_Collapsed"));
            Dvpanel_ws_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_WS_Autowidth"));
            Dvpanel_ws_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_WS_Autoheight"));
            Dvpanel_ws_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_WS_Showcollapseicon"));
            Dvpanel_ws_Iconposition = cgiGet( "DVPANEL_WS_Iconposition");
            Dvpanel_ws_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_WS_Autoscroll"));
            Dvpanel_ext_Width = cgiGet( "DVPANEL_EXT_Width");
            Dvpanel_ext_Cls = cgiGet( "DVPANEL_EXT_Cls");
            Dvpanel_ext_Title = cgiGet( "DVPANEL_EXT_Title");
            Dvpanel_ext_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_EXT_Collapsible"));
            Dvpanel_ext_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_EXT_Collapsed"));
            Dvpanel_ext_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_EXT_Autowidth"));
            Dvpanel_ext_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_EXT_Autoheight"));
            Dvpanel_ext_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_EXT_Showcollapseicon"));
            Dvpanel_ext_Iconposition = cgiGet( "DVPANEL_EXT_Iconposition");
            Dvpanel_ext_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_EXT_Autoscroll"));
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
         E11102 ();
         if (returnInSub) return;
      }

      protected void E11102( )
      {
         /* Start Routine */
         if ( 1 == 2 )
         {
         }
      }

      protected void E12102( )
      {
         /* 'DoGenKeyCustom' Routine */
         AV21CusPrivateEncryptKey = Crypto.GetEncryptionKey( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21CusPrivateEncryptKey", AV21CusPrivateEncryptKey);
         /*  Sending Event outputs  */
      }

      protected void E13102( )
      {
         /* 'DoGenKey' Routine */
         AV39WSPrivateEncryptKey = Crypto.GetEncryptionKey( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39WSPrivateEncryptKey", AV39WSPrivateEncryptKey);
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E14102 ();
         if (returnInSub) return;
      }

      protected void E14102( )
      {
         /* Enter Routine */
         new log(context ).execute(  "1") ;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) )
         {
            if ( StringUtil.StrCmp(AV34TypeId, "GAMLocal") == 0 )
            {
               AV10AuthenticationTypeLocal.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV10AuthenticationTypeLocal.gxTpr_Name = AV32Name;
               AV10AuthenticationTypeLocal.gxTpr_Functionid = AV26FunctionId;
               AV10AuthenticationTypeLocal.gxTpr_Isenable = AV31IsEnable;
               AV10AuthenticationTypeLocal.gxTpr_Description = AV23Dsc;
               AV10AuthenticationTypeLocal.save();
            }
            else if ( StringUtil.StrCmp(AV34TypeId, "Facebook") == 0 )
            {
               new log(context ).execute(  "1") ;
               AV7AuthenticationTypeFacebook.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV7AuthenticationTypeFacebook.gxTpr_Name = AV32Name;
               AV7AuthenticationTypeFacebook.gxTpr_Isenable = AV31IsEnable;
               AV7AuthenticationTypeFacebook.gxTpr_Description = AV23Dsc;
               AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Clientid = AV14ClientId;
               AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Clientsecret = AV15ClientSecret;
               AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Siteurl = AV33SiteURL;
               AV7AuthenticationTypeFacebook.gxTpr_Facebook.gxTpr_Additionalscope = AV5AdditionalScope;
               AV7AuthenticationTypeFacebook.save();
               new log(context ).execute(  "2") ;
            }
            else if ( StringUtil.StrCmp(AV34TypeId, "Google") == 0 )
            {
               AV9AuthenticationTypeGoogle.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV9AuthenticationTypeGoogle.gxTpr_Name = AV32Name;
               AV9AuthenticationTypeGoogle.gxTpr_Isenable = AV31IsEnable;
               AV9AuthenticationTypeGoogle.gxTpr_Description = AV23Dsc;
               AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Clientid = AV14ClientId;
               AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Clientsecret = AV15ClientSecret;
               AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Siteurl = AV33SiteURL;
               AV9AuthenticationTypeGoogle.gxTpr_Google.gxTpr_Additionalscope = AV5AdditionalScope;
               AV9AuthenticationTypeGoogle.save();
            }
            else if ( StringUtil.StrCmp(AV34TypeId, "GAMRemote") == 0 )
            {
               AV8AuthenticationTypeGAMRemote.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV8AuthenticationTypeGAMRemote.gxTpr_Name = AV32Name;
               AV8AuthenticationTypeGAMRemote.gxTpr_Functionid = AV26FunctionId;
               AV8AuthenticationTypeGAMRemote.gxTpr_Isenable = AV31IsEnable;
               AV8AuthenticationTypeGAMRemote.gxTpr_Description = AV23Dsc;
               AV8AuthenticationTypeGAMRemote.gxTpr_Impersonate = AV30Impersonate;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Clientid = AV14ClientId;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Clientsecret = AV15ClientSecret;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Siteurl = AV33SiteURL;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Additionalscope = AV5AdditionalScope;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Remoteserverurl = AV29GAMRServerURL;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Remoteserverkey = AV27GAMRPrivateEncryptKey;
               AV8AuthenticationTypeGAMRemote.gxTpr_Gamremote.gxTpr_Remoterepositoryguid = AV28GAMRRepositoryGUID;
               AV8AuthenticationTypeGAMRemote.save();
            }
            else if ( StringUtil.StrCmp(AV34TypeId, "Twitter") == 0 )
            {
               AV11AuthenticationTypeTwitter.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV11AuthenticationTypeTwitter.gxTpr_Name = AV32Name;
               AV11AuthenticationTypeTwitter.gxTpr_Isenable = AV31IsEnable;
               AV11AuthenticationTypeTwitter.gxTpr_Description = AV23Dsc;
               AV11AuthenticationTypeTwitter.gxTpr_Twitter.gxTpr_Consumerkey = AV16ConsumerKey;
               AV11AuthenticationTypeTwitter.gxTpr_Twitter.gxTpr_Consumersecret = AV17ConsumerSecret;
               AV11AuthenticationTypeTwitter.gxTpr_Twitter.gxTpr_Callbackurl = AV13CallbackURL;
               AV11AuthenticationTypeTwitter.gxTpr_Twitter.gxTpr_Additionalscope = AV5AdditionalScope;
               AV11AuthenticationTypeTwitter.save();
            }
            else if ( StringUtil.StrCmp(AV34TypeId, "ExternalWebService") == 0 )
            {
               cmbavFunctionid.Enabled = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavFunctionid.Enabled), 5, 0)), true);
               AV12AuthenticationTypeWebService.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV12AuthenticationTypeWebService.gxTpr_Name = AV32Name;
               AV12AuthenticationTypeWebService.gxTpr_Functionid = AV26FunctionId;
               AV12AuthenticationTypeWebService.gxTpr_Isenable = AV31IsEnable;
               AV12AuthenticationTypeWebService.gxTpr_Description = AV23Dsc;
               AV12AuthenticationTypeWebService.gxTpr_Impersonate = AV47WSImpersonate;
               AV12AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Version = AV45WSVersion;
               AV12AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Privateencryptkey = AV39WSPrivateEncryptKey;
               AV12AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Timeout = AV44WSTimeout;
               AV12AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Package = AV38WSPackage;
               AV12AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Name = AV37WSName;
               AV12AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Extension = AV36WSExtension;
               AV12AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Server.gxTpr_Name = AV41WSServerName;
               AV12AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Server.gxTpr_Port = AV42WSServerPort;
               AV12AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Server.gxTpr_Baseurl = AV40WSServerBaseURL;
               AV12AuthenticationTypeWebService.gxTpr_Webservice.gxTpr_Server.gxTpr_Secureprotocol = AV43WSServerSecureProtocol;
               AV12AuthenticationTypeWebService.save();
            }
            else if ( StringUtil.StrCmp(AV34TypeId, "Custom") == 0 )
            {
               cmbavFunctionid.Enabled = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavFunctionid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavFunctionid.Enabled), 5, 0)), true);
               AV6AuthenticationTypeCustom.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV6AuthenticationTypeCustom.gxTpr_Name = AV32Name;
               AV6AuthenticationTypeCustom.gxTpr_Functionid = AV26FunctionId;
               AV6AuthenticationTypeCustom.gxTpr_Isenable = AV31IsEnable;
               AV6AuthenticationTypeCustom.gxTpr_Description = AV23Dsc;
               AV6AuthenticationTypeCustom.gxTpr_Impersonate = AV46CusImpersonate;
               AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Version = AV22CusVersion;
               AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Privateencryptkey = AV21CusPrivateEncryptKey;
               AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Filename = AV19CusFileName;
               AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Package = AV20CusPackage;
               AV6AuthenticationTypeCustom.gxTpr_Custom.gxTpr_Classname = AV18CusClassName;
               AV6AuthenticationTypeCustom.save();
            }
         }
         else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            if ( StringUtil.StrCmp(AV34TypeId, "GAMLocal") == 0 )
            {
               AV10AuthenticationTypeLocal.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV10AuthenticationTypeLocal.delete();
            }
            else if ( StringUtil.StrCmp(AV34TypeId, "Facebook") == 0 )
            {
               AV7AuthenticationTypeFacebook.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV7AuthenticationTypeFacebook.delete();
            }
            else if ( StringUtil.StrCmp(AV34TypeId, "Google") == 0 )
            {
               AV9AuthenticationTypeGoogle.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV9AuthenticationTypeGoogle.delete();
            }
            else if ( StringUtil.StrCmp(AV34TypeId, "Twitter") == 0 )
            {
               AV11AuthenticationTypeTwitter.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV11AuthenticationTypeTwitter.delete();
            }
            else if ( StringUtil.StrCmp(AV34TypeId, "ExternalWebService") == 0 )
            {
               AV12AuthenticationTypeWebService.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV12AuthenticationTypeWebService.delete();
            }
            else if ( StringUtil.StrCmp(AV34TypeId, "Custom") == 0 )
            {
               AV6AuthenticationTypeCustom.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV6AuthenticationTypeCustom.delete();
            }
            else if ( StringUtil.StrCmp(AV34TypeId, "GAMRemote") == 0 )
            {
               AV8AuthenticationTypeGAMRemote.load( AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
               AV8AuthenticationTypeGAMRemote.delete();
            }
         }
         new log(context ).execute(  "3") ;
         if ( StringUtil.StrCmp(AV34TypeId, "GAMLocal") == 0 )
         {
            if ( AV10AuthenticationTypeLocal.success() )
            {
               pr_gam.commit( "GAMAuthenticationTypeEntry");
               pr_default.commit( "GAMAuthenticationTypeEntry");
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(AV34TypeId, "Facebook") == 0 )
         {
            new log(context ).execute(  "4") ;
            if ( AV7AuthenticationTypeFacebook.success() )
            {
               new log(context ).execute(  "5") ;
               pr_gam.commit( "GAMAuthenticationTypeEntry");
               pr_default.commit( "GAMAuthenticationTypeEntry");
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(AV34TypeId, "Google") == 0 )
         {
            if ( AV9AuthenticationTypeGoogle.success() )
            {
               pr_gam.commit( "GAMAuthenticationTypeEntry");
               pr_default.commit( "GAMAuthenticationTypeEntry");
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(AV34TypeId, "Twitter") == 0 )
         {
            if ( AV11AuthenticationTypeTwitter.success() )
            {
               pr_gam.commit( "GAMAuthenticationTypeEntry");
               pr_default.commit( "GAMAuthenticationTypeEntry");
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(AV34TypeId, "ExternalWebService") == 0 )
         {
            if ( AV12AuthenticationTypeWebService.success() )
            {
               pr_gam.commit( "GAMAuthenticationTypeEntry");
               pr_default.commit( "GAMAuthenticationTypeEntry");
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(AV34TypeId, "Custom") == 0 )
         {
            if ( AV6AuthenticationTypeCustom.success() )
            {
               pr_gam.commit( "GAMAuthenticationTypeEntry");
               pr_default.commit( "GAMAuthenticationTypeEntry");
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
            else
            {
               AV25Errors = AV6AuthenticationTypeCustom.geterrors();
            }
         }
         else if ( StringUtil.StrCmp(AV34TypeId, "GAMRemote") == 0 )
         {
            if ( AV8AuthenticationTypeGAMRemote.success() )
            {
               pr_gam.commit( "GAMAuthenticationTypeEntry");
               pr_default.commit( "GAMAuthenticationTypeEntry");
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
            else
            {
               AV25Errors = AV8AuthenticationTypeGAMRemote.geterrors();
            }
         }
         new log(context ).execute(  "6") ;
         AV25Errors = new SdtGAMRepository(context).getlasterrors();
         AV56GXV1 = 1;
         while ( AV56GXV1 <= AV25Errors.Count )
         {
            AV24Error = ((SdtGAMError)AV25Errors.Item(AV56GXV1));
            GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV24Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV24Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
            AV56GXV1 = (int)(AV56GXV1+1);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV6AuthenticationTypeCustom", AV6AuthenticationTypeCustom);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12AuthenticationTypeWebService", AV12AuthenticationTypeWebService);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11AuthenticationTypeTwitter", AV11AuthenticationTypeTwitter);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV8AuthenticationTypeGAMRemote", AV8AuthenticationTypeGAMRemote);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9AuthenticationTypeGoogle", AV9AuthenticationTypeGoogle);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV7AuthenticationTypeFacebook", AV7AuthenticationTypeFacebook);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10AuthenticationTypeLocal", AV10AuthenticationTypeLocal);
      }

      protected void E15102( )
      {
         /* Refresh Routine */
      }

      protected void nextLoad( )
      {
      }

      protected void E16102( )
      {
         /* Load Routine */
      }

      protected void wb_table2_213_102( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedcusprivateencryptkey_Internalname, tblTablemergedcusprivateencryptkey_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusprivateencryptkey_Internalname, "Cus Private Encrypt Key", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 217,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusprivateencryptkey_Internalname, StringUtil.RTrim( AV21CusPrivateEncryptKey), StringUtil.RTrim( context.localUtil.Format( AV21CusPrivateEncryptKey, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,217);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusprivateencryptkey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCusprivateencryptkey_Enabled, 0, "text", "", 32, "chr", 1, "row", 32, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='CellMarginLeft'>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 219,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtngenkeycustom_Internalname, "", "Generate Key", bttBtngenkeycustom_Jsonclick, 5, "Generate Key", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOGENKEYCUSTOM\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMAuthenticationTypeEntry.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_213_102e( true) ;
         }
         else
         {
            wb_table2_213_102e( false) ;
         }
      }

      protected void wb_table1_143_102( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedwsprivateencryptkey_Internalname, tblTablemergedwsprivateencryptkey_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWsprivateencryptkey_Internalname, "WSPrivate Encrypt Key", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 147,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWsprivateencryptkey_Internalname, StringUtil.RTrim( AV39WSPrivateEncryptKey), StringUtil.RTrim( context.localUtil.Format( AV39WSPrivateEncryptKey, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,147);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavWsprivateencryptkey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavWsprivateencryptkey_Enabled, 0, "text", "", 32, "chr", 1, "row", 32, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GAMAuthenticationTypeEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='CellMarginLeft'>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 149,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtngenkey_Internalname, "", "Generate Key", bttBtngenkey_Jsonclick, 5, "Generate Key", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOGENKEY\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMAuthenticationTypeEntry.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_143_102e( true) ;
         }
         else
         {
            wb_table1_143_102e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         Gx_mode = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         AV32Name = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Name", AV32Name);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV32Name, "")), context));
         AV35TypeIdDsp = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35TypeIdDsp", AV35TypeIdDsp);
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
         PA102( ) ;
         WS102( ) ;
         WE102( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019435224", true);
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
         context.AddJavascriptSource("gamauthenticationtypeentry.js", "?201892019435229", false);
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
         cmbavTypeid_Internalname = "vTYPEID";
         edtavName_Internalname = "vNAME";
         cmbavFunctionid_Internalname = "vFUNCTIONID";
         edtavDsc_Internalname = "vDSC";
         chkavIsenable_Internalname = "vISENABLE";
         edtavAdditionalscope_Internalname = "vADDITIONALSCOPE";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         edtavClientid_Internalname = "vCLIENTID";
         edtavClientsecret_Internalname = "vCLIENTSECRET";
         edtavSiteurl_Internalname = "vSITEURL";
         edtavImpersonate_Internalname = "vIMPERSONATE";
         edtavGamrserverurl_Internalname = "vGAMRSERVERURL";
         divGamrserverurl_cell_Internalname = "GAMRSERVERURL_CELL";
         edtavGamrprivateencryptkey_Internalname = "vGAMRPRIVATEENCRYPTKEY";
         divGamrprivateencryptkey_cell_Internalname = "GAMRPRIVATEENCRYPTKEY_CELL";
         edtavGamrrepositoryguid_Internalname = "vGAMRREPOSITORYGUID";
         divGamrrepositoryguid_cell_Internalname = "GAMRREPOSITORYGUID_CELL";
         divFb_Internalname = "FB";
         divLayout_fb_Internalname = "LAYOUT_FB";
         Dvpanel_fb_Internalname = "DVPANEL_FB";
         divHtml_dvpanel_fb_Internalname = "HTML_DVPANEL_FB";
         divTblfacebook_Internalname = "TBLFACEBOOK";
         edtavConsumerkey_Internalname = "vCONSUMERKEY";
         edtavConsumersecret_Internalname = "vCONSUMERSECRET";
         edtavCallbackurl_Internalname = "vCALLBACKURL";
         divTw_Internalname = "TW";
         divLayout_tw_Internalname = "LAYOUT_TW";
         Dvpanel_tw_Internalname = "DVPANEL_TW";
         divHtml_dvpanel_tw_Internalname = "HTML_DVPANEL_TW";
         divTbltwitter_Internalname = "TBLTWITTER";
         cmbavWsversion_Internalname = "vWSVERSION";
         edtavWsimpersonate_Internalname = "vWSIMPERSONATE";
         lblTextblockwsprivateencryptkey_Internalname = "TEXTBLOCKWSPRIVATEENCRYPTKEY";
         edtavWsprivateencryptkey_Internalname = "vWSPRIVATEENCRYPTKEY";
         bttBtngenkey_Internalname = "BTNGENKEY";
         tblTablemergedwsprivateencryptkey_Internalname = "TABLEMERGEDWSPRIVATEENCRYPTKEY";
         divTablesplittedwsprivateencryptkey_Internalname = "TABLESPLITTEDWSPRIVATEENCRYPTKEY";
         edtavWsservername_Internalname = "vWSSERVERNAME";
         edtavWsserverport_Internalname = "vWSSERVERPORT";
         edtavWsserverbaseurl_Internalname = "vWSSERVERBASEURL";
         cmbavWsserversecureprotocol_Internalname = "vWSSERVERSECUREPROTOCOL";
         edtavWstimeout_Internalname = "vWSTIMEOUT";
         edtavWspackage_Internalname = "vWSPACKAGE";
         edtavWsname_Internalname = "vWSNAME";
         edtavWsextension_Internalname = "vWSEXTENSION";
         divWs_Internalname = "WS";
         divLayout_ws_Internalname = "LAYOUT_WS";
         Dvpanel_ws_Internalname = "DVPANEL_WS";
         divHtml_dvpanel_ws_Internalname = "HTML_DVPANEL_WS";
         divTblwebservice_Internalname = "TBLWEBSERVICE";
         cmbavCusversion_Internalname = "vCUSVERSION";
         edtavCusimpersonate_Internalname = "vCUSIMPERSONATE";
         lblTextblockcusprivateencryptkey_Internalname = "TEXTBLOCKCUSPRIVATEENCRYPTKEY";
         edtavCusprivateencryptkey_Internalname = "vCUSPRIVATEENCRYPTKEY";
         bttBtngenkeycustom_Internalname = "BTNGENKEYCUSTOM";
         tblTablemergedcusprivateencryptkey_Internalname = "TABLEMERGEDCUSPRIVATEENCRYPTKEY";
         divTablesplittedcusprivateencryptkey_Internalname = "TABLESPLITTEDCUSPRIVATEENCRYPTKEY";
         edtavCusfilename_Internalname = "vCUSFILENAME";
         edtavCuspackage_Internalname = "vCUSPACKAGE";
         edtavCusclassname_Internalname = "vCUSCLASSNAME";
         divExt_Internalname = "EXT";
         divLayout_ext_Internalname = "LAYOUT_EXT";
         Dvpanel_ext_Internalname = "DVPANEL_EXT";
         divHtml_dvpanel_ext_Internalname = "HTML_DVPANEL_EXT";
         divTblexternal_Internalname = "TBLEXTERNAL";
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
         edtavWsprivateencryptkey_Jsonclick = "";
         edtavWsprivateencryptkey_Enabled = 1;
         edtavCusprivateencryptkey_Jsonclick = "";
         edtavCusprivateencryptkey_Enabled = 1;
         chkavIsenable.Caption = " ";
         edtavCusclassname_Jsonclick = "";
         edtavCusclassname_Enabled = 1;
         edtavCuspackage_Jsonclick = "";
         edtavCuspackage_Enabled = 1;
         edtavCusfilename_Jsonclick = "";
         edtavCusfilename_Enabled = 1;
         edtavCusimpersonate_Jsonclick = "";
         edtavCusimpersonate_Enabled = 1;
         cmbavCusversion_Jsonclick = "";
         cmbavCusversion.Enabled = 1;
         edtavWsextension_Jsonclick = "";
         edtavWsextension_Enabled = 1;
         edtavWsname_Jsonclick = "";
         edtavWsname_Enabled = 1;
         edtavWspackage_Jsonclick = "";
         edtavWspackage_Enabled = 1;
         edtavWstimeout_Jsonclick = "";
         edtavWstimeout_Enabled = 1;
         cmbavWsserversecureprotocol_Jsonclick = "";
         cmbavWsserversecureprotocol.Enabled = 1;
         edtavWsserverbaseurl_Jsonclick = "";
         edtavWsserverbaseurl_Enabled = 1;
         edtavWsserverport_Jsonclick = "";
         edtavWsserverport_Enabled = 1;
         edtavWsservername_Jsonclick = "";
         edtavWsservername_Enabled = 1;
         edtavWsimpersonate_Jsonclick = "";
         edtavWsimpersonate_Enabled = 1;
         cmbavWsversion_Jsonclick = "";
         cmbavWsversion.Enabled = 1;
         edtavCallbackurl_Jsonclick = "";
         edtavCallbackurl_Enabled = 1;
         edtavConsumersecret_Jsonclick = "";
         edtavConsumersecret_Enabled = 1;
         edtavConsumerkey_Jsonclick = "";
         edtavConsumerkey_Enabled = 1;
         edtavGamrrepositoryguid_Jsonclick = "";
         edtavGamrrepositoryguid_Enabled = 1;
         edtavGamrprivateencryptkey_Jsonclick = "";
         edtavGamrprivateencryptkey_Enabled = 1;
         edtavGamrserverurl_Jsonclick = "";
         edtavGamrserverurl_Enabled = 1;
         edtavImpersonate_Jsonclick = "";
         edtavImpersonate_Enabled = 1;
         edtavSiteurl_Jsonclick = "";
         edtavSiteurl_Enabled = 1;
         edtavClientsecret_Jsonclick = "";
         edtavClientsecret_Enabled = 1;
         edtavClientid_Jsonclick = "";
         edtavClientid_Enabled = 1;
         edtavAdditionalscope_Jsonclick = "";
         edtavAdditionalscope_Enabled = 1;
         chkavIsenable.Enabled = 1;
         edtavDsc_Jsonclick = "";
         edtavDsc_Enabled = 1;
         cmbavFunctionid_Jsonclick = "";
         cmbavFunctionid.Enabled = 1;
         edtavName_Jsonclick = "";
         edtavName_Enabled = 0;
         cmbavTypeid_Jsonclick = "";
         cmbavTypeid.Enabled = 1;
         Dvpanel_ext_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_ext_Iconposition = "left";
         Dvpanel_ext_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_ext_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_ext_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_ext_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_ext_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_ext_Title = "External";
         Dvpanel_ext_Cls = "PanelCard_BaseColor";
         Dvpanel_ext_Width = "100%";
         Dvpanel_ws_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_ws_Iconposition = "left";
         Dvpanel_ws_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_ws_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_ws_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_ws_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_ws_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_ws_Title = "Web Service";
         Dvpanel_ws_Cls = "PanelCard_BaseColor";
         Dvpanel_ws_Width = "100%";
         Dvpanel_tw_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tw_Iconposition = "left";
         Dvpanel_tw_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tw_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tw_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tw_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tw_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tw_Title = "Twitter";
         Dvpanel_tw_Cls = "PanelCard_BaseColor";
         Dvpanel_tw_Width = "100%";
         Dvpanel_fb_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_fb_Iconposition = "left";
         Dvpanel_fb_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_fb_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_fb_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_fb_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_fb_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_fb_Title = "Facebook";
         Dvpanel_fb_Cls = "PanelCard_BaseColor";
         Dvpanel_fb_Width = "100%";
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "Authentication Type";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Authentication type";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV32Name',fld:'vNAME',pic:'',hsh:true,nv:''}],oparms:[]}");
         setEventMetadata("'DOGENKEYCUSTOM'","{handler:'E12102',iparms:[],oparms:[{av:'AV21CusPrivateEncryptKey',fld:'vCUSPRIVATEENCRYPTKEY',pic:'',nv:''}]}");
         setEventMetadata("'DOGENKEY'","{handler:'E13102',iparms:[],oparms:[{av:'AV39WSPrivateEncryptKey',fld:'vWSPRIVATEENCRYPTKEY',pic:'',nv:''}]}");
         setEventMetadata("ENTER","{handler:'E14102',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV28GAMRRepositoryGUID',fld:'vGAMRREPOSITORYGUID',pic:'',nv:''},{av:'AV27GAMRPrivateEncryptKey',fld:'vGAMRPRIVATEENCRYPTKEY',pic:'',nv:''},{av:'AV29GAMRServerURL',fld:'vGAMRSERVERURL',pic:'',nv:''},{av:'AV33SiteURL',fld:'vSITEURL',pic:'',nv:''},{av:'AV15ClientSecret',fld:'vCLIENTSECRET',pic:'',nv:''},{av:'AV14ClientId',fld:'vCLIENTID',pic:'',nv:''},{av:'AV30Impersonate',fld:'vIMPERSONATE',pic:'',nv:''},{av:'AV5AdditionalScope',fld:'vADDITIONALSCOPE',pic:'',nv:''},{av:'AV13CallbackURL',fld:'vCALLBACKURL',pic:'',nv:''},{av:'AV17ConsumerSecret',fld:'vCONSUMERSECRET',pic:'',nv:''},{av:'AV16ConsumerKey',fld:'vCONSUMERKEY',pic:'',nv:''},{av:'cmbavWsserversecureprotocol'},{av:'AV43WSServerSecureProtocol',fld:'vWSSERVERSECUREPROTOCOL',pic:'9',nv:0},{av:'AV40WSServerBaseURL',fld:'vWSSERVERBASEURL',pic:'',nv:''},{av:'AV42WSServerPort',fld:'vWSSERVERPORT',pic:'ZZZZ9',nv:0},{av:'AV41WSServerName',fld:'vWSSERVERNAME',pic:'',nv:''},{av:'AV36WSExtension',fld:'vWSEXTENSION',pic:'',nv:''},{av:'AV37WSName',fld:'vWSNAME',pic:'',nv:''},{av:'AV38WSPackage',fld:'vWSPACKAGE',pic:'',nv:''},{av:'AV44WSTimeout',fld:'vWSTIMEOUT',pic:'ZZZZ9',nv:0},{av:'AV39WSPrivateEncryptKey',fld:'vWSPRIVATEENCRYPTKEY',pic:'',nv:''},{av:'cmbavWsversion'},{av:'AV45WSVersion',fld:'vWSVERSION',pic:'',nv:''},{av:'AV47WSImpersonate',fld:'vWSIMPERSONATE',pic:'',nv:''},{av:'AV18CusClassName',fld:'vCUSCLASSNAME',pic:'',nv:''},{av:'AV20CusPackage',fld:'vCUSPACKAGE',pic:'',nv:''},{av:'AV19CusFileName',fld:'vCUSFILENAME',pic:'',nv:''},{av:'AV21CusPrivateEncryptKey',fld:'vCUSPRIVATEENCRYPTKEY',pic:'',nv:''},{av:'cmbavCusversion'},{av:'AV22CusVersion',fld:'vCUSVERSION',pic:'',nv:''},{av:'AV46CusImpersonate',fld:'vCUSIMPERSONATE',pic:'',nv:''},{av:'AV23Dsc',fld:'vDSC',pic:'',nv:''},{av:'AV31IsEnable',fld:'vISENABLE',pic:'',nv:false},{av:'cmbavFunctionid'},{av:'AV26FunctionId',fld:'vFUNCTIONID',pic:'',nv:''},{av:'AV32Name',fld:'vNAME',pic:'',hsh:true,nv:''},{av:'cmbavTypeid'},{av:'AV34TypeId',fld:'vTYPEID',pic:'',nv:''}],oparms:[{av:'cmbavFunctionid'}]}");
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
         wcpOAV32Name = "";
         wcpOAV35TypeIdDsp = "";
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
         TempTags = "";
         AV34TypeId = "";
         AV26FunctionId = "";
         AV23Dsc = "";
         AV5AdditionalScope = "";
         AV14ClientId = "";
         AV15ClientSecret = "";
         AV33SiteURL = "";
         AV30Impersonate = "";
         AV29GAMRServerURL = "";
         AV27GAMRPrivateEncryptKey = "";
         AV28GAMRRepositoryGUID = "";
         AV16ConsumerKey = "";
         AV17ConsumerSecret = "";
         AV13CallbackURL = "";
         AV45WSVersion = "";
         AV47WSImpersonate = "";
         lblTextblockwsprivateencryptkey_Jsonclick = "";
         AV41WSServerName = "";
         AV40WSServerBaseURL = "";
         AV43WSServerSecureProtocol = 0;
         AV38WSPackage = "";
         AV37WSName = "";
         AV36WSExtension = "";
         AV22CusVersion = "";
         AV46CusImpersonate = "";
         lblTextblockcusprivateencryptkey_Jsonclick = "";
         AV19CusFileName = "";
         AV20CusPackage = "";
         AV18CusClassName = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV39WSPrivateEncryptKey = "";
         AV21CusPrivateEncryptKey = "";
         AV10AuthenticationTypeLocal = new SdtGAMAuthenticationTypeLocal(context);
         AV7AuthenticationTypeFacebook = new SdtGAMAuthenticationTypeFacebook(context);
         AV9AuthenticationTypeGoogle = new SdtGAMAuthenticationTypeGoogle(context);
         AV8AuthenticationTypeGAMRemote = new SdtGAMAuthenticationTypeGAMRemote(context);
         AV11AuthenticationTypeTwitter = new SdtGAMAuthenticationTypeTwitter(context);
         AV12AuthenticationTypeWebService = new SdtGAMAuthenticationTypeWebService(context);
         AV6AuthenticationTypeCustom = new SdtGAMAuthenticationTypeCustom(context);
         AV25Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV24Error = new SdtGAMError(context);
         sStyleString = "";
         bttBtngenkeycustom_Jsonclick = "";
         bttBtngenkey_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamauthenticationtypeentry__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamauthenticationtypeentry__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short AV43WSServerSecureProtocol ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavName_Enabled ;
      private int edtavDsc_Enabled ;
      private int edtavAdditionalscope_Enabled ;
      private int edtavClientid_Enabled ;
      private int edtavClientsecret_Enabled ;
      private int edtavSiteurl_Enabled ;
      private int edtavImpersonate_Enabled ;
      private int edtavGamrserverurl_Enabled ;
      private int edtavGamrprivateencryptkey_Enabled ;
      private int edtavGamrrepositoryguid_Enabled ;
      private int edtavConsumerkey_Enabled ;
      private int edtavConsumersecret_Enabled ;
      private int edtavCallbackurl_Enabled ;
      private int edtavWsimpersonate_Enabled ;
      private int edtavWsservername_Enabled ;
      private int AV42WSServerPort ;
      private int edtavWsserverport_Enabled ;
      private int edtavWsserverbaseurl_Enabled ;
      private int AV44WSTimeout ;
      private int edtavWstimeout_Enabled ;
      private int edtavWspackage_Enabled ;
      private int edtavWsname_Enabled ;
      private int edtavWsextension_Enabled ;
      private int edtavCusimpersonate_Enabled ;
      private int edtavCusfilename_Enabled ;
      private int edtavCuspackage_Enabled ;
      private int edtavCusclassname_Enabled ;
      private int AV56GXV1 ;
      private int edtavCusprivateencryptkey_Enabled ;
      private int edtavWsprivateencryptkey_Enabled ;
      private int idxLst ;
      private String Gx_mode ;
      private String AV32Name ;
      private String AV35TypeIdDsp ;
      private String wcpOGx_mode ;
      private String wcpOAV32Name ;
      private String wcpOAV35TypeIdDsp ;
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
      private String Dvpanel_fb_Width ;
      private String Dvpanel_fb_Cls ;
      private String Dvpanel_fb_Title ;
      private String Dvpanel_fb_Iconposition ;
      private String Dvpanel_tw_Width ;
      private String Dvpanel_tw_Cls ;
      private String Dvpanel_tw_Title ;
      private String Dvpanel_tw_Iconposition ;
      private String Dvpanel_ws_Width ;
      private String Dvpanel_ws_Cls ;
      private String Dvpanel_ws_Title ;
      private String Dvpanel_ws_Iconposition ;
      private String Dvpanel_ext_Width ;
      private String Dvpanel_ext_Cls ;
      private String Dvpanel_ext_Title ;
      private String Dvpanel_ext_Iconposition ;
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
      private String cmbavTypeid_Internalname ;
      private String TempTags ;
      private String AV34TypeId ;
      private String cmbavTypeid_Jsonclick ;
      private String edtavName_Internalname ;
      private String edtavName_Jsonclick ;
      private String cmbavFunctionid_Internalname ;
      private String AV26FunctionId ;
      private String cmbavFunctionid_Jsonclick ;
      private String edtavDsc_Internalname ;
      private String AV23Dsc ;
      private String edtavDsc_Jsonclick ;
      private String chkavIsenable_Internalname ;
      private String edtavAdditionalscope_Internalname ;
      private String edtavAdditionalscope_Jsonclick ;
      private String divTblfacebook_Internalname ;
      private String divHtml_dvpanel_fb_Internalname ;
      private String divLayout_fb_Internalname ;
      private String divFb_Internalname ;
      private String edtavClientid_Internalname ;
      private String edtavClientid_Jsonclick ;
      private String edtavClientsecret_Internalname ;
      private String edtavClientsecret_Jsonclick ;
      private String edtavSiteurl_Internalname ;
      private String edtavSiteurl_Jsonclick ;
      private String edtavImpersonate_Internalname ;
      private String AV30Impersonate ;
      private String edtavImpersonate_Jsonclick ;
      private String divGamrserverurl_cell_Internalname ;
      private String edtavGamrserverurl_Internalname ;
      private String edtavGamrserverurl_Jsonclick ;
      private String divGamrprivateencryptkey_cell_Internalname ;
      private String edtavGamrprivateencryptkey_Internalname ;
      private String AV27GAMRPrivateEncryptKey ;
      private String edtavGamrprivateencryptkey_Jsonclick ;
      private String divGamrrepositoryguid_cell_Internalname ;
      private String edtavGamrrepositoryguid_Internalname ;
      private String AV28GAMRRepositoryGUID ;
      private String edtavGamrrepositoryguid_Jsonclick ;
      private String divTbltwitter_Internalname ;
      private String divHtml_dvpanel_tw_Internalname ;
      private String divLayout_tw_Internalname ;
      private String divTw_Internalname ;
      private String edtavConsumerkey_Internalname ;
      private String AV16ConsumerKey ;
      private String edtavConsumerkey_Jsonclick ;
      private String edtavConsumersecret_Internalname ;
      private String AV17ConsumerSecret ;
      private String edtavConsumersecret_Jsonclick ;
      private String edtavCallbackurl_Internalname ;
      private String edtavCallbackurl_Jsonclick ;
      private String divTblwebservice_Internalname ;
      private String divHtml_dvpanel_ws_Internalname ;
      private String divLayout_ws_Internalname ;
      private String divWs_Internalname ;
      private String cmbavWsversion_Internalname ;
      private String AV45WSVersion ;
      private String cmbavWsversion_Jsonclick ;
      private String edtavWsimpersonate_Internalname ;
      private String AV47WSImpersonate ;
      private String edtavWsimpersonate_Jsonclick ;
      private String divTablesplittedwsprivateencryptkey_Internalname ;
      private String lblTextblockwsprivateencryptkey_Internalname ;
      private String lblTextblockwsprivateencryptkey_Jsonclick ;
      private String edtavWsservername_Internalname ;
      private String AV41WSServerName ;
      private String edtavWsservername_Jsonclick ;
      private String edtavWsserverport_Internalname ;
      private String edtavWsserverport_Jsonclick ;
      private String edtavWsserverbaseurl_Internalname ;
      private String edtavWsserverbaseurl_Jsonclick ;
      private String cmbavWsserversecureprotocol_Internalname ;
      private String cmbavWsserversecureprotocol_Jsonclick ;
      private String edtavWstimeout_Internalname ;
      private String edtavWstimeout_Jsonclick ;
      private String edtavWspackage_Internalname ;
      private String AV38WSPackage ;
      private String edtavWspackage_Jsonclick ;
      private String edtavWsname_Internalname ;
      private String AV37WSName ;
      private String edtavWsname_Jsonclick ;
      private String edtavWsextension_Internalname ;
      private String AV36WSExtension ;
      private String edtavWsextension_Jsonclick ;
      private String divTblexternal_Internalname ;
      private String divHtml_dvpanel_ext_Internalname ;
      private String divLayout_ext_Internalname ;
      private String divExt_Internalname ;
      private String cmbavCusversion_Internalname ;
      private String AV22CusVersion ;
      private String cmbavCusversion_Jsonclick ;
      private String edtavCusimpersonate_Internalname ;
      private String AV46CusImpersonate ;
      private String edtavCusimpersonate_Jsonclick ;
      private String divTablesplittedcusprivateencryptkey_Internalname ;
      private String lblTextblockcusprivateencryptkey_Internalname ;
      private String lblTextblockcusprivateencryptkey_Jsonclick ;
      private String edtavCusfilename_Internalname ;
      private String AV19CusFileName ;
      private String edtavCusfilename_Jsonclick ;
      private String edtavCuspackage_Internalname ;
      private String AV20CusPackage ;
      private String edtavCuspackage_Jsonclick ;
      private String edtavCusclassname_Internalname ;
      private String AV18CusClassName ;
      private String edtavCusclassname_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV39WSPrivateEncryptKey ;
      private String edtavWsprivateencryptkey_Internalname ;
      private String AV21CusPrivateEncryptKey ;
      private String edtavCusprivateencryptkey_Internalname ;
      private String sStyleString ;
      private String tblTablemergedcusprivateencryptkey_Internalname ;
      private String edtavCusprivateencryptkey_Jsonclick ;
      private String bttBtngenkeycustom_Internalname ;
      private String bttBtngenkeycustom_Jsonclick ;
      private String tblTablemergedwsprivateencryptkey_Internalname ;
      private String edtavWsprivateencryptkey_Jsonclick ;
      private String bttBtngenkey_Internalname ;
      private String bttBtngenkey_Jsonclick ;
      private String Dvpanel_tableattributes_Internalname ;
      private String Dvpanel_fb_Internalname ;
      private String Dvpanel_tw_Internalname ;
      private String Dvpanel_ws_Internalname ;
      private String Dvpanel_ext_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool Dvpanel_fb_Collapsible ;
      private bool Dvpanel_fb_Collapsed ;
      private bool Dvpanel_fb_Autowidth ;
      private bool Dvpanel_fb_Autoheight ;
      private bool Dvpanel_fb_Showcollapseicon ;
      private bool Dvpanel_fb_Autoscroll ;
      private bool Dvpanel_tw_Collapsible ;
      private bool Dvpanel_tw_Collapsed ;
      private bool Dvpanel_tw_Autowidth ;
      private bool Dvpanel_tw_Autoheight ;
      private bool Dvpanel_tw_Showcollapseicon ;
      private bool Dvpanel_tw_Autoscroll ;
      private bool Dvpanel_ws_Collapsible ;
      private bool Dvpanel_ws_Collapsed ;
      private bool Dvpanel_ws_Autowidth ;
      private bool Dvpanel_ws_Autoheight ;
      private bool Dvpanel_ws_Showcollapseicon ;
      private bool Dvpanel_ws_Autoscroll ;
      private bool Dvpanel_ext_Collapsible ;
      private bool Dvpanel_ext_Collapsed ;
      private bool Dvpanel_ext_Autowidth ;
      private bool Dvpanel_ext_Autoheight ;
      private bool Dvpanel_ext_Showcollapseicon ;
      private bool Dvpanel_ext_Autoscroll ;
      private bool wbLoad ;
      private bool AV31IsEnable ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV5AdditionalScope ;
      private String AV14ClientId ;
      private String AV15ClientSecret ;
      private String AV33SiteURL ;
      private String AV29GAMRServerURL ;
      private String AV13CallbackURL ;
      private String AV40WSServerBaseURL ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavTypeid ;
      private GXCombobox cmbavFunctionid ;
      private GXCheckbox chkavIsenable ;
      private GXCombobox cmbavWsversion ;
      private GXCombobox cmbavWsserversecureprotocol ;
      private GXCombobox cmbavCusversion ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMError> AV25Errors ;
      private GXWebForm Form ;
      private SdtGAMAuthenticationTypeCustom AV6AuthenticationTypeCustom ;
      private SdtGAMError AV24Error ;
      private SdtGAMAuthenticationTypeFacebook AV7AuthenticationTypeFacebook ;
      private SdtGAMAuthenticationTypeGoogle AV9AuthenticationTypeGoogle ;
      private SdtGAMAuthenticationTypeLocal AV10AuthenticationTypeLocal ;
      private SdtGAMAuthenticationTypeTwitter AV11AuthenticationTypeTwitter ;
      private SdtGAMAuthenticationTypeWebService AV12AuthenticationTypeWebService ;
      private SdtGAMAuthenticationTypeGAMRemote AV8AuthenticationTypeGAMRemote ;
   }

   public class gamauthenticationtypeentry__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamauthenticationtypeentry__default : DataStoreHelperBase, IDataStoreHelper
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
