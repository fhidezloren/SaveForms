<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SaveJson = New System.Windows.Forms.Button()
        Me.SaveXml = New System.Windows.Forms.Button()
        Me.SaveTxt = New System.Windows.Forms.Button()
        Me.TextAddress = New System.Windows.Forms.TextBox()
        Me.TextAge = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SaveJson
        '
        Me.SaveJson.BackColor = System.Drawing.Color.SaddleBrown
        Me.SaveJson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SaveJson.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveJson.FlatAppearance.BorderSize = 0
        Me.SaveJson.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveJson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveJson.Location = New System.Drawing.Point(451, 201)
        Me.SaveJson.Name = "SaveJson"
        Me.SaveJson.Size = New System.Drawing.Size(116, 23)
        Me.SaveJson.TabIndex = 26
        Me.SaveJson.Text = "Save as JSON"
        Me.SaveJson.UseVisualStyleBackColor = False
        '
        'SaveXml
        '
        Me.SaveXml.BackColor = System.Drawing.Color.Coral
        Me.SaveXml.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveXml.FlatAppearance.BorderSize = 0
        Me.SaveXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveXml.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveXml.Location = New System.Drawing.Point(281, 201)
        Me.SaveXml.Name = "SaveXml"
        Me.SaveXml.Size = New System.Drawing.Size(116, 23)
        Me.SaveXml.TabIndex = 25
        Me.SaveXml.Text = "Save as XML"
        Me.SaveXml.UseVisualStyleBackColor = False
        '
        'SaveTxt
        '
        Me.SaveTxt.BackColor = System.Drawing.Color.Peru
        Me.SaveTxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveTxt.FlatAppearance.BorderSize = 0
        Me.SaveTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveTxt.Location = New System.Drawing.Point(103, 201)
        Me.SaveTxt.Name = "SaveTxt"
        Me.SaveTxt.Size = New System.Drawing.Size(116, 23)
        Me.SaveTxt.TabIndex = 24
        Me.SaveTxt.Text = "Save as TXT"
        Me.SaveTxt.UseVisualStyleBackColor = False
        '
        'TextAddress
        '
        Me.TextAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAddress.Location = New System.Drawing.Point(103, 154)
        Me.TextAddress.Name = "TextAddress"
        Me.TextAddress.Size = New System.Drawing.Size(464, 26)
        Me.TextAddress.TabIndex = 23
        '
        'TextAge
        '
        Me.TextAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAge.Location = New System.Drawing.Point(103, 112)
        Me.TextAge.Name = "TextAge"
        Me.TextAge.Size = New System.Drawing.Size(128, 26)
        Me.TextAge.TabIndex = 22
        '
        'TextName
        '
        Me.TextName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.Location = New System.Drawing.Point(103, 69)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(464, 26)
        Me.TextName.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Age:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 308)
        Me.Controls.Add(Me.SaveJson)
        Me.Controls.Add(Me.SaveXml)
        Me.Controls.Add(Me.SaveTxt)
        Me.Controls.Add(Me.TextAddress)
        Me.Controls.Add(Me.TextAge)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveJson As Button
    Friend WithEvents SaveXml As Button
    Friend WithEvents SaveTxt As Button
    Friend WithEvents TextAddress As TextBox
    Friend WithEvents TextAge As TextBox
    Friend WithEvents TextName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
