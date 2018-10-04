/*
               File: WorkWithDevicesNotificacao_Notificacao_List
        Description: WorkWithDevicesNotificacao_Notificacao_List
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:45:59.59
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
   public class workwithdevicesnotificacao_notificacao_list : GXProcedure
   {
      public workwithdevicesnotificacao_notificacao_list( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public workwithdevicesnotificacao_notificacao_list( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( int aP0_gxid ,
                           out SdtWorkWithDevicesNotificacao_Notificacao_ListSdt aP1_GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt )
      {
         this.AV5gxid = aP0_gxid;
         this.AV7GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt = new SdtWorkWithDevicesNotificacao_Notificacao_ListSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt=this.AV7GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt;
      }

      public SdtWorkWithDevicesNotificacao_Notificacao_ListSdt executeUdp( int aP0_gxid )
      {
         this.AV5gxid = aP0_gxid;
         this.AV7GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt = new SdtWorkWithDevicesNotificacao_Notificacao_ListSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt=this.AV7GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt;
         return AV7GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt ;
      }

      public void executeSubmit( int aP0_gxid ,
                                 out SdtWorkWithDevicesNotificacao_Notificacao_ListSdt aP1_GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt )
      {
         workwithdevicesnotificacao_notificacao_list objworkwithdevicesnotificacao_notificacao_list;
         objworkwithdevicesnotificacao_notificacao_list = new workwithdevicesnotificacao_notificacao_list();
         objworkwithdevicesnotificacao_notificacao_list.AV5gxid = aP0_gxid;
         objworkwithdevicesnotificacao_notificacao_list.AV7GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt = new SdtWorkWithDevicesNotificacao_Notificacao_ListSdt(context) ;
         objworkwithdevicesnotificacao_notificacao_list.context.SetSubmitInitialConfig(context);
         objworkwithdevicesnotificacao_notificacao_list.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesnotificacao_notificacao_list);
         aP1_GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt=this.AV7GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesnotificacao_notificacao_list)stateInfo).executePrivate();
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
         Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( "Notificações") + "\"]";
         AV7GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
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
         Gxdynprop = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV5gxid ;
      private String Gxdynprop ;
      private SdtWorkWithDevicesNotificacao_Notificacao_ListSdt aP1_GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt ;
      private SdtWorkWithDevicesNotificacao_Notificacao_ListSdt AV7GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesnotificacao_notificacao_list_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class workwithdevicesnotificacao_notificacao_list_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?gxid={gxid}")]
      public SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_RESTInterface execute( String gxid )
      {
         SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_RESTInterface GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt = new SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_RESTInterface() ;
         try
         {
            if ( ! ProcessHeaders("workwithdevicesnotificacao_notificacao_list") )
            {
               return null ;
            }
            workwithdevicesnotificacao_notificacao_list worker = new workwithdevicesnotificacao_notificacao_list(context) ;
            worker.IsMain = RunAsMain ;
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            SdtWorkWithDevicesNotificacao_Notificacao_ListSdt gxrGXM1WorkWithDevicesNotificacao_Notificacao_ListSdt = GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt.sdt ;
            worker.execute(gxrgxid,out gxrGXM1WorkWithDevicesNotificacao_Notificacao_ListSdt );
            worker.cleanup( );
            GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt = new SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_RESTInterface(gxrGXM1WorkWithDevicesNotificacao_Notificacao_ListSdt) ;
            return GXM1WorkWithDevicesNotificacao_Notificacao_ListSdt ;
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
