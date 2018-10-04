/*
               File: WWPBaseObjects.WizardStepsBulletWC
        Description: Wizard Steps Bullet WC.
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:23.80
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class wizardstepsbulletwc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public wizardstepsbulletwc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
      }

      public wizardstepsbulletwc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem> aP0_WizardSteps ,
                           String aP1_CurrentStep )
      {
         this.AV11WizardSteps = aP0_WizardSteps;
         this.AV8CurrentStep = aP1_CurrentStep;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  ajax_req_read_hidden_sdt(GetNextPar( ), AV11WizardSteps);
                  AV8CurrentStep = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8CurrentStep", AV8CurrentStep);
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem>)AV11WizardSteps,(String)AV8CurrentStep});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridwizardsteps") == 0 )
               {
                  nRC_GXsfl_5 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_5_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_5_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxnrGridwizardsteps_newrow( ) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Gridwizardsteps") == 0 )
               {
                  AV9StepNumber = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV12SelectedStepNumber = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGridwizardsteps_refresh( AV9StepNumber, AV12SelectedStepNumber, sPrefix) ;
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
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA0E2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               edtavWizardsteps__title_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavWizardsteps__title_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavWizardsteps__title_Enabled), 5, 0)), !bGXsfl_5_Refreshing);
               WS0E2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, false);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Wizard Steps Bullet WC.") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 121631), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 121631), false);
         context.AddJavascriptSource("gxcfg.js", "?201892019382387", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" data-gx-class=\"Form\" novalidate action=\""+formatLink("wwpbaseobjects.wizardstepsbulletwc.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8CurrentStep))+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
               context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "Form", true);
            }
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
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
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"Wizardsteps", AV11WizardSteps);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"Wizardsteps", AV11WizardSteps);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_5", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_5), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8CurrentStep", wcpOAV8CurrentStep);
         GxWebStd.gx_hidden_field( context, sPrefix+"vSTEPNUMBER", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9StepNumber), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vSTEPNUMBER", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(AV9StepNumber), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"vSELECTEDSTEPNUMBER", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12SelectedStepNumber), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vSELECTEDSTEPNUMBER", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(AV12SelectedStepNumber), "ZZZ9"), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vWIZARDSTEPS", AV11WizardSteps);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vWIZARDSTEPS", AV11WizardSteps);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"vCURRENTSTEP", AV8CurrentStep);
      }

      protected void RenderHtmlCloseForm0E2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("wwpbaseobjects/wizardstepsbulletwc.js", "?201892019382390", false);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.WizardStepsBulletWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Wizard Steps Bullet WC." ;
      }

      protected void WB0E0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "wwpbaseobjects.wizardstepsbulletwc.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_0E2( true) ;
         }
         else
         {
            wb_table1_2_0E2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0E2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true;
      }

      protected void START0E2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
               Form.Meta.addItem("description", "Wizard Steps Bullet WC.", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP0E0( ) ;
            }
         }
      }

      protected void WS0E2( )
      {
         START0E2( ) ;
         EVT0E2( ) ;
      }

      protected void EVT0E2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1);
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0E0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0E0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 20), "GRIDWIZARDSTEPS.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0E0( ) ;
                              }
                              nGXsfl_5_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0");
                              SubsflControlProps_52( ) ;
                              AV17GXV1 = nGXsfl_5_idx;
                              if ( ( AV11WizardSteps.Count >= AV17GXV1 ) && ( AV17GXV1 > 0 ) )
                              {
                                 AV11WizardSteps.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem)AV11WizardSteps.Item(AV17GXV1));
                              }
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: Start */
                                          E110E2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRIDWIZARDSTEPS.LOAD") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          E120E2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          if ( ! wbErr )
                                          {
                                             Rfr0gs = false;
                                             if ( ! Rfr0gs )
                                             {
                                             }
                                             dynload_actions( ) ;
                                          }
                                       }
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP0E0( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                       }
                                    }
                                 }
                              }
                              else
                              {
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

      protected void WE0E2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0E2( ) ;
            }
         }
      }

      protected void PA0E2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
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

      protected void gxnrGridwizardsteps_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_52( ) ;
         while ( nGXsfl_5_idx <= nRC_GXsfl_5 )
         {
            sendrow_52( ) ;
            nGXsfl_5_idx = (short)(((subGridwizardsteps_Islastpage==1)&&(nGXsfl_5_idx+1>subGridwizardsteps_Recordsperpage( )) ? 1 : nGXsfl_5_idx+1));
            sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0");
            SubsflControlProps_52( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridwizardstepsContainer));
         /* End function gxnrGridwizardsteps_newrow */
      }

      protected void gxgrGridwizardsteps_refresh( short AV9StepNumber ,
                                                  short AV12SelectedStepNumber ,
                                                  String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRIDWIZARDSTEPS_nCurrentRecord = 0;
         RF0E2( ) ;
         /* End function gxgrGridwizardsteps_refresh */
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
         RF0E2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavWizardsteps__title_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavWizardsteps__title_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavWizardsteps__title_Enabled), 5, 0)), !bGXsfl_5_Refreshing);
      }

      protected void RF0E2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridwizardstepsContainer.ClearRows();
         }
         wbStart = 5;
         nGXsfl_5_idx = 1;
         sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0");
         SubsflControlProps_52( ) ;
         bGXsfl_5_Refreshing = true;
         GridwizardstepsContainer.AddObjectProperty("GridName", "Gridwizardsteps");
         GridwizardstepsContainer.AddObjectProperty("CmpContext", sPrefix);
         GridwizardstepsContainer.AddObjectProperty("InMasterPage", "false");
         GridwizardstepsContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleSteps"));
         GridwizardstepsContainer.AddObjectProperty("Class", "FreeStyleSteps");
         GridwizardstepsContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridwizardstepsContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridwizardstepsContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridwizardsteps_Backcolorstyle), 1, 0, ".", "")));
         GridwizardstepsContainer.PageSize = subGridwizardsteps_Recordsperpage( );
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_52( ) ;
            E120E2 ();
            wbEnd = 5;
            WB0E0( ) ;
         }
         bGXsfl_5_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0E2( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"vSTEPNUMBER", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9StepNumber), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vSTEPNUMBER", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(AV9StepNumber), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"vSELECTEDSTEPNUMBER", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12SelectedStepNumber), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vSELECTEDSTEPNUMBER", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(AV12SelectedStepNumber), "ZZZ9"), context));
      }

      protected int subGridwizardsteps_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGridwizardsteps_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGridwizardsteps_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGridwizardsteps_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP0E0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavWizardsteps__title_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavWizardsteps__title_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavWizardsteps__title_Enabled), 5, 0)), !bGXsfl_5_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110E2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"Wizardsteps"), AV11WizardSteps);
            /* Read variables values. */
            /* Read saved values. */
            nRC_GXsfl_5 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_5"), ",", "."));
            wcpOAV8CurrentStep = cgiGet( sPrefix+"wcpOAV8CurrentStep");
            nRC_GXsfl_5 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_5"), ",", "."));
            nGXsfl_5_fel_idx = 0;
            while ( nGXsfl_5_fel_idx < nRC_GXsfl_5 )
            {
               nGXsfl_5_fel_idx = (short)(((subGridwizardsteps_Islastpage==1)&&(nGXsfl_5_fel_idx+1>subGridwizardsteps_Recordsperpage( )) ? 1 : nGXsfl_5_fel_idx+1));
               sGXsfl_5_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_fel_idx), 4, 0)), 4, "0");
               SubsflControlProps_fel_52( ) ;
               AV17GXV1 = nGXsfl_5_fel_idx;
               if ( ( AV11WizardSteps.Count >= AV17GXV1 ) && ( AV17GXV1 > 0 ) )
               {
                  AV11WizardSteps.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem)AV11WizardSteps.Item(AV17GXV1));
               }
            }
            if ( nGXsfl_5_fel_idx == 0 )
            {
               nGXsfl_5_idx = 1;
               sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0");
               SubsflControlProps_52( ) ;
            }
            nGXsfl_5_fel_idx = 1;
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
         E110E2 ();
         if (returnInSub) return;
      }

      protected void E110E2( )
      {
         /* Start Routine */
         AV12SelectedStepNumber = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12SelectedStepNumber", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12SelectedStepNumber), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, sPrefix+"gxhash_vSELECTEDSTEPNUMBER", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(AV12SelectedStepNumber), "ZZZ9"), context));
         AV19GXV3 = 1;
         while ( AV19GXV3 <= AV11WizardSteps.Count )
         {
            AV5WizardStep = ((GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem)AV11WizardSteps.Item(AV19GXV3));
            if ( StringUtil.StrCmp(AV5WizardStep.gxTpr_Code, AV8CurrentStep) == 0 )
            {
               if (true) break;
            }
            else
            {
               AV12SelectedStepNumber = (short)(AV12SelectedStepNumber+1);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12SelectedStepNumber", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12SelectedStepNumber), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, sPrefix+"gxhash_vSELECTEDSTEPNUMBER", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(AV12SelectedStepNumber), "ZZZ9"), context));
            }
            AV19GXV3 = (int)(AV19GXV3+1);
         }
         AV9StepNumber = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9StepNumber", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9StepNumber), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, sPrefix+"gxhash_vSTEPNUMBER", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(AV9StepNumber), "ZZZ9"), context));
      }

      private void E120E2( )
      {
         /* Gridwizardsteps_Load Routine */
         AV17GXV1 = 1;
         while ( AV17GXV1 <= AV11WizardSteps.Count )
         {
            AV11WizardSteps.CurrentItem = ((GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem)AV11WizardSteps.Item(AV17GXV1));
            AV10TableContainerStepClass = "TableContainerStep";
            lblStepnumber_Visible = 0;
            lblStepnumber_Caption = context.localUtil.Format( (decimal)(AV9StepNumber), "ZZZ9");
            tblTablestepbulletlineleft_Class = "TableStepBulletLine";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, tblTablestepbulletlineleft_Internalname, "Class", tblTablestepbulletlineleft_Class, !bGXsfl_5_Refreshing);
            tblTablestepbulletlineright_Class = "TableStepBulletLine";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, tblTablestepbulletlineright_Internalname, "Class", tblTablestepbulletlineright_Class, !bGXsfl_5_Refreshing);
            if ( AV9StepNumber < AV12SelectedStepNumber )
            {
               divTablestepitem_Class = "TableStepBulletChecked";
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divTablestepitem_Internalname, "Class", divTablestepitem_Class, !bGXsfl_5_Refreshing);
               tblTablestepbulletlineleft_Class = "TableStepBulletLineChecked";
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, tblTablestepbulletlineleft_Internalname, "Class", tblTablestepbulletlineleft_Class, !bGXsfl_5_Refreshing);
               tblTablestepbulletlineright_Class = "TableStepBulletLineChecked";
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, tblTablestepbulletlineright_Internalname, "Class", tblTablestepbulletlineright_Class, !bGXsfl_5_Refreshing);
               edtavWizardsteps__title_Class = "AttributeStepBullet";
            }
            else if ( AV9StepNumber == AV12SelectedStepNumber )
            {
               lblStepnumber_Visible = 1;
               lblStepnumber_Class = "StepNumberBulletSelected";
               divTablestepitem_Class = "TableStepBulletSelected";
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divTablestepitem_Internalname, "Class", divTablestepitem_Class, !bGXsfl_5_Refreshing);
               tblTablestepbulletlineleft_Class = "TableStepBulletLineChecked";
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, tblTablestepbulletlineleft_Internalname, "Class", tblTablestepbulletlineleft_Class, !bGXsfl_5_Refreshing);
               edtavWizardsteps__title_Class = "AttributeStepBulletSelected";
            }
            else if ( AV9StepNumber > AV12SelectedStepNumber )
            {
               lblStepnumber_Class = "StepNumberBullet";
               lblStepnumber_Visible = 1;
               divTablestepitem_Class = "TableStepBullet";
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divTablestepitem_Internalname, "Class", divTablestepitem_Class, !bGXsfl_5_Refreshing);
               edtavWizardsteps__title_Class = "AttributeStepBulletUnSelected";
            }
            AV9StepNumber = (short)(AV9StepNumber+1);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9StepNumber", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9StepNumber), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, sPrefix+"gxhash_vSTEPNUMBER", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(AV9StepNumber), "ZZZ9"), context));
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 5;
            }
            sendrow_52( ) ;
            if ( isFullAjaxMode( ) && ! bGXsfl_5_Refreshing )
            {
               context.DoAjaxLoad(5, GridwizardstepsRow);
            }
            AV17GXV1 = (short)(AV17GXV1+1);
         }
         /*  Sending Event outputs  */
      }

      protected void wb_table1_2_0E2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableWizardSteps TableAlignedCentered", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='WizardStepsContainerCell'>") ;
            /*  Grid Control  */
            GridwizardstepsContainer.SetIsFreestyle(true);
            GridwizardstepsContainer.SetWrapped(nGXWrapped);
            if ( GridwizardstepsContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridwizardstepsContainer"+"DivS\" data-gxgridid=\"5\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGridwizardsteps_Internalname, subGridwizardsteps_Internalname, "", "FreeStyleSteps", 0, "", "", 1, 2, sStyleString, "", 0);
               GridwizardstepsContainer.AddObjectProperty("GridName", "Gridwizardsteps");
            }
            else
            {
               GridwizardstepsContainer.AddObjectProperty("GridName", "Gridwizardsteps");
               GridwizardstepsContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleSteps"));
               GridwizardstepsContainer.AddObjectProperty("Class", "FreeStyleSteps");
               GridwizardstepsContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridwizardstepsContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridwizardstepsContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridwizardsteps_Backcolorstyle), 1, 0, ".", "")));
               GridwizardstepsContainer.AddObjectProperty("CmpContext", sPrefix);
               GridwizardstepsContainer.AddObjectProperty("InMasterPage", "false");
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsColumn.AddObjectProperty("Value", lblDummybulletlineleft_Caption);
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsColumn.AddObjectProperty("Value", lblStepnumber_Caption);
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsColumn.AddObjectProperty("Value", lblDummybulletlineleft_Caption);
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridwizardstepsColumn.AddObjectProperty("Class", StringUtil.RTrim( edtavWizardsteps__title_Class));
               GridwizardstepsColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavWizardsteps__title_Enabled), 5, 0, ".", "")));
               GridwizardstepsContainer.AddColumnProperties(GridwizardstepsColumn);
               GridwizardstepsContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridwizardsteps_Allowselection), 1, 0, ".", "")));
               GridwizardstepsContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridwizardsteps_Selectioncolor), 9, 0, ".", "")));
               GridwizardstepsContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridwizardsteps_Allowhovering), 1, 0, ".", "")));
               GridwizardstepsContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridwizardsteps_Hoveringcolor), 9, 0, ".", "")));
               GridwizardstepsContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridwizardsteps_Allowcollapsing), 1, 0, ".", "")));
               GridwizardstepsContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridwizardsteps_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 5 )
         {
            wbEnd = 0;
            nRC_GXsfl_5 = (short)(nGXsfl_5_idx-1);
            if ( GridwizardstepsContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               AV17GXV1 = nGXsfl_5_idx;
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridwizardstepsContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Gridwizardsteps", GridwizardstepsContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridwizardstepsContainerData", GridwizardstepsContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridwizardstepsContainerData"+"V", GridwizardstepsContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input autocomplete=\"off\" type=\"hidden\" "+"name=\""+sPrefix+"GridwizardstepsContainerData"+"V"+"\" value='"+GridwizardstepsContainer.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0E2e( true) ;
         }
         else
         {
            wb_table1_2_0E2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11WizardSteps = (GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem>)getParm(obj,0);
         AV8CurrentStep = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8CurrentStep", AV8CurrentStep);
      }

      public override String getresponse( String sGXDynURL )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA0E2( ) ;
         WS0E2( ) ;
         WE0E2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV11WizardSteps = (String)((String)getParm(obj,0));
         sCtrlAV8CurrentStep = (String)((String)getParm(obj,1));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0E2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "wwpbaseobjects\\wizardstepsbulletwc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA0E2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV11WizardSteps = (GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem>)getParm(obj,2);
            AV8CurrentStep = (String)getParm(obj,3);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8CurrentStep", AV8CurrentStep);
         }
         wcpOAV8CurrentStep = cgiGet( sPrefix+"wcpOAV8CurrentStep");
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV8CurrentStep, wcpOAV8CurrentStep) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV8CurrentStep = AV8CurrentStep;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV11WizardSteps = cgiGet( sPrefix+"AV11WizardSteps_CTRL");
         if ( StringUtil.Len( sCtrlAV11WizardSteps) > 0 )
         {
            AV11WizardSteps = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem>();
         }
         else
         {
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"AV11WizardSteps_PARM"), AV11WizardSteps);
         }
         sCtrlAV8CurrentStep = cgiGet( sPrefix+"AV8CurrentStep_CTRL");
         if ( StringUtil.Len( sCtrlAV8CurrentStep) > 0 )
         {
            AV8CurrentStep = cgiGet( sCtrlAV8CurrentStep);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8CurrentStep", AV8CurrentStep);
         }
         else
         {
            AV8CurrentStep = cgiGet( sPrefix+"AV8CurrentStep_PARM");
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA0E2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0E2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS0E2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"AV11WizardSteps_PARM", AV11WizardSteps);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"AV11WizardSteps_PARM", AV11WizardSteps);
         }
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV11WizardSteps)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV11WizardSteps_CTRL", StringUtil.RTrim( sCtrlAV11WizardSteps));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8CurrentStep_PARM", AV8CurrentStep);
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8CurrentStep)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8CurrentStep_CTRL", StringUtil.RTrim( sCtrlAV8CurrentStep));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE0E2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), false);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019382432", true);
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
            context.AddJavascriptSource("wwpbaseobjects/wizardstepsbulletwc.js", "?201892019382432", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_52( )
      {
         lblDummybulletlineleft_Internalname = sPrefix+"DUMMYBULLETLINELEFT_"+sGXsfl_5_idx;
         lblStepnumber_Internalname = sPrefix+"STEPNUMBER_"+sGXsfl_5_idx;
         lblDummybulletlineright_Internalname = sPrefix+"DUMMYBULLETLINERIGHT_"+sGXsfl_5_idx;
         edtavWizardsteps__title_Internalname = sPrefix+"WIZARDSTEPS__TITLE_"+sGXsfl_5_idx;
      }

      protected void SubsflControlProps_fel_52( )
      {
         lblDummybulletlineleft_Internalname = sPrefix+"DUMMYBULLETLINELEFT_"+sGXsfl_5_fel_idx;
         lblStepnumber_Internalname = sPrefix+"STEPNUMBER_"+sGXsfl_5_fel_idx;
         lblDummybulletlineright_Internalname = sPrefix+"DUMMYBULLETLINERIGHT_"+sGXsfl_5_fel_idx;
         edtavWizardsteps__title_Internalname = sPrefix+"WIZARDSTEPS__TITLE_"+sGXsfl_5_fel_idx;
      }

      protected void sendrow_52( )
      {
         SubsflControlProps_52( ) ;
         WB0E0( ) ;
         GridwizardstepsRow = GXWebRow.GetNew(context,GridwizardstepsContainer);
         if ( subGridwizardsteps_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridwizardsteps_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridwizardsteps_Class, "") != 0 )
            {
               subGridwizardsteps_Linesclass = subGridwizardsteps_Class+"Odd";
            }
         }
         else if ( subGridwizardsteps_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridwizardsteps_Backstyle = 0;
            subGridwizardsteps_Backcolor = subGridwizardsteps_Allbackcolor;
            if ( StringUtil.StrCmp(subGridwizardsteps_Class, "") != 0 )
            {
               subGridwizardsteps_Linesclass = subGridwizardsteps_Class+"Uniform";
            }
         }
         else if ( subGridwizardsteps_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridwizardsteps_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridwizardsteps_Class, "") != 0 )
            {
               subGridwizardsteps_Linesclass = subGridwizardsteps_Class+"Odd";
            }
            subGridwizardsteps_Backcolor = (int)(0xFFFFFF);
         }
         else if ( subGridwizardsteps_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridwizardsteps_Backstyle = 1;
            if ( ((int)(((nGXsfl_5_idx-1)/ (decimal)(0)) % (2))) == 0 )
            {
               subGridwizardsteps_Backcolor = (int)(0xFFFFFF);
               if ( StringUtil.StrCmp(subGridwizardsteps_Class, "") != 0 )
               {
                  subGridwizardsteps_Linesclass = subGridwizardsteps_Class+"Odd";
               }
            }
            else
            {
               subGridwizardsteps_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridwizardsteps_Class, "") != 0 )
               {
                  subGridwizardsteps_Linesclass = subGridwizardsteps_Class+"Even";
               }
            }
         }
         /* Start of Columns property logic. */
         GridwizardstepsRow.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)subGridwizardsteps_Linesclass,(String)""});
         GridwizardstepsRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",""+" style=\""+CSSHelper.Prettify( "vertical-align:top")+"\""});
         /* Table start */
         GridwizardstepsRow.AddColumnProperties("table", -1, isAjaxCallMode( ), new Object[] {(String)tblTblcontainerstep_Internalname+"_"+sGXsfl_5_idx,(short)1,(String)"TableContainerStepBullet",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)0,(short)0,(String)"",(String)"",(String)"",(String)"px",(String)"px"});
         GridwizardstepsRow.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         GridwizardstepsRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Table start */
         GridwizardstepsRow.AddColumnProperties("table", -1, isAjaxCallMode( ), new Object[] {(String)tblTablestepbulletline_Internalname+"_"+sGXsfl_5_idx,(short)1,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(short)2,(String)"",(String)"",(String)"",(String)"px",(String)"px"});
         GridwizardstepsRow.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         GridwizardstepsRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Table start */
         GridwizardstepsRow.AddColumnProperties("table", -1, isAjaxCallMode( ), new Object[] {(String)tblTablestepbulletlineleft_Internalname+"_"+sGXsfl_5_idx,(short)1,(String)tblTablestepbulletlineleft_Class,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)0,(short)0,(String)"",(String)"",(String)"",(String)"px",(String)"px"});
         GridwizardstepsRow.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         GridwizardstepsRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Text block */
         GridwizardstepsRow.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblDummybulletlineleft_Internalname,(String)" ",(String)"",(String)"",(String)lblDummybulletlineleft_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("cell");
         }
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("row");
         }
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("table");
         }
         /* End of table */
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("cell");
         }
         GridwizardstepsRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Div Control */
         GridwizardstepsRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divLayout_tablestepitem_Internalname+"_"+sGXsfl_5_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Section",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         GridwizardstepsRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Section",(String)"left",(String)"top",(String)" "+"data-abstract-form"+" ",(String)"",(String)"div"});
         /* Div Control */
         GridwizardstepsRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divTablestepitem_Internalname+"_"+sGXsfl_5_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)divTablestepitem_Class,(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         GridwizardstepsRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         GridwizardstepsRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 StepNumberBulletCell",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Text block */
         GridwizardstepsRow.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblStepnumber_Internalname,(String)lblStepnumber_Caption,(String)"",(String)"",(String)lblStepnumber_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)lblStepnumber_Class,(short)0,(String)"",(int)lblStepnumber_Visible,(short)1,(short)0});
         GridwizardstepsRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         GridwizardstepsRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         GridwizardstepsRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         GridwizardstepsRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         GridwizardstepsRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("cell");
         }
         GridwizardstepsRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Table start */
         GridwizardstepsRow.AddColumnProperties("table", -1, isAjaxCallMode( ), new Object[] {(String)tblTablestepbulletlineright_Internalname+"_"+sGXsfl_5_idx,(short)1,(String)tblTablestepbulletlineright_Class,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)0,(short)0,(String)"",(String)"",(String)"",(String)"px",(String)"px"});
         GridwizardstepsRow.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         GridwizardstepsRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Text block */
         GridwizardstepsRow.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblDummybulletlineright_Internalname,(String)" ",(String)"",(String)"",(String)lblDummybulletlineright_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("cell");
         }
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("row");
         }
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("table");
         }
         /* End of table */
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("cell");
         }
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("row");
         }
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("table");
         }
         /* End of table */
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("cell");
         }
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("row");
         }
         sendrow_5230( ) ;
      }

      protected void sendrow_5230( )
      {
         GridwizardstepsRow.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         GridwizardstepsRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Single line edit */
         ROClassString = edtavWizardsteps__title_Class;
         GridwizardstepsRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavWizardsteps__title_Internalname,((GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem)AV11WizardSteps.Item(AV17GXV1)).gxTpr_Title,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavWizardsteps__title_Jsonclick,(short)0,(String)edtavWizardsteps__title_Class,(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtavWizardsteps__title_Enabled,(short)0,(String)"text",(String)"",(short)40,(String)"chr",(short)1,(String)"row",(short)40,(short)0,(short)0,(short)5,(short)1,(short)-1,(short)-1,(bool)false,(String)"",(String)"left",(bool)true});
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("cell");
         }
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("row");
         }
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("table");
         }
         /* End of table */
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("cell");
         }
         if ( GridwizardstepsContainer.GetWrapped() == 1 )
         {
            GridwizardstepsContainer.CloseTag("row");
         }
         send_integrity_lvl_hashes0E2( ) ;
         /* End of Columns property logic. */
         GridwizardstepsContainer.AddRow(GridwizardstepsRow);
         nGXsfl_5_idx = (short)(((subGridwizardsteps_Islastpage==1)&&(nGXsfl_5_idx+1>subGridwizardsteps_Recordsperpage( )) ? 1 : nGXsfl_5_idx+1));
         sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0");
         SubsflControlProps_52( ) ;
         /* End function sendrow_52 */
      }

      protected void init_default_properties( )
      {
         lblDummybulletlineleft_Internalname = sPrefix+"DUMMYBULLETLINELEFT";
         tblTablestepbulletlineleft_Internalname = sPrefix+"TABLESTEPBULLETLINELEFT";
         lblStepnumber_Internalname = sPrefix+"STEPNUMBER";
         divTablestepitem_Internalname = sPrefix+"TABLESTEPITEM";
         divLayout_tablestepitem_Internalname = sPrefix+"LAYOUT_TABLESTEPITEM";
         lblDummybulletlineright_Internalname = sPrefix+"DUMMYBULLETLINERIGHT";
         tblTablestepbulletlineright_Internalname = sPrefix+"TABLESTEPBULLETLINERIGHT";
         tblTablestepbulletline_Internalname = sPrefix+"TABLESTEPBULLETLINE";
         edtavWizardsteps__title_Internalname = sPrefix+"WIZARDSTEPS__TITLE";
         tblTblcontainerstep_Internalname = sPrefix+"TBLCONTAINERSTEP";
         tblTablemain_Internalname = sPrefix+"TABLEMAIN";
         Form.Internalname = sPrefix+"FORM";
         subGridwizardsteps_Internalname = sPrefix+"GRIDWIZARDSTEPS";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtavWizardsteps__title_Jsonclick = "";
         lblStepnumber_Class = "StepNumberBullet";
         lblStepnumber_Caption = "1";
         lblStepnumber_Visible = 1;
         subGridwizardsteps_Class = "FreeStyleSteps";
         subGridwizardsteps_Allowcollapsing = 0;
         edtavWizardsteps__title_Enabled = 0;
         edtavWizardsteps__title_Class = "AttributeStepBulletUnSelected";
         lblStepnumber_Caption = "1";
         lblDummybulletlineleft_Caption = " ";
         divTablestepitem_Class = "TableStepBullet";
         tblTablestepbulletlineright_Class = "TableStepBulletLine";
         tblTablestepbulletlineleft_Class = "TableStepBulletLine";
         subGridwizardsteps_Backcolorstyle = 0;
         edtavWizardsteps__title_Enabled = -1;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRIDWIZARDSTEPS_nFirstRecordOnPage',nv:0},{av:'GRIDWIZARDSTEPS_nEOF',nv:0},{av:'AV11WizardSteps',fld:'vWIZARDSTEPS',grid:5,pic:'',nv:null},{av:'sPrefix',nv:''},{av:'AV9StepNumber',fld:'vSTEPNUMBER',pic:'ZZZ9',hsh:true,nv:0},{av:'AV12SelectedStepNumber',fld:'vSELECTEDSTEPNUMBER',pic:'ZZZ9',hsh:true,nv:0}],oparms:[]}");
         setEventMetadata("GRIDWIZARDSTEPS.LOAD","{handler:'E120E2',iparms:[{av:'AV9StepNumber',fld:'vSTEPNUMBER',pic:'ZZZ9',hsh:true,nv:0},{av:'AV12SelectedStepNumber',fld:'vSELECTEDSTEPNUMBER',pic:'ZZZ9',hsh:true,nv:0}],oparms:[{av:'lblStepnumber_Visible',ctrl:'STEPNUMBER',prop:'Visible'},{av:'lblStepnumber_Caption',ctrl:'STEPNUMBER',prop:'Caption'},{av:'tblTablestepbulletlineleft_Class',ctrl:'TABLESTEPBULLETLINELEFT',prop:'Class'},{av:'tblTablestepbulletlineright_Class',ctrl:'TABLESTEPBULLETLINERIGHT',prop:'Class'},{av:'divTablestepitem_Class',ctrl:'TABLESTEPITEM',prop:'Class'},{ctrl:'WIZARDSTEPS__TITLE',prop:'Class'},{av:'lblStepnumber_Class',ctrl:'STEPNUMBER',prop:'Class'},{av:'AV9StepNumber',fld:'vSTEPNUMBER',pic:'ZZZ9',hsh:true,nv:0}]}");
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
         AV11WizardSteps = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem>( context, "WizardStepsItem", "SeriesColaborativas");
         wcpOAV8CurrentStep = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GridwizardstepsContainer = new GXWebGrid( context);
         AV5WizardStep = new GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem(context);
         AV10TableContainerStepClass = "";
         GridwizardstepsRow = new GXWebRow();
         sStyleString = "";
         GridwizardstepsColumn = new GXWebColumn();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV11WizardSteps = "";
         sCtrlAV8CurrentStep = "";
         subGridwizardsteps_Linesclass = "";
         lblDummybulletlineleft_Jsonclick = "";
         lblStepnumber_Jsonclick = "";
         lblDummybulletlineright_Jsonclick = "";
         ROClassString = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavWizardsteps__title_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_5 ;
      private short nGXsfl_5_idx=1 ;
      private short AV9StepNumber ;
      private short AV12SelectedStepNumber ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short AV17GXV1 ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGridwizardsteps_Backcolorstyle ;
      private short nGXsfl_5_fel_idx=1 ;
      private short subGridwizardsteps_Allowselection ;
      private short subGridwizardsteps_Allowhovering ;
      private short subGridwizardsteps_Allowcollapsing ;
      private short subGridwizardsteps_Collapsed ;
      private short subGridwizardsteps_Backstyle ;
      private short GRIDWIZARDSTEPS_nEOF ;
      private int edtavWizardsteps__title_Enabled ;
      private int subGridwizardsteps_Islastpage ;
      private int AV19GXV3 ;
      private int lblStepnumber_Visible ;
      private int subGridwizardsteps_Selectioncolor ;
      private int subGridwizardsteps_Hoveringcolor ;
      private int idxLst ;
      private int subGridwizardsteps_Backcolor ;
      private int subGridwizardsteps_Allbackcolor ;
      private long GRIDWIZARDSTEPS_nCurrentRecord ;
      private long GRIDWIZARDSTEPS_nFirstRecordOnPage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_5_idx="0001" ;
      private String GXKey ;
      private String edtavWizardsteps__title_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sGXsfl_5_fel_idx="0001" ;
      private String lblStepnumber_Caption ;
      private String tblTablestepbulletlineleft_Class ;
      private String tblTablestepbulletlineleft_Internalname ;
      private String tblTablestepbulletlineright_Class ;
      private String tblTablestepbulletlineright_Internalname ;
      private String divTablestepitem_Class ;
      private String divTablestepitem_Internalname ;
      private String edtavWizardsteps__title_Class ;
      private String lblStepnumber_Class ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String subGridwizardsteps_Internalname ;
      private String lblDummybulletlineleft_Caption ;
      private String sCtrlAV11WizardSteps ;
      private String sCtrlAV8CurrentStep ;
      private String lblDummybulletlineleft_Internalname ;
      private String lblStepnumber_Internalname ;
      private String lblDummybulletlineright_Internalname ;
      private String subGridwizardsteps_Class ;
      private String subGridwizardsteps_Linesclass ;
      private String tblTblcontainerstep_Internalname ;
      private String tblTablestepbulletline_Internalname ;
      private String lblDummybulletlineleft_Jsonclick ;
      private String divLayout_tablestepitem_Internalname ;
      private String lblStepnumber_Jsonclick ;
      private String lblDummybulletlineright_Jsonclick ;
      private String ROClassString ;
      private String edtavWizardsteps__title_Jsonclick ;
      private bool entryPointCalled ;
      private bool bGXsfl_5_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV8CurrentStep ;
      private String wcpOAV8CurrentStep ;
      private String AV10TableContainerStepClass ;
      private GXWebGrid GridwizardstepsContainer ;
      private GXWebRow GridwizardstepsRow ;
      private GXWebColumn GridwizardstepsColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem> AV11WizardSteps ;
      private GeneXus.Programs.wwpbaseobjects.SdtWizardSteps_WizardStepsItem AV5WizardStep ;
   }

}
