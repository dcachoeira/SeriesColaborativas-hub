/*
               File: ObterNotaEpisodio
        Description: Obter Nota Episodio
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/28/2018 18:56:38.10
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
   public class obternotaepisodio : GXProcedure
   {
      public obternotaepisodio( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public obternotaepisodio( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_EpisodioId ,
                           out short aP1_Nota )
      {
         this.AV10EpisodioId = aP0_EpisodioId;
         this.AV9Nota = 0 ;
         initialize();
         executePrivate();
         aP1_Nota=this.AV9Nota;
      }

      public short executeUdp( long aP0_EpisodioId )
      {
         this.AV10EpisodioId = aP0_EpisodioId;
         this.AV9Nota = 0 ;
         initialize();
         executePrivate();
         aP1_Nota=this.AV9Nota;
         return AV9Nota ;
      }

      public void executeSubmit( long aP0_EpisodioId ,
                                 out short aP1_Nota )
      {
         obternotaepisodio objobternotaepisodio;
         objobternotaepisodio = new obternotaepisodio();
         objobternotaepisodio.AV10EpisodioId = aP0_EpisodioId;
         objobternotaepisodio.AV9Nota = 0 ;
         objobternotaepisodio.context.SetSubmitInitialConfig(context);
         objobternotaepisodio.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobternotaepisodio);
         aP1_Nota=this.AV9Nota;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obternotaepisodio)stateInfo).executePrivate();
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
         AV12COunt = 0;
         /* Using cursor P001M2 */
         pr_default.execute(0, new Object[] {AV10EpisodioId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A7EpisodioId = P001M2_A7EpisodioId[0];
            A19UsuarioEpisodioNota = P001M2_A19UsuarioEpisodioNota[0];
            A18UsuarioEpisodioId = P001M2_A18UsuarioEpisodioId[0];
            AV12COunt = (short)(AV12COunt+1);
            AV11Notas = A19UsuarioEpisodioNota;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV9Nota = (short)(AV11Notas/ (decimal)(AV12COunt));
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
         P001M2_A7EpisodioId = new long[1] ;
         P001M2_A19UsuarioEpisodioNota = new short[1] ;
         P001M2_A18UsuarioEpisodioId = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obternotaepisodio__default(),
            new Object[][] {
                new Object[] {
               P001M2_A7EpisodioId, P001M2_A19UsuarioEpisodioNota, P001M2_A18UsuarioEpisodioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9Nota ;
      private short AV12COunt ;
      private short A19UsuarioEpisodioNota ;
      private short AV11Notas ;
      private long AV10EpisodioId ;
      private long A7EpisodioId ;
      private long A18UsuarioEpisodioId ;
      private String scmdbuf ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001M2_A7EpisodioId ;
      private short[] P001M2_A19UsuarioEpisodioNota ;
      private long[] P001M2_A18UsuarioEpisodioId ;
      private short aP1_Nota ;
   }

   public class obternotaepisodio__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001M2 ;
          prmP001M2 = new Object[] {
          new Object[] {"@AV10EpisodioId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001M2", "SELECT [EpisodioId], [UsuarioEpisodioNota], [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE ([EpisodioId] = @AV10EpisodioId) AND (Not ([UsuarioEpisodioNota] = convert(int, 0))) ORDER BY [EpisodioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001M2,100,0,false,false )
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
       }
    }

 }

}
