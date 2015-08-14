'Sidewinder Theme.
'Made by AeroRev9.

Public Module Helpers

    Public Enum MouseState As Byte
        None = 0
        Over = 1
        Down = 2
    End Enum

    Public Function FullRectangle(S As Size, Subtract As Boolean) As Rectangle
        If Subtract Then
            Return New Rectangle(0, 0, S.Width - 1, S.Height - 1)
        Else
            Return New Rectangle(0, 0, S.Width, S.Height)
        End If
    End Function

    Public Function GreyColor(G As UInteger) As Color
        Return Color.FromArgb(G, G, G)
    End Function

    Public Sub CenterString(G As Graphics, T As String, F As Font, C As Color, R As Rectangle)
        Dim TS As SizeF = G.MeasureString(T, F)

        Using B As New SolidBrush(C)
            G.DrawString(T, F, B, New Point(R.Width / 2 - (TS.Width / 2), R.Height / 2 - (TS.Height / 2)))
        End Using
    End Sub

    Public Sub FillRoundRect(G As Graphics, R As Rectangle, Curve As Integer, C As Color)

        Using B As New SolidBrush(C)
            G.FillPie(B, R.X, R.Y, Curve, Curve, 180, 90)
            G.FillPie(B, R.X + R.Width - Curve, R.Y, Curve, Curve, 270, 90)
            G.FillPie(B, R.X, R.Y + R.Height - Curve, Curve, Curve, 90, 90)
            G.FillPie(B, R.X + R.Width - Curve, R.Y + R.Height - Curve, Curve, Curve, 0, 90)
            G.FillRectangle(B, CInt(R.X + Curve / 2), R.Y, R.Width - Curve, CInt(Curve / 2))
            G.FillRectangle(B, R.X, CInt(R.Y + Curve / 2), R.Width, R.Height - Curve)
            G.FillRectangle(B, CInt(R.X + Curve / 2), CInt(R.Y + R.Height - Curve / 2), R.Width - Curve, CInt(Curve / 2))
        End Using

    End Sub

    Public Sub DrawRoundRect(G As Graphics, R As Rectangle, Curve As Integer, C As Color)

        Using P As New Pen(C)
            G.DrawArc(P, R.X, R.Y, Curve, Curve, 180, 90)
            G.DrawLine(P, CInt(R.X + Curve / 2), R.Y, CInt(R.X + R.Width - Curve / 2), R.Y)
            G.DrawArc(P, R.X + R.Width - Curve, R.Y, Curve, Curve, 270, 90)
            G.DrawLine(P, R.X, CInt(R.Y + Curve / 2), R.X, CInt(R.Y + R.Height - Curve / 2))
            G.DrawLine(P, CInt(R.X + R.Width), CInt(R.Y + Curve / 2), CInt(R.X + R.Width), CInt(R.Y + R.Height - Curve / 2))
            G.DrawLine(P, CInt(R.X + Curve / 2), CInt(R.Y + R.Height), CInt(R.X + R.Width - Curve / 2), CInt(R.Y + R.Height))
            G.DrawArc(P, R.X, R.Y + R.Height - Curve, Curve, Curve, 90, 90)
            G.DrawArc(P, R.X + R.Width - Curve, R.Y + R.Height - Curve, Curve, Curve, 0, 90)
        End Using

    End Sub

    Public Enum Direction As Byte
        Up = 0
        Down = 1
        Left = 2
        Right = 3
    End Enum

    Public Sub DrawTriangle(G As Graphics, Rect As Rectangle, D As Direction, C As Color)
        Dim halfWidth As Integer = Rect.Width / 2
        Dim halfHeight As Integer = Rect.Height / 2
        Dim p0 As Point = Point.Empty
        Dim p1 As Point = Point.Empty
        Dim p2 As Point = Point.Empty

        Select Case D
            Case Direction.Up
                p0 = New Point(Rect.Left + halfWidth, Rect.Top)
                p1 = New Point(Rect.Left, Rect.Bottom)
                p2 = New Point(Rect.Right, Rect.Bottom)

            Case Direction.Down
                p0 = New Point(Rect.Left + halfWidth, Rect.Bottom)
                p1 = New Point(Rect.Left, Rect.Top)
                p2 = New Point(Rect.Right, Rect.Top)

            Case Direction.Left
                p0 = New Point(Rect.Left, Rect.Top + halfHeight)
                p1 = New Point(Rect.Right, Rect.Top)
                p2 = New Point(Rect.Right, Rect.Bottom)

            Case Direction.Right
                p0 = New Point(Rect.Right, Rect.Top + halfHeight)
                p1 = New Point(Rect.Left, Rect.Bottom)
                p2 = New Point(Rect.Left, Rect.Top)

        End Select

        Using B As New SolidBrush(C)
            G.FillPolygon(B, New Point() {p0, p1, p2})
        End Using

    End Sub

