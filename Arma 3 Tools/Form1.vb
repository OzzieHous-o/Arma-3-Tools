Imports System.IO
Imports System.Net
Imports GLib.IniFile
Imports Microsoft.VisualBasic.CompilerServices

Public Class Form1
    Private tt As ToolTip = New ToolTip()
    Dim Path As String = "C:\Users\" & Environment.UserName & "\AppData\Local\Arma 3\MPMissionsCache"
    Dim oIniFile As New GLib.IniFile
    Dim strSteamInstallPath As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)
    Dim WC1 As New WebClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lLoad As Boolean
        lLoad = oIniFile.LoadFile(Application.StartupPath & "\DCA3TOOLS.ini")
        Dim str1 As String = oIniFile.Items("CACHE_FOLDER_PATH")
        Dim str2 As String = oIniFile("MP_MISSION_PATH")

        TextBox1.Text = str1
        TextBox2.Text = str2
        Button3.Select()

        Try
            Dim status As String = System.Text.Encoding.ASCII.GetString(WC1.DownloadData("https://gitlab.com/DrunkenCheetah/status/-/raw/main/README.txt"))

            If status.ToString.Contains("leaked") Then
                statuss.Text = "THIS PROGRAM HAS BEEN REPOSTED WITHOUT PERMISSION. PROGRAM DISABLED! PLEASE CONTACT ME."
                statuss.ForeColor = Color.Red
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                flashLabel.Start()
            End If
        Catch ax As Exception
        End Try
    End Sub
    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        tt.Show("You can also double click to automatically add the folder.", TextBox1)
    End Sub
    Private Sub TextBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseDoubleClick
        If Not Directory.Exists(Path) Then
            MessageBox.Show("We couldn't detect any folder for Arma 3. Are you sure it is installed?" & vbNewLine & vbNewLine & "e-10644", "ALERT", MessageBoxButtons.OK)
        Else
            TextBox1.Text = Path
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("All fields are required.", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lSave As Boolean
            lSave = oIniFile.SaveFile(Application.StartupPath & "\DCA3TOOLS.ini")
            If (lSave) Then
                oIniFile.Items("CACHE_FOLDER_PATH") = TextBox1.Text
                oIniFile("MP_MISSION_PATH") = TextBox2.Text
                MessageBox.Show("Everything has been saved.", "ALERT", MessageBoxButtons.OK)
                Dim result As DialogResult = MessageBox.Show("Would you like to open the folder?", "ALERT", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Process.Start(Path)
                End If
            End If
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If System.IO.File.Exists(Application.StartupPath & "\DCA3TOOLS.ini") Then
            System.IO.File.Delete(Application.StartupPath & "\DCA3TOOLS.ini")
            MessageBox.Show("File has been deleted!", "ALERT", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cache As New FolderBrowserDialog
        Dim root As Environment.SpecialFolder = Environment.SpecialFolder.LocalApplicationData

        cache.ShowNewFolderButton = False
        cache.Description = "Please navigate to your Arma 3\MPMissionCache Folder "
        cache.RootFolder = root

        If (cache.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = cache.SelectedPath
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not TextBox1.Text.Contains("Arma 3\MPMissionsCache") Then
            MessageBox.Show("We couldn't detect an absolute folder path for MPMissionCache folder." & vbNewLine & vbNewLine & "e-10645", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not TextBox2.Text.Contains(".pbo") Then
            MessageBox.Show("We couldn't detect a proper file name." & vbNewLine & vbNewLine & "e-10646", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            copyFile()
        End If
    End Sub
    Private Function copyFile() As Boolean
        Try
            Dim separator As Char() = New Char() {"\\"}
            Dim strArray As String() = Me.TextBox2.Text.Split(separator)
            File.Copy(TextBox2.Text, TextBox1.Text & "\" & strArray(strArray.Length - 1), True)

            Dim SourcePath As String = TextBox2.Text
            Dim SaveDirectory As String = TextBox1.Text

            Dim Filename As String = System.IO.Path.GetFileName(SourcePath)
            Dim SavePath As String = System.IO.Path.Combine(SaveDirectory, Filename)

            If System.IO.File.Exists(SavePath) Then
                MessageBox.Show(Filename & vbNewLine & vbNewLine & "Has been successfully copied from:" & vbNewLine &
                            SourcePath & vbNewLine & vbNewLine & "And moved to:" & vbNewLine &
                            SaveDirectory, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("File could not be copied to MP Mission Cache! Arma might be caching it, or you have not re-pbo your mission." & vbNewLine & vbNewLine & "e-10647", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return True
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mission As New OpenFileDialog
        Dim root As Environment.SpecialFolder = Environment.SpecialFolder.MyComputer

        mission.Filter = "PBO Files (*.pbo)|*.pbo"
        mission.InitialDirectory = root
        If (mission.ShowDialog() = DialogResult.OK) Then
            TextBox2.Text = mission.FileName
        End If
    End Sub
    Private Sub Form1_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        MessageBox.Show(My.Resources.errorinfo, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If System.IO.File.Exists(Application.StartupPath & "\DCA3TOOLS.ini") Then
            Process.Start("notepad.exe", Application.StartupPath & "\DCA3TOOLS.ini")
        Else
            MessageBox.Show("We couldn't find any saved ini file. Please save settings before trying to open it!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub flashLabel_Tick(sender As Object, e As EventArgs) Handles flashLabel.Tick
        statuss.Visible = Not statuss.Visible
    End Sub
    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class
