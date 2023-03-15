using S4UI;

using System.Collections.Generic;

namespace S4UI.Rendering.Text {
    public class TextTranslation {
        protected static string setLanguage;
        static TextTranslation() {
            setLanguage = UIEngine.GS.GetLanguage();
        }

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
            return !textTranslations.TryGetValue(setLanguage, out string? output) ? textTranslations["en"] : output;
        }
    }
}
