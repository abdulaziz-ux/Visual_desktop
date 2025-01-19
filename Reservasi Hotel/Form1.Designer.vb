<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        txtelp = New TextBox()
        txnama = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        cbkamar = New ComboBox()
        Txtharga = New TextBox()
        Label6 = New Label()
        Label4 = New Label()
        GroupBox3 = New GroupBox()
        txlamainap = New DomainUpDown()
        txjmlorang = New DomainUpDown()
        tgl = New DateTimePicker()
        Label9 = New Label()
        Label7 = New Label()
        cbchecked = New GroupBox()
        rbtidak = New RadioButton()
        btntambah = New Button()
        rbya = New RadioButton()
        Cbd = New CheckBox()
        Cbl = New CheckBox()
        Cbb = New CheckBox()
        Label10 = New Label()
        Label8 = New Label()
        GroupBox5 = New GroupBox()
        other = New RadioButton()
        Rbcc = New RadioButton()
        RBcash = New RadioButton()
        GroupBox6 = New GroupBox()
        Label11 = New Label()
        Label5 = New Label()
        httambahan = New Label()
        Diskontotal = New Label()
        Buttonreset = New Button()
        Button3 = New Button()
        btninput = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        MenuToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        Datagriedview1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        viewjmlorang = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        cbchecked.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        CType(Datagriedview1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Snap ITC", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(334, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 19)
        Label1.TabIndex = 0
        Label1.Text = "HOTELLLLLL"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtelp)
        GroupBox1.Controls.Add(txnama)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(27, 84)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 125)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Pembeli"
        ' 
        ' txtelp
        ' 
        txtelp.Location = New Point(125, 80)
        txtelp.Name = "txtelp"
        txtelp.Size = New Size(125, 27)
        txtelp.TabIndex = 3
        ' 
        ' txnama
        ' 
        txnama.Location = New Point(125, 27)
        txnama.Name = "txnama"
        txnama.Size = New Size(125, 27)
        txnama.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 1
        Label3.Text = "No Telp"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 20)
        Label2.TabIndex = 0
        Label2.Text = "Nama Pembeli"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbkamar)
        GroupBox2.Controls.Add(Txtharga)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(27, 247)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(250, 149)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Detail Kamar"
        ' 
        ' cbkamar
        ' 
        cbkamar.FormattingEnabled = True
        cbkamar.Items.AddRange(New Object() {"Standar", "Deluxe", "Junior Suite", "Executive"})
        cbkamar.Location = New Point(128, 35)
        cbkamar.Name = "cbkamar"
        cbkamar.Size = New Size(116, 28)
        cbkamar.TabIndex = 11
        ' 
        ' Txtharga
        ' 
        Txtharga.Location = New Point(125, 110)
        Txtharga.Name = "Txtharga"
        Txtharga.Size = New Size(125, 27)
        Txtharga.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 110)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 20)
        Label6.TabIndex = 8
        Label6.Text = "Harga"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 2
        Label4.Text = "Jenis Kamar"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txlamainap)
        GroupBox3.Controls.Add(txjmlorang)
        GroupBox3.Controls.Add(tgl)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Location = New Point(295, 84)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(321, 125)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Detail Pemesanan"
        ' 
        ' txlamainap
        ' 
        txlamainap.Location = New Point(154, 70)
        txlamainap.Name = "txlamainap"
        txlamainap.Size = New Size(64, 27)
        txlamainap.TabIndex = 14
        ' 
        ' txjmlorang
        ' 
        txjmlorang.Location = New Point(154, 23)
        txjmlorang.Name = "txjmlorang"
        txjmlorang.Size = New Size(64, 27)
        txjmlorang.TabIndex = 11
        txjmlorang.Text = "0"
        ' 
        ' tgl
        ' 
        tgl.Location = New Point(6, 98)
        tgl.Name = "tgl"
        tgl.Size = New Size(244, 27)
        tgl.TabIndex = 10
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 72)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 20)
        Label9.TabIndex = 9
        Label9.Text = "Lama Inap"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 20)
        Label7.TabIndex = 7
        Label7.Text = "Jumlah Orang"
        ' 
        ' cbchecked
        ' 
        cbchecked.Controls.Add(rbtidak)
        cbchecked.Controls.Add(btntambah)
        cbchecked.Controls.Add(rbya)
        cbchecked.Controls.Add(Cbd)
        cbchecked.Controls.Add(Cbl)
        cbchecked.Controls.Add(Cbb)
        cbchecked.Controls.Add(Label10)
        cbchecked.Controls.Add(Label8)
        cbchecked.Location = New Point(301, 247)
        cbchecked.Name = "cbchecked"
        cbchecked.Size = New Size(327, 149)
        cbchecked.TabIndex = 4
        cbchecked.TabStop = False
        cbchecked.Text = "Fasilitas Tambahan"
        ' 
        ' rbtidak
        ' 
        rbtidak.AutoSize = True
        rbtidak.Location = New Point(189, 80)
        rbtidak.Name = "rbtidak"
        rbtidak.Size = New Size(72, 24)
        rbtidak.TabIndex = 15
        rbtidak.TabStop = True
        rbtidak.Text = "TIDAK"
        rbtidak.UseVisualStyleBackColor = True
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(221, 110)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(94, 29)
        btntambah.TabIndex = 7
        btntambah.Text = "Tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' rbya
        ' 
        rbya.AutoSize = True
        rbya.Location = New Point(136, 80)
        rbya.Name = "rbya"
        rbya.Size = New Size(47, 24)
        rbya.TabIndex = 13
        rbya.TabStop = True
        rbya.Text = "YA"
        rbya.UseVisualStyleBackColor = True
        ' 
        ' Cbd
        ' 
        Cbd.AutoSize = True
        Cbd.Location = New Point(246, 34)
        Cbd.Name = "Cbd"
        Cbd.Size = New Size(75, 24)
        Cbd.TabIndex = 12
        Cbd.Text = "Dinner"
        Cbd.UseVisualStyleBackColor = True
        ' 
        ' Cbl
        ' 
        Cbl.AutoSize = True
        Cbl.Location = New Point(180, 34)
        Cbl.Name = "Cbl"
        Cbl.Size = New Size(69, 24)
        Cbl.TabIndex = 11
        Cbl.Text = "Lunch"
        Cbl.UseVisualStyleBackColor = True
        ' 
        ' Cbb
        ' 
        Cbb.AutoSize = True
        Cbb.Location = New Point(91, 36)
        Cbb.Name = "Cbb"
        Cbb.Size = New Size(92, 24)
        Cbb.TabIndex = 10
        Cbb.Text = "Breakfast"
        Cbb.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 86)
        Label10.Name = "Label10"
        Label10.Size = New Size(114, 20)
        Label10.TabIndex = 9
        Label10.Text = "kasur tambahan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 38)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 20)
        Label8.TabIndex = 8
        Label8.Text = "makanan"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(other)
        GroupBox5.Controls.Add(Rbcc)
        GroupBox5.Controls.Add(RBcash)
        GroupBox5.Location = New Point(668, 84)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(250, 125)
        GroupBox5.TabIndex = 5
        GroupBox5.TabStop = False
        GroupBox5.Text = "Metode Pembayaran"
        ' 
        ' other
        ' 
        other.AutoSize = True
        other.Location = New Point(6, 83)
        other.Name = "other"
        other.Size = New Size(67, 24)
        other.TabIndex = 18
        other.TabStop = True
        other.Text = "Other"
        other.UseVisualStyleBackColor = True
        ' 
        ' Rbcc
        ' 
        Rbcc.AutoSize = True
        Rbcc.Location = New Point(6, 47)
        Rbcc.Name = "Rbcc"
        Rbcc.Size = New Size(105, 24)
        Rbcc.TabIndex = 17
        Rbcc.TabStop = True
        Rbcc.Text = "Credit Cash"
        Rbcc.UseVisualStyleBackColor = True
        ' 
        ' RBcash
        ' 
        RBcash.AutoSize = True
        RBcash.Location = New Point(6, 17)
        RBcash.Name = "RBcash"
        RBcash.Size = New Size(61, 24)
        RBcash.TabIndex = 16
        RBcash.TabStop = True
        RBcash.Text = "Cash"
        RBcash.UseVisualStyleBackColor = True
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(Label11)
        GroupBox6.Controls.Add(Label5)
        GroupBox6.Controls.Add(httambahan)
        GroupBox6.Controls.Add(Diskontotal)
        GroupBox6.Location = New Point(668, 247)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(250, 125)
        GroupBox6.TabIndex = 6
        GroupBox6.TabStop = False
        GroupBox6.Text = "Total Harga"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(25, 86)
        Label11.Name = "Label11"
        Label11.Size = New Size(42, 20)
        Label11.TabIndex = 11
        Label11.Text = "Total"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 20)
        Label5.TabIndex = 10
        Label5.Text = "Diskon Total"
        ' 
        ' httambahan
        ' 
        httambahan.AutoSize = True
        httambahan.Location = New Point(109, 80)
        httambahan.Name = "httambahan"
        httambahan.Size = New Size(18, 20)
        httambahan.TabIndex = 9
        httambahan.Text = "..."
        ' 
        ' Diskontotal
        ' 
        Diskontotal.AutoSize = True
        Diskontotal.Location = New Point(109, 23)
        Diskontotal.Name = "Diskontotal"
        Diskontotal.Size = New Size(15, 20)
        Diskontotal.TabIndex = 8
        Diskontotal.Text = ".."
        ' 
        ' Buttonreset
        ' 
        Buttonreset.Location = New Point(668, 393)
        Buttonreset.Name = "Buttonreset"
        Buttonreset.Size = New Size(94, 29)
        Buttonreset.TabIndex = 8
        Buttonreset.Text = "Reset"
        Buttonreset.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(777, 393)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 9
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btninput
        ' 
        btninput.Location = New Point(893, 393)
        btninput.Name = "btninput"
        btninput.Size = New Size(94, 29)
        btninput.TabIndex = 10
        btninput.Text = "Input"
        btninput.UseVisualStyleBackColor = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(116, 28)
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(115, 24)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(116, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(27, 429)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(891, 125)
        Panel1.TabIndex = 12
        ' 
        ' Datagriedview1
        ' 
        Datagriedview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Datagriedview1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column4, viewjmlorang, Column5, Column6, Column7, Column3})
        Datagriedview1.Location = New Point(30, 429)
        Datagriedview1.Name = "Datagriedview1"
        Datagriedview1.RowHeadersWidth = 51
        Datagriedview1.Size = New Size(1055, 188)
        Datagriedview1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Nama"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "No telp"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Jkamar"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' viewjmlorang
        ' 
        viewjmlorang.HeaderText = "Jml orang"
        viewjmlorang.MinimumWidth = 6
        viewjmlorang.Name = "viewjmlorang"
        viewjmlorang.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Lama menginap"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "metode pembayaran"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Total"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Tanggal"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        BackgroundImage = My.Resources.Resources.hotel
        ClientSize = New Size(1234, 566)
        Controls.Add(Datagriedview1)
        Controls.Add(Panel1)
        Controls.Add(btninput)
        Controls.Add(Button3)
        Controls.Add(Buttonreset)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox5)
        Controls.Add(cbchecked)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        cbchecked.ResumeLayout(False)
        cbchecked.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        CType(Datagriedview1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbchecked As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tgl As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Cbb As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Cbl As CheckBox
    Friend WithEvents rbtidak As RadioButton
    Friend WithEvents rbya As RadioButton
    Friend WithEvents Cbd As CheckBox
    Friend WithEvents other As RadioButton
    Friend WithEvents Rbcc As RadioButton
    Friend WithEvents RBcash As RadioButton
    Friend WithEvents Diskontotal As Label
    Friend WithEvents btntambah As Button
    Friend WithEvents httambahan As Label
    Friend WithEvents Buttonreset As Button
    Friend WithEvents txtelp As TextBox
    Friend WithEvents txnama As TextBox
    Friend WithEvents Txtharga As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btninput As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbkamar As ComboBox
    Friend WithEvents txjmlorang As DomainUpDown
    Friend WithEvents Datagriedview1 As DataGridView
    Friend WithEvents txlamainap As DomainUpDown
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents viewjmlorang As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label

End Class
