﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winnamespace;
using 오목목목;

namespace rules
{
    public static class rules
    {
        public static bool Three(STONE[,] board, int y, int x, STONE target)
        {
            return false;
        }


        public static bool OverFive(STONE [,] board, int y, int x, STONE target)//육목 체크해주는 함수
        {
            if (target == STONE.white)//육목은 흑돌만 금지하므로
                return false;
            
            int ruleflag = winclass.ruleflag;
            Console.WriteLine(ruleflag);
            if (ruleflag == 1)//가로 방향 육목 체크
            {
                if (x > 4)//왼쪽 체크
                {
                    if (board[y, x - 5] == target)
                        return true;
                }
                if (x != 18)//오른쪽 체크
                {
                    if (board[y, x + 1] == target)
                        return true;
                }
                return false;
            }

            else if (ruleflag == 2)//세로 방향 육목 체크
            {
                if (y > 4)//위에 체크
                {
                    if (board[y - 5, x] == target)
                        return true;
                }
                if (y != 18)//아래 체크
                {
                    if (board[y + 1, x] == target)
                        return true;
                }
                return false;
            }

            else if (ruleflag == 3)//오른쪽 아래 방향 육목 체크
            {
                if (y > 0 && x > 0)//왼쪽 위 체크
                {
                    if (board[y - 1, x - 1] == target)
                        return true;
                }
                if (y < 15 && x < 15)//오른쪽 아래 체크
                {
                    if (board[y + 5, x + 5] == target)
                    {
                        return true;
                    }
                }
                return false;
            }

            else if (ruleflag == 4)//왼쪽 아래 방향 육목 체크
            {
                if (x > 0 && y != 18)//왼쪽 아래 체크
                {
                    if (board[y + 1, x - 1] == target)
                        return true;
                }
                if (x < 15 && y > 4)//오른쪽 위에 체크
                {
                    if (board[y - 5, x + 5] == target)
                        return true;
                }
                return false;
            }

            return false; 
        }
    }
}
