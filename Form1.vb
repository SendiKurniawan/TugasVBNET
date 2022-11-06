Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "
        TextBox8.Text = " "
        TextBox9.Text = " "
        TextBox10.Text = " "
        TextBox11.Text = " "
        ComboBox1.Text = " "

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Label2 = TextBox1.Text
        Dim Label3 = TextBox2.Text
        Dim Label4 = ComboBox1.Text
        Dim Label5 = TextBox4.Text
        Dim Label6 = TextBox5.Text
        Dim Label7 = TextBox6.Text
        Dim Label8 = TextBox7.Text
        Dim Label9 = TextBox8.Text
        Dim Label10 = TextBox9.Text
        Dim Label11 = TextBox10.Text
        Dim Label12 = TextBox11.Text
        TextBox8.Text = (((TextBox12.Text / 16) * 0.1)) + (TextBox4.Text * 0.2) + (TextBox5.Text * 0.3) + (TextBox6.Text * 0.4)
        TextBox10.Text = (TextBox8.Text / TextBox7.Text)
        TextBox11.Text = ((TextBox8.Text * TextBox9.Text) / (TextBox7.Text * TextBox9.Text))
        TextBox10.Text = TextBox10.Text.Substring(0, 3)
        TextBox11.Text = TextBox11.Text.Substring(0, 3)
    End Sub


End Class
