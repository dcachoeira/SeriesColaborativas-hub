/*
				   File: type_SdtQueryViewerAxes_Axis
			Description: QueryViewerAxes
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
	[XmlRoot(ElementName="Axis")]
	[XmlType(TypeName="Axis" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtQueryViewerAxes_Axis : GxUserType
	{
		public SdtQueryViewerAxes_Axis( )
		{
			/* Constructor for serialization */
			gxTv_SdtQueryViewerAxes_Axis_Name = "";

			gxTv_SdtQueryViewerAxes_Axis_Title = "";

			gxTv_SdtQueryViewerAxes_Axis_Datafield = "";

			gxTv_SdtQueryViewerAxes_Axis_Type = "";

			gxTv_SdtQueryViewerAxes_Axis_Aggregation = "";

		}

		public SdtQueryViewerAxes_Axis(IGxContext context)
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
			AddObjectProperty("Title", gxTpr_Title, false);
			AddObjectProperty("DataField", gxTpr_Datafield, false);
			AddObjectProperty("Type", gxTpr_Type, false);
			AddObjectProperty("Aggregation", gxTpr_Aggregation, false);
			AddObjectProperty("Filter", gxTv_SdtQueryViewerAxes_Axis_Filter, false);  
			AddObjectProperty("ExpandCollapse", gxTv_SdtQueryViewerAxes_Axis_Expandcollapse, false);  
			AddObjectProperty("AxisOrder", gxTv_SdtQueryViewerAxes_Axis_Axisorder, false);  
			AddObjectProperty("Format", gxTv_SdtQueryViewerAxes_Axis_Format, false);  
			AddObjectProperty("Grouping", gxTv_SdtQueryViewerAxes_Axis_Grouping, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Name; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="Title")]
		[XmlElement(ElementName="Title")]
		public String gxTpr_Title
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Title; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Title = value;
				SetDirty("Title");
			}
		}


		[SoapElement(ElementName="DataField")]
		[XmlElement(ElementName="DataField")]
		public String gxTpr_Datafield
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Datafield; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Datafield = value;
				SetDirty("Datafield");
			}
		}


		[SoapElement(ElementName="Type")]
		[XmlElement(ElementName="Type")]
		public String gxTpr_Type
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Type; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Type = value;
				SetDirty("Type");
			}
		}


		[SoapElement(ElementName="Aggregation")]
		[XmlElement(ElementName="Aggregation")]
		public String gxTpr_Aggregation
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Aggregation; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Aggregation = value;
				SetDirty("Aggregation");
			}
		}

		[SoapElement(ElementName="Filter" )]
		[XmlElement(ElementName="Filter"   )]
		public SdtQueryViewerAxes_Axis_Filter gxTpr_Filter
		{
			get {
				if ( gxTv_SdtQueryViewerAxes_Axis_Filter == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_Filter = new SdtQueryViewerAxes_Axis_Filter(context);
				}
				return gxTv_SdtQueryViewerAxes_Axis_Filter;
			}
			set {
				gxTv_SdtQueryViewerAxes_Axis_Filter = value;
				SetDirty("Filter");
			}

		}public void gxTv_SdtQueryViewerAxes_Axis_Filter_SetNull()
		{
			gxTv_SdtQueryViewerAxes_Axis_Filter = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerAxes_Axis_Filter_IsNull()
		{
			if (gxTv_SdtQueryViewerAxes_Axis_Filter == null)
			{
				return true ;
			}
			return false ;
		}


		[SoapElement(ElementName="ExpandCollapse" )]
		[XmlElement(ElementName="ExpandCollapse"   )]
		public SdtQueryViewerAxes_Axis_ExpandCollapse gxTpr_Expandcollapse
		{
			get {
				if ( gxTv_SdtQueryViewerAxes_Axis_Expandcollapse == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_Expandcollapse = new SdtQueryViewerAxes_Axis_ExpandCollapse(context);
				}
				return gxTv_SdtQueryViewerAxes_Axis_Expandcollapse;
			}
			set {
				gxTv_SdtQueryViewerAxes_Axis_Expandcollapse = value;
				SetDirty("Expandcollapse");
			}

		}public void gxTv_SdtQueryViewerAxes_Axis_Expandcollapse_SetNull()
		{
			gxTv_SdtQueryViewerAxes_Axis_Expandcollapse = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerAxes_Axis_Expandcollapse_IsNull()
		{
			if (gxTv_SdtQueryViewerAxes_Axis_Expandcollapse == null)
			{
				return true ;
			}
			return false ;
		}


		[SoapElement(ElementName="AxisOrder" )]
		[XmlElement(ElementName="AxisOrder"   )]
		public SdtQueryViewerAxes_Axis_AxisOrder gxTpr_Axisorder
		{
			get {
				if ( gxTv_SdtQueryViewerAxes_Axis_Axisorder == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_Axisorder = new SdtQueryViewerAxes_Axis_AxisOrder(context);
				}
				return gxTv_SdtQueryViewerAxes_Axis_Axisorder;
			}
			set {
				gxTv_SdtQueryViewerAxes_Axis_Axisorder = value;
				SetDirty("Axisorder");
			}

		}public void gxTv_SdtQueryViewerAxes_Axis_Axisorder_SetNull()
		{
			gxTv_SdtQueryViewerAxes_Axis_Axisorder = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerAxes_Axis_Axisorder_IsNull()
		{
			if (gxTv_SdtQueryViewerAxes_Axis_Axisorder == null)
			{
				return true ;
			}
			return false ;
		}


		[SoapElement(ElementName="Format" )]
		[XmlElement(ElementName="Format"   )]
		public SdtQueryViewerAxes_Axis_Format gxTpr_Format
		{
			get {
				if ( gxTv_SdtQueryViewerAxes_Axis_Format == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_Format = new SdtQueryViewerAxes_Axis_Format(context);
				}
				return gxTv_SdtQueryViewerAxes_Axis_Format;
			}
			set {
				gxTv_SdtQueryViewerAxes_Axis_Format = value;
				SetDirty("Format");
			}

		}public void gxTv_SdtQueryViewerAxes_Axis_Format_SetNull()
		{
			gxTv_SdtQueryViewerAxes_Axis_Format = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerAxes_Axis_Format_IsNull()
		{
			if (gxTv_SdtQueryViewerAxes_Axis_Format == null)
			{
				return true ;
			}
			return false ;
		}


		[SoapElement(ElementName="Grouping" )]
		[XmlElement(ElementName="Grouping"   )]
		public SdtQueryViewerAxes_Axis_Grouping gxTpr_Grouping
		{
			get {
				if ( gxTv_SdtQueryViewerAxes_Axis_Grouping == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_Grouping = new SdtQueryViewerAxes_Axis_Grouping(context);
				}
				return gxTv_SdtQueryViewerAxes_Axis_Grouping;
			}
			set {
				gxTv_SdtQueryViewerAxes_Axis_Grouping = value;
				SetDirty("Grouping");
			}

		}public void gxTv_SdtQueryViewerAxes_Axis_Grouping_SetNull()
		{
			gxTv_SdtQueryViewerAxes_Axis_Grouping = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerAxes_Axis_Grouping_IsNull()
		{
			if (gxTv_SdtQueryViewerAxes_Axis_Grouping == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtQueryViewerAxes_Axis_Name = "";
			gxTv_SdtQueryViewerAxes_Axis_Title = "";
			gxTv_SdtQueryViewerAxes_Axis_Datafield = "";
			gxTv_SdtQueryViewerAxes_Axis_Type = "";
			gxTv_SdtQueryViewerAxes_Axis_Aggregation = "";





			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtQueryViewerAxes_Axis_Name;
		protected String gxTv_SdtQueryViewerAxes_Axis_Title;
		protected String gxTv_SdtQueryViewerAxes_Axis_Datafield;
		protected String gxTv_SdtQueryViewerAxes_Axis_Type;
		protected String gxTv_SdtQueryViewerAxes_Axis_Aggregation;
		protected SdtQueryViewerAxes_Axis_Filter gxTv_SdtQueryViewerAxes_Axis_Filter = null; protected SdtQueryViewerAxes_Axis_ExpandCollapse gxTv_SdtQueryViewerAxes_Axis_Expandcollapse = null; protected SdtQueryViewerAxes_Axis_AxisOrder gxTv_SdtQueryViewerAxes_Axis_Axisorder = null; protected SdtQueryViewerAxes_Axis_Format gxTv_SdtQueryViewerAxes_Axis_Format = null; protected SdtQueryViewerAxes_Axis_Grouping gxTv_SdtQueryViewerAxes_Axis_Grouping = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"Axis", Namespace="SeriesColaborativas")]
	public class SdtQueryViewerAxes_Axis_RESTInterface : GxGenericCollectionItem<SdtQueryViewerAxes_Axis>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtQueryViewerAxes_Axis_RESTInterface( ) : base()
		{
		}

		public SdtQueryViewerAxes_Axis_RESTInterface( SdtQueryViewerAxes_Axis psdt ) : base(psdt)
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

		[DataMember(Name="Title", Order=1)]
		public String gxTpr_Title
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Title);
			}
			set { 
				sdt.gxTpr_Title = value;
			}
		}

		[DataMember(Name="DataField", Order=2)]
		public String gxTpr_Datafield
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Datafield);
			}
			set { 
				sdt.gxTpr_Datafield = value;
			}
		}

		[DataMember(Name="Type", Order=3)]
		public String gxTpr_Type
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Type);
			}
			set { 
				sdt.gxTpr_Type = value;
			}
		}

		[DataMember(Name="Aggregation", Order=4)]
		public String gxTpr_Aggregation
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Aggregation);
			}
			set { 
				sdt.gxTpr_Aggregation = value;
			}
		}

		[DataMember(Name="Filter", Order=5)]
		public SdtQueryViewerAxes_Axis_Filter_RESTInterface gxTpr_Filter
		{
			get {
				return new SdtQueryViewerAxes_Axis_Filter_RESTInterface(sdt.gxTpr_Filter) ;
			}

			set {
				sdt.gxTpr_Filter = value.sdt;
			}

		}

		[DataMember(Name="ExpandCollapse", Order=6)]
		public SdtQueryViewerAxes_Axis_ExpandCollapse_RESTInterface gxTpr_Expandcollapse
		{
			get {
				return new SdtQueryViewerAxes_Axis_ExpandCollapse_RESTInterface(sdt.gxTpr_Expandcollapse) ;
			}

			set {
				sdt.gxTpr_Expandcollapse = value.sdt;
			}

		}

		[DataMember(Name="AxisOrder", Order=7)]
		public SdtQueryViewerAxes_Axis_AxisOrder_RESTInterface gxTpr_Axisorder
		{
			get {
				return new SdtQueryViewerAxes_Axis_AxisOrder_RESTInterface(sdt.gxTpr_Axisorder) ;
			}

			set {
				sdt.gxTpr_Axisorder = value.sdt;
			}

		}

		[DataMember(Name="Format", Order=8)]
		public SdtQueryViewerAxes_Axis_Format_RESTInterface gxTpr_Format
		{
			get {
				return new SdtQueryViewerAxes_Axis_Format_RESTInterface(sdt.gxTpr_Format) ;
			}

			set {
				sdt.gxTpr_Format = value.sdt;
			}

		}

		[DataMember(Name="Grouping", Order=9)]
		public SdtQueryViewerAxes_Axis_Grouping_RESTInterface gxTpr_Grouping
		{
			get {
				return new SdtQueryViewerAxes_Axis_Grouping_RESTInterface(sdt.gxTpr_Grouping) ;
			}

			set {
				sdt.gxTpr_Grouping = value.sdt;
			}

		}


		#endregion

		public SdtQueryViewerAxes_Axis sdt
		{
			get { 
				return (SdtQueryViewerAxes_Axis)Sdt;
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
				sdt = new SdtQueryViewerAxes_Axis() ;
			}
		}
	}
	#endregion
}