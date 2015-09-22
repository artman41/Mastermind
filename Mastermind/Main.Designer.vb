<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.TabMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonResults = New System.Windows.Forms.Button()
        Me.ButtonHard = New System.Windows.Forms.Button()
        Me.ButtonMedium = New System.Windows.Forms.Button()
        Me.ButtonEasy = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabMenu.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabMenu
        '
        Me.TabMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.TabMenu.Name = "TabMenu"
        Me.TabMenu.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonResults)
        Me.TabPage1.Controls.Add(Me.ButtonHard)
        Me.TabPage1.Controls.Add(Me.ButtonMedium)
        Me.TabPage1.Controls.Add(Me.ButtonEasy)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(309, 242)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Difficulty"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ButtonResults
        '
        Me.ButtonResults.Location = New System.Drawing.Point(6, 213)
        Me.ButtonResults.Name = "ButtonResults"
        Me.ButtonResults.Size = New System.Drawing.Size(75, 23)
        Me.ButtonResults.TabIndex = 3
        Me.ButtonResults.Text = "Highscores"
        Me.ButtonResults.UseVisualStyleBackColor = True
        '
        'ButtonHard
        '
        Me.ButtonHard.Location = New System.Drawing.Point(6, 129)
        Me.ButtonHard.Name = "ButtonHard"
        Me.ButtonHard.Size = New System.Drawing.Size(297, 23)
        Me.ButtonHard.TabIndex = 2
        Me.ButtonHard.Text = "Hard"
        Me.ButtonHard.UseVisualStyleBackColor = True
        '
        'ButtonMedium
        '
        Me.ButtonMedium.Location = New System.Drawing.Point(6, 65)
        Me.ButtonMedium.Name = "ButtonMedium"
        Me.ButtonMedium.Size = New System.Drawing.Size(297, 23)
        Me.ButtonMedium.TabIndex = 1
        Me.ButtonMedium.Text = "Medium"
        Me.ButtonMedium.UseVisualStyleBackColor = True
        '
        'ButtonEasy
        '
        Me.ButtonEasy.Location = New System.Drawing.Point(6, 6)
        Me.ButtonEasy.Name = "ButtonEasy"
        Me.ButtonEasy.Size = New System.Drawing.Size(297, 23)
        Me.ButtonEasy.TabIndex = 0
        Me.ButtonEasy.Text = "Easy"
        Me.ButtonEasy.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.ContextMenuStrip = Me.TabMenu
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(317, 268)
        Me.TabControl1.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 292)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Main"
        Me.Text = "Mastermind"
        Me.TabMenu.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabMenu As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ButtonHard As Button
    Friend WithEvents ButtonMedium As Button
    Friend WithEvents ButtonEasy As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ButtonResults As Button
End Class
