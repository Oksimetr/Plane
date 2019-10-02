using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planes
{
    delegate void LogMessage(string message);
    sealed public partial class FormMain : Form
    {
        private Planelist list = new Planelist();
        private LandPlan landPlan;
        Supervisor sVisor = new Supervisor();

        public FormMain()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.Columns.Add("number", 50);
            listView1.Columns.Add("fuel", 50);
            listView1.Columns.Add("fuelspeed", 60);
            listView1.Columns.Add("firmname", 80);
            listView1.Columns.Add("timeforland", 90);
            listView1.Columns.Add("status", 90);

            foreach (Plane p in list)
            {
                p.OnMessage += PrintMesage;
                listView1.Items.Add(p.Item);
            }

            landPlan = sVisor.LandPlaneByFuel;
            UpdateFirmsComboBox();
            InitPlaneCmBox();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timermain.Enabled = true;
            timermain.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timermain.Stop();
            timermain.Enabled = false;
            labelTime.Text = "Время остановлено";
        }

        private void timermain_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");

            foreach (Plane p in list)
                p.TimeTick(1);

            landPlan(list);

            listView1.Items.Clear();
            foreach (Plane p in list)
                listView1.Items.Add(p.Item);
        }
        public void PrintMesage(string message)
        {
            textBoxLog.AppendText(message);
            textBoxLog.AppendText(Environment.NewLine);
        }

        private void radioButtonOrder_CheckedChanged(object sender, EventArgs e)
        {
            landPlan = sVisor.LandPlaneByNumber;
        }

        private void radioButtonFuel_CheckedChanged(object sender, EventArgs e)
        {
            landPlan = sVisor.LandPlaneByFuel;
        }
        private void radioButtonFirm_CheckedChanged(object sender, EventArgs e)
        {
            landPlan = sVisor.LandPlaneByFirm;
            sVisor.Firm = comboBoxFirm.Text;
        }
        private void UpdateFirmsComboBox()
        {
            comboBoxFirm.Items.Clear();
            comboBoxFirm.Items.AddRange((list.GetFirmList().Distinct()).ToArray());
            if (comboBoxFirm.SelectedItem == null)
                comboBoxFirm.SelectedIndex = 0;
            sVisor.Firm = comboBoxFirm.Text;
        }
        private void InitPlaneCmBox()
        {
            foreach (Plane p in list)
            {
                Plane p_new = (Plane)p.Clone();
                comboBoxPlanes.Items.Add(p_new);
                comboBoxPlanes.ValueMember = p_new.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxPlanes.SelectedItem == null) return;
            Plane p = (Plane)((Plane)comboBoxPlanes.SelectedItem).Clone();
            p.OnMessage += PrintMesage;
            list.Add(p);
            listView1.Items.Add(((Plane)comboBoxPlanes.SelectedItem).Item);
        }

        private void comboBoxFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            sVisor.Firm = comboBoxFirm.Text;
        }
    }
}
