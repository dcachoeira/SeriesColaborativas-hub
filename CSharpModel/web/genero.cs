/*
               File: Genero
        Description: Gênero
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:37.85
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
   public class genero : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7GeneroId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7GeneroId), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vGENEROID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7GeneroId), "ZZZZZZZZZZZZZZZZZ9"), context));
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
         chkGeneroInativo.Name = "GENEROINATIVO";
         chkGeneroInativo.WebTags = "";
         chkGeneroInativo.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkGeneroInativo_Internalname, "TitleCaption", chkGeneroInativo.Caption, true);
         chkGeneroInativo.CheckedValue = "false";
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
            Form.Meta.addItem("description", "Gênero", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtGeneroNome_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public genero( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public genero( IGxContext context )
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
                           long aP1_GeneroId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7GeneroId = aP1_GeneroId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkGeneroInativo = new GXCheckbox();
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtGeneroNome_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtGeneroNome_Internalname, "Nome", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtGeneroNome_Internalname, A49GeneroNome, StringUtil.RTrim( context.localUtil.Format( A49GeneroNome, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtGeneroNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtGeneroNome_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Nome", "left", true, "HLP_Genero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkGeneroInativo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkGeneroInativo_Internalname, "Inativo", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkGeneroInativo_Internalname, StringUtil.BoolToStr( A50GeneroInativo), "", "Inativo", 1, chkGeneroInativo.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(30, this, 'true', 'false');gx.evt.onchange(this, event);\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "Fechar", bttBtntrn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Genero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "Confirmar", bttBtntrn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Genero.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "Eliminar", bttBtntrn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Genero.htm");
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
            GxWebStd.gx_single_line_edit( context, edtGeneroId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A48GeneroId), 18, 0, ",", "")), ((edtGeneroId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A48GeneroId), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A48GeneroId), "ZZZZZZZZZZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtGeneroId_Jsonclick, 0, "Attribute", "", "", "", "", edtGeneroId_Visible, edtGeneroId_Enabled, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Genero.htm");
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
         E110B2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A49GeneroNome = cgiGet( edtGeneroNome_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49GeneroNome", A49GeneroNome);
               A50GeneroInativo = StringUtil.StrToBool( cgiGet( chkGeneroInativo_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50GeneroInativo", A50GeneroInativo);
               A48GeneroId = (long)(context.localUtil.CToN( cgiGet( edtGeneroId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
               /* Read saved values. */
               Z48GeneroId = (long)(context.localUtil.CToN( cgiGet( "Z48GeneroId"), ",", "."));
               Z49GeneroNome = cgiGet( "Z49GeneroNome");
               Z50GeneroInativo = StringUtil.StrToBool( cgiGet( "Z50GeneroInativo"));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7GeneroId = (long)(context.localUtil.CToN( cgiGet( "vGENEROID"), ",", "."));
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
               forbiddenHiddens = "hsh" + "Genero";
               A48GeneroId = (long)(context.localUtil.CToN( cgiGet( edtGeneroId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A48GeneroId), "ZZZZZZZZZZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A48GeneroId != Z48GeneroId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("genero:[SecurityCheckFailed value for]"+"GeneroId:"+context.localUtil.Format( (decimal)(A48GeneroId), "ZZZZZZZZZZZZZZZZZ9"));
                  GXUtil.WriteLog("genero:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A48GeneroId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
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
                     sMode11 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode11;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound11 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0B0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "GENEROID");
                        AnyError = 1;
                        GX_FocusControl = edtGeneroId_Internalname;
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
                           E110B2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120B2 ();
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
            E120B2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0B11( ) ;
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
            DisableAttributes0B11( ) ;
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

      protected void CONFIRM_0B0( )
      {
         BeforeValidate0B11( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0B11( ) ;
            }
            else
            {
               CheckExtendedTable0B11( ) ;
               CloseExtendedTableCursors0B11( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0B0( )
      {
      }

      protected void E110B2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "SeriesColaborativas");
         edtGeneroId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGeneroId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGeneroId_Visible), 5, 0)), true);
      }

      protected void E120B2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("generoww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0B11( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z49GeneroNome = T000B3_A49GeneroNome[0];
               Z50GeneroInativo = T000B3_A50GeneroInativo[0];
            }
            else
            {
               Z49GeneroNome = A49GeneroNome;
               Z50GeneroInativo = A50GeneroInativo;
            }
         }
         if ( GX_JID == -4 )
         {
            Z48GeneroId = A48GeneroId;
            Z49GeneroNome = A49GeneroNome;
            Z50GeneroInativo = A50GeneroInativo;
         }
      }

      protected void standaloneNotModal( )
      {
         edtGeneroId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGeneroId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGeneroId_Enabled), 5, 0)), true);
         edtGeneroId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGeneroId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGeneroId_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7GeneroId) )
         {
            A48GeneroId = AV7GeneroId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
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
      }

      protected void Load0B11( )
      {
         /* Using cursor T000B4 */
         pr_default.execute(2, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound11 = 1;
            A49GeneroNome = T000B4_A49GeneroNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49GeneroNome", A49GeneroNome);
            A50GeneroInativo = T000B4_A50GeneroInativo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50GeneroInativo", A50GeneroInativo);
            ZM0B11( -4) ;
         }
         pr_default.close(2);
         OnLoadActions0B11( ) ;
      }

      protected void OnLoadActions0B11( )
      {
      }

      protected void CheckExtendedTable0B11( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A49GeneroNome)) )
         {
            GX_msglist.addItem("Nome é obrigatório.", 1, "GENERONOME");
            AnyError = 1;
            GX_FocusControl = edtGeneroNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0B11( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0B11( )
      {
         /* Using cursor T000B5 */
         pr_default.execute(3, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound11 = 1;
         }
         else
         {
            RcdFound11 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000B3 */
         pr_default.execute(1, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0B11( 4) ;
            RcdFound11 = 1;
            A48GeneroId = T000B3_A48GeneroId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
            A49GeneroNome = T000B3_A49GeneroNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49GeneroNome", A49GeneroNome);
            A50GeneroInativo = T000B3_A50GeneroInativo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50GeneroInativo", A50GeneroInativo);
            Z48GeneroId = A48GeneroId;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0B11( ) ;
            if ( AnyError == 1 )
            {
               RcdFound11 = 0;
               InitializeNonKey0B11( ) ;
            }
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound11 = 0;
            InitializeNonKey0B11( ) ;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0B11( ) ;
         if ( RcdFound11 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound11 = 0;
         /* Using cursor T000B6 */
         pr_default.execute(4, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000B6_A48GeneroId[0] < A48GeneroId ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000B6_A48GeneroId[0] > A48GeneroId ) ) )
            {
               A48GeneroId = T000B6_A48GeneroId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
               RcdFound11 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound11 = 0;
         /* Using cursor T000B7 */
         pr_default.execute(5, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000B7_A48GeneroId[0] > A48GeneroId ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000B7_A48GeneroId[0] < A48GeneroId ) ) )
            {
               A48GeneroId = T000B7_A48GeneroId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
               RcdFound11 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0B11( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtGeneroNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0B11( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound11 == 1 )
            {
               if ( A48GeneroId != Z48GeneroId )
               {
                  A48GeneroId = Z48GeneroId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "GENEROID");
                  AnyError = 1;
                  GX_FocusControl = edtGeneroId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtGeneroNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0B11( ) ;
                  GX_FocusControl = edtGeneroNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A48GeneroId != Z48GeneroId )
               {
                  /* Insert record */
                  GX_FocusControl = edtGeneroNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0B11( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "GENEROID");
                     AnyError = 1;
                     GX_FocusControl = edtGeneroId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtGeneroNome_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0B11( ) ;
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
         if ( A48GeneroId != Z48GeneroId )
         {
            A48GeneroId = Z48GeneroId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "GENEROID");
            AnyError = 1;
            GX_FocusControl = edtGeneroId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtGeneroNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0B11( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000B2 */
            pr_default.execute(0, new Object[] {A48GeneroId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Genero"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z49GeneroNome, T000B2_A49GeneroNome[0]) != 0 ) || ( Z50GeneroInativo != T000B2_A50GeneroInativo[0] ) )
            {
               if ( StringUtil.StrCmp(Z49GeneroNome, T000B2_A49GeneroNome[0]) != 0 )
               {
                  GXUtil.WriteLog("genero:[seudo value changed for attri]"+"GeneroNome");
                  GXUtil.WriteLogRaw("Old: ",Z49GeneroNome);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A49GeneroNome[0]);
               }
               if ( Z50GeneroInativo != T000B2_A50GeneroInativo[0] )
               {
                  GXUtil.WriteLog("genero:[seudo value changed for attri]"+"GeneroInativo");
                  GXUtil.WriteLogRaw("Old: ",Z50GeneroInativo);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A50GeneroInativo[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Genero"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0B11( )
      {
         BeforeValidate0B11( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B11( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0B11( 0) ;
            CheckOptimisticConcurrency0B11( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B11( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0B11( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000B8 */
                     pr_default.execute(6, new Object[] {A49GeneroNome, A50GeneroInativo});
                     A48GeneroId = T000B8_A48GeneroId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Genero") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0B0( ) ;
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
               Load0B11( ) ;
            }
            EndLevel0B11( ) ;
         }
         CloseExtendedTableCursors0B11( ) ;
      }

      protected void Update0B11( )
      {
         BeforeValidate0B11( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B11( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B11( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B11( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0B11( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000B9 */
                     pr_default.execute(7, new Object[] {A49GeneroNome, A50GeneroInativo, A48GeneroId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Genero") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Genero"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0B11( ) ;
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
            EndLevel0B11( ) ;
         }
         CloseExtendedTableCursors0B11( ) ;
      }

      protected void DeferredUpdate0B11( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0B11( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B11( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0B11( ) ;
            AfterConfirm0B11( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0B11( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000B10 */
                  pr_default.execute(8, new Object[] {A48GeneroId});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Genero") ;
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
         sMode11 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0B11( ) ;
         Gx_mode = sMode11;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0B11( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000B11 */
            pr_default.execute(9, new Object[] {A48GeneroId});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Série"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel0B11( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0B11( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_gam.commit( "Genero");
            pr_default.commit( "Genero");
            if ( AnyError == 0 )
            {
               ConfirmValues0B0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_gam.rollback( "Genero");
            pr_default.rollback( "Genero");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0B11( )
      {
         /* Scan By routine */
         /* Using cursor T000B12 */
         pr_default.execute(10);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound11 = 1;
            A48GeneroId = T000B12_A48GeneroId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0B11( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound11 = 1;
            A48GeneroId = T000B12_A48GeneroId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
         }
      }

      protected void ScanEnd0B11( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm0B11( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0B11( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0B11( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0B11( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0B11( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0B11( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0B11( )
      {
         edtGeneroNome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGeneroNome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGeneroNome_Enabled), 5, 0)), true);
         chkGeneroInativo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkGeneroInativo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkGeneroInativo.Enabled), 5, 0)), true);
         edtGeneroId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGeneroId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGeneroId_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0B11( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0B0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20189251963931", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("genero.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7GeneroId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Genero";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A48GeneroId), "ZZZZZZZZZZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GXUtil.GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("genero:[SendSecurityCheck value for]"+"GeneroId:"+context.localUtil.Format( (decimal)(A48GeneroId), "ZZZZZZZZZZZZZZZZZ9"));
         GXUtil.WriteLog("genero:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z48GeneroId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48GeneroId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z49GeneroNome", Z49GeneroNome);
         GxWebStd.gx_boolean_hidden_field( context, "Z50GeneroInativo", Z50GeneroInativo);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "vGENEROID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7GeneroId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vGENEROID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7GeneroId), "ZZZZZZZZZZZZZZZZZ9"), context));
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
         return formatLink("genero.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7GeneroId) ;
      }

      public override String GetPgmname( )
      {
         return "Genero" ;
      }

      public override String GetPgmdesc( )
      {
         return "Gênero" ;
      }

      protected void InitializeNonKey0B11( )
      {
         A49GeneroNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49GeneroNome", A49GeneroNome);
         A50GeneroInativo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50GeneroInativo", A50GeneroInativo);
         Z49GeneroNome = "";
         Z50GeneroInativo = false;
      }

      protected void InitAll0B11( )
      {
         A48GeneroId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(A48GeneroId), 18, 0)));
         InitializeNonKey0B11( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20189251963961", true);
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
         context.AddJavascriptSource("genero.js", "?20189251963962", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtGeneroNome_Internalname = "GENERONOME";
         chkGeneroInativo_Internalname = "GENEROINATIVO";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtGeneroId_Internalname = "GENEROID";
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
         Form.Caption = "Gênero";
         edtGeneroId_Jsonclick = "";
         edtGeneroId_Enabled = 0;
         edtGeneroId_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         chkGeneroInativo.Enabled = 1;
         edtGeneroNome_Jsonclick = "";
         edtGeneroNome_Enabled = 1;
         chkGeneroInativo.Caption = "Inativo";
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

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7GeneroId',fld:'vGENEROID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV7GeneroId',fld:'vGENEROID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true,nv:0},{av:'A48GeneroId',fld:'GENEROID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120B2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true,nv:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:'',nv:null}],oparms:[]}");
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
         Z49GeneroNome = "";
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
         A49GeneroNome = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode11 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         T000B4_A48GeneroId = new long[1] ;
         T000B4_A49GeneroNome = new String[] {""} ;
         T000B4_A50GeneroInativo = new bool[] {false} ;
         T000B5_A48GeneroId = new long[1] ;
         T000B3_A48GeneroId = new long[1] ;
         T000B3_A49GeneroNome = new String[] {""} ;
         T000B3_A50GeneroInativo = new bool[] {false} ;
         T000B6_A48GeneroId = new long[1] ;
         T000B7_A48GeneroId = new long[1] ;
         T000B2_A48GeneroId = new long[1] ;
         T000B2_A49GeneroNome = new String[] {""} ;
         T000B2_A50GeneroInativo = new bool[] {false} ;
         T000B8_A48GeneroId = new long[1] ;
         T000B11_A1SerieId = new long[1] ;
         T000B12_A48GeneroId = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.genero__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.genero__default(),
            new Object[][] {
                new Object[] {
               T000B2_A48GeneroId, T000B2_A49GeneroNome, T000B2_A50GeneroInativo
               }
               , new Object[] {
               T000B3_A48GeneroId, T000B3_A49GeneroNome, T000B3_A50GeneroInativo
               }
               , new Object[] {
               T000B4_A48GeneroId, T000B4_A49GeneroNome, T000B4_A50GeneroInativo
               }
               , new Object[] {
               T000B5_A48GeneroId
               }
               , new Object[] {
               T000B6_A48GeneroId
               }
               , new Object[] {
               T000B7_A48GeneroId
               }
               , new Object[] {
               T000B8_A48GeneroId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000B11_A1SerieId
               }
               , new Object[] {
               T000B12_A48GeneroId
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
      private short RcdFound11 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int edtGeneroNome_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtGeneroId_Enabled ;
      private int edtGeneroId_Visible ;
      private int idxLst ;
      private long wcpOAV7GeneroId ;
      private long Z48GeneroId ;
      private long AV7GeneroId ;
      private long A48GeneroId ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String chkGeneroInativo_Internalname ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtGeneroNome_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String TempTags ;
      private String edtGeneroNome_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtGeneroId_Internalname ;
      private String edtGeneroId_Jsonclick ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Height ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode11 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_tableattributes_Internalname ;
      private bool Z50GeneroInativo ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A50GeneroInativo ;
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
      private String Z49GeneroNome ;
      private String A49GeneroNome ;
      private IGxSession AV12WebSession ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkGeneroInativo ;
      private IDataStoreProvider pr_default ;
      private long[] T000B4_A48GeneroId ;
      private String[] T000B4_A49GeneroNome ;
      private bool[] T000B4_A50GeneroInativo ;
      private long[] T000B5_A48GeneroId ;
      private long[] T000B3_A48GeneroId ;
      private String[] T000B3_A49GeneroNome ;
      private bool[] T000B3_A50GeneroInativo ;
      private long[] T000B6_A48GeneroId ;
      private long[] T000B7_A48GeneroId ;
      private long[] T000B2_A48GeneroId ;
      private String[] T000B2_A49GeneroNome ;
      private bool[] T000B2_A50GeneroInativo ;
      private long[] T000B8_A48GeneroId ;
      private long[] T000B11_A1SerieId ;
      private IDataStoreProvider pr_gam ;
      private long[] T000B12_A48GeneroId ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
   }

   public class genero__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class genero__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[7])
       ,new UpdateCursor(def[8])
       ,new ForEachCursor(def[9])
       ,new ForEachCursor(def[10])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000B4 ;
        prmT000B4 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B5 ;
        prmT000B5 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B3 ;
        prmT000B3 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B6 ;
        prmT000B6 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B7 ;
        prmT000B7 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B2 ;
        prmT000B2 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B8 ;
        prmT000B8 = new Object[] {
        new Object[] {"@GeneroNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@GeneroInativo",SqlDbType.Bit,4,0}
        } ;
        Object[] prmT000B9 ;
        prmT000B9 = new Object[] {
        new Object[] {"@GeneroNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@GeneroInativo",SqlDbType.Bit,4,0} ,
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B10 ;
        prmT000B10 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B11 ;
        prmT000B11 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B12 ;
        prmT000B12 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("T000B2", "SELECT [GeneroId], [GeneroNome], [GeneroInativo] FROM [Genero] WITH (UPDLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B2,1,0,true,false )
           ,new CursorDef("T000B3", "SELECT [GeneroId], [GeneroNome], [GeneroInativo] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B3,1,0,true,false )
           ,new CursorDef("T000B4", "SELECT TM1.[GeneroId], TM1.[GeneroNome], TM1.[GeneroInativo] FROM [Genero] TM1 WITH (NOLOCK) WHERE TM1.[GeneroId] = @GeneroId ORDER BY TM1.[GeneroId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B4,100,0,true,false )
           ,new CursorDef("T000B5", "SELECT [GeneroId] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B5,1,0,true,false )
           ,new CursorDef("T000B6", "SELECT TOP 1 [GeneroId] FROM [Genero] WITH (NOLOCK) WHERE ( [GeneroId] > @GeneroId) ORDER BY [GeneroId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B6,1,0,true,true )
           ,new CursorDef("T000B7", "SELECT TOP 1 [GeneroId] FROM [Genero] WITH (NOLOCK) WHERE ( [GeneroId] < @GeneroId) ORDER BY [GeneroId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B7,1,0,true,true )
           ,new CursorDef("T000B8", "INSERT INTO [Genero]([GeneroNome], [GeneroInativo]) VALUES(@GeneroNome, @GeneroInativo); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000B8)
           ,new CursorDef("T000B9", "UPDATE [Genero] SET [GeneroNome]=@GeneroNome, [GeneroInativo]=@GeneroInativo  WHERE [GeneroId] = @GeneroId", GxErrorMask.GX_NOMASK,prmT000B9)
           ,new CursorDef("T000B10", "DELETE FROM [Genero]  WHERE [GeneroId] = @GeneroId", GxErrorMask.GX_NOMASK,prmT000B10)
           ,new CursorDef("T000B11", "SELECT TOP 1 [SerieId] FROM [Serie] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B11,1,0,true,true )
           ,new CursorDef("T000B12", "SELECT [GeneroId] FROM [Genero] WITH (NOLOCK) ORDER BY [GeneroId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B12,100,0,true,false )
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
              ((bool[]) buf[2])[0] = rslt.getBool(3) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.getBool(3) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.getBool(3) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 10 :
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
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (bool)parms[1]);
              return;
           case 7 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (bool)parms[1]);
              stmt.SetParameter(3, (long)parms[2]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
