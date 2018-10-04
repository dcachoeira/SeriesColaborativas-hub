/*
               File: WorkWithDevicesUsuarioSerie_UsuarioSerie_Detail
        Description: WorkWithDevicesUsuarioSerie_UsuarioSerie_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:45:59.98
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
   public class workwithdevicesusuarioserie_usuarioserie_detail : GXProcedure
   {
      public workwithdevicesusuarioserie_usuarioserie_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesusuarioserie_usuarioserie_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_UsuarioSerieId ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt aP2_GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt )
      {
         this.A13UsuarioSerieId = aP0_UsuarioSerieId;
         this.AV7gxid = aP1_gxid;
         this.AV12GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt=this.AV12GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt;
      }

      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt executeUdp( long aP0_UsuarioSerieId ,
                                                                               int aP1_gxid )
      {
         this.A13UsuarioSerieId = aP0_UsuarioSerieId;
         this.AV7gxid = aP1_gxid;
         this.AV12GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt=this.AV12GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt;
         return AV12GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt ;
      }

      public void executeSubmit( long aP0_UsuarioSerieId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt aP2_GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt )
      {
         workwithdevicesusuarioserie_usuarioserie_detail objworkwithdevicesusuarioserie_usuarioserie_detail;
         objworkwithdevicesusuarioserie_usuarioserie_detail = new workwithdevicesusuarioserie_usuarioserie_detail();
         objworkwithdevicesusuarioserie_usuarioserie_detail.A13UsuarioSerieId = aP0_UsuarioSerieId;
         objworkwithdevicesusuarioserie_usuarioserie_detail.AV7gxid = aP1_gxid;
         objworkwithdevicesusuarioserie_usuarioserie_detail.AV12GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt(context) ;
         objworkwithdevicesusuarioserie_usuarioserie_detail.context.SetSubmitInitialConfig(context);
         objworkwithdevicesusuarioserie_usuarioserie_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesusuarioserie_usuarioserie_detail);
         aP2_GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt=this.AV12GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesusuarioserie_usuarioserie_detail)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV7gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            /* Using cursor P00002 */
            pr_default.execute(0, new Object[] {A13UsuarioSerieId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A14UsuarioSerieNota = P00002_A14UsuarioSerieNota[0];
               Gxdynprop1 = StringUtil.Str( (decimal)(A14UsuarioSerieNota), 1, 0);
               Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            Gxwebsession.Set(Gxids, "true");
         }
         AV12GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
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
         P00002_A13UsuarioSerieId = new long[1] ;
         P00002_A14UsuarioSerieNota = new short[1] ;
         Gxdynprop1 = "";
         Gxdynprop = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesusuarioserie_usuarioserie_detail__default(),
            new Object[][] {
                new Object[] {
               P00002_A13UsuarioSerieId, P00002_A14UsuarioSerieNota
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A14UsuarioSerieNota ;
      private int AV7gxid ;
      private long A13UsuarioSerieId ;
      private String Gxids ;
      private String scmdbuf ;
      private String Gxdynprop1 ;
      private String Gxdynprop ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A13UsuarioSerieId ;
      private short[] P00002_A14UsuarioSerieNota ;
      private SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt aP2_GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt AV12GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt ;
   }

   public class workwithdevicesusuarioserie_usuarioserie_detail__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [UsuarioSerieId], [UsuarioSerieNota] FROM [UsuarioSerie] WITH (NOLOCK) WHERE [UsuarioSerieId] = @UsuarioSerieId ORDER BY [UsuarioSerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
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

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesusuarioserie_usuarioserie_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesusuarioserie_usuarioserie_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?UsuarioSerieId={UsuarioSerieId}&gxid={gxid}")]
    public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_RESTInterface execute( String UsuarioSerieId ,
                                                                                        String gxid )
    {
       SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_RESTInterface GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesusuarioserie_usuarioserie_detail") )
          {
             return null ;
          }
          workwithdevicesusuarioserie_usuarioserie_detail worker = new workwithdevicesusuarioserie_usuarioserie_detail(context) ;
          worker.IsMain = RunAsMain ;
          long gxrUsuarioSerieId ;
          gxrUsuarioSerieId = (long)(NumberUtil.Val( (String)(UsuarioSerieId), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt gxrGXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt = GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt.sdt ;
          worker.execute(gxrUsuarioSerieId,gxrgxid,out gxrGXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt );
          worker.cleanup( );
          GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_RESTInterface(gxrGXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt) ;
          return GXM2WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt ;
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
