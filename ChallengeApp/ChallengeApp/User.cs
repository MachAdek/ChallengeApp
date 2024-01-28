namespace ChallengeApp
{
    public class Employee
    {

        private List<int> score = new List<int>();


        public Employee(string login, string password, int age)
        {
            this.Name = login;
            this.Surname = password;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
