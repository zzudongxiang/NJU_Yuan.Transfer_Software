unit Axis;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms, 
  Dialogs, StdCtrls, Mask, JvExMask, JvSpin, Buttons,MT_Dll, CnHint, ExtCtrls,
  mytypes,Math;

type
  TAxis_Param=record
    Axis_Kind:Byte;
    Axis_Div:Byte;
    Axis_Pitch:Byte2;
    Acc:SingleBytes;
    Dec:SingleBytes;
    P_V:SingleBytes ;
    V_V:SingleBytes ;
  end;

type
  TAxisFrm = class(TFrame)
    grp_Ch: TGroupBox;
    hint_Motor: TCnHintWindow;
    tmr_Axis: TTimer;
    grp_Hardware: TGroupBox;
    Label3: TLabel;
    cbb_Kind: TComboBox;
    Label4: TLabel;
    cbb_Div: TComboBox;
    Label5: TLabel;
    cbb_Pitchs: TComboBox;
    cbb_Ratios: TComboBox;
    Label6: TLabel;
    btn_Hardware: TBitBtn;
    grp_Param: TGroupBox;
    lb_Acc: TLabel;
    btn_Param: TBitBtn;
    lbl_Dec: TLabel;
    lbl_Max_V: TLabel;
    grp_Motion: TGroupBox;
    rb_V: TRadioButton;
    rb_Position: TRadioButton;
    btn_Pos_Abs: TBitBtn;
    btn_Pos_Rel: TBitBtn;
    grp_Status: TGroupBox;
    chk_Run: TCheckBox;
    chk_Zero: TCheckBox;
    chk_Neg: TCheckBox;
    chk_Pos: TCheckBox;
    Label2: TLabel;
    edt_Show_Software: TEdit;
    lbl_15: TLabel;
    edt_Show_V: TEdit;
    btn_Zero: TBitBtn;
    btn_Set_Stop: TBitBtn;
    btn_Set_Halt: TBitBtn;
    btn_V: TBitBtn;
    edt_Acc: TEdit;
    edt_Dec: TEdit;
    edt_Max_V: TEdit;
    edt_Abs: TEdit;
    edt_Rel: TEdit;
    edt_Mode_V_Abs: TEdit;
    btn_Save: TBitBtn;
    edt_Mode_V_Ref: TEdit;
    btn_V_Ref: TBitBtn;
    chk_Read: TCheckBox;
    btn_Home: TBitBtn;
    rb_Home: TRadioButton;
    edt_Home_V: TEdit;
    lbl_Home: TLabel;
    grp_Software_Limit: TGroupBox;
    lbl_1: TLabel;
    lbl_11: TLabel;
    edt_Software_Limit_Neg: TEdit;
    edt_Software_Limit_Pos: TEdit;
    btn_Set_Software_Limit_Value: TBitBtn;
    btn_Soft_Limit_Enable: TBitBtn;
    btn_Soft_Limit_Disable: TBitBtn;
    procedure btn_ParamClick(Sender: TObject);
    procedure btn_Set_HaltClick(Sender: TObject);
    procedure tmr_AxisTimer(Sender: TObject);
    procedure btn_ZeroClick(Sender: TObject);
    procedure btn_GetOneClick(Sender: TObject);
    procedure chk_ShuttleClick(Sender: TObject);
    procedure cbb_KindChange(Sender: TObject);
    procedure btn_HardwareClick(Sender: TObject);
    procedure btn_VClick(Sender: TObject);
    procedure btn_Pos_RelClick(Sender: TObject);
    procedure btn_Pos_AbsClick(Sender: TObject);
    procedure btn_Set_StopClick(Sender: TObject);
    procedure rb_VClick(Sender: TObject);
    procedure rb_PositionClick(Sender: TObject);
    procedure btn_SaveClick(Sender: TObject);
    procedure btn_V_RefClick(Sender: TObject);
    procedure chk_ReadClick(Sender: TObject);
    procedure btn_HomeClick(Sender: TObject);
    procedure rb_HomeClick(Sender: TObject);
    procedure btn_Set_Software_Limit_ValueClick(Sender: TObject);
    procedure btn_Soft_Limit_EnableClick(Sender: TObject);
    procedure btn_Soft_Limit_DisableClick(Sender: TObject);
  private
    { Private declarations }
    g_Axis:TAxis_Param;
  public
    { Public declarations }
    procedure Load_Param;
    procedure Show_Info;
    procedure Set_Param;

  end;