End Module

Public Class SideWinderTab
    Inherits TabControl

#Region " Helpers "



#End Region

#Region " Drawing "
    Private G As Graphics
    Private Rect As Rectangle
    Private LastIndex As Integer
    Private BackgroundC As Color = Color.FromArgb(102, 105, 112)

    Private _Index As Integer = -1
    Private Property Index As Integer
        Get
            Return _Index
        End Get
        Set(value As Integer)
            _Index = value
            Invalidate()
        End Set
    End Property

    Sub New()
        DoubleBuffered = True
        ItemSize = New Size(40, 170)
        Alignment = TabAlignment.Left
        SizeMode = TabSizeMode.Fixed
        Dock = DockStyle.Fill
    End Sub

    Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
        MyBase.OnControlAdded(e)
        e.Control.BackColor = Color.White
        e.Control.ForeColor = Color.FromArgb(72, 75, 82)
        e.Control.Font = New Font("Segoe UI", 10)
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        MyBase.OnPaint(e)

        G.Clear(Color.FromArgb(72, 75, 82))

        For i As Integer = 0 To TabPages.Count - 1

            Rect = GetTabRect(i)

            If String.IsNullOrEmpty(TabPages(i).Tag) Then

                If SelectedIndex = i Then

                    'Fill selected
                    Using B As New SolidBrush(Color.FromArgb(90, 93, 100))
                        G.FillRectangle(B, New Rectangle(Rect.X, Rect.Y + 2, Rect.Width, Rect.Height))
                    End Using

                    'Triangles
                    DrawTriangle(G, New Rectangle(Rect.X + 158, Rect.Y + 8.5F, 16, 25), Direction.Left, Color.FromArgb(62, 65, 72))
                    DrawTriangle(G, New Rectangle(Rect.X + 160, Rect.Y + 8.5F, 16, 25), Direction.Left, TabPages(i).BackColor)

                Else

                    'Fill not selected
                    Using B As New SolidBrush(Color.FromArgb(72, 75, 82))
                        G.FillRectangle(B, Rect)
                    End Using

                End If

                'OverFill not selected
                If Not Index = -1 And Not SelectedIndex = Index Then

                    Using B As New SolidBrush(Color.FromArgb(82, 85, 92))
                        G.FillRectangle(B, GetTabRect(Index))
                    End Using

                    'OverText
                    Using B As New SolidBrush(Color.FromArgb(218, 220, 217))
                        G.DrawString(TabPages(Index).Text, New Font("Segoe UI", 10), B, New Point(GetTabRect(Index).X + 55, GetTabRect(Index).Y + 12))
                    End Using

                    'Images
                    If Not IsNothing(ImageList) Then
                        If Not TabPages(Index).ImageIndex < 0 Then
                            G.DrawImage(ImageList.Images(TabPages(Index).ImageIndex), New Rectangle(GetTabRect(Index).X + 25, GetTabRect(Index).Y + ((GetTabRect(Index).Height / 2) - 9), 18, 18))
                        End If
                    End If

                End If

                If Not i = Index Then

                    'Texts
                    Using B As New SolidBrush(Color.FromArgb(218, 220, 217))
                        G.DrawString(TabPages(i).Text, New Font("Segoe UI", 10), B, New Point(Rect.X + 55, Rect.Y + 12))
                    End Using

                    'Images
                    If Not IsNothing(ImageList) Then
                        If Not TabPages(i).ImageIndex < 0 Then
                            G.DrawImage(ImageList.Images(TabPages(i).ImageIndex), New Rectangle(Rect.X + 25, Rect.Y + ((Rect.Height / 2) - 9), 18, 18))
                        End If
                    End If

                End If
            Else
                'Headers
                Using B As New SolidBrush(Color.FromArgb(158, 160, 157))
                    G.DrawString(TabPages(i).Text.ToUpper, New Font("Segoe UI semibold", 9), B, New Point(Rect.X + 25, Rect.Y + 18))
                End Using

            End If

        Next

    End Sub

    Protected Overrides Sub OnSelecting(e As TabControlCancelEventArgs)
        MyBase.OnSelecting(e)

        If Not IsNothing(e.TabPage) Then
            If Not String.IsNullOrEmpty(e.TabPage.Tag) Then
                e.Cancel = True
            Else
                Index = -1
            End If
        End If

    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        For i As Integer = 0 To TabPages.Count - 1
            If GetTabRect(i).Contains(e.Location) And Not SelectedIndex = i And String.IsNullOrEmpty(TabPages(i).Tag) Then
                Index = i
                Exit For
            End If
        Next
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        Index = -1
    End Sub

