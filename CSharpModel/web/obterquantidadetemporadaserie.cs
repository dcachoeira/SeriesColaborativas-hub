/*
               File: ObterQuantidadeTemporadaSerie
        Description: Obter Quantidade Temporada Serie
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:7.81
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
   public class obterquantidadetemporadaserie : GXProcedure
   {
      public obterquantidadetemporadaserie( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public obterquantidadetemporadaserie( IGxContext context )
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
                           out short aP1_QuantidadeTemporada )
      {
         this.AV9SerieId = aP0_SerieId;
         this.AV8QuantidadeTemporada = 0 ;
         initialize();
         executePrivate();
         aP1_QuantidadeTemporada=this.AV8QuantidadeTemporada;
      }

      public short executeUdp( long aP0_SerieId )
      {
         this.AV9SerieId = aP0_SerieId;
         this.AV8QuantidadeTemporada = 0 ;
         initialize();
         executePrivate();
         aP1_QuantidadeTemporada=this.AV8QuantidadeTemporada;
         return AV8QuantidadeTemporada ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 out short aP1_QuantidadeTemporada )
      {
         obterquantidadetemporadaserie objobterquantidadetemporadaserie;
         objobterquantidadetemporadaserie = new obterquantidadetemporadaserie();
         objobterquantidadetemporadaserie.AV9SerieId = aP0_SerieId;
         objobterquantidadetemporadaserie.AV8QuantidadeTemporada = 0 ;
         objobterquantidadetemporadaserie.context.SetSubmitInitialConfig(context);
         objobterquantidadetemporadaserie.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobterquantidadetemporadaserie);
         aP1_QuantidadeTemporada=this.AV8QuantidadeTemporada;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obterquantidadetemporadaserie)stateInfo).executePrivate();
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
         /* Using cursor P001C2 */
         pr_default.execute(0, new Object[] {AV9SerieId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1SerieId = P001C2_A1SerieId[0];
            A3SerieQuantidadeTemporadas = P001C2_A3SerieQuantidadeTemporadas[0];
            AV8QuantidadeTemporada = A3SerieQuantidadeTemporadas;
            /* Exiting from a For First loop. */
            if (true) break;
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
         P001C2_A1SerieId = new long[1] ;
         P001C2_A3SerieQuantidadeTemporadas = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obterquantidadetemporadaserie__default(),
            new Object[][] {
                new Object[] {
               P001C2_A1SerieId, P001C2_A3SerieQuantidadeTemporadas
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8QuantidadeTemporada ;
      private short A3SerieQuantidadeTemporadas ;
      private long AV9SerieId ;
      private long A1SerieId ;
      private String scmdbuf ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001C2_A1SerieId ;
      private short[] P001C2_A3SerieQuantidadeTemporadas ;
      private short aP1_QuantidadeTemporada ;
   }

   public class obterquantidadetemporadaserie__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001C2 ;
          prmP001C2 = new Object[] {
          new Object[] {"@AV9SerieId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001C2", "SELECT [SerieId], [SerieQuantidadeTemporadas] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @AV9SerieId ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001C2,1,0,false,true )
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
