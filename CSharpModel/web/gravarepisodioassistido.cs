/*
               File: GravarEpisodioAssistido
        Description: Gravar Episodio Assistido
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:39:18.7
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
   public class gravarepisodioassistido : GXProcedure
   {
      public gravarepisodioassistido( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gravarepisodioassistido( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_UsuarioId ,
                           long aP1_EpisodioId ,
                           bool aP2_ASsistido )
      {
         this.AV8UsuarioId = aP0_UsuarioId;
         this.AV9EpisodioId = aP1_EpisodioId;
         this.AV13ASsistido = aP2_ASsistido;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_UsuarioId ,
                                 long aP1_EpisodioId ,
                                 bool aP2_ASsistido )
      {
         gravarepisodioassistido objgravarepisodioassistido;
         objgravarepisodioassistido = new gravarepisodioassistido();
         objgravarepisodioassistido.AV8UsuarioId = aP0_UsuarioId;
         objgravarepisodioassistido.AV9EpisodioId = aP1_EpisodioId;
         objgravarepisodioassistido.AV13ASsistido = aP2_ASsistido;
         objgravarepisodioassistido.context.SetSubmitInitialConfig(context);
         objgravarepisodioassistido.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgravarepisodioassistido);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gravarepisodioassistido)stateInfo).executePrivate();
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
         /* Using cursor P001H2 */
         pr_default.execute(0, new Object[] {AV9EpisodioId, AV8UsuarioId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A7EpisodioId = P001H2_A7EpisodioId[0];
            A11UsuarioId = P001H2_A11UsuarioId[0];
            A18UsuarioEpisodioId = P001H2_A18UsuarioEpisodioId[0];
            AV10UsuarioEpisodioId = A18UsuarioEpisodioId;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV11UsuarioEpisodio.Load(AV10UsuarioEpisodioId);
         if ( AV11UsuarioEpisodio.Fail() )
         {
            AV11UsuarioEpisodio = new SdtUsuarioEpisodio(context);
         }
         AV11UsuarioEpisodio.gxTpr_Episodioid = AV9EpisodioId;
         AV11UsuarioEpisodio.gxTpr_Usuarioid = AV8UsuarioId;
         AV11UsuarioEpisodio.gxTpr_Usuarioepisodioassistido = AV13ASsistido;
         AV11UsuarioEpisodio.Save();
         if ( ! AV11UsuarioEpisodio.Fail() )
         {
            pr_gam.commit( "GravarEpisodioAssistido");
            pr_default.commit( "GravarEpisodioAssistido");
         }
         else
         {
            new log(context ).execute(  "Erro ao gravar usuário episódio: "+((SdtMessages_Message)AV11UsuarioEpisodio.GetMessages().Item(1)).gxTpr_Description) ;
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
         P001H2_A7EpisodioId = new long[1] ;
         P001H2_A11UsuarioId = new long[1] ;
         P001H2_A18UsuarioEpisodioId = new long[1] ;
         AV11UsuarioEpisodio = new SdtUsuarioEpisodio(context);
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.gravarepisodioassistido__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gravarepisodioassistido__default(),
            new Object[][] {
                new Object[] {
               P001H2_A7EpisodioId, P001H2_A11UsuarioId, P001H2_A18UsuarioEpisodioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV8UsuarioId ;
      private long AV9EpisodioId ;
      private long A7EpisodioId ;
      private long A11UsuarioId ;
      private long A18UsuarioEpisodioId ;
      private long AV10UsuarioEpisodioId ;
      private String scmdbuf ;
      private bool AV13ASsistido ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001H2_A7EpisodioId ;
      private long[] P001H2_A11UsuarioId ;
      private long[] P001H2_A18UsuarioEpisodioId ;
      private IDataStoreProvider pr_gam ;
      private SdtUsuarioEpisodio AV11UsuarioEpisodio ;
   }

   public class gravarepisodioassistido__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class gravarepisodioassistido__default : DataStoreHelperBase, IDataStoreHelper
 {
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
        Object[] prmP001H2 ;
        prmP001H2 = new Object[] {
        new Object[] {"@AV9EpisodioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@AV8UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("P001H2", "SELECT [EpisodioId], [UsuarioId], [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE ([EpisodioId] = @AV9EpisodioId) AND ([UsuarioId] = @AV8UsuarioId) ORDER BY [EpisodioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001H2,100,0,false,false )
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
     }
  }

}

[ServiceContract(Namespace = "GeneXus.Programs.gravarepisodioassistido_services")]
[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class gravarepisodioassistido_services : GxRestService
{
   [OperationContract]
   [WebInvoke(Method =  "POST" ,
   	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/")]
   public void execute( String UsuarioId ,
                        String EpisodioId ,
                        bool ASsistido )
   {
      try
      {
         if ( ! ProcessHeaders("gravarepisodioassistido") )
         {
            return  ;
         }
         gravarepisodioassistido worker = new gravarepisodioassistido(context) ;
         worker.IsMain = RunAsMain ;
         long gxrUsuarioId ;
         gxrUsuarioId = (long)(NumberUtil.Val( (String)(UsuarioId), "."));
         long gxrEpisodioId ;
         gxrEpisodioId = (long)(NumberUtil.Val( (String)(EpisodioId), "."));
         worker.execute(gxrUsuarioId,gxrEpisodioId,ASsistido );
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
