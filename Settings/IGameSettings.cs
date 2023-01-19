using S4_UIEngine.GameTypes;

namespace S4_UIEngine.Settings {
    public interface IGameSettings {
        public string GetLanguage();

        public Tribe GetCurrentTribe();
    }
}
