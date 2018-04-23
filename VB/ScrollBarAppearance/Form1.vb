Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace ScrollBarAppearance
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim diagram As XYDiagram = CType(chartControl1.Diagram, XYDiagram)
			diagram.EnableAxisXScrolling = True
			diagram.EnableAxisYScrolling = True
			diagram.EnableAxisXZooming = True
			diagram.EnableAxisYZooming = True
			Dim scrollBarOptions As ScrollBarOptions = diagram.DefaultPane.ScrollBarOptions
			scrollBarOptions.BackColor = Color.White
			scrollBarOptions.BarColor = Color.Blue
			scrollBarOptions.BorderColor = Color.Navy
			scrollBarOptions.BarThickness = 15
			scrollBarOptions.XAxisScrollBarAlignment = ScrollBarAlignment.Far
			scrollBarOptions.XAxisScrollBarVisible = True
		End Sub
	End Class
End Namespace