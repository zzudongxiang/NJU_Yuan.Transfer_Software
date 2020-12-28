/*
C#接口文件
V3.10 updated at 2014 07 25
*/
using System;
using System.Text;
using System.Runtime.InteropServices;
public class MT_API
{

public const Int32  R_OK =0;
public const Int32  RUN_OFF =0;
public const Int32  RUN_ON =1;
public const Int32  DIR_NEG =0;
public const Int32  DIR_POS =1;
public const Int32  LIMIT_ON =1;
public const Int32  LIMIT_OFF =0;
public const Int32  RESOURCE_MOTOR =0x00000001;
public const Int32  RESOURCE_TTL_IN =0x00000002;
public const Int32  RESOURCE_TTL_OUT =0x00000004;
public const Int32  RESOURCE_OPTIC_IN =0x00000008;
public const Int32  RESOURCE_OPTIC_OUT =0x00000010;
public const Int32  RESOURCE_AD =0x00000020;
public const Int32  RESOURCE_OC =0x00000040;
public const Int32  RESOURCE_LINE =0x00000080;
public const Int32  RESOURCE_CIRCLE =0x00000100;
public const Int32  RESOURCE_PLC =0x00000200;
public const Int32  RESOURCE_STREAM =0x00000400;
public const Int32  RESOURCE_ENCODER =0x00000800;

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Init();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_DeInit();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Dll_Version(ref String sVer);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Open_UART(String sCOM);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Close_UART();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Open_UART2(String sCOM);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Close_UART2();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Switch_To_UART();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Switch_To_UART2();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Open_USB();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Close_USB();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Open_Net(Byte IP0,Byte IP1,Byte IP2,Byte IP3,UInt16 IPPort);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Close_Net();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Check();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Product_Resource(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Product_ID(String sID);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Product_SN(String sSN);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Product_Version(ref Int32 pMajor,ref Int32 pMinor);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Product_Version2(ref Int32 pMajor,ref Int32 pMinor,ref Int32 pRelease,ref Int32 pBuild);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Num(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Acc(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Acc(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Dec(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Dec(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Mode(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Velocity(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Position(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Position_Open(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Position_Close(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Velocity_V_Target(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Velocity_V_Target_Abs(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Velocity_V_Target_Rel(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Velocity_Stop(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Position_V_Max(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_V_Max(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Position_P_Target(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_P_Target_Abs(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_P_Target_Rel(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_Stop(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_Close_Dec_Factor(UInt16 AObj,Single AFactor);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Halt(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Halt_All();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_V_Now(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Software_P_Now(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Software_P(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Status(UInt16 AObj,ref Byte pRun,ref Byte pDir,ref Byte pNeg,ref Byte pPos,ref Byte pZero,ref Byte pMode);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Param_Mem_Len(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Param_Mem_Data(UInt16 AObj,ref Byte pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Param_Mem_Data(UInt16 AObj,Byte Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Optic_In_Num(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Optic_In_Single(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Optic_In_All(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Optic_Out_Num(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Optic_Out_Single(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Optic_Out_All(Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_OC_Out_Num(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_OC_Out_Single(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_OC_Out_All(Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Home(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Home_Home_Switch(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Home_Encoder_Index(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Home_Encoder_Home_Switch(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Home_V(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Home_Stop(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Software_Limit_Neg_Value(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Software_Limit_Pos_Value(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Software_Limit_Enable(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Software_Limit_Disable(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Axis(UInt16 AObj,Int32 Axis_ID0,Int32 Axis_ID1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Acc(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Dec(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_V(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Run(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Stop(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Halt(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Rel(UInt16 AObj,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Abs(UInt16 AObj,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Run_Rel(UInt16 AObj,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Run_Abs(UInt16 AObj,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Line_Num(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Line_Status(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Line_Axis(UInt16 AObj,ref Int32 pID0,ref Int32 pID1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Line_Acc(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Line_Dec(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Line_V(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_AD_Num(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_AD_Data(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Board_T(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_Axis(UInt16 AObj,Int32 Axis_ID0,Int32 Axis_ID1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_Acc(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_Dec(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_V(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_R_CW_Run_Rel(UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_R_CW_Run_Abs(UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_R_CCW_Run_Rel(UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_R_CCW_Run_Abs(UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_Stop(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_Halt(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Circle_Num(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Circle_Status(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Circle_Axis(UInt16 AObj,ref Int32 pID0,ref Int32 pID1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Circle_Acc(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Circle_Dec(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Circle_V(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Var_Num(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Var_Data(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_PLC_Var_Data(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_PLC_Pause();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_PLC_Stop();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_PLC_Run();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_PLC_Data(UInt16 AObj,Byte Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Code_Size(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Home_V_Start(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Home_Acc(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Home_Dec(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Home_Acc(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Home_Dec(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Velocity_V_Start(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Velocity_Acc(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Velocity_Dec(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Velocity_Acc(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Velocity_Dec(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_V_Start(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_Acc(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_Dec(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Position_Acc(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Position_Dec(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_V_Start(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_V_Start(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_X_Run_Rel(UInt16 AObj,Int32 AAxis_Num,ref Int32 pAxis,ref Int32 pTarget);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_X_Run_Abs(UInt16 AObj,Int32 AAxis_Num,ref Int32 pAxis,ref Int32 pTarget);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_X_Target_Rel(UInt16 AObj,Int32 AAxisID,Int32 ATarget);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_X_Target_Abs(UInt16 AObj,Int32 AAxisID,Int32 ATarget);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_X_Count(UInt16 AObj,Int32 ANum);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_X_Axis(UInt16 AObj,Int32 AAxisID,Int32 AAxis);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Run();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Stop();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Pause();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Clear();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Stream_Space(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Delay(Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_Acc(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_Dec(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_V_Max(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_V_Start(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_Stop(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_Halt(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_X_Run_Rel(UInt16 AObj,Int32 AAxis_Num,ref Int32 pAxis,ref Int32 pTarget);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_X_Run_Abs(UInt16 AObj,Int32 AAxis_Num,ref Int32 pAxis,ref Int32 pTarget);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_Axis(UInt16 AObj,Int32 Axis_ID0,Int32 Axis_ID1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_Acc(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_Dec(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_V_Max(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_V_Start(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_R_CW_Run_Rel(UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_R_CW_Run_Abs(UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_R_CCW_Run_Rel(UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_R_CCW_Run_Abs(UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_Stop(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_Halt(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Wait_Line(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Wait_Circle(UInt16 AObj);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_OC_Out_Single(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_OC_Out_All(Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Optic_Out_Single(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Optic_Out_All(Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Dec_Enable();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Dec_Disable();

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Encoder_Num(ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Encoder_Pos(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Encoder_Pos(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Encoder_Z_Polarity(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Encoder_Dir_Polarity(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Encoder_Index_Line_Count(UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Encoder_Over_Enable(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Encoder_Over_Max(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Encoder_Over_Stable(UInt16 AObj,Int32 Value);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Help_Step_Line_Real_To_Steps(Double AStepAngle,Int32 ADiv,Double APitch,Double ALineRatio,Double AValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Help_Step_Circle_Real_To_Steps(Double AStepAngle,Int32 ADiv,Double ACircleRatio,Double AValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Double MT_Help_Step_Line_Steps_To_Real(Double AStepAngle,Int32 ADiv,Double APitch,Double ALineRatio,Int32 AValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Double MT_Help_Step_Circle_Steps_To_Real(Double AStepAngle,Int32 ADiv,Double ACircleRatio,Int32 AValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Help_Encoder_Line_Real_To_Steps(Double APitch,Double ALineRatio,Int32 ALineCount,Double AValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Help_Encoder_Circle_Real_To_Steps(Double ACircleRatio,Int32 ALineCount,Double AValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Double MT_Help_Encoder_Line_Steps_To_Real(Double APitch,Double ALineRatio,Int32 ALineCount,Int32 AValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Double MT_Help_Encoder_Circle_Steps_To_Real(Double ACircleRatio,Int32 ALineCount,Int32 AValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Help_Grating_Line_Real_To_Steps(Double AUnit_um,Double AValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Help_Grating_Circle_Real_To_Steps(Int32 ALineCount,Double AValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Double MT_Help_Grating_Line_Steps_To_Real(Double AUnit_um,Int32 AValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Double MT_Help_Grating_Circle_Steps_To_Real(Int32 ALineCount,Int32 AValue);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Single MT_Help_Encoder_Factor(Double AStepAngle,Int32 ADiv,Int32 ALineCount);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Single MT_Help_Grating_Line_Factor(Double AStepAngle,Int32 ADiv,Double APitch,Double ALineRatio,Double AUnit_um);

[DllImport("MT_API.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Single MT_Help_Grating_Circle_Factor(Double AStepAngle,Int32 ADiv,Double ACircleRatio,Int32 ALineCount);

}

