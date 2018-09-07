
Imports System
Imports System.IO
Imports System.Text

Public Class GUI
    Dim key(26) As Integer
    Dim keys As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPath.Text = My.Computer.FileSystem.SpecialDirectories.Desktop + "\keys.txt"
        pbxVLine1.Image = My.Resources.line_vertical
        pbxVLine2.Image = My.Resources.line_vertical
        pbxHLine1.Image = My.Resources.line_horizontal
        pbxHLine2.Image = My.Resources.line_horizontal
        pbxVLine1.Show()
        pbxVLine2.Show()
        pbxHLine1.Show()
        pbxHLine2.Show()
    End Sub

    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click

        For i As Integer = 0 To 26 Step 1
            key(i) = 0
        Next

        If b0O.Checked = True Then key(0) = 1
        If b1O.Checked = True Then key(1) = 1
        If b2O.Checked = True Then key(2) = 1
        If b3O.Checked = True Then key(3) = 1
        If b4O.Checked = True Then key(4) = 1
        If b5O.Checked = True Then key(5) = 1
        If b6O.Checked = True Then key(6) = 1
        If b7O.Checked = True Then key(7) = 1
        If b8O.Checked = True Then key(8) = 1

        If b0X.Checked = True Then key(9) = 1
        If b1X.Checked = True Then key(10) = 1
        If b2X.Checked = True Then key(11) = 1
        If b3X.Checked = True Then key(12) = 1
        If b4X.Checked = True Then key(13) = 1
        If b5X.Checked = True Then key(14) = 1
        If b6X.Checked = True Then key(15) = 1
        If b7X.Checked = True Then key(16) = 1
        If b8X.Checked = True Then key(17) = 1

        If k0O.Checked = True Then key(18) = 1
        If k1O.Checked = True Then key(19) = 1
        If k2O.Checked = True Then key(20) = 1
        If k3O.Checked = True Then key(21) = 1
        If k4O.Checked = True Then key(22) = 1
        If k5O.Checked = True Then key(23) = 1
        If k6O.Checked = True Then key(24) = 1
        If k7O.Checked = True Then key(25) = 1
        If k8O.Checked = True Then key(26) = 1

        If k0X.Checked = True Then key(18) = 1
        If k1X.Checked = True Then key(19) = 1
        If k2X.Checked = True Then key(20) = 1
        If k3X.Checked = True Then key(21) = 1
        If k4X.Checked = True Then key(22) = 1
        If k5X.Checked = True Then key(23) = 1
        If k6X.Checked = True Then key(24) = 1
        If k7X.Checked = True Then key(25) = 1
        If k8X.Checked = True Then key(26) = 1

        Dim temp As String
        If rdb9In.Checked = True Then
            temp = (key(0) - key(9)) & (key(1) - key(10)) & (key(2) - key(11)) & (key(3) - key(12)) & (key(4) - key(13)) & (key(5) - key(14)) & (key(6) - key(15)) & (key(7) - key(16)) & (key(8) - key(17)) & " " & key(18) & key(19) & key(20) & key(21) & key(22) & key(23) & key(24) & key(25) & key(26)
            lstKeys.Items.Add(temp)
            keys = keys & temp & vbNewLine
        Else
            temp = key(0) & key(1) & key(2) & key(3) & key(4) & key(5) & key(6) & key(7) & key(8) & key(9) & key(10) & key(11) & key(12) & key(13) & key(14) & key(15) & key(16) & key(17) & " " & key(18) & key(19) & key(20) & key(21) & key(22) & key(23) & key(24) & key(25) & key(26)
            lstKeys.Items.Add(temp)
            keys = keys & temp & vbNewLine
        End If

        b0O.Checked = False
        b1O.Checked = False
        b2O.Checked = False
        b3O.Checked = False
        b4O.Checked = False
        b5O.Checked = False
        b6O.Checked = False
        b7O.Checked = False
        b8O.Checked = False

        b0X.Checked = False
        b1X.Checked = False
        b2X.Checked = False
        b3X.Checked = False
        b4X.Checked = False
        b5X.Checked = False
        b6X.Checked = False
        b7X.Checked = False
        b8X.Checked = False

        k0O.Checked = False
        k1O.Checked = False
        k2O.Checked = False
        k3O.Checked = False
        k4O.Checked = False
        k5O.Checked = False
        k6O.Checked = False
        k7O.Checked = False
        k8O.Checked = False

        k0X.Checked = False
        k1X.Checked = False
        k2X.Checked = False
        k3X.Checked = False
        k4X.Checked = False
        k5X.Checked = False
        k6X.Checked = False
        k7X.Checked = False
        k8X.Checked = False


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim path As String = txtPath.Text

        'Dim sw As New StreamWriter(path)
        'If Not File.Exists(path) Then
        'sw = File.CreateText(path)
        'End If
        'sw.Write(keys)

        Dim fw As StreamWriter
        Try
            fw = New StreamWriter(path, True)
            fw.Write(keys)
        Finally
            fw.Close()
        End Try

        keys = ""
        lstKeys.Items.Clear()

    End Sub

    Private Sub b0O_CheckedChanged(sender As Object, e As EventArgs) Handles b0O.CheckedChanged
        If b0O.Checked = True Then
            pbx0.Image = My.Resources.O_Board
            pbx0.Show()
        Else
            pbx0.Image = My.Resources.Empty_Board
            pbx0.Show()
        End If
    End Sub
    Private Sub b1O_CheckedChanged(sender As Object, e As EventArgs) Handles b1O.CheckedChanged
        If b1O.Checked = True Then
            pbx1.Image = My.Resources.O_Board
            pbx1.Show()
        Else
            pbx1.Image = My.Resources.Empty_Board
            pbx1.Show()
        End If
    End Sub
    Private Sub b2O_CheckedChanged(sender As Object, e As EventArgs) Handles b2O.CheckedChanged
        If b2O.Checked = True Then
            pbx2.Image = My.Resources.O_Board
            pbx2.Show()
        Else
            pbx2.Image = My.Resources.Empty_Board
            pbx2.Show()
        End If
    End Sub
    Private Sub b3O_CheckedChanged(sender As Object, e As EventArgs) Handles b3O.CheckedChanged
        If b3O.Checked = True Then
            pbx3.Image = My.Resources.O_Board
            pbx3.Show()
        Else
            pbx3.Image = My.Resources.Empty_Board
            pbx3.Show()
        End If
    End Sub
    Private Sub b4O_CheckedChanged(sender As Object, e As EventArgs) Handles b4O.CheckedChanged
        If b4O.Checked = True Then
            pbx4.Image = My.Resources.O_Board
            pbx4.Show()
        Else
            pbx4.Image = My.Resources.Empty_Board
            pbx4.Show()
        End If
    End Sub
    Private Sub b5O_CheckedChanged(sender As Object, e As EventArgs) Handles b5O.CheckedChanged
        If b5O.Checked = True Then
            pbx5.Image = My.Resources.O_Board
            pbx5.Show()
        Else
            pbx5.Image = My.Resources.Empty_Board
            pbx5.Show()
        End If
    End Sub
    Private Sub b6O_CheckedChanged(sender As Object, e As EventArgs) Handles b6O.CheckedChanged
        If b6O.Checked = True Then
            pbx6.Image = My.Resources.O_Board
            pbx6.Show()
        Else
            pbx6.Image = My.Resources.Empty_Board
            pbx6.Show()
        End If
    End Sub
    Private Sub b7O_CheckedChanged(sender As Object, e As EventArgs) Handles b7O.CheckedChanged
        If b7O.Checked = True Then
            pbx7.Image = My.Resources.O_Board
            pbx7.Show()
        Else
            pbx7.Image = My.Resources.Empty_Board
            pbx7.Show()
        End If
    End Sub
    Private Sub b8O_CheckedChanged(sender As Object, e As EventArgs) Handles b8O.CheckedChanged
        If b8O.Checked = True Then
            pbx8.Image = My.Resources.O_Board
            pbx8.Show()
        Else
            pbx8.Image = My.Resources.Empty_Board
            pbx8.Show()
        End If
    End Sub
    Private Sub b0X_CheckedChanged(sender As Object, e As EventArgs) Handles b0X.CheckedChanged
        If b0X.Checked = True Then
            pbx0.Image = My.Resources.X_Board
            pbx0.Show()
        Else
            pbx0.Image = My.Resources.Empty_Board
            pbx0.Show()
        End If
    End Sub
    Private Sub b1X_CheckedChanged(sender As Object, e As EventArgs) Handles b1X.CheckedChanged
        If b1X.Checked = True Then
            pbx1.Image = My.Resources.X_Board
            pbx1.Show()
        Else
            pbx1.Image = My.Resources.Empty_Board
            pbx1.Show()
        End If
    End Sub
    Private Sub b2X_CheckedChanged(sender As Object, e As EventArgs) Handles b2X.CheckedChanged
        If b2X.Checked = True Then
            pbx2.Image = My.Resources.X_Board
            pbx2.Show()
        Else
            pbx2.Image = My.Resources.Empty_Board
            pbx2.Show()
        End If
    End Sub
    Private Sub b3X_CheckedChanged(sender As Object, e As EventArgs) Handles b3X.CheckedChanged
        If b3X.Checked = True Then
            pbx3.Image = My.Resources.X_Board
            pbx3.Show()
        Else
            pbx3.Image = My.Resources.Empty_Board
            pbx3.Show()
        End If
    End Sub
    Private Sub b4X_CheckedChanged(sender As Object, e As EventArgs) Handles b4X.CheckedChanged
        If b4X.Checked = True Then
            pbx4.Image = My.Resources.X_Board
            pbx4.Show()
        Else
            pbx4.Image = My.Resources.Empty_Board
            pbx4.Show()
        End If
    End Sub
    Private Sub b5X_CheckedChanged(sender As Object, e As EventArgs) Handles b5X.CheckedChanged
        If b5X.Checked = True Then
            pbx5.Image = My.Resources.X_Board
            pbx5.Show()
        Else
            pbx5.Image = My.Resources.Empty_Board
            pbx5.Show()
        End If
    End Sub
    Private Sub b6X_CheckedChanged(sender As Object, e As EventArgs) Handles b6X.CheckedChanged
        If b6X.Checked = True Then
            pbx6.Image = My.Resources.X_Board
            pbx6.Show()
        Else
            pbx6.Image = My.Resources.Empty_Board
            pbx6.Show()
        End If
    End Sub
    Private Sub b7X_CheckedChanged(sender As Object, e As EventArgs) Handles b7X.CheckedChanged
        If b7X.Checked = True Then
            pbx7.Image = My.Resources.X_Board
            pbx7.Show()
        Else
            pbx7.Image = My.Resources.Empty_Board
            pbx7.Show()
        End If
    End Sub
    Private Sub b8X_CheckedChanged(sender As Object, e As EventArgs) Handles b8X.CheckedChanged
        If b8X.Checked = True Then
            pbx8.Image = My.Resources.X_Board
            pbx8.Show()
        Else
            pbx8.Image = My.Resources.Empty_Board
            pbx8.Show()
        End If
    End Sub

    Private Sub k0O_CheckedChanged(sender As Object, e As EventArgs) Handles k0O.CheckedChanged
        If k0O.Checked = True Then
            pbx0.Image = My.Resources.O_Key
            pbx0.Show()
        Else
            pbx0.Image = My.Resources.Empty_Board
            pbx0.Show()
        End If
    End Sub
    Private Sub k1O_CheckedChanged(sender As Object, e As EventArgs) Handles k1O.CheckedChanged
        If k1O.Checked = True Then
            pbx1.Image = My.Resources.O_Key
            pbx1.Show()
        Else
            pbx1.Image = My.Resources.Empty_Board
            pbx1.Show()
        End If
    End Sub
    Private Sub k2O_CheckedChanged(sender As Object, e As EventArgs) Handles k2O.CheckedChanged
        If k2O.Checked = True Then
            pbx2.Image = My.Resources.O_Key
            pbx2.Show()
        Else
            pbx2.Image = My.Resources.Empty_Board
            pbx2.Show()
        End If
    End Sub
    Private Sub k3O_CheckedChanged(sender As Object, e As EventArgs) Handles k3O.CheckedChanged
        If k3O.Checked = True Then
            pbx3.Image = My.Resources.O_Key
            pbx3.Show()
        Else
            pbx3.Image = My.Resources.Empty_Board
            pbx3.Show()
        End If
    End Sub
    Private Sub k4O_CheckedChanged(sender As Object, e As EventArgs) Handles k4O.CheckedChanged
        If k4O.Checked = True Then
            pbx4.Image = My.Resources.O_Key
            pbx4.Show()
        Else
            pbx4.Image = My.Resources.Empty_Board
            pbx4.Show()
        End If
    End Sub
    Private Sub k5O_CheckedChanged(sender As Object, e As EventArgs) Handles k5O.CheckedChanged
        If k5O.Checked = True Then
            pbx5.Image = My.Resources.O_Key
            pbx5.Show()
        Else
            pbx5.Image = My.Resources.Empty_Board
            pbx5.Show()
        End If
    End Sub
    Private Sub k6O_CheckedChanged(sender As Object, e As EventArgs) Handles k6O.CheckedChanged
        If k6O.Checked = True Then
            pbx6.Image = My.Resources.O_Key
            pbx6.Show()
        Else
            pbx6.Image = My.Resources.Empty_Board
            pbx6.Show()
        End If
    End Sub
    Private Sub k7O_CheckedChanged(sender As Object, e As EventArgs) Handles k7O.CheckedChanged
        If k7O.Checked = True Then
            pbx7.Image = My.Resources.O_Key
            pbx7.Show()
        Else
            pbx7.Image = My.Resources.Empty_Board
            pbx7.Show()
        End If
    End Sub
    Private Sub k8O_CheckedChanged(sender As Object, e As EventArgs) Handles k8O.CheckedChanged
        If k8O.Checked = True Then
            pbx8.Image = My.Resources.O_Key
            pbx8.Show()
        Else
            pbx8.Image = My.Resources.Empty_Board
            pbx8.Show()
        End If
    End Sub
    Private Sub k0X_CheckedChanged(sender As Object, e As EventArgs) Handles k0X.CheckedChanged
        If k0X.Checked = True Then
            pbx0.Image = My.Resources.X_Key
            pbx0.Show()
        Else
            pbx0.Image = My.Resources.Empty_Board
            pbx0.Show()
        End If
    End Sub
    Private Sub k1X_CheckedChanged(sender As Object, e As EventArgs) Handles k1X.CheckedChanged
        If k1X.Checked = True Then
            pbx1.Image = My.Resources.X_Key
            pbx1.Show()
        Else
            pbx1.Image = My.Resources.Empty_Board
            pbx1.Show()
        End If
    End Sub
    Private Sub k2X_CheckedChanged(sender As Object, e As EventArgs) Handles k2X.CheckedChanged
        If k2X.Checked = True Then
            pbx2.Image = My.Resources.X_Key
            pbx2.Show()
        Else
            pbx2.Image = My.Resources.Empty_Board
            pbx2.Show()
        End If
    End Sub
    Private Sub k3X_CheckedChanged(sender As Object, e As EventArgs) Handles k3X.CheckedChanged
        If k3X.Checked = True Then
            pbx3.Image = My.Resources.X_Key
            pbx3.Show()
        Else
            pbx3.Image = My.Resources.Empty_Board
            pbx3.Show()
        End If
    End Sub
    Private Sub k4X_CheckedChanged(sender As Object, e As EventArgs) Handles k4X.CheckedChanged
        If k4X.Checked = True Then
            pbx4.Image = My.Resources.X_Key
            pbx4.Show()
        Else
            pbx4.Image = My.Resources.Empty_Board
            pbx4.Show()
        End If
    End Sub
    Private Sub k5X_CheckedChanged(sender As Object, e As EventArgs) Handles k5X.CheckedChanged
        If k5X.Checked = True Then
            pbx5.Image = My.Resources.X_Key
            pbx5.Show()
        Else
            pbx5.Image = My.Resources.Empty_Board
            pbx5.Show()
        End If
    End Sub
    Private Sub k6X_CheckedChanged(sender As Object, e As EventArgs) Handles k6X.CheckedChanged
        If k6X.Checked = True Then
            pbx6.Image = My.Resources.X_Key
            pbx6.Show()
        Else
            pbx6.Image = My.Resources.Empty_Board
            pbx6.Show()
        End If
    End Sub
    Private Sub k7X_CheckedChanged(sender As Object, e As EventArgs) Handles k7X.CheckedChanged
        If k7X.Checked = True Then
            pbx7.Image = My.Resources.X_Key
            pbx7.Show()
        Else
            pbx7.Image = My.Resources.Empty_Board
            pbx7.Show()
        End If
    End Sub
    Private Sub k8X_CheckedChanged(sender As Object, e As EventArgs) Handles k8X.CheckedChanged
        If k8X.Checked = True Then
            pbx8.Image = My.Resources.X_Key
            pbx8.Show()
        Else
            pbx8.Image = My.Resources.Empty_Board
            pbx8.Show()
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        b0O.Checked = False
        b1O.Checked = False
        b2O.Checked = False
        b3O.Checked = False
        b4O.Checked = False
        b5O.Checked = False
        b6O.Checked = False
        b7O.Checked = False
        b8O.Checked = False
        b0X.Checked = False
        b1X.Checked = False
        b2X.Checked = False
        b3X.Checked = False
        b4X.Checked = False
        b5X.Checked = False
        b6X.Checked = False
        b7X.Checked = False
        b8X.Checked = False
        k0O.Checked = False
        k1O.Checked = False
        k2O.Checked = False
        k3O.Checked = False
        k4O.Checked = False
        k5O.Checked = False
        k6O.Checked = False
        k7O.Checked = False
        k8O.Checked = False
        k0X.Checked = False
        k1X.Checked = False
        k2X.Checked = False
        k3X.Checked = False
        k4X.Checked = False
        k5X.Checked = False
        k6X.Checked = False
        k7X.Checked = False
        k8X.Checked = False
    End Sub


End Class
