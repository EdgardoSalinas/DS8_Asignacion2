<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx_y = New System.Windows.Forms.TextBox()
        Me.tx_q = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_g = New System.Windows.Forms.TextBox()
        Me.bt_calcular = New System.Windows.Forms.Button()
        Me.tx_resultado = New System.Windows.Forms.TextBox()
        Me.resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calcular la formula:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(239, 74)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(321, 52)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "E = y + q^2 / ( 2 * g *  y ^2 )"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "y ="
        '
        'tx_y
        '
        Me.tx_y.Location = New System.Drawing.Point(203, 172)
        Me.tx_y.Name = "tx_y"
        Me.tx_y.Size = New System.Drawing.Size(100, 20)
        Me.tx_y.TabIndex = 3
        '
        'tx_q
        '
        Me.tx_q.Location = New System.Drawing.Point(394, 172)
        Me.tx_q.Name = "tx_q"
        Me.tx_q.Size = New System.Drawing.Size(100, 20)
        Me.tx_q.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "q ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(533, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "g ="
        '
        'tx_g
        '
        Me.tx_g.Location = New System.Drawing.Point(584, 172)
        Me.tx_g.Name = "tx_g"
        Me.tx_g.Size = New System.Drawing.Size(100, 20)
        Me.tx_g.TabIndex = 7
        '
        'bt_calcular
        '
        Me.bt_calcular.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bt_calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_calcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_calcular.Location = New System.Drawing.Point(274, 244)
        Me.bt_calcular.Name = "bt_calcular"
        Me.bt_calcular.Size = New System.Drawing.Size(273, 42)
        Me.bt_calcular.TabIndex = 8
        Me.bt_calcular.Text = "Obtener Resultado"
        Me.bt_calcular.UseVisualStyleBackColor = False
        '
        'tx_resultado
        '
        Me.tx_resultado.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tx_resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_resultado.Location = New System.Drawing.Point(447, 332)
        Me.tx_resultado.Name = "tx_resultado"
        Me.tx_resultado.ReadOnly = True
        Me.tx_resultado.Size = New System.Drawing.Size(100, 35)
        Me.tx_resultado.TabIndex = 9
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(274, 338)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(142, 29)
        Me.resultado.TabIndex = 10
        Me.resultado.Text = "Resultado ="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.tx_resultado)
        Me.Controls.Add(Me.bt_calcular)
        Me.Controls.Add(Me.tx_g)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tx_q)
        Me.Controls.Add(Me.tx_y)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Asignación No.2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tx_y As TextBox
    Friend WithEvents tx_q As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tx_g As TextBox
    Friend WithEvents bt_calcular As Button
    Friend WithEvents tx_resultado As TextBox
    Friend WithEvents resultado As Label
End Class
