//초기 셋팅 
using System;

    Console.ResetColor();       //컬러를 초기화 한다
    Console.CursorVisible = false;            //커서를 숨긴다
    Console.Title = "동기동기";         //타이틀을 설정한다
    Console.BackgroundColor = ConsoleColor.Red;      //배경색을 설정 한다
    Console.ForegroundColor = ConsoleColor.Cyan;         //글꼴색을 설정한다
    Console.Clear();                       //출력된 모든 내용을 지운다
                                           //게임 루프== 프레임 ( Frame)
    int playerX = 0;
    int playerY = 0;

int boxX = 5;
int boxY = 5;

while (true)
{
    Console.Clear();
    //  ------------------------------------Render----------------------
    //플레이어 출력 하기 
    Console.SetCursorPosition(playerX, playerY);
    Console.Write("p");

   
    Console.SetCursorPosition(boxX, boxY);
    Console.Write("o");

    //------------------------------------ProcessInput--------------


    ConsoleKey key = Console.ReadKey().Key;


    //-------------------------------UPdate------------------

    //오른쪽 화살표 키를 눌렀을때 
    if (key == ConsoleKey.RightArrow)
    // 오른쪽으로 이동
    {
        playerX = Math.Min(playerX + 1, 15);
    }

    if (key == ConsoleKey.LeftArrow)
    // 왼쪽으로 이동 
    {
        playerX = Math.Max(playerX - 1, 0);
    }

    if (key == ConsoleKey.UpArrow)
    // 위쪽으로 이동
    {
        playerY = Math.Max(0, playerY - 1);
    }

    if (key == ConsoleKey.DownArrow)
    // 아래쪽으로 이동
    {
        playerY = Math.Min(playerY + 1, 10);
    }

    if (playerX == boxX && playerY == boxY)     
    {
        boxX  ++ ;
    }
     else if (playerY == boxY && playerX == boxX)
        boxY ++ ;
}
