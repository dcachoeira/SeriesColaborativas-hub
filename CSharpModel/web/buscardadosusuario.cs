/*
               File: BuscarDadosUsuario
        Description: Buscar Dados Usuario
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 20:3:14.95
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
   public class buscardadosusuario : GXProcedure
   {
      public buscardadosusuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public buscardadosusuario( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_usuarioId ,
                           out String aP1_UsuarioNome ,
                           out String aP2_UsuarioTitulo ,
                           out String aP3_ImagemUsuario )
      {
         this.AV9usuarioId = aP0_usuarioId;
         this.AV8UsuarioNome = "" ;
         this.AV11UsuarioTitulo = "" ;
         this.AV10ImagemUsuario = "" ;
         initialize();
         executePrivate();
         aP1_UsuarioNome=this.AV8UsuarioNome;
         aP2_UsuarioTitulo=this.AV11UsuarioTitulo;
         aP3_ImagemUsuario=this.AV10ImagemUsuario;
      }

      public String executeUdp( long aP0_usuarioId ,
                                out String aP1_UsuarioNome ,
                                out String aP2_UsuarioTitulo )
      {
         this.AV9usuarioId = aP0_usuarioId;
         this.AV8UsuarioNome = "" ;
         this.AV11UsuarioTitulo = "" ;
         this.AV10ImagemUsuario = "" ;
         initialize();
         executePrivate();
         aP1_UsuarioNome=this.AV8UsuarioNome;
         aP2_UsuarioTitulo=this.AV11UsuarioTitulo;
         aP3_ImagemUsuario=this.AV10ImagemUsuario;
         return AV10ImagemUsuario ;
      }

      public void executeSubmit( long aP0_usuarioId ,
                                 out String aP1_UsuarioNome ,
                                 out String aP2_UsuarioTitulo ,
                                 out String aP3_ImagemUsuario )
      {
         buscardadosusuario objbuscardadosusuario;
         objbuscardadosusuario = new buscardadosusuario();
         objbuscardadosusuario.AV9usuarioId = aP0_usuarioId;
         objbuscardadosusuario.AV8UsuarioNome = "" ;
         objbuscardadosusuario.AV11UsuarioTitulo = "" ;
         objbuscardadosusuario.AV10ImagemUsuario = "" ;
         objbuscardadosusuario.context.SetSubmitInitialConfig(context);
         objbuscardadosusuario.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbuscardadosusuario);
         aP1_UsuarioNome=this.AV8UsuarioNome;
         aP2_UsuarioTitulo=this.AV11UsuarioTitulo;
         aP3_ImagemUsuario=this.AV10ImagemUsuario;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((buscardadosusuario)stateInfo).executePrivate();
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
         /* Using cursor P001D2 */
         pr_default.execute(0, new Object[] {AV9usuarioId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11UsuarioId = P001D2_A11UsuarioId[0];
            A12UsuarioNome = P001D2_A12UsuarioNome[0];
            AV8UsuarioNome = A12UsuarioNome;
            AV10ImagemUsuario = "https://scontent.fbnu4-1.fna.fbcdn.net/v/t1.0-9/12141731_929537667135150_7442395249515377458_n.jpg?_nc_cat=0&oh=c9fd087f5d93df564a24198a7c08548a&oe=5C34A50E";
            AV15Imagemusuario_GXI = GXDbFile.PathToUrl( "https://scontent.fbnu4-1.fna.fbcdn.net/v/t1.0-9/12141731_929537667135150_7442395249515377458_n.jpg?_nc_cat=0&oh=c9fd087f5d93df564a24198a7c08548a&oe=5C34A50E");
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         AV16GXLvl8 = 0;
         /* Using cursor P001D3 */
         pr_default.execute(1, new Object[] {AV9usuarioId});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A27ConquistaId = P001D3_A27ConquistaId[0];
            A11UsuarioId = P001D3_A11UsuarioId[0];
            A29ConquistaNome = P001D3_A29ConquistaNome[0];
            A28ConquistaPontos = P001D3_A28ConquistaPontos[0];
            A30UsuarioConquistaId = P001D3_A30UsuarioConquistaId[0];
            A29ConquistaNome = P001D3_A29ConquistaNome[0];
            A28ConquistaPontos = P001D3_A28ConquistaPontos[0];
            AV16GXLvl8 = 1;
            AV11UsuarioTitulo = A29ConquistaNome;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(1);
         }
         pr_default.close(1);
         if ( AV16GXLvl8 == 0 )
         {
            AV11UsuarioTitulo = "Iniciante";
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
         P001D2_A11UsuarioId = new long[1] ;
         P001D2_A12UsuarioNome = new String[] {""} ;
         A12UsuarioNome = "";
         AV15Imagemusuario_GXI = "";
         P001D3_A27ConquistaId = new long[1] ;
         P001D3_A11UsuarioId = new long[1] ;
         P001D3_A29ConquistaNome = new String[] {""} ;
         P001D3_A28ConquistaPontos = new short[1] ;
         P001D3_A30UsuarioConquistaId = new long[1] ;
         A29ConquistaNome = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.buscardadosusuario__default(),
            new Object[][] {
                new Object[] {
               P001D2_A11UsuarioId, P001D2_A12UsuarioNome
               }
               , new Object[] {
               P001D3_A27ConquistaId, P001D3_A11UsuarioId, P001D3_A29ConquistaNome, P001D3_A28ConquistaPontos, P001D3_A30UsuarioConquistaId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV16GXLvl8 ;
      private short A28ConquistaPontos ;
      private long AV9usuarioId ;
      private long A11UsuarioId ;
      private long A27ConquistaId ;
      private long A30UsuarioConquistaId ;
      private String scmdbuf ;
      private String A12UsuarioNome ;
      private String AV8UsuarioNome ;
      private String AV15Imagemusuario_GXI ;
      private String A29ConquistaNome ;
      private String AV11UsuarioTitulo ;
      private String AV10ImagemUsuario ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001D2_A11UsuarioId ;
      private String[] P001D2_A12UsuarioNome ;
      private long[] P001D3_A27ConquistaId ;
      private long[] P001D3_A11UsuarioId ;
      private String[] P001D3_A29ConquistaNome ;
      private short[] P001D3_A28ConquistaPontos ;
      private long[] P001D3_A30UsuarioConquistaId ;
      private String aP1_UsuarioNome ;
      private String aP2_UsuarioTitulo ;
      private String aP3_ImagemUsuario ;
   }

   public class buscardadosusuario__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001D2 ;
          prmP001D2 = new Object[] {
          new Object[] {"@AV9usuarioId",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP001D3 ;
          prmP001D3 = new Object[] {
          new Object[] {"@AV9usuarioId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001D2", "SELECT [UsuarioId], [UsuarioNome] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @AV9usuarioId ORDER BY [UsuarioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001D2,1,0,false,true )
             ,new CursorDef("P001D3", "SELECT TOP 1 T1.[ConquistaId], T1.[UsuarioId], T2.[ConquistaNome], T2.[ConquistaPontos], T1.[UsuarioConquistaId] FROM ([UsuarioConquista] T1 WITH (NOLOCK) INNER JOIN [Conquista] T2 WITH (NOLOCK) ON T2.[ConquistaId] = T1.[ConquistaId]) WHERE T1.[UsuarioId] = @AV9usuarioId ORDER BY T2.[ConquistaPontos] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001D3,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
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
                return;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.buscardadosusuario_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class buscardadosusuario_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String usuarioId ,
                         out String UsuarioNome ,
                         out String UsuarioTitulo ,
                         out String ImagemUsuario )
    {
       UsuarioNome = "" ;
       UsuarioTitulo = "" ;
       ImagemUsuario = "" ;
       try
       {
          if ( ! ProcessHeaders("buscardadosusuario") )
          {
             return  ;
          }
          buscardadosusuario worker = new buscardadosusuario(context) ;
          worker.IsMain = RunAsMain ;
          long gxrusuarioId ;
          gxrusuarioId = (long)(NumberUtil.Val( (String)(usuarioId), "."));
          worker.execute(gxrusuarioId,out UsuarioNome,out UsuarioTitulo,out ImagemUsuario );
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
