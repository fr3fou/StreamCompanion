﻿using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace osu_StreamCompanion.Code.Modules.MapDataGetters.FileMap
{
    public class FileMapManager
    {
        Dictionary<string, MapContainer> _files = new Dictionary<string, MapContainer>();
        private readonly object _lockingObject = new object();
        private class MapContainer
        {
            public MemoryMappedFile File { get; set; }
            private readonly object _lockingObject = new object();
            
            public void Write(string data)
            {
                lock (_lockingObject)
                {
                    var bytes = Encoding.Unicode.GetBytes(data);
                    using (var a = File.CreateViewStream())
                    {

                        a.Write(bytes, 0, bytes.Length);
                        a.WriteByte(0);
                    }
                }
            }
        }
        
        private MapContainer GetFile(string pipeName)
        {
            lock (_lockingObject)
            {
                if (_files.ContainsKey(pipeName))
                    return _files[pipeName];
                MapContainer f = new MapContainer() { File = MemoryMappedFile.CreateOrOpen(pipeName, 16 * 1024) };

                _files.Add(pipeName, f);
                return f;
            }
        }

        public void Write(string name, string value)
        {
            var file = GetFile(name);
            file.Write(value);

        }





    }
}