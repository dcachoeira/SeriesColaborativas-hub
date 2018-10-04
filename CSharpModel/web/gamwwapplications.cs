/*
               File: GAMWWApplications
        Description: Applications
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:44:17.20
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
   public class gamwwapplications : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamwwapplications( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamwwapplications( IGxContext context )
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridww") == 0 )
            {
               nRC_GXsfl_38 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_38_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_38_idx = GetNextPar( );
               edtavGamactionpermission_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGamactionpermission_Internalname, "Title", edtavGamactionpermission_Title, !bGXsfl_38_Refreshing);
               edtavUamenus_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUamenus_Internalname, "Title", edtavUamenus_Title, !bGXsfl_38_Refreshing);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGridww_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Gridww") == 0 )
            {
               subGridww_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               edtavGamactionpermission_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGamactionpermission_Internalname, "Title", edtavGamactionpermission_Title, !bGXsfl_38_Refreshing);
               edtavUamenus_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUamenus_Internalname, "Title", edtavUamenus_Title, !bGXsfl_38_Refreshing);
               AV15FilName = GetNextPar( );
               AV20IsAuthorized_BtnUpd = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV19IsAuthorized_BtnDlt = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV21IsAuthorized_GAMActionPermission = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV28IsAuthorized_UAMenus = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV22IsAuthorized_Name = (bool)(BooleanUtil.Val(GetNextPar( )));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridww_refresh( subGridww_Rows, AV15FilName, AV20IsAuthorized_BtnUpd, AV19IsAuthorized_BtnDlt, AV21IsAuthorized_GAMActionPermission, AV28IsAuthorized_UAMenus, AV22IsAuthorized_Name) ;
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
         PA1B2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1B2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019441768", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamwwapplications.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_38", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_38), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDWWPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18GridWWPageCount), 10, 0, ",", "")));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNUPD", AV20IsAuthorized_BtnUpd);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNDLT", AV19IsAuthorized_BtnDlt);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_GAMACTIONPERMISSION", AV21IsAuthorized_GAMActionPermission);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UAMENUS", AV28IsAuthorized_UAMenus);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_NAME", AV22IsAuthorized_Name);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV22IsAuthorized_Name, context));
         GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDWW_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Class", StringUtil.RTrim( Gridwwpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Previous", StringUtil.RTrim( Gridwwpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Next", StringUtil.RTrim( Gridwwpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Caption", StringUtil.RTrim( Gridwwpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridwwpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridwwpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridwwpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridwwpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridwwpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridwwpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridwwpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridwwpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridwwpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridwwpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridwwpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridwwpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridwwpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridwwpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridwwpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGAMACTIONPERMISSION_Title", StringUtil.RTrim( edtavGamactionpermission_Title));
         GxWebStd.gx_hidden_field( context, "vUAMENUS_Title", StringUtil.RTrim( edtavUamenus_Title));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridwwpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDWWPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridwwpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
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
            WE1B2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1B2( ) ;
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
         return formatLink("gamwwapplications.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "GAMWWApplications" ;
      }

      public override String GetPgmdesc( )
      {
         return "Applications " ;
      }

      protected void WB1B0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidthAuto", "left", "top", "", "", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnadd_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(38), 2, 0)+","+"null"+");", "Insert", bttBtnadd_Jsonclick, 7, "Insert", "", StyleString, ClassString, bttBtnadd_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e111b1_client"+"'", TempTags, "", 2, "HLP_GAMWWApplications.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-6 CellFloatRight CellWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablefilters_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellFormGroupMarginBottom5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavFilname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFilname_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'" + sGXsfl_38_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFilname_Internalname, StringUtil.RTrim( AV15FilName), StringUtil.RTrim( context.localUtil.Format( AV15FilName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,32);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFilname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavFilname_Enabled, 0, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMWWApplications.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 SectionGrid", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridwwtablewithpaginationbar_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridwwContainer.SetWrapped(nGXWrapped);
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"DivS\" data-gxgridid=\"38\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGridww_Internalname, subGridww_Internalname, "", "GridWithPaginationBar GridWithBorderColor WorkWith", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGridww_Backcolorstyle == 0 )
               {
                  subGridww_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGridww_Class) > 0 )
                  {
                     subGridww_Linesclass = subGridww_Class+"Title";
                  }
               }
               else
               {
                  subGridww_Titlebackstyle = 1;
                  if ( subGridww_Backcolorstyle == 1 )
                  {
                     subGridww_Titlebackcolor = subGridww_Allbackcolor;
                     if ( StringUtil.Len( subGridww_Class) > 0 )
                     {
                        subGridww_Linesclass = subGridww_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGridww_Class) > 0 )
                     {
                        subGridww_Linesclass = subGridww_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "GUID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavBtnupd_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute"+"\" "+" style=\""+((edtavBtndlt_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavGamactionpermission_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( edtavGamactionpermission_Title) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUamenus_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( edtavUamenus_Title) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridwwContainer.AddObjectProperty("GridName", "Gridww");
            }
            else
            {
               GridwwContainer.AddObjectProperty("GridName", "Gridww");
               GridwwContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWith");
               GridwwContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Backcolorstyle), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("CmpContext", "");
               GridwwContainer.AddObjectProperty("InMasterPage", "false");
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV9GUID));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGuid_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10Id), 12, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavId_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV6BtnUpd));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtnupd_Link));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtnupd_Tooltiptext));
               GridwwColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtnupd_Visible), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV13BtnDlt));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtndlt_Link));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtndlt_Tooltiptext));
               GridwwColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtndlt_Visible), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV16GAMActionPermission));
               GridwwColumn.AddObjectProperty("Title", StringUtil.RTrim( edtavGamactionpermission_Title));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavGamactionpermission_Link));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavGamactionpermission_Tooltiptext));
               GridwwColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGamactionpermission_Visible), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV29UAMenus));
               GridwwColumn.AddObjectProperty("Title", StringUtil.RTrim( edtavUamenus_Title));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUamenus_Link));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUamenus_Tooltiptext));
               GridwwColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUamenus_Visible), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV11Name));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavName_Enabled), 5, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavName_Link));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowselection), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Selectioncolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowhovering), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Hoveringcolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowcollapsing), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 38 )
         {
            wbEnd = 0;
            nRC_GXsfl_38 = (short)(nGXsfl_38_idx-1);
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridww", GridwwContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridwwContainerData", GridwwContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridwwContainerData"+"V", GridwwContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input autocomplete=\"off\" type=\"hidden\" "+"name=\""+"GridwwContainerData"+"V"+"\" value='"+GridwwContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_gridwwpaginationbar_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"GRIDWWPAGINATIONBARContainer"+"\"></div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_38_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGridwwcurrentpage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17GridWWCurrentPage), 10, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17GridWWCurrentPage), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGridwwcurrentpage_Jsonclick, 0, "Attribute", "", "", "", "", edtavGridwwcurrentpage_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMWWApplications.htm");
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1B2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Applications ", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1B0( ) ;
      }

      protected void WS1B2( )
      {
         START1B2( ) ;
         EVT1B2( ) ;
      }

      protected void EVT1B2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "GRIDWWPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E121B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E131B2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "GRIDWW.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_38_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0");
                              SubsflControlProps_382( ) ;
                              AV9GUID = cgiGet( edtavGuid_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavGuid_Internalname, AV9GUID);
                              AV10Id = (long)(context.localUtil.CToN( cgiGet( edtavId_Internalname), ",", "."));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV10Id), 12, 0)));
                              AV6BtnUpd = cgiGet( edtavBtnupd_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6BtnUpd)) ? AV36Btnupd_GXI : context.convertURL( context.PathToRelativeUrl( AV6BtnUpd))), !bGXsfl_38_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "SrcSet", context.GetImageSrcSet( AV6BtnUpd), true);
                              AV13BtnDlt = cgiGet( edtavBtndlt_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV13BtnDlt)) ? AV37Btndlt_GXI : context.convertURL( context.PathToRelativeUrl( AV13BtnDlt))), !bGXsfl_38_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "SrcSet", context.GetImageSrcSet( AV13BtnDlt), true);
                              AV16GAMActionPermission = cgiGet( edtavGamactionpermission_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGamactionpermission_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16GAMActionPermission)) ? AV38Gamactionpermission_GXI : context.convertURL( context.PathToRelativeUrl( AV16GAMActionPermission))), !bGXsfl_38_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGamactionpermission_Internalname, "SrcSet", context.GetImageSrcSet( AV16GAMActionPermission), true);
                              AV29UAMenus = cgiGet( edtavUamenus_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUamenus_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV29UAMenus)) ? AV39Uamenus_GXI : context.convertURL( context.PathToRelativeUrl( AV29UAMenus))), !bGXsfl_38_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUamenus_Internalname, "SrcSet", context.GetImageSrcSet( AV29UAMenus), true);
                              AV11Name = cgiGet( edtavName_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV11Name);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E141B2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E151B2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDWW.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E161B2 ();
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
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1B2( )
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

      protected void PA1B2( )
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
               GX_FocusControl = edtavFilname_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridww_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_382( ) ;
         while ( nGXsfl_38_idx <= nRC_GXsfl_38 )
         {
            sendrow_382( ) ;
            nGXsfl_38_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_38_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_38_idx+1));
            sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0");
            SubsflControlProps_382( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridwwContainer));
         /* End function gxnrGridww_newrow */
      }

      protected void gxgrGridww_refresh( int subGridww_Rows ,
                                         String AV15FilName ,
                                         bool AV20IsAuthorized_BtnUpd ,
                                         bool AV19IsAuthorized_BtnDlt ,
                                         bool AV21IsAuthorized_GAMActionPermission ,
                                         bool AV28IsAuthorized_UAMenus ,
                                         bool AV22IsAuthorized_Name )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         GRIDWW_nCurrentRecord = 0;
         RF1B2( ) ;
         /* End function gxgrGridww_refresh */
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
         RF1B2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavGuid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
         edtavName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
      }

      protected void RF1B2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridwwContainer.ClearRows();
         }
         wbStart = 38;
         /* Execute user event: Refresh */
         E151B2 ();
         nGXsfl_38_idx = 1;
         sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0");
         SubsflControlProps_382( ) ;
         bGXsfl_38_Refreshing = true;
         GridwwContainer.AddObjectProperty("GridName", "Gridww");
         GridwwContainer.AddObjectProperty("CmpContext", "");
         GridwwContainer.AddObjectProperty("InMasterPage", "false");
         GridwwContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWith");
         GridwwContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridwwContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridwwContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Backcolorstyle), 1, 0, ".", "")));
         GridwwContainer.PageSize = subGridww_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_382( ) ;
            E161B2 ();
            if ( ( GRIDWW_nCurrentRecord > 0 ) && ( GRIDWW_nGridOutOfScope == 0 ) && ( nGXsfl_38_idx == 1 ) )
            {
               GRIDWW_nCurrentRecord = 0;
               GRIDWW_nGridOutOfScope = 1;
               subgridww_firstpage( ) ;
               E161B2 ();
            }
            wbEnd = 38;
            WB1B0( ) ;
         }
         bGXsfl_38_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1B2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_NAME", AV22IsAuthorized_Name);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV22IsAuthorized_Name, context));
      }

      protected int subGridww_Pagecount( )
      {
         GRIDWW_nRecordCount = subGridww_Recordcount( );
         if ( ((int)((GRIDWW_nRecordCount) % (subGridww_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRIDWW_nRecordCount/ (decimal)(subGridww_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRIDWW_nRecordCount/ (decimal)(subGridww_Recordsperpage( ))))+1) ;
      }

      protected int subGridww_Recordcount( )
      {
         return (int)(GRIDWW_nFirstRecordOnPage+1) ;
      }

      protected int subGridww_Recordsperpage( )
      {
         if ( subGridww_Rows > 0 )
         {
            return subGridww_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGridww_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRIDWW_nFirstRecordOnPage/ (decimal)(subGridww_Recordsperpage( ))))+1) ;
      }

      protected short subgridww_firstpage( )
      {
         GRIDWW_nFirstRecordOnPage = 0;
         if ( isFullAjaxMode( ) )
         {
            gxgrGridww_refresh( subGridww_Rows, AV15FilName, AV20IsAuthorized_BtnUpd, AV19IsAuthorized_BtnDlt, AV21IsAuthorized_GAMActionPermission, AV28IsAuthorized_UAMenus, AV22IsAuthorized_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgridww_nextpage( )
      {
         if ( GRIDWW_nEOF == 0 )
         {
            GRIDWW_nFirstRecordOnPage = (long)(GRIDWW_nFirstRecordOnPage+subGridww_Recordsperpage( ));
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGridww_refresh( subGridww_Rows, AV15FilName, AV20IsAuthorized_BtnUpd, AV19IsAuthorized_BtnDlt, AV21IsAuthorized_GAMActionPermission, AV28IsAuthorized_UAMenus, AV22IsAuthorized_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ".", "")));
         GridwwContainer.AddObjectProperty("GRIDWW_nFirstRecordOnPage", GRIDWW_nFirstRecordOnPage);
         return (short)(((GRIDWW_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgridww_previouspage( )
      {
         if ( GRIDWW_nFirstRecordOnPage >= subGridww_Recordsperpage( ) )
         {
            GRIDWW_nFirstRecordOnPage = (long)(GRIDWW_nFirstRecordOnPage-subGridww_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGridww_refresh( subGridww_Rows, AV15FilName, AV20IsAuthorized_BtnUpd, AV19IsAuthorized_BtnDlt, AV21IsAuthorized_GAMActionPermission, AV28IsAuthorized_UAMenus, AV22IsAuthorized_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgridww_lastpage( )
      {
         subGridww_Islastpage = 1;
         if ( isFullAjaxMode( ) )
         {
            gxgrGridww_refresh( subGridww_Rows, AV15FilName, AV20IsAuthorized_BtnUpd, AV19IsAuthorized_BtnDlt, AV21IsAuthorized_GAMActionPermission, AV28IsAuthorized_UAMenus, AV22IsAuthorized_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgridww_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRIDWW_nFirstRecordOnPage = (long)(subGridww_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRIDWW_nFirstRecordOnPage = 0;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGridww_refresh( subGridww_Rows, AV15FilName, AV20IsAuthorized_BtnUpd, AV19IsAuthorized_BtnDlt, AV21IsAuthorized_GAMActionPermission, AV28IsAuthorized_UAMenus, AV22IsAuthorized_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP1B0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavGuid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
         edtavName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E141B2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV15FilName = cgiGet( edtavFilname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15FilName", AV15FilName);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vGRIDWWCURRENTPAGE");
               GX_FocusControl = edtavGridwwcurrentpage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17GridWWCurrentPage = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GridWWCurrentPage), 10, 0)));
            }
            else
            {
               AV17GridWWCurrentPage = (long)(context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GridWWCurrentPage), 10, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_38 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_38"), ",", "."));
            AV18GridWWPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDWWPAGECOUNT"), ",", "."));
            GRIDWW_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRIDWW_nFirstRecordOnPage"), ",", "."));
            GRIDWW_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRIDWW_nEOF"), ",", "."));
            subGridww_Rows = (int)(context.localUtil.CToN( cgiGet( "GRIDWW_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
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
            Gridwwpaginationbar_Class = cgiGet( "GRIDWWPAGINATIONBAR_Class");
            Gridwwpaginationbar_Previous = cgiGet( "GRIDWWPAGINATIONBAR_Previous");
            Gridwwpaginationbar_Next = cgiGet( "GRIDWWPAGINATIONBAR_Next");
            Gridwwpaginationbar_Caption = cgiGet( "GRIDWWPAGINATIONBAR_Caption");
            Gridwwpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( "GRIDWWPAGINATIONBAR_Showfirst"));
            Gridwwpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( "GRIDWWPAGINATIONBAR_Showprevious"));
            Gridwwpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( "GRIDWWPAGINATIONBAR_Shownext"));
            Gridwwpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( "GRIDWWPAGINATIONBAR_Showlast"));
            Gridwwpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( "GRIDWWPAGINATIONBAR_Pagestoshow"), ",", "."));
            Gridwwpaginationbar_Pagingbuttonsposition = cgiGet( "GRIDWWPAGINATIONBAR_Pagingbuttonsposition");
            Gridwwpaginationbar_Pagingcaptionposition = cgiGet( "GRIDWWPAGINATIONBAR_Pagingcaptionposition");
            Gridwwpaginationbar_Emptygridclass = cgiGet( "GRIDWWPAGINATIONBAR_Emptygridclass");
            Gridwwpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( "GRIDWWPAGINATIONBAR_Rowsperpageselector"));
            Gridwwpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDWWPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            Gridwwpaginationbar_Rowsperpageoptions = cgiGet( "GRIDWWPAGINATIONBAR_Rowsperpageoptions");
            Gridwwpaginationbar_Emptygridcaption = cgiGet( "GRIDWWPAGINATIONBAR_Emptygridcaption");
            Gridwwpaginationbar_Rowsperpagecaption = cgiGet( "GRIDWWPAGINATIONBAR_Rowsperpagecaption");
            Gridwwpaginationbar_Selectedpage = cgiGet( "GRIDWWPAGINATIONBAR_Selectedpage");
            Gridwwpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDWWPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
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
         E141B2 ();
         if (returnInSub) return;
      }

      protected void E141B2( )
      {
         /* Start Routine */
         subGridww_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV17GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GridWWCurrentPage), 10, 0)));
         edtavGridwwcurrentpage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGridwwcurrentpage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGridwwcurrentpage_Visible), 5, 0)), true);
         AV18GridWWPageCount = -1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GridWWPageCount), 10, 0)));
         GXt_boolean1 = AV22IsAuthorized_Name;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamapplicationentry_Execute", out  GXt_boolean1) ;
         AV22IsAuthorized_Name = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22IsAuthorized_Name", AV22IsAuthorized_Name);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV22IsAuthorized_Name, context));
         Gridwwpaginationbar_Rowsperpageselectedvalue = subGridww_Rows;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Gridwwpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridwwpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         edtavGamactionpermission_Title = "Permissions";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGamactionpermission_Internalname, "Title", edtavGamactionpermission_Title, !bGXsfl_38_Refreshing);
         edtavUamenus_Title = "Menus";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUamenus_Internalname, "Title", edtavUamenus_Title, !bGXsfl_38_Refreshing);
      }

      protected void E151B2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         /* Execute user subroutine: 'CHECKSECURITYFORACTIONS' */
         S112 ();
         if (returnInSub) return;
         AV21IsAuthorized_GAMActionPermission = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21IsAuthorized_GAMActionPermission", AV21IsAuthorized_GAMActionPermission);
         AV28IsAuthorized_UAMenus = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28IsAuthorized_UAMenus", AV28IsAuthorized_UAMenus);
         /*  Sending Event outputs  */
      }

      private void E161B2( )
      {
         /* Gridww_Load Routine */
         AV8Filter.gxTpr_Name = "%"+AV15FilName;
         AV25GAMApplications = new SdtGAMRepository(context).getapplications(AV8Filter, out  AV7Errors);
         if ( AV25GAMApplications.Count == 0 )
         {
            AV18GridWWPageCount = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GridWWPageCount), 10, 0)));
         }
         else
         {
            AV18GridWWPageCount = (long)((AV25GAMApplications.Count/ (decimal)(9))+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GridWWPageCount), 10, 0)));
         }
         AV27GridWWRecordCount = AV25GAMApplications.Count;
         AV26GridWWPageSize = 9;
         AV35GXV1 = 1;
         while ( AV35GXV1 <= AV25GAMApplications.Count )
         {
            AV5Application = ((SdtGAMApplication)AV25GAMApplications.Item(AV35GXV1));
            AV10Id = AV5Application.gxTpr_Id;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV10Id), 12, 0)));
            AV9GUID = AV5Application.gxTpr_Guid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavGuid_Internalname, AV9GUID);
            AV11Name = AV5Application.gxTpr_Name;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV11Name);
            AV6BtnUpd = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtnupd_Internalname, AV6BtnUpd);
            AV36Btnupd_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
            edtavBtnupd_Tooltiptext = "Update";
            if ( AV20IsAuthorized_BtnUpd )
            {
               edtavBtnupd_Link = formatLink("gamapplicationentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +AV10Id);
            }
            AV13BtnDlt = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtndlt_Internalname, AV13BtnDlt);
            AV37Btndlt_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
            edtavBtndlt_Tooltiptext = "Delete";
            if ( AV19IsAuthorized_BtnDlt )
            {
               edtavBtndlt_Link = formatLink("gamapplicationentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +AV10Id);
            }
            AV16GAMActionPermission = context.GetImagePath( "846cc5aa-e497-452c-bf2c-fdd868279a72", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavGamactionpermission_Internalname, AV16GAMActionPermission);
            AV38Gamactionpermission_GXI = GXDbFile.PathToUrl( context.GetImagePath( "846cc5aa-e497-452c-bf2c-fdd868279a72", "", context.GetTheme( )));
            edtavGamactionpermission_Tooltiptext = "Permissions";
            if ( AV21IsAuthorized_GAMActionPermission )
            {
               edtavGamactionpermission_Link = formatLink("gamwwapppermissions.aspx") + "?" + UrlEncode("" +AV10Id);
            }
            AV29UAMenus = context.GetImagePath( "8fd5c61d-4e99-4932-bc10-a07be07ac169", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUamenus_Internalname, AV29UAMenus);
            AV39Uamenus_GXI = GXDbFile.PathToUrl( context.GetImagePath( "8fd5c61d-4e99-4932-bc10-a07be07ac169", "", context.GetTheme( )));
            edtavUamenus_Tooltiptext = "";
            if ( AV28IsAuthorized_UAMenus )
            {
               edtavUamenus_Link = formatLink("gamwwappmenus.aspx") + "?" + UrlEncode("" +AV10Id);
            }
            if ( AV22IsAuthorized_Name )
            {
               edtavName_Link = formatLink("gamapplicationentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +AV10Id);
            }
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 38;
            }
            if ( ( subGridww_Islastpage == 1 ) || ( subGridww_Rows == 0 ) || ( ( GRIDWW_nCurrentRecord >= GRIDWW_nFirstRecordOnPage ) && ( GRIDWW_nCurrentRecord < GRIDWW_nFirstRecordOnPage + subGridww_Recordsperpage( ) ) ) )
            {
               sendrow_382( ) ;
               GRIDWW_nEOF = 1;
               GxWebStd.gx_hidden_field( context, "GRIDWW_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nEOF), 1, 0, ".", "")));
               if ( ( subGridww_Islastpage == 1 ) && ( ((int)((GRIDWW_nCurrentRecord) % (subGridww_Recordsperpage( )))) == 0 ) )
               {
                  GRIDWW_nFirstRecordOnPage = GRIDWW_nCurrentRecord;
               }
            }
            if ( GRIDWW_nCurrentRecord >= GRIDWW_nFirstRecordOnPage + subGridww_Recordsperpage( ) )
            {
               GRIDWW_nEOF = 0;
               GxWebStd.gx_hidden_field( context, "GRIDWW_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nEOF), 1, 0, ".", "")));
            }
            GRIDWW_nCurrentRecord = (long)(GRIDWW_nCurrentRecord+1);
            if ( isFullAjaxMode( ) && ! bGXsfl_38_Refreshing )
            {
               context.DoAjaxLoad(38, GridwwRow);
            }
            AV35GXV1 = (int)(AV35GXV1+1);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV8Filter", AV8Filter);
      }

      protected void E121B2( )
      {
         /* Gridwwpaginationbar_Changepage Routine */
         if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Previous") == 0 )
         {
            AV17GridWWCurrentPage = (long)(AV17GridWWCurrentPage-1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GridWWCurrentPage), 10, 0)));
            subgridww_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Next") == 0 )
         {
            AV17GridWWCurrentPage = (long)(AV17GridWWCurrentPage+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GridWWCurrentPage), 10, 0)));
            subgridww_nextpage( ) ;
         }
         else
         {
            AV23PageToGo = (int)(NumberUtil.Val( Gridwwpaginationbar_Selectedpage, "."));
            AV17GridWWCurrentPage = AV23PageToGo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GridWWCurrentPage), 10, 0)));
            subgridww_gotopage( AV23PageToGo) ;
         }
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
      }

      protected void E131B2( )
      {
         /* Gridwwpaginationbar_Changerowsperpage Routine */
         subGridww_Rows = Gridwwpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV17GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GridWWCurrentPage), 10, 0)));
         subgridww_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV20IsAuthorized_BtnUpd;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamapplicationentry_Execute", out  GXt_boolean1) ;
         AV20IsAuthorized_BtnUpd = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20IsAuthorized_BtnUpd", AV20IsAuthorized_BtnUpd);
         if ( ! ( AV20IsAuthorized_BtnUpd ) )
         {
            edtavBtnupd_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtnupd_Visible), 5, 0)), !bGXsfl_38_Refreshing);
         }
         GXt_boolean1 = AV19IsAuthorized_BtnDlt;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamapplicationentry_Execute", out  GXt_boolean1) ;
         AV19IsAuthorized_BtnDlt = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19IsAuthorized_BtnDlt", AV19IsAuthorized_BtnDlt);
         if ( ! ( AV19IsAuthorized_BtnDlt ) )
         {
            edtavBtndlt_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtndlt_Visible), 5, 0)), !bGXsfl_38_Refreshing);
         }
         GXt_boolean1 = AV21IsAuthorized_GAMActionPermission;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamwwapppermissions_Execute", out  GXt_boolean1) ;
         AV21IsAuthorized_GAMActionPermission = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21IsAuthorized_GAMActionPermission", AV21IsAuthorized_GAMActionPermission);
         if ( ! ( AV21IsAuthorized_GAMActionPermission ) )
         {
            edtavGamactionpermission_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGamactionpermission_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGamactionpermission_Visible), 5, 0)), !bGXsfl_38_Refreshing);
         }
         GXt_boolean1 = AV28IsAuthorized_UAMenus;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamwwappmenus_Execute", out  GXt_boolean1) ;
         AV28IsAuthorized_UAMenus = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28IsAuthorized_UAMenus", AV28IsAuthorized_UAMenus);
         if ( ! ( AV28IsAuthorized_UAMenus ) )
         {
            edtavUamenus_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUamenus_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUamenus_Visible), 5, 0)), !bGXsfl_38_Refreshing);
         }
         GXt_boolean1 = AV24TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamapplicationentry_Execute", out  GXt_boolean1) ;
         AV24TempBoolean = GXt_boolean1;
         if ( ! ( AV24TempBoolean ) )
         {
            bttBtnadd_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnadd_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnadd_Visible), 5, 0)), true);
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
         PA1B2( ) ;
         WS1B2( ) ;
         WE1B2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20189201944241", true);
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
            context.AddJavascriptSource("gamwwapplications.js", "?20189201944244", false);
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
            context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_382( )
      {
         edtavGuid_Internalname = "vGUID_"+sGXsfl_38_idx;
         edtavId_Internalname = "vID_"+sGXsfl_38_idx;
         edtavBtnupd_Internalname = "vBTNUPD_"+sGXsfl_38_idx;
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_38_idx;
         edtavGamactionpermission_Internalname = "vGAMACTIONPERMISSION_"+sGXsfl_38_idx;
         edtavUamenus_Internalname = "vUAMENUS_"+sGXsfl_38_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_38_idx;
      }

      protected void SubsflControlProps_fel_382( )
      {
         edtavGuid_Internalname = "vGUID_"+sGXsfl_38_fel_idx;
         edtavId_Internalname = "vID_"+sGXsfl_38_fel_idx;
         edtavBtnupd_Internalname = "vBTNUPD_"+sGXsfl_38_fel_idx;
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_38_fel_idx;
         edtavGamactionpermission_Internalname = "vGAMACTIONPERMISSION_"+sGXsfl_38_fel_idx;
         edtavUamenus_Internalname = "vUAMENUS_"+sGXsfl_38_fel_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_38_fel_idx;
      }

      protected void sendrow_382( )
      {
         SubsflControlProps_382( ) ;
         WB1B0( ) ;
         if ( ( subGridww_Rows * 1 == 0 ) || ( nGXsfl_38_idx <= subGridww_Recordsperpage( ) * 1 ) )
         {
            GridwwRow = GXWebRow.GetNew(context,GridwwContainer);
            if ( subGridww_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGridww_Backstyle = 0;
               if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
               {
                  subGridww_Linesclass = subGridww_Class+"Odd";
               }
            }
            else if ( subGridww_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGridww_Backstyle = 0;
               subGridww_Backcolor = subGridww_Allbackcolor;
               if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
               {
                  subGridww_Linesclass = subGridww_Class+"Uniform";
               }
            }
            else if ( subGridww_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGridww_Backstyle = 1;
               if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
               {
                  subGridww_Linesclass = subGridww_Class+"Odd";
               }
               subGridww_Backcolor = (int)(0x0);
            }
            else if ( subGridww_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGridww_Backstyle = 1;
               if ( ((int)((nGXsfl_38_idx) % (2))) == 0 )
               {
                  subGridww_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
                  {
                     subGridww_Linesclass = subGridww_Class+"Even";
                  }
               }
               else
               {
                  subGridww_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGridww_Class, "") != 0 )
                  {
                     subGridww_Linesclass = subGridww_Class+"Odd";
                  }
               }
            }
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"GridWithPaginationBar GridWithBorderColor WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_38_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGuid_Internalname,StringUtil.RTrim( AV9GUID),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavGuid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavGuid_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)0,(bool)true,(String)"GAMGUID",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10Id), 12, 0, ",", "")),((edtavId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10Id), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV10Id), "ZZZZZZZZZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavId_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)0,(bool)true,(String)"GAMKeyNumLong",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtnupd_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV6BtnUpd_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV6BtnUpd))&&String.IsNullOrEmpty(StringUtil.RTrim( AV36Btnupd_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV6BtnUpd)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV6BtnUpd)) ? AV36Btnupd_GXI : context.PathToRelativeUrl( AV6BtnUpd));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtnupd_Internalname,(String)sImgUrl,(String)edtavBtnupd_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtnupd_Visible,(short)1,(String)"",(String)edtavBtnupd_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV6BtnUpd_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtndlt_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute";
            StyleString = "";
            AV13BtnDlt_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV13BtnDlt))&&String.IsNullOrEmpty(StringUtil.RTrim( AV37Btndlt_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV13BtnDlt)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV13BtnDlt)) ? AV37Btndlt_GXI : context.PathToRelativeUrl( AV13BtnDlt));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtndlt_Internalname,(String)sImgUrl,(String)edtavBtndlt_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtndlt_Visible,(short)1,(String)"",(String)edtavBtndlt_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV13BtnDlt_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavGamactionpermission_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV16GAMActionPermission_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV16GAMActionPermission))&&String.IsNullOrEmpty(StringUtil.RTrim( AV38Gamactionpermission_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV16GAMActionPermission)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV16GAMActionPermission)) ? AV38Gamactionpermission_GXI : context.PathToRelativeUrl( AV16GAMActionPermission));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavGamactionpermission_Internalname,(String)sImgUrl,(String)edtavGamactionpermission_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavGamactionpermission_Visible,(short)1,(String)"",(String)edtavGamactionpermission_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn hidden-xs",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV16GAMActionPermission_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUamenus_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV29UAMenus_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV29UAMenus))&&String.IsNullOrEmpty(StringUtil.RTrim( AV39Uamenus_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV29UAMenus)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV29UAMenus)) ? AV39Uamenus_GXI : context.PathToRelativeUrl( AV29UAMenus));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUamenus_Internalname,(String)sImgUrl,(String)edtavUamenus_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUamenus_Visible,(short)1,(String)"",(String)edtavUamenus_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV29UAMenus_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavName_Internalname,StringUtil.RTrim( AV11Name),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavName_Link,(String)"",(String)"",(String)"",(String)edtavName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavName_Enabled,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)254,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionLong",(String)"left",(bool)true});
            send_integrity_lvl_hashes1B2( ) ;
            GridwwContainer.AddRow(GridwwRow);
            nGXsfl_38_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_38_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_38_idx+1));
            sGXsfl_38_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_38_idx), 4, 0)), 4, "0");
            SubsflControlProps_382( ) ;
         }
         /* End function sendrow_382 */
      }

      protected void init_default_properties( )
      {
         bttBtnadd_Internalname = "BTNADD";
         divTableactions_Internalname = "TABLEACTIONS";
         edtavFilname_Internalname = "vFILNAME";
         divTablefilters_Internalname = "TABLEFILTERS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavGuid_Internalname = "vGUID";
         edtavId_Internalname = "vID";
         edtavBtnupd_Internalname = "vBTNUPD";
         edtavBtndlt_Internalname = "vBTNDLT";
         edtavGamactionpermission_Internalname = "vGAMACTIONPERMISSION";
         edtavUamenus_Internalname = "vUAMENUS";
         edtavName_Internalname = "vNAME";
         Gridwwpaginationbar_Internalname = "GRIDWWPAGINATIONBAR";
         edtavGridwwcurrentpage_Internalname = "vGRIDWWCURRENTPAGE";
         divHtml_gridwwpaginationbar_Internalname = "HTML_GRIDWWPAGINATIONBAR";
         divGridwwtablewithpaginationbar_Internalname = "GRIDWWTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         subGridww_Internalname = "GRIDWW";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavName_Jsonclick = "";
         edtavId_Jsonclick = "";
         edtavGuid_Jsonclick = "";
         edtavGridwwcurrentpage_Jsonclick = "";
         edtavGridwwcurrentpage_Visible = 1;
         subGridww_Allowcollapsing = 0;
         subGridww_Allowselection = 0;
         edtavName_Link = "";
         edtavUamenus_Tooltiptext = "";
         edtavUamenus_Link = "";
         edtavGamactionpermission_Tooltiptext = "Permissions";
         edtavGamactionpermission_Link = "";
         edtavBtndlt_Tooltiptext = "Delete";
         edtavBtndlt_Link = "";
         edtavBtnupd_Tooltiptext = "Update";
         edtavBtnupd_Link = "";
         edtavName_Enabled = 0;
         edtavUamenus_Visible = -1;
         edtavGamactionpermission_Visible = -1;
         edtavBtndlt_Visible = -1;
         edtavBtnupd_Visible = -1;
         edtavId_Enabled = 0;
         edtavGuid_Enabled = 0;
         subGridww_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGridww_Backcolorstyle = 0;
         edtavFilname_Jsonclick = "";
         edtavFilname_Enabled = 1;
         bttBtnadd_Visible = 1;
         Gridwwpaginationbar_Rowsperpagecaption = "WWP_PagingRowsPerPage";
         Gridwwpaginationbar_Emptygridcaption = "WWP_PagingEmptyGridCaption";
         Gridwwpaginationbar_Rowsperpageoptions = "5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50";
         Gridwwpaginationbar_Rowsperpageselectedvalue = 10;
         Gridwwpaginationbar_Rowsperpageselector = Convert.ToBoolean( -1);
         Gridwwpaginationbar_Emptygridclass = "PaginationBarEmptyGrid";
         Gridwwpaginationbar_Pagingcaptionposition = "Left";
         Gridwwpaginationbar_Pagingbuttonsposition = "Right";
         Gridwwpaginationbar_Pagestoshow = 5;
         Gridwwpaginationbar_Showlast = Convert.ToBoolean( 0);
         Gridwwpaginationbar_Shownext = Convert.ToBoolean( -1);
         Gridwwpaginationbar_Showprevious = Convert.ToBoolean( -1);
         Gridwwpaginationbar_Showfirst = Convert.ToBoolean( 0);
         Gridwwpaginationbar_Caption = "Página <CURRENT_PAGE> de <TOTAL_PAGES>";
         Gridwwpaginationbar_Next = "WWP_PagingNextCaption";
         Gridwwpaginationbar_Previous = "WWP_PagingPreviousCaption";
         Gridwwpaginationbar_Class = "PaginationBar";
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
         Form.Caption = "Applications ";
         subGridww_Rows = 0;
         edtavUamenus_Title = "";
         edtavGamactionpermission_Title = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'edtavGamactionpermission_Title',ctrl:'vGAMACTIONPERMISSION',prop:'Title'},{av:'edtavUamenus_Title',ctrl:'vUAMENUS',prop:'Title'},{av:'AV15FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV20IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV19IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV21IsAuthorized_GAMActionPermission',fld:'vISAUTHORIZED_GAMACTIONPERMISSION',pic:'',nv:false},{av:'AV28IsAuthorized_UAMenus',fld:'vISAUTHORIZED_UAMENUS',pic:'',nv:false},{av:'AV22IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false}],oparms:[{av:'AV21IsAuthorized_GAMActionPermission',fld:'vISAUTHORIZED_GAMACTIONPERMISSION',pic:'',nv:false},{av:'AV28IsAuthorized_UAMenus',fld:'vISAUTHORIZED_UAMENUS',pic:'',nv:false},{av:'AV20IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'edtavBtnupd_Visible',ctrl:'vBTNUPD',prop:'Visible'},{av:'AV19IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'edtavBtndlt_Visible',ctrl:'vBTNDLT',prop:'Visible'},{av:'edtavGamactionpermission_Visible',ctrl:'vGAMACTIONPERMISSION',prop:'Visible'},{av:'edtavUamenus_Visible',ctrl:'vUAMENUS',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDWW.LOAD","{handler:'E161B2',iparms:[{av:'AV15FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV20IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV19IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV21IsAuthorized_GAMActionPermission',fld:'vISAUTHORIZED_GAMACTIONPERMISSION',pic:'',nv:false},{av:'AV28IsAuthorized_UAMenus',fld:'vISAUTHORIZED_UAMENUS',pic:'',nv:false},{av:'AV22IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false}],oparms:[{av:'AV18GridWWPageCount',fld:'vGRIDWWPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0},{av:'AV10Id',fld:'vID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV9GUID',fld:'vGUID',pic:'',nv:''},{av:'AV11Name',fld:'vNAME',pic:'',nv:''},{av:'AV6BtnUpd',fld:'vBTNUPD',pic:'',nv:''},{av:'edtavBtnupd_Tooltiptext',ctrl:'vBTNUPD',prop:'Tooltiptext'},{av:'edtavBtnupd_Link',ctrl:'vBTNUPD',prop:'Link'},{av:'AV13BtnDlt',fld:'vBTNDLT',pic:'',nv:''},{av:'edtavBtndlt_Tooltiptext',ctrl:'vBTNDLT',prop:'Tooltiptext'},{av:'edtavBtndlt_Link',ctrl:'vBTNDLT',prop:'Link'},{av:'AV16GAMActionPermission',fld:'vGAMACTIONPERMISSION',pic:'',nv:''},{av:'edtavGamactionpermission_Tooltiptext',ctrl:'vGAMACTIONPERMISSION',prop:'Tooltiptext'},{av:'edtavGamactionpermission_Link',ctrl:'vGAMACTIONPERMISSION',prop:'Link'},{av:'AV29UAMenus',fld:'vUAMENUS',pic:'',nv:''},{av:'edtavUamenus_Tooltiptext',ctrl:'vUAMENUS',prop:'Tooltiptext'},{av:'edtavUamenus_Link',ctrl:'vUAMENUS',prop:'Link'},{av:'edtavName_Link',ctrl:'vNAME',prop:'Link'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEPAGE","{handler:'E121B2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'edtavGamactionpermission_Title',ctrl:'vGAMACTIONPERMISSION',prop:'Title'},{av:'edtavUamenus_Title',ctrl:'vUAMENUS',prop:'Title'},{av:'AV15FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV20IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV19IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV21IsAuthorized_GAMActionPermission',fld:'vISAUTHORIZED_GAMACTIONPERMISSION',pic:'',nv:false},{av:'AV28IsAuthorized_UAMenus',fld:'vISAUTHORIZED_UAMENUS',pic:'',nv:false},{av:'AV22IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false},{av:'Gridwwpaginationbar_Selectedpage',ctrl:'GRIDWWPAGINATIONBAR',prop:'SelectedPage'},{av:'AV17GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}],oparms:[{av:'AV17GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV21IsAuthorized_GAMActionPermission',fld:'vISAUTHORIZED_GAMACTIONPERMISSION',pic:'',nv:false},{av:'AV28IsAuthorized_UAMenus',fld:'vISAUTHORIZED_UAMENUS',pic:'',nv:false},{av:'AV20IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'edtavBtnupd_Visible',ctrl:'vBTNUPD',prop:'Visible'},{av:'AV19IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'edtavBtndlt_Visible',ctrl:'vBTNDLT',prop:'Visible'},{av:'edtavGamactionpermission_Visible',ctrl:'vGAMACTIONPERMISSION',prop:'Visible'},{av:'edtavUamenus_Visible',ctrl:'vUAMENUS',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E131B2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'edtavGamactionpermission_Title',ctrl:'vGAMACTIONPERMISSION',prop:'Title'},{av:'edtavUamenus_Title',ctrl:'vUAMENUS',prop:'Title'},{av:'AV15FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV20IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV19IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV21IsAuthorized_GAMActionPermission',fld:'vISAUTHORIZED_GAMACTIONPERMISSION',pic:'',nv:false},{av:'AV28IsAuthorized_UAMenus',fld:'vISAUTHORIZED_UAMENUS',pic:'',nv:false},{av:'AV22IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false},{av:'Gridwwpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDWWPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],oparms:[{av:'subGridww_Rows',ctrl:'GRIDWW',prop:'Rows'},{av:'AV17GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("'DOADD'","{handler:'E111B1',iparms:[],oparms:[]}");
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
         Gridwwpaginationbar_Selectedpage = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV15FilName = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtnadd_Jsonclick = "";
         GridwwContainer = new GXWebGrid( context);
         sStyleString = "";
         subGridww_Linesclass = "";
         GridwwColumn = new GXWebColumn();
         AV9GUID = "";
         AV6BtnUpd = "";
         AV13BtnDlt = "";
         AV16GAMActionPermission = "";
         AV29UAMenus = "";
         AV11Name = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV36Btnupd_GXI = "";
         AV37Btndlt_GXI = "";
         AV38Gamactionpermission_GXI = "";
         AV39Uamenus_GXI = "";
         AV8Filter = new SdtGAMApplicationFilter(context);
         AV25GAMApplications = new GXExternalCollection<SdtGAMApplication>( context, "SdtGAMApplication", "GeneXus.Programs");
         AV7Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV5Application = new SdtGAMApplication(context);
         GridwwRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         sImgUrl = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavGuid_Enabled = 0;
         edtavId_Enabled = 0;
         edtavName_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_38 ;
      private short nGXsfl_38_idx=1 ;
      private short GRIDWW_nEOF ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subGridww_Backcolorstyle ;
      private short subGridww_Titlebackstyle ;
      private short subGridww_Allowselection ;
      private short subGridww_Allowhovering ;
      private short subGridww_Allowcollapsing ;
      private short subGridww_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGridww_Backstyle ;
      private int Gridwwpaginationbar_Rowsperpageselectedvalue ;
      private int subGridww_Rows ;
      private int Gridwwpaginationbar_Pagestoshow ;
      private int bttBtnadd_Visible ;
      private int edtavFilname_Enabled ;
      private int subGridww_Titlebackcolor ;
      private int subGridww_Allbackcolor ;
      private int edtavBtnupd_Visible ;
      private int edtavBtndlt_Visible ;
      private int edtavGamactionpermission_Visible ;
      private int edtavUamenus_Visible ;
      private int edtavGuid_Enabled ;
      private int edtavId_Enabled ;
      private int edtavName_Enabled ;
      private int subGridww_Selectioncolor ;
      private int subGridww_Hoveringcolor ;
      private int edtavGridwwcurrentpage_Visible ;
      private int subGridww_Islastpage ;
      private int GRIDWW_nGridOutOfScope ;
      private int AV35GXV1 ;
      private int AV23PageToGo ;
      private int idxLst ;
      private int subGridww_Backcolor ;
      private long GRIDWW_nFirstRecordOnPage ;
      private long AV18GridWWPageCount ;
      private long AV10Id ;
      private long AV17GridWWCurrentPage ;
      private long GRIDWW_nCurrentRecord ;
      private long GRIDWW_nRecordCount ;
      private long AV27GridWWRecordCount ;
      private long AV26GridWWPageSize ;
      private String edtavGamactionpermission_Title ;
      private String edtavUamenus_Title ;
      private String Gridwwpaginationbar_Selectedpage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_38_idx="0001" ;
      private String edtavGamactionpermission_Internalname ;
      private String edtavUamenus_Internalname ;
      private String AV15FilName ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_tableheader_Width ;
      private String Dvpanel_tableheader_Cls ;
      private String Dvpanel_tableheader_Title ;
      private String Dvpanel_tableheader_Iconposition ;
      private String Gridwwpaginationbar_Class ;
      private String Gridwwpaginationbar_Previous ;
      private String Gridwwpaginationbar_Next ;
      private String Gridwwpaginationbar_Caption ;
      private String Gridwwpaginationbar_Pagingbuttonsposition ;
      private String Gridwwpaginationbar_Pagingcaptionposition ;
      private String Gridwwpaginationbar_Emptygridclass ;
      private String Gridwwpaginationbar_Rowsperpageoptions ;
      private String Gridwwpaginationbar_Emptygridcaption ;
      private String Gridwwpaginationbar_Rowsperpagecaption ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divTableactions_Internalname ;
      private String TempTags ;
      private String bttBtnadd_Internalname ;
      private String bttBtnadd_Jsonclick ;
      private String divTablefilters_Internalname ;
      private String edtavFilname_Internalname ;
      private String edtavFilname_Jsonclick ;
      private String divGridwwtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGridww_Internalname ;
      private String subGridww_Class ;
      private String subGridww_Linesclass ;
      private String AV9GUID ;
      private String edtavBtnupd_Link ;
      private String edtavBtnupd_Tooltiptext ;
      private String edtavBtndlt_Link ;
      private String edtavBtndlt_Tooltiptext ;
      private String edtavGamactionpermission_Link ;
      private String edtavGamactionpermission_Tooltiptext ;
      private String edtavUamenus_Link ;
      private String edtavUamenus_Tooltiptext ;
      private String AV11Name ;
      private String edtavName_Link ;
      private String divHtml_gridwwpaginationbar_Internalname ;
      private String edtavGridwwcurrentpage_Internalname ;
      private String edtavGridwwcurrentpage_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavGuid_Internalname ;
      private String edtavId_Internalname ;
      private String edtavBtnupd_Internalname ;
      private String edtavBtndlt_Internalname ;
      private String edtavName_Internalname ;
      private String Gridwwpaginationbar_Internalname ;
      private String sGXsfl_38_fel_idx="0001" ;
      private String ROClassString ;
      private String edtavGuid_Jsonclick ;
      private String edtavId_Jsonclick ;
      private String sImgUrl ;
      private String edtavName_Jsonclick ;
      private String Dvpanel_tableheader_Internalname ;
      private bool entryPointCalled ;
      private bool bGXsfl_38_Refreshing=false ;
      private bool AV20IsAuthorized_BtnUpd ;
      private bool AV19IsAuthorized_BtnDlt ;
      private bool AV21IsAuthorized_GAMActionPermission ;
      private bool AV28IsAuthorized_UAMenus ;
      private bool AV22IsAuthorized_Name ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableheader_Collapsible ;
      private bool Dvpanel_tableheader_Collapsed ;
      private bool Dvpanel_tableheader_Autowidth ;
      private bool Dvpanel_tableheader_Autoheight ;
      private bool Dvpanel_tableheader_Showcollapseicon ;
      private bool Dvpanel_tableheader_Autoscroll ;
      private bool Gridwwpaginationbar_Showfirst ;
      private bool Gridwwpaginationbar_Showprevious ;
      private bool Gridwwpaginationbar_Shownext ;
      private bool Gridwwpaginationbar_Showlast ;
      private bool Gridwwpaginationbar_Rowsperpageselector ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV24TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV6BtnUpd_IsBlob ;
      private bool AV13BtnDlt_IsBlob ;
      private bool AV16GAMActionPermission_IsBlob ;
      private bool AV29UAMenus_IsBlob ;
      private String AV36Btnupd_GXI ;
      private String AV37Btndlt_GXI ;
      private String AV38Gamactionpermission_GXI ;
      private String AV39Uamenus_GXI ;
      private String AV6BtnUpd ;
      private String AV13BtnDlt ;
      private String AV16GAMActionPermission ;
      private String AV29UAMenus ;
      private GXWebGrid GridwwContainer ;
      private GXWebRow GridwwRow ;
      private GXWebColumn GridwwColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMApplication> AV25GAMApplications ;
      private GXExternalCollection<SdtGAMError> AV7Errors ;
      private GXWebForm Form ;
      private SdtGAMApplication AV5Application ;
      private SdtGAMApplicationFilter AV8Filter ;
   }

}
