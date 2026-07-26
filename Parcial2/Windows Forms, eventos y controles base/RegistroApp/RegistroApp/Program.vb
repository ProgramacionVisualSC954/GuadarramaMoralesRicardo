Option Strict On

Imports System
Imports System.Windows.Forms

Module Program

    ''' <summary>
    ''' Punto de entrada de la aplicación.
    ''' </summary>
    <STAThread>
    Sub Main()
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub

End Module
