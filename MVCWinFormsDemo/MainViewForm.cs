using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ModelLibrary;

namespace MVCWinFormsDemo
{
    // View
    public partial class MainViewForm : Form
    {
        #region private

        private readonly Controller _c;

        #endregion

        public MainViewForm(Controller c)
        {
            _c = c;            

            InitializeComponent();
        }

        private void ShowDataCommand(object sender, EventArgs e)
        {
            txtData.Text = _c.GetData();
        }

        private void StartGenerateDataCommand(object sender, EventArgs e)
        {
            tmrNewData.Start();
        }

        private void StopGenerateDataCommand(object sender, EventArgs e)
        {
            tmrNewData.Stop();
        }

        private void NewDataCommand(object sender, EventArgs e)
        {
            string errMessage = string.Empty;

            if (!_c.Add(txtNewData.Text, out errMessage))
	        {
                MessageBox.Show(errMessage, "Wrong format", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNewData.Text = string.Empty;

                StopGenerateDataCommand(this, null);
	        }
        }

        private void chbxActiveModel_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxActiveModel.Checked)
            {
                _c.Changed += ShowDataCommand;
            }
            else
            {
                _c.Changed -= ShowDataCommand;
            }
        }                
    }
}
