
namespace MyFirstProject

{

    public class MathProblam
    {
        #region property
        public string? Name;
        public int Number;

        public int PhoneNumber;
        public string? Address { get; set; }
        #endregion

        public MathProblam(string? name, int number, int phoneNumber, string? address)
        {
            Name = name;
            Number = number;
            PhoneNumber = phoneNumber;
            Address = address;
        }
        public MathProblam()
        {

        }



        public int somOfNumber(int v1, int phonenumber)
        {
            return v1 + phonenumber;
        }
    }

}






