<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contoh5
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
        Me.btnStrings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStrings
        '
        Me.btnStrings.Location = New System.Drawing.Point(50, 98)
        Me.btnStrings.Name = "btnStrings"
        Me.btnStrings.Size = New System.Drawing.Size(184, 65)
        Me.btnStrings.TabIndex = 1
        Me.btnStrings.Text = "Using Strings"
        Me.btnStrings.UseVisualStyleBackColor = True
        '
        'Contoh5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnStrings)
        Me.Name = "Contoh5"
        Me.Text = "Contoh5"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStrings As Button
End Class
