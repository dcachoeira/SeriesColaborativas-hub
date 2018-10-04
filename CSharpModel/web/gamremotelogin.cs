/*
               File: GAMRemoteLogin
        Description: Remote Login
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:45:9.33
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
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gamremotelogin : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public gamremotelogin( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamremotelogin( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ApplicationClientId )
      {
         this.AV6ApplicationClientId = aP0_ApplicationClientId;
         executePrivate();
         aP0_ApplicationClientId=this.AV6ApplicationClientId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavLogonto = new GXCombobox();
         chkavKeepmeloggedin = new GXCheckbox();
         chkavRememberme = new GXCheckbox();
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
               AV6ApplicationClientId = gxfirstwebparm;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ApplicationClientId", AV6ApplicationClientId);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONCLIENTID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV6ApplicationClientId, "")), context));
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
            ValidateSpaRequest();
            PA1M2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               edtavCmpname_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavCmpname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavCmpname_Enabled), 5, 0)), true);
               WS1M2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE1M2( ) ;
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( "Remote Login ") ;
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
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 121631), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxcfg.js", "?20189201945966", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( 0) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamremotelogin.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6ApplicationClientId))+"\">") ;
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
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "vAPPLICATIONCLIENTID", StringUtil.RTrim( AV6ApplicationClientId));
         GxWebStd.gx_hidden_field( context, "gxhash_vAPPLICATIONCLIENTID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV6ApplicationClientId, "")), context));
         GxWebStd.gx_hidden_field( context, "vLANGUAGE", StringUtil.RTrim( AV17Language));
         GxWebStd.gx_hidden_field( context, "vUSERREMEMBERME", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28UserRememberMe), 2, 0, ",", "")));
      }

      protected void RenderHtmlCloseForm1M2( )
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
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "GAMRemoteLogin" ;
      }

      public override String GetPgmdesc( )
      {
         return "Remote Login " ;
      }

      protected void WB1M0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginLogin", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "e9edf59f-db45-4e16-b6a6-2c2b6611a4a3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgHeaderoriginal_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMRemoteLogin.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablelogin_Internalname, 1, 0, "px", 0, "px", "TableLogin", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblSignin_Internalname, "IDENTITY PROVIDER", "", "", lblSignin_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlockTitleLogin", 0, "", 1, 1, 0, "HLP_GAMRemoteLogin.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            wb_table1_21_1M2( true) ;
         }
         else
         {
            wb_table1_21_1M2( false) ;
         }
         return  ;
      }

      protected void wb_table1_21_1M2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableloginerror_Internalname, divTableloginerror_Visible, 0, "px", 0, "px", "TableLoginError", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1M2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Remote Login ", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1M0( ) ;
      }

      protected void WS1M2( )
      {
         START1M2( ) ;
         EVT1M2( ) ;
      }

      protected void EVT1M2( )
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
                        else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E111M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( ! wbErr )
                           {
                              Rfr0gs = false;
                              if ( ! Rfr0gs )
                              {
                                 /* Execute user event: Enter */
                                 E121M2 ();
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Refresh */
                           E131M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E141M2 ();
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
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WE1M2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1M2( ) ;
            }
         }
      }

      protected void PA1M2( )
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
            cmbavLogonto.Name = "vLOGONTO";
            cmbavLogonto.WebTags = "";
            if ( cmbavLogonto.ItemCount > 0 )
            {
               AV20LogOnTo = cmbavLogonto.getValidValue(AV20LogOnTo);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20LogOnTo", AV20LogOnTo);
            }
            chkavKeepmeloggedin.Name = "vKEEPMELOGGEDIN";
            chkavKeepmeloggedin.WebTags = "";
            chkavKeepmeloggedin.Caption = " Keep me logged in";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavKeepmeloggedin_Internalname, "TitleCaption", chkavKeepmeloggedin.Caption, true);
            chkavKeepmeloggedin.CheckedValue = "false";
            chkavRememberme.Name = "vREMEMBERME";
            chkavRememberme.WebTags = "";
            chkavRememberme.Caption = " Remember me";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRememberme_Internalname, "TitleCaption", chkavRememberme.Caption, true);
            chkavRememberme.CheckedValue = "false";
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavCmpname_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void fix_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
         }
         if ( cmbavLogonto.ItemCount > 0 )
         {
            AV20LogOnTo = cmbavLogonto.getValidValue(AV20LogOnTo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20LogOnTo", AV20LogOnTo);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavLogonto.CurrentValue = StringUtil.RTrim( AV20LogOnTo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavLogonto_Internalname, "Values", cmbavLogonto.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1M2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavCmpname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavCmpname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavCmpname_Enabled), 5, 0)), true);
      }

      protected void RF1M2( )
      {
         initialize_formulas( ) ;
         /* Execute user event: Refresh */
         E131M2 ();
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E141M2 ();
            WB1M0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1M2( )
      {
         GxWebStd.gx_hidden_field( context, "vAPPLICATIONCLIENTID", StringUtil.RTrim( AV6ApplicationClientId));
         GxWebStd.gx_hidden_field( context, "gxhash_vAPPLICATIONCLIENTID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV6ApplicationClientId, "")), context));
      }

      protected void STRUP1M0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavCmpname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavCmpname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavCmpname_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E111M2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV19LogoAppClient = cgiGet( imgavLogoappclient_Internalname);
            AV29CmpName = cgiGet( edtavCmpname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29CmpName", AV29CmpName);
            cmbavLogonto.CurrentValue = cgiGet( cmbavLogonto_Internalname);
            AV20LogOnTo = cgiGet( cmbavLogonto_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20LogOnTo", AV20LogOnTo);
            AV26UserName = cgiGet( edtavUsername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26UserName", AV26UserName);
            AV27UserPassword = cgiGet( edtavUserpassword_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27UserPassword", AV27UserPassword);
            AV16KeepMeLoggedIn = StringUtil.StrToBool( cgiGet( chkavKeepmeloggedin_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16KeepMeLoggedIn", AV16KeepMeLoggedIn);
            AV21RememberMe = StringUtil.StrToBool( cgiGet( chkavRememberme_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21RememberMe", AV21RememberMe);
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E111M2 ();
         if (returnInSub) return;
      }

      protected void E111M2( )
      {
         /* Start Routine */
         Form.Backcolor = GXUtil.RGB( 238, 238, 238);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(Form.Backcolor), 9, 0)), true);
         AV15isOK = new SdtGAM(context).checkconnection();
         if ( ! AV15isOK )
         {
            AV9ConnectionInfoCollection = new SdtGAM(context).getconnections();
            if ( AV9ConnectionInfoCollection.Count > 0 )
            {
               AV15isOK = new SdtGAM(context).setconnection(((SdtGAMConnectionInfo)AV9ConnectionInfoCollection.Item(1)).gxTpr_Name, out  AV11Errors);
            }
         }
         if ( new SdtGAMRepository(context).isremoteauthentication(AV6ApplicationClientId) )
         {
            AV13GAMApplication = new SdtGAMRepository(context).getremoteapplication(out  AV11Errors);
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV13GAMApplication.gxTpr_Clientimageurl)) )
            {
               AV29CmpName = AV13GAMApplication.gxTpr_Name;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29CmpName", AV29CmpName);
            }
         }
         else
         {
            GX_msglist.addItem(StringUtil.Format( "Application Client ID not found (%1) ", AV6ApplicationClientId, "", "", "", "", "", "", "", ""));
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
         divTableloginerror_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTableloginerror_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTableloginerror_Visible), 5, 0)), true);
         lblForgotpassword_Link = formatLink("gamrecoverpasswordstep1.aspx") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblForgotpassword_Internalname, "Link", lblForgotpassword_Link, true);
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E121M2 ();
         if (returnInSub) return;
      }

      protected void E121M2( )
      {
         /* Enter Routine */
         if ( AV16KeepMeLoggedIn )
         {
            AV5AdditionalParameter.gxTpr_Rememberusertype = (short)((AV16KeepMeLoggedIn ? 3 : 1));
         }
         else
         {
            if ( AV21RememberMe )
            {
               AV5AdditionalParameter.gxTpr_Rememberusertype = (short)((AV21RememberMe ? 2 : 1));
            }
            else
            {
               AV5AdditionalParameter.gxTpr_Rememberusertype = 1;
            }
         }
         AV5AdditionalParameter.gxTpr_Authenticationtypename = AV20LogOnTo;
         AV18LoginOK = new SdtGAMRepository(context).login(AV26UserName, AV27UserPassword, AV5AdditionalParameter, out  AV11Errors);
         if ( AV18LoginOK )
         {
         }
         else
         {
            if ( AV11Errors.Count > 0 )
            {
               if ( ( ((SdtGAMError)AV11Errors.Item(1)).gxTpr_Code == 24 ) || ( ((SdtGAMError)AV11Errors.Item(1)).gxTpr_Code == 23 ) )
               {
                  CallWebObject(formatLink("gamchangepassword.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6ApplicationClientId)));
                  context.wjLocDisableFrm = 1;
               }
               else if ( ((SdtGAMError)AV11Errors.Item(1)).gxTpr_Code == 161 )
               {
                  CallWebObject(formatLink("gamupdateregisteruser.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6ApplicationClientId)));
                  context.wjLocDisableFrm = 1;
               }
               else
               {
                  AV27UserPassword = "";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27UserPassword", AV27UserPassword);
                  /* Execute user subroutine: 'DISPLAYMESSAGES' */
                  S122 ();
                  if (returnInSub) return;
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5AdditionalParameter", AV5AdditionalParameter);
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         if ( ! ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13GAMApplication.gxTpr_Clientimageurl)) ) )
         {
            imgavLogoappclient_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgavLogoappclient_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgavLogoappclient_Visible), 5, 0)), true);
            cellLogoappclient_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellLogoappclient_cell_Internalname, "Class", cellLogoappclient_cell_Class, true);
         }
         else
         {
            imgavLogoappclient_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgavLogoappclient_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgavLogoappclient_Visible), 5, 0)), true);
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( AV13GAMApplication.gxTpr_Clientimageurl)) ) )
         {
            edtavCmpname_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavCmpname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavCmpname_Visible), 5, 0)), true);
            cellCmpname_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellCmpname_cell_Internalname, "Class", cellCmpname_cell_Class, true);
         }
         else
         {
            edtavCmpname_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavCmpname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavCmpname_Visible), 5, 0)), true);
         }
         if ( ! ( ( cmbavLogonto.ItemCount > 1 ) ) )
         {
            cmbavLogonto.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavLogonto_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavLogonto.Visible), 5, 0)), true);
            cellLogonto_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellLogonto_cell_Internalname, "Class", cellLogonto_cell_Class, true);
         }
         else
         {
            cmbavLogonto.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavLogonto_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavLogonto.Visible), 5, 0)), true);
            cellLogonto_cell_Class = "DataContentCellLogin CellPaddingLogin";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellLogonto_cell_Internalname, "Class", cellLogonto_cell_Class, true);
         }
         if ( ! ( ( 1 == 1 ) ) )
         {
            chkavKeepmeloggedin.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavKeepmeloggedin_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavKeepmeloggedin.Visible), 5, 0)), true);
            cellKeepmeloggedin_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellKeepmeloggedin_cell_Internalname, "Class", cellKeepmeloggedin_cell_Class, true);
         }
         else
         {
            chkavKeepmeloggedin.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavKeepmeloggedin_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavKeepmeloggedin.Visible), 5, 0)), true);
            cellKeepmeloggedin_cell_Class = "DataContentCellLogin";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellKeepmeloggedin_cell_Internalname, "Class", cellKeepmeloggedin_cell_Class, true);
         }
         if ( ! ( ( 1 == 1 ) ) )
         {
            chkavRememberme.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRememberme_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavRememberme.Visible), 5, 0)), true);
            cellRememberme_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellRememberme_cell_Internalname, "Class", cellRememberme_cell_Class, true);
         }
         else
         {
            chkavRememberme.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRememberme_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavRememberme.Visible), 5, 0)), true);
            cellRememberme_cell_Class = "DataContentCellLogin";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellRememberme_cell_Internalname, "Class", cellRememberme_cell_Class, true);
         }
      }

      protected void E131M2( )
      {
         /* Refresh Routine */
         AV14hasError = false;
         AV12ErrorsLogin = new SdtGAMRepository(context).getlasterrors();
         if ( AV12ErrorsLogin.Count > 0 )
         {
            AV14hasError = true;
            if ( ( ((SdtGAMError)AV12ErrorsLogin.Item(1)).gxTpr_Code == 24 ) || ( ((SdtGAMError)AV12ErrorsLogin.Item(1)).gxTpr_Code == 23 ) )
            {
               CallWebObject(formatLink("gamchangepassword.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6ApplicationClientId)));
               context.wjLocDisableFrm = 1;
            }
            else if ( ((SdtGAMError)AV12ErrorsLogin.Item(1)).gxTpr_Code == 161 )
            {
               CallWebObject(formatLink("gamupdateregisteruser.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6ApplicationClientId)));
               context.wjLocDisableFrm = 1;
            }
            else
            {
               AV27UserPassword = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27UserPassword", AV27UserPassword);
               AV11Errors = AV12ErrorsLogin;
               /* Execute user subroutine: 'DISPLAYMESSAGES' */
               S122 ();
               if (returnInSub) return;
            }
         }
         if ( ! AV14hasError )
         {
            AV24SessionValid = new SdtGAMSession(context).isvalid(out  AV23Session, out  AV11Errors);
            if ( AV24SessionValid && ! AV23Session.gxTpr_Isanonymous )
            {
               if ( new SdtGAMRepository(context).isremoteauthentication(AV6ApplicationClientId) )
               {
                  new SdtGAMRepository(context).redirecttoremoteauthentication() ;
               }
               else
               {
                  AV25URL = new SdtGAMRepository(context).getlasterrorsurl();
                  if ( String.IsNullOrEmpty(StringUtil.RTrim( AV25URL)) )
                  {
                     new SdtGAMApplication(context).gohome() ;
                  }
                  else
                  {
                     CallWebObject(formatLink(AV25URL) );
                     context.wjLocDisableFrm = 0;
                  }
               }
            }
            else
            {
               cmbavLogonto.removeAllItems();
               AV8AuthenticationTypes = new SdtGAMRepository(context).getenabledauthenticationtypes(AV17Language, out  AV11Errors);
               AV34GXV1 = 1;
               while ( AV34GXV1 <= AV8AuthenticationTypes.Count )
               {
                  AV7AuthenticationType = ((SdtGAMAuthenticationTypeSimple)AV8AuthenticationTypes.Item(AV34GXV1));
                  if ( AV7AuthenticationType.gxTpr_Needusername )
                  {
                     cmbavLogonto.addItem(AV7AuthenticationType.gxTpr_Name, AV7AuthenticationType.gxTpr_Description, 0);
                  }
                  AV34GXV1 = (int)(AV34GXV1+1);
               }
               if ( cmbavLogonto.ItemCount <= 1 )
               {
                  cmbavLogonto.Visible = 0;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavLogonto_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavLogonto.Visible), 5, 0)), true);
               }
               AV15isOK = new SdtGAMRepository(context).getrememberlogin(out  AV20LogOnTo, out  AV26UserName, out  AV28UserRememberMe, out  AV11Errors);
               if ( AV28UserRememberMe == 2 )
               {
                  AV21RememberMe = true;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21RememberMe", AV21RememberMe);
               }
               AV22Repository = new SdtGAMRepository(context).get();
               if ( cmbavLogonto.ItemCount > 1 )
               {
                  AV20LogOnTo = AV22Repository.gxTpr_Defaultauthenticationtypename;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20LogOnTo", AV20LogOnTo);
               }
               chkavRememberme.Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRememberme_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavRememberme.Visible), 5, 0)), true);
               chkavKeepmeloggedin.Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavKeepmeloggedin_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavKeepmeloggedin.Visible), 5, 0)), true);
               if ( StringUtil.StrCmp(AV22Repository.gxTpr_Userremembermetype, "Login") == 0 )
               {
                  chkavRememberme.Visible = 1;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRememberme_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavRememberme.Visible), 5, 0)), true);
               }
               else if ( StringUtil.StrCmp(AV22Repository.gxTpr_Userremembermetype, "Auth") == 0 )
               {
                  chkavKeepmeloggedin.Visible = 1;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavKeepmeloggedin_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavKeepmeloggedin.Visible), 5, 0)), true);
               }
               else if ( StringUtil.StrCmp(AV22Repository.gxTpr_Userremembermetype, "Both") == 0 )
               {
                  chkavRememberme.Visible = 1;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRememberme_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavRememberme.Visible), 5, 0)), true);
                  chkavKeepmeloggedin.Visible = 1;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavKeepmeloggedin_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavKeepmeloggedin.Visible), 5, 0)), true);
               }
            }
         }
         /*  Sending Event outputs  */
         cmbavLogonto.CurrentValue = StringUtil.RTrim( AV20LogOnTo);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavLogonto_Internalname, "Values", cmbavLogonto.ToJavascriptSource(), true);
      }

      protected void S122( )
      {
         /* 'DISPLAYMESSAGES' Routine */
         divTableloginerror_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTableloginerror_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTableloginerror_Visible), 5, 0)), true);
         AV35GXV2 = 1;
         while ( AV35GXV2 <= AV11Errors.Count )
         {
            AV10Error = ((SdtGAMError)AV11Errors.Item(AV35GXV2));
            if ( AV10Error.gxTpr_Code != 13 )
            {
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV10Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV10Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
            }
            AV35GXV2 = (int)(AV35GXV2+1);
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E141M2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_21_1M2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtable1_Internalname, tblUnnamedtable1_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellLogoappclient_cell_Internalname+"\" data-align=\"Center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-Center;text-align:-moz-Center;text-align:-webkit-Center")+"\" class='"+cellLogoappclient_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, imgavLogoappclient_Internalname, "Logo App Client", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Static Bitmap Variable */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            AV19LogoAppClient_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV19LogoAppClient))&&String.IsNullOrEmpty(StringUtil.RTrim( AV36Logoappclient_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV19LogoAppClient)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV19LogoAppClient)) ? AV36Logoappclient_GXI : context.PathToRelativeUrl( AV19LogoAppClient));
            GxWebStd.gx_bitmap( context, imgavLogoappclient_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgavLogoappclient_Visible, 0, "", "", 0, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, AV19LogoAppClient_IsBlob, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMRemoteLogin.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellCmpname_cell_Internalname+"\" data-align=\"Center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-Center;text-align:-moz-Center;text-align:-webkit-Center")+"\" class='"+cellCmpname_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCmpname_Internalname, "Cmp Name", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCmpname_Internalname, AV29CmpName, StringUtil.RTrim( context.localUtil.Format( AV29CmpName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCmpname_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", edtavCmpname_Visible, edtavCmpname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_GAMRemoteLogin.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellLogonto_cell_Internalname+"\"  class='"+cellLogonto_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavLogonto_Internalname, "Log On To", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavLogonto, cmbavLogonto_Internalname, StringUtil.RTrim( AV20LogOnTo), 1, cmbavLogonto_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", cmbavLogonto.Visible, cmbavLogonto.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,33);\"", "", true, "HLP_GAMRemoteLogin.htm");
            cmbavLogonto.CurrentValue = StringUtil.RTrim( AV20LogOnTo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavLogonto_Internalname, "Values", (String)(cmbavLogonto.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='DataContentCellLogin CellPaddingLogin'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUsername_Internalname, "User Name", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUsername_Internalname, AV26UserName, StringUtil.RTrim( context.localUtil.Format( AV26UserName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Email", edtavUsername_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUsername_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 0, 0, true, "GAMUserIdentification", "left", true, "HLP_GAMRemoteLogin.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='DataContentCellLogin CellPaddingLogin'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserpassword_Internalname, "User Password", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserpassword_Internalname, StringUtil.RTrim( AV27UserPassword), StringUtil.RTrim( context.localUtil.Format( AV27UserPassword, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,41);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Password", edtavUserpassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserpassword_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, -1, 0, 0, 1, 0, 0, true, "GAMPassword", "left", true, "HLP_GAMRemoteLogin.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='DataContentCellLogin CellPaddingLogin'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblForgotpassword_Internalname, "Forgot Password?", lblForgotpassword_Link, "", lblForgotpassword_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataDescriptionLogin", 0, "", 1, 1, 1, "HLP_GAMRemoteLogin.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellKeepmeloggedin_cell_Internalname+"\"  class='"+cellKeepmeloggedin_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavKeepmeloggedin_Internalname, "Keep Me Logged In", "col-sm-3 AttributeCheckBoxLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavKeepmeloggedin_Internalname, StringUtil.BoolToStr( AV16KeepMeLoggedIn), "", "Keep Me Logged In", chkavKeepmeloggedin.Visible, chkavKeepmeloggedin.Enabled, "true", " Keep me logged in", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(48, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,48);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellRememberme_cell_Internalname+"\"  class='"+cellRememberme_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRememberme_Internalname, "Remember Me", "col-sm-3 AttributeCheckBoxLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRememberme_Internalname, StringUtil.BoolToStr( AV21RememberMe), "", "Remember Me", chkavRememberme.Visible, chkavRememberme.Enabled, "true", " Remember me", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(52, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,52);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='TableActionsCellLogin'>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "Login", bttBtnenter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMRemoteLogin.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_21_1M2e( true) ;
         }
         else
         {
            wb_table1_21_1M2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6ApplicationClientId = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ApplicationClientId", AV6ApplicationClientId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAPPLICATIONCLIENTID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV6ApplicationClientId, "")), context));
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
         PA1M2( ) ;
         WS1M2( ) ;
         WE1M2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019452419", true);
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
         context.AddJavascriptSource("gamremotelogin.js", "?201892019452423", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgHeaderoriginal_Internalname = "HEADERORIGINAL";
         lblSignin_Internalname = "SIGNIN";
         imgavLogoappclient_Internalname = "vLOGOAPPCLIENT";
         cellLogoappclient_cell_Internalname = "LOGOAPPCLIENT_CELL";
         edtavCmpname_Internalname = "vCMPNAME";
         cellCmpname_cell_Internalname = "CMPNAME_CELL";
         cmbavLogonto_Internalname = "vLOGONTO";
         cellLogonto_cell_Internalname = "LOGONTO_CELL";
         edtavUsername_Internalname = "vUSERNAME";
         edtavUserpassword_Internalname = "vUSERPASSWORD";
         lblForgotpassword_Internalname = "FORGOTPASSWORD";
         chkavKeepmeloggedin_Internalname = "vKEEPMELOGGEDIN";
         cellKeepmeloggedin_cell_Internalname = "KEEPMELOGGEDIN_CELL";
         chkavRememberme_Internalname = "vREMEMBERME";
         cellRememberme_cell_Internalname = "REMEMBERME_CELL";
         bttBtnenter_Internalname = "BTNENTER";
         tblUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         divTablelogin_Internalname = "TABLELOGIN";
         divTableloginerror_Internalname = "TABLELOGINERROR";
         divTablecontent_Internalname = "TABLECONTENT";
         divTablemain_Internalname = "TABLEMAIN";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         chkavRememberme.Enabled = 1;
         cellRememberme_cell_Class = "";
         chkavKeepmeloggedin.Enabled = 1;
         cellKeepmeloggedin_cell_Class = "";
         lblForgotpassword_Link = "";
         edtavUserpassword_Jsonclick = "";
         edtavUserpassword_Enabled = 1;
         edtavUsername_Jsonclick = "";
         edtavUsername_Enabled = 1;
         cmbavLogonto_Jsonclick = "";
         cmbavLogonto.Enabled = 1;
         cellLogonto_cell_Class = "";
         edtavCmpname_Jsonclick = "";
         edtavCmpname_Enabled = 1;
         cellCmpname_cell_Class = "";
         cellLogoappclient_cell_Class = "";
         chkavRememberme.Visible = 1;
         chkavKeepmeloggedin.Visible = 1;
         cmbavLogonto.Visible = 1;
         edtavCmpname_Visible = 1;
         imgavLogoappclient_Visible = 1;
         chkavRememberme.Caption = "Remember Me";
         chkavKeepmeloggedin.Caption = "Keep Me Logged In";
         divTableloginerror_Visible = 1;
         Form.Backcolor = (int)(0xFFFFFF);
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV17Language',fld:'vLANGUAGE',pic:'',nv:''},{av:'AV26UserName',fld:'vUSERNAME',pic:'',nv:''},{av:'AV28UserRememberMe',fld:'vUSERREMEMBERME',pic:'Z9',nv:0},{av:'AV6ApplicationClientId',fld:'vAPPLICATIONCLIENTID',pic:'',hsh:true,nv:''}],oparms:[{av:'AV27UserPassword',fld:'vUSERPASSWORD',pic:'',nv:''},{av:'cmbavLogonto'},{av:'AV20LogOnTo',fld:'vLOGONTO',pic:'',nv:''},{av:'AV21RememberMe',fld:'vREMEMBERME',pic:'',nv:false},{av:'chkavRememberme.Visible',ctrl:'vREMEMBERME',prop:'Visible'},{av:'chkavKeepmeloggedin.Visible',ctrl:'vKEEPMELOGGEDIN',prop:'Visible'},{av:'divTableloginerror_Visible',ctrl:'TABLELOGINERROR',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E121M2',iparms:[{av:'AV16KeepMeLoggedIn',fld:'vKEEPMELOGGEDIN',pic:'',nv:false},{av:'AV21RememberMe',fld:'vREMEMBERME',pic:'',nv:false},{av:'cmbavLogonto'},{av:'AV20LogOnTo',fld:'vLOGONTO',pic:'',nv:''},{av:'AV26UserName',fld:'vUSERNAME',pic:'',nv:''},{av:'AV27UserPassword',fld:'vUSERPASSWORD',pic:'',nv:''},{av:'AV6ApplicationClientId',fld:'vAPPLICATIONCLIENTID',pic:'',hsh:true,nv:''}],oparms:[{av:'AV27UserPassword',fld:'vUSERPASSWORD',pic:'',nv:''},{av:'divTableloginerror_Visible',ctrl:'TABLELOGINERROR',prop:'Visible'}]}");
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
         wcpOAV6ApplicationClientId = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV17Language = "";
         GX_FocusControl = "";
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         sImgUrl = "";
         lblSignin_Jsonclick = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV20LogOnTo = "";
         AV19LogoAppClient = "";
         AV29CmpName = "";
         AV26UserName = "";
         AV27UserPassword = "";
         AV9ConnectionInfoCollection = new GXExternalCollection<SdtGAMConnectionInfo>( context, "SdtGAMConnectionInfo", "GeneXus.Programs");
         AV11Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV13GAMApplication = new SdtGAMApplication(context);
         AV5AdditionalParameter = new SdtGAMLoginAdditionalParameters(context);
         AV12ErrorsLogin = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV23Session = new SdtGAMSession(context);
         AV25URL = "";
         AV8AuthenticationTypes = new GXExternalCollection<SdtGAMAuthenticationTypeSimple>( context, "SdtGAMAuthenticationTypeSimple", "GeneXus.Programs");
         AV7AuthenticationType = new SdtGAMAuthenticationTypeSimple(context);
         AV22Repository = new SdtGAMRepository(context);
         AV10Error = new SdtGAMError(context);
         sStyleString = "";
         AV36Logoappclient_GXI = "";
         TempTags = "";
         lblForgotpassword_Jsonclick = "";
         bttBtnenter_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavCmpname_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short AV28UserRememberMe ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavCmpname_Enabled ;
      private int divTableloginerror_Visible ;
      private int imgavLogoappclient_Visible ;
      private int edtavCmpname_Visible ;
      private int AV34GXV1 ;
      private int AV35GXV2 ;
      private int edtavUsername_Enabled ;
      private int edtavUserpassword_Enabled ;
      private int idxLst ;
      private String AV6ApplicationClientId ;
      private String wcpOAV6ApplicationClientId ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String edtavCmpname_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String AV17Language ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divTablecontent_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String sImgUrl ;
      private String imgHeaderoriginal_Internalname ;
      private String divTablelogin_Internalname ;
      private String lblSignin_Internalname ;
      private String lblSignin_Jsonclick ;
      private String divTableloginerror_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String chkavKeepmeloggedin_Internalname ;
      private String chkavRememberme_Internalname ;
      private String cmbavLogonto_Internalname ;
      private String imgavLogoappclient_Internalname ;
      private String edtavUsername_Internalname ;
      private String AV27UserPassword ;
      private String edtavUserpassword_Internalname ;
      private String lblForgotpassword_Link ;
      private String lblForgotpassword_Internalname ;
      private String cellLogoappclient_cell_Class ;
      private String cellLogoappclient_cell_Internalname ;
      private String cellCmpname_cell_Class ;
      private String cellCmpname_cell_Internalname ;
      private String cellLogonto_cell_Class ;
      private String cellLogonto_cell_Internalname ;
      private String cellKeepmeloggedin_cell_Class ;
      private String cellKeepmeloggedin_cell_Internalname ;
      private String cellRememberme_cell_Class ;
      private String cellRememberme_cell_Internalname ;
      private String sStyleString ;
      private String tblUnnamedtable1_Internalname ;
      private String TempTags ;
      private String edtavCmpname_Jsonclick ;
      private String cmbavLogonto_Jsonclick ;
      private String edtavUsername_Jsonclick ;
      private String edtavUserpassword_Jsonclick ;
      private String lblForgotpassword_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool AV16KeepMeLoggedIn ;
      private bool AV21RememberMe ;
      private bool returnInSub ;
      private bool AV15isOK ;
      private bool AV18LoginOK ;
      private bool AV14hasError ;
      private bool AV24SessionValid ;
      private bool AV19LogoAppClient_IsBlob ;
      private String AV20LogOnTo ;
      private String AV29CmpName ;
      private String AV26UserName ;
      private String AV25URL ;
      private String AV36Logoappclient_GXI ;
      private String AV19LogoAppClient ;
      private GXWebForm Form ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private String aP0_ApplicationClientId ;
      private GXCombobox cmbavLogonto ;
      private GXCheckbox chkavKeepmeloggedin ;
      private GXCheckbox chkavRememberme ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMAuthenticationTypeSimple> AV8AuthenticationTypes ;
      private GXExternalCollection<SdtGAMConnectionInfo> AV9ConnectionInfoCollection ;
      private GXExternalCollection<SdtGAMError> AV11Errors ;
      private GXExternalCollection<SdtGAMError> AV12ErrorsLogin ;
      private SdtGAMLoginAdditionalParameters AV5AdditionalParameter ;
      private SdtGAMAuthenticationTypeSimple AV7AuthenticationType ;
      private SdtGAMError AV10Error ;
      private SdtGAMApplication AV13GAMApplication ;
      private SdtGAMRepository AV22Repository ;
      private SdtGAMSession AV23Session ;
   }

}
