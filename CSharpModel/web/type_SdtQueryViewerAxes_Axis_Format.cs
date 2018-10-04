/*
				   File: type_SdtQueryViewerAxes_Axis_Format
			Description: Format
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
	[XmlRoot(ElementName="QueryViewerAxes.Axis.Format")]
	[XmlType(TypeName="QueryViewerAxes.Axis.Format" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtQueryViewerAxes_Axis_Format : GxUserType
	{
		public SdtQueryViewerAxes_Axis_Format( )
		{
			/* Constructor for serialization */
			gxTv_SdtQueryViewerAxes_Axis_Format_Picture = "";

			gxTv_SdtQueryViewerAxes_Axis_Format_Subtotals = "";

			gxTv_SdtQueryViewerAxes_Axis_Format_Style = "";

		}

		public SdtQueryViewerAxes_Axis_Format(IGxContext context)
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
			AddObjectProperty("Picture", gxTpr_Picture, false);
			AddObjectProperty("Subtotals", gxTpr_Subtotals, false);
			AddObjectProperty("CanDragToPages", gxTpr_Candragtopages, false);
			AddObjectProperty("Style", gxTpr_Style, false);
			AddObjectProperty("TargetValue", StringUtil.LTrim( StringUtil.Str( (decimal)gxTpr_Targetvalue, 18, 2)), false);
			AddObjectProperty("MaximumValue", StringUtil.LTrim( StringUtil.Str( (decimal)gxTpr_Maximumvalue, 18, 2)), false);
			AddObjectProperty("ValuesStyles", gxTv_SdtQueryViewerAxes_Axis_Format_Valuesstyles, false);  
			AddObjectProperty("ConditionalStyles", gxTv_SdtQueryViewerAxes_Axis_Format_Conditionalstyles, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Picture")]
		[XmlElement(ElementName="Picture")]
		public String gxTpr_Picture
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Format_Picture; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Format_Picture = value;
				SetDirty("Picture");
			}
		}


		[SoapElement(ElementName="Subtotals")]
		[XmlElement(ElementName="Subtotals")]
		public String gxTpr_Subtotals
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Format_Subtotals; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Format_Subtotals = value;
				SetDirty("Subtotals");
			}
		}


		[SoapElement(ElementName="CanDragToPages")]
		[XmlElement(ElementName="CanDragToPages")]
		public bool gxTpr_Candragtopages
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Format_Candragtopages; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Format_Candragtopages = value;
				SetDirty("Candragtopages");
			}
		}


		[SoapElement(ElementName="Style")]
		[XmlElement(ElementName="Style")]
		public String gxTpr_Style
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Format_Style; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Format_Style = value;
				SetDirty("Style");
			}
		}

		[SoapElement(ElementName="TargetValue")]
		[XmlElement(ElementName="TargetValue")]
		public double gxTpr_Targetvalue_double
		{
			get {
				return Convert.ToDouble(gxTv_SdtQueryViewerAxes_Axis_Format_Targetvalue) ;
			}
			set {
				gxTv_SdtQueryViewerAxes_Axis_Format_Targetvalue = (decimal)(Convert.ToDecimal( value));
			}
		}
		[SoapIgnore]
		[XmlIgnore]
		public decimal gxTpr_Targetvalue
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Format_Targetvalue; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Format_Targetvalue = value;
				SetDirty("Targetvalue");
			}
		}

		[SoapElement(ElementName="MaximumValue")]
		[XmlElement(ElementName="MaximumValue")]
		public double gxTpr_Maximumvalue_double
		{
			get {
				return Convert.ToDouble(gxTv_SdtQueryViewerAxes_Axis_Format_Maximumvalue) ;
			}
			set {
				gxTv_SdtQueryViewerAxes_Axis_Format_Maximumvalue = (decimal)(Convert.ToDecimal( value));
			}
		}
		[SoapIgnore]
		[XmlIgnore]
		public decimal gxTpr_Maximumvalue
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Format_Maximumvalue; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Format_Maximumvalue = value;
				SetDirty("Maximumvalue");
			}
		}


		[SoapElement(ElementName="ValuesStyles" )]
		[XmlArray(ElementName="ValuesStyles"  )]
		[XmlArrayItemAttribute(ElementName="ValueStyle" , IsNullable=false )]
		public GXBaseCollection<SdtQueryViewerAxes_Axis_Format_ValueStyle> gxTpr_Valuesstyles
		{
			get {
				if ( gxTv_SdtQueryViewerAxes_Axis_Format_Valuesstyles == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_Format_Valuesstyles = new GXBaseCollection<SdtQueryViewerAxes_Axis_Format_ValueStyle>( context, "QueryViewerAxes.Axis.Format.ValueStyle", "");
				}
				return gxTv_SdtQueryViewerAxes_Axis_Format_Valuesstyles;
			}
			set {
				if ( gxTv_SdtQueryViewerAxes_Axis_Format_Valuesstyles == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_Format_Valuesstyles = new GXBaseCollection<SdtQueryViewerAxes_Axis_Format_ValueStyle>( context, "QueryViewerAxes.Axis.Format.ValueStyle", "");
				}
				gxTv_SdtQueryViewerAxes_Axis_Format_Valuesstyles = value;
				SetDirty("Valuesstyles");
			}
		}public void gxTv_SdtQueryViewerAxes_Axis_Format_Valuesstyles_SetNull()
		{
			gxTv_SdtQueryViewerAxes_Axis_Format_Valuesstyles = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerAxes_Axis_Format_Valuesstyles_IsNull()
		{
			if (gxTv_SdtQueryViewerAxes_Axis_Format_Valuesstyles == null)
			{
				return true ;
			}
			return false ;
		}



		[SoapElement(ElementName="ConditionalStyles" )]
		[XmlArray(ElementName="ConditionalStyles"  )]
		[XmlArrayItemAttribute(ElementName="ConditionalStyle" , IsNullable=false )]
		public GXBaseCollection<SdtQueryViewerAxes_Axis_Format_ConditionalStyle> gxTpr_Conditionalstyles
		{
			get {
				if ( gxTv_SdtQueryViewerAxes_Axis_Format_Conditionalstyles == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_Format_Conditionalstyles = new GXBaseCollection<SdtQueryViewerAxes_Axis_Format_ConditionalStyle>( context, "QueryViewerAxes.Axis.Format.ConditionalStyle", "");
				}
				return gxTv_SdtQueryViewerAxes_Axis_Format_Conditionalstyles;
			}
			set {
				if ( gxTv_SdtQueryViewerAxes_Axis_Format_Conditionalstyles == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_Format_Conditionalstyles = new GXBaseCollection<SdtQueryViewerAxes_Axis_Format_ConditionalStyle>( context, "QueryViewerAxes.Axis.Format.ConditionalStyle", "");
				}
				gxTv_SdtQueryViewerAxes_Axis_Format_Conditionalstyles = value;
				SetDirty("Conditionalstyles");
			}
		}public void gxTv_SdtQueryViewerAxes_Axis_Format_Conditionalstyles_SetNull()
		{
			gxTv_SdtQueryViewerAxes_Axis_Format_Conditionalstyles = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerAxes_Axis_Format_Conditionalstyles_IsNull()
		{
			if (gxTv_SdtQueryViewerAxes_Axis_Format_Conditionalstyles == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtQueryViewerAxes_Axis_Format_Picture = "";
			gxTv_SdtQueryViewerAxes_Axis_Format_Subtotals = "";

			gxTv_SdtQueryViewerAxes_Axis_Format_Style = "";




			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtQueryViewerAxes_Axis_Format_Picture;
		protected String gxTv_SdtQueryViewerAxes_Axis_Format_Subtotals;
		protected bool gxTv_SdtQueryViewerAxes_Axis_Format_Candragtopages;
		protected String gxTv_SdtQueryViewerAxes_Axis_Format_Style;
		protected decimal gxTv_SdtQueryViewerAxes_Axis_Format_Targetvalue;
		protected decimal gxTv_SdtQueryViewerAxes_Axis_Format_Maximumvalue;
		protected GXBaseCollection<SdtQueryViewerAxes_Axis_Format_ValueStyle> gxTv_SdtQueryViewerAxes_Axis_Format_Valuesstyles = null; protected GXBaseCollection<SdtQueryViewerAxes_Axis_Format_ConditionalStyle> gxTv_SdtQueryViewerAxes_Axis_Format_Conditionalstyles = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"QueryViewerAxes.Axis.Format", Namespace="SeriesColaborativas")]
	public class SdtQueryViewerAxes_Axis_Format_RESTInterface : GxGenericCollectionItem<SdtQueryViewerAxes_Axis_Format>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtQueryViewerAxes_Axis_Format_RESTInterface( ) : base()
		{
		}

		public SdtQueryViewerAxes_Axis_Format_RESTInterface( SdtQueryViewerAxes_Axis_Format psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Picture", Order=0)]
		public String gxTpr_Picture
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Picture);
			}
			set { 
				sdt.gxTpr_Picture = value;
			}
		}

		[DataMember(Name="Subtotals", Order=1)]
		public String gxTpr_Subtotals
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Subtotals);
			}
			set { 
				sdt.gxTpr_Subtotals = value;
			}
		}

		[DataMember(Name="CanDragToPages", Order=2)]
		public bool gxTpr_Candragtopages
		{
			get { 
				return sdt.gxTpr_Candragtopages;
			}
			set { 
				sdt.gxTpr_Candragtopages = value;
			}
		}

		[DataMember(Name="Style", Order=3)]
		public String gxTpr_Style
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Style);
			}
			set { 
				sdt.gxTpr_Style = value;
			}
		}

		[DataMember(Name="TargetValue", Order=4)]
		public String gxTpr_Targetvalue
		{
			get { 
				return StringUtil.LTrim( StringUtil.Str(  sdt.gxTpr_Targetvalue, 18, 2));
			}
			set { 
				sdt.gxTpr_Targetvalue =  NumberUtil.Val( value, ".");
			}
		}

		[DataMember(Name="MaximumValue", Order=5)]
		public String gxTpr_Maximumvalue
		{
			get { 
				return StringUtil.LTrim( StringUtil.Str(  sdt.gxTpr_Maximumvalue, 18, 2));
			}
			set { 
				sdt.gxTpr_Maximumvalue =  NumberUtil.Val( value, ".");
			}
		}

		[DataMember(Name="ValuesStyles", Order=6)]
		public GxGenericCollection<SdtQueryViewerAxes_Axis_Format_ValueStyle_RESTInterface> gxTpr_Valuesstyles
		{
			get {
				return new GxGenericCollection<SdtQueryViewerAxes_Axis_Format_ValueStyle_RESTInterface>(sdt.gxTpr_Valuesstyles) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Valuesstyles);
			}

		}

		[DataMember(Name="ConditionalStyles", Order=7)]
		public GxGenericCollection<SdtQueryViewerAxes_Axis_Format_ConditionalStyle_RESTInterface> gxTpr_Conditionalstyles
		{
			get {
				return new GxGenericCollection<SdtQueryViewerAxes_Axis_Format_ConditionalStyle_RESTInterface>(sdt.gxTpr_Conditionalstyles) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Conditionalstyles);
			}

		}


		#endregion

		public SdtQueryViewerAxes_Axis_Format sdt
		{
			get { 
				return (SdtQueryViewerAxes_Axis_Format)Sdt;
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
				sdt = new SdtQueryViewerAxes_Axis_Format() ;
			}
		}
	}
	#endregion
}