/*
               File: Usuario
        Description: Usuário
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:17.79
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
using System.Runtime.Remoting;
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
   public class usuario : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action9") == 0 )
         {
            A54UsuarioLogin = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54UsuarioLogin", A54UsuarioLogin);
            A55UsuarioSenha = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55UsuarioSenha", A55UsuarioSenha);
            A52UsuarioTipo = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_9_033( A54UsuarioLogin, A55UsuarioSenha, A52UsuarioTipo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action10") == 0 )
         {
            A55UsuarioSenha = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55UsuarioSenha", A55UsuarioSenha);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_10_033( A55UsuarioSenha) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel1"+"_"+"USUARIOQUANTIDADEPONTOS") == 0 )
         {
            A11UsuarioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX1ASAUSUARIOQUANTIDADEPONTOS033( A11UsuarioId) ;
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
               AV7UsuarioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7UsuarioId), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUARIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7UsuarioId), "ZZZZZZZZZZZZZZZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
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
         cmbUsuarioTipo.Name = "USUARIOTIPO";
         cmbUsuarioTipo.WebTags = "";
         cmbUsuarioTipo.addItem("1", "Mobile", 0);
         cmbUsuarioTipo.addItem("2", "Administrador", 0);
         if ( cmbUsuarioTipo.ItemCount > 0 )
         {
            if ( (0==A52UsuarioTipo) )
            {
               A52UsuarioTipo = 2;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)));
            }
            A52UsuarioTipo = (short)(NumberUtil.Val( cmbUsuarioTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)));
         }
         chkUsuarioInativo.Name = "USUARIOINATIVO";
         chkUsuarioInativo.WebTags = "";
         chkUsuarioInativo.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioInativo_Internalname, "TitleCaption", chkUsuarioInativo.Caption, true);
         chkUsuarioInativo.CheckedValue = "false";
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Usuário", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUsuarioNome_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public usuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public usuario( IGxContext context )
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
                           long aP1_UsuarioId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7UsuarioId = aP1_UsuarioId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbUsuarioTipo = new GXCombobox();
         chkUsuarioInativo = new GXCheckbox();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
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

      protected void fix_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
         }
         if ( cmbUsuarioTipo.ItemCount > 0 )
         {
            A52UsuarioTipo = (short)(NumberUtil.Val( cmbUsuarioTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbUsuarioTipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsuarioTipo_Internalname, "Values", cmbUsuarioTipo.ToJavascriptSource(), true);
         }
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainTransaction", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioNome_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioNome_Internalname, "Nome", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioNome_Internalname, A12UsuarioNome, StringUtil.RTrim( context.localUtil.Format( A12UsuarioNome, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioNome_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Nome", "left", true, "HLP_Usuario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbUsuarioTipo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbUsuarioTipo_Internalname, "Tipo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbUsuarioTipo, cmbUsuarioTipo_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)), 1, cmbUsuarioTipo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbUsuarioTipo.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", "", "", true, "HLP_Usuario.htm");
            cmbUsuarioTipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsuarioTipo_Internalname, "Values", (String)(cmbUsuarioTipo.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioLogin_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioLogin_Internalname, "Login", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioLogin_Internalname, A54UsuarioLogin, StringUtil.RTrim( context.localUtil.Format( A54UsuarioLogin, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioLogin_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioLogin_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Login", "left", true, "HLP_Usuario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioSenha_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioSenha_Internalname, "Senha", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioSenha_Internalname, A55UsuarioSenha, StringUtil.RTrim( context.localUtil.Format( A55UsuarioSenha, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioSenha_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioSenha_Enabled, 0, "text", "", 32, "chr", 1, "row", 32, -1, 0, 0, 1, 0, -1, true, "Senha", "left", true, "HLP_Usuario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkUsuarioInativo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkUsuarioInativo_Internalname, "Inativo", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkUsuarioInativo_Internalname, StringUtil.BoolToStr( A53UsuarioInativo), "", "Inativo", 1, chkUsuarioInativo.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(45, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,45);\"");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "Fechar", bttBtntrn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "Confirmar", bttBtntrn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "Eliminar", bttBtntrn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
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
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtUsuarioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ",", "")), ((edtUsuarioId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioId_Jsonclick, 0, "Attribute", "", "", "", "", edtUsuarioId_Visible, edtUsuarioId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Usuario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11032 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A12UsuarioNome = cgiGet( edtUsuarioNome_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12UsuarioNome", A12UsuarioNome);
               cmbUsuarioTipo.CurrentValue = cgiGet( cmbUsuarioTipo_Internalname);
               A52UsuarioTipo = (short)(NumberUtil.Val( cgiGet( cmbUsuarioTipo_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)));
               A54UsuarioLogin = cgiGet( edtUsuarioLogin_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54UsuarioLogin", A54UsuarioLogin);
               A55UsuarioSenha = cgiGet( edtUsuarioSenha_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55UsuarioSenha", A55UsuarioSenha);
               A53UsuarioInativo = StringUtil.StrToBool( cgiGet( chkUsuarioInativo_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53UsuarioInativo", A53UsuarioInativo);
               A11UsuarioId = (long)(context.localUtil.CToN( cgiGet( edtUsuarioId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
               /* Read saved values. */
               Z11UsuarioId = (long)(context.localUtil.CToN( cgiGet( "Z11UsuarioId"), ",", "."));
               Z56UsuarioGamGuid = cgiGet( "Z56UsuarioGamGuid");
               Z55UsuarioSenha = cgiGet( "Z55UsuarioSenha");
               Z12UsuarioNome = cgiGet( "Z12UsuarioNome");
               Z52UsuarioTipo = (short)(context.localUtil.CToN( cgiGet( "Z52UsuarioTipo"), ",", "."));
               Z54UsuarioLogin = cgiGet( "Z54UsuarioLogin");
               Z53UsuarioInativo = StringUtil.StrToBool( cgiGet( "Z53UsuarioInativo"));
               Z57UsuarioEmail = cgiGet( "Z57UsuarioEmail");
               A56UsuarioGamGuid = cgiGet( "Z56UsuarioGamGuid");
               A57UsuarioEmail = cgiGet( "Z57UsuarioEmail");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               A59UsuarioQuantidadePontos = (long)(context.localUtil.CToN( cgiGet( "USUARIOQUANTIDADEPONTOS"), ",", "."));
               AV7UsuarioId = (long)(context.localUtil.CToN( cgiGet( "vUSUARIOID"), ",", "."));
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               A56UsuarioGamGuid = cgiGet( "USUARIOGAMGUID");
               A57UsuarioEmail = cgiGet( "USUARIOEMAIL");
               Gx_mode = cgiGet( "vMODE");
               Dvpanel_tableattributes_Objectcall = cgiGet( "DVPANEL_TABLEATTRIBUTES_Objectcall");
               Dvpanel_tableattributes_Class = cgiGet( "DVPANEL_TABLEATTRIBUTES_Class");
               Dvpanel_tableattributes_Enabled = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Enabled"));
               Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
               Dvpanel_tableattributes_Height = cgiGet( "DVPANEL_TABLEATTRIBUTES_Height");
               Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
               Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
               Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
               Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
               Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
               Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
               Dvpanel_tableattributes_Showheader = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showheader"));
               Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
               Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
               Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
               Dvpanel_tableattributes_Visible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Visible"));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Usuario";
               A52UsuarioTipo = (short)(NumberUtil.Val( cgiGet( cmbUsuarioTipo_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A52UsuarioTipo), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A57UsuarioEmail, ""));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A11UsuarioId != Z11UsuarioId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("usuario:[SecurityCheckFailed value for]"+"UsuarioTipo:"+context.localUtil.Format( (decimal)(A52UsuarioTipo), "ZZZ9"));
                  GXUtil.WriteLog("usuario:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("usuario:[SecurityCheckFailed value for]"+"UsuarioEmail:"+StringUtil.RTrim( context.localUtil.Format( A57UsuarioEmail, "")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A11UsuarioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode3 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode3;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound3 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_030( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "USUARIOID");
                        AnyError = 1;
                        GX_FocusControl = edtUsuarioId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11032 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12032 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
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

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12032 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll033( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtntrn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtntrn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes033( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_030( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls033( ) ;
            }
            else
            {
               CheckExtendedTable033( ) ;
               CloseExtendedTableCursors033( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption030( )
      {
      }

      protected void E11032( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "SeriesColaborativas");
         edtUsuarioId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioId_Visible), 5, 0)), true);
      }

      protected void E12032( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("usuarioww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM033( short GX_JID )
      {
         if ( ( GX_JID == 11 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z56UsuarioGamGuid = T00033_A56UsuarioGamGuid[0];
               Z55UsuarioSenha = T00033_A55UsuarioSenha[0];
               Z12UsuarioNome = T00033_A12UsuarioNome[0];
               Z52UsuarioTipo = T00033_A52UsuarioTipo[0];
               Z54UsuarioLogin = T00033_A54UsuarioLogin[0];
               Z53UsuarioInativo = T00033_A53UsuarioInativo[0];
               Z57UsuarioEmail = T00033_A57UsuarioEmail[0];
            }
            else
            {
               Z56UsuarioGamGuid = A56UsuarioGamGuid;
               Z55UsuarioSenha = A55UsuarioSenha;
               Z12UsuarioNome = A12UsuarioNome;
               Z52UsuarioTipo = A52UsuarioTipo;
               Z54UsuarioLogin = A54UsuarioLogin;
               Z53UsuarioInativo = A53UsuarioInativo;
               Z57UsuarioEmail = A57UsuarioEmail;
            }
         }
         if ( GX_JID == -11 )
         {
            Z11UsuarioId = A11UsuarioId;
            Z56UsuarioGamGuid = A56UsuarioGamGuid;
            Z55UsuarioSenha = A55UsuarioSenha;
            Z12UsuarioNome = A12UsuarioNome;
            Z52UsuarioTipo = A52UsuarioTipo;
            Z54UsuarioLogin = A54UsuarioLogin;
            Z53UsuarioInativo = A53UsuarioInativo;
            Z57UsuarioEmail = A57UsuarioEmail;
         }
      }

      protected void standaloneNotModal( )
      {
         cmbUsuarioTipo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsuarioTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbUsuarioTipo.Enabled), 5, 0)), true);
         edtUsuarioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioId_Enabled), 5, 0)), true);
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         cmbUsuarioTipo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsuarioTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbUsuarioTipo.Enabled), 5, 0)), true);
         edtUsuarioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioId_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7UsuarioId) )
         {
            A11UsuarioId = AV7UsuarioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtntrn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtntrn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A52UsuarioTipo) && ( Gx_BScreen == 0 ) )
         {
            A52UsuarioTipo = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            GXt_int1 = A59UsuarioQuantidadePontos;
            new obtertotalpontosconquista(context ).execute(  A11UsuarioId, out  GXt_int1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            A59UsuarioQuantidadePontos = GXt_int1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59UsuarioQuantidadePontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A59UsuarioQuantidadePontos), 18, 0)));
         }
      }

      protected void Load033( )
      {
         /* Using cursor T00034 */
         pr_default.execute(2, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound3 = 1;
            A56UsuarioGamGuid = T00034_A56UsuarioGamGuid[0];
            A55UsuarioSenha = T00034_A55UsuarioSenha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55UsuarioSenha", A55UsuarioSenha);
            A12UsuarioNome = T00034_A12UsuarioNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12UsuarioNome", A12UsuarioNome);
            A52UsuarioTipo = T00034_A52UsuarioTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)));
            A54UsuarioLogin = T00034_A54UsuarioLogin[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54UsuarioLogin", A54UsuarioLogin);
            A53UsuarioInativo = T00034_A53UsuarioInativo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53UsuarioInativo", A53UsuarioInativo);
            A57UsuarioEmail = T00034_A57UsuarioEmail[0];
            ZM033( -11) ;
         }
         pr_default.close(2);
         OnLoadActions033( ) ;
      }

      protected void OnLoadActions033( )
      {
         GXt_int1 = A59UsuarioQuantidadePontos;
         new obtertotalpontosconquista(context ).execute(  A11UsuarioId, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
         A59UsuarioQuantidadePontos = GXt_int1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59UsuarioQuantidadePontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A59UsuarioQuantidadePontos), 18, 0)));
      }

      protected void CheckExtendedTable033( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {A54UsuarioLogin, A11UsuarioId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Login"}), 1, "USUARIOLOGIN");
            AnyError = 1;
            GX_FocusControl = edtUsuarioLogin_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(3);
         GXt_int1 = A59UsuarioQuantidadePontos;
         new obtertotalpontosconquista(context ).execute(  A11UsuarioId, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
         A59UsuarioQuantidadePontos = GXt_int1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59UsuarioQuantidadePontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A59UsuarioQuantidadePontos), 18, 0)));
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A12UsuarioNome)) )
         {
            GX_msglist.addItem("Nome é obrigatório.", 1, "USUARIONOME");
            AnyError = 1;
            GX_FocusControl = edtUsuarioNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A54UsuarioLogin)) )
         {
            GX_msglist.addItem("Login é obrigatório.", 1, "USUARIOLOGIN");
            AnyError = 1;
            GX_FocusControl = edtUsuarioLogin_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A55UsuarioSenha)) )
         {
            GX_msglist.addItem("Senha é obrigatório.", 1, "USUARIOSENHA");
            AnyError = 1;
            GX_FocusControl = edtUsuarioSenha_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors033( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey033( )
      {
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound3 = 1;
         }
         else
         {
            RcdFound3 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM033( 11) ;
            RcdFound3 = 1;
            A11UsuarioId = T00033_A11UsuarioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            A56UsuarioGamGuid = T00033_A56UsuarioGamGuid[0];
            A55UsuarioSenha = T00033_A55UsuarioSenha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55UsuarioSenha", A55UsuarioSenha);
            A12UsuarioNome = T00033_A12UsuarioNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12UsuarioNome", A12UsuarioNome);
            A52UsuarioTipo = T00033_A52UsuarioTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)));
            A54UsuarioLogin = T00033_A54UsuarioLogin[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54UsuarioLogin", A54UsuarioLogin);
            A53UsuarioInativo = T00033_A53UsuarioInativo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53UsuarioInativo", A53UsuarioInativo);
            A57UsuarioEmail = T00033_A57UsuarioEmail[0];
            Z11UsuarioId = A11UsuarioId;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load033( ) ;
            if ( AnyError == 1 )
            {
               RcdFound3 = 0;
               InitializeNonKey033( ) ;
            }
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound3 = 0;
            InitializeNonKey033( ) ;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey033( ) ;
         if ( RcdFound3 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound3 = 0;
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00037_A11UsuarioId[0] < A11UsuarioId ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00037_A11UsuarioId[0] > A11UsuarioId ) ) )
            {
               A11UsuarioId = T00037_A11UsuarioId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
               RcdFound3 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void move_previous( )
      {
         RcdFound3 = 0;
         /* Using cursor T00038 */
         pr_default.execute(6, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00038_A11UsuarioId[0] > A11UsuarioId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00038_A11UsuarioId[0] < A11UsuarioId ) ) )
            {
               A11UsuarioId = T00038_A11UsuarioId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
               RcdFound3 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey033( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUsuarioNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert033( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound3 == 1 )
            {
               if ( A11UsuarioId != Z11UsuarioId )
               {
                  A11UsuarioId = Z11UsuarioId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "USUARIOID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtUsuarioNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update033( ) ;
                  GX_FocusControl = edtUsuarioNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A11UsuarioId != Z11UsuarioId )
               {
                  /* Insert record */
                  GX_FocusControl = edtUsuarioNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert033( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "USUARIOID");
                     AnyError = 1;
                     GX_FocusControl = edtUsuarioId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtUsuarioNome_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert033( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A11UsuarioId != Z11UsuarioId )
         {
            A11UsuarioId = Z11UsuarioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "USUARIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUsuarioNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {A11UsuarioId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Usuario"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z56UsuarioGamGuid, T00032_A56UsuarioGamGuid[0]) != 0 ) || ( StringUtil.StrCmp(Z55UsuarioSenha, T00032_A55UsuarioSenha[0]) != 0 ) || ( StringUtil.StrCmp(Z12UsuarioNome, T00032_A12UsuarioNome[0]) != 0 ) || ( Z52UsuarioTipo != T00032_A52UsuarioTipo[0] ) || ( StringUtil.StrCmp(Z54UsuarioLogin, T00032_A54UsuarioLogin[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z53UsuarioInativo != T00032_A53UsuarioInativo[0] ) || ( StringUtil.StrCmp(Z57UsuarioEmail, T00032_A57UsuarioEmail[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z56UsuarioGamGuid, T00032_A56UsuarioGamGuid[0]) != 0 )
               {
                  GXUtil.WriteLog("usuario:[seudo value changed for attri]"+"UsuarioGamGuid");
                  GXUtil.WriteLogRaw("Old: ",Z56UsuarioGamGuid);
                  GXUtil.WriteLogRaw("Current: ",T00032_A56UsuarioGamGuid[0]);
               }
               if ( StringUtil.StrCmp(Z55UsuarioSenha, T00032_A55UsuarioSenha[0]) != 0 )
               {
                  GXUtil.WriteLog("usuario:[seudo value changed for attri]"+"UsuarioSenha");
                  GXUtil.WriteLogRaw("Old: ",Z55UsuarioSenha);
                  GXUtil.WriteLogRaw("Current: ",T00032_A55UsuarioSenha[0]);
               }
               if ( StringUtil.StrCmp(Z12UsuarioNome, T00032_A12UsuarioNome[0]) != 0 )
               {
                  GXUtil.WriteLog("usuario:[seudo value changed for attri]"+"UsuarioNome");
                  GXUtil.WriteLogRaw("Old: ",Z12UsuarioNome);
                  GXUtil.WriteLogRaw("Current: ",T00032_A12UsuarioNome[0]);
               }
               if ( Z52UsuarioTipo != T00032_A52UsuarioTipo[0] )
               {
                  GXUtil.WriteLog("usuario:[seudo value changed for attri]"+"UsuarioTipo");
                  GXUtil.WriteLogRaw("Old: ",Z52UsuarioTipo);
                  GXUtil.WriteLogRaw("Current: ",T00032_A52UsuarioTipo[0]);
               }
               if ( StringUtil.StrCmp(Z54UsuarioLogin, T00032_A54UsuarioLogin[0]) != 0 )
               {
                  GXUtil.WriteLog("usuario:[seudo value changed for attri]"+"UsuarioLogin");
                  GXUtil.WriteLogRaw("Old: ",Z54UsuarioLogin);
                  GXUtil.WriteLogRaw("Current: ",T00032_A54UsuarioLogin[0]);
               }
               if ( Z53UsuarioInativo != T00032_A53UsuarioInativo[0] )
               {
                  GXUtil.WriteLog("usuario:[seudo value changed for attri]"+"UsuarioInativo");
                  GXUtil.WriteLogRaw("Old: ",Z53UsuarioInativo);
                  GXUtil.WriteLogRaw("Current: ",T00032_A53UsuarioInativo[0]);
               }
               if ( StringUtil.StrCmp(Z57UsuarioEmail, T00032_A57UsuarioEmail[0]) != 0 )
               {
                  GXUtil.WriteLog("usuario:[seudo value changed for attri]"+"UsuarioEmail");
                  GXUtil.WriteLogRaw("Old: ",Z57UsuarioEmail);
                  GXUtil.WriteLogRaw("Current: ",T00032_A57UsuarioEmail[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Usuario"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM033( 0) ;
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00039 */
                     pr_default.execute(7, new Object[] {A56UsuarioGamGuid, A55UsuarioSenha, A12UsuarioNome, A52UsuarioTipo, A54UsuarioLogin, A53UsuarioInativo, A57UsuarioEmail});
                     A11UsuarioId = T00039_A11UsuarioId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Usuario") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption030( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load033( ) ;
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void Update033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000310 */
                     pr_default.execute(8, new Object[] {A56UsuarioGamGuid, A55UsuarioSenha, A12UsuarioNome, A52UsuarioTipo, A54UsuarioLogin, A53UsuarioInativo, A57UsuarioEmail, A11UsuarioId});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Usuario") ;
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Usuario"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate033( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void DeferredUpdate033( )
      {
      }

      protected void delete( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls033( ) ;
            AfterConfirm033( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete033( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000311 */
                  pr_default.execute(9, new Object[] {A11UsuarioId});
                  pr_default.close(9);
                  dsDefault.SmartCacheProvider.SetUpdated("Usuario") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode3 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel033( ) ;
         Gx_mode = sMode3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls033( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            GXt_int1 = A59UsuarioQuantidadePontos;
            new obtertotalpontosconquista(context ).execute(  A11UsuarioId, out  GXt_int1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            A59UsuarioQuantidadePontos = GXt_int1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59UsuarioQuantidadePontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A59UsuarioQuantidadePontos), 18, 0)));
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000312 */
            pr_default.execute(10, new Object[] {A11UsuarioId});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário recomendação episódios"+" ("+"Usuário recomendação de episódio destino"+")"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
            /* Using cursor T000313 */
            pr_default.execute(11, new Object[] {A11UsuarioId});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário recomendação episódios"+" ("+"Usuário recomendação de episódio origem"+")"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
            /* Using cursor T000314 */
            pr_default.execute(12, new Object[] {A11UsuarioId});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário recomendação série"+" ("+"Usuário recomendação de série destino"+")"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
            /* Using cursor T000315 */
            pr_default.execute(13, new Object[] {A11UsuarioId});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário recomendação série"+" ("+"Usuario recomendação de série origem"+")"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
            /* Using cursor T000316 */
            pr_default.execute(14, new Object[] {A11UsuarioId});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário conquista"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(14);
            /* Using cursor T000317 */
            pr_default.execute(15, new Object[] {A11UsuarioId});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Notificação"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
            /* Using cursor T000318 */
            pr_default.execute(16, new Object[] {A11UsuarioId});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário episódio"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(16);
            /* Using cursor T000319 */
            pr_default.execute(17, new Object[] {A11UsuarioId});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário série"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(17);
         }
      }

      protected void EndLevel033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete033( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_gam.commit( "Usuario");
            pr_default.commit( "Usuario");
            if ( AnyError == 0 )
            {
               ConfirmValues030( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_gam.rollback( "Usuario");
            pr_default.rollback( "Usuario");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart033( )
      {
         /* Scan By routine */
         /* Using cursor T000320 */
         pr_default.execute(18);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound3 = 1;
            A11UsuarioId = T000320_A11UsuarioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext033( )
      {
         /* Scan next routine */
         pr_default.readNext(18);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound3 = 1;
            A11UsuarioId = T000320_A11UsuarioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
         }
      }

      protected void ScanEnd033( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm033( )
      {
         /* After Confirm Rules */
         if ( A52UsuarioTipo == 1 )
         {
            new criarusuariogam(context ).execute(  A54UsuarioLogin,  A55UsuarioSenha, out  A56UsuarioGamGuid) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54UsuarioLogin", A54UsuarioLogin);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55UsuarioSenha", A55UsuarioSenha);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56UsuarioGamGuid", A56UsuarioGamGuid);
         }
         if ( StringUtil.Len( A55UsuarioSenha) != 32 )
         {
            new gerarmd5(context ).execute(  A55UsuarioSenha, out  A55UsuarioSenha) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55UsuarioSenha", A55UsuarioSenha);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55UsuarioSenha", A55UsuarioSenha);
         }
      }

      protected void BeforeInsert033( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate033( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete033( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete033( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate033( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes033( )
      {
         edtUsuarioNome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioNome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioNome_Enabled), 5, 0)), true);
         cmbUsuarioTipo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsuarioTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbUsuarioTipo.Enabled), 5, 0)), true);
         edtUsuarioLogin_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioLogin_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioLogin_Enabled), 5, 0)), true);
         edtUsuarioSenha_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioSenha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioSenha_Enabled), 5, 0)), true);
         chkUsuarioInativo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioInativo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkUsuarioInativo.Enabled), 5, 0)), true);
         edtUsuarioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioId_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes033( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues030( )
      {
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
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 121631), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxcfg.js", "?20189251961937", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("usuario.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7UsuarioId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Usuario";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A52UsuarioTipo), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A57UsuarioEmail, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("usuario:[SendSecurityCheck value for]"+"UsuarioTipo:"+context.localUtil.Format( (decimal)(A52UsuarioTipo), "ZZZ9"));
         GXUtil.WriteLog("usuario:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("usuario:[SendSecurityCheck value for]"+"UsuarioEmail:"+StringUtil.RTrim( context.localUtil.Format( A57UsuarioEmail, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z11UsuarioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11UsuarioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z56UsuarioGamGuid", StringUtil.RTrim( Z56UsuarioGamGuid));
         GxWebStd.gx_hidden_field( context, "Z55UsuarioSenha", Z55UsuarioSenha);
         GxWebStd.gx_hidden_field( context, "Z12UsuarioNome", Z12UsuarioNome);
         GxWebStd.gx_hidden_field( context, "Z52UsuarioTipo", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z52UsuarioTipo), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z54UsuarioLogin", Z54UsuarioLogin);
         GxWebStd.gx_boolean_hidden_field( context, "Z53UsuarioInativo", Z53UsuarioInativo);
         GxWebStd.gx_hidden_field( context, "Z57UsuarioEmail", Z57UsuarioEmail);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "USUARIOQUANTIDADEPONTOS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A59UsuarioQuantidadePontos), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUARIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7UsuarioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUARIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7UsuarioId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "USUARIOGAMGUID", StringUtil.RTrim( A56UsuarioGamGuid));
         GxWebStd.gx_hidden_field( context, "USUARIOEMAIL", A57UsuarioEmail);
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Objectcall", StringUtil.RTrim( Dvpanel_tableattributes_Objectcall));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Enabled", StringUtil.BoolToStr( Dvpanel_tableattributes_Enabled));
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
         SendSecurityToken(sPrefix);
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

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
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
         return formatLink("usuario.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7UsuarioId) ;
      }

      public override String GetPgmname( )
      {
         return "Usuario" ;
      }

      public override String GetPgmdesc( )
      {
         return "Usuário" ;
      }

      protected void InitializeNonKey033( )
      {
         A56UsuarioGamGuid = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56UsuarioGamGuid", A56UsuarioGamGuid);
         A55UsuarioSenha = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55UsuarioSenha", A55UsuarioSenha);
         A59UsuarioQuantidadePontos = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59UsuarioQuantidadePontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A59UsuarioQuantidadePontos), 18, 0)));
         A12UsuarioNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12UsuarioNome", A12UsuarioNome);
         A54UsuarioLogin = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54UsuarioLogin", A54UsuarioLogin);
         A53UsuarioInativo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53UsuarioInativo", A53UsuarioInativo);
         A57UsuarioEmail = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57UsuarioEmail", A57UsuarioEmail);
         A52UsuarioTipo = 2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)));
         Z56UsuarioGamGuid = "";
         Z55UsuarioSenha = "";
         Z12UsuarioNome = "";
         Z52UsuarioTipo = 0;
         Z54UsuarioLogin = "";
         Z53UsuarioInativo = false;
         Z57UsuarioEmail = "";
      }

      protected void InitAll033( )
      {
         A11UsuarioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
         InitializeNonKey033( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A52UsuarioTipo = i52UsuarioTipo;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A52UsuarioTipo), 4, 0)));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20189251961961", true);
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
         context.AddJavascriptSource("usuario.js", "?20189251961962", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtUsuarioNome_Internalname = "USUARIONOME";
         cmbUsuarioTipo_Internalname = "USUARIOTIPO";
         edtUsuarioLogin_Internalname = "USUARIOLOGIN";
         edtUsuarioSenha_Internalname = "USUARIOSENHA";
         chkUsuarioInativo_Internalname = "USUARIOINATIVO";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtUsuarioId_Internalname = "USUARIOID";
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
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "Informações Gerais";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Usuário";
         edtUsuarioId_Jsonclick = "";
         edtUsuarioId_Enabled = 0;
         edtUsuarioId_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         chkUsuarioInativo.Enabled = 1;
         edtUsuarioSenha_Jsonclick = "";
         edtUsuarioSenha_Enabled = 1;
         edtUsuarioLogin_Jsonclick = "";
         edtUsuarioLogin_Enabled = 1;
         cmbUsuarioTipo_Jsonclick = "";
         cmbUsuarioTipo.Enabled = 0;
         edtUsuarioNome_Jsonclick = "";
         edtUsuarioNome_Enabled = 1;
         chkUsuarioInativo.Caption = "Inativo";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GX1ASAUSUARIOQUANTIDADEPONTOS033( long A11UsuarioId )
      {
         GXt_int1 = A59UsuarioQuantidadePontos;
         new obtertotalpontosconquista(context ).execute(  A11UsuarioId, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
         A59UsuarioQuantidadePontos = GXt_int1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59UsuarioQuantidadePontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A59UsuarioQuantidadePontos), 18, 0)));
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A59UsuarioQuantidadePontos), 18, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void XC_9_033( String A54UsuarioLogin ,
                               String A55UsuarioSenha ,
                               short A52UsuarioTipo )
      {
         if ( A52UsuarioTipo == 1 )
         {
            new criarusuariogam(context ).execute(  A54UsuarioLogin,  A55UsuarioSenha, out  A56UsuarioGamGuid) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54UsuarioLogin", A54UsuarioLogin);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55UsuarioSenha", A55UsuarioSenha);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56UsuarioGamGuid", A56UsuarioGamGuid);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A56UsuarioGamGuid))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      protected void XC_10_033( String A55UsuarioSenha )
      {
         if ( StringUtil.Len( A55UsuarioSenha) != 32 )
         {
            new gerarmd5(context ).execute(  A55UsuarioSenha, out  A55UsuarioSenha) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55UsuarioSenha", A55UsuarioSenha);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55UsuarioSenha", A55UsuarioSenha);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A55UsuarioSenha)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      public void Valid_Usuarioid( long GX_Parm1 ,
                                   long GX_Parm2 )
      {
         A11UsuarioId = GX_Parm1;
         A59UsuarioQuantidadePontos = GX_Parm2;
         GXt_int1 = A59UsuarioQuantidadePontos;
         new obtertotalpontosconquista(context ).execute(  A11UsuarioId, out  GXt_int1) ;
         A59UsuarioQuantidadePontos = GXt_int1;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A59UsuarioQuantidadePontos), 18, 0, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Usuariologin( String GX_Parm1 ,
                                      long GX_Parm2 )
      {
         A54UsuarioLogin = GX_Parm1;
         A11UsuarioId = GX_Parm2;
         /* Using cursor T000321 */
         pr_default.execute(19, new Object[] {A54UsuarioLogin, A11UsuarioId});
         if ( (pr_default.getStatus(19) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Login"}), 1, "USUARIOLOGIN");
            AnyError = 1;
            GX_FocusControl = edtUsuarioLogin_Internalname;
         }
         pr_default.close(19);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A54UsuarioLogin)) )
         {
            GX_msglist.addItem("Login é obrigatório.", 1, "USUARIOLOGIN");
            AnyError = 1;
            GX_FocusControl = edtUsuarioLogin_Internalname;
         }
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7UsuarioId',fld:'vUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7UsuarioId',fld:'vUSUARIOID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0},{av:'cmbUsuarioTipo'},{av:'A52UsuarioTipo',fld:'USUARIOTIPO',pic:'ZZZ9',nv:0},{av:'A57UsuarioEmail',fld:'USUARIOEMAIL',pic:'',nv:''}],oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12032',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:'',nv:null}],oparms:[]}");
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
         pr_default.close(1);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z56UsuarioGamGuid = "";
         Z55UsuarioSenha = "";
         Z12UsuarioNome = "";
         Z54UsuarioLogin = "";
         Z57UsuarioEmail = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A54UsuarioLogin = "";
         A55UsuarioSenha = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         A12UsuarioNome = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A56UsuarioGamGuid = "";
         A57UsuarioEmail = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode3 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         T00034_A11UsuarioId = new long[1] ;
         T00034_A56UsuarioGamGuid = new String[] {""} ;
         T00034_A55UsuarioSenha = new String[] {""} ;
         T00034_A12UsuarioNome = new String[] {""} ;
         T00034_A52UsuarioTipo = new short[1] ;
         T00034_A54UsuarioLogin = new String[] {""} ;
         T00034_A53UsuarioInativo = new bool[] {false} ;
         T00034_A57UsuarioEmail = new String[] {""} ;
         T00035_A54UsuarioLogin = new String[] {""} ;
         T00036_A11UsuarioId = new long[1] ;
         T00033_A11UsuarioId = new long[1] ;
         T00033_A56UsuarioGamGuid = new String[] {""} ;
         T00033_A55UsuarioSenha = new String[] {""} ;
         T00033_A12UsuarioNome = new String[] {""} ;
         T00033_A52UsuarioTipo = new short[1] ;
         T00033_A54UsuarioLogin = new String[] {""} ;
         T00033_A53UsuarioInativo = new bool[] {false} ;
         T00033_A57UsuarioEmail = new String[] {""} ;
         T00037_A11UsuarioId = new long[1] ;
         T00038_A11UsuarioId = new long[1] ;
         T00032_A11UsuarioId = new long[1] ;
         T00032_A56UsuarioGamGuid = new String[] {""} ;
         T00032_A55UsuarioSenha = new String[] {""} ;
         T00032_A12UsuarioNome = new String[] {""} ;
         T00032_A52UsuarioTipo = new short[1] ;
         T00032_A54UsuarioLogin = new String[] {""} ;
         T00032_A53UsuarioInativo = new bool[] {false} ;
         T00032_A57UsuarioEmail = new String[] {""} ;
         T00039_A11UsuarioId = new long[1] ;
         T000312_A37UsuarioRecomendacaoEpisodioId = new long[1] ;
         T000313_A37UsuarioRecomendacaoEpisodioId = new long[1] ;
         T000314_A32UsuarioRecomendacaoSerieId = new long[1] ;
         T000315_A32UsuarioRecomendacaoSerieId = new long[1] ;
         T000316_A30UsuarioConquistaId = new long[1] ;
         T000317_A23NotificacaoId = new long[1] ;
         T000318_A18UsuarioEpisodioId = new long[1] ;
         T000319_A13UsuarioSerieId = new long[1] ;
         T000320_A11UsuarioId = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000321_A54UsuarioLogin = new String[] {""} ;
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.usuario__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuario__default(),
            new Object[][] {
                new Object[] {
               T00032_A11UsuarioId, T00032_A56UsuarioGamGuid, T00032_A55UsuarioSenha, T00032_A12UsuarioNome, T00032_A52UsuarioTipo, T00032_A54UsuarioLogin, T00032_A53UsuarioInativo, T00032_A57UsuarioEmail
               }
               , new Object[] {
               T00033_A11UsuarioId, T00033_A56UsuarioGamGuid, T00033_A55UsuarioSenha, T00033_A12UsuarioNome, T00033_A52UsuarioTipo, T00033_A54UsuarioLogin, T00033_A53UsuarioInativo, T00033_A57UsuarioEmail
               }
               , new Object[] {
               T00034_A11UsuarioId, T00034_A56UsuarioGamGuid, T00034_A55UsuarioSenha, T00034_A12UsuarioNome, T00034_A52UsuarioTipo, T00034_A54UsuarioLogin, T00034_A53UsuarioInativo, T00034_A57UsuarioEmail
               }
               , new Object[] {
               T00035_A54UsuarioLogin
               }
               , new Object[] {
               T00036_A11UsuarioId
               }
               , new Object[] {
               T00037_A11UsuarioId
               }
               , new Object[] {
               T00038_A11UsuarioId
               }
               , new Object[] {
               T00039_A11UsuarioId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000312_A37UsuarioRecomendacaoEpisodioId
               }
               , new Object[] {
               T000313_A37UsuarioRecomendacaoEpisodioId
               }
               , new Object[] {
               T000314_A32UsuarioRecomendacaoSerieId
               }
               , new Object[] {
               T000315_A32UsuarioRecomendacaoSerieId
               }
               , new Object[] {
               T000316_A30UsuarioConquistaId
               }
               , new Object[] {
               T000317_A23NotificacaoId
               }
               , new Object[] {
               T000318_A18UsuarioEpisodioId
               }
               , new Object[] {
               T000319_A13UsuarioSerieId
               }
               , new Object[] {
               T000320_A11UsuarioId
               }
               , new Object[] {
               T000321_A54UsuarioLogin
               }
            }
         );
         Z52UsuarioTipo = 2;
         i52UsuarioTipo = 2;
         A52UsuarioTipo = 2;
      }

      private short Z52UsuarioTipo ;
      private short GxWebError ;
      private short A52UsuarioTipo ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Gx_BScreen ;
      private short RcdFound3 ;
      private short GX_JID ;
      private short gxajaxcallmode ;
      private short i52UsuarioTipo ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtUsuarioNome_Enabled ;
      private int edtUsuarioLogin_Enabled ;
      private int edtUsuarioSenha_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtUsuarioId_Enabled ;
      private int edtUsuarioId_Visible ;
      private int idxLst ;
      private long wcpOAV7UsuarioId ;
      private long Z11UsuarioId ;
      private long A11UsuarioId ;
      private long AV7UsuarioId ;
      private long A59UsuarioQuantidadePontos ;
      private long GXt_int1 ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z56UsuarioGamGuid ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String chkUsuarioInativo_Internalname ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUsuarioNome_Internalname ;
      private String cmbUsuarioTipo_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String TempTags ;
      private String edtUsuarioNome_Jsonclick ;
      private String cmbUsuarioTipo_Jsonclick ;
      private String edtUsuarioLogin_Internalname ;
      private String edtUsuarioLogin_Jsonclick ;
      private String edtUsuarioSenha_Internalname ;
      private String edtUsuarioSenha_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtUsuarioId_Internalname ;
      private String edtUsuarioId_Jsonclick ;
      private String A56UsuarioGamGuid ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Height ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode3 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_tableattributes_Internalname ;
      private bool Z53UsuarioInativo ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A53UsuarioInativo ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z55UsuarioSenha ;
      private String Z12UsuarioNome ;
      private String Z54UsuarioLogin ;
      private String Z57UsuarioEmail ;
      private String A54UsuarioLogin ;
      private String A55UsuarioSenha ;
      private String A12UsuarioNome ;
      private String A57UsuarioEmail ;
      private IGxSession AV12WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbUsuarioTipo ;
      private GXCheckbox chkUsuarioInativo ;
      private IDataStoreProvider pr_default ;
      private long[] T00034_A11UsuarioId ;
      private String[] T00034_A56UsuarioGamGuid ;
      private String[] T00034_A55UsuarioSenha ;
      private String[] T00034_A12UsuarioNome ;
      private short[] T00034_A52UsuarioTipo ;
      private String[] T00034_A54UsuarioLogin ;
      private bool[] T00034_A53UsuarioInativo ;
      private String[] T00034_A57UsuarioEmail ;
      private String[] T00035_A54UsuarioLogin ;
      private long[] T00036_A11UsuarioId ;
      private long[] T00033_A11UsuarioId ;
      private String[] T00033_A56UsuarioGamGuid ;
      private String[] T00033_A55UsuarioSenha ;
      private String[] T00033_A12UsuarioNome ;
      private short[] T00033_A52UsuarioTipo ;
      private String[] T00033_A54UsuarioLogin ;
      private bool[] T00033_A53UsuarioInativo ;
      private String[] T00033_A57UsuarioEmail ;
      private long[] T00037_A11UsuarioId ;
      private long[] T00038_A11UsuarioId ;
      private long[] T00032_A11UsuarioId ;
      private String[] T00032_A56UsuarioGamGuid ;
      private String[] T00032_A55UsuarioSenha ;
      private String[] T00032_A12UsuarioNome ;
      private short[] T00032_A52UsuarioTipo ;
      private String[] T00032_A54UsuarioLogin ;
      private bool[] T00032_A53UsuarioInativo ;
      private String[] T00032_A57UsuarioEmail ;
      private long[] T00039_A11UsuarioId ;
      private long[] T000312_A37UsuarioRecomendacaoEpisodioId ;
      private long[] T000313_A37UsuarioRecomendacaoEpisodioId ;
      private long[] T000314_A32UsuarioRecomendacaoSerieId ;
      private long[] T000315_A32UsuarioRecomendacaoSerieId ;
      private long[] T000316_A30UsuarioConquistaId ;
      private long[] T000317_A23NotificacaoId ;
      private long[] T000318_A18UsuarioEpisodioId ;
      private long[] T000319_A13UsuarioSerieId ;
      private IDataStoreProvider pr_gam ;
      private long[] T000320_A11UsuarioId ;
      private String[] T000321_A54UsuarioLogin ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
   }

   public class usuario__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class usuario__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
       ,new ForEachCursor(def[3])
       ,new ForEachCursor(def[4])
       ,new ForEachCursor(def[5])
       ,new ForEachCursor(def[6])
       ,new ForEachCursor(def[7])
       ,new UpdateCursor(def[8])
       ,new UpdateCursor(def[9])
       ,new ForEachCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
       ,new ForEachCursor(def[15])
       ,new ForEachCursor(def[16])
       ,new ForEachCursor(def[17])
       ,new ForEachCursor(def[18])
       ,new ForEachCursor(def[19])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00034 ;
        prmT00034 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00035 ;
        prmT00035 = new Object[] {
        new Object[] {"@UsuarioLogin",SqlDbType.VarChar,40,0} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00036 ;
        prmT00036 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00033 ;
        prmT00033 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00037 ;
        prmT00037 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00038 ;
        prmT00038 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00032 ;
        prmT00032 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00039 ;
        prmT00039 = new Object[] {
        new Object[] {"@UsuarioGamGuid",SqlDbType.Char,40,0} ,
        new Object[] {"@UsuarioSenha",SqlDbType.VarChar,32,0} ,
        new Object[] {"@UsuarioNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@UsuarioTipo",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@UsuarioLogin",SqlDbType.VarChar,40,0} ,
        new Object[] {"@UsuarioInativo",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioEmail",SqlDbType.VarChar,100,0}
        } ;
        Object[] prmT000310 ;
        prmT000310 = new Object[] {
        new Object[] {"@UsuarioGamGuid",SqlDbType.Char,40,0} ,
        new Object[] {"@UsuarioSenha",SqlDbType.VarChar,32,0} ,
        new Object[] {"@UsuarioNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@UsuarioTipo",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@UsuarioLogin",SqlDbType.VarChar,40,0} ,
        new Object[] {"@UsuarioInativo",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioEmail",SqlDbType.VarChar,100,0} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000311 ;
        prmT000311 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000312 ;
        prmT000312 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000313 ;
        prmT000313 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000314 ;
        prmT000314 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000315 ;
        prmT000315 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000316 ;
        prmT000316 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000317 ;
        prmT000317 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000318 ;
        prmT000318 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000319 ;
        prmT000319 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000320 ;
        prmT000320 = new Object[] {
        } ;
        Object[] prmT000321 ;
        prmT000321 = new Object[] {
        new Object[] {"@UsuarioLogin",SqlDbType.VarChar,40,0} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00032", "SELECT [UsuarioId], [UsuarioGamGuid], [UsuarioSenha], [UsuarioNome], [UsuarioTipo], [UsuarioLogin], [UsuarioInativo], [UsuarioEmail] FROM [Usuario] WITH (UPDLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1,0,true,false )
           ,new CursorDef("T00033", "SELECT [UsuarioId], [UsuarioGamGuid], [UsuarioSenha], [UsuarioNome], [UsuarioTipo], [UsuarioLogin], [UsuarioInativo], [UsuarioEmail] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1,0,true,false )
           ,new CursorDef("T00034", "SELECT TM1.[UsuarioId], TM1.[UsuarioGamGuid], TM1.[UsuarioSenha], TM1.[UsuarioNome], TM1.[UsuarioTipo], TM1.[UsuarioLogin], TM1.[UsuarioInativo], TM1.[UsuarioEmail] FROM [Usuario] TM1 WITH (NOLOCK) WHERE TM1.[UsuarioId] = @UsuarioId ORDER BY TM1.[UsuarioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,100,0,true,false )
           ,new CursorDef("T00035", "SELECT [UsuarioLogin] FROM [Usuario] WITH (NOLOCK) WHERE ([UsuarioLogin] = @UsuarioLogin) AND (Not ( [UsuarioId] = @UsuarioId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,1,0,true,false )
           ,new CursorDef("T00036", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,1,0,true,false )
           ,new CursorDef("T00037", "SELECT TOP 1 [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE ( [UsuarioId] > @UsuarioId) ORDER BY [UsuarioId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,1,0,true,true )
           ,new CursorDef("T00038", "SELECT TOP 1 [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE ( [UsuarioId] < @UsuarioId) ORDER BY [UsuarioId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00038,1,0,true,true )
           ,new CursorDef("T00039", "INSERT INTO [Usuario]([UsuarioGamGuid], [UsuarioSenha], [UsuarioNome], [UsuarioTipo], [UsuarioLogin], [UsuarioInativo], [UsuarioEmail]) VALUES(@UsuarioGamGuid, @UsuarioSenha, @UsuarioNome, @UsuarioTipo, @UsuarioLogin, @UsuarioInativo, @UsuarioEmail); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT00039)
           ,new CursorDef("T000310", "UPDATE [Usuario] SET [UsuarioGamGuid]=@UsuarioGamGuid, [UsuarioSenha]=@UsuarioSenha, [UsuarioNome]=@UsuarioNome, [UsuarioTipo]=@UsuarioTipo, [UsuarioLogin]=@UsuarioLogin, [UsuarioInativo]=@UsuarioInativo, [UsuarioEmail]=@UsuarioEmail  WHERE [UsuarioId] = @UsuarioId", GxErrorMask.GX_NOMASK,prmT000310)
           ,new CursorDef("T000311", "DELETE FROM [Usuario]  WHERE [UsuarioId] = @UsuarioId", GxErrorMask.GX_NOMASK,prmT000311)
           ,new CursorDef("T000312", "SELECT TOP 1 [UsuarioRecomendacaoEpisodioId] FROM [UsuarioRecomendacaoEpisodio] WITH (NOLOCK) WHERE [UsuarioRecomendacaoEpisodioDes] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000312,1,0,true,true )
           ,new CursorDef("T000313", "SELECT TOP 1 [UsuarioRecomendacaoEpisodioId] FROM [UsuarioRecomendacaoEpisodio] WITH (NOLOCK) WHERE [UsuarioRecomendacaoEpisodioOri] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000313,1,0,true,true )
           ,new CursorDef("T000314", "SELECT TOP 1 [UsuarioRecomendacaoSerieId] FROM [UsuarioRecomendacaoSerie] WITH (NOLOCK) WHERE [UsuarioRecomendacaoSerieDestin] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000314,1,0,true,true )
           ,new CursorDef("T000315", "SELECT TOP 1 [UsuarioRecomendacaoSerieId] FROM [UsuarioRecomendacaoSerie] WITH (NOLOCK) WHERE [UsuarioRecomendacaoSerieOrigem] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000315,1,0,true,true )
           ,new CursorDef("T000316", "SELECT TOP 1 [UsuarioConquistaId] FROM [UsuarioConquista] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000316,1,0,true,true )
           ,new CursorDef("T000317", "SELECT TOP 1 [NotificacaoId] FROM [Notificacao] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000317,1,0,true,true )
           ,new CursorDef("T000318", "SELECT TOP 1 [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000318,1,0,true,true )
           ,new CursorDef("T000319", "SELECT TOP 1 [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000319,1,0,true,true )
           ,new CursorDef("T000320", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) ORDER BY [UsuarioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000320,100,0,true,false )
           ,new CursorDef("T000321", "SELECT [UsuarioLogin] FROM [Usuario] WITH (NOLOCK) WHERE ([UsuarioLogin] = @UsuarioLogin) AND (Not ( [UsuarioId] = @UsuarioId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000321,1,0,true,false )
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
              ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 10 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 12 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 13 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 14 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 15 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 16 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 17 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 18 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 19 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
           case 0 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 2 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (short)parms[3]);
              stmt.SetParameter(5, (String)parms[4]);
              stmt.SetParameter(6, (bool)parms[5]);
              stmt.SetParameter(7, (String)parms[6]);
              return;
           case 8 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (short)parms[3]);
              stmt.SetParameter(5, (String)parms[4]);
              stmt.SetParameter(6, (bool)parms[5]);
              stmt.SetParameter(7, (String)parms[6]);
              stmt.SetParameter(8, (long)parms[7]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 10 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 11 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 14 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 15 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 16 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 17 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 19 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
     }
  }

}

}
