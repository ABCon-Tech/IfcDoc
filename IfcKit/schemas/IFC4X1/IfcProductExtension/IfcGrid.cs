// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPropertyResource;
using BuildingSmart.IFC.IfcQuantityResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcSharedBldgElements;
using BuildingSmart.IFC.IfcSharedBldgServiceElements;
using BuildingSmart.IFC.IfcSharedComponentElements;
using BuildingSmart.IFC.IfcSharedFacilitiesElements;
using BuildingSmart.IFC.IfcStructuralElementsDomain;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("25379845-b692-4288-a06e-0e6782212371")]
	public partial class IfcGrid : IfcPositioningElement
	{
		[DataMember(Order=0)] 
		[Required()]
		IList<IfcGridAxis> _UAxes = new List<IfcGridAxis>();
	
		[DataMember(Order=1)] 
		[Required()]
		IList<IfcGridAxis> _VAxes = new List<IfcGridAxis>();
	
		[DataMember(Order=2)] 
		IList<IfcGridAxis> _WAxes = new List<IfcGridAxis>();
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcGridTypeEnum? _PredefinedType;
	
	
		[Description("List of grid axes defining the first row of grid lines.")]
		public IList<IfcGridAxis> UAxes { get { return this._UAxes; } }
	
		[Description("List of grid axes defining the second row of grid lines.")]
		public IList<IfcGridAxis> VAxes { get { return this._VAxes; } }
	
		[Description("List of grid axes defining the third row of grid lines. It may be given in the ca" +
	    "se of a triangular grid.")]
		public IList<IfcGridAxis> WAxes { get { return this._WAxes; } }
	
		[Description("Predefined types to define the particular type of the grid. \r\n<blockquote class=\"" +
	    "change-ifc4\">IFC4 Change&nbsp; New attribute.</blockquote>")]
		public IfcGridTypeEnum? PredefinedType { get { return this._PredefinedType; } set { this._PredefinedType = value;} }
	
	
	}
	
}
