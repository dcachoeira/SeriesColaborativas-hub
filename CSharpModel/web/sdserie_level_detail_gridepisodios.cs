/*
               File: SDSerie_Level_Detail_GridEpisodios
        Description: SDSerie_Level_Detail_GridEpisodios
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/30/2018 20:47:40.13
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
   public class sdserie_level_detail_gridepisodios : GXProcedure
   {
      public sdserie_level_detail_gridepisodios( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdserie_level_detail_gridepisodios( IGxContext context )
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
                           out GXBaseCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item> aP4_GXM3RootCol )
      {
         this.AV5SerieId = aP0_SerieId;
         this.AV16start = aP1_start;
         this.AV17count = aP2_count;
         this.AV15gxid = aP3_gxid;
         this.AV20GXM3RootCol = new GXBaseCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM3RootCol=this.AV20GXM3RootCol;
      }

      public GXBaseCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item> executeUdp( long aP0_SerieId ,
                                                                                         long aP1_start ,
                                                                                         long aP2_count ,
                                                                                         int aP3_gxid )
      {
         this.AV5SerieId = aP0_SerieId;
         this.AV16start = aP1_start;
         this.AV17count = aP2_count;
         this.AV15gxid = aP3_gxid;
         this.AV20GXM3RootCol = new GXBaseCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM3RootCol=this.AV20GXM3RootCol;
         return AV20GXM3RootCol ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 long aP1_start ,
                                 long aP2_count ,
                                 int aP3_gxid ,
                                 out GXBaseCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item> aP4_GXM3RootCol )
      {
         sdserie_level_detail_gridepisodios objsdserie_level_detail_gridepisodios;
         objsdserie_level_detail_gridepisodios = new sdserie_level_detail_gridepisodios();
         objsdserie_level_detail_gridepisodios.AV5SerieId = aP0_SerieId;
         objsdserie_level_detail_gridepisodios.AV16start = aP1_start;
         objsdserie_level_detail_gridepisodios.AV17count = aP2_count;
         objsdserie_level_detail_gridepisodios.AV15gxid = aP3_gxid;
         objsdserie_level_detail_gridepisodios.AV20GXM3RootCol = new GXBaseCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item>( context, "Item", "") ;
         objsdserie_level_detail_gridepisodios.context.SetSubmitInitialConfig(context);
         objsdserie_level_detail_gridepisodios.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdserie_level_detail_gridepisodios);
         aP4_GXM3RootCol=this.AV20GXM3RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdserie_level_detail_gridepisodios)stateInfo).executePrivate();
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
         GXPagingFrom2 = (int)(AV16start);
         GXPagingTo2 = (int)(AV17count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A8EpisodioNome = P00002_A8EpisodioNome[0];
            A9EpisodioDuracao = P00002_A9EpisodioDuracao[0];
            A7EpisodioId = P00002_A7EpisodioId[0];
            AV21GXM2SDSerie_Level_Detail_GridEpisodiosSdt = new SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item(context);
            AV20GXM3RootCol.Add(AV21GXM2SDSerie_Level_Detail_GridEpisodiosSdt, 0);
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Txbepisodionome\",\"Caption\",\"" + StringUtil.JSONEncode( A8EpisodioNome) + "\"]";
            Gxdynprop1 = StringUtil.Str( (decimal)(A9EpisodioDuracao), 3, 0) + "min";
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Txbepisodioduracao\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
            new log(context ).execute(  "Episodio: "+StringUtil.Str( (decimal)(A7EpisodioId), 18, 0)) ;
            AV21GXM2SDSerie_Level_Detail_GridEpisodiosSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
            Gxdynprop = "";
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
         P00002_A8EpisodioNome = new String[] {""} ;
         P00002_A9EpisodioDuracao = new short[1] ;
         P00002_A7EpisodioId = new long[1] ;
         A8EpisodioNome = "";
         AV21GXM2SDSerie_Level_Detail_GridEpisodiosSdt = new SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item(context);
         Gxdynprop = "";
         Gxdynprop1 = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdserie_level_detail_gridepisodios__default(),
            new Object[][] {
                new Object[] {
               P00002_A8EpisodioNome, P00002_A9EpisodioDuracao, P00002_A7EpisodioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A9EpisodioDuracao ;
      private int AV15gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV5SerieId ;
      private long AV16start ;
      private long AV17count ;
      private long A7EpisodioId ;
      private String scmdbuf ;
      private String Gxdynprop1 ;
      private String A8EpisodioNome ;
      private String Gxdynprop ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00002_A8EpisodioNome ;
      private short[] P00002_A9EpisodioDuracao ;
      private long[] P00002_A7EpisodioId ;
      private GXBaseCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item> aP4_GXM3RootCol ;
      private GXBaseCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item> AV20GXM3RootCol ;
      private SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item AV21GXM2SDSerie_Level_Detail_GridEpisodiosSdt ;
   }

   public class sdserie_level_detail_gridepisodios__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [EpisodioNome], [EpisodioDuracao], [EpisodioId] FROM [Episodio] WITH (NOLOCK) ORDER BY [EpisodioId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.sdserie_level_detail_gridepisodios_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdserie_level_detail_gridepisodios_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?SerieId={SerieId}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_RESTInterface> execute( String SerieId ,
                                                                                                     String start ,
                                                                                                     String count ,
                                                                                                     String gxid )
    {
       GxGenericCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_RESTInterface> GXM3RootCol = new GxGenericCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("sdserie_level_detail_gridepisodios") )
          {
             return null ;
          }
          sdserie_level_detail_gridepisodios worker = new sdserie_level_detail_gridepisodios(context) ;
          worker.IsMain = RunAsMain ;
          long gxrSerieId ;
          gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item> gxrGXM3RootCol = new GXBaseCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item>() ;
          worker.execute(gxrSerieId,gxrstart,gxrcount,gxrgxid,out gxrGXM3RootCol );
          worker.cleanup( );
          GXM3RootCol = new GxGenericCollection<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_RESTInterface>(gxrGXM3RootCol) ;
          return GXM3RootCol ;
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
