/*
               File: WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1
        Description: WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:27.76
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
   public class workwithdevicesusuarioconquista_usuarioconquista_list_grid1 : GXProcedure
   {
      public workwithdevicesusuarioconquista_usuarioconquista_list_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesusuarioconquista_usuarioconquista_list_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_UsuarioId ,
                           long aP1_start ,
                           long aP2_count ,
                           int aP3_gxid ,
                           out GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item> aP4_GXM2RootCol )
      {
         this.AV5UsuarioId = aP0_UsuarioId;
         this.AV9start = aP1_start;
         this.AV10count = aP2_count;
         this.AV8gxid = aP3_gxid;
         this.AV11GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM2RootCol=this.AV11GXM2RootCol;
      }

      public GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item> executeUdp( long aP0_UsuarioId ,
                                                                                                                  long aP1_start ,
                                                                                                                  long aP2_count ,
                                                                                                                  int aP3_gxid )
      {
         this.AV5UsuarioId = aP0_UsuarioId;
         this.AV9start = aP1_start;
         this.AV10count = aP2_count;
         this.AV8gxid = aP3_gxid;
         this.AV11GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM2RootCol=this.AV11GXM2RootCol;
         return AV11GXM2RootCol ;
      }

      public void executeSubmit( long aP0_UsuarioId ,
                                 long aP1_start ,
                                 long aP2_count ,
                                 int aP3_gxid ,
                                 out GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item> aP4_GXM2RootCol )
      {
         workwithdevicesusuarioconquista_usuarioconquista_list_grid1 objworkwithdevicesusuarioconquista_usuarioconquista_list_grid1;
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid1 = new workwithdevicesusuarioconquista_usuarioconquista_list_grid1();
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid1.AV5UsuarioId = aP0_UsuarioId;
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid1.AV9start = aP1_start;
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid1.AV10count = aP2_count;
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid1.AV8gxid = aP3_gxid;
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid1.AV11GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item>( context, "Item", "") ;
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid1.context.SetSubmitInitialConfig(context);
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesusuarioconquista_usuarioconquista_list_grid1);
         aP4_GXM2RootCol=this.AV11GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesusuarioconquista_usuarioconquista_list_grid1)stateInfo).executePrivate();
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
         GXPagingFrom2 = (int)(AV9start);
         GXPagingTo2 = (int)(AV10count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {AV5UsuarioId, GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11UsuarioId = P00002_A11UsuarioId[0];
            A31UsuarioConquistaDataHora = P00002_A31UsuarioConquistaDataHora[0];
            A27ConquistaId = P00002_A27ConquistaId[0];
            A29ConquistaNome = P00002_A29ConquistaNome[0];
            A30UsuarioConquistaId = P00002_A30UsuarioConquistaId[0];
            A29ConquistaNome = P00002_A29ConquistaNome[0];
            AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item(context);
            AV11GXM2RootCol.Add(AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt, 0);
            AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt.gxTpr_Conquistaid = A27ConquistaId;
            AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt.gxTpr_Conquistanome = A29ConquistaNome;
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
         P00002_A11UsuarioId = new long[1] ;
         P00002_A31UsuarioConquistaDataHora = new DateTime[] {DateTime.MinValue} ;
         P00002_A27ConquistaId = new long[1] ;
         P00002_A29ConquistaNome = new String[] {""} ;
         P00002_A30UsuarioConquistaId = new long[1] ;
         A31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
         A29ConquistaNome = "";
         AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesusuarioconquista_usuarioconquista_list_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A11UsuarioId, P00002_A31UsuarioConquistaDataHora, P00002_A27ConquistaId, P00002_A29ConquistaNome, P00002_A30UsuarioConquistaId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV8gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV5UsuarioId ;
      private long AV9start ;
      private long AV10count ;
      private long A11UsuarioId ;
      private long A27ConquistaId ;
      private long A30UsuarioConquistaId ;
      private String scmdbuf ;
      private DateTime A31UsuarioConquistaDataHora ;
      private String A29ConquistaNome ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A11UsuarioId ;
      private DateTime[] P00002_A31UsuarioConquistaDataHora ;
      private long[] P00002_A27ConquistaId ;
      private String[] P00002_A29ConquistaNome ;
      private long[] P00002_A30UsuarioConquistaId ;
      private GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item> aP4_GXM2RootCol ;
      private GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item> AV11GXM2RootCol ;
      private SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item AV12GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt ;
   }

   public class workwithdevicesusuarioconquista_usuarioconquista_list_grid1__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@AV5UsuarioId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT T1.[UsuarioId], T1.[UsuarioConquistaDataHora], T1.[ConquistaId], T2.[ConquistaNome], T1.[UsuarioConquistaId] FROM ([UsuarioConquista] T1 WITH (NOLOCK) INNER JOIN [Conquista] T2 WITH (NOLOCK) ON T2.[ConquistaId] = T1.[ConquistaId]) WHERE (Not (T1.[UsuarioConquistaDataHora] = convert( DATETIME, '17530101', 112 ))) AND (T1.[UsuarioId] = @AV5UsuarioId) ORDER BY T1.[UsuarioConquistaDataHora] DESC  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,false,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesusuarioconquista_usuarioconquista_list_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesusuarioconquista_usuarioconquista_list_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?UsuarioId={UsuarioId}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item_RESTInterface> execute( String UsuarioId ,
                                                                                                                              String start ,
                                                                                                                              String count ,
                                                                                                                              String gxid )
    {
       GxGenericCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesusuarioconquista_usuarioconquista_list_grid1") )
          {
             return null ;
          }
          workwithdevicesusuarioconquista_usuarioconquista_list_grid1 worker = new workwithdevicesusuarioconquista_usuarioconquista_list_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrUsuarioId ;
          gxrUsuarioId = (long)(NumberUtil.Val( (String)(UsuarioId), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item>() ;
          worker.execute(gxrUsuarioId,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
