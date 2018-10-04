/*
               File: GAMWWUsers
        Description: Users
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:40:58.55
       Program type: Main program
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
   public class gamwwusers : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamwwusers( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamwwusers( IGxContext context )
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
         cmbavFilauttype = new GXCombobox();
         cmbavFilrol = new GXCombobox();
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
               nRC_GXsfl_54 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_54_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_54_idx = GetNextPar( );
               edtavBtnrole_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnrole_Internalname, "Title", edtavBtnrole_Title, !bGXsfl_54_Refreshing);
               edtavBtnsetpwd_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnsetpwd_Internalname, "Title", edtavBtnsetpwd_Title, !bGXsfl_54_Refreshing);
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
               AV38GridCurrentPage = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV13FilAutType = GetNextPar( );
               AV30UsersXPage = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV25Search = GetNextPar( );
               AV14FilRol = (long)(NumberUtil.Val( GetNextPar( ), "."));
               edtavBtnrole_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnrole_Internalname, "Title", edtavBtnrole_Title, !bGXsfl_54_Refreshing);
               edtavBtnsetpwd_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnsetpwd_Internalname, "Title", edtavBtnsetpwd_Title, !bGXsfl_54_Refreshing);
               AV9CountUsers = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV44IsAuthorized_BtnUpd = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV41IsAuthorized_BtnDlt = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV36GAMUserIsDeleted = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV42IsAuthorized_BtnRole = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV43IsAuthorized_BtnSetPwd = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV35GAMUserIsAutoRegisteredUser = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV48IsAuthorized_Name = (bool)(BooleanUtil.Val(GetNextPar( )));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV38GridCurrentPage, AV13FilAutType, AV30UsersXPage, AV25Search, AV14FilRol, AV9CountUsers, AV44IsAuthorized_BtnUpd, AV41IsAuthorized_BtnDlt, AV36GAMUserIsDeleted, AV42IsAuthorized_BtnRole, AV43IsAuthorized_BtnSetPwd, AV35GAMUserIsAutoRegisteredUser, AV48IsAuthorized_Name) ;
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
         PA0P2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0P2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019405926", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamwwusers.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_54", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_54), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV39GridPageCount), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vCOUNTUSERS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9CountUsers), 4, 0, ",", "")));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNUPD", AV44IsAuthorized_BtnUpd);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNDLT", AV41IsAuthorized_BtnDlt);
         GxWebStd.gx_boolean_hidden_field( context, "vGAMUSERISDELETED", AV36GAMUserIsDeleted);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNROLE", AV42IsAuthorized_BtnRole);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BTNSETPWD", AV43IsAuthorized_BtnSetPwd);
         GxWebStd.gx_boolean_hidden_field( context, "vGAMUSERISAUTOREGISTEREDUSER", AV35GAMUserIsAutoRegisteredUser);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_NAME", AV48IsAuthorized_Name);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV48IsAuthorized_Name, context));
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
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vBTNROLE_Title", StringUtil.RTrim( edtavBtnrole_Title));
         GxWebStd.gx_hidden_field( context, "vBTNSETPWD_Title", StringUtil.RTrim( edtavBtnsetpwd_Title));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
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
            WE0P2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0P2( ) ;
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
         return formatLink("gamwwusers.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "GAMWWUsers" ;
      }

      public override String GetPgmdesc( )
      {
         return "Users " ;
      }

      protected void WB0P0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
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
            GxWebStd.gx_button_ctrl( context, bttBtnadd_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(54), 2, 0)+","+"null"+");", "Insert", bttBtnadd_Jsonclick, 7, "Add", "", StyleString, ClassString, bttBtnadd_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e110p1_client"+"'", TempTags, "", 2, "HLP_GAMWWUsers.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-8", "Right", "top", "", "", "div");
            wb_table1_27_0P2( true) ;
         }
         else
         {
            wb_table1_27_0P2( false) ;
         }
         return  ;
      }

      protected void wb_table1_27_0P2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "Right", "top", "div");
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
            wb_table2_48_0P2( true) ;
         }
         else
         {
            wb_table2_48_0P2( false) ;
         }
         return  ;
      }

      protected void wb_table2_48_0P2e( bool wbgen )
      {
         if ( wbgen )
         {
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
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_54_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGamuserscount_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV47GAMUsersCount), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV47GAMUsersCount), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGamuserscount_Jsonclick, 0, "Attribute", "", "", "", "", edtavGamuserscount_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMWWUsers.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_54_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUsersxpage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30UsersXPage), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV30UsersXPage), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUsersxpage_Jsonclick, 0, "Attribute", "", "", "", "", edtavUsersxpage_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMWWUsers.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0P2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Users ", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0P0( ) ;
      }

      protected void WS0P2( )
      {
         START0P2( ) ;
         EVT0P2( ) ;
      }

      protected void EVT0P2( )
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
                              E120P2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E130P2 ();
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
                              nGXsfl_54_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_54_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_54_idx), 4, 0)), 4, "0");
                              SubsflControlProps_542( ) ;
                              AV8BtnUpd = cgiGet( edtavBtnupd_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV8BtnUpd)) ? AV58Btnupd_GXI : context.convertURL( context.PathToRelativeUrl( AV8BtnUpd))), !bGXsfl_54_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "SrcSet", context.GetImageSrcSet( AV8BtnUpd), true);
                              AV31BtnDlt = cgiGet( edtavBtndlt_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV31BtnDlt)) ? AV59Btndlt_GXI : context.convertURL( context.PathToRelativeUrl( AV31BtnDlt))), !bGXsfl_54_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "SrcSet", context.GetImageSrcSet( AV31BtnDlt), true);
                              AV32BtnRole = cgiGet( edtavBtnrole_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnrole_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV32BtnRole)) ? AV60Btnrole_GXI : context.convertURL( context.PathToRelativeUrl( AV32BtnRole))), !bGXsfl_54_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnrole_Internalname, "SrcSet", context.GetImageSrcSet( AV32BtnRole), true);
                              AV33BtnSetPwd = cgiGet( edtavBtnsetpwd_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnsetpwd_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV33BtnSetPwd)) ? AV61Btnsetpwd_GXI : context.convertURL( context.PathToRelativeUrl( AV33BtnSetPwd))), !bGXsfl_54_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnsetpwd_Internalname, "SrcSet", context.GetImageSrcSet( AV33BtnSetPwd), true);
                              AV21Name = cgiGet( edtavName_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV21Name);
                              AV19FirstName = cgiGet( edtavFirstname_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavFirstname_Internalname, AV19FirstName);
                              AV20LastName = cgiGet( edtavLastname_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLastname_Internalname, AV20LastName);
                              AV6AuthenticationTypeName = cgiGet( edtavAuthenticationtypename_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAuthenticationtypename_Internalname, AV6AuthenticationTypeName);
                              AV40GUID = cgiGet( edtavGuid_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavGuid_Internalname, AV40GUID);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E140P2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E150P2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E160P2 ();
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

      protected void WE0P2( )
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

      protected void PA0P2( )
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
            cmbavFilauttype.Name = "vFILAUTTYPE";
            cmbavFilauttype.WebTags = "";
            if ( cmbavFilauttype.ItemCount > 0 )
            {
               AV13FilAutType = cmbavFilauttype.getValidValue(AV13FilAutType);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13FilAutType", AV13FilAutType);
            }
            cmbavFilrol.Name = "vFILROL";
            cmbavFilrol.WebTags = "";
            if ( cmbavFilrol.ItemCount > 0 )
            {
               AV14FilRol = (long)(NumberUtil.Val( cmbavFilrol.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV14FilRol), 12, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14FilRol", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14FilRol), 12, 0)));
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
               GX_FocusControl = edtavSearch_Internalname;
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
         SubsflControlProps_542( ) ;
         while ( nGXsfl_54_idx <= nRC_GXsfl_54 )
         {
            sendrow_542( ) ;
            nGXsfl_54_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_54_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_54_idx+1));
            sGXsfl_54_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_54_idx), 4, 0)), 4, "0");
            SubsflControlProps_542( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       long AV38GridCurrentPage ,
                                       String AV13FilAutType ,
                                       short AV30UsersXPage ,
                                       String AV25Search ,
                                       long AV14FilRol ,
                                       short AV9CountUsers ,
                                       bool AV44IsAuthorized_BtnUpd ,
                                       bool AV41IsAuthorized_BtnDlt ,
                                       bool AV36GAMUserIsDeleted ,
                                       bool AV42IsAuthorized_BtnRole ,
                                       bool AV43IsAuthorized_BtnSetPwd ,
                                       bool AV35GAMUserIsAutoRegisteredUser ,
                                       bool AV48IsAuthorized_Name )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0P2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void fix_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
         }
         if ( cmbavFilauttype.ItemCount > 0 )
         {
            AV13FilAutType = cmbavFilauttype.getValidValue(AV13FilAutType);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13FilAutType", AV13FilAutType);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavFilauttype.CurrentValue = StringUtil.RTrim( AV13FilAutType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavFilauttype_Internalname, "Values", cmbavFilauttype.ToJavascriptSource(), true);
         }
         if ( cmbavFilrol.ItemCount > 0 )
         {
            AV14FilRol = (long)(NumberUtil.Val( cmbavFilrol.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV14FilRol), 12, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14FilRol", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14FilRol), 12, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavFilrol.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14FilRol), 12, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavFilrol_Internalname, "Values", cmbavFilrol.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0P2( ) ;
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
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_54_Refreshing);
         edtavFirstname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavFirstname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavFirstname_Enabled), 5, 0)), !bGXsfl_54_Refreshing);
         edtavLastname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLastname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavLastname_Enabled), 5, 0)), !bGXsfl_54_Refreshing);
         edtavAuthenticationtypename_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAuthenticationtypename_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAuthenticationtypename_Enabled), 5, 0)), !bGXsfl_54_Refreshing);
         edtavGuid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), !bGXsfl_54_Refreshing);
      }

      protected void RF0P2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 54;
         /* Execute user event: Refresh */
         E150P2 ();
         nGXsfl_54_idx = 1;
         sGXsfl_54_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_54_idx), 4, 0)), 4, "0");
         SubsflControlProps_542( ) ;
         bGXsfl_54_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWith");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_542( ) ;
            E160P2 ();
            if ( ( GRID_nCurrentRecord > 0 ) && ( GRID_nGridOutOfScope == 0 ) && ( nGXsfl_54_idx == 1 ) )
            {
               GRID_nCurrentRecord = 0;
               GRID_nGridOutOfScope = 1;
               subgrid_firstpage( ) ;
               E160P2 ();
            }
            wbEnd = 54;
            WB0P0( ) ;
         }
         bGXsfl_54_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0P2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_NAME", AV48IsAuthorized_Name);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV48IsAuthorized_Name, context));
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
         return (int)(GRID_nFirstRecordOnPage+1) ;
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
         GRID_nFirstRecordOnPage = 0;
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV38GridCurrentPage, AV13FilAutType, AV30UsersXPage, AV25Search, AV14FilRol, AV9CountUsers, AV44IsAuthorized_BtnUpd, AV41IsAuthorized_BtnDlt, AV36GAMUserIsDeleted, AV42IsAuthorized_BtnRole, AV43IsAuthorized_BtnSetPwd, AV35GAMUserIsAutoRegisteredUser, AV48IsAuthorized_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         if ( GRID_nEOF == 0 )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( ));
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV38GridCurrentPage, AV13FilAutType, AV30UsersXPage, AV25Search, AV14FilRol, AV9CountUsers, AV44IsAuthorized_BtnUpd, AV41IsAuthorized_BtnDlt, AV36GAMUserIsDeleted, AV42IsAuthorized_BtnRole, AV43IsAuthorized_BtnSetPwd, AV35GAMUserIsAutoRegisteredUser, AV48IsAuthorized_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
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
            gxgrGrid_refresh( subGrid_Rows, AV38GridCurrentPage, AV13FilAutType, AV30UsersXPage, AV25Search, AV14FilRol, AV9CountUsers, AV44IsAuthorized_BtnUpd, AV41IsAuthorized_BtnDlt, AV36GAMUserIsDeleted, AV42IsAuthorized_BtnRole, AV43IsAuthorized_BtnSetPwd, AV35GAMUserIsAutoRegisteredUser, AV48IsAuthorized_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         subGrid_Islastpage = 1;
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV38GridCurrentPage, AV13FilAutType, AV30UsersXPage, AV25Search, AV14FilRol, AV9CountUsers, AV44IsAuthorized_BtnUpd, AV41IsAuthorized_BtnDlt, AV36GAMUserIsDeleted, AV42IsAuthorized_BtnRole, AV43IsAuthorized_BtnSetPwd, AV35GAMUserIsAutoRegisteredUser, AV48IsAuthorized_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
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
            gxgrGrid_refresh( subGrid_Rows, AV38GridCurrentPage, AV13FilAutType, AV30UsersXPage, AV25Search, AV14FilRol, AV9CountUsers, AV44IsAuthorized_BtnUpd, AV41IsAuthorized_BtnDlt, AV36GAMUserIsDeleted, AV42IsAuthorized_BtnRole, AV43IsAuthorized_BtnSetPwd, AV35GAMUserIsAutoRegisteredUser, AV48IsAuthorized_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP0P0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavName_Enabled), 5, 0)), !bGXsfl_54_Refreshing);
         edtavFirstname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavFirstname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavFirstname_Enabled), 5, 0)), !bGXsfl_54_Refreshing);
         edtavLastname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLastname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavLastname_Enabled), 5, 0)), !bGXsfl_54_Refreshing);
         edtavAuthenticationtypename_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAuthenticationtypename_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAuthenticationtypename_Enabled), 5, 0)), !bGXsfl_54_Refreshing);
         edtavGuid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), !bGXsfl_54_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E140P2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV25Search = cgiGet( edtavSearch_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25Search", AV25Search);
            cmbavFilauttype.Name = cmbavFilauttype_Internalname;
            cmbavFilauttype.CurrentValue = cgiGet( cmbavFilauttype_Internalname);
            AV13FilAutType = cgiGet( cmbavFilauttype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13FilAutType", AV13FilAutType);
            cmbavFilrol.Name = cmbavFilrol_Internalname;
            cmbavFilrol.CurrentValue = cgiGet( cmbavFilrol_Internalname);
            AV14FilRol = (long)(NumberUtil.Val( cgiGet( cmbavFilrol_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14FilRol", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14FilRol), 12, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavGridcurrentpage_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavGridcurrentpage_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vGRIDCURRENTPAGE");
               GX_FocusControl = edtavGridcurrentpage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV38GridCurrentPage = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridCurrentPage), 10, 0)));
            }
            else
            {
               AV38GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( edtavGridcurrentpage_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridCurrentPage), 10, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavGamuserscount_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavGamuserscount_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vGAMUSERSCOUNT");
               GX_FocusControl = edtavGamuserscount_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV47GAMUsersCount = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47GAMUsersCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV47GAMUsersCount), 4, 0)));
            }
            else
            {
               AV47GAMUsersCount = (short)(context.localUtil.CToN( cgiGet( edtavGamuserscount_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47GAMUsersCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV47GAMUsersCount), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavUsersxpage_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavUsersxpage_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vUSERSXPAGE");
               GX_FocusControl = edtavUsersxpage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV30UsersXPage = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30UsersXPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30UsersXPage), 4, 0)));
            }
            else
            {
               AV30UsersXPage = (short)(context.localUtil.CToN( cgiGet( edtavUsersxpage_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30UsersXPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30UsersXPage), 4, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_54 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_54"), ",", "."));
            AV39GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
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
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
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
         E140P2 ();
         if (returnInSub) return;
      }

      protected void E140P2( )
      {
         /* Start Routine */
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
         edtavGamuserscount_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGamuserscount_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGamuserscount_Visible), 5, 0)), true);
         edtavUsersxpage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsersxpage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsersxpage_Visible), 5, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         AV38GridCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridCurrentPage), 10, 0)));
         edtavGridcurrentpage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGridcurrentpage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGridcurrentpage_Visible), 5, 0)), true);
         AV39GridPageCount = -1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV39GridPageCount), 10, 0)));
         GXt_boolean1 = AV48IsAuthorized_Name;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamuserentry_Execute", out  GXt_boolean1) ;
         AV48IsAuthorized_Name = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48IsAuthorized_Name", AV48IsAuthorized_Name);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_NAME", GetSecureSignedToken( "", AV48IsAuthorized_Name, context));
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         AV30UsersXPage = 9;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30UsersXPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30UsersXPage), 4, 0)));
         cmbavFilauttype.removeAllItems();
         cmbavFilauttype.addItem("", "All", 0);
         AV7AuthenticationTypes = new SdtGAMRepository(context).getauthenticationtypes(AV16FilterAutType, out  AV12Errors);
         AV55GXV1 = 1;
         while ( AV55GXV1 <= AV7AuthenticationTypes.Count )
         {
            AV5AuthenticationType = ((SdtGAMAuthenticationType)AV7AuthenticationTypes.Item(AV55GXV1));
            cmbavFilauttype.addItem(AV5AuthenticationType.gxTpr_Name, AV5AuthenticationType.gxTpr_Description, 0);
            AV55GXV1 = (int)(AV55GXV1+1);
         }
         cmbavFilrol.removeAllItems();
         cmbavFilrol.addItem("0", "All", 0);
         cmbavFilrol.addItem("-1", "No role", 0);
         AV24Roles = AV22Repository.getroles(AV17FilterRoles, out  AV12Errors);
         AV56GXV2 = 1;
         while ( AV56GXV2 <= AV24Roles.Count )
         {
            AV23Role = ((SdtGAMRole)AV24Roles.Item(AV56GXV2));
            cmbavFilrol.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV23Role.gxTpr_Id), 12, 0)), AV23Role.gxTpr_Name, 0);
            AV56GXV2 = (int)(AV56GXV2+1);
         }
         edtavBtnrole_Title = "Roles";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnrole_Internalname, "Title", edtavBtnrole_Title, !bGXsfl_54_Refreshing);
         edtavBtnsetpwd_Title = "Password";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnsetpwd_Internalname, "Title", edtavBtnsetpwd_Title, !bGXsfl_54_Refreshing);
      }

      protected void E150P2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV22Repository = new SdtGAMRepository(context).get();
         /* Execute user subroutine: 'CHECKSECURITYFORACTIONS' */
         S122 ();
         if (returnInSub) return;
         if ( AV38GridCurrentPage <= 1 )
         {
            AV38GridCurrentPage = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridCurrentPage), 10, 0)));
         }
         AV34Filter.gxTpr_Authenticationtypename = AV13FilAutType;
         AV34Filter.gxTpr_Loadcustomattributes = true;
         AV34Filter.gxTpr_Returnanonymoususer = false;
         AV34Filter.gxTpr_Limit = AV30UsersXPage+1;
         AV34Filter.gxTpr_Start = (int)((AV38GridCurrentPage-1)*AV34Filter.gxTpr_Limit);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25Search)) )
         {
            AV34Filter.gxTpr_Searchable = "%"+AV25Search;
         }
         if ( AV14FilRol == -1 )
         {
            AV34Filter.gxTpr_Withoutroles = true;
         }
         else
         {
            AV34Filter.gxTpr_Roleid = AV14FilRol;
         }
         AV37GAMUsers = new SdtGAMRepository(context).getusersorderby(AV34Filter, 0, out  AV12Errors);
         AV47GAMUsersCount = (short)(AV37GAMUsers.Count);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47GAMUsersCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV47GAMUsersCount), 4, 0)));
         if ( AV37GAMUsers.Count == AV30UsersXPage + 1 )
         {
            AV37GAMUsers.RemoveItem(AV30UsersXPage+1);
         }
         if ( cmbavFilauttype.ItemCount == 2 )
         {
            edtavAuthenticationtypename_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAuthenticationtypename_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAuthenticationtypename_Visible), 5, 0)), !bGXsfl_54_Refreshing);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22Repository", AV22Repository);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34Filter", AV34Filter);
      }

      private void E160P2( )
      {
         /* Grid_Load Routine */
         AV57GXV3 = 1;
         while ( AV57GXV3 <= AV37GAMUsers.Count )
         {
            AV27User = ((SdtGAMUser)AV37GAMUsers.Item(AV57GXV3));
            AV9CountUsers = (short)(AV9CountUsers+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9CountUsers", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9CountUsers), 4, 0)));
            AV6AuthenticationTypeName = AV27User.gxTpr_Authenticationtypename;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAuthenticationtypename_Internalname, AV6AuthenticationTypeName);
            AV40GUID = AV27User.gxTpr_Guid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavGuid_Internalname, AV40GUID);
            AV21Name = AV27User.gxTpr_Name;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavName_Internalname, AV21Name);
            AV19FirstName = AV27User.gxTpr_Firstname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavFirstname_Internalname, AV19FirstName);
            AV20LastName = AV27User.gxTpr_Lastname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLastname_Internalname, AV20LastName);
            if ( AV27User.gxTpr_Isenabledinrepository )
            {
               edtavName_Class = "ReadonlyAttribute";
               edtavFirstname_Class = "ReadonlyAttribute";
               edtavLastname_Class = "ReadonlyAttribute";
               edtavAuthenticationtypename_Class = "ReadonlyAttribute";
            }
            else
            {
               edtavName_Class = "AttributeInactive";
               edtavFirstname_Class = "AttributeInactive";
               edtavLastname_Class = "AttributeInactive";
               edtavAuthenticationtypename_Class = "AttributeInactive";
            }
            AV8BtnUpd = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtnupd_Internalname, AV8BtnUpd);
            AV58Btnupd_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
            edtavBtnupd_Tooltiptext = "Update";
            if ( AV44IsAuthorized_BtnUpd )
            {
               if ( ! ( ( StringUtil.StrCmp(StringUtil.Trim( AV40GUID), StringUtil.Trim( AV22Repository.gxTpr_Anonymoususerguid)) == 0 ) || AV27User.gxTpr_Isautoregistereduser ) )
               {
                  edtavBtnupd_Link = formatLink("gamuserentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(StringUtil.Trim( AV40GUID)));
                  edtavBtnupd_Class = "ActionBaseColorAttribute";
               }
               else
               {
                  edtavBtnupd_Link = "";
                  edtavBtnupd_Class = "Invisible";
               }
            }
            AV31BtnDlt = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtndlt_Internalname, AV31BtnDlt);
            AV59Btndlt_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
            edtavBtndlt_Tooltiptext = "Delete";
            if ( AV41IsAuthorized_BtnDlt )
            {
               if ( ! ( ( StringUtil.StrCmp(StringUtil.Trim( AV40GUID), StringUtil.Trim( AV22Repository.gxTpr_Anonymoususerguid)) == 0 ) || AV36GAMUserIsDeleted ) )
               {
                  edtavBtndlt_Link = formatLink("gamuserentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(StringUtil.Trim( AV40GUID)));
                  edtavBtndlt_Class = "DeleteAttribute";
               }
               else
               {
                  edtavBtndlt_Link = "";
                  edtavBtndlt_Class = "Invisible";
               }
            }
            AV32BtnRole = context.GetImagePath( "1399ecfa-9434-44f7-87ac-cbf49b0a76d5", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtnrole_Internalname, AV32BtnRole);
            AV60Btnrole_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1399ecfa-9434-44f7-87ac-cbf49b0a76d5", "", context.GetTheme( )));
            edtavBtnrole_Tooltiptext = "Roles";
            if ( AV42IsAuthorized_BtnRole )
            {
               edtavBtnrole_Link = formatLink("gamwwuserroles.aspx") + "?" + UrlEncode(StringUtil.RTrim(StringUtil.Trim( AV40GUID)));
            }
            AV33BtnSetPwd = context.GetImagePath( "835a2c8a-7a40-4c02-af25-cefd1ae394fb", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavBtnsetpwd_Internalname, AV33BtnSetPwd);
            AV61Btnsetpwd_GXI = GXDbFile.PathToUrl( context.GetImagePath( "835a2c8a-7a40-4c02-af25-cefd1ae394fb", "", context.GetTheme( )));
            edtavBtnsetpwd_Tooltiptext = "Set new password";
            if ( AV43IsAuthorized_BtnSetPwd )
            {
               if ( ! ( ( StringUtil.StrCmp(StringUtil.Trim( AV40GUID), StringUtil.Trim( AV22Repository.gxTpr_Anonymoususerguid)) == 0 ) || AV35GAMUserIsAutoRegisteredUser ) )
               {
                  edtavBtnsetpwd_Link = formatLink("gamsetpassword.aspx") + "?" + UrlEncode(StringUtil.RTrim(StringUtil.Trim( AV40GUID)));
                  edtavBtnsetpwd_Class = "ActionBaseColorAttribute";
               }
               else
               {
                  edtavBtnsetpwd_Link = "";
                  edtavBtnsetpwd_Class = "Invisible";
               }
            }
            if ( AV48IsAuthorized_Name )
            {
               edtavName_Link = formatLink("gamuserentry.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode(StringUtil.RTrim(StringUtil.Trim( AV40GUID)));
            }
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 54;
            }
            if ( ( subGrid_Islastpage == 1 ) || ( subGrid_Rows == 0 ) || ( ( GRID_nCurrentRecord >= GRID_nFirstRecordOnPage ) && ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) )
            {
               sendrow_542( ) ;
               GRID_nEOF = 1;
               GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
               if ( ( subGrid_Islastpage == 1 ) && ( ((int)((GRID_nCurrentRecord) % (subGrid_Recordsperpage( )))) == 0 ) )
               {
                  GRID_nFirstRecordOnPage = GRID_nCurrentRecord;
               }
            }
            if ( GRID_nCurrentRecord >= GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) )
            {
               GRID_nEOF = 0;
               GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            }
            GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
            if ( isFullAjaxMode( ) && ! bGXsfl_54_Refreshing )
            {
               context.DoAjaxLoad(54, GridRow);
            }
            AV57GXV3 = (int)(AV57GXV3+1);
         }
         /*  Sending Event outputs  */
      }

      protected void E120P2( )
      {
         /* Gridpaginationbar_Changepage Routine */
         if ( ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Next") == 0 ) && ( AV47GAMUsersCount <= AV30UsersXPage ) )
         {
            AV38GridCurrentPage = (long)(AV38GridCurrentPage-1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridCurrentPage), 10, 0)));
         }
         if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Previous") == 0 )
         {
            AV38GridCurrentPage = (long)(AV38GridCurrentPage-1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridCurrentPage), 10, 0)));
            subgrid_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Next") == 0 )
         {
            AV38GridCurrentPage = (long)(AV38GridCurrentPage+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridCurrentPage), 10, 0)));
            subgrid_nextpage( ) ;
         }
         else
         {
            AV45PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            AV38GridCurrentPage = AV45PageToGo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridCurrentPage), 10, 0)));
            subgrid_gotopage( AV45PageToGo) ;
         }
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22Repository", AV22Repository);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34Filter", AV34Filter);
      }

      protected void E130P2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         AV38GridCurrentPage = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridCurrentPage), 10, 0)));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void S122( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV44IsAuthorized_BtnUpd;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamuserentry_Execute", out  GXt_boolean1) ;
         AV44IsAuthorized_BtnUpd = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44IsAuthorized_BtnUpd", AV44IsAuthorized_BtnUpd);
         if ( ! ( AV44IsAuthorized_BtnUpd ) )
         {
            edtavBtnupd_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnupd_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtnupd_Visible), 5, 0)), !bGXsfl_54_Refreshing);
         }
         GXt_boolean1 = AV41IsAuthorized_BtnDlt;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamuserentry_Execute", out  GXt_boolean1) ;
         AV41IsAuthorized_BtnDlt = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41IsAuthorized_BtnDlt", AV41IsAuthorized_BtnDlt);
         if ( ! ( AV41IsAuthorized_BtnDlt ) )
         {
            edtavBtndlt_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtndlt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtndlt_Visible), 5, 0)), !bGXsfl_54_Refreshing);
         }
         GXt_boolean1 = AV42IsAuthorized_BtnRole;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamwwuserroles_Execute", out  GXt_boolean1) ;
         AV42IsAuthorized_BtnRole = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42IsAuthorized_BtnRole", AV42IsAuthorized_BtnRole);
         if ( ! ( AV42IsAuthorized_BtnRole ) )
         {
            edtavBtnrole_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnrole_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtnrole_Visible), 5, 0)), !bGXsfl_54_Refreshing);
         }
         GXt_boolean1 = AV43IsAuthorized_BtnSetPwd;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamsetpassword_Execute", out  GXt_boolean1) ;
         AV43IsAuthorized_BtnSetPwd = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43IsAuthorized_BtnSetPwd", AV43IsAuthorized_BtnSetPwd);
         if ( ! ( AV43IsAuthorized_BtnSetPwd ) )
         {
            edtavBtnsetpwd_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBtnsetpwd_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBtnsetpwd_Visible), 5, 0)), !bGXsfl_54_Refreshing);
         }
         GXt_boolean1 = AV46TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secgamisauthbyfunctionalitykey(context ).execute(  "gamuserentry_Execute", out  GXt_boolean1) ;
         AV46TempBoolean = GXt_boolean1;
         if ( ! ( AV46TempBoolean ) )
         {
            bttBtnadd_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnadd_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnadd_Visible), 5, 0)), true);
         }
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         if ( ! ( ( cmbavFilauttype.ItemCount > 1 ) ) )
         {
            cmbavFilauttype.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavFilauttype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavFilauttype.Visible), 5, 0)), true);
            divFilauttype_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divFilauttype_cell_Internalname, "Class", divFilauttype_cell_Class, true);
         }
         else
         {
            cmbavFilauttype.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavFilauttype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavFilauttype.Visible), 5, 0)), true);
            divFilauttype_cell_Class = "col-xs-12 CellFormGroupMarginBottom5";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divFilauttype_cell_Internalname, "Class", divFilauttype_cell_Class, true);
         }
      }

      protected void wb_table2_48_0P2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablegridheader_Internalname, tblTablegridheader_Internalname, "", "Table100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='SectionGrid'>") ;
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"54\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+edtavBtnupd_Class+"\" "+" style=\""+((edtavBtnupd_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+edtavBtndlt_Class+"\" "+" style=\""+((edtavBtndlt_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavBtnrole_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( edtavBtnrole_Title) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+edtavBtnsetpwd_Class+"\" "+" style=\""+((edtavBtnsetpwd_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( edtavBtnsetpwd_Title) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+edtavName_Class+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+edtavFirstname_Class+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "First name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+edtavLastname_Class+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Last name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+edtavAuthenticationtypename_Class+"\" "+" style=\""+((edtavAuthenticationtypename_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Authentication") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridContainer.AddObjectProperty("GridName", "Grid");
            }
            else
            {
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV8BtnUpd));
               GridColumn.AddObjectProperty("Class", StringUtil.RTrim( edtavBtnupd_Class));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtnupd_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtnupd_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtnupd_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV31BtnDlt));
               GridColumn.AddObjectProperty("Class", StringUtil.RTrim( edtavBtndlt_Class));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtndlt_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtndlt_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtndlt_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV32BtnRole));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtavBtnrole_Title));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtnrole_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtnrole_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtnrole_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV33BtnSetPwd));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtavBtnsetpwd_Title));
               GridColumn.AddObjectProperty("Class", StringUtil.RTrim( edtavBtnsetpwd_Class));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavBtnsetpwd_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBtnsetpwd_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBtnsetpwd_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", AV21Name);
               GridColumn.AddObjectProperty("Class", StringUtil.RTrim( edtavName_Class));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavName_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavName_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV19FirstName));
               GridColumn.AddObjectProperty("Class", StringUtil.RTrim( edtavFirstname_Class));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavFirstname_Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV20LastName));
               GridColumn.AddObjectProperty("Class", StringUtil.RTrim( edtavLastname_Class));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavLastname_Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV6AuthenticationTypeName));
               GridColumn.AddObjectProperty("Class", StringUtil.RTrim( edtavAuthenticationtypename_Class));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavAuthenticationtypename_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavAuthenticationtypename_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV40GUID));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGuid_Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowselection), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectioncolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowhovering), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Hoveringcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowcollapsing), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 54 )
         {
            wbEnd = 0;
            nRC_GXsfl_54 = (short)(nGXsfl_54_idx-1);
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
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_54_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGridcurrentpage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV38GridCurrentPage), 10, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV38GridCurrentPage), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGridcurrentpage_Jsonclick, 0, "Attribute", "", "", "", "", edtavGridcurrentpage_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMWWUsers.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_48_0P2e( true) ;
         }
         else
         {
            wb_table2_48_0P2e( false) ;
         }
      }

      protected void wb_table1_27_0P2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablerightheader_Internalname, tblTablerightheader_Internalname, "", "Table100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablefilters_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellFormGroupMarginBottom5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSearch_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSearch_Internalname, "Search", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_54_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSearch_Internalname, AV25Search, StringUtil.RTrim( context.localUtil.Format( AV25Search, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Login / Name / Email", edtavSearch_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSearch_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 0, 0, true, "GAMUserIdentification", "left", true, "HLP_GAMWWUsers.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFilauttype_cell_Internalname, 1, 0, "px", 0, "px", divFilauttype_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", cmbavFilauttype.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavFilauttype_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavFilauttype_Internalname, "Authentication", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_54_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavFilauttype, cmbavFilauttype_Internalname, StringUtil.RTrim( AV13FilAutType), 1, cmbavFilauttype_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", cmbavFilauttype.Visible, cmbavFilauttype.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,40);\"", "", true, "HLP_GAMWWUsers.htm");
            cmbavFilauttype.CurrentValue = StringUtil.RTrim( AV13FilAutType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavFilauttype_Internalname, "Values", (String)(cmbavFilauttype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavFilrol_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavFilrol_Internalname, "Role", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_54_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavFilrol, cmbavFilrol_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV14FilRol), 12, 0)), 1, cmbavFilrol_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavFilrol.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,45);\"", "", true, "HLP_GAMWWUsers.htm");
            cmbavFilrol.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14FilRol), 12, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavFilrol_Internalname, "Values", (String)(cmbavFilrol.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_27_0P2e( true) ;
         }
         else
         {
            wb_table1_27_0P2e( false) ;
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
         PA0P2( ) ;
         WS0P2( ) ;
         WE0P2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019411649", true);
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
            context.AddJavascriptSource("gamwwusers.js", "?201892019411653", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
            context.AddJavascriptSource("", "", false);
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

      protected void SubsflControlProps_542( )
      {
         edtavBtnupd_Internalname = "vBTNUPD_"+sGXsfl_54_idx;
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_54_idx;
         edtavBtnrole_Internalname = "vBTNROLE_"+sGXsfl_54_idx;
         edtavBtnsetpwd_Internalname = "vBTNSETPWD_"+sGXsfl_54_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_54_idx;
         edtavFirstname_Internalname = "vFIRSTNAME_"+sGXsfl_54_idx;
         edtavLastname_Internalname = "vLASTNAME_"+sGXsfl_54_idx;
         edtavAuthenticationtypename_Internalname = "vAUTHENTICATIONTYPENAME_"+sGXsfl_54_idx;
         edtavGuid_Internalname = "vGUID_"+sGXsfl_54_idx;
      }

      protected void SubsflControlProps_fel_542( )
      {
         edtavBtnupd_Internalname = "vBTNUPD_"+sGXsfl_54_fel_idx;
         edtavBtndlt_Internalname = "vBTNDLT_"+sGXsfl_54_fel_idx;
         edtavBtnrole_Internalname = "vBTNROLE_"+sGXsfl_54_fel_idx;
         edtavBtnsetpwd_Internalname = "vBTNSETPWD_"+sGXsfl_54_fel_idx;
         edtavName_Internalname = "vNAME_"+sGXsfl_54_fel_idx;
         edtavFirstname_Internalname = "vFIRSTNAME_"+sGXsfl_54_fel_idx;
         edtavLastname_Internalname = "vLASTNAME_"+sGXsfl_54_fel_idx;
         edtavAuthenticationtypename_Internalname = "vAUTHENTICATIONTYPENAME_"+sGXsfl_54_fel_idx;
         edtavGuid_Internalname = "vGUID_"+sGXsfl_54_fel_idx;
      }

      protected void sendrow_542( )
      {
         SubsflControlProps_542( ) ;
         WB0P0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_54_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_54_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_54_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtnupd_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = edtavBtnupd_Class;
            StyleString = "";
            AV8BtnUpd_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV8BtnUpd))&&String.IsNullOrEmpty(StringUtil.RTrim( AV58Btnupd_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV8BtnUpd)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV8BtnUpd)) ? AV58Btnupd_GXI : context.PathToRelativeUrl( AV8BtnUpd));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtnupd_Internalname,(String)sImgUrl,(String)edtavBtnupd_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtnupd_Visible,(short)1,(String)"",(String)edtavBtnupd_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV8BtnUpd_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtndlt_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = edtavBtndlt_Class;
            StyleString = "";
            AV31BtnDlt_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV31BtnDlt))&&String.IsNullOrEmpty(StringUtil.RTrim( AV59Btndlt_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV31BtnDlt)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV31BtnDlt)) ? AV59Btndlt_GXI : context.PathToRelativeUrl( AV31BtnDlt));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtndlt_Internalname,(String)sImgUrl,(String)edtavBtndlt_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtndlt_Visible,(short)1,(String)"",(String)edtavBtndlt_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV31BtnDlt_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtnrole_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV32BtnRole_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV32BtnRole))&&String.IsNullOrEmpty(StringUtil.RTrim( AV60Btnrole_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV32BtnRole)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV32BtnRole)) ? AV60Btnrole_GXI : context.PathToRelativeUrl( AV32BtnRole));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtnrole_Internalname,(String)sImgUrl,(String)edtavBtnrole_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtnrole_Visible,(short)1,(String)"",(String)edtavBtnrole_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn hidden-xs",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV32BtnRole_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBtnsetpwd_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = edtavBtnsetpwd_Class;
            StyleString = "";
            AV33BtnSetPwd_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV33BtnSetPwd))&&String.IsNullOrEmpty(StringUtil.RTrim( AV61Btnsetpwd_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV33BtnSetPwd)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV33BtnSetPwd)) ? AV61Btnsetpwd_GXI : context.PathToRelativeUrl( AV33BtnSetPwd));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBtnsetpwd_Internalname,(String)sImgUrl,(String)edtavBtnsetpwd_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavBtnsetpwd_Visible,(short)1,(String)"",(String)edtavBtnsetpwd_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn hidden-xs",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV33BtnSetPwd_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = edtavName_Class;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavName_Internalname,(String)AV21Name,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavName_Link,(String)"",(String)"",(String)"",(String)edtavName_Jsonclick,(short)0,(String)edtavName_Class,(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavName_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)54,(short)1,(short)0,(short)0,(bool)true,(String)"GAMUserIdentification",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = edtavFirstname_Class;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavFirstname_Internalname,StringUtil.RTrim( AV19FirstName),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavFirstname_Jsonclick,(short)0,(String)edtavFirstname_Class,(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(int)edtavFirstname_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)54,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionShort",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = edtavLastname_Class;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavLastname_Internalname,StringUtil.RTrim( AV20LastName),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavLastname_Jsonclick,(short)0,(String)edtavLastname_Class,(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(int)edtavLastname_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)54,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMDescriptionShort",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtavAuthenticationtypename_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = edtavAuthenticationtypename_Class;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavAuthenticationtypename_Internalname,StringUtil.RTrim( AV6AuthenticationTypeName),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavAuthenticationtypename_Jsonclick,(short)0,(String)edtavAuthenticationtypename_Class,(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtavAuthenticationtypename_Visible,(int)edtavAuthenticationtypename_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)54,(short)1,(short)-1,(short)-1,(bool)true,(String)"GAMAuthenticationTypeName",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGuid_Internalname,StringUtil.RTrim( AV40GUID),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavGuid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavGuid_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)54,(short)1,(short)-1,(short)0,(bool)true,(String)"GAMGUID",(String)"left",(bool)true});
            send_integrity_lvl_hashes0P2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_54_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_54_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_54_idx+1));
            sGXsfl_54_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_54_idx), 4, 0)), 4, "0");
            SubsflControlProps_542( ) ;
         }
         /* End function sendrow_542 */
      }

      protected void init_default_properties( )
      {
         bttBtnadd_Internalname = "BTNADD";
         divTableactions_Internalname = "TABLEACTIONS";
         edtavSearch_Internalname = "vSEARCH";
         cmbavFilauttype_Internalname = "vFILAUTTYPE";
         divFilauttype_cell_Internalname = "FILAUTTYPE_CELL";
         cmbavFilrol_Internalname = "vFILROL";
         divTablefilters_Internalname = "TABLEFILTERS";
         tblTablerightheader_Internalname = "TABLERIGHTHEADER";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavBtnupd_Internalname = "vBTNUPD";
         edtavBtndlt_Internalname = "vBTNDLT";
         edtavBtnrole_Internalname = "vBTNROLE";
         edtavBtnsetpwd_Internalname = "vBTNSETPWD";
         edtavName_Internalname = "vNAME";
         edtavFirstname_Internalname = "vFIRSTNAME";
         edtavLastname_Internalname = "vLASTNAME";
         edtavAuthenticationtypename_Internalname = "vAUTHENTICATIONTYPENAME";
         edtavGuid_Internalname = "vGUID";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         edtavGridcurrentpage_Internalname = "vGRIDCURRENTPAGE";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         tblTablegridheader_Internalname = "TABLEGRIDHEADER";
         divTablemain_Internalname = "TABLEMAIN";
         edtavGamuserscount_Internalname = "vGAMUSERSCOUNT";
         edtavUsersxpage_Internalname = "vUSERSXPAGE";
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
         edtavGuid_Jsonclick = "";
         edtavAuthenticationtypename_Jsonclick = "";
         edtavLastname_Jsonclick = "";
         edtavFirstname_Jsonclick = "";
         edtavName_Jsonclick = "";
         cmbavFilrol_Jsonclick = "";
         cmbavFilrol.Enabled = 1;
         cmbavFilauttype_Jsonclick = "";
         cmbavFilauttype.Enabled = 1;
         edtavSearch_Jsonclick = "";
         edtavSearch_Enabled = 1;
         edtavGridcurrentpage_Jsonclick = "";
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavName_Link = "";
         edtavBtnsetpwd_Tooltiptext = "Set new password";
         edtavBtnsetpwd_Link = "";
         edtavBtnrole_Tooltiptext = "Roles";
         edtavBtnrole_Link = "";
         edtavBtndlt_Tooltiptext = "Delete";
         edtavBtndlt_Link = "";
         edtavBtnupd_Tooltiptext = "Update";
         edtavBtnupd_Link = "";
         edtavGuid_Enabled = 0;
         edtavAuthenticationtypename_Enabled = 0;
         edtavAuthenticationtypename_Class = "Attribute";
         edtavLastname_Enabled = 0;
         edtavLastname_Class = "Attribute";
         edtavFirstname_Enabled = 0;
         edtavFirstname_Class = "Attribute";
         edtavName_Enabled = 0;
         edtavName_Class = "Attribute";
         edtavBtnsetpwd_Class = "ActionBaseColorAttribute";
         edtavBtndlt_Class = "DeleteAttribute";
         edtavBtnupd_Class = "ActionBaseColorAttribute";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divFilauttype_cell_Class = "col-xs-12";
         cmbavFilauttype.Visible = 1;
         edtavBtnsetpwd_Visible = -1;
         edtavBtnrole_Visible = -1;
         edtavBtndlt_Visible = -1;
         edtavBtnupd_Visible = -1;
         edtavAuthenticationtypename_Visible = -1;
         edtavGridcurrentpage_Visible = 1;
         edtavUsersxpage_Jsonclick = "";
         edtavUsersxpage_Visible = 1;
         edtavGamuserscount_Jsonclick = "";
         edtavGamuserscount_Visible = 1;
         bttBtnadd_Visible = 1;
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
         Form.Caption = "Users ";
         subGrid_Rows = 0;
         edtavBtnsetpwd_Title = "";
         edtavBtnrole_Title = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'edtavBtnrole_Title',ctrl:'vBTNROLE',prop:'Title'},{av:'edtavBtnsetpwd_Title',ctrl:'vBTNSETPWD',prop:'Title'},{av:'AV9CountUsers',fld:'vCOUNTUSERS',pic:'ZZZ9',nv:0},{av:'AV44IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV41IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV36GAMUserIsDeleted',fld:'vGAMUSERISDELETED',pic:'',nv:false},{av:'AV42IsAuthorized_BtnRole',fld:'vISAUTHORIZED_BTNROLE',pic:'',nv:false},{av:'AV43IsAuthorized_BtnSetPwd',fld:'vISAUTHORIZED_BTNSETPWD',pic:'',nv:false},{av:'AV35GAMUserIsAutoRegisteredUser',fld:'vGAMUSERISAUTOREGISTEREDUSER',pic:'',nv:false},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'cmbavFilauttype'},{av:'AV13FilAutType',fld:'vFILAUTTYPE',pic:'',nv:''},{av:'AV30UsersXPage',fld:'vUSERSXPAGE',pic:'ZZZ9',nv:0},{av:'AV25Search',fld:'vSEARCH',pic:'',nv:''},{av:'cmbavFilrol'},{av:'AV14FilRol',fld:'vFILROL',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV48IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false}],oparms:[{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV47GAMUsersCount',fld:'vGAMUSERSCOUNT',pic:'ZZZ9',nv:0},{av:'edtavAuthenticationtypename_Visible',ctrl:'vAUTHENTICATIONTYPENAME',prop:'Visible'},{av:'AV44IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'edtavBtnupd_Visible',ctrl:'vBTNUPD',prop:'Visible'},{av:'AV41IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'edtavBtndlt_Visible',ctrl:'vBTNDLT',prop:'Visible'},{av:'AV42IsAuthorized_BtnRole',fld:'vISAUTHORIZED_BTNROLE',pic:'',nv:false},{av:'edtavBtnrole_Visible',ctrl:'vBTNROLE',prop:'Visible'},{av:'AV43IsAuthorized_BtnSetPwd',fld:'vISAUTHORIZED_BTNSETPWD',pic:'',nv:false},{av:'edtavBtnsetpwd_Visible',ctrl:'vBTNSETPWD',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E160P2',iparms:[{av:'AV9CountUsers',fld:'vCOUNTUSERS',pic:'ZZZ9',nv:0},{av:'AV44IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV41IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV36GAMUserIsDeleted',fld:'vGAMUSERISDELETED',pic:'',nv:false},{av:'AV42IsAuthorized_BtnRole',fld:'vISAUTHORIZED_BTNROLE',pic:'',nv:false},{av:'AV43IsAuthorized_BtnSetPwd',fld:'vISAUTHORIZED_BTNSETPWD',pic:'',nv:false},{av:'AV35GAMUserIsAutoRegisteredUser',fld:'vGAMUSERISAUTOREGISTEREDUSER',pic:'',nv:false},{av:'AV48IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false}],oparms:[{av:'AV9CountUsers',fld:'vCOUNTUSERS',pic:'ZZZ9',nv:0},{av:'AV6AuthenticationTypeName',fld:'vAUTHENTICATIONTYPENAME',pic:'',nv:''},{av:'AV40GUID',fld:'vGUID',pic:'',nv:''},{av:'AV21Name',fld:'vNAME',pic:'',nv:''},{av:'AV19FirstName',fld:'vFIRSTNAME',pic:'',nv:''},{av:'AV20LastName',fld:'vLASTNAME',pic:'',nv:''},{av:'edtavName_Class',ctrl:'vNAME',prop:'Class'},{av:'edtavFirstname_Class',ctrl:'vFIRSTNAME',prop:'Class'},{av:'edtavLastname_Class',ctrl:'vLASTNAME',prop:'Class'},{av:'edtavAuthenticationtypename_Class',ctrl:'vAUTHENTICATIONTYPENAME',prop:'Class'},{av:'AV8BtnUpd',fld:'vBTNUPD',pic:'',nv:''},{av:'edtavBtnupd_Tooltiptext',ctrl:'vBTNUPD',prop:'Tooltiptext'},{av:'edtavBtnupd_Link',ctrl:'vBTNUPD',prop:'Link'},{av:'edtavBtnupd_Class',ctrl:'vBTNUPD',prop:'Class'},{av:'AV31BtnDlt',fld:'vBTNDLT',pic:'',nv:''},{av:'edtavBtndlt_Tooltiptext',ctrl:'vBTNDLT',prop:'Tooltiptext'},{av:'edtavBtndlt_Link',ctrl:'vBTNDLT',prop:'Link'},{av:'edtavBtndlt_Class',ctrl:'vBTNDLT',prop:'Class'},{av:'AV32BtnRole',fld:'vBTNROLE',pic:'',nv:''},{av:'edtavBtnrole_Tooltiptext',ctrl:'vBTNROLE',prop:'Tooltiptext'},{av:'edtavBtnrole_Link',ctrl:'vBTNROLE',prop:'Link'},{av:'AV33BtnSetPwd',fld:'vBTNSETPWD',pic:'',nv:''},{av:'edtavBtnsetpwd_Tooltiptext',ctrl:'vBTNSETPWD',prop:'Tooltiptext'},{av:'edtavBtnsetpwd_Link',ctrl:'vBTNSETPWD',prop:'Link'},{av:'edtavBtnsetpwd_Class',ctrl:'vBTNSETPWD',prop:'Class'},{av:'edtavName_Link',ctrl:'vNAME',prop:'Link'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E120P2',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'cmbavFilauttype'},{av:'AV13FilAutType',fld:'vFILAUTTYPE',pic:'',nv:''},{av:'AV30UsersXPage',fld:'vUSERSXPAGE',pic:'ZZZ9',nv:0},{av:'AV25Search',fld:'vSEARCH',pic:'',nv:''},{av:'cmbavFilrol'},{av:'AV14FilRol',fld:'vFILROL',pic:'ZZZZZZZZZZZ9',nv:0},{av:'edtavBtnrole_Title',ctrl:'vBTNROLE',prop:'Title'},{av:'edtavBtnsetpwd_Title',ctrl:'vBTNSETPWD',prop:'Title'},{av:'AV9CountUsers',fld:'vCOUNTUSERS',pic:'ZZZ9',nv:0},{av:'AV44IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV41IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV36GAMUserIsDeleted',fld:'vGAMUSERISDELETED',pic:'',nv:false},{av:'AV42IsAuthorized_BtnRole',fld:'vISAUTHORIZED_BTNROLE',pic:'',nv:false},{av:'AV43IsAuthorized_BtnSetPwd',fld:'vISAUTHORIZED_BTNSETPWD',pic:'',nv:false},{av:'AV35GAMUserIsAutoRegisteredUser',fld:'vGAMUSERISAUTOREGISTEREDUSER',pic:'',nv:false},{av:'AV48IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'},{av:'AV47GAMUsersCount',fld:'vGAMUSERSCOUNT',pic:'ZZZ9',nv:0}],oparms:[{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'AV47GAMUsersCount',fld:'vGAMUSERSCOUNT',pic:'ZZZ9',nv:0},{av:'edtavAuthenticationtypename_Visible',ctrl:'vAUTHENTICATIONTYPENAME',prop:'Visible'},{av:'AV44IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'edtavBtnupd_Visible',ctrl:'vBTNUPD',prop:'Visible'},{av:'AV41IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'edtavBtndlt_Visible',ctrl:'vBTNDLT',prop:'Visible'},{av:'AV42IsAuthorized_BtnRole',fld:'vISAUTHORIZED_BTNROLE',pic:'',nv:false},{av:'edtavBtnrole_Visible',ctrl:'vBTNROLE',prop:'Visible'},{av:'AV43IsAuthorized_BtnSetPwd',fld:'vISAUTHORIZED_BTNSETPWD',pic:'',nv:false},{av:'edtavBtnsetpwd_Visible',ctrl:'vBTNSETPWD',prop:'Visible'},{ctrl:'BTNADD',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E130P2',iparms:[{av:'GRID_nFirstRecordOnPage',nv:0},{av:'GRID_nEOF',nv:0},{av:'subGrid_Rows',nv:0},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0},{av:'cmbavFilauttype'},{av:'AV13FilAutType',fld:'vFILAUTTYPE',pic:'',nv:''},{av:'AV30UsersXPage',fld:'vUSERSXPAGE',pic:'ZZZ9',nv:0},{av:'AV25Search',fld:'vSEARCH',pic:'',nv:''},{av:'cmbavFilrol'},{av:'AV14FilRol',fld:'vFILROL',pic:'ZZZZZZZZZZZ9',nv:0},{av:'edtavBtnrole_Title',ctrl:'vBTNROLE',prop:'Title'},{av:'edtavBtnsetpwd_Title',ctrl:'vBTNSETPWD',prop:'Title'},{av:'AV9CountUsers',fld:'vCOUNTUSERS',pic:'ZZZ9',nv:0},{av:'AV44IsAuthorized_BtnUpd',fld:'vISAUTHORIZED_BTNUPD',pic:'',nv:false},{av:'AV41IsAuthorized_BtnDlt',fld:'vISAUTHORIZED_BTNDLT',pic:'',nv:false},{av:'AV36GAMUserIsDeleted',fld:'vGAMUSERISDELETED',pic:'',nv:false},{av:'AV42IsAuthorized_BtnRole',fld:'vISAUTHORIZED_BTNROLE',pic:'',nv:false},{av:'AV43IsAuthorized_BtnSetPwd',fld:'vISAUTHORIZED_BTNSETPWD',pic:'',nv:false},{av:'AV35GAMUserIsAutoRegisteredUser',fld:'vGAMUSERISAUTOREGISTEREDUSER',pic:'',nv:false},{av:'AV48IsAuthorized_Name',fld:'vISAUTHORIZED_NAME',pic:'',hsh:true,nv:false},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("'DOADD'","{handler:'E110P1',iparms:[],oparms:[]}");
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
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV13FilAutType = "";
         AV25Search = "";
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
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8BtnUpd = "";
         AV58Btnupd_GXI = "";
         AV31BtnDlt = "";
         AV59Btndlt_GXI = "";
         AV32BtnRole = "";
         AV60Btnrole_GXI = "";
         AV33BtnSetPwd = "";
         AV61Btnsetpwd_GXI = "";
         AV21Name = "";
         AV19FirstName = "";
         AV20LastName = "";
         AV6AuthenticationTypeName = "";
         AV40GUID = "";
         GridContainer = new GXWebGrid( context);
         AV7AuthenticationTypes = new GXExternalCollection<SdtGAMAuthenticationType>( context, "SdtGAMAuthenticationType", "GeneXus.Programs");
         AV16FilterAutType = new SdtGAMAuthenticationTypeFilter(context);
         AV12Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV5AuthenticationType = new SdtGAMAuthenticationType(context);
         AV24Roles = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         AV17FilterRoles = new SdtGAMRoleFilter(context);
         AV22Repository = new SdtGAMRepository(context);
         AV23Role = new SdtGAMRole(context);
         AV34Filter = new SdtGAMUserFilter(context);
         AV37GAMUsers = new GXExternalCollection<SdtGAMUser>( context, "SdtGAMUser", "GeneXus.Programs");
         AV27User = new SdtGAMUser(context);
         GridRow = new GXWebRow();
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavName_Enabled = 0;
         edtavFirstname_Enabled = 0;
         edtavLastname_Enabled = 0;
         edtavAuthenticationtypename_Enabled = 0;
         edtavGuid_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_54 ;
      private short nGXsfl_54_idx=1 ;
      private short GRID_nEOF ;
      private short AV30UsersXPage ;
      private short AV9CountUsers ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short AV47GAMUsersCount ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short subGrid_Backstyle ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Pagestoshow ;
      private int bttBtnadd_Visible ;
      private int edtavGamuserscount_Visible ;
      private int edtavUsersxpage_Visible ;
      private int subGrid_Islastpage ;
      private int edtavName_Enabled ;
      private int edtavFirstname_Enabled ;
      private int edtavLastname_Enabled ;
      private int edtavAuthenticationtypename_Enabled ;
      private int edtavGuid_Enabled ;
      private int GRID_nGridOutOfScope ;
      private int edtavGridcurrentpage_Visible ;
      private int AV55GXV1 ;
      private int AV56GXV2 ;
      private int edtavAuthenticationtypename_Visible ;
      private int AV57GXV3 ;
      private int AV45PageToGo ;
      private int edtavBtnupd_Visible ;
      private int edtavBtndlt_Visible ;
      private int edtavBtnrole_Visible ;
      private int edtavBtnsetpwd_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavSearch_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV38GridCurrentPage ;
      private long AV14FilRol ;
      private long AV39GridPageCount ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String edtavBtnrole_Title ;
      private String edtavBtnsetpwd_Title ;
      private String Gridpaginationbar_Selectedpage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_54_idx="0001" ;
      private String edtavBtnrole_Internalname ;
      private String edtavBtnsetpwd_Internalname ;
      private String AV13FilAutType ;
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
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavGamuserscount_Internalname ;
      private String edtavGamuserscount_Jsonclick ;
      private String edtavUsersxpage_Internalname ;
      private String edtavUsersxpage_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavBtnupd_Internalname ;
      private String edtavBtndlt_Internalname ;
      private String edtavName_Internalname ;
      private String AV19FirstName ;
      private String edtavFirstname_Internalname ;
      private String AV20LastName ;
      private String edtavLastname_Internalname ;
      private String AV6AuthenticationTypeName ;
      private String edtavAuthenticationtypename_Internalname ;
      private String AV40GUID ;
      private String edtavGuid_Internalname ;
      private String edtavSearch_Internalname ;
      private String cmbavFilauttype_Internalname ;
      private String cmbavFilrol_Internalname ;
      private String edtavGridcurrentpage_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String edtavName_Class ;
      private String edtavFirstname_Class ;
      private String edtavLastname_Class ;
      private String edtavAuthenticationtypename_Class ;
      private String edtavBtnupd_Tooltiptext ;
      private String edtavBtnupd_Link ;
      private String edtavBtnupd_Class ;
      private String edtavBtndlt_Tooltiptext ;
      private String edtavBtndlt_Link ;
      private String edtavBtndlt_Class ;
      private String edtavBtnrole_Tooltiptext ;
      private String edtavBtnrole_Link ;
      private String edtavBtnsetpwd_Tooltiptext ;
      private String edtavBtnsetpwd_Link ;
      private String edtavBtnsetpwd_Class ;
      private String edtavName_Link ;
      private String divFilauttype_cell_Class ;
      private String divFilauttype_cell_Internalname ;
      private String sStyleString ;
      private String tblTablegridheader_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String edtavGridcurrentpage_Jsonclick ;
      private String tblTablerightheader_Internalname ;
      private String divTablefilters_Internalname ;
      private String edtavSearch_Jsonclick ;
      private String cmbavFilauttype_Jsonclick ;
      private String cmbavFilrol_Jsonclick ;
      private String sGXsfl_54_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtavName_Jsonclick ;
      private String edtavFirstname_Jsonclick ;
      private String edtavLastname_Jsonclick ;
      private String edtavAuthenticationtypename_Jsonclick ;
      private String edtavGuid_Jsonclick ;
      private String Dvpanel_tableheader_Internalname ;
      private bool entryPointCalled ;
      private bool bGXsfl_54_Refreshing=false ;
      private bool AV44IsAuthorized_BtnUpd ;
      private bool AV41IsAuthorized_BtnDlt ;
      private bool AV36GAMUserIsDeleted ;
      private bool AV42IsAuthorized_BtnRole ;
      private bool AV43IsAuthorized_BtnSetPwd ;
      private bool AV35GAMUserIsAutoRegisteredUser ;
      private bool AV48IsAuthorized_Name ;
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
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV46TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV8BtnUpd_IsBlob ;
      private bool AV31BtnDlt_IsBlob ;
      private bool AV32BtnRole_IsBlob ;
      private bool AV33BtnSetPwd_IsBlob ;
      private String AV25Search ;
      private String AV58Btnupd_GXI ;
      private String AV59Btndlt_GXI ;
      private String AV60Btnrole_GXI ;
      private String AV61Btnsetpwd_GXI ;
      private String AV21Name ;
      private String AV8BtnUpd ;
      private String AV31BtnDlt ;
      private String AV32BtnRole ;
      private String AV33BtnSetPwd ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private SdtGAMRepository AV22Repository ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavFilauttype ;
      private GXCombobox cmbavFilrol ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMAuthenticationType> AV7AuthenticationTypes ;
      private GXExternalCollection<SdtGAMError> AV12Errors ;
      private GXExternalCollection<SdtGAMUser> AV37GAMUsers ;
      private GXExternalCollection<SdtGAMRole> AV24Roles ;
      private GXWebForm Form ;
      private SdtGAMAuthenticationType AV5AuthenticationType ;
      private SdtGAMUserFilter AV34Filter ;
      private SdtGAMAuthenticationTypeFilter AV16FilterAutType ;
      private SdtGAMUser AV27User ;
      private SdtGAMRole AV23Role ;
      private SdtGAMRoleFilter AV17FilterRoles ;
   }

}
