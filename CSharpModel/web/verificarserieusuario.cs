/*
               File: VerificarSerieUsuario
        Description: Verificar Serie Usuario
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:54.31
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
   public class verificarserieusuario : GXProcedure
   {
      public verificarserieusuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public verificarserieusuario( IGxContext context )
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
                           String aP1_usuarioGamGuid ,
                           out bool aP2_Favorita ,
                           out bool aP3_Assistido )
      {
         this.AV10SerieId = aP0_SerieId;
         this.AV9usuarioGamGuid = aP1_usuarioGamGuid;
         this.AV11Favorita = false ;
         this.AV13Assistido = false ;
         initialize();
         executePrivate();
         aP2_Favorita=this.AV11Favorita;
         aP3_Assistido=this.AV13Assistido;
      }

      public bool executeUdp( long aP0_SerieId ,
                              String aP1_usuarioGamGuid ,
                              out bool aP2_Favorita )
      {
         this.AV10SerieId = aP0_SerieId;
         this.AV9usuarioGamGuid = aP1_usuarioGamGuid;
         this.AV11Favorita = false ;
         this.AV13Assistido = false ;
         initialize();
         executePrivate();
         aP2_Favorita=this.AV11Favorita;
         aP3_Assistido=this.AV13Assistido;
         return AV13Assistido ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 String aP1_usuarioGamGuid ,
                                 out bool aP2_Favorita ,
                                 out bool aP3_Assistido )
      {
         verificarserieusuario objverificarserieusuario;
         objverificarserieusuario = new verificarserieusuario();
         objverificarserieusuario.AV10SerieId = aP0_SerieId;
         objverificarserieusuario.AV9usuarioGamGuid = aP1_usuarioGamGuid;
         objverificarserieusuario.AV11Favorita = false ;
         objverificarserieusuario.AV13Assistido = false ;
         objverificarserieusuario.context.SetSubmitInitialConfig(context);
         objverificarserieusuario.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objverificarserieusuario);
         aP2_Favorita=this.AV11Favorita;
         aP3_Assistido=this.AV13Assistido;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((verificarserieusuario)stateInfo).executePrivate();
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
         /* Using cursor P00172 */
         pr_default.execute(0, new Object[] {AV9usuarioGamGuid});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A56UsuarioGamGuid = P00172_A56UsuarioGamGuid[0];
            A11UsuarioId = P00172_A11UsuarioId[0];
            AV12UsuarioId = A11UsuarioId;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         /* Using cursor P00173 */
         pr_default.execute(1, new Object[] {AV10SerieId, AV12UsuarioId});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A1SerieId = P00173_A1SerieId[0];
            A11UsuarioId = P00173_A11UsuarioId[0];
            A15UsuarioSerieAssistida = P00173_A15UsuarioSerieAssistida[0];
            A17UsuarioSerieFavorita = P00173_A17UsuarioSerieFavorita[0];
            A13UsuarioSerieId = P00173_A13UsuarioSerieId[0];
            AV13Assistido = A15UsuarioSerieAssistida;
            AV11Favorita = A17UsuarioSerieFavorita;
            pr_default.readNext(1);
         }
         pr_default.close(1);
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
         P00172_A56UsuarioGamGuid = new String[] {""} ;
         P00172_A11UsuarioId = new long[1] ;
         A56UsuarioGamGuid = "";
         P00173_A1SerieId = new long[1] ;
         P00173_A11UsuarioId = new long[1] ;
         P00173_A15UsuarioSerieAssistida = new bool[] {false} ;
         P00173_A17UsuarioSerieFavorita = new bool[] {false} ;
         P00173_A13UsuarioSerieId = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.verificarserieusuario__default(),
            new Object[][] {
                new Object[] {
               P00172_A56UsuarioGamGuid, P00172_A11UsuarioId
               }
               , new Object[] {
               P00173_A1SerieId, P00173_A11UsuarioId, P00173_A15UsuarioSerieAssistida, P00173_A17UsuarioSerieFavorita, P00173_A13UsuarioSerieId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV10SerieId ;
      private long A11UsuarioId ;
      private long AV12UsuarioId ;
      private long A1SerieId ;
      private long A13UsuarioSerieId ;
      private String AV9usuarioGamGuid ;
      private String scmdbuf ;
      private String A56UsuarioGamGuid ;
      private bool AV13Assistido ;
      private bool A15UsuarioSerieAssistida ;
      private bool A17UsuarioSerieFavorita ;
      private bool AV11Favorita ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00172_A56UsuarioGamGuid ;
      private long[] P00172_A11UsuarioId ;
      private long[] P00173_A1SerieId ;
      private long[] P00173_A11UsuarioId ;
      private bool[] P00173_A15UsuarioSerieAssistida ;
      private bool[] P00173_A17UsuarioSerieFavorita ;
      private long[] P00173_A13UsuarioSerieId ;
      private bool aP2_Favorita ;
      private bool aP3_Assistido ;
   }

   public class verificarserieusuario__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00172 ;
          prmP00172 = new Object[] {
          new Object[] {"@AV9usuarioGamGuid",SqlDbType.Char,40,0}
          } ;
          Object[] prmP00173 ;
          prmP00173 = new Object[] {
          new Object[] {"@AV10SerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV12UsuarioId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00172", "SELECT [UsuarioGamGuid], [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioGamGuid] = @AV9usuarioGamGuid ORDER BY [UsuarioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00172,100,0,false,false )
             ,new CursorDef("P00173", "SELECT [SerieId], [UsuarioId], [UsuarioSerieAssistida], [UsuarioSerieFavorita], [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE ([SerieId] = @AV10SerieId) AND ([UsuarioId] = @AV12UsuarioId) ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00173,100,0,false,false )
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                return;
       }
    }

 }

}
