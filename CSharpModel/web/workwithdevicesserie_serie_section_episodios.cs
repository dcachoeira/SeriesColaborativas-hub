/*
               File: WorkWithDevicesSerie_Serie_Section_Episodios
        Description: WorkWithDevicesSerie_Serie_Section_Episodios
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/13/2018 16:23:58.12
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
   public class workwithdevicesserie_serie_section_episodios : GXProcedure
   {
      public workwithdevicesserie_serie_section_episodios( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public workwithdevicesserie_serie_section_episodios( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_SerieId ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt aP2_GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV9gxid = aP1_gxid;
         this.AV12GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt = new SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt=this.AV12GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt;
      }

      public SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt executeUdp( long aP0_SerieId ,
                                                                            int aP1_gxid )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV9gxid = aP1_gxid;
         this.AV12GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt = new SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt=this.AV12GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt;
         return AV12GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt aP2_GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt )
      {
         workwithdevicesserie_serie_section_episodios objworkwithdevicesserie_serie_section_episodios;
         objworkwithdevicesserie_serie_section_episodios = new workwithdevicesserie_serie_section_episodios();
         objworkwithdevicesserie_serie_section_episodios.A1SerieId = aP0_SerieId;
         objworkwithdevicesserie_serie_section_episodios.AV9gxid = aP1_gxid;
         objworkwithdevicesserie_serie_section_episodios.AV12GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt = new SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt(context) ;
         objworkwithdevicesserie_serie_section_episodios.context.SetSubmitInitialConfig(context);
         objworkwithdevicesserie_serie_section_episodios.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesserie_serie_section_episodios);
         aP2_GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt=this.AV12GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesserie_serie_section_episodios)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV9gxid), 8, 0);
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
      private int AV9gxid ;
      private long A1SerieId ;
      private String Gxids ;
      private SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt aP2_GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt AV12GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesserie_serie_section_episodios_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class workwithdevicesserie_serie_section_episodios_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?SerieId={SerieId}&gxid={gxid}")]
      public SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt_RESTInterface execute( String SerieId ,
                                                                                       String gxid )
      {
         SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt_RESTInterface GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt = new SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("workwithdevicesserie_serie_section_episodios") )
            {
               return null ;
            }
            workwithdevicesserie_serie_section_episodios worker = new workwithdevicesserie_serie_section_episodios(context) ;
            worker.IsMain = RunAsMain ;
            long gxrSerieId ;
            gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt gxrGXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt = GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt.sdt ;
            worker.execute(gxrSerieId,gxrgxid,out gxrGXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt );
            worker.cleanup( );
            GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt = new SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt_RESTInterface(gxrGXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt) ;
            return GXM1WorkWithDevicesSerie_Serie_Section_EpisodiosSdt ;
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
