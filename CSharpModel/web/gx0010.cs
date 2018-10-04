/*
               File: Gx0010
        Description: Selection List Série
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:14:34.16
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
   public class gx0010 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0010( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gx0010( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_pSerieId )
      {
         this.AV10pSerieId = 0 ;
         executePrivate();
         aP0_pSerieId=this.AV10pSerieId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavCserieinativo = new GXCheckbox();
         chkSerieInativo = new GXCheckbox();
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
               AV6cSerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cSerieNome = GetNextPar( );
               AV8cSerieQuantidadeTemporadas = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12cSerieInativo = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV13cGeneroId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV14cSerieDataHoraCadastro = context.localUtil.ParseDTimeParm( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cSerieId, AV7cSerieNome, AV8cSerieQuantidadeTemporadas, AV12cSerieInativo, AV13cGeneroId, AV14cSerieDataHoraCadastro) ;
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
               AV10pSerieId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pSerieId), 18, 0)));
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
         PA1V2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1V2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892519143426", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0010.aspx") + "?" + UrlEncode("" +AV10pSerieId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cSerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSERIENOME", AV7cSerieNome);
         GxWebStd.gx_hidden_field( context, "GXH_vCSERIEQUANTIDADETEMPORADAS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cSerieQuantidadeTemporadas), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSERIEINATIVO", StringUtil.BoolToStr( AV12cSerieInativo));
         GxWebStd.gx_hidden_field( context, "GXH_vCGENEROID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13cGeneroId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSERIEDATAHORACADASTRO", context.localUtil.TToC( AV14cSerieDataHoraCadastro, 10, 8, 0, 3, "/", ":", " "));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10pSerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "SERIEIDFILTERCONTAINER_Class", StringUtil.RTrim( divSerieidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SERIENOMEFILTERCONTAINER_Class", StringUtil.RTrim( divSerienomefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SERIEQUANTIDADETEMPORADASFILTERCONTAINER_Class", StringUtil.RTrim( divSeriequantidadetemporadasfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SERIEINATIVOFILTERCONTAINER_Class", StringUtil.RTrim( divSerieinativofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "GENEROIDFILTERCONTAINER_Class", StringUtil.RTrim( divGeneroidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SERIEDATAHORACADASTROFILTERCONTAINER_Class", StringUtil.RTrim( divSeriedatahoracadastrofiltercontainer_Class));
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
            WE1V2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1V2( ) ;
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
         return formatLink("gx0010.aspx") + "?" + UrlEncode("" +AV10pSerieId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0010" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Série" ;
      }

      protected void WB1V0( )
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
            GxWebStd.gx_div_start( context, divSerieidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divSerieidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblserieidfilter_Internalname, "Id", "", "", lblLblserieidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111v1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCserieid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cSerieId), 18, 0, ",", "")), ((edtavCserieid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cSerieId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cSerieId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCserieid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCserieid_Visible, edtavCserieid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divSerienomefiltercontainer_Internalname, 1, 0, "px", 0, "px", divSerienomefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblserienomefilter_Internalname, "Nome", "", "", lblLblserienomefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121v1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCserienome_Internalname, "Nome", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCserienome_Internalname, AV7cSerieNome, StringUtil.RTrim( context.localUtil.Format( AV7cSerieNome, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCserienome_Jsonclick, 0, "Attribute", "", "", "", "", edtavCserienome_Visible, edtavCserienome_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divSeriequantidadetemporadasfiltercontainer_Internalname, 1, 0, "px", 0, "px", divSeriequantidadetemporadasfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblseriequantidadetemporadasfilter_Internalname, "Quantidade de temporadas", "", "", lblLblseriequantidadetemporadasfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131v1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCseriequantidadetemporadas_Internalname, "Quantidade de temporadas", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCseriequantidadetemporadas_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cSerieQuantidadeTemporadas), 4, 0, ",", "")), ((edtavCseriequantidadetemporadas_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cSerieQuantidadeTemporadas), "ZZZ9")) : context.localUtil.Format( (decimal)(AV8cSerieQuantidadeTemporadas), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCseriequantidadetemporadas_Jsonclick, 0, "Attribute", "", "", "", "", edtavCseriequantidadetemporadas_Visible, edtavCseriequantidadetemporadas_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divSerieinativofiltercontainer_Internalname, 1, 0, "px", 0, "px", divSerieinativofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblserieinativofilter_Internalname, "Inativo", "", "", lblLblserieinativofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141v1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCserieinativo_Internalname, "Inativo", "col-sm-3 AttributeLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCserieinativo_Internalname, StringUtil.BoolToStr( AV12cSerieInativo), "", "Inativo", chkavCserieinativo.Visible, chkavCserieinativo.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(46, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"");
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
            GxWebStd.gx_div_start( context, divGeneroidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divGeneroidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblgeneroidfilter_Internalname, "Id", "", "", lblLblgeneroidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151v1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCgeneroid_Internalname, "Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCgeneroid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13cGeneroId), 18, 0, ",", "")), ((edtavCgeneroid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13cGeneroId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV13cGeneroId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCgeneroid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCgeneroid_Visible, edtavCgeneroid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0010.htm");
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
            GxWebStd.gx_div_start( context, divSeriedatahoracadastrofiltercontainer_Internalname, 1, 0, "px", 0, "px", divSeriedatahoracadastrofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblseriedatahoracadastrofilter_Internalname, "Data e hora de cadastro", "", "", lblLblseriedatahoracadastrofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e161v1_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0010.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCseriedatahoracadastro_Internalname, "Data e hora de cadastro", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCseriedatahoracadastro_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCseriedatahoracadastro_Internalname, context.localUtil.TToC( AV14cSerieDataHoraCadastro, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV14cSerieDataHoraCadastro, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'por',false,0);"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCseriedatahoracadastro_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCseriedatahoracadastro_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0010.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e171v1_client"+"'", TempTags, "", 2, "HLP_Gx0010.htm");
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nome") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Quantidade de temporadas") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Imagem") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Inativo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A2SerieNome);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtSerieNome_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3SerieQuantidadeTemporadas), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( A43SerieImagem));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.BoolToStr( A47SerieInativo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A48GeneroId), 18, 0, ".", "")));
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0010.htm");
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

      protected void START1V2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Selection List Série", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1V0( ) ;
      }

      protected void WS1V2( )
      {
         START1V2( ) ;
         EVT1V2( ) ;
      }

      protected void EVT1V2( )
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
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_74_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A1SerieId = (long)(context.localUtil.CToN( cgiGet( edtSerieId_Internalname), ",", "."));
                              A2SerieNome = cgiGet( edtSerieNome_Internalname);
                              A3SerieQuantidadeTemporadas = (short)(context.localUtil.CToN( cgiGet( edtSerieQuantidadeTemporadas_Internalname), ",", "."));
                              A43SerieImagem = cgiGet( edtSerieImagem_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), !bGXsfl_74_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
                              A47SerieInativo = StringUtil.StrToBool( cgiGet( chkSerieInativo_Internalname));
                              A48GeneroId = (long)(context.localUtil.CToN( cgiGet( edtGeneroId_Internalname), ",", "."));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E181V2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E191V2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cserieid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSERIEID"), ",", ".") != Convert.ToDecimal( AV6cSerieId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cserienome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCSERIENOME"), AV7cSerieNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cseriequantidadetemporadas Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSERIEQUANTIDADETEMPORADAS"), ",", ".") != Convert.ToDecimal( AV8cSerieQuantidadeTemporadas )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cserieinativo Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vCSERIEINATIVO")) != AV12cSerieInativo )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cgeneroid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCGENEROID"), ",", ".") != Convert.ToDecimal( AV13cGeneroId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cseriedatahoracadastro Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCSERIEDATAHORACADASTRO"), 0) != AV14cSerieDataHoraCadastro )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E201V2 ();
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

      protected void WE1V2( )
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

      protected void PA1V2( )
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
            chkavCserieinativo.Name = "vCSERIEINATIVO";
            chkavCserieinativo.WebTags = "";
            chkavCserieinativo.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCserieinativo_Internalname, "TitleCaption", chkavCserieinativo.Caption, true);
            chkavCserieinativo.CheckedValue = "false";
            GXCCtl = "SERIEINATIVO_" + sGXsfl_74_idx;
            chkSerieInativo.Name = GXCCtl;
            chkSerieInativo.WebTags = "";
            chkSerieInativo.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkSerieInativo_Internalname, "TitleCaption", chkSerieInativo.Caption, !bGXsfl_74_Refreshing);
            chkSerieInativo.CheckedValue = "false";
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
                                        long AV6cSerieId ,
                                        String AV7cSerieNome ,
                                        short AV8cSerieQuantidadeTemporadas ,
                                        bool AV12cSerieInativo ,
                                        long AV13cGeneroId ,
                                        DateTime AV14cSerieDataHoraCadastro )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF1V2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SERIEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ".", "")));
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
         RF1V2( ) ;
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

      protected void RF1V2( )
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
                                                 AV7cSerieNome ,
                                                 AV8cSerieQuantidadeTemporadas ,
                                                 AV12cSerieInativo ,
                                                 AV13cGeneroId ,
                                                 AV14cSerieDataHoraCadastro ,
                                                 A2SerieNome ,
                                                 A3SerieQuantidadeTemporadas ,
                                                 A47SerieInativo ,
                                                 A48GeneroId ,
                                                 A60SerieDataHoraCadastro ,
                                                 AV6cSerieId } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.DATE,
                                                 TypeConstants.LONG
                                                 }
            } ) ;
            lV7cSerieNome = StringUtil.Concat( StringUtil.RTrim( AV7cSerieNome), "%", "");
            /* Using cursor H001V2 */
            pr_default.execute(0, new Object[] {AV6cSerieId, lV7cSerieNome, AV8cSerieQuantidadeTemporadas, AV12cSerieInativo, AV13cGeneroId, AV14cSerieDataHoraCadastro, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_74_idx = 1;
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A60SerieDataHoraCadastro = H001V2_A60SerieDataHoraCadastro[0];
               A48GeneroId = H001V2_A48GeneroId[0];
               A47SerieInativo = H001V2_A47SerieInativo[0];
               A40000SerieImagem_GXI = H001V2_A40000SerieImagem_GXI[0];
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), !bGXsfl_74_Refreshing);
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
               A3SerieQuantidadeTemporadas = H001V2_A3SerieQuantidadeTemporadas[0];
               A2SerieNome = H001V2_A2SerieNome[0];
               A1SerieId = H001V2_A1SerieId[0];
               A43SerieImagem = H001V2_A43SerieImagem[0];
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), !bGXsfl_74_Refreshing);
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
               /* Execute user event: Load */
               E191V2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB1V0( ) ;
         }
         bGXsfl_74_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1V2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SERIEID"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9"), context));
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
                                              AV7cSerieNome ,
                                              AV8cSerieQuantidadeTemporadas ,
                                              AV12cSerieInativo ,
                                              AV13cGeneroId ,
                                              AV14cSerieDataHoraCadastro ,
                                              A2SerieNome ,
                                              A3SerieQuantidadeTemporadas ,
                                              A47SerieInativo ,
                                              A48GeneroId ,
                                              A60SerieDataHoraCadastro ,
                                              AV6cSerieId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.DATE,
                                              TypeConstants.LONG
                                              }
         } ) ;
         lV7cSerieNome = StringUtil.Concat( StringUtil.RTrim( AV7cSerieNome), "%", "");
         /* Using cursor H001V3 */
         pr_default.execute(1, new Object[] {AV6cSerieId, lV7cSerieNome, AV8cSerieQuantidadeTemporadas, AV12cSerieInativo, AV13cGeneroId, AV14cSerieDataHoraCadastro});
         GRID1_nRecordCount = H001V3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cSerieId, AV7cSerieNome, AV8cSerieQuantidadeTemporadas, AV12cSerieInativo, AV13cGeneroId, AV14cSerieDataHoraCadastro) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cSerieId, AV7cSerieNome, AV8cSerieQuantidadeTemporadas, AV12cSerieInativo, AV13cGeneroId, AV14cSerieDataHoraCadastro) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cSerieId, AV7cSerieNome, AV8cSerieQuantidadeTemporadas, AV12cSerieInativo, AV13cGeneroId, AV14cSerieDataHoraCadastro) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cSerieId, AV7cSerieNome, AV8cSerieQuantidadeTemporadas, AV12cSerieInativo, AV13cGeneroId, AV14cSerieDataHoraCadastro) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cSerieId, AV7cSerieNome, AV8cSerieQuantidadeTemporadas, AV12cSerieInativo, AV13cGeneroId, AV14cSerieDataHoraCadastro) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP1V0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E181V2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCserieid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCserieid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSERIEID");
               GX_FocusControl = edtavCserieid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cSerieId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cSerieId), 18, 0)));
            }
            else
            {
               AV6cSerieId = (long)(context.localUtil.CToN( cgiGet( edtavCserieid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cSerieId), 18, 0)));
            }
            AV7cSerieNome = cgiGet( edtavCserienome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSerieNome", AV7cSerieNome);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCseriequantidadetemporadas_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCseriequantidadetemporadas_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSERIEQUANTIDADETEMPORADAS");
               GX_FocusControl = edtavCseriequantidadetemporadas_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cSerieQuantidadeTemporadas = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSerieQuantidadeTemporadas", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cSerieQuantidadeTemporadas), 4, 0)));
            }
            else
            {
               AV8cSerieQuantidadeTemporadas = (short)(context.localUtil.CToN( cgiGet( edtavCseriequantidadetemporadas_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSerieQuantidadeTemporadas", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cSerieQuantidadeTemporadas), 4, 0)));
            }
            AV12cSerieInativo = StringUtil.StrToBool( cgiGet( chkavCserieinativo_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cSerieInativo", AV12cSerieInativo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCgeneroid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCgeneroid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCGENEROID");
               GX_FocusControl = edtavCgeneroid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13cGeneroId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cGeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13cGeneroId), 18, 0)));
            }
            else
            {
               AV13cGeneroId = (long)(context.localUtil.CToN( cgiGet( edtavCgeneroid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cGeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13cGeneroId), 18, 0)));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavCseriedatahoracadastro_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Data e hora de cadastro"}), 1, "vCSERIEDATAHORACADASTRO");
               GX_FocusControl = edtavCseriedatahoracadastro_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14cSerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cSerieDataHoraCadastro", context.localUtil.TToC( AV14cSerieDataHoraCadastro, 8, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV14cSerieDataHoraCadastro = context.localUtil.CToT( cgiGet( edtavCseriedatahoracadastro_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cSerieDataHoraCadastro", context.localUtil.TToC( AV14cSerieDataHoraCadastro, 8, 5, 0, 3, "/", ":", " "));
            }
            /* Read saved values. */
            nRC_GXsfl_74 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSERIEID"), ",", ".") != Convert.ToDecimal( AV6cSerieId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCSERIENOME"), AV7cSerieNome) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSERIEQUANTIDADETEMPORADAS"), ",", ".") != Convert.ToDecimal( AV8cSerieQuantidadeTemporadas )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vCSERIEINATIVO")) != AV12cSerieInativo )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCGENEROID"), ",", ".") != Convert.ToDecimal( AV13cGeneroId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCSERIEDATAHORACADASTRO"), 0) != AV14cSerieDataHoraCadastro )
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
         E181V2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E181V2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Seleção %1", "Série", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV11ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E191V2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV17Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E201V2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E201V2( )
      {
         /* Enter Routine */
         AV10pSerieId = A1SerieId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pSerieId), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV10pSerieId});
         context.setWebReturnParmsMetadata(new Object[] {"AV10pSerieId"});
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
         AV10pSerieId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pSerieId), 18, 0)));
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
         PA1V2( ) ;
         WS1V2( ) ;
         WE1V2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892519143611", true);
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
         context.AddJavascriptSource("gx0010.js", "?201892519143612", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtSerieId_Internalname = "SERIEID_"+sGXsfl_74_idx;
         edtSerieNome_Internalname = "SERIENOME_"+sGXsfl_74_idx;
         edtSerieQuantidadeTemporadas_Internalname = "SERIEQUANTIDADETEMPORADAS_"+sGXsfl_74_idx;
         edtSerieImagem_Internalname = "SERIEIMAGEM_"+sGXsfl_74_idx;
         chkSerieInativo_Internalname = "SERIEINATIVO_"+sGXsfl_74_idx;
         edtGeneroId_Internalname = "GENEROID_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_fel_idx;
         edtSerieId_Internalname = "SERIEID_"+sGXsfl_74_fel_idx;
         edtSerieNome_Internalname = "SERIENOME_"+sGXsfl_74_fel_idx;
         edtSerieQuantidadeTemporadas_Internalname = "SERIEQUANTIDADETEMPORADAS_"+sGXsfl_74_fel_idx;
         edtSerieImagem_Internalname = "SERIEIMAGEM_"+sGXsfl_74_fel_idx;
         chkSerieInativo_Internalname = "SERIEINATIVO_"+sGXsfl_74_fel_idx;
         edtGeneroId_Internalname = "GENEROID_"+sGXsfl_74_fel_idx;
      }

      protected void sendrow_742( )
      {
         SubsflControlProps_742( ) ;
         WB1V0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_74_Refreshing);
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSerieId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSerieId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtSerieNome_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieNome_Internalname, "Link", edtSerieNome_Link, !bGXsfl_74_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSerieNome_Internalname,(String)A2SerieNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtSerieNome_Link,(String)"",(String)"",(String)"",(String)edtSerieNome_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nome",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSerieQuantidadeTemporadas_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3SerieQuantidadeTemporadas), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A3SerieQuantidadeTemporadas), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSerieQuantidadeTemporadas_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Quantidade",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            A43SerieImagem_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000SerieImagem_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.PathToRelativeUrl( A43SerieImagem));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtSerieImagem_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn OptionalColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)A43SerieImagem_IsBlob,(bool)true,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "Attribute";
            StyleString = "";
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkSerieInativo_Internalname,StringUtil.BoolToStr( A47SerieInativo),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn OptionalColumn",(String)"",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGeneroId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A48GeneroId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A48GeneroId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtGeneroId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            send_integrity_lvl_hashes1V2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
         }
         /* End function sendrow_742 */
      }

      protected void init_default_properties( )
      {
         lblLblserieidfilter_Internalname = "LBLSERIEIDFILTER";
         edtavCserieid_Internalname = "vCSERIEID";
         divSerieidfiltercontainer_Internalname = "SERIEIDFILTERCONTAINER";
         lblLblserienomefilter_Internalname = "LBLSERIENOMEFILTER";
         edtavCserienome_Internalname = "vCSERIENOME";
         divSerienomefiltercontainer_Internalname = "SERIENOMEFILTERCONTAINER";
         lblLblseriequantidadetemporadasfilter_Internalname = "LBLSERIEQUANTIDADETEMPORADASFILTER";
         edtavCseriequantidadetemporadas_Internalname = "vCSERIEQUANTIDADETEMPORADAS";
         divSeriequantidadetemporadasfiltercontainer_Internalname = "SERIEQUANTIDADETEMPORADASFILTERCONTAINER";
         lblLblserieinativofilter_Internalname = "LBLSERIEINATIVOFILTER";
         chkavCserieinativo_Internalname = "vCSERIEINATIVO";
         divSerieinativofiltercontainer_Internalname = "SERIEINATIVOFILTERCONTAINER";
         lblLblgeneroidfilter_Internalname = "LBLGENEROIDFILTER";
         edtavCgeneroid_Internalname = "vCGENEROID";
         divGeneroidfiltercontainer_Internalname = "GENEROIDFILTERCONTAINER";
         lblLblseriedatahoracadastrofilter_Internalname = "LBLSERIEDATAHORACADASTROFILTER";
         edtavCseriedatahoracadastro_Internalname = "vCSERIEDATAHORACADASTRO";
         divSeriedatahoracadastrofiltercontainer_Internalname = "SERIEDATAHORACADASTROFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtSerieId_Internalname = "SERIEID";
         edtSerieNome_Internalname = "SERIENOME";
         edtSerieQuantidadeTemporadas_Internalname = "SERIEQUANTIDADETEMPORADAS";
         edtSerieImagem_Internalname = "SERIEIMAGEM";
         chkSerieInativo_Internalname = "SERIEINATIVO";
         edtGeneroId_Internalname = "GENEROID";
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
         edtGeneroId_Jsonclick = "";
         edtSerieQuantidadeTemporadas_Jsonclick = "";
         edtSerieNome_Jsonclick = "";
         edtSerieId_Jsonclick = "";
         chkSerieInativo.Caption = "";
         chkavCserieinativo.Caption = "Inativo";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtSerieNome_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCseriedatahoracadastro_Jsonclick = "";
         edtavCseriedatahoracadastro_Enabled = 1;
         edtavCgeneroid_Jsonclick = "";
         edtavCgeneroid_Enabled = 1;
         edtavCgeneroid_Visible = 1;
         chkavCserieinativo.Enabled = 1;
         chkavCserieinativo.Visible = 1;
         edtavCseriequantidadetemporadas_Jsonclick = "";
         edtavCseriequantidadetemporadas_Enabled = 1;
         edtavCseriequantidadetemporadas_Visible = 1;
         edtavCserienome_Jsonclick = "";
         edtavCserienome_Enabled = 1;
         edtavCserienome_Visible = 1;
         edtavCserieid_Jsonclick = "";
         edtavCserieid_Enabled = 1;
         edtavCserieid_Visible = 1;
         divSeriedatahoracadastrofiltercontainer_Class = "AdvancedContainerItem";
         divGeneroidfiltercontainer_Class = "AdvancedContainerItem";
         divSerieinativofiltercontainer_Class = "AdvancedContainerItem";
         divSeriequantidadetemporadasfiltercontainer_Class = "AdvancedContainerItem";
         divSerienomefiltercontainer_Class = "AdvancedContainerItem";
         divSerieidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Série";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cSerieNome',fld:'vCSERIENOME',pic:'',nv:''},{av:'AV8cSerieQuantidadeTemporadas',fld:'vCSERIEQUANTIDADETEMPORADAS',pic:'ZZZ9',nv:0},{av:'AV12cSerieInativo',fld:'vCSERIEINATIVO',pic:'',nv:false},{av:'AV13cGeneroId',fld:'vCGENEROID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV14cSerieDataHoraCadastro',fld:'vCSERIEDATAHORACADASTRO',pic:'99/99/99 99:99',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E171V1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLSERIEIDFILTER.CLICK","{handler:'E111V1',iparms:[{av:'divSerieidfiltercontainer_Class',ctrl:'SERIEIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divSerieidfiltercontainer_Class',ctrl:'SERIEIDFILTERCONTAINER',prop:'Class'},{av:'edtavCserieid_Visible',ctrl:'vCSERIEID',prop:'Visible'}]}");
         setEventMetadata("LBLSERIENOMEFILTER.CLICK","{handler:'E121V1',iparms:[{av:'divSerienomefiltercontainer_Class',ctrl:'SERIENOMEFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divSerienomefiltercontainer_Class',ctrl:'SERIENOMEFILTERCONTAINER',prop:'Class'},{av:'edtavCserienome_Visible',ctrl:'vCSERIENOME',prop:'Visible'}]}");
         setEventMetadata("LBLSERIEQUANTIDADETEMPORADASFILTER.CLICK","{handler:'E131V1',iparms:[{av:'divSeriequantidadetemporadasfiltercontainer_Class',ctrl:'SERIEQUANTIDADETEMPORADASFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divSeriequantidadetemporadasfiltercontainer_Class',ctrl:'SERIEQUANTIDADETEMPORADASFILTERCONTAINER',prop:'Class'},{av:'edtavCseriequantidadetemporadas_Visible',ctrl:'vCSERIEQUANTIDADETEMPORADAS',prop:'Visible'}]}");
         setEventMetadata("LBLSERIEINATIVOFILTER.CLICK","{handler:'E141V1',iparms:[{av:'divSerieinativofiltercontainer_Class',ctrl:'SERIEINATIVOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divSerieinativofiltercontainer_Class',ctrl:'SERIEINATIVOFILTERCONTAINER',prop:'Class'},{av:'chkavCserieinativo.Visible',ctrl:'vCSERIEINATIVO',prop:'Visible'}]}");
         setEventMetadata("LBLGENEROIDFILTER.CLICK","{handler:'E151V1',iparms:[{av:'divGeneroidfiltercontainer_Class',ctrl:'GENEROIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divGeneroidfiltercontainer_Class',ctrl:'GENEROIDFILTERCONTAINER',prop:'Class'},{av:'edtavCgeneroid_Visible',ctrl:'vCGENEROID',prop:'Visible'}]}");
         setEventMetadata("LBLSERIEDATAHORACADASTROFILTER.CLICK","{handler:'E161V1',iparms:[{av:'divSeriedatahoracadastrofiltercontainer_Class',ctrl:'SERIEDATAHORACADASTROFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divSeriedatahoracadastrofiltercontainer_Class',ctrl:'SERIEDATAHORACADASTROFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("ENTER","{handler:'E201V2',iparms:[{av:'A1SerieId',fld:'SERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV10pSerieId',fld:'vPSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cSerieNome',fld:'vCSERIENOME',pic:'',nv:''},{av:'AV8cSerieQuantidadeTemporadas',fld:'vCSERIEQUANTIDADETEMPORADAS',pic:'ZZZ9',nv:0},{av:'AV12cSerieInativo',fld:'vCSERIEINATIVO',pic:'',nv:false},{av:'AV13cGeneroId',fld:'vCGENEROID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV14cSerieDataHoraCadastro',fld:'vCSERIEDATAHORACADASTRO',pic:'99/99/99 99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cSerieNome',fld:'vCSERIENOME',pic:'',nv:''},{av:'AV8cSerieQuantidadeTemporadas',fld:'vCSERIEQUANTIDADETEMPORADAS',pic:'ZZZ9',nv:0},{av:'AV12cSerieInativo',fld:'vCSERIEINATIVO',pic:'',nv:false},{av:'AV13cGeneroId',fld:'vCGENEROID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV14cSerieDataHoraCadastro',fld:'vCSERIEDATAHORACADASTRO',pic:'99/99/99 99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cSerieNome',fld:'vCSERIENOME',pic:'',nv:''},{av:'AV8cSerieQuantidadeTemporadas',fld:'vCSERIEQUANTIDADETEMPORADAS',pic:'ZZZ9',nv:0},{av:'AV12cSerieInativo',fld:'vCSERIEINATIVO',pic:'',nv:false},{av:'AV13cGeneroId',fld:'vCGENEROID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV14cSerieDataHoraCadastro',fld:'vCSERIEDATAHORACADASTRO',pic:'99/99/99 99:99',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cSerieNome',fld:'vCSERIENOME',pic:'',nv:''},{av:'AV8cSerieQuantidadeTemporadas',fld:'vCSERIEQUANTIDADETEMPORADAS',pic:'ZZZ9',nv:0},{av:'AV12cSerieInativo',fld:'vCSERIEINATIVO',pic:'',nv:false},{av:'AV13cGeneroId',fld:'vCGENEROID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV14cSerieDataHoraCadastro',fld:'vCSERIEDATAHORACADASTRO',pic:'99/99/99 99:99',nv:''}],oparms:[]}");
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
         AV7cSerieNome = "";
         AV14cSerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblserieidfilter_Jsonclick = "";
         TempTags = "";
         lblLblserienomefilter_Jsonclick = "";
         lblLblseriequantidadetemporadasfilter_Jsonclick = "";
         lblLblserieinativofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         lblLblgeneroidfilter_Jsonclick = "";
         lblLblseriedatahoracadastrofilter_Jsonclick = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A2SerieNome = "";
         A43SerieImagem = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         A40000SerieImagem_GXI = "";
         GXCCtl = "";
         scmdbuf = "";
         lV7cSerieNome = "";
         A60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         H001V2_A60SerieDataHoraCadastro = new DateTime[] {DateTime.MinValue} ;
         H001V2_A48GeneroId = new long[1] ;
         H001V2_A47SerieInativo = new bool[] {false} ;
         H001V2_A40000SerieImagem_GXI = new String[] {""} ;
         H001V2_A3SerieQuantidadeTemporadas = new short[1] ;
         H001V2_A2SerieNome = new String[] {""} ;
         H001V2_A1SerieId = new long[1] ;
         H001V2_A43SerieImagem = new String[] {""} ;
         H001V3_AGRID1_nRecordCount = new long[1] ;
         AV11ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0010__default(),
            new Object[][] {
                new Object[] {
               H001V2_A60SerieDataHoraCadastro, H001V2_A48GeneroId, H001V2_A47SerieInativo, H001V2_A40000SerieImagem_GXI, H001V2_A3SerieQuantidadeTemporadas, H001V2_A2SerieNome, H001V2_A1SerieId, H001V2_A43SerieImagem
               }
               , new Object[] {
               H001V3_AGRID1_nRecordCount
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
      private short AV8cSerieQuantidadeTemporadas ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A3SerieQuantidadeTemporadas ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCserieid_Enabled ;
      private int edtavCserieid_Visible ;
      private int edtavCserienome_Visible ;
      private int edtavCserienome_Enabled ;
      private int edtavCseriequantidadetemporadas_Enabled ;
      private int edtavCseriequantidadetemporadas_Visible ;
      private int edtavCgeneroid_Enabled ;
      private int edtavCgeneroid_Visible ;
      private int edtavCseriedatahoracadastro_Enabled ;
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
      private long AV6cSerieId ;
      private long AV13cGeneroId ;
      private long AV10pSerieId ;
      private long A1SerieId ;
      private long A48GeneroId ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divSerieidfiltercontainer_Class ;
      private String divSerienomefiltercontainer_Class ;
      private String divSeriequantidadetemporadasfiltercontainer_Class ;
      private String divSerieinativofiltercontainer_Class ;
      private String divGeneroidfiltercontainer_Class ;
      private String divSeriedatahoracadastrofiltercontainer_Class ;
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
      private String divSerieidfiltercontainer_Internalname ;
      private String lblLblserieidfilter_Internalname ;
      private String lblLblserieidfilter_Jsonclick ;
      private String edtavCserieid_Internalname ;
      private String TempTags ;
      private String edtavCserieid_Jsonclick ;
      private String divSerienomefiltercontainer_Internalname ;
      private String lblLblserienomefilter_Internalname ;
      private String lblLblserienomefilter_Jsonclick ;
      private String edtavCserienome_Internalname ;
      private String edtavCserienome_Jsonclick ;
      private String divSeriequantidadetemporadasfiltercontainer_Internalname ;
      private String lblLblseriequantidadetemporadasfilter_Internalname ;
      private String lblLblseriequantidadetemporadasfilter_Jsonclick ;
      private String edtavCseriequantidadetemporadas_Internalname ;
      private String edtavCseriequantidadetemporadas_Jsonclick ;
      private String divSerieinativofiltercontainer_Internalname ;
      private String lblLblserieinativofilter_Internalname ;
      private String lblLblserieinativofilter_Jsonclick ;
      private String chkavCserieinativo_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divGeneroidfiltercontainer_Internalname ;
      private String lblLblgeneroidfilter_Internalname ;
      private String lblLblgeneroidfilter_Jsonclick ;
      private String edtavCgeneroid_Internalname ;
      private String edtavCgeneroid_Jsonclick ;
      private String divSeriedatahoracadastrofiltercontainer_Internalname ;
      private String lblLblseriedatahoracadastrofilter_Internalname ;
      private String lblLblseriedatahoracadastrofilter_Jsonclick ;
      private String edtavCseriedatahoracadastro_Internalname ;
      private String edtavCseriedatahoracadastro_Jsonclick ;
      private String divGridtable_Internalname ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String edtavLinkselection_Link ;
      private String edtSerieNome_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtSerieId_Internalname ;
      private String edtSerieNome_Internalname ;
      private String edtSerieQuantidadeTemporadas_Internalname ;
      private String edtSerieImagem_Internalname ;
      private String chkSerieInativo_Internalname ;
      private String edtGeneroId_Internalname ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String AV11ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_74_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtSerieId_Jsonclick ;
      private String edtSerieNome_Jsonclick ;
      private String edtSerieQuantidadeTemporadas_Jsonclick ;
      private String edtGeneroId_Jsonclick ;
      private DateTime AV14cSerieDataHoraCadastro ;
      private DateTime A60SerieDataHoraCadastro ;
      private bool entryPointCalled ;
      private bool AV12cSerieInativo ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool A47SerieInativo ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_74_Refreshing=false ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private bool A43SerieImagem_IsBlob ;
      private String AV7cSerieNome ;
      private String A2SerieNome ;
      private String AV17Linkselection_GXI ;
      private String A40000SerieImagem_GXI ;
      private String lV7cSerieNome ;
      private String AV5LinkSelection ;
      private String A43SerieImagem ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavCserieinativo ;
      private GXCheckbox chkSerieInativo ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H001V2_A60SerieDataHoraCadastro ;
      private long[] H001V2_A48GeneroId ;
      private bool[] H001V2_A47SerieInativo ;
      private String[] H001V2_A40000SerieImagem_GXI ;
      private short[] H001V2_A3SerieQuantidadeTemporadas ;
      private String[] H001V2_A2SerieNome ;
      private long[] H001V2_A1SerieId ;
      private String[] H001V2_A43SerieImagem ;
      private long[] H001V3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_pSerieId ;
      private GXWebForm Form ;
   }

   public class gx0010__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001V2( IGxContext context ,
                                             String AV7cSerieNome ,
                                             short AV8cSerieQuantidadeTemporadas ,
                                             bool AV12cSerieInativo ,
                                             long AV13cGeneroId ,
                                             DateTime AV14cSerieDataHoraCadastro ,
                                             String A2SerieNome ,
                                             short A3SerieQuantidadeTemporadas ,
                                             bool A47SerieInativo ,
                                             long A48GeneroId ,
                                             DateTime A60SerieDataHoraCadastro ,
                                             long AV6cSerieId )
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
         sSelectString = " [SerieDataHoraCadastro], [GeneroId], [SerieInativo], [SerieImagem_GXI], [SerieQuantidadeTemporadas], [SerieNome], [SerieId], [SerieImagem]";
         sFromString = " FROM [Serie] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([SerieId] >= @AV6cSerieId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cSerieNome)) )
         {
            sWhereString = sWhereString + " and ([SerieNome] like @lV7cSerieNome)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV8cSerieQuantidadeTemporadas) )
         {
            sWhereString = sWhereString + " and ([SerieQuantidadeTemporadas] >= @AV8cSerieQuantidadeTemporadas)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (false==AV12cSerieInativo) )
         {
            sWhereString = sWhereString + " and ([SerieInativo] >= @AV12cSerieInativo)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV13cGeneroId) )
         {
            sWhereString = sWhereString + " and ([GeneroId] >= @AV13cGeneroId)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV14cSerieDataHoraCadastro) )
         {
            sWhereString = sWhereString + " and ([SerieDataHoraCadastro] >= @AV14cSerieDataHoraCadastro)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [SerieId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001V3( IGxContext context ,
                                             String AV7cSerieNome ,
                                             short AV8cSerieQuantidadeTemporadas ,
                                             bool AV12cSerieInativo ,
                                             long AV13cGeneroId ,
                                             DateTime AV14cSerieDataHoraCadastro ,
                                             String A2SerieNome ,
                                             short A3SerieQuantidadeTemporadas ,
                                             bool A47SerieInativo ,
                                             long A48GeneroId ,
                                             DateTime A60SerieDataHoraCadastro ,
                                             long AV6cSerieId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Serie] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([SerieId] >= @AV6cSerieId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cSerieNome)) )
         {
            sWhereString = sWhereString + " and ([SerieNome] like @lV7cSerieNome)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV8cSerieQuantidadeTemporadas) )
         {
            sWhereString = sWhereString + " and ([SerieQuantidadeTemporadas] >= @AV8cSerieQuantidadeTemporadas)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (false==AV12cSerieInativo) )
         {
            sWhereString = sWhereString + " and ([SerieInativo] >= @AV12cSerieInativo)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV13cGeneroId) )
         {
            sWhereString = sWhereString + " and ([GeneroId] >= @AV13cGeneroId)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV14cSerieDataHoraCadastro) )
         {
            sWhereString = sWhereString + " and ([SerieDataHoraCadastro] >= @AV14cSerieDataHoraCadastro)";
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
                     return conditional_H001V2(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (bool)dynConstraints[2] , (long)dynConstraints[3] , (DateTime)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (bool)dynConstraints[7] , (long)dynConstraints[8] , (DateTime)dynConstraints[9] , (long)dynConstraints[10] );
               case 1 :
                     return conditional_H001V3(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (bool)dynConstraints[2] , (long)dynConstraints[3] , (DateTime)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (bool)dynConstraints[7] , (long)dynConstraints[8] , (DateTime)dynConstraints[9] , (long)dynConstraints[10] );
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
          Object[] prmH001V2 ;
          prmH001V2 = new Object[] {
          new Object[] {"@AV6cSerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV7cSerieNome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV8cSerieQuantidadeTemporadas",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12cSerieInativo",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV13cGeneroId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV14cSerieDataHoraCadastro",SqlDbType.DateTime,8,5} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH001V3 ;
          prmH001V3 = new Object[] {
          new Object[] {"@AV6cSerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV7cSerieNome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV8cSerieQuantidadeTemporadas",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12cSerieInativo",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV13cGeneroId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV14cSerieDataHoraCadastro",SqlDbType.DateTime,8,5}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001V2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001V2,11,0,false,false )
             ,new CursorDef("H001V3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001V3,1,0,false,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((bool[]) buf[2])[0] = rslt.getBool(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((long[]) buf[6])[0] = rslt.getLong(7) ;
                ((String[]) buf[7])[0] = rslt.getMultimediaFile(8, rslt.getVarchar(4)) ;
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
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[14]);
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
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[11]);
                }
                return;
       }
    }

 }

}
