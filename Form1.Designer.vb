<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lstOutput = New ListBox()
        rdoVat1 = New RadioButton()
        rdoVat2 = New RadioButton()
        SuspendLayout()
        ' 
        ' lstOutput
        ' 
        lstOutput.FormattingEnabled = True
        lstOutput.ItemHeight = 15
        lstOutput.Location = New Point(247, 4)
        lstOutput.Name = "lstOutput"
        lstOutput.Size = New Size(400, 814)
        lstOutput.TabIndex = 1
        ' 
        ' rdoVat1
        ' 
        rdoVat1.AutoSize = True
        rdoVat1.Location = New Point(37, 79)
        rdoVat1.Name = "rdoVat1"
        rdoVat1.Size = New Size(41, 19)
        rdoVat1.TabIndex = 2
        rdoVat1.TabStop = True
        rdoVat1.Text = "1%"
        rdoVat1.UseVisualStyleBackColor = True
        ' 
        ' rdoVat2
        ' 
        rdoVat2.AutoSize = True
        rdoVat2.Location = New Point(37, 104)
        rdoVat2.Name = "rdoVat2"
        rdoVat2.Size = New Size(41, 19)
        rdoVat2.TabIndex = 3
        rdoVat2.TabStop = True
        rdoVat2.Text = "8%"
        rdoVat2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(704, 830)
        Controls.Add(rdoVat2)
        Controls.Add(rdoVat1)
        Controls.Add(lstOutput)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents rdoVat1 As RadioButton
    Friend WithEvents rdoVat2 As RadioButton
End Class
