/*
               File: WorkWithDevicesSerie_Serie_Section_Temporadas
        Description: WorkWithDevicesSerie_Serie_Section_Temporadas
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:32.35
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
   public class workwithdevicesserie_serie_section_temporadas : GXProcedure
   {
      public workwithdevicesserie_serie_section_temporadas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public workwithdevicesserie_serie_section_temporadas( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_SerieId ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt aP2_GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV10gxid = aP1_gxid;
         this.AV13GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt = new SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt=this.AV13GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt;
      }

      public SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt executeUdp( long aP0_SerieId ,
                                                                             int aP1_gxid )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV10gxid = aP1_gxid;
         this.AV13GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt = new SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt=this.AV13GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt;
         return AV13GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt aP2_GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt )
      {
         workwithdevicesserie_serie_section_temporadas objworkwithdevicesserie_serie_section_temporadas;
         objworkwithdevicesserie_serie_section_temporadas = new workwithdevicesserie_serie_section_temporadas();
         objworkwithdevicesserie_serie_section_temporadas.A1SerieId = aP0_SerieId;
         objworkwithdevicesserie_serie_section_temporadas.AV10gxid = aP1_gxid;
         objworkwithdevicesserie_serie_section_temporadas.AV13GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt = new SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt(context) ;
         objworkwithdevicesserie_serie_section_temporadas.context.SetSubmitInitialConfig(context);
         objworkwithdevicesserie_serie_section_temporadas.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesserie_serie_section_temporadas);
         aP2_GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt=this.AV13GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesserie_serie_section_temporadas)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV10gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            new obterquantidadetemporadaserie(context ).execute(  A1SerieId, out  AV7QuantidadeTemporadas) ;
            Gxwebsession.Set(Gxids+"gxvar_Quantidadetemporadas", StringUtil.Str( (decimal)(AV7QuantidadeTemporadas), 4, 0));
            Gxwebsession.Set(Gxids+"gxvar_Temporada", StringUtil.Str( (decimal)(AV6Temporada), 4, 0));
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
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV7QuantidadeTemporadas ;
      private short AV6Temporada ;
      private int AV10gxid ;
      private long A1SerieId ;
      private String Gxids ;
      private SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt aP2_GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt AV13GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesserie_serie_section_temporadas_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class workwithdevicesserie_serie_section_temporadas_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?SerieId={SerieId}&gxid={gxid}")]
      public SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt_RESTInterface execute( String SerieId ,
                                                                                        String gxid )
      {
         SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt_RESTInterface GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt = new SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("workwithdevicesserie_serie_section_temporadas") )
            {
               return null ;
            }
            workwithdevicesserie_serie_section_temporadas worker = new workwithdevicesserie_serie_section_temporadas(context) ;
            worker.IsMain = RunAsMain ;
            long gxrSerieId ;
            gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt gxrGXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt = GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt.sdt ;
            worker.execute(gxrSerieId,gxrgxid,out gxrGXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt );
            worker.cleanup( );
            GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt = new SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt_RESTInterface(gxrGXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt) ;
            return GXM1WorkWithDevicesSerie_Serie_Section_TemporadasSdt ;
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
