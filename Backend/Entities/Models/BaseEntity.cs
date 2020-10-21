using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities.Models
{
    public class BaseEntity
    {
        [Column("EntityId")]
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}
