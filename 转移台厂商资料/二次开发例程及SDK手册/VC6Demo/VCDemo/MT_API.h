#ifndef _MT_API_
#define _MT_API_


//Ver3.6

#define R_OK                  0
#define R_Error               -1
#define RUN_OFF               0
#define RUN_ON                1
#define DIR_NEG               0
#define DIR_POS               1
#define LIMIT_ON              1
#define LIMIT_OFF             0

//�����ڲ���Դ����
#define RESOURCE_MOTOR       0x00000001   //���
#define RESOURCE_TTL_IN      0x00000002   //TTL����
#define RESOURCE_TTL_OUT     0x00000004   //TTL���
#define RESOURCE_OPTIC_IN    0x00000008   //�������
#define RESOURCE_OPTIC_OUT   0x00000010   //������



#ifdef __cplusplus
#define MT_API extern "C" __declspec( dllexport )
#else
#define MT_API __declspec( dllexport )
#endif
//==================================================
//���л���
//===================================================
//dll�汾
//��ʼ��ִ�л���
MT_API INT32 /*__stdcall*/  MT_Init(void);
//�رմ���
MT_API INT32 /*__stdcall*/  MT_DeInit(void);
//��ȡdll�汾��
MT_API INT32 /*__stdcall*/   MT_Get_Dll_Version(char** sVer);

//======================================================
//ͨ�ſ�
//======================================================
//�� UART
MT_API INT32 /*__stdcall*/  MT_Open_UART(char* sCOM);
//�ر� UART
MT_API INT32 /*__stdcall*/  MT_Close_UART(void);
//��USB
MT_API INT32 /*__stdcall*/  MT_Open_USB(void);
//�ر�USB
MT_API INT32 /*__stdcall*/  MT_Close_USB(void);
//������
MT_API INT32 /*__stdcall*/  MT_Open_Net(byte IP0,byte IP1,byte IP2,byte IP3,byte IP4,WORD IPPort);
//�ر�����
MT_API INT32 /*__stdcall*/  MT_Close_Net(void);

//=====================================================
//�忨���
//=====================================================
//����豸
MT_API INT32 /*__stdcall*/  MT_Check(void);
//��ȡ��Դģ��
MT_API INT32 /*__stdcall*/  MT_Get_Product_Resource(INT32* pValue);
//��ȡID
MT_API INT32 /*__stdcall*/  MT_Get_Product_ID(char* sID);
//��ȡSN
MT_API INT32 /*__stdcall*/  MT_Get_Product_SN(char* sSN);
//��ȡ�̼��汾��
MT_API INT32 /*__stdcall*/  MT_Get_Product_Version(INT32* pMajor,INT32* pMinor);

//===================================================================
//������
//====================================================================
//����
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Num(INT32* pValue);
//��ȡ���ٶ�
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Acc(WORD AObj,INT32* pValue);
//���ü��ٶ�
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Acc(WORD AObj,INT32 Value);
//��ȡ���ٶ�
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Dec(WORD AObj,INT32* pValue);
//���ü��ٶ�
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Dec(WORD AObj,INT32 Value);
//��ȡ����ģʽ
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Mode(WORD AObj,INT32* pValue);
//�����ٶ�ģʽ
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Mode_Velocity(WORD AObj);
//����λ��ģʽ
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Mode_Position(WORD AObj);
//��ȡ�ٶ�ģʽĿ���ٶ�
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Velocity_V_Target(WORD AObj,INT32* pValue);
//�����ٶ�ģʽĿ���ٶ�
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Velocity_V_Target_Abs(WORD AObj,INT32 Value);
//�����ٶ�ģʽĿ���ٶ�
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Velocity_V_Target_Rel(WORD AObj,INT32 Value);
//ֹͣ�ٶ�ģʽ
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Velocity_Stop(WORD AObj);

//��ȡλ��ģʽ����ٶ�
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Position_V_Max(WORD AObj,INT32* pValue);
//����λ��ģʽ����ٶ�
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Position_V_Max(WORD AObj,INT32 Value);
//��ȡλ��ģʽĿ��
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Position_P_Target(WORD AObj,INT32* pValue);
//����λ��ģʽĿ��
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Position_P_Target_Abs(WORD AObj,INT32 Value);
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Position_P_Target_Rel(WORD AObj,INT32 Value);
//ֹͣλ��ģʽ
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Position_Stop(WORD AObj);
//����ֹͣ
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Halt(WORD AObj);
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Halt_All();

//////////////////////////////////////////////////////////////
///  ״̬���
///  //////////////////////////////////////////////////////
//��ȡ��ǰ�ٶ�
MT_API INT32 /*__stdcall*/  MT_Get_Axis_V_Now(WORD AObj,INT32* pValue);
//��ȡ��ǰ���λ��
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Software_P_Now(WORD AObj,INT32* pValue);
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Software_P(WORD AObj,INT32 Value);
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Status(WORD AObj,
            BYTE* pRun,
            BYTE* pDir,
            BYTE* pNeg,
            BYTE* pPos,
            BYTE* pZero,
            BYTE* pMode);
