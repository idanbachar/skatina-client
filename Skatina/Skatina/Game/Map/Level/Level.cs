﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatina {
    public class Level {

        public string[,] LevelSchema; //Level's schema string matrix
        public List<Entity> LevelEntities; //Level's entities
        public int Fails; //Level's fails
        public Vector2 PlayerRespawnPosition; //Level's player respawn position

        /// <summary>
        /// Receives a level scheama string matrix and creats a level
        /// </summary>
        /// <param name="levelSchema"></param>
        public Level(string[,] levelSchema) {
            LevelSchema = levelSchema;
            Fails = 0;
            PlayerRespawnPosition = new Vector2(0, 0);
            LoadLevel();
        }

        /// <summary>
        /// Returns width of level
        /// </summary>
        /// <returns></returns>
        public int GetWidth() {
            return LevelSchema.GetLength(1) * Floor.Width;
        }

        /// <summary>
        /// Returns height of level
        /// </summary>
        /// <returns></returns>
        public int GetHeight() {
            return LevelSchema.GetLength(0) * Wall.Height;
        }

        /// <summary>
        /// Increase fails
        /// </summary>
        public void AddFail() {
            Fails++;
        }

        /// <summary>
        /// Loads level by level schema chars
        /// </summary>
        public void LoadLevel() {
            LevelEntities = new List<Entity>();

            for (int y = 0; y < LevelSchema.GetLength(0); y++) {
                for (int x = 0; x < LevelSchema.GetLength(1); x++) {
                    int xPos = 0;
                    int yPos = 0;
                    Entity entity;

                    switch (LevelSchema[y, x]) {
                        case "p":
                            PlayerRespawnPosition = new Vector2(x * Floor.Width + Player.Width / 2, y * Wall.Height);
                            break;
                        case "_":
                            xPos = x * Floor.Width;
                            yPos = y * Floor.Width;
                            entity = new Floor(new Vector2(xPos, yPos), FloorType.Regular);
                            entity.LoadContent(Skatina.GameContent);
                            LevelEntities.Add(entity);
                            break;
                        case "_d":
                            xPos = x * Floor.Width;
                            yPos = y * Floor.Width;
                            entity = new Floor(new Vector2(xPos, yPos), FloorType.Deadly);
                            entity.LoadContent(Skatina.GameContent);
                            LevelEntities.Add(entity);
                            break;
                        case "<_>":
                            xPos = x * Floor.Width;
                            yPos = y * Floor.Width;
                            entity = new Floor(new Vector2(xPos, yPos), FloorType.Moving);
                            entity.LoadContent(Skatina.GameContent);
                            LevelEntities.Add(entity);
                            break;
                        case "_f":
                            xPos = x * Floor.Width;
                            yPos = y * Floor.Width;
                            entity = new Floor(new Vector2(xPos, yPos), FloorType.Finish);
                            entity.LoadContent(Skatina.GameContent);
                            LevelEntities.Add(entity);
                            break;
                        case "^_^":
                            xPos = x * Floor.Width;
                            yPos = y * Floor.Width;
                            entity = new Floor(new Vector2(xPos, yPos), FloorType.Jump);
                            entity.LoadContent(Skatina.GameContent);
                            LevelEntities.Add(entity);
                            break;
                        case "|":
                            xPos = LevelSchema[y, x - 1] == "_" ? x * Wall.Height + Wall.Width * 2 : x * Wall.Height;
                            yPos = y * Wall.Height - Wall.Width * 2;
                            entity = new Wall(new Vector2(xPos, yPos), WallType.Regular, Direction.Left);
                            entity.LoadContent(Skatina.GameContent);
                            LevelEntities.Add(entity);
                            break;
                        case "|d":
                            xPos = LevelSchema[y, x - 1] == "_" ? x * Wall.Height + Wall.Width * 2 : x * Wall.Height;
                            yPos = y * Wall.Height - Wall.Width * 2;
                            entity = new Wall(new Vector2(xPos, yPos), WallType.Deadly, Direction.Left);
                            entity.LoadContent(Skatina.GameContent);
                            LevelEntities.Add(entity);
                            break;
                        case "^|vL":
                            xPos = LevelSchema[y, x - 1] == "_" ? x * Wall.Height + Wall.Width * 2 : x * Wall.Height;
                            yPos = y * Wall.Height - Wall.Width * 2;
                            entity = new Wall(new Vector2(xPos, yPos), WallType.Moving, Direction.Left);
                            entity.LoadContent(Skatina.GameContent);
                            LevelEntities.Add(entity);
                            break;
                        case "^|vdL":
                            xPos = LevelSchema[y, x - 1] == "_" ? x * Wall.Height + Wall.Width * 2 : x * Wall.Height;
                            yPos = y * Wall.Height - Wall.Width * 2;
                            entity = new Wall(new Vector2(xPos, yPos), WallType.DeadlyMoving, Direction.Left);
                            entity.LoadContent(Skatina.GameContent);
                            LevelEntities.Add(entity);
                            break;
                        case "^|vR":
                            xPos = LevelSchema[y, x - 1] == "_" ? x * Wall.Height + Wall.Width * 2 : x * Wall.Height;
                            yPos = y * Wall.Height - Wall.Width * 2;
                            entity = new Wall(new Vector2(xPos, yPos), WallType.Moving, Direction.Right);
                            entity.LoadContent(Skatina.GameContent);
                            LevelEntities.Add(entity);
                            break;
                        case "^|vdR":
                            xPos = LevelSchema[y, x - 1] == "_" ? x * Wall.Height + Wall.Width * 2 : x * Wall.Height;
                            yPos = y * Wall.Height - Wall.Width * 2;
                            entity = new Wall(new Vector2(xPos, yPos), WallType.DeadlyMoving, Direction.Right);
                            entity.LoadContent(Skatina.GameContent);
                            LevelEntities.Add(entity);
                            break;
                    }
                }
            }
        }
    }
}
