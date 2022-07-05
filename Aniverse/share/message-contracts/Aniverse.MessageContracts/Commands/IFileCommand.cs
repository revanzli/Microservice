﻿namespace Aniverse.MessageContracts.Commands
{
    public interface IFileCommand
    {
        public string UserId { get; set; }
        public string PostId { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }
        public long Size { get; set; }
        public string Extension { get; set; }
    }
}
