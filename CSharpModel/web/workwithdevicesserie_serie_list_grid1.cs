/*
               File: WorkWithDevicesSerie_Serie_List_Grid1
        Description: WorkWithDevicesSerie_Serie_List_Grid1
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:31.19
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
   public class workwithdevicesserie_serie_list_grid1 : GXProcedure
   {
      public workwithdevicesserie_serie_list_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesserie_serie_list_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_GeneroId ,
                           bool aP1_Lancamento ,
                           String aP2_SearchText ,
                           long aP3_start ,
                           long aP4_count ,
                           int aP5_gxid ,
                           out GXBaseCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item> aP6_GXM2RootCol )
      {
         this.AV13GeneroId = aP0_GeneroId;
         this.AV14Lancamento = aP1_Lancamento;
         this.AV22SearchText = aP2_SearchText;
         this.AV20start = aP3_start;
         this.AV21count = aP4_count;
         this.AV17gxid = aP5_gxid;
         this.AV23GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP6_GXM2RootCol=this.AV23GXM2RootCol;
      }

      public GXBaseCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item> executeUdp( long aP0_GeneroId ,
                                                                                            bool aP1_Lancamento ,
                                                                                            String aP2_SearchText ,
                                                                                            long aP3_start ,
                                                                                            long aP4_count ,
                                                                                            int aP5_gxid )
      {
         this.AV13GeneroId = aP0_GeneroId;
         this.AV14Lancamento = aP1_Lancamento;
         this.AV22SearchText = aP2_SearchText;
         this.AV20start = aP3_start;
         this.AV21count = aP4_count;
         this.AV17gxid = aP5_gxid;
         this.AV23GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP6_GXM2RootCol=this.AV23GXM2RootCol;
         return AV23GXM2RootCol ;
      }

      public void executeSubmit( long aP0_GeneroId ,
                                 bool aP1_Lancamento ,
                                 String aP2_SearchText ,
                                 long aP3_start ,
                                 long aP4_count ,
                                 int aP5_gxid ,
                                 out GXBaseCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item> aP6_GXM2RootCol )
      {
         workwithdevicesserie_serie_list_grid1 objworkwithdevicesserie_serie_list_grid1;
         objworkwithdevicesserie_serie_list_grid1 = new workwithdevicesserie_serie_list_grid1();
         objworkwithdevicesserie_serie_list_grid1.AV13GeneroId = aP0_GeneroId;
         objworkwithdevicesserie_serie_list_grid1.AV14Lancamento = aP1_Lancamento;
         objworkwithdevicesserie_serie_list_grid1.AV22SearchText = aP2_SearchText;
         objworkwithdevicesserie_serie_list_grid1.AV20start = aP3_start;
         objworkwithdevicesserie_serie_list_grid1.AV21count = aP4_count;
         objworkwithdevicesserie_serie_list_grid1.AV17gxid = aP5_gxid;
         objworkwithdevicesserie_serie_list_grid1.AV23GXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item>( context, "Item", "") ;
         objworkwithdevicesserie_serie_list_grid1.context.SetSubmitInitialConfig(context);
         objworkwithdevicesserie_serie_list_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesserie_serie_list_grid1);
         aP6_GXM2RootCol=this.AV23GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesserie_serie_list_grid1)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV17gxid), 8, 0);
         AV10Assistido = BooleanUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Assistido"));
         AV7Favorito = BooleanUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Favorito"));
         AV27Favoritar_GXI = Gxwebsession.Get(Gxids+"gxvar_Favoritar");
         AV5Favoritar = "";
         AV28Marcarassistido_GXI = Gxwebsession.Get(Gxids+"gxvar_Marcarassistido");
         AV11MarcarAssistido = "";
         GXPagingFrom2 = (int)(AV20start);
         GXPagingTo2 = (int)(AV21count);
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV22SearchText ,
                                              A2SerieNome ,
                                              A49GeneroNome ,
                                              AV13GeneroId ,
                                              A47SerieInativo ,
                                              A48GeneroId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                              }
         } ) ;
         lV22SearchText = StringUtil.Concat( StringUtil.RTrim( AV22SearchText), "%", "");
         lV22SearchText = StringUtil.Concat( StringUtil.RTrim( AV22SearchText), "%", "");
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {AV13GeneroId, AV13GeneroId, lV22SearchText, lV22SearchText, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A2SerieNome = P00002_A2SerieNome[0];
            A49GeneroNome = P00002_A49GeneroNome[0];
            A47SerieInativo = P00002_A47SerieInativo[0];
            A48GeneroId = P00002_A48GeneroId[0];
            A40000SerieImagem_GXI = P00002_A40000SerieImagem_GXI[0];
            A1SerieId = P00002_A1SerieId[0];
            A43SerieImagem = P00002_A43SerieImagem[0];
            A49GeneroNome = P00002_A49GeneroNome[0];
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt = new SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item(context);
            AV23GXM2RootCol.Add(AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt, 0);
            AV9SerieId = A1SerieId;
            new verificarserieusuario(context ).execute(  AV9SerieId,  "123456", out  AV7Favorito, out  AV10Assistido) ;
            if ( AV7Favorito )
            {
               AV5Favoritar = context.GetImagePath( "36fbff47-1ab6-4c69-a869-d775c2c91b99", "", context.GetTheme( ));
               AV27Favoritar_GXI = GXDbFile.PathToUrl( context.GetImagePath( "36fbff47-1ab6-4c69-a869-d775c2c91b99", "", context.GetTheme( )));
            }
            else
            {
               AV5Favoritar = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
               AV27Favoritar_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            }
            if ( AV10Assistido )
            {
               AV11MarcarAssistido = context.GetImagePath( "451cf230-8c7c-4f17-8440-ff7c487b2ad9", "", context.GetTheme( ));
               AV28Marcarassistido_GXI = GXDbFile.PathToUrl( context.GetImagePath( "451cf230-8c7c-4f17-8440-ff7c487b2ad9", "", context.GetTheme( )));
            }
            else
            {
               AV11MarcarAssistido = context.GetImagePath( "df8aee37-3ddd-479f-a9aa-1c4957c02e0a", "", context.GetTheme( ));
               AV28Marcarassistido_GXI = GXDbFile.PathToUrl( context.GetImagePath( "df8aee37-3ddd-479f-a9aa-1c4957c02e0a", "", context.GetTheme( )));
            }
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt.gxTpr_Serieid = A1SerieId;
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt.gxTpr_Serieimagem = A43SerieImagem;
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt.gxTpr_Serieimagem_gxi = A40000SerieImagem_GXI;
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt.gxTpr_Serienome = A2SerieNome;
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt.gxTpr_Generonome = A49GeneroNome;
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt.gxTpr_Generoid = A48GeneroId;
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt.gxTpr_Assistido = AV10Assistido;
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt.gxTpr_Favorito = AV7Favorito;
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt.gxTpr_Favoritar = AV5Favoritar;
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt.gxTpr_Favoritar_gxi = AV27Favoritar_GXI;
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt.gxTpr_Marcarassistido = AV11MarcarAssistido;
            AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt.gxTpr_Marcarassistido_gxi = AV28Marcarassistido_GXI;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         Gxwebsession.Set(Gxids+"gxvar_Assistido", StringUtil.BoolToStr( AV10Assistido));
         Gxwebsession.Set(Gxids+"gxvar_Favorito", StringUtil.BoolToStr( AV7Favorito));
         Gxwebsession.Set(Gxids+"gxvar_Favoritar", AV27Favoritar_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Marcarassistido", AV28Marcarassistido_GXI);
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
         AV27Favoritar_GXI = "";
         AV5Favoritar = "";
         AV28Marcarassistido_GXI = "";
         AV11MarcarAssistido = "";
         scmdbuf = "";
         lV22SearchText = "";
         A2SerieNome = "";
         A49GeneroNome = "";
         P00002_A2SerieNome = new String[] {""} ;
         P00002_A49GeneroNome = new String[] {""} ;
         P00002_A47SerieInativo = new bool[] {false} ;
         P00002_A48GeneroId = new long[1] ;
         P00002_A40000SerieImagem_GXI = new String[] {""} ;
         P00002_A1SerieId = new long[1] ;
         P00002_A43SerieImagem = new String[] {""} ;
         A40000SerieImagem_GXI = "";
         A43SerieImagem = "";
         AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt = new SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesserie_serie_list_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A2SerieNome, P00002_A49GeneroNome, P00002_A47SerieInativo, P00002_A48GeneroId, P00002_A40000SerieImagem_GXI, P00002_A1SerieId, P00002_A43SerieImagem
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV17gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV13GeneroId ;
      private long AV20start ;
      private long AV21count ;
      private long A48GeneroId ;
      private long A1SerieId ;
      private long AV9SerieId ;
      private String Gxids ;
      private String scmdbuf ;
      private bool AV14Lancamento ;
      private bool AV10Assistido ;
      private bool AV7Favorito ;
      private bool A47SerieInativo ;
      private String AV22SearchText ;
      private String AV27Favoritar_GXI ;
      private String AV28Marcarassistido_GXI ;
      private String lV22SearchText ;
      private String A2SerieNome ;
      private String A49GeneroNome ;
      private String A40000SerieImagem_GXI ;
      private String AV5Favoritar ;
      private String AV11MarcarAssistido ;
      private String A43SerieImagem ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00002_A2SerieNome ;
      private String[] P00002_A49GeneroNome ;
      private bool[] P00002_A47SerieInativo ;
      private long[] P00002_A48GeneroId ;
      private String[] P00002_A40000SerieImagem_GXI ;
      private long[] P00002_A1SerieId ;
      private String[] P00002_A43SerieImagem ;
      private GXBaseCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item> aP6_GXM2RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item> AV23GXM2RootCol ;
      private SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item AV24GXM1WorkWithDevicesSerie_Serie_List_Grid1Sdt ;
   }

   public class workwithdevicesserie_serie_list_grid1__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00002( IGxContext context ,
                                             String AV22SearchText ,
                                             String A2SerieNome ,
                                             String A49GeneroNome ,
                                             long AV13GeneroId ,
                                             bool A47SerieInativo ,
                                             long A48GeneroId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [7] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[SerieNome], T2.[GeneroNome], T1.[SerieInativo], T1.[GeneroId], T1.[SerieImagem_GXI], T1.[SerieId], T1.[SerieImagem]";
         sFromString = " FROM ([Serie] T1 WITH (NOLOCK) INNER JOIN [Genero] T2 WITH (NOLOCK) ON T2.[GeneroId] = T1.[GeneroId])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[GeneroId] = @AV13GeneroId)";
         sWhereString = sWhereString + " and (( @AV13GeneroId <> 0))";
         sWhereString = sWhereString + " and (Not T1.[SerieInativo] = 1)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV22SearchText)) )
         {
            sWhereString = sWhereString + " and (UPPER(T1.[SerieNome]) like '%' + UPPER(@lV22SearchText) or UPPER(T2.[GeneroNome]) like '%' + UPPER(@lV22SearchText))";
         }
         else
         {
            GXv_int1[2] = 1;
            GXv_int1[3] = 1;
         }
         sOrderString = sOrderString + " ORDER BY T1.[GeneroId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P00002(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (long)dynConstraints[3] , (bool)dynConstraints[4] , (long)dynConstraints[5] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

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
          new Object[] {"@AV13GeneroId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV13GeneroId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV22SearchText",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@lV22SearchText",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.getBool(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((String[]) buf[4])[0] = rslt.getMultimediaUri(5) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(5)) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesserie_serie_list_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesserie_serie_list_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?GeneroId={GeneroId}&Lancamento={Lancamento}&SearchText={SearchText}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_RESTInterface> execute( String GeneroId ,
                                                                                                        bool Lancamento ,
                                                                                                        String SearchText ,
                                                                                                        String start ,
                                                                                                        String count ,
                                                                                                        String gxid )
    {
       GxGenericCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesserie_serie_list_grid1") )
          {
             return null ;
          }
          workwithdevicesserie_serie_list_grid1 worker = new workwithdevicesserie_serie_list_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrGeneroId ;
          gxrGeneroId = (long)(NumberUtil.Val( (String)(GeneroId), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item>() ;
          worker.execute(gxrGeneroId,Lancamento,SearchText,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
