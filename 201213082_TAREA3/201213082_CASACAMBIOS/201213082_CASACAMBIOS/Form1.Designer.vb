<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Gbx1 = New System.Windows.Forms.GroupBox()
        Me.Cbventa = New System.Windows.Forms.CheckBox()
        Me.Cbcompra = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbVenta = New System.Windows.Forms.Label()
        Me.LbCompra = New System.Windows.Forms.Label()
        Me.TxtVenta = New System.Windows.Forms.TextBox()
        Me.TxtCompra = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbCdolar = New System.Windows.Forms.RadioButton()
        Me.RbCpeso = New System.Windows.Forms.RadioButton()
        Me.RbCeuro = New System.Windows.Forms.RadioButton()
        Me.RbCcolones = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbVcolones = New System.Windows.Forms.RadioButton()
        Me.RbVeuro = New System.Windows.Forms.RadioButton()
        Me.RbVpeso = New System.Windows.Forms.RadioButton()
        Me.RbVdolar = New System.Windows.Forms.RadioButton()
        Me.BtCalcular = New System.Windows.Forms.Button()
        Me.BtLimpiar = New System.Windows.Forms.Button()
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.Gbx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx1
        '
        Me.Gbx1.Controls.Add(Me.Cbventa)
        Me.Gbx1.Controls.Add(Me.Cbcompra)
        Me.Gbx1.Location = New System.Drawing.Point(29, 43)
        Me.Gbx1.Name = "Gbx1"
        Me.Gbx1.Size = New System.Drawing.Size(200, 100)
        Me.Gbx1.TabIndex = 0
        Me.Gbx1.TabStop = False
        Me.Gbx1.Text = "Transacciones"
        '
        'Cbventa
        '
        Me.Cbventa.AutoSize = True
        Me.Cbventa.Location = New System.Drawing.Point(24, 60)
        Me.Cbventa.Name = "Cbventa"
        Me.Cbventa.Size = New System.Drawing.Size(64, 20)
        Me.Cbventa.TabIndex = 1
        Me.Cbventa.Text = "Venta"
        Me.Cbventa.UseVisualStyleBackColor = True
        '
        'Cbcompra
        '
        Me.Cbcompra.AutoSize = True
        Me.Cbcompra.Location = New System.Drawing.Point(24, 33)
        Me.Cbcompra.Name = "Cbcompra"
        Me.Cbcompra.Size = New System.Drawing.Size(77, 20)
        Me.Cbcompra.TabIndex = 0
        Me.Cbcompra.Text = "Compra"
        Me.Cbcompra.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbVenta)
        Me.GroupBox1.Controls.Add(Me.LbCompra)
        Me.GroupBox1.Controls.Add(Me.TxtVenta)
        Me.GroupBox1.Controls.Add(Me.TxtCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 124)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Cantidad"
        '
        'LbVenta
        '
        Me.LbVenta.AutoSize = True
        Me.LbVenta.Location = New System.Drawing.Point(7, 81)
        Me.LbVenta.Name = "LbVenta"
        Me.LbVenta.Size = New System.Drawing.Size(42, 16)
        Me.LbVenta.TabIndex = 3
        Me.LbVenta.Text = "Venta"
        '
        'LbCompra
        '
        Me.LbCompra.AutoSize = True
        Me.LbCompra.Location = New System.Drawing.Point(7, 42)
        Me.LbCompra.Name = "LbCompra"
        Me.LbCompra.Size = New System.Drawing.Size(55, 16)
        Me.LbCompra.TabIndex = 2
        Me.LbCompra.Text = "Compra"
        '
        'TxtVenta
        '
        Me.TxtVenta.Enabled = False
        Me.TxtVenta.Location = New System.Drawing.Point(85, 81)
        Me.TxtVenta.Name = "TxtVenta"
        Me.TxtVenta.Size = New System.Drawing.Size(100, 22)
        Me.TxtVenta.TabIndex = 1
        '
        'TxtCompra
        '
        Me.TxtCompra.Enabled = False
        Me.TxtCompra.Location = New System.Drawing.Point(85, 37)
        Me.TxtCompra.Name = "TxtCompra"
        Me.TxtCompra.Size = New System.Drawing.Size(100, 22)
        Me.TxtCompra.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbCcolones)
        Me.GroupBox2.Controls.Add(Me.RbCeuro)
        Me.GroupBox2.Controls.Add(Me.RbCpeso)
        Me.GroupBox2.Controls.Add(Me.RbCdolar)
        Me.GroupBox2.Location = New System.Drawing.Point(302, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(197, 208)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compra"
        '
        'RbCdolar
        '
        Me.RbCdolar.AutoSize = True
        Me.RbCdolar.Location = New System.Drawing.Point(18, 22)
        Me.RbCdolar.Name = "RbCdolar"
        Me.RbCdolar.Size = New System.Drawing.Size(61, 20)
        Me.RbCdolar.TabIndex = 0
        Me.RbCdolar.TabStop = True
        Me.RbCdolar.Text = "Dolar"
        Me.RbCdolar.UseVisualStyleBackColor = True
        '
        'RbCpeso
        '
        Me.RbCpeso.Location = New System.Drawing.Point(18, 60)
        Me.RbCpeso.Name = "RbCpeso"
        Me.RbCpeso.Size = New System.Drawing.Size(125, 20)
        Me.RbCpeso.TabIndex = 0
        Me.RbCpeso.TabStop = True
        Me.RbCpeso.Text = "Peso Mexicano"
        Me.RbCpeso.UseVisualStyleBackColor = True
        '
        'RbCeuro
        '
        Me.RbCeuro.Location = New System.Drawing.Point(18, 100)
        Me.RbCeuro.Name = "RbCeuro"
        Me.RbCeuro.Size = New System.Drawing.Size(109, 20)
        Me.RbCeuro.TabIndex = 0
        Me.RbCeuro.TabStop = True
        Me.RbCeuro.Text = "Euro"
        Me.RbCeuro.UseVisualStyleBackColor = True
        '
        'RbCcolones
        '
        Me.RbCcolones.Location = New System.Drawing.Point(18, 145)
        Me.RbCcolones.Name = "RbCcolones"
        Me.RbCcolones.Size = New System.Drawing.Size(173, 20)
        Me.RbCcolones.TabIndex = 0
        Me.RbCcolones.TabStop = True
        Me.RbCcolones.Text = "Colones Costarricense"
        Me.RbCcolones.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbVcolones)
        Me.GroupBox3.Controls.Add(Me.RbVeuro)
        Me.GroupBox3.Controls.Add(Me.RbVpeso)
        Me.GroupBox3.Controls.Add(Me.RbVdolar)
        Me.GroupBox3.Location = New System.Drawing.Point(536, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(197, 208)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Venta"
        '
        'RbVcolones
        '
        Me.RbVcolones.Location = New System.Drawing.Point(18, 145)
        Me.RbVcolones.Name = "RbVcolones"
        Me.RbVcolones.Size = New System.Drawing.Size(173, 20)
        Me.RbVcolones.TabIndex = 0
        Me.RbVcolones.TabStop = True
        Me.RbVcolones.Text = "Colones Costarricense"
        Me.RbVcolones.UseVisualStyleBackColor = True
        '
        'RbVeuro
        '
        Me.RbVeuro.Location = New System.Drawing.Point(18, 100)
        Me.RbVeuro.Name = "RbVeuro"
        Me.RbVeuro.Size = New System.Drawing.Size(109, 20)
        Me.RbVeuro.TabIndex = 0
        Me.RbVeuro.TabStop = True
        Me.RbVeuro.Text = "Euro"
        Me.RbVeuro.UseVisualStyleBackColor = True
        '
        'RbVpeso
        '
        Me.RbVpeso.Location = New System.Drawing.Point(18, 60)
        Me.RbVpeso.Name = "RbVpeso"
        Me.RbVpeso.Size = New System.Drawing.Size(125, 20)
        Me.RbVpeso.TabIndex = 0
        Me.RbVpeso.TabStop = True
        Me.RbVpeso.Text = "Peso Mexicano"
        Me.RbVpeso.UseVisualStyleBackColor = True
        '
        'RbVdolar
        '
        Me.RbVdolar.AutoSize = True
        Me.RbVdolar.Location = New System.Drawing.Point(18, 22)
        Me.RbVdolar.Name = "RbVdolar"
        Me.RbVdolar.Size = New System.Drawing.Size(61, 20)
        Me.RbVdolar.TabIndex = 0
        Me.RbVdolar.TabStop = True
        Me.RbVdolar.Text = "Dolar"
        Me.RbVdolar.UseVisualStyleBackColor = True
        '
        'BtCalcular
        '
        Me.BtCalcular.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtCalcular.Location = New System.Drawing.Point(302, 280)
        Me.BtCalcular.Name = "BtCalcular"
        Me.BtCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtCalcular.TabIndex = 4
        Me.BtCalcular.Text = "Calcular"
        Me.BtCalcular.UseVisualStyleBackColor = False
        '
        'BtLimpiar
        '
        Me.BtLimpiar.Location = New System.Drawing.Point(442, 280)
        Me.BtLimpiar.Name = "BtLimpiar"
        Me.BtLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtLimpiar.TabIndex = 5
        Me.BtLimpiar.Text = "Limpiar"
        Me.BtLimpiar.UseVisualStyleBackColor = True
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(565, 280)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtSalir.TabIndex = 6
        Me.BtSalir.Text = "Salir "
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(800, 372)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtLimpiar)
        Me.Controls.Add(Me.BtCalcular)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Gbx1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Gbx1.ResumeLayout(False)
        Me.Gbx1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gbx1 As GroupBox
    Friend WithEvents Cbventa As CheckBox
    Friend WithEvents Cbcompra As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LbVenta As Label
    Friend WithEvents LbCompra As Label
    Friend WithEvents TxtVenta As TextBox
    Friend WithEvents TxtCompra As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RbCdolar As RadioButton
    Friend WithEvents RbCcolones As RadioButton
    Friend WithEvents RbCeuro As RadioButton
    Friend WithEvents RbCpeso As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RbVcolones As RadioButton
    Friend WithEvents RbVeuro As RadioButton
    Friend WithEvents RbVpeso As RadioButton
    Friend WithEvents RbVdolar As RadioButton
    Friend WithEvents BtCalcular As Button
    Friend WithEvents BtLimpiar As Button
    Friend WithEvents BtSalir As Button
End Class
