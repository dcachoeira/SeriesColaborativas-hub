/*
               File: SetarImagem
        Description: Setar Imagem
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 10/1/2018 14:37:13.63
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
   public class setarimagem : GXProcedure
   {
      public setarimagem( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public setarimagem( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_Image )
      {
         this.AV8Image = "" ;
         initialize();
         executePrivate();
         aP0_Image=this.AV8Image;
      }

      public String executeUdp( )
      {
         this.AV8Image = "" ;
         initialize();
         executePrivate();
         aP0_Image=this.AV8Image;
         return AV8Image ;
      }

      public void executeSubmit( out String aP0_Image )
      {
         setarimagem objsetarimagem;
         objsetarimagem = new setarimagem();
         objsetarimagem.AV8Image = "" ;
         objsetarimagem.context.SetSubmitInitialConfig(context);
         objsetarimagem.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsetarimagem);
         aP0_Image=this.AV8Image;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((setarimagem)stateInfo).executePrivate();
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
         AV8Image = context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( ));
         AV11Image_GXI = GXDbFile.PathToUrl( context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( )));
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
         AV11Image_GXI = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV11Image_GXI ;
      private String AV8Image ;
      private String aP0_Image ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.setarimagem_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class setarimagem_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "POST" ,
      	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/")]
      public void execute( out String Image )
      {
         Image = "" ;
         try
         {
            if ( ! ProcessHeaders("setarimagem") )
            {
               return  ;
            }
            setarimagem worker = new setarimagem(context) ;
            worker.IsMain = RunAsMain ;
            worker.execute(out Image );
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
