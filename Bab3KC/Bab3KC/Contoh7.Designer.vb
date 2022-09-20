<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contoh7
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
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.btnLenght = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(32, 120)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(221, 20)
        Me.txtString.TabIndex = 1
        '
        'btnLenght
        '
        Me.btnLenght.Location = New System.Drawing.Point(313, 112)
        Me.btnLenght.Name = "btnLenght"
        Me.btnLenght.Size = New System.Drawing.Size(89, 35)
        Me.btnLenght.TabIndex = 2
        Me.btnLenght.Text = "Lenght"
        Me.btnLenght.UseVisualStyleBackColor = True
        '
        'Contoh7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 348)
        Me.Controls.Add(Me.btnLenght)
        Me.Controls.Add(Me.txtString)
        Me.Name = "Contoh7"
        Me.Text = "Contoh7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtString As TextBox
    Friend WithEvents btnLenght As Button
End Class
