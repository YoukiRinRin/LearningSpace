Imports System
Imports Microsoft.Win32

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim os As System.OperatingSystem = System.Environment.OSVersion

        Dim info_os As String
        Dim Inf_CPU As Object
        Dim Inf_memori As String
        Dim Inf_Drive As String

        info_os = os.ToString

        'CPU情報の取得
        Dim regkey As   
        Inf_CPU = Registry.Getvalue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0",
                                                "ProcessorNameString",
                                                Nothing)

        'OS情報の取得

        Console.WriteLine(info_os)

        Console.ReadLine()
    End Sub
End Module
