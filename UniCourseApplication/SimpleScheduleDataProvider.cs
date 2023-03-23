using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Syncfusion.Schedule;

namespace UniCourseApplication.GridScheduleSample
{
    #region simple data provider - concrete implementations of IScheduleDataProvider, IScheduleAppointmentList, IScheduleAppointment

    /// <summary>
    /// Derives <see cref="ScheduleDataProvider"/> to implement <see cref="IScheduleDataProvider"/>.
    /// </summary>
    /// <remarks>
    /// This implementation of IScheduleDataProvider uses a collection of <see cref="SimpleScheduleAppointment"/>
    /// objects to hold the items displayed in the schedule. This collection is serialized to disk as a 
    /// binary file. The serialization is restricted to the SimpleScheduleDataProvider.MasterList and the
    /// SimpleScheduleAppointment objects that it holds. 
    /// </remarks>
    public class SimpleScheduleDataProvider : ScheduleDataProvider
    {

        public static ListObjectList list;
        // INSTANT VB NOTE: The variable markerList was renamed since Visual Basic does not allow class members with the same name:
        public static ListObjectList markerList_Renamed;
        // INSTANT VB NOTE: The variable reminderList was renamed since Visual Basic does not allow class members with the same name:
        public static ListObjectList reminderList_Renamed;
        // INSTANT VB NOTE: The variable locationList was renamed since Visual Basic does not allow class members with the same name:
        public static ListObjectList locationList_Renamed;

        public SimpleScheduleDataProvider() : base()
        {
        }

        private string fileName_Renamed;

        public string FileName
        {
            get
            {
                return fileName_Renamed;
            }
            set
            {
                fileName_Renamed = value;
            }
        }

        private SimpleScheduleAppointmentList masterList_Renamed;
        public override ILookUpObjectList GetLabels()
        {
            return list;
        }

        public override ILookUpObjectList GetLocations()
        {
            return locationList_Renamed;
        }

        public override ILookUpObjectList GetMarkers()
        {
            return markerList_Renamed;
        }


        public override ILookUpObjectList GetReminders()
        {
            return reminderList_Renamed;
        }

        public override void InitLists()
        {
            list = new ListObjectList();
            list.Add(new ListObject(0, "Κενό", Color.Black));
            list.Add(new ListObject(1, "Σημαντικό", Color.Red));
            list.Add(new ListObject(2, "Επαγγελματικο", Color.Purple));
            list.Add(new ListObject(3, "Προσωπικό", Color.Tomato));
            list.Add(new ListObject(4, "Διακοπές", Color.Pink));
            list.Add(new ListObject(5, "Υποχρεωτικό", Color.YellowGreen));
            list.Add(new ListObject(6, "Άθληση", Color.Violet));
            list.Add(new ListObject(7, "Προετοιμασία", Color.Tomato));
            list.Add(new ListObject(8, "Εξετάσεις", Color.SpringGreen));

            list.Add(new ListObject(9, "Τηλεφώνημα", Color.RosyBrown));


            markerList_Renamed = new ListObjectList();
            markerList_Renamed.Add(new ListObject(0, "Ελέυθερο", Color.FromArgb(50, Color.Yellow))); // //same as noMarkColor
            markerList_Renamed.Add(new ListObject(1, "Ληξηπρόθεσμο", Color.YellowGreen));
            markerList_Renamed.Add(new ListObject(2, "Απασχολημένος", Color.Violet));
            markerList_Renamed.Add(new ListObject(3, "Εκτός Γραφείου", Color.Tomato));

            reminderList_Renamed = new ListObjectList();
            reminderList_Renamed.Add(new ListObject(0, "0 λεπτά", Color.Purple));
            reminderList_Renamed.Add(new ListObject(1, "5 λεπτά", Color.Purple));
            reminderList_Renamed.Add(new ListObject(2, "10 λεπτά", Color.Purple));
            reminderList_Renamed.Add(new ListObject(3, "15 λεπτά", Color.Purple));
            reminderList_Renamed.Add(new ListObject(4, "30 λεπτά", Color.Purple));
            reminderList_Renamed.Add(new ListObject(5, "1 ώρα", Color.Purple));
            reminderList_Renamed.Add(new ListObject(6, "2 ώρες", Color.Purple));
            reminderList_Renamed.Add(new ListObject(7, "3 ώρες", Color.Purple));
            reminderList_Renamed.Add(new ListObject(8, "4 ώρες", Color.Purple));
            reminderList_Renamed.Add(new ListObject(9, "5 ώρες", Color.Purple));
            reminderList_Renamed.Add(new ListObject(10, "6 ώρες", Color.Purple));
            reminderList_Renamed.Add(new ListObject(11, "7 ώρες", Color.Purple));
            reminderList_Renamed.Add(new ListObject(12, "8 ώρες", Color.Purple));
            reminderList_Renamed.Add(new ListObject(13, "9 ώρες", Color.Purple));
            reminderList_Renamed.Add(new ListObject(14, "10 ώρες", Color.Purple));
            reminderList_Renamed.Add(new ListObject(15, "11 ώρες", Color.Purple));
            reminderList_Renamed.Add(new ListObject(16, "12 ώρες", Color.Purple));
            reminderList_Renamed.Add(new ListObject(17, "18 ώρες", Color.Purple));

            locationList_Renamed = new ListObjectList();
            locationList_Renamed.Add(new ListObject(0, string.Empty, Color.Purple));
            locationList_Renamed.Add(new ListObject(1, "RoomB", Color.Red));
            locationList_Renamed.Add(new ListObject(2, "RoomC", Color.Purple));
            locationList_Renamed.Add(new ListObject(3, "RoomD", Color.RosyBrown));
            locationList_Renamed.Add(new ListObject(4, "RoomE", Color.PowderBlue));
        }

