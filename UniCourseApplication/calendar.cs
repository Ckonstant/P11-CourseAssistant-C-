using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Syncfusion.Schedule;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Schedule;
namespace UniCourseApplication.GridScheduleSample
{
    public partial class calendar : Form
    {
       //private IContainer components;
        public calendar()
        {
            

            // initialize the data somehow - specific to your implementation
            GridScheduleSample.SimpleScheduleDataProvider scheduleProvider;
            if (File.Exists("default.schedule"))
            {
                scheduleProvider = GridScheduleSample.SimpleScheduleDataProvider.LoadBinary("default.schedule");
                scheduleProvider.FileName = "default.schedule";
            }
            else
            {
                scheduleProvider = new GridScheduleSample.SimpleScheduleDataProvider();
                scheduleProvider.MasterList = new GridScheduleSample.SimpleScheduleAppointmentList();
                scheduleProvider.FileName = "default.schedule";
            }

            ScheduleControl1.ScheduleType = ScheduleViewType.Month; // ScheduleViewType.Day;//.WorkWeek;//.Week;//ScheduleViewType.WorkWeek;// ScheduleViewType.Day;//.WorkWeek;
            // set the data source
            ScheduleControl1.DataSource = scheduleProvider;
            // Dim ico As System.Drawing.Icon = New System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "Suite.ico"))
            // Me.Icon = ico
            // subscibe to item click event
            // AddHandler ScheduleControl1.ScheduleAppointmentClick, AddressOf ScheduleControl1_ScheduleAppointmentClick
            // Hook the event for showing the appointment.
            // AddHandler ScheduleControl1.ShowingAppointmentForm, AddressOf scheduleControl1_ShowingAppointmentForm
        }

        private void calendar_Load(object sender, EventArgs e)
        {

        }

    }
}
