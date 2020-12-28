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

//定义内部资源类型
#define RESOURCE_MOTOR       0x00000001   //电机
#define RESOURCE_TTL_IN      0x00000002   //TTL输入
#define RESOURCE_TTL_OUT     0x00000004   //TTL输出
#define RESOURCE_OPTIC_IN    0x00000008   //光隔输入
#define RESOURCE_OPTIC_OUT   0x00000010   //光隔输出



#ifdef __cplusplus
#define MT_API extern "C" __declspec( dllexport )
#else
#define MT_API __declspec( dllexport )
#endif
//==================================================
//运行环境
//===================================================
//dll版本
//初始化执行环境
MT_API INT32 /*__stdcall*/  MT_Init(void);
//关闭窗口
MT_API INT32 /*__stdcall*/  MT_DeInit(void);
//获取dll版本号
MT_API INT32 /*__stdcall*/   MT_Get_Dll_Version(char** sVer);

//======================================================
//通信口
//======================================================
//打开 UART
MT_API INT32 /*__stdcall*/  MT_Open_UART(char* sCOM);
//关闭 UART
MT_API INT32 /*__stdcall*/  MT_Close_UART(void);
//打开USB
MT_API INT32 /*__stdcall*/  MT_Open_USB(void);
//关闭USB
MT_API INT32 /*__stdcall*/  MT_Close_USB(void);
//打开网络
MT_API INT32 /*__stdcall*/  MT_Open_Net(byte IP0,byte IP1,byte IP2,byte IP3,byte IP4,WORD IPPort);
//关闭网络
MT_API INT32 /*__stdcall*/  MT_Close_Net(void);

//=====================================================
//板卡检测
//=====================================================
//检测设备
MT_API INT32 /*__stdcall*/  MT_Check(void);
//读取资源模块
MT_API INT32 /*__stdcall*/  MT_Get_Product_Resource(INT32* pValue);
//获取ID
MT_API INT32 /*__stdcall*/  MT_Get_Product_ID(char* sID);
//获取SN
MT_API INT32 /*__stdcall*/  MT_Get_Product_SN(char* sSN);
//读取固件版本号
MT_API INT32 /*__stdcall*/  MT_Get_Product_Version(INT32* pMajor,INT32* pMinor);

//===================================================================
//电机相关
//====================================================================
//轴数
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Num(INT32* pValue);
//读取加速度
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Acc(WORD AObj,INT32* pValue);
//设置加速度
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Acc(WORD AObj,INT32 Value);
//读取加速度
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Dec(WORD AObj,INT32* pValue);
//设置加速度
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Dec(WORD AObj,INT32 Value);
//读取工作模式
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Mode(WORD AObj,INT32* pValue);
//设置速度模式
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Mode_Velocity(WORD AObj);
//设置位置模式
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Mode_Position(WORD AObj);
//读取速度模式目标速度
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Velocity_V_Target(WORD AObj,INT32* pValue);
//设置速度模式目标速度
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Velocity_V_Target_Abs(WORD AObj,INT32 Value);
//设置速度模式目标速度
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Velocity_V_Target_Rel(WORD AObj,INT32 Value);
//停止速度模式
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Velocity_Stop(WORD AObj);

//读取位置模式最大速度
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Position_V_Max(WORD AObj,INT32* pValue);
//设置位置模式最大速度
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Position_V_Max(WORD AObj,INT32 Value);
//读取位置模式目标
MT_API INT32 /*__stdcall*/  MT_Get_Axis_Position_P_Target(WORD AObj,INT32* pValue);
//设置位置模式目标
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Position_P_Target_Abs(WORD AObj,INT32 Value);
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Position_P_Target_Rel(WORD AObj,INT32 Value);
//停止位置模式
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Position_Stop(WORD AObj);
//紧急停止
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Halt(WORD AObj);
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Halt_All();

//////////////////////////////////////////////////////////////
///  状态相关
///  //////////////////////////////////////////////////////
//读取当前速度
MT_API INT32 /*__stdcall*/  MT_Get_Axis_V_Now(WORD AObj,INT32* pValue);
//读取当前软件位置
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
//存储器
//读取存储器长度
MT_API INT32 /*__stdcall*/  MT_Get_Param_Mem_Len(INT32* pValue);
//读取存储器数据
MT_API INT32 /*__stdcall*/  MT_Get_Param_Mem_Data(WORD AObj,BYTE* pValue);
//设置存储器数据
MT_API INT32 /*__stdcall*/  MT_Set_Param_Mem_Data(WORD AObj,BYTE Value);
//光隔输入
MT_API INT32 /*__stdcall*/  MT_Get_Optic_In_Num(INT32* pValue);
MT_API INT32 /*__stdcall*/  MT_Get_Optic_In_Single(WORD AObj,INT32* pValue);
MT_API INT32 /*__stdcall*/  MT_Get_Optic_In_All(INT32* pValue);
//光隔输出
MT_API INT32 /*__stdcall*/  MT_Get_Optic_Out_Num(INT32* pValue);
MT_API INT32 /*__stdcall*/  MT_Set_Optic_Out_Single(WORD AObj,INT32 Value);
MT_API INT32 /*__stdcall*/  MT_Set_Optic_Out_All(INT32 Value);

