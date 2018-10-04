/*
               File: BuscarConquistasUsuario
        Description: Buscar Conquistas Usuario
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:3:14.43
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
   public class buscarconquistasusuario : GXProcedure
   {
      public buscarconquistasusuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public buscarconquistasusuario( IGxContext context )
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
                           out GxSimpleCollection<long> aP1_ConquistasId )
      {
         this.AV8UsuarioId = aP0_UsuarioId;
         this.AV10ConquistasId = new GxSimpleCollection<long>() ;
         initialize();
         executePrivate();
         aP1_ConquistasId=this.AV10ConquistasId;
      }

      public GxSimpleCollection<long> executeUdp( long aP0_UsuarioId )
      {
         this.AV8UsuarioId = aP0_UsuarioId;
         this.AV10ConquistasId = new GxSimpleCollection<long>() ;
         initialize();
         executePrivate();
         aP1_ConquistasId=this.AV10ConquistasId;
         return AV10ConquistasId ;
      }

      public void executeSubmit( long aP0_UsuarioId ,
                                 out GxSimpleCollection<long> aP1_ConquistasId )
      {
         buscarconquistasusuario objbuscarconquistasusuario;
         objbuscarconquistasusuario = new buscarconquistasusuario();
         objbuscarconquistasusuario.AV8UsuarioId = aP0_UsuarioId;
         objbuscarconquistasusuario.AV10ConquistasId = new GxSimpleCollection<long>() ;
         objbuscarconquistasusuario.context.SetSubmitInitialConfig(context);
         objbuscarconquistasusuario.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbuscarconquistasusuario);
         aP1_ConquistasId=this.AV10ConquistasId;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((buscarconquistasusuario)stateInfo).executePrivate();
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
         /* Using cursor P001Q2 */
         pr_default.execute(0, new Object[] {AV8UsuarioId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11UsuarioId = P001Q2_A11UsuarioId[0];
            A27ConquistaId = P001Q2_A27ConquistaId[0];
            A30UsuarioConquistaId = P001Q2_A30UsuarioConquistaId[0];
            AV10ConquistasId.Add(A27ConquistaId, 0);
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
         P001Q2_A11UsuarioId = new long[1] ;
         P001Q2_A27ConquistaId = new long[1] ;
         P001Q2_A30UsuarioConquistaId = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.buscarconquistasusuario__default(),
            new Object[][] {
                new Object[] {
               P001Q2_A11UsuarioId, P001Q2_A27ConquistaId, P001Q2_A30UsuarioConquistaId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV8UsuarioId ;
      private long A11UsuarioId ;
      private long A27ConquistaId ;
      private long A30UsuarioConquistaId ;
      private String scmdbuf ;
      private GxSimpleCollection<long> AV10ConquistasId ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001Q2_A11UsuarioId ;
      private long[] P001Q2_A27ConquistaId ;
      private long[] P001Q2_A30UsuarioConquistaId ;
      private GxSimpleCollection<long> aP1_ConquistasId ;
   }

   public class buscarconquistasusuario__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001Q2 ;
          prmP001Q2 = new Object[] {
          new Object[] {"@AV8UsuarioId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001Q2", "SELECT [UsuarioId], [ConquistaId], [UsuarioConquistaId] FROM [UsuarioConquista] WITH (NOLOCK) WHERE [UsuarioId] = @AV8UsuarioId ORDER BY [UsuarioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Q2,100,0,false,false )
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
                return;
       }
    }

 }

}
