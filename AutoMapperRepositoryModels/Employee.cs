namespace AutoMapperRepositoryModel
{
    //This is Repository Model - You will Portal Context and Base Entity Dependending on your Project
    public class Employee
    {
        //[PrimaryKey] - Entity Framework
        public int Id { get; set; }

        public string Name { get; set; }

        public string Designation { get; set; }
    }
}
