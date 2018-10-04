/*
               File: UsuarioEpisodio
        Description: Usuário episódio
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:39:18.4
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
   public class usuarioepisodio : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A7EpisodioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A7EpisodioId) ;
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
         chkUsuarioEpisodioAssistido.Name = "USUARIOEPISODIOASSISTIDO";
         chkUsuarioEpisodioAssistido.WebTags = "";
         chkUsuarioEpisodioAssistido.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioEpisodioAssistido_Internalname, "TitleCaption", chkUsuarioEpisodioAssistido.Caption, true);
         chkUsuarioEpisodioAssistido.CheckedValue = "false";
         chkUsuarioEpisodioFavorito.Name = "USUARIOEPISODIOFAVORITO";
         chkUsuarioEpisodioFavorito.WebTags = "";
         chkUsuarioEpisodioFavorito.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioEpisodioFavorito_Internalname, "TitleCaption", chkUsuarioEpisodioFavorito.Caption, true);
         chkUsuarioEpisodioFavorito.CheckedValue = "false";
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
            Form.Meta.addItem("description", "Usuário episódio", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUsuarioEpisodioId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public usuarioepisodio( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public usuarioepisodio( IGxContext context )
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
         chkUsuarioEpisodioAssistido = new GXCheckbox();
         chkUsuarioEpisodioFavorito = new GXCheckbox();
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Usuário episódio", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_UsuarioEpisodio.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Selecionar", bttBtn_select_Jsonclick, 4, "Selecionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIOEPISODIOID"+"'), id:'"+"USUARIOEPISODIOID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_UsuarioEpisodio.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioEpisodioId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioEpisodioId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioEpisodioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A18UsuarioEpisodioId), 18, 0, ",", "")), ((edtUsuarioEpisodioId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A18UsuarioEpisodioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A18UsuarioEpisodioId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioEpisodioId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioEpisodioId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioEpisodio.htm");
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
            GxWebStd.gx_single_line_edit( context, edtUsuarioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ",", "")), ((edtUsuarioId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A11UsuarioId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioEpisodio.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_11_Internalname, sImgUrl, imgprompt_11_Link, "", "", context.GetTheme( ), imgprompt_11_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEpisodioId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEpisodioId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEpisodioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EpisodioId), 18, 0, ",", "")), ((edtEpisodioId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEpisodioId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEpisodioId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioEpisodio.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_7_Internalname, sImgUrl, imgprompt_7_Link, "", "", context.GetTheme( ), imgprompt_7_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioEpisodioNota_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioEpisodioNota_Internalname, "Nota", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioEpisodioNota_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19UsuarioEpisodioNota), 1, 0, ",", "")), ((edtUsuarioEpisodioNota_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19UsuarioEpisodioNota), "9")) : context.localUtil.Format( (decimal)(A19UsuarioEpisodioNota), "9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioEpisodioNota_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioEpisodioNota_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "Nota", "right", false, "HLP_UsuarioEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkUsuarioEpisodioAssistido_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkUsuarioEpisodioAssistido_Internalname, "Assistido", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkUsuarioEpisodioAssistido_Internalname, StringUtil.BoolToStr( A20UsuarioEpisodioAssistido), "", "Assistido", 1, chkUsuarioEpisodioAssistido.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(48, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,48);\"");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioEpisodioComentario_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioEpisodioComentario_Internalname, "Comentário", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtUsuarioEpisodioComentario_Internalname, A21UsuarioEpisodioComentario, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,53);\"", 0, 1, edtUsuarioEpisodioComentario_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "Comentario", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_UsuarioEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkUsuarioEpisodioFavorito_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkUsuarioEpisodioFavorito_Internalname, "Favorito", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkUsuarioEpisodioFavorito_Internalname, StringUtil.BoolToStr( A22UsuarioEpisodioFavorito), "", "Favorito", 1, chkUsuarioEpisodioFavorito.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(58, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,58);\"");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioEpisodio.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioEpisodioId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioEpisodioId_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIOEPISODIOID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioEpisodioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A18UsuarioEpisodioId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18UsuarioEpisodioId), 18, 0)));
               }
               else
               {
                  A18UsuarioEpisodioId = (long)(context.localUtil.CToN( cgiGet( edtUsuarioEpisodioId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18UsuarioEpisodioId), 18, 0)));
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtEpisodioId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEpisodioId_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EPISODIOID");
                  AnyError = 1;
                  GX_FocusControl = edtEpisodioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A7EpisodioId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
               }
               else
               {
                  A7EpisodioId = (long)(context.localUtil.CToN( cgiGet( edtEpisodioId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioEpisodioNota_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioEpisodioNota_Internalname), ",", ".") > Convert.ToDecimal( 9 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIOEPISODIONOTA");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioEpisodioNota_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A19UsuarioEpisodioNota = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19UsuarioEpisodioNota", StringUtil.Str( (decimal)(A19UsuarioEpisodioNota), 1, 0));
               }
               else
               {
                  A19UsuarioEpisodioNota = (short)(context.localUtil.CToN( cgiGet( edtUsuarioEpisodioNota_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19UsuarioEpisodioNota", StringUtil.Str( (decimal)(A19UsuarioEpisodioNota), 1, 0));
               }
               A20UsuarioEpisodioAssistido = StringUtil.StrToBool( cgiGet( chkUsuarioEpisodioAssistido_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20UsuarioEpisodioAssistido", A20UsuarioEpisodioAssistido);
               A21UsuarioEpisodioComentario = cgiGet( edtUsuarioEpisodioComentario_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21UsuarioEpisodioComentario", A21UsuarioEpisodioComentario);
               A22UsuarioEpisodioFavorito = StringUtil.StrToBool( cgiGet( chkUsuarioEpisodioFavorito_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22UsuarioEpisodioFavorito", A22UsuarioEpisodioFavorito);
               /* Read saved values. */
               Z18UsuarioEpisodioId = (long)(context.localUtil.CToN( cgiGet( "Z18UsuarioEpisodioId"), ",", "."));
               Z19UsuarioEpisodioNota = (short)(context.localUtil.CToN( cgiGet( "Z19UsuarioEpisodioNota"), ",", "."));
               Z20UsuarioEpisodioAssistido = StringUtil.StrToBool( cgiGet( "Z20UsuarioEpisodioAssistido"));
               Z21UsuarioEpisodioComentario = cgiGet( "Z21UsuarioEpisodioComentario");
               Z22UsuarioEpisodioFavorito = StringUtil.StrToBool( cgiGet( "Z22UsuarioEpisodioFavorito"));
               Z11UsuarioId = (long)(context.localUtil.CToN( cgiGet( "Z11UsuarioId"), ",", "."));
               Z7EpisodioId = (long)(context.localUtil.CToN( cgiGet( "Z7EpisodioId"), ",", "."));
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
                  A18UsuarioEpisodioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18UsuarioEpisodioId), 18, 0)));
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
               InitAll055( ) ;
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
         DisableAttributes055( ) ;
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

      protected void ResetCaption050( )
      {
      }

      protected void ZM055( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z19UsuarioEpisodioNota = T00053_A19UsuarioEpisodioNota[0];
               Z20UsuarioEpisodioAssistido = T00053_A20UsuarioEpisodioAssistido[0];
               Z21UsuarioEpisodioComentario = T00053_A21UsuarioEpisodioComentario[0];
               Z22UsuarioEpisodioFavorito = T00053_A22UsuarioEpisodioFavorito[0];
               Z11UsuarioId = T00053_A11UsuarioId[0];
               Z7EpisodioId = T00053_A7EpisodioId[0];
            }
            else
            {
               Z19UsuarioEpisodioNota = A19UsuarioEpisodioNota;
               Z20UsuarioEpisodioAssistido = A20UsuarioEpisodioAssistido;
               Z21UsuarioEpisodioComentario = A21UsuarioEpisodioComentario;
               Z22UsuarioEpisodioFavorito = A22UsuarioEpisodioFavorito;
               Z11UsuarioId = A11UsuarioId;
               Z7EpisodioId = A7EpisodioId;
            }
         }
         if ( GX_JID == -1 )
         {
            Z18UsuarioEpisodioId = A18UsuarioEpisodioId;
            Z19UsuarioEpisodioNota = A19UsuarioEpisodioNota;
            Z20UsuarioEpisodioAssistido = A20UsuarioEpisodioAssistido;
            Z21UsuarioEpisodioComentario = A21UsuarioEpisodioComentario;
            Z22UsuarioEpisodioFavorito = A22UsuarioEpisodioFavorito;
            Z11UsuarioId = A11UsuarioId;
            Z7EpisodioId = A7EpisodioId;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_11_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIOID"+"'), id:'"+"USUARIOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_7_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EPISODIOID"+"'), id:'"+"EPISODIOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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

      protected void Load055( )
      {
         /* Using cursor T00056 */
         pr_default.execute(4, new Object[] {A18UsuarioEpisodioId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound5 = 1;
            A19UsuarioEpisodioNota = T00056_A19UsuarioEpisodioNota[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19UsuarioEpisodioNota", StringUtil.Str( (decimal)(A19UsuarioEpisodioNota), 1, 0));
            A20UsuarioEpisodioAssistido = T00056_A20UsuarioEpisodioAssistido[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20UsuarioEpisodioAssistido", A20UsuarioEpisodioAssistido);
            A21UsuarioEpisodioComentario = T00056_A21UsuarioEpisodioComentario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21UsuarioEpisodioComentario", A21UsuarioEpisodioComentario);
            A22UsuarioEpisodioFavorito = T00056_A22UsuarioEpisodioFavorito[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22UsuarioEpisodioFavorito", A22UsuarioEpisodioFavorito);
            A11UsuarioId = T00056_A11UsuarioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            A7EpisodioId = T00056_A7EpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
            ZM055( -1) ;
         }
         pr_default.close(4);
         OnLoadActions055( ) ;
      }

      protected void OnLoadActions055( )
      {
      }

      protected void CheckExtendedTable055( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00054 */
         pr_default.execute(2, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         /* Using cursor T00055 */
         pr_default.execute(3, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("Não existe 'Episódio'.", "ForeignKeyNotFound", 1, "EPISODIOID");
            AnyError = 1;
            GX_FocusControl = edtEpisodioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors055( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( long A11UsuarioId )
      {
         /* Using cursor T00057 */
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

      protected void gxLoad_3( long A7EpisodioId )
      {
         /* Using cursor T00058 */
         pr_default.execute(6, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("Não existe 'Episódio'.", "ForeignKeyNotFound", 1, "EPISODIOID");
            AnyError = 1;
            GX_FocusControl = edtEpisodioId_Internalname;
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

      protected void GetKey055( )
      {
         /* Using cursor T00059 */
         pr_default.execute(7, new Object[] {A18UsuarioEpisodioId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00053 */
         pr_default.execute(1, new Object[] {A18UsuarioEpisodioId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM055( 1) ;
            RcdFound5 = 1;
            A18UsuarioEpisodioId = T00053_A18UsuarioEpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18UsuarioEpisodioId), 18, 0)));
            A19UsuarioEpisodioNota = T00053_A19UsuarioEpisodioNota[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19UsuarioEpisodioNota", StringUtil.Str( (decimal)(A19UsuarioEpisodioNota), 1, 0));
            A20UsuarioEpisodioAssistido = T00053_A20UsuarioEpisodioAssistido[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20UsuarioEpisodioAssistido", A20UsuarioEpisodioAssistido);
            A21UsuarioEpisodioComentario = T00053_A21UsuarioEpisodioComentario[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21UsuarioEpisodioComentario", A21UsuarioEpisodioComentario);
            A22UsuarioEpisodioFavorito = T00053_A22UsuarioEpisodioFavorito[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22UsuarioEpisodioFavorito", A22UsuarioEpisodioFavorito);
            A11UsuarioId = T00053_A11UsuarioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
            A7EpisodioId = T00053_A7EpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
            Z18UsuarioEpisodioId = A18UsuarioEpisodioId;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load055( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey055( ) ;
            }
            Gx_mode = sMode5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey055( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey055( ) ;
         if ( RcdFound5 == 0 )
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
         RcdFound5 = 0;
         /* Using cursor T000510 */
         pr_default.execute(8, new Object[] {A18UsuarioEpisodioId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000510_A18UsuarioEpisodioId[0] < A18UsuarioEpisodioId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000510_A18UsuarioEpisodioId[0] > A18UsuarioEpisodioId ) ) )
            {
               A18UsuarioEpisodioId = T000510_A18UsuarioEpisodioId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18UsuarioEpisodioId), 18, 0)));
               RcdFound5 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0;
         /* Using cursor T000511 */
         pr_default.execute(9, new Object[] {A18UsuarioEpisodioId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000511_A18UsuarioEpisodioId[0] > A18UsuarioEpisodioId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000511_A18UsuarioEpisodioId[0] < A18UsuarioEpisodioId ) ) )
            {
               A18UsuarioEpisodioId = T000511_A18UsuarioEpisodioId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18UsuarioEpisodioId), 18, 0)));
               RcdFound5 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey055( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUsuarioEpisodioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert055( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound5 == 1 )
            {
               if ( A18UsuarioEpisodioId != Z18UsuarioEpisodioId )
               {
                  A18UsuarioEpisodioId = Z18UsuarioEpisodioId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18UsuarioEpisodioId), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "USUARIOEPISODIOID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioEpisodioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtUsuarioEpisodioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update055( ) ;
                  GX_FocusControl = edtUsuarioEpisodioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A18UsuarioEpisodioId != Z18UsuarioEpisodioId )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtUsuarioEpisodioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert055( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "USUARIOEPISODIOID");
                     AnyError = 1;
                     GX_FocusControl = edtUsuarioEpisodioId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtUsuarioEpisodioId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert055( ) ;
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
         if ( A18UsuarioEpisodioId != Z18UsuarioEpisodioId )
         {
            A18UsuarioEpisodioId = Z18UsuarioEpisodioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18UsuarioEpisodioId), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "USUARIOEPISODIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioEpisodioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUsuarioEpisodioId_Internalname;
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
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "USUARIOEPISODIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioEpisodioId_Internalname;
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
         ScanStart055( ) ;
         if ( RcdFound5 == 0 )
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
         ScanEnd055( ) ;
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
         if ( RcdFound5 == 0 )
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
         if ( RcdFound5 == 0 )
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
         ScanStart055( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound5 != 0 )
            {
               ScanNext055( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd055( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency055( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00052 */
            pr_default.execute(0, new Object[] {A18UsuarioEpisodioId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioEpisodio"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z19UsuarioEpisodioNota != T00052_A19UsuarioEpisodioNota[0] ) || ( Z20UsuarioEpisodioAssistido != T00052_A20UsuarioEpisodioAssistido[0] ) || ( StringUtil.StrCmp(Z21UsuarioEpisodioComentario, T00052_A21UsuarioEpisodioComentario[0]) != 0 ) || ( Z22UsuarioEpisodioFavorito != T00052_A22UsuarioEpisodioFavorito[0] ) || ( Z11UsuarioId != T00052_A11UsuarioId[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z7EpisodioId != T00052_A7EpisodioId[0] ) )
            {
               if ( Z19UsuarioEpisodioNota != T00052_A19UsuarioEpisodioNota[0] )
               {
                  GXUtil.WriteLog("usuarioepisodio:[seudo value changed for attri]"+"UsuarioEpisodioNota");
                  GXUtil.WriteLogRaw("Old: ",Z19UsuarioEpisodioNota);
                  GXUtil.WriteLogRaw("Current: ",T00052_A19UsuarioEpisodioNota[0]);
               }
               if ( Z20UsuarioEpisodioAssistido != T00052_A20UsuarioEpisodioAssistido[0] )
               {
                  GXUtil.WriteLog("usuarioepisodio:[seudo value changed for attri]"+"UsuarioEpisodioAssistido");
                  GXUtil.WriteLogRaw("Old: ",Z20UsuarioEpisodioAssistido);
                  GXUtil.WriteLogRaw("Current: ",T00052_A20UsuarioEpisodioAssistido[0]);
               }
               if ( StringUtil.StrCmp(Z21UsuarioEpisodioComentario, T00052_A21UsuarioEpisodioComentario[0]) != 0 )
               {
                  GXUtil.WriteLog("usuarioepisodio:[seudo value changed for attri]"+"UsuarioEpisodioComentario");
                  GXUtil.WriteLogRaw("Old: ",Z21UsuarioEpisodioComentario);
                  GXUtil.WriteLogRaw("Current: ",T00052_A21UsuarioEpisodioComentario[0]);
               }
               if ( Z22UsuarioEpisodioFavorito != T00052_A22UsuarioEpisodioFavorito[0] )
               {
                  GXUtil.WriteLog("usuarioepisodio:[seudo value changed for attri]"+"UsuarioEpisodioFavorito");
                  GXUtil.WriteLogRaw("Old: ",Z22UsuarioEpisodioFavorito);
                  GXUtil.WriteLogRaw("Current: ",T00052_A22UsuarioEpisodioFavorito[0]);
               }
               if ( Z11UsuarioId != T00052_A11UsuarioId[0] )
               {
                  GXUtil.WriteLog("usuarioepisodio:[seudo value changed for attri]"+"UsuarioId");
                  GXUtil.WriteLogRaw("Old: ",Z11UsuarioId);
                  GXUtil.WriteLogRaw("Current: ",T00052_A11UsuarioId[0]);
               }
               if ( Z7EpisodioId != T00052_A7EpisodioId[0] )
               {
                  GXUtil.WriteLog("usuarioepisodio:[seudo value changed for attri]"+"EpisodioId");
                  GXUtil.WriteLogRaw("Old: ",Z7EpisodioId);
                  GXUtil.WriteLogRaw("Current: ",T00052_A7EpisodioId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"UsuarioEpisodio"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert055( )
      {
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable055( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM055( 0) ;
            CheckOptimisticConcurrency055( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm055( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert055( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000512 */
                     pr_default.execute(10, new Object[] {A19UsuarioEpisodioNota, A20UsuarioEpisodioAssistido, A21UsuarioEpisodioComentario, A22UsuarioEpisodioFavorito, A11UsuarioId, A7EpisodioId});
                     A18UsuarioEpisodioId = T000512_A18UsuarioEpisodioId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18UsuarioEpisodioId), 18, 0)));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioEpisodio") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption050( ) ;
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
               Load055( ) ;
            }
            EndLevel055( ) ;
         }
         CloseExtendedTableCursors055( ) ;
      }

      protected void Update055( )
      {
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable055( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency055( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm055( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate055( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000513 */
                     pr_default.execute(11, new Object[] {A19UsuarioEpisodioNota, A20UsuarioEpisodioAssistido, A21UsuarioEpisodioComentario, A22UsuarioEpisodioFavorito, A11UsuarioId, A7EpisodioId, A18UsuarioEpisodioId});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioEpisodio") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioEpisodio"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate055( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption050( ) ;
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
            EndLevel055( ) ;
         }
         CloseExtendedTableCursors055( ) ;
      }

      protected void DeferredUpdate055( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency055( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls055( ) ;
            AfterConfirm055( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete055( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000514 */
                  pr_default.execute(12, new Object[] {A18UsuarioEpisodioId});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("UsuarioEpisodio") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound5 == 0 )
                        {
                           InitAll055( ) ;
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
                        ResetCaption050( ) ;
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
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel055( ) ;
         Gx_mode = sMode5;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls055( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel055( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete055( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_gam.commit( "UsuarioEpisodio");
            pr_default.commit( "UsuarioEpisodio");
            if ( AnyError == 0 )
            {
               ConfirmValues050( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_gam.rollback( "UsuarioEpisodio");
            pr_default.rollback( "UsuarioEpisodio");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart055( )
      {
         /* Using cursor T000515 */
         pr_default.execute(13);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound5 = 1;
            A18UsuarioEpisodioId = T000515_A18UsuarioEpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18UsuarioEpisodioId), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext055( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound5 = 1;
            A18UsuarioEpisodioId = T000515_A18UsuarioEpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18UsuarioEpisodioId), 18, 0)));
         }
      }

      protected void ScanEnd055( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm055( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert055( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate055( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete055( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete055( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate055( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes055( )
      {
         edtUsuarioEpisodioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioEpisodioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioEpisodioId_Enabled), 5, 0)), true);
         edtUsuarioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioId_Enabled), 5, 0)), true);
         edtEpisodioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEpisodioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEpisodioId_Enabled), 5, 0)), true);
         edtUsuarioEpisodioNota_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioEpisodioNota_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioEpisodioNota_Enabled), 5, 0)), true);
         chkUsuarioEpisodioAssistido.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioEpisodioAssistido_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkUsuarioEpisodioAssistido.Enabled), 5, 0)), true);
         edtUsuarioEpisodioComentario_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioEpisodioComentario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioEpisodioComentario_Enabled), 5, 0)), true);
         chkUsuarioEpisodioFavorito.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkUsuarioEpisodioFavorito_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkUsuarioEpisodioFavorito.Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes055( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues050( )
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
         context.AddJavascriptSource("gxcfg.js", "?201892019391990", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("usuarioepisodio.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18UsuarioEpisodioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z19UsuarioEpisodioNota", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19UsuarioEpisodioNota), 1, 0, ",", "")));
         GxWebStd.gx_boolean_hidden_field( context, "Z20UsuarioEpisodioAssistido", Z20UsuarioEpisodioAssistido);
         GxWebStd.gx_hidden_field( context, "Z21UsuarioEpisodioComentario", Z21UsuarioEpisodioComentario);
         GxWebStd.gx_boolean_hidden_field( context, "Z22UsuarioEpisodioFavorito", Z22UsuarioEpisodioFavorito);
         GxWebStd.gx_hidden_field( context, "Z11UsuarioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11UsuarioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z7EpisodioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7EpisodioId), 18, 0, ",", "")));
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
         return formatLink("usuarioepisodio.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "UsuarioEpisodio" ;
      }

      public override String GetPgmdesc( )
      {
         return "Usuário episódio" ;
      }

      protected void InitializeNonKey055( )
      {
         A11UsuarioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11UsuarioId), 18, 0)));
         A7EpisodioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
         A19UsuarioEpisodioNota = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19UsuarioEpisodioNota", StringUtil.Str( (decimal)(A19UsuarioEpisodioNota), 1, 0));
         A20UsuarioEpisodioAssistido = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20UsuarioEpisodioAssistido", A20UsuarioEpisodioAssistido);
         A21UsuarioEpisodioComentario = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21UsuarioEpisodioComentario", A21UsuarioEpisodioComentario);
         A22UsuarioEpisodioFavorito = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22UsuarioEpisodioFavorito", A22UsuarioEpisodioFavorito);
         Z19UsuarioEpisodioNota = 0;
         Z20UsuarioEpisodioAssistido = false;
         Z21UsuarioEpisodioComentario = "";
         Z22UsuarioEpisodioFavorito = false;
         Z11UsuarioId = 0;
         Z7EpisodioId = 0;
      }

      protected void InitAll055( )
      {
         A18UsuarioEpisodioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18UsuarioEpisodioId), 18, 0)));
         InitializeNonKey055( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019391997", true);
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
         context.AddJavascriptSource("usuarioepisodio.js", "?201892019391997", false);
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
         edtUsuarioEpisodioId_Internalname = "USUARIOEPISODIOID";
         edtUsuarioId_Internalname = "USUARIOID";
         edtEpisodioId_Internalname = "EPISODIOID";
         edtUsuarioEpisodioNota_Internalname = "USUARIOEPISODIONOTA";
         chkUsuarioEpisodioAssistido_Internalname = "USUARIOEPISODIOASSISTIDO";
         edtUsuarioEpisodioComentario_Internalname = "USUARIOEPISODIOCOMENTARIO";
         chkUsuarioEpisodioFavorito_Internalname = "USUARIOEPISODIOFAVORITO";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         Form.Internalname = "FORM";
         imgprompt_11_Internalname = "PROMPT_11";
         imgprompt_7_Internalname = "PROMPT_7";
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
         Form.Caption = "Usuário episódio";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         chkUsuarioEpisodioFavorito.Enabled = 1;
         edtUsuarioEpisodioComentario_Enabled = 1;
         chkUsuarioEpisodioAssistido.Enabled = 1;
         edtUsuarioEpisodioNota_Jsonclick = "";
         edtUsuarioEpisodioNota_Enabled = 1;
         imgprompt_7_Visible = 1;
         imgprompt_7_Link = "";
         edtEpisodioId_Jsonclick = "";
         edtEpisodioId_Enabled = 1;
         imgprompt_11_Visible = 1;
         imgprompt_11_Link = "";
         edtUsuarioId_Jsonclick = "";
         edtUsuarioId_Enabled = 1;
         edtUsuarioEpisodioId_Jsonclick = "";
         edtUsuarioEpisodioId_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         chkUsuarioEpisodioFavorito.Caption = "Favorito";
         chkUsuarioEpisodioAssistido.Caption = "Assistido";
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

      public void Valid_Usuarioepisodioid( long GX_Parm1 ,
                                           short GX_Parm2 ,
                                           bool GX_Parm3 ,
                                           String GX_Parm4 ,
                                           bool GX_Parm5 ,
                                           long GX_Parm6 ,
                                           long GX_Parm7 )
      {
         A18UsuarioEpisodioId = GX_Parm1;
         A19UsuarioEpisodioNota = GX_Parm2;
         A20UsuarioEpisodioAssistido = GX_Parm3;
         A21UsuarioEpisodioComentario = GX_Parm4;
         A22UsuarioEpisodioFavorito = GX_Parm5;
         A11UsuarioId = GX_Parm6;
         A7EpisodioId = GX_Parm7;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A11UsuarioId), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EpisodioId), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A19UsuarioEpisodioNota), 1, 0, ".", "")));
         isValidOutput.Add(A20UsuarioEpisodioAssistido);
         isValidOutput.Add(A21UsuarioEpisodioComentario);
         isValidOutput.Add(A22UsuarioEpisodioFavorito);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18UsuarioEpisodioId), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11UsuarioId), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7EpisodioId), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19UsuarioEpisodioNota), 1, 0, ",", "")));
         isValidOutput.Add(Z20UsuarioEpisodioAssistido);
         isValidOutput.Add(Z21UsuarioEpisodioComentario);
         isValidOutput.Add(Z22UsuarioEpisodioFavorito);
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
         /* Using cursor T000516 */
         pr_default.execute(14, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioId_Internalname;
         }
         pr_default.close(14);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Episodioid( long GX_Parm1 )
      {
         A7EpisodioId = GX_Parm1;
         /* Using cursor T000517 */
         pr_default.execute(15, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("Não existe 'Episódio'.", "ForeignKeyNotFound", 1, "EPISODIOID");
            AnyError = 1;
            GX_FocusControl = edtEpisodioId_Internalname;
         }
         pr_default.close(15);
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
         pr_default.close(14);
         pr_default.close(15);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z21UsuarioEpisodioComentario = "";
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
         A21UsuarioEpisodioComentario = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00056_A18UsuarioEpisodioId = new long[1] ;
         T00056_A19UsuarioEpisodioNota = new short[1] ;
         T00056_A20UsuarioEpisodioAssistido = new bool[] {false} ;
         T00056_A21UsuarioEpisodioComentario = new String[] {""} ;
         T00056_A22UsuarioEpisodioFavorito = new bool[] {false} ;
         T00056_A11UsuarioId = new long[1] ;
         T00056_A7EpisodioId = new long[1] ;
         T00054_A11UsuarioId = new long[1] ;
         T00055_A7EpisodioId = new long[1] ;
         T00057_A11UsuarioId = new long[1] ;
         T00058_A7EpisodioId = new long[1] ;
         T00059_A18UsuarioEpisodioId = new long[1] ;
         T00053_A18UsuarioEpisodioId = new long[1] ;
         T00053_A19UsuarioEpisodioNota = new short[1] ;
         T00053_A20UsuarioEpisodioAssistido = new bool[] {false} ;
         T00053_A21UsuarioEpisodioComentario = new String[] {""} ;
         T00053_A22UsuarioEpisodioFavorito = new bool[] {false} ;
         T00053_A11UsuarioId = new long[1] ;
         T00053_A7EpisodioId = new long[1] ;
         sMode5 = "";
         T000510_A18UsuarioEpisodioId = new long[1] ;
         T000511_A18UsuarioEpisodioId = new long[1] ;
         T00052_A18UsuarioEpisodioId = new long[1] ;
         T00052_A19UsuarioEpisodioNota = new short[1] ;
         T00052_A20UsuarioEpisodioAssistido = new bool[] {false} ;
         T00052_A21UsuarioEpisodioComentario = new String[] {""} ;
         T00052_A22UsuarioEpisodioFavorito = new bool[] {false} ;
         T00052_A11UsuarioId = new long[1] ;
         T00052_A7EpisodioId = new long[1] ;
         T000512_A18UsuarioEpisodioId = new long[1] ;
         T000515_A18UsuarioEpisodioId = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000516_A11UsuarioId = new long[1] ;
         T000517_A7EpisodioId = new long[1] ;
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.usuarioepisodio__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuarioepisodio__default(),
            new Object[][] {
                new Object[] {
               T00052_A18UsuarioEpisodioId, T00052_A19UsuarioEpisodioNota, T00052_A20UsuarioEpisodioAssistido, T00052_A21UsuarioEpisodioComentario, T00052_A22UsuarioEpisodioFavorito, T00052_A11UsuarioId, T00052_A7EpisodioId
               }
               , new Object[] {
               T00053_A18UsuarioEpisodioId, T00053_A19UsuarioEpisodioNota, T00053_A20UsuarioEpisodioAssistido, T00053_A21UsuarioEpisodioComentario, T00053_A22UsuarioEpisodioFavorito, T00053_A11UsuarioId, T00053_A7EpisodioId
               }
               , new Object[] {
               T00054_A11UsuarioId
               }
               , new Object[] {
               T00055_A7EpisodioId
               }
               , new Object[] {
               T00056_A18UsuarioEpisodioId, T00056_A19UsuarioEpisodioNota, T00056_A20UsuarioEpisodioAssistido, T00056_A21UsuarioEpisodioComentario, T00056_A22UsuarioEpisodioFavorito, T00056_A11UsuarioId, T00056_A7EpisodioId
               }
               , new Object[] {
               T00057_A11UsuarioId
               }
               , new Object[] {
               T00058_A7EpisodioId
               }
               , new Object[] {
               T00059_A18UsuarioEpisodioId
               }
               , new Object[] {
               T000510_A18UsuarioEpisodioId
               }
               , new Object[] {
               T000511_A18UsuarioEpisodioId
               }
               , new Object[] {
               T000512_A18UsuarioEpisodioId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000515_A18UsuarioEpisodioId
               }
               , new Object[] {
               T000516_A11UsuarioId
               }
               , new Object[] {
               T000517_A7EpisodioId
               }
            }
         );
      }

      private short Z19UsuarioEpisodioNota ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A19UsuarioEpisodioNota ;
      private short GX_JID ;
      private short RcdFound5 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUsuarioEpisodioId_Enabled ;
      private int edtUsuarioId_Enabled ;
      private int imgprompt_11_Visible ;
      private int edtEpisodioId_Enabled ;
      private int imgprompt_7_Visible ;
      private int edtUsuarioEpisodioNota_Enabled ;
      private int edtUsuarioEpisodioComentario_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z18UsuarioEpisodioId ;
      private long Z11UsuarioId ;
      private long Z7EpisodioId ;
      private long A11UsuarioId ;
      private long A7EpisodioId ;
      private long A18UsuarioEpisodioId ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String chkUsuarioEpisodioAssistido_Internalname ;
      private String chkUsuarioEpisodioFavorito_Internalname ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUsuarioEpisodioId_Internalname ;
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
      private String edtUsuarioEpisodioId_Jsonclick ;
      private String edtUsuarioId_Internalname ;
      private String edtUsuarioId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_11_Internalname ;
      private String imgprompt_11_Link ;
      private String edtEpisodioId_Internalname ;
      private String edtEpisodioId_Jsonclick ;
      private String imgprompt_7_Internalname ;
      private String imgprompt_7_Link ;
      private String edtUsuarioEpisodioNota_Internalname ;
      private String edtUsuarioEpisodioNota_Jsonclick ;
      private String edtUsuarioEpisodioComentario_Internalname ;
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
      private String sMode5 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool Z20UsuarioEpisodioAssistido ;
      private bool Z22UsuarioEpisodioFavorito ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A20UsuarioEpisodioAssistido ;
      private bool A22UsuarioEpisodioFavorito ;
      private bool Gx_longc ;
      private String Z21UsuarioEpisodioComentario ;
      private String A21UsuarioEpisodioComentario ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkUsuarioEpisodioAssistido ;
      private GXCheckbox chkUsuarioEpisodioFavorito ;
      private IDataStoreProvider pr_default ;
      private long[] T00056_A18UsuarioEpisodioId ;
      private short[] T00056_A19UsuarioEpisodioNota ;
      private bool[] T00056_A20UsuarioEpisodioAssistido ;
      private String[] T00056_A21UsuarioEpisodioComentario ;
      private bool[] T00056_A22UsuarioEpisodioFavorito ;
      private long[] T00056_A11UsuarioId ;
      private long[] T00056_A7EpisodioId ;
      private long[] T00054_A11UsuarioId ;
      private long[] T00055_A7EpisodioId ;
      private long[] T00057_A11UsuarioId ;
      private long[] T00058_A7EpisodioId ;
      private long[] T00059_A18UsuarioEpisodioId ;
      private long[] T00053_A18UsuarioEpisodioId ;
      private short[] T00053_A19UsuarioEpisodioNota ;
      private bool[] T00053_A20UsuarioEpisodioAssistido ;
      private String[] T00053_A21UsuarioEpisodioComentario ;
      private bool[] T00053_A22UsuarioEpisodioFavorito ;
      private long[] T00053_A11UsuarioId ;
      private long[] T00053_A7EpisodioId ;
      private long[] T000510_A18UsuarioEpisodioId ;
      private long[] T000511_A18UsuarioEpisodioId ;
      private long[] T00052_A18UsuarioEpisodioId ;
      private short[] T00052_A19UsuarioEpisodioNota ;
      private bool[] T00052_A20UsuarioEpisodioAssistido ;
      private String[] T00052_A21UsuarioEpisodioComentario ;
      private bool[] T00052_A22UsuarioEpisodioFavorito ;
      private long[] T00052_A11UsuarioId ;
      private long[] T00052_A7EpisodioId ;
      private long[] T000512_A18UsuarioEpisodioId ;
      private IDataStoreProvider pr_gam ;
      private long[] T000515_A18UsuarioEpisodioId ;
      private long[] T000516_A11UsuarioId ;
      private long[] T000517_A7EpisodioId ;
      private GXWebForm Form ;
   }

   public class usuarioepisodio__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class usuarioepisodio__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT00056 ;
        prmT00056 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00054 ;
        prmT00054 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00055 ;
        prmT00055 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00057 ;
        prmT00057 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00058 ;
        prmT00058 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00059 ;
        prmT00059 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00053 ;
        prmT00053 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000510 ;
        prmT000510 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000511 ;
        prmT000511 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00052 ;
        prmT00052 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000512 ;
        prmT000512 = new Object[] {
        new Object[] {"@UsuarioEpisodioNota",SqlDbType.SmallInt,1,0} ,
        new Object[] {"@UsuarioEpisodioAssistido",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioEpisodioComentario",SqlDbType.VarChar,300,0} ,
        new Object[] {"@UsuarioEpisodioFavorito",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000513 ;
        prmT000513 = new Object[] {
        new Object[] {"@UsuarioEpisodioNota",SqlDbType.SmallInt,1,0} ,
        new Object[] {"@UsuarioEpisodioAssistido",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioEpisodioComentario",SqlDbType.VarChar,300,0} ,
        new Object[] {"@UsuarioEpisodioFavorito",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000514 ;
        prmT000514 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000515 ;
        prmT000515 = new Object[] {
        } ;
        Object[] prmT000516 ;
        prmT000516 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000517 ;
        prmT000517 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00052", "SELECT [UsuarioEpisodioId], [UsuarioEpisodioNota], [UsuarioEpisodioAssistido], [UsuarioEpisodioComentario], [UsuarioEpisodioFavorito], [UsuarioId], [EpisodioId] FROM [UsuarioEpisodio] WITH (UPDLOCK) WHERE [UsuarioEpisodioId] = @UsuarioEpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1,0,true,false )
           ,new CursorDef("T00053", "SELECT [UsuarioEpisodioId], [UsuarioEpisodioNota], [UsuarioEpisodioAssistido], [UsuarioEpisodioComentario], [UsuarioEpisodioFavorito], [UsuarioId], [EpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE [UsuarioEpisodioId] = @UsuarioEpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1,0,true,false )
           ,new CursorDef("T00054", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,1,0,true,false )
           ,new CursorDef("T00055", "SELECT [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,1,0,true,false )
           ,new CursorDef("T00056", "SELECT TM1.[UsuarioEpisodioId], TM1.[UsuarioEpisodioNota], TM1.[UsuarioEpisodioAssistido], TM1.[UsuarioEpisodioComentario], TM1.[UsuarioEpisodioFavorito], TM1.[UsuarioId], TM1.[EpisodioId] FROM [UsuarioEpisodio] TM1 WITH (NOLOCK) WHERE TM1.[UsuarioEpisodioId] = @UsuarioEpisodioId ORDER BY TM1.[UsuarioEpisodioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,100,0,true,false )
           ,new CursorDef("T00057", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,1,0,true,false )
           ,new CursorDef("T00058", "SELECT [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00058,1,0,true,false )
           ,new CursorDef("T00059", "SELECT [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE [UsuarioEpisodioId] = @UsuarioEpisodioId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00059,1,0,true,false )
           ,new CursorDef("T000510", "SELECT TOP 1 [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE ( [UsuarioEpisodioId] > @UsuarioEpisodioId) ORDER BY [UsuarioEpisodioId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000510,1,0,true,true )
           ,new CursorDef("T000511", "SELECT TOP 1 [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE ( [UsuarioEpisodioId] < @UsuarioEpisodioId) ORDER BY [UsuarioEpisodioId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000511,1,0,true,true )
           ,new CursorDef("T000512", "INSERT INTO [UsuarioEpisodio]([UsuarioEpisodioNota], [UsuarioEpisodioAssistido], [UsuarioEpisodioComentario], [UsuarioEpisodioFavorito], [UsuarioId], [EpisodioId]) VALUES(@UsuarioEpisodioNota, @UsuarioEpisodioAssistido, @UsuarioEpisodioComentario, @UsuarioEpisodioFavorito, @UsuarioId, @EpisodioId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000512)
           ,new CursorDef("T000513", "UPDATE [UsuarioEpisodio] SET [UsuarioEpisodioNota]=@UsuarioEpisodioNota, [UsuarioEpisodioAssistido]=@UsuarioEpisodioAssistido, [UsuarioEpisodioComentario]=@UsuarioEpisodioComentario, [UsuarioEpisodioFavorito]=@UsuarioEpisodioFavorito, [UsuarioId]=@UsuarioId, [EpisodioId]=@EpisodioId  WHERE [UsuarioEpisodioId] = @UsuarioEpisodioId", GxErrorMask.GX_NOMASK,prmT000513)
           ,new CursorDef("T000514", "DELETE FROM [UsuarioEpisodio]  WHERE [UsuarioEpisodioId] = @UsuarioEpisodioId", GxErrorMask.GX_NOMASK,prmT000514)
           ,new CursorDef("T000515", "SELECT [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) ORDER BY [UsuarioEpisodioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000515,100,0,true,false )
           ,new CursorDef("T000516", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000516,1,0,true,false )
           ,new CursorDef("T000517", "SELECT [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000517,1,0,true,false )
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
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((bool[]) buf[2])[0] = rslt.getBool(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[4])[0] = rslt.getBool(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              ((long[]) buf[6])[0] = rslt.getLong(7) ;
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
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 10 :
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
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (bool)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (bool)parms[3]);
              stmt.SetParameter(5, (long)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              return;
           case 11 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (bool)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (bool)parms[3]);
              stmt.SetParameter(5, (long)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              stmt.SetParameter(7, (long)parms[6]);
              return;
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 14 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 15 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
