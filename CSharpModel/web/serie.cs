/*
               File: Serie
        Description: Série
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:8.53
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
   public class serie : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"GENEROID") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAGENEROID011( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_15") == 0 )
         {
            A48GeneroId = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_15( A48GeneroId) ;
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
               AV7SerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7SerieId), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSERIEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7SerieId), "ZZZZZZZZZZZZZZZZZ9"), context));
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
         dynGeneroId.Name = "GENEROID";
         dynGeneroId.WebTags = "";
         chkSerieInativo.Name = "SERIEINATIVO";
         chkSerieInativo.WebTags = "";
         chkSerieInativo.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkSerieInativo_Internalname, "TitleCaption", chkSerieInativo.Caption, true);
         chkSerieInativo.CheckedValue = "false";
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
            Form.Meta.addItem("description", "Série", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSerieNome_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public serie( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public serie( IGxContext context )
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
                           long aP1_SerieId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7SerieId = aP1_SerieId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynGeneroId = new GXCombobox();
         chkSerieInativo = new GXCheckbox();
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
            GXAGENEROID_html011( ) ;
         }
         if ( dynGeneroId.ItemCount > 0 )
         {
            A48GeneroId = (long)(NumberUtil.Val( dynGeneroId.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynGeneroId.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynGeneroId_Internalname, "Values", dynGeneroId.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSerieNome_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSerieNome_Internalname, "Nome", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSerieNome_Internalname, A2SerieNome, StringUtil.RTrim( context.localUtil.Format( A2SerieNome, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSerieNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSerieNome_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Nome", "left", true, "HLP_Serie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynGeneroId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynGeneroId_Internalname, "Gênero", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynGeneroId, dynGeneroId_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)), 1, dynGeneroId_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynGeneroId.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "", true, "HLP_Serie.htm");
            dynGeneroId.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynGeneroId_Internalname, "Values", (String)(dynGeneroId.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSerieQuantidadeTemporadas_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSerieQuantidadeTemporadas_Internalname, "Quantidade de temporadas", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSerieQuantidadeTemporadas_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3SerieQuantidadeTemporadas), 4, 0, ",", "")), ((edtSerieQuantidadeTemporadas_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A3SerieQuantidadeTemporadas), "ZZZ9")) : context.localUtil.Format( (decimal)(A3SerieQuantidadeTemporadas), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSerieQuantidadeTemporadas_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSerieQuantidadeTemporadas_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Quantidade", "right", false, "HLP_Serie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSerieResumo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSerieResumo_Internalname, "Resumo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtSerieResumo_Internalname, A6SerieResumo, "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,40);\"", 0, 1, edtSerieResumo_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2097152", -1, 0, "", "", -1, true, "Resumo", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Serie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgSerieImagem_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, imgSerieImagem_Internalname, "Imagem", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Static Bitmap Variable */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            A43SerieImagem_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000SerieImagem_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.PathToRelativeUrl( A43SerieImagem));
            GxWebStd.gx_bitmap( context, imgSerieImagem_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgSerieImagem_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,45);\"", "", "", "", 0, A43SerieImagem_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Serie.htm");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.PathToRelativeUrl( A43SerieImagem)), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "IsBlob", StringUtil.BoolToStr( A43SerieImagem_IsBlob), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkSerieInativo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkSerieInativo_Internalname, "Inativo", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkSerieInativo_Internalname, StringUtil.BoolToStr( A47SerieInativo), "", "Inativo", 1, chkSerieInativo.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(50, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,50);\"");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "Fechar", bttBtntrn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Serie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "Eliminar", bttBtntrn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Serie.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "Confirmar", bttBtntrn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Serie.htm");
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
            GxWebStd.gx_single_line_edit( context, edtSerieId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")), ((edtSerieId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSerieId_Jsonclick, 0, "Attribute", "", "", "", "", edtSerieId_Visible, edtSerieId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Serie.htm");
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
         E11012 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A2SerieNome = cgiGet( edtSerieNome_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SerieNome", A2SerieNome);
               dynGeneroId.CurrentValue = cgiGet( dynGeneroId_Internalname);
               A48GeneroId = (long)(NumberUtil.Val( cgiGet( dynGeneroId_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtSerieQuantidadeTemporadas_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSerieQuantidadeTemporadas_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SERIEQUANTIDADETEMPORADAS");
                  AnyError = 1;
                  GX_FocusControl = edtSerieQuantidadeTemporadas_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A3SerieQuantidadeTemporadas = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3SerieQuantidadeTemporadas", StringUtil.LTrim( StringUtil.Str( (decimal)(A3SerieQuantidadeTemporadas), 4, 0)));
               }
               else
               {
                  A3SerieQuantidadeTemporadas = (short)(context.localUtil.CToN( cgiGet( edtSerieQuantidadeTemporadas_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3SerieQuantidadeTemporadas", StringUtil.LTrim( StringUtil.Str( (decimal)(A3SerieQuantidadeTemporadas), 4, 0)));
               }
               A6SerieResumo = cgiGet( edtSerieResumo_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SerieResumo", A6SerieResumo);
               A43SerieImagem = cgiGet( imgSerieImagem_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43SerieImagem", A43SerieImagem);
               A47SerieInativo = StringUtil.StrToBool( cgiGet( chkSerieInativo_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47SerieInativo", A47SerieInativo);
               A1SerieId = (long)(context.localUtil.CToN( cgiGet( edtSerieId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
               /* Read saved values. */
               Z1SerieId = (long)(context.localUtil.CToN( cgiGet( "Z1SerieId"), ",", "."));
               Z60SerieDataHoraCadastro = context.localUtil.CToT( cgiGet( "Z60SerieDataHoraCadastro"), 0);
               Z2SerieNome = cgiGet( "Z2SerieNome");
               Z3SerieQuantidadeTemporadas = (short)(context.localUtil.CToN( cgiGet( "Z3SerieQuantidadeTemporadas"), ",", "."));
               Z47SerieInativo = StringUtil.StrToBool( cgiGet( "Z47SerieInativo"));
               Z48GeneroId = (long)(context.localUtil.CToN( cgiGet( "Z48GeneroId"), ",", "."));
               A60SerieDataHoraCadastro = context.localUtil.CToT( cgiGet( "Z60SerieDataHoraCadastro"), 0);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               N48GeneroId = (long)(context.localUtil.CToN( cgiGet( "N48GeneroId"), ",", "."));
               AV7SerieId = (long)(context.localUtil.CToN( cgiGet( "vSERIEID"), ",", "."));
               AV13Insert_GeneroId = (long)(context.localUtil.CToN( cgiGet( "vINSERT_GENEROID"), ",", "."));
               A60SerieDataHoraCadastro = context.localUtil.CToT( cgiGet( "SERIEDATAHORACADASTRO"), 0);
               A40000SerieImagem_GXI = cgiGet( "SERIEIMAGEM_GXI");
               A49GeneroNome = cgiGet( "GENERONOME");
               AV15Pgmname = cgiGet( "vPGMNAME");
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
               getMultimediaValue(imgSerieImagem_Internalname, ref  A43SerieImagem, ref  A40000SerieImagem_GXI);
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Serie";
               A1SerieId = (long)(context.localUtil.CToN( cgiGet( edtSerieId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A60SerieDataHoraCadastro, "99/99/99 99:99");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1SerieId != Z1SerieId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("serie:[SecurityCheckFailed value for]"+"SerieId:"+context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9"));
                  GXUtil.WriteLog("serie:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("serie:[SecurityCheckFailed value for]"+"SerieDataHoraCadastro:"+context.localUtil.Format( A60SerieDataHoraCadastro, "99/99/99 99:99"));
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
                  A1SerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
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
                     sMode1 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode1;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound1 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_010( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "SERIEID");
                        AnyError = 1;
                        GX_FocusControl = edtSerieId_Internalname;
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
                           E11012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12012 ();
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
            E12012 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll011( ) ;
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
            DisableAttributes011( ) ;
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

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption010( )
      {
      }

      protected void E11012( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "SeriesColaborativas");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV15Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV16GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GXV1), 8, 0)));
            while ( AV16GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV16GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "GeneroId") == 0 )
               {
                  AV13Insert_GeneroId = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_GeneroId), 18, 0)));
               }
               AV16GXV1 = (int)(AV16GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GXV1), 8, 0)));
            }
         }
         edtSerieId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieId_Visible), 5, 0)), true);
      }

      protected void E12012( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("serieww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 14 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z60SerieDataHoraCadastro = T00013_A60SerieDataHoraCadastro[0];
               Z2SerieNome = T00013_A2SerieNome[0];
               Z3SerieQuantidadeTemporadas = T00013_A3SerieQuantidadeTemporadas[0];
               Z47SerieInativo = T00013_A47SerieInativo[0];
               Z48GeneroId = T00013_A48GeneroId[0];
            }
            else
            {
               Z60SerieDataHoraCadastro = A60SerieDataHoraCadastro;
               Z2SerieNome = A2SerieNome;
               Z3SerieQuantidadeTemporadas = A3SerieQuantidadeTemporadas;
               Z47SerieInativo = A47SerieInativo;
               Z48GeneroId = A48GeneroId;
            }
         }
         if ( GX_JID == -14 )
         {
            Z1SerieId = A1SerieId;
            Z60SerieDataHoraCadastro = A60SerieDataHoraCadastro;
            Z2SerieNome = A2SerieNome;
            Z3SerieQuantidadeTemporadas = A3SerieQuantidadeTemporadas;
            Z6SerieResumo = A6SerieResumo;
            Z43SerieImagem = A43SerieImagem;
            Z40000SerieImagem_GXI = A40000SerieImagem_GXI;
            Z47SerieInativo = A47SerieInativo;
            Z48GeneroId = A48GeneroId;
            Z49GeneroNome = A49GeneroNome;
         }
      }

      protected void standaloneNotModal( )
      {
         GXAGENEROID_html011( ) ;
         edtSerieId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieId_Enabled), 5, 0)), true);
         AV15Pgmname = "Serie";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         edtSerieId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieId_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7SerieId) )
         {
            A1SerieId = AV7SerieId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_GeneroId) )
         {
            dynGeneroId.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynGeneroId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynGeneroId.Enabled), 5, 0)), true);
         }
         else
         {
            dynGeneroId.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynGeneroId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynGeneroId.Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A60SerieDataHoraCadastro = DateTimeUtil.Now( context);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60SerieDataHoraCadastro", context.localUtil.TToC( A60SerieDataHoraCadastro, 8, 5, 0, 3, "/", ":", " "));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_GeneroId) )
         {
            A48GeneroId = AV13Insert_GeneroId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
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
            /* Using cursor T00014 */
            pr_default.execute(2, new Object[] {A48GeneroId});
            A49GeneroNome = T00014_A49GeneroNome[0];
            pr_default.close(2);
         }
      }

      protected void Load011( )
      {
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound1 = 1;
            A60SerieDataHoraCadastro = T00015_A60SerieDataHoraCadastro[0];
            A2SerieNome = T00015_A2SerieNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SerieNome", A2SerieNome);
            A3SerieQuantidadeTemporadas = T00015_A3SerieQuantidadeTemporadas[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3SerieQuantidadeTemporadas", StringUtil.LTrim( StringUtil.Str( (decimal)(A3SerieQuantidadeTemporadas), 4, 0)));
            A49GeneroNome = T00015_A49GeneroNome[0];
            A6SerieResumo = T00015_A6SerieResumo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SerieResumo", A6SerieResumo);
            A40000SerieImagem_GXI = T00015_A40000SerieImagem_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
            A47SerieInativo = T00015_A47SerieInativo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47SerieInativo", A47SerieInativo);
            A48GeneroId = T00015_A48GeneroId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
            A43SerieImagem = T00015_A43SerieImagem[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43SerieImagem", A43SerieImagem);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
            ZM011( -14) ;
         }
         pr_default.close(3);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A2SerieNome)) )
         {
            GX_msglist.addItem("Nome é obrigatório.", 1, "SERIENOME");
            AnyError = 1;
            GX_FocusControl = edtSerieNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (0==A3SerieQuantidadeTemporadas) )
         {
            GX_msglist.addItem("Quantidade de temporadas é obrigatório.", 1, "SERIEQUANTIDADETEMPORADAS");
            AnyError = 1;
            GX_FocusControl = edtSerieQuantidadeTemporadas_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00014 */
         pr_default.execute(2, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Gênero'.", "ForeignKeyNotFound", 1, "GENEROID");
            AnyError = 1;
            GX_FocusControl = dynGeneroId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A49GeneroNome = T00014_A49GeneroNome[0];
         pr_default.close(2);
         if ( (0==A48GeneroId) )
         {
            GX_msglist.addItem("Gênero é obrigatório.", 1, "GENEROID");
            AnyError = 1;
            GX_FocusControl = dynGeneroId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A6SerieResumo)) )
         {
            GX_msglist.addItem("Resumo é obrigatório.", 1, "SERIERESUMO");
            AnyError = 1;
            GX_FocusControl = edtSerieResumo_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors011( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_15( long A48GeneroId )
      {
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("Não existe 'Gênero'.", "ForeignKeyNotFound", 1, "GENEROID");
            AnyError = 1;
            GX_FocusControl = dynGeneroId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A49GeneroNome = T00016_A49GeneroNome[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A49GeneroNome)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey011( )
      {
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM011( 14) ;
            RcdFound1 = 1;
            A1SerieId = T00013_A1SerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
            A60SerieDataHoraCadastro = T00013_A60SerieDataHoraCadastro[0];
            A2SerieNome = T00013_A2SerieNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SerieNome", A2SerieNome);
            A3SerieQuantidadeTemporadas = T00013_A3SerieQuantidadeTemporadas[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3SerieQuantidadeTemporadas", StringUtil.LTrim( StringUtil.Str( (decimal)(A3SerieQuantidadeTemporadas), 4, 0)));
            A6SerieResumo = T00013_A6SerieResumo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SerieResumo", A6SerieResumo);
            A40000SerieImagem_GXI = T00013_A40000SerieImagem_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
            A47SerieInativo = T00013_A47SerieInativo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47SerieInativo", A47SerieInativo);
            A48GeneroId = T00013_A48GeneroId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
            A43SerieImagem = T00013_A43SerieImagem[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43SerieImagem", A43SerieImagem);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
            Z1SerieId = A1SerieId;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0;
         /* Using cursor T00018 */
         pr_default.execute(6, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00018_A1SerieId[0] < A1SerieId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00018_A1SerieId[0] > A1SerieId ) ) )
            {
               A1SerieId = T00018_A1SerieId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
               RcdFound1 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0;
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00019_A1SerieId[0] > A1SerieId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00019_A1SerieId[0] < A1SerieId ) ) )
            {
               A1SerieId = T00019_A1SerieId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
               RcdFound1 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtSerieNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert011( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A1SerieId != Z1SerieId )
               {
                  A1SerieId = Z1SerieId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "SERIEID");
                  AnyError = 1;
                  GX_FocusControl = edtSerieId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtSerieNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update011( ) ;
                  GX_FocusControl = edtSerieNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A1SerieId != Z1SerieId )
               {
                  /* Insert record */
                  GX_FocusControl = edtSerieNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert011( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "SERIEID");
                     AnyError = 1;
                     GX_FocusControl = edtSerieId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtSerieNome_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert011( ) ;
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
         if ( A1SerieId != Z1SerieId )
         {
            A1SerieId = Z1SerieId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "SERIEID");
            AnyError = 1;
            GX_FocusControl = edtSerieId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSerieNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {A1SerieId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Serie"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z60SerieDataHoraCadastro != T00012_A60SerieDataHoraCadastro[0] ) || ( StringUtil.StrCmp(Z2SerieNome, T00012_A2SerieNome[0]) != 0 ) || ( Z3SerieQuantidadeTemporadas != T00012_A3SerieQuantidadeTemporadas[0] ) || ( Z47SerieInativo != T00012_A47SerieInativo[0] ) || ( Z48GeneroId != T00012_A48GeneroId[0] ) )
            {
               if ( Z60SerieDataHoraCadastro != T00012_A60SerieDataHoraCadastro[0] )
               {
                  GXUtil.WriteLog("serie:[seudo value changed for attri]"+"SerieDataHoraCadastro");
                  GXUtil.WriteLogRaw("Old: ",Z60SerieDataHoraCadastro);
                  GXUtil.WriteLogRaw("Current: ",T00012_A60SerieDataHoraCadastro[0]);
               }
               if ( StringUtil.StrCmp(Z2SerieNome, T00012_A2SerieNome[0]) != 0 )
               {
                  GXUtil.WriteLog("serie:[seudo value changed for attri]"+"SerieNome");
                  GXUtil.WriteLogRaw("Old: ",Z2SerieNome);
                  GXUtil.WriteLogRaw("Current: ",T00012_A2SerieNome[0]);
               }
               if ( Z3SerieQuantidadeTemporadas != T00012_A3SerieQuantidadeTemporadas[0] )
               {
                  GXUtil.WriteLog("serie:[seudo value changed for attri]"+"SerieQuantidadeTemporadas");
                  GXUtil.WriteLogRaw("Old: ",Z3SerieQuantidadeTemporadas);
                  GXUtil.WriteLogRaw("Current: ",T00012_A3SerieQuantidadeTemporadas[0]);
               }
               if ( Z47SerieInativo != T00012_A47SerieInativo[0] )
               {
                  GXUtil.WriteLog("serie:[seudo value changed for attri]"+"SerieInativo");
                  GXUtil.WriteLogRaw("Old: ",Z47SerieInativo);
                  GXUtil.WriteLogRaw("Current: ",T00012_A47SerieInativo[0]);
               }
               if ( Z48GeneroId != T00012_A48GeneroId[0] )
               {
                  GXUtil.WriteLog("serie:[seudo value changed for attri]"+"GeneroId");
                  GXUtil.WriteLogRaw("Old: ",Z48GeneroId);
                  GXUtil.WriteLogRaw("Current: ",T00012_A48GeneroId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Serie"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000110 */
                     pr_default.execute(8, new Object[] {A60SerieDataHoraCadastro, A2SerieNome, A3SerieQuantidadeTemporadas, A6SerieResumo, A43SerieImagem, A40000SerieImagem_GXI, A47SerieInativo, A48GeneroId});
                     A1SerieId = T000110_A1SerieId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Serie") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption010( ) ;
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
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000111 */
                     pr_default.execute(9, new Object[] {A60SerieDataHoraCadastro, A2SerieNome, A3SerieQuantidadeTemporadas, A6SerieResumo, A47SerieInativo, A48GeneroId, A1SerieId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Serie") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Serie"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
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
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000112 */
            pr_default.execute(10, new Object[] {A43SerieImagem, A40000SerieImagem_GXI, A1SerieId});
            pr_default.close(10);
            dsDefault.SmartCacheProvider.SetUpdated("Serie") ;
         }
      }

      protected void delete( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000113 */
                  pr_default.execute(11, new Object[] {A1SerieId});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("Serie") ;
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
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel011( ) ;
         Gx_mode = sMode1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000114 */
            pr_default.execute(12, new Object[] {A48GeneroId});
            A49GeneroNome = T000114_A49GeneroNome[0];
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000115 */
            pr_default.execute(13, new Object[] {A1SerieId});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário recomendação série"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
            /* Using cursor T000116 */
            pr_default.execute(14, new Object[] {A1SerieId});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário série"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(14);
            /* Using cursor T000117 */
            pr_default.execute(15, new Object[] {A1SerieId});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Episódio"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
         }
      }

      protected void EndLevel011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(12);
            pr_gam.commit( "Serie");
            pr_default.commit( "Serie");
            if ( AnyError == 0 )
            {
               ConfirmValues010( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(12);
            pr_gam.rollback( "Serie");
            pr_default.rollback( "Serie");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart011( )
      {
         /* Scan By routine */
         /* Using cursor T000118 */
         pr_default.execute(16);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound1 = 1;
            A1SerieId = T000118_A1SerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(16);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound1 = 1;
            A1SerieId = T000118_A1SerieId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(16);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
         edtSerieNome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieNome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieNome_Enabled), 5, 0)), true);
         dynGeneroId.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynGeneroId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynGeneroId.Enabled), 5, 0)), true);
         edtSerieQuantidadeTemporadas_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieQuantidadeTemporadas_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieQuantidadeTemporadas_Enabled), 5, 0)), true);
         edtSerieResumo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieResumo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieResumo_Enabled), 5, 0)), true);
         imgSerieImagem_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgSerieImagem_Enabled), 5, 0)), true);
         chkSerieInativo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkSerieInativo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkSerieInativo.Enabled), 5, 0)), true);
         edtSerieId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSerieId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSerieId_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues010( )
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
         context.AddJavascriptSource("gxcfg.js", "?20189251961080", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("serie.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7SerieId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Serie";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A60SerieDataHoraCadastro, "99/99/99 99:99");
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("serie:[SendSecurityCheck value for]"+"SerieId:"+context.localUtil.Format( (decimal)(A1SerieId), "ZZZZZZZZZZZZZZZZZ9"));
         GXUtil.WriteLog("serie:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("serie:[SendSecurityCheck value for]"+"SerieDataHoraCadastro:"+context.localUtil.Format( A60SerieDataHoraCadastro, "99/99/99 99:99"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1SerieId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1SerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z60SerieDataHoraCadastro", context.localUtil.TToC( Z60SerieDataHoraCadastro, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z2SerieNome", Z2SerieNome);
         GxWebStd.gx_hidden_field( context, "Z3SerieQuantidadeTemporadas", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3SerieQuantidadeTemporadas), 4, 0, ",", "")));
         GxWebStd.gx_boolean_hidden_field( context, "Z47SerieInativo", Z47SerieInativo);
         GxWebStd.gx_hidden_field( context, "Z48GeneroId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48GeneroId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N48GeneroId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A48GeneroId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7SerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSERIEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7SerieId), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_GENEROID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_GeneroId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "SERIEDATAHORACADASTRO", context.localUtil.TToC( A60SerieDataHoraCadastro, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "SERIEIMAGEM_GXI", A40000SerieImagem_GXI);
         GxWebStd.gx_hidden_field( context, "GENERONOME", A49GeneroNome);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV15Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXCCtlgxBlob = "SERIEIMAGEM" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A43SerieImagem);
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
         return formatLink("serie.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7SerieId) ;
      }

      public override String GetPgmname( )
      {
         return "Serie" ;
      }

      public override String GetPgmdesc( )
      {
         return "Série" ;
      }

      protected void InitializeNonKey011( )
      {
         A48GeneroId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
         A60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60SerieDataHoraCadastro", context.localUtil.TToC( A60SerieDataHoraCadastro, 8, 5, 0, 3, "/", ":", " "));
         A2SerieNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SerieNome", A2SerieNome);
         A3SerieQuantidadeTemporadas = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3SerieQuantidadeTemporadas", StringUtil.LTrim( StringUtil.Str( (decimal)(A3SerieQuantidadeTemporadas), 4, 0)));
         A49GeneroNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49GeneroNome", A49GeneroNome);
         A6SerieResumo = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SerieResumo", A6SerieResumo);
         A43SerieImagem = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43SerieImagem", A43SerieImagem);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
         A40000SerieImagem_GXI = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A43SerieImagem)) ? A40000SerieImagem_GXI : context.convertURL( context.PathToRelativeUrl( A43SerieImagem))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSerieImagem_Internalname, "SrcSet", context.GetImageSrcSet( A43SerieImagem), true);
         A47SerieInativo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47SerieInativo", A47SerieInativo);
         Z60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         Z2SerieNome = "";
         Z3SerieQuantidadeTemporadas = 0;
         Z47SerieInativo = false;
         Z48GeneroId = 0;
      }

      protected void InitAll011( )
      {
         A1SerieId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SerieId), 18, 0)));
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A60SerieDataHoraCadastro = i60SerieDataHoraCadastro;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60SerieDataHoraCadastro", context.localUtil.TToC( A60SerieDataHoraCadastro, 8, 5, 0, 3, "/", ":", " "));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20189251961113", true);
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
         context.AddJavascriptSource("serie.js", "?20189251961114", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtSerieNome_Internalname = "SERIENOME";
         dynGeneroId_Internalname = "GENEROID";
         edtSerieQuantidadeTemporadas_Internalname = "SERIEQUANTIDADETEMPORADAS";
         edtSerieResumo_Internalname = "SERIERESUMO";
         imgSerieImagem_Internalname = "SERIEIMAGEM";
         chkSerieInativo_Internalname = "SERIEINATIVO";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         divTablemain_Internalname = "TABLEMAIN";
         edtSerieId_Internalname = "SERIEID";
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
         Form.Caption = "Série";
         edtSerieId_Jsonclick = "";
         edtSerieId_Enabled = 0;
         edtSerieId_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         chkSerieInativo.Enabled = 1;
         imgSerieImagem_Enabled = 1;
         edtSerieResumo_Enabled = 1;
         edtSerieQuantidadeTemporadas_Jsonclick = "";
         edtSerieQuantidadeTemporadas_Enabled = 1;
         dynGeneroId_Jsonclick = "";
         dynGeneroId.Enabled = 1;
         edtSerieNome_Jsonclick = "";
         edtSerieNome_Enabled = 1;
         chkSerieInativo.Caption = "Inativo";
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

      protected void GXDLAGENEROID011( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAGENEROID_data011( ) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXAGENEROID_html011( )
      {
         long gxdynajaxvalue ;
         GXDLAGENEROID_data011( ) ;
         gxdynajaxindex = 1;
         dynGeneroId.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (long)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynGeneroId.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 18, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAGENEROID_data011( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Selecione");
         /* Using cursor T000119 */
         pr_default.execute(17);
         while ( (pr_default.getStatus(17) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000119_A48GeneroId[0]), 18, 0, ".", "")));
            gxdynajaxctrldescr.Add(T000119_A49GeneroNome[0]);
            pr_default.readNext(17);
         }
         pr_default.close(17);
      }

      protected String rest_GENEROID( GxStringCollection colParms )
      {
         String jsonString ;
         GXDLAGENEROID_data011( ) ;
         jsonString = GXUtil.StringCollectionsToJson( gxdynajaxctrlcodr, gxdynajaxctrldescr);
         /* End function rest_GENEROID */
         return jsonString ;
      }

      public void Valid_Generoid( GXCombobox dynGX_Parm1 ,
                                  String GX_Parm2 )
      {
         dynGeneroId = dynGX_Parm1;
         A48GeneroId = (long)(NumberUtil.Val( dynGeneroId.CurrentValue, "."));
         A49GeneroNome = GX_Parm2;
         /* Using cursor T000120 */
         pr_default.execute(18, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("Não existe 'Gênero'.", "ForeignKeyNotFound", 1, "GENEROID");
            AnyError = 1;
            GX_FocusControl = dynGeneroId_Internalname;
         }
         A49GeneroNome = T000120_A49GeneroNome[0];
         pr_default.close(18);
         if ( (0==A48GeneroId) )
         {
            GX_msglist.addItem("Gênero é obrigatório.", 1, "GENEROID");
            AnyError = 1;
            GX_FocusControl = dynGeneroId_Internalname;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A49GeneroNome = "";
         }
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7SerieId',fld:'vSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7SerieId',fld:'vSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0},{av:'A1SerieId',fld:'SERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'A60SerieDataHoraCadastro',fld:'SERIEDATAHORACADASTRO',pic:'99/99/99 99:99',nv:''}],oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12012',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:'',nv:null}],oparms:[]}");
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
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         Z2SerieNome = "";
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
         A2SerieNome = "";
         A6SerieResumo = "";
         A43SerieImagem = "";
         A40000SerieImagem_GXI = "";
         sImgUrl = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         bttBtntrn_enter_Jsonclick = "";
         A60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         A49GeneroNome = "";
         AV15Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode1 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z6SerieResumo = "";
         Z43SerieImagem = "";
         Z40000SerieImagem_GXI = "";
         Z49GeneroNome = "";
         T00014_A49GeneroNome = new String[] {""} ;
         T00015_A1SerieId = new long[1] ;
         T00015_A60SerieDataHoraCadastro = new DateTime[] {DateTime.MinValue} ;
         T00015_A2SerieNome = new String[] {""} ;
         T00015_A3SerieQuantidadeTemporadas = new short[1] ;
         T00015_A49GeneroNome = new String[] {""} ;
         T00015_A6SerieResumo = new String[] {""} ;
         T00015_A40000SerieImagem_GXI = new String[] {""} ;
         T00015_A47SerieInativo = new bool[] {false} ;
         T00015_A48GeneroId = new long[1] ;
         T00015_A43SerieImagem = new String[] {""} ;
         T00016_A49GeneroNome = new String[] {""} ;
         T00017_A1SerieId = new long[1] ;
         T00013_A1SerieId = new long[1] ;
         T00013_A60SerieDataHoraCadastro = new DateTime[] {DateTime.MinValue} ;
         T00013_A2SerieNome = new String[] {""} ;
         T00013_A3SerieQuantidadeTemporadas = new short[1] ;
         T00013_A6SerieResumo = new String[] {""} ;
         T00013_A40000SerieImagem_GXI = new String[] {""} ;
         T00013_A47SerieInativo = new bool[] {false} ;
         T00013_A48GeneroId = new long[1] ;
         T00013_A43SerieImagem = new String[] {""} ;
         T00018_A1SerieId = new long[1] ;
         T00019_A1SerieId = new long[1] ;
         T00012_A1SerieId = new long[1] ;
         T00012_A60SerieDataHoraCadastro = new DateTime[] {DateTime.MinValue} ;
         T00012_A2SerieNome = new String[] {""} ;
         T00012_A3SerieQuantidadeTemporadas = new short[1] ;
         T00012_A6SerieResumo = new String[] {""} ;
         T00012_A40000SerieImagem_GXI = new String[] {""} ;
         T00012_A47SerieInativo = new bool[] {false} ;
         T00012_A48GeneroId = new long[1] ;
         T00012_A43SerieImagem = new String[] {""} ;
         T000110_A1SerieId = new long[1] ;
         T000114_A49GeneroNome = new String[] {""} ;
         T000115_A32UsuarioRecomendacaoSerieId = new long[1] ;
         T000116_A13UsuarioSerieId = new long[1] ;
         T000117_A7EpisodioId = new long[1] ;
         T000118_A1SerieId = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         i60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         gxdynajaxctrlcodr = new GxStringCollection();
         gxdynajaxctrldescr = new GxStringCollection();
         gxwrpcisep = "";
         T000119_A48GeneroId = new long[1] ;
         T000119_A49GeneroNome = new String[] {""} ;
         T000119_A50GeneroInativo = new bool[] {false} ;
         T000120_A49GeneroNome = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.serie__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.serie__default(),
            new Object[][] {
                new Object[] {
               T00012_A1SerieId, T00012_A60SerieDataHoraCadastro, T00012_A2SerieNome, T00012_A3SerieQuantidadeTemporadas, T00012_A6SerieResumo, T00012_A40000SerieImagem_GXI, T00012_A47SerieInativo, T00012_A48GeneroId, T00012_A43SerieImagem
               }
               , new Object[] {
               T00013_A1SerieId, T00013_A60SerieDataHoraCadastro, T00013_A2SerieNome, T00013_A3SerieQuantidadeTemporadas, T00013_A6SerieResumo, T00013_A40000SerieImagem_GXI, T00013_A47SerieInativo, T00013_A48GeneroId, T00013_A43SerieImagem
               }
               , new Object[] {
               T00014_A49GeneroNome
               }
               , new Object[] {
               T00015_A1SerieId, T00015_A60SerieDataHoraCadastro, T00015_A2SerieNome, T00015_A3SerieQuantidadeTemporadas, T00015_A49GeneroNome, T00015_A6SerieResumo, T00015_A40000SerieImagem_GXI, T00015_A47SerieInativo, T00015_A48GeneroId, T00015_A43SerieImagem
               }
               , new Object[] {
               T00016_A49GeneroNome
               }
               , new Object[] {
               T00017_A1SerieId
               }
               , new Object[] {
               T00018_A1SerieId
               }
               , new Object[] {
               T00019_A1SerieId
               }
               , new Object[] {
               T000110_A1SerieId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000114_A49GeneroNome
               }
               , new Object[] {
               T000115_A32UsuarioRecomendacaoSerieId
               }
               , new Object[] {
               T000116_A13UsuarioSerieId
               }
               , new Object[] {
               T000117_A7EpisodioId
               }
               , new Object[] {
               T000118_A1SerieId
               }
               , new Object[] {
               T000119_A48GeneroId, T000119_A49GeneroNome, T000119_A50GeneroInativo
               }
               , new Object[] {
               T000120_A49GeneroNome
               }
            }
         );
         AV15Pgmname = "Serie";
      }

      private short Z3SerieQuantidadeTemporadas ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A3SerieQuantidadeTemporadas ;
      private short RcdFound1 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtSerieNome_Enabled ;
      private int edtSerieQuantidadeTemporadas_Enabled ;
      private int edtSerieResumo_Enabled ;
      private int imgSerieImagem_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int edtSerieId_Enabled ;
      private int edtSerieId_Visible ;
      private int AV16GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long wcpOAV7SerieId ;
      private long Z1SerieId ;
      private long Z48GeneroId ;
      private long N48GeneroId ;
      private long A48GeneroId ;
      private long AV7SerieId ;
      private long A1SerieId ;
      private long AV13Insert_GeneroId ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String chkSerieInativo_Internalname ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtSerieNome_Internalname ;
      private String dynGeneroId_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String TempTags ;
      private String edtSerieNome_Jsonclick ;
      private String dynGeneroId_Jsonclick ;
      private String edtSerieQuantidadeTemporadas_Internalname ;
      private String edtSerieQuantidadeTemporadas_Jsonclick ;
      private String edtSerieResumo_Internalname ;
      private String imgSerieImagem_Internalname ;
      private String sImgUrl ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtSerieId_Internalname ;
      private String edtSerieId_Jsonclick ;
      private String AV15Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Height ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode1 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXCCtlgxBlob ;
      private String Dvpanel_tableattributes_Internalname ;
      private String gxwrpcisep ;
      private DateTime Z60SerieDataHoraCadastro ;
      private DateTime A60SerieDataHoraCadastro ;
      private DateTime i60SerieDataHoraCadastro ;
      private bool Z47SerieInativo ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A43SerieImagem_IsBlob ;
      private bool A47SerieInativo ;
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
      private String A6SerieResumo ;
      private String Z6SerieResumo ;
      private String Z2SerieNome ;
      private String A2SerieNome ;
      private String A40000SerieImagem_GXI ;
      private String A49GeneroNome ;
      private String Z40000SerieImagem_GXI ;
      private String Z49GeneroNome ;
      private String A43SerieImagem ;
      private String Z43SerieImagem ;
      private IGxSession AV12WebSession ;
      private GxStringCollection gxdynajaxctrlcodr ;
      private GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynGeneroId ;
      private GXCheckbox chkSerieInativo ;
      private IDataStoreProvider pr_default ;
      private String[] T00014_A49GeneroNome ;
      private long[] T00015_A1SerieId ;
      private DateTime[] T00015_A60SerieDataHoraCadastro ;
      private String[] T00015_A2SerieNome ;
      private short[] T00015_A3SerieQuantidadeTemporadas ;
      private String[] T00015_A49GeneroNome ;
      private String[] T00015_A6SerieResumo ;
      private String[] T00015_A40000SerieImagem_GXI ;
      private bool[] T00015_A47SerieInativo ;
      private long[] T00015_A48GeneroId ;
      private String[] T00015_A43SerieImagem ;
      private String[] T00016_A49GeneroNome ;
      private long[] T00017_A1SerieId ;
      private long[] T00013_A1SerieId ;
      private DateTime[] T00013_A60SerieDataHoraCadastro ;
      private String[] T00013_A2SerieNome ;
      private short[] T00013_A3SerieQuantidadeTemporadas ;
      private String[] T00013_A6SerieResumo ;
      private String[] T00013_A40000SerieImagem_GXI ;
      private bool[] T00013_A47SerieInativo ;
      private long[] T00013_A48GeneroId ;
      private String[] T00013_A43SerieImagem ;
      private long[] T00018_A1SerieId ;
      private long[] T00019_A1SerieId ;
      private long[] T00012_A1SerieId ;
      private DateTime[] T00012_A60SerieDataHoraCadastro ;
      private String[] T00012_A2SerieNome ;
      private short[] T00012_A3SerieQuantidadeTemporadas ;
      private String[] T00012_A6SerieResumo ;
      private String[] T00012_A40000SerieImagem_GXI ;
      private bool[] T00012_A47SerieInativo ;
      private long[] T00012_A48GeneroId ;
      private String[] T00012_A43SerieImagem ;
      private long[] T000110_A1SerieId ;
      private String[] T000114_A49GeneroNome ;
      private long[] T000115_A32UsuarioRecomendacaoSerieId ;
      private long[] T000116_A13UsuarioSerieId ;
      private long[] T000117_A7EpisodioId ;
      private IDataStoreProvider pr_gam ;
      private long[] T000118_A1SerieId ;
      private long[] T000119_A48GeneroId ;
      private String[] T000119_A49GeneroNome ;
      private bool[] T000119_A50GeneroInativo ;
      private String[] T000120_A49GeneroNome ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class serie__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class serie__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[11])
       ,new ForEachCursor(def[12])
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
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
        Object[] prmT00015 ;
        prmT00015 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00014 ;
        prmT00014 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00016 ;
        prmT00016 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00017 ;
        prmT00017 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00013 ;
        prmT00013 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00018 ;
        prmT00018 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00019 ;
        prmT00019 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00012 ;
        prmT00012 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000110 ;
        prmT000110 = new Object[] {
        new Object[] {"@SerieDataHoraCadastro",SqlDbType.DateTime,8,5} ,
        new Object[] {"@SerieNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@SerieQuantidadeTemporadas",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SerieResumo",SqlDbType.VarChar,2097152,0} ,
        new Object[] {"@SerieImagem",SqlDbType.VarBinary,1024,0} ,
        new Object[] {"@SerieImagem_GXI",SqlDbType.VarChar,2048,0} ,
        new Object[] {"@SerieInativo",SqlDbType.Bit,4,0} ,
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000111 ;
        prmT000111 = new Object[] {
        new Object[] {"@SerieDataHoraCadastro",SqlDbType.DateTime,8,5} ,
        new Object[] {"@SerieNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@SerieQuantidadeTemporadas",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SerieResumo",SqlDbType.VarChar,2097152,0} ,
        new Object[] {"@SerieInativo",SqlDbType.Bit,4,0} ,
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000112 ;
        prmT000112 = new Object[] {
        new Object[] {"@SerieImagem",SqlDbType.VarBinary,1024,0} ,
        new Object[] {"@SerieImagem_GXI",SqlDbType.VarChar,2048,0} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000113 ;
        prmT000113 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000114 ;
        prmT000114 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000115 ;
        prmT000115 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000116 ;
        prmT000116 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000117 ;
        prmT000117 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000118 ;
        prmT000118 = new Object[] {
        } ;
        Object[] prmT000119 ;
        prmT000119 = new Object[] {
        } ;
        Object[] prmT000120 ;
        prmT000120 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00012", "SELECT [SerieId], [SerieDataHoraCadastro], [SerieNome], [SerieQuantidadeTemporadas], [SerieResumo], [SerieImagem_GXI], [SerieInativo], [GeneroId], [SerieImagem] FROM [Serie] WITH (UPDLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1,0,true,false )
           ,new CursorDef("T00013", "SELECT [SerieId], [SerieDataHoraCadastro], [SerieNome], [SerieQuantidadeTemporadas], [SerieResumo], [SerieImagem_GXI], [SerieInativo], [GeneroId], [SerieImagem] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1,0,true,false )
           ,new CursorDef("T00014", "SELECT [GeneroNome] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1,0,true,false )
           ,new CursorDef("T00015", "SELECT TM1.[SerieId], TM1.[SerieDataHoraCadastro], TM1.[SerieNome], TM1.[SerieQuantidadeTemporadas], T2.[GeneroNome], TM1.[SerieResumo], TM1.[SerieImagem_GXI], TM1.[SerieInativo], TM1.[GeneroId], TM1.[SerieImagem] FROM ([Serie] TM1 WITH (NOLOCK) INNER JOIN [Genero] T2 WITH (NOLOCK) ON T2.[GeneroId] = TM1.[GeneroId]) WHERE TM1.[SerieId] = @SerieId ORDER BY TM1.[SerieId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,100,0,true,false )
           ,new CursorDef("T00016", "SELECT [GeneroNome] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1,0,true,false )
           ,new CursorDef("T00017", "SELECT [SerieId] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1,0,true,false )
           ,new CursorDef("T00018", "SELECT TOP 1 [SerieId] FROM [Serie] WITH (NOLOCK) WHERE ( [SerieId] > @SerieId) ORDER BY [SerieId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1,0,true,true )
           ,new CursorDef("T00019", "SELECT TOP 1 [SerieId] FROM [Serie] WITH (NOLOCK) WHERE ( [SerieId] < @SerieId) ORDER BY [SerieId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,1,0,true,true )
           ,new CursorDef("T000110", "INSERT INTO [Serie]([SerieDataHoraCadastro], [SerieNome], [SerieQuantidadeTemporadas], [SerieResumo], [SerieImagem], [SerieImagem_GXI], [SerieInativo], [GeneroId]) VALUES(@SerieDataHoraCadastro, @SerieNome, @SerieQuantidadeTemporadas, @SerieResumo, @SerieImagem, @SerieImagem_GXI, @SerieInativo, @GeneroId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000110)
           ,new CursorDef("T000111", "UPDATE [Serie] SET [SerieDataHoraCadastro]=@SerieDataHoraCadastro, [SerieNome]=@SerieNome, [SerieQuantidadeTemporadas]=@SerieQuantidadeTemporadas, [SerieResumo]=@SerieResumo, [SerieInativo]=@SerieInativo, [GeneroId]=@GeneroId  WHERE [SerieId] = @SerieId", GxErrorMask.GX_NOMASK,prmT000111)
           ,new CursorDef("T000112", "UPDATE [Serie] SET [SerieImagem]=@SerieImagem, [SerieImagem_GXI]=@SerieImagem_GXI  WHERE [SerieId] = @SerieId", GxErrorMask.GX_NOMASK,prmT000112)
           ,new CursorDef("T000113", "DELETE FROM [Serie]  WHERE [SerieId] = @SerieId", GxErrorMask.GX_NOMASK,prmT000113)
           ,new CursorDef("T000114", "SELECT [GeneroNome] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000114,1,0,true,false )
           ,new CursorDef("T000115", "SELECT TOP 1 [UsuarioRecomendacaoSerieId] FROM [UsuarioRecomendacaoSerie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,1,0,true,true )
           ,new CursorDef("T000116", "SELECT TOP 1 [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000116,1,0,true,true )
           ,new CursorDef("T000117", "SELECT TOP 1 [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000117,1,0,true,true )
           ,new CursorDef("T000118", "SELECT [SerieId] FROM [Serie] WITH (NOLOCK) ORDER BY [SerieId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000118,100,0,true,false )
           ,new CursorDef("T000119", "SELECT [GeneroId], [GeneroNome], [GeneroInativo] FROM [Genero] WITH (NOLOCK) WHERE Not [GeneroInativo] = 1 and [GeneroId] <> 5 ORDER BY [GeneroNome] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000119,0,0,true,false )
           ,new CursorDef("T000120", "SELECT [GeneroNome] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000120,1,0,true,false )
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
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getLongVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getMultimediaUri(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((long[]) buf[7])[0] = rslt.getLong(8) ;
              ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(6)) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getLongVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getMultimediaUri(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((long[]) buf[7])[0] = rslt.getLong(8) ;
              ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(6)) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getLongVarchar(6) ;
              ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
              ((bool[]) buf[7])[0] = rslt.getBool(8) ;
              ((long[]) buf[8])[0] = rslt.getLong(9) ;
              ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(7)) ;
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
           case 12 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.getBool(3) ;
              return;
           case 18 :
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
              stmt.SetParameterDatetime(1, (DateTime)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameterBlob(5, (String)parms[4], false);
              stmt.SetParameterMultimedia(6, (String)parms[5], (String)parms[4], "Serie", "SerieImagem");
              stmt.SetParameter(7, (bool)parms[6]);
              stmt.SetParameter(8, (long)parms[7]);
              return;
           case 9 :
              stmt.SetParameterDatetime(1, (DateTime)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (bool)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              stmt.SetParameter(7, (long)parms[6]);
              return;
           case 10 :
              stmt.SetParameterBlob(1, (String)parms[0], false);
              stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Serie", "SerieImagem");
              stmt.SetParameter(3, (long)parms[2]);
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
           case 18 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
