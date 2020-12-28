Attribute VB_Name = "MoTech"
'==================================================
'2014 04 22 更新接口文件到 MT_API.dll v3.6
'增加直线插补和圆弧插补相关定义
'上海小墨科技有限公司版权所有
'===================================================

Option Explicit

'==================================================
'运行环境
'===================================================
'dll版本
'初始化窗口
Declare Function MT_Init Lib "MT_API.dll" () As Long
'关闭窗口
Declare Function MT_DeInit Lib "MT_API.dll" () As Long
'获取dll版本号
Declare Function MT_Get_Dll_Version Lib "MT_API.dll" (ByRef sVer As String) As Long



'======================================================
'通信口
'======================================================
'打开 UART
Declare Function MT_Open_UART Lib "MT_API.dll" (ByVal sCOM As String) As Long
'关闭 UART
Declare Function MT_Close_UART Lib "MT_API.dll" () As Long
'打开USB
Declare Function MT_Open_USB Lib "MT_API.dll" () As Long
'关闭USB
Declare Function MT_Close_USB Lib "MT_API.dll" () As Long


'=====================================================
'板卡检测
'=====================================================
'检测设备
Declare Function MT_Check Lib "MT_API.dll" () As Long
'读取资源模块
Declare Function MT_Get_Product_Resource Lib "MT_API.dll" (ByRef Value As Long) As Long
'获取ID
Declare Function MT_Get_Product_ID Lib "MT_API.dll" (ByRef sID As String) As Long
'获取SN
Declare Function MT_Get_Product_SN Lib "MT_API.dll" (ByRef sSN As String) As Long
'读取固件版本号
Declare Function MT_Get_Product_Version Lib "MT_API.dll" (ByRef Major As Long, ByRef Minor As Long) As Long

'===================================================================
'电机相关
'====================================================================
'轴数
Declare Function MT_Get_Axis_Num Lib "MT_API.dll" (ByRef Value As Long) As Long
'读取加速度
Declare Function MT_Get_Axis_Acc Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'设置加速度
Declare Function MT_Set_Axis_Acc Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'读取加速度
Declare Function MT_Get_Axis_Dec Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'设置加速度
Declare Function MT_Set_Axis_Dec Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'读取工作模式
Declare Function MT_Get_Axis_Mode Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'设置速度模式
Declare Function MT_Set_Axis_Mode_Velocity Lib "MT_API.dll" (ByVal AObj As Integer) As Long
'设置位置模式
Declare Function MT_Set_Axis_Mode_Position Lib "MT_API.dll" (ByVal AObj As Integer) As Long
'读取速度模式目标速度
Declare Function MT_Get_Axis_Velocity_V_Target Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'设置速度模式目标速度
Declare Function MT_Set_Axis_Velocity_V_Target_Abs Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'设置速度模式目标速度
Declare Function MT_Set_Axis_Velocity_V_Target_Rel Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'停止速度模式
Declare Function MT_Set_Axis_Velocity_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long

'读取位置模式最大速度
Declare Function MT_Get_Axis_Position_V_Max Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'设置位置模式最大速度
Declare Function MT_Set_Axis_Position_V_Max Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'读取位置模式目标
Declare Function MT_Get_Axis_Position_P_Target Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'设置位置模式目标
Declare Function MT_Set_Axis_Position_P_Target_Abs Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
Declare Function MT_Set_Axis_Position_P_Target_Rel Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'停止位置模式
Declare Function MT_Set_Axis_Position_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long
'紧急停止
Declare Function MT_Set_Axis_Halt Lib "MT_API.dll" (ByVal AObj As Integer) As Long
Declare Function MT_Set_Axis_Halt_All Lib "MT_API.dll" () As Long

'''''''''''''''''''''''''''''''
'/  状态相关
'/  '''''''''''''''''''''''''''
'读取当前速度
Declare Function MT_Get_Axis_V_Now Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'读取当前软件位置
Declare Function MT_Get_Axis_Software_P_Now Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'设置软件位置
Declare Function MT_Set_Axis_Software_P Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long

Declare Function MT_Get_Axis_Status Lib "MT_API.dll" _
   (ByVal AObj As Integer, ByRef Run As Byte, ByRef Dir As Byte, _
   ByRef Neg As Byte, ByRef Pos As Byte, ByRef Zero As Byte, ByRef Mode As Byte) As Long


'设置0位模式
Declare Function MT_Set_Axis_Mode_Home Lib "MT_API.dll" (ByVal AObj As Integer) As Long
'设置0位模式目标速度
Declare Function MT_Set_Axis_Home_V Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'停止0位模式
Declare Function MT_Set_Axis_Home_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long


'软件限位
'设置软件限位值
Declare Function MT_Set_Axis_Software_Limit_Neg_Value Lib "MT_API.dll" _
    (ByVal AObj As Integer, ByVal Value As Long) As Long
'设置软件限位值
Declare Function MT_Set_Axis_Software_Limit_Pos_Value Lib "MT_API.dll" _
    (ByVal AObj As Integer, ByVal Value As Long) As Long
'使能软件限位模式
Declare Function MT_Set_Axis_Software_Limit_Enable Lib "MT_API.dll" (ByVal AObj As Integer) As Long
'停止软件限位模式
Declare Function MT_Set_Axis_Software_Limit_Disable Lib "MT_API.dll" (ByVal AObj As Integer) As Long
''''''''''''''''''''''''''''''''''''
'存储器
'读取存储器长度
Declare Function MT_Get_Param_Mem_Len Lib "MT_API.dll" (ByRef Value As Long) As Long
'读取存储器数据
Declare Function MT_Get_Param_Mem_Data Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Byte) As Long
'设置存储器数据
Declare Function MT_Set_Param_Mem_Data Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Byte) As Long

