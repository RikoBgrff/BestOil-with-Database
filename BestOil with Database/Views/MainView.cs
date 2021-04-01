using BestOil_with_Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil_with_Database.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }
        string time = DateTime.Now.ToString();
        public EventHandler<EventArgs> AddButtonClicked { get; set; }
        public EventHandler<EventArgs> LoadButtonClicked { get; set; }
        public string NameText { get => comboBox1.SelectedIndex.ToString(); }
        public string LiterText { get => LiterTxtb.Text; set => LiterTxtb.Text = value; }
        public string PayText { get => PayTxtBx.Text; set => PayTxtBx.Text = value; }
        public string PaymentDateTimeText { get => DateTime.Now.ToString(); set => time = value; }
        public List<Payment> payments
        {
            set
            {

                {
                    listBox1.DataSource = null;
                    listBox1.DataSource = value;
                }

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddButtonClicked.Invoke(sender, e);

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadButtonClicked.Invoke(sender, e);
        }
    }
}
