<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pass3
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pass3))
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(12, 259)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(375, 39)
        Me.MaterialRaisedButton1.TabIndex = 7
        Me.MaterialRaisedButton1.Text = "SUBMIT"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PasswordMGT.My.Resources.Resources.pass
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 91)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.BackColor = System.Drawing.Color.White
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = ""
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(12, 148)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(375, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 15
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "PasswordMGT"
        Me.NotifyIcon1.Visible = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Open Sans Light", 12.25!)
        Me.Label30.Location = New System.Drawing.Point(12, 122)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(136, 23)
        Me.Label30.TabIndex = 31
        Me.Label30.Text = "Client Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans Light", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 23)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Master Password:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Open Sans Light", 25.25!)
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 200)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(375, 47)
        Me.RichTextBox1.TabIndex = 34
        Me.RichTextBox1.Text = ""
        '
        'Pass3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 304)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pass3"
        Me.Text = "Pass3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Label30 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
