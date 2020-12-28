unit MT_Dll;
//**************************************************//
// Easy tech copyright
//**************************************************//
interface
//==================================================
//运行环境
//===================================================
//dll版本
//初始化窗口
function MT_Init():Integer;cdecl;external 'MT_API.dll'
//关闭窗口
function MT_DeInit():Integer;cdecl;external 'MT_API.dll'
//获取dll版本号
function MT_Get_Dll_Version(sVer:PPChar):Integer;cdecl;external 'MT_API.dll'



//======================================================
//通信口
//======================================================
//打开 UART
function MT_Open_UART(sCOM:PChar):Integer;cdecl;external 'MT_API.dll'
//关闭 UART
function MT_Close_UART():Integer;cdecl;external 'MT_API.dll'
//打开USB
function MT_Open_USB:Integer;cdecl;external 'MT_API.dll'
//关闭USB
function MT_Close_USB:Integer;cdecl;external 'MT_API.dll'


//=====================================================
//板卡检测
//=====================================================
//检测设备
function MT_Check():Integer;cdecl;external 'MT_API.dll'
//读取资源模块
function MT_Get_Product_Resource(pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//获取ID
function MT_Get_Product_ID(sID:PAnsiChar):Integer;cdecl;external 'MT_API.dll'
//获取SN
function MT_Get_Product_SN(sSN:PAnsiChar):Integer;cdecl;external 'MT_API.dll'
//读取固件版本号
function MT_Get_Product_Version(pMajor:PInteger;pMinor:PInteger):Integer;cdecl;external 'MT_API.dll'
//===================================================================
//板卡温度
//===================================================================
//获取温度
function MT_Get_Board_Temperature(pValue:PDouble):Integer;cdecl;external 'MT_API.dll'

//===================================================================
//电机相关
//====================================================================
//轴数
function MT_Get_Axis_Num(pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//读取加速度
function MT_Get_Axis_Acc(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//设置加速度
function MT_Set_Axis_Acc(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//读取加速度
function MT_Get_Axis_Dec(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//设置加速度
function MT_Set_Axis_Dec(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//读取工作模式
function MT_Get_Axis_Mode(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//设置速度模式
function MT_Set_Axis_Mode_Velocity(AObj:Word):Integer;cdecl;external 'MT_API.dll'
//设置位置模式
function MT_Set_Axis_Mode_Position(AObj:Word):Integer;cdecl;external 'MT_API.dll'
//读取速度模式目标速度
function MT_Get_Axis_Velocity_V_Target(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//设置速度模式目标速度
function MT_Set_Axis_Velocity_V_Target_Abs(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//设置速度模式目标速度
function MT_Set_Axis_Velocity_V_Target_Rel(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//停止速度模式
function MT_Set_Axis_Velocity_Stop(AObj:Word):Integer;cdecl;external 'MT_API.dll'

//读取位置模式最大速度
function MT_Get_Axis_Position_V_Max(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//设置位置模式最大速度
function MT_Set_Axis_Position_V_Max(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//读取位置模式目标
function MT_Get_Axis_Position_P_Target(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//设置位置模式目标
function MT_Set_Axis_Position_P_Target_Abs(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
function MT_Set_Axis_Position_P_Target_Rel(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//停止位置模式
function MT_Set_Axis_Position_Stop(AObj:Word):Integer;cdecl;external 'MT_API.dll'
//紧急停止
function MT_Set_Axis_Halt(AObj:Word):Integer;cdecl;external 'MT_API.dll'
function MT_Set_Axis_Halt_All():Integer;cdecl;external 'MT_API.dll'

//////////////////////////////////////////////////////////////
///  状态相关
///  //////////////////////////////////////////////////////
//读取当前速度
function MT_Get_Axis_V_Now(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//读取当前软件位置
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
//存储器
//读取存储器长度
function MT_Get_Param_Mem_Len(pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//读取存储器数据
function MT_Get_Param_Mem_Data(AObj:Word;pValue:PByte):Integer;cdecl;external 'MT_API.dll'
//设置存储器数据
function MT_Set_Param_Mem_Data(AObj:Word;Value:Byte):Integer;cdecl;external 'MT_API.dll'
//光隔输入
function MT_Get_Optic_In_Num(pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
function MT_Get_Optic_In_Single(AObj:Word;pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
function MT_Get_Optic_In_All(pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
//光隔输出
function MT_Get_Optic_Out_Num(pValue:PInteger):Integer;cdecl;external 'MT_API.dll'
function MT_Set_Optic_Out_Single(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
function MT_Set_Optic_Out_All(Value:Integer):Integer;cdecl;external 'MT_API.dll'

//设置0位模式
function MT_Set_Axis_Mode_Home(AObj:Word):Integer;cdecl;external 'MT_API.dll'
//设置0位模式目标速度
function MT_Set_Axis_Home_V(AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//停止0位模式
function MT_Set_Axis_Home_Stop(AObj:Word):Integer;cdecl;external 'MT_API.dll'


//软件限位
//设置软件限位值
function MT_Set_Axis_Software_Limit_Neg_Value
   (AObj:Word;Value:Integer):Integer;cdecl; external 'MT_API.dll'
//设置软件限位值
function MT_Set_Axis_Software_Limit_Pos_Value
   (AObj:Word;Value:Integer):Integer;cdecl;external 'MT_API.dll'
//使能软件限位模式
function MT_Set_Axis_Software_Limit_Enable(AObj:Word):Integer;cdecl;external 'MT_API.dll'
//停止软件限位模式
function MT_Set_Axis_Software_Limit_Disable(AObj:Word):Integer;cdecl;external 'MT_API.dll'

  const R_OK =0;
  const R_Error=-1;
  const RUN_OFF=0;
  const RUN_ON=1;
  const DIR_NEG=0;
  const DIR_POS=1;
  const LIMIT_ON=1;
  const LIMIT_OFF=0;

//定义内部资源类型
const RESOURCE_MOTOR       =$00000001;   //电机
const RESOURCE_TTL_IN      =$00000002;   //TTL输入
const RESOURCE_TTL_OUT     =$00000004;   //TTL输出
const RESOURCE_OPTIC_IN    =$00000008;   //光隔输入
const RESOURCE_OPTIC_OUT   =$00000010;   //光隔输出
implementation

end.
