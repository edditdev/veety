Public Class veety_page

    Public TotallyRegistredUsersCounter As String
    Public TotallyLogginsCounter As String
    Public TotallyServersCounter As String
    Public TotallyInfectedCounter As String

    Private Sub ColorAnimationTimer_Tick(sender As Object, e As EventArgs) Handles ColorAnimationTimer.Tick
        RegistredUsersPreview.ForeColor = ColorAnimation.Value
        LoggingUserPreview.ForeColor = ColorAnimation.Value
        HostedServerPreview.ForeColor = ColorAnimation.Value
        InfectedComputersPreview.ForeColor = ColorAnimation.Value
        Label6.ForeColor = ColorAnimation.Value
        Label7.ForeColor = ColorAnimation.Value
    End Sub

    Private Sub veety_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowAnimation.Show(InfoBox1)
        ShowAnimation.Show(InfoBox2)
        ShowAnimation.Show(InfoBox3)
        ShowAnimation.Show(InfoBox4)
        'ShowAnimation.Show(InfoBox5)
        Counters_script.Start()

    End Sub

    '' ## COUNTERS ''
    Private Sub Rg_Counter_Tick(sender As Object, e As EventArgs) Handles Rg_Counter.Tick
        RegistredUsersPreview.Text = (CInt(RegistredUsersPreview.Text) + 1).ToString()
        If RegistredUsersPreview.Text = TotallyRegistredUsersCounter Then
            Rg_Counter.Stop()
        End If
    End Sub

    Private Sub L_Counter_Tick(sender As Object, e As EventArgs) Handles L_Counter.Tick
        LoggingUserPreview.Text = (CInt(LoggingUserPreview.Text) + 1).ToString()
        If LoggingUserPreview.Text = TotallyLogginsCounter Then
            L_Counter.Stop()
        End If
    End Sub

    Private Sub S_Counter_Tick(sender As Object, e As EventArgs) Handles S_Counter.Tick
        HostedServerPreview.Text = (CInt(HostedServerPreview.Text) + 1).ToString()
        If HostedServerPreview.Text = TotallyServersCounter Then
            S_Counter.Stop()
        End If
    End Sub

    Private Sub I_Counter_Tick(sender As Object, e As EventArgs) Handles I_Counter.Tick
        InfectedComputersPreview.Text = (CInt(InfectedComputersPreview.Text) + 1).ToString()
        If InfectedComputersPreview.Text = TotallyInfectedCounter Then
            I_Counter.Stop()
        End If
    End Sub

End Class