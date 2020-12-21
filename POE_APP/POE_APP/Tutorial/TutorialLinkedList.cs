namespace POE_APP
{
    //LINKEDLIST CLASS
    internal class TutorialLinkedList
    {
        //FIELDS
        public TutorialNode Head;
        public TutorialNode Current;

        //ADD METHOD
        public void Add(string data)
        {
            //CREATE A NEW NODE
            TutorialNode tutorialNode = new TutorialNode(data);

            //IF THE Head (FIRST ITEM) DOES NOT EXIST
            if (Head == null)
            {
                //UPDATE THE Head
                Head = tutorialNode;
                Head.Next = null;
                Head.Previous = null;
                return;
            }

            //SET THE Current NODE TO THE Head NODE
            Current = Head;

            //WHILE THE NEXT NODE EXISTS
            while (Current.Next != null)
            {
                //SET THE Current NODE TO THE NEXT NODE
                Current = Current.Next;
            }

            //SET THE NEXT BLANK NODE TO THE ADDED NODE
            Current.Next = tutorialNode;
            //UPDATE THE PREVIOUS NODE OF THE ADDED NODE
            Current.Next.Previous = Current;
        }
    }
}
