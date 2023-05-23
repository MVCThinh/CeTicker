using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending
{
    
    public enum eCamName
    {
        LoadingPre1 = 0,
        LoadingPre2 = 1,
        Laser1 = 2,
        Laser2 = 3,
    }

    public enum SettingUpConstant
    {
        SettingPMAlign,
        SettingLiveVideo
    }
    public enum eBendMode
    {
        armXYT = 0,
        armTafterXY = 1,
        armXTafterY = 2,
        armXY = 3,
        stageTarmXY = 4
    };

    public enum eLightType
    {
        Light5V = 0,
        Light12V = 1
    };

    public enum eImageSaveType
    {
        All = 0,
        Original = 1,
        Display = 2,
        Fail = 3
    };

    public enum eImageSaveKind
    {
        normal = 0,
        LaserAlign1 = 1,
        LaserAlign2 = 2,
        LaserInspection1 = 3,
        LaserInspection2 = 4
    };

    public enum eInspFindSeq
    {
        PanelFPCB = 0,
        FPCBPanel = 1
    };

    public enum eImageReverse
    {
        None = 0,
        XReverse = 1,
        YReverse = 2,
        AllReverse = 3,
        Reverse90 = 4,
        Reverse270 = 5,
        Reverse90XY = 6,
        Reverse270XY = 7
    };

    public enum ePatternSearchMode
    {
        LastBest = 0,
        AllBest = 1,
    }

    public enum ePatternSearchTool
    {
        PMAlign = 0,
        SearchMax = 1,
    }

    public enum eInspMode
    {
        PanelMarkFPCBMark = 0,
        PanelEdgeFPCBEdge,
        PanelEdgeFPCBMark,
        PanelMarkFPCBEdge,
    }

    public enum eSearchKind
    {
        Pattern = 0,
        Line,
    }
    public enum ePatternKind
    {
        Panel = 0,
        FPC,
        SubPanel,
        SubFPC,
        Material, //자재 추가 Add Material
        Left_1cam,
        Right_1cam,
        Cal,
        Cal2,
        CalX,
        CalY,
        FoamInsp,
    }

    public enum eLineKind
    {
        //cam1에서 두점찾을때 고려해야함(width각각두개 height각각 두개)
        Null = -1, //null이 필요한 곳에서 사용하고, -1로 해둬서 처리 잘못하면 프로그램 뻑날텐데 역추적하기 좋을듯 
        //Use it where you need it, and leave it as -1, so if you do it wrong, the program will crash, so it's better to trace back
        PanelWidth1 = 0,
        PanelWidth2,
        PanelHeight1,
        PanelHeight2,
        FPCBWidth1,
        FPCBWidth2,
        FPCBHeight1,
        FPCBHeight2,
        FoamWidth1, //pcy201118
        FoamWidth2,
        FoamHeight1,
        FoamHeight2,
    }

    public enum eCamNO //사실 visionno와 같음 //tostring비교시 ecamNOpc번호로 변환필요
    {
        Null = -1,
        LoadingPre1 = 0,
        LoadingPre2,
        Laser1,
        Laser2,
    }

    public enum eCamNO1
    {
        LoadingPre1 = 0,
        LoadingPre2,
        Laser1,
        Laser2,
    }

    public enum eCalPos
    {
        Err = -1,
        LoadingPre1_1 = 0,
        LoadingPre1_2,
        LoadingPre2_1,
        LoadingPre2_2,
        Laser1,
        Laser2,
    }

    public enum eHistogram
    {
        Detach = 0,
        MCRPre = 1,
        RefPoint = 2,
        MCRRegion = 3,
        ImageProcessing = 4,
    }

    public enum ePCResult
    {
        WAIT = 0,
        OK = 1,
        BY_PASS = 2, // (Mark NG, L-Check NG, Manual Bending 등) 각종 모르는 이유..
        ALIGN_LIMIT = 3, //
        SPEC_OVER = 4, //각종 스펙오버
        CHECK = 5, //각종 유무
        WORKER_BY_PASS = 6, //작업자 bypass처리
        MANUAL_BENDING = 7, //강제벤딩
        INIT = 8, //이니셜 에러
        RETRY_OVER = 9, //
        PANEL_SHIFT_NG = 10,
        RETRY = 11,
        ERROR_MARK = 12,
        FIRST_LIMIT = 13,
        ERROR_LCHECK = 14,
        VISION_REPLY_WAIT = 15, //(Mark NG, L-Check NG, Manual Bending 등)
        //20.12.17 lkw DL
        DL = 16,
    }

    public enum eID
    {
        DataMatrix = 0,
        QRCode = 1,
    }

    public enum eRefSearch
    {
        Line = 0,
        Mark = 1,
        Blob = 2,
    }

    public enum eBlobMass
    {
        Left = 0,
        Right = 1,
    }

    public enum eBlobPoint
    {
        LeftUp = 0,
        RightUp = 1,
        LeftDown = 2,
        RightDown = 3,
    }

    public enum ePolarity
    {
        Dark = 0,
        Light = 1,
    }

    public enum eInspKind
    {
        Camera = 0,
        Mark = 1,
    }

    public enum eCalType
    {
        Cam1Type = 0,
        Cam2Type = 1,
        Cam3Type = 2,
        Cam4Type = 3,
        Cam1Cal2 = 4,
    }
    public enum eRecipe
    {
        PANEL_LENGTH_X = 0,
        PANEL_LENGTH_Y,
        PANEL_MARK_TO_MARK_LENGTH_X,
        FOAM_LENGTH_Y,   //2.5
        FOAM1_ATTACH_SPEC_LX,
        FOAM1_ATTACH_SPEC_LY,
        FOAM1_ATTACH_SPEC_RX,
        FOAM1_ATTACH_SPEC_RY,
        BENDING_SPEC_LX,
        BENDING_SPEC_LY,
        BENDING_SPEC_RX,
        BENDING_SPEC_RY,
        BENDING_INSPECTION_SPEC_LX,
        BENDING_INSPECTION_SPEC_LY,
        BENDING_INSPECTION_SPEC_RX,
        BENDING_INSPECTION_SPEC_RY,
        FOAM_ATTACH1_OFFSET_X,
        FOAM_ATTACH1_OFFSET_Y,
        FOAM_ATTACH1_OFFSET_T,
        FOAM_ATTACH2_OFFSET_X,
        FOAM_ATTACH2_OFFSET_Y,
        FOAM_ATTACH2_OFFSET_T,
        BENDING_ARM_PRE_OFFSET_X,
        BENDING_ARM_PRE_OFFSET_Y,
        BENDING_ARM_PRE_OFFSET_T,
        BENDING_OFFSET_LY,
        BENDING_OFFSET_RY,
        LOADING_PRE_LCHECK_SPEC1,
        LOADING_PRE_LCHECK_TOLERANCE1,
        LOADING_PRE_LCHECK_SPEC2,
        LOADING_PRE_LCHECK_TOLERANCE2,
        FOAM_REEL_LCHECK_SPEC1,
        FOAM_REEL_LCHECK_TOLERANCE1,
        FOAM_REEL_LCHECK_SPEC2,
        FOAM_REEL_LCHECK_TOLERANCE2,
        FOAM_ATTACH_LCHECK_SPEC1,
        FOAM_ATTACH_LCHECK_TOLERANCE1,
        FOAM_ATTACH_LCHECK_SPEC2,
        FOAM_ATTACH_LCHECK_TOLERANCE2,
        BENDING_LCHECK_SPEC1,
        BENDING_LCHECK_TOLERANCE1,
        BENDING_LCHECK_SPEC2,
        BENDING_LCHECK_TOLERANCE2,
        BENDINGSIDE_LCHECK_SPEC1,
        BENDINGSIDE_LCHECK_TOLERANCE1,
        BENDINGSIDE_LCHECK_SPEC2,
        BENDINGSIDE_LCHECK_TOLERANCE2,
        SIDEINSPECTION_LCHECK_SPEC1,
        SIDEINSPECTION_LCHECK_TOLERANCE1,
        SIDEINSPECTION_LCHECK_SPEC2,
        SIDEINSPECTION_LCHECK_TOLERANCE2,
        UPPERINSPECTION_LCHECK_SPEC1,
        UPPERINSPECTION_LCHECK_TOLERANCE1,
        UPPERINSPECTION_LCHECK_SPEC2,
        UPPERINSPECTION_LCHECK_TOLERANCE2,
        FFU_FAN_SPEED,
        LASER_POSITION_SPECX,
        LASER_POSITION_SPECY,
        RESERVE1, 
        RESERVE2,
        LASER_MARKING_OFFSET_X1,
        LASER_MARKING_OFFSET_Y1,
        LASER_MARKING_OFFSET_X2,
        LASER_MARKING_OFFSET_Y2,
        FOAM2_ATTACH_SPEC_LX,
        FOAM2_ATTACH_SPEC_LY,
        FOAM2_ATTACH_SPEC_RX,
        FOAM2_ATTACH_SPEC_RY,
    }
    public enum eConvert
    {
        TempAttach1 = 0,
        TempAttach2 = 1,
        EMIAttach1 = 2,
        EMIAttach2 = 3,
        notUse = 4,
    }
}
