/*
               File: WorkWithDevicesEpisodio_Episodio_List_Grid1
        Description: WorkWithDevicesEpisodio_Episodio_List_Grid1
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 19:40:18.66
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
   public class workwithdevicesepisodio_episodio_list_grid1 : GXProcedure
   {
      public workwithdevicesepisodio_episodio_list_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesepisodio_episodio_list_grid1( IGxContext context )
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
                           short aP1_EpisodioTemporada ,
                           long aP2_start ,
                           long aP3_count ,
                           int aP4_gxid ,
                           out GXBaseCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item> aP5_GXM2RootCol )
      {
         this.A1SerieId = aP0_SerieId;
         this.A42EpisodioTemporada = aP1_EpisodioTemporada;
         this.AV13start = aP2_start;
         this.AV14count = aP3_count;
         this.AV10gxid = aP4_gxid;
         this.AV15GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP5_GXM2RootCol=this.AV15GXM2RootCol;
      }

      public GXBaseCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item> executeUdp( long aP0_SerieId ,
                                                                                                  short aP1_EpisodioTemporada ,
                                                                                                  long aP2_start ,
                                                                                                  long aP3_count ,
                                                                                                  int aP4_gxid )
      {
         this.A1SerieId = aP0_SerieId;
         this.A42EpisodioTemporada = aP1_EpisodioTemporada;
         this.AV13start = aP2_start;
         this.AV14count = aP3_count;
         this.AV10gxid = aP4_gxid;
         this.AV15GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP5_GXM2RootCol=this.AV15GXM2RootCol;
         return AV15GXM2RootCol ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 short aP1_EpisodioTemporada ,
                                 long aP2_start ,
                                 long aP3_count ,
                                 int aP4_gxid ,
                                 out GXBaseCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item> aP5_GXM2RootCol )
      {
         workwithdevicesepisodio_episodio_list_grid1 objworkwithdevicesepisodio_episodio_list_grid1;
         objworkwithdevicesepisodio_episodio_list_grid1 = new workwithdevicesepisodio_episodio_list_grid1();
         objworkwithdevicesepisodio_episodio_list_grid1.A1SerieId = aP0_SerieId;
         objworkwithdevicesepisodio_episodio_list_grid1.A42EpisodioTemporada = aP1_EpisodioTemporada;
         objworkwithdevicesepisodio_episodio_list_grid1.AV13start = aP2_start;
         objworkwithdevicesepisodio_episodio_list_grid1.AV14count = aP3_count;
         objworkwithdevicesepisodio_episodio_list_grid1.AV10gxid = aP4_gxid;
         objworkwithdevicesepisodio_episodio_list_grid1.AV15GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item>( context, "Item", "") ;
         objworkwithdevicesepisodio_episodio_list_grid1.context.SetSubmitInitialConfig(context);
         objworkwithdevicesepisodio_episodio_list_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesepisodio_episodio_list_grid1);
         aP5_GXM2RootCol=this.AV15GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesepisodio_episodio_list_grid1)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV10gxid), 8, 0);
         AV19Favorito_GXI = Gxwebsession.Get(Gxids+"gxvar_Favorito");
         AV5favorito = "";
         AV20Assistido_GXI = Gxwebsession.Get(Gxids+"gxvar_Assistido");
         AV6assistido = "";
         GXPagingFrom2 = (int)(AV13start);
         GXPagingTo2 = (int)(AV14count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {A1SerieId, A42EpisodioTemporada, GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A7EpisodioId = P00002_A7EpisodioId[0];
            A8EpisodioNome = P00002_A8EpisodioNome[0];
            A58EpisodioNumero = P00002_A58EpisodioNumero[0];
            AV16GXM1WorkWithDevicesEpisodio_Episodio_List_Grid1Sdt = new SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item(context);
            AV15GXM2RootCol.Add(AV16GXM1WorkWithDevicesEpisodio_Episodio_List_Grid1Sdt, 0);
            new verificarepisodiousuario(context ).execute(  2,  A7EpisodioId, out  AV8Assistida, out  AV9Favorita) ;
            if ( AV8Assistida )
            {
               AV6assistido = context.GetImagePath( "451cf230-8c7c-4f17-8440-ff7c487b2ad9", "", context.GetTheme( ));
               AV20Assistido_GXI = GXDbFile.PathToUrl( context.GetImagePath( "451cf230-8c7c-4f17-8440-ff7c487b2ad9", "", context.GetTheme( )));
            }
            else
            {
               AV6assistido = context.GetImagePath( "df8aee37-3ddd-479f-a9aa-1c4957c02e0a", "", context.GetTheme( ));
               AV20Assistido_GXI = GXDbFile.PathToUrl( context.GetImagePath( "df8aee37-3ddd-479f-a9aa-1c4957c02e0a", "", context.GetTheme( )));
            }
            if ( AV9Favorita )
            {
               AV5favorito = context.GetImagePath( "36fbff47-1ab6-4c69-a869-d775c2c91b99", "", context.GetTheme( ));
               AV19Favorito_GXI = GXDbFile.PathToUrl( context.GetImagePath( "36fbff47-1ab6-4c69-a869-d775c2c91b99", "", context.GetTheme( )));
            }
            else
            {
               AV5favorito = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
               AV19Favorito_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            }
            AV16GXM1WorkWithDevicesEpisodio_Episodio_List_Grid1Sdt.gxTpr_Episodioid = A7EpisodioId;
            AV16GXM1WorkWithDevicesEpisodio_Episodio_List_Grid1Sdt.gxTpr_Episodionome = A8EpisodioNome;
            AV16GXM1WorkWithDevicesEpisodio_Episodio_List_Grid1Sdt.gxTpr_Favorito = AV5favorito;
            AV16GXM1WorkWithDevicesEpisodio_Episodio_List_Grid1Sdt.gxTpr_Favorito_gxi = AV19Favorito_GXI;
            AV16GXM1WorkWithDevicesEpisodio_Episodio_List_Grid1Sdt.gxTpr_Assistido = AV6assistido;
            AV16GXM1WorkWithDevicesEpisodio_Episodio_List_Grid1Sdt.gxTpr_Assistido_gxi = AV20Assistido_GXI;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         Gxwebsession.Set(Gxids+"gxvar_Favorito", AV19Favorito_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Assistido", AV20Assistido_GXI);
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
         AV19Favorito_GXI = "";
         Gxwebsession = context.GetSession();
         AV5favorito = "";
         AV20Assistido_GXI = "";
         AV6assistido = "";
         scmdbuf = "";
         P00002_A1SerieId = new long[1] ;
         P00002_A42EpisodioTemporada = new short[1] ;
         P00002_A7EpisodioId = new long[1] ;
         P00002_A8EpisodioNome = new String[] {""} ;
         P00002_A58EpisodioNumero = new short[1] ;
         A8EpisodioNome = "";
         AV16GXM1WorkWithDevicesEpisodio_Episodio_List_Grid1Sdt = new SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesepisodio_episodio_list_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A1SerieId, P00002_A42EpisodioTemporada, P00002_A7EpisodioId, P00002_A8EpisodioNome, P00002_A58EpisodioNumero
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A42EpisodioTemporada ;
      private short A58EpisodioNumero ;
      private int AV10gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long A1SerieId ;
      private long AV13start ;
      private long AV14count ;
      private long A7EpisodioId ;
      private String Gxids ;
      private String scmdbuf ;
      private bool AV8Assistida ;
      private bool AV9Favorita ;
      private String AV19Favorito_GXI ;
      private String AV20Assistido_GXI ;
      private String A8EpisodioNome ;
      private String AV5favorito ;
      private String AV6assistido ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A1SerieId ;
      private short[] P00002_A42EpisodioTemporada ;
      private long[] P00002_A7EpisodioId ;
      private String[] P00002_A8EpisodioNome ;
      private short[] P00002_A58EpisodioNumero ;
      private GXBaseCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item> aP5_GXM2RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item> AV15GXM2RootCol ;
      private SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item AV16GXM1WorkWithDevicesEpisodio_Episodio_List_Grid1Sdt ;
   }

   public class workwithdevicesepisodio_episodio_list_grid1__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@EpisodioTemporada",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [SerieId], [EpisodioTemporada], [EpisodioId], [EpisodioNome], [EpisodioNumero] FROM [Episodio] WITH (NOLOCK) WHERE ([SerieId] = @SerieId) AND ([EpisodioTemporada] = @EpisodioTemporada) ORDER BY [EpisodioNumero]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,true,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesepisodio_episodio_list_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesepisodio_episodio_list_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?SerieId={SerieId}&EpisodioTemporada={EpisodioTemporada}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_RESTInterface> execute( String SerieId ,
                                                                                                              short EpisodioTemporada ,
                                                                                                              String start ,
                                                                                                              String count ,
                                                                                                              String gxid )
    {
       GxGenericCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesepisodio_episodio_list_grid1") )
          {
             return null ;
          }
          workwithdevicesepisodio_episodio_list_grid1 worker = new workwithdevicesepisodio_episodio_list_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrSerieId ;
          gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item>() ;
          worker.execute(gxrSerieId,EpisodioTemporada,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
