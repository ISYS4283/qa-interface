<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Questions
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
        Me.dgvQuestions = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoadQuestionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvQuestions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvQuestions
        '
        Me.dgvQuestions.AllowUserToAddRows = False
        Me.dgvQuestions.AllowUserToDeleteRows = False
        Me.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvQuestions.Location = New System.Drawing.Point(0, 24)
        Me.dgvQuestions.Name = "dgvQuestions"
        Me.dgvQuestions.ReadOnly = True
        Me.dgvQuestions.Size = New System.Drawing.Size(992, 723)
        Me.dgvQuestions.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadQuestionsToolStripMenuItem, Me.CreateQuestionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(992, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoadQuestionsToolStripMenuItem
        '
        Me.LoadQuestionsToolStripMenuItem.Name = "LoadQuestionsToolStripMenuItem"
        Me.LoadQuestionsToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.LoadQuestionsToolStripMenuItem.Text = "Load Questions"
        '
        'CreateQuestionToolStripMenuItem
        '
        Me.CreateQuestionToolStripMenuItem.Name = "CreateQuestionToolStripMenuItem"
        Me.CreateQuestionToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.CreateQuestionToolStripMenuItem.Text = "Create Question"
        '
        'Questions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 747)
        Me.Controls.Add(Me.dgvQuestions)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Questions"
        Me.Text = "Questions"
        CType(Me.dgvQuestions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvQuestions As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoadQuestionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateQuestionToolStripMenuItem As ToolStripMenuItem
End Class
