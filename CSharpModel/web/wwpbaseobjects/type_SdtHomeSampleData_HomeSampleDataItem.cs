/*
				   File: type_SdtHomeSampleData_HomeSampleDataItem
			Description: HomeSampleData
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
	[XmlRoot(ElementName="HomeSampleDataItem")]
	[XmlType(TypeName="HomeSampleDataItem" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtHomeSampleData_HomeSampleDataItem : GxUserType
	{
		public SdtHomeSampleData_HomeSampleDataItem( )
		{
			/* Constructor for serialization */
			gxTv_SdtHomeSampleData_HomeSampleDataItem_Productname = "";

		}

		public SdtHomeSampleData_HomeSampleDataItem(IGxContext context)
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
			AddObjectProperty("ProductName", gxTpr_Productname, false);
			AddObjectProperty("ProductPrice", gxTpr_Productprice, false);
			AddObjectProperty("ProductWeight", gxTpr_Productweight, false);
			AddObjectProperty("ProductVolume", gxTpr_Productvolume, false);
			AddObjectProperty("ProductDiscount", gxTpr_Productdiscount, false);
			AddObjectProperty("ProductStatus", gxTpr_Productstatus, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="ProductName")]
		[XmlElement(ElementName="ProductName")]
		public String gxTpr_Productname
		{
			get { 
				return gxTv_SdtHomeSampleData_HomeSampleDataItem_Productname; 
			}
			set { 
				gxTv_SdtHomeSampleData_HomeSampleDataItem_Productname = value;
				SetDirty("Productname");
			}
		}

		[SoapElement(ElementName="ProductPrice")]
		[XmlElement(ElementName="ProductPrice")]
		public double gxTpr_Productprice_double
		{
			get {
				return Convert.ToDouble(gxTv_SdtHomeSampleData_HomeSampleDataItem_Productprice) ;
			}
			set {
				gxTv_SdtHomeSampleData_HomeSampleDataItem_Productprice = (decimal)(Convert.ToDecimal( value));
			}
		}
		[SoapIgnore]
		[XmlIgnore]
		public decimal gxTpr_Productprice
		{
			get { 
				return gxTv_SdtHomeSampleData_HomeSampleDataItem_Productprice; 
			}
			set { 
				gxTv_SdtHomeSampleData_HomeSampleDataItem_Productprice = value;
				SetDirty("Productprice");
			}
		}

		[SoapElement(ElementName="ProductWeight")]
		[XmlElement(ElementName="ProductWeight")]
		public double gxTpr_Productweight_double
		{
			get {
				return Convert.ToDouble(gxTv_SdtHomeSampleData_HomeSampleDataItem_Productweight) ;
			}
			set {
				gxTv_SdtHomeSampleData_HomeSampleDataItem_Productweight = (decimal)(Convert.ToDecimal( value));
			}
		}
		[SoapIgnore]
		[XmlIgnore]
		public decimal gxTpr_Productweight
		{
			get { 
				return gxTv_SdtHomeSampleData_HomeSampleDataItem_Productweight; 
			}
			set { 
				gxTv_SdtHomeSampleData_HomeSampleDataItem_Productweight = value;
				SetDirty("Productweight");
			}
		}

		[SoapElement(ElementName="ProductVolume")]
		[XmlElement(ElementName="ProductVolume")]
		public double gxTpr_Productvolume_double
		{
			get {
				return Convert.ToDouble(gxTv_SdtHomeSampleData_HomeSampleDataItem_Productvolume) ;
			}
			set {
				gxTv_SdtHomeSampleData_HomeSampleDataItem_Productvolume = (decimal)(Convert.ToDecimal( value));
			}
		}
		[SoapIgnore]
		[XmlIgnore]
		public decimal gxTpr_Productvolume
		{
			get { 
				return gxTv_SdtHomeSampleData_HomeSampleDataItem_Productvolume; 
			}
			set { 
				gxTv_SdtHomeSampleData_HomeSampleDataItem_Productvolume = value;
				SetDirty("Productvolume");
			}
		}

		[SoapElement(ElementName="ProductDiscount")]
		[XmlElement(ElementName="ProductDiscount")]
		public double gxTpr_Productdiscount_double
		{
			get {
				return Convert.ToDouble(gxTv_SdtHomeSampleData_HomeSampleDataItem_Productdiscount) ;
			}
			set {
				gxTv_SdtHomeSampleData_HomeSampleDataItem_Productdiscount = (decimal)(Convert.ToDecimal( value));
			}
		}
		[SoapIgnore]
		[XmlIgnore]
		public decimal gxTpr_Productdiscount
		{
			get { 
				return gxTv_SdtHomeSampleData_HomeSampleDataItem_Productdiscount; 
			}
			set { 
				gxTv_SdtHomeSampleData_HomeSampleDataItem_Productdiscount = value;
				SetDirty("Productdiscount");
			}
		}


		[SoapElement(ElementName="ProductStatus")]
		[XmlElement(ElementName="ProductStatus")]
		public short gxTpr_Productstatus
		{
			get { 
				return gxTv_SdtHomeSampleData_HomeSampleDataItem_Productstatus; 
			}
			set { 
				gxTv_SdtHomeSampleData_HomeSampleDataItem_Productstatus = value;
				SetDirty("Productstatus");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtHomeSampleData_HomeSampleDataItem_Productname = "";





			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtHomeSampleData_HomeSampleDataItem_Productname;
		protected decimal gxTv_SdtHomeSampleData_HomeSampleDataItem_Productprice;
		protected decimal gxTv_SdtHomeSampleData_HomeSampleDataItem_Productweight;
		protected decimal gxTv_SdtHomeSampleData_HomeSampleDataItem_Productvolume;
		protected decimal gxTv_SdtHomeSampleData_HomeSampleDataItem_Productdiscount;
		protected short gxTv_SdtHomeSampleData_HomeSampleDataItem_Productstatus;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"HomeSampleDataItem", Namespace="SeriesColaborativas")]
	public class SdtHomeSampleData_HomeSampleDataItem_RESTInterface : GxGenericCollectionItem<SdtHomeSampleData_HomeSampleDataItem>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtHomeSampleData_HomeSampleDataItem_RESTInterface( ) : base()
		{
		}

		public SdtHomeSampleData_HomeSampleDataItem_RESTInterface( SdtHomeSampleData_HomeSampleDataItem psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="ProductName", Order=0)]
		public String gxTpr_Productname
		{
			get { 
				return sdt.gxTpr_Productname;
			}
			set { 
				sdt.gxTpr_Productname = value;
			}
		}

		[DataMember(Name="ProductPrice", Order=1)]
		public String gxTpr_Productprice
		{
			get { 
				return StringUtil.LTrim( StringUtil.Str(  sdt.gxTpr_Productprice, 8, 1));
			}
			set { 
				sdt.gxTpr_Productprice =  NumberUtil.Val( value, ".");
			}
		}

		[DataMember(Name="ProductWeight", Order=2)]
		public  Nullable<decimal> gxTpr_Productweight
		{
			get { 
				return sdt.gxTpr_Productweight;
			}
			set { 
				sdt.gxTpr_Productweight = (decimal) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="ProductVolume", Order=3)]
		public  Nullable<decimal> gxTpr_Productvolume
		{
			get { 
				return sdt.gxTpr_Productvolume;
			}
			set { 
				sdt.gxTpr_Productvolume = (decimal) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="ProductDiscount", Order=4)]
		public  Nullable<decimal> gxTpr_Productdiscount
		{
			get { 
				return sdt.gxTpr_Productdiscount;
			}
			set { 
				sdt.gxTpr_Productdiscount = (decimal) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="ProductStatus", Order=5)]
		public  Nullable<short> gxTpr_Productstatus
		{
			get { 
				return sdt.gxTpr_Productstatus;
			}
			set { 
				sdt.gxTpr_Productstatus = (short) (value.HasValue ? value.Value : 0);
			}
		}


		#endregion

		public SdtHomeSampleData_HomeSampleDataItem sdt
		{
			get { 
				return (SdtHomeSampleData_HomeSampleDataItem)Sdt;
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
				sdt = new SdtHomeSampleData_HomeSampleDataItem() ;
			}
		}
	}
	#endregion
}