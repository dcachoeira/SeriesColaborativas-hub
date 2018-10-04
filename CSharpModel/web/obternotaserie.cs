/*
               File: ObterNotaSerie
        Description: Obter Nota Serie
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/28/2018 18:56:37.96
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
   public class obternotaserie : GXProcedure
   {
      public obternotaserie( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public obternotaserie( IGxContext context )
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
                           out short aP1_nota )
      {
         this.AV8SerieId = aP0_SerieId;
         this.AV10nota = 0 ;
         initialize();
         executePrivate();
         aP1_nota=this.AV10nota;
      }

      public short executeUdp( long aP0_SerieId )
      {
         this.AV8SerieId = aP0_SerieId;
         this.AV10nota = 0 ;
         initialize();
         executePrivate();
         aP1_nota=this.AV10nota;
         return AV10nota ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 out short aP1_nota )
      {
         obternotaserie objobternotaserie;
         objobternotaserie = new obternotaserie();
         objobternotaserie.AV8SerieId = aP0_SerieId;
         objobternotaserie.AV10nota = 0 ;
         objobternotaserie.context.SetSubmitInitialConfig(context);
         objobternotaserie.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobternotaserie);
         aP1_nota=this.AV10nota;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obternotaserie)stateInfo).executePrivate();
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
         AV12Count = 0;
         /* Optimized group. */
         /* Using cursor P001N2 */
         pr_default.execute(0, new Object[] {AV8SerieId});
         cV12Count = P001N2_AV12Count[0];
         c14UsuarioSerieNota = P001N2_A14UsuarioSerieNota[0];
         pr_default.close(0);
         AV12Count = (short)(AV12Count+cV12Count*1);
         AV11Notas = (short)(AV11Notas+c14UsuarioSerieNota);
         /* End optimized group. */
         AV10nota = (short)(AV11Notas/ (decimal)(AV12Count));
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
         P001N2_AV12Count = new short[1] ;
         P001N2_A14UsuarioSerieNota = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obternotaserie__default(),
            new Object[][] {
                new Object[] {
               P001N2_AV12Count, P001N2_A14UsuarioSerieNota
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV10nota ;
      private short AV12Count ;
      private short c14UsuarioSerieNota ;
      private short cV12Count ;
      private short AV11Notas ;
      private long AV8SerieId ;
      private String scmdbuf ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001N2_AV12Count ;
      private short[] P001N2_A14UsuarioSerieNota ;
      private short aP1_nota ;
   }

   public class obternotaserie__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001N2 ;
          prmP001N2 = new Object[] {
          new Object[] {"@AV8SerieId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001N2", "SELECT COUNT(*), SUM([UsuarioSerieNota]) FROM [UsuarioSerie] WITH (NOLOCK) WHERE ([SerieId] = @AV8SerieId) AND (Not ([UsuarioSerieNota] = convert(int, 0))) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001N2,1,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
