using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Management;
using System.Security.Cryptography.X509Certificates;

namespace TaskManager
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        List<Process> processes;
        //Process[] a_processes;
        Dictionary<int, Process> d_processes;
        int ramFactor = 1024;
        public MainForm()
        {
            InitializeComponent();

            listViewProcesses.Columns.Add("PID");
            listViewProcesses.Columns.Add("Name");
            listViewProcesses.Columns.Add("WorkingSet");
            listViewProcesses.Columns.Add("PrivateSet");
            processes = Process.GetProcesses().OfType<Process>().ToList();
            LoadProcesses();
            RemoveClosedProcesses();

            //AllocConsole();
            //Console.WriteLine("Debug");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!processes.SequenceEqual(Process.GetProcesses().OfType<Process>().ToList()))
                UpdateListView();

            this.processes = Process.GetProcesses().OfType<Process>().ToList();
            statusStrip.Items["toolStripStatusLabelProcesses"].Text = $"Total processes: {processes.Count}, displayed processes {listViewProcesses.Items.Count}";

            float fcpu = performanceCounterCPU.NextValue();
            float fram = performanceCounterRAM.NextValue();
            metroProgressBarCPU.Value = (int)fcpu;
            metroProgressBarRAM.Value = (int)fram;
            lblCPU.Text = string.Format("{0:0.00}%", fcpu);
            lblRAM.Text = string.Format("{0:0.00}%", fram);
            chart.Series["CPU"].Points.AddY(fcpu);
            chart.Series["RAM"].Points.AddY(fram);
            if (chart.Series["CPU"].Points.Count > 50)
            {
                chart.Series["CPU"].Points.RemoveAt(0);
                chart.Series["RAM"].Points.RemoveAt(0);
                chart.ChartAreas[0].AxisX.Minimum = double.NaN;
                chart.ChartAreas[0].AxisX.Maximum = double.NaN;
                chart.ChartAreas[0].RecalculateAxesScale();
            }
        }
        void LoadProcesses()
        {
            listViewProcesses.Items.Clear();

            Dictionary<int, Process> d_processes = Process.GetProcesses().ToDictionary(key => key.Id, process => process);
            this.d_processes = d_processes;
            for (int i = 0; i < d_processes.Count; i++)
            {
                KeyValuePair<int, Process> pair = d_processes.ElementAt(i);
                listViewProcesses.Items.Add(pair.Key.ToString());
                listViewProcesses.Items[i].SubItems.Add(pair.Value.ProcessName);
                listViewProcesses.Items[i].SubItems.Add((pair.Value.WorkingSet64 / ramFactor).ToString());
                listViewProcesses.Items[i].SubItems.Add((pair.Value.PrivateMemorySize64 / ramFactor).ToString());
            }
        }
        void UpdateListView()
        {
            Dictionary<int, Process> d_processes = Process.GetProcesses().ToDictionary(key => key.Id, process => process);
            if (this.d_processes.SequenceEqual(d_processes)) return;
            //if (processes.SequenceEqual(Process.GetProcesses().OfType<Process>().ToList())) return;
            //this.processes = Process.GetProcesses().OfType<Process>().ToList();
            this.d_processes = d_processes;

            listViewProcesses.BeginUpdate();
            RemoveClosedProcesses();
            AddNewProcesses();
            UpdateExistingProcesses();
            listViewProcesses.EndUpdate();
            //Dictionary
        }
        void RemoveClosedProcesses()
        {
            //AllocConsole();
            for (int i = 0; i < listViewProcesses.Items.Count; i++)
            {
                //Console.Clear();
                string item_name = listViewProcesses.Items[i].Name;
                Console.WriteLine(item_name);
                Console.Write(Convert.ToInt32(listViewProcesses.Items[i].Text) + "\t");
                if (!d_processes.ContainsKey(Convert.ToInt32(listViewProcesses.Items[i].Text)))
                {
                    listViewProcesses.Items.RemoveAt(i);
                }
            }
        }
        void AddNewProcesses()
        {
            //AllocConsole();
            //Console.WriteLine();
            //Console.Clear();
            for (int i = 0; i < d_processes.Count; i++)
            {
                KeyValuePair<int, Process> pair = d_processes.ElementAt(i);
                if (listViewProcesses.FindItemWithText(pair.Key.ToString()) == null)
                {
                    ListViewItem item = new ListViewItem(pair.Key.ToString());
                    item.SubItems.Add(pair.Value.ProcessName);
                    item.SubItems.Add((pair.Value.WorkingSet64 / ramFactor).ToString());
                    item.SubItems.Add((pair.Value.PrivateMemorySize64 / ramFactor).ToString());

                    listViewProcesses.Items.Add(item);
                    //Console.Write(pair.Key + "\t");
                }
            }

            //foreach (ListViewItem i in listViewProcesses.Items)
            //{
            //	Console.Write(i.Text);
            //}
        }
        void UpdateExistingProcesses()
        {
            for (int i = 0; i < listViewProcesses.Items.Count; i++)
            {
                //Console.Write($"{listViewProcesses.Items[i].Text}\t");
                int PID = Convert.ToInt32(listViewProcesses.Items[i].Text);
                long workingSet = d_processes[PID].WorkingSet64 / ramFactor;
                long privateSet = d_processes[PID].PrivateMemorySize64 / ramFactor;
                listViewProcesses.Items[i].SubItems[2].Text = workingSet.ToString();
                listViewProcesses.Items[i].SubItems[3].Text = privateSet.ToString();
            }
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

        private void buttonSystemInformation_Click(object sender, EventArgs e)
        {
            SystemInfoBrowserForm sysinfo = new SystemInfoBrowserForm();
            sysinfo.ShowDialog();
        }

        private void buttonCPU_Click(object sender, EventArgs e)
        {
            SelectQuery sq = new SelectQuery("Win32_Processor");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            StringBuilder sb = new StringBuilder();
            foreach (ManagementObject mo in osDetailsCollection)
            {
                sb.AppendLine(string.Format("Name : {0}", (string)mo["Name"]));
                sb.AppendLine(string.Format("AddressWidth: {0}", (ushort)mo["AddressWidth"]));
                sb.AppendLine(string.Format("CreationClassName : {0}", (string)mo["CreationClassName"]));
                sb.AppendLine(string.Format("CurrentClockSpeed : {0}", mo["CurrentClockSpeed"]).ToString());
                sb.AppendLine(string.Format("CurrentVoltage : {0}", (ushort)mo["CurrentVoltage"]));
                sb.AppendLine(string.Format("DataWidth : {0}", (ushort)mo["DataWidth"]));
                sb.AppendLine(string.Format("Description: {0}", (string)mo["Description"]));
                sb.AppendLine(string.Format("DeviceID : {0}", (string)mo["DeviceID"]));
                sb.AppendLine(string.Format("L2CacheSize : {0}", mo["L2CacheSize"]).ToString());
                sb.AppendLine(string.Format("L3CacheSize : {0}", mo["L3CacheSize"]).ToString());
                sb.AppendLine(string.Format("Manufacturer: {0}", (string)mo["Manufacturer"]));
                sb.AppendLine(string.Format("MaxClockSpeed : {0}", mo["MaxClockSpeed"]).ToString());
                sb.AppendLine(string.Format("NumberOfCores : {0}", mo["NumberOfCores"]).ToString());
                sb.AppendLine(string.Format("NumberOfLogicalProcessors : {0}", mo["NumberOfLogicalProcessors"]).ToString());
                sb.AppendLine(string.Format("PowerManagementSupported : {0}", mo["PowerManagementSupported"].ToString()));
                sb.AppendLine(string.Format("ProcessorId: {0}", (string)mo["ProcessorId"]));
                sb.AppendLine(string.Format("Revision: {0}", (ushort)mo["Revision"]));
                sb.AppendLine(string.Format("Role: {0}", (string)mo["Role"]));
                sb.AppendLine(string.Format("SocketDesignation : {0}", mo["SocketDesignation"]).ToString());
                sb.AppendLine(string.Format("Status : {0}", (string)mo["Status"]));
                sb.AppendLine(string.Format("SystemCreationClassName : {0}", (string)mo["SystemCreationClassName"]));
                sb.AppendLine(string.Format("SystemName: {0}", (string)mo["SystemName"]));
            }
            richTextBox.Text = sb.ToString();
        }
        private void buttonRAM_Click(object sender, EventArgs e)
        {
            SelectQuery sq = new SelectQuery("Win32_PhysicalMemory");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            StringBuilder sb = new StringBuilder();
            foreach (ManagementObject mo in osDetailsCollection)
            {
                sb.AppendLine(string.Format("Manufacturer: {0}", (string)mo["Manufacturer"]));
                sb.AppendLine(string.Format("Capacity: {0} GB", Convert.ToUInt64(mo["Capacity"]) / 1073741824));
                sb.AppendLine(string.Format("MemoryType: {0}", (ushort)mo["MemoryType"]));
                sb.AppendLine(string.Format("Description: {0}", (string)mo["Description"]));
                sb.AppendLine(string.Format("SerialNumber: {0}", (string)mo["SerialNumber"]));
                sb.AppendLine(string.Format("DeviceLocator: {0}", (string)mo["DeviceLocator"]));
                sb.AppendLine(string.Format("ConfiguredClockSpeed: {0}", mo["ConfiguredClockSpeed"]));
                sb.AppendLine(string.Format("DataWidth: {0}", (ushort)mo["DataWidth"]));
                sb.AppendLine(string.Format("FormFactor: {0}", (ushort)mo["FormFactor"]));
                sb.AppendLine(string.Format("CreationClassName: {0}", (string)mo["CreationClassName"]));
                sb.AppendLine(string.Format("SMBIOSMemoryType: {0}", mo["SMBIOSMemoryType"]));
                sb.AppendLine(string.Format("BankLabel: {0}", (string)mo["BankLabel"]));

            }
            richTextBox.Text = sb.ToString();
        }
    }
}
