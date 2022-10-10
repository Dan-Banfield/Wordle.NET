using Wordle.NET.Forms;

namespace Wordle.NET.Logic
{
    public class GameManager
    {
        #region Game Data

        private int slotIndex = 1;

        #endregion

        private MainForm mainFormInstance;

        public GameManager(MainForm mainForm)
        {
            mainFormInstance = mainForm;
        }

        public void StartNewGame()
        {
            // TODO: Reset what needs to be reset when a game restarts.
        }

        public void SubmitCharacter(char character)
        {
            switch (character)
            {
                case '+':
                    break;
                case '-':
                    break;
                default:
                    PushCharacter(character);
                    break;
            }
        }

        public void Backspace()
        {
            // TODO: Add backspace functionality.
        }

        private void PushCharacter(char character)
        {
            switch (slotIndex)
            {
                case 1:
                    mainFormInstance.slot1.Text = character.ToString();
                    break;
                case 2:
                    mainFormInstance.slot2.Text = character.ToString();
                    break;
                case 3:
                    mainFormInstance.slot3.Text = character.ToString();
                    break;
                case 4:
                    mainFormInstance.slot4.Text = character.ToString();
                    break;
                case 5:
                    mainFormInstance.slot5.Text = character.ToString();
                    break;
                case 6:
                    mainFormInstance.slot6.Text = character.ToString();
                    break;
                case 7:
                    mainFormInstance.slot7.Text = character.ToString();
                    break;
                case 8:
                    mainFormInstance.slot8.Text = character.ToString();
                    break;
                case 9:
                    mainFormInstance.slot9.Text = character.ToString();
                    break;
            }
            slotIndex++;
        }
    }
}