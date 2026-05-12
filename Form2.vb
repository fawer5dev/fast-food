Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class COMIDAS2
    Public mesa

    ' Load event handler to populate the form with data
    Private Sub COMIDAS2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Display assigned waiter
        lMesero.Text = "Mesero:" & COMIDAS1.mesero

        ' Populate checkboxes based on the order status
        chM1.Checked = COMIDAS1.pedido(mesa, 0)
        chM2.Checked = COMIDAS1.pedido(mesa, 1)
        chM3.Checked = COMIDAS1.pedido(mesa, 2)
        chM4.Checked = COMIDAS1.pedido(mesa, 3)
        chM5.Checked = COMIDAS1.pedido(mesa, 4)
        chM6.Checked = COMIDAS1.pedido(mesa, 5)
        chM7.Checked = COMIDAS1.pedido(mesa, 6)
        chM8.Checked = COMIDAS1.pedido(mesa, 7)
        chM9.Checked = COMIDAS1.pedido(mesa, 8)
        chM10.Checked = COMIDAS1.pedido(mesa, 9)
        rbM1.Checked = COMIDAS1.pedido(mesa, 10)
        rbM2.Checked = COMIDAS1.pedido(mesa, 11)
        rbM3.Checked = COMIDAS1.pedido(mesa, 12)
    End Sub

    ' Form closed event handler to update the order status
    Private Sub COMIDAS2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' Update the order status based on checkbox selections
        COMIDAS1.pedido(mesa, 0) = chM1.Checked
        COMIDAS1.pedido(mesa, 1) = chM2.Checked
        COMIDAS1.pedido(mesa, 2) = chM3.Checked
        COMIDAS1.pedido(mesa, 3) = chM4.Checked
        COMIDAS1.pedido(mesa, 4) = chM5.Checked
        COMIDAS1.pedido(mesa, 5) = chM6.Checked
        COMIDAS1.pedido(mesa, 6) = chM7.Checked
        COMIDAS1.pedido(mesa, 7) = chM8.Checked
        COMIDAS1.pedido(mesa, 8) = chM9.Checked
        COMIDAS1.pedido(mesa, 9) = chM10.Checked
        COMIDAS1.pedido(mesa, 10) = rbM1.Checked
        COMIDAS1.pedido(mesa, 11) = rbM2.Checked
        COMIDAS1.pedido(mesa, 12) = rbM3.Checked
        COMIDAS1.Show()
    End Sub

    ' Function to manage the items in the checklist
    Function listacheq(ByVal quien As Object)
        If quien.Checked = True Then
            If lbMenu.Items.Contains(quien.text) <> True Then
                lbMenu.Items.Add(quien.text)
            End If
        Else
            If lbMenu.Items.Contains(quien.text) = True Then
                lbMenu.Items.Remove(quien.text)
            End If
        End If
    End Function

    ' CheckChanged event handlers to update the checklist based on checkbox selections
    Private Sub chM1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chM1.CheckedChanged
        If chM1.Checked = True Then
            listacheq(chM1)
            chM2.Checked = False
            listacheq(chM2)
            chM3.Checked = False
            listacheq(chM3)
            chM4.Checked = False
            listacheq(chM4)
        End If
    End Sub

    Private Sub chM2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chM2.CheckedChanged
        If chM2.Checked = True Then
            listacheq(chM2)
            chM1.Checked = False
            listacheq(chM1)
            chM3.Checked = False
            listacheq(chM3)
            chM4.Checked = False
            listacheq(chM4)
        End If
    End Sub

    Private Sub chM3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chM3.CheckedChanged
        If chM3.Checked = True Then
            listacheq(chM3)
            chM2.Checked = False
            listacheq(chM2)
            chM1.Checked = False
            listacheq(chM1)
            chM4.Checked = False
            listacheq(chM4)
        End If
    End Sub

    Private Sub chM4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chM4.CheckedChanged
        If chM4.Checked = True Then
            listacheq(chM4)
            chM2.Checked = False
            listacheq(chM2)
            chM3.Checked = False
            listacheq(chM3)
            chM1.Checked = False
            listacheq(chM1)
        End If
    End Sub

    Private Sub chM5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chM5.CheckedChanged
        listacheq(chM5)
    End Sub

    Private Sub chM6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chM6.CheckedChanged
        listacheq(chM6)
    End Sub

    Private Sub chM7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chM7.CheckedChanged
        listacheq(chM7)
    End Sub

    Private Sub chM8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chM8.CheckedChanged
        listacheq(chM8)
    End Sub

    Private Sub chM9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chM9.CheckedChanged
        listacheq(chM9)
    End Sub

    Private Sub chM10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chM10.CheckedChanged
        listacheq(chM10)
    End Sub

    Private Sub rbM1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbM1.CheckedChanged
        listacheq(rbM1)
        listacheq(rbM2)
        listacheq(rbM3)
    End Sub

    Private Sub rbM2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbM2.CheckedChanged
        listacheq(rbM1)
        listacheq(rbM2)
        listacheq(rbM3)
    End Sub

    Private Sub rbM3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbM3.CheckedChanged
        listacheq(rbM1)
        listacheq(rbM2)
        listacheq(rbM3)
    End Sub

    ' Button click event to navigate to the next form
    Private Sub bFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFactura.Click
        COMIDAS3.Show()
        Me.Hide()
    End Sub
End Class
