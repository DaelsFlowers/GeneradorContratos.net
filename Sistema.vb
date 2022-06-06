Imports System.IO
Imports System.Math
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml
Public Class Sistema
    Dim entero As Double
    Dim decima As Double
    Dim aux As Double
    Dim aulx As String

#Region "Numerosparte1"

    Private Sub num1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num1.KeyPress
        num2.Focus()
        guardarnumeros1()
    End Sub

    Private Sub num2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num2.KeyPress
        num3.Focus()
        guardarnumeros1()
    End Sub

    Private Sub num3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num3.KeyPress
        num4.Focus()
        guardarnumeros1()
    End Sub

    Private Sub num4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num4.KeyPress
        num5.Focus()
        guardarnumeros1()
    End Sub

    Private Sub num5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num5.KeyPress
        num6.Focus()
        guardarnumeros1()
    End Sub

    Private Sub num6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num6.KeyPress
        num7.Focus()
        guardarnumeros1()
    End Sub

    Private Sub num7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num7.KeyPress
        num8.Focus()
        guardarnumeros1()
    End Sub

    Private Sub num8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num8.KeyPress
        num9.Focus()
        guardarnumeros1()
    End Sub

    Private Sub num9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num9.KeyPress
        num10.Focus()
        guardarnumeros1()
    End Sub

    Private Sub num10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num10.KeyPress
        num11.Focus()
        guardarnumeros1()
    End Sub

    Private Sub num11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num11.KeyPress
        num12.Focus()
        guardarnumeros1()
    End Sub

    Private Sub num12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num12.KeyPress
        num13.Focus()
        guardarnumeros1()
    End Sub

    Private Sub num13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num13.KeyPress
        txt4.Focus()
        guardarnumeros1()
    End Sub

#End Region
#Region "guardar numerosparte1"
    Public Sub guardarnumeros1()
        AllData.num1a = num1.Text
        AllData.num2a = num2.Text
        AllData.num3a = num3.Text
        AllData.num4a = num4.Text
        AllData.num5a = num5.Text
        AllData.num6a = num6.Text
        AllData.num7a = num7.Text
        AllData.num8a = num8.Text
        AllData.num9a = num9.Text
        AllData.num10a = num10.Text
        AllData.num11a = num11.Text
        AllData.num12a = num12.Text
        AllData.num13a = num13.Text
    End Sub

    Private Sub txt4_Enter(sender As Object, e As EventArgs) Handles txt4.Enter
        guardarnumeros1()
    End Sub


#End Region
#Region "GUARDAR ALLDATA"
    Public Sub guardardata()
        'parte 1
        AllData.folio = TextBox1.Text
        AllData.ciudad = TextBox2.Text
        AllData.txt1 = txt1.Text
        AllData.txt2 = txt2.Text
        AllData.txt3 = txt3.Text
        guardarnumeros1()
        AllData.txt4 = txt4.Text
        AllData.txt5 = txt5.Text
        AllData.txt6 = txt6.Text
        AllData.txt7 = txt7.Text
        AllData.txt8 = txt8.Text
        AllData.txt10 = txt10.Text
        AllData.txt11 = txt11.Text

        'parte 2
        AllData.txt12 = txt12.Text
        AllData.txt13 = txt13.Text
        AllData.txt14 = txt14.Text
        AllData.txt15 = txt15.Text
        AllData.txt16 = txt16.Text
        AllData.txt17 = txt17.Text
        AllData.txt18 = txt18.Text
        AllData.txt19 = txt19.Text

        'parte 3
        AllData.txt20 = txt20.Text
        AllData.txt21 = txt21.Text
        AllData.txt22 = txt22.Text
        AllData.txt23 = txt23.Text
        AllData.txt24 = txt24.Text
        AllData.txt25 = txt25.Text
        AllData.txt26 = txt26.Text
        AllData.txt27 = txt27.Text

        'parte 4
        AllData.txt28 = txt28.Text
        AllData.txt29 = txt29.Text

        'parte 5
        AllData.txt30 = txt30.Text
        AllData.txt31 = txt31.Text
        AllData.txt32 = txt32.Text

        'parte 6
        'cantidad
        AllData.txtcant1 = txtcant1.Text
        AllData.txtcant2 = txtcant2.Text
        AllData.txtcant3 = txtcant3.Text
        AllData.txtcant4 = txtcant4.Text
        AllData.txtcant5 = txtcant5.Text
        AllData.txtcant6 = txtcant6.Text
        AllData.txtcant7 = txtcant7.Text
        AllData.txtcant8 = txtcant8.Text
        AllData.txtcant9 = txtcant9.Text
        AllData.txtcant10 = txtcant10.Text
        'combo box

        AllData.txtcombo1 = txtcombo1.Text
        AllData.txtcombo2 = txtcombo2.Text
        AllData.txtcombo3 = txtcombo3.Text
        AllData.txtcombo4 = txtcombo4.Text
        AllData.txtcombo5 = txtcombo5.Text
        AllData.txtcombo6 = txtcombo6.Text
        AllData.txtcombo7 = txtcombo7.Text
        AllData.txtcombo8 = txtcombo8.Text
        AllData.txtcombo9 = txtcombo9.Text
        AllData.txtcombo10 = txtcombo10.Text
        'precio
        AllData.txtpreci1 = txtpreci1.Text
        AllData.txtpreci2 = txtpreci2.Text
        AllData.txtpreci3 = txtpreci3.Text
        AllData.txtpreci4 = txtpreci4.Text
        AllData.txtpreci5 = txtpreci5.Text
        AllData.txtpreci6 = txtpreci6.Text
        AllData.txtpreci7 = txtpreci7.Text
        AllData.txtpreci8 = txtpreci8.Text
        AllData.txtpreci9 = txtpreci9.Text
        AllData.txtpreci10 = txtpreci10.Text
        'ubicacion
        AllData.txtubi1 = txtubi1.Text
        AllData.txtubi2 = txtubi2.Text
        AllData.txtubi3 = txtubi3.Text
        AllData.txtubi4 = txtubi4.Text
        AllData.txtubi5 = txtubi5.Text
        AllData.txtubi6 = txtubi6.Text
        AllData.txtubi7 = txtubi7.Text
        AllData.txtubi8 = txtubi8.Text
        AllData.txtubi9 = txtubi9.Text
        AllData.txtubi10 = txtubi10.Text
        'total
        AllData.txttotal1 = txttotal1.Text
        AllData.txttotal2 = txttotal2.Text
        AllData.txttotal3 = txttotal3.Text
        AllData.txttotal4 = txttotal4.Text
        AllData.txttotal5 = txttotal5.Text
        AllData.txttotal6 = txttotal6.Text
        AllData.txttotal7 = txttotal7.Text
        AllData.txttotal8 = txttotal8.Text
        AllData.txttotal9 = txttotal9.Text
        AllData.txttotal10 = txttotal10.Text
        AllData.txt35 = txt35.Text
        AllData.txt39 = txt39.Text
        AllData.txtsubtotal1 = txtsubtotal1.Text
        AllData.txtsubtotal2 = txtsubtotal2.Text
        AllData.txtiva = auxiva1.Text
        AllData.txttotalt = txttotalT.Text
        AllData.txttotaltext = txttotalpagatext1.Text
        AllData.txtfechapaga = txtpaga1.Text
    End Sub

