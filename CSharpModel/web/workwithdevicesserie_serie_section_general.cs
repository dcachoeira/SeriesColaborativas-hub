/*
               File: WorkWithDevicesSerie_Serie_Section_General
        Description: WorkWithDevicesSerie_Serie_Section_General
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:31.91
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
   public class workwithdevicesserie_serie_section_general : GXProcedure
   {
      public workwithdevicesserie_serie_section_general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesserie_serie_section_general( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_SerieId ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt aP2_GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV14gxid = aP1_gxid;
         this.AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt = new SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt=this.AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt;
      }

      public SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt executeUdp( long aP0_SerieId ,
                                                                          int aP1_gxid )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV14gxid = aP1_gxid;
         this.AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt = new SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt=this.AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt;
         return AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt aP2_GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt )
      {
         workwithdevicesserie_serie_section_general objworkwithdevicesserie_serie_section_general;
         objworkwithdevicesserie_serie_section_general = new workwithdevicesserie_serie_section_general();
         objworkwithdevicesserie_serie_section_general.A1SerieId = aP0_SerieId;
         objworkwithdevicesserie_serie_section_general.AV14gxid = aP1_gxid;
         objworkwithdevicesserie_serie_section_general.AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt = new SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt(context) ;
         objworkwithdevicesserie_serie_section_general.context.SetSubmitInitialConfig(context);
         objworkwithdevicesserie_serie_section_general.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesserie_serie_section_general);
         aP2_GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt=this.AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesserie_serie_section_general)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV14gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            Gxwebsession.Set(Gxids+"gxvar_Notaimage", AV20Notaimage_GXI);
            Gxwebsession.Set(Gxids, "true");
         }
         else
         {
            AV20Notaimage_GXI = Gxwebsession.Get(Gxids+"gxvar_Notaimage");
            AV13notaImage = "";
         }
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {A1SerieId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A40000SerieImagem_GXI = P00002_A40000SerieImagem_GXI[0];
            A2SerieNome = P00002_A2SerieNome[0];
            A48GeneroId = P00002_A48GeneroId[0];
            A49GeneroNome = P00002_A49GeneroNome[0];
            A6SerieResumo = P00002_A6SerieResumo[0];
            A3SerieQuantidadeTemporadas = P00002_A3SerieQuantidadeTemporadas[0];
            A47SerieInativo = P00002_A47SerieInativo[0];
            A60SerieDataHoraCadastro = P00002_A60SerieDataHoraCadastro[0];
            A43SerieImagem = P00002_A43SerieImagem[0];
            A49GeneroNome = P00002_A49GeneroNome[0];
            new obternotaserie(context ).execute(  A1SerieId, out  AV12Nota) ;
            if ( AV12Nota == 1 )
            {
               AV13notaImage = context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( ));
               AV20Notaimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( )));
            }
            else if ( AV12Nota == 2 )
            {
               AV13notaImage = context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( ));
               AV20Notaimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( )));
            }
            else if ( AV12Nota == 3 )
            {
               AV13notaImage = context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( ));
               AV20Notaimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( )));
            }
            else if ( AV12Nota == 4 )
            {
               AV13notaImage = context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( ));
               AV20Notaimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( )));
            }
            else if ( AV12Nota == 5 )
            {
               AV13notaImage = context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( ));
               AV20Notaimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( )));
            }
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Serieid = A1SerieId;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Serieimagem = A43SerieImagem;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Serieimagem_gxi = A40000SerieImagem_GXI;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Serienome = A2SerieNome;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Generoid = A48GeneroId;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Generonome = A49GeneroNome;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Serieresumo = A6SerieResumo;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Seriequantidadetemporadas = A3SerieQuantidadeTemporadas;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Serieinativo = A47SerieInativo;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Seriedatahoracadastro = A60SerieDataHoraCadastro;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Favorita = AV10Favorita;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Assistido = AV9Assistido;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Notaimage = AV13notaImage;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.gxTpr_Notaimage_gxi = AV20Notaimage_GXI;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         Gxwebsession.Set(Gxids+"gxvar_Notaimage", AV20Notaimage_GXI);
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
         AV20Notaimage_GXI = "";
         AV13notaImage = "";
         scmdbuf = "";
         P00002_A1SerieId = new long[1] ;
         P00002_A40000SerieImagem_GXI = new String[] {""} ;
         P00002_A2SerieNome = new String[] {""} ;
         P00002_A48GeneroId = new long[1] ;
         P00002_A49GeneroNome = new String[] {""} ;
         P00002_A6SerieResumo = new String[] {""} ;
         P00002_A3SerieQuantidadeTemporadas = new short[1] ;
         P00002_A47SerieInativo = new bool[] {false} ;
         P00002_A60SerieDataHoraCadastro = new DateTime[] {DateTime.MinValue} ;
         P00002_A43SerieImagem = new String[] {""} ;
         A40000SerieImagem_GXI = "";
         A2SerieNome = "";
         A49GeneroNome = "";
         A6SerieResumo = "";
         A60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         A43SerieImagem = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesserie_serie_section_general__default(),
            new Object[][] {
                new Object[] {
               P00002_A1SerieId, P00002_A40000SerieImagem_GXI, P00002_A2SerieNome, P00002_A48GeneroId, P00002_A49GeneroNome, P00002_A6SerieResumo, P00002_A3SerieQuantidadeTemporadas, P00002_A47SerieInativo, P00002_A60SerieDataHoraCadastro, P00002_A43SerieImagem
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A3SerieQuantidadeTemporadas ;
      private short AV12Nota ;
      private int AV14gxid ;
      private long A1SerieId ;
      private long A48GeneroId ;
      private String Gxids ;
      private String scmdbuf ;
      private DateTime A60SerieDataHoraCadastro ;
      private bool A47SerieInativo ;
      private bool AV10Favorita ;
      private bool AV9Assistido ;
      private String A6SerieResumo ;
      private String AV20Notaimage_GXI ;
      private String A40000SerieImagem_GXI ;
      private String A2SerieNome ;
      private String A49GeneroNome ;
      private String AV13notaImage ;
      private String A43SerieImagem ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A1SerieId ;
      private String[] P00002_A40000SerieImagem_GXI ;
      private String[] P00002_A2SerieNome ;
      private long[] P00002_A48GeneroId ;
      private String[] P00002_A49GeneroNome ;
      private String[] P00002_A6SerieResumo ;
      private short[] P00002_A3SerieQuantidadeTemporadas ;
      private bool[] P00002_A47SerieInativo ;
      private DateTime[] P00002_A60SerieDataHoraCadastro ;
      private String[] P00002_A43SerieImagem ;
      private SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt aP2_GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt AV17GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt ;
   }

   public class workwithdevicesserie_serie_section_general__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT TOP 1 T1.[SerieId], T1.[SerieImagem_GXI], T1.[SerieNome], T1.[GeneroId], T2.[GeneroNome], T1.[SerieResumo], T1.[SerieQuantidadeTemporadas], T1.[SerieInativo], T1.[SerieDataHoraCadastro], T1.[SerieImagem] FROM ([Serie] T1 WITH (NOLOCK) INNER JOIN [Genero] T2 WITH (NOLOCK) ON T2.[GeneroId] = T1.[GeneroId]) WHERE T1.[SerieId] = @SerieId ORDER BY T1.[SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,true,true )
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
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((bool[]) buf[7])[0] = rslt.getBool(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(9) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(2)) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesserie_serie_section_general_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesserie_serie_section_general_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?SerieId={SerieId}&gxid={gxid}")]
    public SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_RESTInterface execute( String SerieId ,
                                                                                   String gxid )
    {
       SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_RESTInterface GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt = new SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesserie_serie_section_general") )
          {
             return null ;
          }
          workwithdevicesserie_serie_section_general worker = new workwithdevicesserie_serie_section_general(context) ;
          worker.IsMain = RunAsMain ;
          long gxrSerieId ;
          gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt gxrGXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt = GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt.sdt ;
          worker.execute(gxrSerieId,gxrgxid,out gxrGXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt );
          worker.cleanup( );
          GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt = new SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_RESTInterface(gxrGXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt) ;
          return GXM1WorkWithDevicesSerie_Serie_Section_GeneralSdt ;
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
