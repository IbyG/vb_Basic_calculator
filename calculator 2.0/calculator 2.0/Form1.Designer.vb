<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tltippi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnModulus = New System.Windows.Forms.Button()
        Me.btnpi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pitip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(12, 25)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(315, 20)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(11, 78)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(315, 20)
        Me.txtNum2.TabIndex = 1
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(11, 126)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.ReadOnly = True
        Me.txtanswer.Size = New System.Drawing.Size(315, 20)
        Me.txtanswer.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 165)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(106, 165)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtract.TabIndex = 4
        Me.btnSubtract.Text = "Subtract"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(208, 165)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(75, 23)
        Me.btnDivide.TabIndex = 5
        Me.btnDivide.Text = "Divide"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(15, 204)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiply.TabIndex = 6
        Me.btnMultiply.Text = "Multiply "
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnModulus
        '
        Me.btnModulus.Location = New System.Drawing.Point(106, 204)
        Me.btnModulus.Name = "btnModulus"
        Me.btnModulus.Size = New System.Drawing.Size(75, 23)
        Me.btnModulus.TabIndex = 7
        Me.btnModulus.Text = "power"
        Me.btnModulus.UseVisualStyleBackColor = True
        '
        'btnpi
        '
        Me.btnpi.Location = New System.Drawing.Point(208, 204)
        Me.btnpi.Name = "btnpi"
        Me.btnpi.Size = New System.Drawing.Size(75, 23)
        Me.btnpi.TabIndex = 8
        Me.btnpi.Text = "pi"
        Me.btnpi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "First number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Second number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Answer"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(289, 165)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 62)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'tltippi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 247)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnpi)
        Me.Controls.Add(Me.btnModulus)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Name = "tltippi"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSubtract As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnModulus As System.Windows.Forms.Button
    Friend WithEvents btnpi As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents pitip As System.Windows.Forms.ToolTip

End Class
