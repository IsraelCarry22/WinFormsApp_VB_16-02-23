<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Nombre_text = New System.Windows.Forms.TextBox()
        Me.Datos_Text = New System.Windows.Forms.TextBox()
        Me.text_nombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Telef_Text = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Nombre_text
        '
        Me.Nombre_text.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Nombre_text.Location = New System.Drawing.Point(112, 46)
        Me.Nombre_text.Multiline = True
        Me.Nombre_text.Name = "Nombre_text"
        Me.Nombre_text.Size = New System.Drawing.Size(171, 30)
        Me.Nombre_text.TabIndex = 0
        '
        'Datos_Text
        '
        Me.Datos_Text.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Datos_Text.Location = New System.Drawing.Point(90, 294)
        Me.Datos_Text.Multiline = True
        Me.Datos_Text.Name = "Datos_Text"
        Me.Datos_Text.Size = New System.Drawing.Size(244, 30)
        Me.Datos_Text.TabIndex = 2
        '
        'text_nombre
        '
        Me.text_nombre.AutoSize = True
        Me.text_nombre.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.text_nombre.Location = New System.Drawing.Point(12, 46)
        Me.text_nombre.Name = "text_nombre"
        Me.text_nombre.Size = New System.Drawing.Size(94, 30)
        Me.text_nombre.TabIndex = 3
        Me.text_nombre.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(9, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Telefono:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(112, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 65)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Telef_Text
        '
        Me.Telef_Text.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Telef_Text.Location = New System.Drawing.Point(112, 112)
        Me.Telef_Text.Multiline = True
        Me.Telef_Text.Name = "Telef_Text"
        Me.Telef_Text.Size = New System.Drawing.Size(171, 30)
        Me.Telef_Text.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Datos:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 353)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.text_nombre)
        Me.Controls.Add(Me.Datos_Text)
        Me.Controls.Add(Me.Telef_Text)
        Me.Controls.Add(Me.Nombre_text)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nombre_text As TextBox
    Friend WithEvents Datos_Text As TextBox
    Friend WithEvents text_nombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Telef_Text As TextBox
    Friend WithEvents Label1 As Label
End Class
