﻿using Client.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            while (true)
            {
                try
                {
                    
                    Application.Run(new FrmLogin());
                }
                catch (ServerException se)
                {
                    MessageBox.Show(se.Message);
                    Console.WriteLine(se.Message);
                }
            }
        }
    }
}
