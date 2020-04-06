'Imports System.IO.Ports
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing

Public Class frmMain
    Private debug As Boolean = True

    Private elapsedTime As Integer = 0

    Private Const SeriesA As String = "カボチャ"
    Private Const SeriesB As String = "キャベツ"
    Private Const SeriesC As String = "キュウリ"
    Private Const SeriesD As String = "トマト"
    
    Private Const MessageA As String = "Current price(squash) is "
    Private Const MessageB As String = "Current price(cabbage) is "
    Private Const MessageC As String = "Current price(cucumber) is "
    Private Const MessageD As String = "Current price(tomato) is "

    Private Const UnitA As String = "yen"
    Private Const UnitB As String = "yen"
    Private Const UnitC As String = "yen"
    Private Const UnitD As String = "yen"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'SerialPort1.Close()
        Timer1.Enabled = False
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub btnSerialRead_Click(sender As Object, e As EventArgs) Handles btnSerialRead.Click
        If debug Then
        Else
            'Dim portName As String = cbComPort.SelectedItem.ToString
            'SerialPort1.BaudRate = 9600
            'SerialPort1.PortName = portName
            'SerialPort1.Open()
        End If

        txtMessage.Text = ""
        Timer1.Enabled = True
    End Sub

    Function ReadMeasurementData() As String

        Dim alphaa As Single = 200.0
        Dim alphab As Single = 100.0
        Dim alphac As Single = 390.0
        Dim alphad As Single = 380.0

        If debug Then

            Return MessageA + CInt((alphaa * (CDbl(1 + Rnd() / 10)))).ToString + UnitA + vbNewLine + _
                   MessageB + CInt((alphab * (CDbl(1 + Rnd() / 10)))).ToString + UnitB + vbNewLine + _
                   MessageC + CInt((alphac * (CDbl(1 + Rnd() / 10)))).ToString + UnitC + vbNewLine + _
                   MessageD + CInt((alphad * (CDbl(1 + Rnd() / 10)))).ToString + UnitD + vbNewLine + _
                   "EOC"
        Else
            'Dim ret As String = "Current temperature is " + SerialPort1.ReadExisting + "C" + vbNewLine
            Dim ret As String

            Return ret
        End If


    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'うまく読めないので止め。
        'Dim data As String = SerialPort1.ReadLine
        'シミュレーション
        'Dim data As String = SerialPort1.ReadExisting
        Dim data As String = ReadMeasurementData()

        Dim splitData As String() = data.Split(vbNewLine)
        'Dim lastData As String = splitData(splitData.Length - 2)

        Dim SeriesA As Double
        Dim SeriesB As Double
        Dim SeriesC As Double
        Dim SeriesD As Double

        txtMessage.Text = data

        '2018/3/15 キャベツを追加

        'キャベツ
        'SeriesB

        '二酸化炭素濃度
        'carbon dioxide concentration 

        '日射量
        'The amount of solar radiation

        If splitData(0).IndexOf(MessageA) >= 0 Then
            Try
                Dim sTmp As String = Replace(splitData(0), MessageA, "")
                sTmp = sTmp.Replace(UnitA, "")
                sTmp = sTmp.Replace(vbLf, "")
                SeriesA = CDbl(sTmp)
            Catch ex As Exception
            End Try
        End If

        If splitData(1).IndexOf(MessageB) >= 0 Then
            Try
                Dim sTmp As String = Replace(splitData(1), MessageB, "")
                sTmp = sTmp.Replace(UnitB, "")
                sTmp = sTmp.Replace(vbLf, "")
                SeriesB = CDbl(sTmp)
            Catch ex As Exception
            End Try
        End If

        If splitData(2).IndexOf(MessageC) >= 0 Then
            Try
                Dim sTmp As String = Replace(splitData(2), MessageC, "")
                sTmp = sTmp.Replace(UnitC, "")
                sTmp = sTmp.Replace(vbLf, "")
                SeriesC = CDbl(sTmp)
            Catch ex As Exception
            End Try
        End If

        If splitData(3).IndexOf(MessageD) >= 0 Then
            Try
                Dim sTmp As String = Replace(splitData(3), MessageD, "")
                sTmp = sTmp.Replace(UnitD, "")
                sTmp = sTmp.Replace(vbLf, "")
                SeriesD = CDbl(sTmp)
            Catch ex As Exception
            End Try
        End If


        Dim dataPoint1 As DataPoint =
            New System.Windows.Forms.DataVisualization.Charting.DataPoint(elapsedTime, SeriesA)
        'データポイントを追加
        'constは指定できません。
        Me.Chart1.Series(0).Points.Add(dataPoint1)
        elapsedTime = elapsedTime + Timer1.Interval / 1000

        Dim dataPoint2 As DataPoint =
            New System.Windows.Forms.DataVisualization.Charting.DataPoint(elapsedTime, SeriesB)
        'データポイントを追加
        Me.Chart2.Series(0).Points.Add(dataPoint2)
        elapsedTime = elapsedTime + Timer1.Interval / 1000


        Dim dataPoint3 As DataPoint =
        New System.Windows.Forms.DataVisualization.Charting.DataPoint(elapsedTime, SeriesC)
        'データポイントを追加
        Me.Chart3.Series(0).Points.Add(dataPoint3)
        elapsedTime = elapsedTime + Timer1.Interval / 1000

        Dim dataPoint4 As DataPoint =
            New System.Windows.Forms.DataVisualization.Charting.DataPoint(elapsedTime, SeriesD)
        'データポイントを追加
        Me.Chart4.Series(0).Points.Add(dataPoint4)
        elapsedTime = elapsedTime + Timer1.Interval / 1000


        'https://dobon.net/vb/dotnet/control/tbscrolltolast.html
        'カレット位置を末尾に移動
        txtMessage.SelectionStart = txtMessage.Text.Length
        'テキストボックスにフォーカスを移動
        txtMessage.Focus()
        'カレット位置までスクロール
        txtMessage.ScrollToCaret()

    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Chart1

            .Series.Clear()

            'http://hanatyan.sakura.ne.jp/vb2005/vb2013chart02.htm#no2
            '
            '.BackColor = Color.Black
            .BorderSkin.SkinStyle = BorderSkinStyle.Emboss
            .BorderColor = Color.DarkGray
            .ChartAreas(0).BackColor = Color.Green
            .ChartAreas(0).BorderColor = Color.White
            .BorderDashStyle = ChartDashStyle.Solid
            .BorderWidth = 3
            'http://hanatyan.sakura.ne.jp/dotnet/chart11.htm


            .Series.Add(SeriesA)
            '折れ線グラフに設定.
            .Series(SeriesA).ChartType = SeriesChartType.Line
            'X軸
            .Series(SeriesA).XValueMember = SeriesA
            'Y軸
            .Series(SeriesA).YValueMembers = UnitA

            .Series(SeriesA).MarkerStyle = MarkerStyle.Circle
            .Series(SeriesA).Color = Color.White

            '凡例の位置
            'http://www.atmarkit.co.jp/fdotnet/dotnettips/1002aspchartlegend/aspchartlegend.html
            .Legends(0).BackColor = Color.DarkGray
            .Legends(0).Docking = Docking.Top


        End With

        With Chart2

            .Series.Clear()

            'http://hanatyan.sakura.ne.jp/vb2005/vb2013chart02.htm#no2
            '
            '.BackColor = Color.Black
            .BorderSkin.SkinStyle = BorderSkinStyle.Emboss
            .BorderColor = Color.DarkGray
            .ChartAreas(0).BackColor = Color.Green
            .ChartAreas(0).BorderColor = Color.White
            .BorderDashStyle = ChartDashStyle.Solid
            .BorderWidth = 3
            'http://hanatyan.sakura.ne.jp/dotnet/chart11.htm



            .Series.Add(SeriesB)
            '折れ線グラフに設定.
            .Series(SeriesB).ChartType = SeriesChartType.Line
            'X軸
            .Series(SeriesB).XValueMember = SeriesB
            'Y軸
            .Series(SeriesB).YValueMembers = UnitB

            .Series(SeriesB).MarkerStyle = MarkerStyle.Circle
            .Series(SeriesB).Color = Color.White

            .Legends(0).BackColor = Color.DarkGray
            .Legends(0).Docking = Docking.Top

        End With

        With Chart3

            .Series.Clear()

            'http://hanatyan.sakura.ne.jp/vb2005/vb2013chart02.htm#no2
            '
            '.BackColor = Color.Black
            .BorderSkin.SkinStyle = BorderSkinStyle.Emboss
            .BorderColor = Color.DarkGray
            .ChartAreas(0).BackColor = Color.Green
            .ChartAreas(0).BorderColor = Color.White
            .BorderDashStyle = ChartDashStyle.Solid
            .BorderWidth = 3
            'http://hanatyan.sakura.ne.jp/dotnet/chart11.htm



            .Series.Add(SeriesC)
            '折れ線グラフに設定.
            .Series(SeriesC).ChartType = SeriesChartType.Line
            'X軸
            .Series(SeriesC).XValueMember = SeriesC
            'Y軸
            .Series(SeriesC).YValueMembers = UnitC

            .Series(SeriesC).MarkerStyle = MarkerStyle.Circle
            .Series(SeriesC).Color = Color.White

            .Legends(0).BackColor = Color.DarkGray
            .Legends(0).Docking = Docking.Top

        End With

        With Chart4

            .Series.Clear()

            'http://hanatyan.sakura.ne.jp/vb2005/vb2013chart02.htm#no2
            '
            '.BackColor = Color.Black
            .BorderSkin.SkinStyle = BorderSkinStyle.Emboss
            .BorderColor = Color.DarkGray
            .ChartAreas(0).BackColor = Color.Green
            .ChartAreas(0).BorderColor = Color.White
            .BorderDashStyle = ChartDashStyle.Solid
            .BorderWidth = 3
            'http://hanatyan.sakura.ne.jp/dotnet/chart11.htm


            .Series.Add(SeriesD)
            '折れ線グラフに設定.
            .Series(SeriesD).ChartType = SeriesChartType.Line
            'X軸
            .Series(SeriesD).XValueMember = SeriesD
            'Y軸
            .Series(SeriesD).YValueMembers = UnitD

            .Series(SeriesD).MarkerStyle = MarkerStyle.Circle
            .Series(SeriesD).Color = Color.White

            .Legends(0).BackColor = Color.DarkGray
            .Legends(0).Docking = Docking.Top

        End With


    End Sub

End Class
