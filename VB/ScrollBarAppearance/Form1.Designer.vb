Imports Microsoft.VisualBasic
Imports System
Namespace ScrollBarAppearance
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel3 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(12))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(4))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(8))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(2))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (CObj(6))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("F", New Object() { (CObj(10))})
			Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint("G", New Object() { (CObj(7))})
			Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint("H", New Object() { (CObj(5))})
			Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint("I", New Object() { (CObj(9))})
			Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint("J", New Object() { (CObj(11))})
			Dim sideBySideBarSeriesLabel4 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			xyDiagram2.AxisX.Range.Auto = False
			xyDiagram2.AxisX.Range.MaxValueInternal = 8
			xyDiagram2.AxisX.Range.MinValueInternal = 4
			xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram2.AxisX.Range.SideMarginsEnabled = True
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram2.AxisY.Range.SideMarginsEnabled = True
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram2.EnableAxisXScrolling = True
			Me.chartControl1.Diagram = xyDiagram2
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			sideBySideBarSeriesLabel3.LineVisible = True
			sideBySideBarSeriesLabel3.Visible = False
			series2.Label = sideBySideBarSeriesLabel3
			series2.Name = "Series 1"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20})
			series2.SeriesID = 0
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
			sideBySideBarSeriesLabel4.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel4
			Me.chartControl1.Size = New System.Drawing.Size(284, 185)
			Me.chartControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 185)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

