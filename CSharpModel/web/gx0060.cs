/*
               File: Gx0060
        Description: Selection List Notificação
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:55.68
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
   public class gx0060 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0060( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gx0060( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_pNotificacaoId )
      {
         this.AV10pNotificacaoId = 0 ;
         executePrivate();
         aP0_pNotificacaoId=this.AV10pNotificacaoId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCnotificacaotipo = new GXCombobox();
         cmbNotificacaoTipo = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_GXsfl_64 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_64_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_64_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid1_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               subGrid1_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV6cNotificacaoId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cUsuarioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cNotificacaoTipo = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV9cNotificacaoDataHoraEnvio = context.localUtil.ParseDTimeParm( GetNextPar( ));
               AV12cNotificacaoLigacaoId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cNotificacaoId, AV7cUsuarioId, AV8cNotificacaoTipo, AV9cNotificacaoDataHoraEnvio, AV12cNotificacaoLigacaoId) ;
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
               AV10pNotificacaoId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pNotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pNotificacaoId), 18, 0)));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdpromptmasterpage", "GeneXus.Programs.rwdpromptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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
         PA202( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START202( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20189251965576", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("calendar-pt.js", "?"+context.GetBuildNumber( 121631), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0060.aspx") + "?" + UrlEncode("" +AV10pNotificacaoId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCNOTIFICACAOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cNotificacaoId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cUsuarioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCNOTIFICACAOTIPO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cNotificacaoTipo), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCNOTIFICACAODATAHORAENVIO", context.localUtil.TToC( AV9cNotificacaoDataHoraEnvio, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vCNOTIFICACAOLIGACAOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cNotificacaoLigacaoId), 18, 0, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_64", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_64), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPNOTIFICACAOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10pNotificacaoId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "NOTIFICACAOIDFILTERCONTAINER_Class", StringUtil.RTrim( divNotificacaoidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIOIDFILTERCONTAINER_Class", StringUtil.RTrim( divUsuarioidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "NOTIFICACAOTIPOFILTERCONTAINER_Class", StringUtil.RTrim( divNotificacaotipofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "NOTIFICACAODATAHORAENVIOFILTERCONTAINER_Class", StringUtil.RTrim( divNotificacaodatahoraenviofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "NOTIFICACAOLIGACAOIDFILTERCONTAINER_Class", StringUtil.RTrim( divNotificacaoligacaoidfiltercontainer_Class));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", "notset");
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
            WE202( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT202( ) ;
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
         return formatLink("gx0060.aspx") + "?" + UrlEncode("" +AV10pNotificacaoId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0060" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Notificação" ;
      }

      protected void WB200( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMain_Internalname, 1, 0, "px", 0, "px", "ContainerFluid PromptContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 PromptAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", divAdvancedcontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divNotificacaoidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divNotificacaoidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblnotificacaoidfilter_Internalname, "Id", "", "", lblLblnotificacaoidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11201_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCnotificacaoid_Internalname, "Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCnotificacaoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cNotificacaoId), 18, 0, ",", "")), ((edtavCnotificacaoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cNotificacaoId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cNotificacaoId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCnotificacaoid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCnotificacaoid_Visible, edtavCnotificacaoid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0060.htm");
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
            GxWebStd.gx_div_start( context, divUsuarioidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuarioidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuarioidfilter_Internalname, "Id", "", "", lblLblusuarioidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12201_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusuarioid_Internalname, "Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusuarioid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cUsuarioId), 18, 0, ",", "")), ((edtavCusuarioid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cUsuarioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7cUsuarioId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuarioid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusuarioid_Visible, edtavCusuarioid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0060.htm");
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
            GxWebStd.gx_div_start( context, divNotificacaotipofiltercontainer_Internalname, 1, 0, "px", 0, "px", divNotificacaotipofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblnotificacaotipofilter_Internalname, "Tipo de notificação", "", "", lblLblnotificacaotipofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13201_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCnotificacaotipo_Internalname, "Tipo de notificação", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_64_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCnotificacaotipo, cmbavCnotificacaotipo_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV8cNotificacaoTipo), 4, 0)), 1, cmbavCnotificacaotipo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavCnotificacaotipo.Visible, cmbavCnotificacaotipo.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "", true, "HLP_Gx0060.htm");
            cmbavCnotificacaotipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV8cNotificacaoTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCnotificacaotipo_Internalname, "Values", (String)(cmbavCnotificacaotipo.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divNotificacaodatahoraenviofiltercontainer_Internalname, 1, 0, "px", 0, "px", divNotificacaodatahoraenviofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblnotificacaodatahoraenviofilter_Internalname, "Data e hora de envio", "", "", lblLblnotificacaodatahoraenviofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14201_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCnotificacaodatahoraenvio_Internalname, "Data e hora de envio", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_64_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCnotificacaodatahoraenvio_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCnotificacaodatahoraenvio_Internalname, context.localUtil.TToC( AV9cNotificacaoDataHoraEnvio, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV9cNotificacaoDataHoraEnvio, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'por',false,0);"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCnotificacaodatahoraenvio_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCnotificacaodatahoraenvio_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0060.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_start( context, divNotificacaoligacaoidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divNotificacaoligacaoidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblnotificacaoligacaoidfilter_Internalname, "Id de ligação", "", "", lblLblnotificacaoligacaoidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15201_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCnotificacaoligacaoid_Internalname, "Id de ligação", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCnotificacaoligacaoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cNotificacaoLigacaoId), 18, 0, ",", "")), ((edtavCnotificacaoligacaoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12cNotificacaoLigacaoId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV12cNotificacaoLigacaoId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCnotificacaoligacaoid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCnotificacaoligacaoid_Visible, edtavCnotificacaoligacaoid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 WWGridCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg ToggleCell", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(64), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e16201_client"+"'", TempTags, "", 2, "HLP_Gx0060.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"64\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "PromptGrid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "de notificação") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "de envio") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "de ligação") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "PromptGrid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23NotificacaoId), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24NotificacaoTipo), 4, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( cmbNotificacaoTipo.Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.TToC( A26NotificacaoDataHoraEnvio, 10, 8, 0, 3, "/", ":", " "));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A61NotificacaoLigacaoId), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 64 )
         {
            wbEnd = 0;
            nRC_GXsfl_64 = (short)(nGXsfl_64_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input autocomplete=\"off\" type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(64), 2, 0)+","+"null"+");", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0060.htm");
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

      protected void START202( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Selection List Notificação", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP200( ) ;
      }

      protected void WS202( )
      {
         START202( ) ;
         EVT202( ) ;
      }

      protected void EVT202( )
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
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID1PAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_64_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
                              SubsflControlProps_642( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV15Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_64_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A23NotificacaoId = (long)(context.localUtil.CToN( cgiGet( edtNotificacaoId_Internalname), ",", "."));
                              A11UsuarioId = (long)(context.localUtil.CToN( cgiGet( edtUsuarioId_Internalname), ",", "."));
                              cmbNotificacaoTipo.Name = cmbNotificacaoTipo_Internalname;
                              cmbNotificacaoTipo.CurrentValue = cgiGet( cmbNotificacaoTipo_Internalname);
                              A24NotificacaoTipo = (short)(NumberUtil.Val( cgiGet( cmbNotificacaoTipo_Internalname), "."));
                              A26NotificacaoDataHoraEnvio = context.localUtil.CToT( cgiGet( edtNotificacaoDataHoraEnvio_Internalname), 0);
                              A61NotificacaoLigacaoId = (long)(context.localUtil.CToN( cgiGet( edtNotificacaoLigacaoId_Internalname), ",", "."));
                              n61NotificacaoLigacaoId = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E17202 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E18202 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cnotificacaoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCNOTIFICACAOID"), ",", ".") != Convert.ToDecimal( AV6cNotificacaoId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuarioid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOID"), ",", ".") != Convert.ToDecimal( AV7cUsuarioId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cnotificacaotipo Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCNOTIFICACAOTIPO"), ",", ".") != Convert.ToDecimal( AV8cNotificacaoTipo )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cnotificacaodatahoraenvio Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCNOTIFICACAODATAHORAENVIO"), 0) != AV9cNotificacaoDataHoraEnvio )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cnotificacaoligacaoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCNOTIFICACAOLIGACAOID"), ",", ".") != Convert.ToDecimal( AV12cNotificacaoLigacaoId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E19202 ();
                                       }
                                       dynload_actions( ) ;
                                    }
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

      protected void WE202( )
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

      protected void PA202( )
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
            cmbavCnotificacaotipo.Name = "vCNOTIFICACAOTIPO";
            cmbavCnotificacaotipo.WebTags = "";
            cmbavCnotificacaotipo.addItem("1", "Conquista", 0);
            if ( cmbavCnotificacaotipo.ItemCount > 0 )
            {
               AV8cNotificacaoTipo = (short)(NumberUtil.Val( cmbavCnotificacaotipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV8cNotificacaoTipo), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cNotificacaoTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cNotificacaoTipo), 4, 0)));
            }
            GXCCtl = "NOTIFICACAOTIPO_" + sGXsfl_64_idx;
            cmbNotificacaoTipo.Name = GXCCtl;
            cmbNotificacaoTipo.WebTags = "";
            cmbNotificacaoTipo.addItem("1", "Conquista", 0);
            if ( cmbNotificacaoTipo.ItemCount > 0 )
            {
               A24NotificacaoTipo = (short)(NumberUtil.Val( cmbNotificacaoTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0))), "."));
            }
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_642( ) ;
         while ( nGXsfl_64_idx <= nRC_GXsfl_64 )
         {
            sendrow_642( ) ;
            nGXsfl_64_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_64_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_64_idx+1));
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
            SubsflControlProps_642( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        long AV6cNotificacaoId ,
                                        long AV7cUsuarioId ,
                                        short AV8cNotificacaoTipo ,
                                        DateTime AV9cNotificacaoDataHoraEnvio ,
                                        long AV12cNotificacaoLigacaoId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF202( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_NOTIFICACAOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A23NotificacaoId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "NOTIFICACAOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23NotificacaoId), 18, 0, ".", "")));
      }

      protected void fix_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
         }
         if ( cmbavCnotificacaotipo.ItemCount > 0 )
         {
            AV8cNotificacaoTipo = (short)(NumberUtil.Val( cmbavCnotificacaotipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV8cNotificacaoTipo), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cNotificacaoTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cNotificacaoTipo), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCnotificacaotipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV8cNotificacaoTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCnotificacaotipo_Internalname, "Values", cmbavCnotificacaotipo.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF202( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF202( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 64;
         nGXsfl_64_idx = 1;
         sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
         SubsflControlProps_642( ) ;
         bGXsfl_64_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "PromptGrid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_642( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID1_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cUsuarioId ,
                                                 AV8cNotificacaoTipo ,
                                                 AV9cNotificacaoDataHoraEnvio ,
                                                 AV12cNotificacaoLigacaoId ,
                                                 A11UsuarioId ,
                                                 A24NotificacaoTipo ,
                                                 A26NotificacaoDataHoraEnvio ,
                                                 A61NotificacaoLigacaoId ,
                                                 AV6cNotificacaoId } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                                 }
            } ) ;
            /* Using cursor H00202 */
            pr_default.execute(0, new Object[] {AV6cNotificacaoId, AV7cUsuarioId, AV8cNotificacaoTipo, AV9cNotificacaoDataHoraEnvio, AV12cNotificacaoLigacaoId, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_64_idx = 1;
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
            SubsflControlProps_642( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A61NotificacaoLigacaoId = H00202_A61NotificacaoLigacaoId[0];
               n61NotificacaoLigacaoId = H00202_n61NotificacaoLigacaoId[0];
               A26NotificacaoDataHoraEnvio = H00202_A26NotificacaoDataHoraEnvio[0];
               A24NotificacaoTipo = H00202_A24NotificacaoTipo[0];
               A11UsuarioId = H00202_A11UsuarioId[0];
               A23NotificacaoId = H00202_A23NotificacaoId[0];
               /* Execute user event: Load */
               E18202 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 64;
            WB200( ) ;
         }
         bGXsfl_64_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes202( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_NOTIFICACAOID"+"_"+sGXsfl_64_idx, GetSecureSignedToken( sGXsfl_64_idx, context.localUtil.Format( (decimal)(A23NotificacaoId), "ZZZZZZZZZZZZZZZZZ9"), context));
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( ((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV7cUsuarioId ,
                                              AV8cNotificacaoTipo ,
                                              AV9cNotificacaoDataHoraEnvio ,
                                              AV12cNotificacaoLigacaoId ,
                                              A11UsuarioId ,
                                              A24NotificacaoTipo ,
                                              A26NotificacaoDataHoraEnvio ,
                                              A61NotificacaoLigacaoId ,
                                              AV6cNotificacaoId } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                              }
         } ) ;
         /* Using cursor H00203 */
         pr_default.execute(1, new Object[] {AV6cNotificacaoId, AV7cUsuarioId, AV8cNotificacaoTipo, AV9cNotificacaoDataHoraEnvio, AV12cNotificacaoLigacaoId});
         GRID1_nRecordCount = H00203_AGRID1_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID1_nRecordCount) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0;
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cNotificacaoId, AV7cUsuarioId, AV8cNotificacaoTipo, AV9cNotificacaoDataHoraEnvio, AV12cNotificacaoLigacaoId) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cNotificacaoId, AV7cUsuarioId, AV8cNotificacaoTipo, AV9cNotificacaoDataHoraEnvio, AV12cNotificacaoLigacaoId) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
         return (short)(((GRID1_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cNotificacaoId, AV7cUsuarioId, AV8cNotificacaoTipo, AV9cNotificacaoDataHoraEnvio, AV12cNotificacaoLigacaoId) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-subGrid1_Recordsperpage( ));
            }
            else
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))));
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cNotificacaoId, AV7cUsuarioId, AV8cNotificacaoTipo, AV9cNotificacaoDataHoraEnvio, AV12cNotificacaoLigacaoId) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (long)(subGrid1_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cNotificacaoId, AV7cUsuarioId, AV8cNotificacaoTipo, AV9cNotificacaoDataHoraEnvio, AV12cNotificacaoLigacaoId) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP200( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E17202 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCnotificacaoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCnotificacaoid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCNOTIFICACAOID");
               GX_FocusControl = edtavCnotificacaoid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cNotificacaoId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cNotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cNotificacaoId), 18, 0)));
            }
            else
            {
               AV6cNotificacaoId = (long)(context.localUtil.CToN( cgiGet( edtavCnotificacaoid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cNotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cNotificacaoId), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCusuarioid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCusuarioid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCUSUARIOID");
               GX_FocusControl = edtavCusuarioid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cUsuarioId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cUsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cUsuarioId), 18, 0)));
            }
            else
            {
               AV7cUsuarioId = (long)(context.localUtil.CToN( cgiGet( edtavCusuarioid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cUsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cUsuarioId), 18, 0)));
            }
            cmbavCnotificacaotipo.Name = cmbavCnotificacaotipo_Internalname;
            cmbavCnotificacaotipo.CurrentValue = cgiGet( cmbavCnotificacaotipo_Internalname);
            AV8cNotificacaoTipo = (short)(NumberUtil.Val( cgiGet( cmbavCnotificacaotipo_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cNotificacaoTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cNotificacaoTipo), 4, 0)));
            if ( context.localUtil.VCDateTime( cgiGet( edtavCnotificacaodatahoraenvio_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Data e hora de envio"}), 1, "vCNOTIFICACAODATAHORAENVIO");
               GX_FocusControl = edtavCnotificacaodatahoraenvio_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cNotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cNotificacaoDataHoraEnvio", context.localUtil.TToC( AV9cNotificacaoDataHoraEnvio, 8, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV9cNotificacaoDataHoraEnvio = context.localUtil.CToT( cgiGet( edtavCnotificacaodatahoraenvio_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cNotificacaoDataHoraEnvio", context.localUtil.TToC( AV9cNotificacaoDataHoraEnvio, 8, 5, 0, 3, "/", ":", " "));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCnotificacaoligacaoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCnotificacaoligacaoid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCNOTIFICACAOLIGACAOID");
               GX_FocusControl = edtavCnotificacaoligacaoid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12cNotificacaoLigacaoId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cNotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cNotificacaoLigacaoId), 18, 0)));
            }
            else
            {
               AV12cNotificacaoLigacaoId = (long)(context.localUtil.CToN( cgiGet( edtavCnotificacaoligacaoid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cNotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cNotificacaoLigacaoId), 18, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_64 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_64"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCNOTIFICACAOID"), ",", ".") != Convert.ToDecimal( AV6cNotificacaoId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOID"), ",", ".") != Convert.ToDecimal( AV7cUsuarioId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCNOTIFICACAOTIPO"), ",", ".") != Convert.ToDecimal( AV8cNotificacaoTipo )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCNOTIFICACAODATAHORAENVIO"), 0) != AV9cNotificacaoDataHoraEnvio )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCNOTIFICACAOLIGACAOID"), ",", ".") != Convert.ToDecimal( AV12cNotificacaoLigacaoId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
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
         E17202 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E17202( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Seleção %1", "Notificação", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV11ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E18202( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV15Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_642( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_64_Refreshing )
         {
            context.DoAjaxLoad(64, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E19202 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19202( )
      {
         /* Enter Routine */
         AV10pNotificacaoId = A23NotificacaoId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pNotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pNotificacaoId), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV10pNotificacaoId});
         context.setWebReturnParmsMetadata(new Object[] {"AV10pNotificacaoId"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10pNotificacaoId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pNotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pNotificacaoId), 18, 0)));
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
         PA202( ) ;
         WS202( ) ;
         WE202( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20189251965716", true);
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
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gx0060.js", "?20189251965716", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_642( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_idx;
         edtNotificacaoId_Internalname = "NOTIFICACAOID_"+sGXsfl_64_idx;
         edtUsuarioId_Internalname = "USUARIOID_"+sGXsfl_64_idx;
         cmbNotificacaoTipo_Internalname = "NOTIFICACAOTIPO_"+sGXsfl_64_idx;
         edtNotificacaoDataHoraEnvio_Internalname = "NOTIFICACAODATAHORAENVIO_"+sGXsfl_64_idx;
         edtNotificacaoLigacaoId_Internalname = "NOTIFICACAOLIGACAOID_"+sGXsfl_64_idx;
      }

      protected void SubsflControlProps_fel_642( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_fel_idx;
         edtNotificacaoId_Internalname = "NOTIFICACAOID_"+sGXsfl_64_fel_idx;
         edtUsuarioId_Internalname = "USUARIOID_"+sGXsfl_64_fel_idx;
         cmbNotificacaoTipo_Internalname = "NOTIFICACAOTIPO_"+sGXsfl_64_fel_idx;
         edtNotificacaoDataHoraEnvio_Internalname = "NOTIFICACAODATAHORAENVIO_"+sGXsfl_64_fel_idx;
         edtNotificacaoLigacaoId_Internalname = "NOTIFICACAOLIGACAOID_"+sGXsfl_64_fel_idx;
      }

      protected void sendrow_642( )
      {
         SubsflControlProps_642( ) ;
         WB200( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_64_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container);
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0;
               subGrid1_Backcolor = subGrid1_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform";
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
               subGrid1_Backcolor = (int)(0x0);
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( ((int)((nGXsfl_64_idx) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"PromptGrid"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_64_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A23NotificacaoId), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_64_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV15Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV15Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNotificacaoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A23NotificacaoId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A23NotificacaoId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtNotificacaoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbNotificacaoTipo.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "NOTIFICACAOTIPO_" + sGXsfl_64_idx;
               cmbNotificacaoTipo.Name = GXCCtl;
               cmbNotificacaoTipo.WebTags = "";
               cmbNotificacaoTipo.addItem("1", "Conquista", 0);
               if ( cmbNotificacaoTipo.ItemCount > 0 )
               {
                  A24NotificacaoTipo = (short)(NumberUtil.Val( cmbNotificacaoTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0))), "."));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbNotificacaoTipo,(String)cmbNotificacaoTipo_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0)),(short)1,(String)cmbNotificacaoTipo_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"DescriptionAttribute",(String)"WWColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbNotificacaoTipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNotificacaoTipo_Internalname, "Values", (String)(cmbNotificacaoTipo.ToJavascriptSource()), !bGXsfl_64_Refreshing);
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNotificacaoDataHoraEnvio_Internalname,context.localUtil.TToC( A26NotificacaoDataHoraEnvio, 10, 8, 0, 3, "/", ":", " "),context.localUtil.Format( A26NotificacaoDataHoraEnvio, "99/99/99 99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtNotificacaoDataHoraEnvio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)14,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"DataHora",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNotificacaoLigacaoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A61NotificacaoLigacaoId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A61NotificacaoLigacaoId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtNotificacaoLigacaoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"IdNivel",(String)"right",(bool)false});
            send_integrity_lvl_hashes202( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_64_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_64_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_64_idx+1));
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
            SubsflControlProps_642( ) ;
         }
         /* End function sendrow_642 */
      }

      protected void init_default_properties( )
      {
         lblLblnotificacaoidfilter_Internalname = "LBLNOTIFICACAOIDFILTER";
         edtavCnotificacaoid_Internalname = "vCNOTIFICACAOID";
         divNotificacaoidfiltercontainer_Internalname = "NOTIFICACAOIDFILTERCONTAINER";
         lblLblusuarioidfilter_Internalname = "LBLUSUARIOIDFILTER";
         edtavCusuarioid_Internalname = "vCUSUARIOID";
         divUsuarioidfiltercontainer_Internalname = "USUARIOIDFILTERCONTAINER";
         lblLblnotificacaotipofilter_Internalname = "LBLNOTIFICACAOTIPOFILTER";
         cmbavCnotificacaotipo_Internalname = "vCNOTIFICACAOTIPO";
         divNotificacaotipofiltercontainer_Internalname = "NOTIFICACAOTIPOFILTERCONTAINER";
         lblLblnotificacaodatahoraenviofilter_Internalname = "LBLNOTIFICACAODATAHORAENVIOFILTER";
         edtavCnotificacaodatahoraenvio_Internalname = "vCNOTIFICACAODATAHORAENVIO";
         divNotificacaodatahoraenviofiltercontainer_Internalname = "NOTIFICACAODATAHORAENVIOFILTERCONTAINER";
         lblLblnotificacaoligacaoidfilter_Internalname = "LBLNOTIFICACAOLIGACAOIDFILTER";
         edtavCnotificacaoligacaoid_Internalname = "vCNOTIFICACAOLIGACAOID";
         divNotificacaoligacaoidfiltercontainer_Internalname = "NOTIFICACAOLIGACAOIDFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtNotificacaoId_Internalname = "NOTIFICACAOID";
         edtUsuarioId_Internalname = "USUARIOID";
         cmbNotificacaoTipo_Internalname = "NOTIFICACAOTIPO";
         edtNotificacaoDataHoraEnvio_Internalname = "NOTIFICACAODATAHORAENVIO";
         edtNotificacaoLigacaoId_Internalname = "NOTIFICACAOLIGACAOID";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         divGridtable_Internalname = "GRIDTABLE";
         divMain_Internalname = "MAIN";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtNotificacaoLigacaoId_Jsonclick = "";
         edtNotificacaoDataHoraEnvio_Jsonclick = "";
         cmbNotificacaoTipo_Jsonclick = "";
         edtUsuarioId_Jsonclick = "";
         edtNotificacaoId_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         cmbNotificacaoTipo.Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCnotificacaoligacaoid_Jsonclick = "";
         edtavCnotificacaoligacaoid_Enabled = 1;
         edtavCnotificacaoligacaoid_Visible = 1;
         edtavCnotificacaodatahoraenvio_Jsonclick = "";
         edtavCnotificacaodatahoraenvio_Enabled = 1;
         cmbavCnotificacaotipo_Jsonclick = "";
         cmbavCnotificacaotipo.Enabled = 1;
         cmbavCnotificacaotipo.Visible = 1;
         edtavCusuarioid_Jsonclick = "";
         edtavCusuarioid_Enabled = 1;
         edtavCusuarioid_Visible = 1;
         edtavCnotificacaoid_Jsonclick = "";
         edtavCnotificacaoid_Enabled = 1;
         edtavCnotificacaoid_Visible = 1;
         divNotificacaoligacaoidfiltercontainer_Class = "AdvancedContainerItem";
         divNotificacaodatahoraenviofiltercontainer_Class = "AdvancedContainerItem";
         divNotificacaotipofiltercontainer_Class = "AdvancedContainerItem";
         divUsuarioidfiltercontainer_Class = "AdvancedContainerItem";
         divNotificacaoidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Notificação";
         subGrid1_Rows = 10;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cNotificacaoId',fld:'vCNOTIFICACAOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'cmbavCnotificacaotipo'},{av:'AV8cNotificacaoTipo',fld:'vCNOTIFICACAOTIPO',pic:'ZZZ9',nv:0},{av:'AV9cNotificacaoDataHoraEnvio',fld:'vCNOTIFICACAODATAHORAENVIO',pic:'99/99/99 99:99',nv:''},{av:'AV12cNotificacaoLigacaoId',fld:'vCNOTIFICACAOLIGACAOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E16201',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLNOTIFICACAOIDFILTER.CLICK","{handler:'E11201',iparms:[{av:'divNotificacaoidfiltercontainer_Class',ctrl:'NOTIFICACAOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divNotificacaoidfiltercontainer_Class',ctrl:'NOTIFICACAOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCnotificacaoid_Visible',ctrl:'vCNOTIFICACAOID',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIOIDFILTER.CLICK","{handler:'E12201',iparms:[{av:'divUsuarioidfiltercontainer_Class',ctrl:'USUARIOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuarioidfiltercontainer_Class',ctrl:'USUARIOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCusuarioid_Visible',ctrl:'vCUSUARIOID',prop:'Visible'}]}");
         setEventMetadata("LBLNOTIFICACAOTIPOFILTER.CLICK","{handler:'E13201',iparms:[{av:'divNotificacaotipofiltercontainer_Class',ctrl:'NOTIFICACAOTIPOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divNotificacaotipofiltercontainer_Class',ctrl:'NOTIFICACAOTIPOFILTERCONTAINER',prop:'Class'},{av:'cmbavCnotificacaotipo'}]}");
         setEventMetadata("LBLNOTIFICACAODATAHORAENVIOFILTER.CLICK","{handler:'E14201',iparms:[{av:'divNotificacaodatahoraenviofiltercontainer_Class',ctrl:'NOTIFICACAODATAHORAENVIOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divNotificacaodatahoraenviofiltercontainer_Class',ctrl:'NOTIFICACAODATAHORAENVIOFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLNOTIFICACAOLIGACAOIDFILTER.CLICK","{handler:'E15201',iparms:[{av:'divNotificacaoligacaoidfiltercontainer_Class',ctrl:'NOTIFICACAOLIGACAOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divNotificacaoligacaoidfiltercontainer_Class',ctrl:'NOTIFICACAOLIGACAOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCnotificacaoligacaoid_Visible',ctrl:'vCNOTIFICACAOLIGACAOID',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E19202',iparms:[{av:'A23NotificacaoId',fld:'NOTIFICACAOID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV10pNotificacaoId',fld:'vPNOTIFICACAOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cNotificacaoId',fld:'vCNOTIFICACAOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'cmbavCnotificacaotipo'},{av:'AV8cNotificacaoTipo',fld:'vCNOTIFICACAOTIPO',pic:'ZZZ9',nv:0},{av:'AV9cNotificacaoDataHoraEnvio',fld:'vCNOTIFICACAODATAHORAENVIO',pic:'99/99/99 99:99',nv:''},{av:'AV12cNotificacaoLigacaoId',fld:'vCNOTIFICACAOLIGACAOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cNotificacaoId',fld:'vCNOTIFICACAOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'cmbavCnotificacaotipo'},{av:'AV8cNotificacaoTipo',fld:'vCNOTIFICACAOTIPO',pic:'ZZZ9',nv:0},{av:'AV9cNotificacaoDataHoraEnvio',fld:'vCNOTIFICACAODATAHORAENVIO',pic:'99/99/99 99:99',nv:''},{av:'AV12cNotificacaoLigacaoId',fld:'vCNOTIFICACAOLIGACAOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cNotificacaoId',fld:'vCNOTIFICACAOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'cmbavCnotificacaotipo'},{av:'AV8cNotificacaoTipo',fld:'vCNOTIFICACAOTIPO',pic:'ZZZ9',nv:0},{av:'AV9cNotificacaoDataHoraEnvio',fld:'vCNOTIFICACAODATAHORAENVIO',pic:'99/99/99 99:99',nv:''},{av:'AV12cNotificacaoLigacaoId',fld:'vCNOTIFICACAOLIGACAOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cNotificacaoId',fld:'vCNOTIFICACAOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'cmbavCnotificacaotipo'},{av:'AV8cNotificacaoTipo',fld:'vCNOTIFICACAOTIPO',pic:'ZZZ9',nv:0},{av:'AV9cNotificacaoDataHoraEnvio',fld:'vCNOTIFICACAODATAHORAENVIO',pic:'99/99/99 99:99',nv:''},{av:'AV12cNotificacaoLigacaoId',fld:'vCNOTIFICACAOLIGACAOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
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
         AV9cNotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblnotificacaoidfilter_Jsonclick = "";
         TempTags = "";
         lblLblusuarioidfilter_Jsonclick = "";
         lblLblnotificacaotipofilter_Jsonclick = "";
         lblLblnotificacaodatahoraenviofilter_Jsonclick = "";
         lblLblnotificacaoligacaoidfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A26NotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV15Linkselection_GXI = "";
         GXCCtl = "";
         scmdbuf = "";
         H00202_A61NotificacaoLigacaoId = new long[1] ;
         H00202_n61NotificacaoLigacaoId = new bool[] {false} ;
         H00202_A26NotificacaoDataHoraEnvio = new DateTime[] {DateTime.MinValue} ;
         H00202_A24NotificacaoTipo = new short[1] ;
         H00202_A11UsuarioId = new long[1] ;
         H00202_A23NotificacaoId = new long[1] ;
         H00203_AGRID1_nRecordCount = new long[1] ;
         AV11ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0060__default(),
            new Object[][] {
                new Object[] {
               H00202_A61NotificacaoLigacaoId, H00202_n61NotificacaoLigacaoId, H00202_A26NotificacaoDataHoraEnvio, H00202_A24NotificacaoTipo, H00202_A11UsuarioId, H00202_A23NotificacaoId
               }
               , new Object[] {
               H00203_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_64 ;
      private short nGXsfl_64_idx=1 ;
      private short GRID1_nEOF ;
      private short AV8cNotificacaoTipo ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A24NotificacaoTipo ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCnotificacaoid_Enabled ;
      private int edtavCnotificacaoid_Visible ;
      private int edtavCusuarioid_Enabled ;
      private int edtavCusuarioid_Visible ;
      private int edtavCnotificacaodatahoraenvio_Enabled ;
      private int edtavCnotificacaoligacaoid_Enabled ;
      private int edtavCnotificacaoligacaoid_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long AV6cNotificacaoId ;
      private long AV7cUsuarioId ;
      private long AV12cNotificacaoLigacaoId ;
      private long AV10pNotificacaoId ;
      private long A23NotificacaoId ;
      private long A11UsuarioId ;
      private long A61NotificacaoLigacaoId ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divNotificacaoidfiltercontainer_Class ;
      private String divUsuarioidfiltercontainer_Class ;
      private String divNotificacaotipofiltercontainer_Class ;
      private String divNotificacaodatahoraenviofiltercontainer_Class ;
      private String divNotificacaoligacaoidfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_64_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divNotificacaoidfiltercontainer_Internalname ;
      private String lblLblnotificacaoidfilter_Internalname ;
      private String lblLblnotificacaoidfilter_Jsonclick ;
      private String edtavCnotificacaoid_Internalname ;
      private String TempTags ;
      private String edtavCnotificacaoid_Jsonclick ;
      private String divUsuarioidfiltercontainer_Internalname ;
      private String lblLblusuarioidfilter_Internalname ;
      private String lblLblusuarioidfilter_Jsonclick ;
      private String edtavCusuarioid_Internalname ;
      private String edtavCusuarioid_Jsonclick ;
      private String divNotificacaotipofiltercontainer_Internalname ;
      private String lblLblnotificacaotipofilter_Internalname ;
      private String lblLblnotificacaotipofilter_Jsonclick ;
      private String cmbavCnotificacaotipo_Internalname ;
      private String cmbavCnotificacaotipo_Jsonclick ;
      private String divNotificacaodatahoraenviofiltercontainer_Internalname ;
      private String lblLblnotificacaodatahoraenviofilter_Internalname ;
      private String lblLblnotificacaodatahoraenviofilter_Jsonclick ;
      private String edtavCnotificacaodatahoraenvio_Internalname ;
      private String edtavCnotificacaodatahoraenvio_Jsonclick ;
      private String divNotificacaoligacaoidfiltercontainer_Internalname ;
      private String lblLblnotificacaoligacaoidfilter_Internalname ;
      private String lblLblnotificacaoligacaoidfilter_Jsonclick ;
      private String edtavCnotificacaoligacaoid_Internalname ;
      private String edtavCnotificacaoligacaoid_Jsonclick ;
      private String divGridtable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String edtavLinkselection_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtNotificacaoId_Internalname ;
      private String edtUsuarioId_Internalname ;
      private String cmbNotificacaoTipo_Internalname ;
      private String edtNotificacaoDataHoraEnvio_Internalname ;
      private String edtNotificacaoLigacaoId_Internalname ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String AV11ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_64_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtNotificacaoId_Jsonclick ;
      private String edtUsuarioId_Jsonclick ;
      private String cmbNotificacaoTipo_Jsonclick ;
      private String edtNotificacaoDataHoraEnvio_Jsonclick ;
      private String edtNotificacaoLigacaoId_Jsonclick ;
      private DateTime AV9cNotificacaoDataHoraEnvio ;
      private DateTime A26NotificacaoDataHoraEnvio ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_64_Refreshing=false ;
      private bool n61NotificacaoLigacaoId ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV15Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCnotificacaotipo ;
      private GXCombobox cmbNotificacaoTipo ;
      private IDataStoreProvider pr_default ;
      private long[] H00202_A61NotificacaoLigacaoId ;
      private bool[] H00202_n61NotificacaoLigacaoId ;
      private DateTime[] H00202_A26NotificacaoDataHoraEnvio ;
      private short[] H00202_A24NotificacaoTipo ;
      private long[] H00202_A11UsuarioId ;
      private long[] H00202_A23NotificacaoId ;
      private long[] H00203_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_pNotificacaoId ;
      private GXWebForm Form ;
   }

   public class gx0060__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00202( IGxContext context ,
                                             long AV7cUsuarioId ,
                                             short AV8cNotificacaoTipo ,
                                             DateTime AV9cNotificacaoDataHoraEnvio ,
                                             long AV12cNotificacaoLigacaoId ,
                                             long A11UsuarioId ,
                                             short A24NotificacaoTipo ,
                                             DateTime A26NotificacaoDataHoraEnvio ,
                                             long A61NotificacaoLigacaoId ,
                                             long AV6cNotificacaoId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [8] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [NotificacaoLigacaoId], [NotificacaoDataHoraEnvio], [NotificacaoTipo], [UsuarioId], [NotificacaoId]";
         sFromString = " FROM [Notificacao] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([NotificacaoId] >= @AV6cNotificacaoId)";
         if ( ! (0==AV7cUsuarioId) )
         {
            sWhereString = sWhereString + " and ([UsuarioId] >= @AV7cUsuarioId)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV8cNotificacaoTipo) )
         {
            sWhereString = sWhereString + " and ([NotificacaoTipo] >= @AV8cNotificacaoTipo)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV9cNotificacaoDataHoraEnvio) )
         {
            sWhereString = sWhereString + " and ([NotificacaoDataHoraEnvio] >= @AV9cNotificacaoDataHoraEnvio)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV12cNotificacaoLigacaoId) )
         {
            sWhereString = sWhereString + " and ([NotificacaoLigacaoId] >= @AV12cNotificacaoLigacaoId)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [NotificacaoId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00203( IGxContext context ,
                                             long AV7cUsuarioId ,
                                             short AV8cNotificacaoTipo ,
                                             DateTime AV9cNotificacaoDataHoraEnvio ,
                                             long AV12cNotificacaoLigacaoId ,
                                             long A11UsuarioId ,
                                             short A24NotificacaoTipo ,
                                             DateTime A26NotificacaoDataHoraEnvio ,
                                             long A61NotificacaoLigacaoId ,
                                             long AV6cNotificacaoId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [5] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Notificacao] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([NotificacaoId] >= @AV6cNotificacaoId)";
         if ( ! (0==AV7cUsuarioId) )
         {
            sWhereString = sWhereString + " and ([UsuarioId] >= @AV7cUsuarioId)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV8cNotificacaoTipo) )
         {
            sWhereString = sWhereString + " and ([NotificacaoTipo] >= @AV8cNotificacaoTipo)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV9cNotificacaoDataHoraEnvio) )
         {
            sWhereString = sWhereString + " and ([NotificacaoDataHoraEnvio] >= @AV9cNotificacaoDataHoraEnvio)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV12cNotificacaoLigacaoId) )
         {
            sWhereString = sWhereString + " and ([NotificacaoLigacaoId] >= @AV12cNotificacaoLigacaoId)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H00202(context, (long)dynConstraints[0] , (short)dynConstraints[1] , (DateTime)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (short)dynConstraints[5] , (DateTime)dynConstraints[6] , (long)dynConstraints[7] , (long)dynConstraints[8] );
               case 1 :
                     return conditional_H00203(context, (long)dynConstraints[0] , (short)dynConstraints[1] , (DateTime)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (short)dynConstraints[5] , (DateTime)dynConstraints[6] , (long)dynConstraints[7] , (long)dynConstraints[8] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00202 ;
          prmH00202 = new Object[] {
          new Object[] {"@AV6cNotificacaoId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV7cUsuarioId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV8cNotificacaoTipo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cNotificacaoDataHoraEnvio",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV12cNotificacaoLigacaoId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00203 ;
          prmH00203 = new Object[] {
          new Object[] {"@AV6cNotificacaoId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV7cUsuarioId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV8cNotificacaoTipo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cNotificacaoDataHoraEnvio",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV12cNotificacaoLigacaoId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00202", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00202,11,0,false,false )
             ,new CursorDef("H00203", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00203,1,0,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(2) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((long[]) buf[4])[0] = rslt.getLong(4) ;
                ((long[]) buf[5])[0] = rslt.getLong(5) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[8]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[11]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[14]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                return;
       }
    }

 }

}
