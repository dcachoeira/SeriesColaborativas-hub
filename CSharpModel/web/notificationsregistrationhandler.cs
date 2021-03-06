/*
               File: NotificationsRegistrationHandler
        Description: Stub for NotificationsRegistrationHandler
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:53.68
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
using System.Web.Services.Protocols;
using System.Web.Services;
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class notificationsregistrationhandler : GXProcedure
   {
      public notificationsregistrationhandler( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public notificationsregistrationhandler( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_DeviceType ,
                           String aP1_DeviceId ,
                           String aP2_DeviceToken ,
                           String aP3_DeviceName )
      {
         this.AV2DeviceType = aP0_DeviceType;
         this.AV3DeviceId = aP1_DeviceId;
         this.AV4DeviceToken = aP2_DeviceToken;
         this.AV5DeviceName = aP3_DeviceName;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_DeviceType ,
                                 String aP1_DeviceId ,
                                 String aP2_DeviceToken ,
                                 String aP3_DeviceName )
      {
         notificationsregistrationhandler objnotificationsregistrationhandler;
         objnotificationsregistrationhandler = new notificationsregistrationhandler();
         objnotificationsregistrationhandler.AV2DeviceType = aP0_DeviceType;
         objnotificationsregistrationhandler.AV3DeviceId = aP1_DeviceId;
         objnotificationsregistrationhandler.AV4DeviceToken = aP2_DeviceToken;
         objnotificationsregistrationhandler.AV5DeviceName = aP3_DeviceName;
         objnotificationsregistrationhandler.context.SetSubmitInitialConfig(context);
         objnotificationsregistrationhandler.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objnotificationsregistrationhandler);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((notificationsregistrationhandler)stateInfo).executePrivate();
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
         args = new Object[] {(short)AV2DeviceType,(String)AV3DeviceId,(String)AV4DeviceToken,(String)AV5DeviceName} ;
         ClassLoader.Execute("anotificationsregistrationhandler","GeneXus.Programs","anotificationsregistrationhandler", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 4 ) )
         {
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV2DeviceType ;
      private String AV3DeviceId ;
      private String AV4DeviceToken ;
      private String AV5DeviceName ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private Object[] args ;
   }

}
