<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal4
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
        btnPrincipal = New Button()
        lblNomeProjeto = New Label()
        txtIdade = New TextBox()
        lblIdade = New Label()
        txtResultado = New TextBox()
        lblResultado = New Label()
        SuspendLayout()
        ' 
        ' btnPrincipal
        ' 
        btnPrincipal.Location = New Point(12, 147)
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.Size = New Size(125, 66)
        btnPrincipal.TabIndex = 0
        btnPrincipal.Text = "&Clique Aqui"
        btnPrincipal.UseVisualStyleBackColor = True
        ' 
        ' lblNomeProjeto
        ' 
        lblNomeProjeto.AutoSize = True
        lblNomeProjeto.Location = New Point(12, 15)
        lblNomeProjeto.Name = "lblNomeProjeto"
        lblNomeProjeto.Size = New Size(41, 15)
        lblNomeProjeto.TabIndex = 1
        lblNomeProjeto.Text = "Label1"
        ' 
        ' txtIdade
        ' 
        txtIdade.Location = New Point(12, 92)
        txtIdade.Name = "txtIdade"
        txtIdade.Size = New Size(100, 23)
        txtIdade.TabIndex = 2
        ' 
        ' lblIdade
        ' 
        lblIdade.AutoSize = True
        lblIdade.Location = New Point(10, 53)
        lblIdade.Name = "lblIdade"
        lblIdade.Size = New Size(41, 15)
        lblIdade.TabIndex = 3
        lblIdade.Text = "Label1"
        ' 
        ' txtResultado
        ' 
        txtResultado.BorderStyle = BorderStyle.FixedSingle
        txtResultado.Location = New Point(10, 268)
        txtResultado.Name = "txtResultado"
        txtResultado.ReadOnly = True
        txtResultado.Size = New Size(423, 23)
        txtResultado.TabIndex = 4
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(12, 235)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(41, 15)
        lblResultado.TabIndex = 5
        lblResultado.Text = "Label1"
        ' 
        ' frmPrincipal4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(857, 450)
        Controls.Add(lblResultado)
        Controls.Add(txtResultado)
        Controls.Add(lblIdade)
        Controls.Add(txtIdade)
        Controls.Add(lblNomeProjeto)
        Controls.Add(btnPrincipal)
        Name = "frmPrincipal4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aplicação Hello World"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrincipal As Button
    Friend WithEvents lblNomeProjeto As Label
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents lblIdade As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents lblResultado As Label
End Class
