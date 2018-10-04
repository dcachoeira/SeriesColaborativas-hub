/*
               File: WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2
        Description: WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:27.91
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
   public class workwithdevicesusuarioconquista_usuarioconquista_list_grid2 : GXProcedure
   {
      public workwithdevicesusuarioconquista_usuarioconquista_list_grid2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesusuarioconquista_usuarioconquista_list_grid2( IGxContext context )
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
                           out GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item> aP4_GXM2RootCol )
      {
         this.AV5UsuarioId = aP0_UsuarioId;
         this.AV11start = aP1_start;
         this.AV12count = aP2_count;
         this.AV8gxid = aP3_gxid;
         this.AV14GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM2RootCol=this.AV14GXM2RootCol;
      }

      public GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item> executeUdp( long aP0_UsuarioId ,
                                                                                                                  long aP1_start ,
                                                                                                                  long aP2_count ,
                                                                                                                  int aP3_gxid )
      {
         this.AV5UsuarioId = aP0_UsuarioId;
         this.AV11start = aP1_start;
         this.AV12count = aP2_count;
         this.AV8gxid = aP3_gxid;
         this.AV14GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM2RootCol=this.AV14GXM2RootCol;
         return AV14GXM2RootCol ;
      }

      public void executeSubmit( long aP0_UsuarioId ,
                                 long aP1_start ,
                                 long aP2_count ,
                                 int aP3_gxid ,
                                 out GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item> aP4_GXM2RootCol )
      {
         workwithdevicesusuarioconquista_usuarioconquista_list_grid2 objworkwithdevicesusuarioconquista_usuarioconquista_list_grid2;
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid2 = new workwithdevicesusuarioconquista_usuarioconquista_list_grid2();
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid2.AV5UsuarioId = aP0_UsuarioId;
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid2.AV11start = aP1_start;
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid2.AV12count = aP2_count;
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid2.AV8gxid = aP3_gxid;
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid2.AV14GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item>( context, "Item", "") ;
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid2.context.SetSubmitInitialConfig(context);
         objworkwithdevicesusuarioconquista_usuarioconquista_list_grid2.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesusuarioconquista_usuarioconquista_list_grid2);
         aP4_GXM2RootCol=this.AV14GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesusuarioconquista_usuarioconquista_list_grid2)stateInfo).executePrivate();
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
         AV6ConquistasId.FromJSonString(Gxwebsession.Get(Gxids+"gxvar_Conquistasid"), null);
         AV7ConquistaId = (long)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Conquistaid"), "."));
         GXPagingIdx2 = 0;
         GXPagingFrom2 = (int)(AV11start);
         GXPagingTo2 = (int)(AV11start+AV12count);
         /* Using cursor P00002 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( GXPagingTo2 == GXPagingFrom2 ) || ( GXPagingIdx2 < GXPagingTo2 ) ) )
         {
            BRK002 = false;
            A46ConquistaInativo = P00002_A46ConquistaInativo[0];
            A27ConquistaId = P00002_A27ConquistaId[0];
            A29ConquistaNome = P00002_A29ConquistaNome[0];
            GXPagingIdx2 = (int)(GXPagingIdx2+1);
            if ( GXPagingIdx2 > GXPagingFrom2 )
            {
               AV15GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item(context);
               while ( (pr_default.getStatus(0) != 101) && ( P00002_A27ConquistaId[0] == A27ConquistaId ) )
               {
                  BRK002 = false;
                  A46ConquistaInativo = P00002_A46ConquistaInativo[0];
                  A29ConquistaNome = P00002_A29ConquistaNome[0];
                  if ( ! (AV6ConquistasId.IndexOf(A27ConquistaId)>0) )
                  {
                     if ( ! A46ConquistaInativo )
                     {
                        AV7ConquistaId = A27ConquistaId;
                        Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Txbconquistanome\",\"Caption\",\"" + StringUtil.JSONEncode( A29ConquistaNome) + "\"]";
                        AV15GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt.gxTpr_Conquistaid = A27ConquistaId;
                        AV15GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
                        Gxdynprop = "";
                        AV14GXM2RootCol.Add(AV15GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt, 0);
                        AV15GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item(context);
                     }
                  }
                  BRK002 = true;
                  pr_default.readNext(0);
               }
               AV15GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt.gxTpr_Conquistaid = A27ConquistaId;
               AV15GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
               Gxdynprop = "";
            }
            if ( ! BRK002 )
            {
               BRK002 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
         Gxwebsession.Set(Gxids+"gxvar_Conquistasid", AV6ConquistasId.ToJSonString(false));
         Gxwebsession.Set(Gxids+"gxvar_Conquistaid", StringUtil.Str( (decimal)(AV7ConquistaId), 18, 0));
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
         AV6ConquistasId = new GxSimpleCollection<long>();
         Gxwebsession = context.GetSession();
         scmdbuf = "";
         P00002_A46ConquistaInativo = new bool[] {false} ;
         P00002_A27ConquistaId = new long[1] ;
         P00002_A29ConquistaNome = new String[] {""} ;
         A29ConquistaNome = "";
         AV15GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item(context);
         Gxdynprop = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesusuarioconquista_usuarioconquista_list_grid2__default(),
            new Object[][] {
                new Object[] {
               P00002_A46ConquistaInativo, P00002_A27ConquistaId, P00002_A29ConquistaNome
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV8gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int GXPagingIdx2 ;
      private long AV5UsuarioId ;
      private long AV11start ;
      private long AV12count ;
      private long AV7ConquistaId ;
      private long A27ConquistaId ;
      private String Gxids ;
      private String scmdbuf ;
      private bool BRK002 ;
      private bool A46ConquistaInativo ;
      private String A29ConquistaNome ;
      private String Gxdynprop ;
      private GxSimpleCollection<long> AV6ConquistasId ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private bool[] P00002_A46ConquistaInativo ;
      private long[] P00002_A27ConquistaId ;
      private String[] P00002_A29ConquistaNome ;
      private GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item> aP4_GXM2RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item> AV14GXM2RootCol ;
      private SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item AV15GXM1WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt ;
   }

   public class workwithdevicesusuarioconquista_usuarioconquista_list_grid2__default : DataStoreHelperBase, IDataStoreHelper
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
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [ConquistaInativo], [ConquistaId], [ConquistaNome] FROM [Conquista] WITH (NOLOCK) WHERE Not [ConquistaInativo] = 1 ORDER BY [ConquistaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,true,false )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesusuarioconquista_usuarioconquista_list_grid2_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesusuarioconquista_usuarioconquista_list_grid2_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?UsuarioId={UsuarioId}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_RESTInterface> execute( String UsuarioId ,
                                                                                                                              String start ,
                                                                                                                              String count ,
                                                                                                                              String gxid )
    {
       GxGenericCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesusuarioconquista_usuarioconquista_list_grid2") )
          {
             return null ;
          }
          workwithdevicesusuarioconquista_usuarioconquista_list_grid2 worker = new workwithdevicesusuarioconquista_usuarioconquista_list_grid2(context) ;
          worker.IsMain = RunAsMain ;
          long gxrUsuarioId ;
          gxrUsuarioId = (long)(NumberUtil.Val( (String)(UsuarioId), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item>() ;
          worker.execute(gxrUsuarioId,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
