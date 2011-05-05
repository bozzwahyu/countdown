Public Class Form1
    Dim tlsecs As Double
    Private Sub suara()
        My.Computer.Audio.Play("D:\belajar vb.net\countdown\Alarm Clock Digital Buzzer.wav")
    End Sub

    Private Sub tombolAwal()
        BtnMulai.Enabled = False
    End Sub
    Private Sub BtnMulai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMulai.Click
        tlsecs = CDbl(TxtWaktu.Text)
        Label1.Text = tlsecs.ToString
        Timer1.Enabled = True
        tombolAwal()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tlsecs = tlsecs - 1
        If (tlsecs < tlsecs + 1) Then
            Label1.ForeColor = Color.Red
            If (tlsecs <= 0) Then
                Timer1.Enabled = False
                BtnMulai.Enabled = True
                suara()
            End If
            Label1.Text = tlsecs.ToString
        End If
    End Sub

    
End Class
