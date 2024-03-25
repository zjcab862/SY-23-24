<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class monovb
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.monoPB = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.monoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(648, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 39)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "$129.99"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.Location = New System.Drawing.Point(239, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(560, 48)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Monocrystalline Solar Panels"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(481, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Industry leading 5 year product warranty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(330, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(458, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Produces on average 25 Amp-hours/300-Watt-hours per day"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(306, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(482, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Affordable, convenient, and clean power for off-grid applications"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(511, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(277, 43)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Add to Cart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'monoPB
        '
        Me.monoPB.Image = Global.WindowsApp1.My.Resources.Resources._61d6ztszN1L__AC_UF894_1000_QL80_
        Me.monoPB.Location = New System.Drawing.Point(12, 60)
        Me.monoPB.Name = "monoPB"
        Me.monoPB.Size = New System.Drawing.Size(288, 367)
        Me.monoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.monoPB.TabIndex = 8
        Me.monoPB.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(604, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Quantity:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(668, 227)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDown1.TabIndex = 17
        '
        'monovb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.monoPB)
        Me.Name = "monovb"
        Me.Text = "monovb"
        CType(Me.monoPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents monoPB As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
