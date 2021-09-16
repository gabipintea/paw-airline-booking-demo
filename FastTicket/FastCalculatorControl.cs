using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTicket
{
    public partial class FastCalculatorControl : UserControl
    {
        public FastCalculatorControl()
        {
            InitializeComponent();
        }

        #region Methods
        private void Calculate()
        {
            tbFinalPrice.Text = (int.Parse(tbAdults.Text) * int.Parse(tbFullPrice.Text) + int.Parse(tbChildren.Text) * int.Parse(tbChildPrice.Text)).ToString();
        }
        #endregion

        #region Events

        #endregion

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
