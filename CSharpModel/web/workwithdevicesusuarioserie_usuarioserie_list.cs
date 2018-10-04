/*
               File: WorkWithDevicesUsuarioSerie_UsuarioSerie_List
        Description: WorkWithDevicesUsuarioSerie_UsuarioSerie_List
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:45:59.65
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
   public class workwithdevicesusuarioserie_usuarioserie_list : GXProcedure
   {
      public workwithdevicesusuarioserie_usuarioserie_list( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public workwithdevicesusuarioserie_usuarioserie_list( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_UsuarioId ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt aP2_GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt )
      {
         this.AV9UsuarioId = aP0_UsuarioId;
         this.AV12gxid = aP1_gxid;
         this.AV17GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt=this.AV17GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt;
      }

      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt executeUdp( long aP0_UsuarioId ,
                                                                             int aP1_gxid )
      {
         this.AV9UsuarioId = aP0_UsuarioId;
         this.AV12gxid = aP1_gxid;
         this.AV17GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt=this.AV17GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt;
         return AV17GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt ;
      }

      public void executeSubmit( long aP0_UsuarioId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt aP2_GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt )
      {
         workwithdevicesusuarioserie_usuarioserie_list objworkwithdevicesusuarioserie_usuarioserie_list;
         objworkwithdevicesusuarioserie_usuarioserie_list = new workwithdevicesusuarioserie_usuarioserie_list();
         objworkwithdevicesusuarioserie_usuarioserie_list.AV9UsuarioId = aP0_UsuarioId;
         objworkwithdevicesusuarioserie_usuarioserie_list.AV12gxid = aP1_gxid;
         objworkwithdevicesusuarioserie_usuarioserie_list.AV17GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt(context) ;
         objworkwithdevicesusuarioserie_usuarioserie_list.context.SetSubmitInitialConfig(context);
         objworkwithdevicesusuarioserie_usuarioserie_list.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesusuarioserie_usuarioserie_list);
         aP2_GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt=this.AV17GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesusuarioserie_usuarioserie_list)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV12gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            AV9UsuarioId = 2;
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( "Minhas séries") + "\"]";
            new verificarpossuiseriefavorita(context ).execute(  AV9UsuarioId, out  AV10Possui) ;
            if ( ! AV10Possui )
            {
               Gxdyncall = Gxdyncall + ((StringUtil.StrCmp(Gxdyncall, "")==0) ? "" : ", ") + "\"" + "sd:sdfavoritos" + "\"";
            }
            Gxwebsession.Set(Gxids+"gxvar_Assistido", StringUtil.BoolToStr( AV5Assistido));
            Gxwebsession.Set(Gxids+"gxvar_Favorito", StringUtil.BoolToStr( AV6Favorito));
            Gxwebsession.Set(Gxids+"gxvar_Favoritar", AV20Favoritar_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Marcarassistido", AV21Marcarassistido_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Usuarioid", StringUtil.Str( (decimal)(AV9UsuarioId), 18, 0));
            Gxwebsession.Set(Gxids, "true");
         }
         else
         {
            AV9UsuarioId = (long)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Usuarioid"), "."));
         }
         AV9UsuarioId = 2;
         new verificarpossuiseriefavorita(context ).execute(  AV9UsuarioId, out  AV10Possui) ;
         if ( ! AV10Possui )
         {
            Gxdyncall = Gxdyncall + ((StringUtil.StrCmp(Gxdyncall, "")==0) ? "" : ", ") + "\"" + "sd:sdfavoritos" + "\"";
         }
         AV17GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt.gxTpr_Usuarioid = AV9UsuarioId;
         AV17GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
         Gxdynprop = "";
         AV17GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt.gxTpr_Gxdyncall = "[ "+Gxdyncall+" ]";
         Gxdyncall = "";
         Gxwebsession.Set(Gxids+"gxvar_Usuarioid", StringUtil.Str( (decimal)(AV9UsuarioId), 18, 0));
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
         Gxdyncall = "";
         AV20Favoritar_GXI = "";
         AV21Marcarassistido_GXI = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV12gxid ;
      private long AV9UsuarioId ;
      private String Gxids ;
      private bool AV10Possui ;
      private bool AV5Assistido ;
      private bool AV6Favorito ;
      private String Gxdynprop ;
      private String Gxdyncall ;
      private String AV20Favoritar_GXI ;
      private String AV21Marcarassistido_GXI ;
      private SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt aP2_GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt AV17GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesusuarioserie_usuarioserie_list_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class workwithdevicesusuarioserie_usuarioserie_list_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?UsuarioId={UsuarioId}&gxid={gxid}")]
      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_RESTInterface execute( String UsuarioId ,
                                                                                        String gxid )
      {
         SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_RESTInterface GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("workwithdevicesusuarioserie_usuarioserie_list") )
            {
               return null ;
            }
            workwithdevicesusuarioserie_usuarioserie_list worker = new workwithdevicesusuarioserie_usuarioserie_list(context) ;
            worker.IsMain = RunAsMain ;
            long gxrUsuarioId ;
            gxrUsuarioId = (long)(NumberUtil.Val( (String)(UsuarioId), "."));
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt gxrGXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt = GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt.sdt ;
            worker.execute(gxrUsuarioId,gxrgxid,out gxrGXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt );
            worker.cleanup( );
            GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_RESTInterface(gxrGXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt) ;
            return GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt ;
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
