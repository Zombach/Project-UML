using Project_UML.Core.DataProject.Binary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UML.Core.Encrypting
{
    public class DecryptSaving
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private string _tmps;
        private string[] _tmpSplit;
        private byte[] _tmpkey;
        private byte[] _key;
        private int _keyReady = 30;

        public bool StartDecrypt()
        {
            using (FileStream input = new FileStream(_coreUML.MyPathEncrypt, FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamReader sReader = new StreamReader(input, Encoding.Default))
                {
                    _tmps = sReader.ReadToEnd();
                    _tmpSplit = _tmps.Split('-');
                    _tmpkey = new byte[_tmpSplit.Length];

                    _key = Encoding.Default.GetBytes(_coreUML.TmpKeyEncript);
                    for (int i = 0; i < _key.Length; i++)
                    {
                        _keyReady += _key[0];
                    }
                    for (int i = 0; i < _tmpSplit.Length; i++)
                    {
                        _tmpkey[i] = (byte)(Convert.ToInt32(_tmpSplit[i]) - _keyReady);
                    }
                }
            }

            SetMyPath path = new SetMyPath();
            path.MyPath();

            using (FileStream output = new FileStream(_coreUML.MyPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                output.Write(_tmpkey, 0, _tmpkey.Length);
            }
            return true;
        }
    }
}