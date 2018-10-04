/*
               File: WWPBaseObjects.GetHomeSampleNameValueData
        Description: Get Home Sample Name Value Data
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:30.29
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
   public class gethomesamplenamevaluedata : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         initialize();
         Gxm3rootcol = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem>( context, "HomeSampleNameValueDataItem", "SeriesColaborativas") ;
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
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleNameValueData");
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
               GXSoapXMLWriter.WriteAttribute("name", "HomeSampleNameValueData");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "0");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "unbounded");
               GXSoapXMLWriter.WriteAttribute("name", "HomeSampleNameValueDataItem");
               GXSoapXMLWriter.WriteAttribute("type", "tns:WWPBaseObjects.HomeSampleNameValueData.HomeSampleNameValueDataItem");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.HomeSampleNameValueData.HomeSampleNameValueDataItem");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "Name");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:string");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "Value");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "Check");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:boolean");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleNameValueData.Execute");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleNameValueData.ExecuteResponse");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "ReturnValue");
               GXSoapXMLWriter.WriteAttribute("type", "tns:HomeSampleNameValueData");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleNameValueData.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:WWPBaseObjects.GetHomeSampleNameValueData.Execute");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleNameValueData.ExecuteSoapOut");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:WWPBaseObjects.GetHomeSampleNameValueData.ExecuteResponse");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("portType");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleNameValueDataSoapPort");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("input", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"WWPBaseObjects.GetHomeSampleNameValueData.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("output", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"WWPBaseObjects.GetHomeSampleNameValueData.ExecuteSoapOut");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("binding");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleNameValueDataSoapBinding");
               GXSoapXMLWriter.WriteAttribute("type", "wsdlns:"+"WWPBaseObjects.GetHomeSampleNameValueDataSoapPort");
               GXSoapXMLWriter.WriteElement("soap:binding", "");
               GXSoapXMLWriter.WriteAttribute("style", "document");
               GXSoapXMLWriter.WriteAttribute("transport", "http://schemas.xmlsoap.org/soap/http");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("soap:operation", "");
               GXSoapXMLWriter.WriteAttribute("soapAction", "SeriesColaborativasaction/"+"wwpbaseobjects.AGETHOMESAMPLENAMEVALUEDATA.Execute");
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
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleNameValueData");
               GXSoapXMLWriter.WriteStartElement("port");
               GXSoapXMLWriter.WriteAttribute("name", "WWPBaseObjects.GetHomeSampleNameValueDataSoapPort");
               GXSoapXMLWriter.WriteAttribute("binding", "wsdlns:"+"WWPBaseObjects.GetHomeSampleNameValueDataSoapBinding");
               GXSoapXMLWriter.WriteElement("soap:address", "");
               GXSoapXMLWriter.WriteAttribute("location", "http://"+context.GetServerName( )+((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "")+context.GetScriptPath( )+"wwpbaseobjects.gethomesamplenamevaluedata.aspx");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.Close();
               return  ;
            }
            else
            {
               currSoapErr = (short)(-20000);
               currSoapErrmsg = "No SOAP request found. Call " + "http://" + context.GetServerName( ) + ((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "") + context.GetScriptPath( ) + "wwpbaseobjects.gethomesamplenamevaluedata.aspx" + "?wsdl to get the WSDL.";
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
                        Gxm3rootcol = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem>( context, "HomeSampleNameValueDataItem", "SeriesColaborativas");
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
            GXSoapXMLWriter.WriteStartElement("WWPBaseObjects.GetHomeSampleNameValueData.ExecuteResponse");
            GXSoapXMLWriter.WriteAttribute("xmlns", "SeriesColaborativas");
            if ( currSoapErr == 0 )
            {
               if ( Gxm3rootcol != null )
               {
                  Gxm3rootcol.writexmlcollection(GXSoapXMLWriter, "ReturnValue", "SeriesColaborativas", "HomeSampleNameValueDataItem", "SeriesColaborativas");
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

      public gethomesamplenamevaluedata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gethomesamplenamevaluedata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem> aP0_Gxm3rootcol )
      {
         this.Gxm3rootcol = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem>( context, "HomeSampleNameValueDataItem", "SeriesColaborativas") ;
         initialize();
         executePrivate();
         aP0_Gxm3rootcol=this.Gxm3rootcol;
      }

      public GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem> executeUdp( )
      {
         this.Gxm3rootcol = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem>( context, "HomeSampleNameValueDataItem", "SeriesColaborativas") ;
         initialize();
         executePrivate();
         aP0_Gxm3rootcol=this.Gxm3rootcol;
         return Gxm3rootcol ;
      }

      public void executeSubmit( out GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem> aP0_Gxm3rootcol )
      {
         gethomesamplenamevaluedata objgethomesamplenamevaluedata;
         objgethomesamplenamevaluedata = new gethomesamplenamevaluedata();
         objgethomesamplenamevaluedata.Gxm3rootcol = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem>( context, "HomeSampleNameValueDataItem", "SeriesColaborativas") ;
         objgethomesamplenamevaluedata.context.SetSubmitInitialConfig(context);
         objgethomesamplenamevaluedata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgethomesamplenamevaluedata);
         aP0_Gxm3rootcol=this.Gxm3rootcol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gethomesamplenamevaluedata)stateInfo).executePrivate();
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
         GXt_objcol_SdtHomeSampleData_HomeSampleDataItem1 = AV5HomeSampleData;
         new GeneXus.Programs.wwpbaseobjects.gethomesampledata(context ).execute( out  GXt_objcol_SdtHomeSampleData_HomeSampleDataItem1) ;
         AV5HomeSampleData = GXt_objcol_SdtHomeSampleData_HomeSampleDataItem1;
         Gxv1skipcount = 0;
         AV12GXV1 = 1;
         while ( AV12GXV1 <= AV5HomeSampleData.Count )
         {
            AV6HomeSampleDataItem = ((GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem)AV5HomeSampleData.Item(AV12GXV1));
            Gxv1skipcount = (int)(Gxv1skipcount+1);
            Gxm2homesamplenamevaluedata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem(context);
            Gxm3rootcol.Add(Gxm2homesamplenamevaluedata, 0);
            Gxm2homesamplenamevaluedata.gxTpr_Name = AV6HomeSampleDataItem.gxTpr_Productname;
            Gxm2homesamplenamevaluedata.gxTpr_Value = AV6HomeSampleDataItem.gxTpr_Productprice;
            if ( ( 6 != 0 ) && ( Gxv1skipcount >= 6 ) )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            AV12GXV1 = (int)(AV12GXV1+1);
         }
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
         AV5HomeSampleData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem>( context, "HomeSampleDataItem", "SeriesColaborativas");
         GXt_objcol_SdtHomeSampleData_HomeSampleDataItem1 = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem>( context, "HomeSampleDataItem", "SeriesColaborativas");
         AV6HomeSampleDataItem = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem(context);
         Gxm2homesamplenamevaluedata = new GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short GXSoapError ;
      private short currSoapErr ;
      private int Gxv1skipcount ;
      private int AV12GXV1 ;
      private String currSoapErrmsg ;
      private String currMethod ;
      private GXXMLReader GXSoapXMLReader ;
      private GXXMLWriter GXSoapXMLWriter ;
      private GxHttpRequest GXSoapHTTPRequest ;
      private GxHttpResponse GXSoapHTTPResponse ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem> aP0_Gxm3rootcol ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem> AV5HomeSampleData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem> GXt_objcol_SdtHomeSampleData_HomeSampleDataItem1 ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem> Gxm3rootcol ;
      private GeneXus.Programs.wwpbaseobjects.SdtHomeSampleData_HomeSampleDataItem AV6HomeSampleDataItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtHomeSampleNameValueData_HomeSampleNameValueDataItem Gxm2homesamplenamevaluedata ;
   }

}
