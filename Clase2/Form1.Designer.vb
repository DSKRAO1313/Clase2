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
        numero1 = New TextBox()
        numero2 = New TextBox()
        btcalcular = New Button()
        num1 = New Label()
        num2 = New Label()
        Cm = New ComboBox()
        SuspendLayout()
        ' 
        ' numero1
        ' 
        numero1.Location = New Point(60, 74)
        numero1.Name = "numero1"
        numero1.Size = New Size(100, 23)
        numero1.TabIndex = 0
        ' 
        ' numero2
        ' 
        numero2.Location = New Point(60, 140)
        numero2.Name = "numero2"
        numero2.Size = New Size(100, 23)
        numero2.TabIndex = 1
        ' 
        ' btcalcular
        ' 
        btcalcular.Location = New Point(243, 100)
        btcalcular.Name = "btcalcular"
        btcalcular.Size = New Size(75, 23)
        btcalcular.TabIndex = 2
        btcalcular.Text = "Button1"
        btcalcular.UseVisualStyleBackColor = True
        ' 
        ' num1
        ' 
        num1.AutoSize = True
        num1.Location = New Point(62, 51)
        num1.Name = "num1"
        num1.Size = New Size(87, 15)
        num1.TabIndex = 3
        num1.Text = "primer numero"
        ' 
        ' num2
        ' 
        num2.AutoSize = True
        num2.Location = New Point(62, 116)
        num2.Name = "num2"
        num2.Size = New Size(98, 15)
        num2.TabIndex = 4
        num2.Text = "segundo numero"
        ' 
        ' Cm
        ' 
        Cm.FormattingEnabled = True
        Cm.Location = New Point(60, 216)
        Cm.Name = "Cm"
        Cm.Size = New Size(121, 23)
        Cm.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 293)
        Controls.Add(Cm)
        Controls.Add(num2)
        Controls.Add(num1)
        Controls.Add(btcalcular)
        Controls.Add(numero2)
        Controls.Add(numero1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents numero1 As TextBox
    Friend WithEvents numero2 As TextBox
    Friend WithEvents btcalcular As Button
    Friend WithEvents num1 As Label
    Friend WithEvents num2 As Label
    Friend WithEvents Cm As ComboBox

End Class
