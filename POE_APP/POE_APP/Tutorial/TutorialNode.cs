namespace POE_APP
{
    //NODE CLASS
    internal class TutorialNode
    {
        //FIELDS
        public TutorialNode Next;
        public TutorialNode Previous;
        public string Data;

        //CONSTRUCTOR USED TO ADD DATA
        public TutorialNode(string data)
        {
            Data = data;
        }
    }
}
