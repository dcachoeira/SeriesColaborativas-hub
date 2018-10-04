/*
               File: WorkWithDevicesSerie_Serie_Detail
        Description: WorkWithDevicesSerie_Serie_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:31.61
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
   public class workwithdevicesserie_serie_detail : GXProcedure
   {
      public workwithdevicesserie_serie_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesserie_serie_detail( IGxContext context )
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
                           out SdtWorkWithDevicesSerie_Serie_DetailSdt aP2_GXM2WorkWithDevicesSerie_Serie_DetailSdt )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV11gxid = aP1_gxid;
         this.AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt = new SdtWorkWithDevicesSerie_Serie_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2WorkWithDevicesSerie_Serie_DetailSdt=this.AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt;
      }

      public SdtWorkWithDevicesSerie_Serie_DetailSdt executeUdp( long aP0_SerieId ,
                                                                 int aP1_gxid )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV11gxid = aP1_gxid;
         this.AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt = new SdtWorkWithDevicesSerie_Serie_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2WorkWithDevicesSerie_Serie_DetailSdt=this.AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt;
         return AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesSerie_Serie_DetailSdt aP2_GXM2WorkWithDevicesSerie_Serie_DetailSdt )
      {
         workwithdevicesserie_serie_detail objworkwithdevicesserie_serie_detail;
         objworkwithdevicesserie_serie_detail = new workwithdevicesserie_serie_detail();
         objworkwithdevicesserie_serie_detail.A1SerieId = aP0_SerieId;
         objworkwithdevicesserie_serie_detail.AV11gxid = aP1_gxid;
         objworkwithdevicesserie_serie_detail.AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt = new SdtWorkWithDevicesSerie_Serie_DetailSdt(context) ;
         objworkwithdevicesserie_serie_detail.context.SetSubmitInitialConfig(context);
         objworkwithdevicesserie_serie_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesserie_serie_detail);
         aP2_GXM2WorkWithDevicesSerie_Serie_DetailSdt=this.AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesserie_serie_detail)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV11gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            /* Using cursor P00002 */
            pr_default.execute(0, new Object[] {A1SerieId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A2SerieNome = P00002_A2SerieNome[0];
               Gxdynprop1 = A2SerieNome;
               Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            Gxwebsession.Set(Gxids+"gxvar_Favoritar", AV20Favoritar_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Assistido", StringUtil.BoolToStr( AV9Assistido));
            Gxwebsession.Set(Gxids+"gxvar_Favorita", StringUtil.BoolToStr( AV8Favorita));
            Gxwebsession.Set(Gxids+"gxvar_Marcarassistido", AV21Marcarassistido_GXI);
            Gxwebsession.Set(Gxids, "true");
         }
         else
         {
            AV9Assistido = BooleanUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Assistido"));
            AV8Favorita = BooleanUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Favorita"));
            AV20Favoritar_GXI = Gxwebsession.Get(Gxids+"gxvar_Favoritar");
            AV6Favoritar = "";
            AV21Marcarassistido_GXI = Gxwebsession.Get(Gxids+"gxvar_Marcarassistido");
            AV7MarcarAssistido = "";
         }
         /* Using cursor P00003 */
         pr_default.execute(1, new Object[] {A1SerieId});
         while ( (pr_default.getStatus(1) != 101) )
         {
            new verificarserieusuario(context ).execute(  A1SerieId,  "123456", out  AV8Favorita, out  AV9Assistido) ;
            if ( AV8Favorita )
            {
               AV6Favoritar = context.GetImagePath( "36fbff47-1ab6-4c69-a869-d775c2c91b99", "", context.GetTheme( ));
               AV20Favoritar_GXI = GXDbFile.PathToUrl( context.GetImagePath( "36fbff47-1ab6-4c69-a869-d775c2c91b99", "", context.GetTheme( )));
            }
            else
            {
               AV6Favoritar = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
               AV20Favoritar_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            }
            if ( AV9Assistido )
            {
               AV7MarcarAssistido = context.GetImagePath( "451cf230-8c7c-4f17-8440-ff7c487b2ad9", "", context.GetTheme( ));
               AV21Marcarassistido_GXI = GXDbFile.PathToUrl( context.GetImagePath( "451cf230-8c7c-4f17-8440-ff7c487b2ad9", "", context.GetTheme( )));
            }
            else
            {
               AV7MarcarAssistido = context.GetImagePath( "df8aee37-3ddd-479f-a9aa-1c4957c02e0a", "", context.GetTheme( ));
               AV21Marcarassistido_GXI = GXDbFile.PathToUrl( context.GetImagePath( "df8aee37-3ddd-479f-a9aa-1c4957c02e0a", "", context.GetTheme( )));
            }
            AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt.gxTpr_Serieid = A1SerieId;
            AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt.gxTpr_Favoritar = AV6Favoritar;
            AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt.gxTpr_Favoritar_gxi = AV20Favoritar_GXI;
            AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt.gxTpr_Assistido = AV9Assistido;
            AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt.gxTpr_Favorita = AV8Favorita;
            AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt.gxTpr_Marcarassistido = AV7MarcarAssistido;
            AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt.gxTpr_Marcarassistido_gxi = AV21Marcarassistido_GXI;
            AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
            Gxdynprop = "";
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         Gxwebsession.Set(Gxids+"gxvar_Assistido", StringUtil.BoolToStr( AV9Assistido));
         Gxwebsession.Set(Gxids+"gxvar_Favorita", StringUtil.BoolToStr( AV8Favorita));
         Gxwebsession.Set(Gxids+"gxvar_Favoritar", AV20Favoritar_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Marcarassistido", AV21Marcarassistido_GXI);
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
         P00002_A1SerieId = new long[1] ;
         P00002_A2SerieNome = new String[] {""} ;
         A2SerieNome = "";
         Gxdynprop1 = "";
         Gxdynprop = "";
         AV20Favoritar_GXI = "";
         AV21Marcarassistido_GXI = "";
         AV6Favoritar = "";
         AV7MarcarAssistido = "";
         P00003_A1SerieId = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesserie_serie_detail__default(),
            new Object[][] {
                new Object[] {
               P00002_A1SerieId, P00002_A2SerieNome
               }
               , new Object[] {
               P00003_A1SerieId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV11gxid ;
      private long A1SerieId ;
      private String Gxids ;
      private String scmdbuf ;
      private bool AV9Assistido ;
      private bool AV8Favorita ;
      private String A2SerieNome ;
      private String Gxdynprop1 ;
      private String Gxdynprop ;
      private String AV20Favoritar_GXI ;
      private String AV21Marcarassistido_GXI ;
      private String AV6Favoritar ;
      private String AV7MarcarAssistido ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A1SerieId ;
      private String[] P00002_A2SerieNome ;
      private long[] P00003_A1SerieId ;
      private SdtWorkWithDevicesSerie_Serie_DetailSdt aP2_GXM2WorkWithDevicesSerie_Serie_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesSerie_Serie_DetailSdt AV16GXM2WorkWithDevicesSerie_Serie_DetailSdt ;
   }

   public class workwithdevicesserie_serie_detail__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00002 ;
          prmP00002 = new Object[] {
          new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP00003 ;
          prmP00003 = new Object[] {
          new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [SerieId], [SerieNome] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
             ,new CursorDef("P00003", "SELECT TOP 1 [SerieId] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00003,1,0,true,true )
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
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesserie_serie_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesserie_serie_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?SerieId={SerieId}&gxid={gxid}")]
    public SdtWorkWithDevicesSerie_Serie_DetailSdt_RESTInterface execute( String SerieId ,
                                                                          String gxid )
    {
       SdtWorkWithDevicesSerie_Serie_DetailSdt_RESTInterface GXM2WorkWithDevicesSerie_Serie_DetailSdt = new SdtWorkWithDevicesSerie_Serie_DetailSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesserie_serie_detail") )
          {
             return null ;
          }
          workwithdevicesserie_serie_detail worker = new workwithdevicesserie_serie_detail(context) ;
          worker.IsMain = RunAsMain ;
          long gxrSerieId ;
          gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtWorkWithDevicesSerie_Serie_DetailSdt gxrGXM2WorkWithDevicesSerie_Serie_DetailSdt = GXM2WorkWithDevicesSerie_Serie_DetailSdt.sdt ;
          worker.execute(gxrSerieId,gxrgxid,out gxrGXM2WorkWithDevicesSerie_Serie_DetailSdt );
          worker.cleanup( );
          GXM2WorkWithDevicesSerie_Serie_DetailSdt = new SdtWorkWithDevicesSerie_Serie_DetailSdt_RESTInterface(gxrGXM2WorkWithDevicesSerie_Serie_DetailSdt) ;
          return GXM2WorkWithDevicesSerie_Serie_DetailSdt ;
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
