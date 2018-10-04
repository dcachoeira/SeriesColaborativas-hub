/*
               File: Gx0020
        Description: Selection List Episódio
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:30.84
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
   public class gx0020 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0020( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gx0020( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_pEpisodioId )
      {
         this.AV10pEpisodioId = 0 ;
         executePrivate();
         aP0_pEpisodioId=this.AV10pEpisodioId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavCepisodioinativo = new GXCheckbox();
         chkEpisodioInativo = new GXCheckbox();
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
               nRC_GXsfl_84 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_84_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_84_idx = GetNextPar( );
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
               AV6cEpisodioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cSerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cEpisodioNome = GetNextPar( );
               AV9cEpisodioDuracao = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12cEpisodioTemporada = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV13cEpisodioInativo = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV14cEpisodioNumero = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cEpisodioId, AV7cSerieId, AV8cEpisodioNome, AV9cEpisodioDuracao, AV12cEpisodioTemporada, AV13cEpisodioInativo, AV14cEpisodioNumero) ;
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
               AV10pEpisodioId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pEpisodioId), 18, 0)));
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
         PA1W2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1W2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019463093", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0020.aspx") + "?" + UrlEncode("" +AV10pEpisodioId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCEPISODIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cEpisodioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cSerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCEPISODIONOME", AV8cEpisodioNome);
         GxWebStd.gx_hidden_field( context, "GXH_vCEPISODIODURACAO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cEpisodioDuracao), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCEPISODIOTEMPORADA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cEpisodioTemporada), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCEPISODIOINATIVO", StringUtil.BoolToStr( AV13cEpisodioInativo));
         GxWebStd.gx_hidden_field( context, "GXH_vCEPISODIONUMERO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14cEpisodioNumero), 3, 0, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPEPISODIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10pEpisodioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "EPISODIOIDFILTERCONTAINER_Class", StringUtil.RTrim( divEpisodioidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SERIEIDFILTERCONTAINER_Class", StringUtil.RTrim( divSerieidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EPISODIONOMEFILTERCONTAINER_Class", StringUtil.RTrim( divEpisodionomefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EPISODIODURACAOFILTERCONTAINER_Class", StringUtil.RTrim( divEpisodioduracaofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EPISODIOTEMPORADAFILTERCONTAINER_Class", StringUtil.RTrim( divEpisodiotemporadafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EPISODIOINATIVOFILTERCONTAINER_Class", StringUtil.RTrim( divEpisodioinativofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "EPISODIONUMEROFILTERCONTAINER_Class", StringUtil.RTrim( divEpisodionumerofiltercontainer_Class));
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
            WE1W2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1W2( ) ;
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
         return formatLink("gx0020.aspx") + "?" + UrlEncode("" +AV10pEpisodioId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0020" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Episódio" ;
      }

      protected void WB1W0( )
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
            GxWebStd.gx_div_start( context, divEpisodioidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEpisodioidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblepisodioidfilter_Internalname, "Id", "", "", lblLblepisodioidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCepisodioid_Internalname, "Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCepisodioid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cEpisodioId), 18, 0, ",", "")), ((edtavCepisodioid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cEpisodioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cEpisodioId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCepisodioid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCepisodioid_Visible, edtavCepisodioid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0020.htm");
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
            GxWebStd.gx_div_start( context, divSerieidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divSerieidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblserieidfilter_Internalname, "Id", "", "", lblLblserieidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCserieid_Internalname, "Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCserieid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cSerieId), 18, 0, ",", "")), ((edtavCserieid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cSerieId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7cSerieId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCserieid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCserieid_Visible, edtavCserieid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0020.htm");
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
            GxWebStd.gx_div_start( context, divEpisodionomefiltercontainer_Internalname, 1, 0, "px", 0, "px", divEpisodionomefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblepisodionomefilter_Internalname, "Nome", "", "", lblLblepisodionomefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCepisodionome_Internalname, "Nome", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCepisodionome_Internalname, AV8cEpisodioNome, StringUtil.RTrim( context.localUtil.Format( AV8cEpisodioNome, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCepisodionome_Jsonclick, 0, "Attribute", "", "", "", "", edtavCepisodionome_Visible, edtavCepisodionome_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0020.htm");
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
            GxWebStd.gx_div_start( context, divEpisodioduracaofiltercontainer_Internalname, 1, 0, "px", 0, "px", divEpisodioduracaofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblepisodioduracaofilter_Internalname, "Duração", "", "", lblLblepisodioduracaofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCepisodioduracao_Internalname, "Duração", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCepisodioduracao_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cEpisodioDuracao), 3, 0, ",", "")), ((edtavCepisodioduracao_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9cEpisodioDuracao), "ZZZ")) : context.localUtil.Format( (decimal)(AV9cEpisodioDuracao), "ZZZ")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCepisodioduracao_Jsonclick, 0, "Attribute", "", "", "", "", edtavCepisodioduracao_Visible, edtavCepisodioduracao_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0020.htm");
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
            GxWebStd.gx_div_start( context, divEpisodiotemporadafiltercontainer_Internalname, 1, 0, "px", 0, "px", divEpisodiotemporadafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblepisodiotemporadafilter_Internalname, "Temporada", "", "", lblLblepisodiotemporadafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCepisodiotemporada_Internalname, "Temporada", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCepisodiotemporada_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cEpisodioTemporada), 4, 0, ",", "")), ((edtavCepisodiotemporada_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12cEpisodioTemporada), "ZZZ9")) : context.localUtil.Format( (decimal)(AV12cEpisodioTemporada), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCepisodiotemporada_Jsonclick, 0, "Attribute", "", "", "", "", edtavCepisodiotemporada_Visible, edtavCepisodiotemporada_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0020.htm");
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
            GxWebStd.gx_div_start( context, divEpisodioinativofiltercontainer_Internalname, 1, 0, "px", 0, "px", divEpisodioinativofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblepisodioinativofilter_Internalname, "Inativo", "", "", lblLblepisodioinativofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e161w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCepisodioinativo_Internalname, "Inativo", "col-sm-3 AttributeLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCepisodioinativo_Internalname, StringUtil.BoolToStr( AV13cEpisodioInativo), "", "Inativo", chkavCepisodioinativo.Visible, chkavCepisodioinativo.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(66, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"");
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
            GxWebStd.gx_div_start( context, divEpisodionumerofiltercontainer_Internalname, 1, 0, "px", 0, "px", divEpisodionumerofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblepisodionumerofilter_Internalname, "Número do episódio", "", "", lblLblepisodionumerofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e171w1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0020.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCepisodionumero_Internalname, "Número do episódio", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCepisodionumero_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14cEpisodioNumero), 3, 0, ",", "")), ((edtavCepisodionumero_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14cEpisodioNumero), "ZZ9")) : context.localUtil.Format( (decimal)(AV14cEpisodioNumero), "ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCepisodionumero_Jsonclick, 0, "Attribute", "", "", "", "", edtavCepisodionumero_Visible, edtavCepisodionumero_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0020.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e181w1_client"+"'", TempTags, "", 2, "HLP_Gx0020.htm");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"84\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nome") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Duração") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Temporada") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Inativo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "do episódio") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EpisodioId), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A8EpisodioNome);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtEpisodioNome_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A9EpisodioDuracao), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42EpisodioTemporada), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.BoolToStr( A51EpisodioInativo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A58EpisodioNumero), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 84 )
         {
            wbEnd = 0;
            nRC_GXsfl_84 = (short)(nGXsfl_84_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0020.htm");
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

      protected void START1W2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Selection List Episódio", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1W0( ) ;
      }

      protected void WS1W2( )
      {
         START1W2( ) ;
         EVT1W2( ) ;
      }

      protected void EVT1W2( )
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
                              nGXsfl_84_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
                              SubsflControlProps_842( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_84_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A7EpisodioId = (long)(context.localUtil.CToN( cgiGet( edtEpisodioId_Internalname), ",", "."));
                              A1SerieId = (long)(context.localUtil.CToN( cgiGet( edtSerieId_Internalname), ",", "."));
                              A8EpisodioNome = cgiGet( edtEpisodioNome_Internalname);
                              A9EpisodioDuracao = (short)(context.localUtil.CToN( cgiGet( edtEpisodioDuracao_Internalname), ",", "."));
                              A42EpisodioTemporada = (short)(context.localUtil.CToN( cgiGet( edtEpisodioTemporada_Internalname), ",", "."));
                              A51EpisodioInativo = StringUtil.StrToBool( cgiGet( chkEpisodioInativo_Internalname));
                              A58EpisodioNumero = (short)(context.localUtil.CToN( cgiGet( edtEpisodioNumero_Internalname), ",", "."));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E191W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E201W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cepisodioid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEPISODIOID"), ",", ".") != Convert.ToDecimal( AV6cEpisodioId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cserieid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSERIEID"), ",", ".") != Convert.ToDecimal( AV7cSerieId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cepisodionome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCEPISODIONOME"), AV8cEpisodioNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cepisodioduracao Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEPISODIODURACAO"), ",", ".") != Convert.ToDecimal( AV9cEpisodioDuracao )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cepisodiotemporada Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEPISODIOTEMPORADA"), ",", ".") != Convert.ToDecimal( AV12cEpisodioTemporada )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cepisodioinativo Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vCEPISODIOINATIVO")) != AV13cEpisodioInativo )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cepisodionumero Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEPISODIONUMERO"), ",", ".") != Convert.ToDecimal( AV14cEpisodioNumero )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E211W2 ();
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

      protected void WE1W2( )
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

      protected void PA1W2( )
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
            chkavCepisodioinativo.Name = "vCEPISODIOINATIVO";
            chkavCepisodioinativo.WebTags = "";
            chkavCepisodioinativo.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCepisodioinativo_Internalname, "TitleCaption", chkavCepisodioinativo.Caption, true);
            chkavCepisodioinativo.CheckedValue = "false";
            GXCCtl = "EPISODIOINATIVO_" + sGXsfl_84_idx;
            chkEpisodioInativo.Name = GXCCtl;
            chkEpisodioInativo.WebTags = "";
            chkEpisodioInativo.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkEpisodioInativo_Internalname, "TitleCaption", chkEpisodioInativo.Caption, !bGXsfl_84_Refreshing);
            chkEpisodioInativo.CheckedValue = "false";
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
         SubsflControlProps_842( ) ;
         while ( nGXsfl_84_idx <= nRC_GXsfl_84 )
         {
            sendrow_842( ) ;
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        long AV6cEpisodioId ,
                                        long AV7cSerieId ,
                                        String AV8cEpisodioNome ,
                                        short AV9cEpisodioDuracao ,
                                        short AV12cEpisodioTemporada ,
                                        bool AV13cEpisodioInativo ,
                                        short AV14cEpisodioNumero )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF1W2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EPISODIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "EPISODIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EpisodioId), 18, 0, ".", "")));
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
         RF1W2( ) ;
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

      protected void RF1W2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 84;
         nGXsfl_84_idx = 1;
         sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
         SubsflControlProps_842( ) ;
         bGXsfl_84_Refreshing = true;
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
            SubsflControlProps_842( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID1_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cSerieId ,
                                                 AV8cEpisodioNome ,
                                                 AV9cEpisodioDuracao ,
                                                 AV12cEpisodioTemporada ,
                                                 AV13cEpisodioInativo ,
                                                 AV14cEpisodioNumero ,
                                                 A1SerieId ,
                                                 A8EpisodioNome ,
                                                 A9EpisodioDuracao ,
                                                 A42EpisodioTemporada ,
                                                 A51EpisodioInativo ,
                                                 A58EpisodioNumero ,
                                                 AV6cEpisodioId } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.LONG
                                                 }
            } ) ;
            lV8cEpisodioNome = StringUtil.Concat( StringUtil.RTrim( AV8cEpisodioNome), "%", "");
            /* Using cursor H001W2 */
            pr_default.execute(0, new Object[] {AV6cEpisodioId, AV7cSerieId, lV8cEpisodioNome, AV9cEpisodioDuracao, AV12cEpisodioTemporada, AV13cEpisodioInativo, AV14cEpisodioNumero, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A58EpisodioNumero = H001W2_A58EpisodioNumero[0];
               A51EpisodioInativo = H001W2_A51EpisodioInativo[0];
               A42EpisodioTemporada = H001W2_A42EpisodioTemporada[0];
               A9EpisodioDuracao = H001W2_A9EpisodioDuracao[0];
               A8EpisodioNome = H001W2_A8EpisodioNome[0];
               A1SerieId = H001W2_A1SerieId[0];
               A7EpisodioId = H001W2_A7EpisodioId[0];
               /* Execute user event: Load */
               E201W2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB1W0( ) ;
         }
         bGXsfl_84_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1W2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EPISODIOID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9"), context));
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
                                              AV7cSerieId ,
                                              AV8cEpisodioNome ,
                                              AV9cEpisodioDuracao ,
                                              AV12cEpisodioTemporada ,
                                              AV13cEpisodioInativo ,
                                              AV14cEpisodioNumero ,
                                              A1SerieId ,
                                              A8EpisodioNome ,
                                              A9EpisodioDuracao ,
                                              A42EpisodioTemporada ,
                                              A51EpisodioInativo ,
                                              A58EpisodioNumero ,
                                              AV6cEpisodioId } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.LONG
                                              }
         } ) ;
         lV8cEpisodioNome = StringUtil.Concat( StringUtil.RTrim( AV8cEpisodioNome), "%", "");
         /* Using cursor H001W3 */
         pr_default.execute(1, new Object[] {AV6cEpisodioId, AV7cSerieId, lV8cEpisodioNome, AV9cEpisodioDuracao, AV12cEpisodioTemporada, AV13cEpisodioInativo, AV14cEpisodioNumero});
         GRID1_nRecordCount = H001W3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEpisodioId, AV7cSerieId, AV8cEpisodioNome, AV9cEpisodioDuracao, AV12cEpisodioTemporada, AV13cEpisodioInativo, AV14cEpisodioNumero) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEpisodioId, AV7cSerieId, AV8cEpisodioNome, AV9cEpisodioDuracao, AV12cEpisodioTemporada, AV13cEpisodioInativo, AV14cEpisodioNumero) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEpisodioId, AV7cSerieId, AV8cEpisodioNome, AV9cEpisodioDuracao, AV12cEpisodioTemporada, AV13cEpisodioInativo, AV14cEpisodioNumero) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEpisodioId, AV7cSerieId, AV8cEpisodioNome, AV9cEpisodioDuracao, AV12cEpisodioTemporada, AV13cEpisodioInativo, AV14cEpisodioNumero) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEpisodioId, AV7cSerieId, AV8cEpisodioNome, AV9cEpisodioDuracao, AV12cEpisodioTemporada, AV13cEpisodioInativo, AV14cEpisodioNumero) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP1W0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E191W2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCepisodioid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCepisodioid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCEPISODIOID");
               GX_FocusControl = edtavCepisodioid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cEpisodioId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cEpisodioId), 18, 0)));
            }
            else
            {
               AV6cEpisodioId = (long)(context.localUtil.CToN( cgiGet( edtavCepisodioid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cEpisodioId), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCserieid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCserieid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSERIEID");
               GX_FocusControl = edtavCserieid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cSerieId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cSerieId), 18, 0)));
            }
            else
            {
               AV7cSerieId = (long)(context.localUtil.CToN( cgiGet( edtavCserieid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cSerieId), 18, 0)));
            }
            AV8cEpisodioNome = cgiGet( edtavCepisodionome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cEpisodioNome", AV8cEpisodioNome);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCepisodioduracao_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCepisodioduracao_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCEPISODIODURACAO");
               GX_FocusControl = edtavCepisodioduracao_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cEpisodioDuracao = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cEpisodioDuracao", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cEpisodioDuracao), 3, 0)));
            }
            else
            {
               AV9cEpisodioDuracao = (short)(context.localUtil.CToN( cgiGet( edtavCepisodioduracao_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cEpisodioDuracao", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cEpisodioDuracao), 3, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCepisodiotemporada_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCepisodiotemporada_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCEPISODIOTEMPORADA");
               GX_FocusControl = edtavCepisodiotemporada_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12cEpisodioTemporada = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cEpisodioTemporada", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cEpisodioTemporada), 4, 0)));
            }
            else
            {
               AV12cEpisodioTemporada = (short)(context.localUtil.CToN( cgiGet( edtavCepisodiotemporada_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cEpisodioTemporada", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cEpisodioTemporada), 4, 0)));
            }
            AV13cEpisodioInativo = StringUtil.StrToBool( cgiGet( chkavCepisodioinativo_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cEpisodioInativo", AV13cEpisodioInativo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCepisodionumero_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCepisodionumero_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCEPISODIONUMERO");
               GX_FocusControl = edtavCepisodionumero_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14cEpisodioNumero = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cEpisodioNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cEpisodioNumero), 3, 0)));
            }
            else
            {
               AV14cEpisodioNumero = (short)(context.localUtil.CToN( cgiGet( edtavCepisodionumero_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cEpisodioNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cEpisodioNumero), 3, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEPISODIOID"), ",", ".") != Convert.ToDecimal( AV6cEpisodioId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSERIEID"), ",", ".") != Convert.ToDecimal( AV7cSerieId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCEPISODIONOME"), AV8cEpisodioNome) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEPISODIODURACAO"), ",", ".") != Convert.ToDecimal( AV9cEpisodioDuracao )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEPISODIOTEMPORADA"), ",", ".") != Convert.ToDecimal( AV12cEpisodioTemporada )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vCEPISODIOINATIVO")) != AV13cEpisodioInativo )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEPISODIONUMERO"), ",", ".") != Convert.ToDecimal( AV14cEpisodioNumero )) )
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
         E191W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E191W2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Seleção %1", "Episódio", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV11ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E201W2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV17Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_842( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_84_Refreshing )
         {
            context.DoAjaxLoad(84, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E211W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E211W2( )
      {
         /* Enter Routine */
         AV10pEpisodioId = A7EpisodioId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pEpisodioId), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV10pEpisodioId});
         context.setWebReturnParmsMetadata(new Object[] {"AV10pEpisodioId"});
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
         AV10pEpisodioId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pEpisodioId), 18, 0)));
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
         PA1W2( ) ;
         WS1W2( ) ;
         WE1W2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019463276", true);
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
         context.AddJavascriptSource("gx0020.js", "?201892019463276", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtEpisodioId_Internalname = "EPISODIOID_"+sGXsfl_84_idx;
         edtSerieId_Internalname = "SERIEID_"+sGXsfl_84_idx;
         edtEpisodioNome_Internalname = "EPISODIONOME_"+sGXsfl_84_idx;
         edtEpisodioDuracao_Internalname = "EPISODIODURACAO_"+sGXsfl_84_idx;
         edtEpisodioTemporada_Internalname = "EPISODIOTEMPORADA_"+sGXsfl_84_idx;
         chkEpisodioInativo_Internalname = "EPISODIOINATIVO_"+sGXsfl_84_idx;
         edtEpisodioNumero_Internalname = "EPISODIONUMERO_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtEpisodioId_Internalname = "EPISODIOID_"+sGXsfl_84_fel_idx;
         edtSerieId_Internalname = "SERIEID_"+sGXsfl_84_fel_idx;
         edtEpisodioNome_Internalname = "EPISODIONOME_"+sGXsfl_84_fel_idx;
         edtEpisodioDuracao_Internalname = "EPISODIODURACAO_"+sGXsfl_84_fel_idx;
         edtEpisodioTemporada_Internalname = "EPISODIOTEMPORADA_"+sGXsfl_84_fel_idx;
         chkEpisodioInativo_Internalname = "EPISODIOINATIVO_"+sGXsfl_84_fel_idx;
         edtEpisodioNumero_Internalname = "EPISODIONUMERO_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB1W0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_84_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_84_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_84_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EpisodioId), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_84_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV17Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEpisodioId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EpisodioId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEpisodioId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSerieId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSerieId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtEpisodioNome_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EpisodioId), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEpisodioNome_Internalname, "Link", edtEpisodioNome_Link, !bGXsfl_84_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEpisodioNome_Internalname,(String)A8EpisodioNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtEpisodioNome_Link,(String)"",(String)"",(String)"",(String)edtEpisodioNome_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nome",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEpisodioDuracao_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A9EpisodioDuracao), 3, 0, ",", "")),context.localUtil.Format( (decimal)(A9EpisodioDuracao), "ZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEpisodioDuracao_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Duracao",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEpisodioTemporada_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A42EpisodioTemporada), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A42EpisodioTemporada), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEpisodioTemporada_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Temporada",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "Attribute";
            StyleString = "";
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkEpisodioInativo_Internalname,StringUtil.BoolToStr( A51EpisodioInativo),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn OptionalColumn",(String)"",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEpisodioNumero_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A58EpisodioNumero), 3, 0, ",", "")),context.localUtil.Format( (decimal)(A58EpisodioNumero), "ZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEpisodioNumero_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Numero",(String)"right",(bool)false});
            send_integrity_lvl_hashes1W2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblepisodioidfilter_Internalname = "LBLEPISODIOIDFILTER";
         edtavCepisodioid_Internalname = "vCEPISODIOID";
         divEpisodioidfiltercontainer_Internalname = "EPISODIOIDFILTERCONTAINER";
         lblLblserieidfilter_Internalname = "LBLSERIEIDFILTER";
         edtavCserieid_Internalname = "vCSERIEID";
         divSerieidfiltercontainer_Internalname = "SERIEIDFILTERCONTAINER";
         lblLblepisodionomefilter_Internalname = "LBLEPISODIONOMEFILTER";
         edtavCepisodionome_Internalname = "vCEPISODIONOME";
         divEpisodionomefiltercontainer_Internalname = "EPISODIONOMEFILTERCONTAINER";
         lblLblepisodioduracaofilter_Internalname = "LBLEPISODIODURACAOFILTER";
         edtavCepisodioduracao_Internalname = "vCEPISODIODURACAO";
         divEpisodioduracaofiltercontainer_Internalname = "EPISODIODURACAOFILTERCONTAINER";
         lblLblepisodiotemporadafilter_Internalname = "LBLEPISODIOTEMPORADAFILTER";
         edtavCepisodiotemporada_Internalname = "vCEPISODIOTEMPORADA";
         divEpisodiotemporadafiltercontainer_Internalname = "EPISODIOTEMPORADAFILTERCONTAINER";
         lblLblepisodioinativofilter_Internalname = "LBLEPISODIOINATIVOFILTER";
         chkavCepisodioinativo_Internalname = "vCEPISODIOINATIVO";
         divEpisodioinativofiltercontainer_Internalname = "EPISODIOINATIVOFILTERCONTAINER";
         lblLblepisodionumerofilter_Internalname = "LBLEPISODIONUMEROFILTER";
         edtavCepisodionumero_Internalname = "vCEPISODIONUMERO";
         divEpisodionumerofiltercontainer_Internalname = "EPISODIONUMEROFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtEpisodioId_Internalname = "EPISODIOID";
         edtSerieId_Internalname = "SERIEID";
         edtEpisodioNome_Internalname = "EPISODIONOME";
         edtEpisodioDuracao_Internalname = "EPISODIODURACAO";
         edtEpisodioTemporada_Internalname = "EPISODIOTEMPORADA";
         chkEpisodioInativo_Internalname = "EPISODIOINATIVO";
         edtEpisodioNumero_Internalname = "EPISODIONUMERO";
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
         edtEpisodioNumero_Jsonclick = "";
         edtEpisodioTemporada_Jsonclick = "";
         edtEpisodioDuracao_Jsonclick = "";
         edtEpisodioNome_Jsonclick = "";
         edtSerieId_Jsonclick = "";
         edtEpisodioId_Jsonclick = "";
         chkEpisodioInativo.Caption = "";
         chkavCepisodioinativo.Caption = "Inativo";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtEpisodioNome_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCepisodionumero_Jsonclick = "";
         edtavCepisodionumero_Enabled = 1;
         edtavCepisodionumero_Visible = 1;
         chkavCepisodioinativo.Enabled = 1;
         chkavCepisodioinativo.Visible = 1;
         edtavCepisodiotemporada_Jsonclick = "";
         edtavCepisodiotemporada_Enabled = 1;
         edtavCepisodiotemporada_Visible = 1;
         edtavCepisodioduracao_Jsonclick = "";
         edtavCepisodioduracao_Enabled = 1;
         edtavCepisodioduracao_Visible = 1;
         edtavCepisodionome_Jsonclick = "";
         edtavCepisodionome_Enabled = 1;
         edtavCepisodionome_Visible = 1;
         edtavCserieid_Jsonclick = "";
         edtavCserieid_Enabled = 1;
         edtavCserieid_Visible = 1;
         edtavCepisodioid_Jsonclick = "";
         edtavCepisodioid_Enabled = 1;
         edtavCepisodioid_Visible = 1;
         divEpisodionumerofiltercontainer_Class = "AdvancedContainerItem";
         divEpisodioinativofiltercontainer_Class = "AdvancedContainerItem";
         divEpisodiotemporadafiltercontainer_Class = "AdvancedContainerItem";
         divEpisodioduracaofiltercontainer_Class = "AdvancedContainerItem";
         divEpisodionomefiltercontainer_Class = "AdvancedContainerItem";
         divSerieidfiltercontainer_Class = "AdvancedContainerItem";
         divEpisodioidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Episódio";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cEpisodioId',fld:'vCEPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cEpisodioNome',fld:'vCEPISODIONOME',pic:'',nv:''},{av:'AV9cEpisodioDuracao',fld:'vCEPISODIODURACAO',pic:'ZZZ',nv:0},{av:'AV12cEpisodioTemporada',fld:'vCEPISODIOTEMPORADA',pic:'ZZZ9',nv:0},{av:'AV13cEpisodioInativo',fld:'vCEPISODIOINATIVO',pic:'',nv:false},{av:'AV14cEpisodioNumero',fld:'vCEPISODIONUMERO',pic:'ZZ9',nv:0}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E181W1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLEPISODIOIDFILTER.CLICK","{handler:'E111W1',iparms:[{av:'divEpisodioidfiltercontainer_Class',ctrl:'EPISODIOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEpisodioidfiltercontainer_Class',ctrl:'EPISODIOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCepisodioid_Visible',ctrl:'vCEPISODIOID',prop:'Visible'}]}");
         setEventMetadata("LBLSERIEIDFILTER.CLICK","{handler:'E121W1',iparms:[{av:'divSerieidfiltercontainer_Class',ctrl:'SERIEIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divSerieidfiltercontainer_Class',ctrl:'SERIEIDFILTERCONTAINER',prop:'Class'},{av:'edtavCserieid_Visible',ctrl:'vCSERIEID',prop:'Visible'}]}");
         setEventMetadata("LBLEPISODIONOMEFILTER.CLICK","{handler:'E131W1',iparms:[{av:'divEpisodionomefiltercontainer_Class',ctrl:'EPISODIONOMEFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEpisodionomefiltercontainer_Class',ctrl:'EPISODIONOMEFILTERCONTAINER',prop:'Class'},{av:'edtavCepisodionome_Visible',ctrl:'vCEPISODIONOME',prop:'Visible'}]}");
         setEventMetadata("LBLEPISODIODURACAOFILTER.CLICK","{handler:'E141W1',iparms:[{av:'divEpisodioduracaofiltercontainer_Class',ctrl:'EPISODIODURACAOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEpisodioduracaofiltercontainer_Class',ctrl:'EPISODIODURACAOFILTERCONTAINER',prop:'Class'},{av:'edtavCepisodioduracao_Visible',ctrl:'vCEPISODIODURACAO',prop:'Visible'}]}");
         setEventMetadata("LBLEPISODIOTEMPORADAFILTER.CLICK","{handler:'E151W1',iparms:[{av:'divEpisodiotemporadafiltercontainer_Class',ctrl:'EPISODIOTEMPORADAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEpisodiotemporadafiltercontainer_Class',ctrl:'EPISODIOTEMPORADAFILTERCONTAINER',prop:'Class'},{av:'edtavCepisodiotemporada_Visible',ctrl:'vCEPISODIOTEMPORADA',prop:'Visible'}]}");
         setEventMetadata("LBLEPISODIOINATIVOFILTER.CLICK","{handler:'E161W1',iparms:[{av:'divEpisodioinativofiltercontainer_Class',ctrl:'EPISODIOINATIVOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEpisodioinativofiltercontainer_Class',ctrl:'EPISODIOINATIVOFILTERCONTAINER',prop:'Class'},{av:'chkavCepisodioinativo.Visible',ctrl:'vCEPISODIOINATIVO',prop:'Visible'}]}");
         setEventMetadata("LBLEPISODIONUMEROFILTER.CLICK","{handler:'E171W1',iparms:[{av:'divEpisodionumerofiltercontainer_Class',ctrl:'EPISODIONUMEROFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divEpisodionumerofiltercontainer_Class',ctrl:'EPISODIONUMEROFILTERCONTAINER',prop:'Class'},{av:'edtavCepisodionumero_Visible',ctrl:'vCEPISODIONUMERO',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E211W2',iparms:[{av:'A7EpisodioId',fld:'EPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV10pEpisodioId',fld:'vPEPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cEpisodioId',fld:'vCEPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cEpisodioNome',fld:'vCEPISODIONOME',pic:'',nv:''},{av:'AV9cEpisodioDuracao',fld:'vCEPISODIODURACAO',pic:'ZZZ',nv:0},{av:'AV12cEpisodioTemporada',fld:'vCEPISODIOTEMPORADA',pic:'ZZZ9',nv:0},{av:'AV13cEpisodioInativo',fld:'vCEPISODIOINATIVO',pic:'',nv:false},{av:'AV14cEpisodioNumero',fld:'vCEPISODIONUMERO',pic:'ZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cEpisodioId',fld:'vCEPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cEpisodioNome',fld:'vCEPISODIONOME',pic:'',nv:''},{av:'AV9cEpisodioDuracao',fld:'vCEPISODIODURACAO',pic:'ZZZ',nv:0},{av:'AV12cEpisodioTemporada',fld:'vCEPISODIOTEMPORADA',pic:'ZZZ9',nv:0},{av:'AV13cEpisodioInativo',fld:'vCEPISODIOINATIVO',pic:'',nv:false},{av:'AV14cEpisodioNumero',fld:'vCEPISODIONUMERO',pic:'ZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cEpisodioId',fld:'vCEPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cEpisodioNome',fld:'vCEPISODIONOME',pic:'',nv:''},{av:'AV9cEpisodioDuracao',fld:'vCEPISODIODURACAO',pic:'ZZZ',nv:0},{av:'AV12cEpisodioTemporada',fld:'vCEPISODIOTEMPORADA',pic:'ZZZ9',nv:0},{av:'AV13cEpisodioInativo',fld:'vCEPISODIOINATIVO',pic:'',nv:false},{av:'AV14cEpisodioNumero',fld:'vCEPISODIONUMERO',pic:'ZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cEpisodioId',fld:'vCEPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cEpisodioNome',fld:'vCEPISODIONOME',pic:'',nv:''},{av:'AV9cEpisodioDuracao',fld:'vCEPISODIODURACAO',pic:'ZZZ',nv:0},{av:'AV12cEpisodioTemporada',fld:'vCEPISODIOTEMPORADA',pic:'ZZZ9',nv:0},{av:'AV13cEpisodioInativo',fld:'vCEPISODIOINATIVO',pic:'',nv:false},{av:'AV14cEpisodioNumero',fld:'vCEPISODIONUMERO',pic:'ZZ9',nv:0}],oparms:[]}");
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
         AV8cEpisodioNome = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblepisodioidfilter_Jsonclick = "";
         TempTags = "";
         lblLblserieidfilter_Jsonclick = "";
         lblLblepisodionomefilter_Jsonclick = "";
         lblLblepisodioduracaofilter_Jsonclick = "";
         lblLblepisodiotemporadafilter_Jsonclick = "";
         lblLblepisodioinativofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         lblLblepisodionumerofilter_Jsonclick = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A8EpisodioNome = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         GXCCtl = "";
         scmdbuf = "";
         lV8cEpisodioNome = "";
         H001W2_A58EpisodioNumero = new short[1] ;
         H001W2_A51EpisodioInativo = new bool[] {false} ;
         H001W2_A42EpisodioTemporada = new short[1] ;
         H001W2_A9EpisodioDuracao = new short[1] ;
         H001W2_A8EpisodioNome = new String[] {""} ;
         H001W2_A1SerieId = new long[1] ;
         H001W2_A7EpisodioId = new long[1] ;
         H001W3_AGRID1_nRecordCount = new long[1] ;
         AV11ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0020__default(),
            new Object[][] {
                new Object[] {
               H001W2_A58EpisodioNumero, H001W2_A51EpisodioInativo, H001W2_A42EpisodioTemporada, H001W2_A9EpisodioDuracao, H001W2_A8EpisodioNome, H001W2_A1SerieId, H001W2_A7EpisodioId
               }
               , new Object[] {
               H001W3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_84 ;
      private short nGXsfl_84_idx=1 ;
      private short GRID1_nEOF ;
      private short AV9cEpisodioDuracao ;
      private short AV12cEpisodioTemporada ;
      private short AV14cEpisodioNumero ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A9EpisodioDuracao ;
      private short A42EpisodioTemporada ;
      private short A58EpisodioNumero ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCepisodioid_Enabled ;
      private int edtavCepisodioid_Visible ;
      private int edtavCserieid_Enabled ;
      private int edtavCserieid_Visible ;
      private int edtavCepisodionome_Visible ;
      private int edtavCepisodionome_Enabled ;
      private int edtavCepisodioduracao_Enabled ;
      private int edtavCepisodioduracao_Visible ;
      private int edtavCepisodiotemporada_Enabled ;
      private int edtavCepisodiotemporada_Visible ;
      private int edtavCepisodionumero_Enabled ;
      private int edtavCepisodionumero_Visible ;
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
      private long AV6cEpisodioId ;
      private long AV7cSerieId ;
      private long AV10pEpisodioId ;
      private long A7EpisodioId ;
      private long A1SerieId ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divEpisodioidfiltercontainer_Class ;
      private String divSerieidfiltercontainer_Class ;
      private String divEpisodionomefiltercontainer_Class ;
      private String divEpisodioduracaofiltercontainer_Class ;
      private String divEpisodiotemporadafiltercontainer_Class ;
      private String divEpisodioinativofiltercontainer_Class ;
      private String divEpisodionumerofiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_84_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divEpisodioidfiltercontainer_Internalname ;
      private String lblLblepisodioidfilter_Internalname ;
      private String lblLblepisodioidfilter_Jsonclick ;
      private String edtavCepisodioid_Internalname ;
      private String TempTags ;
      private String edtavCepisodioid_Jsonclick ;
      private String divSerieidfiltercontainer_Internalname ;
      private String lblLblserieidfilter_Internalname ;
      private String lblLblserieidfilter_Jsonclick ;
      private String edtavCserieid_Internalname ;
      private String edtavCserieid_Jsonclick ;
      private String divEpisodionomefiltercontainer_Internalname ;
      private String lblLblepisodionomefilter_Internalname ;
      private String lblLblepisodionomefilter_Jsonclick ;
      private String edtavCepisodionome_Internalname ;
      private String edtavCepisodionome_Jsonclick ;
      private String divEpisodioduracaofiltercontainer_Internalname ;
      private String lblLblepisodioduracaofilter_Internalname ;
      private String lblLblepisodioduracaofilter_Jsonclick ;
      private String edtavCepisodioduracao_Internalname ;
      private String edtavCepisodioduracao_Jsonclick ;
      private String divEpisodiotemporadafiltercontainer_Internalname ;
      private String lblLblepisodiotemporadafilter_Internalname ;
      private String lblLblepisodiotemporadafilter_Jsonclick ;
      private String edtavCepisodiotemporada_Internalname ;
      private String edtavCepisodiotemporada_Jsonclick ;
      private String divEpisodioinativofiltercontainer_Internalname ;
      private String lblLblepisodioinativofilter_Internalname ;
      private String lblLblepisodioinativofilter_Jsonclick ;
      private String chkavCepisodioinativo_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divEpisodionumerofiltercontainer_Internalname ;
      private String lblLblepisodionumerofilter_Internalname ;
      private String lblLblepisodionumerofilter_Jsonclick ;
      private String edtavCepisodionumero_Internalname ;
      private String edtavCepisodionumero_Jsonclick ;
      private String divGridtable_Internalname ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String edtavLinkselection_Link ;
      private String edtEpisodioNome_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtEpisodioId_Internalname ;
      private String edtSerieId_Internalname ;
      private String edtEpisodioNome_Internalname ;
      private String edtEpisodioDuracao_Internalname ;
      private String edtEpisodioTemporada_Internalname ;
      private String chkEpisodioInativo_Internalname ;
      private String edtEpisodioNumero_Internalname ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String AV11ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtEpisodioId_Jsonclick ;
      private String edtSerieId_Jsonclick ;
      private String edtEpisodioNome_Jsonclick ;
      private String edtEpisodioDuracao_Jsonclick ;
      private String edtEpisodioTemporada_Jsonclick ;
      private String edtEpisodioNumero_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV13cEpisodioInativo ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool A51EpisodioInativo ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_84_Refreshing=false ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV8cEpisodioNome ;
      private String A8EpisodioNome ;
      private String AV17Linkselection_GXI ;
      private String lV8cEpisodioNome ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavCepisodioinativo ;
      private GXCheckbox chkEpisodioInativo ;
      private IDataStoreProvider pr_default ;
      private short[] H001W2_A58EpisodioNumero ;
      private bool[] H001W2_A51EpisodioInativo ;
      private short[] H001W2_A42EpisodioTemporada ;
      private short[] H001W2_A9EpisodioDuracao ;
      private String[] H001W2_A8EpisodioNome ;
      private long[] H001W2_A1SerieId ;
      private long[] H001W2_A7EpisodioId ;
      private long[] H001W3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_pEpisodioId ;
      private GXWebForm Form ;
   }

   public class gx0020__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001W2( IGxContext context ,
                                             long AV7cSerieId ,
                                             String AV8cEpisodioNome ,
                                             short AV9cEpisodioDuracao ,
                                             short AV12cEpisodioTemporada ,
                                             bool AV13cEpisodioInativo ,
                                             short AV14cEpisodioNumero ,
                                             long A1SerieId ,
                                             String A8EpisodioNome ,
                                             short A9EpisodioDuracao ,
                                             short A42EpisodioTemporada ,
                                             bool A51EpisodioInativo ,
                                             short A58EpisodioNumero ,
                                             long AV6cEpisodioId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [10] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [EpisodioNumero], [EpisodioInativo], [EpisodioTemporada], [EpisodioDuracao], [EpisodioNome], [SerieId], [EpisodioId]";
         sFromString = " FROM [Episodio] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([EpisodioId] >= @AV6cEpisodioId)";
         if ( ! (0==AV7cSerieId) )
         {
            sWhereString = sWhereString + " and ([SerieId] >= @AV7cSerieId)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cEpisodioNome)) )
         {
            sWhereString = sWhereString + " and ([EpisodioNome] like @lV8cEpisodioNome)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV9cEpisodioDuracao) )
         {
            sWhereString = sWhereString + " and ([EpisodioDuracao] >= @AV9cEpisodioDuracao)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV12cEpisodioTemporada) )
         {
            sWhereString = sWhereString + " and ([EpisodioTemporada] >= @AV12cEpisodioTemporada)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (false==AV13cEpisodioInativo) )
         {
            sWhereString = sWhereString + " and ([EpisodioInativo] >= @AV13cEpisodioInativo)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV14cEpisodioNumero) )
         {
            sWhereString = sWhereString + " and ([EpisodioNumero] >= @AV14cEpisodioNumero)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [EpisodioId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001W3( IGxContext context ,
                                             long AV7cSerieId ,
                                             String AV8cEpisodioNome ,
                                             short AV9cEpisodioDuracao ,
                                             short AV12cEpisodioTemporada ,
                                             bool AV13cEpisodioInativo ,
                                             short AV14cEpisodioNumero ,
                                             long A1SerieId ,
                                             String A8EpisodioNome ,
                                             short A9EpisodioDuracao ,
                                             short A42EpisodioTemporada ,
                                             bool A51EpisodioInativo ,
                                             short A58EpisodioNumero ,
                                             long AV6cEpisodioId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Episodio] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([EpisodioId] >= @AV6cEpisodioId)";
         if ( ! (0==AV7cSerieId) )
         {
            sWhereString = sWhereString + " and ([SerieId] >= @AV7cSerieId)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cEpisodioNome)) )
         {
            sWhereString = sWhereString + " and ([EpisodioNome] like @lV8cEpisodioNome)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV9cEpisodioDuracao) )
         {
            sWhereString = sWhereString + " and ([EpisodioDuracao] >= @AV9cEpisodioDuracao)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV12cEpisodioTemporada) )
         {
            sWhereString = sWhereString + " and ([EpisodioTemporada] >= @AV12cEpisodioTemporada)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (false==AV13cEpisodioInativo) )
         {
            sWhereString = sWhereString + " and ([EpisodioInativo] >= @AV13cEpisodioInativo)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV14cEpisodioNumero) )
         {
            sWhereString = sWhereString + " and ([EpisodioNumero] >= @AV14cEpisodioNumero)";
         }
         else
         {
            GXv_int3[6] = 1;
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
                     return conditional_H001W2(context, (long)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (bool)dynConstraints[4] , (short)dynConstraints[5] , (long)dynConstraints[6] , (String)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (bool)dynConstraints[10] , (short)dynConstraints[11] , (long)dynConstraints[12] );
               case 1 :
                     return conditional_H001W3(context, (long)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (bool)dynConstraints[4] , (short)dynConstraints[5] , (long)dynConstraints[6] , (String)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (bool)dynConstraints[10] , (short)dynConstraints[11] , (long)dynConstraints[12] );
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
          Object[] prmH001W2 ;
          prmH001W2 = new Object[] {
          new Object[] {"@AV6cEpisodioId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV7cSerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV8cEpisodioNome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV9cEpisodioDuracao",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV12cEpisodioTemporada",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13cEpisodioInativo",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV14cEpisodioNumero",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH001W3 ;
          prmH001W3 = new Object[] {
          new Object[] {"@AV6cEpisodioId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV7cSerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV8cEpisodioNome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV9cEpisodioDuracao",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV12cEpisodioTemporada",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13cEpisodioInativo",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV14cEpisodioNumero",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001W2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001W2,11,0,false,false )
             ,new CursorDef("H001W3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001W3,1,0,false,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
                ((long[]) buf[6])[0] = rslt.getLong(7) ;
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
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                return;
       }
    }

 }

}
