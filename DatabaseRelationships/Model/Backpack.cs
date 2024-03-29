﻿using System.Text.Json.Serialization;

namespace DatabaseRelationships.Model
{
    public class Backpack
    {

        public int Id { get; set; }

        public String Description { get; set; } = String.Empty;

        [JsonIgnore]
        public Character Character { get; set; }

    }
}
