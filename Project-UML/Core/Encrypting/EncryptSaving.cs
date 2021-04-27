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
    public class EncryptSaving
    {
        private CoreUML _coreUML = CoreUML.GetCoreUML();
        private string _tmps;
        private byte[] _tmpKey;
        private byte[] _key;
        private int _keyReady = 30;
        private int[] _tmp;
        public bool StartEncrypt()
        {

            using (FileStream input = new FileStream(_coreUML.MyPathEncrypt, FileMode.Open, FileAccess.ReadWrite))
            {
                try
                {
                    using (StreamReader sReader = new StreamReader(input, Encoding.Default))
                    {
                        _tmps = sReader.ReadToEnd();
                        sReader.Close();
                    }
                }
                catch
                {
                    return false;
                }
                input.Close();

                _key = Encoding.Default.GetBytes(_coreUML.TmpKeyEncript);
                for (int i = 0; i < _key.Length; i++)
                {
                    _keyReady += _key[0];
                }


                _tmpKey = new byte[_tmps.Length];
                _tmp = new int[_tmpKey.Length];
                _tmpKey = Encoding.Default.GetBytes(_tmps);
                for (int i = 0; i < _tmp.Length; i++)
                {
                    _tmp[i] = _tmpKey[i] + _keyReady;
                }

                _tmps = "";
                for (int i = 0; i < _tmp.Length; i++)
                {
                    if (i != _tmp.Length - 1)
                    {
                        _tmps += _tmp[i] + "-";
                    }
                    else
                    {
                        _tmps += _tmp[i];
                    }
                }

                SetMyPath path = new SetMyPath();
                path.MyPathEncrypt();

                using (FileStream output = new FileStream(_coreUML.MyPathEncryptSave, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    byte[] array = Encoding.Default.GetBytes(_tmps);
                    output.Write(array, 0, array.Length);
                    output.Close();
                }
                return true;
            }
        }
    }
}
