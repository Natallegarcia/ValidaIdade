Public Class frmTelaPrincipal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().


    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click



        Dim idadeUsuario As Integer
        Dim idadeMinima As Integer
        Dim idadeMaxima As Integer
        idadeUsuario = txtIdade.Text
        idadeMinima = 12
        idadeMaxima = 60

        MsgBox("A idade informada é " + idadeUsuario.ToString)





        If idadeUsuario < 12 Then
            MsgBox("O valor da idade é mínima para esse brinquedo é " + idadeMinima.ToString, MsgBoxStyle.Critical, "IDADE MÍNIMA")
        ElseIf idadeUsuario <= 59 Then
            MsgBox("Sua idade é a ideal para este brinquedo no parque ", MsgBoxStyle.MsgBoxRight, "Passagem Liberada")

        ElseIf idadeUsuario > 59 Then
            MsgBox("O valor máximo da idade para esse brinquedo é  " + idadeMaxima.ToString, MsgBoxStyle.Critical, "IDADE MÁXIMA")

        End If



    End Sub

    Private Sub frmTelaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
