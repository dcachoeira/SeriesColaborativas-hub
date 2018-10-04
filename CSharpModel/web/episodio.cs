/*
               File: Episodio
        Description: Episódio
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:24.65
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
   public class episodio : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_14") == 0 )
         {
            A1SerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_14( A1SerieId) ;
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
               AV7EpisodioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EpisodioId), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEPISODIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EpisodioId), "ZZZZZZZZZZZZZZZZZ9"), context));
               AV15EpisodioTemporada = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15EpisodioTemporada", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15EpisodioTemporada), 4, 0)));
               AV16SerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16SerieId), 18, 0)));
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
         chkEpisodioInativo.Name = "EPISODIOINATIVO";
         chkEpisodioInativo.WebTags = "";
         chkEpisodioInativo.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkEpisodioInativo_Internalname, "TitleCaption", chkEpisodioInativo.Caption, true);
         chkEpisodioInativo.CheckedValue = "false";
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
            Form.Meta.addItem("description", "Episódio", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtEpisodioNome_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public episodio( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public episodio( IGxContext context )
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
                           long aP1_EpisodioId ,
                           ref short aP2_EpisodioTemporada ,
                           ref long aP3_SerieId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EpisodioId = aP1_EpisodioId;
         this.AV15EpisodioTemporada = aP2_EpisodioTemporada;
         this.AV16SerieId = aP3_SerieId;
         executePrivate();
         aP2_EpisodioTemporada=this.AV15EpisodioTemporada;
         aP3_SerieId=this.AV16SerieId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkEpisodioInativo = new GXCheckbox();
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-9", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEpisodioNome_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEpisodioNome_Internalname, "Nome", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEpisodioNome_Internalname, A8EpisodioNome, StringUtil.RTrim( context.localUtil.Format( A8EpisodioNome, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEpisodioNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEpisodioNome_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Nome", "left", true, "HLP_Episodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEpisodioNumero_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEpisodioNumero_Internalname, "Número do episódio", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEpisodioNumero_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A58EpisodioNumero), 3, 0, ",", "")), ((edtEpisodioNumero_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A58EpisodioNumero), "ZZ9")) : context.localUtil.Format( (decimal)(A58EpisodioNumero), "ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEpisodioNumero_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEpisodioNumero_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "Numero", "right", false, "HLP_Episodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEpisodioDuracao_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEpisodioDuracao_Internalname, "Duração", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEpisodioDuracao_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A9EpisodioDuracao), 3, 0, ",", "")), ((edtEpisodioDuracao_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A9EpisodioDuracao), "ZZZ")) : context.localUtil.Format( (decimal)(A9EpisodioDuracao), "ZZZ")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Minutos", edtEpisodioDuracao_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEpisodioDuracao_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "Duracao", "right", false, "HLP_Episodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEpisodioSinopse_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEpisodioSinopse_Internalname, "Sinopse", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtEpisodioSinopse_Internalname, A10EpisodioSinopse, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,40);\"", 0, 1, edtEpisodioSinopse_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2097152", -1, 0, "", "", -1, true, "Resumo", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Episodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkEpisodioInativo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkEpisodioInativo_Internalname, "Inativo", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkEpisodioInativo_Internalname, StringUtil.BoolToStr( A51EpisodioInativo), "", "Inativo", 1, chkEpisodioInativo.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(45, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,45);\"");
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
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "Fechar", bttBtntrn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Episodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "Eliminar", bttBtntrn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Episodio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "Confirmar", bttBtntrn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Episodio.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEpisodioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EpisodioId), 18, 0, ",", "")), ((edtEpisodioId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEpisodioId_Jsonclick, 0, "Attribute", "", "", "", "", edtEpisodioId_Visible, edtEpisodioId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Episodio.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSerieId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSerieId_Jsonclick, 0, "Attribute", "", "", "", "", edtSerieId_Visible, edtSerieId_Enabled, 1, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Episodio.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Episodio.htm");
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
         E11022 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A8EpisodioNome = cgiGet( edtEpisodioNome_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8EpisodioNome", A8EpisodioNome);
               if ( ( ( context.localUtil.CToN( cgiGet( edtEpisodioNumero_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEpisodioNumero_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EPISODIONUMERO");
                  AnyError = 1;
                  GX_FocusControl = edtEpisodioNumero_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A58EpisodioNumero = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58EpisodioNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A58EpisodioNumero), 3, 0)));
               }
               else
               {
                  A58EpisodioNumero = (short)(context.localUtil.CToN( cgiGet( edtEpisodioNumero_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58EpisodioNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A58EpisodioNumero), 3, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtEpisodioDuracao_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEpisodioDuracao_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EPISODIODURACAO");
                  AnyError = 1;
                  GX_FocusControl = edtEpisodioDuracao_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A9EpisodioDuracao = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9EpisodioDuracao", StringUtil.LTrim( StringUtil.Str( (decimal)(A9EpisodioDuracao), 3, 0)));
               }
               else
               {
                  A9EpisodioDuracao = (short)(context.localUtil.CToN( cgiGet( edtEpisodioDuracao_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9EpisodioDuracao", StringUtil.LTrim( StringUtil.Str( (decimal)(A9EpisodioDuracao), 3, 0)));
               }
               A10EpisodioSinopse = cgiGet( edtEpisodioSinopse_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10EpisodioSinopse", A10EpisodioSinopse);
               A51EpisodioInativo = StringUtil.StrToBool( cgiGet( chkEpisodioInativo_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51EpisodioInativo", A51EpisodioInativo);
               A7EpisodioId = (long)(context.localUtil.CToN( cgiGet( edtEpisodioId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
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
               Z7EpisodioId = (long)(context.localUtil.CToN( cgiGet( "Z7EpisodioId"), ",", "."));
               Z42EpisodioTemporada = (short)(context.localUtil.CToN( cgiGet( "Z42EpisodioTemporada"), ",", "."));
               Z8EpisodioNome = cgiGet( "Z8EpisodioNome");
               Z9EpisodioDuracao = (short)(context.localUtil.CToN( cgiGet( "Z9EpisodioDuracao"), ",", "."));
               Z51EpisodioInativo = StringUtil.StrToBool( cgiGet( "Z51EpisodioInativo"));
               Z58EpisodioNumero = (short)(context.localUtil.CToN( cgiGet( "Z58EpisodioNumero"), ",", "."));
               Z1SerieId = (long)(context.localUtil.CToN( cgiGet( "Z1SerieId"), ",", "."));
               A42EpisodioTemporada = (short)(context.localUtil.CToN( cgiGet( "Z42EpisodioTemporada"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               N1SerieId = (long)(context.localUtil.CToN( cgiGet( "N1SerieId"), ",", "."));
               AV7EpisodioId = (long)(context.localUtil.CToN( cgiGet( "vEPISODIOID"), ",", "."));
               AV13Insert_SerieId = (long)(context.localUtil.CToN( cgiGet( "vINSERT_SERIEID"), ",", "."));
               AV16SerieId = (long)(context.localUtil.CToN( cgiGet( "vSERIEID"), ",", "."));
               AV15EpisodioTemporada = (short)(context.localUtil.CToN( cgiGet( "vEPISODIOTEMPORADA"), ",", "."));
               A42EpisodioTemporada = (short)(context.localUtil.CToN( cgiGet( "EPISODIOTEMPORADA"), ",", "."));
               A2SerieNome = cgiGet( "SERIENOME");
               AV17Pgmname = cgiGet( "vPGMNAME");
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
               forbiddenHiddens = "hsh" + "Episodio";
               A7EpisodioId = (long)(context.localUtil.CToN( cgiGet( edtEpisodioId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A42EpisodioTemporada), "ZZZ9");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A7EpisodioId != Z7EpisodioId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("episodio:[SecurityCheckFailed value for]"+"EpisodioId:"+context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9"));
                  GXUtil.WriteLog("episodio:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("episodio:[SecurityCheckFailed value for]"+"EpisodioTemporada:"+context.localUtil.Format( (decimal)(A42EpisodioTemporada), "ZZZ9"));
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
                  A7EpisodioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
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
                     sMode2 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode2;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound2 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_020( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "EPISODIOID");
                        AnyError = 1;
                        GX_FocusControl = edtEpisodioId_Internalname;
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
                           E11022 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12022 ();
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
            E12022 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll022( ) ;
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
            DisableAttributes022( ) ;
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

      protected void CONFIRM_020( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls022( ) ;
            }
            else
            {
               CheckExtendedTable022( ) ;
               CloseExtendedTableCursors022( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption020( )
      {
      }

      protected void E11022( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "SeriesColaborativas");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            while ( AV18GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "SerieId") == 0 )
               {
                  AV13Insert_SerieId = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_SerieId), 18, 0)));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            }
         }
         edtEpisodioId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEpisodioId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEpisodioId_Visible), 5, 0)), true);
         edtSerieId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieId_Visible), 5, 0)), true);
         edtEpisodioId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEpisodioId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEpisodioId_Visible), 5, 0)), true);
         edtSerieId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieId_Visible), 5, 0)), true);
      }

      protected void E12022( )
      {
         /* After Trn Routine */
         context.setWebReturnParms(new Object[] {(short)AV15EpisodioTemporada,(long)AV16SerieId});
         context.setWebReturnParmsMetadata(new Object[] {"AV15EpisodioTemporada","AV16SerieId"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         pr_default.close(1);
         pr_default.close(2);
         returnInSub = true;
         if (true) return;
      }

      protected void ZM022( short GX_JID )
      {
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z42EpisodioTemporada = T00023_A42EpisodioTemporada[0];
               Z8EpisodioNome = T00023_A8EpisodioNome[0];
               Z9EpisodioDuracao = T00023_A9EpisodioDuracao[0];
               Z51EpisodioInativo = T00023_A51EpisodioInativo[0];
               Z58EpisodioNumero = T00023_A58EpisodioNumero[0];
               Z1SerieId = T00023_A1SerieId[0];
            }
            else
            {
               Z42EpisodioTemporada = A42EpisodioTemporada;
               Z8EpisodioNome = A8EpisodioNome;
               Z9EpisodioDuracao = A9EpisodioDuracao;
               Z51EpisodioInativo = A51EpisodioInativo;
               Z58EpisodioNumero = A58EpisodioNumero;
               Z1SerieId = A1SerieId;
            }
         }
         if ( GX_JID == -13 )
         {
            Z7EpisodioId = A7EpisodioId;
            Z42EpisodioTemporada = A42EpisodioTemporada;
            Z8EpisodioNome = A8EpisodioNome;
            Z9EpisodioDuracao = A9EpisodioDuracao;
            Z10EpisodioSinopse = A10EpisodioSinopse;
            Z51EpisodioInativo = A51EpisodioInativo;
            Z58EpisodioNumero = A58EpisodioNumero;
            Z1SerieId = A1SerieId;
            Z2SerieNome = A2SerieNome;
         }
      }

      protected void standaloneNotModal( )
      {
         edtEpisodioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEpisodioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEpisodioId_Enabled), 5, 0)), true);
         AV17Pgmname = "Episodio";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"SERIEID"+"'), id:'"+"SERIEID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtEpisodioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEpisodioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEpisodioId_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7EpisodioId) )
         {
            A7EpisodioId = AV7EpisodioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_SerieId) )
         {
            edtSerieId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieId_Enabled), 5, 0)), true);
         }
         else
         {
            edtSerieId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_SerieId) )
         {
            A1SerieId = AV13Insert_SerieId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A1SerieId = AV16SerieId;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A42EpisodioTemporada = AV15EpisodioTemporada;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42EpisodioTemporada", StringUtil.LTrim( StringUtil.Str( (decimal)(A42EpisodioTemporada), 4, 0)));
         }
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T00024 */
            pr_default.execute(2, new Object[] {A1SerieId});
            A2SerieNome = T00024_A2SerieNome[0];
            pr_default.close(2);
         }
      }

      protected void Load022( )
      {
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound2 = 1;
            A42EpisodioTemporada = T00025_A42EpisodioTemporada[0];
            A2SerieNome = T00025_A2SerieNome[0];
            A8EpisodioNome = T00025_A8EpisodioNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8EpisodioNome", A8EpisodioNome);
            A9EpisodioDuracao = T00025_A9EpisodioDuracao[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9EpisodioDuracao", StringUtil.LTrim( StringUtil.Str( (decimal)(A9EpisodioDuracao), 3, 0)));
            A10EpisodioSinopse = T00025_A10EpisodioSinopse[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10EpisodioSinopse", A10EpisodioSinopse);
            A51EpisodioInativo = T00025_A51EpisodioInativo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51EpisodioInativo", A51EpisodioInativo);
            A58EpisodioNumero = T00025_A58EpisodioNumero[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58EpisodioNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A58EpisodioNumero), 3, 0)));
            A1SerieId = T00025_A1SerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
            ZM022( -13) ;
         }
         pr_default.close(3);
         OnLoadActions022( ) ;
      }

      protected void OnLoadActions022( )
      {
      }

      protected void CheckExtendedTable022( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00024 */
         pr_default.execute(2, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Série'.", "ForeignKeyNotFound", 1, "SERIEID");
            AnyError = 1;
            GX_FocusControl = edtSerieId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A2SerieNome = T00024_A2SerieNome[0];
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A8EpisodioNome)) )
         {
            GX_msglist.addItem("Nome é obrigatório.", 1, "EPISODIONOME");
            AnyError = 1;
            GX_FocusControl = edtEpisodioNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (0==A9EpisodioDuracao) )
         {
            GX_msglist.addItem("Duração é obrigatório.", 1, "EPISODIODURACAO");
            AnyError = 1;
            GX_FocusControl = edtEpisodioDuracao_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A10EpisodioSinopse)) )
         {
            GX_msglist.addItem("Sinopse é obrigatório.", 1, "EPISODIOSINOPSE");
            AnyError = 1;
            GX_FocusControl = edtEpisodioSinopse_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (0==A58EpisodioNumero) )
         {
            GX_msglist.addItem("Número do episódio é obrigatório.", 1, "EPISODIONUMERO");
            AnyError = 1;
            GX_FocusControl = edtEpisodioNumero_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors022( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_14( long A1SerieId )
      {
         /* Using cursor T00026 */
         pr_default.execute(4, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("Não existe 'Série'.", "ForeignKeyNotFound", 1, "SERIEID");
            AnyError = 1;
            GX_FocusControl = edtSerieId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A2SerieNome = T00026_A2SerieNome[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A2SerieNome)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey022( )
      {
         /* Using cursor T00027 */
         pr_default.execute(5, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM022( 13) ;
            RcdFound2 = 1;
            A7EpisodioId = T00023_A7EpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
            A42EpisodioTemporada = T00023_A42EpisodioTemporada[0];
            A8EpisodioNome = T00023_A8EpisodioNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8EpisodioNome", A8EpisodioNome);
            A9EpisodioDuracao = T00023_A9EpisodioDuracao[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9EpisodioDuracao", StringUtil.LTrim( StringUtil.Str( (decimal)(A9EpisodioDuracao), 3, 0)));
            A10EpisodioSinopse = T00023_A10EpisodioSinopse[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10EpisodioSinopse", A10EpisodioSinopse);
            A51EpisodioInativo = T00023_A51EpisodioInativo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51EpisodioInativo", A51EpisodioInativo);
            A58EpisodioNumero = T00023_A58EpisodioNumero[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58EpisodioNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A58EpisodioNumero), 3, 0)));
            A1SerieId = T00023_A1SerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
            Z7EpisodioId = A7EpisodioId;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load022( ) ;
            if ( AnyError == 1 )
            {
               RcdFound2 = 0;
               InitializeNonKey022( ) ;
            }
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey022( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey022( ) ;
         if ( RcdFound2 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound2 = 0;
         /* Using cursor T00028 */
         pr_default.execute(6, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00028_A7EpisodioId[0] < A7EpisodioId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00028_A7EpisodioId[0] > A7EpisodioId ) ) )
            {
               A7EpisodioId = T00028_A7EpisodioId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
               RcdFound2 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound2 = 0;
         /* Using cursor T00029 */
         pr_default.execute(7, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00029_A7EpisodioId[0] > A7EpisodioId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00029_A7EpisodioId[0] < A7EpisodioId ) ) )
            {
               A7EpisodioId = T00029_A7EpisodioId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
               RcdFound2 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey022( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEpisodioNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert022( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound2 == 1 )
            {
               if ( A7EpisodioId != Z7EpisodioId )
               {
                  A7EpisodioId = Z7EpisodioId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EPISODIOID");
                  AnyError = 1;
                  GX_FocusControl = edtEpisodioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtEpisodioNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update022( ) ;
                  GX_FocusControl = edtEpisodioNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A7EpisodioId != Z7EpisodioId )
               {
                  /* Insert record */
                  GX_FocusControl = edtEpisodioNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert022( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "EPISODIOID");
                     AnyError = 1;
                     GX_FocusControl = edtEpisodioId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtEpisodioNome_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert022( ) ;
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
         if ( A7EpisodioId != Z7EpisodioId )
         {
            A7EpisodioId = Z7EpisodioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EPISODIOID");
            AnyError = 1;
            GX_FocusControl = edtEpisodioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEpisodioNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency022( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00022 */
            pr_default.execute(0, new Object[] {A7EpisodioId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Episodio"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z42EpisodioTemporada != T00022_A42EpisodioTemporada[0] ) || ( StringUtil.StrCmp(Z8EpisodioNome, T00022_A8EpisodioNome[0]) != 0 ) || ( Z9EpisodioDuracao != T00022_A9EpisodioDuracao[0] ) || ( Z51EpisodioInativo != T00022_A51EpisodioInativo[0] ) || ( Z58EpisodioNumero != T00022_A58EpisodioNumero[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z1SerieId != T00022_A1SerieId[0] ) )
            {
               if ( Z42EpisodioTemporada != T00022_A42EpisodioTemporada[0] )
               {
                  GXUtil.WriteLog("episodio:[seudo value changed for attri]"+"EpisodioTemporada");
                  GXUtil.WriteLogRaw("Old: ",Z42EpisodioTemporada);
                  GXUtil.WriteLogRaw("Current: ",T00022_A42EpisodioTemporada[0]);
               }
               if ( StringUtil.StrCmp(Z8EpisodioNome, T00022_A8EpisodioNome[0]) != 0 )
               {
                  GXUtil.WriteLog("episodio:[seudo value changed for attri]"+"EpisodioNome");
                  GXUtil.WriteLogRaw("Old: ",Z8EpisodioNome);
                  GXUtil.WriteLogRaw("Current: ",T00022_A8EpisodioNome[0]);
               }
               if ( Z9EpisodioDuracao != T00022_A9EpisodioDuracao[0] )
               {
                  GXUtil.WriteLog("episodio:[seudo value changed for attri]"+"EpisodioDuracao");
                  GXUtil.WriteLogRaw("Old: ",Z9EpisodioDuracao);
                  GXUtil.WriteLogRaw("Current: ",T00022_A9EpisodioDuracao[0]);
               }
               if ( Z51EpisodioInativo != T00022_A51EpisodioInativo[0] )
               {
                  GXUtil.WriteLog("episodio:[seudo value changed for attri]"+"EpisodioInativo");
                  GXUtil.WriteLogRaw("Old: ",Z51EpisodioInativo);
                  GXUtil.WriteLogRaw("Current: ",T00022_A51EpisodioInativo[0]);
               }
               if ( Z58EpisodioNumero != T00022_A58EpisodioNumero[0] )
               {
                  GXUtil.WriteLog("episodio:[seudo value changed for attri]"+"EpisodioNumero");
                  GXUtil.WriteLogRaw("Old: ",Z58EpisodioNumero);
                  GXUtil.WriteLogRaw("Current: ",T00022_A58EpisodioNumero[0]);
               }
               if ( Z1SerieId != T00022_A1SerieId[0] )
               {
                  GXUtil.WriteLog("episodio:[seudo value changed for attri]"+"SerieId");
                  GXUtil.WriteLogRaw("Old: ",Z1SerieId);
                  GXUtil.WriteLogRaw("Current: ",T00022_A1SerieId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Episodio"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM022( 0) ;
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000210 */
                     pr_default.execute(8, new Object[] {A42EpisodioTemporada, A8EpisodioNome, A9EpisodioDuracao, A10EpisodioSinopse, A51EpisodioInativo, A58EpisodioNumero, A1SerieId});
                     A7EpisodioId = T000210_A7EpisodioId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Episodio") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption020( ) ;
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
               Load022( ) ;
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void Update022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000211 */
                     pr_default.execute(9, new Object[] {A42EpisodioTemporada, A8EpisodioNome, A9EpisodioDuracao, A10EpisodioSinopse, A51EpisodioInativo, A58EpisodioNumero, A1SerieId, A7EpisodioId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Episodio") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Episodio"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate022( ) ;
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
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void DeferredUpdate022( )
      {
      }

      protected void delete( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls022( ) ;
            AfterConfirm022( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete022( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000212 */
                  pr_default.execute(10, new Object[] {A7EpisodioId});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("Episodio") ;
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
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel022( ) ;
         Gx_mode = sMode2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls022( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000213 */
            pr_default.execute(11, new Object[] {A1SerieId});
            A2SerieNome = T000213_A2SerieNome[0];
            pr_default.close(11);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000214 */
            pr_default.execute(12, new Object[] {A7EpisodioId});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário recomendação episódios"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
            /* Using cursor T000215 */
            pr_default.execute(13, new Object[] {A7EpisodioId});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário episódio"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel022( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete022( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(11);
            pr_gam.commit( "Episodio");
            pr_default.commit( "Episodio");
            if ( AnyError == 0 )
            {
               ConfirmValues020( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(11);
            pr_gam.rollback( "Episodio");
            pr_default.rollback( "Episodio");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart022( )
      {
         /* Scan By routine */
         /* Using cursor T000216 */
         pr_default.execute(14);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound2 = 1;
            A7EpisodioId = T000216_A7EpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext022( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound2 = 1;
            A7EpisodioId = T000216_A7EpisodioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
         }
      }

      protected void ScanEnd022( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm022( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert022( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate022( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete022( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete022( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate022( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes022( )
      {
         edtEpisodioNome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEpisodioNome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEpisodioNome_Enabled), 5, 0)), true);
         edtEpisodioNumero_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEpisodioNumero_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEpisodioNumero_Enabled), 5, 0)), true);
         edtEpisodioDuracao_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEpisodioDuracao_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEpisodioDuracao_Enabled), 5, 0)), true);
         edtEpisodioSinopse_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEpisodioSinopse_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEpisodioSinopse_Enabled), 5, 0)), true);
         chkEpisodioInativo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkEpisodioInativo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkEpisodioInativo.Enabled), 5, 0)), true);
         edtEpisodioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEpisodioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEpisodioId_Enabled), 5, 0)), true);
         edtSerieId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieId_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes022( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues020( )
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
         context.AddJavascriptSource("gxcfg.js", "?20189251962658", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("episodio.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EpisodioId) + "," + UrlEncode("" +AV15EpisodioTemporada) + "," + UrlEncode("" +AV16SerieId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Episodio";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A42EpisodioTemporada), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("episodio:[SendSecurityCheck value for]"+"EpisodioId:"+context.localUtil.Format( (decimal)(A7EpisodioId), "ZZZZZZZZZZZZZZZZZ9"));
         GXUtil.WriteLog("episodio:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("episodio:[SendSecurityCheck value for]"+"EpisodioTemporada:"+context.localUtil.Format( (decimal)(A42EpisodioTemporada), "ZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z7EpisodioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7EpisodioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z42EpisodioTemporada", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42EpisodioTemporada), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z8EpisodioNome", Z8EpisodioNome);
         GxWebStd.gx_hidden_field( context, "Z9EpisodioDuracao", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z9EpisodioDuracao), 3, 0, ",", "")));
         GxWebStd.gx_boolean_hidden_field( context, "Z51EpisodioInativo", Z51EpisodioInativo);
         GxWebStd.gx_hidden_field( context, "Z58EpisodioNumero", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z58EpisodioNumero), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z1SerieId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1SerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N1SerieId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vEPISODIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EpisodioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEPISODIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EpisodioId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_SERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_SerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16SerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vEPISODIOTEMPORADA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15EpisodioTemporada), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "EPISODIOTEMPORADA", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42EpisodioTemporada), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "SERIENOME", A2SerieNome);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV17Pgmname));
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
         return formatLink("episodio.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EpisodioId) + "," + UrlEncode("" +AV15EpisodioTemporada) + "," + UrlEncode("" +AV16SerieId) ;
      }

      public override String GetPgmname( )
      {
         return "Episodio" ;
      }

      public override String GetPgmdesc( )
      {
         return "Episódio" ;
      }

      protected void InitializeNonKey022( )
      {
         A1SerieId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
         A42EpisodioTemporada = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42EpisodioTemporada", StringUtil.LTrim( StringUtil.Str( (decimal)(A42EpisodioTemporada), 4, 0)));
         A2SerieNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SerieNome", A2SerieNome);
         A8EpisodioNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8EpisodioNome", A8EpisodioNome);
         A9EpisodioDuracao = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9EpisodioDuracao", StringUtil.LTrim( StringUtil.Str( (decimal)(A9EpisodioDuracao), 3, 0)));
         A10EpisodioSinopse = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10EpisodioSinopse", A10EpisodioSinopse);
         A51EpisodioInativo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51EpisodioInativo", A51EpisodioInativo);
         A58EpisodioNumero = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58EpisodioNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A58EpisodioNumero), 3, 0)));
         Z42EpisodioTemporada = 0;
         Z8EpisodioNome = "";
         Z9EpisodioDuracao = 0;
         Z51EpisodioInativo = false;
         Z58EpisodioNumero = 0;
         Z1SerieId = 0;
      }

      protected void InitAll022( )
      {
         A7EpisodioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)));
         InitializeNonKey022( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A1SerieId = i1SerieId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
         A42EpisodioTemporada = i42EpisodioTemporada;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42EpisodioTemporada", StringUtil.LTrim( StringUtil.Str( (decimal)(A42EpisodioTemporada), 4, 0)));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20189251962689", true);
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
         context.AddJavascriptSource("episodio.js", "?20189251962690", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtEpisodioNome_Internalname = "EPISODIONOME";
         edtEpisodioNumero_Internalname = "EPISODIONUMERO";
         edtEpisodioDuracao_Internalname = "EPISODIODURACAO";
         edtEpisodioSinopse_Internalname = "EPISODIOSINOPSE";
         chkEpisodioInativo_Internalname = "EPISODIOINATIVO";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         divTablemain_Internalname = "TABLEMAIN";
         edtEpisodioId_Internalname = "EPISODIOID";
         edtSerieId_Internalname = "SERIEID";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
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
         Form.Caption = "Episódio";
         imgprompt_1_Link = "";
         edtSerieId_Jsonclick = "";
         edtSerieId_Enabled = 1;
         edtSerieId_Visible = 1;
         edtEpisodioId_Jsonclick = "";
         edtEpisodioId_Enabled = 0;
         edtEpisodioId_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         chkEpisodioInativo.Enabled = 1;
         edtEpisodioSinopse_Enabled = 1;
         edtEpisodioDuracao_Jsonclick = "";
         edtEpisodioDuracao_Enabled = 1;
         edtEpisodioNumero_Jsonclick = "";
         edtEpisodioNumero_Enabled = 1;
         edtEpisodioNome_Jsonclick = "";
         edtEpisodioNome_Enabled = 1;
         chkEpisodioInativo.Caption = "Inativo";
         imgprompt_1_Visible = 1;
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

      public void Valid_Serieid( long GX_Parm1 ,
                                 String GX_Parm2 )
      {
         A1SerieId = GX_Parm1;
         A2SerieNome = GX_Parm2;
         /* Using cursor T000213 */
         pr_default.execute(11, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("Não existe 'Série'.", "ForeignKeyNotFound", 1, "SERIEID");
            AnyError = 1;
            GX_FocusControl = edtSerieId_Internalname;
         }
         A2SerieNome = T000213_A2SerieNome[0];
         pr_default.close(11);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A2SerieNome = "";
         }
         isValidOutput.Add(A2SerieNome);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7EpisodioId',fld:'vEPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0},{av:'AV15EpisodioTemporada',fld:'vEPISODIOTEMPORADA',pic:'ZZZ9',nv:0},{av:'AV16SerieId',fld:'vSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7EpisodioId',fld:'vEPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0},{av:'A7EpisodioId',fld:'EPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'A42EpisodioTemporada',fld:'EPISODIOTEMPORADA',pic:'ZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12022',iparms:[],oparms:[]}");
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
         pr_default.close(11);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z8EpisodioNome = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         A8EpisodioNome = "";
         A10EpisodioSinopse = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         bttBtntrn_enter_Jsonclick = "";
         sImgUrl = "";
         A2SerieNome = "";
         AV17Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode2 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z10EpisodioSinopse = "";
         Z2SerieNome = "";
         T00024_A2SerieNome = new String[] {""} ;
         T00025_A7EpisodioId = new long[1] ;
         T00025_A42EpisodioTemporada = new short[1] ;
         T00025_A2SerieNome = new String[] {""} ;
         T00025_A8EpisodioNome = new String[] {""} ;
         T00025_A9EpisodioDuracao = new short[1] ;
         T00025_A10EpisodioSinopse = new String[] {""} ;
         T00025_A51EpisodioInativo = new bool[] {false} ;
         T00025_A58EpisodioNumero = new short[1] ;
         T00025_A1SerieId = new long[1] ;
         T00026_A2SerieNome = new String[] {""} ;
         T00027_A7EpisodioId = new long[1] ;
         T00023_A7EpisodioId = new long[1] ;
         T00023_A42EpisodioTemporada = new short[1] ;
         T00023_A8EpisodioNome = new String[] {""} ;
         T00023_A9EpisodioDuracao = new short[1] ;
         T00023_A10EpisodioSinopse = new String[] {""} ;
         T00023_A51EpisodioInativo = new bool[] {false} ;
         T00023_A58EpisodioNumero = new short[1] ;
         T00023_A1SerieId = new long[1] ;
         T00028_A7EpisodioId = new long[1] ;
         T00029_A7EpisodioId = new long[1] ;
         T00022_A7EpisodioId = new long[1] ;
         T00022_A42EpisodioTemporada = new short[1] ;
         T00022_A8EpisodioNome = new String[] {""} ;
         T00022_A9EpisodioDuracao = new short[1] ;
         T00022_A10EpisodioSinopse = new String[] {""} ;
         T00022_A51EpisodioInativo = new bool[] {false} ;
         T00022_A58EpisodioNumero = new short[1] ;
         T00022_A1SerieId = new long[1] ;
         T000210_A7EpisodioId = new long[1] ;
         T000213_A2SerieNome = new String[] {""} ;
         T000214_A37UsuarioRecomendacaoEpisodioId = new long[1] ;
         T000215_A18UsuarioEpisodioId = new long[1] ;
         T000216_A7EpisodioId = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.episodio__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.episodio__default(),
            new Object[][] {
                new Object[] {
               T00022_A7EpisodioId, T00022_A42EpisodioTemporada, T00022_A8EpisodioNome, T00022_A9EpisodioDuracao, T00022_A10EpisodioSinopse, T00022_A51EpisodioInativo, T00022_A58EpisodioNumero, T00022_A1SerieId
               }
               , new Object[] {
               T00023_A7EpisodioId, T00023_A42EpisodioTemporada, T00023_A8EpisodioNome, T00023_A9EpisodioDuracao, T00023_A10EpisodioSinopse, T00023_A51EpisodioInativo, T00023_A58EpisodioNumero, T00023_A1SerieId
               }
               , new Object[] {
               T00024_A2SerieNome
               }
               , new Object[] {
               T00025_A7EpisodioId, T00025_A42EpisodioTemporada, T00025_A2SerieNome, T00025_A8EpisodioNome, T00025_A9EpisodioDuracao, T00025_A10EpisodioSinopse, T00025_A51EpisodioInativo, T00025_A58EpisodioNumero, T00025_A1SerieId
               }
               , new Object[] {
               T00026_A2SerieNome
               }
               , new Object[] {
               T00027_A7EpisodioId
               }
               , new Object[] {
               T00028_A7EpisodioId
               }
               , new Object[] {
               T00029_A7EpisodioId
               }
               , new Object[] {
               T000210_A7EpisodioId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000213_A2SerieNome
               }
               , new Object[] {
               T000214_A37UsuarioRecomendacaoEpisodioId
               }
               , new Object[] {
               T000215_A18UsuarioEpisodioId
               }
               , new Object[] {
               T000216_A7EpisodioId
               }
            }
         );
         AV17Pgmname = "Episodio";
      }

      private short wcpOAV15EpisodioTemporada ;
      private short Z42EpisodioTemporada ;
      private short Z9EpisodioDuracao ;
      private short Z58EpisodioNumero ;
      private short GxWebError ;
      private short AV15EpisodioTemporada ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A58EpisodioNumero ;
      private short A9EpisodioDuracao ;
      private short A42EpisodioTemporada ;
      private short RcdFound2 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short i42EpisodioTemporada ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtEpisodioNome_Enabled ;
      private int edtEpisodioNumero_Enabled ;
      private int edtEpisodioDuracao_Enabled ;
      private int edtEpisodioSinopse_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int edtEpisodioId_Enabled ;
      private int edtEpisodioId_Visible ;
      private int edtSerieId_Visible ;
      private int edtSerieId_Enabled ;
      private int imgprompt_1_Visible ;
      private int AV18GXV1 ;
      private int idxLst ;
      private long wcpOAV7EpisodioId ;
      private long wcpOAV16SerieId ;
      private long Z7EpisodioId ;
      private long Z1SerieId ;
      private long N1SerieId ;
      private long A1SerieId ;
      private long AV7EpisodioId ;
      private long AV16SerieId ;
      private long A7EpisodioId ;
      private long AV13Insert_SerieId ;
      private long i1SerieId ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String chkEpisodioInativo_Internalname ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEpisodioNome_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String TempTags ;
      private String edtEpisodioNome_Jsonclick ;
      private String edtEpisodioNumero_Internalname ;
      private String edtEpisodioNumero_Jsonclick ;
      private String edtEpisodioDuracao_Internalname ;
      private String edtEpisodioDuracao_Jsonclick ;
      private String edtEpisodioSinopse_Internalname ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtEpisodioId_Internalname ;
      private String edtEpisodioId_Jsonclick ;
      private String edtSerieId_Internalname ;
      private String edtSerieId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String AV17Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Height ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode2 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_tableattributes_Internalname ;
      private bool Z51EpisodioInativo ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A51EpisodioInativo ;
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
      private String A10EpisodioSinopse ;
      private String Z10EpisodioSinopse ;
      private String Z8EpisodioNome ;
      private String A8EpisodioNome ;
      private String A2SerieNome ;
      private String Z2SerieNome ;
      private IGxSession AV12WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private short aP2_EpisodioTemporada ;
      private long aP3_SerieId ;
      private GXCheckbox chkEpisodioInativo ;
      private IDataStoreProvider pr_default ;
      private String[] T00024_A2SerieNome ;
      private long[] T00025_A7EpisodioId ;
      private short[] T00025_A42EpisodioTemporada ;
      private String[] T00025_A2SerieNome ;
      private String[] T00025_A8EpisodioNome ;
      private short[] T00025_A9EpisodioDuracao ;
      private String[] T00025_A10EpisodioSinopse ;
      private bool[] T00025_A51EpisodioInativo ;
      private short[] T00025_A58EpisodioNumero ;
      private long[] T00025_A1SerieId ;
      private String[] T00026_A2SerieNome ;
      private long[] T00027_A7EpisodioId ;
      private long[] T00023_A7EpisodioId ;
      private short[] T00023_A42EpisodioTemporada ;
      private String[] T00023_A8EpisodioNome ;
      private short[] T00023_A9EpisodioDuracao ;
      private String[] T00023_A10EpisodioSinopse ;
      private bool[] T00023_A51EpisodioInativo ;
      private short[] T00023_A58EpisodioNumero ;
      private long[] T00023_A1SerieId ;
      private long[] T00028_A7EpisodioId ;
      private long[] T00029_A7EpisodioId ;
      private long[] T00022_A7EpisodioId ;
      private short[] T00022_A42EpisodioTemporada ;
      private String[] T00022_A8EpisodioNome ;
      private short[] T00022_A9EpisodioDuracao ;
      private String[] T00022_A10EpisodioSinopse ;
      private bool[] T00022_A51EpisodioInativo ;
      private short[] T00022_A58EpisodioNumero ;
      private long[] T00022_A1SerieId ;
      private long[] T000210_A7EpisodioId ;
      private String[] T000213_A2SerieNome ;
      private long[] T000214_A37UsuarioRecomendacaoEpisodioId ;
      private long[] T000215_A18UsuarioEpisodioId ;
      private IDataStoreProvider pr_gam ;
      private long[] T000216_A7EpisodioId ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class episodio__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class episodio__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00025 ;
        prmT00025 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00024 ;
        prmT00024 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00026 ;
        prmT00026 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00027 ;
        prmT00027 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00023 ;
        prmT00023 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00028 ;
        prmT00028 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00029 ;
        prmT00029 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00022 ;
        prmT00022 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000210 ;
        prmT000210 = new Object[] {
        new Object[] {"@EpisodioTemporada",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@EpisodioNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@EpisodioDuracao",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@EpisodioSinopse",SqlDbType.VarChar,2097152,0} ,
        new Object[] {"@EpisodioInativo",SqlDbType.Bit,4,0} ,
        new Object[] {"@EpisodioNumero",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000211 ;
        prmT000211 = new Object[] {
        new Object[] {"@EpisodioTemporada",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@EpisodioNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@EpisodioDuracao",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@EpisodioSinopse",SqlDbType.VarChar,2097152,0} ,
        new Object[] {"@EpisodioInativo",SqlDbType.Bit,4,0} ,
        new Object[] {"@EpisodioNumero",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000212 ;
        prmT000212 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000214 ;
        prmT000214 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000215 ;
        prmT000215 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000216 ;
        prmT000216 = new Object[] {
        } ;
        Object[] prmT000213 ;
        prmT000213 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00022", "SELECT [EpisodioId], [EpisodioTemporada], [EpisodioNome], [EpisodioDuracao], [EpisodioSinopse], [EpisodioInativo], [EpisodioNumero], [SerieId] FROM [Episodio] WITH (UPDLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1,0,true,false )
           ,new CursorDef("T00023", "SELECT [EpisodioId], [EpisodioTemporada], [EpisodioNome], [EpisodioDuracao], [EpisodioSinopse], [EpisodioInativo], [EpisodioNumero], [SerieId] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1,0,true,false )
           ,new CursorDef("T00024", "SELECT [SerieNome] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,1,0,true,false )
           ,new CursorDef("T00025", "SELECT TM1.[EpisodioId], TM1.[EpisodioTemporada], T2.[SerieNome], TM1.[EpisodioNome], TM1.[EpisodioDuracao], TM1.[EpisodioSinopse], TM1.[EpisodioInativo], TM1.[EpisodioNumero], TM1.[SerieId] FROM ([Episodio] TM1 WITH (NOLOCK) INNER JOIN [Serie] T2 WITH (NOLOCK) ON T2.[SerieId] = TM1.[SerieId]) WHERE TM1.[EpisodioId] = @EpisodioId ORDER BY TM1.[EpisodioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,100,0,true,false )
           ,new CursorDef("T00026", "SELECT [SerieNome] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,1,0,true,false )
           ,new CursorDef("T00027", "SELECT [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1,0,true,false )
           ,new CursorDef("T00028", "SELECT TOP 1 [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE ( [EpisodioId] > @EpisodioId) ORDER BY [EpisodioId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00028,1,0,true,true )
           ,new CursorDef("T00029", "SELECT TOP 1 [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE ( [EpisodioId] < @EpisodioId) ORDER BY [EpisodioId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00029,1,0,true,true )
           ,new CursorDef("T000210", "INSERT INTO [Episodio]([EpisodioTemporada], [EpisodioNome], [EpisodioDuracao], [EpisodioSinopse], [EpisodioInativo], [EpisodioNumero], [SerieId]) VALUES(@EpisodioTemporada, @EpisodioNome, @EpisodioDuracao, @EpisodioSinopse, @EpisodioInativo, @EpisodioNumero, @SerieId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000210)
           ,new CursorDef("T000211", "UPDATE [Episodio] SET [EpisodioTemporada]=@EpisodioTemporada, [EpisodioNome]=@EpisodioNome, [EpisodioDuracao]=@EpisodioDuracao, [EpisodioSinopse]=@EpisodioSinopse, [EpisodioInativo]=@EpisodioInativo, [EpisodioNumero]=@EpisodioNumero, [SerieId]=@SerieId  WHERE [EpisodioId] = @EpisodioId", GxErrorMask.GX_NOMASK,prmT000211)
           ,new CursorDef("T000212", "DELETE FROM [Episodio]  WHERE [EpisodioId] = @EpisodioId", GxErrorMask.GX_NOMASK,prmT000212)
           ,new CursorDef("T000213", "SELECT [SerieNome] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000213,1,0,true,false )
           ,new CursorDef("T000214", "SELECT TOP 1 [UsuarioRecomendacaoEpisodioId] FROM [UsuarioRecomendacaoEpisodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000214,1,0,true,true )
           ,new CursorDef("T000215", "SELECT TOP 1 [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000215,1,0,true,true )
           ,new CursorDef("T000216", "SELECT [EpisodioId] FROM [Episodio] WITH (NOLOCK) ORDER BY [EpisodioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000216,100,0,true,false )
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
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getLongVarchar(5) ;
              ((bool[]) buf[5])[0] = rslt.getBool(6) ;
              ((short[]) buf[6])[0] = rslt.getShort(7) ;
              ((long[]) buf[7])[0] = rslt.getLong(8) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getLongVarchar(5) ;
              ((bool[]) buf[5])[0] = rslt.getBool(6) ;
              ((short[]) buf[6])[0] = rslt.getShort(7) ;
              ((long[]) buf[7])[0] = rslt.getLong(8) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              ((String[]) buf[5])[0] = rslt.getLongVarchar(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((short[]) buf[7])[0] = rslt.getShort(8) ;
              ((long[]) buf[8])[0] = rslt.getLong(9) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (bool)parms[4]);
              stmt.SetParameter(6, (short)parms[5]);
              stmt.SetParameter(7, (long)parms[6]);
              return;
           case 9 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (bool)parms[4]);
              stmt.SetParameter(6, (short)parms[5]);
              stmt.SetParameter(7, (long)parms[6]);
              stmt.SetParameter(8, (long)parms[7]);
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
     }
  }

}

}
