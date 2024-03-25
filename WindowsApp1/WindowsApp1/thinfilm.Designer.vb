<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class thinfilm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.thinPB = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.thinPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(648, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 39)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "$279.99"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(343, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 48)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Thin-Film Solar Panels"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(499, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(277, 43)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Add to Cart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'thinPB
        '
        Me.thinPB.Image = Global.WindowsApp1.My.Resources.Resources.thin_film
        Me.thinPB.Location = New System.Drawing.Point(12, 73)
        Me.thinPB.Name = "thinPB"
        Me.thinPB.Size = New System.Drawing.Size(320, 351)
        Me.thinPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.thinPB.TabIndex = 1
        Me.thinPB.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(483, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Extremely flexible and durable solar cell"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(455, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(333, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Gathers more energy in low-light conditions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(372, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(416, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Achieves wider application with the 360-degree flexible"
        '
        'thinfilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.thinPB)
        Me.Name = "thinfilm"
        Me.Text = "thinfilm"
        CType(Me.thinPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents thinPB As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
