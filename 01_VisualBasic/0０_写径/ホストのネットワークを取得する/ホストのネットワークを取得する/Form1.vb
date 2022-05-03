Imports System
Imports System.Net

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ipHost As IPHostEntry
        Dim ipAdr As IPAddress

        ipHost = Dns.Resolve(Dns.GetHostName())
        For Each ipSdr In ipHost.AddressList

            TextBox1.Text = "ホスト名:" &
                Dns.GetHostByAddress(ipAdr).HostName

            TextBox2.Text = "IPアドレス:" & ipAdr.ToString

        Next

    End Sub

End Class