        /// <summary>
        /// Get or sets an IScheduleAppointmentList collection that holds the IScheduleAppointments. 
        /// </summary>
        public SimpleScheduleAppointmentList MasterList
        {
            get
            {
                return masterList_Renamed;
            }
            set
            {
                masterList_Renamed = value;
            }
        }

        #region random data

        /// <summary>
        /// A static method that provides random data, not really a part of the implementations.
        /// </summary>
        /// <returns>A SimpleScheduleAppointmentList object holding sample data.</returns>
        public static SimpleScheduleAppointmentList InitializeRandomData()
        {
            // int tc = Environment.TickCount;
            // int tc = 26260100;// simple spread 
            int tc = 28882701; // split the appointment across midnight & 3 items at 8am on 2 days ago

            Console.WriteLine("Random seed: {0}", tc);
            var r = new Random(tc);
            var r1 = new Random(tc);

            // set the number of sample items ou want in this list.
            // int count = r.Next(20) + 4;
            int count = 400; // 2000;//200;//30;

            // INSTANT VB NOTE: The local variable masterList was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
            var masterList_Renamed = new SimpleScheduleAppointmentList();
            var now = DateTime.Now.Date;

            int i = 0;
            // ORIGINAL LINE: for(int i = 0; i < count; i += 1)
            // INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
            while (i < count)
            {
                ScheduleAppointment item = (ScheduleAppointment)Interaction.IIf(masterList_Renamed.NewScheduleAppointment() is ScheduleAppointment, masterList_Renamed.NewScheduleAppointment(), null);




                int dayOffSet = 30 - r.Next(60);

                int hourOffSet = 24 - r.Next(48);

                int len = 30 * (r.Next(4) + 1);
                item.StartTime = now.AddDays(dayOffSet).AddHours(hourOffSet);

                item.EndTime = item.StartTime.AddMinutes(len);
                item.Subject = string.Format("subject{0}", i);
                item.Content = string.Format("content{0}", i);
                item.LabelValue = Conversions.ToInteger(Interaction.IIf(r1.Next(10) < 3, 0, r1.Next(10)));
                item.LocationValue = string.Format("location{0}", r1.Next(5));

                item.ReminderValue = Conversions.ToInteger(Interaction.IIf(r1.Next(10) < 5, 0, r1.Next(12)));
                item.Reminder = r1.Next(10) > 1;
                item.AllDay = r1.Next(10) < 1;


                item.MarkerValue = r1.Next(4);
                item.Dirty = false;
                masterList_Renamed.Add(item);
                i += 1;
            }

            // DisplayList("Before Sort", masterList);
            masterList_Renamed.SortStartTime();
            // DisplayList("After Sort", masterList);

            return masterList_Renamed;
        }

        private static void DisplayList(string title, ScheduleAppointmentList list)
        {
            /* TODO ERROR: Skipped IfDirectiveTrivia
            #If console Then
            *//* TODO ERROR: Skipped DisabledTextTrivia
                        Console.WriteLine("*************" & title)
                        For Each item As ScheduleAppointment In list
                            Console.WriteLine(item)
                        Next item
            *//* TODO ERROR: Skipped EndIfDirectiveTrivia
            #End If
            */
        }
        #endregion

        #region base class overrides

