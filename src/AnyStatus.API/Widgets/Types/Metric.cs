using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AnyStatus.API
{
    public abstract class Metric : Widget, IMetric
    {
        private volatile object _value;

        [XmlIgnore]
        [Browsable(false)]
        public object Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged();
            }
        }

        [XmlIgnore]
        [Browsable(false)]
        [Obsolete("This property has been canceled. Please use the ToString() function instead.")]
        public string Symbol { get; set; }

        public override string ToString()
        {
            return _value != null ? _value.ToString() : string.Empty;
        }
    }
}