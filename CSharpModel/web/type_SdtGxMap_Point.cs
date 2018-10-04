/*
				   File: type_SdtGxMap_Point
			Description: Points
				 Author: Nemo for C# version 15.0.9.121631
		   Generated on: 20/09/2018 19:47:43
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
	[XmlRoot(ElementName="GxMap.Point")]
	[XmlType(TypeName="GxMap.Point" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtGxMap_Point : GxUserType
	{
		public SdtGxMap_Point( )
		{
			/* Constructor for serialization */
			gxTv_SdtGxMap_Point_Pointlat = "";

			gxTv_SdtGxMap_Point_Pointlong = "";

			gxTv_SdtGxMap_Point_Pointicon = "";

			gxTv_SdtGxMap_Point_Pointstreet = "";

			gxTv_SdtGxMap_Point_Pointstreetnumber = "";

			gxTv_SdtGxMap_Point_Pointcrossstreet = "";

			gxTv_SdtGxMap_Point_Pointinfowintit = "";

			gxTv_SdtGxMap_Point_Pointinfowindesc = "";

			gxTv_SdtGxMap_Point_Pointinfowinlink = "";

			gxTv_SdtGxMap_Point_Pointinfowinlinkdsc = "";

			gxTv_SdtGxMap_Point_Pointinfowinimg = "";

		}

		public SdtGxMap_Point(IGxContext context)
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
			AddObjectProperty("PointLat", gxTpr_Pointlat, false);
			AddObjectProperty("PointLong", gxTpr_Pointlong, false);
			AddObjectProperty("PointIcon", gxTpr_Pointicon, false);
			AddObjectProperty("PointStreet", gxTpr_Pointstreet, false);
			AddObjectProperty("PointStreetNumber", gxTpr_Pointstreetnumber, false);
			AddObjectProperty("PointCrossStreet", gxTpr_Pointcrossstreet, false);
			AddObjectProperty("PointInfowinTit", gxTpr_Pointinfowintit, false);
			AddObjectProperty("PointInfowinDesc", gxTpr_Pointinfowindesc, false);
			AddObjectProperty("PointInfowinLink", gxTpr_Pointinfowinlink, false);
			AddObjectProperty("PointInfowinLinkDsc", gxTpr_Pointinfowinlinkdsc, false);
			AddObjectProperty("PointInfowinImg", gxTpr_Pointinfowinimg, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="PointLat")]
		[XmlElement(ElementName="PointLat")]
		public String gxTpr_Pointlat
		{
			get { 
				return gxTv_SdtGxMap_Point_Pointlat; 
			}
			set { 
				gxTv_SdtGxMap_Point_Pointlat = value;
				SetDirty("Pointlat");
			}
		}


		[SoapElement(ElementName="PointLong")]
		[XmlElement(ElementName="PointLong")]
		public String gxTpr_Pointlong
		{
			get { 
				return gxTv_SdtGxMap_Point_Pointlong; 
			}
			set { 
				gxTv_SdtGxMap_Point_Pointlong = value;
				SetDirty("Pointlong");
			}
		}


		[SoapElement(ElementName="PointIcon")]
		[XmlElement(ElementName="PointIcon")]
		public String gxTpr_Pointicon
		{
			get { 
				return gxTv_SdtGxMap_Point_Pointicon; 
			}
			set { 
				gxTv_SdtGxMap_Point_Pointicon = value;
				SetDirty("Pointicon");
			}
		}


		[SoapElement(ElementName="PointStreet")]
		[XmlElement(ElementName="PointStreet")]
		public String gxTpr_Pointstreet
		{
			get { 
				return gxTv_SdtGxMap_Point_Pointstreet; 
			}
			set { 
				gxTv_SdtGxMap_Point_Pointstreet = value;
				SetDirty("Pointstreet");
			}
		}


		[SoapElement(ElementName="PointStreetNumber")]
		[XmlElement(ElementName="PointStreetNumber")]
		public String gxTpr_Pointstreetnumber
		{
			get { 
				return gxTv_SdtGxMap_Point_Pointstreetnumber; 
			}
			set { 
				gxTv_SdtGxMap_Point_Pointstreetnumber = value;
				SetDirty("Pointstreetnumber");
			}
		}


		[SoapElement(ElementName="PointCrossStreet")]
		[XmlElement(ElementName="PointCrossStreet")]
		public String gxTpr_Pointcrossstreet
		{
			get { 
				return gxTv_SdtGxMap_Point_Pointcrossstreet; 
			}
			set { 
				gxTv_SdtGxMap_Point_Pointcrossstreet = value;
				SetDirty("Pointcrossstreet");
			}
		}


		[SoapElement(ElementName="PointInfowinTit")]
		[XmlElement(ElementName="PointInfowinTit")]
		public String gxTpr_Pointinfowintit
		{
			get { 
				return gxTv_SdtGxMap_Point_Pointinfowintit; 
			}
			set { 
				gxTv_SdtGxMap_Point_Pointinfowintit = value;
				SetDirty("Pointinfowintit");
			}
		}


		[SoapElement(ElementName="PointInfowinDesc")]
		[XmlElement(ElementName="PointInfowinDesc")]
		public String gxTpr_Pointinfowindesc
		{
			get { 
				return gxTv_SdtGxMap_Point_Pointinfowindesc; 
			}
			set { 
				gxTv_SdtGxMap_Point_Pointinfowindesc = value;
				SetDirty("Pointinfowindesc");
			}
		}


		[SoapElement(ElementName="PointInfowinLink")]
		[XmlElement(ElementName="PointInfowinLink")]
		public String gxTpr_Pointinfowinlink
		{
			get { 
				return gxTv_SdtGxMap_Point_Pointinfowinlink; 
			}
			set { 
				gxTv_SdtGxMap_Point_Pointinfowinlink = value;
				SetDirty("Pointinfowinlink");
			}
		}


		[SoapElement(ElementName="PointInfowinLinkDsc")]
		[XmlElement(ElementName="PointInfowinLinkDsc")]
		public String gxTpr_Pointinfowinlinkdsc
		{
			get { 
				return gxTv_SdtGxMap_Point_Pointinfowinlinkdsc; 
			}
			set { 
				gxTv_SdtGxMap_Point_Pointinfowinlinkdsc = value;
				SetDirty("Pointinfowinlinkdsc");
			}
		}


		[SoapElement(ElementName="PointInfowinImg")]
		[XmlElement(ElementName="PointInfowinImg")]
		public String gxTpr_Pointinfowinimg
		{
			get { 
				return gxTv_SdtGxMap_Point_Pointinfowinimg; 
			}
			set { 
				gxTv_SdtGxMap_Point_Pointinfowinimg = value;
				SetDirty("Pointinfowinimg");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtGxMap_Point_Pointlat = "";
			gxTv_SdtGxMap_Point_Pointlong = "";
			gxTv_SdtGxMap_Point_Pointicon = "";
			gxTv_SdtGxMap_Point_Pointstreet = "";
			gxTv_SdtGxMap_Point_Pointstreetnumber = "";
			gxTv_SdtGxMap_Point_Pointcrossstreet = "";
			gxTv_SdtGxMap_Point_Pointinfowintit = "";
			gxTv_SdtGxMap_Point_Pointinfowindesc = "";
			gxTv_SdtGxMap_Point_Pointinfowinlink = "";
			gxTv_SdtGxMap_Point_Pointinfowinlinkdsc = "";
			gxTv_SdtGxMap_Point_Pointinfowinimg = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtGxMap_Point_Pointlat;
		protected String gxTv_SdtGxMap_Point_Pointlong;
		protected String gxTv_SdtGxMap_Point_Pointicon;
		protected String gxTv_SdtGxMap_Point_Pointstreet;
		protected String gxTv_SdtGxMap_Point_Pointstreetnumber;
		protected String gxTv_SdtGxMap_Point_Pointcrossstreet;
		protected String gxTv_SdtGxMap_Point_Pointinfowintit;
		protected String gxTv_SdtGxMap_Point_Pointinfowindesc;
		protected String gxTv_SdtGxMap_Point_Pointinfowinlink;
		protected String gxTv_SdtGxMap_Point_Pointinfowinlinkdsc;
		protected String gxTv_SdtGxMap_Point_Pointinfowinimg;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"GxMap.Point", Namespace="SeriesColaborativas")]
	public class SdtGxMap_Point_RESTInterface : GxGenericCollectionItem<SdtGxMap_Point>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtGxMap_Point_RESTInterface( ) : base()
		{
		}

		public SdtGxMap_Point_RESTInterface( SdtGxMap_Point psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="PointLat", Order=0)]
		public String gxTpr_Pointlat
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Pointlat);
			}
			set { 
				sdt.gxTpr_Pointlat = value;
			}
		}

		[DataMember(Name="PointLong", Order=1)]
		public String gxTpr_Pointlong
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Pointlong);
			}
			set { 
				sdt.gxTpr_Pointlong = value;
			}
		}

		[DataMember(Name="PointIcon", Order=2)]
		public String gxTpr_Pointicon
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Pointicon);
			}
			set { 
				sdt.gxTpr_Pointicon = value;
			}
		}

		[DataMember(Name="PointStreet", Order=3)]
		public String gxTpr_Pointstreet
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Pointstreet);
			}
			set { 
				sdt.gxTpr_Pointstreet = value;
			}
		}

		[DataMember(Name="PointStreetNumber", Order=4)]
		public String gxTpr_Pointstreetnumber
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Pointstreetnumber);
			}
			set { 
				sdt.gxTpr_Pointstreetnumber = value;
			}
		}

		[DataMember(Name="PointCrossStreet", Order=5)]
		public String gxTpr_Pointcrossstreet
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Pointcrossstreet);
			}
			set { 
				sdt.gxTpr_Pointcrossstreet = value;
			}
		}

		[DataMember(Name="PointInfowinTit", Order=6)]
		public String gxTpr_Pointinfowintit
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Pointinfowintit);
			}
			set { 
				sdt.gxTpr_Pointinfowintit = value;
			}
		}

		[DataMember(Name="PointInfowinDesc", Order=7)]
		public String gxTpr_Pointinfowindesc
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Pointinfowindesc);
			}
			set { 
				sdt.gxTpr_Pointinfowindesc = value;
			}
		}

		[DataMember(Name="PointInfowinLink", Order=8)]
		public String gxTpr_Pointinfowinlink
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Pointinfowinlink);
			}
			set { 
				sdt.gxTpr_Pointinfowinlink = value;
			}
		}

		[DataMember(Name="PointInfowinLinkDsc", Order=9)]
		public String gxTpr_Pointinfowinlinkdsc
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Pointinfowinlinkdsc);
			}
			set { 
				sdt.gxTpr_Pointinfowinlinkdsc = value;
			}
		}

		[DataMember(Name="PointInfowinImg", Order=10)]
		public String gxTpr_Pointinfowinimg
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Pointinfowinimg);
			}
			set { 
				sdt.gxTpr_Pointinfowinimg = value;
			}
		}


		#endregion

		public SdtGxMap_Point sdt
		{
			get { 
				return (SdtGxMap_Point)Sdt;
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
				sdt = new SdtGxMap_Point() ;
			}
		}
	}
	#endregion
}