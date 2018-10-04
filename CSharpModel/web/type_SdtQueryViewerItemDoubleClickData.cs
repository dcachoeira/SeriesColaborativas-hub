/*
				   File: type_SdtQueryViewerItemDoubleClickData
			Description: QueryViewerItemDoubleClickData
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
	[XmlRoot(ElementName="QueryViewerItemDoubleClickData")]
	[XmlType(TypeName="QueryViewerItemDoubleClickData" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtQueryViewerItemDoubleClickData : GxUserType
	{
		public SdtQueryViewerItemDoubleClickData( )
		{
			/* Constructor for serialization */
			gxTv_SdtQueryViewerItemDoubleClickData_Name = "";

			gxTv_SdtQueryViewerItemDoubleClickData_Axis = "";

			gxTv_SdtQueryViewerItemDoubleClickData_Value = "";

		}

		public SdtQueryViewerItemDoubleClickData(IGxContext context)
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
			AddObjectProperty("Axis", gxTpr_Axis, false);
			AddObjectProperty("Value", gxTpr_Value, false);
			AddObjectProperty("Context", gxTv_SdtQueryViewerItemDoubleClickData_Context, false);  
			AddObjectProperty("Filters", gxTv_SdtQueryViewerItemDoubleClickData_Filters, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtQueryViewerItemDoubleClickData_Name; 
			}
			set { 
				gxTv_SdtQueryViewerItemDoubleClickData_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="Axis")]
		[XmlElement(ElementName="Axis")]
		public String gxTpr_Axis
		{
			get { 
				return gxTv_SdtQueryViewerItemDoubleClickData_Axis; 
			}
			set { 
				gxTv_SdtQueryViewerItemDoubleClickData_Axis = value;
				SetDirty("Axis");
			}
		}


		[SoapElement(ElementName="Value")]
		[XmlElement(ElementName="Value")]
		public String gxTpr_Value
		{
			get { 
				return gxTv_SdtQueryViewerItemDoubleClickData_Value; 
			}
			set { 
				gxTv_SdtQueryViewerItemDoubleClickData_Value = value;
				SetDirty("Value");
			}
		}


		[SoapElement(ElementName="Context" )]
		[XmlArray(ElementName="Context"  )]
		[XmlArrayItemAttribute(ElementName="Element" , IsNullable=false )]
		public GXBaseCollection<SdtQueryViewerItemDoubleClickData_Element> gxTpr_Context
		{
			get {
				if ( gxTv_SdtQueryViewerItemDoubleClickData_Context == null )
				{
					gxTv_SdtQueryViewerItemDoubleClickData_Context = new GXBaseCollection<SdtQueryViewerItemDoubleClickData_Element>( context, "QueryViewerItemDoubleClickData.Element", "");
				}
				return gxTv_SdtQueryViewerItemDoubleClickData_Context;
			}
			set {
				if ( gxTv_SdtQueryViewerItemDoubleClickData_Context == null )
				{
					gxTv_SdtQueryViewerItemDoubleClickData_Context = new GXBaseCollection<SdtQueryViewerItemDoubleClickData_Element>( context, "QueryViewerItemDoubleClickData.Element", "");
				}
				gxTv_SdtQueryViewerItemDoubleClickData_Context = value;
				SetDirty("Context");
			}
		}public void gxTv_SdtQueryViewerItemDoubleClickData_Context_SetNull()
		{
			gxTv_SdtQueryViewerItemDoubleClickData_Context = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerItemDoubleClickData_Context_IsNull()
		{
			if (gxTv_SdtQueryViewerItemDoubleClickData_Context == null)
			{
				return true ;
			}
			return false ;
		}



		[SoapElement(ElementName="Filters" )]
		[XmlArray(ElementName="Filters"  )]
		[XmlArrayItemAttribute(ElementName="Filter" , IsNullable=false )]
		public GXBaseCollection<SdtQueryViewerItemDoubleClickData_Filter> gxTpr_Filters
		{
			get {
				if ( gxTv_SdtQueryViewerItemDoubleClickData_Filters == null )
				{
					gxTv_SdtQueryViewerItemDoubleClickData_Filters = new GXBaseCollection<SdtQueryViewerItemDoubleClickData_Filter>( context, "QueryViewerItemDoubleClickData.Filter", "");
				}
				return gxTv_SdtQueryViewerItemDoubleClickData_Filters;
			}
			set {
				if ( gxTv_SdtQueryViewerItemDoubleClickData_Filters == null )
				{
					gxTv_SdtQueryViewerItemDoubleClickData_Filters = new GXBaseCollection<SdtQueryViewerItemDoubleClickData_Filter>( context, "QueryViewerItemDoubleClickData.Filter", "");
				}
				gxTv_SdtQueryViewerItemDoubleClickData_Filters = value;
				SetDirty("Filters");
			}
		}public void gxTv_SdtQueryViewerItemDoubleClickData_Filters_SetNull()
		{
			gxTv_SdtQueryViewerItemDoubleClickData_Filters = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerItemDoubleClickData_Filters_IsNull()
		{
			if (gxTv_SdtQueryViewerItemDoubleClickData_Filters == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtQueryViewerItemDoubleClickData_Name = "";
			gxTv_SdtQueryViewerItemDoubleClickData_Axis = "";
			gxTv_SdtQueryViewerItemDoubleClickData_Value = "";


			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtQueryViewerItemDoubleClickData_Name;
		protected String gxTv_SdtQueryViewerItemDoubleClickData_Axis;
		protected String gxTv_SdtQueryViewerItemDoubleClickData_Value;
		protected GXBaseCollection<SdtQueryViewerItemDoubleClickData_Element> gxTv_SdtQueryViewerItemDoubleClickData_Context = null; protected GXBaseCollection<SdtQueryViewerItemDoubleClickData_Filter> gxTv_SdtQueryViewerItemDoubleClickData_Filters = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"QueryViewerItemDoubleClickData", Namespace="SeriesColaborativas")]
	public class SdtQueryViewerItemDoubleClickData_RESTInterface : GxGenericCollectionItem<SdtQueryViewerItemDoubleClickData>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtQueryViewerItemDoubleClickData_RESTInterface( ) : base()
		{
		}

		public SdtQueryViewerItemDoubleClickData_RESTInterface( SdtQueryViewerItemDoubleClickData psdt ) : base(psdt)
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

		[DataMember(Name="Axis", Order=1)]
		public String gxTpr_Axis
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Axis);
			}
			set { 
				sdt.gxTpr_Axis = value;
			}
		}

		[DataMember(Name="Value", Order=2)]
		public String gxTpr_Value
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Value);
			}
			set { 
				sdt.gxTpr_Value = value;
			}
		}

		[DataMember(Name="Context", Order=3)]
		public GxGenericCollection<SdtQueryViewerItemDoubleClickData_Element_RESTInterface> gxTpr_Context
		{
			get {
				return new GxGenericCollection<SdtQueryViewerItemDoubleClickData_Element_RESTInterface>(sdt.gxTpr_Context) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Context);
			}

		}

		[DataMember(Name="Filters", Order=4)]
		public GxGenericCollection<SdtQueryViewerItemDoubleClickData_Filter_RESTInterface> gxTpr_Filters
		{
			get {
				return new GxGenericCollection<SdtQueryViewerItemDoubleClickData_Filter_RESTInterface>(sdt.gxTpr_Filters) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Filters);
			}

		}


		#endregion

		public SdtQueryViewerItemDoubleClickData sdt
		{
			get { 
				return (SdtQueryViewerItemDoubleClickData)Sdt;
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
				sdt = new SdtQueryViewerItemDoubleClickData() ;
			}
		}
	}
	#endregion
}