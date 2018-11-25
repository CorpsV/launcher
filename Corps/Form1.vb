Imports System.Net

Public Class Form1
    Private Sub entrar()

        Dim senha As String = TextBox1.Text
        Dim web As New Net.WebClient
        Dim site As String = "https://contatext3.000webhostapp.com/Keys/" + senha + ".txt"
        Dim versao As String
        Try
            versao = web.DownloadString(site)
            If versao <> "" Then

                System.Threading.Thread.Sleep("2000")



                Dim hoje As Date = Date.Now
                Dim datacriacao As Date = Date.ParseExact(versao, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                Dim vencimento = datacriacao.AddDays(20.0#)
                Dim diferenca = vencimento - hoje

                Dim dias As Integer = diferenca.TotalDays

                If dias >= 0 Then
                    MsgBox("Welcome member", MsgBoxStyle.Information, "System")
                    Dim menssagem As String = "You have " & dias & " days of access "
                    MsgBox(menssagem)
                    form2.Show()
                    Me.Hide()

                Else

                    MsgBox("You don't have access days", MsgBoxStyle.Critical, "System")

                End If

            End If

        Catch

            MsgBox("Key invalid", MsgBoxStyle.Critical, "System")

        End Try

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label2.Text = "Version: " + Application.ProductVersion

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        entrar()


    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        MsgBox("The fucking Owner", MsgBoxStyle.OkOnly, "System")

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.UseSystemPasswordChar = False

        Else
            TextBox1.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            entrar()

        End If

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        entrar()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class



