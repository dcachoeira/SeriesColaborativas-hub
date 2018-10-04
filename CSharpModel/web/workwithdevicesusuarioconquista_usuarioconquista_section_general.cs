/*
               File: WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_General
        Description: WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_General
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:28.27
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
   public class workwithdevicesusuarioconquista_usuarioconquista_section_general : GXProcedure
   {
      public workwithdevicesusuarioconquista_usuarioconquista_section_general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesusuarioconquista_usuarioconquista_section_general( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_UsuarioConquistaId ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt aP2_GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt )
      {
         this.A30UsuarioConquistaId = aP0_UsuarioConquistaId;
         this.AV6gxid = aP1_gxid;
         this.AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt=this.AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt;
      }

      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt executeUdp( long aP0_UsuarioConquistaId ,
                                                                                                int aP1_gxid )
      {
         this.A30UsuarioConquistaId = aP0_UsuarioConquistaId;
         this.AV6gxid = aP1_gxid;
         this.AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt=this.AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt;
         return AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt ;
      }

      public void executeSubmit( long aP0_UsuarioConquistaId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt aP2_GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt )
      {
         workwithdevicesusuarioconquista_usuarioconquista_section_general objworkwithdevicesusuarioconquista_usuarioconquista_section_general;
         objworkwithdevicesusuarioconquista_usuarioconquista_section_general = new workwithdevicesusuarioconquista_usuarioconquista_section_general();
         objworkwithdevicesusuarioconquista_usuarioconquista_section_general.A30UsuarioConquistaId = aP0_UsuarioConquistaId;
         objworkwithdevicesusuarioconquista_usuarioconquista_section_general.AV6gxid = aP1_gxid;
         objworkwithdevicesusuarioconquista_usuarioconquista_section_general.AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt(context) ;
         objworkwithdevicesusuarioconquista_usuarioconquista_section_general.context.SetSubmitInitialConfig(context);
         objworkwithdevicesusuarioconquista_usuarioconquista_section_general.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesusuarioconquista_usuarioconquista_section_general);
         aP2_GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt=this.AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesusuarioconquista_usuarioconquista_section_general)stateInfo).executePrivate();
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
         pr_default.execute(0, new Object[] {A30UsuarioConquistaId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11UsuarioId = P00002_A11UsuarioId[0];
            A27ConquistaId = P00002_A27ConquistaId[0];
            A29ConquistaNome = P00002_A29ConquistaNome[0];
            A28ConquistaPontos = P00002_A28ConquistaPontos[0];
            A31UsuarioConquistaDataHora = P00002_A31UsuarioConquistaDataHora[0];
            A29ConquistaNome = P00002_A29ConquistaNome[0];
            A28ConquistaPontos = P00002_A28ConquistaPontos[0];
            AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt.gxTpr_Usuarioconquistaid = A30UsuarioConquistaId;
            AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt.gxTpr_Usuarioid = A11UsuarioId;
            AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt.gxTpr_Conquistaid = A27ConquistaId;
            AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt.gxTpr_Conquistanome = A29ConquistaNome;
            AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt.gxTpr_Conquistapontos = A28ConquistaPontos;
            AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt.gxTpr_Usuarioconquistadatahora = A31UsuarioConquistaDataHora;
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
         P00002_A30UsuarioConquistaId = new long[1] ;
         P00002_A11UsuarioId = new long[1] ;
         P00002_A27ConquistaId = new long[1] ;
         P00002_A29ConquistaNome = new String[] {""} ;
         P00002_A28ConquistaPontos = new short[1] ;
         P00002_A31UsuarioConquistaDataHora = new DateTime[] {DateTime.MinValue} ;
         A29ConquistaNome = "";
         A31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesusuarioconquista_usuarioconquista_section_general__default(),
            new Object[][] {
                new Object[] {
               P00002_A30UsuarioConquistaId, P00002_A11UsuarioId, P00002_A27ConquistaId, P00002_A29ConquistaNome, P00002_A28ConquistaPontos, P00002_A31UsuarioConquistaDataHora
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A28ConquistaPontos ;
      private int AV6gxid ;
      private long A30UsuarioConquistaId ;
      private long A11UsuarioId ;
      private long A27ConquistaId ;
      private String scmdbuf ;
      private DateTime A31UsuarioConquistaDataHora ;
      private String A29ConquistaNome ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A30UsuarioConquistaId ;
      private long[] P00002_A11UsuarioId ;
      private long[] P00002_A27ConquistaId ;
      private String[] P00002_A29ConquistaNome ;
      private short[] P00002_A28ConquistaPontos ;
      private DateTime[] P00002_A31UsuarioConquistaDataHora ;
      private SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt aP2_GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt ;
      private SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt AV7GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt ;
   }

   public class workwithdevicesusuarioconquista_usuarioconquista_section_general__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT TOP 1 T1.[UsuarioConquistaId], T1.[UsuarioId], T1.[ConquistaId], T2.[ConquistaNome], T2.[ConquistaPontos], T1.[UsuarioConquistaDataHora] FROM ([UsuarioConquista] T1 WITH (NOLOCK) INNER JOIN [Conquista] T2 WITH (NOLOCK) ON T2.[ConquistaId] = T1.[ConquistaId]) WHERE T1.[UsuarioConquistaId] = @UsuarioConquistaId ORDER BY T1.[UsuarioConquistaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
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
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(6) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesusuarioconquista_usuarioconquista_section_general_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesusuarioconquista_usuarioconquista_section_general_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?UsuarioConquistaId={UsuarioConquistaId}&gxid={gxid}")]
    public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_RESTInterface execute( String UsuarioConquistaId ,
                                                                                                         String gxid )
    {
       SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_RESTInterface GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesusuarioconquista_usuarioconquista_section_general") )
          {
             return null ;
          }
          workwithdevicesusuarioconquista_usuarioconquista_section_general worker = new workwithdevicesusuarioconquista_usuarioconquista_section_general(context) ;
          worker.IsMain = RunAsMain ;
          long gxrUsuarioConquistaId ;
          gxrUsuarioConquistaId = (long)(NumberUtil.Val( (String)(UsuarioConquistaId), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt gxrGXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt = GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt.sdt ;
          worker.execute(gxrUsuarioConquistaId,gxrgxid,out gxrGXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt );
          worker.cleanup( );
          GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_RESTInterface(gxrGXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt) ;
          return GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt ;
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
