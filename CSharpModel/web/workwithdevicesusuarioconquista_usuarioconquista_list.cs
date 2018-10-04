/*
               File: WorkWithDevicesUsuarioConquista_UsuarioConquista_List
        Description: WorkWithDevicesUsuarioConquista_UsuarioConquista_List
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:28.7
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
   public class workwithdevicesusuarioconquista_usuarioconquista_list : GXProcedure
   {
      public workwithdevicesusuarioconquista_usuarioconquista_list( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public workwithdevicesusuarioconquista_usuarioconquista_list( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_UsuarioId ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt aP2_GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt )
      {
         this.AV5UsuarioId = aP0_UsuarioId;
         this.AV8gxid = aP1_gxid;
         this.AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt=this.AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt;
      }

      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt executeUdp( long aP0_UsuarioId ,
                                                                                     int aP1_gxid )
      {
         this.AV5UsuarioId = aP0_UsuarioId;
         this.AV8gxid = aP1_gxid;
         this.AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt=this.AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt;
         return AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt ;
      }

      public void executeSubmit( long aP0_UsuarioId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt aP2_GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt )
      {
         workwithdevicesusuarioconquista_usuarioconquista_list objworkwithdevicesusuarioconquista_usuarioconquista_list;
         objworkwithdevicesusuarioconquista_usuarioconquista_list = new workwithdevicesusuarioconquista_usuarioconquista_list();
         objworkwithdevicesusuarioconquista_usuarioconquista_list.AV5UsuarioId = aP0_UsuarioId;
         objworkwithdevicesusuarioconquista_usuarioconquista_list.AV8gxid = aP1_gxid;
         objworkwithdevicesusuarioconquista_usuarioconquista_list.AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt(context) ;
         objworkwithdevicesusuarioconquista_usuarioconquista_list.context.SetSubmitInitialConfig(context);
         objworkwithdevicesusuarioconquista_usuarioconquista_list.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesusuarioconquista_usuarioconquista_list);
         aP2_GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt=this.AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesusuarioconquista_usuarioconquista_list)stateInfo).executePrivate();
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
            Gxwebsession.Set(Gxids+"gxvar_Conquistasid", AV6ConquistasId.ToJSonString(false));
            Gxwebsession.Set(Gxids+"gxvar_Conquistaid", StringUtil.Str( (decimal)(AV7ConquistaId), 18, 0));
            Gxwebsession.Set(Gxids, "true");
         }
         else
         {
            AV6ConquistasId.FromJSonString(Gxwebsession.Get(Gxids+"gxvar_Conquistasid"), null);
         }
         Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( "Conquistas") + "\"]";
         new buscarconquistasusuario(context ).execute(  2, out  AV6ConquistasId) ;
         AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
         Gxdynprop = "";
         Gxwebsession.Set(Gxids+"gxvar_Conquistasid", AV6ConquistasId.ToJSonString(false));
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
         AV6ConquistasId = new GxSimpleCollection<long>();
         Gxdynprop = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV8gxid ;
      private long AV5UsuarioId ;
      private long AV7ConquistaId ;
      private String Gxids ;
      private String Gxdynprop ;
      private GxSimpleCollection<long> AV6ConquistasId ;
      private SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt aP2_GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesusuarioconquista_usuarioconquista_list_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class workwithdevicesusuarioconquista_usuarioconquista_list_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?UsuarioId={UsuarioId}&gxid={gxid}")]
      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt_RESTInterface execute( String UsuarioId ,
                                                                                                String gxid )
      {
         SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt_RESTInterface GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("workwithdevicesusuarioconquista_usuarioconquista_list") )
            {
               return null ;
            }
            workwithdevicesusuarioconquista_usuarioconquista_list worker = new workwithdevicesusuarioconquista_usuarioconquista_list(context) ;
            worker.IsMain = RunAsMain ;
            long gxrUsuarioId ;
            gxrUsuarioId = (long)(NumberUtil.Val( (String)(UsuarioId), "."));
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt gxrGXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt = GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt.sdt ;
            worker.execute(gxrUsuarioId,gxrgxid,out gxrGXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt );
            worker.cleanup( );
            GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt_RESTInterface(gxrGXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt) ;
            return GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt ;
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
