<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicTacToe
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
        Me.TLButton = New System.Windows.Forms.Button()
        Me.TMButton = New System.Windows.Forms.Button()
        Me.TRButton = New System.Windows.Forms.Button()
        Me.MRButton = New System.Windows.Forms.Button()
        Me.MMButton = New System.Windows.Forms.Button()
        Me.MLButton = New System.Windows.Forms.Button()
        Me.BLButton = New System.Windows.Forms.Button()
        Me.BMButton = New System.Windows.Forms.Button()
        Me.BRButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GameModeDiscritionLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GameModeComboBox = New System.Windows.Forms.ComboBox()
        Me.TiesLabel = New System.Windows.Forms.Label()
        Me.PlayerTwoLabel = New System.Windows.Forms.Label()
        Me.PlayerOneLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLButton
        '
        Me.TLButton.Font = New System.Drawing.Font("Algerian", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLButton.Location = New System.Drawing.Point(27, 29)
        Me.TLButton.Name = "TLButton"
        Me.TLButton.Size = New System.Drawing.Size(159, 147)
        Me.TLButton.TabIndex = 0
        Me.TLButton.UseVisualStyleBackColor = True
        '
        'TMButton
        '
        Me.TMButton.Font = New System.Drawing.Font("Algerian", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TMButton.Location = New System.Drawing.Point(211, 29)
        Me.TMButton.Name = "TMButton"
        Me.TMButton.Size = New System.Drawing.Size(159, 147)
        Me.TMButton.TabIndex = 0
        Me.TMButton.UseVisualStyleBackColor = True
        '
        'TRButton
        '
        Me.TRButton.Font = New System.Drawing.Font("Algerian", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRButton.Location = New System.Drawing.Point(397, 29)
        Me.TRButton.Name = "TRButton"
        Me.TRButton.Size = New System.Drawing.Size(159, 147)
        Me.TRButton.TabIndex = 0
        Me.TRButton.UseVisualStyleBackColor = True
        '
        'MRButton
        '
        Me.MRButton.Font = New System.Drawing.Font("Algerian", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRButton.Location = New System.Drawing.Point(397, 205)
        Me.MRButton.Name = "MRButton"
        Me.MRButton.Size = New System.Drawing.Size(159, 147)
        Me.MRButton.TabIndex = 0
        Me.MRButton.UseVisualStyleBackColor = True
        '
        'MMButton
        '
        Me.MMButton.Font = New System.Drawing.Font("Algerian", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MMButton.Location = New System.Drawing.Point(211, 205)
        Me.MMButton.Name = "MMButton"
        Me.MMButton.Size = New System.Drawing.Size(159, 147)
        Me.MMButton.TabIndex = 0
        Me.MMButton.UseVisualStyleBackColor = True
        '
        'MLButton
        '
        Me.MLButton.Font = New System.Drawing.Font("Algerian", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLButton.Location = New System.Drawing.Point(27, 205)
        Me.MLButton.Name = "MLButton"
        Me.MLButton.Size = New System.Drawing.Size(159, 147)
        Me.MLButton.TabIndex = 0
        Me.MLButton.UseVisualStyleBackColor = True
        '
        'BLButton
        '
        Me.BLButton.Font = New System.Drawing.Font("Algerian", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLButton.Location = New System.Drawing.Point(27, 381)
        Me.BLButton.Name = "BLButton"
        Me.BLButton.Size = New System.Drawing.Size(159, 147)
        Me.BLButton.TabIndex = 0
        Me.BLButton.UseVisualStyleBackColor = True
        '
        'BMButton
        '
        Me.BMButton.Font = New System.Drawing.Font("Algerian", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMButton.Location = New System.Drawing.Point(211, 381)
        Me.BMButton.Name = "BMButton"
        Me.BMButton.Size = New System.Drawing.Size(159, 147)
        Me.BMButton.TabIndex = 0
        Me.BMButton.UseVisualStyleBackColor = True
        '
        'BRButton
        '
        Me.BRButton.Font = New System.Drawing.Font("Algerian", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRButton.Location = New System.Drawing.Point(397, 381)
        Me.BRButton.Name = "BRButton"
        Me.BRButton.Size = New System.Drawing.Size(159, 147)
        Me.BRButton.TabIndex = 0
        Me.BRButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GameModeDiscritionLabel)
        Me.Panel1.Controls.Add(Me.ClearButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GameModeComboBox)
        Me.Panel1.Controls.Add(Me.TiesLabel)
        Me.Panel1.Controls.Add(Me.PlayerTwoLabel)
        Me.Panel1.Controls.Add(Me.PlayerOneLabel)
        Me.Panel1.Location = New System.Drawing.Point(596, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 498)
        Me.Panel1.TabIndex = 1
        '
        'GameModeDiscritionLabel
        '
        Me.GameModeDiscritionLabel.AutoSize = True
        Me.GameModeDiscritionLabel.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameModeDiscritionLabel.Location = New System.Drawing.Point(21, 387)
        Me.GameModeDiscritionLabel.Name = "GameModeDiscritionLabel"
        Me.GameModeDiscritionLabel.Size = New System.Drawing.Size(276, 81)
        Me.GameModeDiscritionLabel.TabIndex = 6
        Me.GameModeDiscritionLabel.Text = "In Player vs Player each move" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "switches between Xs and Os" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "allways starting with " &
    "Xs."
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(26, 203)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(290, 56)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear Score"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Game Mode"
        '
        'GameModeComboBox
        '
        Me.GameModeComboBox.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameModeComboBox.FormattingEnabled = True
        Me.GameModeComboBox.Items.AddRange(New Object() {"Player Vs Player", "Player Vs Computer (Random)", "Player Vs Computer (Little Timmy)"})
        Me.GameModeComboBox.Location = New System.Drawing.Point(13, 335)
        Me.GameModeComboBox.Name = "GameModeComboBox"
        Me.GameModeComboBox.Size = New System.Drawing.Size(313, 29)
        Me.GameModeComboBox.TabIndex = 3
        '
        'TiesLabel
        '
        Me.TiesLabel.AutoSize = True
        Me.TiesLabel.Font = New System.Drawing.Font("Modern No. 20", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TiesLabel.Location = New System.Drawing.Point(18, 135)
        Me.TiesLabel.Name = "TiesLabel"
        Me.TiesLabel.Size = New System.Drawing.Size(142, 45)
        Me.TiesLabel.TabIndex = 2
        Me.TiesLabel.Text = "Ties: 0"
        '
        'PlayerTwoLabel
        '
        Me.PlayerTwoLabel.AutoSize = True
        Me.PlayerTwoLabel.Font = New System.Drawing.Font("Modern No. 20", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerTwoLabel.Location = New System.Drawing.Point(18, 77)
        Me.PlayerTwoLabel.Name = "PlayerTwoLabel"
        Me.PlayerTwoLabel.Size = New System.Drawing.Size(220, 45)
        Me.PlayerTwoLabel.TabIndex = 2
        Me.PlayerTwoLabel.Text = "Player 2: 0"
        '
        'PlayerOneLabel
        '
        Me.PlayerOneLabel.AutoSize = True
        Me.PlayerOneLabel.Font = New System.Drawing.Font("Modern No. 20", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerOneLabel.Location = New System.Drawing.Point(18, 20)
        Me.PlayerOneLabel.Name = "PlayerOneLabel"
        Me.PlayerOneLabel.Size = New System.Drawing.Size(220, 45)
        Me.PlayerOneLabel.TabIndex = 2
        Me.PlayerOneLabel.Text = "Player 1: 0"
        '
        'TicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 560)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BRButton)
        Me.Controls.Add(Me.BMButton)
        Me.Controls.Add(Me.BLButton)
        Me.Controls.Add(Me.MLButton)
        Me.Controls.Add(Me.MMButton)
        Me.Controls.Add(Me.MRButton)
        Me.Controls.Add(Me.TRButton)
        Me.Controls.Add(Me.TMButton)
        Me.Controls.Add(Me.TLButton)
        Me.Name = "TicTacToe"
        Me.Text = "Tic Tac Toe"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLButton As Button
    Friend WithEvents TMButton As Button
    Friend WithEvents TRButton As Button
    Friend WithEvents MRButton As Button
    Friend WithEvents MMButton As Button
    Friend WithEvents MLButton As Button
    Friend WithEvents BLButton As Button
    Friend WithEvents BMButton As Button
    Friend WithEvents BRButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TiesLabel As Label
    Friend WithEvents PlayerTwoLabel As Label
    Friend WithEvents PlayerOneLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GameModeComboBox As ComboBox
    Friend WithEvents GameModeDiscritionLabel As Label
End Class
