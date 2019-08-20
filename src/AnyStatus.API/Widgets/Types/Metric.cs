using System.ComponentModel;
using System.Xml.Serialization;

namespace AnyStatus.API
{
    public abstract class Metric : Widget, IMetric
    {
        private string _symbol;
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
        public string Symbol
        {
            get => _symbol;
            set
            {
                _symbol = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return _value != null ? _value.ToString() : string.Empty;
        }
    }
}