<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSerialRead = New System.Windows.Forms.Button()
        'Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        'Me.cbComPort = New System.Windows.Forms.ComboBox()
        Me.txtMessage = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        'Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(921, 406)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "閉じる(&C)"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSerialRead
        '
        Me.btnSerialRead.Location = New System.Drawing.Point(845, 406)
        Me.btnSerialRead.Name = "btnSerialRead"
        Me.btnSerialRead.Size = New System.Drawing.Size(75, 23)
        Me.btnSerialRead.TabIndex = 1
        Me.btnSerialRead.Text = "推移表示"
        Me.btnSerialRead.UseVisualStyleBackColor = True
        '
        'cbComPort
        '
        'Me.cbComPort.FormattingEnabled = True
        'Me.cbComPort.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6"})
        'Me.cbComPort.Location = New System.Drawing.Point(51, 12)
        'Me.cbComPort.Name = "cbComPort"
        'Me.cbComPort.Size = New System.Drawing.Size(121, 20)
        'Me.cbComPort.TabIndex = 2
        'Me.cbComPort.Text = "COM5"
        '
        'txtMessage
        '
        Me.txtMessage.BackColor = System.Drawing.Color.Black
        Me.txtMessage.ForeColor = System.Drawing.Color.White
        Me.txtMessage.Location = New System.Drawing.Point(12, 305)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(984, 84)
        Me.txtMessage.TabIndex = 3
        Me.txtMessage.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.DarkGray
        ChartArea9.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea9)
        Legend9.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend9)
        Me.Chart1.Location = New System.Drawing.Point(12, 38)
        Me.Chart1.Name = "Chart1"
        Series9.ChartArea = "ChartArea1"
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Me.Chart1.Series.Add(Series9)
        Me.Chart1.Size = New System.Drawing.Size(240, 261)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart1"
        '
        'Label1
        '
        'Me.Label1.AutoSize = True
        'Me.Label1.Location = New System.Drawing.Point(12, 12)
        'Me.Label1.Name = "Label1"
        'Me.Label1.Size = New System.Drawing.Size(33, 12)
        'Me.Label1.TabIndex = 5
        'Me.Label1.Text = "ポート"
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.DarkGray
        ChartArea10.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea10)
        Legend10.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend10)
        Me.Chart2.Location = New System.Drawing.Point(258, 38)
        Me.Chart2.Name = "Chart2"
        Series10.ChartArea = "ChartArea1"
        Series10.Legend = "Legend1"
        Series10.Name = "Series1"
        Me.Chart2.Series.Add(Series10)
        Me.Chart2.Size = New System.Drawing.Size(240, 261)
        Me.Chart2.TabIndex = 6
        Me.Chart2.Text = "Chart2"
        '
        'Chart3
        '
        Me.Chart3.BackColor = System.Drawing.Color.DarkGray
        ChartArea11.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea11)
        Legend11.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend11)
        Me.Chart3.Location = New System.Drawing.Point(504, 38)
        Me.Chart3.Name = "Chart3"
        Series11.ChartArea = "ChartArea1"
        Series11.Legend = "Legend1"
        Series11.Name = "Series1"
        Me.Chart3.Series.Add(Series11)
        Me.Chart3.Size = New System.Drawing.Size(240, 261)
        Me.Chart3.TabIndex = 7
        Me.Chart3.Text = "Chart3"
        '
        'Chart4
        '
        Me.Chart4.BackColor = System.Drawing.Color.DarkGray
        ChartArea12.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea12)
        Legend12.Name = "Legend1"
        Me.Chart4.Legends.Add(Legend12)
        Me.Chart4.Location = New System.Drawing.Point(750, 38)
        Me.Chart4.Name = "Chart4"
        Series12.ChartArea = "ChartArea1"
        Series12.Legend = "Legend1"
        Series12.Name = "Series1"
        Me.Chart4.Series.Add(Series12)
        Me.Chart4.Size = New System.Drawing.Size(240, 261)
        Me.Chart4.TabIndex = 8
        Me.Chart4.Text = "Chart4"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1008, 441)
        Me.Controls.Add(Me.Chart4)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        'Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.txtMessage)
        'Me.Controls.Add(Me.cbComPort)
        Me.Controls.Add(Me.btnSerialRead)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmMain"
        Me.Text = "リアルタイム価格推移表示ソフト"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSerialRead As System.Windows.Forms.Button
    'Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    'Friend WithEvents cbComPort As System.Windows.Forms.ComboBox
    Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    'Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart4 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
