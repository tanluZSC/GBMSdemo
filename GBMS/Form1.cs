using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using GBMSAPI_NET.GBMSAPI_NET_Defines.GBMSAPI_NET_AcquisitionProcessDefines;
using GBMSAPI_NET.GBMSAPI_NET_Defines.GBMSAPI_NET_DeviceCharacteristicsDefines;
using GBMSAPI_NET.GBMSAPI_NET_Defines.GBMSAPI_NET_ErrorCodesDefines;
using GBMSAPI_NET.GBMSAPI_NET_Defines.GBMSAPI_NET_VisualInterfaceLCDDefines;
using GBMSAPI_NET.GBMSAPI_NET_LibraryFunctions;

using GBMS.UTILITY;


namespace GBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool GetOptionMask(out uint OptionMask, out uint FrameRateOptions)
        {
            OptionMask = 0;
            FrameRateOptions = 0;
            // Auto-Capture
    
                (OptionMask) |= GBMSAPI_NET_AcquisitionOptions.GBMSAPI_NET_AO_AUTOCAPTURE;
            

            

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        [DllImport("DSBeep.dll", EntryPoint = "DSInit")]
        public static extern bool DSInit(uint CoInit, bool ForceDS);

        public const uint COINIT_APARTMENTTHREADED = (uint)(0x02);

        public Boolean GetAcquisitionOptions(
        out uint ObjToScan,
        out uint OptionMask,
        out uint DisplayOptionMask,
        out Byte ContrastLimitToDisplay,
        out Byte CompletenessLimitToDisplay,
        out uint ClipRegionW,
        out uint ClipRegionH,
        out uint RollPreviewTimeout,
        out Byte ArtefactCleaningDepth,
        out Byte ContrastIntermediateLimitToDisplay,
        out Byte CompletenessIntermediateLimitToDisplay,        
        out bool RollAreaStandardGa,      
        out bool EnableRollCompositionBlock,
        out int HwFfdStrictnessThreshold,
        out int SwFfdStrictnessThreshold)    
        {
            ObjToScan = 0;
            OptionMask = 0;
            DisplayOptionMask = 0;
            ContrastLimitToDisplay = 0;
            CompletenessLimitToDisplay = 0;
            ClipRegionW = 0;
            ClipRegionH = 0;
            RollPreviewTimeout = 0;
            ArtefactCleaningDepth = 0;
            ContrastIntermediateLimitToDisplay = 0;
            CompletenessIntermediateLimitToDisplay = 0;
            RollAreaStandardGa = false;           
            EnableRollCompositionBlock = false;            
            HwFfdStrictnessThreshold = -1;
            SwFfdStrictnessThreshold = -1;            
           
                //滚指的GA标准有效化                          
                RollAreaStandardGa = true;
                
               
                // end ver 2.10.0.0
                /////////////////////////////
                // GET OBJECT TO SCAN
                /////////////////////////////
                String ObjToScanName = (String)(this.ObjectToScanComboBox.SelectedItem);
                ObjToScan = GBMSAPI_Example_Util.GetObjectToScanIDFromName(ObjToScanName);

              
                RollPreviewTimeout = 0;

            return false;
        }


    private void Form1_Load(object sender, EventArgs e)
        {
            //UpdateListButton_Click(null, null);
        }

        private void getDevice_Click(object sender, EventArgs e)
        {

        }

        private void UpdateListButton_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            try
            {
                this.DeviceTypeComboBox.Items.Clear();
                ////////////////////////////////
                ///// 获取设备列表存到数组中，最多存储127个设备。GBMSAPI_NET_MAX_PLUGGED_DEVICE_NUM=127常量
                ////////////////////////////////
                GBMSAPI_NET_DeviceInfoStruct[] AttachedDeviceList = new GBMSAPI_NET_DeviceInfoStruct[
                    GBMSAPI_NET_DeviceInfoConstants.GBMSAPI_NET_MAX_PLUGGED_DEVICE_NUM];
                 Console.WriteLine(GBMSAPI_NET_DeviceInfoConstants.GBMSAPI_NET_MAX_PLUGGED_DEVICE_NUM);
                for (int i = 0; i < GBMSAPI_NET_DeviceInfoConstants.GBMSAPI_NET_MAX_PLUGGED_DEVICE_NUM; i++)
                {
                    AttachedDeviceList[i] = new GBMSAPI_NET_DeviceInfoStruct();
                }

                int AttachedDeviceNumber;
                uint USBErrorCode;

                 int RetVal = GBMSAPI_NET_DeviceSettingRoutines.GBMSAPI_NET_GetAttachedDeviceList(
                     AttachedDeviceList, out AttachedDeviceNumber, out USBErrorCode);
                Console.WriteLine(AttachedDeviceNumber);
                if (RetVal != GBMSAPI_NET_ErrorCodes.GBMSAPI_NET_ERROR_CODE_NO_ERROR || AttachedDeviceNumber <= 0)
                {
                    if (RetVal != GBMSAPI_NET_ErrorCodes.GBMSAPI_NET_ERROR_CODE_NO_ERROR)
                    {
                        GBMSAPI_Example_Util.GBMSAPI_Example_ManageErrors(RetVal, USBErrorCode, "UpdateListButton_Click");
                        MessageBox.Show("Error in GBMSAPI_NET_GetAttachedDeviceList function: " + RetVal);
                    }
                    return;
                }
                // Console.WriteLine(RetVal);
                ////////////////////////////////
                //// Store device list 存储设备列表
                ////////////////////////////////
                for (int i = 0; i < AttachedDeviceNumber; i++)
                {
                    String StrToAdd = GBMSAPI_Example_Util.GBMSAPI_Example_GetDevNameFromDevID(
                        AttachedDeviceList[i].DeviceID);
                    StrToAdd += " " + (AttachedDeviceList[i].DeviceSerialNumber);//获取设备型号
                    this.DeviceTypeComboBox.Items.Add(StrToAdd);
                }
                if (AttachedDeviceNumber > 0)
                {
                    this.DeviceTypeComboBox.SelectedIndex = 0;//指定索引号为0
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in UpdateListButton_Click function: " + ex.Message);
                this.Close();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                this.Enabled = true;
            }
        }
    }
}

