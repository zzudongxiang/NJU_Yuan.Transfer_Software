Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (MT_API.R_OK = MT_API.MT_Open_UART("COM1")) Then
            '���ڴ򿪳ɹ�
            Button1.BackColor = Color.Green
        Else
            Button1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '���ָ�������ϵİ忨����״̬
        If (MT_API.R_OK = MT_API.MT_Check()) Then

            Button2.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '���ò���
        '���ٶ�
        MT_API.MT_Set_Axis_Acc(0, 1000)
        '���ٶ�
        MT_API.MT_Set_Axis_Dec(0, 1000)
        '�ٶ�
        MT_API.MT_Set_Axis_Position_V_Max(0, 2000)
        '����ģʽ(���Բ����ã�Ĭ��Ϊ��λģʽ)
        MT_API.MT_Set_Axis_Mode_Position(0)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '��Ե�ǰλ���ƶ�10000����λ
        MT_API.MT_Set_Axis_Position_P_Target_Rel(0, 10000)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MT_API.MT_Init()
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MT_API.MT_DeInit()
    End Sub
End Class
