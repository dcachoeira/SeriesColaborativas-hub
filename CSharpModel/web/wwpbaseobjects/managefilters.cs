/*
               File: WWPBaseObjects.ManageFilters
        Description: Gerenciador de filtros
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:39:35.24
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class managefilters : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public managefilters( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public managefilters( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_UserKey )
      {
         this.AV17UserKey = aP0_UserKey;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavCollectionisempty = new GXCheckbox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridgridstatecollections") == 0 )
            {
               nRC_GXsfl_13 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_13_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_13_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGridgridstatecollections_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Gridgridstatecollections") == 0 )
            {
               subGridgridstatecollections_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV17UserKey = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGridgridstatecollections_refresh( subGridgridstatecollections_Rows, AV17UserKey) ;
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
               AV17UserKey = gxfirstwebparm;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17UserKey", AV17UserKey);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERKEY", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV17UserKey, "")), context));
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
         PA0A2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0A2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, false);
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
         context.AddJavascriptSource("gxcfg.js", "?201892019393531", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("Shared/jquery/jquery1.9.1.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/bootstrap.js", "", false);
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
         context.WriteHtmlText( " "+"class=\"FormNoBackgroundColor\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"FormNoBackgroundColor\" data-gx-class=\"FormNoBackgroundColor\" novalidate action=\""+formatLink("wwpbaseobjects.managefilters.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17UserKey))+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "FormNoBackgroundColor", true);
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
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Gridstatecollection", AV7GridStateCollection);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Gridstatecollection", AV7GridStateCollection);
         }
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_13", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_13), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vGRIDSTATECOLLECTION", AV7GridStateCollection);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vGRIDSTATECOLLECTION", AV7GridStateCollection);
         }
         GxWebStd.gx_hidden_field( context, "vUSERKEY", AV17UserKey);
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERKEY", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV17UserKey, "")), context));
         GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDGRIDSTATECOLLECTIONS_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgridstatecollections_Rows), 6, 0, ".", "")));
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
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "FormNoBackgroundColor" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE0A2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0A2( ) ;
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
         return formatLink("wwpbaseobjects.managefilters.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17UserKey)) ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.ManageFilters" ;
      }

      public override String GetPgmdesc( )
      {
         return "Gerenciador de filtros" ;
      }

      protected void WB0A0( )
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
            GxWebStd.gx_div_start( context, divLayout_tablemain_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 PopupContentCell", "Center", "top", "", "", "div");
            wb_table1_10_0A2( true) ;
         }
         else
         {
            wb_table1_10_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table1_10_0A2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupRight", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(13), 2, 0)+","+"null"+");", "Salvar", bttBtnenter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\ManageFilters.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(13), 2, 0)+","+"null"+");", "Fechar", bttBtncancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\ManageFilters.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_usertable_utpaneldummy_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            wb_table2_29_0A2( true) ;
         }
         else
         {
            wb_table2_29_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table2_29_0A2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_13_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCollectionisempty_Internalname, StringUtil.BoolToStr( AV18CollectionIsEmpty), "", "", chkavCollectionisempty.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(34, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,34);\"");
         }
         wbLoad = true;
      }

      protected void START0A2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Gerenciador de filtros", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0A0( ) ;
      }

      protected void WS0A2( )
      {
         START0A2( ) ;
         EVT0A2( ) ;
      }

      protected void EVT0A2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: Enter */
                                    E110A2 ();
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
                           else if ( StringUtil.StrCmp(sEvt, "GRIDGRIDSTATECOLLECTIONSPAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRIDGRIDSTATECOLLECTIONSPAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgridgridstatecollections_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgridgridstatecollections_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgridgridstatecollections_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgridgridstatecollections_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 29), "GRIDGRIDSTATECOLLECTIONS.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VMOVEUP.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "VMOVEDOWN.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "VUDELETE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VMOVEUP.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "VMOVEDOWN.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "VUDELETE.CLICK") == 0 ) )
                           {
                              nGXsfl_13_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
                              SubsflControlProps_132( ) ;
                              AV29GXV1 = (short)(nGXsfl_13_idx+GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage);
                              if ( ( AV7GridStateCollection.Count >= AV29GXV1 ) && ( AV29GXV1 > 0 ) )
                              {
                                 AV7GridStateCollection.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV29GXV1));
                                 AV16MoveUp = cgiGet( edtavMoveup_Internalname);
                                 context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMoveup_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16MoveUp)) ? AV32Moveup_GXI : context.convertURL( context.PathToRelativeUrl( AV16MoveUp))), !bGXsfl_13_Refreshing);
                                 context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMoveup_Internalname, "SrcSet", context.GetImageSrcSet( AV16MoveUp), true);
                                 AV15MoveDown = cgiGet( edtavMovedown_Internalname);
                                 context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMovedown_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV15MoveDown)) ? AV33Movedown_GXI : context.convertURL( context.PathToRelativeUrl( AV15MoveDown))), !bGXsfl_13_Refreshing);
                                 context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMovedown_Internalname, "SrcSet", context.GetImageSrcSet( AV15MoveDown), true);
                                 AV6UDelete = cgiGet( edtavUdelete_Internalname);
                                 context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUdelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV6UDelete)) ? AV34Udelete_GXI : context.convertURL( context.PathToRelativeUrl( AV6UDelete))), !bGXsfl_13_Refreshing);
                                 context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUdelete_Internalname, "SrcSet", context.GetImageSrcSet( AV6UDelete), true);
                              }
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E120A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDGRIDSTATECOLLECTIONS.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E130A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VMOVEUP.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E140A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VMOVEDOWN.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E150A2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VUDELETE.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E160A2 ();
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

      protected void WE0A2( )
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

      protected void PA0A2( )
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
            chkavCollectionisempty.Name = "vCOLLECTIONISEMPTY";
            chkavCollectionisempty.WebTags = "";
            chkavCollectionisempty.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCollectionisempty_Internalname, "TitleCaption", chkavCollectionisempty.Caption, true);
            chkavCollectionisempty.CheckedValue = "false";
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = chkavCollectionisempty_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridgridstatecollections_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_132( ) ;
         while ( nGXsfl_13_idx <= nRC_GXsfl_13 )
         {
            sendrow_132( ) ;
            nGXsfl_13_idx = (short)(((subGridgridstatecollections_Islastpage==1)&&(nGXsfl_13_idx+1>subGridgridstatecollections_Recordsperpage( )) ? 1 : nGXsfl_13_idx+1));
            sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
            SubsflControlProps_132( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridgridstatecollectionsContainer));
         /* End function gxnrGridgridstatecollections_newrow */
      }

      protected void gxgrGridgridstatecollections_refresh( int subGridgridstatecollections_Rows ,
                                                           String AV17UserKey )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgridstatecollections_Rows), 6, 0, ".", "")));
         GRIDGRIDSTATECOLLECTIONS_nCurrentRecord = 0;
         RF0A2( ) ;
         /* End function gxgrGridgridstatecollections_refresh */
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
         RF0A2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavGridstatecollection__gridstatexml_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGridstatecollection__gridstatexml_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGridstatecollection__gridstatexml_Enabled), 5, 0)), !bGXsfl_13_Refreshing);
      }

      protected void RF0A2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridgridstatecollectionsContainer.ClearRows();
         }
         wbStart = 13;
         nGXsfl_13_idx = 1;
         sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
         SubsflControlProps_132( ) ;
         bGXsfl_13_Refreshing = true;
         GridgridstatecollectionsContainer.AddObjectProperty("GridName", "Gridgridstatecollections");
         GridgridstatecollectionsContainer.AddObjectProperty("CmpContext", "");
         GridgridstatecollectionsContainer.AddObjectProperty("InMasterPage", "false");
         GridgridstatecollectionsContainer.AddObjectProperty("Class", "GridWithBorderColor WorkWith");
         GridgridstatecollectionsContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridgridstatecollectionsContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridgridstatecollectionsContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgridstatecollections_Backcolorstyle), 1, 0, ".", "")));
         GridgridstatecollectionsContainer.PageSize = subGridgridstatecollections_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_132( ) ;
            E130A2 ();
            if ( ( GRIDGRIDSTATECOLLECTIONS_nCurrentRecord > 0 ) && ( GRIDGRIDSTATECOLLECTIONS_nGridOutOfScope == 0 ) && ( nGXsfl_13_idx == 1 ) )
            {
               GRIDGRIDSTATECOLLECTIONS_nCurrentRecord = 0;
               GRIDGRIDSTATECOLLECTIONS_nGridOutOfScope = 1;
               subgridgridstatecollections_firstpage( ) ;
               E130A2 ();
            }
            wbEnd = 13;
            WB0A0( ) ;
         }
         bGXsfl_13_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0A2( )
      {
         GxWebStd.gx_hidden_field( context, "vUSERKEY", AV17UserKey);
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERKEY", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV17UserKey, "")), context));
      }

      protected int subGridgridstatecollections_Pagecount( )
      {
         GRIDGRIDSTATECOLLECTIONS_nRecordCount = subGridgridstatecollections_Recordcount( );
         if ( ((int)((GRIDGRIDSTATECOLLECTIONS_nRecordCount) % (subGridgridstatecollections_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRIDGRIDSTATECOLLECTIONS_nRecordCount/ (decimal)(subGridgridstatecollections_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRIDGRIDSTATECOLLECTIONS_nRecordCount/ (decimal)(subGridgridstatecollections_Recordsperpage( ))))+1) ;
      }

      protected int subGridgridstatecollections_Recordcount( )
      {
         return AV7GridStateCollection.Count ;
      }

      protected int subGridgridstatecollections_Recordsperpage( )
      {
         if ( subGridgridstatecollections_Rows > 0 )
         {
            return subGridgridstatecollections_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGridgridstatecollections_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage/ (decimal)(subGridgridstatecollections_Recordsperpage( ))))+1) ;
      }

      protected short subgridgridstatecollections_firstpage( )
      {
         GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage = 0;
         if ( isFullAjaxMode( ) )
         {
            gxgrGridgridstatecollections_refresh( subGridgridstatecollections_Rows, AV17UserKey) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgridgridstatecollections_nextpage( )
      {
         GRIDGRIDSTATECOLLECTIONS_nRecordCount = subGridgridstatecollections_Recordcount( );
         if ( ( GRIDGRIDSTATECOLLECTIONS_nRecordCount >= subGridgridstatecollections_Recordsperpage( ) ) && ( GRIDGRIDSTATECOLLECTIONS_nEOF == 0 ) )
         {
            GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage = (long)(GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage+subGridgridstatecollections_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGridgridstatecollections_refresh( subGridgridstatecollections_Rows, AV17UserKey) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage), 15, 0, ".", "")));
         GridgridstatecollectionsContainer.AddObjectProperty("GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage", GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage);
         return (short)(((GRIDGRIDSTATECOLLECTIONS_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgridgridstatecollections_previouspage( )
      {
         if ( GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage >= subGridgridstatecollections_Recordsperpage( ) )
         {
            GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage = (long)(GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage-subGridgridstatecollections_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGridgridstatecollections_refresh( subGridgridstatecollections_Rows, AV17UserKey) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgridgridstatecollections_lastpage( )
      {
         GRIDGRIDSTATECOLLECTIONS_nRecordCount = subGridgridstatecollections_Recordcount( );
         if ( GRIDGRIDSTATECOLLECTIONS_nRecordCount > subGridgridstatecollections_Recordsperpage( ) )
         {
            if ( ((int)((GRIDGRIDSTATECOLLECTIONS_nRecordCount) % (subGridgridstatecollections_Recordsperpage( )))) == 0 )
            {
               GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage = (long)(GRIDGRIDSTATECOLLECTIONS_nRecordCount-subGridgridstatecollections_Recordsperpage( ));
            }
            else
            {
               GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage = (long)(GRIDGRIDSTATECOLLECTIONS_nRecordCount-((int)((GRIDGRIDSTATECOLLECTIONS_nRecordCount) % (subGridgridstatecollections_Recordsperpage( )))));
            }
         }
         else
         {
            GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage = 0;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGridgridstatecollections_refresh( subGridgridstatecollections_Rows, AV17UserKey) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected int subgridgridstatecollections_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage = (long)(subGridgridstatecollections_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage = 0;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGridgridstatecollections_refresh( subGridgridstatecollections_Rows, AV17UserKey) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP0A0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavGridstatecollection__gridstatexml_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGridstatecollection__gridstatexml_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGridstatecollection__gridstatexml_Enabled), 5, 0)), !bGXsfl_13_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E120A2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Gridstatecollection"), AV7GridStateCollection);
            ajax_req_read_hidden_sdt(cgiGet( "vGRIDSTATECOLLECTION"), AV7GridStateCollection);
            /* Read variables values. */
            AV18CollectionIsEmpty = StringUtil.StrToBool( cgiGet( chkavCollectionisempty_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18CollectionIsEmpty", AV18CollectionIsEmpty);
            /* Read saved values. */
            nRC_GXsfl_13 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_13"), ",", "."));
            GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage"), ",", "."));
            GRIDGRIDSTATECOLLECTIONS_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRIDGRIDSTATECOLLECTIONS_nEOF"), ",", "."));
            subGridgridstatecollections_Rows = (int)(context.localUtil.CToN( cgiGet( "GRIDGRIDSTATECOLLECTIONS_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgridstatecollections_Rows), 6, 0, ".", "")));
            nRC_GXsfl_13 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_13"), ",", "."));
            nGXsfl_13_fel_idx = 0;
            while ( nGXsfl_13_fel_idx < nRC_GXsfl_13 )
            {
               nGXsfl_13_fel_idx = (short)(((subGridgridstatecollections_Islastpage==1)&&(nGXsfl_13_fel_idx+1>subGridgridstatecollections_Recordsperpage( )) ? 1 : nGXsfl_13_fel_idx+1));
               sGXsfl_13_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_fel_idx), 4, 0)), 4, "0");
               SubsflControlProps_fel_132( ) ;
               AV29GXV1 = (short)(nGXsfl_13_fel_idx+GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage);
               if ( ( AV7GridStateCollection.Count >= AV29GXV1 ) && ( AV29GXV1 > 0 ) )
               {
                  AV7GridStateCollection.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV29GXV1));
                  AV16MoveUp = cgiGet( edtavMoveup_Internalname);
                  AV15MoveDown = cgiGet( edtavMovedown_Internalname);
                  AV6UDelete = cgiGet( edtavUdelete_Internalname);
               }
            }
            if ( nGXsfl_13_fel_idx == 0 )
            {
               nGXsfl_13_idx = 1;
               sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
               SubsflControlProps_132( ) ;
            }
            nGXsfl_13_fel_idx = 1;
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
         E120A2 ();
         if (returnInSub) return;
      }

      protected void E120A2( )
      {
         /* Start Routine */
         chkavCollectionisempty.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCollectionisempty_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavCollectionisempty.Visible), 5, 0)), true);
         subGridgridstatecollections_Rows = 0;
         GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgridstatecollections_Rows), 6, 0, ".", "")));
         if ( StringUtil.StrCmp(AV9HTTPRequest.Method, "GET") == 0 )
         {
            AV7GridStateCollection.FromXml(new GeneXus.Programs.wwpbaseobjects.loadmanagefiltersstate(context).executeUdp(  AV17UserKey), null, "Items", "");
            gx_BV13 = true;
         }
      }

      private void E130A2( )
      {
         /* Gridgridstatecollections_Load Routine */
         AV29GXV1 = 1;
         while ( AV29GXV1 <= AV7GridStateCollection.Count )
         {
            AV7GridStateCollection.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV29GXV1));
            AV16MoveUp = context.GetImagePath( "18fea524-2fca-4d65-a716-0747be033f02", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavMoveup_Internalname, AV16MoveUp);
            AV32Moveup_GXI = GXDbFile.PathToUrl( context.GetImagePath( "18fea524-2fca-4d65-a716-0747be033f02", "", context.GetTheme( )));
            edtavMoveup_Tooltiptext = "";
            AV15MoveDown = context.GetImagePath( "2aa88aca-af12-4417-abf9-461bf944ba5d", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavMovedown_Internalname, AV15MoveDown);
            AV33Movedown_GXI = GXDbFile.PathToUrl( context.GetImagePath( "2aa88aca-af12-4417-abf9-461bf944ba5d", "", context.GetTheme( )));
            edtavMovedown_Tooltiptext = "";
            AV6UDelete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUdelete_Internalname, AV6UDelete);
            AV34Udelete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
            edtavUdelete_Tooltiptext = "";
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 13;
            }
            if ( ( subGridgridstatecollections_Islastpage == 1 ) || ( subGridgridstatecollections_Rows == 0 ) || ( ( GRIDGRIDSTATECOLLECTIONS_nCurrentRecord >= GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage ) && ( GRIDGRIDSTATECOLLECTIONS_nCurrentRecord < GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage + subGridgridstatecollections_Recordsperpage( ) ) ) )
            {
               sendrow_132( ) ;
               GRIDGRIDSTATECOLLECTIONS_nEOF = 0;
               GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDGRIDSTATECOLLECTIONS_nEOF), 1, 0, ".", "")));
               if ( GRIDGRIDSTATECOLLECTIONS_nCurrentRecord + 1 >= subGridgridstatecollections_Recordcount( ) )
               {
                  GRIDGRIDSTATECOLLECTIONS_nEOF = 1;
                  GxWebStd.gx_hidden_field( context, "GRIDGRIDSTATECOLLECTIONS_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRIDGRIDSTATECOLLECTIONS_nEOF), 1, 0, ".", "")));
               }
            }
            GRIDGRIDSTATECOLLECTIONS_nCurrentRecord = (long)(GRIDGRIDSTATECOLLECTIONS_nCurrentRecord+1);
            if ( isFullAjaxMode( ) && ! bGXsfl_13_Refreshing )
            {
               context.DoAjaxLoad(13, GridgridstatecollectionsRow);
            }
            AV29GXV1 = (short)(AV29GXV1+1);
         }
         /*  Sending Event outputs  */
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E110A2 ();
         if (returnInSub) return;
      }

      protected void E110A2( )
      {
         AV29GXV1 = (short)(nGXsfl_13_idx+GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage);
         if ( AV7GridStateCollection.Count >= AV29GXV1 )
         {
            AV7GridStateCollection.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV29GXV1));
         }
         /* Enter Routine */
         AV12IsOK = true;
         AV35GXV4 = 1;
         while ( AV35GXV4 <= AV7GridStateCollection.Count )
         {
            AV8GridStateCollectionItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV35GXV4));
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV8GridStateCollectionItem.gxTpr_Title)) )
            {
               GX_msglist.addItem("Empty");
               AV12IsOK = false;
               if (true) break;
            }
            AV35GXV4 = (int)(AV35GXV4+1);
         }
         if ( AV12IsOK )
         {
            if ( AV18CollectionIsEmpty )
            {
               AV7GridStateCollection = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item>( context, "Item", "");
               gx_BV13 = true;
            }
            new GeneXus.Programs.wwpbaseobjects.savemanagefiltersstate(context ).execute(  AV17UserKey,  AV7GridStateCollection.ToXml(false, true, "Items", "")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17UserKey", AV17UserKey);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERKEY", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV17UserKey, "")), context));
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV7GridStateCollection", AV7GridStateCollection);
         nGXsfl_13_bak_idx = nGXsfl_13_idx;
         gxgrGridgridstatecollections_refresh( subGridgridstatecollections_Rows, AV17UserKey) ;
         nGXsfl_13_idx = nGXsfl_13_bak_idx;
         sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
         SubsflControlProps_132( ) ;
      }

      protected void E140A2( )
      {
         AV29GXV1 = (short)(nGXsfl_13_idx+GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage);
         if ( AV7GridStateCollection.Count >= AV29GXV1 )
         {
            AV7GridStateCollection.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV29GXV1));
         }
         /* Moveup_Click Routine */
         AV10i = (short)(AV7GridStateCollection.IndexOf(((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)(AV7GridStateCollection.CurrentItem))));
         if ( AV10i > 1 )
         {
            AV8GridStateCollectionItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV10i));
            AV7GridStateCollection.RemoveItem(AV10i);
            gx_BV13 = true;
            AV7GridStateCollection.Add(AV8GridStateCollectionItem, AV10i-1);
            gx_BV13 = true;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV7GridStateCollection", AV7GridStateCollection);
         nGXsfl_13_bak_idx = nGXsfl_13_idx;
         gxgrGridgridstatecollections_refresh( subGridgridstatecollections_Rows, AV17UserKey) ;
         nGXsfl_13_idx = nGXsfl_13_bak_idx;
         sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
         SubsflControlProps_132( ) ;
      }

      protected void E150A2( )
      {
         AV29GXV1 = (short)(nGXsfl_13_idx+GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage);
         if ( AV7GridStateCollection.Count >= AV29GXV1 )
         {
            AV7GridStateCollection.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV29GXV1));
         }
         /* Movedown_Click Routine */
         AV10i = (short)(AV7GridStateCollection.IndexOf(((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)(AV7GridStateCollection.CurrentItem))));
         if ( AV10i < AV7GridStateCollection.Count )
         {
            AV8GridStateCollectionItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV10i));
            AV7GridStateCollection.RemoveItem(AV10i);
            gx_BV13 = true;
            AV7GridStateCollection.Add(AV8GridStateCollectionItem, AV10i+1);
            gx_BV13 = true;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV7GridStateCollection", AV7GridStateCollection);
         nGXsfl_13_bak_idx = nGXsfl_13_idx;
         gxgrGridgridstatecollections_refresh( subGridgridstatecollections_Rows, AV17UserKey) ;
         nGXsfl_13_idx = nGXsfl_13_bak_idx;
         sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
         SubsflControlProps_132( ) ;
      }

      protected void E160A2( )
      {
         AV29GXV1 = (short)(nGXsfl_13_idx+GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage);
         if ( AV7GridStateCollection.Count >= AV29GXV1 )
         {
            AV7GridStateCollection.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV29GXV1));
         }
         /* Udelete_Click Routine */
         AV10i = (short)(AV7GridStateCollection.IndexOf(((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)(AV7GridStateCollection.CurrentItem))));
         AV7GridStateCollection.RemoveItem(AV10i);
         gx_BV13 = true;
         if ( AV7GridStateCollection.Count == 0 )
         {
            AV18CollectionIsEmpty = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18CollectionIsEmpty", AV18CollectionIsEmpty);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV7GridStateCollection", AV7GridStateCollection);
         nGXsfl_13_bak_idx = nGXsfl_13_idx;
         gxgrGridgridstatecollections_refresh( subGridgridstatecollections_Rows, AV17UserKey) ;
         nGXsfl_13_idx = nGXsfl_13_bak_idx;
         sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
         SubsflControlProps_132( ) ;
      }

      protected void wb_table2_29_0A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUtpaneldummy_Internalname, tblUtpaneldummy_Internalname, "", "Invisible", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"DVELOP_BOOTSTRAP_PANEL1Container"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_BOOTSTRAP_PANEL1Container"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_29_0A2e( true) ;
         }
         else
         {
            wb_table2_29_0A2e( false) ;
         }
      }

      protected void wb_table1_10_0A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablecontent_Internalname, tblTablecontent_Internalname, "", "TableContent", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /*  Grid Control  */
            GridgridstatecollectionsContainer.SetWrapped(nGXWrapped);
            if ( GridgridstatecollectionsContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridgridstatecollectionsContainer"+"DivS\" data-gxgridid=\"13\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGridgridstatecollections_Internalname, subGridgridstatecollections_Internalname, "", "GridWithBorderColor WorkWith", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGridgridstatecollections_Backcolorstyle == 0 )
               {
                  subGridgridstatecollections_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGridgridstatecollections_Class) > 0 )
                  {
                     subGridgridstatecollections_Linesclass = subGridgridstatecollections_Class+"Title";
                  }
               }
               else
               {
                  subGridgridstatecollections_Titlebackstyle = 1;
                  if ( subGridgridstatecollections_Backcolorstyle == 1 )
                  {
                     subGridgridstatecollections_Titlebackcolor = subGridgridstatecollections_Allbackcolor;
                     if ( StringUtil.Len( subGridgridstatecollections_Class) > 0 )
                     {
                        subGridgridstatecollections_Linesclass = subGridgridstatecollections_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGridgridstatecollections_Class) > 0 )
                     {
                        subGridgridstatecollections_Linesclass = subGridgridstatecollections_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeManageFilters"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Filtros") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Grid State XML") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridgridstatecollectionsContainer.AddObjectProperty("GridName", "Gridgridstatecollections");
            }
            else
            {
               GridgridstatecollectionsContainer.AddObjectProperty("GridName", "Gridgridstatecollections");
               GridgridstatecollectionsContainer.AddObjectProperty("Class", "GridWithBorderColor WorkWith");
               GridgridstatecollectionsContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridgridstatecollectionsContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridgridstatecollectionsContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgridstatecollections_Backcolorstyle), 1, 0, ".", "")));
               GridgridstatecollectionsContainer.AddObjectProperty("CmpContext", "");
               GridgridstatecollectionsContainer.AddObjectProperty("InMasterPage", "false");
               GridgridstatecollectionsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridgridstatecollectionsColumn.AddObjectProperty("Value", context.convertURL( AV16MoveUp));
               GridgridstatecollectionsColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavMoveup_Tooltiptext));
               GridgridstatecollectionsContainer.AddColumnProperties(GridgridstatecollectionsColumn);
               GridgridstatecollectionsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridgridstatecollectionsColumn.AddObjectProperty("Value", context.convertURL( AV15MoveDown));
               GridgridstatecollectionsColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavMovedown_Tooltiptext));
               GridgridstatecollectionsContainer.AddColumnProperties(GridgridstatecollectionsColumn);
               GridgridstatecollectionsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridgridstatecollectionsContainer.AddColumnProperties(GridgridstatecollectionsColumn);
               GridgridstatecollectionsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridgridstatecollectionsColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGridstatecollection__gridstatexml_Enabled), 5, 0, ".", "")));
               GridgridstatecollectionsContainer.AddColumnProperties(GridgridstatecollectionsColumn);
               GridgridstatecollectionsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridgridstatecollectionsColumn.AddObjectProperty("Value", context.convertURL( AV6UDelete));
               GridgridstatecollectionsColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUdelete_Tooltiptext));
               GridgridstatecollectionsContainer.AddColumnProperties(GridgridstatecollectionsColumn);
               GridgridstatecollectionsContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgridstatecollections_Allowselection), 1, 0, ".", "")));
               GridgridstatecollectionsContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgridstatecollections_Selectioncolor), 9, 0, ".", "")));
               GridgridstatecollectionsContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgridstatecollections_Allowhovering), 1, 0, ".", "")));
               GridgridstatecollectionsContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgridstatecollections_Hoveringcolor), 9, 0, ".", "")));
               GridgridstatecollectionsContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgridstatecollections_Allowcollapsing), 1, 0, ".", "")));
               GridgridstatecollectionsContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgridstatecollections_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 13 )
         {
            wbEnd = 0;
            nRC_GXsfl_13 = (short)(nGXsfl_13_idx-1);
            if ( GridgridstatecollectionsContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               GridgridstatecollectionsContainer.AddObjectProperty("GRIDGRIDSTATECOLLECTIONS_nEOF", GRIDGRIDSTATECOLLECTIONS_nEOF);
               GridgridstatecollectionsContainer.AddObjectProperty("GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage", GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage);
               AV29GXV1 = nGXsfl_13_idx;
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridgridstatecollectionsContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridgridstatecollections", GridgridstatecollectionsContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridgridstatecollectionsContainerData", GridgridstatecollectionsContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridgridstatecollectionsContainerData"+"V", GridgridstatecollectionsContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input autocomplete=\"off\" type=\"hidden\" "+"name=\""+"GridgridstatecollectionsContainerData"+"V"+"\" value='"+GridgridstatecollectionsContainer.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_10_0A2e( true) ;
         }
         else
         {
            wb_table1_10_0A2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV17UserKey = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17UserKey", AV17UserKey);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERKEY", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV17UserKey, "")), context));
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
         PA0A2( ) ;
         WS0A2( ) ;
         WE0A2( ) ;
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
         AddStyleSheetFile("DVelop/Bootstrap/Shared/bootstrap.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), false);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019393655", true);
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
         context.AddJavascriptSource("wwpbaseobjects/managefilters.js", "?201892019393656", false);
         context.AddJavascriptSource("Shared/jquery/jquery1.9.1.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/bootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_132( )
      {
         edtavMoveup_Internalname = "vMOVEUP_"+sGXsfl_13_idx;
         edtavMovedown_Internalname = "vMOVEDOWN_"+sGXsfl_13_idx;
         edtavGridstatecollection__title_Internalname = "GRIDSTATECOLLECTION__TITLE_"+sGXsfl_13_idx;
         edtavGridstatecollection__gridstatexml_Internalname = "GRIDSTATECOLLECTION__GRIDSTATEXML_"+sGXsfl_13_idx;
         edtavUdelete_Internalname = "vUDELETE_"+sGXsfl_13_idx;
      }

      protected void SubsflControlProps_fel_132( )
      {
         edtavMoveup_Internalname = "vMOVEUP_"+sGXsfl_13_fel_idx;
         edtavMovedown_Internalname = "vMOVEDOWN_"+sGXsfl_13_fel_idx;
         edtavGridstatecollection__title_Internalname = "GRIDSTATECOLLECTION__TITLE_"+sGXsfl_13_fel_idx;
         edtavGridstatecollection__gridstatexml_Internalname = "GRIDSTATECOLLECTION__GRIDSTATEXML_"+sGXsfl_13_fel_idx;
         edtavUdelete_Internalname = "vUDELETE_"+sGXsfl_13_fel_idx;
      }

      protected void sendrow_132( )
      {
         SubsflControlProps_132( ) ;
         WB0A0( ) ;
         if ( ( subGridgridstatecollections_Rows * 1 == 0 ) || ( nGXsfl_13_idx <= subGridgridstatecollections_Recordsperpage( ) * 1 ) )
         {
            GridgridstatecollectionsRow = GXWebRow.GetNew(context,GridgridstatecollectionsContainer);
            if ( subGridgridstatecollections_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGridgridstatecollections_Backstyle = 0;
               if ( StringUtil.StrCmp(subGridgridstatecollections_Class, "") != 0 )
               {
                  subGridgridstatecollections_Linesclass = subGridgridstatecollections_Class+"Odd";
               }
            }
            else if ( subGridgridstatecollections_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGridgridstatecollections_Backstyle = 0;
               subGridgridstatecollections_Backcolor = subGridgridstatecollections_Allbackcolor;
               if ( StringUtil.StrCmp(subGridgridstatecollections_Class, "") != 0 )
               {
                  subGridgridstatecollections_Linesclass = subGridgridstatecollections_Class+"Uniform";
               }
            }
            else if ( subGridgridstatecollections_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGridgridstatecollections_Backstyle = 1;
               if ( StringUtil.StrCmp(subGridgridstatecollections_Class, "") != 0 )
               {
                  subGridgridstatecollections_Linesclass = subGridgridstatecollections_Class+"Odd";
               }
               subGridgridstatecollections_Backcolor = (int)(0x0);
            }
            else if ( subGridgridstatecollections_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGridgridstatecollections_Backstyle = 1;
               if ( ((int)((nGXsfl_13_idx) % (2))) == 0 )
               {
                  subGridgridstatecollections_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGridgridstatecollections_Class, "") != 0 )
                  {
                     subGridgridstatecollections_Linesclass = subGridgridstatecollections_Class+"Even";
                  }
               }
               else
               {
                  subGridgridstatecollections_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGridgridstatecollections_Class, "") != 0 )
                  {
                     subGridgridstatecollections_Linesclass = subGridgridstatecollections_Class+"Odd";
                  }
               }
            }
            if ( GridgridstatecollectionsContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"GridWithBorderColor WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_13_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridgridstatecollectionsContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavMoveup_Enabled!=0)&&(edtavMoveup_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 14,'',false,'',13)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV16MoveUp_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV16MoveUp))&&String.IsNullOrEmpty(StringUtil.RTrim( AV32Moveup_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV16MoveUp)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV16MoveUp)) ? AV32Moveup_GXI : context.PathToRelativeUrl( AV16MoveUp));
            GridgridstatecollectionsRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavMoveup_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavMoveup_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavMoveup_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVMOVEUP.CLICK."+sGXsfl_13_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV16MoveUp_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridgridstatecollectionsContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavMovedown_Enabled!=0)&&(edtavMovedown_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 15,'',false,'',13)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV15MoveDown_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV15MoveDown))&&String.IsNullOrEmpty(StringUtil.RTrim( AV33Movedown_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV15MoveDown)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV15MoveDown)) ? AV33Movedown_GXI : context.PathToRelativeUrl( AV15MoveDown));
            GridgridstatecollectionsRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavMovedown_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavMovedown_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavMovedown_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVMOVEDOWN.CLICK."+sGXsfl_13_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV15MoveDown_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridgridstatecollectionsContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGridstatecollection__title_Enabled!=0)&&(edtavGridstatecollection__title_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 16,'',false,'"+sGXsfl_13_idx+"',13)\"" : " ");
            ROClassString = "AttributeManageFilters";
            GridgridstatecollectionsRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGridstatecollection__title_Internalname,((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV29GXV1)).gxTpr_Title,(String)"",TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavGridstatecollection__title_Enabled!=0)&&(edtavGridstatecollection__title_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(this,16);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavGridstatecollection__title_Jsonclick,(short)0,(String)"AttributeManageFilters",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)1,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)13,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridgridstatecollectionsContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridgridstatecollectionsRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGridstatecollection__gridstatexml_Internalname,((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV29GXV1)).gxTpr_Gridstatexml,((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV7GridStateCollection.Item(AV29GXV1)).gxTpr_Gridstatexml,(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavGridstatecollection__gridstatexml_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavGridstatecollection__gridstatexml_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(int)2097152,(short)0,(short)0,(short)13,(short)1,(short)0,(short)-1,(bool)true,(String)"",(String)"left",(bool)false});
            /* Subfile cell */
            if ( GridgridstatecollectionsContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavUdelete_Enabled!=0)&&(edtavUdelete_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 18,'',false,'',13)\"" : " ");
            ClassString = "DeleteAttribute";
            StyleString = "";
            AV6UDelete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV6UDelete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV34Udelete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV6UDelete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV6UDelete)) ? AV34Udelete_GXI : context.PathToRelativeUrl( AV6UDelete));
            GridgridstatecollectionsRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUdelete_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUdelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavUdelete_Jsonclick,"'"+""+"'"+",false,"+"'"+"EVUDELETE.CLICK."+sGXsfl_13_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV6UDelete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            send_integrity_lvl_hashes0A2( ) ;
            GridgridstatecollectionsContainer.AddRow(GridgridstatecollectionsRow);
            nGXsfl_13_idx = (short)(((subGridgridstatecollections_Islastpage==1)&&(nGXsfl_13_idx+1>subGridgridstatecollections_Recordsperpage( )) ? 1 : nGXsfl_13_idx+1));
            sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
            SubsflControlProps_132( ) ;
         }
         /* End function sendrow_132 */
      }

      protected void init_default_properties( )
      {
         edtavMoveup_Internalname = "vMOVEUP";
         edtavMovedown_Internalname = "vMOVEDOWN";
         edtavGridstatecollection__title_Internalname = "GRIDSTATECOLLECTION__TITLE";
         edtavGridstatecollection__gridstatexml_Internalname = "GRIDSTATECOLLECTION__GRIDSTATEXML";
         edtavUdelete_Internalname = "vUDELETE";
         tblTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         Dvelop_bootstrap_panel1_Internalname = "DVELOP_BOOTSTRAP_PANEL1";
         tblUtpaneldummy_Internalname = "UTPANELDUMMY";
         divHtml_usertable_utpaneldummy_Internalname = "HTML_USERTABLE_UTPANELDUMMY";
         divTablemain_Internalname = "TABLEMAIN";
         divLayout_tablemain_Internalname = "LAYOUT_TABLEMAIN";
         chkavCollectionisempty_Internalname = "vCOLLECTIONISEMPTY";
         Form.Internalname = "FORM";
         subGridgridstatecollections_Internalname = "GRIDGRIDSTATECOLLECTIONS";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavUdelete_Jsonclick = "";
         edtavUdelete_Visible = -1;
         edtavUdelete_Enabled = 1;
         edtavGridstatecollection__gridstatexml_Jsonclick = "";
         edtavGridstatecollection__title_Jsonclick = "";
         edtavGridstatecollection__title_Visible = -1;
         edtavGridstatecollection__title_Enabled = 1;
         edtavMovedown_Jsonclick = "";
         edtavMovedown_Visible = -1;
         edtavMovedown_Enabled = 1;
         edtavMoveup_Jsonclick = "";
         edtavMoveup_Visible = -1;
         edtavMoveup_Enabled = 1;
         subGridgridstatecollections_Allowcollapsing = 0;
         subGridgridstatecollections_Allowselection = 0;
         edtavUdelete_Tooltiptext = "";
         edtavMovedown_Tooltiptext = "";
         edtavMoveup_Tooltiptext = "";
         edtavGridstatecollection__gridstatexml_Enabled = 0;
         subGridgridstatecollections_Class = "GridWithBorderColor WorkWith";
         subGridgridstatecollections_Backcolorstyle = 0;
         edtavGridstatecollection__gridstatexml_Enabled = -1;
         chkavCollectionisempty.Caption = "";
         chkavCollectionisempty.Visible = 1;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Gerenciador de filtros";
         subGridgridstatecollections_Rows = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0},{av:'GRIDGRIDSTATECOLLECTIONS_nEOF',nv:0},{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null},{av:'subGridgridstatecollections_Rows',nv:0},{av:'AV17UserKey',fld:'vUSERKEY',pic:'',hsh:true,nv:''}],oparms:[]}");
         setEventMetadata("GRIDGRIDSTATECOLLECTIONS.LOAD","{handler:'E130A2',iparms:[],oparms:[{av:'AV16MoveUp',fld:'vMOVEUP',pic:'',nv:''},{av:'edtavMoveup_Tooltiptext',ctrl:'vMOVEUP',prop:'Tooltiptext'},{av:'AV15MoveDown',fld:'vMOVEDOWN',pic:'',nv:''},{av:'edtavMovedown_Tooltiptext',ctrl:'vMOVEDOWN',prop:'Tooltiptext'},{av:'AV6UDelete',fld:'vUDELETE',pic:'',nv:''},{av:'edtavUdelete_Tooltiptext',ctrl:'vUDELETE',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E110A2',iparms:[{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null},{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0},{av:'AV18CollectionIsEmpty',fld:'vCOLLECTIONISEMPTY',pic:'',nv:false},{av:'AV17UserKey',fld:'vUSERKEY',pic:'',hsh:true,nv:''},{av:'GRIDGRIDSTATECOLLECTIONS_nEOF',nv:0},{av:'subGridgridstatecollections_Rows',nv:0}],oparms:[{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null},{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0}]}");
         setEventMetadata("VMOVEUP.CLICK","{handler:'E140A2',iparms:[{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null},{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0},{av:'GRIDGRIDSTATECOLLECTIONS_nEOF',nv:0},{av:'subGridgridstatecollections_Rows',nv:0},{av:'AV17UserKey',fld:'vUSERKEY',pic:'',hsh:true,nv:''}],oparms:[{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null},{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0}]}");
         setEventMetadata("VMOVEDOWN.CLICK","{handler:'E150A2',iparms:[{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null},{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0},{av:'GRIDGRIDSTATECOLLECTIONS_nEOF',nv:0},{av:'subGridgridstatecollections_Rows',nv:0},{av:'AV17UserKey',fld:'vUSERKEY',pic:'',hsh:true,nv:''}],oparms:[{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null},{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0}]}");
         setEventMetadata("VUDELETE.CLICK","{handler:'E160A2',iparms:[{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null},{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0},{av:'GRIDGRIDSTATECOLLECTIONS_nEOF',nv:0},{av:'subGridgridstatecollections_Rows',nv:0},{av:'AV17UserKey',fld:'vUSERKEY',pic:'',hsh:true,nv:''}],oparms:[{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null},{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0},{av:'AV18CollectionIsEmpty',fld:'vCOLLECTIONISEMPTY',pic:'',nv:false}]}");
         setEventMetadata("GRIDGRIDSTATECOLLECTIONS_FIRSTPAGE","{handler:'subgridgridstatecollections_firstpage',iparms:[{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0},{av:'GRIDGRIDSTATECOLLECTIONS_nEOF',nv:0},{av:'subGridgridstatecollections_Rows',nv:0},{av:'AV17UserKey',fld:'vUSERKEY',pic:'',hsh:true,nv:''},{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null}],oparms:[]}");
         setEventMetadata("GRIDGRIDSTATECOLLECTIONS_PREVPAGE","{handler:'subgridgridstatecollections_previouspage',iparms:[{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0},{av:'GRIDGRIDSTATECOLLECTIONS_nEOF',nv:0},{av:'subGridgridstatecollections_Rows',nv:0},{av:'AV17UserKey',fld:'vUSERKEY',pic:'',hsh:true,nv:''},{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null}],oparms:[]}");
         setEventMetadata("GRIDGRIDSTATECOLLECTIONS_NEXTPAGE","{handler:'subgridgridstatecollections_nextpage',iparms:[{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0},{av:'GRIDGRIDSTATECOLLECTIONS_nEOF',nv:0},{av:'subGridgridstatecollections_Rows',nv:0},{av:'AV17UserKey',fld:'vUSERKEY',pic:'',hsh:true,nv:''},{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null}],oparms:[]}");
         setEventMetadata("GRIDGRIDSTATECOLLECTIONS_LASTPAGE","{handler:'subgridgridstatecollections_lastpage',iparms:[{av:'GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage',nv:0},{av:'GRIDGRIDSTATECOLLECTIONS_nEOF',nv:0},{av:'subGridgridstatecollections_Rows',nv:0},{av:'AV17UserKey',fld:'vUSERKEY',pic:'',hsh:true,nv:''},{av:'AV7GridStateCollection',fld:'vGRIDSTATECOLLECTION',grid:13,pic:'',nv:null}],oparms:[]}");
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
         wcpOAV17UserKey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV7GridStateCollection = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item>( context, "Item", "");
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV16MoveUp = "";
         AV32Moveup_GXI = "";
         AV15MoveDown = "";
         AV33Movedown_GXI = "";
         AV6UDelete = "";
         AV34Udelete_GXI = "";
         GridgridstatecollectionsContainer = new GXWebGrid( context);
         AV9HTTPRequest = new GxHttpRequest( context);
         GridgridstatecollectionsRow = new GXWebRow();
         AV8GridStateCollectionItem = new GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item(context);
         sStyleString = "";
         subGridgridstatecollections_Linesclass = "";
         GridgridstatecollectionsColumn = new GXWebColumn();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavGridstatecollection__gridstatexml_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_13 ;
      private short nGXsfl_13_idx=1 ;
      private short GRIDGRIDSTATECOLLECTIONS_nEOF ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short AV29GXV1 ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGridgridstatecollections_Backcolorstyle ;
      private short nGXsfl_13_fel_idx=1 ;
      private short nGXsfl_13_bak_idx=1 ;
      private short AV10i ;
      private short subGridgridstatecollections_Titlebackstyle ;
      private short subGridgridstatecollections_Allowselection ;
      private short subGridgridstatecollections_Allowhovering ;
      private short subGridgridstatecollections_Allowcollapsing ;
      private short subGridgridstatecollections_Collapsed ;
      private short nGXWrapped ;
      private short subGridgridstatecollections_Backstyle ;
      private int subGridgridstatecollections_Rows ;
      private int subGridgridstatecollections_Islastpage ;
      private int edtavGridstatecollection__gridstatexml_Enabled ;
      private int GRIDGRIDSTATECOLLECTIONS_nGridOutOfScope ;
      private int AV35GXV4 ;
      private int subGridgridstatecollections_Titlebackcolor ;
      private int subGridgridstatecollections_Allbackcolor ;
      private int subGridgridstatecollections_Selectioncolor ;
      private int subGridgridstatecollections_Hoveringcolor ;
      private int idxLst ;
      private int subGridgridstatecollections_Backcolor ;
      private int edtavMoveup_Enabled ;
      private int edtavMoveup_Visible ;
      private int edtavMovedown_Enabled ;
      private int edtavMovedown_Visible ;
      private int edtavGridstatecollection__title_Enabled ;
      private int edtavGridstatecollection__title_Visible ;
      private int edtavUdelete_Enabled ;
      private int edtavUdelete_Visible ;
      private long GRIDGRIDSTATECOLLECTIONS_nFirstRecordOnPage ;
      private long GRIDGRIDSTATECOLLECTIONS_nCurrentRecord ;
      private long GRIDGRIDSTATECOLLECTIONS_nRecordCount ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_13_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayout_tablemain_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String TempTags ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_usertable_utpaneldummy_Internalname ;
      private String chkavCollectionisempty_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavMoveup_Internalname ;
      private String edtavMovedown_Internalname ;
      private String edtavUdelete_Internalname ;
      private String edtavGridstatecollection__gridstatexml_Internalname ;
      private String sGXsfl_13_fel_idx="0001" ;
      private String edtavMoveup_Tooltiptext ;
      private String edtavMovedown_Tooltiptext ;
      private String edtavUdelete_Tooltiptext ;
      private String sStyleString ;
      private String tblUtpaneldummy_Internalname ;
      private String tblTablecontent_Internalname ;
      private String subGridgridstatecollections_Internalname ;
      private String subGridgridstatecollections_Class ;
      private String subGridgridstatecollections_Linesclass ;
      private String edtavGridstatecollection__title_Internalname ;
      private String sImgUrl ;
      private String edtavMoveup_Jsonclick ;
      private String edtavMovedown_Jsonclick ;
      private String ROClassString ;
      private String edtavGridstatecollection__title_Jsonclick ;
      private String edtavGridstatecollection__gridstatexml_Jsonclick ;
      private String edtavUdelete_Jsonclick ;
      private String Dvelop_bootstrap_panel1_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool AV18CollectionIsEmpty ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_13_Refreshing=false ;
      private bool returnInSub ;
      private bool gx_BV13 ;
      private bool AV12IsOK ;
      private bool AV16MoveUp_IsBlob ;
      private bool AV15MoveDown_IsBlob ;
      private bool AV6UDelete_IsBlob ;
      private String AV17UserKey ;
      private String wcpOAV17UserKey ;
      private String AV32Moveup_GXI ;
      private String AV33Movedown_GXI ;
      private String AV34Udelete_GXI ;
      private String AV16MoveUp ;
      private String AV15MoveDown ;
      private String AV6UDelete ;
      private GXWebGrid GridgridstatecollectionsContainer ;
      private GXWebRow GridgridstatecollectionsRow ;
      private GXWebColumn GridgridstatecollectionsColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavCollectionisempty ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item> AV7GridStateCollection ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item AV8GridStateCollectionItem ;
   }

}
