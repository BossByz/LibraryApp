using MaterialDesignThemes.Wpf;
using System.Windows.Controls;

namespace POE_APP
{
    internal class TutorialNavigation
    {
        public static void Next(TutorialLinkedList tutorialLinkedList, Button BtnPrevious,
            Button BtnNext, TextBlock TxtTutorial, DialogHost TutorialDialog)
        {
            //ENABLE THE PREVIOUS BUTTON
            BtnPrevious.IsEnabled = true;

            //IF THE LINKEDLIST CONTAINS A NEXT VALUE
            if (tutorialLinkedList.Current.Next != null)
            {
                //UPDATE THE TEXT TO NEXT NODE
                TxtTutorial.Text = tutorialLinkedList.Current.Next.Data;
                //SET THE Current NODE TO THE NEXT NODE
                tutorialLinkedList.Current = tutorialLinkedList.Current.Next;
            }
            else
            {
                //CLOSE THE DIALOG SINCE THE TUTORIAL IS FINISHED
                TutorialDialog.IsOpen = false;
            }

            if (tutorialLinkedList.Current.Next == null)
            {
                //IF THE TUTORIAL IS ON THE LAST NODE, UPDATE THE NEXT BUTTON TEXT
                BtnNext.Content = "GOT IT";
            }
        }

        public static void Previous(TutorialLinkedList tutorialLinkedList, Button BtnPrevious,
            Button BtnNext, TextBlock TxtTutorial)
        {
            //IF THE LINKED LIST CONTAINS A PREVIOUS VALUE
            if (tutorialLinkedList.Current.Previous != null)
            {
                //UPDATE THE TEXT TO THE PREVIOUS NODE
                TxtTutorial.Text = tutorialLinkedList.Current.Previous.Data;
                //SET THE Current NODE TO THE PREVIOUS NODE
                tutorialLinkedList.Current = tutorialLinkedList.Current.Previous;
            }

            //UPDATE THE TEXT ON THE NEXT BUTTON
            BtnNext.Content = "NEXT";

            if (tutorialLinkedList.Current.Previous == null)
            {
                //DISABLE THE PREVIOUS BUTTON IF THERE ARE NO PREVIOUS NODES
                BtnPrevious.IsEnabled = false;
            }
        }
    }
}
