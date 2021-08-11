namespace Tic_Tac_Toe
{
    public class PlayerMoveMaker
    {
        // This should be a 3 Step process.
        // Step 1: Who makes the Move
        //      This this decides the Symbol used, X for P1, O for P2
        // Step 2: Is the move legal
        //      A legal move is a move on a field that hasn't been used yet. We find that out by
        //      checking whether the number is still there. If not, we'll return a false in _legalMove
        // Step 3: Make the Move
        //      Final step, if the move is legal, we replace the number in the index with the players Symbol.//
        
        
        //Fields
        private readonly Grid _activeGrid;
        //Constructor
        public PlayerMoveMaker(Grid activeGrid)
        {
            _activeGrid = activeGrid;
        }

        //Step 2
        private char[] RowSelection(char position)
        {
            switch (position)
            {
                case '1':
                case '2':
                case '3':
                    return _activeGrid.RowThree;
                case '4':
                case '5':
                case '6':
                    return _activeGrid.RowTwo;
                case '7':
                case '8':
                case '9':
                    return _activeGrid.RowOne;
            }

            return null;
        }
        private bool IsLegalMove(char position, char[] activeRow)
        {
            for (int index = 0; index < 3; ++index)
            {
                if (position == activeRow[index])
                    return true;
            }
            return false;
        }
        
        //Step 3
        public void MakeMove(string player, char position)
        {
            if (IsLegalMove(position, RowSelection(position)))
            {
                switch (player)
                {
                    case "Player 1":
                        for (int index = 0; index < 3; ++index)
                        {
                            if (RowSelection(position)[index] == position)
                            {
                                RowSelection(position)[index] = 'X';
                                break;
                            }
                        }
                        break;
                    case "Player 2":
                        for (int index = 0; index < 3; ++index)
                        {
                            if (RowSelection(position)[index] == position)
                            {
                                RowSelection(position)[index] = 'O';
                                break;
                            }
                        }
                        break;
                }
            }
        }
    }
}