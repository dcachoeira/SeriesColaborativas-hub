/*
               File: WWPBaseObjects.GetHomeSampleData
        Description: Get Home Sample Data
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:29.28
       Program type: HTTP procedure
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
using GeneXus.Http.Server;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs.wwpbaseobjects {
   public class gethomesampledata : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         initialize();
         Gxm2rootcol = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem>( context, "HomeSampleDataItem", "SeriesColaborativas") ;
         if ( ! context.isAjaxRequest( ) )
         {
            GXSoapHTTPResponse.AppendHeader("Content-type", "text/xml;charset=utf-8");
         }
         if ( StringUtil.StrCmp(StringUtil.Lower( GXSoapHTTPRequest.Method), "get") == 0 )
         {
            if ( StringUtil.StrCmp(StringUtil.Lower( GXSoapHTTPRequest.QueryString), "wsdl") == 0 )
            {
               GXSoapXMLWriter.OpenResponse(GXSoapHTTPResponse);
               GXSoapXMLWriter.WriteStartDocument("utf-8", 0);
               GXSoapXMLWriter.WriteStartElement("definitions");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleData");
               GXSoapXMLWriter.WriteAttribute("targetNamespace", "SeriesColaborativas");
               GXSoapXMLWriter.WriteAttribute("xmlns:wsdlns", "SeriesColaborativas");
               GXSoapXMLWriter.WriteAttribute("xmlns:soap", "http://schemas.xmlsoap.org/wsdl/soap/");
               GXSoapXMLWriter.WriteAttribute("xmlns:xsd", "http://www.w3.org/2001/XMLSchema");
               GXSoapXMLWriter.WriteAttribute("xmlns", "http://schemas.xmlsoap.org/wsdl/");
               GXSoapXMLWriter.WriteAttribute("xmlns:tns", "SeriesColaborativas");
               GXSoapXMLWriter.WriteStartElement("types");
               GXSoapXMLWriter.WriteStartElement("schema");
               GXSoapXMLWriter.WriteAttribute("targetNamespace", "SeriesColaborativas");
               GXSoapXMLWriter.WriteAttribute("xmlns", "http://www.w3.org/2001/XMLSchema");
               GXSoapXMLWriter.WriteAttribute("xmlns:SOAP-ENC", "http://schemas.xmlsoap.org/soap/encoding/");
               GXSoapXMLWriter.WriteAttribute("elementFormDefault", "qualified");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteAttribute("name", "HomeSampleData");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "0");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "unbounded");
               GXSoapXMLWriter.WriteAttribute("name", "HomeSampleDataItem");
               GXSoapXMLWriter.WriteAttribute("type", "tns:WWPBaseObjects.HomeSampleData.HomeSampleDataItem");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.HomeSampleData.HomeSampleDataItem");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "ProductName");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:string");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "ProductPrice");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "ProductWeight");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "ProductVolume");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "ProductDiscount");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "ProductStatus");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:byte");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleData.Execute");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleData.ExecuteResponse");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "ReturnValue");
               GXSoapXMLWriter.WriteAttribute("type", "tns:HomeSampleData");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleData.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:WWPBaseObjects.GetHomeSampleData.Execute");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleData.ExecuteSoapOut");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:WWPBaseObjects.GetHomeSampleData.ExecuteResponse");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("portType");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleDataSoapPort");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("input", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"WWPBaseObjects.GetHomeSampleData.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("output", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"WWPBaseObjects.GetHomeSampleData.ExecuteSoapOut");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("binding");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleDataSoapBinding");
               GXSoapXMLWriter.WriteAttribute("type", "wsdlns:"+"WWPBaseObjects.GetHomeSampleDataSoapPort");
               GXSoapXMLWriter.WriteElement("soap:binding", "");
               GXSoapXMLWriter.WriteAttribute("style", "document");
               GXSoapXMLWriter.WriteAttribute("transport", "http://schemas.xmlsoap.org/soap/http");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("soap:operation", "");
               GXSoapXMLWriter.WriteAttribute("soapAction", "SeriesColaborativasaction/"+"wwpbaseobjects.AGETHOMESAMPLEDATA.Execute");
               GXSoapXMLWriter.WriteStartElement("input");
               GXSoapXMLWriter.WriteElement("soap:body", "");
               GXSoapXMLWriter.WriteAttribute("use", "literal");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("output");
               GXSoapXMLWriter.WriteElement("soap:body", "");
               GXSoapXMLWriter.WriteAttribute("use", "literal");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("service");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleData");
               GXSoapXMLWriter.WriteStartElement("port");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleDataSoapPort");
               GXSoapXMLWriter.WriteAttribute("binding", "wsdlns:"+"WWPBaseObjects.GetHomeSampleDataSoapBinding");
               GXSoapXMLWriter.WriteElement("soap:address", "");
               GXSoapXMLWriter.WriteAttribute("location", "http://"+context.GetServerName( )+((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "")+context.GetScriptPath( )+"wwpbaseobjects.gethomesampledata.aspx");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.Close();
               return  ;
            }
            else
            {
               currSoapErr = (short)(-20000);
               currSoapErrmsg = "No SOAP request found. Call " + "http://" + context.GetServerName( ) + ((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "") + context.GetScriptPath( ) + "wwpbaseobjects.gethomesampledata.aspx" + "?wsdl to get the WSDL.";
            }
         }
         if ( currSoapErr == 0 )
         {
            GXSoapXMLReader.OpenRequest(GXSoapHTTPRequest);
            GXSoapXMLReader.IgnoreComments = 1;
            GXSoapError = GXSoapXMLReader.Read();
            while ( GXSoapError > 0 )
            {
               this.SetPrefixesFromReader( GXSoapXMLReader);
               if ( StringUtil.StringSearch( GXSoapXMLReader.Name, "Body", 1) > 0 )
               {
                  if (true) break;
               }
               GXSoapError = GXSoapXMLReader.Read();
            }
            if ( GXSoapError > 0 )
            {
               GXSoapError = GXSoapXMLReader.Read();
               if ( GXSoapError > 0 )
               {
                  this.SetPrefixesFromReader( GXSoapXMLReader);
                  currMethod = GXSoapXMLReader.Name;
                  if ( StringUtil.StringSearch( currMethod+"&", "Execute&", 1) > 0 )
                  {
                     if ( currSoapErr == 0 )
                     {
                        Gxm2rootcol = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem>( context, "HomeSampleDataItem", "SeriesColaborativas");
                     }
                  }
                  else
                  {
                     currSoapErr = (short)(-20002);
                     currSoapErrmsg = "Wrong method called. Expected method: " + "Execute";
                  }
               }
            }
            GXSoapXMLReader.Close();
         }
         if ( currSoapErr == 0 )
         {
            if ( GXSoapError < 0 )
            {
               currSoapErr = (short)(GXSoapError*-1);
               currSoapErrmsg = context.sSOAPErrMsg;
            }
            else
            {
               if ( GXSoapXMLReader.ErrCode > 0 )
               {
                  currSoapErr = (short)(GXSoapXMLReader.ErrCode*-1);
                  currSoapErrmsg = GXSoapXMLReader.ErrDescription;
               }
               else
               {
                  if ( GXSoapError == 0 )
                  {
                     currSoapErr = (short)(-20001);
                     currSoapErrmsg = "Malformed SOAP message.";
                  }
                  else
                  {
                     currSoapErr = 0;
                     currSoapErrmsg = "No error.";
                  }
               }
            }
         }
         if ( currSoapErr == 0 )
         {
            executePrivate();
         }
         context.CloseConnections() ;
         GXSoapXMLWriter.OpenResponse(GXSoapHTTPResponse);
         GXSoapXMLWriter.WriteStartDocument("utf-8", 0);
         GXSoapXMLWriter.WriteStartElement("SOAP-ENV:Envelope");
         GXSoapXMLWriter.WriteAttribute("xmlns:SOAP-ENV", "http://schemas.xmlsoap.org/soap/envelope/");
         GXSoapXMLWriter.WriteAttribute("xmlns:xsd", "http://www.w3.org/2001/XMLSchema");
         GXSoapXMLWriter.WriteAttribute("xmlns:SOAP-ENC", "http://schemas.xmlsoap.org/soap/encoding/");
         GXSoapXMLWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
         if ( StringUtil.StringSearch( currMethod+"&", "Execute&", 1) > 0 )
         {
            GXSoapXMLWriter.WriteStartElement("SOAP-ENV:Body");
            GXSoapXMLWriter.WriteStartElement("WWPBaseObjects.GetHomeSampleData.ExecuteResponse");
            GXSoapXMLWriter.WriteAttribute("xmlns", "SeriesColaborativas");
            if ( currSoapErr == 0 )
            {
               if ( Gxm2rootcol != null )
               {
                  Gxm2rootcol.writexmlcollection(GXSoapXMLWriter, "ReturnValue", "SeriesColaborativas", "HomeSampleDataItem", "SeriesColaborativas");
               }
            }
            else
            {
               GXSoapXMLWriter.WriteStartElement("SOAP-ENV:Fault");
               GXSoapXMLWriter.WriteElement("faultcode", "SOAP-ENV:Client");
               GXSoapXMLWriter.WriteElement("faultstring", currSoapErrmsg);
               GXSoapXMLWriter.WriteElement("detail", StringUtil.Trim( StringUtil.Str( (decimal)(currSoapErr), 10, 0)));
               GXSoapXMLWriter.WriteEndElement();
            }
            GXSoapXMLWriter.WriteEndElement();
            GXSoapXMLWriter.WriteEndElement();
         }
         GXSoapXMLWriter.WriteEndElement();
         GXSoapXMLWriter.Close();
         cleanup();
      }

      public gethomesampledata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gethomesampledata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem> aP0_Gxm2rootcol )
      {
         this.Gxm2rootcol = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem>( context, "HomeSampleDataItem", "SeriesColaborativas") ;
         initialize();
         executePrivate();
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      public GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem> executeUdp( )
      {
         this.Gxm2rootcol = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem>( context, "HomeSampleDataItem", "SeriesColaborativas") ;
         initialize();
         executePrivate();
         aP0_Gxm2rootcol=this.Gxm2rootcol;
         return Gxm2rootcol ;
      }

      public void executeSubmit( out GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem> aP0_Gxm2rootcol )
      {
         gethomesampledata objgethomesampledata;
         objgethomesampledata = new gethomesampledata();
         objgethomesampledata.Gxm2rootcol = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem>( context, "HomeSampleDataItem", "SeriesColaborativas") ;
         objgethomesampledata.context.SetSubmitInitialConfig(context);
         objgethomesampledata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgethomesampledata);
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gethomesampledata)stateInfo).executePrivate();
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
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2rootcol.Add(Gxm1homesampledata, 0);
         Gxm1homesampledata.gxTpr_Productname = "Beer";
         Gxm1homesampledata.gxTpr_Productprice = (decimal)(1200);
         Gxm1homesampledata.gxTpr_Productvolume = (decimal)(2000);
         Gxm1homesampledata.gxTpr_Productweight = (decimal)(400);
         Gxm1homesampledata.gxTpr_Productdiscount = (decimal)(10);
         Gxm1homesampledata.gxTpr_Productstatus = 1;
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2rootcol.Add(Gxm1homesampledata, 0);
         Gxm1homesampledata.gxTpr_Productname = "Tannat Wine";
         Gxm1homesampledata.gxTpr_Productprice = (decimal)(890);
         Gxm1homesampledata.gxTpr_Productvolume = (decimal)(100);
         Gxm1homesampledata.gxTpr_Productweight = (decimal)(3000);
         Gxm1homesampledata.gxTpr_Productdiscount = (decimal)(12);
         Gxm1homesampledata.gxTpr_Productstatus = 2;
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2rootcol.Add(Gxm1homesampledata, 0);
         Gxm1homesampledata.gxTpr_Productname = "Lollipop";
         Gxm1homesampledata.gxTpr_Productprice = (decimal)(200);
         Gxm1homesampledata.gxTpr_Productvolume = (decimal)(3098);
         Gxm1homesampledata.gxTpr_Productweight = (decimal)(250);
         Gxm1homesampledata.gxTpr_Productdiscount = (decimal)(20);
         Gxm1homesampledata.gxTpr_Productstatus = 3;
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2rootcol.Add(Gxm1homesampledata, 0);
         Gxm1homesampledata.gxTpr_Productname = "Green Apple";
         Gxm1homesampledata.gxTpr_Productprice = (decimal)(48);
         Gxm1homesampledata.gxTpr_Productvolume = (decimal)(879);
         Gxm1homesampledata.gxTpr_Productweight = (decimal)(235);
         Gxm1homesampledata.gxTpr_Productdiscount = (decimal)(42);
         Gxm1homesampledata.gxTpr_Productstatus = 1;
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2rootcol.Add(Gxm1homesampledata, 0);
         Gxm1homesampledata.gxTpr_Productname = "Delicious Cherries";
         Gxm1homesampledata.gxTpr_Productprice = (decimal)(232);
         Gxm1homesampledata.gxTpr_Productvolume = (decimal)(6788);
         Gxm1homesampledata.gxTpr_Productweight = (decimal)(213);
         Gxm1homesampledata.gxTpr_Productdiscount = (decimal)(34);
         Gxm1homesampledata.gxTpr_Productstatus = 4;
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2rootcol.Add(Gxm1homesampledata, 0);
         Gxm1homesampledata.gxTpr_Productname = "Steak";
         Gxm1homesampledata.gxTpr_Productprice = (decimal)(345);
         Gxm1homesampledata.gxTpr_Productvolume = (decimal)(370);
         Gxm1homesampledata.gxTpr_Productweight = (decimal)(230);
         Gxm1homesampledata.gxTpr_Productdiscount = (decimal)(0);
         Gxm1homesampledata.gxTpr_Productstatus = 1;
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2rootcol.Add(Gxm1homesampledata, 0);
         Gxm1homesampledata.gxTpr_Productname = "Cupcake";
         Gxm1homesampledata.gxTpr_Productprice = (decimal)(340);
         Gxm1homesampledata.gxTpr_Productvolume = (decimal)(1200);
         Gxm1homesampledata.gxTpr_Productweight = (decimal)(230);
         Gxm1homesampledata.gxTpr_Productdiscount = (decimal)(10);
         Gxm1homesampledata.gxTpr_Productstatus = 4;
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2rootcol.Add(Gxm1homesampledata, 0);
         Gxm1homesampledata.gxTpr_Productname = "Strawberry";
         Gxm1homesampledata.gxTpr_Productprice = (decimal)(120);
         Gxm1homesampledata.gxTpr_Productvolume = (decimal)(600);
         Gxm1homesampledata.gxTpr_Productweight = (decimal)(239);
         Gxm1homesampledata.gxTpr_Productdiscount = (decimal)(10);
         Gxm1homesampledata.gxTpr_Productstatus = 1;
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2rootcol.Add(Gxm1homesampledata, 0);
         Gxm1homesampledata.gxTpr_Productname = "Ice cream";
         Gxm1homesampledata.gxTpr_Productprice = (decimal)(70);
         Gxm1homesampledata.gxTpr_Productvolume = (decimal)(1200);
         Gxm1homesampledata.gxTpr_Productweight = (decimal)(120);
         Gxm1homesampledata.gxTpr_Productdiscount = (decimal)(8);
         Gxm1homesampledata.gxTpr_Productstatus = 2;
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2rootcol.Add(Gxm1homesampledata, 0);
         Gxm1homesampledata.gxTpr_Productname = "Frapuccino";
         Gxm1homesampledata.gxTpr_Productprice = (decimal)(670);
         Gxm1homesampledata.gxTpr_Productvolume = (decimal)(124);
         Gxm1homesampledata.gxTpr_Productweight = (decimal)(489);
         Gxm1homesampledata.gxTpr_Productdiscount = (decimal)(5);
         Gxm1homesampledata.gxTpr_Productstatus = 1;
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2rootcol.Add(Gxm1homesampledata, 0);
         Gxm1homesampledata.gxTpr_Productname = "Candy";
         Gxm1homesampledata.gxTpr_Productprice = (decimal)(1200);
         Gxm1homesampledata.gxTpr_Productvolume = (decimal)(2000);
         Gxm1homesampledata.gxTpr_Productweight = (decimal)(400);
         Gxm1homesampledata.gxTpr_Productdiscount = (decimal)(10);
         Gxm1homesampledata.gxTpr_Productstatus = 1;
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2rootcol.Add(Gxm1homesampledata, 0);
         Gxm1homesampledata.gxTpr_Productname = "Pizza";
         Gxm1homesampledata.gxTpr_Productprice = (decimal)(3400);
         Gxm1homesampledata.gxTpr_Productvolume = (decimal)(120);
         Gxm1homesampledata.gxTpr_Productweight = (decimal)(320);
         Gxm1homesampledata.gxTpr_Productdiscount = (decimal)(8);
         Gxm1homesampledata.gxTpr_Productstatus = 4;
         if ( context.WillRedirect( ) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "";
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         base.cleanup();
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
         GXSoapHTTPRequest = new GxHttpRequest(context) ;
         GXSoapXMLReader = new GXXMLReader(context.GetPhysicalPath());
         GXSoapHTTPResponse = new GxHttpResponse(context) ;
         GXSoapXMLWriter = new GXXMLWriter(context.GetPhysicalPath());
         currSoapErrmsg = "";
         currMethod = "";
         Gxm1homesampledata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short GXSoapError ;
      private short currSoapErr ;
      private String currSoapErrmsg ;
      private String currMethod ;
      private GXXMLReader GXSoapXMLReader ;
      private GXXMLWriter GXSoapXMLWriter ;
      private GxHttpRequest GXSoapHTTPRequest ;
      private GxHttpResponse GXSoapHTTPResponse ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem> aP0_Gxm2rootcol ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem> Gxm2rootcol ;
      private GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem Gxm1homesampledata ;
   }

}
