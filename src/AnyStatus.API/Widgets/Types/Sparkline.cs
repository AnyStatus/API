using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Media;
using System.Xml.Serialization;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace AnyStatus.API
{
    [ExcludeFromCodeCoverage]
    public abstract class Sparkline : Metric
    {
        private double _value;
        private const string Category = "Sparkline";

        [PropertyOrder(0)]
        [Category(Category)]
        [DisplayName("Enabled")]
        public bool IsSparklineEnabled { get; set; } = true;

        [PropertyOrder(1)]
        [Category(Category)]
        public int Size { get; set; } = 20;

        [PropertyOrder(2)]
        [Category(Category)]
        public Color Color { get; set; } = Colors.LimeGreen;

        [XmlIgnore]
        [Browsable(false)]
        public ObservableCollection<DataPoint> Points { get; } = new ObservableCollection<DataPoint>();

        [XmlIgnore]
        [Browsable(false)]
        public double MaxValue { get; set; } = 0;

        [XmlIgnore]
        [Browsable(false)]
        public new double Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return _value.ToString("0.#");
        }
    }
}
