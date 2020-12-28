#Attribute VB_Name = "MoTech"
"VB.net接口文件
"V3.10 updated at 2014 07 25

Imports System
Imports System.Text
Imports System.Runtime.InteropServices
Public Class MT_API

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

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Init() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_DeInit() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Dll_Version(ByRef sVer As String) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Open_UART(ByVal sCOM As String) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Close_UART() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Open_UART2(ByVal sCOM As String) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Close_UART2() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Switch_To_UART() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Switch_To_UART2() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Open_USB() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Close_USB() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Open_Net(ByVal IP0 As Byte,ByVal IP1 As Byte,ByVal IP2 As Byte,ByVal IP3 As Byte,ByVal IPPort As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Close_Net() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Check() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_Resource(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_ID(ByVal sID As String) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_SN(ByVal sSN As String) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_Version(ByRef pMajor As Int32,ByRef pMinor As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_Version2(ByRef pMajor As Int32,ByRef pMinor As Int32,ByRef pRelease As Int32,ByRef pBuild As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Num(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Acc(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Acc(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Dec(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Dec(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Mode(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Velocity(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Position(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Position_Open(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Position_Close(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Velocity_V_Target(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_V_Target_Abs(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_V_Target_Rel(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_Stop(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Position_V_Max(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_V_Max(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Position_P_Target(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_P_Target_Abs(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_P_Target_Rel(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_Stop(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_Close_Dec_Factor(ByVal AObj As UInt16,ByVal AFactor As Single) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Halt(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Halt_All() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_V_Now(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Software_P_Now(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_P(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Status(ByVal AObj As UInt16,ByRef pRun As Byte,ByRef pDir As Byte,ByRef pNeg As Byte,ByRef pPos As Byte,ByRef pZero As Byte,ByRef pMode As Byte) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Param_Mem_Len(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Param_Mem_Data(ByVal AObj As UInt16,ByRef pValue As Byte) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Param_Mem_Data(ByVal AObj As UInt16,ByVal Value As Byte) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_In_Num(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_In_Single(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_In_All(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_Out_Num(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Optic_Out_Single(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Optic_Out_All(ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_OC_Out_Num(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_OC_Out_Single(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_OC_Out_All(ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Home(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Home_Home_Switch(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Home_Encoder_Index(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Home_Encoder_Home_Switch(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Home_V(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Home_Stop(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_Limit_Neg_Value(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_Limit_Pos_Value(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_Limit_Enable(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_Limit_Disable(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Axis(ByVal AObj As UInt16,ByVal Axis_ID0 As Int32,ByVal Axis_ID1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Acc(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Dec(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_V(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Run(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Stop(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Halt(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Rel(ByVal AObj As UInt16,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Abs(ByVal AObj As UInt16,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Run_Rel(ByVal AObj As UInt16,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Run_Abs(ByVal AObj As UInt16,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Num(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Status(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Axis(ByVal AObj As UInt16,ByRef pID0 As Int32,ByRef pID1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Acc(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Dec(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_V(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_AD_Num(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_AD_Data(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Board_T(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Axis(ByVal AObj As UInt16,ByVal Axis_ID0 As Int32,ByVal Axis_ID1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Acc(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Dec(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_V(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_R_CW_Run_Rel(ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_R_CW_Run_Abs(ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_R_CCW_Run_Rel(ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_R_CCW_Run_Abs(ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Stop(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Halt(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Num(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Status(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Axis(ByVal AObj As UInt16,ByRef pID0 As Int32,ByRef pID1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Acc(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Dec(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_V(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Var_Num(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Var_Data(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_PLC_Var_Data(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_PLC_Pause() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_PLC_Stop() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_PLC_Run() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_PLC_Data(ByVal AObj As UInt16,ByVal Value As Byte) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Code_Size(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Home_V_Start(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Home_Acc(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Home_Dec(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Home_Acc(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Home_Dec(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_V_Start(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_Acc(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_Dec(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Velocity_Acc(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Velocity_Dec(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_V_Start(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_Acc(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_Dec(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Position_Acc(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Position_Dec(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_V_Start(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_V_Start(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_X_Run_Rel(ByVal AObj As UInt16,ByVal AAxis_Num As Int32,ByRef pAxis As Int32,ByRef pTarget As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_X_Run_Abs(ByVal AObj As UInt16,ByVal AAxis_Num As Int32,ByRef pAxis As Int32,ByRef pTarget As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_X_Target_Rel(ByVal AObj As UInt16,ByVal AAxisID As Int32,ByVal ATarget As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_X_Target_Abs(ByVal AObj As UInt16,ByVal AAxisID As Int32,ByVal ATarget As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_X_Count(ByVal AObj As UInt16,ByVal ANum As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_X_Axis(ByVal AObj As UInt16,ByVal AAxisID As Int32,ByVal AAxis As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Run() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Stop() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Pause() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Clear() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Stream_Space(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Delay(ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_Acc(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_Dec(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_V_Max(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_V_Start(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_Stop(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_Halt(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_X_Run_Rel(ByVal AObj As UInt16,ByVal AAxis_Num As Int32,ByRef pAxis As Int32,ByRef pTarget As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_X_Run_Abs(ByVal AObj As UInt16,ByVal AAxis_Num As Int32,ByRef pAxis As Int32,ByRef pTarget As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_Axis(ByVal AObj As UInt16,ByVal Axis_ID0 As Int32,ByVal Axis_ID1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_Acc(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_Dec(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_V_Max(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_V_Start(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_R_CW_Run_Rel(ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_R_CW_Run_Abs(ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_R_CCW_Run_Rel(ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_R_CCW_Run_Abs(ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_Stop(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_Halt(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Wait_Line(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Wait_Circle(ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_OC_Out_Single(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_OC_Out_All(ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Optic_Out_Single(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Optic_Out_All(ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Dec_Enable() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Dec_Disable() As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Encoder_Num(ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Encoder_Pos(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Encoder_Pos(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Encoder_Z_Polarity(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Encoder_Dir_Polarity(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Encoder_Index_Line_Count(ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Encoder_Over_Enable(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Encoder_Over_Max(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Encoder_Over_Stable(ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Step_Line_Real_To_Steps(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal APitch As Double,ByVal ALineRatio As Double,ByVal AValue As Double) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Step_Circle_Real_To_Steps(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal ACircleRatio As Double,ByVal AValue As Double) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Step_Line_Steps_To_Real(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal APitch As Double,ByVal ALineRatio As Double,ByVal AValue As Int32) As Double
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Step_Circle_Steps_To_Real(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal ACircleRatio As Double,ByVal AValue As Int32) As Double
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Encoder_Line_Real_To_Steps(ByVal APitch As Double,ByVal ALineRatio As Double,ByVal ALineCount As Int32,ByVal AValue As Double) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Encoder_Circle_Real_To_Steps(ByVal ACircleRatio As Double,ByVal ALineCount As Int32,ByVal AValue As Double) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Encoder_Line_Steps_To_Real(ByVal APitch As Double,ByVal ALineRatio As Double,ByVal ALineCount As Int32,ByVal AValue As Int32) As Double
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Encoder_Circle_Steps_To_Real(ByVal ACircleRatio As Double,ByVal ALineCount As Int32,ByVal AValue As Int32) As Double
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Grating_Line_Real_To_Steps(ByVal AUnit_um As Double,ByVal AValue As Double) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Grating_Circle_Real_To_Steps(ByVal ALineCount As Int32,ByVal AValue As Double) As Integer
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Grating_Line_Steps_To_Real(ByVal AUnit_um As Double,ByVal AValue As Int32) As Double
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Grating_Circle_Steps_To_Real(ByVal ALineCount As Int32,ByVal AValue As Int32) As Double
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Encoder_Factor(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal ALineCount As Int32) As Single
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Grating_Line_Factor(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal APitch As Double,ByVal ALineRatio As Double,ByVal AUnit_um As Double) As Single
End Function

<DllImport("MT_API.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Grating_Circle_Factor(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal ACircleRatio As Double,ByVal ALineCount As Int32) As Single
End Function

End Class

