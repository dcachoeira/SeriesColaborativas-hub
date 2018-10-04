/*
               File: SDComentarios_Level_Detail_Grid1
        Description: SDComentarios_Level_Detail_Grid1
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 10/1/2018 14:37:13.68
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
   public class sdcomentarios_level_detail_grid1 : GXProcedure
   {
      public sdcomentarios_level_detail_grid1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdcomentarios_level_detail_grid1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_TipoComentario ,
                           long aP1_Id ,
                           long aP2_start ,
                           long aP3_count ,
                           int aP4_gxid ,
                           out GXBaseCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item> aP5_GXM3RootCol )
      {
         this.AV5TipoComentario = aP0_TipoComentario;
         this.AV6Id = aP1_Id;
         this.AV24start = aP2_start;
         this.AV25count = aP3_count;
         this.AV21gxid = aP4_gxid;
         this.AV28GXM3RootCol = new GXBaseCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP5_GXM3RootCol=this.AV28GXM3RootCol;
      }

      public GXBaseCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item> executeUdp( short aP0_TipoComentario ,
                                                                                       long aP1_Id ,
                                                                                       long aP2_start ,
                                                                                       long aP3_count ,
                                                                                       int aP4_gxid )
      {
         this.AV5TipoComentario = aP0_TipoComentario;
         this.AV6Id = aP1_Id;
         this.AV24start = aP2_start;
         this.AV25count = aP3_count;
         this.AV21gxid = aP4_gxid;
         this.AV28GXM3RootCol = new GXBaseCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP5_GXM3RootCol=this.AV28GXM3RootCol;
         return AV28GXM3RootCol ;
      }

      public void executeSubmit( short aP0_TipoComentario ,
                                 long aP1_Id ,
                                 long aP2_start ,
                                 long aP3_count ,
                                 int aP4_gxid ,
                                 out GXBaseCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item> aP5_GXM3RootCol )
      {
         sdcomentarios_level_detail_grid1 objsdcomentarios_level_detail_grid1;
         objsdcomentarios_level_detail_grid1 = new sdcomentarios_level_detail_grid1();
         objsdcomentarios_level_detail_grid1.AV5TipoComentario = aP0_TipoComentario;
         objsdcomentarios_level_detail_grid1.AV6Id = aP1_Id;
         objsdcomentarios_level_detail_grid1.AV24start = aP2_start;
         objsdcomentarios_level_detail_grid1.AV25count = aP3_count;
         objsdcomentarios_level_detail_grid1.AV21gxid = aP4_gxid;
         objsdcomentarios_level_detail_grid1.AV28GXM3RootCol = new GXBaseCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item>( context, "Item", "") ;
         objsdcomentarios_level_detail_grid1.context.SetSubmitInitialConfig(context);
         objsdcomentarios_level_detail_grid1.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdcomentarios_level_detail_grid1);
         aP5_GXM3RootCol=this.AV28GXM3RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdcomentarios_level_detail_grid1)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV21gxid), 8, 0);
         AV32Avaliacao_GXI = Gxwebsession.Get(Gxids+"gxvar_Avaliacao");
         AV14Avaliacao = "";
         AV27GXV1SkipCount = (int)(-(AV24start));
         AV27GXV1SkipCount = (int)(AV27GXV1SkipCount+1);
         if ( AV27GXV1SkipCount > 0 )
         {
            AV29GXM2SDComentarios_Level_Detail_Grid1Sdt = new SdtSDComentarios_Level_Detail_Grid1Sdt_Item(context);
            if ( AV5TipoComentario == 1 )
            {
               /* Using cursor P00002 */
               pr_default.execute(0, new Object[] {AV6Id});
               while ( (pr_default.getStatus(0) != 101) )
               {
                  A11UsuarioId = P00002_A11UsuarioId[0];
                  A14UsuarioSerieNota = P00002_A14UsuarioSerieNota[0];
                  A1SerieId = P00002_A1SerieId[0];
                  A12UsuarioNome = P00002_A12UsuarioNome[0];
                  A16UsuarioSerieComentario = P00002_A16UsuarioSerieComentario[0];
                  A13UsuarioSerieId = P00002_A13UsuarioSerieId[0];
                  A12UsuarioNome = P00002_A12UsuarioNome[0];
                  Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Usuario\",\"Caption\",\"" + StringUtil.JSONEncode( A12UsuarioNome) + "\"]";
                  Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Comentario\",\"Caption\",\"" + StringUtil.JSONEncode( A16UsuarioSerieComentario) + "\"]";
                  if ( A14UsuarioSerieNota == 1 )
                  {
                     AV14Avaliacao = context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( ));
                     AV32Avaliacao_GXI = GXDbFile.PathToUrl( context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( )));
                  }
                  else if ( A14UsuarioSerieNota == 2 )
                  {
                     AV14Avaliacao = context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( ));
                     AV32Avaliacao_GXI = GXDbFile.PathToUrl( context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( )));
                  }
                  else if ( A14UsuarioSerieNota == 3 )
                  {
                     AV14Avaliacao = context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( ));
                     AV32Avaliacao_GXI = GXDbFile.PathToUrl( context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( )));
                  }
                  else if ( A14UsuarioSerieNota == 4 )
                  {
                     AV14Avaliacao = context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( ));
                     AV32Avaliacao_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( )));
                  }
                  else if ( A14UsuarioSerieNota == 5 )
                  {
                     AV14Avaliacao = context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( ));
                     AV32Avaliacao_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( )));
                  }
                  AV29GXM2SDComentarios_Level_Detail_Grid1Sdt.gxTpr_Avaliacao = AV14Avaliacao;
                  AV29GXM2SDComentarios_Level_Detail_Grid1Sdt.gxTpr_Avaliacao_gxi = AV32Avaliacao_GXI;
                  AV29GXM2SDComentarios_Level_Detail_Grid1Sdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
                  Gxdynprop = "";
                  AV28GXM3RootCol.Add(AV29GXM2SDComentarios_Level_Detail_Grid1Sdt, 0);
                  AV29GXM2SDComentarios_Level_Detail_Grid1Sdt = new SdtSDComentarios_Level_Detail_Grid1Sdt_Item(context);
                  pr_default.readNext(0);
               }
               pr_default.close(0);
            }
            else
            {
               /* Using cursor P00003 */
               pr_default.execute(1, new Object[] {AV6Id});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A11UsuarioId = P00003_A11UsuarioId[0];
                  A19UsuarioEpisodioNota = P00003_A19UsuarioEpisodioNota[0];
                  A7EpisodioId = P00003_A7EpisodioId[0];
                  A12UsuarioNome = P00003_A12UsuarioNome[0];
                  A21UsuarioEpisodioComentario = P00003_A21UsuarioEpisodioComentario[0];
                  A18UsuarioEpisodioId = P00003_A18UsuarioEpisodioId[0];
                  A12UsuarioNome = P00003_A12UsuarioNome[0];
                  Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Usuario\",\"Caption\",\"" + StringUtil.JSONEncode( A12UsuarioNome) + "\"]";
                  Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Comentario\",\"Caption\",\"" + StringUtil.JSONEncode( A21UsuarioEpisodioComentario) + "\"]";
                  if ( A19UsuarioEpisodioNota == 1 )
                  {
                     AV14Avaliacao = context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( ));
                     AV32Avaliacao_GXI = GXDbFile.PathToUrl( context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( )));
                  }
                  else if ( A19UsuarioEpisodioNota == 2 )
                  {
                     AV14Avaliacao = context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( ));
                     AV32Avaliacao_GXI = GXDbFile.PathToUrl( context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( )));
                  }
                  else if ( A19UsuarioEpisodioNota == 3 )
                  {
                     AV14Avaliacao = context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( ));
                     AV32Avaliacao_GXI = GXDbFile.PathToUrl( context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( )));
                  }
                  else if ( A19UsuarioEpisodioNota == 4 )
                  {
                     AV14Avaliacao = context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( ));
                     AV32Avaliacao_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( )));
                  }
                  else if ( A19UsuarioEpisodioNota == 5 )
                  {
                     AV14Avaliacao = context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( ));
                     AV32Avaliacao_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( )));
                  }
                  AV29GXM2SDComentarios_Level_Detail_Grid1Sdt.gxTpr_Avaliacao = AV14Avaliacao;
                  AV29GXM2SDComentarios_Level_Detail_Grid1Sdt.gxTpr_Avaliacao_gxi = AV32Avaliacao_GXI;
                  AV29GXM2SDComentarios_Level_Detail_Grid1Sdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
                  Gxdynprop = "";
                  AV28GXM3RootCol.Add(AV29GXM2SDComentarios_Level_Detail_Grid1Sdt, 0);
                  AV29GXM2SDComentarios_Level_Detail_Grid1Sdt = new SdtSDComentarios_Level_Detail_Grid1Sdt_Item(context);
                  pr_default.readNext(1);
               }
               pr_default.close(1);
            }
            AV29GXM2SDComentarios_Level_Detail_Grid1Sdt.gxTpr_Avaliacao = AV14Avaliacao;
            AV29GXM2SDComentarios_Level_Detail_Grid1Sdt.gxTpr_Avaliacao_gxi = AV32Avaliacao_GXI;
            AV29GXM2SDComentarios_Level_Detail_Grid1Sdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
            Gxdynprop = "";
         }
         Gxwebsession.Set(Gxids+"gxvar_Avaliacao", AV32Avaliacao_GXI);
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
         AV32Avaliacao_GXI = "";
         Gxwebsession = context.GetSession();
         AV14Avaliacao = "";
         AV29GXM2SDComentarios_Level_Detail_Grid1Sdt = new SdtSDComentarios_Level_Detail_Grid1Sdt_Item(context);
         scmdbuf = "";
         P00002_A11UsuarioId = new long[1] ;
         P00002_A14UsuarioSerieNota = new short[1] ;
         P00002_A1SerieId = new long[1] ;
         P00002_A12UsuarioNome = new String[] {""} ;
         P00002_A16UsuarioSerieComentario = new String[] {""} ;
         P00002_A13UsuarioSerieId = new long[1] ;
         A12UsuarioNome = "";
         A16UsuarioSerieComentario = "";
         Gxdynprop = "";
         P00003_A11UsuarioId = new long[1] ;
         P00003_A19UsuarioEpisodioNota = new short[1] ;
         P00003_A7EpisodioId = new long[1] ;
         P00003_A12UsuarioNome = new String[] {""} ;
         P00003_A21UsuarioEpisodioComentario = new String[] {""} ;
         P00003_A18UsuarioEpisodioId = new long[1] ;
         A21UsuarioEpisodioComentario = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdcomentarios_level_detail_grid1__default(),
            new Object[][] {
                new Object[] {
               P00002_A11UsuarioId, P00002_A14UsuarioSerieNota, P00002_A1SerieId, P00002_A12UsuarioNome, P00002_A16UsuarioSerieComentario, P00002_A13UsuarioSerieId
               }
               , new Object[] {
               P00003_A11UsuarioId, P00003_A19UsuarioEpisodioNota, P00003_A7EpisodioId, P00003_A12UsuarioNome, P00003_A21UsuarioEpisodioComentario, P00003_A18UsuarioEpisodioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV5TipoComentario ;
      private short A14UsuarioSerieNota ;
      private short A19UsuarioEpisodioNota ;
      private int AV21gxid ;
      private int AV27GXV1SkipCount ;
      private long AV6Id ;
      private long AV24start ;
      private long AV25count ;
      private long A11UsuarioId ;
      private long A1SerieId ;
      private long A13UsuarioSerieId ;
      private long A7EpisodioId ;
      private long A18UsuarioEpisodioId ;
      private String Gxids ;
      private String scmdbuf ;
      private String AV32Avaliacao_GXI ;
      private String A12UsuarioNome ;
      private String A16UsuarioSerieComentario ;
      private String Gxdynprop ;
      private String A21UsuarioEpisodioComentario ;
      private String AV14Avaliacao ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A11UsuarioId ;
      private short[] P00002_A14UsuarioSerieNota ;
      private long[] P00002_A1SerieId ;
      private String[] P00002_A12UsuarioNome ;
      private String[] P00002_A16UsuarioSerieComentario ;
      private long[] P00002_A13UsuarioSerieId ;
      private long[] P00003_A11UsuarioId ;
      private short[] P00003_A19UsuarioEpisodioNota ;
      private long[] P00003_A7EpisodioId ;
      private String[] P00003_A12UsuarioNome ;
      private String[] P00003_A21UsuarioEpisodioComentario ;
      private long[] P00003_A18UsuarioEpisodioId ;
      private GXBaseCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item> aP5_GXM3RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item> AV28GXM3RootCol ;
      private SdtSDComentarios_Level_Detail_Grid1Sdt_Item AV29GXM2SDComentarios_Level_Detail_Grid1Sdt ;
   }

   public class sdcomentarios_level_detail_grid1__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@AV6Id",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP00003 ;
          prmP00003 = new Object[] {
          new Object[] {"@AV6Id",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT T1.[UsuarioId], T1.[UsuarioSerieNota], T1.[SerieId], T2.[UsuarioNome], T1.[UsuarioSerieComentario], T1.[UsuarioSerieId] FROM ([UsuarioSerie] T1 WITH (NOLOCK) INNER JOIN [Usuario] T2 WITH (NOLOCK) ON T2.[UsuarioId] = T1.[UsuarioId]) WHERE (T1.[SerieId] = @AV6Id) AND (T1.[UsuarioSerieNota] > 0) ORDER BY T1.[SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,100,0,false,false )
             ,new CursorDef("P00003", "SELECT T1.[UsuarioId], T1.[UsuarioEpisodioNota], T1.[EpisodioId], T2.[UsuarioNome], T1.[UsuarioEpisodioComentario], T1.[UsuarioEpisodioId] FROM ([UsuarioEpisodio] T1 WITH (NOLOCK) INNER JOIN [Usuario] T2 WITH (NOLOCK) ON T2.[UsuarioId] = T1.[UsuarioId]) WHERE (T1.[EpisodioId] = @AV6Id) AND (T1.[UsuarioEpisodioNota] > 0) ORDER BY T1.[EpisodioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00003,100,0,false,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.sdcomentarios_level_detail_grid1_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdcomentarios_level_detail_grid1_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?TipoComentario={TipoComentario}&Id={Id}&start={start}&count={count}&gxid={gxid}")]
    public GxGenericCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item_RESTInterface> execute( short TipoComentario ,
                                                                                                   String Id ,
                                                                                                   String start ,
                                                                                                   String count ,
                                                                                                   String gxid )
    {
       GxGenericCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item_RESTInterface> GXM3RootCol = new GxGenericCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("sdcomentarios_level_detail_grid1") )
          {
             return null ;
          }
          sdcomentarios_level_detail_grid1 worker = new sdcomentarios_level_detail_grid1(context) ;
          worker.IsMain = RunAsMain ;
          long gxrId ;
          gxrId = (long)(NumberUtil.Val( (String)(Id), "."));
          long gxrstart ;
          gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
          long gxrcount ;
          gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          GXBaseCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item> gxrGXM3RootCol = new GXBaseCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item>() ;
          worker.execute(TipoComentario,gxrId,gxrstart,gxrcount,gxrgxid,out gxrGXM3RootCol );
          worker.cleanup( );
          GXM3RootCol = new GxGenericCollection<SdtSDComentarios_Level_Detail_Grid1Sdt_Item_RESTInterface>(gxrGXM3RootCol) ;
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
