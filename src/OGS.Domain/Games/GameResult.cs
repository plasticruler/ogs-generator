using System;
using System.Collections.Generic;

namespace OGS.Domain
{
    public class Player{
        public int Id{get;set;}
        public string Username{get;set;}
        public string Country{get;set;}
        public string Icon{get;set;}
        public int Ranking{get;set;}
        public bool Professional{get;set;}

    }
    public class GameResult
    {
        public string Related {get;set;}
        public Dictionary<string, Player> Players{get;set;}
        public int Id{get;set;}
        public string Name{get;set;}
        public int Creator{get;set;}
        public string Mode{get;set;}
        public string Source{get;set;}
        public int Black {get;set;}
        public int White{get;set;}
        public int Width{get;set;}
        public int Height{get;set;}
        public string Rules{get;set;}
        public bool Ranked{get;set;}
        public int Handicap{get;set;}
        public string Time_Control{get;set;}
        public int Time_Per_Move{get;set;}
        public bool Disable_Analysis{get;set;}
        public string Tournament{get;set;}
        public string Ladder{get;set;}
        public bool Pause_On_Weekends{get;set;}
        public string Outcome{get;set;}
        public bool Black_Lost{get;set;}
        public bool White_List{get;set;}
        public bool Annulled{get;set;}
        public DateTime Started{get;set;}
        public DateTime? Ended{get;set;}
    }
}
