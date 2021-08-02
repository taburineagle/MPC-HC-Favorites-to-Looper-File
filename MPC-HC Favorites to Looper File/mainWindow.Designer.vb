<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainWindow
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
        Me.favoritesList = New System.Windows.Forms.ListView()
        Me.favName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.favStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.favRel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.favPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.analyzeTF = New System.Windows.Forms.Label()
        Me.MPC_HC_Radio = New System.Windows.Forms.RadioButton()
        Me.MPC_BE_Radio = New System.Windows.Forms.RadioButton()
        Me.writeButton = New System.Windows.Forms.Button()
        Me.favCountTF = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'favoritesList
        '
        Me.favoritesList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.favoritesList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.favName, Me.favStart, Me.favRel, Me.favPath})
        Me.favoritesList.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.favoritesList.GridLines = True
        Me.favoritesList.HideSelection = False
        Me.favoritesList.Location = New System.Drawing.Point(0, 28)
        Me.favoritesList.Name = "favoritesList"
        Me.favoritesList.Size = New System.Drawing.Size(816, 293)
        Me.favoritesList.TabIndex = 0
        Me.favoritesList.UseCompatibleStateImageBehavior = False
        Me.favoritesList.View = System.Windows.Forms.View.Details
        '
        'favName
        '
        Me.favName.Text = "Favorite Name"
        Me.favName.Width = 200
        '
        'favStart
        '
        Me.favStart.Text = "Start Time"
        Me.favStart.Width = 80
        '
        'favRel
        '
        Me.favRel.Text = "Relative Path"
        Me.favRel.Width = 90
        '
        'favPath
        '
        Me.favPath.Text = "Favorite Path"
        Me.favPath.Width = 442
        '
        'analyzeTF
        '
        Me.analyzeTF.AutoSize = True
        Me.analyzeTF.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.analyzeTF.Location = New System.Drawing.Point(3, 6)
        Me.analyzeTF.Name = "analyzeTF"
        Me.analyzeTF.Size = New System.Drawing.Size(126, 15)
        Me.analyzeTF.TabIndex = 1
        Me.analyzeTF.Text = "Analyze favorites for:"
        '
        'MPC_HC_Radio
        '
        Me.MPC_HC_Radio.AutoSize = True
        Me.MPC_HC_Radio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPC_HC_Radio.Location = New System.Drawing.Point(134, 4)
        Me.MPC_HC_Radio.Name = "MPC_HC_Radio"
        Me.MPC_HC_Radio.Size = New System.Drawing.Size(73, 19)
        Me.MPC_HC_Radio.TabIndex = 2
        Me.MPC_HC_Radio.Text = "MPC-HC"
        Me.MPC_HC_Radio.UseVisualStyleBackColor = True
        '
        'MPC_BE_Radio
        '
        Me.MPC_BE_Radio.AutoSize = True
        Me.MPC_BE_Radio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPC_BE_Radio.Location = New System.Drawing.Point(209, 4)
        Me.MPC_BE_Radio.Name = "MPC_BE_Radio"
        Me.MPC_BE_Radio.Size = New System.Drawing.Size(69, 19)
        Me.MPC_BE_Radio.TabIndex = 3
        Me.MPC_BE_Radio.Text = "MPC-BE"
        Me.MPC_BE_Radio.UseVisualStyleBackColor = True
        '
        'writeButton
        '
        Me.writeButton.Enabled = False
        Me.writeButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.writeButton.Location = New System.Drawing.Point(622, 1)
        Me.writeButton.Name = "writeButton"
        Me.writeButton.Size = New System.Drawing.Size(192, 25)
        Me.writeButton.TabIndex = 4
        Me.writeButton.Text = "Write Favorites to .looper file..."
        Me.writeButton.UseVisualStyleBackColor = True
        '
        'favCountTF
        '
        Me.favCountTF.AutoSize = True
        Me.favCountTF.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.favCountTF.Location = New System.Drawing.Point(286, 6)
        Me.favCountTF.MinimumSize = New System.Drawing.Size(330, 15)
        Me.favCountTF.Name = "favCountTF"
        Me.favCountTF.Size = New System.Drawing.Size(330, 15)
        Me.favCountTF.TabIndex = 5
        Me.favCountTF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 322)
        Me.Controls.Add(Me.favCountTF)
        Me.Controls.Add(Me.writeButton)
        Me.Controls.Add(Me.MPC_BE_Radio)
        Me.Controls.Add(Me.MPC_HC_Radio)
        Me.Controls.Add(Me.analyzeTF)
        Me.Controls.Add(Me.favoritesList)
        Me.MaximumSize = New System.Drawing.Size(833, 900)
        Me.MinimumSize = New System.Drawing.Size(833, 361)
        Me.Name = "mainWindow"
        Me.Text = "MPC-HC/BE Favorite Extractor to Looper file by Zach Glenwright"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents favoritesList As ListView
    Friend WithEvents favName As ColumnHeader
    Friend WithEvents favStart As ColumnHeader
    Friend WithEvents favRel As ColumnHeader
    Friend WithEvents favPath As ColumnHeader
    Friend WithEvents analyzeTF As Label
    Friend WithEvents MPC_HC_Radio As RadioButton
    Friend WithEvents MPC_BE_Radio As RadioButton
    Friend WithEvents writeButton As Button
    Friend WithEvents favCountTF As Label
End Class
