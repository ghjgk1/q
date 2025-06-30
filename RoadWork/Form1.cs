using RoadLibrary;

namespace RoadWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateWorksLists();
        }

        private void UpdateWorksLists()
        {
            listBoxBaseWorks.Items.Clear();
            listBoxExtendedWorks.Items.Clear();

            foreach (var work in RoadWorks.Works)
            {
                if (work is ExtendedRoadWork extendedWork)
                {
                    listBoxExtendedWorks.Items.Add(extendedWork.GetInfo());
                }
                else
                {
                    listBoxBaseWorks.Items.Add(work.GetInfo());
                }
            }
        }

        private void btnAddBase_Click(object sender, EventArgs e)
        {
            try
            {
                double width = double.Parse(txtWidth.Text);
                double length = double.Parse(txtLength.Text);
                double mass = double.Parse(txtMass.Text);

                var work = new RoadWorks(width, length, mass);
                RoadWorks.Works.Add(work);
                UpdateWorksLists();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddExtended_Click(object sender, EventArgs e)
        {
            try
            {
                double width = double.Parse(txtWidth.Text);
                double length = double.Parse(txtLength.Text);
                double mass = double.Parse(txtMass.Text);
                int month = int.Parse(txtMonth.Text);

                if (month <= 0 || month > 12)
                    throw new ArgumentException("Номер месяца должен быть от 1 до 12");

                var work = new ExtendedRoadWork(width, length, mass, month);
                RoadWorks.Works.Add(work);
                UpdateWorksLists();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveSelectedBase_Click(object sender, EventArgs e)
        {
            if (listBoxBaseWorks.SelectedIndex != -1)
            {
                int selectedIndex = listBoxBaseWorks.SelectedIndex;
                var worksToRemove = new List<RoadWorks>();

                foreach (var item in listBoxBaseWorks.SelectedItems)
                {
                    string info = item.ToString();
                    var work = RoadWorks.Works.Find(w => w.GetInfo() == info);
                    if (work != null) worksToRemove.Add(work);
                }

                RoadWorks.RemoveWorks(worksToRemove);
                UpdateWorksLists();
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveSelectedExtended_Click(object sender, EventArgs e)
        {
            if (listBoxExtendedWorks.SelectedIndex != -1)
            {
                int selectedIndex = listBoxExtendedWorks.SelectedIndex;
                var worksToRemove = new List<RoadWorks>();

                foreach (var item in listBoxExtendedWorks.SelectedItems)
                {
                    string info = item.ToString();
                    var work = RoadWorks.Works.Find(w => w.GetInfo() == info);
                    if (work != null) worksToRemove.Add(work);
                }

                RoadWorks.RemoveWorks(worksToRemove);
                UpdateWorksLists();
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearInputs()
        {
            txtWidth.Clear();
            txtLength.Clear();
            txtMass.Clear();
            txtMonth.Clear();
        }

        private void btnCalculateQBase_Click(object sender, EventArgs e)
        {
            if (listBoxBaseWorks.SelectedIndex != -1)
            {
                string info = listBoxBaseWorks.SelectedItem.ToString();
                var selectedWork = RoadWorks.Works.Find(w => w.GetInfo() == info);
                double q = selectedWork.CalculateQ();
                MessageBox.Show($"Качество объекта: {q:F2}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите элемент для расчета", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCalculateQExtended_Click(object sender, EventArgs e)
        {
            if (listBoxExtendedWorks.SelectedIndex != -1)
            {
                string info = listBoxExtendedWorks.SelectedItem.ToString();
                var selectedWork = RoadWorks.Works.Find(w => w.GetInfo() == info);
                double q = selectedWork.CalculateQ();
                MessageBox.Show($"Качество объекта: {q:F2}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите элемент для расчета", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
