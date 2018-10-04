/*
               File: sdsvc_WorkWithDevicesEpisodio_Episodio_List
        Description: sdsvc_WorkWithDevicesEpisodio_Episodio_List
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/13/2018 16:35:43.85
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
   public class sdsvc_workwithdevicesepisodio_episodio_list : GXProcedure
   {
      public sdsvc_workwithdevicesepisodio_episodio_list( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdsvc_workwithdevicesepisodio_episodio_list( IGxContext context )
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
         /* AfterFilterSerieId Routine */
         /* Using cursor SDSVC_WORK2 */
         pr_default.execute(0, new Object[] {AV1Pmpt_serieid});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1SerieId = SDSVC_WORK2_A1SerieId[0];
            A2SerieNome = SDSVC_WORK2_A2SerieNome[0];
            AV2Pmpt_serienome = A2SerieNome;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
      }

      public GxUnknownObjectCollection AfterFilterSerieId( long A1SerieId )
      {
         initialize();
         AV1Pmpt_serieid = A1SerieId;
         /* Execute user subroutine: AfterFilterSerieId */
         S111 ();
         GxUnknownObjectCollection gxjsonarray = new GxUnknownObjectCollection() ;
         gxjsonarray.Add(AV2Pmpt_serienome);
         /* End function AfterFilterSerieId */
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
         SDSVC_WORK2_A1SerieId = new long[1] ;
         SDSVC_WORK2_A2SerieNome = new String[] {""} ;
         A2SerieNome = "";
         AV2Pmpt_serienome = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdsvc_workwithdevicesepisodio_episodio_list__default(),
            new Object[][] {
                new Object[] {
               SDSVC_WORK2_A1SerieId, SDSVC_WORK2_A2SerieNome
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected long AV1Pmpt_serieid ;
      protected long A1SerieId ;
      protected String scmdbuf ;
      protected String A2SerieNome ;
      protected String AV2Pmpt_serienome ;
      protected IGxDataStore dsGAM ;
      protected IGxDataStore dsDefault ;
      protected IDataStoreProvider pr_default ;
      protected long[] SDSVC_WORK2_A1SerieId ;
      protected String[] SDSVC_WORK2_A2SerieNome ;
   }

   public class sdsvc_workwithdevicesepisodio_episodio_list__default : DataStoreHelperBase, IDataStoreHelper
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
              new CursorDef("SDSVC_WORK2", "SELECT [SerieId], [SerieNome] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @AV1Pmpt_serieid ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmSDSVC_WORK2,1,0,false,true )
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

 [ServiceContract(Namespace = "GeneXus.Programs.sdsvc_workwithdevicesepisodio_episodio_list_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdsvc_workwithdevicesepisodio_episodio_list_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/AfterFilterSerieId?SerieId={SerieId}")]
    public GxUnknownObjectCollection AfterFilterSerieId( String SerieId )
    {
       try
       {
          if ( ! ProcessHeaders("sdsvc_workwithdevicesepisodio_episodio_list") )
          {
             return null ;
          }
          sdsvc_workwithdevicesepisodio_episodio_list worker = new sdsvc_workwithdevicesepisodio_episodio_list(context) ;
          long gxrSerieId ;
          gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
          return  worker.AfterFilterSerieId(gxrSerieId );
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
