Imports System.Windows.Forms.Design
Imports System.Windows.Forms.VisualStyles
<ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)>
Partial Public Class ToolStripCheckBox
    Inherits ToolStripItem

    Friend WithEvents CheckBox1 As CheckBox
    Dim _IsChecked As Boolean

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If MyBase.Owner IsNot Nothing Then
            Dim pLocation As Point = New Point(e.ClipRectangle.X, e.ClipRectangle.Height / 2 - (13 / 2))
            Dim txtSize As Size = TextRenderer.MeasureText(Me.Text, Me.Font)
            Dim rectText As Rectangle = New Rectangle(pLocation.X + 13, pLocation.Y, txtSize.Width, txtSize.Height)
            Dim chkState As CheckBoxState = If(IsChecked, CheckBoxState.CheckedNormal, CheckBoxState.UncheckedNormal)
            CheckBoxRenderer.DrawCheckBox(e.Graphics, pLocation, rectText, Me.Text, Me.Font, False, chkState)
        End If
    End Sub

    Public Overrides Function GetPreferredSize(constrainingSize As Size) As Size
        MyBase.GetPreferredSize(constrainingSize)
        Dim preferredSize As Size = MyBase.GetPreferredSize(constrainingSize)
        preferredSize.Width += 13
        Return preferredSize
    End Function

    Public Property IsChecked As Boolean
        Get
            Return _IsChecked
        End Get
        Set(value As Boolean)
            _IsChecked = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnClick(e As EventArgs)
        IsChecked = Not IsChecked
        MyBase.OnClick(e)
    End Sub

    Private Sub InitializeComponent()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(0, 0)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True

    End Sub
End Class