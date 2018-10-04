/*
               File: UsuarioRecomendacaoSerie
        Description: Usuário recomendação série
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:33.18
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
   public class usuariorecomendacaoserie : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A33UsuarioRecomendacaoSerieOrigem = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33UsuarioRecomendacaoSerieOrigem", StringUtil.LTrim( StringUtil.Str( (decimal)(A33UsuarioRecomendacaoSerieOrigem), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A33UsuarioRecomendacaoSerieOrigem) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A34UsuarioRecomendacaoSerieDestin = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34UsuarioRecomendacaoSerieDestin", StringUtil.LTrim( StringUtil.Str( (decimal)(A34UsuarioRecomendacaoSerieDestin), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_5( A34UsuarioRecomendacaoSerieDestin) ;
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
            Form.Meta.addItem("description", "Usuário recomendação série", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUsuarioRecomendacaoSerieId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public usuariorecomendacaoserie( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public usuariorecomendacaoserie( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Usuário recomendação série", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_UsuarioRecomendacaoSerie.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Selecionar", bttBtn_select_Jsonclick, 4, "Selecionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0090.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIORECOMENDACAOSERIEID"+"'), id:'"+"USUARIORECOMENDACAOSERIEID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_UsuarioRecomendacaoSerie.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioRecomendacaoSerieId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioRecomendacaoSerieId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioRecomendacaoSerieId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0, ",", "")), ((edtUsuarioRecomendacaoSerieId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A32UsuarioRecomendacaoSerieId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A32UsuarioRecomendacaoSerieId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioRecomendacaoSerieId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioRecomendacaoSerieId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioRecomendacaoSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioRecomendacaoSerieOrigem_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioRecomendacaoSerieOrigem_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioRecomendacaoSerieOrigem_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33UsuarioRecomendacaoSerieOrigem), 18, 0, ",", "")), ((edtUsuarioRecomendacaoSerieOrigem_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A33UsuarioRecomendacaoSerieOrigem), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A33UsuarioRecomendacaoSerieOrigem), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioRecomendacaoSerieOrigem_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioRecomendacaoSerieOrigem_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioRecomendacaoSerie.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_33_Internalname, sImgUrl, imgprompt_33_Link, "", "", context.GetTheme( ), imgprompt_33_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioRecomendacaoSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioRecomendacaoSerieDestin_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioRecomendacaoSerieDestin_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUsuarioRecomendacaoSerieDestin_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A34UsuarioRecomendacaoSerieDestin), 18, 0, ",", "")), ((edtUsuarioRecomendacaoSerieDestin_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A34UsuarioRecomendacaoSerieDestin), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A34UsuarioRecomendacaoSerieDestin), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioRecomendacaoSerieDestin_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioRecomendacaoSerieDestin_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioRecomendacaoSerie.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_34_Internalname, sImgUrl, imgprompt_34_Link, "", "", context.GetTheme( ), imgprompt_34_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioRecomendacaoSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioRecomendacaoSerieComent_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioRecomendacaoSerieComent_Internalname, "Comentário", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtUsuarioRecomendacaoSerieComent_Internalname, A35UsuarioRecomendacaoSerieComent, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,43);\"", 0, 1, edtUsuarioRecomendacaoSerieComent_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "Comentario", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_UsuarioRecomendacaoSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUsuarioRecomendacaoSerieDataHo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUsuarioRecomendacaoSerieDataHo_Internalname, "da recomendação", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtUsuarioRecomendacaoSerieDataHo_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioRecomendacaoSerieDataHo_Internalname, context.localUtil.TToC( A36UsuarioRecomendacaoSerieDataHo, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A36UsuarioRecomendacaoSerieDataHo, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'por',false,0);"+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUsuarioRecomendacaoSerieDataHo_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUsuarioRecomendacaoSerieDataHo_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "DataHora", "right", false, "HLP_UsuarioRecomendacaoSerie.htm");
            GxWebStd.gx_bitmap( context, edtUsuarioRecomendacaoSerieDataHo_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtUsuarioRecomendacaoSerieDataHo_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_UsuarioRecomendacaoSerie.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSerieId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSerieId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSerieId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")), ((edtSerieId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSerieId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSerieId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_UsuarioRecomendacaoSerie.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_UsuarioRecomendacaoSerie.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoSerie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_UsuarioRecomendacaoSerie.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoSerieId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoSerieId_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIORECOMENDACAOSERIEID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioRecomendacaoSerieId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A32UsuarioRecomendacaoSerieId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0)));
               }
               else
               {
                  A32UsuarioRecomendacaoSerieId = (long)(context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoSerieId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoSerieOrigem_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoSerieOrigem_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIORECOMENDACAOSERIEORIGEM");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioRecomendacaoSerieOrigem_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A33UsuarioRecomendacaoSerieOrigem = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33UsuarioRecomendacaoSerieOrigem", StringUtil.LTrim( StringUtil.Str( (decimal)(A33UsuarioRecomendacaoSerieOrigem), 18, 0)));
               }
               else
               {
                  A33UsuarioRecomendacaoSerieOrigem = (long)(context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoSerieOrigem_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33UsuarioRecomendacaoSerieOrigem", StringUtil.LTrim( StringUtil.Str( (decimal)(A33UsuarioRecomendacaoSerieOrigem), 18, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoSerieDestin_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoSerieDestin_Internalname), ",", ".") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USUARIORECOMENDACAOSERIEDESTIN");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioRecomendacaoSerieDestin_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A34UsuarioRecomendacaoSerieDestin = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34UsuarioRecomendacaoSerieDestin", StringUtil.LTrim( StringUtil.Str( (decimal)(A34UsuarioRecomendacaoSerieDestin), 18, 0)));
               }
               else
               {
                  A34UsuarioRecomendacaoSerieDestin = (long)(context.localUtil.CToN( cgiGet( edtUsuarioRecomendacaoSerieDestin_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34UsuarioRecomendacaoSerieDestin", StringUtil.LTrim( StringUtil.Str( (decimal)(A34UsuarioRecomendacaoSerieDestin), 18, 0)));
               }
               A35UsuarioRecomendacaoSerieComent = cgiGet( edtUsuarioRecomendacaoSerieComent_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35UsuarioRecomendacaoSerieComent", A35UsuarioRecomendacaoSerieComent);
               if ( context.localUtil.VCDateTime( cgiGet( edtUsuarioRecomendacaoSerieDataHo_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Data e hora da recomendação"}), 1, "USUARIORECOMENDACAOSERIEDATAHO");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioRecomendacaoSerieDataHo_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A36UsuarioRecomendacaoSerieDataHo = (DateTime)(DateTime.MinValue);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36UsuarioRecomendacaoSerieDataHo", context.localUtil.TToC( A36UsuarioRecomendacaoSerieDataHo, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A36UsuarioRecomendacaoSerieDataHo = context.localUtil.CToT( cgiGet( edtUsuarioRecomendacaoSerieDataHo_Internalname));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36UsuarioRecomendacaoSerieDataHo", context.localUtil.TToC( A36UsuarioRecomendacaoSerieDataHo, 8, 5, 0, 3, "/", ":", " "));
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
               /* Read saved values. */
               Z32UsuarioRecomendacaoSerieId = (long)(context.localUtil.CToN( cgiGet( "Z32UsuarioRecomendacaoSerieId"), ",", "."));
               Z35UsuarioRecomendacaoSerieComent = cgiGet( "Z35UsuarioRecomendacaoSerieComent");
               Z36UsuarioRecomendacaoSerieDataHo = context.localUtil.CToT( cgiGet( "Z36UsuarioRecomendacaoSerieDataHo"), 0);
               Z1SerieId = (long)(context.localUtil.CToN( cgiGet( "Z1SerieId"), ",", "."));
               Z33UsuarioRecomendacaoSerieOrigem = (long)(context.localUtil.CToN( cgiGet( "Z33UsuarioRecomendacaoSerieOrigem"), ",", "."));
               Z34UsuarioRecomendacaoSerieDestin = (long)(context.localUtil.CToN( cgiGet( "Z34UsuarioRecomendacaoSerieDestin"), ",", "."));
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
                  A32UsuarioRecomendacaoSerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0)));
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
               InitAll099( ) ;
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
         DisableAttributes099( ) ;
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

      protected void ResetCaption090( )
      {
      }

      protected void ZM099( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z35UsuarioRecomendacaoSerieComent = T00093_A35UsuarioRecomendacaoSerieComent[0];
               Z36UsuarioRecomendacaoSerieDataHo = T00093_A36UsuarioRecomendacaoSerieDataHo[0];
               Z1SerieId = T00093_A1SerieId[0];
               Z33UsuarioRecomendacaoSerieOrigem = T00093_A33UsuarioRecomendacaoSerieOrigem[0];
               Z34UsuarioRecomendacaoSerieDestin = T00093_A34UsuarioRecomendacaoSerieDestin[0];
            }
            else
            {
               Z35UsuarioRecomendacaoSerieComent = A35UsuarioRecomendacaoSerieComent;
               Z36UsuarioRecomendacaoSerieDataHo = A36UsuarioRecomendacaoSerieDataHo;
               Z1SerieId = A1SerieId;
               Z33UsuarioRecomendacaoSerieOrigem = A33UsuarioRecomendacaoSerieOrigem;
               Z34UsuarioRecomendacaoSerieDestin = A34UsuarioRecomendacaoSerieDestin;
            }
         }
         if ( GX_JID == -2 )
         {
            Z32UsuarioRecomendacaoSerieId = A32UsuarioRecomendacaoSerieId;
            Z35UsuarioRecomendacaoSerieComent = A35UsuarioRecomendacaoSerieComent;
            Z36UsuarioRecomendacaoSerieDataHo = A36UsuarioRecomendacaoSerieDataHo;
            Z1SerieId = A1SerieId;
            Z33UsuarioRecomendacaoSerieOrigem = A33UsuarioRecomendacaoSerieOrigem;
            Z34UsuarioRecomendacaoSerieDestin = A34UsuarioRecomendacaoSerieDestin;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_33_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIORECOMENDACAOSERIEORIGEM"+"'), id:'"+"USUARIORECOMENDACAOSERIEORIGEM"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_34_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIORECOMENDACAOSERIEDESTIN"+"'), id:'"+"USUARIORECOMENDACAOSERIEDESTIN"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
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

      protected void Load099( )
      {
         /* Using cursor T00097 */
         pr_default.execute(5, new Object[] {A32UsuarioRecomendacaoSerieId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound9 = 1;
            A35UsuarioRecomendacaoSerieComent = T00097_A35UsuarioRecomendacaoSerieComent[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35UsuarioRecomendacaoSerieComent", A35UsuarioRecomendacaoSerieComent);
            A36UsuarioRecomendacaoSerieDataHo = T00097_A36UsuarioRecomendacaoSerieDataHo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36UsuarioRecomendacaoSerieDataHo", context.localUtil.TToC( A36UsuarioRecomendacaoSerieDataHo, 8, 5, 0, 3, "/", ":", " "));
            A1SerieId = T00097_A1SerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
            A33UsuarioRecomendacaoSerieOrigem = T00097_A33UsuarioRecomendacaoSerieOrigem[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33UsuarioRecomendacaoSerieOrigem", StringUtil.LTrim( StringUtil.Str( (decimal)(A33UsuarioRecomendacaoSerieOrigem), 18, 0)));
            A34UsuarioRecomendacaoSerieDestin = T00097_A34UsuarioRecomendacaoSerieDestin[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34UsuarioRecomendacaoSerieDestin", StringUtil.LTrim( StringUtil.Str( (decimal)(A34UsuarioRecomendacaoSerieDestin), 18, 0)));
            ZM099( -2) ;
         }
         pr_default.close(5);
         OnLoadActions099( ) ;
      }

      protected void OnLoadActions099( )
      {
      }

      protected void CheckExtendedTable099( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00095 */
         pr_default.execute(3, new Object[] {A33UsuarioRecomendacaoSerieOrigem});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuario recomendação de série origem'.", "ForeignKeyNotFound", 1, "USUARIORECOMENDACAOSERIEORIGEM");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoSerieOrigem_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(3);
         /* Using cursor T00096 */
         pr_default.execute(4, new Object[] {A34UsuarioRecomendacaoSerieDestin});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário recomendação de série destino'.", "ForeignKeyNotFound", 1, "USUARIORECOMENDACAOSERIEDESTIN");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoSerieDestin_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(4);
         if ( ! ( (DateTime.MinValue==A36UsuarioRecomendacaoSerieDataHo) || ( A36UsuarioRecomendacaoSerieDataHo >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Data e hora da recomendação fora do intervalo", "OutOfRange", 1, "USUARIORECOMENDACAOSERIEDATAHO");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoSerieDataHo_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00094 */
         pr_default.execute(2, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Série'.", "ForeignKeyNotFound", 1, "SERIEID");
            AnyError = 1;
            GX_FocusControl = edtSerieId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors099( )
      {
         pr_default.close(3);
         pr_default.close(4);
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_4( long A33UsuarioRecomendacaoSerieOrigem )
      {
         /* Using cursor T00098 */
         pr_default.execute(6, new Object[] {A33UsuarioRecomendacaoSerieOrigem});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuario recomendação de série origem'.", "ForeignKeyNotFound", 1, "USUARIORECOMENDACAOSERIEORIGEM");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoSerieOrigem_Internalname;
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

      protected void gxLoad_5( long A34UsuarioRecomendacaoSerieDestin )
      {
         /* Using cursor T00099 */
         pr_default.execute(7, new Object[] {A34UsuarioRecomendacaoSerieDestin});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário recomendação de série destino'.", "ForeignKeyNotFound", 1, "USUARIORECOMENDACAOSERIEDESTIN");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoSerieDestin_Internalname;
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

      protected void gxLoad_3( long A1SerieId )
      {
         /* Using cursor T000910 */
         pr_default.execute(8, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("Não existe 'Série'.", "ForeignKeyNotFound", 1, "SERIEID");
            AnyError = 1;
            GX_FocusControl = edtSerieId_Internalname;
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

      protected void GetKey099( )
      {
         /* Using cursor T000911 */
         pr_default.execute(9, new Object[] {A32UsuarioRecomendacaoSerieId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound9 = 1;
         }
         else
         {
            RcdFound9 = 0;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00093 */
         pr_default.execute(1, new Object[] {A32UsuarioRecomendacaoSerieId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM099( 2) ;
            RcdFound9 = 1;
            A32UsuarioRecomendacaoSerieId = T00093_A32UsuarioRecomendacaoSerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0)));
            A35UsuarioRecomendacaoSerieComent = T00093_A35UsuarioRecomendacaoSerieComent[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35UsuarioRecomendacaoSerieComent", A35UsuarioRecomendacaoSerieComent);
            A36UsuarioRecomendacaoSerieDataHo = T00093_A36UsuarioRecomendacaoSerieDataHo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36UsuarioRecomendacaoSerieDataHo", context.localUtil.TToC( A36UsuarioRecomendacaoSerieDataHo, 8, 5, 0, 3, "/", ":", " "));
            A1SerieId = T00093_A1SerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
            A33UsuarioRecomendacaoSerieOrigem = T00093_A33UsuarioRecomendacaoSerieOrigem[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33UsuarioRecomendacaoSerieOrigem", StringUtil.LTrim( StringUtil.Str( (decimal)(A33UsuarioRecomendacaoSerieOrigem), 18, 0)));
            A34UsuarioRecomendacaoSerieDestin = T00093_A34UsuarioRecomendacaoSerieDestin[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34UsuarioRecomendacaoSerieDestin", StringUtil.LTrim( StringUtil.Str( (decimal)(A34UsuarioRecomendacaoSerieDestin), 18, 0)));
            Z32UsuarioRecomendacaoSerieId = A32UsuarioRecomendacaoSerieId;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load099( ) ;
            if ( AnyError == 1 )
            {
               RcdFound9 = 0;
               InitializeNonKey099( ) ;
            }
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound9 = 0;
            InitializeNonKey099( ) ;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey099( ) ;
         if ( RcdFound9 == 0 )
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
         RcdFound9 = 0;
         /* Using cursor T000912 */
         pr_default.execute(10, new Object[] {A32UsuarioRecomendacaoSerieId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000912_A32UsuarioRecomendacaoSerieId[0] < A32UsuarioRecomendacaoSerieId ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000912_A32UsuarioRecomendacaoSerieId[0] > A32UsuarioRecomendacaoSerieId ) ) )
            {
               A32UsuarioRecomendacaoSerieId = T000912_A32UsuarioRecomendacaoSerieId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0)));
               RcdFound9 = 1;
            }
         }
         pr_default.close(10);
      }

      protected void move_previous( )
      {
         RcdFound9 = 0;
         /* Using cursor T000913 */
         pr_default.execute(11, new Object[] {A32UsuarioRecomendacaoSerieId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000913_A32UsuarioRecomendacaoSerieId[0] > A32UsuarioRecomendacaoSerieId ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000913_A32UsuarioRecomendacaoSerieId[0] < A32UsuarioRecomendacaoSerieId ) ) )
            {
               A32UsuarioRecomendacaoSerieId = T000913_A32UsuarioRecomendacaoSerieId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0)));
               RcdFound9 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey099( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUsuarioRecomendacaoSerieId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert099( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound9 == 1 )
            {
               if ( A32UsuarioRecomendacaoSerieId != Z32UsuarioRecomendacaoSerieId )
               {
                  A32UsuarioRecomendacaoSerieId = Z32UsuarioRecomendacaoSerieId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "USUARIORECOMENDACAOSERIEID");
                  AnyError = 1;
                  GX_FocusControl = edtUsuarioRecomendacaoSerieId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtUsuarioRecomendacaoSerieId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update099( ) ;
                  GX_FocusControl = edtUsuarioRecomendacaoSerieId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A32UsuarioRecomendacaoSerieId != Z32UsuarioRecomendacaoSerieId )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtUsuarioRecomendacaoSerieId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert099( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "USUARIORECOMENDACAOSERIEID");
                     AnyError = 1;
                     GX_FocusControl = edtUsuarioRecomendacaoSerieId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtUsuarioRecomendacaoSerieId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert099( ) ;
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
         if ( A32UsuarioRecomendacaoSerieId != Z32UsuarioRecomendacaoSerieId )
         {
            A32UsuarioRecomendacaoSerieId = Z32UsuarioRecomendacaoSerieId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "USUARIORECOMENDACAOSERIEID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoSerieId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUsuarioRecomendacaoSerieId_Internalname;
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
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "USUARIORECOMENDACAOSERIEID");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoSerieId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtUsuarioRecomendacaoSerieOrigem_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart099( ) ;
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioRecomendacaoSerieOrigem_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd099( ) ;
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
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioRecomendacaoSerieOrigem_Internalname;
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
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioRecomendacaoSerieOrigem_Internalname;
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
         ScanStart099( ) ;
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound9 != 0 )
            {
               ScanNext099( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioRecomendacaoSerieOrigem_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd099( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency099( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00092 */
            pr_default.execute(0, new Object[] {A32UsuarioRecomendacaoSerieId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioRecomendacaoSerie"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z35UsuarioRecomendacaoSerieComent, T00092_A35UsuarioRecomendacaoSerieComent[0]) != 0 ) || ( Z36UsuarioRecomendacaoSerieDataHo != T00092_A36UsuarioRecomendacaoSerieDataHo[0] ) || ( Z1SerieId != T00092_A1SerieId[0] ) || ( Z33UsuarioRecomendacaoSerieOrigem != T00092_A33UsuarioRecomendacaoSerieOrigem[0] ) || ( Z34UsuarioRecomendacaoSerieDestin != T00092_A34UsuarioRecomendacaoSerieDestin[0] ) )
            {
               if ( StringUtil.StrCmp(Z35UsuarioRecomendacaoSerieComent, T00092_A35UsuarioRecomendacaoSerieComent[0]) != 0 )
               {
                  GXUtil.WriteLog("usuariorecomendacaoserie:[seudo value changed for attri]"+"UsuarioRecomendacaoSerieComent");
                  GXUtil.WriteLogRaw("Old: ",Z35UsuarioRecomendacaoSerieComent);
                  GXUtil.WriteLogRaw("Current: ",T00092_A35UsuarioRecomendacaoSerieComent[0]);
               }
               if ( Z36UsuarioRecomendacaoSerieDataHo != T00092_A36UsuarioRecomendacaoSerieDataHo[0] )
               {
                  GXUtil.WriteLog("usuariorecomendacaoserie:[seudo value changed for attri]"+"UsuarioRecomendacaoSerieDataHo");
                  GXUtil.WriteLogRaw("Old: ",Z36UsuarioRecomendacaoSerieDataHo);
                  GXUtil.WriteLogRaw("Current: ",T00092_A36UsuarioRecomendacaoSerieDataHo[0]);
               }
               if ( Z1SerieId != T00092_A1SerieId[0] )
               {
                  GXUtil.WriteLog("usuariorecomendacaoserie:[seudo value changed for attri]"+"SerieId");
                  GXUtil.WriteLogRaw("Old: ",Z1SerieId);
                  GXUtil.WriteLogRaw("Current: ",T00092_A1SerieId[0]);
               }
               if ( Z33UsuarioRecomendacaoSerieOrigem != T00092_A33UsuarioRecomendacaoSerieOrigem[0] )
               {
                  GXUtil.WriteLog("usuariorecomendacaoserie:[seudo value changed for attri]"+"UsuarioRecomendacaoSerieOrigem");
                  GXUtil.WriteLogRaw("Old: ",Z33UsuarioRecomendacaoSerieOrigem);
                  GXUtil.WriteLogRaw("Current: ",T00092_A33UsuarioRecomendacaoSerieOrigem[0]);
               }
               if ( Z34UsuarioRecomendacaoSerieDestin != T00092_A34UsuarioRecomendacaoSerieDestin[0] )
               {
                  GXUtil.WriteLog("usuariorecomendacaoserie:[seudo value changed for attri]"+"UsuarioRecomendacaoSerieDestin");
                  GXUtil.WriteLogRaw("Old: ",Z34UsuarioRecomendacaoSerieDestin);
                  GXUtil.WriteLogRaw("Current: ",T00092_A34UsuarioRecomendacaoSerieDestin[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"UsuarioRecomendacaoSerie"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert099( )
      {
         BeforeValidate099( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable099( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM099( 0) ;
            CheckOptimisticConcurrency099( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm099( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert099( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000914 */
                     pr_default.execute(12, new Object[] {A35UsuarioRecomendacaoSerieComent, A36UsuarioRecomendacaoSerieDataHo, A1SerieId, A33UsuarioRecomendacaoSerieOrigem, A34UsuarioRecomendacaoSerieDestin});
                     A32UsuarioRecomendacaoSerieId = T000914_A32UsuarioRecomendacaoSerieId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0)));
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioRecomendacaoSerie") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption090( ) ;
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
               Load099( ) ;
            }
            EndLevel099( ) ;
         }
         CloseExtendedTableCursors099( ) ;
      }

      protected void Update099( )
      {
         BeforeValidate099( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable099( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency099( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm099( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate099( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000915 */
                     pr_default.execute(13, new Object[] {A35UsuarioRecomendacaoSerieComent, A36UsuarioRecomendacaoSerieDataHo, A1SerieId, A33UsuarioRecomendacaoSerieOrigem, A34UsuarioRecomendacaoSerieDestin, A32UsuarioRecomendacaoSerieId});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioRecomendacaoSerie") ;
                     if ( (pr_default.getStatus(13) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioRecomendacaoSerie"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate099( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption090( ) ;
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
            EndLevel099( ) ;
         }
         CloseExtendedTableCursors099( ) ;
      }

      protected void DeferredUpdate099( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate099( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency099( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls099( ) ;
            AfterConfirm099( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete099( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000916 */
                  pr_default.execute(14, new Object[] {A32UsuarioRecomendacaoSerieId});
                  pr_default.close(14);
                  dsDefault.SmartCacheProvider.SetUpdated("UsuarioRecomendacaoSerie") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound9 == 0 )
                        {
                           InitAll099( ) ;
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
                        ResetCaption090( ) ;
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
         sMode9 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel099( ) ;
         Gx_mode = sMode9;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls099( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel099( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete099( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_gam.commit( "UsuarioRecomendacaoSerie");
            pr_default.commit( "UsuarioRecomendacaoSerie");
            if ( AnyError == 0 )
            {
               ConfirmValues090( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_gam.rollback( "UsuarioRecomendacaoSerie");
            pr_default.rollback( "UsuarioRecomendacaoSerie");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart099( )
      {
         /* Using cursor T000917 */
         pr_default.execute(15);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound9 = 1;
            A32UsuarioRecomendacaoSerieId = T000917_A32UsuarioRecomendacaoSerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext099( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound9 = 1;
            A32UsuarioRecomendacaoSerieId = T000917_A32UsuarioRecomendacaoSerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0)));
         }
      }

      protected void ScanEnd099( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm099( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert099( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate099( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete099( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete099( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate099( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes099( )
      {
         edtUsuarioRecomendacaoSerieId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioRecomendacaoSerieId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioRecomendacaoSerieId_Enabled), 5, 0)), true);
         edtUsuarioRecomendacaoSerieOrigem_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioRecomendacaoSerieOrigem_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioRecomendacaoSerieOrigem_Enabled), 5, 0)), true);
         edtUsuarioRecomendacaoSerieDestin_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioRecomendacaoSerieDestin_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioRecomendacaoSerieDestin_Enabled), 5, 0)), true);
         edtUsuarioRecomendacaoSerieComent_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioRecomendacaoSerieComent_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioRecomendacaoSerieComent_Enabled), 5, 0)), true);
         edtUsuarioRecomendacaoSerieDataHo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioRecomendacaoSerieDataHo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioRecomendacaoSerieDataHo_Enabled), 5, 0)), true);
         edtSerieId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieId_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes099( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues090( )
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
         context.AddJavascriptSource("gxcfg.js", "?20189251963480", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("usuariorecomendacaoserie.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32UsuarioRecomendacaoSerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z35UsuarioRecomendacaoSerieComent", Z35UsuarioRecomendacaoSerieComent);
         GxWebStd.gx_hidden_field( context, "Z36UsuarioRecomendacaoSerieDataHo", context.localUtil.TToC( Z36UsuarioRecomendacaoSerieDataHo, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z1SerieId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1SerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z33UsuarioRecomendacaoSerieOrigem", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33UsuarioRecomendacaoSerieOrigem), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z34UsuarioRecomendacaoSerieDestin", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34UsuarioRecomendacaoSerieDestin), 18, 0, ",", "")));
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
         return formatLink("usuariorecomendacaoserie.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "UsuarioRecomendacaoSerie" ;
      }

      public override String GetPgmdesc( )
      {
         return "Usuário recomendação série" ;
      }

      protected void InitializeNonKey099( )
      {
         A33UsuarioRecomendacaoSerieOrigem = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33UsuarioRecomendacaoSerieOrigem", StringUtil.LTrim( StringUtil.Str( (decimal)(A33UsuarioRecomendacaoSerieOrigem), 18, 0)));
         A34UsuarioRecomendacaoSerieDestin = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34UsuarioRecomendacaoSerieDestin", StringUtil.LTrim( StringUtil.Str( (decimal)(A34UsuarioRecomendacaoSerieDestin), 18, 0)));
         A35UsuarioRecomendacaoSerieComent = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35UsuarioRecomendacaoSerieComent", A35UsuarioRecomendacaoSerieComent);
         A36UsuarioRecomendacaoSerieDataHo = (DateTime)(DateTime.MinValue);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36UsuarioRecomendacaoSerieDataHo", context.localUtil.TToC( A36UsuarioRecomendacaoSerieDataHo, 8, 5, 0, 3, "/", ":", " "));
         A1SerieId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
         Z35UsuarioRecomendacaoSerieComent = "";
         Z36UsuarioRecomendacaoSerieDataHo = (DateTime)(DateTime.MinValue);
         Z1SerieId = 0;
         Z33UsuarioRecomendacaoSerieOrigem = 0;
         Z34UsuarioRecomendacaoSerieDestin = 0;
      }

      protected void InitAll099( )
      {
         A32UsuarioRecomendacaoSerieId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32UsuarioRecomendacaoSerieId), 18, 0)));
         InitializeNonKey099( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20189251963488", true);
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
         context.AddJavascriptSource("usuariorecomendacaoserie.js", "?20189251963488", false);
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
         edtUsuarioRecomendacaoSerieId_Internalname = "USUARIORECOMENDACAOSERIEID";
         edtUsuarioRecomendacaoSerieOrigem_Internalname = "USUARIORECOMENDACAOSERIEORIGEM";
         edtUsuarioRecomendacaoSerieDestin_Internalname = "USUARIORECOMENDACAOSERIEDESTIN";
         edtUsuarioRecomendacaoSerieComent_Internalname = "USUARIORECOMENDACAOSERIECOMENT";
         edtUsuarioRecomendacaoSerieDataHo_Internalname = "USUARIORECOMENDACAOSERIEDATAHO";
         edtSerieId_Internalname = "SERIEID";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         Form.Internalname = "FORM";
         imgprompt_33_Internalname = "PROMPT_33";
         imgprompt_34_Internalname = "PROMPT_34";
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
         Form.Caption = "Usuário recomendação série";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         imgprompt_1_Visible = 1;
         imgprompt_1_Link = "";
         edtSerieId_Jsonclick = "";
         edtSerieId_Enabled = 1;
         edtUsuarioRecomendacaoSerieDataHo_Jsonclick = "";
         edtUsuarioRecomendacaoSerieDataHo_Enabled = 1;
         edtUsuarioRecomendacaoSerieComent_Enabled = 1;
         imgprompt_34_Visible = 1;
         imgprompt_34_Link = "";
         edtUsuarioRecomendacaoSerieDestin_Jsonclick = "";
         edtUsuarioRecomendacaoSerieDestin_Enabled = 1;
         imgprompt_33_Visible = 1;
         imgprompt_33_Link = "";
         edtUsuarioRecomendacaoSerieOrigem_Jsonclick = "";
         edtUsuarioRecomendacaoSerieOrigem_Enabled = 1;
         edtUsuarioRecomendacaoSerieId_Jsonclick = "";
         edtUsuarioRecomendacaoSerieId_Enabled = 1;
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
         GX_FocusControl = edtUsuarioRecomendacaoSerieOrigem_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Usuariorecomendacaoserieid( long GX_Parm1 ,
                                                    String GX_Parm2 ,
                                                    DateTime GX_Parm3 ,
                                                    long GX_Parm4 ,
                                                    long GX_Parm5 ,
                                                    long GX_Parm6 )
      {
         A32UsuarioRecomendacaoSerieId = GX_Parm1;
         A35UsuarioRecomendacaoSerieComent = GX_Parm2;
         A36UsuarioRecomendacaoSerieDataHo = GX_Parm3;
         A1SerieId = GX_Parm4;
         A33UsuarioRecomendacaoSerieOrigem = GX_Parm5;
         A34UsuarioRecomendacaoSerieDestin = GX_Parm6;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A33UsuarioRecomendacaoSerieOrigem), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A34UsuarioRecomendacaoSerieDestin), 18, 0, ".", "")));
         isValidOutput.Add(A35UsuarioRecomendacaoSerieComent);
         isValidOutput.Add(context.localUtil.TToC( A36UsuarioRecomendacaoSerieDataHo, 10, 8, 0, 3, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32UsuarioRecomendacaoSerieId), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33UsuarioRecomendacaoSerieOrigem), 18, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34UsuarioRecomendacaoSerieDestin), 18, 0, ",", "")));
         isValidOutput.Add(Z35UsuarioRecomendacaoSerieComent);
         isValidOutput.Add(context.localUtil.TToC( Z36UsuarioRecomendacaoSerieDataHo, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1SerieId), 18, 0, ",", "")));
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Usuariorecomendacaoserieorigem( long GX_Parm1 )
      {
         A33UsuarioRecomendacaoSerieOrigem = GX_Parm1;
         /* Using cursor T000918 */
         pr_default.execute(16, new Object[] {A33UsuarioRecomendacaoSerieOrigem});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuario recomendação de série origem'.", "ForeignKeyNotFound", 1, "USUARIORECOMENDACAOSERIEORIGEM");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoSerieOrigem_Internalname;
         }
         pr_default.close(16);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Usuariorecomendacaoseriedestin( long GX_Parm1 )
      {
         A34UsuarioRecomendacaoSerieDestin = GX_Parm1;
         /* Using cursor T000919 */
         pr_default.execute(17, new Object[] {A34UsuarioRecomendacaoSerieDestin});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário recomendação de série destino'.", "ForeignKeyNotFound", 1, "USUARIORECOMENDACAOSERIEDESTIN");
            AnyError = 1;
            GX_FocusControl = edtUsuarioRecomendacaoSerieDestin_Internalname;
         }
         pr_default.close(17);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Serieid( long GX_Parm1 )
      {
         A1SerieId = GX_Parm1;
         /* Using cursor T000920 */
         pr_default.execute(18, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("Não existe 'Série'.", "ForeignKeyNotFound", 1, "SERIEID");
            AnyError = 1;
            GX_FocusControl = edtSerieId_Internalname;
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
         Z35UsuarioRecomendacaoSerieComent = "";
         Z36UsuarioRecomendacaoSerieDataHo = (DateTime)(DateTime.MinValue);
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
         A35UsuarioRecomendacaoSerieComent = "";
         A36UsuarioRecomendacaoSerieDataHo = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00097_A32UsuarioRecomendacaoSerieId = new long[1] ;
         T00097_A35UsuarioRecomendacaoSerieComent = new String[] {""} ;
         T00097_A36UsuarioRecomendacaoSerieDataHo = new DateTime[] {DateTime.MinValue} ;
         T00097_A1SerieId = new long[1] ;
         T00097_A33UsuarioRecomendacaoSerieOrigem = new long[1] ;
         T00097_A34UsuarioRecomendacaoSerieDestin = new long[1] ;
         T00095_A33UsuarioRecomendacaoSerieOrigem = new long[1] ;
         T00096_A34UsuarioRecomendacaoSerieDestin = new long[1] ;
         T00094_A1SerieId = new long[1] ;
         T00098_A33UsuarioRecomendacaoSerieOrigem = new long[1] ;
         T00099_A34UsuarioRecomendacaoSerieDestin = new long[1] ;
         T000910_A1SerieId = new long[1] ;
         T000911_A32UsuarioRecomendacaoSerieId = new long[1] ;
         T00093_A32UsuarioRecomendacaoSerieId = new long[1] ;
         T00093_A35UsuarioRecomendacaoSerieComent = new String[] {""} ;
         T00093_A36UsuarioRecomendacaoSerieDataHo = new DateTime[] {DateTime.MinValue} ;
         T00093_A1SerieId = new long[1] ;
         T00093_A33UsuarioRecomendacaoSerieOrigem = new long[1] ;
         T00093_A34UsuarioRecomendacaoSerieDestin = new long[1] ;
         sMode9 = "";
         T000912_A32UsuarioRecomendacaoSerieId = new long[1] ;
         T000913_A32UsuarioRecomendacaoSerieId = new long[1] ;
         T00092_A32UsuarioRecomendacaoSerieId = new long[1] ;
         T00092_A35UsuarioRecomendacaoSerieComent = new String[] {""} ;
         T00092_A36UsuarioRecomendacaoSerieDataHo = new DateTime[] {DateTime.MinValue} ;
         T00092_A1SerieId = new long[1] ;
         T00092_A33UsuarioRecomendacaoSerieOrigem = new long[1] ;
         T00092_A34UsuarioRecomendacaoSerieDestin = new long[1] ;
         T000914_A32UsuarioRecomendacaoSerieId = new long[1] ;
         T000917_A32UsuarioRecomendacaoSerieId = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000918_A33UsuarioRecomendacaoSerieOrigem = new long[1] ;
         T000919_A34UsuarioRecomendacaoSerieDestin = new long[1] ;
         T000920_A1SerieId = new long[1] ;
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.usuariorecomendacaoserie__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuariorecomendacaoserie__default(),
            new Object[][] {
                new Object[] {
               T00092_A32UsuarioRecomendacaoSerieId, T00092_A35UsuarioRecomendacaoSerieComent, T00092_A36UsuarioRecomendacaoSerieDataHo, T00092_A1SerieId, T00092_A33UsuarioRecomendacaoSerieOrigem, T00092_A34UsuarioRecomendacaoSerieDestin
               }
               , new Object[] {
               T00093_A32UsuarioRecomendacaoSerieId, T00093_A35UsuarioRecomendacaoSerieComent, T00093_A36UsuarioRecomendacaoSerieDataHo, T00093_A1SerieId, T00093_A33UsuarioRecomendacaoSerieOrigem, T00093_A34UsuarioRecomendacaoSerieDestin
               }
               , new Object[] {
               T00094_A1SerieId
               }
               , new Object[] {
               T00095_A33UsuarioRecomendacaoSerieOrigem
               }
               , new Object[] {
               T00096_A34UsuarioRecomendacaoSerieDestin
               }
               , new Object[] {
               T00097_A32UsuarioRecomendacaoSerieId, T00097_A35UsuarioRecomendacaoSerieComent, T00097_A36UsuarioRecomendacaoSerieDataHo, T00097_A1SerieId, T00097_A33UsuarioRecomendacaoSerieOrigem, T00097_A34UsuarioRecomendacaoSerieDestin
               }
               , new Object[] {
               T00098_A33UsuarioRecomendacaoSerieOrigem
               }
               , new Object[] {
               T00099_A34UsuarioRecomendacaoSerieDestin
               }
               , new Object[] {
               T000910_A1SerieId
               }
               , new Object[] {
               T000911_A32UsuarioRecomendacaoSerieId
               }
               , new Object[] {
               T000912_A32UsuarioRecomendacaoSerieId
               }
               , new Object[] {
               T000913_A32UsuarioRecomendacaoSerieId
               }
               , new Object[] {
               T000914_A32UsuarioRecomendacaoSerieId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000917_A32UsuarioRecomendacaoSerieId
               }
               , new Object[] {
               T000918_A33UsuarioRecomendacaoSerieOrigem
               }
               , new Object[] {
               T000919_A34UsuarioRecomendacaoSerieDestin
               }
               , new Object[] {
               T000920_A1SerieId
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
      private short RcdFound9 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUsuarioRecomendacaoSerieId_Enabled ;
      private int edtUsuarioRecomendacaoSerieOrigem_Enabled ;
      private int imgprompt_33_Visible ;
      private int edtUsuarioRecomendacaoSerieDestin_Enabled ;
      private int imgprompt_34_Visible ;
      private int edtUsuarioRecomendacaoSerieComent_Enabled ;
      private int edtUsuarioRecomendacaoSerieDataHo_Enabled ;
      private int edtSerieId_Enabled ;
      private int imgprompt_1_Visible ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z32UsuarioRecomendacaoSerieId ;
      private long Z1SerieId ;
      private long Z33UsuarioRecomendacaoSerieOrigem ;
      private long Z34UsuarioRecomendacaoSerieDestin ;
      private long A33UsuarioRecomendacaoSerieOrigem ;
      private long A34UsuarioRecomendacaoSerieDestin ;
      private long A1SerieId ;
      private long A32UsuarioRecomendacaoSerieId ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUsuarioRecomendacaoSerieId_Internalname ;
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
      private String edtUsuarioRecomendacaoSerieId_Jsonclick ;
      private String edtUsuarioRecomendacaoSerieOrigem_Internalname ;
      private String edtUsuarioRecomendacaoSerieOrigem_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_33_Internalname ;
      private String imgprompt_33_Link ;
      private String edtUsuarioRecomendacaoSerieDestin_Internalname ;
      private String edtUsuarioRecomendacaoSerieDestin_Jsonclick ;
      private String imgprompt_34_Internalname ;
      private String imgprompt_34_Link ;
      private String edtUsuarioRecomendacaoSerieComent_Internalname ;
      private String edtUsuarioRecomendacaoSerieDataHo_Internalname ;
      private String edtUsuarioRecomendacaoSerieDataHo_Jsonclick ;
      private String edtSerieId_Internalname ;
      private String edtSerieId_Jsonclick ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
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
      private String sMode9 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z36UsuarioRecomendacaoSerieDataHo ;
      private DateTime A36UsuarioRecomendacaoSerieDataHo ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private String Z35UsuarioRecomendacaoSerieComent ;
      private String A35UsuarioRecomendacaoSerieComent ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T00097_A32UsuarioRecomendacaoSerieId ;
      private String[] T00097_A35UsuarioRecomendacaoSerieComent ;
      private DateTime[] T00097_A36UsuarioRecomendacaoSerieDataHo ;
      private long[] T00097_A1SerieId ;
      private long[] T00097_A33UsuarioRecomendacaoSerieOrigem ;
      private long[] T00097_A34UsuarioRecomendacaoSerieDestin ;
      private long[] T00095_A33UsuarioRecomendacaoSerieOrigem ;
      private long[] T00096_A34UsuarioRecomendacaoSerieDestin ;
      private long[] T00094_A1SerieId ;
      private long[] T00098_A33UsuarioRecomendacaoSerieOrigem ;
      private long[] T00099_A34UsuarioRecomendacaoSerieDestin ;
      private long[] T000910_A1SerieId ;
      private long[] T000911_A32UsuarioRecomendacaoSerieId ;
      private long[] T00093_A32UsuarioRecomendacaoSerieId ;
      private String[] T00093_A35UsuarioRecomendacaoSerieComent ;
      private DateTime[] T00093_A36UsuarioRecomendacaoSerieDataHo ;
      private long[] T00093_A1SerieId ;
      private long[] T00093_A33UsuarioRecomendacaoSerieOrigem ;
      private long[] T00093_A34UsuarioRecomendacaoSerieDestin ;
      private long[] T000912_A32UsuarioRecomendacaoSerieId ;
      private long[] T000913_A32UsuarioRecomendacaoSerieId ;
      private long[] T00092_A32UsuarioRecomendacaoSerieId ;
      private String[] T00092_A35UsuarioRecomendacaoSerieComent ;
      private DateTime[] T00092_A36UsuarioRecomendacaoSerieDataHo ;
      private long[] T00092_A1SerieId ;
      private long[] T00092_A33UsuarioRecomendacaoSerieOrigem ;
      private long[] T00092_A34UsuarioRecomendacaoSerieDestin ;
      private long[] T000914_A32UsuarioRecomendacaoSerieId ;
      private IDataStoreProvider pr_gam ;
      private long[] T000917_A32UsuarioRecomendacaoSerieId ;
      private long[] T000918_A33UsuarioRecomendacaoSerieOrigem ;
      private long[] T000919_A34UsuarioRecomendacaoSerieDestin ;
      private long[] T000920_A1SerieId ;
      private GXWebForm Form ;
   }

   public class usuariorecomendacaoserie__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class usuariorecomendacaoserie__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT00097 ;
        prmT00097 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00095 ;
        prmT00095 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieOrigem",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00096 ;
        prmT00096 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieDestin",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00094 ;
        prmT00094 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00098 ;
        prmT00098 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieOrigem",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00099 ;
        prmT00099 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieDestin",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000910 ;
        prmT000910 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000911 ;
        prmT000911 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00093 ;
        prmT00093 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000912 ;
        prmT000912 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000913 ;
        prmT000913 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00092 ;
        prmT00092 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000914 ;
        prmT000914 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieComent",SqlDbType.VarChar,300,0} ,
        new Object[] {"@UsuarioRecomendacaoSerieDataHo",SqlDbType.DateTime,8,5} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioRecomendacaoSerieOrigem",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioRecomendacaoSerieDestin",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000915 ;
        prmT000915 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieComent",SqlDbType.VarChar,300,0} ,
        new Object[] {"@UsuarioRecomendacaoSerieDataHo",SqlDbType.DateTime,8,5} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioRecomendacaoSerieOrigem",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioRecomendacaoSerieDestin",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioRecomendacaoSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000916 ;
        prmT000916 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000917 ;
        prmT000917 = new Object[] {
        } ;
        Object[] prmT000918 ;
        prmT000918 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieOrigem",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000919 ;
        prmT000919 = new Object[] {
        new Object[] {"@UsuarioRecomendacaoSerieDestin",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000920 ;
        prmT000920 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00092", "SELECT [UsuarioRecomendacaoSerieId], [UsuarioRecomendacaoSerieComent], [UsuarioRecomendacaoSerieDataHo], [SerieId], [UsuarioRecomendacaoSerieOrigem] AS UsuarioRecomendacaoSerieOrigem, [UsuarioRecomendacaoSerieDestin] AS UsuarioRecomendacaoSerieDestin FROM [UsuarioRecomendacaoSerie] WITH (UPDLOCK) WHERE [UsuarioRecomendacaoSerieId] = @UsuarioRecomendacaoSerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00092,1,0,true,false )
           ,new CursorDef("T00093", "SELECT [UsuarioRecomendacaoSerieId], [UsuarioRecomendacaoSerieComent], [UsuarioRecomendacaoSerieDataHo], [SerieId], [UsuarioRecomendacaoSerieOrigem] AS UsuarioRecomendacaoSerieOrigem, [UsuarioRecomendacaoSerieDestin] AS UsuarioRecomendacaoSerieDestin FROM [UsuarioRecomendacaoSerie] WITH (NOLOCK) WHERE [UsuarioRecomendacaoSerieId] = @UsuarioRecomendacaoSerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00093,1,0,true,false )
           ,new CursorDef("T00094", "SELECT [SerieId] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00094,1,0,true,false )
           ,new CursorDef("T00095", "SELECT [UsuarioId] AS UsuarioRecomendacaoSerieOrigem FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioRecomendacaoSerieOrigem ",true, GxErrorMask.GX_NOMASK, false, this,prmT00095,1,0,true,false )
           ,new CursorDef("T00096", "SELECT [UsuarioId] AS UsuarioRecomendacaoSerieDestin FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioRecomendacaoSerieDestin ",true, GxErrorMask.GX_NOMASK, false, this,prmT00096,1,0,true,false )
           ,new CursorDef("T00097", "SELECT TM1.[UsuarioRecomendacaoSerieId], TM1.[UsuarioRecomendacaoSerieComent], TM1.[UsuarioRecomendacaoSerieDataHo], TM1.[SerieId], TM1.[UsuarioRecomendacaoSerieOrigem] AS UsuarioRecomendacaoSerieOrigem, TM1.[UsuarioRecomendacaoSerieDestin] AS UsuarioRecomendacaoSerieDestin FROM [UsuarioRecomendacaoSerie] TM1 WITH (NOLOCK) WHERE TM1.[UsuarioRecomendacaoSerieId] = @UsuarioRecomendacaoSerieId ORDER BY TM1.[UsuarioRecomendacaoSerieId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00097,100,0,true,false )
           ,new CursorDef("T00098", "SELECT [UsuarioId] AS UsuarioRecomendacaoSerieOrigem FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioRecomendacaoSerieOrigem ",true, GxErrorMask.GX_NOMASK, false, this,prmT00098,1,0,true,false )
           ,new CursorDef("T00099", "SELECT [UsuarioId] AS UsuarioRecomendacaoSerieDestin FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioRecomendacaoSerieDestin ",true, GxErrorMask.GX_NOMASK, false, this,prmT00099,1,0,true,false )
           ,new CursorDef("T000910", "SELECT [SerieId] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000910,1,0,true,false )
           ,new CursorDef("T000911", "SELECT [UsuarioRecomendacaoSerieId] FROM [UsuarioRecomendacaoSerie] WITH (NOLOCK) WHERE [UsuarioRecomendacaoSerieId] = @UsuarioRecomendacaoSerieId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000911,1,0,true,false )
           ,new CursorDef("T000912", "SELECT TOP 1 [UsuarioRecomendacaoSerieId] FROM [UsuarioRecomendacaoSerie] WITH (NOLOCK) WHERE ( [UsuarioRecomendacaoSerieId] > @UsuarioRecomendacaoSerieId) ORDER BY [UsuarioRecomendacaoSerieId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000912,1,0,true,true )
           ,new CursorDef("T000913", "SELECT TOP 1 [UsuarioRecomendacaoSerieId] FROM [UsuarioRecomendacaoSerie] WITH (NOLOCK) WHERE ( [UsuarioRecomendacaoSerieId] < @UsuarioRecomendacaoSerieId) ORDER BY [UsuarioRecomendacaoSerieId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000913,1,0,true,true )
           ,new CursorDef("T000914", "INSERT INTO [UsuarioRecomendacaoSerie]([UsuarioRecomendacaoSerieComent], [UsuarioRecomendacaoSerieDataHo], [SerieId], [UsuarioRecomendacaoSerieOrigem], [UsuarioRecomendacaoSerieDestin]) VALUES(@UsuarioRecomendacaoSerieComent, @UsuarioRecomendacaoSerieDataHo, @SerieId, @UsuarioRecomendacaoSerieOrigem, @UsuarioRecomendacaoSerieDestin); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000914)
           ,new CursorDef("T000915", "UPDATE [UsuarioRecomendacaoSerie] SET [UsuarioRecomendacaoSerieComent]=@UsuarioRecomendacaoSerieComent, [UsuarioRecomendacaoSerieDataHo]=@UsuarioRecomendacaoSerieDataHo, [SerieId]=@SerieId, [UsuarioRecomendacaoSerieOrigem]=@UsuarioRecomendacaoSerieOrigem, [UsuarioRecomendacaoSerieDestin]=@UsuarioRecomendacaoSerieDestin  WHERE [UsuarioRecomendacaoSerieId] = @UsuarioRecomendacaoSerieId", GxErrorMask.GX_NOMASK,prmT000915)
           ,new CursorDef("T000916", "DELETE FROM [UsuarioRecomendacaoSerie]  WHERE [UsuarioRecomendacaoSerieId] = @UsuarioRecomendacaoSerieId", GxErrorMask.GX_NOMASK,prmT000916)
           ,new CursorDef("T000917", "SELECT [UsuarioRecomendacaoSerieId] FROM [UsuarioRecomendacaoSerie] WITH (NOLOCK) ORDER BY [UsuarioRecomendacaoSerieId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000917,100,0,true,false )
           ,new CursorDef("T000918", "SELECT [UsuarioId] AS UsuarioRecomendacaoSerieOrigem FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioRecomendacaoSerieOrigem ",true, GxErrorMask.GX_NOMASK, false, this,prmT000918,1,0,true,false )
           ,new CursorDef("T000919", "SELECT [UsuarioId] AS UsuarioRecomendacaoSerieDestin FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioRecomendacaoSerieDestin ",true, GxErrorMask.GX_NOMASK, false, this,prmT000919,1,0,true,false )
           ,new CursorDef("T000920", "SELECT [SerieId] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000920,1,0,true,false )
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
