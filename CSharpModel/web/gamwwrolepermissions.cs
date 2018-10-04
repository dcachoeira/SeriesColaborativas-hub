/*
               File: GAMWWRolePermissions
        Description: Role´s permissions
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:41:25.5
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
   public class gamwwrolepermissions : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamwwrolepermissions( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamwwrolepermissions( IGxContext context )
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
                           long aP1_pApplicationId )
      {
         this.AV26RoleId = aP0_RoleId;
         this.AV22pApplicationId = aP1_pApplicationId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavApplicationid = new GXCombobox();
         cmbavPermissionaccesstype = new GXCombobox();
         cmbavIsinherited = new GXCombobox();
         cmbavOld_accesstype = new GXCombobox();
         chkavOld_inherited = new GXCheckbox();
         cmbavAccesstype = new GXCombobox();
         chkavInherited = new GXCheckbox();
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
               nRC_GXsfl_57 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_57_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_57_idx = GetNextPar( );
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
               AV26RoleId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV8ApplicationId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV14FilName = GetNextPar( );
               AV24PermissionAccessType = GetNextPar( );
               AV32IsInherited = GetNextPar( );
               AV22pApplicationId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridww_refresh( subGridww_Rows, AV26RoleId, AV8ApplicationId, AV14FilName, AV24PermissionAccessType, AV32IsInherited, AV22pApplicationId) ;
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
               AV26RoleId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavRoleid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV26RoleId), 12, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, context.localUtil.Format( (decimal)(AV26RoleId), "ZZZZZZZZZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV22pApplicationId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22pApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22pApplicationId), 12, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22pApplicationId), "ZZZZZZZZZZZ9"), context));
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
         PA0S2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0S2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019412574", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamwwrolepermissions.aspx") + "?" + UrlEncode("" +AV26RoleId) + "," + UrlEncode("" +AV22pApplicationId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_57", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_57), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDWWPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31GridWWPageCount), 10, 0, ",", "")));
         GxWebStd.gx_boolean_hidden_field( context, "vISOK", AV18isOK);
         GxWebStd.gx_hidden_field( context, "vPAPPLICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22pApplicationId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22pApplicationId), "ZZZZZZZZZZZ9"), context));
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
            WE0S2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0S2( ) ;
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
         return formatLink("gamwwrolepermissions.aspx") + "?" + UrlEncode("" +AV26RoleId) + "," + UrlEncode("" +AV22pApplicationId) ;
      }

      public override String GetPgmname( )
      {
         return "GAMWWRolePermissions" ;
      }

      public override String GetPgmdesc( )
      {
         return "Role´s permissions" ;
      }

      protected void WB0S0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtnback_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(57), 2, 0)+","+"null"+");", "Back", bttBtnback_Jsonclick, 7, "Back", "", StyleString, ClassString, bttBtnback_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e110s1_client"+"'", TempTags, "", 2, "HLP_GAMWWRolePermissions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnadd_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(57), 2, 0)+","+"null"+");", "Insert", bttBtnadd_Jsonclick, 7, "Add permissions", "", StyleString, ClassString, bttBtnadd_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e120s1_client"+"'", TempTags, "", 2, "HLP_GAMWWRolePermissions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnsave_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(57), 2, 0)+","+"null"+");", "Save changes", bttBtnsave_Jsonclick, 5, "Save changes", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOSAVE\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMWWRolePermissions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-5 CellFloatRight CellWidthAuto", "left", "top", "", "", "div");
            wb_table1_31_0S2( true) ;
         }
         else
         {
            wb_table1_31_0S2( false) ;
         }
         return  ;
      }

      protected void wb_table1_31_0S2e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"DivS\" data-gxgridid=\"57\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Old Access Type") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Boolean") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Key Numeric Long") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Key Numeric Long") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Permission Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Description") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Access Type") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Inherited") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "GUID") ;
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
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV10BtnDlt));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtndlt_Tooltiptext));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV20old_AccessType));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbavOld_accesstype.Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV21Old_Inherited));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavOld_inherited.Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26RoleId), 12, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavRoleid_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29AppId), 12, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavAppid_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV19Name));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavName_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV11Dsc));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDsc_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV5AccessType));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV17Inherited));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV16Id));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavId_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowselection), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Selectioncolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowhovering), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Hoveringcolor), 9, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Allowcollapsing), 1, 0, ".", "")));
               GridwwContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 57 )
         {
            wbEnd = 0;
            nRC_GXsfl_57 = (short)(nGXsfl_57_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_57_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGridwwcurrentpage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30GridWWCurrentPage), 10, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV30GridWWCurrentPage), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGridwwcurrentpage_Jsonclick, 0, "Attribute", "", "", "", "", edtavGridwwcurrentpage_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMWWRolePermissions.htm");
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

      protected void START0S2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Role´s permissions", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0S0( ) ;
      }

      protected void WS0S2( )
      {
         START0S2( ) ;
         EVT0S2( ) ;
      }

      protected void EVT0S2( )
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
                              E130S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E140S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOSAVE'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoSave' */
                              E150S2 ();
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
                              nGXsfl_57_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_57_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_57_idx), 4, 0)), 4, "0");
                              SubsflControlProps_572( ) ;
                              AV10BtnDlt = cgiGet( edtavBtndlt_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV10BtnDlt)) ? AV47Btndlt_GXI : context.convertURL( context.PathToRelativeUrl( AV10BtnDlt))), !bGXsfl_57_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "SrcSet", context.GetImageSrcSet( AV10BtnDlt), true);
                              cmbavOld_accesstype.Name = cmbavOld_accesstype_Internalname;
                              cmbavOld_accesstype.CurrentValue = cgiGet( cmbavOld_accesstype_Internalname);
                              AV20old_AccessType = cgiGet( cmbavOld_accesstype_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavOld_accesstype_Internalname, AV20old_AccessType);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vOLD_ACCESSTYPE"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, StringUtil.RTrim( context.localUtil.Format( AV20old_AccessType, "")), context));
                              AV21Old_Inherited = StringUtil.StrToBool( cgiGet( chkavOld_inherited_Internalname));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavOld_inherited_Internalname, AV21Old_Inherited);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vOLD_INHERITED"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, AV21Old_Inherited, context));
                              AV26RoleId = (long)(context.localUtil.CToN( cgiGet( edtavRoleid_Internalname), ",", "."));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavRoleid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV26RoleId), 12, 0)));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, context.localUtil.Format( (decimal)(AV26RoleId), "ZZZZZZZZZZZ9"), context));
                              if ( ( ( context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vAPPID");
                                 GX_FocusControl = edtavAppid_Internalname;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true;
                                 AV29AppId = 0;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAppid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV29AppId), 12, 0)));
                              }
                              else
                              {
                                 AV29AppId = (long)(context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", "."));
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAppid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV29AppId), 12, 0)));
                              }
                              AV19Name = cgiGet( edtavName_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV19Name);
                              AV11Dsc = cgiGet( edtavDsc_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDsc_Internalname, AV11Dsc);
                              cmbavAccesstype.Name = cmbavAccesstype_Internalname;
                              cmbavAccesstype.CurrentValue = cgiGet( cmbavAccesstype_Internalname);
                              AV5AccessType = cgiGet( cmbavAccesstype_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavAccesstype_Internalname, AV5AccessType);
                              AV17Inherited = StringUtil.StrToBool( cgiGet( chkavInherited_Internalname));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavInherited_Internalname, AV17Inherited);
                              AV16Id = cgiGet( edtavId_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, AV16Id);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, StringUtil.RTrim( context.localUtil.Format( AV16Id, "")), context));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E160S2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E170S2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDWW.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E180S2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VBTNDLT.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E190S2 ();
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

      protected void WE0S2( )
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

      protected void PA0S2( )
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
            cmbavApplicationid.Name = "vAPPLICATIONID";
            cmbavApplicationid.WebTags = "";
            if ( cmbavApplicationid.ItemCount > 0 )
            {
               AV8ApplicationId = (long)(NumberUtil.Val( cmbavApplicationid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0)));
            }
            cmbavPermissionaccesstype.Name = "vPERMISSIONACCESSTYPE";
            cmbavPermissionaccesstype.WebTags = "";
            cmbavPermissionaccesstype.addItem("", "(Nenhum)", 0);
            cmbavPermissionaccesstype.addItem("A", "Allow", 0);
            cmbavPermissionaccesstype.addItem("D", "Deny", 0);
            cmbavPermissionaccesstype.addItem("R", "Restricted", 0);
            if ( cmbavPermissionaccesstype.ItemCount > 0 )
            {
               AV24PermissionAccessType = cmbavPermissionaccesstype.getValidValue(AV24PermissionAccessType);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24PermissionAccessType", AV24PermissionAccessType);
            }
            cmbavIsinherited.Name = "vISINHERITED";
            cmbavIsinherited.WebTags = "";
            cmbavIsinherited.addItem("A", "All", 0);
            cmbavIsinherited.addItem("T", "Yes", 0);
            cmbavIsinherited.addItem("F", "No", 0);
            if ( cmbavIsinherited.ItemCount > 0 )
            {
               AV32IsInherited = cmbavIsinherited.getValidValue(AV32IsInherited);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32IsInherited", AV32IsInherited);
            }
            GXCCtl = "vOLD_ACCESSTYPE_" + sGXsfl_57_idx;
            cmbavOld_accesstype.Name = GXCCtl;
            cmbavOld_accesstype.WebTags = "";
            cmbavOld_accesstype.addItem("A", "Allow", 0);
            cmbavOld_accesstype.addItem("D", "Deny", 0);
            cmbavOld_accesstype.addItem("R", "Restricted", 0);
            if ( cmbavOld_accesstype.ItemCount > 0 )
            {
               AV20old_AccessType = cmbavOld_accesstype.getValidValue(AV20old_AccessType);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavOld_accesstype_Internalname, AV20old_AccessType);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vOLD_ACCESSTYPE"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, StringUtil.RTrim( context.localUtil.Format( AV20old_AccessType, "")), context));
            }
            GXCCtl = "vOLD_INHERITED_" + sGXsfl_57_idx;
            chkavOld_inherited.Name = GXCCtl;
            chkavOld_inherited.WebTags = "";
            chkavOld_inherited.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavOld_inherited_Internalname, "TitleCaption", chkavOld_inherited.Caption, !bGXsfl_57_Refreshing);
            chkavOld_inherited.CheckedValue = "false";
            GXCCtl = "vACCESSTYPE_" + sGXsfl_57_idx;
            cmbavAccesstype.Name = GXCCtl;
            cmbavAccesstype.WebTags = "";
            cmbavAccesstype.addItem("A", "Allow", 0);
            cmbavAccesstype.addItem("D", "Deny", 0);
            cmbavAccesstype.addItem("R", "Restricted", 0);
            if ( cmbavAccesstype.ItemCount > 0 )
            {
               AV5AccessType = cmbavAccesstype.getValidValue(AV5AccessType);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavAccesstype_Internalname, AV5AccessType);
            }
            GXCCtl = "vINHERITED_" + sGXsfl_57_idx;
            chkavInherited.Name = GXCCtl;
            chkavInherited.WebTags = "";
            chkavInherited.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavInherited_Internalname, "TitleCaption", chkavInherited.Caption, !bGXsfl_57_Refreshing);
            chkavInherited.CheckedValue = "false";
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = cmbavApplicationid_Internalname;
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
         SubsflControlProps_572( ) ;
         while ( nGXsfl_57_idx <= nRC_GXsfl_57 )
         {
            sendrow_572( ) ;
            nGXsfl_57_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_57_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_57_idx+1));
            sGXsfl_57_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_57_idx), 4, 0)), 4, "0");
            SubsflControlProps_572( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridwwContainer));
         /* End function gxnrGridww_newrow */
      }

      protected void gxgrGridww_refresh( int subGridww_Rows ,
                                         long AV26RoleId ,
                                         long AV8ApplicationId ,
                                         String AV14FilName ,
                                         String AV24PermissionAccessType ,
                                         String AV32IsInherited ,
                                         long AV22pApplicationId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         GRIDWW_nCurrentRecord = 0;
         RF0S2( ) ;
         /* End function gxgrGridww_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV26RoleId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26RoleId), 12, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vOLD_ACCESSTYPE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV20old_AccessType, "")), context));
         GxWebStd.gx_hidden_field( context, "vOLD_ACCESSTYPE", StringUtil.RTrim( AV20old_AccessType));
         GxWebStd.gx_hidden_field( context, "gxhash_vOLD_INHERITED", GetSecureSignedToken( "", AV21Old_Inherited, context));
         GxWebStd.gx_hidden_field( context, "vOLD_INHERITED", StringUtil.BoolToStr( AV21Old_Inherited));
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV16Id, "")), context));
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.RTrim( AV16Id));
      }

      protected void fix_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
         }
         if ( cmbavApplicationid.ItemCount > 0 )
         {
            AV8ApplicationId = (long)(NumberUtil.Val( cmbavApplicationid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavApplicationid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavApplicationid_Internalname, "Values", cmbavApplicationid.ToJavascriptSource(), true);
         }
         if ( cmbavPermissionaccesstype.ItemCount > 0 )
         {
            AV24PermissionAccessType = cmbavPermissionaccesstype.getValidValue(AV24PermissionAccessType);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24PermissionAccessType", AV24PermissionAccessType);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavPermissionaccesstype.CurrentValue = StringUtil.RTrim( AV24PermissionAccessType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPermissionaccesstype_Internalname, "Values", cmbavPermissionaccesstype.ToJavascriptSource(), true);
         }
         if ( cmbavIsinherited.ItemCount > 0 )
         {
            AV32IsInherited = cmbavIsinherited.getValidValue(AV32IsInherited);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32IsInherited", AV32IsInherited);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavIsinherited.CurrentValue = StringUtil.RTrim( AV32IsInherited);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavIsinherited_Internalname, "Values", cmbavIsinherited.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0S2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         cmbavOld_accesstype.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavOld_accesstype_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavOld_accesstype.Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         chkavOld_inherited.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavOld_inherited_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavOld_inherited.Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         edtavRoleid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRoleid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRoleid_Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         edtavAppid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAppid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAppid_Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         edtavName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         edtavDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDsc_Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), !bGXsfl_57_Refreshing);
      }

      protected void RF0S2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridwwContainer.ClearRows();
         }
         wbStart = 57;
         /* Execute user event: Refresh */
         E170S2 ();
         nGXsfl_57_idx = 1;
         sGXsfl_57_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_57_idx), 4, 0)), 4, "0");
         SubsflControlProps_572( ) ;
         bGXsfl_57_Refreshing = true;
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
            SubsflControlProps_572( ) ;
            E180S2 ();
            if ( ( GRIDWW_nCurrentRecord > 0 ) && ( GRIDWW_nGridOutOfScope == 0 ) && ( nGXsfl_57_idx == 1 ) )
            {
               GRIDWW_nCurrentRecord = 0;
               GRIDWW_nGridOutOfScope = 1;
               subgridww_firstpage( ) ;
               E180S2 ();
            }
            wbEnd = 57;
            WB0S0( ) ;
         }
         bGXsfl_57_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0S2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vROLEID"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, context.localUtil.Format( (decimal)(AV26RoleId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vOLD_ACCESSTYPE"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, StringUtil.RTrim( context.localUtil.Format( AV20old_AccessType, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vOLD_INHERITED"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, AV21Old_Inherited, context));
         GxWebStd.gx_hidden_field( context, "gxhash_vID"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, StringUtil.RTrim( context.localUtil.Format( AV16Id, "")), context));
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
            gxgrGridww_refresh( subGridww_Rows, AV26RoleId, AV8ApplicationId, AV14FilName, AV24PermissionAccessType, AV32IsInherited, AV22pApplicationId) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV26RoleId, AV8ApplicationId, AV14FilName, AV24PermissionAccessType, AV32IsInherited, AV22pApplicationId) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV26RoleId, AV8ApplicationId, AV14FilName, AV24PermissionAccessType, AV32IsInherited, AV22pApplicationId) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV26RoleId, AV8ApplicationId, AV14FilName, AV24PermissionAccessType, AV32IsInherited, AV22pApplicationId) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV26RoleId, AV8ApplicationId, AV14FilName, AV24PermissionAccessType, AV32IsInherited, AV22pApplicationId) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP0S0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         cmbavOld_accesstype.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavOld_accesstype_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavOld_accesstype.Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         chkavOld_inherited.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavOld_inherited_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavOld_inherited.Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         edtavRoleid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRoleid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRoleid_Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         edtavAppid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAppid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAppid_Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         edtavName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         edtavDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDsc_Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), !bGXsfl_57_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E160S2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbavApplicationid.Name = cmbavApplicationid_Internalname;
            cmbavApplicationid.CurrentValue = cgiGet( cmbavApplicationid_Internalname);
            AV8ApplicationId = (long)(NumberUtil.Val( cgiGet( cmbavApplicationid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0)));
            AV14FilName = cgiGet( edtavFilname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14FilName", AV14FilName);
            cmbavPermissionaccesstype.Name = cmbavPermissionaccesstype_Internalname;
            cmbavPermissionaccesstype.CurrentValue = cgiGet( cmbavPermissionaccesstype_Internalname);
            AV24PermissionAccessType = cgiGet( cmbavPermissionaccesstype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24PermissionAccessType", AV24PermissionAccessType);
            cmbavIsinherited.Name = cmbavIsinherited_Internalname;
            cmbavIsinherited.CurrentValue = cgiGet( cmbavIsinherited_Internalname);
            AV32IsInherited = cgiGet( cmbavIsinherited_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32IsInherited", AV32IsInherited);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vGRIDWWCURRENTPAGE");
               GX_FocusControl = edtavGridwwcurrentpage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV30GridWWCurrentPage = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridWWCurrentPage), 10, 0)));
            }
            else
            {
               AV30GridWWCurrentPage = (long)(context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridWWCurrentPage), 10, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_57 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_57"), ",", "."));
            AV31GridWWPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDWWPAGECOUNT"), ",", "."));
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
         E160S2 ();
         if (returnInSub) return;
      }

      protected void E160S2( )
      {
         /* Start Routine */
         cmbavApplicationid.removeAllItems();
         cmbavApplicationid.addItem("0", "(Select)", 0);
         AV45GXV2 = 1;
         AV44GXV1 = new SdtGAMRepository(context).getapplications(AV7ApplicationFilter, out  AV13Errors);
         while ( AV45GXV2 <= AV44GXV1.Count )
         {
            AV6Application = ((SdtGAMApplication)AV44GXV1.Item(AV45GXV2));
            cmbavApplicationid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV6Application.gxTpr_Id), 12, 0)), AV6Application.gxTpr_Name, 0);
            AV45GXV2 = (int)(AV45GXV2+1);
         }
         if ( cmbavApplicationid.ItemCount == 2 )
         {
            AV8ApplicationId = AV6Application.gxTpr_Id;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0)));
         }
         else
         {
            AV8ApplicationId = AV22pApplicationId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0)));
         }
         divTablemain_Height = 600;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGridww_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV30GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridWWCurrentPage), 10, 0)));
         edtavGridwwcurrentpage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGridwwcurrentpage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGridwwcurrentpage_Visible), 5, 0)), true);
         AV31GridWWPageCount = -1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31GridWWPageCount), 10, 0)));
         Gridwwpaginationbar_Rowsperpageselectedvalue = subGridww_Rows;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Gridwwpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridwwpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         AV15GAMRole.load( AV26RoleId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavRoleid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV26RoleId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, context.localUtil.Format( (decimal)(AV26RoleId), "ZZZZZZZZZZZ9"), context));
         Form.Caption = "Permissions of Role: "+AV15GAMRole.gxTpr_Name;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
      }

      protected void E170S2( )
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

      private void E180S2( )
      {
         /* Gridww_Load Routine */
         AV15GAMRole.load( AV26RoleId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavRoleid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV26RoleId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, context.localUtil.Format( (decimal)(AV26RoleId), "ZZZZZZZZZZZ9"), context));
         AV27RolePermissionFilter.gxTpr_Applicationid = AV8ApplicationId;
         AV27RolePermissionFilter.gxTpr_Name = "%"+AV14FilName;
         AV27RolePermissionFilter.gxTpr_Accesstype = AV24PermissionAccessType;
         AV27RolePermissionFilter.gxTpr_Inherited = AV32IsInherited;
         if ( ! (0==AV8ApplicationId) )
         {
            AV35Permissions = AV15GAMRole.getpermissions(AV27RolePermissionFilter, out  AV13Errors);
            if ( AV35Permissions.Count == 0 )
            {
               AV31GridWWPageCount = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31GridWWPageCount), 10, 0)));
            }
            else
            {
               AV31GridWWPageCount = (long)((AV35Permissions.Count/ (decimal)(9))+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31GridWWPageCount), 10, 0)));
            }
            AV37GridWWRecordCount = AV35Permissions.Count;
            AV36GridWWPageSize = 9;
            AV46GXV3 = 1;
            while ( AV46GXV3 <= AV35Permissions.Count )
            {
               AV23Permission = ((SdtGAMPermission)AV35Permissions.Item(AV46GXV3));
               AV10BtnDlt = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtndlt_Internalname, AV10BtnDlt);
               AV47Btndlt_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
               AV16Id = AV23Permission.gxTpr_Guid;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, AV16Id);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, StringUtil.RTrim( context.localUtil.Format( AV16Id, "")), context));
               AV19Name = AV23Permission.gxTpr_Name;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV19Name);
               AV11Dsc = AV23Permission.gxTpr_Description;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDsc_Internalname, AV11Dsc);
               AV5AccessType = AV23Permission.gxTpr_Type;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavAccesstype_Internalname, AV5AccessType);
               AV17Inherited = AV23Permission.gxTpr_Inherited;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavInherited_Internalname, AV17Inherited);
               AV20old_AccessType = AV23Permission.gxTpr_Type;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavOld_accesstype_Internalname, AV20old_AccessType);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vOLD_ACCESSTYPE"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, StringUtil.RTrim( context.localUtil.Format( AV20old_AccessType, "")), context));
               AV21Old_Inherited = AV23Permission.gxTpr_Inherited;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavOld_inherited_Internalname, AV21Old_Inherited);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vOLD_INHERITED"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, AV21Old_Inherited, context));
               /* Load Method */
               if ( wbStart != -1 )
               {
                  wbStart = 57;
               }
               if ( ( subGridww_Islastpage == 1 ) || ( subGridww_Rows == 0 ) || ( ( GRIDWW_nCurrentRecord >= GRIDWW_nFirstRecordOnPage ) && ( GRIDWW_nCurrentRecord < GRIDWW_nFirstRecordOnPage + subGridww_Recordsperpage( ) ) ) )
               {
                  sendrow_572( ) ;
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
               if ( isFullAjaxMode( ) && ! bGXsfl_57_Refreshing )
               {
                  context.DoAjaxLoad(57, GridwwRow);
               }
               AV46GXV3 = (int)(AV46GXV3+1);
            }
         }
         AV10BtnDlt = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtndlt_Internalname, AV10BtnDlt);
         AV47Btndlt_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavBtndlt_Tooltiptext = "Revoke";
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27RolePermissionFilter", AV27RolePermissionFilter);
         cmbavAccesstype.CurrentValue = StringUtil.RTrim( AV5AccessType);
         cmbavOld_accesstype.CurrentValue = StringUtil.RTrim( AV20old_AccessType);
      }

      protected void E130S2( )
      {
         /* Gridwwpaginationbar_Changepage Routine */
         if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Previous") == 0 )
         {
            AV30GridWWCurrentPage = (long)(AV30GridWWCurrentPage-1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridWWCurrentPage), 10, 0)));
            subgridww_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Next") == 0 )
         {
            AV30GridWWCurrentPage = (long)(AV30GridWWCurrentPage+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridWWCurrentPage), 10, 0)));
            subgridww_nextpage( ) ;
         }
         else
         {
            AV33PageToGo = (int)(NumberUtil.Val( Gridwwpaginationbar_Selectedpage, "."));
            AV30GridWWCurrentPage = AV33PageToGo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridWWCurrentPage), 10, 0)));
            subgridww_gotopage( AV33PageToGo) ;
         }
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
      }

      protected void E140S2( )
      {
         /* Gridwwpaginationbar_Changerowsperpage Routine */
         subGridww_Rows = Gridwwpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV30GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridWWCurrentPage), 10, 0)));
         subgridww_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E150S2( )
      {
         /* 'DoSave' Routine */
         AV15GAMRole.load( AV26RoleId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavRoleid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV26RoleId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, context.localUtil.Format( (decimal)(AV26RoleId), "ZZZZZZZZZZZ9"), context));
         /* Start For Each Line */
         nRC_GXsfl_57 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_57"), ",", "."));
         nGXsfl_57_fel_idx = 0;
         while ( nGXsfl_57_fel_idx < nRC_GXsfl_57 )
         {
            nGXsfl_57_fel_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_57_fel_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_57_fel_idx+1));
            sGXsfl_57_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_57_fel_idx), 4, 0)), 4, "0");
            SubsflControlProps_fel_572( ) ;
            AV10BtnDlt = cgiGet( edtavBtndlt_Internalname);
            cmbavOld_accesstype.Name = cmbavOld_accesstype_Internalname;
            cmbavOld_accesstype.CurrentValue = cgiGet( cmbavOld_accesstype_Internalname);
            AV20old_AccessType = cgiGet( cmbavOld_accesstype_Internalname);
            AV21Old_Inherited = StringUtil.StrToBool( cgiGet( chkavOld_inherited_Internalname));
            AV26RoleId = (long)(context.localUtil.CToN( cgiGet( edtavRoleid_Internalname), ",", "."));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vAPPID");
               GX_FocusControl = edtavAppid_Internalname;
               wbErr = true;
               AV29AppId = 0;
            }
            else
            {
               AV29AppId = (long)(context.localUtil.CToN( cgiGet( edtavAppid_Internalname), ",", "."));
            }
            AV19Name = cgiGet( edtavName_Internalname);
            AV11Dsc = cgiGet( edtavDsc_Internalname);
            cmbavAccesstype.Name = cmbavAccesstype_Internalname;
            cmbavAccesstype.CurrentValue = cgiGet( cmbavAccesstype_Internalname);
            AV5AccessType = cgiGet( cmbavAccesstype_Internalname);
            AV17Inherited = StringUtil.StrToBool( cgiGet( chkavInherited_Internalname));
            AV16Id = cgiGet( edtavId_Internalname);
            if ( ( StringUtil.StrCmp(AV5AccessType, AV20old_AccessType) != 0 ) || ( AV17Inherited != AV21Old_Inherited ) )
            {
               AV25PermissionUpd.gxTpr_Applicationid = AV8ApplicationId;
               AV25PermissionUpd.gxTpr_Guid = AV16Id;
               AV25PermissionUpd.gxTpr_Type = AV5AccessType;
               AV25PermissionUpd.gxTpr_Inherited = AV17Inherited;
               AV18isOK = AV15GAMRole.updatepermission(AV25PermissionUpd, out  AV13Errors);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18isOK", AV18isOK);
               if ( ! AV18isOK )
               {
                  AV49GXV4 = 1;
                  while ( AV49GXV4 <= AV13Errors.Count )
                  {
                     AV12Error = ((SdtGAMError)AV13Errors.Item(AV49GXV4));
                     GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV12Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
                     AV49GXV4 = (int)(AV49GXV4+1);
                  }
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            /* End For Each Line */
         }
         if ( nGXsfl_57_fel_idx == 0 )
         {
            nGXsfl_57_idx = 1;
            sGXsfl_57_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_57_idx), 4, 0)), 4, "0");
            SubsflControlProps_572( ) ;
         }
         nGXsfl_57_fel_idx = 1;
         if ( AV18isOK )
         {
            pr_gam.commit( "GAMWWRolePermissions");
            pr_default.commit( "GAMWWRolePermissions");
            GX_msglist.addItem("Changes saved successfully.");
         }
         else
         {
            AV50GXV5 = 1;
            while ( AV50GXV5 <= AV13Errors.Count )
            {
               AV12Error = ((SdtGAMError)AV13Errors.Item(AV50GXV5));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV12Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
               AV50GXV5 = (int)(AV50GXV5+1);
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25PermissionUpd", AV25PermissionUpd);
      }

      protected void S112( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV34TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamwwroles_Execute", out  GXt_boolean1) ;
         AV34TempBoolean = GXt_boolean1;
         if ( ! ( AV34TempBoolean ) )
         {
            bttBtnback_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnback_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnback_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV34TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamrolepermissionselect_Execute", out  GXt_boolean1) ;
         AV34TempBoolean = GXt_boolean1;
         if ( ! ( AV34TempBoolean ) )
         {
            bttBtnadd_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnadd_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnadd_Visible), 5, 0)), true);
         }
      }

      protected void E190S2( )
      {
         /* Btndlt_Click Routine */
         AV15GAMRole.load( AV26RoleId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavRoleid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV26RoleId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, context.localUtil.Format( (decimal)(AV26RoleId), "ZZZZZZZZZZZ9"), context));
         AV18isOK = AV15GAMRole.deletepermissionbyid(AV8ApplicationId, AV16Id, out  AV13Errors);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18isOK", AV18isOK);
         if ( AV18isOK )
         {
            pr_gam.commit( "GAMWWRolePermissions");
            pr_default.commit( "GAMWWRolePermissions");
            context.DoAjaxRefresh();
         }
         else
         {
            AV51GXV6 = 1;
            while ( AV51GXV6 <= AV13Errors.Count )
            {
               AV12Error = ((SdtGAMError)AV13Errors.Item(AV51GXV6));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV12Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
               AV51GXV6 = (int)(AV51GXV6+1);
            }
         }
         /*  Sending Event outputs  */
      }

      protected void wb_table1_31_0S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablefilters_Internalname, tblTablefilters_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellFormGroupMarginBottom5'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavApplicationid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavApplicationid_Internalname, "Application", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_57_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavApplicationid, cmbavApplicationid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0)), 1, cmbavApplicationid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavApplicationid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "", true, "HLP_GAMWWRolePermissions.htm");
            cmbavApplicationid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV8ApplicationId), 12, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavApplicationid_Internalname, "Values", (String)(cmbavApplicationid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellFormGroupMarginBottom5'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavFilname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFilname_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_57_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFilname_Internalname, StringUtil.RTrim( AV14FilName), StringUtil.RTrim( context.localUtil.Format( AV14FilName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,41);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFilname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavFilname_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionShort", "left", true, "HLP_GAMWWRolePermissions.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_57_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPermissionaccesstype, cmbavPermissionaccesstype_Internalname, StringUtil.RTrim( AV24PermissionAccessType), 1, cmbavPermissionaccesstype_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavPermissionaccesstype.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "", true, "HLP_GAMWWRolePermissions.htm");
            cmbavPermissionaccesstype.CurrentValue = StringUtil.RTrim( AV24PermissionAccessType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPermissionaccesstype_Internalname, "Values", (String)(cmbavPermissionaccesstype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellFormGroupMarginBottom5'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavIsinherited_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavIsinherited_Internalname, "Inherited?", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_57_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavIsinherited, cmbavIsinherited_Internalname, StringUtil.RTrim( AV32IsInherited), 1, cmbavIsinherited_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavIsinherited.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,51);\"", "", true, "HLP_GAMWWRolePermissions.htm");
            cmbavIsinherited.CurrentValue = StringUtil.RTrim( AV32IsInherited);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavIsinherited_Internalname, "Values", (String)(cmbavIsinherited.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_31_0S2e( true) ;
         }
         else
         {
            wb_table1_31_0S2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV26RoleId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavRoleid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV26RoleId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vROLEID"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, context.localUtil.Format( (decimal)(AV26RoleId), "ZZZZZZZZZZZ9"), context));
         AV22pApplicationId = Convert.ToInt64(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22pApplicationId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22pApplicationId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPAPPLICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22pApplicationId), "ZZZZZZZZZZZ9"), context));
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
         PA0S2( ) ;
         WS0S2( ) ;
         WE0S2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20189201941452", true);
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
            context.AddJavascriptSource("gamwwrolepermissions.js", "?20189201941456", false);
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

      protected void SubsflControlProps_572( )
      {
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_57_idx;
         cmbavOld_accesstype_Internalname = "vOLD_ACCESSTYPE_"+sGXsfl_57_idx;
         chkavOld_inherited_Internalname = "vOLD_INHERITED_"+sGXsfl_57_idx;
         edtavRoleid_Internalname = "vROLEID_"+sGXsfl_57_idx;
         edtavAppid_Internalname = "vAPPID_"+sGXsfl_57_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_57_idx;
         edtavDsc_Internalname = "vDSC_"+sGXsfl_57_idx;
         cmbavAccesstype_Internalname = "vACCESSTYPE_"+sGXsfl_57_idx;
         chkavInherited_Internalname = "vINHERITED_"+sGXsfl_57_idx;
         edtavId_Internalname = "vID_"+sGXsfl_57_idx;
      }

      protected void SubsflControlProps_fel_572( )
      {
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_57_fel_idx;
         cmbavOld_accesstype_Internalname = "vOLD_ACCESSTYPE_"+sGXsfl_57_fel_idx;
         chkavOld_inherited_Internalname = "vOLD_INHERITED_"+sGXsfl_57_fel_idx;
         edtavRoleid_Internalname = "vROLEID_"+sGXsfl_57_fel_idx;
         edtavAppid_Internalname = "vAPPID_"+sGXsfl_57_fel_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_57_fel_idx;
         edtavDsc_Internalname = "vDSC_"+sGXsfl_57_fel_idx;
         cmbavAccesstype_Internalname = "vACCESSTYPE_"+sGXsfl_57_fel_idx;
         chkavInherited_Internalname = "vINHERITED_"+sGXsfl_57_fel_idx;
         edtavId_Internalname = "vID_"+sGXsfl_57_fel_idx;
      }

      protected void sendrow_572( )
      {
         SubsflControlProps_572( ) ;
         WB0S0( ) ;
         if ( ( subGridww_Rows * 1 == 0 ) || ( nGXsfl_57_idx <= subGridww_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_57_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_57_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavBtndlt_Enabled!=0)&&(edtavBtndlt_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 58,'',false,'',57)\"" : " ");
            ClassString = "DeleteAttribute";
            StyleString = "";
            AV10BtnDlt_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV10BtnDlt))&&String.IsNullOrEmpty(StringUtil.RTrim( AV47Btndlt_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV10BtnDlt)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV10BtnDlt)) ? AV47Btndlt_GXI : context.PathToRelativeUrl( AV10BtnDlt));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtndlt_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavBtndlt_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavBtndlt_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVBTNDLT.CLICK."+sGXsfl_57_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV10BtnDlt_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            TempTags = " " + ((cmbavOld_accesstype.Enabled!=0)&&(cmbavOld_accesstype.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 59,'',false,'"+sGXsfl_57_idx+"',57)\"" : " ");
            if ( ( cmbavOld_accesstype.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "vOLD_ACCESSTYPE_" + sGXsfl_57_idx;
               cmbavOld_accesstype.Name = GXCCtl;
               cmbavOld_accesstype.WebTags = "";
               cmbavOld_accesstype.addItem("A", "Allow", 0);
               cmbavOld_accesstype.addItem("D", "Deny", 0);
               cmbavOld_accesstype.addItem("R", "Restricted", 0);
               if ( cmbavOld_accesstype.ItemCount > 0 )
               {
                  AV20old_AccessType = cmbavOld_accesstype.getValidValue(AV20old_AccessType);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavOld_accesstype_Internalname, AV20old_AccessType);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vOLD_ACCESSTYPE"+"_"+sGXsfl_57_idx, GetSecureSignedToken( sGXsfl_57_idx, StringUtil.RTrim( context.localUtil.Format( AV20old_AccessType, "")), context));
               }
            }
            /* ComboBox */
            GridwwRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavOld_accesstype,(String)cmbavOld_accesstype_Internalname,StringUtil.RTrim( AV20old_AccessType),(short)1,(String)cmbavOld_accesstype_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)0,cmbavOld_accesstype.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((cmbavOld_accesstype.Enabled!=0)&&(cmbavOld_accesstype.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,59);\"" : " "),(String)"",(bool)true});
            cmbavOld_accesstype.CurrentValue = StringUtil.RTrim( AV20old_AccessType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavOld_accesstype_Internalname, "Values", (String)(cmbavOld_accesstype.ToJavascriptSource()), !bGXsfl_57_Refreshing);
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Check box */
            TempTags = " " + ((chkavOld_inherited.Enabled!=0)&&(chkavOld_inherited.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 60,'',false,'"+sGXsfl_57_idx+"',57)\"" : " ");
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridwwRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavOld_inherited_Internalname,StringUtil.BoolToStr( AV21Old_Inherited),(String)"",(String)"",(short)0,chkavOld_inherited.Enabled,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(60, this, 'true', 'false');gx.evt.onchange(this, event);\" "+((chkavOld_inherited.Enabled!=0)&&(chkavOld_inherited.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,60);\"" : " ")});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavRoleid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26RoleId), 12, 0, ",", "")),((edtavRoleid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV26RoleId), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV26RoleId), "ZZZZZZZZZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavRoleid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavRoleid_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)57,(short)1,(short)-1,(short)0,(bool)true,(String)"GAMKeyNumLong",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavAppid_Enabled!=0)&&(edtavAppid_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 62,'',false,'"+sGXsfl_57_idx+"',57)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavAppid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29AppId), 12, 0, ",", "")),((edtavAppid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV29AppId), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV29AppId), "ZZZZZZZZZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavAppid_Enabled!=0)&&(edtavAppid_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,62);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavAppid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavAppid_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)57,(short)1,(short)-1,(short)0,(bool)true,(String)"GAMKeyNumLong",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavName_Enabled!=0)&&(edtavName_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 63,'',false,'"+sGXsfl_57_idx+"',57)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavName_Internalname,StringUtil.RTrim( AV19Name),(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavName_Enabled!=0)&&(edtavName_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,63);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavName_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)120,(short)0,(short)0,(short)57,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionMedium",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavDsc_Enabled!=0)&&(edtavDsc_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 64,'',false,'"+sGXsfl_57_idx+"',57)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDsc_Internalname,StringUtil.RTrim( AV11Dsc),(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavDsc_Enabled!=0)&&(edtavDsc_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,64);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavDsc_Enabled,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)254,(short)0,(short)0,(short)57,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionLong",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            TempTags = " " + ((cmbavAccesstype.Enabled!=0)&&(cmbavAccesstype.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 65,'',false,'"+sGXsfl_57_idx+"',57)\"" : " ");
            if ( ( cmbavAccesstype.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "vACCESSTYPE_" + sGXsfl_57_idx;
               cmbavAccesstype.Name = GXCCtl;
               cmbavAccesstype.WebTags = "";
               cmbavAccesstype.addItem("A", "Allow", 0);
               cmbavAccesstype.addItem("D", "Deny", 0);
               cmbavAccesstype.addItem("R", "Restricted", 0);
               if ( cmbavAccesstype.ItemCount > 0 )
               {
                  AV5AccessType = cmbavAccesstype.getValidValue(AV5AccessType);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavAccesstype_Internalname, AV5AccessType);
               }
            }
            /* ComboBox */
            GridwwRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavAccesstype,(String)cmbavAccesstype_Internalname,StringUtil.RTrim( AV5AccessType),(short)1,(String)cmbavAccesstype_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,(short)1,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((cmbavAccesstype.Enabled!=0)&&(cmbavAccesstype.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,65);\"" : " "),(String)"",(bool)true});
            cmbavAccesstype.CurrentValue = StringUtil.RTrim( AV5AccessType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavAccesstype_Internalname, "Values", (String)(cmbavAccesstype.ToJavascriptSource()), !bGXsfl_57_Refreshing);
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            TempTags = " " + ((chkavInherited.Enabled!=0)&&(chkavInherited.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 66,'',false,'"+sGXsfl_57_idx+"',57)\"" : " ");
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridwwRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavInherited_Internalname,StringUtil.BoolToStr( AV17Inherited),(String)"",(String)"",(short)-1,(short)1,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(66, this, 'true', 'false');gx.evt.onchange(this, event);\" "+((chkavInherited.Enabled!=0)&&(chkavInherited.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,66);\"" : " ")});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 67,'',false,'"+sGXsfl_57_idx+"',57)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavId_Internalname,StringUtil.RTrim( AV16Id),(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,67);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavId_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)57,(short)1,(short)-1,(short)0,(bool)true,(String)"GAMGUID",(String)"left",(bool)true});
            send_integrity_lvl_hashes0S2( ) ;
            GridwwContainer.AddRow(GridwwRow);
            nGXsfl_57_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_57_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_57_idx+1));
            sGXsfl_57_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_57_idx), 4, 0)), 4, "0");
            SubsflControlProps_572( ) ;
         }
         /* End function sendrow_572 */
      }

      protected void init_default_properties( )
      {
         bttBtnback_Internalname = "BTNBACK";
         bttBtnadd_Internalname = "BTNADD";
         bttBtnsave_Internalname = "BTNSAVE";
         divTableactions_Internalname = "TABLEACTIONS";
         cmbavApplicationid_Internalname = "vAPPLICATIONID";
         edtavFilname_Internalname = "vFILNAME";
         cmbavPermissionaccesstype_Internalname = "vPERMISSIONACCESSTYPE";
         cmbavIsinherited_Internalname = "vISINHERITED";
         tblTablefilters_Internalname = "TABLEFILTERS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavBtndlt_Internalname = "vBTNDLT";
         cmbavOld_accesstype_Internalname = "vOLD_ACCESSTYPE";
         chkavOld_inherited_Internalname = "vOLD_INHERITED";
         edtavRoleid_Internalname = "vROLEID";
         edtavAppid_Internalname = "vAPPID";
         edtavName_Internalname = "vNAME";
         edtavDsc_Internalname = "vDSC";
         cmbavAccesstype_Internalname = "vACCESSTYPE";
         chkavInherited_Internalname = "vINHERITED";
         edtavId_Internalname = "vID";
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
         edtavId_Jsonclick = "";
         edtavId_Visible = 0;
         chkavInherited.Visible = -1;
         chkavInherited.Enabled = 1;
         cmbavAccesstype_Jsonclick = "";
         cmbavAccesstype.Visible = -1;
         cmbavAccesstype.Enabled = 1;
         edtavDsc_Jsonclick = "";
         edtavDsc_Visible = -1;
         edtavName_Jsonclick = "";
         edtavName_Visible = -1;
         edtavAppid_Jsonclick = "";
         edtavAppid_Visible = 0;
         edtavRoleid_Jsonclick = "";
         chkavOld_inherited.Visible = 0;
         cmbavOld_accesstype_Jsonclick = "";
         cmbavOld_accesstype.Visible = 0;
         edtavBtndlt_Jsonclick = "";
         edtavBtndlt_Visible = -1;
         edtavBtndlt_Enabled = 1;
         cmbavIsinherited_Jsonclick = "";
         cmbavIsinherited.Enabled = 1;
         cmbavPermissionaccesstype_Jsonclick = "";
         cmbavPermissionaccesstype.Enabled = 1;
         edtavFilname_Jsonclick = "";
         edtavFilname_Enabled = 1;
         cmbavApplicationid_Jsonclick = "";
         cmbavApplicationid.Enabled = 1;
         chkavInherited.Caption = "";
         chkavOld_inherited.Caption = "";
         edtavGridwwcurrentpage_Jsonclick = "";
         edtavGridwwcurrentpage_Visible = 1;
         subGridww_Allowcollapsing = 0;
         subGridww_Allowselection = 0;
         edtavBtndlt_Tooltiptext = "Revoke";
         edtavId_Enabled = 1;
         edtavDsc_Enabled = 1;
         edtavName_Enabled = 1;
         edtavAppid_Enabled = 1;
         edtavRoleid_Enabled = 0;
         chkavOld_inherited.Enabled = 1;
         cmbavOld_accesstype.Enabled = 1;
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
         Form.Caption = "Role´s permissions";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'cmbavApplicationid'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV14FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstype'},{av:'AV24PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:'',nv:''},{av:'cmbavIsinherited'},{av:'AV32IsInherited',fld:'vISINHERITED',pic:'',nv:''},{av:'AV22pApplicationId',fld:'vPAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV26RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{ctrl:'BTNBACK',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDWW.LOAD","{handler:'E180S2',iparms:[{av:'AV26RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'cmbavApplicationid'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV14FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstype'},{av:'AV24PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:'',nv:''},{av:'cmbavIsinherited'},{av:'AV32IsInherited',fld:'vISINHERITED',pic:'',nv:''}],oparms:[{av:'AV31GridWWPageCount',fld:'vGRIDWWPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0},{av:'AV10BtnDlt',fld:'vBTNDLT',pic:'',nv:''},{av:'AV16Id',fld:'vID',pic:'',hsh:true,nv:''},{av:'AV19Name',fld:'vNAME',pic:'',nv:''},{av:'AV11Dsc',fld:'vDSC',pic:'',nv:''},{av:'cmbavAccesstype'},{av:'AV5AccessType',fld:'vACCESSTYPE',pic:'',nv:''},{av:'AV17Inherited',fld:'vINHERITED',pic:'',nv:false},{av:'cmbavOld_accesstype'},{av:'AV20old_AccessType',fld:'vOLD_ACCESSTYPE',pic:'',hsh:true,nv:''},{av:'AV21Old_Inherited',fld:'vOLD_INHERITED',pic:'',hsh:true,nv:false},{av:'edtavBtndlt_Tooltiptext',ctrl:'vBTNDLT',prop:'Tooltiptext'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEPAGE","{handler:'E130S2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV26RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'cmbavApplicationid'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV14FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstype'},{av:'AV24PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:'',nv:''},{av:'cmbavIsinherited'},{av:'AV32IsInherited',fld:'vISINHERITED',pic:'',nv:''},{av:'AV22pApplicationId',fld:'vPAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'Gridwwpaginationbar_Selectedpage',ctrl:'GRIDWWPAGINATIONBAR',prop:'SelectedPage'},{av:'AV30GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}],oparms:[{av:'AV30GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{ctrl:'BTNBACK',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E140S2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV26RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'cmbavApplicationid'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV14FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstype'},{av:'AV24PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:'',nv:''},{av:'cmbavIsinherited'},{av:'AV32IsInherited',fld:'vISINHERITED',pic:'',nv:''},{av:'AV22pApplicationId',fld:'vPAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'Gridwwpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDWWPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],oparms:[{av:'subGridww_Rows',ctrl:'GRIDWW',prop:'Rows'},{av:'AV30GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("'DOBACK'","{handler:'E110S1',iparms:[],oparms:[]}");
         setEventMetadata("'DOADD'","{handler:'E120S1',iparms:[{av:'cmbavApplicationid'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV26RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("'DOSAVE'","{handler:'E150S2',iparms:[{av:'AV26RoleId',fld:'vROLEID',grid:57,pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'cmbavAccesstype'},{av:'AV5AccessType',fld:'vACCESSTYPE',grid:57,pic:'',nv:''},{av:'cmbavOld_accesstype'},{av:'AV20old_AccessType',fld:'vOLD_ACCESSTYPE',grid:57,pic:'',hsh:true,nv:''},{av:'AV17Inherited',fld:'vINHERITED',grid:57,pic:'',nv:false},{av:'AV21Old_Inherited',fld:'vOLD_INHERITED',grid:57,pic:'',hsh:true,nv:false},{av:'cmbavApplicationid'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV16Id',fld:'vID',grid:57,pic:'',hsh:true,nv:''},{av:'AV18isOK',fld:'vISOK',pic:'',nv:false}],oparms:[{av:'AV18isOK',fld:'vISOK',pic:'',nv:false}]}");
         setEventMetadata("VBTNDLT.CLICK","{handler:'E190S2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV26RoleId',fld:'vROLEID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'cmbavApplicationid'},{av:'AV8ApplicationId',fld:'vAPPLICATIONID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV14FilName',fld:'vFILNAME',pic:'',nv:''},{av:'cmbavPermissionaccesstype'},{av:'AV24PermissionAccessType',fld:'vPERMISSIONACCESSTYPE',pic:'',nv:''},{av:'cmbavIsinherited'},{av:'AV32IsInherited',fld:'vISINHERITED',pic:'',nv:''},{av:'AV22pApplicationId',fld:'vPAPPLICATIONID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV16Id',fld:'vID',pic:'',hsh:true,nv:''}],oparms:[{av:'AV18isOK',fld:'vISOK',pic:'',nv:false},{ctrl:'BTNBACK',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
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
         AV14FilName = "";
         AV24PermissionAccessType = "";
         AV32IsInherited = "";
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
         bttBtnsave_Jsonclick = "";
         GridwwContainer = new GXWebGrid( context);
         sStyleString = "";
         subGridww_Linesclass = "";
         GridwwColumn = new GXWebColumn();
         AV10BtnDlt = "";
         AV20old_AccessType = "";
         AV19Name = "";
         AV11Dsc = "";
         AV5AccessType = "";
         AV16Id = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV47Btndlt_GXI = "";
         GXCCtl = "";
         AV44GXV1 = new GXExternalCollection<SdtGAMApplication>( context, "SdtGAMApplication", "GeneXus.Programs");
         AV7ApplicationFilter = new SdtGAMApplicationFilter(context);
         AV13Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV6Application = new SdtGAMApplication(context);
         AV15GAMRole = new SdtGAMRole(context);
         AV27RolePermissionFilter = new SdtGAMPermissionFilter(context);
         AV35Permissions = new GXExternalCollection<SdtGAMPermission>( context, "SdtGAMPermission", "GeneXus.Programs");
         AV23Permission = new SdtGAMPermission(context);
         GridwwRow = new GXWebRow();
         AV25PermissionUpd = new SdtGAMPermission(context);
         AV12Error = new SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamwwrolepermissions__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamwwrolepermissions__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         cmbavOld_accesstype.Enabled = 0;
         chkavOld_inherited.Enabled = 0;
         edtavRoleid_Enabled = 0;
         edtavAppid_Enabled = 0;
         edtavName_Enabled = 0;
         edtavDsc_Enabled = 0;
         edtavId_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_57 ;
      private short nGXsfl_57_idx=1 ;
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
      private short nGXsfl_57_fel_idx=1 ;
      private short subGridww_Backstyle ;
      private int Gridwwpaginationbar_Rowsperpageselectedvalue ;
      private int subGridww_Rows ;
      private int Gridwwpaginationbar_Pagestoshow ;
      private int divTablemain_Height ;
      private int bttBtnback_Visible ;
      private int bttBtnadd_Visible ;
      private int subGridww_Titlebackcolor ;
      private int subGridww_Allbackcolor ;
      private int edtavRoleid_Enabled ;
      private int edtavAppid_Enabled ;
      private int edtavName_Enabled ;
      private int edtavDsc_Enabled ;
      private int edtavId_Enabled ;
      private int subGridww_Selectioncolor ;
      private int subGridww_Hoveringcolor ;
      private int edtavGridwwcurrentpage_Visible ;
      private int subGridww_Islastpage ;
      private int GRIDWW_nGridOutOfScope ;
      private int AV45GXV2 ;
      private int AV46GXV3 ;
      private int AV33PageToGo ;
      private int AV49GXV4 ;
      private int AV50GXV5 ;
      private int AV51GXV6 ;
      private int edtavFilname_Enabled ;
      private int idxLst ;
      private int subGridww_Backcolor ;
      private int edtavBtndlt_Enabled ;
      private int edtavBtndlt_Visible ;
      private int edtavAppid_Visible ;
      private int edtavName_Visible ;
      private int edtavDsc_Visible ;
      private int edtavId_Visible ;
      private long AV26RoleId ;
      private long AV22pApplicationId ;
      private long wcpOAV26RoleId ;
      private long wcpOAV22pApplicationId ;
      private long GRIDWW_nFirstRecordOnPage ;
      private long AV8ApplicationId ;
      private long AV31GridWWPageCount ;
      private long AV29AppId ;
      private long AV30GridWWCurrentPage ;
      private long GRIDWW_nCurrentRecord ;
      private long GRIDWW_nRecordCount ;
      private long AV37GridWWRecordCount ;
      private long AV36GridWWPageSize ;
      private String Gridwwpaginationbar_Selectedpage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_57_idx="0001" ;
      private String AV14FilName ;
      private String AV24PermissionAccessType ;
      private String AV32IsInherited ;
      private String GXKey ;
      private String edtavRoleid_Internalname ;
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
      private String bttBtnsave_Internalname ;
      private String bttBtnsave_Jsonclick ;
      private String divGridwwtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGridww_Internalname ;
      private String subGridww_Class ;
      private String subGridww_Linesclass ;
      private String edtavBtndlt_Tooltiptext ;
      private String AV20old_AccessType ;
      private String AV19Name ;
      private String AV11Dsc ;
      private String AV5AccessType ;
      private String AV16Id ;
      private String divHtml_gridwwpaginationbar_Internalname ;
      private String edtavGridwwcurrentpage_Internalname ;
      private String edtavGridwwcurrentpage_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavBtndlt_Internalname ;
      private String cmbavOld_accesstype_Internalname ;
      private String chkavOld_inherited_Internalname ;
      private String edtavAppid_Internalname ;
      private String edtavName_Internalname ;
      private String edtavDsc_Internalname ;
      private String cmbavAccesstype_Internalname ;
      private String chkavInherited_Internalname ;
      private String edtavId_Internalname ;
      private String GXCCtl ;
      private String cmbavApplicationid_Internalname ;
      private String cmbavPermissionaccesstype_Internalname ;
      private String cmbavIsinherited_Internalname ;
      private String edtavFilname_Internalname ;
      private String Gridwwpaginationbar_Internalname ;
      private String sGXsfl_57_fel_idx="0001" ;
      private String tblTablefilters_Internalname ;
      private String cmbavApplicationid_Jsonclick ;
      private String edtavFilname_Jsonclick ;
      private String cmbavPermissionaccesstype_Jsonclick ;
      private String cmbavIsinherited_Jsonclick ;
      private String sImgUrl ;
      private String edtavBtndlt_Jsonclick ;
      private String cmbavOld_accesstype_Jsonclick ;
      private String ROClassString ;
      private String edtavRoleid_Jsonclick ;
      private String edtavAppid_Jsonclick ;
      private String edtavName_Jsonclick ;
      private String edtavDsc_Jsonclick ;
      private String cmbavAccesstype_Jsonclick ;
      private String edtavId_Jsonclick ;
      private String Dvpanel_tableheader_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV18isOK ;
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
      private bool AV21Old_Inherited ;
      private bool AV17Inherited ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_57_Refreshing=false ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV34TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV10BtnDlt_IsBlob ;
      private String AV47Btndlt_GXI ;
      private String AV10BtnDlt ;
      private GXWebGrid GridwwContainer ;
      private GXWebRow GridwwRow ;
      private GXWebColumn GridwwColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavApplicationid ;
      private GXCombobox cmbavPermissionaccesstype ;
      private GXCombobox cmbavIsinherited ;
      private GXCombobox cmbavOld_accesstype ;
      private GXCheckbox chkavOld_inherited ;
      private GXCombobox cmbavAccesstype ;
      private GXCheckbox chkavInherited ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMApplication> AV44GXV1 ;
      private GXExternalCollection<SdtGAMError> AV13Errors ;
      private GXExternalCollection<SdtGAMPermission> AV35Permissions ;
      private GXWebForm Form ;
      private SdtGAMApplication AV6Application ;
      private SdtGAMError AV12Error ;
      private SdtGAMRole AV15GAMRole ;
      private SdtGAMPermission AV23Permission ;
      private SdtGAMPermission AV25PermissionUpd ;
      private SdtGAMPermissionFilter AV27RolePermissionFilter ;
      private SdtGAMApplicationFilter AV7ApplicationFilter ;
   }

   public class gamwwrolepermissions__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamwwrolepermissions__default : DataStoreHelperBase, IDataStoreHelper
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
