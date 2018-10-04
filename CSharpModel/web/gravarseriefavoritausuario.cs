/*
               File: GravarSerieFavoritaUsuario
        Description: Gravar Serie Favorita Usuario
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:39:17.17
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
   public class gravarseriefavoritausuario : GXProcedure
   {
      public gravarseriefavoritausuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gravarseriefavoritausuario( IGxContext context )
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
                           bool aP2_Favorito )
      {
         this.AV10SerieId = aP0_SerieId;
         this.AV8UsuarioGamGuid = aP1_UsuarioGamGuid;
         this.AV13Favorito = aP2_Favorito;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_SerieId ,
                                 String aP1_UsuarioGamGuid ,
                                 bool aP2_Favorito )
      {
         gravarseriefavoritausuario objgravarseriefavoritausuario;
         objgravarseriefavoritausuario = new gravarseriefavoritausuario();
         objgravarseriefavoritausuario.AV10SerieId = aP0_SerieId;
         objgravarseriefavoritausuario.AV8UsuarioGamGuid = aP1_UsuarioGamGuid;
         objgravarseriefavoritausuario.AV13Favorito = aP2_Favorito;
         objgravarseriefavoritausuario.context.SetSubmitInitialConfig(context);
         objgravarseriefavoritausuario.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgravarseriefavoritausuario);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gravarseriefavoritausuario)stateInfo).executePrivate();
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
         /* Using cursor P00182 */
         pr_default.execute(0, new Object[] {AV8UsuarioGamGuid});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A56UsuarioGamGuid = P00182_A56UsuarioGamGuid[0];
            A11UsuarioId = P00182_A11UsuarioId[0];
            AV9UsuarioId = A11UsuarioId;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         /* Using cursor P00183 */
         pr_default.execute(1, new Object[] {AV10SerieId, AV9UsuarioId});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A1SerieId = P00183_A1SerieId[0];
            A11UsuarioId = P00183_A11UsuarioId[0];
            A13UsuarioSerieId = P00183_A13UsuarioSerieId[0];
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
         AV11UsuarioSerie.gxTpr_Usuarioseriefavorita = AV13Favorito;
         AV11UsuarioSerie.Save();
         if ( ! AV11UsuarioSerie.Fail() )
         {
            pr_gam.commit( "GravarSerieFavoritaUsuario");
            pr_default.commit( "GravarSerieFavoritaUsuario");
         }
         else
         {
            GX_msglist.addItem("Erro ao gravar usuário série: "+((SdtMessages_Message)AV11UsuarioSerie.GetMessages().Item(1)).gxTpr_Description);
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
         P00182_A56UsuarioGamGuid = new String[] {""} ;
         P00182_A11UsuarioId = new long[1] ;
         A56UsuarioGamGuid = "";
         P00183_A1SerieId = new long[1] ;
         P00183_A11UsuarioId = new long[1] ;
         P00183_A13UsuarioSerieId = new long[1] ;
         AV11UsuarioSerie = new SdtUsuarioSerie(context);
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gravarseriefavoritausuario__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gravarseriefavoritausuario__default(),
            new Object[][] {
                new Object[] {
               P00182_A56UsuarioGamGuid, P00182_A11UsuarioId
               }
               , new Object[] {
               P00183_A1SerieId, P00183_A11UsuarioId, P00183_A13UsuarioSerieId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV10SerieId ;
      private long A11UsuarioId ;
      private long AV9UsuarioId ;
      private long A1SerieId ;
      private long A13UsuarioSerieId ;
      private long AV12UsuarioSerieId ;
      private String AV8UsuarioGamGuid ;
      private String scmdbuf ;
      private String A56UsuarioGamGuid ;
      private bool AV13Favorito ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00182_A56UsuarioGamGuid ;
      private long[] P00182_A11UsuarioId ;
      private long[] P00183_A1SerieId ;
      private long[] P00183_A11UsuarioId ;
      private long[] P00183_A13UsuarioSerieId ;
      private IDataStoreProvider pr_gam ;
      private SdtUsuarioSerie AV11UsuarioSerie ;
   }

   public class gravarseriefavoritausuario__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gravarseriefavoritausuario__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmP00182 ;
        prmP00182 = new Object[] {
        new Object[] {"@AV8UsuarioGamGuid",SqlDbType.Char,40,0}
        } ;
        Object[] prmP00183 ;
        prmP00183 = new Object[] {
        new Object[] {"@AV10SerieId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@AV9UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("P00182", "SELECT [UsuarioGamGuid], [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioGamGuid] = @AV8UsuarioGamGuid ORDER BY [UsuarioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00182,100,0,false,false )
           ,new CursorDef("P00183", "SELECT [SerieId], [UsuarioId], [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE ([SerieId] = @AV10SerieId) AND ([UsuarioId] = @AV9UsuarioId) ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00183,100,0,false,false )
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
     }
  }

}

[ServiceContract(Namespace = "GeneXus.Programs.gravarseriefavoritausuario_services")]
[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class gravarseriefavoritausuario_services : GxRestService
{
   [OperationContract]
   [WebInvoke(Method =  "POST" ,
   	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/")]
   public void execute( String SerieId ,
                        String UsuarioGamGuid ,
                        bool Favorito )
   {
      try
      {
         if ( ! ProcessHeaders("gravarseriefavoritausuario") )
         {
            return  ;
         }
         gravarseriefavoritausuario worker = new gravarseriefavoritausuario(context) ;
         worker.IsMain = RunAsMain ;
         long gxrSerieId ;
         gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
         worker.execute(gxrSerieId,UsuarioGamGuid,Favorito );
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
