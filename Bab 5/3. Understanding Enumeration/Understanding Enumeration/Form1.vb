Public Class Form1
    'DayAction Enumeration
    Private Enum DayAction As Integer
        Asleep = 0
        GettingReadyForWork = 1
        TravelingToWork = 2
        AtWork = 3
        AtLunch = 4
        TravelingFromWork = 5
        RelaxingWithFriends = 6
        GettingReadyForBed = 7
    End Enum

    'Declare variable
    Private CurrentState As DayAction

    'Hour property
    Private Property Hour() As Integer
        Get
            'Return the current hour displayed
            Return dtpHour.Value.Hour
        End Get
        Set(value As Integer)
            'Set the date using the hour passed to this property
            dtpHour.Value = New Date(Now.Year, Now.Month, Now.Day, value, 0, 0)
            'Set the display text
            lblState.Text = "At " & value & ":00, Richard is "
        End Set
    End Property


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the Hour property to the current hour
        Me.Hour = Now.Hour
    End Sub

    Private Sub dtpHour_ValueChanged(sender As Object,
e As EventArgs) Handles dtpHour.ValueChanged
        'Update the Hour property
        Me.Hour = dtpHour.Value.Hour
    End Sub

    Private Property Hour() As Integer
        Get
            'Return the current hour displayed
            Return dtpHour.Value.Hour
        End Get
        Set(value As Integer)
            'Set the date using the hour passed to this property
            dtpHour.Value =
New Date(Now.Year, Now.Month, Now.Day, value, 0, 0)
            'Set the display text
            lblState.Text = "At " & value & ":00, Richard is "
        End Set
    End Property

End Class
