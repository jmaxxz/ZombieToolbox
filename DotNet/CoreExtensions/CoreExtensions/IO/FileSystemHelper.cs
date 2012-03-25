using System;
using System.IO;
using System.Linq;

namespace ZombieToolbox.System
{
    public class FileSystemHelper
    {
        private readonly Action<FileInfo> _fileHandler;
        private readonly Action<DirectoryInfo> _directoryHandler;
        private readonly Action<Exception> _errorHandler;
        public FileSystemHelper (Action<FileInfo> fileHandler, Action<DirectoryInfo> directoryHandler, Action<Exception> errorHandler)
        {
            _fileHandler = fileHandler;
            _directoryHandler = directoryHandler;
            _errorHandler =errorHandler;
        }


        public void HandlePath(string path)
        {
            try
            {
                if(File.Exists(path))
                {
                    _fileHandler(new FileInfo(path));
                }
                else if(Directory.Exists(path))
                {
                    _directoryHandler(new DirectoryInfo(path));
                }
            }
            catch(Exception e)
            {
                _errorHandler(e);
            }
        }

        public void HandlePathRecursively(string path)
        {
            try
            {
                if(File.Exists(path))
                {
                    _fileHandler(new FileInfo(path));
                }
                else if(Directory.Exists(path))
                {
                    var d =new DirectoryInfo(path);
                    RecursiveDirectoryHandler(_directoryHandler)(d);
                }
            }
            catch(Exception e)
            {
                _errorHandler(e);
            }
        }
        private static Action<DirectoryInfo> RecursiveDirectoryHandler(Action<DirectoryInfo> d)
        {
            _directoryHandler(d);
            foreach(var f in d.GetFileSystemInfos())
            {
                HandlePath(f.FullName);
            }
        }
    }
}

