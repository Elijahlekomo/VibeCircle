using System;
using System.ComponentModel.DataAnnotations;

namespace OneDoc.Api.Models
{
    public class FileDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FileName { get; set; } = string.Empty;

        public string FilePath { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        public long FileSize { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
        public string FileOwner { get; set; } = string.Empty;
        public bool IsFavorite { get; set; }
    }
}