#End Region

End Class

Public Class SideWinderProgress
    Inherits Control

#Region " Drawing "

    Private _Val As Integer = 0
    Private _Min As Integer = 0
    Private _Max As Integer = 100

    Public Property Value As Integer
        Get
            Return _Val
        End Get
        Set(value As Integer)
            _Val = value
            Invalidate()
        End Set
    End Property

    Public Property Minimum As Integer
        Get
            Return _Min
        End Get
        Set(value As Integer)
            _Min = value
            Invalidate()
        End Set
    End Property

    Public Property Maximum As Integer
        Get
            Return _Max
        End Get
        Set(value As Integer)
            _Max = value
            Invalidate()
        End Set
    End Property

    Sub New()
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        Dim G As Graphics = e.Graphics
        'G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        MyBase.OnPaint(e)

        G.Clear(Color.White)

        If Not Value = 0 Then
            FillRoundRect(G, New Rectangle(0, 0, Value / Maximum * Width - 1, Height - 1), 8, Color.FromArgb(213, 228, 150))
        End If

        DrawRoundRect(G, FullRectangle(Size, True), 8, Color.FromArgb(232, 235, 242))

    End Sub

#End Region

End Class

Public Class SideWinderAlert
    Inherits Control

#Region " Drawing "

    Private G As Graphics
    Private _Alert As Style

    Public Property Centered As Boolean
    Public Property Field As Boolean

    Enum Style As Byte
        Notice = 0
        Informations = 1
        Warning = 2
        Success = 3
    End Enum

    Public Property Alert As Style
        Get
            Return _Alert
        End Get
        Set(value As Style)
            _Alert = value
            Invalidate()
        End Set
    End Property

    Sub New()
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        MyBase.OnPaint(e)

        G.Clear(Parent.BackColor)

        Select Case Alert

            Case Style.Notice

                If Field Then
                    FillRoundRect(G, New Rectangle(20, 0, Width - 20, Height - 1), 4, Color.FromArgb(217, 237, 247))
                    DrawRoundRect(G, New Rectangle(20, 0, Width - 21, Height - 1), 4, Color.FromArgb(188, 232, 241))

                    DrawTriangle(G, New Rectangle(0, 7, 20, 20), Direction.Left, Color.FromArgb(188, 232, 241))
                    DrawTriangle(G, New Rectangle(2, 7, 20, 20), Direction.Left, Color.FromArgb(217, 237, 247))

                    If Centered Then
                        CenterString(G, Text, New Font("Segoe UI", 10), Color.FromArgb(58, 135, 173), New Rectangle(20, 0, Width, Height))
                    Else
                        Using B As New SolidBrush(Color.FromArgb(58, 135, 173))
                            G.DrawString(Text, New Font("Segoe UI", 10), B, New Point(35, 9))
                        End Using
                    End If

                Else
                    FillRoundRect(G, FullRectangle(Size, True), 4, Color.FromArgb(217, 237, 247))
                    DrawRoundRect(G, New Rectangle(0, 0, Width - 1, Height - 1), 4, Color.FromArgb(188, 232, 241))

                    If Centered Then
                        CenterString(G, Text, New Font("Segoe UI", 10), Color.FromArgb(58, 135, 173), FullRectangle(Size, False))
                    Else
                        Using B As New SolidBrush(Color.FromArgb(58, 135, 173))
                            G.DrawString(Text, New Font("Segoe UI", 10), B, New Point(12, 9))
                        End Using
                    End If
                End If


            Case Style.Informations

                If Field Then
                    FillRoundRect(G, New Rectangle(20, 0, Width - 20, Height - 1), 4, Color.FromArgb(252, 248, 227))
                    DrawRoundRect(G, New Rectangle(20, 0, Width - 21, Height - 1), 4, Color.FromArgb(251, 238, 213))

                    DrawTriangle(G, New Rectangle(0, 7, 20, 20), Direction.Left, Color.FromArgb(251, 238, 213))
                    DrawTriangle(G, New Rectangle(2, 7, 20, 20), Direction.Left, Color.FromArgb(252, 248, 227))

                    If Centered Then
                        CenterString(G, Text, New Font("Segoe UI", 10), Color.FromArgb(192, 152, 83), New Rectangle(20, 0, Width, Height))
                    Else
                        Using B As New SolidBrush(Color.FromArgb(192, 152, 83))
                            G.DrawString(Text, New Font("Segoe UI", 10), B, New Point(35, 9))
                        End Using
                    End If

                Else
                    FillRoundRect(G, FullRectangle(Size, True), 4, Color.FromArgb(252, 248, 227))
                    DrawRoundRect(G, New Rectangle(0, 0, Width - 1, Height - 1), 4, Color.FromArgb(251, 238, 213))

                    If Centered Then
                        CenterString(G, Text, New Font("Segoe UI", 10), Color.FromArgb(192, 152, 83), FullRectangle(Size, False))
                    Else
                        Using B As New SolidBrush(Color.FromArgb(192, 152, 83))
                            G.DrawString(Text, New Font("Segoe UI", 10), B, New Point(12, 9))
                        End Using
                    End If
                End If

            Case Style.Warning

                If Field Then
                    FillRoundRect(G, New Rectangle(20, 0, Width - 20, Height - 1), 4, Color.FromArgb(242, 222, 222))
                    DrawRoundRect(G, New Rectangle(20, 0, Width - 21, Height - 1), 4, Color.FromArgb(238, 211, 215))

                    DrawTriangle(G, New Rectangle(0, 7, 20, 20), Direction.Left, Color.FromArgb(238, 211, 215))
                    DrawTriangle(G, New Rectangle(2, 7, 20, 20), Direction.Left, Color.FromArgb(242, 222, 222))

                    If Centered Then
                        CenterString(G, Text, New Font("Segoe UI", 10), Color.FromArgb(185, 74, 72), New Rectangle(20, 0, Width, Height))
                    Else
                        Using B As New SolidBrush(Color.FromArgb(185, 74, 72))
                            G.DrawString(Text, New Font("Segoe UI", 10), B, New Point(35, 9))
                        End Using
                    End If

                Else
                    FillRoundRect(G, FullRectangle(Size, True), 4, Color.FromArgb(242, 222, 222))
                    DrawRoundRect(G, New Rectangle(0, 0, Width - 1, Height - 1), 4, Color.FromArgb(238, 211, 215))

                    If Centered Then
                        CenterString(G, Text, New Font("Segoe UI", 10), Color.FromArgb(185, 74, 72), FullRectangle(Size, False))
                    Else
                        Using B As New SolidBrush(Color.FromArgb(185, 74, 72))
                            G.DrawString(Text, New Font("Segoe UI", 10), B, New Point(12, 9))
                        End Using
                    End If
                End If

            Case Else

                If Field Then
                    FillRoundRect(G, New Rectangle(20, 0, Width - 20, Height - 1), 4, Color.FromArgb(223, 240, 216))
                    DrawRoundRect(G, New Rectangle(20, 0, Width - 21, Height - 1), 4, Color.FromArgb(214, 233, 198))

                    DrawTriangle(G, New Rectangle(0, 7, 20, 20), Direction.Left, Color.FromArgb(214, 233, 198))
                    DrawTriangle(G, New Rectangle(2, 7, 20, 20), Direction.Left, Color.FromArgb(223, 240, 216))

                    If Centered Then
                        CenterString(G, Text, New Font("Segoe UI", 10), Color.FromArgb(70, 136, 71), New Rectangle(20, 0, Width, Height))
                    Else
                        Using B As New SolidBrush(Color.FromArgb(70, 136, 71))
                            G.DrawString(Text, New Font("Segoe UI", 10), B, New Point(35, 9))
                        End Using
                    End If

                Else
                    FillRoundRect(G, FullRectangle(Size, True), 4, Color.FromArgb(223, 240, 216))
                    DrawRoundRect(G, New Rectangle(0, 0, Width - 1, Height - 1), 4, Color.FromArgb(214, 233, 198))

                    If Centered Then
                        CenterString(G, Text, New Font("Segoe UI", 10), Color.FromArgb(70, 136, 71), FullRectangle(Size, False))
                    Else
                        Using B As New SolidBrush(Color.FromArgb(70, 136, 71))
                            G.DrawString(Text, New Font("Segoe UI", 10), B, New Point(12, 9))
                        End Using
                    End If
                End If
        End Select

    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If Not Field Then
            Height = 37
        End If
    End Sub

