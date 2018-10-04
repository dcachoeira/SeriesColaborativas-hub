/*
               File: Gx0070
        Description: Selection List Conquista
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:37.34
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
   public class gx0070 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0070( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gx0070( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_pConquistaId )
      {
         this.AV9pConquistaId = 0 ;
         executePrivate();
         aP0_pConquistaId=this.AV9pConquistaId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCconquistatipo = new GXCombobox();
         chkavCconquistainativo = new GXCheckbox();
         cmbConquistaTipo = new GXCombobox();
         chkConquistaInativo = new GXCheckbox();
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
               nRC_GXsfl_74 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_74_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_74_idx = GetNextPar( );
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
               AV6cConquistaId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cConquistaPontos = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cConquistaNome = GetNextPar( );
               AV11cConquistaTipo = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12cConquistaQuantidadeNecessaria = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV13cConquistaInativo = (bool)(BooleanUtil.Val(GetNextPar( )));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cConquistaId, AV7cConquistaPontos, AV8cConquistaNome, AV11cConquistaTipo, AV12cConquistaQuantidadeNecessaria, AV13cConquistaInativo) ;
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
               AV9pConquistaId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9pConquistaId), 18, 0)));
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
         PA212( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START212( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019463742", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0070.aspx") + "?" + UrlEncode("" +AV9pConquistaId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCCONQUISTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cConquistaId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCONQUISTAPONTOS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cConquistaPontos), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCONQUISTANOME", AV8cConquistaNome);
         GxWebStd.gx_hidden_field( context, "GXH_vCCONQUISTATIPO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cConquistaTipo), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCONQUISTAQUANTIDADENECESSARIA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cConquistaQuantidadeNecessaria), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCONQUISTAINATIVO", StringUtil.BoolToStr( AV13cConquistaInativo));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPCONQUISTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9pConquistaId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "CONQUISTAIDFILTERCONTAINER_Class", StringUtil.RTrim( divConquistaidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "CONQUISTAPONTOSFILTERCONTAINER_Class", StringUtil.RTrim( divConquistapontosfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "CONQUISTANOMEFILTERCONTAINER_Class", StringUtil.RTrim( divConquistanomefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "CONQUISTATIPOFILTERCONTAINER_Class", StringUtil.RTrim( divConquistatipofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER_Class", StringUtil.RTrim( divConquistaquantidadenecessariafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "CONQUISTAINATIVOFILTERCONTAINER_Class", StringUtil.RTrim( divConquistainativofiltercontainer_Class));
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
            WE212( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT212( ) ;
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
         return formatLink("gx0070.aspx") + "?" + UrlEncode("" +AV9pConquistaId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0070" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Conquista" ;
      }

      protected void WB210( )
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
            GxWebStd.gx_div_start( context, divConquistaidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divConquistaidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblconquistaidfilter_Internalname, "Id", "", "", lblLblconquistaidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCconquistaid_Internalname, "Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCconquistaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cConquistaId), 18, 0, ",", "")), ((edtavCconquistaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cConquistaId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cConquistaId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCconquistaid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCconquistaid_Visible, edtavCconquistaid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0070.htm");
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
            GxWebStd.gx_div_start( context, divConquistapontosfiltercontainer_Internalname, 1, 0, "px", 0, "px", divConquistapontosfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblconquistapontosfilter_Internalname, "Pontos", "", "", lblLblconquistapontosfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCconquistapontos_Internalname, "Pontos", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCconquistapontos_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cConquistaPontos), 4, 0, ",", "")), ((edtavCconquistapontos_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cConquistaPontos), "ZZZ9")) : context.localUtil.Format( (decimal)(AV7cConquistaPontos), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCconquistapontos_Jsonclick, 0, "Attribute", "", "", "", "", edtavCconquistapontos_Visible, edtavCconquistapontos_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0070.htm");
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
            GxWebStd.gx_div_start( context, divConquistanomefiltercontainer_Internalname, 1, 0, "px", 0, "px", divConquistanomefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblconquistanomefilter_Internalname, "Nome", "", "", lblLblconquistanomefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCconquistanome_Internalname, "Nome", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCconquistanome_Internalname, AV8cConquistaNome, StringUtil.RTrim( context.localUtil.Format( AV8cConquistaNome, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCconquistanome_Jsonclick, 0, "Attribute", "", "", "", "", edtavCconquistanome_Visible, edtavCconquistanome_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0070.htm");
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
            GxWebStd.gx_div_start( context, divConquistatipofiltercontainer_Internalname, 1, 0, "px", 0, "px", divConquistatipofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblconquistatipofilter_Internalname, "Tipo de conquista", "", "", lblLblconquistatipofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCconquistatipo_Internalname, "Tipo de conquista", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCconquistatipo, cmbavCconquistatipo_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV11cConquistaTipo), 4, 0)), 1, cmbavCconquistatipo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavCconquistatipo.Visible, cmbavCconquistatipo.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "", true, "HLP_Gx0070.htm");
            cmbavCconquistatipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV11cConquistaTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCconquistatipo_Internalname, "Values", (String)(cmbavCconquistatipo.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divConquistaquantidadenecessariafiltercontainer_Internalname, 1, 0, "px", 0, "px", divConquistaquantidadenecessariafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblconquistaquantidadenecessariafilter_Internalname, "Quantidade necessária", "", "", lblLblconquistaquantidadenecessariafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCconquistaquantidadenecessaria_Internalname, "Quantidade necessária", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCconquistaquantidadenecessaria_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cConquistaQuantidadeNecessaria), 4, 0, ",", "")), ((edtavCconquistaquantidadenecessaria_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12cConquistaQuantidadeNecessaria), "ZZZ9")) : context.localUtil.Format( (decimal)(AV12cConquistaQuantidadeNecessaria), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCconquistaquantidadenecessaria_Jsonclick, 0, "Attribute", "", "", "", "", edtavCconquistaquantidadenecessaria_Visible, edtavCconquistaquantidadenecessaria_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0070.htm");
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
            GxWebStd.gx_div_start( context, divConquistainativofiltercontainer_Internalname, 1, 0, "px", 0, "px", divConquistainativofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblconquistainativofilter_Internalname, "Inativo", "", "", lblLblconquistainativofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16211_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCconquistainativo_Internalname, "Inativo", "col-sm-3 AttributeLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCconquistainativo_Internalname, StringUtil.BoolToStr( AV13cConquistaInativo), "", "Inativo", chkavCconquistainativo.Visible, chkavCconquistainativo.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(66, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e17211_client"+"'", TempTags, "", 2, "HLP_Gx0070.htm");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"74\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Pontos") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nome") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo de conquista") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Quantidade necessária") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Inativo") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ConquistaId), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A28ConquistaPontos), 4, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtConquistaPontos_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A29ConquistaNome);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A44ConquistaTipo), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A45ConquistaQuantidadeNecessaria), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.BoolToStr( A46ConquistaInativo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            nRC_GXsfl_74 = (short)(nGXsfl_74_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0070.htm");
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

      protected void START212( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Selection List Conquista", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP210( ) ;
      }

      protected void WS212( )
      {
         START212( ) ;
         EVT212( ) ;
      }

      protected void EVT212( )
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
                              nGXsfl_74_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
                              SubsflControlProps_742( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_74_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A27ConquistaId = (long)(context.localUtil.CToN( cgiGet( edtConquistaId_Internalname), ",", "."));
                              A28ConquistaPontos = (short)(context.localUtil.CToN( cgiGet( edtConquistaPontos_Internalname), ",", "."));
                              A29ConquistaNome = cgiGet( edtConquistaNome_Internalname);
                              cmbConquistaTipo.Name = cmbConquistaTipo_Internalname;
                              cmbConquistaTipo.CurrentValue = cgiGet( cmbConquistaTipo_Internalname);
                              A44ConquistaTipo = (short)(NumberUtil.Val( cgiGet( cmbConquistaTipo_Internalname), "."));
                              A45ConquistaQuantidadeNecessaria = (short)(context.localUtil.CToN( cgiGet( edtConquistaQuantidadeNecessaria_Internalname), ",", "."));
                              A46ConquistaInativo = StringUtil.StrToBool( cgiGet( chkConquistaInativo_Internalname));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E18212 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E19212 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cconquistaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCONQUISTAID"), ",", ".") != Convert.ToDecimal( AV6cConquistaId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cconquistapontos Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCONQUISTAPONTOS"), ",", ".") != Convert.ToDecimal( AV7cConquistaPontos )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cconquistanome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCONQUISTANOME"), AV8cConquistaNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cconquistatipo Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCONQUISTATIPO"), ",", ".") != Convert.ToDecimal( AV11cConquistaTipo )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cconquistaquantidadenecessaria Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCONQUISTAQUANTIDADENECESSARIA"), ",", ".") != Convert.ToDecimal( AV12cConquistaQuantidadeNecessaria )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cconquistainativo Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vCCONQUISTAINATIVO")) != AV13cConquistaInativo )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E20212 ();
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

      protected void WE212( )
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

      protected void PA212( )
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
            cmbavCconquistatipo.Name = "vCCONQUISTATIPO";
            cmbavCconquistatipo.WebTags = "";
            cmbavCconquistatipo.addItem("1", "Quantidade de séries", 0);
            cmbavCconquistatipo.addItem("2", "Quantidade de minutos", 0);
            cmbavCconquistatipo.addItem("3", "Quantidade de episódios", 0);
            if ( cmbavCconquistatipo.ItemCount > 0 )
            {
               AV11cConquistaTipo = (short)(NumberUtil.Val( cmbavCconquistatipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV11cConquistaTipo), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cConquistaTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cConquistaTipo), 4, 0)));
            }
            chkavCconquistainativo.Name = "vCCONQUISTAINATIVO";
            chkavCconquistainativo.WebTags = "";
            chkavCconquistainativo.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCconquistainativo_Internalname, "TitleCaption", chkavCconquistainativo.Caption, true);
            chkavCconquistainativo.CheckedValue = "false";
            GXCCtl = "CONQUISTATIPO_" + sGXsfl_74_idx;
            cmbConquistaTipo.Name = GXCCtl;
            cmbConquistaTipo.WebTags = "";
            cmbConquistaTipo.addItem("1", "Quantidade de séries", 0);
            cmbConquistaTipo.addItem("2", "Quantidade de minutos", 0);
            cmbConquistaTipo.addItem("3", "Quantidade de episódios", 0);
            if ( cmbConquistaTipo.ItemCount > 0 )
            {
               A44ConquistaTipo = (short)(NumberUtil.Val( cmbConquistaTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0))), "."));
            }
            GXCCtl = "CONQUISTAINATIVO_" + sGXsfl_74_idx;
            chkConquistaInativo.Name = GXCCtl;
            chkConquistaInativo.WebTags = "";
            chkConquistaInativo.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkConquistaInativo_Internalname, "TitleCaption", chkConquistaInativo.Caption, !bGXsfl_74_Refreshing);
            chkConquistaInativo.CheckedValue = "false";
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
         SubsflControlProps_742( ) ;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        long AV6cConquistaId ,
                                        short AV7cConquistaPontos ,
                                        String AV8cConquistaNome ,
                                        short AV11cConquistaTipo ,
                                        short AV12cConquistaQuantidadeNecessaria ,
                                        bool AV13cConquistaInativo )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF212( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_CONQUISTAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "CONQUISTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ConquistaId), 18, 0, ".", "")));
      }

      protected void fix_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
         }
         if ( cmbavCconquistatipo.ItemCount > 0 )
         {
            AV11cConquistaTipo = (short)(NumberUtil.Val( cmbavCconquistatipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV11cConquistaTipo), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cConquistaTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cConquistaTipo), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCconquistatipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV11cConquistaTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCconquistatipo_Internalname, "Values", cmbavCconquistatipo.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF212( ) ;
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

      protected void RF212( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 74;
         nGXsfl_74_idx = 1;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         SubsflControlProps_742( ) ;
         bGXsfl_74_Refreshing = true;
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
            SubsflControlProps_742( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID1_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cConquistaPontos ,
                                                 AV8cConquistaNome ,
                                                 AV11cConquistaTipo ,
                                                 AV12cConquistaQuantidadeNecessaria ,
                                                 AV13cConquistaInativo ,
                                                 A28ConquistaPontos ,
                                                 A29ConquistaNome ,
                                                 A44ConquistaTipo ,
                                                 A45ConquistaQuantidadeNecessaria ,
                                                 A46ConquistaInativo ,
                                                 AV6cConquistaId } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN,
                                                 TypeConstants.LONG
                                                 }
            } ) ;
            lV8cConquistaNome = StringUtil.Concat( StringUtil.RTrim( AV8cConquistaNome), "%", "");
            /* Using cursor H00212 */
            pr_default.execute(0, new Object[] {AV6cConquistaId, AV7cConquistaPontos, lV8cConquistaNome, AV11cConquistaTipo, AV12cConquistaQuantidadeNecessaria, AV13cConquistaInativo, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_74_idx = 1;
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A46ConquistaInativo = H00212_A46ConquistaInativo[0];
               A45ConquistaQuantidadeNecessaria = H00212_A45ConquistaQuantidadeNecessaria[0];
               A44ConquistaTipo = H00212_A44ConquistaTipo[0];
               A29ConquistaNome = H00212_A29ConquistaNome[0];
               A28ConquistaPontos = H00212_A28ConquistaPontos[0];
               A27ConquistaId = H00212_A27ConquistaId[0];
               /* Execute user event: Load */
               E19212 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB210( ) ;
         }
         bGXsfl_74_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes212( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_CONQUISTAID"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9"), context));
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
                                              AV7cConquistaPontos ,
                                              AV8cConquistaNome ,
                                              AV11cConquistaTipo ,
                                              AV12cConquistaQuantidadeNecessaria ,
                                              AV13cConquistaInativo ,
                                              A28ConquistaPontos ,
                                              A29ConquistaNome ,
                                              A44ConquistaTipo ,
                                              A45ConquistaQuantidadeNecessaria ,
                                              A46ConquistaInativo ,
                                              AV6cConquistaId } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN,
                                              TypeConstants.LONG
                                              }
         } ) ;
         lV8cConquistaNome = StringUtil.Concat( StringUtil.RTrim( AV8cConquistaNome), "%", "");
         /* Using cursor H00213 */
         pr_default.execute(1, new Object[] {AV6cConquistaId, AV7cConquistaPontos, lV8cConquistaNome, AV11cConquistaTipo, AV12cConquistaQuantidadeNecessaria, AV13cConquistaInativo});
         GRID1_nRecordCount = H00213_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cConquistaId, AV7cConquistaPontos, AV8cConquistaNome, AV11cConquistaTipo, AV12cConquistaQuantidadeNecessaria, AV13cConquistaInativo) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cConquistaId, AV7cConquistaPontos, AV8cConquistaNome, AV11cConquistaTipo, AV12cConquistaQuantidadeNecessaria, AV13cConquistaInativo) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cConquistaId, AV7cConquistaPontos, AV8cConquistaNome, AV11cConquistaTipo, AV12cConquistaQuantidadeNecessaria, AV13cConquistaInativo) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cConquistaId, AV7cConquistaPontos, AV8cConquistaNome, AV11cConquistaTipo, AV12cConquistaQuantidadeNecessaria, AV13cConquistaInativo) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cConquistaId, AV7cConquistaPontos, AV8cConquistaNome, AV11cConquistaTipo, AV12cConquistaQuantidadeNecessaria, AV13cConquistaInativo) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP210( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E18212 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCconquistaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCconquistaid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCONQUISTAID");
               GX_FocusControl = edtavCconquistaid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cConquistaId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cConquistaId), 18, 0)));
            }
            else
            {
               AV6cConquistaId = (long)(context.localUtil.CToN( cgiGet( edtavCconquistaid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cConquistaId), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCconquistapontos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCconquistapontos_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCONQUISTAPONTOS");
               GX_FocusControl = edtavCconquistapontos_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cConquistaPontos = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cConquistaPontos), 4, 0)));
            }
            else
            {
               AV7cConquistaPontos = (short)(context.localUtil.CToN( cgiGet( edtavCconquistapontos_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cConquistaPontos), 4, 0)));
            }
            AV8cConquistaNome = cgiGet( edtavCconquistanome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cConquistaNome", AV8cConquistaNome);
            cmbavCconquistatipo.Name = cmbavCconquistatipo_Internalname;
            cmbavCconquistatipo.CurrentValue = cgiGet( cmbavCconquistatipo_Internalname);
            AV11cConquistaTipo = (short)(NumberUtil.Val( cgiGet( cmbavCconquistatipo_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cConquistaTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cConquistaTipo), 4, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCconquistaquantidadenecessaria_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCconquistaquantidadenecessaria_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCONQUISTAQUANTIDADENECESSARIA");
               GX_FocusControl = edtavCconquistaquantidadenecessaria_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12cConquistaQuantidadeNecessaria = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cConquistaQuantidadeNecessaria", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cConquistaQuantidadeNecessaria), 4, 0)));
            }
            else
            {
               AV12cConquistaQuantidadeNecessaria = (short)(context.localUtil.CToN( cgiGet( edtavCconquistaquantidadenecessaria_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cConquistaQuantidadeNecessaria", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cConquistaQuantidadeNecessaria), 4, 0)));
            }
            AV13cConquistaInativo = StringUtil.StrToBool( cgiGet( chkavCconquistainativo_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cConquistaInativo", AV13cConquistaInativo);
            /* Read saved values. */
            nRC_GXsfl_74 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCONQUISTAID"), ",", ".") != Convert.ToDecimal( AV6cConquistaId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCONQUISTAPONTOS"), ",", ".") != Convert.ToDecimal( AV7cConquistaPontos )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCCONQUISTANOME"), AV8cConquistaNome) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCONQUISTATIPO"), ",", ".") != Convert.ToDecimal( AV11cConquistaTipo )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCONQUISTAQUANTIDADENECESSARIA"), ",", ".") != Convert.ToDecimal( AV12cConquistaQuantidadeNecessaria )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vCCONQUISTAINATIVO")) != AV13cConquistaInativo )
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
         E18212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E18212( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Seleção %1", "Conquista", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV10ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E19212( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV16Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_742( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_74_Refreshing )
         {
            context.DoAjaxLoad(74, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E20212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E20212( )
      {
         /* Enter Routine */
         AV9pConquistaId = A27ConquistaId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9pConquistaId), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV9pConquistaId});
         context.setWebReturnParmsMetadata(new Object[] {"AV9pConquistaId"});
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
         AV9pConquistaId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9pConquistaId), 18, 0)));
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
         PA212( ) ;
         WS212( ) ;
         WE212( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019463887", true);
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
         context.AddJavascriptSource("gx0070.js", "?201892019463887", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtConquistaId_Internalname = "CONQUISTAID_"+sGXsfl_74_idx;
         edtConquistaPontos_Internalname = "CONQUISTAPONTOS_"+sGXsfl_74_idx;
         edtConquistaNome_Internalname = "CONQUISTANOME_"+sGXsfl_74_idx;
         cmbConquistaTipo_Internalname = "CONQUISTATIPO_"+sGXsfl_74_idx;
         edtConquistaQuantidadeNecessaria_Internalname = "CONQUISTAQUANTIDADENECESSARIA_"+sGXsfl_74_idx;
         chkConquistaInativo_Internalname = "CONQUISTAINATIVO_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_fel_idx;
         edtConquistaId_Internalname = "CONQUISTAID_"+sGXsfl_74_fel_idx;
         edtConquistaPontos_Internalname = "CONQUISTAPONTOS_"+sGXsfl_74_fel_idx;
         edtConquistaNome_Internalname = "CONQUISTANOME_"+sGXsfl_74_fel_idx;
         cmbConquistaTipo_Internalname = "CONQUISTATIPO_"+sGXsfl_74_fel_idx;
         edtConquistaQuantidadeNecessaria_Internalname = "CONQUISTAQUANTIDADENECESSARIA_"+sGXsfl_74_fel_idx;
         chkConquistaInativo_Internalname = "CONQUISTAINATIVO_"+sGXsfl_74_fel_idx;
      }

      protected void sendrow_742( )
      {
         SubsflControlProps_742( ) ;
         WB210( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_74_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_74_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_74_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ConquistaId), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_74_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV16Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConquistaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ConquistaId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtConquistaId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtConquistaPontos_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ConquistaId), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaPontos_Internalname, "Link", edtConquistaPontos_Link, !bGXsfl_74_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConquistaPontos_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A28ConquistaPontos), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A28ConquistaPontos), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtConquistaPontos_Link,(String)"",(String)"",(String)"",(String)edtConquistaPontos_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Pontos",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConquistaNome_Internalname,(String)A29ConquistaNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtConquistaNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nome",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbConquistaTipo.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "CONQUISTATIPO_" + sGXsfl_74_idx;
               cmbConquistaTipo.Name = GXCCtl;
               cmbConquistaTipo.WebTags = "";
               cmbConquistaTipo.addItem("1", "Quantidade de séries", 0);
               cmbConquistaTipo.addItem("2", "Quantidade de minutos", 0);
               cmbConquistaTipo.addItem("3", "Quantidade de episódios", 0);
               if ( cmbConquistaTipo.ItemCount > 0 )
               {
                  A44ConquistaTipo = (short)(NumberUtil.Val( cmbConquistaTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0))), "."));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbConquistaTipo,(String)cmbConquistaTipo_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0)),(short)1,(String)cmbConquistaTipo_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn OptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbConquistaTipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A44ConquistaTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbConquistaTipo_Internalname, "Values", (String)(cmbConquistaTipo.ToJavascriptSource()), !bGXsfl_74_Refreshing);
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConquistaQuantidadeNecessaria_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A45ConquistaQuantidadeNecessaria), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A45ConquistaQuantidadeNecessaria), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtConquistaQuantidadeNecessaria_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Quantidade",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "Attribute";
            StyleString = "";
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkConquistaInativo_Internalname,StringUtil.BoolToStr( A46ConquistaInativo),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn OptionalColumn",(String)"",(String)""});
            send_integrity_lvl_hashes212( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
         }
         /* End function sendrow_742 */
      }

      protected void init_default_properties( )
      {
         lblLblconquistaidfilter_Internalname = "LBLCONQUISTAIDFILTER";
         edtavCconquistaid_Internalname = "vCCONQUISTAID";
         divConquistaidfiltercontainer_Internalname = "CONQUISTAIDFILTERCONTAINER";
         lblLblconquistapontosfilter_Internalname = "LBLCONQUISTAPONTOSFILTER";
         edtavCconquistapontos_Internalname = "vCCONQUISTAPONTOS";
         divConquistapontosfiltercontainer_Internalname = "CONQUISTAPONTOSFILTERCONTAINER";
         lblLblconquistanomefilter_Internalname = "LBLCONQUISTANOMEFILTER";
         edtavCconquistanome_Internalname = "vCCONQUISTANOME";
         divConquistanomefiltercontainer_Internalname = "CONQUISTANOMEFILTERCONTAINER";
         lblLblconquistatipofilter_Internalname = "LBLCONQUISTATIPOFILTER";
         cmbavCconquistatipo_Internalname = "vCCONQUISTATIPO";
         divConquistatipofiltercontainer_Internalname = "CONQUISTATIPOFILTERCONTAINER";
         lblLblconquistaquantidadenecessariafilter_Internalname = "LBLCONQUISTAQUANTIDADENECESSARIAFILTER";
         edtavCconquistaquantidadenecessaria_Internalname = "vCCONQUISTAQUANTIDADENECESSARIA";
         divConquistaquantidadenecessariafiltercontainer_Internalname = "CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER";
         lblLblconquistainativofilter_Internalname = "LBLCONQUISTAINATIVOFILTER";
         chkavCconquistainativo_Internalname = "vCCONQUISTAINATIVO";
         divConquistainativofiltercontainer_Internalname = "CONQUISTAINATIVOFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtConquistaId_Internalname = "CONQUISTAID";
         edtConquistaPontos_Internalname = "CONQUISTAPONTOS";
         edtConquistaNome_Internalname = "CONQUISTANOME";
         cmbConquistaTipo_Internalname = "CONQUISTATIPO";
         edtConquistaQuantidadeNecessaria_Internalname = "CONQUISTAQUANTIDADENECESSARIA";
         chkConquistaInativo_Internalname = "CONQUISTAINATIVO";
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
         edtConquistaQuantidadeNecessaria_Jsonclick = "";
         cmbConquistaTipo_Jsonclick = "";
         edtConquistaNome_Jsonclick = "";
         edtConquistaPontos_Jsonclick = "";
         edtConquistaId_Jsonclick = "";
         chkConquistaInativo.Caption = "";
         chkavCconquistainativo.Caption = "Inativo";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtConquistaPontos_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         chkavCconquistainativo.Enabled = 1;
         chkavCconquistainativo.Visible = 1;
         edtavCconquistaquantidadenecessaria_Jsonclick = "";
         edtavCconquistaquantidadenecessaria_Enabled = 1;
         edtavCconquistaquantidadenecessaria_Visible = 1;
         cmbavCconquistatipo_Jsonclick = "";
         cmbavCconquistatipo.Enabled = 1;
         cmbavCconquistatipo.Visible = 1;
         edtavCconquistanome_Jsonclick = "";
         edtavCconquistanome_Enabled = 1;
         edtavCconquistanome_Visible = 1;
         edtavCconquistapontos_Jsonclick = "";
         edtavCconquistapontos_Enabled = 1;
         edtavCconquistapontos_Visible = 1;
         edtavCconquistaid_Jsonclick = "";
         edtavCconquistaid_Enabled = 1;
         edtavCconquistaid_Visible = 1;
         divConquistainativofiltercontainer_Class = "AdvancedContainerItem";
         divConquistaquantidadenecessariafiltercontainer_Class = "AdvancedContainerItem";
         divConquistatipofiltercontainer_Class = "AdvancedContainerItem";
         divConquistanomefiltercontainer_Class = "AdvancedContainerItem";
         divConquistapontosfiltercontainer_Class = "AdvancedContainerItem";
         divConquistaidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Conquista";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cConquistaId',fld:'vCCONQUISTAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cConquistaPontos',fld:'vCCONQUISTAPONTOS',pic:'ZZZ9',nv:0},{av:'AV8cConquistaNome',fld:'vCCONQUISTANOME',pic:'',nv:''},{av:'cmbavCconquistatipo'},{av:'AV11cConquistaTipo',fld:'vCCONQUISTATIPO',pic:'ZZZ9',nv:0},{av:'AV12cConquistaQuantidadeNecessaria',fld:'vCCONQUISTAQUANTIDADENECESSARIA',pic:'ZZZ9',nv:0},{av:'AV13cConquistaInativo',fld:'vCCONQUISTAINATIVO',pic:'',nv:false}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E17211',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLCONQUISTAIDFILTER.CLICK","{handler:'E11211',iparms:[{av:'divConquistaidfiltercontainer_Class',ctrl:'CONQUISTAIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divConquistaidfiltercontainer_Class',ctrl:'CONQUISTAIDFILTERCONTAINER',prop:'Class'},{av:'edtavCconquistaid_Visible',ctrl:'vCCONQUISTAID',prop:'Visible'}]}");
         setEventMetadata("LBLCONQUISTAPONTOSFILTER.CLICK","{handler:'E12211',iparms:[{av:'divConquistapontosfiltercontainer_Class',ctrl:'CONQUISTAPONTOSFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divConquistapontosfiltercontainer_Class',ctrl:'CONQUISTAPONTOSFILTERCONTAINER',prop:'Class'},{av:'edtavCconquistapontos_Visible',ctrl:'vCCONQUISTAPONTOS',prop:'Visible'}]}");
         setEventMetadata("LBLCONQUISTANOMEFILTER.CLICK","{handler:'E13211',iparms:[{av:'divConquistanomefiltercontainer_Class',ctrl:'CONQUISTANOMEFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divConquistanomefiltercontainer_Class',ctrl:'CONQUISTANOMEFILTERCONTAINER',prop:'Class'},{av:'edtavCconquistanome_Visible',ctrl:'vCCONQUISTANOME',prop:'Visible'}]}");
         setEventMetadata("LBLCONQUISTATIPOFILTER.CLICK","{handler:'E14211',iparms:[{av:'divConquistatipofiltercontainer_Class',ctrl:'CONQUISTATIPOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divConquistatipofiltercontainer_Class',ctrl:'CONQUISTATIPOFILTERCONTAINER',prop:'Class'},{av:'cmbavCconquistatipo'}]}");
         setEventMetadata("LBLCONQUISTAQUANTIDADENECESSARIAFILTER.CLICK","{handler:'E15211',iparms:[{av:'divConquistaquantidadenecessariafiltercontainer_Class',ctrl:'CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divConquistaquantidadenecessariafiltercontainer_Class',ctrl:'CONQUISTAQUANTIDADENECESSARIAFILTERCONTAINER',prop:'Class'},{av:'edtavCconquistaquantidadenecessaria_Visible',ctrl:'vCCONQUISTAQUANTIDADENECESSARIA',prop:'Visible'}]}");
         setEventMetadata("LBLCONQUISTAINATIVOFILTER.CLICK","{handler:'E16211',iparms:[{av:'divConquistainativofiltercontainer_Class',ctrl:'CONQUISTAINATIVOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divConquistainativofiltercontainer_Class',ctrl:'CONQUISTAINATIVOFILTERCONTAINER',prop:'Class'},{av:'chkavCconquistainativo.Visible',ctrl:'vCCONQUISTAINATIVO',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E20212',iparms:[{av:'A27ConquistaId',fld:'CONQUISTAID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV9pConquistaId',fld:'vPCONQUISTAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cConquistaId',fld:'vCCONQUISTAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cConquistaPontos',fld:'vCCONQUISTAPONTOS',pic:'ZZZ9',nv:0},{av:'AV8cConquistaNome',fld:'vCCONQUISTANOME',pic:'',nv:''},{av:'cmbavCconquistatipo'},{av:'AV11cConquistaTipo',fld:'vCCONQUISTATIPO',pic:'ZZZ9',nv:0},{av:'AV12cConquistaQuantidadeNecessaria',fld:'vCCONQUISTAQUANTIDADENECESSARIA',pic:'ZZZ9',nv:0},{av:'AV13cConquistaInativo',fld:'vCCONQUISTAINATIVO',pic:'',nv:false}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cConquistaId',fld:'vCCONQUISTAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cConquistaPontos',fld:'vCCONQUISTAPONTOS',pic:'ZZZ9',nv:0},{av:'AV8cConquistaNome',fld:'vCCONQUISTANOME',pic:'',nv:''},{av:'cmbavCconquistatipo'},{av:'AV11cConquistaTipo',fld:'vCCONQUISTATIPO',pic:'ZZZ9',nv:0},{av:'AV12cConquistaQuantidadeNecessaria',fld:'vCCONQUISTAQUANTIDADENECESSARIA',pic:'ZZZ9',nv:0},{av:'AV13cConquistaInativo',fld:'vCCONQUISTAINATIVO',pic:'',nv:false}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cConquistaId',fld:'vCCONQUISTAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cConquistaPontos',fld:'vCCONQUISTAPONTOS',pic:'ZZZ9',nv:0},{av:'AV8cConquistaNome',fld:'vCCONQUISTANOME',pic:'',nv:''},{av:'cmbavCconquistatipo'},{av:'AV11cConquistaTipo',fld:'vCCONQUISTATIPO',pic:'ZZZ9',nv:0},{av:'AV12cConquistaQuantidadeNecessaria',fld:'vCCONQUISTAQUANTIDADENECESSARIA',pic:'ZZZ9',nv:0},{av:'AV13cConquistaInativo',fld:'vCCONQUISTAINATIVO',pic:'',nv:false}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cConquistaId',fld:'vCCONQUISTAID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cConquistaPontos',fld:'vCCONQUISTAPONTOS',pic:'ZZZ9',nv:0},{av:'AV8cConquistaNome',fld:'vCCONQUISTANOME',pic:'',nv:''},{av:'cmbavCconquistatipo'},{av:'AV11cConquistaTipo',fld:'vCCONQUISTATIPO',pic:'ZZZ9',nv:0},{av:'AV12cConquistaQuantidadeNecessaria',fld:'vCCONQUISTAQUANTIDADENECESSARIA',pic:'ZZZ9',nv:0},{av:'AV13cConquistaInativo',fld:'vCCONQUISTAINATIVO',pic:'',nv:false}],oparms:[]}");
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
         AV8cConquistaNome = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblconquistaidfilter_Jsonclick = "";
         TempTags = "";
         lblLblconquistapontosfilter_Jsonclick = "";
         lblLblconquistanomefilter_Jsonclick = "";
         lblLblconquistatipofilter_Jsonclick = "";
         lblLblconquistaquantidadenecessariafilter_Jsonclick = "";
         lblLblconquistainativofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A29ConquistaNome = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV16Linkselection_GXI = "";
         GXCCtl = "";
         scmdbuf = "";
         lV8cConquistaNome = "";
         H00212_A46ConquistaInativo = new bool[] {false} ;
         H00212_A45ConquistaQuantidadeNecessaria = new short[1] ;
         H00212_A44ConquistaTipo = new short[1] ;
         H00212_A29ConquistaNome = new String[] {""} ;
         H00212_A28ConquistaPontos = new short[1] ;
         H00212_A27ConquistaId = new long[1] ;
         H00213_AGRID1_nRecordCount = new long[1] ;
         AV10ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0070__default(),
            new Object[][] {
                new Object[] {
               H00212_A46ConquistaInativo, H00212_A45ConquistaQuantidadeNecessaria, H00212_A44ConquistaTipo, H00212_A29ConquistaNome, H00212_A28ConquistaPontos, H00212_A27ConquistaId
               }
               , new Object[] {
               H00213_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_74 ;
      private short nGXsfl_74_idx=1 ;
      private short GRID1_nEOF ;
      private short AV7cConquistaPontos ;
      private short AV11cConquistaTipo ;
      private short AV12cConquistaQuantidadeNecessaria ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A28ConquistaPontos ;
      private short A44ConquistaTipo ;
      private short A45ConquistaQuantidadeNecessaria ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCconquistaid_Enabled ;
      private int edtavCconquistaid_Visible ;
      private int edtavCconquistapontos_Enabled ;
      private int edtavCconquistapontos_Visible ;
      private int edtavCconquistanome_Visible ;
      private int edtavCconquistanome_Enabled ;
      private int edtavCconquistaquantidadenecessaria_Enabled ;
      private int edtavCconquistaquantidadenecessaria_Visible ;
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
      private long AV6cConquistaId ;
      private long AV9pConquistaId ;
      private long A27ConquistaId ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divConquistaidfiltercontainer_Class ;
      private String divConquistapontosfiltercontainer_Class ;
      private String divConquistanomefiltercontainer_Class ;
      private String divConquistatipofiltercontainer_Class ;
      private String divConquistaquantidadenecessariafiltercontainer_Class ;
      private String divConquistainativofiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divConquistaidfiltercontainer_Internalname ;
      private String lblLblconquistaidfilter_Internalname ;
      private String lblLblconquistaidfilter_Jsonclick ;
      private String edtavCconquistaid_Internalname ;
      private String TempTags ;
      private String edtavCconquistaid_Jsonclick ;
      private String divConquistapontosfiltercontainer_Internalname ;
      private String lblLblconquistapontosfilter_Internalname ;
      private String lblLblconquistapontosfilter_Jsonclick ;
      private String edtavCconquistapontos_Internalname ;
      private String edtavCconquistapontos_Jsonclick ;
      private String divConquistanomefiltercontainer_Internalname ;
      private String lblLblconquistanomefilter_Internalname ;
      private String lblLblconquistanomefilter_Jsonclick ;
      private String edtavCconquistanome_Internalname ;
      private String edtavCconquistanome_Jsonclick ;
      private String divConquistatipofiltercontainer_Internalname ;
      private String lblLblconquistatipofilter_Internalname ;
      private String lblLblconquistatipofilter_Jsonclick ;
      private String cmbavCconquistatipo_Internalname ;
      private String cmbavCconquistatipo_Jsonclick ;
      private String divConquistaquantidadenecessariafiltercontainer_Internalname ;
      private String lblLblconquistaquantidadenecessariafilter_Internalname ;
      private String lblLblconquistaquantidadenecessariafilter_Jsonclick ;
      private String edtavCconquistaquantidadenecessaria_Internalname ;
      private String edtavCconquistaquantidadenecessaria_Jsonclick ;
      private String divConquistainativofiltercontainer_Internalname ;
      private String lblLblconquistainativofilter_Internalname ;
      private String lblLblconquistainativofilter_Jsonclick ;
      private String chkavCconquistainativo_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divGridtable_Internalname ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String edtavLinkselection_Link ;
      private String edtConquistaPontos_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtConquistaId_Internalname ;
      private String edtConquistaPontos_Internalname ;
      private String edtConquistaNome_Internalname ;
      private String cmbConquistaTipo_Internalname ;
      private String edtConquistaQuantidadeNecessaria_Internalname ;
      private String chkConquistaInativo_Internalname ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String AV10ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_74_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtConquistaId_Jsonclick ;
      private String edtConquistaPontos_Jsonclick ;
      private String edtConquistaNome_Jsonclick ;
      private String cmbConquistaTipo_Jsonclick ;
      private String edtConquistaQuantidadeNecessaria_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV13cConquistaInativo ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool A46ConquistaInativo ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_74_Refreshing=false ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV8cConquistaNome ;
      private String A29ConquistaNome ;
      private String AV16Linkselection_GXI ;
      private String lV8cConquistaNome ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCconquistatipo ;
      private GXCheckbox chkavCconquistainativo ;
      private GXCombobox cmbConquistaTipo ;
      private GXCheckbox chkConquistaInativo ;
      private IDataStoreProvider pr_default ;
      private bool[] H00212_A46ConquistaInativo ;
      private short[] H00212_A45ConquistaQuantidadeNecessaria ;
      private short[] H00212_A44ConquistaTipo ;
      private String[] H00212_A29ConquistaNome ;
      private short[] H00212_A28ConquistaPontos ;
      private long[] H00212_A27ConquistaId ;
      private long[] H00213_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_pConquistaId ;
      private GXWebForm Form ;
   }

   public class gx0070__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00212( IGxContext context ,
                                             short AV7cConquistaPontos ,
                                             String AV8cConquistaNome ,
                                             short AV11cConquistaTipo ,
                                             short AV12cConquistaQuantidadeNecessaria ,
                                             bool AV13cConquistaInativo ,
                                             short A28ConquistaPontos ,
                                             String A29ConquistaNome ,
                                             short A44ConquistaTipo ,
                                             short A45ConquistaQuantidadeNecessaria ,
                                             bool A46ConquistaInativo ,
                                             long AV6cConquistaId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [9] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [ConquistaInativo], [ConquistaQuantidadeNecessaria], [ConquistaTipo], [ConquistaNome], [ConquistaPontos], [ConquistaId]";
         sFromString = " FROM [Conquista] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([ConquistaId] >= @AV6cConquistaId)";
         if ( ! (0==AV7cConquistaPontos) )
         {
            sWhereString = sWhereString + " and ([ConquistaPontos] >= @AV7cConquistaPontos)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cConquistaNome)) )
         {
            sWhereString = sWhereString + " and ([ConquistaNome] like @lV8cConquistaNome)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV11cConquistaTipo) )
         {
            sWhereString = sWhereString + " and ([ConquistaTipo] >= @AV11cConquistaTipo)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV12cConquistaQuantidadeNecessaria) )
         {
            sWhereString = sWhereString + " and ([ConquistaQuantidadeNecessaria] >= @AV12cConquistaQuantidadeNecessaria)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (false==AV13cConquistaInativo) )
         {
            sWhereString = sWhereString + " and ([ConquistaInativo] >= @AV13cConquistaInativo)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [ConquistaId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00213( IGxContext context ,
                                             short AV7cConquistaPontos ,
                                             String AV8cConquistaNome ,
                                             short AV11cConquistaTipo ,
                                             short AV12cConquistaQuantidadeNecessaria ,
                                             bool AV13cConquistaInativo ,
                                             short A28ConquistaPontos ,
                                             String A29ConquistaNome ,
                                             short A44ConquistaTipo ,
                                             short A45ConquistaQuantidadeNecessaria ,
                                             bool A46ConquistaInativo ,
                                             long AV6cConquistaId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Conquista] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([ConquistaId] >= @AV6cConquistaId)";
         if ( ! (0==AV7cConquistaPontos) )
         {
            sWhereString = sWhereString + " and ([ConquistaPontos] >= @AV7cConquistaPontos)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cConquistaNome)) )
         {
            sWhereString = sWhereString + " and ([ConquistaNome] like @lV8cConquistaNome)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV11cConquistaTipo) )
         {
            sWhereString = sWhereString + " and ([ConquistaTipo] >= @AV11cConquistaTipo)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV12cConquistaQuantidadeNecessaria) )
         {
            sWhereString = sWhereString + " and ([ConquistaQuantidadeNecessaria] >= @AV12cConquistaQuantidadeNecessaria)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (false==AV13cConquistaInativo) )
         {
            sWhereString = sWhereString + " and ([ConquistaInativo] >= @AV13cConquistaInativo)";
         }
         else
         {
            GXv_int3[5] = 1;
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
                     return conditional_H00212(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (bool)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] , (bool)dynConstraints[9] , (long)dynConstraints[10] );
               case 1 :
                     return conditional_H00213(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (bool)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] , (bool)dynConstraints[9] , (long)dynConstraints[10] );
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
          Object[] prmH00212 ;
          prmH00212 = new Object[] {
          new Object[] {"@AV6cConquistaId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV7cConquistaPontos",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV8cConquistaNome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV11cConquistaTipo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12cConquistaQuantidadeNecessaria",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13cConquistaInativo",SqlDbType.Bit,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00213 ;
          prmH00213 = new Object[] {
          new Object[] {"@AV6cConquistaId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV7cConquistaPontos",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV8cConquistaNome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV11cConquistaTipo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12cConquistaQuantidadeNecessaria",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13cConquistaInativo",SqlDbType.Bit,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00212", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00212,11,0,false,false )
             ,new CursorDef("H00213", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00213,1,0,false,false )
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
                ((bool[]) buf[0])[0] = rslt.getBool(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
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
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[11]);
                }
                return;
       }
    }

 }

}
