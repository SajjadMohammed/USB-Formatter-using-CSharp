using System;
using System.Windows.Forms;

using System.IO;
using System.Management;

namespace USB_Formatting
{
    public partial class Form1 : Form
    {

        private DriveInfo[] _driveInfo;
        private string _driveLetter, _fileSystem;
        private bool _quickFormatSpeed;
      
        public Form1()
        {
            InitializeComponent();
        }

        private bool FormatDrive(string driveLetter, string fileSystem, bool quickFormatSpeed = true,
            int clusterSize = 8192, string label = "", bool doCompression = false)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"select * from Win32_Volume WHERE DriveLetter = '" + driveLetter + "'");
                foreach (ManagementObject format in searcher.Get())
                {
                    format.InvokeMethod("Format", new object[] { fileSystem, quickFormatSpeed, clusterSize, label, doCompression });
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void GetDriveInfo()
        {
            _driveInfo = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in _driveInfo)
            {
                if (driveInfo.IsReady)
                {
                    if (driveInfo.DriveType == DriveType.Removable)
                        USBPath.Items.Add(driveInfo.Name.Remove(2));
                }
            }
        }

        private void FormatButton(object sender, EventArgs e)
        {
            if (NTFS.Checked)
            {
                _fileSystem = "NTFS";
            }

            if (FAT32.Checked)
            {
                _fileSystem = "FAT32";
            }

            if (Quick_rbtn.Checked)
            {
                _quickFormatSpeed = true;
            }

            if (Normal_rbtn.Checked)
            {
                _quickFormatSpeed = false;
            }

            label8.Text = "......رجاءا انتظر";
            if (FormatDrive(_driveLetter, _fileSystem, _quickFormatSpeed))
                label8.Text = "عملية التهيئة تمت بنجاح";
            else
                label8.Text = "هنالك خطأ في عملية تهيئة القرص ,أعد المحاولة";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDriveInfo();
        }

        private void USBPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DriveInfo dinfo in _driveInfo)
            {
                if (dinfo.IsReady)
                {
                    if (USBPath.Text == dinfo.Name.Remove(2))
                    {
                        TotalSpace.Text = (dinfo.TotalSize / (1024 * 1024)).ToString() + " MB";
                        FreeSpace.Text = (dinfo.TotalFreeSpace / (1024 * 1024)).ToString() + " MB";
                        FormatType.Text = dinfo.DriveFormat;
                    }
                }
            }
            _driveLetter = USBPath.Text;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            USBPath.Items.Clear();
            GetDriveInfo();
        }
    }
}