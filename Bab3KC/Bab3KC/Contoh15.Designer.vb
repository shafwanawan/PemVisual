<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contoh15
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
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.btnDateNames = New System.Windows.Forms.Button()
        Me.btnDateProperties = New System.Windows.Forms.Button()
        Me.btnDateLiterals = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(104, 152)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(179, 42)
        Me.btnShowDate.TabIndex = 8
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnDateNames
        '
        Me.btnDateNames.Location = New System.Drawing.Point(408, 152)
        Me.btnDateNames.Name = "btnDateNames"
        Me.btnDateNames.Size = New System.Drawing.Size(146, 42)
        Me.btnDateNames.TabIndex = 10
        Me.btnDateNames.Text = "Date Names"
        Me.btnDateNames.UseVisualStyleBackColor = True
        '
        'btnDateProperties
        '
        Me.btnDateProperties.Location = New System.Drawing.Point(136, 247)
        Me.btnDateProperties.Name = "btnDateProperties"
        Me.btnDateProperties.Size = New System.Drawing.Size(117, 36)
        Me.btnDateProperties.TabIndex = 11
        Me.btnDateProperties.Text = "Date Properties"
        Me.btnDateProperties.UseVisualStyleBackColor = True
        '
        'btnDateLiterals
        '
        Me.btnDateLiterals.Location = New System.Drawing.Point(423, 264)
        Me.btnDateLiterals.Name = "btnDateLiterals"
        Me.btnDateLiterals.Size = New System.Drawing.Size(120, 29)
        Me.btnDateLiterals.TabIndex = 12
        Me.btnDateLiterals.Text = "Date Literals"
        Me.btnDateLiterals.UseVisualStyleBackColor = True
        '
        'Contoh15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 419)
        Me.Controls.Add(Me.btnDateLiterals)
        Me.Controls.Add(Me.btnDateProperties)
        Me.Controls.Add(Me.btnDateNames)
        Me.Controls.Add(Me.btnShowDate)
        Me.Name = "Contoh15"
        Me.Text = "Contoh15"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShowDate As Button
    Friend WithEvents btnDateNames As Button
    Friend WithEvents btnDateProperties As Button
    Friend WithEvents btnDateLiterals As Button
End Class
