using System.Linq;
using System.Threading.Tasks;

namespace POE_APP.Util
{
    public class MCQTestManager
    {
        //FINISH TEST METHOD
        public static void FinishTest(FindCallNumbersTest context)
        {
            //DISABLE BUTTON CLICKS
            context.buttonList.ForEach(_ => _.IsHitTestVisible = false);

            //WAIT 0.5 SECONDS AND OPEN THE RESULTS DIALOG
            _ = Task.Delay(500).ContinueWith(_ =>
              {
                  context.Dispatcher.Invoke(() =>
                  {
                      context.ResultDialog.IsOpen = true;
                      context.txtResultCorrect.Text = "Correct Answers\n\n" + string.Join("\n",
                          context.correctAnswers.Select(__ => __.Value));
                      context.txtResultScore.Text = "\nYou scored " + context.mark + " correct answers";

                      //ADD TO USERS SCORE
                      if (context.mark == 3) User.FindingCallNumbersPerfectScoreCount++;

                      User.FindingCallNumbersCorrectCount += context.mark;
                  });
              });
        }

        //NEXT QUESTION METHOD
        public static void NextQuestion(FindCallNumbersTest context)
        {
            //RESET VISUALS OF OPTION BUTTONS
            context.buttonList.ForEach(_ => _.IsHitTestVisible = true);
            context.buttonList.ForEach(_ => _.Background = context.color);

            //CLEAR THE POSSIBLE ANSWERS LIST AND ADD THE CORRECT ANSWER
            context.possibleAnswers.Clear();
            context.possibleAnswers.Add(context.correctAnswers[context.level].Value);

            //ADD THREE RANDOM WRONG ANSWERS
            while (context.possibleAnswers.Count != 4)
            {
                TreeNode<string> randomAnswer = null;

                //PICK A RANDOM CALL NUMBER FROM THE SELECTED LEVEL
                switch (context.level)
                {
                    case 0:
                        randomAnswer = context.root.Nodes[Generation.random.Next(0, context.root.Nodes.Count)];
                        break;
                    default:
                        randomAnswer = context.correctAnswers[context.level - 1].Children[Generation.random.Next
                            (0, context.correctAnswers[context.level - 1].Children.Count)];
                        break;
                }

                //ADD THE CALL NUMBER IF THE LIST DOES NOT CONTAIN IT
                if (!context.possibleAnswers.Contains(randomAnswer.Value))
                    context.possibleAnswers.Add(randomAnswer.Value);
            }

            //IF IT IS THE LAST LEVEL ADD ONLY THE CALL NUMBERS
            if (context.level == 2)
                context.possibleAnswers = context.possibleAnswers.Select(_ => _.Substring(0, 3)).ToList();

            //SORT THE CALL NUMBERS IN ORDER
            context.possibleAnswers.Sort();

            //SET THE CONTENT FOR EACH OPTION BUTTON
            context.buttonList.ForEach(_ => _.Content = context.possibleAnswers[context.buttonList.IndexOf(_)]);
        }
    }
}
