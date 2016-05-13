Public Class Form1
    Public Structure operador

        Dim nombre As String
        Dim apellido As String
        Dim nivel As Integer
        Dim id As Integer

    End Structure

    Public final_user As operador

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String
        Dim pas As String
        Dim ban_login As Integer
        Dim cantidad_usuarios As Integer

        cantidad_usuarios = DataSet1.Tables("usuario").Rows.Count


        ban_login = 0
        For i As Integer = 0 To (cantidad_usuarios - 1)
            user = DataSet1.Tables("usuario").Rows(i).Item("cuenta")
            pas = DataSet1.Tables("usuario").Rows(i).Item("pass")



            If TextBox1.Text = user And TextBox2.Text = pas Then
                ban_login = 1
                final_user.id = DataSet1.Tables("usuario").Rows(i).Item("id_usuario")
                final_user.nombre = DataSet1.Tables("usuario").Rows(i).Item("nombre_usuario")
                final_user.apellido = DataSet1.Tables("usuario").Rows(i).Item("apellido_usuario")
                final_user.nivel = DataSet1.Tables("usuario").Rows(i).Item("nivel")
            End If

        Next



        If ban_login = 1 Then
            Label3.Text = "Ingreso"
            Label3.ForeColor = Color.Green
            If final_user.nivel = 1 Then
                Dim f2 As New Form2
                Me.Hide()
                f2.Show()
            ElseIf final_user.nivel = 2 Then

            End If

        Else
            Label3.Text = "Usuario o Contraseña incorrecto"
            Label3.ForeColor = Color.Red
        End If



    End Sub

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.DataSet1.usuario)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim user As String
        Dim pas As String
        Dim ban_login As Integer
        Dim cantidad_usuarios As Integer

        cantidad_usuarios = DataSet1.Tables("usuario").Rows.Count


        ban_login = 0
        For i As Integer = 0 To (cantidad_usuarios - 1)
            user = DataSet1.Tables("usuario").Rows(i).Item("cuenta")
            pas = DataSet1.Tables("usuario").Rows(i).Item("pass")



            If TextBox1.Text = user And TextBox2.Text = pas Then
                ban_login = 1
                final_user.id = DataSet1.Tables("usuario").Rows(i).Item("id_usuario")
                final_user.nombre = DataSet1.Tables("usuario").Rows(i).Item("nombre_usuario")
                final_user.apellido = DataSet1.Tables("usuario").Rows(i).Item("apellido_usuario")
                final_user.nivel = DataSet1.Tables("usuario").Rows(i).Item("nivel")
            End If

        Next



        If ban_login = 1 Then
            Label3.Text = "Ingreso"
            Label3.ForeColor = Color.Green
            If final_user.nivel = 1 Then
                Dim f2 As New Form2
                Me.Hide()
                f2.Show()
            ElseIf final_user.nivel = 2 Then

            End If

        Else

        End If

    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter

    End Sub

    Private Sub TextBox2_AcceptsTabChanged(sender As Object, e As EventArgs) Handles TextBox2.AcceptsTabChanged

    End Sub
End Class
