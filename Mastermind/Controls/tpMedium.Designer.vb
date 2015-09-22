<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tpMedium
    Inherits System.Windows.Forms.TabPage

    'UserControl overrides dispose to clean up the component list.
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
        Me.SuspendLayout()
        Me.ResumeLayout(False)

        Me.Cracker1 = New System.Windows.Forms.NumericUpDown()
        Me.Cracker2 = New System.Windows.Forms.NumericUpDown()
        Me.Cracker3 = New System.Windows.Forms.NumericUpDown()
        Me.Cracker4 = New System.Windows.Forms.NumericUpDown()
        Me.Cracker5 = New System.Windows.Forms.NumericUpDown()
        Me.ButtonCrack = New System.Windows.Forms.Button()
        Me.ButtonCheck = New System.Windows.Forms.Button()
        Me.CrackerProgress = New System.Windows.Forms.ProgressBar()
        Me.TimesChecked = New System.Windows.Forms.Label()

        CType(Me.Cracker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cracker2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cracker3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cracker4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cracker5, System.ComponentModel.ISupportInitialize).BeginInit()

        '
        'Tab
        '
        Me.Controls.Add(Me.TimesChecked)
        Me.Controls.Add(Me.CrackerProgress)
        Me.Controls.Add(Me.ButtonCheck)
        Me.Controls.Add(Me.ButtonCrack)
        Me.Controls.Add(Me.Cracker5)
        Me.Controls.Add(Me.Cracker4)
        Me.Controls.Add(Me.Cracker3)
        Me.Controls.Add(Me.Cracker2)
        Me.Controls.Add(Me.Cracker1)
        Me.Location = New System.Drawing.Point(4, 22)
        Me.Name = "TabMedium"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(309, 242)
        Me.TabIndex = 0
        Me.Text = "Medium"
        Me.UseVisualStyleBackColor = True
        '
        'Cracker5
        '
        Me.Cracker5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cracker5.Location = New System.Drawing.Point(258, 60)
        Me.Cracker5.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.Cracker5.Name = "Cracker5"
        Me.Cracker5.Size = New System.Drawing.Size(44, 38)
        Me.Cracker5.TabIndex = 8
        '
        'TimesChecked
        '
        Me.TimesChecked.AutoSize = True
        Me.TimesChecked.Location = New System.Drawing.Point(112, 115)
        Me.TimesChecked.Name = "TimesChecked"
        Me.TimesChecked.Size = New System.Drawing.Size(81, 13)
        Me.TimesChecked.TabIndex = 7
        Me.TimesChecked.Text = "Times Checked"
        '
        'CrackerProgress
        '
        Me.CrackerProgress.Location = New System.Drawing.Point(6, 6)
        Me.CrackerProgress.Name = "CrackerProgress"
        Me.CrackerProgress.Size = New System.Drawing.Size(296, 23)
        Me.CrackerProgress.TabIndex = 6
        '
        'ButtonCheck
        '
        Me.ButtonCheck.Location = New System.Drawing.Point(7, 155)
        Me.ButtonCheck.Name = "ButtonCheck"
        Me.ButtonCheck.Size = New System.Drawing.Size(296, 23)
        Me.ButtonCheck.TabIndex = 5
        Me.ButtonCheck.Text = "Check"
        Me.ButtonCheck.UseVisualStyleBackColor = True
        '
        'ButtonCrack
        '
        Me.ButtonCrack.Location = New System.Drawing.Point(6, 213)
        Me.ButtonCrack.Name = "ButtonCrack"
        Me.ButtonCrack.Size = New System.Drawing.Size(297, 23)
        Me.ButtonCrack.TabIndex = 4
        Me.ButtonCrack.Text = "Crack"
        Me.ButtonCrack.UseVisualStyleBackColor = True
        '
        'Cracker4
        '
        Me.Cracker4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cracker4.Location = New System.Drawing.Point(197, 60)
        Me.Cracker4.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.Cracker4.Name = "Cracker4"
        Me.Cracker4.Size = New System.Drawing.Size(44, 38)
        Me.Cracker4.TabIndex = 3
        '
        'Cracker3
        '
        Me.Cracker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cracker3.Location = New System.Drawing.Point(133, 60)
        Me.Cracker3.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.Cracker3.Name = "Cracker3"
        Me.Cracker3.Size = New System.Drawing.Size(44, 38)
        Me.Cracker3.TabIndex = 2
        '
        'Cracker2
        '
        Me.Cracker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cracker2.Location = New System.Drawing.Point(69, 60)
        Me.Cracker2.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.Cracker2.Name = "Cracker2"
        Me.Cracker2.Size = New System.Drawing.Size(44, 38)
        Me.Cracker2.TabIndex = 1
        '
        'Cracker1
        '
        Me.Cracker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cracker1.Location = New System.Drawing.Point(6, 60)
        Me.Cracker1.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.Cracker1.Name = "Cracker1"
        Me.Cracker1.Size = New System.Drawing.Size(44, 38)
        Me.Cracker1.TabIndex = 0
        '
        'Temp
        '
        CType(Me.Cracker5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cracker4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cracker3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cracker2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cracker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TimesChecked As Label
    Friend WithEvents CrackerProgress As ProgressBar
    Friend WithEvents ButtonCheck As Button
    Friend WithEvents ButtonCrack As Button
    Friend WithEvents Cracker4 As NumericUpDown
    Friend WithEvents Cracker3 As NumericUpDown
    Friend WithEvents Cracker2 As NumericUpDown
    Friend WithEvents Cracker1 As NumericUpDown
    Friend WithEvents Cracker5 As NumericUpDown

End Class
