/*
               File: SDSeries_Level_Detail_GridSeries
        Description: SDSeries_Level_Detail_GridSeries
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/30/2018 21:29:26.71
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
   public class sdseries_level_detail_gridseries : GXProcedure
   {
      public sdseries_level_detail_gridseries( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdseries_level_detail_gridseries( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_start ,
                           long aP1_count ,
                           int aP2_gxid ,
                           out GXBaseCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item> aP3_GXM2RootCol )
      {
         this.AV11start = aP0_start;
         this.AV12count = aP1_count;
         this.AV8gxid = aP2_gxid;
         this.AV14GXM2RootCol = new GXBaseCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP3_GXM2RootCol=this.AV14GXM2RootCol;
      }

      public GXBaseCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item> executeUdp( long aP0_start ,
                                                                                       long aP1_count ,
                                                                                       int aP2_gxid )
      {
         this.AV11start = aP0_start;
         this.AV12count = aP1_count;
         this.AV8gxid = aP2_gxid;
         this.AV14GXM2RootCol = new GXBaseCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP3_GXM2RootCol=this.AV14GXM2RootCol;
         return AV14GXM2RootCol ;
      }

      public void executeSubmit( long aP0_start ,
                                 long aP1_count ,
                                 int aP2_gxid ,
                                 out GXBaseCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item> aP3_GXM2RootCol )
      {
         sdseries_level_detail_gridseries objsdseries_level_detail_gridseries;
         objsdseries_level_detail_gridseries = new sdseries_level_detail_gridseries();
         objsdseries_level_detail_gridseries.AV11start = aP0_start;
         objsdseries_level_detail_gridseries.AV12count = aP1_count;
         objsdseries_level_detail_gridseries.AV8gxid = aP2_gxid;
         objsdseries_level_detail_gridseries.AV14GXM2RootCol = new GXBaseCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item>( context, "Item", "") ;
         objsdseries_level_detail_gridseries.context.SetSubmitInitialConfig(context);
         objsdseries_level_detail_gridseries.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdseries_level_detail_gridseries);
         aP3_GXM2RootCol=this.AV14GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdseries_level_detail_gridseries)stateInfo).executePrivate();
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
         AV7SerieId = (long)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Serieid"), "."));
         AV18Serieimagem_GXI = Gxwebsession.Get(Gxids+"gxvar_Serieimagem");
         AV5SerieImagem = "";
         GXPagingFrom2 = (int)(AV11start);
         GXPagingTo2 = (int)(AV12count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A47SerieInativo = P00002_A47SerieInativo[0];
            A40000SerieImagem_GXI = P00002_A40000SerieImagem_GXI[0];
            A1SerieId = P00002_A1SerieId[0];
            A2SerieNome = P00002_A2SerieNome[0];
            A43SerieImagem = P00002_A43SerieImagem[0];
            AV15GXM1SDSeries_Level_Detail_GridSeriesSdt = new SdtSDSeries_Level_Detail_GridSeriesSdt_Item(context);
            AV14GXM2RootCol.Add(AV15GXM1SDSeries_Level_Detail_GridSeriesSdt, 0);
            AV5SerieImagem = A43SerieImagem;
            AV18Serieimagem_GXI = A40000SerieImagem_GXI;
            AV7SerieId = A1SerieId;
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Txbserienome\",\"Caption\",\"" + StringUtil.JSONEncode( A2SerieNome) + "\"]";
            new log(context ).execute(  A2SerieNome) ;
            AV15GXM1SDSeries_Level_Detail_GridSeriesSdt.gxTpr_Serieid = AV7SerieId;
            AV15GXM1SDSeries_Level_Detail_GridSeriesSdt.gxTpr_Serieimagem = AV5SerieImagem;
            AV15GXM1SDSeries_Level_Detail_GridSeriesSdt.gxTpr_Serieimagem_gxi = AV18Serieimagem_GXI;
            AV15GXM1SDSeries_Level_Detail_GridSeriesSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
            Gxdynprop = "";
            pr_default.readNext(0);
         }
         pr_default.close(0);
         Gxwebsession.Set(Gxids+"gxvar_Serieid", StringUtil.Str( (decimal)(AV7SerieId), 18, 0));
         Gxwebsession.Set(Gxids+"gxvar_Serieimagem", AV18Serieimagem_GXI);
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
         AV18Serieimagem_GXI = "";
         AV5SerieImagem = "";
         scmdbuf = "";
         P00002_A47SerieInativo = new bool[] {false} ;
         P00002_A40000SerieImagem_GXI = new String[] {""} ;
         P00002_A1SerieId = new long[1] ;
         P00002_A2SerieNome = new String[] {""} ;
         P00002_A43SerieImagem = new String[] {""} ;
         A40000SerieImagem_GXI = "";
         A2SerieNome = "";
         A43SerieImagem = "";
         AV15GXM1SDSeries_Level_Detail_GridSeriesSdt = new SdtSDSeries_Level_Detail_GridSeriesSdt_Item(context);
         Gxdynprop = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdseries_level_detail_gridseries__default(),
            new Object[][] {
                new Object[] {
               P00002_A47SerieInativo, P00002_A40000SerieImagem_GXI, P00002_A1SerieId, P00002_A2SerieNome, P00002_A43SerieImagem
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV8gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV11start ;
      private long AV12count ;
      private long AV7SerieId ;
      private long A1SerieId ;
      private String Gxids ;
      private String scmdbuf ;
      private bool A47SerieInativo ;
      private String AV18Serieimagem_GXI ;
      private String A40000SerieImagem_GXI ;
      private String A2SerieNome ;
      private String Gxdynprop ;
      private String AV5SerieImagem ;
      private String A43SerieImagem ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private bool[] P00002_A47SerieInativo ;
      private String[] P00002_A40000SerieImagem_GXI ;
      private long[] P00002_A1SerieId ;
      private String[] P00002_A2SerieNome ;
      private String[] P00002_A43SerieImagem ;
      private GXBaseCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item> aP3_GXM2RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item> AV14GXM2RootCol ;
      private SdtSDSeries_Level_Detail_GridSeriesSdt_Item AV15GXM1SDSeries_Level_Detail_GridSeriesSdt ;
   }

   public class sdseries_level_detail_gridseries__default : DataStoreHelperBase, IDataStoreHelper
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
              new CursorDef("P00002", "SELECT [SerieInativo], [SerieImagem_GXI], [SerieId], [SerieNome], [SerieImagem] FROM [Serie] WITH (NOLOCK) WHERE Not [SerieInativo] = 1 ORDER BY [SerieId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,true,false )
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
                ((bool[]) buf[0])[0] = rslt.getBool(1) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getMultimediaFile(5, rslt.getVarchar(2)) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.sdseries_level_detail_gridseries_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdseries_level_detail_gridseries_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item_RESTInterface> execute( String start ,
                                                                                                   String count ,
                                                                                                   String gxid )
    {
       GxGenericCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("sdseries_level_detail_gridseries") )
          {
             return null ;
          }
          sdseries_level_detail_gridseries worker = new sdseries_level_detail_gridseries(context) ;
          worker.IsMain = RunAsMain ;
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item>() ;
          worker.execute(gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtSDSeries_Level_Detail_GridSeriesSdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
