/*
               File: WWPBaseObjects.LoadUserKeyValue
        Description: Load User Key Value
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:30.90
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class loaduserkeyvalue : GXProcedure
   {
      public loaduserkeyvalue( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public loaduserkeyvalue( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_UserCustomizationsKey ,
                           out String aP1_UserCustomizationsValue )
      {
         this.AV11UserCustomizationsKey = aP0_UserCustomizationsKey;
         this.AV12UserCustomizationsValue = "" ;
         initialize();
         executePrivate();
         aP1_UserCustomizationsValue=this.AV12UserCustomizationsValue;
      }

      public String executeUdp( String aP0_UserCustomizationsKey )
      {
         this.AV11UserCustomizationsKey = aP0_UserCustomizationsKey;
         this.AV12UserCustomizationsValue = "" ;
         initialize();
         executePrivate();
         aP1_UserCustomizationsValue=this.AV12UserCustomizationsValue;
         return AV12UserCustomizationsValue ;
      }

      public void executeSubmit( String aP0_UserCustomizationsKey ,
                                 out String aP1_UserCustomizationsValue )
      {
         loaduserkeyvalue objloaduserkeyvalue;
         objloaduserkeyvalue = new loaduserkeyvalue();
         objloaduserkeyvalue.AV11UserCustomizationsKey = aP0_UserCustomizationsKey;
         objloaduserkeyvalue.AV12UserCustomizationsValue = "" ;
         objloaduserkeyvalue.context.SetSubmitInitialConfig(context);
         objloaduserkeyvalue.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objloaduserkeyvalue);
         aP1_UserCustomizationsValue=this.AV12UserCustomizationsValue;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((loaduserkeyvalue)stateInfo).executePrivate();
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
         AV12UserCustomizationsValue = AV8Session.Get(AV11UserCustomizationsKey);
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
         AV8Session = context.GetSession();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV12UserCustomizationsValue ;
      private String AV11UserCustomizationsKey ;
      private IGxSession AV8Session ;
      private String aP1_UserCustomizationsValue ;
   }

}
