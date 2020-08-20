using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyPinyin.Core;
using MSSQL.SqlHelper;
using System.Data.SqlClient;


namespace pinyin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = PinyinHelper.GetPinyin(textBox1.Text,"");

            textBox2.Text = PinyinHelper.GetPinyinInitials(textBox1.Text);
        }
        /// <summary>
        /// 自动生成助记码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_query_Click(object sender, EventArgs e)
        {
          //初始化dataAdapter
            string connectionString = "Data Source=192.168.10.66;Initial Catalog=manage;User ID=sa;Password=000000";
            using (SqlConnection connection =
               new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdpater = new SqlDataAdapter(
                  "SELECT * FROM addressBook",
                  connection);
              

                dataAdpater.UpdateCommand = new SqlCommand(
               "UPDATE addressBook SET memoryCode = @memoryCode " +
               "WHERE ID = @ID", connection);

                dataAdpater.UpdateCommand.Parameters.Add(
                "@memoryCode", SqlDbType.NVarChar, 50, "memoryCode");

                SqlParameter parameter = dataAdpater.UpdateCommand.Parameters.Add(
                  "@ID", SqlDbType.Int);
                parameter.SourceColumn = "ID";
                parameter.SourceVersion = DataRowVersion.Original;
                //取数并更新
                DataTable dataTable = new DataTable();
                dataAdpater.Fill(dataTable);
                foreach (DataRow item in dataTable.Rows)

                {
                    if (item[3].ToString().Length > 0)
                    {
                        //调用简拼生成方法
                        item[10] = PinyinHelper.GetPinyinInitials(item[3].ToString().Trim());
                    }

                }
                                                             
                dataAdpater.Update(dataTable);
                this.dataGridView1.DataSource = dataTable;
                MessageBox.Show("助记码生成成功", "生成提示");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“testDataSet.addressBook”中。您可以根据需要移动或删除它。
            this.addressBookTableAdapter.Fill(this.testDataSet.addressBook);
            // TODO: 这行代码将数据加载到表“manageDataSet.addressBook”中。您可以根据需要移动或删除它。


        }
    }
}
