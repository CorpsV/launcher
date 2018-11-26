Public Class Form3

    Private Sub Form3_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Close()

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Me.Label2.Text = "Version: " + Application.ProductVersion

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

        MsgBox("The fucking Owner", MsgBoxStyle.OkOnly, "System")

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        MsgBox("Offline", MsgBoxStyle.Information, "System")

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim process As System.Diagnostics.Process = Nothing
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo
        processStartInfo = New System.Diagnostics.ProcessStartInfo()
        processStartInfo.FileName = "C:\ProgramData\Windows\x64\vs32\logs\windd\Win\x64\Microsoft\system\every\nod\Microsoft\Win\Adobe\vsrutmine\sistema\x64\Corps\recoil\recoil 4.exe"
        processStartInfo.Verb = "runas"

        processStartInfo.Arguments = ""
        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        processStartInfo.UseShellExecute = True
        process = System.Diagnostics.Process.Start(processStartInfo)
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim process As System.Diagnostics.Process = Nothing
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo
        processStartInfo = New System.Diagnostics.ProcessStartInfo()
        processStartInfo.FileName = "C:\ProgramData\Windows\x64\vs32\logs\windd\Win\x64\Microsoft\system\every\nod\Microsoft\Win\Adobe\vsrutmine\sistema\x64\Corps\esp\esp 3.exe"
        processStartInfo.Verb = "runas"

        processStartInfo.Arguments = ""
        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        processStartInfo.UseShellExecute = True
        process = System.Diagnostics.Process.Start(processStartInfo)
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim process As System.Diagnostics.Process = Nothing
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo
        processStartInfo = New System.Diagnostics.ProcessStartInfo()
        processStartInfo.FileName = "C:\ProgramData\Windows\x64\vs32\logs\windd\Win\x64\Microsoft\system\every\nod\Microsoft\Win\Adobe\vsrutmine\sistema\x64\Corps\esp\esp 1.exe"
        processStartInfo.Verb = "runas"

        processStartInfo.Arguments = ""
        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        processStartInfo.UseShellExecute = True
        process = System.Diagnostics.Process.Start(processStartInfo)
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim process As System.Diagnostics.Process = Nothing
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo
        processStartInfo = New System.Diagnostics.ProcessStartInfo()
        processStartInfo.FileName = "C:\ProgramData\Windows\x64\vs32\logs\windd\Win\x64\Microsoft\system\every\nod\Microsoft\Win\Adobe\vsrutmine\sistema\x64\Corps\recoil\recoil 3.exe"
        processStartInfo.Verb = "runas"

        processStartInfo.Arguments = ""
        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        processStartInfo.UseShellExecute = True
        process = System.Diagnostics.Process.Start(processStartInfo)
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim process As System.Diagnostics.Process = Nothing
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo
        processStartInfo = New System.Diagnostics.ProcessStartInfo()
        processStartInfo.FileName = "C:\ProgramData\Windows\x64\vs32\logs\windd\Win\x64\Microsoft\system\every\nod\Microsoft\Win\Adobe\vsrutmine\sistema\x64\Corps\esp\esp 2.exe"
        processStartInfo.Verb = "runas"

        processStartInfo.Arguments = ""
        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        processStartInfo.UseShellExecute = True
        process = System.Diagnostics.Process.Start(processStartInfo)
        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class