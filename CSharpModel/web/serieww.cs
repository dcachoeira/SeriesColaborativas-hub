/*
               File: SerieWW
        Description:  S�rie
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:43.17
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
   public class serieww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public serieww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public serieww( IGxContext context )
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
               AV14OrderedDsc = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV39TFSerieNome = GetNextPar( );
               AV40TFSerieNome_Sel = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV28ColumnsSelector);
               AV41ddo_SerieNomeTitleControlIdToReplace = GetNextPar( );
               AV65Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV14OrderedDsc, AV39TFSerieNome, AV40TFSerieNome_Sel, AV28ColumnsSelector, AV41ddo_SerieNomeTitleControlIdToReplace, AV65Pgmname) ;
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
         PA252( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START252( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2018925196440", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("serieww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFSERIENOME", AV39TFSerieNome);
         GxWebStd.gx_hidden_field( context, "GXH_vTFSERIENOME_SEL", AV40TFSerieNome_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_33", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_33), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV50GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV51GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV46DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV46DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSERIENOMETITLEFILTERDATA", AV38SerieNomeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSERIENOMETITLEFILTERDATA", AV38SerieNomeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vCOLUMNSSELECTOR", AV28ColumnsSelector);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vCOLUMNSSELECTOR", AV28ColumnsSelector);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV65Pgmname));
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
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Caption", StringUtil.RTrim( Ddo_serienome_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Tooltip", StringUtil.RTrim( Ddo_serienome_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Cls", StringUtil.RTrim( Ddo_serienome_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Filteredtext_set", StringUtil.RTrim( Ddo_serienome_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Selectedvalue_set", StringUtil.RTrim( Ddo_serienome_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Dropdownoptionstype", StringUtil.RTrim( Ddo_serienome_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_serienome_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Includesortasc", StringUtil.BoolToStr( Ddo_serienome_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Includesortdsc", StringUtil.BoolToStr( Ddo_serienome_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Sortedstatus", StringUtil.RTrim( Ddo_serienome_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Includefilter", StringUtil.BoolToStr( Ddo_serienome_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Filtertype", StringUtil.RTrim( Ddo_serienome_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Filterisrange", StringUtil.BoolToStr( Ddo_serienome_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Includedatalist", StringUtil.BoolToStr( Ddo_serienome_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Datalisttype", StringUtil.RTrim( Ddo_serienome_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Datalistproc", StringUtil.RTrim( Ddo_serienome_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_serienome_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Sortasc", StringUtil.RTrim( Ddo_serienome_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Sortdsc", StringUtil.RTrim( Ddo_serienome_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Loadingdata", StringUtil.RTrim( Ddo_serienome_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Cleanfilter", StringUtil.RTrim( Ddo_serienome_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Noresultsfound", StringUtil.RTrim( Ddo_serienome_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Searchbuttontext", StringUtil.RTrim( Ddo_serienome_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Caption", StringUtil.RTrim( Ddo_gridcolumnsselector_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Tooltip", StringUtil.RTrim( Ddo_gridcolumnsselector_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Cls", StringUtil.RTrim( Ddo_gridcolumnsselector_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_gridcolumnsselector_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_gridcolumnsselector_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Updatebuttontext", StringUtil.RTrim( Ddo_gridcolumnsselector_Updatebuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Activeeventkey", StringUtil.RTrim( Ddo_serienome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Filteredtext_get", StringUtil.RTrim( Ddo_serienome_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Selectedvalue_get", StringUtil.RTrim( Ddo_serienome_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues", StringUtil.RTrim( Ddo_gridcolumnsselector_Columnsselectorvalues));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Activeeventkey", StringUtil.RTrim( Ddo_serienome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Filteredtext_get", StringUtil.RTrim( Ddo_serienome_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_SERIENOME_Selectedvalue_get", StringUtil.RTrim( Ddo_serienome_Selectedvalue_get));
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
            WE252( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT252( ) ;
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
         return formatLink("serieww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "SerieWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " S�rie" ;
      }

      protected void WB250( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(33), 2, 0)+","+"null"+");", "Inserir", bttBtninsert_Jsonclick, 5, "Inserir", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_SerieWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            ClassString = "hidden-xs";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtneditcolumns_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(33), 2, 0)+","+"null"+");", "Seleciona colunas", bttBtneditcolumns_Jsonclick, 5, "Seleciona colunas", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'EDITCOLUMNS\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_SerieWW.htm");
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtSerieNome_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtSerieNome_Titleformat == 0 )
               {
                  context.SendWebValue( edtSerieNome_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtSerieNome_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Quantidade de temporadas") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV52Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A2SerieNome);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtSerieNome_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSerieNome_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtSerieNome_Link));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSerieNome_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3SerieQuantidadeTemporadas), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV57Episodios));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavEpisodios_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavEpisodios_Link));
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
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DDO_SERIENOMEContainer"+"\"></div>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_33_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_serienometitlecontrolidtoreplace_Internalname, AV41ddo_SerieNomeTitleControlIdToReplace, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_serienometitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SerieWW.htm");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"WORKWITHPLUSUTILITIES1Container"+"\"></div>") ;
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DDO_GRIDCOLUMNSSELECTORContainer"+"\"></div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_33_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_SerieWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_33_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfserienome_Internalname, AV39TFSerieNome, StringUtil.RTrim( context.localUtil.Format( AV39TFSerieNome, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfserienome_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfserienome_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SerieWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_33_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfserienome_sel_Internalname, AV40TFSerieNome_Sel, StringUtil.RTrim( context.localUtil.Format( AV40TFSerieNome_Sel, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfserienome_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfserienome_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SerieWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START252( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", " S�rie", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP250( ) ;
      }

      protected void WS252( )
      {
         START252( ) ;
         EVT252( ) ;
      }

      protected void EVT252( )
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
                              E11252 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12252 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SERIENOME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13252 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14252 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E15252 ();
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
                              AV52Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV52Update)) ? AV64Update_GXI : context.convertURL( context.PathToRelativeUrl( AV52Update))), !bGXsfl_33_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV52Update), true);
                              A1SerieId = (long)(context.localUtil.CToN( cgiGet( edtSerieId_Internalname), ",", "."));
                              A2SerieNome = cgiGet( edtSerieNome_Internalname);
                              A3SerieQuantidadeTemporadas = (short)(context.localUtil.CToN( cgiGet( edtSerieQuantidadeTemporadas_Internalname), ",", "."));
                              AV57Episodios = cgiGet( edtavEpisodios_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavEpisodios_Internalname, AV57Episodios);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E16252 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E17252 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E18252 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfserienome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSERIENOME"), AV39TFSerieNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfserienome_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSERIENOME_SEL"), AV40TFSerieNome_Sel) != 0 )
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

      protected void WE252( )
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

      protected void PA252( )
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
               GX_FocusControl = edtavDdo_serienometitlecontrolidtoreplace_Internalname;
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
                                       bool AV14OrderedDsc ,
                                       String AV39TFSerieNome ,
                                       String AV40TFSerieNome_Sel ,
                                       GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV28ColumnsSelector ,
                                       String AV41ddo_SerieNomeTitleControlIdToReplace ,
                                       String AV65Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF252( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SERIEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ".", "")));
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
         RF252( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV65Pgmname = "SerieWW";
         context.Gx_err = 0;
         edtavEpisodios_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEpisodios_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEpisodios_Enabled), 5, 0)), !bGXsfl_33_Refreshing);
      }

      protected void RF252( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 33;
         /* Execute user event: Refresh */
         E17252 ();
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
                                                 AV63SerieWWDS_2_Tfserienome_sel ,
                                                 AV62SerieWWDS_1_Tfserienome ,
                                                 A2SerieNome ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV62SerieWWDS_1_Tfserienome = StringUtil.Concat( StringUtil.RTrim( AV62SerieWWDS_1_Tfserienome), "%", "");
            /* Using cursor H00252 */
            pr_default.execute(0, new Object[] {lV62SerieWWDS_1_Tfserienome, AV63SerieWWDS_2_Tfserienome_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_33_idx = 1;
            sGXsfl_33_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_33_idx), 4, 0)), 4, "0");
            SubsflControlProps_332( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A3SerieQuantidadeTemporadas = H00252_A3SerieQuantidadeTemporadas[0];
               A2SerieNome = H00252_A2SerieNome[0];
               A1SerieId = H00252_A1SerieId[0];
               E18252 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 33;
            WB250( ) ;
         }
         bGXsfl_33_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes252( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SERIEID"+"_"+sGXsfl_33_idx, GetSecureSignedToken( sGXsfl_33_idx, context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9"), context));
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
         AV62SerieWWDS_1_Tfserienome = AV39TFSerieNome;
         AV63SerieWWDS_2_Tfserienome_sel = AV40TFSerieNome_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV63SerieWWDS_2_Tfserienome_sel ,
                                              AV62SerieWWDS_1_Tfserienome ,
                                              A2SerieNome ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV62SerieWWDS_1_Tfserienome = StringUtil.Concat( StringUtil.RTrim( AV62SerieWWDS_1_Tfserienome), "%", "");
         /* Using cursor H00253 */
         pr_default.execute(1, new Object[] {lV62SerieWWDS_1_Tfserienome, AV63SerieWWDS_2_Tfserienome_sel});
         GRID_nRecordCount = H00253_AGRID_nRecordCount[0];
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
         AV62SerieWWDS_1_Tfserienome = AV39TFSerieNome;
         AV63SerieWWDS_2_Tfserienome_sel = AV40TFSerieNome_Sel;
         GRID_nFirstRecordOnPage = 0;
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedDsc, AV39TFSerieNome, AV40TFSerieNome_Sel, AV28ColumnsSelector, AV41ddo_SerieNomeTitleControlIdToReplace, AV65Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV62SerieWWDS_1_Tfserienome = AV39TFSerieNome;
         AV63SerieWWDS_2_Tfserienome_sel = AV40TFSerieNome_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedDsc, AV39TFSerieNome, AV40TFSerieNome_Sel, AV28ColumnsSelector, AV41ddo_SerieNomeTitleControlIdToReplace, AV65Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV62SerieWWDS_1_Tfserienome = AV39TFSerieNome;
         AV63SerieWWDS_2_Tfserienome_sel = AV40TFSerieNome_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedDsc, AV39TFSerieNome, AV40TFSerieNome_Sel, AV28ColumnsSelector, AV41ddo_SerieNomeTitleControlIdToReplace, AV65Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV62SerieWWDS_1_Tfserienome = AV39TFSerieNome;
         AV63SerieWWDS_2_Tfserienome_sel = AV40TFSerieNome_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedDsc, AV39TFSerieNome, AV40TFSerieNome_Sel, AV28ColumnsSelector, AV41ddo_SerieNomeTitleControlIdToReplace, AV65Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV62SerieWWDS_1_Tfserienome = AV39TFSerieNome;
         AV63SerieWWDS_2_Tfserienome_sel = AV40TFSerieNome_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedDsc, AV39TFSerieNome, AV40TFSerieNome_Sel, AV28ColumnsSelector, AV41ddo_SerieNomeTitleControlIdToReplace, AV65Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP250( )
      {
         /* Before Start, stand alone formulas. */
         AV65Pgmname = "SerieWW";
         context.Gx_err = 0;
         edtavEpisodios_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEpisodios_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEpisodios_Enabled), 5, 0)), !bGXsfl_33_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E16252 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV46DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vSERIENOMETITLEFILTERDATA"), AV38SerieNomeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vCOLUMNSSELECTOR"), AV28ColumnsSelector);
            /* Read variables values. */
            AV41ddo_SerieNomeTitleControlIdToReplace = cgiGet( edtavDdo_serienometitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_SerieNomeTitleControlIdToReplace", AV41ddo_SerieNomeTitleControlIdToReplace);
            AV14OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            AV39TFSerieNome = cgiGet( edtavTfserienome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFSerieNome", AV39TFSerieNome);
            AV40TFSerieNome_Sel = cgiGet( edtavTfserienome_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40TFSerieNome_Sel", AV40TFSerieNome_Sel);
            /* Read saved values. */
            nRC_GXsfl_33 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_33"), ",", "."));
            AV50GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV51GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
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
            Ddo_serienome_Caption = cgiGet( "DDO_SERIENOME_Caption");
            Ddo_serienome_Tooltip = cgiGet( "DDO_SERIENOME_Tooltip");
            Ddo_serienome_Cls = cgiGet( "DDO_SERIENOME_Cls");
            Ddo_serienome_Filteredtext_set = cgiGet( "DDO_SERIENOME_Filteredtext_set");
            Ddo_serienome_Selectedvalue_set = cgiGet( "DDO_SERIENOME_Selectedvalue_set");
            Ddo_serienome_Dropdownoptionstype = cgiGet( "DDO_SERIENOME_Dropdownoptionstype");
            Ddo_serienome_Titlecontrolidtoreplace = cgiGet( "DDO_SERIENOME_Titlecontrolidtoreplace");
            Ddo_serienome_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_SERIENOME_Includesortasc"));
            Ddo_serienome_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_SERIENOME_Includesortdsc"));
            Ddo_serienome_Sortedstatus = cgiGet( "DDO_SERIENOME_Sortedstatus");
            Ddo_serienome_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_SERIENOME_Includefilter"));
            Ddo_serienome_Filtertype = cgiGet( "DDO_SERIENOME_Filtertype");
            Ddo_serienome_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_SERIENOME_Filterisrange"));
            Ddo_serienome_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_SERIENOME_Includedatalist"));
            Ddo_serienome_Datalisttype = cgiGet( "DDO_SERIENOME_Datalisttype");
            Ddo_serienome_Datalistproc = cgiGet( "DDO_SERIENOME_Datalistproc");
            Ddo_serienome_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_SERIENOME_Datalistupdateminimumcharacters"), ",", "."));
            Ddo_serienome_Sortasc = cgiGet( "DDO_SERIENOME_Sortasc");
            Ddo_serienome_Sortdsc = cgiGet( "DDO_SERIENOME_Sortdsc");
            Ddo_serienome_Loadingdata = cgiGet( "DDO_SERIENOME_Loadingdata");
            Ddo_serienome_Cleanfilter = cgiGet( "DDO_SERIENOME_Cleanfilter");
            Ddo_serienome_Noresultsfound = cgiGet( "DDO_SERIENOME_Noresultsfound");
            Ddo_serienome_Searchbuttontext = cgiGet( "DDO_SERIENOME_Searchbuttontext");
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
            Ddo_serienome_Activeeventkey = cgiGet( "DDO_SERIENOME_Activeeventkey");
            Ddo_serienome_Filteredtext_get = cgiGet( "DDO_SERIENOME_Filteredtext_get");
            Ddo_serienome_Selectedvalue_get = cgiGet( "DDO_SERIENOME_Selectedvalue_get");
            Ddo_gridcolumnsselector_Columnsselectorvalues = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSERIENOME"), AV39TFSerieNome) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSERIENOME_SEL"), AV40TFSerieNome_Sel) != 0 )
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
         E16252 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E16252( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfserienome_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfserienome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfserienome_Visible), 5, 0)), true);
         edtavTfserienome_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfserienome_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfserienome_sel_Visible), 5, 0)), true);
         Ddo_serienome_Titlecontrolidtoreplace = subGrid_Internalname+"_SerieNome";
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_serienome_Internalname, "TitleControlIdToReplace", Ddo_serienome_Titlecontrolidtoreplace);
         AV41ddo_SerieNomeTitleControlIdToReplace = Ddo_serienome_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_SerieNomeTitleControlIdToReplace", AV41ddo_SerieNomeTitleControlIdToReplace);
         edtavDdo_serienometitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_serienometitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_serienometitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " S�rie";
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
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV46DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV46DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = bttBtneditcolumns_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_gridcolumnsselector_Internalname, "TitleControlIdToReplace", Ddo_gridcolumnsselector_Titlecontrolidtoreplace);
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E17252( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV38SerieNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( StringUtil.StrCmp(AV37Session.Get("SerieWWColumnsSelector"), "") != 0 )
         {
            AV16ColumnsSelectorXML = AV37Session.Get("SerieWWColumnsSelector");
            AV28ColumnsSelector.FromXml(AV16ColumnsSelectorXML, null, "WWPColumnsSelector", "SeriesColaborativas");
         }
         else
         {
            /* Execute user subroutine: 'INITIALIZECOLUMNSSELECTOR' */
            S142 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtSerieNome_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieNome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieNome_Visible), 5, 0)), !bGXsfl_33_Refreshing);
         AV61GXV1 = 1;
         while ( AV61GXV1 <= AV28ColumnsSelector.gxTpr_Visiblecolumns.Count )
         {
            AV29VisibleColumn = ((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn)AV28ColumnsSelector.gxTpr_Visiblecolumns.Item(AV61GXV1));
            if ( StringUtil.StrCmp(AV29VisibleColumn.gxTpr_Columnname, "Nome") == 0 )
            {
               edtSerieNome_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieNome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieNome_Visible), 5, 0)), !bGXsfl_33_Refreshing);
            }
            AV61GXV1 = (int)(AV61GXV1+1);
         }
         edtSerieNome_Titleformat = 2;
         edtSerieNome_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Nome", AV41ddo_SerieNomeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieNome_Internalname, "Title", edtSerieNome_Title, !bGXsfl_33_Refreshing);
         AV50GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV50GridCurrentPage), 10, 0)));
         AV51GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV51GridPageCount), 10, 0)));
         AV62SerieWWDS_1_Tfserienome = AV39TFSerieNome;
         AV63SerieWWDS_2_Tfserienome_sel = AV40TFSerieNome_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38SerieNomeTitleFilterData", AV38SerieNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28ColumnsSelector", AV28ColumnsSelector);
      }

      protected void E11252( )
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
            AV49PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV49PageToGo) ;
         }
      }

      protected void E12252( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13252( )
      {
         /* Ddo_serienome_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_serienome_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_serienome_Sortedstatus = "ASC";
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_serienome_Internalname, "SortedStatus", Ddo_serienome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_serienome_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_serienome_Sortedstatus = "DSC";
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_serienome_Internalname, "SortedStatus", Ddo_serienome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_serienome_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV39TFSerieNome = Ddo_serienome_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFSerieNome", AV39TFSerieNome);
            AV40TFSerieNome_Sel = Ddo_serienome_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40TFSerieNome_Sel", AV40TFSerieNome_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38SerieNomeTitleFilterData", AV38SerieNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28ColumnsSelector", AV28ColumnsSelector);
      }

      private void E18252( )
      {
         /* Grid_Load Routine */
         AV52Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV52Update);
         AV64Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "Modifica";
         edtavUpdate_Link = formatLink("serie.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A1SerieId);
         AV57Episodios = "Epis�dios";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavEpisodios_Internalname, AV57Episodios);
         edtavEpisodios_Link = formatLink("cadastrotemporadas.aspx") + "?" + UrlEncode("" +A1SerieId);
         edtSerieNome_Link = formatLink("serie.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +A1SerieId);
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

      protected void E14252( )
      {
         /* Ddo_gridcolumnsselector_Oncolumnschanged Routine */
         AV16ColumnsSelectorXML = Ddo_gridcolumnsselector_Columnsselectorvalues;
         AV28ColumnsSelector.FromJSonString(AV16ColumnsSelectorXML, null);
         AV37Session.Set("SerieWWColumnsSelector", AV28ColumnsSelector.ToXml(false, true, "WWPColumnsSelector", "SeriesColaborativas"));
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28ColumnsSelector", AV28ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38SerieNomeTitleFilterData", AV38SerieNomeTitleFilterData);
      }

      protected void E15252( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("serie.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S152( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         Ddo_serienome_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_serienome_Internalname, "SortedStatus", Ddo_serienome_Sortedstatus);
      }

      protected void S142( )
      {
         /* 'INITIALIZECOLUMNSSELECTOR' Routine */
         AV28ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         GXt_char2 = AV23UserCustomValue;
         new GeneXus.Programs.wwpbaseobjects.loadcolumnsselectorstate(context ).execute(  "SerieWWColumnsSelector", out  GXt_char2) ;
         AV23UserCustomValue = GXt_char2;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( AV23UserCustomValue)) ) )
         {
            AV28ColumnsSelector.FromXml(AV23UserCustomValue, null, "WWPColumnsSelector", "SeriesColaborativas");
            /* Execute user subroutine: 'UPDATECOLUMNS_COLUMNSSELECTOR' */
            S162 ();
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
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV37Session.Get(AV65Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV65Pgmname+"GridState"), null, "WWPGridState", "SeriesColaborativas");
         }
         else
         {
            AV11GridState.FromXml(AV37Session.Get(AV65Pgmname+"GridState"), null, "WWPGridState", "SeriesColaborativas");
         }
         AV14OrderedDsc = AV11GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV66GXV2 = 1;
         while ( AV66GXV2 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV66GXV2));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFSERIENOME") == 0 )
            {
               AV39TFSerieNome = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFSerieNome", AV39TFSerieNome);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV39TFSerieNome)) )
               {
                  Ddo_serienome_Filteredtext_set = AV39TFSerieNome;
                  context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_serienome_Internalname, "FilteredText_set", Ddo_serienome_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFSERIENOME_SEL") == 0 )
            {
               AV40TFSerieNome_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40TFSerieNome_Sel", AV40TFSerieNome_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV40TFSerieNome_Sel)) )
               {
                  Ddo_serienome_Selectedvalue_set = AV40TFSerieNome_Sel;
                  context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_serienome_Internalname, "SelectedValue_set", Ddo_serienome_Selectedvalue_set);
               }
            }
            AV66GXV2 = (int)(AV66GXV2+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV11GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV11GridState.gxTpr_Currentpage) ;
      }

      protected void S132( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV11GridState.FromXml(AV37Session.Get(AV65Pgmname+"GridState"), null, "WWPGridState", "SeriesColaborativas");
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV39TFSerieNome)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFSERIENOME";
            AV12GridStateFilterValue.gxTpr_Value = AV39TFSerieNome;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV40TFSerieNome_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFSERIENOME_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV40TFSerieNome_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV65Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "SeriesColaborativas")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV65Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "Serie";
         AV37Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "SeriesColaborativas"));
      }

      protected void S162( )
      {
         /* 'UPDATECOLUMNS_COLUMNSSELECTOR' Routine */
         AV16ColumnsSelectorXML = AV28ColumnsSelector.gxTpr_Visiblecolumns.ToXml(false, true, "Collection", "SeriesColaborativas");
         AV36ColumnsSelectorXML2 = AV28ColumnsSelector.gxTpr_Invisiblecolumns.ToXml(false, true, "Collection", "SeriesColaborativas");
         AV28ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         if ( ! ( GxRegex.IsMatch(AV36ColumnsSelectorXML2,"<ColumnName>Nome</ColumnName") ) )
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
         PA252( ) ;
         WS252( ) ;
         WE252( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20189251965298", true);
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
         context.AddJavascriptSource("serieww.js", "?2018925196530", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_332( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_33_idx;
         edtSerieId_Internalname = "SERIEID_"+sGXsfl_33_idx;
         edtSerieNome_Internalname = "SERIENOME_"+sGXsfl_33_idx;
         edtSerieQuantidadeTemporadas_Internalname = "SERIEQUANTIDADETEMPORADAS_"+sGXsfl_33_idx;
         edtavEpisodios_Internalname = "vEPISODIOS_"+sGXsfl_33_idx;
      }

      protected void SubsflControlProps_fel_332( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_33_fel_idx;
         edtSerieId_Internalname = "SERIEID_"+sGXsfl_33_fel_idx;
         edtSerieNome_Internalname = "SERIENOME_"+sGXsfl_33_fel_idx;
         edtSerieQuantidadeTemporadas_Internalname = "SERIEQUANTIDADETEMPORADAS_"+sGXsfl_33_fel_idx;
         edtavEpisodios_Internalname = "vEPISODIOS_"+sGXsfl_33_fel_idx;
      }

      protected void sendrow_332( )
      {
         SubsflControlProps_332( ) ;
         WB250( ) ;
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
            AV52Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV52Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV64Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV52Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV52Update)) ? AV64Update_GXI : context.PathToRelativeUrl( AV52Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV52Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSerieId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSerieId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)33,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtSerieNome_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSerieNome_Internalname,(String)A2SerieNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtSerieNome_Link,(String)"",(String)"",(String)"",(String)edtSerieNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(int)edtSerieNome_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)33,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nome",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSerieQuantidadeTemporadas_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3SerieQuantidadeTemporadas), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A3SerieQuantidadeTemporadas), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSerieQuantidadeTemporadas_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)33,(short)1,(short)-1,(short)0,(bool)true,(String)"Quantidade",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavEpisodios_Internalname,StringUtil.RTrim( AV57Episodios),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavEpisodios_Link,(String)"",(String)"",(String)"",(String)edtavEpisodios_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWActionColumn",(String)"",(short)-1,(int)edtavEpisodios_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)33,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes252( ) ;
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
         edtSerieId_Internalname = "SERIEID";
         edtSerieNome_Internalname = "SERIENOME";
         edtSerieQuantidadeTemporadas_Internalname = "SERIEQUANTIDADETEMPORADAS";
         edtavEpisodios_Internalname = "vEPISODIOS";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_serienome_Internalname = "DDO_SERIENOME";
         edtavDdo_serienometitlecontrolidtoreplace_Internalname = "vDDO_SERIENOMETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         Ddo_gridcolumnsselector_Internalname = "DDO_GRIDCOLUMNSSELECTOR";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfserienome_Internalname = "vTFSERIENOME";
         edtavTfserienome_sel_Internalname = "vTFSERIENOME_SEL";
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
         edtavEpisodios_Jsonclick = "";
         edtSerieQuantidadeTemporadas_Jsonclick = "";
         edtSerieNome_Jsonclick = "";
         edtSerieId_Jsonclick = "";
         edtavTfserienome_sel_Jsonclick = "";
         edtavTfserienome_sel_Visible = 1;
         edtavTfserienome_Jsonclick = "";
         edtavTfserienome_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavDdo_serienometitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavEpisodios_Link = "";
         edtSerieNome_Link = "";
         edtavUpdate_Tooltiptext = "Modifica";
         edtavUpdate_Link = "";
         subGrid_Sortable = 0;
         edtavEpisodios_Enabled = 0;
         edtSerieNome_Titleformat = 0;
         edtSerieNome_Title = "Nome";
         edtSerieNome_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_gridcolumnsselector_Updatebuttontext = "WWP_ColumnsSelectorButton";
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = "";
         Ddo_gridcolumnsselector_Dropdownoptionstype = "GridColumnsSelector";
         Ddo_gridcolumnsselector_Cls = "ColumnsSelector hidden-xs";
         Ddo_gridcolumnsselector_Tooltip = "WWP_EditColumnsTooltip";
         Ddo_gridcolumnsselector_Caption = "Seleciona colunas";
         Ddo_serienome_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_serienome_Noresultsfound = "WWP_TSNoResults";
         Ddo_serienome_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_serienome_Loadingdata = "WWP_TSLoading";
         Ddo_serienome_Sortdsc = "WWP_TSSortDSC";
         Ddo_serienome_Sortasc = "WWP_TSSortASC";
         Ddo_serienome_Datalistupdateminimumcharacters = 0;
         Ddo_serienome_Datalistproc = "SerieWWGetFilterData";
         Ddo_serienome_Datalisttype = "Dynamic";
         Ddo_serienome_Includedatalist = Convert.ToBoolean( -1);
         Ddo_serienome_Filterisrange = Convert.ToBoolean( 0);
         Ddo_serienome_Filtertype = "Character";
         Ddo_serienome_Includefilter = Convert.ToBoolean( -1);
         Ddo_serienome_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_serienome_Includesortasc = Convert.ToBoolean( -1);
         Ddo_serienome_Titlecontrolidtoreplace = "";
         Ddo_serienome_Dropdownoptionstype = "GridTitleSettings";
         Ddo_serienome_Cls = "ColumnSettings";
         Ddo_serienome_Tooltip = "WWP_TSColumnOptions";
         Ddo_serienome_Caption = "";
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
         Gridpaginationbar_Caption = "P�gina <CURRENT_PAGE> de <TOTAL_PAGES>";
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
         Dvpanel_tableheader_Title = "Op��es";
         Dvpanel_tableheader_Cls = "PanelNoHeader";
         Dvpanel_tableheader_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = " S�rie";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV41ddo_SerieNomeTitleControlIdToReplace',fld:'vDDO_SERIENOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV39TFSerieNome',fld:'vTFSERIENOME',pic:'',nv:''},{av:'AV40TFSerieNome_Sel',fld:'vTFSERIENOME_SEL',pic:'',nv:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}],oparms:[{av:'AV38SerieNomeTitleFilterData',fld:'vSERIENOMETITLEFILTERDATA',pic:'',nv:null},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'edtSerieNome_Visible',ctrl:'SERIENOME',prop:'Visible'},{av:'edtSerieNome_Titleformat',ctrl:'SERIENOME',prop:'Titleformat'},{av:'edtSerieNome_Title',ctrl:'SERIENOME',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV51GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11252',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV39TFSerieNome',fld:'vTFSERIENOME',pic:'',nv:''},{av:'AV40TFSerieNome_Sel',fld:'vTFSERIENOME_SEL',pic:'',nv:''},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV41ddo_SerieNomeTitleControlIdToReplace',fld:'vDDO_SERIENOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12252',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV39TFSerieNome',fld:'vTFSERIENOME',pic:'',nv:''},{av:'AV40TFSerieNome_Sel',fld:'vTFSERIENOME_SEL',pic:'',nv:''},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV41ddo_SerieNomeTitleControlIdToReplace',fld:'vDDO_SERIENOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_SERIENOME.ONOPTIONCLICKED","{handler:'E13252',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV39TFSerieNome',fld:'vTFSERIENOME',pic:'',nv:''},{av:'AV40TFSerieNome_Sel',fld:'vTFSERIENOME_SEL',pic:'',nv:''},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV41ddo_SerieNomeTitleControlIdToReplace',fld:'vDDO_SERIENOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Ddo_serienome_Activeeventkey',ctrl:'DDO_SERIENOME',prop:'ActiveEventKey'},{av:'Ddo_serienome_Filteredtext_get',ctrl:'DDO_SERIENOME',prop:'FilteredText_get'},{av:'Ddo_serienome_Selectedvalue_get',ctrl:'DDO_SERIENOME',prop:'SelectedValue_get'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}],oparms:[{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'Ddo_serienome_Sortedstatus',ctrl:'DDO_SERIENOME',prop:'SortedStatus'},{av:'AV39TFSerieNome',fld:'vTFSERIENOME',pic:'',nv:''},{av:'AV40TFSerieNome_Sel',fld:'vTFSERIENOME_SEL',pic:'',nv:''},{av:'AV38SerieNomeTitleFilterData',fld:'vSERIENOMETITLEFILTERDATA',pic:'',nv:null},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'edtSerieNome_Visible',ctrl:'SERIENOME',prop:'Visible'},{av:'edtSerieNome_Titleformat',ctrl:'SERIENOME',prop:'Titleformat'},{av:'edtSerieNome_Title',ctrl:'SERIENOME',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV51GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID.LOAD","{handler:'E18252',iparms:[{av:'A1SerieId',fld:'SERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV52Update',fld:'vUPDATE',pic:'',nv:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV57Episodios',fld:'vEPISODIOS',pic:'',nv:''},{av:'edtavEpisodios_Link',ctrl:'vEPISODIOS',prop:'Link'},{av:'edtSerieNome_Link',ctrl:'SERIENOME',prop:'Link'}]}");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED","{handler:'E14252',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV39TFSerieNome',fld:'vTFSERIENOME',pic:'',nv:''},{av:'AV40TFSerieNome_Sel',fld:'vTFSERIENOME_SEL',pic:'',nv:''},{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV41ddo_SerieNomeTitleControlIdToReplace',fld:'vDDO_SERIENOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Ddo_gridcolumnsselector_Columnsselectorvalues',ctrl:'DDO_GRIDCOLUMNSSELECTOR',prop:'ColumnsSelectorValues'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}],oparms:[{av:'AV28ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV38SerieNomeTitleFilterData',fld:'vSERIENOMETITLEFILTERDATA',pic:'',nv:null},{av:'edtSerieNome_Visible',ctrl:'SERIENOME',prop:'Visible'},{av:'edtSerieNome_Titleformat',ctrl:'SERIENOME',prop:'Titleformat'},{av:'edtSerieNome_Title',ctrl:'SERIENOME',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV51GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("'DOINSERT'","{handler:'E15252',iparms:[{av:'A1SerieId',fld:'SERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
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
         Ddo_serienome_Activeeventkey = "";
         Ddo_serienome_Filteredtext_get = "";
         Ddo_serienome_Selectedvalue_get = "";
         Ddo_gridcolumnsselector_Columnsselectorvalues = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV39TFSerieNome = "";
         AV40TFSerieNome_Sel = "";
         AV28ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV41ddo_SerieNomeTitleControlIdToReplace = "";
         AV65Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV46DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV38SerieNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_serienome_Filteredtext_set = "";
         Ddo_serienome_Selectedvalue_set = "";
         Ddo_serienome_Sortedstatus = "";
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
         AV52Update = "";
         A2SerieNome = "";
         AV57Episodios = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV64Update_GXI = "";
         scmdbuf = "";
         lV62SerieWWDS_1_Tfserienome = "";
         AV63SerieWWDS_2_Tfserienome_sel = "";
         AV62SerieWWDS_1_Tfserienome = "";
         H00252_A3SerieQuantidadeTemporadas = new short[1] ;
         H00252_A2SerieNome = new String[] {""} ;
         H00252_A1SerieId = new long[1] ;
         H00253_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV37Session = context.GetSession();
         AV16ColumnsSelectorXML = "";
         AV29VisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn(context);
         GridRow = new GXWebRow();
         AV23UserCustomValue = "";
         GXt_char2 = "";
         AV11GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         AV36ColumnsSelectorXML2 = "";
         AV30InvisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_InvisibleColumn(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.serieww__default(),
            new Object[][] {
                new Object[] {
               H00252_A3SerieQuantidadeTemporadas, H00252_A2SerieNome, H00252_A1SerieId
               }
               , new Object[] {
               H00253_AGRID_nRecordCount
               }
            }
         );
         AV65Pgmname = "SerieWW";
         /* GeneXus formulas. */
         AV65Pgmname = "SerieWW";
         context.Gx_err = 0;
         edtavEpisodios_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_33 ;
      private short nGXsfl_33_idx=1 ;
      private short GRID_nEOF ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtSerieNome_Titleformat ;
      private short subGrid_Sortable ;
      private short A3SerieQuantidadeTemporadas ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_serienome_Datalistupdateminimumcharacters ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtSerieNome_Visible ;
      private int edtavEpisodios_Enabled ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_serienometitlecontrolidtoreplace_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfserienome_Visible ;
      private int edtavTfserienome_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV61GXV1 ;
      private int AV49PageToGo ;
      private int AV66GXV2 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV50GridCurrentPage ;
      private long AV51GridPageCount ;
      private long A1SerieId ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_serienome_Activeeventkey ;
      private String Ddo_serienome_Filteredtext_get ;
      private String Ddo_serienome_Selectedvalue_get ;
      private String Ddo_gridcolumnsselector_Columnsselectorvalues ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_33_idx="0001" ;
      private String AV65Pgmname ;
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
      private String Ddo_serienome_Caption ;
      private String Ddo_serienome_Tooltip ;
      private String Ddo_serienome_Cls ;
      private String Ddo_serienome_Filteredtext_set ;
      private String Ddo_serienome_Selectedvalue_set ;
      private String Ddo_serienome_Dropdownoptionstype ;
      private String Ddo_serienome_Titlecontrolidtoreplace ;
      private String Ddo_serienome_Sortedstatus ;
      private String Ddo_serienome_Filtertype ;
      private String Ddo_serienome_Datalisttype ;
      private String Ddo_serienome_Datalistproc ;
      private String Ddo_serienome_Sortasc ;
      private String Ddo_serienome_Sortdsc ;
      private String Ddo_serienome_Loadingdata ;
      private String Ddo_serienome_Cleanfilter ;
      private String Ddo_serienome_Noresultsfound ;
      private String Ddo_serienome_Searchbuttontext ;
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
      private String edtSerieNome_Title ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtSerieNome_Link ;
      private String AV57Episodios ;
      private String edtavEpisodios_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavDdo_serienometitlecontrolidtoreplace_Internalname ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfserienome_Internalname ;
      private String edtavTfserienome_Jsonclick ;
      private String edtavTfserienome_sel_Internalname ;
      private String edtavTfserienome_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUpdate_Internalname ;
      private String edtSerieId_Internalname ;
      private String edtSerieNome_Internalname ;
      private String edtSerieQuantidadeTemporadas_Internalname ;
      private String edtavEpisodios_Internalname ;
      private String scmdbuf ;
      private String Ddo_serienome_Internalname ;
      private String Ddo_gridcolumnsselector_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String GXt_char2 ;
      private String sGXsfl_33_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtSerieId_Jsonclick ;
      private String edtSerieNome_Jsonclick ;
      private String edtSerieQuantidadeTemporadas_Jsonclick ;
      private String edtavEpisodios_Jsonclick ;
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
      private bool Ddo_serienome_Includesortasc ;
      private bool Ddo_serienome_Includesortdsc ;
      private bool Ddo_serienome_Includefilter ;
      private bool Ddo_serienome_Filterisrange ;
      private bool Ddo_serienome_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_33_Refreshing=false ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV52Update_IsBlob ;
      private String AV16ColumnsSelectorXML ;
      private String AV23UserCustomValue ;
      private String AV36ColumnsSelectorXML2 ;
      private String AV39TFSerieNome ;
      private String AV40TFSerieNome_Sel ;
      private String AV41ddo_SerieNomeTitleControlIdToReplace ;
      private String A2SerieNome ;
      private String AV64Update_GXI ;
      private String lV62SerieWWDS_1_Tfserienome ;
      private String AV63SerieWWDS_2_Tfserienome_sel ;
      private String AV62SerieWWDS_1_Tfserienome ;
      private String AV52Update ;
      private IGxSession AV37Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H00252_A3SerieQuantidadeTemporadas ;
      private String[] H00252_A2SerieNome ;
      private long[] H00252_A1SerieId ;
      private long[] H00253_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV38SerieNomeTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV28ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn AV29VisibleColumn ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_InvisibleColumn AV30InvisibleColumn ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV46DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class serieww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00252( IGxContext context ,
                                             String AV63SerieWWDS_2_Tfserienome_sel ,
                                             String AV62SerieWWDS_1_Tfserienome ,
                                             String A2SerieNome ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [5] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [SerieQuantidadeTemporadas], [SerieNome], [SerieId]";
         sFromString = " FROM [Serie] WITH (NOLOCK)";
         sOrderString = "";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV63SerieWWDS_2_Tfserienome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62SerieWWDS_1_Tfserienome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SerieNome] like @lV62SerieWWDS_1_Tfserienome)";
            }
            else
            {
               sWhereString = sWhereString + " ([SerieNome] like @lV62SerieWWDS_1_Tfserienome)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63SerieWWDS_2_Tfserienome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SerieNome] = @AV63SerieWWDS_2_Tfserienome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SerieNome] = @AV63SerieWWDS_2_Tfserienome_sel)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [SerieNome]";
         }
         else if ( AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [SerieNome] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [SerieId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00253( IGxContext context ,
                                             String AV63SerieWWDS_2_Tfserienome_sel ,
                                             String AV62SerieWWDS_1_Tfserienome ,
                                             String A2SerieNome ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [2] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Serie] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV63SerieWWDS_2_Tfserienome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62SerieWWDS_1_Tfserienome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SerieNome] like @lV62SerieWWDS_1_Tfserienome)";
            }
            else
            {
               sWhereString = sWhereString + " ([SerieNome] like @lV62SerieWWDS_1_Tfserienome)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63SerieWWDS_2_Tfserienome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SerieNome] = @AV63SerieWWDS_2_Tfserienome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SerieNome] = @AV63SerieWWDS_2_Tfserienome_sel)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( AV14OrderedDsc )
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
                     return conditional_H00252(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] );
               case 1 :
                     return conditional_H00253(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] );
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
          Object[] prmH00252 ;
          prmH00252 = new Object[] {
          new Object[] {"@lV62SerieWWDS_1_Tfserienome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV63SerieWWDS_2_Tfserienome_sel",SqlDbType.VarChar,40,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00253 ;
          prmH00253 = new Object[] {
          new Object[] {"@lV62SerieWWDS_1_Tfserienome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV63SerieWWDS_2_Tfserienome_sel",SqlDbType.VarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00252", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00252,11,0,true,false )
             ,new CursorDef("H00253", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00253,1,0,true,false )
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
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[9]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[2]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[3]);
                }
                return;
       }
    }

 }

}
