Public Class COMIDAS1
    Public mesero As String
    Public pedido(0 To 8, 0 To 12) As Boolean

    ' Function to assign a waiter to a table
    Function mesa(ByVal quien As Object, ByVal quien2 As Object, ByVal tabla As Byte)
        ' Check if waiter is selected and if the table is already assigned a waiter
        If cbMesero.Items.Contains(cbMesero.Text) = False Then cbMesero.Text = ""
        If cbMesero.Text = "" And quien2.Text = "Sin Asignar" Then Exit Function

        ' Assign the waiter to the table and display confirmation message
        If cbMesero.Text <> "" Then
            If quien2.Text <> "Sin Asignar" Then
                If MsgBox("Se cambia el mesero " & quien2.Text & " por el mesero " & cbMesero.Text & " a la " & quien.Text & "?", MsgBoxStyle.OkCancel, "Asignacion de mesero") = MsgBoxResult.Ok Then
                    mesero = cbMesero.Text
                    quien2.Text = cbMesero.Text
                    quien.BackColor = Color.Green
                End If
            ElseIf MsgBox("Se asigna el mesero " & cbMesero.Text & " a la " & quien.Text & "?", MsgBoxStyle.OkCancel, "Asignacion de mesero") = MsgBoxResult.Ok Then
                mesero = cbMesero.Text
                quien2.Text = cbMesero.Text
                quien.BackColor = Color.Green
            End If
        End If

        ' Clear waiter selection and switch to the next form
        cbMesero.Text = ""
        COMIDAS2.mesa = tabla
        COMIDAS2.Show()
        Me.Hide()
    End Function

    ' Button click events to assign waiter to respective tables
    Private Sub bMesa1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMesa1.Click
        mesa(bMesa1, lMesa1, 0)
    End Sub

    Private Sub bMesa2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMesa2.Click
        mesa(bMesa2, lMesa2, 1)
    End Sub

    Private Sub bMesa3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMesa3.Click
        mesa(bMesa3, lMesa3, 2)
    End Sub

    Private Sub bMesa4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMesa4.Click
        mesa(bMesa4, lMesa4, 3)
    End Sub

    Private Sub bMesa5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMesa5.Click
        mesa(bMesa5, lMesa5, 4)
    End Sub

    Private Sub bMesa6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMesa6.Click
        mesa(bMesa6, lMesa6, 5)
    End Sub

    Private Sub bMesa7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMesa7.Click
        mesa(bMesa7, lMesa7, 6)
    End Sub

    Private Sub bMesa8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMesa8.Click
        mesa(bMesa8, lMesa8, 7)
    End Sub

    Private Sub bMesa9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMesa9.Click
        mesa(bMesa9, lMesa9, 8)
    End Sub
End Class