using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operose
{
    public partial class BaseControl : UserControl
    {
        internal string ControlName;

        public BaseControl()
        {
            InitializeComponent();
        }

        public BaseControl(string controlName)
        {
            InitializeComponent();

            ControlName = controlName;
            lblName.Text = ControlName;
        }
    }
}
