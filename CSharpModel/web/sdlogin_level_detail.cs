/*
               File: SDLogin_Level_Detail
        Description: SDLogin_Level_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/23/2018 19:46:33.88
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
   public class sdlogin_level_detail : GXProcedure
   {
      public sdlogin_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdlogin_level_detail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( int aP0_gxid ,
                           out SdtSDLogin_Level_DetailSdt aP1_GXM1SDLogin_Level_DetailSdt )
      {
         this.AV5gxid = aP0_gxid;
         this.AV6GXM1SDLogin_Level_DetailSdt = new SdtSDLogin_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1SDLogin_Level_DetailSdt=this.AV6GXM1SDLogin_Level_DetailSdt;
      }

      public SdtSDLogin_Level_DetailSdt executeUdp( int aP0_gxid )
      {
         this.AV5gxid = aP0_gxid;
         this.AV6GXM1SDLogin_Level_DetailSdt = new SdtSDLogin_Level_DetailSdt(context) ;
         initialize();
         executePrivate();
         aP1_GXM1SDLogin_Level_DetailSdt=this.AV6GXM1SDLogin_Level_DetailSdt;
         return AV6GXM1SDLogin_Level_DetailSdt ;
      }

      public void executeSubmit( int aP0_gxid ,
                                 out SdtSDLogin_Level_DetailSdt aP1_GXM1SDLogin_Level_DetailSdt )
      {
         sdlogin_level_detail objsdlogin_level_detail;
         objsdlogin_level_detail = new sdlogin_level_detail();
         objsdlogin_level_detail.AV5gxid = aP0_gxid;
         objsdlogin_level_detail.AV6GXM1SDLogin_Level_DetailSdt = new SdtSDLogin_Level_DetailSdt(context) ;
         objsdlogin_level_detail.context.SetSubmitInitialConfig(context);
         objsdlogin_level_detail.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdlogin_level_detail);
         aP1_GXM1SDLogin_Level_DetailSdt=this.AV6GXM1SDLogin_Level_DetailSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdlogin_level_detail)stateInfo).executePrivate();
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
         /* Using cursor P00002 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11UsuarioId = P00002_A11UsuarioId[0];
            A57UsuarioEmail = P00002_A57UsuarioEmail[0];
            A55UsuarioSenha = P00002_A55UsuarioSenha[0];
            AV6GXM1SDLogin_Level_DetailSdt.gxTpr_Usuarioid = A11UsuarioId;
            AV6GXM1SDLogin_Level_DetailSdt.gxTpr_Usuarioemail = A57UsuarioEmail;
            AV6GXM1SDLogin_Level_DetailSdt.gxTpr_Usuariosenha = A55UsuarioSenha;
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
         P00002_A11UsuarioId = new long[1] ;
         P00002_A57UsuarioEmail = new String[] {""} ;
         P00002_A55UsuarioSenha = new String[] {""} ;
         A57UsuarioEmail = "";
         A55UsuarioSenha = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdlogin_level_detail__default(),
            new Object[][] {
                new Object[] {
               P00002_A11UsuarioId, P00002_A57UsuarioEmail, P00002_A55UsuarioSenha
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV5gxid ;
      private long A11UsuarioId ;
      private String scmdbuf ;
      private String A57UsuarioEmail ;
      private String A55UsuarioSenha ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A11UsuarioId ;
      private String[] P00002_A57UsuarioEmail ;
      private String[] P00002_A55UsuarioSenha ;
      private SdtSDLogin_Level_DetailSdt aP1_GXM1SDLogin_Level_DetailSdt ;
      private SdtSDLogin_Level_DetailSdt AV6GXM1SDLogin_Level_DetailSdt ;
   }

   public class sdlogin_level_detail__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00002 ;
          prmP00002 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT TOP 1 [UsuarioId], [UsuarioEmail], [UsuarioSenha] FROM [Usuario] WITH (NOLOCK) ORDER BY [UsuarioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,false,true )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.sdlogin_level_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdlogin_level_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?gxid={gxid}")]
    public SdtSDLogin_Level_DetailSdt_RESTInterface execute( String gxid )
    {
       SdtSDLogin_Level_DetailSdt_RESTInterface GXM1SDLogin_Level_DetailSdt = new SdtSDLogin_Level_DetailSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("sdlogin_level_detail") )
          {
             return null ;
          }
          sdlogin_level_detail worker = new sdlogin_level_detail(context) ;
          worker.IsMain = RunAsMain ;
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtSDLogin_Level_DetailSdt gxrGXM1SDLogin_Level_DetailSdt = GXM1SDLogin_Level_DetailSdt.sdt ;
          worker.execute(gxrgxid,out gxrGXM1SDLogin_Level_DetailSdt );
          worker.cleanup( );
          GXM1SDLogin_Level_DetailSdt = new SdtSDLogin_Level_DetailSdt_RESTInterface(gxrGXM1SDLogin_Level_DetailSdt) ;
          return GXM1SDLogin_Level_DetailSdt ;
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
