/*
               File: WorkWithDevicesEpisodio_Episodio_Detail
        Description: WorkWithDevicesEpisodio_Episodio_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 19:40:18.91
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
   public class workwithdevicesepisodio_episodio_detail : GXProcedure
   {
      public workwithdevicesepisodio_episodio_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesepisodio_episodio_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_EpisodioId ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesEpisodio_Episodio_DetailSdt aP2_GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt )
      {
         this.A7EpisodioId = aP0_EpisodioId;
         this.AV13gxid = aP1_gxid;
         this.AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt = new SdtWorkWithDevicesEpisodio_Episodio_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt=this.AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt;
      }

      public SdtWorkWithDevicesEpisodio_Episodio_DetailSdt executeUdp( long aP0_EpisodioId ,
                                                                       int aP1_gxid )
      {
         this.A7EpisodioId = aP0_EpisodioId;
         this.AV13gxid = aP1_gxid;
         this.AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt = new SdtWorkWithDevicesEpisodio_Episodio_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt=this.AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt;
         return AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt ;
      }

      public void executeSubmit( long aP0_EpisodioId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesEpisodio_Episodio_DetailSdt aP2_GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt )
      {
         workwithdevicesepisodio_episodio_detail objworkwithdevicesepisodio_episodio_detail;
         objworkwithdevicesepisodio_episodio_detail = new workwithdevicesepisodio_episodio_detail();
         objworkwithdevicesepisodio_episodio_detail.A7EpisodioId = aP0_EpisodioId;
         objworkwithdevicesepisodio_episodio_detail.AV13gxid = aP1_gxid;
         objworkwithdevicesepisodio_episodio_detail.AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt = new SdtWorkWithDevicesEpisodio_Episodio_DetailSdt(context) ;
         objworkwithdevicesepisodio_episodio_detail.context.SetSubmitInitialConfig(context);
         objworkwithdevicesepisodio_episodio_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesepisodio_episodio_detail);
         aP2_GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt=this.AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesepisodio_episodio_detail)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV13gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            /* Using cursor P00002 */
            pr_default.execute(0, new Object[] {A7EpisodioId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A8EpisodioNome = P00002_A8EpisodioNome[0];
               Gxdynprop1 = A8EpisodioNome;
               Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Form\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            Gxwebsession.Set(Gxids+"gxvar_Favoritar", AV22Favoritar_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Marcarassistido", AV23Marcarassistido_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Assistido", StringUtil.BoolToStr( AV9Assistido));
            Gxwebsession.Set(Gxids, "true");
         }
         else
         {
            AV9Assistido = BooleanUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Assistido"));
            AV22Favoritar_GXI = Gxwebsession.Get(Gxids+"gxvar_Favoritar");
            AV6Favoritar = "";
            AV23Marcarassistido_GXI = Gxwebsession.Get(Gxids+"gxvar_Marcarassistido");
            AV7MarcarAssistido = "";
         }
         /* Using cursor P00003 */
         pr_default.execute(1, new Object[] {A7EpisodioId});
         while ( (pr_default.getStatus(1) != 101) )
         {
            AV11UsuarioId = 2;
            new verificarepisodiousuario(context ).execute(  AV11UsuarioId,  A7EpisodioId, out  AV9Assistido, out  AV8Favorito) ;
            if ( AV8Favorito )
            {
               AV6Favoritar = context.GetImagePath( "36fbff47-1ab6-4c69-a869-d775c2c91b99", "", context.GetTheme( ));
               AV22Favoritar_GXI = GXDbFile.PathToUrl( context.GetImagePath( "36fbff47-1ab6-4c69-a869-d775c2c91b99", "", context.GetTheme( )));
            }
            else
            {
               AV6Favoritar = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
               AV22Favoritar_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            }
            if ( AV9Assistido )
            {
               AV7MarcarAssistido = context.GetImagePath( "451cf230-8c7c-4f17-8440-ff7c487b2ad9", "", context.GetTheme( ));
               AV23Marcarassistido_GXI = GXDbFile.PathToUrl( context.GetImagePath( "451cf230-8c7c-4f17-8440-ff7c487b2ad9", "", context.GetTheme( )));
            }
            else
            {
               AV7MarcarAssistido = context.GetImagePath( "df8aee37-3ddd-479f-a9aa-1c4957c02e0a", "", context.GetTheme( ));
               AV23Marcarassistido_GXI = GXDbFile.PathToUrl( context.GetImagePath( "df8aee37-3ddd-479f-a9aa-1c4957c02e0a", "", context.GetTheme( )));
            }
            AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt.gxTpr_Episodioid = A7EpisodioId;
            AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt.gxTpr_Favoritar = AV6Favoritar;
            AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt.gxTpr_Favoritar_gxi = AV22Favoritar_GXI;
            AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt.gxTpr_Marcarassistido = AV7MarcarAssistido;
            AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt.gxTpr_Marcarassistido_gxi = AV23Marcarassistido_GXI;
            AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt.gxTpr_Favorita = AV10Favorita;
            AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt.gxTpr_Assistido = AV9Assistido;
            AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt.gxTpr_Favorito = AV8Favorito;
            AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt.gxTpr_Usuarioid = AV11UsuarioId;
            AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
            Gxdynprop = "";
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         Gxwebsession.Set(Gxids+"gxvar_Assistido", StringUtil.BoolToStr( AV9Assistido));
         Gxwebsession.Set(Gxids+"gxvar_Favoritar", AV22Favoritar_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Marcarassistido", AV23Marcarassistido_GXI);
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
         Gxids = "";
         Gxwebsession = context.GetSession();
         scmdbuf = "";
         P00002_A7EpisodioId = new long[1] ;
         P00002_A8EpisodioNome = new String[] {""} ;
         A8EpisodioNome = "";
         Gxdynprop1 = "";
         Gxdynprop = "";
         AV22Favoritar_GXI = "";
         AV23Marcarassistido_GXI = "";
         AV6Favoritar = "";
         AV7MarcarAssistido = "";
         P00003_A7EpisodioId = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesepisodio_episodio_detail__default(),
            new Object[][] {
                new Object[] {
               P00002_A7EpisodioId, P00002_A8EpisodioNome
               }
               , new Object[] {
               P00003_A7EpisodioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV13gxid ;
      private long A7EpisodioId ;
      private long AV11UsuarioId ;
      private String Gxids ;
      private String scmdbuf ;
      private bool AV9Assistido ;
      private bool AV8Favorito ;
      private bool AV10Favorita ;
      private String A8EpisodioNome ;
      private String Gxdynprop1 ;
      private String Gxdynprop ;
      private String AV22Favoritar_GXI ;
      private String AV23Marcarassistido_GXI ;
      private String AV6Favoritar ;
      private String AV7MarcarAssistido ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A7EpisodioId ;
      private String[] P00002_A8EpisodioNome ;
      private long[] P00003_A7EpisodioId ;
      private SdtWorkWithDevicesEpisodio_Episodio_DetailSdt aP2_GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesEpisodio_Episodio_DetailSdt AV18GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt ;
   }

   public class workwithdevicesepisodio_episodio_detail__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00002 ;
          prmP00002 = new Object[] {
          new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP00003 ;
          prmP00003 = new Object[] {
          new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT [EpisodioId], [EpisodioNome] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ORDER BY [EpisodioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
             ,new CursorDef("P00003", "SELECT TOP 1 [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ORDER BY [EpisodioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00003,1,0,true,true )
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

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesepisodio_episodio_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesepisodio_episodio_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?EpisodioId={EpisodioId}&gxid={gxid}")]
    public SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_RESTInterface execute( String EpisodioId ,
                                                                                String gxid )
    {
       SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_RESTInterface GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt = new SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesepisodio_episodio_detail") )
          {
             return null ;
          }
          workwithdevicesepisodio_episodio_detail worker = new workwithdevicesepisodio_episodio_detail(context) ;
          worker.IsMain = RunAsMain ;
          long gxrEpisodioId ;
          gxrEpisodioId = (long)(NumberUtil.Val( (String)(EpisodioId), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtWorkWithDevicesEpisodio_Episodio_DetailSdt gxrGXM2WorkWithDevicesEpisodio_Episodio_DetailSdt = GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt.sdt ;
          worker.execute(gxrEpisodioId,gxrgxid,out gxrGXM2WorkWithDevicesEpisodio_Episodio_DetailSdt );
          worker.cleanup( );
          GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt = new SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_RESTInterface(gxrGXM2WorkWithDevicesEpisodio_Episodio_DetailSdt) ;
          return GXM2WorkWithDevicesEpisodio_Episodio_DetailSdt ;
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
