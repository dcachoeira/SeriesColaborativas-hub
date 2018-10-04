/*
               File: WorkWithDevicesEpisodio_Episodio_List
        Description: WorkWithDevicesEpisodio_Episodio_List
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 19:40:18.83
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
   public class workwithdevicesepisodio_episodio_list : GXProcedure
   {
      public workwithdevicesepisodio_episodio_list( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public workwithdevicesepisodio_episodio_list( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_SerieId ,
                           short aP1_EpisodioTemporada ,
                           int aP2_gxid ,
                           out SdtWorkWithDevicesEpisodio_Episodio_ListSdt aP3_GXM2WorkWithDevicesEpisodio_Episodio_ListSdt )
      {
         this.A1SerieId = aP0_SerieId;
         this.A42EpisodioTemporada = aP1_EpisodioTemporada;
         this.AV10gxid = aP2_gxid;
         this.AV15GXM2WorkWithDevicesEpisodio_Episodio_ListSdt = new SdtWorkWithDevicesEpisodio_Episodio_ListSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM2WorkWithDevicesEpisodio_Episodio_ListSdt=this.AV15GXM2WorkWithDevicesEpisodio_Episodio_ListSdt;
      }

      public SdtWorkWithDevicesEpisodio_Episodio_ListSdt executeUdp( long aP0_SerieId ,
                                                                     short aP1_EpisodioTemporada ,
                                                                     int aP2_gxid )
      {
         this.A1SerieId = aP0_SerieId;
         this.A42EpisodioTemporada = aP1_EpisodioTemporada;
         this.AV10gxid = aP2_gxid;
         this.AV15GXM2WorkWithDevicesEpisodio_Episodio_ListSdt = new SdtWorkWithDevicesEpisodio_Episodio_ListSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM2WorkWithDevicesEpisodio_Episodio_ListSdt=this.AV15GXM2WorkWithDevicesEpisodio_Episodio_ListSdt;
         return AV15GXM2WorkWithDevicesEpisodio_Episodio_ListSdt ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 short aP1_EpisodioTemporada ,
                                 int aP2_gxid ,
                                 out SdtWorkWithDevicesEpisodio_Episodio_ListSdt aP3_GXM2WorkWithDevicesEpisodio_Episodio_ListSdt )
      {
         workwithdevicesepisodio_episodio_list objworkwithdevicesepisodio_episodio_list;
         objworkwithdevicesepisodio_episodio_list = new workwithdevicesepisodio_episodio_list();
         objworkwithdevicesepisodio_episodio_list.A1SerieId = aP0_SerieId;
         objworkwithdevicesepisodio_episodio_list.A42EpisodioTemporada = aP1_EpisodioTemporada;
         objworkwithdevicesepisodio_episodio_list.AV10gxid = aP2_gxid;
         objworkwithdevicesepisodio_episodio_list.AV15GXM2WorkWithDevicesEpisodio_Episodio_ListSdt = new SdtWorkWithDevicesEpisodio_Episodio_ListSdt(context) ;
         objworkwithdevicesepisodio_episodio_list.context.SetSubmitInitialConfig(context);
         objworkwithdevicesepisodio_episodio_list.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesepisodio_episodio_list);
         aP3_GXM2WorkWithDevicesEpisodio_Episodio_ListSdt=this.AV15GXM2WorkWithDevicesEpisodio_Episodio_ListSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesepisodio_episodio_list)stateInfo).executePrivate();
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
            Gxdynprop1 = "Episódios " + StringUtil.Trim( StringUtil.Str( (decimal)(A42EpisodioTemporada), 4, 0)) + "ª temporada";
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
            Gxwebsession.Set(Gxids+"gxvar_Favorito", AV18Favorito_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Assistido", AV19Assistido_GXI);
            Gxwebsession.Set(Gxids, "true");
         }
         AV15GXM2WorkWithDevicesEpisodio_Episodio_ListSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
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
         Gxdynprop1 = "";
         Gxdynprop = "";
         AV18Favorito_GXI = "";
         AV19Assistido_GXI = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A42EpisodioTemporada ;
      private int AV10gxid ;
      private long A1SerieId ;
      private String Gxids ;
      private String Gxdynprop1 ;
      private String Gxdynprop ;
      private String AV18Favorito_GXI ;
      private String AV19Assistido_GXI ;
      private SdtWorkWithDevicesEpisodio_Episodio_ListSdt aP3_GXM2WorkWithDevicesEpisodio_Episodio_ListSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesEpisodio_Episodio_ListSdt AV15GXM2WorkWithDevicesEpisodio_Episodio_ListSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesepisodio_episodio_list_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class workwithdevicesepisodio_episodio_list_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?SerieId={SerieId}&EpisodioTemporada={EpisodioTemporada}&gxid={gxid}")]
      public SdtWorkWithDevicesEpisodio_Episodio_ListSdt_RESTInterface execute( String SerieId ,
                                                                                short EpisodioTemporada ,
                                                                                String gxid )
      {
         SdtWorkWithDevicesEpisodio_Episodio_ListSdt_RESTInterface GXM2WorkWithDevicesEpisodio_Episodio_ListSdt = new SdtWorkWithDevicesEpisodio_Episodio_ListSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("workwithdevicesepisodio_episodio_list") )
            {
               return null ;
            }
            workwithdevicesepisodio_episodio_list worker = new workwithdevicesepisodio_episodio_list(context) ;
            worker.IsMain = RunAsMain ;
            long gxrSerieId ;
            gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtWorkWithDevicesEpisodio_Episodio_ListSdt gxrGXM2WorkWithDevicesEpisodio_Episodio_ListSdt = GXM2WorkWithDevicesEpisodio_Episodio_ListSdt.sdt ;
            worker.execute(gxrSerieId,EpisodioTemporada,gxrgxid,out gxrGXM2WorkWithDevicesEpisodio_Episodio_ListSdt );
            worker.cleanup( );
            GXM2WorkWithDevicesEpisodio_Episodio_ListSdt = new SdtWorkWithDevicesEpisodio_Episodio_ListSdt_RESTInterface(gxrGXM2WorkWithDevicesEpisodio_Episodio_ListSdt) ;
            return GXM2WorkWithDevicesEpisodio_Episodio_ListSdt ;
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
