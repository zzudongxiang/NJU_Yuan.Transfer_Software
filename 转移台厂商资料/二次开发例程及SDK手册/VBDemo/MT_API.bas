Attribute VB_Name = "MoTech"
'==================================================
'2014 04 22 ���½ӿ��ļ��� MT_API.dll v3.6
'����ֱ�߲岹��Բ���岹��ض���
'�Ϻ�Сī�Ƽ����޹�˾��Ȩ����
'===================================================

Option Explicit

'==================================================
'���л���
'===================================================
'dll�汾
'��ʼ������
Declare Function MT_Init Lib "MT_API.dll" () As Long
'�رմ���
Declare Function MT_DeInit Lib "MT_API.dll" () As Long
'��ȡdll�汾��
Declare Function MT_Get_Dll_Version Lib "MT_API.dll" (ByRef sVer As String) As Long



'======================================================
'ͨ�ſ�
'======================================================
'�� UART
Declare Function MT_Open_UART Lib "MT_API.dll" (ByVal sCOM As String) As Long
'�ر� UART
Declare Function MT_Close_UART Lib "MT_API.dll" () As Long
'��USB
Declare Function MT_Open_USB Lib "MT_API.dll" () As Long
'�ر�USB
Declare Function MT_Close_USB Lib "MT_API.dll" () As Long


'=====================================================
'�忨���
'=====================================================
'����豸
Declare Function MT_Check Lib "MT_API.dll" () As Long
'��ȡ��Դģ��
Declare Function MT_Get_Product_Resource Lib "MT_API.dll" (ByRef Value As Long) As Long
'��ȡID
Declare Function MT_Get_Product_ID Lib "MT_API.dll" (ByRef sID As String) As Long
'��ȡSN
Declare Function MT_Get_Product_SN Lib "MT_API.dll" (ByRef sSN As String) As Long
'��ȡ�̼��汾��
Declare Function MT_Get_Product_Version Lib "MT_API.dll" (ByRef Major As Long, ByRef Minor As Long) As Long

'===================================================================
'������
'====================================================================
'����
Declare Function MT_Get_Axis_Num Lib "MT_API.dll" (ByRef Value As Long) As Long
'��ȡ���ٶ�
Declare Function MT_Get_Axis_Acc Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'���ü��ٶ�
Declare Function MT_Set_Axis_Acc Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'��ȡ���ٶ�
Declare Function MT_Get_Axis_Dec Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'���ü��ٶ�
Declare Function MT_Set_Axis_Dec Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'��ȡ����ģʽ
Declare Function MT_Get_Axis_Mode Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'�����ٶ�ģʽ
Declare Function MT_Set_Axis_Mode_Velocity Lib "MT_API.dll" (ByVal AObj As Integer) As Long
'����λ��ģʽ
Declare Function MT_Set_Axis_Mode_Position Lib "MT_API.dll" (ByVal AObj As Integer) As Long
'��ȡ�ٶ�ģʽĿ���ٶ�
Declare Function MT_Get_Axis_Velocity_V_Target Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'�����ٶ�ģʽĿ���ٶ�
Declare Function MT_Set_Axis_Velocity_V_Target_Abs Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'�����ٶ�ģʽĿ���ٶ�
Declare Function MT_Set_Axis_Velocity_V_Target_Rel Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'ֹͣ�ٶ�ģʽ
Declare Function MT_Set_Axis_Velocity_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long

'��ȡλ��ģʽ����ٶ�
Declare Function MT_Get_Axis_Position_V_Max Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'����λ��ģʽ����ٶ�
Declare Function MT_Set_Axis_Position_V_Max Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'��ȡλ��ģʽĿ��
Declare Function MT_Get_Axis_Position_P_Target Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'����λ��ģʽĿ��
Declare Function MT_Set_Axis_Position_P_Target_Abs Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
Declare Function MT_Set_Axis_Position_P_Target_Rel Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'ֹͣλ��ģʽ
Declare Function MT_Set_Axis_Position_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long
'����ֹͣ
Declare Function MT_Set_Axis_Halt Lib "MT_API.dll" (ByVal AObj As Integer) As Long
Declare Function MT_Set_Axis_Halt_All Lib "MT_API.dll" () As Long

'''''''''''''''''''''''''''''''
'/  ״̬���
'/  '''''''''''''''''''''''''''
'��ȡ��ǰ�ٶ�
Declare Function MT_Get_Axis_V_Now Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'��ȡ��ǰ���λ��
Declare Function MT_Get_Axis_Software_P_Now Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'�������λ��
Declare Function MT_Set_Axis_Software_P Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long

Declare Function MT_Get_Axis_Status Lib "MT_API.dll" _
   (ByVal AObj As Integer, ByRef Run As Byte, ByRef Dir As Byte, _
   ByRef Neg As Byte, ByRef Pos As Byte, ByRef Zero As Byte, ByRef Mode As Byte) As Long


'����0λģʽ
Declare Function MT_Set_Axis_Mode_Home Lib "MT_API.dll" (ByVal AObj As Integer) As Long
'����0λģʽĿ���ٶ�
Declare Function MT_Set_Axis_Home_V Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'ֹͣ0λģʽ
Declare Function MT_Set_Axis_Home_Stop Lib "MT_API.dll" (ByVal AObj As Integer) As Long


'�����λ
'���������λֵ
Declare Function MT_Set_Axis_Software_Limit_Neg_Value Lib "MT_API.dll" _
    (ByVal AObj As Integer, ByVal Value As Long) As Long
'���������λֵ
Declare Function MT_Set_Axis_Software_Limit_Pos_Value Lib "MT_API.dll" _
    (ByVal AObj As Integer, ByVal Value As Long) As Long
'ʹ�������λģʽ
Declare Function MT_Set_Axis_Software_Limit_Enable Lib "MT_API.dll" (ByVal AObj As Integer) As Long
'ֹͣ�����λģʽ
Declare Function MT_Set_Axis_Software_Limit_Disable Lib "MT_API.dll" (ByVal AObj As Integer) As Long
''''''''''''''''''''''''''''''''''''
'�洢��
'��ȡ�洢������
Declare Function MT_Get_Param_Mem_Len Lib "MT_API.dll" (ByRef Value As Long) As Long
'��ȡ�洢������
Declare Function MT_Get_Param_Mem_Data Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Byte) As Long
'���ô洢������
Declare Function MT_Set_Param_Mem_Data Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Byte) As Long

'====================================================================
'�������
'======================================================================
'ͨ����
Declare Function MT_Get_Optic_In_Num Lib "MT_API.dll" (ByRef Value As Long) As Long
'��ȡ��ͨ��ֵ
Declare Function MT_Get_Optic_In_Single Lib "MT_API.dll" (ByVal AObj As Integer, ByRef Value As Long) As Long
'��ȡ����ͨ��ֵ
Declare Function MT_Get_Optic_In_All Lib "MT_API.dll" (ByRef Value As Long) As Long
'====================================================================
'������
'======================================================================
'ͨ����
Declare Function MT_Get_Optic_Out_Num Lib "MT_API.dll" (ByRef Value As Long) As Long
'���õ�ͨ��ֵ
Declare Function MT_Set_Optic_Out_Single Lib "MT_API.dll" (ByVal AObj As Integer, ByVal Value As Long) As Long
'��������ͨ��ֵ
Declare Function MT_Set_Optic_Out_All Lib "MT_API.dll" (ByVal Value As Long) As Long


'ֱ�߲岹
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


'Բ���岹���
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
    

