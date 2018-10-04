/*
               File: SDRanking_Level_Detail_Grid1
        Description: SDRanking_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:25.14
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
   public class sdranking_level_detail_grid1 : GXProcedure
   {
      public sdranking_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdranking_level_detail_grid1( IGxContext context )
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
                           out GXBaseCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item> aP3_GXM2RootCol )
      {
         this.AV11start = aP0_start;
         this.AV12count = aP1_count;
         this.AV10gxid = aP2_gxid;
         this.AV13GXM2RootCol = new GXBaseCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP3_GXM2RootCol=this.AV13GXM2RootCol;
      }

      public GXBaseCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item> executeUdp( long aP0_start ,
                                                                                   long aP1_count ,
                                                                                   int aP2_gxid )
      {
         this.AV11start = aP0_start;
         this.AV12count = aP1_count;
         this.AV10gxid = aP2_gxid;
         this.AV13GXM2RootCol = new GXBaseCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP3_GXM2RootCol=this.AV13GXM2RootCol;
         return AV13GXM2RootCol ;
      }

      public void executeSubmit( long aP0_start ,
                                 long aP1_count ,
                                 int aP2_gxid ,
                                 out GXBaseCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item> aP3_GXM2RootCol )
      {
         sdranking_level_detail_grid1 objsdranking_level_detail_grid1;
         objsdranking_level_detail_grid1 = new sdranking_level_detail_grid1();
         objsdranking_level_detail_grid1.AV11start = aP0_start;
         objsdranking_level_detail_grid1.AV12count = aP1_count;
         objsdranking_level_detail_grid1.AV10gxid = aP2_gxid;
         objsdranking_level_detail_grid1.AV13GXM2RootCol = new GXBaseCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objsdranking_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objsdranking_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdranking_level_detail_grid1);
         aP3_GXM2RootCol=this.AV13GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdranking_level_detail_grid1)stateInfo).executePrivate();
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
         GXPagingFrom2 = (int)(AV11start);
         GXPagingTo2 = (int)(AV12count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A12UsuarioNome = P00002_A12UsuarioNome[0];
            A11UsuarioId = P00002_A11UsuarioId[0];
            GXt_int1 = A59UsuarioQuantidadePontos;
            new obtertotalpontosconquista(context ).execute(  A11UsuarioId, out  GXt_int1) ;
            A59UsuarioQuantidadePontos = GXt_int1;
            AV14GXM1SDRanking_Level_Detail_Grid1Sdt = new SdtSDRanking_Level_Detail_Grid1Sdt_Item(context);
            AV13GXM2RootCol.Add(AV14GXM1SDRanking_Level_Detail_Grid1Sdt, 0);
            AV14GXM1SDRanking_Level_Detail_Grid1Sdt.gxTpr_Usuarioid = A11UsuarioId;
            AV14GXM1SDRanking_Level_Detail_Grid1Sdt.gxTpr_Usuarionome = A12UsuarioNome;
            AV14GXM1SDRanking_Level_Detail_Grid1Sdt.gxTpr_Usuarioquantidadepontos = A59UsuarioQuantidadePontos;
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
         P00002_A12UsuarioNome = new String[] {""} ;
         P00002_A11UsuarioId = new long[1] ;
         A12UsuarioNome = "";
         AV14GXM1SDRanking_Level_Detail_Grid1Sdt = new SdtSDRanking_Level_Detail_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdranking_level_detail_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A12UsuarioNome, P00002_A11UsuarioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV10gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV11start ;
      private long AV12count ;
      private long A11UsuarioId ;
      private long A59UsuarioQuantidadePontos ;
      private long GXt_int1 ;
      private String scmdbuf ;
      private String A12UsuarioNome ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00002_A12UsuarioNome ;
      private long[] P00002_A11UsuarioId ;
      private GXBaseCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item> aP3_GXM2RootCol ;
      private GXBaseCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item> AV13GXM2RootCol ;
      private SdtSDRanking_Level_Detail_Grid1Sdt_Item AV14GXM1SDRanking_Level_Detail_Grid1Sdt ;
   }

   public class sdranking_level_detail_grid1__default : DataStoreHelperBase, IDataStoreHelper
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
              new CursorDef("P00002", "SELECT [UsuarioNome], [UsuarioId] FROM [Usuario] WITH (NOLOCK) ORDER BY [UsuarioId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,true,false )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.sdranking_level_detail_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdranking_level_detail_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( String start ,
                                                                                               String count ,
                                                                                               String gxid )
    {
       GxGenericCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("sdranking_level_detail_grid1") )
          {
             return null ;
          }
          sdranking_level_detail_grid1 worker = new sdranking_level_detail_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item>() ;
          worker.execute(gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtSDRanking_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
