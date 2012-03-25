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
            HandlePath(path, _fileHandler, _directoryHandler,_errorHandler );
        }

        public void HandlePathRecursively(string path)
        {
            HandlePath(path, _fileHandler, RecursiveDirectoryHandler(),_errorHandler );
        }
        private static void HandlePath(string path, Action<FileInfo> fileHandler,Action<DirectoryInfo> directoryHandler, Action<Exception> errorHandler)
        {
            try
            {
                if(File.Exists(path))
                {
                    fileHandler(new FileInfo(path));
                }
                else if(Directory.Exists(path))
                {
                    var d =new DirectoryInfo(path);
                    directoryHandler(d);
                }
            }
            catch(Exception e)
            {
                errorHandler(e);
            }
        }

        private Action<DirectoryInfo> RecursiveDirectoryHandler()
        {
            return (d)=>{
            _directoryHandler(d);
            foreach(var f in d.GetFileSystemInfos())
            {
                HandlePath(f.FullName);
            }};
        }
    }
}

