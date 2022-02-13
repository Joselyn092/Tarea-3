Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles Gbx1.Enter

    End Sub

    Private Sub CbCompra_CheckedChanged(sender As Object, e As EventArgs) Handles Cbcompra.CheckedChanged
        If Cbcompra.Checked = True Then
            TxtCompra.Enabled = True
        Else
            TxtCompra.Enabled = False
        End If
    End Sub

    Private Sub Cbventa_CheckedChanged(sender As Object, e As EventArgs) Handles Cbventa.CheckedChanged
        If Cbventa.Checked = True Then
            TxtVenta.Enabled = True
        Else
            TxtVenta.Enabled = False
        End If
    End Sub

    Private Sub BtCalcular_Click(sender As Object, e As EventArgs) Handles BtCalcular.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub BtLimpiar_Click(sender As Object, e As EventArgs) Handles BtLimpiar.Click
        limpiar()

    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
        MsgBox "¿Desea salir?"
    End Sub
End Class
