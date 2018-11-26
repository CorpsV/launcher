Imports System.Net

Public Class Form2

    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        Form1.Close()

    End Sub

    Private Sub Form2_FormClosed1(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Close()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Label2.Text = "Version: " + Application.ProductVersion

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Dim web As New Net.WebClient
        Dim site As String = "https://contatext3.000webhostapp.com/Update/update.txt"
        Dim versao As String = web.DownloadString(site)
        Timer1.Stop()
        If versao < Application.ProductVersion = True Then
            MsgBox("The server is offline", MsgBoxStyle.Critical, "System")
            Form1.Show()
            Me.Hide()

        End If


        If versao > Application.ProductVersion = True Then
            MsgBox("New update in Discord,Please download", MsgBoxStyle.Exclamation, "System")
            Form1.Close()


        Else
            If versao = Application.ProductVersion = True Then
                MsgBox("Correct version", MsgBoxStyle.OkOnly, "System")
                Form4.Show()
                MsgBox("Inject your bypass in training and do not close")
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Threading.Thread.Sleep("2000")


        Timer1.Start()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

        MsgBox("The fucking Owner", MsgBoxStyle.OkOnly, "System")

    End Sub
End Class

