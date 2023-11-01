namespace Assign_Inheritence
{
    internal class Student
    {
        public readonly int rn;
        public string name;
        public Student()
        {
            rn = 20;
                
        }
        public Student(int rn ,string name) {
            this.rn = rn;
            this.name = name;
        }
        public void GetDetails()
        {
            //Console.WriteLine("enter rn : ");
            //int rollno = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name : ");
            name = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"rn : {rn} \n name : {name}");
        }
    }
}