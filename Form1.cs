using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string FormatSizeInKb(long bytes) => $"{(bytes + 1023) / 1024:N0} KB";

        private void PopulateListView(ListView lv, string folderPath)
        {
            lv.BeginUpdate();
            lv.Items.Clear();

            try
            {
                if (!Directory.Exists(folderPath)) return;

                string comparePath = (lv == lvwLeftDir) ? txtRightDir.Text : txtLeftDir.Text;
                var compareFiles = Directory.Exists(comparePath)
                    ? Directory.EnumerateFiles(comparePath).Select(p => new FileInfo(p)).ToDictionary(f => f.Name)
                    : new Dictionary<string, FileInfo>();

                // 폴더 추가 로직 (생략 가능, 파일 비교에 집중)
                foreach (var f in Directory.EnumerateFiles(folderPath).Select(p => new FileInfo(p)).OrderBy(f => f.Name))
                {
                    var litem = new ListViewItem(f.Name);
                    litem.SubItems.Add(FormatSizeInKb(f.Length));
                    litem.SubItems.Add(f.LastWriteTime.ToString("g"));

                    if (compareFiles.TryGetValue(f.Name, out var rf))
                    {
                        if (f.LastWriteTime == rf.LastWriteTime) litem.ForeColor = Color.Black;
                        else if (f.LastWriteTime > rf.LastWriteTime) litem.ForeColor = Color.Red;
                        else litem.ForeColor = Color.Gray;
                    }
                    else litem.ForeColor = Color.Purple;

                    lv.Items.Add(litem);
                }

                for (int i = 0; i < lv.Columns.Count; i++)
                    lv.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            finally { lv.EndUpdate(); }
        }

        // 과제 3: 왼쪽에서 오른쪽으로 복사 (>>> 버튼) 
        private void btnCopyFromLeft_Click(object sender, EventArgs e)
        {
            var selected = lvwLeftDir.SelectedItems.Cast<ListViewItem>();
            var leftFiles = Directory.EnumerateFiles(txtLeftDir.Text).Select(p => new FileInfo(p)).ToDictionary(f => f.Name);

            foreach (var item in selected)
            {
                var name = item.Text;
                if (!leftFiles.TryGetValue(name, out var src)) continue;

                var destPath = Path.Combine(txtRightDir.Text, src.Name);
                CopyFileWithConfirmation(src, destPath);
            }
            RefreshLists();
        }

        // 과제 3: 오른쪽에서 왼쪽으로 복사 (<<< 버튼)
        private void btnCopyFromRight_Click(object sender, EventArgs e)
        {
            var selected = lvwRightDir.SelectedItems.Cast<ListViewItem>();
            var rightFiles = Directory.EnumerateFiles(txtRightDir.Text).Select(p => new FileInfo(p)).ToDictionary(f => f.Name);

            foreach (var item in selected)
            {
                var name = item.Text;
                if (!rightFiles.TryGetValue(name, out var src)) continue;

                var destPath = Path.Combine(txtLeftDir.Text, src.Name);
                CopyFileWithConfirmation(src, destPath);
            }
            RefreshLists();
        }

        // 과제 3 핵심: 덮어쓰기 확인 로직 
        private void CopyFileWithConfirmation(FileInfo src, string destPath)
        {
            if (File.Exists(destPath))
            {
                FileInfo dest = new FileInfo(destPath);
               // 대상 파일이 더 신규 파일인 경우 확인창 출력 
                if (dest.LastWriteTime > src.LastWriteTime)
                {
                    string msg = $"대상에 동일한 이름의 파일이 이미 있습니다.\n" +
                                 $"대상 파일이 더 신규 파일입니다. 덮어쓰시겠습니까?\n\n" +
                                 $"원본: {src.FullName} ({src.LastWriteTime})\n" +
                                 $"대상: {dest.FullName} ({dest.LastWriteTime})";

                    if (MessageBox.Show(this, msg, "덮어쓰기 확인",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return; // 아니요 선택 시 복사 중단
                    }
                }
            }
            File.Copy(src.FullName, destPath, true); // 복사 진행 (덮어쓰기 허용) 
        }

        private void RefreshLists()
        {
            PopulateListView(lvwLeftDir, txtLeftDir.Text);
            PopulateListView(lvwRightDir, txtRightDir.Text);
        }

        private void btnLeftDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
                if (dlg.ShowDialog() == DialogResult.OK) { txtLeftDir.Text = dlg.SelectedPath; RefreshLists(); }
        }

        private void btnRightDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
                if (dlg.ShowDialog() == DialogResult.OK) { txtRightDir.Text = dlg.SelectedPath; RefreshLists(); }
        }
    }
}