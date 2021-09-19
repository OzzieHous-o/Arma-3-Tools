<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statuss = New System.Windows.Forms.ToolStripStatusLabel()
        Me.flashLabel = New System.Windows.Forms.Timer(Me.components)
        Me.contactLabel = New System.Windows.Forms.Timer(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MPMissionCache Folder"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(15, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(414, 25)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 6.9!)
        Me.Label2.Location = New System.Drawing.Point(267, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "(By default the folder is pre-chosen)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(435, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "MPMissions Folder"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(15, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(414, 25)
        Me.TextBox2.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(435, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 25)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Set"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 6.9!)
        Me.Label4.Location = New System.Drawing.Point(137, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(278, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "(This should be in your Arma 3 Directory + must include .pbo)"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(15, 124)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(414, 45)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Move PBO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Location = New System.Drawing.Point(481, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 160)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 86)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(159, 31)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Open Settings File"
        Me.ToolTip1.SetToolTip(Me.Button6, "Open ini file")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 49)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(159, 31)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Remove Saved Settings"
        Me.ToolTip1.SetToolTip(Me.Button5, "Delete ini file")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(159, 31)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Save Settings"
        Me.ToolTip1.SetToolTip(Me.Button4, "Save all settings to ini file")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Arma 3 Tools - Tips"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuss})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 173)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(671, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statuss
        '
        Me.statuss.Name = "statuss"
        Me.statuss.Size = New System.Drawing.Size(656, 17)
        Me.statuss.Spring = True
        '
        'flashLabel
        '
        Me.flashLabel.Interval = 800
        '
        'contactLabel
        '
        Me.contactLabel.Interval = 700
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(6, 122)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(159, 31)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Clear Form"
        Me.ToolTip1.SetToolTip(Me.Button7, "Clear text fields. Note: This won't save settings. Same entries will be loaded ne" &
        "xt restart, unless you save new settings.")
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 195)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arma 3 Tools"
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statuss As ToolStripStatusLabel
    Friend WithEvents flashLabel As Timer
    Friend WithEvents contactLabel As Timer
    Friend WithEvents Button7 As Button
End Class
