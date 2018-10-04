/*
               File: Gx0040
        Description: Selection List Usuário série
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:33.93
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
   public class gx0040 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0040( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gx0040( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_pUsuarioSerieId )
      {
         this.AV12pUsuarioSerieId = 0 ;
         executePrivate();
         aP0_pUsuarioSerieId=this.AV12pUsuarioSerieId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavCusuarioserieassistida = new GXCheckbox();
         chkavCusuarioseriefavorita = new GXCheckbox();
         chkUsuarioSerieAssistida = new GXCheckbox();
         chkUsuarioSerieFavorita = new GXCheckbox();
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
               AV6cUsuarioSerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cUsuarioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cSerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV9cUsuarioSerieNota = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV10cUsuarioSerieAssistida = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV11cUsuarioSerieFavorita = (bool)(BooleanUtil.Val(GetNextPar( )));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioSerieId, AV7cUsuarioId, AV8cSerieId, AV9cUsuarioSerieNota, AV10cUsuarioSerieAssistida, AV11cUsuarioSerieFavorita) ;
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
               AV12pUsuarioSerieId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pUsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pUsuarioSerieId), 18, 0)));
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
         PA1Y2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1Y2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20189201946341", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0040.aspx") + "?" + UrlEncode("" +AV12pUsuarioSerieId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cUsuarioSerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cUsuarioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cSerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOSERIENOTA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cUsuarioSerieNota), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOSERIEASSISTIDA", StringUtil.BoolToStr( AV10cUsuarioSerieAssistida));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOSERIEFAVORITA", StringUtil.BoolToStr( AV11cUsuarioSerieFavorita));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPUSUARIOSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pUsuarioSerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "USUARIOSERIEIDFILTERCONTAINER_Class", StringUtil.RTrim( divUsuarioserieidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIOIDFILTERCONTAINER_Class", StringUtil.RTrim( divUsuarioidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SERIEIDFILTERCONTAINER_Class", StringUtil.RTrim( divSerieidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIOSERIENOTAFILTERCONTAINER_Class", StringUtil.RTrim( divUsuarioserienotafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIOSERIEASSISTIDAFILTERCONTAINER_Class", StringUtil.RTrim( divUsuarioserieassistidafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIOSERIEFAVORITAFILTERCONTAINER_Class", StringUtil.RTrim( divUsuarioseriefavoritafiltercontainer_Class));
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
            WE1Y2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1Y2( ) ;
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
         return formatLink("gx0040.aspx") + "?" + UrlEncode("" +AV12pUsuarioSerieId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0040" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Usuário série" ;
      }

      protected void WB1Y0( )
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
            GxWebStd.gx_div_start( context, divUsuarioserieidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuarioserieidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuarioserieidfilter_Internalname, "Id", "", "", lblLblusuarioserieidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111y1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusuarioserieid_Internalname, "Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusuarioserieid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cUsuarioSerieId), 18, 0, ",", "")), ((edtavCusuarioserieid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cUsuarioSerieId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cUsuarioSerieId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuarioserieid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusuarioserieid_Visible, edtavCusuarioserieid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0040.htm");
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
            GxWebStd.gx_label_ctrl( context, lblLblusuarioidfilter_Internalname, "Id", "", "", lblLblusuarioidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121y1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0040.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusuarioid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cUsuarioId), 18, 0, ",", "")), ((edtavCusuarioid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cUsuarioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7cUsuarioId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuarioid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusuarioid_Visible, edtavCusuarioid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0040.htm");
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
            GxWebStd.gx_label_ctrl( context, lblLblserieidfilter_Internalname, "Id", "", "", lblLblserieidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131y1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0040.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCserieid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cSerieId), 18, 0, ",", "")), ((edtavCserieid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cSerieId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8cSerieId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCserieid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCserieid_Visible, edtavCserieid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0040.htm");
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
            GxWebStd.gx_div_start( context, divUsuarioserienotafiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuarioserienotafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuarioserienotafilter_Internalname, "Nota", "", "", lblLblusuarioserienotafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141y1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusuarioserienota_Internalname, "Nota", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusuarioserienota_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cUsuarioSerieNota), 1, 0, ",", "")), ((edtavCusuarioserienota_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9cUsuarioSerieNota), "9")) : context.localUtil.Format( (decimal)(AV9cUsuarioSerieNota), "9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuarioserienota_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusuarioserienota_Visible, edtavCusuarioserienota_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0040.htm");
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
            GxWebStd.gx_div_start( context, divUsuarioserieassistidafiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuarioserieassistidafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuarioserieassistidafilter_Internalname, "Assistida", "", "", lblLblusuarioserieassistidafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151y1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCusuarioserieassistida_Internalname, "Assistida", "col-sm-3 AttributeLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCusuarioserieassistida_Internalname, StringUtil.BoolToStr( AV10cUsuarioSerieAssistida), "", "Assistida", chkavCusuarioserieassistida.Visible, chkavCusuarioserieassistida.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(56, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"");
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
            GxWebStd.gx_div_start( context, divUsuarioseriefavoritafiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuarioseriefavoritafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuarioseriefavoritafilter_Internalname, "Série favorita", "", "", lblLblusuarioseriefavoritafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e161y1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCusuarioseriefavorita_Internalname, "Série favorita", "col-sm-3 AttributeLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCusuarioseriefavorita_Internalname, StringUtil.BoolToStr( AV11cUsuarioSerieFavorita), "", "Série favorita", chkavCusuarioseriefavorita.Visible, chkavCusuarioseriefavorita.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(66, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e171y1_client"+"'", TempTags, "", 2, "HLP_Gx0040.htm");
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nota") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Assistida") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "favorita") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13UsuarioSerieId), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A14UsuarioSerieNota), 1, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtUsuarioSerieNota_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.BoolToStr( A15UsuarioSerieAssistida));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.BoolToStr( A17UsuarioSerieFavorita));
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0040.htm");
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

      protected void START1Y2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Selection List Usuário série", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1Y0( ) ;
      }

      protected void WS1Y2( )
      {
         START1Y2( ) ;
         EVT1Y2( ) ;
      }

      protected void EVT1Y2( )
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
                              A13UsuarioSerieId = (long)(context.localUtil.CToN( cgiGet( edtUsuarioSerieId_Internalname), ",", "."));
                              A11UsuarioId = (long)(context.localUtil.CToN( cgiGet( edtUsuarioId_Internalname), ",", "."));
                              A1SerieId = (long)(context.localUtil.CToN( cgiGet( edtSerieId_Internalname), ",", "."));
                              A14UsuarioSerieNota = (short)(context.localUtil.CToN( cgiGet( edtUsuarioSerieNota_Internalname), ",", "."));
                              A15UsuarioSerieAssistida = StringUtil.StrToBool( cgiGet( chkUsuarioSerieAssistida_Internalname));
                              A17UsuarioSerieFavorita = StringUtil.StrToBool( cgiGet( chkUsuarioSerieFavorita_Internalname));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E181Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E191Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cusuarioserieid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOSERIEID"), ",", ".") != Convert.ToDecimal( AV6cUsuarioSerieId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuarioid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOID"), ",", ".") != Convert.ToDecimal( AV7cUsuarioId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cserieid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSERIEID"), ",", ".") != Convert.ToDecimal( AV8cSerieId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuarioserienota Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOSERIENOTA"), ",", ".") != Convert.ToDecimal( AV9cUsuarioSerieNota )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuarioserieassistida Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vCUSUARIOSERIEASSISTIDA")) != AV10cUsuarioSerieAssistida )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuarioseriefavorita Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vCUSUARIOSERIEFAVORITA")) != AV11cUsuarioSerieFavorita )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E201Y2 ();
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

      protected void WE1Y2( )
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

      protected void PA1Y2( )
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
            chkavCusuarioserieassistida.Name = "vCUSUARIOSERIEASSISTIDA";
            chkavCusuarioserieassistida.WebTags = "";
            chkavCusuarioserieassistida.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCusuarioserieassistida_Internalname, "TitleCaption", chkavCusuarioserieassistida.Caption, true);
            chkavCusuarioserieassistida.CheckedValue = "false";
            chkavCusuarioseriefavorita.Name = "vCUSUARIOSERIEFAVORITA";
            chkavCusuarioseriefavorita.WebTags = "";
            chkavCusuarioseriefavorita.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCusuarioseriefavorita_Internalname, "TitleCaption", chkavCusuarioseriefavorita.Caption, true);
            chkavCusuarioseriefavorita.CheckedValue = "false";
            GXCCtl = "USUARIOSERIEASSISTIDA_" + sGXsfl_74_idx;
            chkUsuarioSerieAssistida.Name = GXCCtl;
            chkUsuarioSerieAssistida.WebTags = "";
            chkUsuarioSerieAssistida.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioSerieAssistida_Internalname, "TitleCaption", chkUsuarioSerieAssistida.Caption, !bGXsfl_74_Refreshing);
            chkUsuarioSerieAssistida.CheckedValue = "false";
            GXCCtl = "USUARIOSERIEFAVORITA_" + sGXsfl_74_idx;
            chkUsuarioSerieFavorita.Name = GXCCtl;
            chkUsuarioSerieFavorita.WebTags = "";
            chkUsuarioSerieFavorita.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioSerieFavorita_Internalname, "TitleCaption", chkUsuarioSerieFavorita.Caption, !bGXsfl_74_Refreshing);
            chkUsuarioSerieFavorita.CheckedValue = "false";
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
                                        long AV6cUsuarioSerieId ,
                                        long AV7cUsuarioId ,
                                        long AV8cSerieId ,
                                        short AV9cUsuarioSerieNota ,
                                        bool AV10cUsuarioSerieAssistida ,
                                        bool AV11cUsuarioSerieFavorita )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF1Y2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_USUARIOSERIEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A13UsuarioSerieId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "USUARIOSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13UsuarioSerieId), 18, 0, ".", "")));
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
         RF1Y2( ) ;
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

      protected void RF1Y2( )
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
                                                 AV7cUsuarioId ,
                                                 AV8cSerieId ,
                                                 AV9cUsuarioSerieNota ,
                                                 AV10cUsuarioSerieAssistida ,
                                                 AV11cUsuarioSerieFavorita ,
                                                 A11UsuarioId ,
                                                 A1SerieId ,
                                                 A14UsuarioSerieNota ,
                                                 A15UsuarioSerieAssistida ,
                                                 A17UsuarioSerieFavorita ,
                                                 AV6cUsuarioSerieId } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN,
                                                 TypeConstants.LONG
                                                 }
            } ) ;
            /* Using cursor H001Y2 */
            pr_default.execute(0, new Object[] {AV6cUsuarioSerieId, AV7cUsuarioId, AV8cSerieId, AV9cUsuarioSerieNota, AV10cUsuarioSerieAssistida, AV11cUsuarioSerieFavorita, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_74_idx = 1;
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A17UsuarioSerieFavorita = H001Y2_A17UsuarioSerieFavorita[0];
               A15UsuarioSerieAssistida = H001Y2_A15UsuarioSerieAssistida[0];
               A14UsuarioSerieNota = H001Y2_A14UsuarioSerieNota[0];
               A1SerieId = H001Y2_A1SerieId[0];
               A11UsuarioId = H001Y2_A11UsuarioId[0];
               A13UsuarioSerieId = H001Y2_A13UsuarioSerieId[0];
               /* Execute user event: Load */
               E191Y2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB1Y0( ) ;
         }
         bGXsfl_74_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1Y2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_USUARIOSERIEID"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A13UsuarioSerieId), "ZZZZZZZZZZZZZZZZZ9"), context));
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
                                              AV8cSerieId ,
                                              AV9cUsuarioSerieNota ,
                                              AV10cUsuarioSerieAssistida ,
                                              AV11cUsuarioSerieFavorita ,
                                              A11UsuarioId ,
                                              A1SerieId ,
                                              A14UsuarioSerieNota ,
                                              A15UsuarioSerieAssistida ,
                                              A17UsuarioSerieFavorita ,
                                              AV6cUsuarioSerieId } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN,
                                              TypeConstants.LONG
                                              }
         } ) ;
         /* Using cursor H001Y3 */
         pr_default.execute(1, new Object[] {AV6cUsuarioSerieId, AV7cUsuarioId, AV8cSerieId, AV9cUsuarioSerieNota, AV10cUsuarioSerieAssistida, AV11cUsuarioSerieFavorita});
         GRID1_nRecordCount = H001Y3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioSerieId, AV7cUsuarioId, AV8cSerieId, AV9cUsuarioSerieNota, AV10cUsuarioSerieAssistida, AV11cUsuarioSerieFavorita) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioSerieId, AV7cUsuarioId, AV8cSerieId, AV9cUsuarioSerieNota, AV10cUsuarioSerieAssistida, AV11cUsuarioSerieFavorita) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioSerieId, AV7cUsuarioId, AV8cSerieId, AV9cUsuarioSerieNota, AV10cUsuarioSerieAssistida, AV11cUsuarioSerieFavorita) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioSerieId, AV7cUsuarioId, AV8cSerieId, AV9cUsuarioSerieNota, AV10cUsuarioSerieAssistida, AV11cUsuarioSerieFavorita) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioSerieId, AV7cUsuarioId, AV8cSerieId, AV9cUsuarioSerieNota, AV10cUsuarioSerieAssistida, AV11cUsuarioSerieFavorita) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP1Y0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E181Y2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCusuarioserieid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCusuarioserieid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCUSUARIOSERIEID");
               GX_FocusControl = edtavCusuarioserieid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cUsuarioSerieId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cUsuarioSerieId), 18, 0)));
            }
            else
            {
               AV6cUsuarioSerieId = (long)(context.localUtil.CToN( cgiGet( edtavCusuarioserieid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cUsuarioSerieId), 18, 0)));
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCserieid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCserieid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSERIEID");
               GX_FocusControl = edtavCserieid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cSerieId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cSerieId), 18, 0)));
            }
            else
            {
               AV8cSerieId = (long)(context.localUtil.CToN( cgiGet( edtavCserieid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cSerieId), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCusuarioserienota_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCusuarioserienota_Internalname), ",", ".") > Convert.ToDecimal( 9 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCUSUARIOSERIENOTA");
               GX_FocusControl = edtavCusuarioserienota_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cUsuarioSerieNota = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cUsuarioSerieNota", StringUtil.Str( (decimal)(AV9cUsuarioSerieNota), 1, 0));
            }
            else
            {
               AV9cUsuarioSerieNota = (short)(context.localUtil.CToN( cgiGet( edtavCusuarioserienota_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cUsuarioSerieNota", StringUtil.Str( (decimal)(AV9cUsuarioSerieNota), 1, 0));
            }
            AV10cUsuarioSerieAssistida = StringUtil.StrToBool( cgiGet( chkavCusuarioserieassistida_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cUsuarioSerieAssistida", AV10cUsuarioSerieAssistida);
            AV11cUsuarioSerieFavorita = StringUtil.StrToBool( cgiGet( chkavCusuarioseriefavorita_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsuarioSerieFavorita", AV11cUsuarioSerieFavorita);
            /* Read saved values. */
            nRC_GXsfl_74 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOSERIEID"), ",", ".") != Convert.ToDecimal( AV6cUsuarioSerieId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOID"), ",", ".") != Convert.ToDecimal( AV7cUsuarioId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSERIEID"), ",", ".") != Convert.ToDecimal( AV8cSerieId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOSERIENOTA"), ",", ".") != Convert.ToDecimal( AV9cUsuarioSerieNota )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vCUSUARIOSERIEASSISTIDA")) != AV10cUsuarioSerieAssistida )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vCUSUARIOSERIEFAVORITA")) != AV11cUsuarioSerieFavorita )
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
         E181Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E181Y2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Seleção %1", "Usuário série", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV13ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E191Y2( )
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
         E201Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E201Y2( )
      {
         /* Enter Routine */
         AV12pUsuarioSerieId = A13UsuarioSerieId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pUsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pUsuarioSerieId), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV12pUsuarioSerieId});
         context.setWebReturnParmsMetadata(new Object[] {"AV12pUsuarioSerieId"});
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
         AV12pUsuarioSerieId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pUsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pUsuarioSerieId), 18, 0)));
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
         PA1Y2( ) ;
         WS1Y2( ) ;
         WE1Y2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019463553", true);
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
         context.AddJavascriptSource("gx0040.js", "?201892019463553", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtUsuarioSerieId_Internalname = "USUARIOSERIEID_"+sGXsfl_74_idx;
         edtUsuarioId_Internalname = "USUARIOID_"+sGXsfl_74_idx;
         edtSerieId_Internalname = "SERIEID_"+sGXsfl_74_idx;
         edtUsuarioSerieNota_Internalname = "USUARIOSERIENOTA_"+sGXsfl_74_idx;
         chkUsuarioSerieAssistida_Internalname = "USUARIOSERIEASSISTIDA_"+sGXsfl_74_idx;
         chkUsuarioSerieFavorita_Internalname = "USUARIOSERIEFAVORITA_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_fel_idx;
         edtUsuarioSerieId_Internalname = "USUARIOSERIEID_"+sGXsfl_74_fel_idx;
         edtUsuarioId_Internalname = "USUARIOID_"+sGXsfl_74_fel_idx;
         edtSerieId_Internalname = "SERIEID_"+sGXsfl_74_fel_idx;
         edtUsuarioSerieNota_Internalname = "USUARIOSERIENOTA_"+sGXsfl_74_fel_idx;
         chkUsuarioSerieAssistida_Internalname = "USUARIOSERIEASSISTIDA_"+sGXsfl_74_fel_idx;
         chkUsuarioSerieFavorita_Internalname = "USUARIOSERIEFAVORITA_"+sGXsfl_74_fel_idx;
      }

      protected void sendrow_742( )
      {
         SubsflControlProps_742( ) ;
         WB1Y0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A13UsuarioSerieId), 18, 0, ",", "")))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioSerieId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A13UsuarioSerieId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A13UsuarioSerieId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioSerieId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSerieId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSerieId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtUsuarioSerieNota_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A13UsuarioSerieId), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioSerieNota_Internalname, "Link", edtUsuarioSerieNota_Link, !bGXsfl_74_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioSerieNota_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A14UsuarioSerieNota), 1, 0, ",", "")),context.localUtil.Format( (decimal)(A14UsuarioSerieNota), "9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtUsuarioSerieNota_Link,(String)"",(String)"",(String)"",(String)edtUsuarioSerieNota_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Nota",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "Attribute";
            StyleString = "";
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkUsuarioSerieAssistida_Internalname,StringUtil.BoolToStr( A15UsuarioSerieAssistida),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn OptionalColumn",(String)"",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "Attribute";
            StyleString = "";
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkUsuarioSerieFavorita_Internalname,StringUtil.BoolToStr( A17UsuarioSerieFavorita),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn OptionalColumn",(String)"",(String)""});
            send_integrity_lvl_hashes1Y2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
         }
         /* End function sendrow_742 */
      }

      protected void init_default_properties( )
      {
         lblLblusuarioserieidfilter_Internalname = "LBLUSUARIOSERIEIDFILTER";
         edtavCusuarioserieid_Internalname = "vCUSUARIOSERIEID";
         divUsuarioserieidfiltercontainer_Internalname = "USUARIOSERIEIDFILTERCONTAINER";
         lblLblusuarioidfilter_Internalname = "LBLUSUARIOIDFILTER";
         edtavCusuarioid_Internalname = "vCUSUARIOID";
         divUsuarioidfiltercontainer_Internalname = "USUARIOIDFILTERCONTAINER";
         lblLblserieidfilter_Internalname = "LBLSERIEIDFILTER";
         edtavCserieid_Internalname = "vCSERIEID";
         divSerieidfiltercontainer_Internalname = "SERIEIDFILTERCONTAINER";
         lblLblusuarioserienotafilter_Internalname = "LBLUSUARIOSERIENOTAFILTER";
         edtavCusuarioserienota_Internalname = "vCUSUARIOSERIENOTA";
         divUsuarioserienotafiltercontainer_Internalname = "USUARIOSERIENOTAFILTERCONTAINER";
         lblLblusuarioserieassistidafilter_Internalname = "LBLUSUARIOSERIEASSISTIDAFILTER";
         chkavCusuarioserieassistida_Internalname = "vCUSUARIOSERIEASSISTIDA";
         divUsuarioserieassistidafiltercontainer_Internalname = "USUARIOSERIEASSISTIDAFILTERCONTAINER";
         lblLblusuarioseriefavoritafilter_Internalname = "LBLUSUARIOSERIEFAVORITAFILTER";
         chkavCusuarioseriefavorita_Internalname = "vCUSUARIOSERIEFAVORITA";
         divUsuarioseriefavoritafiltercontainer_Internalname = "USUARIOSERIEFAVORITAFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtUsuarioSerieId_Internalname = "USUARIOSERIEID";
         edtUsuarioId_Internalname = "USUARIOID";
         edtSerieId_Internalname = "SERIEID";
         edtUsuarioSerieNota_Internalname = "USUARIOSERIENOTA";
         chkUsuarioSerieAssistida_Internalname = "USUARIOSERIEASSISTIDA";
         chkUsuarioSerieFavorita_Internalname = "USUARIOSERIEFAVORITA";
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
         edtUsuarioSerieNota_Jsonclick = "";
         edtSerieId_Jsonclick = "";
         edtUsuarioId_Jsonclick = "";
         edtUsuarioSerieId_Jsonclick = "";
         chkUsuarioSerieFavorita.Caption = "";
         chkUsuarioSerieAssistida.Caption = "";
         chkavCusuarioseriefavorita.Caption = "Série favorita";
         chkavCusuarioserieassistida.Caption = "Assistida";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtUsuarioSerieNota_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         chkavCusuarioseriefavorita.Enabled = 1;
         chkavCusuarioseriefavorita.Visible = 1;
         chkavCusuarioserieassistida.Enabled = 1;
         chkavCusuarioserieassistida.Visible = 1;
         edtavCusuarioserienota_Jsonclick = "";
         edtavCusuarioserienota_Enabled = 1;
         edtavCusuarioserienota_Visible = 1;
         edtavCserieid_Jsonclick = "";
         edtavCserieid_Enabled = 1;
         edtavCserieid_Visible = 1;
         edtavCusuarioid_Jsonclick = "";
         edtavCusuarioid_Enabled = 1;
         edtavCusuarioid_Visible = 1;
         edtavCusuarioserieid_Jsonclick = "";
         edtavCusuarioserieid_Enabled = 1;
         edtavCusuarioserieid_Visible = 1;
         divUsuarioseriefavoritafiltercontainer_Class = "AdvancedContainerItem";
         divUsuarioserieassistidafiltercontainer_Class = "AdvancedContainerItem";
         divUsuarioserienotafiltercontainer_Class = "AdvancedContainerItem";
         divSerieidfiltercontainer_Class = "AdvancedContainerItem";
         divUsuarioidfiltercontainer_Class = "AdvancedContainerItem";
         divUsuarioserieidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Usuário série";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioSerieId',fld:'vCUSUARIOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cUsuarioSerieNota',fld:'vCUSUARIOSERIENOTA',pic:'9',nv:0},{av:'AV10cUsuarioSerieAssistida',fld:'vCUSUARIOSERIEASSISTIDA',pic:'',nv:false},{av:'AV11cUsuarioSerieFavorita',fld:'vCUSUARIOSERIEFAVORITA',pic:'',nv:false}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E171Y1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLUSUARIOSERIEIDFILTER.CLICK","{handler:'E111Y1',iparms:[{av:'divUsuarioserieidfiltercontainer_Class',ctrl:'USUARIOSERIEIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuarioserieidfiltercontainer_Class',ctrl:'USUARIOSERIEIDFILTERCONTAINER',prop:'Class'},{av:'edtavCusuarioserieid_Visible',ctrl:'vCUSUARIOSERIEID',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIOIDFILTER.CLICK","{handler:'E121Y1',iparms:[{av:'divUsuarioidfiltercontainer_Class',ctrl:'USUARIOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuarioidfiltercontainer_Class',ctrl:'USUARIOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCusuarioid_Visible',ctrl:'vCUSUARIOID',prop:'Visible'}]}");
         setEventMetadata("LBLSERIEIDFILTER.CLICK","{handler:'E131Y1',iparms:[{av:'divSerieidfiltercontainer_Class',ctrl:'SERIEIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divSerieidfiltercontainer_Class',ctrl:'SERIEIDFILTERCONTAINER',prop:'Class'},{av:'edtavCserieid_Visible',ctrl:'vCSERIEID',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIOSERIENOTAFILTER.CLICK","{handler:'E141Y1',iparms:[{av:'divUsuarioserienotafiltercontainer_Class',ctrl:'USUARIOSERIENOTAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuarioserienotafiltercontainer_Class',ctrl:'USUARIOSERIENOTAFILTERCONTAINER',prop:'Class'},{av:'edtavCusuarioserienota_Visible',ctrl:'vCUSUARIOSERIENOTA',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIOSERIEASSISTIDAFILTER.CLICK","{handler:'E151Y1',iparms:[{av:'divUsuarioserieassistidafiltercontainer_Class',ctrl:'USUARIOSERIEASSISTIDAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuarioserieassistidafiltercontainer_Class',ctrl:'USUARIOSERIEASSISTIDAFILTERCONTAINER',prop:'Class'},{av:'chkavCusuarioserieassistida.Visible',ctrl:'vCUSUARIOSERIEASSISTIDA',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIOSERIEFAVORITAFILTER.CLICK","{handler:'E161Y1',iparms:[{av:'divUsuarioseriefavoritafiltercontainer_Class',ctrl:'USUARIOSERIEFAVORITAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuarioseriefavoritafiltercontainer_Class',ctrl:'USUARIOSERIEFAVORITAFILTERCONTAINER',prop:'Class'},{av:'chkavCusuarioseriefavorita.Visible',ctrl:'vCUSUARIOSERIEFAVORITA',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E201Y2',iparms:[{av:'A13UsuarioSerieId',fld:'USUARIOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV12pUsuarioSerieId',fld:'vPUSUARIOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioSerieId',fld:'vCUSUARIOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cUsuarioSerieNota',fld:'vCUSUARIOSERIENOTA',pic:'9',nv:0},{av:'AV10cUsuarioSerieAssistida',fld:'vCUSUARIOSERIEASSISTIDA',pic:'',nv:false},{av:'AV11cUsuarioSerieFavorita',fld:'vCUSUARIOSERIEFAVORITA',pic:'',nv:false}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioSerieId',fld:'vCUSUARIOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cUsuarioSerieNota',fld:'vCUSUARIOSERIENOTA',pic:'9',nv:0},{av:'AV10cUsuarioSerieAssistida',fld:'vCUSUARIOSERIEASSISTIDA',pic:'',nv:false},{av:'AV11cUsuarioSerieFavorita',fld:'vCUSUARIOSERIEFAVORITA',pic:'',nv:false}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioSerieId',fld:'vCUSUARIOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cUsuarioSerieNota',fld:'vCUSUARIOSERIENOTA',pic:'9',nv:0},{av:'AV10cUsuarioSerieAssistida',fld:'vCUSUARIOSERIEASSISTIDA',pic:'',nv:false},{av:'AV11cUsuarioSerieFavorita',fld:'vCUSUARIOSERIEFAVORITA',pic:'',nv:false}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioSerieId',fld:'vCUSUARIOSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV8cSerieId',fld:'vCSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV9cUsuarioSerieNota',fld:'vCUSUARIOSERIENOTA',pic:'9',nv:0},{av:'AV10cUsuarioSerieAssistida',fld:'vCUSUARIOSERIEASSISTIDA',pic:'',nv:false},{av:'AV11cUsuarioSerieFavorita',fld:'vCUSUARIOSERIEFAVORITA',pic:'',nv:false}],oparms:[]}");
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
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblusuarioserieidfilter_Jsonclick = "";
         TempTags = "";
         lblLblusuarioidfilter_Jsonclick = "";
         lblLblserieidfilter_Jsonclick = "";
         lblLblusuarioserienotafilter_Jsonclick = "";
         lblLblusuarioserieassistidafilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         lblLblusuarioseriefavoritafilter_Jsonclick = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV16Linkselection_GXI = "";
         GXCCtl = "";
         scmdbuf = "";
         H001Y2_A17UsuarioSerieFavorita = new bool[] {false} ;
         H001Y2_A15UsuarioSerieAssistida = new bool[] {false} ;
         H001Y2_A14UsuarioSerieNota = new short[1] ;
         H001Y2_A1SerieId = new long[1] ;
         H001Y2_A11UsuarioId = new long[1] ;
         H001Y2_A13UsuarioSerieId = new long[1] ;
         H001Y3_AGRID1_nRecordCount = new long[1] ;
         AV13ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0040__default(),
            new Object[][] {
                new Object[] {
               H001Y2_A17UsuarioSerieFavorita, H001Y2_A15UsuarioSerieAssistida, H001Y2_A14UsuarioSerieNota, H001Y2_A1SerieId, H001Y2_A11UsuarioId, H001Y2_A13UsuarioSerieId
               }
               , new Object[] {
               H001Y3_AGRID1_nRecordCount
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
      private short AV9cUsuarioSerieNota ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A14UsuarioSerieNota ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCusuarioserieid_Enabled ;
      private int edtavCusuarioserieid_Visible ;
      private int edtavCusuarioid_Enabled ;
      private int edtavCusuarioid_Visible ;
      private int edtavCserieid_Enabled ;
      private int edtavCserieid_Visible ;
      private int edtavCusuarioserienota_Enabled ;
      private int edtavCusuarioserienota_Visible ;
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
      private long AV6cUsuarioSerieId ;
      private long AV7cUsuarioId ;
      private long AV8cSerieId ;
      private long AV12pUsuarioSerieId ;
      private long A13UsuarioSerieId ;
      private long A11UsuarioId ;
      private long A1SerieId ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divUsuarioserieidfiltercontainer_Class ;
      private String divUsuarioidfiltercontainer_Class ;
      private String divSerieidfiltercontainer_Class ;
      private String divUsuarioserienotafiltercontainer_Class ;
      private String divUsuarioserieassistidafiltercontainer_Class ;
      private String divUsuarioseriefavoritafiltercontainer_Class ;
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
      private String divUsuarioserieidfiltercontainer_Internalname ;
      private String lblLblusuarioserieidfilter_Internalname ;
      private String lblLblusuarioserieidfilter_Jsonclick ;
      private String edtavCusuarioserieid_Internalname ;
      private String TempTags ;
      private String edtavCusuarioserieid_Jsonclick ;
      private String divUsuarioidfiltercontainer_Internalname ;
      private String lblLblusuarioidfilter_Internalname ;
      private String lblLblusuarioidfilter_Jsonclick ;
      private String edtavCusuarioid_Internalname ;
      private String edtavCusuarioid_Jsonclick ;
      private String divSerieidfiltercontainer_Internalname ;
      private String lblLblserieidfilter_Internalname ;
      private String lblLblserieidfilter_Jsonclick ;
      private String edtavCserieid_Internalname ;
      private String edtavCserieid_Jsonclick ;
      private String divUsuarioserienotafiltercontainer_Internalname ;
      private String lblLblusuarioserienotafilter_Internalname ;
      private String lblLblusuarioserienotafilter_Jsonclick ;
      private String edtavCusuarioserienota_Internalname ;
      private String edtavCusuarioserienota_Jsonclick ;
      private String divUsuarioserieassistidafiltercontainer_Internalname ;
      private String lblLblusuarioserieassistidafilter_Internalname ;
      private String lblLblusuarioserieassistidafilter_Jsonclick ;
      private String chkavCusuarioserieassistida_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divUsuarioseriefavoritafiltercontainer_Internalname ;
      private String lblLblusuarioseriefavoritafilter_Internalname ;
      private String lblLblusuarioseriefavoritafilter_Jsonclick ;
      private String chkavCusuarioseriefavorita_Internalname ;
      private String divGridtable_Internalname ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String edtavLinkselection_Link ;
      private String edtUsuarioSerieNota_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtUsuarioSerieId_Internalname ;
      private String edtUsuarioId_Internalname ;
      private String edtSerieId_Internalname ;
      private String edtUsuarioSerieNota_Internalname ;
      private String chkUsuarioSerieAssistida_Internalname ;
      private String chkUsuarioSerieFavorita_Internalname ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String AV13ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_74_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtUsuarioSerieId_Jsonclick ;
      private String edtUsuarioId_Jsonclick ;
      private String edtSerieId_Jsonclick ;
      private String edtUsuarioSerieNota_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV10cUsuarioSerieAssistida ;
      private bool AV11cUsuarioSerieFavorita ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool A15UsuarioSerieAssistida ;
      private bool A17UsuarioSerieFavorita ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_74_Refreshing=false ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV16Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavCusuarioserieassistida ;
      private GXCheckbox chkavCusuarioseriefavorita ;
      private GXCheckbox chkUsuarioSerieAssistida ;
      private GXCheckbox chkUsuarioSerieFavorita ;
      private IDataStoreProvider pr_default ;
      private bool[] H001Y2_A17UsuarioSerieFavorita ;
      private bool[] H001Y2_A15UsuarioSerieAssistida ;
      private short[] H001Y2_A14UsuarioSerieNota ;
      private long[] H001Y2_A1SerieId ;
      private long[] H001Y2_A11UsuarioId ;
      private long[] H001Y2_A13UsuarioSerieId ;
      private long[] H001Y3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_pUsuarioSerieId ;
      private GXWebForm Form ;
   }

   public class gx0040__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001Y2( IGxContext context ,
                                             long AV7cUsuarioId ,
                                             long AV8cSerieId ,
                                             short AV9cUsuarioSerieNota ,
                                             bool AV10cUsuarioSerieAssistida ,
                                             bool AV11cUsuarioSerieFavorita ,
                                             long A11UsuarioId ,
                                             long A1SerieId ,
                                             short A14UsuarioSerieNota ,
                                             bool A15UsuarioSerieAssistida ,
                                             bool A17UsuarioSerieFavorita ,
                                             long AV6cUsuarioSerieId )
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
         sSelectString = " [UsuarioSerieFavorita], [UsuarioSerieAssistida], [UsuarioSerieNota], [SerieId], [UsuarioId], [UsuarioSerieId]";
         sFromString = " FROM [UsuarioSerie] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([UsuarioSerieId] >= @AV6cUsuarioSerieId)";
         if ( ! (0==AV7cUsuarioId) )
         {
            sWhereString = sWhereString + " and ([UsuarioId] >= @AV7cUsuarioId)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV8cSerieId) )
         {
            sWhereString = sWhereString + " and ([SerieId] >= @AV8cSerieId)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV9cUsuarioSerieNota) )
         {
            sWhereString = sWhereString + " and ([UsuarioSerieNota] >= @AV9cUsuarioSerieNota)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (false==AV10cUsuarioSerieAssistida) )
         {
            sWhereString = sWhereString + " and ([UsuarioSerieAssistida] >= @AV10cUsuarioSerieAssistida)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (false==AV11cUsuarioSerieFavorita) )
         {
            sWhereString = sWhereString + " and ([UsuarioSerieFavorita] >= @AV11cUsuarioSerieFavorita)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [UsuarioSerieId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001Y3( IGxContext context ,
                                             long AV7cUsuarioId ,
                                             long AV8cSerieId ,
                                             short AV9cUsuarioSerieNota ,
                                             bool AV10cUsuarioSerieAssistida ,
                                             bool AV11cUsuarioSerieFavorita ,
                                             long A11UsuarioId ,
                                             long A1SerieId ,
                                             short A14UsuarioSerieNota ,
                                             bool A15UsuarioSerieAssistida ,
                                             bool A17UsuarioSerieFavorita ,
                                             long AV6cUsuarioSerieId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [UsuarioSerie] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([UsuarioSerieId] >= @AV6cUsuarioSerieId)";
         if ( ! (0==AV7cUsuarioId) )
         {
            sWhereString = sWhereString + " and ([UsuarioId] >= @AV7cUsuarioId)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV8cSerieId) )
         {
            sWhereString = sWhereString + " and ([SerieId] >= @AV8cSerieId)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV9cUsuarioSerieNota) )
         {
            sWhereString = sWhereString + " and ([UsuarioSerieNota] >= @AV9cUsuarioSerieNota)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (false==AV10cUsuarioSerieAssistida) )
         {
            sWhereString = sWhereString + " and ([UsuarioSerieAssistida] >= @AV10cUsuarioSerieAssistida)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (false==AV11cUsuarioSerieFavorita) )
         {
            sWhereString = sWhereString + " and ([UsuarioSerieFavorita] >= @AV11cUsuarioSerieFavorita)";
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
                     return conditional_H001Y2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (short)dynConstraints[2] , (bool)dynConstraints[3] , (bool)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (short)dynConstraints[7] , (bool)dynConstraints[8] , (bool)dynConstraints[9] , (long)dynConstraints[10] );
               case 1 :
                     return conditional_H001Y3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (short)dynConstraints[2] , (bool)dynConstraints[3] , (bool)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (short)dynConstraints[7] , (bool)dynConstraints[8] , (bool)dynConstraints[9] , (long)dynConstraints[10] );
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
          Object[] prmH001Y2 ;
          prmH001Y2 = new Object[] {
          new Object[] {"@AV6cUsuarioSerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV7cUsuarioId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV8cSerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV9cUsuarioSerieNota",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV10cUsuarioSerieAssistida",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV11cUsuarioSerieFavorita",SqlDbType.Bit,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH001Y3 ;
          prmH001Y3 = new Object[] {
          new Object[] {"@AV6cUsuarioSerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV7cUsuarioId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV8cSerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV9cUsuarioSerieNota",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV10cUsuarioSerieAssistida",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV11cUsuarioSerieFavorita",SqlDbType.Bit,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001Y2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y2,11,0,false,false )
             ,new CursorDef("H001Y3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y3,1,0,false,false )
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
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
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
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[13]);
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
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[10]);
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
