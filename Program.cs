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
                Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

                string errorMessage;
                if (DbConnectionHelper.TestConnection(out errorMessage))
                {
                    Console.WriteLine("Database connection successful. Starting application...");
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                else
                {
                    MessageBox.Show(
                        $"Gagal terhubung ke database.\nDetail: {errorMessage}\n\nPeriksa konfigurasi database Anda.",
                        "Koneksi Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    Environment.Exit(1);
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Startup Exception: {ex}");
                MessageBox.Show(
                    $"Terjadi kesalahan saat memulai aplikasi:\n{ex.Message}",
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Environment.Exit(2);
            }
        }
    }
}
