using AutomaticInterface;

using Forge.Config;
using Forge.Logging;
using Forge.Native;
using Forge.S4.Game;

namespace Forge.S4.Types {
    [GenerateAutomaticInterface]
    public class World : IWorld {
        public uint Size => ModAPI.API.MapSize();

        public uint GetTileHeightAt(int x, int y) {
            return ModAPI.API.LandscapeGetHeight(x, y);
        }

        public uint GetTileTypeAt(int x, int y) {
            return (uint)ModAPI.API.LandscapeGetType(x, y);
        }

        public bool IsTilePond(int x, int y) {
            return ModAPI.API.LandscapeIsPond(x, y) == 1;
        }

        public Resource? GetTileResourceAt(int x, int y) {
            int resourceAndLevel = (int)ModAPI.API.LandscapeGetResource(x, y);

            switch (resourceAndLevel) {
                case 0:
                    return null;
                case (int)ResourceType.Tree:
                    return new Resource {
                        Type = ResourceType.Tree,
                        Level = 1
                    };
            }

            // The rest of the resources are level-based

            // Reverse order to correctly determine the resource type from the lower bound of the level
            ResourceType[] levelTypes = {
                ResourceType.Stone,
                ResourceType.DeepStone,
                ResourceType.Sulfur,
                ResourceType.Gold,
                ResourceType.Iron,
                ResourceType.Coal,
                ResourceType.Fish,
            };

            foreach (ResourceType resourceType in levelTypes) {
                if (resourceAndLevel >= (int)resourceType) {
                    return new Resource {
                        Type = resourceType,
                        Level = resourceAndLevel - (int)resourceType + 1 // Level is 1-based
                    };
                }
            }

            // This should never happen:
            Logger.LogWarn("Unknown resource type: " + resourceAndLevel);

            return null;
        }

        public int SetTileResourceAt(int x, int y, Resource resource) {
            return ModAPI.API.LandscapeSetResource(x, y, resource.ToNative());
        }

        public IPlayer GetTileOwnerAt(int x, int y) {
            uint owner = ModAPI.API.LandscapeGetOwner(x, y);
            return DI.Resolve<IPlayerApi>().GetPlayer(owner);
        }

        public bool IsTileOccupied(int x, int y) {
            return ModAPI.API.LandscapeIsOccupied(x, y) != 0;
        }

        public bool IsTileFoundingStone(int x, int y) {
            return ModAPI.API.LandscapeIsFoundingStone(x, y) != 0;
        }

        /// <summary>
        /// Whether the tile is a dark land border.
        /// </summary>
        /// <remarks>
        /// This flag is mutually exclusive with <see cref="IsTileDarkLand"/>. If a tile is a dark land border, it is not marked as dark land.
        /// </remarks>
        public bool IsTileDarkLandBorder(int x, int y) {
            return ModAPI.API.LandscapeIsDarkLandBorder(x, y) != 0;
        }

        /// <summary>
        /// Whether the tile is dark land.
        /// </summary>
        /// <remarks>
        /// This flag is mutually exclusive with <see cref="IsTileDarkLandBorder"/>. If a tile is a dark land border, it is not marked as dark land.
        /// </remarks>
        public bool IsTileDarkLand(int x, int y) {
            return ModAPI.API.LandscapeIsDarkLand(x, y) != 0;
        }

        /// <summary>
        /// The level of fog of war on the tile. This level is only from the perspective of the local player.
        /// </summary>
        /// <returns>A value between [0,1.0]</returns>
        public float GetTileFogOfWar(int x, int y) {
            return ModAPI.API.LandscapeGetFogOfWar(x, y) / 255.0f;
        }

        public IEcoSector GetEcoSectorAt(int x, int y) {
            return new EcoSector(ModAPI.API.LandscapeGetEcoSector(x, y));
        }
    }


    public struct Resource {
        public ResourceType Type { get; set; }

        /// <summary>
        /// The amount of the resource available in the tile.
        /// </summary>
        /// <remarks>
        /// This value is between 1 and 16.
        /// For resource types like tree, this value is 1.
        /// </remarks>
        public int Level { get; set; }

        internal S4_RESOURCE_ENUM ToNative() {
            if (Level == 0) {
                return 0;
            }

            return (S4_RESOURCE_ENUM)((int)Type + Level - 1);
        }
    }
}
