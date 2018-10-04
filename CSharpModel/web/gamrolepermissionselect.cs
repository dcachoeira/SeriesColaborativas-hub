/*
               File: GAMRolePermissionSelect
        Description: Application permission select to role
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:44:47.14
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
   public class gamrolepermissionselect : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamrolepermissionselect( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamrolepermissionselect( IGxContext context )
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
                           long aP1_ApplicationId )
      {
         this.AV24RoleId = aP0_RoleId;
         this.AV8ApplicationId = aP1_ApplicationId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavPermissionaccesstype = new GXCombobox();
         cmbavBoolenfilter = new GXCombobox();
         chkavSelect = new GXCheckbox();
         cmbavAccess = new GXCombobox();
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
               nRC_GXsfl_43 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_43_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_43_idx = GetNextPar( );
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
               AV8ApplicationId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV28FilName = GetNextPar( );
               AV20PermissionAccessType = GetNextPar( );
               AV9BoolenFilter = GetNextPar( );
               AV31IsAuthorized_Name = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV24RoleId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridww_refresh( subGridww_Rows, AV8ApplicationId, AV28FilName, AV20PermissionAccessType, AV9BoolenFilter, AV31IsAuthorized_Name, AV24RoleId) ;
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
               AV24RoleId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24RoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24RoleId), 12, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV24RoleId), "ZZZZZZZZZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV8ApplicationId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ApplicationId), "ZZZZZZZZZZZ9"), context));
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
         PA1G2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1G2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019444738", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamrolepermissionselect.aspx") + "?" + UrlEncode("" +AV24RoleId) + "," + UrlEncode("" +AV8ApplicationId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_43", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_43), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDWWPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30GridWWPageCount), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vAPPLICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8ApplicationId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ApplicationId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_NAME", AV31IsAuthorized_Name);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV31IsAuthorized_Name, context));
         GxWebStd.gx_hidden_field( context, "vROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24RoleId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV24RoleId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_boolean_hidden_field( context, "vISOK", AV17isOK);
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
            WE1G2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1G2( ) ;
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
         return formatLink("gamrolepermissionselect.aspx") + "?" + UrlEncode("" +AV24RoleId) + "," + UrlEncode("" +AV8ApplicationId) ;
      }

      public override String GetPgmname( )
      {
         return "GAMRolePermissionSelect" ;
      }

      public override String GetPgmdesc( )
      {
         return "Application permission select to role" ;
      }

      protected void WB1G0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-7", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableactions_Internalname, 1, 0, "px", 0, "px", "TableCellsWidthAuto", "left", "top", "", "", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-5 CellFloatRight", "left", "top", "", "", "div");
            wb_table1_22_1G2( true) ;
         }
         else
         {
            wb_table1_22_1G2( false) ;
         }
         return  ;
      }

      protected void wb_table1_22_1G2e( bool wbgen )
      {
         if ( wbgen )
         {
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
               context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"DivS\" data-gxgridid=\"43\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(50), 4, 0))+"px"+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Permission Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "GUID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Key Numeric Long") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Description") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Access type") ;
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
               GridwwColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV27Select));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV18Name));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavName_Enabled), 5, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavName_Link));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV16ID));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavId_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7AppId), 12, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavAppid_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV12Dsc));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDsc_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV6Access));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowselection), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Selectioncolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowhovering), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Hoveringcolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowcollapsing), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 43 )
         {
            wbEnd = 0;
            nRC_GXsfl_43 = (short)(nGXsfl_43_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_43_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGridwwcurrentpage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29GridWWCurrentPage), 10, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV29GridWWCurrentPage), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGridwwcurrentpage_Jsonclick, 0, "Attribute", "", "", "", "", edtavGridwwcurrentpage_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMRolePermissionSelect.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnadd_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(43), 2, 0)+","+"null"+");", "Add Selected", bttBtnadd_Jsonclick, 5, "Add Selected", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOADD\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(43), 2, 0)+","+"null"+");", "Fechar", bttBtncancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMRolePermissionSelect.htm");
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

      protected void START1G2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Application permission select to role", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1G0( ) ;
      }

      protected void WS1G2( )
      {
         START1G2( ) ;
         EVT1G2( ) ;
      }

      protected void EVT1G2( )
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
                              E111G2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E121G2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOADD'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoAdd' */
                              E131G2 ();
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
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "GRIDWW.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_43_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_43_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_idx), 4, 0)), 4, "0");
                              SubsflControlProps_432( ) ;
                              AV27Select = StringUtil.StrToBool( cgiGet( chkavSelect_Internalname));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavSelect_Internalname, AV27Select);
                              AV18Name = cgiGet( edtavName_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV18Name);
                              AV16ID = cgiGet( edtavId_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, AV16ID);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID"+"_"+sGXsfl_43_idx, GetSecureSignedToken( sGXsfl_43_idx, StringUtil.RTrim( context.localUtil.Format( AV16ID, "")), context));
                              if ( ( ( context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vAPPID");
                                 GX_FocusControl = edtavAppid_Internalname;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true;
                                 AV7AppId = 0;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAppid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV7AppId), 12, 0)));
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPID"+"_"+sGXsfl_43_idx, GetSecureSignedToken( sGXsfl_43_idx, context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9"), context));
                              }
                              else
                              {
                                 AV7AppId = (long)(context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", "."));
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAppid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV7AppId), 12, 0)));
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPID"+"_"+sGXsfl_43_idx, GetSecureSignedToken( sGXsfl_43_idx, context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9"), context));
                              }
                              AV12Dsc = cgiGet( edtavDsc_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDsc_Internalname, AV12Dsc);
                              cmbavAccess.Name = cmbavAccess_Internalname;
                              cmbavAccess.CurrentValue = cgiGet( cmbavAccess_Internalname);
                              AV6Access = cgiGet( cmbavAccess_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavAccess_Internalname, AV6Access);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E141G2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E151G2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDWW.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E161G2 ();
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

      protected void WE1G2( )
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

      protected void PA1G2( )
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
            cmbavPermissionaccesstype.Name = "vPERMISSIONACCESSTYPE";
            cmbavPermissionaccesstype.WebTags = "";
            cmbavPermissionaccesstype.addItem("", "(Nenhum)", 0);
            cmbavPermissionaccesstype.addItem("A", "Allow", 0);
            cmbavPermissionaccesstype.addItem("D", "Deny", 0);
            cmbavPermissionaccesstype.addItem("R", "Restricted", 0);
            if ( cmbavPermissionaccesstype.ItemCount > 0 )
            {
               AV20PermissionAccessType = cmbavPermissionaccesstype.getValidValue(AV20PermissionAccessType);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PermissionAccessType", AV20PermissionAccessType);
            }
            cmbavBoolenfilter.Name = "vBOOLENFILTER";
            cmbavBoolenfilter.WebTags = "";
            cmbavBoolenfilter.addItem("A", "All", 0);
            cmbavBoolenfilter.addItem("T", "Yes", 0);
            cmbavBoolenfilter.addItem("F", "No", 0);
            if ( cmbavBoolenfilter.ItemCount > 0 )
            {
               AV9BoolenFilter = cmbavBoolenfilter.getValidValue(AV9BoolenFilter);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9BoolenFilter", AV9BoolenFilter);
            }
            GXCCtl = "vSELECT_" + sGXsfl_43_idx;
            chkavSelect.Name = GXCCtl;
            chkavSelect.WebTags = "";
            chkavSelect.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSelect_Internalname, "TitleCaption", chkavSelect.Caption, !bGXsfl_43_Refreshing);
            chkavSelect.CheckedValue = "false";
            GXCCtl = "vACCESS_" + sGXsfl_43_idx;
            cmbavAccess.Name = GXCCtl;
            cmbavAccess.WebTags = "";
            cmbavAccess.addItem("A", "Allow", 0);
            cmbavAccess.addItem("D", "Deny", 0);
            cmbavAccess.addItem("R", "Restricted", 0);
            if ( cmbavAccess.ItemCount > 0 )
            {
               AV6Access = cmbavAccess.getValidValue(AV6Access);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavAccess_Internalname, AV6Access);
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
         SubsflControlProps_432( ) ;
         while ( nGXsfl_43_idx <= nRC_GXsfl_43 )
         {
            sendrow_432( ) ;
            nGXsfl_43_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_43_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_43_idx+1));
            sGXsfl_43_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_idx), 4, 0)), 4, "0");
            SubsflControlProps_432( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridwwContainer));
         /* End function gxnrGridww_newrow */
      }

      protected void gxgrGridww_refresh( int subGridww_Rows ,
                                         long AV8ApplicationId ,
                                         String AV28FilName ,
                                         String AV20PermissionAccessType ,
                                         String AV9BoolenFilter ,
                                         bool AV31IsAuthorized_Name ,
                                         long AV24RoleId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         GRIDWW_nCurrentRecord = 0;
         RF1G2( ) ;
         /* End function gxgrGridww_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vAPPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAPPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7AppId), 12, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV16ID, "")), context));
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.RTrim( AV16ID));
      }

      protected void fix_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
         }
         if ( cmbavPermissionaccesstype.ItemCount > 0 )
         {
            AV20PermissionAccessType = cmbavPermissionaccesstype.getValidValue(AV20PermissionAccessType);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PermissionAccessType", AV20PermissionAccessType);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavPermissionaccesstype.CurrentValue = StringUtil.RTrim( AV20PermissionAccessType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPermissionaccesstype_Internalname, "Values", cmbavPermissionaccesstype.ToJavascriptSource(), true);
         }
         if ( cmbavBoolenfilter.ItemCount > 0 )
         {
            AV9BoolenFilter = cmbavBoolenfilter.getValidValue(AV9BoolenFilter);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9BoolenFilter", AV9BoolenFilter);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBoolenfilter.CurrentValue = StringUtil.RTrim( AV9BoolenFilter);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBoolenfilter_Internalname, "Values", cmbavBoolenfilter.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1G2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
         edtavAppid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAppid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAppid_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
         edtavDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDsc_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
      }

      protected void RF1G2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridwwContainer.ClearRows();
         }
         wbStart = 43;
         /* Execute user event: Refresh */
         E151G2 ();
         nGXsfl_43_idx = 1;
         sGXsfl_43_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_idx), 4, 0)), 4, "0");
         SubsflControlProps_432( ) ;
         bGXsfl_43_Refreshing = true;
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
            SubsflControlProps_432( ) ;
            E161G2 ();
            if ( ( GRIDWW_nCurrentRecord > 0 ) && ( GRIDWW_nGridOutOfScope == 0 ) && ( nGXsfl_43_idx == 1 ) )
            {
               GRIDWW_nCurrentRecord = 0;
               GRIDWW_nGridOutOfScope = 1;
               subgridww_firstpage( ) ;
               E161G2 ();
            }
            wbEnd = 43;
            WB1G0( ) ;
         }
         bGXsfl_43_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1G2( )
      {
         GxWebStd.gx_hidden_field( context, "vAPPLICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8ApplicationId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ApplicationId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_NAME", AV31IsAuthorized_Name);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV31IsAuthorized_Name, context));
         GxWebStd.gx_hidden_field( context, "vROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24RoleId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV24RoleId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vAPPID"+"_"+sGXsfl_43_idx, GetSecureSignedToken( sGXsfl_43_idx, context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vID"+"_"+sGXsfl_43_idx, GetSecureSignedToken( sGXsfl_43_idx, StringUtil.RTrim( context.localUtil.Format( AV16ID, "")), context));
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
            gxgrGridww_refresh( subGridww_Rows, AV8ApplicationId, AV28FilName, AV20PermissionAccessType, AV9BoolenFilter, AV31IsAuthorized_Name, AV24RoleId) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV8ApplicationId, AV28FilName, AV20PermissionAccessType, AV9BoolenFilter, AV31IsAuthorized_Name, AV24RoleId) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV8ApplicationId, AV28FilName, AV20PermissionAccessType, AV9BoolenFilter, AV31IsAuthorized_Name, AV24RoleId) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV8ApplicationId, AV28FilName, AV20PermissionAccessType, AV9BoolenFilter, AV31IsAuthorized_Name, AV24RoleId) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV8ApplicationId, AV28FilName, AV20PermissionAccessType, AV9BoolenFilter, AV31IsAuthorized_Name, AV24RoleId) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP1G0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
         edtavAppid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAppid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAppid_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
         edtavDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDsc_Enabled), 5, 0)), !bGXsfl_43_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E141G2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV28FilName = cgiGet( edtavFilname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28FilName", AV28FilName);
            cmbavPermissionaccesstype.Name = cmbavPermissionaccesstype_Internalname;
            cmbavPermissionaccesstype.CurrentValue = cgiGet( cmbavPermissionaccesstype_Internalname);
            AV20PermissionAccessType = cgiGet( cmbavPermissionaccesstype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PermissionAccessType", AV20PermissionAccessType);
            cmbavBoolenfilter.Name = cmbavBoolenfilter_Internalname;
            cmbavBoolenfilter.CurrentValue = cgiGet( cmbavBoolenfilter_Internalname);
            AV9BoolenFilter = cgiGet( cmbavBoolenfilter_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9BoolenFilter", AV9BoolenFilter);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vGRIDWWCURRENTPAGE");
               GX_FocusControl = edtavGridwwcurrentpage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV29GridWWCurrentPage = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridWWCurrentPage), 10, 0)));
            }
            else
            {
               AV29GridWWCurrentPage = (long)(context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridWWCurrentPage), 10, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_43 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_43"), ",", "."));
            AV30GridWWPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDWWPAGECOUNT"), ",", "."));
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
         E141G2 ();
         if (returnInSub) return;
      }

      protected void E141G2( )
      {
         /* Start Routine */
         if ( (0==AV24RoleId) || (0==AV8ApplicationId) )
         {
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         subGridww_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV29GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridWWCurrentPage), 10, 0)));
         edtavGridwwcurrentpage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGridwwcurrentpage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGridwwcurrentpage_Visible), 5, 0)), true);
         AV30GridWWPageCount = -1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridWWPageCount), 10, 0)));
         GXt_boolean1 = AV31IsAuthorized_Name;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamapppermissionentry_Execute", out  GXt_boolean1) ;
         AV31IsAuthorized_Name = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31IsAuthorized_Name", AV31IsAuthorized_Name);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV31IsAuthorized_Name, context));
         Gridwwpaginationbar_Rowsperpageselectedvalue = subGridww_Rows;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Gridwwpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridwwpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         AV15GAMRole.load( AV24RoleId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24RoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24RoleId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV24RoleId), "ZZZZZZZZZZZ9"), context));
         AV5GAMApplication.load( AV8ApplicationId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ApplicationId), "ZZZZZZZZZZZ9"), context));
         Form.Caption = "Add permissions to Role "+StringUtil.Trim( AV15GAMRole.gxTpr_Name)+" [Application: "+StringUtil.Trim( AV5GAMApplication.gxTpr_Name)+"]";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
      }

      protected void E151G2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
      }

      private void E161G2( )
      {
         /* Gridww_Load Routine */
         AV7AppId = AV8ApplicationId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAppid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV7AppId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPID"+"_"+sGXsfl_43_idx, GetSecureSignedToken( sGXsfl_43_idx, context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9"), context));
         AV22PermissionFilter.gxTpr_Applicationid = AV7AppId;
         AV22PermissionFilter.gxTpr_Name = AV28FilName;
         AV22PermissionFilter.gxTpr_Accesstype = AV20PermissionAccessType;
         AV22PermissionFilter.gxTpr_Inherited = AV9BoolenFilter;
         AV33GAMPermissions = AV15GAMRole.getunassignedpermissions(AV22PermissionFilter, out  AV14Errors);
         if ( AV33GAMPermissions.Count == 0 )
         {
            AV30GridWWPageCount = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridWWPageCount), 10, 0)));
         }
         else
         {
            AV30GridWWPageCount = (long)((AV33GAMPermissions.Count/ (decimal)(9))+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridWWPageCount), 10, 0)));
         }
         if ( ! (0==AV7AppId) )
         {
            AV40GXV1 = 1;
            while ( AV40GXV1 <= AV33GAMPermissions.Count )
            {
               AV19Permission = ((SdtGAMPermission)AV33GAMPermissions.Item(AV40GXV1));
               AV27Select = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavSelect_Internalname, AV27Select);
               AV16ID = AV19Permission.gxTpr_Guid;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, AV16ID);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID"+"_"+sGXsfl_43_idx, GetSecureSignedToken( sGXsfl_43_idx, StringUtil.RTrim( context.localUtil.Format( AV16ID, "")), context));
               AV18Name = AV19Permission.gxTpr_Name;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV18Name);
               AV12Dsc = AV19Permission.gxTpr_Description;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDsc_Internalname, AV12Dsc);
               if ( AV31IsAuthorized_Name )
               {
                  edtavName_Link = formatLink("gamapppermissionentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +AV8ApplicationId) + "," + UrlEncode(StringUtil.RTrim(AV16ID));
               }
               /* Load Method */
               if ( wbStart != -1 )
               {
                  wbStart = 43;
               }
               if ( ( subGridww_Islastpage == 1 ) || ( subGridww_Rows == 0 ) || ( ( GRIDWW_nCurrentRecord >= GRIDWW_nFirstRecordOnPage ) && ( GRIDWW_nCurrentRecord < GRIDWW_nFirstRecordOnPage + subGridww_Recordsperpage( ) ) ) )
               {
                  sendrow_432( ) ;
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
               if ( isFullAjaxMode( ) && ! bGXsfl_43_Refreshing )
               {
                  context.DoAjaxLoad(43, GridwwRow);
               }
               AV40GXV1 = (int)(AV40GXV1+1);
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22PermissionFilter", AV22PermissionFilter);
      }

      protected void E111G2( )
      {
         /* Gridwwpaginationbar_Changepage Routine */
         if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Previous") == 0 )
         {
            AV29GridWWCurrentPage = (long)(AV29GridWWCurrentPage-1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridWWCurrentPage), 10, 0)));
            subgridww_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Next") == 0 )
         {
            AV29GridWWCurrentPage = (long)(AV29GridWWCurrentPage+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridWWCurrentPage), 10, 0)));
            subgridww_nextpage( ) ;
         }
         else
         {
            AV32PageToGo = (int)(NumberUtil.Val( Gridwwpaginationbar_Selectedpage, "."));
            AV29GridWWCurrentPage = AV32PageToGo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridWWCurrentPage), 10, 0)));
            subgridww_gotopage( AV32PageToGo) ;
         }
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
      }

      protected void E121G2( )
      {
         /* Gridwwpaginationbar_Changerowsperpage Routine */
         subGridww_Rows = Gridwwpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV29GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridWWCurrentPage), 10, 0)));
         subgridww_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E131G2( )
      {
         /* 'DoAdd' Routine */
         AV15GAMRole.load( AV24RoleId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24RoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24RoleId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV24RoleId), "ZZZZZZZZZZZ9"), context));
         /* Start For Each Line */
         nRC_GXsfl_43 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_43"), ",", "."));
         nGXsfl_43_fel_idx = 0;
         while ( nGXsfl_43_fel_idx < nRC_GXsfl_43 )
         {
            nGXsfl_43_fel_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_43_fel_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_43_fel_idx+1));
            sGXsfl_43_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_fel_idx), 4, 0)), 4, "0");
            SubsflControlProps_fel_432( ) ;
            AV27Select = StringUtil.StrToBool( cgiGet( chkavSelect_Internalname));
            AV18Name = cgiGet( edtavName_Internalname);
            AV16ID = cgiGet( edtavId_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vAPPID");
               GX_FocusControl = edtavAppid_Internalname;
               wbErr = true;
               AV7AppId = 0;
            }
            else
            {
               AV7AppId = (long)(context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", "."));
            }
            AV12Dsc = cgiGet( edtavDsc_Internalname);
            cmbavAccess.Name = cmbavAccess_Internalname;
            cmbavAccess.CurrentValue = cgiGet( cmbavAccess_Internalname);
            AV6Access = cgiGet( cmbavAccess_Internalname);
            if ( AV27Select )
            {
               AV21PermissionAdd.gxTpr_Applicationid = AV7AppId;
               AV21PermissionAdd.gxTpr_Guid = AV16ID;
               AV21PermissionAdd.gxTpr_Type = AV6Access;
               AV17isOK = AV15GAMRole.addpermission(AV21PermissionAdd, out  AV14Errors);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17isOK", AV17isOK);
               if ( ! AV17isOK )
               {
                  AV42GXV2 = 1;
                  while ( AV42GXV2 <= AV14Errors.Count )
                  {
                     AV13Error = ((SdtGAMError)AV14Errors.Item(AV42GXV2));
                     GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV13Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
                     AV42GXV2 = (int)(AV42GXV2+1);
                  }
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            /* End For Each Line */
         }
         if ( nGXsfl_43_fel_idx == 0 )
         {
            nGXsfl_43_idx = 1;
            sGXsfl_43_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_idx), 4, 0)), 4, "0");
            SubsflControlProps_432( ) ;
         }
         nGXsfl_43_fel_idx = 1;
         if ( AV17isOK )
         {
            pr_gam.commit( "GAMRolePermissionSelect");
            pr_default.commit( "GAMRolePermissionSelect");
            CallWebObject(formatLink("gamwwrolepermissions.aspx") + "?" + UrlEncode("" +AV24RoleId) + "," + UrlEncode("" +AV8ApplicationId));
            context.wjLocDisableFrm = 1;
         }
         else
         {
            AV43GXV3 = 1;
            while ( AV43GXV3 <= AV14Errors.Count )
            {
               AV13Error = ((SdtGAMError)AV14Errors.Item(AV43GXV3));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV13Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
               AV43GXV3 = (int)(AV43GXV3+1);
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15GAMRole", AV15GAMRole);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21PermissionAdd", AV21PermissionAdd);
      }

      protected void wb_table1_22_1G2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablefilters_Internalname, tblTablefilters_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellFormGroupMarginBottom5'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavFilname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFilname_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'" + sGXsfl_43_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFilname_Internalname, StringUtil.RTrim( AV28FilName), StringUtil.RTrim( context.localUtil.Format( AV28FilName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,27);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFilname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavFilname_Enabled, 0, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMRolePermissionSelect.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellFormGroupMarginBottom5'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavPermissionaccesstype_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavPermissionaccesstype_Internalname, "Type", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'" + sGXsfl_43_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPermissionaccesstype, cmbavPermissionaccesstype_Internalname, StringUtil.RTrim( AV20PermissionAccessType), 1, cmbavPermissionaccesstype_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavPermissionaccesstype.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,32);\"", "", true, "HLP_GAMRolePermissionSelect.htm");
            cmbavPermissionaccesstype.CurrentValue = StringUtil.RTrim( AV20PermissionAccessType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPermissionaccesstype_Internalname, "Values", (String)(cmbavPermissionaccesstype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellFormGroupMarginBottom5'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBoolenfilter_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBoolenfilter_Internalname, "Inherited?", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_43_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBoolenfilter, cmbavBoolenfilter_Internalname, StringUtil.RTrim( AV9BoolenFilter), 1, cmbavBoolenfilter_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavBoolenfilter.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,37);\"", "", true, "HLP_GAMRolePermissionSelect.htm");
            cmbavBoolenfilter.CurrentValue = StringUtil.RTrim( AV9BoolenFilter);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBoolenfilter_Internalname, "Values", (String)(cmbavBoolenfilter.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_22_1G2e( true) ;
         }
         else
         {
            wb_table1_22_1G2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV24RoleId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24RoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24RoleId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV24RoleId), "ZZZZZZZZZZZ9"), context));
         AV8ApplicationId = Convert.ToInt64(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ApplicationId), "ZZZZZZZZZZZ9"), context));
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
         PA1G2( ) ;
         WS1G2( ) ;
         WE1G2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019445330", true);
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
            context.AddJavascriptSource("gamrolepermissionselect.js", "?201892019445331", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
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

      protected void SubsflControlProps_432( )
      {
         chkavSelect_Internalname = "vSELECT_"+sGXsfl_43_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_43_idx;
         edtavId_Internalname = "vID_"+sGXsfl_43_idx;
         edtavAppid_Internalname = "vAPPID_"+sGXsfl_43_idx;
         edtavDsc_Internalname = "vDSC_"+sGXsfl_43_idx;
         cmbavAccess_Internalname = "vACCESS_"+sGXsfl_43_idx;
      }

      protected void SubsflControlProps_fel_432( )
      {
         chkavSelect_Internalname = "vSELECT_"+sGXsfl_43_fel_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_43_fel_idx;
         edtavId_Internalname = "vID_"+sGXsfl_43_fel_idx;
         edtavAppid_Internalname = "vAPPID_"+sGXsfl_43_fel_idx;
         edtavDsc_Internalname = "vDSC_"+sGXsfl_43_fel_idx;
         cmbavAccess_Internalname = "vACCESS_"+sGXsfl_43_fel_idx;
      }

      protected void sendrow_432( )
      {
         SubsflControlProps_432( ) ;
         WB1G0( ) ;
         if ( ( subGridww_Rows * 1 == 0 ) || ( nGXsfl_43_idx <= subGridww_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_43_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_43_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            TempTags = " " + ((chkavSelect.Enabled!=0)&&(chkavSelect.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 44,'',false,'"+sGXsfl_43_idx+"',43)\"" : " ");
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridwwRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavSelect_Internalname,StringUtil.BoolToStr( AV27Select),(String)"",(String)"",(short)-1,(short)1,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(44, this, 'true', 'false');gx.evt.onchange(this, event);\" "+((chkavSelect.Enabled!=0)&&(chkavSelect.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,44);\"" : " ")});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavName_Enabled!=0)&&(edtavName_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 45,'',false,'"+sGXsfl_43_idx+"',43)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavName_Internalname,StringUtil.RTrim( AV18Name),(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavName_Enabled!=0)&&(edtavName_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,45);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavName_Link,(String)"",(String)"",(String)"",(String)edtavName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavName_Enabled,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)254,(short)0,(short)0,(short)43,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionLong",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 46,'',false,'"+sGXsfl_43_idx+"',43)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavId_Internalname,StringUtil.RTrim( AV16ID),(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,46);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavId_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)43,(short)1,(short)-1,(short)0,(bool)true,(String)"GAMGUID",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavAppid_Enabled!=0)&&(edtavAppid_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 47,'',false,'"+sGXsfl_43_idx+"',43)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavAppid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7AppId), 12, 0, ",", "")),((edtavAppid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7AppId), "ZZZZZZZZZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavAppid_Enabled!=0)&&(edtavAppid_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,47);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavAppid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavAppid_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)43,(short)1,(short)-1,(short)0,(bool)true,(String)"GAMKeyNumLong",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavDsc_Enabled!=0)&&(edtavDsc_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 48,'',false,'"+sGXsfl_43_idx+"',43)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDsc_Internalname,StringUtil.RTrim( AV12Dsc),(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavDsc_Enabled!=0)&&(edtavDsc_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,48);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavDsc_Enabled,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)254,(short)0,(short)0,(short)43,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionLong",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            TempTags = " " + ((cmbavAccess.Enabled!=0)&&(cmbavAccess.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 49,'',false,'"+sGXsfl_43_idx+"',43)\"" : " ");
            if ( ( cmbavAccess.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "vACCESS_" + sGXsfl_43_idx;
               cmbavAccess.Name = GXCCtl;
               cmbavAccess.WebTags = "";
               cmbavAccess.addItem("A", "Allow", 0);
               cmbavAccess.addItem("D", "Deny", 0);
               cmbavAccess.addItem("R", "Restricted", 0);
               if ( cmbavAccess.ItemCount > 0 )
               {
                  AV6Access = cmbavAccess.getValidValue(AV6Access);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavAccess_Internalname, AV6Access);
               }
            }
            /* ComboBox */
            GridwwRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavAccess,(String)cmbavAccess_Internalname,StringUtil.RTrim( AV6Access),(short)1,(String)cmbavAccess_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,(short)1,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((cmbavAccess.Enabled!=0)&&(cmbavAccess.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,49);\"" : " "),(String)"",(bool)true});
            cmbavAccess.CurrentValue = StringUtil.RTrim( AV6Access);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavAccess_Internalname, "Values", (String)(cmbavAccess.ToJavascriptSource()), !bGXsfl_43_Refreshing);
            send_integrity_lvl_hashes1G2( ) ;
            GridwwContainer.AddRow(GridwwRow);
            nGXsfl_43_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_43_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_43_idx+1));
            sGXsfl_43_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_43_idx), 4, 0)), 4, "0");
            SubsflControlProps_432( ) ;
         }
         /* End function sendrow_432 */
      }

      protected void init_default_properties( )
      {
         divTableactions_Internalname = "TABLEACTIONS";
         edtavFilname_Internalname = "vFILNAME";
         cmbavPermissionaccesstype_Internalname = "vPERMISSIONACCESSTYPE";
         cmbavBoolenfilter_Internalname = "vBOOLENFILTER";
         tblTablefilters_Internalname = "TABLEFILTERS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         chkavSelect_Internalname = "vSELECT";
         edtavName_Internalname = "vNAME";
         edtavId_Internalname = "vID";
         edtavAppid_Internalname = "vAPPID";
         edtavDsc_Internalname = "vDSC";
         cmbavAccess_Internalname = "vACCESS";
         Gridwwpaginationbar_Internalname = "GRIDWWPAGINATIONBAR";
         edtavGridwwcurrentpage_Internalname = "vGRIDWWCURRENTPAGE";
         divHtml_gridwwpaginationbar_Internalname = "HTML_GRIDWWPAGINATIONBAR";
         divGridwwtablewithpaginationbar_Internalname = "GRIDWWTABLEWITHPAGINATIONBAR";
         bttBtnadd_Internalname = "BTNADD";
         bttBtncancel_Internalname = "BTNCANCEL";
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
         cmbavAccess_Jsonclick = "";
         cmbavAccess.Visible = -1;
         cmbavAccess.Enabled = 1;
         edtavDsc_Jsonclick = "";
         edtavDsc_Visible = -1;
         edtavAppid_Jsonclick = "";
         edtavAppid_Visible = 0;
         edtavId_Jsonclick = "";
         edtavId_Visible = 0;
         edtavName_Jsonclick = "";
         edtavName_Visible = -1;
         chkavSelect.Visible = -1;
         chkavSelect.Enabled = 1;
         cmbavBoolenfilter_Jsonclick = "";
         cmbavBoolenfilter.Enabled = 1;
         cmbavPermissionaccesstype_Jsonclick = "";
         cmbavPermissionaccesstype.Enabled = 1;
         edtavFilname_Jsonclick = "";
         edtavFilname_Enabled = 1;
         chkavSelect.Caption = "";
         edtavGridwwcurrentpage_Jsonclick = "";
         edtavGridwwcurrentpage_Visible = 1;
         subGridww_Allowcollapsing = 0;
         subGridww_Allowselection = 0;
         edtavName_Link = "";
         edtavDsc_Enabled = 1;
         edtavAppid_Enabled = 1;
         edtavId_Enabled = 1;
         edtavName_Enabled = 1;
         subGridww_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGridww_Backcolorstyle = 0;
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
         Form.Caption = "Application permission select to role";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV28FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstype'},{av:'AV20PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:'',nv:''},{av:'cmbavBoolenfilter'},{av:'AV9BoolenFilter',fld:'vBOOLENFILTER',pic:'',nv:''},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV24RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV31IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false}],oparms:[]}");
         setEventMetadata("GRIDWW.LOAD","{handler:'E161G2',iparms:[{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV28FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstype'},{av:'AV20PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:'',nv:''},{av:'cmbavBoolenfilter'},{av:'AV9BoolenFilter',fld:'vBOOLENFILTER',pic:'',nv:''},{av:'AV31IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false}],oparms:[{av:'AV7AppId',fld:'vAPPID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV30GridWWPageCount',fld:'vGRIDWWPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0},{av:'AV27Select',fld:'vSELECT',pic:'',nv:false},{av:'AV16ID',fld:'vID',pic:'',hsh:true,nv:''},{av:'AV18Name',fld:'vNAME',pic:'',nv:''},{av:'AV12Dsc',fld:'vDSC',pic:'',nv:''},{av:'edtavName_Link',ctrl:'vNAME',prop:'Link'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEPAGE","{handler:'E111G2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV28FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstype'},{av:'AV20PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:'',nv:''},{av:'cmbavBoolenfilter'},{av:'AV9BoolenFilter',fld:'vBOOLENFILTER',pic:'',nv:''},{av:'AV31IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false},{av:'AV24RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'Gridwwpaginationbar_Selectedpage',ctrl:'GRIDWWPAGINATIONBAR',prop:'SelectedPage'},{av:'AV29GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}],oparms:[{av:'AV29GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E121G2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV28FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstype'},{av:'AV20PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:'',nv:''},{av:'cmbavBoolenfilter'},{av:'AV9BoolenFilter',fld:'vBOOLENFILTER',pic:'',nv:''},{av:'AV31IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false},{av:'AV24RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'Gridwwpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDWWPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],oparms:[{av:'subGridww_Rows',ctrl:'GRIDWW',prop:'Rows'},{av:'AV29GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("'DOADD'","{handler:'E131G2',iparms:[{av:'AV24RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV27Select',fld:'vSELECT',grid:43,pic:'',nv:false},{av:'AV7AppId',fld:'vAPPID',grid:43,pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV16ID',fld:'vID',grid:43,pic:'',hsh:true,nv:''},{av:'cmbavAccess'},{av:'AV6Access',fld:'vACCESS',grid:43,pic:'',nv:''},{av:'AV17isOK',fld:'vISOK',pic:'',nv:false},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV17isOK',fld:'vISOK',pic:'',nv:false}]}");
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
         AV28FilName = "";
         AV20PermissionAccessType = "";
         AV9BoolenFilter = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         GridwwContainer = new GXWebGrid( context);
         sStyleString = "";
         subGridww_Linesclass = "";
         GridwwColumn = new GXWebColumn();
         AV18Name = "";
         AV16ID = "";
         AV12Dsc = "";
         AV6Access = "";
         TempTags = "";
         bttBtnadd_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV15GAMRole = new SdtGAMRole(context);
         AV5GAMApplication = new SdtGAMApplication(context);
         AV22PermissionFilter = new SdtGAMPermissionFilter(context);
         AV33GAMPermissions = new GXExternalCollection<SdtGAMPermission>( context, "SdtGAMPermission", "GeneXus.Programs");
         AV14Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV19Permission = new SdtGAMPermission(context);
         GridwwRow = new GXWebRow();
         AV21PermissionAdd = new SdtGAMPermission(context);
         AV13Error = new SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamrolepermissionselect__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamrolepermissionselect__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavName_Enabled = 0;
         edtavId_Enabled = 0;
         edtavAppid_Enabled = 0;
         edtavDsc_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_43 ;
      private short nGXsfl_43_idx=1 ;
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
      private short nGXsfl_43_fel_idx=1 ;
      private short subGridww_Backstyle ;
      private int Gridwwpaginationbar_Rowsperpageselectedvalue ;
      private int subGridww_Rows ;
      private int Gridwwpaginationbar_Pagestoshow ;
      private int subGridww_Titlebackcolor ;
      private int subGridww_Allbackcolor ;
      private int edtavName_Enabled ;
      private int edtavId_Enabled ;
      private int edtavAppid_Enabled ;
      private int edtavDsc_Enabled ;
      private int subGridww_Selectioncolor ;
      private int subGridww_Hoveringcolor ;
      private int edtavGridwwcurrentpage_Visible ;
      private int subGridww_Islastpage ;
      private int GRIDWW_nGridOutOfScope ;
      private int AV40GXV1 ;
      private int AV32PageToGo ;
      private int AV42GXV2 ;
      private int AV43GXV3 ;
      private int edtavFilname_Enabled ;
      private int idxLst ;
      private int subGridww_Backcolor ;
      private int edtavName_Visible ;
      private int edtavId_Visible ;
      private int edtavAppid_Visible ;
      private int edtavDsc_Visible ;
      private long AV24RoleId ;
      private long AV8ApplicationId ;
      private long wcpOAV24RoleId ;
      private long wcpOAV8ApplicationId ;
      private long GRIDWW_nFirstRecordOnPage ;
      private long AV30GridWWPageCount ;
      private long AV7AppId ;
      private long AV29GridWWCurrentPage ;
      private long GRIDWW_nCurrentRecord ;
      private long GRIDWW_nRecordCount ;
      private String Gridwwpaginationbar_Selectedpage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_43_idx="0001" ;
      private String AV28FilName ;
      private String AV20PermissionAccessType ;
      private String AV9BoolenFilter ;
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
      private String divGridwwtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGridww_Internalname ;
      private String subGridww_Class ;
      private String subGridww_Linesclass ;
      private String AV18Name ;
      private String edtavName_Link ;
      private String AV16ID ;
      private String AV12Dsc ;
      private String AV6Access ;
      private String divHtml_gridwwpaginationbar_Internalname ;
      private String TempTags ;
      private String edtavGridwwcurrentpage_Internalname ;
      private String edtavGridwwcurrentpage_Jsonclick ;
      private String bttBtnadd_Internalname ;
      private String bttBtnadd_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String chkavSelect_Internalname ;
      private String edtavName_Internalname ;
      private String edtavId_Internalname ;
      private String edtavAppid_Internalname ;
      private String edtavDsc_Internalname ;
      private String cmbavAccess_Internalname ;
      private String GXCCtl ;
      private String edtavFilname_Internalname ;
      private String cmbavPermissionaccesstype_Internalname ;
      private String cmbavBoolenfilter_Internalname ;
      private String Gridwwpaginationbar_Internalname ;
      private String sGXsfl_43_fel_idx="0001" ;
      private String tblTablefilters_Internalname ;
      private String edtavFilname_Jsonclick ;
      private String cmbavPermissionaccesstype_Jsonclick ;
      private String cmbavBoolenfilter_Jsonclick ;
      private String ROClassString ;
      private String edtavName_Jsonclick ;
      private String edtavId_Jsonclick ;
      private String edtavAppid_Jsonclick ;
      private String edtavDsc_Jsonclick ;
      private String cmbavAccess_Jsonclick ;
      private String Dvpanel_tableheader_Internalname ;
      private bool entryPointCalled ;
      private bool AV31IsAuthorized_Name ;
      private bool toggleJsOutput ;
      private bool AV17isOK ;
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
      private bool AV27Select ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_43_Refreshing=false ;
      private bool returnInSub ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private GXWebGrid GridwwContainer ;
      private GXWebRow GridwwRow ;
      private GXWebColumn GridwwColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavPermissionaccesstype ;
      private GXCombobox cmbavBoolenfilter ;
      private GXCheckbox chkavSelect ;
      private GXCombobox cmbavAccess ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMError> AV14Errors ;
      private GXExternalCollection<SdtGAMPermission> AV33GAMPermissions ;
      private GXWebForm Form ;
      private SdtGAMApplication AV5GAMApplication ;
      private SdtGAMError AV13Error ;
      private SdtGAMRole AV15GAMRole ;
      private SdtGAMPermission AV19Permission ;
      private SdtGAMPermission AV21PermissionAdd ;
      private SdtGAMPermissionFilter AV22PermissionFilter ;
   }

   public class gamrolepermissionselect__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamrolepermissionselect__default : DataStoreHelperBase, IDataStoreHelper
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
