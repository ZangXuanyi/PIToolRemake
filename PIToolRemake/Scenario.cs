﻿using System.Windows.Input;

namespace PIToolRemake
{
    public class Scenario
    {
        public int ID { get; set; } = 0;
        public string Name { get; set; } = "";
        public float ScoreMultiplier { get; set; } = 0f;
        public float Constant { get; set; } = 0f;
        public string Author { get; set; } = "";
        public int Feature { get; set; } = 0;
        public string Package { get; set; } = "";
        public string ImageUrl => $"http://47.93.57.125:521/WebAPI/public/icons/{ID}.png";
        public string CacheFilePath => Path.Combine(FileSystem.AppDataDirectory, $"{ID}.png");
        public string FeatureString => Name + $"[{Constant}]";
    }
}
