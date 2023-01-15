﻿using InformsISG.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformsISG.Entities.Concrete
{
    public class Makine_Bilgi_Baslik : EntityBase, IEntity
    {
        public string Madde_Ad { get; set; }

        //FK
        [ForeignKey("Makine")]
        public long Makine_Id { get; set; }

        //FK Bağlantıları
        public virtual Makine Makine { get; set; }

        //Bire Çok İlişkiler
        public virtual ICollection<Makine_Bilgiler> Makine_Bilgiler { get; set; }
    }
}