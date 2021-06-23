using OilSystemWithDB.Model;
using OilSystemWithDB.Wiew;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilSystemWithDB
{
    public partial class Form1 : Form, IMainWiew
    {
        public Form1()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> ComboBoxSelectCahnnged { get ; set ; }
        public EventHandler<EventArgs> HotDogcheckboxisCliked { get; set; }
        public EventHandler<EventArgs> ColacheckboxisCliked { get ; set ; }
        public EventHandler<EventArgs> HamburgercheckboxisCliked { get; set ; }
        public EventHandler<EventArgs> KartofFreecheckboxisCliked { get; set ; }
        public EventHandler<EventArgs> LitrTxtBoxChanged { get ; set ; }
        public EventHandler<EventArgs> MeblegTxtBoxChanged { get; set; }
        public EventHandler<EventArgs> BuyBtnClicked { get ; set ; }
        public string meblegText { get => Meblegtextbox.Text; set=>Meblegtextbox.Text=value; }
        public string Litrtext { get => Meblegtextbox.Text; set=>Meblegtextbox.Text=value; }
        

        public List<Oil> oils { set {
                ListBox1.DataSource = null;
                ListBox1.DataSource = value;
            
            } }
        public List<Cafe> cafes { set {

                ListBox1.DataSource = null;
                ListBox1.DataSource=value;
            } }

        public int ComboboxSelectedIndex { get=>comboBox1.SelectedIndex; set => comboBox1.SelectedIndex=value; }
        public EventHandler<EventArgs> RadioBtnCheckedChanged { get ; set; }
        public string OilTotalLbltextChanged { get =>TotalSalaryy.Text; set => TotalSalaryy.Text=value; }
        public List<Oil> Oils {
            get => (List<Oil>)comboBox1.DataSource;
            set {
                ListBox1.DataSource = null;
                ListBox1.DataSource = value;
            } }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Oil> Oils = new List<Oil>
            {
                new Oil
                {
                     Name="AI-92",
                      Price=0.90
                },
                new Oil
                {
                    Name="AI-95",
                     Price=1.25
                },
                new Oil
                {
                    Name="DIZEl",
                     Price=0.60
                }
            };
            comboBox1.DataSource = Oils;

        }
        //private void ComboboxOil_SelectedIndexChanged(object sender,EventArgs e)
        //{
        //    //ComboBoxSelectCahnnged.Invoke(sender, e);
        //}
        //private void RaddioBtnCheckedChanged(object sender,EventArgs e)
        //{
        //    RadioBtnCheckedChanged.Invoke(sender, e);
        //}

    }
}
