using Forge.S4.Managers;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.I18n {
    public class TextTranslation {
        protected static string setLanguage => GameConfig.GetLanguage();

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
            return !textTranslations.TryGetValue(setLanguage, out string output) ? textTranslations["en"] : output;
        }
    }
}