#End Region
#Region "borrar ALLDATA"
    Public Sub borrardatos()
        'parte 1
        AllData.txt1 = ""
        AllData.txt2 = ""
        AllData.txt3 = ""
        guardarnumeros1()
        AllData.txt4 = ""
        AllData.txt5 = ""
        AllData.txt6 = ""
        AllData.txt7 = ""
        AllData.txt8 = ""
        AllData.txt10 = ""
        AllData.txt11 = ""

        'parte 2
        AllData.txt12 = ""
        AllData.txt13 = ""
        AllData.txt14 = ""
        AllData.txt15 = ""
        AllData.txt16 = ""
        AllData.txt17 = ""
        AllData.txt18 = ""
        AllData.txt19 = ""

        'parte 3
        AllData.txt20 = ""
        AllData.txt21 = ""
        AllData.txt22 = ""
        AllData.txt23 = ""
        AllData.txt24 = ""
        AllData.txt25 = ""
        AllData.txt26 = ""
        AllData.txt27 = ""

        'parte 4
        AllData.txt28 = ""
        AllData.txt29 = ""

        'parte 5
        AllData.txt30 = ""
        AllData.txt31 = ""
        AllData.txt32 = ""

        'parte 6
        'cantidad
        AllData.txtcant1 = ""
        AllData.txtcant2 = ""
        AllData.txtcant3 = ""
        AllData.txtcant4 = ""
        AllData.txtcant5 = ""
        AllData.txtcant6 = ""
        AllData.txtcant7 = ""
        AllData.txtcant8 = ""
        AllData.txtcant9 = ""
        'combo box
        AllData.txtcant10 = ""
        AllData.txtcombo1 = ""
        AllData.txtcombo2 = ""
        AllData.txtcombo3 = ""
        AllData.txtcombo4 = ""
        AllData.txtcombo5 = ""
        AllData.txtcombo6 = ""
        AllData.txtcombo7 = ""
        AllData.txtcombo8 = ""
        AllData.txtcombo9 = ""
        AllData.txtcombo10 = ""
        'precio
        AllData.txtpreci1 = ""
        AllData.txtpreci2 = ""
        AllData.txtpreci3 = ""
        AllData.txtpreci4 = ""
        AllData.txtpreci5 = ""
        AllData.txtpreci6 = ""
        AllData.txtpreci7 = ""
        AllData.txtpreci8 = ""
        AllData.txtpreci9 = ""
        AllData.txtpreci10 = ""
        'ubicacion
        AllData.txtubi1 = ""
        AllData.txtubi2 = ""
        AllData.txtubi3 = ""
        AllData.txtubi4 = ""
        AllData.txtubi5 = ""
        AllData.txtubi6 = ""
        AllData.txtubi7 = ""
        AllData.txtubi8 = ""
        AllData.txtubi9 = ""
        AllData.txtubi10 = ""
        'total
        AllData.txttotal1 = ""
        AllData.txttotal2 = ""
        AllData.txttotal3 = ""
        AllData.txttotal4 = ""
        AllData.txttotal5 = ""
        AllData.txttotal6 = ""
        AllData.txttotal7 = ""
        AllData.txttotal8 = ""
        AllData.txttotal9 = ""
        AllData.txttotal10 = ""
        AllData.txt35 = ""
        AllData.txt39 = ""
        AllData.txtsubtotal1 = ""
        AllData.txtsubtotal2 = ""
        AllData.txtiva = ""
        AllData.txttotalt = ""
        AllData.txttotaltext = ""
        AllData.txtfirma = ""
        AllData.txtfechapaga = ""
    End Sub

#End Region
#Region "botones select 1"



    Private Sub btn1_CheckedChanged(sender As Object, e As EventArgs) Handles btn1.CheckedChanged
        If btn1.Checked = True Then
            AllData.opcionmul1 = "Efectivo"
        End If

    End Sub

    Private Sub btn2_CheckedChanged(sender As Object, e As EventArgs) Handles btn2.CheckedChanged
        If btn2.Checked = True Then
            AllData.opcionmul1 = "Cheque"
        End If
    End Sub

    Private Sub btn3_CheckedChanged(sender As Object, e As EventArgs) Handles btn3.CheckedChanged
        If btn3.Checked = True Then
            AllData.opcionmul1 = "Transferencia"
        End If
    End Sub
#End Region
#Region "botones fecha parte 5"
    Private Sub btn1p5_ValueChanged(sender As Object, e As EventArgs) Handles btn1p5.ValueChanged

        txt30.Text = btn1p5.Value.ToShortDateString
    End Sub

    Private Sub btn2p5_ValueChanged(sender As Object, e As EventArgs) Handles btn2p5.ValueChanged
        txt31.Text = btn2p5.Value.ToShortDateString
    End Sub

#End Region
#Region "btnparte1 multiple checkbox"
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        AllData.L = CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        AllData.M = CheckBox2.Checked
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        AllData.Mi = CheckBox3.Checked
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        AllData.J = CheckBox4.Checked
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        AllData.V = CheckBox6.Checked
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        AllData.S = CheckBox5.Checked
    End Sub



#End Region
#Region "totales automaticos 1"
    Private Sub txtpreci1_TextChanged(sender As Object, e As EventArgs) Handles txtpreci1.TextChanged
        If txtcant1.Text <> "" Then
            Try
                txttotal1.Text = Round(CInt(txtcant1.Text) * CDbl(txtpreci1.Text), 2)
                txttotal1.Text = moneda.transform(txttotal1.Text)
            Catch ex As Exception
                txttotal1.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtpreci2_TextChanged(sender As Object, e As EventArgs) Handles txtpreci2.TextChanged
        If txtcant2.Text <> "" Then
            Try
                txttotal2.Text = Round(CInt(txtcant2.Text) * CDbl(txtpreci2.Text), 2)
                txttotal2.Text = moneda.transform(txttotal2.Text)
            Catch ex As Exception
                txttotal2.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtpreci3_TextChanged(sender As Object, e As EventArgs) Handles txtpreci3.TextChanged
        If txtcant3.Text <> "" Then
            Try
                txttotal3.Text = Round(CInt(txtcant3.Text) * CDbl(txtpreci3.Text), 2)
                txttotal3.Text = moneda.transform(txttotal3.Text)
            Catch ex As Exception
                txttotal3.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtpreci4_TextChanged(sender As Object, e As EventArgs) Handles txtpreci4.TextChanged
        If txtcant4.Text <> "" Then
            Try
                txttotal4.Text = Round(CInt(txtcant4.Text) * CDbl(txtpreci4.Text), 2)
                txttotal4.Text = moneda.transform(txttotal4.Text)
            Catch ex As Exception
                txttotal4.Text = "$0.00"
            End Try
        End If
        actualizartotales()

    End Sub

    Private Sub txtpreci5_TextChanged(sender As Object, e As EventArgs) Handles txtpreci5.TextChanged
        If txtcant5.Text <> "" Then
            Try
                txttotal5.Text = Round(CInt(txtcant5.Text) * CDbl(txtpreci5.Text), 2)
                txttotal5.Text = moneda.transform(txttotal5.Text)
            Catch ex As Exception
                txttotal5.Text = "$0.00"
            End Try
        End If
        actualizartotales()

    End Sub

    Private Sub txtpreci6_TextChanged(sender As Object, e As EventArgs) Handles txtpreci6.TextChanged
        If txtcant6.Text <> "" Then
            Try
                txttotal6.Text = Round(CInt(txtcant6.Text) * CDbl(txtpreci6.Text), 2)
                txttotal6.Text = moneda.transform(txttotal6.Text)
            Catch ex As Exception
                txttotal6.Text = "$0.00"
            End Try
        End If
        actualizartotales()

    End Sub

    Private Sub txtpreci7_TextChanged(sender As Object, e As EventArgs) Handles txtpreci7.TextChanged
        If txtcant7.Text <> "" Then
            Try
                txttotal7.Text = Round(CInt(txtcant7.Text) * CDbl(txtpreci7.Text), 2)
                txttotal7.Text = moneda.transform(txttotal7.Text)
            Catch ex As Exception
                txttotal7.Text = "$0.00"
            End Try
        End If
        actualizartotales()

    End Sub

    Private Sub txtpreci8_TextChanged(sender As Object, e As EventArgs) Handles txtpreci8.TextChanged
        If txtcant8.Text <> "" Then
            Try
                txttotal8.Text = Round(CInt(txtcant8.Text) * CDbl(txtpreci8.Text), 2)
                txttotal8.Text = moneda.transform(txttotal8.Text)
            Catch ex As Exception
                txttotal8.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtpreci9_TextChanged(sender As Object, e As EventArgs) Handles txtpreci9.TextChanged
        If txtcant9.Text <> "" Then
            Try
                txttotal9.Text = Round(CInt(txtcant9.Text) * CDbl(txtpreci9.Text), 2)
                txttotal9.Text = moneda.transform(txttotal9.Text)
            Catch ex As Exception
                txttotal9.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtpreci10_TextChanged(sender As Object, e As EventArgs) Handles txtpreci10.TextChanged
        If txtcant10.Text <> "" Then
            Try
                txttotal10.Text = Round(CInt(txtcant10.Text) * CDbl(txtpreci10.Text), 2)
                txttotal10.Text = moneda.transform(txttotal10.Text)
            Catch ex As Exception
                txttotal10.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtcant1_TextChanged(sender As Object, e As EventArgs) Handles txtcant1.TextChanged
        If txtpreci1.Text <> "" Then
            Try
                txttotal1.Text = Round(CInt(txtcant1.Text) * CDbl(txtpreci1.Text), 2)
                txttotal1.Text = moneda.transform(txttotal1.Text)
            Catch ex As Exception
                txttotal1.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtcant2_TextChanged(sender As Object, e As EventArgs) Handles txtcant2.TextChanged
        If txtpreci2.Text <> "" Then
            Try
                txttotal2.Text = Round(CInt(txtcant2.Text) * CDbl(txtpreci2.Text), 2)
                txttotal2.Text = moneda.transform(txttotal2.Text)
            Catch ex As Exception
                txttotal2.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtcant3_TextChanged(sender As Object, e As EventArgs) Handles txtcant3.TextChanged
        If txtpreci3.Text <> "" Then
            Try
                txttotal3.Text = Round(CInt(txtcant3.Text) * CDbl(txtpreci3.Text), 2)
                txttotal3.Text = moneda.transform(txttotal3.Text)
            Catch ex As Exception
                txttotal3.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtcant4_TextChanged(sender As Object, e As EventArgs) Handles txtcant4.TextChanged
        If txtpreci4.Text <> "" Then
            Try
                txttotal4.Text = Round(CInt(txtcant4.Text) * CDbl(txtpreci4.Text), 2)
                txttotal4.Text = moneda.transform(txttotal4.Text)
            Catch ex As Exception
                txttotal4.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtcant5_TextChanged(sender As Object, e As EventArgs) Handles txtcant5.TextChanged
        If txtpreci5.Text <> "" Then
            Try
                txttotal5.Text = Round(CInt(txtcant5.Text) * CDbl(txtpreci5.Text), 2)
                txttotal5.Text = moneda.transform(txttotal5.Text)
            Catch ex As Exception
                txttotal5.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtcant6_TextChanged(sender As Object, e As EventArgs) Handles txtcant6.TextChanged
        If txtpreci6.Text <> "" Then
            Try
                txttotal6.Text = Round(CInt(txtcant6.Text) * CDbl(txtpreci6.Text), 2)
                txttotal6.Text = moneda.transform(txttotal6.Text)
            Catch ex As Exception
                txttotal6.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtcant7_TextChanged(sender As Object, e As EventArgs) Handles txtcant7.TextChanged
        If txtpreci7.Text <> "" Then
            Try
                txttotal7.Text = Round(CInt(txtcant7.Text) * CDbl(txtpreci7.Text), 2)
                txttotal7.Text = moneda.transform(txttotal7.Text)
            Catch ex As Exception
                txttotal7.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtcant8_TextChanged(sender As Object, e As EventArgs) Handles txtcant8.TextChanged
        If txtpreci8.Text <> "" Then
            Try
                txttotal8.Text = Round(CInt(txtcant8.Text) * CDbl(txtpreci8.Text), 2)
                txttotal8.Text = moneda.transform(txttotal8.Text)
            Catch ex As Exception
                txttotal8.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtcant9_TextChanged(sender As Object, e As EventArgs) Handles txtcant9.TextChanged
        If txtpreci9.Text <> "" Then
            Try
                txttotal9.Text = Round(CInt(txtcant9.Text) * CDbl(txtpreci9.Text), 2)
                txttotal9.Text = moneda.transform(txttotal9.Text)
            Catch ex As Exception
                txttotal9.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub

    Private Sub txtcant10_TextChanged(sender As Object, e As EventArgs) Handles txtcant10.TextChanged
        If txtpreci10.Text <> "" Then
            Try
                txttotal10.Text = Round(CInt(txtcant10.Text) * CDbl(txtpreci10.Text), 2)
                txttotal10.Text = moneda.transform(txttotal10.Text)
            Catch ex As Exception
                txttotal10.Text = "$0.00"
            End Try
        End If
        actualizartotales()
    End Sub
