/*
               File: Gx0030
        Description: Selection List Usuário
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:27.63
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
   public class gx0030 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0030( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gx0030( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_pUsuarioId )
      {
         this.AV8pUsuarioId = 0 ;
         executePrivate();
         aP0_pUsuarioId=this.AV8pUsuarioId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCusuariotipo = new GXCombobox();
         chkavCusuarioinativo = new GXCheckbox();
         cmbUsuarioTipo = new GXCombobox();
         chkUsuarioInativo = new GXCheckbox();
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
               AV6cUsuarioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cUsuarioNome = GetNextPar( );
               AV10cUsuarioTipo = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV11cUsuarioInativo = (bool)(BooleanUtil.Val(GetNextPar( )));
               AV12cUsuarioLogin = GetNextPar( );
               AV13cUsuarioSenha = GetNextPar( );
               AV14cUsuarioGamGuid = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioId, AV7cUsuarioNome, AV10cUsuarioTipo, AV11cUsuarioInativo, AV12cUsuarioLogin, AV13cUsuarioSenha, AV14cUsuarioGamGuid) ;
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
               AV8pUsuarioId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8pUsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8pUsuarioId), 18, 0)));
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
         PA1X2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1X2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019462773", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0030.aspx") + "?" + UrlEncode("" +AV8pUsuarioId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cUsuarioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIONOME", AV7cUsuarioNome);
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOTIPO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cUsuarioTipo), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOINATIVO", StringUtil.BoolToStr( AV11cUsuarioInativo));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOLOGIN", AV12cUsuarioLogin);
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOSENHA", AV13cUsuarioSenha);
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOGAMGUID", StringUtil.RTrim( AV14cUsuarioGamGuid));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPUSUARIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8pUsuarioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "USUARIOIDFILTERCONTAINER_Class", StringUtil.RTrim( divUsuarioidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIONOMEFILTERCONTAINER_Class", StringUtil.RTrim( divUsuarionomefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIOTIPOFILTERCONTAINER_Class", StringUtil.RTrim( divUsuariotipofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIOINATIVOFILTERCONTAINER_Class", StringUtil.RTrim( divUsuarioinativofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIOLOGINFILTERCONTAINER_Class", StringUtil.RTrim( divUsuariologinfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIOSENHAFILTERCONTAINER_Class", StringUtil.RTrim( divUsuariosenhafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "USUARIOGAMGUIDFILTERCONTAINER_Class", StringUtil.RTrim( divUsuariogamguidfiltercontainer_Class));
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
            WE1X2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1X2( ) ;
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
         return formatLink("gx0030.aspx") + "?" + UrlEncode("" +AV8pUsuarioId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0030" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Usuário" ;
      }

      protected void WB1X0( )
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
            GxWebStd.gx_div_start( context, divUsuarioidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuarioidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuarioidfilter_Internalname, "Id", "", "", lblLblusuarioidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusuarioid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cUsuarioId), 18, 0, ",", "")), ((edtavCusuarioid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cUsuarioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV6cUsuarioId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuarioid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusuarioid_Visible, edtavCusuarioid_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0030.htm");
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
            GxWebStd.gx_div_start( context, divUsuarionomefiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuarionomefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuarionomefilter_Internalname, "Nome", "", "", lblLblusuarionomefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusuarionome_Internalname, "Nome", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusuarionome_Internalname, AV7cUsuarioNome, StringUtil.RTrim( context.localUtil.Format( AV7cUsuarioNome, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuarionome_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusuarionome_Visible, edtavCusuarionome_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0030.htm");
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
            GxWebStd.gx_div_start( context, divUsuariotipofiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuariotipofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuariotipofilter_Internalname, "Tipo", "", "", lblLblusuariotipofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCusuariotipo_Internalname, "Tipo", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCusuariotipo, cmbavCusuariotipo_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV10cUsuarioTipo), 4, 0)), 1, cmbavCusuariotipo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavCusuariotipo.Visible, cmbavCusuariotipo.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "", true, "HLP_Gx0030.htm");
            cmbavCusuariotipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV10cUsuarioTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCusuariotipo_Internalname, "Values", (String)(cmbavCusuariotipo.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divUsuarioinativofiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuarioinativofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuarioinativofilter_Internalname, "Inativo", "", "", lblLblusuarioinativofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCusuarioinativo_Internalname, "Inativo", "col-sm-3 AttributeLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCusuarioinativo_Internalname, StringUtil.BoolToStr( AV11cUsuarioInativo), "", "Inativo", chkavCusuarioinativo.Visible, chkavCusuarioinativo.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(46, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"");
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
            GxWebStd.gx_div_start( context, divUsuariologinfiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuariologinfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuariologinfilter_Internalname, "Login", "", "", lblLblusuariologinfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusuariologin_Internalname, "Login", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusuariologin_Internalname, AV12cUsuarioLogin, StringUtil.RTrim( context.localUtil.Format( AV12cUsuarioLogin, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuariologin_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusuariologin_Visible, edtavCusuariologin_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0030.htm");
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
            GxWebStd.gx_div_start( context, divUsuariosenhafiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuariosenhafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuariosenhafilter_Internalname, "Senha", "", "", lblLblusuariosenhafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e161x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusuariosenha_Internalname, "Senha", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusuariosenha_Internalname, AV13cUsuarioSenha, StringUtil.RTrim( context.localUtil.Format( AV13cUsuarioSenha, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuariosenha_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusuariosenha_Visible, edtavCusuariosenha_Enabled, 0, "text", "", 32, "chr", 1, "row", 32, -1, 0, 0, 1, 0, -1, true, "", "left", true, "HLP_Gx0030.htm");
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
            GxWebStd.gx_div_start( context, divUsuariogamguidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divUsuariogamguidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblusuariogamguidfilter_Internalname, "GUID", "", "", lblLblusuariogamguidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e171x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0030.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCusuariogamguid_Internalname, "GUID", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCusuariogamguid_Internalname, StringUtil.RTrim( AV14cUsuarioGamGuid), StringUtil.RTrim( context.localUtil.Format( AV14cUsuarioGamGuid, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCusuariogamguid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCusuariogamguid_Visible, edtavCusuariogamguid_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, 0, true, "", "left", true, "HLP_Gx0030.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e181x1_client"+"'", TempTags, "", 2, "HLP_Gx0030.htm");
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nome") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Inativo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Login") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A12UsuarioNome);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtUsuarioNome_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A52UsuarioTipo), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.BoolToStr( A53UsuarioInativo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A54UsuarioLogin);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0030.htm");
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

      protected void START1X2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Selection List Usuário", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1X0( ) ;
      }

      protected void WS1X2( )
      {
         START1X2( ) ;
         EVT1X2( ) ;
      }

      protected void EVT1X2( )
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
                              A11UsuarioId = (long)(context.localUtil.CToN( cgiGet( edtUsuarioId_Internalname), ",", "."));
                              A12UsuarioNome = cgiGet( edtUsuarioNome_Internalname);
                              cmbUsuarioTipo.Name = cmbUsuarioTipo_Internalname;
                              cmbUsuarioTipo.CurrentValue = cgiGet( cmbUsuarioTipo_Internalname);
                              A52UsuarioTipo = (short)(NumberUtil.Val( cgiGet( cmbUsuarioTipo_Internalname), "."));
                              A53UsuarioInativo = StringUtil.StrToBool( cgiGet( chkUsuarioInativo_Internalname));
                              A54UsuarioLogin = cgiGet( edtUsuarioLogin_Internalname);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E191X2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E201X2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cusuarioid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOID"), ",", ".") != Convert.ToDecimal( AV6cUsuarioId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuarionome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIONOME"), AV7cUsuarioNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuariotipo Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOTIPO"), ",", ".") != Convert.ToDecimal( AV10cUsuarioTipo )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuarioinativo Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vCUSUARIOINATIVO")) != AV11cUsuarioInativo )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuariologin Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOLOGIN"), AV12cUsuarioLogin) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuariosenha Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOSENHA"), AV13cUsuarioSenha) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cusuariogamguid Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOGAMGUID"), AV14cUsuarioGamGuid) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E211X2 ();
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

      protected void WE1X2( )
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

      protected void PA1X2( )
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
            cmbavCusuariotipo.Name = "vCUSUARIOTIPO";
            cmbavCusuariotipo.WebTags = "";
            cmbavCusuariotipo.addItem("1", "Mobile", 0);
            cmbavCusuariotipo.addItem("2", "Administrador", 0);
            if ( cmbavCusuariotipo.ItemCount > 0 )
            {
               AV10cUsuarioTipo = (short)(NumberUtil.Val( cmbavCusuariotipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV10cUsuarioTipo), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cUsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cUsuarioTipo), 4, 0)));
            }
            chkavCusuarioinativo.Name = "vCUSUARIOINATIVO";
            chkavCusuarioinativo.WebTags = "";
            chkavCusuarioinativo.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCusuarioinativo_Internalname, "TitleCaption", chkavCusuarioinativo.Caption, true);
            chkavCusuarioinativo.CheckedValue = "false";
            GXCCtl = "USUARIOTIPO_" + sGXsfl_84_idx;
            cmbUsuarioTipo.Name = GXCCtl;
            cmbUsuarioTipo.WebTags = "";
            cmbUsuarioTipo.addItem("1", "Mobile", 0);
            cmbUsuarioTipo.addItem("2", "Administrador", 0);
            if ( cmbUsuarioTipo.ItemCount > 0 )
            {
               A52UsuarioTipo = (short)(NumberUtil.Val( cmbUsuarioTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0))), "."));
            }
            GXCCtl = "USUARIOINATIVO_" + sGXsfl_84_idx;
            chkUsuarioInativo.Name = GXCCtl;
            chkUsuarioInativo.WebTags = "";
            chkUsuarioInativo.Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioInativo_Internalname, "TitleCaption", chkUsuarioInativo.Caption, !bGXsfl_84_Refreshing);
            chkUsuarioInativo.CheckedValue = "false";
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
                                        long AV6cUsuarioId ,
                                        String AV7cUsuarioNome ,
                                        short AV10cUsuarioTipo ,
                                        bool AV11cUsuarioInativo ,
                                        String AV12cUsuarioLogin ,
                                        String AV13cUsuarioSenha ,
                                        String AV14cUsuarioGamGuid )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF1X2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_USUARIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "USUARIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ".", "")));
      }

      protected void fix_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
         }
         if ( cmbavCusuariotipo.ItemCount > 0 )
         {
            AV10cUsuarioTipo = (short)(NumberUtil.Val( cmbavCusuariotipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV10cUsuarioTipo), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cUsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cUsuarioTipo), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCusuariotipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV10cUsuarioTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCusuariotipo_Internalname, "Values", cmbavCusuariotipo.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1X2( ) ;
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

      protected void RF1X2( )
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
                                                 AV7cUsuarioNome ,
                                                 AV10cUsuarioTipo ,
                                                 AV11cUsuarioInativo ,
                                                 AV12cUsuarioLogin ,
                                                 AV13cUsuarioSenha ,
                                                 AV14cUsuarioGamGuid ,
                                                 A12UsuarioNome ,
                                                 A52UsuarioTipo ,
                                                 A53UsuarioInativo ,
                                                 A54UsuarioLogin ,
                                                 A55UsuarioSenha ,
                                                 A56UsuarioGamGuid ,
                                                 AV6cUsuarioId } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG
                                                 }
            } ) ;
            lV7cUsuarioNome = StringUtil.Concat( StringUtil.RTrim( AV7cUsuarioNome), "%", "");
            lV12cUsuarioLogin = StringUtil.Concat( StringUtil.RTrim( AV12cUsuarioLogin), "%", "");
            lV13cUsuarioSenha = StringUtil.Concat( StringUtil.RTrim( AV13cUsuarioSenha), "%", "");
            lV14cUsuarioGamGuid = StringUtil.PadR( StringUtil.RTrim( AV14cUsuarioGamGuid), 40, "%");
            /* Using cursor H001X2 */
            pr_default.execute(0, new Object[] {AV6cUsuarioId, lV7cUsuarioNome, AV10cUsuarioTipo, AV11cUsuarioInativo, lV12cUsuarioLogin, lV13cUsuarioSenha, lV14cUsuarioGamGuid, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A56UsuarioGamGuid = H001X2_A56UsuarioGamGuid[0];
               A55UsuarioSenha = H001X2_A55UsuarioSenha[0];
               A54UsuarioLogin = H001X2_A54UsuarioLogin[0];
               A53UsuarioInativo = H001X2_A53UsuarioInativo[0];
               A52UsuarioTipo = H001X2_A52UsuarioTipo[0];
               A12UsuarioNome = H001X2_A12UsuarioNome[0];
               A11UsuarioId = H001X2_A11UsuarioId[0];
               /* Execute user event: Load */
               E201X2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB1X0( ) ;
         }
         bGXsfl_84_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1X2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_USUARIOID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9"), context));
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
                                              AV7cUsuarioNome ,
                                              AV10cUsuarioTipo ,
                                              AV11cUsuarioInativo ,
                                              AV12cUsuarioLogin ,
                                              AV13cUsuarioSenha ,
                                              AV14cUsuarioGamGuid ,
                                              A12UsuarioNome ,
                                              A52UsuarioTipo ,
                                              A53UsuarioInativo ,
                                              A54UsuarioLogin ,
                                              A55UsuarioSenha ,
                                              A56UsuarioGamGuid ,
                                              AV6cUsuarioId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG
                                              }
         } ) ;
         lV7cUsuarioNome = StringUtil.Concat( StringUtil.RTrim( AV7cUsuarioNome), "%", "");
         lV12cUsuarioLogin = StringUtil.Concat( StringUtil.RTrim( AV12cUsuarioLogin), "%", "");
         lV13cUsuarioSenha = StringUtil.Concat( StringUtil.RTrim( AV13cUsuarioSenha), "%", "");
         lV14cUsuarioGamGuid = StringUtil.PadR( StringUtil.RTrim( AV14cUsuarioGamGuid), 40, "%");
         /* Using cursor H001X3 */
         pr_default.execute(1, new Object[] {AV6cUsuarioId, lV7cUsuarioNome, AV10cUsuarioTipo, AV11cUsuarioInativo, lV12cUsuarioLogin, lV13cUsuarioSenha, lV14cUsuarioGamGuid});
         GRID1_nRecordCount = H001X3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioId, AV7cUsuarioNome, AV10cUsuarioTipo, AV11cUsuarioInativo, AV12cUsuarioLogin, AV13cUsuarioSenha, AV14cUsuarioGamGuid) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioId, AV7cUsuarioNome, AV10cUsuarioTipo, AV11cUsuarioInativo, AV12cUsuarioLogin, AV13cUsuarioSenha, AV14cUsuarioGamGuid) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioId, AV7cUsuarioNome, AV10cUsuarioTipo, AV11cUsuarioInativo, AV12cUsuarioLogin, AV13cUsuarioSenha, AV14cUsuarioGamGuid) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioId, AV7cUsuarioNome, AV10cUsuarioTipo, AV11cUsuarioInativo, AV12cUsuarioLogin, AV13cUsuarioSenha, AV14cUsuarioGamGuid) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cUsuarioId, AV7cUsuarioNome, AV10cUsuarioTipo, AV11cUsuarioInativo, AV12cUsuarioLogin, AV13cUsuarioSenha, AV14cUsuarioGamGuid) ;
         }
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         return (int)(0) ;
      }

      protected void STRUP1X0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E191X2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCusuarioid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCusuarioid_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCUSUARIOID");
               GX_FocusControl = edtavCusuarioid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cUsuarioId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cUsuarioId), 18, 0)));
            }
            else
            {
               AV6cUsuarioId = (long)(context.localUtil.CToN( cgiGet( edtavCusuarioid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cUsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cUsuarioId), 18, 0)));
            }
            AV7cUsuarioNome = cgiGet( edtavCusuarionome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cUsuarioNome", AV7cUsuarioNome);
            cmbavCusuariotipo.Name = cmbavCusuariotipo_Internalname;
            cmbavCusuariotipo.CurrentValue = cgiGet( cmbavCusuariotipo_Internalname);
            AV10cUsuarioTipo = (short)(NumberUtil.Val( cgiGet( cmbavCusuariotipo_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cUsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cUsuarioTipo), 4, 0)));
            AV11cUsuarioInativo = StringUtil.StrToBool( cgiGet( chkavCusuarioinativo_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsuarioInativo", AV11cUsuarioInativo);
            AV12cUsuarioLogin = cgiGet( edtavCusuariologin_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cUsuarioLogin", AV12cUsuarioLogin);
            AV13cUsuarioSenha = cgiGet( edtavCusuariosenha_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cUsuarioSenha", AV13cUsuarioSenha);
            AV14cUsuarioGamGuid = cgiGet( edtavCusuariogamguid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cUsuarioGamGuid", AV14cUsuarioGamGuid);
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOID"), ",", ".") != Convert.ToDecimal( AV6cUsuarioId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIONOME"), AV7cUsuarioNome) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCUSUARIOTIPO"), ",", ".") != Convert.ToDecimal( AV10cUsuarioTipo )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vCUSUARIOINATIVO")) != AV11cUsuarioInativo )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOLOGIN"), AV12cUsuarioLogin) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOSENHA"), AV13cUsuarioSenha) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOGAMGUID"), AV14cUsuarioGamGuid) != 0 )
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
         E191X2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E191X2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Seleção %1", "Usuário", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV9ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E201X2( )
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
         E211X2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E211X2( )
      {
         /* Enter Routine */
         AV8pUsuarioId = A11UsuarioId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8pUsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8pUsuarioId), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV8pUsuarioId});
         context.setWebReturnParmsMetadata(new Object[] {"AV8pUsuarioId"});
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
         AV8pUsuarioId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8pUsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8pUsuarioId), 18, 0)));
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
         PA1X2( ) ;
         WS1X2( ) ;
         WE1X2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019462955", true);
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
         context.AddJavascriptSource("gx0030.js", "?201892019462955", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtUsuarioId_Internalname = "USUARIOID_"+sGXsfl_84_idx;
         edtUsuarioNome_Internalname = "USUARIONOME_"+sGXsfl_84_idx;
         cmbUsuarioTipo_Internalname = "USUARIOTIPO_"+sGXsfl_84_idx;
         chkUsuarioInativo_Internalname = "USUARIOINATIVO_"+sGXsfl_84_idx;
         edtUsuarioLogin_Internalname = "USUARIOLOGIN_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtUsuarioId_Internalname = "USUARIOID_"+sGXsfl_84_fel_idx;
         edtUsuarioNome_Internalname = "USUARIONOME_"+sGXsfl_84_fel_idx;
         cmbUsuarioTipo_Internalname = "USUARIOTIPO_"+sGXsfl_84_fel_idx;
         chkUsuarioInativo_Internalname = "USUARIOINATIVO_"+sGXsfl_84_fel_idx;
         edtUsuarioLogin_Internalname = "USUARIOLOGIN_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB1X0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ",", "")))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtUsuarioNome_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioNome_Internalname, "Link", edtUsuarioNome_Link, !bGXsfl_84_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioNome_Internalname,(String)A12UsuarioNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtUsuarioNome_Link,(String)"",(String)"",(String)"",(String)edtUsuarioNome_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nome",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbUsuarioTipo.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "USUARIOTIPO_" + sGXsfl_84_idx;
               cmbUsuarioTipo.Name = GXCCtl;
               cmbUsuarioTipo.WebTags = "";
               cmbUsuarioTipo.addItem("1", "Mobile", 0);
               cmbUsuarioTipo.addItem("2", "Administrador", 0);
               if ( cmbUsuarioTipo.ItemCount > 0 )
               {
                  A52UsuarioTipo = (short)(NumberUtil.Val( cmbUsuarioTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0))), "."));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbUsuarioTipo,(String)cmbUsuarioTipo_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)),(short)1,(String)cmbUsuarioTipo_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn OptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbUsuarioTipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsuarioTipo_Internalname, "Values", (String)(cmbUsuarioTipo.ToJavascriptSource()), !bGXsfl_84_Refreshing);
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "Attribute";
            StyleString = "";
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkUsuarioInativo_Internalname,StringUtil.BoolToStr( A53UsuarioInativo),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn OptionalColumn",(String)"",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioLogin_Internalname,(String)A54UsuarioLogin,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioLogin_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"Login",(String)"left",(bool)true});
            send_integrity_lvl_hashes1X2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblusuarioidfilter_Internalname = "LBLUSUARIOIDFILTER";
         edtavCusuarioid_Internalname = "vCUSUARIOID";
         divUsuarioidfiltercontainer_Internalname = "USUARIOIDFILTERCONTAINER";
         lblLblusuarionomefilter_Internalname = "LBLUSUARIONOMEFILTER";
         edtavCusuarionome_Internalname = "vCUSUARIONOME";
         divUsuarionomefiltercontainer_Internalname = "USUARIONOMEFILTERCONTAINER";
         lblLblusuariotipofilter_Internalname = "LBLUSUARIOTIPOFILTER";
         cmbavCusuariotipo_Internalname = "vCUSUARIOTIPO";
         divUsuariotipofiltercontainer_Internalname = "USUARIOTIPOFILTERCONTAINER";
         lblLblusuarioinativofilter_Internalname = "LBLUSUARIOINATIVOFILTER";
         chkavCusuarioinativo_Internalname = "vCUSUARIOINATIVO";
         divUsuarioinativofiltercontainer_Internalname = "USUARIOINATIVOFILTERCONTAINER";
         lblLblusuariologinfilter_Internalname = "LBLUSUARIOLOGINFILTER";
         edtavCusuariologin_Internalname = "vCUSUARIOLOGIN";
         divUsuariologinfiltercontainer_Internalname = "USUARIOLOGINFILTERCONTAINER";
         lblLblusuariosenhafilter_Internalname = "LBLUSUARIOSENHAFILTER";
         edtavCusuariosenha_Internalname = "vCUSUARIOSENHA";
         divUsuariosenhafiltercontainer_Internalname = "USUARIOSENHAFILTERCONTAINER";
         lblLblusuariogamguidfilter_Internalname = "LBLUSUARIOGAMGUIDFILTER";
         edtavCusuariogamguid_Internalname = "vCUSUARIOGAMGUID";
         divUsuariogamguidfiltercontainer_Internalname = "USUARIOGAMGUIDFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtUsuarioId_Internalname = "USUARIOID";
         edtUsuarioNome_Internalname = "USUARIONOME";
         cmbUsuarioTipo_Internalname = "USUARIOTIPO";
         chkUsuarioInativo_Internalname = "USUARIOINATIVO";
         edtUsuarioLogin_Internalname = "USUARIOLOGIN";
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
         edtUsuarioLogin_Jsonclick = "";
         cmbUsuarioTipo_Jsonclick = "";
         edtUsuarioNome_Jsonclick = "";
         edtUsuarioId_Jsonclick = "";
         chkUsuarioInativo.Caption = "";
         chkavCusuarioinativo.Caption = "Inativo";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtUsuarioNome_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCusuariogamguid_Jsonclick = "";
         edtavCusuariogamguid_Enabled = 1;
         edtavCusuariogamguid_Visible = 1;
         edtavCusuariosenha_Jsonclick = "";
         edtavCusuariosenha_Enabled = 1;
         edtavCusuariosenha_Visible = 1;
         edtavCusuariologin_Jsonclick = "";
         edtavCusuariologin_Enabled = 1;
         edtavCusuariologin_Visible = 1;
         chkavCusuarioinativo.Enabled = 1;
         chkavCusuarioinativo.Visible = 1;
         cmbavCusuariotipo_Jsonclick = "";
         cmbavCusuariotipo.Enabled = 1;
         cmbavCusuariotipo.Visible = 1;
         edtavCusuarionome_Jsonclick = "";
         edtavCusuarionome_Enabled = 1;
         edtavCusuarionome_Visible = 1;
         edtavCusuarioid_Jsonclick = "";
         edtavCusuarioid_Enabled = 1;
         edtavCusuarioid_Visible = 1;
         divUsuariogamguidfiltercontainer_Class = "AdvancedContainerItem";
         divUsuariosenhafiltercontainer_Class = "AdvancedContainerItem";
         divUsuariologinfiltercontainer_Class = "AdvancedContainerItem";
         divUsuarioinativofiltercontainer_Class = "AdvancedContainerItem";
         divUsuariotipofiltercontainer_Class = "AdvancedContainerItem";
         divUsuarionomefiltercontainer_Class = "AdvancedContainerItem";
         divUsuarioidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Usuário";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioNome',fld:'vCUSUARIONOME',pic:'',nv:''},{av:'cmbavCusuariotipo'},{av:'AV10cUsuarioTipo',fld:'vCUSUARIOTIPO',pic:'ZZZ9',nv:0},{av:'AV11cUsuarioInativo',fld:'vCUSUARIOINATIVO',pic:'',nv:false},{av:'AV12cUsuarioLogin',fld:'vCUSUARIOLOGIN',pic:'',nv:''},{av:'AV13cUsuarioSenha',fld:'vCUSUARIOSENHA',pic:'',nv:''},{av:'AV14cUsuarioGamGuid',fld:'vCUSUARIOGAMGUID',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E181X1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLUSUARIOIDFILTER.CLICK","{handler:'E111X1',iparms:[{av:'divUsuarioidfiltercontainer_Class',ctrl:'USUARIOIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuarioidfiltercontainer_Class',ctrl:'USUARIOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCusuarioid_Visible',ctrl:'vCUSUARIOID',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIONOMEFILTER.CLICK","{handler:'E121X1',iparms:[{av:'divUsuarionomefiltercontainer_Class',ctrl:'USUARIONOMEFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuarionomefiltercontainer_Class',ctrl:'USUARIONOMEFILTERCONTAINER',prop:'Class'},{av:'edtavCusuarionome_Visible',ctrl:'vCUSUARIONOME',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIOTIPOFILTER.CLICK","{handler:'E131X1',iparms:[{av:'divUsuariotipofiltercontainer_Class',ctrl:'USUARIOTIPOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuariotipofiltercontainer_Class',ctrl:'USUARIOTIPOFILTERCONTAINER',prop:'Class'},{av:'cmbavCusuariotipo'}]}");
         setEventMetadata("LBLUSUARIOINATIVOFILTER.CLICK","{handler:'E141X1',iparms:[{av:'divUsuarioinativofiltercontainer_Class',ctrl:'USUARIOINATIVOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuarioinativofiltercontainer_Class',ctrl:'USUARIOINATIVOFILTERCONTAINER',prop:'Class'},{av:'chkavCusuarioinativo.Visible',ctrl:'vCUSUARIOINATIVO',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIOLOGINFILTER.CLICK","{handler:'E151X1',iparms:[{av:'divUsuariologinfiltercontainer_Class',ctrl:'USUARIOLOGINFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuariologinfiltercontainer_Class',ctrl:'USUARIOLOGINFILTERCONTAINER',prop:'Class'},{av:'edtavCusuariologin_Visible',ctrl:'vCUSUARIOLOGIN',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIOSENHAFILTER.CLICK","{handler:'E161X1',iparms:[{av:'divUsuariosenhafiltercontainer_Class',ctrl:'USUARIOSENHAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuariosenhafiltercontainer_Class',ctrl:'USUARIOSENHAFILTERCONTAINER',prop:'Class'},{av:'edtavCusuariosenha_Visible',ctrl:'vCUSUARIOSENHA',prop:'Visible'}]}");
         setEventMetadata("LBLUSUARIOGAMGUIDFILTER.CLICK","{handler:'E171X1',iparms:[{av:'divUsuariogamguidfiltercontainer_Class',ctrl:'USUARIOGAMGUIDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divUsuariogamguidfiltercontainer_Class',ctrl:'USUARIOGAMGUIDFILTERCONTAINER',prop:'Class'},{av:'edtavCusuariogamguid_Visible',ctrl:'vCUSUARIOGAMGUID',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E211X2',iparms:[{av:'A11UsuarioId',fld:'USUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[{av:'AV8pUsuarioId',fld:'vPUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioNome',fld:'vCUSUARIONOME',pic:'',nv:''},{av:'cmbavCusuariotipo'},{av:'AV10cUsuarioTipo',fld:'vCUSUARIOTIPO',pic:'ZZZ9',nv:0},{av:'AV11cUsuarioInativo',fld:'vCUSUARIOINATIVO',pic:'',nv:false},{av:'AV12cUsuarioLogin',fld:'vCUSUARIOLOGIN',pic:'',nv:''},{av:'AV13cUsuarioSenha',fld:'vCUSUARIOSENHA',pic:'',nv:''},{av:'AV14cUsuarioGamGuid',fld:'vCUSUARIOGAMGUID',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioNome',fld:'vCUSUARIONOME',pic:'',nv:''},{av:'cmbavCusuariotipo'},{av:'AV10cUsuarioTipo',fld:'vCUSUARIOTIPO',pic:'ZZZ9',nv:0},{av:'AV11cUsuarioInativo',fld:'vCUSUARIOINATIVO',pic:'',nv:false},{av:'AV12cUsuarioLogin',fld:'vCUSUARIOLOGIN',pic:'',nv:''},{av:'AV13cUsuarioSenha',fld:'vCUSUARIOSENHA',pic:'',nv:''},{av:'AV14cUsuarioGamGuid',fld:'vCUSUARIOGAMGUID',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioNome',fld:'vCUSUARIONOME',pic:'',nv:''},{av:'cmbavCusuariotipo'},{av:'AV10cUsuarioTipo',fld:'vCUSUARIOTIPO',pic:'ZZZ9',nv:0},{av:'AV11cUsuarioInativo',fld:'vCUSUARIOINATIVO',pic:'',nv:false},{av:'AV12cUsuarioLogin',fld:'vCUSUARIOLOGIN',pic:'',nv:''},{av:'AV13cUsuarioSenha',fld:'vCUSUARIOSENHA',pic:'',nv:''},{av:'AV14cUsuarioGamGuid',fld:'vCUSUARIOGAMGUID',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage',nv:0},{av:'GRID1_nEOF',nv:0},{av:'subGrid1_Rows',nv:0},{av:'AV6cUsuarioId',fld:'vCUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV7cUsuarioNome',fld:'vCUSUARIONOME',pic:'',nv:''},{av:'cmbavCusuariotipo'},{av:'AV10cUsuarioTipo',fld:'vCUSUARIOTIPO',pic:'ZZZ9',nv:0},{av:'AV11cUsuarioInativo',fld:'vCUSUARIOINATIVO',pic:'',nv:false},{av:'AV12cUsuarioLogin',fld:'vCUSUARIOLOGIN',pic:'',nv:''},{av:'AV13cUsuarioSenha',fld:'vCUSUARIOSENHA',pic:'',nv:''},{av:'AV14cUsuarioGamGuid',fld:'vCUSUARIOGAMGUID',pic:'',nv:''}],oparms:[]}");
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
         AV7cUsuarioNome = "";
         AV10cUsuarioTipo = 2;
         AV12cUsuarioLogin = "";
         AV13cUsuarioSenha = "";
         AV14cUsuarioGamGuid = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblusuarioidfilter_Jsonclick = "";
         TempTags = "";
         lblLblusuarionomefilter_Jsonclick = "";
         lblLblusuariotipofilter_Jsonclick = "";
         lblLblusuarioinativofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         lblLblusuariologinfilter_Jsonclick = "";
         lblLblusuariosenhafilter_Jsonclick = "";
         lblLblusuariogamguidfilter_Jsonclick = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A12UsuarioNome = "";
         A54UsuarioLogin = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         GXCCtl = "";
         scmdbuf = "";
         lV7cUsuarioNome = "";
         lV12cUsuarioLogin = "";
         lV13cUsuarioSenha = "";
         lV14cUsuarioGamGuid = "";
         A55UsuarioSenha = "";
         A56UsuarioGamGuid = "";
         H001X2_A56UsuarioGamGuid = new String[] {""} ;
         H001X2_A55UsuarioSenha = new String[] {""} ;
         H001X2_A54UsuarioLogin = new String[] {""} ;
         H001X2_A53UsuarioInativo = new bool[] {false} ;
         H001X2_A52UsuarioTipo = new short[1] ;
         H001X2_A12UsuarioNome = new String[] {""} ;
         H001X2_A11UsuarioId = new long[1] ;
         H001X3_AGRID1_nRecordCount = new long[1] ;
         AV9ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0030__default(),
            new Object[][] {
                new Object[] {
               H001X2_A56UsuarioGamGuid, H001X2_A55UsuarioSenha, H001X2_A54UsuarioLogin, H001X2_A53UsuarioInativo, H001X2_A52UsuarioTipo, H001X2_A12UsuarioNome, H001X2_A11UsuarioId
               }
               , new Object[] {
               H001X3_AGRID1_nRecordCount
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
      private short AV10cUsuarioTipo ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A52UsuarioTipo ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCusuarioid_Enabled ;
      private int edtavCusuarioid_Visible ;
      private int edtavCusuarionome_Visible ;
      private int edtavCusuarionome_Enabled ;
      private int edtavCusuariologin_Visible ;
      private int edtavCusuariologin_Enabled ;
      private int edtavCusuariosenha_Visible ;
      private int edtavCusuariosenha_Enabled ;
      private int edtavCusuariogamguid_Visible ;
      private int edtavCusuariogamguid_Enabled ;
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
      private long AV6cUsuarioId ;
      private long AV8pUsuarioId ;
      private long A11UsuarioId ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divUsuarioidfiltercontainer_Class ;
      private String divUsuarionomefiltercontainer_Class ;
      private String divUsuariotipofiltercontainer_Class ;
      private String divUsuarioinativofiltercontainer_Class ;
      private String divUsuariologinfiltercontainer_Class ;
      private String divUsuariosenhafiltercontainer_Class ;
      private String divUsuariogamguidfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_84_idx="0001" ;
      private String AV14cUsuarioGamGuid ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divUsuarioidfiltercontainer_Internalname ;
      private String lblLblusuarioidfilter_Internalname ;
      private String lblLblusuarioidfilter_Jsonclick ;
      private String edtavCusuarioid_Internalname ;
      private String TempTags ;
      private String edtavCusuarioid_Jsonclick ;
      private String divUsuarionomefiltercontainer_Internalname ;
      private String lblLblusuarionomefilter_Internalname ;
      private String lblLblusuarionomefilter_Jsonclick ;
      private String edtavCusuarionome_Internalname ;
      private String edtavCusuarionome_Jsonclick ;
      private String divUsuariotipofiltercontainer_Internalname ;
      private String lblLblusuariotipofilter_Internalname ;
      private String lblLblusuariotipofilter_Jsonclick ;
      private String cmbavCusuariotipo_Internalname ;
      private String cmbavCusuariotipo_Jsonclick ;
      private String divUsuarioinativofiltercontainer_Internalname ;
      private String lblLblusuarioinativofilter_Internalname ;
      private String lblLblusuarioinativofilter_Jsonclick ;
      private String chkavCusuarioinativo_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divUsuariologinfiltercontainer_Internalname ;
      private String lblLblusuariologinfilter_Internalname ;
      private String lblLblusuariologinfilter_Jsonclick ;
      private String edtavCusuariologin_Internalname ;
      private String edtavCusuariologin_Jsonclick ;
      private String divUsuariosenhafiltercontainer_Internalname ;
      private String lblLblusuariosenhafilter_Internalname ;
      private String lblLblusuariosenhafilter_Jsonclick ;
      private String edtavCusuariosenha_Internalname ;
      private String edtavCusuariosenha_Jsonclick ;
      private String divUsuariogamguidfiltercontainer_Internalname ;
      private String lblLblusuariogamguidfilter_Internalname ;
      private String lblLblusuariogamguidfilter_Jsonclick ;
      private String edtavCusuariogamguid_Internalname ;
      private String edtavCusuariogamguid_Jsonclick ;
      private String divGridtable_Internalname ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String edtavLinkselection_Link ;
      private String edtUsuarioNome_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtUsuarioId_Internalname ;
      private String edtUsuarioNome_Internalname ;
      private String cmbUsuarioTipo_Internalname ;
      private String chkUsuarioInativo_Internalname ;
      private String edtUsuarioLogin_Internalname ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String lV14cUsuarioGamGuid ;
      private String A56UsuarioGamGuid ;
      private String AV9ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtUsuarioId_Jsonclick ;
      private String edtUsuarioNome_Jsonclick ;
      private String cmbUsuarioTipo_Jsonclick ;
      private String edtUsuarioLogin_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV11cUsuarioInativo ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool A53UsuarioInativo ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_84_Refreshing=false ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7cUsuarioNome ;
      private String AV12cUsuarioLogin ;
      private String AV13cUsuarioSenha ;
      private String A12UsuarioNome ;
      private String A54UsuarioLogin ;
      private String AV17Linkselection_GXI ;
      private String lV7cUsuarioNome ;
      private String lV12cUsuarioLogin ;
      private String lV13cUsuarioSenha ;
      private String A55UsuarioSenha ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCusuariotipo ;
      private GXCheckbox chkavCusuarioinativo ;
      private GXCombobox cmbUsuarioTipo ;
      private GXCheckbox chkUsuarioInativo ;
      private IDataStoreProvider pr_default ;
      private String[] H001X2_A56UsuarioGamGuid ;
      private String[] H001X2_A55UsuarioSenha ;
      private String[] H001X2_A54UsuarioLogin ;
      private bool[] H001X2_A53UsuarioInativo ;
      private short[] H001X2_A52UsuarioTipo ;
      private String[] H001X2_A12UsuarioNome ;
      private long[] H001X2_A11UsuarioId ;
      private long[] H001X3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_pUsuarioId ;
      private GXWebForm Form ;
   }

   public class gx0030__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001X2( IGxContext context ,
                                             String AV7cUsuarioNome ,
                                             short AV10cUsuarioTipo ,
                                             bool AV11cUsuarioInativo ,
                                             String AV12cUsuarioLogin ,
                                             String AV13cUsuarioSenha ,
                                             String AV14cUsuarioGamGuid ,
                                             String A12UsuarioNome ,
                                             short A52UsuarioTipo ,
                                             bool A53UsuarioInativo ,
                                             String A54UsuarioLogin ,
                                             String A55UsuarioSenha ,
                                             String A56UsuarioGamGuid ,
                                             long AV6cUsuarioId )
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
         sSelectString = " [UsuarioGamGuid], [UsuarioSenha], [UsuarioLogin], [UsuarioInativo], [UsuarioTipo], [UsuarioNome], [UsuarioId]";
         sFromString = " FROM [Usuario] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([UsuarioId] >= @AV6cUsuarioId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cUsuarioNome)) )
         {
            sWhereString = sWhereString + " and ([UsuarioNome] like @lV7cUsuarioNome)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV10cUsuarioTipo) )
         {
            sWhereString = sWhereString + " and ([UsuarioTipo] >= @AV10cUsuarioTipo)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (false==AV11cUsuarioInativo) )
         {
            sWhereString = sWhereString + " and ([UsuarioInativo] >= @AV11cUsuarioInativo)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cUsuarioLogin)) )
         {
            sWhereString = sWhereString + " and ([UsuarioLogin] like @lV12cUsuarioLogin)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13cUsuarioSenha)) )
         {
            sWhereString = sWhereString + " and ([UsuarioSenha] like @lV13cUsuarioSenha)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14cUsuarioGamGuid)) )
         {
            sWhereString = sWhereString + " and ([UsuarioGamGuid] like @lV14cUsuarioGamGuid)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [UsuarioId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001X3( IGxContext context ,
                                             String AV7cUsuarioNome ,
                                             short AV10cUsuarioTipo ,
                                             bool AV11cUsuarioInativo ,
                                             String AV12cUsuarioLogin ,
                                             String AV13cUsuarioSenha ,
                                             String AV14cUsuarioGamGuid ,
                                             String A12UsuarioNome ,
                                             short A52UsuarioTipo ,
                                             bool A53UsuarioInativo ,
                                             String A54UsuarioLogin ,
                                             String A55UsuarioSenha ,
                                             String A56UsuarioGamGuid ,
                                             long AV6cUsuarioId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Usuario] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([UsuarioId] >= @AV6cUsuarioId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cUsuarioNome)) )
         {
            sWhereString = sWhereString + " and ([UsuarioNome] like @lV7cUsuarioNome)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV10cUsuarioTipo) )
         {
            sWhereString = sWhereString + " and ([UsuarioTipo] >= @AV10cUsuarioTipo)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (false==AV11cUsuarioInativo) )
         {
            sWhereString = sWhereString + " and ([UsuarioInativo] >= @AV11cUsuarioInativo)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cUsuarioLogin)) )
         {
            sWhereString = sWhereString + " and ([UsuarioLogin] like @lV12cUsuarioLogin)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13cUsuarioSenha)) )
         {
            sWhereString = sWhereString + " and ([UsuarioSenha] like @lV13cUsuarioSenha)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14cUsuarioGamGuid)) )
         {
            sWhereString = sWhereString + " and ([UsuarioGamGuid] like @lV14cUsuarioGamGuid)";
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
                     return conditional_H001X2(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (bool)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (bool)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] );
               case 1 :
                     return conditional_H001X3(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (bool)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (bool)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] );
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
          Object[] prmH001X2 ;
          prmH001X2 = new Object[] {
          new Object[] {"@AV6cUsuarioId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV7cUsuarioNome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV10cUsuarioTipo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cUsuarioInativo",SqlDbType.Bit,4,0} ,
          new Object[] {"@lV12cUsuarioLogin",SqlDbType.VarChar,40,0} ,
          new Object[] {"@lV13cUsuarioSenha",SqlDbType.VarChar,32,0} ,
          new Object[] {"@lV14cUsuarioGamGuid",SqlDbType.Char,40,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH001X3 ;
          prmH001X3 = new Object[] {
          new Object[] {"@AV6cUsuarioId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV7cUsuarioNome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV10cUsuarioTipo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cUsuarioInativo",SqlDbType.Bit,4,0} ,
          new Object[] {"@lV12cUsuarioLogin",SqlDbType.VarChar,40,0} ,
          new Object[] {"@lV13cUsuarioSenha",SqlDbType.VarChar,32,0} ,
          new Object[] {"@lV14cUsuarioGamGuid",SqlDbType.Char,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001X2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001X2,11,0,false,false )
             ,new CursorDef("H001X3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001X3,1,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.getBool(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
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
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                return;
       }
    }

 }

}
