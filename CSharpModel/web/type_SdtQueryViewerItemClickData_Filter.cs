/*
				   File: type_SdtQueryViewerItemClickData_Filter
			Description: Filters
				 Author: Nemo for C# version 15.0.9.121631
		   Generated on: 20/09/2018 19:47:44
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

namespace GeneXus.Programs{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="QueryViewerItemClickData.Filter")]
	[XmlType(TypeName="QueryViewerItemClickData.Filter" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtQueryViewerItemClickData_Filter : GxUserType
	{
		public SdtQueryViewerItemClickData_Filter( )
		{
			/* Constructor for serialization */
			gxTv_SdtQueryViewerItemClickData_Filter_Name = "";

		}

		public SdtQueryViewerItemClickData_Filter(IGxContext context)
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
			AddObjectProperty("Name", gxTpr_Name, false);
			AddObjectProperty("Values", gxTv_SdtQueryViewerItemClickData_Filter_Values, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtQueryViewerItemClickData_Filter_Name; 
			}
			set { 
				gxTv_SdtQueryViewerItemClickData_Filter_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="Values" )]
		[XmlArray(ElementName="Values"  )]
		[XmlArrayItemAttribute(ElementName="Item" , IsNullable=false )]
		public GxSimpleCollection<String> gxTpr_Values_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtQueryViewerItemClickData_Filter_Values == null )
				{
					gxTv_SdtQueryViewerItemClickData_Filter_Values = new GxSimpleCollection<String>( );
				}
				return gxTv_SdtQueryViewerItemClickData_Filter_Values;
			}
			set {
				if ( gxTv_SdtQueryViewerItemClickData_Filter_Values == null )
				{
					gxTv_SdtQueryViewerItemClickData_Filter_Values = new GxSimpleCollection<String>( );
				}
				gxTv_SdtQueryViewerItemClickData_Filter_Values = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GxSimpleCollection<String> gxTpr_Values
		{
			get {
				if ( gxTv_SdtQueryViewerItemClickData_Filter_Values == null )
				{
					gxTv_SdtQueryViewerItemClickData_Filter_Values = new GxSimpleCollection<String>();
				}
				return gxTv_SdtQueryViewerItemClickData_Filter_Values ;
			}
			set {
				gxTv_SdtQueryViewerItemClickData_Filter_Values = value;
				SetDirty("Values");
			}
		}

		public void gxTv_SdtQueryViewerItemClickData_Filter_Values_SetNull()
		{
			gxTv_SdtQueryViewerItemClickData_Filter_Values = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerItemClickData_Filter_Values_IsNull()
		{
			if (gxTv_SdtQueryViewerItemClickData_Filter_Values == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtQueryViewerItemClickData_Filter_Name = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtQueryViewerItemClickData_Filter_Name;
		protected GxSimpleCollection<String> gxTv_SdtQueryViewerItemClickData_Filter_Values = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"QueryViewerItemClickData.Filter", Namespace="SeriesColaborativas")]
	public class SdtQueryViewerItemClickData_Filter_RESTInterface : GxGenericCollectionItem<SdtQueryViewerItemClickData_Filter>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtQueryViewerItemClickData_Filter_RESTInterface( ) : base()
		{
		}

		public SdtQueryViewerItemClickData_Filter_RESTInterface( SdtQueryViewerItemClickData_Filter psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Name", Order=0)]
		public String gxTpr_Name
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Name);
			}
			set { 
				sdt.gxTpr_Name = value;
			}
		}

		[DataMember(Name="Values", Order=1)]
		public  GxSimpleCollection<String> gxTpr_Values
		{
			get { 
				return sdt.gxTpr_Values;
			}
			set { 
				sdt.gxTpr_Values = value;
			}
		}


		#endregion

		public SdtQueryViewerItemClickData_Filter sdt
		{
			get { 
				return (SdtQueryViewerItemClickData_Filter)Sdt;
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
				sdt = new SdtQueryViewerItemClickData_Filter() ;
			}
		}
	}
	#endregion
}