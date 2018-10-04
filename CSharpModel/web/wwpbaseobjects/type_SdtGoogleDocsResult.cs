/*
				   File: type_SdtGoogleDocsResult
			Description: GoogleDocsResult
				 Author: Nemo for C# version 15.0.9.121631
		   Generated on: 20/09/2018 19:47:45
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
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
using GeneXus.Programs;
namespace GeneXus.Programs.wwpbaseobjects{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="Result")]
	[XmlType(TypeName="Result" , Namespace="DVelop.Extensions.GoogleDocs" )]
	[Serializable]
	public class SdtGoogleDocsResult : GxUserType
	{
		public SdtGoogleDocsResult( )
		{
			/* Constructor for serialization */
			gxTv_SdtGoogleDocsResult_Error = "";

		}

		public SdtGoogleDocsResult(IGxContext context)
		{
			this.context = context;
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override String JsonMap(String value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
			}
			return (String)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			AddObjectProperty("Success", gxTpr_Success, false);
			AddObjectProperty("Error", gxTpr_Error, false);
			AddObjectProperty("Docs", gxTv_SdtGoogleDocsResult_Docs, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Success")]
		[XmlElement(ElementName="Success")]
		public bool gxTpr_Success
		{
			get { 
				return gxTv_SdtGoogleDocsResult_Success; 
			}
			set { 
				gxTv_SdtGoogleDocsResult_Success = value;
				SetDirty("Success");
			}
		}


		[SoapElement(ElementName="Error")]
		[XmlElement(ElementName="Error")]
		public String gxTpr_Error
		{
			get { 
				return gxTv_SdtGoogleDocsResult_Error; 
			}
			set { 
				gxTv_SdtGoogleDocsResult_Error = value;
				SetDirty("Error");
			}
		}


		[SoapElement(ElementName="Docs" )]
		[XmlArray(ElementName="Docs"  )]
		[XmlArrayItemAttribute(ElementName="Doc" , IsNullable=false )]
		public GXBaseCollection<SdtGoogleDocsResult_Doc> gxTpr_Docs
		{
			get {
				if ( gxTv_SdtGoogleDocsResult_Docs == null )
				{
					gxTv_SdtGoogleDocsResult_Docs = new GXBaseCollection<SdtGoogleDocsResult_Doc>( context, "GoogleDocsResult.Doc", "");
				}
				return gxTv_SdtGoogleDocsResult_Docs;
			}
			set {
				if ( gxTv_SdtGoogleDocsResult_Docs == null )
				{
					gxTv_SdtGoogleDocsResult_Docs = new GXBaseCollection<SdtGoogleDocsResult_Doc>( context, "GoogleDocsResult.Doc", "");
				}
				gxTv_SdtGoogleDocsResult_Docs = value;
				SetDirty("Docs");
			}
		}public void gxTv_SdtGoogleDocsResult_Docs_SetNull()
		{
			gxTv_SdtGoogleDocsResult_Docs = null;
			return  ;
		}

		public bool gxTv_SdtGoogleDocsResult_Docs_IsNull()
		{
			if (gxTv_SdtGoogleDocsResult_Docs == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtGoogleDocsResult_Error = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected bool gxTv_SdtGoogleDocsResult_Success;
		protected String gxTv_SdtGoogleDocsResult_Error;
		protected GXBaseCollection<SdtGoogleDocsResult_Doc> gxTv_SdtGoogleDocsResult_Docs = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"Result", Namespace="DVelop.Extensions.GoogleDocs")]
	public class SdtGoogleDocsResult_RESTInterface : GxGenericCollectionItem<SdtGoogleDocsResult>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtGoogleDocsResult_RESTInterface( ) : base()
		{
		}

		public SdtGoogleDocsResult_RESTInterface( SdtGoogleDocsResult psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Success", Order=0)]
		public bool gxTpr_Success
		{
			get { 
				return sdt.gxTpr_Success;
			}
			set { 
				sdt.gxTpr_Success = value;
			}
		}

		[DataMember(Name="Error", Order=1)]
		public String gxTpr_Error
		{
			get { 
				return sdt.gxTpr_Error;
			}
			set { 
				sdt.gxTpr_Error = value;
			}
		}

		[DataMember(Name="Docs", Order=2)]
		public GxGenericCollection<SdtGoogleDocsResult_Doc_RESTInterface> gxTpr_Docs
		{
			get {
				return new GxGenericCollection<SdtGoogleDocsResult_Doc_RESTInterface>(sdt.gxTpr_Docs) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Docs);
			}

		}


		#endregion

		public SdtGoogleDocsResult sdt
		{
			get { 
				return (SdtGoogleDocsResult)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtGoogleDocsResult() ;
			}
		}
	}
	#endregion
}