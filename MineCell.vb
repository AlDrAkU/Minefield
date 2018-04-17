Public Class MineCell
    'Enum for MineCell Views
    Public Enum MineCellView
        Button '=0
        Mine '=1,etc
        Number
        Question
        Flag
    End Enum

    'Private Field variables to store the mine properties

    Private mView As MineCellView
    Private mNumber As Integer
    Private mHasMine As Boolean
    Private myX As Integer
    Private myY As Integer
    Private mButtonColor As Color = Color.LightGray
    Public Property ButtonColor() As Color
        Get
            Return mButtonColor

        End Get
        Set(value As Color)
            mButtonColor = value

        End Set
    End Property

    Public Property HasMine() As Boolean
        Get
            Return mHasMine
        End Get
        Set(value As Boolean)
            mHasMine = value
        End Set
    End Property
    Public Property X() As Integer
        Get
            Return myX
        End Get
        Set(value As Integer)
            myX = value
        End Set
    End Property
    Public Property Y() As Integer
        Get
            Return myY
        End Get
        Set(value As Integer)
            myY = value
        End Set
    End Property

    Public Property Number As Integer
        Get
            Return mNumber

        End Get
        Set(ByVal value As Integer)
            mNumber = value
            Me.Invalidate() 'anytime we change the property, it forces a redraw
        End Set
    End Property

    Public Property View() As MineCellView
        Get
            Return mView
        End Get
        Set(ByVal value As MineCellView)
            mView = value
            Me.Invalidate()

        End Set
    End Property

    Private Sub MineCell_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Select Case mView
            Case MineCellView.Button
                With e.Graphics
                    .ResetTransform()
                    .TranslateTransform(CSng(Me.Width / 2), CSng(Me.Height / 2))
                    .ScaleTransform(CSng(Me.Width / 2), CSng(Me.Height / 2))
                    .Clear(mButtonColor)
                    'Special Points for drawing shades
                    Dim TopLeft As New PointF(-1, -1)
                    Dim TopRight As New PointF(1, -1)
                    Dim BotLeft As New PointF(-1, 1)
                    Dim BotRight As New PointF(1, 1)

                    'Draw darker shade on the bottom
                    Dim mPen As New Pen(Color.Gray, 0.3)
                    .DrawLine(mPen, BotRight, BotLeft)
                    .DrawLine(mPen, BotRight, TopRight)
                    'Draw lighter shade on the top
                    mPen = New Pen(Color.White, 0.3)
                    .DrawLine(mPen, TopLeft, BotLeft)
                    .DrawLine(mPen, TopLeft, TopRight)
                End With
            Case MineCellView.Mine 'Drawing the mine in all it's glory 
                With e.Graphics
                    .ResetTransform()
                    .TranslateTransform(CSng(Me.Width / 2), CSng(Me.Height / 2))
                    .ScaleTransform(CSng(Me.Width / 2), CSng(Me.Height / 2))
                    .Clear(Color.WhiteSmoke)

                    'Draw Circle for the mine
                    Dim CRect As New RectangleF(-0.6, -0.6, 1.2, 1.2)
                    Dim CBrush As New SolidBrush(Color.Black)
                    .FillEllipse(CBrush, CRect)

                    'Draw Pegs on mine
                    Dim IRad As Single = 0.5
                    Dim ORad As Single = 0.8
                    Dim PPen As New Pen(Color.Black, 0.15)
                    PPen.EndCap = Drawing2D.LineCap.Round
                    For Ang As Single = 0 To 1.75 * Math.PI Step 0.25 * Math.PI
                        Dim Inner As New PointF(CSng(IRad * Math.Cos(Ang)), CSng(IRad * Math.Sin(Ang)))
                        Dim Outer As New PointF(CSng(ORad * Math.Cos(Ang)), CSng(ORad * Math.Sin(Ang)))
                        .DrawLine(PPen, Inner, Outer)

                    Next
                    'Draw Highlight on mine
                    Dim Hrect As New RectangleF(-0.3, -0.3, 0.2, 0.2)
                    Dim WBrush As New SolidBrush(Color.White)
                    .FillRectangle(WBrush, Hrect)

                    'Draw Border around the mine
                    Dim BRect As New Rectangle(-1, -1, 2, 2)
                    Dim BPen As New Pen(Color.Gray, 0.05)
                    .DrawRectangle(BPen, BRect)
                End With

            Case MineCellView.Number
                Dim NColors() As Color = {Color.Blue, Color.Green, Color.Red, Color.Navy, Color.DarkGreen, Color.DarkRed, Color.Brown, Color.Black}
                'Dim NColors As Color = (Color.Black)

                With e.Graphics
                    'SetScale

                    .ResetTransform()
                    .TranslateTransform(CSng(Me.Width / 2), CSng(Me.Height / 2))
                    .ScaleTransform(CSng(Me.Width / 2), CSng(Me.Height / 2))
                    .Clear(Color.WhiteSmoke)

                    If mNumber > 0 And mNumber <= 8 Then
                        'Draw Number
                        Dim NBrush As New SolidBrush(NColors(mNumber - 1))
                        Dim myFont As New Font("Times", 1.5, FontStyle.Bold, GraphicsUnit.World)
                        Dim SS As SizeF = .MeasureString(mNumber.ToString, myFont)
                        .DrawString(mNumber.ToString, myFont, NBrush, -SS.Width / 2, -SS.Height / 2)

                    End If

                    'Draw Border around the mine
                    Dim BRect As New Rectangle(-1, -1, 2, 2)
                    Dim BPen As New Pen(Color.Gray, 0.05)
                    .DrawRectangle(BPen, BRect)
                End With
              

            Case MineCellView.Question
                With e.Graphics
                    .ResetTransform()
                    .TranslateTransform(CSng(Me.Width / 2), CSng(Me.Height / 2))
                    .ScaleTransform(CSng(Me.Width / 2), CSng(Me.Height / 2))
                    .Clear(Color.LightGray)
                    'Special Points for drawing shades
                    Dim TopLeft As New PointF(-1, -1)
                    Dim TopRight As New PointF(1, -1)
                    Dim BotLeft As New PointF(-1, 1)
                    Dim BotRight As New PointF(1, 1)

                    'Draw Question mark

                    Dim NBrush As New SolidBrush(Color.Black)
                    Dim myFont As New Font("Times", 1.5, FontStyle.Bold, GraphicsUnit.World)
                    Dim SS As SizeF = .MeasureString("?", myFont)
                    .DrawString("?", myFont, NBrush, -SS.Width / 2, -SS.Height / 2)

                    'Draw darker shade on the bottom
                    Dim mPen As New Pen(Color.Gray, 0.3)
                    .DrawLine(mPen, BotRight, BotLeft)
                    .DrawLine(mPen, BotRight, TopRight)
                    'Draw lighter shade on the top
                    mPen = New Pen(Color.White, 0.3)
                    .DrawLine(mPen, TopLeft, BotLeft)
                    .DrawLine(mPen, TopLeft, TopRight)
                End With
            Case MineCellView.Flag
                'Drawing the Flag by first drawing the button graphic
                With e.Graphics
                    .ResetTransform()
                    .TranslateTransform(CSng(Me.Width / 2), CSng(Me.Height / 2))
                    .ScaleTransform(CSng(Me.Width / 2), CSng(Me.Height / 2))
                    .Clear(Color.LightGray)
                    'Special Points for drawing shades
                    Dim TopLeft As New PointF(-1, -1)
                    Dim TopRight As New PointF(1, -1)
                    Dim BotLeft As New PointF(-1, 1)
                    Dim BotRight As New PointF(1, 1)

                    'Draw darker shade on the bottom
                    Dim mPen As New Pen(Color.Gray, 0.3)
                    .DrawLine(mPen, BotRight, BotLeft)
                    .DrawLine(mPen, BotRight, TopRight)
                    'Draw lighter shade on the top
                    mPen = New Pen(Color.White, 0.3)
                    .DrawLine(mPen, TopLeft, BotLeft)
                    .DrawLine(mPen, TopLeft, TopRight)

                    'Special Flag Points
                    Dim PoleTop As New PointF(0, -0.7)
                    Dim PoleBottom As New PointF(0, 0.5)
                    Dim FlagTip As New PointF(-0.7, -0.3)
                    Dim FlagBottom As New PointF(0, 0.1)
                    Dim BaseLT As New PointF(-0.5, 0.5)
                    Dim BaseLB As New PointF(-0.7, 0.7)
                    Dim BaseRT As New PointF(0.5, 0.5)
                    Dim BaseBR As New PointF(0.7, 0.7)
                    'pole
                    mPen = New Pen(Color.Brown, 0.1)
                    .DrawLine(mPen, PoleTop, PoleBottom)
                    'Flag
                    Dim Fpts() As PointF = {PoleTop, FlagTip, FlagBottom}
                    Dim FBrush As New SolidBrush(Color.Red)
                    .FillPolygon(FBrush, Fpts)

                    'drawing the base of the flag
                    Dim BPts() As PointF = {BaseLT, BaseLB, BaseBR, BaseRT}
                    FBrush.Color = Color.Black
                    .FillPolygon(FBrush, BPts)

                End With

        End Select
    End Sub
 
End Class
