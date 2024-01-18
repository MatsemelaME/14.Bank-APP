Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Retrieve values from textboxes
        Dim name As String = TextBox1.Text
        Dim surname As String = TextBox2.Text
        Dim accNumber As String = TextBox3.Text
        Dim contactNumber As String = TextBox4.Text
        Dim pin As String = TextBox5.Text

        ' You can perform any further processing or validation here
        ' For example, you may want to check if the entered values are not empty

        ' Display confirmation message
        Dim result As DialogResult = MessageBox.Show("Do you want to update your details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' User confirmed, perform update or save operation
            ' For now, let's just display a message
            MessageBox.Show("Click ok to proceed with the updates!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear the textboxes after updating
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()

        Else
            ' User chose not to update, ask if they want to close the application
            Dim closeResult As DialogResult = MessageBox.Show("Do you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If closeResult = DialogResult.Yes Then
                ' User confirmed, close the application
                Me.Close()
            Else
                ' User chose not to close, you can handle it accordingly or do nothing
            End If
        End If

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Display a login success message
        MessageBox.Show("You've successfully logged in!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
