/*
               File: UsuarioConquista
        Description: Usuário conquista
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:29.73
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
   public class usuarioconquista : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A11UsuarioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A11UsuarioId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A27ConquistaId = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A27ConquistaId) ;
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
            Form.Meta.addItem("description", "Usuário conquista", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUsuarioConquistaId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public usuarioconquista( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public usuarioconquista( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Usuário conquista", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_UsuarioConquista.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioConquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioConquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioConquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioConquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Selecionar", bttBtn_select_Jsonclick, 4, "Selecionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0080.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIOCONQUISTAID"+"'), id:'"+"USUARIOCONQUISTAID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_UsuarioConquista.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioConquistaId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioConquistaId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioConquistaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A30UsuarioConquistaId), 18, 0, ",", "")), ((edtUsuarioConquistaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A30UsuarioConquistaId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A30UsuarioConquistaId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioConquistaId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioConquistaId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioConquista.htm");
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
            GxWebStd.gx_single_line_edit( context, edtUsuarioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ",", "")), ((edtUsuarioId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioConquista.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_11_Internalname, sImgUrl, imgprompt_11_Link, "", "", context.GetTheme( ), imgprompt_11_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioConquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtConquistaId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtConquistaId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtConquistaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ConquistaId), 18, 0, ",", "")), ((edtConquistaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A27ConquistaId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtConquistaId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtConquistaId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioConquista.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_27_Internalname, sImgUrl, imgprompt_27_Link, "", "", context.GetTheme( ), imgprompt_27_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioConquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtConquistaNome_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtConquistaNome_Internalname, "Nome", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtConquistaNome_Internalname, A29ConquistaNome, StringUtil.RTrim( context.localUtil.Format( A29ConquistaNome, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtConquistaNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtConquistaNome_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Nome", "left", true, "HLP_UsuarioConquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtConquistaPontos_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtConquistaPontos_Internalname, "Pontos", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtConquistaPontos_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A28ConquistaPontos), 4, 0, ",", "")), ((edtConquistaPontos_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A28ConquistaPontos), "ZZZ9")) : context.localUtil.Format( (decimal)(A28ConquistaPontos), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtConquistaPontos_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtConquistaPontos_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Pontos", "right", false, "HLP_UsuarioConquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioConquistaDataHora_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioConquistaDataHora_Internalname, "da conquista", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtUsuarioConquistaDataHora_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioConquistaDataHora_Internalname, context.localUtil.TToC( A31UsuarioConquistaDataHora, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A31UsuarioConquistaDataHora, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'por',false,0);"+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioConquistaDataHora_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioConquistaDataHora_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "DataHora", "right", false, "HLP_UsuarioConquista.htm");
            GxWebStd.gx_bitmap( context, edtUsuarioConquistaDataHora_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtUsuarioConquistaDataHora_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_UsuarioConquista.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioConquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioConquista.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioConquista.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioConquistaId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioConquistaId_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIOCONQUISTAID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioConquistaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A30UsuarioConquistaId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A30UsuarioConquistaId), 18, 0)));
               }
               else
               {
                  A30UsuarioConquistaId = (long)(context.localUtil.CToN( cgiGet( edtUsuarioConquistaId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A30UsuarioConquistaId), 18, 0)));
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtConquistaId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtConquistaId_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CONQUISTAID");
                  AnyError = 1;
                  GX_FocusControl = edtConquistaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A27ConquistaId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
               }
               else
               {
                  A27ConquistaId = (long)(context.localUtil.CToN( cgiGet( edtConquistaId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
               }
               A29ConquistaNome = cgiGet( edtConquistaNome_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29ConquistaNome", A29ConquistaNome);
               A28ConquistaPontos = (short)(context.localUtil.CToN( cgiGet( edtConquistaPontos_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ConquistaPontos), 4, 0)));
               if ( context.localUtil.VCDateTime( cgiGet( edtUsuarioConquistaDataHora_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Data e hora da conquista"}), 1, "USUARIOCONQUISTADATAHORA");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioConquistaDataHora_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31UsuarioConquistaDataHora", context.localUtil.TToC( A31UsuarioConquistaDataHora, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A31UsuarioConquistaDataHora = context.localUtil.CToT( cgiGet( edtUsuarioConquistaDataHora_Internalname));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31UsuarioConquistaDataHora", context.localUtil.TToC( A31UsuarioConquistaDataHora, 8, 5, 0, 3, "/", ":", " "));
               }
               /* Read saved values. */
               Z30UsuarioConquistaId = (long)(context.localUtil.CToN( cgiGet( "Z30UsuarioConquistaId"), ",", "."));
               Z31UsuarioConquistaDataHora = context.localUtil.CToT( cgiGet( "Z31UsuarioConquistaDataHora"), 0);
               Z11UsuarioId = (long)(context.localUtil.CToN( cgiGet( "Z11UsuarioId"), ",", "."));
               Z27ConquistaId = (long)(context.localUtil.CToN( cgiGet( "Z27ConquistaId"), ",", "."));
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
                  A30UsuarioConquistaId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A30UsuarioConquistaId), 18, 0)));
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
               InitAll088( ) ;
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
         DisableAttributes088( ) ;
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

      protected void ResetCaption080( )
      {
      }

      protected void ZM088( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z31UsuarioConquistaDataHora = T00083_A31UsuarioConquistaDataHora[0];
               Z11UsuarioId = T00083_A11UsuarioId[0];
               Z27ConquistaId = T00083_A27ConquistaId[0];
            }
            else
            {
               Z31UsuarioConquistaDataHora = A31UsuarioConquistaDataHora;
               Z11UsuarioId = A11UsuarioId;
               Z27ConquistaId = A27ConquistaId;
            }
         }
         if ( GX_JID == -2 )
         {
            Z30UsuarioConquistaId = A30UsuarioConquistaId;
            Z31UsuarioConquistaDataHora = A31UsuarioConquistaDataHora;
            Z11UsuarioId = A11UsuarioId;
            Z27ConquistaId = A27ConquistaId;
            Z29ConquistaNome = A29ConquistaNome;
            Z28ConquistaPontos = A28ConquistaPontos;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_11_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIOID"+"'), id:'"+"USUARIOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_27_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0070.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CONQUISTAID"+"'), id:'"+"CONQUISTAID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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

      protected void Load088( )
      {
         /* Using cursor T00086 */
         pr_default.execute(4, new Object[] {A30UsuarioConquistaId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound8 = 1;
            A29ConquistaNome = T00086_A29ConquistaNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29ConquistaNome", A29ConquistaNome);
            A28ConquistaPontos = T00086_A28ConquistaPontos[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ConquistaPontos), 4, 0)));
            A31UsuarioConquistaDataHora = T00086_A31UsuarioConquistaDataHora[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31UsuarioConquistaDataHora", context.localUtil.TToC( A31UsuarioConquistaDataHora, 8, 5, 0, 3, "/", ":", " "));
            A11UsuarioId = T00086_A11UsuarioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            A27ConquistaId = T00086_A27ConquistaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
            ZM088( -2) ;
         }
         pr_default.close(4);
         OnLoadActions088( ) ;
      }

      protected void OnLoadActions088( )
      {
      }

      protected void CheckExtendedTable088( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00084 */
         pr_default.execute(2, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         /* Using cursor T00085 */
         pr_default.execute(3, new Object[] {A27ConquistaId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("Não existe 'Conquista'.", "ForeignKeyNotFound", 1, "CONQUISTAID");
            AnyError = 1;
            GX_FocusControl = edtConquistaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A29ConquistaNome = T00085_A29ConquistaNome[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29ConquistaNome", A29ConquistaNome);
         A28ConquistaPontos = T00085_A28ConquistaPontos[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ConquistaPontos), 4, 0)));
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A31UsuarioConquistaDataHora) || ( A31UsuarioConquistaDataHora >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Data e hora da conquista fora do intervalo", "OutOfRange", 1, "USUARIOCONQUISTADATAHORA");
            AnyError = 1;
            GX_FocusControl = edtUsuarioConquistaDataHora_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors088( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_3( long A11UsuarioId )
      {
         /* Using cursor T00087 */
         pr_default.execute(5, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(5) == 101) )
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
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(5);
      }

      protected void gxLoad_4( long A27ConquistaId )
      {
         /* Using cursor T00088 */
         pr_default.execute(6, new Object[] {A27ConquistaId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("Não existe 'Conquista'.", "ForeignKeyNotFound", 1, "CONQUISTAID");
            AnyError = 1;
            GX_FocusControl = edtConquistaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A29ConquistaNome = T00088_A29ConquistaNome[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29ConquistaNome", A29ConquistaNome);
         A28ConquistaPontos = T00088_A28ConquistaPontos[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ConquistaPontos), 4, 0)));
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A29ConquistaNome)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A28ConquistaPontos), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void GetKey088( )
      {
         /* Using cursor T00089 */
         pr_default.execute(7, new Object[] {A30UsuarioConquistaId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00083 */
         pr_default.execute(1, new Object[] {A30UsuarioConquistaId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM088( 2) ;
            RcdFound8 = 1;
            A30UsuarioConquistaId = T00083_A30UsuarioConquistaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A30UsuarioConquistaId), 18, 0)));
            A31UsuarioConquistaDataHora = T00083_A31UsuarioConquistaDataHora[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31UsuarioConquistaDataHora", context.localUtil.TToC( A31UsuarioConquistaDataHora, 8, 5, 0, 3, "/", ":", " "));
            A11UsuarioId = T00083_A11UsuarioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            A27ConquistaId = T00083_A27ConquistaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
            Z30UsuarioConquistaId = A30UsuarioConquistaId;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load088( ) ;
            if ( AnyError == 1 )
            {
               RcdFound8 = 0;
               InitializeNonKey088( ) ;
            }
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey088( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey088( ) ;
         if ( RcdFound8 == 0 )
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
         RcdFound8 = 0;
         /* Using cursor T000810 */
         pr_default.execute(8, new Object[] {A30UsuarioConquistaId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000810_A30UsuarioConquistaId[0] < A30UsuarioConquistaId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000810_A30UsuarioConquistaId[0] > A30UsuarioConquistaId ) ) )
            {
               A30UsuarioConquistaId = T000810_A30UsuarioConquistaId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A30UsuarioConquistaId), 18, 0)));
               RcdFound8 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound8 = 0;
         /* Using cursor T000811 */
         pr_default.execute(9, new Object[] {A30UsuarioConquistaId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000811_A30UsuarioConquistaId[0] > A30UsuarioConquistaId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000811_A30UsuarioConquistaId[0] < A30UsuarioConquistaId ) ) )
            {
               A30UsuarioConquistaId = T000811_A30UsuarioConquistaId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A30UsuarioConquistaId), 18, 0)));
               RcdFound8 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey088( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUsuarioConquistaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert088( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound8 == 1 )
            {
               if ( A30UsuarioConquistaId != Z30UsuarioConquistaId )
               {
                  A30UsuarioConquistaId = Z30UsuarioConquistaId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A30UsuarioConquistaId), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "USUARIOCONQUISTAID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioConquistaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtUsuarioConquistaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update088( ) ;
                  GX_FocusControl = edtUsuarioConquistaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A30UsuarioConquistaId != Z30UsuarioConquistaId )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtUsuarioConquistaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert088( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "USUARIOCONQUISTAID");
                     AnyError = 1;
                     GX_FocusControl = edtUsuarioConquistaId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtUsuarioConquistaId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert088( ) ;
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
         if ( A30UsuarioConquistaId != Z30UsuarioConquistaId )
         {
            A30UsuarioConquistaId = Z30UsuarioConquistaId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A30UsuarioConquistaId), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "USUARIOCONQUISTAID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioConquistaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUsuarioConquistaId_Internalname;
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
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "USUARIOCONQUISTAID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioConquistaId_Internalname;
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
         ScanStart088( ) ;
         if ( RcdFound8 == 0 )
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
         ScanEnd088( ) ;
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
         if ( RcdFound8 == 0 )
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
         if ( RcdFound8 == 0 )
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
         ScanStart088( ) ;
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound8 != 0 )
            {
               ScanNext088( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd088( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency088( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00082 */
            pr_default.execute(0, new Object[] {A30UsuarioConquistaId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioConquista"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z31UsuarioConquistaDataHora != T00082_A31UsuarioConquistaDataHora[0] ) || ( Z11UsuarioId != T00082_A11UsuarioId[0] ) || ( Z27ConquistaId != T00082_A27ConquistaId[0] ) )
            {
               if ( Z31UsuarioConquistaDataHora != T00082_A31UsuarioConquistaDataHora[0] )
               {
                  GXUtil.WriteLog("usuarioconquista:[seudo value changed for attri]"+"UsuarioConquistaDataHora");
                  GXUtil.WriteLogRaw("Old: ",Z31UsuarioConquistaDataHora);
                  GXUtil.WriteLogRaw("Current: ",T00082_A31UsuarioConquistaDataHora[0]);
               }
               if ( Z11UsuarioId != T00082_A11UsuarioId[0] )
               {
                  GXUtil.WriteLog("usuarioconquista:[seudo value changed for attri]"+"UsuarioId");
                  GXUtil.WriteLogRaw("Old: ",Z11UsuarioId);
                  GXUtil.WriteLogRaw("Current: ",T00082_A11UsuarioId[0]);
               }
               if ( Z27ConquistaId != T00082_A27ConquistaId[0] )
               {
                  GXUtil.WriteLog("usuarioconquista:[seudo value changed for attri]"+"ConquistaId");
                  GXUtil.WriteLogRaw("Old: ",Z27ConquistaId);
                  GXUtil.WriteLogRaw("Current: ",T00082_A27ConquistaId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"UsuarioConquista"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert088( )
      {
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable088( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM088( 0) ;
            CheckOptimisticConcurrency088( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm088( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert088( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000812 */
                     pr_default.execute(10, new Object[] {A31UsuarioConquistaDataHora, A11UsuarioId, A27ConquistaId});
                     A30UsuarioConquistaId = T000812_A30UsuarioConquistaId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A30UsuarioConquistaId), 18, 0)));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioConquista") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption080( ) ;
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
               Load088( ) ;
            }
            EndLevel088( ) ;
         }
         CloseExtendedTableCursors088( ) ;
      }

      protected void Update088( )
      {
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable088( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency088( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm088( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate088( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000813 */
                     pr_default.execute(11, new Object[] {A31UsuarioConquistaDataHora, A11UsuarioId, A27ConquistaId, A30UsuarioConquistaId});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioConquista") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioConquista"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate088( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption080( ) ;
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
            EndLevel088( ) ;
         }
         CloseExtendedTableCursors088( ) ;
      }

      protected void DeferredUpdate088( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency088( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls088( ) ;
            AfterConfirm088( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete088( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000814 */
                  pr_default.execute(12, new Object[] {A30UsuarioConquistaId});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("UsuarioConquista") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound8 == 0 )
                        {
                           InitAll088( ) ;
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
                        ResetCaption080( ) ;
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
         sMode8 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel088( ) ;
         Gx_mode = sMode8;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls088( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000815 */
            pr_default.execute(13, new Object[] {A27ConquistaId});
            A29ConquistaNome = T000815_A29ConquistaNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29ConquistaNome", A29ConquistaNome);
            A28ConquistaPontos = T000815_A28ConquistaPontos[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ConquistaPontos), 4, 0)));
            pr_default.close(13);
         }
      }

      protected void EndLevel088( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete088( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_gam.commit( "UsuarioConquista");
            pr_default.commit( "UsuarioConquista");
            if ( AnyError == 0 )
            {
               ConfirmValues080( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_gam.rollback( "UsuarioConquista");
            pr_default.rollback( "UsuarioConquista");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart088( )
      {
         /* Using cursor T000816 */
         pr_default.execute(14);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound8 = 1;
            A30UsuarioConquistaId = T000816_A30UsuarioConquistaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A30UsuarioConquistaId), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext088( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound8 = 1;
            A30UsuarioConquistaId = T000816_A30UsuarioConquistaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A30UsuarioConquistaId), 18, 0)));
         }
      }

      protected void ScanEnd088( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm088( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert088( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate088( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete088( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete088( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate088( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes088( )
      {
         edtUsuarioConquistaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioConquistaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioConquistaId_Enabled), 5, 0)), true);
         edtUsuarioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioId_Enabled), 5, 0)), true);
         edtConquistaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaId_Enabled), 5, 0)), true);
         edtConquistaNome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaNome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaNome_Enabled), 5, 0)), true);
         edtConquistaPontos_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConquistaPontos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConquistaPontos_Enabled), 5, 0)), true);
         edtUsuarioConquistaDataHora_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioConquistaDataHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioConquistaDataHora_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes088( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues080( )
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
         context.AddJavascriptSource("gxcfg.js", "?20189251963126", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("usuarioconquista.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z30UsuarioConquistaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z30UsuarioConquistaId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z31UsuarioConquistaDataHora", context.localUtil.TToC( Z31UsuarioConquistaDataHora, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z11UsuarioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11UsuarioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z27ConquistaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27ConquistaId), 18, 0, ",", "")));
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
         return formatLink("usuarioconquista.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "UsuarioConquista" ;
      }

      public override String GetPgmdesc( )
      {
         return "Usuário conquista" ;
      }

      protected void InitializeNonKey088( )
      {
         A11UsuarioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
         A27ConquistaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A27ConquistaId), 18, 0)));
         A29ConquistaNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29ConquistaNome", A29ConquistaNome);
         A28ConquistaPontos = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28ConquistaPontos", StringUtil.LTrim( StringUtil.Str( (decimal)(A28ConquistaPontos), 4, 0)));
         A31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31UsuarioConquistaDataHora", context.localUtil.TToC( A31UsuarioConquistaDataHora, 8, 5, 0, 3, "/", ":", " "));
         Z31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
         Z11UsuarioId = 0;
         Z27ConquistaId = 0;
      }

      protected void InitAll088( )
      {
         A30UsuarioConquistaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A30UsuarioConquistaId), 18, 0)));
         InitializeNonKey088( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20189251963132", true);
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
         context.AddJavascriptSource("usuarioconquista.js", "?20189251963133", false);
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
         edtUsuarioConquistaId_Internalname = "USUARIOCONQUISTAID";
         edtUsuarioId_Internalname = "USUARIOID";
         edtConquistaId_Internalname = "CONQUISTAID";
         edtConquistaNome_Internalname = "CONQUISTANOME";
         edtConquistaPontos_Internalname = "CONQUISTAPONTOS";
         edtUsuarioConquistaDataHora_Internalname = "USUARIOCONQUISTADATAHORA";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         Form.Internalname = "FORM";
         imgprompt_11_Internalname = "PROMPT_11";
         imgprompt_27_Internalname = "PROMPT_27";
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
         Form.Caption = "Usuário conquista";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtUsuarioConquistaDataHora_Jsonclick = "";
         edtUsuarioConquistaDataHora_Enabled = 1;
         edtConquistaPontos_Jsonclick = "";
         edtConquistaPontos_Enabled = 0;
         edtConquistaNome_Jsonclick = "";
         edtConquistaNome_Enabled = 0;
         imgprompt_27_Visible = 1;
         imgprompt_27_Link = "";
         edtConquistaId_Jsonclick = "";
         edtConquistaId_Enabled = 1;
         imgprompt_11_Visible = 1;
         imgprompt_11_Link = "";
         edtUsuarioId_Jsonclick = "";
         edtUsuarioId_Enabled = 1;
         edtUsuarioConquistaId_Jsonclick = "";
         edtUsuarioConquistaId_Enabled = 1;
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

      public void Valid_Usuarioconquistaid( long GX_Parm1 ,
                                            DateTime GX_Parm2 ,
                                            long GX_Parm3 ,
                                            long GX_Parm4 )
      {
         A30UsuarioConquistaId = GX_Parm1;
         A31UsuarioConquistaDataHora = GX_Parm2;
         A11UsuarioId = GX_Parm3;
         A27ConquistaId = GX_Parm4;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A29ConquistaNome = "";
            A28ConquistaPontos = 0;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ConquistaId), 18, 0, ".", "")));
         isValidOutput.Add(context.localUtil.TToC( A31UsuarioConquistaDataHora, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(A29ConquistaNome);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A28ConquistaPontos), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z30UsuarioConquistaId), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11UsuarioId), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27ConquistaId), 18, 0, ",", "")));
         isValidOutput.Add(context.localUtil.TToC( Z31UsuarioConquistaDataHora, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(Z29ConquistaNome);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28ConquistaPontos), 4, 0, ".", "")));
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
         /* Using cursor T000817 */
         pr_default.execute(15, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioId_Internalname;
         }
         pr_default.close(15);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Conquistaid( long GX_Parm1 ,
                                     String GX_Parm2 ,
                                     short GX_Parm3 )
      {
         A27ConquistaId = GX_Parm1;
         A29ConquistaNome = GX_Parm2;
         A28ConquistaPontos = GX_Parm3;
         /* Using cursor T000815 */
         pr_default.execute(13, new Object[] {A27ConquistaId});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("Não existe 'Conquista'.", "ForeignKeyNotFound", 1, "CONQUISTAID");
            AnyError = 1;
            GX_FocusControl = edtConquistaId_Internalname;
         }
         A29ConquistaNome = T000815_A29ConquistaNome[0];
         A28ConquistaPontos = T000815_A28ConquistaPontos[0];
         pr_default.close(13);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A29ConquistaNome = "";
            A28ConquistaPontos = 0;
         }
         isValidOutput.Add(A29ConquistaNome);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A28ConquistaPontos), 4, 0, ".", "")));
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
         pr_default.close(15);
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
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
         A29ConquistaNome = "";
         A31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z29ConquistaNome = "";
         T00086_A30UsuarioConquistaId = new long[1] ;
         T00086_A29ConquistaNome = new String[] {""} ;
         T00086_A28ConquistaPontos = new short[1] ;
         T00086_A31UsuarioConquistaDataHora = new DateTime[] {DateTime.MinValue} ;
         T00086_A11UsuarioId = new long[1] ;
         T00086_A27ConquistaId = new long[1] ;
         T00084_A11UsuarioId = new long[1] ;
         T00085_A29ConquistaNome = new String[] {""} ;
         T00085_A28ConquistaPontos = new short[1] ;
         T00087_A11UsuarioId = new long[1] ;
         T00088_A29ConquistaNome = new String[] {""} ;
         T00088_A28ConquistaPontos = new short[1] ;
         T00089_A30UsuarioConquistaId = new long[1] ;
         T00083_A30UsuarioConquistaId = new long[1] ;
         T00083_A31UsuarioConquistaDataHora = new DateTime[] {DateTime.MinValue} ;
         T00083_A11UsuarioId = new long[1] ;
         T00083_A27ConquistaId = new long[1] ;
         sMode8 = "";
         T000810_A30UsuarioConquistaId = new long[1] ;
         T000811_A30UsuarioConquistaId = new long[1] ;
         T00082_A30UsuarioConquistaId = new long[1] ;
         T00082_A31UsuarioConquistaDataHora = new DateTime[] {DateTime.MinValue} ;
         T00082_A11UsuarioId = new long[1] ;
         T00082_A27ConquistaId = new long[1] ;
         T000812_A30UsuarioConquistaId = new long[1] ;
         T000815_A29ConquistaNome = new String[] {""} ;
         T000815_A28ConquistaPontos = new short[1] ;
         T000816_A30UsuarioConquistaId = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000817_A11UsuarioId = new long[1] ;
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.usuarioconquista__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuarioconquista__default(),
            new Object[][] {
                new Object[] {
               T00082_A30UsuarioConquistaId, T00082_A31UsuarioConquistaDataHora, T00082_A11UsuarioId, T00082_A27ConquistaId
               }
               , new Object[] {
               T00083_A30UsuarioConquistaId, T00083_A31UsuarioConquistaDataHora, T00083_A11UsuarioId, T00083_A27ConquistaId
               }
               , new Object[] {
               T00084_A11UsuarioId
               }
               , new Object[] {
               T00085_A29ConquistaNome, T00085_A28ConquistaPontos
               }
               , new Object[] {
               T00086_A30UsuarioConquistaId, T00086_A29ConquistaNome, T00086_A28ConquistaPontos, T00086_A31UsuarioConquistaDataHora, T00086_A11UsuarioId, T00086_A27ConquistaId
               }
               , new Object[] {
               T00087_A11UsuarioId
               }
               , new Object[] {
               T00088_A29ConquistaNome, T00088_A28ConquistaPontos
               }
               , new Object[] {
               T00089_A30UsuarioConquistaId
               }
               , new Object[] {
               T000810_A30UsuarioConquistaId
               }
               , new Object[] {
               T000811_A30UsuarioConquistaId
               }
               , new Object[] {
               T000812_A30UsuarioConquistaId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000815_A29ConquistaNome, T000815_A28ConquistaPontos
               }
               , new Object[] {
               T000816_A30UsuarioConquistaId
               }
               , new Object[] {
               T000817_A11UsuarioId
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A28ConquistaPontos ;
      private short GX_JID ;
      private short Z28ConquistaPontos ;
      private short RcdFound8 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUsuarioConquistaId_Enabled ;
      private int edtUsuarioId_Enabled ;
      private int imgprompt_11_Visible ;
      private int edtConquistaId_Enabled ;
      private int imgprompt_27_Visible ;
      private int edtConquistaNome_Enabled ;
      private int edtConquistaPontos_Enabled ;
      private int edtUsuarioConquistaDataHora_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z30UsuarioConquistaId ;
      private long Z11UsuarioId ;
      private long Z27ConquistaId ;
      private long A11UsuarioId ;
      private long A27ConquistaId ;
      private long A30UsuarioConquistaId ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUsuarioConquistaId_Internalname ;
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
      private String edtUsuarioConquistaId_Jsonclick ;
      private String edtUsuarioId_Internalname ;
      private String edtUsuarioId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_11_Internalname ;
      private String imgprompt_11_Link ;
      private String edtConquistaId_Internalname ;
      private String edtConquistaId_Jsonclick ;
      private String imgprompt_27_Internalname ;
      private String imgprompt_27_Link ;
      private String edtConquistaNome_Internalname ;
      private String edtConquistaNome_Jsonclick ;
      private String edtConquistaPontos_Internalname ;
      private String edtConquistaPontos_Jsonclick ;
      private String edtUsuarioConquistaDataHora_Internalname ;
      private String edtUsuarioConquistaDataHora_Jsonclick ;
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
      private String sMode8 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z31UsuarioConquistaDataHora ;
      private DateTime A31UsuarioConquistaDataHora ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private String A29ConquistaNome ;
      private String Z29ConquistaNome ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T00086_A30UsuarioConquistaId ;
      private String[] T00086_A29ConquistaNome ;
      private short[] T00086_A28ConquistaPontos ;
      private DateTime[] T00086_A31UsuarioConquistaDataHora ;
      private long[] T00086_A11UsuarioId ;
      private long[] T00086_A27ConquistaId ;
      private long[] T00084_A11UsuarioId ;
      private String[] T00085_A29ConquistaNome ;
      private short[] T00085_A28ConquistaPontos ;
      private long[] T00087_A11UsuarioId ;
      private String[] T00088_A29ConquistaNome ;
      private short[] T00088_A28ConquistaPontos ;
      private long[] T00089_A30UsuarioConquistaId ;
      private long[] T00083_A30UsuarioConquistaId ;
      private DateTime[] T00083_A31UsuarioConquistaDataHora ;
      private long[] T00083_A11UsuarioId ;
      private long[] T00083_A27ConquistaId ;
      private long[] T000810_A30UsuarioConquistaId ;
      private long[] T000811_A30UsuarioConquistaId ;
      private long[] T00082_A30UsuarioConquistaId ;
      private DateTime[] T00082_A31UsuarioConquistaDataHora ;
      private long[] T00082_A11UsuarioId ;
      private long[] T00082_A27ConquistaId ;
      private long[] T000812_A30UsuarioConquistaId ;
      private String[] T000815_A29ConquistaNome ;
      private short[] T000815_A28ConquistaPontos ;
      private IDataStoreProvider pr_gam ;
      private long[] T000816_A30UsuarioConquistaId ;
      private long[] T000817_A11UsuarioId ;
      private GXWebForm Form ;
   }

   public class usuarioconquista__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class usuarioconquista__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[9])
       ,new ForEachCursor(def[10])
       ,new UpdateCursor(def[11])
       ,new UpdateCursor(def[12])
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
       ,new ForEachCursor(def[15])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00086 ;
        prmT00086 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00084 ;
        prmT00084 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00085 ;
        prmT00085 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00087 ;
        prmT00087 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00088 ;
        prmT00088 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00089 ;
        prmT00089 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00083 ;
        prmT00083 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000810 ;
        prmT000810 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000811 ;
        prmT000811 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00082 ;
        prmT00082 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000812 ;
        prmT000812 = new Object[] {
        new Object[] {"@UsuarioConquistaDataHora",SqlDbType.DateTime,8,5} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000813 ;
        prmT000813 = new Object[] {
        new Object[] {"@UsuarioConquistaDataHora",SqlDbType.DateTime,8,5} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000814 ;
        prmT000814 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000816 ;
        prmT000816 = new Object[] {
        } ;
        Object[] prmT000817 ;
        prmT000817 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000815 ;
        prmT000815 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00082", "SELECT [UsuarioConquistaId], [UsuarioConquistaDataHora], [UsuarioId], [ConquistaId] FROM [UsuarioConquista] WITH (UPDLOCK) WHERE [UsuarioConquistaId] = @UsuarioConquistaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00082,1,0,true,false )
           ,new CursorDef("T00083", "SELECT [UsuarioConquistaId], [UsuarioConquistaDataHora], [UsuarioId], [ConquistaId] FROM [UsuarioConquista] WITH (NOLOCK) WHERE [UsuarioConquistaId] = @UsuarioConquistaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00083,1,0,true,false )
           ,new CursorDef("T00084", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00084,1,0,true,false )
           ,new CursorDef("T00085", "SELECT [ConquistaNome], [ConquistaPontos] FROM [Conquista] WITH (NOLOCK) WHERE [ConquistaId] = @ConquistaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00085,1,0,true,false )
           ,new CursorDef("T00086", "SELECT TM1.[UsuarioConquistaId], T2.[ConquistaNome], T2.[ConquistaPontos], TM1.[UsuarioConquistaDataHora], TM1.[UsuarioId], TM1.[ConquistaId] FROM ([UsuarioConquista] TM1 WITH (NOLOCK) INNER JOIN [Conquista] T2 WITH (NOLOCK) ON T2.[ConquistaId] = TM1.[ConquistaId]) WHERE TM1.[UsuarioConquistaId] = @UsuarioConquistaId ORDER BY TM1.[UsuarioConquistaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00086,100,0,true,false )
           ,new CursorDef("T00087", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00087,1,0,true,false )
           ,new CursorDef("T00088", "SELECT [ConquistaNome], [ConquistaPontos] FROM [Conquista] WITH (NOLOCK) WHERE [ConquistaId] = @ConquistaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00088,1,0,true,false )
           ,new CursorDef("T00089", "SELECT [UsuarioConquistaId] FROM [UsuarioConquista] WITH (NOLOCK) WHERE [UsuarioConquistaId] = @UsuarioConquistaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00089,1,0,true,false )
           ,new CursorDef("T000810", "SELECT TOP 1 [UsuarioConquistaId] FROM [UsuarioConquista] WITH (NOLOCK) WHERE ( [UsuarioConquistaId] > @UsuarioConquistaId) ORDER BY [UsuarioConquistaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000810,1,0,true,true )
           ,new CursorDef("T000811", "SELECT TOP 1 [UsuarioConquistaId] FROM [UsuarioConquista] WITH (NOLOCK) WHERE ( [UsuarioConquistaId] < @UsuarioConquistaId) ORDER BY [UsuarioConquistaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000811,1,0,true,true )
           ,new CursorDef("T000812", "INSERT INTO [UsuarioConquista]([UsuarioConquistaDataHora], [UsuarioId], [ConquistaId]) VALUES(@UsuarioConquistaDataHora, @UsuarioId, @ConquistaId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000812)
           ,new CursorDef("T000813", "UPDATE [UsuarioConquista] SET [UsuarioConquistaDataHora]=@UsuarioConquistaDataHora, [UsuarioId]=@UsuarioId, [ConquistaId]=@ConquistaId  WHERE [UsuarioConquistaId] = @UsuarioConquistaId", GxErrorMask.GX_NOMASK,prmT000813)
           ,new CursorDef("T000814", "DELETE FROM [UsuarioConquista]  WHERE [UsuarioConquistaId] = @UsuarioConquistaId", GxErrorMask.GX_NOMASK,prmT000814)
           ,new CursorDef("T000815", "SELECT [ConquistaNome], [ConquistaPontos] FROM [Conquista] WITH (NOLOCK) WHERE [ConquistaId] = @ConquistaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000815,1,0,true,false )
           ,new CursorDef("T000816", "SELECT [UsuarioConquistaId] FROM [UsuarioConquista] WITH (NOLOCK) ORDER BY [UsuarioConquistaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000816,100,0,true,false )
           ,new CursorDef("T000817", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000817,1,0,true,false )
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
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
              ((long[]) buf[2])[0] = rslt.getLong(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
              ((long[]) buf[4])[0] = rslt.getLong(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 10 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 13 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 14 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 15 :
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 10 :
              stmt.SetParameterDatetime(1, (DateTime)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              stmt.SetParameter(3, (long)parms[2]);
              return;
           case 11 :
              stmt.SetParameterDatetime(1, (DateTime)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              stmt.SetParameter(3, (long)parms[2]);
              stmt.SetParameter(4, (long)parms[3]);
              return;
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 15 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
