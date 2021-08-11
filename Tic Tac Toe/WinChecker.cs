using System;

namespace Tic_Tac_Toe
{
    public class WinChecker
    {
        // Fields
        private bool _isThereAWinner;
        private string _whoWon;
        private readonly Grid _grid;

        // Constructor
        public WinChecker(Grid grid)
        {
            _grid = grid;
        }

        //Methods
        public void WinCheck()
        {
            int y = 0;
            int x;
            for (x = 0; x < 3; ++x)
                if (_grid.FullGrid[x][y] == _grid.FullGrid[x][y + 1] &&
                    _grid.FullGrid[x][y + 1] == _grid.FullGrid[x][y + 2]) //Horizontal
                {
                    _isThereAWinner = true;
                    switch (_grid.FullGrid[x][y])
                    {
                        case 'X':
                            _whoWon = "Player 1";
                            break;
                        case 'O':
                            _whoWon = "Player 2";
                            break;
                    }
                    break;
                }

            x = 0;
            for (y = 0; y < 3; ++y)
                if (_grid.FullGrid[x][y] == _grid.FullGrid[x + 1][y] &&
                    _grid.FullGrid[x + 1][y] == _grid.FullGrid[x + 2][y]) //Vertical
                {
                    _isThereAWinner = true;
                    switch (_grid.FullGrid[x][y])
                    {
                        case 'X':
                            _whoWon = "Player 1";
                            break;
                        case 'O':
                            _whoWon = "Player 2";
                            break;
                    }
                    break;
                }

            if (_grid.FullGrid[0][0] == _grid.FullGrid[1][1] &&
                _grid.FullGrid[1][1] == _grid.FullGrid[2][2]) //Diagonal 1
            {
                _isThereAWinner = true;
                switch (_grid.FullGrid[0][0])
                {
                    case 'X':
                        _whoWon = "Player 1";
                        break;
                    case 'O':
                        _whoWon = "Player 2";
                        break;
                }
            }

            if (_grid.FullGrid[0][2] == _grid.FullGrid[1][1] &&
                _grid.FullGrid[1][1] == _grid.FullGrid[2][0]) //Diagonal 2
            {
                _isThereAWinner = true;
                switch (_grid.FullGrid[0][2])
                {
                    case 'X':
                        _whoWon = "Player 1";
                        break;
                    case 'O':
                        _whoWon = "Player 2";
                        break;
                }
            }
        }

        public void LossCheck()
        {
            int fullFields = 0;
            
            for (int field = 0; field < 3; ++field)
            {
                if (char.IsLetter(_grid.RowOne[field]))
                    ++fullFields;
                if (char.IsLetter(_grid.RowTwo[field]))
                    ++fullFields;
                if (char.IsLetter((_grid.RowThree[field])))
                    ++fullFields;
            }
            
            if (fullFields > 8)
            {
                _isThereAWinner = true;
                _whoWon = "Nobody";
            }
            

        }

        // Properties

        public string WhoWon => _whoWon;
        public bool IsThereAWinner => _isThereAWinner;

    }
}
