/*
               File: UsuarioSerie
        Description: Usuário série
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:14.81
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
   public class usuarioserie : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A11UsuarioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_2( A11UsuarioId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A1SerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A1SerieId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A48GeneroId = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A48GeneroId) ;
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
         chkUsuarioSerieAssistida.Name = "USUARIOSERIEASSISTIDA";
         chkUsuarioSerieAssistida.WebTags = "";
         chkUsuarioSerieAssistida.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioSerieAssistida_Internalname, "TitleCaption", chkUsuarioSerieAssistida.Caption, true);
         chkUsuarioSerieAssistida.CheckedValue = "false";
         chkUsuarioSerieFavorita.Name = "USUARIOSERIEFAVORITA";
         chkUsuarioSerieFavorita.WebTags = "";
         chkUsuarioSerieFavorita.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioSerieFavorita_Internalname, "TitleCaption", chkUsuarioSerieFavorita.Caption, true);
         chkUsuarioSerieFavorita.CheckedValue = "false";
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
            Form.Meta.addItem("description", "Usuário série", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUsuarioSerieId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public usuarioserie( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public usuarioserie( IGxContext context )
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
         chkUsuarioSerieAssistida = new GXCheckbox();
         chkUsuarioSerieFavorita = new GXCheckbox();
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Usuário série", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_UsuarioSerie.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Selecionar", bttBtn_select_Jsonclick, 4, "Selecionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIOSERIEID"+"'), id:'"+"USUARIOSERIEID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_UsuarioSerie.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioSerieId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioSerieId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioSerieId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13UsuarioSerieId), 18, 0, ",", "")), ((edtUsuarioSerieId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A13UsuarioSerieId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A13UsuarioSerieId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioSerieId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioSerieId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioSerie.htm");
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
            GxWebStd.gx_single_line_edit( context, edtUsuarioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ",", "")), ((edtUsuarioId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioSerie.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_11_Internalname, sImgUrl, imgprompt_11_Link, "", "", context.GetTheme( ), imgprompt_11_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSerieId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSerieId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSerieId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")), ((edtSerieId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSerieId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSerieId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioSerie.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSerieNome_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSerieNome_Internalname, "Nome", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSerieNome_Internalname, A2SerieNome, StringUtil.RTrim( context.localUtil.Format( A2SerieNome, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSerieNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSerieNome_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Nome", "left", true, "HLP_UsuarioSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgSerieImagem_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, imgSerieImagem_Internalname, "Imagem", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Static Bitmap Variable */
            ClassString = "Attribute";
            StyleString = "";
            A43SerieImagem_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000SerieImagem_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.PathToRelativeUrl( A43SerieImagem));
            GxWebStd.gx_bitmap( context, imgSerieImagem_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgSerieImagem_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 0, A43SerieImagem_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioSerie.htm");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.PathToRelativeUrl( A43SerieImagem)), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "IsBlob", StringUtil.BoolToStr( A43SerieImagem_IsBlob), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtGeneroNome_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtGeneroNome_Internalname, "Nome", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtGeneroNome_Internalname, A49GeneroNome, StringUtil.RTrim( context.localUtil.Format( A49GeneroNome, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtGeneroNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtGeneroNome_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Nome", "left", true, "HLP_UsuarioSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioSerieNota_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioSerieNota_Internalname, "Nota", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioSerieNota_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A14UsuarioSerieNota), 1, 0, ",", "")), ((edtUsuarioSerieNota_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A14UsuarioSerieNota), "9")) : context.localUtil.Format( (decimal)(A14UsuarioSerieNota), "9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioSerieNota_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioSerieNota_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "Nota", "right", false, "HLP_UsuarioSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkUsuarioSerieAssistida_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkUsuarioSerieAssistida_Internalname, "Assistida", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkUsuarioSerieAssistida_Internalname, StringUtil.BoolToStr( A15UsuarioSerieAssistida), "", "Assistida", 1, chkUsuarioSerieAssistida.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(63, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,63);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioSerieComentario_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioSerieComentario_Internalname, "Comentário", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtUsuarioSerieComentario_Internalname, A16UsuarioSerieComentario, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,68);\"", 0, 1, edtUsuarioSerieComentario_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "Comentario", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_UsuarioSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkUsuarioSerieFavorita_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkUsuarioSerieFavorita_Internalname, "favorita", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkUsuarioSerieFavorita_Internalname, StringUtil.BoolToStr( A17UsuarioSerieFavorita), "", "favorita", 1, chkUsuarioSerieFavorita.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(73, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,73);\"");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioSerie.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioSerieId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioSerieId_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIOSERIEID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioSerieId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A13UsuarioSerieId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13UsuarioSerieId), 18, 0)));
               }
               else
               {
                  A13UsuarioSerieId = (long)(context.localUtil.CToN( cgiGet( edtUsuarioSerieId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13UsuarioSerieId), 18, 0)));
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtSerieId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSerieId_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SERIEID");
                  AnyError = 1;
                  GX_FocusControl = edtSerieId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A1SerieId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
               }
               else
               {
                  A1SerieId = (long)(context.localUtil.CToN( cgiGet( edtSerieId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
               }
               A2SerieNome = cgiGet( edtSerieNome_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SerieNome", A2SerieNome);
               A43SerieImagem = cgiGet( imgSerieImagem_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43SerieImagem", A43SerieImagem);
               A49GeneroNome = cgiGet( edtGeneroNome_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49GeneroNome", A49GeneroNome);
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioSerieNota_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioSerieNota_Internalname), ",", ".") > Convert.ToDecimal( 9 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIOSERIENOTA");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioSerieNota_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A14UsuarioSerieNota = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14UsuarioSerieNota", StringUtil.Str( (decimal)(A14UsuarioSerieNota), 1, 0));
               }
               else
               {
                  A14UsuarioSerieNota = (short)(context.localUtil.CToN( cgiGet( edtUsuarioSerieNota_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14UsuarioSerieNota", StringUtil.Str( (decimal)(A14UsuarioSerieNota), 1, 0));
               }
               A15UsuarioSerieAssistida = StringUtil.StrToBool( cgiGet( chkUsuarioSerieAssistida_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15UsuarioSerieAssistida", A15UsuarioSerieAssistida);
               A16UsuarioSerieComentario = cgiGet( edtUsuarioSerieComentario_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16UsuarioSerieComentario", A16UsuarioSerieComentario);
               A17UsuarioSerieFavorita = StringUtil.StrToBool( cgiGet( chkUsuarioSerieFavorita_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17UsuarioSerieFavorita", A17UsuarioSerieFavorita);
               /* Read saved values. */
               Z13UsuarioSerieId = (long)(context.localUtil.CToN( cgiGet( "Z13UsuarioSerieId"), ",", "."));
               Z14UsuarioSerieNota = (short)(context.localUtil.CToN( cgiGet( "Z14UsuarioSerieNota"), ",", "."));
               Z15UsuarioSerieAssistida = StringUtil.StrToBool( cgiGet( "Z15UsuarioSerieAssistida"));
               Z16UsuarioSerieComentario = cgiGet( "Z16UsuarioSerieComentario");
               Z17UsuarioSerieFavorita = StringUtil.StrToBool( cgiGet( "Z17UsuarioSerieFavorita"));
               Z11UsuarioId = (long)(context.localUtil.CToN( cgiGet( "Z11UsuarioId"), ",", "."));
               Z1SerieId = (long)(context.localUtil.CToN( cgiGet( "Z1SerieId"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               A48GeneroId = (long)(context.localUtil.CToN( cgiGet( "GENEROID"), ",", "."));
               A40000SerieImagem_GXI = cgiGet( "SERIEIMAGEM_GXI");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               getMultimediaValue(imgSerieImagem_Internalname, ref  A43SerieImagem, ref  A40000SerieImagem_GXI);
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
                  A13UsuarioSerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13UsuarioSerieId), 18, 0)));
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
               InitAll044( ) ;
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
         DisableAttributes044( ) ;
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

      protected void ResetCaption040( )
      {
      }

      protected void ZM044( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z14UsuarioSerieNota = T00043_A14UsuarioSerieNota[0];
               Z15UsuarioSerieAssistida = T00043_A15UsuarioSerieAssistida[0];
               Z16UsuarioSerieComentario = T00043_A16UsuarioSerieComentario[0];
               Z17UsuarioSerieFavorita = T00043_A17UsuarioSerieFavorita[0];
               Z11UsuarioId = T00043_A11UsuarioId[0];
               Z1SerieId = T00043_A1SerieId[0];
            }
            else
            {
               Z14UsuarioSerieNota = A14UsuarioSerieNota;
               Z15UsuarioSerieAssistida = A15UsuarioSerieAssistida;
               Z16UsuarioSerieComentario = A16UsuarioSerieComentario;
               Z17UsuarioSerieFavorita = A17UsuarioSerieFavorita;
               Z11UsuarioId = A11UsuarioId;
               Z1SerieId = A1SerieId;
            }
         }
         if ( GX_JID == -1 )
         {
            Z13UsuarioSerieId = A13UsuarioSerieId;
            Z14UsuarioSerieNota = A14UsuarioSerieNota;
            Z15UsuarioSerieAssistida = A15UsuarioSerieAssistida;
            Z16UsuarioSerieComentario = A16UsuarioSerieComentario;
            Z17UsuarioSerieFavorita = A17UsuarioSerieFavorita;
            Z11UsuarioId = A11UsuarioId;
            Z1SerieId = A1SerieId;
            Z48GeneroId = A48GeneroId;
            Z2SerieNome = A2SerieNome;
            Z43SerieImagem = A43SerieImagem;
            Z40000SerieImagem_GXI = A40000SerieImagem_GXI;
            Z49GeneroNome = A49GeneroNome;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_11_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIOID"+"'), id:'"+"USUARIOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"SERIEID"+"'), id:'"+"SERIEID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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

      protected void Load044( )
      {
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {A13UsuarioSerieId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound4 = 1;
            A48GeneroId = T00047_A48GeneroId[0];
            A2SerieNome = T00047_A2SerieNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SerieNome", A2SerieNome);
            A40000SerieImagem_GXI = T00047_A40000SerieImagem_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
            A49GeneroNome = T00047_A49GeneroNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49GeneroNome", A49GeneroNome);
            A14UsuarioSerieNota = T00047_A14UsuarioSerieNota[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14UsuarioSerieNota", StringUtil.Str( (decimal)(A14UsuarioSerieNota), 1, 0));
            A15UsuarioSerieAssistida = T00047_A15UsuarioSerieAssistida[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15UsuarioSerieAssistida", A15UsuarioSerieAssistida);
            A16UsuarioSerieComentario = T00047_A16UsuarioSerieComentario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16UsuarioSerieComentario", A16UsuarioSerieComentario);
            A17UsuarioSerieFavorita = T00047_A17UsuarioSerieFavorita[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17UsuarioSerieFavorita", A17UsuarioSerieFavorita);
            A11UsuarioId = T00047_A11UsuarioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            A1SerieId = T00047_A1SerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
            A43SerieImagem = T00047_A43SerieImagem[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43SerieImagem", A43SerieImagem);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
            ZM044( -1) ;
         }
         pr_default.close(5);
         OnLoadActions044( ) ;
      }

      protected void OnLoadActions044( )
      {
      }

      protected void CheckExtendedTable044( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00044 */
         pr_default.execute(2, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         /* Using cursor T00045 */
         pr_default.execute(3, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("Não existe 'Série'.", "ForeignKeyNotFound", 1, "SERIEID");
            AnyError = 1;
            GX_FocusControl = edtSerieId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A48GeneroId = T00045_A48GeneroId[0];
         A2SerieNome = T00045_A2SerieNome[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SerieNome", A2SerieNome);
         A40000SerieImagem_GXI = T00045_A40000SerieImagem_GXI[0];
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
         A43SerieImagem = T00045_A43SerieImagem[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43SerieImagem", A43SerieImagem);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
         pr_default.close(3);
         /* Using cursor T00046 */
         pr_default.execute(4, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("Não existe 'Gênero'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A49GeneroNome = T00046_A49GeneroNome[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49GeneroNome", A49GeneroNome);
         pr_default.close(4);
      }

      protected void CloseExtendedTableCursors044( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( long A11UsuarioId )
      {
         /* Using cursor T00048 */
         pr_default.execute(6, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(6) == 101) )
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
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void gxLoad_3( long A1SerieId )
      {
         /* Using cursor T00049 */
         pr_default.execute(7, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("Não existe 'Série'.", "ForeignKeyNotFound", 1, "SERIEID");
            AnyError = 1;
            GX_FocusControl = edtSerieId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A48GeneroId = T00049_A48GeneroId[0];
         A2SerieNome = T00049_A2SerieNome[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SerieNome", A2SerieNome);
         A40000SerieImagem_GXI = T00049_A40000SerieImagem_GXI[0];
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
         A43SerieImagem = T00049_A43SerieImagem[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43SerieImagem", A43SerieImagem);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A48GeneroId), 18, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( A2SerieNome)+"\""+","+"\""+GXUtil.EncodeJSConstant( A43SerieImagem)+"\""+","+"\""+GXUtil.EncodeJSConstant( A40000SerieImagem_GXI)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(7);
      }

      protected void gxLoad_4( long A48GeneroId )
      {
         /* Using cursor T000410 */
         pr_default.execute(8, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("Não existe 'Gênero'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A49GeneroNome = T000410_A49GeneroNome[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49GeneroNome", A49GeneroNome);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A49GeneroNome)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(8);
      }

      protected void GetKey044( )
      {
         /* Using cursor T000411 */
         pr_default.execute(9, new Object[] {A13UsuarioSerieId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {A13UsuarioSerieId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM044( 1) ;
            RcdFound4 = 1;
            A13UsuarioSerieId = T00043_A13UsuarioSerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13UsuarioSerieId), 18, 0)));
            A14UsuarioSerieNota = T00043_A14UsuarioSerieNota[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14UsuarioSerieNota", StringUtil.Str( (decimal)(A14UsuarioSerieNota), 1, 0));
            A15UsuarioSerieAssistida = T00043_A15UsuarioSerieAssistida[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15UsuarioSerieAssistida", A15UsuarioSerieAssistida);
            A16UsuarioSerieComentario = T00043_A16UsuarioSerieComentario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16UsuarioSerieComentario", A16UsuarioSerieComentario);
            A17UsuarioSerieFavorita = T00043_A17UsuarioSerieFavorita[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17UsuarioSerieFavorita", A17UsuarioSerieFavorita);
            A11UsuarioId = T00043_A11UsuarioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            A1SerieId = T00043_A1SerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
            Z13UsuarioSerieId = A13UsuarioSerieId;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load044( ) ;
            if ( AnyError == 1 )
            {
               RcdFound4 = 0;
               InitializeNonKey044( ) ;
            }
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey044( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey044( ) ;
         if ( RcdFound4 == 0 )
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
         RcdFound4 = 0;
         /* Using cursor T000412 */
         pr_default.execute(10, new Object[] {A13UsuarioSerieId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000412_A13UsuarioSerieId[0] < A13UsuarioSerieId ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000412_A13UsuarioSerieId[0] > A13UsuarioSerieId ) ) )
            {
               A13UsuarioSerieId = T000412_A13UsuarioSerieId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13UsuarioSerieId), 18, 0)));
               RcdFound4 = 1;
            }
         }
         pr_default.close(10);
      }

      protected void move_previous( )
      {
         RcdFound4 = 0;
         /* Using cursor T000413 */
         pr_default.execute(11, new Object[] {A13UsuarioSerieId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000413_A13UsuarioSerieId[0] > A13UsuarioSerieId ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000413_A13UsuarioSerieId[0] < A13UsuarioSerieId ) ) )
            {
               A13UsuarioSerieId = T000413_A13UsuarioSerieId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13UsuarioSerieId), 18, 0)));
               RcdFound4 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey044( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUsuarioSerieId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert044( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound4 == 1 )
            {
               if ( A13UsuarioSerieId != Z13UsuarioSerieId )
               {
                  A13UsuarioSerieId = Z13UsuarioSerieId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13UsuarioSerieId), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "USUARIOSERIEID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioSerieId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtUsuarioSerieId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update044( ) ;
                  GX_FocusControl = edtUsuarioSerieId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A13UsuarioSerieId != Z13UsuarioSerieId )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtUsuarioSerieId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert044( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "USUARIOSERIEID");
                     AnyError = 1;
                     GX_FocusControl = edtUsuarioSerieId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtUsuarioSerieId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert044( ) ;
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
         if ( A13UsuarioSerieId != Z13UsuarioSerieId )
         {
            A13UsuarioSerieId = Z13UsuarioSerieId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13UsuarioSerieId), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "USUARIOSERIEID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioSerieId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUsuarioSerieId_Internalname;
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
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "USUARIOSERIEID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioSerieId_Internalname;
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
         ScanStart044( ) ;
         if ( RcdFound4 == 0 )
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
         ScanEnd044( ) ;
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
         if ( RcdFound4 == 0 )
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
         if ( RcdFound4 == 0 )
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
         ScanStart044( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound4 != 0 )
            {
               ScanNext044( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd044( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency044( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00042 */
            pr_default.execute(0, new Object[] {A13UsuarioSerieId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioSerie"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z14UsuarioSerieNota != T00042_A14UsuarioSerieNota[0] ) || ( Z15UsuarioSerieAssistida != T00042_A15UsuarioSerieAssistida[0] ) || ( StringUtil.StrCmp(Z16UsuarioSerieComentario, T00042_A16UsuarioSerieComentario[0]) != 0 ) || ( Z17UsuarioSerieFavorita != T00042_A17UsuarioSerieFavorita[0] ) || ( Z11UsuarioId != T00042_A11UsuarioId[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z1SerieId != T00042_A1SerieId[0] ) )
            {
               if ( Z14UsuarioSerieNota != T00042_A14UsuarioSerieNota[0] )
               {
                  GXUtil.WriteLog("usuarioserie:[seudo value changed for attri]"+"UsuarioSerieNota");
                  GXUtil.WriteLogRaw("Old: ",Z14UsuarioSerieNota);
                  GXUtil.WriteLogRaw("Current: ",T00042_A14UsuarioSerieNota[0]);
               }
               if ( Z15UsuarioSerieAssistida != T00042_A15UsuarioSerieAssistida[0] )
               {
                  GXUtil.WriteLog("usuarioserie:[seudo value changed for attri]"+"UsuarioSerieAssistida");
                  GXUtil.WriteLogRaw("Old: ",Z15UsuarioSerieAssistida);
                  GXUtil.WriteLogRaw("Current: ",T00042_A15UsuarioSerieAssistida[0]);
               }
               if ( StringUtil.StrCmp(Z16UsuarioSerieComentario, T00042_A16UsuarioSerieComentario[0]) != 0 )
               {
                  GXUtil.WriteLog("usuarioserie:[seudo value changed for attri]"+"UsuarioSerieComentario");
                  GXUtil.WriteLogRaw("Old: ",Z16UsuarioSerieComentario);
                  GXUtil.WriteLogRaw("Current: ",T00042_A16UsuarioSerieComentario[0]);
               }
               if ( Z17UsuarioSerieFavorita != T00042_A17UsuarioSerieFavorita[0] )
               {
                  GXUtil.WriteLog("usuarioserie:[seudo value changed for attri]"+"UsuarioSerieFavorita");
                  GXUtil.WriteLogRaw("Old: ",Z17UsuarioSerieFavorita);
                  GXUtil.WriteLogRaw("Current: ",T00042_A17UsuarioSerieFavorita[0]);
               }
               if ( Z11UsuarioId != T00042_A11UsuarioId[0] )
               {
                  GXUtil.WriteLog("usuarioserie:[seudo value changed for attri]"+"UsuarioId");
                  GXUtil.WriteLogRaw("Old: ",Z11UsuarioId);
                  GXUtil.WriteLogRaw("Current: ",T00042_A11UsuarioId[0]);
               }
               if ( Z1SerieId != T00042_A1SerieId[0] )
               {
                  GXUtil.WriteLog("usuarioserie:[seudo value changed for attri]"+"SerieId");
                  GXUtil.WriteLogRaw("Old: ",Z1SerieId);
                  GXUtil.WriteLogRaw("Current: ",T00042_A1SerieId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"UsuarioSerie"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert044( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable044( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM044( 0) ;
            CheckOptimisticConcurrency044( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm044( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert044( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000414 */
                     pr_default.execute(12, new Object[] {A14UsuarioSerieNota, A15UsuarioSerieAssistida, A16UsuarioSerieComentario, A17UsuarioSerieFavorita, A11UsuarioId, A1SerieId});
                     A13UsuarioSerieId = T000414_A13UsuarioSerieId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13UsuarioSerieId), 18, 0)));
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioSerie") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption040( ) ;
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
               Load044( ) ;
            }
            EndLevel044( ) ;
         }
         CloseExtendedTableCursors044( ) ;
      }

      protected void Update044( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable044( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency044( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm044( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate044( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000415 */
                     pr_default.execute(13, new Object[] {A14UsuarioSerieNota, A15UsuarioSerieAssistida, A16UsuarioSerieComentario, A17UsuarioSerieFavorita, A11UsuarioId, A1SerieId, A13UsuarioSerieId});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioSerie") ;
                     if ( (pr_default.getStatus(13) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioSerie"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate044( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption040( ) ;
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
            EndLevel044( ) ;
         }
         CloseExtendedTableCursors044( ) ;
      }

      protected void DeferredUpdate044( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency044( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls044( ) ;
            AfterConfirm044( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete044( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000416 */
                  pr_default.execute(14, new Object[] {A13UsuarioSerieId});
                  pr_default.close(14);
                  dsDefault.SmartCacheProvider.SetUpdated("UsuarioSerie") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound4 == 0 )
                        {
                           InitAll044( ) ;
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
                        ResetCaption040( ) ;
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
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel044( ) ;
         Gx_mode = sMode4;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls044( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000417 */
            pr_default.execute(15, new Object[] {A1SerieId});
            A48GeneroId = T000417_A48GeneroId[0];
            A2SerieNome = T000417_A2SerieNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SerieNome", A2SerieNome);
            A40000SerieImagem_GXI = T000417_A40000SerieImagem_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
            A43SerieImagem = T000417_A43SerieImagem[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43SerieImagem", A43SerieImagem);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
            pr_default.close(15);
            /* Using cursor T000418 */
            pr_default.execute(16, new Object[] {A48GeneroId});
            A49GeneroNome = T000418_A49GeneroNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49GeneroNome", A49GeneroNome);
            pr_default.close(16);
         }
      }

      protected void EndLevel044( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete044( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(15);
            pr_default.close(16);
            pr_gam.commit( "UsuarioSerie");
            pr_default.commit( "UsuarioSerie");
            if ( AnyError == 0 )
            {
               ConfirmValues040( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(15);
            pr_default.close(16);
            pr_gam.rollback( "UsuarioSerie");
            pr_default.rollback( "UsuarioSerie");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart044( )
      {
         /* Using cursor T000419 */
         pr_default.execute(17);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound4 = 1;
            A13UsuarioSerieId = T000419_A13UsuarioSerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13UsuarioSerieId), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext044( )
      {
         /* Scan next routine */
         pr_default.readNext(17);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound4 = 1;
            A13UsuarioSerieId = T000419_A13UsuarioSerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13UsuarioSerieId), 18, 0)));
         }
      }

      protected void ScanEnd044( )
      {
         pr_default.close(17);
      }

      protected void AfterConfirm044( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert044( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate044( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete044( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete044( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate044( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes044( )
      {
         edtUsuarioSerieId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioSerieId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioSerieId_Enabled), 5, 0)), true);
         edtUsuarioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioId_Enabled), 5, 0)), true);
         edtSerieId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieId_Enabled), 5, 0)), true);
         edtSerieNome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieNome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieNome_Enabled), 5, 0)), true);
         imgSerieImagem_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgSerieImagem_Enabled), 5, 0)), true);
         edtGeneroNome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGeneroNome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGeneroNome_Enabled), 5, 0)), true);
         edtUsuarioSerieNota_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioSerieNota_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioSerieNota_Enabled), 5, 0)), true);
         chkUsuarioSerieAssistida.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioSerieAssistida_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkUsuarioSerieAssistida.Enabled), 5, 0)), true);
         edtUsuarioSerieComentario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioSerieComentario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioSerieComentario_Enabled), 5, 0)), true);
         chkUsuarioSerieFavorita.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioSerieFavorita_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkUsuarioSerieFavorita.Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes044( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues040( )
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
         context.AddJavascriptSource("gxcfg.js", "?20189251961694", false);
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
         bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("usuarioserie.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z13UsuarioSerieId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13UsuarioSerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z14UsuarioSerieNota", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14UsuarioSerieNota), 1, 0, ",", "")));
         GxWebStd.gx_boolean_hidden_field( context, "Z15UsuarioSerieAssistida", Z15UsuarioSerieAssistida);
         GxWebStd.gx_hidden_field( context, "Z16UsuarioSerieComentario", Z16UsuarioSerieComentario);
         GxWebStd.gx_boolean_hidden_field( context, "Z17UsuarioSerieFavorita", Z17UsuarioSerieFavorita);
         GxWebStd.gx_hidden_field( context, "Z11UsuarioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11UsuarioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z1SerieId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1SerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "GENEROID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A48GeneroId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "SERIEIMAGEM_GXI", A40000SerieImagem_GXI);
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GXCCtlgxBlob = "SERIEIMAGEM" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A43SerieImagem);
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
         return formatLink("usuarioserie.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "UsuarioSerie" ;
      }

      public override String GetPgmdesc( )
      {
         return "Usuário série" ;
      }

      protected void InitializeNonKey044( )
      {
         A48GeneroId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
         A11UsuarioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
         A1SerieId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
         A2SerieNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SerieNome", A2SerieNome);
         A43SerieImagem = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43SerieImagem", A43SerieImagem);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
         A40000SerieImagem_GXI = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
         A49GeneroNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49GeneroNome", A49GeneroNome);
         A14UsuarioSerieNota = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14UsuarioSerieNota", StringUtil.Str( (decimal)(A14UsuarioSerieNota), 1, 0));
         A15UsuarioSerieAssistida = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15UsuarioSerieAssistida", A15UsuarioSerieAssistida);
         A16UsuarioSerieComentario = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16UsuarioSerieComentario", A16UsuarioSerieComentario);
         A17UsuarioSerieFavorita = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17UsuarioSerieFavorita", A17UsuarioSerieFavorita);
         Z14UsuarioSerieNota = 0;
         Z15UsuarioSerieAssistida = false;
         Z16UsuarioSerieComentario = "";
         Z17UsuarioSerieFavorita = false;
         Z11UsuarioId = 0;
         Z1SerieId = 0;
      }

      protected void InitAll044( )
      {
         A13UsuarioSerieId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A13UsuarioSerieId), 18, 0)));
         InitializeNonKey044( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2018925196172", true);
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
         context.AddJavascriptSource("usuarioserie.js", "?2018925196172", false);
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
         edtUsuarioSerieId_Internalname = "USUARIOSERIEID";
         edtUsuarioId_Internalname = "USUARIOID";
         edtSerieId_Internalname = "SERIEID";
         edtSerieNome_Internalname = "SERIENOME";
         imgSerieImagem_Internalname = "SERIEIMAGEM";
         edtGeneroNome_Internalname = "GENERONOME";
         edtUsuarioSerieNota_Internalname = "USUARIOSERIENOTA";
         chkUsuarioSerieAssistida_Internalname = "USUARIOSERIEASSISTIDA";
         edtUsuarioSerieComentario_Internalname = "USUARIOSERIECOMENTARIO";
         chkUsuarioSerieFavorita_Internalname = "USUARIOSERIEFAVORITA";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         Form.Internalname = "FORM";
         imgprompt_11_Internalname = "PROMPT_11";
         imgprompt_1_Internalname = "PROMPT_1";
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
         Form.Caption = "Usuário série";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         chkUsuarioSerieFavorita.Enabled = 1;
         edtUsuarioSerieComentario_Enabled = 1;
         chkUsuarioSerieAssistida.Enabled = 1;
         edtUsuarioSerieNota_Jsonclick = "";
         edtUsuarioSerieNota_Enabled = 1;
         edtGeneroNome_Jsonclick = "";
         edtGeneroNome_Enabled = 0;
         imgSerieImagem_Enabled = 0;
         edtSerieNome_Jsonclick = "";
         edtSerieNome_Enabled = 0;
         imgprompt_1_Visible = 1;
         imgprompt_1_Link = "";
         edtSerieId_Jsonclick = "";
         edtSerieId_Enabled = 1;
         imgprompt_11_Visible = 1;
         imgprompt_11_Link = "";
         edtUsuarioId_Jsonclick = "";
         edtUsuarioId_Enabled = 1;
         edtUsuarioSerieId_Jsonclick = "";
         edtUsuarioSerieId_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         chkUsuarioSerieFavorita.Caption = "favorita";
         chkUsuarioSerieAssistida.Caption = "Assistida";
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

      public void Valid_Usuarioserieid( long GX_Parm1 ,
                                        short GX_Parm2 ,
                                        bool GX_Parm3 ,
                                        String GX_Parm4 ,
                                        bool GX_Parm5 ,
                                        long GX_Parm6 ,
                                        long GX_Parm7 )
      {
         A13UsuarioSerieId = GX_Parm1;
         A14UsuarioSerieNota = GX_Parm2;
         A15UsuarioSerieAssistida = GX_Parm3;
         A16UsuarioSerieComentario = GX_Parm4;
         A17UsuarioSerieFavorita = GX_Parm5;
         A11UsuarioId = GX_Parm6;
         A1SerieId = GX_Parm7;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A48GeneroId = 0;
            A2SerieNome = "";
            A43SerieImagem = "";
            A40000SerieImagem_GXI = "";
            A49GeneroNome = "";
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A14UsuarioSerieNota), 1, 0, ".", "")));
         isValidOutput.Add(A15UsuarioSerieAssistida);
         isValidOutput.Add(A16UsuarioSerieComentario);
         isValidOutput.Add(A17UsuarioSerieFavorita);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A48GeneroId), 18, 0, ".", "")));
         isValidOutput.Add(A2SerieNome);
         isValidOutput.Add(context.PathToRelativeUrl( A43SerieImagem));
         isValidOutput.Add(A43SerieImagem);
         isValidOutput.Add(A40000SerieImagem_GXI);
         isValidOutput.Add(A49GeneroNome);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13UsuarioSerieId), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11UsuarioId), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1SerieId), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14UsuarioSerieNota), 1, 0, ",", "")));
         isValidOutput.Add(Z15UsuarioSerieAssistida);
         isValidOutput.Add(Z16UsuarioSerieComentario);
         isValidOutput.Add(Z17UsuarioSerieFavorita);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48GeneroId), 18, 0, ".", "")));
         isValidOutput.Add(Z2SerieNome);
         isValidOutput.Add(context.PathToRelativeUrl( Z43SerieImagem));
         isValidOutput.Add(Z40000SerieImagem_GXI);
         isValidOutput.Add(Z49GeneroNome);
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
         /* Using cursor T000420 */
         pr_default.execute(18, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioId_Internalname;
         }
         pr_default.close(18);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Serieid( long GX_Parm1 ,
                                 long GX_Parm2 ,
                                 String GX_Parm3 ,
                                 String GX_Parm4 ,
                                 String GX_Parm5 ,
                                 String GX_Parm6 )
      {
         A1SerieId = GX_Parm1;
         A48GeneroId = GX_Parm2;
         A2SerieNome = GX_Parm3;
         A43SerieImagem = GX_Parm4;
         A40000SerieImagem_GXI = GX_Parm5;
         A49GeneroNome = GX_Parm6;
         /* Using cursor T000417 */
         pr_default.execute(15, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("Não existe 'Série'.", "ForeignKeyNotFound", 1, "SERIEID");
            AnyError = 1;
            GX_FocusControl = edtSerieId_Internalname;
         }
         A48GeneroId = T000417_A48GeneroId[0];
         A2SerieNome = T000417_A2SerieNome[0];
         A40000SerieImagem_GXI = T000417_A40000SerieImagem_GXI[0];
         A43SerieImagem = T000417_A43SerieImagem[0];
         pr_default.close(15);
         /* Using cursor T000418 */
         pr_default.execute(16, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("Não existe 'Gênero'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A49GeneroNome = T000418_A49GeneroNome[0];
         pr_default.close(16);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A48GeneroId = 0;
            A2SerieNome = "";
            A43SerieImagem = "";
            A40000SerieImagem_GXI = "";
            A49GeneroNome = "";
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A48GeneroId), 18, 0, ".", "")));
         isValidOutput.Add(A2SerieNome);
         isValidOutput.Add(context.PathToRelativeUrl( A43SerieImagem));
         isValidOutput.Add(A43SerieImagem);
         isValidOutput.Add(A40000SerieImagem_GXI);
         isValidOutput.Add(A49GeneroNome);
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
         pr_default.close(18);
         pr_default.close(15);
         pr_default.close(16);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z16UsuarioSerieComentario = "";
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
         A2SerieNome = "";
         A43SerieImagem = "";
         A40000SerieImagem_GXI = "";
         A49GeneroNome = "";
         A16UsuarioSerieComentario = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z2SerieNome = "";
         Z43SerieImagem = "";
         Z40000SerieImagem_GXI = "";
         Z49GeneroNome = "";
         T00047_A48GeneroId = new long[1] ;
         T00047_A13UsuarioSerieId = new long[1] ;
         T00047_A2SerieNome = new String[] {""} ;
         T00047_A40000SerieImagem_GXI = new String[] {""} ;
         T00047_A49GeneroNome = new String[] {""} ;
         T00047_A14UsuarioSerieNota = new short[1] ;
         T00047_A15UsuarioSerieAssistida = new bool[] {false} ;
         T00047_A16UsuarioSerieComentario = new String[] {""} ;
         T00047_A17UsuarioSerieFavorita = new bool[] {false} ;
         T00047_A11UsuarioId = new long[1] ;
         T00047_A1SerieId = new long[1] ;
         T00047_A43SerieImagem = new String[] {""} ;
         T00044_A11UsuarioId = new long[1] ;
         T00045_A48GeneroId = new long[1] ;
         T00045_A2SerieNome = new String[] {""} ;
         T00045_A40000SerieImagem_GXI = new String[] {""} ;
         T00045_A43SerieImagem = new String[] {""} ;
         T00046_A49GeneroNome = new String[] {""} ;
         T00048_A11UsuarioId = new long[1] ;
         T00049_A48GeneroId = new long[1] ;
         T00049_A2SerieNome = new String[] {""} ;
         T00049_A40000SerieImagem_GXI = new String[] {""} ;
         T00049_A43SerieImagem = new String[] {""} ;
         T000410_A49GeneroNome = new String[] {""} ;
         T000411_A13UsuarioSerieId = new long[1] ;
         T00043_A13UsuarioSerieId = new long[1] ;
         T00043_A14UsuarioSerieNota = new short[1] ;
         T00043_A15UsuarioSerieAssistida = new bool[] {false} ;
         T00043_A16UsuarioSerieComentario = new String[] {""} ;
         T00043_A17UsuarioSerieFavorita = new bool[] {false} ;
         T00043_A11UsuarioId = new long[1] ;
         T00043_A1SerieId = new long[1] ;
         sMode4 = "";
         T000412_A13UsuarioSerieId = new long[1] ;
         T000413_A13UsuarioSerieId = new long[1] ;
         T00042_A13UsuarioSerieId = new long[1] ;
         T00042_A14UsuarioSerieNota = new short[1] ;
         T00042_A15UsuarioSerieAssistida = new bool[] {false} ;
         T00042_A16UsuarioSerieComentario = new String[] {""} ;
         T00042_A17UsuarioSerieFavorita = new bool[] {false} ;
         T00042_A11UsuarioId = new long[1] ;
         T00042_A1SerieId = new long[1] ;
         T000414_A13UsuarioSerieId = new long[1] ;
         T000417_A48GeneroId = new long[1] ;
         T000417_A2SerieNome = new String[] {""} ;
         T000417_A40000SerieImagem_GXI = new String[] {""} ;
         T000417_A43SerieImagem = new String[] {""} ;
         T000418_A49GeneroNome = new String[] {""} ;
         T000419_A13UsuarioSerieId = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000420_A11UsuarioId = new long[1] ;
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.usuarioserie__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuarioserie__default(),
            new Object[][] {
                new Object[] {
               T00042_A13UsuarioSerieId, T00042_A14UsuarioSerieNota, T00042_A15UsuarioSerieAssistida, T00042_A16UsuarioSerieComentario, T00042_A17UsuarioSerieFavorita, T00042_A11UsuarioId, T00042_A1SerieId
               }
               , new Object[] {
               T00043_A13UsuarioSerieId, T00043_A14UsuarioSerieNota, T00043_A15UsuarioSerieAssistida, T00043_A16UsuarioSerieComentario, T00043_A17UsuarioSerieFavorita, T00043_A11UsuarioId, T00043_A1SerieId
               }
               , new Object[] {
               T00044_A11UsuarioId
               }
               , new Object[] {
               T00045_A48GeneroId, T00045_A2SerieNome, T00045_A40000SerieImagem_GXI, T00045_A43SerieImagem
               }
               , new Object[] {
               T00046_A49GeneroNome
               }
               , new Object[] {
               T00047_A48GeneroId, T00047_A13UsuarioSerieId, T00047_A2SerieNome, T00047_A40000SerieImagem_GXI, T00047_A49GeneroNome, T00047_A14UsuarioSerieNota, T00047_A15UsuarioSerieAssistida, T00047_A16UsuarioSerieComentario, T00047_A17UsuarioSerieFavorita, T00047_A11UsuarioId,
               T00047_A1SerieId, T00047_A43SerieImagem
               }
               , new Object[] {
               T00048_A11UsuarioId
               }
               , new Object[] {
               T00049_A48GeneroId, T00049_A2SerieNome, T00049_A40000SerieImagem_GXI, T00049_A43SerieImagem
               }
               , new Object[] {
               T000410_A49GeneroNome
               }
               , new Object[] {
               T000411_A13UsuarioSerieId
               }
               , new Object[] {
               T000412_A13UsuarioSerieId
               }
               , new Object[] {
               T000413_A13UsuarioSerieId
               }
               , new Object[] {
               T000414_A13UsuarioSerieId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000417_A48GeneroId, T000417_A2SerieNome, T000417_A40000SerieImagem_GXI, T000417_A43SerieImagem
               }
               , new Object[] {
               T000418_A49GeneroNome
               }
               , new Object[] {
               T000419_A13UsuarioSerieId
               }
               , new Object[] {
               T000420_A11UsuarioId
               }
            }
         );
      }

      private short Z14UsuarioSerieNota ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A14UsuarioSerieNota ;
      private short GX_JID ;
      private short RcdFound4 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUsuarioSerieId_Enabled ;
      private int edtUsuarioId_Enabled ;
      private int imgprompt_11_Visible ;
      private int edtSerieId_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtSerieNome_Enabled ;
      private int imgSerieImagem_Enabled ;
      private int edtGeneroNome_Enabled ;
      private int edtUsuarioSerieNota_Enabled ;
      private int edtUsuarioSerieComentario_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z13UsuarioSerieId ;
      private long Z11UsuarioId ;
      private long Z1SerieId ;
      private long A11UsuarioId ;
      private long A1SerieId ;
      private long A48GeneroId ;
      private long A13UsuarioSerieId ;
      private long Z48GeneroId ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String chkUsuarioSerieAssistida_Internalname ;
      private String chkUsuarioSerieFavorita_Internalname ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUsuarioSerieId_Internalname ;
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
      private String edtUsuarioSerieId_Jsonclick ;
      private String edtUsuarioId_Internalname ;
      private String edtUsuarioId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_11_Internalname ;
      private String imgprompt_11_Link ;
      private String edtSerieId_Internalname ;
      private String edtSerieId_Jsonclick ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtSerieNome_Internalname ;
      private String edtSerieNome_Jsonclick ;
      private String imgSerieImagem_Internalname ;
      private String edtGeneroNome_Internalname ;
      private String edtGeneroNome_Jsonclick ;
      private String edtUsuarioSerieNota_Internalname ;
      private String edtUsuarioSerieNota_Jsonclick ;
      private String edtUsuarioSerieComentario_Internalname ;
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
      private String sMode4 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXCCtlgxBlob ;
      private bool Z15UsuarioSerieAssistida ;
      private bool Z17UsuarioSerieFavorita ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A43SerieImagem_IsBlob ;
      private bool A15UsuarioSerieAssistida ;
      private bool A17UsuarioSerieFavorita ;
      private bool Gx_longc ;
      private String Z16UsuarioSerieComentario ;
      private String A2SerieNome ;
      private String A40000SerieImagem_GXI ;
      private String A49GeneroNome ;
      private String A16UsuarioSerieComentario ;
      private String Z2SerieNome ;
      private String Z40000SerieImagem_GXI ;
      private String Z49GeneroNome ;
      private String A43SerieImagem ;
      private String Z43SerieImagem ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkUsuarioSerieAssistida ;
      private GXCheckbox chkUsuarioSerieFavorita ;
      private IDataStoreProvider pr_default ;
      private long[] T00047_A48GeneroId ;
      private long[] T00047_A13UsuarioSerieId ;
      private String[] T00047_A2SerieNome ;
      private String[] T00047_A40000SerieImagem_GXI ;
      private String[] T00047_A49GeneroNome ;
      private short[] T00047_A14UsuarioSerieNota ;
      private bool[] T00047_A15UsuarioSerieAssistida ;
      private String[] T00047_A16UsuarioSerieComentario ;
      private bool[] T00047_A17UsuarioSerieFavorita ;
      private long[] T00047_A11UsuarioId ;
      private long[] T00047_A1SerieId ;
      private String[] T00047_A43SerieImagem ;
      private long[] T00044_A11UsuarioId ;
      private long[] T00045_A48GeneroId ;
      private String[] T00045_A2SerieNome ;
      private String[] T00045_A40000SerieImagem_GXI ;
      private String[] T00045_A43SerieImagem ;
      private String[] T00046_A49GeneroNome ;
      private long[] T00048_A11UsuarioId ;
      private long[] T00049_A48GeneroId ;
      private String[] T00049_A2SerieNome ;
      private String[] T00049_A40000SerieImagem_GXI ;
      private String[] T00049_A43SerieImagem ;
      private String[] T000410_A49GeneroNome ;
      private long[] T000411_A13UsuarioSerieId ;
      private long[] T00043_A13UsuarioSerieId ;
      private short[] T00043_A14UsuarioSerieNota ;
      private bool[] T00043_A15UsuarioSerieAssistida ;
      private String[] T00043_A16UsuarioSerieComentario ;
      private bool[] T00043_A17UsuarioSerieFavorita ;
      private long[] T00043_A11UsuarioId ;
      private long[] T00043_A1SerieId ;
      private long[] T000412_A13UsuarioSerieId ;
      private long[] T000413_A13UsuarioSerieId ;
      private long[] T00042_A13UsuarioSerieId ;
      private short[] T00042_A14UsuarioSerieNota ;
      private bool[] T00042_A15UsuarioSerieAssistida ;
      private String[] T00042_A16UsuarioSerieComentario ;
      private bool[] T00042_A17UsuarioSerieFavorita ;
      private long[] T00042_A11UsuarioId ;
      private long[] T00042_A1SerieId ;
      private long[] T000414_A13UsuarioSerieId ;
      private long[] T000417_A48GeneroId ;
      private String[] T000417_A2SerieNome ;
      private String[] T000417_A40000SerieImagem_GXI ;
      private String[] T000417_A43SerieImagem ;
      private String[] T000418_A49GeneroNome ;
      private IDataStoreProvider pr_gam ;
      private long[] T000419_A13UsuarioSerieId ;
      private long[] T000420_A11UsuarioId ;
      private GXWebForm Form ;
   }

   public class usuarioserie__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class usuarioserie__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
       ,new UpdateCursor(def[13])
       ,new UpdateCursor(def[14])
       ,new ForEachCursor(def[15])
       ,new ForEachCursor(def[16])
       ,new ForEachCursor(def[17])
       ,new ForEachCursor(def[18])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00047 ;
        prmT00047 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00044 ;
        prmT00044 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00045 ;
        prmT00045 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00046 ;
        prmT00046 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00048 ;
        prmT00048 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00049 ;
        prmT00049 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000410 ;
        prmT000410 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000411 ;
        prmT000411 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00043 ;
        prmT00043 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000412 ;
        prmT000412 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000413 ;
        prmT000413 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00042 ;
        prmT00042 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000414 ;
        prmT000414 = new Object[] {
        new Object[] {"@UsuarioSerieNota",SqlDbType.SmallInt,1,0} ,
        new Object[] {"@UsuarioSerieAssistida",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioSerieComentario",SqlDbType.VarChar,300,0} ,
        new Object[] {"@UsuarioSerieFavorita",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000415 ;
        prmT000415 = new Object[] {
        new Object[] {"@UsuarioSerieNota",SqlDbType.SmallInt,1,0} ,
        new Object[] {"@UsuarioSerieAssistida",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioSerieComentario",SqlDbType.VarChar,300,0} ,
        new Object[] {"@UsuarioSerieFavorita",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000416 ;
        prmT000416 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000419 ;
        prmT000419 = new Object[] {
        } ;
        Object[] prmT000420 ;
        prmT000420 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000417 ;
        prmT000417 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000418 ;
        prmT000418 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00042", "SELECT [UsuarioSerieId], [UsuarioSerieNota], [UsuarioSerieAssistida], [UsuarioSerieComentario], [UsuarioSerieFavorita], [UsuarioId], [SerieId] FROM [UsuarioSerie] WITH (UPDLOCK) WHERE [UsuarioSerieId] = @UsuarioSerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1,0,true,false )
           ,new CursorDef("T00043", "SELECT [UsuarioSerieId], [UsuarioSerieNota], [UsuarioSerieAssistida], [UsuarioSerieComentario], [UsuarioSerieFavorita], [UsuarioId], [SerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE [UsuarioSerieId] = @UsuarioSerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1,0,true,false )
           ,new CursorDef("T00044", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00044,1,0,true,false )
           ,new CursorDef("T00045", "SELECT [GeneroId], [SerieNome], [SerieImagem_GXI], [SerieImagem] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,1,0,true,false )
           ,new CursorDef("T00046", "SELECT [GeneroNome] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00046,1,0,true,false )
           ,new CursorDef("T00047", "SELECT T2.[GeneroId], TM1.[UsuarioSerieId], T2.[SerieNome], T2.[SerieImagem_GXI], T3.[GeneroNome], TM1.[UsuarioSerieNota], TM1.[UsuarioSerieAssistida], TM1.[UsuarioSerieComentario], TM1.[UsuarioSerieFavorita], TM1.[UsuarioId], TM1.[SerieId], T2.[SerieImagem] FROM (([UsuarioSerie] TM1 WITH (NOLOCK) INNER JOIN [Serie] T2 WITH (NOLOCK) ON T2.[SerieId] = TM1.[SerieId]) INNER JOIN [Genero] T3 WITH (NOLOCK) ON T3.[GeneroId] = T2.[GeneroId]) WHERE TM1.[UsuarioSerieId] = @UsuarioSerieId ORDER BY TM1.[UsuarioSerieId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,100,0,true,false )
           ,new CursorDef("T00048", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00048,1,0,true,false )
           ,new CursorDef("T00049", "SELECT [GeneroId], [SerieNome], [SerieImagem_GXI], [SerieImagem] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00049,1,0,true,false )
           ,new CursorDef("T000410", "SELECT [GeneroNome] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000410,1,0,true,false )
           ,new CursorDef("T000411", "SELECT [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE [UsuarioSerieId] = @UsuarioSerieId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000411,1,0,true,false )
           ,new CursorDef("T000412", "SELECT TOP 1 [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE ( [UsuarioSerieId] > @UsuarioSerieId) ORDER BY [UsuarioSerieId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000412,1,0,true,true )
           ,new CursorDef("T000413", "SELECT TOP 1 [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE ( [UsuarioSerieId] < @UsuarioSerieId) ORDER BY [UsuarioSerieId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000413,1,0,true,true )
           ,new CursorDef("T000414", "INSERT INTO [UsuarioSerie]([UsuarioSerieNota], [UsuarioSerieAssistida], [UsuarioSerieComentario], [UsuarioSerieFavorita], [UsuarioId], [SerieId]) VALUES(@UsuarioSerieNota, @UsuarioSerieAssistida, @UsuarioSerieComentario, @UsuarioSerieFavorita, @UsuarioId, @SerieId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000414)
           ,new CursorDef("T000415", "UPDATE [UsuarioSerie] SET [UsuarioSerieNota]=@UsuarioSerieNota, [UsuarioSerieAssistida]=@UsuarioSerieAssistida, [UsuarioSerieComentario]=@UsuarioSerieComentario, [UsuarioSerieFavorita]=@UsuarioSerieFavorita, [UsuarioId]=@UsuarioId, [SerieId]=@SerieId  WHERE [UsuarioSerieId] = @UsuarioSerieId", GxErrorMask.GX_NOMASK,prmT000415)
           ,new CursorDef("T000416", "DELETE FROM [UsuarioSerie]  WHERE [UsuarioSerieId] = @UsuarioSerieId", GxErrorMask.GX_NOMASK,prmT000416)
           ,new CursorDef("T000417", "SELECT [GeneroId], [SerieNome], [SerieImagem_GXI], [SerieImagem] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000417,1,0,true,false )
           ,new CursorDef("T000418", "SELECT [GeneroNome] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000418,1,0,true,false )
           ,new CursorDef("T000419", "SELECT [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) ORDER BY [UsuarioSerieId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000419,100,0,true,false )
           ,new CursorDef("T000420", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000420,1,0,true,false )
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
              ((bool[]) buf[2])[0] = rslt.getBool(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[4])[0] = rslt.getBool(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              ((long[]) buf[6])[0] = rslt.getLong(7) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((bool[]) buf[2])[0] = rslt.getBool(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[4])[0] = rslt.getBool(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              ((long[]) buf[6])[0] = rslt.getLong(7) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
              ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((short[]) buf[5])[0] = rslt.getShort(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[8])[0] = rslt.getBool(9) ;
              ((long[]) buf[9])[0] = rslt.getLong(10) ;
              ((long[]) buf[10])[0] = rslt.getLong(11) ;
              ((String[]) buf[11])[0] = rslt.getMultimediaFile(12, rslt.getVarchar(4)) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
              ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
              return;
           case 8 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 9 :
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
           case 15 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
              ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
              return;
           case 16 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 17 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 18 :
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 11 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 12 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (bool)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (bool)parms[3]);
              stmt.SetParameter(5, (long)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              return;
           case 13 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (bool)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (bool)parms[3]);
              stmt.SetParameter(5, (long)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              stmt.SetParameter(7, (long)parms[6]);
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
           case 18 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
