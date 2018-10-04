/*
				   File: type_SdtDVelop_Menu_Item
			Description: DVelop_Menu
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
	[XmlRoot(ElementName="Item")]
	[XmlType(TypeName="Item" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtDVelop_Menu_Item : GxUserType
	{
		public SdtDVelop_Menu_Item( )
		{
			/* Constructor for serialization */
			gxTv_SdtDVelop_Menu_Item_Id = "";

			gxTv_SdtDVelop_Menu_Item_Tooltip = "";

			gxTv_SdtDVelop_Menu_Item_Link = "";

			gxTv_SdtDVelop_Menu_Item_Linktarget = "";

			gxTv_SdtDVelop_Menu_Item_Iconclass = "";

			gxTv_SdtDVelop_Menu_Item_Caption = "";

			gxTv_SdtDVelop_Menu_Item_Authorizationkey = "";

		}

		public SdtDVelop_Menu_Item(IGxContext context)
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
			AddObjectProperty("id", gxTpr_Id, false);
			AddObjectProperty("tooltip", gxTpr_Tooltip, false);
			AddObjectProperty("link", gxTpr_Link, false);
			AddObjectProperty("linkTarget", gxTpr_Linktarget, false);
			AddObjectProperty("iconClass", gxTpr_Iconclass, false);
			AddObjectProperty("caption", gxTpr_Caption, false);
			AddObjectProperty("authorizationKey", gxTpr_Authorizationkey, false);
			AddObjectProperty("subItems", gxTv_SdtDVelop_Menu_Item_Subitems, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="id")]
		[XmlElement(ElementName="id")]
		public String gxTpr_Id
		{
			get { 
				return gxTv_SdtDVelop_Menu_Item_Id; 
			}
			set { 
				gxTv_SdtDVelop_Menu_Item_Id = value;
				SetDirty("Id");
			}
		}


		[SoapElement(ElementName="tooltip")]
		[XmlElement(ElementName="tooltip")]
		public String gxTpr_Tooltip
		{
			get { 
				return gxTv_SdtDVelop_Menu_Item_Tooltip; 
			}
			set { 
				gxTv_SdtDVelop_Menu_Item_Tooltip = value;
				SetDirty("Tooltip");
			}
		}


		[SoapElement(ElementName="link")]
		[XmlElement(ElementName="link")]
		public String gxTpr_Link
		{
			get { 
				return gxTv_SdtDVelop_Menu_Item_Link; 
			}
			set { 
				gxTv_SdtDVelop_Menu_Item_Link = value;
				SetDirty("Link");
			}
		}


		[SoapElement(ElementName="linkTarget")]
		[XmlElement(ElementName="linkTarget")]
		public String gxTpr_Linktarget
		{
			get { 
				return gxTv_SdtDVelop_Menu_Item_Linktarget; 
			}
			set { 
				gxTv_SdtDVelop_Menu_Item_Linktarget = value;
				SetDirty("Linktarget");
			}
		}


		[SoapElement(ElementName="iconClass")]
		[XmlElement(ElementName="iconClass")]
		public String gxTpr_Iconclass
		{
			get { 
				return gxTv_SdtDVelop_Menu_Item_Iconclass; 
			}
			set { 
				gxTv_SdtDVelop_Menu_Item_Iconclass = value;
				SetDirty("Iconclass");
			}
		}


		[SoapElement(ElementName="caption")]
		[XmlElement(ElementName="caption")]
		public String gxTpr_Caption
		{
			get { 
				return gxTv_SdtDVelop_Menu_Item_Caption; 
			}
			set { 
				gxTv_SdtDVelop_Menu_Item_Caption = value;
				SetDirty("Caption");
			}
		}


		[SoapElement(ElementName="authorizationKey")]
		[XmlElement(ElementName="authorizationKey")]
		public String gxTpr_Authorizationkey
		{
			get { 
				return gxTv_SdtDVelop_Menu_Item_Authorizationkey; 
			}
			set { 
				gxTv_SdtDVelop_Menu_Item_Authorizationkey = value;
				SetDirty("Authorizationkey");
			}
		}


		[SoapElement(ElementName="subItems" )]
		[XmlArray(ElementName="subItems"  )]
		[XmlArrayItemAttribute(ElementName="Item" , IsNullable=false )]
		public GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> gxTpr_Subitems_GXBaseCollection
		{
			get {
				if ( gxTv_SdtDVelop_Menu_Item_Subitems == null )
				{
					gxTv_SdtDVelop_Menu_Item_Subitems = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item>( context, "DVelop_Menu", "");
				}
				return gxTv_SdtDVelop_Menu_Item_Subitems;
			}
			set {
				if ( gxTv_SdtDVelop_Menu_Item_Subitems == null )
				{
					gxTv_SdtDVelop_Menu_Item_Subitems = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item>( context, "DVelop_Menu", "");
				}
				gxTv_SdtDVelop_Menu_Item_Subitems = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> gxTpr_Subitems
		{
			get {
				if ( gxTv_SdtDVelop_Menu_Item_Subitems == null )
				{
					gxTv_SdtDVelop_Menu_Item_Subitems = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item>( context, "DVelop_Menu", "");
				}
				return gxTv_SdtDVelop_Menu_Item_Subitems ;
			}
			set {
				gxTv_SdtDVelop_Menu_Item_Subitems = value;
				SetDirty("Subitems");
			}
		}

		public void gxTv_SdtDVelop_Menu_Item_Subitems_SetNull()
		{
			gxTv_SdtDVelop_Menu_Item_Subitems = null;
			return  ;
		}

		public bool gxTv_SdtDVelop_Menu_Item_Subitems_IsNull()
		{
			if (gxTv_SdtDVelop_Menu_Item_Subitems == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtDVelop_Menu_Item_Id = "";
			gxTv_SdtDVelop_Menu_Item_Tooltip = "";
			gxTv_SdtDVelop_Menu_Item_Link = "";
			gxTv_SdtDVelop_Menu_Item_Linktarget = "";
			gxTv_SdtDVelop_Menu_Item_Iconclass = "";
			gxTv_SdtDVelop_Menu_Item_Caption = "";
			gxTv_SdtDVelop_Menu_Item_Authorizationkey = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtDVelop_Menu_Item_Id;
		protected String gxTv_SdtDVelop_Menu_Item_Tooltip;
		protected String gxTv_SdtDVelop_Menu_Item_Link;
		protected String gxTv_SdtDVelop_Menu_Item_Linktarget;
		protected String gxTv_SdtDVelop_Menu_Item_Iconclass;
		protected String gxTv_SdtDVelop_Menu_Item_Caption;
		protected String gxTv_SdtDVelop_Menu_Item_Authorizationkey;
		protected GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> gxTv_SdtDVelop_Menu_Item_Subitems = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"Item", Namespace="SeriesColaborativas")]
	public class SdtDVelop_Menu_Item_RESTInterface : GxGenericCollectionItem<SdtDVelop_Menu_Item>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtDVelop_Menu_Item_RESTInterface( ) : base()
		{
		}

		public SdtDVelop_Menu_Item_RESTInterface( SdtDVelop_Menu_Item psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="id", Order=0)]
		public String gxTpr_Id
		{
			get { 
				return sdt.gxTpr_Id;
			}
			set { 
				sdt.gxTpr_Id = value;
			}
		}

		[DataMember(Name="tooltip", Order=1)]
		public String gxTpr_Tooltip
		{
			get { 
				return sdt.gxTpr_Tooltip;
			}
			set { 
				sdt.gxTpr_Tooltip = value;
			}
		}

		[DataMember(Name="link", Order=2)]
		public String gxTpr_Link
		{
			get { 
				return sdt.gxTpr_Link;
			}
			set { 
				sdt.gxTpr_Link = value;
			}
		}

		[DataMember(Name="linkTarget", Order=3)]
		public String gxTpr_Linktarget
		{
			get { 
				return sdt.gxTpr_Linktarget;
			}
			set { 
				sdt.gxTpr_Linktarget = value;
			}
		}

		[DataMember(Name="iconClass", Order=4)]
		public String gxTpr_Iconclass
		{
			get { 
				return sdt.gxTpr_Iconclass;
			}
			set { 
				sdt.gxTpr_Iconclass = value;
			}
		}

		[DataMember(Name="caption", Order=5)]
		public String gxTpr_Caption
		{
			get { 
				return sdt.gxTpr_Caption;
			}
			set { 
				sdt.gxTpr_Caption = value;
			}
		}

		[DataMember(Name="authorizationKey", Order=6)]
		public String gxTpr_Authorizationkey
		{
			get { 
				return sdt.gxTpr_Authorizationkey;
			}
			set { 
				sdt.gxTpr_Authorizationkey = value;
			}
		}

		[DataMember(Name="subItems", Order=7)]
		public  GxGenericCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item_RESTInterface> gxTpr_Subitems
		{
			get { 
				return new GxGenericCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item_RESTInterface>(sdt.gxTpr_Subitems);
			}
			set { 
				value.LoadCollection(sdt.gxTpr_Subitems);
			}
		}


		#endregion

		public SdtDVelop_Menu_Item sdt
		{
			get { 
				return (SdtDVelop_Menu_Item)Sdt;
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
				sdt = new SdtDVelop_Menu_Item() ;
			}
		}
	}
	#endregion
}