//设置0位模式
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Mode_Home(WORD AObj);
//设置0位模式目标速度
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Home_V(WORD AObj,INT32 Value);
//停止0位模式
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Home_Stop(WORD AObj);


//软件限位
//设置软件限位值
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Software_Limit_Neg_Value(WORD AObj,INT32 Value);
//设置软件限位值
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Software_Limit_Pos_Value(WORD AObj,INT32 Value);
//使能软件限位模式
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Software_Limit_Enable(WORD AObj);
//停止软件限位模式
MT_API INT32 /*__stdcall*/  MT_Set_Axis_Software_Limit_Disable(WORD AObj);


//直线插补相关
//设置直线插补主轴及速度
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Axis(WORD AObj,INT32 InAxis_ID0,INT32 Axis_ID1);
//设置直线插补加速度
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Acc(WORD AObj,INT32 Value);
//设置直线插补减速度
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Dec(WORD AObj,INT32 Value);
//设置直线插补速度
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_V(WORD AObj,INT32 Value);
//设置直线插补启动
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Run(WORD AObj);
//设置直线插补停止
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Stop(WORD AObj);
//设置直线插补急停
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Halt(WORD AObj);
//设置直线插补相对移动目标
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Rel(WORD AObj,INT32 Axis_Target0,INT32 Axis_Target1);
//设置直线插补绝对移动目标
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Abs(WORD AObj,INT32 Axis_Target0,INT32 Axis_Target1);
//设置直线插补启动
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Run_Rel(WORD AObj,INT32 Axis_Target0,INT32 Axis_Target1);
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Line_Run_Abs(WORD AObj,INT32 Axis_Target0,INT32 Axis_Target1);
//读取直线插补模块
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Line_Num(INT32* pValue);
//插补运动状态
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Line_Status(WORD AObj,INT32* pValue);
//插补轴
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Line_Axis(WORD AObj,INT32* pID0,INT32* pID1);
//插补加速度
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Line_Acc(WORD AObj,INT32* pValue);
//插补减速度
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Line_Dec(WORD AObj,INT32* pValue);
//插补速度
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Line_V(WORD AObj,INT32* pValue);

//AD输入
MT_API INT32 /*__stdcall*/ MT_Get_AD_Num(INT32* pValue);
MT_API INT32 /*__stdcall*/ MT_Get_AD_Data(WORD AObj,INT32* pValue);
MT_API INT32 /*__stdcall*/ MT_Get_Board_T(INT32* pValue);

//================================================================
//圆弧插补
//================================================================
//设置圆弧插补主轴及速度
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_Axis(WORD AObj,INT32* Axis_ID0,INT32* Axis_ID1);
//设置圆弧插补加速度
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_Acc(WORD AObj,INT32 Value);
//设置圆弧插补减速度
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_Dec(WORD AObj,INT32 Value);
//设置圆弧插补速度
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_V(WORD AObj,INT32 Value);

//设置圆弧插补启动 顺时钟  圆心坐标模式
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_R_CW_Run_Rel(WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_R_CW_Run_Abs(WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);
//设置圆弧插补启动 逆时钟   圆心坐标
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_R_CCW_Run_Rel(WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_R_CCW_Run_Abs(WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);
//设置圆弧插补停止
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_Stop(WORD AObj);
//设置圆弧插补急停
MT_API INT32 /*__stdcall*/ MT_Set_Axis_Circle_Halt(WORD AObj);

//读取圆弧插补模块
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Circle_Num(INT32* pValue);
//插补运动状态
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Circle_Status(WORD AObj,INT32* pValue);
//插补轴
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Circle_Axis(WORD AObj,INT32* pID0,INT32* pID1);
//插补加速度
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Circle_Acc(WORD AObj,INT32* pValue);
//插补减速度
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Circle_Dec(WORD AObj,INT32* pValue);
//插补速度
MT_API INT32 /*__stdcall*/ MT_Get_Axis_Circle_V(WORD AObj,INT32* pValue);





#endif