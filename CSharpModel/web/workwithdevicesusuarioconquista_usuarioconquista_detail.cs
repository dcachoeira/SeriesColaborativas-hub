/*
               File: WorkWithDevicesUsuarioConquista_UsuarioConquista_Detail
        Description: WorkWithDevicesUsuarioConquista_UsuarioConquista_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:28.15
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
   public class workwithdevicesusuarioconquista_usuarioconquista_detail : GXProcedure
   {
      public workwithdevicesusuarioconquista_usuarioconquista_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesusuarioconquista_usuarioconquista_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_UsuarioConquistaId ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt aP2_GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt )
      {
         this.A30UsuarioConquistaId = aP0_UsuarioConquistaId;
         this.AV6gxid = aP1_gxid;
         this.AV11GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt=this.AV11GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt;
      }

      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt executeUdp( long aP0_UsuarioConquistaId ,
                                                                                       int aP1_gxid )
      {
         this.A30UsuarioConquistaId = aP0_UsuarioConquistaId;
         this.AV6gxid = aP1_gxid;
         this.AV11GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt=this.AV11GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt;
         return AV11GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt ;
      }

      public void executeSubmit( long aP0_UsuarioConquistaId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt aP2_GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt )
      {
         workwithdevicesusuarioconquista_usuarioconquista_detail objworkwithdevicesusuarioconquista_usuarioconquista_detail;
         objworkwithdevicesusuarioconquista_usuarioconquista_detail = new workwithdevicesusuarioconquista_usuarioconquista_detail();
         objworkwithdevicesusuarioconquista_usuarioconquista_detail.A30UsuarioConquistaId = aP0_UsuarioConquistaId;
         objworkwithdevicesusuarioconquista_usuarioconquista_detail.AV6gxid = aP1_gxid;
         objworkwithdevicesusuarioconquista_usuarioconquista_detail.AV11GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt(context) ;
         objworkwithdevicesusuarioconquista_usuarioconquista_detail.context.SetSubmitInitialConfig(context);
         objworkwithdevicesusuarioconquista_usuarioconquista_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesusuarioconquista_usuarioconquista_detail);
         aP2_GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt=this.AV11GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesusuarioconquista_usuarioconquista_detail)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV6gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            /* Using cursor P00002 */
            pr_default.execute(0, new Object[] {A30UsuarioConquistaId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A31UsuarioConquistaDataHora = P00002_A31UsuarioConquistaDataHora[0];
               Gxdynprop1 = context.localUtil.TToC( A31UsuarioConquistaDataHora, 8, 5, 0, 3, "/", ":", " ");
               Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            Gxwebsession.Set(Gxids, "true");
         }
         AV11GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
         Gxdynprop = "";
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
         scmdbuf = "";
         P00002_A30UsuarioConquistaId = new long[1] ;
         P00002_A31UsuarioConquistaDataHora = new DateTime[] {DateTime.MinValue} ;
         A31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
         Gxdynprop1 = "";
         Gxdynprop = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesusuarioconquista_usuarioconquista_detail__default(),
            new Object[][] {
                new Object[] {
               P00002_A30UsuarioConquistaId, P00002_A31UsuarioConquistaDataHora
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV6gxid ;
      private long A30UsuarioConquistaId ;
      private String Gxids ;
      private String scmdbuf ;
      private String Gxdynprop1 ;
      private DateTime A31UsuarioConquistaDataHora ;
      private String Gxdynprop ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A30UsuarioConquistaId ;
      private DateTime[] P00002_A31UsuarioConquistaDataHora ;
      private SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt aP2_GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt AV11GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt ;
   }

   public class workwithdevicesusuarioconquista_usuarioconquista_detail__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [UsuarioConquistaId], [UsuarioConquistaDataHora] FROM [UsuarioConquista] WITH (NOLOCK) WHERE [UsuarioConquistaId] = @UsuarioConquistaId ORDER BY [UsuarioConquistaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
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

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesusuarioconquista_usuarioconquista_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesusuarioconquista_usuarioconquista_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?UsuarioConquistaId={UsuarioConquistaId}&gxid={gxid}")]
    public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_RESTInterface execute( String UsuarioConquistaId ,
                                                                                                String gxid )
    {
       SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_RESTInterface GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesusuarioconquista_usuarioconquista_detail") )
          {
             return null ;
          }
          workwithdevicesusuarioconquista_usuarioconquista_detail worker = new workwithdevicesusuarioconquista_usuarioconquista_detail(context) ;
          worker.IsMain = RunAsMain ;
          long gxrUsuarioConquistaId ;
          gxrUsuarioConquistaId = (long)(NumberUtil.Val( (String)(UsuarioConquistaId), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt gxrGXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt = GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt.sdt ;
          worker.execute(gxrUsuarioConquistaId,gxrgxid,out gxrGXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt );
          worker.cleanup( );
          GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_RESTInterface(gxrGXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt) ;
          return GXM2WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt ;
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
