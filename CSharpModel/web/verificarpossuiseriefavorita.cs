/*
               File: VerificarPossuiSerieFavorita
        Description: Verificar Possui Serie Favorita
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:54.78
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
   public class verificarpossuiseriefavorita : GXProcedure
   {
      public verificarpossuiseriefavorita( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public verificarpossuiseriefavorita( IGxContext context )
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
                           out bool aP1_Possui )
      {
         this.AV9UsuarioId = aP0_UsuarioId;
         this.AV8Possui = false ;
         initialize();
         executePrivate();
         aP1_Possui=this.AV8Possui;
      }

      public bool executeUdp( long aP0_UsuarioId )
      {
         this.AV9UsuarioId = aP0_UsuarioId;
         this.AV8Possui = false ;
         initialize();
         executePrivate();
         aP1_Possui=this.AV8Possui;
         return AV8Possui ;
      }

      public void executeSubmit( long aP0_UsuarioId ,
                                 out bool aP1_Possui )
      {
         verificarpossuiseriefavorita objverificarpossuiseriefavorita;
         objverificarpossuiseriefavorita = new verificarpossuiseriefavorita();
         objverificarpossuiseriefavorita.AV9UsuarioId = aP0_UsuarioId;
         objverificarpossuiseriefavorita.AV8Possui = false ;
         objverificarpossuiseriefavorita.context.SetSubmitInitialConfig(context);
         objverificarpossuiseriefavorita.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objverificarpossuiseriefavorita);
         aP1_Possui=this.AV8Possui;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((verificarpossuiseriefavorita)stateInfo).executePrivate();
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
         AV8Possui = false;
         /* Using cursor P001B2 */
         pr_default.execute(0, new Object[] {AV9UsuarioId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A17UsuarioSerieFavorita = P001B2_A17UsuarioSerieFavorita[0];
            A11UsuarioId = P001B2_A11UsuarioId[0];
            A13UsuarioSerieId = P001B2_A13UsuarioSerieId[0];
            AV8Possui = true;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
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
         P001B2_A17UsuarioSerieFavorita = new bool[] {false} ;
         P001B2_A11UsuarioId = new long[1] ;
         P001B2_A13UsuarioSerieId = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.verificarpossuiseriefavorita__default(),
            new Object[][] {
                new Object[] {
               P001B2_A17UsuarioSerieFavorita, P001B2_A11UsuarioId, P001B2_A13UsuarioSerieId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV9UsuarioId ;
      private long A11UsuarioId ;
      private long A13UsuarioSerieId ;
      private String scmdbuf ;
      private bool AV8Possui ;
      private bool A17UsuarioSerieFavorita ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private bool[] P001B2_A17UsuarioSerieFavorita ;
      private long[] P001B2_A11UsuarioId ;
      private long[] P001B2_A13UsuarioSerieId ;
      private bool aP1_Possui ;
   }

   public class verificarpossuiseriefavorita__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001B2 ;
          prmP001B2 = new Object[] {
          new Object[] {"@AV9UsuarioId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001B2", "SELECT TOP 1 [UsuarioSerieFavorita], [UsuarioId], [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE ([UsuarioId] = @AV9UsuarioId) AND ([UsuarioSerieFavorita] = 1) ORDER BY [UsuarioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B2,1,0,false,true )
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
                ((bool[]) buf[0])[0] = rslt.getBool(1) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.verificarpossuiseriefavorita_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class verificarpossuiseriefavorita_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String UsuarioId ,
                         out bool Possui )
    {
       Possui = false ;
       try
       {
          if ( ! ProcessHeaders("verificarpossuiseriefavorita") )
          {
             return  ;
          }
          verificarpossuiseriefavorita worker = new verificarpossuiseriefavorita(context) ;
          worker.IsMain = RunAsMain ;
          long gxrUsuarioId ;
          gxrUsuarioId = (long)(NumberUtil.Val( (String)(UsuarioId), "."));
          worker.execute(gxrUsuarioId,out Possui );
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
