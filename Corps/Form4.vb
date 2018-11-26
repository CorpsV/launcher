
Public Class Form4

    Dim frase = "Process.running: "
    Dim dica1 As String = "0wx172djh*a922.exe"
    Dim dica2 As String = "&#82.htm102w&/pubg"
    Dim dica3 As String = "ex.29x9&913mx1.bat"
    Dim dica4 As String = "d3d9a-18321wa91¨&@"
    Dim dica5 As String = "directhtml0(h1x12)"
    Dim dica6 As String = "data*(bas45x1.bat)"
    Dim dica7 As String = "Isc{everylop21x3z1"
    Dim cont As Integer = 0

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label7.Text = "Version: " + Application.ProductVersion

        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Label1.Visible = False
        Timer1.Stop()

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        cont = cont + 1
        If cont = 1 Then Me.Label1.Text = frase & dica1
        If cont = 2 Then Me.Label1.Text = frase & dica2
        If cont = 3 Then Me.Label1.Text = frase & dica3
        If cont = 4 Then Me.Label1.Text = frase & dica4
        If cont = 5 Then Me.Label1.Text = frase & dica5
        If cont = 6 Then Me.Label1.Text = frase & dica6
        If cont = 7 Then Me.Label1.Text = frase & dica7




        If cont = 7 Then
            Me.Label1.Text = frase & dica1
            cont = 0
        End If
    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Close()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        System.Threading.Thread.Sleep("2000")
        MsgBox("Bypass injected", MsgBoxStyle.OkOnly, "System")
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Button1.Enabled = False
        Label1.Visible = True
        Timer1.Start()
        Form3.Show()



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If Label3.Visible = True Then

            Label3.Visible = False

        Else
            Label3.Visible = True

        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Label4.Visible = True Then

            Label4.Visible = False

        Else
            Label4.Visible = True

        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If Label6.Visible = True Then

            Label6.Visible = False

        Else
            Label6.Visible = True

        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Label5.Visible = True Then

            Label5.Visible = False

        Else
            Label5.Visible = True

        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        MsgBox("The fucking Owner", MsgBoxStyle.OkOnly, "System")
    End Sub
End Class