using System;
namespace Tic_Tac_Toe
{
    public class WinChecker
    {
        private static char[] _diagonalOne;
            private static char[] _diagonalTwo;
            private static char[] _horizontalOne;
            private static char[] _horizontalTwo;
            private static char[] _horizontalThree;
            private static char[] _verticalOne;
            private static char[] _verticalTwo;
            private static char[] _verticalThree;
            private readonly char[][] _toBeChecked = new[]
                {_horizontalOne, _horizontalTwo, _horizontalThree, _diagonalOne, _diagonalTwo, _verticalThree, _verticalTwo, _verticalOne};

            //Constructor

            public WinChecker(Grid grid)
            {
                _horizontalOne = grid.RowOne;
                _horizontalTwo = grid.RowTwo;
                _horizontalThree = grid.RowThree;
                _diagonalOne = new char[] {grid.FullGrid[0][0], grid.FullGrid[1][1], grid.FullGrid[2][2]};
                _diagonalTwo = new char[] {grid.FullGrid[0][2], grid.FullGrid[1][1], grid.FullGrid[2][0]};
                _verticalOne = new char[] {grid.FullGrid[0][0], grid.FullGrid[1][0], grid.FullGrid[2][0]};
                _verticalTwo = new char[] {grid.FullGrid[0][1], grid.FullGrid[1][1], grid.FullGrid[2][1]};
                _verticalThree = new char[] {grid.FullGrid[0][2], grid.FullGrid[1][2], grid.FullGrid[2][2]};
                HasSomebodyWon = false;    
            }

            private bool IsArrayFull(char[] array)
            {
                if (Array.TrueForAll(array, char.IsLetter))
                    return true;
                return false;
            }

            private bool IsArrayWon(char[] array)
            {
                if (IsArrayFull(array))
                    if (array[0] == array[1] && array[1] == array[2])
                        return true;
                return false;
            }

            private string WhoWon(char[] array)
            {
                if (IsArrayWon(array))
                    switch (array[0])
                    {
                        case 'X':
                            return "Player 1";
                        case 'O':
                            return "Player 2";
                    }

                return null;
            }

            public void FullCheck()
            {
                string winner = null;
                for (int check = 0; check < 4 && winner == null; ++check)
                {
                    if (IsArrayWon(_toBeChecked[check]))
                    {
                        HasSomebodyWon = true;
                        winner = WhoWon(_toBeChecked[check]);
                        whoWon = winner;
                    }
                }
            }
            
            //Properties
            public bool HasSomebodyWon { get; private set; }

            public string whoWon { get; private set; }
    }
}