namespace L05_LINQ.Opg5_3
{
    static class Extensions
    {
        public static void SetAcceptedP(this List<Person> lst, Predicate<Person> pred)
        {
            var liste2 = lst.FindAll(pred);

            foreach (Person p in liste2)
            {
                p.Accepted = true;
            }

        }

        public static void Reset(this List<Person> lst)
        {
            foreach (Person p in lst)
            {
                p.Accepted = false;
            }
        }
    }
}