#End Region
#Region "actualizar totales auto"
    Public Sub actualizartotales()
        If (txttotal1.Text <> "$0.00") Or (txttotal2.Text <> "$0.00") Or (txttotal3.Text <> "$0.00") Or (txttotal4.Text <> "$0.00") Or (txttotal5.Text <> "$0.00") Or (txttotal6.Text <> "$0.00") Or (txttotal7.Text <> "$0.00") Or (txttotal8.Text <> "$0.00") Or (txttotal9.Text <> "$0.00") Or (txttotal10.Text <> "$0.00") Then
            Try
                txtsubtotal1.Text = Round(CDbl(txttotal1.Text.Replace("$", "").Replace(",", "")) + CDbl(txttotal2.Text.Replace("$", "").Replace(",", "")) + CDbl(txttotal3.Text.Replace("$", "").Replace(",", "")) + CDbl(txttotal4.Text.Replace("$", "").Replace(",", "")) + CDbl(txttotal5.Text.Replace("$", "").Replace(",", "")) + CDbl(txttotal6.Text.Replace("$", "").Replace(",", "")) + CDbl(txttotal7.Text.Replace("$", "").Replace(",", "")) + CDbl(txttotal8.Text.Replace("$", "").Replace(",", "")) + CDbl(txttotal9.Text.Replace("$", "").Replace(",", "")) + CDbl(txttotal10.Text.Replace("$", "").Replace(",", "")), 2)
                txtsubtotal1.Text = moneda.transform(txtsubtotal1.Text)
            Catch ex As Exception
                MsgBox("error")
            End Try
        Else
            txtsubtotal1.Text = "$0.00"
        End If


    End Sub

    Private Sub txtsubtotal1_TextChanged(sender As Object, e As EventArgs) Handles txtsubtotal1.TextChanged
        Try
            If txt35.Text = "" Then
                txtsubtotal2.Text = CDbl(txtsubtotal1.Text.Replace("$", "").Replace(",", ""))
            Else
                txtsubtotal2.Text = Round(CDbl(txtsubtotal1.Text.Replace("$", "").Replace(",", "")) - CDbl(txt35.Text), 3)
            End If

            txtsubtotal2.Text = moneda.transform(txtsubtotal2.Text)
        Catch ex As Exception
            txtsubtotal2.Text = "$0.00"
        End Try
    End Sub

    Private Sub txtsubtotal2_TextChanged(sender As Object, e As EventArgs) Handles txtsubtotal2.TextChanged
        Try
            If ivachecker.Checked = True Then
                Try
                    txttotalT.Text = Round(CDbl(txtsubtotal2.Text.Replace("$", "").Replace(",", "")) + CDbl(auxiva1.Text.Replace("$", "").Replace(",", "")), 2)

                    txttotalT.Text = moneda.transform(txttotalT.Text)
                Catch ex As Exception
                    txttotalT.Text = "$0.00"
                End Try
            Else
                auxiva1.Text = Round((CDbl(txtsubtotal2.Text.Replace("$", "").Replace(",", "")) * 0.16), 2)
                auxiva1.Text = moneda.transform(auxiva1.Text)
            End If
        Catch ex As Exception
            auxiva1.Text = "$0.00"
        End Try
    End Sub

    Private Sub auxiva1_TextChanged(sender As Object, e As EventArgs) Handles auxiva1.TextChanged
        If auxiva1.Text = "" Then
            txttotalT.Text = "0"
        Else
            Try
                txttotalT.Text = Round(CDbl(txtsubtotal2.Text.Replace("$", "").Replace(",", "")) + CDbl(auxiva1.Text.Replace("$", "").Replace(",", "")), 2)

                txttotalT.Text = moneda.transform(txttotalT.Text)
            Catch ex As Exception
                txttotalT.Text = "$0.00"
            End Try
        End If
    End Sub

    Private Sub txt35_TextChanged(sender As Object, e As EventArgs) Handles txt35.TextChanged
        Try
            If txt35.Text = "" Then
                txtsubtotal2.Text = CDbl(txtsubtotal1.Text.Replace("$", "").Replace(",", ""))
            Else
                If (CDbl(txtsubtotal1.Text.Replace("$", "").Replace(",", "")) - CDbl(txt35.Text)) < 0 Then
                Else
                    txtsubtotal2.Text = CDbl(txtsubtotal1.Text.Replace("$", "").Replace(",", "")) - CDbl(txt35.Text)
                    txtsubtotal2.Text = moneda.transform(txtsubtotal2.Text)
                End If
            End If
        Catch ex As Exception
            txtsubtotal2.Text = "$0.00"
        End Try
    End Sub

    Private Sub txt20_TextChanged(sender As Object, e As EventArgs) Handles txt20.TextChanged
        txtnomejec.Text = txt20.Text

    End Sub

    Private Sub txt12_TextChanged(sender As Object, e As EventArgs) Handles txt12.TextChanged
        txtnomcontra.Text = txt12.Text
        txtnompaga.Text = txt12.Text
    End Sub

    Private Sub txttotalT_TextChanged(sender As Object, e As EventArgs) Handles txttotalT.TextChanged
        txttotalpaga1.Text = txttotalT.Text
    End Sub

    Private Sub btntiemerpaga1_ValueChanged(sender As Object, e As EventArgs) Handles btntiemerpaga1.ValueChanged
        txtpaga1.Text = btntiemerpaga1.Value.ToShortDateString
    End Sub

    Private Sub txttotalpaga1_TextChanged(sender As Object, e As EventArgs) Handles txttotalpaga1.TextChanged
        'entero = CInt(txttotalpaga1.Text.Replace("$", ""))
        aulx = txttotalpaga1.Text.Replace(",", "")
        entero = CDbl(aulx.Replace("$", ""))
        decima = Truncate(entero)
        aux = decima
        decima = Round(decima - entero, 2) ' parte decimal
        decima = decima * -100
        If txttotalpaga1.Text = "$0" Or txttotalpaga1.Text = "$0.00" Then
            txttotalpagatext1.Text = ""
        Else
            If decima = 0 Then
                txttotalpagatext1.Text = aletras.letras(aux) & " pesos 00/100 M.N."
            Else
                txttotalpagatext1.Text = aletras.letras(aux) & " pesos " & decima & "/100 M.N."
            End If
        End If

    End Sub

