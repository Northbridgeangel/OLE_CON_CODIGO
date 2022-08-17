Imports System.Data.OleDb

Public Class Form1

    '-------------------------------------------------

    '--- CREO LOS OBJETOS BD A LOS QUE DARE VALOR:

    '--- (LUEGO EN EL FORM_LOAD)

    '--------------------------------------------------

    Private MyCn As New OleDbConnection

    Private MyDatAdp As New OleDbDataAdapter

    Private MyCmdBld As New OleDbCommandBuilder

    Private MyDataTbl As New DataTable

    Private MyRowPosition As Integer = 0

    Private Sub showrecords()
        If MyDataTbl.Rows.Count = 0 Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            Exit Sub
        End If
        TextBox1.Text = MyDataTbl.Rows(MyRowPosition)("CLAVE").ToString()
        TextBox2.Text = MyDataTbl.Rows(MyRowPosition)("NOMBRE").ToString()
        TextBox3.Text = MyDataTbl.Rows(MyRowPosition)("PROVINCIA").ToString()
    End Sub

    'Inicializo los objetos en la carga del formulario

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MyCn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Cristina\source\repos\OLE_CON_CODIGO\PRUEBA.mdb"

        MyCn.Open()

        MyDatAdp = New OleDbDataAdapter(“SELECT * FROM tabla”, MyCn)

        MyCmdBld = New OleDbCommandBuilder(MyDatAdp)

        MyDatAdp.Fill(MyDataTbl)


        '-----------------------
        'ESTÉTICA DE LOS BOTONES, QUE APAREZCA UN BOCADILLO DE TEXTO = ARRAY DE TOOLTIP
        Dim TL(8) As ToolTip 'DIMENSIONO SEGUN EN QUE CONTROLES QUIERO MI AYUDA
        For I = 0 To 8
            TL(I) = New ToolTip
            TL(I).IsBalloon = True
        Next
        TL(0).SetToolTip(Me.BTN_IRALPRIMERO, "Ir al primero")
        TL(1).SetToolTip(Me.BTN_RETROCEDER, "Ir al anterior")
        TL(2).SetToolTip(Me.BTN_AVANZAR, "Ir al siguiente")
        TL(3).SetToolTip(Me.BTN_IRALULTIMO, "Ir al último")
        TL(4).SetToolTip(Me.BTN_GRABAR, "Guardar Registro")
        TL(5).SetToolTip(Me.BTN_NUEVO, "Crear Registro")
        TL(6).SetToolTip(Me.BTN_BUSCAR, "Buscar")
        TL(7).SetToolTip(Me.BTN_BORRAR, "Borrar")
        '-----------------------

    End Sub

    'CREO LOS BOTONES 

    Private Sub BTN_IRALPRIMERO_Click(sender As Object, e As EventArgs) Handles BTN_IRALPRIMERO.Click
        MyRowPosition = 0
        Call showrecords()
    End Sub

    Private Sub BTN_RETROCEDER_Click(sender As Object, e As EventArgs) Handles BTN_RETROCEDER.Click
        If MyRowPosition = 0 Then Exit Sub
        MyRowPosition = MyRowPosition - 1
        Call showrecords()
    End Sub

    Private Sub BTN_AVANZAR_Click(sender As Object, e As EventArgs) Handles BTN_AVANZAR.Click
        If MyDataTbl.Rows.Count - 1 = MyRowPosition Then Exit Sub
        MyRowPosition = MyRowPosition + 1
        Call showrecords()
    End Sub

    Private Sub BTN_IRALULTIMO_Click(sender As Object, e As EventArgs) Handles BTN_IRALULTIMO.Click
        MyRowPosition = MyDataTbl.Rows.Count - 1
        Call showrecords()
    End Sub


    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        Dim MyNewRow As DataRow = MyDataTbl.NewRow()
        MyDataTbl.Rows.Add(MyNewRow)
        MyRowPosition = MyDataTbl.Rows.Count - 1
        Me.showrecords()
        TextBox1.Select()
        BTN_GRABAR.Enabled = True
        BTN_NUEVO.Enabled = False

    End Sub


    Private Sub BTN_GRABAR_Click(sender As Object, e As EventArgs) Handles BTN_GRABAR.Click
        'DATA ADAPTER
        Try
            If MyDataTbl.Rows.Count <> 0 Then
                MyDataTbl.Rows(MyRowPosition)("CLAVE") = TextBox1.Text
                MyDataTbl.Rows(MyRowPosition)("NOMBRE") = TextBox2.Text
                MyDataTbl.Rows(MyRowPosition)("PROVINCIA") = TextBox3.Text
                MyDatAdp.Update(MyDataTbl)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call REFRESCA()
        BTN_GRABAR.Enabled = False
        BTN_NUEVO.Enabled = True
    End Sub

    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        Dim sebusca As String
        Cursor.Current = Cursors.WaitCursor
        MyRowPosition = 0
        Call showrecords()

        sebusca = UCase(InputBox("Mete la clave del registro", "SE BUSCA"))
        For I = 0 To MyDataTbl.Rows.Count
            Call showrecords()
            'se busca por textbox1.text porque es el registro "CLAVE" (La clave principal en Access)
            If InStr(TextBox1.Text, sebusca) <> 0 Then
                GoTo sal
            End If
            MyRowPosition = I
        Next
        MsgBox("No esta")


        'El cursor del mouse le da forma de actualizar
sal:

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub BTN_BORRAR_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR.Click
        Dim R As Integer 'VARIABLE R PARA EL SI = 6 O EL NO =7 DEL MSGBOX
        R = MsgBox("¿Estas seguro de querer borrar el registro?", vbYesNo, "BORRAR REGISTRO")
        If R = 7 Then Exit Sub
        If MyDataTbl.Rows.Count <> 0 Then  'SI HAY FILAS ENTONCES
            MyDataTbl.Rows(MyRowPosition).Delete()
            MyDatAdp.Update(MyDataTbl)
            MyRowPosition = 0
            Me.showrecords()
        End If
    End Sub


    Sub REFRESCA()
        MyCn.Close()
        MyCn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Cristina\source\repos\OLE_CON_CODIGO\PRUEBA.mdb"
        MyDatAdp = New OleDbDataAdapter("SELECT * FROM tabla", MyCn)
        MyCmdBld = New OleDbCommandBuilder(MyDatAdp)
        MyDatAdp.Fill(MyDataTbl)
    End Sub

End Class

