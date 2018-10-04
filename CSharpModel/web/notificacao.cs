/*
               File: Notificacao
        Description: Notificação
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:26.1
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
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class notificacao : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A11UsuarioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_5( A11UsuarioId) ;
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
         cmbNotificacaoTipo.Name = "NOTIFICACAOTIPO";
         cmbNotificacaoTipo.WebTags = "";
         cmbNotificacaoTipo.addItem("1", "Conquista", 0);
         if ( cmbNotificacaoTipo.ItemCount > 0 )
         {
            A24NotificacaoTipo = (short)(NumberUtil.Val( cmbNotificacaoTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24NotificacaoTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0)));
         }
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
            Form.Meta.addItem("description", "Notificação", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtNotificacaoId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public notificacao( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public notificacao( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbNotificacaoTipo = new GXCombobox();
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
         if ( cmbNotificacaoTipo.ItemCount > 0 )
         {
            A24NotificacaoTipo = (short)(NumberUtil.Val( cmbNotificacaoTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24NotificacaoTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbNotificacaoTipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNotificacaoTipo_Internalname, "Values", cmbNotificacaoTipo.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "Container FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Notificação", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Selecionar", bttBtn_select_Jsonclick, 4, "Selecionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0060.aspx"+"',["+"{Ctrl:gx.dom.el('"+"NOTIFICACAOID"+"'), id:'"+"NOTIFICACAOID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtNotificacaoId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtNotificacaoId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtNotificacaoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A23NotificacaoId), 18, 0, ",", "")), ((edtNotificacaoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A23NotificacaoId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A23NotificacaoId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtNotificacaoId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtNotificacaoId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ",", "")), ((edtUsuarioId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Notificacao.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_11_Internalname, sImgUrl, imgprompt_11_Link, "", "", context.GetTheme( ), imgprompt_11_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbNotificacaoTipo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbNotificacaoTipo_Internalname, "de notificação", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbNotificacaoTipo, cmbNotificacaoTipo_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0)), 1, cmbNotificacaoTipo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbNotificacaoTipo.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,38);\"", "", true, "HLP_Notificacao.htm");
            cmbNotificacaoTipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNotificacaoTipo_Internalname, "Values", (String)(cmbNotificacaoTipo.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtNotificacaoTexto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtNotificacaoTexto_Internalname, "Texto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtNotificacaoTexto_Internalname, A25NotificacaoTexto, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,43);\"", 0, 1, edtNotificacaoTexto_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "Comentario", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtNotificacaoLigacaoId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtNotificacaoLigacaoId_Internalname, "de ligação", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtNotificacaoLigacaoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A61NotificacaoLigacaoId), 18, 0, ",", "")), ((edtNotificacaoLigacaoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A61NotificacaoLigacaoId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A61NotificacaoLigacaoId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtNotificacaoLigacaoId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtNotificacaoLigacaoId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "IdNivel", "right", false, "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtNotificacaoDataHoraEnvio_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtNotificacaoDataHoraEnvio_Internalname, "de envio", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtNotificacaoDataHoraEnvio_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtNotificacaoDataHoraEnvio_Internalname, context.localUtil.TToC( A26NotificacaoDataHoraEnvio, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A26NotificacaoDataHoraEnvio, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'por',false,0);"+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtNotificacaoDataHoraEnvio_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtNotificacaoDataHoraEnvio_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "DataHora", "right", false, "HLP_Notificacao.htm");
            GxWebStd.gx_bitmap( context, edtNotificacaoDataHoraEnvio_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtNotificacaoDataHoraEnvio_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Notificacao.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Notificacao.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtNotificacaoId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtNotificacaoId_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NOTIFICACAOID");
                  AnyError = 1;
                  GX_FocusControl = edtNotificacaoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A23NotificacaoId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A23NotificacaoId), 18, 0)));
               }
               else
               {
                  A23NotificacaoId = (long)(context.localUtil.CToN( cgiGet( edtNotificacaoId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A23NotificacaoId), 18, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioId_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIOID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A11UsuarioId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
               }
               else
               {
                  A11UsuarioId = (long)(context.localUtil.CToN( cgiGet( edtUsuarioId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
               }
               cmbNotificacaoTipo.CurrentValue = cgiGet( cmbNotificacaoTipo_Internalname);
               A24NotificacaoTipo = (short)(NumberUtil.Val( cgiGet( cmbNotificacaoTipo_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24NotificacaoTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0)));
               A25NotificacaoTexto = cgiGet( edtNotificacaoTexto_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25NotificacaoTexto", A25NotificacaoTexto);
               if ( ( ( context.localUtil.CToN( cgiGet( edtNotificacaoLigacaoId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtNotificacaoLigacaoId_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "NOTIFICACAOLIGACAOID");
                  AnyError = 1;
                  GX_FocusControl = edtNotificacaoLigacaoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A61NotificacaoLigacaoId = 0;
                  n61NotificacaoLigacaoId = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61NotificacaoLigacaoId), 18, 0)));
               }
               else
               {
                  A61NotificacaoLigacaoId = (long)(context.localUtil.CToN( cgiGet( edtNotificacaoLigacaoId_Internalname), ",", "."));
                  n61NotificacaoLigacaoId = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61NotificacaoLigacaoId), 18, 0)));
               }
               n61NotificacaoLigacaoId = ((0==A61NotificacaoLigacaoId) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtNotificacaoDataHoraEnvio_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Data e hora de envio"}), 1, "NOTIFICACAODATAHORAENVIO");
                  AnyError = 1;
                  GX_FocusControl = edtNotificacaoDataHoraEnvio_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A26NotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26NotificacaoDataHoraEnvio", context.localUtil.TToC( A26NotificacaoDataHoraEnvio, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A26NotificacaoDataHoraEnvio = context.localUtil.CToT( cgiGet( edtNotificacaoDataHoraEnvio_Internalname));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26NotificacaoDataHoraEnvio", context.localUtil.TToC( A26NotificacaoDataHoraEnvio, 8, 5, 0, 3, "/", ":", " "));
               }
               /* Read saved values. */
               Z23NotificacaoId = (long)(context.localUtil.CToN( cgiGet( "Z23NotificacaoId"), ",", "."));
               Z24NotificacaoTipo = (short)(context.localUtil.CToN( cgiGet( "Z24NotificacaoTipo"), ",", "."));
               Z25NotificacaoTexto = cgiGet( "Z25NotificacaoTexto");
               Z61NotificacaoLigacaoId = (long)(context.localUtil.CToN( cgiGet( "Z61NotificacaoLigacaoId"), ",", "."));
               n61NotificacaoLigacaoId = ((0==A61NotificacaoLigacaoId) ? true : false);
               Z26NotificacaoDataHoraEnvio = context.localUtil.CToT( cgiGet( "Z26NotificacaoDataHoraEnvio"), 0);
               Z11UsuarioId = (long)(context.localUtil.CToN( cgiGet( "Z11UsuarioId"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A23NotificacaoId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A23NotificacaoId), 18, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
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
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll066( ) ;
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         bttBtn_first_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)), true);
         bttBtn_previous_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)), true);
         bttBtn_next_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)), true);
         bttBtn_last_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)), true);
         bttBtn_select_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)), true);
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
         }
         DisableAttributes066( ) ;
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

      protected void ResetCaption060( )
      {
      }

      protected void ZM066( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z24NotificacaoTipo = T00063_A24NotificacaoTipo[0];
               Z25NotificacaoTexto = T00063_A25NotificacaoTexto[0];
               Z61NotificacaoLigacaoId = T00063_A61NotificacaoLigacaoId[0];
               Z26NotificacaoDataHoraEnvio = T00063_A26NotificacaoDataHoraEnvio[0];
               Z11UsuarioId = T00063_A11UsuarioId[0];
            }
            else
            {
               Z24NotificacaoTipo = A24NotificacaoTipo;
               Z25NotificacaoTexto = A25NotificacaoTexto;
               Z61NotificacaoLigacaoId = A61NotificacaoLigacaoId;
               Z26NotificacaoDataHoraEnvio = A26NotificacaoDataHoraEnvio;
               Z11UsuarioId = A11UsuarioId;
            }
         }
         if ( GX_JID == -4 )
         {
            Z23NotificacaoId = A23NotificacaoId;
            Z24NotificacaoTipo = A24NotificacaoTipo;
            Z25NotificacaoTexto = A25NotificacaoTexto;
            Z61NotificacaoLigacaoId = A61NotificacaoLigacaoId;
            Z26NotificacaoDataHoraEnvio = A26NotificacaoDataHoraEnvio;
            Z11UsuarioId = A11UsuarioId;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_11_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIOID"+"'), id:'"+"USUARIOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
      }

      protected void Load066( )
      {
         /* Using cursor T00065 */
         pr_default.execute(3, new Object[] {A23NotificacaoId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound6 = 1;
            A24NotificacaoTipo = T00065_A24NotificacaoTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24NotificacaoTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0)));
            A25NotificacaoTexto = T00065_A25NotificacaoTexto[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25NotificacaoTexto", A25NotificacaoTexto);
            A61NotificacaoLigacaoId = T00065_A61NotificacaoLigacaoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61NotificacaoLigacaoId), 18, 0)));
            n61NotificacaoLigacaoId = T00065_n61NotificacaoLigacaoId[0];
            A26NotificacaoDataHoraEnvio = T00065_A26NotificacaoDataHoraEnvio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26NotificacaoDataHoraEnvio", context.localUtil.TToC( A26NotificacaoDataHoraEnvio, 8, 5, 0, 3, "/", ":", " "));
            A11UsuarioId = T00065_A11UsuarioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            ZM066( -4) ;
         }
         pr_default.close(3);
         OnLoadActions066( ) ;
      }

      protected void OnLoadActions066( )
      {
         if ( (0==A61NotificacaoLigacaoId) )
         {
            A61NotificacaoLigacaoId = 0;
            n61NotificacaoLigacaoId = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61NotificacaoLigacaoId), 18, 0)));
            n61NotificacaoLigacaoId = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61NotificacaoLigacaoId), 18, 0)));
         }
      }

      protected void CheckExtendedTable066( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         if ( ! ( ( A24NotificacaoTipo == 1 ) ) )
         {
            GX_msglist.addItem("Campo Tipo de notificação fora do intervalo", "OutOfRange", 1, "NOTIFICACAOTIPO");
            AnyError = 1;
            GX_FocusControl = cmbNotificacaoTipo_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (0==A61NotificacaoLigacaoId) )
         {
            A61NotificacaoLigacaoId = 0;
            n61NotificacaoLigacaoId = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61NotificacaoLigacaoId), 18, 0)));
            n61NotificacaoLigacaoId = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61NotificacaoLigacaoId), 18, 0)));
         }
         if ( ! ( (DateTime.MinValue==A26NotificacaoDataHoraEnvio) || ( A26NotificacaoDataHoraEnvio >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Data e hora de envio fora do intervalo", "OutOfRange", 1, "NOTIFICACAODATAHORAENVIO");
            AnyError = 1;
            GX_FocusControl = edtNotificacaoDataHoraEnvio_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors066( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( long A11UsuarioId )
      {
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey066( )
      {
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {A23NotificacaoId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A23NotificacaoId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM066( 4) ;
            RcdFound6 = 1;
            A23NotificacaoId = T00063_A23NotificacaoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A23NotificacaoId), 18, 0)));
            A24NotificacaoTipo = T00063_A24NotificacaoTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24NotificacaoTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0)));
            A25NotificacaoTexto = T00063_A25NotificacaoTexto[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25NotificacaoTexto", A25NotificacaoTexto);
            A61NotificacaoLigacaoId = T00063_A61NotificacaoLigacaoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61NotificacaoLigacaoId), 18, 0)));
            n61NotificacaoLigacaoId = T00063_n61NotificacaoLigacaoId[0];
            A26NotificacaoDataHoraEnvio = T00063_A26NotificacaoDataHoraEnvio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26NotificacaoDataHoraEnvio", context.localUtil.TToC( A26NotificacaoDataHoraEnvio, 8, 5, 0, 3, "/", ":", " "));
            A11UsuarioId = T00063_A11UsuarioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            Z23NotificacaoId = A23NotificacaoId;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load066( ) ;
            if ( AnyError == 1 )
            {
               RcdFound6 = 0;
               InitializeNonKey066( ) ;
            }
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey066( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey066( ) ;
         if ( RcdFound6 == 0 )
         {
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound6 = 0;
         /* Using cursor T00068 */
         pr_default.execute(6, new Object[] {A23NotificacaoId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00068_A23NotificacaoId[0] < A23NotificacaoId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00068_A23NotificacaoId[0] > A23NotificacaoId ) ) )
            {
               A23NotificacaoId = T00068_A23NotificacaoId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A23NotificacaoId), 18, 0)));
               RcdFound6 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound6 = 0;
         /* Using cursor T00069 */
         pr_default.execute(7, new Object[] {A23NotificacaoId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00069_A23NotificacaoId[0] > A23NotificacaoId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00069_A23NotificacaoId[0] < A23NotificacaoId ) ) )
            {
               A23NotificacaoId = T00069_A23NotificacaoId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A23NotificacaoId), 18, 0)));
               RcdFound6 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey066( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtNotificacaoId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert066( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound6 == 1 )
            {
               if ( A23NotificacaoId != Z23NotificacaoId )
               {
                  A23NotificacaoId = Z23NotificacaoId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A23NotificacaoId), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "NOTIFICACAOID");
                  AnyError = 1;
                  GX_FocusControl = edtNotificacaoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtNotificacaoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update066( ) ;
                  GX_FocusControl = edtNotificacaoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A23NotificacaoId != Z23NotificacaoId )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtNotificacaoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert066( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "NOTIFICACAOID");
                     AnyError = 1;
                     GX_FocusControl = edtNotificacaoId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtNotificacaoId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert066( ) ;
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
      }

      protected void btn_delete( )
      {
         if ( A23NotificacaoId != Z23NotificacaoId )
         {
            A23NotificacaoId = Z23NotificacaoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A23NotificacaoId), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "NOTIFICACAOID");
            AnyError = 1;
            GX_FocusControl = edtNotificacaoId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtNotificacaoId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "NOTIFICACAOID");
            AnyError = 1;
            GX_FocusControl = edtNotificacaoId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtUsuarioId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart066( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd066( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_previous( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_next( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart066( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound6 != 0 )
            {
               ScanNext066( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd066( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency066( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00062 */
            pr_default.execute(0, new Object[] {A23NotificacaoId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Notificacao"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z24NotificacaoTipo != T00062_A24NotificacaoTipo[0] ) || ( StringUtil.StrCmp(Z25NotificacaoTexto, T00062_A25NotificacaoTexto[0]) != 0 ) || ( Z61NotificacaoLigacaoId != T00062_A61NotificacaoLigacaoId[0] ) || ( Z26NotificacaoDataHoraEnvio != T00062_A26NotificacaoDataHoraEnvio[0] ) || ( Z11UsuarioId != T00062_A11UsuarioId[0] ) )
            {
               if ( Z24NotificacaoTipo != T00062_A24NotificacaoTipo[0] )
               {
                  GXUtil.WriteLog("notificacao:[seudo value changed for attri]"+"NotificacaoTipo");
                  GXUtil.WriteLogRaw("Old: ",Z24NotificacaoTipo);
                  GXUtil.WriteLogRaw("Current: ",T00062_A24NotificacaoTipo[0]);
               }
               if ( StringUtil.StrCmp(Z25NotificacaoTexto, T00062_A25NotificacaoTexto[0]) != 0 )
               {
                  GXUtil.WriteLog("notificacao:[seudo value changed for attri]"+"NotificacaoTexto");
                  GXUtil.WriteLogRaw("Old: ",Z25NotificacaoTexto);
                  GXUtil.WriteLogRaw("Current: ",T00062_A25NotificacaoTexto[0]);
               }
               if ( Z61NotificacaoLigacaoId != T00062_A61NotificacaoLigacaoId[0] )
               {
                  GXUtil.WriteLog("notificacao:[seudo value changed for attri]"+"NotificacaoLigacaoId");
                  GXUtil.WriteLogRaw("Old: ",Z61NotificacaoLigacaoId);
                  GXUtil.WriteLogRaw("Current: ",T00062_A61NotificacaoLigacaoId[0]);
               }
               if ( Z26NotificacaoDataHoraEnvio != T00062_A26NotificacaoDataHoraEnvio[0] )
               {
                  GXUtil.WriteLog("notificacao:[seudo value changed for attri]"+"NotificacaoDataHoraEnvio");
                  GXUtil.WriteLogRaw("Old: ",Z26NotificacaoDataHoraEnvio);
                  GXUtil.WriteLogRaw("Current: ",T00062_A26NotificacaoDataHoraEnvio[0]);
               }
               if ( Z11UsuarioId != T00062_A11UsuarioId[0] )
               {
                  GXUtil.WriteLog("notificacao:[seudo value changed for attri]"+"UsuarioId");
                  GXUtil.WriteLogRaw("Old: ",Z11UsuarioId);
                  GXUtil.WriteLogRaw("Current: ",T00062_A11UsuarioId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Notificacao"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert066( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable066( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM066( 0) ;
            CheckOptimisticConcurrency066( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm066( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert066( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000610 */
                     pr_default.execute(8, new Object[] {A24NotificacaoTipo, A25NotificacaoTexto, n61NotificacaoLigacaoId, A61NotificacaoLigacaoId, A26NotificacaoDataHoraEnvio, A11UsuarioId});
                     A23NotificacaoId = T000610_A23NotificacaoId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A23NotificacaoId), 18, 0)));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Notificacao") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption060( ) ;
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
               Load066( ) ;
            }
            EndLevel066( ) ;
         }
         CloseExtendedTableCursors066( ) ;
      }

      protected void Update066( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable066( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency066( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm066( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate066( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000611 */
                     pr_default.execute(9, new Object[] {A24NotificacaoTipo, A25NotificacaoTexto, n61NotificacaoLigacaoId, A61NotificacaoLigacaoId, A26NotificacaoDataHoraEnvio, A11UsuarioId, A23NotificacaoId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Notificacao") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Notificacao"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate066( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption060( ) ;
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
            EndLevel066( ) ;
         }
         CloseExtendedTableCursors066( ) ;
      }

      protected void DeferredUpdate066( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency066( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls066( ) ;
            AfterConfirm066( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete066( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000612 */
                  pr_default.execute(10, new Object[] {A23NotificacaoId});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("Notificacao") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound6 == 0 )
                        {
                           InitAll066( ) ;
                           Gx_mode = "INS";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                        ResetCaption060( ) ;
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
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel066( ) ;
         Gx_mode = sMode6;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls066( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel066( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete066( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_gam.commit( "Notificacao");
            pr_default.commit( "Notificacao");
            if ( AnyError == 0 )
            {
               ConfirmValues060( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_gam.rollback( "Notificacao");
            pr_default.rollback( "Notificacao");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart066( )
      {
         /* Using cursor T000613 */
         pr_default.execute(11);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound6 = 1;
            A23NotificacaoId = T000613_A23NotificacaoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A23NotificacaoId), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext066( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound6 = 1;
            A23NotificacaoId = T000613_A23NotificacaoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A23NotificacaoId), 18, 0)));
         }
      }

      protected void ScanEnd066( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm066( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert066( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate066( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete066( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete066( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate066( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes066( )
      {
         edtNotificacaoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNotificacaoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNotificacaoId_Enabled), 5, 0)), true);
         edtUsuarioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioId_Enabled), 5, 0)), true);
         cmbNotificacaoTipo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNotificacaoTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbNotificacaoTipo.Enabled), 5, 0)), true);
         edtNotificacaoTexto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNotificacaoTexto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNotificacaoTexto_Enabled), 5, 0)), true);
         edtNotificacaoLigacaoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNotificacaoLigacaoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNotificacaoLigacaoId_Enabled), 5, 0)), true);
         edtNotificacaoDataHoraEnvio_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtNotificacaoDataHoraEnvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtNotificacaoDataHoraEnvio_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes066( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues060( )
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
         context.AddJavascriptSource("gxcfg.js", "?201892720412854", false);
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
         bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("notificacao.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z23NotificacaoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23NotificacaoId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z24NotificacaoTipo", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z24NotificacaoTipo), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z25NotificacaoTexto", Z25NotificacaoTexto);
         GxWebStd.gx_hidden_field( context, "Z61NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z61NotificacaoLigacaoId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z26NotificacaoDataHoraEnvio", context.localUtil.TToC( Z26NotificacaoDataHoraEnvio, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z11UsuarioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11UsuarioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
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
         return formatLink("notificacao.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Notificacao" ;
      }

      public override String GetPgmdesc( )
      {
         return "Notificação" ;
      }

      protected void InitializeNonKey066( )
      {
         A11UsuarioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
         A24NotificacaoTipo = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24NotificacaoTipo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0)));
         A25NotificacaoTexto = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25NotificacaoTexto", A25NotificacaoTexto);
         A61NotificacaoLigacaoId = 0;
         n61NotificacaoLigacaoId = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61NotificacaoLigacaoId), 18, 0)));
         n61NotificacaoLigacaoId = ((0==A61NotificacaoLigacaoId) ? true : false);
         A26NotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26NotificacaoDataHoraEnvio", context.localUtil.TToC( A26NotificacaoDataHoraEnvio, 8, 5, 0, 3, "/", ":", " "));
         Z24NotificacaoTipo = 0;
         Z25NotificacaoTexto = "";
         Z61NotificacaoLigacaoId = 0;
         Z26NotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
         Z11UsuarioId = 0;
      }

      protected void InitAll066( )
      {
         A23NotificacaoId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A23NotificacaoId), 18, 0)));
         InitializeNonKey066( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892720412864", true);
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
         context.AddJavascriptSource("notificacao.js", "?201892720412864", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         edtNotificacaoId_Internalname = "NOTIFICACAOID";
         edtUsuarioId_Internalname = "USUARIOID";
         cmbNotificacaoTipo_Internalname = "NOTIFICACAOTIPO";
         edtNotificacaoTexto_Internalname = "NOTIFICACAOTEXTO";
         edtNotificacaoLigacaoId_Internalname = "NOTIFICACAOLIGACAOID";
         edtNotificacaoDataHoraEnvio_Internalname = "NOTIFICACAODATAHORAENVIO";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         Form.Internalname = "FORM";
         imgprompt_11_Internalname = "PROMPT_11";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Notificação";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtNotificacaoDataHoraEnvio_Jsonclick = "";
         edtNotificacaoDataHoraEnvio_Enabled = 1;
         edtNotificacaoLigacaoId_Jsonclick = "";
         edtNotificacaoLigacaoId_Enabled = 1;
         edtNotificacaoTexto_Enabled = 1;
         cmbNotificacaoTipo_Jsonclick = "";
         cmbNotificacaoTipo.Enabled = 1;
         imgprompt_11_Visible = 1;
         imgprompt_11_Link = "";
         edtUsuarioId_Jsonclick = "";
         edtUsuarioId_Enabled = 1;
         edtNotificacaoId_Jsonclick = "";
         edtNotificacaoId_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
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

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         GX_FocusControl = edtUsuarioId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Notificacaoid( long GX_Parm1 ,
                                       GXCombobox cmbGX_Parm2 ,
                                       String GX_Parm3 ,
                                       long GX_Parm4 ,
                                       DateTime GX_Parm5 ,
                                       long GX_Parm6 )
      {
         A23NotificacaoId = GX_Parm1;
         cmbNotificacaoTipo = cmbGX_Parm2;
         A24NotificacaoTipo = (short)(NumberUtil.Val( cmbNotificacaoTipo.CurrentValue, "."));
         cmbNotificacaoTipo.CurrentValue = StringUtil.LTrim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0));
         A25NotificacaoTexto = GX_Parm3;
         A61NotificacaoLigacaoId = GX_Parm4;
         n61NotificacaoLigacaoId = false;
         A26NotificacaoDataHoraEnvio = GX_Parm5;
         A11UsuarioId = GX_Parm6;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ".", "")));
         cmbNotificacaoTipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0));
         isValidOutput.Add(cmbNotificacaoTipo);
         isValidOutput.Add(A25NotificacaoTexto);
         isValidOutput.Add(context.localUtil.TToC( A26NotificacaoDataHoraEnvio, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A61NotificacaoLigacaoId), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23NotificacaoId), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11UsuarioId), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z24NotificacaoTipo), 4, 0, ",", "")));
         isValidOutput.Add(Z25NotificacaoTexto);
         isValidOutput.Add(context.localUtil.TToC( Z26NotificacaoDataHoraEnvio, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z61NotificacaoLigacaoId), 18, 0, ",", "")));
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Usuarioid( long GX_Parm1 )
      {
         A11UsuarioId = GX_Parm1;
         /* Using cursor T000614 */
         pr_default.execute(12, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioId_Internalname;
         }
         pr_default.close(12);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}],oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[],oparms:[]}");
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
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z25NotificacaoTexto = "";
         Z26NotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         sImgUrl = "";
         A25NotificacaoTexto = "";
         A26NotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00065_A23NotificacaoId = new long[1] ;
         T00065_A24NotificacaoTipo = new short[1] ;
         T00065_A25NotificacaoTexto = new String[] {""} ;
         T00065_A61NotificacaoLigacaoId = new long[1] ;
         T00065_n61NotificacaoLigacaoId = new bool[] {false} ;
         T00065_A26NotificacaoDataHoraEnvio = new DateTime[] {DateTime.MinValue} ;
         T00065_A11UsuarioId = new long[1] ;
         T00064_A11UsuarioId = new long[1] ;
         T00066_A11UsuarioId = new long[1] ;
         T00067_A23NotificacaoId = new long[1] ;
         T00063_A23NotificacaoId = new long[1] ;
         T00063_A24NotificacaoTipo = new short[1] ;
         T00063_A25NotificacaoTexto = new String[] {""} ;
         T00063_A61NotificacaoLigacaoId = new long[1] ;
         T00063_n61NotificacaoLigacaoId = new bool[] {false} ;
         T00063_A26NotificacaoDataHoraEnvio = new DateTime[] {DateTime.MinValue} ;
         T00063_A11UsuarioId = new long[1] ;
         sMode6 = "";
         T00068_A23NotificacaoId = new long[1] ;
         T00069_A23NotificacaoId = new long[1] ;
         T00062_A23NotificacaoId = new long[1] ;
         T00062_A24NotificacaoTipo = new short[1] ;
         T00062_A25NotificacaoTexto = new String[] {""} ;
         T00062_A61NotificacaoLigacaoId = new long[1] ;
         T00062_n61NotificacaoLigacaoId = new bool[] {false} ;
         T00062_A26NotificacaoDataHoraEnvio = new DateTime[] {DateTime.MinValue} ;
         T00062_A11UsuarioId = new long[1] ;
         T000610_A23NotificacaoId = new long[1] ;
         T000613_A23NotificacaoId = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000614_A11UsuarioId = new long[1] ;
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.notificacao__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.notificacao__default(),
            new Object[][] {
                new Object[] {
               T00062_A23NotificacaoId, T00062_A24NotificacaoTipo, T00062_A25NotificacaoTexto, T00062_A61NotificacaoLigacaoId, T00062_n61NotificacaoLigacaoId, T00062_A26NotificacaoDataHoraEnvio, T00062_A11UsuarioId
               }
               , new Object[] {
               T00063_A23NotificacaoId, T00063_A24NotificacaoTipo, T00063_A25NotificacaoTexto, T00063_A61NotificacaoLigacaoId, T00063_n61NotificacaoLigacaoId, T00063_A26NotificacaoDataHoraEnvio, T00063_A11UsuarioId
               }
               , new Object[] {
               T00064_A11UsuarioId
               }
               , new Object[] {
               T00065_A23NotificacaoId, T00065_A24NotificacaoTipo, T00065_A25NotificacaoTexto, T00065_A61NotificacaoLigacaoId, T00065_n61NotificacaoLigacaoId, T00065_A26NotificacaoDataHoraEnvio, T00065_A11UsuarioId
               }
               , new Object[] {
               T00066_A11UsuarioId
               }
               , new Object[] {
               T00067_A23NotificacaoId
               }
               , new Object[] {
               T00068_A23NotificacaoId
               }
               , new Object[] {
               T00069_A23NotificacaoId
               }
               , new Object[] {
               T000610_A23NotificacaoId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000613_A23NotificacaoId
               }
               , new Object[] {
               T000614_A11UsuarioId
               }
            }
         );
      }

      private short Z24NotificacaoTipo ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short A24NotificacaoTipo ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short RcdFound6 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtNotificacaoId_Enabled ;
      private int edtUsuarioId_Enabled ;
      private int imgprompt_11_Visible ;
      private int edtNotificacaoTexto_Enabled ;
      private int edtNotificacaoLigacaoId_Enabled ;
      private int edtNotificacaoDataHoraEnvio_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z23NotificacaoId ;
      private long Z61NotificacaoLigacaoId ;
      private long Z11UsuarioId ;
      private long A11UsuarioId ;
      private long A23NotificacaoId ;
      private long A61NotificacaoLigacaoId ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtNotificacaoId_Internalname ;
      private String cmbNotificacaoTipo_Internalname ;
      private String divTablemain_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtNotificacaoId_Jsonclick ;
      private String edtUsuarioId_Internalname ;
      private String edtUsuarioId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_11_Internalname ;
      private String imgprompt_11_Link ;
      private String cmbNotificacaoTipo_Jsonclick ;
      private String edtNotificacaoTexto_Internalname ;
      private String edtNotificacaoLigacaoId_Internalname ;
      private String edtNotificacaoLigacaoId_Jsonclick ;
      private String edtNotificacaoDataHoraEnvio_Internalname ;
      private String edtNotificacaoDataHoraEnvio_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode6 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z26NotificacaoDataHoraEnvio ;
      private DateTime A26NotificacaoDataHoraEnvio ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n61NotificacaoLigacaoId ;
      private String Z25NotificacaoTexto ;
      private String A25NotificacaoTexto ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbNotificacaoTipo ;
      private IDataStoreProvider pr_default ;
      private long[] T00065_A23NotificacaoId ;
      private short[] T00065_A24NotificacaoTipo ;
      private String[] T00065_A25NotificacaoTexto ;
      private long[] T00065_A61NotificacaoLigacaoId ;
      private bool[] T00065_n61NotificacaoLigacaoId ;
      private DateTime[] T00065_A26NotificacaoDataHoraEnvio ;
      private long[] T00065_A11UsuarioId ;
      private long[] T00064_A11UsuarioId ;
      private long[] T00066_A11UsuarioId ;
      private long[] T00067_A23NotificacaoId ;
      private long[] T00063_A23NotificacaoId ;
      private short[] T00063_A24NotificacaoTipo ;
      private String[] T00063_A25NotificacaoTexto ;
      private long[] T00063_A61NotificacaoLigacaoId ;
      private bool[] T00063_n61NotificacaoLigacaoId ;
      private DateTime[] T00063_A26NotificacaoDataHoraEnvio ;
      private long[] T00063_A11UsuarioId ;
      private long[] T00068_A23NotificacaoId ;
      private long[] T00069_A23NotificacaoId ;
      private long[] T00062_A23NotificacaoId ;
      private short[] T00062_A24NotificacaoTipo ;
      private String[] T00062_A25NotificacaoTexto ;
      private long[] T00062_A61NotificacaoLigacaoId ;
      private bool[] T00062_n61NotificacaoLigacaoId ;
      private DateTime[] T00062_A26NotificacaoDataHoraEnvio ;
      private long[] T00062_A11UsuarioId ;
      private long[] T000610_A23NotificacaoId ;
      private IDataStoreProvider pr_gam ;
      private long[] T000613_A23NotificacaoId ;
      private long[] T000614_A11UsuarioId ;
      private GXWebForm Form ;
   }

   public class notificacao__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class notificacao__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[8])
       ,new UpdateCursor(def[9])
       ,new UpdateCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00065 ;
        prmT00065 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00064 ;
        prmT00064 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00066 ;
        prmT00066 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00067 ;
        prmT00067 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00063 ;
        prmT00063 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00068 ;
        prmT00068 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00069 ;
        prmT00069 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00062 ;
        prmT00062 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000610 ;
        prmT000610 = new Object[] {
        new Object[] {"@NotificacaoTipo",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@NotificacaoTexto",SqlDbType.VarChar,300,0} ,
        new Object[] {"@NotificacaoLigacaoId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@NotificacaoDataHoraEnvio",SqlDbType.DateTime,8,5} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000611 ;
        prmT000611 = new Object[] {
        new Object[] {"@NotificacaoTipo",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@NotificacaoTexto",SqlDbType.VarChar,300,0} ,
        new Object[] {"@NotificacaoLigacaoId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@NotificacaoDataHoraEnvio",SqlDbType.DateTime,8,5} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000612 ;
        prmT000612 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000613 ;
        prmT000613 = new Object[] {
        } ;
        Object[] prmT000614 ;
        prmT000614 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00062", "SELECT [NotificacaoId], [NotificacaoTipo], [NotificacaoTexto], [NotificacaoLigacaoId], [NotificacaoDataHoraEnvio], [UsuarioId] FROM [Notificacao] WITH (UPDLOCK) WHERE [NotificacaoId] = @NotificacaoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1,0,true,false )
           ,new CursorDef("T00063", "SELECT [NotificacaoId], [NotificacaoTipo], [NotificacaoTexto], [NotificacaoLigacaoId], [NotificacaoDataHoraEnvio], [UsuarioId] FROM [Notificacao] WITH (NOLOCK) WHERE [NotificacaoId] = @NotificacaoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1,0,true,false )
           ,new CursorDef("T00064", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1,0,true,false )
           ,new CursorDef("T00065", "SELECT TM1.[NotificacaoId], TM1.[NotificacaoTipo], TM1.[NotificacaoTexto], TM1.[NotificacaoLigacaoId], TM1.[NotificacaoDataHoraEnvio], TM1.[UsuarioId] FROM [Notificacao] TM1 WITH (NOLOCK) WHERE TM1.[NotificacaoId] = @NotificacaoId ORDER BY TM1.[NotificacaoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,100,0,true,false )
           ,new CursorDef("T00066", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1,0,true,false )
           ,new CursorDef("T00067", "SELECT [NotificacaoId] FROM [Notificacao] WITH (NOLOCK) WHERE [NotificacaoId] = @NotificacaoId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1,0,true,false )
           ,new CursorDef("T00068", "SELECT TOP 1 [NotificacaoId] FROM [Notificacao] WITH (NOLOCK) WHERE ( [NotificacaoId] > @NotificacaoId) ORDER BY [NotificacaoId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,1,0,true,true )
           ,new CursorDef("T00069", "SELECT TOP 1 [NotificacaoId] FROM [Notificacao] WITH (NOLOCK) WHERE ( [NotificacaoId] < @NotificacaoId) ORDER BY [NotificacaoId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,1,0,true,true )
           ,new CursorDef("T000610", "INSERT INTO [Notificacao]([NotificacaoTipo], [NotificacaoTexto], [NotificacaoLigacaoId], [NotificacaoDataHoraEnvio], [UsuarioId]) VALUES(@NotificacaoTipo, @NotificacaoTexto, @NotificacaoLigacaoId, @NotificacaoDataHoraEnvio, @UsuarioId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000610)
           ,new CursorDef("T000611", "UPDATE [Notificacao] SET [NotificacaoTipo]=@NotificacaoTipo, [NotificacaoTexto]=@NotificacaoTexto, [NotificacaoLigacaoId]=@NotificacaoLigacaoId, [NotificacaoDataHoraEnvio]=@NotificacaoDataHoraEnvio, [UsuarioId]=@UsuarioId  WHERE [NotificacaoId] = @NotificacaoId", GxErrorMask.GX_NOMASK,prmT000611)
           ,new CursorDef("T000612", "DELETE FROM [Notificacao]  WHERE [NotificacaoId] = @NotificacaoId", GxErrorMask.GX_NOMASK,prmT000612)
           ,new CursorDef("T000613", "SELECT [NotificacaoId] FROM [Notificacao] WITH (NOLOCK) ORDER BY [NotificacaoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000613,100,0,true,false )
           ,new CursorDef("T000614", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000614,1,0,true,false )
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
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(5) ;
              ((long[]) buf[6])[0] = rslt.getLong(6) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(5) ;
              ((long[]) buf[6])[0] = rslt.getLong(6) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(5) ;
              ((long[]) buf[6])[0] = rslt.getLong(6) ;
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
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 12 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
              stmt.SetParameter(1, (long)parms[0]);
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (long)parms[3]);
              }
              stmt.SetParameterDatetime(4, (DateTime)parms[4]);
              stmt.SetParameter(5, (long)parms[5]);
              return;
           case 9 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (long)parms[3]);
              }
              stmt.SetParameterDatetime(4, (DateTime)parms[4]);
              stmt.SetParameter(5, (long)parms[5]);
              stmt.SetParameter(6, (long)parms[6]);
              return;
           case 10 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
