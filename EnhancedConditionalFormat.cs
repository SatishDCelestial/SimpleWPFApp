
using System;
using System.ComponentModel;
using System.Drawing;

namespace FarPoint.Win.Spread
{
  [Serializable]
  public class DatabarConditionalFormattingRule
  {
    [Obsolete]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public DatabarConditionalFormattingRule(bool suppressCustomName) : this()
    {
    }

    internal DatabarConditionalFormattingRule(bool suppressCustomName, bool createCommonRule)
    {
    }

    public DatabarConditionalFormattingRule() : base()
    {
    }

    internal DatabarConditionalFormattingRule(DatabarConditionalFormattingRule rule) : base()
    {
    }

    [field: NonSerialized]
    public event PropertyChangedEventHandler PropertyChanged;
    [NonSerialized]
    internal int ignorePropertyChangedCount;
    protected virtual void OnPropertyChanged(string propertyName)
    {
      this.OnPropertyChanged(propertyName, true);
    }

    protected virtual void OnPropertyChanged(string propertyName, bool dataChanged)
    {
      if (this.ignorePropertyChangedCount > 0)
        return;

      if (this.PropertyChanged != null)
        this.PropertyChanged(this, new ConditionalFormattingRulePropertyChangedEventArgs(propertyName, dataChanged));
    }

    private Color fillColor;
    private bool showBorder;
    [DefaultValue(typeof(Color), "99, 142, 198")]
    public Color FillColor
    {
      get
      {
        return fillColor;
      }
      set
      {
        Color fillColor = this.FillColor;
        if (fillColor != value)
        {
          this.OnPropertyChanged("FillColor");
        }
      }
    }
    
    [DefaultValue(false)]
    public bool ShowBorder
    {
      get
      {
        return showBorder;
      }
      set
      {
        bool showBorder = this.ShowBorder;
        if (showBorder != value)
        {
          this.OnPropertyChanged("ShowBorder");
        }
      }
    }

    public object Clone()
    {
      throw new NotImplementedException();
    }
    
  }

  public class ConditionalFormattingRulePropertyChangedEventArgs : PropertyChangedEventArgs
  {
    public ConditionalFormattingRulePropertyChangedEventArgs(string propertyName, bool dataChanged)
      : base(propertyName)
    {
      this.dataChanged = dataChanged;
    }

    private bool dataChanged;
    public bool DataChanged
    {
      get { return this.dataChanged; }
    }
  }
}