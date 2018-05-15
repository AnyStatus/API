﻿using System.ComponentModel;
using System.Xml.Serialization;

namespace AnyStatus.API
{
    public interface IReportProgress
    {
        [XmlIgnore]
        [Browsable(false)]
        bool ProgressEnabled { get; set; }

        [XmlIgnore]
        [Browsable(false)]
        int Progress { get; set; }
    }
}