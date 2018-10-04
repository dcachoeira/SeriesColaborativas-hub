/*
				   File: type_SdtWWPTransactionContext_Attribute
			Description: Attributes
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
	[XmlRoot(ElementName="WWPTransactionContext.Attribute")]
	[XmlType(TypeName="WWPTransactionContext.Attribute" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtWWPTransactionContext_Attribute : GxUserType
	{
		public SdtWWPTransactionContext_Attribute( )
		{
			/* Constructor for serialization */
			gxTv_SdtWWPTransactionContext_Attribute_Attributename = "";

			gxTv_SdtWWPTransactionContext_Attribute_Attributevalue = "";

		}

		public SdtWWPTransactionContext_Attribute(IGxContext context)
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
			AddObjectProperty("AttributeName", gxTpr_Attributename, false);
			AddObjectProperty("AttributeValue", gxTpr_Attributevalue, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="AttributeName")]
		[XmlElement(ElementName="AttributeName")]
		public String gxTpr_Attributename
		{
			get { 
				return gxTv_SdtWWPTransactionContext_Attribute_Attributename; 
			}
			set { 
				gxTv_SdtWWPTransactionContext_Attribute_Attributename = value;
				SetDirty("Attributename");
			}
		}


		[SoapElement(ElementName="AttributeValue")]
		[XmlElement(ElementName="AttributeValue")]
		public String gxTpr_Attributevalue
		{
			get { 
				return gxTv_SdtWWPTransactionContext_Attribute_Attributevalue; 
			}
			set { 
				gxTv_SdtWWPTransactionContext_Attribute_Attributevalue = value;
				SetDirty("Attributevalue");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtWWPTransactionContext_Attribute_Attributename = "";
			gxTv_SdtWWPTransactionContext_Attribute_Attributevalue = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtWWPTransactionContext_Attribute_Attributename;
		protected String gxTv_SdtWWPTransactionContext_Attribute_Attributevalue;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"WWPTransactionContext.Attribute", Namespace="SeriesColaborativas")]
	public class SdtWWPTransactionContext_Attribute_RESTInterface : GxGenericCollectionItem<SdtWWPTransactionContext_Attribute>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtWWPTransactionContext_Attribute_RESTInterface( ) : base()
		{
		}

		public SdtWWPTransactionContext_Attribute_RESTInterface( SdtWWPTransactionContext_Attribute psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="AttributeName", Order=0)]
		public String gxTpr_Attributename
		{
			get { 
				return sdt.gxTpr_Attributename;
			}
			set { 
				sdt.gxTpr_Attributename = value;
			}
		}

		[DataMember(Name="AttributeValue", Order=1)]
		public String gxTpr_Attributevalue
		{
			get { 
				return sdt.gxTpr_Attributevalue;
			}
			set { 
				sdt.gxTpr_Attributevalue = value;
			}
		}


		#endregion

		public SdtWWPTransactionContext_Attribute sdt
		{
			get { 
				return (SdtWWPTransactionContext_Attribute)Sdt;
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
				sdt = new SdtWWPTransactionContext_Attribute() ;
			}
		}
	}
	#endregion
}