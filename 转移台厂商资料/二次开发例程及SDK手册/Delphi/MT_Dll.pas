unit MT_Dll;
//**************************************************//
// Easy tech copyright
//**************************************************//
interface
//==================================================
//���л���
//===================================================
//dll�汾
//��ʼ������
function MT_Init():Integer;cdecl;external 'MT_API.dll'
//�رմ���
function MT_DeInit():Integer;cdecl;external 'MT_API.dll'
//��ȡdll�汾��
function MT_Get_Dll_Version(sVer:PPChar):Integer;cdecl;external 'MT_API.dll'



//======================================================
//ͨ�ſ�
//======================================================
//�� UART
function MT_Open_UART(sCOM:PChar):Integer;cdecl;external 'MT_API.dll'
//�ر� UART
function MT_Close_UART():Integer;cdecl;external 'MT_API.dll'
//��USB
function MT_Open_USB:Integer;cdecl;external 'MT_API.dll'
//�ر�USB
function MT_Close_USB:Integer;cdecl;external 'MT_API.dll'


//=====================================================
//�忨���
//=====================================================
//����豸
function MT_Check():Integer;cdecl;external 'MT_API.dll'
//��ȡ��Դģ��
function MT_Get_Product_Resource(pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//��ȡID
function MT_Get_Product_ID(sID:PAnsiChar):Integer;cdecl;external 'MT_API.dll'
//��ȡSN
function MT_Get_Product_SN(sSN:PAnsiChar):Integer;cdecl;external 'MT_API.dll'
//��ȡ�̼��汾��
function MT_Get_Product_Version(pMajor:PInteger;pMinor:PInteger):Integer;cdecl;external 'MT_API.dll'
//===================================================================
//�忨�¶�
//===================================================================
//��ȡ�¶�
function MT_Get_Board_Temperature(pValue:PDouble):Integer;cdecl;external 'MT_API.dll'

//===================================================================
//������
//====================================================================
//����
function MT_Get_Axis_Num(pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//��ȡ���ٶ�
function MT_Get_Axis_Acc(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//���ü��ٶ�
function MT_Set_Axis_Acc(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//��ȡ���ٶ�
function MT_Get_Axis_Dec(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//���ü��ٶ�
function MT_Set_Axis_Dec(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//��ȡ����ģʽ
function MT_Get_Axis_Mode(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//�����ٶ�ģʽ
function MT_Set_Axis_Mode_Velocity(AObj:Word):Integer;cdecl;external 'MT_API.dll'
//����λ��ģʽ
function MT_Set_Axis_Mode_Position(AObj:Word):Integer;cdecl;external 'MT_API.dll'
//��ȡ�ٶ�ģʽĿ���ٶ�
function MT_Get_Axis_Velocity_V_Target(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//�����ٶ�ģʽĿ���ٶ�
function MT_Set_Axis_Velocity_V_Target_Abs(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//�����ٶ�ģʽĿ���ٶ�
function MT_Set_Axis_Velocity_V_Target_Rel(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//ֹͣ�ٶ�ģʽ
function MT_Set_Axis_Velocity_Stop(AObj:Word):Integer;cdecl;external 'MT_API.dll'

//��ȡλ��ģʽ����ٶ�
function MT_Get_Axis_Position_V_Max(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//����λ��ģʽ����ٶ�
function MT_Set_Axis_Position_V_Max(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//��ȡλ��ģʽĿ��
function MT_Get_Axis_Position_P_Target(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//����λ��ģʽĿ��
function MT_Set_Axis_Position_P_Target_Abs(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
function MT_Set_Axis_Position_P_Target_Rel(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//ֹͣλ��ģʽ
function MT_Set_Axis_Position_Stop(AObj:Word):Integer;cdecl;external 'MT_API.dll'
//����ֹͣ
function MT_Set_Axis_Halt(AObj:Word):Integer;cdecl;external 'MT_API.dll'
function MT_Set_Axis_Halt_All():Integer;cdecl;external 'MT_API.dll'

//////////////////////////////////////////////////////////////
///  ״̬���
///  //////////////////////////////////////////////////////
//��ȡ��ǰ�ٶ�
function MT_Get_Axis_V_Now(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//��ȡ��ǰ���λ��
function MT_Get_Axis_Software_P_Now(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
function MT_Set_Axis_Software_P(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
function MT_Get_Axis_Status(AObj:Word;
            pRun:PBoolean;
            pDir:PBoolean;
            pNeg:PBoolean;
            pPos:PBoolean;
            pZero:PBoolean;
            pMode:PByte):Integer;cdecl;external 'MT_API.dll'
////////////////////////////////////////////////////////////////////////
//�洢��
//��ȡ�洢������
function MT_Get_Param_Mem_Len(pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//��ȡ�洢������
function MT_Get_Param_Mem_Data(AObj:Word;pValue:PByte):Integer;cdecl;external 'MT_API.dll'
//���ô洢������
function MT_Set_Param_Mem_Data(AObj:Word;Value:Byte):Integer;cdecl;external 'MT_API.dll'
//�������
function MT_Get_Optic_In_Num(pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
function MT_Get_Optic_In_Single(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
function MT_Get_Optic_In_All(pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//������
function MT_Get_Optic_Out_Num(pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
function MT_Set_Optic_Out_Single(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
function MT_Set_Optic_Out_All(Value:Integer):Integer;cdecl;external 'MT_API.dll'

//����0λģʽ
function MT_Set_Axis_Mode_Home(AObj:Word):Integer;cdecl;external 'MT_API.dll'
//����0λģʽĿ���ٶ�
function MT_Set_Axis_Home_V(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//ֹͣ0λģʽ
function MT_Set_Axis_Home_Stop(AObj:Word):Integer;cdecl;external 'MT_API.dll'


//�����λ
//���������λֵ
function MT_Set_Axis_Software_Limit_Neg_Value
   (AObj:Word;Value:Integer):Integer;cdecl; external 'MT_API.dll'
//���������λֵ
function MT_Set_Axis_Software_Limit_Pos_Value
   (AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//ʹ�������λģʽ
function MT_Set_Axis_Software_Limit_Enable(AObj:Word):Integer;cdecl;external 'MT_API.dll'
//ֹͣ�����λģʽ
function MT_Set_Axis_Software_Limit_Disable(AObj:Word):Integer;cdecl;external 'MT_API.dll'

  const R_OK =0;
  const R_Error=-1;
  const RUN_OFF=0;
  const RUN_ON=1;
  const DIR_NEG=0;
  const DIR_POS=1;
  const LIMIT_ON=1;
  const LIMIT_OFF=0;

//�����ڲ���Դ����
const RESOURCE_MOTOR       =$00000001;   //���
const RESOURCE_TTL_IN      =$00000002;   //TTL����
const RESOURCE_TTL_OUT     =$00000004;   //TTL���
const RESOURCE_OPTIC_IN    =$00000008;   //�������
const RESOURCE_OPTIC_OUT   =$00000010;   //������
implementation

end.
