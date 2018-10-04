/*
               File: VerificarEpisodioUsuario
        Description: Verificar Episodio Usuario
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:55.79
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class verificarepisodiousuario : GXProcedure
   {
      public verificarepisodiousuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public verificarepisodiousuario( IGxContext context )
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
                           out bool aP2_Assistido ,
                           out bool aP3_Favorito )
      {
         this.AV11UsuarioId = aP0_UsuarioId;
         this.AV8EpisodioId = aP1_EpisodioId;
         this.AV10Assistido = false ;
         this.AV9Favorito = false ;
         initialize();
         executePrivate();
         aP2_Assistido=this.AV10Assistido;
         aP3_Favorito=this.AV9Favorito;
      }

      public bool executeUdp( long aP0_UsuarioId ,
                              long aP1_EpisodioId ,
                              out bool aP2_Assistido )
      {
         this.AV11UsuarioId = aP0_UsuarioId;
         this.AV8EpisodioId = aP1_EpisodioId;
         this.AV10Assistido = false ;
         this.AV9Favorito = false ;
         initialize();
         executePrivate();
         aP2_Assistido=this.AV10Assistido;
         aP3_Favorito=this.AV9Favorito;
         return AV9Favorito ;
      }

      public void executeSubmit( long aP0_UsuarioId ,
                                 long aP1_EpisodioId ,
                                 out bool aP2_Assistido ,
                                 out bool aP3_Favorito )
      {
         verificarepisodiousuario objverificarepisodiousuario;
         objverificarepisodiousuario = new verificarepisodiousuario();
         objverificarepisodiousuario.AV11UsuarioId = aP0_UsuarioId;
         objverificarepisodiousuario.AV8EpisodioId = aP1_EpisodioId;
         objverificarepisodiousuario.AV10Assistido = false ;
         objverificarepisodiousuario.AV9Favorito = false ;
         objverificarepisodiousuario.context.SetSubmitInitialConfig(context);
         objverificarepisodiousuario.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objverificarepisodiousuario);
         aP2_Assistido=this.AV10Assistido;
         aP3_Favorito=this.AV9Favorito;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((verificarepisodiousuario)stateInfo).executePrivate();
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
         /* Using cursor P001J2 */
         pr_default.execute(0, new Object[] {AV8EpisodioId, AV11UsuarioId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A7EpisodioId = P001J2_A7EpisodioId[0];
            A11UsuarioId = P001J2_A11UsuarioId[0];
            A22UsuarioEpisodioFavorito = P001J2_A22UsuarioEpisodioFavorito[0];
            A20UsuarioEpisodioAssistido = P001J2_A20UsuarioEpisodioAssistido[0];
            A18UsuarioEpisodioId = P001J2_A18UsuarioEpisodioId[0];
            AV9Favorito = A22UsuarioEpisodioFavorito;
            AV10Assistido = A20UsuarioEpisodioAssistido;
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
         P001J2_A7EpisodioId = new long[1] ;
         P001J2_A11UsuarioId = new long[1] ;
         P001J2_A22UsuarioEpisodioFavorito = new bool[] {false} ;
         P001J2_A20UsuarioEpisodioAssistido = new bool[] {false} ;
         P001J2_A18UsuarioEpisodioId = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.verificarepisodiousuario__default(),
            new Object[][] {
                new Object[] {
               P001J2_A7EpisodioId, P001J2_A11UsuarioId, P001J2_A22UsuarioEpisodioFavorito, P001J2_A20UsuarioEpisodioAssistido, P001J2_A18UsuarioEpisodioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV11UsuarioId ;
      private long AV8EpisodioId ;
      private long A7EpisodioId ;
      private long A11UsuarioId ;
      private long A18UsuarioEpisodioId ;
      private String scmdbuf ;
      private bool AV9Favorito ;
      private bool A22UsuarioEpisodioFavorito ;
      private bool A20UsuarioEpisodioAssistido ;
      private bool AV10Assistido ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001J2_A7EpisodioId ;
      private long[] P001J2_A11UsuarioId ;
      private bool[] P001J2_A22UsuarioEpisodioFavorito ;
      private bool[] P001J2_A20UsuarioEpisodioAssistido ;
      private long[] P001J2_A18UsuarioEpisodioId ;
      private bool aP2_Assistido ;
      private bool aP3_Favorito ;
   }

   public class verificarepisodiousuario__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001J2 ;
          prmP001J2 = new Object[] {
          new Object[] {"@AV8EpisodioId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV11UsuarioId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001J2", "SELECT [EpisodioId], [UsuarioId], [UsuarioEpisodioFavorito], [UsuarioEpisodioAssistido], [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE ([EpisodioId] = @AV8EpisodioId) AND ([UsuarioId] = @AV11UsuarioId) ORDER BY [EpisodioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001J2,100,0,false,false )
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
                ((bool[]) buf[2])[0] = rslt.getBool(3) ;
                ((bool[]) buf[3])[0] = rslt.getBool(4) ;
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
                stmt.SetParameter(2, (long)parms[1]);
                return;
       }
    }

 }

}
