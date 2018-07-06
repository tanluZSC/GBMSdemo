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

            GBMSAPI_Example_Globals.InitGlobalAcqOptions();
            Boolean res = this.GetAcquisitionOptions(
               out GBMSAPI_Example_Globals.ObjToScan,
               out GBMSAPI_Example_Globals.OptionMask,
               out GBMSAPI_Example_Globals.DisplayOptionMask,
               out GBMSAPI_Example_Globals.ContrastLimitToDisplay,
               out GBMSAPI_Example_Globals.CompletenessLimitToDisplay,
               out GBMSAPI_Example_Globals.ClipRegionW,
               out GBMSAPI_Example_Globals.ClipRegionH,
               out GBMSAPI_Example_Globals.RollPreviewTimeout,
               out GBMSAPI_Example_Globals.ArtefactCleaningDepth,
               out GBMSAPI_Example_Globals.ContrastIntermediateLimitToDisplay,
               out GBMSAPI_Example_Globals.CompletenessIntermediateLimitToDisplay,
               out GBMSAPI_Example_Globals.IsRollAreaStandardGa,
               // ver 3.2.0.0
               out GBMSAPI_Example_Globals.RollBlockCompositionIsEnabled,
               // end ver 3.2.0.0
               // ver 4.0.0.0
               out GBMSAPI_Example_Globals.HwFfdThresholdToBeSet,
               out GBMSAPI_Example_Globals.SwFfdThresholdToBeSet
               // ver 4.0.0.0
               );
            //初始化
            DSInit(COINIT_APARTMENTTHREADED, false);

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
        // ver 2.10.0.0
        out bool RollAreaStandardGa,
        // end ver 2.10.0.0
        // ver 3.2.0.0
        out bool EnableRollCompositionBlock,
        // end ver 3.2.0.0
        // ver 4.0.0.0
        out int HwFfdStrictnessThreshold,
        out int SwFfdStrictnessThreshold)
        // end ver 4.0.0.0
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
            // ver 3.2.0.0
            EnableRollCompositionBlock = false;
            // end ver 3.2.0.0
            // ver 4.0.0.0
            HwFfdStrictnessThreshold = -1;
            SwFfdStrictnessThreshold = -1;
            // end ver 4.0.0.0

            try
            {
                // ver 2.10.0.0
                /////////////////////////////
                // ROLL AREA STANDARD
                /////////////////////////////
              
                    RollAreaStandardGa = true;
                
               
                // end ver 2.10.0.0
                /////////////////////////////
                // GET OBJECT TO SCAN
                /////////////////////////////
                String ObjToScanName = (String)(this.ObjectToScanComboBox.SelectedItem);
                ObjToScan = GBMSAPI_Example_Util.GetObjectToScanIDFromName(ObjToScanName);

                /////////////////////////////
                // GET OPTION MASK
                /////////////////////////////
                uint dummyFrOpt;
                GetOptionMask(out OptionMask, out dummyFrOpt);

                /////////////////////////////////////
                // GET DISPLAY OPTION MASK
                /////////////////////////////////////
                DisplayOptionMask = 0;

                uint ExternalDevicesMask;
                int RetVal = GBMSAPI_NET_DeviceCharacteristicsRoutines.GBMSAPI_NET_GetOptionalExternalEquipment(out ExternalDevicesMask);

                if (RetVal != GBMSAPI_NET_ErrorCodes.GBMSAPI_NET_ERROR_CODE_NO_ERROR)
                {
                    GBMSAPI_Example_Util.GBMSAPI_Example_ManageErrors(
                        RetVal, "GetAcquisitionOptions,GBMSAPI_NET_GetOptionalExternalEquipment");
                    return false;
                }

                if ((ExternalDevicesMask & GBMSAPI_NET_OptionalExternalEquipment.GBMSAPI_NET_OED_VUI_LCD) != 0)
                {
                    // Stop screen after acquisition
                   
                        (DisplayOptionMask) |= GBMSAPI_NET_DisplayOptions.GBMSAPI_NET_DO_FINAL_SCREEN;                    
                    // customized contrast
                    
                        // read limit value
                     
                            Byte ContrastLimit = Byte.Parse(this.label1.Text);
                            ContrastLimitToDisplay = ContrastLimit;                                                                       
                            (DisplayOptionMask) |= GBMSAPI_NET_DisplayOptions.GBMSAPI_NET_DO_CUSTOMIZED_CONTRAST;
                    }

                    // customized completeness
                    if (this.ShowCustomizedCompletenessCheckBox.Enabled == true && this.ShowCustomizedCompletenessCheckBox.Checked == true)
                    {
                        // read limit value
                        try
                        {
                            Byte CompletenessLimit = Byte.Parse(this.CompletenessLimitTextBox.Text);
                            CompletenessLimitToDisplay = CompletenessLimit;
                        }
                        catch (Exception ReadEx)
                        {
                            if ((ReadEx.GetType()).ToString() == ((new ArgumentNullException()).GetType()).ToString() ||
                                (ReadEx.GetType()).ToString() == ((new FormatException()).GetType()).ToString() ||
                                (ReadEx.GetType()).ToString() == ((new OverflowException()).GetType()).ToString()
                                )
                            {
                                // default value
                                CompletenessLimitToDisplay = 90;
                            }
                            else
                            {
                                MessageBox.Show("Exception in GetAcquisitionOptions: " + ReadEx.Message);
                                ObjToScan = 0;
                                OptionMask = 0;
                                DisplayOptionMask = 0;
                                ContrastLimitToDisplay = 0;
                                CompletenessLimitToDisplay = 0;
                                ClipRegionW = 0;
                                ClipRegionH = 0;
                                RollPreviewTimeout = 0;
                                ArtefactCleaningDepth = 0;
                                return false;
                            }
                        }
                        (DisplayOptionMask) |= GBMSAPI_NET_DisplayOptions.GBMSAPI_NET_DO_CUSTOMIZED_COMPLETENESS;
                    }
                }
                #region 获取裁剪数据
                ///////////////////////////////////////
                // GET CLIP DATA
                ///////////////////////////////////////
                ClipRegionW = 0;
                ClipRegionH = 0;
                if (this.ClipEnableCheckBox.Enabled == true &&
                    this.ClipEnableCheckBox.Checked == true)
                {
                    // read clip values
                    try
                    {
                        UInt32 ClipSizeX = UInt32.Parse(this.ClipRegionSizeXTextBox.Text);
                        UInt32 ClipSizeY = UInt32.Parse(this.ClipRegionSizeYTextBox.Text);
                        ClipRegionW = ClipSizeX;
                        ClipRegionH = ClipSizeY;
                    }
                    catch (Exception ReadEx)
                    {
                        if ((ReadEx.GetType()).ToString() == ((new ArgumentNullException()).GetType()).ToString() ||
                            (ReadEx.GetType()).ToString() == ((new FormatException()).GetType()).ToString() ||
                            (ReadEx.GetType()).ToString() == ((new OverflowException()).GetType()).ToString()
                            )
                        {
                            // default value
                            ClipRegionW = 0;
                            ClipRegionH = 0;
                        }
                        else
                        {
                            MessageBox.Show("Exception in GetAcquisitionOptions: " + ReadEx.Message);
                            ObjToScan = 0;
                            OptionMask = 0;
                            DisplayOptionMask = 0;
                            ContrastLimitToDisplay = 0;
                            CompletenessLimitToDisplay = 0;
                            ClipRegionW = 0;
                            ClipRegionH = 0;
                            RollPreviewTimeout = 0;
                            ArtefactCleaningDepth = 0;
                            return false;
                        }
                    }
                }
                #endregion
                ///////////////////////////////////////////
                // GET ROLL OPTIONS
                ///////////////////////////////////////////
                // Roll Preview Timeout
                RollPreviewTimeout = 0;
                if (this.AutomaticRollPreviewTimeoutTextBox.Enabled == true)
                {
                    // read timeout
                    try
                    {
                        UInt32 Timeout = UInt32.Parse(this.AutomaticRollPreviewTimeoutTextBox.Text);
                        RollPreviewTimeout = Timeout;
                    }
                    catch (Exception ReadEx)
                    {
                        if ((ReadEx.GetType()).ToString() == ((new ArgumentNullException()).GetType()).ToString() ||
                            (ReadEx.GetType()).ToString() == ((new FormatException()).GetType()).ToString() ||
                            (ReadEx.GetType()).ToString() == ((new OverflowException()).GetType()).ToString()
                            )
                        {
                            // default value
                            RollPreviewTimeout = 0;
                        }
                        else
                        {
                            MessageBox.Show("Exception in GetAcquisitionOptions: " + ReadEx.Message);
                            ObjToScan = 0;
                            OptionMask = 0;
                            DisplayOptionMask = 0;
                            ContrastLimitToDisplay = 0;
                            CompletenessLimitToDisplay = 0;
                            ClipRegionW = 0;
                            ClipRegionH = 0;
                            RollPreviewTimeout = 0;
                            ArtefactCleaningDepth = 0;
                            return false;
                        }
                    }
                }
                // Artefact Cleaning Depth
                ArtefactCleaningDepth = 0;
                if (this.ArtefactCleaningDepthTextBox.Enabled == true)
                {
                    // read Clean Depth
                    try
                    {
                        Byte CleanDepth = Byte.Parse(this.ArtefactCleaningDepthTextBox.Text);
                        if (CleanDepth > GBMSAPI_NET_CleaningDepth.GBMSAPI_NET_ARTEFACT_CLEANING_DEPTH_MAX &&
                            CleanDepth != GBMSAPI_NET_CleaningDepth.GBMSAPI_NET_ARTEFACT_CLEANING_DEPTH_UNLIMITED)
                        {
                            MessageBox.Show("Clean depth greater than maximum allowed value; will be automatically set to max", "Warning");
                            CleanDepth = GBMSAPI_NET_CleaningDepth.GBMSAPI_NET_ARTEFACT_CLEANING_DEPTH_MAX;
                        }
                        ArtefactCleaningDepth = CleanDepth;
                    }
                    catch (Exception ReadEx)
                    {
                        if ((ReadEx.GetType()).ToString() == ((new ArgumentNullException()).GetType()).ToString() ||
                            (ReadEx.GetType()).ToString() == ((new FormatException()).GetType()).ToString() ||
                            (ReadEx.GetType()).ToString() == ((new OverflowException()).GetType()).ToString()
                            )
                        {
                            // default value
                            ArtefactCleaningDepth = 0;
                        }
                        else
                        {
                            MessageBox.Show("Exception in GetAcquisitionOptions: " + ReadEx.Message);
                            ObjToScan = 0;
                            OptionMask = 0;
                            DisplayOptionMask = 0;
                            ContrastLimitToDisplay = 0;
                            CompletenessLimitToDisplay = 0;
                            ClipRegionW = 0;
                            ClipRegionH = 0;
                            RollPreviewTimeout = 0;
                            ArtefactCleaningDepth = 0;
                            return false;
                        }
                    }
                }

                // ver 3.2.0.0
                // EnableRollCompositionBlock
                if (this.cbEnableRollCompositionBlock.Checked) EnableRollCompositionBlock = true;
                // end ver 3.2.0.0

                ///////////////////////////////////////////
                // GET FFD OPTIONS
                ///////////////////////////////////////////
                // ver 4.0.0.0
                if (this.gbHwFfdSettings.Enabled)
                {
                    if (this.rbHwFfdHighStrictness.Checked)
                    {
                        HwFfdStrictnessThreshold = GBMSAPI_NET_HwAntifakeStrictnessThresholds.GBMSAPI_NET_HW_ANTIFAKE_THRESHOLD_HIGH_STRICTNESS;
                    }
                    else if (this.rbHwFfdMediumStrictness.Checked)
                    {
                        HwFfdStrictnessThreshold = GBMSAPI_NET_HwAntifakeStrictnessThresholds.GBMSAPI_NET_HW_ANTIFAKE_THRESHOLD_MEDIUM_STRICTNESS;
                    }
                    else if (this.rbHwFfdLowStrictness.Checked)
                    {
                        HwFfdStrictnessThreshold = GBMSAPI_NET_HwAntifakeStrictnessThresholds.GBMSAPI_NET_HW_ANTIFAKE_THRESHOLD_LOW_STRICTNESS;
                    }
                    else if (this.rbHwFfdPersonalizedStrictness.Checked)
                    {
                        int dummyFfdStrictTh;
                        if (int.TryParse(this.tbHwFfdPersonalizedStrictValue.Text, out dummyFfdStrictTh))
                        {
                            // ver 4.1.0: max value for hw ffd threshold set to 150
                            if (dummyFfdStrictTh >= 10 && dummyFfdStrictTh <= 150)
                            {
                                HwFfdStrictnessThreshold = dummyFfdStrictTh;
                            }
                        }
                    }
                }
                if (this.gbSwFfdSettings.Enabled)
                {
                    int dummyFfdStrictTh;
                    if (int.TryParse(this.tbSwFfdThreshold.Text, out dummyFfdStrictTh))
                    {
                        if (dummyFfdStrictTh >= 0 && dummyFfdStrictTh <= 100)
                        {
                            SwFfdStrictnessThreshold = dummyFfdStrictTh;
                        }
                    }
                }
                // end ver 4.0.0.0

                ///////////////////////////
                //// RETURN OK
                ///////////////////////////
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GetAcquisitionOptions function: " + ex.Message);
                ObjToScan = 0;
                OptionMask = 0;
                DisplayOptionMask = 0;
                ContrastLimitToDisplay = 0;
                CompletenessLimitToDisplay = 0;
                ClipRegionW = 0;
                ClipRegionH = 0;
                RollPreviewTimeout = 0;
                ArtefactCleaningDepth = 0;
                EnableRollCompositionBlock = false;

                return false;
            }
        }


    private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

