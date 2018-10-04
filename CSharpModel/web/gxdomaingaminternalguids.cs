/*
               File: GAMInternalGUIDs
        Description: GAMInternalGUIDs
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:0.97
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
   public class gxdomaingaminternalguids
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaingaminternalguids ()
      {
         domain["8d9934db-05db-4d64-adba-5e0466c3a56f"] = "Application GAM Admnistrator";
         domain["8d9934db-05db-4d64-adba-5e0466c3appU"] = "Application GAM User Backend";
         domain["8d9934db-05db-4d64-adba-5e0466gam001"] = "Backend Main Menu";
         domain["8d9934db-05db-4d64-adba-5e0466gam002"] = "Backend settings Menu";
         domain["8d9934db-05db-4d64-adba-5e0466gam003"] = "Backend Menu Opt Users";
         domain["8d9934db-05db-4d64-adba-5e0466gam004"] = "Backend Menu Opt Roles";
         domain["8d9934db-05db-4d64-adba-5e0466gam005"] = "Backend Menu Opt Setings";
         domain["8d9934db-05db-4d64-adba-5e0466gam006"] = "Backend Menu Opt Sec Pol";
         domain["8d9934db-05db-4d64-adba-5e0466gam007"] = "Backend Menu Opt Applications";
         domain["8d9934db-05db-4d64-adba-5e0466gam008"] = "Backend Menu Opt Rep Conf";
         domain["8d9934db-05db-4d64-adba-5e0466gam009"] = "Backend Menu Opt Rep Conn";
         domain["8d9934db-05db-4d64-adba-5e0466gam010"] = "Backend Menu Opt Auth Types";
         domain["8d9934db-05db-4d64-adba-5e0466gam011"] = "Backend Menu Opt Change Pwd";
         domain["8d9934db-05db-4d64-adba-5e0466gam012"] = "Backend Menu Opt Change WR";
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
            domainMap["AppGAMAdmnistrator"] = "8d9934db-05db-4d64-adba-5e0466c3a56f";
            domainMap["AppGAMUserBackend"] = "8d9934db-05db-4d64-adba-5e0466c3appU";
            domainMap["BackendMenuMain"] = "8d9934db-05db-4d64-adba-5e0466gam001";
            domainMap["BackendMenuSettings"] = "8d9934db-05db-4d64-adba-5e0466gam002";
            domainMap["BackendMenuOptUsers"] = "8d9934db-05db-4d64-adba-5e0466gam003";
            domainMap["BackendMenuOptRoles"] = "8d9934db-05db-4d64-adba-5e0466gam004";
            domainMap["BackendMenuOptSetings"] = "8d9934db-05db-4d64-adba-5e0466gam005";
            domainMap["BackendMenuOptSecPol"] = "8d9934db-05db-4d64-adba-5e0466gam006";
            domainMap["BackendMenuOptApplications"] = "8d9934db-05db-4d64-adba-5e0466gam007";
            domainMap["BackendMenuOptRepConf"] = "8d9934db-05db-4d64-adba-5e0466gam008";
            domainMap["BackendMenuOptRepConn"] = "8d9934db-05db-4d64-adba-5e0466gam009";
            domainMap["BackendMenuOptAuthTypes"] = "8d9934db-05db-4d64-adba-5e0466gam010";
            domainMap["BackendMenuOptChangePwd"] = "8d9934db-05db-4d64-adba-5e0466gam011";
            domainMap["BackendMenuOptChangeWR"] = "8d9934db-05db-4d64-adba-5e0466gam012";
         }
         return (String)domainMap[key] ;
      }

   }

}