'====================================================================
'光隔输入
'======================================================================
'通道数
Declare Function MT_Get_Optic_In_Num Lib "MT_API.dll" (ByRef Value As Long) As Long
'读取单通道值
Declare Function MT_Get_Optic_In_Single Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'读取所有通道值
Declare Function MT_Get_Optic_In_All Lib "MT_API.dll" (ByRef Value As Long) As Long
'====================================================================
'光隔输出
'======================================================================
'通道数
Declare Function MT_Get_Optic_Out_Num Lib "MT_API.dll" (ByRef Value As Long) As Long
'设置单通道值
Declare Function MT_Set_Optic_Out_Single Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'设置所有通道值
Declare Function MT_Set_Optic_Out_All Lib "MT_API.dll" (ByVal Value As Long) As Long


'直线插补
Declare Function MT_Set_Axis_Line_Axis Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Axis_ID0 As Long, ByVal Axis_ID1 As Long) As Long


Declare Function MT_Set_Axis_Line_Acc Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long


Declare Function MT_Set_Axis_Line_Dec Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long


Declare Function MT_Set_Axis_Line_V Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long


Declare Function MT_Set_Axis_Line_Run Lib "MT_API.dll" (ByVal AObj As Integer) As Long


Declare Function MT_Set_Axis_Line_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long


Declare Function MT_Set_Axis_Line_Halt Lib "MT_API.dll" (ByVal AObj As Integer) As Long


Declare Function MT_Set_Axis_Line_Rel Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Axis_Target0 As Long, ByVal Axis_Target1 As Long) As Long


Declare Function MT_Set_Axis_Line_Abs Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Axis_Target0 As Long, ByVal Axis_Target1 As Long) As Long


Declare Function MT_Set_Axis_Line_Run_Rel Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Axis_Target0 As Long, ByVal Axis_Target1 As Long) As Long


Declare Function MT_Set_Axis_Line_Run_Abs Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Axis_Target0 As Long, ByVal Axis_Target1 As Long) As Long


Declare Function MT_Get_Axis_Line_Num Lib "MT_API.dll" (ByVal AObj As Integer, ByRef pValue As Long) As Long


Declare Function MT_Get_Axis_Line_Status Lib "MT_API.dll" (ByVal AObj As Integer, ByRef pValue As Long) As Long


Declare Function MT_Get_Axis_Line_Axis Lib "MT_API.dll" (ByVal AObj As Integer, ByVal pID0 As Long, ByVal pID1 As Long) As Long


Declare Function MT_Get_Axis_Line_Acc Lib "MT_API.dll" (ByVal AObj As Integer, ByRef pValue As Long) As Long


Declare Function MT_Get_Axis_Line_Dec Lib "MT_API.dll" (ByVal AObj As Integer, ByRef pValue As Long) As Long


Declare Function MT_Get_Axis_Line_V Lib "MT_API.dll" (ByVal AObj As Integer, ByRef pValue As Long) As Long


'圆弧插补相关
Declare Function MT_Set_Axis_Circle_Axis Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Axis_ID0 As Long, ByVal Axis_ID1 As Long) As Long


Declare Function MT_Set_Axis_Circle_Acc Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long


Declare Function MT_Set_Axis_Circle_Dec Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long


Declare Function MT_Set_Axis_Circle_V Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long


Declare Function MT_Set_Axis_Circle_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long


Declare Function MT_Set_Axis_Circle_Halt Lib "MT_API.dll" (ByVal AObj As Integer) As Long


Declare Function MT_Set_Axis_Circle_R_CW_Run_Rel Lib "MT_API.dll" (ByVal AObj As Integer, ByVal AR As Long, ByVal Axis_Target0 As Long, ByVal Axis_Target1 As Long) As Long


Declare Function MT_Set_Axis_Circle_R_CW_Run_Abs Lib "MT_API.dll" (ByVal AObj As Integer, ByVal AR As Long, ByVal Axis_Target0 As Long, ByVal Axis_Target1 As Long) As Long


Declare Function MT_Set_Axis_Circle_R_CCW_Run_Rel Lib "MT_API.dll" (ByVal AObj As Integer, ByVal AR As Long, ByVal Axis_Target0 As Long, ByVal Axis_Target1 As Long) As Long


Declare Function MT_Set_Axis_Circle_R_CCW_Run_Abs Lib "MT_API.dll" (ByVal AObj As Integer, ByVal AR As Long, ByVal Axis_Target0 As Long, ByVal Axis_Target1 As Long) As Long


Declare Function MT_Get_Axis_Circle_Num Lib "MT_API.dll" (ByVal AObj As Integer, ByRef pValue As Long) As Long


Declare Function MT_Get_Axis_Circle_Status Lib "MT_API.dll" (ByVal AObj As Integer, ByRef pValue As Long) As Long


Declare Function MT_Get_Axis_Circle_Axis Lib "MT_API.dll" (ByVal AObj As Integer, ByVal pID0 As Long, ByVal pID1 As Long) As Long


Declare Function MT_Get_Axis_Circle_Acc Lib "MT_API.dll" (ByVal AObj As Integer, ByRef pValue As Long) As Long


Declare Function MT_Get_Axis_Circle_Dec Lib "MT_API.dll" (ByVal AObj As Integer, ByRef pValue As Long) As Long


Declare Function MT_Get_Axis_Circle_V Lib "MT_API.dll" (ByVal AObj As Integer, ByRef pValue As Long) As Long
    

