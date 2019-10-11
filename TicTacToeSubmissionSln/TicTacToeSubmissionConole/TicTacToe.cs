using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;




namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();

        }

        public void Run()
        {

            string player1 = "Fruit";
            string player2 = "Vegatables";



            Console.SetCursorPosition(2, 19);

            if (player1 == "Fruit")

            {

                Console.Write(player1);

                Console.SetCursorPosition(2, 20);

                Console.Write("Please Enter Row: ");
                var row = Console.ReadLine();


                Console.SetCursorPosition(2, 22);
                Console.Write("Please Enter Column: ");
                var column = Console.ReadLine();
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);


            }

            if (player2 == "Vegatables")

            {
                Console.SetCursorPosition(2, 19);


                Console.Write(player2);

                Console.SetCursorPosition(2, 20);

                Console.Write("Please Enter Row: ");
                var row = Console.ReadLine();

                //Console.SetCursorPosition(2, 22);
                Console.Write("Please Enter Column: ");
                var column = Console.ReadLine();

                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);


            }
            int index = 0;
            while (index < 9)
            {
                if (index % 2 == 0)
                {
                    Console.Write(player1);

                    Console.SetCursorPosition(2, 20);

                    Console.Write("Please Enter Row: ");
                    var row = Console.ReadLine();


                    Console.SetCursorPosition(2, 22);
                    Console.Write("Please Enter Column: ");
                    var column = Console.ReadLine();
                    _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
                }

                else

                {
                    Console.SetCursorPosition(2, 19);
                    Console.Write(player2);
                    Console.SetCursorPosition(2, 20);
                    Console.Write("Please Enter Row: ");
                    var row = Console.ReadLine();

                    //Console.SetCursorPosition(2, 22);
                    Console.Write("Please Enter Column: ");
                    var column = Console.ReadLine();

                    _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);
                }
                index++;
            }
        }
    }
}