implementation

{$R *.dfm}

procedure TAxisFrm.btn_HomeClick(Sender: TObject);
var
 iNum:Integer;
begin
if(rb_Home.Checked)then
 begin
 if(00=g_Axis.Axis_Kind)then//平移台
  begin
      //调整速度
       //计算速度
      iNum := Round(1.0 * StrToFloat(edt_Home_V.Text) * 200.0 *
         g_Axis.Axis_Div /
         (g_Axis.Axis_Pitch.i16 / 100.0));
      MT_Set_Axis_Home_V(grp_Ch.Tag, iNum);

  end
  else//旋转台
  begin
        //计算速度
    iNum := Round(1.0 * StrToFloat(edt_Home_V.Text) * 200.0 *
       g_Axis.Axis_Div *
       g_Axis.Axis_Pitch.i16 / 360.0);
    MT_Set_Axis_Home_V(grp_Ch.Tag, iNum);

  end
 end;
end;

procedure TAxisFrm.btn_GetOneClick(Sender: TObject);
var
  iValue:Integer;
  iRun,iDir,iNeg,iPos,iZero:Integer;
begin
//tmr_AxisTimer(Self);
 tmr_Axis.Enabled:=not tmr_Axis.Enabled;
end;

procedure TAxisFrm.btn_ZeroClick(Sender: TObject);
begin
  if(R_OK=MT_Set_Axis_Software_P(grp_Ch.Tag,0))then
   begin
     hint_Motor.ActivateHint('成功!','执行结果:');
   end
  else
   begin
     hint_Motor.ActivateHint('失败!','执行结果:');
   end;
end;

procedure TAxisFrm.btn_HardwareClick(Sender: TObject);
var
 i:Integer;
 iIndex:Word;
 iCh:Integer;
begin
//保存硬件参数
//
if(cbb_Kind.ItemIndex=0)then
 begin
   g_Axis.Axis_Kind:=00;
   g_Axis.Axis_Pitch.i16:=Round(StrToFloat(cbb_Pitchs.Text)*100);
 end
else
 begin
   g_Axis.Axis_Kind:=255;
   g_Axis.Axis_Pitch.i16:=StrToInt(cbb_Ratios.Text);
 end;
   g_Axis.Axis_Div:=StrToInt(cbb_Div.Text);
    //读取轴数
    iCh:=grp_Ch.Tag;

    iIndex := 4+iCh*4;
    //读取参数

      MT_Set_Param_Mem_Data(iIndex,
                    g_Axis.Axis_Kind);
      Inc(iIndex);

      MT_Set_Param_Mem_Data(iIndex,
          g_Axis.Axis_Div);
      Inc(iIndex);

      MT_Set_Param_Mem_Data(iIndex,
           g_Axis.Axis_Pitch.byte0);
      Inc(iIndex);

      MT_Set_Param_Mem_Data(iIndex,
           g_Axis.Axis_Pitch.byte1);
      Inc(iIndex);
     ShowMessage('保存成功!');

end;

procedure TAxisFrm.btn_ParamClick(Sender: TObject);
begin
    Set_Param;
    ShowMessage('设置成功!');
end;

procedure TAxisFrm.btn_SaveClick(Sender: TObject);
var
 i:Integer;
 iIndex:Word;
 iCh:Integer;
begin


     //读取轴数
    iCh:=grp_Ch.Tag;

    iIndex := $14+iCh*12;
