/*
               File: SDSeries_Level_Detail
        Description: SDSeries_Level_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/30/2018 20:47:38.95
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
   public class sdseries_level_detail : GXProcedure
   {
      public sdseries_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public sdseries_level_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( int aP0_gxid ,
                           out SdtSDSeries_Level_DetailSdt aP1_GXM1SDSeries_Level_DetailSdt )
      {
         this.AV8gxid = aP0_gxid;
         this.AV11GXM1SDSeries_Level_DetailSdt = new SdtSDSeries_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1SDSeries_Level_DetailSdt=this.AV11GXM1SDSeries_Level_DetailSdt;
      }

      public SdtSDSeries_Level_DetailSdt executeUdp( int aP0_gxid )
      {
         this.AV8gxid = aP0_gxid;
         this.AV11GXM1SDSeries_Level_DetailSdt = new SdtSDSeries_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1SDSeries_Level_DetailSdt=this.AV11GXM1SDSeries_Level_DetailSdt;
         return AV11GXM1SDSeries_Level_DetailSdt ;
      }

      public void executeSubmit( int aP0_gxid ,
                                 out SdtSDSeries_Level_DetailSdt aP1_GXM1SDSeries_Level_DetailSdt )
      {
         sdseries_level_detail objsdseries_level_detail;
         objsdseries_level_detail = new sdseries_level_detail();
         objsdseries_level_detail.AV8gxid = aP0_gxid;
         objsdseries_level_detail.AV11GXM1SDSeries_Level_DetailSdt = new SdtSDSeries_Level_DetailSdt(context) ;
         objsdseries_level_detail.context.SetSubmitInitialConfig(context);
         objsdseries_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdseries_level_detail);
         aP1_GXM1SDSeries_Level_DetailSdt=this.AV11GXM1SDSeries_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdseries_level_detail)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV8gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            Gxwebsession.Set(Gxids+"gxvar_Serieid", StringUtil.Str( (decimal)(AV7SerieId), 18, 0));
            Gxwebsession.Set(Gxids+"gxvar_Serieimagem", AV14Serieimagem_GXI);
            Gxwebsession.Set(Gxids, "true");
         }
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
         AV14Serieimagem_GXI = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV8gxid ;
      private long AV7SerieId ;
      private String Gxids ;
      private String AV14Serieimagem_GXI ;
      private SdtSDSeries_Level_DetailSdt aP1_GXM1SDSeries_Level_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtSDSeries_Level_DetailSdt AV11GXM1SDSeries_Level_DetailSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.sdseries_level_detail_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class sdseries_level_detail_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?gxid={gxid}")]
      public SdtSDSeries_Level_DetailSdt_RESTInterface execute( String gxid )
      {
         SdtSDSeries_Level_DetailSdt_RESTInterface GXM1SDSeries_Level_DetailSdt = new SdtSDSeries_Level_DetailSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("sdseries_level_detail") )
            {
               return null ;
            }
            sdseries_level_detail worker = new sdseries_level_detail(context) ;
            worker.IsMain = RunAsMain ;
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtSDSeries_Level_DetailSdt gxrGXM1SDSeries_Level_DetailSdt = GXM1SDSeries_Level_DetailSdt.sdt ;
            worker.execute(gxrgxid,out gxrGXM1SDSeries_Level_DetailSdt );
            worker.cleanup( );
            GXM1SDSeries_Level_DetailSdt = new SdtSDSeries_Level_DetailSdt_RESTInterface(gxrGXM1SDSeries_Level_DetailSdt) ;
            return GXM1SDSeries_Level_DetailSdt ;
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
