﻿using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VŽBUS_
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DB.SetConfiguration("PI2324_tpodnar22_DB", "PI2324_tpodnar22_User", "%K^{YcZ(");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
