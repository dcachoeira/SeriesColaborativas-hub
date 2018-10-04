/*
               File: WorkWithDevicesNotificacao_Notificacao_Detail
        Description: WorkWithDevicesNotificacao_Notificacao_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:45:59.82
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
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
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
   public class workwithdevicesnotificacao_notificacao_detail : GXProcedure
   {
      public workwithdevicesnotificacao_notificacao_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesnotificacao_notificacao_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_NotificacaoId ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt aP2_GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt )
      {
         this.A23NotificacaoId = aP0_NotificacaoId;
         this.AV6gxid = aP1_gxid;
         this.AV11GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt = new SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt=this.AV11GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt;
      }

      public SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt executeUdp( long aP0_NotificacaoId ,
                                                                             int aP1_gxid )
      {
         this.A23NotificacaoId = aP0_NotificacaoId;
         this.AV6gxid = aP1_gxid;
         this.AV11GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt = new SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt=this.AV11GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt;
         return AV11GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt ;
      }

      public void executeSubmit( long aP0_NotificacaoId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt aP2_GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt )
      {
         workwithdevicesnotificacao_notificacao_detail objworkwithdevicesnotificacao_notificacao_detail;
         objworkwithdevicesnotificacao_notificacao_detail = new workwithdevicesnotificacao_notificacao_detail();
         objworkwithdevicesnotificacao_notificacao_detail.A23NotificacaoId = aP0_NotificacaoId;
         objworkwithdevicesnotificacao_notificacao_detail.AV6gxid = aP1_gxid;
         objworkwithdevicesnotificacao_notificacao_detail.AV11GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt = new SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt(context) ;
         objworkwithdevicesnotificacao_notificacao_detail.context.SetSubmitInitialConfig(context);
         objworkwithdevicesnotificacao_notificacao_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesnotificacao_notificacao_detail);
         aP2_GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt=this.AV11GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesnotificacao_notificacao_detail)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV6gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            /* Using cursor P00002 */
            pr_default.execute(0, new Object[] {A23NotificacaoId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A24NotificacaoTipo = P00002_A24NotificacaoTipo[0];
               Gxdynprop1 = StringUtil.Str( (decimal)(A24NotificacaoTipo), 4, 0);
               Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            Gxwebsession.Set(Gxids, "true");
         }
         AV11GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
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
         scmdbuf = "";
         P00002_A23NotificacaoId = new long[1] ;
         P00002_A24NotificacaoTipo = new short[1] ;
         Gxdynprop1 = "";
         Gxdynprop = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesnotificacao_notificacao_detail__default(),
            new Object[][] {
                new Object[] {
               P00002_A23NotificacaoId, P00002_A24NotificacaoTipo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A24NotificacaoTipo ;
      private int AV6gxid ;
      private long A23NotificacaoId ;
      private String Gxids ;
      private String scmdbuf ;
      private String Gxdynprop1 ;
      private String Gxdynprop ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A23NotificacaoId ;
      private short[] P00002_A24NotificacaoTipo ;
      private SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt aP2_GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt AV11GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt ;
   }

   public class workwithdevicesnotificacao_notificacao_detail__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00002 ;
          prmP00002 = new Object[] {
          new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [NotificacaoId], [NotificacaoTipo] FROM [Notificacao] WITH (NOLOCK) WHERE [NotificacaoId] = @NotificacaoId ORDER BY [NotificacaoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesnotificacao_notificacao_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesnotificacao_notificacao_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?NotificacaoId={NotificacaoId}&gxid={gxid}")]
    public SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt_RESTInterface execute( String NotificacaoId ,
                                                                                      String gxid )
    {
       SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt_RESTInterface GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt = new SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesnotificacao_notificacao_detail") )
          {
             return null ;
          }
          workwithdevicesnotificacao_notificacao_detail worker = new workwithdevicesnotificacao_notificacao_detail(context) ;
          worker.IsMain = RunAsMain ;
          long gxrNotificacaoId ;
          gxrNotificacaoId = (long)(NumberUtil.Val( (String)(NotificacaoId), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt gxrGXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt = GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt.sdt ;
          worker.execute(gxrNotificacaoId,gxrgxid,out gxrGXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt );
          worker.cleanup( );
          GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt = new SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt_RESTInterface(gxrGXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt) ;
          return GXM2WorkWithDevicesNotificacao_Notificacao_DetailSdt ;
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
