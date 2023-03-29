using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Robo.Services.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        private DateTime? _createAt;
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }
        public DateTime? UpdateAt { get; set; }

    }
}
