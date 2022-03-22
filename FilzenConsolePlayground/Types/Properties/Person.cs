namespace FilzenConsolePlayground.Types.Properties
{
    class Person
    {
        private string name; //field

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        //You can also use automatic setters.
        //public string Name  // property
        //{ get; set; }
    }
}