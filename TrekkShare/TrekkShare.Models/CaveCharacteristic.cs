﻿using System.ComponentModel.DataAnnotations;

namespace TrekkShare.Models
{
    public class CaveCharacteristic
    {[Key]
        public int Id { get; set; }

        public int Temperature { get; set; }
        public double Length { get; set; }

    }
}