/*
               File: UsuarioRecomendacaoEpisodio
        Description: Usuário recomendação episódios
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:39:33.16
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
   public class usuariorecomendacaoepisodio : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A38UsuarioRecomendacaoEpisodioOri = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38UsuarioRecomendacaoEpisodioOri", StringUtil.LTrim( StringUtil.Str( (decimal)(A38UsuarioRecomendacaoEpisodioOri), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A38UsuarioRecomendacaoEpisodioOri) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A39UsuarioRecomendacaoEpisodioDes = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39UsuarioRecomendacaoEpisodioDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A39UsuarioRecomendacaoEpisodioDes), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_5( A39UsuarioRecomendacaoEpisodioDes) ;
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
            Form.Meta.addItem("description", "Usuário recomendação episódios", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUsuarioRecomendacaoEpisodioId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public usuariorecomendacaoepisodio( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public usuariorecomendacaoepisodio( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Usuário recomendação episódios", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_UsuarioRecomendacaoEpisodio.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Selecionar", bttBtn_select_Jsonclick, 4, "Selecionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIORECOMENDACAOEPISODIOID"+"'), id:'"+"USUARIORECOMENDACAOEPISODIOID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_UsuarioRecomendacaoEpisodio.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioRecomendacaoEpisodioId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioRecomendacaoEpisodioId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioRecomendacaoEpisodioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0, ",", "")), ((edtUsuarioRecomendacaoEpisodioId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A37UsuarioRecomendacaoEpisodioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A37UsuarioRecomendacaoEpisodioId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioRecomendacaoEpisodioId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioRecomendacaoEpisodioId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioRecomendacaoEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioRecomendacaoEpisodioOri_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioRecomendacaoEpisodioOri_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioRecomendacaoEpisodioOri_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A38UsuarioRecomendacaoEpisodioOri), 18, 0, ",", "")), ((edtUsuarioRecomendacaoEpisodioOri_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A38UsuarioRecomendacaoEpisodioOri), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A38UsuarioRecomendacaoEpisodioOri), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioRecomendacaoEpisodioOri_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioRecomendacaoEpisodioOri_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioRecomendacaoEpisodio.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_38_Internalname, sImgUrl, imgprompt_38_Link, "", "", context.GetTheme( ), imgprompt_38_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioRecomendacaoEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioRecomendacaoEpisodioDes_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioRecomendacaoEpisodioDes_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioRecomendacaoEpisodioDes_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A39UsuarioRecomendacaoEpisodioDes), 18, 0, ",", "")), ((edtUsuarioRecomendacaoEpisodioDes_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A39UsuarioRecomendacaoEpisodioDes), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A39UsuarioRecomendacaoEpisodioDes), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioRecomendacaoEpisodioDes_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioRecomendacaoEpisodioDes_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioRecomendacaoEpisodio.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_39_Internalname, sImgUrl, imgprompt_39_Link, "", "", context.GetTheme( ), imgprompt_39_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioRecomendacaoEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioRecomendacaoEpisodioCom_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioRecomendacaoEpisodioCom_Internalname, "Comentário", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtUsuarioRecomendacaoEpisodioCom_Internalname, A40UsuarioRecomendacaoEpisodioCom, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,43);\"", 0, 1, edtUsuarioRecomendacaoEpisodioCom_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "Comentario", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_UsuarioRecomendacaoEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioRecomendacaoEpisodioDat_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioRecomendacaoEpisodioDat_Internalname, "da recomendação", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtUsuarioRecomendacaoEpisodioDat_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioRecomendacaoEpisodioDat_Internalname, context.localUtil.TToC( A41UsuarioRecomendacaoEpisodioDat, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A41UsuarioRecomendacaoEpisodioDat, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'por',false,0);"+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioRecomendacaoEpisodioDat_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioRecomendacaoEpisodioDat_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "DataHora", "right", false, "HLP_UsuarioRecomendacaoEpisodio.htm");
            GxWebStd.gx_bitmap( context, edtUsuarioRecomendacaoEpisodioDat_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtUsuarioRecomendacaoEpisodioDat_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_UsuarioRecomendacaoEpisodio.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEpisodioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EpisodioId), 18, 0, ",", "")), ((edtEpisodioId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEpisodioId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEpisodioId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioRecomendacaoEpisodio.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_7_Internalname, sImgUrl, imgprompt_7_Link, "", "", context.GetTheme( ), imgprompt_7_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioRecomendacaoEpisodio.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoEpisodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoEpisodio.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoEpisodioId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoEpisodioId_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIORECOMENDACAOEPISODIOID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioRecomendacaoEpisodioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A37UsuarioRecomendacaoEpisodioId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0)));
               }
               else
               {
                  A37UsuarioRecomendacaoEpisodioId = (long)(context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoEpisodioId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoEpisodioOri_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoEpisodioOri_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIORECOMENDACAOEPISODIOORI");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioRecomendacaoEpisodioOri_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A38UsuarioRecomendacaoEpisodioOri = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38UsuarioRecomendacaoEpisodioOri", StringUtil.LTrim( StringUtil.Str( (decimal)(A38UsuarioRecomendacaoEpisodioOri), 18, 0)));
               }
               else
               {
                  A38UsuarioRecomendacaoEpisodioOri = (long)(context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoEpisodioOri_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38UsuarioRecomendacaoEpisodioOri", StringUtil.LTrim( StringUtil.Str( (decimal)(A38UsuarioRecomendacaoEpisodioOri), 18, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoEpisodioDes_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoEpisodioDes_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIORECOMENDACAOEPISODIODES");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioRecomendacaoEpisodioDes_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A39UsuarioRecomendacaoEpisodioDes = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39UsuarioRecomendacaoEpisodioDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A39UsuarioRecomendacaoEpisodioDes), 18, 0)));
               }
               else
               {
                  A39UsuarioRecomendacaoEpisodioDes = (long)(context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoEpisodioDes_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39UsuarioRecomendacaoEpisodioDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A39UsuarioRecomendacaoEpisodioDes), 18, 0)));
               }
               A40UsuarioRecomendacaoEpisodioCom = cgiGet( edtUsuarioRecomendacaoEpisodioCom_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40UsuarioRecomendacaoEpisodioCom", A40UsuarioRecomendacaoEpisodioCom);
               if ( context.localUtil.VCDateTime( cgiGet( edtUsuarioRecomendacaoEpisodioDat_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Data e hora da recomendação"}), 1, "USUARIORECOMENDACAOEPISODIODAT");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioRecomendacaoEpisodioDat_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A41UsuarioRecomendacaoEpisodioDat = (DateTime)(DateTime.MinValue);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41UsuarioRecomendacaoEpisodioDat", context.localUtil.TToC( A41UsuarioRecomendacaoEpisodioDat, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A41UsuarioRecomendacaoEpisodioDat = context.localUtil.CToT( cgiGet( edtUsuarioRecomendacaoEpisodioDat_Internalname));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41UsuarioRecomendacaoEpisodioDat", context.localUtil.TToC( A41UsuarioRecomendacaoEpisodioDat, 8, 5, 0, 3, "/", ":", " "));
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
               /* Read saved values. */
               Z37UsuarioRecomendacaoEpisodioId = (long)(context.localUtil.CToN( cgiGet( "Z37UsuarioRecomendacaoEpisodioId"), ",", "."));
               Z40UsuarioRecomendacaoEpisodioCom = cgiGet( "Z40UsuarioRecomendacaoEpisodioCom");
               Z41UsuarioRecomendacaoEpisodioDat = context.localUtil.CToT( cgiGet( "Z41UsuarioRecomendacaoEpisodioDat"), 0);
               Z7EpisodioId = (long)(context.localUtil.CToN( cgiGet( "Z7EpisodioId"), ",", "."));
               Z38UsuarioRecomendacaoEpisodioOri = (long)(context.localUtil.CToN( cgiGet( "Z38UsuarioRecomendacaoEpisodioOri"), ",", "."));
               Z39UsuarioRecomendacaoEpisodioDes = (long)(context.localUtil.CToN( cgiGet( "Z39UsuarioRecomendacaoEpisodioDes"), ",", "."));
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
                  A37UsuarioRecomendacaoEpisodioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0)));
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
               InitAll0A10( ) ;
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
         DisableAttributes0A10( ) ;
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

      protected void ResetCaption0A0( )
      {
      }

      protected void ZM0A10( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z40UsuarioRecomendacaoEpisodioCom = T000A3_A40UsuarioRecomendacaoEpisodioCom[0];
               Z41UsuarioRecomendacaoEpisodioDat = T000A3_A41UsuarioRecomendacaoEpisodioDat[0];
               Z7EpisodioId = T000A3_A7EpisodioId[0];
               Z38UsuarioRecomendacaoEpisodioOri = T000A3_A38UsuarioRecomendacaoEpisodioOri[0];
               Z39UsuarioRecomendacaoEpisodioDes = T000A3_A39UsuarioRecomendacaoEpisodioDes[0];
            }
            else
            {
               Z40UsuarioRecomendacaoEpisodioCom = A40UsuarioRecomendacaoEpisodioCom;
               Z41UsuarioRecomendacaoEpisodioDat = A41UsuarioRecomendacaoEpisodioDat;
               Z7EpisodioId = A7EpisodioId;
               Z38UsuarioRecomendacaoEpisodioOri = A38UsuarioRecomendacaoEpisodioOri;
               Z39UsuarioRecomendacaoEpisodioDes = A39UsuarioRecomendacaoEpisodioDes;
            }
         }
         if ( GX_JID == -2 )
         {
            Z37UsuarioRecomendacaoEpisodioId = A37UsuarioRecomendacaoEpisodioId;
            Z40UsuarioRecomendacaoEpisodioCom = A40UsuarioRecomendacaoEpisodioCom;
            Z41UsuarioRecomendacaoEpisodioDat = A41UsuarioRecomendacaoEpisodioDat;
            Z7EpisodioId = A7EpisodioId;
            Z38UsuarioRecomendacaoEpisodioOri = A38UsuarioRecomendacaoEpisodioOri;
            Z39UsuarioRecomendacaoEpisodioDes = A39UsuarioRecomendacaoEpisodioDes;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_38_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIORECOMENDACAOEPISODIOORI"+"'), id:'"+"USUARIORECOMENDACAOEPISODIOORI"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_39_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIORECOMENDACAOEPISODIODES"+"'), id:'"+"USUARIORECOMENDACAOEPISODIODES"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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

      protected void Load0A10( )
      {
         /* Using cursor T000A7 */
         pr_default.execute(5, new Object[] {A37UsuarioRecomendacaoEpisodioId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound10 = 1;
            A40UsuarioRecomendacaoEpisodioCom = T000A7_A40UsuarioRecomendacaoEpisodioCom[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40UsuarioRecomendacaoEpisodioCom", A40UsuarioRecomendacaoEpisodioCom);
            A41UsuarioRecomendacaoEpisodioDat = T000A7_A41UsuarioRecomendacaoEpisodioDat[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41UsuarioRecomendacaoEpisodioDat", context.localUtil.TToC( A41UsuarioRecomendacaoEpisodioDat, 8, 5, 0, 3, "/", ":", " "));
            A7EpisodioId = T000A7_A7EpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
            A38UsuarioRecomendacaoEpisodioOri = T000A7_A38UsuarioRecomendacaoEpisodioOri[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38UsuarioRecomendacaoEpisodioOri", StringUtil.LTrim( StringUtil.Str( (decimal)(A38UsuarioRecomendacaoEpisodioOri), 18, 0)));
            A39UsuarioRecomendacaoEpisodioDes = T000A7_A39UsuarioRecomendacaoEpisodioDes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39UsuarioRecomendacaoEpisodioDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A39UsuarioRecomendacaoEpisodioDes), 18, 0)));
            ZM0A10( -2) ;
         }
         pr_default.close(5);
         OnLoadActions0A10( ) ;
      }

      protected void OnLoadActions0A10( )
      {
      }

      protected void CheckExtendedTable0A10( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T000A5 */
         pr_default.execute(3, new Object[] {A38UsuarioRecomendacaoEpisodioOri});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário recomendação de episódio origem'.", "ForeignKeyNotFound", 1, "USUARIORECOMENDACAOEPISODIOORI");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoEpisodioOri_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(3);
         /* Using cursor T000A6 */
         pr_default.execute(4, new Object[] {A39UsuarioRecomendacaoEpisodioDes});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário recomendação de episódio destino'.", "ForeignKeyNotFound", 1, "USUARIORECOMENDACAOEPISODIODES");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoEpisodioDes_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(4);
         if ( ! ( (DateTime.MinValue==A41UsuarioRecomendacaoEpisodioDat) || ( A41UsuarioRecomendacaoEpisodioDat >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Data e hora da recomendação fora do intervalo", "OutOfRange", 1, "USUARIORECOMENDACAOEPISODIODAT");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoEpisodioDat_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T000A4 */
         pr_default.execute(2, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Episódio'.", "ForeignKeyNotFound", 1, "EPISODIOID");
            AnyError = 1;
            GX_FocusControl = edtEpisodioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0A10( )
      {
         pr_default.close(3);
         pr_default.close(4);
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_4( long A38UsuarioRecomendacaoEpisodioOri )
      {
         /* Using cursor T000A8 */
         pr_default.execute(6, new Object[] {A38UsuarioRecomendacaoEpisodioOri});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário recomendação de episódio origem'.", "ForeignKeyNotFound", 1, "USUARIORECOMENDACAOEPISODIOORI");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoEpisodioOri_Internalname;
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

      protected void gxLoad_5( long A39UsuarioRecomendacaoEpisodioDes )
      {
         /* Using cursor T000A9 */
         pr_default.execute(7, new Object[] {A39UsuarioRecomendacaoEpisodioDes});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário recomendação de episódio destino'.", "ForeignKeyNotFound", 1, "USUARIORECOMENDACAOEPISODIODES");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoEpisodioDes_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(7);
      }

      protected void gxLoad_3( long A7EpisodioId )
      {
         /* Using cursor T000A10 */
         pr_default.execute(8, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(8) == 101) )
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
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(8);
      }

      protected void GetKey0A10( )
      {
         /* Using cursor T000A11 */
         pr_default.execute(9, new Object[] {A37UsuarioRecomendacaoEpisodioId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound10 = 1;
         }
         else
         {
            RcdFound10 = 0;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000A3 */
         pr_default.execute(1, new Object[] {A37UsuarioRecomendacaoEpisodioId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0A10( 2) ;
            RcdFound10 = 1;
            A37UsuarioRecomendacaoEpisodioId = T000A3_A37UsuarioRecomendacaoEpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0)));
            A40UsuarioRecomendacaoEpisodioCom = T000A3_A40UsuarioRecomendacaoEpisodioCom[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40UsuarioRecomendacaoEpisodioCom", A40UsuarioRecomendacaoEpisodioCom);
            A41UsuarioRecomendacaoEpisodioDat = T000A3_A41UsuarioRecomendacaoEpisodioDat[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41UsuarioRecomendacaoEpisodioDat", context.localUtil.TToC( A41UsuarioRecomendacaoEpisodioDat, 8, 5, 0, 3, "/", ":", " "));
            A7EpisodioId = T000A3_A7EpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
            A38UsuarioRecomendacaoEpisodioOri = T000A3_A38UsuarioRecomendacaoEpisodioOri[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38UsuarioRecomendacaoEpisodioOri", StringUtil.LTrim( StringUtil.Str( (decimal)(A38UsuarioRecomendacaoEpisodioOri), 18, 0)));
            A39UsuarioRecomendacaoEpisodioDes = T000A3_A39UsuarioRecomendacaoEpisodioDes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39UsuarioRecomendacaoEpisodioDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A39UsuarioRecomendacaoEpisodioDes), 18, 0)));
            Z37UsuarioRecomendacaoEpisodioId = A37UsuarioRecomendacaoEpisodioId;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0A10( ) ;
            if ( AnyError == 1 )
            {
               RcdFound10 = 0;
               InitializeNonKey0A10( ) ;
            }
            Gx_mode = sMode10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound10 = 0;
            InitializeNonKey0A10( ) ;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0A10( ) ;
         if ( RcdFound10 == 0 )
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
         RcdFound10 = 0;
         /* Using cursor T000A12 */
         pr_default.execute(10, new Object[] {A37UsuarioRecomendacaoEpisodioId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000A12_A37UsuarioRecomendacaoEpisodioId[0] < A37UsuarioRecomendacaoEpisodioId ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000A12_A37UsuarioRecomendacaoEpisodioId[0] > A37UsuarioRecomendacaoEpisodioId ) ) )
            {
               A37UsuarioRecomendacaoEpisodioId = T000A12_A37UsuarioRecomendacaoEpisodioId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0)));
               RcdFound10 = 1;
            }
         }
         pr_default.close(10);
      }

      protected void move_previous( )
      {
         RcdFound10 = 0;
         /* Using cursor T000A13 */
         pr_default.execute(11, new Object[] {A37UsuarioRecomendacaoEpisodioId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000A13_A37UsuarioRecomendacaoEpisodioId[0] > A37UsuarioRecomendacaoEpisodioId ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000A13_A37UsuarioRecomendacaoEpisodioId[0] < A37UsuarioRecomendacaoEpisodioId ) ) )
            {
               A37UsuarioRecomendacaoEpisodioId = T000A13_A37UsuarioRecomendacaoEpisodioId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0)));
               RcdFound10 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0A10( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUsuarioRecomendacaoEpisodioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0A10( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound10 == 1 )
            {
               if ( A37UsuarioRecomendacaoEpisodioId != Z37UsuarioRecomendacaoEpisodioId )
               {
                  A37UsuarioRecomendacaoEpisodioId = Z37UsuarioRecomendacaoEpisodioId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "USUARIORECOMENDACAOEPISODIOID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioRecomendacaoEpisodioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtUsuarioRecomendacaoEpisodioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0A10( ) ;
                  GX_FocusControl = edtUsuarioRecomendacaoEpisodioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A37UsuarioRecomendacaoEpisodioId != Z37UsuarioRecomendacaoEpisodioId )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtUsuarioRecomendacaoEpisodioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0A10( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "USUARIORECOMENDACAOEPISODIOID");
                     AnyError = 1;
                     GX_FocusControl = edtUsuarioRecomendacaoEpisodioId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtUsuarioRecomendacaoEpisodioId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0A10( ) ;
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
         if ( A37UsuarioRecomendacaoEpisodioId != Z37UsuarioRecomendacaoEpisodioId )
         {
            A37UsuarioRecomendacaoEpisodioId = Z37UsuarioRecomendacaoEpisodioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "USUARIORECOMENDACAOEPISODIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoEpisodioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUsuarioRecomendacaoEpisodioId_Internalname;
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
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "USUARIORECOMENDACAOEPISODIOID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoEpisodioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtUsuarioRecomendacaoEpisodioOri_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0A10( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioRecomendacaoEpisodioOri_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0A10( ) ;
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
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioRecomendacaoEpisodioOri_Internalname;
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
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioRecomendacaoEpisodioOri_Internalname;
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
         ScanStart0A10( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound10 != 0 )
            {
               ScanNext0A10( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioRecomendacaoEpisodioOri_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0A10( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0A10( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000A2 */
            pr_default.execute(0, new Object[] {A37UsuarioRecomendacaoEpisodioId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioRecomendacaoEpisodio"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z40UsuarioRecomendacaoEpisodioCom, T000A2_A40UsuarioRecomendacaoEpisodioCom[0]) != 0 ) || ( Z41UsuarioRecomendacaoEpisodioDat != T000A2_A41UsuarioRecomendacaoEpisodioDat[0] ) || ( Z7EpisodioId != T000A2_A7EpisodioId[0] ) || ( Z38UsuarioRecomendacaoEpisodioOri != T000A2_A38UsuarioRecomendacaoEpisodioOri[0] ) || ( Z39UsuarioRecomendacaoEpisodioDes != T000A2_A39UsuarioRecomendacaoEpisodioDes[0] ) )
            {
               if ( StringUtil.StrCmp(Z40UsuarioRecomendacaoEpisodioCom, T000A2_A40UsuarioRecomendacaoEpisodioCom[0]) != 0 )
               {
                  GXUtil.WriteLog("usuariorecomendacaoepisodio:[seudo value changed for attri]"+"UsuarioRecomendacaoEpisodioCom");
                  GXUtil.WriteLogRaw("Old: ",Z40UsuarioRecomendacaoEpisodioCom);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A40UsuarioRecomendacaoEpisodioCom[0]);
               }
               if ( Z41UsuarioRecomendacaoEpisodioDat != T000A2_A41UsuarioRecomendacaoEpisodioDat[0] )
               {
                  GXUtil.WriteLog("usuariorecomendacaoepisodio:[seudo value changed for attri]"+"UsuarioRecomendacaoEpisodioDat");
                  GXUtil.WriteLogRaw("Old: ",Z41UsuarioRecomendacaoEpisodioDat);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A41UsuarioRecomendacaoEpisodioDat[0]);
               }
               if ( Z7EpisodioId != T000A2_A7EpisodioId[0] )
               {
                  GXUtil.WriteLog("usuariorecomendacaoepisodio:[seudo value changed for attri]"+"EpisodioId");
                  GXUtil.WriteLogRaw("Old: ",Z7EpisodioId);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A7EpisodioId[0]);
               }
               if ( Z38UsuarioRecomendacaoEpisodioOri != T000A2_A38UsuarioRecomendacaoEpisodioOri[0] )
               {
                  GXUtil.WriteLog("usuariorecomendacaoepisodio:[seudo value changed for attri]"+"UsuarioRecomendacaoEpisodioOri");
                  GXUtil.WriteLogRaw("Old: ",Z38UsuarioRecomendacaoEpisodioOri);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A38UsuarioRecomendacaoEpisodioOri[0]);
               }
               if ( Z39UsuarioRecomendacaoEpisodioDes != T000A2_A39UsuarioRecomendacaoEpisodioDes[0] )
               {
                  GXUtil.WriteLog("usuariorecomendacaoepisodio:[seudo value changed for attri]"+"UsuarioRecomendacaoEpisodioDes");
                  GXUtil.WriteLogRaw("Old: ",Z39UsuarioRecomendacaoEpisodioDes);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A39UsuarioRecomendacaoEpisodioDes[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"UsuarioRecomendacaoEpisodio"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0A10( )
      {
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0A10( 0) ;
            CheckOptimisticConcurrency0A10( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A10( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0A10( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A14 */
                     pr_default.execute(12, new Object[] {A40UsuarioRecomendacaoEpisodioCom, A41UsuarioRecomendacaoEpisodioDat, A7EpisodioId, A38UsuarioRecomendacaoEpisodioOri, A39UsuarioRecomendacaoEpisodioDes});
                     A37UsuarioRecomendacaoEpisodioId = T000A14_A37UsuarioRecomendacaoEpisodioId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0)));
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioRecomendacaoEpisodio") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0A0( ) ;
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
               Load0A10( ) ;
            }
            EndLevel0A10( ) ;
         }
         CloseExtendedTableCursors0A10( ) ;
      }

      protected void Update0A10( )
      {
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A10( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A10( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0A10( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A15 */
                     pr_default.execute(13, new Object[] {A40UsuarioRecomendacaoEpisodioCom, A41UsuarioRecomendacaoEpisodioDat, A7EpisodioId, A38UsuarioRecomendacaoEpisodioOri, A39UsuarioRecomendacaoEpisodioDes, A37UsuarioRecomendacaoEpisodioId});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioRecomendacaoEpisodio") ;
                     if ( (pr_default.getStatus(13) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioRecomendacaoEpisodio"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0A10( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption0A0( ) ;
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
            EndLevel0A10( ) ;
         }
         CloseExtendedTableCursors0A10( ) ;
      }

      protected void DeferredUpdate0A10( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0A10( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0A10( ) ;
            AfterConfirm0A10( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0A10( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000A16 */
                  pr_default.execute(14, new Object[] {A37UsuarioRecomendacaoEpisodioId});
                  pr_default.close(14);
                  dsDefault.SmartCacheProvider.SetUpdated("UsuarioRecomendacaoEpisodio") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound10 == 0 )
                        {
                           InitAll0A10( ) ;
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
                        ResetCaption0A0( ) ;
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
         sMode10 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0A10( ) ;
         Gx_mode = sMode10;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0A10( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0A10( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0A10( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_gam.commit( "UsuarioRecomendacaoEpisodio");
            pr_default.commit( "UsuarioRecomendacaoEpisodio");
            if ( AnyError == 0 )
            {
               ConfirmValues0A0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_gam.rollback( "UsuarioRecomendacaoEpisodio");
            pr_default.rollback( "UsuarioRecomendacaoEpisodio");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0A10( )
      {
         /* Using cursor T000A17 */
         pr_default.execute(15);
         RcdFound10 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound10 = 1;
            A37UsuarioRecomendacaoEpisodioId = T000A17_A37UsuarioRecomendacaoEpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0A10( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound10 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound10 = 1;
            A37UsuarioRecomendacaoEpisodioId = T000A17_A37UsuarioRecomendacaoEpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0)));
         }
      }

      protected void ScanEnd0A10( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm0A10( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0A10( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0A10( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0A10( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0A10( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0A10( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0A10( )
      {
         edtUsuarioRecomendacaoEpisodioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioRecomendacaoEpisodioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioRecomendacaoEpisodioId_Enabled), 5, 0)), true);
         edtUsuarioRecomendacaoEpisodioOri_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioRecomendacaoEpisodioOri_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioRecomendacaoEpisodioOri_Enabled), 5, 0)), true);
         edtUsuarioRecomendacaoEpisodioDes_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioRecomendacaoEpisodioDes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioRecomendacaoEpisodioDes_Enabled), 5, 0)), true);
         edtUsuarioRecomendacaoEpisodioCom_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioRecomendacaoEpisodioCom_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioRecomendacaoEpisodioCom_Enabled), 5, 0)), true);
         edtUsuarioRecomendacaoEpisodioDat_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioRecomendacaoEpisodioDat_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioRecomendacaoEpisodioDat_Enabled), 5, 0)), true);
         edtEpisodioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEpisodioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEpisodioId_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0A10( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0A0( )
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
         context.AddJavascriptSource("gxcfg.js", "?201892019393566", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("usuariorecomendacaoepisodio.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z37UsuarioRecomendacaoEpisodioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z40UsuarioRecomendacaoEpisodioCom", Z40UsuarioRecomendacaoEpisodioCom);
         GxWebStd.gx_hidden_field( context, "Z41UsuarioRecomendacaoEpisodioDat", context.localUtil.TToC( Z41UsuarioRecomendacaoEpisodioDat, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z7EpisodioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7EpisodioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z38UsuarioRecomendacaoEpisodioOri", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38UsuarioRecomendacaoEpisodioOri), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z39UsuarioRecomendacaoEpisodioDes", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z39UsuarioRecomendacaoEpisodioDes), 18, 0, ",", "")));
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
         return formatLink("usuariorecomendacaoepisodio.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "UsuarioRecomendacaoEpisodio" ;
      }

      public override String GetPgmdesc( )
      {
         return "Usuário recomendação episódios" ;
      }

      protected void InitializeNonKey0A10( )
      {
         A38UsuarioRecomendacaoEpisodioOri = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38UsuarioRecomendacaoEpisodioOri", StringUtil.LTrim( StringUtil.Str( (decimal)(A38UsuarioRecomendacaoEpisodioOri), 18, 0)));
         A39UsuarioRecomendacaoEpisodioDes = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39UsuarioRecomendacaoEpisodioDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A39UsuarioRecomendacaoEpisodioDes), 18, 0)));
         A40UsuarioRecomendacaoEpisodioCom = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40UsuarioRecomendacaoEpisodioCom", A40UsuarioRecomendacaoEpisodioCom);
         A41UsuarioRecomendacaoEpisodioDat = (DateTime)(DateTime.MinValue);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41UsuarioRecomendacaoEpisodioDat", context.localUtil.TToC( A41UsuarioRecomendacaoEpisodioDat, 8, 5, 0, 3, "/", ":", " "));
         A7EpisodioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
         Z40UsuarioRecomendacaoEpisodioCom = "";
         Z41UsuarioRecomendacaoEpisodioDat = (DateTime)(DateTime.MinValue);
         Z7EpisodioId = 0;
         Z38UsuarioRecomendacaoEpisodioOri = 0;
         Z39UsuarioRecomendacaoEpisodioDes = 0;
      }

      protected void InitAll0A10( )
      {
         A37UsuarioRecomendacaoEpisodioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37UsuarioRecomendacaoEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A37UsuarioRecomendacaoEpisodioId), 18, 0)));
         InitializeNonKey0A10( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019393576", true);
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
         context.AddJavascriptSource("usuariorecomendacaoepisodio.js", "?201892019393577", false);
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
         edtUsuarioRecomendacaoEpisodioId_Internalname = "USUARIORECOMENDACAOEPISODIOID";
         edtUsuarioRecomendacaoEpisodioOri_Internalname = "USUARIORECOMENDACAOEPISODIOORI";
         edtUsuarioRecomendacaoEpisodioDes_Internalname = "USUARIORECOMENDACAOEPISODIODES";
         edtUsuarioRecomendacaoEpisodioCom_Internalname = "USUARIORECOMENDACAOEPISODIOCOM";
         edtUsuarioRecomendacaoEpisodioDat_Internalname = "USUARIORECOMENDACAOEPISODIODAT";
         edtEpisodioId_Internalname = "EPISODIOID";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         Form.Internalname = "FORM";
         imgprompt_38_Internalname = "PROMPT_38";
         imgprompt_39_Internalname = "PROMPT_39";
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
         Form.Caption = "Usuário recomendação episódios";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         imgprompt_7_Visible = 1;
         imgprompt_7_Link = "";
         edtEpisodioId_Jsonclick = "";
         edtEpisodioId_Enabled = 1;
         edtUsuarioRecomendacaoEpisodioDat_Jsonclick = "";
         edtUsuarioRecomendacaoEpisodioDat_Enabled = 1;
         edtUsuarioRecomendacaoEpisodioCom_Enabled = 1;
         imgprompt_39_Visible = 1;
         imgprompt_39_Link = "";
         edtUsuarioRecomendacaoEpisodioDes_Jsonclick = "";
         edtUsuarioRecomendacaoEpisodioDes_Enabled = 1;
         imgprompt_38_Visible = 1;
         imgprompt_38_Link = "";
         edtUsuarioRecomendacaoEpisodioOri_Jsonclick = "";
         edtUsuarioRecomendacaoEpisodioOri_Enabled = 1;
         edtUsuarioRecomendacaoEpisodioId_Jsonclick = "";
         edtUsuarioRecomendacaoEpisodioId_Enabled = 1;
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
         GX_FocusControl = edtUsuarioRecomendacaoEpisodioOri_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Usuariorecomendacaoepisodioid( long GX_Parm1 ,
                                                       String GX_Parm2 ,
                                                       DateTime GX_Parm3 ,
                                                       long GX_Parm4 ,
                                                       long GX_Parm5 ,
                                                       long GX_Parm6 )
      {
         A37UsuarioRecomendacaoEpisodioId = GX_Parm1;
         A40UsuarioRecomendacaoEpisodioCom = GX_Parm2;
         A41UsuarioRecomendacaoEpisodioDat = GX_Parm3;
         A7EpisodioId = GX_Parm4;
         A38UsuarioRecomendacaoEpisodioOri = GX_Parm5;
         A39UsuarioRecomendacaoEpisodioDes = GX_Parm6;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A38UsuarioRecomendacaoEpisodioOri), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A39UsuarioRecomendacaoEpisodioDes), 18, 0, ".", "")));
         isValidOutput.Add(A40UsuarioRecomendacaoEpisodioCom);
         isValidOutput.Add(context.localUtil.TToC( A41UsuarioRecomendacaoEpisodioDat, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EpisodioId), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z37UsuarioRecomendacaoEpisodioId), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38UsuarioRecomendacaoEpisodioOri), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z39UsuarioRecomendacaoEpisodioDes), 18, 0, ",", "")));
         isValidOutput.Add(Z40UsuarioRecomendacaoEpisodioCom);
         isValidOutput.Add(context.localUtil.TToC( Z41UsuarioRecomendacaoEpisodioDat, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7EpisodioId), 18, 0, ",", "")));
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Usuariorecomendacaoepisodioori( long GX_Parm1 )
      {
         A38UsuarioRecomendacaoEpisodioOri = GX_Parm1;
         /* Using cursor T000A18 */
         pr_default.execute(16, new Object[] {A38UsuarioRecomendacaoEpisodioOri});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário recomendação de episódio origem'.", "ForeignKeyNotFound", 1, "USUARIORECOMENDACAOEPISODIOORI");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoEpisodioOri_Internalname;
         }
         pr_default.close(16);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Usuariorecomendacaoepisodiodes( long GX_Parm1 )
      {
         A39UsuarioRecomendacaoEpisodioDes = GX_Parm1;
         /* Using cursor T000A19 */
         pr_default.execute(17, new Object[] {A39UsuarioRecomendacaoEpisodioDes});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário recomendação de episódio destino'.", "ForeignKeyNotFound", 1, "USUARIORECOMENDACAOEPISODIODES");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoEpisodioDes_Internalname;
         }
         pr_default.close(17);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Episodioid( long GX_Parm1 )
      {
         A7EpisodioId = GX_Parm1;
         /* Using cursor T000A20 */
         pr_default.execute(18, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("Não existe 'Episódio'.", "ForeignKeyNotFound", 1, "EPISODIOID");
            AnyError = 1;
            GX_FocusControl = edtEpisodioId_Internalname;
         }
         pr_default.close(18);
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
         pr_default.close(18);
         pr_default.close(16);
         pr_default.close(17);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z40UsuarioRecomendacaoEpisodioCom = "";
         Z41UsuarioRecomendacaoEpisodioDat = (DateTime)(DateTime.MinValue);
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
         A40UsuarioRecomendacaoEpisodioCom = "";
         A41UsuarioRecomendacaoEpisodioDat = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T000A7_A37UsuarioRecomendacaoEpisodioId = new long[1] ;
         T000A7_A40UsuarioRecomendacaoEpisodioCom = new String[] {""} ;
         T000A7_A41UsuarioRecomendacaoEpisodioDat = new DateTime[] {DateTime.MinValue} ;
         T000A7_A7EpisodioId = new long[1] ;
         T000A7_A38UsuarioRecomendacaoEpisodioOri = new long[1] ;
         T000A7_A39UsuarioRecomendacaoEpisodioDes = new long[1] ;
         T000A5_A38UsuarioRecomendacaoEpisodioOri = new long[1] ;
         T000A6_A39UsuarioRecomendacaoEpisodioDes = new long[1] ;
         T000A4_A7EpisodioId = new long[1] ;
         T000A8_A38UsuarioRecomendacaoEpisodioOri = new long[1] ;
         T000A9_A39UsuarioRecomendacaoEpisodioDes = new long[1] ;
         T000A10_A7EpisodioId = new long[1] ;
         T000A11_A37UsuarioRecomendacaoEpisodioId = new long[1] ;
         T000A3_A37UsuarioRecomendacaoEpisodioId = new long[1] ;
         T000A3_A40UsuarioRecomendacaoEpisodioCom = new String[] {""} ;
         T000A3_A41UsuarioRecomendacaoEpisodioDat = new DateTime[] {DateTime.MinValue} ;
         T000A3_A7EpisodioId = new long[1] ;
         T000A3_A38UsuarioRecomendacaoEpisodioOri = new long[1] ;
         T000A3_A39UsuarioRecomendacaoEpisodioDes = new long[1] ;
         sMode10 = "";
         T000A12_A37UsuarioRecomendacaoEpisodioId = new long[1] ;
         T000A13_A37UsuarioRecomendacaoEpisodioId = new long[1] ;
         T000A2_A37UsuarioRecomendacaoEpisodioId = new long[1] ;
         T000A2_A40UsuarioRecomendacaoEpisodioCom = new String[] {""} ;
         T000A2_A41UsuarioRecomendacaoEpisodioDat = new DateTime[] {DateTime.MinValue} ;
         T000A2_A7EpisodioId = new long[1] ;
         T000A2_A38UsuarioRecomendacaoEpisodioOri = new long[1] ;
         T000A2_A39UsuarioRecomendacaoEpisodioDes = new long[1] ;
         T000A14_A37UsuarioRecomendacaoEpisodioId = new long[1] ;
         T000A17_A37UsuarioRecomendacaoEpisodioId = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000A18_A38UsuarioRecomendacaoEpisodioOri = new long[1] ;
         T000A19_A39UsuarioRecomendacaoEpisodioDes = new long[1] ;
         T000A20_A7EpisodioId = new long[1] ;
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.usuariorecomendacaoepisodio__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuariorecomendacaoepisodio__default(),
            new Object[][] {
                new Object[] {
               T000A2_A37UsuarioRecomendacaoEpisodioId, T000A2_A40UsuarioRecomendacaoEpisodioCom, T000A2_A41UsuarioRecomendacaoEpisodioDat, T000A2_A7EpisodioId, T000A2_A38UsuarioRecomendacaoEpisodioOri, T000A2_A39UsuarioRecomendacaoEpisodioDes
               }
               , new Object[] {
               T000A3_A37UsuarioRecomendacaoEpisodioId, T000A3_A40UsuarioRecomendacaoEpisodioCom, T000A3_A41UsuarioRecomendacaoEpisodioDat, T000A3_A7EpisodioId, T000A3_A38UsuarioRecomendacaoEpisodioOri, T000A3_A39UsuarioRecomendacaoEpisodioDes
               }
               , new Object[] {
               T000A4_A7EpisodioId
               }
               , new Object[] {
               T000A5_A38UsuarioRecomendacaoEpisodioOri
               }
               , new Object[] {
               T000A6_A39UsuarioRecomendacaoEpisodioDes
               }
               , new Object[] {
               T000A7_A37UsuarioRecomendacaoEpisodioId, T000A7_A40UsuarioRecomendacaoEpisodioCom, T000A7_A41UsuarioRecomendacaoEpisodioDat, T000A7_A7EpisodioId, T000A7_A38UsuarioRecomendacaoEpisodioOri, T000A7_A39UsuarioRecomendacaoEpisodioDes
               }
               , new Object[] {
               T000A8_A38UsuarioRecomendacaoEpisodioOri
               }
               , new Object[] {
               T000A9_A39UsuarioRecomendacaoEpisodioDes
               }
               , new Object[] {
               T000A10_A7EpisodioId
               }
               , new Object[] {
               T000A11_A37UsuarioRecomendacaoEpisodioId
               }
               , new Object[] {
               T000A12_A37UsuarioRecomendacaoEpisodioId
               }
               , new Object[] {
               T000A13_A37UsuarioRecomendacaoEpisodioId
               }
               , new Object[] {
               T000A14_A37UsuarioRecomendacaoEpisodioId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000A17_A37UsuarioRecomendacaoEpisodioId
               }
               , new Object[] {
               T000A18_A38UsuarioRecomendacaoEpisodioOri
               }
               , new Object[] {
               T000A19_A39UsuarioRecomendacaoEpisodioDes
               }
               , new Object[] {
               T000A20_A7EpisodioId
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
      private short GX_JID ;
      private short RcdFound10 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUsuarioRecomendacaoEpisodioId_Enabled ;
      private int edtUsuarioRecomendacaoEpisodioOri_Enabled ;
      private int imgprompt_38_Visible ;
      private int edtUsuarioRecomendacaoEpisodioDes_Enabled ;
      private int imgprompt_39_Visible ;
      private int edtUsuarioRecomendacaoEpisodioCom_Enabled ;
      private int edtUsuarioRecomendacaoEpisodioDat_Enabled ;
      private int edtEpisodioId_Enabled ;
      private int imgprompt_7_Visible ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z37UsuarioRecomendacaoEpisodioId ;
      private long Z7EpisodioId ;
      private long Z38UsuarioRecomendacaoEpisodioOri ;
      private long Z39UsuarioRecomendacaoEpisodioDes ;
      private long A38UsuarioRecomendacaoEpisodioOri ;
      private long A39UsuarioRecomendacaoEpisodioDes ;
      private long A7EpisodioId ;
      private long A37UsuarioRecomendacaoEpisodioId ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUsuarioRecomendacaoEpisodioId_Internalname ;
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
      private String edtUsuarioRecomendacaoEpisodioId_Jsonclick ;
      private String edtUsuarioRecomendacaoEpisodioOri_Internalname ;
      private String edtUsuarioRecomendacaoEpisodioOri_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_38_Internalname ;
      private String imgprompt_38_Link ;
      private String edtUsuarioRecomendacaoEpisodioDes_Internalname ;
      private String edtUsuarioRecomendacaoEpisodioDes_Jsonclick ;
      private String imgprompt_39_Internalname ;
      private String imgprompt_39_Link ;
      private String edtUsuarioRecomendacaoEpisodioCom_Internalname ;
      private String edtUsuarioRecomendacaoEpisodioDat_Internalname ;
      private String edtUsuarioRecomendacaoEpisodioDat_Jsonclick ;
      private String edtEpisodioId_Internalname ;
      private String edtEpisodioId_Jsonclick ;
      private String imgprompt_7_Internalname ;
      private String imgprompt_7_Link ;
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
      private String sMode10 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z41UsuarioRecomendacaoEpisodioDat ;
      private DateTime A41UsuarioRecomendacaoEpisodioDat ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private String Z40UsuarioRecomendacaoEpisodioCom ;
      private String A40UsuarioRecomendacaoEpisodioCom ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T000A7_A37UsuarioRecomendacaoEpisodioId ;
      private String[] T000A7_A40UsuarioRecomendacaoEpisodioCom ;
      private DateTime[] T000A7_A41UsuarioRecomendacaoEpisodioDat ;
      private long[] T000A7_A7EpisodioId ;
      private long[] T000A7_A38UsuarioRecomendacaoEpisodioOri ;
      private long[] T000A7_A39UsuarioRecomendacaoEpisodioDes ;
      private long[] T000A5_A38UsuarioRecomendacaoEpisodioOri ;
      private long[] T000A6_A39UsuarioRecomendacaoEpisodioDes ;
      private long[] T000A4_A7EpisodioId ;
      private long[] T000A8_A38UsuarioRecomendacaoEpisodioOri ;
      private long[] T000A9_A39UsuarioRecomendacaoEpisodioDes ;
      private long[] T000A10_A7EpisodioId ;
      private long[] T000A11_A37UsuarioRecomendacaoEpisodioId ;
      private long[] T000A3_A37UsuarioRecomendacaoEpisodioId ;
      private String[] T000A3_A40UsuarioRecomendacaoEpisodioCom ;
      private DateTime[] T000A3_A41UsuarioRecomendacaoEpisodioDat ;
      private long[] T000A3_A7EpisodioId ;
      private long[] T000A3_A38UsuarioRecomendacaoEpisodioOri ;
      private long[] T000A3_A39UsuarioRecomendacaoEpisodioDes ;
      private long[] T000A12_A37UsuarioRecomendacaoEpisodioId ;
      private long[] T000A13_A37UsuarioRecomendacaoEpisodioId ;
      private long[] T000A2_A37UsuarioRecomendacaoEpisodioId ;
      private String[] T000A2_A40UsuarioRecomendacaoEpisodioCom ;
      private DateTime[] T000A2_A41UsuarioRecomendacaoEpisodioDat ;
      private long[] T000A2_A7EpisodioId ;
      private long[] T000A2_A38UsuarioRecomendacaoEpisodioOri ;
      private long[] T000A2_A39UsuarioRecomendacaoEpisodioDes ;
      private long[] T000A14_A37UsuarioRecomendacaoEpisodioId ;
      private IDataStoreProvider pr_gam ;
      private long[] T000A17_A37UsuarioRecomendacaoEpisodioId ;
      private long[] T000A18_A38UsuarioRecomendacaoEpisodioOri ;
      private long[] T000A19_A39UsuarioRecomendacaoEpisodioDes ;
      private long[] T000A20_A7EpisodioId ;
      private GXWebForm Form ;
   }

   public class usuariorecomendacaoepisodio__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class usuariorecomendacaoepisodio__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT000A7 ;
        prmT000A7 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A5 ;
        prmT000A5 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioOri",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A6 ;
        prmT000A6 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioDes",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A4 ;
        prmT000A4 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A8 ;
        prmT000A8 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioOri",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A9 ;
        prmT000A9 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioDes",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A10 ;
        prmT000A10 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A11 ;
        prmT000A11 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A3 ;
        prmT000A3 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A12 ;
        prmT000A12 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A13 ;
        prmT000A13 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A2 ;
        prmT000A2 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A14 ;
        prmT000A14 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioCom",SqlDbType.VarChar,300,0} ,
        new Object[] {"@UsuarioRecomendacaoEpisodioDat",SqlDbType.DateTime,8,5} ,
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioRecomendacaoEpisodioOri",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioRecomendacaoEpisodioDes",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A15 ;
        prmT000A15 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioCom",SqlDbType.VarChar,300,0} ,
        new Object[] {"@UsuarioRecomendacaoEpisodioDat",SqlDbType.DateTime,8,5} ,
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioRecomendacaoEpisodioOri",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioRecomendacaoEpisodioDes",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioRecomendacaoEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A16 ;
        prmT000A16 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A17 ;
        prmT000A17 = new Object[] {
        } ;
        Object[] prmT000A18 ;
        prmT000A18 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioOri",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A19 ;
        prmT000A19 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoEpisodioDes",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A20 ;
        prmT000A20 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000A2", "SELECT [UsuarioRecomendacaoEpisodioId], [UsuarioRecomendacaoEpisodioCom], [UsuarioRecomendacaoEpisodioDat], [EpisodioId], [UsuarioRecomendacaoEpisodioOri] AS UsuarioRecomendacaoEpisodioOri, [UsuarioRecomendacaoEpisodioDes] AS UsuarioRecomendacaoEpisodioDes FROM [UsuarioRecomendacaoEpisodio] WITH (UPDLOCK) WHERE [UsuarioRecomendacaoEpisodioId] = @UsuarioRecomendacaoEpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A2,1,0,true,false )
           ,new CursorDef("T000A3", "SELECT [UsuarioRecomendacaoEpisodioId], [UsuarioRecomendacaoEpisodioCom], [UsuarioRecomendacaoEpisodioDat], [EpisodioId], [UsuarioRecomendacaoEpisodioOri] AS UsuarioRecomendacaoEpisodioOri, [UsuarioRecomendacaoEpisodioDes] AS UsuarioRecomendacaoEpisodioDes FROM [UsuarioRecomendacaoEpisodio] WITH (NOLOCK) WHERE [UsuarioRecomendacaoEpisodioId] = @UsuarioRecomendacaoEpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A3,1,0,true,false )
           ,new CursorDef("T000A4", "SELECT [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A4,1,0,true,false )
           ,new CursorDef("T000A5", "SELECT [UsuarioId] AS UsuarioRecomendacaoEpisodioOri FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioRecomendacaoEpisodioOri ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A5,1,0,true,false )
           ,new CursorDef("T000A6", "SELECT [UsuarioId] AS UsuarioRecomendacaoEpisodioDes FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioRecomendacaoEpisodioDes ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A6,1,0,true,false )
           ,new CursorDef("T000A7", "SELECT TM1.[UsuarioRecomendacaoEpisodioId], TM1.[UsuarioRecomendacaoEpisodioCom], TM1.[UsuarioRecomendacaoEpisodioDat], TM1.[EpisodioId], TM1.[UsuarioRecomendacaoEpisodioOri] AS UsuarioRecomendacaoEpisodioOri, TM1.[UsuarioRecomendacaoEpisodioDes] AS UsuarioRecomendacaoEpisodioDes FROM [UsuarioRecomendacaoEpisodio] TM1 WITH (NOLOCK) WHERE TM1.[UsuarioRecomendacaoEpisodioId] = @UsuarioRecomendacaoEpisodioId ORDER BY TM1.[UsuarioRecomendacaoEpisodioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A7,100,0,true,false )
           ,new CursorDef("T000A8", "SELECT [UsuarioId] AS UsuarioRecomendacaoEpisodioOri FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioRecomendacaoEpisodioOri ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A8,1,0,true,false )
           ,new CursorDef("T000A9", "SELECT [UsuarioId] AS UsuarioRecomendacaoEpisodioDes FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioRecomendacaoEpisodioDes ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A9,1,0,true,false )
           ,new CursorDef("T000A10", "SELECT [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A10,1,0,true,false )
           ,new CursorDef("T000A11", "SELECT [UsuarioRecomendacaoEpisodioId] FROM [UsuarioRecomendacaoEpisodio] WITH (NOLOCK) WHERE [UsuarioRecomendacaoEpisodioId] = @UsuarioRecomendacaoEpisodioId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A11,1,0,true,false )
           ,new CursorDef("T000A12", "SELECT TOP 1 [UsuarioRecomendacaoEpisodioId] FROM [UsuarioRecomendacaoEpisodio] WITH (NOLOCK) WHERE ( [UsuarioRecomendacaoEpisodioId] > @UsuarioRecomendacaoEpisodioId) ORDER BY [UsuarioRecomendacaoEpisodioId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A12,1,0,true,true )
           ,new CursorDef("T000A13", "SELECT TOP 1 [UsuarioRecomendacaoEpisodioId] FROM [UsuarioRecomendacaoEpisodio] WITH (NOLOCK) WHERE ( [UsuarioRecomendacaoEpisodioId] < @UsuarioRecomendacaoEpisodioId) ORDER BY [UsuarioRecomendacaoEpisodioId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A13,1,0,true,true )
           ,new CursorDef("T000A14", "INSERT INTO [UsuarioRecomendacaoEpisodio]([UsuarioRecomendacaoEpisodioCom], [UsuarioRecomendacaoEpisodioDat], [EpisodioId], [UsuarioRecomendacaoEpisodioOri], [UsuarioRecomendacaoEpisodioDes]) VALUES(@UsuarioRecomendacaoEpisodioCom, @UsuarioRecomendacaoEpisodioDat, @EpisodioId, @UsuarioRecomendacaoEpisodioOri, @UsuarioRecomendacaoEpisodioDes); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000A14)
           ,new CursorDef("T000A15", "UPDATE [UsuarioRecomendacaoEpisodio] SET [UsuarioRecomendacaoEpisodioCom]=@UsuarioRecomendacaoEpisodioCom, [UsuarioRecomendacaoEpisodioDat]=@UsuarioRecomendacaoEpisodioDat, [EpisodioId]=@EpisodioId, [UsuarioRecomendacaoEpisodioOri]=@UsuarioRecomendacaoEpisodioOri, [UsuarioRecomendacaoEpisodioDes]=@UsuarioRecomendacaoEpisodioDes  WHERE [UsuarioRecomendacaoEpisodioId] = @UsuarioRecomendacaoEpisodioId", GxErrorMask.GX_NOMASK,prmT000A15)
           ,new CursorDef("T000A16", "DELETE FROM [UsuarioRecomendacaoEpisodio]  WHERE [UsuarioRecomendacaoEpisodioId] = @UsuarioRecomendacaoEpisodioId", GxErrorMask.GX_NOMASK,prmT000A16)
           ,new CursorDef("T000A17", "SELECT [UsuarioRecomendacaoEpisodioId] FROM [UsuarioRecomendacaoEpisodio] WITH (NOLOCK) ORDER BY [UsuarioRecomendacaoEpisodioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A17,100,0,true,false )
           ,new CursorDef("T000A18", "SELECT [UsuarioId] AS UsuarioRecomendacaoEpisodioOri FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioRecomendacaoEpisodioOri ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A18,1,0,true,false )
           ,new CursorDef("T000A19", "SELECT [UsuarioId] AS UsuarioRecomendacaoEpisodioDes FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioRecomendacaoEpisodioDes ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A19,1,0,true,false )
           ,new CursorDef("T000A20", "SELECT [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A20,1,0,true,false )
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              ((long[]) buf[4])[0] = rslt.getLong(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              ((long[]) buf[4])[0] = rslt.getLong(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              ((long[]) buf[4])[0] = rslt.getLong(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
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
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 12 :
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
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameterDatetime(2, (DateTime)parms[1]);
              stmt.SetParameter(3, (long)parms[2]);
              stmt.SetParameter(4, (long)parms[3]);
              stmt.SetParameter(5, (long)parms[4]);
              return;
           case 13 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameterDatetime(2, (DateTime)parms[1]);
              stmt.SetParameter(3, (long)parms[2]);
              stmt.SetParameter(4, (long)parms[3]);
              stmt.SetParameter(5, (long)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              return;
           case 14 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 16 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 17 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 18 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
