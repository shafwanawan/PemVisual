<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bab4
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
        Me.btnData = New System.Windows.Forms.ListBox()
        Me.ForNextLoop = New System.Windows.Forms.Button()
        Me.btnForNextLoopWithStep = New System.Windows.Forms.Button()
        Me.btnBacwardsForNextLLoop = New System.Windows.Forms.Button()
        Me.btnForEachLoop = New System.Windows.Forms.Button()
        Me.btnDoUntilLoop = New System.Windows.Forms.Button()
        Me.btnDoWhileLoop = New System.Windows.Forms.Button()
        Me.btnNestedLoops = New System.Windows.Forms.Button()
        Me.btnQuittingAForLoop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnData
        '
        Me.btnData.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnData.FormattingEnabled = True
        Me.btnData.ItemHeight = 15
        Me.btnData.Location = New System.Drawing.Point(9, 37)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(230, 409)
        Me.btnData.TabIndex = 0
        '
        'ForNextLoop
        '
        Me.ForNextLoop.Location = New System.Drawing.Point(305, 61)
        Me.ForNextLoop.Name = "ForNextLoop"
        Me.ForNextLoop.Size = New System.Drawing.Size(203, 29)
        Me.ForNextLoop.TabIndex = 1
        Me.ForNextLoop.Text = "For Next Loop"
        Me.ForNextLoop.UseVisualStyleBackColor = True
        '
        'btnForNextLoopWithStep
        '
        Me.btnForNextLoopWithStep.Location = New System.Drawing.Point(305, 96)
        Me.btnForNextLoopWithStep.Name = "btnForNextLoopWithStep"
        Me.btnForNextLoopWithStep.Size = New System.Drawing.Size(203, 29)
        Me.btnForNextLoopWithStep.TabIndex = 2
        Me.btnForNextLoopWithStep.Text = "For Next Loop w / Step"
        Me.btnForNextLoopWithStep.UseVisualStyleBackColor = True
        '
        'btnBacwardsForNextLLoop
        '
        Me.btnBacwardsForNextLLoop.Location = New System.Drawing.Point(305, 131)
        Me.btnBacwardsForNextLLoop.Name = "btnBacwardsForNextLLoop"
        Me.btnBacwardsForNextLLoop.Size = New System.Drawing.Size(203, 29)
        Me.btnBacwardsForNextLLoop.TabIndex = 3
        Me.btnBacwardsForNextLLoop.Text = "Backwards For Next Loop"
        Me.btnBacwardsForNextLLoop.UseVisualStyleBackColor = True
        '
        'btnForEachLoop
        '
        Me.btnForEachLoop.Location = New System.Drawing.Point(305, 166)
        Me.btnForEachLoop.Name = "btnForEachLoop"
        Me.btnForEachLoop.Size = New System.Drawing.Size(203, 29)
        Me.btnForEachLoop.TabIndex = 4
        Me.btnForEachLoop.Text = "For Each Loop"
        Me.btnForEachLoop.UseVisualStyleBackColor = True
        '
        'btnDoUntilLoop
        '
        Me.btnDoUntilLoop.Location = New System.Drawing.Point(305, 201)
        Me.btnDoUntilLoop.Name = "btnDoUntilLoop"
        Me.btnDoUntilLoop.Size = New System.Drawing.Size(203, 29)
        Me.btnDoUntilLoop.TabIndex = 5
        Me.btnDoUntilLoop.Text = "Do Until Loop"
        Me.btnDoUntilLoop.UseVisualStyleBackColor = True
        '
        'btnDoWhileLoop
        '
        Me.btnDoWhileLoop.Location = New System.Drawing.Point(305, 236)
        Me.btnDoWhileLoop.Name = "btnDoWhileLoop"
        Me.btnDoWhileLoop.Size = New System.Drawing.Size(203, 29)
        Me.btnDoWhileLoop.TabIndex = 6
        Me.btnDoWhileLoop.Text = " Do While Loop."
        Me.btnDoWhileLoop.UseVisualStyleBackColor = True
        '
        'btnNestedLoops
        '
        Me.btnNestedLoops.Location = New System.Drawing.Point(305, 271)
        Me.btnNestedLoops.Name = "btnNestedLoops"
        Me.btnNestedLoops.Size = New System.Drawing.Size(203, 29)
        Me.btnNestedLoops.TabIndex = 7
        Me.btnNestedLoops.Text = "Nested Loops"
        Me.btnNestedLoops.UseVisualStyleBackColor = True
        '
        'btnQuittingAForLoop
        '
        Me.btnQuittingAForLoop.Location = New System.Drawing.Point(305, 306)
        Me.btnQuittingAForLoop.Name = "btnQuittingAForLoop"
        Me.btnQuittingAForLoop.Size = New System.Drawing.Size(203, 29)
        Me.btnQuittingAForLoop.TabIndex = 8
        Me.btnQuittingAForLoop.Text = "Quitting A For Loop"
        Me.btnQuittingAForLoop.UseVisualStyleBackColor = True
        '
        'Bab4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(562, 466)
        Me.Controls.Add(Me.btnQuittingAForLoop)
        Me.Controls.Add(Me.btnNestedLoops)
        Me.Controls.Add(Me.btnDoWhileLoop)
        Me.Controls.Add(Me.btnDoUntilLoop)
        Me.Controls.Add(Me.btnForEachLoop)
        Me.Controls.Add(Me.btnBacwardsForNextLLoop)
        Me.Controls.Add(Me.btnForNextLoopWithStep)
        Me.Controls.Add(Me.ForNextLoop)
        Me.Controls.Add(Me.btnData)
        Me.Name = "Bab4"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnData As ListBox
    Friend WithEvents ForNextLoop As Button
    Friend WithEvents btnForNextLoopWithStep As Button
    Friend WithEvents btnBacwardsForNextLLoop As Button
    Friend WithEvents btnForEachLoop As Button
    Friend WithEvents btnDoUntilLoop As Button
    Friend WithEvents btnDoWhileLoop As Button
    Friend WithEvents btnNestedLoops As Button
    Friend WithEvents btnQuittingAForLoop As Button
End Class
