'VB接口文件
'V3.10 updated at 2014 07 25

Option Explicit

Public Const R_OK =0
Public Const RUN_OFF =0
Public Const RUN_ON =1
Public Const DIR_NEG =0
Public Const DIR_POS =1
Public Const LIMIT_ON =1
Public Const LIMIT_OFF =0
Public Const RESOURCE_MOTOR =&H00000001
Public Const RESOURCE_TTL_IN =&H00000002
Public Const RESOURCE_TTL_OUT =&H00000004
Public Const RESOURCE_OPTIC_IN =&H00000008
Public Const RESOURCE_OPTIC_OUT =&H00000010
Public Const RESOURCE_AD =&H00000020
Public Const RESOURCE_OC =&H00000040
Public Const RESOURCE_LINE =&H00000080
Public Const RESOURCE_CIRCLE =&H00000100
Public Const RESOURCE_PLC =&H00000200
Public Const RESOURCE_STREAM =&H00000400
Public Const RESOURCE_ENCODER =&H00000800

Declare Function MT_Init Lib "MT_API.dll" () As Long

Declare Function MT_DeInit Lib "MT_API.dll" () As Long

Declare Function MT_Get_Dll_Version Lib "MT_API.dll" (ByRef sVer As String) As Long

Declare Function MT_Open_UART Lib "MT_API.dll" (ByVal sCOM As String) As Long

Declare Function MT_Close_UART Lib "MT_API.dll" () As Long

Declare Function MT_Open_UART2 Lib "MT_API.dll" (ByVal sCOM As String) As Long

Declare Function MT_Close_UART2 Lib "MT_API.dll" () As Long

Declare Function MT_Switch_To_UART Lib "MT_API.dll" () As Long

Declare Function MT_Switch_To_UART2 Lib "MT_API.dll" () As Long

Declare Function MT_Open_USB Lib "MT_API.dll" () As Long

Declare Function MT_Close_USB Lib "MT_API.dll" () As Long

Declare Function MT_Open_Net Lib "MT_API.dll" (ByVal IP0 As Byte,ByVal IP1 As Byte,ByVal IP2 As Byte,ByVal IP3 As Byte,ByVal IPPort As Integer) As Long

Declare Function MT_Close_Net Lib "MT_API.dll" () As Long

Declare Function MT_Check Lib "MT_API.dll" () As Long

Declare Function MT_Get_Product_Resource Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Get_Product_ID Lib "MT_API.dll" (ByVal sID As String) As Long

Declare Function MT_Get_Product_SN Lib "MT_API.dll" (ByVal sSN As String) As Long

Declare Function MT_Get_Product_Version Lib "MT_API.dll" (ByRef pMajor As Long,ByRef pMinor As Long) As Long

Declare Function MT_Get_Product_Version2 Lib "MT_API.dll" (ByRef pMajor As Long,ByRef pMinor As Long,ByRef pRelease As Long,ByRef pBuild As Long) As Long

Declare Function MT_Get_Axis_Num Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_Axis_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Get_Axis_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_Axis_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Get_Axis_Mode Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_Axis_Mode_Velocity Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Mode_Position Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Mode_Position_Open Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Mode_Position_Close Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Get_Axis_Velocity_V_Target Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_Axis_Velocity_V_Target_Abs Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Velocity_V_Target_Rel Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Velocity_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Get_Axis_Position_V_Max Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_Axis_Position_V_Max Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Get_Axis_Position_P_Target Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_Axis_Position_P_Target_Abs Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Position_P_Target_Rel Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Position_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Position_Close_Dec_Factor Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AFactor As Single) As Long

Declare Function MT_Set_Axis_Halt Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Halt_All Lib "MT_API.dll" () As Long

Declare Function MT_Get_Axis_V_Now Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Software_P_Now Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_Axis_Software_P Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Get_Axis_Status Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pRun As Byte,ByRef pDir As Byte,ByRef pNeg As Byte,ByRef pPos As Byte,ByRef pZero As Byte,ByRef pMode As Byte) As Long

