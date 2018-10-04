/*
               File: SDPerfil_Level_Detail
        Description: SDPerfil_Level_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/23/2018 19:29:41.81
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
   public class sdperfil_level_detail : GXProcedure
   {
      public sdperfil_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdperfil_level_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( int aP0_gxid ,
                           out SdtSDPerfil_Level_DetailSdt aP1_GXM1SDPerfil_Level_DetailSdt )
      {
         this.AV5gxid = aP0_gxid;
         this.AV6GXM1SDPerfil_Level_DetailSdt = new SdtSDPerfil_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1SDPerfil_Level_DetailSdt=this.AV6GXM1SDPerfil_Level_DetailSdt;
      }

      public SdtSDPerfil_Level_DetailSdt executeUdp( int aP0_gxid )
      {
         this.AV5gxid = aP0_gxid;
         this.AV6GXM1SDPerfil_Level_DetailSdt = new SdtSDPerfil_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1SDPerfil_Level_DetailSdt=this.AV6GXM1SDPerfil_Level_DetailSdt;
         return AV6GXM1SDPerfil_Level_DetailSdt ;
      }

      public void executeSubmit( int aP0_gxid ,
                                 out SdtSDPerfil_Level_DetailSdt aP1_GXM1SDPerfil_Level_DetailSdt )
      {
         sdperfil_level_detail objsdperfil_level_detail;
         objsdperfil_level_detail = new sdperfil_level_detail();
         objsdperfil_level_detail.AV5gxid = aP0_gxid;
         objsdperfil_level_detail.AV6GXM1SDPerfil_Level_DetailSdt = new SdtSDPerfil_Level_DetailSdt(context) ;
         objsdperfil_level_detail.context.SetSubmitInitialConfig(context);
         objsdperfil_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdperfil_level_detail);
         aP1_GXM1SDPerfil_Level_DetailSdt=this.AV6GXM1SDPerfil_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdperfil_level_detail)stateInfo).executePrivate();
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
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11UsuarioId = P00002_A11UsuarioId[0];
            A12UsuarioNome = P00002_A12UsuarioNome[0];
            AV6GXM1SDPerfil_Level_DetailSdt.gxTpr_Usuarioid = A11UsuarioId;
            AV6GXM1SDPerfil_Level_DetailSdt.gxTpr_Usuarionome = A12UsuarioNome;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
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
         P00002_A12UsuarioNome = new String[] {""} ;
         A12UsuarioNome = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdperfil_level_detail__default(),
            new Object[][] {
                new Object[] {
               P00002_A11UsuarioId, P00002_A12UsuarioNome
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV5gxid ;
      private long A11UsuarioId ;
      private String scmdbuf ;
      private String A12UsuarioNome ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A11UsuarioId ;
      private String[] P00002_A12UsuarioNome ;
      private SdtSDPerfil_Level_DetailSdt aP1_GXM1SDPerfil_Level_DetailSdt ;
      private SdtSDPerfil_Level_DetailSdt AV6GXM1SDPerfil_Level_DetailSdt ;
   }

   public class sdperfil_level_detail__default : DataStoreHelperBase, IDataStoreHelper
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
              new CursorDef("P00002", "SELECT TOP 1 [UsuarioId], [UsuarioNome] FROM [Usuario] WITH (NOLOCK) ORDER BY [UsuarioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
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

 [ServiceContract(Namespace = "GeneXus.Programs.sdperfil_level_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdperfil_level_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?gxid={gxid}")]
    public SdtSDPerfil_Level_DetailSdt_RESTInterface execute( String gxid )
    {
       SdtSDPerfil_Level_DetailSdt_RESTInterface GXM1SDPerfil_Level_DetailSdt = new SdtSDPerfil_Level_DetailSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("sdperfil_level_detail") )
          {
             return null ;
          }
          sdperfil_level_detail worker = new sdperfil_level_detail(context) ;
          worker.IsMain = RunAsMain ;
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtSDPerfil_Level_DetailSdt gxrGXM1SDPerfil_Level_DetailSdt = GXM1SDPerfil_Level_DetailSdt.sdt ;
          worker.execute(gxrgxid,out gxrGXM1SDPerfil_Level_DetailSdt );
          worker.cleanup( );
          GXM1SDPerfil_Level_DetailSdt = new SdtSDPerfil_Level_DetailSdt_RESTInterface(gxrGXM1SDPerfil_Level_DetailSdt) ;
          return GXM1SDPerfil_Level_DetailSdt ;
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
