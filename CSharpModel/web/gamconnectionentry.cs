/*
               File: GAMConnectionEntry
        Description: Connection
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:43:0.88
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
   public class gamconnectionentry : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamconnectionentry( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamconnectionentry( IGxContext context )
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
                           String aP1_pConnectionName )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV13pConnectionName = aP1_pConnectionName;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
                  AV13pConnectionName = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pConnectionName", AV13pConnectionName);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPCONNECTIONNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV13pConnectionName, "")), context));
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
         PA132( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START132( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20189201943131", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamconnectionentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV13pConnectionName))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vPCONNECTIONNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV13pConnectionName, "")), context));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
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
         GxWebStd.gx_hidden_field( context, "DVPANEL_GAMCONNECTION_Width", StringUtil.RTrim( Dvpanel_gamconnection_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_GAMCONNECTION_Cls", StringUtil.RTrim( Dvpanel_gamconnection_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_GAMCONNECTION_Title", StringUtil.RTrim( Dvpanel_gamconnection_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_GAMCONNECTION_Collapsible", StringUtil.BoolToStr( Dvpanel_gamconnection_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_GAMCONNECTION_Collapsed", StringUtil.BoolToStr( Dvpanel_gamconnection_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_GAMCONNECTION_Autowidth", StringUtil.BoolToStr( Dvpanel_gamconnection_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_GAMCONNECTION_Autoheight", StringUtil.BoolToStr( Dvpanel_gamconnection_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_GAMCONNECTION_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_gamconnection_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_GAMCONNECTION_Iconposition", StringUtil.RTrim( Dvpanel_gamconnection_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_GAMCONNECTION_Autoscroll", StringUtil.BoolToStr( Dvpanel_gamconnection_Autoscroll));
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
            WE132( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT132( ) ;
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
         return formatLink("gamconnectionentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV13pConnectionName)) ;
      }

      public override String GetPgmname( )
      {
         return "GAMConnectionEntry" ;
      }

      public override String GetPgmdesc( )
      {
         return "Connection" ;
      }

      protected void WB130( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConnectionname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConnectionname_Internalname, "Connection name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavConnectionname_Internalname, StringUtil.RTrim( AV8ConnectionName), StringUtil.RTrim( context.localUtil.Format( AV8ConnectionName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavConnectionname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavConnectionname_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMConnectionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUsername_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUsername_Internalname, "User name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUsername_Internalname, StringUtil.RTrim( AV14UserName), StringUtil.RTrim( context.localUtil.Format( AV14UserName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUsername_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUsername_Enabled, 1, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMConnectionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUserpassword_cell_Internalname, 1, 0, "px", 0, "px", divUserpassword_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavUserpassword_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserpassword_Internalname, "User password", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserpassword_Internalname, StringUtil.RTrim( AV15UserPassword), StringUtil.RTrim( context.localUtil.Format( AV15UserPassword, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserpassword_Jsonclick, 0, "Attribute", "", "", "", "", edtavUserpassword_Visible, edtavUserpassword_Enabled, 0, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMConnectionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavChallengeexpire_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavChallengeexpire_Internalname, "Connection challenge expire (minutes)", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavChallengeexpire_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5ChallengeExpire), 6, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV5ChallengeExpire), "ZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "(0 = Never expires)", edtavChallengeexpire_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavChallengeexpire_Enabled, 1, "text", "", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMConnectionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedkey_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockkey_Internalname, "Encription Key", "", "", lblTextblockkey_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMConnectionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_48_132( true) ;
         }
         else
         {
            wb_table1_48_132( false) ;
         }
         return  ;
      }

      protected void wb_table1_48_132e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divDvpanel_gamconnection_cell_Internalname, 1, 0, "px", 0, "px", divDvpanel_gamconnection_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_gamconnection_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_GAMCONNECTIONContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_GAMCONNECTIONContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_gamconnection_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGamconnection_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavConnectionfilexml_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavConnectionfilexml_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavConnectionfilexml_Internalname, "Connection File XML", "col-sm-3 AttributeWidthAutoLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            ClassString = "AttributeWidthAuto";
            StyleString = "";
            ClassString = "AttributeWidthAuto";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavConnectionfilexml_Internalname, StringUtil.RTrim( AV7ConnectionFileXML), "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,67);\"", 0, edtavConnectionfilexml_Visible, edtavConnectionfilexml_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_GAMConnectionEntry.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", bttBtnenter_Caption, bttBtnenter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtnenter_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMConnectionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Fechar", bttBtncancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMConnectionEntry.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavPconnectionname_Internalname, StringUtil.RTrim( AV13pConnectionName), StringUtil.RTrim( context.localUtil.Format( AV13pConnectionName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPconnectionname_Jsonclick, 0, "Attribute", "", "", "", "", edtavPconnectionname_Visible, 0, 0, "text", "", 0, "px", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMConnectionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START132( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Connection", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP130( ) ;
      }

      protected void WS132( )
      {
         START132( ) ;
         EVT132( ) ;
      }

      protected void EVT132( )
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
                              E11132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOGENKEY'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoGenKey' */
                              E12132 ();
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
                                    E13132 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E14132 ();
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

      protected void WE132( )
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

      protected void PA132( )
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
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavConnectionname_Internalname;
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
         RF132( ) ;
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

      protected void RF132( )
      {
         initialize_formulas( ) ;
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E14132 ();
            WB130( ) ;
         }
      }

      protected void send_integrity_lvl_hashes132( )
      {
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void STRUP130( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11132 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV8ConnectionName = cgiGet( edtavConnectionname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ConnectionName", AV8ConnectionName);
            AV14UserName = cgiGet( edtavUsername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14UserName", AV14UserName);
            AV15UserPassword = cgiGet( edtavUserpassword_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15UserPassword", AV15UserPassword);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavChallengeexpire_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavChallengeexpire_Internalname), ",", ".") > Convert.ToDecimal( 999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCHALLENGEEXPIRE");
               GX_FocusControl = edtavChallengeexpire_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5ChallengeExpire = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5ChallengeExpire", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5ChallengeExpire), 6, 0)));
            }
            else
            {
               AV5ChallengeExpire = (int)(context.localUtil.CToN( cgiGet( edtavChallengeexpire_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5ChallengeExpire", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5ChallengeExpire), 6, 0)));
            }
            AV12Key = cgiGet( edtavKey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Key", AV12Key);
            AV7ConnectionFileXML = cgiGet( edtavConnectionfilexml_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConnectionFileXML", AV7ConnectionFileXML);
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
            Dvpanel_gamconnection_Width = cgiGet( "DVPANEL_GAMCONNECTION_Width");
            Dvpanel_gamconnection_Cls = cgiGet( "DVPANEL_GAMCONNECTION_Cls");
            Dvpanel_gamconnection_Title = cgiGet( "DVPANEL_GAMCONNECTION_Title");
            Dvpanel_gamconnection_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_GAMCONNECTION_Collapsible"));
            Dvpanel_gamconnection_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_GAMCONNECTION_Collapsed"));
            Dvpanel_gamconnection_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_GAMCONNECTION_Autowidth"));
            Dvpanel_gamconnection_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_GAMCONNECTION_Autoheight"));
            Dvpanel_gamconnection_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_GAMCONNECTION_Showcollapseicon"));
            Dvpanel_gamconnection_Iconposition = cgiGet( "DVPANEL_GAMCONNECTION_Iconposition");
            Dvpanel_gamconnection_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_GAMCONNECTION_Autoscroll"));
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
         E11132 ();
         if (returnInSub) return;
      }

      protected void E11132( )
      {
         /* Start Routine */
         AV8ConnectionName = AV13pConnectionName;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ConnectionName", AV8ConnectionName);
         GX_FocusControl = edtavConnectionname_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         context.DoAjaxSetFocus(GX_FocusControl);
         edtavConnectionfilexml_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConnectionfilexml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavConnectionfilexml_Visible), 5, 0)), true);
         edtavPconnectionname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPconnectionname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPconnectionname_Visible), 5, 0)), true);
         edtavConnectionname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConnectionname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavConnectionname_Enabled), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            edtavConnectionname_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConnectionname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavConnectionname_Enabled), 5, 0)), true);
            edtavUsername_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsername_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsername_Enabled), 5, 0)), true);
         }
         else
         {
            AV6Connection.load( AV8ConnectionName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ConnectionName", AV8ConnectionName);
            AV14UserName = AV6Connection.gxTpr_Username;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14UserName", AV14UserName);
            AV15UserPassword = AV6Connection.gxTpr_Userpassword;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15UserPassword", AV15UserPassword);
            AV5ChallengeExpire = AV6Connection.gxTpr_Challengeexpire;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5ChallengeExpire", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5ChallengeExpire), 6, 0)));
            AV12Key = AV6Connection.gxTpr_Key;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Key", AV12Key);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "XML") == 0 ) )
         {
            bttBtnenter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnenter_Visible), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "XML") == 0 ) )
         {
            bttBtngenkey_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtngenkey_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtngenkey_Visible), 5, 0)), true);
            edtavConnectionname_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConnectionname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavConnectionname_Enabled), 5, 0)), true);
            edtavChallengeexpire_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavChallengeexpire_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavChallengeexpire_Enabled), 5, 0)), true);
            edtavUsername_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsername_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsername_Enabled), 5, 0)), true);
            edtavKey_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavKey_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavKey_Enabled), 5, 0)), true);
            bttBtnenter_Caption = "Delete";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenter_Internalname, "Caption", bttBtnenter_Caption, true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "XML") == 0 )
         {
            edtavConnectionfilexml_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConnectionfilexml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavConnectionfilexml_Visible), 5, 0)), true);
            AV11isOk = new SdtGAMRepository(context).generateconnectionfile(AV8ConnectionName, out  AV7ConnectionFileXML, out  AV10Errors);
            if ( ! AV11isOk )
            {
               /* Execute user subroutine: 'DISPLAYMESSAGES' */
               S112 ();
               if (returnInSub) return;
            }
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S122 ();
         if (returnInSub) return;
         edtavPconnectionname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPconnectionname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPconnectionname_Visible), 5, 0)), true);
      }

      protected void E12132( )
      {
         /* 'DoGenKey' Routine */
         AV12Key = Crypto.GetEncryptionKey( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Key", AV12Key);
         /*  Sending Event outputs  */
      }

      protected void S122( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         if ( ! ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) )
         {
            edtavUserpassword_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserpassword_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserpassword_Visible), 5, 0)), true);
            divUserpassword_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserpassword_cell_Internalname, "Class", divUserpassword_cell_Class, true);
         }
         else
         {
            edtavUserpassword_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserpassword_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserpassword_Visible), 5, 0)), true);
            divUserpassword_cell_Class = "col-xs-12 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserpassword_cell_Internalname, "Class", divUserpassword_cell_Class, true);
         }
         if ( ! ( ( StringUtil.StrCmp(Gx_mode, "XML") == 0 ) ) )
         {
            divDvpanel_gamconnection_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divDvpanel_gamconnection_cell_Internalname, "Class", divDvpanel_gamconnection_cell_Class, true);
         }
         else
         {
            divDvpanel_gamconnection_cell_Class = "col-xs-12 CellMarginTop";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divDvpanel_gamconnection_cell_Internalname, "Class", divDvpanel_gamconnection_cell_Class, true);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E13132 ();
         if (returnInSub) return;
      }

      protected void E13132( )
      {
         /* Enter Routine */
         AV6Connection.load( AV8ConnectionName);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ConnectionName", AV8ConnectionName);
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) )
         {
            AV6Connection.gxTpr_Username = AV14UserName;
            AV6Connection.gxTpr_Userpassword = AV15UserPassword;
            AV6Connection.gxTpr_Challengeexpire = AV5ChallengeExpire;
            AV6Connection.gxTpr_Key = AV12Key;
            AV6Connection.save();
         }
         else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            AV6Connection.delete();
         }
         if ( AV6Connection.success() )
         {
            pr_gam.commit( "GAMConnectionEntry");
            pr_default.commit( "GAMConnectionEntry");
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         else
         {
            AV10Errors = AV6Connection.geterrors();
            /* Execute user subroutine: 'DISPLAYMESSAGES' */
            S112 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'DISPLAYMESSAGES' Routine */
         AV24GXV1 = 1;
         while ( AV24GXV1 <= AV10Errors.Count )
         {
            AV9Error = ((SdtGAMError)AV10Errors.Item(AV24GXV1));
            if ( AV9Error.gxTpr_Code != 13 )
            {
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV9Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV9Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
            }
            AV24GXV1 = (int)(AV24GXV1+1);
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E14132( )
      {
         /* Load Routine */
      }

      protected void wb_table1_48_132( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedkey_Internalname, tblTablemergedkey_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavKey_Internalname, "Key", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavKey_Internalname, StringUtil.RTrim( AV12Key), StringUtil.RTrim( context.localUtil.Format( AV12Key, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavKey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavKey_Enabled, 1, "text", "", 32, "chr", 1, "row", 32, 0, 0, 0, 1, -1, 0, true, "GAMEncryptionKey", "left", true, "HLP_GAMConnectionEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtngenkey_Internalname, "", "Generate Key", bttBtngenkey_Jsonclick, 5, "Generate Key", "", StyleString, ClassString, bttBtngenkey_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOGENKEY\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMConnectionEntry.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_48_132e( true) ;
         }
         else
         {
            wb_table1_48_132e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         Gx_mode = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         AV13pConnectionName = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pConnectionName", AV13pConnectionName);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPCONNECTIONNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV13pConnectionName, "")), context));
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
         PA132( ) ;
         WS132( ) ;
         WE132( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019431132", true);
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
         context.AddJavascriptSource("gamconnectionentry.js", "?201892019431135", false);
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
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtavConnectionname_Internalname = "vCONNECTIONNAME";
         edtavUsername_Internalname = "vUSERNAME";
         edtavUserpassword_Internalname = "vUSERPASSWORD";
         divUserpassword_cell_Internalname = "USERPASSWORD_CELL";
         edtavChallengeexpire_Internalname = "vCHALLENGEEXPIRE";
         lblTextblockkey_Internalname = "TEXTBLOCKKEY";
         edtavKey_Internalname = "vKEY";
         bttBtngenkey_Internalname = "BTNGENKEY";
         tblTablemergedkey_Internalname = "TABLEMERGEDKEY";
         divTablesplittedkey_Internalname = "TABLESPLITTEDKEY";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         edtavConnectionfilexml_Internalname = "vCONNECTIONFILEXML";
         divGamconnection_Internalname = "GAMCONNECTION";
         divLayout_gamconnection_Internalname = "LAYOUT_GAMCONNECTION";
         Dvpanel_gamconnection_Internalname = "DVPANEL_GAMCONNECTION";
         divHtml_dvpanel_gamconnection_Internalname = "HTML_DVPANEL_GAMCONNECTION";
         divDvpanel_gamconnection_cell_Internalname = "DVPANEL_GAMCONNECTION_CELL";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavPconnectionname_Internalname = "vPCONNECTIONNAME";
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
         bttBtngenkey_Visible = 1;
         edtavKey_Jsonclick = "";
         edtavKey_Enabled = 1;
         edtavPconnectionname_Jsonclick = "";
         edtavPconnectionname_Visible = 1;
         bttBtnenter_Caption = "Confirmar";
         bttBtnenter_Visible = 1;
         edtavConnectionfilexml_Enabled = 1;
         edtavConnectionfilexml_Visible = 1;
         divDvpanel_gamconnection_cell_Class = "col-xs-12";
         edtavChallengeexpire_Jsonclick = "";
         edtavChallengeexpire_Enabled = 1;
         edtavUserpassword_Jsonclick = "";
         edtavUserpassword_Enabled = 1;
         edtavUserpassword_Visible = 1;
         divUserpassword_cell_Class = "col-xs-12";
         edtavUsername_Jsonclick = "";
         edtavUsername_Enabled = 1;
         edtavConnectionname_Jsonclick = "";
         edtavConnectionname_Enabled = 1;
         Dvpanel_gamconnection_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_gamconnection_Iconposition = "left";
         Dvpanel_gamconnection_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_gamconnection_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_gamconnection_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_gamconnection_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_gamconnection_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_gamconnection_Title = "Content of connection.gam";
         Dvpanel_gamconnection_Cls = "PanelCard_BaseColor";
         Dvpanel_gamconnection_Width = "100%";
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "Connection";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Connection";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV13pConnectionName',fld:'vPCONNECTIONNAME',pic:'',hsh:true,nv:''}],oparms:[]}");
         setEventMetadata("'DOGENKEY'","{handler:'E12132',iparms:[],oparms:[{av:'AV12Key',fld:'vKEY',pic:'',nv:''}]}");
         setEventMetadata("ENTER","{handler:'E13132',iparms:[{av:'AV8ConnectionName',fld:'vCONNECTIONNAME',pic:'',nv:''},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV14UserName',fld:'vUSERNAME',pic:'',nv:''},{av:'AV15UserPassword',fld:'vUSERPASSWORD',pic:'',nv:''},{av:'AV5ChallengeExpire',fld:'vCHALLENGEEXPIRE',pic:'ZZZZZ9',nv:0},{av:'AV12Key',fld:'vKEY',pic:'',nv:''}],oparms:[]}");
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
         wcpOAV13pConnectionName = "";
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
         AV8ConnectionName = "";
         AV14UserName = "";
         AV15UserPassword = "";
         lblTextblockkey_Jsonclick = "";
         AV7ConnectionFileXML = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV12Key = "";
         AV6Connection = new SdtGAMRepositoryConnection(context);
         AV10Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV9Error = new SdtGAMError(context);
         sStyleString = "";
         bttBtngenkey_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamconnectionentry__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamconnectionentry__default(),
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
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavConnectionname_Enabled ;
      private int edtavUsername_Enabled ;
      private int edtavUserpassword_Visible ;
      private int edtavUserpassword_Enabled ;
      private int AV5ChallengeExpire ;
      private int edtavChallengeexpire_Enabled ;
      private int edtavConnectionfilexml_Visible ;
      private int edtavConnectionfilexml_Enabled ;
      private int bttBtnenter_Visible ;
      private int edtavPconnectionname_Visible ;
      private int bttBtngenkey_Visible ;
      private int edtavKey_Enabled ;
      private int AV24GXV1 ;
      private int idxLst ;
      private String Gx_mode ;
      private String AV13pConnectionName ;
      private String wcpOGx_mode ;
      private String wcpOAV13pConnectionName ;
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
      private String Dvpanel_gamconnection_Width ;
      private String Dvpanel_gamconnection_Cls ;
      private String Dvpanel_gamconnection_Title ;
      private String Dvpanel_gamconnection_Iconposition ;
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
      private String edtavConnectionname_Internalname ;
      private String TempTags ;
      private String AV8ConnectionName ;
      private String edtavConnectionname_Jsonclick ;
      private String edtavUsername_Internalname ;
      private String AV14UserName ;
      private String edtavUsername_Jsonclick ;
      private String divUserpassword_cell_Internalname ;
      private String divUserpassword_cell_Class ;
      private String edtavUserpassword_Internalname ;
      private String AV15UserPassword ;
      private String edtavUserpassword_Jsonclick ;
      private String edtavChallengeexpire_Internalname ;
      private String edtavChallengeexpire_Jsonclick ;
      private String divTablesplittedkey_Internalname ;
      private String lblTextblockkey_Internalname ;
      private String lblTextblockkey_Jsonclick ;
      private String divDvpanel_gamconnection_cell_Internalname ;
      private String divDvpanel_gamconnection_cell_Class ;
      private String divHtml_dvpanel_gamconnection_Internalname ;
      private String divLayout_gamconnection_Internalname ;
      private String divGamconnection_Internalname ;
      private String edtavConnectionfilexml_Internalname ;
      private String AV7ConnectionFileXML ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Caption ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavPconnectionname_Internalname ;
      private String edtavPconnectionname_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV12Key ;
      private String edtavKey_Internalname ;
      private String bttBtngenkey_Internalname ;
      private String sStyleString ;
      private String tblTablemergedkey_Internalname ;
      private String edtavKey_Jsonclick ;
      private String bttBtngenkey_Jsonclick ;
      private String Dvpanel_tableattributes_Internalname ;
      private String Dvpanel_gamconnection_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool Dvpanel_gamconnection_Collapsible ;
      private bool Dvpanel_gamconnection_Collapsed ;
      private bool Dvpanel_gamconnection_Autowidth ;
      private bool Dvpanel_gamconnection_Autoheight ;
      private bool Dvpanel_gamconnection_Showcollapseicon ;
      private bool Dvpanel_gamconnection_Autoscroll ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV11isOk ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMError> AV10Errors ;
      private GXWebForm Form ;
      private SdtGAMRepositoryConnection AV6Connection ;
      private SdtGAMError AV9Error ;
   }

   public class gamconnectionentry__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamconnectionentry__default : DataStoreHelperBase, IDataStoreHelper
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
