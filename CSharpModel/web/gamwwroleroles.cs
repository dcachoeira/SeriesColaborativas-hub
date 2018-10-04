/*
               File: GAMWWRoleRoles
        Description: Role's roles
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:41:16.13
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
   public class gamwwroleroles : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamwwroleroles( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamwwroleroles( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_RoleId ,
                           long aP1_RoleIdAux )
      {
         this.AV20RoleId = aP0_RoleId;
         this.AV21RoleIdAux = aP1_RoleIdAux;
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
               nRC_GXsfl_45 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_45_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_45_idx = GetNextPar( );
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
               AV21RoleIdAux = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV12FilName = GetNextPar( );
               AV11FilExternalId = GetNextPar( );
               AV20RoleId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridww_refresh( subGridww_Rows, AV21RoleIdAux, AV12FilName, AV11FilExternalId, AV20RoleId) ;
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
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV20RoleId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20RoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20RoleId), 12, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20RoleId), "ZZZZZZZZZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV21RoleIdAux = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21RoleIdAux", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21RoleIdAux), 12, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21RoleIdAux), "ZZZZZZZZZZZ9"), context));
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
         PA0T2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0T2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019411636", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamwwroleroles.aspx") + "?" + UrlEncode("" +AV20RoleId) + "," + UrlEncode("" +AV21RoleIdAux)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_45", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_45), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDWWPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29GridWWPageCount), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vROLEIDAUX", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21RoleIdAux), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21RoleIdAux), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20RoleId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20RoleId), "ZZZZZZZZZZZ9"), context));
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
            WE0T2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0T2( ) ;
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
         return formatLink("gamwwroleroles.aspx") + "?" + UrlEncode("" +AV20RoleId) + "," + UrlEncode("" +AV21RoleIdAux) ;
      }

      public override String GetPgmname( )
      {
         return "GAMWWRoleRoles" ;
      }

      public override String GetPgmdesc( )
      {
         return "Role's roles" ;
      }

      protected void WB0T0( )
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", divTablemain_Height, "px", "TableMainPopup", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-7", "left", "top", "", "", "div");
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
            GxWebStd.gx_button_ctrl( context, bttBtnback_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(45), 2, 0)+","+"null"+");", "Back", bttBtnback_Jsonclick, 7, "Back", "", StyleString, ClassString, bttBtnback_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e110t1_client"+"'", TempTags, "", 2, "HLP_GAMWWRoleRoles.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnadd_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(45), 2, 0)+","+"null"+");", "Insert", bttBtnadd_Jsonclick, 7, "Insert", "", StyleString, ClassString, bttBtnadd_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e120t1_client"+"'", TempTags, "", 2, "HLP_GAMWWRoleRoles.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-5", "left", "top", "", "", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_45_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFilname_Internalname, StringUtil.RTrim( AV12FilName), StringUtil.RTrim( context.localUtil.Format( AV12FilName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFilname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavFilname_Enabled, 0, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMWWRoleRoles.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellFormGroupMarginBottom5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavFilexternalid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFilexternalid_Internalname, "External Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_45_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFilexternalid_Internalname, StringUtil.RTrim( AV11FilExternalId), StringUtil.RTrim( context.localUtil.Format( AV11FilExternalId, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFilexternalid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavFilexternalid_Enabled, 0, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMWWRoleRoles.htm");
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
               context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"DivS\" data-gxgridid=\"45\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
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
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV5BtnDlt));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtndlt_Tooltiptext));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15Id), 12, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavId_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV18Name));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavName_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowselection), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Selectioncolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowhovering), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Hoveringcolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowcollapsing), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 45 )
         {
            wbEnd = 0;
            nRC_GXsfl_45 = (short)(nGXsfl_45_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_45_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGridwwcurrentpage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28GridWWCurrentPage), 10, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV28GridWWCurrentPage), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGridwwcurrentpage_Jsonclick, 0, "Attribute", "", "", "", "", edtavGridwwcurrentpage_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMWWRoleRoles.htm");
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

      protected void START0T2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Role's roles", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0T0( ) ;
      }

      protected void WS0T2( )
      {
         START0T2( ) ;
         EVT0T2( ) ;
      }

      protected void EVT0T2( )
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
                              E130T2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E140T2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "GRIDWW.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VBTNDLT.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VBTNDLT.CLICK") == 0 ) )
                           {
                              nGXsfl_45_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
                              SubsflControlProps_452( ) ;
                              AV5BtnDlt = cgiGet( edtavBtndlt_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5BtnDlt)) ? AV43Btndlt_GXI : context.convertURL( context.PathToRelativeUrl( AV5BtnDlt))), !bGXsfl_45_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "SrcSet", context.GetImageSrcSet( AV5BtnDlt), true);
                              if ( ( ( context.localUtil.CToN( cgiGet( edtavId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavId_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vID");
                                 GX_FocusControl = edtavId_Internalname;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true;
                                 AV15Id = 0;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV15Id), 12, 0)));
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID"+"_"+sGXsfl_45_idx, GetSecureSignedToken( sGXsfl_45_idx, context.localUtil.Format( (decimal)(AV15Id), "ZZZZZZZZZZZ9"), context));
                              }
                              else
                              {
                                 AV15Id = (long)(context.localUtil.CToN( cgiGet( edtavId_Internalname), ",", "."));
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV15Id), 12, 0)));
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID"+"_"+sGXsfl_45_idx, GetSecureSignedToken( sGXsfl_45_idx, context.localUtil.Format( (decimal)(AV15Id), "ZZZZZZZZZZZ9"), context));
                              }
                              AV18Name = cgiGet( edtavName_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV18Name);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E150T2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E160T2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDWW.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E170T2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VBTNDLT.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E180T2 ();
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

      protected void WE0T2( )
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

      protected void PA0T2( )
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
         SubsflControlProps_452( ) ;
         while ( nGXsfl_45_idx <= nRC_GXsfl_45 )
         {
            sendrow_452( ) ;
            nGXsfl_45_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_45_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_45_idx+1));
            sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
            SubsflControlProps_452( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridwwContainer));
         /* End function gxnrGridww_newrow */
      }

      protected void gxgrGridww_refresh( int subGridww_Rows ,
                                         long AV21RoleIdAux ,
                                         String AV12FilName ,
                                         String AV11FilExternalId ,
                                         long AV20RoleId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         GRIDWW_nCurrentRecord = 0;
         RF0T2( ) ;
         /* End function gxgrGridww_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV15Id), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15Id), 12, 0, ".", "")));
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
         RF0T2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
         edtavName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
      }

      protected void RF0T2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridwwContainer.ClearRows();
         }
         wbStart = 45;
         /* Execute user event: Refresh */
         E160T2 ();
         nGXsfl_45_idx = 1;
         sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
         SubsflControlProps_452( ) ;
         bGXsfl_45_Refreshing = true;
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
            SubsflControlProps_452( ) ;
            E170T2 ();
            if ( ( GRIDWW_nCurrentRecord > 0 ) && ( GRIDWW_nGridOutOfScope == 0 ) && ( nGXsfl_45_idx == 1 ) )
            {
               GRIDWW_nCurrentRecord = 0;
               GRIDWW_nGridOutOfScope = 1;
               subgridww_firstpage( ) ;
               E170T2 ();
            }
            wbEnd = 45;
            WB0T0( ) ;
         }
         bGXsfl_45_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0T2( )
      {
         GxWebStd.gx_hidden_field( context, "vROLEIDAUX", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21RoleIdAux), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21RoleIdAux), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20RoleId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20RoleId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vID"+"_"+sGXsfl_45_idx, GetSecureSignedToken( sGXsfl_45_idx, context.localUtil.Format( (decimal)(AV15Id), "ZZZZZZZZZZZ9"), context));
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
            gxgrGridww_refresh( subGridww_Rows, AV21RoleIdAux, AV12FilName, AV11FilExternalId, AV20RoleId) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV21RoleIdAux, AV12FilName, AV11FilExternalId, AV20RoleId) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV21RoleIdAux, AV12FilName, AV11FilExternalId, AV20RoleId) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV21RoleIdAux, AV12FilName, AV11FilExternalId, AV20RoleId) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV21RoleIdAux, AV12FilName, AV11FilExternalId, AV20RoleId) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP0T0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
         edtavName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_45_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E150T2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV12FilName = cgiGet( edtavFilname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12FilName", AV12FilName);
            AV11FilExternalId = cgiGet( edtavFilexternalid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11FilExternalId", AV11FilExternalId);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vGRIDWWCURRENTPAGE");
               GX_FocusControl = edtavGridwwcurrentpage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV28GridWWCurrentPage = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridWWCurrentPage), 10, 0)));
            }
            else
            {
               AV28GridWWCurrentPage = (long)(context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridWWCurrentPage), 10, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_45 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_45"), ",", "."));
            AV29GridWWPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDWWPAGECOUNT"), ",", "."));
            AV21RoleIdAux = (long)(context.localUtil.CToN( cgiGet( "vROLEIDAUX"), ",", "."));
            AV20RoleId = (long)(context.localUtil.CToN( cgiGet( "vROLEID"), ",", "."));
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
         E150T2 ();
         if (returnInSub) return;
      }

      protected void E150T2( )
      {
         /* Start Routine */
         AV14GAMRole.load( AV21RoleIdAux);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21RoleIdAux", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21RoleIdAux), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21RoleIdAux), "ZZZZZZZZZZZ9"), context));
         Form.Caption = "Roles of Role: "+AV14GAMRole.gxTpr_Name;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         divTablemain_Height = 400;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGridww_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV28GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridWWCurrentPage), 10, 0)));
         edtavGridwwcurrentpage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGridwwcurrentpage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGridwwcurrentpage_Visible), 5, 0)), true);
         AV29GridWWPageCount = -1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridWWPageCount), 10, 0)));
         Gridwwpaginationbar_Rowsperpageselectedvalue = subGridww_Rows;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Gridwwpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridwwpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E160T2( )
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
         /*  Sending Event outputs  */
      }

      private void E170T2( )
      {
         /* Gridww_Load Routine */
         AV14GAMRole.load( AV21RoleIdAux);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21RoleIdAux", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21RoleIdAux), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21RoleIdAux), "ZZZZZZZZZZZ9"), context));
         AV13Filter.gxTpr_Name = "%"+AV12FilName;
         AV13Filter.gxTpr_Externalid = "%"+AV11FilExternalId;
         AV33Roles = AV14GAMRole.getchildren(AV13Filter, ref  AV10Errors);
         if ( AV33Roles.Count == 0 )
         {
            AV29GridWWPageCount = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridWWPageCount), 10, 0)));
         }
         else
         {
            AV29GridWWPageCount = (long)((AV33Roles.Count/ (decimal)(9))+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridWWPageCount), 10, 0)));
         }
         AV35GridWWRecordCount = AV33Roles.Count;
         AV34GridWWPageSize = 9;
         AV42GXV1 = 1;
         while ( AV42GXV1 <= AV33Roles.Count )
         {
            AV19Role = ((SdtGAMRole)AV33Roles.Item(AV42GXV1));
            AV15Id = AV19Role.gxTpr_Id;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV15Id), 12, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID"+"_"+sGXsfl_45_idx, GetSecureSignedToken( sGXsfl_45_idx, context.localUtil.Format( (decimal)(AV15Id), "ZZZZZZZZZZZ9"), context));
            AV18Name = AV19Role.gxTpr_Name;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV18Name);
            AV5BtnDlt = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtndlt_Internalname, AV5BtnDlt);
            AV43Btndlt_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
            edtavBtndlt_Tooltiptext = "";
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 45;
            }
            if ( ( subGridww_Islastpage == 1 ) || ( subGridww_Rows == 0 ) || ( ( GRIDWW_nCurrentRecord >= GRIDWW_nFirstRecordOnPage ) && ( GRIDWW_nCurrentRecord < GRIDWW_nFirstRecordOnPage + subGridww_Recordsperpage( ) ) ) )
            {
               sendrow_452( ) ;
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
            if ( isFullAjaxMode( ) && ! bGXsfl_45_Refreshing )
            {
               context.DoAjaxLoad(45, GridwwRow);
            }
            AV42GXV1 = (int)(AV42GXV1+1);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13Filter", AV13Filter);
      }

      protected void E130T2( )
      {
         /* Gridwwpaginationbar_Changepage Routine */
         if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Previous") == 0 )
         {
            AV28GridWWCurrentPage = (long)(AV28GridWWCurrentPage-1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridWWCurrentPage), 10, 0)));
            subgridww_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Next") == 0 )
         {
            AV28GridWWCurrentPage = (long)(AV28GridWWCurrentPage+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridWWCurrentPage), 10, 0)));
            subgridww_nextpage( ) ;
         }
         else
         {
            AV30PageToGo = (int)(NumberUtil.Val( Gridwwpaginationbar_Selectedpage, "."));
            AV28GridWWCurrentPage = AV30PageToGo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridWWCurrentPage), 10, 0)));
            subgridww_gotopage( AV30PageToGo) ;
         }
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
      }

      protected void E140T2( )
      {
         /* Gridwwpaginationbar_Changerowsperpage Routine */
         subGridww_Rows = Gridwwpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV28GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridWWCurrentPage), 10, 0)));
         subgridww_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV32TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamwwroles_Execute", out  GXt_boolean1) ;
         AV32TempBoolean = GXt_boolean1;
         if ( ! ( AV32TempBoolean ) )
         {
            bttBtnback_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnback_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnback_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV32TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamroleselect_Execute", out  GXt_boolean1) ;
         AV32TempBoolean = GXt_boolean1;
         if ( ! ( AV32TempBoolean ) )
         {
            bttBtnadd_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnadd_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnadd_Visible), 5, 0)), true);
         }
      }

      protected void E180T2( )
      {
         /* Btndlt_Click Routine */
         AV14GAMRole.load( AV21RoleIdAux);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21RoleIdAux", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21RoleIdAux), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21RoleIdAux), "ZZZZZZZZZZZ9"), context));
         AV16isOK = AV14GAMRole.deleterolebyid(AV15Id, ref  AV10Errors);
         if ( AV16isOK )
         {
            pr_gam.commit( "GAMWWRoleRoles");
            pr_default.commit( "GAMWWRoleRoles");
         }
         else
         {
            AV44GXV2 = 1;
            while ( AV44GXV2 <= AV10Errors.Count )
            {
               AV9Error = ((SdtGAMError)AV10Errors.Item(AV44GXV2));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV9Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV9Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
               AV44GXV2 = (int)(AV44GXV2+1);
            }
         }
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV20RoleId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20RoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20RoleId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20RoleId), "ZZZZZZZZZZZ9"), context));
         AV21RoleIdAux = Convert.ToInt64(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21RoleIdAux", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21RoleIdAux), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEIDAUX", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21RoleIdAux), "ZZZZZZZZZZZ9"), context));
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
         PA0T2( ) ;
         WS0T2( ) ;
         WE0T2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019412159", true);
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
            context.AddJavascriptSource("gamwwroleroles.js", "?201892019412160", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
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

      protected void SubsflControlProps_452( )
      {
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_45_idx;
         edtavId_Internalname = "vID_"+sGXsfl_45_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_45_idx;
      }

      protected void SubsflControlProps_fel_452( )
      {
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_45_fel_idx;
         edtavId_Internalname = "vID_"+sGXsfl_45_fel_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_45_fel_idx;
      }

      protected void sendrow_452( )
      {
         SubsflControlProps_452( ) ;
         WB0T0( ) ;
         if ( ( subGridww_Rows * 1 == 0 ) || ( nGXsfl_45_idx <= subGridww_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_45_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_45_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavBtndlt_Enabled!=0)&&(edtavBtndlt_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 46,'',false,'',45)\"" : " ");
            ClassString = "DeleteAttribute";
            StyleString = "";
            AV5BtnDlt_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5BtnDlt))&&String.IsNullOrEmpty(StringUtil.RTrim( AV43Btndlt_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5BtnDlt)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5BtnDlt)) ? AV43Btndlt_GXI : context.PathToRelativeUrl( AV5BtnDlt));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtndlt_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavBtndlt_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavBtndlt_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVBTNDLT.CLICK."+sGXsfl_45_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV5BtnDlt_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 47,'',false,'"+sGXsfl_45_idx+"',45)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15Id), 12, 0, ",", "")),((edtavId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV15Id), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV15Id), "ZZZZZZZZZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,47);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavId_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)45,(short)1,(short)-1,(short)0,(bool)true,(String)"GAMKeyNumLong",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavName_Enabled!=0)&&(edtavName_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 48,'',false,'"+sGXsfl_45_idx+"',45)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavName_Internalname,StringUtil.RTrim( AV18Name),(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavName_Enabled!=0)&&(edtavName_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,48);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+"e190t2_client"+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavName_Jsonclick,(short)7,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavName_Enabled,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)254,(short)0,(short)0,(short)45,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionLong",(String)"left",(bool)true});
            send_integrity_lvl_hashes0T2( ) ;
            GridwwContainer.AddRow(GridwwRow);
            nGXsfl_45_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_45_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_45_idx+1));
            sGXsfl_45_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_45_idx), 4, 0)), 4, "0");
            SubsflControlProps_452( ) ;
         }
         /* End function sendrow_452 */
      }

      protected void init_default_properties( )
      {
         bttBtnback_Internalname = "BTNBACK";
         bttBtnadd_Internalname = "BTNADD";
         divTableactions_Internalname = "TABLEACTIONS";
         edtavFilname_Internalname = "vFILNAME";
         edtavFilexternalid_Internalname = "vFILEXTERNALID";
         divTablefilters_Internalname = "TABLEFILTERS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavBtndlt_Internalname = "vBTNDLT";
         edtavId_Internalname = "vID";
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
         edtavName_Visible = -1;
         edtavId_Jsonclick = "";
         edtavId_Visible = 0;
         edtavBtndlt_Jsonclick = "";
         edtavBtndlt_Visible = -1;
         edtavBtndlt_Enabled = 1;
         edtavGridwwcurrentpage_Jsonclick = "";
         edtavGridwwcurrentpage_Visible = 1;
         subGridww_Allowcollapsing = 0;
         subGridww_Allowselection = 0;
         edtavBtndlt_Tooltiptext = "";
         edtavName_Enabled = 1;
         edtavId_Enabled = 1;
         subGridww_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGridww_Backcolorstyle = 0;
         edtavFilexternalid_Jsonclick = "";
         edtavFilexternalid_Enabled = 1;
         edtavFilname_Jsonclick = "";
         edtavFilname_Enabled = 1;
         bttBtnadd_Visible = 1;
         bttBtnback_Visible = 1;
         divTablemain_Height = 0;
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
         Form.Caption = "Role's roles";
         subGridww_Rows = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV12FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV11FilExternalId',fld:'vFILEXTERNALID',pic:'',nv:''},{av:'AV21RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV20RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{ctrl:'BTNBACK',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDWW.LOAD","{handler:'E170T2',iparms:[{av:'AV21RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV12FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV11FilExternalId',fld:'vFILEXTERNALID',pic:'',nv:''}],oparms:[{av:'AV29GridWWPageCount',fld:'vGRIDWWPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0},{av:'AV15Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV18Name',fld:'vNAME',pic:'',nv:''},{av:'AV5BtnDlt',fld:'vBTNDLT',pic:'',nv:''},{av:'edtavBtndlt_Tooltiptext',ctrl:'vBTNDLT',prop:'Tooltiptext'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEPAGE","{handler:'E130T2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV21RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV12FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV11FilExternalId',fld:'vFILEXTERNALID',pic:'',nv:''},{av:'AV20RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'Gridwwpaginationbar_Selectedpage',ctrl:'GRIDWWPAGINATIONBAR',prop:'SelectedPage'},{av:'AV28GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}],oparms:[{av:'AV28GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{ctrl:'BTNBACK',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E140T2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV21RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV12FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV11FilExternalId',fld:'vFILEXTERNALID',pic:'',nv:''},{av:'AV20RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'Gridwwpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDWWPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],oparms:[{av:'subGridww_Rows',ctrl:'GRIDWW',prop:'Rows'},{av:'AV28GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("'DOBACK'","{handler:'E110T1',iparms:[],oparms:[]}");
         setEventMetadata("'DOADD'","{handler:'E120T1',iparms:[{av:'AV20RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV21RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("VBTNDLT.CLICK","{handler:'E180T2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV21RoleIdAux',fld:'vROLEIDAUX',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV12FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV11FilExternalId',fld:'vFILEXTERNALID',pic:'',nv:''},{av:'AV20RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV15Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{ctrl:'BTNBACK',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("VNAME.CLICK","{handler:'E190T2',iparms:[{av:'AV15Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
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
         AV12FilName = "";
         AV11FilExternalId = "";
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
         bttBtnback_Jsonclick = "";
         bttBtnadd_Jsonclick = "";
         GridwwContainer = new GXWebGrid( context);
         sStyleString = "";
         subGridww_Linesclass = "";
         GridwwColumn = new GXWebColumn();
         AV5BtnDlt = "";
         AV18Name = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV43Btndlt_GXI = "";
         AV14GAMRole = new SdtGAMRole(context);
         AV13Filter = new SdtGAMRoleFilter(context);
         AV33Roles = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         AV10Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV19Role = new SdtGAMRole(context);
         GridwwRow = new GXWebRow();
         AV9Error = new SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamwwroleroles__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamwwroleroles__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavId_Enabled = 0;
         edtavName_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_45 ;
      private short nGXsfl_45_idx=1 ;
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
      private int divTablemain_Height ;
      private int bttBtnback_Visible ;
      private int bttBtnadd_Visible ;
      private int edtavFilname_Enabled ;
      private int edtavFilexternalid_Enabled ;
      private int subGridww_Titlebackcolor ;
      private int subGridww_Allbackcolor ;
      private int edtavId_Enabled ;
      private int edtavName_Enabled ;
      private int subGridww_Selectioncolor ;
      private int subGridww_Hoveringcolor ;
      private int edtavGridwwcurrentpage_Visible ;
      private int subGridww_Islastpage ;
      private int GRIDWW_nGridOutOfScope ;
      private int AV42GXV1 ;
      private int AV30PageToGo ;
      private int AV44GXV2 ;
      private int idxLst ;
      private int subGridww_Backcolor ;
      private int edtavBtndlt_Enabled ;
      private int edtavBtndlt_Visible ;
      private int edtavId_Visible ;
      private int edtavName_Visible ;
      private long AV20RoleId ;
      private long AV21RoleIdAux ;
      private long wcpOAV20RoleId ;
      private long wcpOAV21RoleIdAux ;
      private long GRIDWW_nFirstRecordOnPage ;
      private long AV29GridWWPageCount ;
      private long AV15Id ;
      private long AV28GridWWCurrentPage ;
      private long GRIDWW_nCurrentRecord ;
      private long GRIDWW_nRecordCount ;
      private long AV35GridWWRecordCount ;
      private long AV34GridWWPageSize ;
      private String Gridwwpaginationbar_Selectedpage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_45_idx="0001" ;
      private String AV12FilName ;
      private String AV11FilExternalId ;
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
      private String bttBtnback_Internalname ;
      private String bttBtnback_Jsonclick ;
      private String bttBtnadd_Internalname ;
      private String bttBtnadd_Jsonclick ;
      private String divTablefilters_Internalname ;
      private String edtavFilname_Internalname ;
      private String edtavFilname_Jsonclick ;
      private String edtavFilexternalid_Internalname ;
      private String edtavFilexternalid_Jsonclick ;
      private String divGridwwtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGridww_Internalname ;
      private String subGridww_Class ;
      private String subGridww_Linesclass ;
      private String edtavBtndlt_Tooltiptext ;
      private String AV18Name ;
      private String divHtml_gridwwpaginationbar_Internalname ;
      private String edtavGridwwcurrentpage_Internalname ;
      private String edtavGridwwcurrentpage_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavBtndlt_Internalname ;
      private String edtavId_Internalname ;
      private String edtavName_Internalname ;
      private String Gridwwpaginationbar_Internalname ;
      private String sGXsfl_45_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavBtndlt_Jsonclick ;
      private String ROClassString ;
      private String edtavId_Jsonclick ;
      private String edtavName_Jsonclick ;
      private String Dvpanel_tableheader_Internalname ;
      private bool entryPointCalled ;
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
      private bool bGXsfl_45_Refreshing=false ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV32TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV16isOK ;
      private bool AV5BtnDlt_IsBlob ;
      private String AV43Btndlt_GXI ;
      private String AV5BtnDlt ;
      private GXWebGrid GridwwContainer ;
      private GXWebRow GridwwRow ;
      private GXWebColumn GridwwColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMError> AV10Errors ;
      private GXExternalCollection<SdtGAMRole> AV33Roles ;
      private GXWebForm Form ;
      private SdtGAMError AV9Error ;
      private SdtGAMRoleFilter AV13Filter ;
      private SdtGAMRole AV14GAMRole ;
      private SdtGAMRole AV19Role ;
   }

   public class gamwwroleroles__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamwwroleroles__default : DataStoreHelperBase, IDataStoreHelper
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