//acc
    MT_Set_Param_Mem_Data(iIndex,
         g_Axis.Acc.byte0);
    Inc(iIndex);
    MT_Set_Param_Mem_Data(iIndex,
         g_Axis.Acc.byte1);
    Inc(iIndex);
    MT_Set_Param_Mem_Data(iIndex,
        g_Axis.Acc.byte2);
    Inc(iIndex);
    MT_Set_Param_Mem_Data(iIndex,
        g_Axis.Acc.byte3);
    Inc(iIndex);

    //dec
    MT_Set_Param_Mem_Data(iIndex,
        g_Axis.Dec.byte0);
    Inc(iIndex);
    MT_Set_Param_Mem_Data(iIndex,
        g_Axis.Dec.byte1);
    Inc(iIndex);
    MT_Set_Param_Mem_Data(iIndex,
        g_Axis.Dec.byte2);
    Inc(iIndex);
    MT_Set_Param_Mem_Data(iIndex,
        g_Axis.Dec.byte3);
    Inc(iIndex);
    //P-V
    MT_Set_Param_Mem_Data(iIndex,
        g_Axis.P_V.byte0);
    Inc(iIndex);
    MT_Set_Param_Mem_Data(iIndex,
        g_Axis.P_V.byte1);
    Inc(iIndex);
    MT_Set_Param_Mem_Data(iIndex,
        g_Axis.P_V.byte2);
    Inc(iIndex);
    MT_Set_Param_Mem_Data(iIndex,
        g_Axis.P_V.byte3);
    Inc(iIndex);
    g_Axis.Acc.fData:=StrToFloat(edt_Acc.Text);
    g_Axis.Dec.fData:=StrToFloat(edt_Dec.Text);
    g_Axis.P_V.fData:=StrToFloat(edt_Max_V.Text);
    ShowMessage('保存成功!');

end;

procedure TAxisFrm.btn_Set_HaltClick(Sender: TObject);
begin
  if(R_OK=MT_Set_Axis_Halt(grp_Ch.Tag))then
   begin
     hint_Motor.ActivateHint('成功!','执行结果:');
   end
  else
   begin
     hint_Motor.ActivateHint('失败!','执行结果:');
   end;
end;

procedure TAxisFrm.btn_Set_Software_Limit_ValueClick(Sender: TObject);
var
 iNum:Integer;
begin
  if(00 = g_Axis.Axis_Kind)then
  begin
  //计算距离
   iNum := Round(StrToFloat(edt_Software_Limit_Neg.Text) * 200.0 *
     g_Axis.Axis_Div /
     (g_Axis.Axis_Pitch.i16/100.0));
    MT_Set_Axis_Software_Limit_Neg_Value(grp_Ch.Tag,iNum);
   iNum := Round(StrToFloat(edt_Software_Limit_Pos.Text) * 200.0 *
     g_Axis.Axis_Div /
     (g_Axis.Axis_Pitch.i16/100.0));
    MT_Set_Axis_Software_Limit_Pos_Value(grp_Ch.Tag,iNum);

  end
  else
  begin
      //计算距离
      iNum := Round(StrToFloat(edt_Software_Limit_Neg.Text)* 200.0 *
         g_Axis.Axis_Div *
         (g_Axis.Axis_Pitch.i16 / 360.0));
      MT_Set_Axis_Software_Limit_Neg_Value(grp_Ch.Tag, iNum);
      //计算距离
      iNum := Round(StrToFloat(edt_Software_Limit_Pos.Text)* 200.0 *
         g_Axis.Axis_Div *
         (g_Axis.Axis_Pitch.i16 / 360.0));
      MT_Set_Axis_Software_Limit_Pos_Value(grp_Ch.Tag, iNum);
  end
end;

procedure TAxisFrm.btn_Set_StopClick(Sender: TObject);
begin
if(rb_V.Checked)then
 begin
   MT_Set_Axis_Velocity_Stop(grp_Ch.Tag);
 end
else
 begin
   MT_Set_Axis_Position_Stop(grp_Ch.Tag);

 end;
end;

procedure TAxisFrm.btn_Soft_Limit_DisableClick(Sender: TObject);
begin
MT_Set_Axis_Software_Limit_Disable(grp_Ch.Tag);
end;

procedure TAxisFrm.btn_Soft_Limit_EnableClick(Sender: TObject);
begin
 MT_Set_Axis_Software_Limit_Enable(grp_Ch.Tag);
