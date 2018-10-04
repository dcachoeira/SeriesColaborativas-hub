/*
               File: WorkWithDevicesNotificacao_Notificacao_Section_General
        Description: WorkWithDevicesNotificacao_Notificacao_Section_General
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:46:0.13
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
   public class workwithdevicesnotificacao_notificacao_section_general : GXProcedure
   {
      public workwithdevicesnotificacao_notificacao_section_general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesnotificacao_notificacao_section_general( IGxContext context )
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
                           out SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt aP2_GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt )
      {
         this.A23NotificacaoId = aP0_NotificacaoId;
         this.AV6gxid = aP1_gxid;
         this.AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt = new SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt=this.AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt;
      }

      public SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt executeUdp( long aP0_NotificacaoId ,
                                                                                      int aP1_gxid )
      {
         this.A23NotificacaoId = aP0_NotificacaoId;
         this.AV6gxid = aP1_gxid;
         this.AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt = new SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt=this.AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt;
         return AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt ;
      }

      public void executeSubmit( long aP0_NotificacaoId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt aP2_GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt )
      {
         workwithdevicesnotificacao_notificacao_section_general objworkwithdevicesnotificacao_notificacao_section_general;
         objworkwithdevicesnotificacao_notificacao_section_general = new workwithdevicesnotificacao_notificacao_section_general();
         objworkwithdevicesnotificacao_notificacao_section_general.A23NotificacaoId = aP0_NotificacaoId;
         objworkwithdevicesnotificacao_notificacao_section_general.AV6gxid = aP1_gxid;
         objworkwithdevicesnotificacao_notificacao_section_general.AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt = new SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt(context) ;
         objworkwithdevicesnotificacao_notificacao_section_general.context.SetSubmitInitialConfig(context);
         objworkwithdevicesnotificacao_notificacao_section_general.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesnotificacao_notificacao_section_general);
         aP2_GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt=this.AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesnotificacao_notificacao_section_general)stateInfo).executePrivate();
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
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {A23NotificacaoId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11UsuarioId = P00002_A11UsuarioId[0];
            A24NotificacaoTipo = P00002_A24NotificacaoTipo[0];
            A25NotificacaoTexto = P00002_A25NotificacaoTexto[0];
            A61NotificacaoLigacaoId = P00002_A61NotificacaoLigacaoId[0];
            n61NotificacaoLigacaoId = P00002_n61NotificacaoLigacaoId[0];
            A26NotificacaoDataHoraEnvio = P00002_A26NotificacaoDataHoraEnvio[0];
            AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt.gxTpr_Notificacaoid = A23NotificacaoId;
            AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt.gxTpr_Usuarioid = A11UsuarioId;
            AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt.gxTpr_Notificacaotipo = A24NotificacaoTipo;
            AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt.gxTpr_Notificacaotexto = A25NotificacaoTexto;
            AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt.gxTpr_Notificacaoligacaoid = A61NotificacaoLigacaoId;
            AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt.gxTpr_Notificacaodatahoraenvio = A26NotificacaoDataHoraEnvio;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
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
         scmdbuf = "";
         P00002_A23NotificacaoId = new long[1] ;
         P00002_A11UsuarioId = new long[1] ;
         P00002_A24NotificacaoTipo = new short[1] ;
         P00002_A25NotificacaoTexto = new String[] {""} ;
         P00002_A61NotificacaoLigacaoId = new long[1] ;
         P00002_n61NotificacaoLigacaoId = new bool[] {false} ;
         P00002_A26NotificacaoDataHoraEnvio = new DateTime[] {DateTime.MinValue} ;
         A25NotificacaoTexto = "";
         A26NotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesnotificacao_notificacao_section_general__default(),
            new Object[][] {
                new Object[] {
               P00002_A23NotificacaoId, P00002_A11UsuarioId, P00002_A24NotificacaoTipo, P00002_A25NotificacaoTexto, P00002_A61NotificacaoLigacaoId, P00002_n61NotificacaoLigacaoId, P00002_A26NotificacaoDataHoraEnvio
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A24NotificacaoTipo ;
      private int AV6gxid ;
      private long A23NotificacaoId ;
      private long A11UsuarioId ;
      private long A61NotificacaoLigacaoId ;
      private String scmdbuf ;
      private DateTime A26NotificacaoDataHoraEnvio ;
      private bool n61NotificacaoLigacaoId ;
      private String A25NotificacaoTexto ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A23NotificacaoId ;
      private long[] P00002_A11UsuarioId ;
      private short[] P00002_A24NotificacaoTipo ;
      private String[] P00002_A25NotificacaoTexto ;
      private long[] P00002_A61NotificacaoLigacaoId ;
      private bool[] P00002_n61NotificacaoLigacaoId ;
      private DateTime[] P00002_A26NotificacaoDataHoraEnvio ;
      private SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt aP2_GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt ;
      private SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt AV7GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt ;
   }

   public class workwithdevicesnotificacao_notificacao_section_general__default : DataStoreHelperBase, IDataStoreHelper
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
              new CursorDef("P00002", "SELECT TOP 1 [NotificacaoId], [UsuarioId], [NotificacaoTipo], [NotificacaoTexto], [NotificacaoLigacaoId], [NotificacaoDataHoraEnvio] FROM [Notificacao] WITH (NOLOCK) WHERE [NotificacaoId] = @NotificacaoId ORDER BY [NotificacaoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(6) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesnotificacao_notificacao_section_general_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesnotificacao_notificacao_section_general_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?NotificacaoId={NotificacaoId}&gxid={gxid}")]
    public SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_RESTInterface execute( String NotificacaoId ,
                                                                                               String gxid )
    {
       SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_RESTInterface GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt = new SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesnotificacao_notificacao_section_general") )
          {
             return null ;
          }
          workwithdevicesnotificacao_notificacao_section_general worker = new workwithdevicesnotificacao_notificacao_section_general(context) ;
          worker.IsMain = RunAsMain ;
          long gxrNotificacaoId ;
          gxrNotificacaoId = (long)(NumberUtil.Val( (String)(NotificacaoId), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt gxrGXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt = GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt.sdt ;
          worker.execute(gxrNotificacaoId,gxrgxid,out gxrGXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt );
          worker.cleanup( );
          GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt = new SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_RESTInterface(gxrGXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt) ;
          return GXM1WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt ;
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
