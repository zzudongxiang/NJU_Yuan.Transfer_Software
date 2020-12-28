VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   8220
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   11400
   LinkTopic       =   "Form1"
   ScaleHeight     =   8220
   ScaleWidth      =   11400
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton btn_In_All 
      Caption         =   "所有输入通道"
      Height          =   615
      Left            =   5640
      TabIndex        =   26
      Top             =   7440
      Width           =   2055
   End
   Begin VB.TextBox txt_In_All 
      Height          =   495
      Left            =   5520
      TabIndex        =   25
      Top             =   6720
      Width           =   2295
   End
   Begin VB.ComboBox Combo1 
      Height          =   315
      ItemData        =   "VB_Demo.frx":0000
      Left            =   360
      List            =   "VB_Demo.frx":001C
      Style           =   2  'Dropdown List
      TabIndex        =   24
      Top             =   6840
      Width           =   1575
   End
   Begin VB.CommandButton btn_Optic_In 
      Caption         =   "单通道光电输入"
      Height          =   495
      Left            =   2160
      TabIndex        =   23
      Top             =   7440
      Width           =   1695
   End
   Begin VB.TextBox txt_In_Single 
      Height          =   375
      Left            =   2280
      TabIndex        =   22
      Top             =   6840
      Width           =   1695
   End
   Begin VB.CheckBox chk_Zero 
      Caption         =   "零位"
      Height          =   495
      Left            =   8280
      TabIndex        =   21
      Top             =   4680
      Width           =   1815
   End
   Begin VB.CheckBox chk_Pos 
      Caption         =   "正限位"
      Height          =   495
      Left            =   8280
      TabIndex        =   20
      Top             =   4080
      Width           =   1815
   End
   Begin VB.CheckBox chk_Neg 
      Caption         =   "负限位"
      Height          =   495
      Left            =   8280
      TabIndex        =   19
      Top             =   3480
      Width           =   1815
   End
   Begin VB.CheckBox chk_Dir 
      Caption         =   "正方向"
      Height          =   495
      Left            =   8280
      TabIndex        =   18
      Top             =   3000
      Width           =   1815
   End
   Begin VB.CheckBox chk_Run 
      Caption         =   "运行中"
      Height          =   495
      Left            =   8280
      TabIndex        =   17
      Top             =   2400
      Width           =   1815
   End
   Begin VB.CommandButton btn_Status 
      Caption         =   "状态"
      Height          =   735
      Left            =   7920
      TabIndex        =   16
      Top             =   5520
      Width           =   2295
   End
   Begin VB.TextBox txt_Pos 
      Height          =   495
      Left            =   8400
      TabIndex        =   15
      Top             =   600
      Width           =   2295
   End
   Begin VB.CommandButton btn_Get_Pos 
      Caption         =   "读取位置"
      Height          =   735
      Left            =   8280
      TabIndex        =   14
      Top             =   1320
      Width           =   2415
   End
   Begin VB.CommandButton btn_Halt 
      Caption         =   "急停"
      Height          =   615
      Left            =   2880
      TabIndex        =   13
      Top             =   4680
      Width           =   2055
   End
   Begin VB.CommandButton btn_Stop 
      Caption         =   "停止"
      Height          =   615
      Left            =   720
      TabIndex        =   12
      Top             =   4680
      Width           =   1815
   End
   Begin VB.CommandButton btn_Abs 
      Caption         =   "绝对移动"
      Height          =   615
      Left            =   2160
      TabIndex        =   11
      Top             =   3840
      Width           =   1695
   End
   Begin VB.TextBox txt_Abs 
      Height          =   495
      Left            =   480
      TabIndex        =   10
      Text            =   "50000"
      Top             =   3840
      Width           =   1335
   End
   Begin VB.CommandButton btn_Ref 
      Caption         =   "相对移动"
      Height          =   615
      Left            =   2160
      TabIndex        =   9
      Top             =   3000
      Width           =   1695
   End
   Begin VB.TextBox txt_Ref 
      Height          =   495
      Left            =   480
      TabIndex        =   8
      Text            =   "50000"
      Top             =   3000
      Width           =   1335
   End
   Begin VB.CommandButton btn_MaxV 
      Caption         =   "速度"
      Height          =   615
      Left            =   2160
      TabIndex        =   7
      Top             =   1920
      Width           =   1695
   End
   Begin VB.TextBox txt_MaxV 
      Height          =   495
      Left            =   480
      TabIndex        =   6
      Text            =   "5000"
      Top             =   1920
      Width           =   1335
   End
   Begin VB.CommandButton btn_Dec 
      Caption         =   "减速度"
      Height          =   615
      Left            =   5760
      TabIndex        =   5
      Top             =   960
      Width           =   1695
   End
   Begin VB.TextBox txt_Dec 
      Height          =   495
      Left            =   4080
      TabIndex        =   4
      Text            =   "500"
      Top             =   1080
      Width           =   1335
   End
   Begin VB.CommandButton btn_Acc 
      Caption         =   "加速度"
      Height          =   615
      Left            =   2160
      TabIndex        =   3
      Top             =   960
      Width           =   1695
   End
   Begin VB.TextBox txt_Acc 
      Height          =   495
      Left            =   480
      TabIndex        =   2
      Text            =   "500"
      Top             =   1080
      Width           =   1335
   End
   Begin VB.CommandButton btn_Port 
      Caption         =   "检测板卡"
      Height          =   615
      Left            =   2160
      TabIndex        =   1
      Top             =   120
      Width           =   1695
   End
   Begin VB.TextBox txt_Port 
      Height          =   375
      Left            =   480
      TabIndex        =   0
      Text            =   "COM1"
      Top             =   240
      Width           =   1335
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub btn_Abs_Click()
 Dim iR As Long
 '一定要设置为位置模式，位置相关的函数才会有效
 iR = MT_Set_Axis_Mode_Position(0)
 iR = MT_Set_Axis_Position_P_Target_Abs(0, CLng(txt_Abs.Text))
 
   If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_Acc_Click()
 Dim iR As Long
 iR = MT_Set_Axis_Acc(0, CLng(txt_Acc.Text))
  If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_Dec_Click()
 Dim iR As Long
 iR = MT_Set_Axis_Dec(0, CLng(txt_Dec.Text))
  If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_Get_Pos_Click()
 Dim iPos As Long
 Dim iR As Long
 iR = MT_Get_Axis_Software_P_Now(0, iPos)
 If (iR <> 0) Then
  MsgBox ("Error")
 End
 Else
  'MsgBox ("ok")
  txt_Pos.Text = CStr(iPos)
 End If
 
