using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_UIEngine.Rendering.Texture {
    public static class TextureCollectionManager {
        private static readonly Dictionary<int, ITextureCollection> collections = new();

        public static void AddCollection(int id, ITextureCollection collection) => collections.Add(id, collection);

        public static void RemoveCollection(int id) => collections.Remove(id);

        public static ITextureCollection GetCollection(int id) => collections[id];

        public static ITexture Get(int col, int id) => GetCollection(col).GetTexture(id);
    }
}
