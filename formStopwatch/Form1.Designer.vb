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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.minute = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.second = New System.Windows.Forms.Label()
        Me.milisecond = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hour = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'minute
        '
        Me.minute.AutoSize = True
        Me.minute.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minute.Location = New System.Drawing.Point(139, 33)
        Me.minute.Name = "minute"
        Me.minute.Size = New System.Drawing.Size(40, 45)
        Me.minute.TabIndex = 1
        Me.minute.Text = "0"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(58, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 49)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(241, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 49)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(146, 247)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 49)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'second
        '
        Me.second.AutoSize = True
        Me.second.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second.Location = New System.Drawing.Point(234, 33)
        Me.second.Name = "second"
        Me.second.Size = New System.Drawing.Size(40, 45)
        Me.second.TabIndex = 5
        Me.second.Text = "0"
        '
        'milisecond
        '
        Me.milisecond.AutoSize = True
        Me.milisecond.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.milisecond.Location = New System.Drawing.Point(329, 33)
        Me.milisecond.Name = "milisecond"
        Me.milisecond.Size = New System.Drawing.Size(40, 45)
        Me.milisecond.TabIndex = 6
        Me.milisecond.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 45)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(285, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 45)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 45)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = ":"
        '
        'hour
        '
        Me.hour.AutoSize = True
        Me.hour.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hour.Location = New System.Drawing.Point(40, 33)
        Me.hour.Name = "hour"
        Me.hour.Size = New System.Drawing.Size(40, 45)
        Me.hour.TabIndex = 8
        Me.hour.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Hour"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(129, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Minute"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(229, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Second"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(409, 340)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.hour)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.milisecond)
        Me.Controls.Add(Me.second)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.minute)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "StopWatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents minute As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents second As System.Windows.Forms.Label
    Friend WithEvents milisecond As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents hour As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
