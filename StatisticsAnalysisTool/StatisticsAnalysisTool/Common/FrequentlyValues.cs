﻿using System.Collections.Generic;

namespace StatisticsAnalysisTool.Common
{
    public static class FrequentlyValues
    {
        public static readonly Dictionary<ItemTier, string> ItemTiers = new Dictionary<ItemTier, string>
        {
            {ItemTier.Unknown, string.Empty },
            {ItemTier.T1, "Tier 1" },
            {ItemTier.T2, "Tier 2" },
            {ItemTier.T3, "Tier 3" },
            {ItemTier.T4, "Tier 4" },
            {ItemTier.T5, "Tier 5" },
            {ItemTier.T6, "Tier 6" },
            {ItemTier.T7, "Tier 7" },
            {ItemTier.T8, "Tier 8" }
        };

        public static readonly Dictionary<ItemLevel, string> ItemLevels = new Dictionary<ItemLevel, string>
        {
            {ItemLevel.Unknown, string.Empty },
            {ItemLevel.Level0, "0" },
            {ItemLevel.Level1, "1" },
            {ItemLevel.Level2, "2" },
            {ItemLevel.Level3, "3" }
        };

        public static readonly Dictionary<ItemQuality, int> ItemQualities = new Dictionary<ItemQuality, int>
        {
            {ItemQuality.Unknown, -1 },
            {ItemQuality.Normal, 1 },
            {ItemQuality.Good, 2 },
            {ItemQuality.Outstanding, 3 },
            {ItemQuality.Excellent, 4 },
            {ItemQuality.Masterpiece, 5 }
        };

        public static readonly Dictionary<GameLanguage, string> GameLanguages = new Dictionary<GameLanguage, string>()
        {
            {GameLanguage.UnitedStates, "EN-US" },
            {GameLanguage.Germany, "DE-DE" },
            {GameLanguage.Russia, "RU-RU" },
            {GameLanguage.Poland, "PL-PL" },
            {GameLanguage.Brazil, "PT-BR" },
            {GameLanguage.France, "FR-FR" },
            {GameLanguage.Spain, "ES-ES" },
            {GameLanguage.Chinese, "ZH-CH" }
        };

        public static readonly Dictionary<ItemTier, float> BaseCraftingFame = new Dictionary<ItemTier, float>
        {
            {ItemTier.Unknown, 0 },
            //{ItemTier.T1, "Tier 1" },
            //{ItemTier.T2, "Tier 2" },
            //{ItemTier.T3, "Tier 3" },
            {ItemTier.T4, 22.5f },
            {ItemTier.T5, 90 },
            {ItemTier.T6, 270 },
            {ItemTier.T7, 645 },
            {ItemTier.T8, 1395 }
        };
    }

    public enum GameLanguage { UnitedStates, Germany, Russia, Poland, Brazil, France, Spain, Chinese }

    public enum ItemTier { Unknown = -1, T1 = 1, T2 = 2, T3 = 3, T4 = 4, T5 = 5, T6 = 6, T7 = 7, T8 = 8 }

    public enum ItemLevel { Unknown = -1, Level0 = 0, Level1 = 1, Level2 = 2, Level3 = 3 }

    public enum ItemQuality { Unknown = -1, Normal = 0, Good = 1, Outstanding = 2, Excellent = 3, Masterpiece = 4 }

    public enum ItemMaterialType { Standard = 0, Artifact = 1, Royal = 2 }
}