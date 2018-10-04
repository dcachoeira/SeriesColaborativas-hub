/*
               File: WWPBaseObjects.WWPTabbedView
        Description: Tabbed View
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:23.14
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
   public class wwptabbedview : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public wwptabbedview( )
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

      public wwptabbedview( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWWPTabOptions_TabOptionsItem> aP0_Tabs ,
                           String aP1_TabCode )
      {
         this.AV5Tabs = aP0_Tabs;
         this.AV7TabCode = aP1_TabCode;
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
                  ajax_req_read_hidden_sdt(GetNextPar( ), AV5Tabs);
                  AV7TabCode = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TabCode", AV7TabCode);
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWWPTabOptions_TabOptionsItem>)AV5Tabs,(String)AV7TabCode});
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Tabsgrid") == 0 )
               {
                  nRC_GXsfl_14 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_14_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_14_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxnrTabsgrid_newrow( ) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Tabsgrid") == 0 )
               {
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrTabsgrid_refresh( sPrefix) ;
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
            PA0F2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS0F2( ) ;
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
            context.SendWebValue( "Tabbed View") ;
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
         context.AddJavascriptSource("gxcfg.js", "?201892019382321", false);
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
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + ";-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" data-gx-class=\"Form\" novalidate action=\""+formatLink("wwpbaseobjects.wwptabbedview.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV7TabCode))+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "Form", true);
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
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_14", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_14), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7TabCode", StringUtil.RTrim( wcpOAV7TabCode));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vTABS", AV5Tabs);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vTABS", AV5Tabs);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"vTABCODE", StringUtil.RTrim( AV7TabCode));
      }

      protected void RenderHtmlCloseForm0F2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("wwpbaseobjects/wwptabbedview.js", "?201892019382324", false);
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
            context.WriteHtmlTextNl( "</form>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            include_jscripts( ) ;
            if ( ! ( WebComp_Component == null ) )
            {
               WebComp_Component.componentjscripts();
            }
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
         return "WWPBaseObjects.WWPTabbedView" ;
      }

      public override String GetPgmdesc( )
      {
         return "Tabbed View" ;
      }

      protected void WB0F0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "wwpbaseobjects.wwptabbedview.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_0F2( true) ;
         }
         else
         {
            wb_table1_2_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true;
      }

      protected void START0F2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 15_0_9-121631", 0) ;
               Form.Meta.addItem("description", "Tabbed View", 0) ;
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
               STRUP0F0( ) ;
            }
         }
      }

      protected void WS0F2( )
      {
         START0F2( ) ;
         EVT0F2( ) ;
      }

      protected void EVT0F2( )
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
                                 STRUP0F0( ) ;
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
                                 STRUP0F0( ) ;
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0F0( ) ;
                              }
                              nGXsfl_14_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_14_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_14_idx), 4, 0)), 4, "0");
                              SubsflControlProps_142( ) ;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: Load */
                                          E110F2 ();
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
                                       STRUP0F0( ) ;
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
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4);
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                        if ( nCmpId == 37 )
                        {
                           OldComponent = cgiGet( sPrefix+"W0037");
                           if ( ( StringUtil.Len( OldComponent) == 0 ) || ( StringUtil.StrCmp(OldComponent, WebComp_Component_Component) != 0 ) )
                           {
                              WebComp_Component = getWebComponent(GetType(), "GeneXus.Programs", OldComponent, new Object[] {context} );
                              WebComp_Component.ComponentInit();
                              WebComp_Component.Name = "OldComponent";
                              WebComp_Component_Component = OldComponent;
                           }
                           WebComp_Component.componentprocess(sPrefix+"W0037", "", sEvt);
                           WebComp_Component_Component = OldComponent;
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0F2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0F2( ) ;
            }
         }
      }

      protected void PA0F2( )
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

      protected void gxnrTabsgrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_142( ) ;
         while ( nGXsfl_14_idx <= nRC_GXsfl_14 )
         {
            sendrow_142( ) ;
            nGXsfl_14_idx = (short)(((subTabsgrid_Islastpage==1)&&(nGXsfl_14_idx+1>subTabsgrid_Recordsperpage( )) ? 1 : nGXsfl_14_idx+1));
            sGXsfl_14_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_14_idx), 4, 0)), 4, "0");
            SubsflControlProps_142( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( TabsgridContainer));
         /* End function gxnrTabsgrid_newrow */
      }

      protected void gxgrTabsgrid_refresh( String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         TABSGRID_nCurrentRecord = 0;
         RF0F2( ) ;
         /* End function gxgrTabsgrid_refresh */
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
         RF0F2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF0F2( )
      {
         initialize_formulas( ) ;
         if ( isAjaxCallMode( ) )
         {
            TabsgridContainer.ClearRows();
         }
         wbStart = 14;
         nGXsfl_14_idx = 1;
         sGXsfl_14_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_14_idx), 4, 0)), 4, "0");
         SubsflControlProps_142( ) ;
         bGXsfl_14_Refreshing = true;
         TabsgridContainer.AddObjectProperty("GridName", "Tabsgrid");
         TabsgridContainer.AddObjectProperty("CmpContext", sPrefix);
         TabsgridContainer.AddObjectProperty("InMasterPage", "false");
         TabsgridContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
         TabsgridContainer.AddObjectProperty("Borderwidth", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
         TabsgridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
         TabsgridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
         TabsgridContainer.AddObjectProperty("Rules", StringUtil.RTrim( "none"));
         TabsgridContainer.AddObjectProperty("Class", "FreeStyleGrid");
         TabsgridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
         TabsgridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
         TabsgridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTabsgrid_Backcolorstyle), 1, 0, ".", "")));
         TabsgridContainer.AddObjectProperty("Borderwidth", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTabsgrid_Borderwidth), 4, 0, ".", "")));
         TabsgridContainer.PageSize = subTabsgrid_Recordsperpage( );
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               WebComp_Component.componentstart();
            }
         }
         fix_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_142( ) ;
            /* Execute user event: Load */
            E110F2 ();
            wbEnd = 14;
            WB0F0( ) ;
         }
         bGXsfl_14_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0F2( )
      {
      }

      protected int subTabsgrid_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subTabsgrid_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subTabsgrid_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subTabsgrid_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP0F0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_GXsfl_14 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_14"), ",", "."));
            wcpOAV7TabCode = cgiGet( sPrefix+"wcpOAV7TabCode");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      private void E110F2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_0F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";";
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='TableAttributesCell'>") ;
            wb_table2_5_0F2( true) ;
         }
         else
         {
            wb_table2_5_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0F2e( true) ;
         }
         else
         {
            wb_table1_2_0F2e( false) ;
         }
      }

      protected void wb_table2_5_0F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";";
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='TableAttributesCell'>") ;
            wb_table3_8_0F2( true) ;
         }
         else
         {
            wb_table3_8_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table3_8_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_0F2e( true) ;
         }
         else
         {
            wb_table2_5_0F2e( false) ;
         }
      }

      protected void wb_table3_8_0F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "none", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr style=\""+CSSHelper.Prettify( "vertical-align:bottom")+"\">") ;
            context.WriteHtmlText( "<td background=\"\"  style=\""+CSSHelper.Prettify( "vertical-align:bottom;height:25px")+"\">") ;
            wb_table4_11_0F2( true) ;
         }
         else
         {
            wb_table4_11_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table4_11_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "vertical-align:top;height:39px")+"\">") ;
            wb_table5_31_0F2( true) ;
         }
         else
         {
            wb_table5_31_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table5_31_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_8_0F2e( true) ;
         }
         else
         {
            wb_table3_8_0F2e( false) ;
         }
      }

      protected void wb_table5_31_0F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + "background-color: " + context.BuildHTMLColor( (int)(0xFFFFFF)) + ";";
            if ( StringUtil.StrCmp(context.BuildHTMLColor( (int)(0x000000))+";", "") != 0 )
            {
               sStyleString = sStyleString + " border-color: " + context.BuildHTMLColor( (int)(0x000000)) + ";";
            }
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";";
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "none", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "vertical-align:top")+"\">") ;
            wb_table6_34_0F2( true) ;
         }
         else
         {
            wb_table6_34_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table6_34_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_31_0F2e( true) ;
         }
         else
         {
            wb_table5_31_0F2e( false) ;
         }
      }

      protected void wb_table6_34_0F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablecomponent_Internalname, tblTablecomponent_Internalname, "", "TableView", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, sPrefix+"W0037"+"", StringUtil.RTrim( WebComp_Component_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+sPrefix+"gxHTMLWrpW0037"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.StrCmp(StringUtil.Lower( OldComponent), StringUtil.Lower( WebComp_Component_Component)) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix+"gxHTMLWrpW0037"+"");
               }
               WebComp_Component.componentdraw();
               if ( StringUtil.StrCmp(StringUtil.Lower( OldComponent), StringUtil.Lower( WebComp_Component_Component)) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
               context.WriteHtmlText( "</div>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_34_0F2e( true) ;
         }
         else
         {
            wb_table6_34_0F2e( false) ;
         }
      }

      protected void wb_table4_11_0F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabletabs_Internalname, tblTabletabs_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "none", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "vertical-align:bottom")+"\">") ;
            /*  Grid Control  */
            TabsgridContainer.SetIsFreestyle(true);
            TabsgridContainer.SetWrapped(nGXWrapped);
            if ( TabsgridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+sPrefix+"TabsgridContainer"+"DivS\" data-gxgridid=\"14\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subTabsgrid_Internalname, subTabsgrid_Internalname, "", "FreeStyleGrid", 0, "", "", 0, 0, sStyleString, "none", 0);
               TabsgridContainer.AddObjectProperty("GridName", "Tabsgrid");
            }
            else
            {
               TabsgridContainer.AddObjectProperty("GridName", "Tabsgrid");
               TabsgridContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
               TabsgridContainer.AddObjectProperty("Borderwidth", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               TabsgridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               TabsgridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               TabsgridContainer.AddObjectProperty("Rules", StringUtil.RTrim( "none"));
               TabsgridContainer.AddObjectProperty("Class", "FreeStyleGrid");
               TabsgridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               TabsgridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               TabsgridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTabsgrid_Backcolorstyle), 1, 0, ".", "")));
               TabsgridContainer.AddObjectProperty("Borderwidth", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTabsgrid_Borderwidth), 4, 0, ".", "")));
               TabsgridContainer.AddObjectProperty("CmpContext", sPrefix);
               TabsgridContainer.AddObjectProperty("InMasterPage", "false");
               TabsgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TabsgridContainer.AddColumnProperties(TabsgridColumn);
               TabsgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TabsgridContainer.AddColumnProperties(TabsgridColumn);
               TabsgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TabsgridColumn.AddObjectProperty("Value", context.convertURL( "(none)"));
               TabsgridContainer.AddColumnProperties(TabsgridColumn);
               TabsgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TabsgridContainer.AddColumnProperties(TabsgridColumn);
               TabsgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TabsgridContainer.AddColumnProperties(TabsgridColumn);
               TabsgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TabsgridContainer.AddColumnProperties(TabsgridColumn);
               TabsgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TabsgridContainer.AddColumnProperties(TabsgridColumn);
               TabsgridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TabsgridColumn.AddObjectProperty("Value", lblTab_Caption);
               TabsgridContainer.AddColumnProperties(TabsgridColumn);
               TabsgridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTabsgrid_Allowselection), 1, 0, ".", "")));
               TabsgridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTabsgrid_Selectioncolor), 9, 0, ".", "")));
               TabsgridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTabsgrid_Allowhovering), 1, 0, ".", "")));
               TabsgridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTabsgrid_Hoveringcolor), 9, 0, ".", "")));
               TabsgridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTabsgrid_Allowcollapsing), 1, 0, ".", "")));
               TabsgridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTabsgrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 14 )
         {
            wbEnd = 0;
            nRC_GXsfl_14 = (short)(nGXsfl_14_idx-1);
            if ( TabsgridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"TabsgridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Tabsgrid", TabsgridContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"TabsgridContainerData", TabsgridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"TabsgridContainerData"+"V", TabsgridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input autocomplete=\"off\" type=\"hidden\" "+"name=\""+sPrefix+"TabsgridContainerData"+"V"+"\" value='"+TabsgridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "vertical-align:bottom")+"\">") ;
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            sImgUrl = "(none)";
            GxWebStd.gx_bitmap( context, imgEndtab_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WWPBaseObjects\\WWPTabbedView.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:15px")+"\">") ;
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            sImgUrl = "(none)";
            GxWebStd.gx_bitmap( context, imgTabprevious_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Previous Tab", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WWPBaseObjects\\WWPTabbedView.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "width:13px")+"\">") ;
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            sImgUrl = "(none)";
            GxWebStd.gx_bitmap( context, imgTabnext_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Next Tab", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WWPBaseObjects\\WWPTabbedView.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_11_0F2e( true) ;
         }
         else
         {
            wb_table4_11_0F2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV5Tabs = (GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWWPTabOptions_TabOptionsItem>)getParm(obj,0);
         AV7TabCode = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TabCode", AV7TabCode);
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
         PA0F2( ) ;
         WS0F2( ) ;
         WE0F2( ) ;
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
         sCtrlAV5Tabs = (String)((String)getParm(obj,0));
         sCtrlAV7TabCode = (String)((String)getParm(obj,1));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0F2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "wwpbaseobjects\\wwptabbedview", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA0F2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV5Tabs = (GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWWPTabOptions_TabOptionsItem>)getParm(obj,2);
            AV7TabCode = (String)getParm(obj,3);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TabCode", AV7TabCode);
         }
         wcpOAV7TabCode = cgiGet( sPrefix+"wcpOAV7TabCode");
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV7TabCode, wcpOAV7TabCode) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV7TabCode = AV7TabCode;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV5Tabs = cgiGet( sPrefix+"AV5Tabs_CTRL");
         if ( StringUtil.Len( sCtrlAV5Tabs) > 0 )
         {
            AV5Tabs = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWWPTabOptions_TabOptionsItem>();
         }
         else
         {
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"AV5Tabs_PARM"), AV5Tabs);
         }
         sCtrlAV7TabCode = cgiGet( sPrefix+"AV7TabCode_CTRL");
         if ( StringUtil.Len( sCtrlAV7TabCode) > 0 )
         {
            AV7TabCode = cgiGet( sCtrlAV7TabCode);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TabCode", AV7TabCode);
         }
         else
         {
            AV7TabCode = cgiGet( sPrefix+"AV7TabCode_PARM");
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
         PA0F2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0F2( ) ;
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
         WS0F2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"AV5Tabs_PARM", AV5Tabs);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"AV5Tabs_PARM", AV5Tabs);
         }
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV5Tabs)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV5Tabs_CTRL", StringUtil.RTrim( sCtrlAV5Tabs));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7TabCode_PARM", StringUtil.RTrim( AV7TabCode));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7TabCode)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7TabCode_CTRL", StringUtil.RTrim( sCtrlAV7TabCode));
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
         WE0F2( ) ;
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
         if ( ! ( WebComp_Component == null ) )
         {
            WebComp_Component.componentjscripts();
         }
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), false);
         if ( ! ( WebComp_Component == null ) )
         {
            WebComp_Component.componentthemes();
         }
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201892019382365", true);
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
         context.AddJavascriptSource("wwpbaseobjects/wwptabbedview.js", "?201892019382366", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_142( )
      {
         imgBegintab_Internalname = sPrefix+"BEGINTAB_"+sGXsfl_14_idx;
         lblTab_Internalname = sPrefix+"TAB_"+sGXsfl_14_idx;
      }

      protected void SubsflControlProps_fel_142( )
      {
         imgBegintab_Internalname = sPrefix+"BEGINTAB_"+sGXsfl_14_fel_idx;
         lblTab_Internalname = sPrefix+"TAB_"+sGXsfl_14_fel_idx;
      }

      protected void sendrow_142( )
      {
         SubsflControlProps_142( ) ;
         WB0F0( ) ;
         TabsgridRow = GXWebRow.GetNew(context,TabsgridContainer);
         if ( subTabsgrid_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subTabsgrid_Backstyle = 0;
            if ( StringUtil.StrCmp(subTabsgrid_Class, "") != 0 )
            {
               subTabsgrid_Linesclass = subTabsgrid_Class+"Odd";
            }
         }
         else if ( subTabsgrid_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subTabsgrid_Backstyle = 0;
            subTabsgrid_Backcolor = subTabsgrid_Allbackcolor;
            if ( StringUtil.StrCmp(subTabsgrid_Class, "") != 0 )
            {
               subTabsgrid_Linesclass = subTabsgrid_Class+"Uniform";
            }
         }
         else if ( subTabsgrid_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subTabsgrid_Backstyle = 1;
            if ( StringUtil.StrCmp(subTabsgrid_Class, "") != 0 )
            {
               subTabsgrid_Linesclass = subTabsgrid_Class+"Odd";
            }
            subTabsgrid_Backcolor = (int)(0xFFFFFF);
         }
         else if ( subTabsgrid_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subTabsgrid_Backstyle = 1;
            if ( ((int)(((nGXsfl_14_idx-1)/ (decimal)(0)) % (2))) == 0 )
            {
               subTabsgrid_Backcolor = (int)(0xFFFFFF);
               if ( StringUtil.StrCmp(subTabsgrid_Class, "") != 0 )
               {
                  subTabsgrid_Linesclass = subTabsgrid_Class+"Odd";
               }
            }
            else
            {
               subTabsgrid_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subTabsgrid_Class, "") != 0 )
               {
                  subTabsgrid_Linesclass = subTabsgrid_Class+"Even";
               }
            }
         }
         /* Start of Columns property logic. */
         TabsgridRow.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)subTabsgrid_Linesclass,(String)""});
         TabsgridRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",""+" style=\""+CSSHelper.Prettify( "vertical-align:bottom")+"\""});
         /* Static images/pictures */
         ClassString = "Image";
         StyleString = "";
         sImgUrl = "(none)";
         TabsgridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgBegintab_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)1,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         if ( TabsgridContainer.GetWrapped() == 1 )
         {
            TabsgridContainer.CloseTag("cell");
         }
         TabsgridRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",""+" style=\""+CSSHelper.Prettify( "vertical-align:top;width:63px")+"\""});
         /* Table start */
         TabsgridRow.AddColumnProperties("table", -1, isAjaxCallMode( ), new Object[] {(String)tblTabletab_Internalname+"_"+sGXsfl_14_idx,(short)1,(String)"Table",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)0,(short)0,(String)"",(String)"",(String)"",(String)"px",(String)"px"});
         TabsgridRow.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         TabsgridRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Text block */
         TabsgridRow.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTab_Internalname,(String)"Tab Name",(String)"",(String)"",(String)lblTab_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"UnSelectedTab",(short)0,(String)"",(short)1,(short)1,(short)0});
         if ( TabsgridContainer.GetWrapped() == 1 )
         {
            TabsgridContainer.CloseTag("cell");
         }
         if ( TabsgridContainer.GetWrapped() == 1 )
         {
            TabsgridContainer.CloseTag("row");
         }
         if ( TabsgridContainer.GetWrapped() == 1 )
         {
            TabsgridContainer.CloseTag("table");
         }
         /* End of table */
         if ( TabsgridContainer.GetWrapped() == 1 )
         {
            TabsgridContainer.CloseTag("cell");
         }
         if ( TabsgridContainer.GetWrapped() == 1 )
         {
            TabsgridContainer.CloseTag("row");
         }
         send_integrity_lvl_hashes0F2( ) ;
         /* End of Columns property logic. */
         TabsgridContainer.AddRow(TabsgridRow);
         nGXsfl_14_idx = (short)(((subTabsgrid_Islastpage==1)&&(nGXsfl_14_idx+1>subTabsgrid_Recordsperpage( )) ? 1 : nGXsfl_14_idx+1));
         sGXsfl_14_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_14_idx), 4, 0)), 4, "0");
         SubsflControlProps_142( ) ;
         /* End function sendrow_142 */
      }

      protected void init_default_properties( )
      {
         imgBegintab_Internalname = sPrefix+"BEGINTAB";
         lblTab_Internalname = sPrefix+"TAB";
         tblTabletab_Internalname = sPrefix+"TABLETAB";
         imgEndtab_Internalname = sPrefix+"ENDTAB";
         imgTabprevious_Internalname = sPrefix+"TABPREVIOUS";
         imgTabnext_Internalname = sPrefix+"TABNEXT";
         tblTabletabs_Internalname = sPrefix+"TABLETABS";
         tblTablecomponent_Internalname = sPrefix+"TABLECOMPONENT";
         tblTable2_Internalname = sPrefix+"TABLE2";
         tblTable1_Internalname = sPrefix+"TABLE1";
         tblTable3_Internalname = sPrefix+"TABLE3";
         tblTable4_Internalname = sPrefix+"TABLE4";
         Form.Internalname = sPrefix+"FORM";
         subTabsgrid_Internalname = sPrefix+"TABSGRID";
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
         subTabsgrid_Class = "FreeStyleGrid";
         subTabsgrid_Allowcollapsing = 0;
         lblTab_Caption = "Tab Name";
         subTabsgrid_Borderwidth = 0;
         subTabsgrid_Backcolorstyle = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'TABSGRID_nFirstRecordOnPage',nv:0},{av:'TABSGRID_nEOF',nv:0},{av:'sPrefix',nv:''}],oparms:[]}");
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
         AV5Tabs = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWWPTabOptions_TabOptionsItem>( context, "TabOptionsItem", "SeriesColaborativas");
         wcpOAV7TabCode = "";
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
         OldComponent = "";
         WebComp_Component_Component = "";
         TabsgridContainer = new GXWebGrid( context);
         sStyleString = "";
         TabsgridColumn = new GXWebColumn();
         ClassString = "";
         StyleString = "";
         sImgUrl = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV5Tabs = "";
         sCtrlAV7TabCode = "";
         TabsgridRow = new GXWebRow();
         subTabsgrid_Linesclass = "";
         lblTab_Jsonclick = "";
         WebComp_Component = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_14 ;
      private short nGXsfl_14_idx=1 ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subTabsgrid_Backcolorstyle ;
      private short subTabsgrid_Borderwidth ;
      private short subTabsgrid_Allowselection ;
      private short subTabsgrid_Allowhovering ;
      private short subTabsgrid_Allowcollapsing ;
      private short subTabsgrid_Collapsed ;
      private short nGXWrapped ;
      private short subTabsgrid_Backstyle ;
      private short TABSGRID_nEOF ;
      private int subTabsgrid_Islastpage ;
      private int subTabsgrid_Selectioncolor ;
      private int subTabsgrid_Hoveringcolor ;
      private int idxLst ;
      private int subTabsgrid_Backcolor ;
      private int subTabsgrid_Allbackcolor ;
      private long TABSGRID_nCurrentRecord ;
      private long TABSGRID_nFirstRecordOnPage ;
      private String AV7TabCode ;
      private String wcpOAV7TabCode ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_14_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String OldComponent ;
      private String WebComp_Component_Component ;
      private String sStyleString ;
      private String tblTable4_Internalname ;
      private String tblTable3_Internalname ;
      private String tblTable1_Internalname ;
      private String tblTable2_Internalname ;
      private String tblTablecomponent_Internalname ;
      private String tblTabletabs_Internalname ;
      private String subTabsgrid_Internalname ;
      private String lblTab_Caption ;
      private String ClassString ;
      private String StyleString ;
      private String sImgUrl ;
      private String imgEndtab_Internalname ;
      private String imgTabprevious_Internalname ;
      private String imgTabnext_Internalname ;
      private String sCtrlAV5Tabs ;
      private String sCtrlAV7TabCode ;
      private String imgBegintab_Internalname ;
      private String lblTab_Internalname ;
      private String sGXsfl_14_fel_idx="0001" ;
      private String subTabsgrid_Class ;
      private String subTabsgrid_Linesclass ;
      private String tblTabletab_Internalname ;
      private String lblTab_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_14_Refreshing=false ;
      private GXWebComponent WebComp_Component ;
      private GXWebGrid TabsgridContainer ;
      private GXWebRow TabsgridRow ;
      private GXWebColumn TabsgridColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtWWPTabOptions_TabOptionsItem> AV5Tabs ;
   }

}
