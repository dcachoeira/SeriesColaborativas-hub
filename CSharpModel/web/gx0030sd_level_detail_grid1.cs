/*
               File: Gx0030sd_Level_Detail_Grid1
        Description: Gx0030sd_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:28.42
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
   public class gx0030sd_level_detail_grid1 : GXProcedure
   {
      public gx0030sd_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public gx0030sd_level_detail_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_pUsuarioId ,
                           String aP1_SearchText ,
                           long aP2_cUsuarioId ,
                           short aP3_cUsuarioTipo ,
                           bool aP4_cUsuarioInativo ,
                           long aP5_start ,
                           long aP6_count ,
                           int aP7_gxid ,
                           out GXBaseCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item> aP8_GXM2RootCol )
      {
         this.AV5pUsuarioId = aP0_pUsuarioId;
         this.AV17SearchText = aP1_SearchText;
         this.AV11cUsuarioId = aP2_cUsuarioId;
         this.AV12cUsuarioTipo = aP3_cUsuarioTipo;
         this.AV13cUsuarioInativo = aP4_cUsuarioInativo;
         this.AV15start = aP5_start;
         this.AV16count = aP6_count;
         this.AV14gxid = aP7_gxid;
         this.AV18GXM2RootCol = new GXBaseCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP8_GXM2RootCol=this.AV18GXM2RootCol;
      }

      public GXBaseCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item> executeUdp( long aP0_pUsuarioId ,
                                                                                  String aP1_SearchText ,
                                                                                  long aP2_cUsuarioId ,
                                                                                  short aP3_cUsuarioTipo ,
                                                                                  bool aP4_cUsuarioInativo ,
                                                                                  long aP5_start ,
                                                                                  long aP6_count ,
                                                                                  int aP7_gxid )
      {
         this.AV5pUsuarioId = aP0_pUsuarioId;
         this.AV17SearchText = aP1_SearchText;
         this.AV11cUsuarioId = aP2_cUsuarioId;
         this.AV12cUsuarioTipo = aP3_cUsuarioTipo;
         this.AV13cUsuarioInativo = aP4_cUsuarioInativo;
         this.AV15start = aP5_start;
         this.AV16count = aP6_count;
         this.AV14gxid = aP7_gxid;
         this.AV18GXM2RootCol = new GXBaseCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP8_GXM2RootCol=this.AV18GXM2RootCol;
         return AV18GXM2RootCol ;
      }

      public void executeSubmit( long aP0_pUsuarioId ,
                                 String aP1_SearchText ,
                                 long aP2_cUsuarioId ,
                                 short aP3_cUsuarioTipo ,
                                 bool aP4_cUsuarioInativo ,
                                 long aP5_start ,
                                 long aP6_count ,
                                 int aP7_gxid ,
                                 out GXBaseCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item> aP8_GXM2RootCol )
      {
         gx0030sd_level_detail_grid1 objgx0030sd_level_detail_grid1;
         objgx0030sd_level_detail_grid1 = new gx0030sd_level_detail_grid1();
         objgx0030sd_level_detail_grid1.AV5pUsuarioId = aP0_pUsuarioId;
         objgx0030sd_level_detail_grid1.AV17SearchText = aP1_SearchText;
         objgx0030sd_level_detail_grid1.AV11cUsuarioId = aP2_cUsuarioId;
         objgx0030sd_level_detail_grid1.AV12cUsuarioTipo = aP3_cUsuarioTipo;
         objgx0030sd_level_detail_grid1.AV13cUsuarioInativo = aP4_cUsuarioInativo;
         objgx0030sd_level_detail_grid1.AV15start = aP5_start;
         objgx0030sd_level_detail_grid1.AV16count = aP6_count;
         objgx0030sd_level_detail_grid1.AV14gxid = aP7_gxid;
         objgx0030sd_level_detail_grid1.AV18GXM2RootCol = new GXBaseCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objgx0030sd_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objgx0030sd_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgx0030sd_level_detail_grid1);
         aP8_GXM2RootCol=this.AV18GXM2RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gx0030sd_level_detail_grid1)stateInfo).executePrivate();
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
         GXPagingFrom2 = (int)(AV15start);
         GXPagingTo2 = (int)(AV16count);
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV17SearchText ,
                                              AV11cUsuarioId ,
                                              AV12cUsuarioTipo ,
                                              AV13cUsuarioInativo ,
                                              A12UsuarioNome ,
                                              A54UsuarioLogin ,
                                              A55UsuarioSenha ,
                                              A56UsuarioGamGuid ,
                                              A11UsuarioId ,
                                              A52UsuarioTipo ,
                                              A53UsuarioInativo } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.SHORT,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV17SearchText = StringUtil.Concat( StringUtil.RTrim( AV17SearchText), "%", "");
         lV17SearchText = StringUtil.Concat( StringUtil.RTrim( AV17SearchText), "%", "");
         lV17SearchText = StringUtil.Concat( StringUtil.RTrim( AV17SearchText), "%", "");
         lV17SearchText = StringUtil.Concat( StringUtil.RTrim( AV17SearchText), "%", "");
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {lV17SearchText, lV17SearchText, lV17SearchText, lV17SearchText, AV11cUsuarioId, AV12cUsuarioTipo, AV13cUsuarioInativo, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A53UsuarioInativo = P00002_A53UsuarioInativo[0];
            A52UsuarioTipo = P00002_A52UsuarioTipo[0];
            A11UsuarioId = P00002_A11UsuarioId[0];
            A12UsuarioNome = P00002_A12UsuarioNome[0];
            A54UsuarioLogin = P00002_A54UsuarioLogin[0];
            A55UsuarioSenha = P00002_A55UsuarioSenha[0];
            A56UsuarioGamGuid = P00002_A56UsuarioGamGuid[0];
            AV19GXM1Gx0030sd_Level_Detail_Grid1Sdt = new SdtGx0030sd_Level_Detail_Grid1Sdt_Item(context);
            AV18GXM2RootCol.Add(AV19GXM1Gx0030sd_Level_Detail_Grid1Sdt, 0);
            AV19GXM1Gx0030sd_Level_Detail_Grid1Sdt.gxTpr_Usuarioid = A11UsuarioId;
            AV19GXM1Gx0030sd_Level_Detail_Grid1Sdt.gxTpr_Usuarionome = A12UsuarioNome;
            AV19GXM1Gx0030sd_Level_Detail_Grid1Sdt.gxTpr_Usuariotipo = A52UsuarioTipo;
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
         lV17SearchText = "";
         A12UsuarioNome = "";
         A54UsuarioLogin = "";
         A55UsuarioSenha = "";
         A56UsuarioGamGuid = "";
         P00002_A53UsuarioInativo = new bool[] {false} ;
         P00002_A52UsuarioTipo = new short[1] ;
         P00002_A11UsuarioId = new long[1] ;
         P00002_A12UsuarioNome = new String[] {""} ;
         P00002_A54UsuarioLogin = new String[] {""} ;
         P00002_A55UsuarioSenha = new String[] {""} ;
         P00002_A56UsuarioGamGuid = new String[] {""} ;
         AV19GXM1Gx0030sd_Level_Detail_Grid1Sdt = new SdtGx0030sd_Level_Detail_Grid1Sdt_Item(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0030sd_level_detail_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A53UsuarioInativo, P00002_A52UsuarioTipo, P00002_A11UsuarioId, P00002_A12UsuarioNome, P00002_A54UsuarioLogin, P00002_A55UsuarioSenha, P00002_A56UsuarioGamGuid
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV12cUsuarioTipo ;
      private short A52UsuarioTipo ;
      private int AV14gxid ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private long AV5pUsuarioId ;
      private long AV11cUsuarioId ;
      private long AV15start ;
      private long AV16count ;
      private long A11UsuarioId ;
      private String scmdbuf ;
      private String A56UsuarioGamGuid ;
      private bool AV13cUsuarioInativo ;
      private bool A53UsuarioInativo ;
      private String AV17SearchText ;
      private String lV17SearchText ;
      private String A12UsuarioNome ;
      private String A54UsuarioLogin ;
      private String A55UsuarioSenha ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private bool[] P00002_A53UsuarioInativo ;
      private short[] P00002_A52UsuarioTipo ;
      private long[] P00002_A11UsuarioId ;
      private String[] P00002_A12UsuarioNome ;
      private String[] P00002_A54UsuarioLogin ;
      private String[] P00002_A55UsuarioSenha ;
      private String[] P00002_A56UsuarioGamGuid ;
      private GXBaseCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item> aP8_GXM2RootCol ;
      private GXBaseCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item> AV18GXM2RootCol ;
      private SdtGx0030sd_Level_Detail_Grid1Sdt_Item AV19GXM1Gx0030sd_Level_Detail_Grid1Sdt ;
   }

   public class gx0030sd_level_detail_grid1__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00002( IGxContext context ,
                                             String AV17SearchText ,
                                             long AV11cUsuarioId ,
                                             short AV12cUsuarioTipo ,
                                             bool AV13cUsuarioInativo ,
                                             String A12UsuarioNome ,
                                             String A54UsuarioLogin ,
                                             String A55UsuarioSenha ,
                                             String A56UsuarioGamGuid ,
                                             long A11UsuarioId ,
                                             short A52UsuarioTipo ,
                                             bool A53UsuarioInativo )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [10] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [UsuarioInativo], [UsuarioTipo], [UsuarioId], [UsuarioNome], [UsuarioLogin], [UsuarioSenha], [UsuarioGamGuid]";
         sFromString = " FROM [Usuario] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV17SearchText)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (UPPER([UsuarioNome]) like '%' + UPPER(@lV17SearchText) or UPPER([UsuarioLogin]) like '%' + UPPER(@lV17SearchText) or UPPER([UsuarioSenha]) like '%' + UPPER(@lV17SearchText) or UPPER([UsuarioGamGuid]) like '%' + UPPER(@lV17SearchText))";
            }
            else
            {
               sWhereString = sWhereString + " (UPPER([UsuarioNome]) like '%' + UPPER(@lV17SearchText) or UPPER([UsuarioLogin]) like '%' + UPPER(@lV17SearchText) or UPPER([UsuarioSenha]) like '%' + UPPER(@lV17SearchText) or UPPER([UsuarioGamGuid]) like '%' + UPPER(@lV17SearchText))";
            }
         }
         else
         {
            GXv_int1[0] = 1;
            GXv_int1[1] = 1;
            GXv_int1[2] = 1;
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV11cUsuarioId) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([UsuarioId] = @AV11cUsuarioId)";
            }
            else
            {
               sWhereString = sWhereString + " ([UsuarioId] = @AV11cUsuarioId)";
            }
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV12cUsuarioTipo) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([UsuarioTipo] >= @AV12cUsuarioTipo)";
            }
            else
            {
               sWhereString = sWhereString + " ([UsuarioTipo] >= @AV12cUsuarioTipo)";
            }
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (false==AV13cUsuarioInativo) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([UsuarioInativo] = @AV13cUsuarioInativo)";
            }
            else
            {
               sWhereString = sWhereString + " ([UsuarioInativo] = @AV13cUsuarioInativo)";
            }
         }
         else
         {
            GXv_int1[6] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         sOrderString = sOrderString + " ORDER BY [UsuarioId]";
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
                     return conditional_P00002(context, (String)dynConstraints[0] , (long)dynConstraints[1] , (short)dynConstraints[2] , (bool)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (short)dynConstraints[9] , (bool)dynConstraints[10] );
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
          new Object[] {"@lV17SearchText",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@lV17SearchText",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@lV17SearchText",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@lV17SearchText",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@AV11cUsuarioId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV12cUsuarioTipo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13cUsuarioInativo",SqlDbType.Bit,4,0} ,
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
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 40) ;
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
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.gx0030sd_level_detail_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class gx0030sd_level_detail_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?pUsuarioId={pUsuarioId}&SearchText={SearchText}&cUsuarioId={cUsuarioId}&cUsuarioTipo={cUsuarioTipo}&cUsuarioInativo={cUsuarioInativo}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( String pUsuarioId ,
                                                                                              String SearchText ,
                                                                                              String cUsuarioId ,
                                                                                              short cUsuarioTipo ,
                                                                                              bool cUsuarioInativo ,
                                                                                              String start ,
                                                                                              String count ,
                                                                                              String gxid )
    {
       GxGenericCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM2RootCol = new GxGenericCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("gx0030sd_level_detail_grid1") )
          {
             return null ;
          }
          gx0030sd_level_detail_grid1 worker = new gx0030sd_level_detail_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrpUsuarioId ;
          gxrpUsuarioId = (long)(NumberUtil.Val( (String)(pUsuarioId), "."));
          long gxrcUsuarioId ;
          gxrcUsuarioId = (long)(NumberUtil.Val( (String)(cUsuarioId), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item> gxrGXM2RootCol = new GXBaseCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item>() ;
          worker.execute(gxrpUsuarioId,SearchText,gxrcUsuarioId,cUsuarioTipo,cUsuarioInativo,gxrstart,gxrcount,gxrgxid,out gxrGXM2RootCol );
          worker.cleanup( );
          GXM2RootCol = new GxGenericCollection<SdtGx0030sd_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM2RootCol) ;
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