End Sub

Private Sub btn_Halt_Click()
 Dim iR As Long
 iR = MT_Set_Axis_Halt(0)
   If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_In_All_Click()
 Dim iR As Long
 Dim Value As Long
 iR = MT_Get_Optic_In_All(Value)
  If (iR <> 0) Then
  
   MsgBox ("Error")
  End
 Else
  txt_In_All.Text = CStr(Value)

  End If
End Sub

Private Sub btn_MaxV_Click()
 Dim iR As Long
 iR = MT_Set_Axis_Position_V_Max(0, CLng(txt_MaxV.Text))
  If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_Optic_In_Click()
 Dim iR As Long
 Dim Value As Long
 iR = MT_Get_Optic_In_Single(Combo1.ListIndex, Value)
  If (iR <> 0) Then
  
   MsgBox ("Error")
  End
 Else
  If (Value > 0) Then
  
    txt_In_Single.Text = "高电平"
    Else
    txt_In_Single.Text = "低电平"
    End If
  End If
 
 
End Sub

Private Sub btn_Port_Click()
 Dim iR As Long
 MT_Close_UART
 MT_Close_USB
 iR = MT_Open_UART(txt_Port.Text)
 If (iR <> 0) Then
   MsgBox ("Error")
   Exit Sub
  End If
 iR = MT_Check
 If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
 
End Sub

Private Sub btn_Ref_Click()
 Dim iR As Long
 '一定要设置为位置模式，位置相关的函数才会有效
 iR = MT_Set_Axis_Mode_Position(0)
 iR = MT_Set_Axis_Position_P_Target_Rel(0, CLng(txt_Ref.Text))
 
  If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_Status_Click()
 Dim iR As Long
 Dim bRun, bDir, bNeg, bPos, bZero As Byte
 Dim iMode As Byte
 iR = MT_Get_Axis_Status(0, bRun, bDir, bNeg, bPos, bZero, iMode)
 
   If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  chk_Run.Value = bRun
  chk_Dir.Value = bDir
  chk_Neg.Value = bNeg
  chk_Pos.Value = bPos
  chk_Zero.Value = bZero
  End If
End Sub

Private Sub btn_Stop_Click()
 Dim iR As Long
 iR = MT_Set_Axis_Position_Stop(0)
 
   If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub Command1_Click()

End Sub

Private Sub Form_Load()
 MT_Init
 
 Combo1.ListIndex = 0
End Sub

Private Sub Form_Unload(Cancel As Integer)
 MT_DeInit
End Sub
