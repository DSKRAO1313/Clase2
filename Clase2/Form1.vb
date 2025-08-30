Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cm.Items.Add("suma")
        Cm.Items.Add("resta")
        Cm.Items.Add("multiplicacion")
        Cm.Items.Add("division")
    End Sub

    Private Sub btcalcular_Click(sender As Object, e As EventArgs) Handles btcalcular.Click
        Try
            Dim numero1 As Double
            Dim numero2 As Double
            Dim resultado As Double

            Select Case Cm.SelectedItem.ToString()
                Case "+"
                    resultado = numero1 + numero2
                Case "-"
                    resultado = numero1 - numero2
                Case "*"
                    resultado = numero1 * numero2
                Case "/"
                    If numero2 <> 0 Then
                        resultado = numero1 / numero2
                    Else
                        MessageBox.Show("No se puede dividir entre 0")
                        Exit Sub
                    End If
                Case Else
                    MessageBox.Show("Seleccione una operación válida")
                    Exit Sub
            End Select


            MessageBox.Show("El resultado es: " & resultado.ToString())

        Catch ex As Exception
            MessageBox.Show("Por favor ingrese números válidos")
        End Try
    End Sub

    Private Sub numero1_TextChanged(sender As Object, e As EventArgs) Handles numero1.TextChanged

    End Sub
End Class
