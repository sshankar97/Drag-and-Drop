Public Class Form1
    Dim sx As Integer
    Dim sy As Integer
    Dim ex As Integer
    Dim ey As Integer
    Dim hold As Boolean
    Dim x As Boolean
    Dim y As Boolean
    Dim sx1 As Integer
    Dim sy1 As Integer
    Dim ex1 As Integer
    Dim ey1 As Integer
    Dim hold1 As Boolean
    Dim x1 As Boolean
    Dim y1 As Boolean


    Public Sub New()
        InitializeComponent()

    End Sub



    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        sx = MousePosition.X
        sy = MousePosition.Y
        hold = True
        x = False
        y = False


    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If hold Then
            ex = MousePosition.X
            ey = MousePosition.Y
            Me.Cursor = Cursors.Hand
        End If
        If x = False Then
            sx = ex - sender.left
            x = True
        End If
        If y = False Then
            sy = ey - sender.top
            y = True
        End If
        sender.left = ex - sx
        sender.top = ey - sy
        ToolStripStatusLabel1.Text = "PictureBox1: " + Convert.ToString(sender.left) + "," + Convert.ToString(sender.top)
        Dim rectangle1 As New Rectangle(ex - sx, ey - sy, PictureBox1.Height, PictureBox1.Width)
        Dim rectangle2 As New Rectangle(PictureBox2.Location.X, PictureBox2.Location.Y, PictureBox2.Height, PictureBox2.Width)
        If (rectangle1.IntersectsWith(rectangle2)) Then
            rectangle2.Intersect(rectangle1)
            ToolStripStatusLabel1.Text = "PictureBox1: " + Convert.ToString(sender.left) + "," + Convert.ToString(sender.top) + "| PictureBox1 is currently over PictureBox2"


        End If

    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        hold = False
        x = False
        y = False
        Me.Cursor = Cursors.Default


    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        sx1 = MousePosition.X
        sy1 = MousePosition.Y
        hold1 = True
        x1 = False
        y1 = False


    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        If hold1 Then
            ex1 = MousePosition.X
            ey1 = MousePosition.Y
            Me.Cursor = Cursors.Hand
        End If
        If x1 = False Then
            sx1 = ex1 - sender.left
            x1 = True
        End If
        If y1 = False Then
            sy1 = ey1 - sender.top
            y1 = True
        End If
        sender.left = ex1 - sx1
        sender.top = ey1 - sy1
        ToolStripStatusLabel1.Text = "PictureBox2: " + Convert.ToString(sender.left) + "," + Convert.ToString(sender.top)
        Dim rectangle1 As New Rectangle(PictureBox1.Location.X, PictureBox1.Location.Y, PictureBox1.Height, PictureBox1.Width)
        Dim rectangle2 As New Rectangle(ex1 - sx1, ey1 - sy1, PictureBox2.Height, PictureBox2.Width)
        If (rectangle2.IntersectsWith(rectangle1)) Then
            rectangle1.Intersect(rectangle2)
            ToolStripStatusLabel1.Text = "PictureBox2: " + Convert.ToString(sender.left) + "," + Convert.ToString(sender.top) + "| PictureBox2 is currently over PictureBox1"


        End If
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        hold1 = False
        x1 = False
        y1 = False
        Me.Cursor = Cursors.Default


    End Sub


End Class
