Public Class Libraries
    Public Shared Sub InitLibs()
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CDAR01
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CDAR02
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CDAR03
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CDAR04
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CDAR05
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CDAR06
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CDAR07
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CDAR08
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CDAR09
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CDAR10
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CDAR11
    End Sub
    Private Shared Function CDAR01(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Limitless.NAudio.dll")
            Dim assemblyData = New Byte(stream.Length - 1) {}
            stream.Read(assemblyData, 0, assemblyData.Length)
            Return System.Reflection.Assembly.Load(assemblyData)
        End Using
    End Function
    Private Shared Function CDAR02(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Limitless.EntityFramework.dll")
            Dim assemblyData = New Byte(stream.Length - 1) {}
            stream.Read(assemblyData, 0, assemblyData.Length)
            Return System.Reflection.Assembly.Load(assemblyData)
        End Using
    End Function
    Private Shared Function CDAR03(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Limitless.EntityFrameworkSqlServer.dll")
            Dim assemblyData = New Byte(stream.Length - 1) {}
            stream.Read(assemblyData, 0, assemblyData.Length)
            Return System.Reflection.Assembly.Load(assemblyData)
        End Using
    End Function
    Private Shared Function CDAR04(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Limitless.Microsoft.Win32.Registry.dll")
            Dim assemblyData = New Byte(stream.Length - 1) {}
            stream.Read(assemblyData, 0, assemblyData.Length)
            Return System.Reflection.Assembly.Load(assemblyData)
        End Using
    End Function
    Private Shared Function CDAR05(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Limitless.NAudio.Asio.dll")
            Dim assemblyData = New Byte(stream.Length - 1) {}
            stream.Read(assemblyData, 0, assemblyData.Length)
            Return System.Reflection.Assembly.Load(assemblyData)
        End Using
    End Function
    Private Shared Function CDAR06(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Limitless.NAudio.Midi.dll")
            Dim assemblyData = New Byte(stream.Length - 1) {}
            stream.Read(assemblyData, 0, assemblyData.Length)
            Return System.Reflection.Assembly.Load(assemblyData)
        End Using
    End Function
    Private Shared Function CDAR07(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Limitless.NAudio.Wasapi.dll")
            Dim assemblyData = New Byte(stream.Length - 1) {}
            stream.Read(assemblyData, 0, assemblyData.Length)
            Return System.Reflection.Assembly.Load(assemblyData)
        End Using
    End Function
    Private Shared Function CDAR08(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Limitless.System.Data.SQLite.EF6.dll")
            Dim assemblyData = New Byte(stream.Length - 1) {}
            stream.Read(assemblyData, 0, assemblyData.Length)
            Return System.Reflection.Assembly.Load(assemblyData)
        End Using
    End Function
    Private Shared Function CDAR09(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Limitless.System.Data.SQLite.Linq.dll")
            Dim assemblyData = New Byte(stream.Length - 1) {}
            stream.Read(assemblyData, 0, assemblyData.Length)
            Return System.Reflection.Assembly.Load(assemblyData)
        End Using
    End Function
    Private Shared Function CDAR10(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Limitless.System.Security.Principal.Window.dll")
            Dim assemblyData = New Byte(stream.Length - 1) {}
            stream.Read(assemblyData, 0, assemblyData.Length)
            Return System.Reflection.Assembly.Load(assemblyData)
        End Using
    End Function
    Private Shared Function CDAR11(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Limitless..System.Security.AccessControl.dll")
            Dim assemblyData = New Byte(stream.Length - 1) {}
            stream.Read(assemblyData, 0, assemblyData.Length)
            Return System.Reflection.Assembly.Load(assemblyData)
        End Using
    End Function

End Class
