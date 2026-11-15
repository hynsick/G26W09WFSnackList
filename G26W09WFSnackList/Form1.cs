namespace G26W09WFSnackList;

public partial class Form1 : Form
{
    private SnackDatabaseSet SnackStore = new(); // (2)

    public Form1()
    {
        InitializeComponent();

        SnackStore.Database.EnsureCreated(); // (3)

        if (!SnackStore.Tuples.Any())
            SnackStore.AddInitSnack();

        ExecuteQuery();
    }

    // 검색어 변경 이벤트
    private void ApplyFilter(object sender, EventArgs e) // (4)
    {
        ExecuteQuery();
    }

    // 데이터 검색 및 목록 출력
    private void ExecuteQuery() // (5)
    {
        mainContainer.Items.Clear();

        string keyword = filterText.Text.Trim().ToLower();

        var filteredResult = SnackStore.Tuples
            .Where(item =>
                item.Name.ToLower().Contains(keyword) ||
                item.Reason.ToLower().Contains(keyword))
            .ToList(); // (6), (7)

        foreach (var item in filteredResult) // (8), (9)
        {
            mainContainer.Items.Add(item);
        }
    }

    // 선택한 야식 이미지 출력
    private void ShowImage(object sender, EventArgs e) // (10)
    {
        if (mainContainer.SelectedItem is not Snack selected) // (11)
        {
            dropAction.Enabled = false;
            imageRenderer.Image = null;
            return;
        }

        dropAction.Enabled = true;

        if (string.IsNullOrEmpty(selected.Image))
        {
            imageRenderer.Image = null;
            return;
        }

        imageRenderer.LoadAsync(selected.Image);
    }

    // 야식 추가
    private void InsertSnack(object sender, EventArgs e) // (12)
    {
        string title = titleField.Text.Trim();
        string reason = descField.Text.Trim();
        string image = linkField.Text.Trim();

        if (string.IsNullOrEmpty(image))
            image = "";

        if (title.Length == 0 || reason.Length == 0)
        {
            MessageBox.Show("야식 이름과 원인(또는 평가)를 입력하세요.");
            return;
        }

        SnackStore.Tuples.Add(new Snack(title, reason, image)); // (13)
        SnackStore.SaveChanges(); // (14)

        ExecuteQuery();

        titleField.Clear();
        descField.Clear();
        linkField.Clear();
    }

    // 야식 삭제
    private void DeleteSnack(object sender, EventArgs e) // (15)
    {
        if (mainContainer.SelectedItem is not Snack outcast) // (11)
        {
            dropAction.Enabled = false;
            return;
        }

        var result = MessageBox.Show(
            $"{outcast.Name}\n\n야식을 삭제할까요?", // (16)
            "삭제 확인",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result != DialogResult.Yes)
            return;

        SnackStore.Tuples.Remove(outcast); // (17), (16)
        SnackStore.SaveChanges(); // (14)

        ExecuteQuery();

        dropAction.Enabled = false;
    }
}