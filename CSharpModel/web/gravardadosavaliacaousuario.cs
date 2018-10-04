/*
               File: GravarDadosAvaliacaoUsuario
        Description: Gravar Dados Avaliacao Usuario
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:39:23.20
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
   public class gravardadosavaliacaousuario : GXProcedure
   {
      public gravardadosavaliacaousuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gravardadosavaliacaousuario( IGxContext context )
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
                           long aP2_usuarioId ,
                           String aP3_Comentario ,
                           short aP4_nota )
      {
         this.AV9TipoComentario = aP0_TipoComentario;
         this.AV10Id = aP1_Id;
         this.AV13usuarioId = aP2_usuarioId;
         this.AV11Comentario = aP3_Comentario;
         this.AV8nota = aP4_nota;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_TipoComentario ,
                                 long aP1_Id ,
                                 long aP2_usuarioId ,
                                 String aP3_Comentario ,
                                 short aP4_nota )
      {
         gravardadosavaliacaousuario objgravardadosavaliacaousuario;
         objgravardadosavaliacaousuario = new gravardadosavaliacaousuario();
         objgravardadosavaliacaousuario.AV9TipoComentario = aP0_TipoComentario;
         objgravardadosavaliacaousuario.AV10Id = aP1_Id;
         objgravardadosavaliacaousuario.AV13usuarioId = aP2_usuarioId;
         objgravardadosavaliacaousuario.AV11Comentario = aP3_Comentario;
         objgravardadosavaliacaousuario.AV8nota = aP4_nota;
         objgravardadosavaliacaousuario.context.SetSubmitInitialConfig(context);
         objgravardadosavaliacaousuario.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgravardadosavaliacaousuario);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gravardadosavaliacaousuario)stateInfo).executePrivate();
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
         if ( AV9TipoComentario == 1 )
         {
            /* Using cursor P001L2 */
            pr_default.execute(0, new Object[] {AV10Id, AV13usuarioId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A11UsuarioId = P001L2_A11UsuarioId[0];
               A1SerieId = P001L2_A1SerieId[0];
               A13UsuarioSerieId = P001L2_A13UsuarioSerieId[0];
               AV14UsuarioSerieId = A13UsuarioSerieId;
               pr_default.readNext(0);
            }
            pr_default.close(0);
            AV12UsuarioSerie.Load(AV14UsuarioSerieId);
            if ( AV12UsuarioSerie.Fail() )
            {
               AV12UsuarioSerie = new SdtUsuarioSerie(context);
            }
            AV12UsuarioSerie.gxTpr_Serieid = AV10Id;
            AV12UsuarioSerie.gxTpr_Usuarioid = AV13usuarioId;
            AV12UsuarioSerie.gxTpr_Usuarioseriecomentario = AV11Comentario;
            AV12UsuarioSerie.gxTpr_Usuarioserienota = AV8nota;
            AV12UsuarioSerie.Save();
            if ( ! AV12UsuarioSerie.Fail() )
            {
               pr_gam.commit( "GravarDadosAvaliacaoUsuario");
               pr_default.commit( "GravarDadosAvaliacaoUsuario");
            }
            else
            {
               GX_msglist.addItem("Erro ao gravar usuário série: "+((SdtMessages_Message)AV12UsuarioSerie.GetMessages().Item(1)).gxTpr_Description);
            }
         }
         else
         {
            /* Using cursor P001L3 */
            pr_default.execute(1, new Object[] {AV10Id, AV13usuarioId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A11UsuarioId = P001L3_A11UsuarioId[0];
               A7EpisodioId = P001L3_A7EpisodioId[0];
               A18UsuarioEpisodioId = P001L3_A18UsuarioEpisodioId[0];
               AV16UsuarioEpisodioId = A18UsuarioEpisodioId;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            AV17UsuarioEpisodio.Load(AV16UsuarioEpisodioId);
            if ( AV17UsuarioEpisodio.Fail() )
            {
               AV17UsuarioEpisodio = new SdtUsuarioEpisodio(context);
            }
            AV17UsuarioEpisodio.gxTpr_Episodioid = AV10Id;
            AV17UsuarioEpisodio.gxTpr_Usuarioid = AV13usuarioId;
            AV17UsuarioEpisodio.gxTpr_Usuarioepisodiocomentario = AV11Comentario;
            AV17UsuarioEpisodio.gxTpr_Usuarioepisodionota = AV8nota;
            AV17UsuarioEpisodio.Save();
            if ( ! AV17UsuarioEpisodio.Fail() )
            {
               pr_gam.commit( "GravarDadosAvaliacaoUsuario");
               pr_default.commit( "GravarDadosAvaliacaoUsuario");
            }
            else
            {
               GX_msglist.addItem("Erro ao gravar usuário episódio: "+((SdtMessages_Message)AV17UsuarioEpisodio.GetMessages().Item(1)).gxTpr_Description);
            }
         }
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
         P001L2_A11UsuarioId = new long[1] ;
         P001L2_A1SerieId = new long[1] ;
         P001L2_A13UsuarioSerieId = new long[1] ;
         AV12UsuarioSerie = new SdtUsuarioSerie(context);
         P001L3_A11UsuarioId = new long[1] ;
         P001L3_A7EpisodioId = new long[1] ;
         P001L3_A18UsuarioEpisodioId = new long[1] ;
         AV17UsuarioEpisodio = new SdtUsuarioEpisodio(context);
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gravardadosavaliacaousuario__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gravardadosavaliacaousuario__default(),
            new Object[][] {
                new Object[] {
               P001L2_A11UsuarioId, P001L2_A1SerieId, P001L2_A13UsuarioSerieId
               }
               , new Object[] {
               P001L3_A11UsuarioId, P001L3_A7EpisodioId, P001L3_A18UsuarioEpisodioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9TipoComentario ;
      private short AV8nota ;
      private long AV10Id ;
      private long AV13usuarioId ;
      private long A11UsuarioId ;
      private long A1SerieId ;
      private long A13UsuarioSerieId ;
      private long AV14UsuarioSerieId ;
      private long A7EpisodioId ;
      private long A18UsuarioEpisodioId ;
      private long AV16UsuarioEpisodioId ;
      private String scmdbuf ;
      private String AV11Comentario ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001L2_A11UsuarioId ;
      private long[] P001L2_A1SerieId ;
      private long[] P001L2_A13UsuarioSerieId ;
      private IDataStoreProvider pr_gam ;
      private long[] P001L3_A11UsuarioId ;
      private long[] P001L3_A7EpisodioId ;
      private long[] P001L3_A18UsuarioEpisodioId ;
      private SdtUsuarioSerie AV12UsuarioSerie ;
      private SdtUsuarioEpisodio AV17UsuarioEpisodio ;
   }

   public class gravardadosavaliacaousuario__gam : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "GAM";
    }

 }

 public class gravardadosavaliacaousuario__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmP001L2 ;
        prmP001L2 = new Object[] {
        new Object[] {"@AV10Id",SqlDbType.Decimal,18,0} ,
        new Object[] {"@AV13usuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmP001L3 ;
        prmP001L3 = new Object[] {
        new Object[] {"@AV10Id",SqlDbType.Decimal,18,0} ,
        new Object[] {"@AV13usuarioId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("P001L2", "SELECT [UsuarioId], [SerieId], [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE ([SerieId] = @AV10Id) AND ([UsuarioId] = @AV13usuarioId) ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001L2,100,0,false,false )
           ,new CursorDef("P001L3", "SELECT [UsuarioId], [EpisodioId], [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE ([EpisodioId] = @AV10Id) AND ([UsuarioId] = @AV13usuarioId) ORDER BY [EpisodioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001L3,100,0,false,false )
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
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((long[]) buf[2])[0] = rslt.getLong(3) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((long[]) buf[2])[0] = rslt.getLong(3) ;
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
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
     }
  }

}

[ServiceContract(Namespace = "GeneXus.Programs.gravardadosavaliacaousuario_services")]
[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class gravardadosavaliacaousuario_services : GxRestService
{
   [OperationContract]
   [WebInvoke(Method =  "POST" ,
   	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/")]
   public void execute( short TipoComentario ,
                        String Id ,
                        String usuarioId ,
                        String Comentario ,
                        short nota )
   {
      try
      {
         if ( ! ProcessHeaders("gravardadosavaliacaousuario") )
         {
            return  ;
         }
         gravardadosavaliacaousuario worker = new gravardadosavaliacaousuario(context) ;
         worker.IsMain = RunAsMain ;
         long gxrId ;
         gxrId = (long)(NumberUtil.Val( (String)(Id), "."));
         long gxrusuarioId ;
         gxrusuarioId = (long)(NumberUtil.Val( (String)(usuarioId), "."));
         worker.execute(TipoComentario,gxrId,gxrusuarioId,Comentario,nota );
         worker.cleanup( );
      }
      catch ( Exception e )
      {
         WebException(e);
      }
      finally
      {
         Cleanup();
      }
   }

}

}
