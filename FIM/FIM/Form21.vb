Public Class Form21
    Function Buka(ByVal Z As Object) As Form
        Z.Show()
        Me.Hide()
        Return Z
    End Function
    Private Sub Form21_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        PictureBox1.Focus()
    End Sub
    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles Me.Load
        If mundur.Enabled = True Then
            mundur.Start()
        Else
            detik.Text = 121
            mundur.Start()
        End If
        UA.Enabled = False
        UB.Enabled = False
        UC.Enabled = False
        UD.Enabled = False
        UE.Enabled = False
        UF.Enabled = False
        PictureBox1.Focus()
    End Sub
    Private Sub Mundur_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mundur.Tick
        mundur.Start()
        mundur.Interval = 1000
        If detik.Text = 0 Then
            mundur.Enabled = False
            Form1.Show()
            Me.Hide()
            MsgBox("Waktu Habis!")
            Form1.Button20.Text = " "
            A.Enabled = True
            B.Enabled = True
            C.Enabled = True
            D.Enabled = True
            BE.Enabled = True
            F.Enabled = True
            GroupBox2.ForeColor = Color.RoyalBlue
            detik.Text = 120
            detik.BackColor = Color.RoyalBlue
        ElseIf detik.Text <= 10 Then
            detik.BackColor = Color.Crimson
            GroupBox2.ForeColor = Color.Crimson
            detik.Text = Val(detik.Text) - 1
        Else
            detik.Text = Val(detik.Text) - 1
        End If
    End Sub
    Private Sub A_Click(sender As Object, e As EventArgs) Handles A.Click
        mundur.Enabled = False
        Form1.Button20.Text = "A"
        Buka(Form1)
        Form1.Button20.BackColor = Color.HotPink
        Form1.T1.Text = Val(Form1.T1.Text) + Val(TextBox3.Text)
        A.Enabled = True
        B.Enabled = True
        C.Enabled = True
        D.Enabled = True
        BE.Enabled = True
        F.Enabled = True
        detik.Text = 120
    End Sub
    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        mundur.Enabled = False
        Form1.Button20.Text = "B"
        Buka(Form1)
        Form1.Button20.BackColor = Color.Yellow
        Form1.T2.Text = Val(Form1.T2.Text) + Val(TextBox3.Text)
        A.Enabled = True
        B.Enabled = True
        C.Enabled = True
        D.Enabled = True
        BE.Enabled = True
        F.Enabled = True
        detik.Text = 120
    End Sub
    Private Sub C_Click(sender As Object, e As EventArgs) Handles C.Click
        mundur.Enabled = False
        Form1.Button20.Text = "C"
        Buka(Form1)
        Form1.Button20.BackColor = Color.GreenYellow
        Form1.T3.Text = Val(Form1.T3.Text) + Val(TextBox3.Text)
        A.Enabled = True
        B.Enabled = True
        C.Enabled = True
        D.Enabled = True
        BE.Enabled = True
        F.Enabled = True
        detik.Text = 120
    End Sub
    Private Sub D_Click(sender As Object, e As EventArgs) Handles D.Click
        mundur.Enabled = False
        Form1.Button20.Text = "D"
        Buka(Form1)
        Form1.Button20.BackColor = Color.Cyan
        Form1.T4.Text = Val(Form1.T4.Text) + Val(TextBox3.Text)
        A.Enabled = True
        B.Enabled = True
        C.Enabled = True
        D.Enabled = True
        BE.Enabled = True
        F.Enabled = True
        detik.Text = 120
    End Sub
    Private Sub BE_Click(sender As Object, e As EventArgs) Handles BE.Click
        mundur.Enabled = False
        Form1.Button20.Text = "E"
        Buka(Form1)
        Form1.Button20.BackColor = Color.Orange
        Form1.T5.Text = Val(Form1.T5.Text) + Val(TextBox3.Text)
        A.Enabled = True
        B.Enabled = True
        C.Enabled = True
        D.Enabled = True
        BE.Enabled = True
        F.Enabled = True
        detik.Text = 120
    End Sub
    Private Sub F_Click(sender As Object, e As EventArgs) Handles F.Click
        mundur.Enabled = False
        Form1.Button20.Text = "F"
        Buka(Form1)
        Form1.Button20.BackColor = Color.BlueViolet
        Form1.T6.Text = Val(Form1.T6.Text) + Val(TextBox3.Text)
        A.Enabled = True
        B.Enabled = True
        C.Enabled = True
        D.Enabled = True
        BE.Enabled = True
        F.Enabled = True
        detik.Text = 120
    End Sub
    Private Sub TT_Click(sender As Object, e As EventArgs) Handles TT.Click
        mundur.Enabled = False
        Form1.Button20.Text = " "
        Buka(Form1)
        Form1.Button20.BackColor = Color.Gainsboro
        A.Enabled = True
        B.Enabled = True
        C.Enabled = True
        D.Enabled = True
        BE.Enabled = True
        F.Enabled = True
        detik.Text = 120
    End Sub
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        B1.Enabled = False
        A.Enabled = False
        UA.Enabled = True
        Form1.T1.Text = Val(Form1.T1.Text) - 5
        PictureBox1.Focus()
    End Sub
    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        B2.Enabled = False
        B.Enabled = False
        UB.Enabled = True
        Form1.T2.Text = Val(Form1.T2.Text) - 5
        PictureBox1.Focus()
    End Sub
    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        B3.Enabled = False
        C.Enabled = False
        UC.Enabled = True
        Form1.T3.Text = Val(Form1.T3.Text) - 5
        PictureBox1.Focus()
    End Sub
    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        B4.Enabled = False
        D.Enabled = False
        UD.Enabled = True
        Form1.T4.Text = Val(Form1.T4.Text) - 5
        PictureBox1.Focus()
    End Sub
    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        B5.Enabled = False
        BE.Enabled = False
        UE.Enabled = True
        Form1.T5.Text = Val(Form1.T5.Text) - 5
        PictureBox1.Focus()
    End Sub
    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        B6.Enabled = False
        F.Enabled = False
        UF.Enabled = True
        Form1.T6.Text = Val(Form1.T6.Text) - 5
        PictureBox1.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
        detik.Text = 120
        mundur.Enabled = False
    End Sub
    Private Sub UA_Click(sender As Object, e As EventArgs) Handles UA.Click
        B1.Enabled = True
        A.Enabled = True
        UA.Enabled = False
        Form1.T1.Text = Val(Form1.T1.Text) + 5
        PictureBox1.Focus()
    End Sub
    Private Sub UB_Click(sender As Object, e As EventArgs) Handles UB.Click
        B2.Enabled = True
        B.Enabled = True
        UB.Enabled = False
        Form1.T2.Text = Val(Form1.T2.Text) + 5
        PictureBox1.Focus()
    End Sub
    Private Sub UC_Click(sender As Object, e As EventArgs) Handles UC.Click
        B3.Enabled = True
        C.Enabled = True
        UC.Enabled = False
        Form1.T3.Text = Val(Form1.T3.Text) + 5
        PictureBox1.Focus()
    End Sub
    Private Sub UD_Click(sender As Object, e As EventArgs) Handles UD.Click
        B4.Enabled = True
        D.Enabled = True
        UD.Enabled = False
        Form1.T4.Text = Val(Form1.T4.Text) + 5
        PictureBox1.Focus()
    End Sub
    Private Sub UE_Click(sender As Object, e As EventArgs) Handles UE.Click
        B5.Enabled = True
        BE.Enabled = True
        UE.Enabled = False
        Form1.T5.Text = Val(Form1.T5.Text) + 5
        PictureBox1.Focus()
    End Sub
    Private Sub UF_Click(sender As Object, e As EventArgs) Handles UF.Click
        B6.Enabled = True
        F.Enabled = True
        UF.Enabled = False
        Form1.T6.Text = Val(Form1.T6.Text) + 5
        PictureBox1.Focus()
    End Sub
    Private Sub PA_Click(sender As Object, e As EventArgs) Handles PA.Click
        Form1.T1.Text = Val(Form1.T1.Text) - 10
        PictureBox1.Focus()
    End Sub

    Private Sub PB_Click(sender As Object, e As EventArgs) Handles PB.Click
        Form1.T2.Text = Val(Form1.T2.Text) - 10
        PictureBox1.Focus()
    End Sub

    Private Sub PC_Click(sender As Object, e As EventArgs) Handles PC.Click
        Form1.T3.Text = Val(Form1.T3.Text) - 10
        PictureBox1.Focus()
    End Sub
    Private Sub PD_Click(sender As Object, e As EventArgs) Handles PD.Click
        Form1.T4.Text = Val(Form1.T4.Text) - 10
        PictureBox1.Focus()
    End Sub
    Private Sub PE_Click(sender As Object, e As EventArgs) Handles PE.Click
        Form1.T5.Text = Val(Form1.T5.Text) - 10
        PictureBox1.Focus()
    End Sub
    Private Sub PF_Click(sender As Object, e As EventArgs) Handles PF.Click
        Form1.T6.Text = Val(Form1.T6.Text) - 10
        PictureBox1.Focus()
    End Sub
End Class