Public Class Form1

    Private Sub hitungbtn_Click(sender As Object, e As EventArgs) Handles hitungbtn.Click
        Dim angka1, angka2, hasil As Integer
        'Dim angka1 As Interger
        'Dim angka2 As Interger
        'Dim hasil As Interger
        angka1 = Convert.ToInt32(TextBox1.Text)
        angka2 = Convert.ToInt32(TextBox2.Text)
        hasil = angka1 + angka2
        HASILLABEL.Text = hasil.ToString()
    End Sub

    Private Sub TextBox1_KeyPress(ByValsender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        inputfilter(e)
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        inputfilter(e)
    End Sub
    Private Sub inputfilter(ByVal e As KeyPressEventArgs)
        MessageBox.Show(Asc(e.KeyChar))
        If (Asc(e.KeyChar) < 48 Or _
            Asc(e.KeyChar) > 57) And_
            Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
End Class
