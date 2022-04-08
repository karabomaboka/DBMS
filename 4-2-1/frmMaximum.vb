Public Class frmMaximum

  Private Sub btnFindLargest_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLargest.Click
    Dim num1, num2, largestValue As Double
    num1 = CDbl(txtFirstNum.Text)
    num2 = CDbl(txtSecondNum.Text)
    If num1 > num2 Then  'condition is (num1 > num2)
      largestValue = num1   'take this action if the condition is true
    Else
      largestValue = num2   'take this action if the condition is false
    End If
    txtResult.Text = "The largest value is " & largestValue & "."
  End Sub

End Class
