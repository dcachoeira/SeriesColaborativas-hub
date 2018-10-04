/*
               File: sdsvc_WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_General
        Description: sdsvc_WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_General
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:46:1.6
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
   public class sdsvc_workwithdevicesusuarioserie_usuarioserie_section_general : GXProcedure
   {
      public sdsvc_workwithdevicesusuarioserie_usuarioserie_section_general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdsvc_workwithdevicesusuarioserie_usuarioserie_section_general( IGxContext context )
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
         /* AfterAttSerieId Routine */
         /* Using cursor SDSVC_WORK2 */
         pr_default.execute(0, new Object[] {AV1Pmpt_serieid});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A48GeneroId = SDSVC_WORK2_A48GeneroId[0];
            A1SerieId = SDSVC_WORK2_A1SerieId[0];
            A40000SerieImagem_GXI = SDSVC_WORK2_A40000SerieImagem_GXI[0];
            A2SerieNome = SDSVC_WORK2_A2SerieNome[0];
            A49GeneroNome = SDSVC_WORK2_A49GeneroNome[0];
            A43SerieImagem = SDSVC_WORK2_A43SerieImagem[0];
            A49GeneroNome = SDSVC_WORK2_A49GeneroNome[0];
            AV2Pmpt_serienome = A2SerieNome;
            AV3Pmpt_serieimagem = A43SerieImagem;
            AV8Pmpt_serieimagem_GXI = A40000SerieImagem_GXI;
            AV4Pmpt_generonome = A49GeneroNome;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
      }

      public GxUnknownObjectCollection AfterAttSerieId( long A1SerieId )
      {
         initialize();
         AV1Pmpt_serieid = A1SerieId;
         /* Execute user subroutine: AfterAttSerieId */
         S111 ();
         GxUnknownObjectCollection gxjsonarray = new GxUnknownObjectCollection() ;
         gxjsonarray.Add(AV2Pmpt_serienome);
         gxjsonarray.Add((!String.IsNullOrEmpty(StringUtil.RTrim( AV3Pmpt_serieimagem)) ? PathUtil.RelativeURL( AV3Pmpt_serieimagem) : StringUtil.RTrim( AV8Pmpt_serieimagem_GXI)));
         gxjsonarray.Add(AV4Pmpt_generonome);
         /* End function AfterAttSerieId */
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
         SDSVC_WORK2_A48GeneroId = new long[1] ;
         SDSVC_WORK2_A1SerieId = new long[1] ;
         SDSVC_WORK2_A40000SerieImagem_GXI = new String[] {""} ;
         SDSVC_WORK2_A2SerieNome = new String[] {""} ;
         SDSVC_WORK2_A49GeneroNome = new String[] {""} ;
         SDSVC_WORK2_A43SerieImagem = new String[] {""} ;
         A40000SerieImagem_GXI = "";
         A2SerieNome = "";
         A49GeneroNome = "";
         A43SerieImagem = "";
         AV2Pmpt_serienome = "";
         AV3Pmpt_serieimagem = "";
         AV8Pmpt_serieimagem_GXI = "";
         AV4Pmpt_generonome = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdsvc_workwithdevicesusuarioserie_usuarioserie_section_general__default(),
            new Object[][] {
                new Object[] {
               SDSVC_WORK2_A48GeneroId, SDSVC_WORK2_A1SerieId, SDSVC_WORK2_A40000SerieImagem_GXI, SDSVC_WORK2_A2SerieNome, SDSVC_WORK2_A49GeneroNome, SDSVC_WORK2_A43SerieImagem
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected long AV1Pmpt_serieid ;
      protected long A48GeneroId ;
      protected long A1SerieId ;
      protected String scmdbuf ;
      protected String A40000SerieImagem_GXI ;
      protected String A2SerieNome ;
      protected String A49GeneroNome ;
      protected String AV2Pmpt_serienome ;
      protected String AV8Pmpt_serieimagem_GXI ;
      protected String AV4Pmpt_generonome ;
      protected String A43SerieImagem ;
      protected String AV3Pmpt_serieimagem ;
      protected IGxDataStore dsGAM ;
      protected IGxDataStore dsDefault ;
      protected IDataStoreProvider pr_default ;
      protected long[] SDSVC_WORK2_A48GeneroId ;
      protected long[] SDSVC_WORK2_A1SerieId ;
      protected String[] SDSVC_WORK2_A40000SerieImagem_GXI ;
      protected String[] SDSVC_WORK2_A2SerieNome ;
      protected String[] SDSVC_WORK2_A49GeneroNome ;
      protected String[] SDSVC_WORK2_A43SerieImagem ;
   }

   public class sdsvc_workwithdevicesusuarioserie_usuarioserie_section_general__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@AV1Pmpt_serieid",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("SDSVC_WORK2", "SELECT T1.[GeneroId], T1.[SerieId], T1.[SerieImagem_GXI], T1.[SerieNome], T2.[GeneroNome], T1.[SerieImagem] FROM ([Serie] T1 WITH (NOLOCK) INNER JOIN [Genero] T2 WITH (NOLOCK) ON T2.[GeneroId] = T1.[GeneroId]) WHERE T1.[SerieId] = @AV1Pmpt_serieid ORDER BY T1.[SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmSDSVC_WORK2,1,0,false,true )
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
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(3)) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.sdsvc_workwithdevicesusuarioserie_usuarioserie_section_general_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdsvc_workwithdevicesusuarioserie_usuarioserie_section_general_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/AfterAttSerieId?SerieId={SerieId}")]
    public GxUnknownObjectCollection AfterAttSerieId( String SerieId )
    {
       try
       {
          if ( ! ProcessHeaders("sdsvc_workwithdevicesusuarioserie_usuarioserie_section_general") )
          {
             return null ;
          }
          sdsvc_workwithdevicesusuarioserie_usuarioserie_section_general worker = new sdsvc_workwithdevicesusuarioserie_usuarioserie_section_general(context) ;
          long gxrSerieId ;
          gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
          return  worker.AfterAttSerieId(gxrSerieId );
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
