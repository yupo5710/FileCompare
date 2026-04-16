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

        //
        private string FormatSizeInKb(long bytes) => $"{(bytes + 1023) / 1024:N0} KB";

        private void PopulateListView(ListView lv, string folderPath)
        {
            lv.BeginUpdate();
            lv.Items.Clear();

            try
            {
                if (!Directory.Exists(folderPath)) return;

                // 비교를 위해 상대방 폴더의 파일 정보(rf)를 가져오는 로직
                string comparePath = (lv == lvwLeftDir) ? txtRightDir.Text : txtLeftDir.Text;
                var compareFiles = Directory.Exists(comparePath)
                    ? Directory.EnumerateFiles(comparePath)
                               .Select(p => new FileInfo(p))
                               .ToDictionary(f => f.Name)
                    : new Dictionary<string, FileInfo>();

                // 1. 폴더(디렉터리) 먼저 추가
                var dirs = Directory.EnumerateDirectories(folderPath)
                    .Select(p => new DirectoryInfo(p)).OrderBy(d => d.Name);

                foreach (var d in dirs)
                {
                    var item = new ListViewItem(d.Name);
                    item.SubItems.Add("<DIR>");
                    item.SubItems.Add(d.LastWriteTime.ToString("g"));
                    item.ForeColor = Color.Blue; // 폴더 구분용
                    lv.Items.Add(item);
                }

                // 2. 파일 추가 및 비교 
                var files = Directory.EnumerateFiles(folderPath)
                    .Select(p => new FileInfo(p))
                    .OrderBy(f => f.Name);

                foreach (var f in files)
                {
                    // --- 이미지 코드 적용 시작 ---
                    var litem = new ListViewItem(f.Name);
                    litem.SubItems.Add(FormatSizeInKb(f.Length));
                    litem.SubItems.Add(f.LastWriteTime.ToString("g"));

                    // 상대방 파일(rf)과 비교하여 색상 결정
                    if (compareFiles.TryGetValue(f.Name, out var rf))
                    {
                        if (f.LastWriteTime == rf.LastWriteTime)
                        {
                            litem.ForeColor = Color.Black; // 동일 파일
                        }
                        else if (f.LastWriteTime > rf.LastWriteTime)
                        {
                            litem.ForeColor = Color.Red;   // 내가 더 최신
                        }
                        else
                        {
                            litem.ForeColor = Color.Gray;  // 내가 더 오래됨
                        }
                    }
                    else
                    {
                        litem.ForeColor = Color.Purple;    // 단독 파일
                    }
                    lv.Items.Add(litem);
                    // --- 이미지 코드 적용 끝 ---
                }

                // 3. 컬럼 너비 자동 조정 (이미지 내용 반영)
                for (int i = 0; i < lv.Columns.Count; i++)
                {
                    lv.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(this, "폴더를 찾을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, "입출력 오류: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lv.EndUpdate();
            }
        }

        // 양쪽 리스트를 동시에 새로고침하여 비교 상태를 업데이트
        private void RefreshLists()
        {
            PopulateListView(lvwLeftDir, txtLeftDir.Text);
            PopulateListView(lvwRightDir, txtRightDir.Text);
        }

        private void btnLeftDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtLeftDir.Text = dlg.SelectedPath;
                    RefreshLists();
                }
            }
        }

        private void btnRightDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRightDir.Text = dlg.SelectedPath;
                    RefreshLists();
                }
            }
        }
        private void btnCopyFromLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnCopyFromRight_Click(object sender, EventArgs e)
        {

        }
    }
}