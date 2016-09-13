using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MDWlite
{
    public partial class TabletMonitor : Form
    {
        #region Class Variables
        BindingSource bs = new BindingSource();
        BindingSource bsT = new BindingSource();
        BindingSource bsU = new BindingSource();
        List<Panel> Plist = new List<Panel>();
        List<ProgressBar> Proglist = new List<ProgressBar>();
        List<Label> Labellist = new List<Label>();
        #endregion

        #region Form Management
        public TabletMonitor()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Start();
            LoadData();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
            CS203.Handlers(false);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            drawMonitor();
        }
        #endregion

        #region GUI Management
        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            if (btnConnect.Text == "Connect")
            {
                if (CS203.Connect(Program.appSetting.IP))
                {
                    btnConnect.Text = "Disconnect";
                    btnPlay.Text = "Play";
                    lbl2.Text = "On";
                    lbl.Text = CS203.Reader.State.ToString();
                }
                else
                    lbl2.Text = "Off";
            }
            else
            {
                btnConnect.Text = "Connect";
                lbl2.Text = "Off";
                lbl.Text = "";
                CS203.Stop();
            }
            Cursor.Current = Cursors.Default;
            this.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Play")
            {
                if (CS203.Play(Program.appSetting.PowerVal))
                {
                    ((Button)sender).Text = "Pause";
                    tmr.Enabled = true;
                }
            }
            else
            {
                if (CS203.Pause())
                {
                    ((Button)sender).Text = "Play";
                    tmr.Enabled = false;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string EPC = CS203.getOneEPC();
            if (EPC == null)
                return;
            AppSettings.User _user = Program.appSetting.Users.Find(delegate(AppSettings.User nn) { return (nn._epcE == EPC); });
            AppSettings.Tablet _tablet = Program.appSetting.Tablets.Find(delegate(AppSettings.Tablet nn) { return (nn._epcT == EPC); });
            if (_user != null)
            {
                MessageBox.Show("EPC asignado previamente a usuario");
                return;
            }
            else if (_tablet != null)
            {
                MessageBox.Show("EPC asignado previamente a tablet");
                return;
            }
            if (tbcAll.SelectedTab.Text == "Usuarios")
            {
                if (dgvUsers.SelectedCells.Count == 0)
                    return;
                int _row = dgvUsers.CurrentCell.RowIndex;
                dgvUsers.Rows[_row].Cells[4].Value = EPC;
            }
            else if (tbcAll.SelectedTab.Text == "Tablets")
            {
                if (dgvTablets.SelectedCells.Count == 0)
                    return;
                int _row = dgvTablets.CurrentCell.RowIndex;
                dgvTablets.Rows[_row].Cells[3].Value = EPC;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tb0.Size.Height.ToString());
            drawMonitor();
        }
        private void n1_ValueChanged(object sender, EventArgs e)
        {
            drawMonitor();
        }
        private void dgvEPCs_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string st = "In here I'm gonna do nothing";
        }
        //private void dgvTablets_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    drawMonitor();
        //}
        //private void dgvTablets_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        //{
        //    drawMonitor();
        //}
        private void tmr_Tick(object sender, EventArgs e)
        {
            bs.ResetBindings(false);
            lbl.Text = CS203.Reader.State.ToString();
            if (Proglist.Count == 0)
                return;
            //Recorrido EPCs Vs Tablets
            foreach (var x in Program.appSetting.Tablets)
            {
                CS203.EPCread _fTab = CS203.EPCs.Find(delegate(CS203.EPCread nn) { return (nn._epc == x._epcT); });
                if (_fTab == null)
                {
                    if (x._status == "1" )//| x._status == "0")
                    {
                        ModifyPanel(x._id, "", 0, 5);
                        continue;
                    }
                    if (x._status != "3")
                    {
                        //ModifyPanel(x._id);
                        if (x._status != "2")
                            x._status = "0";
                        continue;
                    }

                }
                else
                {
                    x._status = "1";
                    ModifyPanel(x._id, "", double.Parse(_fTab._rssi) * 10, 1);
                }
            }
            //Recorrido EPCs Vs Users
            foreach (var x in Program.appSetting.Users)
            {
                CS203.EPCread _fUserActive = CS203.EPCs.Find(delegate(CS203.EPCread nn) { return (nn._epc == x._epcE); });
                if (_fUserActive == null)
                    continue;
                AppSettings.Tablet _fTab = Program.appSetting.Tablets.Find(delegate(AppSettings.Tablet nn) { return (nn._id == x._tablet); });
                if (_fTab == null)
                    continue;
                CS203.EPCread _fTabRead = CS203.EPCs.Find(delegate(CS203.EPCread nn) { return (nn._epc == _fTab._epcT); });
                if (_fTabRead == null)
                {
                    if (_fTab._status == "2" | _fTab._status == "3")
                    {
                        _fTab._status = "3";
                        ModifyPanel(_fTab._id, "", 0, 3);
                    }
                    else
                    {
                        ModifyPanel(_fTab._id, "", 0, 4);
                    }
                    continue;
                }

                ModifyPanel(_fTab._id, "", double.Parse(_fTabRead._rssi) * 10, 2);
                _fTab._status = "2";
            }

        }
        #endregion

        #region Class Methods
        void Start()
        {
            CS203.Handlers(true);
            bs.DataSource = CS203.EPCs;
            dgvEPCs.DataSource = bs;

            bsT.DataSource = Program.appSetting.Tablets;
            dgvTablets.DataSource = bsT;

            bsU.DataSource = Program.appSetting.Users;
            dgvUsers.DataSource = bsU;

            drawMonitor();
        }
        void LoadData()
        {
            txtIP.Text = Program.appSetting.IP;
            numPower.Value = Program.appSetting.PowerVal;

            //numMaxRel.Value = Program.appSetting.maxRelation;
            numBorrar.Value = Program.appSetting.numBorrar;
            numSuccess.Value = Program.appSetting.bitSuccess;
            numONsuccess.Value = Program.appSetting.TONsuccess;
            numOFFsuccess.Value = Program.appSetting.TOFFsuccess;
            numNsuccess.Value = Program.appSetting.Nsuccess;
            numError.Value = Program.appSetting.bitError;
            numONerror.Value = Program.appSetting.TONerror;
            numOFFerror.Value = Program.appSetting.TOFFerror;
            numNerror.Value = Program.appSetting.Nerror;
        }
        void ModifyPanel(string id)
        {
            ModifyPanel(id, "", 0, 0);
        }
        void ModifyPanel(string id, string name, double rssi, int status)
        {
            ProgressBar pb = Proglist.Find(delegate(ProgressBar nn) { return (nn.Name == "Progress_" + id); });
            Panel p = Plist.Find(delegate(Panel nn) { return (nn.Name == "Panel_" + id); });
            Label l = Labellist.Find(delegate(Label nn) { return (nn.Name == "LabelStatus_" + id); });
            pb.Value = (int)rssi;
            switch (status)
            {
                case 0:
                    p.BackColor = Color.WhiteSmoke;
                    l.Text = "Not present";
                    break;
                case 1:
                    p.BackColor = Color.Yellow;
                    l.Text = "Available";
                    break;
                case 2:
                    p.BackColor = Color.Green;
                    l.Text = "Ready";
                    break;
                case 3:
                    if (l.Text != "Assigned")
                    {
                        p.BackColor = Color.Blue;
                        l.Text = "Assigned";
                        p.Refresh();
                        l.Refresh();
                        towerLight(0);
                    }
                    break;
                case 4:
                    p.BackColor = Color.DarkGray;
                    l.Text = "Not available";
                    break;
                case 5:
                    if (l.Text != "Wrong")
                    {
                        p.BackColor = Color.Red;
                        l.Text = "Wrong";
                        p.Refresh();
                        l.Refresh();
                        towerLight(1);
                    }
                    break;
            }
        }
        void towerLight(int status)
        {
            int bSuc = Program.appSetting.bitSuccess;
            int bErr = Program.appSetting.bitError;
            int TonS = Program.appSetting.TONsuccess;
            int TonE = Program.appSetting.TONerror;
            int ToffS = Program.appSetting.TOFFsuccess;
            int ToffE = Program.appSetting.TOFFerror;
            int nSuc = Program.appSetting.Nsuccess;
            int nErr = Program.appSetting.Nerror;

            switch (status)
            {
                case 0://Éxito
                    for (int i = 1; i <= nSuc; i++)
                    {
                        CS203.SetBit(bSuc, true);
                        System.Threading.Thread.Sleep(TonS);
                        CS203.SetBit(bSuc, false);
                        System.Threading.Thread.Sleep(ToffS);
                    }
                    break;
                case 1://Error
                    for (int i = 1; i <= nErr; i++)
                    {
                        CS203.SetBit(bErr, true);
                        System.Threading.Thread.Sleep(TonE);
                        CS203.SetBit(bErr, false);
                        System.Threading.Thread.Sleep(ToffE);
                    }
                    break;
            }
        }
        void Save()
        {
            this.Enabled = false;
            Application.DoEvents();

            Program.appSetting.IP = txtIP.Text.Trim();
            Program.appSetting.PowerVal = (int)numPower.Value;

            Program.appSetting.maxRelation = (int)0;
            Program.appSetting.numBorrar = (int)numBorrar.Value;

            Program.appSetting.bitSuccess = (int)numSuccess.Value;
            Program.appSetting.TONsuccess = (int)numONsuccess.Value;
            Program.appSetting.TOFFsuccess = (int)numOFFsuccess.Value;
            Program.appSetting.Nsuccess = (int)numNsuccess.Value;
            Program.appSetting.bitError = (int)numError.Value;
            Program.appSetting.TONerror = (int)numONerror.Value;
            Program.appSetting.TOFFerror = (int)numOFFerror.Value;
            Program.appSetting.Nerror = (int)numNerror.Value;

            Program.SaveSettings();
            Application.DoEvents();
            this.Enabled = true;
        }
        void drawMonitor()
        {
            tb0.Controls.Clear();
            Plist.Clear();
            Proglist.Clear();
            Labellist.Clear();

            int x = tb0.Size.Width;
            int y = tb0.Size.Height;
            double l = Math.Sqrt(Program.appSetting.Tablets.Count);
            double le = l - (int)l;
            l = le == 0.0 ? l : (int)l + 1;

            double x_p = x / l;
            double y_p = y / l;

            int brX = 0;
            for (int j = 0; j < l; j++)
            {
                for (int i = 0; i < l; i++)
                {
                    Panel p = new Panel();
                    p.Location = new Point((int)(x_p * i), (int)(y_p * j));
                    p.Size = new Size((int)x_p, (int)y_p);
                    p.BackColor = Color.WhiteSmoke;
                    p.BorderStyle = BorderStyle.Fixed3D;
                    p.Parent = tb0;
                    Plist.Add(p);
                    p.Name = "Panel_" + Program.appSetting.Tablets[brX]._id;
                    ProgressBar pb = new ProgressBar();
                    pb.Location = new Point((int)(x_p * i), (int)(y_p * j));
                    pb.Size = new Size((int)x_p, (int)y_p / 7);
                    pb.Parent = tb0;
                    pb.Name = "Progress_" + Program.appSetting.Tablets[brX]._id;
                    pb.Minimum = 0;
                    pb.Maximum = 1000;
                    pb.BringToFront();
                    Proglist.Add(pb);
                    Label lbl = new Label();
                    lbl.Location = new Point((int)(x_p * i + x_p / 4), (int)(y_p * j + y_p / 4));
                    lbl.Text = Program.appSetting.Tablets[brX]._id;
                    lbl.Parent = tb0;
                    lbl.BringToFront();
                    Label lbl2 = new Label();
                    lbl2.Location = new Point((int)(x_p * i + x_p / 4), (int)(y_p * j + 2 * y_p / 4));
                    lbl2.Text = Program.appSetting.Tablets[brX]._status;
                    lbl2.Parent = tb0;
                    lbl2.Name = "LabelStatus_" + Program.appSetting.Tablets[brX]._id;
                    lbl2.BringToFront();
                    Labellist.Add(lbl2);
                    brX++;
                    if (brX >= Program.appSetting.Tablets.Count)
                    {
                        goto FinishTablets;
                    }
                }
            }

        FinishTablets:
            this.Refresh();
            //
        }
        #endregion

    }
}