end;

procedure TAxisFrm.btn_Pos_AbsClick(Sender: TObject);
var
 iNum:Integer;
begin
if(rb_Position.Checked)then
 begin

  if (00 = g_Axis.Axis_Kind)then
  begin
  //计算距离
   iNum := Round(StrToFloat(edt_abs.Text) * 200.0 *
     g_Axis.Axis_Div /
     (g_Axis.Axis_Pitch.i16/100.0));
    MT_Set_Axis_Position_P_Target_Abs(grp_Ch.Tag,iNum);
  end
  else
  begin
      //计算距离
      iNum := Round(StrToFloat(edt_abs.Text)* 200.0 *
         g_Axis.Axis_Div *
         (g_Axis.Axis_Pitch.i16 / 360.0));
      MT_Set_Axis_Position_P_Target_Abs(grp_Ch.Tag, iNum);
  end

 end;

end;

procedure TAxisFrm.btn_Pos_RelClick(Sender: TObject);
var
 iNum:Integer;
begin
if(rb_Position.Checked)then
 begin

  if (00 = g_Axis.Axis_Kind)then
  begin
  //计算距离
   iNum := Round(StrToFloat(edt_Rel.Text) * 200.0 *
     g_Axis.Axis_Div /
     (g_Axis.Axis_Pitch.i16/100.0));
    MT_Set_Axis_Position_P_Target_Rel(grp_Ch.Tag,iNum);
  end
  else
  begin
      //计算距离
      iNum := Round(StrToFloat(edt_Rel.Text)* 200.0 *
         g_Axis.Axis_Div *
         (g_Axis.Axis_Pitch.i16 / 360.0));
      MT_Set_Axis_Position_P_Target_Rel(grp_Ch.Tag, iNum);
  end

 end;

end;

procedure TAxisFrm.btn_VClick(Sender: TObject);
var
 iNum:Integer;
begin
if(rb_V.Checked)then
 begin
if(00=g_Axis.Axis_Kind)then//平移台
  begin
      //调整速度
       //计算速度
      iNum := Round(1.0 * StrToFloat(edt_Mode_V_Abs.Text) * 200.0 *
         g_Axis.Axis_Div /
         (g_Axis.Axis_Pitch.i16 / 100.0));
      MT_Set_Axis_Velocity_V_Target_Abs(grp_Ch.Tag, iNum);

  end
  else//旋转台
  begin
        //计算速度
    iNum := Round(1.0 * StrToFloat(edt_Mode_V_Abs.Text) * 200.0 *
       g_Axis.Axis_Div *
       g_Axis.Axis_Pitch.i16 / 360.0);
    MT_Set_Axis_Velocity_V_Target_Abs(grp_Ch.Tag, iNum);

  end

 end;

end;

procedure TAxisFrm.btn_V_RefClick(Sender: TObject);
var
 iNum:Integer;
begin
if(rb_V.Checked)then
 begin
if(00=g_Axis.Axis_Kind)then//平移台
  begin
      //调整速度
       //计算速度
      iNum := Round(1.0 * StrToFloat(edt_Mode_V_Ref.Text) * 200.0 *
         g_Axis.Axis_Div /
         (g_Axis.Axis_Pitch.i16 / 100.0));
      MT_Set_Axis_Velocity_V_Target_Rel(grp_Ch.Tag, iNum);

  end
  else//旋转台
  begin

        //计算速度
    iNum := Round(1.0 * StrToFloat(edt_Mode_V_Ref.Text) * 200.0 *
       g_Axis.Axis_Div *
       g_Axis.Axis_Pitch.i16 / 360.0);
    MT_Set_Axis_Velocity_V_Target_Rel(grp_Ch.Tag, iNum);

  end

 end;
end;

procedure TAxisFrm.cbb_KindChange(Sender: TObject);
begin
if(cbb_Kind.ItemIndex=0)then
 begin
   cbb_Pitchs.Enabled:=True;
   cbb_Ratios.Enabled:=False;
 end;
