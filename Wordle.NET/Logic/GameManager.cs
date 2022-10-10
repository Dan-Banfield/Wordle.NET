using Wordle.NET.Forms;

namespace Wordle.NET.Logic
{
    public class GameManager
    {
        #region Game Data

        private int slotIndex = 0;

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
                    Backspace();
                    break;
                default:
                    PushCharacter(character);
                    break;
            }
        }

        public void Backspace()
        {
            slotIndex--;
            mainFormInstance.slots[slotIndex].Text = "";
        }

        private void PushCharacter(char character)
        {
            mainFormInstance.slots[slotIndex].Text = character.ToString();
            slotIndex++;
        }
    }
}