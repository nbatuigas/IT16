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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.enctextbox = New System.Windows.Forms.TextBox()
        Me.orgtextbox = New System.Windows.Forms.TextBox()
        Me.decbutton = New System.Windows.Forms.Button()
        Me.encbutton = New System.Windows.Forms.Button()
        Me.numupdown = New System.Windows.Forms.NumericUpDown()
        CType(Me.numupdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Encrypted Text:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(455, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Original Text:"
        '
        'enctextbox
        '
        Me.enctextbox.Location = New System.Drawing.Point(24, 67)
        Me.enctextbox.Multiline = True
        Me.enctextbox.Name = "enctextbox"
        Me.enctextbox.Size = New System.Drawing.Size(356, 307)
        Me.enctextbox.TabIndex = 2
        '
        'orgtextbox
        '
        Me.orgtextbox.Location = New System.Drawing.Point(458, 67)
        Me.orgtextbox.Multiline = True
        Me.orgtextbox.Name = "orgtextbox"
        Me.orgtextbox.Size = New System.Drawing.Size(356, 307)
        Me.orgtextbox.TabIndex = 3
        '
        'decbutton
        '
        Me.decbutton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.decbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.decbutton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decbutton.Location = New System.Drawing.Point(152, 392)
        Me.decbutton.Name = "decbutton"
        Me.decbutton.Size = New System.Drawing.Size(79, 40)
        Me.decbutton.TabIndex = 4
        Me.decbutton.Text = "Decrypt"
        Me.decbutton.UseVisualStyleBackColor = False
        '
        'encbutton
        '
        Me.encbutton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.encbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.encbutton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.encbutton.Location = New System.Drawing.Point(597, 392)
        Me.encbutton.Name = "encbutton"
        Me.encbutton.Size = New System.Drawing.Size(84, 40)
        Me.encbutton.TabIndex = 5
        Me.encbutton.Text = "Encrypt"
        Me.encbutton.UseVisualStyleBackColor = False
        '
        'numupdown
        '
        Me.numupdown.Location = New System.Drawing.Point(386, 404)
        Me.numupdown.Name = "numupdown"
        Me.numupdown.Size = New System.Drawing.Size(64, 21)
        Me.numupdown.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IT16_Ciphering.My.Resources.Resources.hacker
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(840, 468)
        Me.Controls.Add(Me.numupdown)
        Me.Controls.Add(Me.encbutton)
        Me.Controls.Add(Me.decbutton)
        Me.Controls.Add(Me.orgtextbox)
        Me.Controls.Add(Me.enctextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "Form1"
        Me.Text = "Caesar Cipher Encryption"
        CType(Me.numupdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents enctextbox As TextBox
    Friend WithEvents orgtextbox As TextBox
    Friend WithEvents decbutton As Button
    Friend WithEvents encbutton As Button
    Friend WithEvents numupdown As NumericUpDown

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
