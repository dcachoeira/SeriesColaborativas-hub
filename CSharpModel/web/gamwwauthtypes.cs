/*
               File: GAMWWAuthTypes
        Description: Authentication Types
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:42:9.21
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
   public class gamwwauthtypes : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamwwauthtypes( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamwwauthtypes( IGxContext context )
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
         cmbavTypeid = new GXCombobox();
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
               edtavBtntestws_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtntestws_Internalname, "Title", edtavBtntestws_Title, !bGXsfl_38_Refreshing);
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
               edtavBtntestws_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtntestws_Internalname, "Title", edtavBtntestws_Title, !bGXsfl_38_Refreshing);
               AV10FilName = GetNextPar( );
               AV19IsAuthorized_BtnUpd = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV17IsAuthorized_BtnDlt = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV18IsAuthorized_BtnTestWS = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV20IsAuthorized_Name = (bool)(BooleanUtil.Val(GetNextPar( )));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridww_refresh( subGridww_Rows, AV10FilName, AV19IsAuthorized_BtnUpd, AV17IsAuthorized_BtnDlt, AV18IsAuthorized_BtnTestWS, AV20IsAuthorized_Name) ;
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
         PA0Z2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0Z2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20189201942964", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamwwauthtypes.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDWWPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16GridWWPageCount), 10, 0, ",", "")));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNUPD", AV19IsAuthorized_BtnUpd);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNDLT", AV17IsAuthorized_BtnDlt);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNTESTWS", AV18IsAuthorized_BtnTestWS);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_NAME", AV20IsAuthorized_Name);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV20IsAuthorized_Name, context));
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
         GxWebStd.gx_hidden_field( context, "vBTNTESTWS_Title", StringUtil.RTrim( edtavBtntestws_Title));
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
            WE0Z2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0Z2( ) ;
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
         return formatLink("gamwwauthtypes.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "GAMWWAuthTypes" ;
      }

      public override String GetPgmdesc( )
      {
         return "Authentication Types" ;
      }

      protected void WB0Z0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
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
            GxWebStd.gx_button_ctrl( context, bttBtnadd_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(38), 2, 0)+","+"null"+");", "Insert", bttBtnadd_Jsonclick, 7, "Insert", "", StyleString, ClassString, bttBtnadd_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e110z1_client"+"'", TempTags, "", 2, "HLP_GAMWWAuthTypes.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavFilname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavFilname_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'" + sGXsfl_38_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFilname_Internalname, StringUtil.RTrim( AV10FilName), StringUtil.RTrim( context.localUtil.Format( AV10FilName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,32);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFilname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavFilname_Enabled, 0, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMWWAuthTypes.htm");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavBtnupd_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute"+"\" "+" style=\""+((edtavBtndlt_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavBtntestws_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( edtavBtntestws_Title) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Type") ;
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
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV8BtnUpd));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtnupd_Link));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtnupd_Tooltiptext));
               GridwwColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtnupd_Visible), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV6BtnDlt));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtndlt_Link));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtndlt_Tooltiptext));
               GridwwColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtndlt_Visible), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV7BtnTestWS));
               GridwwColumn.AddObjectProperty("Title", StringUtil.RTrim( edtavBtntestws_Title));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtntestws_Link));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtntestws_Tooltiptext));
               GridwwColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtntestws_Visible), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV12Name));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavName_Enabled), 5, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavName_Link));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV13TypeId));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbavTypeid.Enabled), 5, 0, ".", "")));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_38_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGridwwcurrentpage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15GridWWCurrentPage), 10, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV15GridWWCurrentPage), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGridwwcurrentpage_Jsonclick, 0, "Attribute", "", "", "", "", edtavGridwwcurrentpage_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMWWAuthTypes.htm");
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

      protected void START0Z2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Authentication Types", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0Z0( ) ;
      }

      protected void WS0Z2( )
      {
         START0Z2( ) ;
         EVT0Z2( ) ;
      }

      protected void EVT0Z2( )
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
                              E120Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E130Z2 ();
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
                              AV8BtnUpd = cgiGet( edtavBtnupd_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV8BtnUpd)) ? AV32Btnupd_GXI : context.convertURL( context.PathToRelativeUrl( AV8BtnUpd))), !bGXsfl_38_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "SrcSet", context.GetImageSrcSet( AV8BtnUpd), true);
                              AV6BtnDlt = cgiGet( edtavBtndlt_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6BtnDlt)) ? AV33Btndlt_GXI : context.convertURL( context.PathToRelativeUrl( AV6BtnDlt))), !bGXsfl_38_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "SrcSet", context.GetImageSrcSet( AV6BtnDlt), true);
                              AV7BtnTestWS = cgiGet( edtavBtntestws_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtntestws_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7BtnTestWS)) ? AV34Btntestws_GXI : context.convertURL( context.PathToRelativeUrl( AV7BtnTestWS))), !bGXsfl_38_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtntestws_Internalname, "SrcSet", context.GetImageSrcSet( AV7BtnTestWS), true);
                              AV12Name = cgiGet( edtavName_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV12Name);
                              cmbavTypeid.Name = cmbavTypeid_Internalname;
                              cmbavTypeid.CurrentValue = cgiGet( cmbavTypeid_Internalname);
                              AV13TypeId = cgiGet( cmbavTypeid_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavTypeid_Internalname, AV13TypeId);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E140Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E150Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDWW.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E160Z2 ();
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

      protected void WE0Z2( )
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

      protected void PA0Z2( )
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
            GXCCtl = "vTYPEID_" + sGXsfl_38_idx;
            cmbavTypeid.Name = GXCCtl;
            cmbavTypeid.WebTags = "";
            cmbavTypeid.addItem("Custom", "Custom", 0);
            cmbavTypeid.addItem("ExternalWebService", "External Web Service", 0);
            cmbavTypeid.addItem("Facebook", "Facebook", 0);
            cmbavTypeid.addItem("GAMLocal", "GAM Local", 0);
            cmbavTypeid.addItem("GAMRemote", "GAM Remote", 0);
            cmbavTypeid.addItem("Google", "Google", 0);
            cmbavTypeid.addItem("Twitter", "Twitter", 0);
            if ( cmbavTypeid.ItemCount > 0 )
            {
               AV13TypeId = cmbavTypeid.getValidValue(AV13TypeId);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavTypeid_Internalname, AV13TypeId);
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
                                         String AV10FilName ,
                                         bool AV19IsAuthorized_BtnUpd ,
                                         bool AV17IsAuthorized_BtnDlt ,
                                         bool AV18IsAuthorized_BtnTestWS ,
                                         bool AV20IsAuthorized_Name )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         GRIDWW_nCurrentRecord = 0;
         RF0Z2( ) ;
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
         RF0Z2( ) ;
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
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
         cmbavTypeid.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTypeid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavTypeid.Enabled), 5, 0)), !bGXsfl_38_Refreshing);
      }

      protected void RF0Z2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridwwContainer.ClearRows();
         }
         wbStart = 38;
         /* Execute user event: Refresh */
         E150Z2 ();
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
            E160Z2 ();
            if ( ( GRIDWW_nCurrentRecord > 0 ) && ( GRIDWW_nGridOutOfScope == 0 ) && ( nGXsfl_38_idx == 1 ) )
            {
               GRIDWW_nCurrentRecord = 0;
               GRIDWW_nGridOutOfScope = 1;
               subgridww_firstpage( ) ;
               E160Z2 ();
            }
            wbEnd = 38;
            WB0Z0( ) ;
         }
         bGXsfl_38_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0Z2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_NAME", AV20IsAuthorized_Name);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV20IsAuthorized_Name, context));
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
            gxgrGridww_refresh( subGridww_Rows, AV10FilName, AV19IsAuthorized_BtnUpd, AV17IsAuthorized_BtnDlt, AV18IsAuthorized_BtnTestWS, AV20IsAuthorized_Name) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV10FilName, AV19IsAuthorized_BtnUpd, AV17IsAuthorized_BtnDlt, AV18IsAuthorized_BtnTestWS, AV20IsAuthorized_Name) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV10FilName, AV19IsAuthorized_BtnUpd, AV17IsAuthorized_BtnDlt, AV18IsAuthorized_BtnTestWS, AV20IsAuthorized_Name) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV10FilName, AV19IsAuthorized_BtnUpd, AV17IsAuthorized_BtnDlt, AV18IsAuthorized_BtnTestWS, AV20IsAuthorized_Name) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV10FilName, AV19IsAuthorized_BtnUpd, AV17IsAuthorized_BtnDlt, AV18IsAuthorized_BtnTestWS, AV20IsAuthorized_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP0Z0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_38_Refreshing);
         cmbavTypeid.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTypeid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavTypeid.Enabled), 5, 0)), !bGXsfl_38_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E140Z2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV10FilName = cgiGet( edtavFilname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10FilName", AV10FilName);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vGRIDWWCURRENTPAGE");
               GX_FocusControl = edtavGridwwcurrentpage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15GridWWCurrentPage = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GridWWCurrentPage), 10, 0)));
            }
            else
            {
               AV15GridWWCurrentPage = (long)(context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GridWWCurrentPage), 10, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_38 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_38"), ",", "."));
            AV16GridWWPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDWWPAGECOUNT"), ",", "."));
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
         E140Z2 ();
         if (returnInSub) return;
      }

      protected void E140Z2( )
      {
         /* Start Routine */
         subGridww_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV15GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GridWWCurrentPage), 10, 0)));
         edtavGridwwcurrentpage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGridwwcurrentpage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGridwwcurrentpage_Visible), 5, 0)), true);
         AV16GridWWPageCount = -1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GridWWPageCount), 10, 0)));
         GXt_boolean1 = AV20IsAuthorized_Name;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamauthenticationtypeentry_Execute", out  GXt_boolean1) ;
         AV20IsAuthorized_Name = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20IsAuthorized_Name", AV20IsAuthorized_Name);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV20IsAuthorized_Name, context));
         Gridwwpaginationbar_Rowsperpageselectedvalue = subGridww_Rows;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Gridwwpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridwwpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         edtavBtntestws_Title = "Test external login";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtntestws_Internalname, "Title", edtavBtntestws_Title, !bGXsfl_38_Refreshing);
      }

      protected void E150Z2( )
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

      private void E160Z2( )
      {
         /* Gridww_Load Routine */
         AV11Filter.gxTpr_Name = "%"+AV10FilName;
         AV23GAMAuthTypes = new SdtGAMRepository(context).getauthenticationtypes(AV11Filter, out  AV9Errors);
         if ( AV23GAMAuthTypes.Count == 0 )
         {
            AV16GridWWPageCount = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GridWWPageCount), 10, 0)));
         }
         else
         {
            AV16GridWWPageCount = (long)((AV23GAMAuthTypes.Count/ (decimal)(9))+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GridWWPageCount), 10, 0)));
         }
         AV25GridWWRecordCount = AV23GAMAuthTypes.Count;
         AV24GridWWPageSize = 9;
         AV31GXV1 = 1;
         while ( AV31GXV1 <= AV23GAMAuthTypes.Count )
         {
            AV5AuthenticationType = ((SdtGAMAuthenticationType)AV23GAMAuthTypes.Item(AV31GXV1));
            AV12Name = AV5AuthenticationType.gxTpr_Name;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV12Name);
            AV13TypeId = AV5AuthenticationType.gxTpr_Typeid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavTypeid_Internalname, AV13TypeId);
            if ( ( StringUtil.StrCmp(AV13TypeId, "ExternalWebService") == 0 ) || ( StringUtil.StrCmp(AV13TypeId, "Custom") == 0 ) )
            {
               edtavBtntestws_Visible = 1;
            }
            else
            {
               edtavBtntestws_Visible = 0;
            }
            AV8BtnUpd = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtnupd_Internalname, AV8BtnUpd);
            AV32Btnupd_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
            edtavBtnupd_Tooltiptext = "";
            if ( AV19IsAuthorized_BtnUpd )
            {
               edtavBtnupd_Link = formatLink("gamauthenticationtypeentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(AV12Name)) + "," + UrlEncode(StringUtil.RTrim(AV13TypeId));
            }
            AV6BtnDlt = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtndlt_Internalname, AV6BtnDlt);
            AV33Btndlt_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
            edtavBtndlt_Tooltiptext = "";
            if ( AV17IsAuthorized_BtnDlt )
            {
               edtavBtndlt_Link = formatLink("gamauthenticationtypeentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(AV12Name)) + "," + UrlEncode(StringUtil.RTrim(AV13TypeId));
            }
            AV7BtnTestWS = context.GetImagePath( "835a2c8a-7a40-4c02-af25-cefd1ae394fb", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtntestws_Internalname, AV7BtnTestWS);
            AV34Btntestws_GXI = GXDbFile.PathToUrl( context.GetImagePath( "835a2c8a-7a40-4c02-af25-cefd1ae394fb", "", context.GetTheme( )));
            edtavBtntestws_Tooltiptext = "Test external login";
            if ( AV18IsAuthorized_BtnTestWS )
            {
               edtavBtntestws_Link = formatLink("gamtestexternallogin.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12Name)) + "," + UrlEncode(StringUtil.RTrim(AV13TypeId));
            }
            if ( AV20IsAuthorized_Name )
            {
               edtavName_Link = formatLink("gamauthenticationtypeentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode(StringUtil.RTrim(AV12Name)) + "," + UrlEncode(StringUtil.RTrim(AV13TypeId));
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
            AV31GXV1 = (int)(AV31GXV1+1);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11Filter", AV11Filter);
         cmbavTypeid.CurrentValue = StringUtil.RTrim( AV13TypeId);
      }

      protected void E120Z2( )
      {
         /* Gridwwpaginationbar_Changepage Routine */
         if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Previous") == 0 )
         {
            AV15GridWWCurrentPage = (long)(AV15GridWWCurrentPage-1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GridWWCurrentPage), 10, 0)));
            subgridww_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Next") == 0 )
         {
            AV15GridWWCurrentPage = (long)(AV15GridWWCurrentPage+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GridWWCurrentPage), 10, 0)));
            subgridww_nextpage( ) ;
         }
         else
         {
            AV21PageToGo = (int)(NumberUtil.Val( Gridwwpaginationbar_Selectedpage, "."));
            AV15GridWWCurrentPage = AV21PageToGo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GridWWCurrentPage), 10, 0)));
            subgridww_gotopage( AV21PageToGo) ;
         }
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
      }

      protected void E130Z2( )
      {
         /* Gridwwpaginationbar_Changerowsperpage Routine */
         subGridww_Rows = Gridwwpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV15GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GridWWCurrentPage), 10, 0)));
         subgridww_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV19IsAuthorized_BtnUpd;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamauthenticationtypeentry_Execute", out  GXt_boolean1) ;
         AV19IsAuthorized_BtnUpd = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19IsAuthorized_BtnUpd", AV19IsAuthorized_BtnUpd);
         if ( ! ( AV19IsAuthorized_BtnUpd ) )
         {
            edtavBtnupd_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtnupd_Visible), 5, 0)), !bGXsfl_38_Refreshing);
         }
         GXt_boolean1 = AV17IsAuthorized_BtnDlt;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamauthenticationtypeentry_Execute", out  GXt_boolean1) ;
         AV17IsAuthorized_BtnDlt = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17IsAuthorized_BtnDlt", AV17IsAuthorized_BtnDlt);
         if ( ! ( AV17IsAuthorized_BtnDlt ) )
         {
            edtavBtndlt_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtndlt_Visible), 5, 0)), !bGXsfl_38_Refreshing);
         }
         GXt_boolean1 = AV18IsAuthorized_BtnTestWS;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamtestexternallogin_Execute", out  GXt_boolean1) ;
         AV18IsAuthorized_BtnTestWS = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18IsAuthorized_BtnTestWS", AV18IsAuthorized_BtnTestWS);
         if ( ! ( AV18IsAuthorized_BtnTestWS ) )
         {
            edtavBtntestws_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtntestws_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtntestws_Visible), 5, 0)), !bGXsfl_38_Refreshing);
         }
         GXt_boolean1 = AV22TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamauthenticationtypeentry_Execute", out  GXt_boolean1) ;
         AV22TempBoolean = GXt_boolean1;
         if ( ! ( AV22TempBoolean ) )
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
         PA0Z2( ) ;
         WS0Z2( ) ;
         WE0Z2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019421570", true);
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
            context.AddJavascriptSource("gamwwauthtypes.js", "?201892019421573", false);
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
         edtavBtnupd_Internalname = "vBTNUPD_"+sGXsfl_38_idx;
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_38_idx;
         edtavBtntestws_Internalname = "vBTNTESTWS_"+sGXsfl_38_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_38_idx;
         cmbavTypeid_Internalname = "vTYPEID_"+sGXsfl_38_idx;
      }

      protected void SubsflControlProps_fel_382( )
      {
         edtavBtnupd_Internalname = "vBTNUPD_"+sGXsfl_38_fel_idx;
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_38_fel_idx;
         edtavBtntestws_Internalname = "vBTNTESTWS_"+sGXsfl_38_fel_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_38_fel_idx;
         cmbavTypeid_Internalname = "vTYPEID_"+sGXsfl_38_fel_idx;
      }

      protected void sendrow_382( )
      {
         SubsflControlProps_382( ) ;
         WB0Z0( ) ;
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtnupd_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV8BtnUpd_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV8BtnUpd))&&String.IsNullOrEmpty(StringUtil.RTrim( AV32Btnupd_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV8BtnUpd)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV8BtnUpd)) ? AV32Btnupd_GXI : context.PathToRelativeUrl( AV8BtnUpd));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtnupd_Internalname,(String)sImgUrl,(String)edtavBtnupd_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtnupd_Visible,(short)1,(String)"",(String)edtavBtnupd_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV8BtnUpd_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtndlt_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute";
            StyleString = "";
            AV6BtnDlt_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV6BtnDlt))&&String.IsNullOrEmpty(StringUtil.RTrim( AV33Btndlt_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV6BtnDlt)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV6BtnDlt)) ? AV33Btndlt_GXI : context.PathToRelativeUrl( AV6BtnDlt));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtndlt_Internalname,(String)sImgUrl,(String)edtavBtndlt_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtndlt_Visible,(short)1,(String)"",(String)edtavBtndlt_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV6BtnDlt_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtntestws_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV7BtnTestWS_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV7BtnTestWS))&&String.IsNullOrEmpty(StringUtil.RTrim( AV34Btntestws_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV7BtnTestWS)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV7BtnTestWS)) ? AV34Btntestws_GXI : context.PathToRelativeUrl( AV7BtnTestWS));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtntestws_Internalname,(String)sImgUrl,(String)edtavBtntestws_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtntestws_Visible,(short)1,(String)"",(String)edtavBtntestws_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn hidden-xs",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV7BtnTestWS_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavName_Internalname,StringUtil.RTrim( AV12Name),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavName_Link,(String)"",(String)"",(String)"",(String)edtavName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavName_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)38,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionShort",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbavTypeid.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "vTYPEID_" + sGXsfl_38_idx;
               cmbavTypeid.Name = GXCCtl;
               cmbavTypeid.WebTags = "";
               cmbavTypeid.addItem("Custom", "Custom", 0);
               cmbavTypeid.addItem("ExternalWebService", "External Web Service", 0);
               cmbavTypeid.addItem("Facebook", "Facebook", 0);
               cmbavTypeid.addItem("GAMLocal", "GAM Local", 0);
               cmbavTypeid.addItem("GAMRemote", "GAM Remote", 0);
               cmbavTypeid.addItem("Google", "Google", 0);
               cmbavTypeid.addItem("Twitter", "Twitter", 0);
               if ( cmbavTypeid.ItemCount > 0 )
               {
                  AV13TypeId = cmbavTypeid.getValidValue(AV13TypeId);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavTypeid_Internalname, AV13TypeId);
               }
            }
            /* ComboBox */
            GridwwRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavTypeid,(String)cmbavTypeid_Internalname,StringUtil.RTrim( AV13TypeId),(short)1,(String)cmbavTypeid_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,cmbavTypeid.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbavTypeid.CurrentValue = StringUtil.RTrim( AV13TypeId);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTypeid_Internalname, "Values", (String)(cmbavTypeid.ToJavascriptSource()), !bGXsfl_38_Refreshing);
            send_integrity_lvl_hashes0Z2( ) ;
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
         edtavBtnupd_Internalname = "vBTNUPD";
         edtavBtndlt_Internalname = "vBTNDLT";
         edtavBtntestws_Internalname = "vBTNTESTWS";
         edtavName_Internalname = "vNAME";
         cmbavTypeid_Internalname = "vTYPEID";
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
         cmbavTypeid_Jsonclick = "";
         edtavName_Jsonclick = "";
         edtavGridwwcurrentpage_Jsonclick = "";
         edtavGridwwcurrentpage_Visible = 1;
         subGridww_Allowcollapsing = 0;
         subGridww_Allowselection = 0;
         edtavName_Link = "";
         edtavBtntestws_Tooltiptext = "Test external login";
         edtavBtntestws_Link = "";
         edtavBtndlt_Tooltiptext = "";
         edtavBtndlt_Link = "";
         edtavBtnupd_Tooltiptext = "";
         edtavBtnupd_Link = "";
         cmbavTypeid.Enabled = 0;
         edtavName_Enabled = 0;
         edtavBtntestws_Visible = -1;
         edtavBtndlt_Visible = -1;
         edtavBtnupd_Visible = -1;
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
         Form.Caption = "Authentication Types";
         subGridww_Rows = 0;
         edtavBtntestws_Title = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'edtavBtntestws_Title',ctrl:'vBTNTESTWS',prop:'Title'},{av:'AV10FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV19IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV17IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV18IsAuthorized_BtnTestWS',fld:'vISAUTHORIZED_BTNTESTWS',pic:'',nv:false},{av:'AV20IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false}],oparms:[{av:'AV19IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'edtavBtnupd_Visible',ctrl:'vBTNUPD',prop:'Visible'},{av:'AV17IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'edtavBtndlt_Visible',ctrl:'vBTNDLT',prop:'Visible'},{av:'AV18IsAuthorized_BtnTestWS',fld:'vISAUTHORIZED_BTNTESTWS',pic:'',nv:false},{av:'edtavBtntestws_Visible',ctrl:'vBTNTESTWS',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDWW.LOAD","{handler:'E160Z2',iparms:[{av:'AV10FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV19IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV17IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV18IsAuthorized_BtnTestWS',fld:'vISAUTHORIZED_BTNTESTWS',pic:'',nv:false},{av:'AV20IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false}],oparms:[{av:'AV16GridWWPageCount',fld:'vGRIDWWPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0},{av:'AV12Name',fld:'vNAME',pic:'',nv:''},{av:'cmbavTypeid'},{av:'AV13TypeId',fld:'vTYPEID',pic:'',nv:''},{av:'edtavBtntestws_Visible',ctrl:'vBTNTESTWS',prop:'Visible'},{av:'AV8BtnUpd',fld:'vBTNUPD',pic:'',nv:''},{av:'edtavBtnupd_Tooltiptext',ctrl:'vBTNUPD',prop:'Tooltiptext'},{av:'edtavBtnupd_Link',ctrl:'vBTNUPD',prop:'Link'},{av:'AV6BtnDlt',fld:'vBTNDLT',pic:'',nv:''},{av:'edtavBtndlt_Tooltiptext',ctrl:'vBTNDLT',prop:'Tooltiptext'},{av:'edtavBtndlt_Link',ctrl:'vBTNDLT',prop:'Link'},{av:'AV7BtnTestWS',fld:'vBTNTESTWS',pic:'',nv:''},{av:'edtavBtntestws_Tooltiptext',ctrl:'vBTNTESTWS',prop:'Tooltiptext'},{av:'edtavBtntestws_Link',ctrl:'vBTNTESTWS',prop:'Link'},{av:'edtavName_Link',ctrl:'vNAME',prop:'Link'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEPAGE","{handler:'E120Z2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'edtavBtntestws_Title',ctrl:'vBTNTESTWS',prop:'Title'},{av:'AV10FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV19IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV17IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV18IsAuthorized_BtnTestWS',fld:'vISAUTHORIZED_BTNTESTWS',pic:'',nv:false},{av:'AV20IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false},{av:'Gridwwpaginationbar_Selectedpage',ctrl:'GRIDWWPAGINATIONBAR',prop:'SelectedPage'},{av:'AV15GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}],oparms:[{av:'AV15GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV19IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'edtavBtnupd_Visible',ctrl:'vBTNUPD',prop:'Visible'},{av:'AV17IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'edtavBtndlt_Visible',ctrl:'vBTNDLT',prop:'Visible'},{av:'AV18IsAuthorized_BtnTestWS',fld:'vISAUTHORIZED_BTNTESTWS',pic:'',nv:false},{av:'edtavBtntestws_Visible',ctrl:'vBTNTESTWS',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E130Z2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'edtavBtntestws_Title',ctrl:'vBTNTESTWS',prop:'Title'},{av:'AV10FilName',fld:'vFILNAME',pic:'',nv:''},{av:'AV19IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV17IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV18IsAuthorized_BtnTestWS',fld:'vISAUTHORIZED_BTNTESTWS',pic:'',nv:false},{av:'AV20IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false},{av:'Gridwwpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDWWPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],oparms:[{av:'subGridww_Rows',ctrl:'GRIDWW',prop:'Rows'},{av:'AV15GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("'DOADD'","{handler:'E110Z1',iparms:[],oparms:[]}");
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
         AV10FilName = "";
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
         AV8BtnUpd = "";
         AV6BtnDlt = "";
         AV7BtnTestWS = "";
         AV12Name = "";
         AV13TypeId = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV32Btnupd_GXI = "";
         AV33Btndlt_GXI = "";
         AV34Btntestws_GXI = "";
         GXCCtl = "";
         AV11Filter = new SdtGAMAuthenticationTypeFilter(context);
         AV23GAMAuthTypes = new GXExternalCollection<SdtGAMAuthenticationType>( context, "SdtGAMAuthenticationType", "GeneXus.Programs");
         AV9Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV5AuthenticationType = new SdtGAMAuthenticationType(context);
         GridwwRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavName_Enabled = 0;
         cmbavTypeid.Enabled = 0;
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
      private int edtavBtntestws_Visible ;
      private int edtavName_Enabled ;
      private int subGridww_Selectioncolor ;
      private int subGridww_Hoveringcolor ;
      private int edtavGridwwcurrentpage_Visible ;
      private int subGridww_Islastpage ;
      private int GRIDWW_nGridOutOfScope ;
      private int AV31GXV1 ;
      private int AV21PageToGo ;
      private int idxLst ;
      private int subGridww_Backcolor ;
      private long GRIDWW_nFirstRecordOnPage ;
      private long AV16GridWWPageCount ;
      private long AV15GridWWCurrentPage ;
      private long GRIDWW_nCurrentRecord ;
      private long GRIDWW_nRecordCount ;
      private long AV25GridWWRecordCount ;
      private long AV24GridWWPageSize ;
      private String edtavBtntestws_Title ;
      private String Gridwwpaginationbar_Selectedpage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_38_idx="0001" ;
      private String edtavBtntestws_Internalname ;
      private String AV10FilName ;
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
      private String edtavBtnupd_Link ;
      private String edtavBtnupd_Tooltiptext ;
      private String edtavBtndlt_Link ;
      private String edtavBtndlt_Tooltiptext ;
      private String edtavBtntestws_Link ;
      private String edtavBtntestws_Tooltiptext ;
      private String AV12Name ;
      private String edtavName_Link ;
      private String AV13TypeId ;
      private String divHtml_gridwwpaginationbar_Internalname ;
      private String edtavGridwwcurrentpage_Internalname ;
      private String edtavGridwwcurrentpage_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavBtnupd_Internalname ;
      private String edtavBtndlt_Internalname ;
      private String edtavName_Internalname ;
      private String cmbavTypeid_Internalname ;
      private String GXCCtl ;
      private String Gridwwpaginationbar_Internalname ;
      private String sGXsfl_38_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtavName_Jsonclick ;
      private String cmbavTypeid_Jsonclick ;
      private String Dvpanel_tableheader_Internalname ;
      private bool entryPointCalled ;
      private bool bGXsfl_38_Refreshing=false ;
      private bool AV19IsAuthorized_BtnUpd ;
      private bool AV17IsAuthorized_BtnDlt ;
      private bool AV18IsAuthorized_BtnTestWS ;
      private bool AV20IsAuthorized_Name ;
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
      private bool AV22TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV8BtnUpd_IsBlob ;
      private bool AV6BtnDlt_IsBlob ;
      private bool AV7BtnTestWS_IsBlob ;
      private String AV32Btnupd_GXI ;
      private String AV33Btndlt_GXI ;
      private String AV34Btntestws_GXI ;
      private String AV8BtnUpd ;
      private String AV6BtnDlt ;
      private String AV7BtnTestWS ;
      private GXWebGrid GridwwContainer ;
      private GXWebRow GridwwRow ;
      private GXWebColumn GridwwColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavTypeid ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMAuthenticationType> AV23GAMAuthTypes ;
      private GXExternalCollection<SdtGAMError> AV9Errors ;
      private GXWebForm Form ;
      private SdtGAMAuthenticationType AV5AuthenticationType ;
      private SdtGAMAuthenticationTypeFilter AV11Filter ;
   }

}
