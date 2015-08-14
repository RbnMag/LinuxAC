Imports System.Threading
Public Class LinuxAC


    ' ####################
    ' ####################
    ' ######Made by:######
    ' ######Snowfall######
    ' ####################
    ' ####################

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Then
            MessageBox.Show("Please fill out all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick

        SideWinderProgress1.Maximum = 100

        SideWinderProgress1.Value = SideWinderProgress1.Value + 10

        If SideWinderProgress1.Value = 30 Then
            Thread.Sleep(100)
        End If


        If SideWinderProgress1.Value = 60 Then
            Try
                Dim connInfo As New Renci.SshNet.PasswordConnectionInfo(TextBox1.Text, TextBox2.Text, TextBox3.Text)
                Dim sshClient As New Renci.SshNet.SshClient(connInfo)
                Using sshClient
                    sshClient.Connect()

                    SideWinderAlert1.Alert = SideWinderAlert.Style.Success
                    SideWinderAlert1.Text = "Connected Successfully!"

                    TextBox1.Enabled = False
                    TextBox2.Enabled = False
                    TextBox3.Enabled = False

                    sshClient.Disconnect()
                End Using
            Catch ex As Exception
                SideWinderAlert1.Alert = SideWinderAlert.Style.Warning
                SideWinderAlert1.Text = "Could not connect!"
                MessageBox.Show(ex.ToString)
            End Try
            Thread.Sleep(100)
        End If

        If SideWinderProgress1.Value = 100 Then
            Timer1.Stop()
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connInfo As New Renci.SshNet.PasswordConnectionInfo(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        Dim sshClient As New Renci.SshNet.SshClient(connInfo)
        Dim cmd As Renci.SshNet.SshCommand

        Try

            Using sshClient
                sshClient.Connect()
                cmd = sshClient.RunCommand(TextBox4.Text)

                RichTextBox1.Text = cmd.Result

                sshClient.Disconnect()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connInfo As New Renci.SshNet.PasswordConnectionInfo(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        Dim sshClient As New Renci.SshNet.SshClient(connInfo)
        Dim cmd As Renci.SshNet.SshCommand


        Try

            If ComboBox1.SelectedIndex = 0 Then
                sshClient.Connect()
                cmd = sshClient.RunCommand("df")
                RichTextBox1.Text = cmd.Result
                sshClient.Disconnect()
            End If

            If ComboBox1.SelectedIndex = 1 Then
                sshClient.Connect()
                cmd = sshClient.RunCommand("top")
                RichTextBox1.Text = cmd.Result
                sshClient.Disconnect()
            End If


            If ComboBox1.SelectedIndex = 2 Then
                sshClient.Connect()
                cmd = sshClient.RunCommand("hwinfo --short")
                RichTextBox1.Text = cmd.Result
                sshClient.Disconnect()
            End If

            If ComboBox1.SelectedIndex = 3 Then
                sshClient.Connect()
                cmd = sshClient.RunCommand("w")
                RichTextBox1.Text = cmd.Result
                sshClient.Disconnect()
            End If

            If ComboBox1.SelectedIndex = 4 Then
                sshClient.Connect()
                cmd = sshClient.RunCommand("uptime")
                RichTextBox1.Text = cmd.Result
                sshClient.Disconnect()
            End If

            If ComboBox1.SelectedIndex = 5 Then
                sshClient.Connect()
                cmd = sshClient.RunCommand("ps")
                RichTextBox1.Text = cmd.Result
                sshClient.Disconnect()
            End If

            If ComboBox1.SelectedIndex = 6 Then
                sshClient.Connect()
                cmd = sshClient.RunCommand("iostat")
                RichTextBox1.Text = cmd.Result
                sshClient.Disconnect()
            End If

            If ComboBox1.SelectedIndex = 7 Then
                sshClient.Connect()
                cmd = sshClient.RunCommand("sar")
                RichTextBox1.Text = cmd.Result
                sshClient.Disconnect()
            End If

            If ComboBox1.SelectedIndex = 8 Then
                sshClient.Connect()
                cmd = sshClient.RunCommand("mpstat")
                RichTextBox1.Text = cmd.Result
                sshClient.Disconnect()
            End If



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
