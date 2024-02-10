using System.IO;
using System.Text;

namespace TxtCvsConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtConvert_Click(object sender, EventArgs e)
        {
            string[] lines = { "Первая строка", "Вторая строка", "Третья строка" };

            // Путь и имя файла
            string filePath = "txt_test.txt";

            // Запись строк в файл
            File.WriteAllLines(filePath, lines);

            MessageBox.Show("Данные успешно сохранены в файл.");
        }

        private void cvsConvert_Click(object sender, EventArgs e)
            
        {
            StringBuilder csvContent = new StringBuilder();

            // Добавление заголовка
            csvContent.AppendLine("Имя,Возраст,Город");

            // Добавление данных
            csvContent.AppendLine("Иван,25,Москва");
            csvContent.AppendLine("Мария,30,Санкт-Петербург");
            csvContent.AppendLine("Алексей,20,Киев");

            // Путь и имя файла
            string filePath = "csv_test.csv";

            // Запись содержимого в файл с кодировкой UTF-8
            File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);

            MessageBox.Show("Данные успешно сохранены в файл.");
        }
    }
}
