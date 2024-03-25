<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class poly
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.polyPB = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.polyPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label6.Location = New System.Drawing.Point(633, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 39)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "$189.19"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label3.Location = New System.Drawing.Point(250, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(538, 48)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Polycrystalline Solar Panels"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(481, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Industry leading 5 year product warranty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(330, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(458, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Produces on average 25 Amp-hours/300-Watt-hours per day"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(306, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(482, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Affordable, convenient, and clean power for off-grid applications"
        '
        'polyPB
        '
        Me.polyPB.Image = Global.WindowsApp1.My.Resources.Resources.The_Solar_Panel_Polycrystalline_Type
        Me.polyPB.Location = New System.Drawing.Point(12, 60)
        Me.polyPB.Name = "polyPB"
        Me.polyPB.Size = New System.Drawing.Size(288, 270)
        Me.polyPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.polyPB.TabIndex = 9
        Me.polyPB.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(485, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(277, 43)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Add to Cart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'poly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.polyPB)
        Me.Name = "poly"
        Me.Text = "poly"
        CType(Me.polyPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents polyPB As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
