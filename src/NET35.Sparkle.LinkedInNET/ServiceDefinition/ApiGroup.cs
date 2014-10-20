﻿
namespace Sparkle.LinkedInNET.ServiceDefinition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    [Serializable, XmlElement]
    public class ApiGroup
    {
        [XmlElement(ElementName = "ApiMethod")]
        public IList<ApiMethod> Methods { get; set; }
    }
}