Declare Function MT_Get_Param_Mem_Len Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Get_Param_Mem_Data Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Byte) As Long

Declare Function MT_Set_Param_Mem_Data Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Byte) As Long

Declare Function MT_Get_Optic_In_Num Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Get_Optic_In_Single Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_Optic_In_All Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Get_Optic_Out_Num Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Set_Optic_Out_Single Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Optic_Out_All Lib "MT_API.dll" (ByVal Value As Long) As Long

Declare Function MT_Get_OC_Out_Num Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Set_OC_Out_Single Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_OC_Out_All Lib "MT_API.dll" (ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Mode_Home Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Mode_Home_Home_Switch Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Mode_Home_Encoder_Index Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Mode_Home_Encoder_Home_Switch Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Home_V Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Home_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Software_Limit_Neg_Value Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Software_Limit_Pos_Value Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Software_Limit_Enable Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Software_Limit_Disable Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Line_Axis Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Axis_ID0 As Long,ByVal Axis_ID1 As Long) As Long

Declare Function MT_Set_Axis_Line_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Line_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Line_V Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Line_Run Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Line_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Line_Halt Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Line_Rel Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Axis_Target0 As Long,ByVal Axis_Target1 As Long) As Long

Declare Function MT_Set_Axis_Line_Abs Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Axis_Target0 As Long,ByVal Axis_Target1 As Long) As Long

Declare Function MT_Set_Axis_Line_Run_Rel Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Axis_Target0 As Long,ByVal Axis_Target1 As Long) As Long

Declare Function MT_Set_Axis_Line_Run_Abs Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Axis_Target0 As Long,ByVal Axis_Target1 As Long) As Long

Declare Function MT_Get_Axis_Line_Num Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Line_Status Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Line_Axis Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pID0 As Long,ByRef pID1 As Long) As Long

Declare Function MT_Get_Axis_Line_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Line_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Line_V Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_AD_Num Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Get_AD_Data Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_Board_T Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Set_Axis_Circle_Axis Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Axis_ID0 As Long,ByVal Axis_ID1 As Long) As Long

Declare Function MT_Set_Axis_Circle_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Circle_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Circle_V Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Circle_R_CW_Run_Rel Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AR As Long,ByVal Axis_Target0 As Long,ByVal Axis_Target1 As Long) As Long

Declare Function MT_Set_Axis_Circle_R_CW_Run_Abs Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AR As Long,ByVal Axis_Target0 As Long,ByVal Axis_Target1 As Long) As Long

Declare Function MT_Set_Axis_Circle_R_CCW_Run_Rel Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AR As Long,ByVal Axis_Target0 As Long,ByVal Axis_Target1 As Long) As Long

Declare Function MT_Set_Axis_Circle_R_CCW_Run_Abs Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AR As Long,ByVal Axis_Target0 As Long,ByVal Axis_Target1 As Long) As Long

Declare Function MT_Set_Axis_Circle_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Axis_Circle_Halt Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Get_Axis_Circle_Num Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Circle_Status Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Circle_Axis Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pID0 As Long,ByRef pID1 As Long) As Long

Declare Function MT_Get_Axis_Circle_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Circle_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Circle_V Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_PLC_Var_Num Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Get_PLC_Var_Data Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_PLC_Var_Data Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_PLC_Pause Lib "MT_API.dll" () As Long

Declare Function MT_Set_PLC_Stop Lib "MT_API.dll" () As Long

Declare Function MT_Set_PLC_Run Lib "MT_API.dll" () As Long

Declare Function MT_Set_PLC_Data Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Byte) As Long

