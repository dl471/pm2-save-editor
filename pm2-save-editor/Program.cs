﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace pm2_save_editor
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

            PrincessMakerFileBuffer pm2 = new PrincessMakerFileBuffer();

            bool testLoad = pm2.LoadFile("F101.GNX");

            string newName = "Marisa";
            byte[] newNameBytes = ASCIIEncoding.ASCII.GetBytes(newName);
            pm2.WriteAtOffset(0x74, newNameBytes.Length, newNameBytes);

            byte[] name = pm2.ReadAtOffset(0x74, 48);

            MessageBox.Show(ASCIIEncoding.ASCII.GetString(name));

            pm2.SaveFile("F109.GNX");

            //Application.Run(new Form1());

        }
    }
}
