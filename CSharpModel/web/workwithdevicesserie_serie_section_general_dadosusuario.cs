/*
               File: WorkWithDevicesSerie_Serie_Section_General_DadosUsuario
        Description: WorkWithDevicesSerie_Serie_Section_General_DadosUsuario
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/13/2018 20:58:35.84
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
   public class workwithdevicesserie_serie_section_general_dadosusuario : GXProcedure
   {
      public workwithdevicesserie_serie_section_general_dadosusuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesserie_serie_section_general_dadosusuario( IGxContext context )
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
                           out GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item> aP4_GXM2RootCol )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV14start = aP1_start;
         this.AV15count = aP2_count;
         this.AV11gxid = aP3_gxid;
         this.AV16GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM2RootCol=this.AV16GXM2RootCol;
      }

      public GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item> executeUdp( long aP0_SerieId ,
                                                                                                              long aP1_start ,
                                                                                                              long aP2_count ,
                                                                                                              int aP3_gxid )
      {
         this.A1SerieId = aP0_SerieId;
         this.AV14start = aP1_start;
         this.AV15count = aP2_count;
         this.AV11gxid = aP3_gxid;
         this.AV16GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM2RootCol=this.AV16GXM2RootCol;
         return AV16GXM2RootCol ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 long aP1_start ,
                                 long aP2_count ,
                                 int aP3_gxid ,
                                 out GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item> aP4_GXM2RootCol )
      {
         workwithdevicesserie_serie_section_general_dadosusuario objworkwithdevicesserie_serie_section_general_dadosusuario;
         objworkwithdevicesserie_serie_section_general_dadosusuario = new workwithdevicesserie_serie_section_general_dadosusuario();
         objworkwithdevicesserie_serie_section_general_dadosusuario.A1SerieId = aP0_SerieId;
         objworkwithdevicesserie_serie_section_general_dadosusuario.AV14start = aP1_start;
         objworkwithdevicesserie_serie_section_general_dadosusuario.AV15count = aP2_count;
         objworkwithdevicesserie_serie_section_general_dadosusuario.AV11gxid = aP3_gxid;
         objworkwithdevicesserie_serie_section_general_dadosusuario.AV16GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item>( context, "Item", "") ;
         objworkwithdevicesserie_serie_section_general_dadosusuario.context.SetSubmitInitialConfig(context);
         objworkwithdevicesserie_serie_section_general_dadosusuario.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesserie_serie_section_general_dadosusuario);
         aP4_GXM2RootCol=this.AV16GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesserie_serie_section_general_dadosusuario)stateInfo).executePrivate();
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
         AV20Favoritar_GXI = Gxwebsession.Get(Gxids+"gxvar_Favoritar");
         AV6Favoritar = "";
         AV21Marcarassistido_GXI = Gxwebsession.Get(Gxids+"gxvar_Marcarassistido");
         AV7MarcarAssistido = "";
         GXPagingFrom2 = (int)(AV14start);
         GXPagingTo2 = (int)(AV15count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {A1SerieId, GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt = new SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item(context);
            new verificarserieusuario(context ).execute(  A1SerieId,  "123456", out  AV10Favorita, out  AV9Assistido) ;
            if ( AV10Favorita )
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
               AV7MarcarAssistido = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
               AV21Marcarassistido_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
            }
            AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt.gxTpr_Serieid = A1SerieId;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt.gxTpr_Favoritar = AV6Favoritar;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt.gxTpr_Favoritar_gxi = AV20Favoritar_GXI;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt.gxTpr_Marcarassistido = AV7MarcarAssistido;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt.gxTpr_Marcarassistido_gxi = AV21Marcarassistido_GXI;
            AV16GXM2RootCol.Add(AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt, 0);
            AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt = new SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item(context);
            AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt.gxTpr_Serieid = A1SerieId;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt.gxTpr_Favoritar = AV6Favoritar;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt.gxTpr_Favoritar_gxi = AV20Favoritar_GXI;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt.gxTpr_Marcarassistido = AV7MarcarAssistido;
            AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt.gxTpr_Marcarassistido_gxi = AV21Marcarassistido_GXI;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
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
         AV20Favoritar_GXI = "";
         Gxwebsession = context.GetSession();
         AV6Favoritar = "";
         AV21Marcarassistido_GXI = "";
         AV7MarcarAssistido = "";
         scmdbuf = "";
         P00002_A1SerieId = new long[1] ;
         AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt = new SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesserie_serie_section_general_dadosusuario__default(),
            new Object[][] {
                new Object[] {
               P00002_A1SerieId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV11gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long A1SerieId ;
      private long AV14start ;
      private long AV15count ;
      private String Gxids ;
      private String scmdbuf ;
      private bool AV10Favorita ;
      private bool AV9Assistido ;
      private String AV20Favoritar_GXI ;
      private String AV21Marcarassistido_GXI ;
      private String AV6Favoritar ;
      private String AV7MarcarAssistido ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A1SerieId ;
      private GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item> aP4_GXM2RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item> AV16GXM2RootCol ;
      private SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item AV17GXM1WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt ;
   }

   public class workwithdevicesserie_serie_section_general_dadosusuario__default : DataStoreHelperBase, IDataStoreHelper
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

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesserie_serie_section_general_dadosusuario_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesserie_serie_section_general_dadosusuario_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?SerieId={SerieId}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_RESTInterface> execute( String SerieId ,
                                                                                                                          String start ,
                                                                                                                          String count ,
                                                                                                                          String gxid )
    {
       GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesserie_serie_section_general_dadosusuario") )
          {
             return null ;
          }
          workwithdevicesserie_serie_section_general_dadosusuario worker = new workwithdevicesserie_serie_section_general_dadosusuario(context) ;
          worker.IsMain = RunAsMain ;
          long gxrSerieId ;
          gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item>() ;
          worker.execute(gxrSerieId,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
