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
        //變數區
        private CarApi api = null;

        public Form1()
        {
            InitializeComponent();
        }

        #region 生命週期 

        private void Form1_Load(object sender, EventArgs e)
        {
            api = new CarApi();   //配置記憶體空間
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
            if (string.IsNullOrWhiteSpace(tbPlate.Text))
            {
                MessageBox.Show("請輸入車牌", "警告");
                return;
            }

            // 送資料給API 
            List<Image> imgList = api.GetPlate(tbPlate.Text);  //調用程式

            // 根據結果顯示圖片 
            if (imgList != null && imgList.Count >= 4)
            {
                pic1.Image = imgList[0];
                //TODO:把剩下三個全部補完
            }
        }


        #endregion


    }
}
