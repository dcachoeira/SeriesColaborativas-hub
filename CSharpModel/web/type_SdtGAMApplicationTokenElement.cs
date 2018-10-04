/*
               File: type_SdtGAMApplicationTokenElement
        Description: GAMApplicationTokenElement
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:54.39
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
   public class SdtGAMApplicationTokenElement : GxUserType, IGxExternalObject
   {
      public SdtGAMApplicationTokenElement( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMApplicationTokenElement( IGxContext context )
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
         if ( GAMApplicationTokenElement_externalReference == null )
         {
            GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
         }
         returntostring = "";
         returntostring = (String)(GAMApplicationTokenElement_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMApplicationTokenElement_externalReference == null )
         {
            GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMApplicationTokenElement_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMApplicationTokenElement_externalReference == null )
         {
            GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMApplicationTokenElement_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMApplicationTokenElement_externalReference == null )
            {
               GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
            }
            return GAMApplicationTokenElement_externalReference.Name ;
         }

         set {
            if ( GAMApplicationTokenElement_externalReference == null )
            {
               GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
            }
            GAMApplicationTokenElement_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMApplicationTokenElement_externalReference == null )
            {
               GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
            }
            return GAMApplicationTokenElement_externalReference.Description ;
         }

         set {
            if ( GAMApplicationTokenElement_externalReference == null )
            {
               GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
            }
            GAMApplicationTokenElement_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public short gxTpr_Order
      {
         get {
            if ( GAMApplicationTokenElement_externalReference == null )
            {
               GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
            }
            return GAMApplicationTokenElement_externalReference.Order ;
         }

         set {
            if ( GAMApplicationTokenElement_externalReference == null )
            {
               GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
            }
            GAMApplicationTokenElement_externalReference.Order = value;
            SetDirty("Order");
         }

      }

      public String gxTpr_Webservicehost
      {
         get {
            if ( GAMApplicationTokenElement_externalReference == null )
            {
               GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
            }
            return GAMApplicationTokenElement_externalReference.WebServiceHost ;
         }

         set {
            if ( GAMApplicationTokenElement_externalReference == null )
            {
               GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
            }
            GAMApplicationTokenElement_externalReference.WebServiceHost = value;
            SetDirty("Webservicehost");
         }

      }

      public String gxTpr_Webservicename
      {
         get {
            if ( GAMApplicationTokenElement_externalReference == null )
            {
               GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
            }
            return GAMApplicationTokenElement_externalReference.WebServiceName ;
         }

         set {
            if ( GAMApplicationTokenElement_externalReference == null )
            {
               GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
            }
            GAMApplicationTokenElement_externalReference.WebServiceName = value;
            SetDirty("Webservicename");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMApplicationTokenElement_externalReference == null )
            {
               GAMApplicationTokenElement_externalReference = new Artech.Security.GAMApplicationTokenElement(context);
            }
            return GAMApplicationTokenElement_externalReference ;
         }

         set {
            GAMApplicationTokenElement_externalReference = (Artech.Security.GAMApplicationTokenElement)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMApplicationTokenElement GAMApplicationTokenElement_externalReference=null ;
   }

}
