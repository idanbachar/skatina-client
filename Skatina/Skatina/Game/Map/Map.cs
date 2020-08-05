﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatina {
    public class Map {

        public int CurrentLevelIndex; //Current map's level index
        public Level[] Levels; //Map's levels array

        /// <summary>
        /// Creates a map with levels
        /// </summary>
        public Map() {
            Levels = new Level[5];
            CurrentLevelIndex = 0;
            Load();
        }

        /// <summary>
        /// Load levels in map
        /// </summary>
        public void Load() {
            Levels[0] = new Level(new string[,] {
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {"p"," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {"_","_","_","|d","_","_","^|vL","_"," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","|"," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","|"," ","_","^|vdL"," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","|"," ","_"," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," ","_","_"," "," ","<_>"," ", " ", "_f"},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "}
                });

            Levels[1] = new Level(new string[,] {
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {"p"," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {"_","_","_"," ","_","_","|"," "," "," "," "," "," "," ","^|vdL", " ", " "},
                {" "," "," "," "," "," ",""," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," ","_"," ","_","|"," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," ","_","|"," "," ","_"," "," "," "," ","^|vdL", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," ","_"," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," ","_","_"," ","<_>"," ","<_>"," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," ","_"," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," ","|", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", "_f", " "}
                });

            Levels[2] = new Level(new string[,] {
                {"p","|d"," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" ","|d"," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" ","|d"," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" ","|d"," "," "," "," "," "," "," "," ","^|vdL"," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","|d"," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","|d"," "," "," "," "," "," ", " ", " "},
                {"_"," ","_"," ","^_^","^_^"," ","_","|d"," ","^|vdL"," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," ","|d"," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," ","_","|d"," "," "," "," "," "," ", " ", "_f"},
                {" "," "," "," "," "," "," "," ","|d"," "," "," "," "," "," ", " ", "|d"},
                {" "," "," "," "," "," "," "," "," "," "," "," "," ","^|vdL"," ", " ", "|d"},
                {" "," "," "," "," "," "," ","<_>"," "," "," "," "," "," ","^_^", " ", "|d"},
                {" "," "," "," "," "," "," "," "," "," "," "," ","_","_"," ", "_", "|d"},
                {" "," "," "," "," "," "," "," "," ","<_>"," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "}
                });

            Levels[3] = new Level(new string[,] {
                {"p"," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {"_"," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" ","_"," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," ","_"," "," "," "," "," "," "," "," "," "," "," ","^|vdL", " ", " "},
                {" "," "," "," "," "," "," "," ","  "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," ","_"," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," ","_f"," "," "," "," "," ", " ", " "},
                {" "," ","^|vdR"," ","^_^","^_^","|d","^_^"," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "}
                });

            Levels[4] = new Level(new string[,] {
                {" ","|d"," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" ","|d"," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "},
                {" ","|d"," "," "," "," "," "," "," "," ","^|vdL"," "," "," "," ", " ", " "},
                {" ","|d"," "," "," "," ","<_>"," "," "," "," "," "," "," "," ", " ", " "},
                {"p"," "," "," "," ","|d"," "," ","|"," "," "," "," "," "," ", " ", " "},
                {"_"," "," "," "," "," "," "," ","|"," "," "," "," "," "," ", " ", " "},
                {" ","<_>"," "," ","^_^","^_^"," "," ","|"," "," "," "," "," "," ", " ", " "},
                {" "," "," "," "," "," "," "," "," "," ","_","<_>"," "," ","_f", " ", " "},
                {"_d","_d","_d","_d","_d","_d","_d","_d","_d","_d","_d","_d","_d","_d","_d", "_d", "_d"},
                {" "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", " ", " "}
                });
        }

        /// <summary>
        /// Go to next level
        /// </summary>
        public void NextLevel() {
            CurrentLevelIndex++;
        }

        /// <summary>
        /// Returns total tries
        /// </summary>
        /// <returns></returns>
        public int GetTotalTries() {
            int sumTries = 0;

            foreach (Level level in Levels)
                sumTries += (level.Fails);

            return sumTries;
        }

        /// <summary>
        /// Draw map
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch) {
            foreach (Entity entity in Levels[CurrentLevelIndex].LevelEntities) {
                if (entity != null)
                    entity.Draw(spriteBatch);
            }
        }
    }
}
