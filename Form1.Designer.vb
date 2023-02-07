<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurger
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
        Me.LblHeading = New System.Windows.Forms.Label()
        Me.picPrime = New System.Windows.Forms.PictureBox()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.btnprime = New System.Windows.Forms.Button()
        Me.btnSelectMeal = New System.Windows.Forms.Button()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.LblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPrime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblHeading
        '
        Me.LblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeading.Location = New System.Drawing.Point(239, 9)
        Me.LblHeading.Name = "LblHeading"
        Me.LblHeading.Size = New System.Drawing.Size(305, 33)
        Me.LblHeading.TabIndex = 0
        Me.LblHeading.Text = "Farm Burger Specials"
        Me.LblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picPrime
        '
        Me.picPrime.Location = New System.Drawing.Point(86, 48)
        Me.picPrime.Name = "picPrime"
        Me.picPrime.Size = New System.Drawing.Size(260, 250)
        Me.picPrime.TabIndex = 1
        Me.picPrime.TabStop = False
        '
        'picVeggie
        '
        Me.picVeggie.Location = New System.Drawing.Point(431, 48)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(260, 250)
        Me.picVeggie.TabIndex = 2
        Me.picVeggie.TabStop = False
        '
        'btnprime
        '
        Me.btnprime.Location = New System.Drawing.Point(151, 321)
        Me.btnprime.Name = "btnprime"
        Me.btnprime.Size = New System.Drawing.Size(128, 35)
        Me.btnprime.TabIndex = 3
        Me.btnprime.Text = "Prime beef"
        Me.btnprime.UseVisualStyleBackColor = True
        '
        'btnSelectMeal
        '
        Me.btnSelectMeal.Location = New System.Drawing.Point(321, 321)
        Me.btnSelectMeal.Name = "btnSelectMeal"
        Me.btnSelectMeal.Size = New System.Drawing.Size(128, 35)
        Me.btnSelectMeal.TabIndex = 4
        Me.btnSelectMeal.Text = "Select Meal"
        Me.btnSelectMeal.UseVisualStyleBackColor = True
        '
        'btnVeggie
        '
        Me.btnVeggie.Location = New System.Drawing.Point(493, 321)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Size = New System.Drawing.Size(128, 35)
        Me.btnVeggie.TabIndex = 5
        Me.btnVeggie.Text = "Veggie"
        Me.btnVeggie.UseVisualStyleBackColor = True
        '
        'LblInstructions
        '
        Me.LblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInstructions.Location = New System.Drawing.Point(206, 379)
        Me.LblInstructions.Name = "LblInstructions"
        Me.LblInstructions.Size = New System.Drawing.Size(360, 18)
        Me.LblInstructions.TabIndex = 6
        Me.LblInstructions.Text = "Choose a burger and then click the select meal button"
        Me.LblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConfirmation
        '
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(318, 435)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(172, 18)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Enjoy your special burger"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(321, 485)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmBurger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 551)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.LblInstructions)
        Me.Controls.Add(Me.btnVeggie)
        Me.Controls.Add(Me.btnSelectMeal)
        Me.Controls.Add(Me.btnprime)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picPrime)
        Me.Controls.Add(Me.LblHeading)
        Me.Name = "frmBurger"
        Me.Text = "Burger Specials"
        CType(Me.picPrime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblHeading As Label
    Friend WithEvents picPrime As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents btnprime As Button
    Friend WithEvents btnSelectMeal As Button
    Friend WithEvents btnVeggie As Button
    Friend WithEvents LblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button
End Class
