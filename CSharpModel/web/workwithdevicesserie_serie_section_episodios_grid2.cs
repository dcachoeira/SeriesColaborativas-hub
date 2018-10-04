/*
               File: WorkWithDevicesSerie_Serie_Section_Episodios_Grid2
        Description: WorkWithDevicesSerie_Serie_Section_Episodios_Grid2
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/13/2018 16:23:58.6
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
   public class workwithdevicesserie_serie_section_episodios_grid2 : GXProcedure
   {
      public workwithdevicesserie_serie_section_episodios_grid2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public workwithdevicesserie_serie_section_episodios_grid2( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_SerieId ,
                           long aP1_start ,
                           long aP2_count ,
                           int aP3_gxid ,
                           out GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item> aP4_GXM4RootCol )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV12start = aP1_start;
         this.AV13count = aP2_count;
         this.AV9gxid = aP3_gxid;
         this.AV17GXM4RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM4RootCol=this.AV17GXM4RootCol;
      }

      public GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item> executeUdp( long aP0_SerieId ,
                                                                                                         long aP1_start ,
                                                                                                         long aP2_count ,
                                                                                                         int aP3_gxid )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV12start = aP1_start;
         this.AV13count = aP2_count;
         this.AV9gxid = aP3_gxid;
         this.AV17GXM4RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM4RootCol=this.AV17GXM4RootCol;
         return AV17GXM4RootCol ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 long aP1_start ,
                                 long aP2_count ,
                                 int aP3_gxid ,
                                 out GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item> aP4_GXM4RootCol )
      {
         workwithdevicesserie_serie_section_episodios_grid2 objworkwithdevicesserie_serie_section_episodios_grid2;
         objworkwithdevicesserie_serie_section_episodios_grid2 = new workwithdevicesserie_serie_section_episodios_grid2();
         objworkwithdevicesserie_serie_section_episodios_grid2.A1SerieId = aP0_SerieId;
         objworkwithdevicesserie_serie_section_episodios_grid2.AV12start = aP1_start;
         objworkwithdevicesserie_serie_section_episodios_grid2.AV13count = aP2_count;
         objworkwithdevicesserie_serie_section_episodios_grid2.AV9gxid = aP3_gxid;
         objworkwithdevicesserie_serie_section_episodios_grid2.AV17GXM4RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item>( context, "Item", "") ;
         objworkwithdevicesserie_serie_section_episodios_grid2.context.SetSubmitInitialConfig(context);
         objworkwithdevicesserie_serie_section_episodios_grid2.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesserie_serie_section_episodios_grid2);
         aP4_GXM4RootCol=this.AV17GXM4RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesserie_serie_section_episodios_grid2)stateInfo).executePrivate();
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
         AV7QuantidadeTemporadas = (short)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Quantidadetemporadas"), "."));
         AV6Temporada = (short)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Temporada"), "."));
         AV16GXV2SkipCount = (int)(-(AV12start));
         AV16GXV2SkipCount = (int)(AV16GXV2SkipCount+1);
         if ( AV16GXV2SkipCount > 0 )
         {
            AV18GXM3WorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt = new SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item(context);
            AV8i = 1;
            while ( AV8i <= AV7QuantidadeTemporadas )
            {
               Gxdynprop1 = "Temporada " + StringUtil.Str( (decimal)(AV8i), 4, 0);
               Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Txbtemporada\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
               AV6Temporada = AV8i;
               AV18GXM3WorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt.gxTpr_Temporada = AV6Temporada;
               AV18GXM3WorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
               Gxdynprop = "";
               AV17GXM4RootCol.Add(AV18GXM3WorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt, 0);
               AV18GXM3WorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt = new SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item(context);
               AV8i = (short)(AV8i+1);
            }
            AV18GXM3WorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt.gxTpr_Temporada = AV6Temporada;
            AV18GXM3WorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
            Gxdynprop = "";
         }
         Gxwebsession.Set(Gxids+"gxvar_Quantidadetemporadas", StringUtil.Str( (decimal)(AV7QuantidadeTemporadas), 4, 0));
         Gxwebsession.Set(Gxids+"gxvar_Temporada", StringUtil.Str( (decimal)(AV6Temporada), 4, 0));
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
         AV18GXM3WorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt = new SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item(context);
         Gxdynprop1 = "";
         Gxdynprop = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV7QuantidadeTemporadas ;
      private short AV6Temporada ;
      private short AV8i ;
      private int AV9gxid ;
      private int AV16GXV2SkipCount ;
      private long A1SerieId ;
      private long AV12start ;
      private long AV13count ;
      private String Gxids ;
      private String Gxdynprop1 ;
      private String Gxdynprop ;
      private GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item> aP4_GXM4RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item> AV17GXM4RootCol ;
      private SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item AV18GXM3WorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesserie_serie_section_episodios_grid2_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class workwithdevicesserie_serie_section_episodios_grid2_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?SerieId={SerieId}&start={start}&count={count}&gxid={gxid}")]
      public GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_RESTInterface> execute( String SerieId ,
                                                                                                                       String start ,
                                                                                                                       String count ,
                                                                                                                       String gxid )
      {
         GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_RESTInterface> GXM4RootCol = new GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_RESTInterface>() ;
         try
         {
            if ( ! ProcessHeaders("workwithdevicesserie_serie_section_episodios_grid2") )
            {
               return null ;
            }
            workwithdevicesserie_serie_section_episodios_grid2 worker = new workwithdevicesserie_serie_section_episodios_grid2(context) ;
            worker.IsMain = RunAsMain ;
            long gxrSerieId ;
            gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
            long gxrstart ;
            gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
            long gxrcount ;
            gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item> gxrGXM4RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item>() ;
            worker.execute(gxrSerieId,gxrstart,gxrcount,gxrgxid,out gxrGXM4RootCol );
            worker.cleanup( );
            GXM4RootCol = new GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_RESTInterface>(gxrGXM4RootCol) ;
            return GXM4RootCol ;
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
