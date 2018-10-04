/*
				   File: type_SdtGxMap
			Description: GxMap
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
	[XmlRoot(ElementName="GxMap")]
	[XmlType(TypeName="GxMap" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtGxMap : GxUserType
	{
		public SdtGxMap( )
		{
			/* Constructor for serialization */
		}

		public SdtGxMap(IGxContext context)
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
			AddObjectProperty("Points", gxTv_SdtGxMap_Points, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Points" )]
		[XmlArray(ElementName="Points"  )]
		[XmlArrayItemAttribute(ElementName="Point" , IsNullable=false )]
		public GXBaseCollection<SdtGxMap_Point> gxTpr_Points
		{
			get {
				if ( gxTv_SdtGxMap_Points == null )
				{
					gxTv_SdtGxMap_Points = new GXBaseCollection<SdtGxMap_Point>( context, "GxMap.Point", "");
				}
				return gxTv_SdtGxMap_Points;
			}
			set {
				if ( gxTv_SdtGxMap_Points == null )
				{
					gxTv_SdtGxMap_Points = new GXBaseCollection<SdtGxMap_Point>( context, "GxMap.Point", "");
				}
				gxTv_SdtGxMap_Points = value;
				SetDirty("Points");
			}
		}public void gxTv_SdtGxMap_Points_SetNull()
		{
			gxTv_SdtGxMap_Points = null;
			return  ;
		}

		public bool gxTv_SdtGxMap_Points_IsNull()
		{
			if (gxTv_SdtGxMap_Points == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			return  ;
		}



		#endregion

		#region Declaration

		protected GXBaseCollection<SdtGxMap_Point> gxTv_SdtGxMap_Points = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"GxMap", Namespace="SeriesColaborativas")]
	public class SdtGxMap_RESTInterface : GxGenericCollectionItem<SdtGxMap>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtGxMap_RESTInterface( ) : base()
		{
		}

		public SdtGxMap_RESTInterface( SdtGxMap psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Points", Order=0)]
		public GxGenericCollection<SdtGxMap_Point_RESTInterface> gxTpr_Points
		{
			get {
				return new GxGenericCollection<SdtGxMap_Point_RESTInterface>(sdt.gxTpr_Points) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Points);
			}

		}


		#endregion

		public SdtGxMap sdt
		{
			get { 
				return (SdtGxMap)Sdt;
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
				sdt = new SdtGxMap() ;
			}
		}
	}
	#endregion
}