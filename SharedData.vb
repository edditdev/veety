Module SharedData
    '# Serwer
    Public veety_database As String = "https://edditdev.com/veety/database/"
    Public veety_servers As String = "https://edditdev.com/veety/servers/"
    Public veety_all_license As String = "https://edditdev.com/veety/license/licenses"
    Public veety_counters As String = "https://edditdev.com/veety/other/"

    '# Veety Inside data
    Public LicensesList As New RichTextBox
    '- Licznk
    Public RegistrationsCounter As String

    '# User
    Public veety_downloaded_licenses As String
    Public user_username As String
    Public user_password As String
    Public user_license As String

    Public connected_server As String
    Public VictimID As String


End Module
