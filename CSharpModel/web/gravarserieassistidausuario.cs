/*
               File: GravarSerieAssistidaUsuario
        Description: Gravar Serie Assistida Usuario
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:39:17.60
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
   public class gravarserieassistidausuario : GXProcedure
   {
      public gravarserieassistidausuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gravarserieassistidausuario( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_SerieId ,
                           String aP1_UsuarioGamGuid ,
                           bool aP2_Assistido )
      {
         this.AV10SerieId = aP0_SerieId;
         this.AV8UsuarioGamGuid = aP1_UsuarioGamGuid;
         this.AV14Assistido = aP2_Assistido;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_SerieId ,
                                 String aP1_UsuarioGamGuid ,
                                 bool aP2_Assistido )
      {
         gravarserieassistidausuario objgravarserieassistidausuario;
         objgravarserieassistidausuario = new gravarserieassistidausuario();
         objgravarserieassistidausuario.AV10SerieId = aP0_SerieId;
         objgravarserieassistidausuario.AV8UsuarioGamGuid = aP1_UsuarioGamGuid;
         objgravarserieassistidausuario.AV14Assistido = aP2_Assistido;
         objgravarserieassistidausuario.context.SetSubmitInitialConfig(context);
         objgravarserieassistidausuario.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgravarserieassistidausuario);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gravarserieassistidausuario)stateInfo).executePrivate();
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
         /* Using cursor P00192 */
         pr_default.execute(0, new Object[] {AV8UsuarioGamGuid});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A56UsuarioGamGuid = P00192_A56UsuarioGamGuid[0];
            A11UsuarioId = P00192_A11UsuarioId[0];
            AV9UsuarioId = A11UsuarioId;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         /* Using cursor P00193 */
         pr_default.execute(1, new Object[] {AV10SerieId, AV9UsuarioId});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A1SerieId = P00193_A1SerieId[0];
            A11UsuarioId = P00193_A11UsuarioId[0];
            A13UsuarioSerieId = P00193_A13UsuarioSerieId[0];
            AV12UsuarioSerieId = A13UsuarioSerieId;
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV11UsuarioSerie.Load(AV12UsuarioSerieId);
         if ( AV11UsuarioSerie.Fail() )
         {
            AV11UsuarioSerie = new SdtUsuarioSerie(context);
         }
         AV11UsuarioSerie.gxTpr_Serieid = AV10SerieId;
         AV11UsuarioSerie.gxTpr_Usuarioid = AV9UsuarioId;
         AV11UsuarioSerie.gxTpr_Usuarioserieassistida = AV14Assistido;
         AV11UsuarioSerie.Save();
         if ( ! AV11UsuarioSerie.Fail() )
         {
            pr_gam.commit( "GravarSerieAssistidaUsuario");
            pr_default.commit( "GravarSerieAssistidaUsuario");
            /* Using cursor P00194 */
            pr_default.execute(2, new Object[] {AV10SerieId});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A51EpisodioInativo = P00194_A51EpisodioInativo[0];
               A1SerieId = P00194_A1SerieId[0];
               A7EpisodioId = P00194_A7EpisodioId[0];
               AV16EpisodiosId.Add(A7EpisodioId, 0);
               pr_default.readNext(2);
            }
            pr_default.close(2);
            AV19i = 1;
            while ( AV19i <= AV16EpisodiosId.Count )
            {
               AV18UsuarioEpisodioId = 0;
               /* Using cursor P00195 */
               pr_default.execute(3, new Object[] {AV9UsuarioId});
               while ( (pr_default.getStatus(3) != 101) )
               {
                  A7EpisodioId = P00195_A7EpisodioId[0];
                  A11UsuarioId = P00195_A11UsuarioId[0];
                  A18UsuarioEpisodioId = P00195_A18UsuarioEpisodioId[0];
                  if ( A7EpisodioId == AV16EpisodiosId.GetNumeric(AV19i) )
                  {
                     AV18UsuarioEpisodioId = A18UsuarioEpisodioId;
                  }
                  pr_default.readNext(3);
               }
               pr_default.close(3);
               AV17UsuarioEpisodio.Load(AV18UsuarioEpisodioId);
               if ( AV17UsuarioEpisodio.Fail() )
               {
                  AV17UsuarioEpisodio = new SdtUsuarioEpisodio(context);
               }
               AV17UsuarioEpisodio.gxTpr_Episodioid = (long)(AV16EpisodiosId.GetNumeric(AV19i));
               AV17UsuarioEpisodio.gxTpr_Usuarioid = AV9UsuarioId;
               AV17UsuarioEpisodio.gxTpr_Usuarioepisodioassistido = AV14Assistido;
               AV17UsuarioEpisodio.Save();
               if ( ! AV17UsuarioEpisodio.Fail() )
               {
                  pr_gam.commit( "GravarSerieAssistidaUsuario");
                  pr_default.commit( "GravarSerieAssistidaUsuario");
               }
               else
               {
                  new log(context ).execute(  "Erro ao gravar usuário episódio: "+((SdtMessages_Message)AV17UsuarioEpisodio.GetMessages().Item(1)).gxTpr_Description) ;
                  if (true) break;
               }
               AV19i = (short)(AV19i+1);
            }
         }
         else
         {
            new log(context ).execute(  "Erro ao gravar usuário série: "+((SdtMessages_Message)AV11UsuarioSerie.GetMessages().Item(1)).gxTpr_Description) ;
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
         P00192_A56UsuarioGamGuid = new String[] {""} ;
         P00192_A11UsuarioId = new long[1] ;
         A56UsuarioGamGuid = "";
         P00193_A1SerieId = new long[1] ;
         P00193_A11UsuarioId = new long[1] ;
         P00193_A13UsuarioSerieId = new long[1] ;
         AV11UsuarioSerie = new SdtUsuarioSerie(context);
         P00194_A51EpisodioInativo = new bool[] {false} ;
         P00194_A1SerieId = new long[1] ;
         P00194_A7EpisodioId = new long[1] ;
         AV16EpisodiosId = new GxSimpleCollection<long>();
         P00195_A7EpisodioId = new long[1] ;
         P00195_A11UsuarioId = new long[1] ;
         P00195_A18UsuarioEpisodioId = new long[1] ;
         AV17UsuarioEpisodio = new SdtUsuarioEpisodio(context);
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gravarserieassistidausuario__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gravarserieassistidausuario__default(),
            new Object[][] {
                new Object[] {
               P00192_A56UsuarioGamGuid, P00192_A11UsuarioId
               }
               , new Object[] {
               P00193_A1SerieId, P00193_A11UsuarioId, P00193_A13UsuarioSerieId
               }
               , new Object[] {
               P00194_A51EpisodioInativo, P00194_A1SerieId, P00194_A7EpisodioId
               }
               , new Object[] {
               P00195_A7EpisodioId, P00195_A11UsuarioId, P00195_A18UsuarioEpisodioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV19i ;
      private long AV10SerieId ;
      private long A11UsuarioId ;
      private long AV9UsuarioId ;
      private long A1SerieId ;
      private long A13UsuarioSerieId ;
      private long AV12UsuarioSerieId ;
      private long A7EpisodioId ;
      private long AV18UsuarioEpisodioId ;
      private long A18UsuarioEpisodioId ;
      private String AV8UsuarioGamGuid ;
      private String scmdbuf ;
      private String A56UsuarioGamGuid ;
      private bool AV14Assistido ;
      private bool A51EpisodioInativo ;
      private GxSimpleCollection<long> AV16EpisodiosId ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00192_A56UsuarioGamGuid ;
      private long[] P00192_A11UsuarioId ;
      private long[] P00193_A1SerieId ;
      private long[] P00193_A11UsuarioId ;
      private long[] P00193_A13UsuarioSerieId ;
      private IDataStoreProvider pr_gam ;
      private bool[] P00194_A51EpisodioInativo ;
      private long[] P00194_A1SerieId ;
      private long[] P00194_A7EpisodioId ;
      private long[] P00195_A7EpisodioId ;
      private long[] P00195_A11UsuarioId ;
      private long[] P00195_A18UsuarioEpisodioId ;
      private SdtUsuarioSerie AV11UsuarioSerie ;
      private SdtUsuarioEpisodio AV17UsuarioEpisodio ;
   }

   public class gravarserieassistidausuario__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gravarserieassistidausuario__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmP00192 ;
        prmP00192 = new Object[] {
        new Object[] {"@AV8UsuarioGamGuid",SqlDbType.Char,40,0}
        } ;
        Object[] prmP00193 ;
        prmP00193 = new Object[] {
        new Object[] {"@AV10SerieId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@AV9UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmP00194 ;
        prmP00194 = new Object[] {
        new Object[] {"@AV10SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmP00195 ;
        prmP00195 = new Object[] {
        new Object[] {"@AV9UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("P00192", "SELECT [UsuarioGamGuid], [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioGamGuid] = @AV8UsuarioGamGuid ORDER BY [UsuarioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00192,100,0,false,false )
           ,new CursorDef("P00193", "SELECT [SerieId], [UsuarioId], [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE ([SerieId] = @AV10SerieId) AND ([UsuarioId] = @AV9UsuarioId) ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00193,100,0,false,false )
           ,new CursorDef("P00194", "SELECT [EpisodioInativo], [SerieId], [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE ([SerieId] = @AV10SerieId) AND (Not [EpisodioInativo] = 1) ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00194,100,0,false,false )
           ,new CursorDef("P00195", "SELECT [EpisodioId], [UsuarioId], [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE [UsuarioId] = @AV9UsuarioId ORDER BY [UsuarioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00195,100,0,false,false )
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
              ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((long[]) buf[2])[0] = rslt.getLong(3) ;
              return;
           case 2 :
              ((bool[]) buf[0])[0] = rslt.getBool(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((long[]) buf[2])[0] = rslt.getLong(3) ;
              return;
           case 3 :
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
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
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

[ServiceContract(Namespace = "GeneXus.Programs.gravarserieassistidausuario_services")]
[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class gravarserieassistidausuario_services : GxRestService
{
   [OperationContract]
   [WebInvoke(Method =  "POST" ,
   	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/")]
   public void execute( String SerieId ,
                        String UsuarioGamGuid ,
                        bool Assistido )
   {
      try
      {
         if ( ! ProcessHeaders("gravarserieassistidausuario") )
         {
            return  ;
         }
         gravarserieassistidausuario worker = new gravarserieassistidausuario(context) ;
         worker.IsMain = RunAsMain ;
         long gxrSerieId ;
         gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
         worker.execute(gxrSerieId,UsuarioGamGuid,Assistido );
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
