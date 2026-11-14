using G26W09WFSnackList;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace G26W09WFSnackList;

public partial class Form1 : Form
{
    private Database(2)                    = new (); // new에 클래스 이름 생략 가능

    public Form1()
    {
        InitializeComponent();

        SnackStore.(3)(); // 데이터베이스 없으면 자동 생성

        if (!SnackStore.Tuples.Any())
            SnackStore.AddInitSnack();

        ExecuteQuery();
    }

    private void (4)                          (object sender, EventArgs e) {
        ExecuteQuery();
    }

private void (5)                                                      () {
        mainContainer.Items.Clear();

        string keyword = filterText.Text.Trim();

var filteredResult = SnackStore.Tuples
    .(6)(item => item.Name.ToLower().Contains(keyword) ||
            item.Reason.ToLower().Contains(keyword))
    .(7)();

(8)                    (var (9)                     in filteredResult)
            mainContainer.Items.Add(item);
    }

    private void (10)(object sender, EventArgs e) {
    if (mainContainer.SelectedItem(11)            not Snack selected) {
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

private void (12)(object sender, EventArgs e) {
    string title = titleField.Text.Trim();
    string reason = descField.Text.Trim();
    string image = linkField.Text.Trim();
    if (string.IsNullOrEmpty(image)) image = "";

    if (title.Length == 0 || reason.Length == 0)
    {
        MessageBox.Show("야식 이름과 원인(또는 평가)를 입력하세요.");
        return;
    }

    SnackStore.Tuples.(13)(new Snack(title, reason, image));
    SnackStore.(14)();

    ExecuteQuery();

    titleField.Clear();
    descField.Clear();
    linkField.Clear();
}

private void (15)(object sender, EventArgs e) {
    if (mainContainer.SelectedItem(11) not Snack outcast) {
        dropAction.Enabled = false;
        return;
    }

    var result = MessageBox.Show(
            $"{(16).Name}\n\n야식을 삭제할까요?",
            "삭제 확인",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

    if (result != DialogResult.Yes)
        return;

    SnackStore.Tuples.(17)((16));
    SnackStore.(14)();

    ExecuteQuery();

    dropAction.Enabled = false;
}
}