////////////////////////////////////////////////////////////////////////
//�洢��
//��ȡ�洢������
MT_API INT32 /*__stdcall*/  MT_Get_Param_Mem_Len(INT32* pValue);
//��ȡ�洢������
MT_API INT32 /*__stdcall*/  MT_Get_Param_Mem_Data(WORD AObj,BYTE* pValue);
//���ô洢������
MT_API INT32 /*__stdcall*/  MT_Set_Param_Mem_Data(WORD AObj,BYTE Value);
//�������
MT_API INT32 /*__stdcall*/  MT_Get_Optic_In_Num(INT32* pValue);
MT_API INT32 /*__stdcall*/  MT_Get_Optic_In_Single(WORD AObj,INT32* pValue);
MT_API INT32 /*__stdcall*/  MT_Get_Optic_In_All(INT32* pValue);
//������
MT_API INT32 /*__stdcall*/  MT_Get_Optic_Out_Num(INT32* pValue);
MT_API INT32 /*__stdcall*/  MT_Set_Optic_Out_Single(WORD AObj,INT32 Value);
MT_API INT32 /*__stdcall*/  MT_Set_Optic_Out_All(INT32 Value);

//����0λģʽ
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Mode_Home(WORD AObj);
//����0λģʽĿ���ٶ�
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Home_V(WORD AObj,INT32 Value);
//ֹͣ0λģʽ
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Home_Stop(WORD AObj);


//�����λ
//���������λֵ
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Software_Limit_Neg_Value(WORD AObj,INT32 Value);
//���������λֵ
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Software_Limit_Pos_Value(WORD AObj,INT32 Value);
//ʹ�������λģʽ
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Software_Limit_Enable(WORD AObj);
//ֹͣ�����λģʽ
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Software_Limit_Disable(WORD AObj);


//ֱ�߲岹���
//����ֱ�߲岹���ἰ�ٶ�
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Axis(WORD AObj,INT32 InAxis_ID0,INT32 Axis_ID1);
//����ֱ�߲岹���ٶ�
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Acc(WORD AObj,INT32 Value);
//����ֱ�߲岹���ٶ�
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Dec(WORD AObj,INT32 Value);
//����ֱ�߲岹�ٶ�
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_V(WORD AObj,INT32 Value);
//����ֱ�߲岹����
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Run(WORD AObj);
//����ֱ�߲岹ֹͣ
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Stop(WORD AObj);
//����ֱ�߲岹��ͣ
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Halt(WORD AObj);
//����ֱ�߲岹����ƶ�Ŀ��
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Rel(WORD AObj,INT32 Axis_Target0,INT32 Axis_Target1);
//����ֱ�߲岹�����ƶ�Ŀ��
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Abs(WORD AObj,INT32 Axis_Target0,INT32 Axis_Target1);
//����ֱ�߲岹����
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Run_Rel(WORD AObj,INT32 Axis_Target0,INT32 Axis_Target1);
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Run_Abs(WORD AObj,INT32 Axis_Target0,INT32 Axis_Target1);
//��ȡֱ�߲岹ģ��
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Line_Num(INT32* pValue);
//�岹�˶�״̬
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Line_Status(WORD AObj,INT32* pValue);
//�岹��
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Line_Axis(WORD AObj,INT32* pID0,INT32* pID1);
//�岹���ٶ�
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Line_Acc(WORD AObj,INT32* pValue);
//�岹���ٶ�
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Line_Dec(WORD AObj,INT32* pValue);
//�岹�ٶ�
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Line_V(WORD AObj,INT32* pValue);

//AD����
MT_API INT32 /*__stdcall*/ MT_Get_AD_Num(INT32* pValue);
MT_API INT32 /*__stdcall*/ MT_Get_AD_Data(WORD AObj,INT32* pValue);
MT_API INT32 /*__stdcall*/ MT_Get_Board_T(INT32* pValue);

//================================================================
//Բ���岹
//================================================================
//����Բ���岹���ἰ�ٶ�
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_Axis(WORD AObj,INT32* Axis_ID0,INT32* Axis_ID1);
//����Բ���岹���ٶ�
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_Acc(WORD AObj,INT32 Value);
//����Բ���岹���ٶ�
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_Dec(WORD AObj,INT32 Value);
//����Բ���岹�ٶ�
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_V(WORD AObj,INT32 Value);

//����Բ���岹���� ˳ʱ��  Բ������ģʽ
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_R_CW_Run_Rel(WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_R_CW_Run_Abs(WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);
//����Բ���岹���� ��ʱ��   Բ������
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_R_CCW_Run_Rel(WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_R_CCW_Run_Abs(WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);
//����Բ���岹ֹͣ
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_Stop(WORD AObj);
//����Բ���岹��ͣ
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_Halt(WORD AObj);

//��ȡԲ���岹ģ��
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Circle_Num(INT32* pValue);
//�岹�˶�״̬
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Circle_Status(WORD AObj,INT32* pValue);
//�岹��
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Circle_Axis(WORD AObj,INT32* pID0,INT32* pID1);
//�岹���ٶ�
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Circle_Acc(WORD AObj,INT32* pValue);
//�岹���ٶ�
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Circle_Dec(WORD AObj,INT32* pValue);
//�岹�ٶ�
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Circle_V(WORD AObj,INT32* pValue);





#endif