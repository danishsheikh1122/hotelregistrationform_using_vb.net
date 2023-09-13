<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clientt1 = New System.Windows.Forms.TextBox()
        Me.clientt2 = New System.Windows.Forms.TextBox()
        Me.clientg1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clientt4 = New System.Windows.Forms.TextBox()
        Me.clientg2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(730, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(23, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Client Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(23, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter Your Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(23, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter Your Age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(23, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Enter Your Gender"
        '
        'clientt1
        '
        Me.clientt1.Location = New System.Drawing.Point(27, 129)
        Me.clientt1.Name = "clientt1"
        Me.clientt1.Size = New System.Drawing.Size(227, 27)
        Me.clientt1.TabIndex = 5
        '
        'clientt2
        '
        Me.clientt2.Location = New System.Drawing.Point(27, 222)
        Me.clientt2.Name = "clientt2"
        Me.clientt2.Size = New System.Drawing.Size(227, 27)
        Me.clientt2.TabIndex = 6
        '
        'clientg1
        '
        Me.clientg1.FormattingEnabled = True
        Me.clientg1.Items.AddRange(New Object() {"Male ", "Female", "Other"})
        Me.clientg1.Location = New System.Drawing.Point(27, 309)
        Me.clientg1.Name = "clientg1"
        Me.clientg1.Size = New System.Drawing.Size(159, 28)
        Me.clientg1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(410, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(414, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(254, 28)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Enter Your Phone number"
        '
        'clientt4
        '
        Me.clientt4.Location = New System.Drawing.Point(410, 222)
        Me.clientt4.Name = "clientt4"
        Me.clientt4.Size = New System.Drawing.Size(227, 27)
        Me.clientt4.TabIndex = 11
        '
        'clientg2
        '
        Me.clientg2.FormattingEnabled = True
        Me.clientg2.Items.AddRange(New Object() {"07-05-2022"})
        Me.clientg2.Location = New System.Drawing.Point(410, 129)
        Me.clientg2.Name = "clientg2"
        Me.clientg2.Size = New System.Drawing.Size(163, 28)
        Me.clientg2.TabIndex = 12
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.clientg2)
        Me.Controls.Add(Me.clientt4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.clientg1)
        Me.Controls.Add(Me.clientt2)
        Me.Controls.Add(Me.clientt1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "client"
        Me.Text = "client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents clientt1 As TextBox
    Friend WithEvents clientt2 As TextBox
    Friend WithEvents clientg1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents clientt4 As TextBox
    Friend WithEvents clientg2 As ComboBox
End Class
