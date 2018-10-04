/*
               File: sdsvc_WorkWithDevicesNotificacao_Notificacao_List
        Description: sdsvc_WorkWithDevicesNotificacao_Notificacao_List
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:46:1.0
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
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class sdsvc_workwithdevicesnotificacao_notificacao_list : GXProcedure
   {
      public sdsvc_workwithdevicesnotificacao_notificacao_list( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdsvc_workwithdevicesnotificacao_notificacao_list( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         this.cleanup();
      }

      protected void S111( )
      {
         /* AfterFilterUsuarioId Routine */
         /* Using cursor SDSVC_WORK2 */
         pr_default.execute(0, new Object[] {AV1Pmpt_usuarioid});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11UsuarioId = SDSVC_WORK2_A11UsuarioId[0];
            A12UsuarioNome = SDSVC_WORK2_A12UsuarioNome[0];
            AV2Pmpt_usuarionome = A12UsuarioNome;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
      }

      public GxUnknownObjectCollection AfterFilterUsuarioId( long A11UsuarioId )
      {
         initialize();
         AV1Pmpt_usuarioid = A11UsuarioId;
         /* Execute user subroutine: AfterFilterUsuarioId */
         S111 ();
         GxUnknownObjectCollection gxjsonarray = new GxUnknownObjectCollection() ;
         gxjsonarray.Add(AV2Pmpt_usuarionome);
         /* End function AfterFilterUsuarioId */
         return gxjsonarray ;
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         SDSVC_WORK2_A11UsuarioId = new long[1] ;
         SDSVC_WORK2_A12UsuarioNome = new String[] {""} ;
         A12UsuarioNome = "";
         AV2Pmpt_usuarionome = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdsvc_workwithdevicesnotificacao_notificacao_list__default(),
            new Object[][] {
                new Object[] {
               SDSVC_WORK2_A11UsuarioId, SDSVC_WORK2_A12UsuarioNome
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected long AV1Pmpt_usuarioid ;
      protected long A11UsuarioId ;
      protected String scmdbuf ;
      protected String A12UsuarioNome ;
      protected String AV2Pmpt_usuarionome ;
      protected IGxDataStore dsGAM ;
      protected IGxDataStore dsDefault ;
      protected IDataStoreProvider pr_default ;
      protected long[] SDSVC_WORK2_A11UsuarioId ;
      protected String[] SDSVC_WORK2_A12UsuarioNome ;
   }

   public class sdsvc_workwithdevicesnotificacao_notificacao_list__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmSDSVC_WORK2 ;
          prmSDSVC_WORK2 = new Object[] {
          new Object[] {"@AV1Pmpt_usuarioid",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("SDSVC_WORK2", "SELECT [UsuarioId], [UsuarioNome] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @AV1Pmpt_usuarioid ORDER BY [UsuarioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmSDSVC_WORK2,1,0,false,true )
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

 [ServiceContract(Namespace = "GeneXus.Programs.sdsvc_workwithdevicesnotificacao_notificacao_list_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdsvc_workwithdevicesnotificacao_notificacao_list_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/AfterFilterUsuarioId?UsuarioId={UsuarioId}")]
    public GxUnknownObjectCollection AfterFilterUsuarioId( String UsuarioId )
    {
       try
       {
          if ( ! ProcessHeaders("sdsvc_workwithdevicesnotificacao_notificacao_list") )
          {
             return null ;
          }
          sdsvc_workwithdevicesnotificacao_notificacao_list worker = new sdsvc_workwithdevicesnotificacao_notificacao_list(context) ;
          long gxrUsuarioId ;
          gxrUsuarioId = (long)(NumberUtil.Val( (String)(UsuarioId), "."));
          return  worker.AfterFilterUsuarioId(gxrUsuarioId );
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
       return null ;
    }

 }

}
