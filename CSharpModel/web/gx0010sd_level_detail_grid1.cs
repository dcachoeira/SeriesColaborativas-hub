/*
               File: Gx0010sd_Level_Detail_Grid1
        Description: Gx0010sd_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:50.62
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
   public class gx0010sd_level_detail_grid1 : GXProcedure
   {
      public gx0010sd_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public gx0010sd_level_detail_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_pSerieId ,
                           String aP1_SearchText ,
                           long aP2_cSerieId ,
                           short aP3_cSerieQuantidadeTemporadas ,
                           bool aP4_cSerieInativo ,
                           long aP5_cGeneroId ,
                           DateTime aP6_cSerieDataHoraCadastro ,
                           long aP7_start ,
                           long aP8_count ,
                           int aP9_gxid ,
                           out GXBaseCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item> aP10_GXM2RootCol )
      {
         this.AV5pSerieId = aP0_pSerieId;
         this.AV19SearchText = aP1_SearchText;
         this.AV11cSerieId = aP2_cSerieId;
         this.AV12cSerieQuantidadeTemporadas = aP3_cSerieQuantidadeTemporadas;
         this.AV13cSerieInativo = aP4_cSerieInativo;
         this.AV14cGeneroId = aP5_cGeneroId;
         this.AV15cSerieDataHoraCadastro = aP6_cSerieDataHoraCadastro;
         this.AV17start = aP7_start;
         this.AV18count = aP8_count;
         this.AV16gxid = aP9_gxid;
         this.AV20GXM2RootCol = new GXBaseCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP10_GXM2RootCol=this.AV20GXM2RootCol;
      }

      public GXBaseCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item> executeUdp( long aP0_pSerieId ,
                                                                                  String aP1_SearchText ,
                                                                                  long aP2_cSerieId ,
                                                                                  short aP3_cSerieQuantidadeTemporadas ,
                                                                                  bool aP4_cSerieInativo ,
                                                                                  long aP5_cGeneroId ,
                                                                                  DateTime aP6_cSerieDataHoraCadastro ,
                                                                                  long aP7_start ,
                                                                                  long aP8_count ,
                                                                                  int aP9_gxid )
      {
         this.AV5pSerieId = aP0_pSerieId;
         this.AV19SearchText = aP1_SearchText;
         this.AV11cSerieId = aP2_cSerieId;
         this.AV12cSerieQuantidadeTemporadas = aP3_cSerieQuantidadeTemporadas;
         this.AV13cSerieInativo = aP4_cSerieInativo;
         this.AV14cGeneroId = aP5_cGeneroId;
         this.AV15cSerieDataHoraCadastro = aP6_cSerieDataHoraCadastro;
         this.AV17start = aP7_start;
         this.AV18count = aP8_count;
         this.AV16gxid = aP9_gxid;
         this.AV20GXM2RootCol = new GXBaseCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP10_GXM2RootCol=this.AV20GXM2RootCol;
         return AV20GXM2RootCol ;
      }

      public void executeSubmit( long aP0_pSerieId ,
                                 String aP1_SearchText ,
                                 long aP2_cSerieId ,
                                 short aP3_cSerieQuantidadeTemporadas ,
                                 bool aP4_cSerieInativo ,
                                 long aP5_cGeneroId ,
                                 DateTime aP6_cSerieDataHoraCadastro ,
                                 long aP7_start ,
                                 long aP8_count ,
                                 int aP9_gxid ,
                                 out GXBaseCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item> aP10_GXM2RootCol )
      {
         gx0010sd_level_detail_grid1 objgx0010sd_level_detail_grid1;
         objgx0010sd_level_detail_grid1 = new gx0010sd_level_detail_grid1();
         objgx0010sd_level_detail_grid1.AV5pSerieId = aP0_pSerieId;
         objgx0010sd_level_detail_grid1.AV19SearchText = aP1_SearchText;
         objgx0010sd_level_detail_grid1.AV11cSerieId = aP2_cSerieId;
         objgx0010sd_level_detail_grid1.AV12cSerieQuantidadeTemporadas = aP3_cSerieQuantidadeTemporadas;
         objgx0010sd_level_detail_grid1.AV13cSerieInativo = aP4_cSerieInativo;
         objgx0010sd_level_detail_grid1.AV14cGeneroId = aP5_cGeneroId;
         objgx0010sd_level_detail_grid1.AV15cSerieDataHoraCadastro = aP6_cSerieDataHoraCadastro;
         objgx0010sd_level_detail_grid1.AV17start = aP7_start;
         objgx0010sd_level_detail_grid1.AV18count = aP8_count;
         objgx0010sd_level_detail_grid1.AV16gxid = aP9_gxid;
         objgx0010sd_level_detail_grid1.AV20GXM2RootCol = new GXBaseCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objgx0010sd_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objgx0010sd_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgx0010sd_level_detail_grid1);
         aP10_GXM2RootCol=this.AV20GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gx0010sd_level_detail_grid1)stateInfo).executePrivate();
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
         GXPagingFrom2 = (int)(AV17start);
         GXPagingTo2 = (int)(AV18count);
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV19SearchText ,
                                              AV11cSerieId ,
                                              AV12cSerieQuantidadeTemporadas ,
                                              AV13cSerieInativo ,
                                              AV14cGeneroId ,
                                              AV15cSerieDataHoraCadastro ,
                                              A2SerieNome ,
                                              A1SerieId ,
                                              A3SerieQuantidadeTemporadas ,
                                              A47SerieInativo ,
                                              A48GeneroId ,
                                              A60SerieDataHoraCadastro } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN,
                                              TypeConstants.LONG, TypeConstants.DATE
                                              }
         } ) ;
         lV19SearchText = StringUtil.Concat( StringUtil.RTrim( AV19SearchText), "%", "");
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {lV19SearchText, AV11cSerieId, AV12cSerieQuantidadeTemporadas, AV13cSerieInativo, AV14cGeneroId, AV15cSerieDataHoraCadastro, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A60SerieDataHoraCadastro = P00002_A60SerieDataHoraCadastro[0];
            A48GeneroId = P00002_A48GeneroId[0];
            A47SerieInativo = P00002_A47SerieInativo[0];
            A3SerieQuantidadeTemporadas = P00002_A3SerieQuantidadeTemporadas[0];
            A1SerieId = P00002_A1SerieId[0];
            A2SerieNome = P00002_A2SerieNome[0];
            A40000SerieImagem_GXI = P00002_A40000SerieImagem_GXI[0];
            A43SerieImagem = P00002_A43SerieImagem[0];
            AV21GXM1Gx0010sd_Level_Detail_Grid1Sdt = new SdtGx0010sd_Level_Detail_Grid1Sdt_Item(context);
            AV20GXM2RootCol.Add(AV21GXM1Gx0010sd_Level_Detail_Grid1Sdt, 0);
            AV21GXM1Gx0010sd_Level_Detail_Grid1Sdt.gxTpr_Serieid = A1SerieId;
            AV21GXM1Gx0010sd_Level_Detail_Grid1Sdt.gxTpr_Serienome = A2SerieNome;
            AV21GXM1Gx0010sd_Level_Detail_Grid1Sdt.gxTpr_Serieimagem = A43SerieImagem;
            AV21GXM1Gx0010sd_Level_Detail_Grid1Sdt.gxTpr_Serieimagem_gxi = A40000SerieImagem_GXI;
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
         lV19SearchText = "";
         A2SerieNome = "";
         A60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         P00002_A60SerieDataHoraCadastro = new DateTime[] {DateTime.MinValue} ;
         P00002_A48GeneroId = new long[1] ;
         P00002_A47SerieInativo = new bool[] {false} ;
         P00002_A3SerieQuantidadeTemporadas = new short[1] ;
         P00002_A1SerieId = new long[1] ;
         P00002_A2SerieNome = new String[] {""} ;
         P00002_A40000SerieImagem_GXI = new String[] {""} ;
         P00002_A43SerieImagem = new String[] {""} ;
         A40000SerieImagem_GXI = "";
         A43SerieImagem = "";
         AV21GXM1Gx0010sd_Level_Detail_Grid1Sdt = new SdtGx0010sd_Level_Detail_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0010sd_level_detail_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A60SerieDataHoraCadastro, P00002_A48GeneroId, P00002_A47SerieInativo, P00002_A3SerieQuantidadeTemporadas, P00002_A1SerieId, P00002_A2SerieNome, P00002_A40000SerieImagem_GXI, P00002_A43SerieImagem
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV12cSerieQuantidadeTemporadas ;
      private short A3SerieQuantidadeTemporadas ;
      private int AV16gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV5pSerieId ;
      private long AV11cSerieId ;
      private long AV14cGeneroId ;
      private long AV17start ;
      private long AV18count ;
      private long A1SerieId ;
      private long A48GeneroId ;
      private String scmdbuf ;
      private DateTime AV15cSerieDataHoraCadastro ;
      private DateTime A60SerieDataHoraCadastro ;
      private bool AV13cSerieInativo ;
      private bool A47SerieInativo ;
      private String AV19SearchText ;
      private String lV19SearchText ;
      private String A2SerieNome ;
      private String A40000SerieImagem_GXI ;
      private String A43SerieImagem ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] P00002_A60SerieDataHoraCadastro ;
      private long[] P00002_A48GeneroId ;
      private bool[] P00002_A47SerieInativo ;
      private short[] P00002_A3SerieQuantidadeTemporadas ;
      private long[] P00002_A1SerieId ;
      private String[] P00002_A2SerieNome ;
      private String[] P00002_A40000SerieImagem_GXI ;
      private String[] P00002_A43SerieImagem ;
      private GXBaseCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item> aP10_GXM2RootCol ;
      private GXBaseCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item> AV20GXM2RootCol ;
      private SdtGx0010sd_Level_Detail_Grid1Sdt_Item AV21GXM1Gx0010sd_Level_Detail_Grid1Sdt ;
   }

   public class gx0010sd_level_detail_grid1__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00002( IGxContext context ,
                                             String AV19SearchText ,
                                             long AV11cSerieId ,
                                             short AV12cSerieQuantidadeTemporadas ,
                                             bool AV13cSerieInativo ,
                                             long AV14cGeneroId ,
                                             DateTime AV15cSerieDataHoraCadastro ,
                                             String A2SerieNome ,
                                             long A1SerieId ,
                                             short A3SerieQuantidadeTemporadas ,
                                             bool A47SerieInativo ,
                                             long A48GeneroId ,
                                             DateTime A60SerieDataHoraCadastro )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [9] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [SerieDataHoraCadastro], [GeneroId], [SerieInativo], [SerieQuantidadeTemporadas], [SerieId], [SerieNome], [SerieImagem_GXI], [SerieImagem]";
         sFromString = " FROM [Serie] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19SearchText)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (UPPER([SerieNome]) like '%' + UPPER(@lV19SearchText))";
            }
            else
            {
               sWhereString = sWhereString + " (UPPER([SerieNome]) like '%' + UPPER(@lV19SearchText))";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! (0==AV11cSerieId) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SerieId] = @AV11cSerieId)";
            }
            else
            {
               sWhereString = sWhereString + " ([SerieId] = @AV11cSerieId)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV12cSerieQuantidadeTemporadas) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SerieQuantidadeTemporadas] >= @AV12cSerieQuantidadeTemporadas)";
            }
            else
            {
               sWhereString = sWhereString + " ([SerieQuantidadeTemporadas] >= @AV12cSerieQuantidadeTemporadas)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (false==AV13cSerieInativo) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SerieInativo] = @AV13cSerieInativo)";
            }
            else
            {
               sWhereString = sWhereString + " ([SerieInativo] = @AV13cSerieInativo)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV14cGeneroId) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([GeneroId] = @AV14cGeneroId)";
            }
            else
            {
               sWhereString = sWhereString + " ([GeneroId] = @AV14cGeneroId)";
            }
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV15cSerieDataHoraCadastro) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SerieDataHoraCadastro] >= @AV15cSerieDataHoraCadastro)";
            }
            else
            {
               sWhereString = sWhereString + " ([SerieDataHoraCadastro] >= @AV15cSerieDataHoraCadastro)";
            }
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         sOrderString = sOrderString + " ORDER BY [SerieId]";
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
                     return conditional_P00002(context, (String)dynConstraints[0] , (long)dynConstraints[1] , (short)dynConstraints[2] , (bool)dynConstraints[3] , (long)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (long)dynConstraints[7] , (short)dynConstraints[8] , (bool)dynConstraints[9] , (long)dynConstraints[10] , (DateTime)dynConstraints[11] );
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
          new Object[] {"@lV19SearchText",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@AV11cSerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV12cSerieQuantidadeTemporadas",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13cSerieInativo",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV14cGeneroId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV15cSerieDataHoraCadastro",SqlDbType.DateTime,8,5} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,false,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((bool[]) buf[2])[0] = rslt.getBool(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
                ((String[]) buf[7])[0] = rslt.getMultimediaFile(8, rslt.getVarchar(7)) ;
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
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.gx0010sd_level_detail_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class gx0010sd_level_detail_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?pSerieId={pSerieId}&SearchText={SearchText}&cSerieId={cSerieId}&cSerieQuantidadeTemporadas={cSerieQuantidadeTemporadas}&cSerieInativo={cSerieInativo}&cGeneroId={cGeneroId}&cSerieDataHoraCadastro={cSerieDataHoraCadastro}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( String pSerieId ,
                                                                                              String SearchText ,
                                                                                              String cSerieId ,
                                                                                              short cSerieQuantidadeTemporadas ,
                                                                                              bool cSerieInativo ,
                                                                                              String cGeneroId ,
                                                                                              String cSerieDataHoraCadastro ,
                                                                                              String start ,
                                                                                              String count ,
                                                                                              String gxid )
    {
       GxGenericCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("gx0010sd_level_detail_grid1") )
          {
             return null ;
          }
          gx0010sd_level_detail_grid1 worker = new gx0010sd_level_detail_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrpSerieId ;
          gxrpSerieId = (long)(NumberUtil.Val( (String)(pSerieId), "."));
          long gxrcSerieId ;
          gxrcSerieId = (long)(NumberUtil.Val( (String)(cSerieId), "."));
          long gxrcGeneroId ;
          gxrcGeneroId = (long)(NumberUtil.Val( (String)(cGeneroId), "."));
          DateTime gxrcSerieDataHoraCadastro ;
          gxrcSerieDataHoraCadastro = DateTimeUtil.CToT2( (String)(cSerieDataHoraCadastro));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item>() ;
          worker.execute(gxrpSerieId,SearchText,gxrcSerieId,cSerieQuantidadeTemporadas,cSerieInativo,gxrcGeneroId,gxrcSerieDataHoraCadastro,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtGx0010sd_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
