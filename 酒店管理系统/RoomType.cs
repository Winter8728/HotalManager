using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace �Ƶ����ϵͳ
{
	public class RoomType : �Ƶ����ϵͳ.ParentForm
	{
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private �Ƶ����ϵͳ.DataSet1 dataSet11;
		private System.ComponentModel.IContainer components = null;

		public RoomType()
		{
			// �õ����� Windows ���������������ġ�
			InitializeComponent();

			// TODO: �� InitializeComponent ���ú�����κγ�ʼ��
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region ��������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomType));
            this.txt4 = new System.Windows.Forms.TextBox();
            this.dataSet11 = new �Ƶ����ϵͳ.DataSet1();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "��������";
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Text = "���ͱ��";
            // 
            // txt3
            // 
            this.txt3.Visible = false;
            // 
            // label3
            // 
            this.label3.Visible = false;
            // 
            // toolBar1
            // 
            this.toolBar1.Size = new System.Drawing.Size(728, 41);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "�ͷ�����";
            this.dataGrid1.DataSource = this.dataSet11;
            this.dataGrid1.Size = new System.Drawing.Size(728, 197);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt4);
            this.groupBox2.Controls.Add(this.txt5);
            this.groupBox2.Controls.Add(this.txt6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(0, 289);
            this.groupBox2.Size = new System.Drawing.Size(728, 86);
            // 
            // da1
            // 
            this.da1.DeleteCommand = this.sqlDeleteCommand1;
            this.da1.InsertCommand = this.sqlInsertCommand1;
            this.da1.SelectCommand = this.sqlSelectCommand1;
            this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "�ͷ�����", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("���ͱ��", "���ͱ��"),
                        new System.Data.Common.DataColumnMapping("��������", "��������"),
                        new System.Data.Common.DataColumnMapping("�۸�", "�۸�"),
                        new System.Data.Common.DataColumnMapping("ƴ���۸�", "ƴ���۸�"),
                        new System.Data.Common.DataColumnMapping("�ɳ�Ԥ����", "�ɳ�Ԥ����"),
                        new System.Data.Common.DataColumnMapping("�Ƿ��ƴ��", "�Ƿ��ƴ��")})});
            this.da1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // txt4
            // 
            this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "�ͷ�����.���ͱ��", true));
            this.txt4.Location = new System.Drawing.Point(124, 40);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(136, 21);
            this.txt4.TabIndex = 6;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("zh-CN");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt5
            // 
            this.txt5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "�ͷ�����.��������", true));
            this.txt5.Location = new System.Drawing.Point(292, 40);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(136, 21);
            this.txt5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(468, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "�۸�";
            // 
            // txt6
            // 
            this.txt6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "�ͷ�����.�۸�", true));
            this.txt6.Location = new System.Drawing.Point(468, 40);
            this.txt6.Name = "txt6";
            this.txt6.ReadOnly = true;
            this.txt6.Size = new System.Drawing.Size(136, 21);
            this.txt6.TabIndex = 5;
            this.txt6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt6_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(296, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "��������";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(128, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "���ͱ��";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT ���ͱ��, ��������, �۸�, ƴ���۸�, �ɳ�Ԥ����, �Ƿ��ƴ�� FROM �ͷ����� WHERE (���ͱ�� LIKE @Param3) AND" +
                " (�������� LIKE @Param4)";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param3", System.Data.SqlDbType.VarChar, 4, "���ͱ��"),
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 40, "��������")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO �ͷ�����(���ͱ��, ��������, �۸�, ƴ���۸�, �ɳ�Ԥ����, �Ƿ��ƴ��) VALUES (@���ͱ��, @��������, @�۸�, @" +
                "ƴ���۸�, @�ɳ�Ԥ����, @�Ƿ��ƴ��); SELECT ���ͱ��, ��������, �۸�, ƴ���۸�, �ɳ�Ԥ����, �Ƿ��ƴ�� FROM �ͷ����� WHERE" +
                " (���ͱ�� = @���ͱ��)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@���ͱ��", System.Data.SqlDbType.VarChar, 4, "���ͱ��"),
            new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.VarChar, 40, "��������"),
            new System.Data.SqlClient.SqlParameter("@�۸�", System.Data.SqlDbType.Money, 8, "�۸�"),
            new System.Data.SqlClient.SqlParameter("@ƴ���۸�", System.Data.SqlDbType.Money, 8, "ƴ���۸�"),
            new System.Data.SqlClient.SqlParameter("@�ɳ�Ԥ����", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(3)), ((byte)(0)), "�ɳ�Ԥ����", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@�Ƿ��ƴ��", System.Data.SqlDbType.Bit, 1, "�Ƿ��ƴ��")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@���ͱ��", System.Data.SqlDbType.VarChar, 4, "���ͱ��"),
            new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.VarChar, 40, "��������"),
            new System.Data.SqlClient.SqlParameter("@�۸�", System.Data.SqlDbType.Money, 8, "�۸�"),
            new System.Data.SqlClient.SqlParameter("@ƴ���۸�", System.Data.SqlDbType.Money, 8, "ƴ���۸�"),
            new System.Data.SqlClient.SqlParameter("@�ɳ�Ԥ����", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(3)), ((byte)(0)), "�ɳ�Ԥ����", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@�Ƿ��ƴ��", System.Data.SqlDbType.Bit, 1, "�Ƿ��ƴ��"),
            new System.Data.SqlClient.SqlParameter("@Original_���ͱ��", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ͱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ɳ�Ԥ����", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(3)), ((byte)(0)), "�ɳ�Ԥ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ƴ���۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ƴ���۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ��ƴ��", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ��ƴ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��������", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_���ͱ��", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ͱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ɳ�Ԥ����", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(3)), ((byte)(0)), "�ɳ�Ԥ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ƴ���۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ƴ���۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ��ƴ��", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ��ƴ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��������", System.Data.DataRowVersion.Original, null)});
            // 
            // RoomType
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(728, 389);
            this.Name = "RoomType";
            this.Text = "���ͷ��������á�";
            this.Load += new System.EventHandler(this.RoomType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		//--------��������ʱ����������-------
		private void RoomType_Load(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].SqlDbType=SqlDbType.VarChar;
			da1.SelectCommand.Parameters[0].Value="%";			
			da1.SelectCommand.Parameters[1].Value="%";			
			
			da1.Fill(dataSet11);
			//�������ݵ����ؼ�
			this.cmOrders=(CurrencyManager) BindingContext[dataSet11,"�ͷ�����"];	
			//�������е����ݼ����������е����ݼ�����
			base.dataSet11=this.dataSet11;
		}

		//-----------�������룬������Ϣ----------
		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].Value="%";			
			da1.SelectCommand.Parameters[1].Value="%";
			
			if(txt1.Text.Trim()!="")
			{
				da1.SelectCommand.Parameters[0].Value="%"+txt1.Text.Trim()+"%";
			}
			if(txt2.Text.Trim()!="")
			{
				da1.SelectCommand.Parameters[1].Value="%"+txt2.Text.Trim()+"%";
			}
			
			dataSet11.Clear();//ˢ�����ݼ�
			da1.Fill(dataSet11);		
		}

		//----------��д���ÿؼ�ֻ�����Ժ���----------
		protected override void SetModifyMode(bool blnEdit)
		{
			base.SetModifyMode (blnEdit);			
			txt5.ReadOnly=!blnEdit;
			txt6.ReadOnly=!blnEdit;			
		}

		//-------��д������¼ʱ����Ĭ��ֵ����--------
		protected override void SetDefaultValue()
		{
			//�����µı��
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="select max(���ͱ��) ����� from �ͷ�����";
			object result=cmd.ExecuteScalar();
			int newID=1;
			if(result!=System.DBNull.Value)
			{
				newID=Convert.ToInt32(result)+1;
			}
			txt4.Text=newID.ToString();			
			base.SetDefaultValue ();
		}

		//-------��д���ǿ��ֶκ���--------
		protected override bool CheckNotNull()
		{
			if(txt4.Text.Trim()=="")// �ͷ����Ʋ���Ϊ��
			{
				MessageBox.Show("�ͷ����Ʋ���Ϊ��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}	
			if(txt5.Text.Trim()=="")// �۸���Ϊ��
			{
				MessageBox.Show("�۸���Ϊ��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			
			return base.CheckNotNull ();
		}

		//--------------�۸��ı���ֻ���������֣�С�����ɾ��--------------
		private void txt6_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(!((e.KeyChar<='9'&&e.KeyChar>='0')||e.KeyChar=='.'||e.KeyChar==8))
			{
				e.Handled=true;
			}
		}
	}
}

