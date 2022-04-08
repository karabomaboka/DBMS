Partial Public Class frmMaximum
  Inherits System.Windows.Forms.Form

  <System.Diagnostics.DebuggerNonUserCode()> _
  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

  End Sub

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.lblFirstNum = New System.Windows.Forms.Label()
    Me.lblSecondNum = New System.Windows.Forms.Label()
    Me.btnFindLargest = New System.Windows.Forms.Button()
    Me.txtResult = New System.Windows.Forms.TextBox()
    Me.txtFirstNum = New System.Windows.Forms.TextBox()
    Me.txtSecondNum = New System.Windows.Forms.TextBox()
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.SuspendLayout()
    '
    'lblFirstNum
    '
    Me.lblFirstNum.AutoSize = True
    Me.lblFirstNum.Location = New System.Drawing.Point(80, 12)
    Me.lblFirstNum.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.lblFirstNum.Name = "lblFirstNum"
    Me.lblFirstNum.Size = New System.Drawing.Size(91, 17)
    Me.lblFirstNum.TabIndex = 0
    Me.lblFirstNum.Text = "First number:"
    '
    'lblSecondNum
    '
    Me.lblSecondNum.AutoSize = True
    Me.lblSecondNum.Location = New System.Drawing.Point(56, 42)
    Me.lblSecondNum.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Me.lblSecondNum.Name = "lblSecondNum"
    Me.lblSecondNum.Size = New System.Drawing.Size(112, 17)
    Me.lblSecondNum.TabIndex = 2
    Me.lblSecondNum.Text = "Second number:"
    '
    'btnFindLargest
    '
    Me.btnFindLargest.Location = New System.Drawing.Point(59, 69)
    Me.btnFindLargest.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnFindLargest.Name = "btnFindLargest"
    Me.btnFindLargest.Size = New System.Drawing.Size(175, 36)
    Me.btnFindLargest.TabIndex = 4
    Me.btnFindLargest.Text = "Find Largest Value" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    '
    'txtResult
    '
    Me.txtResult.Location = New System.Drawing.Point(59, 113)
    Me.txtResult.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.txtResult.Name = "txtResult"
    Me.txtResult.ReadOnly = True
    Me.txtResult.Size = New System.Drawing.Size(175, 22)
    Me.txtResult.TabIndex = 5
    '
    'txtFirstNum
    '
    Me.txtFirstNum.Location = New System.Drawing.Point(175, 9)
    Me.txtFirstNum.Margin = New System.Windows.Forms.Padding(4)
    Me.txtFirstNum.Name = "txtFirstNum"
    Me.txtFirstNum.Size = New System.Drawing.Size(61, 22)
    Me.txtFirstNum.TabIndex = 1
    '
    'txtSecondNum
    '
    Me.txtSecondNum.Location = New System.Drawing.Point(175, 39)
    Me.txtSecondNum.Margin = New System.Windows.Forms.Padding(4)
    Me.txtSecondNum.Name = "txtSecondNum"
    Me.txtSecondNum.Size = New System.Drawing.Size(61, 22)
    Me.txtSecondNum.TabIndex = 3
    '
    'frmMaximum
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(292, 143)
    Me.Controls.Add(Me.txtSecondNum)
    Me.Controls.Add(Me.txtFirstNum)
    Me.Controls.Add(Me.txtResult)
    Me.Controls.Add(Me.btnFindLargest)
    Me.Controls.Add(Me.lblSecondNum)
    Me.Controls.Add(Me.lblFirstNum)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmMaximum"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Maximum"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblFirstNum As System.Windows.Forms.Label
  Friend WithEvents lblSecondNum As System.Windows.Forms.Label
  Friend WithEvents btnFindLargest As System.Windows.Forms.Button
  Friend WithEvents txtResult As System.Windows.Forms.TextBox
  Friend WithEvents txtFirstNum As System.Windows.Forms.TextBox
  Friend WithEvents txtSecondNum As System.Windows.Forms.TextBox
  Friend WithEvents ToolTip1 As ToolTip
End Class
