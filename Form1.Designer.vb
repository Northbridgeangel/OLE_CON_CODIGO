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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.BTN_BORRAR = New System.Windows.Forms.Button()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.BTN_GRABAR = New System.Windows.Forms.Button()
        Me.BTN_IRALULTIMO = New System.Windows.Forms.Button()
        Me.BTN_AVANZAR = New System.Windows.Forms.Button()
        Me.BTN_RETROCEDER = New System.Windows.Forms.Button()
        Me.BTN_IRALPRIMERO = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OLE CON CODIGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(197, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clave"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BTN_NUEVO)
        Me.Panel1.Controls.Add(Me.BTN_BORRAR)
        Me.Panel1.Controls.Add(Me.BTN_BUSCAR)
        Me.Panel1.Controls.Add(Me.BTN_GRABAR)
        Me.Panel1.Controls.Add(Me.BTN_IRALULTIMO)
        Me.Panel1.Controls.Add(Me.BTN_AVANZAR)
        Me.Panel1.Controls.Add(Me.BTN_RETROCEDER)
        Me.Panel1.Controls.Add(Me.BTN_IRALPRIMERO)
        Me.Panel1.Location = New System.Drawing.Point(134, 336)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 46)
        Me.Panel1.TabIndex = 2
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Image = Global.OLE_CON_CODIGO.My.Resources.Resources.add_circle
        Me.BTN_NUEVO.Location = New System.Drawing.Point(341, 3)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(41, 40)
        Me.BTN_NUEVO.TabIndex = 7
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'BTN_BORRAR
        '
        Me.BTN_BORRAR.Image = Global.OLE_CON_CODIGO.My.Resources.Resources.delete_circle
        Me.BTN_BORRAR.Location = New System.Drawing.Point(435, 3)
        Me.BTN_BORRAR.Name = "BTN_BORRAR"
        Me.BTN_BORRAR.Size = New System.Drawing.Size(41, 40)
        Me.BTN_BORRAR.TabIndex = 6
        Me.BTN_BORRAR.UseVisualStyleBackColor = True
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Image = Global.OLE_CON_CODIGO.My.Resources.Resources.web_search
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(482, 3)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(41, 40)
        Me.BTN_BUSCAR.TabIndex = 5
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'BTN_GRABAR
        '
        Me.BTN_GRABAR.Image = Global.OLE_CON_CODIGO.My.Resources.Resources.ok
        Me.BTN_GRABAR.Location = New System.Drawing.Point(388, 3)
        Me.BTN_GRABAR.Name = "BTN_GRABAR"
        Me.BTN_GRABAR.Size = New System.Drawing.Size(41, 40)
        Me.BTN_GRABAR.TabIndex = 4
        Me.BTN_GRABAR.UseVisualStyleBackColor = True
        '
        'BTN_IRALULTIMO
        '
        Me.BTN_IRALULTIMO.Image = Global.OLE_CON_CODIGO.My.Resources.Resources.fast_forward
        Me.BTN_IRALULTIMO.Location = New System.Drawing.Point(144, 3)
        Me.BTN_IRALULTIMO.Name = "BTN_IRALULTIMO"
        Me.BTN_IRALULTIMO.Size = New System.Drawing.Size(41, 40)
        Me.BTN_IRALULTIMO.TabIndex = 3
        Me.BTN_IRALULTIMO.UseVisualStyleBackColor = True
        '
        'BTN_AVANZAR
        '
        Me.BTN_AVANZAR.Image = Global.OLE_CON_CODIGO.My.Resources.Resources.next_
        Me.BTN_AVANZAR.Location = New System.Drawing.Point(97, 3)
        Me.BTN_AVANZAR.Name = "BTN_AVANZAR"
        Me.BTN_AVANZAR.Size = New System.Drawing.Size(41, 40)
        Me.BTN_AVANZAR.TabIndex = 2
        Me.BTN_AVANZAR.UseVisualStyleBackColor = True
        '
        'BTN_RETROCEDER
        '
        Me.BTN_RETROCEDER.Image = Global.OLE_CON_CODIGO.My.Resources.Resources.back_
        Me.BTN_RETROCEDER.Location = New System.Drawing.Point(50, 3)
        Me.BTN_RETROCEDER.Name = "BTN_RETROCEDER"
        Me.BTN_RETROCEDER.Size = New System.Drawing.Size(41, 40)
        Me.BTN_RETROCEDER.TabIndex = 1
        Me.BTN_RETROCEDER.UseVisualStyleBackColor = True
        '
        'BTN_IRALPRIMERO
        '
        Me.BTN_IRALPRIMERO.Image = Global.OLE_CON_CODIGO.My.Resources.Resources.reward
        Me.BTN_IRALPRIMERO.Location = New System.Drawing.Point(3, 3)
        Me.BTN_IRALPRIMERO.Name = "BTN_IRALPRIMERO"
        Me.BTN_IRALPRIMERO.Size = New System.Drawing.Size(41, 40)
        Me.BTN_IRALPRIMERO.TabIndex = 0
        Me.BTN_IRALPRIMERO.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(182, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Provincia"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(278, 130)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(293, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(278, 172)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(293, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(278, 212)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(293, 20)
        Me.TextBox3.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents BTN_BORRAR As Button
    Friend WithEvents BTN_BUSCAR As Button
    Friend WithEvents BTN_GRABAR As Button
    Friend WithEvents BTN_IRALULTIMO As Button
    Friend WithEvents BTN_AVANZAR As Button
    Friend WithEvents BTN_RETROCEDER As Button
    Friend WithEvents BTN_IRALPRIMERO As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
