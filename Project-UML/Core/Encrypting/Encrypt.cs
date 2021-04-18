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
            FileStream input = new FileStream(@"TestData.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sReader = new StreamReader(input, Encoding.Default);
            string tmps = sReader.ReadToEnd();
            MessageBox.Show(tmps);
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

            FileStream output = new FileStream(@"TestData2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            byte[] array = Encoding.Default.GetBytes(okoko);
            output.Write(array, 0, array.Length);

            for (int i = 0; i < Tmpkey.Length; i++)
            {
                Tmpkey[i] = (byte)(tmp[i] - 2999);
            }
            Tmpkey.CopyTo(tmp, 0);
            string newS = Encoding.Default.GetString(Tmpkey);
            MessageBox.Show(newS);


        }

    }
}