#End Region
    Private Sub Sistema_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Login.Close()
    End Sub
#Region "Generar pdf"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = "" Or
            TextBox2.Text = "" Or
            txt1.Text = "" Or
            txt2.Text = "" Or
            txt5.Text = "" Or
            txt4.Text = "" Or
            txt6.Text = "" Or
            txt7.Text = "" Or
            txt8.Text = "" Or
            txt10.Text = "" Or
            txt11.Text = "" Or
            txt12.Text = "" Or
            txt13.Text = "" Or
            txt15.Text = "" Or
            txt14.Text = "" Or
            txt17.Text = "" Or
            txt16.Text = "" Or
            txt18.Text = "" Or
            txt19.Text = "" Or
            txt20.Text = "" Or
            txt21.Text = "" Or
            txt22.Text = "" Or
            txt23.Text = "" Or
            txt24.Text = "" Or
            txt25.Text = "" Or
            txt26.Text = "" Or
            txt27.Text = "" Or
            txt28.Text = "" Or
            txt29.Text = "" Or
            txt32.Text = "" Or
            txtpaga1.Text = "" Or
            txt30.Text = "" Or
            txt31.Text = "" Or
            txt17.Text = "") Then
            MsgBox("Favor De Llenar Todos Los Campos", vbInformation, "Campos Incompletos")
        Else
            guardardata()
            Dim guardar As SaveFileDialog = New SaveFileDialog()
            guardar.FileName = Date.Now.ToShortDateString & ".pdf"
            guardar.Filter = "Pdf(*.pdf)|*.pdf"
            guardar.Title = "Guardar pdf"
            Dim paginahtml As String
            paginahtml = SNA.My.Resources.plantilla.ToString




            If guardar.ShowDialog() = DialogResult.OK Then
                'Using stream As FileStream = New FileStream(guardar.FileName, FileMode.Create)
                '    Dim pdfDoc As Document = New Document(PageSize.B4)
                'Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, stream)
                Dim oDoc As New iTextSharp.text.Document(PageSize.B4, 0, 0, 0, 0)
                Dim pdfw As iTextSharp.text.pdf.PdfWriter
                Dim cb As PdfContentByte
                Dim fuente As iTextSharp.text.pdf.BaseFont
                Dim nombrearchivo As String = guardar.FileName

                Try
                    pdfw = PdfWriter.GetInstance(oDoc, New FileStream(nombrearchivo, FileMode.Create, FileAccess.Write, FileShare.None))
                    oDoc.Open()
                    cb = pdfw.DirectContent
                    oDoc.NewPage()
                    cb.BeginText()
                    fuente = FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont
                    cb.SetFontAndSize(fuente, 10)
                    cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)

                    Dim imgfont As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(SNA.My.Resources.plantnusie, System.Drawing.Imaging.ImageFormat.Jpeg)
                    imgfont.ScaleToFit(1000, 1000)
                    imgfont.ScaleAbsolute(oDoc.PageSize)
                    imgfont.Alignment = iTextSharp.text.Image.UNDERLYING
                    imgfont.SetAbsolutePosition(0, 0)
                    oDoc.Add(imgfont)

                    'imprimir variables
                    Try
                        '----------------------------------Folio y fecha--------------------------------------------------------
                        'se imprime el folio
                        If AllData.folio = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.folio, 570, PageSize.B4.Height - 35, 0)
                        End If
                        'se imprime la ciudad
                        If AllData.ciudad = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.ciudad, 570, PageSize.B4.Height - 61, 0)
                        End If
                        'se imprime la fecha
                        cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.fecha, 570, PageSize.B4.Height - 82, 0)
                        'se imprime txt1
                        '___________________________________________________________________________________________________________________________
                        '-----------------------------------------Datos primera parte inicio-------------------------------------------------
                        '___________________________________________________________________________________________________________________________
                        If AllData.txt1 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt1, 140, PageSize.B4.Height - 152, 0)
                        End If
                        'se imprime txt2
                        If AllData.txt2 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt2, 480, PageSize.B4.Height - 152, 0)
                        End If
                        'se imprime txt3
                        If AllData.txt3 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt3, 110, PageSize.B4.Height - 169, 0)
                        End If
                        '--------------------------------------Numeros RFC----------------------------------------------------
                        'se imprime num1
                        Dim xpos As Integer = 480
                        If AllData.num1a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num1a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        'se imprime txt3
                        If AllData.num2a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num2a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        'se imprime txt3
                        If AllData.num3a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num3a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        'se imprime txt3
                        If AllData.num4a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num4a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        'se imprime txt3
                        If AllData.num5a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num5a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        'se imprime txt3
                        If AllData.num6a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num6a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        'se imprime txt3
                        If AllData.num7a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num7a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        'se imprime txt3
                        If AllData.num8a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num8a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        'se imprime txt3
                        If AllData.num9a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num9a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        'se imprime txt3
                        If AllData.num10a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num10a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        'se imprime txt3
                        If AllData.num11a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num11a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        'se imprime txt3
                        If AllData.num12a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num12a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        'se imprime txt3
                        If AllData.num13a = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.num13a, xpos, PageSize.B4.Height - 169, 0)
                            xpos = xpos + 15
                        End If
                        '----------------------------------fin de rfc--------------------------------------------------------
                        If AllData.txt4 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt4, 95, PageSize.B4.Height - 187, 0)
                        End If
                        If AllData.txt5 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt5, 335, PageSize.B4.Height - 187, 0)
                        End If
                        If AllData.txt6 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt6, 455, PageSize.B4.Height - 187, 0)
                        End If
                        ''----------------------------siguente linea--------------------------------------------------------------
                        If AllData.txt7 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt7, 85, PageSize.B4.Height - 205, 0)
                        End If
                        If AllData.txt8 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt8, 270, PageSize.B4.Height - 205, 0)
                        End If


                        '------------------------OPCION 1-------------------------------------------------------------------
                        If AllData.opcionmul1 = "" Then
                        Else
                            If AllData.opcionmul1 = "Efectivo" Then
                                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "x", 495, PageSize.B4.Height - 205, 0)
                            ElseIf AllData.opcionmul1 = "Cheque" Then
                                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "x", 544, PageSize.B4.Height - 205, 0)
                            ElseIf AllData.opcionmul1 = "Transferencia" Then
                                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "x", 594, PageSize.B4.Height - 205, 0)
                            End If
                        End If
                        '_______________________________________inicio de opcion multiple____________________________________________________________________________________
                        If AllData.L = True Then
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "x", 156, PageSize.B4.Height - 222, 0)
                        End If
                        If AllData.M = True Then
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "x", 172, PageSize.B4.Height - 222, 0)
                        End If
                        If AllData.Mi = True Then
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "x", 190, PageSize.B4.Height - 222, 0)
                        End If
                        If AllData.J = True Then
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "x", 208, PageSize.B4.Height - 222, 0)
                        End If
                        If AllData.V = True Then
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "x", 223, PageSize.B4.Height - 222, 0)
                        End If
                        If AllData.S = True Then
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "x", 241, PageSize.B4.Height - 222, 0)
                        End If
                        '___________________________________________________________________________________________________________________________
                        '___________________________________________________________________________________________________________________________

                        If AllData.txt10 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt10, 365, PageSize.B4.Height - 223, 0)
                        End If
                        'se imprime txt3
                        If AllData.txt11 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt11, 595, PageSize.B4.Height - 223, 0)
                        End If
                        '___________________________________________________________________________________________________________________________
                        '_______________________________________________Fin parte 1____________________________________________________________________________
                        '___________________________________________________________________________________________________________________________


                        '___________________________________________________________________________________________________________________________
                        '_______________________________________________parte 2____________________________________________________________________________
                        '___________________________________________________________________________________________________________________________

                        If AllData.txt12 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt12, 95, PageSize.B4.Height - 260, 0)
                        End If
                        If AllData.txt13 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt13, 480, PageSize.B4.Height - 260, 0)
                        End If
                        '___________________________________________________________________________________________________________________________
                        If AllData.txt14 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt14, 80, PageSize.B4.Height - 278, 0)
                        End If
                        If AllData.txt15 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt15, 375, PageSize.B4.Height - 278, 0)
                        End If
                        If AllData.txt16 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt16, 540, PageSize.B4.Height - 278, 0)
                        End If
                        '___________________________________________________________________________________________________________________________
                        If AllData.txt17 = "" Then

                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt17, 95, PageSize.B4.Height - 295, 0)
                        End If
                        If AllData.txt18 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt18, 442, PageSize.B4.Height - 295, 0)
                        End If
                        If AllData.txt19 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt19, 575, PageSize.B4.Height - 295, 0)
                        End If

                        '___________________________________________________________________________________________________________________________
                        '__________________________________________________________parte 3__________________________________________________________
                        '___________________________________________________________________________________________________________________________

                        If AllData.txt20 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt20, 95, PageSize.B4.Height - 260 - 74, 0)
                        End If
                        If AllData.txt21 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt21, 480, PageSize.B4.Height - 260 - 74, 0)
                        End If
                        '___________________________________________________________________________________________________________________________
                        If AllData.txt22 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt22, 80, PageSize.B4.Height - 278 - 73, 0)
                        End If
                        If AllData.txt23 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt23, 375, PageSize.B4.Height - 278 - 73, 0)
                        End If
                        If AllData.txt24 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt24, 540, PageSize.B4.Height - 278 - 73, 0)
                        End If
                        '___________________________________________________________________________________________________________________________
                        If AllData.txt25 = "" Then

                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt25, 95, PageSize.B4.Height - 295 - 74, 0)
                        End If
                        If AllData.txt26 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt26, 442, PageSize.B4.Height - 295 - 74, 0)
                        End If
                        If AllData.txt27 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt27, 575, PageSize.B4.Height - 295 - 74, 0)
                        End If

                        '___________________________________________________________________________________________________________________________
                        '_________________________________________________pARTE 4__________________________________________________________________________
                        '___________________________________________________________________________________________________________________________

                        If AllData.txt28 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt28, 138, PageSize.B4.Height - 409, 0)
                        End If
                        If AllData.txt29 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt29, 480, PageSize.B4.Height - 409, 0)
                        End If

                        '___________________________________________________________________________________________________________________________
                        '_________________________________________________pARTE 5__________________________________________________________________________
                        '___________________________________________________________________________________________________________________________
                        If AllData.txt30 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt30, 95, PageSize.B4.Height - 448, 0)
                        End If
                        If AllData.txt31 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt31, 240, PageSize.B4.Height - 448, 0)
                        End If
                        If AllData.txt32 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txt32, 355, PageSize.B4.Height - 448, 0)
                        End If

                        '___________________________________________________________________________________________________________________________
                        '_________________________________________________pARTE 6__________________________________________________________________________
                        '___________________________________________________________________________________________________________________________
                        If AllData.txtcant1 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcant1, 40, PageSize.B4.Height - 493, 0)
                        End If
                        If AllData.txtcombo1 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcombo1, 100, PageSize.B4.Height - 493, 0)
                        End If
                        If AllData.txtubi1 = "" Then
                        Else
                            cb.SetFontAndSize(fuente, 8)
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtubi1, 415, PageSize.B4.Height - 493, 0)
                            cb.SetFontAndSize(fuente, 10)
                        End If

                        If AllData.txtpreci1 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtpreci1, 505, PageSize.B4.Height - 493, 0)
                        End If
                        If txttotal1.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotal1.Text, 595, PageSize.B4.Height - 493, 0)
                        End If


                        If AllData.txtcant2 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcant2, 40, PageSize.B4.Height - 511, 0)
                        End If
                        If AllData.txtcombo2 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcombo2, 100, PageSize.B4.Height - 511, 0)
                        End If
                        If AllData.txtubi2 = "" Then
                        Else

                            cb.SetFontAndSize(fuente, 8)
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtubi2, 415, PageSize.B4.Height - 511, 0)
                            cb.SetFontAndSize(fuente, 10)
                        End If

                        If AllData.txtpreci2 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtpreci2, 505, PageSize.B4.Height - 511, 0)
                        End If
                        If txttotal2.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotal2.Text, 595, PageSize.B4.Height - 511, 0)
                        End If

                        Dim xxp As Integer = -17

                        If AllData.txtcant3 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcant3, 40, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtcombo3 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcombo3, 100, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtubi3 = "" Then
                        Else
                            cb.SetFontAndSize(fuente, 8)

                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtubi3, 415, PageSize.B4.Height - 511 + xxp, 0)
                            cb.SetFontAndSize(fuente, 10)

                        End If

                        If AllData.txtpreci3 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtpreci3, 505, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If txttotal3.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotal3.Text, 595, PageSize.B4.Height - 511 + xxp, 0)
                        End If

                        xxp = xxp - 16
                        If AllData.txtcant4 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcant4, 40, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtcombo4 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcombo4, 100, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtubi4 = "" Then
                        Else
                            cb.SetFontAndSize(fuente, 8)
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtubi4, 415, PageSize.B4.Height - 511 + xxp, 0)
                            cb.SetFontAndSize(fuente, 10)
                        End If

                        If AllData.txtpreci4 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtpreci4, 505, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If txttotal4.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotal4.Text, 595, PageSize.B4.Height - 511 + xxp, 0)
                        End If



                        xxp = xxp - 16
                        If AllData.txtcant5 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcant5, 40, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtcombo5 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcombo5, 100, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtubi5 = "" Then
                        Else
                            cb.SetFontAndSize(fuente, 8)
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtubi5, 415, PageSize.B4.Height - 511 + xxp, 0)
                            cb.SetFontAndSize(fuente, 10)
                        End If

                        If AllData.txtpreci5 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtpreci5, 505, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If txttotal5.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotal5.Text, 595, PageSize.B4.Height - 511 + xxp, 0)
                        End If

                        xxp = xxp - 16
                        If AllData.txtcant6 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcant6, 40, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtcombo6 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcombo6, 100, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtubi6 = "" Then
                        Else
                            cb.SetFontAndSize(fuente, 8)
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtubi6, 415, PageSize.B4.Height - 511 + xxp, 0)
                            cb.SetFontAndSize(fuente, 10)
                        End If

                        If AllData.txtpreci6 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtpreci6, 505, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If txttotal6.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotal6.Text, 595, PageSize.B4.Height - 511 + xxp, 0)
                        End If


                        xxp = xxp - 16
                        If AllData.txtcant7 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcant7, 40, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtcombo7 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcombo7, 100, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtubi7 = "" Then
                        Else
                            cb.SetFontAndSize(fuente, 8)
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtubi7, 415, PageSize.B4.Height - 511 + xxp, 0)
                            cb.SetFontAndSize(fuente, 10)
                        End If

                        If AllData.txtpreci7 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtpreci7, 505, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If txttotal7.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotal7.Text, 595, PageSize.B4.Height - 511 + xxp, 0)
                        End If


                        xxp = xxp - 16
                        If AllData.txtcant8 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcant8, 40, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtcombo8 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcombo8, 100, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtubi8 = "" Then
                        Else
                            cb.SetFontAndSize(fuente, 8)
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtubi8, 415, PageSize.B4.Height - 511 + xxp, 0)
                            cb.SetFontAndSize(fuente, 10)
                        End If

                        If AllData.txtpreci8 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtpreci8, 505, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If txttotal8.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotal8.Text, 595, PageSize.B4.Height - 511 + xxp, 0)
                        End If


                        xxp = xxp - 17
                        If AllData.txtcant9 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcant9, 40, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtcombo9 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcombo9, 100, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtubi9 = "" Then
                        Else
                            cb.SetFontAndSize(fuente, 8)
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtubi9, 415, PageSize.B4.Height - 511 + xxp, 0)
                            cb.SetFontAndSize(fuente, 10)
                        End If

                        If AllData.txtpreci9 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtpreci9, 505, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If txttotal9.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotal9.Text, 595, PageSize.B4.Height - 511 + xxp, 0)
                        End If



                        xxp = xxp - 17
                        If AllData.txtcant10 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcant10, 40, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtcombo10 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtcombo10, 100, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If AllData.txtubi10 = "" Then
                        Else
                            cb.SetFontAndSize(fuente, 8)
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtubi10, 415, PageSize.B4.Height - 511 + xxp, 0)
                            cb.SetFontAndSize(fuente, 10)
                        End If

                        If AllData.txtpreci10 = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.txtpreci10, 505, PageSize.B4.Height - 511 + xxp, 0)
                        End If
                        If txttotal10.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotal10.Text, 595, PageSize.B4.Height - 511 + xxp, 0)
                        End If



                        If txtsubtotal1.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txtsubtotal1.Text, 600, PageSize.B4.Height - 530 + xxp, 0)
                        End If

                        If txt35.Text = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txt35.Text, 600, PageSize.B4.Height - 547 + xxp, 0)
                        End If

                        If txtsubtotal2.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txtsubtotal2.Text, 600, PageSize.B4.Height - 563 + xxp, 0)
                        End If
                        If auxiva1.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, auxiva1.Text, 600, PageSize.B4.Height - 579 + xxp, 0)
                        End If
                        If txttotalT.Text = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotalT.Text, 600, PageSize.B4.Height - 595 + xxp, 0)
                        End If


                        xxp = xxp - 75
                        If txt20.Text = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txt20.Text, 280, PageSize.B4.Height - 595 + xxp, 0)
                        End If

                        If txt12.Text = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txt12.Text, 500, PageSize.B4.Height - 595 + xxp, 0)
                        End If

                        xxp = xxp - 50
                        If txttotalpaga1.Text = "$0.00" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotalpaga1.Text, 45, PageSize.B4.Height - 635 + xxp, 0)
                        End If

                        If txttotalpagatext1.Text = "." Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttotalpagatext1.Text, 180, PageSize.B4.Height - 635 + xxp, 0)
                        End If


                        If txtpaga1.Text = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txtpaga1.Text, 223, PageSize.B4.Height - 655 + xxp, 0)
                        End If

                        If txtnompaga.Text = "" Then
                        Else
                            cb.SetFontAndSize(fuente, 8)
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txtnompaga.Text, 115, PageSize.B4.Height - 706 + xxp, 0)
                            cb.SetFontAndSize(fuente, 10)
                        End If
                        If txtdireccionpaga.Text = "" Then
                        Else
                            cb.SetFontAndSize(fuente, 8)
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txtdireccionpaga.Text, 115, PageSize.B4.Height - 722 + xxp, 0)
                            cb.SetFontAndSize(fuente, 10)
                        End If

                        If txttelpaga.Text = "" Then
                        Else
                            cb.SetFontAndSize(fuente, 8)
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txttelpaga.Text, 410, PageSize.B4.Height - 706 + xxp, 0)
                            cb.SetFontAndSize(fuente, 10)
                        End If

                        If txt12.Text = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, txt12.Text, 515, PageSize.B4.Height - 702 + xxp, 0)
                        End If

                        xxp = xxp + 100

                        cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, AllData.fecha, 420, PageSize.B4.Height - 700 + xxp, 0)

                        If TextBox1.Text = "" Then
                        Else
                            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, TextBox1.Text, 580, PageSize.B4.Height - 700 + xxp, 0)
                        End If


                        If txt39.Text = "" Then
                        Else
                            Dim table As New PdfPTable(1)
                            table.WidthPercentage = (66.0F)
                            table.HorizontalAlignment = 0
                            table.PaddingTop = 100.0F
                            Dim cell As New PdfPCell()
                            cell.Colspan = 1
                            cell.Border = 0
                            cell.Phrase = (New Phrase(txt39.Text))
                            cell.PaddingTop = 666.0F
                            cell.PaddingLeft = 33.0F
                            table.AddCell(cell)
                            oDoc.Add(table)
                        End If

                    Catch ex As Exception

                    End Try

                    'Fin del flujo de bytes.
                    cb.EndText()
                    'Forzamos vaciamiento del buffer.
                    pdfw.Flush()
                    'Cerramos el documento.
                    oDoc.Close()
                    MsgBox("Pdf Generado", vbInformation, "Pdf")
                Catch ex As Exception
                    If File.Exists(nombrearchivo) Then
                        'Cerramos el documento si esta abierto.
                        'Y asi desbloqueamos el archivo para su eliminacion.
                        If oDoc.IsOpen Then oDoc.Close()
                        '... lo eliminamos de disco.
                        File.Delete(nombrearchivo)
                    End If
                    Throw New Exception("Error al generar archivo PDF (" & ex.Message & ")")
                Finally
                    cb = Nothing
                    pdfw = Nothing
                    oDoc = Nothing
                End Try
            End If
        End If
    End Sub
