/*
               File: GAMRepositoryEntry
        Description: Repository
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:41:40.7
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
   public class gamrepositoryentry : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamrepositoryentry( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamrepositoryentry( IGxContext context )
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
                           int aP1_Id )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV28Id = aP1_Id;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavAllowoauthaccess = new GXCheckbox();
         chkavCanregisterusers = new GXCheckbox();
         chkavGiveanonymoussession = new GXCheckbox();
         chkavUpdateconnectionfile = new GXCheckbox();
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
                  AV28Id = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28Id), 9, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV28Id), "ZZZZZZZZ9"), context));
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
         PA0X2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0X2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019414063", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamrepositoryentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV28Id)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28Id), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV28Id), "ZZZZZZZZ9"), context));
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
         GxWebStd.gx_hidden_field( context, "DVPANEL_CONN_Width", StringUtil.RTrim( Dvpanel_conn_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_CONN_Cls", StringUtil.RTrim( Dvpanel_conn_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_CONN_Title", StringUtil.RTrim( Dvpanel_conn_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_CONN_Collapsible", StringUtil.BoolToStr( Dvpanel_conn_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_CONN_Collapsed", StringUtil.BoolToStr( Dvpanel_conn_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_CONN_Autowidth", StringUtil.BoolToStr( Dvpanel_conn_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_CONN_Autoheight", StringUtil.BoolToStr( Dvpanel_conn_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_CONN_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_conn_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_CONN_Iconposition", StringUtil.RTrim( Dvpanel_conn_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_CONN_Autoscroll", StringUtil.BoolToStr( Dvpanel_conn_Autoscroll));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ADMIN_Width", StringUtil.RTrim( Dvpanel_admin_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ADMIN_Cls", StringUtil.RTrim( Dvpanel_admin_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ADMIN_Title", StringUtil.RTrim( Dvpanel_admin_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ADMIN_Collapsible", StringUtil.BoolToStr( Dvpanel_admin_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ADMIN_Collapsed", StringUtil.BoolToStr( Dvpanel_admin_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ADMIN_Autowidth", StringUtil.BoolToStr( Dvpanel_admin_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ADMIN_Autoheight", StringUtil.BoolToStr( Dvpanel_admin_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ADMIN_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_admin_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ADMIN_Iconposition", StringUtil.RTrim( Dvpanel_admin_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_ADMIN_Autoscroll", StringUtil.BoolToStr( Dvpanel_admin_Autoscroll));
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
            WE0X2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0X2( ) ;
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
         return formatLink("gamrepositoryentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV28Id) ;
      }

      public override String GetPgmname( )
      {
         return "GAMRepositoryEntry" ;
      }

      public override String GetPgmdesc( )
      {
         return "Repository " ;
      }

      protected void WB0X0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGuid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGuid_Internalname, "GUID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGuid_Internalname, StringUtil.RTrim( AV27GUID), StringUtil.RTrim( context.localUtil.Format( AV27GUID, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,24);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGuid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavGuid_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GAMGUID", "left", true, "HLP_GAMRepositoryEntry.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavName_Internalname, StringUtil.RTrim( AV31Name), StringUtil.RTrim( context.localUtil.Format( AV31Name, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavName_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionShort", "left", true, "HLP_GAMRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavNamespace_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavNamespace_Internalname, "Namespace", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNamespace_Internalname, StringUtil.RTrim( AV32Namespace), StringUtil.RTrim( context.localUtil.Format( AV32Namespace, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNamespace_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavNamespace_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, 0, true, "GAMRepositoryNameSpace", "left", true, "HLP_GAMRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavDescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavDescription_Internalname, "Description", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDescription_Internalname, StringUtil.RTrim( AV21Description), StringUtil.RTrim( context.localUtil.Format( AV21Description, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDescription_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavDescription_Enabled, 1, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavAllowoauthaccess_Internalname+"\"", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavAllowoauthaccess_Internalname, StringUtil.BoolToStr( AV9AllowOauthAccess), "", "", 1, chkavAllowoauthaccess.Enabled, "true", "Allow oauth access?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(42, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,42);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavCanregisterusers_Internalname+"\"", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCanregisterusers_Internalname, StringUtil.BoolToStr( AV40CanRegisterUsers), "", "", 1, chkavCanregisterusers.Enabled, "true", "Can register users?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(46, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavGiveanonymoussession_Internalname+"\"", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavGiveanonymoussession_Internalname, StringUtil.BoolToStr( AV26GiveAnonymousSession), "", "", 1, chkavGiveanonymoussession.Enabled, "true", "Give anonymous session?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(51, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,51);\"");
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
            GxWebStd.gx_div_start( context, divHtml_dvpanel_conn_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_CONNContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_CONNContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_conn_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divConn_Internalname, divConn_Visible, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConnectionusername_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConnectionusername_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConnectionusername_Internalname, StringUtil.RTrim( AV12ConnectionUserName), StringUtil.RTrim( context.localUtil.Format( AV12ConnectionUserName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConnectionusername_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavConnectionusername_Enabled, 1, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, 0, true, "GAMConnectionUser", "left", true, "HLP_GAMRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConnectionuserpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConnectionuserpassword_Internalname, "Password", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConnectionuserpassword_Internalname, StringUtil.RTrim( AV13ConnectionUserPassword), StringUtil.RTrim( context.localUtil.Format( AV13ConnectionUserPassword, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConnectionuserpassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavConnectionuserpassword_Enabled, 1, "text", "", 80, "chr", 1, "row", 254, edtavConnectionuserpassword_Ispassword, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GAMRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConfconnectionuserpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConfconnectionuserpassword_Internalname, "Conf. Password", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConfconnectionuserpassword_Internalname, StringUtil.RTrim( AV11ConfConnectionUserPassword), StringUtil.RTrim( context.localUtil.Format( AV11ConfConnectionUserPassword, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConfconnectionuserpassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavConfconnectionuserpassword_Enabled, 0, "text", "", 80, "chr", 1, "row", 254, edtavConfconnectionuserpassword_Ispassword, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GAMRepositoryEntry.htm");
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
            GxWebStd.gx_div_start( context, divHtml_dvpanel_admin_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_ADMINContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_ADMINContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_admin_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdmin_Internalname, divAdmin_Visible, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavAdministratorusername_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAdministratorusername_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavAdministratorusername_Internalname, StringUtil.RTrim( AV7AdministratorUserName), StringUtil.RTrim( context.localUtil.Format( AV7AdministratorUserName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,86);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavAdministratorusername_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavAdministratorusername_Enabled, 1, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, 0, true, "GAMConnectionUser", "left", true, "HLP_GAMRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavAdministratoruserpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAdministratoruserpassword_Internalname, "Password", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavAdministratoruserpassword_Internalname, StringUtil.RTrim( AV8AdministratorUserPassword), StringUtil.RTrim( context.localUtil.Format( AV8AdministratorUserPassword, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,91);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavAdministratoruserpassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavAdministratoruserpassword_Enabled, 1, "text", "", 80, "chr", 1, "row", 254, edtavAdministratoruserpassword_Ispassword, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GAMRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConfadministratoruserpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConfadministratoruserpassword_Internalname, "Conf. Password", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConfadministratoruserpassword_Internalname, StringUtil.RTrim( AV10ConfAdministratorUserPassword), StringUtil.RTrim( context.localUtil.Format( AV10ConfAdministratorUserPassword, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,96);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConfadministratoruserpassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavConfadministratoruserpassword_Enabled, 0, "text", "", 80, "chr", 1, "row", 254, edtavConfadministratoruserpassword_Ispassword, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GAMRepositoryEntry.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "Confirmar", bttBtnenter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMRepositoryEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Fechar", bttBtncancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMRepositoryEntry.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 107,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUpdateconnectionfile_Internalname, StringUtil.BoolToStr( AV39UpdateConnectionFile), "", "", chkavUpdateconnectionfile.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(107, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,107);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0X2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Repository ", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0X0( ) ;
      }

      protected void WS0X2( )
      {
         START0X2( ) ;
         EVT0X2( ) ;
      }

      protected void EVT0X2( )
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
                              E110X2 ();
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
                                    E120X2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E130X2 ();
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

      protected void WE0X2( )
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

      protected void PA0X2( )
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
            chkavAllowoauthaccess.Name = "vALLOWOAUTHACCESS";
            chkavAllowoauthaccess.WebTags = "";
            chkavAllowoauthaccess.Caption = "Allow oauth access?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAllowoauthaccess_Internalname, "TitleCaption", chkavAllowoauthaccess.Caption, true);
            chkavAllowoauthaccess.CheckedValue = "false";
            chkavCanregisterusers.Name = "vCANREGISTERUSERS";
            chkavCanregisterusers.WebTags = "";
            chkavCanregisterusers.Caption = "Can register users?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCanregisterusers_Internalname, "TitleCaption", chkavCanregisterusers.Caption, true);
            chkavCanregisterusers.CheckedValue = "false";
            chkavGiveanonymoussession.Name = "vGIVEANONYMOUSSESSION";
            chkavGiveanonymoussession.WebTags = "";
            chkavGiveanonymoussession.Caption = "Give anonymous session?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavGiveanonymoussession_Internalname, "TitleCaption", chkavGiveanonymoussession.Caption, true);
            chkavGiveanonymoussession.CheckedValue = "false";
            chkavUpdateconnectionfile.Name = "vUPDATECONNECTIONFILE";
            chkavUpdateconnectionfile.WebTags = "";
            chkavUpdateconnectionfile.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUpdateconnectionfile_Internalname, "TitleCaption", chkavUpdateconnectionfile.Caption, true);
            chkavUpdateconnectionfile.CheckedValue = "false";
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0X2( ) ;
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

      protected void RF0X2( )
      {
         initialize_formulas( ) ;
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E130X2 ();
            WB0X0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0X2( )
      {
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void STRUP0X0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110X2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV27GUID = cgiGet( edtavGuid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GUID", AV27GUID);
            AV31Name = cgiGet( edtavName_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31Name", AV31Name);
            AV32Namespace = cgiGet( edtavNamespace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Namespace", AV32Namespace);
            AV21Description = cgiGet( edtavDescription_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Description", AV21Description);
            AV9AllowOauthAccess = StringUtil.StrToBool( cgiGet( chkavAllowoauthaccess_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9AllowOauthAccess", AV9AllowOauthAccess);
            AV40CanRegisterUsers = StringUtil.StrToBool( cgiGet( chkavCanregisterusers_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40CanRegisterUsers", AV40CanRegisterUsers);
            AV26GiveAnonymousSession = StringUtil.StrToBool( cgiGet( chkavGiveanonymoussession_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26GiveAnonymousSession", AV26GiveAnonymousSession);
            AV12ConnectionUserName = cgiGet( edtavConnectionusername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12ConnectionUserName", AV12ConnectionUserName);
            AV13ConnectionUserPassword = cgiGet( edtavConnectionuserpassword_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ConnectionUserPassword", AV13ConnectionUserPassword);
            AV11ConfConnectionUserPassword = cgiGet( edtavConfconnectionuserpassword_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ConfConnectionUserPassword", AV11ConfConnectionUserPassword);
            AV7AdministratorUserName = cgiGet( edtavAdministratorusername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7AdministratorUserName", AV7AdministratorUserName);
            AV8AdministratorUserPassword = cgiGet( edtavAdministratoruserpassword_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8AdministratorUserPassword", AV8AdministratorUserPassword);
            AV10ConfAdministratorUserPassword = cgiGet( edtavConfadministratoruserpassword_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ConfAdministratorUserPassword", AV10ConfAdministratorUserPassword);
            AV39UpdateConnectionFile = StringUtil.StrToBool( cgiGet( chkavUpdateconnectionfile_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39UpdateConnectionFile", AV39UpdateConnectionFile);
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
            Dvpanel_conn_Width = cgiGet( "DVPANEL_CONN_Width");
            Dvpanel_conn_Cls = cgiGet( "DVPANEL_CONN_Cls");
            Dvpanel_conn_Title = cgiGet( "DVPANEL_CONN_Title");
            Dvpanel_conn_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_CONN_Collapsible"));
            Dvpanel_conn_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_CONN_Collapsed"));
            Dvpanel_conn_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_CONN_Autowidth"));
            Dvpanel_conn_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_CONN_Autoheight"));
            Dvpanel_conn_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_CONN_Showcollapseicon"));
            Dvpanel_conn_Iconposition = cgiGet( "DVPANEL_CONN_Iconposition");
            Dvpanel_conn_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_CONN_Autoscroll"));
            Dvpanel_admin_Width = cgiGet( "DVPANEL_ADMIN_Width");
            Dvpanel_admin_Cls = cgiGet( "DVPANEL_ADMIN_Cls");
            Dvpanel_admin_Title = cgiGet( "DVPANEL_ADMIN_Title");
            Dvpanel_admin_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_ADMIN_Collapsible"));
            Dvpanel_admin_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_ADMIN_Collapsed"));
            Dvpanel_admin_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_ADMIN_Autowidth"));
            Dvpanel_admin_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_ADMIN_Autoheight"));
            Dvpanel_admin_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_ADMIN_Showcollapseicon"));
            Dvpanel_admin_Iconposition = cgiGet( "DVPANEL_ADMIN_Iconposition");
            Dvpanel_admin_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_ADMIN_Autoscroll"));
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
         E110X2 ();
         if (returnInSub) return;
      }

      protected void E110X2( )
      {
         /* Start Routine */
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            AV35Repository.load( AV28Id);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28Id), 9, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV28Id), "ZZZZZZZZ9"), context));
            if ( AV35Repository.success() )
            {
               AV27GUID = AV35Repository.gxTpr_Guid;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GUID", AV27GUID);
               AV31Name = AV35Repository.gxTpr_Name;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31Name", AV31Name);
               AV32Namespace = AV35Repository.gxTpr_Namespace;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Namespace", AV32Namespace);
               AV21Description = AV35Repository.gxTpr_Description;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Description", AV21Description);
               AV9AllowOauthAccess = AV35Repository.gxTpr_Allowoauthaccess;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9AllowOauthAccess", AV9AllowOauthAccess);
               AV40CanRegisterUsers = AV35Repository.gxTpr_Canregisterusers;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40CanRegisterUsers", AV40CanRegisterUsers);
               AV26GiveAnonymousSession = AV35Repository.gxTpr_Giveanonymoussession;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26GiveAnonymousSession", AV26GiveAnonymousSession);
               edtavGuid_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), true);
               edtavName_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), true);
               edtavNamespace_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNamespace_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNamespace_Enabled), 5, 0)), true);
               edtavDescription_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDescription_Enabled), 5, 0)), true);
               edtavAdministratorusername_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdministratorusername_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdministratorusername_Enabled), 5, 0)), true);
               edtavAdministratoruserpassword_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdministratoruserpassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdministratoruserpassword_Enabled), 5, 0)), true);
               chkavAllowoauthaccess.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAllowoauthaccess_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavAllowoauthaccess.Enabled), 5, 0)), true);
               chkavCanregisterusers.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCanregisterusers_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavCanregisterusers.Enabled), 5, 0)), true);
               edtavConnectionusername_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConnectionusername_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavConnectionusername_Enabled), 5, 0)), true);
               edtavConnectionuserpassword_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConnectionuserpassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavConnectionuserpassword_Enabled), 5, 0)), true);
               chkavGiveanonymoussession.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavGiveanonymoussession_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavGiveanonymoussession.Enabled), 5, 0)), true);
               divConn_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divConn_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divConn_Visible), 5, 0)), true);
               divAdmin_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divAdmin_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divAdmin_Visible), 5, 0)), true);
            }
            else
            {
               AV23Errors = AV35Repository.geterrors();
               /* Execute user subroutine: 'DISPLAYERRORS' */
               S112 ();
               if (returnInSub) return;
            }
         }
         else
         {
            edtavAdministratoruserpassword_Ispassword = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdministratoruserpassword_Internalname, "Ispassword", StringUtil.Str( (decimal)(edtavAdministratoruserpassword_Ispassword), 1, 0), true);
            edtavConfadministratoruserpassword_Ispassword = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConfadministratoruserpassword_Internalname, "Ispassword", StringUtil.Str( (decimal)(edtavConfadministratoruserpassword_Ispassword), 1, 0), true);
            edtavConnectionuserpassword_Ispassword = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConnectionuserpassword_Internalname, "Ispassword", StringUtil.Str( (decimal)(edtavConnectionuserpassword_Ispassword), 1, 0), true);
            edtavConfconnectionuserpassword_Ispassword = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConfconnectionuserpassword_Internalname, "Ispassword", StringUtil.Str( (decimal)(edtavConfconnectionuserpassword_Ispassword), 1, 0), true);
            edtavGuid_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), true);
         }
         chkavUpdateconnectionfile.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUpdateconnectionfile_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUpdateconnectionfile.Visible), 5, 0)), true);
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E120X2 ();
         if (returnInSub) return;
      }

      protected void E120X2( )
      {
         /* Enter Routine */
         AV30isOK = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            if ( StringUtil.StrCmp(StringUtil.Trim( AV8AdministratorUserPassword), StringUtil.Trim( AV10ConfAdministratorUserPassword)) != 0 )
            {
               GX_msglist.addItem("The administrator password and confirmation do not match");
               AV30isOK = false;
            }
            if ( StringUtil.StrCmp(StringUtil.Trim( AV13ConnectionUserPassword), StringUtil.Trim( AV11ConfConnectionUserPassword)) != 0 )
            {
               GX_msglist.addItem("The connection password and confirmation do not match");
               AV30isOK = false;
            }
         }
         if ( AV30isOK )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               AV27GUID = Guid.NewGuid( ).ToString();
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GUID", AV27GUID);
               AV36RepositoryCreate.gxTpr_Guid = AV27GUID;
               AV36RepositoryCreate.gxTpr_Name = AV31Name;
               AV36RepositoryCreate.gxTpr_Namespace = AV32Namespace;
               AV36RepositoryCreate.gxTpr_Description = AV21Description;
               AV36RepositoryCreate.gxTpr_Administratorusername = AV7AdministratorUserName;
               AV36RepositoryCreate.gxTpr_Administratoruserpassword = AV8AdministratorUserPassword;
               AV36RepositoryCreate.gxTpr_Allowoauthaccess = AV9AllowOauthAccess;
               AV36RepositoryCreate.gxTpr_Canregisterusers = AV40CanRegisterUsers;
               AV36RepositoryCreate.gxTpr_Connectionusername = AV12ConnectionUserName;
               AV36RepositoryCreate.gxTpr_Connectionuserpassword = AV13ConnectionUserPassword;
               AV36RepositoryCreate.gxTpr_Giveanonymoussession = AV26GiveAnonymousSession;
               AV30isOK = AV24GAM.createrepository(AV36RepositoryCreate, AV39UpdateConnectionFile, out  AV23Errors);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               AV30isOK = new SdtGAM(context).deleterepository(AV35Repository.gxTpr_Guid, out  AV23Errors);
            }
         }
         if ( AV30isOK )
         {
            pr_gam.commit( "GAMRepositoryEntry");
            pr_default.commit( "GAMRepositoryEntry");
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         else
         {
            /* Execute user subroutine: 'DISPLAYERRORS' */
            S112 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36RepositoryCreate", AV36RepositoryCreate);
      }

      protected void S112( )
      {
         /* 'DISPLAYERRORS' Routine */
         AV49GXV1 = 1;
         while ( AV49GXV1 <= AV23Errors.Count )
         {
            AV22Error = ((SdtGAMError)AV23Errors.Item(AV49GXV1));
            GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV22Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV22Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
            AV49GXV1 = (int)(AV49GXV1+1);
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E130X2( )
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
         AV28Id = Convert.ToInt32(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28Id), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV28Id), "ZZZZZZZZ9"), context));
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
         PA0X2( ) ;
         WS0X2( ) ;
         WE0X2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019415876", true);
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
         context.AddJavascriptSource("gamrepositoryentry.js", "?201892019415880", false);
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
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtavGuid_Internalname = "vGUID";
         edtavName_Internalname = "vNAME";
         edtavNamespace_Internalname = "vNAMESPACE";
         edtavDescription_Internalname = "vDESCRIPTION";
         chkavAllowoauthaccess_Internalname = "vALLOWOAUTHACCESS";
         chkavCanregisterusers_Internalname = "vCANREGISTERUSERS";
         chkavGiveanonymoussession_Internalname = "vGIVEANONYMOUSSESSION";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         edtavConnectionusername_Internalname = "vCONNECTIONUSERNAME";
         edtavConnectionuserpassword_Internalname = "vCONNECTIONUSERPASSWORD";
         edtavConfconnectionuserpassword_Internalname = "vCONFCONNECTIONUSERPASSWORD";
         divConn_Internalname = "CONN";
         divLayout_conn_Internalname = "LAYOUT_CONN";
         Dvpanel_conn_Internalname = "DVPANEL_CONN";
         divHtml_dvpanel_conn_Internalname = "HTML_DVPANEL_CONN";
         edtavAdministratorusername_Internalname = "vADMINISTRATORUSERNAME";
         edtavAdministratoruserpassword_Internalname = "vADMINISTRATORUSERPASSWORD";
         edtavConfadministratoruserpassword_Internalname = "vCONFADMINISTRATORUSERPASSWORD";
         divAdmin_Internalname = "ADMIN";
         divLayout_admin_Internalname = "LAYOUT_ADMIN";
         Dvpanel_admin_Internalname = "DVPANEL_ADMIN";
         divHtml_dvpanel_admin_Internalname = "HTML_DVPANEL_ADMIN";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         chkavUpdateconnectionfile_Internalname = "vUPDATECONNECTIONFILE";
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
         chkavUpdateconnectionfile.Caption = "";
         chkavGiveanonymoussession.Caption = "";
         chkavCanregisterusers.Caption = "";
         chkavAllowoauthaccess.Caption = "";
         chkavUpdateconnectionfile.Visible = 1;
         edtavConfadministratoruserpassword_Jsonclick = "";
         edtavConfadministratoruserpassword_Ispassword = 0;
         edtavConfadministratoruserpassword_Enabled = 1;
         edtavAdministratoruserpassword_Jsonclick = "";
         edtavAdministratoruserpassword_Ispassword = 0;
         edtavAdministratoruserpassword_Enabled = 1;
         edtavAdministratorusername_Jsonclick = "";
         edtavAdministratorusername_Enabled = 1;
         divAdmin_Visible = 1;
         edtavConfconnectionuserpassword_Jsonclick = "";
         edtavConfconnectionuserpassword_Ispassword = 0;
         edtavConfconnectionuserpassword_Enabled = 1;
         edtavConnectionuserpassword_Jsonclick = "";
         edtavConnectionuserpassword_Ispassword = 0;
         edtavConnectionuserpassword_Enabled = 1;
         edtavConnectionusername_Jsonclick = "";
         edtavConnectionusername_Enabled = 1;
         divConn_Visible = 1;
         chkavGiveanonymoussession.Enabled = 1;
         chkavCanregisterusers.Enabled = 1;
         chkavAllowoauthaccess.Enabled = 1;
         edtavDescription_Jsonclick = "";
         edtavDescription_Enabled = 1;
         edtavNamespace_Jsonclick = "";
         edtavNamespace_Enabled = 1;
         edtavName_Jsonclick = "";
         edtavName_Enabled = 1;
         edtavGuid_Jsonclick = "";
         edtavGuid_Enabled = 1;
         Dvpanel_admin_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_admin_Iconposition = "left";
         Dvpanel_admin_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_admin_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_admin_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_admin_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_admin_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_admin_Title = "Administrator";
         Dvpanel_admin_Cls = "PanelCard_BaseColor";
         Dvpanel_admin_Width = "100%";
         Dvpanel_conn_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_conn_Iconposition = "left";
         Dvpanel_conn_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_conn_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_conn_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_conn_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_conn_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_conn_Title = "Connection User";
         Dvpanel_conn_Cls = "PanelCard_BaseColor";
         Dvpanel_conn_Width = "100%";
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "Repository";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Repository ";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV28Id',fld:'vID',pic:'ZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("ENTER","{handler:'E120X2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV8AdministratorUserPassword',fld:'vADMINISTRATORUSERPASSWORD',pic:'',nv:''},{av:'AV10ConfAdministratorUserPassword',fld:'vCONFADMINISTRATORUSERPASSWORD',pic:'',nv:''},{av:'AV13ConnectionUserPassword',fld:'vCONNECTIONUSERPASSWORD',pic:'',nv:''},{av:'AV11ConfConnectionUserPassword',fld:'vCONFCONNECTIONUSERPASSWORD',pic:'',nv:''},{av:'AV31Name',fld:'vNAME',pic:'',nv:''},{av:'AV32Namespace',fld:'vNAMESPACE',pic:'',nv:''},{av:'AV21Description',fld:'vDESCRIPTION',pic:'',nv:''},{av:'AV7AdministratorUserName',fld:'vADMINISTRATORUSERNAME',pic:'',nv:''},{av:'AV9AllowOauthAccess',fld:'vALLOWOAUTHACCESS',pic:'',nv:false},{av:'AV40CanRegisterUsers',fld:'vCANREGISTERUSERS',pic:'',nv:false},{av:'AV12ConnectionUserName',fld:'vCONNECTIONUSERNAME',pic:'',nv:''},{av:'AV26GiveAnonymousSession',fld:'vGIVEANONYMOUSSESSION',pic:'',nv:false},{av:'AV39UpdateConnectionFile',fld:'vUPDATECONNECTIONFILE',pic:'',nv:false}],oparms:[{av:'AV27GUID',fld:'vGUID',pic:'',nv:''}]}");
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
         TempTags = "";
         AV27GUID = "";
         AV31Name = "";
         AV32Namespace = "";
         AV21Description = "";
         AV12ConnectionUserName = "";
         AV13ConnectionUserPassword = "";
         AV11ConfConnectionUserPassword = "";
         AV7AdministratorUserName = "";
         AV8AdministratorUserPassword = "";
         AV10ConfAdministratorUserPassword = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV35Repository = new SdtGAMRepository(context);
         AV23Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV36RepositoryCreate = new SdtGAMRepositoryCreate(context);
         AV24GAM = new SdtGAM(context);
         AV22Error = new SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamrepositoryentry__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamrepositoryentry__default(),
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
      private short edtavConnectionuserpassword_Ispassword ;
      private short edtavConfconnectionuserpassword_Ispassword ;
      private short edtavAdministratoruserpassword_Ispassword ;
      private short edtavConfadministratoruserpassword_Ispassword ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int AV28Id ;
      private int wcpOAV28Id ;
      private int edtavGuid_Enabled ;
      private int edtavName_Enabled ;
      private int edtavNamespace_Enabled ;
      private int edtavDescription_Enabled ;
      private int divConn_Visible ;
      private int edtavConnectionusername_Enabled ;
      private int edtavConnectionuserpassword_Enabled ;
      private int edtavConfconnectionuserpassword_Enabled ;
      private int divAdmin_Visible ;
      private int edtavAdministratorusername_Enabled ;
      private int edtavAdministratoruserpassword_Enabled ;
      private int edtavConfadministratoruserpassword_Enabled ;
      private int AV49GXV1 ;
      private int idxLst ;
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
      private String Dvpanel_conn_Width ;
      private String Dvpanel_conn_Cls ;
      private String Dvpanel_conn_Title ;
      private String Dvpanel_conn_Iconposition ;
      private String Dvpanel_admin_Width ;
      private String Dvpanel_admin_Cls ;
      private String Dvpanel_admin_Title ;
      private String Dvpanel_admin_Iconposition ;
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
      private String edtavGuid_Internalname ;
      private String TempTags ;
      private String AV27GUID ;
      private String edtavGuid_Jsonclick ;
      private String edtavName_Internalname ;
      private String AV31Name ;
      private String edtavName_Jsonclick ;
      private String edtavNamespace_Internalname ;
      private String AV32Namespace ;
      private String edtavNamespace_Jsonclick ;
      private String edtavDescription_Internalname ;
      private String AV21Description ;
      private String edtavDescription_Jsonclick ;
      private String chkavAllowoauthaccess_Internalname ;
      private String chkavCanregisterusers_Internalname ;
      private String chkavGiveanonymoussession_Internalname ;
      private String divHtml_dvpanel_conn_Internalname ;
      private String divLayout_conn_Internalname ;
      private String divConn_Internalname ;
      private String edtavConnectionusername_Internalname ;
      private String AV12ConnectionUserName ;
      private String edtavConnectionusername_Jsonclick ;
      private String edtavConnectionuserpassword_Internalname ;
      private String AV13ConnectionUserPassword ;
      private String edtavConnectionuserpassword_Jsonclick ;
      private String edtavConfconnectionuserpassword_Internalname ;
      private String AV11ConfConnectionUserPassword ;
      private String edtavConfconnectionuserpassword_Jsonclick ;
      private String divHtml_dvpanel_admin_Internalname ;
      private String divLayout_admin_Internalname ;
      private String divAdmin_Internalname ;
      private String edtavAdministratorusername_Internalname ;
      private String AV7AdministratorUserName ;
      private String edtavAdministratorusername_Jsonclick ;
      private String edtavAdministratoruserpassword_Internalname ;
      private String AV8AdministratorUserPassword ;
      private String edtavAdministratoruserpassword_Jsonclick ;
      private String edtavConfadministratoruserpassword_Internalname ;
      private String AV10ConfAdministratorUserPassword ;
      private String edtavConfadministratoruserpassword_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String chkavUpdateconnectionfile_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Dvpanel_tableattributes_Internalname ;
      private String Dvpanel_conn_Internalname ;
      private String Dvpanel_admin_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool Dvpanel_conn_Collapsible ;
      private bool Dvpanel_conn_Collapsed ;
      private bool Dvpanel_conn_Autowidth ;
      private bool Dvpanel_conn_Autoheight ;
      private bool Dvpanel_conn_Showcollapseicon ;
      private bool Dvpanel_conn_Autoscroll ;
      private bool Dvpanel_admin_Collapsible ;
      private bool Dvpanel_admin_Collapsed ;
      private bool Dvpanel_admin_Autowidth ;
      private bool Dvpanel_admin_Autoheight ;
      private bool Dvpanel_admin_Showcollapseicon ;
      private bool Dvpanel_admin_Autoscroll ;
      private bool wbLoad ;
      private bool AV9AllowOauthAccess ;
      private bool AV40CanRegisterUsers ;
      private bool AV26GiveAnonymousSession ;
      private bool AV39UpdateConnectionFile ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV30isOK ;
      private SdtGAM AV24GAM ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavAllowoauthaccess ;
      private GXCheckbox chkavCanregisterusers ;
      private GXCheckbox chkavGiveanonymoussession ;
      private GXCheckbox chkavUpdateconnectionfile ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMError> AV23Errors ;
      private GXWebForm Form ;
      private SdtGAMError AV22Error ;
      private SdtGAMRepositoryCreate AV36RepositoryCreate ;
      private SdtGAMRepository AV35Repository ;
   }

   public class gamrepositoryentry__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamrepositoryentry__default : DataStoreHelperBase, IDataStoreHelper
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
