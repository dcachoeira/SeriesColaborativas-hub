/*
               File: GravarSerieAssistidaUsuarioInterno
        Description: Gravar Serie Assistida Usuario Interno
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:55.45
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
   public class gravarserieassistidausuariointerno : GXProcedure
   {
      public gravarserieassistidausuariointerno( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gravarserieassistidausuariointerno( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_SerieId ,
                           String aP1_UsuarioGAMGuid ,
                           decimal aP2_Assistido )
      {
         this.AV8SerieId = aP0_SerieId;
         this.AV10UsuarioGAMGuid = aP1_UsuarioGAMGuid;
         this.AV11Assistido = aP2_Assistido;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_SerieId ,
                                 String aP1_UsuarioGAMGuid ,
                                 decimal aP2_Assistido )
      {
         gravarserieassistidausuariointerno objgravarserieassistidausuariointerno;
         objgravarserieassistidausuariointerno = new gravarserieassistidausuariointerno();
         objgravarserieassistidausuariointerno.AV8SerieId = aP0_SerieId;
         objgravarserieassistidausuariointerno.AV10UsuarioGAMGuid = aP1_UsuarioGAMGuid;
         objgravarserieassistidausuariointerno.AV11Assistido = aP2_Assistido;
         objgravarserieassistidausuariointerno.context.SetSubmitInitialConfig(context);
         objgravarserieassistidausuariointerno.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgravarserieassistidausuariointerno);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gravarserieassistidausuariointerno)stateInfo).executePrivate();
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
         new gravarserieassistidausuario(context).executeSubmit(  AV8SerieId,  AV10UsuarioGAMGuid,  Convert.ToBoolean( (int)(AV11Assistido))) ;
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
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV8SerieId ;
      private decimal AV11Assistido ;
      private String AV10UsuarioGAMGuid ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.gravarserieassistidausuariointerno_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class gravarserieassistidausuariointerno_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "POST" ,
      	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/")]
      public void execute( String SerieId ,
                           String UsuarioGAMGuid ,
                           String Assistido )
      {
         try
         {
            if ( ! ProcessHeaders("gravarserieassistidausuariointerno") )
            {
               return  ;
            }
            gravarserieassistidausuariointerno worker = new gravarserieassistidausuariointerno(context) ;
            worker.IsMain = RunAsMain ;
            long gxrSerieId ;
            gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
            decimal gxrAssistido ;
            gxrAssistido = NumberUtil.Val( (String)(Assistido), ".");
            worker.execute(gxrSerieId,UsuarioGAMGuid,gxrAssistido );
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
