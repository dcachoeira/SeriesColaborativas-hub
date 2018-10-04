/*
               File: VerificarEpisodiosAssistidosTemporada
        Description: Verificar Episodios Assistidos Temporada
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:56.20
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
   public class verificarepisodiosassistidostemporada : GXProcedure
   {
      public verificarepisodiosassistidostemporada( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public verificarepisodiosassistidostemporada( IGxContext context )
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
                           short aP1_Temporada ,
                           out bool aP2_Assitido )
      {
         this.AV11SerieId = aP0_SerieId;
         this.AV10Temporada = aP1_Temporada;
         this.AV9Assitido = false ;
         initialize();
         executePrivate();
         aP2_Assitido=this.AV9Assitido;
      }

      public bool executeUdp( long aP0_SerieId ,
                              short aP1_Temporada )
      {
         this.AV11SerieId = aP0_SerieId;
         this.AV10Temporada = aP1_Temporada;
         this.AV9Assitido = false ;
         initialize();
         executePrivate();
         aP2_Assitido=this.AV9Assitido;
         return AV9Assitido ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 short aP1_Temporada ,
                                 out bool aP2_Assitido )
      {
         verificarepisodiosassistidostemporada objverificarepisodiosassistidostemporada;
         objverificarepisodiosassistidostemporada = new verificarepisodiosassistidostemporada();
         objverificarepisodiosassistidostemporada.AV11SerieId = aP0_SerieId;
         objverificarepisodiosassistidostemporada.AV10Temporada = aP1_Temporada;
         objverificarepisodiosassistidostemporada.AV9Assitido = false ;
         objverificarepisodiosassistidostemporada.context.SetSubmitInitialConfig(context);
         objverificarepisodiosassistidostemporada.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objverificarepisodiosassistidostemporada);
         aP2_Assitido=this.AV9Assitido;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((verificarepisodiosassistidostemporada)stateInfo).executePrivate();
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
         /* Using cursor P001K2 */
         pr_default.execute(0, new Object[] {AV11SerieId, AV10Temporada});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A7EpisodioId = P001K2_A7EpisodioId[0];
            A51EpisodioInativo = P001K2_A51EpisodioInativo[0];
            A42EpisodioTemporada = P001K2_A42EpisodioTemporada[0];
            A1SerieId = P001K2_A1SerieId[0];
            A20UsuarioEpisodioAssistido = P001K2_A20UsuarioEpisodioAssistido[0];
            A18UsuarioEpisodioId = P001K2_A18UsuarioEpisodioId[0];
            A51EpisodioInativo = P001K2_A51EpisodioInativo[0];
            A42EpisodioTemporada = P001K2_A42EpisodioTemporada[0];
            A1SerieId = P001K2_A1SerieId[0];
            if ( ! A20UsuarioEpisodioAssistido )
            {
               AV9Assitido = false;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            else
            {
               AV9Assitido = true;
            }
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
         P001K2_A7EpisodioId = new long[1] ;
         P001K2_A51EpisodioInativo = new bool[] {false} ;
         P001K2_A42EpisodioTemporada = new short[1] ;
         P001K2_A1SerieId = new long[1] ;
         P001K2_A20UsuarioEpisodioAssistido = new bool[] {false} ;
         P001K2_A18UsuarioEpisodioId = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.verificarepisodiosassistidostemporada__default(),
            new Object[][] {
                new Object[] {
               P001K2_A7EpisodioId, P001K2_A51EpisodioInativo, P001K2_A42EpisodioTemporada, P001K2_A1SerieId, P001K2_A20UsuarioEpisodioAssistido, P001K2_A18UsuarioEpisodioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV10Temporada ;
      private short A42EpisodioTemporada ;
      private long AV11SerieId ;
      private long A7EpisodioId ;
      private long A1SerieId ;
      private long A18UsuarioEpisodioId ;
      private String scmdbuf ;
      private bool AV9Assitido ;
      private bool A51EpisodioInativo ;
      private bool A20UsuarioEpisodioAssistido ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001K2_A7EpisodioId ;
      private bool[] P001K2_A51EpisodioInativo ;
      private short[] P001K2_A42EpisodioTemporada ;
      private long[] P001K2_A1SerieId ;
      private bool[] P001K2_A20UsuarioEpisodioAssistido ;
      private long[] P001K2_A18UsuarioEpisodioId ;
      private bool aP2_Assitido ;
   }

   public class verificarepisodiosassistidostemporada__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001K2 ;
          prmP001K2 = new Object[] {
          new Object[] {"@AV11SerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV10Temporada",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001K2", "SELECT T1.[EpisodioId], T2.[EpisodioInativo], T2.[EpisodioTemporada], T2.[SerieId], T1.[UsuarioEpisodioAssistido], T1.[UsuarioEpisodioId] FROM ([UsuarioEpisodio] T1 WITH (NOLOCK) INNER JOIN [Episodio] T2 WITH (NOLOCK) ON T2.[EpisodioId] = T1.[EpisodioId]) WHERE (Not T2.[EpisodioInativo] = 1) AND (T2.[SerieId] = @AV11SerieId) AND (T2.[EpisodioTemporada] = @AV10Temporada) ORDER BY T1.[UsuarioEpisodioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001K2,100,0,false,false )
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
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((bool[]) buf[4])[0] = rslt.getBool(5) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