#End Region
#Region "focus y enter"


    Private Sub Sistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt1.Focus()
        End If
    End Sub

    Private Sub txt1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt1.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt2.Focus()
        End If
    End Sub

    Private Sub txt2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt2.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt3.Focus()
        End If
    End Sub

    Private Sub txt3_KeyDown(sender As Object, e As KeyEventArgs) Handles txt3.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num1.Focus()
        End If
    End Sub

    Private Sub txt5_KeyDown(sender As Object, e As KeyEventArgs) Handles txt5.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt6.Focus()
        End If
    End Sub

    Private Sub txt4_KeyDown(sender As Object, e As KeyEventArgs) Handles txt4.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt5.Focus()
        End If
    End Sub

    Private Sub txt6_KeyDown(sender As Object, e As KeyEventArgs) Handles txt6.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt7.Focus()
        End If
    End Sub

    Private Sub txt7_KeyDown(sender As Object, e As KeyEventArgs) Handles txt7.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt8.Focus()
        End If
    End Sub

    Private Sub txt8_KeyDown(sender As Object, e As KeyEventArgs) Handles txt8.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt10.Focus()
        End If
    End Sub

    Private Sub txt10_KeyDown(sender As Object, e As KeyEventArgs) Handles txt10.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt11.Focus()
        End If
    End Sub

    Private Sub txt11_KeyDown(sender As Object, e As KeyEventArgs) Handles txt11.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt12.Focus()
        End If
    End Sub

    Private Sub txt12_KeyDown(sender As Object, e As KeyEventArgs) Handles txt12.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt13.Focus()
        End If
    End Sub

    Private Sub txt13_KeyDown(sender As Object, e As KeyEventArgs) Handles txt13.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt14.Focus()
        End If
    End Sub

    Private Sub txt14_KeyDown(sender As Object, e As KeyEventArgs) Handles txt14.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt15.Focus()
        End If
    End Sub

    Private Sub txt15_KeyDown(sender As Object, e As KeyEventArgs) Handles txt15.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt16.Focus()
        End If
    End Sub

    Private Sub txt16_KeyDown(sender As Object, e As KeyEventArgs) Handles txt16.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt17.Focus()
        End If
    End Sub

    Private Sub txt17_KeyDown(sender As Object, e As KeyEventArgs) Handles txt17.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt18.Focus()
        End If
    End Sub

    Private Sub txt18_KeyDown(sender As Object, e As KeyEventArgs) Handles txt18.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt19.Focus()
        End If
    End Sub

    Private Sub txt19_KeyDown(sender As Object, e As KeyEventArgs) Handles txt19.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt20.Focus()
        End If
    End Sub

    Private Sub txt20_KeyDown(sender As Object, e As KeyEventArgs) Handles txt20.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt21.Focus()
        End If
    End Sub

    Private Sub txt21_KeyDown(sender As Object, e As KeyEventArgs) Handles txt21.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt22.Focus()
        End If
    End Sub

    Private Sub txt22_KeyDown(sender As Object, e As KeyEventArgs) Handles txt22.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt23.Focus()
        End If
    End Sub

    Private Sub txt23_KeyDown(sender As Object, e As KeyEventArgs) Handles txt23.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt24.Focus()
        End If
    End Sub

    Private Sub txt24_KeyDown(sender As Object, e As KeyEventArgs) Handles txt24.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt25.Focus()
        End If
    End Sub

    Private Sub txt25_KeyDown(sender As Object, e As KeyEventArgs) Handles txt25.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt26.Focus()
        End If
    End Sub

    Private Sub txt26_KeyDown(sender As Object, e As KeyEventArgs) Handles txt26.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt27.Focus()
        End If
    End Sub

    Private Sub txt27_KeyDown(sender As Object, e As KeyEventArgs) Handles txt27.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt28.Focus()
        End If
    End Sub

    Private Sub num1_KeyDown(sender As Object, e As KeyEventArgs) Handles num1.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num2.Focus()
        End If
    End Sub

    Private Sub num2_KeyDown(sender As Object, e As KeyEventArgs) Handles num2.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num3.Focus()
        End If
    End Sub

    Private Sub num3_KeyDown(sender As Object, e As KeyEventArgs) Handles num3.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num4.Focus()
        End If
    End Sub

    Private Sub num4_KeyDown(sender As Object, e As KeyEventArgs) Handles num4.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num5.Focus()
        End If
    End Sub

    Private Sub num5_KeyDown(sender As Object, e As KeyEventArgs) Handles num5.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num6.Focus()
        End If
    End Sub

    Private Sub num6_KeyDown(sender As Object, e As KeyEventArgs) Handles num6.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num7.Focus()
        End If
    End Sub

    Private Sub num7_KeyDown(sender As Object, e As KeyEventArgs) Handles num7.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num8.Focus()
        End If
    End Sub

    Private Sub num8_KeyDown(sender As Object, e As KeyEventArgs) Handles num8.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num9.Focus()
        End If
    End Sub

    Private Sub num9_KeyDown(sender As Object, e As KeyEventArgs) Handles num9.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num10.Focus()
        End If
    End Sub

    Private Sub num10_KeyDown(sender As Object, e As KeyEventArgs) Handles num10.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num11.Focus()
        End If
    End Sub

    Private Sub num11_KeyDown(sender As Object, e As KeyEventArgs) Handles num11.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num12.Focus()
        End If
    End Sub

    Private Sub num12_KeyDown(sender As Object, e As KeyEventArgs) Handles num12.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            num13.Focus()
        End If
    End Sub

    Private Sub num13_KeyDown(sender As Object, e As KeyEventArgs) Handles num13.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt4.Focus()
        End If
    End Sub

    Private Sub txt28_KeyDown(sender As Object, e As KeyEventArgs) 
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt29.Focus()
        End If
    End Sub

    Private Sub txt29_KeyDown(sender As Object, e As KeyEventArgs) Handles txt29.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt32.Focus()
        End If
    End Sub

    Private Sub txt32_KeyDown(sender As Object, e As KeyEventArgs) Handles txt32.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtcant1.Focus()
        End If
    End Sub

    Private Sub txtcant1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcant1.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtubi1.Focus()
        End If
    End Sub

    Private Sub txtubi1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtubi1.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtpreci1.Focus()
        End If
    End Sub

    Private Sub txtpreci1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpreci1.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtcant2.Focus()
        End If
    End Sub

    Private Sub txtcant2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcant2.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtubi2.Focus()
        End If
    End Sub

    Private Sub txtubi2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtubi2.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtpreci2.Focus()
        End If
    End Sub

    Private Sub txtpreci2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpreci2.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtcant3.Focus()
        End If
    End Sub

    Private Sub txtcant3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcant3.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtubi3.Focus()
        End If
    End Sub

    Private Sub txtubi3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtubi3.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtpreci3.Focus()
        End If
    End Sub

    Private Sub txtpreci3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpreci3.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtcant4.Focus()
        End If
    End Sub

    Private Sub txtcant4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcant4.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtubi4.Focus()
        End If
    End Sub

    Private Sub txtubi4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtubi4.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtpreci4.Focus()
        End If
    End Sub

    Private Sub txtpreci4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpreci4.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtcant5.Focus()
        End If
    End Sub

    Private Sub txtcant5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcant5.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtubi5.Focus()
        End If
    End Sub

    Private Sub txtubi5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtubi5.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtpreci5.Focus()
        End If
    End Sub

    Private Sub txtpreci5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpreci5.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtcant6.Focus()
        End If
    End Sub

    Private Sub txtcant6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcant6.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtubi6.Focus()
        End If
    End Sub

    Private Sub txtubi6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtubi6.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtpreci6.Focus()
        End If
    End Sub

    Private Sub txtpreci6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpreci6.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtcant7.Focus()
        End If
    End Sub

    Private Sub txtcant7_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcant7.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtubi7.Focus()
        End If
    End Sub

    Private Sub txtubi7_KeyDown(sender As Object, e As KeyEventArgs) Handles txtubi7.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtpreci7.Focus()
        End If
    End Sub

    Private Sub txtpreci7_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpreci7.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtcant8.Focus()
        End If
    End Sub

    Private Sub txtcant8_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcant8.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtubi8.Focus()
        End If
    End Sub

    Private Sub txtubi8_KeyDown(sender As Object, e As KeyEventArgs) Handles txtubi8.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtpreci8.Focus()
        End If
    End Sub

    Private Sub txtpreci8_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpreci8.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtcant9.Focus()
        End If
    End Sub

    Private Sub txtcant9_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcant9.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtubi9.Focus()
        End If
    End Sub

    Private Sub txtubi9_KeyDown(sender As Object, e As KeyEventArgs) Handles txtubi9.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtpreci9.Focus()
        End If
    End Sub

    Private Sub txtpreci9_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpreci9.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtcant10.Focus()
        End If
    End Sub

    Private Sub txtcant10_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcant10.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtubi10.Focus()
        End If
    End Sub

    Private Sub txtubi10_KeyDown(sender As Object, e As KeyEventArgs) Handles txtubi10.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtpreci10.Focus()
        End If
    End Sub

    Private Sub txtpreci10_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpreci10.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt39.Focus()
        End If
    End Sub

    Private Sub txt39_KeyDown(sender As Object, e As KeyEventArgs) Handles txt39.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txt35.Focus()
        End If
    End Sub

    Private Sub txt35_KeyDown(sender As Object, e As KeyEventArgs) Handles txt35.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            btntiemerpaga1.Focus()
        End If
    End Sub

    Private Sub btntiemerpaga1_KeyDown(sender As Object, e As KeyEventArgs) Handles btntiemerpaga1.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            Button1.Focus()
        End If
    End Sub

    Private Sub txt17_TextChanged(sender As Object, e As EventArgs) Handles txt17.TextChanged
        txtdireccionpaga.Text = txt17.Text
    End Sub


