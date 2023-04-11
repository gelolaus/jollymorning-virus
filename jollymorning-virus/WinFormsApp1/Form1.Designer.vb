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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        lbl_title = New Label()
        btn_close = New Button()
        SuspendLayout()
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(42, 14)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(710, 128)
        lbl_title.TabIndex = 0
        lbl_title.Text = "Jolly Morning!"
        ' 
        ' btn_close
        ' 
        btn_close.Location = New Point(697, 12)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(75, 23)
        btn_close.TabIndex = 1
        btn_close.Text = "Close"
        btn_close.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 161)
        ControlBox = False
        Controls.Add(btn_close)
        Controls.Add(lbl_title)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        ShowInTaskbar = False
        Text = "Jollibee Greeter"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_close As Button
End Class
