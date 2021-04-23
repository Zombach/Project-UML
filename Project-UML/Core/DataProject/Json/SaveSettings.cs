﻿using Newtonsoft.Json;
using Project_UML.Core.DataProject.Structure;
using System.IO;

namespace Project_UML.Core.DataProject.Json
{
    public class SaveSettings
    {
        private SerializeSettings _serializer = new SerializeSettings();
        public void WriteSettings()
        {
            using (FileStream fileStream = new FileStream(CoreUML.GetCoreUML().MyPathSettings, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine(_serializer.Serializer());
                    streamWriter.Close();
                }
                fileStream.Close();
            }
        }
    }
}
