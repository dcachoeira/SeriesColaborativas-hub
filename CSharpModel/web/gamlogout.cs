/*
               File: GAMLogout
        Description: Logout
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:27.2
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
   public class gamlogout : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public gamlogout( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
      }

      public gamlogout( IGxContext context )
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

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA0H2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               edtavGuid_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), true);
               WS0H2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
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
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Logout") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 121631), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxcfg.js", "?201892019382743", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamlogout.aspx") +"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vGUID", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV7GUID, "")), context));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = sPrefix + "hsh" + "GAMLogout";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV7GUID, ""));
         GxWebStd.gx_hidden_field( context, sPrefix+"hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("gamlogout:[SendSecurityCheck value for]"+"GUID:"+StringUtil.RTrim( context.localUtil.Format( AV7GUID, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"PROFILE_Class", StringUtil.RTrim( divProfile_Class));
      }

      protected void RenderHtmlCloseForm0H2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("gamlogout.js", "?201892019382768", false);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "GAMLogout" ;
      }

      public override String GetPgmdesc( )
      {
         return "Logout" ;
      }

      protected void WB0H0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "gamlogout.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "TableHeaderRight", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable3_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPhotocelltop_Internalname, divPhotocelltop_Visible, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Active Bitmap Variable */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'" + sPrefix + "',false,'',0)\"";
            ClassString = "RoundedImageTitle";
            StyleString = "";
            AV10Photo_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV10Photo))&&String.IsNullOrEmpty(StringUtil.RTrim( AV16Photo_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV10Photo)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV10Photo)) ? AV16Photo_GXI : context.PathToRelativeUrl( AV10Photo));
            GxWebStd.gx_bitmap( context, imgavPhoto_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, -1, 0, "", 0, "", 0, 0, 7, imgavPhoto_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+"e110h1_client"+"'", StyleString, ClassString, "", "", "", "", ""+TempTags, "", "", 1, AV10Photo_IsBlob, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMLogout.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLettercelltop_Internalname, divLettercelltop_Visible, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLettertittle_Internalname, lblLettertittle_Caption, "", "", lblLettertittle_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+"e110h1_client"+"'", "", "RoundedImageTitle RoundedImageText", 7, "", 1, 1, 0, "HLP_GAMLogout.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-9", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablewelcome_Internalname, 1, 0, "px", 0, "px", divTablewelcome_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "Middle", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTbwelcome_Internalname, lblTbwelcome_Caption, "", "", lblTbwelcome_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+"e110h1_client"+"'", "", "WelcomeText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMLogout.htm");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblCurrentrepository_Internalname, lblCurrentrepository_Caption, "", "", lblCurrentrepository_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "FloatingVersionTextColoured", 0, "", lblCurrentrepository_Visible, 1, 0, "HLP_GAMLogout.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divProfile_Internalname, 1, 0, "px", 0, "px", divProfile_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-3 col-sm-6 col-md-1 col-lg-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPhotocell_Internalname, divPhotocell_Visible, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Static Bitmap Variable */
            ClassString = "RoundedImage";
            StyleString = "";
            AV10Photo_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV10Photo))&&String.IsNullOrEmpty(StringUtil.RTrim( AV16Photo_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV10Photo)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV10Photo)) ? AV16Photo_GXI : context.PathToRelativeUrl( AV10Photo));
            GxWebStd.gx_bitmap( context, imgavPhoto_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 0, "", "", 0, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, AV10Photo_IsBlob, false, context.GetImageSrcSet( sImgUrl), "HLP_GAMLogout.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLettercell_Internalname, divLettercell_Visible, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLetter_Internalname, lblLetter_Caption, "", "", lblLetter_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "RoundedImage RoundedImageText", 0, "", 1, 1, 0, "HLP_GAMLogout.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-9 col-sm-6 col-md-11 col-lg-9", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblName_Internalname, lblName_Caption, "", "", lblName_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "WelcomeTextName", 0, "", 1, 1, 0, "HLP_GAMLogout.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 TopLeftSeparateCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblEmail_Internalname, lblEmail_Caption, "", "", lblEmail_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "WelcomeTextMarginLeft", 0, "", 1, 1, 0, "HLP_GAMLogout.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 TopLeftSeparateCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblSettings_Internalname, "Settings", "", "", lblSettings_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+"e120h1_client"+"'", "", "ActionText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMLogout.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 TopLeftSeparateCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblChangepassword_Internalname, "Change Password", "", "", lblChangepassword_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+"e130h1_client"+"'", "", "ActionText TextLikeLink", 7, "", 1, 1, 0, "HLP_GAMLogout.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 TopLeftSeparateCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLogout_Internalname, "Logout", "", "", lblLogout_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'LOGOUT\\'."+"'", "", "ActionText TextLikeLink", 5, "", 1, 1, 0, "HLP_GAMLogout.htm");
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
            GxWebStd.gx_div_start( context, "", edtavGuid_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavGuid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavGuid_Internalname, "GUID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavGuid_Internalname, StringUtil.RTrim( AV7GUID), StringUtil.RTrim( context.localUtil.Format( AV7GUID, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavGuid_Jsonclick, 0, "Attribute", "", "", "", "", edtavGuid_Visible, edtavGuid_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GAMGUID", "left", true, "HLP_GAMLogout.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0H2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
               Form.Meta.addItem("description", "Logout", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP0H0( ) ;
            }
         }
      }

      protected void WS0H2( )
      {
         START0H2( ) ;
         EVT0H2( ) ;
      }

      protected void EVT0H2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
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
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E140H2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'LOGOUT'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'Logout' */
                                    E150H2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E160H2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavGuid_Internalname;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
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
      }

      protected void WE0H2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0H2( ) ;
            }
         }
      }

      protected void PA0H2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavGuid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0H2( ) ;
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
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), true);
      }

      protected void RF0H2( )
      {
         initialize_formulas( ) ;
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E160H2 ();
            WB0H0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0H2( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vGUID", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV7GUID, "")), context));
      }

      protected void STRUP0H0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavGuid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGuid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E140H2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV10Photo = cgiGet( imgavPhoto_Internalname);
            AV10Photo = cgiGet( imgavPhoto_Internalname);
            AV7GUID = cgiGet( edtavGuid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7GUID", AV7GUID);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, sPrefix+"gxhash_vGUID", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV7GUID, "")), context));
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = sPrefix + "hsh" + "GAMLogout";
            AV7GUID = cgiGet( edtavGuid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7GUID", AV7GUID);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, sPrefix+"gxhash_vGUID", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV7GUID, "")), context));
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV7GUID, ""));
            hsh = cgiGet( sPrefix+"hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("gamlogout:[SecurityCheckFailed value for]"+"GUID:"+StringUtil.RTrim( context.localUtil.Format( AV7GUID, "")));
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
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
         E140H2 ();
         if (returnInSub) return;
      }

      protected void E140H2( )
      {
         /* Start Routine */
         lblCurrentrepository_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblCurrentrepository_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblCurrentrepository_Visible), 5, 0)), true);
         lblTbwelcome_Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblTbwelcome_Internalname, "Caption", lblTbwelcome_Caption, true);
         edtavGuid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGuid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGuid_Visible), 5, 0)), true);
         AV11Session = new SdtGAMSession(context).get(out  AV5Errors);
         divProfile_Class = "Table193x216Collapsed";
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divProfile_Internalname, "Class", divProfile_Class, true);
         if ( ! AV11Session.gxTpr_Isanonymous )
         {
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11Session.gxTpr_User.gxTpr_Firstname)) )
            {
               AV9Name = AV11Session.gxTpr_User.gxTpr_Firstname;
            }
            else
            {
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11Session.gxTpr_User.gxTpr_Name)) )
               {
                  AV9Name = AV11Session.gxTpr_User.gxTpr_Name;
               }
               else
               {
                  AV9Name = AV11Session.gxTpr_User.gxTpr_Email;
               }
            }
            lblTbwelcome_Caption = StringUtil.Format( "%1", AV9Name, "", "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblTbwelcome_Internalname, "Caption", lblTbwelcome_Caption, true);
         }
         else
         {
            CallWebObject(formatLink("login.aspx") );
            context.wjLocDisableFrm = 1;
         }
         AV12User = new SdtGAMUser(context).get();
         lblName_Caption = AV12User.gxTpr_Firstname+" "+AV12User.gxTpr_Lastname;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblName_Internalname, "Caption", lblName_Caption, true);
         lblEmail_Caption = AV12User.gxTpr_Email;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblEmail_Internalname, "Caption", lblEmail_Caption, true);
         AV7GUID = AV12User.gxTpr_Guid;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7GUID", AV7GUID);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, sPrefix+"gxhash_vGUID", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV7GUID, "")), context));
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12User.gxTpr_Urlimage)) )
         {
            AV10Photo = AV12User.gxTpr_Urlimage;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgavPhoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV10Photo)) ? AV16Photo_GXI : context.convertURL( context.PathToRelativeUrl( AV10Photo))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgavPhoto_Internalname, "SrcSet", context.GetImageSrcSet( AV10Photo), true);
            AV16Photo_GXI = GXDbFile.PathToUrl( AV12User.gxTpr_Urlimage);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgavPhoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV10Photo)) ? AV16Photo_GXI : context.convertURL( context.PathToRelativeUrl( AV10Photo))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgavPhoto_Internalname, "SrcSet", context.GetImageSrcSet( AV10Photo), true);
            divPhotocell_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divPhotocell_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divPhotocell_Visible), 5, 0)), true);
            divLettercell_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divLettercell_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divLettercell_Visible), 5, 0)), true);
            divPhotocelltop_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divPhotocelltop_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divPhotocelltop_Visible), 5, 0)), true);
            divLettercelltop_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divLettercelltop_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divLettercelltop_Visible), 5, 0)), true);
         }
         else
         {
            divLettercell_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divLettercell_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divLettercell_Visible), 5, 0)), true);
            divPhotocell_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divPhotocell_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divPhotocell_Visible), 5, 0)), true);
            divLettercelltop_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divLettercelltop_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divLettercelltop_Visible), 5, 0)), true);
            divPhotocelltop_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divPhotocelltop_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divPhotocelltop_Visible), 5, 0)), true);
            lblLetter_Caption = StringUtil.Substring( AV12User.gxTpr_Name, 1, 1);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblLetter_Internalname, "Caption", lblLetter_Caption, true);
            lblLettertittle_Caption = StringUtil.Substring( AV12User.gxTpr_Name, 1, 1);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblLettertittle_Internalname, "Caption", lblLettertittle_Caption, true);
         }
         AV13GAMConnectionInfo = new SdtGAM(context).getconnections();
         if ( AV13GAMConnectionInfo.Count > 1 )
         {
            AV6GAMRepository = new SdtGAMRepository(context).get();
            lblCurrentrepository_Caption = "Repository:"+AV6GAMRepository.gxTpr_Name;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblCurrentrepository_Internalname, "Caption", lblCurrentrepository_Caption, true);
            lblCurrentrepository_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblCurrentrepository_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblCurrentrepository_Visible), 5, 0)), true);
            divTablewelcome_Class = "NegativeMarginTop10";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divTablewelcome_Internalname, "Class", divTablewelcome_Class, true);
         }
      }

      protected void E150H2( )
      {
         /* 'Logout' Routine */
         AV8Isok = new SdtGAMRepository(context).logout(out  AV5Errors);
         new SdtGAMRepository(context).applicationgohome("8d9934db-05db-4d64-adba-5e0466c3appU") ;
      }

      protected void nextLoad( )
      {
      }

      protected void E160H2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA0H2( ) ;
         WS0H2( ) ;
         WE0H2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0H2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "gamlogout", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA0H2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
         }
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA0H2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0H2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS0H2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE0H2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019383987", true);
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
         context.AddJavascriptSource("gamlogout.js", "?201892019383990", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
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
         imgavPhoto_Internalname = sPrefix+"vPHOTO";
         divPhotocelltop_Internalname = sPrefix+"PHOTOCELLTOP";
         lblLettertittle_Internalname = sPrefix+"LETTERTITTLE";
         divLettercelltop_Internalname = sPrefix+"LETTERCELLTOP";
         divTable3_Internalname = sPrefix+"TABLE3";
         lblTbwelcome_Internalname = sPrefix+"TBWELCOME";
         lblCurrentrepository_Internalname = sPrefix+"CURRENTREPOSITORY";
         divTablewelcome_Internalname = sPrefix+"TABLEWELCOME";
         divTable1_Internalname = sPrefix+"TABLE1";
         imgavPhoto_Internalname = sPrefix+"vPHOTO";
         divPhotocell_Internalname = sPrefix+"PHOTOCELL";
         lblLetter_Internalname = sPrefix+"LETTER";
         divLettercell_Internalname = sPrefix+"LETTERCELL";
         divTable2_Internalname = sPrefix+"TABLE2";
         lblName_Internalname = sPrefix+"NAME";
         lblEmail_Internalname = sPrefix+"EMAIL";
         lblSettings_Internalname = sPrefix+"SETTINGS";
         lblChangepassword_Internalname = sPrefix+"CHANGEPASSWORD";
         lblLogout_Internalname = sPrefix+"LOGOUT";
         divProfile_Internalname = sPrefix+"PROFILE";
         edtavGuid_Internalname = sPrefix+"vGUID";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         Form.Internalname = sPrefix+"FORM";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtavGuid_Jsonclick = "";
         edtavGuid_Enabled = 1;
         edtavGuid_Visible = 1;
         lblLogout_Jsonclick = "";
         lblSettings_Jsonclick = "";
         lblEmail_Caption = "Text Block";
         lblName_Caption = "Text Block";
         lblLetter_Caption = "Q";
         divLettercell_Visible = 1;
         divPhotocell_Visible = 1;
         lblCurrentrepository_Caption = "Text Block";
         lblCurrentrepository_Visible = 1;
         lblTbwelcome_Caption = "TBWelcome";
         divTablewelcome_Class = "Table";
         lblLettertittle_Caption = "Q";
         divLettercelltop_Visible = 1;
         imgavPhoto_Jsonclick = "";
         divPhotocelltop_Visible = 1;
         divProfile_Class = "Table193x216";
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV7GUID',fld:'vGUID',pic:'',hsh:true,nv:''}],oparms:[]}");
         setEventMetadata("'LOGOUT'","{handler:'E150H2',iparms:[],oparms:[]}");
         setEventMetadata("'USEROPTIONS'","{handler:'E110H1',iparms:[{av:'divProfile_Class',ctrl:'PROFILE',prop:'Class'}],oparms:[{av:'divProfile_Class',ctrl:'PROFILE',prop:'Class'}]}");
         setEventMetadata("'PROFILE'","{handler:'E120H1',iparms:[{av:'AV7GUID',fld:'vGUID',pic:'',hsh:true,nv:''}],oparms:[]}");
         setEventMetadata("'CHANGEPASSWORD'","{handler:'E130H1',iparms:[],oparms:[]}");
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
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV7GUID = "";
         GXKey = "";
         forbiddenHiddens = "";
         GX_FocusControl = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         AV10Photo = "";
         AV16Photo_GXI = "";
         sImgUrl = "";
         lblLettertittle_Jsonclick = "";
         lblTbwelcome_Jsonclick = "";
         lblCurrentrepository_Jsonclick = "";
         lblLetter_Jsonclick = "";
         lblName_Jsonclick = "";
         lblEmail_Jsonclick = "";
         lblChangepassword_Jsonclick = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         hsh = "";
         AV11Session = new SdtGAMSession(context);
         AV5Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV9Name = "";
         AV12User = new SdtGAMUser(context);
         AV13GAMConnectionInfo = new GXExternalCollection<SdtGAMConnectionInfo>( context, "SdtGAMConnectionInfo", "GeneXus.Programs");
         AV6GAMRepository = new SdtGAMRepository(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavGuid_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavGuid_Enabled ;
      private int divPhotocelltop_Visible ;
      private int divLettercelltop_Visible ;
      private int lblCurrentrepository_Visible ;
      private int divPhotocell_Visible ;
      private int divLettercell_Visible ;
      private int edtavGuid_Visible ;
      private int idxLst ;
      private String divProfile_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String edtavGuid_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String AV7GUID ;
      private String GXKey ;
      private String forbiddenHiddens ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String divTable1_Internalname ;
      private String divTable3_Internalname ;
      private String divPhotocelltop_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String sImgUrl ;
      private String imgavPhoto_Internalname ;
      private String imgavPhoto_Jsonclick ;
      private String divLettercelltop_Internalname ;
      private String lblLettertittle_Internalname ;
      private String lblLettertittle_Caption ;
      private String lblLettertittle_Jsonclick ;
      private String divTablewelcome_Internalname ;
      private String divTablewelcome_Class ;
      private String lblTbwelcome_Internalname ;
      private String lblTbwelcome_Caption ;
      private String lblTbwelcome_Jsonclick ;
      private String lblCurrentrepository_Internalname ;
      private String lblCurrentrepository_Caption ;
      private String lblCurrentrepository_Jsonclick ;
      private String divProfile_Internalname ;
      private String divTable2_Internalname ;
      private String divPhotocell_Internalname ;
      private String divLettercell_Internalname ;
      private String lblLetter_Internalname ;
      private String lblLetter_Caption ;
      private String lblLetter_Jsonclick ;
      private String lblName_Internalname ;
      private String lblName_Caption ;
      private String lblName_Jsonclick ;
      private String lblEmail_Internalname ;
      private String lblEmail_Caption ;
      private String lblEmail_Jsonclick ;
      private String lblSettings_Internalname ;
      private String lblSettings_Jsonclick ;
      private String lblChangepassword_Internalname ;
      private String lblChangepassword_Jsonclick ;
      private String lblLogout_Internalname ;
      private String lblLogout_Jsonclick ;
      private String edtavGuid_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String hsh ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool AV10Photo_IsBlob ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV8Isok ;
      private String AV16Photo_GXI ;
      private String AV9Name ;
      private String AV10Photo ;
      private GXWebForm Form ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMError> AV5Errors ;
      private GXExternalCollection<SdtGAMConnectionInfo> AV13GAMConnectionInfo ;
      private SdtGAMRepository AV6GAMRepository ;
      private SdtGAMUser AV12User ;
      private SdtGAMSession AV11Session ;
   }

}
