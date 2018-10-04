/*
               File: Gx0090
        Description: Selection List Usuário recomendação série
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:38.0
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
   public class gx0090 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0090( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gx0090( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_pUsuarioRecomendacaoSerieId )
      {
         this.AV11pUsuarioRecomendacaoSerieId = 0 ;
         executePrivate();
         aP0_pUsuarioRecomendacaoSerieId=this.AV11pUsuarioRecomendacaoSerieId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
               AV6cUsuarioRecomendacaoSerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cUsuarioRecomendacaoSerieOrigemId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cUsuarioRecomendacaoSerieDestinoId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV9cUsuarioRecomendacaoSerieDataHora = context.localUtil.ParseDTimeParm( GetNextPar( ));
               AV10cSerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioRecomendacaoSerieId, AV7cUsuarioRecomendacaoSerieOrigemId, AV8cUsuarioRecomendacaoSerieDestinoId, AV9cUsuarioRecomendacaoSerieDataHora, AV10cSerieId) ;
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
               AV11pUsuarioRecomendacaoSerieId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pUsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pUsuarioRecomendacaoSerieId), 18, 0)));
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
         PA232( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START232( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20189201946386", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0090.aspx") + "?" + UrlEncode("" +AV11pUsuarioRecomendacaoSerieId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIORECOMENDACAOSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cUsuarioRecomendacaoSerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIORECOMENDACAOSERIEORIGEMID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cUsuarioRecomendacaoSerieOrigemId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIORECOMENDACAOSERIEDESTINOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cUsuarioRecomendacaoSerieDestinoId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIORECOMENDACAOSERIEDATAHORA", context.localUtil.TToC( AV9cUsuarioRecomendacaoSerieDataHora, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vCSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cSerieId), 18, 0, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_64", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_64), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPUSUARIORECOMENDACAOSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pUsuarioRecomendacaoSerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "USUARIORECOMENDACAOSERIEIDFILTERCONTAINER_Class", StringUtil.RTrim( divUsuariorecomendacaoserieidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIORECOMENDACAOSERIEORIGEMIDFILTERCONTAINER_Class", StringUtil.RTrim( divUsuariorecomendacaoserieorigemidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIORECOMENDACAOSERIEDESTINOIDFILTERCONTAINER_Class", StringUtil.RTrim( divUsuariorecomendacaoseriedestinoidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIORECOMENDACAOSERIEDATAHORAFILTERCONTAINER_Class", StringUtil.RTrim( divUsuariorecomendacaoseriedatahorafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SERIEIDFILTERCONTAINER_Class", StringUtil.RTrim( divSerieidfiltercontainer_Class));
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
            WE232( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT232( ) ;
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
         return formatLink("gx0090.aspx") + "?" + UrlEncode("" +AV11pUsuarioRecomendacaoSerieId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0090" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Usuário recomendação série" ;
      }

      protected void WB230( )
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
            GxWebStd.gx_div_start( context, divUsuariorecomendacaoserieidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuariorecomendacaoserieidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuariorecomendacaoserieidfilter_Internalname, "Id", "", "", lblLblusuariorecomendacaoserieidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11231_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusuariorecomendacaoserieid_Internalname, "Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusuariorecomendacaoserieid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cUsuarioRecomendacaoSerieId), 18, 0, ",", "")), ((edtavCusuariorecomendacaoserieid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cUsuarioRecomendacaoSerieId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cUsuarioRecomendacaoSerieId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuariorecomendacaoserieid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusuariorecomendacaoserieid_Visible, edtavCusuariorecomendacaoserieid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0090.htm");
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
            GxWebStd.gx_div_start( context, divUsuariorecomendacaoserieorigemidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuariorecomendacaoserieorigemidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuariorecomendacaoserieorigemidfilter_Internalname, "Id", "", "", lblLblusuariorecomendacaoserieorigemidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12231_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusuariorecomendacaoserieorigemid_Internalname, "Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusuariorecomendacaoserieorigemid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cUsuarioRecomendacaoSerieOrigemId), 18, 0, ",", "")), ((edtavCusuariorecomendacaoserieorigemid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cUsuarioRecomendacaoSerieOrigemId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7cUsuarioRecomendacaoSerieOrigemId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuariorecomendacaoserieorigemid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusuariorecomendacaoserieorigemid_Visible, edtavCusuariorecomendacaoserieorigemid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0090.htm");
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
            GxWebStd.gx_div_start( context, divUsuariorecomendacaoseriedestinoidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuariorecomendacaoseriedestinoidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuariorecomendacaoseriedestinoidfilter_Internalname, "Id", "", "", lblLblusuariorecomendacaoseriedestinoidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13231_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusuariorecomendacaoseriedestinoid_Internalname, "Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusuariorecomendacaoseriedestinoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cUsuarioRecomendacaoSerieDestinoId), 18, 0, ",", "")), ((edtavCusuariorecomendacaoseriedestinoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cUsuarioRecomendacaoSerieDestinoId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8cUsuarioRecomendacaoSerieDestinoId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuariorecomendacaoseriedestinoid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusuariorecomendacaoseriedestinoid_Visible, edtavCusuariorecomendacaoseriedestinoid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0090.htm");
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
            GxWebStd.gx_div_start( context, divUsuariorecomendacaoseriedatahorafiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuariorecomendacaoseriedatahorafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuariorecomendacaoseriedatahorafilter_Internalname, "Data e hora da recomendação", "", "", lblLblusuariorecomendacaoseriedatahorafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14231_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusuariorecomendacaoseriedatahora_Internalname, "Data e hora da recomendação", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_64_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCusuariorecomendacaoseriedatahora_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCusuariorecomendacaoseriedatahora_Internalname, context.localUtil.TToC( AV9cUsuarioRecomendacaoSerieDataHora, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( AV9cUsuarioRecomendacaoSerieDataHora, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'por',false,0);"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuariorecomendacaoseriedatahora_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCusuariorecomendacaoseriedatahora_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0090.htm");
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
            GxWebStd.gx_div_start( context, divSerieidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divSerieidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblserieidfilter_Internalname, "Id", "", "", lblLblserieidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15231_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCserieid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cSerieId), 18, 0, ",", "")), ((edtavCserieid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cSerieId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV10cSerieId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCserieid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCserieid_Visible, edtavCserieid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0090.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(64), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e16231_client"+"'", TempTags, "", 2, "HLP_Gx0090.htm");
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "da recomendação") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33UsuarioRecomendacaoSerieOrigem), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34UsuarioRecomendacaoSerieDestin), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.TToC( A36UsuarioRecomendacaoSerieDataHo, 10, 8, 0, 3, "/", ":", " "));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ".", "")));
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(64), 2, 0)+","+"null"+");", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0090.htm");
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

      protected void START232( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Selection List Usuário recomendação série", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP230( ) ;
      }

      protected void WS232( )
      {
         START232( ) ;
         EVT232( ) ;
      }

      protected void EVT232( )
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
                              A32UsuarioRecomendacaoSerieId = (long)(context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoSerieId_Internalname), ",", "."));
                              A33UsuarioRecomendacaoSerieOrigem = (long)(context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoSerieOrigem_Internalname), ",", "."));
                              A34UsuarioRecomendacaoSerieDestin = (long)(context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoSerieDestin_Internalname), ",", "."));
                              A36UsuarioRecomendacaoSerieDataHo = context.localUtil.CToT( cgiGet( edtUsuarioRecomendacaoSerieDataHo_Internalname), 0);
                              A1SerieId = (long)(context.localUtil.CToN( cgiGet( edtSerieId_Internalname), ",", "."));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E17232 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E18232 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cusuariorecomendacaoserieid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIORECOMENDACAOSERIEID"), ",", ".") != Convert.ToDecimal( AV6cUsuarioRecomendacaoSerieId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuariorecomendacaoserieorigemid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIORECOMENDACAOSERIEORIGEMID"), ",", ".") != Convert.ToDecimal( AV7cUsuarioRecomendacaoSerieOrigemId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuariorecomendacaoseriedestinoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIORECOMENDACAOSERIEDESTINOID"), ",", ".") != Convert.ToDecimal( AV8cUsuarioRecomendacaoSerieDestinoId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuariorecomendacaoseriedatahora Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCUSUARIORECOMENDACAOSERIEDATAHORA"), 0) != AV9cUsuarioRecomendacaoSerieDataHora )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cserieid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSERIEID"), ",", ".") != Convert.ToDecimal( AV10cSerieId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E19232 ();
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

      protected void WE232( )
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

      protected void PA232( )
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
                                        long AV6cUsuarioRecomendacaoSerieId ,
                                        long AV7cUsuarioRecomendacaoSerieOrigemId ,
                                        long AV8cUsuarioRecomendacaoSerieDestinoId ,
                                        DateTime AV9cUsuarioRecomendacaoSerieDataHora ,
                                        long AV10cSerieId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF232( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_USUARIORECOMENDACAOSERIEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A32UsuarioRecomendacaoSerieId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "USUARIORECOMENDACAOSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0, ".", "")));
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
         RF232( ) ;
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

      protected void RF232( )
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
                                                 AV7cUsuarioRecomendacaoSerieOrigemId ,
                                                 AV8cUsuarioRecomendacaoSerieDestinoId ,
                                                 AV9cUsuarioRecomendacaoSerieDataHora ,
                                                 AV10cSerieId ,
                                                 A33UsuarioRecomendacaoSerieOrigem ,
                                                 A34UsuarioRecomendacaoSerieDestin ,
                                                 A36UsuarioRecomendacaoSerieDataHo ,
                                                 A1SerieId ,
                                                 AV6cUsuarioRecomendacaoSerieId } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.LONG, TypeConstants.LONG
                                                 }
            } ) ;
            /* Using cursor H00232 */
            pr_default.execute(0, new Object[] {AV6cUsuarioRecomendacaoSerieId, AV7cUsuarioRecomendacaoSerieOrigemId, AV8cUsuarioRecomendacaoSerieDestinoId, AV9cUsuarioRecomendacaoSerieDataHora, AV10cSerieId, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_64_idx = 1;
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
            SubsflControlProps_642( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A1SerieId = H00232_A1SerieId[0];
               A36UsuarioRecomendacaoSerieDataHo = H00232_A36UsuarioRecomendacaoSerieDataHo[0];
               A34UsuarioRecomendacaoSerieDestin = H00232_A34UsuarioRecomendacaoSerieDestin[0];
               A33UsuarioRecomendacaoSerieOrigem = H00232_A33UsuarioRecomendacaoSerieOrigem[0];
               A32UsuarioRecomendacaoSerieId = H00232_A32UsuarioRecomendacaoSerieId[0];
               /* Execute user event: Load */
               E18232 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 64;
            WB230( ) ;
         }
         bGXsfl_64_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes232( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_USUARIORECOMENDACAOSERIEID"+"_"+sGXsfl_64_idx, GetSecureSignedToken( sGXsfl_64_idx, context.localUtil.Format( (decimal)(A32UsuarioRecomendacaoSerieId), "ZZZZZZZZZZZZZZZZZ9"), context));
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
                                              AV7cUsuarioRecomendacaoSerieOrigemId ,
                                              AV8cUsuarioRecomendacaoSerieDestinoId ,
                                              AV9cUsuarioRecomendacaoSerieDataHora ,
                                              AV10cSerieId ,
                                              A33UsuarioRecomendacaoSerieOrigem ,
                                              A34UsuarioRecomendacaoSerieDestin ,
                                              A36UsuarioRecomendacaoSerieDataHo ,
                                              A1SerieId ,
                                              AV6cUsuarioRecomendacaoSerieId } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.LONG, TypeConstants.LONG
                                              }
         } ) ;
         /* Using cursor H00233 */
         pr_default.execute(1, new Object[] {AV6cUsuarioRecomendacaoSerieId, AV7cUsuarioRecomendacaoSerieOrigemId, AV8cUsuarioRecomendacaoSerieDestinoId, AV9cUsuarioRecomendacaoSerieDataHora, AV10cSerieId});
         GRID1_nRecordCount = H00233_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioRecomendacaoSerieId, AV7cUsuarioRecomendacaoSerieOrigemId, AV8cUsuarioRecomendacaoSerieDestinoId, AV9cUsuarioRecomendacaoSerieDataHora, AV10cSerieId) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioRecomendacaoSerieId, AV7cUsuarioRecomendacaoSerieOrigemId, AV8cUsuarioRecomendacaoSerieDestinoId, AV9cUsuarioRecomendacaoSerieDataHora, AV10cSerieId) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioRecomendacaoSerieId, AV7cUsuarioRecomendacaoSerieOrigemId, AV8cUsuarioRecomendacaoSerieDestinoId, AV9cUsuarioRecomendacaoSerieDataHora, AV10cSerieId) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioRecomendacaoSerieId, AV7cUsuarioRecomendacaoSerieOrigemId, AV8cUsuarioRecomendacaoSerieDestinoId, AV9cUsuarioRecomendacaoSerieDataHora, AV10cSerieId) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioRecomendacaoSerieId, AV7cUsuarioRecomendacaoSerieOrigemId, AV8cUsuarioRecomendacaoSerieDestinoId, AV9cUsuarioRecomendacaoSerieDataHora, AV10cSerieId) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP230( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E17232 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCusuariorecomendacaoserieid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCusuariorecomendacaoserieid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCUSUARIORECOMENDACAOSERIEID");
               GX_FocusControl = edtavCusuariorecomendacaoserieid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cUsuarioRecomendacaoSerieId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cUsuarioRecomendacaoSerieId), 18, 0)));
            }
            else
            {
               AV6cUsuarioRecomendacaoSerieId = (long)(context.localUtil.CToN( cgiGet( edtavCusuariorecomendacaoserieid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cUsuarioRecomendacaoSerieId), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCusuariorecomendacaoserieorigemid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCusuariorecomendacaoserieorigemid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCUSUARIORECOMENDACAOSERIEORIGEMID");
               GX_FocusControl = edtavCusuariorecomendacaoserieorigemid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cUsuarioRecomendacaoSerieOrigemId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cUsuarioRecomendacaoSerieOrigemId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cUsuarioRecomendacaoSerieOrigemId), 18, 0)));
            }
            else
            {
               AV7cUsuarioRecomendacaoSerieOrigemId = (long)(context.localUtil.CToN( cgiGet( edtavCusuariorecomendacaoserieorigemid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cUsuarioRecomendacaoSerieOrigemId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cUsuarioRecomendacaoSerieOrigemId), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCusuariorecomendacaoseriedestinoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCusuariorecomendacaoseriedestinoid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCUSUARIORECOMENDACAOSERIEDESTINOID");
               GX_FocusControl = edtavCusuariorecomendacaoseriedestinoid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cUsuarioRecomendacaoSerieDestinoId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cUsuarioRecomendacaoSerieDestinoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cUsuarioRecomendacaoSerieDestinoId), 18, 0)));
            }
            else
            {
               AV8cUsuarioRecomendacaoSerieDestinoId = (long)(context.localUtil.CToN( cgiGet( edtavCusuariorecomendacaoseriedestinoid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cUsuarioRecomendacaoSerieDestinoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cUsuarioRecomendacaoSerieDestinoId), 18, 0)));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavCusuariorecomendacaoseriedatahora_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Data e hora da recomendação"}), 1, "vCUSUARIORECOMENDACAOSERIEDATAHORA");
               GX_FocusControl = edtavCusuariorecomendacaoseriedatahora_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cUsuarioRecomendacaoSerieDataHora = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cUsuarioRecomendacaoSerieDataHora", context.localUtil.TToC( AV9cUsuarioRecomendacaoSerieDataHora, 8, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV9cUsuarioRecomendacaoSerieDataHora = context.localUtil.CToT( cgiGet( edtavCusuariorecomendacaoseriedatahora_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cUsuarioRecomendacaoSerieDataHora", context.localUtil.TToC( AV9cUsuarioRecomendacaoSerieDataHora, 8, 5, 0, 3, "/", ":", " "));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCserieid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCserieid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSERIEID");
               GX_FocusControl = edtavCserieid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cSerieId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cSerieId), 18, 0)));
            }
            else
            {
               AV10cSerieId = (long)(context.localUtil.CToN( cgiGet( edtavCserieid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cSerieId), 18, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_64 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_64"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIORECOMENDACAOSERIEID"), ",", ".") != Convert.ToDecimal( AV6cUsuarioRecomendacaoSerieId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIORECOMENDACAOSERIEORIGEMID"), ",", ".") != Convert.ToDecimal( AV7cUsuarioRecomendacaoSerieOrigemId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIORECOMENDACAOSERIEDESTINOID"), ",", ".") != Convert.ToDecimal( AV8cUsuarioRecomendacaoSerieDestinoId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vCUSUARIORECOMENDACAOSERIEDATAHORA"), 0) != AV9cUsuarioRecomendacaoSerieDataHora )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSERIEID"), ",", ".") != Convert.ToDecimal( AV10cSerieId )) )
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
         E17232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E17232( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Seleção %1", "Usuário recomendação série", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV12ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E18232( )
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
         E19232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19232( )
      {
         /* Enter Routine */
         AV11pUsuarioRecomendacaoSerieId = A32UsuarioRecomendacaoSerieId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pUsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pUsuarioRecomendacaoSerieId), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV11pUsuarioRecomendacaoSerieId});
         context.setWebReturnParmsMetadata(new Object[] {"AV11pUsuarioRecomendacaoSerieId"});
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
         AV11pUsuarioRecomendacaoSerieId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pUsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pUsuarioRecomendacaoSerieId), 18, 0)));
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
         PA232( ) ;
         WS232( ) ;
         WE232( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019463929", true);
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
         context.AddJavascriptSource("gx0090.js", "?201892019463930", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_642( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_idx;
         edtUsuarioRecomendacaoSerieId_Internalname = "USUARIORECOMENDACAOSERIEID_"+sGXsfl_64_idx;
         edtUsuarioRecomendacaoSerieOrigem_Internalname = "USUARIORECOMENDACAOSERIEORIGEM_"+sGXsfl_64_idx;
         edtUsuarioRecomendacaoSerieDestin_Internalname = "USUARIORECOMENDACAOSERIEDESTIN_"+sGXsfl_64_idx;
         edtUsuarioRecomendacaoSerieDataHo_Internalname = "USUARIORECOMENDACAOSERIEDATAHO_"+sGXsfl_64_idx;
         edtSerieId_Internalname = "SERIEID_"+sGXsfl_64_idx;
      }

      protected void SubsflControlProps_fel_642( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_fel_idx;
         edtUsuarioRecomendacaoSerieId_Internalname = "USUARIORECOMENDACAOSERIEID_"+sGXsfl_64_fel_idx;
         edtUsuarioRecomendacaoSerieOrigem_Internalname = "USUARIORECOMENDACAOSERIEORIGEM_"+sGXsfl_64_fel_idx;
         edtUsuarioRecomendacaoSerieDestin_Internalname = "USUARIORECOMENDACAOSERIEDESTIN_"+sGXsfl_64_fel_idx;
         edtUsuarioRecomendacaoSerieDataHo_Internalname = "USUARIORECOMENDACAOSERIEDATAHO_"+sGXsfl_64_fel_idx;
         edtSerieId_Internalname = "SERIEID_"+sGXsfl_64_fel_idx;
      }

      protected void sendrow_642( )
      {
         SubsflControlProps_642( ) ;
         WB230( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0, ",", "")))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioRecomendacaoSerieId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A32UsuarioRecomendacaoSerieId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioRecomendacaoSerieId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioRecomendacaoSerieOrigem_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A33UsuarioRecomendacaoSerieOrigem), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A33UsuarioRecomendacaoSerieOrigem), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioRecomendacaoSerieOrigem_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioRecomendacaoSerieDestin_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A34UsuarioRecomendacaoSerieDestin), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A34UsuarioRecomendacaoSerieDestin), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioRecomendacaoSerieDestin_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioRecomendacaoSerieDataHo_Internalname,context.localUtil.TToC( A36UsuarioRecomendacaoSerieDataHo, 10, 8, 0, 3, "/", ":", " "),context.localUtil.Format( A36UsuarioRecomendacaoSerieDataHo, "99/99/99 99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioRecomendacaoSerieDataHo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)14,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"DataHora",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSerieId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSerieId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            send_integrity_lvl_hashes232( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_64_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_64_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_64_idx+1));
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
            SubsflControlProps_642( ) ;
         }
         /* End function sendrow_642 */
      }

      protected void init_default_properties( )
      {
         lblLblusuariorecomendacaoserieidfilter_Internalname = "LBLUSUARIORECOMENDACAOSERIEIDFILTER";
         edtavCusuariorecomendacaoserieid_Internalname = "vCUSUARIORECOMENDACAOSERIEID";
         divUsuariorecomendacaoserieidfiltercontainer_Internalname = "USUARIORECOMENDACAOSERIEIDFILTERCONTAINER";
         lblLblusuariorecomendacaoserieorigemidfilter_Internalname = "LBLUSUARIORECOMENDACAOSERIEORIGEMIDFILTER";
         edtavCusuariorecomendacaoserieorigemid_Internalname = "vCUSUARIORECOMENDACAOSERIEORIGEMID";
         divUsuariorecomendacaoserieorigemidfiltercontainer_Internalname = "USUARIORECOMENDACAOSERIEORIGEMIDFILTERCONTAINER";
         lblLblusuariorecomendacaoseriedestinoidfilter_Internalname = "LBLUSUARIORECOMENDACAOSERIEDESTINOIDFILTER";
         edtavCusuariorecomendacaoseriedestinoid_Internalname = "vCUSUARIORECOMENDACAOSERIEDESTINOID";
         divUsuariorecomendacaoseriedestinoidfiltercontainer_Internalname = "USUARIORECOMENDACAOSERIEDESTINOIDFILTERCONTAINER";
         lblLblusuariorecomendacaoseriedatahorafilter_Internalname = "LBLUSUARIORECOMENDACAOSERIEDATAHORAFILTER";
         edtavCusuariorecomendacaoseriedatahora_Internalname = "vCUSUARIORECOMENDACAOSERIEDATAHORA";
         divUsuariorecomendacaoseriedatahorafiltercontainer_Internalname = "USUARIORECOMENDACAOSERIEDATAHORAFILTERCONTAINER";
         lblLblserieidfilter_Internalname = "LBLSERIEIDFILTER";
         edtavCserieid_Internalname = "vCSERIEID";
         divSerieidfiltercontainer_Internalname = "SERIEIDFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtUsuarioRecomendacaoSerieId_Internalname = "USUARIORECOMENDACAOSERIEID";
         edtUsuarioRecomendacaoSerieOrigem_Internalname = "USUARIORECOMENDACAOSERIEORIGEM";
         edtUsuarioRecomendacaoSerieDestin_Internalname = "USUARIORECOMENDACAOSERIEDESTIN";
         edtUsuarioRecomendacaoSerieDataHo_Internalname = "USUARIORECOMENDACAOSERIEDATAHO";
         edtSerieId_Internalname = "SERIEID";
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
         edtSerieId_Jsonclick = "";
         edtUsuarioRecomendacaoSerieDataHo_Jsonclick = "";
         edtUsuarioRecomendacaoSerieDestin_Jsonclick = "";
         edtUsuarioRecomendacaoSerieOrigem_Jsonclick = "";
         edtUsuarioRecomendacaoSerieId_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCserieid_Jsonclick = "";
         edtavCserieid_Enabled = 1;
         edtavCserieid_Visible = 1;
         edtavCusuariorecomendacaoseriedatahora_Jsonclick = "";
         edtavCusuariorecomendacaoseriedatahora_Enabled = 1;
         edtavCusuariorecomendacaoseriedestinoid_Jsonclick = "";
         edtavCusuariorecomendacaoseriedestinoid_Enabled = 1;
         edtavCusuariorecomendacaoseriedestinoid_Visible = 1;
         edtavCusuariorecomendacaoserieorigemid_Jsonclick = "";
         edtavCusuariorecomendacaoserieorigemid_Enabled = 1;
         edtavCusuariorecomendacaoserieorigemid_Visible = 1;
         edtavCusuariorecomendacaoserieid_Jsonclick = "";
         edtavCusuariorecomendacaoserieid_Enabled = 1;
         edtavCusuariorecomendacaoserieid_Visible = 1;
         divSerieidfiltercontainer_Class = "AdvancedContainerItem";
         divUsuariorecomendacaoseriedatahorafiltercontainer_Class = "AdvancedContainerItem";
         divUsuariorecomendacaoseriedestinoidfiltercontainer_Class = "AdvancedContainerItem";
         divUsuariorecomendacaoserieorigemidfiltercontainer_Class = "AdvancedContainerItem";
         divUsuariorecomendacaoserieidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Usuário recomendação série";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioRecomendacaoSerieId',fld:'vCUSUARIORECOMENDACAOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioRecomendacaoSerieOrigemId',fld:'vCUSUARIORECOMENDACAOSERIEORIGEMID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cUsuarioRecomendacaoSerieDestinoId',fld:'vCUSUARIORECOMENDACAOSERIEDESTINOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cUsuarioRecomendacaoSerieDataHora',fld:'vCUSUARIORECOMENDACAOSERIEDATAHORA',pic:'99/99/99 99:99',nv:''},{av:'AV10cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E16231',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLUSUARIORECOMENDACAOSERIEIDFILTER.CLICK","{handler:'E11231',iparms:[{av:'divUsuariorecomendacaoserieidfiltercontainer_Class',ctrl:'USUARIORECOMENDACAOSERIEIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuariorecomendacaoserieidfiltercontainer_Class',ctrl:'USUARIORECOMENDACAOSERIEIDFILTERCONTAINER',prop:'Class'},{av:'edtavCusuariorecomendacaoserieid_Visible',ctrl:'vCUSUARIORECOMENDACAOSERIEID',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIORECOMENDACAOSERIEORIGEMIDFILTER.CLICK","{handler:'E12231',iparms:[{av:'divUsuariorecomendacaoserieorigemidfiltercontainer_Class',ctrl:'USUARIORECOMENDACAOSERIEORIGEMIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuariorecomendacaoserieorigemidfiltercontainer_Class',ctrl:'USUARIORECOMENDACAOSERIEORIGEMIDFILTERCONTAINER',prop:'Class'},{av:'edtavCusuariorecomendacaoserieorigemid_Visible',ctrl:'vCUSUARIORECOMENDACAOSERIEORIGEMID',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIORECOMENDACAOSERIEDESTINOIDFILTER.CLICK","{handler:'E13231',iparms:[{av:'divUsuariorecomendacaoseriedestinoidfiltercontainer_Class',ctrl:'USUARIORECOMENDACAOSERIEDESTINOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuariorecomendacaoseriedestinoidfiltercontainer_Class',ctrl:'USUARIORECOMENDACAOSERIEDESTINOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCusuariorecomendacaoseriedestinoid_Visible',ctrl:'vCUSUARIORECOMENDACAOSERIEDESTINOID',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIORECOMENDACAOSERIEDATAHORAFILTER.CLICK","{handler:'E14231',iparms:[{av:'divUsuariorecomendacaoseriedatahorafiltercontainer_Class',ctrl:'USUARIORECOMENDACAOSERIEDATAHORAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuariorecomendacaoseriedatahorafiltercontainer_Class',ctrl:'USUARIORECOMENDACAOSERIEDATAHORAFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLSERIEIDFILTER.CLICK","{handler:'E15231',iparms:[{av:'divSerieidfiltercontainer_Class',ctrl:'SERIEIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divSerieidfiltercontainer_Class',ctrl:'SERIEIDFILTERCONTAINER',prop:'Class'},{av:'edtavCserieid_Visible',ctrl:'vCSERIEID',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E19232',iparms:[{av:'A32UsuarioRecomendacaoSerieId',fld:'USUARIORECOMENDACAOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV11pUsuarioRecomendacaoSerieId',fld:'vPUSUARIORECOMENDACAOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioRecomendacaoSerieId',fld:'vCUSUARIORECOMENDACAOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioRecomendacaoSerieOrigemId',fld:'vCUSUARIORECOMENDACAOSERIEORIGEMID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cUsuarioRecomendacaoSerieDestinoId',fld:'vCUSUARIORECOMENDACAOSERIEDESTINOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cUsuarioRecomendacaoSerieDataHora',fld:'vCUSUARIORECOMENDACAOSERIEDATAHORA',pic:'99/99/99 99:99',nv:''},{av:'AV10cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioRecomendacaoSerieId',fld:'vCUSUARIORECOMENDACAOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioRecomendacaoSerieOrigemId',fld:'vCUSUARIORECOMENDACAOSERIEORIGEMID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cUsuarioRecomendacaoSerieDestinoId',fld:'vCUSUARIORECOMENDACAOSERIEDESTINOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cUsuarioRecomendacaoSerieDataHora',fld:'vCUSUARIORECOMENDACAOSERIEDATAHORA',pic:'99/99/99 99:99',nv:''},{av:'AV10cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioRecomendacaoSerieId',fld:'vCUSUARIORECOMENDACAOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioRecomendacaoSerieOrigemId',fld:'vCUSUARIORECOMENDACAOSERIEORIGEMID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cUsuarioRecomendacaoSerieDestinoId',fld:'vCUSUARIORECOMENDACAOSERIEDESTINOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cUsuarioRecomendacaoSerieDataHora',fld:'vCUSUARIORECOMENDACAOSERIEDATAHORA',pic:'99/99/99 99:99',nv:''},{av:'AV10cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioRecomendacaoSerieId',fld:'vCUSUARIORECOMENDACAOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioRecomendacaoSerieOrigemId',fld:'vCUSUARIORECOMENDACAOSERIEORIGEMID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cUsuarioRecomendacaoSerieDestinoId',fld:'vCUSUARIORECOMENDACAOSERIEDESTINOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cUsuarioRecomendacaoSerieDataHora',fld:'vCUSUARIORECOMENDACAOSERIEDATAHORA',pic:'99/99/99 99:99',nv:''},{av:'AV10cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
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
         AV9cUsuarioRecomendacaoSerieDataHora = (DateTime)(DateTime.MinValue);
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblusuariorecomendacaoserieidfilter_Jsonclick = "";
         TempTags = "";
         lblLblusuariorecomendacaoserieorigemidfilter_Jsonclick = "";
         lblLblusuariorecomendacaoseriedestinoidfilter_Jsonclick = "";
         lblLblusuariorecomendacaoseriedatahorafilter_Jsonclick = "";
         lblLblserieidfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A36UsuarioRecomendacaoSerieDataHo = (DateTime)(DateTime.MinValue);
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV15Linkselection_GXI = "";
         scmdbuf = "";
         H00232_A1SerieId = new long[1] ;
         H00232_A36UsuarioRecomendacaoSerieDataHo = new DateTime[] {DateTime.MinValue} ;
         H00232_A34UsuarioRecomendacaoSerieDestin = new long[1] ;
         H00232_A33UsuarioRecomendacaoSerieOrigem = new long[1] ;
         H00232_A32UsuarioRecomendacaoSerieId = new long[1] ;
         H00233_AGRID1_nRecordCount = new long[1] ;
         AV12ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0090__default(),
            new Object[][] {
                new Object[] {
               H00232_A1SerieId, H00232_A36UsuarioRecomendacaoSerieDataHo, H00232_A34UsuarioRecomendacaoSerieDestin, H00232_A33UsuarioRecomendacaoSerieOrigem, H00232_A32UsuarioRecomendacaoSerieId
               }
               , new Object[] {
               H00233_AGRID1_nRecordCount
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
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCusuariorecomendacaoserieid_Enabled ;
      private int edtavCusuariorecomendacaoserieid_Visible ;
      private int edtavCusuariorecomendacaoserieorigemid_Enabled ;
      private int edtavCusuariorecomendacaoserieorigemid_Visible ;
      private int edtavCusuariorecomendacaoseriedestinoid_Enabled ;
      private int edtavCusuariorecomendacaoseriedestinoid_Visible ;
      private int edtavCusuariorecomendacaoseriedatahora_Enabled ;
      private int edtavCserieid_Enabled ;
      private int edtavCserieid_Visible ;
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
      private long AV6cUsuarioRecomendacaoSerieId ;
      private long AV7cUsuarioRecomendacaoSerieOrigemId ;
      private long AV8cUsuarioRecomendacaoSerieDestinoId ;
      private long AV10cSerieId ;
      private long AV11pUsuarioRecomendacaoSerieId ;
      private long A32UsuarioRecomendacaoSerieId ;
      private long A33UsuarioRecomendacaoSerieOrigem ;
      private long A34UsuarioRecomendacaoSerieDestin ;
      private long A1SerieId ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divUsuariorecomendacaoserieidfiltercontainer_Class ;
      private String divUsuariorecomendacaoserieorigemidfiltercontainer_Class ;
      private String divUsuariorecomendacaoseriedestinoidfiltercontainer_Class ;
      private String divUsuariorecomendacaoseriedatahorafiltercontainer_Class ;
      private String divSerieidfiltercontainer_Class ;
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
      private String divUsuariorecomendacaoserieidfiltercontainer_Internalname ;
      private String lblLblusuariorecomendacaoserieidfilter_Internalname ;
      private String lblLblusuariorecomendacaoserieidfilter_Jsonclick ;
      private String edtavCusuariorecomendacaoserieid_Internalname ;
      private String TempTags ;
      private String edtavCusuariorecomendacaoserieid_Jsonclick ;
      private String divUsuariorecomendacaoserieorigemidfiltercontainer_Internalname ;
      private String lblLblusuariorecomendacaoserieorigemidfilter_Internalname ;
      private String lblLblusuariorecomendacaoserieorigemidfilter_Jsonclick ;
      private String edtavCusuariorecomendacaoserieorigemid_Internalname ;
      private String edtavCusuariorecomendacaoserieorigemid_Jsonclick ;
      private String divUsuariorecomendacaoseriedestinoidfiltercontainer_Internalname ;
      private String lblLblusuariorecomendacaoseriedestinoidfilter_Internalname ;
      private String lblLblusuariorecomendacaoseriedestinoidfilter_Jsonclick ;
      private String edtavCusuariorecomendacaoseriedestinoid_Internalname ;
      private String edtavCusuariorecomendacaoseriedestinoid_Jsonclick ;
      private String divUsuariorecomendacaoseriedatahorafiltercontainer_Internalname ;
      private String lblLblusuariorecomendacaoseriedatahorafilter_Internalname ;
      private String lblLblusuariorecomendacaoseriedatahorafilter_Jsonclick ;
      private String edtavCusuariorecomendacaoseriedatahora_Internalname ;
      private String edtavCusuariorecomendacaoseriedatahora_Jsonclick ;
      private String divSerieidfiltercontainer_Internalname ;
      private String lblLblserieidfilter_Internalname ;
      private String lblLblserieidfilter_Jsonclick ;
      private String edtavCserieid_Internalname ;
      private String edtavCserieid_Jsonclick ;
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
      private String edtUsuarioRecomendacaoSerieId_Internalname ;
      private String edtUsuarioRecomendacaoSerieOrigem_Internalname ;
      private String edtUsuarioRecomendacaoSerieDestin_Internalname ;
      private String edtUsuarioRecomendacaoSerieDataHo_Internalname ;
      private String edtSerieId_Internalname ;
      private String scmdbuf ;
      private String AV12ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_64_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtUsuarioRecomendacaoSerieId_Jsonclick ;
      private String edtUsuarioRecomendacaoSerieOrigem_Jsonclick ;
      private String edtUsuarioRecomendacaoSerieDestin_Jsonclick ;
      private String edtUsuarioRecomendacaoSerieDataHo_Jsonclick ;
      private String edtSerieId_Jsonclick ;
      private DateTime AV9cUsuarioRecomendacaoSerieDataHora ;
      private DateTime A36UsuarioRecomendacaoSerieDataHo ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_64_Refreshing=false ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV15Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H00232_A1SerieId ;
      private DateTime[] H00232_A36UsuarioRecomendacaoSerieDataHo ;
      private long[] H00232_A34UsuarioRecomendacaoSerieDestin ;
      private long[] H00232_A33UsuarioRecomendacaoSerieOrigem ;
      private long[] H00232_A32UsuarioRecomendacaoSerieId ;
      private long[] H00233_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_pUsuarioRecomendacaoSerieId ;
      private GXWebForm Form ;
   }

   public class gx0090__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00232( IGxContext context ,
                                             long AV7cUsuarioRecomendacaoSerieOrigemId ,
                                             long AV8cUsuarioRecomendacaoSerieDestinoId ,
                                             DateTime AV9cUsuarioRecomendacaoSerieDataHora ,
                                             long AV10cSerieId ,
                                             long A33UsuarioRecomendacaoSerieOrigem ,
                                             long A34UsuarioRecomendacaoSerieDestin ,
                                             DateTime A36UsuarioRecomendacaoSerieDataHo ,
                                             long A1SerieId ,
                                             long AV6cUsuarioRecomendacaoSerieId )
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
         sSelectString = " [SerieId], [UsuarioRecomendacaoSerieDataHo], [UsuarioRecomendacaoSerieDestin], [UsuarioRecomendacaoSerieOrigem], [UsuarioRecomendacaoSerieId]";
         sFromString = " FROM [UsuarioRecomendacaoSerie] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([UsuarioRecomendacaoSerieId] >= @AV6cUsuarioRecomendacaoSerieId)";
         if ( ! (0==AV7cUsuarioRecomendacaoSerieOrigemId) )
         {
            sWhereString = sWhereString + " and ([UsuarioRecomendacaoSerieOrigem] >= @AV7cUsuarioRecomendacaoSerieOrigemId)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV8cUsuarioRecomendacaoSerieDestinoId) )
         {
            sWhereString = sWhereString + " and ([UsuarioRecomendacaoSerieDestin] >= @AV8cUsuarioRecomendacaoSerieDestinoId)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV9cUsuarioRecomendacaoSerieDataHora) )
         {
            sWhereString = sWhereString + " and ([UsuarioRecomendacaoSerieDataHo] >= @AV9cUsuarioRecomendacaoSerieDataHora)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV10cSerieId) )
         {
            sWhereString = sWhereString + " and ([SerieId] >= @AV10cSerieId)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [UsuarioRecomendacaoSerieId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00233( IGxContext context ,
                                             long AV7cUsuarioRecomendacaoSerieOrigemId ,
                                             long AV8cUsuarioRecomendacaoSerieDestinoId ,
                                             DateTime AV9cUsuarioRecomendacaoSerieDataHora ,
                                             long AV10cSerieId ,
                                             long A33UsuarioRecomendacaoSerieOrigem ,
                                             long A34UsuarioRecomendacaoSerieDestin ,
                                             DateTime A36UsuarioRecomendacaoSerieDataHo ,
                                             long A1SerieId ,
                                             long AV6cUsuarioRecomendacaoSerieId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [5] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [UsuarioRecomendacaoSerie] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([UsuarioRecomendacaoSerieId] >= @AV6cUsuarioRecomendacaoSerieId)";
         if ( ! (0==AV7cUsuarioRecomendacaoSerieOrigemId) )
         {
            sWhereString = sWhereString + " and ([UsuarioRecomendacaoSerieOrigem] >= @AV7cUsuarioRecomendacaoSerieOrigemId)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV8cUsuarioRecomendacaoSerieDestinoId) )
         {
            sWhereString = sWhereString + " and ([UsuarioRecomendacaoSerieDestin] >= @AV8cUsuarioRecomendacaoSerieDestinoId)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV9cUsuarioRecomendacaoSerieDataHora) )
         {
            sWhereString = sWhereString + " and ([UsuarioRecomendacaoSerieDataHo] >= @AV9cUsuarioRecomendacaoSerieDataHora)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV10cSerieId) )
         {
            sWhereString = sWhereString + " and ([SerieId] >= @AV10cSerieId)";
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
                     return conditional_H00232(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (DateTime)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (DateTime)dynConstraints[6] , (long)dynConstraints[7] , (long)dynConstraints[8] );
               case 1 :
                     return conditional_H00233(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (DateTime)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (DateTime)dynConstraints[6] , (long)dynConstraints[7] , (long)dynConstraints[8] );
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
          Object[] prmH00232 ;
          prmH00232 = new Object[] {
          new Object[] {"@AV6cUsuarioRecomendacaoSerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV7cUsuarioRecomendacaoSerieOrigemId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV8cUsuarioRecomendacaoSerieDestinoId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV9cUsuarioRecomendacaoSerieDataHora",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV10cSerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00233 ;
          prmH00233 = new Object[] {
          new Object[] {"@AV6cUsuarioRecomendacaoSerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV7cUsuarioRecomendacaoSerieOrigemId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV8cUsuarioRecomendacaoSerieDestinoId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV9cUsuarioRecomendacaoSerieDataHora",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV10cSerieId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00232", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00232,11,0,false,false )
             ,new CursorDef("H00233", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00233,1,0,false,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
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
                   stmt.SetParameter(sIdx, (long)parms[10]);
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
                   stmt.SetParameter(sIdx, (long)parms[7]);
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
