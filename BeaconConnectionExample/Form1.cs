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
      BeaconConnector.BeaconChanged += BeaconConnector_BeaconChanged;
    
    }

    private void BeaconConnector_BeaconChanged(object sender, EventArgs e)
    {
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

        }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (BeaconConnector != null)
      {
        BeaconConnector.BeaconChanged -= BeaconConnector_BeaconChanged;
        BeaconConnector.CloseBeaconConnection();
      }
    }
  }
}
