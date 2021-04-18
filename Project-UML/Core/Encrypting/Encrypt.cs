using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.Encrypting
{
    public class Encrypt
    {
        public Encrypt()
        {
            StartEncrypt();
        }

        public void StartEncrypt()
        {
            FileStream input = new FileStream(@"../../Save/Save.Мы-Програмист", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sReader = new StreamReader(input, Encoding.Default);
            string tmps = sReader.ReadToEnd();
            MessageBox.Show("Зашифровано успешно");
            byte[] Tmpkey = new byte[tmps.Length];
            int[] tmp = new int[Tmpkey.Length];
            Tmpkey = Encoding.Default.GetBytes(tmps);

            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = Tmpkey[i] + 2999;
            }


            string okoko = "";
            for (int i = 0; i < tmp.Length; i++)
            {
                if (i != tmp.Length - 1)
                {
                    okoko += tmp[i] + "-";
                }
                else
                {
                    okoko += tmp[i];
                }
            }

            FileStream output = new FileStream(@"../../Save/Save1.Мы-Програмист", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            byte[] array = Encoding.Default.GetBytes(okoko);
            output.Write(array, 0, array.Length);


            FileStream input2 = new FileStream(@"../../Save/Save2.Мы-Програмист", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sReader2 = new StreamReader(input2, Encoding.Default);
            string tmps2 = sReader2.ReadToEnd();
            string[] ttt = tmps2.Split('-');
            byte[] Tmpkey2 = new byte[ttt.Length];
            for (int i = 0; i < ttt.Length; i++)
            {
                Tmpkey2[i] = (byte)(Convert.ToInt32(ttt[i]) - 2999);
            }

            FileStream output2 = new FileStream(@"../../Save/Save3.Мы-Програмист", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //string newS = Encoding.Default.GetString(Tmpkey2);
            output2.Write(Tmpkey2, 0, Tmpkey2.Length);


            //for (int i = 0; i < Tmpkey.Length; i++)
            //{
            //    Tmpkey[i] = (byte)(tmp[i] - 2999);
            //}
            //Tmpkey.CopyTo(tmp, 0);
            //string newS = Encoding.Default.GetString(Tmpkey);
            //MessageBox.Show(newS);
        }

    }
}
