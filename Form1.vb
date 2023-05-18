Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        driver()
    End Sub
    Private Function addGST(excGST As Single) As Single
        Const GST_rate As Integer = 10
        Dim incGST As Single
        incGST = excGST * (1 + (GST_rate / 100))
        Return incGST
    End Function
    Private Sub driver()
        For i = 1.0 To 10.0 Step 0.01
            lstOutput.Items.Add("Input price: " & FormatCurrency(i) & " Output price: " & FormatCurrency(addGST(i))
        Next i
    End Sub
End Class

'This function 
'Private Function addGST(excGST As Single) As Single
'    Const GST_rate As Integer = 10
'    Dim incGST As Single
'    incGST = excGST * (1 + (GST_rate / 100))
'    Return incGST
'End Function