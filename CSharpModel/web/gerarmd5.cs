/*
               File: GerarMD5
        Description: Gerar MD5
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:51.52
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gerarmd5 : GXProcedure
   {
      public gerarmd5( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gerarmd5( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_Entrada ,
                           out String aP1_Saida )
      {
         this.AV8Entrada = aP0_Entrada;
         this.AV9Saida = "" ;
         initialize();
         executePrivate();
         aP1_Saida=this.AV9Saida;
      }

      public String executeUdp( String aP0_Entrada )
      {
         this.AV8Entrada = aP0_Entrada;
         this.AV9Saida = "" ;
         initialize();
         executePrivate();
         aP1_Saida=this.AV9Saida;
         return AV9Saida ;
      }

      public void executeSubmit( String aP0_Entrada ,
                                 out String aP1_Saida )
      {
         gerarmd5 objgerarmd5;
         objgerarmd5 = new gerarmd5();
         objgerarmd5.AV8Entrada = aP0_Entrada;
         objgerarmd5.AV9Saida = "" ;
         objgerarmd5.context.SetSubmitInitialConfig(context);
         objgerarmd5.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgerarmd5);
         aP1_Saida=this.AV9Saida;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gerarmd5)stateInfo).executePrivate();
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
         AV10Cryptohash.Algorithm = "MD5";
         AV9Saida = AV10Cryptohash.Compute(AV8Entrada, "");
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
         AV10Cryptohash = new GXHashing();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV8Entrada ;
      private String AV9Saida ;
      private String aP1_Saida ;
      private GXHashing AV10Cryptohash ;
   }

}
