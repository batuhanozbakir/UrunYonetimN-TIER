﻿using DAL_UrunYonetimi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_UrunYonetimi.Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set ; }
        public DateTime? ModifiedDate { get ; set ; }
        public DateTime? DeletedDate { get ; set ; }
        public DataStatus DataStatus { get ; set ; }
        public DateTime CreatedDate { get; internal set; }
    }
}
