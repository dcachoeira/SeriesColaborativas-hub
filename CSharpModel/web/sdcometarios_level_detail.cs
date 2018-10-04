/*
               File: SDCometarios_Level_Detail
        Description: SDCometarios_Level_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:31.24
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
   public class sdcometarios_level_detail : GXProcedure
   {
      public sdcometarios_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdcometarios_level_detail( IGxContext context )
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
                           out SdtSDCometarios_Level_DetailSdt aP3_GXM2SDCometarios_Level_DetailSdt )
      {
         this.AV5TipoComentario = aP0_TipoComentario;
         this.AV6Id = aP1_Id;
         this.AV21gxid = aP2_gxid;
         this.AV26GXM2SDCometarios_Level_DetailSdt = new SdtSDCometarios_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM2SDCometarios_Level_DetailSdt=this.AV26GXM2SDCometarios_Level_DetailSdt;
      }

      public SdtSDCometarios_Level_DetailSdt executeUdp( short aP0_TipoComentario ,
                                                         long aP1_Id ,
                                                         int aP2_gxid )
      {
         this.AV5TipoComentario = aP0_TipoComentario;
         this.AV6Id = aP1_Id;
         this.AV21gxid = aP2_gxid;
         this.AV26GXM2SDCometarios_Level_DetailSdt = new SdtSDCometarios_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP3_GXM2SDCometarios_Level_DetailSdt=this.AV26GXM2SDCometarios_Level_DetailSdt;
         return AV26GXM2SDCometarios_Level_DetailSdt ;
      }

      public void executeSubmit( short aP0_TipoComentario ,
                                 long aP1_Id ,
                                 int aP2_gxid ,
                                 out SdtSDCometarios_Level_DetailSdt aP3_GXM2SDCometarios_Level_DetailSdt )
      {
         sdcometarios_level_detail objsdcometarios_level_detail;
         objsdcometarios_level_detail = new sdcometarios_level_detail();
         objsdcometarios_level_detail.AV5TipoComentario = aP0_TipoComentario;
         objsdcometarios_level_detail.AV6Id = aP1_Id;
         objsdcometarios_level_detail.AV21gxid = aP2_gxid;
         objsdcometarios_level_detail.AV26GXM2SDCometarios_Level_DetailSdt = new SdtSDCometarios_Level_DetailSdt(context) ;
         objsdcometarios_level_detail.context.SetSubmitInitialConfig(context);
         objsdcometarios_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdcometarios_level_detail);
         aP3_GXM2SDCometarios_Level_DetailSdt=this.AV26GXM2SDCometarios_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdcometarios_level_detail)stateInfo).executePrivate();
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
            Gxdynprop1 = "Avaliação - " + AV9Nome;
            Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
            Gxwebsession.Set(Gxids+"gxvar_Nota", StringUtil.Str( (decimal)(AV11nota), 1, 0));
            Gxwebsession.Set(Gxids+"gxvar_Comentario", AV10Comentario);
            Gxwebsession.Set(Gxids+"gxvar_Avaliacao", AV33Avaliacao_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Um", AV34Um_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Dois", AV35Dois_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Tres", AV36Tres_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Quatro", AV37Quatro_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Cinco", AV38Cinco_GXI);
            Gxwebsession.Set(Gxids, "true");
         }
         else
         {
            AV10Comentario = Gxwebsession.Get(Gxids+"gxvar_Comentario");
            AV11nota = (short)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Nota"), "."));
         }
         AV26GXM2SDCometarios_Level_DetailSdt.gxTpr_Comentario = AV10Comentario;
         AV26GXM2SDCometarios_Level_DetailSdt.gxTpr_Nota = AV11nota;
         AV26GXM2SDCometarios_Level_DetailSdt.gxTpr_Tipocomentario = AV5TipoComentario;
         AV26GXM2SDCometarios_Level_DetailSdt.gxTpr_Id = AV6Id;
         AV26GXM2SDCometarios_Level_DetailSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
         Gxdynprop = "";
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
         Gxdynprop1 = "";
         Gxdynprop = "";
         AV33Avaliacao_GXI = "";
         AV34Um_GXI = "";
         AV35Dois_GXI = "";
         AV36Tres_GXI = "";
         AV37Quatro_GXI = "";
         AV38Cinco_GXI = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdcometarios_level_detail__default(),
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
      private String Gxdynprop ;
      private String AV33Avaliacao_GXI ;
      private String AV34Um_GXI ;
      private String AV35Dois_GXI ;
      private String AV36Tres_GXI ;
      private String AV37Quatro_GXI ;
      private String AV38Cinco_GXI ;
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
      private SdtSDCometarios_Level_DetailSdt aP3_GXM2SDCometarios_Level_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtSDCometarios_Level_DetailSdt AV26GXM2SDCometarios_Level_DetailSdt ;
   }

   public class sdcometarios_level_detail__default : DataStoreHelperBase, IDataStoreHelper
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

 [ServiceContract(Namespace = "GeneXus.Programs.sdcometarios_level_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdcometarios_level_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?TipoComentario={TipoComentario}&Id={Id}&gxid={gxid}")]
    public SdtSDCometarios_Level_DetailSdt_RESTInterface execute( short TipoComentario ,
                                                                  String Id ,
                                                                  String gxid )
    {
       SdtSDCometarios_Level_DetailSdt_RESTInterface GXM2SDCometarios_Level_DetailSdt = new SdtSDCometarios_Level_DetailSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("sdcometarios_level_detail") )
          {
             return null ;
          }
          sdcometarios_level_detail worker = new sdcometarios_level_detail(context) ;
          worker.IsMain = RunAsMain ;
          long gxrId ;
          gxrId = (long)(NumberUtil.Val( (String)(Id), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtSDCometarios_Level_DetailSdt gxrGXM2SDCometarios_Level_DetailSdt = GXM2SDCometarios_Level_DetailSdt.sdt ;
          worker.execute(TipoComentario,gxrId,gxrgxid,out gxrGXM2SDCometarios_Level_DetailSdt );
          worker.cleanup( );
          GXM2SDCometarios_Level_DetailSdt = new SdtSDCometarios_Level_DetailSdt_RESTInterface(gxrGXM2SDCometarios_Level_DetailSdt) ;
          return GXM2SDCometarios_Level_DetailSdt ;
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
