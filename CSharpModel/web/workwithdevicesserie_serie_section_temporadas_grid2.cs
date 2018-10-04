/*
               File: WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2
        Description: WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:32.15
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
   public class workwithdevicesserie_serie_section_temporadas_grid2 : GXProcedure
   {
      public workwithdevicesserie_serie_section_temporadas_grid2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesserie_serie_section_temporadas_grid2( IGxContext context )
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
                           long aP1_start ,
                           long aP2_count ,
                           int aP3_gxid ,
                           out GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item> aP4_GXM3RootCol )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV13start = aP1_start;
         this.AV14count = aP2_count;
         this.AV10gxid = aP3_gxid;
         this.AV17GXM3RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM3RootCol=this.AV17GXM3RootCol;
      }

      public GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item> executeUdp( long aP0_SerieId ,
                                                                                                          long aP1_start ,
                                                                                                          long aP2_count ,
                                                                                                          int aP3_gxid )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV13start = aP1_start;
         this.AV14count = aP2_count;
         this.AV10gxid = aP3_gxid;
         this.AV17GXM3RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM3RootCol=this.AV17GXM3RootCol;
         return AV17GXM3RootCol ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 long aP1_start ,
                                 long aP2_count ,
                                 int aP3_gxid ,
                                 out GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item> aP4_GXM3RootCol )
      {
         workwithdevicesserie_serie_section_temporadas_grid2 objworkwithdevicesserie_serie_section_temporadas_grid2;
         objworkwithdevicesserie_serie_section_temporadas_grid2 = new workwithdevicesserie_serie_section_temporadas_grid2();
         objworkwithdevicesserie_serie_section_temporadas_grid2.A1SerieId = aP0_SerieId;
         objworkwithdevicesserie_serie_section_temporadas_grid2.AV13start = aP1_start;
         objworkwithdevicesserie_serie_section_temporadas_grid2.AV14count = aP2_count;
         objworkwithdevicesserie_serie_section_temporadas_grid2.AV10gxid = aP3_gxid;
         objworkwithdevicesserie_serie_section_temporadas_grid2.AV17GXM3RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item>( context, "Item", "") ;
         objworkwithdevicesserie_serie_section_temporadas_grid2.context.SetSubmitInitialConfig(context);
         objworkwithdevicesserie_serie_section_temporadas_grid2.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesserie_serie_section_temporadas_grid2);
         aP4_GXM3RootCol=this.AV17GXM3RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesserie_serie_section_temporadas_grid2)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV10gxid), 8, 0);
         AV7QuantidadeTemporadas = (short)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Quantidadetemporadas"), "."));
         AV6Temporada = (short)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Temporada"), "."));
         GXPagingFrom2 = (int)(AV13start);
         GXPagingTo2 = (int)(AV14count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {A1SerieId, GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            AV18GXM2WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt = new SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item(context);
            AV8i = 1;
            while ( AV8i <= AV7QuantidadeTemporadas )
            {
               Gxdynprop1 = StringUtil.Str( (decimal)(AV8i), 4, 0) + "ª Temporada";
               Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Txbtemporada\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
               new verificarepisodiosassistidostemporada(context ).execute(  A1SerieId,  AV8i, out  AV9Assistido) ;
               if ( AV9Assistido )
               {
                  Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Assistido\",\"Visible\",\"" + "True" + "\"]";
               }
               else
               {
                  Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Assistido\",\"Visible\",\"" + "False" + "\"]";
               }
               AV6Temporada = AV8i;
               AV18GXM2WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt.gxTpr_Serieid = A1SerieId;
               AV18GXM2WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt.gxTpr_Temporada = AV6Temporada;
               AV18GXM2WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
               Gxdynprop = "";
               AV17GXM3RootCol.Add(AV18GXM2WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt, 0);
               AV18GXM2WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt = new SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item(context);
               AV8i = (short)(AV8i+1);
            }
            AV18GXM2WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt.gxTpr_Serieid = A1SerieId;
            AV18GXM2WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt.gxTpr_Temporada = AV6Temporada;
            AV18GXM2WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
            Gxdynprop = "";
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         Gxwebsession.Set(Gxids+"gxvar_Quantidadetemporadas", StringUtil.Str( (decimal)(AV7QuantidadeTemporadas), 4, 0));
         Gxwebsession.Set(Gxids+"gxvar_Temporada", StringUtil.Str( (decimal)(AV6Temporada), 4, 0));
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
         AV18GXM2WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt = new SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item(context);
         Gxdynprop1 = "";
         Gxdynprop = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesserie_serie_section_temporadas_grid2__default(),
            new Object[][] {
                new Object[] {
               P00002_A1SerieId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV7QuantidadeTemporadas ;
      private short AV6Temporada ;
      private short AV8i ;
      private int AV10gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long A1SerieId ;
      private long AV13start ;
      private long AV14count ;
      private String Gxids ;
      private String scmdbuf ;
      private String Gxdynprop1 ;
      private bool AV9Assistido ;
      private String Gxdynprop ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A1SerieId ;
      private GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item> aP4_GXM3RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item> AV17GXM3RootCol ;
      private SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item AV18GXM2WorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt ;
   }

   public class workwithdevicesserie_serie_section_temporadas_grid2__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@SerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [SerieId] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ORDER BY [SerieId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,true,true )
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

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesserie_serie_section_temporadas_grid2_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesserie_serie_section_temporadas_grid2_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?SerieId={SerieId}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item_RESTInterface> execute( String SerieId ,
                                                                                                                      String start ,
                                                                                                                      String count ,
                                                                                                                      String gxid )
    {
       GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item_RESTInterface> GXM3RootCol = new GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesserie_serie_section_temporadas_grid2") )
          {
             return null ;
          }
          workwithdevicesserie_serie_section_temporadas_grid2 worker = new workwithdevicesserie_serie_section_temporadas_grid2(context) ;
          worker.IsMain = RunAsMain ;
          long gxrSerieId ;
          gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item> gxrGXM3RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item>() ;
          worker.execute(gxrSerieId,gxrstart,gxrcount,gxrgxid,out gxrGXM3RootCol );
          worker.cleanup( );
          GXM3RootCol = new GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item_RESTInterface>(gxrGXM3RootCol) ;
          return GXM3RootCol ;
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
