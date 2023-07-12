Public Class frmPrincipal4


    Public Sub New()


        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        lblNomeProjeto.Text = "4- Controle de Fluxo"
        btnPrincipal.Text = "Verificar permissão de entrada"
        Me.Text = "4 Controle de Fluxo"

        lblIdade.Text = "Idade"
        lblResultado.Text = "Resultado da análise: "




        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click

        Dim idadeUsuario As Integer
        Dim permitido As String
        Dim bloqueado As String
        Dim resultado As String

        idadeUsuario = txtIdade.Text
        resultado = txtResultado.Text
        permitido = "Você tem permissão para prosseguir"
        bloqueado = "É necessário o acompanhamento dos responsáveis legais!"

        If idadeUsuario <= 11 Then
            resultado = bloqueado
            If resultado = bloqueado Then
                MsgBox("Está acompanhado dos seus responsáveis legais? ", MsgBoxStyle.YesNo, "Validação")
                If MsgBox("Está acompanhado dos seus responsáveis legais? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    resultado = permitido
                ElseIf MsgBox("Está acompanhado dos seus responsáveis legais? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    MsgBox(" Acesso Negado" + vbCrLf + "Retorne novamamente acompanhado de seus responsáveis legais!", MsgBoxStyle.MsgBoxSetForeground, "Validação")
                End If
            End If

        ElseIf idadeUsuario >= 12 Then
            resultado = permitido
        End If

        txtResultado.Text = (resultado)





    End Sub

    Private Sub txtResultado_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged

    End Sub
End Class
