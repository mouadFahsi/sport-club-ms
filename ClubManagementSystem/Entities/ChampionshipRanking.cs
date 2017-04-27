﻿using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Entities
{
    [GwinEntity(Localizable = true, DisplayMember = "NameOfChampionRank")]
    [Menu(Group = "Configuration")]
    public class ChampionshipRanking:BaseEntity
    {

        public ChampionshipRanking()
        {
            this.NameOfChampionRank = new LocalizedString();
            this.DescriptionOfChampionRank = new LocalizedString();
        }

        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString NameOfChampionRank { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString DescriptionOfChampionRank { get; set; }
    }
}
