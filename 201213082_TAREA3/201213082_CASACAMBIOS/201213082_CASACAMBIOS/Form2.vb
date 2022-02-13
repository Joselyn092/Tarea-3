Public Class Form2
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.RbCdolar.Checked Then
            LbC1.Text = Str(calcularCompra(Form1.TxtCompra.Text, tcDolar))
        End If

        If Form1.RbCpeso.Checked Then
            LbC2.Text = Str(calcularCompra(Form1.TxtCompra.Text, tcPM))
        End If

        If Form1.RbCeuro.Checked Then
            LbC3.Text = Str(calcularCompra(Form1.TxtCompra.Text, tcEuro))
        End If

        If Form1.RbCcolones.Checked Then
            LbC4.Text = Str(calcularCompra(Form1.TxtCompra.Text, tcCCR))
        End If

        If Form1.RbVdolar.Checkedked Then
            LbV1.Text = Str(calcularVenta(Form1.TxtVenta.Text, tcDolar))
        End If

        If Form1.RbCpeso.Checkedked Then
            LbV2.Text = Str(calcularVenta(Form1.TxtVenta.Text, tcPM))
        End If

        If Form1.RbVeuro.Checkedked Then
            LbV3.Text = Str(calcularVenta(Form1.TxtVenta.Text, tcEuro)
        End If

        If Form1.RbVcolones.Checkedked Then
            LbV4.Text = Str(calcularVenta(Form1.TxtVenta.Text, tcCCR))
        End If
    End Sub
End Class