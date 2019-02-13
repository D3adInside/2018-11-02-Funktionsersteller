<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdRechnen = New System.Windows.Forms.Button()
        Me.txtZweite = New System.Windows.Forms.TextBox()
        Me.txtErste = New System.Windows.Forms.TextBox()
        Me.txtGroeste = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdRechnen
        '
        Me.cmdRechnen.Location = New System.Drawing.Point(376, 185)
        Me.cmdRechnen.Name = "cmdRechnen"
        Me.cmdRechnen.Size = New System.Drawing.Size(100, 31)
        Me.cmdRechnen.TabIndex = 0
        Me.cmdRechnen.Text = "Knopf"
        Me.cmdRechnen.UseVisualStyleBackColor = True
        '
        'txtZweite
        '
        Me.txtZweite.Location = New System.Drawing.Point(376, 101)
        Me.txtZweite.Name = "txtZweite"
        Me.txtZweite.Size = New System.Drawing.Size(100, 26)
        Me.txtZweite.TabIndex = 1
        '
        'txtErste
        '
        Me.txtErste.Location = New System.Drawing.Point(228, 101)
        Me.txtErste.Name = "txtErste"
        Me.txtErste.Size = New System.Drawing.Size(100, 26)
        Me.txtErste.TabIndex = 2
        '
        'txtGroeste
        '
        Me.txtGroeste.Location = New System.Drawing.Point(376, 291)
        Me.txtGroeste.Name = "txtGroeste"
        Me.txtGroeste.Size = New System.Drawing.Size(100, 26)
        Me.txtGroeste.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(372, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Zweite"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Erste"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Größte"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGroeste)
        Me.Controls.Add(Me.txtErste)
        Me.Controls.Add(Me.txtZweite)
        Me.Controls.Add(Me.cmdRechnen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdRechnen As Button
    Friend WithEvents txtZweite As TextBox
    Friend WithEvents txtErste As TextBox
    Friend WithEvents txtGroeste As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
