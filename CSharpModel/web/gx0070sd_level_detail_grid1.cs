/*
               File: Gx0070sd_Level_Detail_Grid1
        Description: Gx0070sd_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:58.12
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
   public class gx0070sd_level_detail_grid1 : GXProcedure
   {
      public gx0070sd_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public gx0070sd_level_detail_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_pConquistaId ,
                           String aP1_SearchText ,
                           long aP2_cConquistaId ,
                           short aP3_cConquistaPontos ,
                           short aP4_cConquistaTipo ,
                           short aP5_cConquistaQuantidadeNecessaria ,
                           bool aP6_cConquistaInativo ,
                           long aP7_start ,
                           long aP8_count ,
                           int aP9_gxid ,
                           out GXBaseCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item> aP10_GXM2RootCol )
      {
         this.AV5pConquistaId = aP0_pConquistaId;
         this.AV19SearchText = aP1_SearchText;
         this.AV11cConquistaId = aP2_cConquistaId;
         this.AV12cConquistaPontos = aP3_cConquistaPontos;
         this.AV13cConquistaTipo = aP4_cConquistaTipo;
         this.AV14cConquistaQuantidadeNecessaria = aP5_cConquistaQuantidadeNecessaria;
         this.AV15cConquistaInativo = aP6_cConquistaInativo;
         this.AV17start = aP7_start;
         this.AV18count = aP8_count;
         this.AV16gxid = aP9_gxid;
         this.AV20GXM2RootCol = new GXBaseCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP10_GXM2RootCol=this.AV20GXM2RootCol;
      }

      public GXBaseCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item> executeUdp( long aP0_pConquistaId ,
                                                                                  String aP1_SearchText ,
                                                                                  long aP2_cConquistaId ,
                                                                                  short aP3_cConquistaPontos ,
                                                                                  short aP4_cConquistaTipo ,
                                                                                  short aP5_cConquistaQuantidadeNecessaria ,
                                                                                  bool aP6_cConquistaInativo ,
                                                                                  long aP7_start ,
                                                                                  long aP8_count ,
                                                                                  int aP9_gxid )
      {
         this.AV5pConquistaId = aP0_pConquistaId;
         this.AV19SearchText = aP1_SearchText;
         this.AV11cConquistaId = aP2_cConquistaId;
         this.AV12cConquistaPontos = aP3_cConquistaPontos;
         this.AV13cConquistaTipo = aP4_cConquistaTipo;
         this.AV14cConquistaQuantidadeNecessaria = aP5_cConquistaQuantidadeNecessaria;
         this.AV15cConquistaInativo = aP6_cConquistaInativo;
         this.AV17start = aP7_start;
         this.AV18count = aP8_count;
         this.AV16gxid = aP9_gxid;
         this.AV20GXM2RootCol = new GXBaseCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP10_GXM2RootCol=this.AV20GXM2RootCol;
         return AV20GXM2RootCol ;
      }

      public void executeSubmit( long aP0_pConquistaId ,
                                 String aP1_SearchText ,
                                 long aP2_cConquistaId ,
                                 short aP3_cConquistaPontos ,
                                 short aP4_cConquistaTipo ,
                                 short aP5_cConquistaQuantidadeNecessaria ,
                                 bool aP6_cConquistaInativo ,
                                 long aP7_start ,
                                 long aP8_count ,
                                 int aP9_gxid ,
                                 out GXBaseCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item> aP10_GXM2RootCol )
      {
         gx0070sd_level_detail_grid1 objgx0070sd_level_detail_grid1;
         objgx0070sd_level_detail_grid1 = new gx0070sd_level_detail_grid1();
         objgx0070sd_level_detail_grid1.AV5pConquistaId = aP0_pConquistaId;
         objgx0070sd_level_detail_grid1.AV19SearchText = aP1_SearchText;
         objgx0070sd_level_detail_grid1.AV11cConquistaId = aP2_cConquistaId;
         objgx0070sd_level_detail_grid1.AV12cConquistaPontos = aP3_cConquistaPontos;
         objgx0070sd_level_detail_grid1.AV13cConquistaTipo = aP4_cConquistaTipo;
         objgx0070sd_level_detail_grid1.AV14cConquistaQuantidadeNecessaria = aP5_cConquistaQuantidadeNecessaria;
         objgx0070sd_level_detail_grid1.AV15cConquistaInativo = aP6_cConquistaInativo;
         objgx0070sd_level_detail_grid1.AV17start = aP7_start;
         objgx0070sd_level_detail_grid1.AV18count = aP8_count;
         objgx0070sd_level_detail_grid1.AV16gxid = aP9_gxid;
         objgx0070sd_level_detail_grid1.AV20GXM2RootCol = new GXBaseCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objgx0070sd_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objgx0070sd_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgx0070sd_level_detail_grid1);
         aP10_GXM2RootCol=this.AV20GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gx0070sd_level_detail_grid1)stateInfo).executePrivate();
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
                                              AV11cConquistaId ,
                                              AV12cConquistaPontos ,
                                              AV13cConquistaTipo ,
                                              AV14cConquistaQuantidadeNecessaria ,
                                              AV15cConquistaInativo ,
                                              A29ConquistaNome ,
                                              A27ConquistaId ,
                                              A28ConquistaPontos ,
                                              A44ConquistaTipo ,
                                              A45ConquistaQuantidadeNecessaria ,
                                              A46ConquistaInativo } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV19SearchText = StringUtil.Concat( StringUtil.RTrim( AV19SearchText), "%", "");
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {lV19SearchText, AV11cConquistaId, AV12cConquistaPontos, AV13cConquistaTipo, AV14cConquistaQuantidadeNecessaria, AV15cConquistaInativo, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A46ConquistaInativo = P00002_A46ConquistaInativo[0];
            A45ConquistaQuantidadeNecessaria = P00002_A45ConquistaQuantidadeNecessaria[0];
            A44ConquistaTipo = P00002_A44ConquistaTipo[0];
            A28ConquistaPontos = P00002_A28ConquistaPontos[0];
            A27ConquistaId = P00002_A27ConquistaId[0];
            A29ConquistaNome = P00002_A29ConquistaNome[0];
            AV21GXM1Gx0070sd_Level_Detail_Grid1Sdt = new SdtGx0070sd_Level_Detail_Grid1Sdt_Item(context);
            AV20GXM2RootCol.Add(AV21GXM1Gx0070sd_Level_Detail_Grid1Sdt, 0);
            AV21GXM1Gx0070sd_Level_Detail_Grid1Sdt.gxTpr_Conquistaid = A27ConquistaId;
            AV21GXM1Gx0070sd_Level_Detail_Grid1Sdt.gxTpr_Conquistapontos = A28ConquistaPontos;
            AV21GXM1Gx0070sd_Level_Detail_Grid1Sdt.gxTpr_Conquistanome = A29ConquistaNome;
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
         A29ConquistaNome = "";
         P00002_A46ConquistaInativo = new bool[] {false} ;
         P00002_A45ConquistaQuantidadeNecessaria = new short[1] ;
         P00002_A44ConquistaTipo = new short[1] ;
         P00002_A28ConquistaPontos = new short[1] ;
         P00002_A27ConquistaId = new long[1] ;
         P00002_A29ConquistaNome = new String[] {""} ;
         AV21GXM1Gx0070sd_Level_Detail_Grid1Sdt = new SdtGx0070sd_Level_Detail_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0070sd_level_detail_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A46ConquistaInativo, P00002_A45ConquistaQuantidadeNecessaria, P00002_A44ConquistaTipo, P00002_A28ConquistaPontos, P00002_A27ConquistaId, P00002_A29ConquistaNome
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV12cConquistaPontos ;
      private short AV13cConquistaTipo ;
      private short AV14cConquistaQuantidadeNecessaria ;
      private short A28ConquistaPontos ;
      private short A44ConquistaTipo ;
      private short A45ConquistaQuantidadeNecessaria ;
      private int AV16gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV5pConquistaId ;
      private long AV11cConquistaId ;
      private long AV17start ;
      private long AV18count ;
      private long A27ConquistaId ;
      private String scmdbuf ;
      private bool AV15cConquistaInativo ;
      private bool A46ConquistaInativo ;
      private String AV19SearchText ;
      private String lV19SearchText ;
      private String A29ConquistaNome ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private bool[] P00002_A46ConquistaInativo ;
      private short[] P00002_A45ConquistaQuantidadeNecessaria ;
      private short[] P00002_A44ConquistaTipo ;
      private short[] P00002_A28ConquistaPontos ;
      private long[] P00002_A27ConquistaId ;
      private String[] P00002_A29ConquistaNome ;
      private GXBaseCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item> aP10_GXM2RootCol ;
      private GXBaseCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item> AV20GXM2RootCol ;
      private SdtGx0070sd_Level_Detail_Grid1Sdt_Item AV21GXM1Gx0070sd_Level_Detail_Grid1Sdt ;
   }

   public class gx0070sd_level_detail_grid1__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00002( IGxContext context ,
                                             String AV19SearchText ,
                                             long AV11cConquistaId ,
                                             short AV12cConquistaPontos ,
                                             short AV13cConquistaTipo ,
                                             short AV14cConquistaQuantidadeNecessaria ,
                                             bool AV15cConquistaInativo ,
                                             String A29ConquistaNome ,
                                             long A27ConquistaId ,
                                             short A28ConquistaPontos ,
                                             short A44ConquistaTipo ,
                                             short A45ConquistaQuantidadeNecessaria ,
                                             bool A46ConquistaInativo )
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
         sSelectString = " [ConquistaInativo], [ConquistaQuantidadeNecessaria], [ConquistaTipo], [ConquistaPontos], [ConquistaId], [ConquistaNome]";
         sFromString = " FROM [Conquista] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19SearchText)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (UPPER([ConquistaNome]) like '%' + UPPER(@lV19SearchText))";
            }
            else
            {
               sWhereString = sWhereString + " (UPPER([ConquistaNome]) like '%' + UPPER(@lV19SearchText))";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! (0==AV11cConquistaId) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaId] = @AV11cConquistaId)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaId] = @AV11cConquistaId)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV12cConquistaPontos) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaPontos] >= @AV12cConquistaPontos)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaPontos] >= @AV12cConquistaPontos)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV13cConquistaTipo) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaTipo] >= @AV13cConquistaTipo)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaTipo] >= @AV13cConquistaTipo)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV14cConquistaQuantidadeNecessaria) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaQuantidadeNecessaria] >= @AV14cConquistaQuantidadeNecessaria)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaQuantidadeNecessaria] >= @AV14cConquistaQuantidadeNecessaria)";
            }
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (false==AV15cConquistaInativo) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaInativo] = @AV15cConquistaInativo)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaInativo] = @AV15cConquistaInativo)";
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
         sOrderString = sOrderString + " ORDER BY [ConquistaId]";
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
                     return conditional_P00002(context, (String)dynConstraints[0] , (long)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (bool)dynConstraints[5] , (String)dynConstraints[6] , (long)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (bool)dynConstraints[11] );
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
          new Object[] {"@AV11cConquistaId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV12cConquistaPontos",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13cConquistaTipo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14cConquistaQuantidadeNecessaria",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15cConquistaInativo",SqlDbType.Bit,4,0} ,
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
                ((bool[]) buf[0])[0] = rslt.getBool(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[14]);
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

 [ServiceContract(Namespace = "GeneXus.Programs.gx0070sd_level_detail_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class gx0070sd_level_detail_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?pConquistaId={pConquistaId}&SearchText={SearchText}&cConquistaId={cConquistaId}&cConquistaPontos={cConquistaPontos}&cConquistaTipo={cConquistaTipo}&cConquistaQuantidadeNecessaria={cConquistaQuantidadeNecessaria}&cConquistaInativo={cConquistaInativo}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( String pConquistaId ,
                                                                                              String SearchText ,
                                                                                              String cConquistaId ,
                                                                                              short cConquistaPontos ,
                                                                                              short cConquistaTipo ,
                                                                                              short cConquistaQuantidadeNecessaria ,
                                                                                              bool cConquistaInativo ,
                                                                                              String start ,
                                                                                              String count ,
                                                                                              String gxid )
    {
       GxGenericCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("gx0070sd_level_detail_grid1") )
          {
             return null ;
          }
          gx0070sd_level_detail_grid1 worker = new gx0070sd_level_detail_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrpConquistaId ;
          gxrpConquistaId = (long)(NumberUtil.Val( (String)(pConquistaId), "."));
          long gxrcConquistaId ;
          gxrcConquistaId = (long)(NumberUtil.Val( (String)(cConquistaId), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item>() ;
          worker.execute(gxrpConquistaId,SearchText,gxrcConquistaId,cConquistaPontos,cConquistaTipo,cConquistaQuantidadeNecessaria,cConquistaInativo,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtGx0070sd_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
