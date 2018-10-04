/*
               File: WorkWithDevicesSerie_Serie_List
        Description: WorkWithDevicesSerie_Serie_List
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:31.51
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
   public class workwithdevicesserie_serie_list : GXProcedure
   {
      public workwithdevicesserie_serie_list( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public workwithdevicesserie_serie_list( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_GeneroId ,
                           bool aP1_Lancamento ,
                           int aP2_gxid ,
                           out SdtWorkWithDevicesSerie_Serie_ListSdt aP3_GXM1WorkWithDevicesSerie_Serie_ListSdt )
      {
         this.AV13GeneroId = aP0_GeneroId;
         this.AV14Lancamento = aP1_Lancamento;
         this.AV17gxid = aP2_gxid;
         this.AV21GXM1WorkWithDevicesSerie_Serie_ListSdt = new SdtWorkWithDevicesSerie_Serie_ListSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM1WorkWithDevicesSerie_Serie_ListSdt=this.AV21GXM1WorkWithDevicesSerie_Serie_ListSdt;
      }

      public SdtWorkWithDevicesSerie_Serie_ListSdt executeUdp( long aP0_GeneroId ,
                                                               bool aP1_Lancamento ,
                                                               int aP2_gxid )
      {
         this.AV13GeneroId = aP0_GeneroId;
         this.AV14Lancamento = aP1_Lancamento;
         this.AV17gxid = aP2_gxid;
         this.AV21GXM1WorkWithDevicesSerie_Serie_ListSdt = new SdtWorkWithDevicesSerie_Serie_ListSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM1WorkWithDevicesSerie_Serie_ListSdt=this.AV21GXM1WorkWithDevicesSerie_Serie_ListSdt;
         return AV21GXM1WorkWithDevicesSerie_Serie_ListSdt ;
      }

      public void executeSubmit( long aP0_GeneroId ,
                                 bool aP1_Lancamento ,
                                 int aP2_gxid ,
                                 out SdtWorkWithDevicesSerie_Serie_ListSdt aP3_GXM1WorkWithDevicesSerie_Serie_ListSdt )
      {
         workwithdevicesserie_serie_list objworkwithdevicesserie_serie_list;
         objworkwithdevicesserie_serie_list = new workwithdevicesserie_serie_list();
         objworkwithdevicesserie_serie_list.AV13GeneroId = aP0_GeneroId;
         objworkwithdevicesserie_serie_list.AV14Lancamento = aP1_Lancamento;
         objworkwithdevicesserie_serie_list.AV17gxid = aP2_gxid;
         objworkwithdevicesserie_serie_list.AV21GXM1WorkWithDevicesSerie_Serie_ListSdt = new SdtWorkWithDevicesSerie_Serie_ListSdt(context) ;
         objworkwithdevicesserie_serie_list.context.SetSubmitInitialConfig(context);
         objworkwithdevicesserie_serie_list.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesserie_serie_list);
         aP3_GXM1WorkWithDevicesSerie_Serie_ListSdt=this.AV21GXM1WorkWithDevicesSerie_Serie_ListSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesserie_serie_list)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV17gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            Gxwebsession.Set(Gxids+"gxvar_Assistido", StringUtil.BoolToStr( AV10Assistido));
            Gxwebsession.Set(Gxids+"gxvar_Favorito", StringUtil.BoolToStr( AV7Favorito));
            Gxwebsession.Set(Gxids+"gxvar_Favoritar", AV24Favoritar_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Marcarassistido", AV25Marcarassistido_GXI);
            Gxwebsession.Set(Gxids, "true");
         }
         Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( "Séries") + "\"]";
         AV21GXM1WorkWithDevicesSerie_Serie_ListSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
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
         AV24Favoritar_GXI = "";
         AV25Marcarassistido_GXI = "";
         Gxdynprop = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV17gxid ;
      private long AV13GeneroId ;
      private String Gxids ;
      private bool AV14Lancamento ;
      private bool AV10Assistido ;
      private bool AV7Favorito ;
      private String AV24Favoritar_GXI ;
      private String AV25Marcarassistido_GXI ;
      private String Gxdynprop ;
      private SdtWorkWithDevicesSerie_Serie_ListSdt aP3_GXM1WorkWithDevicesSerie_Serie_ListSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesSerie_Serie_ListSdt AV21GXM1WorkWithDevicesSerie_Serie_ListSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesserie_serie_list_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class workwithdevicesserie_serie_list_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?GeneroId={GeneroId}&Lancamento={Lancamento}&gxid={gxid}")]
      public SdtWorkWithDevicesSerie_Serie_ListSdt_RESTInterface execute( String GeneroId ,
                                                                          bool Lancamento ,
                                                                          String gxid )
      {
         SdtWorkWithDevicesSerie_Serie_ListSdt_RESTInterface GXM1WorkWithDevicesSerie_Serie_ListSdt = new SdtWorkWithDevicesSerie_Serie_ListSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("workwithdevicesserie_serie_list") )
            {
               return null ;
            }
            workwithdevicesserie_serie_list worker = new workwithdevicesserie_serie_list(context) ;
            worker.IsMain = RunAsMain ;
            long gxrGeneroId ;
            gxrGeneroId = (long)(NumberUtil.Val( (String)(GeneroId), "."));
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtWorkWithDevicesSerie_Serie_ListSdt gxrGXM1WorkWithDevicesSerie_Serie_ListSdt = GXM1WorkWithDevicesSerie_Serie_ListSdt.sdt ;
            worker.execute(gxrGeneroId,Lancamento,gxrgxid,out gxrGXM1WorkWithDevicesSerie_Serie_ListSdt );
            worker.cleanup( );
            GXM1WorkWithDevicesSerie_Serie_ListSdt = new SdtWorkWithDevicesSerie_Serie_ListSdt_RESTInterface(gxrGXM1WorkWithDevicesSerie_Serie_ListSdt) ;
            return GXM1WorkWithDevicesSerie_Serie_ListSdt ;
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
