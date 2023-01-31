<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtY2 = New System.Windows.Forms.TextBox()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.txtY1 = New System.Windows.Forms.TextBox()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btLimpiar = New System.Windows.Forms.Button()
        Me.btCalcular = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtY2
        '
        Me.txtY2.Location = New System.Drawing.Point(60, 151)
        Me.txtY2.Name = "txtY2"
        Me.txtY2.Size = New System.Drawing.Size(52, 22)
        Me.txtY2.TabIndex = 0
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(322, 334)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(52, 22)
        Me.txtX2.TabIndex = 1
        '
        'txtY1
        '
        Me.txtY1.Location = New System.Drawing.Point(60, 254)
        Me.txtY1.Name = "txtY1"
        Me.txtY1.Size = New System.Drawing.Size(52, 22)
        Me.txtY1.TabIndex = 2
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(155, 334)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(52, 22)
        Me.txtX1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(118, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(305, 252)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btLimpiar
        '
        Me.btLimpiar.Location = New System.Drawing.Point(480, 175)
        Me.btLimpiar.Name = "btLimpiar"
        Me.btLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btLimpiar.TabIndex = 5
        Me.btLimpiar.Text = "Limpiar"
        Me.btLimpiar.UseVisualStyleBackColor = True
        '
        'btCalcular
        '
        Me.btCalcular.Location = New System.Drawing.Point(155, 387)
        Me.btCalcular.Name = "btCalcular"
        Me.btCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btCalcular.TabIndex = 6
        Me.btCalcular.Text = "Calcular"
        Me.btCalcular.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(480, 408)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(75, 23)
        Me.btSalir.TabIndex = 7
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(236, 388)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 454)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btCalcular)
        Me.Controls.Add(Me.btLimpiar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtX1)
        Me.Controls.Add(Me.txtY1)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.txtY2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtY2 As System.Windows.Forms.TextBox
    Friend WithEvents txtX2 As System.Windows.Forms.TextBox
    Friend WithEvents txtY1 As System.Windows.Forms.TextBox
    Friend WithEvents txtX1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btLimpiar As System.Windows.Forms.Button
    Friend WithEvents btCalcular As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox

End Class
