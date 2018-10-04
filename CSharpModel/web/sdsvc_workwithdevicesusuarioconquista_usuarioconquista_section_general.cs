/*
               File: sdsvc_WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_General
        Description: sdsvc_WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_General
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:31.66
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
   public class sdsvc_workwithdevicesusuarioconquista_usuarioconquista_section_general : GXProcedure
   {
      public sdsvc_workwithdevicesusuarioconquista_usuarioconquista_section_general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdsvc_workwithdevicesusuarioconquista_usuarioconquista_section_general( IGxContext context )
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
         /* AfterAttConquistaId Routine */
         /* Using cursor SDSVC_WORK2 */
         pr_default.execute(0, new Object[] {AV1Pmpt_conquistaid});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A27ConquistaId = SDSVC_WORK2_A27ConquistaId[0];
            A29ConquistaNome = SDSVC_WORK2_A29ConquistaNome[0];
            A28ConquistaPontos = SDSVC_WORK2_A28ConquistaPontos[0];
            AV2Pmpt_conquistanome = A29ConquistaNome;
            AV3Pmpt_conquistapontos = A28ConquistaPontos;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
      }

      public GxUnknownObjectCollection AfterAttConquistaId( long A27ConquistaId )
      {
         initialize();
         AV1Pmpt_conquistaid = A27ConquistaId;
         /* Execute user subroutine: AfterAttConquistaId */
         S111 ();
         GxUnknownObjectCollection gxjsonarray = new GxUnknownObjectCollection() ;
         gxjsonarray.Add(AV2Pmpt_conquistanome);
         gxjsonarray.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV3Pmpt_conquistapontos), 4, 0, ".", "")));
         /* End function AfterAttConquistaId */
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
         SDSVC_WORK2_A27ConquistaId = new long[1] ;
         SDSVC_WORK2_A29ConquistaNome = new String[] {""} ;
         SDSVC_WORK2_A28ConquistaPontos = new short[1] ;
         A29ConquistaNome = "";
         AV2Pmpt_conquistanome = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdsvc_workwithdevicesusuarioconquista_usuarioconquista_section_general__default(),
            new Object[][] {
                new Object[] {
               SDSVC_WORK2_A27ConquistaId, SDSVC_WORK2_A29ConquistaNome, SDSVC_WORK2_A28ConquistaPontos
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected short A28ConquistaPontos ;
      protected short AV3Pmpt_conquistapontos ;
      protected long AV1Pmpt_conquistaid ;
      protected long A27ConquistaId ;
      protected String scmdbuf ;
      protected String A29ConquistaNome ;
      protected String AV2Pmpt_conquistanome ;
      protected IGxDataStore dsGAM ;
      protected IGxDataStore dsDefault ;
      protected IDataStoreProvider pr_default ;
      protected long[] SDSVC_WORK2_A27ConquistaId ;
      protected String[] SDSVC_WORK2_A29ConquistaNome ;
      protected short[] SDSVC_WORK2_A28ConquistaPontos ;
   }

   public class sdsvc_workwithdevicesusuarioconquista_usuarioconquista_section_general__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@AV1Pmpt_conquistaid",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("SDSVC_WORK2", "SELECT [ConquistaId], [ConquistaNome], [ConquistaPontos] FROM [Conquista] WITH (NOLOCK) WHERE [ConquistaId] = @AV1Pmpt_conquistaid ORDER BY [ConquistaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmSDSVC_WORK2,1,0,false,true )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.sdsvc_workwithdevicesusuarioconquista_usuarioconquista_section_general_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdsvc_workwithdevicesusuarioconquista_usuarioconquista_section_general_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/AfterAttConquistaId?ConquistaId={ConquistaId}")]
    public GxUnknownObjectCollection AfterAttConquistaId( String ConquistaId )
    {
       try
       {
          if ( ! ProcessHeaders("sdsvc_workwithdevicesusuarioconquista_usuarioconquista_section_general") )
          {
             return null ;
          }
          sdsvc_workwithdevicesusuarioconquista_usuarioconquista_section_general worker = new sdsvc_workwithdevicesusuarioconquista_usuarioconquista_section_general(context) ;
          long gxrConquistaId ;
          gxrConquistaId = (long)(NumberUtil.Val( (String)(ConquistaId), "."));
          return  worker.AfterAttConquistaId(gxrConquistaId );
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
