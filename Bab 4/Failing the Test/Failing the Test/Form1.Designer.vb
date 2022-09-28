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
        Me.btnAnotherIf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAnotherIf
        '
        Me.btnAnotherIf.Location = New System.Drawing.Point(161, 161)
        Me.btnAnotherIf.Name = "btnAnotherIf"
        Me.btnAnotherIf.Size = New System.Drawing.Size(75, 23)
        Me.btnAnotherIf.TabIndex = 0
        Me.btnAnotherIf.Text = "OK"
        Me.btnAnotherIf.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 196)
        Me.Controls.Add(Me.btnAnotherIf)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAnotherIf As Button
End Class
