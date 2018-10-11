using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLaboratory.Classes
{ 
    struct SizeGood
    {
        private int lengthCm;
        private int widthCm;
        private int heightCm;

        public SizeGood(int lengthCm, int widthCm, int heightCm)
        {
            this.lengthCm = lengthCm;
            this.widthCm = widthCm;
            this.heightCm = heightCm;
        }

        public string GetInfo()
        {
            string result = lengthCm + "cm x " + widthCm + "cm x " + heightCm + "cm";
            return result;
        }
    }

    struct BaseInfoAboutGood
    {
        private int weight;
        private SizeGood size;

        public BaseInfoAboutGood(int weight, SizeGood size) { this.weight = weight; this.size = size; }

        public string GetInfo()
        {
            string result = "Weight: " + weight + "g" + Environment.NewLine;
            return result += "Size: " + size.GetInfo() + Environment.NewLine;
        }
    }

    struct Nutrients
    {
        private int kcals;
        private int proteins;
        private int carbohydrates;
        private int fats;

        public Nutrients(int kcals, int proteins, int carbohydrates, int fats)
        {
            this.kcals = kcals;
            this.proteins = proteins;
            this.carbohydrates = carbohydrates;
            this.fats = fats;
        }

        public string GetInfo()
        {
            string result = "Energetic value: " + kcals + "kcals in 100g" + Environment.NewLine;
            result += "Proteins: " + proteins + "g" + Environment.NewLine;
            result += "Carbohydrates: " + carbohydrates + "g" + Environment.NewLine;
            result += "Fats: " + fats + "g";
            return result;
        }
    }

    namespace NS_Game
    {
        // --- Enum for VideoGame ---
        enum EnGamePlatform
        {
            PC,
            PlayStation,
            XBOX,
            All
        }

        enum EnGenreVideoGame
        {
            Action,
            Arcade,
            Adventure,
            Simulator,
            Sport,
            Strategy,
            RPG
        }

        enum EnGameMode
        {
            Singleplayer,
            Multiplayer,
            Both
        }

        enum EnStylistic
        {
            Modern,
            Cyberpunk,
            Fantasy,
            Space,
            Steampunk,
            Western
        }

        // --- Enum for Constructors ---
        enum EnMaterialConstructor
        {
            Metal,
            Plastic,
            Wood
        }

        // --- Enum for SoftToy ---
        enum EnMaterialSoftToy
        {
            Cloth,
            FauxFur
        }

        enum EnFillerSoftToy
        {
            Polyester
        }
    }
}
