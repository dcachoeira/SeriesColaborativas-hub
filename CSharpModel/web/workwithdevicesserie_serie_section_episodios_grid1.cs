/*
               File: WorkWithDevicesSerie_Serie_Section_Episodios_Grid1
        Description: WorkWithDevicesSerie_Serie_Section_Episodios_Grid1
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/13/2018 16:23:58.41
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
   public class workwithdevicesserie_serie_section_episodios_grid1 : GXProcedure
   {
      public workwithdevicesserie_serie_section_episodios_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesserie_serie_section_episodios_grid1( IGxContext context )
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
                           long aP1_start ,
                           long aP2_count ,
                           int aP3_gxid ,
                           out GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item> aP4_GXM2RootCol )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV10start = aP1_start;
         this.AV11count = aP2_count;
         this.AV9gxid = aP3_gxid;
         this.AV12GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM2RootCol=this.AV12GXM2RootCol;
      }

      public GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item> executeUdp( long aP0_SerieId ,
                                                                                                         long aP1_start ,
                                                                                                         long aP2_count ,
                                                                                                         int aP3_gxid )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV10start = aP1_start;
         this.AV11count = aP2_count;
         this.AV9gxid = aP3_gxid;
         this.AV12GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM2RootCol=this.AV12GXM2RootCol;
         return AV12GXM2RootCol ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 long aP1_start ,
                                 long aP2_count ,
                                 int aP3_gxid ,
                                 out GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item> aP4_GXM2RootCol )
      {
         workwithdevicesserie_serie_section_episodios_grid1 objworkwithdevicesserie_serie_section_episodios_grid1;
         objworkwithdevicesserie_serie_section_episodios_grid1 = new workwithdevicesserie_serie_section_episodios_grid1();
         objworkwithdevicesserie_serie_section_episodios_grid1.A1SerieId = aP0_SerieId;
         objworkwithdevicesserie_serie_section_episodios_grid1.AV10start = aP1_start;
         objworkwithdevicesserie_serie_section_episodios_grid1.AV11count = aP2_count;
         objworkwithdevicesserie_serie_section_episodios_grid1.AV9gxid = aP3_gxid;
         objworkwithdevicesserie_serie_section_episodios_grid1.AV12GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item>( context, "Item", "") ;
         objworkwithdevicesserie_serie_section_episodios_grid1.context.SetSubmitInitialConfig(context);
         objworkwithdevicesserie_serie_section_episodios_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesserie_serie_section_episodios_grid1);
         aP4_GXM2RootCol=this.AV12GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesserie_serie_section_episodios_grid1)stateInfo).executePrivate();
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
         GXPagingFrom2 = (int)(AV10start);
         GXPagingTo2 = (int)(AV11count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {A1SerieId, AV6Temporada, GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A42EpisodioTemporada = P00002_A42EpisodioTemporada[0];
            A51EpisodioInativo = P00002_A51EpisodioInativo[0];
            A7EpisodioId = P00002_A7EpisodioId[0];
            A58EpisodioNumero = P00002_A58EpisodioNumero[0];
            A8EpisodioNome = P00002_A8EpisodioNome[0];
            AV13GXM1WorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt = new SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item(context);
            AV12GXM2RootCol.Add(AV13GXM1WorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt, 0);
            AV13GXM1WorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt.gxTpr_Episodioid = A7EpisodioId;
            AV13GXM1WorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt.gxTpr_Episodionumero = A58EpisodioNumero;
            AV13GXM1WorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt.gxTpr_Episodionome = A8EpisodioNome;
            pr_default.readNext(0);
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
         P00002_A1SerieId = new long[1] ;
         P00002_A42EpisodioTemporada = new short[1] ;
         P00002_A51EpisodioInativo = new bool[] {false} ;
         P00002_A7EpisodioId = new long[1] ;
         P00002_A58EpisodioNumero = new short[1] ;
         P00002_A8EpisodioNome = new String[] {""} ;
         A8EpisodioNome = "";
         AV13GXM1WorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt = new SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesserie_serie_section_episodios_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A1SerieId, P00002_A42EpisodioTemporada, P00002_A51EpisodioInativo, P00002_A7EpisodioId, P00002_A58EpisodioNumero, P00002_A8EpisodioNome
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV6Temporada ;
      private short A42EpisodioTemporada ;
      private short A58EpisodioNumero ;
      private int AV9gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long A1SerieId ;
      private long AV10start ;
      private long AV11count ;
      private long A7EpisodioId ;
      private String scmdbuf ;
      private bool A51EpisodioInativo ;
      private String A8EpisodioNome ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A1SerieId ;
      private short[] P00002_A42EpisodioTemporada ;
      private bool[] P00002_A51EpisodioInativo ;
      private long[] P00002_A7EpisodioId ;
      private short[] P00002_A58EpisodioNumero ;
      private String[] P00002_A8EpisodioNome ;
      private GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item> aP4_GXM2RootCol ;
      private GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item> AV12GXM2RootCol ;
      private SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item AV13GXM1WorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt ;
   }

   public class workwithdevicesserie_serie_section_episodios_grid1__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@SerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV6Temporada",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [SerieId], [EpisodioTemporada], [EpisodioInativo], [EpisodioId], [EpisodioNumero], [EpisodioNome] FROM [Episodio] WITH (NOLOCK) WHERE ([SerieId] = @SerieId) AND (Not [EpisodioInativo] = 1) AND ([EpisodioTemporada] = @AV6Temporada) ORDER BY [SerieId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,false,false )
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
                ((bool[]) buf[2])[0] = rslt.getBool(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesserie_serie_section_episodios_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesserie_serie_section_episodios_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?SerieId={SerieId}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item_RESTInterface> execute( String SerieId ,
                                                                                                                     String start ,
                                                                                                                     String count ,
                                                                                                                     String gxid )
    {
       GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesserie_serie_section_episodios_grid1") )
          {
             return null ;
          }
          workwithdevicesserie_serie_section_episodios_grid1 worker = new workwithdevicesserie_serie_section_episodios_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrSerieId ;
          gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item>() ;
          worker.execute(gxrSerieId,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
          return GXM2RootCol ;
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
