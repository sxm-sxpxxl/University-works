using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLaboratory.Classes
{
    class Game : Good
    {
        protected int ageLimit;

        public Game(NS_Game.GameBuilder builder) : base(builder.GetName(), builder.GetPrice(), builder.GetManufacturerName())
        {
            this.ageLimit = builder.GetAgeLimit();
        }

        public Game(string name, double price, string manufacturerName, int ageLimit) : base(name, price, manufacturerName)
        {
            this.ageLimit = ageLimit;
        }

        public int GetAgeLimit() { return ageLimit; }

        public override object Clone()
        {
            return new Game(this.name, this.price, this.manufacturerName, this.ageLimit);
        }

        public new string GetInfo()
        {
            string result = base.GetInfo();
            result += "Age limit: " + ageLimit + Environment.NewLine;
            return result;
        }
    }

    namespace NS_Game
    {
        using ClassesLaboratory.Classes;
        class VideoGame : Game
        {
            private EnGamePlatform platform;
            private EnGenreVideoGame genre;
            private EnGameMode mode;
            private EnStylistic style;

            public VideoGame(VideoGameBuilder builder) : base(builder.GetName(), builder.GetPrice(), builder.GetManufacturerName(), builder.GetAgeLimit())
            {
                platform = builder.GetPlatform();
                genre = builder.GetGenre();
                mode = builder.GetMode();
                style = builder.GetStyle();
            }

            VideoGame(string name, double price, string manufacturerName, int ageLimit, EnGamePlatform platform,
                EnGenreVideoGame genre, EnGameMode mode, EnStylistic style) : base(name, price, manufacturerName, ageLimit)
            {
                this.platform = platform;
                this.genre = genre;
                this.mode = mode;
                this.style = style;
            }

            public override object Clone()
            {
                return new VideoGame(this.name, this.price, this.manufacturerName, this.ageLimit, this.platform, this.genre, this.mode, this.style);
            }

            public new string GetInfo()
            {
                string result = base.GetInfo();
                result += "Game platform: " + platform.ToString() + Environment.NewLine;
                result += "Genre: " + genre.ToString() + Environment.NewLine;
                result += "Mode: " + mode.ToString() + Environment.NewLine;
                result += "Style: " + style.ToString() + Environment.NewLine;
                return result;
            }
        }

        class ConstructorGame : Game
        {
            private int durationOfBuildInHour;
            private int countOfDetails;
            private EnMaterialConstructor material;
            private BaseInfoAboutGood bsInfo;

            public ConstructorGame(ConstructorBuilder builder) : base(builder.GetName(), builder.GetPrice(), builder.GetManufacturerName(), builder.GetAgeLimit())
            {
                durationOfBuildInHour = builder.GetDurationOfBuildInHour();
                countOfDetails = builder.GetCountOfDetails();
                material = builder.GetMaterial();
                bsInfo = builder.GetBsInfo();
            }

            ConstructorGame(string name, double price, string manufacturerName, int ageLimit, int durationOfBuildInHour,
                      int countOfDetails, EnMaterialConstructor material, BaseInfoAboutGood bsInfo) : base(name, price, manufacturerName, ageLimit)
            {
                this.durationOfBuildInHour = durationOfBuildInHour;
                this.countOfDetails = countOfDetails;
                this.material = material;
                this.bsInfo = bsInfo;
            }

            public override object Clone()
            {
                return new ConstructorGame(this.name, this.price, this.manufacturerName, this.ageLimit, this.durationOfBuildInHour, this.countOfDetails,
                    this.material, this.bsInfo);
            }

            public new string GetInfo()
            {
                string result = base.GetInfo();
                result += "Duration of build in hour: " + durationOfBuildInHour + Environment.NewLine;
                result += "Count of details: " + countOfDetails + Environment.NewLine;
                result += "Material: " + material + Environment.NewLine;
                result += bsInfo.GetInfo() + Environment.NewLine;
                return result;
            }
        }

        class SoftToy : Game
        {
            private EnMaterialSoftToy material;
            private EnFillerSoftToy filler;
            private BaseInfoAboutGood bsInfo;

            public SoftToy(SoftToyBuilder builder) : base(builder.GetName(), builder.GetPrice(), builder.GetManufacturerName(), builder.GetAgeLimit())
            {
                material = builder.GetMaterial();
                filler = builder.GetFiller();
                bsInfo = builder.GetBsInfo();
            }

            SoftToy(string name, double price, string manufacturerName, int ageLimit, EnMaterialSoftToy material,
                EnFillerSoftToy filler, BaseInfoAboutGood bsInfo) : base(name, price, manufacturerName, ageLimit)
            {
                this.material = material;
                this.filler = filler;
                this.bsInfo = bsInfo;
            }

            public override object Clone()
            {
                return new SoftToy(this.name, this.price, this.manufacturerName, this.ageLimit, this.material, this.filler, this.bsInfo);
            }

            public new string GetInfo()
            {
                string result = base.GetInfo();
                result += "Filler: " + filler + Environment.NewLine;
                result += "Material: " + material + Environment.NewLine;
                result += bsInfo.GetInfo() + Environment.NewLine;
                return result;
            }
        }
    }
}
