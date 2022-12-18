Imports System
Imports System.Collections.Generic

Namespace Point2DChart

    Public Class ChartViewModel

        Private dataPointsField As List(Of DataPoint)

        Public ReadOnly Property DataPoints As List(Of DataPoint)
            Get
                If dataPointsField Is Nothing Then
                    dataPointsField = New List(Of DataPoint) From {New DataPoint(New DateTime(2019, 1, 1), 7.2), New DataPoint(New DateTime(2019, 2, 1), 8.3), New DataPoint(New DateTime(2019, 3, 1), 12.2), New DataPoint(New DateTime(2019, 4, 1), 15.6), New DataPoint(New DateTime(2019, 5, 1), 19.6), New DataPoint(New DateTime(2019, 6, 1), 22.7), New DataPoint(New DateTime(2019, 7, 1), 25.2), New DataPoint(New DateTime(2019, 8, 1), 25), New DataPoint(New DateTime(2019, 9, 1), 21.1), New DataPoint(New DateTime(2019, 10, 1), 16.3), New DataPoint(New DateTime(2019, 11, 1), 10.8), New DataPoint(New DateTime(2019, 12, 1), 7.5)}
                End If

                Return dataPointsField
            End Get
        End Property
    End Class

    Public Class DataPoint

        Public Property Time As Date

        Public Property Value As Double

        Public Sub New(ByVal time As Date, ByVal value As Double)
            Me.Time = time
            Me.Value = value
        End Sub
    End Class
End Namespace
