using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace �Ƶ����ϵͳ
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private IContainer components;

		public MainForm()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		/*protected override void Dispose( bool disposing )
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
        */
		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem4,
            this.menuItem9,
            this.menuItem10});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3});
            this.menuItem1.Text = "��������";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "�ͷ���������";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "�ͷ���Ϣ����";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem6,
            this.menuItem7,
            this.menuItem8});
            this.menuItem4.Text = "ҵ�����";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Ԥ������";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "��ס����";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.Text = "���Ѽ���";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 3;
            this.menuItem8.Text = "�����˷�";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 2;
            this.menuItem9.Text = "��̬����";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 3;
            this.menuItem10.Text = "�˳�ϵͳ";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = "E:\\lee\\SQL\\�½��ļ���\\�Ƶ����ϵͳ\\����\\�Ƶ����ϵͳ\\bin\\Debug\\Ƥ��\\MSN\\MSN.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "���Ƶ����ϵͳ��";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		//----------------------��ѯMDI�Ӵ����Ƿ����-----------------------------
		private bool checkChildFrmExist(string childFrmName)
		{
			foreach(Form childFrm in this.MdiChildren)
			{
				if(childFrm.Name == childFrmName) //���Ӵ����Name�����жϣ����������������
				{
					if(childFrm.WindowState == FormWindowState.Minimized)
						childFrm.WindowState = FormWindowState.Normal;
					childFrm.Activate();
					return true;
				}
			}
			return false;
		}

		//-----------------��ʾ�ͷ����͹������ô���-----------------------
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("RoomType") == true)
			{
				return;
			}
			RoomType newFrm=new RoomType();
			newFrm.MdiParent = this;
			newFrm.Show();		
		}

		//-----------------��ʾ�ͷ���Ϣ�������ô���-----------------------
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("RoomInfo") == true)
			{
				return;
			}
			RoomInfo newFrm=new RoomInfo();
			newFrm.MdiParent = this;
			newFrm.Show();	
		
		}

		//-----------------��ʾ�ͷ�Ԥ����Ϣ����-----------------------
		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("HotelReserve") == true)
			{
				return;
			}
			HotelReserve newFrm=new HotelReserve();
			newFrm.MdiParent = this;
			newFrm.Show();	
		
		}
        
		//-----------------��ʾ��ס������Ϣ����-----------------------
		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("HotelArrival") == true)
			{
				return;
			}
			HotelArrival newFrm=new HotelArrival();
			newFrm.MdiParent = this;
			newFrm.Show();	
		
		}

		//-----------------��ʾ���Ѽ��ʴ���-----------------------
		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("ClientConsume") == true)
			{
				return;
			}
			ClientConsume newFrm=new ClientConsume();
			newFrm.MdiParent = this;
			newFrm.Show();
		
		}

		//-----------��ʾ�����˷�����---------------
		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("HotelLeave") == true)
			{
				return;
			}
			HotelLeave newFrm=new HotelLeave();
			newFrm.MdiParent = this;
			newFrm.Show();		
		}
        
		//-----------��ʾ��̬ͼ---------------
		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("RoomStatus") == true)
			{
				return;
			}
			RoomStatus newFrm=new RoomStatus(0);
			newFrm.MdiParent = this;
			newFrm.Show();		
		}

		//--------�˳�ϵͳ-----------
		private void menuItem10_Click(object sender, System.EventArgs e)
		{
            Application.Exit();
        }

        public static bool isRunMain = false;

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
       }
}
