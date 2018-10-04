/*
               File: SeriesColaborativas_Level_Detail
        Description: SeriesColaborativas_Level_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/13/2018 16:41:22.81
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
   public class seriescolaborativas_level_detail : GXProcedure
   {
      public seriescolaborativas_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public seriescolaborativas_level_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( int aP0_gxid ,
                           out SdtSeriesColaborativas_Level_DetailSdt aP1_GXM1SeriesColaborativas_Level_DetailSdt )
      {
         this.AV15gxid = aP0_gxid;
         this.AV19GXM1SeriesColaborativas_Level_DetailSdt = new SdtSeriesColaborativas_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1SeriesColaborativas_Level_DetailSdt=this.AV19GXM1SeriesColaborativas_Level_DetailSdt;
      }

      public SdtSeriesColaborativas_Level_DetailSdt executeUdp( int aP0_gxid )
      {
         this.AV15gxid = aP0_gxid;
         this.AV19GXM1SeriesColaborativas_Level_DetailSdt = new SdtSeriesColaborativas_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1SeriesColaborativas_Level_DetailSdt=this.AV19GXM1SeriesColaborativas_Level_DetailSdt;
         return AV19GXM1SeriesColaborativas_Level_DetailSdt ;
      }

      public void executeSubmit( int aP0_gxid ,
                                 out SdtSeriesColaborativas_Level_DetailSdt aP1_GXM1SeriesColaborativas_Level_DetailSdt )
      {
         seriescolaborativas_level_detail objseriescolaborativas_level_detail;
         objseriescolaborativas_level_detail = new seriescolaborativas_level_detail();
         objseriescolaborativas_level_detail.AV15gxid = aP0_gxid;
         objseriescolaborativas_level_detail.AV19GXM1SeriesColaborativas_Level_DetailSdt = new SdtSeriesColaborativas_Level_DetailSdt(context) ;
         objseriescolaborativas_level_detail.context.SetSubmitInitialConfig(context);
         objseriescolaborativas_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objseriescolaborativas_level_detail);
         aP1_GXM1SeriesColaborativas_Level_DetailSdt=this.AV19GXM1SeriesColaborativas_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((seriescolaborativas_level_detail)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV15gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            AV13UsuarioId = 2;
            new buscardadosusuario(context ).execute(  AV13UsuarioId, out  AV5UsuarioNome, out  AV12UsuarioTitulo, out  AV11ImagemUsuario) ;
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( "Meu perfil") + "\"]";
            Gxwebsession.Set(Gxids+"gxvar_Imagemusuario", AV22Imagemusuario_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Usuarionome", AV5UsuarioNome);
            Gxwebsession.Set(Gxids+"gxvar_Usuariotitulo", AV12UsuarioTitulo);
            Gxwebsession.Set(Gxids, "true");
         }
         else
         {
            AV22Imagemusuario_GXI = Gxwebsession.Get(Gxids+"gxvar_Imagemusuario");
            AV11ImagemUsuario = "";
            AV12UsuarioTitulo = Gxwebsession.Get(Gxids+"gxvar_Usuariotitulo");
            AV5UsuarioNome = Gxwebsession.Get(Gxids+"gxvar_Usuarionome");
         }
         AV19GXM1SeriesColaborativas_Level_DetailSdt.gxTpr_Imagemusuario = AV11ImagemUsuario;
         AV19GXM1SeriesColaborativas_Level_DetailSdt.gxTpr_Imagemusuario_gxi = AV22Imagemusuario_GXI;
         AV19GXM1SeriesColaborativas_Level_DetailSdt.gxTpr_Usuarionome = AV5UsuarioNome;
         AV19GXM1SeriesColaborativas_Level_DetailSdt.gxTpr_Usuariotitulo = AV12UsuarioTitulo;
         AV19GXM1SeriesColaborativas_Level_DetailSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
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
         AV5UsuarioNome = "";
         AV12UsuarioTitulo = "";
         AV11ImagemUsuario = "";
         Gxdynprop = "";
         AV22Imagemusuario_GXI = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV15gxid ;
      private long AV13UsuarioId ;
      private String Gxids ;
      private String AV5UsuarioNome ;
      private String AV12UsuarioTitulo ;
      private String Gxdynprop ;
      private String AV22Imagemusuario_GXI ;
      private String AV11ImagemUsuario ;
      private SdtSeriesColaborativas_Level_DetailSdt aP1_GXM1SeriesColaborativas_Level_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtSeriesColaborativas_Level_DetailSdt AV19GXM1SeriesColaborativas_Level_DetailSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.seriescolaborativas_level_detail_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class seriescolaborativas_level_detail_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?gxid={gxid}")]
      public SdtSeriesColaborativas_Level_DetailSdt_RESTInterface execute( String gxid )
      {
         SdtSeriesColaborativas_Level_DetailSdt_RESTInterface GXM1SeriesColaborativas_Level_DetailSdt = new SdtSeriesColaborativas_Level_DetailSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("seriescolaborativas_level_detail") )
            {
               return null ;
            }
            seriescolaborativas_level_detail worker = new seriescolaborativas_level_detail(context) ;
            worker.IsMain = RunAsMain ;
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtSeriesColaborativas_Level_DetailSdt gxrGXM1SeriesColaborativas_Level_DetailSdt = GXM1SeriesColaborativas_Level_DetailSdt.sdt ;
            worker.execute(gxrgxid,out gxrGXM1SeriesColaborativas_Level_DetailSdt );
            worker.cleanup( );
            GXM1SeriesColaborativas_Level_DetailSdt = new SdtSeriesColaborativas_Level_DetailSdt_RESTInterface(gxrGXM1SeriesColaborativas_Level_DetailSdt) ;
            return GXM1SeriesColaborativas_Level_DetailSdt ;
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
