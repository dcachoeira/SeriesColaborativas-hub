/*
               File: WorkWithDevicesNotificacao_Notificacao_List_Grid1
        Description: WorkWithDevicesNotificacao_Notificacao_List_Grid1
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:45:59.43
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
   public class workwithdevicesnotificacao_notificacao_list_grid1 : GXProcedure
   {
      public workwithdevicesnotificacao_notificacao_list_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesnotificacao_notificacao_list_grid1( IGxContext context )
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
                           out GXBaseCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item> aP3_GXM2RootCol )
      {
         this.AV6start = aP0_start;
         this.AV7count = aP1_count;
         this.AV5gxid = aP2_gxid;
         this.AV8GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP3_GXM2RootCol=this.AV8GXM2RootCol;
      }

      public GXBaseCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item> executeUdp( long aP0_start ,
                                                                                                        long aP1_count ,
                                                                                                        int aP2_gxid )
      {
         this.AV6start = aP0_start;
         this.AV7count = aP1_count;
         this.AV5gxid = aP2_gxid;
         this.AV8GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP3_GXM2RootCol=this.AV8GXM2RootCol;
         return AV8GXM2RootCol ;
      }

      public void executeSubmit( long aP0_start ,
                                 long aP1_count ,
                                 int aP2_gxid ,
                                 out GXBaseCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item> aP3_GXM2RootCol )
      {
         workwithdevicesnotificacao_notificacao_list_grid1 objworkwithdevicesnotificacao_notificacao_list_grid1;
         objworkwithdevicesnotificacao_notificacao_list_grid1 = new workwithdevicesnotificacao_notificacao_list_grid1();
         objworkwithdevicesnotificacao_notificacao_list_grid1.AV6start = aP0_start;
         objworkwithdevicesnotificacao_notificacao_list_grid1.AV7count = aP1_count;
         objworkwithdevicesnotificacao_notificacao_list_grid1.AV5gxid = aP2_gxid;
         objworkwithdevicesnotificacao_notificacao_list_grid1.AV8GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item>( context, "Item", "") ;
         objworkwithdevicesnotificacao_notificacao_list_grid1.context.SetSubmitInitialConfig(context);
         objworkwithdevicesnotificacao_notificacao_list_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesnotificacao_notificacao_list_grid1);
         aP3_GXM2RootCol=this.AV8GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesnotificacao_notificacao_list_grid1)stateInfo).executePrivate();
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
         GXPagingFrom2 = (int)(AV6start);
         GXPagingTo2 = (int)(AV7count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A23NotificacaoId = P00002_A23NotificacaoId[0];
            A25NotificacaoTexto = P00002_A25NotificacaoTexto[0];
            A24NotificacaoTipo = P00002_A24NotificacaoTipo[0];
            A61NotificacaoLigacaoId = P00002_A61NotificacaoLigacaoId[0];
            n61NotificacaoLigacaoId = P00002_n61NotificacaoLigacaoId[0];
            AV9GXM1WorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt = new SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item(context);
            AV8GXM2RootCol.Add(AV9GXM1WorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt, 0);
            AV9GXM1WorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt.gxTpr_Notificacaoid = A23NotificacaoId;
            AV9GXM1WorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt.gxTpr_Notificacaotexto = A25NotificacaoTexto;
            AV9GXM1WorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt.gxTpr_Notificacaotipo = A24NotificacaoTipo;
            AV9GXM1WorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt.gxTpr_Notificacaoligacaoid = A61NotificacaoLigacaoId;
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
         P00002_A23NotificacaoId = new long[1] ;
         P00002_A25NotificacaoTexto = new String[] {""} ;
         P00002_A24NotificacaoTipo = new short[1] ;
         P00002_A61NotificacaoLigacaoId = new long[1] ;
         P00002_n61NotificacaoLigacaoId = new bool[] {false} ;
         A25NotificacaoTexto = "";
         AV9GXM1WorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt = new SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesnotificacao_notificacao_list_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A23NotificacaoId, P00002_A25NotificacaoTexto, P00002_A24NotificacaoTipo, P00002_A61NotificacaoLigacaoId, P00002_n61NotificacaoLigacaoId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A24NotificacaoTipo ;
      private int AV5gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV6start ;
      private long AV7count ;
      private long A23NotificacaoId ;
      private long A61NotificacaoLigacaoId ;
      private String scmdbuf ;
      private bool n61NotificacaoLigacaoId ;
      private String A25NotificacaoTexto ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A23NotificacaoId ;
      private String[] P00002_A25NotificacaoTexto ;
      private short[] P00002_A24NotificacaoTipo ;
      private long[] P00002_A61NotificacaoLigacaoId ;
      private bool[] P00002_n61NotificacaoLigacaoId ;
      private GXBaseCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item> aP3_GXM2RootCol ;
      private GXBaseCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item> AV8GXM2RootCol ;
      private SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item AV9GXM1WorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt ;
   }

   public class workwithdevicesnotificacao_notificacao_list_grid1__default : DataStoreHelperBase, IDataStoreHelper
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
              new CursorDef("P00002", "SELECT [NotificacaoId], [NotificacaoTexto], [NotificacaoTipo], [NotificacaoLigacaoId] FROM [Notificacao] WITH (NOLOCK) ORDER BY [NotificacaoId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,false,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
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

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesnotificacao_notificacao_list_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesnotificacao_notificacao_list_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_RESTInterface> execute( String start ,
                                                                                                                    String count ,
                                                                                                                    String gxid )
    {
       GxGenericCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesnotificacao_notificacao_list_grid1") )
          {
             return null ;
          }
          workwithdevicesnotificacao_notificacao_list_grid1 worker = new workwithdevicesnotificacao_notificacao_list_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item>() ;
          worker.execute(gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
