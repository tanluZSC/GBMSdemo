﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBMS.UTILITY
{
    class GBMSAPI_Example_DevNameStrings
    {
        public const String DS84_NameStr = "DactyScan84";

        public const String DS40_NameStr = "DactyScan40";

        public const String DS40I_NameStr = "DactyScan40I";

        public const String VS3_NameStr = "Visascan3";

        public const String PS2_NameStr = "Poliscan2";

        public const String MS500_NameStr = "MultiScan500";

        public const String MS1000_NameStr = "MultiScan1000";

        public const String DS26_NameStr = "DactyScan26";

        public const String MC500_NameStr = "MC500";

        public const String MSC500_NameStr = "MSC500";

        public const String DS84C_NameStr = "DactyScan84C";

        public const String MC517_NameStr = "MC517"; // Ver 2800

        public const String MSC517_NameStr = "MSC517"; // Ver 2800

        public const String DS32_NameStr = "DactyScanS32"; // Ver 2800

        public const String MS527_NameStr = "MS527"; // Ver 2.10.0.0

        public const String DS84t_NameStr = "DactyScan84t"; // ver 3.4.0.0

        public const String Did20_NameStr = "DactyID20"; // ver 4.0.0.0

        public const String MS527t_NameStr = "MS527t"; // ver 4.2.0.0
    }
    #region 说明了采集各种指纹的选项

    class GBMSAPI_Example_ScannableObjectStrings
    {
        // 平面指纹
        public static String FlatRightThumb_Str = "FLAT RIGHT THUMB";
        public static String FlatRightIndex_Str = "FLAT RIGHT INDEX";
        public static String FlatRightMiddle_Str = "FLAT RIGHT MIDDLE";
        public static String FlatRightRing_Str = "FLAT RIGHT RING";
        public static String FlatRightLittle_Str = "FLAT RIGHT LITTLE";
        public static String FlatLeftThumb_Str = "FLAT LEFT THUMB";
        public static String FlatLeftIndex_Str = "FLAT LEFT INDEX";
        public static String FlatLeftMiddle_Str = "FLAT LEFT MIDDLE";
        public static String FlatLeftRing_Str = "FLAT LEFT RING";
        public static String FlatLeftLittle_Str = "FLAT LEFT LITTLE";

        // 滚动指纹
        public static String RollRightThumb_Str = "ROLL RIGHT THUMB";
        public static String RollRightIndex_Str = "ROLL RIGHT INDEX";
        public static String RollRightMiddle_Str = "ROLL RIGHT MIDDLE";
        public static String RollRightRing_Str = "ROLL RIGHT RING";
        public static String RollRightLittle_Str = "ROLL RIGHT LITTLE";
        public static String RollLeftThumb_Str = "ROLL LEFT THUMB";
        public static String RollLeftIndex_Str = "ROLL LEFT INDEX";
        public static String RollLeftMiddle_Str = "ROLL LEFT MIDDLE";
        public static String RollLeftRing_Str = "ROLL LEFT RING";
        public static String RollLeftLittle_Str = "ROLL LEFT LITTLE";

        // ver 3.2.0.0
        // Rolled top
        public static String RolledTopRightThumb_Str = "ROLLED UPRIGHT THUMB";
        public static String RolledTopRightIndex_Str = "ROLLED UPRIGHT INDEX";
        public static String RolledTopRightMiddle_Str = "ROLLED UPRIGHT MIDDLE";
        public static String RolledTopRightRing_Str = "ROLLED UPRIGHT RING";
        public static String RolledTopRightLittle_Str = "ROLLED UPRIGHT LITTLE";
        public static String RolledTopLeftThumb_Str = "ROLLED UPLEFT THUMB";
        public static String RolledTopLeftIndex_Str = "ROLLED UPLEFT INDEX";
        public static String RolledTopLeftMiddle_Str = "ROLLED UPLEFT MIDDLE";
        public static String RolledTopLeftRing_Str = "ROLLED UPLEFT RING";
        public static String RolledTopLeftLittle_Str = "ROLLED UPLEFT LITTLE";
        // Rolled down
        public static String RolledDownRightThumb_Str = "ROLLED DOWN RIGHT THUMB";
        public static String RolledDownRightIndex_Str = "ROLLED DOWN RIGHT INDEX";
        public static String RolledDownRightMiddle_Str = "ROLLED DOWN RIGHT MIDDLE";
        public static String RolledDownRightRing_Str = "ROLLED DOWN RIGHT RING";
        public static String RolledDownRightLittle_Str = "ROLLED DOWN RIGHT LITTLE";
        public static String RolledDownLeftThumb_Str = "ROLLED DOWN LEFT THUMB";
        public static String RolledDownLeftIndex_Str = "ROLLED DOWN LEFT INDEX";
        public static String RolledDownLeftMiddle_Str = "ROLLED DOWN LEFT MIDDLE";
        public static String RolledDownLeftRing_Str = "ROLLED DOWN LEFT RING";
        public static String RolledDownLeftLittle_Str = "ROLLED DOWN LEFT LITTLE";
        // end ver 3.2.0.0

        // 双拇指
        public static String Slap2Thumbs_Str = "2 THUMBS";

        // VER 2000
        // 双食指
        public static String Slap2Indexes_Str = "2 INDEXES";
        // end VER 2000

        //四联指
        public static String Slap4Right_Str = "4 FINGERS RIGHT";
        public static String Slap4Left_Str = "4 FINGERS LEFT";

        // 左右手各一指（双手指）
        public static String Slap2Right_Str = "2 FINGERS RIGHT";
        public static String Slap2Left_Str = "2 FINGERS LEFT";

        //上半掌
        public static String UpperHalfPalmRight_Str = "UPPER HALF PALM RIGHT";
        public static String UpperHalfPalmLeft_Str = "UPPER HALF PALM LEFT";

        // 下半掌
        public static String LowerHalfPalmRight_Str = "LOWER HALF PALM RIGHT";
        public static String LowerHalfPalmLeft_Str = "LOWER HALF PALM LEFT";

        // 常用手掌
        public static String WriterPalmRight_Str = "WRITER PALM RIGHT";
        public static String WriterPalmLeft_Str = "WRITER PALM LEFT";

        //照片
        public static String Photo_Str = "PHOTO";

        // Ver 2.10.0.0
        // rolled thenar 滚动掌纹
        public static String RolledThenarRight_Str = "ROLLED THENAR RIGHT";
        public static String RolledThenarLeft_Str = "ROLLED THENAR LEFT";
        // Ver 3.3.0.0
        // rolled hypothenar
        public static String RolledHypoThenarRight_Str = "ROLLED HYPOTHENAR RIGHT";
        public static String RolledHypoThenarLeft_Str = "ROLLED HYPOTHENAR LEFT";
        // end Ver 3.3.0.0

        // Rolled joint //滚动掌纹
        public static String RolledJointRightThumb_Str = "ROLLED JOINT RIGHT THUMB";
        public static String RolledJointRightIndex_Str = "ROLLED JOINT RIGHT INDEX";
        public static String RolledJointRightMiddle_Str = "ROLLED JOINT RIGHT MIDDLE";
        public static String RolledJointRightRing_Str = "ROLLED JOINT RIGHT RING";
        public static String RolledJointRightLittle_Str = "ROLLED JOINT RIGHT LITTLE";
        public static String RolledJointLeftThumb_Str = "ROLLED JOINT LEFT THUMB";
        public static String RolledJointLeftIndex_Str = "ROLLED JOINT LEFT INDEX";
        public static String RolledJointLeftMiddle_Str = "ROLLED JOINT LEFT MIDDLE";
        public static String RolledJointLeftRing_Str = "ROLLED JOINT LEFT RING";
        public static String RolledJointLeftLittle_Str = "ROLLED JOINT LEFT LITTLE";
        //左侧平面关节
        // Plain joint left side 
        public static String PlainJointLeftSideRightThumb_Str = "PLAIN JOINT LEFT SIDE RIGHT THUMB";
        public static String PlainJointLeftSideRightIndex_Str = "PLAIN JOINT LEFT SIDE RIGHT INDEX";
        public static String PlainJointLeftSideRightMiddle_Str = "PLAIN JOINT LEFT SIDE RIGHT MIDDLE";
        public static String PlainJointLeftSideRightRing_Str = "PLAIN JOINT LEFT SIDE RIGHT RING";
        public static String PlainJointLeftSideRightLittle_Str = "PLAIN JOINT LEFT SIDE RIGHT LITTLE";
        public static String PlainJointLeftSideLeftThumb_Str = "PLAIN JOINT LEFT SIDE LEFT THUMB";
        public static String PlainJointLeftSideLeftIndex_Str = "PLAIN JOINT LEFT SIDE LEFT INDEX";
        public static String PlainJointLeftSideLeftMiddle_Str = "PLAIN JOINT LEFT SIDE LEFT MIDDLE";
        public static String PlainJointLeftSideLeftRing_Str = "PLAIN JOINT LEFT SIDE LEFT RING";
        public static String PlainJointLeftSideLeftLittle_Str = "PLAIN JOINT LEFT SIDE LEFT LITTLE";
        //右侧平面关节
        // Plain joint right side
        public static String PlainJointRightSideRightThumb_Str = "PLAIN JOINT RIGHT SIDE RIGHT THUMB";
        public static String PlainJointRightSideRightIndex_Str = "PLAIN JOINT RIGHT SIDE RIGHT INDEX";
        public static String PlainJointRightSideRightMiddle_Str = "PLAIN JOINT RIGHT SIDE RIGHT MIDDLE";
        public static String PlainJointRightSideRightRing_Str = "PLAIN JOINT RIGHT SIDE RIGHT RING";
        public static String PlainJointRightSideRightLittle_Str = "PLAIN JOINT RIGHT SIDE RIGHT LITTLE";
        public static String PlainJointRightSideLeftThumb_Str = "PLAIN JOINT RIGHT SIDE LEFT THUMB";
        public static String PlainJointRightSideLeftIndex_Str = "PLAIN JOINT RIGHT SIDE LEFT INDEX";
        public static String PlainJointRightSideLeftMiddle_Str = "PLAIN JOINT RIGHT SIDE LEFT MIDDLE";
        public static String PlainJointRightSideLeftRing_Str = "PLAIN JOINT RIGHT SIDE LEFT RING";
        public static String PlainJointRightSideLeftLittle_Str = "PLAIN JOINT RIGHT SIDE LEFT LITTLE";

        //中部平面关节
        // Plain joint center
        public static String RolledJointCenterRightThumb_Str = "ROLLED JOINT CENTER RIGHT THUMB";
        public static String RolledJointCenterRightIndex_Str = "ROLLED JOINT CENTER RIGHT INDEX";
        public static String RolledJointCenterRightMiddle_Str = "ROLLED JOINT CENTER RIGHT MIDDLE";
        public static String RolledJointCenterRightRing_Str = "ROLLED JOINT CENTER RIGHT RING";
        public static String RolledJointCenterRightLittle_Str = "ROLLED JOINT CENTER RIGHT LITTLE";
        public static String RolledJointCenterLeftThumb_Str = "ROLLED JOINT CENTER LEFT THUMB";
        public static String RolledJointCenterLeftIndex_Str = "ROLLED JOINT CENTER LEFT INDEX";
        public static String RolledJointCenterLeftMiddle_Str = "ROLLED JOINT CENTER LEFT MIDDLE";
        public static String RolledJointCenterLeftRing_Str = "ROLLED JOINT CENTER LEFT RING";
        public static String RolledJointCenterLeftLittle_Str = "ROLLED JOINT CENTER LEFT LITTLE";

        // Rolled tip 滚动指尖
        public static String RolledTipRightThumb_Str = "ROLLED TIP RIGHT THUMB";
        public static String RolledTipRightIndex_Str = "ROLLED TIP RIGHT INDEX";
        public static String RolledTipRightMiddle_Str = "ROLLED TIP RIGHT MIDDLE";
        public static String RolledTipRightRing_Str = "ROLLED TIP RIGHT RING";
        public static String RolledTipRightLittle_Str = "ROLLED TIP RIGHT LITTLE";
        public static String RolledTipLeftThumb_Str = "ROLLED TIP LEFT THUMB";
        public static String RolledTipLeftIndex_Str = "ROLLED TIP LEFT INDEX";
        public static String RolledTipLeftMiddle_Str = "ROLLED TIP LEFT MIDDLE";
        public static String RolledTipLeftRing_Str = "ROLLED TIP LEFT RING";
        public static String RolledTipLeftLittle_Str = "ROLLED TIP LEFT LITTLE";
        // end Ver 2.10.0.0
    }
    #endregion

    public class DeviceFeaturesStrings
    {
        public
            static String MultipleUSBConnectionsAllowed = "MULTIPLE USB CONNECTIONS ALLOWED";
        public
            static String AutoCaptureBlocking = "AUTO-CAPTURE-BLOCKING";
        public
            static String Resolution1000DPI = "1000 DPI RESOLUTION";
    }

    public class ScannableTypesStrings
    {
        public
            static String RollSingleFinger = "ROLL SINGLE FINGER";
        public
            static String FlatSingleFinger = "FLAT SINGLE FINGER";
        public
            static String FlatSlap4 = "FLAT 4 SLAP";
        public
            static String FlatSlap2 = "FLAT 2 SLAP";
        public
            static String FlatThumbs2 = "FLAT 2 THUMBS";
        // VER 2000
        public static String FlatIndexes2 = "FLAT 2 INDEXES";
        // end VER 2000
        public
            static String FlatLHP = "FLAT LOWER HALF PALM";
        public
            static String FlatUHP = "FLAT UPPER HALF PALM";
        public
            static String FlatWP = "FLAT WRITER PALM";
        public
            static String Photo = "PHOTO";
        // Ver 3.3.0.0
        public
            static String RolledHypoThenar = "ROLLED HYPOTHENAR";
        // end Ver 3.3.0.0
        // Ver 2.10.0.0
        public
            static String RolledThenar = "ROLLED THENAR";
        public
            static String RolledJoint = "ROLLED JOINT";
        public
            static String PlainJointRightSide = "PLAIN JOINT RIGHT SIDE";
        public
            static String PlainJointLeftSide = "PLAIN JOINT LEFT SIDE";
        public
            static String RolledJointCenter = "ROLLED JOINT CENTER";
        public
            static String RolledTip = "ROLLED TIP";
        // end Ver 2.10.0.0
        // ver 3.2.0.0
        public
            static String RolledTop = "ROLLED TOP";
        public
            static String RolledDown = "ROLLED DOWN";
        // end ver 3.2.0.0
    }

    public class DiagnosticStrings
    {
        public
            static String ScannerSurfaceNotNormalDiagMessString = "Finger placed too early or scanner surface dirty";
        public
            static String ScannerFailureDiagMessString = "Parameters of acquired image do not conform to quality standard";
        public
            static String CompositionSlowDiagMessString = "Frame rate is too slow to ensure proper composition image of rolled fingerprint";
        public
            static String FlatFingerSlidingDiagMessString = "Flat finger(s) sliding has been detected";
        public
            static String ExternalLightDiagMessString = "Too much strong external light influence";
        public
            static String FingerOutOfRegionLeftDiagMessString = "Finger goes out on the left border";
        public
            static String FingerOutOfRegionRightDiagMessString = "Finger goes out on the right border";
        public
            static String FingerOutOfRegionTopDiagMessString = "Finger goes out on the top border";
        public
            static String FingerDisplacedDownDiagMessString = "Finger significantly displaced to the down border";
        public
            static String ImproperRollDiagMessString = "Finger has been rolled improperly";
        public
            static String TooFastRollDiagMessString = "Finger has been rolled too much rapidly";
        public
            static String TooNarrowRollDiagMessString = "Finger has been rolled too much narrowly";
        public static String RollDirLeftDiagMessString = "Roll Finger to left direction";
        public static String RollDirRightDiagMessString = "Roll Finger to right direction";
        // VER 2.9.0.0
        public
            static String DryFingerDiagMessString = "Warning: Dry Finger";
        // VER 2.9.0.0
        public
            static String WetFingerDiagMessString = "Warning: Wet Finger";
        // VER 3.1.0.0
        public
            static String TooShortVerticalRollDiagMessString = "Finger has been rolled too much shortly in vertical direction";
        // end VER 3.1.0.0
        // ver 3.2.0.0
        public static String RollDirUpDiagMessString = "Roll up the finger";
        public static String RollDirDownDiagMessString = "Roll down the finger";
        // ver 3.2.0.0
        // ver 4.1.0.0
        public static String AutoCaptureBlockedForFakeFingerDetectionString = "Fake finger detected: lift finger and retry";
        // end ver 4.1.0.0
    }

    public class AutoCapturePhaseStrings
    {
        public
            static String AutoCaptureOffString = "OFF";
        public
            static String AutoCaptureWaitFingerString = "WAIT FINGER";
        public
            static String AutoCaptureSelectImageString = "SELECT IMAGE";
        public
            static String AutoCaptureBestImageStop = "BEST IMAGE STOP";
        public
            static String AutoCaptureBlocked = "BLOCKED";
    }
}
