#ifndef _MT_API_
#define _MT_API_

#ifdef __cplusplus
#define MT_API extern "C" __declspec( dllexport )
#else
#define MT_API __declspec( dllexport )
#endif


MT_API int __stdcall MT_Init(void);

MT_API int __stdcall MT_DeInit(void);

MT_API int __stdcall MT_Open_UART(char* sCOM);

MT_API int __stdcall MT_Close_UART(void);

MT_API int __stdcall MT_Open_USB(void);

MT_API int __stdcall MT_Close_USB(void);

MT_API int __stdcall MT_Open_Net(unsigned char IP0,unsigned char IP1,unsigned char IP2,unsigned char IP3,unsigned short IPPort);

MT_API int __stdcall MT_Close_Net(void);

MT_API int __stdcall MT_Check(void);

MT_API int __stdcall MT_Get_Product_Resource(int* pValue);

MT_API int __stdcall MT_Get_Product_ID(char* sID);

MT_API int __stdcall MT_Get_Product_SN(char* sSN);

MT_API int __stdcall MT_Get_Product_SN2(unsigned char* sSN);

MT_API int __stdcall MT_Get_Product_SN3(char* sSN);

MT_API int __stdcall MT_Get_Product_Version(int* pMajor,int* pMinor);

MT_API int __stdcall MT_Get_Product_Version2(int* pMajor,int* pMinor,int* pRelease,int* pBuild);

MT_API int __stdcall MT_Get_Axis_Num(int* pValue);

