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
            return !textTranslations.TryGetValue(gameLanguage, out string output) ? textTranslations["en"] : output;
        }

        public static Dictionary<string, TextTranslation> FromCsv(string path) {
            Dictionary<string, TextTranslation> translations = new Dictionary<string, TextTranslation>();
            string[] lines = System.IO.File.ReadAllLines(path);

            // Example Format:
            // "name;de;en;pl"

            string[] fileLanguages = lines[0].Split(',');

            for (int lineIndex = 1; lineIndex < lines.Length; lineIndex++) {
                string[] keys = lines[lineIndex].Split(',');
                if (keys.Length == 0) continue;
                if (keys[0].StartsWith("#")) continue; // Commented out line (starts with #)
                if (keys.Length != fileLanguages.Length + 1) throw new Exception($"Invalid CSV Format at line {lineIndex}");

                TextTranslation translation = new TextTranslation();
                for (int languageIndex = 1; languageIndex < keys.Length; languageIndex++) {
                    translation.textTranslations.Add(fileLanguages[languageIndex], keys[languageIndex]);
                }

                string name = keys[0];
                translations.Add(name, translation);
            }

            return translations;
        }
    }
}
