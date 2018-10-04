/*
               File: SDSerie_Level_Detail
        Description: SDSerie_Level_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/30/2018 21:13:3.48
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
   public class sdserie_level_detail : GXProcedure
   {
      public sdserie_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdserie_level_detail( IGxContext context )
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
                           int aP1_gxid ,
                           out SdtSDSerie_Level_DetailSdt aP2_GXM2SDSerie_Level_DetailSdt )
      {
         this.AV5SerieId = aP0_SerieId;
         this.AV15gxid = aP1_gxid;
         this.AV20GXM2SDSerie_Level_DetailSdt = new SdtSDSerie_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2SDSerie_Level_DetailSdt=this.AV20GXM2SDSerie_Level_DetailSdt;
      }

      public SdtSDSerie_Level_DetailSdt executeUdp( long aP0_SerieId ,
                                                    int aP1_gxid )
      {
         this.AV5SerieId = aP0_SerieId;
         this.AV15gxid = aP1_gxid;
         this.AV20GXM2SDSerie_Level_DetailSdt = new SdtSDSerie_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2SDSerie_Level_DetailSdt=this.AV20GXM2SDSerie_Level_DetailSdt;
         return AV20GXM2SDSerie_Level_DetailSdt ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 int aP1_gxid ,
                                 out SdtSDSerie_Level_DetailSdt aP2_GXM2SDSerie_Level_DetailSdt )
      {
         sdserie_level_detail objsdserie_level_detail;
         objsdserie_level_detail = new sdserie_level_detail();
         objsdserie_level_detail.AV5SerieId = aP0_SerieId;
         objsdserie_level_detail.AV15gxid = aP1_gxid;
         objsdserie_level_detail.AV20GXM2SDSerie_Level_DetailSdt = new SdtSDSerie_Level_DetailSdt(context) ;
         objsdserie_level_detail.context.SetSubmitInitialConfig(context);
         objsdserie_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdserie_level_detail);
         aP2_GXM2SDSerie_Level_DetailSdt=this.AV20GXM2SDSerie_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdserie_level_detail)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV15gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            /* Using cursor P00002 */
            pr_default.execute(0, new Object[] {AV5SerieId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A48GeneroId = P00002_A48GeneroId[0];
               A1SerieId = P00002_A1SerieId[0];
               A2SerieNome = P00002_A2SerieNome[0];
               A3SerieQuantidadeTemporadas = P00002_A3SerieQuantidadeTemporadas[0];
               A49GeneroNome = P00002_A49GeneroNome[0];
               A6SerieResumo = P00002_A6SerieResumo[0];
               A49GeneroNome = P00002_A49GeneroNome[0];
               AV6SerieNome = A2SerieNome;
               AV9QuantidadeTemporadas = A3SerieQuantidadeTemporadas;
               AV13SerieGenero = A49GeneroNome;
               AV14SerieResumo = A6SerieResumo;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            Gxdynprop1 = "Gênero: " + AV13SerieGenero;
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Txbgenero\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Txbresumo\",\"Caption\",\"" + StringUtil.JSONEncode( AV14SerieResumo) + "\"]";
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( AV6SerieNome) + "\"]";
            Gxwebsession.Set(Gxids+"gxvar_Quantidadetemporadas", StringUtil.Str( (decimal)(AV9QuantidadeTemporadas), 4, 0));
            Gxwebsession.Set(Gxids+"gxvar_Temporada", StringUtil.Str( (decimal)(AV10Temporada), 4, 0));
            Gxwebsession.Set(Gxids, "true");
         }
         AV20GXM2SDSerie_Level_DetailSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
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
         P00002_A48GeneroId = new long[1] ;
         P00002_A1SerieId = new long[1] ;
         P00002_A2SerieNome = new String[] {""} ;
         P00002_A3SerieQuantidadeTemporadas = new short[1] ;
         P00002_A49GeneroNome = new String[] {""} ;
         P00002_A6SerieResumo = new String[] {""} ;
         A2SerieNome = "";
         A49GeneroNome = "";
         A6SerieResumo = "";
         AV6SerieNome = "";
         AV13SerieGenero = "";
         AV14SerieResumo = "";
         Gxdynprop1 = "";
         Gxdynprop = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdserie_level_detail__default(),
            new Object[][] {
                new Object[] {
               P00002_A48GeneroId, P00002_A1SerieId, P00002_A2SerieNome, P00002_A3SerieQuantidadeTemporadas, P00002_A49GeneroNome, P00002_A6SerieResumo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A3SerieQuantidadeTemporadas ;
      private short AV9QuantidadeTemporadas ;
      private short AV10Temporada ;
      private int AV15gxid ;
      private long AV5SerieId ;
      private long A48GeneroId ;
      private long A1SerieId ;
      private String Gxids ;
      private String scmdbuf ;
      private String Gxdynprop1 ;
      private String A6SerieResumo ;
      private String AV14SerieResumo ;
      private String A2SerieNome ;
      private String A49GeneroNome ;
      private String AV6SerieNome ;
      private String AV13SerieGenero ;
      private String Gxdynprop ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A48GeneroId ;
      private long[] P00002_A1SerieId ;
      private String[] P00002_A2SerieNome ;
      private short[] P00002_A3SerieQuantidadeTemporadas ;
      private String[] P00002_A49GeneroNome ;
      private String[] P00002_A6SerieResumo ;
      private SdtSDSerie_Level_DetailSdt aP2_GXM2SDSerie_Level_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtSDSerie_Level_DetailSdt AV20GXM2SDSerie_Level_DetailSdt ;
   }

   public class sdserie_level_detail__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@AV5SerieId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT T1.[GeneroId], T1.[SerieId], T1.[SerieNome], T1.[SerieQuantidadeTemporadas], T2.[GeneroNome], T1.[SerieResumo] FROM ([Serie] T1 WITH (NOLOCK) INNER JOIN [Genero] T2 WITH (NOLOCK) ON T2.[GeneroId] = T1.[GeneroId]) WHERE T1.[SerieId] = @AV5SerieId ORDER BY T1.[SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(6) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.sdserie_level_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdserie_level_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?SerieId={SerieId}&gxid={gxid}")]
    public SdtSDSerie_Level_DetailSdt_RESTInterface execute( String SerieId ,
                                                             String gxid )
    {
       SdtSDSerie_Level_DetailSdt_RESTInterface GXM2SDSerie_Level_DetailSdt = new SdtSDSerie_Level_DetailSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("sdserie_level_detail") )
          {
             return null ;
          }
          sdserie_level_detail worker = new sdserie_level_detail(context) ;
          worker.IsMain = RunAsMain ;
          long gxrSerieId ;
          gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtSDSerie_Level_DetailSdt gxrGXM2SDSerie_Level_DetailSdt = GXM2SDSerie_Level_DetailSdt.sdt ;
          worker.execute(gxrSerieId,gxrgxid,out gxrGXM2SDSerie_Level_DetailSdt );
          worker.cleanup( );
          GXM2SDSerie_Level_DetailSdt = new SdtSDSerie_Level_DetailSdt_RESTInterface(gxrGXM2SDSerie_Level_DetailSdt) ;
          return GXM2SDSerie_Level_DetailSdt ;
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