if(cbb_Kind.ItemIndex=1)then
 begin
   cbb_Ratios.Enabled:=True;
   cbb_Pitchs.Enabled:=False;
 end;
end;


procedure TAxisFrm.chk_ReadClick(Sender: TObject);
begin
 tmr_Axis.Enabled:=chk_Read.Checked;
end;

procedure TAxisFrm.chk_ShuttleClick(Sender: TObject);
begin
 tmr_Axis.Tag:=0;
end;

//装载参数
procedure TAxisFrm.Load_Param;
var
 i:Integer;
 iIndex:Word;
 iCh:Integer;
 AByte:Byte;
begin

//读取轴数
    iCh:=grp_Ch.Tag;

    iIndex := 4+iCh*4;
    //读取参数
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.Axis_Kind :=AByte;

    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.Axis_Div :=AByte;


    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.Axis_Pitch.byte0 :=AByte;

    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.Axis_Pitch.byte1 :=AByte;


    Inc(iIndex);



    //读取运动参数

 //acc
   iIndex:=$14+iCh*12;
   MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.Acc.byte0 :=AByte;

    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.Acc.byte1 :=AByte;

    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.Acc.byte2 :=AByte;


    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.Acc.byte3 :=AByte;

    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    //dec
    g_Axis.Dec.byte0 :=AByte;


    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.Dec.byte1 :=AByte;


    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.Dec.byte2 :=AByte;

    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.Dec.byte3 := AByte;

    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    //P_V
    g_Axis.P_V.byte0 :=AByte;


    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.P_V.byte1 :=AByte;

    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.P_V.byte2 :=AByte;

    Inc(iIndex);
    MT_Get_Param_Mem_Data(iIndex,@AByte);
    g_Axis.P_V.byte3 :=AByte;

    Inc(iIndex);

    
    Show_Info();
end;

procedure TAxisFrm.rb_HomeClick(Sender: TObject);
begin
MT_Set_Axis_Mode_Home(grp_Ch.Tag);
end;

procedure TAxisFrm.rb_PositionClick(Sender: TObject);
begin
MT_Set_Axis_Mode_Position(grp_Ch.Tag);
end;

procedure TAxisFrm.rb_VClick(Sender: TObject);
begin
 MT_Set_Axis_Mode_Velocity(grp_Ch.Tag);
end;

procedure TAxisFrm.Set_Param;
var
 iNum:Integer;
  i: Integer;
begin
 if(g_Axis.Axis_Pitch.i16=0)then
  begin
    Exit;
  end;
 if(00=g_Axis.Axis_Kind)then//平移台
    begin
        //计算加速度
        iNum := Round(1.0*g_Axis.Acc.fData * 200.0 *
           g_Axis.Axis_Div /
           (g_Axis.Axis_Pitch.i16/100.0));
        MT_Set_Axis_Acc(grp_Ch.Tag, iNum);

        //计算减速度
        iNum := Round(1.0*g_Axis.Dec.fData * 200.0 *
           g_Axis.Axis_Div /
           (g_Axis.Axis_Pitch.i16/100.0));
        MT_Set_Axis_Dec(grp_Ch.Tag, iNum);

        //计算速度
        iNum := Round(1.0*g_Axis.P_V.fData * 200.0 *
           g_Axis.Axis_Div /
           (g_Axis.Axis_Pitch.i16/100.0));
        MT_Set_Axis_Position_V_Max(grp_Ch.Tag, iNum);
    end
    else//旋转台
    begin

        //计算加速度
        iNum := Round(1.0 * g_Axis.Acc.fData * 200.0 *
           g_Axis.Axis_Div*g_Axis.Axis_Pitch.i16 / 360.0);
        MT_Set_Axis_Acc(grp_Ch.Tag, iNum);
        //计算减速度
        iNum := Round(1.0 * g_Axis.Dec.fData * 200.0 *
           g_Axis.Axis_Div *
           g_Axis.Axis_Pitch.i16 / 360.0);
        MT_Set_Axis_Dec(grp_Ch.Tag, iNum);
        //计算速度
        iNum := Round(1.0 * g_Axis.P_V.fData * 200.0 *
           g_Axis.Axis_Div *
           g_Axis.Axis_Pitch.i16 / 360.0);
        MT_Set_Axis_Position_V_Max(grp_Ch.Tag, iNum);
    end
