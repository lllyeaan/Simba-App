using MaterialOrderingApp.Forms;
using MaterialOrderingApp.Repositories; 
using System;
using System.Windows.Forms;

namespace Project_PBO
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                if (DbConnectionHelper.TestConnection())
                {
                    Console.WriteLine("Database connection successful. Starting application...");
                    ApplicationConfiguration.Initialize();
                    Application.Run(new MainForm());
                }
                else
                {
                    MessageBox.Show("Gagal terhubung ke database. Periksa konfigurasi database Anda.",
                                    "Koneksi Gagal",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memulai aplikasi: {ex.Message}",
                                "Kesalahan",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}