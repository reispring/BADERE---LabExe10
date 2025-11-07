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
        Me.txtNumbers = New System.Windows.Forms.TextBox()
        Me.btnSaveSort = New System.Windows.Forms.Button()
        Me.Sorted = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(286, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter numbers: "
        '
        'txtNumbers
        '
        Me.txtNumbers.Location = New System.Drawing.Point(279, 71)
        Me.txtNumbers.Name = "txtNumbers"
        Me.txtNumbers.Size = New System.Drawing.Size(210, 20)
        Me.txtNumbers.TabIndex = 1
        '
        'btnSaveSort
        '
        Me.btnSaveSort.Location = New System.Drawing.Point(332, 107)
        Me.btnSaveSort.Name = "btnSaveSort"
        Me.btnSaveSort.Size = New System.Drawing.Size(100, 23)
        Me.btnSaveSort.TabIndex = 2
        Me.btnSaveSort.Text = "Save and Sort"
        Me.btnSaveSort.UseVisualStyleBackColor = True
        '
        'Sorted
        '
        Me.Sorted.FormattingEnabled = True
        Me.Sorted.Location = New System.Drawing.Point(279, 171)
        Me.Sorted.Name = "Sorted"
        Me.Sorted.Size = New System.Drawing.Size(210, 147)
        Me.Sorted.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Sorted)
        Me.Controls.Add(Me.btnSaveSort)
        Me.Controls.Add(Me.txtNumbers)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumbers As TextBox
    Friend WithEvents btnSaveSort As Button
    Friend WithEvents Sorted As ListBox
End Class
