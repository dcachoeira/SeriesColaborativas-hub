/*
               File: GAMWWEventSubscriptions
        Description: Event Susbcrtiptions
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:45:29.91
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
   public class gamwweventsubscriptions : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamwweventsubscriptions( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamwweventsubscriptions( IGxContext context )
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
         cmbavStatus = new GXCombobox();
         cmbavEvent = new GXCombobox();
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
               nRC_GXsfl_32 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_32_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_32_idx = GetNextPar( );
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
               AV23IsAuthorized_BtnUpd = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV24IsAuthorized_BtnDlt = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV32IsAuthorized_Description = (bool)(BooleanUtil.Val(GetNextPar( )));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridww_refresh( subGridww_Rows, AV23IsAuthorized_BtnUpd, AV24IsAuthorized_BtnDlt, AV32IsAuthorized_Description) ;
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
         PA1O2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1O2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019453026", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamwweventsubscriptions.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_32", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_32), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDWWPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21GridWWPageCount), 10, 0, ",", "")));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNUPD", AV23IsAuthorized_BtnUpd);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNDLT", AV24IsAuthorized_BtnDlt);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DESCRIPTION", AV32IsAuthorized_Description);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_DESCRIPTION", GetSecureSignedToken( "", AV32IsAuthorized_Description, context));
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
            WE1O2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1O2( ) ;
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
         return formatLink("gamwweventsubscriptions.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "GAMWWEventSubscriptions" ;
      }

      public override String GetPgmdesc( )
      {
         return "Event Susbcrtiptions" ;
      }

      protected void WB1O0( )
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
            GxWebStd.gx_div_start( context, divTableheader_Internalname, 1, 0, "px", 0, "px", "TableCellsWidthAuto", "left", "top", "", "", "div");
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
            GxWebStd.gx_button_ctrl( context, bttBtnadd_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(32), 2, 0)+","+"null"+");", "Insert", bttBtnadd_Jsonclick, 7, "Insert", "", StyleString, ClassString, bttBtnadd_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e111o1_client"+"'", TempTags, "", 2, "HLP_GAMWWEventSubscriptions.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-6 CellFloatRight", "left", "top", "", "", "div");
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
               context.WriteHtmlText( "<div id=\""+"GridwwContainer"+"DivS\" data-gxgridid=\"32\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Event Description") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Status") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Entity") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "File Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Class Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Method Name") ;
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
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV5BtnUpd));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtnupd_Link));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtnupd_Tooltiptext));
               GridwwColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtnupd_Visible), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV22BtnDlt));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtndlt_Link));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtndlt_Tooltiptext));
               GridwwColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtndlt_Visible), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV8Description));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDescription_Enabled), 5, 0, ".", "")));
               GridwwColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDescription_Link));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV17Status));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbavStatus.Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", context.convertURL( AV27Subscribe));
               GridwwColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSubscribe_Tooltiptext));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV10Event));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbavEvent.Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV13FileName));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavFilename_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV6ClassName));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavClassname_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV15MethodName));
               GridwwColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavMethodname_Enabled), 5, 0, ".", "")));
               GridwwContainer.AddColumnProperties(GridwwColumn);
               GridwwColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwwColumn.AddObjectProperty("Value", StringUtil.RTrim( AV14Id));
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
         if ( wbEnd == 32 )
         {
            wbEnd = 0;
            nRC_GXsfl_32 = (short)(nGXsfl_32_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_32_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGridwwcurrentpage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20GridWWCurrentPage), 10, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV20GridWWCurrentPage), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,47);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGridwwcurrentpage_Jsonclick, 0, "Attribute", "", "", "", "", edtavGridwwcurrentpage_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMWWEventSubscriptions.htm");
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

      protected void START1O2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Event Susbcrtiptions", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1O0( ) ;
      }

      protected void WS1O2( )
      {
         START1O2( ) ;
         EVT1O2( ) ;
      }

      protected void EVT1O2( )
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
                              E121O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E131O2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "GRIDWW.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 16), "VSUBSCRIBE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 16), "VSUBSCRIBE.CLICK") == 0 ) )
                           {
                              nGXsfl_32_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
                              SubsflControlProps_322( ) ;
                              AV5BtnUpd = cgiGet( edtavBtnupd_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5BtnUpd)) ? AV39Btnupd_GXI : context.convertURL( context.PathToRelativeUrl( AV5BtnUpd))), !bGXsfl_32_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "SrcSet", context.GetImageSrcSet( AV5BtnUpd), true);
                              AV22BtnDlt = cgiGet( edtavBtndlt_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV22BtnDlt)) ? AV40Btndlt_GXI : context.convertURL( context.PathToRelativeUrl( AV22BtnDlt))), !bGXsfl_32_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "SrcSet", context.GetImageSrcSet( AV22BtnDlt), true);
                              AV8Description = cgiGet( edtavDescription_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDescription_Internalname, AV8Description);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vDESCRIPTION"+"_"+sGXsfl_32_idx, GetSecureSignedToken( sGXsfl_32_idx, StringUtil.RTrim( context.localUtil.Format( AV8Description, "")), context));
                              cmbavStatus.Name = cmbavStatus_Internalname;
                              cmbavStatus.CurrentValue = cgiGet( cmbavStatus_Internalname);
                              AV17Status = cgiGet( cmbavStatus_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavStatus_Internalname, AV17Status);
                              AV27Subscribe = cgiGet( edtavSubscribe_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSubscribe_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV27Subscribe)) ? AV41Subscribe_GXI : context.convertURL( context.PathToRelativeUrl( AV27Subscribe))), !bGXsfl_32_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSubscribe_Internalname, "SrcSet", context.GetImageSrcSet( AV27Subscribe), true);
                              cmbavEvent.Name = cmbavEvent_Internalname;
                              cmbavEvent.CurrentValue = cgiGet( cmbavEvent_Internalname);
                              AV10Event = cgiGet( cmbavEvent_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavEvent_Internalname, AV10Event);
                              AV13FileName = cgiGet( edtavFilename_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavFilename_Internalname, AV13FileName);
                              AV6ClassName = cgiGet( edtavClassname_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavClassname_Internalname, AV6ClassName);
                              AV15MethodName = cgiGet( edtavMethodname_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavMethodname_Internalname, AV15MethodName);
                              AV14Id = cgiGet( edtavId_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, AV14Id);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID"+"_"+sGXsfl_32_idx, GetSecureSignedToken( sGXsfl_32_idx, StringUtil.RTrim( context.localUtil.Format( AV14Id, "")), context));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E141O2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E151O2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDWW.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E161O2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VSUBSCRIBE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E171O2 ();
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

      protected void WE1O2( )
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

      protected void PA1O2( )
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
            GXCCtl = "vSTATUS_" + sGXsfl_32_idx;
            cmbavStatus.Name = GXCCtl;
            cmbavStatus.WebTags = "";
            cmbavStatus.addItem("u", "Unsubscribed", 0);
            cmbavStatus.addItem("s", "Subscribed", 0);
            if ( cmbavStatus.ItemCount > 0 )
            {
               AV17Status = cmbavStatus.getValidValue(AV17Status);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavStatus_Internalname, AV17Status);
            }
            GXCCtl = "vEVENT_" + sGXsfl_32_idx;
            cmbavEvent.Name = GXCCtl;
            cmbavEvent.WebTags = "";
            cmbavEvent.addItem("user-update", "User - Update", 0);
            cmbavEvent.addItem("user-insert", "User - Insert", 0);
            cmbavEvent.addItem("user-delete", "User - Delete", 0);
            cmbavEvent.addItem("user-updateroles", "User - Update Roles", 0);
            cmbavEvent.addItem("user-getcustominfo", "User - Get Custom Information on GAMRemote Server", 0);
            cmbavEvent.addItem("user-savecustominfo", "User - Save Custom Information on GAMRemote Client", 0);
            cmbavEvent.addItem("role-insert", "Role - Insert", 0);
            cmbavEvent.addItem("role-update", "Role - Update", 0);
            cmbavEvent.addItem("role-delete", "Role - Delete", 0);
            cmbavEvent.addItem("repository-login", "Repository - Login", 0);
            cmbavEvent.addItem("repository-logout", "Repository - Logout", 0);
            cmbavEvent.addItem("application-checkprmfail", "Application - Check Permission Fail", 0);
            if ( cmbavEvent.ItemCount > 0 )
            {
               AV10Event = cmbavEvent.getValidValue(AV10Event);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavEvent_Internalname, AV10Event);
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
               GX_FocusControl = edtavGridwwcurrentpage_Internalname;
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
         SubsflControlProps_322( ) ;
         while ( nGXsfl_32_idx <= nRC_GXsfl_32 )
         {
            sendrow_322( ) ;
            nGXsfl_32_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_32_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_32_idx+1));
            sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
            SubsflControlProps_322( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridwwContainer));
         /* End function gxnrGridww_newrow */
      }

      protected void gxgrGridww_refresh( int subGridww_Rows ,
                                         bool AV23IsAuthorized_BtnUpd ,
                                         bool AV24IsAuthorized_BtnDlt ,
                                         bool AV32IsAuthorized_Description )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         GRIDWW_nCurrentRecord = 0;
         RF1O2( ) ;
         /* End function gxgrGridww_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV14Id, "")), context));
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.RTrim( AV14Id));
         GxWebStd.gx_hidden_field( context, "gxhash_vDESCRIPTION", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8Description, "")), context));
         GxWebStd.gx_hidden_field( context, "vDESCRIPTION", StringUtil.RTrim( AV8Description));
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
         RF1O2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDescription_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         cmbavStatus.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavStatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavStatus.Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         cmbavEvent.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavEvent_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavEvent.Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         edtavFilename_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavFilename_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavFilename_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         edtavClassname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClassname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClassname_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         edtavMethodname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMethodname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMethodname_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
      }

      protected void RF1O2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridwwContainer.ClearRows();
         }
         wbStart = 32;
         /* Execute user event: Refresh */
         E151O2 ();
         nGXsfl_32_idx = 1;
         sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
         SubsflControlProps_322( ) ;
         bGXsfl_32_Refreshing = true;
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
            SubsflControlProps_322( ) ;
            E161O2 ();
            if ( ( GRIDWW_nCurrentRecord > 0 ) && ( GRIDWW_nGridOutOfScope == 0 ) && ( nGXsfl_32_idx == 1 ) )
            {
               GRIDWW_nCurrentRecord = 0;
               GRIDWW_nGridOutOfScope = 1;
               subgridww_firstpage( ) ;
               E161O2 ();
            }
            wbEnd = 32;
            WB1O0( ) ;
         }
         bGXsfl_32_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1O2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DESCRIPTION", AV32IsAuthorized_Description);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_DESCRIPTION", GetSecureSignedToken( "", AV32IsAuthorized_Description, context));
         GxWebStd.gx_hidden_field( context, "gxhash_vID"+"_"+sGXsfl_32_idx, GetSecureSignedToken( sGXsfl_32_idx, StringUtil.RTrim( context.localUtil.Format( AV14Id, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vDESCRIPTION"+"_"+sGXsfl_32_idx, GetSecureSignedToken( sGXsfl_32_idx, StringUtil.RTrim( context.localUtil.Format( AV8Description, "")), context));
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
            gxgrGridww_refresh( subGridww_Rows, AV23IsAuthorized_BtnUpd, AV24IsAuthorized_BtnDlt, AV32IsAuthorized_Description) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV23IsAuthorized_BtnUpd, AV24IsAuthorized_BtnDlt, AV32IsAuthorized_Description) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV23IsAuthorized_BtnUpd, AV24IsAuthorized_BtnDlt, AV32IsAuthorized_Description) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV23IsAuthorized_BtnUpd, AV24IsAuthorized_BtnDlt, AV32IsAuthorized_Description) ;
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
            gxgrGridww_refresh( subGridww_Rows, AV23IsAuthorized_BtnUpd, AV24IsAuthorized_BtnDlt, AV32IsAuthorized_Description) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDWW_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDWW_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP1O0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDescription_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         cmbavStatus.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavStatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavStatus.Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         cmbavEvent.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavEvent_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavEvent.Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         edtavFilename_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavFilename_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavFilename_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         edtavClassname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavClassname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavClassname_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         edtavMethodname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMethodname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMethodname_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         edtavId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_Enabled), 5, 0)), !bGXsfl_32_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E141O2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vGRIDWWCURRENTPAGE");
               GX_FocusControl = edtavGridwwcurrentpage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV20GridWWCurrentPage = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GridWWCurrentPage), 10, 0)));
            }
            else
            {
               AV20GridWWCurrentPage = (long)(context.localUtil.CToN( cgiGet( edtavGridwwcurrentpage_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GridWWCurrentPage), 10, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_32 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_32"), ",", "."));
            AV21GridWWPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDWWPAGECOUNT"), ",", "."));
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
         E141O2 ();
         if (returnInSub) return;
      }

      protected void E141O2( )
      {
         /* Start Routine */
         subGridww_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV20GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GridWWCurrentPage), 10, 0)));
         edtavGridwwcurrentpage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGridwwcurrentpage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGridwwcurrentpage_Visible), 5, 0)), true);
         AV21GridWWPageCount = -1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GridWWPageCount), 10, 0)));
         GXt_boolean1 = AV32IsAuthorized_Description;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gameventsubscriptionentry_Execute", out  GXt_boolean1) ;
         AV32IsAuthorized_Description = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32IsAuthorized_Description", AV32IsAuthorized_Description);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_DESCRIPTION", GetSecureSignedToken( "", AV32IsAuthorized_Description, context));
         Gridwwpaginationbar_Rowsperpageselectedvalue = subGridww_Rows;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Gridwwpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridwwpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E151O2( )
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

      private void E161O2( )
      {
         /* Gridww_Load Routine */
         AV26GAMEventSubscriptions = new SdtGAMRepository(context).geteventsubscriptions(AV11EventSubscriptionFilter, out  AV9Errors);
         if ( AV26GAMEventSubscriptions.Count == 0 )
         {
            AV21GridWWPageCount = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GridWWPageCount), 10, 0)));
         }
         else
         {
            AV21GridWWPageCount = (long)((AV26GAMEventSubscriptions.Count/ (decimal)(9))+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GridWWPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GridWWPageCount), 10, 0)));
         }
         AV30GridWWRecordCount = AV26GAMEventSubscriptions.Count;
         AV31GridWWPageSize = 9;
         AV38GXV1 = 1;
         while ( AV38GXV1 <= AV26GAMEventSubscriptions.Count )
         {
            AV12EventSuscription = ((SdtGAMEventSubscription)AV26GAMEventSubscriptions.Item(AV38GXV1));
            AV14Id = AV12EventSuscription.gxTpr_Id;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavId_Internalname, AV14Id);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID"+"_"+sGXsfl_32_idx, GetSecureSignedToken( sGXsfl_32_idx, StringUtil.RTrim( context.localUtil.Format( AV14Id, "")), context));
            AV8Description = AV12EventSuscription.gxTpr_Description;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDescription_Internalname, AV8Description);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vDESCRIPTION"+"_"+sGXsfl_32_idx, GetSecureSignedToken( sGXsfl_32_idx, StringUtil.RTrim( context.localUtil.Format( AV8Description, "")), context));
            AV17Status = AV12EventSuscription.gxTpr_Status;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavStatus_Internalname, AV17Status);
            AV10Event = AV12EventSuscription.gxTpr_Event;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavEvent_Internalname, AV10Event);
            AV13FileName = AV12EventSuscription.gxTpr_Filename;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavFilename_Internalname, AV13FileName);
            AV6ClassName = AV12EventSuscription.gxTpr_Classname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavClassname_Internalname, AV6ClassName);
            AV15MethodName = AV12EventSuscription.gxTpr_Methodname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavMethodname_Internalname, AV15MethodName);
            AV5BtnUpd = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtnupd_Internalname, AV5BtnUpd);
            AV39Btnupd_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
            edtavBtnupd_Tooltiptext = "Update";
            if ( AV23IsAuthorized_BtnUpd )
            {
               edtavBtnupd_Link = formatLink("gameventsubscriptionentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(AV14Id));
            }
            AV22BtnDlt = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtndlt_Internalname, AV22BtnDlt);
            AV40Btndlt_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
            edtavBtndlt_Tooltiptext = "Delete";
            if ( AV24IsAuthorized_BtnDlt )
            {
               edtavBtndlt_Link = formatLink("gameventsubscriptionentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(AV14Id));
            }
            AV27Subscribe = context.GetImagePath( "b6756c95-9c4d-4ad8-a89d-3b506d3989b2", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSubscribe_Internalname, AV27Subscribe);
            AV41Subscribe_GXI = GXDbFile.PathToUrl( context.GetImagePath( "b6756c95-9c4d-4ad8-a89d-3b506d3989b2", "", context.GetTheme( )));
            edtavSubscribe_Tooltiptext = "Subscribe";
            if ( AV32IsAuthorized_Description )
            {
               edtavDescription_Link = formatLink("gameventsubscriptionentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode(StringUtil.RTrim(AV14Id));
            }
            if ( StringUtil.StrCmp(AV17Status, "s") == 0 )
            {
               AV27Subscribe = context.GetImagePath( "0a2f07a0-2541-4460-b333-43ce89262aec", "", context.GetTheme( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSubscribe_Internalname, AV27Subscribe);
               AV41Subscribe_GXI = GXDbFile.PathToUrl( context.GetImagePath( "0a2f07a0-2541-4460-b333-43ce89262aec", "", context.GetTheme( )));
               edtavSubscribe_Tooltiptext = "Unsubscribe";
            }
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 32;
            }
            if ( ( subGridww_Islastpage == 1 ) || ( subGridww_Rows == 0 ) || ( ( GRIDWW_nCurrentRecord >= GRIDWW_nFirstRecordOnPage ) && ( GRIDWW_nCurrentRecord < GRIDWW_nFirstRecordOnPage + subGridww_Recordsperpage( ) ) ) )
            {
               sendrow_322( ) ;
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
            if ( isFullAjaxMode( ) && ! bGXsfl_32_Refreshing )
            {
               context.DoAjaxLoad(32, GridwwRow);
            }
            AV38GXV1 = (int)(AV38GXV1+1);
         }
         /*  Sending Event outputs  */
         cmbavStatus.CurrentValue = StringUtil.RTrim( AV17Status);
         cmbavEvent.CurrentValue = StringUtil.RTrim( AV10Event);
      }

      protected void E121O2( )
      {
         /* Gridwwpaginationbar_Changepage Routine */
         if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Previous") == 0 )
         {
            AV20GridWWCurrentPage = (long)(AV20GridWWCurrentPage-1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GridWWCurrentPage), 10, 0)));
            subgridww_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridwwpaginationbar_Selectedpage, "Next") == 0 )
         {
            AV20GridWWCurrentPage = (long)(AV20GridWWCurrentPage+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GridWWCurrentPage), 10, 0)));
            subgridww_nextpage( ) ;
         }
         else
         {
            AV19PageToGo = (int)(NumberUtil.Val( Gridwwpaginationbar_Selectedpage, "."));
            AV20GridWWCurrentPage = AV19PageToGo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GridWWCurrentPage), 10, 0)));
            subgridww_gotopage( AV19PageToGo) ;
         }
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
      }

      protected void E131O2( )
      {
         /* Gridwwpaginationbar_Changerowsperpage Routine */
         subGridww_Rows = Gridwwpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRIDWW_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridww_Rows), 6, 0, ".", "")));
         AV20GridWWCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GridWWCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GridWWCurrentPage), 10, 0)));
         subgridww_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV23IsAuthorized_BtnUpd;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gameventsubscriptionentry_Execute", out  GXt_boolean1) ;
         AV23IsAuthorized_BtnUpd = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23IsAuthorized_BtnUpd", AV23IsAuthorized_BtnUpd);
         if ( ! ( AV23IsAuthorized_BtnUpd ) )
         {
            edtavBtnupd_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtnupd_Visible), 5, 0)), !bGXsfl_32_Refreshing);
         }
         GXt_boolean1 = AV24IsAuthorized_BtnDlt;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gameventsubscriptionentry_Execute", out  GXt_boolean1) ;
         AV24IsAuthorized_BtnDlt = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24IsAuthorized_BtnDlt", AV24IsAuthorized_BtnDlt);
         if ( ! ( AV24IsAuthorized_BtnDlt ) )
         {
            edtavBtndlt_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtndlt_Visible), 5, 0)), !bGXsfl_32_Refreshing);
         }
         GXt_boolean1 = AV25TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gameventsubscriptionentry_Execute", out  GXt_boolean1) ;
         AV25TempBoolean = GXt_boolean1;
         if ( ! ( AV25TempBoolean ) )
         {
            bttBtnadd_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnadd_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnadd_Visible), 5, 0)), true);
         }
      }

      protected void E171O2( )
      {
         /* Subscribe_Click Routine */
         if ( StringUtil.StrCmp(AV17Status, "u") == 0 )
         {
            AV29isOK = new SdtGAMRepository(context).subscribeevent(AV14Id, out  AV9Errors);
            AV17Status = "s";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavStatus_Internalname, AV17Status);
         }
         else
         {
            AV29isOK = new SdtGAMRepository(context).unsubscribeevent(AV14Id, out  AV9Errors);
            AV17Status = "u";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavStatus_Internalname, AV17Status);
         }
         if ( ! AV29isOK )
         {
            AV42GXV2 = 1;
            while ( AV42GXV2 <= AV9Errors.Count )
            {
               AV28Error = ((SdtGAMError)AV9Errors.Item(AV42GXV2));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV28Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV28Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
               AV42GXV2 = (int)(AV42GXV2+1);
            }
         }
         else
         {
            if ( StringUtil.StrCmp(AV17Status, "u") == 0 )
            {
               GX_msglist.addItem("Event "+AV8Description+" Unsubscription success");
            }
            else
            {
               GX_msglist.addItem("Event "+AV8Description+" subscription success");
            }
            pr_gam.commit( "GAMWWEventSubscriptions");
            pr_default.commit( "GAMWWEventSubscriptions");
            gxgrGridww_refresh( subGridww_Rows, AV23IsAuthorized_BtnUpd, AV24IsAuthorized_BtnDlt, AV32IsAuthorized_Description) ;
         }
         /*  Sending Event outputs  */
         cmbavStatus.CurrentValue = StringUtil.RTrim( AV17Status);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavStatus_Internalname, "Values", cmbavStatus.ToJavascriptSource(), true);
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
         PA1O2( ) ;
         WS1O2( ) ;
         WE1O2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019453677", true);
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
            context.AddJavascriptSource("gamwweventsubscriptions.js", "?201892019453680", false);
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

      protected void SubsflControlProps_322( )
      {
         edtavBtnupd_Internalname = "vBTNUPD_"+sGXsfl_32_idx;
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_32_idx;
         edtavDescription_Internalname = "vDESCRIPTION_"+sGXsfl_32_idx;
         cmbavStatus_Internalname = "vSTATUS_"+sGXsfl_32_idx;
         edtavSubscribe_Internalname = "vSUBSCRIBE_"+sGXsfl_32_idx;
         cmbavEvent_Internalname = "vEVENT_"+sGXsfl_32_idx;
         edtavFilename_Internalname = "vFILENAME_"+sGXsfl_32_idx;
         edtavClassname_Internalname = "vCLASSNAME_"+sGXsfl_32_idx;
         edtavMethodname_Internalname = "vMETHODNAME_"+sGXsfl_32_idx;
         edtavId_Internalname = "vID_"+sGXsfl_32_idx;
      }

      protected void SubsflControlProps_fel_322( )
      {
         edtavBtnupd_Internalname = "vBTNUPD_"+sGXsfl_32_fel_idx;
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_32_fel_idx;
         edtavDescription_Internalname = "vDESCRIPTION_"+sGXsfl_32_fel_idx;
         cmbavStatus_Internalname = "vSTATUS_"+sGXsfl_32_fel_idx;
         edtavSubscribe_Internalname = "vSUBSCRIBE_"+sGXsfl_32_fel_idx;
         cmbavEvent_Internalname = "vEVENT_"+sGXsfl_32_fel_idx;
         edtavFilename_Internalname = "vFILENAME_"+sGXsfl_32_fel_idx;
         edtavClassname_Internalname = "vCLASSNAME_"+sGXsfl_32_fel_idx;
         edtavMethodname_Internalname = "vMETHODNAME_"+sGXsfl_32_fel_idx;
         edtavId_Internalname = "vID_"+sGXsfl_32_fel_idx;
      }

      protected void sendrow_322( )
      {
         SubsflControlProps_322( ) ;
         WB1O0( ) ;
         if ( ( subGridww_Rows * 1 == 0 ) || ( nGXsfl_32_idx <= subGridww_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_32_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_32_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtnupd_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV5BtnUpd_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5BtnUpd))&&String.IsNullOrEmpty(StringUtil.RTrim( AV39Btnupd_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5BtnUpd)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5BtnUpd)) ? AV39Btnupd_GXI : context.PathToRelativeUrl( AV5BtnUpd));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtnupd_Internalname,(String)sImgUrl,(String)edtavBtnupd_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtnupd_Visible,(short)1,(String)"",(String)edtavBtnupd_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5BtnUpd_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtndlt_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute";
            StyleString = "";
            AV22BtnDlt_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV22BtnDlt))&&String.IsNullOrEmpty(StringUtil.RTrim( AV40Btndlt_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV22BtnDlt)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV22BtnDlt)) ? AV40Btndlt_GXI : context.PathToRelativeUrl( AV22BtnDlt));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtndlt_Internalname,(String)sImgUrl,(String)edtavBtndlt_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtndlt_Visible,(short)1,(String)"",(String)edtavBtndlt_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV22BtnDlt_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavDescription_Enabled!=0)&&(edtavDescription_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 35,'',false,'"+sGXsfl_32_idx+"',32)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDescription_Internalname,StringUtil.RTrim( AV8Description),(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavDescription_Enabled!=0)&&(edtavDescription_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,35);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavDescription_Link,(String)"",(String)"",(String)"",(String)edtavDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavDescription_Enabled,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)254,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionLong",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            TempTags = " " + ((cmbavStatus.Enabled!=0)&&(cmbavStatus.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 36,'',false,'"+sGXsfl_32_idx+"',32)\"" : " ");
            if ( ( cmbavStatus.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "vSTATUS_" + sGXsfl_32_idx;
               cmbavStatus.Name = GXCCtl;
               cmbavStatus.WebTags = "";
               cmbavStatus.addItem("u", "Unsubscribed", 0);
               cmbavStatus.addItem("s", "Subscribed", 0);
               if ( cmbavStatus.ItemCount > 0 )
               {
                  AV17Status = cmbavStatus.getValidValue(AV17Status);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavStatus_Internalname, AV17Status);
               }
            }
            /* ComboBox */
            GridwwRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavStatus,(String)cmbavStatus_Internalname,StringUtil.RTrim( AV17Status),(short)1,(String)cmbavStatus_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,cmbavStatus.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((cmbavStatus.Enabled!=0)&&(cmbavStatus.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,36);\"" : " "),(String)"",(bool)true});
            cmbavStatus.CurrentValue = StringUtil.RTrim( AV17Status);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavStatus_Internalname, "Values", (String)(cmbavStatus.ToJavascriptSource()), !bGXsfl_32_Refreshing);
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavSubscribe_Enabled!=0)&&(edtavSubscribe_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 37,'',false,'',32)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV27Subscribe_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV27Subscribe))&&String.IsNullOrEmpty(StringUtil.RTrim( AV41Subscribe_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV27Subscribe)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV27Subscribe)) ? AV41Subscribe_GXI : context.PathToRelativeUrl( AV27Subscribe));
            GridwwRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSubscribe_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSubscribe_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSubscribe_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVSUBSCRIBE.CLICK."+sGXsfl_32_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV27Subscribe_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            TempTags = " " + ((cmbavEvent.Enabled!=0)&&(cmbavEvent.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 38,'',false,'"+sGXsfl_32_idx+"',32)\"" : " ");
            if ( ( cmbavEvent.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "vEVENT_" + sGXsfl_32_idx;
               cmbavEvent.Name = GXCCtl;
               cmbavEvent.WebTags = "";
               cmbavEvent.addItem("user-update", "User - Update", 0);
               cmbavEvent.addItem("user-insert", "User - Insert", 0);
               cmbavEvent.addItem("user-delete", "User - Delete", 0);
               cmbavEvent.addItem("user-updateroles", "User - Update Roles", 0);
               cmbavEvent.addItem("user-getcustominfo", "User - Get Custom Information on GAMRemote Server", 0);
               cmbavEvent.addItem("user-savecustominfo", "User - Save Custom Information on GAMRemote Client", 0);
               cmbavEvent.addItem("role-insert", "Role - Insert", 0);
               cmbavEvent.addItem("role-update", "Role - Update", 0);
               cmbavEvent.addItem("role-delete", "Role - Delete", 0);
               cmbavEvent.addItem("repository-login", "Repository - Login", 0);
               cmbavEvent.addItem("repository-logout", "Repository - Logout", 0);
               cmbavEvent.addItem("application-checkprmfail", "Application - Check Permission Fail", 0);
               if ( cmbavEvent.ItemCount > 0 )
               {
                  AV10Event = cmbavEvent.getValidValue(AV10Event);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavEvent_Internalname, AV10Event);
               }
            }
            /* ComboBox */
            GridwwRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavEvent,(String)cmbavEvent_Internalname,StringUtil.RTrim( AV10Event),(short)1,(String)cmbavEvent_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,cmbavEvent.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((cmbavEvent.Enabled!=0)&&(cmbavEvent.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,38);\"" : " "),(String)"",(bool)true});
            cmbavEvent.CurrentValue = StringUtil.RTrim( AV10Event);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavEvent_Internalname, "Values", (String)(cmbavEvent.ToJavascriptSource()), !bGXsfl_32_Refreshing);
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavFilename_Enabled!=0)&&(edtavFilename_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 39,'',false,'"+sGXsfl_32_idx+"',32)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavFilename_Internalname,StringUtil.RTrim( AV13FileName),(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavFilename_Enabled!=0)&&(edtavFilename_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,39);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavFilename_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavFilename_Enabled,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)254,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionLong",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavClassname_Enabled!=0)&&(edtavClassname_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 40,'',false,'"+sGXsfl_32_idx+"',32)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavClassname_Internalname,StringUtil.RTrim( AV6ClassName),(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavClassname_Enabled!=0)&&(edtavClassname_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,40);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavClassname_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavClassname_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionShort",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavMethodname_Enabled!=0)&&(edtavMethodname_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 41,'',false,'"+sGXsfl_32_idx+"',32)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavMethodname_Internalname,StringUtil.RTrim( AV15MethodName),(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavMethodname_Enabled!=0)&&(edtavMethodname_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,41);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavMethodname_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavMethodname_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionShort",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridwwContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 42,'',false,'"+sGXsfl_32_idx+"',32)\"" : " ");
            ROClassString = "Attribute";
            GridwwRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavId_Internalname,StringUtil.RTrim( AV14Id),(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavId_Enabled!=0)&&(edtavId_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,42);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavId_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)0,(bool)true,(String)"GAMGUID",(String)"left",(bool)true});
            send_integrity_lvl_hashes1O2( ) ;
            GridwwContainer.AddRow(GridwwRow);
            nGXsfl_32_idx = (short)(((subGridww_Islastpage==1)&&(nGXsfl_32_idx+1>subGridww_Recordsperpage( )) ? 1 : nGXsfl_32_idx+1));
            sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
            SubsflControlProps_322( ) ;
         }
         /* End function sendrow_322 */
      }

      protected void init_default_properties( )
      {
         bttBtnadd_Internalname = "BTNADD";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavBtnupd_Internalname = "vBTNUPD";
         edtavBtndlt_Internalname = "vBTNDLT";
         edtavDescription_Internalname = "vDESCRIPTION";
         cmbavStatus_Internalname = "vSTATUS";
         edtavSubscribe_Internalname = "vSUBSCRIBE";
         cmbavEvent_Internalname = "vEVENT";
         edtavFilename_Internalname = "vFILENAME";
         edtavClassname_Internalname = "vCLASSNAME";
         edtavMethodname_Internalname = "vMETHODNAME";
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
         edtavMethodname_Jsonclick = "";
         edtavMethodname_Visible = -1;
         edtavClassname_Jsonclick = "";
         edtavClassname_Visible = -1;
         edtavFilename_Jsonclick = "";
         edtavFilename_Visible = -1;
         cmbavEvent_Jsonclick = "";
         cmbavEvent.Visible = -1;
         edtavSubscribe_Jsonclick = "";
         edtavSubscribe_Visible = -1;
         edtavSubscribe_Enabled = 1;
         cmbavStatus_Jsonclick = "";
         cmbavStatus.Visible = -1;
         edtavDescription_Jsonclick = "";
         edtavDescription_Visible = -1;
         edtavGridwwcurrentpage_Jsonclick = "";
         edtavGridwwcurrentpage_Visible = 1;
         subGridww_Allowcollapsing = 0;
         subGridww_Allowselection = 0;
         edtavSubscribe_Tooltiptext = "Subscribe";
         edtavDescription_Link = "";
         edtavBtndlt_Tooltiptext = "Delete";
         edtavBtndlt_Link = "";
         edtavBtnupd_Tooltiptext = "Update";
         edtavBtnupd_Link = "";
         edtavId_Enabled = 1;
         edtavMethodname_Enabled = 1;
         edtavClassname_Enabled = 1;
         edtavFilename_Enabled = 1;
         cmbavEvent.Enabled = 1;
         cmbavStatus.Enabled = 1;
         edtavDescription_Enabled = 1;
         edtavBtndlt_Visible = -1;
         edtavBtnupd_Visible = -1;
         subGridww_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGridww_Backcolorstyle = 0;
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
         Form.Caption = "Event Susbcrtiptions";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV23IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV24IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV32IsAuthorized_Description',fld:'vISAUTHORIZED_DESCRIPTION',pic:'',hsh:true,nv:false}],oparms:[{av:'AV23IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'edtavBtnupd_Visible',ctrl:'vBTNUPD',prop:'Visible'},{av:'AV24IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'edtavBtndlt_Visible',ctrl:'vBTNDLT',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDWW.LOAD","{handler:'E161O2',iparms:[{av:'AV23IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV24IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV32IsAuthorized_Description',fld:'vISAUTHORIZED_DESCRIPTION',pic:'',hsh:true,nv:false}],oparms:[{av:'AV21GridWWPageCount',fld:'vGRIDWWPAGECOUNT',pic:'ZZZZZZZZZ9',nv:0},{av:'AV14Id',fld:'vID',pic:'',hsh:true,nv:''},{av:'AV8Description',fld:'vDESCRIPTION',pic:'',hsh:true,nv:''},{av:'cmbavStatus'},{av:'AV17Status',fld:'vSTATUS',pic:'',nv:''},{av:'cmbavEvent'},{av:'AV10Event',fld:'vEVENT',pic:'',nv:''},{av:'AV13FileName',fld:'vFILENAME',pic:'',nv:''},{av:'AV6ClassName',fld:'vCLASSNAME',pic:'',nv:''},{av:'AV15MethodName',fld:'vMETHODNAME',pic:'',nv:''},{av:'AV5BtnUpd',fld:'vBTNUPD',pic:'',nv:''},{av:'edtavBtnupd_Tooltiptext',ctrl:'vBTNUPD',prop:'Tooltiptext'},{av:'edtavBtnupd_Link',ctrl:'vBTNUPD',prop:'Link'},{av:'AV22BtnDlt',fld:'vBTNDLT',pic:'',nv:''},{av:'edtavBtndlt_Tooltiptext',ctrl:'vBTNDLT',prop:'Tooltiptext'},{av:'edtavBtndlt_Link',ctrl:'vBTNDLT',prop:'Link'},{av:'AV27Subscribe',fld:'vSUBSCRIBE',pic:'',nv:''},{av:'edtavSubscribe_Tooltiptext',ctrl:'vSUBSCRIBE',prop:'Tooltiptext'},{av:'edtavDescription_Link',ctrl:'vDESCRIPTION',prop:'Link'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEPAGE","{handler:'E121O2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV23IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV24IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV32IsAuthorized_Description',fld:'vISAUTHORIZED_DESCRIPTION',pic:'',hsh:true,nv:false},{av:'Gridwwpaginationbar_Selectedpage',ctrl:'GRIDWWPAGINATIONBAR',prop:'SelectedPage'},{av:'AV20GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}],oparms:[{av:'AV20GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV23IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'edtavBtnupd_Visible',ctrl:'vBTNUPD',prop:'Visible'},{av:'AV24IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'edtavBtndlt_Visible',ctrl:'vBTNDLT',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDWWPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E131O2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV23IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV24IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV32IsAuthorized_Description',fld:'vISAUTHORIZED_DESCRIPTION',pic:'',hsh:true,nv:false},{av:'Gridwwpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDWWPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],oparms:[{av:'subGridww_Rows',ctrl:'GRIDWW',prop:'Rows'},{av:'AV20GridWWCurrentPage',fld:'vGRIDWWCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("'DOADD'","{handler:'E111O1',iparms:[],oparms:[]}");
         setEventMetadata("VSUBSCRIBE.CLICK","{handler:'E171O2',iparms:[{av:'GRIDWW_nFirstRecordOnPage',nv:0},{av:'GRIDWW_nEOF',nv:0},{av:'subGridww_Rows',nv:0},{av:'AV23IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV24IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV32IsAuthorized_Description',fld:'vISAUTHORIZED_DESCRIPTION',pic:'',hsh:true,nv:false},{av:'cmbavStatus'},{av:'AV17Status',fld:'vSTATUS',pic:'',nv:''},{av:'AV14Id',fld:'vID',pic:'',hsh:true,nv:''},{av:'AV8Description',fld:'vDESCRIPTION',pic:'',hsh:true,nv:''}],oparms:[{av:'cmbavStatus'},{av:'AV17Status',fld:'vSTATUS',pic:'',nv:''},{av:'AV23IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'edtavBtnupd_Visible',ctrl:'vBTNUPD',prop:'Visible'},{av:'AV24IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'edtavBtndlt_Visible',ctrl:'vBTNDLT',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
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
         AV5BtnUpd = "";
         AV22BtnDlt = "";
         AV8Description = "";
         AV17Status = "";
         AV27Subscribe = "";
         AV10Event = "";
         AV13FileName = "";
         AV6ClassName = "";
         AV15MethodName = "";
         AV14Id = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV39Btnupd_GXI = "";
         AV40Btndlt_GXI = "";
         AV41Subscribe_GXI = "";
         GXCCtl = "";
         AV26GAMEventSubscriptions = new GXExternalCollection<SdtGAMEventSubscription>( context, "SdtGAMEventSubscription", "GeneXus.Programs");
         AV11EventSubscriptionFilter = new SdtGAMEventSubscriptionFilter(context);
         AV9Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV12EventSuscription = new SdtGAMEventSubscription(context);
         GridwwRow = new GXWebRow();
         AV28Error = new SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamwweventsubscriptions__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamwweventsubscriptions__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavDescription_Enabled = 0;
         cmbavStatus.Enabled = 0;
         cmbavEvent.Enabled = 0;
         edtavFilename_Enabled = 0;
         edtavClassname_Enabled = 0;
         edtavMethodname_Enabled = 0;
         edtavId_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_32 ;
      private short nGXsfl_32_idx=1 ;
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
      private short AV31GridWWPageSize ;
      private short subGridww_Backstyle ;
      private int Gridwwpaginationbar_Rowsperpageselectedvalue ;
      private int subGridww_Rows ;
      private int Gridwwpaginationbar_Pagestoshow ;
      private int bttBtnadd_Visible ;
      private int subGridww_Titlebackcolor ;
      private int subGridww_Allbackcolor ;
      private int edtavBtnupd_Visible ;
      private int edtavBtndlt_Visible ;
      private int edtavDescription_Enabled ;
      private int edtavFilename_Enabled ;
      private int edtavClassname_Enabled ;
      private int edtavMethodname_Enabled ;
      private int edtavId_Enabled ;
      private int subGridww_Selectioncolor ;
      private int subGridww_Hoveringcolor ;
      private int edtavGridwwcurrentpage_Visible ;
      private int subGridww_Islastpage ;
      private int GRIDWW_nGridOutOfScope ;
      private int AV38GXV1 ;
      private int AV19PageToGo ;
      private int AV42GXV2 ;
      private int idxLst ;
      private int subGridww_Backcolor ;
      private int edtavDescription_Visible ;
      private int edtavSubscribe_Enabled ;
      private int edtavSubscribe_Visible ;
      private int edtavFilename_Visible ;
      private int edtavClassname_Visible ;
      private int edtavMethodname_Visible ;
      private int edtavId_Visible ;
      private long GRIDWW_nFirstRecordOnPage ;
      private long AV21GridWWPageCount ;
      private long AV20GridWWCurrentPage ;
      private long GRIDWW_nCurrentRecord ;
      private long GRIDWW_nRecordCount ;
      private long AV30GridWWRecordCount ;
      private String Gridwwpaginationbar_Selectedpage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_32_idx="0001" ;
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
      private String divGridwwtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGridww_Internalname ;
      private String subGridww_Class ;
      private String subGridww_Linesclass ;
      private String edtavBtnupd_Link ;
      private String edtavBtnupd_Tooltiptext ;
      private String edtavBtndlt_Link ;
      private String edtavBtndlt_Tooltiptext ;
      private String AV8Description ;
      private String edtavDescription_Link ;
      private String AV17Status ;
      private String edtavSubscribe_Tooltiptext ;
      private String AV10Event ;
      private String AV13FileName ;
      private String AV6ClassName ;
      private String AV15MethodName ;
      private String AV14Id ;
      private String divHtml_gridwwpaginationbar_Internalname ;
      private String edtavGridwwcurrentpage_Internalname ;
      private String edtavGridwwcurrentpage_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavBtnupd_Internalname ;
      private String edtavBtndlt_Internalname ;
      private String edtavDescription_Internalname ;
      private String cmbavStatus_Internalname ;
      private String edtavSubscribe_Internalname ;
      private String cmbavEvent_Internalname ;
      private String edtavFilename_Internalname ;
      private String edtavClassname_Internalname ;
      private String edtavMethodname_Internalname ;
      private String edtavId_Internalname ;
      private String GXCCtl ;
      private String Gridwwpaginationbar_Internalname ;
      private String sGXsfl_32_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtavDescription_Jsonclick ;
      private String cmbavStatus_Jsonclick ;
      private String edtavSubscribe_Jsonclick ;
      private String cmbavEvent_Jsonclick ;
      private String edtavFilename_Jsonclick ;
      private String edtavClassname_Jsonclick ;
      private String edtavMethodname_Jsonclick ;
      private String edtavId_Jsonclick ;
      private String Dvpanel_tableheader_Internalname ;
      private bool entryPointCalled ;
      private bool AV23IsAuthorized_BtnUpd ;
      private bool AV24IsAuthorized_BtnDlt ;
      private bool AV32IsAuthorized_Description ;
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
      private bool bGXsfl_32_Refreshing=false ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV25TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV29isOK ;
      private bool AV5BtnUpd_IsBlob ;
      private bool AV22BtnDlt_IsBlob ;
      private bool AV27Subscribe_IsBlob ;
      private String AV39Btnupd_GXI ;
      private String AV40Btndlt_GXI ;
      private String AV41Subscribe_GXI ;
      private String AV5BtnUpd ;
      private String AV22BtnDlt ;
      private String AV27Subscribe ;
      private GXWebGrid GridwwContainer ;
      private GXWebRow GridwwRow ;
      private GXWebColumn GridwwColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavStatus ;
      private GXCombobox cmbavEvent ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMError> AV9Errors ;
      private GXExternalCollection<SdtGAMEventSubscription> AV26GAMEventSubscriptions ;
      private GXWebForm Form ;
      private SdtGAMError AV28Error ;
      private SdtGAMEventSubscriptionFilter AV11EventSubscriptionFilter ;
      private SdtGAMEventSubscription AV12EventSuscription ;
   }

   public class gamwweventsubscriptions__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamwweventsubscriptions__default : DataStoreHelperBase, IDataStoreHelper
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