end;

procedure TAxisFrm.Show_Info;
var
 i:Integer;
begin
 if(g_Axis.Axis_Kind=0)then
  begin
    cbb_Pitchs.Enabled:=True;
    cbb_Ratios.Enabled:=False;
    lb_Acc.Caption:='加速度(mm/s²)';
    lbl_Dec.Caption:='减速度(mm/s²)';
    lbl_Max_V.Caption:='位置模式最大速度(mm/s)';
    rb_V.Caption:='速度模式(mm/s)';
    rb_Position.Caption:='位置模式(mm)';
    cbb_Div.ItemIndex:=cbb_Div.Items.IndexOf(IntToStr(g_Axis.Axis_Div));
    if(cbb_Div.ItemIndex<0)then
     begin
       cbb_Div.ItemIndex:=0;
     end;

    cbb_Pitchs.ItemIndex:=cbb_Pitchs.Items.IndexOf(
       FormatFloat('0.00',g_Axis.Axis_Pitch.i16/100));

    if(cbb_Pitchs.ItemIndex<0)then
     begin
       cbb_Pitchs.ItemIndex:=0;
     end;
  end
 else
  begin
    cbb_Pitchs.Enabled:=False;
    cbb_Ratios.Enabled:=True;
    lb_Acc.Caption:='加速度(°/s²)';
    lbl_Dec.Caption:='减速度(°/s²)';
    lbl_Max_V.Caption:='位置模式最大速度(°/s)';
    rb_V.Caption:='速度模式(°/s)';
    rb_Position.Caption:='位置模式(°)';

    cbb_Div.ItemIndex:=cbb_Div.Items.IndexOf(IntToStr(g_Axis.Axis_Div));
    if(cbb_Div.ItemIndex<0)then
     begin
       cbb_Div.ItemIndex:=0;
     end;

    cbb_Ratios.ItemIndex:=cbb_Ratios.Items.IndexOf(
       FormatFloat('0',g_Axis.Axis_Pitch.i16));

    if(cbb_Ratios.ItemIndex<0)then
     begin
       cbb_Ratios.ItemIndex:=0;
     end;
  end;

  //运动参数
  edt_Acc.Text:=FormatFloat('0.00',g_Axis.Acc.fData);
  edt_Dec.Text:=FormatFloat('0.00',g_Axis.Dec.fData);
  edt_Max_V.Text:=FormatFloat('0.00',g_Axis.P_V.fData);
end;

procedure TAxisFrm.tmr_AxisTimer(Sender: TObject);
var
  iValue:Integer;
  bRun,bDir,bNeg,bPos,bZero:Boolean;
  AMode:Byte;
  f:Double;
begin
    if(R_OK=MT_Get_Axis_Status(grp_Ch.Tag,
     @bRun,@bDir,@bNeg,@bPos,@bZero,@AMode))then
      begin
        chk_Run.Checked:=bRun;
        chk_Neg.Checked:=bNeg;
        chk_Pos.Checked:=bPos;
        chk_Zero.Checked:=bZero;
      end;

  //软件位置
    if(R_OK=MT_Get_Axis_Software_P_Now(grp_Ch.Tag,@iValue))then
     begin
      f:=0;
      if(g_Axis.Axis_Div<>0)then
       begin
        if(0=g_Axis.Axis_Kind)then
         begin
          f:=iValue/200/g_Axis.Axis_Div*(g_Axis.Axis_Pitch.i16/100);
         end
        else
         begin
          f:=iValue/200/g_Axis.Axis_Div/g_Axis.Axis_Pitch.i16*360;
         end;
       end;


       edt_Show_Software.Text:=FormatFloat('0.000000',f);
     end;
  //当前速度
    if(R_OK=MT_Get_Axis_V_Now(grp_Ch.Tag,@iValue))then
     begin
       edt_Show_V.Text:=IntToStr(iValue);
     end;
end;

end.
