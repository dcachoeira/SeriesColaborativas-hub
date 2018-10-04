/*
               File: GAMUserEntry
        Description: User
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:40:11.2
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
   public class gamuserentry : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamuserentry( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamuserentry( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           String aP1_UserId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV44UserId = aP1_UserId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavUserauthenticationtypename = new GXCombobox();
         cmbavUsergender = new GXCombobox();
         chkavUserisactive = new GXCheckbox();
         chkavUserisenabledinrepository = new GXCheckbox();
         chkavUserdontreceiveinformation = new GXCheckbox();
         chkavUserisblocked = new GXCheckbox();
         chkavUsercannotchangepassword = new GXCheckbox();
         chkavUsermustchangepassword = new GXCheckbox();
         chkavUserpasswordneverexpires = new GXCheckbox();
         cmbavUsersecuritypolicyid = new GXCombobox();
         chkavUser_isenabledinrepository = new GXCheckbox();
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
               Gx_mode = gxfirstwebparm;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV44UserId = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44UserId", AV44UserId);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV44UserId, "")), context));
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
         PA0J2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0J2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019401188", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("calendar-pt.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamuserentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV44UserId))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERISENABLEDINREPOSITORY", GetSecureSignedToken( "", AV60UserIsEnabledInRepository, context));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERACTIVATIONDATE", GetSecureSignedToken( "", context.localUtil.Format( AV47UserActivationDate, "99/99/9999 99:99"), context));
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "GAMUserEntry";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV47UserActivationDate, "99/99/9999 99:99");
         AV60UserIsEnabledInRepository = StringUtil.StrToBool( StringUtil.BoolToStr( AV60UserIsEnabledInRepository));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60UserIsEnabledInRepository", AV60UserIsEnabledInRepository);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERISENABLEDINREPOSITORY", GetSecureSignedToken( "", AV60UserIsEnabledInRepository, context));
         forbiddenHiddens = forbiddenHiddens + StringUtil.BoolToStr( AV60UserIsEnabledInRepository);
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("gamuserentry:[SendSecurityCheck value for]"+"UserActivationDate:"+context.localUtil.Format( AV47UserActivationDate, "99/99/9999 99:99"));
         GXUtil.WriteLog("gamuserentry:[SendSecurityCheck value for]"+"UserIsEnabledInRepository:"+StringUtil.BoolToStr( AV60UserIsEnabledInRepository));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "vUSERID", StringUtil.RTrim( AV44UserId));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV44UserId, "")), context));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_boolean_hidden_field( context, "vCHECKREQUIREDFIELDSRESULT", AV46CheckRequiredFieldsResult);
         GxWebStd.gx_hidden_field( context, "vLANGUAGE", StringUtil.RTrim( AV28Language));
         GxWebStd.gx_hidden_field( context, "vUSERAUTHENTICATIONTYPET", StringUtil.RTrim( AV70UserAuthenticationTypeT));
         GxWebStd.gx_hidden_field( context, "vPASSWORD", StringUtil.RTrim( AV32Password));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Width", StringUtil.RTrim( Dvpanel_tableattributes_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Cls", StringUtil.RTrim( Dvpanel_tableattributes_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Title", StringUtil.RTrim( Dvpanel_tableattributes_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsible", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsed", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autowidth", StringUtil.BoolToStr( Dvpanel_tableattributes_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoheight", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableattributes_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Iconposition", StringUtil.RTrim( Dvpanel_tableattributes_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoscroll));
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
         context.WriteHtmlTextNl( "</form>") ;
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
            WE0J2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0J2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gamuserentry.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV44UserId)) ;
      }

      public override String GetPgmname( )
      {
         return "GAMUserEntry" ;
      }

      public override String GetPgmdesc( )
      {
         return "User " ;
      }

      protected void WB0J0( )
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
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUserauthenticationtypename_cell_Internalname, 1, 0, "px", 0, "px", divUserauthenticationtypename_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", cmbavUserauthenticationtypename.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavUserauthenticationtypename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavUserauthenticationtypename_Internalname, "Auth. type", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavUserauthenticationtypename, cmbavUserauthenticationtypename_Internalname, StringUtil.RTrim( AV48UserAuthenticationTypeName), 1, cmbavUserauthenticationtypename_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", cmbavUserauthenticationtypename.Visible, cmbavUserauthenticationtypename.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,25);\"", "", true, "HLP_GAMUserEntry.htm");
            cmbavUserauthenticationtypename.CurrentValue = StringUtil.RTrim( AV48UserAuthenticationTypeName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavUserauthenticationtypename_Internalname, "Values", (String)(cmbavUserauthenticationtypename.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUsername_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUsername_Internalname, "User Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUsername_Internalname, AV63UserName, StringUtil.RTrim( context.localUtil.Format( AV63UserName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUsername_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUsername_Enabled, 1, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 0, 0, true, "GAMUserIdentification", "left", true, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUseremail_cell_Internalname, 1, 0, "px", 0, "px", divUseremail_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUseremail_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUseremail_Internalname, "Email", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUseremail_Internalname, AV53UserEmail, StringUtil.RTrim( context.localUtil.Format( AV53UserEmail, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUseremail_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUseremail_Enabled, 1, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, 0, true, "GAMEMail", "left", true, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUserfirstname_cell_Internalname, 1, 0, "px", 0, "px", divUserfirstname_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserfirstname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserfirstname_Internalname, "First Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserfirstname_Internalname, StringUtil.RTrim( AV55UserFirstName), StringUtil.RTrim( context.localUtil.Format( AV55UserFirstName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserfirstname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserfirstname_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionShort", "left", true, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUserlastname_cell_Internalname, 1, 0, "px", 0, "px", divUserlastname_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserlastname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserlastname_Internalname, "Last Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserlastname_Internalname, StringUtil.RTrim( AV61UserLastName), StringUtil.RTrim( context.localUtil.Format( AV61UserLastName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserlastname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserlastname_Enabled, 1, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionShort", "left", true, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUserpassword_cell_Internalname, 1, 0, "px", 0, "px", divUserpassword_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavUserpassword_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserpassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserpassword_Internalname, "Password", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserpassword_Internalname, StringUtil.RTrim( AV64UserPassword), StringUtil.RTrim( context.localUtil.Format( AV64UserPassword, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserpassword_Jsonclick, 0, "Attribute", "", "", "", "", edtavUserpassword_Visible, edtavUserpassword_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, -1, 0, 0, 1, 0, 0, true, "GAMPassword", "left", true, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPasswordconf_cell_Internalname, 1, 0, "px", 0, "px", divPasswordconf_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavPasswordconf_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavPasswordconf_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPasswordconf_Internalname, "Password conf.", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPasswordconf_Internalname, StringUtil.RTrim( AV33PasswordConf), StringUtil.RTrim( context.localUtil.Format( AV33PasswordConf, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPasswordconf_Jsonclick, 0, "Attribute", "", "", "", "", edtavPasswordconf_Visible, edtavPasswordconf_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, -1, 0, 0, 1, 0, 0, true, "GAMPassword", "left", true, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserexternalid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserexternalid_Internalname, "External Id.", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserexternalid_Internalname, AV54UserExternalId, StringUtil.RTrim( context.localUtil.Format( AV54UserExternalId, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserexternalid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUserexternalid_Enabled, 1, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 0, 0, true, "GAMUserIdentification", "left", true, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUserbirthday_cell_Internalname, 1, 0, "px", 0, "px", divUserbirthday_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserbirthday_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserbirthday_Internalname, "Birthday", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavUserbirthday_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavUserbirthday_Internalname, context.localUtil.Format(AV49UserBirthday, "99/99/9999"), context.localUtil.Format( AV49UserBirthday, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'por',false,0);"+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserbirthday_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavUserbirthday_Enabled, 1, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "GAMDate", "right", false, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_bitmap( context, edtavUserbirthday_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavUserbirthday_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_GAMUserEntry.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUsergender_cell_Internalname, 1, 0, "px", 0, "px", divUsergender_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavUsergender_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavUsergender_Internalname, "Gender", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavUsergender, cmbavUsergender_Internalname, StringUtil.RTrim( AV56UserGender), 1, cmbavUsergender_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavUsergender.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "", true, "HLP_GAMUserEntry.htm");
            cmbavUsergender.CurrentValue = StringUtil.RTrim( AV56UserGender);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavUsergender_Internalname, "Values", (String)(cmbavUsergender.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUserurlprofile_cell_Internalname, 1, 0, "px", 0, "px", divUserurlprofile_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavUserurlprofile_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserurlprofile_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserurlprofile_Internalname, "URL profile", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserurlprofile_Internalname, AV68UserURLProfile, StringUtil.RTrim( context.localUtil.Format( AV68UserURLProfile, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", edtavUserurlprofile_Link, edtavUserurlprofile_Linktarget, "", "", edtavUserurlprofile_Jsonclick, 0, "Attribute", "", "", "", "", edtavUserurlprofile_Visible, edtavUserurlprofile_Enabled, 1, "text", "", 80, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUserurlimage_cell_Internalname, 1, 0, "px", 0, "px", divUserurlimage_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavUserurlimage_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserurlimage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserurlimage_Internalname, "URL image", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserurlimage_Internalname, AV67UserURLImage, StringUtil.RTrim( context.localUtil.Format( AV67UserURLImage, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,75);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserurlimage_Jsonclick, 0, "Attribute", "", "", "", "", edtavUserurlimage_Visible, edtavUserurlimage_Enabled, 1, "text", "", 80, "chr", 1, "row", 2048, 0, 0, 0, 1, -1, 0, true, "GAMURL", "left", true, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUserisactive_cell_Internalname, 1, 0, "px", 0, "px", divUserisactive_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", chkavUserisactive.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavUserisactive_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavUserisactive_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUserisactive_Internalname, StringUtil.BoolToStr( AV58UserIsActive), "", " ", chkavUserisactive.Visible, chkavUserisactive.Enabled, "true", "Is active?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(79, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,79);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUseractivationdate_cell_Internalname, 1, 0, "px", 0, "px", divUseractivationdate_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavUseractivationdate_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUseractivationdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUseractivationdate_Internalname, "Activation date", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavUseractivationdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavUseractivationdate_Internalname, context.localUtil.TToC( AV47UserActivationDate, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV47UserActivationDate, "99/99/9999 99:99"), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',5,24,'por',false,0);"+";gx.evt.onblur(this,84);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUseractivationdate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", edtavUseractivationdate_Visible, edtavUseractivationdate_Enabled, 0, "text", "", 16, "chr", 1, "row", 16, 0, 0, 0, 1, -1, 0, true, "GAMDateTime", "right", false, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_bitmap( context, edtavUseractivationdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavUseractivationdate_Visible==0)||(edtavUseractivationdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_GAMUserEntry.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplitteduserisenabledinrepository_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTextblockuserisenabledinrepository_cell_Internalname, 1, 0, "px", 0, "px", divTextblockuserisenabledinrepository_cell_Class, "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockuserisenabledinrepository_Internalname, "", "", "", lblTextblockuserisenabledinrepository_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_91_0J2( true) ;
         }
         else
         {
            wb_table1_91_0J2( false) ;
         }
         return  ;
      }

      protected void wb_table1_91_0J2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divUserdatelasauthentication_cell_Internalname, 1, 0, "px", 0, "px", divUserdatelasauthentication_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavUserdatelasauthentication_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUserdatelasauthentication_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUserdatelasauthentication_Internalname, "Date last auth.", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavUserdatelasauthentication_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavUserdatelasauthentication_Internalname, context.localUtil.TToC( AV51UserDateLasAuthentication, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV51UserDateLasAuthentication, "99/99/9999 99:99"), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',5,24,'por',false,0);"+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserdatelasauthentication_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", edtavUserdatelasauthentication_Visible, edtavUserdatelasauthentication_Enabled, 0, "text", "", 16, "chr", 1, "row", 16, 0, 0, 0, 1, -1, 0, true, "GAMDateTime", "right", false, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_bitmap( context, edtavUserdatelasauthentication_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavUserdatelasauthentication_Visible==0)||(edtavUserdatelasauthentication_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_GAMUserEntry.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavUserdontreceiveinformation_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavUserdontreceiveinformation_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUserdontreceiveinformation_Internalname, StringUtil.BoolToStr( AV52UserDontReceiveInformation), "", " ", 1, chkavUserdontreceiveinformation.Enabled, "true", "Don't want to receive information", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(106, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,106);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavUserisblocked_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavUserisblocked_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUserisblocked_Internalname, StringUtil.BoolToStr( AV59UserIsBlocked), "", " ", 1, chkavUserisblocked.Enabled, "true", "Is Blocked?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(111, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,111);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavUsercannotchangepassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavUsercannotchangepassword_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUsercannotchangepassword_Internalname, StringUtil.BoolToStr( AV50UserCannotChangePassword), "", " ", 1, chkavUsercannotchangepassword.Enabled, "true", "Cannot change password", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(115, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,115);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavUsermustchangepassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavUsermustchangepassword_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 120,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUsermustchangepassword_Internalname, StringUtil.BoolToStr( AV62UserMustChangePassword), "", " ", 1, chkavUsermustchangepassword.Enabled, "true", "Must change password", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(120, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,120);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavUserpasswordneverexpires_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavUserpasswordneverexpires_Internalname, " ", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 124,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUserpasswordneverexpires_Internalname, StringUtil.BoolToStr( AV65UserPasswordNeverExpires), "", " ", 1, chkavUserpasswordneverexpires.Enabled, "true", "Password never expires", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(124, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,124);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavUsersecuritypolicyid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavUsersecuritypolicyid_Internalname, "Security policy", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 129,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavUsersecuritypolicyid, cmbavUsersecuritypolicyid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV66UserSecurityPolicyId), 9, 0)), 1, cmbavUsersecuritypolicyid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavUsersecuritypolicyid.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,129);\"", "", true, "HLP_GAMUserEntry.htm");
            cmbavUsersecuritypolicyid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV66UserSecurityPolicyId), 9, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavUsersecuritypolicyid_Internalname, "Values", (String)(cmbavUsersecuritypolicyid.ToJavascriptSource()), true);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 134,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", bttBtnenter_Caption, bttBtnenter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtnenter_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 136,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Fechar", bttBtncancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 140,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUser_isenabledinrepository_Internalname, StringUtil.BoolToStr( AV43User.gxTpr_Isenabledinrepository), "", "", chkavUser_isenabledinrepository.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(140, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,140);\"");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 141,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUserguid_Internalname, StringUtil.RTrim( AV57UserGUID), StringUtil.RTrim( context.localUtil.Format( AV57UserGUID, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,141);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUserguid_Jsonclick, 0, "Attribute", "", "", "", "", edtavUserguid_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GAMGUID", "left", true, "HLP_GAMUserEntry.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 142,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUsernamespace_Internalname, StringUtil.RTrim( AV45UserNameSpace), StringUtil.RTrim( context.localUtil.Format( AV45UserNameSpace, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,142);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUsernamespace_Jsonclick, 0, "Attribute", "", "", "", "", edtavUsernamespace_Visible, 1, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, 0, true, "GAMRepositoryNameSpace", "left", true, "HLP_GAMUserEntry.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0J2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "User ", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0J0( ) ;
      }

      protected void WS0J2( )
      {
         START0J2( ) ;
         EVT0J2( ) ;
      }

      protected void EVT0J2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E110J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOENABLEUSERINREPO'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoEnableUserinRepo' */
                              E120J2 ();
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
                                    E130J2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VUSERAUTHENTICATIONTYPENAME.ISVALID") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E140J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E150J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E160J2 ();
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
      }

      protected void WE0J2( )
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

      protected void PA0J2( )
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
            cmbavUserauthenticationtypename.Name = "vUSERAUTHENTICATIONTYPENAME";
            cmbavUserauthenticationtypename.WebTags = "";
            if ( cmbavUserauthenticationtypename.ItemCount > 0 )
            {
               AV48UserAuthenticationTypeName = cmbavUserauthenticationtypename.getValidValue(AV48UserAuthenticationTypeName);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48UserAuthenticationTypeName", AV48UserAuthenticationTypeName);
            }
            cmbavUsergender.Name = "vUSERGENDER";
            cmbavUsergender.WebTags = "";
            cmbavUsergender.addItem("N", "Not Specified", 0);
            cmbavUsergender.addItem("F", "Female", 0);
            cmbavUsergender.addItem("M", "Male", 0);
            if ( cmbavUsergender.ItemCount > 0 )
            {
               AV56UserGender = cmbavUsergender.getValidValue(AV56UserGender);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56UserGender", AV56UserGender);
            }
            chkavUserisactive.Name = "vUSERISACTIVE";
            chkavUserisactive.WebTags = "";
            chkavUserisactive.Caption = "Is active?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserisactive_Internalname, "TitleCaption", chkavUserisactive.Caption, true);
            chkavUserisactive.CheckedValue = "false";
            chkavUserisenabledinrepository.Name = "vUSERISENABLEDINREPOSITORY";
            chkavUserisenabledinrepository.WebTags = "";
            chkavUserisenabledinrepository.Caption = "Is enabled in repository?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserisenabledinrepository_Internalname, "TitleCaption", chkavUserisenabledinrepository.Caption, true);
            chkavUserisenabledinrepository.CheckedValue = "false";
            chkavUserdontreceiveinformation.Name = "vUSERDONTRECEIVEINFORMATION";
            chkavUserdontreceiveinformation.WebTags = "";
            chkavUserdontreceiveinformation.Caption = "Don't want to receive information";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserdontreceiveinformation_Internalname, "TitleCaption", chkavUserdontreceiveinformation.Caption, true);
            chkavUserdontreceiveinformation.CheckedValue = "false";
            chkavUserisblocked.Name = "vUSERISBLOCKED";
            chkavUserisblocked.WebTags = "";
            chkavUserisblocked.Caption = "Is Blocked?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserisblocked_Internalname, "TitleCaption", chkavUserisblocked.Caption, true);
            chkavUserisblocked.CheckedValue = "false";
            chkavUsercannotchangepassword.Name = "vUSERCANNOTCHANGEPASSWORD";
            chkavUsercannotchangepassword.WebTags = "";
            chkavUsercannotchangepassword.Caption = "Cannot change password";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUsercannotchangepassword_Internalname, "TitleCaption", chkavUsercannotchangepassword.Caption, true);
            chkavUsercannotchangepassword.CheckedValue = "false";
            chkavUsermustchangepassword.Name = "vUSERMUSTCHANGEPASSWORD";
            chkavUsermustchangepassword.WebTags = "";
            chkavUsermustchangepassword.Caption = "Must change password";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUsermustchangepassword_Internalname, "TitleCaption", chkavUsermustchangepassword.Caption, true);
            chkavUsermustchangepassword.CheckedValue = "false";
            chkavUserpasswordneverexpires.Name = "vUSERPASSWORDNEVEREXPIRES";
            chkavUserpasswordneverexpires.WebTags = "";
            chkavUserpasswordneverexpires.Caption = "Password never expires";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserpasswordneverexpires_Internalname, "TitleCaption", chkavUserpasswordneverexpires.Caption, true);
            chkavUserpasswordneverexpires.CheckedValue = "false";
            cmbavUsersecuritypolicyid.Name = "vUSERSECURITYPOLICYID";
            cmbavUsersecuritypolicyid.WebTags = "";
            if ( cmbavUsersecuritypolicyid.ItemCount > 0 )
            {
               AV66UserSecurityPolicyId = (int)(NumberUtil.Val( cmbavUsersecuritypolicyid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV66UserSecurityPolicyId), 9, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66UserSecurityPolicyId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV66UserSecurityPolicyId), 9, 0)));
            }
            chkavUser_isenabledinrepository.Name = "USER_ISENABLEDINREPOSITORY";
            chkavUser_isenabledinrepository.WebTags = "";
            chkavUser_isenabledinrepository.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUser_isenabledinrepository_Internalname, "TitleCaption", chkavUser_isenabledinrepository.Caption, true);
            chkavUser_isenabledinrepository.CheckedValue = "false";
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = cmbavUserauthenticationtypename_Internalname;
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
         if ( cmbavUserauthenticationtypename.ItemCount > 0 )
         {
            AV48UserAuthenticationTypeName = cmbavUserauthenticationtypename.getValidValue(AV48UserAuthenticationTypeName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48UserAuthenticationTypeName", AV48UserAuthenticationTypeName);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavUserauthenticationtypename.CurrentValue = StringUtil.RTrim( AV48UserAuthenticationTypeName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavUserauthenticationtypename_Internalname, "Values", cmbavUserauthenticationtypename.ToJavascriptSource(), true);
         }
         if ( cmbavUsergender.ItemCount > 0 )
         {
            AV56UserGender = cmbavUsergender.getValidValue(AV56UserGender);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56UserGender", AV56UserGender);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavUsergender.CurrentValue = StringUtil.RTrim( AV56UserGender);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavUsergender_Internalname, "Values", cmbavUsergender.ToJavascriptSource(), true);
         }
         if ( cmbavUsersecuritypolicyid.ItemCount > 0 )
         {
            AV66UserSecurityPolicyId = (int)(NumberUtil.Val( cmbavUsersecuritypolicyid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV66UserSecurityPolicyId), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66UserSecurityPolicyId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV66UserSecurityPolicyId), 9, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavUsersecuritypolicyid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV66UserSecurityPolicyId), 9, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavUsersecuritypolicyid_Internalname, "Values", cmbavUsersecuritypolicyid.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0J2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavUseractivationdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUseractivationdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUseractivationdate_Enabled), 5, 0)), true);
         chkavUserisenabledinrepository.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserisenabledinrepository_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUserisenabledinrepository.Enabled), 5, 0)), true);
         edtavUserdatelasauthentication_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserdatelasauthentication_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserdatelasauthentication_Enabled), 5, 0)), true);
      }

      protected void RF0J2( )
      {
         initialize_formulas( ) ;
         /* Execute user event: Refresh */
         E150J2 ();
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E160J2 ();
            WB0J0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0J2( )
      {
         GxWebStd.gx_hidden_field( context, "vUSERID", StringUtil.RTrim( AV44UserId));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV44UserId, "")), context));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERISENABLEDINREPOSITORY", GetSecureSignedToken( "", AV60UserIsEnabledInRepository, context));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERACTIVATIONDATE", GetSecureSignedToken( "", context.localUtil.Format( AV47UserActivationDate, "99/99/9999 99:99"), context));
      }

      protected void STRUP0J0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavUseractivationdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUseractivationdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUseractivationdate_Enabled), 5, 0)), true);
         chkavUserisenabledinrepository.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserisenabledinrepository_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUserisenabledinrepository.Enabled), 5, 0)), true);
         edtavUserdatelasauthentication_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserdatelasauthentication_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserdatelasauthentication_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110J2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbavUserauthenticationtypename.CurrentValue = cgiGet( cmbavUserauthenticationtypename_Internalname);
            AV48UserAuthenticationTypeName = cgiGet( cmbavUserauthenticationtypename_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48UserAuthenticationTypeName", AV48UserAuthenticationTypeName);
            AV63UserName = cgiGet( edtavUsername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63UserName", AV63UserName);
            AV53UserEmail = cgiGet( edtavUseremail_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53UserEmail", AV53UserEmail);
            AV55UserFirstName = cgiGet( edtavUserfirstname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55UserFirstName", AV55UserFirstName);
            AV61UserLastName = cgiGet( edtavUserlastname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61UserLastName", AV61UserLastName);
            AV64UserPassword = cgiGet( edtavUserpassword_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64UserPassword", AV64UserPassword);
            AV33PasswordConf = cgiGet( edtavPasswordconf_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33PasswordConf", AV33PasswordConf);
            AV54UserExternalId = cgiGet( edtavUserexternalid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54UserExternalId", AV54UserExternalId);
            if ( context.localUtil.VCDateTime( cgiGet( edtavUserbirthday_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"User Birthday"}), 1, "vUSERBIRTHDAY");
               GX_FocusControl = edtavUserbirthday_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV49UserBirthday = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49UserBirthday", context.localUtil.Format(AV49UserBirthday, "99/99/9999"));
            }
            else
            {
               AV49UserBirthday = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtavUserbirthday_Internalname), 0));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49UserBirthday", context.localUtil.Format(AV49UserBirthday, "99/99/9999"));
            }
            cmbavUsergender.CurrentValue = cgiGet( cmbavUsergender_Internalname);
            AV56UserGender = cgiGet( cmbavUsergender_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56UserGender", AV56UserGender);
            AV68UserURLProfile = cgiGet( edtavUserurlprofile_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68UserURLProfile", AV68UserURLProfile);
            AV67UserURLImage = cgiGet( edtavUserurlimage_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67UserURLImage", AV67UserURLImage);
            AV58UserIsActive = StringUtil.StrToBool( cgiGet( chkavUserisactive_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58UserIsActive", AV58UserIsActive);
            if ( context.localUtil.VCDateTime( cgiGet( edtavUseractivationdate_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"User Activation Date"}), 1, "vUSERACTIVATIONDATE");
               GX_FocusControl = edtavUseractivationdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV47UserActivationDate = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47UserActivationDate", context.localUtil.TToC( AV47UserActivationDate, 10, 5, 0, 3, "/", ":", " "));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERACTIVATIONDATE", GetSecureSignedToken( "", context.localUtil.Format( AV47UserActivationDate, "99/99/9999 99:99"), context));
            }
            else
            {
               AV47UserActivationDate = context.localUtil.CToT( cgiGet( edtavUseractivationdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47UserActivationDate", context.localUtil.TToC( AV47UserActivationDate, 10, 5, 0, 3, "/", ":", " "));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERACTIVATIONDATE", GetSecureSignedToken( "", context.localUtil.Format( AV47UserActivationDate, "99/99/9999 99:99"), context));
            }
            AV60UserIsEnabledInRepository = StringUtil.StrToBool( cgiGet( chkavUserisenabledinrepository_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60UserIsEnabledInRepository", AV60UserIsEnabledInRepository);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERISENABLEDINREPOSITORY", GetSecureSignedToken( "", AV60UserIsEnabledInRepository, context));
            if ( context.localUtil.VCDateTime( cgiGet( edtavUserdatelasauthentication_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"User Date Las Authentication"}), 1, "vUSERDATELASAUTHENTICATION");
               GX_FocusControl = edtavUserdatelasauthentication_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV51UserDateLasAuthentication = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51UserDateLasAuthentication", context.localUtil.TToC( AV51UserDateLasAuthentication, 10, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV51UserDateLasAuthentication = context.localUtil.CToT( cgiGet( edtavUserdatelasauthentication_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51UserDateLasAuthentication", context.localUtil.TToC( AV51UserDateLasAuthentication, 10, 5, 0, 3, "/", ":", " "));
            }
            AV52UserDontReceiveInformation = StringUtil.StrToBool( cgiGet( chkavUserdontreceiveinformation_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52UserDontReceiveInformation", AV52UserDontReceiveInformation);
            AV59UserIsBlocked = StringUtil.StrToBool( cgiGet( chkavUserisblocked_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59UserIsBlocked", AV59UserIsBlocked);
            AV50UserCannotChangePassword = StringUtil.StrToBool( cgiGet( chkavUsercannotchangepassword_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50UserCannotChangePassword", AV50UserCannotChangePassword);
            AV62UserMustChangePassword = StringUtil.StrToBool( cgiGet( chkavUsermustchangepassword_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62UserMustChangePassword", AV62UserMustChangePassword);
            AV65UserPasswordNeverExpires = StringUtil.StrToBool( cgiGet( chkavUserpasswordneverexpires_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65UserPasswordNeverExpires", AV65UserPasswordNeverExpires);
            cmbavUsersecuritypolicyid.CurrentValue = cgiGet( cmbavUsersecuritypolicyid_Internalname);
            AV66UserSecurityPolicyId = (int)(NumberUtil.Val( cgiGet( cmbavUsersecuritypolicyid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66UserSecurityPolicyId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV66UserSecurityPolicyId), 9, 0)));
            AV43User.gxTpr_Isenabledinrepository = StringUtil.StrToBool( cgiGet( chkavUser_isenabledinrepository_Internalname));
            AV57UserGUID = cgiGet( edtavUserguid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57UserGUID", AV57UserGUID);
            AV45UserNameSpace = cgiGet( edtavUsernamespace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45UserNameSpace", AV45UserNameSpace);
            /* Read saved values. */
            Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
            Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
            Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
            Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
            Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
            Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
            Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
            Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
            Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
            Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = "hsh" + "GAMUserEntry";
            AV47UserActivationDate = context.localUtil.CToT( cgiGet( edtavUseractivationdate_Internalname), 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47UserActivationDate", context.localUtil.TToC( AV47UserActivationDate, 10, 5, 0, 3, "/", ":", " "));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERACTIVATIONDATE", GetSecureSignedToken( "", context.localUtil.Format( AV47UserActivationDate, "99/99/9999 99:99"), context));
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV47UserActivationDate, "99/99/9999 99:99");
            AV60UserIsEnabledInRepository = StringUtil.StrToBool( cgiGet( chkavUserisenabledinrepository_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60UserIsEnabledInRepository", AV60UserIsEnabledInRepository);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERISENABLEDINREPOSITORY", GetSecureSignedToken( "", AV60UserIsEnabledInRepository, context));
            forbiddenHiddens = forbiddenHiddens + StringUtil.BoolToStr( AV60UserIsEnabledInRepository);
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("gamuserentry:[SecurityCheckFailed value for]"+"UserActivationDate:"+context.localUtil.Format( AV47UserActivationDate, "99/99/9999 99:99"));
               GXUtil.WriteLog("gamuserentry:[SecurityCheckFailed value for]"+"UserIsEnabledInRepository:"+StringUtil.BoolToStr( AV60UserIsEnabledInRepository));
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
         E110J2 ();
         if (returnInSub) return;
      }

      protected void E110J2( )
      {
         /* Start Routine */
         AV37Repository = new SdtGAMRepository(context).get();
         cmbavUserauthenticationtypename.removeAllItems();
         AV8AuthenticationTypes = new SdtGAMRepository(context).getenabledauthenticationtypes(AV28Language, out  AV18Errors);
         AV80GXV2 = 1;
         while ( AV80GXV2 <= AV8AuthenticationTypes.Count )
         {
            AV9AuthenticationTypesIns = ((SdtGAMAuthenticationTypeSimple)AV8AuthenticationTypes.Item(AV80GXV2));
            cmbavUserauthenticationtypename.addItem(AV9AuthenticationTypesIns.gxTpr_Name, AV9AuthenticationTypesIns.gxTpr_Description, 0);
            AV80GXV2 = (int)(AV80GXV2+1);
         }
         AV38SecurityPolicies = new SdtGAMRepository(context).getsecuritypolicies(AV20FilterSecPol, out  AV18Errors);
         cmbavUsersecuritypolicyid.addItem("0", "(None)", 0);
         AV81GXV3 = 1;
         while ( AV81GXV3 <= AV38SecurityPolicies.Count )
         {
            AV39SecurityPolicy = ((SdtGAMSecurityPolicy)AV38SecurityPolicies.Item(AV81GXV3));
            cmbavUsersecuritypolicyid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV39SecurityPolicy.gxTpr_Id), 9, 0)), AV39SecurityPolicy.gxTpr_Name, 0);
            AV81GXV3 = (int)(AV81GXV3+1);
         }
         bttBtnenableuserinrepo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenableuserinrepo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnenableuserinrepo_Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            cmbavUserauthenticationtypename.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavUserauthenticationtypename_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavUserauthenticationtypename.Enabled), 5, 0)), true);
            AV48UserAuthenticationTypeName = "local";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48UserAuthenticationTypeName", AV48UserAuthenticationTypeName);
            AV45UserNameSpace = AV37Repository.gxTpr_Namespace;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45UserNameSpace", AV45UserNameSpace);
         }
         else
         {
            AV43User.load( AV44UserId);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44UserId", AV44UserId);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV44UserId, "")), context));
            AV57UserGUID = AV43User.gxTpr_Guid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57UserGUID", AV57UserGUID);
            AV45UserNameSpace = AV43User.gxTpr_Namespace;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45UserNameSpace", AV45UserNameSpace);
            AV48UserAuthenticationTypeName = AV43User.gxTpr_Authenticationtypename;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48UserAuthenticationTypeName", AV48UserAuthenticationTypeName);
            AV63UserName = AV43User.gxTpr_Name;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63UserName", AV63UserName);
            AV53UserEmail = AV43User.gxTpr_Email;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53UserEmail", AV53UserEmail);
            AV55UserFirstName = AV43User.gxTpr_Firstname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55UserFirstName", AV55UserFirstName);
            AV61UserLastName = AV43User.gxTpr_Lastname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61UserLastName", AV61UserLastName);
            AV54UserExternalId = AV43User.gxTpr_Externalid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54UserExternalId", AV54UserExternalId);
            AV49UserBirthday = AV43User.gxTpr_Birthday;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49UserBirthday", context.localUtil.Format(AV49UserBirthday, "99/99/9999"));
            AV56UserGender = AV43User.gxTpr_Gender;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56UserGender", AV56UserGender);
            AV68UserURLProfile = AV43User.gxTpr_Urlprofile;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68UserURLProfile", AV68UserURLProfile);
            AV67UserURLImage = AV43User.gxTpr_Urlimage;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67UserURLImage", AV67UserURLImage);
            AV58UserIsActive = AV43User.gxTpr_Isactive;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58UserIsActive", AV58UserIsActive);
            AV47UserActivationDate = AV43User.gxTpr_Activationdate;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47UserActivationDate", context.localUtil.TToC( AV47UserActivationDate, 10, 5, 0, 3, "/", ":", " "));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERACTIVATIONDATE", GetSecureSignedToken( "", context.localUtil.Format( AV47UserActivationDate, "99/99/9999 99:99"), context));
            AV60UserIsEnabledInRepository = AV43User.gxTpr_Isenabledinrepository;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60UserIsEnabledInRepository", AV60UserIsEnabledInRepository);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERISENABLEDINREPOSITORY", GetSecureSignedToken( "", AV60UserIsEnabledInRepository, context));
            AV52UserDontReceiveInformation = AV43User.gxTpr_Dontreceiveinformation;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52UserDontReceiveInformation", AV52UserDontReceiveInformation);
            AV59UserIsBlocked = AV43User.gxTpr_Isblocked;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59UserIsBlocked", AV59UserIsBlocked);
            AV50UserCannotChangePassword = AV43User.gxTpr_Cannotchangepassword;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50UserCannotChangePassword", AV50UserCannotChangePassword);
            AV62UserMustChangePassword = AV43User.gxTpr_Mustchangepassword;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62UserMustChangePassword", AV62UserMustChangePassword);
            AV65UserPasswordNeverExpires = AV43User.gxTpr_Passwordneverexpires;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65UserPasswordNeverExpires", AV65UserPasswordNeverExpires);
            AV66UserSecurityPolicyId = AV43User.gxTpr_Securitypolicyid;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66UserSecurityPolicyId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV66UserSecurityPolicyId), 9, 0)));
            AV64UserPassword = AV43User.gxTpr_Password;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64UserPassword", AV64UserPassword);
            AV51UserDateLasAuthentication = AV43User.gxTpr_Datelastauthentication;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51UserDateLasAuthentication", context.localUtil.TToC( AV51UserDateLasAuthentication, 10, 5, 0, 3, "/", ":", " "));
            cmbavUserauthenticationtypename.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavUserauthenticationtypename_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavUserauthenticationtypename.Enabled), 5, 0)), true);
            AV10AuthTypeId = AV6AuthenticationType.gettypebyname(AV7AuthenticationTypeName, out  AV18Errors);
            if ( StringUtil.StrCmp(AV10AuthTypeId, "GAMLocal") == 0 )
            {
               edtavUsername_Enabled = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsername_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsername_Enabled), 5, 0)), true);
            }
            else
            {
               edtavUsername_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsername_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsername_Enabled), 5, 0)), true);
            }
            bttBtnenableuserinrepo_Caption = (AV60UserIsEnabledInRepository ? "Disable" : "Enable");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenableuserinrepo_Internalname, "Caption", bttBtnenableuserinrepo_Caption, true);
         }
         if ( AV24IsActive )
         {
            chkavUserisactive.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserisactive_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUserisactive.Enabled), 5, 0)), true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtnenter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnenter_Visible), 5, 0)), true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            bttBtnenableuserinrepo_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenableuserinrepo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnenableuserinrepo_Visible), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            edtavUsername_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsername_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsername_Enabled), 5, 0)), true);
            edtavUseremail_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUseremail_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUseremail_Enabled), 5, 0)), true);
            edtavUserfirstname_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserfirstname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserfirstname_Enabled), 5, 0)), true);
            edtavUserlastname_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserlastname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserlastname_Enabled), 5, 0)), true);
            edtavUserurlprofile_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserurlprofile_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserurlprofile_Enabled), 5, 0)), true);
            edtavUserurlimage_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserurlimage_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserurlimage_Enabled), 5, 0)), true);
            edtavUserexternalid_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserexternalid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserexternalid_Enabled), 5, 0)), true);
            edtavUserbirthday_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserbirthday_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserbirthday_Enabled), 5, 0)), true);
            cmbavUsergender.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavUsergender_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavUsergender.Enabled), 5, 0)), true);
            chkavUserisactive.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserisactive_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUserisactive.Enabled), 5, 0)), true);
            chkavUserdontreceiveinformation.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserdontreceiveinformation_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUserdontreceiveinformation.Enabled), 5, 0)), true);
            chkavUsercannotchangepassword.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUsercannotchangepassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUsercannotchangepassword.Enabled), 5, 0)), true);
            chkavUsermustchangepassword.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUsermustchangepassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUsermustchangepassword.Enabled), 5, 0)), true);
            chkavUserisblocked.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserisblocked_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUserisblocked.Enabled), 5, 0)), true);
            chkavUserpasswordneverexpires.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserpasswordneverexpires_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUserpasswordneverexpires.Enabled), 5, 0)), true);
            cmbavUsersecuritypolicyid.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavUsersecuritypolicyid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavUsersecuritypolicyid.Enabled), 5, 0)), true);
            bttBtnenter_Caption = "Delete";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenter_Internalname, "Caption", bttBtnenter_Caption, true);
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
         chkavUser_isenabledinrepository.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUser_isenabledinrepository_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUser_isenabledinrepository.Visible), 5, 0)), true);
         edtavUserguid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserguid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserguid_Visible), 5, 0)), true);
         edtavUsernamespace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsernamespace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsernamespace_Visible), 5, 0)), true);
      }

      protected void E120J2( )
      {
         /* 'DoEnableUserinRepo' Routine */
         AV43User.load( AV44UserId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44UserId", AV44UserId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV44UserId, "")), context));
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            if ( AV60UserIsEnabledInRepository )
            {
               AV27isOK = AV43User.repositorydisable(out  AV18Errors);
            }
            else
            {
               AV27isOK = AV43User.repositoryenable(out  AV18Errors);
            }
            if ( ! AV27isOK )
            {
               AV82GXV4 = 1;
               while ( AV82GXV4 <= AV18Errors.Count )
               {
                  AV17Error = ((SdtGAMError)AV18Errors.Item(AV82GXV4));
                  GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV17Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
                  AV82GXV4 = (int)(AV82GXV4+1);
               }
            }
            else
            {
               pr_gam.commit( "GAMUserEntry");
               pr_default.commit( "GAMUserEntry");
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43User", AV43User);
      }

      protected void S122( )
      {
         /* 'CHECKREQUIREDFIELDS' Routine */
         AV37Repository = new SdtGAMRepository(context).get();
         AV46CheckRequiredFieldsResult = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46CheckRequiredFieldsResult", AV46CheckRequiredFieldsResult);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV63UserName)) )
         {
            GX_msglist.addItem("User Name é obrigatório.");
            AV46CheckRequiredFieldsResult = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46CheckRequiredFieldsResult", AV46CheckRequiredFieldsResult);
         }
         if ( ( AV37Repository.gxTpr_Requiredemail ) && String.IsNullOrEmpty(StringUtil.RTrim( AV53UserEmail)) )
         {
            GX_msglist.addItem("Email é obrigatório.");
            AV46CheckRequiredFieldsResult = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46CheckRequiredFieldsResult", AV46CheckRequiredFieldsResult);
         }
         if ( ( AV37Repository.gxTpr_Requiredfirstname ) && String.IsNullOrEmpty(StringUtil.RTrim( AV55UserFirstName)) )
         {
            GX_msglist.addItem("First Name é obrigatório.");
            AV46CheckRequiredFieldsResult = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46CheckRequiredFieldsResult", AV46CheckRequiredFieldsResult);
         }
         if ( ( AV37Repository.gxTpr_Requiredlastname ) && String.IsNullOrEmpty(StringUtil.RTrim( AV61UserLastName)) )
         {
            GX_msglist.addItem("Last Name é obrigatório.");
            AV46CheckRequiredFieldsResult = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46CheckRequiredFieldsResult", AV46CheckRequiredFieldsResult);
         }
         if ( ( AV37Repository.gxTpr_Requiredpassword && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV64UserPassword)) )
         {
            GX_msglist.addItem("Password é obrigatório.");
            AV46CheckRequiredFieldsResult = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46CheckRequiredFieldsResult", AV46CheckRequiredFieldsResult);
         }
         if ( ( AV37Repository.gxTpr_Requiredbirthday ) && (DateTime.MinValue==AV49UserBirthday) )
         {
            GX_msglist.addItem("Birthday é obrigatório.");
            AV46CheckRequiredFieldsResult = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46CheckRequiredFieldsResult", AV46CheckRequiredFieldsResult);
         }
         if ( ( AV37Repository.gxTpr_Requiredgender ) && String.IsNullOrEmpty(StringUtil.RTrim( AV56UserGender)) )
         {
            GX_msglist.addItem("Gender é obrigatório.");
            AV46CheckRequiredFieldsResult = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46CheckRequiredFieldsResult", AV46CheckRequiredFieldsResult);
         }
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         AV37Repository = new SdtGAMRepository(context).get();
         AV10AuthTypeId = AV6AuthenticationType.gettypebyname(AV48UserAuthenticationTypeName, out  AV18Errors);
         if ( ! ( ( cmbavUserauthenticationtypename.ItemCount > 1 ) ) )
         {
            cmbavUserauthenticationtypename.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavUserauthenticationtypename_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavUserauthenticationtypename.Visible), 5, 0)), true);
            divUserauthenticationtypename_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserauthenticationtypename_cell_Internalname, "Class", divUserauthenticationtypename_cell_Class, true);
         }
         else
         {
            cmbavUserauthenticationtypename.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavUserauthenticationtypename_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavUserauthenticationtypename.Visible), 5, 0)), true);
            divUserauthenticationtypename_cell_Class = "col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserauthenticationtypename_cell_Internalname, "Class", divUserauthenticationtypename_cell_Class, true);
         }
         if ( AV37Repository.gxTpr_Requiredemail )
         {
            divUseremail_cell_Class = "col-sm-6 RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUseremail_cell_Internalname, "Class", divUseremail_cell_Class, true);
         }
         else
         {
            divUseremail_cell_Class = "col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUseremail_cell_Internalname, "Class", divUseremail_cell_Class, true);
         }
         if ( AV37Repository.gxTpr_Requiredfirstname )
         {
            divUserfirstname_cell_Class = "col-sm-6 RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserfirstname_cell_Internalname, "Class", divUserfirstname_cell_Class, true);
         }
         else
         {
            divUserfirstname_cell_Class = "col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserfirstname_cell_Internalname, "Class", divUserfirstname_cell_Class, true);
         }
         if ( AV37Repository.gxTpr_Requiredlastname )
         {
            divUserlastname_cell_Class = "col-sm-6 RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserlastname_cell_Internalname, "Class", divUserlastname_cell_Class, true);
         }
         else
         {
            divUserlastname_cell_Class = "col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserlastname_cell_Internalname, "Class", divUserlastname_cell_Class, true);
         }
         if ( ! ( ( StringUtil.StrCmp(AV10AuthTypeId, "GAMLocal") == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) )
         {
            edtavUserpassword_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserpassword_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserpassword_Visible), 5, 0)), true);
            divUserpassword_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserpassword_cell_Internalname, "Class", divUserpassword_cell_Class, true);
         }
         else
         {
            edtavUserpassword_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserpassword_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserpassword_Visible), 5, 0)), true);
            if ( AV37Repository.gxTpr_Requiredpassword && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
            {
               divUserpassword_cell_Class = "col-sm-6 RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserpassword_cell_Internalname, "Class", divUserpassword_cell_Class, true);
            }
            else
            {
               divUserpassword_cell_Class = "col-sm-6 DataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserpassword_cell_Internalname, "Class", divUserpassword_cell_Class, true);
            }
         }
         if ( ! ( ( StringUtil.StrCmp(AV10AuthTypeId, "GAMLocal") == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) )
         {
            edtavPasswordconf_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPasswordconf_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPasswordconf_Visible), 5, 0)), true);
            divPasswordconf_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divPasswordconf_cell_Internalname, "Class", divPasswordconf_cell_Class, true);
         }
         else
         {
            edtavPasswordconf_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPasswordconf_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPasswordconf_Visible), 5, 0)), true);
            divPasswordconf_cell_Class = "col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divPasswordconf_cell_Internalname, "Class", divPasswordconf_cell_Class, true);
         }
         if ( AV37Repository.gxTpr_Requiredbirthday )
         {
            divUserbirthday_cell_Class = "col-sm-6 RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserbirthday_cell_Internalname, "Class", divUserbirthday_cell_Class, true);
         }
         else
         {
            divUserbirthday_cell_Class = "col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserbirthday_cell_Internalname, "Class", divUserbirthday_cell_Class, true);
         }
         if ( AV37Repository.gxTpr_Requiredgender )
         {
            divUsergender_cell_Class = "col-sm-6 RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUsergender_cell_Internalname, "Class", divUsergender_cell_Class, true);
         }
         else
         {
            divUsergender_cell_Class = "col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUsergender_cell_Internalname, "Class", divUsergender_cell_Class, true);
         }
         if ( ! ( ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) ) )
         {
            edtavUserurlprofile_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserurlprofile_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserurlprofile_Visible), 5, 0)), true);
            divUserurlprofile_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserurlprofile_cell_Internalname, "Class", divUserurlprofile_cell_Class, true);
         }
         else
         {
            edtavUserurlprofile_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserurlprofile_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserurlprofile_Visible), 5, 0)), true);
            divUserurlprofile_cell_Class = "col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserurlprofile_cell_Internalname, "Class", divUserurlprofile_cell_Class, true);
         }
         if ( ! ( ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) ) )
         {
            edtavUserurlimage_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserurlimage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserurlimage_Visible), 5, 0)), true);
            divUserurlimage_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserurlimage_cell_Internalname, "Class", divUserurlimage_cell_Class, true);
         }
         else
         {
            edtavUserurlimage_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserurlimage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserurlimage_Visible), 5, 0)), true);
            divUserurlimage_cell_Class = "col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserurlimage_cell_Internalname, "Class", divUserurlimage_cell_Class, true);
         }
         if ( ! ( ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) ) )
         {
            chkavUserisactive.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserisactive_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUserisactive.Visible), 5, 0)), true);
            divUserisactive_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserisactive_cell_Internalname, "Class", divUserisactive_cell_Class, true);
         }
         else
         {
            chkavUserisactive.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserisactive_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUserisactive.Visible), 5, 0)), true);
            divUserisactive_cell_Class = "col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserisactive_cell_Internalname, "Class", divUserisactive_cell_Class, true);
         }
         if ( ! ( ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) ) )
         {
            edtavUseractivationdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUseractivationdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUseractivationdate_Visible), 5, 0)), true);
            divUseractivationdate_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUseractivationdate_cell_Internalname, "Class", divUseractivationdate_cell_Class, true);
         }
         else
         {
            edtavUseractivationdate_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUseractivationdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUseractivationdate_Visible), 5, 0)), true);
            divUseractivationdate_cell_Class = "col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUseractivationdate_cell_Internalname, "Class", divUseractivationdate_cell_Class, true);
         }
         if ( ! ( ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) ) )
         {
            chkavUserisenabledinrepository.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserisenabledinrepository_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUserisenabledinrepository.Visible), 5, 0)), true);
            cellUserisenabledinrepository_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellUserisenabledinrepository_cell_Internalname, "Class", cellUserisenabledinrepository_cell_Class, true);
            divTextblockuserisenabledinrepository_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTextblockuserisenabledinrepository_cell_Internalname, "Class", divTextblockuserisenabledinrepository_cell_Class, true);
         }
         else
         {
            chkavUserisenabledinrepository.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavUserisenabledinrepository_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavUserisenabledinrepository.Visible), 5, 0)), true);
            cellUserisenabledinrepository_cell_Class = "MergeDataCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellUserisenabledinrepository_cell_Internalname, "Class", cellUserisenabledinrepository_cell_Class, true);
            divTextblockuserisenabledinrepository_cell_Class = "col-sm-3 MergeLabelCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTextblockuserisenabledinrepository_cell_Internalname, "Class", divTextblockuserisenabledinrepository_cell_Class, true);
         }
         if ( ! ( ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) ) )
         {
            edtavUserdatelasauthentication_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserdatelasauthentication_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserdatelasauthentication_Visible), 5, 0)), true);
            divUserdatelasauthentication_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserdatelasauthentication_cell_Internalname, "Class", divUserdatelasauthentication_cell_Class, true);
         }
         else
         {
            edtavUserdatelasauthentication_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserdatelasauthentication_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUserdatelasauthentication_Visible), 5, 0)), true);
            divUserdatelasauthentication_cell_Class = "col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUserdatelasauthentication_cell_Internalname, "Class", divUserdatelasauthentication_cell_Class, true);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E130J2 ();
         if (returnInSub) return;
      }

      protected void E130J2( )
      {
         /* Enter Routine */
         /* Execute user subroutine: 'CHECKREQUIREDFIELDS' */
         S122 ();
         if (returnInSub) return;
         if ( AV46CheckRequiredFieldsResult )
         {
            AV43User.gxTpr_Guid = AV44UserId;
            AV34PasswordIsOK = true;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) )
            {
               if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
               {
                  AV69AuthenticationTypesI = new SdtGAMRepository(context).getenabledauthenticationtypes(AV28Language, out  AV18Errors);
                  AV83GXV5 = 1;
                  while ( AV83GXV5 <= AV69AuthenticationTypesI.Count )
                  {
                     AV9AuthenticationTypesIns = ((SdtGAMAuthenticationTypeSimple)AV69AuthenticationTypesI.Item(AV83GXV5));
                     if ( StringUtil.StrCmp(AV9AuthenticationTypesIns.gxTpr_Description, AV48UserAuthenticationTypeName) == 0 )
                     {
                        AV70UserAuthenticationTypeT = AV9AuthenticationTypesIns.gxTpr_Type;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70UserAuthenticationTypeT", AV70UserAuthenticationTypeT);
                     }
                     AV83GXV5 = (int)(AV83GXV5+1);
                  }
                  if ( StringUtil.StrCmp(AV70UserAuthenticationTypeT, "GAMLocal") == 0 )
                  {
                     if ( StringUtil.StrCmp(AV64UserPassword, AV33PasswordConf) != 0 )
                     {
                        AV34PasswordIsOK = false;
                        GX_msglist.addItem("The password and confirmation password do not match.");
                     }
                  }
                  else
                  {
                     AV32Password = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Password", AV32Password);
                  }
               }
               if ( AV34PasswordIsOK )
               {
                  AV43User.load( AV44UserId);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44UserId", AV44UserId);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV44UserId, "")), context));
                  AV43User.gxTpr_Authenticationtypename = AV48UserAuthenticationTypeName;
                  AV43User.gxTpr_Name = AV63UserName;
                  AV43User.gxTpr_Email = AV53UserEmail;
                  AV43User.gxTpr_Firstname = AV55UserFirstName;
                  AV43User.gxTpr_Lastname = AV61UserLastName;
                  AV43User.gxTpr_Externalid = AV54UserExternalId;
                  AV43User.gxTpr_Birthday = AV49UserBirthday;
                  AV43User.gxTpr_Gender = AV56UserGender;
                  AV43User.gxTpr_Urlprofile = AV68UserURLProfile;
                  AV43User.gxTpr_Urlimage = AV67UserURLImage;
                  AV43User.gxTpr_Isactive = AV58UserIsActive;
                  AV43User.gxTpr_Activationdate = AV47UserActivationDate;
                  AV43User.gxTpr_Isenabledinrepository = AV60UserIsEnabledInRepository;
                  AV43User.gxTpr_Dontreceiveinformation = AV52UserDontReceiveInformation;
                  AV43User.gxTpr_Isblocked = AV59UserIsBlocked;
                  AV43User.gxTpr_Cannotchangepassword = AV50UserCannotChangePassword;
                  AV43User.gxTpr_Mustchangepassword = AV62UserMustChangePassword;
                  AV43User.gxTpr_Passwordneverexpires = AV65UserPasswordNeverExpires;
                  AV43User.gxTpr_Securitypolicyid = AV66UserSecurityPolicyId;
                  AV43User.gxTpr_Password = AV64UserPassword;
                  AV43User.save();
               }
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               AV43User.delete();
            }
            if ( AV34PasswordIsOK )
            {
               if ( AV43User.success() )
               {
                  pr_gam.commit( "GAMUserEntry");
                  pr_default.commit( "GAMUserEntry");
                  context.setWebReturnParms(new Object[] {});
                  context.setWebReturnParmsMetadata(new Object[] {});
                  context.wjLocDisableFrm = 1;
                  context.nUserReturn = 1;
                  returnInSub = true;
                  if (true) return;
               }
               else
               {
                  AV18Errors = AV43User.geterrors();
                  AV84GXV6 = 1;
                  while ( AV84GXV6 <= AV18Errors.Count )
                  {
                     AV17Error = ((SdtGAMError)AV18Errors.Item(AV84GXV6));
                     GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV17Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
                     AV84GXV6 = (int)(AV84GXV6+1);
                  }
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43User", AV43User);
      }

      protected void E140J2( )
      {
         /* Userauthenticationtypename_Isvalid Routine */
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E150J2( )
      {
         /* Refresh Routine */
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            edtavUserurlprofile_Linktarget = "_blank";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserurlprofile_Internalname, "Linktarget", edtavUserurlprofile_Linktarget, true);
            edtavUserurlprofile_Link = formatLink(AV68UserURLProfile) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUserurlprofile_Internalname, "Link", edtavUserurlprofile_Link, true);
         }
         /*  Sending Event outputs  */
      }

      protected void nextLoad( )
      {
      }

      protected void E160J2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_91_0J2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergeduserisenabledinrepository_Internalname, tblTablemergeduserisenabledinrepository_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellUserisenabledinrepository_cell_Internalname+"\"  class='"+cellUserisenabledinrepository_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavUserisenabledinrepository_Internalname, "User Is Enabled In Repository", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavUserisenabledinrepository_Internalname, StringUtil.BoolToStr( AV60UserIsEnabledInRepository), "", "User Is Enabled In Repository", chkavUserisenabledinrepository.Visible, chkavUserisenabledinrepository.Enabled, "true", "Is enabled in repository?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(95, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,95);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenableuserinrepo_Internalname, "", bttBtnenableuserinrepo_Caption, bttBtnenableuserinrepo_Jsonclick, 5, "Enable", "", StyleString, ClassString, bttBtnenableuserinrepo_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOENABLEUSERINREPO\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMUserEntry.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_91_0J2e( true) ;
         }
         else
         {
            wb_table1_91_0J2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         Gx_mode = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         AV44UserId = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44UserId", AV44UserId);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERID", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV44UserId, "")), context));
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
         PA0J2( ) ;
         WS0J2( ) ;
         WE0J2( ) ;
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
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019404899", true);
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
         context.AddJavascriptSource("gamuserentry.js", "?20189201940494", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
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
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         cmbavUserauthenticationtypename_Internalname = "vUSERAUTHENTICATIONTYPENAME";
         divUserauthenticationtypename_cell_Internalname = "USERAUTHENTICATIONTYPENAME_CELL";
         edtavUsername_Internalname = "vUSERNAME";
         edtavUseremail_Internalname = "vUSEREMAIL";
         divUseremail_cell_Internalname = "USEREMAIL_CELL";
         edtavUserfirstname_Internalname = "vUSERFIRSTNAME";
         divUserfirstname_cell_Internalname = "USERFIRSTNAME_CELL";
         edtavUserlastname_Internalname = "vUSERLASTNAME";
         divUserlastname_cell_Internalname = "USERLASTNAME_CELL";
         edtavUserpassword_Internalname = "vUSERPASSWORD";
         divUserpassword_cell_Internalname = "USERPASSWORD_CELL";
         edtavPasswordconf_Internalname = "vPASSWORDCONF";
         divPasswordconf_cell_Internalname = "PASSWORDCONF_CELL";
         edtavUserexternalid_Internalname = "vUSEREXTERNALID";
         edtavUserbirthday_Internalname = "vUSERBIRTHDAY";
         divUserbirthday_cell_Internalname = "USERBIRTHDAY_CELL";
         cmbavUsergender_Internalname = "vUSERGENDER";
         divUsergender_cell_Internalname = "USERGENDER_CELL";
         edtavUserurlprofile_Internalname = "vUSERURLPROFILE";
         divUserurlprofile_cell_Internalname = "USERURLPROFILE_CELL";
         edtavUserurlimage_Internalname = "vUSERURLIMAGE";
         divUserurlimage_cell_Internalname = "USERURLIMAGE_CELL";
         chkavUserisactive_Internalname = "vUSERISACTIVE";
         divUserisactive_cell_Internalname = "USERISACTIVE_CELL";
         edtavUseractivationdate_Internalname = "vUSERACTIVATIONDATE";
         divUseractivationdate_cell_Internalname = "USERACTIVATIONDATE_CELL";
         lblTextblockuserisenabledinrepository_Internalname = "TEXTBLOCKUSERISENABLEDINREPOSITORY";
         divTextblockuserisenabledinrepository_cell_Internalname = "TEXTBLOCKUSERISENABLEDINREPOSITORY_CELL";
         chkavUserisenabledinrepository_Internalname = "vUSERISENABLEDINREPOSITORY";
         cellUserisenabledinrepository_cell_Internalname = "USERISENABLEDINREPOSITORY_CELL";
         bttBtnenableuserinrepo_Internalname = "BTNENABLEUSERINREPO";
         tblTablemergeduserisenabledinrepository_Internalname = "TABLEMERGEDUSERISENABLEDINREPOSITORY";
         divTablesplitteduserisenabledinrepository_Internalname = "TABLESPLITTEDUSERISENABLEDINREPOSITORY";
         edtavUserdatelasauthentication_Internalname = "vUSERDATELASAUTHENTICATION";
         divUserdatelasauthentication_cell_Internalname = "USERDATELASAUTHENTICATION_CELL";
         chkavUserdontreceiveinformation_Internalname = "vUSERDONTRECEIVEINFORMATION";
         chkavUserisblocked_Internalname = "vUSERISBLOCKED";
         chkavUsercannotchangepassword_Internalname = "vUSERCANNOTCHANGEPASSWORD";
         chkavUsermustchangepassword_Internalname = "vUSERMUSTCHANGEPASSWORD";
         chkavUserpasswordneverexpires_Internalname = "vUSERPASSWORDNEVEREXPIRES";
         cmbavUsersecuritypolicyid_Internalname = "vUSERSECURITYPOLICYID";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         chkavUser_isenabledinrepository_Internalname = "USER_ISENABLEDINREPOSITORY";
         edtavUserguid_Internalname = "vUSERGUID";
         edtavUsernamespace_Internalname = "vUSERNAMESPACE";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
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
         bttBtnenableuserinrepo_Visible = 1;
         chkavUserisenabledinrepository.Enabled = 1;
         cellUserisenabledinrepository_cell_Class = "";
         chkavUserisenabledinrepository.Visible = 1;
         bttBtnenableuserinrepo_Caption = "Enable";
         chkavUser_isenabledinrepository.Caption = "";
         chkavUserpasswordneverexpires.Caption = " ";
         chkavUsermustchangepassword.Caption = " ";
         chkavUsercannotchangepassword.Caption = " ";
         chkavUserisblocked.Caption = " ";
         chkavUserdontreceiveinformation.Caption = " ";
         chkavUserisenabledinrepository.Caption = "User Is Enabled In Repository";
         chkavUserisactive.Caption = " ";
         edtavUsernamespace_Jsonclick = "";
         edtavUsernamespace_Visible = 1;
         edtavUserguid_Jsonclick = "";
         edtavUserguid_Visible = 1;
         chkavUser_isenabledinrepository.Visible = 1;
         bttBtnenter_Caption = "Confirmar";
         bttBtnenter_Visible = 1;
         cmbavUsersecuritypolicyid_Jsonclick = "";
         cmbavUsersecuritypolicyid.Enabled = 1;
         chkavUserpasswordneverexpires.Enabled = 1;
         chkavUsermustchangepassword.Enabled = 1;
         chkavUsercannotchangepassword.Enabled = 1;
         chkavUserisblocked.Enabled = 1;
         chkavUserdontreceiveinformation.Enabled = 1;
         edtavUserdatelasauthentication_Jsonclick = "";
         edtavUserdatelasauthentication_Enabled = 1;
         edtavUserdatelasauthentication_Visible = 1;
         divUserdatelasauthentication_cell_Class = "col-xs-12 col-sm-6";
         divTextblockuserisenabledinrepository_cell_Class = "col-xs-12 col-sm-3";
         edtavUseractivationdate_Jsonclick = "";
         edtavUseractivationdate_Enabled = 1;
         edtavUseractivationdate_Visible = 1;
         divUseractivationdate_cell_Class = "col-xs-12 col-sm-6";
         chkavUserisactive.Enabled = 1;
         chkavUserisactive.Visible = 1;
         divUserisactive_cell_Class = "col-xs-12 col-sm-6";
         edtavUserurlimage_Jsonclick = "";
         edtavUserurlimage_Enabled = 1;
         edtavUserurlimage_Visible = 1;
         divUserurlimage_cell_Class = "col-xs-12 col-sm-6";
         edtavUserurlprofile_Jsonclick = "";
         edtavUserurlprofile_Linktarget = "";
         edtavUserurlprofile_Link = "";
         edtavUserurlprofile_Enabled = 1;
         edtavUserurlprofile_Visible = 1;
         divUserurlprofile_cell_Class = "col-xs-12 col-sm-6";
         cmbavUsergender_Jsonclick = "";
         cmbavUsergender.Enabled = 1;
         divUsergender_cell_Class = "col-xs-12 col-sm-6";
         edtavUserbirthday_Jsonclick = "";
         edtavUserbirthday_Enabled = 1;
         divUserbirthday_cell_Class = "col-xs-12 col-sm-6";
         edtavUserexternalid_Jsonclick = "";
         edtavUserexternalid_Enabled = 1;
         edtavPasswordconf_Jsonclick = "";
         edtavPasswordconf_Enabled = 1;
         edtavPasswordconf_Visible = 1;
         divPasswordconf_cell_Class = "col-xs-12 col-sm-6";
         edtavUserpassword_Jsonclick = "";
         edtavUserpassword_Enabled = 1;
         edtavUserpassword_Visible = 1;
         divUserpassword_cell_Class = "col-xs-12 col-sm-6";
         edtavUserlastname_Jsonclick = "";
         edtavUserlastname_Enabled = 1;
         divUserlastname_cell_Class = "col-xs-12 col-sm-6";
         edtavUserfirstname_Jsonclick = "";
         edtavUserfirstname_Enabled = 1;
         divUserfirstname_cell_Class = "col-xs-12 col-sm-6";
         edtavUseremail_Jsonclick = "";
         edtavUseremail_Enabled = 1;
         divUseremail_cell_Class = "col-xs-12 col-sm-6";
         edtavUsername_Jsonclick = "";
         edtavUsername_Enabled = 1;
         cmbavUserauthenticationtypename_Jsonclick = "";
         cmbavUserauthenticationtypename.Enabled = 1;
         cmbavUserauthenticationtypename.Visible = 1;
         divUserauthenticationtypename_cell_Class = "col-xs-12 col-sm-6";
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "User";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "User ";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV68UserURLProfile',fld:'vUSERURLPROFILE',pic:'',nv:''},{av:'AV44UserId',fld:'vUSERID',pic:'',hsh:true,nv:''},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV60UserIsEnabledInRepository',fld:'vUSERISENABLEDINREPOSITORY',pic:'',hsh:true,nv:false},{av:'AV47UserActivationDate',fld:'vUSERACTIVATIONDATE',pic:'99/99/9999 99:99',hsh:true,nv:''}],oparms:[{av:'edtavUserurlprofile_Linktarget',ctrl:'vUSERURLPROFILE',prop:'Linktarget'},{av:'edtavUserurlprofile_Link',ctrl:'vUSERURLPROFILE',prop:'Link'}]}");
         setEventMetadata("'DOENABLEUSERINREPO'","{handler:'E120J2',iparms:[{av:'AV44UserId',fld:'vUSERID',pic:'',hsh:true,nv:''},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV60UserIsEnabledInRepository',fld:'vUSERISENABLEDINREPOSITORY',pic:'',hsh:true,nv:false}],oparms:[]}");
         setEventMetadata("ENTER","{handler:'E130J2',iparms:[{av:'AV46CheckRequiredFieldsResult',fld:'vCHECKREQUIREDFIELDSRESULT',pic:'',nv:false},{av:'AV44UserId',fld:'vUSERID',pic:'',hsh:true,nv:''},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV28Language',fld:'vLANGUAGE',pic:'',nv:''},{av:'cmbavUserauthenticationtypename'},{av:'AV48UserAuthenticationTypeName',fld:'vUSERAUTHENTICATIONTYPENAME',pic:'',nv:''},{av:'AV70UserAuthenticationTypeT',fld:'vUSERAUTHENTICATIONTYPET',pic:'',nv:''},{av:'AV64UserPassword',fld:'vUSERPASSWORD',pic:'',nv:''},{av:'AV33PasswordConf',fld:'vPASSWORDCONF',pic:'',nv:''},{av:'AV32Password',fld:'vPASSWORD',pic:'',nv:''},{av:'AV63UserName',fld:'vUSERNAME',pic:'',nv:''},{av:'AV53UserEmail',fld:'vUSEREMAIL',pic:'',nv:''},{av:'AV55UserFirstName',fld:'vUSERFIRSTNAME',pic:'',nv:''},{av:'AV61UserLastName',fld:'vUSERLASTNAME',pic:'',nv:''},{av:'AV54UserExternalId',fld:'vUSEREXTERNALID',pic:'',nv:''},{av:'AV49UserBirthday',fld:'vUSERBIRTHDAY',pic:'',nv:''},{av:'cmbavUsergender'},{av:'AV56UserGender',fld:'vUSERGENDER',pic:'',nv:''},{av:'AV68UserURLProfile',fld:'vUSERURLPROFILE',pic:'',nv:''},{av:'AV67UserURLImage',fld:'vUSERURLIMAGE',pic:'',nv:''},{av:'AV58UserIsActive',fld:'vUSERISACTIVE',pic:'',nv:false},{av:'AV47UserActivationDate',fld:'vUSERACTIVATIONDATE',pic:'99/99/9999 99:99',hsh:true,nv:''},{av:'AV60UserIsEnabledInRepository',fld:'vUSERISENABLEDINREPOSITORY',pic:'',hsh:true,nv:false},{av:'AV52UserDontReceiveInformation',fld:'vUSERDONTRECEIVEINFORMATION',pic:'',nv:false},{av:'AV59UserIsBlocked',fld:'vUSERISBLOCKED',pic:'',nv:false},{av:'AV50UserCannotChangePassword',fld:'vUSERCANNOTCHANGEPASSWORD',pic:'',nv:false},{av:'AV62UserMustChangePassword',fld:'vUSERMUSTCHANGEPASSWORD',pic:'',nv:false},{av:'AV65UserPasswordNeverExpires',fld:'vUSERPASSWORDNEVEREXPIRES',pic:'',nv:false},{av:'cmbavUsersecuritypolicyid'},{av:'AV66UserSecurityPolicyId',fld:'vUSERSECURITYPOLICYID',pic:'ZZZZZZZZ9',nv:0}],oparms:[{av:'AV70UserAuthenticationTypeT',fld:'vUSERAUTHENTICATIONTYPET',pic:'',nv:''},{av:'AV32Password',fld:'vPASSWORD',pic:'',nv:''},{av:'AV46CheckRequiredFieldsResult',fld:'vCHECKREQUIREDFIELDSRESULT',pic:'',nv:false}]}");
         setEventMetadata("VUSERAUTHENTICATIONTYPENAME.ISVALID","{handler:'E140J2',iparms:[{av:'cmbavUserauthenticationtypename'},{av:'AV48UserAuthenticationTypeName',fld:'vUSERAUTHENTICATIONTYPENAME',pic:'',nv:''},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''}],oparms:[{av:'cmbavUserauthenticationtypename'},{av:'divUserauthenticationtypename_cell_Class',ctrl:'USERAUTHENTICATIONTYPENAME_CELL',prop:'Class'},{av:'divUseremail_cell_Class',ctrl:'USEREMAIL_CELL',prop:'Class'},{av:'divUserfirstname_cell_Class',ctrl:'USERFIRSTNAME_CELL',prop:'Class'},{av:'divUserlastname_cell_Class',ctrl:'USERLASTNAME_CELL',prop:'Class'},{av:'edtavUserpassword_Visible',ctrl:'vUSERPASSWORD',prop:'Visible'},{av:'divUserpassword_cell_Class',ctrl:'USERPASSWORD_CELL',prop:'Class'},{av:'edtavPasswordconf_Visible',ctrl:'vPASSWORDCONF',prop:'Visible'},{av:'divPasswordconf_cell_Class',ctrl:'PASSWORDCONF_CELL',prop:'Class'},{av:'divUserbirthday_cell_Class',ctrl:'USERBIRTHDAY_CELL',prop:'Class'},{av:'divUsergender_cell_Class',ctrl:'USERGENDER_CELL',prop:'Class'},{av:'edtavUserurlprofile_Visible',ctrl:'vUSERURLPROFILE',prop:'Visible'},{av:'divUserurlprofile_cell_Class',ctrl:'USERURLPROFILE_CELL',prop:'Class'},{av:'edtavUserurlimage_Visible',ctrl:'vUSERURLIMAGE',prop:'Visible'},{av:'divUserurlimage_cell_Class',ctrl:'USERURLIMAGE_CELL',prop:'Class'},{av:'chkavUserisactive.Visible',ctrl:'vUSERISACTIVE',prop:'Visible'},{av:'divUserisactive_cell_Class',ctrl:'USERISACTIVE_CELL',prop:'Class'},{av:'edtavUseractivationdate_Visible',ctrl:'vUSERACTIVATIONDATE',prop:'Visible'},{av:'divUseractivationdate_cell_Class',ctrl:'USERACTIVATIONDATE_CELL',prop:'Class'},{av:'chkavUserisenabledinrepository.Visible',ctrl:'vUSERISENABLEDINREPOSITORY',prop:'Visible'},{av:'cellUserisenabledinrepository_cell_Class',ctrl:'USERISENABLEDINREPOSITORY_CELL',prop:'Class'},{av:'divTextblockuserisenabledinrepository_cell_Class',ctrl:'TEXTBLOCKUSERISENABLEDINREPOSITORY_CELL',prop:'Class'},{av:'edtavUserdatelasauthentication_Visible',ctrl:'vUSERDATELASAUTHENTICATION',prop:'Visible'},{av:'divUserdatelasauthentication_cell_Class',ctrl:'USERDATELASAUTHENTICATION_CELL',prop:'Class'}]}");
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
         wcpOGx_mode = "";
         wcpOAV44UserId = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV47UserActivationDate = (DateTime)(DateTime.MinValue);
         GXKey = "";
         forbiddenHiddens = "";
         AV28Language = "";
         AV70UserAuthenticationTypeT = "";
         AV32Password = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         AV48UserAuthenticationTypeName = "";
         AV63UserName = "";
         AV53UserEmail = "";
         AV55UserFirstName = "";
         AV61UserLastName = "";
         AV64UserPassword = "";
         AV33PasswordConf = "";
         AV54UserExternalId = "";
         AV49UserBirthday = DateTime.MinValue;
         AV56UserGender = "";
         AV68UserURLProfile = "";
         AV67UserURLImage = "";
         lblTextblockuserisenabledinrepository_Jsonclick = "";
         AV51UserDateLasAuthentication = (DateTime)(DateTime.MinValue);
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         AV43User = new SdtGAMUser(context);
         AV57UserGUID = "";
         AV45UserNameSpace = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         hsh = "";
         AV37Repository = new SdtGAMRepository(context);
         AV8AuthenticationTypes = new GXExternalCollection<SdtGAMAuthenticationTypeSimple>( context, "SdtGAMAuthenticationTypeSimple", "GeneXus.Programs");
         AV18Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV9AuthenticationTypesIns = new SdtGAMAuthenticationTypeSimple(context);
         AV38SecurityPolicies = new GXExternalCollection<SdtGAMSecurityPolicy>( context, "SdtGAMSecurityPolicy", "GeneXus.Programs");
         AV20FilterSecPol = new SdtGAMSecurityPolicyFilter(context);
         AV39SecurityPolicy = new SdtGAMSecurityPolicy(context);
         AV10AuthTypeId = "";
         AV7AuthenticationTypeName = "";
         AV6AuthenticationType = new SdtGAMAuthenticationType(context);
         AV17Error = new SdtGAMError(context);
         AV69AuthenticationTypesI = new GXExternalCollection<SdtGAMAuthenticationTypeSimple>( context, "SdtGAMAuthenticationTypeSimple", "GeneXus.Programs");
         sStyleString = "";
         bttBtnenableuserinrepo_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamuserentry__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamuserentry__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavUseractivationdate_Enabled = 0;
         chkavUserisenabledinrepository.Enabled = 0;
         edtavUserdatelasauthentication_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavUsername_Enabled ;
      private int edtavUseremail_Enabled ;
      private int edtavUserfirstname_Enabled ;
      private int edtavUserlastname_Enabled ;
      private int edtavUserpassword_Visible ;
      private int edtavUserpassword_Enabled ;
      private int edtavPasswordconf_Visible ;
      private int edtavPasswordconf_Enabled ;
      private int edtavUserexternalid_Enabled ;
      private int edtavUserbirthday_Enabled ;
      private int edtavUserurlprofile_Visible ;
      private int edtavUserurlprofile_Enabled ;
      private int edtavUserurlimage_Visible ;
      private int edtavUserurlimage_Enabled ;
      private int edtavUseractivationdate_Visible ;
      private int edtavUseractivationdate_Enabled ;
      private int edtavUserdatelasauthentication_Visible ;
      private int edtavUserdatelasauthentication_Enabled ;
      private int AV66UserSecurityPolicyId ;
      private int bttBtnenter_Visible ;
      private int edtavUserguid_Visible ;
      private int edtavUsernamespace_Visible ;
      private int AV80GXV2 ;
      private int AV81GXV3 ;
      private int bttBtnenableuserinrepo_Visible ;
      private int AV82GXV4 ;
      private int AV83GXV5 ;
      private int AV84GXV6 ;
      private int idxLst ;
      private String Gx_mode ;
      private String AV44UserId ;
      private String wcpOGx_mode ;
      private String wcpOAV44UserId ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String forbiddenHiddens ;
      private String AV28Language ;
      private String AV70UserAuthenticationTypeT ;
      private String AV32Password ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divTablecontent_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String divUserauthenticationtypename_cell_Internalname ;
      private String divUserauthenticationtypename_cell_Class ;
      private String cmbavUserauthenticationtypename_Internalname ;
      private String TempTags ;
      private String AV48UserAuthenticationTypeName ;
      private String cmbavUserauthenticationtypename_Jsonclick ;
      private String edtavUsername_Internalname ;
      private String edtavUsername_Jsonclick ;
      private String divUseremail_cell_Internalname ;
      private String divUseremail_cell_Class ;
      private String edtavUseremail_Internalname ;
      private String edtavUseremail_Jsonclick ;
      private String divUserfirstname_cell_Internalname ;
      private String divUserfirstname_cell_Class ;
      private String edtavUserfirstname_Internalname ;
      private String AV55UserFirstName ;
      private String edtavUserfirstname_Jsonclick ;
      private String divUserlastname_cell_Internalname ;
      private String divUserlastname_cell_Class ;
      private String edtavUserlastname_Internalname ;
      private String AV61UserLastName ;
      private String edtavUserlastname_Jsonclick ;
      private String divUserpassword_cell_Internalname ;
      private String divUserpassword_cell_Class ;
      private String edtavUserpassword_Internalname ;
      private String AV64UserPassword ;
      private String edtavUserpassword_Jsonclick ;
      private String divPasswordconf_cell_Internalname ;
      private String divPasswordconf_cell_Class ;
      private String edtavPasswordconf_Internalname ;
      private String AV33PasswordConf ;
      private String edtavPasswordconf_Jsonclick ;
      private String edtavUserexternalid_Internalname ;
      private String edtavUserexternalid_Jsonclick ;
      private String divUserbirthday_cell_Internalname ;
      private String divUserbirthday_cell_Class ;
      private String edtavUserbirthday_Internalname ;
      private String edtavUserbirthday_Jsonclick ;
      private String divUsergender_cell_Internalname ;
      private String divUsergender_cell_Class ;
      private String cmbavUsergender_Internalname ;
      private String AV56UserGender ;
      private String cmbavUsergender_Jsonclick ;
      private String divUserurlprofile_cell_Internalname ;
      private String divUserurlprofile_cell_Class ;
      private String edtavUserurlprofile_Internalname ;
      private String edtavUserurlprofile_Link ;
      private String edtavUserurlprofile_Linktarget ;
      private String edtavUserurlprofile_Jsonclick ;
      private String divUserurlimage_cell_Internalname ;
      private String divUserurlimage_cell_Class ;
      private String edtavUserurlimage_Internalname ;
      private String edtavUserurlimage_Jsonclick ;
      private String divUserisactive_cell_Internalname ;
      private String divUserisactive_cell_Class ;
      private String chkavUserisactive_Internalname ;
      private String divUseractivationdate_cell_Internalname ;
      private String divUseractivationdate_cell_Class ;
      private String edtavUseractivationdate_Internalname ;
      private String edtavUseractivationdate_Jsonclick ;
      private String divTablesplitteduserisenabledinrepository_Internalname ;
      private String divTextblockuserisenabledinrepository_cell_Internalname ;
      private String divTextblockuserisenabledinrepository_cell_Class ;
      private String lblTextblockuserisenabledinrepository_Internalname ;
      private String lblTextblockuserisenabledinrepository_Jsonclick ;
      private String divUserdatelasauthentication_cell_Internalname ;
      private String divUserdatelasauthentication_cell_Class ;
      private String edtavUserdatelasauthentication_Internalname ;
      private String edtavUserdatelasauthentication_Jsonclick ;
      private String chkavUserdontreceiveinformation_Internalname ;
      private String chkavUserisblocked_Internalname ;
      private String chkavUsercannotchangepassword_Internalname ;
      private String chkavUsermustchangepassword_Internalname ;
      private String chkavUserpasswordneverexpires_Internalname ;
      private String cmbavUsersecuritypolicyid_Internalname ;
      private String cmbavUsersecuritypolicyid_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Caption ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String chkavUser_isenabledinrepository_Internalname ;
      private String edtavUserguid_Internalname ;
      private String AV57UserGUID ;
      private String edtavUserguid_Jsonclick ;
      private String edtavUsernamespace_Internalname ;
      private String AV45UserNameSpace ;
      private String edtavUsernamespace_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String chkavUserisenabledinrepository_Internalname ;
      private String hsh ;
      private String bttBtnenableuserinrepo_Internalname ;
      private String AV10AuthTypeId ;
      private String AV7AuthenticationTypeName ;
      private String bttBtnenableuserinrepo_Caption ;
      private String cellUserisenabledinrepository_cell_Class ;
      private String cellUserisenabledinrepository_cell_Internalname ;
      private String sStyleString ;
      private String tblTablemergeduserisenabledinrepository_Internalname ;
      private String bttBtnenableuserinrepo_Jsonclick ;
      private String Dvpanel_tableattributes_Internalname ;
      private DateTime AV47UserActivationDate ;
      private DateTime AV51UserDateLasAuthentication ;
      private DateTime AV49UserBirthday ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV60UserIsEnabledInRepository ;
      private bool AV46CheckRequiredFieldsResult ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool wbLoad ;
      private bool AV58UserIsActive ;
      private bool AV52UserDontReceiveInformation ;
      private bool AV59UserIsBlocked ;
      private bool AV50UserCannotChangePassword ;
      private bool AV62UserMustChangePassword ;
      private bool AV65UserPasswordNeverExpires ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV24IsActive ;
      private bool AV27isOK ;
      private bool AV34PasswordIsOK ;
      private String AV63UserName ;
      private String AV53UserEmail ;
      private String AV54UserExternalId ;
      private String AV68UserURLProfile ;
      private String AV67UserURLImage ;
      private SdtGAMAuthenticationType AV6AuthenticationType ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavUserauthenticationtypename ;
      private GXCombobox cmbavUsergender ;
      private GXCheckbox chkavUserisactive ;
      private GXCheckbox chkavUserisenabledinrepository ;
      private GXCheckbox chkavUserdontreceiveinformation ;
      private GXCheckbox chkavUserisblocked ;
      private GXCheckbox chkavUsercannotchangepassword ;
      private GXCheckbox chkavUsermustchangepassword ;
      private GXCheckbox chkavUserpasswordneverexpires ;
      private GXCombobox cmbavUsersecuritypolicyid ;
      private GXCheckbox chkavUser_isenabledinrepository ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMError> AV18Errors ;
      private GXExternalCollection<SdtGAMAuthenticationTypeSimple> AV8AuthenticationTypes ;
      private GXExternalCollection<SdtGAMAuthenticationTypeSimple> AV69AuthenticationTypesI ;
      private GXExternalCollection<SdtGAMSecurityPolicy> AV38SecurityPolicies ;
      private GXWebForm Form ;
      private SdtGAMError AV17Error ;
      private SdtGAMAuthenticationTypeSimple AV9AuthenticationTypesIns ;
      private SdtGAMSecurityPolicyFilter AV20FilterSecPol ;
      private SdtGAMRepository AV37Repository ;
      private SdtGAMSecurityPolicy AV39SecurityPolicy ;
      private SdtGAMUser AV43User ;
   }

   public class gamuserentry__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamuserentry__default : DataStoreHelperBase, IDataStoreHelper
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
