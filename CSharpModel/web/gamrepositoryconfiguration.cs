/*
               File: GAMRepositoryConfiguration
        Description: Repository configuration
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:42:6.26
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
   public class gamrepositoryconfiguration : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gamrepositoryconfiguration( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamrepositoryconfiguration( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_pId )
      {
         this.AV31pId = aP0_pId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavRepositorydefaultauthenticationtypename = new GXCombobox();
         chkavRepositorysessionexpiresonipchange = new GXCheckbox();
         chkavRepositoryallowoauthaccess = new GXCheckbox();
         cmbavRepositorydefaultsecuritypolicyid = new GXCombobox();
         cmbavRepositorylogoutbehavior = new GXCombobox();
         cmbavRepositorydefaultroleid = new GXCombobox();
         cmbavRepositoryenabletracing = new GXCombobox();
         cmbavRepositoryuseridentification = new GXCombobox();
         cmbavRepositoryuseractivationmethod = new GXCombobox();
         chkavRepositoryuseremailsunique = new GXCheckbox();
         chkavRepositoryrequiredemail = new GXCheckbox();
         chkavRepositoryrequiredpassword = new GXCheckbox();
         chkavRepositoryrequiredfirstname = new GXCheckbox();
         chkavRepositoryrequiredlastname = new GXCheckbox();
         cmbavRepositorygeneratesessionstatistics = new GXCombobox();
         chkavRepositorygiveanonymoussession = new GXCheckbox();
         cmbavRepositoryuserremembermetype = new GXCombobox();
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
               AV31pId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31pId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31pId), 12, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV31pId), "ZZZZZZZZZZZ9"), context));
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
         PA0Y2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0Y2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20189201942680", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gamrepositoryconfiguration.aspx") + "?" + UrlEncode("" +AV31pId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22Id), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22Id), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31pId), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV31pId), "ZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "GXUITABSPANEL_TABS_Class", StringUtil.RTrim( Gxuitabspanel_tabs_Class));
         GxWebStd.gx_hidden_field( context, "GXUITABSPANEL_TABS_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gxuitabspanel_tabs_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXUITABSPANEL_TABS_Historymanagement", StringUtil.BoolToStr( Gxuitabspanel_tabs_Historymanagement));
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
            WE0Y2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0Y2( ) ;
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
         return formatLink("gamrepositoryconfiguration.aspx") + "?" + UrlEncode("" +AV31pId) ;
      }

      public override String GetPgmname( )
      {
         return "GAMRepositoryConfiguration" ;
      }

      public override String GetPgmdesc( )
      {
         return "Repository configuration " ;
      }

      protected void WB0Y0( )
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
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableMainWithShadow", "left", "top", "", "", "div");
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
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"GXUITABSPANEL_TABSContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "General", "", "", lblGeneral_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "General") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable3_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryid_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryid_Internalname, "Id", "", "", lblTextblockrepositoryid_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositoryid_Internalname, "Repository Id", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositoryid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV69RepositoryId), 9, 0, ",", "")), ((edtavRepositoryid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV69RepositoryId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV69RepositoryId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositoryid_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavRepositoryid_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "GAMKeyNumShort", "right", false, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryguid_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryguid_Internalname, "GUID", "", "", lblTextblockrepositoryguid_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositoryguid_Internalname, "Repository GUID", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositoryguid_Internalname, StringUtil.RTrim( AV70RepositoryGUID), StringUtil.RTrim( context.localUtil.Format( AV70RepositoryGUID, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositoryguid_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavRepositoryguid_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "GAMGUID", "left", true, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositorynamespace_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositorynamespace_Internalname, "Namespace", "", "", lblTextblockrepositorynamespace_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositorynamespace_Internalname, "Repository Name Space", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositorynamespace_Internalname, StringUtil.RTrim( AV71RepositoryNameSpace), StringUtil.RTrim( context.localUtil.Format( AV71RepositoryNameSpace, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,47);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositorynamespace_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavRepositorynamespace_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, 0, true, "GAMRepositoryNameSpace", "left", true, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryname_Internalname, "Name", "", "", lblTextblockrepositoryname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositoryname_Internalname, "Repository Name", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositoryname_Internalname, StringUtil.RTrim( AV72RepositoryName), StringUtil.RTrim( context.localUtil.Format( AV72RepositoryName, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositoryname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavRepositoryname_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionShort", "left", true, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositorydescription_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositorydescription_Internalname, "Description", "", "", lblTextblockrepositorydescription_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositorydescription_Internalname, "Repository Description", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositorydescription_Internalname, StringUtil.RTrim( AV73RepositoryDescription), StringUtil.RTrim( context.localUtil.Format( AV73RepositoryDescription, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositorydescription_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavRepositorydescription_Enabled, 0, "text", "", 80, "chr", 1, "row", 254, 0, 0, 0, 1, -1, -1, true, "GAMDescriptionLong", "left", true, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRepositorydefaultauthenticationtypename_cell_Internalname, 1, 0, "px", 0, "px", divRepositorydefaultauthenticationtypename_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositorydefaultauthenticationtypename_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositorydefaultauthenticationtypename_Internalname, "Default authentication type", "", "", lblTextblockrepositorydefaultauthenticationtypename_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavRepositorydefaultauthenticationtypename_Internalname, "Repository Default Authentication Type Name", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavRepositorydefaultauthenticationtypename, cmbavRepositorydefaultauthenticationtypename_Internalname, StringUtil.RTrim( AV74RepositoryDefaultAuthenticationTypeName), 1, cmbavRepositorydefaultauthenticationtypename_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", cmbavRepositorydefaultauthenticationtypename.Visible, cmbavRepositorydefaultauthenticationtypename.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,74);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavRepositorydefaultauthenticationtypename.CurrentValue = StringUtil.RTrim( AV74RepositoryDefaultAuthenticationTypeName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorydefaultauthenticationtypename_Internalname, "Values", (String)(cmbavRepositorydefaultauthenticationtypename.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositorysessionexpiresonipchange_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositorysessionexpiresonipchange_Internalname, " ", "", "", lblTextblockrepositorysessionexpiresonipchange_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRepositorysessionexpiresonipchange_Internalname, "Repository Session Expires On IPChange", "col-sm-3 AttributeCheckBoxLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRepositorysessionexpiresonipchange_Internalname, StringUtil.BoolToStr( AV75RepositorySessionExpiresOnIPChange), "", "Repository Session Expires On IPChange", 1, chkavRepositorysessionexpiresonipchange.Enabled, "true", "GAM session expires on IP change?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(83, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,83);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryallowoauthaccess_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryallowoauthaccess_Internalname, " ", "", "", lblTextblockrepositoryallowoauthaccess_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRepositoryallowoauthaccess_Internalname, "Repository Allow Oauth Access", "col-sm-3 AttributeCheckBoxLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRepositoryallowoauthaccess_Internalname, StringUtil.BoolToStr( AV76RepositoryAllowOauthAccess), "", "Repository Allow Oauth Access", 1, chkavRepositoryallowoauthaccess.Enabled, "true", "Allow oauth access (Smart Devices)", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(92, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,92);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRepositorydefaultsecuritypolicyid_cell_Internalname, 1, 0, "px", 0, "px", divRepositorydefaultsecuritypolicyid_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositorydefaultsecuritypolicyid_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositorydefaultsecuritypolicyid_Internalname, "Default security policy", "", "", lblTextblockrepositorydefaultsecuritypolicyid_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavRepositorydefaultsecuritypolicyid_Internalname, "Repository Default Security Policy Id", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavRepositorydefaultsecuritypolicyid, cmbavRepositorydefaultsecuritypolicyid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV54RepositoryDefaultSecurityPolicyId), 9, 0)), 1, cmbavRepositorydefaultsecuritypolicyid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavRepositorydefaultsecuritypolicyid.Visible, cmbavRepositorydefaultsecuritypolicyid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,101);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavRepositorydefaultsecuritypolicyid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV54RepositoryDefaultSecurityPolicyId), 9, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorydefaultsecuritypolicyid_Internalname, "Values", (String)(cmbavRepositorydefaultsecuritypolicyid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositorylogoutbehavior_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositorylogoutbehavior_Internalname, "SSO Logout behavior", "", "", lblTextblockrepositorylogoutbehavior_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavRepositorylogoutbehavior_Internalname, "Repository Logout Behavior", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 110,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavRepositorylogoutbehavior, cmbavRepositorylogoutbehavior_Internalname, StringUtil.RTrim( AV78RepositoryLogoutBehavior), 1, cmbavRepositorylogoutbehavior_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavRepositorylogoutbehavior.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,110);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavRepositorylogoutbehavior.CurrentValue = StringUtil.RTrim( AV78RepositoryLogoutBehavior);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorylogoutbehavior_Internalname, "Values", (String)(cmbavRepositorylogoutbehavior.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRepositorydefaultroleid_cell_Internalname, 1, 0, "px", 0, "px", divRepositorydefaultroleid_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositorydefaultroleid_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositorydefaultroleid_Internalname, "Default role", "", "", lblTextblockrepositorydefaultroleid_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavRepositorydefaultroleid_Internalname, "Repository Default Role Id", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavRepositorydefaultroleid, cmbavRepositorydefaultroleid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV77RepositoryDefaultRoleId), 12, 0)), 1, cmbavRepositorydefaultroleid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavRepositorydefaultroleid.Visible, cmbavRepositorydefaultroleid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,119);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavRepositorydefaultroleid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV77RepositoryDefaultRoleId), 12, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorydefaultroleid_Internalname, "Values", (String)(cmbavRepositorydefaultroleid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryenabletracing_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryenabletracing_Internalname, "Enable Tracing", "", "", lblTextblockrepositoryenabletracing_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavRepositoryenabletracing_Internalname, "Repository Enable Tracing", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 128,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavRepositoryenabletracing, cmbavRepositoryenabletracing_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV79RepositoryEnableTracing), 4, 0)), 1, cmbavRepositoryenabletracing_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavRepositoryenabletracing.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,128);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavRepositoryenabletracing.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV79RepositoryEnableTracing), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositoryenabletracing_Internalname, "Values", (String)(cmbavRepositoryenabletracing.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblUsers_title_Internalname, "Users", "", "", lblUsers_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Users") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable2_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryuseridentification_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryuseridentification_Internalname, "User identification", "", "", lblTextblockrepositoryuseridentification_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavRepositoryuseridentification_Internalname, "Repository User Identification", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 142,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavRepositoryuseridentification, cmbavRepositoryuseridentification_Internalname, StringUtil.RTrim( AV63RepositoryUserIdentification), 1, cmbavRepositoryuseridentification_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavRepositoryuseridentification.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,142);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavRepositoryuseridentification.CurrentValue = StringUtil.RTrim( AV63RepositoryUserIdentification);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositoryuseridentification_Internalname, "Values", (String)(cmbavRepositoryuseridentification.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryuseractivationmethod_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryuseractivationmethod_Internalname, "User activation method", "", "", lblTextblockrepositoryuseractivationmethod_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavRepositoryuseractivationmethod_Internalname, "Repository User Activation Method", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 151,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavRepositoryuseractivationmethod, cmbavRepositoryuseractivationmethod_Internalname, StringUtil.RTrim( AV64RepositoryUserActivationMethod), 1, cmbavRepositoryuseractivationmethod_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavRepositoryuseractivationmethod.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,151);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavRepositoryuseractivationmethod.CurrentValue = StringUtil.RTrim( AV64RepositoryUserActivationMethod);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositoryuseractivationmethod_Internalname, "Values", (String)(cmbavRepositoryuseractivationmethod.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryautomaticactivationtimeout_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryautomaticactivationtimeout_Internalname, "User automatic activation timeout (hours)", "", "", lblTextblockrepositoryautomaticactivationtimeout_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositoryautomaticactivationtimeout_Internalname, "Repository Automatic Activation Timeout", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 160,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositoryautomaticactivationtimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV65RepositoryAutomaticActivationTimeout), 4, 0, ",", "")), ((edtavRepositoryautomaticactivationtimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV65RepositoryAutomaticActivationTimeout), "ZZZ9")) : context.localUtil.Format( (decimal)(AV65RepositoryAutomaticActivationTimeout), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,160);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositoryautomaticactivationtimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavRepositoryautomaticactivationtimeout_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryuseremailsunique_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryuseremailsunique_Internalname, " ", "", "", lblTextblockrepositoryuseremailsunique_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRepositoryuseremailsunique_Internalname, "Repository User Emails Unique", "col-sm-3 AttributeCheckBoxLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 169,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRepositoryuseremailsunique_Internalname, StringUtil.BoolToStr( AV66RepositoryUserEmailsUnique), "", "Repository User Emails Unique", 1, chkavRepositoryuseremailsunique.Enabled, "true", "User Email is unique?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(169, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,169);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryrequiredemail_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryrequiredemail_Internalname, " ", "", "", lblTextblockrepositoryrequiredemail_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRepositoryrequiredemail_Internalname, "Repository Required Email", "col-sm-3 AttributeCheckBoxLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 178,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRepositoryrequiredemail_Internalname, StringUtil.BoolToStr( AV67RepositoryRequiredEmail), "", "Repository Required Email", 1, chkavRepositoryrequiredemail.Enabled, "true", "Required email?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(178, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,178);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryrequiredpassword_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryrequiredpassword_Internalname, " ", "", "", lblTextblockrepositoryrequiredpassword_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRepositoryrequiredpassword_Internalname, "Repository Required Password", "col-sm-3 AttributeCheckBoxLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 187,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRepositoryrequiredpassword_Internalname, StringUtil.BoolToStr( AV68RepositoryRequiredPassword), "", "Repository Required Password", 1, chkavRepositoryrequiredpassword.Enabled, "true", "Required password?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(187, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,187);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryrequiredfirstname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryrequiredfirstname_Internalname, " ", "", "", lblTextblockrepositoryrequiredfirstname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRepositoryrequiredfirstname_Internalname, "Repository Required First Name", "col-sm-3 AttributeCheckBoxLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 196,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRepositoryrequiredfirstname_Internalname, StringUtil.BoolToStr( AV52RepositoryRequiredFirstName), "", "Repository Required First Name", 1, chkavRepositoryrequiredfirstname.Enabled, "true", "Required first name?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(196, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,196);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryrequiredlastname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryrequiredlastname_Internalname, " ", "", "", lblTextblockrepositoryrequiredlastname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRepositoryrequiredlastname_Internalname, "Repository Required Last Name", "col-sm-3 AttributeCheckBoxLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 205,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRepositoryrequiredlastname_Internalname, StringUtil.BoolToStr( AV53RepositoryRequiredLastName), "", "Repository Required Last Name", 1, chkavRepositoryrequiredlastname.Enabled, "true", "Required last name?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(205, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,205);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"title3"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblSession_title_Internalname, "Session", "", "", lblSession_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Session") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"GXUITABSPANEL_TABSContainer"+"panel3"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositorygeneratesessionstatistics_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositorygeneratesessionstatistics_Internalname, "Generate session statistics?", "", "", lblTextblockrepositorygeneratesessionstatistics_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavRepositorygeneratesessionstatistics_Internalname, "Repository Generate Session Statistics", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 219,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavRepositorygeneratesessionstatistics, cmbavRepositorygeneratesessionstatistics_Internalname, StringUtil.RTrim( AV59RepositoryGenerateSessionStatistics), 1, cmbavRepositorygeneratesessionstatistics_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavRepositorygeneratesessionstatistics.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,219);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavRepositorygeneratesessionstatistics.CurrentValue = StringUtil.RTrim( AV59RepositoryGenerateSessionStatistics);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorygeneratesessionstatistics_Internalname, "Values", (String)(cmbavRepositorygeneratesessionstatistics.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryusersessioncachetimeout_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryusersessioncachetimeout_Internalname, "User session cache timeout (seconds)", "", "", lblTextblockrepositoryusersessioncachetimeout_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositoryusersessioncachetimeout_Internalname, "Repository User Session Cache Timeout", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 228,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositoryusersessioncachetimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV58RepositoryUserSessionCacheTimeout), 9, 0, ",", "")), ((edtavRepositoryusersessioncachetimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV58RepositoryUserSessionCacheTimeout), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV58RepositoryUserSessionCacheTimeout), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,228);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositoryusersessioncachetimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavRepositoryusersessioncachetimeout_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositorygiveanonymoussession_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositorygiveanonymoussession_Internalname, "  ", "", "", lblTextblockrepositorygiveanonymoussession_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavRepositorygiveanonymoussession_Internalname, "Repository Give Anonymous Session", "col-sm-3 AttributeCheckBoxLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 237,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavRepositorygiveanonymoussession_Internalname, StringUtil.BoolToStr( AV57RepositoryGiveAnonymousSession), "", "Repository Give Anonymous Session", 1, chkavRepositorygiveanonymoussession.Enabled, "true", "Give web Anonymous session?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(237, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,237);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryloginattemptstolocksession_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryloginattemptstolocksession_Internalname, "Login retries to lock session", "", "", lblTextblockrepositoryloginattemptstolocksession_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositoryloginattemptstolocksession_Internalname, "Repository Login Attempts To Lock Session", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 246,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositoryloginattemptstolocksession_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV80RepositoryLoginAttemptsToLockSession), 2, 0, ",", "")), ((edtavRepositoryloginattemptstolocksession_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV80RepositoryLoginAttemptsToLockSession), "Z9")) : context.localUtil.Format( (decimal)(AV80RepositoryLoginAttemptsToLockSession), "Z9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,246);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositoryloginattemptstolocksession_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavRepositoryloginattemptstolocksession_Enabled, 0, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositorygamunblockusertimeout_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositorygamunblockusertimeout_Internalname, "Unblock user timeout (minutes)", "", "", lblTextblockrepositorygamunblockusertimeout_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositorygamunblockusertimeout_Internalname, "Repository GAMUnblock User Timeout", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 255,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositorygamunblockusertimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV81RepositoryGAMUnblockUserTimeout), 2, 0, ",", "")), ((edtavRepositorygamunblockusertimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV81RepositoryGAMUnblockUserTimeout), "Z9")) : context.localUtil.Format( (decimal)(AV81RepositoryGAMUnblockUserTimeout), "Z9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,255);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositorygamunblockusertimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavRepositorygamunblockusertimeout_Enabled, 0, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryloginattemptstolockuser_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryloginattemptstolockuser_Internalname, "Login retries to lock user", "", "", lblTextblockrepositoryloginattemptstolockuser_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositoryloginattemptstolockuser_Internalname, "Repository Login Attempts To Lock User", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 264,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositoryloginattemptstolockuser_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV56RepositoryLoginAttemptsToLockUser), 2, 0, ",", "")), ((edtavRepositoryloginattemptstolockuser_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV56RepositoryLoginAttemptsToLockUser), "Z9")) : context.localUtil.Format( (decimal)(AV56RepositoryLoginAttemptsToLockUser), "Z9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,264);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositoryloginattemptstolockuser_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavRepositoryloginattemptstolockuser_Enabled, 0, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryminimumamountcharactersinlogin_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryminimumamountcharactersinlogin_Internalname, "Minimum amount of characters in login", "", "", lblTextblockrepositoryminimumamountcharactersinlogin_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositoryminimumamountcharactersinlogin_Internalname, "Repository Minimum Amount Characters In Login", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 273,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositoryminimumamountcharactersinlogin_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV55RepositoryMinimumAmountCharactersInLogin), 2, 0, ",", "")), ((edtavRepositoryminimumamountcharactersinlogin_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV55RepositoryMinimumAmountCharactersInLogin), "Z9")) : context.localUtil.Format( (decimal)(AV55RepositoryMinimumAmountCharactersInLogin), "Z9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,273);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositoryminimumamountcharactersinlogin_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavRepositoryminimumamountcharactersinlogin_Enabled, 0, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryuserrecoverypasswordkeytimeout_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryuserrecoverypasswordkeytimeout_Internalname, "User recovery password key timeout (minutes)", "", "", lblTextblockrepositoryuserrecoverypasswordkeytimeout_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositoryuserrecoverypasswordkeytimeout_Internalname, "Repository User Recovery Password Key Timeout", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 282,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositoryuserrecoverypasswordkeytimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV62RepositoryUserRecoveryPasswordKeyTimeout), 4, 0, ",", "")), ((edtavRepositoryuserrecoverypasswordkeytimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV62RepositoryUserRecoveryPasswordKeyTimeout), "ZZZ9")) : context.localUtil.Format( (decimal)(AV62RepositoryUserRecoveryPasswordKeyTimeout), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,282);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositoryuserrecoverypasswordkeytimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavRepositoryuserrecoverypasswordkeytimeout_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryuserremembermetimeout_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryuserremembermetimeout_Internalname, "User remember me timeout (days)", "", "", lblTextblockrepositoryuserremembermetimeout_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositoryuserremembermetimeout_Internalname, "Repository User Remember Me Timeout", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 291,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositoryuserremembermetimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV61RepositoryUserRememberMeTimeout), 4, 0, ",", "")), ((edtavRepositoryuserremembermetimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV61RepositoryUserRememberMeTimeout), "ZZZ9")) : context.localUtil.Format( (decimal)(AV61RepositoryUserRememberMeTimeout), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,291);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositoryuserremembermetimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavRepositoryuserremembermetimeout_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositoryuserremembermetype_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositoryuserremembermetype_Internalname, "User remember me type", "", "", lblTextblockrepositoryuserremembermetype_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavRepositoryuserremembermetype_Internalname, "Repository User Remember Me Type", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 300,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavRepositoryuserremembermetype, cmbavRepositoryuserremembermetype_Internalname, StringUtil.RTrim( AV60RepositoryUserRememberMeType), 1, cmbavRepositoryuserremembermetype_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbavRepositoryuserremembermetype.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,300);\"", "", true, "HLP_GAMRepositoryConfiguration.htm");
            cmbavRepositoryuserremembermetype.CurrentValue = StringUtil.RTrim( AV60RepositoryUserRememberMeType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositoryuserremembermetype_Internalname, "Values", (String)(cmbavRepositoryuserremembermetype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablerepositorycachetimeout_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockrepositorycachetimeout_Internalname, "Cache timeout (minutes)", "", "", lblTextblockrepositorycachetimeout_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavRepositorycachetimeout_Internalname, "Repository Cache Timeout", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 309,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRepositorycachetimeout_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV33RepositoryCacheTimeout), 9, 0, ",", "")), ((edtavRepositorycachetimeout_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV33RepositoryCacheTimeout), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV33RepositoryCacheTimeout), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,309);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRepositorycachetimeout_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavRepositorycachetimeout_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_GAMRepositoryConfiguration.htm");
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 314,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "Confirmar", bttBtnenter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMRepositoryConfiguration.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 316,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Fechar", bttBtncancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GAMRepositoryConfiguration.htm");
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

      protected void START0Y2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Repository configuration ", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0Y0( ) ;
      }

      protected void WS0Y2( )
      {
         START0Y2( ) ;
         EVT0Y2( ) ;
      }

      protected void EVT0Y2( )
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
                              E110Y2 ();
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
                                    E120Y2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E130Y2 ();
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

      protected void WE0Y2( )
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

      protected void PA0Y2( )
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
            cmbavRepositorydefaultauthenticationtypename.Name = "vREPOSITORYDEFAULTAUTHENTICATIONTYPENAME";
            cmbavRepositorydefaultauthenticationtypename.WebTags = "";
            if ( cmbavRepositorydefaultauthenticationtypename.ItemCount > 0 )
            {
               AV74RepositoryDefaultAuthenticationTypeName = cmbavRepositorydefaultauthenticationtypename.getValidValue(AV74RepositoryDefaultAuthenticationTypeName);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74RepositoryDefaultAuthenticationTypeName", AV74RepositoryDefaultAuthenticationTypeName);
            }
            chkavRepositorysessionexpiresonipchange.Name = "vREPOSITORYSESSIONEXPIRESONIPCHANGE";
            chkavRepositorysessionexpiresonipchange.WebTags = "";
            chkavRepositorysessionexpiresonipchange.Caption = "GAM session expires on IP change?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRepositorysessionexpiresonipchange_Internalname, "TitleCaption", chkavRepositorysessionexpiresonipchange.Caption, true);
            chkavRepositorysessionexpiresonipchange.CheckedValue = "false";
            chkavRepositoryallowoauthaccess.Name = "vREPOSITORYALLOWOAUTHACCESS";
            chkavRepositoryallowoauthaccess.WebTags = "";
            chkavRepositoryallowoauthaccess.Caption = "Allow oauth access (Smart Devices)";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRepositoryallowoauthaccess_Internalname, "TitleCaption", chkavRepositoryallowoauthaccess.Caption, true);
            chkavRepositoryallowoauthaccess.CheckedValue = "false";
            cmbavRepositorydefaultsecuritypolicyid.Name = "vREPOSITORYDEFAULTSECURITYPOLICYID";
            cmbavRepositorydefaultsecuritypolicyid.WebTags = "";
            if ( cmbavRepositorydefaultsecuritypolicyid.ItemCount > 0 )
            {
               AV54RepositoryDefaultSecurityPolicyId = (int)(NumberUtil.Val( cmbavRepositorydefaultsecuritypolicyid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV54RepositoryDefaultSecurityPolicyId), 9, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54RepositoryDefaultSecurityPolicyId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV54RepositoryDefaultSecurityPolicyId), 9, 0)));
            }
            cmbavRepositorylogoutbehavior.Name = "vREPOSITORYLOGOUTBEHAVIOR";
            cmbavRepositorylogoutbehavior.WebTags = "";
            cmbavRepositorylogoutbehavior.addItem("clionl", "Client only", 0);
            cmbavRepositorylogoutbehavior.addItem("cliip", "Identity Provider and Client", 0);
            cmbavRepositorylogoutbehavior.addItem("all", "Identity Provider and all Clients", 0);
            if ( cmbavRepositorylogoutbehavior.ItemCount > 0 )
            {
               AV78RepositoryLogoutBehavior = cmbavRepositorylogoutbehavior.getValidValue(AV78RepositoryLogoutBehavior);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78RepositoryLogoutBehavior", AV78RepositoryLogoutBehavior);
            }
            cmbavRepositorydefaultroleid.Name = "vREPOSITORYDEFAULTROLEID";
            cmbavRepositorydefaultroleid.WebTags = "";
            if ( cmbavRepositorydefaultroleid.ItemCount > 0 )
            {
               AV77RepositoryDefaultRoleId = (long)(NumberUtil.Val( cmbavRepositorydefaultroleid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV77RepositoryDefaultRoleId), 12, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77RepositoryDefaultRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV77RepositoryDefaultRoleId), 12, 0)));
            }
            cmbavRepositoryenabletracing.Name = "vREPOSITORYENABLETRACING";
            cmbavRepositoryenabletracing.WebTags = "";
            cmbavRepositoryenabletracing.addItem("0", "0 - Off", 0);
            cmbavRepositoryenabletracing.addItem("1", "1 - Debug", 0);
            if ( cmbavRepositoryenabletracing.ItemCount > 0 )
            {
               AV79RepositoryEnableTracing = (short)(NumberUtil.Val( cmbavRepositoryenabletracing.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV79RepositoryEnableTracing), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79RepositoryEnableTracing", StringUtil.LTrim( StringUtil.Str( (decimal)(AV79RepositoryEnableTracing), 4, 0)));
            }
            cmbavRepositoryuseridentification.Name = "vREPOSITORYUSERIDENTIFICATION";
            cmbavRepositoryuseridentification.WebTags = "";
            cmbavRepositoryuseridentification.addItem("name", "Name", 0);
            cmbavRepositoryuseridentification.addItem("email", "EMail", 0);
            cmbavRepositoryuseridentification.addItem("namema", "Name and Email", 0);
            if ( cmbavRepositoryuseridentification.ItemCount > 0 )
            {
               AV63RepositoryUserIdentification = cmbavRepositoryuseridentification.getValidValue(AV63RepositoryUserIdentification);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63RepositoryUserIdentification", AV63RepositoryUserIdentification);
            }
            cmbavRepositoryuseractivationmethod.Name = "vREPOSITORYUSERACTIVATIONMETHOD";
            cmbavRepositoryuseractivationmethod.WebTags = "";
            cmbavRepositoryuseractivationmethod.addItem("A", "Automatic", 0);
            cmbavRepositoryuseractivationmethod.addItem("U", "User", 0);
            cmbavRepositoryuseractivationmethod.addItem("D", "Administrator", 0);
            if ( cmbavRepositoryuseractivationmethod.ItemCount > 0 )
            {
               AV64RepositoryUserActivationMethod = cmbavRepositoryuseractivationmethod.getValidValue(AV64RepositoryUserActivationMethod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64RepositoryUserActivationMethod", AV64RepositoryUserActivationMethod);
            }
            chkavRepositoryuseremailsunique.Name = "vREPOSITORYUSEREMAILSUNIQUE";
            chkavRepositoryuseremailsunique.WebTags = "";
            chkavRepositoryuseremailsunique.Caption = "User Email is unique?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRepositoryuseremailsunique_Internalname, "TitleCaption", chkavRepositoryuseremailsunique.Caption, true);
            chkavRepositoryuseremailsunique.CheckedValue = "false";
            chkavRepositoryrequiredemail.Name = "vREPOSITORYREQUIREDEMAIL";
            chkavRepositoryrequiredemail.WebTags = "";
            chkavRepositoryrequiredemail.Caption = "Required email?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRepositoryrequiredemail_Internalname, "TitleCaption", chkavRepositoryrequiredemail.Caption, true);
            chkavRepositoryrequiredemail.CheckedValue = "false";
            chkavRepositoryrequiredpassword.Name = "vREPOSITORYREQUIREDPASSWORD";
            chkavRepositoryrequiredpassword.WebTags = "";
            chkavRepositoryrequiredpassword.Caption = "Required password?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRepositoryrequiredpassword_Internalname, "TitleCaption", chkavRepositoryrequiredpassword.Caption, true);
            chkavRepositoryrequiredpassword.CheckedValue = "false";
            chkavRepositoryrequiredfirstname.Name = "vREPOSITORYREQUIREDFIRSTNAME";
            chkavRepositoryrequiredfirstname.WebTags = "";
            chkavRepositoryrequiredfirstname.Caption = "Required first name?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRepositoryrequiredfirstname_Internalname, "TitleCaption", chkavRepositoryrequiredfirstname.Caption, true);
            chkavRepositoryrequiredfirstname.CheckedValue = "false";
            chkavRepositoryrequiredlastname.Name = "vREPOSITORYREQUIREDLASTNAME";
            chkavRepositoryrequiredlastname.WebTags = "";
            chkavRepositoryrequiredlastname.Caption = "Required last name?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRepositoryrequiredlastname_Internalname, "TitleCaption", chkavRepositoryrequiredlastname.Caption, true);
            chkavRepositoryrequiredlastname.CheckedValue = "false";
            cmbavRepositorygeneratesessionstatistics.Name = "vREPOSITORYGENERATESESSIONSTATISTICS";
            cmbavRepositorygeneratesessionstatistics.WebTags = "";
            cmbavRepositorygeneratesessionstatistics.addItem("None", "None", 0);
            cmbavRepositorygeneratesessionstatistics.addItem("Minimum", "Minimum (Only authenticated users)", 0);
            cmbavRepositorygeneratesessionstatistics.addItem("Detail", "Detail (Authenticated and anonymous users)", 0);
            cmbavRepositorygeneratesessionstatistics.addItem("Full", "Full log (Authenticated and anonymous users)", 0);
            if ( cmbavRepositorygeneratesessionstatistics.ItemCount > 0 )
            {
               AV59RepositoryGenerateSessionStatistics = cmbavRepositorygeneratesessionstatistics.getValidValue(AV59RepositoryGenerateSessionStatistics);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59RepositoryGenerateSessionStatistics", AV59RepositoryGenerateSessionStatistics);
            }
            chkavRepositorygiveanonymoussession.Name = "vREPOSITORYGIVEANONYMOUSSESSION";
            chkavRepositorygiveanonymoussession.WebTags = "";
            chkavRepositorygiveanonymoussession.Caption = "Give web Anonymous session?";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRepositorygiveanonymoussession_Internalname, "TitleCaption", chkavRepositorygiveanonymoussession.Caption, true);
            chkavRepositorygiveanonymoussession.CheckedValue = "false";
            cmbavRepositoryuserremembermetype.Name = "vREPOSITORYUSERREMEMBERMETYPE";
            cmbavRepositoryuserremembermetype.WebTags = "";
            cmbavRepositoryuserremembermetype.addItem("None", "None", 0);
            cmbavRepositoryuserremembermetype.addItem("Login", "Login", 0);
            cmbavRepositoryuserremembermetype.addItem("Auth", "Authentication", 0);
            cmbavRepositoryuserremembermetype.addItem("Both", "Both", 0);
            if ( cmbavRepositoryuserremembermetype.ItemCount > 0 )
            {
               AV60RepositoryUserRememberMeType = cmbavRepositoryuserremembermetype.getValidValue(AV60RepositoryUserRememberMeType);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60RepositoryUserRememberMeType", AV60RepositoryUserRememberMeType);
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
               GX_FocusControl = edtavRepositoryid_Internalname;
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
         if ( cmbavRepositorydefaultauthenticationtypename.ItemCount > 0 )
         {
            AV74RepositoryDefaultAuthenticationTypeName = cmbavRepositorydefaultauthenticationtypename.getValidValue(AV74RepositoryDefaultAuthenticationTypeName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74RepositoryDefaultAuthenticationTypeName", AV74RepositoryDefaultAuthenticationTypeName);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavRepositorydefaultauthenticationtypename.CurrentValue = StringUtil.RTrim( AV74RepositoryDefaultAuthenticationTypeName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorydefaultauthenticationtypename_Internalname, "Values", cmbavRepositorydefaultauthenticationtypename.ToJavascriptSource(), true);
         }
         if ( cmbavRepositorydefaultsecuritypolicyid.ItemCount > 0 )
         {
            AV54RepositoryDefaultSecurityPolicyId = (int)(NumberUtil.Val( cmbavRepositorydefaultsecuritypolicyid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV54RepositoryDefaultSecurityPolicyId), 9, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54RepositoryDefaultSecurityPolicyId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV54RepositoryDefaultSecurityPolicyId), 9, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavRepositorydefaultsecuritypolicyid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV54RepositoryDefaultSecurityPolicyId), 9, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorydefaultsecuritypolicyid_Internalname, "Values", cmbavRepositorydefaultsecuritypolicyid.ToJavascriptSource(), true);
         }
         if ( cmbavRepositorylogoutbehavior.ItemCount > 0 )
         {
            AV78RepositoryLogoutBehavior = cmbavRepositorylogoutbehavior.getValidValue(AV78RepositoryLogoutBehavior);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78RepositoryLogoutBehavior", AV78RepositoryLogoutBehavior);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavRepositorylogoutbehavior.CurrentValue = StringUtil.RTrim( AV78RepositoryLogoutBehavior);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorylogoutbehavior_Internalname, "Values", cmbavRepositorylogoutbehavior.ToJavascriptSource(), true);
         }
         if ( cmbavRepositorydefaultroleid.ItemCount > 0 )
         {
            AV77RepositoryDefaultRoleId = (long)(NumberUtil.Val( cmbavRepositorydefaultroleid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV77RepositoryDefaultRoleId), 12, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77RepositoryDefaultRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV77RepositoryDefaultRoleId), 12, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavRepositorydefaultroleid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV77RepositoryDefaultRoleId), 12, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorydefaultroleid_Internalname, "Values", cmbavRepositorydefaultroleid.ToJavascriptSource(), true);
         }
         if ( cmbavRepositoryenabletracing.ItemCount > 0 )
         {
            AV79RepositoryEnableTracing = (short)(NumberUtil.Val( cmbavRepositoryenabletracing.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV79RepositoryEnableTracing), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79RepositoryEnableTracing", StringUtil.LTrim( StringUtil.Str( (decimal)(AV79RepositoryEnableTracing), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavRepositoryenabletracing.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV79RepositoryEnableTracing), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositoryenabletracing_Internalname, "Values", cmbavRepositoryenabletracing.ToJavascriptSource(), true);
         }
         if ( cmbavRepositoryuseridentification.ItemCount > 0 )
         {
            AV63RepositoryUserIdentification = cmbavRepositoryuseridentification.getValidValue(AV63RepositoryUserIdentification);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63RepositoryUserIdentification", AV63RepositoryUserIdentification);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavRepositoryuseridentification.CurrentValue = StringUtil.RTrim( AV63RepositoryUserIdentification);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositoryuseridentification_Internalname, "Values", cmbavRepositoryuseridentification.ToJavascriptSource(), true);
         }
         if ( cmbavRepositoryuseractivationmethod.ItemCount > 0 )
         {
            AV64RepositoryUserActivationMethod = cmbavRepositoryuseractivationmethod.getValidValue(AV64RepositoryUserActivationMethod);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64RepositoryUserActivationMethod", AV64RepositoryUserActivationMethod);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavRepositoryuseractivationmethod.CurrentValue = StringUtil.RTrim( AV64RepositoryUserActivationMethod);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositoryuseractivationmethod_Internalname, "Values", cmbavRepositoryuseractivationmethod.ToJavascriptSource(), true);
         }
         if ( cmbavRepositorygeneratesessionstatistics.ItemCount > 0 )
         {
            AV59RepositoryGenerateSessionStatistics = cmbavRepositorygeneratesessionstatistics.getValidValue(AV59RepositoryGenerateSessionStatistics);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59RepositoryGenerateSessionStatistics", AV59RepositoryGenerateSessionStatistics);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavRepositorygeneratesessionstatistics.CurrentValue = StringUtil.RTrim( AV59RepositoryGenerateSessionStatistics);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorygeneratesessionstatistics_Internalname, "Values", cmbavRepositorygeneratesessionstatistics.ToJavascriptSource(), true);
         }
         if ( cmbavRepositoryuserremembermetype.ItemCount > 0 )
         {
            AV60RepositoryUserRememberMeType = cmbavRepositoryuserremembermetype.getValidValue(AV60RepositoryUserRememberMeType);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60RepositoryUserRememberMeType", AV60RepositoryUserRememberMeType);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavRepositoryuserremembermetype.CurrentValue = StringUtil.RTrim( AV60RepositoryUserRememberMeType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositoryuserremembermetype_Internalname, "Values", cmbavRepositoryuserremembermetype.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0Y2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavRepositoryid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRepositoryid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRepositoryid_Enabled), 5, 0)), true);
         edtavRepositoryguid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRepositoryguid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRepositoryguid_Enabled), 5, 0)), true);
         edtavRepositorynamespace_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRepositorynamespace_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRepositorynamespace_Enabled), 5, 0)), true);
      }

      protected void RF0Y2( )
      {
         initialize_formulas( ) ;
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E130Y2 ();
            WB0Y0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0Y2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22Id), "ZZZZZZZZZZZ9"), context));
      }

      protected void STRUP0Y0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavRepositoryid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRepositoryid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRepositoryid_Enabled), 5, 0)), true);
         edtavRepositoryguid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRepositoryguid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRepositoryguid_Enabled), 5, 0)), true);
         edtavRepositorynamespace_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRepositorynamespace_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRepositorynamespace_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110Y2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavRepositoryid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavRepositoryid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vREPOSITORYID");
               GX_FocusControl = edtavRepositoryid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV69RepositoryId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69RepositoryId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV69RepositoryId), 9, 0)));
            }
            else
            {
               AV69RepositoryId = (int)(context.localUtil.CToN( cgiGet( edtavRepositoryid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69RepositoryId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV69RepositoryId), 9, 0)));
            }
            AV70RepositoryGUID = cgiGet( edtavRepositoryguid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70RepositoryGUID", AV70RepositoryGUID);
            AV71RepositoryNameSpace = cgiGet( edtavRepositorynamespace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71RepositoryNameSpace", AV71RepositoryNameSpace);
            AV72RepositoryName = cgiGet( edtavRepositoryname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72RepositoryName", AV72RepositoryName);
            AV73RepositoryDescription = cgiGet( edtavRepositorydescription_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73RepositoryDescription", AV73RepositoryDescription);
            cmbavRepositorydefaultauthenticationtypename.CurrentValue = cgiGet( cmbavRepositorydefaultauthenticationtypename_Internalname);
            AV74RepositoryDefaultAuthenticationTypeName = cgiGet( cmbavRepositorydefaultauthenticationtypename_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74RepositoryDefaultAuthenticationTypeName", AV74RepositoryDefaultAuthenticationTypeName);
            AV75RepositorySessionExpiresOnIPChange = StringUtil.StrToBool( cgiGet( chkavRepositorysessionexpiresonipchange_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75RepositorySessionExpiresOnIPChange", AV75RepositorySessionExpiresOnIPChange);
            AV76RepositoryAllowOauthAccess = StringUtil.StrToBool( cgiGet( chkavRepositoryallowoauthaccess_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76RepositoryAllowOauthAccess", AV76RepositoryAllowOauthAccess);
            cmbavRepositorydefaultsecuritypolicyid.CurrentValue = cgiGet( cmbavRepositorydefaultsecuritypolicyid_Internalname);
            AV54RepositoryDefaultSecurityPolicyId = (int)(NumberUtil.Val( cgiGet( cmbavRepositorydefaultsecuritypolicyid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54RepositoryDefaultSecurityPolicyId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV54RepositoryDefaultSecurityPolicyId), 9, 0)));
            cmbavRepositorylogoutbehavior.CurrentValue = cgiGet( cmbavRepositorylogoutbehavior_Internalname);
            AV78RepositoryLogoutBehavior = cgiGet( cmbavRepositorylogoutbehavior_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78RepositoryLogoutBehavior", AV78RepositoryLogoutBehavior);
            cmbavRepositorydefaultroleid.CurrentValue = cgiGet( cmbavRepositorydefaultroleid_Internalname);
            AV77RepositoryDefaultRoleId = (long)(NumberUtil.Val( cgiGet( cmbavRepositorydefaultroleid_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77RepositoryDefaultRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV77RepositoryDefaultRoleId), 12, 0)));
            cmbavRepositoryenabletracing.CurrentValue = cgiGet( cmbavRepositoryenabletracing_Internalname);
            AV79RepositoryEnableTracing = (short)(NumberUtil.Val( cgiGet( cmbavRepositoryenabletracing_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79RepositoryEnableTracing", StringUtil.LTrim( StringUtil.Str( (decimal)(AV79RepositoryEnableTracing), 4, 0)));
            cmbavRepositoryuseridentification.CurrentValue = cgiGet( cmbavRepositoryuseridentification_Internalname);
            AV63RepositoryUserIdentification = cgiGet( cmbavRepositoryuseridentification_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63RepositoryUserIdentification", AV63RepositoryUserIdentification);
            cmbavRepositoryuseractivationmethod.CurrentValue = cgiGet( cmbavRepositoryuseractivationmethod_Internalname);
            AV64RepositoryUserActivationMethod = cgiGet( cmbavRepositoryuseractivationmethod_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64RepositoryUserActivationMethod", AV64RepositoryUserActivationMethod);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavRepositoryautomaticactivationtimeout_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavRepositoryautomaticactivationtimeout_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vREPOSITORYAUTOMATICACTIVATIONTIMEOUT");
               GX_FocusControl = edtavRepositoryautomaticactivationtimeout_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV65RepositoryAutomaticActivationTimeout = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65RepositoryAutomaticActivationTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV65RepositoryAutomaticActivationTimeout), 4, 0)));
            }
            else
            {
               AV65RepositoryAutomaticActivationTimeout = (short)(context.localUtil.CToN( cgiGet( edtavRepositoryautomaticactivationtimeout_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65RepositoryAutomaticActivationTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV65RepositoryAutomaticActivationTimeout), 4, 0)));
            }
            AV66RepositoryUserEmailsUnique = StringUtil.StrToBool( cgiGet( chkavRepositoryuseremailsunique_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66RepositoryUserEmailsUnique", AV66RepositoryUserEmailsUnique);
            AV67RepositoryRequiredEmail = StringUtil.StrToBool( cgiGet( chkavRepositoryrequiredemail_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67RepositoryRequiredEmail", AV67RepositoryRequiredEmail);
            AV68RepositoryRequiredPassword = StringUtil.StrToBool( cgiGet( chkavRepositoryrequiredpassword_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68RepositoryRequiredPassword", AV68RepositoryRequiredPassword);
            AV52RepositoryRequiredFirstName = StringUtil.StrToBool( cgiGet( chkavRepositoryrequiredfirstname_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52RepositoryRequiredFirstName", AV52RepositoryRequiredFirstName);
            AV53RepositoryRequiredLastName = StringUtil.StrToBool( cgiGet( chkavRepositoryrequiredlastname_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53RepositoryRequiredLastName", AV53RepositoryRequiredLastName);
            cmbavRepositorygeneratesessionstatistics.CurrentValue = cgiGet( cmbavRepositorygeneratesessionstatistics_Internalname);
            AV59RepositoryGenerateSessionStatistics = cgiGet( cmbavRepositorygeneratesessionstatistics_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59RepositoryGenerateSessionStatistics", AV59RepositoryGenerateSessionStatistics);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavRepositoryusersessioncachetimeout_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavRepositoryusersessioncachetimeout_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vREPOSITORYUSERSESSIONCACHETIMEOUT");
               GX_FocusControl = edtavRepositoryusersessioncachetimeout_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV58RepositoryUserSessionCacheTimeout = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58RepositoryUserSessionCacheTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV58RepositoryUserSessionCacheTimeout), 9, 0)));
            }
            else
            {
               AV58RepositoryUserSessionCacheTimeout = (int)(context.localUtil.CToN( cgiGet( edtavRepositoryusersessioncachetimeout_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58RepositoryUserSessionCacheTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV58RepositoryUserSessionCacheTimeout), 9, 0)));
            }
            AV57RepositoryGiveAnonymousSession = StringUtil.StrToBool( cgiGet( chkavRepositorygiveanonymoussession_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57RepositoryGiveAnonymousSession", AV57RepositoryGiveAnonymousSession);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavRepositoryloginattemptstolocksession_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavRepositoryloginattemptstolocksession_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vREPOSITORYLOGINATTEMPTSTOLOCKSESSION");
               GX_FocusControl = edtavRepositoryloginattemptstolocksession_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV80RepositoryLoginAttemptsToLockSession = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80RepositoryLoginAttemptsToLockSession", StringUtil.LTrim( StringUtil.Str( (decimal)(AV80RepositoryLoginAttemptsToLockSession), 2, 0)));
            }
            else
            {
               AV80RepositoryLoginAttemptsToLockSession = (short)(context.localUtil.CToN( cgiGet( edtavRepositoryloginattemptstolocksession_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80RepositoryLoginAttemptsToLockSession", StringUtil.LTrim( StringUtil.Str( (decimal)(AV80RepositoryLoginAttemptsToLockSession), 2, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavRepositorygamunblockusertimeout_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavRepositorygamunblockusertimeout_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vREPOSITORYGAMUNBLOCKUSERTIMEOUT");
               GX_FocusControl = edtavRepositorygamunblockusertimeout_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV81RepositoryGAMUnblockUserTimeout = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81RepositoryGAMUnblockUserTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV81RepositoryGAMUnblockUserTimeout), 2, 0)));
            }
            else
            {
               AV81RepositoryGAMUnblockUserTimeout = (short)(context.localUtil.CToN( cgiGet( edtavRepositorygamunblockusertimeout_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81RepositoryGAMUnblockUserTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV81RepositoryGAMUnblockUserTimeout), 2, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavRepositoryloginattemptstolockuser_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavRepositoryloginattemptstolockuser_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vREPOSITORYLOGINATTEMPTSTOLOCKUSER");
               GX_FocusControl = edtavRepositoryloginattemptstolockuser_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV56RepositoryLoginAttemptsToLockUser = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56RepositoryLoginAttemptsToLockUser", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56RepositoryLoginAttemptsToLockUser), 2, 0)));
            }
            else
            {
               AV56RepositoryLoginAttemptsToLockUser = (short)(context.localUtil.CToN( cgiGet( edtavRepositoryloginattemptstolockuser_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56RepositoryLoginAttemptsToLockUser", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56RepositoryLoginAttemptsToLockUser), 2, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavRepositoryminimumamountcharactersinlogin_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavRepositoryminimumamountcharactersinlogin_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vREPOSITORYMINIMUMAMOUNTCHARACTERSINLOGIN");
               GX_FocusControl = edtavRepositoryminimumamountcharactersinlogin_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV55RepositoryMinimumAmountCharactersInLogin = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55RepositoryMinimumAmountCharactersInLogin", StringUtil.LTrim( StringUtil.Str( (decimal)(AV55RepositoryMinimumAmountCharactersInLogin), 2, 0)));
            }
            else
            {
               AV55RepositoryMinimumAmountCharactersInLogin = (short)(context.localUtil.CToN( cgiGet( edtavRepositoryminimumamountcharactersinlogin_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55RepositoryMinimumAmountCharactersInLogin", StringUtil.LTrim( StringUtil.Str( (decimal)(AV55RepositoryMinimumAmountCharactersInLogin), 2, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavRepositoryuserrecoverypasswordkeytimeout_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavRepositoryuserrecoverypasswordkeytimeout_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vREPOSITORYUSERRECOVERYPASSWORDKEYTIMEOUT");
               GX_FocusControl = edtavRepositoryuserrecoverypasswordkeytimeout_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV62RepositoryUserRecoveryPasswordKeyTimeout = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62RepositoryUserRecoveryPasswordKeyTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV62RepositoryUserRecoveryPasswordKeyTimeout), 4, 0)));
            }
            else
            {
               AV62RepositoryUserRecoveryPasswordKeyTimeout = (short)(context.localUtil.CToN( cgiGet( edtavRepositoryuserrecoverypasswordkeytimeout_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62RepositoryUserRecoveryPasswordKeyTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV62RepositoryUserRecoveryPasswordKeyTimeout), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavRepositoryuserremembermetimeout_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavRepositoryuserremembermetimeout_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vREPOSITORYUSERREMEMBERMETIMEOUT");
               GX_FocusControl = edtavRepositoryuserremembermetimeout_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV61RepositoryUserRememberMeTimeout = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61RepositoryUserRememberMeTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV61RepositoryUserRememberMeTimeout), 4, 0)));
            }
            else
            {
               AV61RepositoryUserRememberMeTimeout = (short)(context.localUtil.CToN( cgiGet( edtavRepositoryuserremembermetimeout_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61RepositoryUserRememberMeTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV61RepositoryUserRememberMeTimeout), 4, 0)));
            }
            cmbavRepositoryuserremembermetype.CurrentValue = cgiGet( cmbavRepositoryuserremembermetype_Internalname);
            AV60RepositoryUserRememberMeType = cgiGet( cmbavRepositoryuserremembermetype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60RepositoryUserRememberMeType", AV60RepositoryUserRememberMeType);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavRepositorycachetimeout_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavRepositorycachetimeout_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vREPOSITORYCACHETIMEOUT");
               GX_FocusControl = edtavRepositorycachetimeout_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV33RepositoryCacheTimeout = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33RepositoryCacheTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33RepositoryCacheTimeout), 9, 0)));
            }
            else
            {
               AV33RepositoryCacheTimeout = (int)(context.localUtil.CToN( cgiGet( edtavRepositorycachetimeout_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33RepositoryCacheTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33RepositoryCacheTimeout), 9, 0)));
            }
            /* Read saved values. */
            Gxuitabspanel_tabs_Class = cgiGet( "GXUITABSPANEL_TABS_Class");
            Gxuitabspanel_tabs_Pagecount = (int)(context.localUtil.CToN( cgiGet( "GXUITABSPANEL_TABS_Pagecount"), ",", "."));
            Gxuitabspanel_tabs_Historymanagement = StringUtil.StrToBool( cgiGet( "GXUITABSPANEL_TABS_Historymanagement"));
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
         E110Y2 ();
         if (returnInSub) return;
      }

      protected void E110Y2( )
      {
         /* Start Routine */
         AV23isLoginRepositoryAdm = new SdtGAMRepository(context).isgamadministrator(out  AV15Errors);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23isLoginRepositoryAdm", AV23isLoginRepositoryAdm);
         AV7AuthenticationTypes = new SdtGAMRepository(context).getenabledauthenticationtypes(AV24Language, out  AV15Errors);
         AV89GXV1 = 1;
         while ( AV89GXV1 <= AV7AuthenticationTypes.Count )
         {
            AV6AuthenticationType = ((SdtGAMAuthenticationTypeSimple)AV7AuthenticationTypes.Item(AV89GXV1));
            cmbavRepositorydefaultauthenticationtypename.addItem(AV6AuthenticationType.gxTpr_Name, AV6AuthenticationType.gxTpr_Description, 0);
            AV89GXV1 = (int)(AV89GXV1+1);
         }
         AV41SecurityPolicies = new SdtGAMRepository(context).getsecuritypolicies(AV17FilterSecPol, out  AV15Errors);
         AV90GXV2 = 1;
         while ( AV90GXV2 <= AV41SecurityPolicies.Count )
         {
            AV42SecurityPolicy = ((SdtGAMSecurityPolicy)AV41SecurityPolicies.Item(AV90GXV2));
            cmbavRepositorydefaultsecuritypolicyid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV42SecurityPolicy.gxTpr_Id), 9, 0)), AV42SecurityPolicy.gxTpr_Name, 0);
            AV90GXV2 = (int)(AV90GXV2+1);
         }
         AV39Roles = new SdtGAMRepository(context).getroles(AV16FilterRole, out  AV15Errors);
         AV91GXV3 = 1;
         while ( AV91GXV3 <= AV39Roles.Count )
         {
            AV38Role = ((SdtGAMRole)AV39Roles.Item(AV91GXV3));
            cmbavRepositorydefaultroleid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(AV38Role.gxTpr_Id), 12, 0)), AV38Role.gxTpr_Name, 0);
            AV91GXV3 = (int)(AV91GXV3+1);
         }
         if ( (0==AV31pId) )
         {
            AV22Id = new SdtGAMRepository(context).getid();
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22Id), 12, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22Id), "ZZZZZZZZZZZ9"), context));
         }
         else
         {
            AV22Id = AV31pId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22Id), 12, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22Id), "ZZZZZZZZZZZ9"), context));
         }
         AV32Repository.load( (int)(AV22Id));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22Id), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22Id), "ZZZZZZZZZZZ9"), context));
         AV69RepositoryId = AV32Repository.gxTpr_Id;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69RepositoryId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV69RepositoryId), 9, 0)));
         AV70RepositoryGUID = AV32Repository.gxTpr_Guid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70RepositoryGUID", AV70RepositoryGUID);
         AV71RepositoryNameSpace = AV32Repository.gxTpr_Namespace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71RepositoryNameSpace", AV71RepositoryNameSpace);
         AV72RepositoryName = AV32Repository.gxTpr_Name;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72RepositoryName", AV72RepositoryName);
         AV73RepositoryDescription = AV32Repository.gxTpr_Description;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73RepositoryDescription", AV73RepositoryDescription);
         AV74RepositoryDefaultAuthenticationTypeName = AV32Repository.gxTpr_Defaultauthenticationtypename;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74RepositoryDefaultAuthenticationTypeName", AV74RepositoryDefaultAuthenticationTypeName);
         AV75RepositorySessionExpiresOnIPChange = AV32Repository.gxTpr_Sessionexpiresonipchange;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75RepositorySessionExpiresOnIPChange", AV75RepositorySessionExpiresOnIPChange);
         AV76RepositoryAllowOauthAccess = AV32Repository.gxTpr_Allowoauthaccess;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76RepositoryAllowOauthAccess", AV76RepositoryAllowOauthAccess);
         AV63RepositoryUserIdentification = AV32Repository.gxTpr_Useridentification;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63RepositoryUserIdentification", AV63RepositoryUserIdentification);
         AV64RepositoryUserActivationMethod = AV32Repository.gxTpr_Useractivationmethod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64RepositoryUserActivationMethod", AV64RepositoryUserActivationMethod);
         AV65RepositoryAutomaticActivationTimeout = AV32Repository.gxTpr_Userautomaticactivationtimeout;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65RepositoryAutomaticActivationTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV65RepositoryAutomaticActivationTimeout), 4, 0)));
         AV66RepositoryUserEmailsUnique = AV32Repository.gxTpr_Useremailisunique;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66RepositoryUserEmailsUnique", AV66RepositoryUserEmailsUnique);
         AV59RepositoryGenerateSessionStatistics = AV32Repository.gxTpr_Generatesessionstatistics;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59RepositoryGenerateSessionStatistics", AV59RepositoryGenerateSessionStatistics);
         AV60RepositoryUserRememberMeType = AV32Repository.gxTpr_Userremembermetype;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60RepositoryUserRememberMeType", AV60RepositoryUserRememberMeType);
         AV61RepositoryUserRememberMeTimeout = AV32Repository.gxTpr_Userremembermetimeout;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61RepositoryUserRememberMeTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV61RepositoryUserRememberMeTimeout), 4, 0)));
         AV62RepositoryUserRecoveryPasswordKeyTimeout = AV32Repository.gxTpr_Userrecoverypasswordkeytimeout;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62RepositoryUserRecoveryPasswordKeyTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV62RepositoryUserRecoveryPasswordKeyTimeout), 4, 0)));
         AV55RepositoryMinimumAmountCharactersInLogin = AV32Repository.gxTpr_Minimumamountcharactersinlogin;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55RepositoryMinimumAmountCharactersInLogin", StringUtil.LTrim( StringUtil.Str( (decimal)(AV55RepositoryMinimumAmountCharactersInLogin), 2, 0)));
         AV56RepositoryLoginAttemptsToLockUser = AV32Repository.gxTpr_Loginattemptstolockuser;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56RepositoryLoginAttemptsToLockUser", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56RepositoryLoginAttemptsToLockUser), 2, 0)));
         AV80RepositoryLoginAttemptsToLockSession = AV32Repository.gxTpr_Loginattemptstolocksession;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80RepositoryLoginAttemptsToLockSession", StringUtil.LTrim( StringUtil.Str( (decimal)(AV80RepositoryLoginAttemptsToLockSession), 2, 0)));
         AV57RepositoryGiveAnonymousSession = AV32Repository.gxTpr_Giveanonymoussession;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57RepositoryGiveAnonymousSession", AV57RepositoryGiveAnonymousSession);
         AV58RepositoryUserSessionCacheTimeout = AV32Repository.gxTpr_Usersessioncachetimeout;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58RepositoryUserSessionCacheTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV58RepositoryUserSessionCacheTimeout), 9, 0)));
         AV33RepositoryCacheTimeout = AV32Repository.gxTpr_Cachetimeout;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33RepositoryCacheTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33RepositoryCacheTimeout), 9, 0)));
         AV54RepositoryDefaultSecurityPolicyId = AV32Repository.gxTpr_Defaultsecuritypolicyid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54RepositoryDefaultSecurityPolicyId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV54RepositoryDefaultSecurityPolicyId), 9, 0)));
         AV77RepositoryDefaultRoleId = AV32Repository.gxTpr_Defaultroleid;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77RepositoryDefaultRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV77RepositoryDefaultRoleId), 12, 0)));
         AV52RepositoryRequiredFirstName = AV32Repository.gxTpr_Requiredfirstname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52RepositoryRequiredFirstName", AV52RepositoryRequiredFirstName);
         AV53RepositoryRequiredLastName = AV32Repository.gxTpr_Requiredlastname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53RepositoryRequiredLastName", AV53RepositoryRequiredLastName);
         AV67RepositoryRequiredEmail = AV32Repository.gxTpr_Requiredemail;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67RepositoryRequiredEmail", AV67RepositoryRequiredEmail);
         AV68RepositoryRequiredPassword = AV32Repository.gxTpr_Requiredpassword;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68RepositoryRequiredPassword", AV68RepositoryRequiredPassword);
         AV81RepositoryGAMUnblockUserTimeout = AV32Repository.gxTpr_Gamunblockusertimeout;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81RepositoryGAMUnblockUserTimeout", StringUtil.LTrim( StringUtil.Str( (decimal)(AV81RepositoryGAMUnblockUserTimeout), 2, 0)));
         AV78RepositoryLogoutBehavior = AV32Repository.gxTpr_Gamremotelogoutbehavior;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78RepositoryLogoutBehavior", AV78RepositoryLogoutBehavior);
         AV79RepositoryEnableTracing = AV32Repository.gxTpr_Enabletracing;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79RepositoryEnableTracing", StringUtil.LTrim( StringUtil.Str( (decimal)(AV79RepositoryEnableTracing), 4, 0)));
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         if ( ! ( ! AV23isLoginRepositoryAdm ) )
         {
            cmbavRepositorydefaultauthenticationtypename.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorydefaultauthenticationtypename_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavRepositorydefaultauthenticationtypename.Visible), 5, 0)), true);
            divRepositorydefaultauthenticationtypename_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divRepositorydefaultauthenticationtypename_cell_Internalname, "Class", divRepositorydefaultauthenticationtypename_cell_Class, true);
         }
         else
         {
            cmbavRepositorydefaultauthenticationtypename.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorydefaultauthenticationtypename_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavRepositorydefaultauthenticationtypename.Visible), 5, 0)), true);
            divRepositorydefaultauthenticationtypename_cell_Class = "col-xs-12 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divRepositorydefaultauthenticationtypename_cell_Internalname, "Class", divRepositorydefaultauthenticationtypename_cell_Class, true);
         }
         if ( ! ( ! AV23isLoginRepositoryAdm ) )
         {
            cmbavRepositorydefaultsecuritypolicyid.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorydefaultsecuritypolicyid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavRepositorydefaultsecuritypolicyid.Visible), 5, 0)), true);
            divRepositorydefaultsecuritypolicyid_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divRepositorydefaultsecuritypolicyid_cell_Internalname, "Class", divRepositorydefaultsecuritypolicyid_cell_Class, true);
         }
         else
         {
            cmbavRepositorydefaultsecuritypolicyid.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorydefaultsecuritypolicyid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavRepositorydefaultsecuritypolicyid.Visible), 5, 0)), true);
            divRepositorydefaultsecuritypolicyid_cell_Class = "col-xs-12 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divRepositorydefaultsecuritypolicyid_cell_Internalname, "Class", divRepositorydefaultsecuritypolicyid_cell_Class, true);
         }
         if ( ! ( ! AV23isLoginRepositoryAdm ) )
         {
            cmbavRepositorydefaultroleid.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorydefaultroleid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavRepositorydefaultroleid.Visible), 5, 0)), true);
            divRepositorydefaultroleid_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divRepositorydefaultroleid_cell_Internalname, "Class", divRepositorydefaultroleid_cell_Class, true);
         }
         else
         {
            cmbavRepositorydefaultroleid.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavRepositorydefaultroleid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavRepositorydefaultroleid.Visible), 5, 0)), true);
            divRepositorydefaultroleid_cell_Class = "col-xs-12 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divRepositorydefaultroleid_cell_Internalname, "Class", divRepositorydefaultroleid_cell_Class, true);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E120Y2 ();
         if (returnInSub) return;
      }

      protected void E120Y2( )
      {
         /* Enter Routine */
         AV32Repository.load( (int)(AV22Id));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22Id), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV22Id), "ZZZZZZZZZZZ9"), context));
         AV32Repository.gxTpr_Name = AV72RepositoryName;
         AV32Repository.gxTpr_Description = AV73RepositoryDescription;
         AV32Repository.gxTpr_Defaultauthenticationtypename = AV74RepositoryDefaultAuthenticationTypeName;
         AV32Repository.gxTpr_Sessionexpiresonipchange = AV75RepositorySessionExpiresOnIPChange;
         AV32Repository.gxTpr_Allowoauthaccess = AV76RepositoryAllowOauthAccess;
         AV32Repository.gxTpr_Useridentification = AV63RepositoryUserIdentification;
         AV32Repository.gxTpr_Useractivationmethod = AV64RepositoryUserActivationMethod;
         AV32Repository.gxTpr_Userautomaticactivationtimeout = AV65RepositoryAutomaticActivationTimeout;
         AV32Repository.gxTpr_Useremailisunique = AV66RepositoryUserEmailsUnique;
         AV32Repository.gxTpr_Generatesessionstatistics = AV59RepositoryGenerateSessionStatistics;
         AV32Repository.gxTpr_Userremembermetype = AV60RepositoryUserRememberMeType;
         AV32Repository.gxTpr_Userremembermetimeout = AV61RepositoryUserRememberMeTimeout;
         AV32Repository.gxTpr_Userrecoverypasswordkeytimeout = AV62RepositoryUserRecoveryPasswordKeyTimeout;
         AV32Repository.gxTpr_Minimumamountcharactersinlogin = AV55RepositoryMinimumAmountCharactersInLogin;
         AV32Repository.gxTpr_Loginattemptstolockuser = AV56RepositoryLoginAttemptsToLockUser;
         AV32Repository.gxTpr_Loginattemptstolocksession = AV80RepositoryLoginAttemptsToLockSession;
         AV32Repository.gxTpr_Giveanonymoussession = AV57RepositoryGiveAnonymousSession;
         AV32Repository.gxTpr_Usersessioncachetimeout = AV58RepositoryUserSessionCacheTimeout;
         AV32Repository.gxTpr_Cachetimeout = AV33RepositoryCacheTimeout;
         AV32Repository.gxTpr_Defaultsecuritypolicyid = AV54RepositoryDefaultSecurityPolicyId;
         AV32Repository.gxTpr_Defaultroleid = AV77RepositoryDefaultRoleId;
         AV32Repository.gxTpr_Requiredfirstname = AV52RepositoryRequiredFirstName;
         AV32Repository.gxTpr_Requiredlastname = AV53RepositoryRequiredLastName;
         AV32Repository.gxTpr_Requiredemail = AV67RepositoryRequiredEmail;
         AV32Repository.gxTpr_Requiredpassword = AV68RepositoryRequiredPassword;
         AV32Repository.gxTpr_Gamunblockusertimeout = AV81RepositoryGAMUnblockUserTimeout;
         AV32Repository.gxTpr_Gamremotelogoutbehavior = AV78RepositoryLogoutBehavior;
         AV32Repository.gxTpr_Enabletracing = AV79RepositoryEnableTracing;
         AV32Repository.save();
         if ( AV32Repository.success() )
         {
            pr_gam.commit( "GAMRepositoryConfiguration");
            pr_default.commit( "GAMRepositoryConfiguration");
            GX_msglist.addItem(context.GetMessage( "Os dados foram atualizados com sucesso.", ""));
         }
         else
         {
            AV15Errors = AV32Repository.geterrors();
            AV92GXV4 = 1;
            while ( AV92GXV4 <= AV15Errors.Count )
            {
               AV14Error = ((SdtGAMError)AV15Errors.Item(AV92GXV4));
               GX_msglist.addItem(StringUtil.Format( "%1 (GAM%2)", AV14Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV14Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", ""));
               AV92GXV4 = (int)(AV92GXV4+1);
            }
         }
         /*  Sending Event outputs  */
      }

      protected void nextLoad( )
      {
      }

      protected void E130Y2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV31pId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31pId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31pId), 12, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV31pId), "ZZZZZZZZZZZ9"), context));
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
         PA0Y2( ) ;
         WS0Y2( ) ;
         WE0Y2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019424915", true);
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
         context.AddJavascriptSource("gamrepositoryconfiguration.js", "?201892019424918", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblGeneral_title_Internalname = "GENERAL_TITLE";
         lblTextblockrepositoryid_Internalname = "TEXTBLOCKREPOSITORYID";
         edtavRepositoryid_Internalname = "vREPOSITORYID";
         divUnnamedtablerepositoryid_Internalname = "UNNAMEDTABLEREPOSITORYID";
         lblTextblockrepositoryguid_Internalname = "TEXTBLOCKREPOSITORYGUID";
         edtavRepositoryguid_Internalname = "vREPOSITORYGUID";
         divUnnamedtablerepositoryguid_Internalname = "UNNAMEDTABLEREPOSITORYGUID";
         lblTextblockrepositorynamespace_Internalname = "TEXTBLOCKREPOSITORYNAMESPACE";
         edtavRepositorynamespace_Internalname = "vREPOSITORYNAMESPACE";
         divUnnamedtablerepositorynamespace_Internalname = "UNNAMEDTABLEREPOSITORYNAMESPACE";
         lblTextblockrepositoryname_Internalname = "TEXTBLOCKREPOSITORYNAME";
         edtavRepositoryname_Internalname = "vREPOSITORYNAME";
         divUnnamedtablerepositoryname_Internalname = "UNNAMEDTABLEREPOSITORYNAME";
         lblTextblockrepositorydescription_Internalname = "TEXTBLOCKREPOSITORYDESCRIPTION";
         edtavRepositorydescription_Internalname = "vREPOSITORYDESCRIPTION";
         divUnnamedtablerepositorydescription_Internalname = "UNNAMEDTABLEREPOSITORYDESCRIPTION";
         lblTextblockrepositorydefaultauthenticationtypename_Internalname = "TEXTBLOCKREPOSITORYDEFAULTAUTHENTICATIONTYPENAME";
         cmbavRepositorydefaultauthenticationtypename_Internalname = "vREPOSITORYDEFAULTAUTHENTICATIONTYPENAME";
         divUnnamedtablerepositorydefaultauthenticationtypename_Internalname = "UNNAMEDTABLEREPOSITORYDEFAULTAUTHENTICATIONTYPENAME";
         divRepositorydefaultauthenticationtypename_cell_Internalname = "REPOSITORYDEFAULTAUTHENTICATIONTYPENAME_CELL";
         lblTextblockrepositorysessionexpiresonipchange_Internalname = "TEXTBLOCKREPOSITORYSESSIONEXPIRESONIPCHANGE";
         chkavRepositorysessionexpiresonipchange_Internalname = "vREPOSITORYSESSIONEXPIRESONIPCHANGE";
         divUnnamedtablerepositorysessionexpiresonipchange_Internalname = "UNNAMEDTABLEREPOSITORYSESSIONEXPIRESONIPCHANGE";
         lblTextblockrepositoryallowoauthaccess_Internalname = "TEXTBLOCKREPOSITORYALLOWOAUTHACCESS";
         chkavRepositoryallowoauthaccess_Internalname = "vREPOSITORYALLOWOAUTHACCESS";
         divUnnamedtablerepositoryallowoauthaccess_Internalname = "UNNAMEDTABLEREPOSITORYALLOWOAUTHACCESS";
         lblTextblockrepositorydefaultsecuritypolicyid_Internalname = "TEXTBLOCKREPOSITORYDEFAULTSECURITYPOLICYID";
         cmbavRepositorydefaultsecuritypolicyid_Internalname = "vREPOSITORYDEFAULTSECURITYPOLICYID";
         divUnnamedtablerepositorydefaultsecuritypolicyid_Internalname = "UNNAMEDTABLEREPOSITORYDEFAULTSECURITYPOLICYID";
         divRepositorydefaultsecuritypolicyid_cell_Internalname = "REPOSITORYDEFAULTSECURITYPOLICYID_CELL";
         lblTextblockrepositorylogoutbehavior_Internalname = "TEXTBLOCKREPOSITORYLOGOUTBEHAVIOR";
         cmbavRepositorylogoutbehavior_Internalname = "vREPOSITORYLOGOUTBEHAVIOR";
         divUnnamedtablerepositorylogoutbehavior_Internalname = "UNNAMEDTABLEREPOSITORYLOGOUTBEHAVIOR";
         lblTextblockrepositorydefaultroleid_Internalname = "TEXTBLOCKREPOSITORYDEFAULTROLEID";
         cmbavRepositorydefaultroleid_Internalname = "vREPOSITORYDEFAULTROLEID";
         divUnnamedtablerepositorydefaultroleid_Internalname = "UNNAMEDTABLEREPOSITORYDEFAULTROLEID";
         divRepositorydefaultroleid_cell_Internalname = "REPOSITORYDEFAULTROLEID_CELL";
         lblTextblockrepositoryenabletracing_Internalname = "TEXTBLOCKREPOSITORYENABLETRACING";
         cmbavRepositoryenabletracing_Internalname = "vREPOSITORYENABLETRACING";
         divUnnamedtablerepositoryenabletracing_Internalname = "UNNAMEDTABLEREPOSITORYENABLETRACING";
         divUnnamedtable3_Internalname = "UNNAMEDTABLE3";
         lblUsers_title_Internalname = "USERS_TITLE";
         lblTextblockrepositoryuseridentification_Internalname = "TEXTBLOCKREPOSITORYUSERIDENTIFICATION";
         cmbavRepositoryuseridentification_Internalname = "vREPOSITORYUSERIDENTIFICATION";
         divUnnamedtablerepositoryuseridentification_Internalname = "UNNAMEDTABLEREPOSITORYUSERIDENTIFICATION";
         lblTextblockrepositoryuseractivationmethod_Internalname = "TEXTBLOCKREPOSITORYUSERACTIVATIONMETHOD";
         cmbavRepositoryuseractivationmethod_Internalname = "vREPOSITORYUSERACTIVATIONMETHOD";
         divUnnamedtablerepositoryuseractivationmethod_Internalname = "UNNAMEDTABLEREPOSITORYUSERACTIVATIONMETHOD";
         lblTextblockrepositoryautomaticactivationtimeout_Internalname = "TEXTBLOCKREPOSITORYAUTOMATICACTIVATIONTIMEOUT";
         edtavRepositoryautomaticactivationtimeout_Internalname = "vREPOSITORYAUTOMATICACTIVATIONTIMEOUT";
         divUnnamedtablerepositoryautomaticactivationtimeout_Internalname = "UNNAMEDTABLEREPOSITORYAUTOMATICACTIVATIONTIMEOUT";
         lblTextblockrepositoryuseremailsunique_Internalname = "TEXTBLOCKREPOSITORYUSEREMAILSUNIQUE";
         chkavRepositoryuseremailsunique_Internalname = "vREPOSITORYUSEREMAILSUNIQUE";
         divUnnamedtablerepositoryuseremailsunique_Internalname = "UNNAMEDTABLEREPOSITORYUSEREMAILSUNIQUE";
         lblTextblockrepositoryrequiredemail_Internalname = "TEXTBLOCKREPOSITORYREQUIREDEMAIL";
         chkavRepositoryrequiredemail_Internalname = "vREPOSITORYREQUIREDEMAIL";
         divUnnamedtablerepositoryrequiredemail_Internalname = "UNNAMEDTABLEREPOSITORYREQUIREDEMAIL";
         lblTextblockrepositoryrequiredpassword_Internalname = "TEXTBLOCKREPOSITORYREQUIREDPASSWORD";
         chkavRepositoryrequiredpassword_Internalname = "vREPOSITORYREQUIREDPASSWORD";
         divUnnamedtablerepositoryrequiredpassword_Internalname = "UNNAMEDTABLEREPOSITORYREQUIREDPASSWORD";
         lblTextblockrepositoryrequiredfirstname_Internalname = "TEXTBLOCKREPOSITORYREQUIREDFIRSTNAME";
         chkavRepositoryrequiredfirstname_Internalname = "vREPOSITORYREQUIREDFIRSTNAME";
         divUnnamedtablerepositoryrequiredfirstname_Internalname = "UNNAMEDTABLEREPOSITORYREQUIREDFIRSTNAME";
         lblTextblockrepositoryrequiredlastname_Internalname = "TEXTBLOCKREPOSITORYREQUIREDLASTNAME";
         chkavRepositoryrequiredlastname_Internalname = "vREPOSITORYREQUIREDLASTNAME";
         divUnnamedtablerepositoryrequiredlastname_Internalname = "UNNAMEDTABLEREPOSITORYREQUIREDLASTNAME";
         divUnnamedtable2_Internalname = "UNNAMEDTABLE2";
         lblSession_title_Internalname = "SESSION_TITLE";
         lblTextblockrepositorygeneratesessionstatistics_Internalname = "TEXTBLOCKREPOSITORYGENERATESESSIONSTATISTICS";
         cmbavRepositorygeneratesessionstatistics_Internalname = "vREPOSITORYGENERATESESSIONSTATISTICS";
         divUnnamedtablerepositorygeneratesessionstatistics_Internalname = "UNNAMEDTABLEREPOSITORYGENERATESESSIONSTATISTICS";
         lblTextblockrepositoryusersessioncachetimeout_Internalname = "TEXTBLOCKREPOSITORYUSERSESSIONCACHETIMEOUT";
         edtavRepositoryusersessioncachetimeout_Internalname = "vREPOSITORYUSERSESSIONCACHETIMEOUT";
         divUnnamedtablerepositoryusersessioncachetimeout_Internalname = "UNNAMEDTABLEREPOSITORYUSERSESSIONCACHETIMEOUT";
         lblTextblockrepositorygiveanonymoussession_Internalname = "TEXTBLOCKREPOSITORYGIVEANONYMOUSSESSION";
         chkavRepositorygiveanonymoussession_Internalname = "vREPOSITORYGIVEANONYMOUSSESSION";
         divUnnamedtablerepositorygiveanonymoussession_Internalname = "UNNAMEDTABLEREPOSITORYGIVEANONYMOUSSESSION";
         lblTextblockrepositoryloginattemptstolocksession_Internalname = "TEXTBLOCKREPOSITORYLOGINATTEMPTSTOLOCKSESSION";
         edtavRepositoryloginattemptstolocksession_Internalname = "vREPOSITORYLOGINATTEMPTSTOLOCKSESSION";
         divUnnamedtablerepositoryloginattemptstolocksession_Internalname = "UNNAMEDTABLEREPOSITORYLOGINATTEMPTSTOLOCKSESSION";
         lblTextblockrepositorygamunblockusertimeout_Internalname = "TEXTBLOCKREPOSITORYGAMUNBLOCKUSERTIMEOUT";
         edtavRepositorygamunblockusertimeout_Internalname = "vREPOSITORYGAMUNBLOCKUSERTIMEOUT";
         divUnnamedtablerepositorygamunblockusertimeout_Internalname = "UNNAMEDTABLEREPOSITORYGAMUNBLOCKUSERTIMEOUT";
         lblTextblockrepositoryloginattemptstolockuser_Internalname = "TEXTBLOCKREPOSITORYLOGINATTEMPTSTOLOCKUSER";
         edtavRepositoryloginattemptstolockuser_Internalname = "vREPOSITORYLOGINATTEMPTSTOLOCKUSER";
         divUnnamedtablerepositoryloginattemptstolockuser_Internalname = "UNNAMEDTABLEREPOSITORYLOGINATTEMPTSTOLOCKUSER";
         lblTextblockrepositoryminimumamountcharactersinlogin_Internalname = "TEXTBLOCKREPOSITORYMINIMUMAMOUNTCHARACTERSINLOGIN";
         edtavRepositoryminimumamountcharactersinlogin_Internalname = "vREPOSITORYMINIMUMAMOUNTCHARACTERSINLOGIN";
         divUnnamedtablerepositoryminimumamountcharactersinlogin_Internalname = "UNNAMEDTABLEREPOSITORYMINIMUMAMOUNTCHARACTERSINLOGIN";
         lblTextblockrepositoryuserrecoverypasswordkeytimeout_Internalname = "TEXTBLOCKREPOSITORYUSERRECOVERYPASSWORDKEYTIMEOUT";
         edtavRepositoryuserrecoverypasswordkeytimeout_Internalname = "vREPOSITORYUSERRECOVERYPASSWORDKEYTIMEOUT";
         divUnnamedtablerepositoryuserrecoverypasswordkeytimeout_Internalname = "UNNAMEDTABLEREPOSITORYUSERRECOVERYPASSWORDKEYTIMEOUT";
         lblTextblockrepositoryuserremembermetimeout_Internalname = "TEXTBLOCKREPOSITORYUSERREMEMBERMETIMEOUT";
         edtavRepositoryuserremembermetimeout_Internalname = "vREPOSITORYUSERREMEMBERMETIMEOUT";
         divUnnamedtablerepositoryuserremembermetimeout_Internalname = "UNNAMEDTABLEREPOSITORYUSERREMEMBERMETIMEOUT";
         lblTextblockrepositoryuserremembermetype_Internalname = "TEXTBLOCKREPOSITORYUSERREMEMBERMETYPE";
         cmbavRepositoryuserremembermetype_Internalname = "vREPOSITORYUSERREMEMBERMETYPE";
         divUnnamedtablerepositoryuserremembermetype_Internalname = "UNNAMEDTABLEREPOSITORYUSERREMEMBERMETYPE";
         lblTextblockrepositorycachetimeout_Internalname = "TEXTBLOCKREPOSITORYCACHETIMEOUT";
         edtavRepositorycachetimeout_Internalname = "vREPOSITORYCACHETIMEOUT";
         divUnnamedtablerepositorycachetimeout_Internalname = "UNNAMEDTABLEREPOSITORYCACHETIMEOUT";
         divUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         Gxuitabspanel_tabs_Internalname = "GXUITABSPANEL_TABS";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
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
         chkavRepositorygiveanonymoussession.Caption = "Repository Give Anonymous Session";
         chkavRepositoryrequiredlastname.Caption = "Repository Required Last Name";
         chkavRepositoryrequiredfirstname.Caption = "Repository Required First Name";
         chkavRepositoryrequiredpassword.Caption = "Repository Required Password";
         chkavRepositoryrequiredemail.Caption = "Repository Required Email";
         chkavRepositoryuseremailsunique.Caption = "Repository User Emails Unique";
         chkavRepositoryallowoauthaccess.Caption = "Repository Allow Oauth Access";
         chkavRepositorysessionexpiresonipchange.Caption = "Repository Session Expires On IPChange";
         edtavRepositorycachetimeout_Jsonclick = "";
         edtavRepositorycachetimeout_Enabled = 1;
         cmbavRepositoryuserremembermetype_Jsonclick = "";
         cmbavRepositoryuserremembermetype.Enabled = 1;
         edtavRepositoryuserremembermetimeout_Jsonclick = "";
         edtavRepositoryuserremembermetimeout_Enabled = 1;
         edtavRepositoryuserrecoverypasswordkeytimeout_Jsonclick = "";
         edtavRepositoryuserrecoverypasswordkeytimeout_Enabled = 1;
         edtavRepositoryminimumamountcharactersinlogin_Jsonclick = "";
         edtavRepositoryminimumamountcharactersinlogin_Enabled = 1;
         edtavRepositoryloginattemptstolockuser_Jsonclick = "";
         edtavRepositoryloginattemptstolockuser_Enabled = 1;
         edtavRepositorygamunblockusertimeout_Jsonclick = "";
         edtavRepositorygamunblockusertimeout_Enabled = 1;
         edtavRepositoryloginattemptstolocksession_Jsonclick = "";
         edtavRepositoryloginattemptstolocksession_Enabled = 1;
         chkavRepositorygiveanonymoussession.Enabled = 1;
         edtavRepositoryusersessioncachetimeout_Jsonclick = "";
         edtavRepositoryusersessioncachetimeout_Enabled = 1;
         cmbavRepositorygeneratesessionstatistics_Jsonclick = "";
         cmbavRepositorygeneratesessionstatistics.Enabled = 1;
         chkavRepositoryrequiredlastname.Enabled = 1;
         chkavRepositoryrequiredfirstname.Enabled = 1;
         chkavRepositoryrequiredpassword.Enabled = 1;
         chkavRepositoryrequiredemail.Enabled = 1;
         chkavRepositoryuseremailsunique.Enabled = 1;
         edtavRepositoryautomaticactivationtimeout_Jsonclick = "";
         edtavRepositoryautomaticactivationtimeout_Enabled = 1;
         cmbavRepositoryuseractivationmethod_Jsonclick = "";
         cmbavRepositoryuseractivationmethod.Enabled = 1;
         cmbavRepositoryuseridentification_Jsonclick = "";
         cmbavRepositoryuseridentification.Enabled = 1;
         cmbavRepositoryenabletracing_Jsonclick = "";
         cmbavRepositoryenabletracing.Enabled = 1;
         cmbavRepositorydefaultroleid_Jsonclick = "";
         cmbavRepositorydefaultroleid.Enabled = 1;
         cmbavRepositorydefaultroleid.Visible = 1;
         divRepositorydefaultroleid_cell_Class = "col-xs-12";
         cmbavRepositorylogoutbehavior_Jsonclick = "";
         cmbavRepositorylogoutbehavior.Enabled = 1;
         cmbavRepositorydefaultsecuritypolicyid_Jsonclick = "";
         cmbavRepositorydefaultsecuritypolicyid.Enabled = 1;
         cmbavRepositorydefaultsecuritypolicyid.Visible = 1;
         divRepositorydefaultsecuritypolicyid_cell_Class = "col-xs-12";
         chkavRepositoryallowoauthaccess.Enabled = 1;
         chkavRepositorysessionexpiresonipchange.Enabled = 1;
         cmbavRepositorydefaultauthenticationtypename_Jsonclick = "";
         cmbavRepositorydefaultauthenticationtypename.Enabled = 1;
         cmbavRepositorydefaultauthenticationtypename.Visible = 1;
         divRepositorydefaultauthenticationtypename_cell_Class = "col-xs-12";
         edtavRepositorydescription_Jsonclick = "";
         edtavRepositorydescription_Enabled = 1;
         edtavRepositoryname_Jsonclick = "";
         edtavRepositoryname_Enabled = 1;
         edtavRepositorynamespace_Jsonclick = "";
         edtavRepositorynamespace_Enabled = 1;
         edtavRepositoryguid_Jsonclick = "";
         edtavRepositoryguid_Enabled = 1;
         edtavRepositoryid_Jsonclick = "";
         edtavRepositoryid_Enabled = 1;
         Gxuitabspanel_tabs_Historymanagement = Convert.ToBoolean( 0);
         Gxuitabspanel_tabs_Pagecount = 3;
         Gxuitabspanel_tabs_Class = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Repository configuration ";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV31pId',fld:'vPID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV22Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("ENTER","{handler:'E120Y2',iparms:[{av:'AV22Id',fld:'vID',pic:'ZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV72RepositoryName',fld:'vREPOSITORYNAME',pic:'',nv:''},{av:'AV73RepositoryDescription',fld:'vREPOSITORYDESCRIPTION',pic:'',nv:''},{av:'cmbavRepositorydefaultauthenticationtypename'},{av:'AV74RepositoryDefaultAuthenticationTypeName',fld:'vREPOSITORYDEFAULTAUTHENTICATIONTYPENAME',pic:'',nv:''},{av:'AV75RepositorySessionExpiresOnIPChange',fld:'vREPOSITORYSESSIONEXPIRESONIPCHANGE',pic:'',nv:false},{av:'AV76RepositoryAllowOauthAccess',fld:'vREPOSITORYALLOWOAUTHACCESS',pic:'',nv:false},{av:'cmbavRepositoryuseridentification'},{av:'AV63RepositoryUserIdentification',fld:'vREPOSITORYUSERIDENTIFICATION',pic:'',nv:''},{av:'cmbavRepositoryuseractivationmethod'},{av:'AV64RepositoryUserActivationMethod',fld:'vREPOSITORYUSERACTIVATIONMETHOD',pic:'',nv:''},{av:'AV65RepositoryAutomaticActivationTimeout',fld:'vREPOSITORYAUTOMATICACTIVATIONTIMEOUT',pic:'ZZZ9',nv:0},{av:'AV66RepositoryUserEmailsUnique',fld:'vREPOSITORYUSEREMAILSUNIQUE',pic:'',nv:false},{av:'cmbavRepositorygeneratesessionstatistics'},{av:'AV59RepositoryGenerateSessionStatistics',fld:'vREPOSITORYGENERATESESSIONSTATISTICS',pic:'',nv:''},{av:'cmbavRepositoryuserremembermetype'},{av:'AV60RepositoryUserRememberMeType',fld:'vREPOSITORYUSERREMEMBERMETYPE',pic:'',nv:''},{av:'AV61RepositoryUserRememberMeTimeout',fld:'vREPOSITORYUSERREMEMBERMETIMEOUT',pic:'ZZZ9',nv:0},{av:'AV62RepositoryUserRecoveryPasswordKeyTimeout',fld:'vREPOSITORYUSERRECOVERYPASSWORDKEYTIMEOUT',pic:'ZZZ9',nv:0},{av:'AV55RepositoryMinimumAmountCharactersInLogin',fld:'vREPOSITORYMINIMUMAMOUNTCHARACTERSINLOGIN',pic:'Z9',nv:0},{av:'AV56RepositoryLoginAttemptsToLockUser',fld:'vREPOSITORYLOGINATTEMPTSTOLOCKUSER',pic:'Z9',nv:0},{av:'AV80RepositoryLoginAttemptsToLockSession',fld:'vREPOSITORYLOGINATTEMPTSTOLOCKSESSION',pic:'Z9',nv:0},{av:'AV57RepositoryGiveAnonymousSession',fld:'vREPOSITORYGIVEANONYMOUSSESSION',pic:'',nv:false},{av:'AV58RepositoryUserSessionCacheTimeout',fld:'vREPOSITORYUSERSESSIONCACHETIMEOUT',pic:'ZZZZZZZZ9',nv:0},{av:'AV33RepositoryCacheTimeout',fld:'vREPOSITORYCACHETIMEOUT',pic:'ZZZZZZZZ9',nv:0},{av:'cmbavRepositorydefaultsecuritypolicyid'},{av:'AV54RepositoryDefaultSecurityPolicyId',fld:'vREPOSITORYDEFAULTSECURITYPOLICYID',pic:'ZZZZZZZZ9',nv:0},{av:'cmbavRepositorydefaultroleid'},{av:'AV77RepositoryDefaultRoleId',fld:'vREPOSITORYDEFAULTROLEID',pic:'ZZZZZZZZZZZ9',nv:0},{av:'AV52RepositoryRequiredFirstName',fld:'vREPOSITORYREQUIREDFIRSTNAME',pic:'',nv:false},{av:'AV53RepositoryRequiredLastName',fld:'vREPOSITORYREQUIREDLASTNAME',pic:'',nv:false},{av:'AV67RepositoryRequiredEmail',fld:'vREPOSITORYREQUIREDEMAIL',pic:'',nv:false},{av:'AV68RepositoryRequiredPassword',fld:'vREPOSITORYREQUIREDPASSWORD',pic:'',nv:false},{av:'AV81RepositoryGAMUnblockUserTimeout',fld:'vREPOSITORYGAMUNBLOCKUSERTIMEOUT',pic:'Z9',nv:0},{av:'cmbavRepositorylogoutbehavior'},{av:'AV78RepositoryLogoutBehavior',fld:'vREPOSITORYLOGOUTBEHAVIOR',pic:'',nv:''},{av:'cmbavRepositoryenabletracing'},{av:'AV79RepositoryEnableTracing',fld:'vREPOSITORYENABLETRACING',pic:'ZZZ9',nv:0}],oparms:[]}");
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
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         lblGeneral_title_Jsonclick = "";
         lblTextblockrepositoryid_Jsonclick = "";
         TempTags = "";
         lblTextblockrepositoryguid_Jsonclick = "";
         AV70RepositoryGUID = "";
         lblTextblockrepositorynamespace_Jsonclick = "";
         AV71RepositoryNameSpace = "";
         lblTextblockrepositoryname_Jsonclick = "";
         AV72RepositoryName = "";
         lblTextblockrepositorydescription_Jsonclick = "";
         AV73RepositoryDescription = "";
         lblTextblockrepositorydefaultauthenticationtypename_Jsonclick = "";
         AV74RepositoryDefaultAuthenticationTypeName = "";
         lblTextblockrepositorysessionexpiresonipchange_Jsonclick = "";
         lblTextblockrepositoryallowoauthaccess_Jsonclick = "";
         lblTextblockrepositorydefaultsecuritypolicyid_Jsonclick = "";
         lblTextblockrepositorylogoutbehavior_Jsonclick = "";
         AV78RepositoryLogoutBehavior = "";
         lblTextblockrepositorydefaultroleid_Jsonclick = "";
         lblTextblockrepositoryenabletracing_Jsonclick = "";
         lblUsers_title_Jsonclick = "";
         lblTextblockrepositoryuseridentification_Jsonclick = "";
         AV63RepositoryUserIdentification = "";
         lblTextblockrepositoryuseractivationmethod_Jsonclick = "";
         AV64RepositoryUserActivationMethod = "";
         lblTextblockrepositoryautomaticactivationtimeout_Jsonclick = "";
         lblTextblockrepositoryuseremailsunique_Jsonclick = "";
         lblTextblockrepositoryrequiredemail_Jsonclick = "";
         lblTextblockrepositoryrequiredpassword_Jsonclick = "";
         lblTextblockrepositoryrequiredfirstname_Jsonclick = "";
         lblTextblockrepositoryrequiredlastname_Jsonclick = "";
         lblSession_title_Jsonclick = "";
         lblTextblockrepositorygeneratesessionstatistics_Jsonclick = "";
         AV59RepositoryGenerateSessionStatistics = "";
         lblTextblockrepositoryusersessioncachetimeout_Jsonclick = "";
         lblTextblockrepositorygiveanonymoussession_Jsonclick = "";
         lblTextblockrepositoryloginattemptstolocksession_Jsonclick = "";
         lblTextblockrepositorygamunblockusertimeout_Jsonclick = "";
         lblTextblockrepositoryloginattemptstolockuser_Jsonclick = "";
         lblTextblockrepositoryminimumamountcharactersinlogin_Jsonclick = "";
         lblTextblockrepositoryuserrecoverypasswordkeytimeout_Jsonclick = "";
         lblTextblockrepositoryuserremembermetimeout_Jsonclick = "";
         lblTextblockrepositoryuserremembermetype_Jsonclick = "";
         AV60RepositoryUserRememberMeType = "";
         lblTextblockrepositorycachetimeout_Jsonclick = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV15Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV7AuthenticationTypes = new GXExternalCollection<SdtGAMAuthenticationTypeSimple>( context, "SdtGAMAuthenticationTypeSimple", "GeneXus.Programs");
         AV24Language = "";
         AV6AuthenticationType = new SdtGAMAuthenticationTypeSimple(context);
         AV41SecurityPolicies = new GXExternalCollection<SdtGAMSecurityPolicy>( context, "SdtGAMSecurityPolicy", "GeneXus.Programs");
         AV17FilterSecPol = new SdtGAMSecurityPolicyFilter(context);
         AV42SecurityPolicy = new SdtGAMSecurityPolicy(context);
         AV39Roles = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         AV16FilterRole = new SdtGAMRoleFilter(context);
         AV38Role = new SdtGAMRole(context);
         AV32Repository = new SdtGAMRepository(context);
         AV14Error = new SdtGAMError(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gamrepositoryconfiguration__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gamrepositoryconfiguration__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavRepositoryid_Enabled = 0;
         edtavRepositoryguid_Enabled = 0;
         edtavRepositorynamespace_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short AV79RepositoryEnableTracing ;
      private short AV65RepositoryAutomaticActivationTimeout ;
      private short AV80RepositoryLoginAttemptsToLockSession ;
      private short AV81RepositoryGAMUnblockUserTimeout ;
      private short AV56RepositoryLoginAttemptsToLockUser ;
      private short AV55RepositoryMinimumAmountCharactersInLogin ;
      private short AV62RepositoryUserRecoveryPasswordKeyTimeout ;
      private short AV61RepositoryUserRememberMeTimeout ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int Gxuitabspanel_tabs_Pagecount ;
      private int AV69RepositoryId ;
      private int edtavRepositoryid_Enabled ;
      private int edtavRepositoryguid_Enabled ;
      private int edtavRepositorynamespace_Enabled ;
      private int edtavRepositoryname_Enabled ;
      private int edtavRepositorydescription_Enabled ;
      private int AV54RepositoryDefaultSecurityPolicyId ;
      private int edtavRepositoryautomaticactivationtimeout_Enabled ;
      private int AV58RepositoryUserSessionCacheTimeout ;
      private int edtavRepositoryusersessioncachetimeout_Enabled ;
      private int edtavRepositoryloginattemptstolocksession_Enabled ;
      private int edtavRepositorygamunblockusertimeout_Enabled ;
      private int edtavRepositoryloginattemptstolockuser_Enabled ;
      private int edtavRepositoryminimumamountcharactersinlogin_Enabled ;
      private int edtavRepositoryuserrecoverypasswordkeytimeout_Enabled ;
      private int edtavRepositoryuserremembermetimeout_Enabled ;
      private int AV33RepositoryCacheTimeout ;
      private int edtavRepositorycachetimeout_Enabled ;
      private int AV89GXV1 ;
      private int AV90GXV2 ;
      private int AV91GXV3 ;
      private int AV92GXV4 ;
      private int idxLst ;
      private long AV31pId ;
      private long wcpOAV31pId ;
      private long AV22Id ;
      private long AV77RepositoryDefaultRoleId ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String Gxuitabspanel_tabs_Class ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divTablecontent_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblGeneral_title_Internalname ;
      private String lblGeneral_title_Jsonclick ;
      private String divUnnamedtable3_Internalname ;
      private String divUnnamedtablerepositoryid_Internalname ;
      private String lblTextblockrepositoryid_Internalname ;
      private String lblTextblockrepositoryid_Jsonclick ;
      private String edtavRepositoryid_Internalname ;
      private String TempTags ;
      private String edtavRepositoryid_Jsonclick ;
      private String divUnnamedtablerepositoryguid_Internalname ;
      private String lblTextblockrepositoryguid_Internalname ;
      private String lblTextblockrepositoryguid_Jsonclick ;
      private String edtavRepositoryguid_Internalname ;
      private String AV70RepositoryGUID ;
      private String edtavRepositoryguid_Jsonclick ;
      private String divUnnamedtablerepositorynamespace_Internalname ;
      private String lblTextblockrepositorynamespace_Internalname ;
      private String lblTextblockrepositorynamespace_Jsonclick ;
      private String edtavRepositorynamespace_Internalname ;
      private String AV71RepositoryNameSpace ;
      private String edtavRepositorynamespace_Jsonclick ;
      private String divUnnamedtablerepositoryname_Internalname ;
      private String lblTextblockrepositoryname_Internalname ;
      private String lblTextblockrepositoryname_Jsonclick ;
      private String edtavRepositoryname_Internalname ;
      private String AV72RepositoryName ;
      private String edtavRepositoryname_Jsonclick ;
      private String divUnnamedtablerepositorydescription_Internalname ;
      private String lblTextblockrepositorydescription_Internalname ;
      private String lblTextblockrepositorydescription_Jsonclick ;
      private String edtavRepositorydescription_Internalname ;
      private String AV73RepositoryDescription ;
      private String edtavRepositorydescription_Jsonclick ;
      private String divRepositorydefaultauthenticationtypename_cell_Internalname ;
      private String divRepositorydefaultauthenticationtypename_cell_Class ;
      private String divUnnamedtablerepositorydefaultauthenticationtypename_Internalname ;
      private String lblTextblockrepositorydefaultauthenticationtypename_Internalname ;
      private String lblTextblockrepositorydefaultauthenticationtypename_Jsonclick ;
      private String cmbavRepositorydefaultauthenticationtypename_Internalname ;
      private String AV74RepositoryDefaultAuthenticationTypeName ;
      private String cmbavRepositorydefaultauthenticationtypename_Jsonclick ;
      private String divUnnamedtablerepositorysessionexpiresonipchange_Internalname ;
      private String lblTextblockrepositorysessionexpiresonipchange_Internalname ;
      private String lblTextblockrepositorysessionexpiresonipchange_Jsonclick ;
      private String chkavRepositorysessionexpiresonipchange_Internalname ;
      private String divUnnamedtablerepositoryallowoauthaccess_Internalname ;
      private String lblTextblockrepositoryallowoauthaccess_Internalname ;
      private String lblTextblockrepositoryallowoauthaccess_Jsonclick ;
      private String chkavRepositoryallowoauthaccess_Internalname ;
      private String divRepositorydefaultsecuritypolicyid_cell_Internalname ;
      private String divRepositorydefaultsecuritypolicyid_cell_Class ;
      private String divUnnamedtablerepositorydefaultsecuritypolicyid_Internalname ;
      private String lblTextblockrepositorydefaultsecuritypolicyid_Internalname ;
      private String lblTextblockrepositorydefaultsecuritypolicyid_Jsonclick ;
      private String cmbavRepositorydefaultsecuritypolicyid_Internalname ;
      private String cmbavRepositorydefaultsecuritypolicyid_Jsonclick ;
      private String divUnnamedtablerepositorylogoutbehavior_Internalname ;
      private String lblTextblockrepositorylogoutbehavior_Internalname ;
      private String lblTextblockrepositorylogoutbehavior_Jsonclick ;
      private String cmbavRepositorylogoutbehavior_Internalname ;
      private String AV78RepositoryLogoutBehavior ;
      private String cmbavRepositorylogoutbehavior_Jsonclick ;
      private String divRepositorydefaultroleid_cell_Internalname ;
      private String divRepositorydefaultroleid_cell_Class ;
      private String divUnnamedtablerepositorydefaultroleid_Internalname ;
      private String lblTextblockrepositorydefaultroleid_Internalname ;
      private String lblTextblockrepositorydefaultroleid_Jsonclick ;
      private String cmbavRepositorydefaultroleid_Internalname ;
      private String cmbavRepositorydefaultroleid_Jsonclick ;
      private String divUnnamedtablerepositoryenabletracing_Internalname ;
      private String lblTextblockrepositoryenabletracing_Internalname ;
      private String lblTextblockrepositoryenabletracing_Jsonclick ;
      private String cmbavRepositoryenabletracing_Internalname ;
      private String cmbavRepositoryenabletracing_Jsonclick ;
      private String lblUsers_title_Internalname ;
      private String lblUsers_title_Jsonclick ;
      private String divUnnamedtable2_Internalname ;
      private String divUnnamedtablerepositoryuseridentification_Internalname ;
      private String lblTextblockrepositoryuseridentification_Internalname ;
      private String lblTextblockrepositoryuseridentification_Jsonclick ;
      private String cmbavRepositoryuseridentification_Internalname ;
      private String AV63RepositoryUserIdentification ;
      private String cmbavRepositoryuseridentification_Jsonclick ;
      private String divUnnamedtablerepositoryuseractivationmethod_Internalname ;
      private String lblTextblockrepositoryuseractivationmethod_Internalname ;
      private String lblTextblockrepositoryuseractivationmethod_Jsonclick ;
      private String cmbavRepositoryuseractivationmethod_Internalname ;
      private String AV64RepositoryUserActivationMethod ;
      private String cmbavRepositoryuseractivationmethod_Jsonclick ;
      private String divUnnamedtablerepositoryautomaticactivationtimeout_Internalname ;
      private String lblTextblockrepositoryautomaticactivationtimeout_Internalname ;
      private String lblTextblockrepositoryautomaticactivationtimeout_Jsonclick ;
      private String edtavRepositoryautomaticactivationtimeout_Internalname ;
      private String edtavRepositoryautomaticactivationtimeout_Jsonclick ;
      private String divUnnamedtablerepositoryuseremailsunique_Internalname ;
      private String lblTextblockrepositoryuseremailsunique_Internalname ;
      private String lblTextblockrepositoryuseremailsunique_Jsonclick ;
      private String chkavRepositoryuseremailsunique_Internalname ;
      private String divUnnamedtablerepositoryrequiredemail_Internalname ;
      private String lblTextblockrepositoryrequiredemail_Internalname ;
      private String lblTextblockrepositoryrequiredemail_Jsonclick ;
      private String chkavRepositoryrequiredemail_Internalname ;
      private String divUnnamedtablerepositoryrequiredpassword_Internalname ;
      private String lblTextblockrepositoryrequiredpassword_Internalname ;
      private String lblTextblockrepositoryrequiredpassword_Jsonclick ;
      private String chkavRepositoryrequiredpassword_Internalname ;
      private String divUnnamedtablerepositoryrequiredfirstname_Internalname ;
      private String lblTextblockrepositoryrequiredfirstname_Internalname ;
      private String lblTextblockrepositoryrequiredfirstname_Jsonclick ;
      private String chkavRepositoryrequiredfirstname_Internalname ;
      private String divUnnamedtablerepositoryrequiredlastname_Internalname ;
      private String lblTextblockrepositoryrequiredlastname_Internalname ;
      private String lblTextblockrepositoryrequiredlastname_Jsonclick ;
      private String chkavRepositoryrequiredlastname_Internalname ;
      private String lblSession_title_Internalname ;
      private String lblSession_title_Jsonclick ;
      private String divUnnamedtable1_Internalname ;
      private String divUnnamedtablerepositorygeneratesessionstatistics_Internalname ;
      private String lblTextblockrepositorygeneratesessionstatistics_Internalname ;
      private String lblTextblockrepositorygeneratesessionstatistics_Jsonclick ;
      private String cmbavRepositorygeneratesessionstatistics_Internalname ;
      private String AV59RepositoryGenerateSessionStatistics ;
      private String cmbavRepositorygeneratesessionstatistics_Jsonclick ;
      private String divUnnamedtablerepositoryusersessioncachetimeout_Internalname ;
      private String lblTextblockrepositoryusersessioncachetimeout_Internalname ;
      private String lblTextblockrepositoryusersessioncachetimeout_Jsonclick ;
      private String edtavRepositoryusersessioncachetimeout_Internalname ;
      private String edtavRepositoryusersessioncachetimeout_Jsonclick ;
      private String divUnnamedtablerepositorygiveanonymoussession_Internalname ;
      private String lblTextblockrepositorygiveanonymoussession_Internalname ;
      private String lblTextblockrepositorygiveanonymoussession_Jsonclick ;
      private String chkavRepositorygiveanonymoussession_Internalname ;
      private String divUnnamedtablerepositoryloginattemptstolocksession_Internalname ;
      private String lblTextblockrepositoryloginattemptstolocksession_Internalname ;
      private String lblTextblockrepositoryloginattemptstolocksession_Jsonclick ;
      private String edtavRepositoryloginattemptstolocksession_Internalname ;
      private String edtavRepositoryloginattemptstolocksession_Jsonclick ;
      private String divUnnamedtablerepositorygamunblockusertimeout_Internalname ;
      private String lblTextblockrepositorygamunblockusertimeout_Internalname ;
      private String lblTextblockrepositorygamunblockusertimeout_Jsonclick ;
      private String edtavRepositorygamunblockusertimeout_Internalname ;
      private String edtavRepositorygamunblockusertimeout_Jsonclick ;
      private String divUnnamedtablerepositoryloginattemptstolockuser_Internalname ;
      private String lblTextblockrepositoryloginattemptstolockuser_Internalname ;
      private String lblTextblockrepositoryloginattemptstolockuser_Jsonclick ;
      private String edtavRepositoryloginattemptstolockuser_Internalname ;
      private String edtavRepositoryloginattemptstolockuser_Jsonclick ;
      private String divUnnamedtablerepositoryminimumamountcharactersinlogin_Internalname ;
      private String lblTextblockrepositoryminimumamountcharactersinlogin_Internalname ;
      private String lblTextblockrepositoryminimumamountcharactersinlogin_Jsonclick ;
      private String edtavRepositoryminimumamountcharactersinlogin_Internalname ;
      private String edtavRepositoryminimumamountcharactersinlogin_Jsonclick ;
      private String divUnnamedtablerepositoryuserrecoverypasswordkeytimeout_Internalname ;
      private String lblTextblockrepositoryuserrecoverypasswordkeytimeout_Internalname ;
      private String lblTextblockrepositoryuserrecoverypasswordkeytimeout_Jsonclick ;
      private String edtavRepositoryuserrecoverypasswordkeytimeout_Internalname ;
      private String edtavRepositoryuserrecoverypasswordkeytimeout_Jsonclick ;
      private String divUnnamedtablerepositoryuserremembermetimeout_Internalname ;
      private String lblTextblockrepositoryuserremembermetimeout_Internalname ;
      private String lblTextblockrepositoryuserremembermetimeout_Jsonclick ;
      private String edtavRepositoryuserremembermetimeout_Internalname ;
      private String edtavRepositoryuserremembermetimeout_Jsonclick ;
      private String divUnnamedtablerepositoryuserremembermetype_Internalname ;
      private String lblTextblockrepositoryuserremembermetype_Internalname ;
      private String lblTextblockrepositoryuserremembermetype_Jsonclick ;
      private String cmbavRepositoryuserremembermetype_Internalname ;
      private String AV60RepositoryUserRememberMeType ;
      private String cmbavRepositoryuserremembermetype_Jsonclick ;
      private String divUnnamedtablerepositorycachetimeout_Internalname ;
      private String lblTextblockrepositorycachetimeout_Internalname ;
      private String lblTextblockrepositorycachetimeout_Jsonclick ;
      private String edtavRepositorycachetimeout_Internalname ;
      private String edtavRepositorycachetimeout_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV24Language ;
      private String Gxuitabspanel_tabs_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Gxuitabspanel_tabs_Historymanagement ;
      private bool wbLoad ;
      private bool AV75RepositorySessionExpiresOnIPChange ;
      private bool AV76RepositoryAllowOauthAccess ;
      private bool AV66RepositoryUserEmailsUnique ;
      private bool AV67RepositoryRequiredEmail ;
      private bool AV68RepositoryRequiredPassword ;
      private bool AV52RepositoryRequiredFirstName ;
      private bool AV53RepositoryRequiredLastName ;
      private bool AV57RepositoryGiveAnonymousSession ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV23isLoginRepositoryAdm ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavRepositorydefaultauthenticationtypename ;
      private GXCheckbox chkavRepositorysessionexpiresonipchange ;
      private GXCheckbox chkavRepositoryallowoauthaccess ;
      private GXCombobox cmbavRepositorydefaultsecuritypolicyid ;
      private GXCombobox cmbavRepositorylogoutbehavior ;
      private GXCombobox cmbavRepositorydefaultroleid ;
      private GXCombobox cmbavRepositoryenabletracing ;
      private GXCombobox cmbavRepositoryuseridentification ;
      private GXCombobox cmbavRepositoryuseractivationmethod ;
      private GXCheckbox chkavRepositoryuseremailsunique ;
      private GXCheckbox chkavRepositoryrequiredemail ;
      private GXCheckbox chkavRepositoryrequiredpassword ;
      private GXCheckbox chkavRepositoryrequiredfirstname ;
      private GXCheckbox chkavRepositoryrequiredlastname ;
      private GXCombobox cmbavRepositorygeneratesessionstatistics ;
      private GXCheckbox chkavRepositorygiveanonymoussession ;
      private GXCombobox cmbavRepositoryuserremembermetype ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXExternalCollection<SdtGAMAuthenticationTypeSimple> AV7AuthenticationTypes ;
      private GXExternalCollection<SdtGAMError> AV15Errors ;
      private GXExternalCollection<SdtGAMSecurityPolicy> AV41SecurityPolicies ;
      private GXExternalCollection<SdtGAMRole> AV39Roles ;
      private GXWebForm Form ;
      private SdtGAMAuthenticationTypeSimple AV6AuthenticationType ;
      private SdtGAMError AV14Error ;
      private SdtGAMRoleFilter AV16FilterRole ;
      private SdtGAMSecurityPolicyFilter AV17FilterSecPol ;
      private SdtGAMRepository AV32Repository ;
      private SdtGAMSecurityPolicy AV42SecurityPolicy ;
      private SdtGAMRole AV38Role ;
   }

   public class gamrepositoryconfiguration__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gamrepositoryconfiguration__default : DataStoreHelperBase, IDataStoreHelper
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
