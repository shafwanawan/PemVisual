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
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.btnArrayElement = New System.Windows.Forms.Button()
        Me.btnEnumerateArray = New System.Windows.Forms.Button()
        Me.btnArrayAsParameters = New System.Windows.Forms.Button()
        Me.btnMoreArrayParameters = New System.Windows.Forms.Button()
        Me.btnSortingArrays = New System.Windows.Forms.Button()
        Me.btnReversingAnArray = New System.Windows.Forms.Button()
        Me.btnInitializingArraysWith = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFriends
        '
        Me.lstFriends.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.ItemHeight = 15
        Me.lstFriends.Location = New System.Drawing.Point(46, 12)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(207, 304)
        Me.lstFriends.TabIndex = 0
        '
        'btnArrayElement
        '
        Me.btnArrayElement.Location = New System.Drawing.Point(315, 12)
        Me.btnArrayElement.Name = "btnArrayElement"
        Me.btnArrayElement.Size = New System.Drawing.Size(145, 23)
        Me.btnArrayElement.TabIndex = 1
        Me.btnArrayElement.Text = "Array Element"
        Me.btnArrayElement.UseVisualStyleBackColor = True
        '
        'btnEnumerateArray
        '
        Me.btnEnumerateArray.Location = New System.Drawing.Point(315, 54)
        Me.btnEnumerateArray.Name = "btnEnumerateArray"
        Me.btnEnumerateArray.Size = New System.Drawing.Size(145, 23)
        Me.btnEnumerateArray.TabIndex = 2
        Me.btnEnumerateArray.Text = "Enumerate Array"
        Me.btnEnumerateArray.UseVisualStyleBackColor = True
        '
        'btnArrayAsParameters
        '
        Me.btnArrayAsParameters.Location = New System.Drawing.Point(315, 93)
        Me.btnArrayAsParameters.Name = "btnArrayAsParameters"
        Me.btnArrayAsParameters.Size = New System.Drawing.Size(145, 23)
        Me.btnArrayAsParameters.TabIndex = 3
        Me.btnArrayAsParameters.Text = "Array as Parameters"
        Me.btnArrayAsParameters.UseVisualStyleBackColor = True
        '
        'btnMoreArrayParameters
        '
        Me.btnMoreArrayParameters.Location = New System.Drawing.Point(315, 134)
        Me.btnMoreArrayParameters.Name = "btnMoreArrayParameters"
        Me.btnMoreArrayParameters.Size = New System.Drawing.Size(145, 23)
        Me.btnMoreArrayParameters.TabIndex = 4
        Me.btnMoreArrayParameters.Text = "More Array Parameters"
        Me.btnMoreArrayParameters.UseVisualStyleBackColor = True
        '
        'btnSortingArrays
        '
        Me.btnSortingArrays.Location = New System.Drawing.Point(315, 176)
        Me.btnSortingArrays.Name = "btnSortingArrays"
        Me.btnSortingArrays.Size = New System.Drawing.Size(145, 23)
        Me.btnSortingArrays.TabIndex = 5
        Me.btnSortingArrays.Text = "Sorting Arrays"
        Me.btnSortingArrays.UseVisualStyleBackColor = True
        '
        'btnReversingAnArray
        '
        Me.btnReversingAnArray.Location = New System.Drawing.Point(315, 216)
        Me.btnReversingAnArray.Name = "btnReversingAnArray"
        Me.btnReversingAnArray.Size = New System.Drawing.Size(145, 23)
        Me.btnReversingAnArray.TabIndex = 6
        Me.btnReversingAnArray.Text = "Reversing an Array"
        Me.btnReversingAnArray.UseVisualStyleBackColor = True
        '
        'btnInitializingArraysWith
        '
        Me.btnInitializingArraysWith.Location = New System.Drawing.Point(315, 257)
        Me.btnInitializingArraysWith.Name = "btnInitializingArraysWith"
        Me.btnInitializingArraysWith.Size = New System.Drawing.Size(145, 23)
        Me.btnInitializingArraysWith.TabIndex = 7
        Me.btnInitializingArraysWith.Text = "Initializing Arrays with"
        Me.btnInitializingArraysWith.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(536, 359)
        Me.Controls.Add(Me.btnInitializingArraysWith)
        Me.Controls.Add(Me.btnReversingAnArray)
        Me.Controls.Add(Me.btnSortingArrays)
        Me.Controls.Add(Me.btnMoreArrayParameters)
        Me.Controls.Add(Me.btnArrayAsParameters)
        Me.Controls.Add(Me.btnEnumerateArray)
        Me.Controls.Add(Me.btnArrayElement)
        Me.Controls.Add(Me.lstFriends)
        Me.Name = "Form1"
        Me.Text = "UnderstandingArrays"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFriends As ListBox
    Friend WithEvents btnArrayElement As Button
    Friend WithEvents btnEnumerateArray As Button
    Friend WithEvents btnArrayAsParameters As Button
    Friend WithEvents btnMoreArrayParameters As Button
    Friend WithEvents btnSortingArrays As Button
    Friend WithEvents btnReversingAnArray As Button
    Friend WithEvents btnInitializingArraysWith As Button
End Class
