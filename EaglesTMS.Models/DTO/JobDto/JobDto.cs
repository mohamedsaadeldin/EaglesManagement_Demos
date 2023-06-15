﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaglesTMS.Models.DTO.JobDto
{
    public class JobDto
    {
        //public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string JobName { get; set; }
        [Required]
        public int NumberOfAssignees { get; set; }
    }
}
