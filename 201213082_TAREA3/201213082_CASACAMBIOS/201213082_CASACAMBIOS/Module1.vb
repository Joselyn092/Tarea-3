Module Module1
    Public Const tcDolar = 7.69
    Public Const tcPM = 0.38
    Public Const tcEuro = 8.79
    Public Const tcCCR = 0.012
    Public Const comisionCompra = 2.5 / 100
    Public Const comisionVenta = 3 / 100

    Dim total_parcial = 0
    Dim Total
    Sub limpiar()
        Form1.TxtCompra.Clear()
        Form1.TxtVenta.Clear()
        Form1.Cbcompra.Checked = False
        Form1.Cbventa.Checked = False


    End Sub

    Function calcularCompra(cantidadCompra As Double, tipoCompra As Double,) As Double
        If cantidadCompra > 0 Then
            total_parcial = cantidadCompra / tipoCompra
            Total = total_parcial * comisionCompra + total_parcial

        End If
        Return Math.Round(Total, 2)
    End Function

    Function calcularVenta(cantidadVenta As Double, tipoVenta As Double,) As Double
        If cantidadVenta > 0 Then
            total_parcial = cantidadVenta * tipoVenta
            Total = total_parcial * comisionCompra + total_parcial

        End If
        Return Math.Round(Total, 2)
    End Function

End Module
