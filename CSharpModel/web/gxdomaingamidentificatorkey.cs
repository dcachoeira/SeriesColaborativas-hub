/*
               File: GAMIdentificatorKey
        Description: GAMIdentificatorKey
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:0.94
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
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gxdomaingamidentificatorkey
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaingamidentificatorkey ()
      {
         domain["Repository"] = "Repository";
         domain["SecurityPolicy"] = "Security Policy";
         domain["Role"] = "Role";
         domain["AppType"] = "Application Type";
         domain["AppTypeResource"] = "Application Type Resource";
         domain["AppTypeAction"] = "Application Type Action";
         domain["Application"] = "Application";
         domain["AppEnv"] = "Application Environment";
         domain["AppMenu"] = "Application Menu";
         domain["AppMenuOption"] = "Application Menu Option";
      }

      public static string getDescription( IGxContext context ,
                                           String key )
      {
         string rtkey ;
         rtkey = StringUtil.Trim( (String)(key));
         return (string)domain[rtkey] ;
      }

      public static GxSimpleCollection<String> getValues( )
      {
         GxSimpleCollection<String> value = new GxSimpleCollection<String>();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (String key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public static String getValue( string key )
      {
         if(domainMap == null)
         {
            domainMap = new Hashtable();
            domainMap["Repository"] = "Repository";
            domainMap["SecurityPolicy"] = "SecurityPolicy";
            domainMap["Role"] = "Role";
            domainMap["ApplicationType"] = "AppType";
            domainMap["ApplicationTypeResource"] = "AppTypeResource";
            domainMap["ApplicationTypeAction"] = "AppTypeAction";
            domainMap["Application"] = "Application";
            domainMap["ApplicationEnvironment"] = "AppEnv";
            domainMap["ApplicationMenu"] = "AppMenu";
            domainMap["ApplicationMenuOption"] = "AppMenuOption";
         }
         return (String)domainMap[key] ;
      }

   }

}
