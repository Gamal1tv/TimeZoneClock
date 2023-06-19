using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace TimeZoneClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //GLOBALS
        int choiceIndex;
        ReadOnlyCollection<TimeZoneInfo> tzCollection;
        

        //ON FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            tzCollection = TimeZoneInfo.GetSystemTimeZones();
            foreach (TimeZoneInfo tz in tzCollection)
            {
                cboxTimeZone.Items.Add(tz.Id);
            }
            cboxTimeZone.Text = cboxTimeZone.Items[46].ToString();
            choiceIndex = 46;
            lblIsDLS.Text = "Time Zones current as of August 2010";
        }

        //FOR EACH TIMER TICK (1 sec)
        private void timer1_Tick(object sender, EventArgs e)
         {
            TimeZoneInfo tst = TimeZoneInfo.FindSystemTimeZoneById(tzCollection[choiceIndex].Id);
            TimeZoneInfo utc = TimeZoneInfo.FindSystemTimeZoneById(tzCollection[46].Id);
            DateTime yourESTTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, utc, tst);
            string yourESTUI = TimeZoneInfo.ConvertTime(DateTime.UtcNow, utc, tst).ToString("hh:mm:sstt");
            lblTime.Text = yourESTTime.DayOfWeek.ToString() + "\n" + yourESTTime.ToString("MM/dd/yyyy");
            foreach (var button in Controls.OfType<Button>())
            {
                for (int i = 0; i < yourESTUI.Length; i++)
                {
                    if (Convert.ToInt32(button.Tag) == i)
                    {
                        button.Text = yourESTUI[i].ToString();
                    }
                    
                }
            }
        }

        //COMBO BOX TEXT CHANGE
        private void cboxTimeZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            choiceIndex = cboxTimeZone.SelectedIndex;
        }
    }
}