        /// <summary>
        /// Returns a the subset of MasterList between the 2 dates.
        /// </summary>
        /// <param name="startDate">Starting date limit for the returned items.</param>
        /// <param name="endDate">Ending date limit for the returned items.</param>
        /// <returns>Returns a the subset of MasterList.</returns>
        public override IScheduleAppointmentList GetSchedule(DateTime startDate, DateTime endDate)
        {
            var list = new ScheduleAppointmentList();
            var start = startDate.Date;
            // INSTANT VB NOTE: The local variable end was renamed since it is a keyword in VB:
            var end_Renamed = endDate.Date;
            foreach (ScheduleAppointment item in MasterList)
            {
                // item.EndTime.AddMinutes(-1) is to make sure an item that ends at 
                // midnight is not shown on the next days calendar

                if (item.StartTime.Date >= start && item.StartTime.Date <= end_Renamed || item.EndTime.AddMinutes(-1).Date > start && item.EndTime.Date <= end_Renamed)
                {
                    list.Add(item);
                }
            }
            list.SortStartTime();
            // DisplayList(string.Format("************dates between {0} and {1}", startDate, endDate), list);
            return list;
        }

        /// <summary>
        /// Returns a the subset of MasterList between the 2 dates.
        /// </summary>
        /// <param name="day">Date for the returned items.</param>
        /// <returns>Returns a the subset of MasterList.</returns>
        public override IScheduleAppointmentList GetScheduleForDay(DateTime day)
        {
            var list = new ScheduleAppointmentList();
            day = day.Date;
            foreach (ScheduleAppointment item in MasterList)
            {
                // do not want anything that ends at 12AM on the day
                if (item.StartTime.Date == day || item.EndTime.Date == day && item.EndTime > day)
                {
                    list.Add(item);
                }
            }

            // DisplayList(string.Format("*************day {0}", day), list);
            return list;
        }

        /// <summary>
        /// Saves the MasterList as a diskfile.
        /// </summary>
        public override void CommitChanges()
        {
            SaveBinary(FileName);
            IsDirty = false;
        }

        /// <summary>
        /// Gets or sets whether the MasterList has been modified.
        /// </summary>
        public override bool IsDirty
        {
            get
            {
                bool val = base.IsDirty;
                if (!val) // if no global setting marked list as dirty, check individual items
                {
                    foreach (ScheduleAppointment item in MasterList)
                    {
                        if (item.Dirty)
                        {
                            val = true;
                            break;
                        }
                    }
                }
                return val;
            }
            set
            {
                base.IsDirty = value;
            }
        }


        /// <summary>
        /// Saves the current <see cref="MasterList"/> object in binary format to a file 
        /// with the specified filename.
        /// </summary>
        // INSTANT VB NOTE: The parameter fileName was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        public void SaveBinary(string fileName_Renamed)
        {
            Stream s = File.Create(fileName_Renamed);
            SaveBinary(s);
            s.Close();
        }

        /// <summary>
        /// Saves the current <see cref="MasterList"/> object to a stream in binary format.
        /// </summary>
        public void SaveBinary(Stream s)
        {
            var b = new BinaryFormatter();
            b.AssemblyFormat = FormatterAssemblyStyle.Simple;
            b.Serialize(s, MasterList);
        }


        /// <summary>
        /// Creates an instance of <see cref="SimpleScheduleDataProvider"/> and loads 
        /// a previously serialized MasterList into the instance.
        /// </summary>
        /// <param name="fileName">The serialized filename.</param>
        /// <returns>A SimpleScheduleDataProvider.</returns>
        /// <remarks>
        /// This method uses <see cref="AppDomain.CurrentDomain.AssemblyResolve"/> to 
        /// avoid versioning issues with the binary serialization of the MasterList.
        /// </remarks>
        // INSTANT VB NOTE: The parameter fileName was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        public static SimpleScheduleDataProvider LoadBinary(string fileName_Renamed)
        {
            var t = new SimpleScheduleDataProvider();
            Stream s = File.OpenRead(fileName_Renamed);
            try
            {
                AppDomain.CurrentDomain.AssemblyResolve += Syncfusion.ScheduleWindowsAssembly.AssemblyResolver;
                var b = new BinaryFormatter();
                b.AssemblyFormat = FormatterAssemblyStyle.Simple;
                var obj = b.Deserialize(s);
                t.MasterList = (SimpleScheduleAppointmentList)Interaction.IIf(obj is SimpleScheduleAppointmentList, obj, null);
            }

            finally
            {
                s.Close();
                AppDomain.CurrentDomain.AssemblyResolve -= Syncfusion.ScheduleWindowsAssembly.AssemblyResolver;
            }
            return t;
        }

        /// <summary>
        /// Overridden to return a <see cref="SimpleScheduleAppointment"/>.
        /// </summary>
        /// <returns></returns>
        public override IScheduleAppointment NewScheduleAppointment()
        {
            return new SimpleScheduleAppointment();
        }

