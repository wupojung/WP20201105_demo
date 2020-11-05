using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 生命週期 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //重設 程式位置
            this.Location = new Point(200, 100);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #endregion

        #region Event


        /// <summary>
        /// 查詢按鈕按下時的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {
            // 檢查是否輸入空白

            // 送資料給API 

            // 根據結果顯示圖片 
        }

        #endregion
    }
}
