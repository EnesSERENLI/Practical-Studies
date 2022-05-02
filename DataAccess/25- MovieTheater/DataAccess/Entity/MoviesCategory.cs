namespace DataAccess.Entity
{
    public class MoviesCategory
    {
        public MoviesCategory()
        {

        }
        public MoviesCategory(int movieId, int categoryId)
        {
            MovieId = movieId;
            CategoryId = categoryId;
        }
        public int ID { get; set; }

        //Mapping
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
