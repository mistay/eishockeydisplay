using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using databoardHelper;
using LOS6Connector;

namespace BeaconConnectionExample
{
  public partial class Form1 : Form
  {
    ZeromqBeaconConnector BeaconConnector; //CHANGE
    WebserverStatic webserverStatic = null;



    public Form1()
    {
        InitializeComponent();
            webserverStatic = new WebserverStatic();
            webserverStatic.Start("http://+:8080/static/");
            start();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.îpaddress = txtAddress.Text;
            Properties.Settings.Default.port = txtPort.Text;
            Properties.Settings.Default.Save();

            start();
        }

        private void start() { 

      if (BeaconConnector!=null)
      {
        BeaconConnector.BeaconChanged -= BeaconConnector_BeaconChanged;
        BeaconConnector.CloseBeaconConnection();
      }
      else
      {
        BeaconConnector = new ZeromqBeaconConnector();
      }
      var serverPort = Convert.ToInt32(txtPort.Text);      
      var cr = BeaconConnector.OpenBeaconConnection(txtAddress.Text, serverPort, "username", "password");
            Log.getInstance().info(String.Format("opening connection to {0}:{1}", txtAddress.Text, serverPort));
      BeaconConnector.BeaconChanged += BeaconConnector_BeaconChanged;
    
    }

    private void BeaconConnector_BeaconChanged(object sender, EventArgs e)
    {
        Log.getInstance().info(String.Format("BeaconConnector_BeaconChanged"));
        var ci= HdTimingBeacon.GetMainClock(BeaconConnector.CurrentBeacon); //CHANGE
        lblMainClock.Text = String.Format("{0:00}:{1:00}", ci.ClockMinutesCorrected, ci.ClockSecondsCorrected);
        lblScoreHome.Text = ci.ScoreHome.ToString();
        lblScoreAway.Text = ci.ScoreAway.ToString();
        lblPeriod.Text = ci.Period.ToString();
        lblMainClock.BackColor = ci.ClockIsRunning ? Color.Green : Color.Red;
        lblMainClock.ForeColor = (HdTimingBeacon.PerceivedBrightness(lblMainClock.BackColor) > 130 ? Color.Black : Color.White);
        lblPeriod.BackColor = ci.ClockIsLastMinute ? Color.Yellow : Color.Blue;
        Data data = Data.getInstance();
        data.mainClock = String.Format("{0:00}:{1:00}", ci.ClockMinutesCorrected, ci.ClockSecondsCorrected);
        data.scoreHome = ci.ScoreHome.ToString();
        data.scoreAway = ci.ScoreAway.ToString();
        data.period = ci.Period.ToString();
        data.clockIsLastMinute = ci.ClockIsLastMinute;
        data.clockIsRunning = ci.ClockIsRunning;
        data.TeamnameHome = ci.TeamnameHome;
        data.TeamnameAway = ci.TeamnameAway;

        data.ShootoutScoreAway = ci.ShootoutScoreAway.ToString();
        data.ShootoutScoreHome = ci.ShootoutScoreHome.ToString();



            //ci.ShootoutScoreHome;


            IceHockeyClockInformation tmp = HdTimingBeacon.GetPenaltyHome1Clock(BeaconConnector.CurrentBeacon);
        if (tmp != null)
        {
            data.penalty1homejersey = tmp.JerseyNr;
            data.penalty1homeClockMinutesCorrected = tmp.ClockMinutesCorrected.ToString();
            data.penalty1homeClockSecondsCorrected = tmp.ClockSecondsCorrected.ToString();
        }

        tmp = HdTimingBeacon.GetPenaltyHome2Clock(BeaconConnector.CurrentBeacon);
        if (tmp != null)
        {
            data.penalty2homejersey = tmp.JerseyNr;
            data.penalty2homeClockMinutesCorrected = tmp.ClockMinutesCorrected.ToString();
            data.penalty2homeClockSecondsCorrected = tmp.ClockSecondsCorrected.ToString();
        }

        tmp = HdTimingBeacon.GetPenaltyAway1Clock(BeaconConnector.CurrentBeacon);
        if (tmp != null)
        {
            data.penalty1awayjersey = tmp.JerseyNr;
            data.penalty1awayClockMinutesCorrected = tmp.ClockMinutesCorrected.ToString();
            data.penalty1awayClockSecondsCorrected = tmp.ClockSecondsCorrected.ToString();
        }

        tmp = HdTimingBeacon.GetPenaltyAway2Clock(BeaconConnector.CurrentBeacon);
        if (tmp != null)
        {
            data.penalty2awayjersey = tmp.JerseyNr;
            data.penalty2awayClockMinutesCorrected = tmp.ClockMinutesCorrected.ToString();
            data.penalty2awayClockSecondsCorrected = tmp.ClockSecondsCorrected.ToString();
        }

        
        data.id++;
        Log.getInstance().info("updated data");
    }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (BeaconConnector != null)
      {
        BeaconConnector.BeaconChanged -= BeaconConnector_BeaconChanged;
        BeaconConnector.CloseBeaconConnection();
      }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BeaconConnector != null)
            {
                BeaconConnector.BeaconChanged -= BeaconConnector_BeaconChanged;
                BeaconConnector.CloseBeaconConnection();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