#End Region

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        btn1.Checked = False
        btn2.Checked = False
        btn3.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt5.Text = ""
        txt4.Text = ""
        txt6.Text = ""
        txt7.Text = ""
        txt8.Text = ""
        txt10.Text = ""
        txt11.Text = ""
        txt12.Text = ""
        txt13.Text = ""
        txt15.Text = ""
        txt14.Text = ""
        txt17.Text = ""
        txt16.Text = ""
        txt18.Text = ""
        txt19.Text = ""
        txt20.Text = ""
        txt21.Text = ""
        txt22.Text = ""
        txt23.Text = ""
        txt24.Text = ""
        txt25.Text = ""
        txt26.Text = ""
        txt27.Text = ""
        num1.Text = ""
        num2.Text = ""
        num3.Text = ""
        num4.Text = ""
        num5.Text = ""
        num6.Text = ""
        num7.Text = ""
        num8.Text = ""
        num9.Text = ""
        num10.Text = ""
        num11.Text = ""
        num12.Text = ""
        num13.Text = ""
        txt28.Text = ""
        txt29.Text = ""
        txt30.Text = ""
        txt31.Text = ""
        txt32.Text = ""
        txtpaga1.Text = ""

        txtcant1.Text = ""
        txtcombo1.Text = ""
        txtubi1.Text = ""
        txtpreci1.Text = ""

        txtcant2.Text = ""
        txtcombo2.Text = ""
        txtubi2.Text = ""
        txtpreci2.Text = ""

        txtcant3.Text = ""
        txtcombo3.Text = ""
        txtubi3.Text = ""
        txtpreci3.Text = ""

        txtcant4.Text = ""
        txtcombo4.Text = ""
        txtubi4.Text = ""
        txtpreci4.Text = ""

        txtcant5.Text = ""
        txtcombo5.Text = ""
        txtubi5.Text = ""
        txtpreci5.Text = ""

        txtcant6.Text = ""
        txtcombo6.Text = ""
        txtubi6.Text = ""
        txtpreci6.Text = ""

        txtcant7.Text = ""
        txtcombo7.Text = ""
        txtubi7.Text = ""
        txtpreci7.Text = ""

        txtcant8.Text = ""
        txtcombo8.Text = ""
        txtubi8.Text = ""
        txtpreci8.Text = ""

        txtcant9.Text = ""
        txtcombo9.Text = ""
        txtubi9.Text = ""
        txtpreci9.Text = ""

        txtcant10.Text = ""
        txtcombo10.Text = ""
        txtubi10.Text = ""
        txtpreci10.Text = ""

        txt35.Text = ""
        txt39.Text = ""

        borrardatos()
    End Sub

    Private Sub txt15_TextChanged(sender As Object, e As EventArgs) Handles txt15.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        btn1.Checked = False
        btn2.Checked = False
        btn3.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox6.Checked = False
        CheckBox5.Checked = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt5.Text = ""
        txt4.Text = ""
        txt6.Text = ""
        txt7.Text = ""
        txt8.Text = ""
        txt10.Text = ""
        txt11.Text = ""
        txt12.Text = ""
        txt13.Text = ""
        txt15.Text = ""
        txt14.Text = ""
        txt17.Text = ""
        txt16.Text = ""
        txt18.Text = ""
        txt19.Text = ""
        num1.Text = ""
        num2.Text = ""
        num3.Text = ""
        num4.Text = ""
        num5.Text = ""
        num6.Text = ""
        num7.Text = ""
        num8.Text = ""
        num9.Text = ""
        num10.Text = ""
        num11.Text = ""
        num12.Text = ""
        num13.Text = ""
        txt28.Text = ""
        txt29.Text = ""
        txt30.Text = ""
        txt31.Text = ""
        txt32.Text = ""
        txtpaga1.Text = ""

        txtcant1.Text = ""
        txtcombo1.Text = ""
        txtubi1.Text = ""
        txtpreci1.Text = ""

        txtcant2.Text = ""
        txtcombo2.Text = ""
        txtubi2.Text = ""
        txtpreci2.Text = ""

        txtcant3.Text = ""
        txtcombo3.Text = ""
        txtubi3.Text = ""
        txtpreci3.Text = ""

        txtcant4.Text = ""
        txtcombo4.Text = ""
        txtubi4.Text = ""
        txtpreci4.Text = ""

        txtcant5.Text = ""
        txtcombo5.Text = ""
        txtubi5.Text = ""
        txtpreci5.Text = ""

        txtcant6.Text = ""
        txtcombo6.Text = ""
        txtubi6.Text = ""
        txtpreci6.Text = ""

        txtcant7.Text = ""
        txtcombo7.Text = ""
        txtubi7.Text = ""
        txtpreci7.Text = ""

        txtcant8.Text = ""
        txtcombo8.Text = ""
        txtubi8.Text = ""
        txtpreci8.Text = ""

        txtcant9.Text = ""
        txtcombo9.Text = ""
        txtubi9.Text = ""
        txtpreci9.Text = ""

        txtcant10.Text = ""
        txtcombo10.Text = ""
        txtubi10.Text = ""
        txtpreci10.Text = ""

        txt35.Text = ""
        txt39.Text = ""

        borrardatos()
    End Sub

    Private Sub ivachecker_CheckedChanged(sender As Object, e As EventArgs) Handles ivachecker.CheckedChanged
        If ivachecker.Checked = True Then
            auxiva1.Enabled = True
        Else
            Try
                auxiva1.Text = Round((CDbl(txtsubtotal2.Text.Replace("$", "")) * 0.16), 2)
                auxiva1.Text = "$" & auxiva1.Text
            Catch ex As Exception
                auxiva1.Text = "$0.00"
            End Try
            auxiva1.Enabled = False
        End If
    End Sub

    Private Sub txt16_TextChanged(sender As Object, e As EventArgs) Handles txt16.TextChanged
        txttelpaga.Text = txt16.Text
    End Sub

    Private Sub txtpreci1_Enter(sender As Object, e As EventArgs) Handles txtpreci1.Enter
        If txtpreci1.Text = "" Then
        Else
            txtpreci1.Text = txtpreci1.Text.Replace("$", "")
            txtpreci1.Text = txtpreci1.Text.Replace(",", "")
            txtpreci1.SelectAll()
        End If
    End Sub

    Private Sub txtpreci1_Leave(sender As Object, e As EventArgs) Handles txtpreci1.Leave
        If txtpreci1.Text = "" Then
        Else
            txtpreci1.Text = moneda.transform(txtpreci1.Text)
        End If

    End Sub

    Private Sub txtpreci2_Enter(sender As Object, e As EventArgs) Handles txtpreci2.Enter
        If txtpreci2.Text = "" Then
        Else
            txtpreci2.Text = txtpreci2.Text.Replace("$", "")
            txtpreci2.Text = txtpreci2.Text.Replace(",", "")
            txtpreci2.SelectAll()
        End If
    End Sub

    Private Sub txtpreci2_Leave(sender As Object, e As EventArgs) Handles txtpreci2.Leave
        If txtpreci2.Text = "" Then
        Else
            txtpreci2.Text = moneda.transform(txtpreci2.Text)
        End If
    End Sub

    Private Sub txtpreci3_Enter(sender As Object, e As EventArgs) Handles txtpreci3.Enter
        If txtpreci3.Text = "" Then
        Else
            txtpreci3.Text = txtpreci3.Text.Replace("$", "")
            txtpreci3.Text = txtpreci3.Text.Replace(",", "")
            txtpreci3.SelectAll()
        End If
    End Sub

    Private Sub txtpreci3_Leave(sender As Object, e As EventArgs) Handles txtpreci3.Leave
        If txtpreci3.Text = "" Then
        Else
            txtpreci3.Text = moneda.transform(txtpreci3.Text)
        End If
    End Sub

    Private Sub txtpreci4_Enter(sender As Object, e As EventArgs) Handles txtpreci4.Enter
        If txtpreci4.Text = "" Then
        Else
            txtpreci4.Text = txtpreci4.Text.Replace("$", "")
            txtpreci4.Text = txtpreci4.Text.Replace(",", "")
            txtpreci4.SelectAll()
        End If
    End Sub

    Private Sub txtpreci4_Leave(sender As Object, e As EventArgs) Handles txtpreci4.Leave
        If txtpreci4.Text = "" Then
        Else
            txtpreci4.Text = moneda.transform(txtpreci4.Text)
        End If
    End Sub

    Private Sub txtpreci5_Enter(sender As Object, e As EventArgs) Handles txtpreci5.Enter
        If txtpreci5.Text = "" Then
        Else
            txtpreci5.Text = txtpreci5.Text.Replace("$", "")
            txtpreci5.Text = txtpreci5.Text.Replace(",", "")
            txtpreci5.SelectAll()
        End If
    End Sub

    Private Sub txtpreci5_Leave(sender As Object, e As EventArgs) Handles txtpreci5.Leave
        If txtpreci5.Text = "" Then
        Else
            txtpreci5.Text = moneda.transform(txtpreci5.Text)
        End If
    End Sub

    Private Sub txtpreci6_Enter(sender As Object, e As EventArgs) Handles txtpreci6.Enter
        If txtpreci6.Text = "" Then
        Else
            txtpreci6.Text = txtpreci6.Text.Replace("$", "")
            txtpreci6.Text = txtpreci6.Text.Replace(",", "")
            txtpreci6.SelectAll()
        End If
    End Sub

    Private Sub txtpreci6_Leave(sender As Object, e As EventArgs) Handles txtpreci6.Leave
        If txtpreci6.Text = "" Then
        Else
            txtpreci6.Text = moneda.transform(txtpreci6.Text)
        End If
    End Sub

    Private Sub txtpreci7_Enter(sender As Object, e As EventArgs) Handles txtpreci7.Enter
        If txtpreci7.Text = "" Then
        Else
            txtpreci7.Text = txtpreci7.Text.Replace("$", "")
            txtpreci7.Text = txtpreci7.Text.Replace(",", "")
            txtpreci7.SelectAll()
        End If
    End Sub

    Private Sub txtpreci7_Leave(sender As Object, e As EventArgs) Handles txtpreci7.Leave
        If txtpreci7.Text = "" Then
        Else
            txtpreci7.Text = moneda.transform(txtpreci7.Text)
        End If
    End Sub

    Private Sub txtpreci8_Enter(sender As Object, e As EventArgs) Handles txtpreci8.Enter
        If txtpreci8.Text = "" Then
        Else
            txtpreci8.Text = txtpreci8.Text.Replace("$", "")
            txtpreci8.Text = txtpreci8.Text.Replace(",", "")
            txtpreci8.SelectAll()
        End If
    End Sub

    Private Sub txtpreci8_Leave(sender As Object, e As EventArgs) Handles txtpreci8.Leave
        If txtpreci8.Text = "" Then
        Else
            txtpreci8.Text = moneda.transform(txtpreci8.Text)
        End If
    End Sub

    Private Sub txtpreci9_Enter(sender As Object, e As EventArgs) Handles txtpreci9.Enter
        If txtpreci9.Text = "" Then
        Else
            txtpreci9.Text = txtpreci9.Text.Replace("$", "")
            txtpreci9.Text = txtpreci9.Text.Replace(",", "")
            txtpreci9.SelectAll()
        End If
    End Sub

    Private Sub txtpreci9_Leave(sender As Object, e As EventArgs) Handles txtpreci9.Leave
        If txtpreci9.Text = "" Then
        Else
            txtpreci9.Text = moneda.transform(txtpreci9.Text)
        End If
    End Sub

    Private Sub txtpreci10_Enter(sender As Object, e As EventArgs) Handles txtpreci10.Enter
        If txtpreci10.Text = "" Then
        Else
            txtpreci10.Text = txtpreci10.Text.Replace("$", "")
            txtpreci10.Text = txtpreci10.Text.Replace(",", "")
            txtpreci10.SelectAll()
        End If
    End Sub

    Private Sub txtpreci10_Leave(sender As Object, e As EventArgs) Handles txtpreci10.Leave
        If txtpreci10.Text = "" Then
        Else
            txtpreci10.Text = moneda.transform(txtpreci10.Text)
        End If
    End Sub

    Private Sub txt35_Enter(sender As Object, e As EventArgs) Handles txt35.Enter
        If txt35.Text = "" Then
        Else
            txt35.Text = txt35.Text.Replace("$", "")
            txt35.Text = txt35.Text.Replace(",", "")
            txt35.SelectAll()
        End If
    End Sub

    Private Sub txt35_Leave(sender As Object, e As EventArgs) Handles txt35.Leave
        If txt35.Text = "" Then
        Else
            txt35.Text = moneda.transform(txt35.Text)
        End If
    End Sub

    Private Sub auxiva1_Enter(sender As Object, e As EventArgs) Handles auxiva1.Enter
        If auxiva1.Text = "" Then
        Else
            auxiva1.Text = auxiva1.Text.Replace("$", "")
            auxiva1.Text = auxiva1.Text.Replace(",", "")
            auxiva1.SelectAll()
        End If
    End Sub

    Private Sub auxiva1_Leave(sender As Object, e As EventArgs) Handles auxiva1.Leave
        If auxiva1.Text = "" Then
            auxiva1.Text = "$0"
        Else
            auxiva1.Text = moneda.transform(auxiva1.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txt12.Text = txt1.Text
        txt14.Text = txt10.Text
        txt17.Text = txt4.Text
        txt18.Text = txt7.Text
        txt19.Text = txt8.Text
    End Sub

    Private Sub Label67_Click(sender As Object, e As EventArgs) Handles Label67.Click

    End Sub
End Class