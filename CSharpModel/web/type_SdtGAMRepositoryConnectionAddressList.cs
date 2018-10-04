/*
               File: type_SdtGAMRepositoryConnectionAddressList
        Description: GAMRepositoryConnectionAddressList
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:19.37
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
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtGAMRepositoryConnectionAddressList : GxUserType, IGxExternalObject
   {
      public SdtGAMRepositoryConnectionAddressList( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMRepositoryConnectionAddressList( IGxContext context )
      {
         this.context = context;
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMRepositoryConnectionAddressList_externalReference == null )
         {
            GAMRepositoryConnectionAddressList_externalReference = new Artech.Security.GAMRepositoryConnectionAddressList(context);
         }
         returntostring = "";
         returntostring = (String)(GAMRepositoryConnectionAddressList_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMRepositoryConnectionAddressList_externalReference == null )
         {
            GAMRepositoryConnectionAddressList_externalReference = new Artech.Security.GAMRepositoryConnectionAddressList(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMRepositoryConnectionAddressList_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMRepositoryConnectionAddressList_externalReference == null )
         {
            GAMRepositoryConnectionAddressList_externalReference = new Artech.Security.GAMRepositoryConnectionAddressList(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMRepositoryConnectionAddressList_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Address
      {
         get {
            if ( GAMRepositoryConnectionAddressList_externalReference == null )
            {
               GAMRepositoryConnectionAddressList_externalReference = new Artech.Security.GAMRepositoryConnectionAddressList(context);
            }
            return GAMRepositoryConnectionAddressList_externalReference.Address ;
         }

         set {
            if ( GAMRepositoryConnectionAddressList_externalReference == null )
            {
               GAMRepositoryConnectionAddressList_externalReference = new Artech.Security.GAMRepositoryConnectionAddressList(context);
            }
            GAMRepositoryConnectionAddressList_externalReference.Address = value;
            SetDirty("Address");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMRepositoryConnectionAddressList_externalReference == null )
            {
               GAMRepositoryConnectionAddressList_externalReference = new Artech.Security.GAMRepositoryConnectionAddressList(context);
            }
            return GAMRepositoryConnectionAddressList_externalReference ;
         }

         set {
            GAMRepositoryConnectionAddressList_externalReference = (Artech.Security.GAMRepositoryConnectionAddressList)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMRepositoryConnectionAddressList GAMRepositoryConnectionAddressList_externalReference=null ;
   }

}
