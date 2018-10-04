/*
               File: CadastroTemporadas
        Description: Cadastro de episódios
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:40.23
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
   public class cadastrotemporadas : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public cadastrotemporadas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public cadastrotemporadas( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_SerieId )
      {
         this.AV10SerieId = aP0_SerieId;
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

      protected void INITWEB( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Fsgepisodios") == 0 )
            {
               nRC_GXsfl_28 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_28_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_28_idx = GetNextPar( );
               edtavEpisodioid_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEpisodioid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEpisodioid_Visible), 5, 0)), !bGXsfl_28_Refreshing);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrFsgepisodios_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Fsgepisodios") == 0 )
            {
               edtavEpisodioid_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEpisodioid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEpisodioid_Visible), 5, 0)), !bGXsfl_28_Refreshing);
               A58EpisodioNumero = (short)(NumberUtil.Val( GetNextPar( ), "."));
               A1SerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV10SerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               A42EpisodioTemporada = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV11TemporadaNumero = (short)(NumberUtil.Val( GetNextPar( ), "."));
               A7EpisodioId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               A8EpisodioNome = GetNextPar( );
               A9EpisodioDuracao = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrFsgepisodios_refresh( A58EpisodioNumero, A1SerieId, AV10SerieId, A42EpisodioTemporada, AV11TemporadaNumero, A7EpisodioId, A8EpisodioNome, A9EpisodioDuracao) ;
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Fsgtemporadas") == 0 )
            {
               nRC_GXsfl_15 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_15_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_15_idx = GetNextPar( );
               edtavTemporadanumero_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTemporadanumero_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTemporadanumero_Visible), 5, 0)), !bGXsfl_15_Refreshing);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrFsgtemporadas_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Fsgtemporadas") == 0 )
            {
               edtavTemporadanumero_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTemporadanumero_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTemporadanumero_Visible), 5, 0)), !bGXsfl_15_Refreshing);
               A1SerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV10SerieId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               A3SerieQuantidadeTemporadas = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrFsgtemporadas_refresh( A1SerieId, AV10SerieId, A3SerieQuantidadeTemporadas) ;
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
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
               AV10SerieId = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10SerieId), 18, 0)));
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
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

      public override short ExecuteStartEvent( )
      {
         PA262( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START262( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 121631), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxcfg.js", "?20189251964032", false);
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
         FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("cadastrotemporadas.aspx") + "?" + UrlEncode("" +AV10SerieId)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         }
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
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_15", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_15), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "SERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSERIEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10SerieId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "SERIEQUANTIDADETEMPORADAS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3SerieQuantidadeTemporadas), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "EPISODIONUMERO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A58EpisodioNumero), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "EPISODIOTEMPORADA", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42EpisodioTemporada), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "EPISODIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EpisodioId), 18, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "EPISODIONOME", A8EpisodioNome);
         GxWebStd.gx_hidden_field( context, "EPISODIODURACAO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A9EpisodioDuracao), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vTEMPORADANUMERO_Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavTemporadanumero_Visible), 5, 0, ".", "")));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE262( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT262( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("cadastrotemporadas.aspx") + "?" + UrlEncode("" +AV10SerieId) ;
      }

      public override String GetPgmname( )
      {
         return "CadastroTemporadas" ;
      }

      public override String GetPgmdesc( )
      {
         return "Cadastro de episódios" ;
      }

      protected void WB260( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            FsgtemporadasContainer.SetIsFreestyle(true);
            FsgtemporadasContainer.SetWrapped(nGXWrapped);
            if ( FsgtemporadasContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"FsgtemporadasContainer"+"DivS\" data-gxgridid=\"15\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subFsgtemporadas_Internalname, subFsgtemporadas_Internalname, "", "FreeStyleGrid", 0, "", "", 1, 2, sStyleString, "", 0);
               FsgtemporadasContainer.AddObjectProperty("GridName", "Fsgtemporadas");
            }
            else
            {
               FsgtemporadasContainer.AddObjectProperty("GridName", "Fsgtemporadas");
               FsgtemporadasContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
               FsgtemporadasContainer.AddObjectProperty("Class", "FreeStyleGrid");
               FsgtemporadasContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               FsgtemporadasContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               FsgtemporadasContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgtemporadas_Backcolorstyle), 1, 0, ".", "")));
               FsgtemporadasContainer.AddObjectProperty("CmpContext", "");
               FsgtemporadasContainer.AddObjectProperty("InMasterPage", "false");
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasColumn.AddObjectProperty("Value", lblTxttemporada_Caption);
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasColumn.AddObjectProperty("Value", context.convertURL( context.GetImagePath( "c7bbffa6-abe6-45fb-9e3f-01a3bc116e6a", "", context.GetTheme( ))));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               FsgtemporadasColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11TemporadaNumero), 4, 0, ".", "")));
               FsgtemporadasColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavTemporadanumero_Visible), 5, 0, ".", "")));
               FsgtemporadasContainer.AddColumnProperties(FsgtemporadasColumn);
               FsgtemporadasContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgtemporadas_Allowselection), 1, 0, ".", "")));
               FsgtemporadasContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgtemporadas_Selectioncolor), 9, 0, ".", "")));
               FsgtemporadasContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgtemporadas_Allowhovering), 1, 0, ".", "")));
               FsgtemporadasContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgtemporadas_Hoveringcolor), 9, 0, ".", "")));
               FsgtemporadasContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgtemporadas_Allowcollapsing), 1, 0, ".", "")));
               FsgtemporadasContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgtemporadas_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 15 )
         {
            wbEnd = 0;
            nRC_GXsfl_15 = (short)(nGXsfl_15_idx-1);
            if ( FsgtemporadasContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"FsgtemporadasContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Fsgtemporadas", FsgtemporadasContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "FsgtemporadasContainerData", FsgtemporadasContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "FsgtemporadasContainerData"+"V", FsgtemporadasContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input autocomplete=\"off\" type=\"hidden\" "+"name=\""+"FsgtemporadasContainerData"+"V"+"\" value='"+FsgtemporadasContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START262( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
            Form.Meta.addItem("description", "Cadastro de episódios", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP260( ) ;
      }

      protected void WS262( )
      {
         START262( ) ;
         EVT262( ) ;
      }

      protected void EVT262( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 18), "FSGTEMPORADAS.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "'DOADICIONAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "'DOADICIONAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 17), "FSGEPISODIOS.LOAD") == 0 ) )
                           {
                              nGXsfl_15_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
                              SubsflControlProps_152( ) ;
                              if ( ( ( context.localUtil.CToN( cgiGet( edtavTemporadanumero_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTemporadanumero_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTEMPORADANUMERO");
                                 GX_FocusControl = edtavTemporadanumero_Internalname;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true;
                                 AV11TemporadaNumero = 0;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavTemporadanumero_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV11TemporadaNumero), 4, 0)));
                              }
                              else
                              {
                                 AV11TemporadaNumero = (short)(context.localUtil.CToN( cgiGet( edtavTemporadanumero_Internalname), ",", "."));
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavTemporadanumero_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV11TemporadaNumero), 4, 0)));
                              }
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E11262 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "FSGTEMPORADAS.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E12262 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DOADICIONAR'") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: 'DoAdicionar' */
                                    E13262 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E14262 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                                 sEvtType = StringUtil.Right( sEvt, 4);
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                                 if ( StringUtil.StrCmp(StringUtil.Left( sEvt, 17), "FSGEPISODIOS.LOAD") == 0 )
                                 {
                                    nGXsfl_28_idx = (short)(NumberUtil.Val( sEvtType, "."));
                                    sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0") + sGXsfl_15_idx;
                                    SubsflControlProps_284( ) ;
                                    AV14EpisodioNome = cgiGet( edtavEpisodionome_Internalname);
                                    context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavEpisodionome_Internalname, AV14EpisodioNome);
                                    AV15EpisodioDuracao = cgiGet( edtavEpisodioduracao_Internalname);
                                    context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavEpisodioduracao_Internalname, AV15EpisodioDuracao);
                                    AV13EpisodioId = (long)(context.localUtil.CToN( cgiGet( edtavEpisodioid_Internalname), ",", "."));
                                    context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavEpisodioid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV13EpisodioId), 18, 0)));
                                    sEvtType = StringUtil.Right( sEvt, 1);
                                    if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                                    {
                                       sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                       if ( StringUtil.StrCmp(sEvt, "FSGEPISODIOS.LOAD") == 0 )
                                       {
                                          context.wbHandled = 1;
                                          dynload_actions( ) ;
                                          E15264 ();
                                       }
                                       else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                       {
                                          context.wbHandled = 1;
                                          dynload_actions( ) ;
                                       }
                                    }
                                    else
                                    {
                                    }
                                 }
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE262( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA262( )
      {
         if ( nDonePA == 0 )
         {
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
            if ( ! context.isAjaxRequest( ) )
            {
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrFsgtemporadas_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_152( ) ;
         while ( nGXsfl_15_idx <= nRC_GXsfl_15 )
         {
            sendrow_152( ) ;
            nGXsfl_15_idx = (short)(((subFsgtemporadas_Islastpage==1)&&(nGXsfl_15_idx+1>subFsgtemporadas_Recordsperpage( )) ? 1 : nGXsfl_15_idx+1));
            sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
            SubsflControlProps_152( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( FsgtemporadasContainer));
         /* End function gxnrFsgtemporadas_newrow */
      }

      protected void gxnrFsgepisodios_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_284( ) ;
         while ( nGXsfl_28_idx <= nRC_GXsfl_28 )
         {
            sendrow_284( ) ;
            nGXsfl_28_idx = (short)(((subFsgepisodios_Islastpage==1)&&(nGXsfl_28_idx+1>subFsgepisodios_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1));
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0") + sGXsfl_15_idx;
            SubsflControlProps_284( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( FsgepisodiosContainer));
         /* End function gxnrFsgepisodios_newrow */
      }

      protected void gxgrFsgepisodios_refresh( short A58EpisodioNumero ,
                                               long A1SerieId ,
                                               long AV10SerieId ,
                                               short A42EpisodioTemporada ,
                                               short AV11TemporadaNumero ,
                                               long A7EpisodioId ,
                                               String A8EpisodioNome ,
                                               short A9EpisodioDuracao )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         /* Execute user event: Refresh */
         E14262 ();
         FSGEPISODIOS_nCurrentRecord = 0;
         RF264( ) ;
         /* End function gxgrFsgepisodios_refresh */
      }

      protected void gxgrFsgtemporadas_refresh( long A1SerieId ,
                                                long AV10SerieId ,
                                                short A3SerieQuantidadeTemporadas )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         FSGTEMPORADAS_nCurrentRecord = 0;
         RF262( ) ;
         /* End function gxgrFsgtemporadas_refresh */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void fix_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF262( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavEpisodionome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEpisodionome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEpisodionome_Enabled), 5, 0)), !bGXsfl_28_Refreshing);
         edtavEpisodioduracao_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEpisodioduracao_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEpisodioduracao_Enabled), 5, 0)), !bGXsfl_28_Refreshing);
      }

      protected void RF262( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            FsgtemporadasContainer.ClearRows();
         }
         wbStart = 15;
         /* Execute user event: Refresh */
         E14262 ();
         nGXsfl_15_idx = 1;
         sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
         SubsflControlProps_152( ) ;
         bGXsfl_15_Refreshing = true;
         FsgtemporadasContainer.AddObjectProperty("GridName", "Fsgtemporadas");
         FsgtemporadasContainer.AddObjectProperty("CmpContext", "");
         FsgtemporadasContainer.AddObjectProperty("InMasterPage", "false");
         FsgtemporadasContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
         FsgtemporadasContainer.AddObjectProperty("Class", "FreeStyleGrid");
         FsgtemporadasContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         FsgtemporadasContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         FsgtemporadasContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgtemporadas_Backcolorstyle), 1, 0, ".", "")));
         FsgtemporadasContainer.PageSize = subFsgtemporadas_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_152( ) ;
            E12262 ();
            wbEnd = 15;
            WB260( ) ;
         }
         bGXsfl_15_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes262( )
      {
      }

      protected void RF264( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            FsgepisodiosContainer.ClearRows();
         }
         wbStart = 28;
         nGXsfl_28_idx = 1;
         sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0") + sGXsfl_15_idx;
         SubsflControlProps_284( ) ;
         bGXsfl_28_Refreshing = true;
         FsgepisodiosContainer.AddObjectProperty("GridName", "Fsgepisodios");
         FsgepisodiosContainer.AddObjectProperty("CmpContext", "");
         FsgepisodiosContainer.AddObjectProperty("InMasterPage", "false");
         FsgepisodiosContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
         FsgepisodiosContainer.AddObjectProperty("Class", "FreeStyleGrid");
         FsgepisodiosContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         FsgepisodiosContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         FsgepisodiosContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgepisodios_Backcolorstyle), 1, 0, ".", "")));
         FsgepisodiosContainer.PageSize = subFsgepisodios_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_284( ) ;
            E15264 ();
            wbEnd = 28;
            WB260( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes264( )
      {
      }

      protected int subFsgtemporadas_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subFsgtemporadas_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subFsgtemporadas_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subFsgtemporadas_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected int subFsgepisodios_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subFsgepisodios_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subFsgepisodios_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subFsgepisodios_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP260( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavEpisodionome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEpisodionome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEpisodionome_Enabled), 5, 0)), !bGXsfl_28_Refreshing);
         edtavEpisodioduracao_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEpisodioduracao_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEpisodioduracao_Enabled), 5, 0)), !bGXsfl_28_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11262 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_GXsfl_15 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_15"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E11262 ();
         if (returnInSub) return;
      }

      protected void E11262( )
      {
         /* Start Routine */
         edtavTemporadanumero_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTemporadanumero_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTemporadanumero_Visible), 5, 0)), !bGXsfl_15_Refreshing);
         edtavEpisodioid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEpisodioid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEpisodioid_Visible), 5, 0)), !bGXsfl_28_Refreshing);
      }

      private void E12262( )
      {
         /* Fsgtemporadas_Load Routine */
         /* Using cursor H00262 */
         pr_default.execute(0, new Object[] {AV10SerieId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1SerieId = H00262_A1SerieId[0];
            A3SerieQuantidadeTemporadas = H00262_A3SerieQuantidadeTemporadas[0];
            AV12SerieQuantidadeTemporadas = A3SerieQuantidadeTemporadas;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         AV9i = 1;
         while ( AV9i <= AV12SerieQuantidadeTemporadas )
         {
            lblTxttemporada_Caption = "Temporada "+StringUtil.Str( (decimal)(AV9i), 4, 0);
            AV11TemporadaNumero = AV9i;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavTemporadanumero_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV11TemporadaNumero), 4, 0)));
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 15;
            }
            sendrow_152( ) ;
            if ( isFullAjaxMode( ) && ! bGXsfl_15_Refreshing )
            {
               context.DoAjaxLoad(15, FsgtemporadasRow);
            }
            AV9i = (short)(AV9i+1);
         }
         /*  Sending Event outputs  */
      }

      protected void E13262( )
      {
         /* 'DoAdicionar' Routine */
         context.PopUp(formatLink("episodio.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0) + "," + UrlEncode("" +AV11TemporadaNumero) + "," + UrlEncode("" +AV10SerieId), new Object[] {"AV11TemporadaNumero","AV10SerieId"});
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
      }

      protected void E14262( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         divTableone_Width = 850;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTableone_Internalname, "Width", StringUtil.LTrim( StringUtil.Str( (decimal)(divTableone_Width), 9, 0)), !bGXsfl_15_Refreshing);
         /*  Sending Event outputs  */
      }

      private void E15264( )
      {
         /* Fsgepisodios_Load Routine */
         bttBtneditar_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtneditar_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtneditar_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         AV16Count = 0;
         AV20GXLvl45 = 0;
         /* Using cursor H00263 */
         pr_default.execute(1, new Object[] {AV10SerieId, AV11TemporadaNumero});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A1SerieId = H00263_A1SerieId[0];
            A42EpisodioTemporada = H00263_A42EpisodioTemporada[0];
            A7EpisodioId = H00263_A7EpisodioId[0];
            A8EpisodioNome = H00263_A8EpisodioNome[0];
            A9EpisodioDuracao = H00263_A9EpisodioDuracao[0];
            A58EpisodioNumero = H00263_A58EpisodioNumero[0];
            AV20GXLvl45 = 1;
            edtavEpisodioduracao_Visible = 1;
            AV16Count = (short)(AV16Count+1);
            AV13EpisodioId = A7EpisodioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavEpisodioid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV13EpisodioId), 18, 0)));
            AV14EpisodioNome = A8EpisodioNome;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavEpisodionome_Internalname, AV14EpisodioNome);
            AV15EpisodioDuracao = StringUtil.Str( (decimal)(A9EpisodioDuracao), 3, 0) + " Minutos";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavEpisodioduracao_Internalname, AV15EpisodioDuracao);
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 28;
            }
            sendrow_284( ) ;
            if ( isFullAjaxMode( ) && ! bGXsfl_28_Refreshing )
            {
               context.DoAjaxLoad(28, FsgepisodiosRow);
            }
            pr_default.readNext(1);
         }
         pr_default.close(1);
         if ( AV20GXLvl45 == 0 )
         {
            AV14EpisodioNome = "Sem episódios cadastrados";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavEpisodionome_Internalname, AV14EpisodioNome);
            edtavEpisodioduracao_Visible = 0;
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 28;
            }
            sendrow_284( ) ;
            if ( isFullAjaxMode( ) && ! bGXsfl_28_Refreshing )
            {
               context.DoAjaxLoad(28, FsgepisodiosRow);
            }
         }
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10SerieId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10SerieId), 18, 0)));
      }

      public override String getresponse( String sGXDynURL )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA262( ) ;
         WS262( ) ;
         WE262( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20189251964087", true);
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
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.por.js", "?"+GetCacheInvalidationToken( ), false);
            context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 121631), false);
            context.AddJavascriptSource("cadastrotemporadas.js", "?20189251964087", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_284( )
      {
         edtavEpisodionome_Internalname = "vEPISODIONOME_"+sGXsfl_28_idx;
         edtavEpisodioduracao_Internalname = "vEPISODIODURACAO_"+sGXsfl_28_idx;
         edtavEpisodioid_Internalname = "vEPISODIOID_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_284( )
      {
         edtavEpisodionome_Internalname = "vEPISODIONOME_"+sGXsfl_28_fel_idx;
         edtavEpisodioduracao_Internalname = "vEPISODIODURACAO_"+sGXsfl_28_fel_idx;
         edtavEpisodioid_Internalname = "vEPISODIOID_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_284( )
      {
         SubsflControlProps_284( ) ;
         WB260( ) ;
         FsgepisodiosRow = GXWebRow.GetNew(context,FsgepisodiosContainer);
         if ( subFsgepisodios_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subFsgepisodios_Backstyle = 0;
            if ( StringUtil.StrCmp(subFsgepisodios_Class, "") != 0 )
            {
               subFsgepisodios_Linesclass = subFsgepisodios_Class+"Odd";
            }
         }
         else if ( subFsgepisodios_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subFsgepisodios_Backstyle = 0;
            subFsgepisodios_Backcolor = subFsgepisodios_Allbackcolor;
            if ( StringUtil.StrCmp(subFsgepisodios_Class, "") != 0 )
            {
               subFsgepisodios_Linesclass = subFsgepisodios_Class+"Uniform";
            }
         }
         else if ( subFsgepisodios_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subFsgepisodios_Backstyle = 1;
            if ( StringUtil.StrCmp(subFsgepisodios_Class, "") != 0 )
            {
               subFsgepisodios_Linesclass = subFsgepisodios_Class+"Odd";
            }
            subFsgepisodios_Backcolor = (int)(0xFFFFFF);
         }
         else if ( subFsgepisodios_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subFsgepisodios_Backstyle = 1;
            if ( ((int)((nGXsfl_28_idx) % (2))) == 0 )
            {
               subFsgepisodios_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subFsgepisodios_Class, "") != 0 )
               {
                  subFsgepisodios_Linesclass = subFsgepisodios_Class+"Even";
               }
            }
            else
            {
               subFsgepisodios_Backcolor = (int)(0xFFFFFF);
               if ( StringUtil.StrCmp(subFsgepisodios_Class, "") != 0 )
               {
                  subFsgepisodios_Linesclass = subFsgepisodios_Class+"Odd";
               }
            }
         }
         /* Start of Columns property logic. */
         if ( FsgepisodiosContainer.GetWrapped() == 1 )
         {
            if ( ( 1 == 0 ) && ( nGXsfl_28_idx == 1 ) )
            {
               context.WriteHtmlText( "<tr"+" class=\""+subFsgepisodios_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_28_idx+"\">") ;
            }
            if ( 1 > 0 )
            {
               if ( ( 1 == 1 ) || ( ((int)((nGXsfl_28_idx) % (1))) - 1 == 0 ) )
               {
                  context.WriteHtmlText( "<tr"+" class=\""+subFsgepisodios_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_28_idx+"\">") ;
               }
            }
         }
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divUnnamedtablefsfsgepisodios_Internalname+"_"+sGXsfl_28_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Table",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divTableepisodio_Internalname+"_"+sGXsfl_28_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-2",(String)"Center",(String)"top",(String)"",(String)"",(String)"div"});
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
         ClassString = "Button";
         StyleString = "";
         FsgepisodiosRow.AddColumnProperties("button", 2, isAjaxCallMode( ), new Object[] {(String)bttBtneditar_Internalname+"_"+sGXsfl_28_idx,"gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");",(String)"Editar",(String)bttBtneditar_Jsonclick,(short)7,(String)"Editar",(String)"",(String)StyleString,(String)ClassString,(int)bttBtneditar_Visible,(short)1,(String)"standard",(String)"'"+""+"'"+",false,"+"'"+"e16264_client"+"'",(String)TempTags,(String)"",(short)2});
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"Center",(String)"top",(String)"div"});
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-8",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         FsgepisodiosRow.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtavEpisodionome_Internalname,(String)"Episodio Nome",(String)"col-sm-3 ReadonlyAttributeLabel",(short)0,(bool)true});
         /* Single line edit */
         ROClassString = "ReadonlyAttribute";
         FsgepisodiosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavEpisodionome_Internalname,(String)AV14EpisodioNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavEpisodionome_Jsonclick,(short)0,(String)"ReadonlyAttribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtavEpisodionome_Enabled,(short)0,(String)"text",(String)"",(short)40,(String)"chr",(short)1,(String)"row",(short)40,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-2",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         FsgepisodiosRow.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtavEpisodioduracao_Internalname,(String)"Episodio Duracao",(String)"col-sm-3 ReadonlyAttributeLabel",(short)0,(bool)true});
         /* Single line edit */
         ROClassString = "ReadonlyAttribute";
         FsgepisodiosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavEpisodioduracao_Internalname,(String)AV15EpisodioDuracao,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavEpisodioduracao_Jsonclick,(short)0,(String)"ReadonlyAttribute",(String)"",(String)ROClassString,(String)"",(String)"",(int)edtavEpisodioduracao_Visible,(int)edtavEpisodioduracao_Enabled,(short)0,(String)"text",(String)"",(short)80,(String)"chr",(short)1,(String)"row",(short)100,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Table start */
         FsgepisodiosRow.AddColumnProperties("table", -1, isAjaxCallMode( ), new Object[] {(String)tblUnnamedtablecontentfsfsgepisodios_Internalname+"_"+sGXsfl_28_idx,(short)1,(String)"Table",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(short)2,(String)"",(String)"",(String)"",(String)"px",(String)"px"});
         FsgepisodiosRow.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         FsgepisodiosRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Div Control */
         FsgepisodiosRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         FsgepisodiosRow.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtavEpisodioid_Internalname,(String)"Episodio Id",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
         /* Single line edit */
         ROClassString = "Attribute";
         FsgepisodiosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavEpisodioid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13EpisodioId), 18, 0, ",", "")),context.localUtil.Format( (decimal)(AV13EpisodioId), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavEpisodioid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(int)edtavEpisodioid_Visible,(short)0,(short)0,(String)"text",(String)"",(short)18,(String)"chr",(short)1,(String)"row",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         if ( FsgepisodiosContainer.GetWrapped() == 1 )
         {
            FsgepisodiosContainer.CloseTag("cell");
         }
         if ( FsgepisodiosContainer.GetWrapped() == 1 )
         {
            FsgepisodiosContainer.CloseTag("row");
         }
         if ( FsgepisodiosContainer.GetWrapped() == 1 )
         {
            FsgepisodiosContainer.CloseTag("table");
         }
         /* End of table */
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgepisodiosRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         send_integrity_lvl_hashes264( ) ;
         /* End of Columns property logic. */
         FsgepisodiosContainer.AddRow(FsgepisodiosRow);
         nGXsfl_28_idx = (short)(((subFsgepisodios_Islastpage==1)&&(nGXsfl_28_idx+1>subFsgepisodios_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1));
         sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0") + sGXsfl_15_idx;
         SubsflControlProps_284( ) ;
         /* End function sendrow_284 */
      }

      protected void SubsflControlProps_152( )
      {
         lblTxttemporada_Internalname = "TXTTEMPORADA_"+sGXsfl_15_idx;
         imgAdicionar_Internalname = "ADICIONAR_"+sGXsfl_15_idx;
         edtavTemporadanumero_Internalname = "vTEMPORADANUMERO_"+sGXsfl_15_idx;
         subFsgepisodios_Internalname = "FSGEPISODIOS_"+sGXsfl_15_idx;
      }

      protected void SubsflControlProps_fel_152( )
      {
         lblTxttemporada_Internalname = "TXTTEMPORADA_"+sGXsfl_15_fel_idx;
         imgAdicionar_Internalname = "ADICIONAR_"+sGXsfl_15_fel_idx;
         edtavTemporadanumero_Internalname = "vTEMPORADANUMERO_"+sGXsfl_15_fel_idx;
         subFsgepisodios_Internalname = "FSGEPISODIOS_"+sGXsfl_15_fel_idx;
      }

      protected void sendrow_152( )
      {
         SubsflControlProps_152( ) ;
         WB260( ) ;
         FsgtemporadasRow = GXWebRow.GetNew(context,FsgtemporadasContainer);
         if ( subFsgtemporadas_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subFsgtemporadas_Backstyle = 0;
            if ( StringUtil.StrCmp(subFsgtemporadas_Class, "") != 0 )
            {
               subFsgtemporadas_Linesclass = subFsgtemporadas_Class+"Odd";
            }
         }
         else if ( subFsgtemporadas_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subFsgtemporadas_Backstyle = 0;
            subFsgtemporadas_Backcolor = subFsgtemporadas_Allbackcolor;
            if ( StringUtil.StrCmp(subFsgtemporadas_Class, "") != 0 )
            {
               subFsgtemporadas_Linesclass = subFsgtemporadas_Class+"Uniform";
            }
         }
         else if ( subFsgtemporadas_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subFsgtemporadas_Backstyle = 1;
            if ( StringUtil.StrCmp(subFsgtemporadas_Class, "") != 0 )
            {
               subFsgtemporadas_Linesclass = subFsgtemporadas_Class+"Odd";
            }
            subFsgtemporadas_Backcolor = (int)(0xFFFFFF);
         }
         else if ( subFsgtemporadas_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subFsgtemporadas_Backstyle = 1;
            if ( ((int)((nGXsfl_15_idx) % (2))) == 0 )
            {
               subFsgtemporadas_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subFsgtemporadas_Class, "") != 0 )
               {
                  subFsgtemporadas_Linesclass = subFsgtemporadas_Class+"Even";
               }
            }
            else
            {
               subFsgtemporadas_Backcolor = (int)(0xFFFFFF);
               if ( StringUtil.StrCmp(subFsgtemporadas_Class, "") != 0 )
               {
                  subFsgtemporadas_Linesclass = subFsgtemporadas_Class+"Odd";
               }
            }
         }
         /* Start of Columns property logic. */
         if ( FsgtemporadasContainer.GetWrapped() == 1 )
         {
            if ( ( 1 == 0 ) && ( nGXsfl_15_idx == 1 ) )
            {
               context.WriteHtmlText( "<tr"+" class=\""+subFsgtemporadas_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_15_idx+"\">") ;
            }
            if ( 1 > 0 )
            {
               if ( ( 1 == 1 ) || ( ((int)((nGXsfl_15_idx) % (1))) - 1 == 0 ) )
               {
                  context.WriteHtmlText( "<tr"+" class=\""+subFsgtemporadas_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_15_idx+"\">") ;
               }
            }
         }
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divUnnamedtablefsfsgtemporadas_Internalname+"_"+sGXsfl_15_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Table",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divTableone_Internalname+"_"+sGXsfl_15_idx,(short)1,(int)divTableone_Width,(String)"px",(short)0,(String)"px",(String)"TableLogin",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-1",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-8",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Text block */
         FsgtemporadasRow.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTxttemporada_Internalname,(String)lblTxttemporada_Caption,(String)"",(String)"",(String)lblTxttemporada_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlockTitleLogin",(short)0,(String)"",(short)1,(short)1,(short)0});
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-3",(String)"Center",(String)"top",(String)"",(String)"",(String)"div"});
         /* Active images/pictures */
         TempTags = " " + ((imgAdicionar_Enabled!=0)&&(imgAdicionar_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"" : " ");
         ClassString = "Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "c7bbffa6-abe6-45fb-9e3f-01a3bc116e6a", "", context.GetTheme( )));
         FsgtemporadasRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgAdicionar_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)1,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)imgAdicionar_Jsonclick,"'"+""+"'"+",false,"+"'"+"E\\'DOADICIONAR\\'."+"'",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)" "+"data-gx-image"+" "+TempTags,(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"Center",(String)"top",(String)"div"});
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /*  Child Grid Control  */
         FsgtemporadasRow.AddColumnProperties("subfile", -1, isAjaxCallMode( ), new Object[] {(String)"FsgepisodiosContainer"});
         if ( isAjaxCallMode( ) )
         {
            FsgepisodiosContainer = new GXWebGrid( context);
         }
         else
         {
            FsgepisodiosContainer.Clear();
         }
         FsgepisodiosContainer.SetIsFreestyle(true);
         FsgepisodiosContainer.SetWrapped(nGXWrapped);
         if ( FsgepisodiosContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<div id=\""+"FsgepisodiosContainer"+"DivS\" data-gxgridid=\"28\">") ;
            sStyleString = "";
            GxWebStd.gx_table_start( context, subFsgepisodios_Internalname, subFsgepisodios_Internalname, "", "FreeStyleGrid", 0, "", "", 1, 2, sStyleString, "", 0);
            FsgepisodiosContainer.AddObjectProperty("GridName", "Fsgepisodios");
         }
         else
         {
            FsgepisodiosContainer.AddObjectProperty("GridName", "Fsgepisodios");
            FsgepisodiosContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
            FsgepisodiosContainer.AddObjectProperty("Class", "FreeStyleGrid");
            FsgepisodiosContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            FsgepisodiosContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            FsgepisodiosContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgepisodios_Backcolorstyle), 1, 0, ".", "")));
            FsgepisodiosContainer.AddObjectProperty("CmpContext", "");
            FsgepisodiosContainer.AddObjectProperty("InMasterPage", "false");
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosColumn.AddObjectProperty("Value", AV14EpisodioNome);
            FsgepisodiosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavEpisodionome_Enabled), 5, 0, ".", "")));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosColumn.AddObjectProperty("Value", AV15EpisodioDuracao);
            FsgepisodiosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavEpisodioduracao_Enabled), 5, 0, ".", "")));
            FsgepisodiosColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavEpisodioduracao_Visible), 5, 0, ".", "")));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
            FsgepisodiosColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13EpisodioId), 18, 0, ".", "")));
            FsgepisodiosColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavEpisodioid_Visible), 5, 0, ".", "")));
            FsgepisodiosContainer.AddColumnProperties(FsgepisodiosColumn);
            FsgepisodiosContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgepisodios_Allowselection), 1, 0, ".", "")));
            FsgepisodiosContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgepisodios_Selectioncolor), 9, 0, ".", "")));
            FsgepisodiosContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgepisodios_Allowhovering), 1, 0, ".", "")));
            FsgepisodiosContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgepisodios_Hoveringcolor), 9, 0, ".", "")));
            FsgepisodiosContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgepisodios_Allowcollapsing), 1, 0, ".", "")));
            FsgepisodiosContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subFsgepisodios_Collapsed), 1, 0, ".", "")));
         }
         RF264( ) ;
         nRC_GXsfl_28 = (short)(nGXsfl_28_idx-1);
         send_integrity_footer_hashes( ) ;
         GXCCtl = "nRC_GXsfl_28_" + sGXsfl_15_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_28), 4, 0, ",", "")));
         if ( FsgepisodiosContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "</table>") ;
         }
         else
         {
            if ( ! isAjaxCallMode( ) )
            {
               GxWebStd.gx_hidden_field( context, "FsgepisodiosContainerData"+"_"+sGXsfl_15_idx, FsgepisodiosContainer.ToJavascriptSource());
            }
            if ( isAjaxCallMode( ) )
            {
               FsgtemporadasRow.AddGrid("Fsgepisodios", FsgepisodiosContainer);
            }
            if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "FsgepisodiosContainerData"+"V_"+sGXsfl_15_idx, FsgepisodiosContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input autocomplete=\"off\" type=\"hidden\" "+"name=\""+"FsgepisodiosContainerData"+"V_"+sGXsfl_15_idx+"\" value='"+FsgepisodiosContainer.GridValuesHidden()+"'/>") ;
            }
         }
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Table start */
         FsgtemporadasRow.AddColumnProperties("table", -1, isAjaxCallMode( ), new Object[] {(String)tblUnnamedtablecontentfsfsgtemporadas_Internalname+"_"+sGXsfl_15_idx,(short)1,(String)"Table",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(short)2,(String)"",(String)"",(String)"",(String)"px",(String)"px"});
         FsgtemporadasRow.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         FsgtemporadasRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Div Control */
         FsgtemporadasRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         FsgtemporadasRow.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtavTemporadanumero_Internalname,(String)"Temporada Numero",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
         /* Single line edit */
         TempTags = " " + ((edtavTemporadanumero_Enabled!=0)&&(edtavTemporadanumero_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 55,'',false,'"+sGXsfl_15_idx+"',15)\"" : " ");
         ROClassString = "Attribute";
         FsgtemporadasRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavTemporadanumero_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11TemporadaNumero), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11TemporadaNumero), "ZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+((edtavTemporadanumero_Enabled!=0)&&(edtavTemporadanumero_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,55);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavTemporadanumero_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(int)edtavTemporadanumero_Visible,(short)1,(short)0,(String)"text",(String)"",(short)4,(String)"chr",(short)1,(String)"row",(short)4,(short)0,(short)0,(short)15,(short)1,(short)-1,(short)0,(bool)true,(String)"Temporada",(String)"right",(bool)false});
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         if ( FsgtemporadasContainer.GetWrapped() == 1 )
         {
            FsgtemporadasContainer.CloseTag("cell");
         }
         if ( FsgtemporadasContainer.GetWrapped() == 1 )
         {
            FsgtemporadasContainer.CloseTag("row");
         }
         if ( FsgtemporadasContainer.GetWrapped() == 1 )
         {
            FsgtemporadasContainer.CloseTag("table");
         }
         /* End of table */
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         FsgtemporadasRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         send_integrity_lvl_hashes262( ) ;
         /* End of Columns property logic. */
         FsgtemporadasContainer.AddRow(FsgtemporadasRow);
         nGXsfl_15_idx = (short)(((subFsgtemporadas_Islastpage==1)&&(nGXsfl_15_idx+1>subFsgtemporadas_Recordsperpage( )) ? 1 : nGXsfl_15_idx+1));
         sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
         SubsflControlProps_152( ) ;
         /* End function sendrow_152 */
      }

      protected void init_default_properties( )
      {
         lblTxttemporada_Internalname = "TXTTEMPORADA";
         imgAdicionar_Internalname = "ADICIONAR";
         bttBtneditar_Internalname = "BTNEDITAR";
         edtavEpisodionome_Internalname = "vEPISODIONOME";
         edtavEpisodioduracao_Internalname = "vEPISODIODURACAO";
         divTableepisodio_Internalname = "TABLEEPISODIO";
         edtavEpisodioid_Internalname = "vEPISODIOID";
         tblUnnamedtablecontentfsfsgepisodios_Internalname = "UNNAMEDTABLECONTENTFSFSGEPISODIOS";
         divUnnamedtablefsfsgepisodios_Internalname = "UNNAMEDTABLEFSFSGEPISODIOS";
         divTableone_Internalname = "TABLEONE";
         edtavTemporadanumero_Internalname = "vTEMPORADANUMERO";
         tblUnnamedtablecontentfsfsgtemporadas_Internalname = "UNNAMEDTABLECONTENTFSFSGTEMPORADAS";
         divUnnamedtablefsfsgtemporadas_Internalname = "UNNAMEDTABLEFSFSGTEMPORADAS";
         divTablecontent_Internalname = "TABLECONTENT";
         divTablemain_Internalname = "TABLEMAIN";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         subFsgepisodios_Internalname = "FSGEPISODIOS";
         subFsgtemporadas_Internalname = "FSGTEMPORADAS";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavTemporadanumero_Jsonclick = "";
         edtavTemporadanumero_Enabled = 1;
         subFsgepisodios_Allowcollapsing = 0;
         lblTxttemporada_Caption = "Temporada";
         divTableone_Width = 0;
         subFsgtemporadas_Class = "FreeStyleGrid";
         edtavEpisodioid_Jsonclick = "";
         edtavEpisodioduracao_Jsonclick = "";
         edtavEpisodioduracao_Enabled = 0;
         edtavEpisodioduracao_Visible = 1;
         edtavEpisodionome_Jsonclick = "";
         edtavEpisodionome_Enabled = 0;
         bttBtneditar_Visible = 1;
         subFsgepisodios_Class = "FreeStyleGrid";
         subFsgepisodios_Backcolorstyle = 0;
         subFsgtemporadas_Allowcollapsing = 0;
         lblTxttemporada_Caption = "Temporada";
         subFsgtemporadas_Backcolorstyle = 0;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Cadastro de episódios";
         edtavTemporadanumero_Visible = 1;
         edtavEpisodioid_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'FSGTEMPORADAS_nFirstRecordOnPage',nv:0},{av:'FSGTEMPORADAS_nEOF',nv:0},{av:'edtavTemporadanumero_Visible',ctrl:'vTEMPORADANUMERO',prop:'Visible'},{av:'A3SerieQuantidadeTemporadas',fld:'SERIEQUANTIDADETEMPORADAS',pic:'ZZZ9',nv:0},{av:'FSGEPISODIOS_nFirstRecordOnPage',nv:0},{av:'FSGEPISODIOS_nEOF',nv:0},{av:'edtavEpisodioid_Visible',ctrl:'vEPISODIOID',prop:'Visible'},{av:'A58EpisodioNumero',fld:'EPISODIONUMERO',pic:'ZZ9',nv:0},{av:'A1SerieId',fld:'SERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10SerieId',fld:'vSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'A42EpisodioTemporada',fld:'EPISODIOTEMPORADA',pic:'ZZZ9',nv:0},{av:'AV11TemporadaNumero',fld:'vTEMPORADANUMERO',pic:'ZZZ9',nv:0},{av:'A7EpisodioId',fld:'EPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'A8EpisodioNome',fld:'EPISODIONOME',pic:'',nv:''},{av:'A9EpisodioDuracao',fld:'EPISODIODURACAO',pic:'ZZZ',nv:0}],oparms:[{av:'divTableone_Width',ctrl:'TABLEONE',prop:'Width'}]}");
         setEventMetadata("FSGTEMPORADAS.LOAD","{handler:'E12262',iparms:[{av:'A1SerieId',fld:'SERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10SerieId',fld:'vSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'A3SerieQuantidadeTemporadas',fld:'SERIEQUANTIDADETEMPORADAS',pic:'ZZZ9',nv:0}],oparms:[{av:'lblTxttemporada_Caption',ctrl:'TXTTEMPORADA',prop:'Caption'},{av:'AV11TemporadaNumero',fld:'vTEMPORADANUMERO',pic:'ZZZ9',nv:0}]}");
         setEventMetadata("FSGEPISODIOS.LOAD","{handler:'E15264',iparms:[{av:'A58EpisodioNumero',fld:'EPISODIONUMERO',pic:'ZZ9',nv:0},{av:'A1SerieId',fld:'SERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10SerieId',fld:'vSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'A42EpisodioTemporada',fld:'EPISODIOTEMPORADA',pic:'ZZZ9',nv:0},{av:'AV11TemporadaNumero',fld:'vTEMPORADANUMERO',pic:'ZZZ9',nv:0},{av:'A7EpisodioId',fld:'EPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'A8EpisodioNome',fld:'EPISODIONOME',pic:'',nv:''},{av:'A9EpisodioDuracao',fld:'EPISODIODURACAO',pic:'ZZZ',nv:0}],oparms:[{ctrl:'BTNEDITAR',prop:'Visible'},{av:'edtavEpisodioduracao_Visible',ctrl:'vEPISODIODURACAO',prop:'Visible'},{av:'AV13EpisodioId',fld:'vEPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV14EpisodioNome',fld:'vEPISODIONOME',pic:'',nv:''},{av:'AV15EpisodioDuracao',fld:'vEPISODIODURACAO',pic:'',nv:''}]}");
         setEventMetadata("'DOADICIONAR'","{handler:'E13262',iparms:[{av:'FSGTEMPORADAS_nFirstRecordOnPage',nv:0},{av:'FSGTEMPORADAS_nEOF',nv:0},{av:'edtavTemporadanumero_Visible',ctrl:'vTEMPORADANUMERO',prop:'Visible'},{av:'A1SerieId',fld:'SERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV10SerieId',fld:'vSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'A3SerieQuantidadeTemporadas',fld:'SERIEQUANTIDADETEMPORADAS',pic:'ZZZ9',nv:0},{av:'AV11TemporadaNumero',fld:'vTEMPORADANUMERO',pic:'ZZZ9',nv:0},{av:'FSGEPISODIOS_nFirstRecordOnPage',nv:0},{av:'FSGEPISODIOS_nEOF',nv:0},{av:'edtavEpisodioid_Visible',ctrl:'vEPISODIOID',prop:'Visible'},{av:'A58EpisodioNumero',fld:'EPISODIONUMERO',pic:'ZZ9',nv:0},{av:'A42EpisodioTemporada',fld:'EPISODIOTEMPORADA',pic:'ZZZ9',nv:0},{av:'A7EpisodioId',fld:'EPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'A8EpisodioNome',fld:'EPISODIONOME',pic:'',nv:''},{av:'A9EpisodioDuracao',fld:'EPISODIODURACAO',pic:'ZZZ',nv:0}],oparms:[{av:'AV10SerieId',fld:'vSERIEID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0},{av:'AV11TemporadaNumero',fld:'vTEMPORADANUMERO',pic:'ZZZ9',nv:0},{av:'divTableone_Width',ctrl:'TABLEONE',prop:'Width'}]}");
         setEventMetadata("'DOEDITAR'","{handler:'E16264',iparms:[{av:'AV13EpisodioId',fld:'vEPISODIOID',pic:'ZZZZZZZZZZZZZZZZZ9',nv:0}],oparms:[]}");
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A8EpisodioNome = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         FsgtemporadasContainer = new GXWebGrid( context);
         sStyleString = "";
         FsgtemporadasColumn = new GXWebColumn();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV14EpisodioNome = "";
         AV15EpisodioDuracao = "";
         FsgepisodiosContainer = new GXWebGrid( context);
         scmdbuf = "";
         H00262_A1SerieId = new long[1] ;
         H00262_A3SerieQuantidadeTemporadas = new short[1] ;
         FsgtemporadasRow = new GXWebRow();
         H00263_A1SerieId = new long[1] ;
         H00263_A42EpisodioTemporada = new short[1] ;
         H00263_A7EpisodioId = new long[1] ;
         H00263_A8EpisodioNome = new String[] {""} ;
         H00263_A9EpisodioDuracao = new short[1] ;
         H00263_A58EpisodioNumero = new short[1] ;
         FsgepisodiosRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         subFsgepisodios_Linesclass = "";
         TempTags = "";
         bttBtneditar_Jsonclick = "";
         ROClassString = "";
         subFsgtemporadas_Linesclass = "";
         lblTxttemporada_Jsonclick = "";
         sImgUrl = "";
         imgAdicionar_Jsonclick = "";
         FsgepisodiosColumn = new GXWebColumn();
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cadastrotemporadas__default(),
            new Object[][] {
                new Object[] {
               H00262_A1SerieId, H00262_A3SerieQuantidadeTemporadas
               }
               , new Object[] {
               H00263_A1SerieId, H00263_A42EpisodioTemporada, H00263_A7EpisodioId, H00263_A8EpisodioNome, H00263_A9EpisodioDuracao, H00263_A58EpisodioNumero
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavEpisodionome_Enabled = 0;
         edtavEpisodioduracao_Enabled = 0;
      }

      private short nRC_GXsfl_28 ;
      private short nGXsfl_28_idx=1 ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_15 ;
      private short A58EpisodioNumero ;
      private short A42EpisodioTemporada ;
      private short AV11TemporadaNumero ;
      private short A9EpisodioDuracao ;
      private short nGXsfl_15_idx=1 ;
      private short A3SerieQuantidadeTemporadas ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subFsgtemporadas_Backcolorstyle ;
      private short subFsgtemporadas_Allowselection ;
      private short subFsgtemporadas_Allowhovering ;
      private short subFsgtemporadas_Allowcollapsing ;
      private short subFsgtemporadas_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subFsgepisodios_Backcolorstyle ;
      private short AV12SerieQuantidadeTemporadas ;
      private short AV9i ;
      private short FSGTEMPORADAS_nEOF ;
      private short FSGEPISODIOS_nEOF ;
      private short AV16Count ;
      private short AV20GXLvl45 ;
      private short subFsgepisodios_Backstyle ;
      private short subFsgtemporadas_Backstyle ;
      private short subFsgepisodios_Allowselection ;
      private short subFsgepisodios_Allowhovering ;
      private short subFsgepisodios_Allowcollapsing ;
      private short subFsgepisodios_Collapsed ;
      private int edtavTemporadanumero_Visible ;
      private int edtavEpisodioid_Visible ;
      private int subFsgtemporadas_Selectioncolor ;
      private int subFsgtemporadas_Hoveringcolor ;
      private int subFsgtemporadas_Islastpage ;
      private int subFsgepisodios_Islastpage ;
      private int edtavEpisodionome_Enabled ;
      private int edtavEpisodioduracao_Enabled ;
      private int divTableone_Width ;
      private int bttBtneditar_Visible ;
      private int edtavEpisodioduracao_Visible ;
      private int idxLst ;
      private int subFsgepisodios_Backcolor ;
      private int subFsgepisodios_Allbackcolor ;
      private int subFsgtemporadas_Backcolor ;
      private int subFsgtemporadas_Allbackcolor ;
      private int imgAdicionar_Enabled ;
      private int imgAdicionar_Visible ;
      private int subFsgepisodios_Selectioncolor ;
      private int subFsgepisodios_Hoveringcolor ;
      private int edtavTemporadanumero_Enabled ;
      private long AV10SerieId ;
      private long wcpOAV10SerieId ;
      private long A1SerieId ;
      private long A7EpisodioId ;
      private long AV13EpisodioId ;
      private long FSGEPISODIOS_nCurrentRecord ;
      private long FSGTEMPORADAS_nCurrentRecord ;
      private long FSGTEMPORADAS_nFirstRecordOnPage ;
      private long FSGEPISODIOS_nFirstRecordOnPage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_28_idx="0001" ;
      private String edtavEpisodioid_Internalname ;
      private String GXKey ;
      private String sGXsfl_15_idx="0001" ;
      private String edtavTemporadanumero_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String sStyleString ;
      private String subFsgtemporadas_Internalname ;
      private String lblTxttemporada_Caption ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavEpisodionome_Internalname ;
      private String edtavEpisodioduracao_Internalname ;
      private String scmdbuf ;
      private String divTableone_Internalname ;
      private String bttBtneditar_Internalname ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String subFsgepisodios_Class ;
      private String subFsgepisodios_Linesclass ;
      private String divUnnamedtablefsfsgepisodios_Internalname ;
      private String divTableepisodio_Internalname ;
      private String TempTags ;
      private String bttBtneditar_Jsonclick ;
      private String ROClassString ;
      private String edtavEpisodionome_Jsonclick ;
      private String edtavEpisodioduracao_Jsonclick ;
      private String tblUnnamedtablecontentfsfsgepisodios_Internalname ;
      private String edtavEpisodioid_Jsonclick ;
      private String lblTxttemporada_Internalname ;
      private String imgAdicionar_Internalname ;
      private String subFsgepisodios_Internalname ;
      private String sGXsfl_15_fel_idx="0001" ;
      private String subFsgtemporadas_Class ;
      private String subFsgtemporadas_Linesclass ;
      private String divUnnamedtablefsfsgtemporadas_Internalname ;
      private String lblTxttemporada_Jsonclick ;
      private String sImgUrl ;
      private String imgAdicionar_Jsonclick ;
      private String GXCCtl ;
      private String tblUnnamedtablecontentfsfsgtemporadas_Internalname ;
      private String edtavTemporadanumero_Jsonclick ;
      private bool entryPointCalled ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool bGXsfl_15_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private String A8EpisodioNome ;
      private String AV14EpisodioNome ;
      private String AV15EpisodioDuracao ;
      private GXWebGrid FsgtemporadasContainer ;
      private GXWebGrid FsgepisodiosContainer ;
      private GXWebRow FsgtemporadasRow ;
      private GXWebRow FsgepisodiosRow ;
      private GXWebColumn FsgtemporadasColumn ;
      private GXWebColumn FsgepisodiosColumn ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H00262_A1SerieId ;
      private short[] H00262_A3SerieQuantidadeTemporadas ;
      private long[] H00263_A1SerieId ;
      private short[] H00263_A42EpisodioTemporada ;
      private long[] H00263_A7EpisodioId ;
      private String[] H00263_A8EpisodioNome ;
      private short[] H00263_A9EpisodioDuracao ;
      private short[] H00263_A58EpisodioNumero ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class cadastrotemporadas__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00262 ;
          prmH00262 = new Object[] {
          new Object[] {"@AV10SerieId",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmH00263 ;
          prmH00263 = new Object[] {
          new Object[] {"@AV10SerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV11TemporadaNumero",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00262", "SELECT [SerieId], [SerieQuantidadeTemporadas] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @AV10SerieId ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00262,1,0,false,true )
             ,new CursorDef("H00263", "SELECT [SerieId], [EpisodioTemporada], [EpisodioId], [EpisodioNome], [EpisodioDuracao], [EpisodioNumero] FROM [Episodio] WITH (NOLOCK) WHERE ([SerieId] = @AV10SerieId) AND ([EpisodioTemporada] = @AV11TemporadaNumero) ORDER BY [EpisodioNumero] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00263,100,0,false,false )
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
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
