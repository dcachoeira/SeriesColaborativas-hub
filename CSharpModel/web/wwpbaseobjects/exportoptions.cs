/*
               File: WWPBaseObjects.ExportOptions
        Description: Opções para Exportar para Excel
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:39:36.89
       Program type: Main program
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs.wwpbaseobjects {
   public class exportoptions : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public exportoptions( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public exportoptions( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_ExcelFileName ,
                           String aP1_DefaultTitle )
      {
         this.AV12ExcelFileName = aP0_ExcelFileName;
         this.AV9DefaultTitle = aP1_DefaultTitle;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavExporttype = new GXCombobox();
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
               AV12ExcelFileName = gxfirstwebparm;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12ExcelFileName", AV12ExcelFileName);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEXCELFILENAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV12ExcelFileName, "")), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9DefaultTitle = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9DefaultTitle", AV9DefaultTitle);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vDEFAULTTITLE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV9DefaultTitle, "")), context));
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
            ValidateSpaRequest();
            PA082( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS082( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE082( ) ;
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, false);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( "Opções para Exportar para Excel") ;
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
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 121631), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxcfg.js", "?201892019393695", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("Window/InNewWindowRender.js", "", false);
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
         }
         context.WriteHtmlText( " "+"class=\"FormNoBackgroundColor\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"FormNoBackgroundColor\" data-gx-class=\"FormNoBackgroundColor\" novalidate action=\""+formatLink("wwpbaseobjects.exportoptions.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12ExcelFileName)) + "," + UrlEncode(StringUtil.RTrim(AV9DefaultTitle))+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "FormNoBackgroundColor", true);
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
         GxWebStd.gx_hidden_field( context, "vGOOGLEDOCRESULTXML", AV14GoogleDocResultXML);
         GxWebStd.gx_hidden_field( context, "vEXCELFILENAME", AV12ExcelFileName);
         GxWebStd.gx_hidden_field( context, "gxhash_vEXCELFILENAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV12ExcelFileName, "")), context));
         GxWebStd.gx_hidden_field( context, "vDEFAULTTITLE", StringUtil.RTrim( AV9DefaultTitle));
         GxWebStd.gx_hidden_field( context, "gxhash_vDEFAULTTITLE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV9DefaultTitle, "")), context));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEEXPORT_Width", StringUtil.RTrim( Dvpanel_tableexport_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEEXPORT_Cls", StringUtil.RTrim( Dvpanel_tableexport_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEEXPORT_Title", StringUtil.RTrim( Dvpanel_tableexport_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEEXPORT_Collapsible", StringUtil.BoolToStr( Dvpanel_tableexport_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEEXPORT_Collapsed", StringUtil.BoolToStr( Dvpanel_tableexport_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEEXPORT_Autowidth", StringUtil.BoolToStr( Dvpanel_tableexport_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEEXPORT_Autoheight", StringUtil.BoolToStr( Dvpanel_tableexport_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEEXPORT_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableexport_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEEXPORT_Iconposition", StringUtil.RTrim( Dvpanel_tableexport_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEEXPORT_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableexport_Autoscroll));
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
         GxWebStd.gx_hidden_field( context, "INNEWWINDOW1_Width", StringUtil.RTrim( Innewwindow1_Width));
         GxWebStd.gx_hidden_field( context, "INNEWWINDOW1_Height", StringUtil.RTrim( Innewwindow1_Height));
         GxWebStd.gx_hidden_field( context, "INNEWWINDOW1_Target", StringUtil.RTrim( Innewwindow1_Target));
      }

      protected void RenderHtmlCloseForm082( )
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
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.ExportOptions" ;
      }

      public override String GetPgmdesc( )
      {
         return "Opções para Exportar para Excel" ;
      }

      protected void WB080( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            wb_table1_2_082( true) ;
         }
         else
         {
            wb_table1_2_082( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_082e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true;
      }

      protected void START082( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Opções para Exportar para Excel", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP080( ) ;
      }

      protected void WS082( )
      {
         START082( ) ;
         EVT082( ) ;
      }

      protected void EVT082( )
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
                           E11082 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'DODOWNLOADTOFILE'") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'DoDownloadToFile' */
                           E12082 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'DOSAVEGOOGLEDRIVE'") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'DoSaveGoogleDrive' */
                           E13082 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E14082 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( ! wbErr )
                           {
                              Rfr0gs = false;
                              if ( ! Rfr0gs )
                              {
                              }
                              dynload_actions( ) ;
                           }
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

      protected void WE082( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm082( ) ;
            }
         }
      }

      protected void PA082( )
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
            cmbavExporttype.Name = "vEXPORTTYPE";
            cmbavExporttype.WebTags = "";
            cmbavExporttype.addItem("1", "Download to disk", 0);
            cmbavExporttype.addItem("2", "Upload to Google Drive", 0);
            if ( cmbavExporttype.ItemCount > 0 )
            {
               AV13ExportType = (short)(NumberUtil.Val( cmbavExporttype.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV13ExportType), 1, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ExportType", StringUtil.Str( (decimal)(AV13ExportType), 1, 0));
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
               GX_FocusControl = cmbavExporttype_Internalname;
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
         if ( cmbavExporttype.ItemCount > 0 )
         {
            AV13ExportType = (short)(NumberUtil.Val( cmbavExporttype.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV13ExportType), 1, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ExportType", StringUtil.Str( (decimal)(AV13ExportType), 1, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavExporttype.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV13ExportType), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavExporttype_Internalname, "Values", cmbavExporttype.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF082( ) ;
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

      protected void RF082( )
      {
         initialize_formulas( ) ;
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E14082 ();
            WB080( ) ;
         }
      }

      protected void send_integrity_lvl_hashes082( )
      {
      }

      protected void STRUP080( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11082 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbavExporttype.CurrentValue = cgiGet( cmbavExporttype_Internalname);
            AV13ExportType = (short)(NumberUtil.Val( cgiGet( cmbavExporttype_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ExportType", StringUtil.Str( (decimal)(AV13ExportType), 1, 0));
            AV22User = cgiGet( edtavUser_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22User", AV22User);
            AV5DocTitle = cgiGet( edtavDoctitle_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5DocTitle", AV5DocTitle);
            AV20Password = cgiGet( edtavPassword_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Password", AV20Password);
            /* Read saved values. */
            Dvpanel_tableexport_Width = cgiGet( "DVPANEL_TABLEEXPORT_Width");
            Dvpanel_tableexport_Cls = cgiGet( "DVPANEL_TABLEEXPORT_Cls");
            Dvpanel_tableexport_Title = cgiGet( "DVPANEL_TABLEEXPORT_Title");
            Dvpanel_tableexport_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEEXPORT_Collapsible"));
            Dvpanel_tableexport_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEEXPORT_Collapsed"));
            Dvpanel_tableexport_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEEXPORT_Autowidth"));
            Dvpanel_tableexport_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEEXPORT_Autoheight"));
            Dvpanel_tableexport_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEEXPORT_Showcollapseicon"));
            Dvpanel_tableexport_Iconposition = cgiGet( "DVPANEL_TABLEEXPORT_Iconposition");
            Dvpanel_tableexport_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEEXPORT_Autoscroll"));
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
            Innewwindow1_Width = cgiGet( "INNEWWINDOW1_Width");
            Innewwindow1_Height = cgiGet( "INNEWWINDOW1_Height");
            Innewwindow1_Target = cgiGet( "INNEWWINDOW1_Target");
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
         E11082 ();
         if (returnInSub) return;
      }

      protected void E11082( )
      {
         /* Start Routine */
         tblTablecontent_Height = 388;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablecontent_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablecontent_Height), 9, 0)), true);
         AV5DocTitle = AV9DefaultTitle;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5DocTitle", AV5DocTitle);
         AV5DocTitle = AV9DefaultTitle;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5DocTitle", AV5DocTitle);
         edtavPassword_Ispassword = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPassword_Internalname, "Ispassword", StringUtil.Str( (decimal)(edtavPassword_Ispassword), 1, 0), true);
         if ( StringUtil.StrCmp(AV16HttpRequest.Method, "GET") == 0 )
         {
            tblTablegoogledriveinfo_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablegoogledriveinfo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablegoogledriveinfo_Visible), 5, 0)), true);
            bttBtnsavegoogledrive_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnsavegoogledrive_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnsavegoogledrive_Visible), 5, 0)), true);
         }
         AV21URL = formatLink(AV12ExcelFileName) ;
         bttBtndownloadtofile_Jsonclick = "exportActionDownloadFile('"+AV21URL+"')";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtndownloadtofile_Internalname, "Jsonclick", bttBtndownloadtofile_Jsonclick, true);
         lblJs_Caption = "<script type=\"text/javascript\">function exportActionDownloadFile(u) { var element = document.createElement(\"iframe\"); element.setAttribute(\"src\", u);document.body.appendChild(element); return true; }</script>";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJs_Internalname, "Caption", lblJs_Caption, true);
      }

      protected void E12082( )
      {
         /* 'DoDownloadToFile' Routine */
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void E13082( )
      {
         /* 'DoSaveGoogleDrive' Routine */
         AV15GoogleDocsResult.FromXml(AV14GoogleDocResultXML, null, "Result", "DVelop.Extensions.GoogleDocs");
         if ( AV15GoogleDocsResult.gxTpr_Success )
         {
            Innewwindow1_Target = ((GeneXus.Programs.wwpbaseobjects.SdtGoogleDocsResult_Doc)AV15GoogleDocsResult.gxTpr_Docs.Item(1)).gxTpr_Url;
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Innewwindow1_Internalname, "Target", Innewwindow1_Target);
            Innewwindow1_Height = "600";
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Innewwindow1_Internalname, "Height", Innewwindow1_Height);
            Innewwindow1_Width = "800";
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Innewwindow1_Internalname, "Width", Innewwindow1_Width);
            this.executeUsercontrolMethod("", false, "INNEWWINDOW1Container", "OpenWindow", "", new Object[] {});
            GX_msglist.addItem("The document was succesully uploaded to Google Drive");
            bttBtncancel_Caption = "Fechar";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncancel_Internalname, "Caption", bttBtncancel_Caption, true);
            tblTablecontent_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablecontent_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablecontent_Visible), 5, 0)), true);
            bttBtndownloadtofile_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtndownloadtofile_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtndownloadtofile_Visible), 5, 0)), true);
            bttBtnsavegoogledrive_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnsavegoogledrive_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnsavegoogledrive_Visible), 5, 0)), true);
         }
         else
         {
            GX_msglist.addItem("Error uploading Spreadsheet:  "+AV15GoogleDocsResult.gxTpr_Error);
         }
         /*  Sending Event outputs  */
      }

      protected void nextLoad( )
      {
      }

      protected void E14082( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_082( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblJs_Internalname, lblJs_Caption, "", "", lblJs_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 2, "HLP_WWPBaseObjects\\ExportOptions.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "vertical-align:top")+"\" class='PopupContentCell'>") ;
            wb_table2_11_082( true) ;
         }
         else
         {
            wb_table2_11_082( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_082e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_51_082( true) ;
         }
         else
         {
            wb_table3_51_082( false) ;
         }
         return  ;
      }

      protected void wb_table3_51_082e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divActiongroup_actions_Internalname, 1, 0, "px", 0, "px", "ActionGroupRight", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndownloadtofile_Internalname, "", "Salvar", bttBtndownloadtofile_Jsonclick, 5, "", "", StyleString, ClassString, bttBtndownloadtofile_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DODOWNLOADTOFILE\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\ExportOptions.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnsavegoogledrive_Internalname, "", "Salvar", bttBtnsavegoogledrive_Jsonclick, 5, "", "", StyleString, ClassString, bttBtnsavegoogledrive_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOSAVEGOOGLEDRIVE\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\ExportOptions.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", bttBtncancel_Caption, bttBtncancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\ExportOptions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_082e( true) ;
         }
         else
         {
            wb_table1_2_082e( false) ;
         }
      }

      protected void wb_table3_51_082( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUt_Internalname, tblUt_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr class='Table'>") ;
            context.WriteHtmlText( "<td class='Table'>") ;
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"INNEWWINDOW1Container"+"\"></div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_51_082e( true) ;
         }
         else
         {
            wb_table3_51_082e( false) ;
         }
      }

      protected void wb_table2_11_082( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            if ( tblTablecontent_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;";
            }
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablecontent_Height), 10, 0)) + "px" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(560), 10, 0)) + "px" + ";";
            GxWebStd.gx_table_start( context, tblTablecontent_Internalname, tblTablecontent_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='ExportOptionsPanellCell'>") ;
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_TABLEEXPORTContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEEXPORTContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableexport_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableexport_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavExporttype_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavExporttype_Internalname, "Tipo de exportação", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavExporttype, cmbavExporttype_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV13ExportType), 1, 0)), 1, cmbavExporttype_Jsonclick, 7, "'"+""+"'"+",false,"+"'"+"e15081_client"+"'", "int", "", 1, cmbavExporttype.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,23);\"", "", true, "HLP_WWPBaseObjects\\ExportOptions.htm");
            cmbavExporttype.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV13ExportType), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavExporttype_Internalname, "Values", (String)(cmbavExporttype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='ExportOptionsPanellCell'>") ;
            wb_table4_26_082( true) ;
         }
         else
         {
            wb_table4_26_082( false) ;
         }
         return  ;
      }

      protected void wb_table4_26_082e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_082e( true) ;
         }
         else
         {
            wb_table2_11_082e( false) ;
         }
      }

      protected void wb_table4_26_082( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            if ( tblTablegoogledriveinfo_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;";
            }
            GxWebStd.gx_table_start( context, tblTablegoogledriveinfo_Internalname, tblTablegoogledriveinfo_Internalname, "", "Table100x100", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUser_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUser_Internalname, "E-mail", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUser_Internalname, StringUtil.RTrim( AV22User), StringUtil.RTrim( context.localUtil.Format( AV22User, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUser_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUser_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Description", "left", true, "HLP_WWPBaseObjects\\ExportOptions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavDoctitle_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavDoctitle_Internalname, "Título do documento", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDoctitle_Internalname, StringUtil.RTrim( AV5DocTitle), StringUtil.RTrim( context.localUtil.Format( AV5DocTitle, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDoctitle_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavDoctitle_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Description", "left", true, "HLP_WWPBaseObjects\\ExportOptions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavPassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPassword_Internalname, "Senha", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPassword_Internalname, StringUtil.RTrim( AV20Password), StringUtil.RTrim( context.localUtil.Format( AV20Password, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavPassword_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, edtavPassword_Ispassword, 0, 0, 1, -1, -1, true, "Description", "left", true, "HLP_WWPBaseObjects\\ExportOptions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_26_082e( true) ;
         }
         else
         {
            wb_table4_26_082e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12ExcelFileName = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12ExcelFileName", AV12ExcelFileName);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEXCELFILENAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV12ExcelFileName, "")), context));
         AV9DefaultTitle = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9DefaultTitle", AV9DefaultTitle);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vDEFAULTTITLE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV9DefaultTitle, "")), context));
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
         PA082( ) ;
         WS082( ) ;
         WE082( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), false);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019393929", true);
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
         context.AddJavascriptSource("wwpbaseobjects/exportoptions.js", "?201892019393929", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("Window/InNewWindowRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblJs_Internalname = "JS";
         cmbavExporttype_Internalname = "vEXPORTTYPE";
         divTableexport_Internalname = "TABLEEXPORT";
         divLayout_tableexport_Internalname = "LAYOUT_TABLEEXPORT";
         Dvpanel_tableexport_Internalname = "DVPANEL_TABLEEXPORT";
         edtavUser_Internalname = "vUSER";
         edtavDoctitle_Internalname = "vDOCTITLE";
         edtavPassword_Internalname = "vPASSWORD";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         tblTablegoogledriveinfo_Internalname = "TABLEGOOGLEDRIVEINFO";
         tblTablecontent_Internalname = "TABLECONTENT";
         Innewwindow1_Internalname = "INNEWWINDOW1";
         tblUt_Internalname = "UT";
         bttBtndownloadtofile_Internalname = "BTNDOWNLOADTOFILE";
         bttBtnsavegoogledrive_Internalname = "BTNSAVEGOOGLEDRIVE";
         bttBtncancel_Internalname = "BTNCANCEL";
         divActiongroup_actions_Internalname = "ACTIONGROUP_ACTIONS";
         tblTablemain_Internalname = "TABLEMAIN";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavPassword_Jsonclick = "";
         edtavPassword_Enabled = 1;
         edtavDoctitle_Jsonclick = "";
         edtavDoctitle_Enabled = 1;
         edtavUser_Jsonclick = "";
         edtavUser_Enabled = 1;
         cmbavExporttype_Jsonclick = "";
         cmbavExporttype.Enabled = 1;
         bttBtnsavegoogledrive_Visible = 1;
         bttBtndownloadtofile_Visible = 1;
         tblTablecontent_Visible = 1;
         bttBtncancel_Caption = "Fechar";
         lblJs_Caption = "JS";
         tblTablegoogledriveinfo_Visible = 1;
         edtavPassword_Ispassword = 0;
         tblTablecontent_Height = 386;
         Innewwindow1_Target = "";
         Innewwindow1_Height = "50";
         Innewwindow1_Width = "50";
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "Informação de Google Drive";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Dvpanel_tableexport_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableexport_Iconposition = "left";
         Dvpanel_tableexport_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableexport_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableexport_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableexport_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableexport_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableexport_Title = "Onde exportar?";
         Dvpanel_tableexport_Cls = "PanelCard_BaseColor";
         Dvpanel_tableexport_Width = "100%";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV12ExcelFileName',fld:'vEXCELFILENAME',pic:'',hsh:true,nv:''},{av:'AV9DefaultTitle',fld:'vDEFAULTTITLE',pic:'',hsh:true,nv:''}],oparms:[]}");
         setEventMetadata("'DODOWNLOADTOFILE'","{handler:'E12082',iparms:[],oparms:[]}");
         setEventMetadata("'DOSAVEGOOGLEDRIVE'","{handler:'E13082',iparms:[{av:'AV14GoogleDocResultXML',fld:'vGOOGLEDOCRESULTXML',pic:'',nv:''}],oparms:[{av:'Innewwindow1_Target',ctrl:'INNEWWINDOW1',prop:'Target'},{av:'Innewwindow1_Height',ctrl:'INNEWWINDOW1',prop:'Height'},{av:'Innewwindow1_Width',ctrl:'INNEWWINDOW1',prop:'Width'},{ctrl:'BTNCANCEL',prop:'Caption'},{av:'tblTablecontent_Visible',ctrl:'TABLECONTENT',prop:'Visible'},{ctrl:'BTNDOWNLOADTOFILE',prop:'Visible'},{ctrl:'BTNSAVEGOOGLEDRIVE',prop:'Visible'}]}");
         setEventMetadata("VEXPORTTYPE.CLICK","{handler:'E15081',iparms:[{av:'cmbavExporttype'},{av:'AV13ExportType',fld:'vEXPORTTYPE',pic:'9',nv:0}],oparms:[{av:'tblTablegoogledriveinfo_Visible',ctrl:'TABLEGOOGLEDRIVEINFO',prop:'Visible'},{ctrl:'BTNDOWNLOADTOFILE',prop:'Visible'},{ctrl:'BTNSAVEGOOGLEDRIVE',prop:'Visible'}]}");
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
         wcpOAV12ExcelFileName = "";
         wcpOAV9DefaultTitle = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV14GoogleDocResultXML = "";
         GX_FocusControl = "";
         sPrefix = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV22User = "";
         AV5DocTitle = "";
         AV20Password = "";
         AV16HttpRequest = new GxHttpRequest( context);
         AV21URL = "";
         bttBtndownloadtofile_Jsonclick = "";
         AV15GoogleDocsResult = new GeneXus.Programs.wwpbaseobjects.SdtGoogleDocsResult(context);
         sStyleString = "";
         lblJs_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtnsavegoogledrive_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV13ExportType ;
      private short edtavPassword_Ispassword ;
      private short nGXWrapped ;
      private int tblTablecontent_Height ;
      private int tblTablegoogledriveinfo_Visible ;
      private int bttBtnsavegoogledrive_Visible ;
      private int tblTablecontent_Visible ;
      private int bttBtndownloadtofile_Visible ;
      private int edtavUser_Enabled ;
      private int edtavDoctitle_Enabled ;
      private int edtavPassword_Enabled ;
      private int idxLst ;
      private String AV9DefaultTitle ;
      private String wcpOAV9DefaultTitle ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String Dvpanel_tableexport_Width ;
      private String Dvpanel_tableexport_Cls ;
      private String Dvpanel_tableexport_Title ;
      private String Dvpanel_tableexport_Iconposition ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String Innewwindow1_Width ;
      private String Innewwindow1_Height ;
      private String Innewwindow1_Target ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String cmbavExporttype_Internalname ;
      private String AV22User ;
      private String edtavUser_Internalname ;
      private String AV5DocTitle ;
      private String edtavDoctitle_Internalname ;
      private String AV20Password ;
      private String edtavPassword_Internalname ;
      private String tblTablecontent_Internalname ;
      private String tblTablegoogledriveinfo_Internalname ;
      private String bttBtnsavegoogledrive_Internalname ;
      private String bttBtndownloadtofile_Jsonclick ;
      private String bttBtndownloadtofile_Internalname ;
      private String lblJs_Caption ;
      private String lblJs_Internalname ;
      private String Innewwindow1_Internalname ;
      private String bttBtncancel_Caption ;
      private String bttBtncancel_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String lblJs_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divActiongroup_actions_Internalname ;
      private String TempTags ;
      private String bttBtnsavegoogledrive_Jsonclick ;
      private String bttBtncancel_Jsonclick ;
      private String tblUt_Internalname ;
      private String divLayout_tableexport_Internalname ;
      private String divTableexport_Internalname ;
      private String cmbavExporttype_Jsonclick ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String edtavUser_Jsonclick ;
      private String edtavDoctitle_Jsonclick ;
      private String edtavPassword_Jsonclick ;
      private String Dvpanel_tableexport_Internalname ;
      private String Dvpanel_tableattributes_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableexport_Collapsible ;
      private bool Dvpanel_tableexport_Collapsed ;
      private bool Dvpanel_tableexport_Autowidth ;
      private bool Dvpanel_tableexport_Autoheight ;
      private bool Dvpanel_tableexport_Showcollapseicon ;
      private bool Dvpanel_tableexport_Autoscroll ;
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
      private String AV14GoogleDocResultXML ;
      private String AV12ExcelFileName ;
      private String wcpOAV12ExcelFileName ;
      private String AV21URL ;
      private GXWebForm Form ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavExporttype ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV16HttpRequest ;
      private GeneXus.Programs.wwpbaseobjects.SdtGoogleDocsResult AV15GoogleDocsResult ;
   }

}
