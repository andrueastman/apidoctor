﻿using ApiDoctor.Validation.OData.Transformation;
using ApiDoctor.Validation.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ApiDoctor.Validation.OData
{
    public abstract class XmlBackedObject
    {
        [XmlAnyElement, MergePolicy(MergePolicy.MustBeNull)]
        public List<XmlNode> ExtraElements { get; set; }

        [XmlAnyAttribute, MergePolicy(MergePolicy.MustBeNull)]
        public List<XmlNode> ExtraAttributes { get; set; }

        public bool HasUnknownMembers { get { return (null != ExtraElements && ExtraElements.Any()) || 
                                                     (null != ExtraAttributes && ExtraAttributes.Any()); } }

    }
}
