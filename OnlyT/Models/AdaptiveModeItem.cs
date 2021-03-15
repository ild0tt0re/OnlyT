﻿namespace OnlyT.Models
{
    // ReSharper disable UnusedAutoPropertyAccessor.Global
    using Services.Options;

    /// <summary>
    /// Used for items in the Adaptive mode combos
    /// </summary>
    public class AdaptiveModeItem
    {
        public AdaptiveModeItem(AdaptiveMode mode, string name)
        {
            Mode = mode;
            Name = name;
        }

        public AdaptiveMode Mode { get; }

        public string Name { get; }
    }
}
