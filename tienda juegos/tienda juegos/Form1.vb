Public Class Form1

    Private Sub AdminBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseC1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseC1DataSet.admin' Puede moverla o quitarla según sea necesario.
        Me.AdminTableAdapter.Fill(Me.BaseC1DataSet.admin)

    End Sub

    Private Sub AlmacenLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.AdminTableAdapter.Insert(ClaveTextBox.Text, AlmacenTextBox.Text, Nombre_juegoTextBox.Text, PrecioTextBox.Text)
        Me.AdminTableAdapter.Fill(Me.BaseC1DataSet.admin)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.AdminTableAdapter.Editar(ClaveTextBox.Text, AlmacenTextBox.Text, Nombre_juegoTextBox.Text, PrecioTextBox.Text, ClaveTextBox.Text)
        Me.AdminTableAdapter.Fill(Me.BaseC1DataSet.admin)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.AdminTableAdapter.Borrar(ClaveTextBox.Text)
        Me.AdminTableAdapter.Fill(Me.BaseC1DataSet.admin)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.AdminTableAdapter.FillBy(Me.BaseC1DataSet.admin, ClaveTextBox.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.AdminTableAdapter.Fill(Me.BaseC1DataSet.admin)
    End Sub
End Class
