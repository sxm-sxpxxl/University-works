using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLaboratory.Classes
{

    class GoodBuilder
    {
        private string name;
        private double price;
        private string manufacturerName;

        public GoodBuilder SetName(string name) { this.name = name; return this; }
        public GoodBuilder SetPrice(double price) { this.price = price; return this; }
        public GoodBuilder SetManufacturerName(string manufacturerName) { this.manufacturerName = manufacturerName; return this; }

        public string GetName() { return name; }
        public double GetPrice() { return price; }
        public string GetManufacturerName() { return manufacturerName; }

        public Good Build() { return new Good(this); }
    }

    namespace NS_Game
    {

        class GameBuilder : GoodBuilder
        {
            private int ageLimit;

            public GameBuilder SetAgeLimit(int ageLimit) { this.ageLimit = ageLimit; return this; }
            public int GetAgeLimit() { return ageLimit; }
            public new Game Build() { return new Game(this); }
        }

        class VideoGameBuilder : GameBuilder
        {
            private EnGamePlatform platform;
            private EnGenreVideoGame genre;
            private EnGameMode mode;
            private EnStylistic style;

            public VideoGameBuilder SetPlatform(EnGamePlatform platform) { this.platform = platform; return this; }
            public VideoGameBuilder SetGenre(EnGenreVideoGame genre) { this.genre = genre; return this; }
            public VideoGameBuilder SetMode(EnGameMode mode) { this.mode = mode; return this; }
            public VideoGameBuilder SetStyle(EnStylistic style) { this.style = style; return this; }

            public EnGamePlatform GetPlatform() { return platform; }
            public EnGenreVideoGame GetGenre() { return genre; }
            public EnGameMode GetMode() { return mode; }
            public EnStylistic GetStyle() { return style; }

            public new VideoGame Build() { return new VideoGame(this); }
        }

        class ConstructorBuilder : GameBuilder
        {
            private int durationOfBuildInHour;
            private int countOfDetails;
            private EnMaterialConstructor material;
            private BaseInfoAboutGood bsInfo;

            public ConstructorBuilder SetDurationOfBuildInHour(int durationOfBuildInHour) { this.durationOfBuildInHour = durationOfBuildInHour; return this; }
            public ConstructorBuilder SetCountOfDetails(int countOfDetails) { this.countOfDetails = countOfDetails; return this; }
            public ConstructorBuilder SetMaterial(EnMaterialConstructor material) { this.material = material; return this; }
            public ConstructorBuilder SetBsInfo(BaseInfoAboutGood bsInfo) { this.bsInfo = bsInfo; return this; }

            public int GetDurationOfBuildInHour() { return durationOfBuildInHour; }
            public int GetCountOfDetails() { return countOfDetails; }
            public EnMaterialConstructor GetMaterial() { return material; }
            public BaseInfoAboutGood GetBsInfo() { return bsInfo; }

            public new ConstructorGame Build() { return new ConstructorGame(this); }
        }

        class SoftToyBuilder : GameBuilder
        {
            private EnMaterialSoftToy material;
            private EnFillerSoftToy filler;
            private BaseInfoAboutGood bsInfo;

            public SoftToyBuilder SetMaterial(EnMaterialSoftToy material) { this.material = material; return this; }
            public SoftToyBuilder SetFiller(EnFillerSoftToy filler) { this.filler = filler; return this; }
            public SoftToyBuilder SetBsInfo(BaseInfoAboutGood bsInfo) { this.bsInfo = bsInfo; return this; }

            public EnMaterialSoftToy GetMaterial() { return material; }
            public EnFillerSoftToy GetFiller() { return filler; }
            public BaseInfoAboutGood GetBsInfo() { return bsInfo; }

            public new SoftToy Build() { return new SoftToy(this); }
        }
    }

    class ProductBuilder : GoodBuilder
    {
        private Nutrients nutrients;
        private BaseInfoAboutGood bsInfo;

        public ProductBuilder SetNutrients(Nutrients nutrients) { this.nutrients = nutrients; return this; }
        public ProductBuilder SetBsInfo(BaseInfoAboutGood bsInfo) { this.bsInfo = bsInfo; return this; }

        public Nutrients GetNutrients() { return nutrients; }
        public BaseInfoAboutGood GetBsInfo() { return bsInfo; }

        public new Product Build() { return new Product(this); }
    }

    class DairyProductBuilder : ProductBuilder
    {
        public new DairyProduct Build() { return new DairyProduct(this); }
    }
}