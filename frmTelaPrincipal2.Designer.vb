<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTelaPrincipal
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmTelaPrincipal))
        PictureBox1 = New PictureBox()
        btnPrincipal = New Button()
        lbl1 = New Label()
        txtIdade = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        ' 
        ' btnPrincipal
        ' 
        resources.ApplyResources(btnPrincipal, "btnPrincipal")
        btnPrincipal.BackColor = SystemColors.ButtonHighlight
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.UseVisualStyleBackColor = False
        ' 
        ' lbl1
        ' 
        resources.ApplyResources(lbl1, "lbl1")
        lbl1.Name = "lbl1"
        ' 
        ' txtIdade
        ' 
        resources.ApplyResources(txtIdade, "txtIdade")
        txtIdade.BackColor = SystemColors.ScrollBar
        txtIdade.Name = "txtIdade"
        ' 
        ' frmTelaPrincipal
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        CausesValidation = False
        Controls.Add(PictureBox1)
        Controls.Add(txtIdade)
        Controls.Add(lbl1)
        Controls.Add(btnPrincipal)
        ForeColor = SystemColors.Highlight
        Name = "frmTelaPrincipal"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrincipal As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
