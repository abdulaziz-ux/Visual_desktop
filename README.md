# Sistem_Pemesanan_Hotel

![image](https://github.com/user-attachments/assets/b4b38add-b945-4c58-932c-ce36fa6238b3)


- Detail Aplikasi

1. Data Pembeli
Nama Pembeli: Input untuk mengisi nama pelanggan.
No Telp: Input untuk memasukkan nomor telepon pelanggan.
2. Detail Kamar
Jenis Kamar: Pilihan jenis kamar (misalnya, "Deluxe").
Harga: Harga kamar sesuai dengan jenis yang dipilih.
3. Detail Pemesanan
Jumlah Orang: Input untuk jumlah orang yang menginap.
Lama Inap: Berapa malam pelanggan akan menginap.
Tanggal Check-in: Pilihan tanggal check-in pelanggan.
4. Fasilitas Tambahan
Makanan: Pilihan makanan seperti sarapan (Breakfast), makan siang (Lunch), atau makan malam (Dinner).
Kasur Tambahan: Pilihan untuk kasur tambahan, dengan opsi "YA" atau "TIDAK".
5. Metode Pembayaran
Pilihan metode pembayaran: Cash, Credit Cash, atau metode lain.
6. Total Harga
Diskon Total: Menampilkan diskon yang diberikan (jika ada).
Total: Total biaya yang harus dibayarkan pelanggan setelah diskon.
7. Tabel Data Pemesanan
Menampilkan data pemesanan yang sudah ditambahkan, termasuk kolom seperti:
Nama pelanggan.
Nomor telepon.
Jenis kamar.
Jumlah orang.
Lama menginap.
Metode pembayaran.
Total biaya.
Tanggal check-in.
8. Tombol Operasi
Tambah: Menambahkan data pemesanan ke tabel.
Reset: Menghapus data yang diisi pada form untuk menginput ulang.
Hapus: Menghapus data tertentu yang sudah ada di tabel.
Input: Menyimpan data ke tabel atau sistem.
Fungsi Utama Sistem
Sistem ini dirancang untuk membantu proses pemesanan kamar hotel secara cepat dan terstruktur, dengan memudahkan penginputan data pelanggan, menghitung total biaya termasuk diskon dan tambahan fasilitas, serta menyimpan data ke dalam tabel untuk pencatatan.












Source Code







                                                                  Public Class Form1
                                                                      Private hargakamar, dinner, lunch, breakfast, jmlorang, tmbahan, total, diskon, lamainap, hf, tdiskon As Double
                                                                      Dim fasilitas, methodpembayaran As String
                                                                      Private Sub cbkamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkamar.SelectedIndexChanged
                                                                          Select Case cbkamar.Text
                                                                              Case "Standar"
                                                                                  hargakamar = 75000
                                                                              Case "Deluxe"
                                                                                  hargakamar = 125000
                                                                              Case "Junior Suite"
                                                                                  hargakamar = 700000
                                                                              Case "Executive"
                                                                                  hargakamar = 1250000
                                                                          End Select
                                                                          Txtharga.Text = hargakamar.ToString()
                                                                      End Sub
                                                                      Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles cbchecked.Enter
                                                                  
                                                                      End Sub
                                                                  
                                                                      Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
                                                                  
                                                                      End Sub
                                                                  
                                                                      Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btntambah.Click
                                                                          If Cbb.Checked Then
                                                            breakfast = 20000
                                                            fasilitas = "b"
                                                        Else
                                                            breakfast = 0
                                                        End If
                                                
                                                        If Cbl.Checked Then
                                                            lunch = 25000
                                                            fasilitas = "l"
                                                        Else
                                                            lunch = 0
                                                        End If
                                                
                                                        If Cbd.Checked Then
                                                            dinner = 20000
                                                            fasilitas = "d"
                                                        Else
                                                            dinner = 0
                                                        End If
                                                
                                                        If rbya.Checked Then
                                                            tmbahan = 50000
                                                            fasilitas = "bed"
                                                        Else
                                                            tmbahan = 0
                                                        End If
                                                        hf = tmbahan + breakfast + lunch + dinner
                                                        httambahan.Text = "Rp." + hf.ToString
                                                    End Sub
                                                
                                                    Private Sub proses_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninput.Click
                                                        jmlorang = txjmlorang.Text
                                                        lamainap = txlamainap.Text
                                                
                                                        total = (hargakamar + hf) * jmlorang * lamainap
                                                
                                                        If RBcash.Checked Then
                                                            diskon = 0
                                                            methodpembayaran = "Cash"
                                                        ElseIf Rbcc.Checked Then
                                                            diskon = 0.1 * total
                                                            methodpembayaran = "CreditCash"
                                                        ElseIf other.Checked Then
                                                            diskon = 0
                                                            methodpembayaran = "Other"
                                                        End If
                                                
                                                        tdiskon = diskon
                                                        total -= tdiskon
                                                        Diskontotal.Text = tdiskon.ToString
                                                        httambahan.Text = total.ToString
                                                    End Sub
                                                
                                                    Private Sub input_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninput.Click
                                                        Datagriedview1.Rows.Add(1)
                                                        Dim newRow As Integer = Datagriedview1.RowCount - 2
                                                
                                                        Datagriedview1.Rows(newRow).Cells(0).Value = txnama.Text
                                                        Datagriedview1.Rows(newRow).Cells(1).Value = txtelp.Text
                                                        Datagriedview1.Rows(newRow).Cells(2).Value = cbkamar.Text
                                                        Datagriedview1.Rows(newRow).Cells(3).Value = txjmlorang.Text
                                                        Datagriedview1.Rows(newRow).Cells(4).Value = txlamainap.Text
                                                        Datagriedview1.Rows(newRow).Cells(5).Value = methodpembayaran.ToString
                                                        Datagriedview1.Rows(newRow).Cells(6).Value = total.ToString
                                                        Datagriedview1.Rows(newRow).Cells(7).Value = tgl.Value.ToString("dd/MM/yyyy") ' Format tanggal
                                                
                                                    End Sub
                                                
                                                    Private Sub ExitToolStripMenuItem_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
                                                
                                                    End Sub
                                                
                                                    Private Sub button1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonreset.Click
                                                        txnama.Text = ""
                                                        txtelp.Text = ""
                                                        Txtharga.Text = ""
                                                        txjmlorang.Text = ""
                                                        txlamainap.Text = ""
                                                        cbkamar.Text = ""
                                                        cbkamar.Text = ""
                                                    End Sub
                                                
                                                    Private Sub txtelp_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtelp.KeyPress
                                                        ' Periksa apakah karakter yang dimasukkan adalah angka, backspace, atau delete
                                                        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                                                            ' Jika bukan, batalkan input
                                                            e.Handled = True
                                                        End If
                                                    End Sub
                                                    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
                                                        ' Cek apakah ada baris yang dipilih
                                                        If Datagriedview1.SelectedRows.Count > 0 Then
                                                            ' Hapus baris yang dipilih
                                                            For Each row As DataGridViewRow In Datagriedview1.SelectedRows
                                                                If Not row.IsNewRow Then
                                                                    Datagriedview1.Rows.Remove(row)
                                                                End If
                                                            Next
                                                        Else
                                                            MessageBox.Show("Pilih baris yang akan dihapus terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                        End If
                                                    End Sub
                                                
                                                End Class
                                                
                                                
