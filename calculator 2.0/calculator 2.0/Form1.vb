Public Class tltippi

    Private Sub txtanswer_TextChanged(sender As Object, e As EventArgs) Handles txtanswer.TextChanged

    End Sub


    Private isadding As Boolean = False
    Private issubtracting As Boolean = False
    Private ismultiplying As Boolean = False
    Private isdividing As Boolean = False
    Private ismodulus As Boolean = False


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isadding = False Then
            Dim Answer As Double = add(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtanswer.Text = Answer.ToString(0)
            txtNum2.ReadOnly = True
            isadding = True
        ElseIf isadding Then
            Dim ans As Double = add(CType(txtNum1.Text, Double), CType(txtanswer.Text, Double))
            txtanswer.Text = ans.tostring()
        Else
            MessageBox.Show("please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function add(num1 As Double, ByVal num2 As Double) As Double
        Return num1 + num2
    End Function

    Private Function subtract(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function

    Private Function divide(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 / num2
    End Function

    Private Function multiply(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 * num2
    End Function

    Private Function modulus(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 Mod num2
    End Function

    Private Function PI(ByVal num1 As Double) As Double
        Return num1 * Math.PI
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNum2.ReadOnly = False
        revertbool()
        txtNum1.Clear()
        txtanswer.Clear()
        txtNum2.Clear()
    End Sub
    Private Sub revertbool()
        isadding = False
        issubtracting = False
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And issubtracting = False Then
            Dim Answer As Double = subtract(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtanswer.Text = Answer.ToString(0)
            txtNum2.ReadOnly = True
            issubtracting = True
        ElseIf issubtracting Then
            Dim ans As Double = subtract(CType(txtNum1.Text, Double), CType(txtanswer.Text, Double))
            txtanswer.Text = ans.ToString()
        Else
            MessageBox.Show("please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isdividing = False Then
            Dim Answer As Double = divide(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtanswer.Text = Answer.ToString(0)
            txtNum2.ReadOnly = True
            isdividing = True
        ElseIf isdividing Then
            Dim ans As Double = divide(CType(txtNum1.Text, Double), CType(txtanswer.Text, Double))
            txtanswer.Text = ans.ToString()
        Else
            MessageBox.Show("please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And ismultiplying = False Then
            Dim Answer As Double = multiply(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtanswer.Text = Answer.ToString(0)
            txtNum2.ReadOnly = True
            ismultiplying = True
        ElseIf ismultiplying Then
            Dim ans As Double = multiply(CType(txtNum1.Text, Double), CType(txtanswer.Text, Double))
            txtanswer.Text = ans.ToString()
        Else
            MessageBox.Show("please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnModulus_Click(sender As Object, e As EventArgs) Handles btnModulus.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And ismodulus = False Then
            Dim Answer As Double = modulus(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtanswer.Text = Answer.ToString(0)
            txtNum2.ReadOnly = True
            ismodulus = True
        ElseIf ismodulus Then
            Dim ans As Double = modulus(CType(txtNum1.Text, Double), CType(txtanswer.Text, Double))
            txtanswer.Text = ans.ToString()
        Else
            MessageBox.Show("please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnpi_Click(sender As Object, e As EventArgs) Handles btnpi.Click
        If txtNum1.Text.Length <> 0 Then
            Dim answer As Double = PI(CType(txtNum1.Text, Double))
            txtanswer.Text = String.Format("{0:n3}", answer)
            txtNum2.Text = String.Format("{0:n3}", Math.PI)
            txtNum2.ReadOnly = True
        Else
            MessageBox.Show("please fill all fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnpi_MouseHover(sender As Object, e As EventArgs) Handles btnpi.MouseHover
        pitip.SetToolTip(btnpi, "only one value is needed in the first value field")
    End Sub
End Class
