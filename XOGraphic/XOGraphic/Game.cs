using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace XOGraphic

{
    public class Game
    {
        private const int RowCount = 3;
        private const int ColumnCount = 3;
        private const int PlayersCount = 2;

        Player.PType[,] GamePath = new Player.PType[RowCount, ColumnCount];
        int round, roundStarter;
        int turn;
        bool roundFlag;
        int filledCount;

        public Player[] players = new Player[PlayersCount];
        public bool RoundFlag { get => roundFlag; set => roundFlag = value; }
        public int Turn { get => turn; set => turn = value; }

        public Game()
        {
            roundStarter = Turn = 0;
            for (int i = 0; i < PlayersCount; i++)
            {
                players[i] = new Player((Player.PType)(i));
            }
            ClearField();
        }


        public override string ToString()
        {
            string s = "";
            s += ("Round: " + round + "\n");
            s += "Score:\t";
            for (int i = 0; i < PlayersCount; i++)
            {
                s += players[i].playerName + ": " + players[i].Score + "\t";
            }
            s += "Turn: " + players[Turn % 2].playerName + " as "  + (Player.PType)(Turn % 2) + "\n";
            return s;
        }

        private void IndexTo2D(int i, out int row, out int col)
        {
            row = i / ColumnCount;
            col = i % RowCount;
        }
        public bool Next(int i)
        {
            Player p = players[Turn % players.Length];
            int r, c;
            IndexTo2D(i, out r, out c);
            if (GamePath[r, c] != Player.PType.Empty)
            {
                return false;
            }

            GamePath[r, c] = p.Type;

            filledCount++;
            if (CheckforWinner())
            {
                p.Score++;
                round++;
                ClearField();
                RoundFlag = true;
            }
            else
            {
                if (IsFilled())
                {
                    round++;
                    Turn = (++roundStarter);
                    ClearField();
                    RoundFlag = true;
                }
                else
                {
                    Turn++;
                }
            }
            
            return true;
        }

        private void ClearField()
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    GamePath[i, j] = Player.PType.Empty;
                }
            }

            filledCount = 0;
        }


        public void DrawGame(Graphics g, int w, int h)
        {
            DrawFields(g, w, h);
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    if (GamePath[i, j] == Player.PType.X)
                        DrawX(g, i * ColumnCount + j, w, h, (w / (RowCount * 2)));
                    else if (GamePath[i, j] == Player.PType.O)
                        DrawO(g, i * ColumnCount + j, w, h, (w / (ColumnCount * 2)));
                }
            }
        }


        private void DrawFields(Graphics graphics, int Width, int Height)
        {
            Pen p = new Pen(Color.Black, 9);
            graphics.DrawLine(p, 0 / Width, Height / 3, Width, Height / 3);
            graphics.DrawLine(p, 0 / Width, Height / 1.5f, Width, Height / 1.5f);
            graphics.DrawLine(p, Width / 3, 0 / Height, Width / 3, Height);
            graphics.DrawLine(p, Width / 1.5f, 0 / Width, Width / 1.5f, Height);

        }

        private void I2Pos(int Width, int Height, int i, out int w, out int h)
        {
            int field_w = Width / RowCount;
            int field_h = Height / ColumnCount;
            int row = i / ColumnCount;
            int col = i % RowCount;
            w = ((col * field_w) + (field_h / 2) - field_w / RowCount);
            h = ((row * field_w) + (field_h / 2) - field_h / 2);
        }

        public void DrawX(Graphics graphics, int i, int Width, int Height, int font)
        {
           
            string str = "X";
            Font f = new Font("Tahoma", font);
            I2Pos(Width, Height, i, out int w, out int h);
            graphics.DrawString(str, f, Brushes.DarkBlue, w, h);

        }
        public void DrawO(Graphics graphics, int i, int Width, int Height, int font)
        {
         
            string str = "O";
            Font f = new Font("Tahoma", font);
            I2Pos(Width, Height, i, out int w, out int h);
            graphics.DrawString(str, f, Brushes.DarkRed, w, h);

        }

        private bool IsFilled()
        {
            return filledCount == (RowCount * ColumnCount);
        }
        private bool CheckforWinner()
        {


            for (int i = 0; i < RowCount; i++)
            {
                if (GamePath[i, 0] != Player.PType.Empty && (GamePath[i, 0] == GamePath[i, 1]) && (GamePath[i, 1] == GamePath[i, 2]))
                {
                    return true;
                }
            }
            for (int i = 0; i < ColumnCount; i++)
            {
                if (GamePath[0, i] != Player.PType.Empty && (GamePath[0, i] == GamePath[1, i]) && (GamePath[1, i] == GamePath[2, i]))
                {
                    return true;
                }
            }
            if (GamePath[0, 0] != Player.PType.Empty && (GamePath[0, 0] == GamePath[1, 1]) && (GamePath[1, 1] == GamePath[2, 2]))
            {
                return true;
            }
            if (GamePath[0, 2] != Player.PType.Empty && (GamePath[0, 2] == GamePath[1, 1]) && (GamePath[1, 1] == GamePath[2, 0]))
            {
                return true;
            }
            return false;
        }
    }
}