#End Region

End Class

Public Class SideWinderBlock
    Inherits GroupBox

#Region " Drawing "

    Private G As Graphics

    Sub New()
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        MyBase.OnPaint(e)

        G.Clear(Color.White)

        Using P As New Pen(Color.FromArgb(220, 220, 220)) With {
            .DashStyle = Drawing2D.DashStyle.Dash}

            G.DrawRectangle(P, FullRectangle(Size, True))
        End Using

    End Sub


#End Region


End Class

Public Class SideWinderSeparator
    Inherits Control

#Region " Drawing "

    Private G As Graphics

    Sub New()
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        MyBase.OnPaint(e)

        Using P As New Pen(Color.FromArgb(232, 235, 242)) With {
            .DashStyle = Drawing2D.DashStyle.Dash}
            G.DrawLine(P, New Point(0, 0), New Point(Width, 0))
        End Using

    End Sub

#End Region

End Class

Public Class SideWinderBlockQuote
    Inherits Control

#Region " Drawing "

    Private G As Graphics

    Public Property Title As String

    Public Property Description As String

    Sub New()
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        MyBase.OnPaint(e)

        Using P As New Pen(Color.FromArgb(102, 105, 112), 3)
            G.DrawLine(P, New Point(3, 0), New Point(3, Height))
        End Using

        If Not String.IsNullOrEmpty(Title) Then
            Using B As New SolidBrush(Color.FromArgb(112, 115, 122))
                G.DrawString(Title.ToUpper, New Font("Segoe UI semibold", 11), B, New Point(13, 0))
            End Using
        End If

        Using B As New SolidBrush(Color.FromArgb(92, 95, 112))
            G.DrawString(Description, New Font("Segoe UI", 10), B, New Point(13, 23))
        End Using

    End Sub

#End Region

End Class