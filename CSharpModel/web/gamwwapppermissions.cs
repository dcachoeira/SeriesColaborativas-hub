/*
               File: GAMWWAppPermissions
        Description: Application`s permissions
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:44:30.1
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
   public class gamwwapppermissions : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamwwapppermissions( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamwwapppermissions( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_ApplicationId )
      {
         this.AV8ApplicationId = aP0_ApplicationId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavPermissionaccesstypedefault = new GXCombobox();
         cmbavPermissiontypefilter = new GXCombobox();
         cmbavIsautomaticpermission = new GXCombobox();
         cmbavAccesstype = new GXCombobox();
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
               nRC_GXsfl_55 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_55_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_55_idx = GetNextPar( );
               edtavBtnchildren_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnchildren_Internalname, "Title", edtavBtnchildren_Title, !bGXsfl_55_Refreshing);
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
               edtavBtnchildren_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnchildren_Internalname, "Title", edtavBtnchildren_Title, !bGXsfl_55_Refreshing);
               AV8ApplicationId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV13FilName = GetNextPar( );
               AV19PermissionAccessTypeDefault = GetNextPar( );
               AV20PermissionTypeFilter = GetNextPar( );
               AV16isAutomaticPermission = GetNextPar( );
               AV28IsAuthorized_BtnUpd = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV27IsAuthorized_BtnDlt = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV26IsAuthorized_BtnChildren = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV29IsAuthorized_Name = (bool)(BooleanUtil.Val(GetNextPar( )));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridww_refresh( subGridww_Rows, AV8ApplicationId, AV13FilName, AV19PermissionAccessTypeDefault, AV20PermissionTypeFilter, AV16isAutomaticPermission, AV28IsAuthorized_BtnUpd, AV27IsAuthorized_BtnDlt, AV26IsAuthorized_BtnChildren, AV29IsAuthorized_Name) ;
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
               AV8ApplicationId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ApplicationId), "ZZZZZZZZZZZ9"), context));
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
         PA1E2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1E2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019443026", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamwwapppermissions.aspx") + "?" + UrlEncode("" +AV8ApplicationId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_55", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_55), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDWWPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25GridWWPageCount), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vAPPLICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8ApplicationId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ApplicationId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNUPD", AV28IsAuthorized_BtnUpd);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNDLT", AV27IsAuthorized_BtnDlt);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNCHILDREN", AV26IsAuthorized_BtnChildren);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_NAME", AV29IsAuthorized_Name);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV29IsAuthorized_Name, context));
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
         GxWebStd.gx_hidden_field( context, "vBTNCHILDREN_Title", StringUtil.RTrim( edtavBtnchildren_Title));
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
            WE1E2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1E2( ) ;
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
         return formatLink("gamwwapppermissions.aspx") + "?" + UrlEncode("" +AV8ApplicationId) ;
      }

      public override String GetPgmname( )
      {
         return "GAMWWAppPermissions" ;
      }

      public override String GetPgmdesc( )
      {
         return "Application`s permissions" ;
      }

      protected void WB1E0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-7 TableCellsWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableactions_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
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
            GxWebStd.gx_button_ctrl( context, bttBtnback_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(55), 2, 0)+","+"null"+");", "Back", bttBtnback_Jsonclick, 7, "Back", "", StyleString, ClassString, bttBtnback_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e111e1_client"+"'", TempTags, "", 2, "HLP_GAMWWAppPermissions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnadd_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(55), 2, 0)+","+"null"+");", "Insert", bttBtnadd_Jsonclick, 7, "Add", "", StyleString, ClassString, bttBtnadd_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e121e1_client"+"'", TempTags, "", 2, "HLP_GAMWWAppPermissions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-5", "left", "top", "", "", "div");
            wb_table1_29_1E2( true) ;
         }
         else
         {
            wb_table1_29_1E2( false) ;
         }
         return  ;
      }

      protected void wb_table1_29_1E2e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"DivS\" data-gxgridid=\"55\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "AppId") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavBtnupd_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute"+"\" "+" style=\""+((edtavBtndlt_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavBtnchildren_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( edtavBtnchildren_Title) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "GUID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Permission Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Description") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Default Access") ;
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
               GridwwColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6AppId), 12, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavAppid_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV10BtnUpd));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtnupd_Link));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtnupd_Tooltiptext));
               GridwwColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtnupd_Visible), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV23BtnDlt));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtndlt_Link));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtndlt_Tooltiptext));
               GridwwColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtndlt_Visible), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV22BtnChildren));
               GridwwColumn.AddObjectProperty("Title", StringUtil.RTrim( edtavBtnchildren_Title));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtnchildren_Link));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtnchildren_Tooltiptext));
               GridwwColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtnchildren_Visible), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV15Id));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavId_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV18Name));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavName_Enabled), 5, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavName_Link));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV11Dsc));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDsc_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV5AccessType));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbavAccesstype.Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowselection), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Selectioncolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowhovering), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Hoveringcolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowcollapsing), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 55 )
         {
            wbEnd = 0;
            nRC_GXsfl_55 = (short)(nGXsfl_55_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_55_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGridwwcurrentpage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24GridWWCurrentPage), 10, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV24GridWWCurrentPage), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGridwwcurrentpage_Jsonclick, 0, "Attribute", "", "", "", "", edtavGridwwcurrentpage_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMWWAppPermissions.htm");
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

      protected void START1E2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Application`s permissions", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1E0( ) ;
      }

      protected void WS1E2( )
      {
         START1E2( ) ;
         EVT1E2( ) ;
      }

      protected void EVT1E2( )
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
                              E131E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E141E2 ();
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
                              nGXsfl_55_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0");
                              SubsflControlProps_552( ) ;
                              AV6AppId = (long)(context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", "."));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAppid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV6AppId), 12, 0)));
                              AV10BtnUpd = cgiGet( edtavBtnupd_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV10BtnUpd)) ? AV42Btnupd_GXI : context.convertURL( context.PathToRelativeUrl( AV10BtnUpd))), !bGXsfl_55_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "SrcSet", context.GetImageSrcSet( AV10BtnUpd), true);
                              AV23BtnDlt = cgiGet( edtavBtndlt_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV23BtnDlt)) ? AV43Btndlt_GXI : context.convertURL( context.PathToRelativeUrl( AV23BtnDlt))), !bGXsfl_55_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "SrcSet", context.GetImageSrcSet( AV23BtnDlt), true);
                              AV22BtnChildren = cgiGet( edtavBtnchildren_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnchildren_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV22BtnChildren)) ? AV44Btnchildren_GXI : context.convertURL( context.PathToRelativeUrl( AV22BtnChildren))), !bGXsfl_55_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnchildren_Internalname, "SrcSet", context.GetImageSrcSet( AV22BtnChildren), true);
                              AV15Id = cgiGet( edtavId_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, AV15Id);
                              AV18Name = cgiGet( edtavName_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV18Name);
                              AV11Dsc = cgiGet( edtavDsc_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDsc_Internalname, AV11Dsc);
                              cmbavAccesstype.Name = cmbavAccesstype_Internalname;
                              cmbavAccesstype.CurrentValue = cgiGet( cmbavAccesstype_Internalname);
                              AV5AccessType = cgiGet( cmbavAccesstype_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavAccesstype_Internalname, AV5AccessType);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E151E2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E161E2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDWW.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E171E2 ();
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

      protected void WE1E2( )
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

      protected void PA1E2( )
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
            cmbavPermissionaccesstypedefault.Name = "vPERMISSIONACCESSTYPEDEFAULT";
            cmbavPermissionaccesstypedefault.WebTags = "";
            cmbavPermissionaccesstypedefault.addItem("", "(Nenhum)", 0);
            cmbavPermissionaccesstypedefault.addItem("A", "Allow", 0);
            cmbavPermissionaccesstypedefault.addItem("R", "Restricted", 0);
            if ( cmbavPermissionaccesstypedefault.ItemCount > 0 )
            {
               AV19PermissionAccessTypeDefault = cmbavPermissionaccesstypedefault.getValidValue(AV19PermissionAccessTypeDefault);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19PermissionAccessTypeDefault", AV19PermissionAccessTypeDefault);
            }
            cmbavPermissiontypefilter.Name = "vPERMISSIONTYPEFILTER";
            cmbavPermissiontypefilter.WebTags = "";
            cmbavPermissiontypefilter.addItem("A", "All", 0);
            cmbavPermissiontypefilter.addItem("F", "First level", 0);
            cmbavPermissiontypefilter.addItem("P", "All parents", 0);
            cmbavPermissiontypefilter.addItem("C", "All children", 0);
            if ( cmbavPermissiontypefilter.ItemCount > 0 )
            {
               AV20PermissionTypeFilter = cmbavPermissiontypefilter.getValidValue(AV20PermissionTypeFilter);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PermissionTypeFilter", AV20PermissionTypeFilter);
            }
            cmbavIsautomaticpermission.Name = "vISAUTOMATICPERMISSION";
            cmbavIsautomaticpermission.WebTags = "";
            cmbavIsautomaticpermission.addItem("A", "All", 0);
            cmbavIsautomaticpermission.addItem("T", "Yes", 0);
            cmbavIsautomaticpermission.addItem("F", "No", 0);
            if ( cmbavIsautomaticpermission.ItemCount > 0 )
            {
               AV16isAutomaticPermission = cmbavIsautomaticpermission.getValidValue(AV16isAutomaticPermission);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16isAutomaticPermission", AV16isAutomaticPermission);
            }
            GXCCtl = "vACCESSTYPE_" + sGXsfl_55_idx;
            cmbavAccesstype.Name = GXCCtl;
            cmbavAccesstype.WebTags = "";
            cmbavAccesstype.addItem("A", "Allow", 0);
            cmbavAccesstype.addItem("R", "Restricted", 0);
            if ( cmbavAccesstype.ItemCount > 0 )
            {
               AV5AccessType = cmbavAccesstype.getValidValue(AV5AccessType);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavAccesstype_Internalname, AV5AccessType);
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
         SubsflControlProps_552( ) ;
         while ( nGXsfl_55_idx <= nRC_GXsfl_55 )
         {
            sendrow_552( ) ;
            nGXsfl_55_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_55_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_55_idx+1));
            sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0");
            SubsflControlProps_552( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridwwContainer));
         /* End function gxnrGridww_newrow */
      }

      protected void gxgrGridww_refresh( int subGridww_Rows ,
                                         long AV8ApplicationId ,
                                         String AV13FilName ,
                                         String AV19PermissionAccessTypeDefault ,
                                         String AV20PermissionTypeFilter ,
                                         String AV16isAutomaticPermission ,
                                         bool AV28IsAuthorized_BtnUpd ,
                                         bool AV27IsAuthorized_BtnDlt ,
                                         bool AV26IsAuthorized_BtnChildren ,
                                         bool AV29IsAuthorized_Name )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         GRIDWW_nCurrentRecord = 0;
         RF1E2( ) ;
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
         if ( cmbavPermissionaccesstypedefault.ItemCount > 0 )
         {
            AV19PermissionAccessTypeDefault = cmbavPermissionaccesstypedefault.getValidValue(AV19PermissionAccessTypeDefault);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19PermissionAccessTypeDefault", AV19PermissionAccessTypeDefault);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavPermissionaccesstypedefault.CurrentValue = StringUtil.RTrim( AV19PermissionAccessTypeDefault);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPermissionaccesstypedefault_Internalname, "Values", cmbavPermissionaccesstypedefault.ToJavascriptSource(), true);
         }
         if ( cmbavPermissiontypefilter.ItemCount > 0 )
         {
            AV20PermissionTypeFilter = cmbavPermissiontypefilter.getValidValue(AV20PermissionTypeFilter);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PermissionTypeFilter", AV20PermissionTypeFilter);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavPermissiontypefilter.CurrentValue = StringUtil.RTrim( AV20PermissionTypeFilter);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPermissiontypefilter_Internalname, "Values", cmbavPermissiontypefilter.ToJavascriptSource(), true);
         }
         if ( cmbavIsautomaticpermission.ItemCount > 0 )
         {
            AV16isAutomaticPermission = cmbavIsautomaticpermission.getValidValue(AV16isAutomaticPermission);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16isAutomaticPermission", AV16isAutomaticPermission);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavIsautomaticpermission.CurrentValue = StringUtil.RTrim( AV16isAutomaticPermission);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavIsautomaticpermission_Internalname, "Values", cmbavIsautomaticpermission.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1E2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavAppid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAppid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAppid_Enabled), 5, 0)), !bGXsfl_55_Refreshing);
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), !bGXsfl_55_Refreshing);
         edtavName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_55_Refreshing);
         edtavDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDsc_Enabled), 5, 0)), !bGXsfl_55_Refreshing);
         cmbavAccesstype.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavAccesstype_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavAccesstype.Enabled), 5, 0)), !bGXsfl_55_Refreshing);
      }

      protected void RF1E2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridwwContainer.ClearRows();
         }
         wbStart = 55;
         /* Execute user event: Refresh */
         E161E2 ();
         nGXsfl_55_idx = 1;
         sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0");
         SubsflControlProps_552( ) ;
         bGXsfl_55_Refreshing = true;
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
            SubsflControlProps_552( ) ;
            E171E2 ();
            if ( ( GRIDWW_nCurrentRecord > 0 ) && ( GRIDWW_nGridOutOfScope == 0 ) && ( nGXsfl_55_idx == 1 ) )
            {
               GRIDWW_nCurrentRecord = 0;
               GRIDWW_nGridOutOfScope = 1;
               subgridww_firstpage( ) ;
               E171E2 ();
            }
            wbEnd = 55;
            WB1E0( ) ;
         }
         bGXsfl_55_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1E2( )
      {
         GxWebStd.gx_hidden_field( context, "vAPPLICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8ApplicationId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ApplicationId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_NAME", AV29IsAuthorized_Name);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV29IsAuthorized_Name, context));
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
            gxgrGridww_refresh( subGridww_Rows, AV8ApplicationId, AV13FilName, AV19PermissionAccessTypeDefault, AV20PermissionTypeFilter, AV16isAutomaticPermission, AV28IsAuthorized_BtnUpd, AV27IsAuthorized_BtnDlt, AV26IsAuthorized_BtnChildren, AV29IsAuthorized_Name) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV8ApplicationId, AV13FilName, AV19PermissionAccessTypeDefault, AV20PermissionTypeFilter, AV16isAutomaticPermission, AV28IsAuthorized_BtnUpd, AV27IsAuthorized_BtnDlt, AV26IsAuthorized_BtnChildren, AV29IsAuthorized_Name) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV8ApplicationId, AV13FilName, AV19PermissionAccessTypeDefault, AV20PermissionTypeFilter, AV16isAutomaticPermission, AV28IsAuthorized_BtnUpd, AV27IsAuthorized_BtnDlt, AV26IsAuthorized_BtnChildren, AV29IsAuthorized_Name) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV8ApplicationId, AV13FilName, AV19PermissionAccessTypeDefault, AV20PermissionTypeFilter, AV16isAutomaticPermission, AV28IsAuthorized_BtnUpd, AV27IsAuthorized_BtnDlt, AV26IsAuthorized_BtnChildren, AV29IsAuthorized_Name) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV8ApplicationId, AV13FilName, AV19PermissionAccessTypeDefault, AV20PermissionTypeFilter, AV16isAutomaticPermission, AV28IsAuthorized_BtnUpd, AV27IsAuthorized_BtnDlt, AV26IsAuthorized_BtnChildren, AV29IsAuthorized_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP1E0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavAppid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAppid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAppid_Enabled), 5, 0)), !bGXsfl_55_Refreshing);
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), !bGXsfl_55_Refreshing);
         edtavName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_55_Refreshing);
         edtavDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDsc_Enabled), 5, 0)), !bGXsfl_55_Refreshing);
         cmbavAccesstype.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavAccesstype_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavAccesstype.Enabled), 5, 0)), !bGXsfl_55_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E151E2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV13FilName = cgiGet( edtavFilname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13FilName", AV13FilName);
            cmbavPermissionaccesstypedefault.Name = cmbavPermissionaccesstypedefault_Internalname;
            cmbavPermissionaccesstypedefault.CurrentValue = cgiGet( cmbavPermissionaccesstypedefault_Internalname);
            AV19PermissionAccessTypeDefault = cgiGet( cmbavPermissionaccesstypedefault_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19PermissionAccessTypeDefault", AV19PermissionAccessTypeDefault);
            cmbavPermissiontypefilter.Name = cmbavPermissiontypefilter_Internalname;
            cmbavPermissiontypefilter.CurrentValue = cgiGet( cmbavPermissiontypefilter_Internalname);
            AV20PermissionTypeFilter = cgiGet( cmbavPermissiontypefilter_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PermissionTypeFilter", AV20PermissionTypeFilter);
            cmbavIsautomaticpermission.Name = cmbavIsautomaticpermission_Internalname;
            cmbavIsautomaticpermission.CurrentValue = cgiGet( cmbavIsautomaticpermission_Internalname);
            AV16isAutomaticPermission = cgiGet( cmbavIsautomaticpermission_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16isAutomaticPermission", AV16isAutomaticPermission);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vGRIDWWCURRENTPAGE");
               GX_FocusControl = edtavGridwwcurrentpage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV24GridWWCurrentPage = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24GridWWCurrentPage), 10, 0)));
            }
            else
            {
               AV24GridWWCurrentPage = (long)(context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24GridWWCurrentPage), 10, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_55 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_55"), ",", "."));
            AV25GridWWPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDWWPAGECOUNT"), ",", "."));
            AV8ApplicationId = (long)(context.localUtil.CToN( cgiGet( "vAPPLICATIONID"), ",", "."));
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
         E151E2 ();
         if (returnInSub) return;
      }

      protected void E151E2( )
      {
         /* Start Routine */
         divTablemain_Height = 600;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGridww_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV24GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24GridWWCurrentPage), 10, 0)));
         edtavGridwwcurrentpage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGridwwcurrentpage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGridwwcurrentpage_Visible), 5, 0)), true);
         AV25GridWWPageCount = -1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25GridWWPageCount), 10, 0)));
         GXt_boolean1 = AV29IsAuthorized_Name;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamapppermissionentry_Execute", out  GXt_boolean1) ;
         AV29IsAuthorized_Name = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29IsAuthorized_Name", AV29IsAuthorized_Name);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV29IsAuthorized_Name, context));
         Gridwwpaginationbar_Rowsperpageselectedvalue = subGridww_Rows;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Gridwwpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridwwpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         edtavBtnchildren_Title = "Children";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnchildren_Internalname, "Title", edtavBtnchildren_Title, !bGXsfl_55_Refreshing);
         AV7Application.load( AV8ApplicationId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ApplicationId), "ZZZZZZZZZZZ9"), context));
         Form.Caption = "Permissions of Application: "+AV7Application.gxTpr_Name;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
      }

      protected void E161E2( )
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

      private void E171E2( )
      {
         /* Gridww_Load Routine */
         AV7Application.load( AV8ApplicationId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8ApplicationId), "ZZZZZZZZZZZ9"), context));
         AV6AppId = AV8ApplicationId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAppid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV6AppId), 12, 0)));
         AV14Filter.gxTpr_Name = "%"+AV13FilName;
         AV14Filter.gxTpr_Accesstypedefault = AV19PermissionAccessTypeDefault;
         AV14Filter.gxTpr_Typefilter = AV20PermissionTypeFilter;
         AV14Filter.gxTpr_Isautomaticpermission = AV16isAutomaticPermission;
         AV32Permissions = AV7Application.getpermissions(AV14Filter, out  AV12Errors);
         if ( AV32Permissions.Count == 0 )
         {
            AV25GridWWPageCount = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25GridWWPageCount), 10, 0)));
         }
         else
         {
            AV25GridWWPageCount = (long)((AV32Permissions.Count/ (decimal)(9))+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25GridWWPageCount), 10, 0)));
         }
         AV34GridWWRecordCount = AV32Permissions.Count;
         AV33GridWWPageSize = 9;
         AV41GXV1 = 1;
         while ( AV41GXV1 <= AV32Permissions.Count )
         {
            AV9AppPermission = ((SdtGAMApplicationPermission)AV32Permissions.Item(AV41GXV1));
            AV15Id = AV9AppPermission.gxTpr_Guid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, AV15Id);
            AV18Name = AV9AppPermission.gxTpr_Name;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV18Name);
            AV11Dsc = AV9AppPermission.gxTpr_Description;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDsc_Internalname, AV11Dsc);
            AV5AccessType = AV9AppPermission.gxTpr_Accesstype;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavAccesstype_Internalname, AV5AccessType);
            AV10BtnUpd = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtnupd_Internalname, AV10BtnUpd);
            AV42Btnupd_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
            edtavBtnupd_Tooltiptext = "Update";
            if ( AV28IsAuthorized_BtnUpd )
            {
               edtavBtnupd_Link = formatLink("gamapppermissionentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +AV8ApplicationId) + "," + UrlEncode(StringUtil.RTrim(AV15Id));
            }
            AV23BtnDlt = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtndlt_Internalname, AV23BtnDlt);
            AV43Btndlt_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
            edtavBtndlt_Tooltiptext = "Delete";
            if ( AV27IsAuthorized_BtnDlt )
            {
               edtavBtndlt_Link = formatLink("gamapppermissionentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +AV8ApplicationId) + "," + UrlEncode(StringUtil.RTrim(AV15Id));
            }
            AV22BtnChildren = context.GetImagePath( "846cc5aa-e497-452c-bf2c-fdd868279a72", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtnchildren_Internalname, AV22BtnChildren);
            AV44Btnchildren_GXI = GXDbFile.PathToUrl( context.GetImagePath( "846cc5aa-e497-452c-bf2c-fdd868279a72", "", context.GetTheme( )));
            edtavBtnchildren_Tooltiptext = "Children";
            if ( AV26IsAuthorized_BtnChildren )
            {
               edtavBtnchildren_Link = formatLink("gamapppermissionchildren.aspx") + "?" + UrlEncode("" +AV8ApplicationId) + "," + UrlEncode(StringUtil.RTrim(AV15Id));
            }
            if ( AV29IsAuthorized_Name )
            {
               edtavName_Link = formatLink("gamapppermissionentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +AV8ApplicationId) + "," + UrlEncode(StringUtil.RTrim(AV15Id));
            }
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 55;
            }
            if ( ( subGridww_Islastpage == 1 ) || ( subGridww_Rows == 0 ) || ( ( GRIDWW_nCurrentRecord >= GRIDWW_nFirstRecordOnPage ) && ( GRIDWW_nCurrentRecord < GRIDWW_nFirstRecordOnPage + subGridww_Recordsperpage( ) ) ) )
            {
               sendrow_552( ) ;
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
            if ( isFullAjaxMode( ) && ! bGXsfl_55_Refreshing )
            {
               context.DoAjaxLoad(55, GridwwRow);
            }
            AV41GXV1 = (int)(AV41GXV1+1);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14Filter", AV14Filter);
         cmbavAccesstype.CurrentValue = StringUtil.RTrim( AV5AccessType);
      }

      protected void E131E2( )
      {
         /* Gridwwpaginationbar_Changepage Routine */
         if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Previous") == 0 )
         {
            AV24GridWWCurrentPage = (long)(AV24GridWWCurrentPage-1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24GridWWCurrentPage), 10, 0)));
            subgridww_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Next") == 0 )
         {
            AV24GridWWCurrentPage = (long)(AV24GridWWCurrentPage+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24GridWWCurrentPage), 10, 0)));
            subgridww_nextpage( ) ;
         }
         else
         {
            AV30PageToGo = (int)(NumberUtil.Val( Gridwwpaginationbar_Selectedpage, "."));
            AV24GridWWCurrentPage = AV30PageToGo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24GridWWCurrentPage), 10, 0)));
            subgridww_gotopage( AV30PageToGo) ;
         }
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
      }

      protected void E141E2( )
      {
         /* Gridwwpaginationbar_Changerowsperpage Routine */
         subGridww_Rows = Gridwwpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV24GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24GridWWCurrentPage), 10, 0)));
         subgridww_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV28IsAuthorized_BtnUpd;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamapppermissionentry_Execute", out  GXt_boolean1) ;
         AV28IsAuthorized_BtnUpd = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28IsAuthorized_BtnUpd", AV28IsAuthorized_BtnUpd);
         if ( ! ( AV28IsAuthorized_BtnUpd ) )
         {
            edtavBtnupd_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtnupd_Visible), 5, 0)), !bGXsfl_55_Refreshing);
         }
         GXt_boolean1 = AV27IsAuthorized_BtnDlt;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamapppermissionentry_Execute", out  GXt_boolean1) ;
         AV27IsAuthorized_BtnDlt = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27IsAuthorized_BtnDlt", AV27IsAuthorized_BtnDlt);
         if ( ! ( AV27IsAuthorized_BtnDlt ) )
         {
            edtavBtndlt_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtndlt_Visible), 5, 0)), !bGXsfl_55_Refreshing);
         }
         GXt_boolean1 = AV26IsAuthorized_BtnChildren;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamapppermissionchildren_Execute", out  GXt_boolean1) ;
         AV26IsAuthorized_BtnChildren = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26IsAuthorized_BtnChildren", AV26IsAuthorized_BtnChildren);
         if ( ! ( AV26IsAuthorized_BtnChildren ) )
         {
            edtavBtnchildren_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnchildren_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtnchildren_Visible), 5, 0)), !bGXsfl_55_Refreshing);
         }
         GXt_boolean1 = AV31TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamwwapplications_Execute", out  GXt_boolean1) ;
         AV31TempBoolean = GXt_boolean1;
         if ( ! ( AV31TempBoolean ) )
         {
            bttBtnback_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnback_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnback_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV31TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamapppermissionentry_Execute", out  GXt_boolean1) ;
         AV31TempBoolean = GXt_boolean1;
         if ( ! ( AV31TempBoolean ) )
         {
            bttBtnadd_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnadd_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnadd_Visible), 5, 0)), true);
         }
      }

      protected void wb_table1_29_1E2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablefilters_Internalname, tblTablefilters_Internalname, "", "Table100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellFormGroupMarginBottom5'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavFilname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFilname_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_55_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFilname_Internalname, StringUtil.RTrim( AV13FilName), StringUtil.RTrim( context.localUtil.Format( AV13FilName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFilname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavFilname_Enabled, 0, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMWWAppPermissions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellFormGroupMarginBottom5'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavPermissionaccesstypedefault_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavPermissionaccesstypedefault_Internalname, "Default Access", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_55_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPermissionaccesstypedefault, cmbavPermissionaccesstypedefault_Internalname, StringUtil.RTrim( AV19PermissionAccessTypeDefault), 1, cmbavPermissionaccesstypedefault_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavPermissionaccesstypedefault.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "", true, "HLP_GAMWWAppPermissions.htm");
            cmbavPermissionaccesstypedefault.CurrentValue = StringUtil.RTrim( AV19PermissionAccessTypeDefault);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPermissionaccesstypedefault_Internalname, "Values", (String)(cmbavPermissionaccesstypedefault.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellFormGroupMarginBottom5'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavPermissiontypefilter_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavPermissiontypefilter_Internalname, "Filter by", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_55_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPermissiontypefilter, cmbavPermissiontypefilter_Internalname, StringUtil.RTrim( AV20PermissionTypeFilter), 1, cmbavPermissiontypefilter_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavPermissiontypefilter.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "", true, "HLP_GAMWWAppPermissions.htm");
            cmbavPermissiontypefilter.CurrentValue = StringUtil.RTrim( AV20PermissionTypeFilter);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPermissiontypefilter_Internalname, "Values", (String)(cmbavPermissiontypefilter.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellFormGroupMarginBottom5'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavIsautomaticpermission_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavIsautomaticpermission_Internalname, "Only automatic permissions?", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_55_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavIsautomaticpermission, cmbavIsautomaticpermission_Internalname, StringUtil.RTrim( AV16isAutomaticPermission), 1, cmbavIsautomaticpermission_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavIsautomaticpermission.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,49);\"", "", true, "HLP_GAMWWAppPermissions.htm");
            cmbavIsautomaticpermission.CurrentValue = StringUtil.RTrim( AV16isAutomaticPermission);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavIsautomaticpermission_Internalname, "Values", (String)(cmbavIsautomaticpermission.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_29_1E2e( true) ;
         }
         else
         {
            wb_table1_29_1E2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8ApplicationId = Convert.ToInt64(getParm(obj,0));
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
         PA1E2( ) ;
         WS1E2( ) ;
         WE1E2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019443649", true);
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
            context.AddJavascriptSource("gamwwapppermissions.js", "?201892019443650", false);
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

      protected void SubsflControlProps_552( )
      {
         edtavAppid_Internalname = "vAPPID_"+sGXsfl_55_idx;
         edtavBtnupd_Internalname = "vBTNUPD_"+sGXsfl_55_idx;
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_55_idx;
         edtavBtnchildren_Internalname = "vBTNCHILDREN_"+sGXsfl_55_idx;
         edtavId_Internalname = "vID_"+sGXsfl_55_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_55_idx;
         edtavDsc_Internalname = "vDSC_"+sGXsfl_55_idx;
         cmbavAccesstype_Internalname = "vACCESSTYPE_"+sGXsfl_55_idx;
      }

      protected void SubsflControlProps_fel_552( )
      {
         edtavAppid_Internalname = "vAPPID_"+sGXsfl_55_fel_idx;
         edtavBtnupd_Internalname = "vBTNUPD_"+sGXsfl_55_fel_idx;
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_55_fel_idx;
         edtavBtnchildren_Internalname = "vBTNCHILDREN_"+sGXsfl_55_fel_idx;
         edtavId_Internalname = "vID_"+sGXsfl_55_fel_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_55_fel_idx;
         edtavDsc_Internalname = "vDSC_"+sGXsfl_55_fel_idx;
         cmbavAccesstype_Internalname = "vACCESSTYPE_"+sGXsfl_55_fel_idx;
      }

      protected void sendrow_552( )
      {
         SubsflControlProps_552( ) ;
         WB1E0( ) ;
         if ( ( subGridww_Rows * 1 == 0 ) || ( nGXsfl_55_idx <= subGridww_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_55_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_55_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavAppid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6AppId), 12, 0, ",", "")),((edtavAppid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6AppId), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6AppId), "ZZZZZZZZZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavAppid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavAppid_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)55,(short)1,(short)-1,(short)0,(bool)true,(String)"GAMKeyNumLong",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtnupd_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV10BtnUpd_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV10BtnUpd))&&String.IsNullOrEmpty(StringUtil.RTrim( AV42Btnupd_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV10BtnUpd)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV10BtnUpd)) ? AV42Btnupd_GXI : context.PathToRelativeUrl( AV10BtnUpd));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtnupd_Internalname,(String)sImgUrl,(String)edtavBtnupd_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtnupd_Visible,(short)1,(String)"",(String)edtavBtnupd_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV10BtnUpd_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtndlt_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute";
            StyleString = "";
            AV23BtnDlt_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV23BtnDlt))&&String.IsNullOrEmpty(StringUtil.RTrim( AV43Btndlt_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV23BtnDlt)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV23BtnDlt)) ? AV43Btndlt_GXI : context.PathToRelativeUrl( AV23BtnDlt));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtndlt_Internalname,(String)sImgUrl,(String)edtavBtndlt_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtndlt_Visible,(short)1,(String)"",(String)edtavBtndlt_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV23BtnDlt_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtnchildren_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV22BtnChildren_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV22BtnChildren))&&String.IsNullOrEmpty(StringUtil.RTrim( AV44Btnchildren_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV22BtnChildren)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV22BtnChildren)) ? AV44Btnchildren_GXI : context.PathToRelativeUrl( AV22BtnChildren));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtnchildren_Internalname,(String)sImgUrl,(String)edtavBtnchildren_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtnchildren_Visible,(short)1,(String)"",(String)edtavBtnchildren_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV22BtnChildren_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavId_Internalname,StringUtil.RTrim( AV15Id),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavId_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)55,(short)1,(short)-1,(short)0,(bool)true,(String)"GAMGUID",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavName_Internalname,StringUtil.RTrim( AV18Name),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavName_Link,(String)"",(String)"",(String)"",(String)edtavName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavName_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)120,(short)0,(short)0,(short)55,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionMedium",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDsc_Internalname,StringUtil.RTrim( AV11Dsc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavDsc_Enabled,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)254,(short)0,(short)0,(short)55,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionLong",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbavAccesstype.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "vACCESSTYPE_" + sGXsfl_55_idx;
               cmbavAccesstype.Name = GXCCtl;
               cmbavAccesstype.WebTags = "";
               cmbavAccesstype.addItem("A", "Allow", 0);
               cmbavAccesstype.addItem("R", "Restricted", 0);
               if ( cmbavAccesstype.ItemCount > 0 )
               {
                  AV5AccessType = cmbavAccesstype.getValidValue(AV5AccessType);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavAccesstype_Internalname, AV5AccessType);
               }
            }
            /* ComboBox */
            GridwwRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavAccesstype,(String)cmbavAccesstype_Internalname,StringUtil.RTrim( AV5AccessType),(short)1,(String)cmbavAccesstype_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,cmbavAccesstype.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbavAccesstype.CurrentValue = StringUtil.RTrim( AV5AccessType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavAccesstype_Internalname, "Values", (String)(cmbavAccesstype.ToJavascriptSource()), !bGXsfl_55_Refreshing);
            send_integrity_lvl_hashes1E2( ) ;
            GridwwContainer.AddRow(GridwwRow);
            nGXsfl_55_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_55_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_55_idx+1));
            sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0");
            SubsflControlProps_552( ) ;
         }
         /* End function sendrow_552 */
      }

      protected void init_default_properties( )
      {
         bttBtnback_Internalname = "BTNBACK";
         bttBtnadd_Internalname = "BTNADD";
         divTableactions_Internalname = "TABLEACTIONS";
         edtavFilname_Internalname = "vFILNAME";
         cmbavPermissionaccesstypedefault_Internalname = "vPERMISSIONACCESSTYPEDEFAULT";
         cmbavPermissiontypefilter_Internalname = "vPERMISSIONTYPEFILTER";
         cmbavIsautomaticpermission_Internalname = "vISAUTOMATICPERMISSION";
         tblTablefilters_Internalname = "TABLEFILTERS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavAppid_Internalname = "vAPPID";
         edtavBtnupd_Internalname = "vBTNUPD";
         edtavBtndlt_Internalname = "vBTNDLT";
         edtavBtnchildren_Internalname = "vBTNCHILDREN";
         edtavId_Internalname = "vID";
         edtavName_Internalname = "vNAME";
         edtavDsc_Internalname = "vDSC";
         cmbavAccesstype_Internalname = "vACCESSTYPE";
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
         cmbavAccesstype_Jsonclick = "";
         edtavDsc_Jsonclick = "";
         edtavName_Jsonclick = "";
         edtavId_Jsonclick = "";
         edtavAppid_Jsonclick = "";
         cmbavIsautomaticpermission_Jsonclick = "";
         cmbavIsautomaticpermission.Enabled = 1;
         cmbavPermissiontypefilter_Jsonclick = "";
         cmbavPermissiontypefilter.Enabled = 1;
         cmbavPermissionaccesstypedefault_Jsonclick = "";
         cmbavPermissionaccesstypedefault.Enabled = 1;
         edtavFilname_Jsonclick = "";
         edtavFilname_Enabled = 1;
         edtavGridwwcurrentpage_Jsonclick = "";
         edtavGridwwcurrentpage_Visible = 1;
         subGridww_Allowcollapsing = 0;
         subGridww_Allowselection = 0;
         edtavName_Link = "";
         edtavBtnchildren_Tooltiptext = "Children";
         edtavBtnchildren_Link = "";
         edtavBtndlt_Tooltiptext = "Delete";
         edtavBtndlt_Link = "";
         edtavBtnupd_Tooltiptext = "Update";
         edtavBtnupd_Link = "";
         cmbavAccesstype.Enabled = 0;
         edtavDsc_Enabled = 0;
         edtavName_Enabled = 0;
         edtavId_Enabled = 0;
         edtavBtnchildren_Visible = -1;
         edtavBtndlt_Visible = -1;
         edtavBtnupd_Visible = -1;
         edtavAppid_Enabled = 0;
         subGridww_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGridww_Backcolorstyle = 0;
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
         Form.Caption = "Application`s permissions";
         subGridww_Rows = 0;
         edtavBtnchildren_Title = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'edtavBtnchildren_Title',ctrl:'vBTNCHILDREN',prop:'Title'},{av:'AV13FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstypedefault'},{av:'AV19PermissionAccessTypeDefault',fld:'vPERMISSIONACCESSTYPEDEFAULT',pic:'',nv:''},{av:'cmbavPermissiontypefilter'},{av:'AV20PermissionTypeFilter',fld:'vPERMISSIONTYPEFILTER',pic:'',nv:''},{av:'cmbavIsautomaticpermission'},{av:'AV16isAutomaticPermission',fld:'vISAUTOMATICPERMISSION',pic:'',nv:''},{av:'AV28IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV27IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV26IsAuthorized_BtnChildren',fld:'vISAUTHORIZED_BTNCHILDREN',pic:'',nv:false},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV29IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false}],oparms:[{av:'AV28IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'edtavBtnupd_Visible',ctrl:'vBTNUPD',prop:'Visible'},{av:'AV27IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'edtavBtndlt_Visible',ctrl:'vBTNDLT',prop:'Visible'},{av:'AV26IsAuthorized_BtnChildren',fld:'vISAUTHORIZED_BTNCHILDREN',pic:'',nv:false},{av:'edtavBtnchildren_Visible',ctrl:'vBTNCHILDREN',prop:'Visible'},{ctrl:'BTNBACK',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDWW.LOAD","{handler:'E171E2',iparms:[{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV13FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstypedefault'},{av:'AV19PermissionAccessTypeDefault',fld:'vPERMISSIONACCESSTYPEDEFAULT',pic:'',nv:''},{av:'cmbavPermissiontypefilter'},{av:'AV20PermissionTypeFilter',fld:'vPERMISSIONTYPEFILTER',pic:'',nv:''},{av:'cmbavIsautomaticpermission'},{av:'AV16isAutomaticPermission',fld:'vISAUTOMATICPERMISSION',pic:'',nv:''},{av:'AV28IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV27IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV26IsAuthorized_BtnChildren',fld:'vISAUTHORIZED_BTNCHILDREN',pic:'',nv:false},{av:'AV29IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false}],oparms:[{av:'AV6AppId',fld:'vAPPID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV25GridWWPageCount',fld:'vGRIDWWPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0},{av:'AV15Id',fld:'vID',pic:'',nv:''},{av:'AV18Name',fld:'vNAME',pic:'',nv:''},{av:'AV11Dsc',fld:'vDSC',pic:'',nv:''},{av:'cmbavAccesstype'},{av:'AV5AccessType',fld:'vACCESSTYPE',pic:'',nv:''},{av:'AV10BtnUpd',fld:'vBTNUPD',pic:'',nv:''},{av:'edtavBtnupd_Tooltiptext',ctrl:'vBTNUPD',prop:'Tooltiptext'},{av:'edtavBtnupd_Link',ctrl:'vBTNUPD',prop:'Link'},{av:'AV23BtnDlt',fld:'vBTNDLT',pic:'',nv:''},{av:'edtavBtndlt_Tooltiptext',ctrl:'vBTNDLT',prop:'Tooltiptext'},{av:'edtavBtndlt_Link',ctrl:'vBTNDLT',prop:'Link'},{av:'AV22BtnChildren',fld:'vBTNCHILDREN',pic:'',nv:''},{av:'edtavBtnchildren_Tooltiptext',ctrl:'vBTNCHILDREN',prop:'Tooltiptext'},{av:'edtavBtnchildren_Link',ctrl:'vBTNCHILDREN',prop:'Link'},{av:'edtavName_Link',ctrl:'vNAME',prop:'Link'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEPAGE","{handler:'E131E2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'edtavBtnchildren_Title',ctrl:'vBTNCHILDREN',prop:'Title'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV13FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstypedefault'},{av:'AV19PermissionAccessTypeDefault',fld:'vPERMISSIONACCESSTYPEDEFAULT',pic:'',nv:''},{av:'cmbavPermissiontypefilter'},{av:'AV20PermissionTypeFilter',fld:'vPERMISSIONTYPEFILTER',pic:'',nv:''},{av:'cmbavIsautomaticpermission'},{av:'AV16isAutomaticPermission',fld:'vISAUTOMATICPERMISSION',pic:'',nv:''},{av:'AV28IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV27IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV26IsAuthorized_BtnChildren',fld:'vISAUTHORIZED_BTNCHILDREN',pic:'',nv:false},{av:'AV29IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false},{av:'Gridwwpaginationbar_Selectedpage',ctrl:'GRIDWWPAGINATIONBAR',prop:'SelectedPage'},{av:'AV24GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}],oparms:[{av:'AV24GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV28IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'edtavBtnupd_Visible',ctrl:'vBTNUPD',prop:'Visible'},{av:'AV27IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'edtavBtndlt_Visible',ctrl:'vBTNDLT',prop:'Visible'},{av:'AV26IsAuthorized_BtnChildren',fld:'vISAUTHORIZED_BTNCHILDREN',pic:'',nv:false},{av:'edtavBtnchildren_Visible',ctrl:'vBTNCHILDREN',prop:'Visible'},{ctrl:'BTNBACK',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E141E2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'edtavBtnchildren_Title',ctrl:'vBTNCHILDREN',prop:'Title'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV13FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstypedefault'},{av:'AV19PermissionAccessTypeDefault',fld:'vPERMISSIONACCESSTYPEDEFAULT',pic:'',nv:''},{av:'cmbavPermissiontypefilter'},{av:'AV20PermissionTypeFilter',fld:'vPERMISSIONTYPEFILTER',pic:'',nv:''},{av:'cmbavIsautomaticpermission'},{av:'AV16isAutomaticPermission',fld:'vISAUTOMATICPERMISSION',pic:'',nv:''},{av:'AV28IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV27IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV26IsAuthorized_BtnChildren',fld:'vISAUTHORIZED_BTNCHILDREN',pic:'',nv:false},{av:'AV29IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false},{av:'Gridwwpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDWWPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],oparms:[{av:'subGridww_Rows',ctrl:'GRIDWW',prop:'Rows'},{av:'AV24GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("'DOBACK'","{handler:'E111E1',iparms:[],oparms:[]}");
         setEventMetadata("'DOADD'","{handler:'E121E1',iparms:[{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
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
         AV13FilName = "";
         AV19PermissionAccessTypeDefault = "";
         AV20PermissionTypeFilter = "";
         AV16isAutomaticPermission = "";
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
         AV10BtnUpd = "";
         AV23BtnDlt = "";
         AV22BtnChildren = "";
         AV15Id = "";
         AV18Name = "";
         AV11Dsc = "";
         AV5AccessType = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV42Btnupd_GXI = "";
         AV43Btndlt_GXI = "";
         AV44Btnchildren_GXI = "";
         GXCCtl = "";
         AV7Application = new SdtGAMApplication(context);
         AV14Filter = new SdtGAMApplicationPermissionFilter(context);
         AV32Permissions = new GXExternalCollection<SdtGAMApplicationPermission>( context, "SdtGAMApplicationPermission", "GeneXus.Programs");
         AV12Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV9AppPermission = new SdtGAMApplicationPermission(context);
         GridwwRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         sImgUrl = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavAppid_Enabled = 0;
         edtavId_Enabled = 0;
         edtavName_Enabled = 0;
         edtavDsc_Enabled = 0;
         cmbavAccesstype.Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_55 ;
      private short nGXsfl_55_idx=1 ;
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
      private int subGridww_Titlebackcolor ;
      private int subGridww_Allbackcolor ;
      private int edtavBtnupd_Visible ;
      private int edtavBtndlt_Visible ;
      private int edtavBtnchildren_Visible ;
      private int edtavAppid_Enabled ;
      private int edtavId_Enabled ;
      private int edtavName_Enabled ;
      private int edtavDsc_Enabled ;
      private int subGridww_Selectioncolor ;
      private int subGridww_Hoveringcolor ;
      private int edtavGridwwcurrentpage_Visible ;
      private int subGridww_Islastpage ;
      private int GRIDWW_nGridOutOfScope ;
      private int AV41GXV1 ;
      private int AV30PageToGo ;
      private int edtavFilname_Enabled ;
      private int idxLst ;
      private int subGridww_Backcolor ;
      private long AV8ApplicationId ;
      private long wcpOAV8ApplicationId ;
      private long GRIDWW_nFirstRecordOnPage ;
      private long AV25GridWWPageCount ;
      private long AV6AppId ;
      private long AV24GridWWCurrentPage ;
      private long GRIDWW_nCurrentRecord ;
      private long GRIDWW_nRecordCount ;
      private long AV34GridWWRecordCount ;
      private long AV33GridWWPageSize ;
      private String edtavBtnchildren_Title ;
      private String Gridwwpaginationbar_Selectedpage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_55_idx="0001" ;
      private String edtavBtnchildren_Internalname ;
      private String AV13FilName ;
      private String AV19PermissionAccessTypeDefault ;
      private String AV20PermissionTypeFilter ;
      private String AV16isAutomaticPermission ;
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
      private String divGridwwtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGridww_Internalname ;
      private String subGridww_Class ;
      private String subGridww_Linesclass ;
      private String edtavBtnupd_Link ;
      private String edtavBtnupd_Tooltiptext ;
      private String edtavBtndlt_Link ;
      private String edtavBtndlt_Tooltiptext ;
      private String edtavBtnchildren_Link ;
      private String edtavBtnchildren_Tooltiptext ;
      private String AV15Id ;
      private String AV18Name ;
      private String edtavName_Link ;
      private String AV11Dsc ;
      private String AV5AccessType ;
      private String divHtml_gridwwpaginationbar_Internalname ;
      private String edtavGridwwcurrentpage_Internalname ;
      private String edtavGridwwcurrentpage_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavAppid_Internalname ;
      private String edtavBtnupd_Internalname ;
      private String edtavBtndlt_Internalname ;
      private String edtavId_Internalname ;
      private String edtavName_Internalname ;
      private String edtavDsc_Internalname ;
      private String cmbavAccesstype_Internalname ;
      private String GXCCtl ;
      private String edtavFilname_Internalname ;
      private String cmbavPermissionaccesstypedefault_Internalname ;
      private String cmbavPermissiontypefilter_Internalname ;
      private String cmbavIsautomaticpermission_Internalname ;
      private String Gridwwpaginationbar_Internalname ;
      private String tblTablefilters_Internalname ;
      private String edtavFilname_Jsonclick ;
      private String cmbavPermissionaccesstypedefault_Jsonclick ;
      private String cmbavPermissiontypefilter_Jsonclick ;
      private String cmbavIsautomaticpermission_Jsonclick ;
      private String sGXsfl_55_fel_idx="0001" ;
      private String ROClassString ;
      private String edtavAppid_Jsonclick ;
      private String sImgUrl ;
      private String edtavId_Jsonclick ;
      private String edtavName_Jsonclick ;
      private String edtavDsc_Jsonclick ;
      private String cmbavAccesstype_Jsonclick ;
      private String Dvpanel_tableheader_Internalname ;
      private bool entryPointCalled ;
      private bool bGXsfl_55_Refreshing=false ;
      private bool AV28IsAuthorized_BtnUpd ;
      private bool AV27IsAuthorized_BtnDlt ;
      private bool AV26IsAuthorized_BtnChildren ;
      private bool AV29IsAuthorized_Name ;
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
      private bool AV31TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV10BtnUpd_IsBlob ;
      private bool AV23BtnDlt_IsBlob ;
      private bool AV22BtnChildren_IsBlob ;
      private String AV42Btnupd_GXI ;
      private String AV43Btndlt_GXI ;
      private String AV44Btnchildren_GXI ;
      private String AV10BtnUpd ;
      private String AV23BtnDlt ;
      private String AV22BtnChildren ;
      private GXWebGrid GridwwContainer ;
      private GXWebRow GridwwRow ;
      private GXWebColumn GridwwColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavPermissionaccesstypedefault ;
      private GXCombobox cmbavPermissiontypefilter ;
      private GXCombobox cmbavIsautomaticpermission ;
      private GXCombobox cmbavAccesstype ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMError> AV12Errors ;
      private GXExternalCollection<SdtGAMApplicationPermission> AV32Permissions ;
      private GXWebForm Form ;
      private SdtGAMApplication AV7Application ;
      private SdtGAMApplicationPermission AV9AppPermission ;
      private SdtGAMApplicationPermissionFilter AV14Filter ;
   }

}
