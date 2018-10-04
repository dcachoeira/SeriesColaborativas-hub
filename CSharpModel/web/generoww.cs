/*
               File: GeneroWW
        Description:  Gênero
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:2.37
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
   public class generoww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public generoww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public generoww( IGxContext context )
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
         chkGeneroInativo = new GXCheckbox();
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
               AV13OrderedDsc = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV37TFGeneroNome = GetNextPar( );
               AV38TFGeneroNome_Sel = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV27ColumnsSelector);
               AV39ddo_GeneroNomeTitleControlIdToReplace = GetNextPar( );
               AV56Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedDsc, AV37TFGeneroNome, AV38TFGeneroNome_Sel, AV27ColumnsSelector, AV39ddo_GeneroNomeTitleControlIdToReplace, AV56Pgmname) ;
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
         PA282( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START282( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20189201946317", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("generoww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV13OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFGENERONOME", AV37TFGeneroNome);
         GxWebStd.gx_hidden_field( context, "GXH_vTFGENERONOME_SEL", AV38TFGeneroNome_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_33", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_33), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV44GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV45GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV40DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV40DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vGENERONOMETITLEFILTERDATA", AV36GeneroNomeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vGENERONOMETITLEFILTERDATA", AV36GeneroNomeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vCOLUMNSSELECTOR", AV27ColumnsSelector);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vCOLUMNSSELECTOR", AV27ColumnsSelector);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV56Pgmname));
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
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Caption", StringUtil.RTrim( Ddo_generonome_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Tooltip", StringUtil.RTrim( Ddo_generonome_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Cls", StringUtil.RTrim( Ddo_generonome_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Filteredtext_set", StringUtil.RTrim( Ddo_generonome_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Selectedvalue_set", StringUtil.RTrim( Ddo_generonome_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Dropdownoptionstype", StringUtil.RTrim( Ddo_generonome_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_generonome_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Includesortasc", StringUtil.BoolToStr( Ddo_generonome_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Includesortdsc", StringUtil.BoolToStr( Ddo_generonome_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Sortedstatus", StringUtil.RTrim( Ddo_generonome_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Includefilter", StringUtil.BoolToStr( Ddo_generonome_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Filtertype", StringUtil.RTrim( Ddo_generonome_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Filterisrange", StringUtil.BoolToStr( Ddo_generonome_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Includedatalist", StringUtil.BoolToStr( Ddo_generonome_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Datalisttype", StringUtil.RTrim( Ddo_generonome_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Datalistproc", StringUtil.RTrim( Ddo_generonome_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_generonome_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Sortasc", StringUtil.RTrim( Ddo_generonome_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Sortdsc", StringUtil.RTrim( Ddo_generonome_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Loadingdata", StringUtil.RTrim( Ddo_generonome_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Cleanfilter", StringUtil.RTrim( Ddo_generonome_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Noresultsfound", StringUtil.RTrim( Ddo_generonome_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Searchbuttontext", StringUtil.RTrim( Ddo_generonome_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Caption", StringUtil.RTrim( Ddo_gridcolumnsselector_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Tooltip", StringUtil.RTrim( Ddo_gridcolumnsselector_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Cls", StringUtil.RTrim( Ddo_gridcolumnsselector_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_gridcolumnsselector_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_gridcolumnsselector_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Updatebuttontext", StringUtil.RTrim( Ddo_gridcolumnsselector_Updatebuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Activeeventkey", StringUtil.RTrim( Ddo_generonome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Filteredtext_get", StringUtil.RTrim( Ddo_generonome_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Selectedvalue_get", StringUtil.RTrim( Ddo_generonome_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues", StringUtil.RTrim( Ddo_gridcolumnsselector_Columnsselectorvalues));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Activeeventkey", StringUtil.RTrim( Ddo_generonome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Filteredtext_get", StringUtil.RTrim( Ddo_generonome_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_GENERONOME_Selectedvalue_get", StringUtil.RTrim( Ddo_generonome_Selectedvalue_get));
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
            WE282( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT282( ) ;
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
         return formatLink("generoww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "GeneroWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " Gênero" ;
      }

      protected void WB280( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(33), 2, 0)+","+"null"+");", "Inserir", bttBtninsert_Jsonclick, 5, "Inserir", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GeneroWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            ClassString = "hidden-xs";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtneditcolumns_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(33), 2, 0)+","+"null"+");", "Seleciona colunas", bttBtneditcolumns_Jsonclick, 5, "Seleciona colunas", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'EDITCOLUMNS\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GeneroWW.htm");
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtGeneroNome_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtGeneroNome_Titleformat == 0 )
               {
                  context.SendWebValue( edtGeneroNome_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtGeneroNome_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Inativo") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV46Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A48GeneroId), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A49GeneroNome);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtGeneroNome_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGeneroNome_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtGeneroNome_Link));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGeneroNome_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A50GeneroInativo));
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
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DDO_GENERONOMEContainer"+"\"></div>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_33_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_generonometitlecontrolidtoreplace_Internalname, AV39ddo_GeneroNomeTitleControlIdToReplace, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_generonometitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_GeneroWW.htm");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"WORKWITHPLUSUTILITIES1Container"+"\"></div>") ;
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DDO_GRIDCOLUMNSSELECTORContainer"+"\"></div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_33_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV13OrderedDsc), StringUtil.BoolToStr( AV13OrderedDsc), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_GeneroWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_33_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfgeneronome_Internalname, AV37TFGeneroNome, StringUtil.RTrim( context.localUtil.Format( AV37TFGeneroNome, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfgeneronome_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfgeneronome_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GeneroWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_33_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfgeneronome_sel_Internalname, AV38TFGeneroNome_Sel, StringUtil.RTrim( context.localUtil.Format( AV38TFGeneroNome_Sel, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfgeneronome_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfgeneronome_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GeneroWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START282( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", " Gênero", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP280( ) ;
      }

      protected void WS282( )
      {
         START282( ) ;
         EVT282( ) ;
      }

      protected void EVT282( )
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
                              E11282 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12282 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_GENERONOME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13282 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14282 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E15282 ();
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
                              AV46Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV46Update)) ? AV55Update_GXI : context.convertURL( context.PathToRelativeUrl( AV46Update))), !bGXsfl_33_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV46Update), true);
                              A48GeneroId = (long)(context.localUtil.CToN( cgiGet( edtGeneroId_Internalname), ",", "."));
                              A49GeneroNome = cgiGet( edtGeneroNome_Internalname);
                              A50GeneroInativo = StringUtil.StrToBool( cgiGet( chkGeneroInativo_Internalname));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E16282 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E17282 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E18282 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV13OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfgeneronome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFGENERONOME"), AV37TFGeneroNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfgeneronome_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFGENERONOME_SEL"), AV38TFGeneroNome_Sel) != 0 )
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

      protected void WE282( )
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

      protected void PA282( )
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
            GXCCtl = "GENEROINATIVO_" + sGXsfl_33_idx;
            chkGeneroInativo.Name = GXCCtl;
            chkGeneroInativo.WebTags = "";
            chkGeneroInativo.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkGeneroInativo_Internalname, "TitleCaption", chkGeneroInativo.Caption, !bGXsfl_33_Refreshing);
            chkGeneroInativo.CheckedValue = "false";
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavDdo_generonometitlecontrolidtoreplace_Internalname;
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
                                       bool AV13OrderedDsc ,
                                       String AV37TFGeneroNome ,
                                       String AV38TFGeneroNome_Sel ,
                                       GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV27ColumnsSelector ,
                                       String AV39ddo_GeneroNomeTitleControlIdToReplace ,
                                       String AV56Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF282( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_GENEROID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A48GeneroId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "GENEROID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A48GeneroId), 18, 0, ".", "")));
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
         RF282( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV56Pgmname = "GeneroWW";
         context.Gx_err = 0;
      }

      protected void RF282( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 33;
         /* Execute user event: Refresh */
         E17282 ();
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
                                                 AV54GeneroWWDS_2_Tfgeneronome_sel ,
                                                 AV53GeneroWWDS_1_Tfgeneronome ,
                                                 A49GeneroNome ,
                                                 AV13OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV53GeneroWWDS_1_Tfgeneronome = StringUtil.Concat( StringUtil.RTrim( AV53GeneroWWDS_1_Tfgeneronome), "%", "");
            /* Using cursor H00282 */
            pr_default.execute(0, new Object[] {lV53GeneroWWDS_1_Tfgeneronome, AV54GeneroWWDS_2_Tfgeneronome_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_33_idx = 1;
            sGXsfl_33_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_33_idx), 4, 0)), 4, "0");
            SubsflControlProps_332( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A50GeneroInativo = H00282_A50GeneroInativo[0];
               A49GeneroNome = H00282_A49GeneroNome[0];
               A48GeneroId = H00282_A48GeneroId[0];
               E18282 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 33;
            WB280( ) ;
         }
         bGXsfl_33_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes282( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_GENEROID"+"_"+sGXsfl_33_idx, GetSecureSignedToken( sGXsfl_33_idx, context.localUtil.Format( (decimal)(A48GeneroId), "ZZZZZZZZZZZZZZZZZ9"), context));
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
         AV53GeneroWWDS_1_Tfgeneronome = AV37TFGeneroNome;
         AV54GeneroWWDS_2_Tfgeneronome_sel = AV38TFGeneroNome_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV54GeneroWWDS_2_Tfgeneronome_sel ,
                                              AV53GeneroWWDS_1_Tfgeneronome ,
                                              A49GeneroNome ,
                                              AV13OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV53GeneroWWDS_1_Tfgeneronome = StringUtil.Concat( StringUtil.RTrim( AV53GeneroWWDS_1_Tfgeneronome), "%", "");
         /* Using cursor H00283 */
         pr_default.execute(1, new Object[] {lV53GeneroWWDS_1_Tfgeneronome, AV54GeneroWWDS_2_Tfgeneronome_sel});
         GRID_nRecordCount = H00283_AGRID_nRecordCount[0];
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
         AV53GeneroWWDS_1_Tfgeneronome = AV37TFGeneroNome;
         AV54GeneroWWDS_2_Tfgeneronome_sel = AV38TFGeneroNome_Sel;
         GRID_nFirstRecordOnPage = 0;
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedDsc, AV37TFGeneroNome, AV38TFGeneroNome_Sel, AV27ColumnsSelector, AV39ddo_GeneroNomeTitleControlIdToReplace, AV56Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV53GeneroWWDS_1_Tfgeneronome = AV37TFGeneroNome;
         AV54GeneroWWDS_2_Tfgeneronome_sel = AV38TFGeneroNome_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedDsc, AV37TFGeneroNome, AV38TFGeneroNome_Sel, AV27ColumnsSelector, AV39ddo_GeneroNomeTitleControlIdToReplace, AV56Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV53GeneroWWDS_1_Tfgeneronome = AV37TFGeneroNome;
         AV54GeneroWWDS_2_Tfgeneronome_sel = AV38TFGeneroNome_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedDsc, AV37TFGeneroNome, AV38TFGeneroNome_Sel, AV27ColumnsSelector, AV39ddo_GeneroNomeTitleControlIdToReplace, AV56Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV53GeneroWWDS_1_Tfgeneronome = AV37TFGeneroNome;
         AV54GeneroWWDS_2_Tfgeneronome_sel = AV38TFGeneroNome_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedDsc, AV37TFGeneroNome, AV38TFGeneroNome_Sel, AV27ColumnsSelector, AV39ddo_GeneroNomeTitleControlIdToReplace, AV56Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV53GeneroWWDS_1_Tfgeneronome = AV37TFGeneroNome;
         AV54GeneroWWDS_2_Tfgeneronome_sel = AV38TFGeneroNome_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedDsc, AV37TFGeneroNome, AV38TFGeneroNome_Sel, AV27ColumnsSelector, AV39ddo_GeneroNomeTitleControlIdToReplace, AV56Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP280( )
      {
         /* Before Start, stand alone formulas. */
         AV56Pgmname = "GeneroWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E16282 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV40DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vGENERONOMETITLEFILTERDATA"), AV36GeneroNomeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vCOLUMNSSELECTOR"), AV27ColumnsSelector);
            /* Read variables values. */
            AV39ddo_GeneroNomeTitleControlIdToReplace = cgiGet( edtavDdo_generonometitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_GeneroNomeTitleControlIdToReplace", AV39ddo_GeneroNomeTitleControlIdToReplace);
            AV13OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            AV37TFGeneroNome = cgiGet( edtavTfgeneronome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFGeneroNome", AV37TFGeneroNome);
            AV38TFGeneroNome_Sel = cgiGet( edtavTfgeneronome_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFGeneroNome_Sel", AV38TFGeneroNome_Sel);
            /* Read saved values. */
            nRC_GXsfl_33 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_33"), ",", "."));
            AV44GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV45GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
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
            Ddo_generonome_Caption = cgiGet( "DDO_GENERONOME_Caption");
            Ddo_generonome_Tooltip = cgiGet( "DDO_GENERONOME_Tooltip");
            Ddo_generonome_Cls = cgiGet( "DDO_GENERONOME_Cls");
            Ddo_generonome_Filteredtext_set = cgiGet( "DDO_GENERONOME_Filteredtext_set");
            Ddo_generonome_Selectedvalue_set = cgiGet( "DDO_GENERONOME_Selectedvalue_set");
            Ddo_generonome_Dropdownoptionstype = cgiGet( "DDO_GENERONOME_Dropdownoptionstype");
            Ddo_generonome_Titlecontrolidtoreplace = cgiGet( "DDO_GENERONOME_Titlecontrolidtoreplace");
            Ddo_generonome_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_GENERONOME_Includesortasc"));
            Ddo_generonome_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_GENERONOME_Includesortdsc"));
            Ddo_generonome_Sortedstatus = cgiGet( "DDO_GENERONOME_Sortedstatus");
            Ddo_generonome_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_GENERONOME_Includefilter"));
            Ddo_generonome_Filtertype = cgiGet( "DDO_GENERONOME_Filtertype");
            Ddo_generonome_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_GENERONOME_Filterisrange"));
            Ddo_generonome_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_GENERONOME_Includedatalist"));
            Ddo_generonome_Datalisttype = cgiGet( "DDO_GENERONOME_Datalisttype");
            Ddo_generonome_Datalistproc = cgiGet( "DDO_GENERONOME_Datalistproc");
            Ddo_generonome_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_GENERONOME_Datalistupdateminimumcharacters"), ",", "."));
            Ddo_generonome_Sortasc = cgiGet( "DDO_GENERONOME_Sortasc");
            Ddo_generonome_Sortdsc = cgiGet( "DDO_GENERONOME_Sortdsc");
            Ddo_generonome_Loadingdata = cgiGet( "DDO_GENERONOME_Loadingdata");
            Ddo_generonome_Cleanfilter = cgiGet( "DDO_GENERONOME_Cleanfilter");
            Ddo_generonome_Noresultsfound = cgiGet( "DDO_GENERONOME_Noresultsfound");
            Ddo_generonome_Searchbuttontext = cgiGet( "DDO_GENERONOME_Searchbuttontext");
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
            Ddo_generonome_Activeeventkey = cgiGet( "DDO_GENERONOME_Activeeventkey");
            Ddo_generonome_Filteredtext_get = cgiGet( "DDO_GENERONOME_Filteredtext_get");
            Ddo_generonome_Selectedvalue_get = cgiGet( "DDO_GENERONOME_Selectedvalue_get");
            Ddo_gridcolumnsselector_Columnsselectorvalues = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV13OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFGENERONOME"), AV37TFGeneroNome) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFGENERONOME_SEL"), AV38TFGeneroNome_Sel) != 0 )
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
         E16282 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E16282( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfgeneronome_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfgeneronome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfgeneronome_Visible), 5, 0)), true);
         edtavTfgeneronome_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfgeneronome_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfgeneronome_sel_Visible), 5, 0)), true);
         Ddo_generonome_Titlecontrolidtoreplace = subGrid_Internalname+"_GeneroNome";
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_generonome_Internalname, "TitleControlIdToReplace", Ddo_generonome_Titlecontrolidtoreplace);
         AV39ddo_GeneroNomeTitleControlIdToReplace = Ddo_generonome_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_GeneroNomeTitleControlIdToReplace", AV39ddo_GeneroNomeTitleControlIdToReplace);
         edtavDdo_generonometitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_generonometitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_generonometitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " Gênero";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV40DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV40DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = bttBtneditcolumns_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_gridcolumnsselector_Internalname, "TitleControlIdToReplace", Ddo_gridcolumnsselector_Titlecontrolidtoreplace);
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E17282( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV36GeneroNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( StringUtil.StrCmp(AV35Session.Get("GeneroWWColumnsSelector"), "") != 0 )
         {
            AV15ColumnsSelectorXML = AV35Session.Get("GeneroWWColumnsSelector");
            AV27ColumnsSelector.FromXml(AV15ColumnsSelectorXML, null, "WWPColumnsSelector", "SeriesColaborativas");
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
         edtGeneroNome_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGeneroNome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGeneroNome_Visible), 5, 0)), !bGXsfl_33_Refreshing);
         AV52GXV1 = 1;
         while ( AV52GXV1 <= AV27ColumnsSelector.gxTpr_Visiblecolumns.Count )
         {
            AV28VisibleColumn = ((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn)AV27ColumnsSelector.gxTpr_Visiblecolumns.Item(AV52GXV1));
            if ( StringUtil.StrCmp(AV28VisibleColumn.gxTpr_Columnname, "Nome") == 0 )
            {
               edtGeneroNome_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGeneroNome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGeneroNome_Visible), 5, 0)), !bGXsfl_33_Refreshing);
            }
            AV52GXV1 = (int)(AV52GXV1+1);
         }
         edtGeneroNome_Titleformat = 2;
         edtGeneroNome_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Nome", AV39ddo_GeneroNomeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGeneroNome_Internalname, "Title", edtGeneroNome_Title, !bGXsfl_33_Refreshing);
         AV44GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44GridCurrentPage), 10, 0)));
         AV45GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV45GridPageCount), 10, 0)));
         AV53GeneroWWDS_1_Tfgeneronome = AV37TFGeneroNome;
         AV54GeneroWWDS_2_Tfgeneronome_sel = AV38TFGeneroNome_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36GeneroNomeTitleFilterData", AV36GeneroNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ColumnsSelector", AV27ColumnsSelector);
      }

      protected void E11282( )
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
            AV43PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV43PageToGo) ;
         }
      }

      protected void E12282( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13282( )
      {
         /* Ddo_generonome_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_generonome_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV13OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            Ddo_generonome_Sortedstatus = "ASC";
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_generonome_Internalname, "SortedStatus", Ddo_generonome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_generonome_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV13OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            Ddo_generonome_Sortedstatus = "DSC";
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_generonome_Internalname, "SortedStatus", Ddo_generonome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_generonome_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV37TFGeneroNome = Ddo_generonome_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFGeneroNome", AV37TFGeneroNome);
            AV38TFGeneroNome_Sel = Ddo_generonome_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFGeneroNome_Sel", AV38TFGeneroNome_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36GeneroNomeTitleFilterData", AV36GeneroNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ColumnsSelector", AV27ColumnsSelector);
      }

      private void E18282( )
      {
         /* Grid_Load Routine */
         AV46Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV46Update);
         AV55Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "Modifica";
         edtavUpdate_Link = formatLink("genero.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A48GeneroId);
         edtGeneroNome_Link = formatLink("genero.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +A48GeneroId);
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

      protected void E14282( )
      {
         /* Ddo_gridcolumnsselector_Oncolumnschanged Routine */
         AV15ColumnsSelectorXML = Ddo_gridcolumnsselector_Columnsselectorvalues;
         AV27ColumnsSelector.FromJSonString(AV15ColumnsSelectorXML, null);
         AV35Session.Set("GeneroWWColumnsSelector", AV27ColumnsSelector.ToXml(false, true, "WWPColumnsSelector", "SeriesColaborativas"));
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ColumnsSelector", AV27ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36GeneroNomeTitleFilterData", AV36GeneroNomeTitleFilterData);
      }

      protected void E15282( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("genero.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S152( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         Ddo_generonome_Sortedstatus = (AV13OrderedDsc ? "DSC" : "ASC");
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_generonome_Internalname, "SortedStatus", Ddo_generonome_Sortedstatus);
      }

      protected void S142( )
      {
         /* 'INITIALIZECOLUMNSSELECTOR' Routine */
         AV27ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         GXt_char2 = AV22UserCustomValue;
         new GeneXus.Programs.wwpbaseobjects.loadcolumnsselectorstate(context ).execute(  "GeneroWWColumnsSelector", out  GXt_char2) ;
         AV22UserCustomValue = GXt_char2;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( AV22UserCustomValue)) ) )
         {
            AV27ColumnsSelector.FromXml(AV22UserCustomValue, null, "WWPColumnsSelector", "SeriesColaborativas");
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
            AV28VisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn(context);
            AV28VisibleColumn.gxTpr_Columnname = "Nome";
            AV27ColumnsSelector.gxTpr_Visiblecolumns.Add(AV28VisibleColumn, 0);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV35Session.Get(AV56Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV56Pgmname+"GridState"), null, "WWPGridState", "SeriesColaborativas");
         }
         else
         {
            AV11GridState.FromXml(AV35Session.Get(AV56Pgmname+"GridState"), null, "WWPGridState", "SeriesColaborativas");
         }
         AV13OrderedDsc = AV11GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV57GXV2 = 1;
         while ( AV57GXV2 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV57GXV2));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFGENERONOME") == 0 )
            {
               AV37TFGeneroNome = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFGeneroNome", AV37TFGeneroNome);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37TFGeneroNome)) )
               {
                  Ddo_generonome_Filteredtext_set = AV37TFGeneroNome;
                  context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_generonome_Internalname, "FilteredText_set", Ddo_generonome_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFGENERONOME_SEL") == 0 )
            {
               AV38TFGeneroNome_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFGeneroNome_Sel", AV38TFGeneroNome_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFGeneroNome_Sel)) )
               {
                  Ddo_generonome_Selectedvalue_set = AV38TFGeneroNome_Sel;
                  context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Ddo_generonome_Internalname, "SelectedValue_set", Ddo_generonome_Selectedvalue_set);
               }
            }
            AV57GXV2 = (int)(AV57GXV2+1);
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
         AV11GridState.FromXml(AV35Session.Get(AV56Pgmname+"GridState"), null, "WWPGridState", "SeriesColaborativas");
         AV11GridState.gxTpr_Ordereddsc = AV13OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37TFGeneroNome)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFGENERONOME";
            AV12GridStateFilterValue.gxTpr_Value = AV37TFGeneroNome;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFGeneroNome_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFGENERONOME_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV38TFGeneroNome_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV56Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "SeriesColaborativas")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV56Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "Genero";
         AV35Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "SeriesColaborativas"));
      }

      protected void S162( )
      {
         /* 'UPDATECOLUMNS_COLUMNSSELECTOR' Routine */
         AV15ColumnsSelectorXML = AV27ColumnsSelector.gxTpr_Visiblecolumns.ToXml(false, true, "Collection", "SeriesColaborativas");
         AV34ColumnsSelectorXML2 = AV27ColumnsSelector.gxTpr_Invisiblecolumns.ToXml(false, true, "Collection", "SeriesColaborativas");
         AV27ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         if ( ! ( GxRegex.IsMatch(AV34ColumnsSelectorXML2,"<ColumnName>Nome</ColumnName") ) )
         {
            AV28VisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn(context);
            AV28VisibleColumn.gxTpr_Columnname = "Nome";
            AV27ColumnsSelector.gxTpr_Visiblecolumns.Add(AV28VisibleColumn, 0);
         }
         else
         {
            AV29InvisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_InvisibleColumn(context);
            AV29InvisibleColumn.gxTpr_Columnname = "Nome";
            AV27ColumnsSelector.gxTpr_Invisiblecolumns.Add(AV29InvisibleColumn, 0);
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
         PA282( ) ;
         WS282( ) ;
         WE282( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019461111", true);
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
         context.AddJavascriptSource("generoww.js", "?201892019461113", false);
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
         edtGeneroId_Internalname = "GENEROID_"+sGXsfl_33_idx;
         edtGeneroNome_Internalname = "GENERONOME_"+sGXsfl_33_idx;
         chkGeneroInativo_Internalname = "GENEROINATIVO_"+sGXsfl_33_idx;
      }

      protected void SubsflControlProps_fel_332( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_33_fel_idx;
         edtGeneroId_Internalname = "GENEROID_"+sGXsfl_33_fel_idx;
         edtGeneroNome_Internalname = "GENERONOME_"+sGXsfl_33_fel_idx;
         chkGeneroInativo_Internalname = "GENEROINATIVO_"+sGXsfl_33_fel_idx;
      }

      protected void sendrow_332( )
      {
         SubsflControlProps_332( ) ;
         WB280( ) ;
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
            AV46Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV46Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV55Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV46Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV46Update)) ? AV55Update_GXI : context.PathToRelativeUrl( AV46Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV46Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGeneroId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A48GeneroId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A48GeneroId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtGeneroId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)33,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtGeneroNome_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGeneroNome_Internalname,(String)A49GeneroNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtGeneroNome_Link,(String)"",(String)"",(String)"",(String)edtGeneroNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(int)edtGeneroNome_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)33,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nome",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkGeneroInativo_Internalname,StringUtil.BoolToStr( A50GeneroInativo),(String)"",(String)"",(short)0,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            send_integrity_lvl_hashes282( ) ;
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
         edtGeneroId_Internalname = "GENEROID";
         edtGeneroNome_Internalname = "GENERONOME";
         chkGeneroInativo_Internalname = "GENEROINATIVO";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_generonome_Internalname = "DDO_GENERONOME";
         edtavDdo_generonometitlecontrolidtoreplace_Internalname = "vDDO_GENERONOMETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         Ddo_gridcolumnsselector_Internalname = "DDO_GRIDCOLUMNSSELECTOR";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfgeneronome_Internalname = "vTFGENERONOME";
         edtavTfgeneronome_sel_Internalname = "vTFGENERONOME_SEL";
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
         edtGeneroNome_Jsonclick = "";
         edtGeneroId_Jsonclick = "";
         chkGeneroInativo.Caption = "";
         edtavTfgeneronome_sel_Jsonclick = "";
         edtavTfgeneronome_sel_Visible = 1;
         edtavTfgeneronome_Jsonclick = "";
         edtavTfgeneronome_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavDdo_generonometitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtGeneroNome_Link = "";
         edtavUpdate_Tooltiptext = "Modifica";
         edtavUpdate_Link = "";
         subGrid_Sortable = 0;
         edtGeneroNome_Titleformat = 0;
         edtGeneroNome_Title = "Nome";
         edtGeneroNome_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_gridcolumnsselector_Updatebuttontext = "WWP_ColumnsSelectorButton";
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = "";
         Ddo_gridcolumnsselector_Dropdownoptionstype = "GridColumnsSelector";
         Ddo_gridcolumnsselector_Cls = "ColumnsSelector hidden-xs";
         Ddo_gridcolumnsselector_Tooltip = "WWP_EditColumnsTooltip";
         Ddo_gridcolumnsselector_Caption = "Seleciona colunas";
         Ddo_generonome_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_generonome_Noresultsfound = "WWP_TSNoResults";
         Ddo_generonome_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_generonome_Loadingdata = "WWP_TSLoading";
         Ddo_generonome_Sortdsc = "WWP_TSSortDSC";
         Ddo_generonome_Sortasc = "WWP_TSSortASC";
         Ddo_generonome_Datalistupdateminimumcharacters = 0;
         Ddo_generonome_Datalistproc = "GeneroWWGetFilterData";
         Ddo_generonome_Datalisttype = "Dynamic";
         Ddo_generonome_Includedatalist = Convert.ToBoolean( -1);
         Ddo_generonome_Filterisrange = Convert.ToBoolean( 0);
         Ddo_generonome_Filtertype = "Character";
         Ddo_generonome_Includefilter = Convert.ToBoolean( -1);
         Ddo_generonome_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_generonome_Includesortasc = Convert.ToBoolean( -1);
         Ddo_generonome_Titlecontrolidtoreplace = "";
         Ddo_generonome_Dropdownoptionstype = "GridTitleSettings";
         Ddo_generonome_Cls = "ColumnSettings";
         Ddo_generonome_Tooltip = "WWP_TSColumnOptions";
         Ddo_generonome_Caption = "";
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
         Form.Caption = " Gênero";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV39ddo_GeneroNomeTitleControlIdToReplace',fld:'vDDO_GENERONOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV37TFGeneroNome',fld:'vTFGENERONOME',pic:'',nv:''},{av:'AV38TFGeneroNome_Sel',fld:'vTFGENERONOME_SEL',pic:'',nv:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}],oparms:[{av:'AV36GeneroNomeTitleFilterData',fld:'vGENERONOMETITLEFILTERDATA',pic:'',nv:null},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'edtGeneroNome_Visible',ctrl:'GENERONOME',prop:'Visible'},{av:'edtGeneroNome_Titleformat',ctrl:'GENERONOME',prop:'Titleformat'},{av:'edtGeneroNome_Title',ctrl:'GENERONOME',prop:'Title'},{av:'AV44GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV45GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11282',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV37TFGeneroNome',fld:'vTFGENERONOME',pic:'',nv:''},{av:'AV38TFGeneroNome_Sel',fld:'vTFGENERONOME_SEL',pic:'',nv:''},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV39ddo_GeneroNomeTitleControlIdToReplace',fld:'vDDO_GENERONOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12282',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV37TFGeneroNome',fld:'vTFGENERONOME',pic:'',nv:''},{av:'AV38TFGeneroNome_Sel',fld:'vTFGENERONOME_SEL',pic:'',nv:''},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV39ddo_GeneroNomeTitleControlIdToReplace',fld:'vDDO_GENERONOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_GENERONOME.ONOPTIONCLICKED","{handler:'E13282',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV37TFGeneroNome',fld:'vTFGENERONOME',pic:'',nv:''},{av:'AV38TFGeneroNome_Sel',fld:'vTFGENERONOME_SEL',pic:'',nv:''},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV39ddo_GeneroNomeTitleControlIdToReplace',fld:'vDDO_GENERONOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Ddo_generonome_Activeeventkey',ctrl:'DDO_GENERONOME',prop:'ActiveEventKey'},{av:'Ddo_generonome_Filteredtext_get',ctrl:'DDO_GENERONOME',prop:'FilteredText_get'},{av:'Ddo_generonome_Selectedvalue_get',ctrl:'DDO_GENERONOME',prop:'SelectedValue_get'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}],oparms:[{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'Ddo_generonome_Sortedstatus',ctrl:'DDO_GENERONOME',prop:'SortedStatus'},{av:'AV37TFGeneroNome',fld:'vTFGENERONOME',pic:'',nv:''},{av:'AV38TFGeneroNome_Sel',fld:'vTFGENERONOME_SEL',pic:'',nv:''},{av:'AV36GeneroNomeTitleFilterData',fld:'vGENERONOMETITLEFILTERDATA',pic:'',nv:null},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'edtGeneroNome_Visible',ctrl:'GENERONOME',prop:'Visible'},{av:'edtGeneroNome_Titleformat',ctrl:'GENERONOME',prop:'Titleformat'},{av:'edtGeneroNome_Title',ctrl:'GENERONOME',prop:'Title'},{av:'AV44GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV45GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID.LOAD","{handler:'E18282',iparms:[{av:'A48GeneroId',fld:'GENEROID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV46Update',fld:'vUPDATE',pic:'',nv:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'edtGeneroNome_Link',ctrl:'GENERONOME',prop:'Link'}]}");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED","{handler:'E14282',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:'',nv:false},{av:'AV37TFGeneroNome',fld:'vTFGENERONOME',pic:'',nv:''},{av:'AV38TFGeneroNome_Sel',fld:'vTFGENERONOME_SEL',pic:'',nv:''},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV39ddo_GeneroNomeTitleControlIdToReplace',fld:'vDDO_GENERONOMETITLECONTROLIDTOREPLACE',pic:'',nv:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:'',nv:''},{av:'Ddo_gridcolumnsselector_Columnsselectorvalues',ctrl:'DDO_GRIDCOLUMNSSELECTOR',prop:'ColumnsSelectorValues'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}],oparms:[{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:'',nv:null},{av:'AV36GeneroNomeTitleFilterData',fld:'vGENERONOMETITLEFILTERDATA',pic:'',nv:null},{av:'edtGeneroNome_Visible',ctrl:'GENERONOME',prop:'Visible'},{av:'edtGeneroNome_Titleformat',ctrl:'GENERONOME',prop:'Titleformat'},{av:'edtGeneroNome_Title',ctrl:'GENERONOME',prop:'Title'},{av:'AV44GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV45GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("'DOINSERT'","{handler:'E15282',iparms:[{av:'A48GeneroId',fld:'GENEROID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
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
         Ddo_generonome_Activeeventkey = "";
         Ddo_generonome_Filteredtext_get = "";
         Ddo_generonome_Selectedvalue_get = "";
         Ddo_gridcolumnsselector_Columnsselectorvalues = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV37TFGeneroNome = "";
         AV38TFGeneroNome_Sel = "";
         AV27ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV39ddo_GeneroNomeTitleControlIdToReplace = "";
         AV56Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV40DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV36GeneroNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_generonome_Filteredtext_set = "";
         Ddo_generonome_Selectedvalue_set = "";
         Ddo_generonome_Sortedstatus = "";
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
         AV46Update = "";
         A49GeneroNome = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV55Update_GXI = "";
         GXCCtl = "";
         scmdbuf = "";
         lV53GeneroWWDS_1_Tfgeneronome = "";
         AV54GeneroWWDS_2_Tfgeneronome_sel = "";
         AV53GeneroWWDS_1_Tfgeneronome = "";
         H00282_A50GeneroInativo = new bool[] {false} ;
         H00282_A49GeneroNome = new String[] {""} ;
         H00282_A48GeneroId = new long[1] ;
         H00283_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV35Session = context.GetSession();
         AV15ColumnsSelectorXML = "";
         AV28VisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn(context);
         GridRow = new GXWebRow();
         AV22UserCustomValue = "";
         GXt_char2 = "";
         AV11GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         AV34ColumnsSelectorXML2 = "";
         AV29InvisibleColumn = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_InvisibleColumn(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.generoww__default(),
            new Object[][] {
                new Object[] {
               H00282_A50GeneroInativo, H00282_A49GeneroNome, H00282_A48GeneroId
               }
               , new Object[] {
               H00283_AGRID_nRecordCount
               }
            }
         );
         AV56Pgmname = "GeneroWW";
         /* GeneXus formulas. */
         AV56Pgmname = "GeneroWW";
         context.Gx_err = 0;
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
      private short edtGeneroNome_Titleformat ;
      private short subGrid_Sortable ;
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
      private int Ddo_generonome_Datalistupdateminimumcharacters ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtGeneroNome_Visible ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_generonometitlecontrolidtoreplace_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfgeneronome_Visible ;
      private int edtavTfgeneronome_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV52GXV1 ;
      private int AV43PageToGo ;
      private int AV57GXV2 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV44GridCurrentPage ;
      private long AV45GridPageCount ;
      private long A48GeneroId ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_generonome_Activeeventkey ;
      private String Ddo_generonome_Filteredtext_get ;
      private String Ddo_generonome_Selectedvalue_get ;
      private String Ddo_gridcolumnsselector_Columnsselectorvalues ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_33_idx="0001" ;
      private String AV56Pgmname ;
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
      private String Ddo_generonome_Caption ;
      private String Ddo_generonome_Tooltip ;
      private String Ddo_generonome_Cls ;
      private String Ddo_generonome_Filteredtext_set ;
      private String Ddo_generonome_Selectedvalue_set ;
      private String Ddo_generonome_Dropdownoptionstype ;
      private String Ddo_generonome_Titlecontrolidtoreplace ;
      private String Ddo_generonome_Sortedstatus ;
      private String Ddo_generonome_Filtertype ;
      private String Ddo_generonome_Datalisttype ;
      private String Ddo_generonome_Datalistproc ;
      private String Ddo_generonome_Sortasc ;
      private String Ddo_generonome_Sortdsc ;
      private String Ddo_generonome_Loadingdata ;
      private String Ddo_generonome_Cleanfilter ;
      private String Ddo_generonome_Noresultsfound ;
      private String Ddo_generonome_Searchbuttontext ;
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
      private String edtGeneroNome_Title ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtGeneroNome_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavDdo_generonometitlecontrolidtoreplace_Internalname ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfgeneronome_Internalname ;
      private String edtavTfgeneronome_Jsonclick ;
      private String edtavTfgeneronome_sel_Internalname ;
      private String edtavTfgeneronome_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUpdate_Internalname ;
      private String edtGeneroId_Internalname ;
      private String edtGeneroNome_Internalname ;
      private String chkGeneroInativo_Internalname ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String Ddo_generonome_Internalname ;
      private String Ddo_gridcolumnsselector_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String GXt_char2 ;
      private String sGXsfl_33_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtGeneroId_Jsonclick ;
      private String edtGeneroNome_Jsonclick ;
      private String Dvpanel_tableheader_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private bool entryPointCalled ;
      private bool AV13OrderedDsc ;
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
      private bool Ddo_generonome_Includesortasc ;
      private bool Ddo_generonome_Includesortdsc ;
      private bool Ddo_generonome_Includefilter ;
      private bool Ddo_generonome_Filterisrange ;
      private bool Ddo_generonome_Includedatalist ;
      private bool wbLoad ;
      private bool A50GeneroInativo ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_33_Refreshing=false ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV46Update_IsBlob ;
      private String AV15ColumnsSelectorXML ;
      private String AV22UserCustomValue ;
      private String AV34ColumnsSelectorXML2 ;
      private String AV37TFGeneroNome ;
      private String AV38TFGeneroNome_Sel ;
      private String AV39ddo_GeneroNomeTitleControlIdToReplace ;
      private String A49GeneroNome ;
      private String AV55Update_GXI ;
      private String lV53GeneroWWDS_1_Tfgeneronome ;
      private String AV54GeneroWWDS_2_Tfgeneronome_sel ;
      private String AV53GeneroWWDS_1_Tfgeneronome ;
      private String AV46Update ;
      private IGxSession AV35Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkGeneroInativo ;
      private IDataStoreProvider pr_default ;
      private bool[] H00282_A50GeneroInativo ;
      private String[] H00282_A49GeneroNome ;
      private long[] H00282_A48GeneroId ;
      private long[] H00283_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36GeneroNomeTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV27ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_VisibleColumn AV28VisibleColumn ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_InvisibleColumn AV29InvisibleColumn ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV40DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class generoww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00282( IGxContext context ,
                                             String AV54GeneroWWDS_2_Tfgeneronome_sel ,
                                             String AV53GeneroWWDS_1_Tfgeneronome ,
                                             String A49GeneroNome ,
                                             bool AV13OrderedDsc )
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
         sSelectString = " [GeneroInativo], [GeneroNome], [GeneroId]";
         sFromString = " FROM [Genero] WITH (NOLOCK)";
         sOrderString = "";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54GeneroWWDS_2_Tfgeneronome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53GeneroWWDS_1_Tfgeneronome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([GeneroNome] like @lV53GeneroWWDS_1_Tfgeneronome)";
            }
            else
            {
               sWhereString = sWhereString + " ([GeneroNome] like @lV53GeneroWWDS_1_Tfgeneronome)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54GeneroWWDS_2_Tfgeneronome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([GeneroNome] = @AV54GeneroWWDS_2_Tfgeneronome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([GeneroNome] = @AV54GeneroWWDS_2_Tfgeneronome_sel)";
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
         if ( ! AV13OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [GeneroNome]";
         }
         else if ( AV13OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [GeneroNome] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [GeneroId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00283( IGxContext context ,
                                             String AV54GeneroWWDS_2_Tfgeneronome_sel ,
                                             String AV53GeneroWWDS_1_Tfgeneronome ,
                                             String A49GeneroNome ,
                                             bool AV13OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [2] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Genero] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54GeneroWWDS_2_Tfgeneronome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53GeneroWWDS_1_Tfgeneronome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([GeneroNome] like @lV53GeneroWWDS_1_Tfgeneronome)";
            }
            else
            {
               sWhereString = sWhereString + " ([GeneroNome] like @lV53GeneroWWDS_1_Tfgeneronome)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54GeneroWWDS_2_Tfgeneronome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([GeneroNome] = @AV54GeneroWWDS_2_Tfgeneronome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([GeneroNome] = @AV54GeneroWWDS_2_Tfgeneronome_sel)";
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
         if ( ! AV13OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( AV13OrderedDsc )
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
                     return conditional_H00282(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] );
               case 1 :
                     return conditional_H00283(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] );
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
          Object[] prmH00282 ;
          prmH00282 = new Object[] {
          new Object[] {"@lV53GeneroWWDS_1_Tfgeneronome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV54GeneroWWDS_2_Tfgeneronome_sel",SqlDbType.VarChar,40,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00283 ;
          prmH00283 = new Object[] {
          new Object[] {"@lV53GeneroWWDS_1_Tfgeneronome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV54GeneroWWDS_2_Tfgeneronome_sel",SqlDbType.VarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00282", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00282,11,0,true,false )
             ,new CursorDef("H00283", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00283,1,0,true,false )
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
                ((bool[]) buf[0])[0] = rslt.getBool(1) ;
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