Declare Function MT_Get_PLC_Code_Size Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Set_Axis_Home_V_Start Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Home_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Home_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Get_Axis_Home_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Home_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_Axis_Velocity_V_Start Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Velocity_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Velocity_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Get_Axis_Velocity_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Velocity_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_Axis_Position_V_Start Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Position_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Position_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Get_Axis_Position_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Get_Axis_Position_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_Axis_Line_V_Start Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Circle_V_Start Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Axis_Line_X_Run_Rel Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AAxis_Num As Long,ByVal pAxis As Long,ByVal pTarget As Long) As Long

Declare Function MT_Set_Axis_Line_X_Run_Abs Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AAxis_Num As Long,ByVal pAxis As Long,ByVal pTarget As Long) As Long

Declare Function MT_Set_Axis_Line_X_Target_Rel Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AAxisID As Long,ByVal ATarget As Long) As Long

Declare Function MT_Set_Axis_Line_X_Target_Abs Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AAxisID As Long,ByVal ATarget As Long) As Long

Declare Function MT_Set_Axis_Line_X_Count Lib "MT_API.dll" (ByVal AObj As Integer,ByVal ANum As Long) As Long

Declare Function MT_Set_Axis_Line_X_Axis Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AAxisID As Long,ByVal AAxis As Long) As Long

Declare Function MT_Set_Stream_Run Lib "MT_API.dll" () As Long

Declare Function MT_Set_Stream_Stop Lib "MT_API.dll" () As Long

Declare Function MT_Set_Stream_Pause Lib "MT_API.dll" () As Long

Declare Function MT_Set_Stream_Clear Lib "MT_API.dll" () As Long

Declare Function MT_Get_Stream_Space Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Set_Stream_Delay Lib "MT_API.dll" (ByVal Value As Long) As Long

Declare Function MT_Set_Stream_Line_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Stream_Line_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Stream_Line_V_Max Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Stream_Line_V_Start Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Stream_Line_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Stream_Line_Halt Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Stream_Line_X_Run_Rel Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AAxis_Num As Long,ByVal pAxis As Long,ByVal pTarget As Long) As Long

Declare Function MT_Set_Stream_Line_X_Run_Abs Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AAxis_Num As Long,ByVal pAxis As Long,ByVal pTarget As Long) As Long

Declare Function MT_Set_Stream_Circle_Axis Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Axis_ID0 As Long,ByVal Axis_ID1 As Long) As Long

Declare Function MT_Set_Stream_Circle_Acc Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Stream_Circle_Dec Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Stream_Circle_V_Max Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Stream_Circle_V_Start Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Stream_Circle_R_CW_Run_Rel Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AR As Long,ByVal Axis_Target0 As Long,ByVal Axis_Target1 As Long) As Long

Declare Function MT_Set_Stream_Circle_R_CW_Run_Abs Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AR As Long,ByVal Axis_Target0 As Long,ByVal Axis_Target1 As Long) As Long

Declare Function MT_Set_Stream_Circle_R_CCW_Run_Rel Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AR As Long,ByVal Axis_Target0 As Long,ByVal Axis_Target1 As Long) As Long

Declare Function MT_Set_Stream_Circle_R_CCW_Run_Abs Lib "MT_API.dll" (ByVal AObj As Integer,ByVal AR As Long,ByVal Axis_Target0 As Long,ByVal Axis_Target1 As Long) As Long

Declare Function MT_Set_Stream_Circle_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Stream_Circle_Halt Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Stream_Wait_Line Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Stream_Wait_Circle Lib "MT_API.dll" (ByVal AObj As Integer) As Long

Declare Function MT_Set_Stream_OC_Out_Single Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Stream_OC_Out_All Lib "MT_API.dll" (ByVal Value As Long) As Long

Declare Function MT_Set_Stream_Optic_Out_Single Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Stream_Optic_Out_All Lib "MT_API.dll" (ByVal Value As Long) As Long

Declare Function MT_Set_Stream_Dec_Enable Lib "MT_API.dll" () As Long

Declare Function MT_Set_Stream_Dec_Disable Lib "MT_API.dll" () As Long

