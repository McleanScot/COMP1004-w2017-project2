/*
 * scot mclean
 * 2, 10, 2017
 * get's calculates the sales bonus for employees.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpAutoCenter
{
    /*
    * listing all instance variables 
    */
    public partial class SharpAutoCenter : Form
    {
        private decimal _additionalPrice;
        private decimal _basePrice;
        private decimal _subTotal;
        private decimal _steroSystemPrice = 425.76m;
        private decimal _leatherInterior = 987.41m;
        private decimal _computerNavigationPrice = 1741.23m;
        private decimal _standardPrice = 0.0m;
        private decimal _pearlizedPrice = 345.72m;
        private decimal _customDetailingPrice = 599.99m;
        private decimal _taxRate = 0.13m;
        private decimal _taxes;
        private decimal _total;
        private decimal _tradeInValue;
        private decimal _amountDue;
      

        public SharpAutoCenter()
        {
            InitializeComponent();
        }
        /*
        *  closing the application when the exit menu button is clicked 
        */
        private void _exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
        *adding and subtracting the stereo price to the additional price 
        * based off if the checkbox is checked or not
        */

        private void _StereoSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StereoSystemCheckBox.Checked)
            {
                _additionalPrice += _steroSystemPrice;
                AdditionalOptionsTextBox.Text = Convert.ToString("$" + _additionalPrice);
            }
            if (!StereoSystemCheckBox.Checked)
            {
                _additionalPrice -= _steroSystemPrice;
                AdditionalOptionsTextBox.Text = Convert.ToString("$" + _additionalPrice);
            };
        }
        /*
        *adding and subtracting the leather interior price to the additional price 
        * based off if the checkbox is checked or not
        */
        private void _LeatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LeatherInteriorCheckBox.Checked)
            {
                _additionalPrice += _leatherInterior;
                AdditionalOptionsTextBox.Text = Convert.ToString("$" + _additionalPrice);
            }
            if (!LeatherInteriorCheckBox.Checked)
            {
                _additionalPrice -= _leatherInterior;
                AdditionalOptionsTextBox.Text = Convert.ToString("$" + _additionalPrice);
            };
        }
        /*
        *adding and subtracting the computer nav price to the additional price 
        * based off if the checkbox is checked or not
        */
        private void _ComputerNavCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ComputerNavCheckBox.Checked)
            {
                _additionalPrice += _computerNavigationPrice;
                AdditionalOptionsTextBox.Text = Convert.ToString("$" + _additionalPrice);
            }
            if (!ComputerNavCheckBox.Checked)
            {
                _additionalPrice -= _computerNavigationPrice;
                AdditionalOptionsTextBox.Text = Convert.ToString("$" + _additionalPrice);
            };
        }
        /*
        *adding and subtracting the standard price to the additional price 
        * based off if the checkbox is checked or not
        */
        private void _StandardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StandardRadioButton.Checked)
            {
                _additionalPrice += _standardPrice;
                AdditionalOptionsTextBox.Text = Convert.ToString("$" + _additionalPrice);
            }
            if (!StandardRadioButton.Checked)
            {
                _additionalPrice -= _standardPrice;
                AdditionalOptionsTextBox.Text = Convert.ToString("$" + _additionalPrice);
            }
        }
        /*
        *adding and subtracting the pearlized price to the additional price 
        * based off if the checkbox is checked or not
        */
        private void _PearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PearlizedRadioButton.Checked)
            {
                _additionalPrice += _pearlizedPrice;
                AdditionalOptionsTextBox.Text = Convert.ToString("$" + _additionalPrice);
            }
            if (!PearlizedRadioButton.Checked)
            {
                _additionalPrice -= _pearlizedPrice;
                AdditionalOptionsTextBox.Text = Convert.ToString("$" + _additionalPrice);
            }
        }
        /*
        *adding and subtracting the custom detailing price to the additional price 
        * based off if the checkbox is checked or not
        */
        private void _CustomizedDetailingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomizedDetailingRadioButton.Checked)
            {
                _additionalPrice += _customDetailingPrice;
                AdditionalOptionsTextBox.Text = Convert.ToString("$" + _additionalPrice);
            }
            if (!CustomizedDetailingRadioButton.Checked)
            {
                _additionalPrice -= _customDetailingPrice;
                AdditionalOptionsTextBox.Text = Convert.ToString("$" + _additionalPrice);
            }
        }
        /*
        * doing all the calculations and then assigning them to string values for the textboxes.
        */
        private void _CalculateButton_Click(object sender, EventArgs e)
        {
            _basePrice = Convert.ToDecimal(BasePriceTextBox.Text);
            _subTotal = _additionalPrice + _basePrice;
            SubTotalTextBox.Text = _subTotal.ToString("C2");
            _taxes = _taxRate * _subTotal;
            SalesTaxTextBox.Text = _taxes.ToString("C2");
            _total = _subTotal - _taxes;
            TotalTextBox.Text = _total.ToString("C2");
            _tradeInValue = Convert.ToDecimal(TradeInTextBox.Text);
            _amountDue = _total - _tradeInValue;
            AmountDueTextBox.Text = _amountDue.ToString("C2");
        }
        /*
        * clearing the text fields for the text boxes back to their defualts
        */
        private void _ClearButton_Click(object sender, EventArgs e)
        {
            BasePriceTextBox.Text = "";
            AdditionalOptionsTextBox.Text = "";
            SubTotalTextBox.Text = "";
            SalesTaxTextBox.Text = "";
            TotalTextBox.Text = "";
            TradeInTextBox.Text = "0";
            AmountDueTextBox.Text = "";
            StereoSystemCheckBox.Checked = false;
            LeatherInteriorCheckBox.Checked = false;
            ComputerNavCheckBox.Checked = false;
            StandardRadioButton.Checked = true;
        }
        /*
        * closing the application when the exit button is clicked.
        */
        private void _ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