MT_API int __stdcall MT_Get_Axis_Acc(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Acc(unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Dec(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Dec(unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Mode(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Mode_Velocity(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Position(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Position_Open(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Position_Close(unsigned short AObj);

MT_API int __stdcall MT_Get_Axis_Velocity_V_Target(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Velocity_V_Target_Abs(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Velocity_V_Target_Rel(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Velocity_Stop(unsigned short AObj);

MT_API int __stdcall MT_Get_Axis_Position_V_Max(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Position_V_Max(unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Position_P_Target(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Position_P_Target_Abs(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Position_P_Target_Rel(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Position_Stop(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Position_Close_Dec_Factor(unsigned short AObj,float AFactor);

MT_API int __stdcall MT_Set_Axis_Halt(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Halt_All(void);

MT_API int __stdcall MT_Get_Axis_V_Now(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Software_P_Now(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Software_P(unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Status(unsigned short AObj,unsigned char* pRun,unsigned char* pDir,unsigned char* pNeg,unsigned char* pPos,unsigned char* pZero,unsigned char* pMode);

MT_API int __stdcall MT_Get_Axis_Status2(unsigned short AObj,int* pRun,int* pDir,int* pNeg,int* pPos,int* pZero,int* pMode);

MT_API int __stdcall MT_Get_Axis_Status_Run(unsigned short AObj,int* pRun);

MT_API int __stdcall MT_Get_Axis_Status_Dir(unsigned short AObj,int* pDir);

MT_API int __stdcall MT_Get_Axis_Status_Neg(unsigned short AObj,int* pNeg);

MT_API int __stdcall MT_Get_Axis_Status_Pos(unsigned short AObj,int* pPos);

MT_API int __stdcall MT_Get_Axis_Status_Zero(unsigned short AObj,int* pZero);

MT_API int __stdcall MT_Get_Axis_Status_Mode(unsigned short AObj,int* pMode);

MT_API int __stdcall MT_Get_Param_Mem_Len(int* pValue);

MT_API int __stdcall MT_Get_Param_Mem_Data(unsigned short AObj,unsigned char* pValue);

MT_API int __stdcall MT_Set_Param_Mem_Data(unsigned short AObj,unsigned char Value);

MT_API int __stdcall MT_Get_System_Mem_Len(int* pValue);

MT_API int __stdcall MT_Get_System_Mem_Data(unsigned short AObj,unsigned char* pValue);

MT_API int __stdcall MT_Set_System_Mem_Data(unsigned short AObj,unsigned char Value);

MT_API int __stdcall MT_Get_Optic_In_Num(int* pValue);

MT_API int __stdcall MT_Get_Optic_In_Basic_Num(int* pValue);

MT_API int __stdcall MT_Get_Optic_In_Single(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Optic_In_All(int* pValue);

MT_API int __stdcall MT_Get_Optic_Out_Num(int* pValue);

MT_API int __stdcall MT_Set_Optic_Out_Single(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Optic_Out_All(int Value);

MT_API int __stdcall MT_Get_Optic_Out_Single(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Optic_Out_All(int* pValue);

MT_API int __stdcall MT_Get_OC_Out_Num(int* pValue);

MT_API int __stdcall MT_Set_OC_Out_Single(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_OC_Out_All(int Value);

MT_API int __stdcall MT_Get_OC_Out_Single(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_OC_Out_All(int* pValue);

MT_API int __stdcall MT_Set_Axis_Mode_Home(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Home_Home_Switch(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Home_Encoder_Index(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Home_Encoder_Home_Switch(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Home_Home_Zero(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Home_V(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Home_Stop(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Software_Limit_Neg_Value(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Software_Limit_Pos_Value(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Software_Limit_Enable(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Software_Limit_Disable(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Line_Axis(unsigned short AObj,int Axis_ID0,int Axis_ID1);

MT_API int __stdcall MT_Set_Axis_Line_Acc(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Line_Dec(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Line_V(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Line_Run(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Line_Stop(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Line_Halt(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Line_Rel(unsigned short AObj,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Line_Abs(unsigned short AObj,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Line_Run_Rel(unsigned short AObj,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Line_Run_Abs(unsigned short AObj,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Get_Axis_Line_Num(int* pValue);

MT_API int __stdcall MT_Get_Axis_Line_Status(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Line_Axis(unsigned short AObj,int* pID0,int* pID1);

MT_API int __stdcall MT_Get_Axis_Line_Acc(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Line_Dec(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Line_V(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_AD_Num(int* pValue);

MT_API int __stdcall MT_Get_AD_Data(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Board_T(int* pValue);

MT_API int __stdcall MT_Set_Axis_Circle_Axis(unsigned short AObj,int Axis_ID0,int Axis_ID1);

MT_API int __stdcall MT_Set_Axis_Circle_Acc(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Circle_Dec(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Circle_V(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Circle_R_CW_Run_Rel(unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Circle_R_CW_Run_Abs(unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Circle_R_CCW_Run_Rel(unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Circle_R_CCW_Run_Abs(unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Circle_Stop(unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Circle_Halt(unsigned short AObj);

MT_API int __stdcall MT_Get_Axis_Circle_Num(int* pValue);

MT_API int __stdcall MT_Get_Axis_Circle_Status(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Circle_Axis(unsigned short AObj,int* pID0,int* pID1);

MT_API int __stdcall MT_Get_Axis_Circle_Acc(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Circle_Dec(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Circle_V(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_PLC_Var_Num(int* pValue);

MT_API int __stdcall MT_Get_PLC_Var_Data(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_PLC_Var_Data(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_PLC_Pause(void);

MT_API int __stdcall MT_Set_PLC_Stop(void);

MT_API int __stdcall MT_Set_PLC_Run(void);

MT_API int __stdcall MT_Set_PLC_Data(unsigned short AObj,unsigned char Value);

MT_API int __stdcall MT_Get_PLC_Code_Size(int* pValue);

MT_API int __stdcall MT_Get_PLC_Task_Count(int* pValue);

MT_API int __stdcall MT_Get_PLC_Task_Status(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_PLC_Var_Seg(int* pValue);

MT_API int __stdcall MT_Get_PLC_Var_Used(int* pValue);

MT_API int __stdcall MT_Get_PLC_Status(int* pValue);

MT_API int __stdcall MT_Get_PLC_Tasks_Status(int* pValue);

MT_API int __stdcall MT_Get_PLC_Axis_Ratio(unsigned short AObj,float* pValue);

MT_API int __stdcall MT_Get_PLC_Encoder_Ratio(unsigned short AObj,float* pValue);

MT_API int __stdcall MT_Set_Axis_Home_V_Start(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Home_Acc(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Home_Dec(unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Home_Acc(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Home_Dec(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Velocity_V_Start(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Velocity_Acc(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Velocity_Dec(unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Velocity_Acc(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Velocity_Dec(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Position_V_Start(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Position_Acc(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Position_Dec(unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Position_Acc(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Position_Dec(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Line_V_Start(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Circle_V_Start(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Line_X_Run_Rel(unsigned short AObj,int AAxis_Num,int* pAxis,int* pTarget);

MT_API int __stdcall MT_Set_Axis_Line_X_Run_Abs(unsigned short AObj,int AAxis_Num,int* pAxis,int* pTarget);

MT_API int __stdcall MT_Set_Axis_Line_X_Target_Rel(unsigned short AObj,int AAxisID,int ATarget);

MT_API int __stdcall MT_Set_Axis_Line_X_Target_Abs(unsigned short AObj,int AAxisID,int ATarget);

MT_API int __stdcall MT_Set_Axis_Line_X_Count(unsigned short AObj,int ANum);

MT_API int __stdcall MT_Set_Axis_Line_X_Axis(unsigned short AObj,int AAxisID,int AAxis);

MT_API int __stdcall MT_Set_Stream_Run(void);

MT_API int __stdcall MT_Set_Stream_Stop(void);

MT_API int __stdcall MT_Set_Stream_Pause(void);

MT_API int __stdcall MT_Set_Stream_Clear(void);

MT_API int __stdcall MT_Get_Stream_Space(int* pValue);

MT_API int __stdcall MT_Get_Stream_Total(int* pValue);

MT_API int __stdcall MT_Get_Stream_Count(int* pValue);

MT_API int __stdcall MT_Set_Stream_Delay(int Value);

MT_API int __stdcall MT_Set_Stream_Line_Acc(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Line_Dec(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Line_V_Max(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Line_V_Start(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Line_Stop(unsigned short AObj);

MT_API int __stdcall MT_Set_Stream_Line_Halt(unsigned short AObj);

MT_API int __stdcall MT_Set_Stream_Line_X_Run_Rel(unsigned short AObj,int AAxis_Num,int* pAxis,int* pTarget);

MT_API int __stdcall MT_Set_Stream_Line_X_Run_Abs(unsigned short AObj,int AAxis_Num,int* pAxis,int* pTarget);

MT_API int __stdcall MT_Set_Stream_Circle_Axis(unsigned short AObj,int Axis_ID0,int Axis_ID1);

MT_API int __stdcall MT_Set_Stream_Circle_Acc(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Circle_Dec(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Circle_V_Max(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Circle_V_Start(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Circle_R_CW_Run_Rel(unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Stream_Circle_R_CW_Run_Abs(unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Stream_Circle_R_CCW_Run_Rel(unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Stream_Circle_R_CCW_Run_Abs(unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Stream_Circle_Stop(unsigned short AObj);

MT_API int __stdcall MT_Set_Stream_Circle_Halt(unsigned short AObj);

MT_API int __stdcall MT_Set_Stream_Wait_Line(unsigned short AObj);

MT_API int __stdcall MT_Set_Stream_Wait_Circle(unsigned short AObj);

MT_API int __stdcall MT_Set_Stream_OC_Out_Single(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_OC_Out_All(int Value);

MT_API int __stdcall MT_Set_Stream_Optic_Out_Single(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Optic_Out_All(int Value);

MT_API int __stdcall MT_Set_Stream_Wait_Optic_In(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Run_Check(void);

MT_API int __stdcall MT_Set_Stream_Dec_Enable(void);

MT_API int __stdcall MT_Set_Stream_Dec_Disable(void);

MT_API int __stdcall MT_Get_Encoder_Num(int* pValue);

MT_API int __stdcall MT_Get_Encoder_Pos(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Encoder_Pos(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Encoder_Z_Polarity(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Encoder_Dir_Polarity(unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Encoder_Index_Line_Count(unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Encoder_Over_Enable(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Encoder_Over_Max(unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Encoder_Over_Stable(unsigned short AObj,int Value);

MT_API int __stdcall MT_Help_Step_Line_Real_To_Steps(double AStepAngle,int ADiv,double APitch,double ALineRatio,double AValue);

MT_API int __stdcall MT_Help_Step_Circle_Real_To_Steps(double AStepAngle,int ADiv,double ACircleRatio,double AValue);

MT_API double __stdcall MT_Help_Step_Line_Steps_To_Real(double AStepAngle,int ADiv,double APitch,double ALineRatio,int AValue);

MT_API double __stdcall MT_Help_Step_Circle_Steps_To_Real(double AStepAngle,int ADiv,double ACircleRatio,int AValue);

MT_API int __stdcall MT_Help_Encoder_Line_Real_To_Steps(double APitch,double ALineRatio,int ALineCount,double AValue);

MT_API int __stdcall MT_Help_Encoder_Circle_Real_To_Steps(double ACircleRatio,int ALineCount,double AValue);

MT_API double __stdcall MT_Help_Encoder_Line_Steps_To_Real(double APitch,double ALineRatio,int ALineCount,int AValue);

MT_API double __stdcall MT_Help_Encoder_Circle_Steps_To_Real(double ACircleRatio,int ALineCount,int AValue);

MT_API int __stdcall MT_Help_Grating_Line_Real_To_Steps(double AUnit_um,double AValue);

MT_API int __stdcall MT_Help_Grating_Circle_Real_To_Steps(int ALineCount,double AValue);

MT_API double __stdcall MT_Help_Grating_Line_Steps_To_Real(double AUnit_um,int AValue);

MT_API double __stdcall MT_Help_Grating_Circle_Steps_To_Real(int ALineCount,int AValue);

MT_API float __stdcall MT_Help_Encoder_Factor(double AStepAngle,int ADiv,int ALineCount);

MT_API float __stdcall MT_Help_Grating_Line_Factor(double AStepAngle,int ADiv,double APitch,double ALineRatio,double AUnit_um);

MT_API float __stdcall MT_Help_Grating_Circle_Factor(double AStepAngle,int ADiv,double ACircleRatio,int ALineCount);

#endif

