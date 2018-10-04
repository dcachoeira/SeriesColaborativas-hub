/*
               File: WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1
        Description: WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:46:0.18
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
   public class workwithdevicesusuarioserie_usuarioserie_list_grid1 : GXProcedure
   {
      public workwithdevicesusuarioserie_usuarioserie_list_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesusuarioserie_usuarioserie_list_grid1( IGxContext context )
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
                           out GXBaseCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item> aP4_GXM2RootCol )
      {
         this.AV9UsuarioId = aP0_UsuarioId;
         this.AV15start = aP1_start;
         this.AV16count = aP2_count;
         this.AV12gxid = aP3_gxid;
         this.AV17GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM2RootCol=this.AV17GXM2RootCol;
      }

      public GXBaseCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item> executeUdp( long aP0_UsuarioId ,
                                                                                                          long aP1_start ,
                                                                                                          long aP2_count ,
                                                                                                          int aP3_gxid )
      {
         this.AV9UsuarioId = aP0_UsuarioId;
         this.AV15start = aP1_start;
         this.AV16count = aP2_count;
         this.AV12gxid = aP3_gxid;
         this.AV17GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM2RootCol=this.AV17GXM2RootCol;
         return AV17GXM2RootCol ;
      }

      public void executeSubmit( long aP0_UsuarioId ,
                                 long aP1_start ,
                                 long aP2_count ,
                                 int aP3_gxid ,
                                 out GXBaseCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item> aP4_GXM2RootCol )
      {
         workwithdevicesusuarioserie_usuarioserie_list_grid1 objworkwithdevicesusuarioserie_usuarioserie_list_grid1;
         objworkwithdevicesusuarioserie_usuarioserie_list_grid1 = new workwithdevicesusuarioserie_usuarioserie_list_grid1();
         objworkwithdevicesusuarioserie_usuarioserie_list_grid1.AV9UsuarioId = aP0_UsuarioId;
         objworkwithdevicesusuarioserie_usuarioserie_list_grid1.AV15start = aP1_start;
         objworkwithdevicesusuarioserie_usuarioserie_list_grid1.AV16count = aP2_count;
         objworkwithdevicesusuarioserie_usuarioserie_list_grid1.AV12gxid = aP3_gxid;
         objworkwithdevicesusuarioserie_usuarioserie_list_grid1.AV17GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item>( context, "Item", "") ;
         objworkwithdevicesusuarioserie_usuarioserie_list_grid1.context.SetSubmitInitialConfig(context);
         objworkwithdevicesusuarioserie_usuarioserie_list_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesusuarioserie_usuarioserie_list_grid1);
         aP4_GXM2RootCol=this.AV17GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesusuarioserie_usuarioserie_list_grid1)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV12gxid), 8, 0);
         AV5Assistido = BooleanUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Assistido"));
         AV6Favorito = BooleanUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Favorito"));
         AV21Favoritar_GXI = Gxwebsession.Get(Gxids+"gxvar_Favoritar");
         AV7Favoritar = "";
         AV22Marcarassistido_GXI = Gxwebsession.Get(Gxids+"gxvar_Marcarassistido");
         AV8MarcarAssistido = "";
         AV9UsuarioId = (long)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Usuarioid"), "."));
         GXPagingFrom2 = (int)(AV15start);
         GXPagingTo2 = (int)(AV16count);
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {AV9UsuarioId, GXPagingFrom2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A17UsuarioSerieFavorita = P00002_A17UsuarioSerieFavorita[0];
            A11UsuarioId = P00002_A11UsuarioId[0];
            A40000SerieImagem_GXI = P00002_A40000SerieImagem_GXI[0];
            A15UsuarioSerieAssistida = P00002_A15UsuarioSerieAssistida[0];
            A1SerieId = P00002_A1SerieId[0];
            A2SerieNome = P00002_A2SerieNome[0];
            A49GeneroNome = P00002_A49GeneroNome[0];
            A48GeneroId = P00002_A48GeneroId[0];
            A13UsuarioSerieId = P00002_A13UsuarioSerieId[0];
            A43SerieImagem = P00002_A43SerieImagem[0];
            A40000SerieImagem_GXI = P00002_A40000SerieImagem_GXI[0];
            A2SerieNome = P00002_A2SerieNome[0];
            A48GeneroId = P00002_A48GeneroId[0];
            A43SerieImagem = P00002_A43SerieImagem[0];
            A49GeneroNome = P00002_A49GeneroNome[0];
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item(context);
            AV17GXM2RootCol.Add(AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt, 0);
            if ( A17UsuarioSerieFavorita )
            {
               AV6Favorito = true;
               AV7Favoritar = context.GetImagePath( "36fbff47-1ab6-4c69-a869-d775c2c91b99", "", context.GetTheme( ));
               AV21Favoritar_GXI = GXDbFile.PathToUrl( context.GetImagePath( "36fbff47-1ab6-4c69-a869-d775c2c91b99", "", context.GetTheme( )));
            }
            else
            {
               AV6Favorito = false;
               AV7Favoritar = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
               AV21Favoritar_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            }
            if ( A15UsuarioSerieAssistida )
            {
               AV5Assistido = true;
               AV8MarcarAssistido = context.GetImagePath( "451cf230-8c7c-4f17-8440-ff7c487b2ad9", "", context.GetTheme( ));
               AV22Marcarassistido_GXI = GXDbFile.PathToUrl( context.GetImagePath( "451cf230-8c7c-4f17-8440-ff7c487b2ad9", "", context.GetTheme( )));
            }
            else
            {
               AV5Assistido = false;
               AV8MarcarAssistido = context.GetImagePath( "df8aee37-3ddd-479f-a9aa-1c4957c02e0a", "", context.GetTheme( ));
               AV22Marcarassistido_GXI = GXDbFile.PathToUrl( context.GetImagePath( "df8aee37-3ddd-479f-a9aa-1c4957c02e0a", "", context.GetTheme( )));
            }
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt.gxTpr_Serieid = A1SerieId;
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt.gxTpr_Serieimagem = A43SerieImagem;
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt.gxTpr_Serieimagem_gxi = A40000SerieImagem_GXI;
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt.gxTpr_Serienome = A2SerieNome;
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt.gxTpr_Generonome = A49GeneroNome;
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt.gxTpr_Generoid = A48GeneroId;
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt.gxTpr_Assistido = AV5Assistido;
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt.gxTpr_Favorito = AV6Favorito;
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt.gxTpr_Favoritar = AV7Favoritar;
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt.gxTpr_Favoritar_gxi = AV21Favoritar_GXI;
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt.gxTpr_Marcarassistido = AV8MarcarAssistido;
            AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt.gxTpr_Marcarassistido_gxi = AV22Marcarassistido_GXI;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         Gxwebsession.Set(Gxids+"gxvar_Assistido", StringUtil.BoolToStr( AV5Assistido));
         Gxwebsession.Set(Gxids+"gxvar_Favorito", StringUtil.BoolToStr( AV6Favorito));
         Gxwebsession.Set(Gxids+"gxvar_Favoritar", AV21Favoritar_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Marcarassistido", AV22Marcarassistido_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Usuarioid", StringUtil.Str( (decimal)(AV9UsuarioId), 18, 0));
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
         AV21Favoritar_GXI = "";
         AV7Favoritar = "";
         AV22Marcarassistido_GXI = "";
         AV8MarcarAssistido = "";
         scmdbuf = "";
         P00002_A17UsuarioSerieFavorita = new bool[] {false} ;
         P00002_A11UsuarioId = new long[1] ;
         P00002_A40000SerieImagem_GXI = new String[] {""} ;
         P00002_A15UsuarioSerieAssistida = new bool[] {false} ;
         P00002_A1SerieId = new long[1] ;
         P00002_A2SerieNome = new String[] {""} ;
         P00002_A49GeneroNome = new String[] {""} ;
         P00002_A48GeneroId = new long[1] ;
         P00002_A13UsuarioSerieId = new long[1] ;
         P00002_A43SerieImagem = new String[] {""} ;
         A40000SerieImagem_GXI = "";
         A2SerieNome = "";
         A49GeneroNome = "";
         A43SerieImagem = "";
         AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesusuarioserie_usuarioserie_list_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A17UsuarioSerieFavorita, P00002_A11UsuarioId, P00002_A40000SerieImagem_GXI, P00002_A15UsuarioSerieAssistida, P00002_A1SerieId, P00002_A2SerieNome, P00002_A49GeneroNome, P00002_A48GeneroId, P00002_A13UsuarioSerieId, P00002_A43SerieImagem
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV12gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV9UsuarioId ;
      private long AV15start ;
      private long AV16count ;
      private long A11UsuarioId ;
      private long A1SerieId ;
      private long A48GeneroId ;
      private long A13UsuarioSerieId ;
      private String Gxids ;
      private String scmdbuf ;
      private bool AV5Assistido ;
      private bool AV6Favorito ;
      private bool A17UsuarioSerieFavorita ;
      private bool A15UsuarioSerieAssistida ;
      private String AV21Favoritar_GXI ;
      private String AV22Marcarassistido_GXI ;
      private String A40000SerieImagem_GXI ;
      private String A2SerieNome ;
      private String A49GeneroNome ;
      private String AV7Favoritar ;
      private String AV8MarcarAssistido ;
      private String A43SerieImagem ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private bool[] P00002_A17UsuarioSerieFavorita ;
      private long[] P00002_A11UsuarioId ;
      private String[] P00002_A40000SerieImagem_GXI ;
      private bool[] P00002_A15UsuarioSerieAssistida ;
      private long[] P00002_A1SerieId ;
      private String[] P00002_A2SerieNome ;
      private String[] P00002_A49GeneroNome ;
      private long[] P00002_A48GeneroId ;
      private long[] P00002_A13UsuarioSerieId ;
      private String[] P00002_A43SerieImagem ;
      private GXBaseCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item> aP4_GXM2RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item> AV17GXM2RootCol ;
      private SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item AV18GXM1WorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt ;
   }

   public class workwithdevicesusuarioserie_usuarioserie_list_grid1__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@AV9UsuarioId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT T1.[UsuarioSerieFavorita], T1.[UsuarioId], T2.[SerieImagem_GXI], T1.[UsuarioSerieAssistida], T1.[SerieId], T2.[SerieNome], T3.[GeneroNome], T2.[GeneroId], T1.[UsuarioSerieId], T2.[SerieImagem] FROM (([UsuarioSerie] T1 WITH (NOLOCK) INNER JOIN [Serie] T2 WITH (NOLOCK) ON T2.[SerieId] = T1.[SerieId]) INNER JOIN [Genero] T3 WITH (NOLOCK) ON T3.[GeneroId] = T2.[GeneroId]) WHERE (T1.[UsuarioId] = @AV9UsuarioId) AND (T1.[UsuarioSerieFavorita] = 1) ORDER BY T1.[UsuarioId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,false,false )
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
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((bool[]) buf[3])[0] = rslt.getBool(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((long[]) buf[7])[0] = rslt.getLong(8) ;
                ((long[]) buf[8])[0] = rslt.getLong(9) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(3)) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesusuarioserie_usuarioserie_list_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesusuarioserie_usuarioserie_list_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?UsuarioId={UsuarioId}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item_RESTInterface> execute( String UsuarioId ,
                                                                                                                      String start ,
                                                                                                                      String count ,
                                                                                                                      String gxid )
    {
       GxGenericCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesusuarioserie_usuarioserie_list_grid1") )
          {
             return null ;
          }
          workwithdevicesusuarioserie_usuarioserie_list_grid1 worker = new workwithdevicesusuarioserie_usuarioserie_list_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrUsuarioId ;
          gxrUsuarioId = (long)(NumberUtil.Val( (String)(UsuarioId), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item>() ;
          worker.execute(gxrUsuarioId,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
