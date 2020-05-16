<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MaterialSingleLineTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialSingleLineTextField2
        '
        Me.MaterialSingleLineTextField2.Depth = 0
        Me.MaterialSingleLineTextField2.Hint = ""
        Me.MaterialSingleLineTextField2.Location = New System.Drawing.Point(23, 148)
        Me.MaterialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField2.Name = "MaterialSingleLineTextField2"
        Me.MaterialSingleLineTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.MaterialSingleLineTextField2.SelectedText = ""
        Me.MaterialSingleLineTextField2.SelectionLength = 0
        Me.MaterialSingleLineTextField2.SelectionStart = 0
        Me.MaterialSingleLineTextField2.Size = New System.Drawing.Size(234, 23)
        Me.MaterialSingleLineTextField2.TabIndex = 5
        Me.MaterialSingleLineTextField2.Tag = "paper"
        Me.MaterialSingleLineTextField2.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(23, 177)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(234, 39)
        Me.MaterialRaisedButton1.TabIndex = 6
        Me.MaterialRaisedButton1.Text = "LOGIN"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = Global.PasswordMGT.My.Resources.Resources.d11
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 92)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "PasswordMGT"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 234)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialSingleLineTextField2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "6"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialSingleLineTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
