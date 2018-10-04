/*
               File: GAMEvents
        Description: GAMEvents
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:0.79
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
   public class gxdomaingamevents
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaingamevents ()
      {
         domain["user-update"] = "User - Update";
         domain["user-insert"] = "User - Insert";
         domain["user-delete"] = "User - Delete";
         domain["user-updateroles"] = "User - Update Roles";
         domain["user-getcustominfo"] = "User - Get Custom Information on GAMRemote Server";
         domain["user-savecustominfo"] = "User - Save Custom Information on GAMRemote Client";
         domain["role-insert"] = "Role - Insert";
         domain["role-update"] = "Role - Update";
         domain["role-delete"] = "Role - Delete";
         domain["repository-login"] = "Repository - Login";
         domain["repository-logout"] = "Repository - Logout";
         domain["application-checkprmfail"] = "Application - Check Permission Fail";
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
            domainMap["User_Update"] = "user-update";
            domainMap["User_Insert"] = "user-insert";
            domainMap["User_Delete"] = "user-delete";
            domainMap["User_UpdateRoles"] = "user-updateroles";
            domainMap["User_GetCustomInfo"] = "user-getcustominfo";
            domainMap["User_SaveCustomInfo"] = "user-savecustominfo";
            domainMap["Role_Insert"] = "role-insert";
            domainMap["Role_Update"] = "role-update";
            domainMap["Role_Delete"] = "role-delete";
            domainMap["Repository_Login"] = "repository-login";
            domainMap["Repository_Logout"] = "repository-logout";
            domainMap["Application_CheckPermissionFail"] = "application-checkprmfail";
         }
         return (String)domainMap[key] ;
      }

   }

}
