/*
               File: WWPBaseObjects.Home
        Description: Inicio
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:39:41.89
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
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs.wwpbaseobjects {
   public class home : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public home( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public home( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavHomesamplenamevaluedata__check = new GXCheckbox();
         cmbavHomesampledata__productstatus = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridtodolist") == 0 )
            {
               nRC_GXsfl_104 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_104_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_104_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGridtodolist_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Gridtodolist") == 0 )
            {
               subGridtodolist_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV6HomeSampleNameValueData);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridtodolist_refresh( subGridtodolist_Rows, AV6HomeSampleNameValueData) ;
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_GXsfl_131 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_131_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_131_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
            {
               subGrid_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV5HomeSampleData);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV5HomeSampleData) ;
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
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
         PA092( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START092( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019394264", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/DVProgressIndicator/DVProgressIndicatorRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DVProgressIndicator/DVProgressIndicatorRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DVProgressIndicator/DVProgressIndicatorRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DVProgressIndicator/DVProgressIndicatorRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("QueryViewer/QueryViewerCommon.js", "", false);
         context.AddJavascriptSource("QueryViewer/highcharts/highcharts.js", "", false);
         context.AddJavascriptSource("QueryViewer/highcharts/highcharts-3d.js", "", false);
         context.AddJavascriptSource("QueryViewer/highcharts/highcharts-more.js", "", false);
         context.AddJavascriptSource("QueryViewer/highcharts/modules/funnel.js", "", false);
         context.AddJavascriptSource("QueryViewer/highcharts/modules/solid-gauge.js", "", false);
         context.AddJavascriptSource("QueryViewer/oatPivot/gxpivotjs.js", "", false);
         context.AddJavascriptSource("QueryViewer/QueryViewerRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("QueryViewer/QueryViewerCommon.js", "", false);
         context.AddJavascriptSource("QueryViewer/highcharts/highcharts.js", "", false);
         context.AddJavascriptSource("QueryViewer/highcharts/highcharts-3d.js", "", false);
         context.AddJavascriptSource("QueryViewer/highcharts/highcharts-more.js", "", false);
         context.AddJavascriptSource("QueryViewer/highcharts/modules/funnel.js", "", false);
         context.AddJavascriptSource("QueryViewer/highcharts/modules/solid-gauge.js", "", false);
         context.AddJavascriptSource("QueryViewer/oatPivot/gxpivotjs.js", "", false);
         context.AddJavascriptSource("QueryViewer/QueryViewerRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
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
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.home.aspx") +"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         }
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
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Homesamplenamevaluedata", AV6HomeSampleNameValueData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Homesamplenamevaluedata", AV6HomeSampleNameValueData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Homesampledata", AV5HomeSampleData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Homesampledata", AV5HomeSampleData);
         }
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_104", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_104), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_131", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_131), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDRAGANDDROPDATA", AV16DragAndDropData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDRAGANDDROPDATA", AV16DragAndDropData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vITEMEXPANDDATA", AV17ItemExpandData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vITEMEXPANDDATA", AV17ItemExpandData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vITEMCOLLAPSEDATA", AV18ItemCollapseData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vITEMCOLLAPSEDATA", AV18ItemCollapseData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vFILTERCHANGEDDATA", AV19FilterChangedData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vFILTERCHANGEDDATA", AV19FilterChangedData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vITEMCLICKDATA", AV20ItemClickData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vITEMCLICKDATA", AV20ItemClickData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vITEMDOUBLECLICKDATA", AV21ItemDoubleClickData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vITEMDOUBLECLICKDATA", AV21ItemDoubleClickData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vAXES", AV22Axes);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vAXES", AV22Axes);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETERS", AV23Parameters);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETERS", AV23Parameters);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vHOMESAMPLEDATA", AV5HomeSampleData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vHOMESAMPLEDATA", AV5HomeSampleData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vHOMESAMPLENAMEVALUEDATA", AV6HomeSampleNameValueData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vHOMESAMPLENAMEVALUEDATA", AV6HomeSampleNameValueData);
         }
         GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDTODOLIST_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDTODOLIST_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtodolist_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROGRESSCARD1_Type", StringUtil.RTrim( Progresscard1_Type));
         GxWebStd.gx_hidden_field( context, "PROGRESSCARD1_Cls", StringUtil.RTrim( Progresscard1_Cls));
         GxWebStd.gx_hidden_field( context, "PROGRESSCARD1_Percentage", StringUtil.LTrim( StringUtil.NToC( (decimal)(Progresscard1_Percentage), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROGRESSCARD2_Type", StringUtil.RTrim( Progresscard2_Type));
         GxWebStd.gx_hidden_field( context, "PROGRESSCARD2_Cls", StringUtil.RTrim( Progresscard2_Cls));
         GxWebStd.gx_hidden_field( context, "PROGRESSCARD2_Percentage", StringUtil.LTrim( StringUtil.NToC( (decimal)(Progresscard2_Percentage), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROGRESSCARD3_Type", StringUtil.RTrim( Progresscard3_Type));
         GxWebStd.gx_hidden_field( context, "PROGRESSCARD3_Cls", StringUtil.RTrim( Progresscard3_Cls));
         GxWebStd.gx_hidden_field( context, "PROGRESSCARD3_Percentage", StringUtil.LTrim( StringUtil.NToC( (decimal)(Progresscard3_Percentage), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROGRESSCARD4_Type", StringUtil.RTrim( Progresscard4_Type));
         GxWebStd.gx_hidden_field( context, "PROGRESSCARD4_Cls", StringUtil.RTrim( Progresscard4_Cls));
         GxWebStd.gx_hidden_field( context, "PROGRESSCARD4_Percentage", StringUtil.LTrim( StringUtil.NToC( (decimal)(Progresscard4_Percentage), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLETODOLIST_Width", StringUtil.RTrim( Dvpanel_tabletodolist_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLETODOLIST_Cls", StringUtil.RTrim( Dvpanel_tabletodolist_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLETODOLIST_Title", StringUtil.RTrim( Dvpanel_tabletodolist_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLETODOLIST_Collapsible", StringUtil.BoolToStr( Dvpanel_tabletodolist_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLETODOLIST_Collapsed", StringUtil.BoolToStr( Dvpanel_tabletodolist_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLETODOLIST_Autowidth", StringUtil.BoolToStr( Dvpanel_tabletodolist_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLETODOLIST_Autoheight", StringUtil.BoolToStr( Dvpanel_tabletodolist_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLETODOLIST_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tabletodolist_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLETODOLIST_Iconposition", StringUtil.RTrim( Dvpanel_tabletodolist_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLETODOLIST_Autoscroll", StringUtil.BoolToStr( Dvpanel_tabletodolist_Autoscroll));
         GxWebStd.gx_hidden_field( context, "UTCHARTCOLUMNLINE_Width", StringUtil.RTrim( Utchartcolumnline_Width));
         GxWebStd.gx_hidden_field( context, "UTCHARTCOLUMNLINE_Height", StringUtil.RTrim( Utchartcolumnline_Height));
         GxWebStd.gx_hidden_field( context, "UTCHARTCOLUMNLINE_Type", StringUtil.RTrim( Utchartcolumnline_Type));
         GxWebStd.gx_hidden_field( context, "UTCHARTCOLUMNLINE_Charttype", StringUtil.RTrim( Utchartcolumnline_Charttype));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART1_Width", StringUtil.RTrim( Dvpanel_tablechart1_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART1_Cls", StringUtil.RTrim( Dvpanel_tablechart1_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART1_Title", StringUtil.RTrim( Dvpanel_tablechart1_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART1_Collapsible", StringUtil.BoolToStr( Dvpanel_tablechart1_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART1_Collapsed", StringUtil.BoolToStr( Dvpanel_tablechart1_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART1_Autowidth", StringUtil.BoolToStr( Dvpanel_tablechart1_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART1_Autoheight", StringUtil.BoolToStr( Dvpanel_tablechart1_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART1_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tablechart1_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART1_Iconposition", StringUtil.RTrim( Dvpanel_tablechart1_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART1_Autoscroll", StringUtil.BoolToStr( Dvpanel_tablechart1_Autoscroll));
         GxWebStd.gx_hidden_field( context, "UTCHARTSMOOTHLINE_Height", StringUtil.RTrim( Utchartsmoothline_Height));
         GxWebStd.gx_hidden_field( context, "UTCHARTSMOOTHLINE_Type", StringUtil.RTrim( Utchartsmoothline_Type));
         GxWebStd.gx_hidden_field( context, "UTCHARTSMOOTHLINE_Charttype", StringUtil.RTrim( Utchartsmoothline_Charttype));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART2_Width", StringUtil.RTrim( Dvpanel_tablechart2_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART2_Cls", StringUtil.RTrim( Dvpanel_tablechart2_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART2_Title", StringUtil.RTrim( Dvpanel_tablechart2_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART2_Collapsible", StringUtil.BoolToStr( Dvpanel_tablechart2_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART2_Collapsed", StringUtil.BoolToStr( Dvpanel_tablechart2_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART2_Autowidth", StringUtil.BoolToStr( Dvpanel_tablechart2_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART2_Autoheight", StringUtil.BoolToStr( Dvpanel_tablechart2_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART2_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tablechart2_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART2_Iconposition", StringUtil.RTrim( Dvpanel_tablechart2_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLECHART2_Autoscroll", StringUtil.BoolToStr( Dvpanel_tablechart2_Autoscroll));
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
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
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
            WE092( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT092( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wwpbaseobjects.home.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.Home" ;
      }

      public override String GetPgmdesc( )
      {
         return "Inicio" ;
      }

      protected void WB090( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
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
            GxWebStd.gx_div_start( context, divTablecards_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-lg-3", "left", "top", "", "", "div");
            wb_table1_12_092( true) ;
         }
         else
         {
            wb_table1_12_092( false) ;
         }
         return  ;
      }

      protected void wb_table1_12_092e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-lg-3", "left", "top", "", "", "div");
            wb_table2_33_092( true) ;
         }
         else
         {
            wb_table2_33_092( false) ;
         }
         return  ;
      }

      protected void wb_table2_33_092e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-lg-3 CellMarginTopMedium", "left", "top", "", "", "div");
            wb_table3_54_092( true) ;
         }
         else
         {
            wb_table3_54_092( false) ;
         }
         return  ;
      }

      protected void wb_table3_54_092e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-lg-3 CellMarginTopMedium", "left", "top", "", "", "div");
            wb_table4_75_092( true) ;
         }
         else
         {
            wb_table4_75_092( false) ;
         }
         return  ;
      }

      protected void wb_table4_75_092e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-5 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tabletodolist_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_TABLETODOLISTContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLETODOLISTContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tabletodolist_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabletodolist_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 GridNoHeaderCellItems", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridtodolistContainer.SetWrapped(nGXWrapped);
            if ( GridtodolistContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridtodolistContainer"+"DivS\" data-gxgridid=\"104\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGridtodolist_Internalname, subGridtodolist_Internalname, "", "GridWithBorderColor WorkWith", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGridtodolist_Backcolorstyle == 0 )
               {
                  subGridtodolist_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGridtodolist_Class) > 0 )
                  {
                     subGridtodolist_Linesclass = subGridtodolist_Class+"Title";
                  }
               }
               else
               {
                  subGridtodolist_Titlebackstyle = 1;
                  if ( subGridtodolist_Backcolorstyle == 1 )
                  {
                     subGridtodolist_Titlebackcolor = subGridtodolist_Allbackcolor;
                     if ( StringUtil.Len( subGridtodolist_Class) > 0 )
                     {
                        subGridtodolist_Linesclass = subGridtodolist_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGridtodolist_Class) > 0 )
                     {
                        subGridtodolist_Linesclass = subGridtodolist_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Check") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Value") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridtodolistContainer.AddObjectProperty("GridName", "Gridtodolist");
            }
            else
            {
               GridtodolistContainer.AddObjectProperty("GridName", "Gridtodolist");
               GridtodolistContainer.AddObjectProperty("Class", "GridWithBorderColor WorkWith");
               GridtodolistContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridtodolistContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridtodolistContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtodolist_Backcolorstyle), 1, 0, ".", "")));
               GridtodolistContainer.AddObjectProperty("CmpContext", "");
               GridtodolistContainer.AddObjectProperty("InMasterPage", "false");
               GridtodolistColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridtodolistContainer.AddColumnProperties(GridtodolistColumn);
               GridtodolistColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridtodolistColumn.AddObjectProperty("Value", AV15HomeSampleNameValueData__NameWithTags);
               GridtodolistColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavHomesamplenamevaluedata__namewithtags_Enabled), 5, 0, ".", "")));
               GridtodolistContainer.AddColumnProperties(GridtodolistColumn);
               GridtodolistColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridtodolistColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavHomesamplenamevaluedata__name_Enabled), 5, 0, ".", "")));
               GridtodolistContainer.AddColumnProperties(GridtodolistColumn);
               GridtodolistColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridtodolistColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavHomesamplenamevaluedata__value_Enabled), 5, 0, ".", "")));
               GridtodolistContainer.AddColumnProperties(GridtodolistColumn);
               GridtodolistContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtodolist_Allowselection), 1, 0, ".", "")));
               GridtodolistContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtodolist_Selectioncolor), 9, 0, ".", "")));
               GridtodolistContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtodolist_Allowhovering), 1, 0, ".", "")));
               GridtodolistContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtodolist_Hoveringcolor), 9, 0, ".", "")));
               GridtodolistContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtodolist_Allowcollapsing), 1, 0, ".", "")));
               GridtodolistContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtodolist_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 104 )
         {
            wbEnd = 0;
            nRC_GXsfl_104 = (short)(nGXsfl_104_idx-1);
            if ( GridtodolistContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               GridtodolistContainer.AddObjectProperty("GRIDTODOLIST_nEOF", GRIDTODOLIST_nEOF);
               GridtodolistContainer.AddObjectProperty("GRIDTODOLIST_nFirstRecordOnPage", GRIDTODOLIST_nFirstRecordOnPage);
               AV28GXV1 = nGXsfl_104_idx;
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridtodolistContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridtodolist", GridtodolistContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridtodolistContainerData", GridtodolistContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridtodolistContainerData"+"V", GridtodolistContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input autocomplete=\"off\" type=\"hidden\" "+"name=\""+"GridtodolistContainerData"+"V"+"\" value='"+GridtodolistContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-lg-7 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tablechart1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_TABLECHART1Container"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLECHART1Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tablechart1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablechart1_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"UTCHARTCOLUMNLINEContainer"+"\"></div>") ;
            GxWebStd.gx_div_end( context, "Center", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs hidden-sm col-lg-8 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tablechart2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_TABLECHART2Container"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLECHART2Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tablechart2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablechart2_Internalname, 1, 0, "px", divTablechart2_Height, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"UTCHARTSMOOTHLINEContainer"+"\"></div>") ;
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md col-lg-4 CellMarginTop", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"131\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "GridWithBorderColor WorkWith", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title";
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Price") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Status") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridContainer.AddObjectProperty("GridName", "Grid");
            }
            else
            {
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Class", "GridWithBorderColor WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavHomesampledata__productname_Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavHomesampledata__productprice_Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Columnclass", StringUtil.RTrim( cmbavHomesampledata__productstatus_Columnclass));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbavHomesampledata__productstatus.Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowselection), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectioncolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowhovering), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Hoveringcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowcollapsing), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 131 )
         {
            wbEnd = 0;
            nRC_GXsfl_131 = (short)(nGXsfl_131_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               GridContainer.AddObjectProperty("GRID_nEOF", GRID_nEOF);
               GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
               AV32GXV5 = nGXsfl_131_idx;
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input autocomplete=\"off\" type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
               }
            }
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

      protected void START092( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Inicio", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP090( ) ;
      }

      protected void WS092( )
      {
         START092( ) ;
         EVT092( ) ;
      }

      protected void EVT092( )
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
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDTODOLISTPAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRIDTODOLISTPAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgridtodolist_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgridtodolist_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgridtodolist_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgridtodolist_lastpage( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRIDPAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 17), "GRIDTODOLIST.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_104_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_104_idx), 4, 0)), 4, "0");
                              SubsflControlProps_1042( ) ;
                              AV28GXV1 = (short)(nGXsfl_104_idx+GRIDTODOLIST_nFirstRecordOnPage);
                              if ( ( AV6HomeSampleNameValueData.Count >= AV28GXV1 ) && ( AV28GXV1 > 0 ) )
                              {
                                 AV6HomeSampleNameValueData.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)AV6HomeSampleNameValueData.Item(AV28GXV1));
                                 AV15HomeSampleNameValueData__NameWithTags = cgiGet( edtavHomesamplenamevaluedata__namewithtags_Internalname);
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavHomesamplenamevaluedata__namewithtags_Internalname, AV15HomeSampleNameValueData__NameWithTags);
                              }
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E11092 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDTODOLIST.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E12092 ();
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
                                 }
                              }
                              else
                              {
                              }
                           }
                           else if ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 )
                           {
                              nGXsfl_131_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_131_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_131_idx), 4, 0)), 4, "0");
                              SubsflControlProps_1313( ) ;
                              AV32GXV5 = (short)(nGXsfl_131_idx+GRID_nFirstRecordOnPage);
                              if ( ( AV5HomeSampleData.Count >= AV32GXV5 ) && ( AV32GXV5 > 0 ) )
                              {
                                 AV5HomeSampleData.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5));
                              }
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E13093 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE092( )
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

      protected void PA092( )
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
            GXCCtl = "HOMESAMPLENAMEVALUEDATA__CHECK_" + sGXsfl_104_idx;
            chkavHomesamplenamevaluedata__check.Name = GXCCtl;
            chkavHomesamplenamevaluedata__check.WebTags = "";
            chkavHomesamplenamevaluedata__check.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavHomesamplenamevaluedata__check_Internalname, "TitleCaption", chkavHomesamplenamevaluedata__check.Caption, !bGXsfl_104_Refreshing);
            chkavHomesamplenamevaluedata__check.CheckedValue = "false";
            GXCCtl = "HOMESAMPLEDATA__PRODUCTSTATUS_" + sGXsfl_131_idx;
            cmbavHomesampledata__productstatus.Name = GXCCtl;
            cmbavHomesampledata__productstatus.WebTags = "";
            cmbavHomesampledata__productstatus.addItem("1", "Available", 0);
            cmbavHomesampledata__productstatus.addItem("2", "Missing", 0);
            cmbavHomesampledata__productstatus.addItem("3", "Comming Soon", 0);
            cmbavHomesampledata__productstatus.addItem("4", "Ordered", 0);
            if ( cmbavHomesampledata__productstatus.ItemCount > 0 )
            {
               if ( ( AV32GXV5 > 0 ) && ( AV5HomeSampleData.Count >= AV32GXV5 ) && (0==((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5)).gxTpr_Productstatus) )
               {
                  ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5)).gxTpr_Productstatus = (short)(NumberUtil.Val( cmbavHomesampledata__productstatus.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5)).gxTpr_Productstatus), 1, 0))), "."));
               }
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
               GX_FocusControl = edtavValuecard1_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridtodolist_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_1042( ) ;
         while ( nGXsfl_104_idx <= nRC_GXsfl_104 )
         {
            sendrow_1042( ) ;
            nGXsfl_104_idx = (short)(((subGridtodolist_Islastpage==1)&&(nGXsfl_104_idx+1>subGridtodolist_Recordsperpage( )) ? 1 : nGXsfl_104_idx+1));
            sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_104_idx), 4, 0)), 4, "0");
            SubsflControlProps_1042( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridtodolistContainer));
         /* End function gxnrGridtodolist_newrow */
      }

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_1313( ) ;
         while ( nGXsfl_131_idx <= nRC_GXsfl_131 )
         {
            sendrow_1313( ) ;
            nGXsfl_131_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_131_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_131_idx+1));
            sGXsfl_131_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_131_idx), 4, 0)), 4, "0");
            SubsflControlProps_1313( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGridtodolist_refresh( int subGridtodolist_Rows ,
                                               GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem> AV6HomeSampleNameValueData )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtodolist_Rows), 6, 0, ".", "")));
         GRIDTODOLIST_nCurrentRecord = 0;
         RF092( ) ;
         /* End function gxgrGridtodolist_refresh */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem> AV5HomeSampleData )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF093( ) ;
         /* End function gxgrGrid_refresh */
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
         RF092( ) ;
         RF093( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavValuecard1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavValuecard1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavValuecard1_Enabled), 5, 0)), true);
         edtavAdditionaldatacard1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdditionaldatacard1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdditionaldatacard1_Enabled), 5, 0)), true);
         edtavValuecard2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavValuecard2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavValuecard2_Enabled), 5, 0)), true);
         edtavAdditionaldatacard2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdditionaldatacard2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdditionaldatacard2_Enabled), 5, 0)), true);
         edtavValuecard3_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavValuecard3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavValuecard3_Enabled), 5, 0)), true);
         edtavAdditionaldatacard3_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdditionaldatacard3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdditionaldatacard3_Enabled), 5, 0)), true);
         edtavValuecard4_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavValuecard4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavValuecard4_Enabled), 5, 0)), true);
         edtavAdditionaldatacard4_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdditionaldatacard4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdditionaldatacard4_Enabled), 5, 0)), true);
         edtavHomesamplenamevaluedata__namewithtags_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHomesamplenamevaluedata__namewithtags_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHomesamplenamevaluedata__namewithtags_Enabled), 5, 0)), !bGXsfl_104_Refreshing);
         edtavHomesamplenamevaluedata__name_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHomesamplenamevaluedata__name_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHomesamplenamevaluedata__name_Enabled), 5, 0)), !bGXsfl_104_Refreshing);
         edtavHomesamplenamevaluedata__value_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHomesamplenamevaluedata__value_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHomesamplenamevaluedata__value_Enabled), 5, 0)), !bGXsfl_104_Refreshing);
         edtavHomesampledata__productname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHomesampledata__productname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHomesampledata__productname_Enabled), 5, 0)), !bGXsfl_131_Refreshing);
         edtavHomesampledata__productprice_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHomesampledata__productprice_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHomesampledata__productprice_Enabled), 5, 0)), !bGXsfl_131_Refreshing);
         cmbavHomesampledata__productstatus.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavHomesampledata__productstatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavHomesampledata__productstatus.Enabled), 5, 0)), !bGXsfl_131_Refreshing);
      }

      protected void RF092( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridtodolistContainer.ClearRows();
         }
         wbStart = 104;
         nGXsfl_104_idx = 1;
         sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_104_idx), 4, 0)), 4, "0");
         SubsflControlProps_1042( ) ;
         bGXsfl_104_Refreshing = true;
         GridtodolistContainer.AddObjectProperty("GridName", "Gridtodolist");
         GridtodolistContainer.AddObjectProperty("CmpContext", "");
         GridtodolistContainer.AddObjectProperty("InMasterPage", "false");
         GridtodolistContainer.AddObjectProperty("Class", "GridWithBorderColor WorkWith");
         GridtodolistContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridtodolistContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridtodolistContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtodolist_Backcolorstyle), 1, 0, ".", "")));
         GridtodolistContainer.PageSize = subGridtodolist_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_1042( ) ;
            E12092 ();
            if ( ( GRIDTODOLIST_nCurrentRecord > 0 ) && ( GRIDTODOLIST_nGridOutOfScope == 0 ) && ( nGXsfl_104_idx == 1 ) )
            {
               GRIDTODOLIST_nCurrentRecord = 0;
               GRIDTODOLIST_nGridOutOfScope = 1;
               subgridtodolist_firstpage( ) ;
               E12092 ();
            }
            wbEnd = 104;
            WB090( ) ;
         }
         bGXsfl_104_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes092( )
      {
      }

      protected void RF093( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 131;
         nGXsfl_131_idx = 1;
         sGXsfl_131_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_131_idx), 4, 0)), 4, "0");
         SubsflControlProps_1313( ) ;
         bGXsfl_131_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "GridWithBorderColor WorkWith");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_1313( ) ;
            E13093 ();
            if ( ( GRID_nCurrentRecord > 0 ) && ( GRID_nGridOutOfScope == 0 ) && ( nGXsfl_131_idx == 1 ) )
            {
               GRID_nCurrentRecord = 0;
               GRID_nGridOutOfScope = 1;
               subgrid_firstpage( ) ;
               E13093 ();
            }
            wbEnd = 131;
            WB090( ) ;
         }
         bGXsfl_131_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes093( )
      {
      }

      protected int subGridtodolist_Pagecount( )
      {
         GRIDTODOLIST_nRecordCount = subGridtodolist_Recordcount( );
         if ( ((int)((GRIDTODOLIST_nRecordCount) % (subGridtodolist_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRIDTODOLIST_nRecordCount/ (decimal)(subGridtodolist_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRIDTODOLIST_nRecordCount/ (decimal)(subGridtodolist_Recordsperpage( ))))+1) ;
      }

      protected int subGridtodolist_Recordcount( )
      {
         return AV6HomeSampleNameValueData.Count ;
      }

      protected int subGridtodolist_Recordsperpage( )
      {
         if ( subGridtodolist_Rows > 0 )
         {
            return subGridtodolist_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGridtodolist_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRIDTODOLIST_nFirstRecordOnPage/ (decimal)(subGridtodolist_Recordsperpage( ))))+1) ;
      }

      protected short subgridtodolist_firstpage( )
      {
         GRIDTODOLIST_nFirstRecordOnPage = 0;
         if ( isFullAjaxMode( ) )
         {
            gxgrGridtodolist_refresh( subGridtodolist_Rows, AV6HomeSampleNameValueData) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDTODOLIST_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgridtodolist_nextpage( )
      {
         GRIDTODOLIST_nRecordCount = subGridtodolist_Recordcount( );
         if ( ( GRIDTODOLIST_nRecordCount >= subGridtodolist_Recordsperpage( ) ) && ( GRIDTODOLIST_nEOF == 0 ) )
         {
            GRIDTODOLIST_nFirstRecordOnPage = (long)(GRIDTODOLIST_nFirstRecordOnPage+subGridtodolist_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGridtodolist_refresh( subGridtodolist_Rows, AV6HomeSampleNameValueData) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDTODOLIST_nFirstRecordOnPage), 15, 0, ".", "")));
         GridtodolistContainer.AddObjectProperty("GRIDTODOLIST_nFirstRecordOnPage", GRIDTODOLIST_nFirstRecordOnPage);
         return (short)(((GRIDTODOLIST_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgridtodolist_previouspage( )
      {
         if ( GRIDTODOLIST_nFirstRecordOnPage >= subGridtodolist_Recordsperpage( ) )
         {
            GRIDTODOLIST_nFirstRecordOnPage = (long)(GRIDTODOLIST_nFirstRecordOnPage-subGridtodolist_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGridtodolist_refresh( subGridtodolist_Rows, AV6HomeSampleNameValueData) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDTODOLIST_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgridtodolist_lastpage( )
      {
         GRIDTODOLIST_nRecordCount = subGridtodolist_Recordcount( );
         if ( GRIDTODOLIST_nRecordCount > subGridtodolist_Recordsperpage( ) )
         {
            if ( ((int)((GRIDTODOLIST_nRecordCount) % (subGridtodolist_Recordsperpage( )))) == 0 )
            {
               GRIDTODOLIST_nFirstRecordOnPage = (long)(GRIDTODOLIST_nRecordCount-subGridtodolist_Recordsperpage( ));
            }
            else
            {
               GRIDTODOLIST_nFirstRecordOnPage = (long)(GRIDTODOLIST_nRecordCount-((int)((GRIDTODOLIST_nRecordCount) % (subGridtodolist_Recordsperpage( )))));
            }
         }
         else
         {
            GRIDTODOLIST_nFirstRecordOnPage = 0;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGridtodolist_refresh( subGridtodolist_Rows, AV6HomeSampleNameValueData) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDTODOLIST_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected int subgridtodolist_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRIDTODOLIST_nFirstRecordOnPage = (long)(subGridtodolist_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRIDTODOLIST_nFirstRecordOnPage = 0;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGridtodolist_refresh( subGridtodolist_Rows, AV6HomeSampleNameValueData) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDTODOLIST_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected int subGrid_Pagecount( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_Recordcount( )
      {
         return AV5HomeSampleData.Count ;
      }

      protected int subGrid_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            return subGrid_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGrid_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         GRID_nFirstRecordOnPage = 0;
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV5HomeSampleData) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ( GRID_nRecordCount >= subGrid_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV5HomeSampleData) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         if ( GRID_nFirstRecordOnPage >= subGrid_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage-subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV5HomeSampleData) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( GRID_nRecordCount > subGrid_Recordsperpage( ) )
         {
            if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-subGrid_Recordsperpage( ));
            }
            else
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))));
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV5HomeSampleData) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID_nFirstRecordOnPage = (long)(subGrid_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV5HomeSampleData) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP090( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavValuecard1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavValuecard1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavValuecard1_Enabled), 5, 0)), true);
         edtavAdditionaldatacard1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdditionaldatacard1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdditionaldatacard1_Enabled), 5, 0)), true);
         edtavValuecard2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavValuecard2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavValuecard2_Enabled), 5, 0)), true);
         edtavAdditionaldatacard2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdditionaldatacard2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdditionaldatacard2_Enabled), 5, 0)), true);
         edtavValuecard3_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavValuecard3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavValuecard3_Enabled), 5, 0)), true);
         edtavAdditionaldatacard3_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdditionaldatacard3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdditionaldatacard3_Enabled), 5, 0)), true);
         edtavValuecard4_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavValuecard4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavValuecard4_Enabled), 5, 0)), true);
         edtavAdditionaldatacard4_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdditionaldatacard4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdditionaldatacard4_Enabled), 5, 0)), true);
         edtavHomesamplenamevaluedata__namewithtags_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHomesamplenamevaluedata__namewithtags_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHomesamplenamevaluedata__namewithtags_Enabled), 5, 0)), !bGXsfl_104_Refreshing);
         edtavHomesamplenamevaluedata__name_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHomesamplenamevaluedata__name_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHomesamplenamevaluedata__name_Enabled), 5, 0)), !bGXsfl_104_Refreshing);
         edtavHomesamplenamevaluedata__value_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHomesamplenamevaluedata__value_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHomesamplenamevaluedata__value_Enabled), 5, 0)), !bGXsfl_104_Refreshing);
         edtavHomesampledata__productname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHomesampledata__productname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHomesampledata__productname_Enabled), 5, 0)), !bGXsfl_131_Refreshing);
         edtavHomesampledata__productprice_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHomesampledata__productprice_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHomesampledata__productprice_Enabled), 5, 0)), !bGXsfl_131_Refreshing);
         cmbavHomesampledata__productstatus.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavHomesampledata__productstatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavHomesampledata__productstatus.Enabled), 5, 0)), !bGXsfl_131_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11092 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Homesamplenamevaluedata"), AV6HomeSampleNameValueData);
            ajax_req_read_hidden_sdt(cgiGet( "Homesampledata"), AV5HomeSampleData);
            ajax_req_read_hidden_sdt(cgiGet( "vDRAGANDDROPDATA"), AV16DragAndDropData);
            ajax_req_read_hidden_sdt(cgiGet( "vITEMEXPANDDATA"), AV17ItemExpandData);
            ajax_req_read_hidden_sdt(cgiGet( "vITEMCOLLAPSEDATA"), AV18ItemCollapseData);
            ajax_req_read_hidden_sdt(cgiGet( "vFILTERCHANGEDDATA"), AV19FilterChangedData);
            ajax_req_read_hidden_sdt(cgiGet( "vITEMCLICKDATA"), AV20ItemClickData);
            ajax_req_read_hidden_sdt(cgiGet( "vITEMDOUBLECLICKDATA"), AV21ItemDoubleClickData);
            ajax_req_read_hidden_sdt(cgiGet( "vAXES"), AV22Axes);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETERS"), AV23Parameters);
            ajax_req_read_hidden_sdt(cgiGet( "vHOMESAMPLENAMEVALUEDATA"), AV6HomeSampleNameValueData);
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavValuecard1_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavValuecard1_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vVALUECARD1");
               GX_FocusControl = edtavValuecard1_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13ValueCard1 = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ValueCard1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13ValueCard1), 8, 0)));
            }
            else
            {
               AV13ValueCard1 = (int)(context.localUtil.CToN( cgiGet( edtavValuecard1_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ValueCard1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13ValueCard1), 8, 0)));
            }
            AV14AdditionalDataCard1 = cgiGet( edtavAdditionaldatacard1_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14AdditionalDataCard1", AV14AdditionalDataCard1);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavValuecard2_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavValuecard2_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vVALUECARD2");
               GX_FocusControl = edtavValuecard2_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11ValueCard2 = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ValueCard2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11ValueCard2), 8, 0)));
            }
            else
            {
               AV11ValueCard2 = (int)(context.localUtil.CToN( cgiGet( edtavValuecard2_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ValueCard2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11ValueCard2), 8, 0)));
            }
            AV12AdditionalDataCard2 = cgiGet( edtavAdditionaldatacard2_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12AdditionalDataCard2", AV12AdditionalDataCard2);
            AV9ValueCard3 = cgiGet( edtavValuecard3_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ValueCard3", AV9ValueCard3);
            AV10AdditionalDataCard3 = cgiGet( edtavAdditionaldatacard3_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10AdditionalDataCard3", AV10AdditionalDataCard3);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavValuecard4_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavValuecard4_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vVALUECARD4");
               GX_FocusControl = edtavValuecard4_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7ValueCard4 = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ValueCard4", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ValueCard4), 8, 0)));
            }
            else
            {
               AV7ValueCard4 = (int)(context.localUtil.CToN( cgiGet( edtavValuecard4_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ValueCard4", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ValueCard4), 8, 0)));
            }
            AV8AdditionalDataCard4 = cgiGet( edtavAdditionaldatacard4_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8AdditionalDataCard4", AV8AdditionalDataCard4);
            /* Read saved values. */
            nRC_GXsfl_104 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_104"), ",", "."));
            nRC_GXsfl_131 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_131"), ",", "."));
            GRIDTODOLIST_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRIDTODOLIST_nFirstRecordOnPage"), ",", "."));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ",", "."));
            GRIDTODOLIST_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRIDTODOLIST_nEOF"), ",", "."));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ",", "."));
            subGridtodolist_Rows = (int)(context.localUtil.CToN( cgiGet( "GRIDTODOLIST_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtodolist_Rows), 6, 0, ".", "")));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Progresscard1_Type = cgiGet( "PROGRESSCARD1_Type");
            Progresscard1_Cls = cgiGet( "PROGRESSCARD1_Cls");
            Progresscard1_Percentage = (int)(context.localUtil.CToN( cgiGet( "PROGRESSCARD1_Percentage"), ",", "."));
            Progresscard2_Type = cgiGet( "PROGRESSCARD2_Type");
            Progresscard2_Cls = cgiGet( "PROGRESSCARD2_Cls");
            Progresscard2_Percentage = (int)(context.localUtil.CToN( cgiGet( "PROGRESSCARD2_Percentage"), ",", "."));
            Progresscard3_Type = cgiGet( "PROGRESSCARD3_Type");
            Progresscard3_Cls = cgiGet( "PROGRESSCARD3_Cls");
            Progresscard3_Percentage = (int)(context.localUtil.CToN( cgiGet( "PROGRESSCARD3_Percentage"), ",", "."));
            Progresscard4_Type = cgiGet( "PROGRESSCARD4_Type");
            Progresscard4_Cls = cgiGet( "PROGRESSCARD4_Cls");
            Progresscard4_Percentage = (int)(context.localUtil.CToN( cgiGet( "PROGRESSCARD4_Percentage"), ",", "."));
            Dvpanel_tabletodolist_Width = cgiGet( "DVPANEL_TABLETODOLIST_Width");
            Dvpanel_tabletodolist_Cls = cgiGet( "DVPANEL_TABLETODOLIST_Cls");
            Dvpanel_tabletodolist_Title = cgiGet( "DVPANEL_TABLETODOLIST_Title");
            Dvpanel_tabletodolist_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLETODOLIST_Collapsible"));
            Dvpanel_tabletodolist_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLETODOLIST_Collapsed"));
            Dvpanel_tabletodolist_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLETODOLIST_Autowidth"));
            Dvpanel_tabletodolist_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLETODOLIST_Autoheight"));
            Dvpanel_tabletodolist_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLETODOLIST_Showcollapseicon"));
            Dvpanel_tabletodolist_Iconposition = cgiGet( "DVPANEL_TABLETODOLIST_Iconposition");
            Dvpanel_tabletodolist_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLETODOLIST_Autoscroll"));
            Utchartcolumnline_Width = cgiGet( "UTCHARTCOLUMNLINE_Width");
            Utchartcolumnline_Height = cgiGet( "UTCHARTCOLUMNLINE_Height");
            Utchartcolumnline_Type = cgiGet( "UTCHARTCOLUMNLINE_Type");
            Utchartcolumnline_Charttype = cgiGet( "UTCHARTCOLUMNLINE_Charttype");
            Dvpanel_tablechart1_Width = cgiGet( "DVPANEL_TABLECHART1_Width");
            Dvpanel_tablechart1_Cls = cgiGet( "DVPANEL_TABLECHART1_Cls");
            Dvpanel_tablechart1_Title = cgiGet( "DVPANEL_TABLECHART1_Title");
            Dvpanel_tablechart1_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLECHART1_Collapsible"));
            Dvpanel_tablechart1_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLECHART1_Collapsed"));
            Dvpanel_tablechart1_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLECHART1_Autowidth"));
            Dvpanel_tablechart1_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLECHART1_Autoheight"));
            Dvpanel_tablechart1_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLECHART1_Showcollapseicon"));
            Dvpanel_tablechart1_Iconposition = cgiGet( "DVPANEL_TABLECHART1_Iconposition");
            Dvpanel_tablechart1_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLECHART1_Autoscroll"));
            Utchartsmoothline_Height = cgiGet( "UTCHARTSMOOTHLINE_Height");
            Utchartsmoothline_Type = cgiGet( "UTCHARTSMOOTHLINE_Type");
            Utchartsmoothline_Charttype = cgiGet( "UTCHARTSMOOTHLINE_Charttype");
            Dvpanel_tablechart2_Width = cgiGet( "DVPANEL_TABLECHART2_Width");
            Dvpanel_tablechart2_Cls = cgiGet( "DVPANEL_TABLECHART2_Cls");
            Dvpanel_tablechart2_Title = cgiGet( "DVPANEL_TABLECHART2_Title");
            Dvpanel_tablechart2_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLECHART2_Collapsible"));
            Dvpanel_tablechart2_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLECHART2_Collapsed"));
            Dvpanel_tablechart2_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLECHART2_Autowidth"));
            Dvpanel_tablechart2_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLECHART2_Autoheight"));
            Dvpanel_tablechart2_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLECHART2_Showcollapseicon"));
            Dvpanel_tablechart2_Iconposition = cgiGet( "DVPANEL_TABLECHART2_Iconposition");
            Dvpanel_tablechart2_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLECHART2_Autoscroll"));
            nRC_GXsfl_104 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_104"), ",", "."));
            nGXsfl_104_fel_idx = 0;
            while ( nGXsfl_104_fel_idx < nRC_GXsfl_104 )
            {
               nGXsfl_104_fel_idx = (short)(((subGridtodolist_Islastpage==1)&&(nGXsfl_104_fel_idx+1>subGridtodolist_Recordsperpage( )) ? 1 : nGXsfl_104_fel_idx+1));
               sGXsfl_104_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_104_fel_idx), 4, 0)), 4, "0");
               SubsflControlProps_fel_1042( ) ;
               AV28GXV1 = (short)(nGXsfl_104_fel_idx+GRIDTODOLIST_nFirstRecordOnPage);
               if ( ( AV6HomeSampleNameValueData.Count >= AV28GXV1 ) && ( AV28GXV1 > 0 ) )
               {
                  AV6HomeSampleNameValueData.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)AV6HomeSampleNameValueData.Item(AV28GXV1));
                  AV15HomeSampleNameValueData__NameWithTags = cgiGet( edtavHomesamplenamevaluedata__namewithtags_Internalname);
               }
            }
            if ( nGXsfl_104_fel_idx == 0 )
            {
               nGXsfl_104_idx = 1;
               sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_104_idx), 4, 0)), 4, "0");
               SubsflControlProps_1042( ) ;
            }
            nGXsfl_104_fel_idx = 1;
            nRC_GXsfl_131 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_131"), ",", "."));
            nGXsfl_131_fel_idx = 0;
            while ( nGXsfl_131_fel_idx < nRC_GXsfl_131 )
            {
               nGXsfl_131_fel_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_131_fel_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_131_fel_idx+1));
               sGXsfl_131_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_131_fel_idx), 4, 0)), 4, "0");
               SubsflControlProps_fel_1313( ) ;
               AV32GXV5 = (short)(nGXsfl_131_fel_idx+GRID_nFirstRecordOnPage);
               if ( ( AV5HomeSampleData.Count >= AV32GXV5 ) && ( AV32GXV5 > 0 ) )
               {
                  AV5HomeSampleData.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5));
               }
            }
            if ( nGXsfl_131_fel_idx == 0 )
            {
               nGXsfl_131_idx = 1;
               sGXsfl_131_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_131_idx), 4, 0)), 4, "0");
               SubsflControlProps_1313( ) ;
            }
            nGXsfl_131_fel_idx = 1;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            /* Check if conditions changed and reset current page numbers */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E11092 ();
         if (returnInSub) return;
      }

      protected void E11092( )
      {
         /* Start Routine */
         divTablechart2_Height = 427;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablechart2_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablechart2_Height), 9, 0)), true);
         subGrid_Rows = 0;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subGridtodolist_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtodolist_Rows), 6, 0, ".", "")));
         AV13ValueCard1 = 352;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ValueCard1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13ValueCard1), 8, 0)));
         AV11ValueCard2 = 75520;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ValueCard2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11ValueCard2), 8, 0)));
         AV9ValueCard3 = "+560";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ValueCard3", AV9ValueCard3);
         AV7ValueCard4 = 2540;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ValueCard4", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ValueCard4), 8, 0)));
         GXt_objcol_SdtHomeSampleData_HomeSampleDataItem1 = AV5HomeSampleData;
         new GeneXus.Programs.wwpbaseobjects.gethomesampledata(context ).execute( out  GXt_objcol_SdtHomeSampleData_HomeSampleDataItem1) ;
         AV5HomeSampleData = GXt_objcol_SdtHomeSampleData_HomeSampleDataItem1;
         gx_BV131 = true;
         GXt_objcol_SdtHomeSampleNameValueData_HomeSampleNameValueDataItem2 = AV6HomeSampleNameValueData;
         new GeneXus.Programs.wwpbaseobjects.gethomesamplenamevaluedata(context ).execute( out  GXt_objcol_SdtHomeSampleNameValueData_HomeSampleNameValueDataItem2) ;
         AV6HomeSampleNameValueData = GXt_objcol_SdtHomeSampleNameValueData_HomeSampleNameValueDataItem2;
         gx_BV104 = true;
         AV14AdditionalDataCard1 = "50% increase in 30 days";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14AdditionalDataCard1", AV14AdditionalDataCard1);
         AV12AdditionalDataCard2 = "20% increase in 30 days";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12AdditionalDataCard2", AV12AdditionalDataCard2);
         AV10AdditionalDataCard3 = "70% increase in 30 days";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10AdditionalDataCard3", AV10AdditionalDataCard3);
         AV8AdditionalDataCard4 = "40% increase in 30 days";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8AdditionalDataCard4", AV8AdditionalDataCard4);
      }

      private void E12092( )
      {
         /* Gridtodolist_Load Routine */
         AV28GXV1 = 1;
         while ( AV28GXV1 <= AV6HomeSampleNameValueData.Count )
         {
            AV6HomeSampleNameValueData.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)AV6HomeSampleNameValueData.Item(AV28GXV1));
            AV15HomeSampleNameValueData__NameWithTags = ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)(AV6HomeSampleNameValueData.CurrentItem)).gxTpr_Name;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavHomesamplenamevaluedata__namewithtags_Internalname, AV15HomeSampleNameValueData__NameWithTags);
            if ( ( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)(AV6HomeSampleNameValueData.CurrentItem)).gxTpr_Value == Convert.ToDecimal( 1200 )) )
            {
               AV15HomeSampleNameValueData__NameWithTags = AV15HomeSampleNameValueData__NameWithTags + StringUtil.Format( "<span class='AttributeTagDanger TagAfterText'>%1</span>", "2 mins", "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavHomesamplenamevaluedata__namewithtags_Internalname, AV15HomeSampleNameValueData__NameWithTags);
            }
            if ( ( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)(AV6HomeSampleNameValueData.CurrentItem)).gxTpr_Value == Convert.ToDecimal( 890 )) )
            {
               AV15HomeSampleNameValueData__NameWithTags = AV15HomeSampleNameValueData__NameWithTags + StringUtil.Format( "<span class='AttributeTagWarning TagAfterText'>%1</span>", "3 days", "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavHomesamplenamevaluedata__namewithtags_Internalname, AV15HomeSampleNameValueData__NameWithTags);
            }
            if ( ( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)(AV6HomeSampleNameValueData.CurrentItem)).gxTpr_Value == Convert.ToDecimal( 200 )) )
            {
               AV15HomeSampleNameValueData__NameWithTags = AV15HomeSampleNameValueData__NameWithTags + StringUtil.Format( "<span class='AttributeTagSuccess TagAfterText'>%1</span>", "1 month", "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavHomesamplenamevaluedata__namewithtags_Internalname, AV15HomeSampleNameValueData__NameWithTags);
            }
            if ( ( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)(AV6HomeSampleNameValueData.CurrentItem)).gxTpr_Value == Convert.ToDecimal( 48 )) )
            {
               AV15HomeSampleNameValueData__NameWithTags = AV15HomeSampleNameValueData__NameWithTags + StringUtil.Format( "<span class='AttributeTagInfoLight TagAfterText'>%1</span>", "8 hours", "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavHomesamplenamevaluedata__namewithtags_Internalname, AV15HomeSampleNameValueData__NameWithTags);
            }
            if ( ( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)(AV6HomeSampleNameValueData.CurrentItem)).gxTpr_Value == Convert.ToDecimal( 232 )) )
            {
               AV15HomeSampleNameValueData__NameWithTags = AV15HomeSampleNameValueData__NameWithTags + StringUtil.Format( "<span class='AttributeTagInfo TagAfterText'>%1</span>", "5 days", "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavHomesamplenamevaluedata__namewithtags_Internalname, AV15HomeSampleNameValueData__NameWithTags);
            }
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 104;
            }
            if ( ( subGridtodolist_Islastpage == 1 ) || ( subGridtodolist_Rows == 0 ) || ( ( GRIDTODOLIST_nCurrentRecord >= GRIDTODOLIST_nFirstRecordOnPage ) && ( GRIDTODOLIST_nCurrentRecord < GRIDTODOLIST_nFirstRecordOnPage + subGridtodolist_Recordsperpage( ) ) ) )
            {
               sendrow_1042( ) ;
               GRIDTODOLIST_nEOF = 0;
               GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDTODOLIST_nEOF), 1, 0, ".", "")));
               if ( GRIDTODOLIST_nCurrentRecord + 1 >= subGridtodolist_Recordcount( ) )
               {
                  GRIDTODOLIST_nEOF = 1;
                  GxWebStd.gx_hidden_field( context, "GRIDTODOLIST_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDTODOLIST_nEOF), 1, 0, ".", "")));
               }
            }
            GRIDTODOLIST_nCurrentRecord = (long)(GRIDTODOLIST_nCurrentRecord+1);
            if ( isFullAjaxMode( ) && ! bGXsfl_104_Refreshing )
            {
               context.DoAjaxLoad(104, GridtodolistRow);
            }
            AV28GXV1 = (short)(AV28GXV1+1);
         }
         /*  Sending Event outputs  */
      }

      private void E13093( )
      {
         /* Grid_Load Routine */
         AV32GXV5 = 1;
         while ( AV32GXV5 <= AV5HomeSampleData.Count )
         {
            AV5HomeSampleData.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5));
            if ( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)(AV5HomeSampleData.CurrentItem)).gxTpr_Productstatus == 1 )
            {
               cmbavHomesampledata__productstatus_Columnclass = "WWColumn WWColumnTag WWColumnTagSuccess WWColumnTagSuccessSingleCell";
            }
            else if ( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)(AV5HomeSampleData.CurrentItem)).gxTpr_Productstatus == 2 )
            {
               cmbavHomesampledata__productstatus_Columnclass = "WWColumn WWColumnTag WWColumnTagDanger WWColumnTagDangerSingleCell";
            }
            else if ( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)(AV5HomeSampleData.CurrentItem)).gxTpr_Productstatus == 4 )
            {
               cmbavHomesampledata__productstatus_Columnclass = "WWColumn WWColumnTag WWColumnTagInfoLight WWColumnTagInfoLightSingleCell";
            }
            else if ( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)(AV5HomeSampleData.CurrentItem)).gxTpr_Productstatus == 3 )
            {
               cmbavHomesampledata__productstatus_Columnclass = "WWColumn WWColumnTag WWColumnTagWarning WWColumnTagWarningSingleCell";
            }
            else
            {
               cmbavHomesampledata__productstatus_Columnclass = "WWColumn";
            }
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 131;
            }
            if ( ( subGrid_Islastpage == 1 ) || ( subGrid_Rows == 0 ) || ( ( GRID_nCurrentRecord >= GRID_nFirstRecordOnPage ) && ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) )
            {
               sendrow_1313( ) ;
               GRID_nEOF = 0;
               GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
               if ( GRID_nCurrentRecord + 1 >= subGrid_Recordcount( ) )
               {
                  GRID_nEOF = 1;
                  GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
               }
            }
            GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
            if ( isFullAjaxMode( ) && ! bGXsfl_131_Refreshing )
            {
               context.DoAjaxLoad(131, GridRow);
            }
            AV32GXV5 = (short)(AV32GXV5+1);
         }
         /*  Sending Event outputs  */
      }

      protected void wb_table4_75_092( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblCard4_Internalname, tblCard4_Internalname, "", "TableCardProgressAdminBaseColor", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='ProgressAdminCardCellIcon'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblProgresscard4icon_Internalname, "<i class='ProgressAdminCardIcon fa fa-envelope-o' style='font-size: 45px'></i>", "", "", lblProgresscard4icon_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 2, "HLP_WWPBaseObjects\\Home.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='ProgressAdminCardCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecard4info_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDescriptioncard4_Internalname, "Messages", "", "", lblDescriptioncard4_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "ProgressAdminCardTitle", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\Home.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavValuecard4_Internalname, "Value Card4", "col-sm-3 ProgressAdminCardNumberLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'" + sGXsfl_104_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavValuecard4_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ValueCard4), 10, 0, ",", "")), ((edtavValuecard4_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7ValueCard4), "ZZ,ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(AV7ValueCard4), "ZZ,ZZZ,ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,87);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavValuecard4_Jsonclick, 0, "ProgressAdminCardNumber", "", "", "", "", 1, edtavValuecard4_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "KPINumericValue", "right", false, "HLP_WWPBaseObjects\\Home.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"PROGRESSCARD4Container"+"\"></div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAdditionaldatacard4_Internalname, "Additional Data Card4", "col-sm-3 ProgressAdminCardDescriptionLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'" + sGXsfl_104_idx + "',0)\"";
            ClassString = "ProgressAdminCardDescription";
            StyleString = "";
            ClassString = "ProgressAdminCardDescription";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavAdditionaldatacard4_Internalname, AV8AdditionalDataCard4, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,94);\"", 0, 1, edtavAdditionaldatacard4_Enabled, 0, 80, "chr", 5, "row", StyleString, ClassString, "", "", "400", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\Home.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_75_092e( true) ;
         }
         else
         {
            wb_table4_75_092e( false) ;
         }
      }

      protected void wb_table3_54_092( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblCard3_Internalname, tblCard3_Internalname, "", "TableCardProgressAdminWarning", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='ProgressAdminCardCellIcon'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblProgresscard3icon_Internalname, "<i class='ProgressAdminCardIcon fa fa-cloud-download' style='font-size: 45px'></i>", "", "", lblProgresscard3icon_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 2, "HLP_WWPBaseObjects\\Home.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='ProgressAdminCardCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecard3info_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDescriptioncard3_Internalname, "Downloads", "", "", lblDescriptioncard3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "ProgressAdminCardTitle", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\Home.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavValuecard3_Internalname, "Value Card3", "col-sm-3 ProgressAdminCardNumberLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_104_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavValuecard3_Internalname, AV9ValueCard3, StringUtil.RTrim( context.localUtil.Format( AV9ValueCard3, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavValuecard3_Jsonclick, 0, "ProgressAdminCardNumber", "", "", "", "", 1, edtavValuecard3_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "KPIVarchar", "left", true, "HLP_WWPBaseObjects\\Home.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"PROGRESSCARD3Container"+"\"></div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAdditionaldatacard3_Internalname, "Additional Data Card3", "col-sm-3 ProgressAdminCardDescriptionLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_104_idx + "',0)\"";
            ClassString = "ProgressAdminCardDescription";
            StyleString = "";
            ClassString = "ProgressAdminCardDescription";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavAdditionaldatacard3_Internalname, AV10AdditionalDataCard3, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,73);\"", 0, 1, edtavAdditionaldatacard3_Enabled, 0, 80, "chr", 5, "row", StyleString, ClassString, "", "", "400", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\Home.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_54_092e( true) ;
         }
         else
         {
            wb_table3_54_092e( false) ;
         }
      }

      protected void wb_table2_33_092( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblCard2_Internalname, tblCard2_Internalname, "", "TableCardProgressAdminSuccess", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='ProgressAdminCardCellIcon'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblProgresscard2icon_Internalname, "<i class='ProgressAdminCardIcon fa fa-heart-o' style='font-size: 45px'></i>", "", "", lblProgresscard2icon_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 2, "HLP_WWPBaseObjects\\Home.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='ProgressAdminCardCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecard2info_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDescriptioncard2_Internalname, "Mentions", "", "", lblDescriptioncard2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "ProgressAdminCardTitle", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\Home.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavValuecard2_Internalname, "Value Card2", "col-sm-3 ProgressAdminCardNumberLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_104_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavValuecard2_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11ValueCard2), 11, 0, ",", "")), ((edtavValuecard2_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11ValueCard2), "$ZZ,ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(AV11ValueCard2), "$ZZ,ZZZ,ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavValuecard2_Jsonclick, 0, "ProgressAdminCardNumber", "", "", "", "", 1, edtavValuecard2_Enabled, 0, "text", "", 11, "chr", 1, "row", 11, 0, 0, 0, 1, -1, 0, true, "KPIPrice", "right", false, "HLP_WWPBaseObjects\\Home.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"PROGRESSCARD2Container"+"\"></div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAdditionaldatacard2_Internalname, "Additional Data Card2", "col-sm-3 ProgressAdminCardDescriptionLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_104_idx + "',0)\"";
            ClassString = "ProgressAdminCardDescription";
            StyleString = "";
            ClassString = "ProgressAdminCardDescription";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavAdditionaldatacard2_Internalname, AV12AdditionalDataCard2, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,52);\"", 0, 1, edtavAdditionaldatacard2_Enabled, 0, 80, "chr", 5, "row", StyleString, ClassString, "", "", "400", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\Home.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_33_092e( true) ;
         }
         else
         {
            wb_table2_33_092e( false) ;
         }
      }

      protected void wb_table1_12_092( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblCard1_Internalname, tblCard1_Internalname, "", "TableCardProgressAdminInfoLight", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='ProgressAdminCardCellIcon'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblProgresscard1icon_Internalname, "<i class='ProgressAdminCardIcon fa fa-tag' style='font-size: 45px'></i>", "", "", lblProgresscard1icon_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 2, "HLP_WWPBaseObjects\\Home.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='ProgressAdminCardCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecard1info_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDescriptioncard1_Internalname, "Inventory", "", "", lblDescriptioncard1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "ProgressAdminCardTitle", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\Home.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavValuecard1_Internalname, "Value Card1", "col-sm-3 ProgressAdminCardNumberLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_104_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavValuecard1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13ValueCard1), 10, 0, ",", "")), ((edtavValuecard1_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13ValueCard1), "ZZ,ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(AV13ValueCard1), "ZZ,ZZZ,ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,24);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavValuecard1_Jsonclick, 0, "ProgressAdminCardNumber", "", "", "", "", 1, edtavValuecard1_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "KPINumericValue", "right", false, "HLP_WWPBaseObjects\\Home.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"PROGRESSCARD1Container"+"\"></div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAdditionaldatacard1_Internalname, "Additional Data Card1", "col-sm-3 ProgressAdminCardDescriptionLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_104_idx + "',0)\"";
            ClassString = "ProgressAdminCardDescription";
            StyleString = "";
            ClassString = "ProgressAdminCardDescription";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavAdditionaldatacard1_Internalname, AV14AdditionalDataCard1, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,31);\"", 0, 1, edtavAdditionaldatacard1_Enabled, 0, 80, "chr", 5, "row", StyleString, ClassString, "", "", "400", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\Home.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_12_092e( true) ;
         }
         else
         {
            wb_table1_12_092e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PA092( ) ;
         WS092( ) ;
         WE092( ) ;
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
         AddStyleSheetFile("DVelop/Bootstrap/Shared/DVelopBootstrap.css", "");
         AddStyleSheetFile("DVelop/Bootstrap/Shared/DVelopBootstrap.css", "");
         AddStyleSheetFile("DVelop/Bootstrap/Shared/DVelopBootstrap.css", "");
         AddStyleSheetFile("DVelop/Bootstrap/Shared/DVelopBootstrap.css", "");
         AddStyleSheetFile("QueryViewer/highcharts/css/highcharts.css", "");
         AddStyleSheetFile("QueryViewer/QueryViewer.css", "");
         AddStyleSheetFile("QueryViewer/highcharts/css/highcharts.css", "");
         AddStyleSheetFile("QueryViewer/QueryViewer.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019395754", true);
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
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.por.js", "?"+GetCacheInvalidationToken( ), false);
            context.AddJavascriptSource("wwpbaseobjects/home.js", "?201892019395755", false);
            context.AddJavascriptSource("DVelop/Bootstrap/DVProgressIndicator/DVProgressIndicatorRender.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/DVProgressIndicator/DVProgressIndicatorRender.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/DVProgressIndicator/DVProgressIndicatorRender.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/DVProgressIndicator/DVProgressIndicatorRender.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
            context.AddJavascriptSource("QueryViewer/QueryViewerCommon.js", "", false);
            context.AddJavascriptSource("QueryViewer/highcharts/highcharts.js", "", false);
            context.AddJavascriptSource("QueryViewer/highcharts/highcharts-3d.js", "", false);
            context.AddJavascriptSource("QueryViewer/highcharts/highcharts-more.js", "", false);
            context.AddJavascriptSource("QueryViewer/highcharts/modules/funnel.js", "", false);
            context.AddJavascriptSource("QueryViewer/highcharts/modules/solid-gauge.js", "", false);
            context.AddJavascriptSource("QueryViewer/oatPivot/gxpivotjs.js", "", false);
            context.AddJavascriptSource("QueryViewer/QueryViewerRender.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
            context.AddJavascriptSource("QueryViewer/QueryViewerCommon.js", "", false);
            context.AddJavascriptSource("QueryViewer/highcharts/highcharts.js", "", false);
            context.AddJavascriptSource("QueryViewer/highcharts/highcharts-3d.js", "", false);
            context.AddJavascriptSource("QueryViewer/highcharts/highcharts-more.js", "", false);
            context.AddJavascriptSource("QueryViewer/highcharts/modules/funnel.js", "", false);
            context.AddJavascriptSource("QueryViewer/highcharts/modules/solid-gauge.js", "", false);
            context.AddJavascriptSource("QueryViewer/oatPivot/gxpivotjs.js", "", false);
            context.AddJavascriptSource("QueryViewer/QueryViewerRender.js", "", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_1042( )
      {
         chkavHomesamplenamevaluedata__check_Internalname = "HOMESAMPLENAMEVALUEDATA__CHECK_"+sGXsfl_104_idx;
         edtavHomesamplenamevaluedata__namewithtags_Internalname = "vHOMESAMPLENAMEVALUEDATA__NAMEWITHTAGS_"+sGXsfl_104_idx;
         edtavHomesamplenamevaluedata__name_Internalname = "HOMESAMPLENAMEVALUEDATA__NAME_"+sGXsfl_104_idx;
         edtavHomesamplenamevaluedata__value_Internalname = "HOMESAMPLENAMEVALUEDATA__VALUE_"+sGXsfl_104_idx;
      }

      protected void SubsflControlProps_fel_1042( )
      {
         chkavHomesamplenamevaluedata__check_Internalname = "HOMESAMPLENAMEVALUEDATA__CHECK_"+sGXsfl_104_fel_idx;
         edtavHomesamplenamevaluedata__namewithtags_Internalname = "vHOMESAMPLENAMEVALUEDATA__NAMEWITHTAGS_"+sGXsfl_104_fel_idx;
         edtavHomesamplenamevaluedata__name_Internalname = "HOMESAMPLENAMEVALUEDATA__NAME_"+sGXsfl_104_fel_idx;
         edtavHomesamplenamevaluedata__value_Internalname = "HOMESAMPLENAMEVALUEDATA__VALUE_"+sGXsfl_104_fel_idx;
      }

      protected void sendrow_1042( )
      {
         SubsflControlProps_1042( ) ;
         WB090( ) ;
         if ( ( subGridtodolist_Rows * 1 == 0 ) || ( nGXsfl_104_idx <= subGridtodolist_Recordsperpage( ) * 1 ) )
         {
            GridtodolistRow = GXWebRow.GetNew(context,GridtodolistContainer);
            if ( subGridtodolist_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGridtodolist_Backstyle = 0;
               if ( StringUtil.StrCmp(subGridtodolist_Class, "") != 0 )
               {
                  subGridtodolist_Linesclass = subGridtodolist_Class+"Odd";
               }
            }
            else if ( subGridtodolist_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGridtodolist_Backstyle = 0;
               subGridtodolist_Backcolor = subGridtodolist_Allbackcolor;
               if ( StringUtil.StrCmp(subGridtodolist_Class, "") != 0 )
               {
                  subGridtodolist_Linesclass = subGridtodolist_Class+"Uniform";
               }
            }
            else if ( subGridtodolist_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGridtodolist_Backstyle = 1;
               if ( StringUtil.StrCmp(subGridtodolist_Class, "") != 0 )
               {
                  subGridtodolist_Linesclass = subGridtodolist_Class+"Odd";
               }
               subGridtodolist_Backcolor = (int)(0x0);
            }
            else if ( subGridtodolist_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGridtodolist_Backstyle = 1;
               if ( ((int)((nGXsfl_104_idx) % (2))) == 0 )
               {
                  subGridtodolist_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGridtodolist_Class, "") != 0 )
                  {
                     subGridtodolist_Linesclass = subGridtodolist_Class+"Even";
                  }
               }
               else
               {
                  subGridtodolist_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGridtodolist_Class, "") != 0 )
                  {
                     subGridtodolist_Linesclass = subGridtodolist_Class+"Odd";
                  }
               }
            }
            if ( GridtodolistContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"GridWithBorderColor WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_104_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridtodolistContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            TempTags = " " + ((chkavHomesamplenamevaluedata__check.Enabled!=0)&&(chkavHomesamplenamevaluedata__check.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 105,'',false,'"+sGXsfl_104_idx+"',104)\"" : " ");
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridtodolistRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavHomesamplenamevaluedata__check_Internalname,StringUtil.BoolToStr( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)AV6HomeSampleNameValueData.Item(AV28GXV1)).gxTpr_Check),(String)"",(String)"",(short)-1,(short)1,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(105, this, 'true', 'false');gx.evt.onchange(this, event);\" "+((chkavHomesamplenamevaluedata__check.Enabled!=0)&&(chkavHomesamplenamevaluedata__check.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,105);\"" : " ")});
            /* Subfile cell */
            if ( GridtodolistContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridtodolistRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavHomesamplenamevaluedata__namewithtags_Internalname,(String)AV15HomeSampleNameValueData__NameWithTags,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavHomesamplenamevaluedata__namewithtags_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavHomesamplenamevaluedata__namewithtags_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)1,(short)104,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridtodolistContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridtodolistRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavHomesamplenamevaluedata__name_Internalname,((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)AV6HomeSampleNameValueData.Item(AV28GXV1)).gxTpr_Name,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavHomesamplenamevaluedata__name_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavHomesamplenamevaluedata__name_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridtodolistContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridtodolistRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavHomesamplenamevaluedata__value_Internalname,StringUtil.LTrim( StringUtil.NToC( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)AV6HomeSampleNameValueData.Item(AV28GXV1)).gxTpr_Value, 11, 1, ",", "")),((edtavHomesamplenamevaluedata__value_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)AV6HomeSampleNameValueData.Item(AV28GXV1)).gxTpr_Value, "$ ZZZ,ZZ9.9")) : context.localUtil.Format( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem)AV6HomeSampleNameValueData.Item(AV28GXV1)).gxTpr_Value, "$ ZZZ,ZZ9.9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavHomesamplenamevaluedata__value_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavHomesamplenamevaluedata__value_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)11,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes092( ) ;
            GridtodolistContainer.AddRow(GridtodolistRow);
            nGXsfl_104_idx = (short)(((subGridtodolist_Islastpage==1)&&(nGXsfl_104_idx+1>subGridtodolist_Recordsperpage( )) ? 1 : nGXsfl_104_idx+1));
            sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_104_idx), 4, 0)), 4, "0");
            SubsflControlProps_1042( ) ;
         }
         /* End function sendrow_1042 */
      }

      protected void SubsflControlProps_1313( )
      {
         edtavHomesampledata__productname_Internalname = "HOMESAMPLEDATA__PRODUCTNAME_"+sGXsfl_131_idx;
         edtavHomesampledata__productprice_Internalname = "HOMESAMPLEDATA__PRODUCTPRICE_"+sGXsfl_131_idx;
         cmbavHomesampledata__productstatus_Internalname = "HOMESAMPLEDATA__PRODUCTSTATUS_"+sGXsfl_131_idx;
      }

      protected void SubsflControlProps_fel_1313( )
      {
         edtavHomesampledata__productname_Internalname = "HOMESAMPLEDATA__PRODUCTNAME_"+sGXsfl_131_fel_idx;
         edtavHomesampledata__productprice_Internalname = "HOMESAMPLEDATA__PRODUCTPRICE_"+sGXsfl_131_fel_idx;
         cmbavHomesampledata__productstatus_Internalname = "HOMESAMPLEDATA__PRODUCTSTATUS_"+sGXsfl_131_fel_idx;
      }

      protected void sendrow_1313( )
      {
         SubsflControlProps_1313( ) ;
         WB090( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_131_idx <= subGrid_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer);
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0;
               subGrid_Backcolor = subGrid_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform";
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
               subGrid_Backcolor = (int)(0x0);
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( ((int)((nGXsfl_131_idx) % (2))) == 0 )
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even";
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd";
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"GridWithBorderColor WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_131_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavHomesampledata__productname_Internalname,((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5)).gxTpr_Productname,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavHomesampledata__productname_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavHomesampledata__productname_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)131,(short)1,(short)-1,(short)-1,(bool)false,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavHomesampledata__productprice_Internalname,StringUtil.LTrim( StringUtil.NToC( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5)).gxTpr_Productprice, 11, 1, ",", "")),((edtavHomesampledata__productprice_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5)).gxTpr_Productprice, "$ ZZZ,ZZ9.9")) : context.localUtil.Format( ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5)).gxTpr_Productprice, "$ ZZZ,ZZ9.9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavHomesampledata__productprice_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavHomesampledata__productprice_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)11,(short)0,(short)0,(short)131,(short)1,(short)-1,(short)0,(bool)false,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbavHomesampledata__productstatus.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "HOMESAMPLEDATA__PRODUCTSTATUS_" + sGXsfl_131_idx;
               cmbavHomesampledata__productstatus.Name = GXCCtl;
               cmbavHomesampledata__productstatus.WebTags = "";
               cmbavHomesampledata__productstatus.addItem("1", "Available", 0);
               cmbavHomesampledata__productstatus.addItem("2", "Missing", 0);
               cmbavHomesampledata__productstatus.addItem("3", "Comming Soon", 0);
               cmbavHomesampledata__productstatus.addItem("4", "Ordered", 0);
               if ( cmbavHomesampledata__productstatus.ItemCount > 0 )
               {
                  if ( ( AV32GXV5 > 0 ) && ( AV5HomeSampleData.Count >= AV32GXV5 ) && (0==((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5)).gxTpr_Productstatus) )
                  {
                     ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5)).gxTpr_Productstatus = (short)(NumberUtil.Val( cmbavHomesampledata__productstatus.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5)).gxTpr_Productstatus), 1, 0))), "."));
                  }
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavHomesampledata__productstatus,(String)cmbavHomesampledata__productstatus_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5)).gxTpr_Productstatus), 1, 0)),(short)1,(String)cmbavHomesampledata__productstatus_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,cmbavHomesampledata__productstatus.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)cmbavHomesampledata__productstatus_Columnclass,(String)"",(String)"",(String)"",(bool)false});
            cmbavHomesampledata__productstatus.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV32GXV5)).gxTpr_Productstatus), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavHomesampledata__productstatus_Internalname, "Values", (String)(cmbavHomesampledata__productstatus.ToJavascriptSource()), !bGXsfl_131_Refreshing);
            send_integrity_lvl_hashes093( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_131_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_131_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_131_idx+1));
            sGXsfl_131_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_131_idx), 4, 0)), 4, "0");
            SubsflControlProps_1313( ) ;
         }
         /* End function sendrow_1313 */
      }

      protected void init_default_properties( )
      {
         lblProgresscard1icon_Internalname = "PROGRESSCARD1ICON";
         lblDescriptioncard1_Internalname = "DESCRIPTIONCARD1";
         edtavValuecard1_Internalname = "vVALUECARD1";
         Progresscard1_Internalname = "PROGRESSCARD1";
         edtavAdditionaldatacard1_Internalname = "vADDITIONALDATACARD1";
         divTablecard1info_Internalname = "TABLECARD1INFO";
         tblCard1_Internalname = "CARD1";
         lblProgresscard2icon_Internalname = "PROGRESSCARD2ICON";
         lblDescriptioncard2_Internalname = "DESCRIPTIONCARD2";
         edtavValuecard2_Internalname = "vVALUECARD2";
         Progresscard2_Internalname = "PROGRESSCARD2";
         edtavAdditionaldatacard2_Internalname = "vADDITIONALDATACARD2";
         divTablecard2info_Internalname = "TABLECARD2INFO";
         tblCard2_Internalname = "CARD2";
         lblProgresscard3icon_Internalname = "PROGRESSCARD3ICON";
         lblDescriptioncard3_Internalname = "DESCRIPTIONCARD3";
         edtavValuecard3_Internalname = "vVALUECARD3";
         Progresscard3_Internalname = "PROGRESSCARD3";
         edtavAdditionaldatacard3_Internalname = "vADDITIONALDATACARD3";
         divTablecard3info_Internalname = "TABLECARD3INFO";
         tblCard3_Internalname = "CARD3";
         lblProgresscard4icon_Internalname = "PROGRESSCARD4ICON";
         lblDescriptioncard4_Internalname = "DESCRIPTIONCARD4";
         edtavValuecard4_Internalname = "vVALUECARD4";
         Progresscard4_Internalname = "PROGRESSCARD4";
         edtavAdditionaldatacard4_Internalname = "vADDITIONALDATACARD4";
         divTablecard4info_Internalname = "TABLECARD4INFO";
         tblCard4_Internalname = "CARD4";
         divTablecards_Internalname = "TABLECARDS";
         chkavHomesamplenamevaluedata__check_Internalname = "HOMESAMPLENAMEVALUEDATA__CHECK";
         edtavHomesamplenamevaluedata__namewithtags_Internalname = "vHOMESAMPLENAMEVALUEDATA__NAMEWITHTAGS";
         edtavHomesamplenamevaluedata__name_Internalname = "HOMESAMPLENAMEVALUEDATA__NAME";
         edtavHomesamplenamevaluedata__value_Internalname = "HOMESAMPLENAMEVALUEDATA__VALUE";
         divTabletodolist_Internalname = "TABLETODOLIST";
         divLayout_tabletodolist_Internalname = "LAYOUT_TABLETODOLIST";
         Dvpanel_tabletodolist_Internalname = "DVPANEL_TABLETODOLIST";
         divHtml_dvpanel_tabletodolist_Internalname = "HTML_DVPANEL_TABLETODOLIST";
         Utchartcolumnline_Internalname = "UTCHARTCOLUMNLINE";
         divTablechart1_Internalname = "TABLECHART1";
         divLayout_tablechart1_Internalname = "LAYOUT_TABLECHART1";
         Dvpanel_tablechart1_Internalname = "DVPANEL_TABLECHART1";
         divHtml_dvpanel_tablechart1_Internalname = "HTML_DVPANEL_TABLECHART1";
         Utchartsmoothline_Internalname = "UTCHARTSMOOTHLINE";
         divTablechart2_Internalname = "TABLECHART2";
         divLayout_tablechart2_Internalname = "LAYOUT_TABLECHART2";
         Dvpanel_tablechart2_Internalname = "DVPANEL_TABLECHART2";
         divHtml_dvpanel_tablechart2_Internalname = "HTML_DVPANEL_TABLECHART2";
         edtavHomesampledata__productname_Internalname = "HOMESAMPLEDATA__PRODUCTNAME";
         edtavHomesampledata__productprice_Internalname = "HOMESAMPLEDATA__PRODUCTPRICE";
         cmbavHomesampledata__productstatus_Internalname = "HOMESAMPLEDATA__PRODUCTSTATUS";
         divTablemain_Internalname = "TABLEMAIN";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         subGridtodolist_Internalname = "GRIDTODOLIST";
         subGrid_Internalname = "GRID";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         cmbavHomesampledata__productstatus_Jsonclick = "";
         edtavHomesampledata__productprice_Jsonclick = "";
         edtavHomesampledata__productname_Jsonclick = "";
         edtavHomesamplenamevaluedata__value_Jsonclick = "";
         edtavHomesamplenamevaluedata__name_Jsonclick = "";
         edtavHomesamplenamevaluedata__namewithtags_Jsonclick = "";
         chkavHomesamplenamevaluedata__check.Visible = -1;
         chkavHomesamplenamevaluedata__check.Enabled = 1;
         edtavAdditionaldatacard1_Enabled = 1;
         edtavValuecard1_Jsonclick = "";
         edtavValuecard1_Enabled = 1;
         edtavAdditionaldatacard2_Enabled = 1;
         edtavValuecard2_Jsonclick = "";
         edtavValuecard2_Enabled = 1;
         edtavAdditionaldatacard3_Enabled = 1;
         edtavValuecard3_Jsonclick = "";
         edtavValuecard3_Enabled = 1;
         edtavAdditionaldatacard4_Enabled = 1;
         edtavValuecard4_Jsonclick = "";
         edtavValuecard4_Enabled = 1;
         cmbavHomesampledata__productstatus.Enabled = -1;
         edtavHomesampledata__productprice_Enabled = -1;
         edtavHomesampledata__productname_Enabled = -1;
         edtavHomesamplenamevaluedata__value_Enabled = -1;
         edtavHomesamplenamevaluedata__name_Enabled = -1;
         chkavHomesamplenamevaluedata__check.Caption = "";
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         cmbavHomesampledata__productstatus_Columnclass = "WWColumn";
         cmbavHomesampledata__productstatus.Enabled = 0;
         edtavHomesampledata__productprice_Enabled = 0;
         edtavHomesampledata__productname_Enabled = 0;
         subGrid_Class = "GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablechart2_Height = 0;
         subGridtodolist_Allowcollapsing = 0;
         subGridtodolist_Allowselection = 0;
         edtavHomesamplenamevaluedata__value_Enabled = 0;
         edtavHomesamplenamevaluedata__name_Enabled = 0;
         edtavHomesamplenamevaluedata__namewithtags_Enabled = 0;
         subGridtodolist_Class = "GridWithBorderColor WorkWith";
         subGridtodolist_Backcolorstyle = 0;
         Dvpanel_tablechart2_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tablechart2_Iconposition = "left";
         Dvpanel_tablechart2_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tablechart2_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tablechart2_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tablechart2_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tablechart2_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tablechart2_Title = "Task Board";
         Dvpanel_tablechart2_Cls = "DVBootstrapResponsivePanel";
         Dvpanel_tablechart2_Width = "100%";
         Utchartsmoothline_Charttype = "SmoothLine";
         Utchartsmoothline_Type = "Chart";
         Utchartsmoothline_Height = "450";
         Dvpanel_tablechart1_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tablechart1_Iconposition = "left";
         Dvpanel_tablechart1_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tablechart1_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tablechart1_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tablechart1_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tablechart1_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tablechart1_Title = "Sales Table";
         Dvpanel_tablechart1_Cls = "DVBootstrapResponsivePanel";
         Dvpanel_tablechart1_Width = "100%";
         Utchartcolumnline_Charttype = "ColumnLine";
         Utchartcolumnline_Type = "Chart";
         Utchartcolumnline_Height = "248";
         Utchartcolumnline_Width = "540";
         Dvpanel_tabletodolist_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tabletodolist_Iconposition = "left";
         Dvpanel_tabletodolist_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tabletodolist_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tabletodolist_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tabletodolist_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tabletodolist_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_tabletodolist_Title = "To Do List";
         Dvpanel_tabletodolist_Cls = "DVBootstrapResponsivePanel";
         Dvpanel_tabletodolist_Width = "100%";
         Progresscard4_Percentage = 40;
         Progresscard4_Cls = "ProgressBarAdminCard";
         Progresscard4_Type = "Bar";
         Progresscard3_Percentage = 70;
         Progresscard3_Cls = "ProgressBarAdminCard";
         Progresscard3_Type = "Bar";
         Progresscard2_Percentage = 20;
         Progresscard2_Cls = "ProgressBarAdminCard";
         Progresscard2_Type = "Bar";
         Progresscard1_Percentage = 50;
         Progresscard1_Cls = "ProgressBarAdminCard";
         Progresscard1_Type = "Bar";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Inicio";
         subGrid_Rows = 0;
         subGridtodolist_Rows = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDTODOLIST_nFirstRecordOnPage',nv:0},{av:'GRIDTODOLIST_nEOF',nv:0},{av:'subGridtodolist_Rows',nv:0},{av:'AV6HomeSampleNameValueData',fld:'vHOMESAMPLENAMEVALUEDATA',grid:104,pic:'',nv:null},{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV5HomeSampleData',fld:'vHOMESAMPLEDATA',grid:131,pic:'',nv:null}],oparms:[]}");
         setEventMetadata("GRID.LOAD","{handler:'E13093',iparms:[{av:'AV5HomeSampleData',fld:'vHOMESAMPLEDATA',grid:131,pic:'',nv:null},{av:'GRID_nFirstRecordOnPage',nv:0}],oparms:[{ctrl:'HOMESAMPLEDATA__PRODUCTSTATUS',prop:'Columnclass'}]}");
         setEventMetadata("GRIDTODOLIST.LOAD","{handler:'E12092',iparms:[{av:'AV6HomeSampleNameValueData',fld:'vHOMESAMPLENAMEVALUEDATA',grid:104,pic:'',nv:null},{av:'GRIDTODOLIST_nFirstRecordOnPage',nv:0}],oparms:[{av:'AV15HomeSampleNameValueData__NameWithTags',fld:'vHOMESAMPLENAMEVALUEDATA__NAMEWITHTAGS',pic:'',nv:''}]}");
         setEventMetadata("GRIDTODOLIST_FIRSTPAGE","{handler:'subgridtodolist_firstpage',iparms:[{av:'GRIDTODOLIST_nFirstRecordOnPage',nv:0},{av:'GRIDTODOLIST_nEOF',nv:0},{av:'subGridtodolist_Rows',nv:0},{av:'AV6HomeSampleNameValueData',fld:'vHOMESAMPLENAMEVALUEDATA',grid:104,pic:'',nv:null}],oparms:[]}");
         setEventMetadata("GRIDTODOLIST_PREVPAGE","{handler:'subgridtodolist_previouspage',iparms:[{av:'GRIDTODOLIST_nFirstRecordOnPage',nv:0},{av:'GRIDTODOLIST_nEOF',nv:0},{av:'subGridtodolist_Rows',nv:0},{av:'AV6HomeSampleNameValueData',fld:'vHOMESAMPLENAMEVALUEDATA',grid:104,pic:'',nv:null}],oparms:[]}");
         setEventMetadata("GRIDTODOLIST_NEXTPAGE","{handler:'subgridtodolist_nextpage',iparms:[{av:'GRIDTODOLIST_nFirstRecordOnPage',nv:0},{av:'GRIDTODOLIST_nEOF',nv:0},{av:'subGridtodolist_Rows',nv:0},{av:'AV6HomeSampleNameValueData',fld:'vHOMESAMPLENAMEVALUEDATA',grid:104,pic:'',nv:null}],oparms:[]}");
         setEventMetadata("GRIDTODOLIST_LASTPAGE","{handler:'subgridtodolist_lastpage',iparms:[{av:'GRIDTODOLIST_nFirstRecordOnPage',nv:0},{av:'GRIDTODOLIST_nEOF',nv:0},{av:'subGridtodolist_Rows',nv:0},{av:'AV6HomeSampleNameValueData',fld:'vHOMESAMPLENAMEVALUEDATA',grid:104,pic:'',nv:null}],oparms:[]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV5HomeSampleData',fld:'vHOMESAMPLEDATA',grid:131,pic:'',nv:null}],oparms:[]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV5HomeSampleData',fld:'vHOMESAMPLEDATA',grid:131,pic:'',nv:null}],oparms:[]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV5HomeSampleData',fld:'vHOMESAMPLEDATA',grid:131,pic:'',nv:null}],oparms:[]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV5HomeSampleData',fld:'vHOMESAMPLEDATA',grid:131,pic:'',nv:null}],oparms:[]}");
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
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV6HomeSampleNameValueData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem>( context, "HomeSampleNameValueDataItem", "SeriesColaborativas");
         GXKey = "";
         AV5HomeSampleData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem>( context, "HomeSampleDataItem", "SeriesColaborativas");
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV16DragAndDropData = new SdtQueryViewerDragAndDropData(context);
         AV17ItemExpandData = new SdtQueryViewerItemExpandData(context);
         AV18ItemCollapseData = new SdtQueryViewerItemCollapseData(context);
         AV19FilterChangedData = new SdtQueryViewerFilterChangedData(context);
         AV20ItemClickData = new SdtQueryViewerItemClickData(context);
         AV21ItemDoubleClickData = new SdtQueryViewerItemDoubleClickData(context);
         AV22Axes = new GXBaseCollection<SdtQueryViewerAxes_Axis>( context, "Axis", "SeriesColaborativas");
         AV23Parameters = new GXBaseCollection<SdtQueryViewerParameters_Parameter>( context, "Parameter", "SeriesColaborativas");
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         GridtodolistContainer = new GXWebGrid( context);
         sStyleString = "";
         subGridtodolist_Linesclass = "";
         GridtodolistColumn = new GXWebColumn();
         AV15HomeSampleNameValueData__NameWithTags = "";
         GridContainer = new GXWebGrid( context);
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV14AdditionalDataCard1 = "";
         AV12AdditionalDataCard2 = "";
         AV9ValueCard3 = "";
         AV10AdditionalDataCard3 = "";
         AV8AdditionalDataCard4 = "";
         GXt_objcol_SdtHomeSampleData_HomeSampleDataItem1 = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem>( context, "HomeSampleDataItem", "SeriesColaborativas");
         GXt_objcol_SdtHomeSampleNameValueData_HomeSampleNameValueDataItem2 = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem>( context, "HomeSampleNameValueDataItem", "SeriesColaborativas");
         GridtodolistRow = new GXWebRow();
         GridRow = new GXWebRow();
         lblProgresscard4icon_Jsonclick = "";
         lblDescriptioncard4_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         lblProgresscard3icon_Jsonclick = "";
         lblDescriptioncard3_Jsonclick = "";
         lblProgresscard2icon_Jsonclick = "";
         lblDescriptioncard2_Jsonclick = "";
         lblProgresscard1icon_Jsonclick = "";
         lblDescriptioncard1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavValuecard1_Enabled = 0;
         edtavAdditionaldatacard1_Enabled = 0;
         edtavValuecard2_Enabled = 0;
         edtavAdditionaldatacard2_Enabled = 0;
         edtavValuecard3_Enabled = 0;
         edtavAdditionaldatacard3_Enabled = 0;
         edtavValuecard4_Enabled = 0;
         edtavAdditionaldatacard4_Enabled = 0;
         edtavHomesamplenamevaluedata__namewithtags_Enabled = 0;
         edtavHomesamplenamevaluedata__name_Enabled = 0;
         edtavHomesamplenamevaluedata__value_Enabled = 0;
         edtavHomesampledata__productname_Enabled = 0;
         edtavHomesampledata__productprice_Enabled = 0;
         cmbavHomesampledata__productstatus.Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_104 ;
      private short nGXsfl_104_idx=1 ;
      private short nRC_GXsfl_131 ;
      private short GRIDTODOLIST_nEOF ;
      private short GRID_nEOF ;
      private short nGXsfl_131_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subGridtodolist_Backcolorstyle ;
      private short subGridtodolist_Titlebackstyle ;
      private short subGridtodolist_Allowselection ;
      private short subGridtodolist_Allowhovering ;
      private short subGridtodolist_Allowcollapsing ;
      private short subGridtodolist_Collapsed ;
      private short AV28GXV1 ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short AV32GXV5 ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_104_fel_idx=1 ;
      private short nGXsfl_131_fel_idx=1 ;
      private short subGridtodolist_Backstyle ;
      private short subGrid_Backstyle ;
      private int subGridtodolist_Rows ;
      private int subGrid_Rows ;
      private int Progresscard1_Percentage ;
      private int Progresscard2_Percentage ;
      private int Progresscard3_Percentage ;
      private int Progresscard4_Percentage ;
      private int subGridtodolist_Titlebackcolor ;
      private int subGridtodolist_Allbackcolor ;
      private int edtavHomesamplenamevaluedata__namewithtags_Enabled ;
      private int edtavHomesamplenamevaluedata__name_Enabled ;
      private int edtavHomesamplenamevaluedata__value_Enabled ;
      private int subGridtodolist_Selectioncolor ;
      private int subGridtodolist_Hoveringcolor ;
      private int divTablechart2_Height ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavHomesampledata__productname_Enabled ;
      private int edtavHomesampledata__productprice_Enabled ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int subGridtodolist_Islastpage ;
      private int subGrid_Islastpage ;
      private int edtavValuecard1_Enabled ;
      private int edtavAdditionaldatacard1_Enabled ;
      private int edtavValuecard2_Enabled ;
      private int edtavAdditionaldatacard2_Enabled ;
      private int edtavValuecard3_Enabled ;
      private int edtavAdditionaldatacard3_Enabled ;
      private int edtavValuecard4_Enabled ;
      private int edtavAdditionaldatacard4_Enabled ;
      private int GRIDTODOLIST_nGridOutOfScope ;
      private int GRID_nGridOutOfScope ;
      private int AV13ValueCard1 ;
      private int AV11ValueCard2 ;
      private int AV7ValueCard4 ;
      private int idxLst ;
      private int subGridtodolist_Backcolor ;
      private int subGrid_Backcolor ;
      private long GRIDTODOLIST_nFirstRecordOnPage ;
      private long GRID_nFirstRecordOnPage ;
      private long GRIDTODOLIST_nCurrentRecord ;
      private long GRID_nCurrentRecord ;
      private long GRIDTODOLIST_nRecordCount ;
      private long GRID_nRecordCount ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_104_idx="0001" ;
      private String GXKey ;
      private String sGXsfl_131_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Progresscard1_Type ;
      private String Progresscard1_Cls ;
      private String Progresscard2_Type ;
      private String Progresscard2_Cls ;
      private String Progresscard3_Type ;
      private String Progresscard3_Cls ;
      private String Progresscard4_Type ;
      private String Progresscard4_Cls ;
      private String Dvpanel_tabletodolist_Width ;
      private String Dvpanel_tabletodolist_Cls ;
      private String Dvpanel_tabletodolist_Title ;
      private String Dvpanel_tabletodolist_Iconposition ;
      private String Utchartcolumnline_Width ;
      private String Utchartcolumnline_Height ;
      private String Utchartcolumnline_Type ;
      private String Utchartcolumnline_Charttype ;
      private String Dvpanel_tablechart1_Width ;
      private String Dvpanel_tablechart1_Cls ;
      private String Dvpanel_tablechart1_Title ;
      private String Dvpanel_tablechart1_Iconposition ;
      private String Utchartsmoothline_Height ;
      private String Utchartsmoothline_Type ;
      private String Utchartsmoothline_Charttype ;
      private String Dvpanel_tablechart2_Width ;
      private String Dvpanel_tablechart2_Cls ;
      private String Dvpanel_tablechart2_Title ;
      private String Dvpanel_tablechart2_Iconposition ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divTablecards_Internalname ;
      private String divHtml_dvpanel_tabletodolist_Internalname ;
      private String divLayout_tabletodolist_Internalname ;
      private String divTabletodolist_Internalname ;
      private String sStyleString ;
      private String subGridtodolist_Internalname ;
      private String subGridtodolist_Class ;
      private String subGridtodolist_Linesclass ;
      private String divHtml_dvpanel_tablechart1_Internalname ;
      private String divLayout_tablechart1_Internalname ;
      private String divTablechart1_Internalname ;
      private String divHtml_dvpanel_tablechart2_Internalname ;
      private String divLayout_tablechart2_Internalname ;
      private String divTablechart2_Internalname ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String cmbavHomesampledata__productstatus_Columnclass ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavHomesamplenamevaluedata__namewithtags_Internalname ;
      private String GXCCtl ;
      private String chkavHomesamplenamevaluedata__check_Internalname ;
      private String edtavValuecard1_Internalname ;
      private String edtavAdditionaldatacard1_Internalname ;
      private String edtavValuecard2_Internalname ;
      private String edtavAdditionaldatacard2_Internalname ;
      private String edtavValuecard3_Internalname ;
      private String edtavAdditionaldatacard3_Internalname ;
      private String edtavValuecard4_Internalname ;
      private String edtavAdditionaldatacard4_Internalname ;
      private String edtavHomesamplenamevaluedata__name_Internalname ;
      private String edtavHomesamplenamevaluedata__value_Internalname ;
      private String edtavHomesampledata__productname_Internalname ;
      private String edtavHomesampledata__productprice_Internalname ;
      private String cmbavHomesampledata__productstatus_Internalname ;
      private String sGXsfl_104_fel_idx="0001" ;
      private String sGXsfl_131_fel_idx="0001" ;
      private String tblCard4_Internalname ;
      private String lblProgresscard4icon_Internalname ;
      private String lblProgresscard4icon_Jsonclick ;
      private String divTablecard4info_Internalname ;
      private String lblDescriptioncard4_Internalname ;
      private String lblDescriptioncard4_Jsonclick ;
      private String TempTags ;
      private String edtavValuecard4_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String tblCard3_Internalname ;
      private String lblProgresscard3icon_Internalname ;
      private String lblProgresscard3icon_Jsonclick ;
      private String divTablecard3info_Internalname ;
      private String lblDescriptioncard3_Internalname ;
      private String lblDescriptioncard3_Jsonclick ;
      private String edtavValuecard3_Jsonclick ;
      private String tblCard2_Internalname ;
      private String lblProgresscard2icon_Internalname ;
      private String lblProgresscard2icon_Jsonclick ;
      private String divTablecard2info_Internalname ;
      private String lblDescriptioncard2_Internalname ;
      private String lblDescriptioncard2_Jsonclick ;
      private String edtavValuecard2_Jsonclick ;
      private String tblCard1_Internalname ;
      private String lblProgresscard1icon_Internalname ;
      private String lblProgresscard1icon_Jsonclick ;
      private String divTablecard1info_Internalname ;
      private String lblDescriptioncard1_Internalname ;
      private String lblDescriptioncard1_Jsonclick ;
      private String edtavValuecard1_Jsonclick ;
      private String ROClassString ;
      private String edtavHomesamplenamevaluedata__namewithtags_Jsonclick ;
      private String edtavHomesamplenamevaluedata__name_Jsonclick ;
      private String edtavHomesamplenamevaluedata__value_Jsonclick ;
      private String edtavHomesampledata__productname_Jsonclick ;
      private String edtavHomesampledata__productprice_Jsonclick ;
      private String cmbavHomesampledata__productstatus_Jsonclick ;
      private String Progresscard1_Internalname ;
      private String Progresscard2_Internalname ;
      private String Progresscard3_Internalname ;
      private String Progresscard4_Internalname ;
      private String Dvpanel_tabletodolist_Internalname ;
      private String Utchartcolumnline_Internalname ;
      private String Dvpanel_tablechart1_Internalname ;
      private String Utchartsmoothline_Internalname ;
      private String Dvpanel_tablechart2_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tabletodolist_Collapsible ;
      private bool Dvpanel_tabletodolist_Collapsed ;
      private bool Dvpanel_tabletodolist_Autowidth ;
      private bool Dvpanel_tabletodolist_Autoheight ;
      private bool Dvpanel_tabletodolist_Showcollapseicon ;
      private bool Dvpanel_tabletodolist_Autoscroll ;
      private bool Dvpanel_tablechart1_Collapsible ;
      private bool Dvpanel_tablechart1_Collapsed ;
      private bool Dvpanel_tablechart1_Autowidth ;
      private bool Dvpanel_tablechart1_Autoheight ;
      private bool Dvpanel_tablechart1_Showcollapseicon ;
      private bool Dvpanel_tablechart1_Autoscroll ;
      private bool Dvpanel_tablechart2_Collapsible ;
      private bool Dvpanel_tablechart2_Collapsed ;
      private bool Dvpanel_tablechart2_Autowidth ;
      private bool Dvpanel_tablechart2_Autoheight ;
      private bool Dvpanel_tablechart2_Showcollapseicon ;
      private bool Dvpanel_tablechart2_Autoscroll ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_104_Refreshing=false ;
      private bool bGXsfl_131_Refreshing=false ;
      private bool returnInSub ;
      private bool gx_BV131 ;
      private bool gx_BV104 ;
      private String AV15HomeSampleNameValueData__NameWithTags ;
      private String AV14AdditionalDataCard1 ;
      private String AV12AdditionalDataCard2 ;
      private String AV9ValueCard3 ;
      private String AV10AdditionalDataCard3 ;
      private String AV8AdditionalDataCard4 ;
      private GXWebGrid GridtodolistContainer ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridtodolistRow ;
      private GXWebRow GridRow ;
      private GXWebColumn GridtodolistColumn ;
      private GXWebColumn GridColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavHomesamplenamevaluedata__check ;
      private GXCombobox cmbavHomesampledata__productstatus ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem> AV5HomeSampleData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem> GXt_objcol_SdtHomeSampleData_HomeSampleDataItem1 ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem> AV6HomeSampleNameValueData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem> GXt_objcol_SdtHomeSampleNameValueData_HomeSampleNameValueDataItem2 ;
      private GXBaseCollection<SdtQueryViewerAxes_Axis> AV22Axes ;
      private GXBaseCollection<SdtQueryViewerParameters_Parameter> AV23Parameters ;
      private GXWebForm Form ;
      private SdtQueryViewerDragAndDropData AV16DragAndDropData ;
      private SdtQueryViewerItemExpandData AV17ItemExpandData ;
      private SdtQueryViewerItemCollapseData AV18ItemCollapseData ;
      private SdtQueryViewerFilterChangedData AV19FilterChangedData ;
      private SdtQueryViewerItemClickData AV20ItemClickData ;
      private SdtQueryViewerItemDoubleClickData AV21ItemDoubleClickData ;
   }

}
