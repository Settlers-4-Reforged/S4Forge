using Forge.Logging;
using Forge.S4.Managers;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.I18n {
    public class TextTranslation {
        protected static string gameLanguage => GameConfig.GetLanguage();

        public Dictionary<string, string> textTranslations;

        public TextTranslation(params (string lang, string text)[] translations) {
            textTranslations = new Dictionary<string, string>();

            foreach (var t in translations) {
                textTranslations.Add(t.lang, t.text);
            }
        }

        public static implicit operator string(TextTranslation t) {
            return t.ToString();
        }

        public override string ToString() {
            return !textTranslations.TryGetValue(gameLanguage, out string? output) ? textTranslations["en"] : output;
        }

        // Cache file reads, to not read files multiple times
        static Dictionary<string, string[]> CsvCache = new Dictionary<string, string[]>();
        public static TextTranslation FromCsv(string path, string key) {
            string[] lines;

            if (!CsvCache.TryGetValue(path, out lines!)) {
                lines = System.IO.File.ReadAllLines(path);
                CsvCache.Add(path, lines);
            }

            // Example Format:
            // "name;de;en;pl"
            string[] fileLanguages = lines[0].Split(',');

            for (int lineIndex = 1; lineIndex < lines.Length; lineIndex++) {
                string[] keys = lines[lineIndex].Split(',');
                if (keys.Length == 0) continue;
                if (keys[0].StartsWith("#", StringComparison.InvariantCultureIgnoreCase)) continue; // Commented out line (starts with #)
                if (keys.Length != fileLanguages.Length + 1) { Logger.LogError(null, $"Invalid CSV format at line {lineIndex} for translation key {key}"); continue; }


                string lineKey = keys[0];
                if (lineKey != key) continue;

                TextTranslation translation = new TextTranslation();
                for (int languageIndex = 1; languageIndex < keys.Length; languageIndex++) {
                    translation.textTranslations.Add(fileLanguages[languageIndex], keys[languageIndex]);
                }

                return translation;
            }

            Logger.LogError(null, "Failed to find translation key ${0} in csv '${1}'", key, path);
            return new TextTranslation(("en", "NOT FOUND"));
        }
    }
}
