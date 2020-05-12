using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Net;
using CushyTripV1.Class;
using Newtonsoft.Json;

namespace CushyTripV1
{
    public partial class TravelPackages : Form
    {
        string memberID;
        public TravelPackages(string memberID)
        {
            InitializeComponent();
            this.memberID = memberID;
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

        }

        private void TravelPackages_Load(object sender, EventArgs e)
        {
            //this.DoubleBuffered = true;
            //flowLayoutPanel1.VerticalScroll.Enabled = false;
            //flowLayoutPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
        
            
            
            List<RegularPackage> regularPackages;

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString("http://cushytrip.tk/regularpackage.php");

                object result = JsonConvert.DeserializeObject<List<RegularPackage>>(json);

                regularPackages = result as List<RegularPackage>;
            }


            foreach (var r in regularPackages)
            {
                
                string image = "";

                if (!(r.images.Count == 0)) image = r.images[0];

                USCTourPackage uc = new USCTourPackage(image, r.packageName, r.details,r.regularPackageID,r.price,r.images);

                flowLayoutPanel1.Controls.Add(uc);
            }
            
            //flowLayoutPanel1.HorizontalScroll.Maximum = 0;
        }

        static int slide = 0;
        private void slider_ValueChanged(object sender, EventArgs e)
        {
            
            flowLayoutPanel1.AutoScrollPosition = new Point(0,slide+=20);

        }
        int currentPage = 1;
        private bool loadFlow(int x,int y)
        {

            if (currentPage == x) return false;

            flowLayoutPanel1.Visible = false;
           
            flowLayoutPanel1.Controls.Clear();
            
            string[] name = { "Boracay", "Palawan", "Koui Beach", "Enchanted Kingdom", "Star City", "Pooop" };
            string detail = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                 " Cras aliquam dolor et purus semper tincidunt. Sed a erat eget leo" +
                 " porta dictum sit amet id nisi. Sed euismod maximus eros, vitae luctus magna." +
                 " Ut consectetur ipsum vitae odio dignissim tempus. Etiam sollicitudin posuere " +
                 "laoreet. Integer nec est mi. Etiam tempor vehicula volutpat. Maecenas egestas " +
                 "sapien sem, vel vehicula sem gravida non. Sed et dui id dolor viverra condimentum. " +
                 "Vivamus ac sapien non nisl auctor ullamcorper nec sit amet eros. Morbi consequat ac velit nec accumsan.";
            for (int i = x; i <= y; i++)
            {
                string img = @"E:\Download\" + i + ".jpg";

                USCTourPackage uc = new USCTourPackage(img, name[i - 1], detail,"0","",null);

                flowLayoutPanel1.Controls.Add(uc);
            }

            foreach(var p in flowLayoutPanel1.Controls.Cast<USCTourPackage>())
            {
                p.Visible = true;
            }

            flowLayoutPanel1.Visible = true;

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (loadFlow(1, 3) == true) currentPage = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (loadFlow(3, 6) == true) currentPage = 3;
            
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            
            if (bunifuSwitch1.Value == true) flowLayoutPanel1.Visible = true;

            else flowLayoutPanel1.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            using (Form f = new CreateTourPackage(memberID))
            {
                f.ShowDialog();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string[] name = { "Boracay", "Palawan", "Koui Beach", "Enchanted Kingdom", "Star City", "Pooop" };
            string detail = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                 " Cras aliquam dolor et purus semper tincidunt. Sed a erat eget leo" +
                 " porta dictum sit amet id nisi. Sed euismod maximus eros, vitae luctus magna." +
                 " Ut consectetur ipsum vitae odio dignissim tempus. Etiam sollicitudin posuere " +
                 "laoreet. Integer nec est mi. Etiam tempor vehicula volutpat. Maecenas egestas " +
                 "sapien sem, vel vehicula sem gravida non. Sed et dui id dolor viverra condimentum. " +
                 "Vivamus ac sapien non nisl auctor ullamcorper nec sit amet eros. Morbi consequat ac velit nec accumsan.";
            for (int i = 1; i <= 6; i++)
            {
                string img = @"E:\Download\" + i + ".jpg";

                USCTourPackage uc = new USCTourPackage(img, name[i - 1], detail,"0","",null);

                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
