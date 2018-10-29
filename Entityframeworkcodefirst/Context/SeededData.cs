using Entityframeworkcodefirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.Provider;

namespace Entityframeworkcodefirst.Context
{
    public class SeededData
    {
        public static List<Team> getTeams()
        {
            List<Team> teams = new List<Team>
            {
                new Team()
                {
                    TeamName = "Sunrisers",
                    Type = "Batting",
                    province = "Hyderabad",
                    Country = "India"

                },
                new Team()
                {
                    TeamName = "Superkings",
                    Type = "Fielding",
                    province = "Chennai",
                    Country = "India"

                },
                new Team()
                {
                    TeamName = "Indians",
                    Type = "Bowling",
                    province = "Mumbai",
                    Country = "India"

                }
            };
            return teams;
        }

        public static List<Player> getPlayers(GameContext game)
        {
            List<Player> players = new List<Player>
            {
                new Player()
                {
                    FirstName="Sachin",
                    LastName="Tendulkar",
                    Position = "Batting",
                    TeamName = game.Teams.Find("Sunrisers").TeamName

                },
                new Player()
                {
                    FirstName="MS",
                    LastName="Dhoni",
                    Position = "Batting",
                    TeamName = game.Teams.Find("Indians").TeamName

                },
                new Player()
                {
                    FirstName="Virat",
                    LastName="Kohli",
                    Position = "Batting",
                    TeamName = game.Teams.Find("Superkings").TeamName
                }
            };
            return players;
        }
    }
}