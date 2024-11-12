using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarPoint.Win.Spread
{
  internal class ClockHand
  {
    private Color fillcolor;
    private bool showBorder;

    internal Color FillColor
    {
      get { return fillcolor; }
      set { fillcolor = value; }
    }

    internal bool ShowBorder
    {
      get { return showBorder; }
      set { showBorder = value; }
    }
  }
}
