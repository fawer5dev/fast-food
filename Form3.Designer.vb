<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class COMIDAS3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lMesa = New System.Windows.Forms.Label
        Me.lMesero = New System.Windows.Forms.Label
        Me.lbMenu = New System.Windows.Forms.ListBox
        Me.lbValor = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbValor = New System.Windows.Forms.TextBox
        Me.bCobrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lMesa
        '
        Me.lMesa.AutoSize = True
        Me.lMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMesa.Location = New System.Drawing.Point(71, 14)
        Me.lMesa.Name = "lMesa"
        Me.lMesa.Size = New System.Drawing.Size(61, 24)
        Me.lMesa.TabIndex = 0
        Me.lMesa.Text = "Mesa:"
        '
        'lMesero
        '
        Me.lMesero.AutoSize = True
        Me.lMesero.Location = New System.Drawing.Point(71, 39)
        Me.lMesero.Name = "lMesero"
        Me.lMesero.Size = New System.Drawing.Size(45, 13)
        Me.lMesero.TabIndex = 1
        Me.lMesero.Text = "Mesero:"
        '
        'lbMenu
        '
        Me.lbMenu.Enabled = False
        Me.lbMenu.FormattingEnabled = True
        Me.lbMenu.Location = New System.Drawing.Point(12, 68)
        Me.lbMenu.Name = "lbMenu"
        Me.lbMenu.Size = New System.Drawing.Size(202, 160)
        Me.lbMenu.TabIndex = 14
        '
        'lbValor
        '
        Me.lbValor.Enabled = False
        Me.lbValor.FormattingEnabled = True
        Me.lbValor.Location = New System.Drawing.Point(220, 68)
        Me.lbValor.Name = "lbValor"
        Me.lbValor.Size = New System.Drawing.Size(83, 160)
        Me.lbValor.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Total:"
        '
        'tbValor
        '
        Me.tbValor.Enabled = False
        Me.tbValor.Location = New System.Drawing.Point(220, 244)
        Me.tbValor.Name = "tbValor"
        Me.tbValor.Size = New System.Drawing.Size(83, 20)
        Me.tbValor.TabIndex = 17
        '
        'bCobrar
        '
        Me.bCobrar.Location = New System.Drawing.Point(12, 273)
        Me.bCobrar.Name = "bCobrar"
        Me.bCobrar.Size = New System.Drawing.Size(290, 33)
        Me.bCobrar.TabIndex = 18
        Me.bCobrar.Text = "Cobrar"
        Me.bCobrar.UseVisualStyleBackColor = True
        '
        'COMIDAS3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 318)
        Me.Controls.Add(Me.bCobrar)
        Me.Controls.Add(Me.tbValor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbValor)
        Me.Controls.Add(Me.lbMenu)
        Me.Controls.Add(Me.lMesero)
        Me.Controls.Add(Me.lMesa)
        Me.Name = "COMIDAS3"
        Me.Text = "Comidas Rapidas Fawer Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lMesa As System.Windows.Forms.Label
    Friend WithEvents lMesero As System.Windows.Forms.Label
    Friend WithEvents lbMenu As System.Windows.Forms.ListBox
    Friend WithEvents lbValor As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbValor As System.Windows.Forms.TextBox
    Friend WithEvents bCobrar As System.Windows.Forms.Button
End Class
