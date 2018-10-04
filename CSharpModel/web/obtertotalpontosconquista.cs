/*
               File: ObterTotalPontosConquista
        Description: Obter Total Pontos Conquista
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 21:23:45.94
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
   public class obtertotalpontosconquista : GXProcedure
   {
      public obtertotalpontosconquista( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public obtertotalpontosconquista( IGxContext context )
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
                           out long aP1_QuantidadeTotal )
      {
         this.AV9UsuarioId = aP0_UsuarioId;
         this.AV8QuantidadeTotal = 0 ;
         initialize();
         executePrivate();
         aP1_QuantidadeTotal=this.AV8QuantidadeTotal;
      }

      public long executeUdp( long aP0_UsuarioId )
      {
         this.AV9UsuarioId = aP0_UsuarioId;
         this.AV8QuantidadeTotal = 0 ;
         initialize();
         executePrivate();
         aP1_QuantidadeTotal=this.AV8QuantidadeTotal;
         return AV8QuantidadeTotal ;
      }

      public void executeSubmit( long aP0_UsuarioId ,
                                 out long aP1_QuantidadeTotal )
      {
         obtertotalpontosconquista objobtertotalpontosconquista;
         objobtertotalpontosconquista = new obtertotalpontosconquista();
         objobtertotalpontosconquista.AV9UsuarioId = aP0_UsuarioId;
         objobtertotalpontosconquista.AV8QuantidadeTotal = 0 ;
         objobtertotalpontosconquista.context.SetSubmitInitialConfig(context);
         objobtertotalpontosconquista.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtertotalpontosconquista);
         aP1_QuantidadeTotal=this.AV8QuantidadeTotal;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtertotalpontosconquista)stateInfo).executePrivate();
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
         AV8QuantidadeTotal = 0;
         /* Optimized group. */
         /* Using cursor P001F2 */
         pr_default.execute(0, new Object[] {AV9UsuarioId});
         c28ConquistaPontos = P001F2_A28ConquistaPontos[0];
         pr_default.close(0);
         AV8QuantidadeTotal = (long)(AV8QuantidadeTotal+c28ConquistaPontos);
         /* End optimized group. */
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
         P001F2_A28ConquistaPontos = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtertotalpontosconquista__default(),
            new Object[][] {
                new Object[] {
               P001F2_A28ConquistaPontos
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV9UsuarioId ;
      private long AV8QuantidadeTotal ;
      private long c28ConquistaPontos ;
      private String scmdbuf ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001F2_A28ConquistaPontos ;
      private long aP1_QuantidadeTotal ;
   }

   public class obtertotalpontosconquista__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001F2 ;
          prmP001F2 = new Object[] {
          new Object[] {"@AV9UsuarioId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001F2", "SELECT SUM(T2.[ConquistaPontos]) FROM ([UsuarioConquista] T1 WITH (NOLOCK) INNER JOIN [Conquista] T2 WITH (NOLOCK) ON T2.[ConquistaId] = T1.[ConquistaId]) WHERE (T1.[UsuarioId] = @AV9UsuarioId) AND (Not (T1.[UsuarioConquistaDataHora] = convert( DATETIME, '17530101', 112 ))) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001F2,1,0,true,false )
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
