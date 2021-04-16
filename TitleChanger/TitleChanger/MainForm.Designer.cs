
namespace TitleChanger
{
    partial class MainPanel
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileListView = new System.Windows.Forms.ListView();
            this.btnStart = new System.Windows.Forms.Button();
            this.setTitlePanel = new System.Windows.Forms.Panel();
            this.tbSetTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindPath = new System.Windows.Forms.Button();
            this.tvPath = new System.Windows.Forms.TextBox();
            this.cbDiffSaveName = new System.Windows.Forms.CheckBox();
            this.setTitlePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileListView
            // 
            this.fileListView.AllowDrop = true;
            this.fileListView.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fileListView.HideSelection = false;
            this.fileListView.Location = new System.Drawing.Point(10, 10);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(905, 750);
            this.fileListView.TabIndex = 0;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            this.fileListView.View = System.Windows.Forms.View.List;
            this.fileListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileListView_DragDrop);
            this.fileListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileListView_DragEnter);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Font = new System.Drawing.Font("굴림", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(755, 770);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 163);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "변환";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // setTitlePanel
            // 
            this.setTitlePanel.Controls.Add(this.tbSetTitle);
            this.setTitlePanel.Controls.Add(this.label1);
            this.setTitlePanel.Location = new System.Drawing.Point(10, 770);
            this.setTitlePanel.Margin = new System.Windows.Forms.Padding(10);
            this.setTitlePanel.Name = "setTitlePanel";
            this.setTitlePanel.Size = new System.Drawing.Size(735, 45);
            this.setTitlePanel.TabIndex = 2;
            // 
            // tbSetTitle
            // 
            this.tbSetTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbSetTitle.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSetTitle.Location = new System.Drawing.Point(231, 0);
            this.tbSetTitle.Name = "tbSetTitle";
            this.tbSetTitle.Size = new System.Drawing.Size(504, 44);
            this.tbSetTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "변환 할 제목 : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFindPath);
            this.panel1.Controls.Add(this.tvPath);
            this.panel1.Controls.Add(this.cbDiffSaveName);
            this.panel1.Location = new System.Drawing.Point(10, 828);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 105);
            this.panel1.TabIndex = 3;
            // 
            // btnFindPath
            // 
            this.btnFindPath.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFindPath.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFindPath.Location = new System.Drawing.Point(571, 50);
            this.btnFindPath.Name = "btnFindPath";
            this.btnFindPath.Size = new System.Drawing.Size(161, 44);
            this.btnFindPath.TabIndex = 2;
            this.btnFindPath.Text = "경로 선택";
            this.btnFindPath.UseVisualStyleBackColor = false;
            // 
            // tvPath
            // 
            this.tvPath.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tvPath.Location = new System.Drawing.Point(10, 50);
            this.tvPath.Name = "tvPath";
            this.tvPath.Size = new System.Drawing.Size(555, 44);
            this.tvPath.TabIndex = 1;
            // 
            // cbDiffSaveName
            // 
            this.cbDiffSaveName.AutoSize = true;
            this.cbDiffSaveName.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbDiffSaveName.Location = new System.Drawing.Point(10, 8);
            this.cbDiffSaveName.Name = "cbDiffSaveName";
            this.cbDiffSaveName.Size = new System.Drawing.Size(319, 36);
            this.cbDiffSaveName.TabIndex = 0;
            this.cbDiffSaveName.Text = "다른 이름으로 저장";
            this.cbDiffSaveName.UseVisualStyleBackColor = true;
            this.cbDiffSaveName.CheckedChanged += new System.EventHandler(this.cbDiffSaveName_CheckedChanged);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 941);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.setTitlePanel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.fileListView);
            this.Name = "MainPanel";
            this.Text = "TitleChanger";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.setTitlePanel.ResumeLayout(false);
            this.setTitlePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel setTitlePanel;
        private System.Windows.Forms.TextBox tbSetTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFindPath;
        private System.Windows.Forms.TextBox tvPath;
        private System.Windows.Forms.CheckBox cbDiffSaveName;
    }
}

