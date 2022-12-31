using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S4_UIEngine.GameTypes;

namespace S4_UIEngine.Settings {
    public interface IGameSettings {
        public string GetLanguage();

        public Tribe GetCurrentTribe();
    }
}