Declare Function MT_Get_Encoder_Num Lib "MT_API.dll" (ByRef pValue As Long) As Long

Declare Function MT_Get_Encoder_Pos Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_Encoder_Pos Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Encoder_Z_Polarity Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Encoder_Dir_Polarity Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Get_Encoder_Index_Line_Count Lib "MT_API.dll" (ByVal AObj As Integer,ByRef pValue As Long) As Long

Declare Function MT_Set_Encoder_Over_Enable Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Encoder_Over_Max Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Set_Encoder_Over_Stable Lib "MT_API.dll" (ByVal AObj As Integer,ByVal Value As Long) As Long

Declare Function MT_Help_Step_Line_Real_To_Steps Lib "MT_API.dll" (ByVal AStepAngle As Double,ByVal ADiv As Long,ByVal APitch As Double,ByVal ALineRatio As Double,ByVal AValue As Double) As Long

Declare Function MT_Help_Step_Circle_Real_To_Steps Lib "MT_API.dll" (ByVal AStepAngle As Double,ByVal ADiv As Long,ByVal ACircleRatio As Double,ByVal AValue As Double) As Long

Declare Function MT_Help_Step_Line_Steps_To_Real Lib "MT_API.dll" (ByVal AStepAngle As Double,ByVal ADiv As Long,ByVal APitch As Double,ByVal ALineRatio As Double,ByVal AValue As Long) As Double

Declare Function MT_Help_Step_Circle_Steps_To_Real Lib "MT_API.dll" (ByVal AStepAngle As Double,ByVal ADiv As Long,ByVal ACircleRatio As Double,ByVal AValue As Long) As Double

Declare Function MT_Help_Encoder_Line_Real_To_Steps Lib "MT_API.dll" (ByVal APitch As Double,ByVal ALineRatio As Double,ByVal ALineCount As Long,ByVal AValue As Double) As Long

Declare Function MT_Help_Encoder_Circle_Real_To_Steps Lib "MT_API.dll" (ByVal ACircleRatio As Double,ByVal ALineCount As Long,ByVal AValue As Double) As Long

Declare Function MT_Help_Encoder_Line_Steps_To_Real Lib "MT_API.dll" (ByVal APitch As Double,ByVal ALineRatio As Double,ByVal ALineCount As Long,ByVal AValue As Long) As Double

Declare Function MT_Help_Encoder_Circle_Steps_To_Real Lib "MT_API.dll" (ByVal ACircleRatio As Double,ByVal ALineCount As Long,ByVal AValue As Long) As Double

Declare Function MT_Help_Grating_Line_Real_To_Steps Lib "MT_API.dll" (ByVal AUnit_um As Double,ByVal AValue As Double) As Long

Declare Function MT_Help_Grating_Circle_Real_To_Steps Lib "MT_API.dll" (ByVal ALineCount As Long,ByVal AValue As Double) As Long

Declare Function MT_Help_Grating_Line_Steps_To_Real Lib "MT_API.dll" (ByVal AUnit_um As Double,ByVal AValue As Long) As Double

Declare Function MT_Help_Grating_Circle_Steps_To_Real Lib "MT_API.dll" (ByVal ALineCount As Long,ByVal AValue As Long) As Double

Declare Function MT_Help_Encoder_Factor Lib "MT_API.dll" (ByVal AStepAngle As Double,ByVal ADiv As Long,ByVal ALineCount As Long) As Single

Declare Function MT_Help_Grating_Line_Factor Lib "MT_API.dll" (ByVal AStepAngle As Double,ByVal ADiv As Long,ByVal APitch As Double,ByVal ALineRatio As Double,ByVal AUnit_um As Double) As Single

Declare Function MT_Help_Grating_Circle_Factor Lib "MT_API.dll" (ByVal AStepAngle As Double,ByVal ADiv As Long,ByVal ACircleRatio As Double,ByVal ALineCount As Long) As Single



