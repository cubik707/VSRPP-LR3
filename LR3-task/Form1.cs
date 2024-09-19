namespace LR3_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                listBoxItems.Items.Add(textBoxInput.Text);
                textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Введите текст для добавления.");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null && !string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                int selectedIndex = listBoxItems.SelectedIndex;
                listBoxItems.Items[selectedIndex] = textBoxInput.Text;
                textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Выберите элемент для редактирования и введите новый текст.");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                listBoxItems.Items.Remove(listBoxItems.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления.");
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchText = textBoxInput.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                listBoxItems.ClearSelected();
                for (int i = 0; i < listBoxItems.Items.Count; i++)
                {
                    if (listBoxItems.Items[i].ToString().Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    {
                        listBoxItems.SetSelected(i, true);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите текст для поиска.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxItems.Items.AddRange(new string[] { "Яблоко", "Банан", "Вишня", "Финик", "Бузина" });

        }
    }
}
