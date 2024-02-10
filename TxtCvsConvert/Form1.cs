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
            string[] lines = { "������ ������", "������ ������", "������ ������" };

            // ���� � ��� �����
            string filePath = "txt_test.txt";

            // ������ ����� � ����
            File.WriteAllLines(filePath, lines);

            MessageBox.Show("������ ������� ��������� � ����.");
        }

        private void cvsConvert_Click(object sender, EventArgs e)
            
        {
            StringBuilder csvContent = new StringBuilder();

            // ���������� ���������
            csvContent.AppendLine("���,�������,�����");

            // ���������� ������
            csvContent.AppendLine("����,25,������");
            csvContent.AppendLine("�����,30,�����-���������");
            csvContent.AppendLine("�������,20,����");

            // ���� � ��� �����
            string filePath = "csv_test.csv";

            // ������ ����������� � ���� � ���������� UTF-8
            File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);

            MessageBox.Show("������ ������� ��������� � ����.");
        }
    }
}
