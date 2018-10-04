/*
               File: GAMUserListOrder
        Description: GAMUserListOrder
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:1.44
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
   public class gxdomaingamuserlistorder
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaingamuserlistorder ()
      {
         domain[(short)0] = "None";
         domain[(short)1] = "GUID_ Asc";
         domain[(short)2] = "GUID_ Desc";
         domain[(short)3] = "User Name_ Asc";
         domain[(short)4] = "User Name_ Desc";
         domain[(short)5] = "User Email_ Asc";
         domain[(short)6] = "User Email_ Desc";
         domain[(short)7] = "User First Name_ Asc";
         domain[(short)8] = "User First Name_ Desc";
         domain[(short)9] = "User Last Name_ Asc";
         domain[(short)10] = "User Last Name_ Desc";
         domain[(short)11] = "User External Id_Asc";
         domain[(short)12] = "User External Id_Desc";
      }

      public static string getDescription( IGxContext context ,
                                           short key )
      {
         return (string)domain[key] ;
      }

      public static GxSimpleCollection<short> getValues( )
      {
         GxSimpleCollection<short> value = new GxSimpleCollection<short>();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (short key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public static short getValue( string key )
      {
         if(domainMap == null)
         {
            domainMap = new Hashtable();
            domainMap["None"] = (short)0;
            domainMap["GUID_Asc"] = (short)1;
            domainMap["GUID_Desc"] = (short)2;
            domainMap["UserName_Asc"] = (short)3;
            domainMap["UserName_Desc"] = (short)4;
            domainMap["UserEmail_Asc"] = (short)5;
            domainMap["UserEmail_Desc"] = (short)6;
            domainMap["UserFirstName_Asc"] = (short)7;
            domainMap["UserFirstName_Desc"] = (short)8;
            domainMap["UserLastName_Asc"] = (short)9;
            domainMap["UserLastName_Desc"] = (short)10;
            domainMap["UserExternalId_Asc"] = (short)11;
            domainMap["UserExternalId_Desc"] = (short)12;
         }
         return (short)domainMap[key] ;
      }

   }

}
