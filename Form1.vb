Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ' Change the color of the selected word in the ListBox
        If ListBox1.SelectedIndex <> -1 Then
            Dim selectedColor As Color = GetSelectedColor()
            ListBox1.ForeColor = selectedColor
            Label1.ForeColor = selectedColor
            Label1.Text = "Selected Word: " & ListBox1.SelectedItem.ToString()
        End If


    End Sub
    Private Function GetSelectedColor() As Color
        ' Get the selected color from the ComboBox
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Red"
                Return Color.Red
            Case "Green"
                Return Color.Green
            Case "Blue"
                Return Color.Blue
            Case "Yellow"
                Return Color.Yellow
            Case Else
                Return Color.Black ' Default to Black if no color is selected
        End Select
    End Function






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate color options in ComboBox
        ComboBox1.Items.Add("Red")
        ComboBox1.Items.Add("Green")
        ComboBox1.Items.Add("Blue")
        ComboBox1.Items.Add("Yellow")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Add the entered word to the ListBox
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) Then
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Clear()
        Else
            MessageBox.Show("Please enter a word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex <> -1 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            ListBox1.Text = "Selected Word: "
        Else
            MessageBox.Show("Please select a word to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        Label1.Text = "Selected Word: "
    End Sub
End Class
