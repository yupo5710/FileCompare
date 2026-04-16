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

                // 상대방 폴더 내 파일 및 하위 폴더 정보를 딕셔너리로 미리 준비
                var compareItems = Directory.Exists(comparePath)
                    ? Directory.GetFileSystemEntries(comparePath)
                               .Select(p => File.GetAttributes(p).HasFlag(FileAttributes.Directory)
                                            ? (FileSystemInfo)new DirectoryInfo(p)
                                            : new FileInfo(p))
                               .ToDictionary(i => i.Name)
                    : new Dictionary<string, FileSystemInfo>();

                // 폴더와 파일을 포함한 모든 항목 가져오기 (과제 4: 하위 폴더 처리)
                var entries = new DirectoryInfo(folderPath).GetFileSystemInfos().OrderBy(i => i.Name);

                foreach (var info in entries)
                {
                    var litem = new ListViewItem(info.Name);

                    if (info is DirectoryInfo di) // 폴더인 경우
                    {
                        litem.SubItems.Add("<DIR>");
                    }
                    else if (info is FileInfo fi) // 파일인 경우
                    {
                        litem.SubItems.Add(FormatSizeInKb(fi.Length));
                    }

                    litem.SubItems.Add(info.LastWriteTime.ToString("g"));

                    // 상대방 항목과 비교하여 색상 표시 (과제 4-2)
                    if (compareItems.TryGetValue(info.Name, out var ri))
                    {
                        if (info.LastWriteTime == ri.LastWriteTime) litem.ForeColor = Color.Black;
                        else if (info.LastWriteTime > ri.LastWriteTime) litem.ForeColor = Color.Red;
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

        private void btnCopyFromLeft_Click(object sender, EventArgs e)
        {
            CopySelectedItems(lvwLeftDir, txtLeftDir.Text, txtRightDir.Text);
            RefreshLists();
        }

        private void btnCopyFromRight_Click(object sender, EventArgs e)
        {
            CopySelectedItems(lvwRightDir, txtRightDir.Text, txtLeftDir.Text);
            RefreshLists();
        }

        // 과제 4-3: 하위 폴더의 모든 내용(파일과 하위폴더 포함) 처리
        private void CopySelectedItems(ListView lv, string srcDir, string destDir)
        {
            var selected = lv.SelectedItems.Cast<ListViewItem>();
            foreach (var item in selected)
            {
                string srcPath = Path.Combine(srcDir, item.Text);
                string destPath = Path.Combine(destDir, item.Text);

                if (Directory.Exists(srcPath))
                {
                    // 폴더인 경우 재귀적으로 복사
                    CopyDirectoryRecursively(new DirectoryInfo(srcPath), new DirectoryInfo(destPath));
                }
                else if (File.Exists(srcPath))
                {
                    // 파일인 경우 기존 확인 로직 사용
                    CopyFileWithConfirmation(new FileInfo(srcPath), destPath);
                }
            }
        }

        // 재귀적 폴더 복사 메서드
        private void CopyDirectoryRecursively(DirectoryInfo src, DirectoryInfo dest)
        {
            if (!dest.Exists) dest.Create();

            // 하위 파일 복사
            foreach (FileInfo fi in src.GetFiles())
            {
                CopyFileWithConfirmation(fi, Path.Combine(dest.FullName, fi.Name));
            }

            // 하위 폴더 복사 (재귀 호출)
            foreach (DirectoryInfo di in src.GetDirectories())
            {
                CopyDirectoryRecursively(di, new DirectoryInfo(Path.Combine(dest.FullName, di.Name)));
            }
            Directory.SetLastWriteTime(dest.FullName, src.LastWriteTime);
        }

        private void CopyFileWithConfirmation(FileInfo src, string destPath)
        {
            if (File.Exists(destPath))
            {
                FileInfo dest = new FileInfo(destPath);
                if (dest.LastWriteTime > src.LastWriteTime)
                {
                    string msg = $"대상에 동일한 이름의 파일이 이미 있습니다.\n" +
                                 $"대상 파일이 더 신규 파일입니다. 덮어쓰시겠습니까?\n\n" +
                                 $"원본: {src.FullName} ({src.LastWriteTime})\n" +
                                 $"대상: {dest.FullName} ({dest.LastWriteTime})";

                    if (MessageBox.Show(this, msg, "덮어쓰기 확인",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            File.Copy(src.FullName, destPath, true);
            File.SetLastWriteTime(destPath, src.LastWriteTime);
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