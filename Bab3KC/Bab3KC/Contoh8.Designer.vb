<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contoh8
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
        Me.btnSubStrings = New System.Windows.Forms.Button()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSubStrings
        '
        Me.btnSubStrings.Location = New System.Drawing.Point(36, 190)
        Me.btnSubStrings.Name = "btnSubStrings"
        Me.btnSubStrings.Size = New System.Drawing.Size(321, 87)
        Me.btnSubStrings.TabIndex = 1
        Me.btnSubStrings.Text = "SubStrings"
        Me.btnSubStrings.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(80, 140)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(242, 20)
        Me.txtString.TabIndex = 2
        '
        'Contoh8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 367)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.btnSubStrings)
        Me.Name = "Contoh8"
        Me.Text = "Contoh8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubStrings As Button
    Friend WithEvents txtString As TextBox
End Class