        /// <summary>
        /// Overridden to add the item to the MasterList.
        /// </summary>
        /// <param name="item">IScheduleAppointment item to be added.</param>
        public override void AddItem(IScheduleAppointment item)
        {
            MasterList.Add(item);
        }

        /// <summary>
        /// Overridden to remove the item from the MasterList.
        /// </summary>
        /// <param name="item">IScheduleAppointment item to be removed.</param>
        public override void RemoveItem(IScheduleAppointment item)
        {
            MasterList.Remove(item);
        }
        #endregion
    }

    /// <summary>
    /// Derives <see cref="ScheduleAppointmentList"/> to implement IScheduleAppointmentList.
    /// </summary>
    [Serializable()]
    public class SimpleScheduleAppointmentList : ScheduleAppointmentList, ISerializable
    {
        #region ISerializable Members

        #region ISerializable Members

        /// <summary>
        /// Used in serialization.
        /// </summary>
        /// <param name="info"> The SerializationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // GetObjectDatae(info, context)
            info.AddValue("List", List);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) => GetObjectData(info, context);

        #endregion


        /// <summary>
        /// Override to control serialization.
        /// </summary>
        /// <param name="info"> The SerializationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        // Protected Overridable Sub GetObjectDatae(ByVal info As SerializationInfo, ByVal context As StreamingContext) 'Implements ISerializable.GetObjectData
        // info.AddValue("List", Me.List)
        // End Sub


        #endregion

        /// <summary>
        /// Used in serialization.
        /// </summary>
        /// <param name="info"> The SerializationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        protected SimpleScheduleAppointmentList(SerializationInfo info, StreamingContext context)
        {
            List = (ArrayList)info.GetValue("List", typeof(ArrayList));
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SimpleScheduleAppointmentList() : base()
        {

        }

        /// <summary>
        /// Overridden to return a <see cref="SimpleScheduleAppointment"/>.
        /// </summary>
        /// <returns>A SimpleScheduleAppointment.</returns>
        public override IScheduleAppointment NewScheduleAppointment()
        {
            return new SimpleScheduleAppointment();
        }


    }

    /// <summary>
    /// Derives <see cref="ScheduleAppointment"/> to implement IScheduleAppointment.
    /// </summary>
    [Serializable()]
    public class SimpleScheduleAppointment : ScheduleAppointment, ISerializable
    {
        #region ISerializable Members

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SimpleScheduleAppointment() : base()
        {
        }

        /// <summary>
        /// Overridden to handle serilaization.
        /// </summary>
        /// <param name="info">The SerialazationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        protected SimpleScheduleAppointment(SerializationInfo info, StreamingContext context)
        {
            UniqueID = Conversions.ToInteger(info.GetValue("UniqueID", typeof(int)));
            Subject = Conversions.ToString(info.GetValue("Subject", typeof(string)));
            StartTime = Conversions.ToDate(info.GetValue("StartTime", typeof(DateTime)));
            ReminderValue = Conversions.ToInteger(info.GetValue("ReminderValue", typeof(int)));
            Reminder = Conversions.ToBoolean(info.GetValue("Reminder", typeof(bool)));
            Owner = Conversions.ToInteger(info.GetValue("Owner", typeof(int)));
            MarkerValue = Conversions.ToInteger(info.GetValue("MarkerValue", typeof(int)));
            LocationValue = Conversions.ToString(info.GetValue("LocationValue", typeof(string)));
            LabelValue = Conversions.ToInteger(info.GetValue("LabelValue", typeof(int)));
            EndTime = Conversions.ToDate(info.GetValue("EndTime", typeof(DateTime)));
            Content = Conversions.ToString(info.GetValue("Content", typeof(string)));
            AllDay = Conversions.ToBoolean(info.GetValue("AllDay", typeof(bool)));

            Dirty = false;
        }

        /// <summary>
        /// Handle serilaization.
        /// </summary>
        /// <param name="info">The SerialazationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("UniqueID", UniqueID);
            info.AddValue("Subject", Subject);
            info.AddValue("StartTime", StartTime);
            info.AddValue("ReminderValue", ReminderValue);
            info.AddValue("Reminder", Reminder);
            info.AddValue("Owner", Owner);
            info.AddValue("MarkerValue", MarkerValue);
            info.AddValue("LocationValue", LocationValue);
            info.AddValue("LabelValue", LabelValue);
            info.AddValue("EndTime", EndTime);
            info.AddValue("Content", Content);
            info.AddValue("AllDay", AllDay);

            // info.AddValue("Tag", this.Tag); assume Tag not serializable in this implemetation
        }

        #endregion

    }


    #endregion

}