Public Class Builder

    '# RANDOM STRINGS
    Private Shared random As New Random()
    Public Shared Function Gen(ByVal length As Integer) As String
        Dim chars As String = "123456789asdfghjklzxcvbnmqwertyuiop".ToUpper
        Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
    End Function


    Private Sub Builder_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'Create server name for logged in user.
        Try

            ServerName_BOX.Text = "V" & Gen(5)

            ShowAnimation.Show(InfoBox1)
            ShowAnimation.Show(Step1)
            fbars.Show(f1)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Try

            If ServerName_BOX.Text.Length < 4 Then
                MsgBox("Minimun 4 characters for server name. (no simbols)")
            Else
                StartBuilding()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ServerName_BOX_TextChanged(sender As Object, e As EventArgs) Handles ServerName_BOX.TextChanged
        ServerName_BOX.Text.ToUpper()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Step1.Hide()
        StepsAnim.Show(Step2)
        fbars.Show(f2)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Step2.Hide()

        StepsAnim.Show(Step1)
        fbarshide.Hide(f2)
        fbars.Show(f1)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Step2.Hide()

        StepsAnim.Show(Step3)
        fbars.Show(f3)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Step3.Hide()
        fbarshide.Hide(f3)
        StepsAnim.Show(Step2)
        fbars.Show(f2)

    End Sub
End Class