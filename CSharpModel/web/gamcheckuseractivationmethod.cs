/*
               File: GAMCheckUserActivationMethod
        Description: Check User Activation Method
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:42.80
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
   public class gamcheckuseractivationmethod : GXProcedure
   {
      public gamcheckuseractivationmethod( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gamcheckuseractivationmethod( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_UserGUID ,
                           out GXBaseCollection<SdtMessages_Message> aP1_Messages )
      {
         this.AV10UserGUID = aP0_UserGUID;
         this.AV12Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus") ;
         initialize();
         executePrivate();
         aP1_Messages=this.AV12Messages;
      }

      public GXBaseCollection<SdtMessages_Message> executeUdp( String aP0_UserGUID )
      {
         this.AV10UserGUID = aP0_UserGUID;
         this.AV12Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus") ;
         initialize();
         executePrivate();
         aP1_Messages=this.AV12Messages;
         return AV12Messages ;
      }

      public void executeSubmit( String aP0_UserGUID ,
                                 out GXBaseCollection<SdtMessages_Message> aP1_Messages )
      {
         gamcheckuseractivationmethod objgamcheckuseractivationmethod;
         objgamcheckuseractivationmethod = new gamcheckuseractivationmethod();
         objgamcheckuseractivationmethod.AV10UserGUID = aP0_UserGUID;
         objgamcheckuseractivationmethod.AV12Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus") ;
         objgamcheckuseractivationmethod.context.SetSubmitInitialConfig(context);
         objgamcheckuseractivationmethod.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgamcheckuseractivationmethod);
         aP1_Messages=this.AV12Messages;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gamcheckuseractivationmethod)stateInfo).executePrivate();
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
         AV9Repository = new SdtGAMRepository(context).get();
         if ( StringUtil.StrCmp(AV9Repository.gxTpr_Useractivationmethod, "U") == 0 )
         {
            AV14Message = new SdtMessages_Message(context);
            AV14Message.gxTpr_Type = 0;
            AV14Message.gxTpr_Description = "The user was created successfully!!, you must confirm the account, check your email, you will receive an email with a link to activate your account.";
            AV12Messages.Add(AV14Message, 0);
            AV11User.load( AV10UserGUID);
            AV15ActivactionKey = AV11User.getactivationkey(out  AV13Errors);
            AV8isOK = new SdtGAMRepository(context).activateuser(AV15ActivactionKey, true, out  AV13Errors);
            if ( AV8isOK )
            {
               AV14Message = new SdtMessages_Message(context);
               AV14Message.gxTpr_Type = 0;
               AV14Message.gxTpr_Description = "Your user account was successfully activated !!";
               AV12Messages.Add(AV14Message, 0);
            }
            else
            {
               GXt_objcol_SdtMessages_Message1 = AV12Messages;
               new gamconverterrorstomessages(context ).execute(  AV13Errors, out  GXt_objcol_SdtMessages_Message1) ;
               AV12Messages = GXt_objcol_SdtMessages_Message1;
            }
         }
         else if ( StringUtil.StrCmp(AV9Repository.gxTpr_Useractivationmethod, "D") == 0 )
         {
            AV14Message = new SdtMessages_Message(context);
            AV14Message.gxTpr_Type = 0;
            AV14Message.gxTpr_Description = "The user was created successfully!!, you must wait for confirmation from the administrator.";
            AV12Messages.Add(AV14Message, 0);
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
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV9Repository = new SdtGAMRepository(context);
         AV14Message = new SdtMessages_Message(context);
         AV11User = new SdtGAMUser(context);
         AV15ActivactionKey = "";
         AV13Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         GXt_objcol_SdtMessages_Message1 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV10UserGUID ;
      private String AV15ActivactionKey ;
      private bool AV8isOK ;
      private GXBaseCollection<SdtMessages_Message> aP1_Messages ;
      private GXExternalCollection<SdtGAMError> AV13Errors ;
      private GXBaseCollection<SdtMessages_Message> AV12Messages ;
      private GXBaseCollection<SdtMessages_Message> GXt_objcol_SdtMessages_Message1 ;
      private SdtGAMRepository AV9Repository ;
      private SdtGAMUser AV11User ;
      private SdtMessages_Message AV14Message ;
   }

}
