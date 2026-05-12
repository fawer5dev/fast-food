Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class COMIDAS3
    Public mesa As Byte, estado As Boolean

    ' Activated event handler to calculate the total order value and display the details
    Private Sub COMIDAS3_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim conta1 As Byte, conta2 As Byte
        Dim lista(0 To 12) As Double, total As Double
        ' Array to store menu item prices
        Dim lista2 As String() = {"Pollo Sencillo",
                                  "Pollo Doble",
                                  "Carne Sencillo",
                                  "Carne Doble",
                                  "Lechuga",
                                  "Tomate",
                                  "Queso",
                                  "Salsas",
                                  "Tocineta",
                                  "Papas",
                                  "Retornable 350",
                                  "No Retornable 600",
                                  "Vaso de 7 Onzas"}
        ' Assign prices to menu items
        lista(0) = 6000
        lista(1) = 10000
        lista(2) = 5000
        lista(3) = 8000
        lista(4) = 0
        lista(5) = 0
        lista(6) = 500
        lista(7) = 0
        lista(8) = 1000
        lista(9) = 2500
        lista(10) = 2000
        lista(11) = 1000
        lista(12) = 700

        ' Retrieve selected menu items and calculate total price
        mesa = COMIDAS2.mesa
        lMesero.Text = COMIDAS2.lMesero.Text
        lMesa.Text = "Mesa: " & Str(mesa + 1)
        total = 0
        For conta1 = 1 To COMIDAS2.lbMenu.Items.Count
            lbMenu.Items.Add(COMIDAS2.lbMenu.Items(conta1 - 1))
            For conta2 = 0 To 13
                If COMIDAS2.lbMenu.Items(conta1 - 1) = lista2(conta2) Then
                    lbValor.Items.Add(lista(conta2))
                    total = total + lista(conta2)
                    Exit For
                End If
            Next
        Next
        tbValor.Text = total
    End Sub

    ' Form closed event handler to display the previous form when closed
    Private Sub COMIDAS3_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If estado <> True Then COMIDAS2.Show()
    End Sub

    ' Button click event handler to process payment and update order status
    Private Sub bCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCobrar.Click
        Dim conta1 As Byte
        ' Confirm payment amount and update order status if confirmed
        If MsgBox("Se van a cobrar por las Mesa " & Str(mesa + 1) & " un total de " & tbValor.Text & ", Esta de acuerdo?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            For conta1 = 0 To 12
                COMIDAS1.pedido(mesa, conta1) = False
            Next
            ' Update order status and display on previous form
            Select Case mesa
                Case Is = 0
                    COMIDAS1.bMesa1.BackColor = Color.Beige
                    COMIDAS1.lMesa1.Text = "Sin Asignar"
                Case Is = 1
                    COMIDAS1.bMesa2.BackColor = Color.Beige
                    COMIDAS1.lMesa2.Text = "Sin Asignar"
                Case Is = 2
                    COMIDAS1.bMesa3.BackColor = Color.Beige
                    COMIDAS1.lMesa3.Text = "Sin Asignar"
                Case Is = 3
                    COMIDAS1.bMesa4.BackColor = Color.Beige
                    COMIDAS1.lMesa4.Text = "Sin Asignar"
                Case Is = 4
                    COMIDAS1.bMesa5.BackColor = Color.Beige
                    COMIDAS1.lMesa5.Text = "Sin Asignar"
                Case Is = 5
                    COMIDAS1.bMesa6.BackColor = Color.Beige
                    COMIDAS1.lMesa6.Text = "Sin Asignar"
                Case Is = 6
                    COMIDAS1.bMesa7.BackColor = Color.Beige
                    COMIDAS1.lMesa7.Text = "Sin Asignar"
                Case Is = 7
                    COMIDAS1.bMesa8.BackColor = Color.Beige
                    COMIDAS1.lMesa8.Text = "Sin Asignar"
                Case Is = 8
                    COMIDAS1.bMesa9.BackColor = Color.Beige
                    COMIDAS1.lMesa9.Text = "Sin Asignar"
            End Select
            ' Close current form and display previous form
            COMIDAS2.Close()
            COMIDAS1.Show()
            estado = True
            Me.Close()
        End If
    End Sub
End Class