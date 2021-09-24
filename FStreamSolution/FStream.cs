using System;
using System.IO;
using System.Text;

namespace FStreamSolution
{
    interface ILogger
    {
        void Log(string m);
    }

    interface IOtherLogger
    {
        void Log(string m);

    }


    interface IStream
    {
        int Read(byte[] buffer, int offset, int count);
    }

    interface IFoo
    {
        void Log(string m);
    }
    class ConsoleLogger : IFoo, ILogger, IOtherLogger
    {
        public void Log(string m)
        {
            Console.WriteLine(m);
        }
    }

    class FStream : Stream, IFoo, 
    {
        IFoo foo = new ConsoleLogger();
        public void Log(string m)
        {
            foo.Log(m);
        }

        public override bool CanRead { get; } = true;
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Length { get; }
        public override long Position { get; set; }

        public override void Flush()
        {
            throw new NotImplementedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            Encoding.ASCII.GetBytes("ffff\nffff\nffff\nffff\nffff\n").CopyTo(buffer, offset);
            return 15;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }
    }
}
