using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOGraphic

{
    public class Player
    {
        PType type;
        public string playerName = "";
        public int Score { get => score; set => score = value; }
        public PType Type { get => type; }

        int score;
        public Player(PType t)
        {
            type = t;
            score = 0;
        }

        public enum PType {
            X,
            O,
            Empty
        }
       
    }

}
