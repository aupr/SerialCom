Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel

Public Class Form1
    Dim auto As Integer
    Dim myPort As Array
    Dim data As Integer
    Dim input_ext_data_val As Integer
    Delegate Sub setTextCallBack(ByVal [text] As String)

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
        My.Settings.BaudRate = Me.baudComboBox.SelectedIndex
        My.Settings.CB_ext_enter = CheckBoxExtEnter.Checked
        My.Settings.CB_ext_spcl = CheckBoxExtSpecial.Checked
        My.Settings.TX_ext_spcl = TextBoxExtData.Text
        'MessageBox.Show("this is only message")
        'MessageBox.Show("this is message", "This is caption", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        portComboBox.Items.AddRange(myPort)
        baudComboBox.Items.AddRange({110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200})
        If myPort.Length Then
            Me.portComboBox.SelectedIndex = 0
        End If
        Me.baudComboBox.SelectedIndex = My.Settings.BaudRate
        Me.CheckBoxExtEnter.Checked = My.Settings.CB_ext_enter
        Me.CheckBoxExtSpecial.Checked = My.Settings.CB_ext_spcl
        Me.TextBoxExtData.Text = My.Settings.TX_ext_spcl
        Me.input_ext_data_val = BinaryToLong(HexToBin(TextBoxExtData.Text))
        GroupBox1.Enabled = False
        Me.portComboBox.Text = "Select"
    End Sub

    Private Sub get_new_port_Click(sender As Object, e As EventArgs) Handles get_new_port.Click
        portComboBox.Items.Clear()
        myPort = IO.Ports.SerialPort.GetPortNames()
        portComboBox.Items.AddRange(myPort)
        initButton.Enabled = False
        initButton.BackColor = Color.FromArgb(255, 192, 192)
    End Sub

    Private Sub initButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles initButton.Click
        If initButton.Text = "Connect" Then
            SerialPort1.PortName = portComboBox.Text
            SerialPort1.BaudRate = baudComboBox.Text
            Try
                SerialPort1.Open()
            Catch ex As Exception
                MessageBox.Show("This port is failed to connect. Probably busy or configuration error,", "Port Connection message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            If SerialPort1.IsOpen Then
                'SerialPort1.Open()
                GroupBox1.Enabled = True
                portComboBox.Enabled = False
                baudComboBox.Enabled = False
                get_new_port.Enabled = False
                initButton.Text = "Disconnect"
                initButton.BackColor = Color.FromArgb(255, 255, 192)
            End If
        Else
            SerialPort1.Close()
            GroupBox1.Enabled = False
            portComboBox.Enabled = True
            baudComboBox.Enabled = True
            get_new_port.Enabled = True
            'inputTextBox.Text = ""
            initButton.Text = "Connect"
            initButton.BackColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())
    End Sub
    Private Sub ReceivedText(ByVal [text] As String)
        If Me.outputTextBox.InvokeRequired Then
            Dim x As New setTextCallBack(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.outputTextBox.Text &= [text]
        End If
    End Sub

    Private Sub writeButton_Click(sender As Object, e As EventArgs) Handles writeButton.Click
        'Dim ext_data_8bit As Integer
        SerialPort1.Write(inputTextBox.Text)
        If CheckBoxExtEnter.Checked Then
            SerialPort1.Write(vbCr)
        ElseIf CheckBoxExtSpecial.Checked Then
            If TextBoxExtData.Text.Length Then
                'ext_data_8bit = Integer.Parse(TextBoxExtData.Text)
                SerialPort1.Write(New Byte() {input_ext_data_val}, 0, 1)
            End If
        End If
    End Sub

    Private Sub inputTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputTextBox.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            SerialPort1.Write(inputTextBox.Text)
            If CheckBoxExtEnter.Checked Then
                SerialPort1.Write(vbCr)
            ElseIf CheckBoxExtSpecial.Checked Then
                If TextBoxExtData.Text.Length Then
                    SerialPort1.Write(New Byte() {input_ext_data_val}, 0, 1)
                End If
            End If
        End If
    End Sub

    Private Sub outputTextBox_TextChanged(sender As Object, e As EventArgs) Handles outputTextBox.TextChanged
        outputTextBox.SelectionStart = outputTextBox.TextLength
        outputTextBox.ScrollToCaret()
    End Sub

    Private Sub Buttonh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonh.Click
        outputTextBox.Text = ""
    End Sub

    Private Sub inputTextBox_TextChanged(sender As Object, e As EventArgs) Handles inputTextBox.TextChanged
        If auto = 1 Then
            SerialPort1.Write(inputTextBox.Text)
            inputTextBox.Text = ""
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            auto = 1
            writeButton.Enabled = False
        Else
            auto = 0
            writeButton.Enabled = True
        End If
    End Sub

    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        SerialPort1.Write(vbCr)
    End Sub

    Private Sub portComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles portComboBox.SelectedIndexChanged
        If baudComboBox.CanSelect Then
            initButton.Enabled = True
            initButton.BackColor = Color.FromArgb(192, 255, 192)
        Else
            writeButton.Enabled = False
            initButton.BackColor = Color.FromArgb(255, 192, 192)
        End If
    End Sub

    ' Convert this binary value into a Long.
    Private Function BinaryToLong(ByVal binary_value As String) _
 _
        As Long
        ' Remove any leading &B if present.
        ' (Note: &B is not a standard prefix, it just
        ' makes some sense.)
        binary_value = binary_value.Trim().ToUpper()
        If binary_value.StartsWith("&B") Then binary_value = _
            binary_value.Substring(2)

        ' Strip out spaces in case the bytes are separated
        ' by spaces.
        binary_value = binary_value.Replace(" ", "")

        ' Left pad with zeros so we have a full 64 bits.
        binary_value = binary_value.PadLeft(64, "0")

        ' Read the bits in nibbles from left to right.
        ' (A nibble is half a byte. No kidding!)
        Dim hex_result As String = ""
        For nibble_num As Integer = 0 To 15
            ' Convert this nibble into a hexadecimal string.
            Dim factor As Integer = 1
            Dim nibble_value As Integer = 0

            ' Read the nibble's bits from right to left.
            For bit As Integer = 3 To 0 Step -1
                If binary_value.Substring(nibble_num * 4 + bit, _
 _
                    1).Equals("1") Then
                    nibble_value += factor
                End If
                factor *= 2
            Next bit

            ' Add the nibble's value to the right of the
            ' result hex string.
            hex_result &= nibble_value.ToString("X")
        Next nibble_num

        ' Convert the result string into a long.
        Return Long.Parse(hex_result, _
            Globalization.NumberStyles.HexNumber)
    End Function

    ' Convert this Long value into a binary string.
    ' See also
    ' http://www.vb-helper.com/howto_net_dec_hex_oct_bin.html.
    ' This version of LongToBinary does not add a "&B" in the
    ' front.
    Private Function LongToBinary(ByVal long_value As Long, _
        Optional ByVal separate_bytes As Boolean = True) As _
        String
        ' Convert into hex.
        Dim hex_string As String = long_value.ToString("X")

        ' Zero-pad to a full 16 characters.
        hex_string = hex_string.PadLeft(2, "0")

        ' Read the hexadecimal digits
        ' one at a time from right to left.
        Dim result_string As String = ""
        For digit_num As Integer = 0 To 1
            ' Convert this hexadecimal digit into a
            ' binary nibble.
            Dim digit_value As Integer = Integer.Parse(hex_string.Substring(digit_num, 1), Globalization.NumberStyles.HexNumber)

            ' Convert the value into bits.
            Dim factor As Integer = 8
            Dim nibble_string As String = ""
            For bit As Integer = 0 To 3
                If digit_value And factor Then
                    nibble_string &= "1"
                Else
                    nibble_string &= "0"
                End If
                factor \= 2
            Next bit

            ' Add the nibble's string to the left of the
            ' result string.
            result_string &= nibble_string
        Next digit_num
        ' Add spaces between bytes if desired.
        If separate_bytes Then
            Dim tmp As String = ""
            For i As Integer = 0 To result_string.Length - 8 _
                Step 8
                tmp &= result_string.Substring(i, 8) & " "
            Next i
            result_string = tmp.Substring(0, tmp.Length - 1)
        End If

        ' Return the result.
        Return result_string
    End Function

    Private Function LongToHex(ByVal long_value As Long, _
    Optional ByVal separate_bytes As Boolean = True) As _
    String
        ' Convert into hex.
        Dim hex_string As String = long_value.ToString("X")

        ' Zero-pad to a full 16 characters.
        hex_string = hex_string.PadLeft(2, "0")

        Return hex_string
    End Function

    Private Function HexToBin(ByVal hex_string As String, _
 Optional ByVal separate_bytes As Boolean = True) As _
 String
        hex_string = hex_string.PadLeft(2, "0")

        ' Read the hexadecimal digits
        ' one at a time from right to left.
        Dim result_string As String = ""
        For digit_num As Integer = 0 To 1
            ' Convert this hexadecimal digit into a
            ' binary nibble.
            Dim digit_value As Integer = Integer.Parse(hex_string.Substring(digit_num, 1), Globalization.NumberStyles.HexNumber)

            ' Convert the value into bits.
            Dim factor As Integer = 8
            Dim nibble_string As String = ""
            For bit As Integer = 0 To 3
                If digit_value And factor Then
                    nibble_string &= "1"
                Else
                    nibble_string &= "0"
                End If
                factor \= 2
            Next bit

            ' Add the nibble's string to the left of the
            ' result string.
            result_string &= nibble_string
        Next digit_num
        ' Add spaces between bytes if desired.
        If separate_bytes Then
            Dim tmp As String = ""
            For i As Integer = 0 To result_string.Length - 8 _
                Step 8
                tmp &= result_string.Substring(i, 8) & " "
            Next i
            result_string = tmp.Substring(0, tmp.Length - 1)
        End If

        ' Return the result.
        Return result_string
    End Function

    Private Sub txtDec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDec.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number", "Input rules", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtDec_TextChanged(sender As Object, e As EventArgs) Handles txtDec.TextChanged
        Dim dec_val As Long
        If txtDec.TextLength And txtDec.Focused Then
            dec_val = txtDec.Text
            If dec_val <= 255 Then
                txtBinary.Text = LongToBinary(dec_val)
                txtHex.Text = LongToHex(dec_val)
                txtChar.Text = Chr(dec_val)
            Else
                MessageBox.Show("Maximum input value 255", "Input rules", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDec.Text = txtDec.Text.Substring(0, txtDec.Text.Length - 1)
                'txtDec.Cursor.
            End If
            
        ElseIf txtDec.Focused Then
            'dec_val = 0
            txtBinary.Text = ""
            txtHex.Text = ""
            txtChar.Text = ""
        End If
    End Sub

    Private Sub txtBinary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBinary.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 49 Then
            e.Handled = True
            MessageBox.Show("You can only input 0 and 1", "Input rules", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtBinary_TextChanged(sender As Object, e As EventArgs) Handles txtBinary.TextChanged
        Dim bin As String
        If txtBinary.TextLength And txtBinary.Focused Then
            bin = txtBinary.Text
            txtDec.Text = BinaryToLong(bin)
            txtHex.Text = LongToHex(txtDec.Text)
            txtChar.Text = Chr(BinaryToLong(bin))
        ElseIf txtBinary.Focused Then
            txtDec.Text = ""
            txtHex.Text = ""
            txtChar.Text = ""
        End If
    End Sub

    Private Sub txtHex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHex.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 70 Then
                If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 102 Then
                    e.Handled = True
                    MessageBox.Show("You can only input hexadecimal character", "Input rules", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub txtHex_TextChanged(sender As Object, e As EventArgs) Handles txtHex.TextChanged
        Dim Hex_val As String
        If txtHex.TextLength And txtHex.Focused Then
            Hex_val = txtHex.Text
            txtBinary.Text = HexToBin(Hex_val)
            txtDec.Text = BinaryToLong(txtBinary.Text)
            txtChar.Text = Chr(BinaryToLong(txtBinary.Text))
        ElseIf txtHex.Focused Then
            txtBinary.Text = ""
            txtDec.Text = ""
            txtChar.Text = ""
        End If
    End Sub

    Private Sub txtChar_TextChanged(sender As Object, e As EventArgs) Handles txtChar.TextChanged
        Dim Char_val As Integer
        If txtChar.Text.Length And txtChar.Focused Then
            Char_val = Asc(txtChar.Text)
            txtDec.Text = Char_val
            txtBinary.Text = LongToBinary(Char_val)
            txtHex.Text = LongToHex(Char_val)
        ElseIf txtChar.Focused Then
            txtHex.Text = ""
            txtBinary.Text = ""
            txtDec.Text = ""
        End If
    End Sub

    Private Sub SendBin_Click(sender As Object, e As EventArgs) Handles SendBin.Click
        Dim dec_data_8bit As Integer

        If txtDec.Text.Length Then
            dec_data_8bit = Integer.Parse(txtDec.Text)
            SerialPort1.Write(New Byte() {dec_data_8bit}, 0, 1)
        End If
    End Sub

    Private Sub CheckBoxExtEnter_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxExtEnter.CheckedChanged
        If CheckBoxExtEnter.Checked Then
            CheckBoxExtSpecial.Checked = False
        End If
    End Sub

    Private Sub CheckBoxExtSpecial_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxExtSpecial.CheckedChanged
        If CheckBoxExtSpecial.Checked Then
            CheckBoxExtEnter.Checked = False
        End If
    End Sub

    Private Sub TextBoxExtData_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxExtData.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 70 Then
                If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 102 Then
                    e.Handled = True
                    MessageBox.Show("You can only input hexadecimal character", "Input rules", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub TextBoxExtData_TextChanged(sender As Object, e As EventArgs) Handles TextBoxExtData.TextChanged
        If TextBoxExtData.TextLength And TextBoxExtData.Focused Then
            input_ext_data_val = BinaryToLong(HexToBin(TextBoxExtData.Text))
        ElseIf TextBoxExtData.Focused Then
            input_ext_data_val = 0
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.facebook.com/amanullah.snet")
    End Sub

End Class
