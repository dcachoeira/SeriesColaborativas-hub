/*
               File: SDComentarios_Level_Detail
        Description: SDComentarios_Level_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 10/1/2018 14:37:13.89
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
   public class sdcomentarios_level_detail : GXProcedure
   {
      public sdcomentarios_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdcomentarios_level_detail( IGxContext context )
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
                           int aP2_gxid ,
                           out SdtSDComentarios_Level_DetailSdt aP3_GXM2SDComentarios_Level_DetailSdt )
      {
         this.AV5TipoComentario = aP0_TipoComentario;
         this.AV6Id = aP1_Id;
         this.AV21gxid = aP2_gxid;
         this.AV26GXM2SDComentarios_Level_DetailSdt = new SdtSDComentarios_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM2SDComentarios_Level_DetailSdt=this.AV26GXM2SDComentarios_Level_DetailSdt;
      }

      public SdtSDComentarios_Level_DetailSdt executeUdp( short aP0_TipoComentario ,
                                                          long aP1_Id ,
                                                          int aP2_gxid )
      {
         this.AV5TipoComentario = aP0_TipoComentario;
         this.AV6Id = aP1_Id;
         this.AV21gxid = aP2_gxid;
         this.AV26GXM2SDComentarios_Level_DetailSdt = new SdtSDComentarios_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM2SDComentarios_Level_DetailSdt=this.AV26GXM2SDComentarios_Level_DetailSdt;
         return AV26GXM2SDComentarios_Level_DetailSdt ;
      }

      public void executeSubmit( short aP0_TipoComentario ,
                                 long aP1_Id ,
                                 int aP2_gxid ,
                                 out SdtSDComentarios_Level_DetailSdt aP3_GXM2SDComentarios_Level_DetailSdt )
      {
         sdcomentarios_level_detail objsdcomentarios_level_detail;
         objsdcomentarios_level_detail = new sdcomentarios_level_detail();
         objsdcomentarios_level_detail.AV5TipoComentario = aP0_TipoComentario;
         objsdcomentarios_level_detail.AV6Id = aP1_Id;
         objsdcomentarios_level_detail.AV21gxid = aP2_gxid;
         objsdcomentarios_level_detail.AV26GXM2SDComentarios_Level_DetailSdt = new SdtSDComentarios_Level_DetailSdt(context) ;
         objsdcomentarios_level_detail.context.SetSubmitInitialConfig(context);
         objsdcomentarios_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdcomentarios_level_detail);
         aP3_GXM2SDComentarios_Level_DetailSdt=this.AV26GXM2SDComentarios_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdcomentarios_level_detail)stateInfo).executePrivate();
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
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            if ( AV5TipoComentario == 1 )
            {
               /* Using cursor P00002 */
               pr_default.execute(0, new Object[] {AV6Id});
               while ( (pr_default.getStatus(0) != 101) )
               {
                  A1SerieId = P00002_A1SerieId[0];
                  A2SerieNome = P00002_A2SerieNome[0];
                  AV9Nome = A2SerieNome;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(0);
               /* Using cursor P00003 */
               pr_default.execute(1, new Object[] {AV6Id});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A11UsuarioId = P00003_A11UsuarioId[0];
                  A1SerieId = P00003_A1SerieId[0];
                  A16UsuarioSerieComentario = P00003_A16UsuarioSerieComentario[0];
                  A14UsuarioSerieNota = P00003_A14UsuarioSerieNota[0];
                  A13UsuarioSerieId = P00003_A13UsuarioSerieId[0];
                  AV10Comentario = A16UsuarioSerieComentario;
                  AV11nota = A14UsuarioSerieNota;
                  pr_default.readNext(1);
               }
               pr_default.close(1);
            }
            else
            {
               /* Using cursor P00004 */
               pr_default.execute(2, new Object[] {AV6Id});
               while ( (pr_default.getStatus(2) != 101) )
               {
                  A7EpisodioId = P00004_A7EpisodioId[0];
                  A8EpisodioNome = P00004_A8EpisodioNome[0];
                  AV9Nome = A8EpisodioNome;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(2);
               /* Using cursor P00005 */
               pr_default.execute(3, new Object[] {AV6Id});
               while ( (pr_default.getStatus(3) != 101) )
               {
                  A11UsuarioId = P00005_A11UsuarioId[0];
                  A7EpisodioId = P00005_A7EpisodioId[0];
                  A21UsuarioEpisodioComentario = P00005_A21UsuarioEpisodioComentario[0];
                  A19UsuarioEpisodioNota = P00005_A19UsuarioEpisodioNota[0];
                  A18UsuarioEpisodioId = P00005_A18UsuarioEpisodioId[0];
                  AV10Comentario = A21UsuarioEpisodioComentario;
                  AV11nota = A19UsuarioEpisodioNota;
                  pr_default.readNext(3);
               }
               pr_default.close(3);
            }
            AV15Um = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
            AV33Um_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            AV16Dois = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
            AV34Dois_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            AV17Tres = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
            AV35Tres_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            AV18Quatro = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
            AV36Quatro_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            AV19Cinco = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
            AV37Cinco_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            if ( AV11nota == 1 )
            {
               AV15Um = context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( ));
               AV33Um_GXI = GXDbFile.PathToUrl( context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( )));
            }
            else if ( AV11nota == 2 )
            {
               AV16Dois = context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( ));
               AV34Dois_GXI = GXDbFile.PathToUrl( context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( )));
            }
            else if ( AV11nota == 3 )
            {
               AV17Tres = context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( ));
               AV35Tres_GXI = GXDbFile.PathToUrl( context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( )));
            }
            else if ( AV11nota == 4 )
            {
               AV18Quatro = context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( ));
               AV36Quatro_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( )));
            }
            else if ( AV11nota == 5 )
            {
               AV19Cinco = context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( ));
               AV37Cinco_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( )));
            }
            Gxdynprop1 = "Avaliação - " + AV9Nome;
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
            Gxwebsession.Set(Gxids+"gxvar_Comentario", AV10Comentario);
            Gxwebsession.Set(Gxids+"gxvar_Nota", StringUtil.Str( (decimal)(AV11nota), 1, 0));
            Gxwebsession.Set(Gxids+"gxvar_Um", AV33Um_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Dois", AV34Dois_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Tres", AV35Tres_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Quatro", AV36Quatro_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Cinco", AV37Cinco_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Avaliacao", AV38Avaliacao_GXI);
            Gxwebsession.Set(Gxids, "true");
         }
         else
         {
            AV11nota = (short)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Nota"), "."));
            AV33Um_GXI = Gxwebsession.Get(Gxids+"gxvar_Um");
            AV15Um = "";
            AV34Dois_GXI = Gxwebsession.Get(Gxids+"gxvar_Dois");
            AV16Dois = "";
            AV35Tres_GXI = Gxwebsession.Get(Gxids+"gxvar_Tres");
            AV17Tres = "";
            AV36Quatro_GXI = Gxwebsession.Get(Gxids+"gxvar_Quatro");
            AV18Quatro = "";
            AV37Cinco_GXI = Gxwebsession.Get(Gxids+"gxvar_Cinco");
            AV19Cinco = "";
            AV10Comentario = Gxwebsession.Get(Gxids+"gxvar_Comentario");
         }
         GX_msglist.addItem("Refresh");
         if ( AV11nota == 1 )
         {
            AV15Um = context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( ));
            AV33Um_GXI = GXDbFile.PathToUrl( context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( )));
         }
         else if ( AV11nota == 2 )
         {
            AV16Dois = context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( ));
            AV34Dois_GXI = GXDbFile.PathToUrl( context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( )));
         }
         else if ( AV11nota == 3 )
         {
            AV17Tres = context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( ));
            AV35Tres_GXI = GXDbFile.PathToUrl( context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( )));
         }
         else if ( AV11nota == 4 )
         {
            AV18Quatro = context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( ));
            AV36Quatro_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( )));
         }
         else if ( AV11nota == 5 )
         {
            AV19Cinco = context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( ));
            AV37Cinco_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( )));
         }
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Comentario = AV10Comentario;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Nota = AV11nota;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Um = AV15Um;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Um_gxi = AV33Um_GXI;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Dois = AV16Dois;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Dois_gxi = AV34Dois_GXI;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Tres = AV17Tres;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Tres_gxi = AV35Tres_GXI;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Quatro = AV18Quatro;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Quatro_gxi = AV36Quatro_GXI;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Cinco = AV19Cinco;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Cinco_gxi = AV37Cinco_GXI;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Tipocomentario = AV5TipoComentario;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Id = AV6Id;
         AV26GXM2SDComentarios_Level_DetailSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
         Gxdynprop = "";
         Gxwebsession.Set(Gxids+"gxvar_Um", AV33Um_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Dois", AV34Dois_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Tres", AV35Tres_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Quatro", AV36Quatro_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Cinco", AV37Cinco_GXI);
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
         AV9Nome = "";
         P00003_A11UsuarioId = new long[1] ;
         P00003_A1SerieId = new long[1] ;
         P00003_A16UsuarioSerieComentario = new String[] {""} ;
         P00003_A14UsuarioSerieNota = new short[1] ;
         P00003_A13UsuarioSerieId = new long[1] ;
         A16UsuarioSerieComentario = "";
         AV10Comentario = "";
         P00004_A7EpisodioId = new long[1] ;
         P00004_A8EpisodioNome = new String[] {""} ;
         A8EpisodioNome = "";
         P00005_A11UsuarioId = new long[1] ;
         P00005_A7EpisodioId = new long[1] ;
         P00005_A21UsuarioEpisodioComentario = new String[] {""} ;
         P00005_A19UsuarioEpisodioNota = new short[1] ;
         P00005_A18UsuarioEpisodioId = new long[1] ;
         A21UsuarioEpisodioComentario = "";
         AV15Um = "";
         AV33Um_GXI = "";
         AV16Dois = "";
         AV34Dois_GXI = "";
         AV17Tres = "";
         AV35Tres_GXI = "";
         AV18Quatro = "";
         AV36Quatro_GXI = "";
         AV19Cinco = "";
         AV37Cinco_GXI = "";
         Gxdynprop1 = "";
         Gxdynprop = "";
         AV38Avaliacao_GXI = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdcomentarios_level_detail__default(),
            new Object[][] {
                new Object[] {
               P00002_A1SerieId, P00002_A2SerieNome
               }
               , new Object[] {
               P00003_A11UsuarioId, P00003_A1SerieId, P00003_A16UsuarioSerieComentario, P00003_A14UsuarioSerieNota, P00003_A13UsuarioSerieId
               }
               , new Object[] {
               P00004_A7EpisodioId, P00004_A8EpisodioNome
               }
               , new Object[] {
               P00005_A11UsuarioId, P00005_A7EpisodioId, P00005_A21UsuarioEpisodioComentario, P00005_A19UsuarioEpisodioNota, P00005_A18UsuarioEpisodioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV5TipoComentario ;
      private short A14UsuarioSerieNota ;
      private short AV11nota ;
      private short A19UsuarioEpisodioNota ;
      private int AV21gxid ;
      private long AV6Id ;
      private long A1SerieId ;
      private long A11UsuarioId ;
      private long A13UsuarioSerieId ;
      private long A7EpisodioId ;
      private long A18UsuarioEpisodioId ;
      private String Gxids ;
      private String scmdbuf ;
      private String Gxdynprop1 ;
      private String A2SerieNome ;
      private String AV9Nome ;
      private String A16UsuarioSerieComentario ;
      private String AV10Comentario ;
      private String A8EpisodioNome ;
      private String A21UsuarioEpisodioComentario ;
      private String AV33Um_GXI ;
      private String AV34Dois_GXI ;
      private String AV35Tres_GXI ;
      private String AV36Quatro_GXI ;
      private String AV37Cinco_GXI ;
      private String Gxdynprop ;
      private String AV38Avaliacao_GXI ;
      private String AV15Um ;
      private String AV16Dois ;
      private String AV17Tres ;
      private String AV18Quatro ;
      private String AV19Cinco ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A1SerieId ;
      private String[] P00002_A2SerieNome ;
      private long[] P00003_A11UsuarioId ;
      private long[] P00003_A1SerieId ;
      private String[] P00003_A16UsuarioSerieComentario ;
      private short[] P00003_A14UsuarioSerieNota ;
      private long[] P00003_A13UsuarioSerieId ;
      private long[] P00004_A7EpisodioId ;
      private String[] P00004_A8EpisodioNome ;
      private long[] P00005_A11UsuarioId ;
      private long[] P00005_A7EpisodioId ;
      private String[] P00005_A21UsuarioEpisodioComentario ;
      private short[] P00005_A19UsuarioEpisodioNota ;
      private long[] P00005_A18UsuarioEpisodioId ;
      private SdtSDComentarios_Level_DetailSdt aP3_GXM2SDComentarios_Level_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtSDComentarios_Level_DetailSdt AV26GXM2SDComentarios_Level_DetailSdt ;
   }

   public class sdcomentarios_level_detail__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
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
          Object[] prmP00004 ;
          prmP00004 = new Object[] {
          new Object[] {"@AV6Id",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP00005 ;
          prmP00005 = new Object[] {
          new Object[] {"@AV6Id",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [SerieId], [SerieNome] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @AV6Id ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
             ,new CursorDef("P00003", "SELECT [UsuarioId], [SerieId], [UsuarioSerieComentario], [UsuarioSerieNota], [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE ([SerieId] = @AV6Id) AND ([UsuarioId] = 2) ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00003,100,0,false,false )
             ,new CursorDef("P00004", "SELECT [EpisodioId], [EpisodioNome] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @AV6Id ORDER BY [EpisodioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00004,1,0,false,true )
             ,new CursorDef("P00005", "SELECT [UsuarioId], [EpisodioId], [UsuarioEpisodioComentario], [UsuarioEpisodioNota], [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE ([EpisodioId] = @AV6Id) AND ([UsuarioId] = 2) ORDER BY [EpisodioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00005,100,0,false,false )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
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
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.sdcomentarios_level_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdcomentarios_level_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?TipoComentario={TipoComentario}&Id={Id}&gxid={gxid}")]
    public SdtSDComentarios_Level_DetailSdt_RESTInterface execute( short TipoComentario ,
                                                                   String Id ,
                                                                   String gxid )
    {
       SdtSDComentarios_Level_DetailSdt_RESTInterface GXM2SDComentarios_Level_DetailSdt = new SdtSDComentarios_Level_DetailSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("sdcomentarios_level_detail") )
          {
             return null ;
          }
          sdcomentarios_level_detail worker = new sdcomentarios_level_detail(context) ;
          worker.IsMain = RunAsMain ;
          long gxrId ;
          gxrId = (long)(NumberUtil.Val( (String)(Id), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtSDComentarios_Level_DetailSdt gxrGXM2SDComentarios_Level_DetailSdt = GXM2SDComentarios_Level_DetailSdt.sdt ;
          worker.execute(TipoComentario,gxrId,gxrgxid,out gxrGXM2SDComentarios_Level_DetailSdt );
          worker.cleanup( );
          GXM2SDComentarios_Level_DetailSdt = new SdtSDComentarios_Level_DetailSdt_RESTInterface(gxrGXM2SDComentarios_Level_DetailSdt) ;
          return GXM2SDComentarios_Level_DetailSdt ;
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
