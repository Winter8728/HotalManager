﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace 酒店管理系统
{
    class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            if (MainForm.isRunMain == true)
            {
                Application.Run(new MainForm());
            }

        }

    }
}



