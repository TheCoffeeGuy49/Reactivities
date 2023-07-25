namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; } //keep this as "Id" because its the name searched for when searching for primary key in db.

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string City { get; set; }

        public string Venue { get; set; }
    }
}