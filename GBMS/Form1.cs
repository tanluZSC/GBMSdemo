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



namespace GBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            GBMSAPI_NET_DeviceInfoStruct[] AttachedDeviceList = new GBMSAPI_NET_DeviceInfoStruct[
                 GBMSAPI_NET_DeviceInfoConstants.GBMSAPI_NET_MAX_PLUGGED_DEVICE_NUM];
            for (int i = 0; i < GBMSAPI_NET_DeviceInfoConstants.GBMSAPI_NET_MAX_PLUGGED_DEVICE_NUM; i++)
            {
                AttachedDeviceList[i] = new GBMSAPI_NET_DeviceInfoStruct();
            }

            int AttachedDeviceNumber;
            uint USBErrorCode;

            int RetVal = GBMSAPI_NET_DeviceSettingRoutines.GBMSAPI_NET_GetAttachedDeviceList(
                AttachedDeviceList, out AttachedDeviceNumber, out USBErrorCode);
           
            //if (RetVal != GBMSAPI_NET_ErrorCodes.GBMSAPI_NET_ERROR_CODE_NO_ERROR || AttachedDeviceNumber <= 0)
            //{
            //    if (RetVal != GBMSAPI_NET_ErrorCodes.GBMSAPI_NET_ERROR_CODE_NO_ERROR)
            //    {
            //       // GBMSAPI_Example_Util.GBMSAPI_Example_ManageErrors(RetVal, USBErrorCode, "UpdateListButton_Click");
            //        MessageBox.Show("Error in GBMSAPI_NET_GetAttachedDeviceList function: " + RetVal);
            //    }
            //    return;
            //}

            

            Byte VersionField1, VersionField2, VersionField3, VersionField4;
            GBMSAPI_NET_AuxiliaryRoutines.GBMSAPI_NET_GetMultiScanAPIVersion(
                out VersionField1, out VersionField2, out VersionField3, out VersionField4
                ); 
                            
            label1.Text = "" + VersionField1 + "." + VersionField2 + "." + VersionField3 + "." + VersionField4;//GBMS版本号4.1.0.0
            uint ObjType = GBMSAPI_NET_ScanObjectsUtilities.GBMSAPI_NET_GetTypeFromObject(0);
            label1.Text = ObjType.ToString();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

