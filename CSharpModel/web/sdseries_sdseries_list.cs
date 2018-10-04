/*
               File: SdSeries_SdSeries_List
        Description: SdSeries_SdSeries_List
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:24.70
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
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class sdseries_sdseries_list : GXProcedure
   {
      public sdseries_sdseries_list( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public sdseries_sdseries_list( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( int aP0_gxid ,
                           out SdtSdSeries_SdSeries_ListSdt aP1_GXM1SdSeries_SdSeries_ListSdt )
      {
         this.AV5gxid = aP0_gxid;
         this.AV9GXM1SdSeries_SdSeries_ListSdt = new SdtSdSeries_SdSeries_ListSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1SdSeries_SdSeries_ListSdt=this.AV9GXM1SdSeries_SdSeries_ListSdt;
      }

      public SdtSdSeries_SdSeries_ListSdt executeUdp( int aP0_gxid )
      {
         this.AV5gxid = aP0_gxid;
         this.AV9GXM1SdSeries_SdSeries_ListSdt = new SdtSdSeries_SdSeries_ListSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1SdSeries_SdSeries_ListSdt=this.AV9GXM1SdSeries_SdSeries_ListSdt;
         return AV9GXM1SdSeries_SdSeries_ListSdt ;
      }

      public void executeSubmit( int aP0_gxid ,
                                 out SdtSdSeries_SdSeries_ListSdt aP1_GXM1SdSeries_SdSeries_ListSdt )
      {
         sdseries_sdseries_list objsdseries_sdseries_list;
         objsdseries_sdseries_list = new sdseries_sdseries_list();
         objsdseries_sdseries_list.AV5gxid = aP0_gxid;
         objsdseries_sdseries_list.AV9GXM1SdSeries_SdSeries_ListSdt = new SdtSdSeries_SdSeries_ListSdt(context) ;
         objsdseries_sdseries_list.context.SetSubmitInitialConfig(context);
         objsdseries_sdseries_list.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdseries_sdseries_list);
         aP1_GXM1SdSeries_SdSeries_ListSdt=this.AV9GXM1SdSeries_SdSeries_ListSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdseries_sdseries_list)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV5gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( "Séries") + "\"]";
            Gxwebsession.Set(Gxids, "true");
         }
         AV9GXM1SdSeries_SdSeries_ListSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
         Gxdynprop = "";
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         Gxids = "";
         Gxwebsession = context.GetSession();
         Gxdynprop = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV5gxid ;
      private String Gxids ;
      private String Gxdynprop ;
      private SdtSdSeries_SdSeries_ListSdt aP1_GXM1SdSeries_SdSeries_ListSdt ;
      private IGxSession Gxwebsession ;
      private SdtSdSeries_SdSeries_ListSdt AV9GXM1SdSeries_SdSeries_ListSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.sdseries_sdseries_list_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class sdseries_sdseries_list_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?gxid={gxid}")]
      public SdtSdSeries_SdSeries_ListSdt_RESTInterface execute( String gxid )
      {
         SdtSdSeries_SdSeries_ListSdt_RESTInterface GXM1SdSeries_SdSeries_ListSdt = new SdtSdSeries_SdSeries_ListSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("sdseries_sdseries_list") )
            {
               return null ;
            }
            sdseries_sdseries_list worker = new sdseries_sdseries_list(context) ;
            worker.IsMain = RunAsMain ;
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtSdSeries_SdSeries_ListSdt gxrGXM1SdSeries_SdSeries_ListSdt = GXM1SdSeries_SdSeries_ListSdt.sdt ;
            worker.execute(gxrgxid,out gxrGXM1SdSeries_SdSeries_ListSdt );
            worker.cleanup( );
            GXM1SdSeries_SdSeries_ListSdt = new SdtSdSeries_SdSeries_ListSdt_RESTInterface(gxrGXM1SdSeries_SdSeries_ListSdt) ;
            return GXM1SdSeries_SdSeries_ListSdt ;
         }
         catch ( Exception e )
         {
            WebException(e);
         }
         finally
         {
            Cleanup();
         }
         return null ;
      }

   }

}
