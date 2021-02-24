<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.txtten = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.save = New System.Windows.Forms.Button()
        Me.cancle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtten
        '
        Me.txtten.Location = New System.Drawing.Point(121, 45)
        Me.txtten.Name = "txtten"
        Me.txtten.Size = New System.Drawing.Size(196, 20)
        Me.txtten.TabIndex = 0
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(121, 111)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(196, 20)
        Me.txtemail.TabIndex = 1
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(121, 177)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(196, 20)
        Me.txtsdt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tên :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Email :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sdt :"
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(147, 252)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(75, 23)
        Me.save.TabIndex = 6
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'cancle
        '
        Me.cancle.Location = New System.Drawing.Point(242, 252)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(75, 23)
        Me.cancle.TabIndex = 7
        Me.cancle.Text = "Cancle"
        Me.cancle.UseVisualStyleBackColor = True
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 312)
        Me.Controls.Add(Me.cancle)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtten)
        Me.Name = "AddUser"
        Me.Text = "AddUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtten As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtsdt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents save As Button
    Friend WithEvents cancle As Button
End Class
