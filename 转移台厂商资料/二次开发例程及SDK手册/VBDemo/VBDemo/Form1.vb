Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (MT_API.R_OK = MT_API.MT_Open_UART("COM1")) Then
            '串口打开成功
            Button1.BackColor = Color.Green
        Else
            Button1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '检测指定串口上的板卡连接状态
        If (MT_API.R_OK = MT_API.MT_Check()) Then

            Button2.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '设置参数
        '加速度
        MT_API.MT_Set_Axis_Acc(0, 1000)
        '减速度
        MT_API.MT_Set_Axis_Dec(0, 1000)
        '速度
        MT_API.MT_Set_Axis_Position_V_Max(0, 2000)
        '工作模式(可以不设置，默认为定位模式)
        MT_API.MT_Set_Axis_Mode_Position(0)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '相对当前位置移动10000个单位
        MT_API.MT_Set_Axis_Position_P_Target_Rel(0, 10000)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MT_API.MT_Init()
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MT_API.MT_DeInit()
    End Sub
End Class
