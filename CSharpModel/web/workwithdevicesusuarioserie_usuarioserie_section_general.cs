/*
               File: WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_General
        Description: WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_General
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:46:0.26
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
   public class workwithdevicesusuarioserie_usuarioserie_section_general : GXProcedure
   {
      public workwithdevicesusuarioserie_usuarioserie_section_general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesusuarioserie_usuarioserie_section_general( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_UsuarioSerieId ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt aP2_GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt )
      {
         this.A13UsuarioSerieId = aP0_UsuarioSerieId;
         this.AV7gxid = aP1_gxid;
         this.AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt=this.AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt;
      }

      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt executeUdp( long aP0_UsuarioSerieId ,
                                                                                        int aP1_gxid )
      {
         this.A13UsuarioSerieId = aP0_UsuarioSerieId;
         this.AV7gxid = aP1_gxid;
         this.AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt=this.AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt;
         return AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt ;
      }

      public void executeSubmit( long aP0_UsuarioSerieId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt aP2_GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt )
      {
         workwithdevicesusuarioserie_usuarioserie_section_general objworkwithdevicesusuarioserie_usuarioserie_section_general;
         objworkwithdevicesusuarioserie_usuarioserie_section_general = new workwithdevicesusuarioserie_usuarioserie_section_general();
         objworkwithdevicesusuarioserie_usuarioserie_section_general.A13UsuarioSerieId = aP0_UsuarioSerieId;
         objworkwithdevicesusuarioserie_usuarioserie_section_general.AV7gxid = aP1_gxid;
         objworkwithdevicesusuarioserie_usuarioserie_section_general.AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt(context) ;
         objworkwithdevicesusuarioserie_usuarioserie_section_general.context.SetSubmitInitialConfig(context);
         objworkwithdevicesusuarioserie_usuarioserie_section_general.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesusuarioserie_usuarioserie_section_general);
         aP2_GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt=this.AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesusuarioserie_usuarioserie_section_general)stateInfo).executePrivate();
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
         pr_default.execute(0, new Object[] {A13UsuarioSerieId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A48GeneroId = P00002_A48GeneroId[0];
            A40000SerieImagem_GXI = P00002_A40000SerieImagem_GXI[0];
            A11UsuarioId = P00002_A11UsuarioId[0];
            A1SerieId = P00002_A1SerieId[0];
            A14UsuarioSerieNota = P00002_A14UsuarioSerieNota[0];
            A15UsuarioSerieAssistida = P00002_A15UsuarioSerieAssistida[0];
            A16UsuarioSerieComentario = P00002_A16UsuarioSerieComentario[0];
            A17UsuarioSerieFavorita = P00002_A17UsuarioSerieFavorita[0];
            A2SerieNome = P00002_A2SerieNome[0];
            A49GeneroNome = P00002_A49GeneroNome[0];
            A43SerieImagem = P00002_A43SerieImagem[0];
            A48GeneroId = P00002_A48GeneroId[0];
            A40000SerieImagem_GXI = P00002_A40000SerieImagem_GXI[0];
            A2SerieNome = P00002_A2SerieNome[0];
            A43SerieImagem = P00002_A43SerieImagem[0];
            A49GeneroNome = P00002_A49GeneroNome[0];
            AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.gxTpr_Usuarioserieid = A13UsuarioSerieId;
            AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.gxTpr_Usuarioid = A11UsuarioId;
            AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.gxTpr_Serieid = A1SerieId;
            AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.gxTpr_Usuarioserienota = A14UsuarioSerieNota;
            AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.gxTpr_Usuarioserieassistida = A15UsuarioSerieAssistida;
            AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.gxTpr_Usuarioseriecomentario = A16UsuarioSerieComentario;
            AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.gxTpr_Usuarioseriefavorita = A17UsuarioSerieFavorita;
            AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.gxTpr_Serienome = A2SerieNome;
            AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.gxTpr_Serieimagem = A43SerieImagem;
            AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.gxTpr_Serieimagem_gxi = A40000SerieImagem_GXI;
            AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.gxTpr_Generonome = A49GeneroNome;
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
         P00002_A48GeneroId = new long[1] ;
         P00002_A13UsuarioSerieId = new long[1] ;
         P00002_A40000SerieImagem_GXI = new String[] {""} ;
         P00002_A11UsuarioId = new long[1] ;
         P00002_A1SerieId = new long[1] ;
         P00002_A14UsuarioSerieNota = new short[1] ;
         P00002_A15UsuarioSerieAssistida = new bool[] {false} ;
         P00002_A16UsuarioSerieComentario = new String[] {""} ;
         P00002_A17UsuarioSerieFavorita = new bool[] {false} ;
         P00002_A2SerieNome = new String[] {""} ;
         P00002_A49GeneroNome = new String[] {""} ;
         P00002_A43SerieImagem = new String[] {""} ;
         A40000SerieImagem_GXI = "";
         A16UsuarioSerieComentario = "";
         A2SerieNome = "";
         A49GeneroNome = "";
         A43SerieImagem = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesusuarioserie_usuarioserie_section_general__default(),
            new Object[][] {
                new Object[] {
               P00002_A48GeneroId, P00002_A13UsuarioSerieId, P00002_A40000SerieImagem_GXI, P00002_A11UsuarioId, P00002_A1SerieId, P00002_A14UsuarioSerieNota, P00002_A15UsuarioSerieAssistida, P00002_A16UsuarioSerieComentario, P00002_A17UsuarioSerieFavorita, P00002_A2SerieNome,
               P00002_A49GeneroNome, P00002_A43SerieImagem
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A14UsuarioSerieNota ;
      private int AV7gxid ;
      private long A13UsuarioSerieId ;
      private long A48GeneroId ;
      private long A11UsuarioId ;
      private long A1SerieId ;
      private String scmdbuf ;
      private bool A15UsuarioSerieAssistida ;
      private bool A17UsuarioSerieFavorita ;
      private String A40000SerieImagem_GXI ;
      private String A16UsuarioSerieComentario ;
      private String A2SerieNome ;
      private String A49GeneroNome ;
      private String A43SerieImagem ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A48GeneroId ;
      private long[] P00002_A13UsuarioSerieId ;
      private String[] P00002_A40000SerieImagem_GXI ;
      private long[] P00002_A11UsuarioId ;
      private long[] P00002_A1SerieId ;
      private short[] P00002_A14UsuarioSerieNota ;
      private bool[] P00002_A15UsuarioSerieAssistida ;
      private String[] P00002_A16UsuarioSerieComentario ;
      private bool[] P00002_A17UsuarioSerieFavorita ;
      private String[] P00002_A2SerieNome ;
      private String[] P00002_A49GeneroNome ;
      private String[] P00002_A43SerieImagem ;
      private SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt aP2_GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt ;
      private SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt AV8GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt ;
   }

   public class workwithdevicesusuarioserie_usuarioserie_section_general__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT TOP 1 T2.[GeneroId], T1.[UsuarioSerieId], T2.[SerieImagem_GXI], T1.[UsuarioId], T1.[SerieId], T1.[UsuarioSerieNota], T1.[UsuarioSerieAssistida], T1.[UsuarioSerieComentario], T1.[UsuarioSerieFavorita], T2.[SerieNome], T3.[GeneroNome], T2.[SerieImagem] FROM (([UsuarioSerie] T1 WITH (NOLOCK) INNER JOIN [Serie] T2 WITH (NOLOCK) ON T2.[SerieId] = T1.[SerieId]) INNER JOIN [Genero] T3 WITH (NOLOCK) ON T3.[GeneroId] = T2.[GeneroId]) WHERE T1.[UsuarioSerieId] = @UsuarioSerieId ORDER BY T1.[UsuarioSerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
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
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((bool[]) buf[6])[0] = rslt.getBool(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[8])[0] = rslt.getBool(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getMultimediaFile(12, rslt.getVarchar(3)) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesusuarioserie_usuarioserie_section_general_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesusuarioserie_usuarioserie_section_general_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?UsuarioSerieId={UsuarioSerieId}&gxid={gxid}")]
    public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_RESTInterface execute( String UsuarioSerieId ,
                                                                                                 String gxid )
    {
       SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_RESTInterface GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesusuarioserie_usuarioserie_section_general") )
          {
             return null ;
          }
          workwithdevicesusuarioserie_usuarioserie_section_general worker = new workwithdevicesusuarioserie_usuarioserie_section_general(context) ;
          worker.IsMain = RunAsMain ;
          long gxrUsuarioSerieId ;
          gxrUsuarioSerieId = (long)(NumberUtil.Val( (String)(UsuarioSerieId), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt gxrGXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt = GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.sdt ;
          worker.execute(gxrUsuarioSerieId,gxrgxid,out gxrGXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt );
          worker.cleanup( );
          GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_RESTInterface(gxrGXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt) ;
          return GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt ;
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
