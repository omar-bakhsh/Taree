using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HajjHachathon.Tarie.Model.Contracts;

namespace HajjHachathon.Tarie.Test
{
    public partial class AssignAgent : Form
    {
        public AssignAgent()
        {
            InitializeComponent();
            var cases = BLL.Bll.GetUnresolvedCases().Cases;
            comboBox1.DataSource = cases;
            comboBox1.DisplayMember = "Id";
            comboBox1.ValueMember = "Id";
        }

        private CaseContract SelectedCase;
        private void button1_Click(object sender, EventArgs e)
        {
            var result=BLL.Bll.AssignAgent(SelectedCase);
            txtAssigned.Text = result.Message;
            txtAssigned.Visible = labAssigned.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCase = BLL.Bll.GetCaseById((int) comboBox1.SelectedValue).Case;
            txtAssigned.Text=String.Empty;
            txtAssigned.Visible = labAssigned.Visible = false;
        }
    }
}
