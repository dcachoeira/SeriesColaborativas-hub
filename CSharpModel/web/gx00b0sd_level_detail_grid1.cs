/*
               File: Gx00B0sd_Level_Detail_Grid1
        Description: Gx00B0sd_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:27.60
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
   public class gx00b0sd_level_detail_grid1 : GXProcedure
   {
      public gx00b0sd_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public gx00b0sd_level_detail_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_pGeneroId ,
                           String aP1_SearchText ,
                           long aP2_cGeneroId ,
                           bool aP3_cGeneroInativo ,
                           long aP4_start ,
                           long aP5_count ,
                           int aP6_gxid ,
                           out GXBaseCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item> aP7_GXM2RootCol )
      {
         this.AV5pGeneroId = aP0_pGeneroId;
         this.AV16SearchText = aP1_SearchText;
         this.AV11cGeneroId = aP2_cGeneroId;
         this.AV12cGeneroInativo = aP3_cGeneroInativo;
         this.AV14start = aP4_start;
         this.AV15count = aP5_count;
         this.AV13gxid = aP6_gxid;
         this.AV17GXM2RootCol = new GXBaseCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP7_GXM2RootCol=this.AV17GXM2RootCol;
      }

      public GXBaseCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item> executeUdp( long aP0_pGeneroId ,
                                                                                  String aP1_SearchText ,
                                                                                  long aP2_cGeneroId ,
                                                                                  bool aP3_cGeneroInativo ,
                                                                                  long aP4_start ,
                                                                                  long aP5_count ,
                                                                                  int aP6_gxid )
      {
         this.AV5pGeneroId = aP0_pGeneroId;
         this.AV16SearchText = aP1_SearchText;
         this.AV11cGeneroId = aP2_cGeneroId;
         this.AV12cGeneroInativo = aP3_cGeneroInativo;
         this.AV14start = aP4_start;
         this.AV15count = aP5_count;
         this.AV13gxid = aP6_gxid;
         this.AV17GXM2RootCol = new GXBaseCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP7_GXM2RootCol=this.AV17GXM2RootCol;
         return AV17GXM2RootCol ;
      }

      public void executeSubmit( long aP0_pGeneroId ,
                                 String aP1_SearchText ,
                                 long aP2_cGeneroId ,
                                 bool aP3_cGeneroInativo ,
                                 long aP4_start ,
                                 long aP5_count ,
                                 int aP6_gxid ,
                                 out GXBaseCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item> aP7_GXM2RootCol )
      {
         gx00b0sd_level_detail_grid1 objgx00b0sd_level_detail_grid1;
         objgx00b0sd_level_detail_grid1 = new gx00b0sd_level_detail_grid1();
         objgx00b0sd_level_detail_grid1.AV5pGeneroId = aP0_pGeneroId;
         objgx00b0sd_level_detail_grid1.AV16SearchText = aP1_SearchText;
         objgx00b0sd_level_detail_grid1.AV11cGeneroId = aP2_cGeneroId;
         objgx00b0sd_level_detail_grid1.AV12cGeneroInativo = aP3_cGeneroInativo;
         objgx00b0sd_level_detail_grid1.AV14start = aP4_start;
         objgx00b0sd_level_detail_grid1.AV15count = aP5_count;
         objgx00b0sd_level_detail_grid1.AV13gxid = aP6_gxid;
         objgx00b0sd_level_detail_grid1.AV17GXM2RootCol = new GXBaseCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objgx00b0sd_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objgx00b0sd_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgx00b0sd_level_detail_grid1);
         aP7_GXM2RootCol=this.AV17GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gx00b0sd_level_detail_grid1)stateInfo).executePrivate();
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
         GXPagingFrom2 = (int)(AV14start);
         GXPagingTo2 = (int)(AV15count);
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV16SearchText ,
                                              AV11cGeneroId ,
                                              AV12cGeneroInativo ,
                                              A49GeneroNome ,
                                              A48GeneroId ,
                                              A50GeneroInativo } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV16SearchText = StringUtil.Concat( StringUtil.RTrim( AV16SearchText), "%", "");
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {lV16SearchText, AV11cGeneroId, AV12cGeneroInativo, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A50GeneroInativo = P00002_A50GeneroInativo[0];
            A48GeneroId = P00002_A48GeneroId[0];
            A49GeneroNome = P00002_A49GeneroNome[0];
            AV18GXM1Gx00B0sd_Level_Detail_Grid1Sdt = new SdtGx00B0sd_Level_Detail_Grid1Sdt_Item(context);
            AV17GXM2RootCol.Add(AV18GXM1Gx00B0sd_Level_Detail_Grid1Sdt, 0);
            AV18GXM1Gx00B0sd_Level_Detail_Grid1Sdt.gxTpr_Generoid = A48GeneroId;
            AV18GXM1Gx00B0sd_Level_Detail_Grid1Sdt.gxTpr_Generonome = A49GeneroNome;
            AV18GXM1Gx00B0sd_Level_Detail_Grid1Sdt.gxTpr_Generoinativo = A50GeneroInativo;
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
         lV16SearchText = "";
         A49GeneroNome = "";
         P00002_A50GeneroInativo = new bool[] {false} ;
         P00002_A48GeneroId = new long[1] ;
         P00002_A49GeneroNome = new String[] {""} ;
         AV18GXM1Gx00B0sd_Level_Detail_Grid1Sdt = new SdtGx00B0sd_Level_Detail_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00b0sd_level_detail_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A50GeneroInativo, P00002_A48GeneroId, P00002_A49GeneroNome
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV13gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV5pGeneroId ;
      private long AV11cGeneroId ;
      private long AV14start ;
      private long AV15count ;
      private long A48GeneroId ;
      private String scmdbuf ;
      private bool AV12cGeneroInativo ;
      private bool A50GeneroInativo ;
      private String AV16SearchText ;
      private String lV16SearchText ;
      private String A49GeneroNome ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private bool[] P00002_A50GeneroInativo ;
      private long[] P00002_A48GeneroId ;
      private String[] P00002_A49GeneroNome ;
      private GXBaseCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item> aP7_GXM2RootCol ;
      private GXBaseCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item> AV17GXM2RootCol ;
      private SdtGx00B0sd_Level_Detail_Grid1Sdt_Item AV18GXM1Gx00B0sd_Level_Detail_Grid1Sdt ;
   }

   public class gx00b0sd_level_detail_grid1__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00002( IGxContext context ,
                                             String AV16SearchText ,
                                             long AV11cGeneroId ,
                                             bool AV12cGeneroInativo ,
                                             String A49GeneroNome ,
                                             long A48GeneroId ,
                                             bool A50GeneroInativo )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [6] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [GeneroInativo], [GeneroId], [GeneroNome]";
         sFromString = " FROM [Genero] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV16SearchText)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (UPPER([GeneroNome]) like '%' + UPPER(@lV16SearchText))";
            }
            else
            {
               sWhereString = sWhereString + " (UPPER([GeneroNome]) like '%' + UPPER(@lV16SearchText))";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! (0==AV11cGeneroId) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([GeneroId] = @AV11cGeneroId)";
            }
            else
            {
               sWhereString = sWhereString + " ([GeneroId] = @AV11cGeneroId)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (false==AV12cGeneroInativo) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([GeneroInativo] = @AV12cGeneroInativo)";
            }
            else
            {
               sWhereString = sWhereString + " ([GeneroInativo] = @AV12cGeneroInativo)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         sOrderString = sOrderString + " ORDER BY [GeneroId]";
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
                     return conditional_P00002(context, (String)dynConstraints[0] , (long)dynConstraints[1] , (bool)dynConstraints[2] , (String)dynConstraints[3] , (long)dynConstraints[4] , (bool)dynConstraints[5] );
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
          new Object[] {"@lV16SearchText",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@AV11cGeneroId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV12cGeneroInativo",SqlDbType.Bit,4,0} ,
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[11]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.gx00b0sd_level_detail_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class gx00b0sd_level_detail_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?pGeneroId={pGeneroId}&SearchText={SearchText}&cGeneroId={cGeneroId}&cGeneroInativo={cGeneroInativo}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( String pGeneroId ,
                                                                                              String SearchText ,
                                                                                              String cGeneroId ,
                                                                                              bool cGeneroInativo ,
                                                                                              String start ,
                                                                                              String count ,
                                                                                              String gxid )
    {
       GxGenericCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("gx00b0sd_level_detail_grid1") )
          {
             return null ;
          }
          gx00b0sd_level_detail_grid1 worker = new gx00b0sd_level_detail_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrpGeneroId ;
          gxrpGeneroId = (long)(NumberUtil.Val( (String)(pGeneroId), "."));
          long gxrcGeneroId ;
          gxrcGeneroId = (long)(NumberUtil.Val( (String)(cGeneroId), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item>() ;
          worker.execute(gxrpGeneroId,SearchText,gxrcGeneroId,cGeneroInativo,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
