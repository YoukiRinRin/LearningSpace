Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim os As System.OperatingSystem = System.Environment.OSVersion

        Console.WriteLine(os.ToString())

        Console.WriteLine(os.VersionString)

        Console.WriteLine(os.Version.ToString())

        Console.WriteLine(os.Platform)

        Console.WriteLine(os.Version.Major)
        Console.WriteLine(os.Version.Minor)

        Console.WriteLine(os.Version.Build)

        Console.WriteLine(os.Version.Revision)

        Console.WriteLine(os.ServicePack)

        Console.WriteLine(os.Version.MajorRevision)
        Console.WriteLine(os.Version.MinorRevision)
    End Sub
End Module
