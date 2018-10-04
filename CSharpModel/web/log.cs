/*
               File: log
        Description: log
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:51.71
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
   public class log : GXProcedure
   {
      public log( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public log( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_Log )
      {
         this.AV8Log = aP0_Log;
         initialize();
         executePrivate();
      }

      public void executeSubmit( String aP0_Log )
      {
         log objlog;
         objlog = new log();
         objlog.AV8Log = aP0_Log;
         objlog.context.SetSubmitInitialConfig(context);
         objlog.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objlog);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((log)stateInfo).executePrivate();
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
         AV11Ret = (decimal)(context.FileIOInstance.dfwopen( "C:\\temp\\log.txt", "", "", 1, ""));
         AV11Ret = (decimal)(context.FileIOInstance.dfwptxt( AV8Log, 0));
         AV11Ret = (decimal)(context.FileIOInstance.dfwnext( ));
         AV11Ret = (decimal)(context.FileIOInstance.dfwclose( ));
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

      private decimal AV11Ret ;
      private String AV8Log ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.log_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class log_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "POST" ,
      	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/")]
      public void execute( String Log )
      {
         try
         {
            if ( ! ProcessHeaders("log") )
            {
               return  ;
            }
            log worker = new log(context) ;
            worker.IsMain = RunAsMain ;
            worker.execute(Log );
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
