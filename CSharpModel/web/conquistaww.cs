/*
               File: ConquistaWW
        Description:  Conquista
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:13.62
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class conquistaww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public conquistaww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public conquistaww( IGxContext context )
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_GXsfl_33 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_33_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_33_idx = GetNextPar( );
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
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV46TFConquistaNome = GetNextPar( );
               AV47TFConquistaNome_Sel = GetNextPar( );
               AV42TFConquistaPontos = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV43TFConquistaPontos_To = (short)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV28ColumnsSelector);
               AV48ddo_ConquistaNomeTitleControlIdToReplace = GetNextPar( );
               AV44ddo_ConquistaPontosTitleControlIdToReplace = GetNextPar( );
               AV77Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV46TFConquistaNome, AV47TFConquistaNome_Sel, AV42TFConquistaPontos, AV43TFConquistaPontos_To, AV28ColumnsSelector, AV48ddo_ConquistaNomeTitleControlIdToReplace, AV44ddo_ConquistaPontosTitleControlIdToReplace, AV77Pgmname) ;
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
         PA272( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START272( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019461452", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("conquistaww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFCONQUISTANOME", AV46TFConquistaNome);
         GxWebStd.gx_hidden_field( context, "GXH_vTFCONQUISTANOME_SEL", AV47TFConquistaNome_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFCONQUISTAPONTOS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42TFConquistaPontos), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFCONQUISTAPONTOS_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43TFConquistaPontos_To), 4, 0, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_33", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_33), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV61GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV62GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV57DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV57DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vCONQUISTANOMETITLEFILTERDATA", AV45ConquistaNomeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vCONQUISTANOMETITLEFILTERDATA", AV45ConquistaNomeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vCONQUISTAPONTOSTITLEFILTERDATA", AV41ConquistaPontosTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vCONQUISTAPONTOSTITLEFILTERDATA", AV41ConquistaPontosTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vCOLUMNSSELECTOR", AV28ColumnsSelector);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vCOLUMNSSELECTOR", AV28ColumnsSelector);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV77Pgmname));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Width", StringUtil.RTrim( Dvpanel_tableheader_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Cls", StringUtil.RTrim( Dvpanel_tableheader_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Title", StringUtil.RTrim( Dvpanel_tableheader_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsible", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsed", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autowidth", StringUtil.BoolToStr( Dvpanel_tableheader_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoheight", StringUtil.BoolToStr( Dvpanel_tableheader_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableheader_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Iconposition", StringUtil.RTrim( Dvpanel_tableheader_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableheader_Autoscroll));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Class", StringUtil.RTrim( Gridpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Previous", StringUtil.RTrim( Gridpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Next", StringUtil.RTrim( Gridpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Caption", StringUtil.RTrim( Gridpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Caption", StringUtil.RTrim( Ddo_conquistanome_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Tooltip", StringUtil.RTrim( Ddo_conquistanome_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Cls", StringUtil.RTrim( Ddo_conquistanome_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Filteredtext_set", StringUtil.RTrim( Ddo_conquistanome_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Selectedvalue_set", StringUtil.RTrim( Ddo_conquistanome_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Dropdownoptionstype", StringUtil.RTrim( Ddo_conquistanome_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_conquistanome_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Includesortasc", StringUtil.BoolToStr( Ddo_conquistanome_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Includesortdsc", StringUtil.BoolToStr( Ddo_conquistanome_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Sortedstatus", StringUtil.RTrim( Ddo_conquistanome_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Includefilter", StringUtil.BoolToStr( Ddo_conquistanome_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Filtertype", StringUtil.RTrim( Ddo_conquistanome_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Filterisrange", StringUtil.BoolToStr( Ddo_conquistanome_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Includedatalist", StringUtil.BoolToStr( Ddo_conquistanome_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Datalisttype", StringUtil.RTrim( Ddo_conquistanome_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Datalistproc", StringUtil.RTrim( Ddo_conquistanome_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_conquistanome_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Sortasc", StringUtil.RTrim( Ddo_conquistanome_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Sortdsc", StringUtil.RTrim( Ddo_conquistanome_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Loadingdata", StringUtil.RTrim( Ddo_conquistanome_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Cleanfilter", StringUtil.RTrim( Ddo_conquistanome_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Noresultsfound", StringUtil.RTrim( Ddo_conquistanome_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Searchbuttontext", StringUtil.RTrim( Ddo_conquistanome_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Caption", StringUtil.RTrim( Ddo_conquistapontos_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Tooltip", StringUtil.RTrim( Ddo_conquistapontos_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Cls", StringUtil.RTrim( Ddo_conquistapontos_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Filteredtext_set", StringUtil.RTrim( Ddo_conquistapontos_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Filteredtextto_set", StringUtil.RTrim( Ddo_conquistapontos_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Dropdownoptionstype", StringUtil.RTrim( Ddo_conquistapontos_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_conquistapontos_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Includesortasc", StringUtil.BoolToStr( Ddo_conquistapontos_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Includesortdsc", StringUtil.BoolToStr( Ddo_conquistapontos_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Sortedstatus", StringUtil.RTrim( Ddo_conquistapontos_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Includefilter", StringUtil.BoolToStr( Ddo_conquistapontos_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Filtertype", StringUtil.RTrim( Ddo_conquistapontos_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Filterisrange", StringUtil.BoolToStr( Ddo_conquistapontos_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Includedatalist", StringUtil.BoolToStr( Ddo_conquistapontos_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Sortasc", StringUtil.RTrim( Ddo_conquistapontos_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Sortdsc", StringUtil.RTrim( Ddo_conquistapontos_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Cleanfilter", StringUtil.RTrim( Ddo_conquistapontos_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Rangefilterfrom", StringUtil.RTrim( Ddo_conquistapontos_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Rangefilterto", StringUtil.RTrim( Ddo_conquistapontos_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Searchbuttontext", StringUtil.RTrim( Ddo_conquistapontos_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Caption", StringUtil.RTrim( Ddo_gridcolumnsselector_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Tooltip", StringUtil.RTrim( Ddo_gridcolumnsselector_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Cls", StringUtil.RTrim( Ddo_gridcolumnsselector_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_gridcolumnsselector_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_gridcolumnsselector_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Updatebuttontext", StringUtil.RTrim( Ddo_gridcolumnsselector_Updatebuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Activeeventkey", StringUtil.RTrim( Ddo_conquistanome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Filteredtext_get", StringUtil.RTrim( Ddo_conquistanome_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Selectedvalue_get", StringUtil.RTrim( Ddo_conquistanome_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Activeeventkey", StringUtil.RTrim( Ddo_conquistapontos_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Filteredtext_get", StringUtil.RTrim( Ddo_conquistapontos_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Filteredtextto_get", StringUtil.RTrim( Ddo_conquistapontos_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues", StringUtil.RTrim( Ddo_gridcolumnsselector_Columnsselectorvalues));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Activeeventkey", StringUtil.RTrim( Ddo_conquistanome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Filteredtext_get", StringUtil.RTrim( Ddo_conquistanome_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTANOME_Selectedvalue_get", StringUtil.RTrim( Ddo_conquistanome_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Activeeventkey", StringUtil.RTrim( Ddo_conquistapontos_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Filteredtext_get", StringUtil.RTrim( Ddo_conquistapontos_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_CONQUISTAPONTOS_Filteredtextto_get", StringUtil.RTrim( Ddo_conquistapontos_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues", StringUtil.RTrim( Ddo_gridcolumnsselector_Columnsselectorvalues));
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
            WE272( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT272( ) ;
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
         return formatLink("conquistaww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "ConquistaWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " Conquista" ;
      }

      protected void WB270( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableheader_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_TABLEHEADERContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEHEADERContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableheader_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableheader_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableactions_Internalname, 1, 0, "px", 0, "px", "TableCellsWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupColoredActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(33), 2, 0)+","+"null"+");", "Inserir", bttBtninsert_Jsonclick, 5, "Inserir", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_ConquistaWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            ClassString = "hidden-xs";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtneditcolumns_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(33), 2, 0)+","+"null"+");", "Seleciona colunas", bttBtneditcolumns_Jsonclick, 5, "Seleciona colunas", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'EDITCOLUMNS\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_ConquistaWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 SectionGrid", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtablewithpaginationbar_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"33\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "GridWithPaginationBar GridWithBorderColor WorkWith", 0, "", "", 1, 2, sStyleString, "", 0);
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtConquistaNome_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtConquistaNome_Titleformat == 0 )
               {
                  context.SendWebValue( edtConquistaNome_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtConquistaNome_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtConquistaPontos_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtConquistaPontos_Titleformat == 0 )
               {
                  context.SendWebValue( edtConquistaPontos_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtConquistaPontos_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridContainer.AddObjectProperty("GridName", "Grid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridContainer = new GXWebGrid( context);
               }
               else
               {
                  GridContainer.Clear();
               }
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV65Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ConquistaId), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A29ConquistaNome);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtConquistaNome_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtConquistaNome_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtConquistaNome_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A28ConquistaPontos), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtConquistaPontos_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtConquistaPontos_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtConquistaPontos_Link));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtConquistaPontos_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowselection), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectioncolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowhovering), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Hoveringcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowcollapsing), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 33 )
         {
            wbEnd = 0;
            nRC_GXsfl_33 = (short)(nGXsfl_33_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_gridpaginationbar_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"GRIDPAGINATIONBARContainer"+"\"></div>") ;
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
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DDO_CONQUISTANOMEContainer"+"\"></div>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_33_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_conquistanometitlecontrolidtoreplace_Internalname, AV48ddo_ConquistaNomeTitleControlIdToReplace, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_conquistanometitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ConquistaWW.htm");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DDO_CONQUISTAPONTOSContainer"+"\"></div>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_33_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_conquistapontostitlecontrolidtoreplace_Internalname, AV44ddo_ConquistaPontosTitleControlIdToReplace, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_conquistapontostitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ConquistaWW.htm");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"WORKWITHPLUSUTILITIES1Container"+"\"></div>") ;
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DDO_GRIDCOLUMNSSELECTORContainer"+"\"></div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_33_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ConquistaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_33_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_ConquistaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_33_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfconquistanome_Internalname, AV46TFConquistaNome, StringUtil.RTrim( context.localUtil.Format( AV46TFConquistaNome, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfconquistanome_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfconquistanome_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ConquistaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_33_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfconquistanome_sel_Internalname, AV47TFConquistaNome_Sel, StringUtil.RTrim( context.localUtil.Format( AV47TFConquistaNome_Sel, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfconquistanome_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfconquistanome_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ConquistaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_33_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfconquistapontos_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42TFConquistaPontos), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV42TFConquistaPontos), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfconquistapontos_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfconquistapontos_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ConquistaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_33_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfconquistapontos_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43TFConquistaPontos_To), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV43TFConquistaPontos_To), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfconquistapontos_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfconquistapontos_to_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ConquistaWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START272( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", " Conquista", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP270( ) ;
      }

      protected void WS272( )
      {
         START272( ) ;
         EVT272( ) ;
      }

      protected void EVT272( )
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
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E11272 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12272 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_CONQUISTANOME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13272 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_CONQUISTAPONTOS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14272 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15272 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E16272 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'EDITCOLUMNS'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
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
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_33_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_33_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_33_idx), 4, 0)), 4, "0");
                              SubsflControlProps_332( ) ;
                              AV65Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV65Update)) ? AV76Update_GXI : context.convertURL( context.PathToRelativeUrl( AV65Update))), !bGXsfl_33_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV65Update), true);
                              A27ConquistaId = (long)(context.localUtil.CToN( cgiGet( edtConquistaId_Internalname), ",", "."));
                              A29ConquistaNome = cgiGet( edtConquistaNome_Internalname);
                              A28ConquistaPontos = (short)(context.localUtil.CToN( cgiGet( edtConquistaPontos_Internalname), ",", "."));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E17272 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E18272 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E19272 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV13OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfconquistanome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFCONQUISTANOME"), AV46TFConquistaNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfconquistanome_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFCONQUISTANOME_SEL"), AV47TFConquistaNome_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfconquistapontos Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFCONQUISTAPONTOS"), ",", ".") != Convert.ToDecimal( AV42TFConquistaPontos )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfconquistapontos_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFCONQUISTAPONTOS_TO"), ",", ".") != Convert.ToDecimal( AV43TFConquistaPontos_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
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
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE272( )
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

      protected void PA272( )
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
               GX_FocusControl = edtavDdo_conquistanometitlecontrolidtoreplace_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_332( ) ;
         while ( nGXsfl_33_idx <= nRC_GXsfl_33 )
         {
            sendrow_332( ) ;
            nGXsfl_33_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_33_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_33_idx+1));
            sGXsfl_33_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_33_idx), 4, 0)), 4, "0");
            SubsflControlProps_332( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       String AV46TFConquistaNome ,
                                       String AV47TFConquistaNome_Sel ,
                                       short AV42TFConquistaPontos ,
                                       short AV43TFConquistaPontos_To ,
                                       GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV28ColumnsSelector ,
                                       String AV48ddo_ConquistaNomeTitleControlIdToReplace ,
                                       String AV44ddo_ConquistaPontosTitleControlIdToReplace ,
                                       String AV77Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF272( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_CONQUISTAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "CONQUISTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ConquistaId), 18, 0, ".", "")));
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
         RF272( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV77Pgmname = "ConquistaWW";
         context.Gx_err = 0;
      }

      protected void RF272( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 33;
         /* Execute user event: Refresh */
         E18272 ();
         nGXsfl_33_idx = 1;
         sGXsfl_33_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_33_idx), 4, 0)), 4, "0");
         SubsflControlProps_332( ) ;
         bGXsfl_33_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWith");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_332( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV73ConquistaWWDS_2_Tfconquistanome_sel ,
                                                 AV72ConquistaWWDS_1_Tfconquistanome ,
                                                 AV74ConquistaWWDS_3_Tfconquistapontos ,
                                                 AV75ConquistaWWDS_4_Tfconquistapontos_to ,
                                                 A29ConquistaNome ,
                                                 A28ConquistaPontos ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV72ConquistaWWDS_1_Tfconquistanome = StringUtil.Concat( StringUtil.RTrim( AV72ConquistaWWDS_1_Tfconquistanome), "%", "");
            /* Using cursor H00272 */
            pr_default.execute(0, new Object[] {lV72ConquistaWWDS_1_Tfconquistanome, AV73ConquistaWWDS_2_Tfconquistanome_sel, AV74ConquistaWWDS_3_Tfconquistapontos, AV75ConquistaWWDS_4_Tfconquistapontos_to, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_33_idx = 1;
            sGXsfl_33_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_33_idx), 4, 0)), 4, "0");
            SubsflControlProps_332( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A28ConquistaPontos = H00272_A28ConquistaPontos[0];
               A29ConquistaNome = H00272_A29ConquistaNome[0];
               A27ConquistaId = H00272_A27ConquistaId[0];
               E19272 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 33;
            WB270( ) ;
         }
         bGXsfl_33_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes272( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_CONQUISTAID"+"_"+sGXsfl_33_idx, GetSecureSignedToken( sGXsfl_33_idx, context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9"), context));
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
         AV72ConquistaWWDS_1_Tfconquistanome = AV46TFConquistaNome;
         AV73ConquistaWWDS_2_Tfconquistanome_sel = AV47TFConquistaNome_Sel;
         AV74ConquistaWWDS_3_Tfconquistapontos = AV42TFConquistaPontos;
         AV75ConquistaWWDS_4_Tfconquistapontos_to = AV43TFConquistaPontos_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV73ConquistaWWDS_2_Tfconquistanome_sel ,
                                              AV72ConquistaWWDS_1_Tfconquistanome ,
                                              AV74ConquistaWWDS_3_Tfconquistapontos ,
                                              AV75ConquistaWWDS_4_Tfconquistapontos_to ,
                                              A29ConquistaNome ,
                                              A28ConquistaPontos ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV72ConquistaWWDS_1_Tfconquistanome = StringUtil.Concat( StringUtil.RTrim( AV72ConquistaWWDS_1_Tfconquistanome), "%", "");
         /* Using cursor H00273 */
         pr_default.execute(1, new Object[] {lV72ConquistaWWDS_1_Tfconquistanome, AV73ConquistaWWDS_2_Tfconquistanome_sel, AV74ConquistaWWDS_3_Tfconquistapontos, AV75ConquistaWWDS_4_Tfconquistapontos_to});
         GRID_nRecordCount = H00273_AGRID_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID_nRecordCount) ;
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
         AV72ConquistaWWDS_1_Tfconquistanome = AV46TFConquistaNome;
         AV73ConquistaWWDS_2_Tfconquistanome_sel = AV47TFConquistaNome_Sel;
         AV74ConquistaWWDS_3_Tfconquistapontos = AV42TFConquistaPontos;
         AV75ConquistaWWDS_4_Tfconquistapontos_to = AV43TFConquistaPontos_To;
         GRID_nFirstRecordOnPage = 0;
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV46TFConquistaNome, AV47TFConquistaNome_Sel, AV42TFConquistaPontos, AV43TFConquistaPontos_To, AV28ColumnsSelector, AV48ddo_ConquistaNomeTitleControlIdToReplace, AV44ddo_ConquistaPontosTitleControlIdToReplace, AV77Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV72ConquistaWWDS_1_Tfconquistanome = AV46TFConquistaNome;
         AV73ConquistaWWDS_2_Tfconquistanome_sel = AV47TFConquistaNome_Sel;
         AV74ConquistaWWDS_3_Tfconquistapontos = AV42TFConquistaPontos;
         AV75ConquistaWWDS_4_Tfconquistapontos_to = AV43TFConquistaPontos_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV46TFConquistaNome, AV47TFConquistaNome_Sel, AV42TFConquistaPontos, AV43TFConquistaPontos_To, AV28ColumnsSelector, AV48ddo_ConquistaNomeTitleControlIdToReplace, AV44ddo_ConquistaPontosTitleControlIdToReplace, AV77Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV72ConquistaWWDS_1_Tfconquistanome = AV46TFConquistaNome;
         AV73ConquistaWWDS_2_Tfconquistanome_sel = AV47TFConquistaNome_Sel;
         AV74ConquistaWWDS_3_Tfconquistapontos = AV42TFConquistaPontos;
         AV75ConquistaWWDS_4_Tfconquistapontos_to = AV43TFConquistaPontos_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV46TFConquistaNome, AV47TFConquistaNome_Sel, AV42TFConquistaPontos, AV43TFConquistaPontos_To, AV28ColumnsSelector, AV48ddo_ConquistaNomeTitleControlIdToReplace, AV44ddo_ConquistaPontosTitleControlIdToReplace, AV77Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV72ConquistaWWDS_1_Tfconquistanome = AV46TFConquistaNome;
         AV73ConquistaWWDS_2_Tfconquistanome_sel = AV47TFConquistaNome_Sel;
         AV74ConquistaWWDS_3_Tfconquistapontos = AV42TFConquistaPontos;
         AV75ConquistaWWDS_4_Tfconquistapontos_to = AV43TFConquistaPontos_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV46TFConquistaNome, AV47TFConquistaNome_Sel, AV42TFConquistaPontos, AV43TFConquistaPontos_To, AV28ColumnsSelector, AV48ddo_ConquistaNomeTitleControlIdToReplace, AV44ddo_ConquistaPontosTitleControlIdToReplace, AV77Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV72ConquistaWWDS_1_Tfconquistanome = AV46TFConquistaNome;
         AV73ConquistaWWDS_2_Tfconquistanome_sel = AV47TFConquistaNome_Sel;
         AV74ConquistaWWDS_3_Tfconquistapontos = AV42TFConquistaPontos;
         AV75ConquistaWWDS_4_Tfconquistapontos_to = AV43TFConquistaPontos_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV46TFConquistaNome, AV47TFConquistaNome_Sel, AV42TFConquistaPontos, AV43TFConquistaPontos_To, AV28ColumnsSelector, AV48ddo_ConquistaNomeTitleControlIdToReplace, AV44ddo_ConquistaPontosTitleControlIdToReplace, AV77Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP270( )
      {
         /* Before Start, stand alone formulas. */
         AV77Pgmname = "ConquistaWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E17272 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV57DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vCONQUISTANOMETITLEFILTERDATA"), AV45ConquistaNomeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vCONQUISTAPONTOSTITLEFILTERDATA"), AV41ConquistaPontosTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vCOLUMNSSELECTOR"), AV28ColumnsSelector);
            /* Read variables values. */
            AV48ddo_ConquistaNomeTitleControlIdToReplace = cgiGet( edtavDdo_conquistanometitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48ddo_ConquistaNomeTitleControlIdToReplace", AV48ddo_ConquistaNomeTitleControlIdToReplace);
            AV44ddo_ConquistaPontosTitleControlIdToReplace = cgiGet( edtavDdo_conquistapontostitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44ddo_ConquistaPontosTitleControlIdToReplace", AV44ddo_ConquistaPontosTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            else
            {
               AV13OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            AV14OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            AV46TFConquistaNome = cgiGet( edtavTfconquistanome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFConquistaNome", AV46TFConquistaNome);
            AV47TFConquistaNome_Sel = cgiGet( edtavTfconquistanome_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFConquistaNome_Sel", AV47TFConquistaNome_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfconquistapontos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfconquistapontos_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFCONQUISTAPONTOS");
               GX_FocusControl = edtavTfconquistapontos_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV42TFConquistaPontos = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42TFConquistaPontos), 4, 0)));
            }
            else
            {
               AV42TFConquistaPontos = (short)(context.localUtil.CToN( cgiGet( edtavTfconquistapontos_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42TFConquistaPontos), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfconquistapontos_to_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfconquistapontos_to_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFCONQUISTAPONTOS_TO");
               GX_FocusControl = edtavTfconquistapontos_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV43TFConquistaPontos_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFConquistaPontos_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFConquistaPontos_To), 4, 0)));
            }
            else
            {
               AV43TFConquistaPontos_To = (short)(context.localUtil.CToN( cgiGet( edtavTfconquistapontos_to_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFConquistaPontos_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFConquistaPontos_To), 4, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_33 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_33"), ",", "."));
            AV61GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV62GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ",", "."));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ",", "."));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Dvpanel_tableheader_Width = cgiGet( "DVPANEL_TABLEHEADER_Width");
            Dvpanel_tableheader_Cls = cgiGet( "DVPANEL_TABLEHEADER_Cls");
            Dvpanel_tableheader_Title = cgiGet( "DVPANEL_TABLEHEADER_Title");
            Dvpanel_tableheader_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsible"));
            Dvpanel_tableheader_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsed"));
            Dvpanel_tableheader_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autowidth"));
            Dvpanel_tableheader_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoheight"));
            Dvpanel_tableheader_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Showcollapseicon"));
            Dvpanel_tableheader_Iconposition = cgiGet( "DVPANEL_TABLEHEADER_Iconposition");
            Dvpanel_tableheader_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoscroll"));
            Gridpaginationbar_Class = cgiGet( "GRIDPAGINATIONBAR_Class");
            Gridpaginationbar_Previous = cgiGet( "GRIDPAGINATIONBAR_Previous");
            Gridpaginationbar_Next = cgiGet( "GRIDPAGINATIONBAR_Next");
            Gridpaginationbar_Caption = cgiGet( "GRIDPAGINATIONBAR_Caption");
            Gridpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showfirst"));
            Gridpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showprevious"));
            Gridpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Shownext"));
            Gridpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showlast"));
            Gridpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Pagestoshow"), ",", "."));
            Gridpaginationbar_Pagingbuttonsposition = cgiGet( "GRIDPAGINATIONBAR_Pagingbuttonsposition");
            Gridpaginationbar_Pagingcaptionposition = cgiGet( "GRIDPAGINATIONBAR_Pagingcaptionposition");
            Gridpaginationbar_Emptygridclass = cgiGet( "GRIDPAGINATIONBAR_Emptygridclass");
            Gridpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselector"));
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            Gridpaginationbar_Rowsperpageoptions = cgiGet( "GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Emptygridcaption = cgiGet( "GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( "GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_conquistanome_Caption = cgiGet( "DDO_CONQUISTANOME_Caption");
            Ddo_conquistanome_Tooltip = cgiGet( "DDO_CONQUISTANOME_Tooltip");
            Ddo_conquistanome_Cls = cgiGet( "DDO_CONQUISTANOME_Cls");
            Ddo_conquistanome_Filteredtext_set = cgiGet( "DDO_CONQUISTANOME_Filteredtext_set");
            Ddo_conquistanome_Selectedvalue_set = cgiGet( "DDO_CONQUISTANOME_Selectedvalue_set");
            Ddo_conquistanome_Dropdownoptionstype = cgiGet( "DDO_CONQUISTANOME_Dropdownoptionstype");
            Ddo_conquistanome_Titlecontrolidtoreplace = cgiGet( "DDO_CONQUISTANOME_Titlecontrolidtoreplace");
            Ddo_conquistanome_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_CONQUISTANOME_Includesortasc"));
            Ddo_conquistanome_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_CONQUISTANOME_Includesortdsc"));
            Ddo_conquistanome_Sortedstatus = cgiGet( "DDO_CONQUISTANOME_Sortedstatus");
            Ddo_conquistanome_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_CONQUISTANOME_Includefilter"));
            Ddo_conquistanome_Filtertype = cgiGet( "DDO_CONQUISTANOME_Filtertype");
            Ddo_conquistanome_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_CONQUISTANOME_Filterisrange"));
            Ddo_conquistanome_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_CONQUISTANOME_Includedatalist"));
            Ddo_conquistanome_Datalisttype = cgiGet( "DDO_CONQUISTANOME_Datalisttype");
            Ddo_conquistanome_Datalistproc = cgiGet( "DDO_CONQUISTANOME_Datalistproc");
            Ddo_conquistanome_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_CONQUISTANOME_Datalistupdateminimumcharacters"), ",", "."));
            Ddo_conquistanome_Sortasc = cgiGet( "DDO_CONQUISTANOME_Sortasc");
            Ddo_conquistanome_Sortdsc = cgiGet( "DDO_CONQUISTANOME_Sortdsc");
            Ddo_conquistanome_Loadingdata = cgiGet( "DDO_CONQUISTANOME_Loadingdata");
            Ddo_conquistanome_Cleanfilter = cgiGet( "DDO_CONQUISTANOME_Cleanfilter");
            Ddo_conquistanome_Noresultsfound = cgiGet( "DDO_CONQUISTANOME_Noresultsfound");
            Ddo_conquistanome_Searchbuttontext = cgiGet( "DDO_CONQUISTANOME_Searchbuttontext");
            Ddo_conquistapontos_Caption = cgiGet( "DDO_CONQUISTAPONTOS_Caption");
            Ddo_conquistapontos_Tooltip = cgiGet( "DDO_CONQUISTAPONTOS_Tooltip");
            Ddo_conquistapontos_Cls = cgiGet( "DDO_CONQUISTAPONTOS_Cls");
            Ddo_conquistapontos_Filteredtext_set = cgiGet( "DDO_CONQUISTAPONTOS_Filteredtext_set");
            Ddo_conquistapontos_Filteredtextto_set = cgiGet( "DDO_CONQUISTAPONTOS_Filteredtextto_set");
            Ddo_conquistapontos_Dropdownoptionstype = cgiGet( "DDO_CONQUISTAPONTOS_Dropdownoptionstype");
            Ddo_conquistapontos_Titlecontrolidtoreplace = cgiGet( "DDO_CONQUISTAPONTOS_Titlecontrolidtoreplace");
            Ddo_conquistapontos_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_CONQUISTAPONTOS_Includesortasc"));
            Ddo_conquistapontos_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_CONQUISTAPONTOS_Includesortdsc"));
            Ddo_conquistapontos_Sortedstatus = cgiGet( "DDO_CONQUISTAPONTOS_Sortedstatus");
            Ddo_conquistapontos_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_CONQUISTAPONTOS_Includefilter"));
            Ddo_conquistapontos_Filtertype = cgiGet( "DDO_CONQUISTAPONTOS_Filtertype");
            Ddo_conquistapontos_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_CONQUISTAPONTOS_Filterisrange"));
            Ddo_conquistapontos_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_CONQUISTAPONTOS_Includedatalist"));
            Ddo_conquistapontos_Sortasc = cgiGet( "DDO_CONQUISTAPONTOS_Sortasc");
            Ddo_conquistapontos_Sortdsc = cgiGet( "DDO_CONQUISTAPONTOS_Sortdsc");
            Ddo_conquistapontos_Cleanfilter = cgiGet( "DDO_CONQUISTAPONTOS_Cleanfilter");
            Ddo_conquistapontos_Rangefilterfrom = cgiGet( "DDO_CONQUISTAPONTOS_Rangefilterfrom");
            Ddo_conquistapontos_Rangefilterto = cgiGet( "DDO_CONQUISTAPONTOS_Rangefilterto");
            Ddo_conquistapontos_Searchbuttontext = cgiGet( "DDO_CONQUISTAPONTOS_Searchbuttontext");
            Ddo_gridcolumnsselector_Caption = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Caption");
            Ddo_gridcolumnsselector_Tooltip = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Tooltip");
            Ddo_gridcolumnsselector_Cls = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Cls");
            Ddo_gridcolumnsselector_Dropdownoptionstype = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Dropdownoptionstype");
            Ddo_gridcolumnsselector_Titlecontrolidtoreplace = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Titlecontrolidtoreplace");
            Ddo_gridcolumnsselector_Updatebuttontext = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Updatebuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            Ddo_conquistanome_Activeeventkey = cgiGet( "DDO_CONQUISTANOME_Activeeventkey");
            Ddo_conquistanome_Filteredtext_get = cgiGet( "DDO_CONQUISTANOME_Filteredtext_get");
            Ddo_conquistanome_Selectedvalue_get = cgiGet( "DDO_CONQUISTANOME_Selectedvalue_get");
            Ddo_conquistapontos_Activeeventkey = cgiGet( "DDO_CONQUISTAPONTOS_Activeeventkey");
            Ddo_conquistapontos_Filteredtext_get = cgiGet( "DDO_CONQUISTAPONTOS_Filteredtext_get");
            Ddo_conquistapontos_Filteredtextto_get = cgiGet( "DDO_CONQUISTAPONTOS_Filteredtextto_get");
            Ddo_gridcolumnsselector_Columnsselectorvalues = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV13OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFCONQUISTANOME"), AV46TFConquistaNome) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFCONQUISTANOME_SEL"), AV47TFConquistaNome_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFCONQUISTAPONTOS"), ",", ".") != Convert.ToDecimal( AV42TFConquistaPontos )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFCONQUISTAPONTOS_TO"), ",", ".") != Convert.ToDecimal( AV43TFConquistaPontos_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
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
         E17272 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E17272( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfconquistanome_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfconquistanome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfconquistanome_Visible), 5, 0)), true);
         edtavTfconquistanome_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfconquistanome_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfconquistanome_sel_Visible), 5, 0)), true);
         edtavTfconquistapontos_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfconquistapontos_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfconquistapontos_Visible), 5, 0)), true);
         edtavTfconquistapontos_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfconquistapontos_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfconquistapontos_to_Visible), 5, 0)), true);
         Ddo_conquistanome_Titlecontrolidtoreplace = subGrid_Internalname+"_ConquistaNome";
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistanome_Internalname, "TitleControlIdToReplace", Ddo_conquistanome_Titlecontrolidtoreplace);
         AV48ddo_ConquistaNomeTitleControlIdToReplace = Ddo_conquistanome_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48ddo_ConquistaNomeTitleControlIdToReplace", AV48ddo_ConquistaNomeTitleControlIdToReplace);
         edtavDdo_conquistanometitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_conquistanometitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_conquistanometitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_conquistapontos_Titlecontrolidtoreplace = subGrid_Internalname+"_ConquistaPontos";
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistapontos_Internalname, "TitleControlIdToReplace", Ddo_conquistapontos_Titlecontrolidtoreplace);
         AV44ddo_ConquistaPontosTitleControlIdToReplace = Ddo_conquistapontos_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44ddo_ConquistaPontosTitleControlIdToReplace", AV44ddo_ConquistaPontosTitleControlIdToReplace);
         edtavDdo_conquistapontostitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_conquistapontostitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_conquistapontostitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " Conquista";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV13OrderedBy < 1 )
         {
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV57DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV57DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = bttBtneditcolumns_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_gridcolumnsselector_Internalname, "TitleControlIdToReplace", Ddo_gridcolumnsselector_Titlecontrolidtoreplace);
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E18272( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV45ConquistaNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV41ConquistaPontosTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( StringUtil.StrCmp(AV36Session.Get("ConquistaWWColumnsSelector"), "") != 0 )
         {
            AV16ColumnsSelectorXML = AV36Session.Get("ConquistaWWColumnsSelector");
            AV28ColumnsSelector.FromXml(AV16ColumnsSelectorXML, null, "WWPColumnsSelector", "SeriesColaborativas");
         }
         else
         {
            /* Execute user subroutine: 'INITIALIZECOLUMNSSELECTOR' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtConquistaNome_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaNome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaNome_Visible), 5, 0)), !bGXsfl_33_Refreshing);
         edtConquistaPontos_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaPontos_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaPontos_Visible), 5, 0)), !bGXsfl_33_Refreshing);
         AV71GXV1 = 1;
         while ( AV71GXV1 <= AV28ColumnsSelector.gxTpr_Visiblecolumns.Count )
         {
            AV29VisibleColumn = ((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn)AV28ColumnsSelector.gxTpr_Visiblecolumns.Item(AV71GXV1));
            if ( StringUtil.StrCmp(AV29VisibleColumn.gxTpr_Columnname, "Nome") == 0 )
            {
               edtConquistaNome_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaNome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaNome_Visible), 5, 0)), !bGXsfl_33_Refreshing);
            }
            else if ( StringUtil.StrCmp(AV29VisibleColumn.gxTpr_Columnname, "Pontos") == 0 )
            {
               edtConquistaPontos_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaPontos_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaPontos_Visible), 5, 0)), !bGXsfl_33_Refreshing);
            }
            AV71GXV1 = (int)(AV71GXV1+1);
         }
         edtConquistaNome_Titleformat = 2;
         edtConquistaNome_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Nome", AV48ddo_ConquistaNomeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaNome_Internalname, "Title", edtConquistaNome_Title, !bGXsfl_33_Refreshing);
         edtConquistaPontos_Titleformat = 2;
         edtConquistaPontos_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Pontos", AV44ddo_ConquistaPontosTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaPontos_Internalname, "Title", edtConquistaPontos_Title, !bGXsfl_33_Refreshing);
         AV61GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV61GridCurrentPage), 10, 0)));
         AV62GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV62GridPageCount), 10, 0)));
         AV72ConquistaWWDS_1_Tfconquistanome = AV46TFConquistaNome;
         AV73ConquistaWWDS_2_Tfconquistanome_sel = AV47TFConquistaNome_Sel;
         AV74ConquistaWWDS_3_Tfconquistapontos = AV42TFConquistaPontos;
         AV75ConquistaWWDS_4_Tfconquistapontos_to = AV43TFConquistaPontos_To;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45ConquistaNomeTitleFilterData", AV45ConquistaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ConquistaPontosTitleFilterData", AV41ConquistaPontosTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28ColumnsSelector", AV28ColumnsSelector);
      }

      protected void E11272( )
      {
         /* Gridpaginationbar_Changepage Routine */
         if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Previous") == 0 )
         {
            subgrid_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Next") == 0 )
         {
            subgrid_nextpage( ) ;
         }
         else
         {
            AV60PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV60PageToGo) ;
         }
      }

      protected void E12272( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13272( )
      {
         /* Ddo_conquistanome_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_conquistanome_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_conquistanome_Sortedstatus = "ASC";
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistanome_Internalname, "SortedStatus", Ddo_conquistanome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_conquistanome_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_conquistanome_Sortedstatus = "DSC";
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistanome_Internalname, "SortedStatus", Ddo_conquistanome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_conquistanome_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV46TFConquistaNome = Ddo_conquistanome_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFConquistaNome", AV46TFConquistaNome);
            AV47TFConquistaNome_Sel = Ddo_conquistanome_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFConquistaNome_Sel", AV47TFConquistaNome_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45ConquistaNomeTitleFilterData", AV45ConquistaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ConquistaPontosTitleFilterData", AV41ConquistaPontosTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28ColumnsSelector", AV28ColumnsSelector);
      }

      protected void E14272( )
      {
         /* Ddo_conquistapontos_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_conquistapontos_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_conquistapontos_Sortedstatus = "ASC";
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistapontos_Internalname, "SortedStatus", Ddo_conquistapontos_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_conquistapontos_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_conquistapontos_Sortedstatus = "DSC";
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistapontos_Internalname, "SortedStatus", Ddo_conquistapontos_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_conquistapontos_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV42TFConquistaPontos = (short)(NumberUtil.Val( Ddo_conquistapontos_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42TFConquistaPontos), 4, 0)));
            AV43TFConquistaPontos_To = (short)(NumberUtil.Val( Ddo_conquistapontos_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFConquistaPontos_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFConquistaPontos_To), 4, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45ConquistaNomeTitleFilterData", AV45ConquistaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ConquistaPontosTitleFilterData", AV41ConquistaPontosTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28ColumnsSelector", AV28ColumnsSelector);
      }

      private void E19272( )
      {
         /* Grid_Load Routine */
         AV65Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV65Update);
         AV76Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "Modifica";
         edtavUpdate_Link = formatLink("conquista.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A27ConquistaId);
         edtConquistaPontos_Link = formatLink("conquista.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +A27ConquistaId);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 33;
         }
         sendrow_332( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_33_Refreshing )
         {
            context.DoAjaxLoad(33, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E15272( )
      {
         /* Ddo_gridcolumnsselector_Oncolumnschanged Routine */
         AV16ColumnsSelectorXML = Ddo_gridcolumnsselector_Columnsselectorvalues;
         AV28ColumnsSelector.FromJSonString(AV16ColumnsSelectorXML, null);
         AV36Session.Set("ConquistaWWColumnsSelector", AV28ColumnsSelector.ToXml(false, true, "WWPColumnsSelector", "SeriesColaborativas"));
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28ColumnsSelector", AV28ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45ConquistaNomeTitleFilterData", AV45ConquistaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ConquistaPontosTitleFilterData", AV41ConquistaPontosTitleFilterData);
      }

      protected void E16272( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("conquista.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_conquistanome_Sortedstatus = "";
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistanome_Internalname, "SortedStatus", Ddo_conquistanome_Sortedstatus);
         Ddo_conquistapontos_Sortedstatus = "";
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistapontos_Internalname, "SortedStatus", Ddo_conquistapontos_Sortedstatus);
      }

      protected void S132( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S162 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV13OrderedBy == 1 )
         {
            Ddo_conquistanome_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistanome_Internalname, "SortedStatus", Ddo_conquistanome_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_conquistapontos_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistapontos_Internalname, "SortedStatus", Ddo_conquistapontos_Sortedstatus);
         }
      }

      protected void S152( )
      {
         /* 'INITIALIZECOLUMNSSELECTOR' Routine */
         AV28ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         GXt_char2 = AV23UserCustomValue;
         new GeneXus.Programs.wwpbaseobjects.loadcolumnsselectorstate(context ).execute(  "ConquistaWWColumnsSelector", out  GXt_char2) ;
         AV23UserCustomValue = GXt_char2;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( AV23UserCustomValue)) ) )
         {
            AV28ColumnsSelector.FromXml(AV23UserCustomValue, null, "WWPColumnsSelector", "SeriesColaborativas");
            /* Execute user subroutine: 'UPDATECOLUMNS_COLUMNSSELECTOR' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         else
         {
            AV29VisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn(context);
            AV29VisibleColumn.gxTpr_Columnname = "Nome";
            AV28ColumnsSelector.gxTpr_Visiblecolumns.Add(AV29VisibleColumn, 0);
            AV29VisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn(context);
            AV29VisibleColumn.gxTpr_Columnname = "Pontos";
            AV28ColumnsSelector.gxTpr_Visiblecolumns.Add(AV29VisibleColumn, 0);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV36Session.Get(AV77Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV77Pgmname+"GridState"), null, "WWPGridState", "SeriesColaborativas");
         }
         else
         {
            AV11GridState.FromXml(AV36Session.Get(AV77Pgmname+"GridState"), null, "WWPGridState", "SeriesColaborativas");
         }
         AV13OrderedBy = AV11GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         AV14OrderedDsc = AV11GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV78GXV2 = 1;
         while ( AV78GXV2 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV78GXV2));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFCONQUISTANOME") == 0 )
            {
               AV46TFConquistaNome = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFConquistaNome", AV46TFConquistaNome);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46TFConquistaNome)) )
               {
                  Ddo_conquistanome_Filteredtext_set = AV46TFConquistaNome;
                  context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistanome_Internalname, "FilteredText_set", Ddo_conquistanome_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFCONQUISTANOME_SEL") == 0 )
            {
               AV47TFConquistaNome_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFConquistaNome_Sel", AV47TFConquistaNome_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47TFConquistaNome_Sel)) )
               {
                  Ddo_conquistanome_Selectedvalue_set = AV47TFConquistaNome_Sel;
                  context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistanome_Internalname, "SelectedValue_set", Ddo_conquistanome_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFCONQUISTAPONTOS") == 0 )
            {
               AV42TFConquistaPontos = (short)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42TFConquistaPontos), 4, 0)));
               AV43TFConquistaPontos_To = (short)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFConquistaPontos_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFConquistaPontos_To), 4, 0)));
               if ( ! (0==AV42TFConquistaPontos) )
               {
                  Ddo_conquistapontos_Filteredtext_set = StringUtil.Str( (decimal)(AV42TFConquistaPontos), 4, 0);
                  context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistapontos_Internalname, "FilteredText_set", Ddo_conquistapontos_Filteredtext_set);
               }
               if ( ! (0==AV43TFConquistaPontos_To) )
               {
                  Ddo_conquistapontos_Filteredtextto_set = StringUtil.Str( (decimal)(AV43TFConquistaPontos_To), 4, 0);
                  context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_conquistapontos_Internalname, "FilteredTextTo_set", Ddo_conquistapontos_Filteredtextto_set);
               }
            }
            AV78GXV2 = (int)(AV78GXV2+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV11GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV11GridState.gxTpr_Currentpage) ;
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV11GridState.FromXml(AV36Session.Get(AV77Pgmname+"GridState"), null, "WWPGridState", "SeriesColaborativas");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46TFConquistaNome)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFCONQUISTANOME";
            AV12GridStateFilterValue.gxTpr_Value = AV46TFConquistaNome;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47TFConquistaNome_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFCONQUISTANOME_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV47TFConquistaNome_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV42TFConquistaPontos) && (0==AV43TFConquistaPontos_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFCONQUISTAPONTOS";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV42TFConquistaPontos), 4, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV43TFConquistaPontos_To), 4, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV77Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "SeriesColaborativas")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV77Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "Conquista";
         AV36Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "SeriesColaborativas"));
      }

      protected void S172( )
      {
         /* 'UPDATECOLUMNS_COLUMNSSELECTOR' Routine */
         AV16ColumnsSelectorXML = AV28ColumnsSelector.gxTpr_Visiblecolumns.ToXml(false, true, "Collection", "SeriesColaborativas");
         AV35ColumnsSelectorXML2 = AV28ColumnsSelector.gxTpr_Invisiblecolumns.ToXml(false, true, "Collection", "SeriesColaborativas");
         AV28ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         if ( ! ( GxRegex.IsMatch(AV35ColumnsSelectorXML2,"<ColumnName>Nome</ColumnName") ) )
         {
            AV29VisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn(context);
            AV29VisibleColumn.gxTpr_Columnname = "Nome";
            AV28ColumnsSelector.gxTpr_Visiblecolumns.Add(AV29VisibleColumn, 0);
         }
         else
         {
            AV30InvisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_InvisibleColumn(context);
            AV30InvisibleColumn.gxTpr_Columnname = "Nome";
            AV28ColumnsSelector.gxTpr_Invisiblecolumns.Add(AV30InvisibleColumn, 0);
         }
         if ( ! ( GxRegex.IsMatch(AV35ColumnsSelectorXML2,"<ColumnName>Pontos</ColumnName") ) )
         {
            AV29VisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn(context);
            AV29VisibleColumn.gxTpr_Columnname = "Pontos";
            AV28ColumnsSelector.gxTpr_Visiblecolumns.Add(AV29VisibleColumn, 0);
         }
         else
         {
            AV30InvisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_InvisibleColumn(context);
            AV30InvisibleColumn.gxTpr_Columnname = "Pontos";
            AV28ColumnsSelector.gxTpr_Invisiblecolumns.Add(AV30InvisibleColumn, 0);
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
         PA272( ) ;
         WS272( ) ;
         WE272( ) ;
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
         AddStyleSheetFile("DVelop/DVPaginationBar/DVPaginationBar.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019462561", true);
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
         context.AddJavascriptSource("conquistaww.js", "?201892019462563", false);
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
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_332( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_33_idx;
         edtConquistaId_Internalname = "CONQUISTAID_"+sGXsfl_33_idx;
         edtConquistaNome_Internalname = "CONQUISTANOME_"+sGXsfl_33_idx;
         edtConquistaPontos_Internalname = "CONQUISTAPONTOS_"+sGXsfl_33_idx;
      }

      protected void SubsflControlProps_fel_332( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_33_fel_idx;
         edtConquistaId_Internalname = "CONQUISTAID_"+sGXsfl_33_fel_idx;
         edtConquistaNome_Internalname = "CONQUISTANOME_"+sGXsfl_33_fel_idx;
         edtConquistaPontos_Internalname = "CONQUISTAPONTOS_"+sGXsfl_33_fel_idx;
      }

      protected void sendrow_332( )
      {
         SubsflControlProps_332( ) ;
         WB270( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_33_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_33_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " class=\""+"GridWithPaginationBar GridWithBorderColor WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_33_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV65Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV65Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV76Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV65Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV65Update)) ? AV76Update_GXI : context.PathToRelativeUrl( AV65Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV65Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConquistaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ConquistaId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtConquistaId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)33,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtConquistaNome_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConquistaNome_Internalname,(String)A29ConquistaNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtConquistaNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtConquistaNome_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)33,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nome",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtConquistaPontos_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConquistaPontos_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A28ConquistaPontos), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A28ConquistaPontos), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtConquistaPontos_Link,(String)"",(String)"",(String)"",(String)edtConquistaPontos_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(int)edtConquistaPontos_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)33,(short)1,(short)-1,(short)0,(bool)true,(String)"Pontos",(String)"right",(bool)false});
            send_integrity_lvl_hashes272( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_33_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_33_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_33_idx+1));
            sGXsfl_33_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_33_idx), 4, 0)), 4, "0");
            SubsflControlProps_332( ) ;
         }
         /* End function sendrow_332 */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         bttBtneditcolumns_Internalname = "BTNEDITCOLUMNS";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavUpdate_Internalname = "vUPDATE";
         edtConquistaId_Internalname = "CONQUISTAID";
         edtConquistaNome_Internalname = "CONQUISTANOME";
         edtConquistaPontos_Internalname = "CONQUISTAPONTOS";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_conquistanome_Internalname = "DDO_CONQUISTANOME";
         edtavDdo_conquistanometitlecontrolidtoreplace_Internalname = "vDDO_CONQUISTANOMETITLECONTROLIDTOREPLACE";
         Ddo_conquistapontos_Internalname = "DDO_CONQUISTAPONTOS";
         edtavDdo_conquistapontostitlecontrolidtoreplace_Internalname = "vDDO_CONQUISTAPONTOSTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         Ddo_gridcolumnsselector_Internalname = "DDO_GRIDCOLUMNSSELECTOR";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfconquistanome_Internalname = "vTFCONQUISTANOME";
         edtavTfconquistanome_sel_Internalname = "vTFCONQUISTANOME_SEL";
         edtavTfconquistapontos_Internalname = "vTFCONQUISTAPONTOS";
         edtavTfconquistapontos_to_Internalname = "vTFCONQUISTAPONTOS_TO";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         subGrid_Internalname = "GRID";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtConquistaPontos_Jsonclick = "";
         edtConquistaNome_Jsonclick = "";
         edtConquistaId_Jsonclick = "";
         edtavTfconquistapontos_to_Jsonclick = "";
         edtavTfconquistapontos_to_Visible = 1;
         edtavTfconquistapontos_Jsonclick = "";
         edtavTfconquistapontos_Visible = 1;
         edtavTfconquistanome_sel_Jsonclick = "";
         edtavTfconquistanome_sel_Visible = 1;
         edtavTfconquistanome_Jsonclick = "";
         edtavTfconquistanome_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_conquistapontostitlecontrolidtoreplace_Visible = 1;
         edtavDdo_conquistanometitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtConquistaPontos_Link = "";
         edtavUpdate_Tooltiptext = "Modifica";
         edtavUpdate_Link = "";
         subGrid_Sortable = 0;
         edtConquistaPontos_Titleformat = 0;
         edtConquistaPontos_Title = "Pontos";
         edtConquistaPontos_Visible = -1;
         edtConquistaNome_Titleformat = 0;
         edtConquistaNome_Title = "Nome";
         edtConquistaNome_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_gridcolumnsselector_Updatebuttontext = "WWP_ColumnsSelectorButton";
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = "";
         Ddo_gridcolumnsselector_Dropdownoptionstype = "GridColumnsSelector";
         Ddo_gridcolumnsselector_Cls = "ColumnsSelector hidden-xs";
         Ddo_gridcolumnsselector_Tooltip = "WWP_EditColumnsTooltip";
         Ddo_gridcolumnsselector_Caption = "Seleciona colunas";
         Ddo_conquistapontos_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_conquistapontos_Rangefilterto = "WWP_TSTo";
         Ddo_conquistapontos_Rangefilterfrom = "WWP_TSFrom";
         Ddo_conquistapontos_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_conquistapontos_Sortdsc = "WWP_TSSortDSC";
         Ddo_conquistapontos_Sortasc = "WWP_TSSortASC";
         Ddo_conquistapontos_Includedatalist = Convert.ToBoolean( 0);
         Ddo_conquistapontos_Filterisrange = Convert.ToBoolean( -1);
         Ddo_conquistapontos_Filtertype = "Numeric";
         Ddo_conquistapontos_Includefilter = Convert.ToBoolean( -1);
         Ddo_conquistapontos_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_conquistapontos_Includesortasc = Convert.ToBoolean( -1);
         Ddo_conquistapontos_Titlecontrolidtoreplace = "";
         Ddo_conquistapontos_Dropdownoptionstype = "GridTitleSettings";
         Ddo_conquistapontos_Cls = "ColumnSettings";
         Ddo_conquistapontos_Tooltip = "WWP_TSColumnOptions";
         Ddo_conquistapontos_Caption = "";
         Ddo_conquistanome_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_conquistanome_Noresultsfound = "WWP_TSNoResults";
         Ddo_conquistanome_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_conquistanome_Loadingdata = "WWP_TSLoading";
         Ddo_conquistanome_Sortdsc = "WWP_TSSortDSC";
         Ddo_conquistanome_Sortasc = "WWP_TSSortASC";
         Ddo_conquistanome_Datalistupdateminimumcharacters = 0;
         Ddo_conquistanome_Datalistproc = "ConquistaWWGetFilterData";
         Ddo_conquistanome_Datalisttype = "Dynamic";
         Ddo_conquistanome_Includedatalist = Convert.ToBoolean( -1);
         Ddo_conquistanome_Filterisrange = Convert.ToBoolean( 0);
         Ddo_conquistanome_Filtertype = "Character";
         Ddo_conquistanome_Includefilter = Convert.ToBoolean( -1);
         Ddo_conquistanome_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_conquistanome_Includesortasc = Convert.ToBoolean( -1);
         Ddo_conquistanome_Titlecontrolidtoreplace = "";
         Ddo_conquistanome_Dropdownoptionstype = "GridTitleSettings";
         Ddo_conquistanome_Cls = "ColumnSettings";
         Ddo_conquistanome_Tooltip = "WWP_TSColumnOptions";
         Ddo_conquistanome_Caption = "";
         Gridpaginationbar_Rowsperpagecaption = "WWP_PagingRowsPerPage";
         Gridpaginationbar_Emptygridcaption = "WWP_PagingEmptyGridCaption";
         Gridpaginationbar_Rowsperpageoptions = "5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50";
         Gridpaginationbar_Rowsperpageselectedvalue = 10;
         Gridpaginationbar_Rowsperpageselector = Convert.ToBoolean( -1);
         Gridpaginationbar_Emptygridclass = "PaginationBarEmptyGrid";
         Gridpaginationbar_Pagingcaptionposition = "Left";
         Gridpaginationbar_Pagingbuttonsposition = "Right";
         Gridpaginationbar_Pagestoshow = 5;
         Gridpaginationbar_Showlast = Convert.ToBoolean( 0);
         Gridpaginationbar_Shownext = Convert.ToBoolean( -1);
         Gridpaginationbar_Showprevious = Convert.ToBoolean( -1);
         Gridpaginationbar_Showfirst = Convert.ToBoolean( 0);
         Gridpaginationbar_Caption = "Página <CURRENT_PAGE> de <TOTAL_PAGES>";
         Gridpaginationbar_Next = "WWP_PagingNextCaption";
         Gridpaginationbar_Previous = "WWP_PagingPreviousCaption";
         Gridpaginationbar_Class = "PaginationBar";
         Dvpanel_tableheader_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Iconposition = "left";
         Dvpanel_tableheader_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableheader_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_tableheader_Title = "Opções";
         Dvpanel_tableheader_Cls = "PanelNoHeader";
         Dvpanel_tableheader_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = " Conquista";
         subGrid_Rows = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV48ddo_ConquistaNomeTitleControlIdToReplace',fld:'vDDO_CONQUISTANOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV44ddo_ConquistaPontosTitleControlIdToReplace',fld:'vDDO_CONQUISTAPONTOSTITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV46TFConquistaNome',fld:'vTFCONQUISTANOME',pic:'',nv:''},{av:'AV47TFConquistaNome_Sel',fld:'vTFCONQUISTANOME_SEL',pic:'',nv:''},{av:'AV42TFConquistaPontos',fld:'vTFCONQUISTAPONTOS',pic:'ZZZ9',nv:0},{av:'AV43TFConquistaPontos_To',fld:'vTFCONQUISTAPONTOS_TO',pic:'ZZZ9',nv:0},{av:'AV77Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9',nv:0},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}],oparms:[{av:'AV45ConquistaNomeTitleFilterData',fld:'vCONQUISTANOMETITLEFILTERDATA',pic:'',nv:null},{av:'AV41ConquistaPontosTitleFilterData',fld:'vCONQUISTAPONTOSTITLEFILTERDATA',pic:'',nv:null},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'edtConquistaNome_Visible',ctrl:'CONQUISTANOME',prop:'Visible'},{av:'edtConquistaPontos_Visible',ctrl:'CONQUISTAPONTOS',prop:'Visible'},{av:'edtConquistaNome_Titleformat',ctrl:'CONQUISTANOME',prop:'Titleformat'},{av:'edtConquistaNome_Title',ctrl:'CONQUISTANOME',prop:'Title'},{av:'edtConquistaPontos_Titleformat',ctrl:'CONQUISTAPONTOS',prop:'Titleformat'},{av:'edtConquistaPontos_Title',ctrl:'CONQUISTAPONTOS',prop:'Title'},{av:'AV61GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV62GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11272',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9',nv:0},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV46TFConquistaNome',fld:'vTFCONQUISTANOME',pic:'',nv:''},{av:'AV47TFConquistaNome_Sel',fld:'vTFCONQUISTANOME_SEL',pic:'',nv:''},{av:'AV42TFConquistaPontos',fld:'vTFCONQUISTAPONTOS',pic:'ZZZ9',nv:0},{av:'AV43TFConquistaPontos_To',fld:'vTFCONQUISTAPONTOS_TO',pic:'ZZZ9',nv:0},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV48ddo_ConquistaNomeTitleControlIdToReplace',fld:'vDDO_CONQUISTANOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV44ddo_ConquistaPontosTitleControlIdToReplace',fld:'vDDO_CONQUISTAPONTOSTITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12272',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9',nv:0},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV46TFConquistaNome',fld:'vTFCONQUISTANOME',pic:'',nv:''},{av:'AV47TFConquistaNome_Sel',fld:'vTFCONQUISTANOME_SEL',pic:'',nv:''},{av:'AV42TFConquistaPontos',fld:'vTFCONQUISTAPONTOS',pic:'ZZZ9',nv:0},{av:'AV43TFConquistaPontos_To',fld:'vTFCONQUISTAPONTOS_TO',pic:'ZZZ9',nv:0},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV48ddo_ConquistaNomeTitleControlIdToReplace',fld:'vDDO_CONQUISTANOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV44ddo_ConquistaPontosTitleControlIdToReplace',fld:'vDDO_CONQUISTAPONTOSTITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_CONQUISTANOME.ONOPTIONCLICKED","{handler:'E13272',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9',nv:0},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV46TFConquistaNome',fld:'vTFCONQUISTANOME',pic:'',nv:''},{av:'AV47TFConquistaNome_Sel',fld:'vTFCONQUISTANOME_SEL',pic:'',nv:''},{av:'AV42TFConquistaPontos',fld:'vTFCONQUISTAPONTOS',pic:'ZZZ9',nv:0},{av:'AV43TFConquistaPontos_To',fld:'vTFCONQUISTAPONTOS_TO',pic:'ZZZ9',nv:0},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV48ddo_ConquistaNomeTitleControlIdToReplace',fld:'vDDO_CONQUISTANOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV44ddo_ConquistaPontosTitleControlIdToReplace',fld:'vDDO_CONQUISTAPONTOSTITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Ddo_conquistanome_Activeeventkey',ctrl:'DDO_CONQUISTANOME',prop:'ActiveEventKey'},{av:'Ddo_conquistanome_Filteredtext_get',ctrl:'DDO_CONQUISTANOME',prop:'FilteredText_get'},{av:'Ddo_conquistanome_Selectedvalue_get',ctrl:'DDO_CONQUISTANOME',prop:'SelectedValue_get'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}],oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9',nv:0},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'Ddo_conquistanome_Sortedstatus',ctrl:'DDO_CONQUISTANOME',prop:'SortedStatus'},{av:'AV46TFConquistaNome',fld:'vTFCONQUISTANOME',pic:'',nv:''},{av:'AV47TFConquistaNome_Sel',fld:'vTFCONQUISTANOME_SEL',pic:'',nv:''},{av:'Ddo_conquistapontos_Sortedstatus',ctrl:'DDO_CONQUISTAPONTOS',prop:'SortedStatus'},{av:'AV45ConquistaNomeTitleFilterData',fld:'vCONQUISTANOMETITLEFILTERDATA',pic:'',nv:null},{av:'AV41ConquistaPontosTitleFilterData',fld:'vCONQUISTAPONTOSTITLEFILTERDATA',pic:'',nv:null},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'edtConquistaNome_Visible',ctrl:'CONQUISTANOME',prop:'Visible'},{av:'edtConquistaPontos_Visible',ctrl:'CONQUISTAPONTOS',prop:'Visible'},{av:'edtConquistaNome_Titleformat',ctrl:'CONQUISTANOME',prop:'Titleformat'},{av:'edtConquistaNome_Title',ctrl:'CONQUISTANOME',prop:'Title'},{av:'edtConquistaPontos_Titleformat',ctrl:'CONQUISTAPONTOS',prop:'Titleformat'},{av:'edtConquistaPontos_Title',ctrl:'CONQUISTAPONTOS',prop:'Title'},{av:'AV61GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV62GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("DDO_CONQUISTAPONTOS.ONOPTIONCLICKED","{handler:'E14272',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9',nv:0},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV46TFConquistaNome',fld:'vTFCONQUISTANOME',pic:'',nv:''},{av:'AV47TFConquistaNome_Sel',fld:'vTFCONQUISTANOME_SEL',pic:'',nv:''},{av:'AV42TFConquistaPontos',fld:'vTFCONQUISTAPONTOS',pic:'ZZZ9',nv:0},{av:'AV43TFConquistaPontos_To',fld:'vTFCONQUISTAPONTOS_TO',pic:'ZZZ9',nv:0},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV48ddo_ConquistaNomeTitleControlIdToReplace',fld:'vDDO_CONQUISTANOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV44ddo_ConquistaPontosTitleControlIdToReplace',fld:'vDDO_CONQUISTAPONTOSTITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Ddo_conquistapontos_Activeeventkey',ctrl:'DDO_CONQUISTAPONTOS',prop:'ActiveEventKey'},{av:'Ddo_conquistapontos_Filteredtext_get',ctrl:'DDO_CONQUISTAPONTOS',prop:'FilteredText_get'},{av:'Ddo_conquistapontos_Filteredtextto_get',ctrl:'DDO_CONQUISTAPONTOS',prop:'FilteredTextTo_get'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}],oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9',nv:0},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'Ddo_conquistapontos_Sortedstatus',ctrl:'DDO_CONQUISTAPONTOS',prop:'SortedStatus'},{av:'AV42TFConquistaPontos',fld:'vTFCONQUISTAPONTOS',pic:'ZZZ9',nv:0},{av:'AV43TFConquistaPontos_To',fld:'vTFCONQUISTAPONTOS_TO',pic:'ZZZ9',nv:0},{av:'Ddo_conquistanome_Sortedstatus',ctrl:'DDO_CONQUISTANOME',prop:'SortedStatus'},{av:'AV45ConquistaNomeTitleFilterData',fld:'vCONQUISTANOMETITLEFILTERDATA',pic:'',nv:null},{av:'AV41ConquistaPontosTitleFilterData',fld:'vCONQUISTAPONTOSTITLEFILTERDATA',pic:'',nv:null},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'edtConquistaNome_Visible',ctrl:'CONQUISTANOME',prop:'Visible'},{av:'edtConquistaPontos_Visible',ctrl:'CONQUISTAPONTOS',prop:'Visible'},{av:'edtConquistaNome_Titleformat',ctrl:'CONQUISTANOME',prop:'Titleformat'},{av:'edtConquistaNome_Title',ctrl:'CONQUISTANOME',prop:'Title'},{av:'edtConquistaPontos_Titleformat',ctrl:'CONQUISTAPONTOS',prop:'Titleformat'},{av:'edtConquistaPontos_Title',ctrl:'CONQUISTAPONTOS',prop:'Title'},{av:'AV61GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV62GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID.LOAD","{handler:'E19272',iparms:[{av:'A27ConquistaId',fld:'CONQUISTAID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV65Update',fld:'vUPDATE',pic:'',nv:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'edtConquistaPontos_Link',ctrl:'CONQUISTAPONTOS',prop:'Link'}]}");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED","{handler:'E15272',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9',nv:0},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV46TFConquistaNome',fld:'vTFCONQUISTANOME',pic:'',nv:''},{av:'AV47TFConquistaNome_Sel',fld:'vTFCONQUISTANOME_SEL',pic:'',nv:''},{av:'AV42TFConquistaPontos',fld:'vTFCONQUISTAPONTOS',pic:'ZZZ9',nv:0},{av:'AV43TFConquistaPontos_To',fld:'vTFCONQUISTAPONTOS_TO',pic:'ZZZ9',nv:0},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV48ddo_ConquistaNomeTitleControlIdToReplace',fld:'vDDO_CONQUISTANOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV44ddo_ConquistaPontosTitleControlIdToReplace',fld:'vDDO_CONQUISTAPONTOSTITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Ddo_gridcolumnsselector_Columnsselectorvalues',ctrl:'DDO_GRIDCOLUMNSSELECTOR',prop:'ColumnsSelectorValues'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}],oparms:[{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV45ConquistaNomeTitleFilterData',fld:'vCONQUISTANOMETITLEFILTERDATA',pic:'',nv:null},{av:'AV41ConquistaPontosTitleFilterData',fld:'vCONQUISTAPONTOSTITLEFILTERDATA',pic:'',nv:null},{av:'edtConquistaNome_Visible',ctrl:'CONQUISTANOME',prop:'Visible'},{av:'edtConquistaPontos_Visible',ctrl:'CONQUISTAPONTOS',prop:'Visible'},{av:'edtConquistaNome_Titleformat',ctrl:'CONQUISTANOME',prop:'Titleformat'},{av:'edtConquistaNome_Title',ctrl:'CONQUISTANOME',prop:'Title'},{av:'edtConquistaPontos_Titleformat',ctrl:'CONQUISTAPONTOS',prop:'Titleformat'},{av:'edtConquistaPontos_Title',ctrl:'CONQUISTAPONTOS',prop:'Title'},{av:'AV61GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV62GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("'DOINSERT'","{handler:'E16272',iparms:[{av:'A27ConquistaId',fld:'CONQUISTAID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
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
         Gridpaginationbar_Selectedpage = "";
         Ddo_conquistanome_Activeeventkey = "";
         Ddo_conquistanome_Filteredtext_get = "";
         Ddo_conquistanome_Selectedvalue_get = "";
         Ddo_conquistapontos_Activeeventkey = "";
         Ddo_conquistapontos_Filteredtext_get = "";
         Ddo_conquistapontos_Filteredtextto_get = "";
         Ddo_gridcolumnsselector_Columnsselectorvalues = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV46TFConquistaNome = "";
         AV47TFConquistaNome_Sel = "";
         AV28ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV48ddo_ConquistaNomeTitleControlIdToReplace = "";
         AV44ddo_ConquistaPontosTitleControlIdToReplace = "";
         AV77Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV57DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV45ConquistaNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV41ConquistaPontosTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_conquistanome_Filteredtext_set = "";
         Ddo_conquistanome_Selectedvalue_set = "";
         Ddo_conquistanome_Sortedstatus = "";
         Ddo_conquistapontos_Filteredtext_set = "";
         Ddo_conquistapontos_Filteredtextto_set = "";
         Ddo_conquistapontos_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         bttBtneditcolumns_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV65Update = "";
         A29ConquistaNome = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV76Update_GXI = "";
         scmdbuf = "";
         lV72ConquistaWWDS_1_Tfconquistanome = "";
         AV73ConquistaWWDS_2_Tfconquistanome_sel = "";
         AV72ConquistaWWDS_1_Tfconquistanome = "";
         H00272_A28ConquistaPontos = new short[1] ;
         H00272_A29ConquistaNome = new String[] {""} ;
         H00272_A27ConquistaId = new long[1] ;
         H00273_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV36Session = context.GetSession();
         AV16ColumnsSelectorXML = "";
         AV29VisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn(context);
         GridRow = new GXWebRow();
         AV23UserCustomValue = "";
         GXt_char2 = "";
         AV11GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         AV35ColumnsSelectorXML2 = "";
         AV30InvisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_InvisibleColumn(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.conquistaww__default(),
            new Object[][] {
                new Object[] {
               H00272_A28ConquistaPontos, H00272_A29ConquistaNome, H00272_A27ConquistaId
               }
               , new Object[] {
               H00273_AGRID_nRecordCount
               }
            }
         );
         AV77Pgmname = "ConquistaWW";
         /* GeneXus formulas. */
         AV77Pgmname = "ConquistaWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_33 ;
      private short nGXsfl_33_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short AV42TFConquistaPontos ;
      private short AV43TFConquistaPontos_To ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtConquistaNome_Titleformat ;
      private short edtConquistaPontos_Titleformat ;
      private short subGrid_Sortable ;
      private short A28ConquistaPontos ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV74ConquistaWWDS_3_Tfconquistapontos ;
      private short AV75ConquistaWWDS_4_Tfconquistapontos_to ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_conquistanome_Datalistupdateminimumcharacters ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtConquistaNome_Visible ;
      private int edtConquistaPontos_Visible ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_conquistanometitlecontrolidtoreplace_Visible ;
      private int edtavDdo_conquistapontostitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfconquistanome_Visible ;
      private int edtavTfconquistanome_sel_Visible ;
      private int edtavTfconquistapontos_Visible ;
      private int edtavTfconquistapontos_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV71GXV1 ;
      private int AV60PageToGo ;
      private int AV78GXV2 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV61GridCurrentPage ;
      private long AV62GridPageCount ;
      private long A27ConquistaId ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_conquistanome_Activeeventkey ;
      private String Ddo_conquistanome_Filteredtext_get ;
      private String Ddo_conquistanome_Selectedvalue_get ;
      private String Ddo_conquistapontos_Activeeventkey ;
      private String Ddo_conquistapontos_Filteredtext_get ;
      private String Ddo_conquistapontos_Filteredtextto_get ;
      private String Ddo_gridcolumnsselector_Columnsselectorvalues ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_33_idx="0001" ;
      private String AV77Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_tableheader_Width ;
      private String Dvpanel_tableheader_Cls ;
      private String Dvpanel_tableheader_Title ;
      private String Dvpanel_tableheader_Iconposition ;
      private String Gridpaginationbar_Class ;
      private String Gridpaginationbar_Previous ;
      private String Gridpaginationbar_Next ;
      private String Gridpaginationbar_Caption ;
      private String Gridpaginationbar_Pagingbuttonsposition ;
      private String Gridpaginationbar_Pagingcaptionposition ;
      private String Gridpaginationbar_Emptygridclass ;
      private String Gridpaginationbar_Rowsperpageoptions ;
      private String Gridpaginationbar_Emptygridcaption ;
      private String Gridpaginationbar_Rowsperpagecaption ;
      private String Ddo_conquistanome_Caption ;
      private String Ddo_conquistanome_Tooltip ;
      private String Ddo_conquistanome_Cls ;
      private String Ddo_conquistanome_Filteredtext_set ;
      private String Ddo_conquistanome_Selectedvalue_set ;
      private String Ddo_conquistanome_Dropdownoptionstype ;
      private String Ddo_conquistanome_Titlecontrolidtoreplace ;
      private String Ddo_conquistanome_Sortedstatus ;
      private String Ddo_conquistanome_Filtertype ;
      private String Ddo_conquistanome_Datalisttype ;
      private String Ddo_conquistanome_Datalistproc ;
      private String Ddo_conquistanome_Sortasc ;
      private String Ddo_conquistanome_Sortdsc ;
      private String Ddo_conquistanome_Loadingdata ;
      private String Ddo_conquistanome_Cleanfilter ;
      private String Ddo_conquistanome_Noresultsfound ;
      private String Ddo_conquistanome_Searchbuttontext ;
      private String Ddo_conquistapontos_Caption ;
      private String Ddo_conquistapontos_Tooltip ;
      private String Ddo_conquistapontos_Cls ;
      private String Ddo_conquistapontos_Filteredtext_set ;
      private String Ddo_conquistapontos_Filteredtextto_set ;
      private String Ddo_conquistapontos_Dropdownoptionstype ;
      private String Ddo_conquistapontos_Titlecontrolidtoreplace ;
      private String Ddo_conquistapontos_Sortedstatus ;
      private String Ddo_conquistapontos_Filtertype ;
      private String Ddo_conquistapontos_Sortasc ;
      private String Ddo_conquistapontos_Sortdsc ;
      private String Ddo_conquistapontos_Cleanfilter ;
      private String Ddo_conquistapontos_Rangefilterfrom ;
      private String Ddo_conquistapontos_Rangefilterto ;
      private String Ddo_conquistapontos_Searchbuttontext ;
      private String Ddo_gridcolumnsselector_Caption ;
      private String Ddo_gridcolumnsselector_Tooltip ;
      private String Ddo_gridcolumnsselector_Cls ;
      private String Ddo_gridcolumnsselector_Dropdownoptionstype ;
      private String Ddo_gridcolumnsselector_Titlecontrolidtoreplace ;
      private String Ddo_gridcolumnsselector_Updatebuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divTableactions_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String bttBtneditcolumns_Internalname ;
      private String bttBtneditcolumns_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtConquistaNome_Title ;
      private String edtConquistaPontos_Title ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtConquistaPontos_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavDdo_conquistanometitlecontrolidtoreplace_Internalname ;
      private String edtavDdo_conquistapontostitlecontrolidtoreplace_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfconquistanome_Internalname ;
      private String edtavTfconquistanome_Jsonclick ;
      private String edtavTfconquistanome_sel_Internalname ;
      private String edtavTfconquistanome_sel_Jsonclick ;
      private String edtavTfconquistapontos_Internalname ;
      private String edtavTfconquistapontos_Jsonclick ;
      private String edtavTfconquistapontos_to_Internalname ;
      private String edtavTfconquistapontos_to_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUpdate_Internalname ;
      private String edtConquistaId_Internalname ;
      private String edtConquistaNome_Internalname ;
      private String edtConquistaPontos_Internalname ;
      private String scmdbuf ;
      private String Ddo_conquistanome_Internalname ;
      private String Ddo_conquistapontos_Internalname ;
      private String Ddo_gridcolumnsselector_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String GXt_char2 ;
      private String sGXsfl_33_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtConquistaId_Jsonclick ;
      private String edtConquistaNome_Jsonclick ;
      private String edtConquistaPontos_Jsonclick ;
      private String Dvpanel_tableheader_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableheader_Collapsible ;
      private bool Dvpanel_tableheader_Collapsed ;
      private bool Dvpanel_tableheader_Autowidth ;
      private bool Dvpanel_tableheader_Autoheight ;
      private bool Dvpanel_tableheader_Showcollapseicon ;
      private bool Dvpanel_tableheader_Autoscroll ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_conquistanome_Includesortasc ;
      private bool Ddo_conquistanome_Includesortdsc ;
      private bool Ddo_conquistanome_Includefilter ;
      private bool Ddo_conquistanome_Filterisrange ;
      private bool Ddo_conquistanome_Includedatalist ;
      private bool Ddo_conquistapontos_Includesortasc ;
      private bool Ddo_conquistapontos_Includesortdsc ;
      private bool Ddo_conquistapontos_Includefilter ;
      private bool Ddo_conquistapontos_Filterisrange ;
      private bool Ddo_conquistapontos_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_33_Refreshing=false ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV65Update_IsBlob ;
      private String AV16ColumnsSelectorXML ;
      private String AV23UserCustomValue ;
      private String AV35ColumnsSelectorXML2 ;
      private String AV46TFConquistaNome ;
      private String AV47TFConquistaNome_Sel ;
      private String AV48ddo_ConquistaNomeTitleControlIdToReplace ;
      private String AV44ddo_ConquistaPontosTitleControlIdToReplace ;
      private String A29ConquistaNome ;
      private String AV76Update_GXI ;
      private String lV72ConquistaWWDS_1_Tfconquistanome ;
      private String AV73ConquistaWWDS_2_Tfconquistanome_sel ;
      private String AV72ConquistaWWDS_1_Tfconquistanome ;
      private String AV65Update ;
      private IGxSession AV36Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H00272_A28ConquistaPontos ;
      private String[] H00272_A29ConquistaNome ;
      private long[] H00272_A27ConquistaId ;
      private long[] H00273_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV45ConquistaNomeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV41ConquistaPontosTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV28ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn AV29VisibleColumn ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_InvisibleColumn AV30InvisibleColumn ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV57DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class conquistaww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00272( IGxContext context ,
                                             String AV73ConquistaWWDS_2_Tfconquistanome_sel ,
                                             String AV72ConquistaWWDS_1_Tfconquistanome ,
                                             short AV74ConquistaWWDS_3_Tfconquistapontos ,
                                             short AV75ConquistaWWDS_4_Tfconquistapontos_to ,
                                             String A29ConquistaNome ,
                                             short A28ConquistaPontos ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [ConquistaPontos], [ConquistaNome], [ConquistaId]";
         sFromString = " FROM [Conquista] WITH (NOLOCK)";
         sOrderString = "";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV73ConquistaWWDS_2_Tfconquistanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72ConquistaWWDS_1_Tfconquistanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaNome] like @lV72ConquistaWWDS_1_Tfconquistanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaNome] like @lV72ConquistaWWDS_1_Tfconquistanome)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73ConquistaWWDS_2_Tfconquistanome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaNome] = @AV73ConquistaWWDS_2_Tfconquistanome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaNome] = @AV73ConquistaWWDS_2_Tfconquistanome_sel)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV74ConquistaWWDS_3_Tfconquistapontos) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaPontos] >= @AV74ConquistaWWDS_3_Tfconquistapontos)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaPontos] >= @AV74ConquistaWWDS_3_Tfconquistapontos)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV75ConquistaWWDS_4_Tfconquistapontos_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaPontos] <= @AV75ConquistaWWDS_4_Tfconquistapontos_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaPontos] <= @AV75ConquistaWWDS_4_Tfconquistapontos_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ConquistaNome]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ConquistaNome] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ConquistaPontos]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ConquistaPontos] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [ConquistaId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00273( IGxContext context ,
                                             String AV73ConquistaWWDS_2_Tfconquistanome_sel ,
                                             String AV72ConquistaWWDS_1_Tfconquistanome ,
                                             short AV74ConquistaWWDS_3_Tfconquistapontos ,
                                             short AV75ConquistaWWDS_4_Tfconquistapontos_to ,
                                             String A29ConquistaNome ,
                                             short A28ConquistaPontos ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [4] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Conquista] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV73ConquistaWWDS_2_Tfconquistanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72ConquistaWWDS_1_Tfconquistanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaNome] like @lV72ConquistaWWDS_1_Tfconquistanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaNome] like @lV72ConquistaWWDS_1_Tfconquistanome)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73ConquistaWWDS_2_Tfconquistanome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaNome] = @AV73ConquistaWWDS_2_Tfconquistanome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaNome] = @AV73ConquistaWWDS_2_Tfconquistanome_sel)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV74ConquistaWWDS_3_Tfconquistapontos) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaPontos] >= @AV74ConquistaWWDS_3_Tfconquistapontos)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaPontos] >= @AV74ConquistaWWDS_3_Tfconquistapontos)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV75ConquistaWWDS_4_Tfconquistapontos_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaPontos] <= @AV75ConquistaWWDS_4_Tfconquistapontos_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaPontos] <= @AV75ConquistaWWDS_4_Tfconquistapontos_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H00272(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (bool)dynConstraints[7] );
               case 1 :
                     return conditional_H00273(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (bool)dynConstraints[7] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00272 ;
          prmH00272 = new Object[] {
          new Object[] {"@lV72ConquistaWWDS_1_Tfconquistanome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV73ConquistaWWDS_2_Tfconquistanome_sel",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV74ConquistaWWDS_3_Tfconquistapontos",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV75ConquistaWWDS_4_Tfconquistapontos_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00273 ;
          prmH00273 = new Object[] {
          new Object[] {"@lV72ConquistaWWDS_1_Tfconquistanome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV73ConquistaWWDS_2_Tfconquistanome_sel",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV74ConquistaWWDS_3_Tfconquistapontos",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV75ConquistaWWDS_4_Tfconquistapontos_to",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00272", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00272,11,0,true,false )
             ,new CursorDef("H00273", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00273,1,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                return;
       }
    }

 }

}
